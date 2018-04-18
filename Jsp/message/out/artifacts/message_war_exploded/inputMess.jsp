<%@ page contentType="text/html;charset=utf-8" %>
<%@ page import="java.io.*" %>
<%@ page import="java.util.*" %>
<%@ page import="com.exper.*" %>
<html>
<body>
	<jsp:useBean id="mb" class="com.exper.MessBoard" scope="request"/>
	<FORM action="" method="post" name="form">
		输入您的名字：
	    <br><INPUT  type="text" name="peopleName">
	    <br>输入您的留言标题：
	    <br><INPUT  type="text"  name="title">
	    <br>输入您的留言：
	    <br><TEXTAREA name="messages" ROWs="10" COLS=36 WRAP="physical" ></TEXTAREA>
	    <br><INPUT type="submit" value="提交信息" name="submit">
 	</FORM>
 	<%
		String a = request.getParameter("peopleName");
		String b = request.getParameter("title");
		String c = request.getParameter("messages");

		if(a==null && b==null && c==null){}
        else
		{
	%>
	<jsp:setProperty name="mb" property="*"/>
	<%
			mb.insertcondition();
		}
	%>
 	<a href="show.jsp">查看留言板</a>

</body>
</html>