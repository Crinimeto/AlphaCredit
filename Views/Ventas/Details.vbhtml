@ModelType AcreditPrueba.AcreditPrueba.Venta
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.IdVenta }) |
    @Html.ActionLink("Back to List", "Index")
</p>
