using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_6_task_2
{
    public class Store
    {
        private int stock;

        public Store(int initialStock)
        {
            stock = initialStock;
        }

        public void ProcessSale()
        {
            Console.WriteLine($"Поточний залишок товару на складі: {stock} шт.");

            try
            {
                Console.Write("Введіть кількість товарів для продажу: ");

                if (!int.TryParse(Console.ReadLine(), out int amountToSell))
                {
                    Console.WriteLine("Помилка: будь ласка, введіть ціле число.");
                    return;
                }

                if (amountToSell < 0)
                {
                    Console.WriteLine("Помилка: кількість не може бути від'ємною.");
                    return;
                }

                if (amountToSell > stock)
                {
                    throw new InsufficientStockException(
                        $"Помилка: недостатньо товару! Залишок на складі: {stock}, а ви намагаєтеся продати: {amountToSell}."
                    );
                }

                stock -= amountToSell;
                Console.WriteLine($"Продаж успішний! Залишок на складі: {stock} шт.");
            }
            catch (InsufficientStockException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
