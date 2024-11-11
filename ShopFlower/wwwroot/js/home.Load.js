document.addEventListener("DOMContentLoaded", function () {
    // Получаем элемент, на который нужно кликнуть
    var aboutLink = document.getElementById("About");

    aboutLink.addEventListener("click", function (event) {
        event.preventDefault();  // Предотвращаем переход по ссылке

        // Создаем новый объект XMLHttpRequest для Ajax-запроса
        var xhr = new XMLHttpRequest();

        // Открываем GET-запрос, URL для которого генерируется с помощью Razor-синтаксиса
        xhr.open('GET', '@Url.Action("Index", "About")', true);

        // Определяем, что делать при успешном ответе
        xhr.onload = function () {
            if (xhr.status === 200) {  // Если запрос успешен (HTTP статус 200)
                // Получаем ответ (HTML/данные) и вставляем в элемент с id="main"
                document.getElementById('main').innerHTML = xhr.responseText;
            } else {
                console.error('Ошибка запроса: ' + xhr.statusText);
            }
        };

        // Обработка ошибок (например, если запрос не был выполнен)
        xhr.onerror = function () {
            console.error("Ошибка запроса: " + xhr.statusText);
        };

        // Отправляем запрос
        xhr.send();
    });
});