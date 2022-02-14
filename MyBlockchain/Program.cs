using MyBlockchain.Classes;

Chain bchain = new Chain();

bchain.AddBlock("привет");
bchain.AddBlock("привет2");

Console.WriteLine(bchain[0]);
Console.WriteLine(bchain[1]);

