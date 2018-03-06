using System;

namespace GPAG.Commons.Utils.DataTypes
{
    public static class Conversion
    {
        public static byte[] StringToByteArray(string str)
        {
            byte[] bytearr = Convert.FromBase64String(str);
            return bytearr;
        }

        public static string ByteArrayToString(byte[] arr)
        {
            return Convert.ToBase64String(arr);
        }

    }
}
