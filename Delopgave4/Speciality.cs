using System.Collections.ObjectModel;

namespace Delopgave4
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
