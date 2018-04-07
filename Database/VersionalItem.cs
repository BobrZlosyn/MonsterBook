using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class VersionalItem
    {
        protected static readonly uint DEFAULT_REVISION = 1;

        protected string ControlSum {  get; set; }
        public uint Version { get; set; } = DEFAULT_REVISION;

        protected string ComputeSum (string msg)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(msg);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }
    }
}
