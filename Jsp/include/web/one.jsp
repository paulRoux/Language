<%@ page contentType="text/html;charset=UTF-8" %>
<html>

<body>
<%@ include file="head.txt" %>
<P>请输入一个1～100之间的整数。
<FORM action="" method=post name=form>
    <INPUT type="text" name="OK">
    <br><INPUT TYPE="submit" value="确定" name=submit>
</FORM
<% String a = request.getParameter("OK");
    if (a == null) {
    } else {
        int n = Integer.parseInt(a);
        if (1 <= n && n <= 50) {
%>
<jsp:forward page="two.jsp">
    <jsp:param name="number" value="<%=n%>"/>
</jsp:forward>
<% } else if (50 < n && n <= 100) {
%>
<jsp:forward page="three.jsp">
    <jsp:param name="number" value="<%=n%>"/>
</jsp:forward>
<% } else {
%>
<jsp:forward page="error.jsp">
    <jsp:param name="number" value="<%=n%>"/>
</jsp:forward>
<% }
}
%>
</body>

</html>