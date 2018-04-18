package com.exper;
import java.io.*;
import java.sql.*;
import java.util.*;
import java.text.SimpleDateFormat;
public class MessBoard
{
	String name;
	String title;
	String mess;
    StringBuffer result;     //查询结果

    public MessBoard()
    {  result=new StringBuffer();
       try{
       		Class.forName("com.mysql.jdbc.Driver");
        }
       catch(Exception e) {}
    }

	public void setPeopleName(String pn)
	{
		try{
		byte[] b = pn.getBytes("ISO-8859-1");
		name = new String(b,"UTF-8");
		}
		catch(Exception e){
		}
	}

	public void setTitle(String t)
	{
		try{
		byte[] b = t.getBytes("ISO-8859-1");
		title = new String(b,"UTF-8");
		}
		catch(Exception e){
		}
	}

	public void setMessages(String m)
	{
		try{
		byte[] b = m.getBytes("ISO-8859-1");
		mess = new String(b,"UTF-8");
		}
		catch(Exception e){
		}
	}

	public String getPeopleName()
	{
		return name;
	}

	public String getTitle()
	{
		return title;
	}

	public String getMessages()
	{
		return mess;
	}

	public void insertcondition()
    {
    	SimpleDateFormat df = new SimpleDateFormat("yyyy-MM-dd");//设置日期格式
		java.util.Date date = new java.util.Date();
		String time = df.format(date);
    	String condition="INSERT INTO messages VALUES"+"("+"'"+name+"','"+title+"','"+mess+"','"+time+"')";
    	Connection con;
	    Statement sql;
	    try
	    {
			String url = "jdbc:mysql://127.0.0.1:3306/message?"
					+ "user=roux&password=xia7758521&useUnicode=true&characterEncoding=UTF8";
			con = DriverManager.getConnection(url);
	        sql=con.createStatement();
         	sql.executeUpdate(condition);
         	con.close();
        }
        catch(Exception e){
        	System.out.println(e);
      	}
    }

    public StringBuffer getResult()
    {
    	Connection con;
	    Statement sql;
	    ResultSet rs;
	    try
	    {
	        result.append("<table border=1>");
			String url = "jdbc:mysql://127.0.0.1:3306/message?"
					+ "user=roux&password=xia7758521&useUnicode=true&characterEncoding=UTF8";
			con = DriverManager.getConnection(url);
	        DatabaseMetaData metadata=con.getMetaData();
	        ResultSet rs1=metadata.getColumns(null,null,"messages",null);
	        int zd=0;
	        result.append("<tr>");
	        while(rs1.next())
	        {
	            zd++;
	        }
	        result.append("<td>"+"留言者姓名"+"</td>");
	        result.append("<td>"+"留言标题"+"</td>");
	        result.append("<td>"+"留言内容"+"</td>");
	        result.append("<td>"+"留言时间"+"</td>");
	        result.append("</tr>");

	        sql=con.createStatement();
	        rs=sql.executeQuery("SELECT * FROM messages");
	        while(rs.next())
	        {
	            result.append("<tr>");
	            for(int k=1;k<=zd;k++)
	            {
	                result.append("<td>"+rs.getString(k)+"</td>");
	            }
	             result.append("</tr>");
	           }
	          result.append("</table>");
	          con.close();
	    }
        catch(SQLException e)
        {
            result.append(e);
        }
       	return result;
    }

}