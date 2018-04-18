<%@ tag import="java.io.*" %>
<%@tag pageEncoding="UTF-8" %>
<%@attribute name="read" required="true"%>
<%@attribute name="dir" required="true"%>

<%
  File d = new File(dir);
  d.mkdir();
  StringBuffer strBuffer = new StringBuffer();
  try{
    File f = new File(d, read);
    FileReader in = new FileReader(f);
    BufferedReader bufferIn = new BufferedReader(in);
    String temp;
    while((temp = bufferIn.readLine()) != null){
    	strBuffer.append(temp);
    }
    bufferIn.close();
    in.close();
  }catch(IOException ex){
  	out.print("read error!");
  }
  out.print(strBuffer);
%>
