using System;

string title = "인터스텔라";
string genre = "SF";
double rating = 9.2;
int releaseYear = 2014;;

var movie = new { title, genre, rating, releaseYear };

Console.WriteLine($"=== 영화 정보 ===");
Console.WriteLine($"제목 : {movie.title}");
Console.WriteLine($"장르 : {movie.genre}");
Console.WriteLine($"평점 : {movie.rating}");
Console.WriteLine($"개봉연도 : {movie.releaseYear}");
Console.WriteLine();

  
Console.WriteLine($"Tostring 결과 : ");
Console.WriteLine(movie.ToString());
Console.WriteLine();
Console.WriteLine();