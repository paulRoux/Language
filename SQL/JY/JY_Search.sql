USE JY
GO
/*
--声明变量保存书名和作者
DECLARE @bookname nvarchar(50), @bookauthor char(10), @bookpublisher nvarchar(50)
--对变量赋值
SET @bookname = '蛤蟆功'
--查询
/*
IF EXISTS(SELECT * FROM book WHERE book_name = @bookname)
BEGIN
	SELECT @bookpublisher FROM book WHERE book_name = @bookname
	PRINT @bookpublisher
END
ELSE
	PRINT '没有相关图书！'
GO
*/

/*
SELECT @bookauthor = book_author FROM book WHERE book_name = @bookname

--输出
PRINT @bookauthor
GO
*/


SELECT min(interview_times) FROM book
GO
WHILE(SELECT min(interview_times) FROM book) < 35
BEGIN
	UPDATE book SET interview_times = interview_times + 5

	IF(SELECT min(interview_times) FROM book) > 35
		BREAK
	ELSE
		CONTINUE
END

SELECT min(interview_times) FROM book
GO