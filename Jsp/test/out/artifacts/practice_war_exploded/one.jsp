<%--
  Created by IntelliJ IDEA.
  User: HASEE
  Date: 2017/9/19
  Time: 22:40
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<body bacolor = cyan><font size="5">
    <%
        String str = request.getParameter("number");
        double n = Double.parseDouble(str);
    %>
    <P>result:<BR>
    <%=n%>
</font>

</body>
</html>
