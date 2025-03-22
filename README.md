# Tic Tac Toe 🏁 - Jeu en C

## Description

**Tic Tac Toe** est un jeu classique qui se joue sur une grille de 3x3 où deux joueurs (X et O) s'affrontent pour aligner trois de leurs symboles, soit horizontalement, verticalement ou diagonalement. Le premier joueur à aligner trois symboles gagne. Si la grille est pleine sans gagnant, la partie est déclarée nulle.

Ce jeu a été développé en **C** et permet de jouer en mode console avec des commandes simples.

## Fonctionnalités

- **Jeu à deux joueurs** : Les joueurs alternent pour placer leur symbole sur la grille.
- **Vérification du gagnant** : Le jeu vérifie après chaque tour si un joueur a gagné ou si la partie est terminée par un match nul.
- **Interface en ligne de commande** : Le jeu s'exécute dans le terminal avec une interface textuelle.
- **Rejouer** : Une fois la partie terminée, il est possible de recommencer une nouvelle partie.

## Comment jouer

1. Clonez ou téléchargez ce projet sur votre machine.
2. Ouvrez une fenêtre de terminal et compilez le fichier source avec le compilateur C.
3. Lancez le jeu en exécutant le fichier compilé.
4. À chaque tour, entrez un numéro entre 1 et 9 pour choisir où placer votre symbole (X ou O) sur la grille.
5. Le jeu vérifiera automatiquement si un joueur a gagné ou si la partie est terminée par un match nul.
6. À la fin de chaque partie, vous pourrez choisir de recommencer une nouvelle partie.

## Compilation et exécution

### Prérequis

- **Compilateur C** (comme `gcc` ou `clang`) installé sur votre machine.
- Système d'exploitation compatible avec la compilation C (Linux, macOS, Windows avec MinGW ou Cygwin).

### Étapes pour compiler et exécuter le jeu :

1. **Clonez ou téléchargez le projet.**

2. **Ouvrez un terminal dans le répertoire du projet.**

3. **Compilez le programme en utilisant `gcc` ou un autre compilateur C :**

   ```bash
   gcc -o tictactoe tictactoe.c```
   
4. **Exécutez le jeu avec la commande suivante :**
   ```bash
   ./tictactoe```

## Technologies utilisées :
- **Langage C** : Le jeu est développé en C, avec une interface console.
- **Logique du jeu** : Le code gère les entrées des joueurs, l'affichage de la grille, la vérification des conditions de victoire et la gestion des tours.

## Exemple d'exécution

Voici un exemple d'affichage du jeu :

 ```
Joueur X, entrez votre mouvement (1-9) : 5
 1 | 2 | 3
-----------
 4 | X | 6
-----------
 7 | 8 | 9

Joueur O, entrez votre mouvement (1-9) : 1
 X | 2 | 3
-----------
 4 | X | 6
-----------
 7 | O | 9
```

## Auteur : 
Romane Collomb
