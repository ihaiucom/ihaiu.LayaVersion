/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace LayaVersion
{
	public partial class UITag : GLabel
	{
		public GLoader m_icon;
		public GTextField m_title;

		public const string URL = "ui://4yrap86wjw3ew";

		public static UITag CreateInstance()
		{
			return (UITag)UIPackage.CreateObject("LayaVersion","Tag");
		}

		public UITag()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_icon = (GLoader)this.GetChildAt(0);
			m_title = (GTextField)this.GetChildAt(1);
		}
	}
}