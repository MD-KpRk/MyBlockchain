using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlockchain.Classes
{
    class BlockChain
    {
        List<Block>? blocks;

        public byte[]? last_hash;

        public BlockChain()
        {
            blocks = new List<Block>();
            last_hash = null;
        }

        public void addBlock()
        {
            //Добавление блока в блокчейн
        }

    }
}
