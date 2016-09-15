[ ... back  ]( ../README.md)

# Llistes dinàmiques  

Les llistes dinàmiques, a diferència de les taules, són estructures de dades que poden anar creixent a demanda. No cal que donem una mida inicial de la llista, sinó que la llista anirà allotjant memòria a mesura que necessiti afegir nous elements a la llista.

.NET ens dona diferents tipus de llista dinàmica, segons les nostres necessitats. Per comenar treballarem amb la d'ús més general: _List_
Tanmateix n'hi ha d'altres tipus d'estructures de dades per desar "col·lecions" , entre d'altres:
 * List
 * Queue
 * Stack
 * Dictionary
 
## Inicialització

La sintaxi d'una llista dinàmica bàsica és:
> List<[tipus de dades]> = new List<tipus de dades]();

```c#
            // Creació d'una llista dinàmica
            List<string> people = new List<string>();
```
## Afegir elements

```c#
            // Afegir elements a la llista
            people.Add("Maria");
            people.Add("Berta");
            people.Add("Joan");
            people.Add("Pep");
            // Accés per índex
            people[2] = "Josep";
```
##  Recorreguts

```c#
            // Recorregut per índex
            string noms = "";
            for(int n=0;n<people.Count;n++)
            {
                noms += $" - {people[n]} \n";
            }
```

```c#
            // Recorregut amb foreach
            foreach( string p in people )
            {
                noms += $" - {p} \n";
            }
```
## Eliminar elements

```c#
            // Eliminació d'un element de la llista
            noms.Remove(2, 1); // esborra l'element amb índex 2 ( el tercer )
                               // i reindexa els posteriors
            noms.Remove(2);  // esborra tots els elements de la llista a partir del que 
                            // està a l'index 2 (inclós)
```

 





```	
	
 