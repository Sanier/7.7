using System;

namespace _7._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
        }

        abstract class Delivery
        {
            public string Address;
        }

        class HomeDelivery : Delivery               //Доставка на дом (ФИО, адрес, номер телефона, дата и примерное время)
        {                                           //Для компании: кому и куда(данные заказчика), номер заказа и какой КС(курьерской службой), дата доставки и выбор примерного времени доставки... дополнить по времени и возможности
            /* ... */
        }

        class PickPointDelivery : Delivery          //Пункт выдачи (Время прихода заказа, номер телефона и ФИО и адрес пункта выдачи (из списка по возможности))
        {                                           //Для компании: кому(данные заказчика), ПВ(пункт выдачи) (город, адрес из списка своего города), какой ТК, номер накладной, примерное время поступления
            /* ... */
        }

        class ShopDelivery : Delivery               //По типу пункта выдачи (ФИО, адрес магазина(находится ли он в ТЦ(добавить наименование ТЦ), либо же просто адрес), номер телефона)
        {                                           //Для компании: кому(данные заказчика), какой магазин (адрес и, если он в ТЦ - указать), есть ли в наличии(нет - дата привоза), номер заказа, время работы магазина
            /* ... */
        }

        class Order<TDelivery, TStruct> where TDelivery : Delivery
        {
            public TDelivery Delivery;

            public int Number;

            public string Description;

            public void DisplayAddress()
            {
                Console.WriteLine(Delivery.Address);
            }
        }

        static class Client                //Данные клиента(ФИО, нмоер телефона, адрес клиента)
        {
            static string Name = Console.ReadLine();       //ФИО
            static string City = Console.ReadLine();
            static string Adress = Console.ReadLine();


        }

        class ListPickPointDelivery : PickPointDelivery         //список пунктов выдачи
        {

        }

        class ListShopDelivery : ShopDelivery                   //список магазинов + проверка на ТЦ
        {

        }

        class NumberDelivery                    //номер заказа (присваивается рандомно)
        {

        }
    }
}
