
const previewImage = (event) => {
    const imageFiles = event.target.files;
    const imageFilesLength = imageFiles.length;
    if (imageFilesLength > 0) {
        const imageSrc = URL.createObjectURL(imageFiles[0]);
        const imagePreviewElement = document.getElementById("ImgSelected");
        imagePreviewElement.src = imageSrc;
    }
};

function changeElems() {
    var selectP = document.getElementById("categoria");
    var selectS = document.getElementById("subcategoria");
    $("#subcategoria").empty();
    selectS.options.add(new Option("Subcategoria", "", false, true));
    selectS.options[0].disabled = true;
    if (selectP.value == "Alimentos") {
        selectS.options.add(new Option("Tacos", "Tacos"));
        selectS.options.add(new Option("Sopas", "Sopas"));
        selectS.options.add(new Option("Ensaladas", "Ensaladas"));
        selectS.options.add(new Option("Frutas", "Frutas"));
        selectS.options.add(new Option("Carnes", "Carnes"));
        selectS.options.add(new Option("Hot-Dogs", "Hot-Dogs"));
        selectS.options.add(new Option("Pizzas", "Pizzas"));
        selectS.options.add(new Option("Hamburguesas", "Hamburguesas"));
        selectS.options.add(new Option("Empanadas", "Empanadas"));
        selectS.options.add(new Option("Mariscos", "Mariscos"));
    } else if (selectP.value == "Bebidas") {
        selectS.options.add(new Option("Refrescos", "Refrescos"));
        selectS.options.add(new Option("Aguas", "Aguas"));
        selectS.options.add(new Option("Jugos", "Jugos"));
        selectS.options.add(new Option("Cervezas", "Cervezas"));
        selectS.options.add(new Option("Energeticas", "Energeticas"));
        selectS.options.add(new Option("Licuados", "Licuados"));
        selectS.options.add(new Option("Calientes", "Calientes"));
    } else {
        selectS.options.add(new Option("Pasteles", "Pasteles"));
        selectS.options.add(new Option("Helados", "Helados"));
        selectS.options.add(new Option("Pan", "Pan"));
    }
}