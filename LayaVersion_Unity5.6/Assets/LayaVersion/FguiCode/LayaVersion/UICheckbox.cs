/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace LayaVersion
{
	public partial class UICheckbox : GButton
	{
		public Controller m_button;
		public GImage m_n1;
		public GImage m_n2;
		public GImage m_n3;
		public GTextField m_title;
		public GImage m_n7;

		public const string URL = "ui://4yrap86wjw3ej";

		public static UICheckbox CreateInstance()
		{
			return (UICheckbox)UIPackage.CreateObject("LayaVersion","Checkbox");
		}

		public UICheckbox()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_button = this.GetControllerAt(0);
			m_n1 = (GImage)this.GetChildAt(0);
			m_n2 = (GImage)this.GetChildAt(1);
			m_n3 = (GImage)this.GetChildAt(2);
			m_title = (GTextField)this.GetChildAt(3);
			m_n7 = (GImage)this.GetChildAt(4);
		}
	}
}