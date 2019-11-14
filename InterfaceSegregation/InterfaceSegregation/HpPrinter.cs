using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class HpPrinter:IPrinterTask
    {
        // Imagine that HP printer won't support Fax. In that case do we really need to implement that method here? use ISP
        public bool PrintContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool ScanContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool FaxContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool PhotoCopyContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool PrintDuplexContent(string content)
        {
            throw new NotImplementedException();
        }
    }
}
