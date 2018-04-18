<%--
  Created by IntelliJ IDEA.
  User: HASEE
  Date: 2017/10/13
  Time: 21:54
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" %>
<html>
  <body>
    <p>请输入要查询学生的学号：
    <form action="byNumber.jsp" method="post">
      <br>输入学号:<input type="text" name="num" >
      <input type="submit" value="Enter" name="submit">
    </form>

    <p>请输入要查询学生的姓名：
    <form action="byName.jsp" method="post">
      <br>姓名含有<input type="text" name="name" >
      <input type="submit" value="Enter" name="submit">
    </form>
  </body>
</html>
