using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class StringAr
    {
        private static int length = 5;
        private int index;
        public List<string> ar = new List<string>();
        public static int Length { get { return length; } }
        public int Index { get { return index; } set { index = value; } }
        public StringAr(int index, List<string> ar)
        {
            this.index = index;
            for(int i=0;i<ar.Count(); i++)
            {
                this.ar.Add(ar[i]);
            }
        }
        public string getElement(int index)
        {
           return ar[index];
        }
        public static StringAr Consolid(StringAr first, StringAr second, int last_ind)
        {
            bool fl = false;
            List<string> ob_ar = new List<string>();
            ob_ar.AddRange(first.ar);
            for(int i=0;i<second.ar.Count();i++ )
            {
                fl = false;
                for(int j = 0; j < first.ar.Count(); j++)
                {
                    if (second.ar[i] == first.ar[j]) { fl = true; break; }
                    else continue;
                }
                if (fl) continue;
                else ob_ar.Add(second.ar[i]);
            }
            
            StringAr ob = new StringAr(last_ind,ob_ar);
            return ob;
        }
        public void serialize()
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(@"D:\KPI\ОП 2\Lab_1\test.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, this);
               
            }
        }

        public static StringAr DeSerialize(int ind)
        {
            StringAr ob = JsonConvert.DeserializeObject<StringAr>(File.ReadAllText(@"D:\KPI\ОП 2\Lab_1\test.json"));
            ob.index = ind;
            return ob;
        }
}
}
