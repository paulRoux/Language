<%--
  Created by IntelliJ IDEA.
  User: HASEE
  Date: 2017/10/12
  Time: 23:31
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" %>
<%@taglib tagdir="/WEB-INF/tags" prefix="write"%>
<html>
  <body>
    <%
      String name = request.getParameter("name");
      String directory = request.getParameter("directory");
      String textarea = request.getParameter("textarea");
    %>

    <write:WriteTag name = "<%=name%>" directory = "<%=directory%>" textarea = "<%=textarea%>"/>

    <jsp:forward page="lookContent.jsp"></jsp:forward>
  </body>
</html>
