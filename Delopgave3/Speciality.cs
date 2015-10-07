using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delopgave3
{
    class Speciality : ObservableCollection<string>
    {
        public  Speciality()
        {
            Add("Assassination");
            Add("CodeGenius");
            Add("BabyMaker");
            Add("IceCreamMaker");
            Add("Systematicer");
        }
    }
}
