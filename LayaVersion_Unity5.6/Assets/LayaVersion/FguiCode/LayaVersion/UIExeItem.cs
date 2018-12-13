/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace LayaVersion
{
	public partial class UIExeItem : GComponent
	{
		public UICheckbox m_n1;
		public UIButton m_n4;

		public const string URL = "ui://4yrap86wjw3em";

		public static UIExeItem CreateInstance()
		{
			return (UIExeItem)UIPackage.CreateObject("LayaVersion","ExeItem");
		}

		public UIExeItem()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_n1 = (UICheckbox)this.GetChildAt(0);
			m_n4 = (UIButton)this.GetChildAt(1);
		}
	}
}