using System;

var defaultSetting = new { ResulutionWidth = 1920, ResolutionHeight = 1080, Volume = 50, Difficulty = "보통" };
var userSetting = new { ResulutionWidth = 1920, ResolutionHeight = 1080, Volume = 80, Difficulty = "어려움" };

Console.WriteLine($"=== 게임 설정 비교 ===");
Console.WriteLine();

Console.WriteLine($"[기본 설정]");
Console.WriteLine(defaultSetting);
Console.WriteLine();

Console.WriteLine($"[사용자 설정]");
Console.WriteLine(userSetting);
Console.WriteLine();

Console.WriteLine($"[타입 비교]");
Console.WriteLine(defaultSetting.GetType() == userSetting.GetType());
Console.WriteLine();

Console.WriteLine($"[값 비교]");
Console.WriteLine($"Equals 결과 : {defaultSetting.Equals(userSetting)} (Volume, Difficulty 값이 다름)");
Console.WriteLine();

var backupSetting = defaultSetting;
Console.WriteLine($"[백업 설정]");
Console.WriteLine(backupSetting);
Console.WriteLine($"기본 설정과 Equals : {defaultSetting.Equals(backupSetting)} (모든 값이 동일)");
Console.WriteLine();

var settingLists = new[] {
    defaultSetting,
    userSetting,
    defaultSetting
};
Console.WriteLine($"=== 설정 목록 (배열) ===");
foreach ( var setting in settingLists ) { Console.WriteLine($"설정 1 : {setting.ResulutionWidth}x{setting.ResolutionHeight}, 볼룸 {setting.Volume}, 난이도 {setting.Difficulty}"); }
Console.WriteLine();

var diffSetting = new { Volume = 50, Difficulty = "보통", ResolutionWidth = 1920, ResolutionHeight = 1080 };
Console.WriteLine($"=== 속성 순서가 다른 설정 ===");
Console.WriteLine(diffSetting);
Console.WriteLine($"설정과 같은 타입 : {defaultSetting.GetType() == diffSetting.GetType()} (속성 순서가 달라 다른 타입)");
Console.WriteLine();
Console.WriteLine();

