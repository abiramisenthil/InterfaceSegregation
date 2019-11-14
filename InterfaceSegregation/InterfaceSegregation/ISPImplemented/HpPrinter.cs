using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.ISPImplemented
{
    public class HpPrinter : IPrinterTask , IPrintDuplex
    {
        public bool PrintContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool ScanContent(string content)
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
