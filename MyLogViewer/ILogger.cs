using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLogViewer
{
    public interface ILogger
    {
        List<LogEntity> GetLogContent(string strPath);

    }
}
