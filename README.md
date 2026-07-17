# Fred Oracle PostgreSQL Data Compare application

Application Windows développée en C# avec WinForms pour comparer des données entre une base Oracle et une base PostgreSQL.

## Description

Ce projet fournit une interface graphique permettant de se connecter à deux sources de données distinctes, d’exécuter une comparaison de contenu et d’identifier les différences entre les jeux de données.

## Fonctionnalités

- Connexion à une base Oracle
- Connexion à une base PostgreSQL
- Comparaison de données entre les deux systèmes
- Interface utilisateur simple basée sur Windows Forms
- Support de logging via log4net

## Prérequis

- Visual Studio avec support .NET Framework 4.8
- Accès aux bases Oracle et PostgreSQL à comparer
- Paquets NuGet restaurés depuis le fichier packages.config

## Compilation

1. Ouvrez la solution FredOraclePostgreSQLDataCompare.sln
2. Restaurez les dépendances NuGet
3. Compilez le projet en mode Debug ou Release

## Utilisation

1. Démarrez l’application
2. Configurez les paramètres de connexion pour Oracle et PostgreSQL
3. Lancez la comparaison et consultez les résultats

## Technologies utilisées

- C# / .NET Framework 4.8
- Windows Forms
- Oracle ManagedDataAccess
- Npgsql
- log4net

## Licence

Ce projet est distribué sous la licence indiquée dans le fichier LICENSE.txt.
