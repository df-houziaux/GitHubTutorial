document.addEventListener("DOMContentLoaded", function () {
    let btnScrollTop = document.createElement("button");
    btnScrollTop.innerText = "⬆ Retour en haut";
    btnScrollTop.style.position = "fixed";
    btnScrollTop.style.bottom = "20px";
    btnScrollTop.style.right = "20px";
    btnScrollTop.style.padding = "10px";
    btnScrollTop.style.backgroundColor = "#333";
    btnScrollTop.style.color = "white";
    btnScrollTop.style.border = "none";
    btnScrollTop.style.cursor = "pointer";
    document.body.appendChild(btnScrollTop);

    btnScrollTop.addEventListener("click", function () {
        window.scrollTo({ top: 0, behavior: "smooth" });
    });
});
