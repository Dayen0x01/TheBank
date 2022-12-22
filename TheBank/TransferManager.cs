using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TheBank
{
    public class TransferManager
    {
        private static List<Transfer> transferList = new List<Transfer>();

        private static void addTransfer(Transfer transfer)
        {
            int id = transferList.Count + 1;
            transfer.id = id;
            transferList.Add(transfer);
        }
        public static void Transfer(Transfer transfer)
        {
            addTransfer(transfer);

            int id = transfer.id, to = transfer.to, from = transfer.from;

            AccountManager.transfer(to, from, transfer.balance);
        }
        public static void listTransfers()
        {
            if (transferList.Count > 0)
            {
                foreach (Transfer tr in transferList)
                {
                    Console.WriteLine($"From: {tr.from}\n To: {tr.to}\nID: {tr.id}\nBalance: {tr.balance}\n");
                }
            }
            else
            {
                Console.WriteLine("0 transfers registered!");
            }
        }

    }
}
