/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace LayaVersion
{
	public partial class UIButton : GButton
	{
		public Controller m_button;
		public Controller m_grayed;
		public GImage m_n1;
		public GImage m_n2;
		public GImage m_n3;
		public GTextField m_title;

		public const string URL = "ui://4yrap86wjw3el";

		public static UIButton CreateInstance()
		{
			return (UIButton)UIPackage.CreateObject("LayaVersion","Button");
		}

		public UIButton()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_button = this.GetControllerAt(0);
			m_grayed = this.GetControllerAt(1);
			m_n1 = (GImage)this.GetChildAt(0);
			m_n2 = (GImage)this.GetChildAt(1);
			m_n3 = (GImage)this.GetChildAt(2);
			m_title = (GTextField)this.GetChildAt(3);
		}
	}
}