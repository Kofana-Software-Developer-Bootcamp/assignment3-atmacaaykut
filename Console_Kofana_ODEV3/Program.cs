using System;
using System.Collections.Generic;
using System.Data;

namespace Console_Kofana_ODEV3
{
    class Program
    {
        //Müşteri Nesnesinin oluşturulması
        public class Customer
        {
            string tc, name, product, total;

            public string Tc { get => tc; set => tc = value; }
            public string Name { get => name; set => name = value; }
            public string Product { get => product; set => product = value; }
            public string Total { get => total; set => total = value; }
        }

        static void Main(string[] args)
        {

            Customer cst = new Customer();


            //Müşteri kayıtlarının tutulacağı listenin oluşturulması

            List<Customer> lst = new List<Customer>();

            //Senaryo kontrolü için örnek kayıtların eklenmesi

            cst.Name = "Aykut Atmaca";
            cst.Tc = "1";
            cst.Product = "Tablet";
            cst.Total = "6000";

            lst.Add(cst);

            Customer cst1 = new Customer();
            cst1.Name = "Ali Yılmaz";
            cst1.Tc = "2";
            cst1.Product = "Laptop";
            cst1.Total = "15000";
            lst.Add(cst1);

            //Üye kontrol ve uygulama sonlandırma değişkenleri
            bool exit = true;
            bool isMember=true;

            
            while (exit == true)
            {

                Console.WriteLine("Hoşgeldiniz \nLütfen TC kimlik numaranız ile giriş yapınız:");
                string tc = Console.ReadLine();

                //Üye kaydı sorgulaması
                for (int i = 0; i < lst.Count; i++)
                {
                    //Üye kaydı varsa alışveriş yapar
                    if (lst[i].Tc == tc)
                    {
                        Console.WriteLine($"Hoşgeldin {lst[i].Name} \nÜrün Listesi: \n1-)Laptop  15000 TL \n2-)Tablet  9000 TL \n3-)Telefon  6000 TL");
                        string decision = Console.ReadLine();
                        if (decision == "1")
                        {
                            lst[i].Product = "Laptop";
                            lst[i].Total = "15000 TL";
                        }
                        else if (decision == "2")
                        {
                            lst[i].Product = "Tablet";
                            lst[i].Total = "9000 TL";
                        }
                        else if (decision == "3")
                        {
                            lst[i].Product = "Telefon";
                            lst[i].Total = "6000 TL";
                        }
                        Console.WriteLine($"Bizi tercih ettiğiniz için teşekkür ederiz.\nSipariş Özetiniz:\nMüşteri Adı:{lst[i].Name}\nTc No:{lst[i].Tc}\nAlınan Ürün:{lst[i].Product}\nToplam Tutar:{lst[i].Total}");

                        Console.WriteLine("Çıkış için 2'ye basınız");
                        string escape = Console.ReadLine();
                        if (escape == "2")
                        {
                            exit = false;
                            
                            
                        }
                         isMember = false;
                    }
                    if (isMember==false)
                    {
                        exit = false;
                    }

                }

                //Uygulamadan çıkış
                if (exit==false)
                {
                    break;
                }
                else
                {
                    //Yeni üye kaydı

                    Console.WriteLine("Hoşgeldin misafir, alışveriş yapmak için kayıt olmalısın. Kayıt olmak için 1'e basınız.");
                    string ok = Console.ReadLine();
                    if (ok == "1")
                    {
                        Customer cst2 = new Customer();
                        Console.WriteLine("TC No:");
                        cst2.Tc = Console.ReadLine();
                        Console.WriteLine("Ad Soyad:");
                        cst2.Name = Console.ReadLine();
                        cst2.Product = "";
                        cst2.Total = "";
                        lst.Add(cst2);
                        tc = cst2.Tc;
                    }
                }

            }
        }
    }
}
