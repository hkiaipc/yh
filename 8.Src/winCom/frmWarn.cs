using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;


namespace winCom
{
	/// <summary>
	/// frmWarn ��ժҪ˵����
	/// </summary>
	public class frmWarn : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnCer;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmWarn()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
			this.btnCer = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCer
			// 
			this.btnCer.Location = new System.Drawing.Point(200, 176);
			this.btnCer.Name = "btnCer";
			this.btnCer.TabIndex = 0;
			this.btnCer.Text = "ȷ��";
			this.btnCer.Click += new System.EventHandler(this.btnCer_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(280, 120);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// frmWarn
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 221);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCer);
			this.Name = "frmWarn";
			this.Text = "ͨѶ�쳣վ";
			this.Load += new System.EventHandler(this.frmWarn_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnCer_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		public ArrayList m_arr=new ArrayList();	

		private void frmWarn_Load(object sender, System.EventArgs e)
		{
			string str="";

			if(this.m_arr==null)
			{
				this.Close();
				return;
			}

			for(int i=0;i<this.m_arr.Count;i++)
			{
				str+=this.m_arr[i].ToString();
			}

			this.m_arr.Clear();

			this.label1.Text=str;
		}
	}
}
