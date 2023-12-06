--Peliculas
--	Id
--	Nombre
--	Fecha_Salida
--	Duracion(m)
--	Clasificacion
--	Poster
--	Generos
--	Puntuacion_IMDB

--Datos_Peliculas
--	Id
--	Id_Pelicula
--	Descripcion
--	Trailer
--	Opinion_Usuario
--	Puntuacion_Usuario

--Reparto_Pelicula
--	Id
--	Id_Datos_Peliculas
--	Dirección
--	Guión
--	Actores
--	Personajes

--Actores
--  Id
--	Nombre
--	Apellido
--	Edad
--	Foto

--create table Peliculas (
--Id INT NOT NULL PRIMARY KEY IDENTITY,
--Nombre varchar(200),
--Fecha_Salida Date,
--Duracion int,
--Clasificacion varchar(10),
--Poster varchar(250),
--Generos varchar(250),
--Puntuacion_IMDB char(8)
--)

--create table Datos_Pelicula (
--Id INT NOT NULL PRIMARY KEY IDENTITY,
--Id_Pelicula INT FOREIGN KEY REFERENCES Peliculas(Id),
--Descripcion varchar(1000),
--Trailer varchar(250),
--Opinion_Usuario varchar(1000),
--Puntuacion_Usuario char(8)
--)

--create table Reparto_Pelicula (
--Id INT NOT NULL PRIMARY KEY IDENTITY,
--Id_Datos_Pelicula INT FOREIGN KEY REFERENCES Datos_Pelicula(Id),
--Direccion varchar(250),
--Guion varchar(250),
--Actores varchar(250),
--Personajes varchar(1000)
--)

--create table Actores (
--Id INT NOT NULL PRIMARY KEY IDENTITY,
--Nombre varchar(250),
--Apellido varchar(250),
--Edad int,
--Foto varchar(250)
--)

--insert into Peliculas values ('Barbie', '09/07/2023', 114, 'PG-13', 'https://m.media-amazon.com/images/M/MV5BZjhlOWYyNWMtMzIxZi00MmQxLTk4MTktNWIxZGNmM2NjOWM5XkEyXkFqcGdeQXVyMTQ4NTgxNzYx._V1_QL75_UY281_CR19,0,190,281_.jpg', 'Aventura, Comedia, Fantasía','7.1')
--insert into Datos_Pelicula values (1,
--'Barbie vive en Barbieland donde todo es ideal y lleno de música y color. Un buen día decide conocer el mundo real. Cuando el CEO de Mattel se entere tratará de evitarlo a toda costa y devolver a Barbie a una caja.',
--'https://www.youtube.com/watch?v=pBk4NYhWNMM&pp=ygUWYmFyYmllIHRyYWlsZXIgZW5nbGlzaA%3D%3D',
--'','')
--insert into Reparto_Pelicula values (1,'Greta Gerwig', 'Greta Gerwig, Noah Baumbach', 'Margot Robbie, Ryan Gosling, Issa Rae', 'Barbie, Ken')
--insert into Actores values ('Margot', 'Robbie', '33', 'https://m.media-amazon.com/images/M/MV5BMTgxNDcwMzU2Nl5BMl5BanBnXkFtZTcwNDc4NzkzOQ@@._V1_QL75_UY207_CR8,0,140,207_.jpg')
--insert into Actores values ('Ryan', 'Gosling', 42, 'https://m.media-amazon.com/images/M/MV5BMTQzMjkwNTQ2OF5BMl5BanBnXkFtZTgwNTQ4MTQ4MTE@._V1_QL75_UY207_CR12,0,140,207_.jpg')
--insert into Actores values ('Issa', 'Rae', 38, 'https://m.media-amazon.com/images/M/MV5BMTUyODI3MDg1OF5BMl5BanBnXkFtZTgwMjc5NTc5MDI@._V1_QL75_UY207_CR8,0,140,207_.jpg')

select * from Peliculas P
left join Datos_Pelicula DP on P.Id = DP.Id_Pelicula
left join Reparto_Pelicula RP on DP.Id = RP.Id_Datos_Pelicula
left join Actores A on A.Id > 0

--update Datos_Pelicula set Trailer = 'https://www.youtube.com/watch?v=pBk4NYhWNMM' where Id = 1