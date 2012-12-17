using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Data.SqlClient;

namespace BengZhan.AutoBackup
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnCer;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFileName;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnExit;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;
		private bool m_bBack=true;
		private System.Windows.Forms.CheckBox chkAutoBack;
		private bool m_bRestore=false;
		public SqlConnection m_sCon;

		public Form1()
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
				if (components != null) 
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtFileName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.chkAutoBack = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCer
			// 
			this.btnCer.Location = new System.Drawing.Point(144, 64);
			this.btnCer.Name = "btnCer";
			this.btnCer.Size = new System.Drawing.Size(64, 23);
			this.btnCer.TabIndex = 0;
			this.btnCer.Text = "ȷ��";
			this.btnCer.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSearch);
			this.groupBox1.Controls.Add(this.txtFileName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(280, 48);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(240, 16);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(32, 23);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "...";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtFileName
			// 
			this.txtFileName.Location = new System.Drawing.Point(80, 16);
			this.txtFileName.Name = "txtFileName";
			this.txtFileName.Size = new System.Drawing.Size(152, 21);
			this.txtFileName.TabIndex = 1;
			this.txtFileName.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "�ļ�����";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(216, 64);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(64, 23);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "�˳�";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// chkAutoBack
			// 
			this.chkAutoBack.Location = new System.Drawing.Point(16, 64);
			this.chkAutoBack.Name = "chkAutoBack";
			this.chkAutoBack.Size = new System.Drawing.Size(112, 24);
			this.chkAutoBack.TabIndex = 3;
			this.chkAutoBack.Text = "�Զ��������ݿ�";
			this.chkAutoBack.CheckedChanged += new System.EventHandler(this.chkAutoBack_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 94);
			this.Controls.Add(this.chkAutoBack);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "���ݿ��Զ�����-�ļ�·������";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		

		private void button1_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.chkAutoBack.Checked==false)
				{
					string message="�Ƿ�ȷʵȥ���Զ����ݹ��ܣ�";

					DialogResult result;
					MessageBoxButtons buttons = MessageBoxButtons.YesNo;


					// Displays the MessageBox.

					result = MessageBox.Show(this, message, "ȡ��ȷ��", buttons,
						MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, 
						MessageBoxOptions.RightAlign);

					if(result == DialogResult.Yes)
					{	
						SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
						sCon.Open();
						string strSql="delete from databaseback";
						SqlCommand sCmd=new  SqlCommand();
						sCmd.Connection=sCon;
						sCmd.CommandText=strSql;
						sCmd.ExecuteNonQuery();
						sCon.Close();
						MessageBox.Show("��ȥ���Զ����ݣ�");
						return;
					}
					else
					{
						this.chkAutoBack.Checked=true;
					}
				}
				if(this.chkAutoBack.Checked==true)
				{
					if(this.setFileName()==false)
					{
						MessageBox.Show("����ʧ�ܣ�");
					}
					else
					{
						MessageBox.Show("������ɣ�");
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			//CAutoBackup cab=new CAutoBackup();
			//cab.autoBackup();			
		}

		//�����Զ����ݵ�·��
		private bool setFileName()
		{
			try
			{

				CAutoBackup cab=new CAutoBackup();
				string strErr="";
				if(cab.backUp(CAutoBackup.m_sCon.Database,this.txtFileName.Text.Trim(),ref strErr)==false)
				{
					return false;
				}
				if(cab.bSetFileName(CAutoBackup.m_sCon.Database,this.txtFileName.Text.Trim())==false)
				{
					return false;
				}				
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}
	
		private void btnExit_Click(object sender, System.EventArgs e)
		{
			//ɾ�����ü�¼
//			CAutoBackup cab=new CAutoBackup();
//			cab.iniCon();
//			if(cab.executeSqlFile("delTable.sql")==true)
//			{
//				MessageBox.Show("succ");
//			}

			this.Close();
		}

		private void btnSearch_Click(object sender, System.EventArgs e)
		{
			try
			{
				string strFileName="";
				try
				{
					if(this.m_bBack==true)
					{
						SaveFileDialog saveFileDialog1 = new SaveFileDialog(); 
						saveFileDialog1.InitialDirectory=Application.StartupPath+@"\database";
						saveFileDialog1.Filter = "���ݿⱸ��|*.bak" ; 
						
						saveFileDialog1.RestoreDirectory = true ; 
						saveFileDialog1.FileName=String.Format("data{0}.bak","Last");
						
						if(saveFileDialog1.ShowDialog() == DialogResult.OK) 
						{ 
							this.txtFileName.Text=saveFileDialog1.FileName;
						} 
						Directory.SetCurrentDirectory(Application.StartupPath);
						return;
					}
					if(this.m_bRestore==true)
					{
						OpenFileDialog openFileDialog1 = new OpenFileDialog(); 
						openFileDialog1.Filter = "���ݿⱸ��|*.bak"; 
						openFileDialog1.Title = "ѡ�����ݿⱸ���ļ�"; 
						openFileDialog1.InitialDirectory=Application.StartupPath+@"\database";
 
						// Show the Dialog. 
						// If the user clicked OK in the dialog and 
						// a .CUR file was selected, open it. 
						if (openFileDialog1.ShowDialog() == DialogResult.OK) 
						{ 
							if(openFileDialog1.FileName != "") 
							{ 
								strFileName=openFileDialog1.FileName;
					
							} 
							else
							{
								return;
							}
						} 
						if(strFileName!="")
						{
							this.txtFileName.Text=strFileName;						
						}
						Directory.SetCurrentDirectory(Application.StartupPath);
						return;
					}
				
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.ToString());
					return;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{			
			CAutoBackup cab=new CAutoBackup();
			if(this.m_sCon==null)
			{
				cab.iniCon();
				this.m_sCon=CAutoBackup.m_sCon;
			}
			else
			{
				CAutoBackup.m_sCon=this.m_sCon;
			}
			string strFileName="";
			cab.getFileName(ref strFileName);
			this.txtFileName.Text=strFileName;
			if(this.txtFileName.Text.Trim()=="")
			{
				this.chkAutoBack.Checked=false;
			}
			else
			
			{
				this.chkAutoBack.Checked=true;
			}
			
		}

		private void chkAutoBack_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.chkAutoBack.Checked==true)
			{
				if(this.txtFileName.Text.Trim()=="")
				{
					MessageBox.Show("�����ļ�������Ϊ�գ�");
					this.chkAutoBack.Checked=false;
				}
				
			}
			
		}
	}
}
