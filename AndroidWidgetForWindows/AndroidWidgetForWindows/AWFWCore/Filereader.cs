using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace AWFWCore
{
    internal class Filereader
    {
        static internal int jsonver {  get; set; }
        static internal string Temppath = "%Temp%/AWFW";
        internal void ToTemp(string path)
        {
            if (!Directory.Exists(Temppath)) { Directory.CreateDirectory(Temppath); } else { Console.WriteLine("Directory.Exists(\"%Temp%/AWFW\") = true."); }
            File.Move(path,Temppath);
        }
        internal void verchecker()
        {
            string numberString = "123";
            if (int.TryParse(numberString, out int result))
            {
                Console.WriteLine(result); // 出力: 123
            }
            else
            {
                Console.WriteLine("変換に失敗しました。");
            }
        }
    }
    //Filereader => Fr(abbreviation)
    namespace ver1fr
    {
        internal class WidgetSample
        {
            public string Name { get; set; }
            public VersionInfo Version { get; set; }
        }

        internal class VersionInfo
        {
            public string Core { get; set; }
            public string Jsonver { get; set; }
        }

    }
}
