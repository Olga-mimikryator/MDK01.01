using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace LR3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            List<Food> foods = new List<Food>();
            foods.Add(new Food("Батон \"Как у бабули\"", 19, "YamyFoodCorporation", "ООО \"Хлебобулочное в ваш дом\"", "02.02.2026", "", "Хлебобулочные изделия"));
            foods.Add(new Food("Яблочный штрудель \"Пальчики оближешь\"", 25, "YamyFoodCorporation", "АО \"Хлеб всему голова\"", "04.02.2026", "", "Хлебобулочные изделия"));
            foods.Add(new Food("Шоколад \"Аленка\"", 200, "Объединение кондитеров", "ООО \"Красный октябрь\"", "02.02.2026", "", "Кондитерские изделия"));
            foods.Add(new Food("Рис \"Фром жапан\"", 50, "ZernoNaPoklev", "АО \"Зерно - это круто\"", "20.02.2026", "", "Крупы и злаки"));

        }
    }
}
