

--1)

SELECT YEAR(F.DT_ADMISSAO), COUNT(*) FROM FUNCIONARIOS  F GROUP BY F.DT_ADMISSAO


DROP TABLE IF EXISTS #X
CREATE TABLE #X(ANOS INT, QTN INT)

USE MEUFUNCIONARIO
DECLARE @MIN INT = (SELECT ANO_MIN = MIN(YEAR(DT_ADMISSAO))
FROM FUNCIONARIOS)
DECLARE @MAX INT = (SELECT ANO_MAX = MAX(YEAR(DT_ADMISSAO))
FROM FUNCIONARIOS)

WHILE @MIN <= @MAX
BEGIN
INSERT INTO #X VALUES
(@MIN, (SELECT COUNT(NM_FUNCIONARIO) FROM FUNCIONARIOS WHERE YEAR(DT_ADMISSAO) = @MIN))
SET @MIN = @MIN + 1
END

SELECT * FROM #X

















DROP TABLE IF EXISTS #Y
CREATE TABLE #Y (ANO INT, MES INT, QTN INT)

DECLARE @MINI INT = (SELECT MIN(YEAR(F.DT_ADMISSAO)) FROM FUNCIONARIOS F)
DECLARE @MAXI INT = (SELECT MAX(YEAR(F.DT_ADMISSAO)) FROM FUNCIONARIOS F)
DECLARE @MES INT = 1

WHILE @MINI <= @MAXI

BEGIN
	WHILE @MES<= 12
	BEGIN
	INSERT INTO #Y VALUES(@MINI, @MES , (SELECT COUNT(NM_FUNCIONARIO) FROM FUNCIONARIOS F WHERE YEAR(F.DT_ADMISSAO) = @MINI AND  MONTH(F.DT_ADMISSAO) = @MES))

	SET @MES = @MES + 1
	END
	SET @MINI = @MINI + 1
	IF(@MINI <= @MAXI)
	SET @MES = 1
END
		


SELECT * FROM #Y






DROP TABLE IF EXISTS #X
CREATE TABLE #X(ANOS INT, QTN INT)

USE MEUFUNCIONARIO
DECLARE @MIN INT = (SELECT ANO_MIN = MIN(YEAR(DT_ADMISSAO))
FROM FUNCIONARIOS)
DECLARE @MAX INT = (SELECT ANO_MAX = MAX(YEAR(DT_ADMISSAO))
FROM FUNCIONARIOS)

WHILE @MIN <= @MAX
BEGIN
INSERT INTO #X VALUES
(@MIN, (SELECT COUNT(NM_FUNCIONARIO) FROM FUNCIONARIOS WHERE YEAR(DT_ADMISSAO) = @MIN))
SET @MIN = @MIN + 1
END

SELECT * FROM #X WHERE QTN = 0








DROP TABLE IF EXISTS #X
CREATE TABLE #X(ANOS INT, QTN INT)

USE MEUFUNCIONARIO
DECLARE @MIN INT = (SELECT ANO_MIN = MIN(YEAR(DT_ADMISSAO))
FROM FUNCIONARIOS)
DECLARE @MAX INT = (SELECT ANO_MAX = MAX(YEAR(DT_ADMISSAO))
FROM FUNCIONARIOS)

WHILE @MIN <= @MAX
BEGIN
INSERT INTO #X VALUES
(@MIN, (SELECT COUNT(NM_FUNCIONARIO) FROM FUNCIONARIOS WHERE YEAR(DT_ADMISSAO) = @MIN))
DELETE FROM #X WHERE QTN >0
SET @MIN = @MIN + 1
END

SELECT * FROM #X 












SELECT YEAR(F.DT_ADMISSAO) ANOS, F.VL_SALARIO, (SELECT SUM(T.VL_SALARIO) FROM FUNCIONARIOS T WHERE T.DT_ADMISSAO <= F.DT_ADMISSAO) AS ACUMULADO
FROM FUNCIONARIOS F GROUP BY F.DT_ADMISSAO , F.VL_SALARIO 















