## Programm.cs
1. Регистрация сервисов.
2. Конфигурация pipline
3. Устанавливается запускаемый файл _host. Находящийся в Pages
``` 
app.MapFallbackToPage("/_Host");
app.Run();
```


## _host
1. Устанавливается дефолтный layout.
2. Запукается компонент app в режиме ServerPrerendered
``` c
@{
    Layout = "_Layout";
}
<component type="typeof(App)" render-mode="ServerPrerendered"/>
```

## Компонент app
Cодержит компонент Routing
1. Первый компонент отрабатывает если маршрут найден.
2. Второй, если маршрут не нейден.
В обоих случаях прописывается компонент Layout - DefaultLayout="@typeof(MainLayout)"

## index.razor
В компоненте прописан дефолтный маршрут 
``` c
@page "/"
```
Соответственно он запускается первым.


## Другие файлы.
- appsetting.json includes settings. ConnectionStrings and e.t.c.
- _Imports.razor inclides using for all project files.
- _Layout.cshtml include css and js references

## Итого
1. Programm.cs -> регистрация и настройка сервисов. 
2. _Host.cshtml -> установка default _layout, component with routing and render-mode   
3. App.razor -> Содержит маршрты and mainLayout
4. _Layout.cshtml -> css and js links 
4. MainLayout.razor -> Layout
4. Index.razor -> default page


WebAssembly
Programm.cs -> Index.html -> App.razor -> MainLayout.razor -> Index.razor


# Binding
## One Way Binding
``` c
Id = @_product.Id <br/>
Name = @_product.Name <br/>

@code {

    readonly Product _product = new()
    {
        Id = 1,
        Name = "Product 2"
    };
}
```

## Two way binding
``` c
// One way binding with condition
This Product is: @(_product.Active?"Active":"InActive") <br/>
<br/>
// Two way binding
Price: <input type="number" @bind="@_product.Price" @bind:event="oninput"/>
<br/>
Active: <input type="checkbox" @bind="@_product.Active" @bind:event="oninput"/> 
<br />

@code {

    readonly Product _product = new()
    {
        Id = 1,
        Name = "Product 2",
        Active = true,
        Price = 12
    };

}
```