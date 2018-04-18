<%--
  Created by IntelliJ IDEA.
  User: HASEE
  Date: 2017/9/29
  Time: 8:27
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ page import="java.text.*" %>
<%@ taglib tagdir="/WEB-INF/tags" prefix="calculate" %>
<html>
  <body>
  <calculate:trangle sideA = "5" sideB = "4" sideC = "3" />
  <h4>三角形的面积保留三位小数的结果是：</h4>
  <%
      NumberFormat f = NumberFormat.getInstance();
      f.setMaximumFractionDigits(3);
      double r = result.doubleValue();
      out.println(r);
  %>
  </body>
</html>
