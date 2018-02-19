using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class User
    {
        public String Name { get; set; }
        public byte ID { get; set; }
        public User()
        {

        }

        public User(String user, byte id)
        {
            this.Name = user;
            this.ID = id;
        }

        public static User CreateUser(List<Tuple<String, String>> list)
        {
            if (list != null)
            {
                return new User(list[0].Item1, Convert.ToByte(list[0].Item2));
            } 
            else
            {
                return null;
            }

        }
    }
}
