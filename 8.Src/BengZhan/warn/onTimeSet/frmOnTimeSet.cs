using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;

namespace BengZhan.warn.onTimeSet
{
	/// <summary>
	/// frmOnTimeSet ��ժҪ˵����
	/// </summary>
	public class frmOnTimeSet : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.ListView lsvTime;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmOnTimeSet()
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
			this.lsvTime = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lsvTime);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(256, 304);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// lsvTime
			// 
			this.lsvTime.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					  this.columnHeader1});
			this.lsvTime.FullRowSelect = true;
			this.lsvTime.GridLines = true;
			this.lsvTime.Location = new System.Drawing.Point(8, 16);
			this.lsvTime.MultiSelect = false;
			this.lsvTime.Name = "lsvTime";
			this.lsvTime.Size = new System.Drawing.Size(240, 280);
			this.lsvTime.TabIndex = 0;
			this.lsvTime.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "ʱ��";
			this.columnHeader1.Width = 230;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(8, 320);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "���";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(96, 320);
			this.btnDel.Name = "btnDel";
			this.btnDel.TabIndex = 2;
			this.btnDel.Text = "ɾ��";
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(184, 320);
			this.btnExit.Name = "btnExit";
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "�˳�";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// frmOnTimeSet
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(266, 351);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmOnTimeSet";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "�����в�ʱ�̱�";
			this.Load += new System.EventHandler(this.frmOnTimeSet_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmOnTimeSet_Load(object sender, System.EventArgs e)
		{
			paintFrm();
		}
		private void paintFrm()
		{
			try
			{
				this.lsvTime.Items.Clear();
				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("timer.xml");
				
				for(int i=0;i<xDoc.DocumentElement.ChildNodes.Count;i++)
				{
					XmlNode xNode=xDoc.DocumentElement.ChildNodes[i];
					string strHour=xNode.Attributes.GetNamedItem("hour").Value.ToString().Trim();
					string strMin=xNode.Attributes.GetNamedItem("min").Value.ToString().Trim();
					string strInfo=String.Format("{0}:{1}",strHour,strMin);
					this.lsvTime.Items.Add(strInfo);
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
		}

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			if(this.lsvTime.Items.Count>80)
			{
				MessageBox.Show("��ʱ�в�ʱ�̱�����,��ִ��ɾ������!");
				return;
			}
			frmTime frmT=new frmTime();
			frmT.ShowDialog();
			this.paintFrm();
		}

		private void btnDel_Click(object sender, System.EventArgs e)
		{
	
			if(this.lsvTime.Items.Count==0)
			{
				MessageBox.Show("��ѡ��Ҫɾ����!");
			}
			string strInfo=this.lsvTime.SelectedItems[0].Text.Trim();
			

			XmlDocument xDoc=new XmlDocument();
			xDoc.Load("timer.xml");
			for(int i=0;i<xDoc.DocumentElement.ChildNodes.Count;i++)
			{
				XmlNode xNode=xDoc.DocumentElement.ChildNodes[i];
				string strHour=xNode.Attributes.GetNamedItem("hour").Value.ToString().Trim();
				string strMin=xNode.Attributes.GetNamedItem("min").Value.ToString().Trim();
                string strTime=String.Format("{0}:{1}",strHour,strMin) ;
				if(strTime==strInfo)
				{
					xDoc.DocumentElement.RemoveChild(xDoc.DocumentElement.ChildNodes[i]);
					i--;
				}               
			}
			xDoc.Save("timer.xml");
			this.paintFrm();
		}
	}
}
