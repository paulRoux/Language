<%--
  Created by IntelliJ IDEA.
  User: HASEE
  Date: 2017/10/12
  Time: 22:11
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" %>
<%@page import="java.io.*" %>
<html>
<body bgcolor="#00ffff">
<%
  File dir = new File("D:/Intellij/JSP/ioStream");
  File file[] = dir.listFiles();
%>
<form action="writeContent.jsp" method="post" name="form">
  <input type="text" name="name">

  <br><br>
  <select name="directory">
    <%
      for(int i = 0; i < file.length; i++) {
        if(file[i].isDirectory()) {
      %>
          <option value="<%=file[i].toString()%>"><%=file[i].toString()%>
        <%
		}
	  }
		%>
  </select>

  <br><br><textarea name="textarea" cols="30" rows="10"></textarea>

  <br><input type="submit" value="Enter">
</form>
</body>
</html>
