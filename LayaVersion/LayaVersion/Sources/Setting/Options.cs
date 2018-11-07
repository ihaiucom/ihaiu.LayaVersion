using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CommandLine;

public class Options
{
    // 运行完，是否自动关闭cmd
    [Option("autoEnd", Required = false, Default = true)]
    public bool autoEnd { get; set; }

    // 命令
    [Option("cmd", Required = false, Default = "mergejs")]
    public string cmd { get; set; }

    // 启动参数设置 配置路径
    [Option("optionSetting", Required = false, Default = "./ReleaseLaya.json")]
    public string optionSetting { get; set; }

    // laya项目路径
    [Option("layaProject", Required = false, Default = "E:/zengfeng/GamePF/Gidea-PF-Client/GamePF")]
    public string layaProject { get; set; }

    // laya项目发布过度路径
    [Option("binCache", Required = false, Default = "E:/wamp/www/GamePF/bin-cache")]
    public string binCache { get; set; }


    // 忽略文件
    [Option("ignorePaths", Required = false, Default = new string[] { "js/"})]
    public string[] ignorePaths { get; set; }

    // 忽略文件后缀
    [Option("ignoreExes", Required = false, Default = new string[] { ".map" })]
    public string[] ignoreExes { get; set; }


    public void Save(string path = null)
    {
        if (string.IsNullOrEmpty(path))
            path = "./ReleaseLaya.json";

        string json = JsonHelper.ToJsonType(this);
        File.WriteAllText(path, json);
    }

    public static Options Load(string path = null)
    {
        if (string.IsNullOrEmpty(path))
            path = "./ReleaseLaya.json";

        string json = File.ReadAllText(path);
        Options options = JsonHelper.FromJson<Options>(json);
        return options;
    }
}


public class OptionsMinConfig
{
    public string[] paths;
    public string savePath;


}