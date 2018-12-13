/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace LayaVersion
{
	public partial class UIMainMenuBar : GComponent
	{
		public GImage m_n1;
		public GList m_list;

		public const string URL = "ui://4yrap86wjw3e4";

		public static UIMainMenuBar CreateInstance()
		{
			return (UIMainMenuBar)UIPackage.CreateObject("LayaVersion","MainMenuBar");
		}

		public UIMainMenuBar()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_n1 = (GImage)this.GetChildAt(0);
			m_list = (GList)this.GetChildAt(1);
		}
	}
}