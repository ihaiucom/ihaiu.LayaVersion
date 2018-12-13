/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace LayaVersion
{
	public partial class UINumericInput : GLabel
	{
		public Controller m_c1;
		public Controller m_grayed;
		public GImage m_n0;
		public GImage m_n4;
		public GGraph m_holder;
		public GTextInput m_title;

		public const string URL = "ui://4yrap86wjw3e11";

		public static UINumericInput CreateInstance()
		{
			return (UINumericInput)UIPackage.CreateObject("LayaVersion","NumericInput");
		}

		public UINumericInput()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_c1 = this.GetControllerAt(0);
			m_grayed = this.GetControllerAt(1);
			m_n0 = (GImage)this.GetChildAt(0);
			m_n4 = (GImage)this.GetChildAt(1);
			m_holder = (GGraph)this.GetChildAt(2);
			m_title = (GTextInput)this.GetChildAt(3);
		}
	}
}