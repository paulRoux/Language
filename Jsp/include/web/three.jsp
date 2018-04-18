<%@ page contentType="text/html;charset=utf-8"%>
<html>
<body>
<% String a = request.getParameter("number");
    if(a == null)
    {
        a = "0";
    }
    int n = Integer.parseInt(a);
%>
<P>您传过来的数值是：<BR>
        <%=n%>
    <image src="116762-106.jpg" width=<%=n%> height=<%=n%> ></image>
</body>
</html>