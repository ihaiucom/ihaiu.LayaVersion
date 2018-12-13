/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace LayaVersion
{
	public partial class UIProjectMenuBar : GComponent
	{
		public GImage m_n3;
		public GList m_list;

		public const string URL = "ui://4yrap86wjw3e9";

		public static UIProjectMenuBar CreateInstance()
		{
			return (UIProjectMenuBar)UIPackage.CreateObject("LayaVersion","ProjectMenuBar");
		}

		public UIProjectMenuBar()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_n3 = (GImage)this.GetChildAt(0);
			m_list = (GList)this.GetChildAt(1);
		}
	}
}