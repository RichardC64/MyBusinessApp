using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using Spectre.Console;
using Spectre.Console.Cli;

namespace Spectre;

internal sealed class MyAppCommand : AsyncCommand<MyAppCommand.Settings>
{
    public class Settings : CommandSettings
    {
        [Description("Nom de la compétition.")]
        [CommandArgument(0, "[nomCompetition]")]
        public string? NomCompetition { get; init; }

        [Description("Import des résultats de la compétition")]
        [CommandOption("-i|--import")]
        [DefaultValue(false)]
        public bool Import { get; init; }

        [Description("Export des résultats de la compétition")]
        [CommandOption("-e|--export")]
        [DefaultValue(false)]
        public bool Export { get; init; }

    }

    // execute async
    public override async Task<int> ExecuteAsync(CommandContext context, Settings settings)
    {
        // Image
        // ajout d'une image
        var image = new CanvasImage("Logo-lunettes-256.png");
        image.MaxWidth(16);
        AnsiConsole.Write(image);

        AnsiConsole.Write(
            new FigletText("GOLF")
                .LeftJustified()
                .Color(Color.Green));

        // markup language
        AnsiConsole.MarkupLine("[bold green]Bienvenue dans notre application de gestion de compétitions de golf.[/]");

        var nomCompetition = settings.NomCompetition ?? null;
        if (nomCompetition == null)
        {
            // Prompt : Inputbox
            nomCompetition = AnsiConsole.Prompt(
                new TextPrompt<string>("Quelle est le nom de la compétition ?"));
            if (string.IsNullOrWhiteSpace(nomCompetition))
            {
                AnsiConsole.MarkupLine("[red]Le nom de la compétition est obligatoire[/]");
                return 1;
            }
        }
        // Prompt ComboBox
        const string brut = "Brut";
        const string net = "Net";
        var typeCompetition = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Quelle type de compétition ?")
                .AddChoices(brut, net));

        await AnsiConsole.Status()
            .StartAsync("Chargement en cours...", async ctx =>
            {
                AnsiConsole.MarkupLine($"Nom de la compétition: {nomCompetition}/{typeCompetition}");
                AnsiConsole.MarkupLine($"Import: {settings.Import}");
                AnsiConsole.MarkupLine($"Export: {settings.Export}");
                ctx.Status = "Chargement des données...";
                ctx.Spinner = Spinner.Known.Dots;
                await Task.Delay(2000);
                ctx.Status = "Traitement des données...";
                await Task.Delay(2000);
                ctx.Status = "Terminé.";

            });

        

        return 0;
    }



  
}