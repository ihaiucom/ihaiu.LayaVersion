/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace LayaVersion
{
	public partial class UIPageBody : GComponent
	{
		public UIMergePage m_mergePage;
		public UIAppPage m_appPage;
		public UIPatchPage m_patchPage;
		public UIWebPage m_webPage;

		public const string URL = "ui://4yrap86wjw3eh";

		public static UIPageBody CreateInstance()
		{
			return (UIPageBody)UIPackage.CreateObject("LayaVersion","PageBody");
		}

		public UIPageBody()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_mergePage = (UIMergePage)this.GetChildAt(0);
			m_appPage = (UIAppPage)this.GetChildAt(1);
			m_patchPage = (UIPatchPage)this.GetChildAt(2);
			m_webPage = (UIWebPage)this.GetChildAt(3);
		}
	}
}