using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_work_with_Files_by_Adapter_pattern_in_MVVM.Models.Adapter
{
    class XML_Adapter : IAdapter
    {
        XML_File _XML_File;
        public void Read()
        {
            _XML_File.XML_Deserialize();
        }

        public XML_Adapter(XML_File XML_File)
        {
            _XML_File = XML_File;
        }
        public void Write()
        {
            _XML_File.XML_Serialize();
        }
    }
}
