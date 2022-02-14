using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlockchain.Classes
{
    class Chain : IEnumerable
    {
        List<Block>? blocks;

        public byte[]? last_hash;

        public IEnumerator GetEnumerator() =>
            blocks != null ? ((IEnumerable)blocks).GetEnumerator() : throw new NullReferenceException("Коллекция блоков не инициализирована");

        public Block this[int index]
        {
            get =>
                blocks != null ? blocks[index] : throw new NullReferenceException("Коллекция блоков не инициализирована");
        }

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
                newblock = new Block(message); // Создания генезис-блока при отсуствии предыдущего

            blocks.Add(newblock);
            last_hash = newblock.GetCurrentHash();
        }

        public void ReadFirst()
        {
            if (blocks == null || last_hash == null) return;

            Console.WriteLine(blocks.First().GetMessage());
        }


        // Метод для проверки целостности последовательности блоков
        public bool CheckValid()
        {
            if(blocks == null) throw new NullReferenceException("Коллекция блоков не инициализирована");
            if(blocks.Count()==1) return true;

            for(int i=1;i<blocks.Count();i++)
            {
                if (blocks[i - 1].GetCurrentHash() != blocks[i].GetPreviosHash())
                    return false;
            }

            return true;
        }
    }
}
