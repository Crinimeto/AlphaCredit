@ModelType IEnumerable(Of AcreditPrueba.AcreditPrueba.Vehiculo)
@Code
    ViewData("Title") = "Vehículos"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Placa)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Marca)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Linea)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Color)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Modelo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Tipo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Precio)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Placa)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Marca)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Linea)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Color)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Modelo)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Tipo)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Precio)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.IdVehiculo }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.IdVehiculo }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.IdVehiculo })
        </td>
    </tr>
Next

</table>
