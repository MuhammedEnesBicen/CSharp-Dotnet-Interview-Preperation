#### Question asked in Doğuş Teknoloji preinterview coding test on Coensio platform

### Question Image

![SQL AVG Question](https://github.com/MuhammedEnesBicen/CSharp-Dotnet-Interview-Preperation/blob/main/images/i2.png)

## Solution

```SQL
CREATE TABLE Expenses (
  monthNumber VARCHAR(7),
  weekNumber VARCHAR(6),
  expense INT
);

INSERT INTO Expenses VALUES ("month01","week01",12);
INSERT INTO Expenses VALUES ("month01","week02",21);
INSERT INTO Expenses VALUES ("month01","week03",33);
INSERT INTO Expenses VALUES ("month01","week04",18);
INSERT INTO Expenses VALUES ("month02","week01",35);
INSERT INTO Expenses VALUES ("month02","week02",27);

SELECT monthNumber, FORMAT(AVG(expense) , 'N2') as avg_expense
FROM Expenses
GROUP BY monthNumber
ORDER BY avg_expense DESC
;
```

You can try on this [website online](https://sqlfiddle.com/sql-server/online-compiler?id=2fb4ca57-317f-4dc0-95a2-d1fb1da1c0e8)
