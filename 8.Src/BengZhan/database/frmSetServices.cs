using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;

namespace BengZhan.database
{
	/// <summary>
	/// frmSetServices ��ժҪ˵����
	/// </summary>
	public class frmSetServices : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSetTest;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.CheckBox chkServer;
		private System.Windows.Forms.CheckBox chkClient;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.ComboBox cmbTcpServ;
		private System.Windows.Forms.CheckBox chkOrdial;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmSetServices()
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
			this.chkOrdial = new System.Windows.Forms.CheckBox();
			this.cmbTcpServ = new System.Windows.Forms.ComboBox();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.chkClient = new System.Windows.Forms.CheckBox();
			this.chkServer = new System.Windows.Forms.CheckBox();
			this.btnSetTest = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chkOrdial);
			this.groupBox1.Controls.Add(this.cmbTcpServ);
			this.groupBox1.Controls.Add(this.txtPort);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.chkClient);
			this.groupBox1.Controls.Add(this.chkServer);
			this.groupBox1.Location = new System.Drawing.Point(8, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(280, 152);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// chkOrdial
			// 
			this.chkOrdial.Location = new System.Drawing.Point(200, 24);
			this.chkOrdial.Name = "chkOrdial";
			this.chkOrdial.Size = new System.Drawing.Size(48, 24);
			this.chkOrdial.TabIndex = 7;
			this.chkOrdial.Text = "��ͨ";
			this.chkOrdial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkOrdial.CheckedChanged += new System.EventHandler(this.chkOrdial_CheckedChanged);
			// 
			// cmbTcpServ
			// 
			this.cmbTcpServ.Location = new System.Drawing.Point(120, 72);
			this.cmbTcpServ.Name = "cmbTcpServ";
			this.cmbTcpServ.Size = new System.Drawing.Size(136, 20);
			this.cmbTcpServ.TabIndex = 6;
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(120, 112);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(136, 21);
			this.txtPort.TabIndex = 5;
			this.txtPort.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "�˿ںţ�";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "��������";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// chkClient
			// 
			this.chkClient.Location = new System.Drawing.Point(120, 24);
			this.chkClient.Name = "chkClient";
			this.chkClient.Size = new System.Drawing.Size(64, 24);
			this.chkClient.TabIndex = 1;
			this.chkClient.Text = "�ͻ���";
			this.chkClient.CheckedChanged += new System.EventHandler(this.chkClient_CheckedChanged);
			// 
			// chkServer
			// 
			this.chkServer.Location = new System.Drawing.Point(32, 24);
			this.chkServer.Name = "chkServer";
			this.chkServer.Size = new System.Drawing.Size(64, 24);
			this.chkServer.TabIndex = 0;
			this.chkServer.Text = "������";
			this.chkServer.CheckedChanged += new System.EventHandler(this.chkServer_CheckedChanged);
			// 
			// btnSetTest
			// 
			this.btnSetTest.Location = new System.Drawing.Point(120, 160);
			this.btnSetTest.Name = "btnSetTest";
			this.btnSetTest.TabIndex = 1;
			this.btnSetTest.Text = "��������";
			this.btnSetTest.Click += new System.EventHandler(this.btnSetTest_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(208, 160);
			this.btnExit.Name = "btnExit";
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "�˳�";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// frmSetServices
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 192);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSetTest);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmSetServices";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "��������";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.frmSetServices_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void chkServer_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.chkOrdial.Checked==true)
			{
				return;
			}
			if(this.chkServer.Checked==true)
			{
				this.chkClient.Checked=false;
				
				this.cmbTcpServ.Text=System.Net.Dns.GetHostName();

			}
			else
			{
				this.chkClient.Checked=true;
				
			}
		}

		private void chkClient_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.chkOrdial.Checked==true)
			{
				return;
			}
			if(this.chkClient.Checked==true)
			{
				this.chkServer.Checked=false;				
			}
			else
			{
				this.chkServer.Checked=true;			
			}
		}

		private void frmSetServices_Load(object sender, System.EventArgs e)
		{
			try
			{
				XmlDocument xDoc=new XmlDocument();
			
				xDoc.Load("Info.xml");
				this.txtPort.Text =xDoc.DocumentElement.SelectSingleNode("./socketPort").InnerText;
				this.cmbTcpServ.Text=xDoc.DocumentElement.SelectSingleNode("./tcpServer").InnerText;
				string strName=xDoc.DocumentElement.SelectSingleNode("./tcpServer").Attributes.GetNamedItem("name").Value.ToString().Trim();
				if(strName=="client")
				{
					this.chkClient.Checked=true;
				}
				else
				{
					if(strName=="server")
					{
						this.chkServer.Checked=true;
					}
					
				}			
				
				this.cmbTcpServ.Items.Add(System.Net.Dns.GetHostName());
			 }
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}

			
		}

		private void btnSetTest_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.chkOrdial.Checked==true)
				{
					XmlDocument xDoc=new XmlDocument();
					xDoc.Load("Info.xml");
					xDoc.DocumentElement.SelectSingleNode("./tcpServer").Attributes.GetNamedItem("name").Value="";
					xDoc.Save("Info.xml");
					MessageBox.Show("������ɣ�");
					return;
				}
				if(this.chkServer.Checked==true)
				{
					//������
					this.cmbTcpServ.Text=System.Net.Dns.GetHostName();

					if(this.txtPort.Text.Trim()=="")
					{
						MessageBox.Show("����д�˿ںţ�");
						return;
					}

					if(this.cmbTcpServ.Text.Trim()=="")
					{
						MessageBox.Show("����д���������ƣ�");
						return;
					}

					GprsSoft.serverMonitor.CServerMonitor cSerMon=new GprsSoft.serverMonitor.CServerMonitor();		
				
					//�򿪼���
					if(cSerMon.openWebRemoting(this.txtPort.Text.Trim())==true)
					{
						//cSerMon.closeWebRemote();
						XmlDocument xDoc=new XmlDocument();
						xDoc.Load("Info.xml");
						xDoc.DocumentElement.SelectSingleNode("./socketPort").InnerText=this.txtPort.Text;
						xDoc.DocumentElement.SelectSingleNode("./tcpServer").InnerText=this.cmbTcpServ.Text;
						xDoc.DocumentElement.SelectSingleNode("./tcpServer").Attributes.GetNamedItem("name").Value="server";
						xDoc.Save("Info.xml");						
					}
					else
					{
						MessageBox.Show("��������ʧ�ܣ�");	
						return;
					}
					MessageBox.Show("�������óɹ���");
				}	
				else
				{
					if(this.chkClient.Checked==true)
					{
						//�ͻ���
						XmlDocument xDoc=new XmlDocument();
						xDoc.Load("Info.xml");

						if(this.txtPort.Text.Trim()=="")
						{
							MessageBox.Show("����д�˿ںţ�");
							return;
						}

						string strSocketPort="";
						strSocketPort=this.txtPort.Text.Trim();
						int iPort=Convert.ToInt32(strSocketPort);

						if(this.cmbTcpServ.Text.Trim()=="")
						{
							MessageBox.Show("����д���������ƣ�");
							return;
						}
						string strServer="";
						strServer=this.cmbTcpServ.Text.Trim();

						string strUrl=String.Format("tcp://{1}:{0}/serverMonitor",iPort.ToString(),strServer);
						GprsSoft.serverMonitor.CServer  cServerObj = (GprsSoft.serverMonitor.CServer)Activator.GetObject(typeof(GprsSoft.serverMonitor.CServer), strUrl);
						//CDBConnection.m_cServerMonObj=cServerObj;
						if(cServerObj==null)
						{
							cServerObj=null;
							MessageBox.Show("����ʧ�ܣ���������������Ƿ�򿪣�");
							return;
						}
						try
						{
							cServerObj.getRefreshTime();
							MessageBox.Show("���ӳɹ���");
						}
						catch(Exception ex)
						{
							cServerObj=null;
							MessageBox.Show("����ʧ�ܣ���������������Ƿ�򿪣�");
							return;
						}			
						
						xDoc.DocumentElement.SelectSingleNode("./socketPort").InnerText=this.txtPort.Text;
						xDoc.DocumentElement.SelectSingleNode("./tcpServer").InnerText=this.cmbTcpServ.Text;
						xDoc.DocumentElement.SelectSingleNode("./tcpServer").Attributes.GetNamedItem("name").Value="client";
						xDoc.Save("Info.xml");
					}
					else
					{
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void chkOrdial_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.chkOrdial.Checked==true)
			{
				this.chkClient.Checked=false;
				this.chkServer.Checked=false;
			}
		}

	
	}
}
