using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_work_with_Files_by_Adapter_pattern_in_MVVM.Models.Adapter
{
    class Application_File
    {
        private readonly Converter _converter;

        public Application_File(IAdapter adapter)
        {
            _converter = new Converter(adapter);
        }

        public void Start()
        {
            _converter.WriteFile();
            _converter.ReadFile();

        }

    }
}
