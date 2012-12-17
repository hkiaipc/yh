using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;

namespace BengZhan.database
{
	/// <summary>
	/// frmSysSet ��ժҪ˵����
	/// </summary>
	public class frmSysSet : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSet;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtInterval;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtWarnLevel;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		private XmlDocument m_xDoc;

		public frmSysSet()
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
			this.txtWarnLevel = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtInterval = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSet = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtWarnLevel);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtInterval);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(280, 120);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// txtWarnLevel
			// 
			this.txtWarnLevel.Location = new System.Drawing.Point(128, 72);
			this.txtWarnLevel.Name = "txtWarnLevel";
			this.txtWarnLevel.Size = new System.Drawing.Size(144, 21);
			this.txtWarnLevel.TabIndex = 3;
			this.txtWarnLevel.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "�������ޣ�";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtInterval
			// 
			this.txtInterval.Location = new System.Drawing.Point(128, 32);
			this.txtInterval.Name = "txtInterval";
			this.txtInterval.Size = new System.Drawing.Size(144, 21);
			this.txtInterval.TabIndex = 1;
			this.txtInterval.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "�в�ʱ����(��)��";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnSet
			// 
			this.btnSet.Location = new System.Drawing.Point(128, 136);
			this.btnSet.Name = "btnSet";
			this.btnSet.TabIndex = 1;
			this.btnSet.Text = "�趨";
			this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(208, 136);
			this.btnExit.Name = "btnExit";
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "�˳�";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// frmSysSet
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 168);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSet);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSysSet";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ϵͳ����";
			this.Load += new System.EventHandler(this.frmSysSet_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmSysSet_Load(object sender, System.EventArgs e)
		{
			try
			{
				
				string strSql=String.Format("select val from tbInfo where des='{0}'","��������");
				this.txtWarnLevel.Text=CDBConnection.ExecuteScalar(strSql);

				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("Info.xml");

				XmlNode xNode=xDoc.DocumentElement.SelectSingleNode("./interval");
				string strInterval=xNode.InnerText.Trim();

				int iInter=Convert.ToInt32(Math.Round(Convert.ToDouble(strInterval) ,0));
				double dInter=Math.Round(iInter/60.00,2);
				this.txtInterval.Text=dInter.ToString();
				this.m_xDoc=xDoc;

				

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			

		}

		private void btnSet_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.txtInterval.Text.Trim()=="")
				{
					MessageBox.Show("����дʱ������");
					return;
				}
				if(this.txtWarnLevel.Text.Trim()=="")
				{
					MessageBox.Show("����д�������ޣ�");
					return;
				}
				double dWarn=Convert.ToDouble(this.txtWarnLevel.Text.Trim());
				string strSql=String.Format("update tbInfo set val='{0}' where des='{1}'",dWarn.ToString(),"��������");
				CDBConnection.ExecuteSql(strSql);
				double dInter=Convert.ToDouble(this.txtInterval.Text);
				double iInter=Convert.ToDouble(dInter*60);
				this.m_xDoc.DocumentElement.SelectSingleNode("./interval").InnerText=iInter.ToString();
				this.m_xDoc.Save("Info.xml");

				this.Close();

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}

		
		}
	}
}
