/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace LayaVersion
{
	public partial class UIWebPage : GComponent
	{
		public GGraph m_n21;
		public UIBigButton m_exeSelectedButton;
		public UIExeList m_exeList;
		public UITag m_n6;
		public UITag m_n10;
		public GTextField m_n16;
		public UITextInput m_version;

		public const string URL = "ui://4yrap86wjw3e14";

		public static UIWebPage CreateInstance()
		{
			return (UIWebPage)UIPackage.CreateObject("LayaVersion","WebPage");
		}

		public UIWebPage()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_n21 = (GGraph)this.GetChildAt(0);
			m_exeSelectedButton = (UIBigButton)this.GetChildAt(1);
			m_exeList = (UIExeList)this.GetChildAt(2);
			m_n6 = (UITag)this.GetChildAt(3);
			m_n10 = (UITag)this.GetChildAt(4);
			m_n16 = (GTextField)this.GetChildAt(5);
			m_version = (UITextInput)this.GetChildAt(6);
		}
	}
}