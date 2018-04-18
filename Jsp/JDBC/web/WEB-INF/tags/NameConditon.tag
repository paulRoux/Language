<%@tag pageEncoding="UTF-8" %>
<%@attribute name="name" required="true" %>
<%@ tag import="java.sql.*" %>
<%@variable name-given="queryNameResult" scope="AT_END" %>

<%
  StringBuffer result;
  result = new StringBuffer();

  try{
    Class.forName("com.mysql.jdbc.Driver");
  }catch(Exception e){
    out.print("error");
  }

  Connection con;
  Statement mysql;
  ResultSet rs;

  try{
    result.append("<table border=1");
    String url = "jdbc:mysql://127.0.0.1:3306/student?"
            + "user=roux&password=xia7758521&useUnicode=true&characterEncoding=UTF8";
    con = DriverManager.getConnection(url);
    DatabaseMetaData metadata = con.getMetaData();
    ResultSet rs1 = metadata.getColumns(null, null, "students", null);
    int count = 0;
    result.append("<tr>");

    while(rs1.next()){
      count++;
      String clubName = rs1.getString(4);
      result.append("<td>"+clubName+"</td>");
    }
    result.append("</tr>");

    mysql = con.createStatement();
    String condition="SELECT * FROM students Where name LIKE '%" + name + "%'";
    rs = mysql.executeQuery(condition);

    while(rs.next()){
      result.append("<tr>");
      for(int k = 1; k <= count; k++){
        result.append("<td>"+rs.getString(k)+"</td>");
      }
      result.append("</tr>");
    }
    result.append("</table>");
    con.close();
  }catch(SQLException e){
    result.append(e);
  }

  jspContext.setAttribute("queryNameResult", new String(result));

%>