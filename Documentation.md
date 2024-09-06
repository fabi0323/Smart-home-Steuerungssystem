# Steuerungssystem

# LA-0110

### Beschreibung

Gruppe: Fabian Meyer, Justus Meister

Wir entwickeln ein Steuerungssystem mit welchem man verschiedene Geräte in einem Smarthome wie Lichter, Storen usw. ansteuern kann. Die Geräte werden debei simuliert und sind nicht wirklich vorhanden.

### Anforderungen
| A-№ |  Beschreibung                                                                                                                                                  |
| ---- | ------------------------------------------------------------------------------------ |
| 1    | Übersichtliches und modernes GUI                                                        |
| 2    |     Erfassen neuer Räume im Smarthome                                                                   |
|  3   |     Erfassen von Geräten innerhalb eines Raums im Smarthome                                                                  |
|   4  |     Bearbeiten und Speichern der verschiedenen Räume und Geräte                                                                   |
|  5   |      Ansteuern der verschiedenen erfassten Geräte                                                                  |


### User Stories

| US-№ | Verbindlichkeit | Typ        | Beschreibung                                                                                                                                                  |
| ---- | --------------- | ---------- | ----------------------------------------------------------------------------- |
| 1.1    | Muss            | Qualität | Als User möchte ich ein selbsterklärendes und übersichtliches GUI, damit ich mich einfach zurecht finden kann.                                                          |
| 1.2    | Muss            | Qualität | Als User möchte ich ein modernes GUI haben, um meine User-Experience ertragbar zu machen.                                                                    |
| 2.1    | Muss            | Funktional | Als User möchte ich die einzelnen Räume meines Smarthomes erfassen können, um meine Geräte zu erfassen.                                                                        |
| 3.1    | Muss            | Funktional | Als User möchte ich Geräte innerhalb eines Raums mit Namen und Typ erfassen können, um diese anzusteuern.                                            |
| 3.2    | Muss            | Funktional | Als User möchte ich die Möglichkeit haben, Lichter, Heizungen und Storen als Geräte erfassen zu können, um diese anzusteuern.                                         |
| 4.1    | Muss            | Funktional | Als User möchte ich die Daten der Geräte und Räume bearbeiten können, um die Daten aktuell zu halten.                                            |
| 4.2    | Muss            | Funktional | Als User möchte ich Geräte und Räume aus dem System entfernen können, um keine überflüssigen Elemente zu haben. |
| 4.3    | Muss            | Funktional | Als User möchte ich, dass die Daten der Geräte und Räume gespeichert werden, um das System wiederverwendbar zu machen.            |
| 5.1    | Muss            | Funktional | Als User möchte ich Lichter an- und ausschalten können, um das Licht an- und ausschalten zu können.                                             |
| 5.2    | Muss            | Funktional | Als User möchte ich die Temperatur der Heizungen anpassen können, um im Winter nicht zu erfrieren.                                             |
| 5.3    | Kann            | Funktional | Als User möchte ich die Storen hoch- und runterlassen können und Sie anwinkeln, um zu kontrolieren wie viel Lich ins Haus kommt.                                        |

### Testfälle

#### TC-№: 2.1.1
Beschreibung: Räume erfassen
Ausgangslage: Programm gestartet
Eingabe: 1. Button(Raumerfassung) gedrückt | 2. Raum benannt | 3. Button(Erfassen) gedrückt
Ausgaabe: 4. Raum mit gewähltem Namen erstellt

#### TC-№: 2.1.2
Beschreibung: Räume erfassen
Ausgangslage: Programm gestartet
Eingabe: 1. Button(Raumerfassung) gedrückt | 2. Raum benannt | 3. Button(Abbrechen) gedrückt
Ausgaabe: 4. Erfassen des Raums abgebrochen

#### TC-№: 3.1.1
Beschreibung: Geräte erfassen
Ausgangslage: Raum ausgewählt
Eingabe: 1. Button(Geräterfassung) gedrückt | 2. Gerätetyp ausgewählt | 3. Gerät benannt | 4. Button(Erfassen) gedrückt
Ausgaabe: 5. Gerät mit gewähltem Typ und Namen erstellt.

#### TC-№: 3.1.2
Beschreibung: Geräte erfassen
Ausgangslage: Raum ausgewählt
Eingabe: 1. Button(Geräterfassung) gedrückt | 2. Gerätetyp ausgewählt | 3. Gerät benannt | 4. Button(Abbrechen) gedrückt
Ausgaabe: 5. Erfassen des geräts abbgebrochen.

#### TC-№: 4.1.1
Beschreibung: Räume bearbeiten
Ausgangslage: Raum ausgewählt
Eingabe: 1. Button(Bearbeiten) gedrückt | 2. Namen geändert | 3. Button(Speichern) gedrückt
Ausgaabe: 4. Name des gewählten Raums aktialisiert

#### TC-№: 4.1.2
Beschreibung: Geräte bearbeiten
Ausgangslage: Gerät ausgewählt
Eingabe: 1. Button(Bearbeiten) gedrückt | 2. Namen geändert | 3. Typ geaändert | 4. Button(Speichern) gedrückt
Ausgaabe: 5. Name und Typ des gewählten Geräts aktialisiert

#### TC-№: 4.2.1
Beschreibung: Räume entfernen
Ausgangslage: Raum ausgewählt
Eingabe: 1. Button(Entfernen) gedrückt | 2. Entfernen bestätigt
Ausgaabe: 4. Raum entfernt

#### TC-№: 4.2.2
Beschreibung: Geräte entfernen
Ausgangslage: Gerät ausgewählt
Eingabe: 1. Button(Entfernen) gedrückt | 2. Entfernen bestätigt
Ausgaabe: 3. Gerät entfernt

#### TC-№: 4.3.1
Beschreibung: Räume und Geräte speichern
Ausgangslage: Programm neugestartet
Eingabe: 2. Raum ausgewählt
Ausgaabe: 1. zuvor erstellte Räume ersichtlich | 3. zuvor erstellte Geräte ersichtlich

#### TC-№: 5.1.1
Beschreibung: Licht an/aus
Ausgangslage: Gerät vom Typ Licht ausgewählt (Licht aus)
Eingabe: 1. Button(Licht an) gedrückt | 3. Button(Licht aus) gedrückt
Ausgaabe: 2. Licht geht an | 4. Licht geht aus

#### TC-№: 5.2.1
Beschreibung: Heizung bedienen
Ausgangslage: Gerät vom Typ heizung ausgewählt (Temperatur: 18°)
Eingabe: 1. Slider(Temperatur) drei Stellen nach oben | 3. Slider(Temperatur) eine Stelle nach unten
Ausgaabe: 2. (Temperatur: 21°) | 4. (Temperatur: 20°)

#### TC-№: 5.2.1
Beschreibung: Storen bedienen
Ausgangslage: Gerät vom Typ Storen ausgewählt (Position: oben)
Eingabe: 1. Button(Runter) gedrückt | 3. Button(Anwinkeln) gedrückt | 5. Button(Hoch) gedrückt
Ausgaabe: 2. (Position: unten) | 4. (Position: angewinkelt) | 6. (Position: oben)


### Planen

| AP-№ | Datum      | Arbeitspaket                                           | Verantwortliche Person                      |
| ---- | ---------- | ------------------------------------------------------ | ------------------------------------------- |
| 1    | 23.08.2024 | Projekt Idee wählen                                    | Fabian Meyer, Justus Meister                |
| 2    | 23.08.2024 | Anforderungen, Userstories, Testfälle schreiben        | Justus Meister                              |
| 3    | 23.08.2024 | Vertrautmachen mit WPF       | Justus Meister, Fabian Meyer                           |
| 4    | 30.08.2024 | Erstellen des MainGrids für das GUI        | Justus Meister                              |
| 5    | 30.08.2024 | Erstellen und designen der Buttons        | Fabian Meyer                              |
| 6    | 06.09.2024 | Erstellen und designen der Navigationsleisten        | Justus Meister        |

### Realisieren

| AP-№ | Datum      | Durchgeführt von...  in... min                                           |
| ---- | ---------- | ------------------------------------------------------ |
| 1    | 23.08.2024 | Justus Meister, Fabian Meyer (15min)                   |
| 2    | 23.08.2024 | Justus Meister (90min)                   |
| 3    | 23.08.2024 | Justus Meister, Fabian Meyer (90min)                   |
| 4    | 30.08.2024 | Justus Meister (50min)                   |
| 5    | 30.08.2024 | Fabian Meyer (30min)                   |
| 6    | 06.09.2024 | Justus Meister (40min)                   |

### Testprotokoll

| TC-№   | Datum      | Resultat | Tester        |
| ------ | ---------- | -------- | ------------- |
| 1.5.1  | 23.02.2023 | OK       | Elias Spycher |
| 2.4.1  | 23.02.2023 | OK       | Elias Spycher |
| 3.4.2  | 23.02.2023 | OK       | Elias Spycher |
| 4.1.1  | 23.02.2023 | OK       | Elias Spycher |
| 5.2.1  | 23.02.2023 | OK       | Elias Spycher |
| 6.3.1  | 23.02.2023 | OK       | Elias Spycher |
| 7.3.2  | 23.02.2023 | OK       | Elias Spycher |
| 8.6.1  | 23.02.2023 | OK       | Elias Spycher |
| 9.6.2  | 23.02.2023 | OK       | Elias Spycher |
| 10.7.1 | 23.02.2023 | OK       | Elias Spycher |
| 11.8.1 | 23.02.2023 | OK       | Elias Spycher |
| 12.8.2 | 23.02.2023 | OK       | Elias Spycher |

### Testbericht

Das Projekt funktioniert ziemlich fehlerfrei. Es konnten Alle funktionen umgesetzt werden.
