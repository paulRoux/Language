###IDENTITY属性的使用

####1.创建查看IDENTITY

- 创建

```sql
	IF OBJECT_ID('test','U') IS NOT NULL
	    DROP TABLE test
	GO

	CREATE TABLE test
	(
		id int IDENTITY(1, 1),  --如果直接写IDENTITY则默认为（1， 1）
		c1 char(1)
	)
	INSERT test VALUES('a');
	INSERT test VALUES('b');

	SELECT * FROM test
```

- 查看（通过函数或者系统视图）

```sql
	SELECT COLUMNPROPERTY(OBJECT_ID('test'),'id','IsIdentity') AS is_identity

	SELECT object_name(object_id) as table_name, is_identity, *
	FROM sys.columns
	WHERE object_id = object_id('test')
--and is_identity=1
```

- 重置IDENTITY列的初始值(通常在数据删除/归档后进行)

```sql
DELETE test
DBCC CHECKIDENT('test', RESEED, 1)
DBCC CHECKIDENT('test', NORESEED)

--TRUNCATE表后会自动重置IDENTITY列
TRUNCATE TABLE test
DBCC CHECKIDENT('test', NORESEED)
```

####2.获取IDENTITY列值

1. 说明

	>1. 插入了数据，有时还需要获取刚才生成的序列值另作他用，返回给前端也好，或者插入其他将来需要关联的表。

2. 示例

	曾经有个面试题：假设当前表 IDENTITY 列最大值为 N，在存储过程中，对这个表插入 1 行数据，获取到的 IDENTITY 列值有时小于或者大于 N + 1，可能是什么原因？

	获取 IDENTITY 列值有三种方式：
	>1. `IDENT_CURRENT( 'table_name' )`返回为**任何会话**和**任何作用域**中的**特定表**最后生成的标识值。
	>2. `@@IDENTITY`返回为**当前会话**的**所有作用域**中的**任何表**最后生成的标识值。
	>3. `SCOPE_IDENTITY()`返回为**当前会话**和**当前作用域**中的**任何表**最后生成的标识值。

	`IDENT_CURRENT( 'table_name' )`针对特定表，是**全局**的。
	`@@IDENTITY`和`SCOPE_IDENTITY()`针对所有表，区别在于作用域，也就是上下文：
	>1. 如果当前 INSERT 语句上有函数，触发器等(不同作用域的)对象返回的 IDENTITY 值，那么`@@IDENTITY`会取所有表上的最后1个，而不是当前表上的；
	>2. `SCOPE\_IDENTITY()`会取当前作用域所有表上最后1 个 IDENTITY 值，被调用的函数，触发器已经超出了作用域或上下文。所以在使用 INSERT 后，接着使用`SCOPE_IDENTITY()`获取 IDENTITY 列值，就不会有问题了：

			INSERT test VALUES('z');
			SELECT SCOPE_IDENTITY() AS curr_value

	一个 GO 语句/批处理，也是一个上下文的分界点，但是 SQL 语句是顺序执行的，所以一个会话里，只要在 INSERT 之后用`SCOPE_IDENTITY()`来获取 IDENTITY 值是没问题的。

####3.修改IDENTITY列值/属性

1. 对已存在的列增加/删除IDENTITY属性

```sql
IF OBJECT_ID('t_id') IS NOT NULL
DROP TABLE t_id
GO

CREATE TABLE t_id(id int,c1 char(1))

INSERT INTO t_id
SELECT 1,'a' UNION ALL
SELECT 2,'b'

ALTER TABLE t_id alter column id int identity(1,2)
/*
Msg 156, Level 15, State 1, Line 2
Incorrect syntax near the keyword 'identity'.
*/
```

	注意：直接修改列属性会报错，IDENTITY属性只能伴随着列增加/删除。

- 利用中间表

	1. 在SSMS界面上设计表(SSMS/Tables/Design)，可以直接增加/删除列上的 IDENTITY 属性，如果生成脚本看看的话(右击编辑框/工具栏/菜单栏)，可以发现SSMS是利用了中间表，并非在原表直接修改属性。

	2. 表上有约束，索引等对象时，脚本会更加繁杂些。示例如下图：
	![中间表](https://raw.githubusercontent.com/McXing/Pictures/master/IDENTITY/IDENTITY.jpg "IDENTITY")

	3. 如果出现如下错误：
	Saving changes is not permitted. The changes that you have made require the following tables to be dropped and re-created. You have either made changes to a table that can't be re-created or enabled the option Prevent saving changes that require the table to be re-created.
	![错误](https://raw.githubusercontent.com/McXing/Pictures/master/IDENTITY/%E5%87%BA%E7%8E%B0%E9%94%99%E8%AF%AF.jpg "IDENTITY")

	4. 是因为SSMS里有个选项没设置，SQL Server认为有删除/重建表的脚本不安全，所以默认关闭了，需要手动开启一下，去掉那个勾：
	![错误解决](https://raw.githubusercontent.com/McXing/Pictures/master/IDENTITY/%E9%94%99%E8%AF%AF%E8%A7%A3%E5%86%B3.jpg "IDENTITY")

	5. 对表上已存在列**添加** IDENTITY 属性，生成的脚本如下代码1：
	6. 对表上已存在列**删除** IDENTITY 属性，生成的脚本如下代码2：

代码1：

```sql
	BEGIN TRANSACTION
	SET QUOTED_IDENTIFIER ON
	SET ARITHABORT ON
	SET NUMERIC_ROUNDABORT OFF
	SET CONCAT_NULL_YIELDS_NULL ON
	SET ANSI_NULLS ON
	SET ANSI_PADDING ON
	SET ANSI_WARNINGS ON
	COMMIT
	BEGIN TRANSACTION
	GO
	CREATE TABLE dbo.Tmp_t_id
	    (
	    id int NOT NULL IDENTITY (1, 1),
	    c1 char(1) NULL
	    )  ON [PRIMARY]
	GO
	ALTER TABLE dbo.Tmp_t_id SET (LOCK_ESCALATION = TABLE)
	GO
	SET IDENTITY_INSERT dbo.Tmp_t_id ON
	GO
	IF EXISTS(SELECT * FROM dbo.t_id)
	     EXEC('INSERT INTO dbo.Tmp_t_id (id, c1)
	        SELECT id, c1 FROM dbo.t_id WITH (HOLDLOCK TABLOCKX)')
	GO
	SET IDENTITY_INSERT dbo.Tmp_t_id OFF
	GO
	DROP TABLE dbo.t_id
	GO
	EXECUTE sp_rename N'dbo.Tmp_t_id', N't_id', 'OBJECT'
	GO
	COMMIT
```

代码2：

```sql
	BEGIN TRANSACTION
	SET QUOTED_IDENTIFIER ON
	SET ARITHABORT ON
	SET NUMERIC_ROUNDABORT OFF
	SET CONCAT_NULL_YIELDS_NULL ON
	SET ANSI_NULLS ON
	SET ANSI_PADDING ON
	SET ANSI_WARNINGS ON
	COMMIT
	BEGIN TRANSACTION
	GO
	CREATE TABLE dbo.Tmp_t_id
	    (
	    id int NOT NULL,
	    c1 char(1) NULL
	    )  ON [PRIMARY]
	GO
	ALTER TABLE dbo.Tmp_t_id SET (LOCK_ESCALATION = TABLE)
	GO
	IF EXISTS(SELECT * FROM dbo.t_id)
	     EXEC('INSERT INTO dbo.Tmp_t_id (id, c1)
	        SELECT id, c1 FROM dbo.t_id WITH (HOLDLOCK TABLOCKX)')
	GO
	DROP TABLE dbo.t_id
	GO
	EXECUTE sp_rename N'dbo.Tmp_t_id', N't_id', 'OBJECT'
	GO
	COMMIT
```

- 利用中间列

	1. 对表上已存在列删除IDENTITY属性,如代码3：
	2. 对表上已存在列添加IDENTITY属性，用中间列的方式不太可行，因为IDENTITY列不接受UPDATE，新增的IDENTITY列无法直接复制原id的值，还得借助中间表，但如果不需要原来id的值，那么可以如代码4：

代码3：

```sql
	IF OBJECT_ID('t_id') IS NOT NULL
	    DROP TABLE t_id
	GO
	CREATE TABLE t_id(id int identity(1,1),c1 char(1))

	INSERT INTO t_id
	SELECT 'a' UNION ALL
	SELECT 'b'
	SELECT * FROM t_id
	SELECT COLUMNPROPERTY(OBJECT_ID('t_id'),'id','IsIdentity')

	--在表上新增一个列，把IDENTITY列值复制过去
	ALTER TABLE t_id add id_new int
	GO
	UPDATE t_id SET id_new = id

	--删除原来的列，并重命名新增列
	ALTER TABLE t_id drop column id
	exec sp_rename 't_id.id_new','id'
	SELECT * FROM t_id
	SELECT COLUMNPROPERTY(OBJECT_ID('t_id'),'id','IsIdentity')
```

代码4：

```sql
	IF OBJECT_ID('t_id') IS NOT NULL
	    DROP TABLE t_id
	GO
	CREATE TABLE t_id(id int,c1 char(1))

	INSERT INTO t_id
	SELECT 1,'a' UNION ALL
	SELECT 3,'b'
	SELECT * FROM t_id
	SELECT COLUMNPROPERTY(OBJECT_ID('t_id'),'id','IsIdentity')

	--在表上新增一个IDENTITY列，不复制原来的ID值
	ALTER TABLE t_id add id_new int identity(1,1) NOT NULL

	--删除原来的列，并重命名新增列
	ALTER TABLE t_id drop column id
	exec sp_rename 't_id.id_new','id'
	SELECT * FROM t_id
	SELECT COLUMNPROPERTY(OBJECT_ID('t_id'),'id','IsIdentity')
```

---

1. 在IDENTITY列上做增删改操作(DML)

	1. 删除操作没有问题，直接 DELETE 即可:
	`DELETE test WHERE id = 2`

	2. 如果要显式 INSERT 某个值，需要开启`IDENTITY_INSERT`这个`SESSION`级的选项

			SET IDENTITY_INSERT test on;
			INSERT test(id,c1) VALUES(3,'c');
			SET IDENTITY_INSERT test off;
			SELECT * FROM test

	3. 如果要 UPDATE IDENTITY 列值，无论是否开启`IDENTITY_INSERT`这个选项都无法更新

			SET IDENTITY_INSERT test on;
			UPDATE test SET id = 10 WHERE id = 1
			SET IDENTITY_INSERT test off;
			/*
			Msg 8102, Level 16, State 1, Line 1
			Cannot update identity column 'id'.
			*/
		注: 非要修改的话，就得借助中间表，在不含IDENTITY属性的中间表里做完UPDATE，然后再把数据导回来。中间表可参考上面的脚本。

---

1. IDENTITY列属性复制

	1. 直接从单表 SELECT INTO table_name，原表其他约束，索引等等都不会被复制，但是 IDENTITY 属性会被复制。

			SELECT * INTO test2 FROM test
			SELECT * FROM test2
			SELECT columnproperty(OBJECT_ID('test'),'id','IsIdentity')
			SELECT columnproperty(OBJECT_ID('test2'),'id','IsIdentity')

	2. 如果有 IDENTITY 属性的表和其他表 JOIN，那么 IDENTITY 属性不会被复制。

			SELECT a.* INTO test3
			FROM test a INNER JOIN sys.objects b
			ON a.id = b.object_id

			SELECT * FROM test3
			SELECT columnproperty(OBJECT_ID('test3'),'id','IsIdentity')
		1. 假如复制表时，不想要 IDENTITY 属性，正好可以利用一下这个特点，如下：

				SELECT a.* INTO test4
				FROM test a INNER JOIN sys.objects b
				ON 1=2

	3. 如果用 SELECT INTO table_name 导数据时，FROM子句有多表关联，且想要保留 IDENTITY 属性，这时可以用 INSERT，并考虑使用 TABLOCK 提示

			IF OBJECT_ID('test5','U') is not null
			DROP TABLE test5
			GO

			CREATE TABLE test5
			(
				id int IDENTITY(1, 1),  --如果直接写IDENTITY则默认为（1， 1）
				c1 char(1)
			)
			SELECT * FROM test5
			GO

			SET IDENTITY_INSERT test5 ON;
			INSERT INTO test5 WITH(TABLOCK) (id,c1)
			SELECT a.* FROM test a INNER JOIN test2 b ON a.id = b.id
			SET IDENTITY_INSERT test5 off;

			SELECT * FROM test5
			SELECT columnproperty(OBJECT_ID('test5'),'id','IsIdentity')

		这里使用了`WITH(TABLOCK)`选项，在 SIMPLE 或者`BULK_LOGGED`恢复模式下，`SELECT…INTO table_name` 和 `INSERT INTO table_name WITH(TABLOCK)` 都能最小化日志。

---

1. 借助SWITCH来处理IDENTITY属性(**推荐**)

	1. 同样也是利用中间表，上面的几个列子都使用了INSERT，这里使用SWITCH，不再有数据倒来倒去的开销，需要SQL Server 2008及以上版本，能比较有效地同时解决上面的3个问题：

		1. 不能直接对表上现有列增加/删除 IDENTITY 属性；
		2. 不能直接更新 IDENTITY 列；
		3. 复制表时，有选择的复制 IDENTITY 列属性(多表关联，对关联后的表做 SWITCH 以实现)；

```sql
	--原表
	CREATE TABLE Temp1
	(
		ID INT IDENTITY(1,1) PRIMARY KEY,
		X VARCHAR(10)
	)

	--插入测试数据
	INSERT INTO Temp1
	OUTPUT INSERTED.*
	SELECT 'Foo' UNION ALL
	SELECT 'Bar' UNION ALL
	SELECT 'Baz'

	--创建中间表，用作交换分区
	CREATE TABLE Temp2
	(
		ID INT PRIMARY KEY,
		X VARCHAR(10)
	)

	--交换分区
	ALTER TABLE Temp1 SWITCH TO Temp2;
	SELECT COLUMNPROPERTY(OBJECT_ID('Temp1'),'id','IsIdentity')
	SELECT COLUMNPROPERTY(OBJECT_ID('Temp2'),'id','IsIdentity')

	--插入测试数据
	INSERT INTO Temp2
	OUTPUT INSERTED.*
	SELECT 10,'Foo' UNION ALL
	SELECT 20,'Bar' UNION ALL
	SELECT 5, 'Baz'

	--更改IDENTITY初始值
	UPDATE Temp2 SET ID = ID + 1;

	--交换分区
	ALTER TABLE Temp2 SWITCH TO Temp1;
	SELECT * FROM Temp2
	SELECT * FROM Temp1
```

- 另外，从SQL Server 2012开始，如果开发时使用了SEQUENCE，这些IDENTITY列的限制就都不会存在了。

####4.参考

- 链接：<http://www.cnblogs.com/seusoftware/p/3804333.html>
