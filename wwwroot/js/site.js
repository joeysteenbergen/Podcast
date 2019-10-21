$("#changeLogin").on("click", function () {
    document.getElementById("Login").style.display = "block";
    document.getElementById("Register").style.display = "none";
    document.getElementById("changeLogin").style.backgroundColor = "#9E9E9E";
    document.getElementById("changeRegister").style.backgroundColor = "#757575";
});

$("#changeRegister").on("click", function () {
    document.getElementById("Register").style.display = "block";
    document.getElementById("Login").style.display = "none";
    document.getElementById("changeRegister").style.backgroundColor = "#9E9E9E";
    document.getElementById("changeLogin").style.backgroundColor = "#757575";
});
