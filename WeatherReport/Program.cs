using System;

var weatherDatas = new[] {
    new { day = "월요일", maxTemp = 12, minTemp = 3, rainPossibility = 0.2 },
    new { day = "화요일", maxTemp = 8, minTemp = -1, rainPossibility = 0.6 },
    new { day = "수요일", maxTemp = 5, minTemp = -3, rainPossibility = 0.8 },
    new { day = "목요일", maxTemp = 10, minTemp = 2, rainPossibility = 0.4 },
    new { day = "금요일", maxTemp = 15, minTemp = 5, rainPossibility = 0.1 }
};

Console.WriteLine($"=== 5일간 날씨 예보 ===");
Console.WriteLine($"요일\t최고기온    최저기온   강수확률");
Console.WriteLine($"--------------------------------------------");
double maxTempSum = 0;
int rainyDayCount = 0;
foreach (var  weather in weatherDatas) {
    Console.WriteLine($"{weather.day}\t    {weather.maxTemp, 2}도\t{weather.minTemp, 2}도\t    {weather.rainPossibility:P0}");
    maxTempSum += weather.maxTemp;
    if (weather.rainPossibility > 0.5) { rainyDayCount++; }
}
Console.WriteLine($"--------------------------------------------");
Console.WriteLine($"최고기온 평균 : {(double)maxTempSum / weatherDatas.Length:F1}도");
Console.WriteLine($"비 올 가능성 높은 날(50% 이상) : {rainyDayCount}일");
Console.WriteLine();
Console.WriteLine();