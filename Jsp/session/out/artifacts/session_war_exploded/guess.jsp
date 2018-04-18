<%@ page contentType="text/html; charset=UTF-8" %>
<%@ taglib tagdir="/WEB-INF/tags" prefix="guessNumber" %>
<HTML>
<BODY bgcolor="#00ffff">
<span style="font-size: x-small">
            <%
				String str = request.getParameter("guessChar");
				if(str == null){
					str = "*";
				}
				if(str.length() == 0){
					str = "*";
				}
			%>

            <guessNumber:guessTag number = "<%=str%>"/>
            <p>当前的猜测结果：<%=message%>

            <%
                if(message.startsWith("您猜对了")){
            %>
			<br><A HREF="index.jsp">重新获得随机字母</A>
			<%
				}else{
            %>
				<br>请输入你的猜测:
				<form action="" method="post" name="form">
					<input type="text" name="guessChar" >
					<input type="submit" name="submit" value="送出" >
				</form>
			<%
				}
			%>
        </span>
</BODY>
</HTML>