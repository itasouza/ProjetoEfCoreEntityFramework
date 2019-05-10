function addClasses() {
    $(".bg-light").each(function () {
        var scre = $("body").width();
        if (scre <= 768) {
            $("#btnGravar").addClass("btn-block");
        } else {
            $("#btnGravar").removeClass("btn-block");
        }

    });
}

$(document).ready(function () {
    // Adicionar classes ao carregar o documento
    addClasses();

    $(window).resize(function () {
        // Adicionar sempre que a tela for redimensionada
        addClasses();
    });
});