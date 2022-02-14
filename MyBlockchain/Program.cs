using MyBlockchain.Classes;
using System.Text;

Chain bchain = new Chain();

bchain.AddBlock("привет");
bchain.AddBlock("привет2");
bchain.AddBlock("привет3");

foreach (Block b in bchain)
{
    Console.WriteLine(b);
}
Console.WriteLine("Корректность блокчейн цепи: " + bchain.CheckValid());
