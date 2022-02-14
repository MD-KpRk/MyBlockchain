using BlockChain;

Chain bchain = new Chain();

bchain.AddBlock("Сообщение 1");
bchain.AddBlock("Сообщение 2");
bchain.AddBlock("Сообщение 3");

foreach (Block b in bchain)
{
    Console.WriteLine(b);
}

Console.WriteLine("Корректность блокчейн цепи: " + bchain.CheckValid());
