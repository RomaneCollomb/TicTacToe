using System;

class TicTacToe
{
    static char[] board = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }; // Tableau pour afficher le jeu
    static int player = 1; // Le joueur actuel (1 ou 2)
    static int choice; // Le choix du joueur
    static int flag = 0; // 0 = aucun gagnant, 1 = joueur 1, 2 = joueur 2
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenue dans le jeu Tic-Tac-Toe !");
        Console.WriteLine("Joueur 1 (X) contre Joueur 2 (O)");
        Console.WriteLine("Le premier joueur à aligner 3 symboles gagne !");
        
        do
        {
            Console.Clear();
            DisplayBoard(); // Afficher l'état actuel du plateau de jeu
            player = (player % 2) + 1; // Alterner entre les joueurs 1 et 2
            Console.WriteLine("Joueur {0}, entrez un numéro pour placer votre symbole (1-9) : ", player);
            choice = int.Parse(Console.ReadLine());
            
            // Vérifier si l'emplacement choisi est valide
            if (choice < 1 || choice > 9 || board[choice] == 'X' || board[choice] == 'O')
            {
                Console.WriteLine("Emplacement invalide ! Appuyez sur une touche pour réessayer...");
                Console.ReadLine();
                continue;
            }

            // Placer le symbole sur le plateau
            board[choice] = player == 1 ? 'X' : 'O';

            // Vérifier si un joueur a gagné
            flag = CheckWin();

        } while (flag != 1 && flag != 2); // Continuer tant qu'il n'y a pas de gagnant

        Console.Clear();
        DisplayBoard();
        Console.WriteLine("Félicitations, Joueur {0} a gagné !", player);
        Console.ReadLine();
    }

    // Fonction pour afficher le plateau de jeu
    static void DisplayBoard()
    {
        Console.WriteLine(" {0} | {1} | {2} ", board[1], board[2], board[3]);
        Console.WriteLine("---|---|---");
        Console.WriteLine(" {0} | {1} | {2} ", board[4], board[5], board[6]);
        Console.WriteLine("---|---|---");
        Console.WriteLine(" {0} | {1} | {2} ", board[7], board[8], board[9]);
    }

    // Fonction pour vérifier si un joueur a gagné
    static int CheckWin()
    {
        #region Vérifier les lignes
        // Vérifier les lignes horizontales
        if (board[1] == board[2] && board[2] == board[3])
            return player == 1 ? 1 : 2;
        if (board[4] == board[5] && board[5] == board[6])
            return player == 1 ? 1 : 2;
        if (board[7] == board[8] && board[8] == board[9])
            return player == 1 ? 1 : 2;
        #endregion

        #region Vérifier les colonnes
        // Vérifier les colonnes verticales
        if (board[1] == board[4] && board[4] == board[7])
            return player == 1 ? 1 : 2;
        if (board[2] == board[5] && board[5] == board[8])
            return player == 1 ? 1 : 2;
        if (board[3] == board[6] && board[6] == board[9])
            return player == 1 ? 1 : 2;
        #endregion

        #region Vérifier les diagonales
        // Vérifier les diagonales
        if (board[1] == board[5] && board[5] == board[9])
            return player == 1 ? 1 : 2;
        if (board[3] == board[5] && board[5] == board[7])
            return player == 1 ? 1 : 2;
        #endregion

        return 0; // Aucun gagnant
    }
}
