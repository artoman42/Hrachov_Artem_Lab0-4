using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            Currency UAH = new Currency("UAH", 0.03125);
            Currency BTC = new Currency("BTC", 42440.49);
            Currency ETH = new Currency("ETH", 3150.12);
            Currency BNB = new Currency("BNB", 424.9);
            Currency SOL = new Currency("SOL", 108.82);
            Currency APE = new Currency("APE", 15.66);
            Currency ZIL = new Currency("ZIL", 0.125);
            List<Currency> Currency_list = new List<Currency>() {UAH, BTC , ETH, BNB, SOL, APE, ZIL };  
            Account UAH_account = new Account(UAH, 0, true);
            Account BTC_account = new Account(BTC, 0, false);
            Account ETH_account = new Account(ETH, 0, false);
            Account BNB_account = new Account(BNB, 0, false);
            Account SOL_account = new Account(SOL, 0, false);
            Account APE_account = new Account(APE, 0, false);
            Account ZIL_account = new Account(ZIL, 0, false);
            List<Account> list_account = new List<Account>() { UAH_account, BTC_account, ETH_account, BNB_account, SOL_account, APE_account, ZIL_account };
            Console.WriteLine("Список доступних валют:");
            Currency.Currency_write(Currency_list);
            
            while (true)
            {
                Console.WriteLine("Список доступних рахункiв та їх стан:");
                Account.AccountWrite(list_account);
                Console.WriteLine("0-вихiд, 1 назва_валюти - вiдкрити рахунок, якщо вiн буде вiдкритим, то стане зачиненим, 2 назва рахунку сума кiлькiсть днiв(дата) - поповнення, 3 0|1- сортування за зростанням|спаданням, 4 - обчислити вартiсть усього криптопортфелю, 5 рахунок дата - вивiд кiлькостi по датi за останнiх днiв");
                string input = Console.ReadLine();
                string[] buff = input.Split(" ");
                int operation = -1;
                try
                {
                    operation = Convert.ToInt32(buff[0]);

                }
                catch
                {
                    Console.WriteLine("Не правильнi данi");
                    continue;
                }
                if (operation == 0) Process.GetCurrentProcess().Kill();
                if (operation == 1) { 
                    for(int i = 0; i < list_account.Count; i++)
                    {
                        if (list_account[i].Type.Name == buff[1] && !list_account[i].Active)
                        {
                            list_account[i].Active = true;
                            break;
                        }else if (list_account[i].Type.Name == buff[1] && list_account[i].Active)
                        {
                            list_account[i].Active = false ;
                            list_account[i].Amount = 0;
                            
                            break;
                        }
                    }
                }
                if (operation == 2)
                {
                    double summ = 0; int days = 0;
                    
                    try
                    {

                        summ = Convert.ToInt32(buff[2]);
                        days = Convert.ToInt32(buff[3]);
                    }
                    catch
                    {
                        Console.WriteLine("Не правильнi данi");
                        continue;
                    }
                    Payment payment =  new Payment(summ, UAH, days);
                    foreach (Currency ob in Currency_list)
                    {
                        if (ob.Name == buff[1])
                        {
                           
                            payment.Sum = summ;
                            payment._Currency = ob;
                            payment.Days = days;                               
                            break;
                        }
                    }
                    for(int i = 0; i < list_account.Count; i++)
                    {
                        if(buff[1] == list_account[i].Type.Name)
                        {
                            if(list_account[i].Active)
                            {
                                list_account[i].RecievePayment(payment);
                                list_account[i].CalcAmount();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Рахунок закритий!");
                            }
                        }
                    }
                }
                if(operation == 3)
                {
                    if(Convert.ToInt32(buff[1]) == 0) list_account.Sort(new AccountComparerIncrease());
                    else if (Convert.ToInt32(buff[1]) == 1) list_account.Sort(new AccountComparerDecrease());
                    else Console.WriteLine("Не коректно!");
                }
                if(operation == 4)
                {
                    Console.WriteLine(Account.FullCryptoCalc(list_account));
                }
                if (operation == 5)
                {
                    foreach(Account ob in list_account)
                    {
                        if(buff[1] == ob.Type.Name)
                        {
                            List<Payment> pay_list_copy = new List<Payment>(ob.GetPay());
                            // pay_list_copy.AddRange(ob.GetPay());
                            pay_list_copy.Sort(new PaymentComparer());
                            int data = 0;
                            try
                            {
                                data = Convert.ToInt32(buff[2]);
                            }
                            catch
                            {
                                Console.WriteLine("Не правильнi данi");
                                continue;
                            }
                            int now = pay_list_copy[0].Days;
                            double res = 0;
                            foreach(Payment pay in pay_list_copy)
                            {
                                if(now - pay.Days + 1<= data)
                                {
                                    res += pay.Sum;
                                }
                            }
                            Console.WriteLine(res);
                            break;
                        }
                    }
                }
            }
        }
       


    }
}
