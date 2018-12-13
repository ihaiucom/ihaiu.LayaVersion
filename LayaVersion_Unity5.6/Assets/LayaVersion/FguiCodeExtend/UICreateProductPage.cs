using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FairyGUI;
using FairyGUI.Utils;

namespace LayaVersion
{
    public partial class UICreateProductPage
    {
        public void Init()
        {
            m_createButton.onClick.Add(OnClickCreateButton);
            m_cancelButton.onClick.Add(OnClickCanneleButton);
        }

        private void OnClickCreateButton()
        {
            UIVersion.windowTabCtr.OpenTab(WindowTabType.ProjectPage);
        }


        private void OnClickCanneleButton()
        {
            UIVersion.windowTabCtr.OpenTab(WindowTabType.ProjectPage);
        }
    }
}
