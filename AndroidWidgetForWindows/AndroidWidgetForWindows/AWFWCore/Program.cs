using CommandLine;
using System.Diagnostics;
class Program
{
    private static Fileordirectory isfod { get; set; }
    private Parsed<Options> parsed { get; set; }
    private Options opt = null;
    //**メイン**
    static void Main(string[] args)
    {
        // ジェネリクスでオプションクラスを指定し、パースする
        var parseResult = Parser.Default.ParseArguments<Options>(args);

        switch (parseResult.Tag)
        {
            // パース成功
            case ParserResultType.Parsed:
                Options opt = null;
                Parsed<Options> parsed = parseResult as Parsed<Options>;
                opt = parsed.Value;
                string strOthers = string.Concat("{ ", string.Join(", ", opt.Others.Select(e => $"\"{e}\"")), " }");
                Console.WriteLine(opt.path);
                isfod = IsFod(opt.path);
                bool IsSecond = new[] { opt.Add, opt.Delete, opt.Change }.Count(x => x) >= 2;
                bool Iszero = new[] { opt.Add, opt.Delete, opt.Change }.Count(x => x) == 0;
                //a,d,cの引数のboolがゼロか調べる
                if (Iszero) { Console.WriteLine("Please choos in -c,-d,-a."); }
                if (IsSecond) { Console.WriteLine("secondplus"); } else if (Iszero) { Console.WriteLine("zero"); } else { Console.WriteLine("one"); }
                Core core = new Core();
                switch (isfod)
                {
                    case Fileordirectory.None:
                        Console.WriteLine("input path.");
                        break;
                    case Fileordirectory.File:
                        Console.WriteLine($"File path = {opt.path}");
                        core.windowopen(opt.path);

                        break;
                    case Fileordirectory.Directory:
                        Console.WriteLine($"Directory path = {opt.path}");
                        break;
                }
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
        Fileordirectory Fod;
        if (System.IO.File.Exists(path)) { Fod = Fileordirectory.File; }
        else if (System.IO.Directory.Exists(path)) { Fod = Fileordirectory.Directory; }
        else { Fod = Fileordirectory.None; }
        return Fod;
    }

}
