USE JY
GO

--在reader表的reader_name列创建索引i_name
CREATE NONCLUSTERED INDEX i_name
ON reader(reader_name)
GO

--注意事项：
--1、必须是使用SCHEMABINDING定义的视图才能创建索引，而且必须在视图上创建了唯一索引后，
--才能在视图上创建非聚集索引

--2、必须是数据表的所有者才能创建索引

--3、如果在定义是不指明CLUSTERED选项，则会默认为非聚集索引

--4、如果表中存在数据，那么在创建索引的时候会检查是否存在重复的列，有则创建失败

--5、具有相同组合列但组合顺序不同的符合索引也是不同的

--6、在创建了唯一索引的表中进行更新插入数据时，将自动检验是否存在重复的值，有则会在重复的第一列停止并返回错误


--删除索引
USE JY
GO

EXEC sp_helpindex 'reader'
DROP INDEX i_name ON reader
EXEC sp_helpindex 'reader'
GO

--重命名索引
--格式sp_rename 'object_name', 'new_name', 'object_type'
EXEC sp_rename 'reader.i_name', 'ix_name', 'index'

--维护索引
--显示查询计划
--显示reader表中的姓蔡的读者，并分析那些索引被系统采用
USE JY
GO
SET SHOWPLAN_ALL ON
GO
SELECT *
FROM reader
WHERE reader_name LIKE '蔡%'
GO
SET SHOWPLAN_ALL OFF
GO

--更新统计信息
UPDATE STATISTICS(reader, i_name)
GO

--扫描表,确定碎片信息
--扫描密度是100%则正常，否则需要清理
DBCC SHOWCONTIG(reader, i_name)
GO

--碎片整理
DBCC INDEXDEFRAG(JY, reader, i_name)
GO