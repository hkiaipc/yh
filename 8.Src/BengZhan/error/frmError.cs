using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace BengZhan.error
{
	/// <summary>
	/// frmError ��ժҪ˵����
	/// </summary>
	public class frmError : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnCer;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ListView lsvErr;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmError()
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lsvErr = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.btnCer = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lsvErr);
			this.groupBox1.Location = new System.Drawing.Point(8, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(464, 328);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// lsvErr
			// 
			this.lsvErr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					 this.columnHeader1,
																					 this.columnHeader2,
																					 this.columnHeader3});
			this.lsvErr.FullRowSelect = true;
			this.lsvErr.GridLines = true;
			this.lsvErr.Location = new System.Drawing.Point(8, 16);
			this.lsvErr.Name = "lsvErr";
			this.lsvErr.Size = new System.Drawing.Size(448, 304);
			this.lsvErr.TabIndex = 0;
			this.lsvErr.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "GPRS��";
			this.columnHeader1.Width = 101;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "�쳣��ʾ";
			this.columnHeader2.Width = 208;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "�ϱ�ʱ��";
			this.columnHeader3.Width = 127;
			// 
			// btnCer
			// 
			this.btnCer.Location = new System.Drawing.Point(232, 336);
			this.btnCer.Name = "btnCer";
			this.btnCer.TabIndex = 1;
			this.btnCer.Text = "ȷ��";
			this.btnCer.Click += new System.EventHandler(this.btnCer_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(344, 336);
			this.btnExit.Name = "btnExit";
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "�˳�";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// frmError
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(474, 366);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnCer);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmError";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "�ϱ��쳣";
			this.Load += new System.EventHandler(this.frmError_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnCer_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmError_Load(object sender, System.EventArgs e)
		{
			try
			{
				this.lsvErr.Items.Clear();
				if(CDBConnection.m_dtErr!=null)
				{
					for(int i=0;i<CDBConnection.m_dtErr.Rows.Count;i++)
					{
						this.lsvErr.Items.Add(CDBConnection.m_dtErr.Rows[i]["gprsNo"].ToString());
						this.lsvErr.Items[i].SubItems.Add(CDBConnection.m_dtErr.Rows[i]["err"].ToString());
						this.lsvErr.Items[i].SubItems.Add(CDBConnection.m_dtErr.Rows[i]["errTime"].ToString());
					}

				}
				
					  }
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}
