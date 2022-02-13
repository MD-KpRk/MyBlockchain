using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyBlockchain.Classes
{

    // Класс для описания блока из блокчейна
    class Block
    {
        byte[]? prev_hash;
        byte[]? curr_hash;
        byte[]? data;

        public Block(byte[]? previos_block_hash, string message)
        {
            this.prev_hash = previos_block_hash;

            //Перевод сообщения в вид массива байтов
            this.SetDataMessage(message);

            // Рассчёт хэша по массиву байтов данных блока
            curr_hash = this.GetHash(data);
        }

        // Конструктор для инициализации генезис блока
        public Block(string message)
        {
            this.prev_hash = null;
            this.SetDataMessage(message);
            curr_hash = this.GetHash(data);
        }

        private void SetDataMessage(string str)
        {
            data = Encoding.ASCII.GetBytes(str);
        }

        public string GetMessage()
        {
            if (data == null) return string.Empty;
            return Encoding.ASCII.GetString(data);
        }

        public byte[]? GetHash() => curr_hash;

        private byte[]? GetHash(byte[]? src)
        {
            if(src == null) return null;
            using (SHA256 hash = SHA256.Create())
                return hash.ComputeHash(src);
        }

    }
}
