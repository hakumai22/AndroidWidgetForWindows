using CommandLine;

enum HogeInfo
{
    Hoge, Fuga, Piyo
}

class Options
{
    //パスを選ぶ
    [Option('p', "path", Required = false, HelpText = "パスを入力")]
    public string path { set; get; }
    [Value(1, MetaName = "Others")]
    public IEnumerable<string> Others { get; set; }
    [Option('a', "add", Default = (bool)false)]
    public bool Add { get; set; }
    [Option('d', "delete", Default = (bool)false)]
    public bool Delete { get; set; }
    [Option('c', "change", Default = (bool)false)]
    public bool Change { get; set; }
    [Option('g', "get", Default = (bool)false)]
    public bool Get { get; set; }
    [Option('t', "trans", Default = (bool)false)]
    public bool Transform { get; set; }


}






class Commets
{
    /*/ -a と -aaa の二つ指定可能
[Option('a', "aaa", Required = false, HelpText = "Aの説明です。")]
public string A { get; set; }
// string 以外でも受け取れる（この場合はオプションがあるかどうか）
[Option('b', "bbb", Required = false, HelpText = "Bの説明です。")]
public bool B { get; set; }
// Sepalatorで指定下文字を区切り文字として、複数の値を渡せる
[Option('c', "ccc", Separator = ',', HelpText = "Cの説明です。")]
public IEnumerable<string> C { get; set; }
// enumもいける（Hoge, Fuga などと指定する）
[Option('d', "ddd", HelpText = "Cの説明です。")]
public HogeInfo D { get; set; }

// 上記指定以外のオプションや文字列が入る

*/

}