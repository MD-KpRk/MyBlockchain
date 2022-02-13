using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlockchain.Classes
{
    class Chain
    {
        List<Block>? blocks;

        public byte[]? last_hash;

        public Chain()
        {
            blocks = new List<Block>();
            last_hash = null;
        }

        public void AddBlock(Block block)
        {
            blocks?.Add(block);
            last_hash = block.GetHash();
        }

        public void ReadFirst()
        {
            if (blocks == null || last_hash == null) return;

            Console.WriteLine(blocks.First().GetMessage());
        }

    }
}
