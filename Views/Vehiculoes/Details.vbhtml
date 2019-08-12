@ModelType AcreditPrueba.AcreditPrueba.Vehiculo
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Vehiculo</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Placa)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Placa)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Marca)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Marca)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Linea)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Linea)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Color)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Color)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Modelo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Modelo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Tipo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Tipo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Precio)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Precio)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.IdVehiculo }) |
    @Html.ActionLink("Back to List", "Index")
</p>
