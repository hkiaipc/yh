using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BengZhan.bengzhans
{
	/// <summary>
	/// frmGLDatas ��ժҪ˵����
	/// </summary>
	public class frmGLDatas : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmGLDatas()
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
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(3, 17);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(404, 380);
			this.dataGrid1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.dataGrid1);
			this.groupBox1.Location = new System.Drawing.Point(8, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(410, 400);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(320, 408);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 24);
			this.button1.TabIndex = 2;
			this.button1.Text = "�˳�";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmGLDatas
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(426, 448);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmGLDatas";
			this.Text = "���ʱ�";
			this.Load += new System.EventHandler(this.frmGLDatas_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void LoadDGtitle()
		{
			DataGridTableStyle tbs= new DataGridTableStyle();
			string[] colNames = new string[] { "name", "minValue", "oValue", "maxValue"};
			string[] showNames = new string[] { "�������ͼ�״��", "��Сֵ","����ֵ", "���ֵ" };

			for (int i = 0; i < colNames.Length; i++)
			{
				DataGridTextBoxColumn clm=new DataGridTextBoxColumn();
				clm.MappingName=colNames[i];
				clm.HeaderText=showNames[i];
				clm.Width=100;
				tbs.GridColumnStyles.Add(clm);
			}
			
			tbs.MappingName ="tbw_Granulation";
			dataGrid1.TableStyles.Add(tbs);
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmGLDatas_Load(object sender, System.EventArgs e)
		{
			LoadDGtitle();
			string strSql=string.Format("select * from tbw_Granulation");
			DataTable dtWell=null;
			CDBConnection.getDataTable(ref dtWell,strSql,"tbw_Granulation");
			this.dataGrid1.DataSource=dtWell.DefaultView;
		}
	}
}
