using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using CrystalDecisions.CrystalReports.Engine;
namespace winRep
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

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
			this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// crystalReportViewer1
			// 
			this.crystalReportViewer1.ActiveViewIndex = -1;
			this.crystalReportViewer1.Location = new System.Drawing.Point(8, 40);
			this.crystalReportViewer1.Name = "crystalReportViewer1";
			this.crystalReportViewer1.ReportSource = null;
			this.crystalReportViewer1.Size = new System.Drawing.Size(840, 456);
			this.crystalReportViewer1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(24, 8);
			this.button1.Name = "button1";
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(856, 509);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.crystalReportViewer1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			ReportDocument rd=new   ReportDocument();
			rd.Load("crp2.rpt");
			DataTable dt=new DataTable();		
			dt.Columns.Add("field1");
			dt.Columns.Add("field2");	
			dt.Columns.Add("field3");
			dt.Columns.Add("field4");	
			dt.Columns.Add("field5");
			dt.Columns.Add("field6");
			dt.Columns.Add("field7");
			dt.Columns.Add("field8");
			dt.TableName="tbRep";

			DataRow dr=dt.NewRow();

			dr["field1"]="hello";

			dt.Rows.Add(dr);
		

			CrystalDecisions.CrystalReports.Engine.TextObject ReportTextPrintDate=(CrystalDecisions.CrystalReports.Engine.TextObject)rd.ReportDefinition.ReportObjects["Text1"];

			
ReportTextPrintDate.Text="thank god";


			this.crystalReportViewer1.ReportSource=rd;
		}

		/// <summary>
		/// Ӧ�ó��������ڵ㡣
		/// </summary>
		
	}
}
