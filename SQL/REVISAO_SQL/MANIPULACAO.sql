-- ALTERAR TIPO DE ATRIBUTO
ALTER TABLE categoria MODIFY COLUMN FK_JOGO_ID INT NULL;

-- ADICIONAR COLUNA NA TABELA
ALTER TABLE categoria ADD COLUMN [COLUNA QUE QUER ADD] [TIPO DE DADO];
-- EXEMPLO
ALTER TABLE categoria ADD COLUMN DATA_CRIACAO DATETIME NOT NULL;

-- REMOVENDO COLUMN
ALTER TABLE [nome da tabela] DROP COLUMN FK_JOGO_ID;

-- RENOMEANDO COLUNA
ALTER TABLE categoria RENAME COLUMN FK_JOGO_IU TO FK_JOGO_ID;


---------------------------------------------------------------------------------------

-- INSERTS
INSERT INTO categoria (NOME, ATIVO,) VALUES 
("RPG", "S");

-- INSERT MULTILINHAS
INSERT INTO categoria (NOME, ATIVO) VALUES
("AÇÃO", "S"),
("ANIME", "S"),
("CARD GAME", "S"),
("ESTRATÉGIA", "N"),
("CORRIDA", "S");


INSERT INTO jogos (NOME, ANO, PLATAFORMA, ATIVO, DESENVOLVEDORA) VALUES
('The Legend of Zelda: Breath of the Wild', '2017', 'Nintendo Switch', TRUE, 'Nintendo'),
('God of War', '2018', 'PlayStation 4', TRUE, 'Santa Monica Studio'),
('Red Dead Redemption 2', '2018', 'PlayStation 4', TRUE, 'Rockstar Games'),
('The Witcher 3: Wild Hunt', '2015', 'PC', TRUE, 'CD Projekt'),
('Minecraft', '2011', 'Multiplataforma', TRUE, 'Mojang Studios'),
('Fortnite', '2017', 'Multiplataforma', TRUE, 'Epic Games'),
('Cyberpunk 2077', '2020', 'PC', TRUE, 'CD Projekt'),
('Hades', '2020', 'Nintendo Switch', TRUE, 'Supergiant Games'),
('Among Us', '2018', 'PC', TRUE, 'Innersloth'),
('Grand Theft Auto V', '2013', 'Multiplataforma', TRUE, 'Rockstar Games'),
('Elden Ring', '2022', 'PlayStation 5', TRUE, 'FromSoftware'),
('Hollow Knight', '2017', 'PC', TRUE, 'Team Cherry'),
('Stardew Valley', '2016', 'PC', TRUE, 'ConcernedApe'),
('Overwatch', '2016', 'PC', TRUE, 'Blizzard Entertainment'),
('League of Legends', '2009', 'PC', TRUE, 'Riot Games'),
('Valorant', '2020', 'PC', TRUE, 'Riot Games'),
('FIFA 23', '2022', 'Multiplataforma', TRUE, 'EA Sports'),
('Call of Duty: Modern Warfare II', '2022', 'Multiplataforma', TRUE, 'Infinity Ward'),
('Assassin’s Creed Valhalla', '2020', 'Multiplataforma', TRUE, 'Ubisoft'),
('Animal Crossing: New Horizons', '2020', 'Nintendo Switch', TRUE, 'Nintendo');


INSERT INTO jogos (NOME, ANO, PLATAFORMA, ATIVO, DESENVOLVEDORA) VALUES
('Diablo', '1996', 'PC', TRUE, 'Blizzard Entertainment'),
('Diablo: Hellfire', '1997', 'PC', TRUE, 'Sierra On-Line'),
('Diablo II', '2000', 'PC', TRUE, 'Blizzard North'),
('Diablo II: Lord of Destruction', '2001', 'PC', TRUE, 'Blizzard North'),
('Diablo III', '2012', 'PC', TRUE, 'Blizzard Entertainment'),
('Diablo III: Reaper of Souls', '2014', 'PC', TRUE, 'Blizzard Entertainment'),
('Diablo IV', '2023', 'Multiplataforma', TRUE, 'Blizzard Entertainment');

-- BALDUR'S GATE
INSERT INTO jogos (NOME, ANO, PLATAFORMA, ATIVO, DESENVOLVEDORA) VALUES
("Baldur's Gate", '1998', 'PC', TRUE, 'BioWare'),
("Baldur's Gate: Tales of the Sword Coast", '1999', 'PC', TRUE, 'BioWare'),
("Baldur's Gate II: Shadows of Amn", '2000', 'PC', TRUE, 'BioWare'),
("Baldur's Gate II: Throne of Bhaal", '2001', 'PC', TRUE, 'BioWare'),
("Baldur's Gate III", '2023', 'PC', TRUE, 'Larian Studios');

-- HALO
INSERT INTO jogos (NOME, ANO, PLATAFORMA, ATIVO, DESENVOLVEDORA) VALUES
('Halo: Combat Evolved', '2001', 'Xbox', TRUE, 'Bungie'),
('Halo 2', '2004', 'Xbox', TRUE, 'Bungie'),
('Halo 3', '2007', 'Xbox 360', TRUE, 'Bungie'),
('Halo 4', '2012', 'Xbox 360', TRUE, '343 Industries');


---------------------------------------------------------------------------------------


-- CONSULTAR O BANCO


-- CONSULTA TOTAL DA TABELA
SELECT * FROM categoria;

-- CONSULTA NOME DA CATEGORIA
SELECT NOME FROM categoria;

-- COLETANDO SOMENTE 2 CAMPOS DA MINHA TABELA DE JOGOS
SELECT NOME, PLATAFORMA FROM jogos;

-- ORDEM ALFABETICA
SELECT NOME FROM jogos ORDER BY NOME ASC;

-- ORDEM POR ANO DE LANÇAMENTO
SELECT * FROM jogos ORDER BY ANO ASC;

-- BOTÃO QUE SELECIONA O ANO. [2016]
SELECT * FROM jogos WHERE ANO = '2016';

-- TRAZ TUDO DO GAMES
SELECT * FROM jogos;


----------------------------------------------------------------------------------------

-- UPDATES DE DADOS
UPDATE categoria SET ATIVO = "S" WHERE ID = 1;