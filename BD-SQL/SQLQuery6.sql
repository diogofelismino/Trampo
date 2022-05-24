USE joaozinho_games;



SELECT AVG(preco) FROM dbo.jogos 

SELECT AVG(preco) FROM dbo.jogos  WHERE id_jogo > 5;
 

SELECT * FROM DBO.jogos
WHERE nome LIKE 'O%';

SELECT SUM(preco) FROM dbo.jogos

SELECT MIN(preco) FROM dbo.jogos 

SELECT MAX(preco) FROM dbo.jogos 

INSERT INTO dbo.jogos(id_jogo, nome, preco)
VALUES (9, 'D', 10.90);

INSERT INTO dbo.jogos(id_jogo, nome, preco)
VALUES (10, 'i', 10.90);

INSERT INTO dbo.jogos(id_jogo, nome, preco)
VALUES (11, 'o', 10.90);

INSERT INTO dbo.jogos(id_jogo, nome, preco)
VALUES (12, 'g', 10.90);

INSERT INTO dbo.jogos(id_jogo, nome, preco)
VALUES (13, 'o', 10.90);

DELETE FROM dbo.jogos 
WHERE id_jogo > 8;

BACKUP DATABASE FUNCIONARIOS
TO DISK = 'C:\X\TESTE.BKP'

-- RESTORE DATABASE nomeDoBD  FROM DISK 'CAMINHO' WITH RECOVERY, STATS=10; 

