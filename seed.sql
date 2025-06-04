-- Aktorzy
INSERT INTO aktorzy (id, imie, nazwisko, data_urodzenia) VALUES
(1, 'Robert', 'Wiêckiewicz', '1967-06-30'),
(2, 'Agnieszka', 'Grochowska', '1979-12-31'),
(3, 'Borys', 'Szyc', '1978-09-04'),
(4, 'Ryan', 'Reynolds', '1976-10-23'),
(5, 'Tomasz', 'Kot', '1977-04-21'),
(6, 'Leonardo', 'DiCaprio', '1974-11-11'),
(7, 'Meryl', 'Streep', '1949-06-22'),
(8, 'Tom', 'Hanks', '1956-07-09'),
(9, 'Scarlett', 'Johansson', '1984-11-22'),
(10, 'Brad', 'Pitt', '1963-12-18');

-- Re¿yserzy
INSERT INTO rezyserzy (id, imie, nazwisko, data_urodzenia) VALUES
(1, 'Steven', 'Spielberg', '1946-12-18'),
(2, 'Quentin', 'Tarantino', '1963-03-27'),
(3, 'Agnieszka', 'Holland', '1948-11-28'),
(4, 'Shawn', 'Levy', '1968-07-23'),
(5, 'Christopher', 'Nolan', '1970-07-30'),
(6, 'Patryk', 'Vega', '1977-01-02'),
(7, 'Martin', 'Scorsese', '1942-11-17'),
(8, 'W³adys³aw', 'Pasikowski', '1959-06-14'),
(9, 'James', 'Cameron', '1954-08-16'),
(10, 'Juliusz', 'Machulski', '1955-03-10');

-- Filmy
INSERT INTO filmy (id, tytul, data_wydania, gatunki, sciezkadoobrazu, aktor_id, rezyser_id, sciezka_do_pliku) VALUES
(1, 'Deadpool & Wolverine', '2024-07-26', 'Akcja', 'https://m.media-amazon.com/images/M/MV5BZTk5ODY0MmQtMzA3Ni00NGY1LThiYzItZThiNjFiNDM4MTM3XkEyXkFqcGc@._V1_SX300.jpg', 4, 4, 'G:\Arr\123\Oppenheimer.mkv'),
(2, 'Incepcja', '2010-07-16', 'Sci-Fi, Thriller', 'https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_SX300.jpg', 6, 5, NULL),
(3, 'Titanic', '1997-12-19', 'Dramat, Romans', 'https://m.media-amazon.com/images/M/MV5BYzYyN2FiZmUtYWYzMy00MzViLWJkZTMtOGY1ZjgzNWMwN2YxXkEyXkFqcGc@._V1_SX300.jpg', 6, 9, NULL),
(4, 'Forrest Gump', '1994-07-06', 'Dramat, Komedia', 'https://m.media-amazon.com/images/M/MV5BNDYwNzVjMTItZmU5YS00YjQ5LTljYjgtMjY2NDVmYWMyNWFmXkEyXkFqcGc@._V1_SX300.jpg', 8, 1, NULL),
(5, 'Plan 9 From Outer Space', '1959-07-22', 'Sci-Fi', 'https://m.media-amazon.com/images/M/MV5BZGM4Y2MwMzktODg3MS00ZjVkLTk2NGMtY2Y0M2Y2MWQ0ZDBiXkEyXkFqcGc@._V1_SX300.jpg', 1, 2, NULL),
(6, 'Pulp Fiction', '1994-10-14', 'Kryminalny, Dramat', 'https://m.media-amazon.com/images/M/MV5BYTViYTE3ZGQtNDBlMC00ZTAyLTkyODMtZGRiZDg0MjA2YThkXkEyXkFqcGc@._V1_SX300.jpg', 10, 2, NULL),
(7, 'Lista Schindlera', '1993-12-15', 'Dramat, Historyczny', 'https://m.media-amazon.com/images/M/MV5BNjM1ZDQxYWUtMzQyZS00MTE1LWJmZGYtNGUyNTdlYjM3ZmVmXkEyXkFqcGc@._V1_SX300.jpg', 1, 1, NULL),
(8, 'Diabe³ ubiera siê u Prady', '2006-06-30', 'Komedia', 'https://m.media-amazon.com/images/M/MV5BOWM3NTI3YWEtYjJmMy00M2U5LWI1NzEtZWM3ZDY2ZWNjOGRiXkEyXkFqcGc@._V1_SX300.jpg', 7, 3, NULL),
(9, 'Avengers: Koniec gry', '2019-04-26', 'Akcja, Sci-Fi', 'https://m.media-amazon.com/images/M/MV5BMTc5MDE2ODcwNV5BMl5BanBnXkFtZTgwMzI2NzQ2NzM@._V1_SX300.jpg', 9, 9, NULL),