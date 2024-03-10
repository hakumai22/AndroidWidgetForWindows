using CommandLine;
using System.Diagnostics;
namespace AWFW
{
    class Program
    {
        private static Fileordirectory isfod { get; set; }
        private Parsed<Options> parsed { get; set; }
        private Options? opt = null;
        private static Core core { get; set; }
        //**メイン**
        public Program()
        {
            
        }
        static void Main(string[] args)
        {
            // ジェネリクスでオプションクラスを指定し、パースする
            var parseResult = Parser.Default.ParseArguments<Options>(args);

            switch (parseResult.Tag)
            {
                // パース成功
                case ParserResultType.Parsed:
                    test(parseResult);
                    break;

                case ParserResultType.NotParsed:
                    // パースの成否でパース結果のオブジェクトの方が変わる
                    var notParsed = parseResult as NotParsed<Options>;
                    Console.WriteLine("error");
                    break;
            }
        }

        //ファイルかディレクトリかを確認する
        //Fileordirectory -> Fod(インスタンス)
        private enum Fileordirectory
        {
            File, Directory, None
        }
        static Fileordirectory IsFod(string path)
        {
            //ファイルかディレクトリかを調べる
            Fileordirectory Fod;
            if (System.IO.File.Exists(path)) { Fod = Fileordirectory.File; }
            else if (System.IO.Directory.Exists(path)) { Fod = Fileordirectory.Directory; }
            else { Fod = Fileordirectory.None; }
            return Fod;
        }
        static void test(ParserResult<Options> parseResult)
        {
            core = new Core();
            core.windowopen();
            Options opt = null;
            Parsed<Options> parsed = parseResult as Parsed<Options>;
            opt = parsed.Value;
            //対象外の引数を整形する
            string strOthers = string.Concat("{ ", string.Join(", ", opt.Others.Select(e => $"\"{e}\"")), " }");
            //パスを表示する(-p等)
            Console.WriteLine(opt.path);
            isfod = IsFod(opt.path); ;
            //.Count()を使うことでboolがどれくらいあるかを調べる
            bool IsSecond = new[] { opt.Add, opt.Delete, opt.Change }.Count(x => x) >= 2;
            bool Iszero = new[] { opt.Add, opt.Delete, opt.Change }.Count(x => x) == 0;
            int argskazu = new[] { opt.Add, opt.Delete, opt.Change }.Count(x => x);
            Console.WriteLine(argskazu);
            //a,d,cの引数のboolがゼロか調べる
            //if (Iszero) { Console.WriteLine("Please choos in -c,-d,-a."); }
            if (IsSecond) { Console.WriteLine("secondplus"); } else if (Iszero) { Console.WriteLine("zero"); } else { Console.WriteLine("one"); }
            switch (isfod)
            {
                case Fileordirectory.None:
                    Console.WriteLine("input path.");
                    break;
                case Fileordirectory.File:
                    Console.WriteLine($"File path = {opt.path}");
                    core.windowopen(
                        //opt.path
                        );

                    break;
                case Fileordirectory.Directory:
                    Console.WriteLine($"Directory path = {opt.path}");
                    break;
            }
            
        }
    }
}