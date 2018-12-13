/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace LayaVersion
{
	public partial class UIExeList : GComponent
	{
		public GGraph m_n5;
		public GList m_list;

		public const string URL = "ui://4yrap86wjw3en";

		public static UIExeList CreateInstance()
		{
			return (UIExeList)UIPackage.CreateObject("LayaVersion","ExeList");
		}

		public UIExeList()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_n5 = (GGraph)this.GetChildAt(0);
			m_list = (GList)this.GetChildAt(1);
		}
	}
}