document.addEventListener("DOMContentLoaded", function () {
    // Ajout d'un bouton pour revenir en haut de la page
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

    // Défilement fluide vers le haut lorsque le bouton est cliqué
    btnScrollTop.addEventListener("click", function () {
        window.scrollTo({ top: 0, behavior: "smooth" });
    });

    // Gestion de la classe active dans la navigation
    document.querySelectorAll("nav ul li a").forEach(link => {
        link.addEventListener("click", function () {
            document.querySelectorAll("nav ul li a").forEach(el => el.classList.remove("active"));
            this.classList.add("active");
        });
    });
});