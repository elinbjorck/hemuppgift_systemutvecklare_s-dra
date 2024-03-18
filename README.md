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
