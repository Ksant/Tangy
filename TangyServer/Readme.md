Programm.cs
1. Регистрация сервисов.
2. Конфигурация pipline

app.MapFallbackToPage("/_Host");
app.Run();
Устанавливается запускаемый файл _host. Находящийся в Pages
@{
    Layout = "_Layout";
}
<component type="typeof(App)" render-mode="ServerPrerendered"/>
В нем устанавливается дефолтный layout.
Запукается компонент app в режиме ServerPrerendered

Компонент app содержит компонент Routing
1. Первый компонент отрабатывает если маршрут найден.
2. Второй, если маршрут не нейден.
В обоих случаях прописывается компонент Layout - DefaultLayout="@typeof(MainLayout)"

Дефолтный маршрут по умолчанию пропиан в компоненте index.razor


Кроме того.
appsetting.json includes settings. ConnectionStrings and e.t.c.
_Imports.razor inclides using for all project files.
_Layout.cshtml include css and js references

Итого
Programm.cs -> _Host.cshtml -> App.razor -> _Layout.cshtml -> MainLayout.razor -> Index.razor


WebAssembly
Programm.cs -> Index.html -> App.razor -> MainLayout.razor -> Index.razor
