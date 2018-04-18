<%@ tag import="java.io.*" %>
<%@tag pageEncoding="UTF-8" %>
<%@attribute name="name" required="true" %>
<%@attribute name="directory" required="true" %>
<%@attribute name="textarea" required="true" %>
<%@variable name-given="flag" scope="AT_END" %>


<%
  File dir = new File(directory);
  dir.mkdir();
  try {
    File f = new File(dir, name);
    if(f.length() > 0){
    	FileWriter outfile = new FileWriter(f);
    	BufferedWriter bufferOut = new BufferedWriter(outfile);
    	bufferOut.write(textarea);
    	bufferOut.close();
    	outfile.close();
    	out.print("write successful!");
    }
  }catch(IOException ex){
  	out.print("File open error!");
  }
%>
