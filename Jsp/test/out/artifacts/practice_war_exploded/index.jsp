<%--
  Created by IntelliJ IDEA.
  User: HASEE
  Date: 2017/9/19
  Time: 21:42
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
  <body>
  <%
  double i = Math.random();
  %>
  <jsp:forward page="one.jsp">
    <jsp:param name = "number" value = "<%=i%>"/>
    </jsp:forward>
  </body>
</html>
