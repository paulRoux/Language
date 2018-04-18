USE　JY
GO


/******创建视图******/
--创建视图的原型
/*
CREAT VIEW view_name[column_list]
[WITH ENCRYPTION]
AS select_statement
[WITH CHECK OPTION]

--注释
--1.view_name 视图的名称
--2.column_list 视图使用的列表名。组成视图的列名或者全部省略或者全部指定，
不能指定一部分列名。如果省略那就和SELECT中的一致。
    --2.1 必须指定视图的列表名的情况：
	    --2.1.1 某个目标列不是基本表的列，而是通过基本表计算得来的，包括聚合函数和算数表达式
	    --2.1.2 多表连接时选择了几个同名列作为视图的列
	    --2.1.3 需要在视图中为某个列指定别名
--3.WITH ENCRYPTION 对视图的定义进行加密
--4.AS子句 指定视图要进行的操作
--5.select_statement 定义视图的SELECT语句，AS后只能有一条SELECT语句。不能使用ORDER BY、
COMPUTE BY、INTO、临时表
--6.WITH CHECK OPTION 强制要求对视图的数据进行修改时，必须符合视图定义中的查询设置条件
*/

--创建视图
--1.查看借阅次数大于30的图书信息
CREATE VIEW v_book
AS
	SELECT *
	FROM book
	WHERE interview_times > 30
GO

--2.查看借阅了图书的读者姓名以及他们借阅的图书名称
CREATE VIEW c_record(reader_name, book_name)
AS
	SELECT reder.reader_name, book.book_name
	FROM reader, book, record
	WHERE reader.reader_id = record.reader_id AND book.book_id = record.book_id
GO

--或者采用下面的方法进行创建
/*
CREATE VIEW v_record
AS
	SELECT reader.reader_name, book.book_name
	FROM record JOIN reader
	ON reader.reader_id = record.reader_id
	JOIN book
	ON book.book_id = record.book_id
GO
*/


--查询访问次数大于30的图书名称和借阅次数,并在视图中为列指定别名
--基于视图v_book创建视图
CREATE VIEW v_newbook(图书名称, 借阅次数)
AS
	SELECT book_name, interview_times
	FROM v_book
GO

--也可以用下面的方式在SELECT中指定别名
/*
CREATE VIEW v_newbook
AS
	SELECT book_name AS '图书名称', interview_times AS '借阅次数'
	FROM v_book
GO
*/


--创建带WITH CHECK OPTION选项的视图
--保证对视图进行UPDATE、INSERT、DELETE时，满足对视图定义中的查询的条件表达式
CREATE VIEW v_book2
AS
	SELECT *
	FROM book
	WHERE interview_times > 30
WITH CHECK OPTION
GO


/******管理视图******/
--修改视图v_record,使其能查看读者姓名、借阅图示名称和借阅时间,并显示名为“读者姓名”、“借阅图书名称”和“借阅时间”
ALTER v_record
AS
	SELECT reader.reader_name AS '读者姓名', book.book_name '图书名称',
			record.borrow_date AS '借阅时间'
	FROM record JOIN reader
	ON record.reader_id = reader.reader_id
	JOIN book
	ON book.book_id = record.book_id
GO

--删除视图和重命名视图
DROP VIEW view_name
sp_rename view_name, new_view_name


/******使用视图******/
--注释
--1.不能同时更新两个或多个基本表
--2.不能更新视图中通过计算得到的列

--通过视图v_reader向基本表reader中插入数据
SELECT *
FROM reader
INSERT INTO v_reader
	VALUES('r0009','钟灵','女','信息工程系')
SELECT * FROM reader
GO

--查询视图
SELECT *
FROM v_book2
GO