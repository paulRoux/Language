<%--
  Created by IntelliJ IDEA.
  User: HASEE
  Date: 2017/10/13
  Time: 21:56
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" %>
<%@taglib prefix="Number" tagdir="/WEB-INF/tags" %>
<html>
  <body>
    <%
      String number = request.getParameter("num");
    %>

    <Number:NumberCondtion number="<%=number%>"/>

    根据学号<%=number%>查询到的记录:
    <br><%=queryResult%>
  </body>
</html>
