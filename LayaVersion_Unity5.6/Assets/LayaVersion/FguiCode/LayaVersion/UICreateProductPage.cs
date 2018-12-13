/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace LayaVersion
{
	public partial class UICreateProductPage : GComponent
	{
		public GImage m_bg;
		public GGraph m_n21;
		public UITag m_n6;
		public UIInputItem m_n16;
		public UIBigButton m_createButton;
		public UIBigButton m_cancelButton;

		public const string URL = "ui://4yrap86wjw3e17";

		public static UICreateProductPage CreateInstance()
		{
			return (UICreateProductPage)UIPackage.CreateObject("LayaVersion","CreateProductPage");
		}

		public UICreateProductPage()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_bg = (GImage)this.GetChildAt(0);
			m_n21 = (GGraph)this.GetChildAt(1);
			m_n6 = (UITag)this.GetChildAt(2);
			m_n16 = (UIInputItem)this.GetChildAt(3);
			m_createButton = (UIBigButton)this.GetChildAt(4);
			m_cancelButton = (UIBigButton)this.GetChildAt(5);
		}
	}
}