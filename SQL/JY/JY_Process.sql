USE JY
GO

--IF...ELSE语句
--显示两个数中较大的一个
DECLARE @a int, @m int
SELECT @n = 1, @m = 9
IF(@n > @m)
	PRINT @n
ELSE
	PRINT @m
GO

--CASE语句
--注释的语句为简单的CASE语句
--搜索CASE语句，查看变量值为10时对应的字符
DECLARE @n int, @ch varchar(10)
SET @n = 10
SET @ch = CASE  --SET @ch = CASE @n
	WHEN @n = 2 THEN 'a'  --WHEN 2 THEN 'a'
	WHEN @n = 5 THEN 'b'  --WHEN 5 THEN 'b'
	WHEN @n = 6 THEN 'g'  --WHEN 6 THEN 'g'
	WHEN @n = 8 THEN 's'  --WHEN 8 THEN 's'
	ELSE 'o' --ELSE 'o'
END

PRINT @ch
GO

--WHILE语句
--计算1+2+3+...+100的和
DECLARE @n int, @sum int  --定义局部变量
SELECT @n = 1, @sum = 0  --对变量赋值
WHILE @n <= 100  --当@n <= 100执行循环体
	BEGIN
		SELECT @sum = @sum + @n  --求和
		SELECT @n = @n + 1  --计数单元
	END
SELECT '1+2+3+...+100的和' = @sum
GO

--WAITFOR语句
--暂时停止程序的执行，直到所设定的时间结束
DECLARE @name varchar(10)  --定义变量
SET @name = 'SQL Server'  --变量赋值
BEGIN
	WAITFOR DELAY '00:00:10'  --设置程序停止的时长
	PRINT @name  --打印变量
END
GO