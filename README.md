# Suivi des Changements d'État d'Objets

## Description

Ce projet implémente un **Système de Suivi des Changements d'État d'Objets d'utilisateur** Le système permet de suivre les modifications des objets Utilisateur et de conserver un historique détaillé des changements d'état pour chacun d'entre eux.
### Fonctionnalités :

- Suivi des changements d'état.
- Historique complet des modifications (ancien état, nouvel état, date du changement).
- Utilisation du **pattern Observer** pour une gestion des événements de changement d'état.

## Prérequis

- [.NET SDK](https://dotnet.microsoft.com/download) version 6.0 ou plus récente.

## Installation

# Clonez ce dépôt dans votre environnement de développement local.

# Restaurez les dépendances du projet :

        dotnet restore

Exécutez l'application

Le programme console affichera l'état initial, les changements d'état, et l'historique des modifications.

Program.cs
Le fichier Program.cs est le point d'entrée de l'application. Il crée les objets métiers, attache les observateurs, et modifie les états des objets. Le programme affiche ensuite l'historique des modifications dans la console.
