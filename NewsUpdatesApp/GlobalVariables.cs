using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WorldNewsDM
{
    class GlobalVariables
    {
        public static readonly string _path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\Files\Countries.json";
    }
}
