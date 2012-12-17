using System;
using System.Windows;
using System.Windows.Forms;

namespace CReportDll.comReport.newRep
{
	/// <summary>
	/// cNumText ��ժҪ˵����
	/// </summary>
	public class cNumText:TextBox
	{
		public cNumText()
		{		
		}
		protected override void OnKeyPress(
			KeyPressEventArgs e
			)
		{
			if(!char.IsDigit(e.KeyChar))
			{
				e.Handled=true;
			}
		}


	}
}
