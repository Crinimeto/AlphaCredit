@ModelType AcreditPrueba.AcreditPrueba.Venta
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Venta</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Fecha)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Fecha)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Consecutivo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Consecutivo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Valor)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Valor)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Persona.Nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Persona.Nombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Vehiculo.Placa)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Vehiculo.Placa)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
