# Entrada 1: Creació, configuració i ús de GitHub

En aquesta entrada explicaré com he creat, configurat i utilitzat GitHub per fer aquesta activitat de la RA2 - IDEs de l'assignatura d'Entorns de Desenvolupament.

L'objectiu d'aquesta part de l'activitat és crear un repositori, treballar amb arxius Markdown i publicar el resultat com una petita web o bloc mitjançant GitHub Pages.

## Instal·lació de GitHub Desktop i creació d'un compte

Primerament he instal·lat GitHub Desktop i he iniciat sessió amb el compte de Google de l'institut.

He utilitzat GitHub Desktop perquè és una eina que facilita el treball amb GitHub de manera visual. Això permet crear repositoris, veure els canvis dels arxius, fer commits i pujar els canvis a GitHub sense haver d'utilitzar directament les comandes de Git des de la terminal.

## Creació del repositori

Seguidament he creat un repositori anomenat `Projecte-Entorns` utilitzant GitHub Desktop. He escollit una carpeta local dins del meu ordinador per guardar el projecte.

El repositori serveix per tenir tots els arxius de la pràctica organitzats i poder-los pujar després al meu compte de GitHub.

En crear el repositori, he indicat el nom del projecte i la ubicació local on es guardarien els arxius. També he inicialitzat el repositori amb un arxiu `README.md`, que serveix per afegir una primera descripció del projecte.

Les opcions principals utilitzades han estat:

- Nom del repositori: `Projecte-Entorns`
- Carpeta local del projecte: `Documents\GitHub\Projecte-Entorns`
- Inicialització amb arxiu `README.md`
- Git ignore: `None`
- Llicència: `None`

## Publicació del repositori a GitHub

Després de crear el repositori en local, l'he publicat a GitHub amb l'opció `Publish repository` de GitHub Desktop.

D'aquesta manera, el repositori ha passat d'estar només al meu ordinador a estar també disponible al meu compte de GitHub.

He deixat el repositori com a públic, ja que així es pot publicar més fàcilment com a web utilitzant GitHub Pages.

## Ús de GitHub Desktop

GitHub Desktop m'ha servit per gestionar els canvis del repositori d'una manera visual i senzilla, sense haver d'escriure comandes de Git a la terminal.

El flux de treball que he seguit ha estat:

1. Crear o modificar arxius en local.
2. Revisar els canvis a GitHub Desktop.
3. Escriure un missatge de commit.
4. Fer `Commit to main`.
5. Fer `Push origin` per pujar els canvis a GitHub.

Un `commit` serveix per guardar una versió dels canvis dins del repositori local. En canvi, el `push` serveix per enviar aquests canvis al repositori remot de GitHub. Per tant, fins que no es fa `Push origin`, els canvis només estan guardats al meu ordinador.

## Ús d'Obsidian per als arxius Markdown

Per redactar les entrades del bloc he utilitzat Obsidian. He obert la carpeta del repositori `Projecte-Entorns` com una bóveda d'Obsidian.

Això m'ha permès crear i editar els arxius `.md` directament dins del repositori local. D'aquesta manera, els canvis fets amb Obsidian apareixen automàticament a GitHub Desktop i es poden pujar a GitHub.

Els arxius Markdown principals que he creat són:

- `index.md`
- `entrada1-github.md`
- `entrada2-dni.md`

El fitxer `index.md` funciona com a pàgina principal del bloc. Des d'aquest arxiu es pot accedir a les dues entrades creades per a l'activitat.

## Modificació de l'arxiu .gitignore

Quan he obert el projecte amb Obsidian, s'ha creat una carpeta interna anomenada `.obsidian`. Aquesta carpeta guarda configuracions pròpies d'Obsidian, com ara preferències de l'espai de treball.

Com que aquesta carpeta no forma part del contingut real del bloc, he modificat l'arxiu `.gitignore` per evitar que es pugi a GitHub.

Dins de l'arxiu `.gitignore` he afegit aquesta línia:

```gitignore
.obsidian/
```

Això indica a Git que ignori la carpeta `.obsidian` i que no la inclogui en els commits. D'aquesta manera, al repositori només es pugen els arxius importants de la pràctica i no la configuració personal d'Obsidian.

## Estructura del projecte

L'estructura principal del repositori és aquesta:

```text
Projecte-Entorns/
│
├── index.md
├── entrada1-github.md
├── entrada2-dni.md
├── .gitignore
│
├── ProgramaDNI/
│   └── Program.cs
```

La carpeta `ProgramaDNI` conté l'arxiu `Program.cs`, que és el codi font del programa fet en C# per calcular la lletra del DNI. Aquest programa s'explica amb més detall a la segona entrada del bloc.

## Publicació amb GitHub Pages

Després de pujar els arxius a GitHub, he activat GitHub Pages des de la configuració del repositori.

Per fer-ho, he anat a:

```text
Settings → Pages
```

I he configurat la publicació amb aquestes opcions:

```text
Source: Deploy from a branch
Branch: main
Folder: / (root)
```

Aquesta configuració fa que GitHub Pages publiqui com a web el contingut que es troba a la branca `main`, concretament a l'arrel del repositori.

Com que el fitxer `index.md` està a l'arrel del projecte, aquest fitxer actua com a pàgina principal del bloc.

## Comprovació final

Finalment, he comprovat que el bloc s'ha publicat correctament amb GitHub Pages. La pàgina principal mostra els enllaços cap a les dues entrades:

- Entrada 1: Creació, configuració i ús de GitHub
- Entrada 2: Programa en C# per calcular la lletra del DNI

També he comprovat que els enllaços entre els arxius Markdown funcionen correctament i que es pot accedir al codi font del programa C# dins de la carpeta `ProgramaDNI` amb l'enllaç.

## Conclusió

Aquesta part de l'activitat m'ha servit per entendre millor com funciona GitHub i com es pot utilitzar per guardar i publicar projectes.

He après a crear un repositori, publicar-lo a GitHub, treballar amb GitHub Desktop, redactar arxius Markdown amb Obsidian, ignorar carpetes innecessàries amb `.gitignore`, fer commits, pujar els canvis amb `Push origin` i publicar una web senzilla amb GitHub Pages.

Considero que aquest procés és útil perquè permet documentar pràctiques, guardar codi font i començar a crear un petit portafoli de projectes.