using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.IO;

namespace BengZhan.database
{
	/// <summary>
	/// frmBackRestoreDB ��ժҪ˵����
	/// </summary>
	public class frmBackRestoreDB : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFileName;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnRestore;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		private string m_dbName;
		private string m_strCon="";

		public bool m_bIni=false;

		public bool m_bBack=false;
		private System.Windows.Forms.Button btnIni;
		private System.Windows.Forms.Button btnUpDb;
		public bool m_bRestore=false;

		public frmBackRestoreDB()
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
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtFileName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnRestore = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnIni = new System.Windows.Forms.Button();
			this.btnUpDb = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSearch);
			this.groupBox1.Controls.Add(this.txtFileName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(344, 72);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(296, 32);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(40, 24);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "...";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtFileName
			// 
			this.txtFileName.Location = new System.Drawing.Point(80, 32);
			this.txtFileName.Name = "txtFileName";
			this.txtFileName.Size = new System.Drawing.Size(208, 21);
			this.txtFileName.TabIndex = 1;
			this.txtFileName.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "�ļ�����";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(88, 88);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(64, 23);
			this.btnBack.TabIndex = 1;
			this.btnBack.Text = "����";
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnRestore
			// 
			this.btnRestore.Location = new System.Drawing.Point(152, 88);
			this.btnRestore.Name = "btnRestore";
			this.btnRestore.Size = new System.Drawing.Size(64, 23);
			this.btnRestore.TabIndex = 2;
			this.btnRestore.Text = "��ԭ";
			this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(280, 88);
			this.btnExit.Name = "btnExit";
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "�˳�";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnIni
			// 
			this.btnIni.Location = new System.Drawing.Point(216, 88);
			this.btnIni.Name = "btnIni";
			this.btnIni.Size = new System.Drawing.Size(64, 23);
			this.btnIni.TabIndex = 4;
			this.btnIni.Text = "��ʼ�ļ�";
			this.btnIni.Click += new System.EventHandler(this.btnIni_Click);
			// 
			// btnUpDb
			// 
			this.btnUpDb.Location = new System.Drawing.Point(16, 88);
			this.btnUpDb.Name = "btnUpDb";
			this.btnUpDb.Size = new System.Drawing.Size(72, 23);
			this.btnUpDb.TabIndex = 5;
			this.btnUpDb.Text = "�������ݿ�";
			this.btnUpDb.Click += new System.EventHandler(this.btnUpDb_Click);
			// 
			// frmBackRestoreDB
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(362, 120);
			this.Controls.Add(this.btnUpDb);
			this.Controls.Add(this.btnIni);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnRestore);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmBackRestoreDB";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "���ݿⱸ��\\��ԭ";
			this.Load += new System.EventHandler(this.frmBackRestoreDB_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		//�������ݿ�
		private bool backUp(string strDBName,string strFileName,ref string strErr)
		{
			try
			{
				SqlConnection sCon=new SqlConnection(this.m_strCon);
				sCon.Open();
				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;
				sCmd.CommandText="pr_backup_db";
				sCmd.CommandType=CommandType.StoredProcedure;
				sCmd.Parameters.Add("@backup_db_name",strDBName);
				sCmd.Parameters.Add("@filename",strFileName);
				sCmd.ExecuteNonQuery();
				MessageBox.Show("������ɣ�");
				sCon.Close();
				return true;

			}
			catch(Exception ex)
			{
				strErr=ex.ToString();
				MessageBox.Show(strErr);
				return false;
			}
		}
		//��ԭ���ݿ�
		private void restoreDB(SqlConnection sCon,string strDBName,string strFilePath)
		{
			try
			{	
				
				if(MessageBox.Show("��ԭ���ݿ⣬�������������ݣ��Ƿ������","���ݻ�ԭ",MessageBoxButtons.OKCancel)!=DialogResult.OK)
				{
					return;
				}
	sCon=new SqlConnection(this.m_strCon);
				sCon.Open();

				SqlCommand sCmd=new SqlCommand();				
				FileStream fs=new FileStream("killCon.sql",FileMode.Open,FileAccess.Read);
				StreamReader sdr=new StreamReader(fs,System.Text.Encoding.Unicode);
				string strSql=sdr.ReadToEnd();
				//MessageBox.Show(strSql);
				sCmd.Connection =sCon;
				sCmd.CommandText="use master";
				sCmd.ExecuteNonQuery();			
				sCmd.CommandText="select count(*) from dbo.sysobjects where id = object_id(N'[dbo].[killspid]') and OBJECTPROPERTY(id, N'IsProcedure') = 1";
				string strCount=sCmd.ExecuteScalar().ToString();
				if(strCount=="0")
				{
					sCmd.CommandText=strSql;
					sCmd.ExecuteNonQuery();
				}
				sCmd.CommandText=String.Format("killspid '{0}'",strDBName);
				sCmd.ExecuteNonQuery();
                sCmd.CommandText=String.Format(@"RESTORE DATABASE {0}  FROM disk='{1}' WITH MOVE '{0}_Data' to 'c:\{0}_Data.mdf',MOVE '{0}_Log' to 'c:\{0}_Log.ldf',REPLACE",strDBName,strFilePath);
				sCmd.ExecuteNonQuery();
				sCon.Close();
				MessageBox.Show("��ԭ��ɣ�");
				Application.Exit();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnBack_Click(object sender, System.EventArgs e)
		{
			try
			{

				if(this.txtFileName.Text.Trim()=="")
				{
					MessageBox.Show("����д�ļ�����");
					return;
				}				
				string strErr="";
				if(File.Exists(this.txtFileName.Text.Trim()))
				{
					File.Delete(this.txtFileName.Text.Trim());
				}
				this.backUp("dbBengZhan",this.txtFileName.Text.Trim(),ref strErr);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
		}

		private void btnRestore_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.txtFileName.Text.Trim()=="")
				{
					MessageBox.Show("����д�ļ�����");
					return;
				}				
				if(!File.Exists(this.txtFileName.Text.Trim()))
				{
					MessageBox.Show("�ļ�"+this.txtFileName.Text.Trim()+"�����ڣ�");
					return;
				}
				SqlConnection sCon=new SqlConnection(this.m_strCon);
				sCon.Open();
				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;
				sCmd.CommandText="use master";
				sCmd.ExecuteNonQuery();
				sCmd.CommandText=String.Format("select count(*) from sysdatabases where name='{0}'","dbBengZhan");
				string strCount=sCmd.ExecuteScalar().ToString();
				if(strCount=="0")
				{
					sCmd.CommandText="create database dbBengZhan";
					sCmd.ExecuteNonQuery();
				}				
				this.restoreDB(sCon,"dbBengZhan",this.txtFileName.Text.Trim());	
				sCmd.CommandText="use dbBengZhan";
				sCmd.ExecuteNonQuery();
				CDBConnection.m_sCon=sCon;
				

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
		}

		private void frmBackRestoreDB_Load(object sender, System.EventArgs e)
		{
			try
			{
				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("Server.xml");
				this.m_dbName=xDoc.DocumentElement.SelectSingleNode("./dataBase").InnerText.Trim();				
				string strCon=xDoc.DocumentElement.SelectSingleNode("./strCon").InnerText.Trim();
				this.m_strCon=strCon;

				SqlConnection sCon=new SqlConnection(this.m_strCon);
				try
				{
					sCon.Open();
				}
				catch(Exception ex)
				{
					MessageBox.Show("���ݿ�����ʧ�ܣ���������ӣ�");
					this.btnBack.Enabled=false;
					this.btnRestore.Enabled=false;
					return;
				}				
				sCon.Close();

				
				this.btnBack.Enabled=false;
				this.btnRestore.Enabled=false;

				if(this.m_bBack==true)
				{
					this.btnBack.Enabled=true;
					this.btnIni.Enabled=false;
				}
				if(this.m_bRestore==true)
				{
					this.btnRestore.Enabled=true;
				}

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());

			}
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
						saveFileDialog1.FileName=String.Format("data{0}.bak",System.DateTime.Now.ToShortDateString().Replace("-",""));
						
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

		private void btnIni_Click(object sender, System.EventArgs e)
		{
			this.txtFileName.Text=Application.StartupPath.ToString()+@"\database\ԭʼ����\initialData.bak";
		}

		private void btnUpDb_Click(object sender, System.EventArgs e)
		{			
			try
			{

				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("Info.xml");
				string strFileName=xDoc.DocumentElement.SelectSingleNode("./dbFile").Attributes.GetNamedItem("name").Value.Trim();

				if(!File.Exists(strFileName))
				{
					return;
				}		

				xDoc=new XmlDocument();
				xDoc.Load("upSqls.xml");


				if(xDoc.DocumentElement.Attributes.GetNamedItem("val").Value.Trim()=="1")
				{
					MessageBox.Show("���ݿ���������");
					return;
				}

				for(int i=0;i<xDoc.DocumentElement.ChildNodes.Count;i++)
				{
					string strFile=xDoc.DocumentElement.ChildNodes[i].Attributes.GetNamedItem("name").Value.ToString().Trim();
					if(this.executeSqlFile(strFile)==false)				
					{
						MessageBox.Show("���ݿ���������");
						return ;
					}
				}
			
				MessageBox.Show("���ݿ��������!");
				xDoc.DocumentElement.Attributes.GetNamedItem("val").Value="1";
				xDoc.Save("upSqls.xml");

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
		}
		//ִ��sql�ű��ļ�
		public bool executeSqlFile(string strFileName)
		{
			try
			{
				SqlConnection sCon=new SqlConnection(BengZhan.CDBConnection.m_strCon);
				sCon.Open();

				StreamReader sr = new StreamReader(strFileName,System.Text.Encoding.UTF8);
				string strSqlFile=sr.ReadToEnd();
				strSqlFile=strSqlFile.Replace(@"\r","");
				strSqlFile=strSqlFile.Replace(@"\n","");				
				SqlCommand sCmd=new SqlCommand();
				sCmd.Connection=sCon;
				sCmd.CommandText=strSqlFile;
				sCmd.ExecuteNonQuery();	
				sCon.Close();
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}

		}

	}
}
