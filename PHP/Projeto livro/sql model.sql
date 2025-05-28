CREATE TABLE livro (
  livro_id INTEGER   NOT NULL ,
  livro_nome VARCHAR    ,
  livro_desc TEXT    ,
  livro_valor INTEGER    ,
  livro_capa VARCHAR    ,
  livro_editora_fk INTEGER    ,
  livro_autor_fk INTEGER    ,
  livro_pag INTEGER    ,
  livro_pub DATETIME      ,
PRIMARY KEY(livro_id));




CREATE TABLE Usuario (
  user_id INTEGER   NOT NULL ,
  user_nome VARCHAR    ,
  user_cpf VARCHAR    ,
  user_end VARCHAR    ,
  user_end_num INTEGER    ,
  user_nasc DATETIME    ,
  user_sexo VARCHAR    ,
  user_cel VARCHAR      ,
PRIMARY KEY(user_id));




CREATE TABLE autor (
  autor_id INTEGER   NOT NULL ,
  livro_id INTEGER   NOT NULL ,
  autor_nome VARCHAR    ,
  autor_sobrenome VARCHAR    ,
  autor_desc TEXT    ,
  autor_nasc DATETIME      ,
PRIMARY KEY(autor_id)  ,
  FOREIGN KEY(livro_id)
    REFERENCES livro(livro_id));


CREATE INDEX autor_FKIndex1 ON autor (livro_id);


CREATE INDEX IFK_Rel_02 ON autor (livro_id);


CREATE TABLE editora (
  edit_id INTEGER   NOT NULL ,
  livro_id INTEGER   NOT NULL ,
  edit_nome VARCHAR    ,
  edit_cnpj VARCHAR    ,
  edit_desc VARCHAR      ,
PRIMARY KEY(edit_id)  ,
  FOREIGN KEY(livro_id)
    REFERENCES livro(livro_id));


CREATE INDEX editora_FKIndex1 ON editora (livro_id);


CREATE INDEX IFK_Rel_01 ON editora (livro_id);



