using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBank
{
    public class Commands
    {
        public static Dictionary<string, Action> commandsList = new Dictionary<string, Action>();

        private static void addAccount()
        {
            Console.WriteLine("Owner: ");
            string owner = Console.ReadLine();
            Console.WriteLine("Balance: ");
            string balance = Console.ReadLine();

            Account acc = new Account();
            acc.id = 0;
            acc.owner = owner;
            acc.balance = Convert.ToDouble(balance);

            AccountManager.add(acc);

            Console.WriteLine($"Account to {owner.ToUpper()} addeded successfully!");
        }
        private static void listAccounts()
        {
            AccountManager.listAccounts();
        }
        private static void listTransfers()
        {
            TransferManager.listTransfers();
        }
        private static void transferTo()
        {
            Console.WriteLine("Transfer to account id: ");
            int toId = int.Parse(Console.ReadLine());
            Console.WriteLine("Transfer from account id: ");
            int fromId = int.Parse(Console.ReadLine());
            Console.WriteLine("Value: ");
            double value = Convert.ToDouble(Console.ReadLine());

            if (AccountManager.isValid(toId) && AccountManager.isValid(fromId))
            {
                Transfer tr = new Transfer();
                tr.id = 0;
                tr.from = fromId;
                tr.to = toId;
                tr.balance = value;
                TransferManager.Transfer(tr);
            }
            else
            {
                Console.WriteLine("Verify accounts id's!");
            }
        }

        public static void registerCommands()
        {
            commandsList.Add("1", addAccount);
            commandsList.Add("2", listAccounts);
            commandsList.Add("3", listTransfers);
            commandsList.Add("4", transferTo);
        }

    }
}
