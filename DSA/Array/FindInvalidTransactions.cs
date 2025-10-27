using System;
using System.Collections.Generic;

namespace DSA.Array
{
    public class FindInvalidTransactions
    {
        public void Start()
        {
            InvalidTransactions(["alex,676,260,bangkok", "bob,656,1366,bangkok", "alex,393,616,bangkok", "bob,820,990,amsterdam", "alex,596,1390,amsterdam"]);
        }

        public IList<string> InvalidTransactions(string[] transactions)
        {
            List<string> ans = new List<string>();
            bool[] invalidT = new bool[transactions.Length];
            Dictionary<string, List<Transaction>> d = new();

            for (int i = 0; i < transactions.Length; i++)
            {
                Transaction tr = new Transaction(transactions[i]);
                tr.id = i;
                if (tr.amount > 1000)
                    invalidT[i] = true;

                if (d.ContainsKey(tr.name))
                {
                    var dts = d[tr.name];
                    for (int j = 0; j < dts.Count; j++)
                    {
                        Transaction tr2 = dts[j];
                        if (Math.Abs(tr2.time - tr.time) <= 60 && tr.city != tr2.city)
                        {
                            invalidT[i] = true;
                            invalidT[tr2.id] = true;
                        }
                    }
                    d[tr.name].Add(tr);
                }
                else
                    d[tr.name] = new List<Transaction>() { tr };


            }
            for (int i = 0; i < transactions.Length; i++)
            {
                if (invalidT[i])
                    ans.Add(transactions[i]);
            }

            return ans;
        }
    }
    public class Transaction{
    public string name;
    public int time;  
    public int amount;
    public string city;
    public int id;
    public Transaction(string transaction){
        string[] t = transaction.Split(",");
        
        name = t[0];
        time = int.Parse(t[1]);
        amount = int.Parse(t[2]);
        city = t[3];
    }
}
}
