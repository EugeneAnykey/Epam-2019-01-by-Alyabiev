﻿/* Занятие 10
 * Задание 2
 * Написать программу, описывающую небольшой офис, в котором работают сотрудники – объекты 
 *  класса *Person*, обладающие полем имя (*Name*). Каждый из сотрудников содержит пару методов:
 *  
 *  1. приветствие сотрудника, пришедшего на работу (принимает в качестве аргументов объект сотрудника
 *   и время его прихода). В зависимости от времени суток, приветствие может быть различным:
 *   до 12 часов – «Доброе утро», с 12 до 17 – «Добрый день», начиная с 17 часов – «Добрый вечер».
 *  2. прощание с ним (принимает только объект сотрудника).
 *  
 *  Каждый раз при входе очередного сотрудника в офис, все пришедшие ранее его приветствуют.
 *  При уходе сотрудника домой с ним также прощаются все присутствующие.
 *  Вызов процедуры приветствия/прощания производить через групповые делегаты.
 *  Факт прихода и ухода сотрудника отслеживается через генерируемые им события.
 *  Событие прихода описывается делегатом, передающим в числе параметров наследника *EventArgs*, явно содержащего поле с временем прихода.
 *  Продемонстрировать работу офиса при последовательном приходе и уходе сотрудников.
 */

using System;

namespace Alyabiev.Task10.Task2
{
	class Program1
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("[Task 10 - 2] Persons says Hi.\n");

			var os = new OfficeSimulation();

			os.Run();

			Console.Write("[!] finished.");
			Console.ReadKey(true);
		}
	}
}