<%@tag pageEncoding="UTF-8" %>
<%@attribute name="number" required="true" %>
<%@variable name-given="message" scope="AT_END" %>

<%
	String mess = "";
	Character character = (Character)session.getAttribute("save");
	char realNumber = character.charValue();
	char guessNumber = '0';
	boolean boo = true;

	try{
		char[] b = number.toCharArray();
		guessNumber = b[0];
	}
	catch(Exception exp){
		boo = false;
	}

	if(boo){
		if(guessNumber == realNumber){
			int n = (Integer) session.getAttribute("count");
			n+=1;
			session.setAttribute("count", n);
			mess = "您猜对了，这是第" + n + "次猜测！";
		}else if(guessNumber > realNumber){
			int n = (Integer) session.getAttribute("count");
			n+=1;
			session.setAttribute("count", n);
			mess = "您猜大了，这是第" + n + "次猜测！";
		}else if(guessNumber < realNumber){
			int n = (Integer) session.getAttribute("count");
			n+=1;
			session.setAttribute("count", n);
			mess = "您猜小了，这是第" + n + "次猜测！";
		}else if(number.equals("你还没开始猜测")){
			mess = "你还没开始猜测";
		}

		jspContext.setAttribute("message", mess);
	}else{
		jspContext.setAttribute("message", "请输入您的猜测");
	}
%>