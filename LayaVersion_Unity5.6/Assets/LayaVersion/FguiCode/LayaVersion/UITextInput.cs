/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace LayaVersion
{
	public partial class UITextInput : GLabel
	{
		public Controller m_grayed;
		public GImage m_n0;
		public GImage m_n4;
		public GTextInput m_title;

		public const string URL = "ui://4yrap86wjw3e12";

		public static UITextInput CreateInstance()
		{
			return (UITextInput)UIPackage.CreateObject("LayaVersion","TextInput");
		}

		public UITextInput()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_grayed = this.GetControllerAt(0);
			m_n0 = (GImage)this.GetChildAt(0);
			m_n4 = (GImage)this.GetChildAt(1);
			m_title = (GTextInput)this.GetChildAt(2);
		}
	}
}