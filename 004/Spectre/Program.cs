using Spectre.Console;
using Spectre.Console.Cli;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

/*
Spectre NomCompetition
Specre NomCompetition
 -




 */
// ajout d'une image
var image = new CanvasImage("Logo-lunettes-256.png");
image.MaxWidth(16);
AnsiConsole.Write(image);
var app = new CommandApp<MyAppCommand>();

app.Run(args);







internal sealed class MyAppCommand : Command<MyAppCommand.Settings>
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

        //[CommandOption("-p|--pattern")]
        //public string? SearchPattern { get; init; }

        //[CommandOption("--hidden")]
        //[DefaultValue(true)]
        //public bool IncludeHidden { get; init; }
    }

    public override int Execute([NotNull] CommandContext context, [NotNull] Settings settings)
    {
        var nomCompetition = settings.NomCompetition ?? null;
        if (nomCompetition == null)
        {
            nomCompetition = AnsiConsole.Prompt(
                new TextPrompt<string>("Quelle est le nom de la compétition ?"));
            if (string.IsNullOrWhiteSpace(nomCompetition))
            {
                AnsiConsole.MarkupLine("[red]Le nom de la compétition est obligatoire[/]");
                return 1;
            }
        }
        var brut = "Brut";
        var net = "Net";
        var typeCompetition = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Quelle type de compétition ?")
                .AddChoices(brut, net));


        AnsiConsole.MarkupLine($"Nom de la compétition: {nomCompetition}/{typeCompetition}");
        AnsiConsole.MarkupLine($"Import: {settings.Import}");
        AnsiConsole.MarkupLine($"Export: {settings.Export}");

        return 0;
    }



  
}