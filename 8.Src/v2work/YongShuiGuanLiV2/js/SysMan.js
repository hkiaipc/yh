//-----------------------改变alert的风格
function window.alert(strText){
	var pWin=window.showModalDialog("alert.htm",strText,"dialogHeight:116px; dialogWidth:232px; help: No; resizable: no; status: No; scroll:no; dialogTop:"+(screen.height-116)/2+"px; dialogLeft:"+(screen.width-232)/2+"px;");
}


//--------------列表显示相关begin---------------------------

function ChkSelectAll(choice) {
	
    for(i = 0; i < document.formList.elements.length; ++i){

        if (document.formList.elements[i].name == "check"){
            if (choice == 1) document.formList.elements[i].checked = true;
            else  document.formList.elements[i].checked = false;
        }
    }
}
function SelectChg(id,para_id) {
    for(i = 0; i < document.formList.elements.length; ++i){
        if ((document.formList.elements[i].name ==id) && (document.formList.elements[i].value == para_id)){
            if (document.formList.elements[i-1].name == "check"){
               if (document.formList.elements[i-1].checked)
                          document.formList.elements[i-1].checked = false;
               else  document.formList.elements[i-1].checked = true;
            }
        }
     };
}


function DeleSelectd(strUrl,moduleId)
{
	
        var id=1;
        var SelectIds="";
        var multiple=0;
        var yes=0;
	for(i = 0; i < document.formList.elements.length; ++i){
           if (document.formList.elements[i].name == "check"){
               if (document.formList.elements[i].checked){
                id = document.formList.elements[i+1].value;
                if(multiple==0){SelectIds += id;multiple=1;}
                 else SelectIds += ","+id;
                 yes=1;
                 //break;  //只取一条，如果要同时选取条，去掉此语句即可
               }
            }
 	};
        if(yes==1){
        
          
	if(strUrl=="/OA/userAction.do")
	{
		if(confirm("删除选中的用户？")==false)
		{
			return;
		}
	}
	if(strUrl=="/OA/roleAction.do")
	{
		if(confirm("确定删除选中的角色？")==false)
		{
			return;
		}
	}
	
	if(strUrl=="/OA/orgAction.do")
	{
		
		
		if(confirm("将删除该部门所有下级部门,确定删除？")==false)
		{
			return;
		}
	}
	
	
	if(strUrl=="/OA/moduleAction.do")
	{
		if(confirm("将删除该模块所有下级模块,确定删除？")==false)
		{
			return;
		}
	}
	


	
	if(strUrl=="/OA/tempOrgAction.do")
	{
		if(confirm("确定删除选定的团队？")==false)
		{
			return;
		}
	}
	
	
	if(strUrl=="/OA/rankAction.do")
	{
		if(confirm("将删除该职务及其所有下级职务,确定删除？")==false)
		{
			return;
		}
	}
	

           this.location =strUrl+ "?type=Delete&expression="+SelectIds+"&moduleId="+moduleId;
            
        }
        else alert("请选中一行记录！");
}

function Add(strUrl,moduleId)
{
 var allNodes="";
  for(i = 0; i < document.formList.elements.length; ++i){
        if (document.formList.elements[i].name == "allNodes"){
           allNodes=document.formList.elements[i].value;
           break;
        }
    }
 this.location = strUrl+"?type=new"+"&moduleId="+moduleId;
}

function SelectdDetail(strUrl,moduleId){
        var id=1;
        var SelectIds="";
        var multiple=0;
        var yes=0;
	for(i = 0; i < document.formList.elements.length; ++i){
           if (document.formList.elements[i].name == "check"){
               if (document.formList.elements[i].checked){
                 id = document.formList.elements[i+1].value;
                 if(multiple==0){SelectIds += id;multiple=1;}
                 else SelectIds += ","+id;
                 yes=1;
                 break;  //只取一条，如果要同时选取条，去掉此语句即可
               }
            }
 	};
        if(yes==1){
            this.location = strUrl+"?type=Detail&expression="+SelectIds+"&moduleId="+moduleId;
        }
        else alert("请选中一行记录！");
}
//--------------列表显示相关end---------------------------


//打开树形窗口
function OpenMods(newurl)
{


var url=newurl+"select.aspx";
 var  top=((window.screen.availHeight-380)/2);  
var  left=((window.screen.availWidth-350)/2);

 window.open(url,"choose","left="+left+",top="+top+",width=350,height=380,scrollbars=1,status=1,fullscreen=0,resizable=1,menubar=0,toolbar=0,location=0");

}
//---------------显示树相关begin----------------------
function getObjectById(id)
    {
      if (typeof(id) != "string" || id == "") return null;
      if (document.all) return document.all(id);
      if (document.getElementById) return document.getElementById(id);
      try {return eval(id);} catch(e){ return null;}
    }
 
  
   function set(id,name)
   {
     var NodeId=getObjectById("NodeId");
     NodeId.value=id;
     var NodeName=getObjectById("NodeName");
     NodeName.value=name;
   }
   
   function WriteBack()
    {
    var NodeId=getObjectById("NodeId");
    var NodeName=getObjectById("NodeName");
    
    opener.document.all.fatherId.value= NodeId.value;
    opener.document.all.fatherName.value= NodeName.value;
    window.close();
   } 
//---------------显示树相关end----------------------
   
//-----------------多选框操作begin---------------------------------

function SelectMove(obj,obj2)
{//删除选定项
   for(var i=obj.length-1;i>=0;i--){
     if(obj.options[i].selected){
      var val=obj.options[i].value;
      var txt=obj.options[i].text;
      AddOnTo(obj2,val,txt);
      obj.remove(i);
     }
   }
}

function SelectAll(obj,obj2)
{//删除选定项
   for(var i=obj.length-1;i>=0;i--){
      var val=obj.options[i].value;
      var txt=obj.options[i].text;
      AddOnTo(obj2,val,txt);
      obj.remove(i);
   }
}

function UnSelectAll(obj,obj2)
{//删除选定项
  for(var i=obj.length-1;i>=0;i--){
      var val=obj.options[i].value;
      var txt=obj.options[i].text;
      AddOnTo(obj2,val,txt);
      obj.remove(i);
   }
}

function UnSelectMove(obj,obj2)
{//删除选定项
   for(var i=obj.length-1;i>=0;i--){
     if(obj.options[i].selected){
      var val=obj.options[i].value;
      var txt=obj.options[i].text;
      AddOnTo(obj2,val,txt);
      obj.remove(i);
     }
   }
}

function AddOnTo(obj,val,txt)
{ //增加一项
   if(CheckExists(obj,val,txt)) {
     //alert('选项已存在：['+obj.id+']'+'\n  Value: '+ val+'\n  Text: '+txt);
     return;
   }
   var opt=new Option();
   opt.value=val;
   opt.text=txt;
   obj.options.add(opt,0);
}

function AddTo(src,obj)
{//往指定列表添加选项
   for(var i=0;i<src.length;i++){
     if(src.options[i].selected){
      AddOnTo(obj,src.options[i].value,src.options[i].text);
     }
   }
}

function CheckExists(obj,val,txt)
{//检查项是否已存在
   if(obj.length<0) return false;
   for(var i=0;i<obj.length;i++){
     if(obj.options[i].value==val && obj.options[i].text==txt) {
      return true;
     }
   }
   return false;
}

function ArrayClear(obj)
{//删除全部选项
   if(obj.length-1>=0){
     for(var i=obj.length-1;i>=0;i--){
      obj.remove(i);
     }
   }
}

function RemoveOne(obj)
{//删除选定项
   for(var i=obj.length-1;i>=0;i--){
     if(obj.options[i].selected){
      obj.remove(i);
     }
   }
}

function ChgDepartRank(obj,obj2)
{
   var val=obj2.value;
   ArrayClear(obj);
   AddOnTo(obj,'0',"");
   if(ArrayRanks.length){
       for(var i=0;i<ArrayRanks.length;i++){
         if (val == 'ALL')
         {
             AddOnTo(obj,ArrayRanks[i][1],ArrayRanks[i][2]);
         }
         else
         {
           if (ArrayRanks[i][0]==val)
           {
             AddOnTo(obj,ArrayRanks[i][1],ArrayRanks[i][2]);
           }
         }
       }
   }

}
function ChgDepart(obj,obj2)
{//部门改变级别列表随之而动
   
   var val=obj2.value;
   
   ArrayClear(obj);
   if(ArrayRanks.length){
       for(var i=0;i<ArrayRanks.length;i++){
         if (val == 'ALL')
         {
             AddOnTo(obj,ArrayRanks[i][1],ArrayRanks[i][2]);
         }
         else
         {
           if (ArrayRanks[i][0]==val)
           {
             AddOnTo(obj,ArrayRanks[i][1],ArrayRanks[i][2]);
           }
         }
       }
   }
}
function addFromTo(mulOne, mulTwo) {
    var opts = mulOne.options;   
         for (var i = 0; i < opts.length; i++) {
        if (opts[i].selected == true) {
            var opi = document.createElement("OPTION");
            opi.text=opts[i].text;
            opi.value=opts[i].value;
             var m2ops = mulTwo.options;
            var mtl = m2ops.length;
            if (mtl == 0) {
                mulTwo.add(opi);
                
            }
            else {
                var hasOpt = false;
                for (var j = 0; j < mtl; j++) {
                    if (opi.value == m2ops[j].value) {
                        hasOpt = true;
                        break;
                    }
                }
                if (hasOpt == false) {
                    mulTwo.add(opi);
                     
                }
            }
        }
    }
}
function addAllFromTo(mulOne, mulTwo) {
    var opts = mulOne.options;   
    for (var i = 0; i < opts.length; i++) {
        var opi = document.createElement("OPTION");
        opi.text=opts[i].text;
        opi.value=opts[i].value;

        var m2ops = mulTwo.options;
        var mtl = m2ops.length;
        if (mtl == 0) {
            mulTwo.add(opi);
          
        }
        else {
            var hasOpt = false;
            for (var j = 0; j < mtl; j++) {
                if (opi.value == m2ops[j].value) {
                    hasOpt = true;
                    break;
                }
            }
            if (hasOpt == false) {
                mulTwo.add(opi);
               
            }
        }
    }
}
function removeFrom(mulTwo) {
    var opts = mulTwo.options;
    var initLength = opts.length;
    for (var i = 0; i < initLength; i++) {
        var opts2 = mulTwo.options;
        for (var j = 0; j < opts2.length; j++) {
            if (opts2[j].selected == true) {
                mulTwo.remove(j);
            }
        }
    }
}
function removeAllFrom(mulTwo) {
    var opts = mulTwo.options;
    var initLength = opts.length;
    for (var i = 0; i < initLength; i++) {
        var opts2 = mulTwo.options;
        for (var j = 0; j < opts2.length; j++) {
            mulTwo.remove(j);
        }
    }
}


function checkSelect(mulTwo)
{

 var opts = mulTwo.options;
    var initLength = opts.length;
    for (var i = 0; i < initLength; i++) {
        opts[i].selected=true;
        }

}

//-----------------多选框操作end---------------------------------


//------------字符串操作begin---------------------------------

//用value替换pos的值
function StringSet(mystr,pos,value)
{

 var temp = mystr.substring(0,pos);
 temp=temp+value;
 mystr=temp+mystr.substring(pos+1,mystr.length);
 return mystr;

}

//模块ID与权限的分割符为，组与组的分隔为;
function GetRight(){
   var right="";
   for(i = 0; i < document.formList.elements.length; ++i){
        var item=document.formList.elements[i].name;
        if ((item == "check")&&(document.formList.elements[i].checked == true))
        {
          right=right+document.formList.elements[i+1].value+","+document.formList.elements[i+2].value+";";
        }
    }
     return right;

}


function Right(Value,pos){

 var mystr = Value.substring(pos-1,pos);
 //alert(mystr);
 return mystr;


}
//---------------end-----------

function SelectAllNew(choice) {
     var start=4;
     var end=document.formList.elements.length-4;
     var count=(end-start)/8;
     
     for(i =0 ; i <count ; ++i){
     	
            if (choice == 1)
            {
            	            //相应的right也变化
             document.formList.elements[8*i+start].checked=true;
             document.formList.elements[8*i+2+start].value ="11111";
             document.formList.elements[8*i+3+start].checked=true;
             document.formList.elements[8*i+4+start].checked=true;
             document.formList.elements[8*i+5+start].checked=true;
             document.formList.elements[8*i+6+start].checked=true;
             document.formList.elements[8*i+7+start].checked=true;

            }
            else
            {
             //相应的right也变化
             document.formList.elements[8*i+start].checked=false;
             document.formList.elements[8*i+2+start].value ="00000";
             document.formList.elements[8*i+3+start].checked=false;
             document.formList.elements[8*i+4+start].checked=false;
             document.formList.elements[8*i+5+start].checked=false;
             document.formList.elements[8*i+6+start].checked=false;
             document.formList.elements[8*i+7+start].checked=false;
           
        }

    }
}

function SelectAllOld(choice) {
     var start=2;
     var end=document.formList.elements.length-2;
     var count=(end-start)/8;
     
     for(i =0 ; i <count ; ++i){
     	
            if (choice == 1)
            {
            	            //相应的right也变化
             document.formList.elements[8*i+start].checked=true;
             document.formList.elements[8*i+2+start].value ="11111";
             document.formList.elements[8*i+3+start].checked=true;
             document.formList.elements[8*i+4+start].checked=true;
             document.formList.elements[8*i+5+start].checked=true;
             document.formList.elements[8*i+6+start].checked=true;
             document.formList.elements[8*i+7+start].checked=true;

            }
            else
            {
             //相应的right也变化
             document.formList.elements[8*i+start].checked=false;
             document.formList.elements[8*i+2+start].value ="00000";
             document.formList.elements[8*i+3+start].checked=false;
             document.formList.elements[8*i+4+start].checked=false;
             document.formList.elements[8*i+5+start].checked=false;
             document.formList.elements[8*i+6+start].checked=false;
             document.formList.elements[8*i+7+start].checked=false;
           
        }

    }
}



function SelectAllOld2(choice) {
     for(i = 0; i < document.formList.elements.length; ++i){
         var item=document.formList.elements[i].name;
        if ((item == "check")||( item=="search")||(item=="view")||(item=="add")||(item=="delete")||(item=="modify"))
           {
            if (choice == 1)
            {
            //相应的right也变化
             document.formList.elements[i].checked = true;
             if(item=="check")
             document.formList.elements[i+2].value ="11111";

            }
            else
            {
            //相应的right也变化
             document.formList.elements[i].checked = false;
             if(item=="check")
             document.formList.elements[i+2].value ="00000";

            }
        }

    }
}
function init()
{
  for(i = 0; i < document.formList.elements.length; ++i)
  {
      if (document.formList.elements[i].id =="right")
      {
        var RightValue=document.formList.elements[i].value;
        if(Right(RightValue,1)=="1")
        {
       		document.formList.elements[i-2].checked =true;
       		document.formList.elements[i+1].checked =true;
        }
        if(Right(RightValue,2)=="1")
        {
       		document.formList.elements[i-2].checked =true;
       		document.formList.elements[i+2].checked =true;
       	}
        if(Right(RightValue,3)=="1")
        {
       		document.formList.elements[i-2].checked =true;
       		document.formList.elements[i+3].checked =true;
       	}
        if(Right(RightValue,4)=="1")
        {
       		document.formList.elements[i-2].checked =true;
       		document.formList.elements[i+4].checked =true;
       	}
         if(Right(RightValue,5)=="1")
        {
       		document.formList.elements[i-2].checked =true;
       		document.formList.elements[i+5].checked =true;
       	}
      
      }
    }     
}
function fatherCheck(para_id)
{
  //如果权限项被选中,菜单项自动选中
  for(i = 0; i < document.formList.elements.length; ++i){

            if ((document.formList.elements[i].value == para_id)&&(document.formList.elements[i].id =="modId")){

               if((document.formList.elements[i+6].checked ==true)||
                   (document.formList.elements[i+2].checked ==true)||
                   (document.formList.elements[i+3].checked ==true)||
                   (document.formList.elements[i+4].checked ==true)||
                   (document.formList.elements[i+5].checked ==true))
                {

                   document.formList.elements[i-1].checked = true;
                }
                else
                {
                  document.formList.elements[i-1].checked = false;
                }
                if(document.formList.elements[i+2].checked ==true)
                {
                 document.formList.elements[i+1].value=StringSet(document.formList.elements[i+1].value,0,1);
                }
                else
                {
                 document.formList.elements[i+1].value=StringSet(document.formList.elements[i+1].value,0,0);
                }

                if(document.formList.elements[i+3].checked ==true)
                {
                 document.formList.elements[i+1].value=StringSet(document.formList.elements[i+1].value,1,1);
                }
                else
                {
                 document.formList.elements[i+1].value=StringSet(document.formList.elements[i+1].value,1,0);
                }

                if(document.formList.elements[i+4].checked ==true)
                {
                 document.formList.elements[i+1].value=StringSet(document.formList.elements[i+1].value,2,1);
                }
                else
                {
                 document.formList.elements[i+1].value=StringSet(document.formList.elements[i+1].value,2,0);
                }

                if(document.formList.elements[i+5].checked ==true)
                {
                 document.formList.elements[i+1].value=StringSet(document.formList.elements[i+1].value,3,1);
                }
                else
                {
                 document.formList.elements[i+1].value=StringSet(document.formList.elements[i+1].value,3,0);
                }

                if(document.formList.elements[i+6].checked ==true)
                {
                 document.formList.elements[i+1].value=StringSet(document.formList.elements[i+1].value,4,1);
                }
                else
                {
                 document.formList.elements[i+1].value=StringSet(document.formList.elements[i+1].value,4,0);
                }


        }
     };

}

function RowClick(para_id)
{
 //如果控制行的checkbox被选中,权限项自动变化
  for(i = 0; i < document.formList.elements.length; ++i){

     if ((document.formList.elements[i].value == para_id)&&(document.formList.elements[i].id =="modId")){
      if(document.formList.elements[i-1].checked ==true)
      {
       document.formList.elements[i+2].checked =true;
       document.formList.elements[i+3].checked =true;
       document.formList.elements[i+4].checked =true;
       document.formList.elements[i+5].checked =true;
       document.formList.elements[i+6].checked =true;

       document.formList.elements[i+1].value=StringSet(document.formList.elements[i+1].value,0,1);
       document.formList.elements[i+1].value=StringSet(document.formList.elements[i+1].value,1,1);
       document.formList.elements[i+1].value=StringSet(document.formList.elements[i+1].value,2,1);
       document.formList.elements[i+1].value=StringSet(document.formList.elements[i+1].value,3,1);
       document.formList.elements[i+1].value=StringSet(document.formList.elements[i+1].value,4,1);

       }
       else
       {
       document.formList.elements[i+2].checked =false;
       document.formList.elements[i+3].checked =false;
       document.formList.elements[i+4].checked =false;
       document.formList.elements[i+5].checked =false;
       document.formList.elements[i+6].checked =false;
       document.formList.elements[i+1].value=StringSet(document.formList.elements[i+1].value,0,0);
       document.formList.elements[i+1].value=StringSet(document.formList.elements[i+1].value,1,0);
       document.formList.elements[i+1].value=StringSet(document.formList.elements[i+1].value,2,0);
       document.formList.elements[i+1].value=StringSet(document.formList.elements[i+1].value,3,0);
       document.formList.elements[i+1].value=StringSet(document.formList.elements[i+1].value,4,0);


       }

         }

  }


}




