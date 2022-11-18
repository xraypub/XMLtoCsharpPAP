# XMLtoCsharpPAP 2022

Ein C++ try-out mit Regulären-Ausdrücken und eigenen String-Workern am Beispiel des PAP 2022 XML Files des BMF.

Aus dem XML File werden Properties, interne Felder, Konstanten und Methoden extrahiert und in C#-Code konvertiert. Dabei wird eine C#-Klasse mit Dateinamen CsharpPAP2022.cs erstellt. Die Properties können über Data-Binding (OnPropertyChanged, Raise Commands etc.) leicht an ein UI / eine View gebunden werden.

Es kommen keine XML Deserializer oder bestehende Converter-Pakete zum Einsatz - sozusagen "from scratch". **Ziel war hauptsächlich das Testen von Visual C++.**

*Derzeitiger Stand - To-Do's:*

- Pfade und Dateinamen als Argumente beim Programmstart oder über Abfrage, derzeit nur direkt im Code
- Prüfroutine zur Validierung der Methoden fehlt z.B. Richtigkeit der Berechnung und Rundung der berechneten Werte, Klammersetzung etc.
- "Main" aus PAP-File nicht umgesetzt, nur als Comment
- Strukturierung des C#-Codes "{...}"-Brackets nicht immer optimal - Einrückungen!
- Überprüfen ob die Erstellung des C#-Codes so sinnvoll bzw. überhaupt praktikabel wäre
- Strukturierung des Codes und der Methoden, Optimierung, Überprüfung und Beseitigung von Redundanzen
