using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        //注册EncodeProvider
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);



        Setting.Init(args);


        switch (Setting.cmd)
        {
            // 生成资源版本 md5码
            case CmdType.assetversion:
                new GenerateAssetVersionManager().Run();
                break;
        }

        Console.WriteLine("完成!");

        if (!Setting.Options.autoEnd)
            Console.Read();
    }


}