USE JY
GO

UPDATE book
SET interview_times = '0'
FROM book
WHERE book_publisher = '电子工业出版社'
GO

SELECT * FROM book
GO

/*
DELETE FROM reader
WHERE reader_id = 'r003'
GO

SELECT * FROM reader
GO
*/