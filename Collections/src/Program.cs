using Collections;

Console.WriteLine("==========================");
Console.WriteLine("Egyption Phone Validation");
Console.WriteLine("==========================");

string phone1 = "01012345678";
Console.WriteLine($"Is valid egyptian phone `{phone1}` ? {phone1.IsValidEgyptianPhone()}");

string phone2 = "+201512345678";
Console.WriteLine($"Is valid egyptian phone `{phone2}` ? {phone2.IsValidEgyptianPhone()}");

string phone3 = "01312345678";
Console.WriteLine($"Is valid egyptian phone `{phone3}` ? {phone3.IsValidEgyptianPhone()}");

string phone4 = "0101234567";
Console.WriteLine($"Is valid egyptian phone `{phone4}` ? {phone4.IsValidEgyptianPhone()}");

string phone5 = "0101234567a";
Console.WriteLine($"Is valid egyptian phone `{phone5}` ? {phone5.IsValidEgyptianPhone()}");

Console.WriteLine("\n===============================");
Console.WriteLine("Egyptian National Id Validation");
Console.WriteLine("===============================");

string nationalId1 = "29901011234567";
Console.WriteLine($"Is valid egyptian national id `{nationalId1}` ? {nationalId1.IsValidEgyptianNationalId()}");

string nationalId2 = "19901011234567";
Console.WriteLine($"Is valid egyptian national id `{nationalId2}` ? {nationalId2.IsValidEgyptianNationalId()}");

string nationalId3 = "2990101123456";
Console.WriteLine($"Is valid egyptian national id `{nationalId3}` ? {nationalId3.IsValidEgyptianNationalId()}");