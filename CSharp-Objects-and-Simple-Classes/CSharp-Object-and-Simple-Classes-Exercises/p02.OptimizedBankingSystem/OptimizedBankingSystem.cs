using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02.OptimizedBankingSystem
{
    class OptimizedBankingSystem
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<BankAccount> data = new List<BankAccount>();

            while (input != "end")
            {
                string[] token = input
                                 .Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries)
                                 .ToArray();
                string bank = token[0];
                string name = token[1];
                decimal balance = decimal.Parse(token[2]);

                data.Add(new BankAccount(name, bank, balance));
                input = Console.ReadLine();
            }
            var sortedData = data
                            .OrderByDescending(x => x.Balance)
                            .ThenBy(x => x.Bank.Length)
                            .ToList();

            foreach (var acc in sortedData)
            {
                var currName = acc.Name;
                var currAccount = acc.Balance;
                var currBank = acc.Bank;

                Console.WriteLine($"{currName} -> {currAccount} ({currBank})");
            }
        }

    }
    class BankAccount
    {
        public string Name { get; set; }
        public string Bank { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string name, string bank, decimal balance)
        {
            this.Name = name;
            this.Bank = bank;
            this.Balance = balance;
        }
    }
}
