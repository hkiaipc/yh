using System;
using System.Windows.Forms;

namespace BengZhan.controls
{
	/// <summary>
	/// myCmb ��ժҪ˵����
	/// </summary>
	public class myCmb:System.Windows.Forms.ComboBox
	{
		public myCmb():base()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}
		protected override void OnKeyDown(KeyEventArgs e)
		{
			e.Handled=true;
		}
		protected override void OnKeyPress(
			KeyPressEventArgs e
			)
		{
			Byte[] bt=System.Text.Encoding.ASCII.GetBytes(e.KeyChar.ToString());
			if(bt.Length<1)
			{
				e.Handled=true;
				return;
			}
			if(bt[0]!=8)
			{
				//ɾ����
				e.Handled=true;
				return;
			}		
		}
		
	}
}
