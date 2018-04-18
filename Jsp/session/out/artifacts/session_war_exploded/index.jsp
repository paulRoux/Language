<%--
  Created by IntelliJ IDEA.
  User: HASEE
  Date: 2017/10/2
  Time: 14:58
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" %>
<html>
<body>
  <span style="font-size: x-small">
  <p>随机分给你了一个 a 到 z 的字母，猜猜！

  <%
      int num = (int)(97 + (Math.random() * 100) % 26);
      char c = (char)num;
      session.setAttribute("count", 0);
      session.setAttribute("save", c);
  %>

  <br><A HREF="guess.jsp">去猜测这个字母</A>
  </span>
</body>
</html>
