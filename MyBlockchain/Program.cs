using MyBlockchain.Classes;

Chain bchain = new Chain();

Block block = new Block("Hello Blockchain!");



bchain.AddBlock(block);

bchain.ReadFirst();

