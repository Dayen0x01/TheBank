using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBank
{
    public class AccountManager
    {
        private static List<Account> accounts = new List<Account>();

        public static void add(Account acc)
        {
            int id = accounts.Count + 1;
            acc.id = id;
            accounts.Add(acc);
        }

        public static bool isValid(int id)
        {
            bool exist = accounts.FindIndex(c => c.id == id) == -1 ? false : true;
            return exist;
        }

        public static void transfer(int to, int from, double value)
        {
            var indexTo = accounts.FindIndex(c => c.id == to);
            var indexFrom = accounts.FindIndex(c => c.id == from);
            accounts[indexTo].balance += value;
            accounts[indexFrom].balance -= value;
        }
        public static void listAccounts()
        {
            if (accounts.Count > 0)
            {
                foreach (Account acc in accounts)
                {
                    Console.WriteLine($"== {acc.owner} ==\nID: {acc.id}\nBalance: {acc.balance}\n");
                }
            }
            else
            {
                Console.WriteLine("0 accounts registered!");
            }
        }
    }
}
