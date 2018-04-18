###SQL Server 2012 SEQUENCE 使用

####1.说明

1. 缘由
	1. 众所周知，在之前的sql server版本中，一般采用GUID或者 identity 来作为标示符，但是 identity 是一个表对象，只能保证在一张表里面的序列，当我们遇到以下情况时，

	表1：

	ID | 订单类型 | 价格
	---|----------|-----
	1  | 火车票   | 200
	4  | 飞机票   | 2000
	5  | 船票     | 600

	表2：

	ID | 订单类型 | 价格
	---|----------|-----
	2  | 酒店     | 400
	3  | 公园门票 | 170
	6  | 租车费用 | 300

	2. 如上表，我们需要在多表之间，实现 ID 的一致性，在sqlserver里面就会有一定的麻烦，通常我们会使用额外使用一张temp表来映射这些ID的关系然后再从中取序列来完成。

	3. sequence在oracle中其实很早就存在了，sqlserver 2012的sequence功能和那个相似，是一个基于schema的对象，所以可以被多表调用。

2. sequence语法如下：

```sql
CREATE SEQUENCE [schema_name . ] sequence_name
    [ AS [ built_in_integer_type | user-defined_integer_type ] ]
    [ START WITH <constant> ]
    [ INCREMENT BY <constant> ]
    [ { MINVALUE [ <constant> ] } | { NO MINVALUE } ]
    [ { MAXVALUE [ <constant> ] } | { NO MAXVALUE } ]
    [ CYCLE | { NO CYCLE } ]
    [ { CACHE [ <constant> ] } | { NO CACHE } ]
    [ ; ]
```
	start with 设置起始值

	increment by 设置增长间隔

	min和max分别设置最小和最大值

	cycle设置是否循环

	cache指定缓存的设置

- Oracle中有sequence的功能，SQL Server类似的功能使用Identity列实现，但是有很大的局限性。在2012中，微软终于增加了 sequence 对象，功能和性能都有了很大的提高。

####2.创建及使用

1. 使用SSMS中创建

	![创建](https://raw.githubusercontent.com/McXing/Pictures/master/IDENTITY/SEQUENCE.jpg "SEQUENCE")

2. 使用SQL创建序列对象：

```sql
IF EXISTS(SELECT * FROM sys.sequences
		WHERE name = N'TestSeq')
DROP SEQUENCE TestSeq;
GO

--创建序列对象

CREATE SEQUENCE TestSeq AS tinyint
    START WITH 1
    INCREMENT BY 1;
GO



--创建表
 CREATE TABLE TEST
(
	ID tinyint,
	Name varchar(150)
)

--产生序列号码并插入表中
INSERT INTO TEST
(ID,Name)
VALUES
(NEXT VALUE FOR TestSeq, 'allen')

INSERT INTO TEST
(ID,Name)
VALUES
(NEXT VALUE FOR TestSeq, 'kevin')

SELECT * FROM TEST
--产生序列可以重复使用，下面的例子当序列号码超过255后又重新从0开始。

CREATE SEQUENCE [dbo].[Test1Seq]
AS [tinyint]
	START WITH 0
	INCREMENT BY 5
	CYCLE
GO

--当获取到下一个序列值时，即该序列值被使用，而不管是否是INSERT/SELECT
SELECT NEXT VALUE FOR [Test1Seq]
GO

--重新将序列初始值变为5
ALTER SEQUENCE dbo.TestSeq
RESTART WITH 5;

SELECT * FROM sys.sequences
WHERE name = 'TestSeq'


--共享序列，两个表可以使用同一个序列对象（Identity列是不可以的）
CREATE SEQUENCE dbo.Seq AS INT
	START WITH 1
 	INCREMENT BY 1


CREATE TABLE dbo.Examp1
(
   	Seq INT NOT NULL,
   	Name VARCHAR(50) NOT NULL
);


CREATE TABLE dbo.Examp2
(
	Seq INT NOT NULL,
   	Name VARCHAR(50)NOTNULL
);



INSERT INTO dbo.Examp1(Seq,Name) VALUES (NEXT VALUE FOR dbo.Seq, 'Tom');

INSERT INTO dbo.Examp2(Seq,Name) VALUES (NEXT VALUE FOR dbo.Seq, 'Jerry');


SELECT * FROM Examp1
SELECT * FROM Examp2



--可以直接在查询中使用序列对象（Identity列是不可以的）

CREATE SEQUENCE SeqOrder AS tinyint
    START WITH1
    INCREMENT BY1
    MINVALUE 1
    NO MAXVALUE
    CYCLE;
GO



SELECT ID, Name,
NEXT VALUE FOR SeqOrder OVER(ORDER BY Name DESC) As [Order]
FROM test;
```

- 注意：

	1. 由于序列是数据库级别的，因此单表中的值是不连续的
	2. 序列可以缓存到内存中
	3. 当获取到下一个序列值时，即该序列值被使用，而不管是否是INSERT/SELECT

- 为了提升性能，还可以使用 CACHE 选项，这样就可以将序列号码缓存到内存，减少IO操作,值得一提的是序列对象可以指定最大值和最小值，增加值可以为负数。

####3.参考

- 链接：

	<http://www.sqlservercentral.com/articles/sequence/88422/>

	<http://blog.csdn.net/wstoneh01/article/details/50736260>

	<http://www.voidcn.com/blog/zeko075/article/p-1660668.html>
