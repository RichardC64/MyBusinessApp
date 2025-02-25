# Idées
### Voir une meilleure gestion du temps en .NET
var t = TimeProvider.System;
t.GetLocalNow();
var tz = TimeZoneInfo.FindSystemTimeZoneById("Paris");
await Task.Delay(TimeSpan.FromSeconds(1), TimeProvider.System);
https://okyrylchuk.dev/blog/better-controlling-time-in-dotnet/

### SLNX
https://www.devlead.se/posts/2025/2025-02-24-slnx-finally-here
Vérifier dotnet --version 
VS	:	17.13.1
SDK	:	9.0.200
Aller dans Options/environnement/Fonctionnalités en préversion/Activer SLNX

Migration
dotnet sln migration <SLN_FILE>

Création 
dotnet new sln --format slnx

Voir aussi https://github.com/microsoft/vs-solutionpersistence/wiki/Samples

