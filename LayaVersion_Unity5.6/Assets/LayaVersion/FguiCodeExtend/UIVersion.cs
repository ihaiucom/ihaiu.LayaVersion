using LayaVersion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class UIVersion
{
    public static UIVersionWindow window;

    public static TabCtr windowTabCtr
    {
        get
        {
            return window.windowTabCtr;
        }
    }
}