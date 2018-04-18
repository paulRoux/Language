<%--
  Created by IntelliJ IDEA.
  User: HASEE
  Date: 2017/9/29
  Time: 19:34
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@taglib tagdir="/WEB-INF/tags" prefix="calculate"%>
<html>
  <body bgcolor="yellow">
  <form action="" method="post" name="form">
    <p>输入运算数、选择运算符号：<br>
    <input type="text" name="cal" value="0" size="4">

    <select name="ch">
      <option value="+">+
      <option value="-">-
      <option value="*">*
      <option value="/">/
    </select>

    <input type="text" name="cal1" value="0" size="4">
    <br><input type="submit" value="提交你的选择">
  </form>

    <%
        String a = request.getParameter("cal");
        String b = request.getParameter("ch");
        String c = request.getParameter("cal1");
        if(a == null || b == null || c == null){

        }else{
    %>

    <calculate:count a="<%=a%>" b="<%=b%>" c="<%=c%>"/>

    <%
        double r = res;
        out.println("<br>计算结果是：" + a + b + c + "=" + r);
        }
    %>
  </body>
</html>
