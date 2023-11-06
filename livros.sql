CREATE DATABASE Livros;

CREATE TABLE Livros(
	Id_Livro INT IDENTITY(1,1) PRIMARY KEY,
	Titulo VARCHAR(50),
	Autores  VARCHAR(30),
	EDITORA VARCHAR(30),
	Dataedicao DATETIME,
	Assunto VARCHAR(50),
);

SELECT * FROM Livros;

INSERT INTO Livros(Titulo,Autores,EDITORA,Dataedicao,Assunto) VALUES ('Jogos Vorazes','Suzanne collins','ROCCO',2008-07-14,'Jogos mortais');
INSERT INTO Livros(Titulo,Autores,EDITORA,Dataedicao,Assunto) VALUES ('Tono de vidro','Sarah J. Mass','Galera',2014-07-02,'Ascenção da assassina');
INSERT INTO Livros(Titulo,Autores,EDITORA,Dataedicao,Assunto) VALUES ('O segredo','Rhonda Byrne','Sextante',2006-03-23,'Lei da atração');
INSERT INTO Livros(Titulo,Autores,EDITORA,Dataedicao,Assunto) VALUES ('Fortaleza digital','Dan Brown','Arqueiro',1998-05-27,'Código de criptografia inquebravel que foi criado');
INSERT INTO Livros(Titulo,Autores,EDITORA,Dataedicao,Assunto) VALUES ('Percy Jackson o ladrão de raios','Rick Riordan','Intrínseca',2005-06-28,'Semideuses gregos');
