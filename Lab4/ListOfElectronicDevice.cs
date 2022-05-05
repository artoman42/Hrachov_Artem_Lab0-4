using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class ListOfElectronicDevice
    {
        private List<ElectronicDevice> MainList = new List<ElectronicDevice>();
        public void Add(ElectronicDevice item)
        {
            MainList.Add(item);
        }

        public void Remove(int index)
        {
            try
            {
                MainList.RemoveAt(index);
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
        }
        public void Clear()
        {
            MainList.Clear();
        }

        public string GetKeyboard(int index)
        {
            return MainList[index].GetKeyboardColor();
        }
        public void Reboot(int index)
        {
            MainList[index].Reboot();
        }
        public int GetCount()
        {
            return MainList.Count;
        }
    }

    
}
