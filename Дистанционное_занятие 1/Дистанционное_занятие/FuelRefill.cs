using System;
namespace Дистанционное_занятие
{

    /// Струтура для информации о процедурах 
    /// заправления машин топливом на заправке
    public struct FuelRefill
    {
        public string carNumber;    ///номер машины
        public int liters;          ///Количество литров топлива
        public int cost;            ///Стоимость процедуры заправки
        public int refillTime;      ///Время заправки машины

        ///Создание консктруктора для структуры, 
        ///чтобы проще было заполнять данными
        public FuelRefill(string number, int liters, int cost, int time)
        {
            this.carNumber = number;
            this.liters = liters;
            this.cost = cost;
            this.refillTime = time;
        }

        /// Функция вывода инфомарции о процедуре заправки
        public void Show()
        {
            Console.WriteLine($"Машина: {carNumber} | " +
                              $"Количество литров: {liters} | " +
                              $"Стоимость: {cost} рублей | " +
                              $"Время заправки: {refillTime} мин");
        }
    }
}
