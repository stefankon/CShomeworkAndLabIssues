using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06.OrderedBankingSystem
{
    class OrderedBankingSystem
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var data = new Dictionary<string, Dictionary<string, decimal>>();

            while (input != "end")
            {
                BankData bank = InputLine(input);

                if (!data.ContainsKey(bank.Bank))
                {
                    data.Add(bank.Bank, new Dictionary<string, decimal>());
                }

                if (!data[bank.Bank].ContainsKey(bank.Account))
                {
                    data[bank.Bank].Add(bank.Account, 0);
                }

                data[bank.Bank][bank.Account] += bank.Balance;
                
                input = Console.ReadLine();
            }

            var orderdedData = data
                               .OrderByDescending(bank => bank.Value.Sum(balance => balance.Value))
                               .ThenByDescending(bank => bank.Value.Max(balance => balance.Value));

            foreach (var bank in orderdedData)
            {
                string currBank = bank.Key;
                Dictionary<string, decimal> bankData = bank.Value;
                var orderedBankData = bankData
                                      .OrderByDescending(balance => balance.Value);

                foreach (var balanceData in orderedBankData)
                {
                    string currAccount = balanceData.Key;
                    decimal currBalance = balanceData.Value;

                    Console.WriteLine($"{currAccount} -> {currBalance} ({currBank})");
                }

            }
        }

        private static BankData InputLine(string input)
        {
            string[] tokens = input
                                    .Split(new string[] { " -> " },
                                        StringSplitOptions.RemoveEmptyEntries)
                                            .ToArray();

            string bank = tokens[0];
            string account = tokens[1];
            decimal balance = decimal.Parse(tokens[2]);

            return new BankData(bank, account, balance);
        }
    }

    class BankData
    {
        public string Bank { get; set; }
        public string Account { get; set; }
        public decimal Balance { get; set; }

        public BankData(string bank, string account, decimal balance)
        {
            this.Bank = bank;
            this.Account = account;
            this.Balance = balance;
        }
    }
}
