<%@ page contentType="text/html;charset=GB2312"%>
<html>

<body>
<table border="1" align="center" width="1000px">
  <tr align="center">
    <th colspan="26">大，小写英文字母表</th>
  </tr>
  <tr style="color:#03F" align="center">
    <%  char a = 'a';
      for(int i = 1; i <= 26; i++)
      {
    %>
    <td>
      <%=a%>
    </td>
    <%  a++;
    }
    %>
  </tr>
  <tr style="color:#F00" align="center">
    <%  char b = 'A';
      for(int j = 1; j <= 26; j++)
      {
    %>
    <td>
      <%=b%>
    </td>
    <%  b++;
    }
    %>
  </tr>
</table>
</body>

</html>