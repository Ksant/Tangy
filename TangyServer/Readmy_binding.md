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
