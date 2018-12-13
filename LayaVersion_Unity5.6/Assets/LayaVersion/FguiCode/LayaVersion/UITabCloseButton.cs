/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace LayaVersion
{
	public partial class UITabCloseButton : GButton
	{
		public Controller m_button;
		public GImage m_n1;
		public GImage m_n2;

		public const string URL = "ui://4yrap86wjw3ec";

		public static UITabCloseButton CreateInstance()
		{
			return (UITabCloseButton)UIPackage.CreateObject("LayaVersion","TabCloseButton");
		}

		public UITabCloseButton()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_button = this.GetControllerAt(0);
			m_n1 = (GImage)this.GetChildAt(0);
			m_n2 = (GImage)this.GetChildAt(1);
		}
	}
}