const subCats = @Html.Raw(Json.Serialize(ViewBag.SubCategorias));


function changeSubCatsElems() {
    var selectP = document.getElementById("categoria");
    var selectS = document.getElementById("subcategoria");
    selectS.removeAttribute("disabled");
    $("#subcategoria").empty();
    selectS.options.add(new Option("Subcategoria", "", false, true));
    selectS.options[0].disabled = true;
    for (var e in subCats) {
        if (subCats[e].categorias_Id.id == selectP.value) {
            selectS.options.add(new Option(subCats[e].nombre, subCats[e].id));
        }
    }
}