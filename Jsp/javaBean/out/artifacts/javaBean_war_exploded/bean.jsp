<%@ page contentType="text/html;charset=utf-8" %>
<%@ page import="java.io.*" %>
<%@ page import="java.util.*" %>
<%@ page import="com.exper.*" %>
<html>
<body>
	<jsp:useBean id="c" class="com.exper.Car1" scope="request"/>
	<form action="" method="post">
	汽车牌号：<input type="text" name="carNum">(如："陕A12345")
	<br>汽车品牌：<input type="text" name="carBoard">(如："BYD牌")
	<br>商产日期：<input type="text" name="carDate">(如："2016.10")
	<br><input type="submit" value="提交">
	</form>
	<%
		String a = request.getParameter("carNum");
		String b = request.getParameter("carBoard");
		String c1 = request.getParameter("carDate");

		int n = 0;
		StringBuffer sb = new StringBuffer();

		if(a==null && b==null && c1==null){}
        else
		{
	%>
	<jsp:setProperty name="c" property="*"/>
	<%
		c.saveMessage();
	%>
	<br>最后一个提交的数据为：
	<br>
	车牌号:<jsp:getProperty name="c" property="carNum"/>
	,品牌:<jsp:getProperty name="c" property="carBoard"/>
	,生产日期:<jsp:getProperty name="c" property="carDate"/>

	<%
		}
		File file = new File("D:\\Intellij\\JSP\\javaBean\\web\\test.txt");
		if(!file.exists()){
				file.createNewFile();
			}

		FileInputStream fis = new FileInputStream(file);
		InputStreamReader read = new InputStreamReader(fis,"UTF-8");
		BufferedReader br = new BufferedReader(read);

		String temp;
		sb.append("<table border=1>");
		sb.append("<tr>");
		sb.append("<td>");
		sb.append("</td>");
		sb.append("<td>");
		sb.append("车牌号");
		sb.append("</td>");
		sb.append("<td>");
		sb.append("品牌");
		sb.append("</td>");
		sb.append("<td>");
		sb.append("生产日期");
		sb.append("</td>");
		sb.append("</tr>");

		while((temp=br.readLine()) != null)
		{
			String[] nu = temp.split(" ");
			n++;

        	sb.append("<tr>");
        	sb.append("<td>");
			sb.append(n);
			sb.append("</td>");
        	for(int i=0;i<nu.length;i++)
        	{
				sb.append("<td>");
				sb.append(nu[i]);
				sb.append("</td>");
        	}
        	sb.append("</tr>");
		}

		sb.append("</table>");
		br.close();
		read.close();
		fis.close();
	%>
	<p>目前已登记车辆共<%=n%>辆
	<%=sb%>
</body>
</html>