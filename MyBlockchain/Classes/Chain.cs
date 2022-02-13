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

        public void AddBlock(string message)
        {
            if (blocks == null) throw new NullReferenceException("Коллекция блоков не инициализирована");

            Block newblock;
            if (last_hash != null)
                newblock = new Block(last_hash, message);
            else
                newblock = new Block(message); // Создания генезис-блока

            blocks.Add(newblock);
            last_hash = newblock.GetHash();
        }

        public void ReadFirst()
        {
            if (blocks == null || last_hash == null) return;

            Console.WriteLine(blocks.First().GetMessage());
        }

        // Метод для проверки целостности последовательности блоков
        public bool CheckValid()
        {
            return false;
        }

    }
}
