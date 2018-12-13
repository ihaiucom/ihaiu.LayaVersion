/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace LayaVersion
{
	public partial class UIMergePage : GComponent
	{
		public UIBigButton m_exeSelectedButton;
		public UIExeList m_exeList;

		public const string URL = "ui://4yrap86wjw3ei";

		public static UIMergePage CreateInstance()
		{
			return (UIMergePage)UIPackage.CreateObject("LayaVersion","MergePage");
		}

		public UIMergePage()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

			m_exeSelectedButton = (UIBigButton)this.GetChildAt(0);
			m_exeList = (UIExeList)this.GetChildAt(1);
		}
	}
}