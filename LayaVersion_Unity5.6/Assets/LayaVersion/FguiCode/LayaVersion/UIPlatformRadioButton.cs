/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace LayaVersion
{
	public partial class UIPlatformRadioButton : GButton
	{
		public Controller m_button;
		public GLoader m_icon;
		public GImage m_n1;
		public GImage m_n3;
		public GImage m_n2;

		public const string URL = "ui://4yrap86wjw3ex";

		public static UIPlatformRadioButton CreateInstance()
		{
			return (UIPlatformRadioButton)UIPackage.CreateObject("LayaVersion","PlatformRadioButton");
		}

		public UIPlatformRadioButton()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_button = this.GetControllerAt(0);
			m_icon = (GLoader)this.GetChildAt(0);
			m_n1 = (GImage)this.GetChildAt(1);
			m_n3 = (GImage)this.GetChildAt(2);
			m_n2 = (GImage)this.GetChildAt(3);
		}
	}
}