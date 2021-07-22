using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_work_with_Files_by_Adapter_pattern_in_MVVM.Models.Adapter
{
    class JSON_Adapter : IAdapter
    {
        JSON_File _JSON_File;
        public void Read()
        {
            _JSON_File.JSON_Deserialize();
        }

        public JSON_Adapter(JSON_File JSON_File)
        {
            _JSON_File = JSON_File;
        }
        public void Write()
        {
            _JSON_File.JSON_Serialize();
        }
    }
}
