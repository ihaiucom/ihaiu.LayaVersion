/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
using System;
using System.Collections;
using System.Collections.Generic;

namespace LayaVersion
{
    public enum WindowTabType
    {
        CreateProjectPage,
        ProjectPage
    }

    public partial class UIVersionWindow 
    {
        public TabCtr windowTabCtr;

        public void Init()
        {
            UIVersion.window = this;
            InitTab();

            m_createProductPage.Init();
        }


        public void InitTab()
        {
            windowTabCtr = new TabCtr();

            windowTabCtr.RegisterTab(WindowTabType.CreateProjectPage, m_createProductPage);

            windowTabCtr.RegisterTab(WindowTabType.ProjectPage, m_contentMenuBar);
            windowTabCtr.RegisterTab(WindowTabType.ProjectPage, m_pageBody);

            windowTabCtr.OpenTab(WindowTabType.CreateProjectPage);


        }
    }
}
