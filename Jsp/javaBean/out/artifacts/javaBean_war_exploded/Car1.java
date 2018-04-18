package com.exper;
import java.io.*;
public class Car1
{
	String carNum = null;
	String carBoard = null;
	String carDate = null;

	public void setCarNum(String cn)
	{
		try{
		byte[] b = cn.getBytes("ISO-8859-1");
		carNum = new String(b,"UTF-8");
		}
		catch(Exception e){
		}
	}

	public void setCarBoard(String cb)
	{
		try{
		byte[] b = cb.getBytes("ISO-8859-1");
		carBoard = new String(b,"UTF-8");
		}
		catch(Exception e){
		}
	}

	public void setCarDate(String cd)
	{
		carDate = cd;
	}

	public String getCarNum()
	{
		return carNum;
	}

	public String getCarBoard()
	{
		return carBoard;
	}

	public String getCarDate()
	{
		return carDate;
	}

	public void saveMessage()
	{
		StringBuffer mes = new StringBuffer();
		if(carNum.equals(null) && carNum.equals(null) && carNum.equals(null))
		{
			return;
		}
		try{
			File file = new File("D:\\Intellij\\JSP\\javaBean\\web\\test.txt");
			if(!file.exists()){
				file.createNewFile();
			}
			FileOutputStream fs = new FileOutputStream(file,true);
			OutputStreamWriter osw = new OutputStreamWriter(fs,"UTF-8");
			BufferedWriter bw = new BufferedWriter(osw);
			mes.append(carNum);
			mes.append(" ");
			mes.append(carBoard);
			mes.append(" ");
			mes.append(carDate);
			mes.append("\r\n");
			String str = new String(mes);
			bw.write(str);
			bw.close();
			osw.close();
			fs.close();
		}
		catch(Exception e){}
	}

}