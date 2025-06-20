using System.Reflection.Metadata.Ecma335;
using ABSTRAINDO_CELULAR.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("================================================ RETORNO NOKIA ================================================");
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp", "Nokia 3310", "123456789012345", 64);

Console.WriteLine("=============================================== RETORNO IPHONE ===============================================");
Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("987654321", "iPhone 15", "987654321098765", 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram", "iPhone 15", "987654321098765", 256);
Console.WriteLine("==============================================================================================================");

// ALÉM DOS "TODOS" PARA IMPLEMENTAR, 
// O CÓDIGO ESTÁ PRONTO PARA SER EXECUTADO E TESTADO COMPLETAMENTE.