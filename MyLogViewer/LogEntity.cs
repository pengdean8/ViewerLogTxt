using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLogViewer
{
    public class LogEntity
    {
        public string strloglevel;
        public string strdatetime;
        public string strMessage;
    }

    public enum LogLevel
    {
        Error,
        Warn,
        Info,
        Debug
    }
}
