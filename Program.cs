/*
 * Создано в SharpDevelop.
 * Пользователь: Артём
 * Дата: 27.09.2018
 * Время: 19:16
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;

namespace lab1nom5
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			// TODO: Implement Functionality Here
			Console.WriteLine("Введите номер месяца от 1 до 12");
			int x=int.Parse(Console.ReadLine());
			if (x>=3&&x<=5)
				Console.WriteLine("Весна");
else
	if (x>=6&&x<=8)
		Console.WriteLine("Лето");
else
	if (x>=9&&x<=11
	   )Console.WriteLine("Осень");
else
if (x==12||x<=2)
		Console.WriteLine("Зима");
Console.ReadKey();
			
			
			
		}
	}
}