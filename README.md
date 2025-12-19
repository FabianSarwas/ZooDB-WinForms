ZooDB – Datenbankdokumentation

Projekbeschreibung:

Die ZooDB ist eine relationale Datenbank zur Verwaltung eines Zoos.
Sie dient dazu, Tiere, Gehege, Pfleger sowie weitere relevante Informationen strukturiert zu speichern und miteinander in Beziehung zu setzen.

Die Datenbank wurde nach den Regeln der Normalisierung entworfen und verwendet Primär- und Fremdschlüssel, um konsistente Beziehungen zwischen den Tabellen sicherzustellen.

Ziel der Datenbank:

- Verwaltung von Tieren im Zoo.

- Zuordnung von Tieren zu Gehegen.

- Verwaltung von Pflegern.

- Abbildung von Beziehungen zwischen Tieren, Gehegen und Pflegern.

- Grundlage für eine Anwendung (z. B. WinForms, WebApp).


Schlüssel & Beziehungen:

- Jede Tabelle besitzt einen Primärschlüssel (PK).

- Beziehungen werden über Fremdschlüssel (FK) realisiert.

- n:m-Beziehungen werden über Zwischentabellen aufgelöst.

- Redundanzen wurden vermieden (3. Normalform).


Verwendete Technologien:

- Relationale Datenbank (z. B. MySQL / SQL Server / SQLite).

- SQL für Definition und Abfragen.

- Optional: C# WinForms zur Darstellung und Verwaltung der Daten.


Hinweis:

Diese Datenbank wurde zu Lern- und Übungszwecken erstellt und kann beliebig erweitert oder angepasst werden.
