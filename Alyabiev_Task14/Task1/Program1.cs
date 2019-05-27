﻿/*
 * Реализовать **Windows Forms** приложение, позволяющее работать с *пользователями* и *наградами* (перечень атрибутов указаны ниже).
 * 
 * *********************************************************************************************************
 * 
 * Награды (например, «Нобелевская премия», «премия Дарвина»).
 * Атрибуты награды:
 * 
 * - ID — уникальный идентификатор, генерируемый приложением (int).
 * - Title — наименование (String) (обязательное, не более 50 символов).
 * - Description — описание (String) (необязательное, но не более 250 символов).
 * 
 * *********************************************************************************************************
 * 
 * Атрибуты пользователя:
 * 
 * - ID — уникальный идентификатор, генерируемый приложением (int).
 * - First Name — имя (String) (обязательное, не более 50 символов).
 * - Last Name — фамилия (String) (обязательное, не более 50 символов).
 * - Birthdate — дата рождения (DateTime) (обязательное, не может быть меньше текущей даты, не может быть более 150 лет).
 * - Age — возраст. Вычисляемое число полных лет (int).
 * 
 * *********************************************************************************************************
 * 
 * Рекомендуется использовать TabPanel для переключения между списком пользователей и наград.
 * 
 * Возможности, предоставляемые приложением:
 * 
 * - Просматривать список пользователей/наград и все их атрибуты. В качестве элемента отображения списка использовать GridView.
 * - Должна быть реализована возможность сортировки списка по выбранной колонке.
 * - Редактировать, создавать и удалять пользователей/награды.
 *   * Вызывается через главное меню и/или контекстное меню.
 *   * Создание и редактирование пользователя/награды должно быть реализовано через отдельную дочернюю форму.
 *   * При удалении должен выводиться диалог подтверждения.
 * 
 * - Реализовать возможность награждения пользователя наградами из числа имеющихся (при создании/редактировании пользователя).
 *   * Предусмотреть невозможность повторного награждения пользователя той же наградой.
 *   * В списке пользователей необходимо отображать имеющиеся у него награды.
 *   * При удалении награды из списка наград, она также должна удаляться у всех пользователей.
 * 
 * - Все сущности должны находиться в валидном состоянии.
 * - Реализовать хранение данных в памяти процесса на время выполнения программы (класс List).
 *   Сохранение данных в файлах или базе данных реализовывать пока не требуется.
 *   
 * *********************************************************************************************************
 */

using System;
using System.Windows.Forms;

namespace Alyabiev.Task14.Task1
{
	static class Program1
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}