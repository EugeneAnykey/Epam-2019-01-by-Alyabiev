﻿# Занятие 05. Основы ООП

## Задания

## Задание 1

Написать класс **User**, описывающий человека (*Фамилия*, *Имя*, *Отчество*, *Дата рождения*, *Возраст*). Написать программу, демонстрирующую использование этого класса.

## Задание 2

Написать класс **Round**, задающий круг с указанными *координатами центра*, *радиусом*, а также свойствами, позволяющими узнать *длину описанной окружности* и *площадь круга*. Обеспечить нахождение объекта в заведомо корректном состоянии. Написать программу, демонстрирующую использование данного круга.

## Задание 3

Написать класс, описывающий треугольник со сторонами *a*, *b*, *c*, и методами, позволяющими осуществить расчёт его *площади* и *периметра*. Обеспечить нахождение объекта в заведомо корректном состоянии. Написать программу, демонстрирующую использование данного треугольника.

## Задание 4

Написать свой собственный класс **MyString**, описывающий строку как массив символов. Перегрузить для этого класса типовые операторы:

* [+] – добавляет строку в конец текущей
* [-] – удаляет подстроку из текущей строки
* [==] – сравнивает два объекта *MyString*
* метод *ToString*

Материалы:

* [Use Operator Overloading](https://msdn.microsoft.com/en-us/library/6fbs5e2h(v=vs.120).aspx)
* [.net perls — operator](http://www.dotnetperls.com/operator)


## Примечания

Для работы тестов необходимо использовать <nunit.framework.dll> и <nunit test adapter 2>.