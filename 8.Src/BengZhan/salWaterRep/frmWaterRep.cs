using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
namespace BengZhan.salWaterRep
{
	/// <summary>
	/// frm ��ժҪ˵����
	/// </summary>
	public class frmSalWaterRep : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDisp;
		private System.Windows.Forms.Button btnExit;
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crpSalWater;
		private System.Windows.Forms.GroupBox grp1;
		private System.Windows.Forms.DateTimePicker dtpFrom;
		private System.Windows.Forms.DateTimePicker dtpTo;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbCountry;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TreeView trv;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmSalWaterRep()
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
			this.grp1 = new System.Windows.Forms.GroupBox();
			this.trv = new System.Windows.Forms.TreeView();
			this.crpSalWater = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnDisp = new System.Windows.Forms.Button();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbCountry = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.grp1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// grp1
			// 
			this.grp1.Controls.Add(this.trv);
			this.grp1.Location = new System.Drawing.Point(8, 64);
			this.grp1.Name = "grp1";
			this.grp1.Size = new System.Drawing.Size(224, 488);
			this.grp1.TabIndex = 0;
			this.grp1.TabStop = false;
			// 
			// trv
			// 
			this.trv.ImageIndex = -1;
			this.trv.Location = new System.Drawing.Point(8, 16);
			this.trv.Name = "trv";
			this.trv.SelectedImageIndex = -1;
			this.trv.Size = new System.Drawing.Size(208, 464);
			this.trv.TabIndex = 0;
			this.trv.Click += new System.EventHandler(this.trv_Click);
			this.trv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trv_AfterSelect);
			// 
			// crpSalWater
			// 
			this.crpSalWater.ActiveViewIndex = -1;
			this.crpSalWater.Location = new System.Drawing.Point(240, 64);
			this.crpSalWater.Name = "crpSalWater";
			this.crpSalWater.ReportSource = null;
			this.crpSalWater.ShowExportButton = false;
			this.crpSalWater.Size = new System.Drawing.Size(536, 456);
			this.crpSalWater.TabIndex = 1;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnExit);
			this.groupBox2.Controls.Add(this.btnDisp);
			this.groupBox2.Controls.Add(this.dtpTo);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.dtpFrom);
			this.groupBox2.Location = new System.Drawing.Point(240, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(488, 48);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(400, 17);
			this.btnExit.Name = "btnExit";
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "�˳�";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnDisp
			// 
			this.btnDisp.Location = new System.Drawing.Point(296, 17);
			this.btnDisp.Name = "btnDisp";
			this.btnDisp.TabIndex = 3;
			this.btnDisp.Text = "ͳ�Ʊ���";
			this.btnDisp.Click += new System.EventHandler(this.btnDisp_Click);
			// 
			// dtpTo
			// 
			this.dtpTo.Location = new System.Drawing.Point(176, 16);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(96, 21);
			this.dtpTo.TabIndex = 2;
			this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(128, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "����";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpFrom
			// 
			this.dtpFrom.Location = new System.Drawing.Point(8, 16);
			this.dtpFrom.Name = "dtpFrom";
			this.dtpFrom.Size = new System.Drawing.Size(112, 21);
			this.dtpFrom.TabIndex = 0;
			this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbCountry);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(224, 48);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			// 
			// cmbCountry
			// 
			this.cmbCountry.Location = new System.Drawing.Point(88, 13);
			this.cmbCountry.Name = "cmbCountry";
			this.cmbCountry.Size = new System.Drawing.Size(136, 20);
			this.cmbCountry.TabIndex = 3;
			this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "��������";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// frmSalWaterRep
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(832, 542);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.crpSalWater);
			this.Controls.Add(this.grp1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmSalWaterRep";
			this.Text = "��ˮ���";
			this.Load += new System.EventHandler(this.frmSalWaterRep_Load);
			this.grp1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmSalWaterRep_Load(object sender, System.EventArgs e)
		{
			this.dtpTo.Value=this.dtpFrom.Value.AddDays(1);
			this.paintFrmSize();
			tools.CPaintForm.paintCountry(this.cmbCountry);
			this.paintTrvWell();
			this.paintReport("","");

		}
		//��䴰��ؼ�
		private void paintFrmSize()
		{
			try
			{
				this.grp1.Height=this.Height-this.grp1.Top-40;
				this.trv.Height=this.grp1.Height-25;
				this.crpSalWater.Width=this.Width-this.crpSalWater.Left-20;
				this.crpSalWater.Height=this.Height-this.crpSalWater.Top-40;
				this.crpSalWater.DisplayGroupTree=false;

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		//
		private  bool paintTrvWell()
		{
			try
			{
				this.trv.Nodes.Clear();

				tools.CPaintForm.paintWell(this.cmbCountry.Text,this.trv);
				
				this.trv.Nodes.Add("���в���Ա");
				string strSql="select userName from tbUsers";
				DataTable dt=null;
				CDBConnection.getDataTable(ref dt,strSql,"tbUsers");

				for(int i=0;i<dt.Rows.Count;i++)
				{
					this.trv.Nodes[1].Nodes.Add(dt.Rows[i]["userName"].ToString());
				}
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}
		//
		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		
		private void dtpTo_ValueChanged(object sender, System.EventArgs e)
		{
			//this.paintReport();
		}

		private void dtpFrom_ValueChanged(object sender, System.EventArgs e)
		{
			//this.paintReport();
		}

		private void trv_Click(object sender, System.EventArgs e)
		{
			//this.paintReport();
		}		
		private void btnDisp_Click(object sender, System.EventArgs e)
		{

			this.paintReport();	
		}

		private void trv_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			//this.paintReport();			
		}
		// ������ʾ
		private void paintReport()
		{
			try
			{
				string strWellNo="";
				string strManaName="";

				if(this.trv.SelectedNode!=null)
				{
					string strNText=this.trv.SelectedNode.Text;
					if(strNText.IndexOf("|")>0)
					{
						strWellNo=strNText.Substring(0,strNText.IndexOf("|"));
					}
					else
					{
						if(this.trv.SelectedNode.Parent!=null)
						{
							strManaName=this.trv.SelectedNode.Text.Trim();
						}
					}
				}
				if(strWellNo.Trim()!="")
				{
					this.paintReport(strWellNo,"");
					return;
				}
				if(strManaName.Trim()!="")
				{
					//����Աͳ��
					this.paintReport("",strManaName);
					return;
				}
				//δѡ����վ,��ʾ����
				this.paintReport("","");			
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void cmbCountry_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.paintTrvWell();
		}
		//*******************���ݿ������*****************
		#region"���ݿ��ѯ"
/// <summary>
/// ����
/// </summary>
/// <param name="strWellNo">���վ���</param>
/// <param name="strUserName">����Ա����</param>
		private void paintReport(string strWellNo,string strUserName)
		{
			try
			{
				string strFrom=String.Format("{0}-{1}-{2}",this.dtpFrom.Value.Year.ToString(),this.dtpFrom.Value.Month.ToString(),this.dtpFrom.Value.Day.ToString());
				string strTo=String.Format("{0}-{1}-{2}",this.dtpTo.Value.Year.ToString(),this.dtpTo.Value.Month.ToString(),this.dtpTo.Value.Day.ToString());
				string strTitle="";
				
				
				//���վͳ��sql1******************************sql���
				string strSql=String.Format("select tbSal.wellNo as Field1,depName as Field2,price as Field3,salMony as Field4,salAmount as Field5,salPer as Field6,time as Field7 from tbSal,tbWell where (cast(floor(cast(time as float)) as datetime) between '{0}' and '{1}') and tbSal.wellNo=tbWell.wellNo and tbSal.wellNo='{2}' order by time",strFrom,strTo,strWellNo);
				strTitle="��λ��ˮͳ�Ʊ�";
				if(strWellNo.Trim()=="")
				{
					if(strUserName.Trim()=="")
					{
						//�޲�ѯ����sql2
						strSql=String.Format("select tbSal.wellNo as Field1,depName as Field2,price as Field3,salMony as Field4,salAmount as Field5,salPer as Field6,time as Field7 from tbSal,tbWell where (cast(floor(cast(time as float)) as datetime) between '{0}' and '{1}') and tbSal.wellNo=tbWell.wellNo order by time",strFrom,strTo);						
					}
					else
					{						
						//����Աͳ��sql3*****
						strSql=String.Format("select tbSal.wellNo as Field1,depName as Field2,price as Field3,salMony as Field4,salAmount as Field5,salPer as Field6,time as Field7 from tbSal,tbWell where (cast(floor(cast(time as float)) as datetime) between '{0}' and '{1}') and tbSal.wellNo=tbWell.wellNo and tbSal.salPer='{2}' order by time",strFrom,strTo,strUserName);
						strTitle="����Ա��ˮͳ�Ʊ�";
					}
					
				}
				//**************************************

				
				//ͳ�ƺϼ�
				DataTable dt=null;
				CDBConnection.getDataTable(ref dt,strSql,"tbSalWater");				
				double iSalAmount=0,iSalMony=0;
				for(int i=0;i<dt.Rows.Count;i++)
				{
					iSalAmount=iSalAmount+Convert.ToDouble(dt.Rows[i]["Field5"]);
					iSalMony=iSalMony+Convert.ToDouble(dt.Rows[i]["Field4"]);
				}
				DataRow dr=dt.NewRow();
				dr["Field1"]="�ϼ�";
				dr["Field4"]=iSalMony.ToString();
				dr["Field5"]=iSalAmount.ToString();
				dt.Rows.Add(dr);
				//************************

				//������ʾ
				string strTime=String.Format("ʱ�䷶Χ��{0}��{1}",strFrom,strTo);
				string[] strText=new string[7];
				strText[0]="���վ���";
				strText[1]="��λ����";
				strText[2]="��ˮ����";
				strText[3]="��ˮ���";
				strText[4]="��ˮ��";
				strText[5]="��ˮ��";
				strText[6]="��ˮʱ��";

				printDoc.crpPrint crpPrintObj=new BengZhan.printDoc.crpPrint();
				CrystalDecisions.CrystalReports.Engine.TextObject toTitle=(CrystalDecisions.CrystalReports.Engine.TextObject)crpPrintObj.ReportDefinition.ReportObjects["txtTime"];
				toTitle.Text=strTime;
				toTitle=(CrystalDecisions.CrystalReports.Engine.TextObject)crpPrintObj.ReportDefinition.ReportObjects["txtTitle"];
				if(strTitle!="")
				{
					toTitle.Text=strTitle;
				}				
				for(int i=0;i<7;i++)
				{
					int iNum=i+1;
					string strTextTitle="Text"+iNum.ToString();
					CrystalDecisions.CrystalReports.Engine.TextObject to=(CrystalDecisions.CrystalReports.Engine.TextObject)crpPrintObj.ReportDefinition.ReportObjects[strTextTitle];					
					to.Text=strText[i].ToString();
				}	
						
				crpPrintObj.SetDataSource(dt);
				this.crpSalWater.ReportSource=crpPrintObj;


			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		#endregion
		//************************************************


	}
}
