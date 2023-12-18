$(document).ready(function () {
    $("#btnThemeSwtich").click(function () {
        if (document.body.classList.contains('dark')) {
            document.body.classList.remove('dark');
        } else {
            document.body.classList.add('dark');
        }
        $("#darkTheme").innerText = document.body.classList;
    });
});