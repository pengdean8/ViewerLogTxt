using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MyLogViewer
{
    public partial class Form1 : Form
    {
        private List<ListViewItem> m_TotalViewItems = new List<ListViewItem>();
        private List<ListViewItem> m_hListViewItems;
        private object _lockobj = new object();
        Point m_MBRpt;//鼠标右键点击时Point
        string strCopyText = string.Empty;
        string _strFilePath = @"D:\log\ServiceTool\logfile.txt";
        Queue<string> QueueLog = new Queue<string>();
        string[] logFields = new string[3];
        int intLineNumber = 0;
        public string strFilePath
        { 
            get
            {
                return _strFilePath;
            }
            set
            {
                _strFilePath = value;
                lbFilePathValue.Text = _strFilePath;
            }
        }


        public Form1()
        {
            InitializeComponent();
            m_hListViewItems = new List<ListViewItem>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetLogContent(strFilePath);
            m_TotalViewItems.AddRange(m_hListViewItems);
        }

        private void GetLogContent(string strPath)
        {
            StringBuilder strFileContent = new StringBuilder();
            StreamReader objReader = new StreamReader(strPath, System.Text.Encoding.GetEncoding("gb2312"));
            //string strContent = objReader.ReadToEnd().Replace("\r\n   "," ");

            m_hListViewItems.Clear();
            string strCurrentLineContent = string.Empty;
            string[] logFields = new string[3];
            intLineNumber = 0;
            while ((strCurrentLineContent = objReader.ReadLine()) != null)
            {
                QueueLog.Enqueue(strCurrentLineContent);
                
            }

            AddListViewItem(QueueLog);

            QueueLog.Clear();

            if (intLineNumber <= 0)
            {
                m_hListViewItems.Clear();
            }

            objReader.Close();

            //下面代码写得不好，会导致内存溢出,但下面写法方便
            //string[] arrLineContent = strContent.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            //string[] logFields = new string [3];
            //if (arrLineContent.Length < 2)
            //{
            //    m_hListViewItems.Clear();
            //}
            //else
            //{
            //    for (int i = 0; i < arrLineContent.Length; i++)
            //    {
            //        logFields = arrLineContent[i].Split('|');
            //        if (logFields.Length < 3)
            //        {
            //            continue;
            //        }

            //        m_hListViewItems.Add(new ListViewItem(new string[] { logFields[0], logFields[1], logFields[2] }));
            //    }
            //}



            lisLogMessage.RetrieveVirtualItem += new RetrieveVirtualItemEventHandler(listView_RetrieveVirtualItem);
            lisLogMessage.SearchForVirtualItem += new SearchForVirtualItemEventHandler(listView1_SearchForVirtualItem);

            lisLogMessage.VirtualListSize = m_hListViewItems.Count;
            lisLogMessage.VirtualMode = true;
            lisLogMessage.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
        }


        private void AddListViewItem(Queue<string> logQueue)
        {
            int SperatorCount = 0;
            string strNextLineContent = string.Empty;
            while (logQueue.Count > 0)
            {
                string strCurrentLineContent = logQueue.Dequeue();
                
                strCurrentLineContent.Replace("\r\n   ", " ");

                if (strCurrentLineContent != string.Empty && strCurrentLineContent.IndexOf("|") < 0)
                {
                    strNextLineContent += strCurrentLineContent;
                    continue;
                }
                else
                {
                    SperatorCount++; //当一条记录占有几行时，只有前面的数据含有|，后面的记录的才可以累加
                    if (SperatorCount > 1)
                    {
                        logFields = strNextLineContent.Split('|');
                        if (logFields.Length >= 3)
                        {
                            intLineNumber++;
                            m_hListViewItems.Add(new ListViewItem(new string[] { intLineNumber.ToString(), logFields[0], logFields[1], logFields[2] }));
                            SperatorCount = 0;
                        }
                    }
                    strNextLineContent = strCurrentLineContent;

                   
                }
            }
            logFields = strNextLineContent.Split('|');
            if (logFields.Length == 3)
            {
                intLineNumber++;
                m_hListViewItems.Add(new ListViewItem(new string[] { intLineNumber.ToString(), logFields[0], logFields[1], logFields[2] }));
            }
         }


        void listView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (this.m_hListViewItems == null || this.m_hListViewItems.Count == 0)
            {
                return;
            }

            e.Item = this.m_hListViewItems[e.ItemIndex];
            if (e.ItemIndex == this.m_hListViewItems.Count)
            {
                this.m_hListViewItems = null;
            }
            //e.Item = m_hListViewItems[e.ItemIndex];
        }

        private void lisLogMessage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lisLogMessage.FocusedItem != null)//这个if必须的，不然会得到值但会报错
            {
                strCopyText = this.lisLogMessage.FocusedItem.SubItems[3].Text;
                txtMessageValue.Text = strCopyText;
                //MessageBox.Show(this.lisLogMessage.FocusedItem.SubItems[0].Text);
            } 
        }

        ListViewItem lvi = null;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //ListViewItem foundItem =
            //lisLogMessage.FindItemWithText(txtSearchText.Text, false, 0, true);
            //if (foundItem != null)
            //{
            //    lisLogMessage.TopItem = foundItem;

            //}
            if (lvi != null)
            {
                lvi.SubItems[3].ForeColor = Color.Black;
                //lvi.ForeColor = Color.Black;
            }
            lvi = lisLogMessage.FindItemWithText(txtSearchText.Text);

            //Select the item found and scroll it into view. 
            if (lvi != null)
            {
                //this.lisLogMessage.TopItem = lvi;  //定位到该项
                lvi.UseItemStyleForSubItems = false;
                lvi.SubItems[3].ForeColor = Color.Red;
                lisLogMessage.SelectedIndices.Add(lvi.Index);
                lisLogMessage.EnsureVisible(lvi.Index);
            }

        }

       


        private int CurrentIndex = -1;
        string strSearchText = string.Empty;
        //This event handler enables search functionality, and is called 
        //for every search request when in Virtual mode. 
        void listView1_SearchForVirtualItem(object sender, SearchForVirtualItemEventArgs e)
        {
            //We've gotten a search request. 
            //In this example, finding the item is easy since it's 
            //just the square of its index.  We'll take the square root 
            //and round. 
            //double x = 0;
            //if (Double.TryParse(e.Text, out x)) //check if this is a valid search
            //{
            //    x = Math.Sqrt(x);
            //    x = Math.Round(x);
            //    e.Index = (int)x;

            //}
            //If e.Index is not set, the search returns null. 
            //Note that this only handles simple searches over the entire 
            //list, ignoring any other settings.  Handling Direction, StartIndex, 
            //and the other properties of SearchForVirtualItemEventArgs is up 
            //to this handler.
            lock (_lockobj)
            {
                if (strSearchText != e.Text.ToLower())
                {
                    CurrentIndex = -1;
                }
                if (CurrentIndex == m_hListViewItems.Count - 1)
                {
                    if (MessageBox.Show("You have searched all test,Did you research?", "LogView", MessageBoxButtons.YesNo) == DialogResult.OK)
                    {
                        CurrentIndex = -1;
                    }
                    
                }
                strSearchText = e.Text.ToLower();
                for (int i = CurrentIndex + 1; i < m_hListViewItems.Count; i++)
                {
                    string strMessage = m_hListViewItems[i].SubItems[3].Text;
                    strMessage = strMessage.ToLower();
                    if (strMessage.IndexOf(strSearchText) >= 0)
                    {
                        CurrentIndex = e.Index = i;
                        return;
                    }
                }
                // no item found, so continue from top
                for (int i = 0; i < CurrentIndex + 1; i++)
                {
                    string strMessage = m_hListViewItems[i].SubItems[3].Text;
                    strMessage = strMessage.ToLower();
                    if (strMessage.IndexOf(strSearchText) >= 0)
                    {
                        e.Index = i;
                        return;
                    }
                }

            }

            //string s = e.Text.ToLower();
            //if (e.Direction == SearchDirectionHint.Down)
            //{
            //    for (int i = e.StartIndex; i < list.Count; i++)
            //    {
            //        FileData f = (FileData)list[i];
            //        string fname = Path.GetFileName(f.Filename).ToLower();
            //        if (fname.StartsWith(s))
            //        {
            //            e.Index = i;
            //            return;
            //        }
            //    }
            //    // no item found, so continue from top
            //    for (int i = 0; i < e.StartIndex; i++)
            //    {
            //        FileData f = (FileData)list[i];
            //        string fname = Path.GetFileName(f.Filename).ToLower();
            //        if (fname.StartsWith(s))
            //        {
            //            e.Index = i;
            //            return;
            //        }
            //    }
            //}
            //else // assume up
            //{
            //    for (int i = e.StartIndex; i >= 0; i--)
            //    {
            //        FileData f = (FileData)list[i];
            //        string fname = Path.GetFileName(f.Filename).ToLower();
            //        if (fname.StartsWith(s))
            //        {
            //            e.Index = i;
            //            return;
            //        }
            //    }
            //    // no item found, so continue from bottom
            //    for (int i = list.Count - 1; i < e.StartIndex; i--)
            //    {
            //        FileData f = (FileData)list[i];
            //        string fname = Path.GetFileName(f.Filename).ToLower();
            //        if (fname.StartsWith(s))
            //        {
            //            e.Index = i;
            //            return;
            //        }
            //    }
            //}


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //need refresh interface
            //if (chkError.Checked && chkWarn.Checked && chkInfo.Checked && chkDebug.Checked)
            //{
            //    m_hListViewItems = m_TotalViewItems.Where(r => r.SubItems[1].Text == LogLevel.Error.ToString() && r.SubItems[1].Text == LogLevel.Warn.ToString() && r.SubItems[1].Text == LogLevel.Info.ToString() && r.SubItems[1].Text == LogLevel.Info.ToString()).ToList();
            //}
            lock (_lockobj)
            {
                m_hListViewItems.Clear();
                m_hListViewItems.AddRange(m_TotalViewItems);


                if (!chkDebug.Checked)
                {
                    m_hListViewItems = m_hListViewItems.Where(r => r.SubItems[2].Text != LogLevel.Debug.ToString()).ToList();
                }

                if (!chkInfo.Checked)
                {
                    m_hListViewItems = m_hListViewItems.Where(r => r.SubItems[2].Text != LogLevel.Info.ToString()).ToList();
                }

                if (!chkWarn.Checked)
                {
                    m_hListViewItems = m_hListViewItems.Where(r => r.SubItems[2].Text != LogLevel.Warn.ToString()).ToList();
                }

                if (!chkError.Checked)
                {
                    m_hListViewItems = m_hListViewItems.Where(r => r.SubItems[2].Text != LogLevel.Error.ToString()).ToList();
                }

                lisLogMessage.VirtualListSize = m_hListViewItems.Count;
                this.lisLogMessage.Refresh();
                CurrentIndex = -1;
            }
        }



        public void SetClipboardText(string strText)
        {
            try
            {
                Clipboard.SetDataObject(strText);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void COPYITEM_Click(object sender, EventArgs e)
        {
            //复制指定表格单元格的内容
            if (lisLogMessage.SelectedItems.Count <= 0)
            {
                MessageBox.Show("没有选中交易信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            // 得到屏幕鼠标的坐标，转换为列表控件的坐标标(在鼠标按下时就去处理并保存)
            //Point pt = listView1.PointToClient(m_MBRpt);


            ListViewItem lstrow = lisLogMessage.GetItemAt(m_MBRpt.X, m_MBRpt.Y);
            System.Windows.Forms.ListViewItem.ListViewSubItem lstcol = lstrow.GetSubItemAt(m_MBRpt.X, m_MBRpt.Y);
            string strText = lstcol.Text;
            //设置到粘贴板
            SetClipboardText(strText);


        }



        private void lisLogMessage_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
            //    // 得到屏幕鼠标的坐标，转换为列表控件的坐标标
            //    contextCopyMenu.Show(Control.MousePosition);
            //    // m_MBRpt = lisLogMessage.PointToClient(Control.MousePosition);
            //    SetClipboardText(strCopyText);
            //}
            //else
            //{
            //    strCopyText = string.Empty;
            //}
        }

        private void opneFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = this.openLogFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                strFilePath = openLogFileDialog.FileName;
            }
            GetLogContent(strFilePath);
            m_TotalViewItems.AddRange(m_hListViewItems);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(strFilePath, FileMode.Create, FileAccess.Write);
            fs.Close();
            GetLogContent(strFilePath);
            m_TotalViewItems.AddRange(m_hListViewItems);
        }

        private void freshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_hListViewItems.Clear();
            GetLogContent(strFilePath);
            m_TotalViewItems.AddRange(m_hListViewItems);
        }






    }
}
