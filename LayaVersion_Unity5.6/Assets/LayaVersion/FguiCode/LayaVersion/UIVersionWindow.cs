/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace LayaVersion
{
	public partial class UIVersionWindow : GComponent
	{
		public GImage m_bg;
		public UIMainMenuBar m_mainMenuBar;
		public UIProjectMenuBar m_projectMenuBar;
		public UIContentMenuBar m_contentMenuBar;
		public UIPageBody m_pageBody;
		public UICreateProductPage m_createProductPage;

		public const string URL = "ui://4yrap86woulr0";

		public static UIVersionWindow CreateInstance()
		{
			return (UIVersionWindow)UIPackage.CreateObject("LayaVersion","VersionWindow");
		}

		public UIVersionWindow()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_bg = (GImage)this.GetChildAt(0);
			m_mainMenuBar = (UIMainMenuBar)this.GetChildAt(1);
			m_projectMenuBar = (UIProjectMenuBar)this.GetChildAt(2);
			m_contentMenuBar = (UIContentMenuBar)this.GetChildAt(3);
			m_pageBody = (UIPageBody)this.GetChildAt(4);
			m_createProductPage = (UICreateProductPage)this.GetChildAt(5);
		}
	}
}