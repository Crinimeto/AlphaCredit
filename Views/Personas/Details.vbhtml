@ModelType AcreditPrueba.AcreditPrueba.Persona
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Persona</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Nombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Apellido)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Apellido)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Documento)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Documento)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.IdPersona }) |
    @Html.ActionLink("Back to List", "Index")
</p>
