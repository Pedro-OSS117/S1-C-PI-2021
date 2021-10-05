# Introduction - Un peu d'histoire

https://fr.wikipedia.org/wiki/Histoire_de_l%27informatique

- Architecture Von Neumann
https://en.wikipedia.org/wiki/John_von_Neumann

- Transistor 0 et 1 - Le Binaire
https://en.wikipedia.org/wiki/Transistor

- Le compilateur - Transformer du texte en 0 et 1

- Langage Imperatif notamment le C 1970

- Langage Orienté Objet le C++ Java C#


Introduction à l’environnement .net
Ce chapitre donne les grandes lignes de la Plateforme .net (prononcé dot net).

Plateforme .net
La plateforme .net regroupe deux choses (à l’instar de Java) :

un environnement d’exécution appelé Common Langage Runtime (CLR);

le Framework .net : une bibliothèque de classes riches ou Application Programming Interface (API).

.net permet de créer des applications exécutables, des libraires (dll), des applications web (ASP.net), des scripts.

Il existe plusieurs implémentations du framework .net:

Microsoft .net: l’implémentation officielle et historique, disponible sous Windows (bureau, console xbox, téléphone);

Mono: implémentation libre initiallement développée par la société Xamarin pour pouvoir développer des applications mobiles multiplateformes (Android, Ios, Windows Phone). Aujourd’hui Mono est également utilisé comme plateforme de scripting, par exemple dans Unity 3D.

.net Core: récemment proposé par Microsoft afin de cibler les plateformes Unix, en particulier les serveurs.

Attention

Mono et .net Core n’implémentent pas l’intégralité de l’API .net. Par exemple .net Core, qui est destiné au développement de services Web tournant sur des serveurs, ne propose pas d’interface graphique.

Il existe différents langages (C#, VB.net, F#, C++) dans l’environnement .net qui peuvent cohabiter au sein d’un même projet grâce au Common Language Infrastructure (CLI) qui spécifie la base commune pour les langages .net. En particulier, le CLI repose sur un système de types de données communs, le Common Type System (CTS) qui définit des types primitifs et un schéma de construction de nouveaux types. Ainsi un nouveau type de données déclaré, par exemple en C#, sera utilisable dans les autres langages de .net.
