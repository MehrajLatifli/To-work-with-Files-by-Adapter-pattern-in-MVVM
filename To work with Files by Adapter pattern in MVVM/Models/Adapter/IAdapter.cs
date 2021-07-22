using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_work_with_Files_by_Adapter_pattern_in_MVVM.Models.Adapter
{
    interface IAdapter
    {
        void Write();
        void Read();
    }
}
