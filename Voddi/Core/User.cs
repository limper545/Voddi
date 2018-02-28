using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

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
            if (string.IsNullOrEmpty(user))
            {
                throw new ArgumentException("message", nameof(user));
            }

            Name = user;
            ID = id;
        }

        public static User CreateUser(List<Tuple<String, String>> list)
        {
            Contract.Ensures(Contract.Result<User>() != null);
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            return list != null ? new User(list[0x0].Item1, Convert.ToByte(list[0].Item2)) : null;
        }
    }
}