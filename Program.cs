﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newston.Js;

namespace JURNAL_MOD8_1302213091_AFF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = BankTransferConfig.LoadConfig();

            if (config.lang == "en")
            {
                Console.WriteLine("Please insert the amount of money to transfer:");
            }
            else if (config.lang == "id")
            {
                Console.WriteLine("Masukkan jumlah uang yang akan di-transfer:");
            }

            var transferAmount = double.Parse(Console.ReadLine());
            double transferFee = transferAmount <= config.threshold ? config.low_fee : config.high_fee;
            double totalAmount = transferAmount + transferFee;

            if (config.lang == "en")
            {
                Console.WriteLine($"Transfer fee = {transferFee}");
                Console.WriteLine($"Total amount = {totalAmount}");
                Console.WriteLine("Select transfer method:");
            }
            else if (config.lang == "id")
            {
                Console.WriteLine($"Biaya Transfer = {transferFee}");
                Console.WriteLine($"Total biaya = {totalAmount}");
                Console.WriteLine("Pilih metode transfer:");
            }

            for (int i = 0; i < config.methods.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {config.methods[i]}");
            }

            if (config.lang == "en")
            {
                Console.WriteLine($"Please type \"{config.confirmation}\" to confirm the transaction:");
            }
            else if (config.lang == "id")
            {
                Console.WriteLine($"Ketik \"{config.konfirmasi}\" untuk mengkonfirmasi transaksi:");
            }

            var confirmation = Console.ReadLine();

            if (config.lang == "en" && confirmation == config.confirmation)
            {
                Console.WriteLine("The transfer is completed");
            }
            else if (config.lang == "id" && confirmation == config.konfirmasi)
            {
                Console.WriteLine("Proses transfer berhasil");
            }
            else
            {
                if (config.lang == "en")
                {
                    Console.WriteLine("Transfer is cancelled");
                }
                else if (config.lang == "id")
                {
                    Console.WriteLine("Transfer dibatalkan");
                }
            }
        }
    }
}
