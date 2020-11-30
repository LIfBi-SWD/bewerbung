# Bewerbung am LIfBi
Um die Softwareumgebung und Technologien am LIfBi als Bewerber besser kennen zulernen, hier ein kleine Testaufgabe:

## Beschreibung
In dieser Aufgabe soll eine kleine Sanduhr angezeigt werden. Dazu wird in einer statischen Methode in der Klasse Sanduhr die Funktion Print(int width) zur Verfügung gestellt.
Diese berechnet einen String, der auf dem Bildschirm angezeigt eine Sanduhr ergibt. Die kleinste Sanduhr hat die Breite 3. Wird eine kleinere Breite übergeben soll eine Exception
geworfen werden.


Breite 3
````
 ***
  *
 ***
````

Breite 4 
````
 ****
  **
 ****
````

Breite 5
````
 *****
  ***
   *
  ***
 *****
````

## Vorraussetzungen
- [Git](https://git-scm.com/)
- [Github Account](https://github.com)
- [.Net SDK](https://dotnet.microsoft.com/download/dotnet/5.0)

## Anleitung
Clonen sie sich das Projekt in einen Ordner Ihrer Wahl und legen Sie einen Brunch unter ihrem Namen an, auf diesem Brunch sollten sie dann über 
Github einen Pull-Request stellen.

Installieren Sie sich zunächst das neuste [.Net SDK](https://dotnet.microsoft.com/download/dotnet/5.0). Die Anwendung ist mit .Net 5 geschrieben. 
Das SDK kommt mit einer Kommandozeilen Erweiterung und nach der Installation sollten Sie *dotnet* in der Konsole eingeben können.

Es ist zu empfehlen sich für diese Aufgabe Visual Studio Code zu installieren, das ist die leichtgewichtige Version des großen Bruders, dem Visual Studio. Mit dem Tastaturkürzel 
[Strg+ö] lässt sich eine Console im aktuellen Ordner auf. In der Konsole können Sie dann die Kommandozeilenbefehle für den .Net Code aufrufen. 


Um die Test für die Sanduhrklasse zu starten geben sie folgenden Befehl in der Konsole ein:
````
 dotnet test
````