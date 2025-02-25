using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Ajouter des services au conteneur.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configurer le pipeline de requêtes HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Acceuil/Error"); // Gérer les erreurs dans l'application.
    // La valeur HSTS par défaut est de 30 jours. Vous pouvez vouloir la modifier pour des scénarios de production.
    app.UseHsts();
}

app.UseHttpsRedirection(); // Rediriger les requêtes HTTP vers HTTPS.
app.UseStaticFiles(); // Activer le traitement des fichiers statiques.

app.UseRouting(); // Activer le routage.

app.UseAuthorization(); // Activer l'autorisation des requêtes.

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Acceuil}/{action=Index}/{id?}"); // Définir la route par défaut.

app.Run(); // Exécuter l'application.
