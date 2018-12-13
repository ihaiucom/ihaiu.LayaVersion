/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace LayaVersion
{
	public partial class UIContentTabButton : GButton
	{
		public Controller m_button;
		public GImage m_n4;
		public GImage m_n5;
		public GTextField m_title;

		public const string URL = "ui://4yrap86wjw3eg";

		public static UIContentTabButton CreateInstance()
		{
			return (UIContentTabButton)UIPackage.CreateObject("LayaVersion","ContentTabButton");
		}

		public UIContentTabButton()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_button = this.GetControllerAt(0);
			m_n4 = (GImage)this.GetChildAt(0);
			m_n5 = (GImage)this.GetChildAt(1);
			m_title = (GTextField)this.GetChildAt(2);
		}
	}
}