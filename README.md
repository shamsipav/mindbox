## Ответы на вопросы

### Вопрос №1: Был ли у вас опыт веб-разработки? Приложите ссылку на репозиторий с вашим веб-проектом, если возможно.

Да, у меня был опыт веб-разработки, вот несколько моих проектов:

- [Получена государственная регистрация для ЭВМ]
**TeploPro** (https://github.com/shamsipav/teplopro) ‑ дипломный проект, разработка программного веб‑модуля расчетов показателей
теплового режима доменной печи при изменении её режимных и конструктивных параметров. Стек: ASP.NET Core MVC + Microsoft SQL Server (Entity Framework)
- **Akira** (https://github.com/shamsipav/akira-shamsi/tree/shamsi) ‑ дипломный проект, разработка системы управления взаимоотношениями с клиентами (CRM) для отдела продаж металлургического цеха. Стек: ASP.NET Core MVC + Microsoft SQL Server (Entity Framework) + jQuery
- **Карьера в Метавселенной** (https://metaverse‑career.ru/) ‑ реализация сайта для молодежной конференции в сфере IT на базе Уральского федерального университета. Стек: Svelte (SvelteKit)
- **Ключевая ставка** (https://econstaff.urfu.ru/) ‑ реализация сайта для дня открытых дверей Института экономики и управления УрФУ. Стек: Svelte (SvelteKit)
- **Разработка админ‑панели для сайта Эндаумент Фонда УрФУ** (https://endowment.urfu.ru/). Стек: Svelte (SvelteKit) + Node.js + PostgreSQL
- **Разработка админ‑панели для сайта приёмной кампании Института новых материалов и технологий УрФУ** (https://inmt-priem.urfu.ru/). Стек: Svelte (SvelteKit) + Node.js + PostgreSQL

### Вопрос №2: Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.

Выполнил следующие условия:

- [x] Юнит-тесты // Возник вопрос по поводу тестирования ArgumentException
- [x] Легкость добавления других фигур // Реализовал с помощью абстрактного класса Figure, от которого наследуются фигуры
- [ ] Вычисление площади фигуры без знания типа фигуры в compile-time
- [x] Проверку на то, является ли треугольник прямоугольным // Реализовал с помощью теоремы Пифагора

### Вопрос №3:
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

```
SELECT product.name AS ProductName, category.name AS CategoryName FROM Products product
LEFT JOIN ProductsCategories productCategory on productCategory.product_id = product.Id
LEFT JOIN Categories category on productCategory.category_id = category.Id
```

![image](https://user-images.githubusercontent.com/56552046/215501676-ee31c1cb-b2ae-497e-b4d4-1854da565642.png)

### Вопрос №4: Готовы ли выйти на фуллтайм (в офис/удаленно) в случае успешного завершения стажировки через 3-4 месяца?

Да, я готов выйти на фуллтайм (удаленно)
