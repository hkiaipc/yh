using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Xml;

namespace BengZhan.deps
{
	/// <summary>
	/// δ�ô��壬frmDep ��ժҪ˵����
	/// </summary>
	public class frmDep : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.ListView lsvDep;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbCountry;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmDep()
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
			this.lsvDep = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cmbCountry = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lsvDep);
			this.groupBox1.Location = new System.Drawing.Point(0, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(752, 480);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// lsvDep
			// 
			this.lsvDep.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					 this.columnHeader1,
																					 this.columnHeader2,
																					 this.columnHeader3,
																					 this.columnHeader4,
																					 this.columnHeader6,
																					 this.columnHeader8,
																					 this.columnHeader5});
			this.lsvDep.FullRowSelect = true;
			this.lsvDep.GridLines = true;
			this.lsvDep.Location = new System.Drawing.Point(8, 16);
			this.lsvDep.Name = "lsvDep";
			this.lsvDep.Size = new System.Drawing.Size(736, 456);
			this.lsvDep.TabIndex = 0;
			this.lsvDep.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "�������";
			this.columnHeader1.Width = 90;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "��������";
			this.columnHeader2.Width = 110;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "��ַ";
			this.columnHeader3.Width = 85;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "��ϵ��";
			this.columnHeader4.Width = 85;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "��ϵ�绰";
			this.columnHeader6.Width = 83;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "���������";
			this.columnHeader8.Width = 77;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "��ע";
			this.columnHeader5.Width = 97;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnPrint);
			this.groupBox2.Controls.Add(this.btnExit);
			this.groupBox2.Controls.Add(this.btnDel);
			this.groupBox2.Controls.Add(this.btnEdit);
			this.groupBox2.Controls.Add(this.btnAdd);
			this.groupBox2.Location = new System.Drawing.Point(256, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(336, 40);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(248, 12);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.TabIndex = 4;
			this.btnPrint.Text = "��ӡ";
			this.btnPrint.Visible = false;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(248, 11);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(80, 24);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "�˳�";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(168, 12);
			this.btnDel.Name = "btnDel";
			this.btnDel.TabIndex = 2;
			this.btnDel.Text = "ɾ��";
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(88, 12);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.TabIndex = 1;
			this.btnEdit.Text = "�޸�";
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(8, 12);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "���";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cmbCountry);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Location = new System.Drawing.Point(8, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(240, 40);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			// 
			// cmbCountry
			// 
			this.cmbCountry.Location = new System.Drawing.Point(88, 14);
			this.cmbCountry.Name = "cmbCountry";
			this.cmbCountry.Size = new System.Drawing.Size(144, 20);
			this.cmbCountry.TabIndex = 1;
			this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "��������� :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// frmDep
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(754, 528);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmDep";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "������Ϣ";
			this.Load += new System.EventHandler(this.frmDep_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnDel_Click(object sender, System.EventArgs e)
		{
			try
			{

				//MessageBox.Show("��Ϊɾ��������ϵͳ����,����ɾ��������!");
				//return;

				if(this.lsvDep.SelectedItems.Count<=0)
				{
					MessageBox.Show("��ѡ��Ҫɾ���Ĺ�����");
					return;
				}

				string strDepShortName=this.lsvDep.SelectedItems[0].Text.Trim();

				string strSql=String.Format("select count(*) from tbWell where depName ='{0}'",strDepShortName);
				string strCount=CDBConnection.ExecuteScalar(strSql);
				if(strCount.Trim()!="0")
				{
					MessageBox.Show("�õ�λ����¼����վ,����ɾ�����µ�վ��!");
					return;
				}

				strSql=String.Format("delete from tbDep where depShortName='{0}'",strDepShortName);
				CDBConnection.ExecuteSql(strSql);			

				this.paintFrm();


			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void frmDep_Load(object sender, System.EventArgs e)
		{
			//����treeview
			this.paintCountry();
			//����listview
			this.paintFrm();
			//�����б�
			iniFrm();
		}
		private void paintCountry()
		{
			try
			{
				//����������Ϣ
				string strSql="select countryName from tbCountry";
				DataTable dtCountry=null;
				CDBConnection.getDataTable(ref dtCountry,strSql,"tbCountry");
				this.cmbCountry.Items.Clear();
				for(int i=0;i<dtCountry.Rows.Count;i++)
				{
					this.cmbCountry.Items.Add(dtCountry.Rows[i]["countryName"].ToString());
				}
				this.cmbCountry.Items.Add("");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		//��䵥λ�б�
		private void paintFrm()
		{
			try
			{
				string strCountry=this.cmbCountry.Text.Trim();

				string strSql="";

				if(strCountry.Trim()!="")
				{
					strSql=String.Format("select depShortName,depName,hangYeName,countryName,contactPer,contactTel,address,des from tbDep where countryName='{0}'",strCountry);
				}
				else
				{
					strSql=String.Format("select depShortName,depName,hangYeName,countryName,contactPer,contactTel,address,des from tbDep");
				}
					
				DataTable dtDep=null;
				CDBConnection.getDataTable(ref dtDep,strSql,"tbDep");

				this.lsvDep.Items.Clear();

				for(int i=0;i<dtDep.Rows.Count;i++)
				{
					this.lsvDep.Items.Add(dtDep.Rows[i]["depShortName"].ToString());
					this.lsvDep.Items[i].SubItems.Add(dtDep.Rows[i]["depName"].ToString());
					this.lsvDep.Items[i].SubItems.Add(dtDep.Rows[i]["address"].ToString());
					this.lsvDep.Items[i].SubItems.Add(dtDep.Rows[i]["contactPer"].ToString());
					this.lsvDep.Items[i].SubItems.Add(dtDep.Rows[i]["contactTel"].ToString());
					//this.lsvDep.Items[i].SubItems.Add(dtDep.Rows[i]["HangYeName"].ToString());
					this.lsvDep.Items[i].SubItems.Add(dtDep.Rows[i]["countryName"].ToString());
					this.lsvDep.Items[i].SubItems.Add(dtDep.Rows[i]["des"].ToString() );
				}
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}			

		}

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			try
			{
				
				string strCountryName="";
				strCountryName=this.cmbCountry.Text.Trim();

				if(strCountryName=="")
				{
					MessageBox.Show("��ѡ��ù�����������֣�");
					return;
				}

				frmDepEdit frmDepEditObj=new frmDepEdit();
				frmDepEditObj.m_strCountryName=strCountryName;
				frmDepEditObj.ShowDialog();
				if(frmDepEditObj.m_bInserted==true)
				{
					this.paintFrm();
				}
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnEdit_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.lsvDep.SelectedItems.Count<=0)
				{
					MessageBox.Show("��ѡ��Ҫ�޸ĵĵ�λ��");
					return;
				}

				frmDepEdit frmDepEditObj=new frmDepEdit();
				frmDepEditObj.m_bEdit=true;
				frmDepEditObj.m_strDepShortName=this.lsvDep.SelectedItems[0].Text.Trim();
				frmDepEditObj.ShowDialog();
				this.paintFrm();


			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			

		}

		private void btnPrint_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.lsvDep.SelectedItems.Count<=0)
				{
					MessageBox.Show("��ѡ��Ҫ��ӡ�ĵ�λ��");
					return;
				}

				DataTable dtDep=new DataTable();
				dtDep.Columns.Add(new DataColumn("field1"));
				dtDep.Columns.Add(new DataColumn("field2"));

				DataRow dr=dtDep.NewRow();
				dr["field1"]="��λ���";
				dr["field2"]=this.lsvDep.SelectedItems[0].SubItems[0].Text;
				dtDep.Rows.Add(dr);

				dr=dtDep.NewRow();
				dr["field1"]="��λ����";
				dr["field2"]=this.lsvDep.SelectedItems[0].SubItems[1].Text;
				dtDep.Rows.Add(dr);

				dr=dtDep.NewRow();
				dr["field1"]="��ַ";
				dr["field2"]=this.lsvDep.SelectedItems[0].SubItems[2].Text;
				dtDep.Rows.Add(dr);

				dr=dtDep.NewRow();
				dr["field1"]="��ϵ��";
				dr["field2"]=this.lsvDep.SelectedItems[0].SubItems[3].Text;
				dtDep.Rows.Add(dr);

				dr=dtDep.NewRow();
				dr["field1"]="��ϵ�绰";
				dr["field2"]=this.lsvDep.SelectedItems[0].SubItems[4].Text;
				dtDep.Rows.Add(dr);

				dr=dtDep.NewRow();
				dr["field1"]="��ҵ�����ʣ�";
				dr["field2"]=this.lsvDep.SelectedItems[0].SubItems[5].Text;
				dtDep.Rows.Add(dr);

				dr=dtDep.NewRow();
				dr["field1"]="��������";
				dr["field2"]=this.lsvDep.SelectedItems[0].SubItems[6].Text;
				dtDep.Rows.Add(dr);

				dr=dtDep.NewRow();
				dr["field1"]="��ע";
				dr["field2"]=this.lsvDep.SelectedItems[0].SubItems[7].Text;
				dtDep.Rows.Add(dr);

				CDGPrintDll.frmDgPrint frmDgP=new CDGPrintDll.frmDgPrint();
				frmDgP.iniDgPrint(dtDep,"��λ��Ϣ��",System.DateTime.Now.ToString());
				frmDgP.print(false);		 


			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void tvwCountry_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			this.paintFrm();
		}

		
		//�Ƿ���ʾ�����б�
		private bool m_bDispCountry=false;
		//��ʼ����
		private void iniFrm()
		{
//			try
//			{
//				XmlDocument xDoc=new XmlDocument();
//				xDoc.Load("sysForm.xml");
//				string strDisCountry=xDoc.DocumentElement.SelectSingleNode("./dispCountry").Attributes.GetNamedItem("val").Value.ToString().Trim();
//				if(strDisCountry!="1")
//				{
//					this.m_bDispCountry=false;
//				}
//				else
//				{
//					this.m_bDispCountry=true;
//				}
//				if(this.m_bDispCountry==false)
//				{
//					this.Left=this.Left+this.grpTrv.Width/2;
//					this.grpTrv.Visible=false;
//					this.groupBox1.Left=this.groupBox1.Left-this.grpTrv.Width;
//					this.groupBox2.Left=this.groupBox2.Left-this.grpTrv.Width;
//					this.Width=this.Width-this.grpTrv.Width;
//				}
//			}
//			catch(Exception ex)
//			{
//				MessageBox.Show(ex.ToString());
//			}
		}

		private void cmbCountry_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.paintFrm();
		}
		

	}
}
