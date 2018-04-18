<%@ page contentType="text/html;charset=utf-8" %>
<%@ page import="java.io.*" %>
<%@ page import="java.util.*" %>
<%@ page import="com.exper.*" %>
<html>
<body>
	<jsp:useBean id="mb" class="com.exper.MessBoard" scope="request"/>
	<jsp:getProperty name="mb" property="result"/>
 	<a href="inputMess.jsp">我要留言</a>

</body>
</html>