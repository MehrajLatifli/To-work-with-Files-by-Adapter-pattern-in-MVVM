using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_work_with_Files_by_Adapter_pattern_in_MVVM.Models.Adapter
{
    class Converter
    {
        private readonly IAdapter _adapter;

        public Converter(IAdapter adapter)
        {
            _adapter = adapter;
        }

        public void WriteFile()
        {
            _adapter.Write();
        }

        public void ReadFile()
        {
            _adapter.Read();
        }
    }
}
