using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Xml;

namespace BengZhan.com
{
	/// <summary>
	/// frmMain ��ժҪ˵����
	/// </summary>
	public class frmMain : System.Windows.Forms.Form
	{
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public System.Windows.Forms.Form m_parent;

		public frmMain()
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
			// 
			// frmMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Name = "frmMain";
			this.Text = "frmMain";
			this.Load += new System.EventHandler(this.frmMain_Load);

		}
		#endregion

		private static bool m_bDingFeng=false;

		private void frmMain_Load(object sender, System.EventArgs e)
		{		
			this.Close();
			//openCon();	
			//***************����ϵͳ��ʾ
			if(bDingFeng()==true)
			{		
				BengZhan.dingFengReLi.frmMonitor frmMoniObj=new BengZhan.dingFengReLi.frmMonitor();
				frmMoniObj.MdiParent=this.m_parent;
				frmMoniObj.WindowState=this.WindowState;				
				frmMoniObj.Show();				
			}
			else
			{
				ComSoft.frmMonitorEx frmMoniObj=new ComSoft.frmMonitorEx();
				frmMoniObj.m_sCon=CDBConnection.m_sCon;
				frmMoniObj.MdiParent=this.m_parent;
				frmMoniObj.WindowState=this.WindowState;				
				frmMoniObj.Show();
			}
			//**************************	
			
		}

		#region"���ݿ�����"

		private static bool openCon()
		{
			SqlConnection sCon=new SqlConnection();			
			frmMain.openCon(ref sCon);
			CDBConnection.m_sCon=sCon;
			return true;
		}
		private static bool openCon(ref SqlConnection sCon)
		{
			try
			{
				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("Info.xml");
				string strCon=xDoc.DocumentElement.SelectSingleNode("./sConStr").InnerText.Trim();

				SqlConnection sConEx=new SqlConnection(strCon);
				sConEx.Open();
				sCon=sConEx;
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show("���ݿ�����ʧ�ܣ�");
				return false;
			}
		}
		private static bool bDingFeng()
		{
			try
			{
				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("Info.xml");
				string strBDingFeng=xDoc.DocumentElement.SelectSingleNode("./bDingFeng").Attributes.GetNamedItem("val").Value.ToString().Trim();
				if(strBDingFeng=="true")
				{
					return true;
				}
				else
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

		#endregion
	}
}
