using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    class User
    {
        String Name { get; set; }
        byte ID { get; set; }
        public User(String user, byte id)
        {
            this.Name = user;
            this.ID = id;
        }
    }
}
