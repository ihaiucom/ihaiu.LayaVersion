using CommandLine;
using System;
using System.IO;


public class CmdType
{
    // 生成资源版本 md5码
    public const string assetversion = "assetversion";
}

public class Setting
{
    public static Options Options { get; set; }
    public static string cmd = CmdType.assetversion;

    public static void Init(string[] args)
    {
        bool useSetting = args.Length == 0;
        foreach (string op in args)
        {
            if (op.StartsWith("--optionSetting"))
            {
                useSetting = true;
                break;
            }
        }

        Parse(args);

        if(!File.Exists(Options.optionSetting))
        {
            Options.Save(Options.optionSetting);
        }


        cmd = Options.cmd;
        if (string.IsNullOrEmpty(cmd))
        {
            cmd = CmdType.assetversion;
        }

        //if (useSetting)
        {
            Options = Options.Load(Options.optionSetting);
        }
    }


    public static void Parse(string[] args)
    {
        Parser.Default.ParseArguments<Options>(args)
            .WithNotParsed(error => throw new Exception($"命令行格式错误!"))
            .WithParsed(options =>
            {
                Options = options;
            });
    }




    public static string MergeRoot
    {
        get
        {
            return Options.binCache + "/js-merge";
        }
    }

    public static string MinRoot
    {
        get
        {
            return Options.binCache + "/js-min";
        }
    }

    public static string MD5File
    {
        get
        {
            return Options.layaProject + "/bin/AssetVersion.json";
        }
    }


}