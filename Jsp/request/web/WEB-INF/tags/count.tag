<%@tag pageEncoding="UTF-8" %>
<%@attribute name="a" required="true" %>
<%@attribute name="b" required="true" %>
<%@attribute name="c" required="true" %>
<%@variable name-given="res" variable-class="java.lang.Double" scope="AT_END"%>

<%
    double A = Double.parseDouble(a);
    double B = Double.parseDouble(c);
    /*char[] C = b.toCharArray();

    double r = 0.0;
    switch(C[0])
    {
        case '+': r = A + B;
            break;
        case '-': r = A - B;
            break;
        case '*': r = A * B;
            break;
        case '/': r = A / B;
            break;
    }*/

    double r = 0.0;
    switch (b) {
        case "+":
            r = A + B;
            break;
        case "-":
            r = A - B;
            break;
        case "*":
            r = A * B;
            break;
        case "/":
            r = A / B;
            break;
    }

    jspContext.setAttribute("res", r);
%>