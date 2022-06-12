# HTL-VRProject with XRInteractionToolkit Victoria Schorn

### Spiel Beschreibung: 
In diesem Spiel, muss der Spieler 5 Ostereier einsammeln, um den Osterhasen aus dem Labyrinth zu befreien. Wenn er alle fünf richtigen Eier eingesammelt hat, öffnet sich die Tür und er kann samt dem Osterhasen entkommen. 
Jedoch muss der Spieler aufpassen, damit er nicht eines der "faulen Eier" des Osterhuhns einsammelt. Tut er dies, verliert er alle bereits gesammelten Eier und muss noch einmal von Neuem anfangen! 

### Ablauf:
Nachdem das Spiel gestartet wird, bekommt man eine kleine Intro Sequenz mit Musik und einem idyllischen Hintergrund vorgespielt. Nach dem Intro wird man in die "Main Scene" geladen, wo man dann auch mit dem eigentlichen Spiel beginnen kann. Am Start ist noch einmal eine kurze Beschreibung, was der Spieler tun soll. 
Nachdem alle richtigen Eier gesammelt worden sind, kann der Spieler das Labyrinth verlassen, und das Spiel ist somit beendet. 

### Auditive Gestaltung:
Leise Waldgeräusche und vereinzeltes Vogelgezwitschere lässt die Umgebung in eine natürliche Stimmung versenken. Durch eine entspannte Background Musik, wird das Spielerlebnis zusätzlich geschmückt und angenehmer gemacht. 
Als Hinweis für die Ostereier, wird der Spieler durch "Glitter" Sounds zu den Eiern geführt. 

### Visual Style: 
Das Spiel sollte ansprechend und glücklich wirken. Es wurde mehr auf hellere und buntere Farben gesetzt und mit der Idee durch gewisse Texturen den Eindruck einer Blumenwiese zu vermitteln. Durch den Himmel wirkt es zusätzlich so, als wäre man mitten auf einer Wiese in der Natur. 

### Minigame 1:
In dem ersten Minigame muss der Spieler fünf Eier einsammeln, welche im Labyrinth versteckt sind.
Je näher man den Eiern kommt, desto lauter hört man die Sounds der Eier als Tipp für den User, dass er nahe dran ist. 
Der Spieler muss die Eier einsammeln. Wenn er aber ein falsches Ei einsammelt, wird er zurück an den Start gesetzt und verliert alle bisher gesammelten Eier und muss sie noch einmal alle von neuem einsammeln. Wenn der Spieler die fünf richtigen Eier eingesammelt hat, öffnet sich eine Tür und er kann zu dem Osterhasen flüchten.

![LabyrinthBli](https://user-images.githubusercontent.com/72389422/173232212-c0ba362b-12e2-4e0e-9872-f59b166b12cf.png)


### Minigame programmierung:
-	Der Spieler kann mit den Controllern die Eier aufheben und berühren. (XR Grab Interactable) Sobald er ein Ei aufgehoben hat, wird ein Trigger aktiviert und das Ei verschwindet. Das Ei, welches eingesammelt wurde, wird im Inventar angezeigt. Sobald 5 richtige Eier eingesammelt sind, öffnet sich die Türe. 

### Arbeitsschritte:
1.	Recherche: Ostereier einsammeln, wie programmieren?, gibt es Assets oder muss ich sie selber machen?
2.	Recherche & Überlegung: Modell Osterhase?
3.	Recherche Assets & Texturen
4.	Rechereche: Wie sieht Overlay aus? Atmosphäre InGame, Gestaltung?
5.	Sounds raussuchen
6.	Wie sieht start aus? Overlay (Einleitung ins Spiel? Erklärungstext?)
7.	Dokumentation erstellen
8.	Whiteboxing Minigames & Umgebung
9.	Rätsel bzw Minigame 1 erstellen
10.	Testing ob Rätsel funktioniert
11.	Audios einbinden
12.	Testing ob audio richtig abgespielt wird 
13.	Build
14.	Abgabe

### Assets & Sounds:
- Nature sounds Meditation forest sounds of birds singing relaxation - 4 minutes
 https://www.youtube.com/watch?v=wKnS8VPxpHI
- [no copyright music] 'Purple' lofi background music
 https://www.youtube.com/watch?v=BWNx0VQJjMY
- Sparkling Fairy Shimmer - Sound Effect (HD)
  https://www.youtube.com/watch?v=dxhXHAGVLww


  - AllSky Free - 10 Sky / Skybox Set
  - Grass And Flowers Pack 1
  - Stylized Wood Texture
  

### Development platform: 
OS: Windows 10, Game Engine: Unity 2020.3.18f1, Visual Studio 2019, XR Interaction Toolkit 1.0.0-pre.8, XR Plugin Management 4.2.1, Oculus XR Plugin 1.10.0.

## Software/Hardware Requirements: 
Oculus hardware requirements https://support.oculus.com/248749509016567/
You need a VR headset in this case an Oculus Rift/Quest/Quest2

Examples: https://github.com/Unity-Technologies/XR-Interaction-Toolkit-Examples

When downlaoded, you have compile time errors in the project. To solve them install the XR interaction toolkit package via the Package Manager. (!Enable in Advanced Settings Preview Packages).

### Target platform: 
Oculus Rift/S; Quest/2

### Third party material: 

For testing without a headset, use the XR Device Simulator (included in the xr interaction toolkit package):  https://www.youtube.com/watch?v=d4bTpkvBwrs

### Limitations/Problems: 

Generelles Problem: Konnte das Projekt nicht mit VR Brille testen, darum weiß ich nicht, ob alles funktioniert oder nicht.
- Door on Trigger funktioniert nicht
- Nicht sicher ob Inventar funktionert
- Mögliche Fehler in Scripts




Copyright by Victoria Schorn
