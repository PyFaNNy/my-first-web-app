# my-first-web-app
Azure - https://webapplication120201218142347.azurewebsites.net/Users


Задание №4 (после 1/2/3): на платформе своей специализации (.NET/C#/Core/ASP.NET в любом реинкарнации/EntityFramework/SQL Server | JavaScript/React/Node.js/Express/MySQL | Java/Spring/Hibernate/MySQL; iOS — на выбор, что-то из указанного выше) реализовать Web-приложение, которое позволяет пользователям зарегистрироваться и аутентифицироваться. Неаутентифицированные пользователи не имеют доступа к управлению пользователями (могут достучаться только к форме регистрации или форме аутентификации).

Аутентифицированные пользователи видят таблицу (таблица с идентификатором, именем, мылом, датой регистрации, датой последнего логина, статусом) с пользователями. Таблица левой колонкой содержит чек-боксы для множественного выделения, в заголовке колонки чек-бокс "выделить все/снять выделение". Над таблицей тулбар с действиями: Block, Unblock, Delete (два последних можно и лучше иконками). Пользователь может удалить или заблокировать себя — при этом сразу должен быть разлогинен. Если кто-то другой блокирует или удаляет пользователя, то при любом следующем действии пользователь переправляется на страницу логина.

Таблица, множественное выделение, тулбар — обязательно.

Обязательно использование CSS-фреймворка (рекомендация — Bootstrap, но он не обязателен, можно любой другой).

При регистрации должна быть возможность использовать любой пароль, даже из одного символа.
