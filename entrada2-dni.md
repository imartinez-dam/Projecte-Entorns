# Entrada 2: Programa en C# per calcular la lletra del DNI

En aquesta entrada explicaré la part de programació de l’activitat. He creat un programa en C# amb Visual Studio Code que calcula la lletra corresponent d’un DNI a partir del número introduït per l’usuari.

## Objectiu del programa

L’objectiu del programa és demanar a l’usuari el número del DNI sense lletra i calcular automàticament quina lletra li correspon.

Per fer-ho, el programa utilitza el sistema oficial de càlcul de la lletra del DNI, que consisteix a dividir el número entre 23 i utilitzar el residu per seleccionar una lletra d’una cadena predeterminada.

## Codi font

```csharp
using System;

namespace CalculDNI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroDNI;
            int residu;
            string lletres = "TRWAGMYFPDXBNJZSQVHLCKE";
            char lletraDNI;
            bool correcte;

            do
            {
                Console.WriteLine("=== CALCULADORA DE LLETRA DEL DNI ===");
                Console.WriteLine();

                Console.Write("Introdueix el número del DNI sense lletra: ");
                correcte = int.TryParse(Console.ReadLine(), out numeroDNI);

                if (correcte && numeroDNI >= 0 && numeroDNI <= 99999999)
                {
                    residu = numeroDNI % 23;
                    lletraDNI = lletres[residu];

                    Console.WriteLine();
                    Console.WriteLine("La lletra del DNI és: " + lletraDNI);
                    Console.WriteLine("El DNI complet és: " + numeroDNI.ToString("D8") + lletraDNI); // D8 formata el número amb 8 dígits, afegint zeros al principi si cal
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("ERROR: has d'introduir un número de DNI vàlid, entre 0 i 99999999.");
                }
            } while (!correcte);
        }
    }
}
```

## Explicació del funcionament

Primer es declaren les variables que farà servir el programa:

```csharp
int numeroDNI;
int residu;
string lletres = "TRWAGMYFPDXBNJZSQVHLCKE";
char lletraDNI;
bool correcte;
```

La variable `numeroDNI` guarda el número que introdueix l’usuari. La variable `residu` guardarà el resultat de fer el mòdul del número entre 23. La cadena `lletres` conté totes les lletres possibles del DNI en l’ordre correcte. La variable `lletraDNI` guardarà la lletra calculada i la variable `correcte` servirà per comprovar si l’usuari ha introduït un número vàlid i per repetir el bucle demanant de nou a l'usuari fins que introdueixi un número vàlid.

Després el programa mostra un títol per pantalla i demana el número del DNI:

```csharp
Console.Write("Introdueix el número del DNI sense lletra: ");
correcte = int.TryParse(Console.ReadLine(), out numeroDNI);
```

Aquí he utilitzat `int.TryParse` perquè és més segur que fer servir directament `Convert.ToInt32`. Si l’usuari escriu text o un valor incorrecte, el programa no es tanca amb error, sinó que guarda `false` a la variable `correcte`.

A continuació, el programa comprova que el valor introduït sigui correcte i que estigui dins del rang permès:

```csharp
if (correcte && numeroDNI >= 0 && numeroDNI <= 99999999)
```

Aquesta condició comprova tres coses:

- Que l’usuari hagi escrit un número.
- Que el número no sigui negatiu.
- Que el número no tingui més de 8 xifres.

Si tot és correcte, es calcula el residu de dividir el número entre 23:

```csharp
residu = numeroDNI % 23;
```

L’operador `%` retorna el residu d’una divisió. En aquest cas, el residu sempre serà un valor entre 0 i 22.

Aquest residu s’utilitza com a posició dins la cadena de lletres:

```csharp
lletraDNI = lletres[residu];
```

Per exemple, si el residu és `0`, agafa la primera lletra de la cadena, que és `T`. Si el residu és `1`, agafa la `R`, i així successivament.

Finalment, el programa mostra la lletra calculada i el DNI complet:

```csharp
Console.WriteLine("La lletra del DNI és: " + lletraDNI);
Console.WriteLine("El DNI complet és: " + numeroDNI.ToString("D8") + lletraDNI);
```

El mètode `ToString("D8")` serveix per mostrar el número del DNI sempre amb 8 dígits. Si el número introduït té menys xifres, afegeix zeros al davant.

Per exemple:

```csharp
1234567.ToString("D8")
```

mostraria:

```text
01234567
```

Això és útil perquè el DNI s’ha de mostrar amb 8 números i una lletra.

Si el valor introduït no és correcte, el programa mostra un missatge d’error:

```csharp
Console.WriteLine("ERROR: has d'introduir un número de DNI vàlid, entre 0 i 99999999.");
```

## Sortida de prova 1

En aquesta primera prova he introduït el número `12345678`.

```text
=== CALCULADORA DE LLETRA DEL DNI ===

Introdueix el número del DNI sense lletra: 12345678

La lletra del DNI és: Z
El DNI complet és: 12345678Z
```

## Sortida de prova 2

En aquesta segona prova he introduït el número `1234567`, amb només 7 xifres. El programa afegeix un zero al davant gràcies a `ToString("D8")`.

```text
=== CALCULADORA DE LLETRA DEL DNI ===

Introdueix el número del DNI sense lletra: 1234567

La lletra del DNI és: L
El DNI complet és: 01234567L
```

## Sortida de prova amb error

També he comprovat què passa si l’usuari introdueix un valor incorrecte.

```text
=== CALCULADORA DE LLETRA DEL DNI ===

Introdueix el número del DNI sense lletra: hola

ERROR: has d'introduir un número de DNI vàlid, entre 0 i 99999999.
```
