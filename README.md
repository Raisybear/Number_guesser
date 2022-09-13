# Projektdokumentation

Spycher

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben. |
|       | ...     |   Ich habe dieses Mal                                                            |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Einen random Numberguesser mit c+ programmieren.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |        Muss   |   Funktional   | Eine zufällige Nummer zwischen 1 und 100 generieren, dass es nicht immer die gleiche Zahl ist.|
| 2    |        Muss   |   Funktional   | gewählte Zahl mit generierter Zahl vergleichen, um rausuzufinden ob es die richtige ist.|
| 3    |        Muss   |   Funktional   | Angeben ob Zahl richtig/grösser/kleiner ist, um weiter zu raten   |
| 4    |        Muss   |   Funktional   | Bei korrekter Zahl, angeben wie viele Versuche man gebraucht hat, damit der Nutzer ein kleines Feature hat.  |
| 5    |        Muss   |   Funktional   | Bei korrket geratener Zahl Programm abschliessen, um nochmal zu spielen.  |
| 6    |        Muss   |   Funktional   | Neue Zahl generieren, um wieder spielen zu können  |
| 7    |        Muss   |   Funktional   | Bei einer zu grossen Eingabe möchte ich eine Fehlermeldung anzeigen und den Spieler drauf hinweisen, damit es keine Errors gibt |
| 8    |        Muss   |   Funktional   | Bei einer zu kleinen Eingaebe (Negativbereich/Dezimal oder anderen Reellen Zahlen) Problem sagen, damit es keine Fehler gibt |
| 9    |        Muss   |   Funktional   | Bei einem Buchstaben oder einem Wort Problem sagen, damit es keine Fehler gibt |
 
 
✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |     Randomnummer wurde generiert und gespeichert         |     Zahl von 1 bis 100    |          Zahl ist grösser/kleiner         |
| 7.2 |     Randomnummer wurde generiert und gespeichert         |    Zahl über 100     |          Eingabe ist nicht erlaubt, wähle eine kleinere Zahl         |
| 8.3  |     Randomnummer wurde generiert und gespeichert         |     Zahl unter 100    |        Es entsteht ein Fehler, wurde nicht Programmiert           |
| 4.4 |    Lauf beendet        |     keine    |         Es wird angegeben, wie viele Versuche man gebraucht hat.          |
| 5.5 |     Der Durchlauf wurde erfolgreich beendet         |    Ja/Nein     |         Programm wird nochmal ausgeführt oder nicht          |

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

Keine Vorhanden

## 2 Planen

| AP-№ | Frist       | Zuständig | Beschreibung | geplante Zeit |
| ---- | -----       | --------- | ------------ | ------------- |
| 1.A  |   30.08.    |     Spycher      |      Random Number generieren        |       20 min        |
| 2/3.B  |   30.08.    |     Spycher     |       Zahl bestimmen ob höher oder kleiner als x       |       30 min        |
| 2/3.C  |   30.08.    |      Spycher     |       x bestimmen können, also der Spieler kann eine Zahl raten      |       30 min        |
| 4/5.D |   30.08.    |      Spycher     |       Beenden des Durchlaufes mit geratener Zahl und Spiel neu starten nach Wunsch |        45 min       |
| 7.E  |   30.08.    |      Spycher     |       Hinweisen bei einer zu grossen Zahl  |       45 min        |
| 8.F |   06.09    |      Spycher     |      Rechtweisung bei negativer Eingabe      |       30 min        |
| 8.G  |   06.09    |      Spycher     |      Rechtweisung bei Nachkommazahlen    |      30 min        |
| 8.H  |   06.09    |      Spycher     |      Rechtweisung bei Reellenzahlen, die nicht erkannt werden können   |      30 min        |
| 9.I  |   06.09    |      Spycher     |      Rechtweisung bei Einagabe von Buchstaben/Wörtern   |      30 min        |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

Ich habe mich schon ziemlich früh entschieden wenig bis keine Design features einzufügen, denn ich denke es ist wichtig, dass der User möglichst wenig Optionen hat das Spiel zu crashen und auch alles testen kann was bei inkorrekter Eingabe geregelt ist.


## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |   30.08.    |     Spycher |      20 min       |           10 min        |
| 2/3.B |    30.08.    |     Spycher       |       30 min        |         30 min          |
| 2/3.C  |    30.08.    |    Spycher        |        30 min       |          45 min         |
| 4/5.D |   06.09.    |      Spycher     |     45 min    |       ca. 200 min       |
| 7.E  |   30.08.    |      Spycher     |        45 min   |       45 min        |



## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |    funktioniert, es wird angegeben, ob eine Zahl zu gross oder zu klein ist.      |    Spycher Elias    |
| 7.2  |       |     Funktioniert     |    Spycher Elias    |
| 8.3  |       |          |    Spycher Elias    |
| 4.4  |       |          |    Spycher Elias    |
| 5.5  |       |          |    Spycher Elias    |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I   |              |   2.2mrd      |   zu gross                |      crash weil über int32                |
| II  |              |  buchstabe       |      error             |                      | crash weil kein int
| III  |              |  dezimalzahl       |     zu klein/zu gross              |  crash                    |
| II  |              |         |                   |                      |
| II  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
