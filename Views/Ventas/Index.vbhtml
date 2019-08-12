@ModelType IEnumerable(Of AcreditPrueba.AcreditPrueba.Venta)
@Code
    ViewData("Title") = "Ventas"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Fecha)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Consecutivo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Persona.Documento)
        </th>

        <th>
            @Html.DisplayNameFor(Function(model) model.Persona.Nombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Vehiculo.Placa)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Vehiculo.Marca)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Vehiculo.Precio)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Valor)
        </th>


        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Fecha)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Consecutivo)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Persona.Documento)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Persona.Nombre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Vehiculo.Placa)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Vehiculo.Marca)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Vehiculo.Precio)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Valor)
        </td>

        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.IdVenta}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.IdVenta}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.IdVenta})
        </td>
    </tr>
Next

</table>
