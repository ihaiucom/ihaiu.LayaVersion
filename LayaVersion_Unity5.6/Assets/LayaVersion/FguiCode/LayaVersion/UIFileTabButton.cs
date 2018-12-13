/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace LayaVersion
{
	public partial class UIFileTabButton : GButton
	{
		public Controller m_button;
		public GImage m_n5;
		public GImage m_n4;
		public GTextField m_title;
		public UITabCloseButton m_closeButton;
		public GLoader m_icon;

		public const string URL = "ui://4yrap86wjw3ed";

		public static UIFileTabButton CreateInstance()
		{
			return (UIFileTabButton)UIPackage.CreateObject("LayaVersion","FileTabButton");
		}

		public UIFileTabButton()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_button = this.GetControllerAt(0);
			m_n5 = (GImage)this.GetChildAt(0);
			m_n4 = (GImage)this.GetChildAt(1);
			m_title = (GTextField)this.GetChildAt(2);
			m_closeButton = (UITabCloseButton)this.GetChildAt(3);
			m_icon = (GLoader)this.GetChildAt(4);
		}
	}
}