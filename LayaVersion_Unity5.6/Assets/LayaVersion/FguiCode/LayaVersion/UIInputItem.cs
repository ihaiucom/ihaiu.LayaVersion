/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace LayaVersion
{
	public partial class UIInputItem : GLabel
	{
		public Controller m_buttonVisiable;
		public GTextField m_title;
		public UITextInput m_value;
		public UIButton m_button;

		public const string URL = "ui://4yrap86wjw3e16";

		public static UIInputItem CreateInstance()
		{
			return (UIInputItem)UIPackage.CreateObject("LayaVersion","InputItem");
		}

		public UIInputItem()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_buttonVisiable = this.GetControllerAt(0);
			m_title = (GTextField)this.GetChildAt(0);
			m_value = (UITextInput)this.GetChildAt(1);
			m_button = (UIButton)this.GetChildAt(2);
		}
	}
}