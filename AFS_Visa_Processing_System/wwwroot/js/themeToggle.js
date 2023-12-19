function themeToggle() {
    
    // Add
    $("nav").toggleClass("navbar-dark bg-dark");
    
    $("body").toggleClass("bg-secondary text-white");

    $("li.list-group-item").toggleClass("bg-secondary text-white")

    $("#btnThemeToggle").toggleClass("btn-dark");

    $("div.step-container").toggleClass("text-black");
    $("div.form-text").toggleClass("text-white");

    // Remove
    $("nav").toggleClass("border-bottom border-2"); 
    
}