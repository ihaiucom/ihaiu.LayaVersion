/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace LayaVersion
{
	public partial class UIContentMenuBar : GComponent
	{
		public GGraph m_n6;
		public GList m_list;

		public const string URL = "ui://4yrap86wjw3ee";

		public static UIContentMenuBar CreateInstance()
		{
			return (UIContentMenuBar)UIPackage.CreateObject("LayaVersion","ContentMenuBar");
		}

		public UIContentMenuBar()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_n6 = (GGraph)this.GetChildAt(0);
			m_list = (GList)this.GetChildAt(1);
		}
	}
}