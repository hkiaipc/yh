using System;
using System.Windows;
using System.Windows.Forms;

namespace CReportDll
{
	/// <summary>
	/// CReadText ��ժҪ˵����
	/// </summary>
	public class CReadText:TextBox
	{
		public CReadText()
		{			
		}
		protected override void OnKeyPress(
			KeyPressEventArgs e
			)
		{
			e.Handled=true;
		}


	}
}
