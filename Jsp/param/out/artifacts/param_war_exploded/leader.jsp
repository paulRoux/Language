<%@ page contentType="text/html;charset=utf-8"%>
<html>
<body>
<% String a = request.getParameter("shangDi"),
        b = request.getParameter("xiaDi"),
        h = request.getParameter("high");
    try
    {
        double sd = Double.parseDouble(a);
        double xd = Double.parseDouble(b);
        double hi = Double.parseDouble(h);
        double mj = (sd + xd) * hi / 2;
%>
<P>该梯形的面积是：<%=mj%></P>
<%
    }
    catch(NumberFormatException e)
    {
        out.print("<br>"+"数据传输错误");
    }
%>
</body>
</html>