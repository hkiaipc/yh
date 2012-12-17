using System;
using System.Windows;
using System.Windows.Forms;
using System.Data;
using System.Xml;

namespace BengZhan.comReport.zedGraph
{
	/// <summary>
	/// CmyPaintChart ��ժҪ˵����
	/// </summary>
	public class CmyPaintChart
	{
		public CmyPaintChart()
		{
			
		}	

		private static bool getEDataType(string strCDataType,ref string strEDataType)
		{
			try
			{
				XmlDocument xDoc=new XmlDocument();
				xDoc.Load("columnName.xml");

				for(int i=0;i<xDoc.DocumentElement.ChildNodes.Count;i++)
				{
					if(xDoc.DocumentElement.ChildNodes[i].Attributes.GetNamedItem("des").Value.ToString().Trim()==strCDataType)
					{
						strEDataType=xDoc.DocumentElement.ChildNodes[i].Attributes.GetNamedItem("ename").Value.ToString().Trim();
						return true;
					}
				}

				return true;
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}

		}

		private static void clearDt(ref DataTable dt)
		{
			for(int i=0;i<dt.Rows.Count;i++)
			{
				if(dt.Rows[i]["time"]==null)
				{
					dt.Rows.RemoveAt(i);
					i--;
				}
				if(dt.Rows[i]["time"].ToString().Trim()=="")
				{
					dt.Rows.RemoveAt(i);
					i--;
				}
			}

			for(int i=0;i<dt.Rows.Count;i++)
			{
				for(int j=0;j<dt.Columns.Count;j++)
				{
					if(dt.Rows[i][j]==null)
					{
						dt.Rows[i][j]=0;

					}
					if(dt.Rows[i][j].ToString().Trim()=="")
					
					{
						dt.Rows[i][j]=0;
					}
				}
			}
		}

		
		//����ͼ��(���վ)
		public static bool paintChartDetail(string strFrom,string strTo,string strWellNo,string strCDataType,ZedGraph.ZedGraphControl zedChart)
		{
			try
			{
				DataTable dtDetail=new DataTable();

				if(BengZhan.comReport.CReports.getDtDetailReport(strWellNo,strFrom,strTo,ref dtDetail)==false)
				{
					return false;
				}

				clearDt(ref dtDetail);

				if(dtDetail==null)
				{
					return false;
				}
			
				string strDataType="";
				if(getEDataType(strCDataType,ref strDataType)==false)
				{
					return false;
				}

				DataTable dtChart=new DataTable();
				dtChart.Columns.Add("x");
				dtChart.Columns.Add("y");

				for(int i=0;i<dtDetail.Rows.Count;i++)
				{
					DataRow dr=dtChart.NewRow();
					dr["x"]=dtDetail.Rows[i]["time"].ToString().Trim();
					dr["y"]=dtDetail.Rows[i][strDataType].ToString().Trim();
					dtChart.Rows.Add(dr);
				}

				string strSql=String.Format("select wellName from tbWell where wellNo='{0}'",strWellNo);
				string strWellName=BengZhan.CDBConnection.ExecuteScalar(strSql);

				string strTitle=String.Format("��ϸ��ͼ��  ���վ:{0}  ʱ�䷶Χ{1}��{2}",strWellName,strFrom,strTo);                

				return paintChart(dtChart,strCDataType,"ʱ��","Day",strTitle,zedChart);                				
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}

        //����ͼ��(��λ)
		public static bool paintChartDetailDep(string strFrom,string strTo,string strDepName,string strCDataType,ZedGraph.ZedGraphControl zedChart)
		{
			try
			{
				DataTable dtDetail=new DataTable();

				if(BengZhan.comReport.CReports.getDtDetailReportDep(strDepName,strFrom,strTo,ref dtDetail)==false)
				{
					return false;
				}

				clearDt(ref dtDetail);

				if(dtDetail==null)
				{
					return false;
				}
			
				string strDataType="";
				if(getEDataType(strCDataType,ref strDataType)==false)
				{
					return false;
				}

				DataTable dtChart=new DataTable();
				dtChart.Columns.Add("x");
				dtChart.Columns.Add("y");

				for(int i=0;i<dtDetail.Rows.Count;i++)
				{
					DataRow dr=dtChart.NewRow();
					dr["x"]=dtDetail.Rows[i]["time"].ToString().Trim();
					dr["y"]=dtDetail.Rows[i][strDataType].ToString().Trim();
					dtChart.Rows.Add(dr);
				}

				string strTitle=String.Format("��ϸ��ͼ��  ��λ:{0}  ʱ�䷶Χ{1}��{2}",strDepName,strFrom,strTo);                

				return paintChart(dtChart,strCDataType,"ʱ��","Day",strTitle,zedChart);                				
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}

		public static bool paintChartAvgMonthDep(string strFrom,string strTo,string strZhanNo,string strCDataType,ZedGraph.ZedGraphControl zedChart)
		{
			try
			{		
				DataTable dtAvg=new DataTable();

				if(BengZhan.comReport.CReports.getDtMonthAvgReportDep(strZhanNo,strFrom,strTo,ref dtAvg)==false)
				{
					return false;
				}
		
				clearDt(ref dtAvg);

				if(dtAvg==null)
				{
					return false;
				}

				string strDataType="";
				if(getEDataType(strCDataType,ref strDataType)==false)
				{
					return false;
				}

				DataTable dtChart=new DataTable();
				dtChart.Columns.Add("x");
				dtChart.Columns.Add("y");

				for(int i=0;i<dtAvg.Rows.Count;i++)
				{
					DataRow dr=dtChart.NewRow();
					dr["x"]=dtAvg.Rows[i]["time"].ToString().Trim();
					dr["y"]=dtAvg.Rows[i][strDataType].ToString().Trim();
					dtChart.Rows.Add(dr);
				}

				strFrom=strFrom.Substring(0,7);

				strFrom=strFrom.Replace("-","��");
				strFrom=strFrom+"��";

	         strTo=strTo.Substring(0,7);

				strTo=strTo.Replace("-","��");
				strTo=strTo+"��";

				string strTitle=String.Format("��ͳ��ֵͼ��  ��λ:{0}  ʱ�䷶Χ{1}��{2}",strZhanNo,strFrom,strTo);

				return paintChartMonth(dtChart,strCDataType,"�·�","month",strTitle,zedChart);        
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}

		public static bool paintChartAvgMonth(string strFrom,string strTo,string strZhanNo,string strCDataType,ZedGraph.ZedGraphControl zedChart)
		{
			try
			{		
				DataTable dtAvg=new DataTable();

				if(BengZhan.comReport.CReports.getDtMonthAvgReport(strZhanNo,strFrom,strTo,ref dtAvg)==false)
				{
					return false;
				}
		
				clearDt(ref dtAvg);

				if(dtAvg==null)
				{
					return false;
				}

				string strDataType="";
				if(getEDataType(strCDataType,ref strDataType)==false)
				{
					return false;
				}

				DataTable dtChart=new DataTable();
				dtChart.Columns.Add("x");
				dtChart.Columns.Add("y");

				for(int i=0;i<dtAvg.Rows.Count;i++)
				{
					DataRow dr=dtChart.NewRow();
					dr["x"]=dtAvg.Rows[i]["time"].ToString().Trim();
					dr["y"]=dtAvg.Rows[i][strDataType].ToString().Trim();
					dtChart.Rows.Add(dr);
				}

				string strSql=String.Format("select wellName from tbWell where wellNo='{0}'",strZhanNo);
				string strWellName=BengZhan.CDBConnection.ExecuteScalar(strSql);
				strFrom=strFrom.Replace("-","��");
				strFrom=strFrom+"��";

			     strTo=strTo.Replace("-","��");
				 strTo=strTo+"��";

				string strTitle=String.Format("��ͳ��ֵͼ��  ���վ:{0}  ʱ�䷶Χ{1}��{2}",strWellName,strFrom,strTo);

				return paintChartMonth(dtChart,strCDataType,"�·�","month",strTitle,zedChart);        
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}

		public static bool paintChartAvgDep(string strFrom,string strTo,string strDepName,string strCDataType,ZedGraph.ZedGraphControl zedChart)
		{
			try
			{		
				DataTable dtAvg=new DataTable();

				if(BengZhan.comReport.CReports.getDtAvgReportDep(strDepName,strFrom,strTo,ref dtAvg)==false)
				{
					return false;
				}
		
				clearDt(ref dtAvg);

				if(dtAvg==null)
				{
					return false;
				}

				string strDataType="";
				if(getEDataType(strCDataType,ref strDataType)==false)
				{
					return false;
				}

				DataTable dtChart=new DataTable();
				dtChart.Columns.Add("x");
				dtChart.Columns.Add("y");

				for(int i=0;i<dtAvg.Rows.Count;i++)
				{
					DataRow dr=dtChart.NewRow();
					dr["x"]=dtAvg.Rows[i]["time"].ToString().Trim();
					dr["y"]=dtAvg.Rows[i][strDataType].ToString().Trim();
					dtChart.Rows.Add(dr);
				}

				string strTitle=String.Format("��ͳ��ֵͼ��  ��λ:{0}  ʱ�䷶Χ{1}��{2}",strDepName,strFrom,strTo);

				return paintChart(dtChart,strCDataType,"����","month",strTitle,zedChart);        
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}


		public static bool paintChartAvg(string strFrom,string strTo,string strWellNo,string strCDataType,ZedGraph.ZedGraphControl zedChart)
		{
			try
			{		
				DataTable dtAvg=new DataTable();

				if(BengZhan.comReport.CReports.getDtAvgReport(strWellNo,strFrom,strTo,ref dtAvg)==false)
				{
					return false;
				}
		
				clearDt(ref dtAvg);

				if(dtAvg==null)
				{
					return false;
				}

				string strDataType="";
				if(getEDataType(strCDataType,ref strDataType)==false)
				{
					return false;
				}

				DataTable dtChart=new DataTable();
				dtChart.Columns.Add("x");
				dtChart.Columns.Add("y");

				for(int i=0;i<dtAvg.Rows.Count;i++)
				{
					DataRow dr=dtChart.NewRow();
					dr["x"]=dtAvg.Rows[i]["time"].ToString().Trim();
					dr["y"]=dtAvg.Rows[i][strDataType].ToString().Trim();
					dtChart.Rows.Add(dr);
				}

				string strSql=String.Format("select wellName from tbWell where wellNo='{0}'",strWellNo);
				string strWellName=BengZhan.CDBConnection.ExecuteScalar(strSql);

				string strTitle=String.Format("��ͳ��ֵͼ��  ���վ:{0}  ʱ�䷶Χ{1}��{2}",strWellName,strFrom,strTo);

				return paintChart(dtChart,strCDataType,"����","month",strTitle,zedChart);        
				
			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}
	
		private static bool paintChart(DataTable dtLine1,string strLineName,string strXTitle,string strState,string strTitle,ZedGraph.ZedGraphControl zedChart)
		{
			try
			{
				//lblInfo.Text=strTitle;

				ZedGraph.Demo.DateAxisSampleDemo demo = new ZedGraph.Demo.DateAxisSampleDemo();				

				demo.m_dtLine1 =dtLine1;				

				demo.m_dtLine2=new DataTable();
				//��һ��������
				demo.m_strLine1Name=strLineName;
				//�ڶ���������
				demo.m_strLine2Name="";				
				demo.m_strState=strState;
				demo.m_strTitle=strTitle;
				demo.m_xAxisTitle=strXTitle;

				demo.initialDateAxis(zedChart);			
			
				if ( demo == null )
					return false;			
				return true;

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}

		private static bool paintChartMonth(DataTable dtLine1,string strLineName,string strXTitle,string strState,string strTitle,ZedGraph.ZedGraphControl zedChart)
		{
			try
			{
				//lblInfo.Text=strTitle;

				ZedGraph.Demo.DateAxisSampleDemo demo = new ZedGraph.Demo.DateAxisSampleDemo();				

				demo.m_dtLine1 =dtLine1;				

				demo.m_dtLine2=new DataTable();
				//��һ��������
				demo.m_strLine1Name=strLineName;
				//�ڶ���������
				demo.m_strLine2Name="";				
				demo.m_strState=strState;
				demo.m_strTitle=strTitle;
				demo.m_xAxisTitle=strXTitle;

				demo.initialDateAxisMonth(zedChart);			
			
				if ( demo == null )
					return false;			
				return true;

			}
			catch(Exception ex)
			{
				cSaveErr.CSaveErr.msgboxErr(ex.ToString());
				return false;
			}
		}



	}
}
