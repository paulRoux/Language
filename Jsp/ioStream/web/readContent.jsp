<%--
  Created by IntelliJ IDEA.
  User: HASEE
  Date: 2017/10/12
  Time: 23:36
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" %>
<%@taglib tagdir="/WEB-INF/tags" prefix="r"%>
<html>
<body bgcolor="#00ffff">
  <%
    String read = request.getParameter("read");
    String dir = request.getParameter("dir");
  %>

  <r:ReadTag read="<%=read%>" dir="<%=dir%>" />
</body>
</html>
