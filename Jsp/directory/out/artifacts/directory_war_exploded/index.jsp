<%--
  Created by IntelliJ IDEA.
  User: HASEE
  Date: 2017/10/12
  Time: 22:24
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@page import="java.io.*" %>
<html>
  <body>
    <%
        File dir = new File("D:/Intellij/JSP/directory");
        File file[] = dir.listFiles();
    %>
    <br>目录有:
        <%
          for(int i = 0; i < file.length; i++){
    	    if(file[i].isDirectory()){
    	    	out.print("<br>" + file[i].toString());
            }
          }
        %>
    <br>文件名字有:
        <%
          for(int i = 0; i < file.length; i++){
          	if(file[i].isFile()){
          		out.print("<br>" + file[i].toString());
            }
          }
        %>
  </body>
</html>
