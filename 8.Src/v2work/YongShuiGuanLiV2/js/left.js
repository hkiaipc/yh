
function exec (command) {
    window.oldOnError = window.onerror;
    window._command = command;
    window.onerror = function (err) {
      if (err.indexOf('utomation') != -1) {
        alert('�����Ѿ����û���ֹ��'); 
        return true;
      }
      else return false;
    };
    var wsh = new ActiveXObject('WScript.Shell');
    if (wsh)
      wsh.Run(command);
    window.onerror = window.oldOnError;
   
  }

function exeaspx (command) {
    var win = window.open("command",null,"width=700,height=200");
   
  }
  
function menuChange(obj,menu)
{
	if(menu.style.display=="")
	{
		obj.background="Images/left/left_menu2.gif";
		menu.style.display="none";
	}else{
		obj.background="Images/left/left_menu.gif";
		//menu.style.display="none";
		var c=menu.value
		alert(c);
		menu.style.display="";
	}
}
function menuChange3(count,ii)
{
	//ѭ���жϣ�ssΪ���б���,iiΪ��ǰ��
 for (i=0;i<=count;i++){
   //������ˣ���i=1��10����һ�����ϳ����Զ�����
  try{
   //��i=iiʱչ��Ŀ¼��������ر�
   if (i==ii){
    //�ж�i�е�Ŀ¼���Ƿ�չ����û�о�չ��������ر�
    if (window.eval("menu"+i).style.display=="none"){
     window.eval("menu"+i).style.display="";
    }else{
     window.eval("menu"+i).style.display="none"; 
    }
   }else{
    window.eval("menu"+i).style.display="none"; 
   }
  }catch(e){}
 }
}
function menuChange2(obj,menu)
{
	if(menu.style.display=="")
	{
		menu.style.display="none";
	}else{
		menu.style.display="";
	}
}

function proLoadimg()
{
	var i=new Image;
	i.src='Images/left/left_menu.gif';
}
proLoadimg();
