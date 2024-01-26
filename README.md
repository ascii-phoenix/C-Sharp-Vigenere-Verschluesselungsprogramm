# Lern-Periode 3

**Eloi Knecht**

*12.1. bis 23.2.2024*

## Grob-Planung

Ich möchte ein Vigenère-Verschlüsselungsprogramm schreiben.

## 12.1.2024

Heute habe ich mit dem Vigenère-Verschlüsselungsprojekt begonnen. Dabei habe ich versucht, mein Programm benutzerfreundlich zu gestalten, indem ich alle Eingaben klein und alle Abstände gelöscht habe. Bei diesem Projekt möchte ich den Code möglichst modular gestalten und mit Objekten arbeiten, um eine bessere Leserlichkeit zu erreichen.

## 19.1.2024

- [x] Programm sollte Buchstaben in Zahlen 1-26 (englisches Alphabet) umwandeln
- [x] Funktionen in Methoden umwandeln
- [x] Schlüssel in Zahlen 1-26 (englisches Alphabet) umwandeln
- [x] Implementierung der Vigenère-Verschlüsselung (nur Verschlüsselung)

**Testfälle:**
| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --------------- | -------------------- | -------------- | -------------- | -------- |
| 1               | hallo = 7 0 11 11 14 | hallo          | 7 0 11 11 14   | ja       |
| 2               | hallo = 7 0 11 11 14 | hallo          | 7 0 11 11 14   | ja       |
| 3               | abc = 0 1 2          | abc            | 0 1 2          | ja       |
| 4               | abc / abc = ace      | abc / abc      | ace            | ja       |

*Heute, am 16. Januar, habe ich erfolgreich eine Klasse programmiert. Diese Klasse ermöglicht die Verarbeitung von Eingaben eines Schlüssels und eines Klartexts, um den Klartext mithilfe der Vigenère-Verschlüsselung zu verschlüsseln. Leider bereitet die Entschlüsselung noch Probleme, und ich arbeite daran, das Problem zu identifizieren und zu beheben.*

☝️ *Vergessen Sie nicht, bis zum 16.1 einen ersten Code auf GitHub hochzuladen und in der Spalte **Erfüllt?** einzutragen, ob Ihr Code die Test-Fälle erfüllt.*

## 26.1.2024

- [ ] Implementierung der Vigenère-Verschlüsselung (Entschlüsselung)
- [x] Erstellung einer Eingabeoberfläche für Key und Text
- [x] Oberfläche für den Ausgabe-Text
- [ ] Ein Schalter, um zwischen Verschlüsselung und Entschlüsselung zu wechseln

**Testfälle:**
| Testfall-Nummer | Ausgangslage (Given)                                         | Eingabe (When)              | Ausgabe (Then) | Erfüllt? |
| --------------- | ------------------------------------------------------------ | --------------------------- | -------------- | -------- |
| 5.1             | Verschlüsselter Text wird entschlüsselt                      | ace/abc=abc                | adg            | nein     |
| 5.2             | Verschlüsselter Text wird entschlüsselt                      | ace/abc=abc                | abc            | ja       |
| 7               | Spiel gestartet, Schlange lang genug, dass sie sich beißen kann | Schlange beißt sich selber | Spiel endet    |          |
| 8               |                                                              |                             |                |          |

*Heute am 26.1 habe ich die Konsolenversion beendet und somit mein Minimum-Meilenstein erreicht. Leider ist mir aufgefallen, dass der Code nur funktioniert, wenn der Schlüssel als zweites gegeben wird. Auch während der Programmierung der Ausgabeoberfläche ist mir aufgefallen, dass die Entschlüsselung bei komplizierteren Eingaben nicht funktioniert. Meine momentane Vermutung ist, dass Leerzeichen vom Code nicht vertragen werden.*

☝️ *Vergessen Sie nicht, bis zum 23.1 Ihren fixfertigen Code auf GitHub hochzuladen und in der Spalte **Erfüllt?** einzutragen, ob Ihr Code die Test-Fälle erfüllt.*

## 16.2.2024

*Heute am 23.1 habe ich... (50-100 Wörter)*

## Reflexion

*Meine Zusammenfassungen in Bezug auf meinen VBV bilden einen zusammenhängenden Text von 100 bis 200 Wörtern (wieder mit Angabe in Klammern).*

*Zusätzlich reflektiere ich über die Länge der Projekte: Die 10-wöchige LP2 und die 4-wöchige LP3. Fand ich die 10-wöchige LP2 oder die 4-wöchige LP3 angenehmer? Was bedeutet das für meine Planung der zukünftigen LP?*
