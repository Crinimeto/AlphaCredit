@ModelType IEnumerable(Of AcreditPrueba.AcreditPrueba.Persona)
@Code
    ViewData("Title") = "Clientes"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Nombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Apellido)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Documento)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Nombre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Apellido)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Documento)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.IdPersona }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.IdPersona }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.IdPersona })
        </td>
    </tr>
Next

</table>
