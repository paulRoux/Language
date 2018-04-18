USE JY
GO

CREATE TABLE reader
(
	reader_id varchar(8) NOT NULL PRIMARY KEY, --第一种主键约束方式
	reader_name nvarchar(50) NOT NULL,  --姓名
	reader_sex char(2) NOT NULL,  --性别
	reader_department nvarchar(60) NOT NULL,  --院系
	--PRIMARY KEY (reader_id)  --第二种主键约束方式
	/*
	CONSTRAINT ck_idd CHECK
	(reader_id like '[0~9][0~9][0~9][0~9][0~9][0~9][0~9][0~9]')
	*/
)
GO

CREATE TABLE record
(
	reader_id varchar(8) NOT NULL,  --读者编号
	book_id varchar(8) NOT NULL,  --图书编号
	borrow_date date NOt NULL DEFAULT getdate(),  --结束时间
	return_date date NOT NULL,  --还书时间
	notes nvarchar(50) NOT NULL,  --备注
	PRIMARY KEY (reader_id, book_id),
	--定义键外约束，前提是要定义主键约束
	CONSTRAINT fk_reader FOREIGN KEY (reader_id) REFERENCES reader(reader_id),
	CONSTRAINT fk_book FOREIGN KEY (book_id) REFERENCES book(book_id),
)
GO

CREATE TABLE book
(
	book_id varchar(8) NOT NULL,  --书号
	book_name nvarchar(50) NOT NULL,  --书名
	book_isbn char(17) NOT NULL,  --isbn号
	book_author nvarchar(10) NOT NULL,  --作者
	book_publisher nvarchar(50) NOT NULL,  --出版社
	interview_times smallint NOT NULL,  --借阅次数
	book_price money NOT NULL,  --价格
	CONSTRAINT un_isbn UNIQUE (book_isbn)
)
GO

/*
ALTER TABLE book
(
	ADD CONSTRAINT pk_book PRIMARY KEY (book_id),
		CONSTRAINT un_isbn UNIQUE (book_isbn)

	ADD CONSTRAINT ck_idd CHECK
	(book_id like '[0~9][0~9][0~9][0~9][0~9][0~9][0~9][0~9]')

	DROP CONSTRAINT un_isbn
)
GO
*/


ALTER TABLE record
(
	/*
	ADD CONSTRAINT pk_rbook PRIMARY KEY (reader_id),
	    CONSTRAINT pk_bbook PRIMARY KEY (book_id)

	ADD CONSTRAINT fk_reader FOREIGN KEY (reader_id) REFERENCES reader(reader_id),
	    CONSTRAINT fk_book FOREIGN KEY (book_id) REFERENCES book(book_id),

	ADD CONSTRAINT df_bd DEFAULT getdate() FOR borrow_date
	*/

	ADD record_id int IDENTITY(1,1)
)
GO
