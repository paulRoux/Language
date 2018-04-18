<%@ tag import="java.util.*" %>
<%@ tag pageEncoding="UTF-8"%>
<%@ attribute name="sideA" required="true" %>
<%@ attribute name="sideB" required="true" %>
<%@ attribute name="sideC" required="true" %>
<%@ variable name-given="result" variable-class="java.lang.Double" scope="AT_END" %>
<%@ variable name-given="message" scope="AT_END" %>
<%
    out.println("<br> jsp页面传过来的三边: " +sideA+ ", " +sideB+ ", " +sideC );
    double a = Double.parseDouble(sideA);
    double b = Double.parseDouble(sideB);
    double c = Double.parseDouble(sideC);

    if((a+b) > c && (a+c) > b && (c+b) > a) {
        double p = (a + b + c) / 2.0;
        double res = Math.sqrt(p * (p - a) * (p - b) * (p - c));
        jspContext.setAttribute("result", new Double(res));
    }else{
        jspContext.setAttribute("message", "所传过来的三边无法构成一个三角形!");
    }
%>