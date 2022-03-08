using System;
using System.Collections.Generic;
using System.Collections;

namespace Console_Kofana_Odev_3
{
    //Müşteri nesnesinin oluşturulması
    class Customer
    {
        string tcNo;
        string name;
        string surname;
        string tel;
        string product;
        int quantity;
        string total;

        public string TcNo { get => tcNo; set => tcNo = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Product { get => product; set => product = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Total { get => total; set => total = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            //Tüm Müşterileri verilerinin saklanacağı liste
            Customer[] lst = new Customer[] { };

            string[] products = {"Telefon","Tablet","Laptop"};

            //Müşteri nesnesi
            Customer customer = new Customer();
            customer.Name = "Aykut";
            customer.Surname = "Atmaca";
            customer.TcNo = "12312312312";
            customer.Tel = "0511 111 11 11";
            customer.Product = "Tablet";
            customer.Quantity = 1;
            customer.Total = "8000 ₺";

            //Kullanıcı Girişi
            Console.Write("Lütfen Tc No Giriniz:");
            string tc = Console.ReadLine();

            for (int i = 0; i < lst.Length; i++)
            {
                if (lst[i].TcNo==tc)  //Müşteri kayıtlıysa
                {
                    Console.WriteLine("Kullanıcı girişi başarılı, Lütfen ürün ve adet seçiniz");
                    Console.Write("Ürünler: 1-)Telefon  4000 ₺ \n 2-)Tablet  8000 ₺ \n 3-)Laptop  12000₺");
                    int prdct =Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Adet seçiniz:");
                    int qt = Convert.ToInt32(Console.ReadLine());
                    string total = "";
                    if (prdct==1)
                    {
                        total=(qt*4000)+ "₺";
                    }
                    else if (prdct == 2)
                    {
                        total = (qt * 8000) + "₺";
                    }
                    else if (prdct == 3)
                    {
                        total = (qt * 12000) + "₺";
                    }
                    lst[i].Product = prdct.ToString();
                    lst[i].Quantity = qt;
                    lst[i].Total = total;

                    Console.WriteLine($"Sipariş Özetiniz: \n Ad:{lst[i].Name} \n Soyad:{lst[i].Surname} \n TC:{lst[i].TcNo} \n Telefon:{lst[i].Tel} \n Ürün:{lst[i].Product} \n Adet:{lst[i].Quantity} \n Toplam Tutar:{lst[i].Total}");
                }
                else
                {
                    Customer cust = new Customer();
                    Console.WriteLine("Yeni Üye Kayıt Sayfası".ToUpper());
                    
                    Console.Write("Lütfen Adınızı Giriniz:");
                    cust.Name=Console.ReadLine();

                    Console.Write("Lütfen Soyadınızı Giriniz:");
                    cust.Surname = Console.ReadLine();

                    Console.Write("Lütfen TC No Giriniz:");
                    cust.TcNo = Console.ReadLine();

                    Console.Write("Lütfen Telefon Numaranızı Giriniz:");
                    cust.Tel = Console.ReadLine();

                    lst[lst.Length] = cust;
                }
            }

            for (int i = 0; i < lst.Length; i++)
            {
                Console.WriteLine(lst[i].Name);
            }


            

           


            
        }
    }
}
