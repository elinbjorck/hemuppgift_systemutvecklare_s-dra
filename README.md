# Hemuppgift Systemutvecklare

## SQL

> Vi har en databas-tabell Medarbetare med kolumnerna ID, Namn och Avdelning. T.ex:

| ID  | Namn  | Avdelning |
| --- | ----- | --------- |
| 1   | Lisa  | IT        |
| 2   | Kalle | HR        |
| 3   | Emma  | HR        |

Det är meningen att denna query ska räkna de anställda på respektive avdelning och sortera dem så att avdelningen med flest anställda hamnar först. SQLite användes för att testa queryn på en likadan tabell som den i instruktionerna och det verkar funka. 

```sql
SELECT COUNT(ID) AS MedarbetarCount, Avdelning
FROM Medarbetare
GROUP BY Avdelning
ORDER BY MedarbetarCount DESC;
```
## Imperativ programering

Jag hade lite olika ideér på lösningar så jag implementerade dem i några olika språk. Jag är mest bekväm i Python och Java. 

### Python
Jag valde att gå igenom strängen tecken för tecken och kolla om tecknet finns i ett set som skapats i förväg, gör den det returnerar jag `False`. Finns tecknet inte läggs det till i setet.  Går det att gå igenom hela strängen utan att hitta några likadana tecken returneras `True`. 

```python
def hasUniqueCharacters(textString):
    charecterSet = set()
    for character in textString:
        if character in charecterSet:
            return False
        else:
            charecterSet.add(character)
    return Trues
```
### .NET

I denna lösnaing går jag igenom varje tecken i strängen och jämför med alla tecken som följer. Jag använder alltså nestlade for-loopar. 

```c#

bool HasUniqueCharacters(string text) {
    for( int i = 0; i < text.Length; i++) {
        for ( int j = i + 1; j < text.Length; j++) {
            if(text[i] == text[j]) {
                return false;
            }
        }
    }
    return true;
}

```
