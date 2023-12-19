function defaultToEnglish()
{
    $("#ukFlag").show();
    $("#franceFlag").hide();
    $("#germanyFlag").hide();
    $("#ukraineFlag").hide();

    $(".english").show();
    $(".french").hide();
    $(".german").hide();
    $(".ukranian").hide();
}

$(document).ready(function () {

    defaultToEnglish();
    $("#languageSelector").on("change", function () {

        $(".french").removeAttr("hidden");
        $(".german").removeAttr("hidden");
        $(".ukranian").removeAttr("hidden");

        switch ($("#languageSelector").val()) {

            case "english":
                $("#ukFlag").show();
                $("#franceFlag").hide();
                $("#germanyFlag").hide();
                $("#ukraineFlag").hide();

                $(".english").show();
                $(".french").hide();
                $(".german").hide();
                $(".ukranian").hide();
                break;

            case "french":
                $("#ukFlag").hide();
                $("#franceFlag").show();
                $("#germanyFlag").hide();
                $("#ukraineFlag").hide();

                $(".english").hide();
                $(".french").show();
                $(".german").hide();
                $(".ukranian").hide();
                break;

            case "german":
                $("#ukFlag").hide();
                $("#franceFlag").hide();
                $("#germanyFlag").show();
                $("#ukraineFlag").hide();

                $(".english").hide();
                $(".french").hide();
                $(".german").show();
                $(".ukranian").hide();
                break;

            case "ukraine":
                $("#ukFlag").hide();
                $("#franceFlag").hide();
                $("#germanyFlag").hide();
                $("#ukraineFlag").show();

                $(".english").hide();
                $(".french").hide();
                $(".german").hide();
                $(".ukranian").show();
                break;

            default:
                break;
        }
    });
});