

---------- sub consulta ------------------



SELECT D.CD_DEPARTAMENTO, D.NM_DEPARTAMENTO, TOTAL = (SELECT COUNT(*) 
									FROM FUNCIONARIOS F 
									WHERE F.CD_DEPARTAMENTO = D.CD_DEPARTAMENTO) 
FROM DEPARTAMENTOS D
----------------------------------------------------------------------------------
SELECT * FROM FUNCIONARIOS
SELECT * FROM DEPARTAMENTOS
----------------------------------------------------------------------------------
SELECT * FROM
 (SELECT D.NM_DEPARTAMENTO ,MIN(F.VL_SALARIO) AS [MENOR SALARIO]
  FROM FUNCIONARIOS F JOIN DEPARTAMENTOS D 
  ON F.CD_DEPARTAMENTO = D.CD_DEPARTAMENTO 
  GROUP BY D.NM_DEPARTAMENTO )  A