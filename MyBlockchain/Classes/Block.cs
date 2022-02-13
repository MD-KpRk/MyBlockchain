using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlockchain.Classes
{

    // Класс для описания блока из блокчейна
    class Block
    {
        byte[]? prev_hash;
        byte[]? curr_hash;
        byte[]? info;

        public Block(byte[]? previos_block_hash, string message)
        {
            this.prev_hash = previos_block_hash;

            //Перевод сообщения в вид массива байтов
            info = null;


            // Рассчёт хэша по массиву байтов info
            curr_hash = null;

        }
    }
}
