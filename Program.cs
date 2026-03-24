// operators

//int a = 5, b = 5, c = 10, d = 3;
//string username = "yunusg";
//string password = "123";


//var sonuc = (a == b);
//sonuc = (a == d);
//sonuc=(username == "yunusg" && password == "123");

//sonuc = (a != b);
//sonuc = (a != d);
//sonuc = (a > c);
//sonuc = (a > c);
//sonuc = (a >=b);
////ternary operator
//var sonuc2 = (a > b) ? "a büyüktür b" :(a==b) ? "a b eşit":"b büyük";


//Console.WriteLine(sonuc2);


Console.WriteLine("Yasiniz:");
var yas = Convert.ToInt32(Console.ReadLine());

var sonuc = (yas >= 18) ? "Ehliyet alabilirsiniz" : "Ehliyet alamazsiniz";

Console.WriteLine(sonuc);


Console.WriteLine("Lütfen bir sayı giriniz:");

var sayı = Convert.ToInt32(Console.ReadLine());

var sonuc = (sayı > 0) ? "sayı pozitif" : "sayı negatif";

Console.WriteLine(sonuc);

Console.WriteLine("Lütfen bir sayı giriniz:");

var sayi = Convert.ToInt32(Console.ReadLine());

var sonuc = (sayi % 2 == 0) ? "sayı çift" : "sayı tek";
Console.WriteLine(sonuc);




