/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace LayaVersion
{
	public partial class UIAppPage : GComponent
	{
		public GGraph m_n21;
		public UIBigButton m_exeSelectedButton;
		public UIExeList m_exeList;
		public UITag m_n6;
		public UITag m_n10;
		public GList m_n14;
		public GTextField m_n16;
		public UITextInput m_version;
		public GTextField m_n19;
		public UICheckbox m_n20;
		public GTextField m_n22;
		public UICheckbox m_n23;
		public UIExeList m_exeList_2;
		public UITag m_n29;
		public UIBigButton m_exeSelectedButton_2;

		public const string URL = "ui://4yrap86wjw3eo";

		public static UIAppPage CreateInstance()
		{
			return (UIAppPage)UIPackage.CreateObject("LayaVersion","AppPage");
		}

		public UIAppPage()
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
			m_n14 = (GList)this.GetChildAt(5);
			m_n16 = (GTextField)this.GetChildAt(6);
			m_version = (UITextInput)this.GetChildAt(7);
			m_n19 = (GTextField)this.GetChildAt(8);
			m_n20 = (UICheckbox)this.GetChildAt(9);
			m_n22 = (GTextField)this.GetChildAt(10);
			m_n23 = (UICheckbox)this.GetChildAt(11);
			m_exeList_2 = (UIExeList)this.GetChildAt(12);
			m_n29 = (UITag)this.GetChildAt(13);
			m_exeSelectedButton_2 = (UIBigButton)this.GetChildAt(14);
		}
	}
}