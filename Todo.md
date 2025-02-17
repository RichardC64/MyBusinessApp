# Idées
### Voir une meilleure gestion du temps en .NET
var t = TimeProvider.System;
t.GetLocalNow();
var tz = TimeZoneInfo.FindSystemTimeZoneById("Paris");
await Task.Delay(TimeSpan.FromSeconds(1), TimeProvider.System);
https://okyrylchuk.dev/blog/better-controlling-time-in-dotnet/