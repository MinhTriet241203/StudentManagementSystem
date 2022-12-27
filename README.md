# StudentManagementSystem

Phần thống kê tụi tui query lấy thông tin và sử dụng để tính điểm trung bình trong cột AVG và đánh giá được học lực ở cột EVAL nhưng mà không thể làm cho Visual Studio hiện ra trong dataGridView được.

![image](https://user-images.githubusercontent.com/111042904/209681369-152fc18d-4c96-4794-8392-e372d2ce59a3.png)

Query để ra được kết quả ở trên:

```SQL
SELECT  Students.StudentName, AVG(Scores.Score) AS Average, 
CASE WHEN AVG(Scores.Score) > 5 THEN 'good' 
WHEN AVG(Scores.Score) = 5 THEN 'average' 
END AS Evaluation
FROM      Scores INNER JOIN
                 Students ON Scores.StudentID = Students.StudentID
GROUP BY Students.StudentName
```
