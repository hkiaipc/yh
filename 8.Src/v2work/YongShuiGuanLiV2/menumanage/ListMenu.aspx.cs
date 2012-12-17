using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;


namespace YongShuiGuanLiV2.menumanage
{
	/// <summary>
	/// ListMenu ��ժҪ˵����
	/// </summary>
	public class ListMenu : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button btnDel;
		public string allNodes;
        YongShuiGuanLiDBI.MenuDBI lo = new YongShuiGuanLiDBI.MenuDBI();
		
		private void Page_Load(object sender, System.EventArgs e)
		{
            //String c="";
//			if(!IsPostBack)
//			{
//				if(Request.Params.Count>1)
//				{
//					c=Request.QueryString["para"].ToString();
//				}
//				String user_name=Session["username"].ToString();
//			}

            string admin = Session["admin"].ToString();
            string role_type = lo.role_type(admin);
            allNodes = lo.getAllNodes(role_type);
			//Response.Write("<script type='text/javascript' src=http://localhost/yh/js/MzTreeView10.js> </script>"); 
		}

		#region Web ������������ɵĴ���
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: �õ����� ASP.NET Web ���������������ġ�
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{    
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnDel_Click(object sender, System.EventArgs e)
		{
	      string menuId=Request.Params["NodeId"].ToString();
		  if((menuId=="")||(menuId==null))
		  {
			  
			  
			  String scriptString = "<script language=JavaScript> ";
			  scriptString += "alert('��ѡ��Ҫɾ����ģ�飡')</script>";
			  this.RegisterStartupScript("Script", scriptString);
			   return;	
		  }

		  string fatherId=lo.GetModuleInfo(menuId).Rows[0][1].ToString();
		  if(fatherId=="-1")
		  {
			  String scriptString = "<script language=JavaScript> ";
			  scriptString += "alert('�Բ��𣬲���ɾ����ģ�飡')</script>";
			  this.RegisterStartupScript("Script", scriptString);
			  return;	
		  }
 
		  lo.DelModuleInfo(menuId);
		  Response.Redirect("ListMenu.aspx");
//		  
		}
	}
}
