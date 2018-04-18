<%@ page contentType="text/html;charset=utf-8"%>
<html>

<body>
<P>请输入梯形的上底，下底和高
<FORM action="" method=post name=form>
  <INPUT type="text" name="sd1">
  <br>
  <INPUT type="text" name="xd1">
  <br>
  <INPUT type="text" name="high">
  <br>
  <INPUT TYPE="submit" value="确定" name=submit>
</FORM>
<% String a = request.getParameter("sd1");
  String b = request.getParameter("xd1");
  String c = request.getParameter("high");

  if(a == null)
  {
    a = "0";
  }
  if(b == null)
  {
    b = "0";
  }
  if(c == null)
  {
    c = "0";
  }

  double sd = Double.parseDouble(a);
  double xd = Double.parseDouble(b);
  double h = Double.parseDouble(c);

  if(sd>0 && xd>0 && h>0)
  {
%>
<jsp:include page="leader.jsp">
  <jsp:param name="shangDi" value="<%=sd%>" />
  <jsp:param name="xiaDi" value="<%=xd%>" />
  <jsp:param name="high" value="<%=h%>" />
</jsp:include>
<%
  }
%>
</body>

</html>