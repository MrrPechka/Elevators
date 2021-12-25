Основные требования к приложению

Имеется n-этажное здание (не более 20) с количеством лифтов не более 5. На каждом этаже имеется пульт вызова лифта с количеством кнопок, равным количеству этажей (либо 10 кнопок с возможностью набора двузначных чисел). Единственная кнопка в лифте – «Ход», которая и инициирует движение лифта. Каждый лифт имеет свою максимальную вместимость (в количестве человек), максимальную скорость и максимальное ускорение. В приложении должны быть реализованы функции старта, паузы, остановки работы системы, ускорения симуляции, замедления симуляции. Остановить систему можно только в том случае, если все лифты пустые и остановлены.
Необходимая функциональность:

Система должна предоставлять статус каждого человека – “ожидает лифт столько-то секунд”, “движется на этаж N”, “доставлен на целевой этаж”. После создания объект “человек” должен нажать набрать на пульте вызова лифта свой этаж назначения этаже в течение 3 секунд. После доставки на целевой этаж объект человек должен существовать в системе еще 3 секунды. После остановки системы приложение должно выводить на экран (с возможностью экспорта в файл):

• Общее количество поездок (под одной поездкой понимается изменение направления движения) каждого лифта

• Процент “холостых” поездок (когда лифт пустой) для каждого лифта

• Количество перевезённых людей каждым лифтом

• Общее количество поездок

• Общее количество перевезённых людей каждым лифтом

• Среднее, наибольшее и суммарное время ожидания лифтов человеками

• Количество пожарных тревог и их сумарная длительность

В строке статуса приложения (Status bar) должно отображаться время, прошедшее с начала старта системы и количество перевезённых лифтами человек за весь сеанс работы.
![изображение](https://user-images.githubusercontent.com/71975109/147378721-212adef1-e71c-4f08-a85f-c5c0c87b8186.png)
![изображение](https://user-images.githubusercontent.com/71975109/147379903-f5dcae1e-6728-4d20-a740-d2fe060f76e0.png)
