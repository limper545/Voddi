using System;
using System.Collections.Generic;

namespace Core
{
    public class Classes
    {
        public String Name { get; set; }
        public byte ID { get; set; }

        public Classes(String name, byte id)
        {
            Name = name;
            ID = id;
        }

        public static List<Classes> FillListWithClasses(List<Tuple<String, String>> list)
        {
            var classesList = new List<Classes>();
            foreach (Tuple<String, String> item in list)
            {
                classesList.Add(new Classes(item.Item1, Convert.ToByte(item.Item2)));
            }

            return classesList;
        }
    }
}