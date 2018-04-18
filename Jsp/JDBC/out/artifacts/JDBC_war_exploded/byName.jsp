<%--
  Created by IntelliJ IDEA.
  User: HASEE
  Date: 2017/10/13
  Time: 21:56
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@taglib prefix="Name" tagdir="/WEB-INF/tags" %>
<html>
  <body>
    <%
      String name = request.getParameter("name");
      byte[]b = name.getBytes("ISO-8859-1");
      name = new String(b, "utf-8");
    %>

    <Name:NameConditon name="<%=name%>"/>

    根据学号<%=name%>查询到的记录:
    <br><%=queryNameResult%>
  </body>
</html>
