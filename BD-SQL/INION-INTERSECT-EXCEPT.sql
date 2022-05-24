USE MEUFUNCIONARIO
---------- UNION  ------------------------
SELECT F.CD_FUNCIONARIO, F.NM_FUNCIONARIO, F.CD_DEPARTAMENTO CATEGORIA  FROM FUNCIONARIOS F
WHERE F.CD_DEPARTAMENTO = 4
UNION
SELECT F.CD_FUNCIONARIO, F.NM_FUNCIONARIO, F.CD_DEPARTAMENTO FROM FUNCIONARIOS F
WHERE F.CD_FUNCIONARIO = 7


---------- INTERSECT -------------------------------
SELECT F.CD_FUNCIONARIO,F.NM_FUNCIONARIO, F.CD_DEPARTAMENTO FROM FUNCIONARIOS F
WHERE F.CD_DEPARTAMENTO =4
INTERSECT
SELECT F.CD_FUNCIONARIO, F.NM_FUNCIONARIO, F.CD_DEPARTAMENTO FROM FUNCIONARIOS F
WHERE F.CD_FUNCIONARIO =7


---------- EXCEPT -----------------------------------

SELECT F.CD_FUNCIONARIO,F.NM_FUNCIONARIO, F.CD_DEPARTAMENTO FROM FUNCIONARIOS F
WHERE F.CD_DEPARTAMENTO =4
EXCEPT
SELECT F.CD_FUNCIONARIO, F.NM_FUNCIONARIO, F.CD_DEPARTAMENTO FROM FUNCIONARIOS F
WHERE F.CD_FUNCIONARIO =7





SELECT F.CD_FUNCIONARIO,F.NM_FUNCIONARIO, F.CD_DEPARTAMENTO FROM FUNCIONARIOS F
WHERE F.CD_DEPARTAMENTO =4
EXCEPT
SELECT F.CD_FUNCIONARIO, F.NM_FUNCIONARIO, F.CD_DEPARTAMENTO FROM 
(VALUES(8,'LUCAS', 4)) F (CD_FUNCIONARIO, NM_FUNCIONARIO, CD_DEPARTAMENTO)





--1)--------------------------------------

SELECT F.NM_FUNCIONARIO FROM FUNCIONARIOS F
WHERE F.CD_DEPARTAMENTO =1
UNION
SELECT  F.NM_FUNCIONARIO  FROM FUNCIONARIOS F
WHERE F.CD_BANCO = 1


SELECT F.NM_FUNCIONARIO FROM FUNCIONARIOS F
WHERE F.CD_DEPARTAMENTO =1
INTERSECT
SELECT  F.NM_FUNCIONARIO  FROM FUNCIONARIOS F
WHERE F.CD_BANCO = 1

-------------------------------------------------
SELECT * FROM FUNCIONARIOS
---2)-----------------------------------------------

SELECT F.NM_FUNCIONARIO FROM FUNCIONARIOS F
WHERE F.CD_BANCO  IS NULL
UNION
SELECT  F.NM_FUNCIONARIO  FROM FUNCIONARIOS F
WHERE F.CD_DEPARTAMENTO IN (3, 4)

SELECT F.NM_FUNCIONARIO FROM FUNCIONARIOS F
WHERE F.CD_BANCO  IS NULL
INTERSECT
SELECT  F.NM_FUNCIONARIO  FROM FUNCIONARIOS F
WHERE F.CD_DEPARTAMENTO IN (3, 4)


SELECT F.NM_FUNCIONARIO FROM FUNCIONARIOS F
WHERE F.CD_BANCO  IS NULL
EXCEPT
SELECT  F.NM_FUNCIONARIO  FROM FUNCIONARIOS F
WHERE F.CD_DEPARTAMENTO IN (3, 4)

-----------------------------------------------------


