using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Classes
    {
        public String Name { get; set; }
        public byte ID { get; set; }
        public Classes(String name, byte id)
        {
            this.Name = name;
            this.ID = id;
        }

        public static List<Classes> FillListWithClasses(List<Tuple<String, String>> list)
        {
            List<Classes> classesList = new List<Classes>();
            foreach (Tuple<String, String> item in list)
            {
                classesList.Add(new Classes(item.Item1, Convert.ToByte(item.Item2)));
            }

            return classesList;
        }
    }
}
