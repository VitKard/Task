Console.Write("Введите пятизначное число: ");
string s=Console.ReadLine()!;
while (s.Length>5)
{
    Console.Write("Вы ошиблись!\nВведите пятизначное число: ");
    s=Console.ReadLine()!;
}
while (s.Length<5)
{
    Console.Write("Вы ошиблись!\nВведите пятизначное число: ");
    s=Console.ReadLine()!;
}
if (s[0]==s[4] && s[1]==s[3])
Console.WriteLine("палиндром");
else
Console.WriteLine("не палиндром");