﻿int ay = DateTime.Now.Month;
switch(ay)
{
    case 1: 
    {
        System.Console.WriteLine("Ocak");
        break;
    }
    case 2: 
    {
        System.Console.WriteLine("Şubat");
        break;
    }
    case 3: 
    {
        System.Console.WriteLine("Mart");
        break;
    }
    case 4:
    {
        System.Console.WriteLine("Nisan");
        break;
    }
    case 5:
    {
        System.Console.WriteLine("Mayıs");
        break;
    }
    case 6:
    {
        System.Console.WriteLine("Haziran");
        break;
    }
    case 7 :
    {
        System.Console.WriteLine("Temmuz");
        break;
    }
    case 8 :
    {
        System.Console.WriteLine("Ağustos");
        break;
    }
    case 9:
    {
        System.Console.WriteLine("Eylül");
        break;
    }
    case 10:
    {
        System.Console.WriteLine("Ekim");
        break;
    }
    case 11:
    {
        System.Console.WriteLine("Kasım");
        break;
    }
    case 12:
    {
        System.Console.WriteLine("Aralık");
        break;
    }
    default:
    {
        System.Console.WriteLine("Tarih Bilgisi Hatalı");
        break;
    }
}
switch(ay)
{
    case 12:
    case 1:
    case 2:
    {
        System.Console.WriteLine("Kış");
        break;
    }
    case 3:
    case 4:
    case 5:
    {
        System.Console.WriteLine("İlkbahar");
        break;
    }
    case 6:
    case 7:
    case 8:
    {
        System.Console.WriteLine("Yaz");
        break;
    }
    case 9:
    case 10:
    case 11:
    {
        System.Console.WriteLine("Sonbahar");
        break;
    }
}