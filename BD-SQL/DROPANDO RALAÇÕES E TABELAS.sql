USE FUNCIONARIO

DROP TABLE BANCOS(CD_BANCO INT IDENTITY(1,1) PRIMARY KEY NOT NULL, 
NM_BANCO VARCHAR(150) NOT NULL,
AGENCIA INT,
NUMERO_BANCO INT
);

DROP TABLE FUNCIONARIOS(CD_FUNCIONARIO INT IDENTITY(1,1) PRIMARY KEY NOT NULL, 
CD_DEPARTAMENTO INT NOT NULL,
CD_BANCO INT NOT NULL,
NM_FUNCIONARIO VARCHAR(150) NOT NULL,
DT_ADMISSAO DATETIME,
DT_NASCIMENTO DATETIME,
);

DROP TABLE DEPARTAMENTO(CD_DEPARTAMENTO INT IDENTITY(1,1) PRIMARY KEY NOT NULL, 
NM_DEPARTAMENTO VARCHAR(150) NOT NULL,

);


ALTER TABLE FUNCIONARIOS
DROP CONSTRAINT FK_FUNCIONARIO_X_BANCOS



ALTER TABLE FUNCIONARIOS
DROP CONSTRAINT FK_FUNCIONARIO_X_DEPARTAMENTO
