using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Ajouter des services au conteneur.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configurer le pipeline de requ�tes HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Acceuil/Error"); // G�rer les erreurs dans l'application.
    // La valeur HSTS par d�faut est de 30 jours. Vous pouvez vouloir la modifier pour des sc�narios de production.
    app.UseHsts();
}

app.UseHttpsRedirection(); // Rediriger les requ�tes HTTP vers HTTPS.
app.UseStaticFiles(); // Activer le traitement des fichiers statiques.

app.UseRouting(); // Activer le routage.

app.UseAuthorization(); // Activer l'autorisation des requ�tes.

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Acceuil}/{action=Index}/{id?}"); // D�finir la route par d�faut.

app.Run(); // Ex�cuter l'application.
