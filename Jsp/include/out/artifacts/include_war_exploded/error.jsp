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
    <br>
    <image src="116762-106.jpg" width=<%=n%> height=<%=n%> ></image>
<P>输入整数的范围应该是1~100。<BR>
</body>
</html>