using System;

class Program
{
    static char[,] board = new char[8, 8]
    {
        { 'R', 'N', 'B', 'Q', 'K', 'B', 'N', 'R' },
        { 'P', 'P', 'P', 'P', 'P', 'P', 'P', 'P' },
        { '.', '.', '.', '.', '.', '.', '.', '.' },
        { '.', '.', '.', '.', '.', '.', '.', '.' },
        { '.', '.', '.', '.', '.', '.', '.', '.' },
        { '.', '.', '.', '.', '.', '.', '.', '.' },
        { 'p', 'p', 'p', 'p', 'p', 'p', 'p', 'p' },
        { 'r', 'n', 'b', 'q', 'k', 'b', 'n', 'r' }
    };

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            PrintBoard();
            Console.Write("Ingrese la posición de origen (ej. e2): ");
            string from = Console.ReadLine();
            Console.Write("Ingrese la posición de destino (ej. e4): ");
            string to = Console.ReadLine();

            if (MovePiece(from, to))
            {
                Console.WriteLine("Movimiento realizado.");
            }
            else
            {
                Console.WriteLine("Movimiento inválido.");
            }
            Console.ReadLine();
        }
    }

    static void PrintBoard()
    {
        Console.WriteLine("  a b c d e f g h");
        for (int i = 0; i < 8; i++)
        {
            Console.Write(8 - i + " ");
            for (int j = 0; j < 8; j++)
            {
                Console.Write(board[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static bool MovePiece(string from, string to)
    {
        int fromRow = 8 - (from[1] - '0');
        int fromCol = from[0] - 'a';
        int toRow = 8 - (to[1] - '0');
        int toCol = to[0] - 'a';

        if (IsValidMove(fromRow, fromCol, toRow, toCol))
        {
            board[toRow, toCol] = board[fromRow, fromCol];
            board[fromRow, fromCol] = '.';
            return true;
        }
        return false;
    }

    static bool IsValidMove(int fromRow, int fromCol, int toRow, int toCol)
    {
        if (fromRow < 0 || fromRow >= 8 || fromCol < 0 || fromCol >= 8 ||
            toRow < 0 || toRow >= 8 || toCol < 0 || toCol >= 8)
        {
            return false;
        }

        char piece = board[fromRow, fromCol];
        char target = board[toRow, toCol];

        if (piece == '.') return false; 
        if (char.IsUpper(piece) == char.IsUpper(target)) return false; 

        switch (char.ToLower(piece))
        {
            case 'p': 
                return ValidatePawnMove(fromRow, fromCol, toRow, toCol, char.IsUpper(piece));
            case 'r':
                return ValidateRookMove(fromRow, fromCol, toRow, toCol);
            case 'n':
                return ValidateKnightMove(fromRow, fromCol, toRow, toCol);
            case 'b':
                return ValidateBishopMove(fromRow, fromCol, toRow, toCol);
            case 'q':
                return ValidateQueenMove(fromRow, fromCol, toRow, toCol);
            case 'k':
                return ValidateKingMove(fromRow, fromCol, toRow, toCol);
            default:
                return false;
        }
    }

    static bool ValidatePawnMove(int fromRow, int fromCol, int toRow, int toCol, bool isWhite)
    {
        int direction = isWhite ? -1 : 1;
        if (fromCol == toCol && board[toRow, toCol] == '.') 
        {
            if (toRow == fromRow + direction) return true;
            if ((isWhite && fromRow == 6 || !isWhite && fromRow == 1) && toRow == fromRow + 2 * direction && board[fromRow + direction, fromCol] == '.') return true;
        }
        else if (Math.Abs(fromCol - toCol) == 1 && toRow == fromRow + direction && board[toRow, toCol] != '.') 
        {
            return true;
        }
        return false;
    }

    static bool ValidateRookMove(int fromRow, int fromCol, int toRow, int toCol)
    {
        return (fromRow == toRow || fromCol == toCol) && IsPathClear(fromRow, fromCol, toRow, toCol);
    }

    static bool ValidateKnightMove(int fromRow, int fromCol, int toRow, int toCol)
    {
        int rowDiff = Math.Abs(fromRow - toRow);
        int colDiff = Math.Abs(fromCol - toCol);
        return (rowDiff == 2 && colDiff == 1) || (rowDiff == 1 && colDiff == 2);
    }

    static bool ValidateBishopMove(int fromRow, int fromCol, int toRow, int toCol)
    {
        return Math.Abs(fromRow - toRow) == Math.Abs(fromCol - toCol) && IsPathClear(fromRow, fromCol, toRow, toCol);
    }

    static bool ValidateQueenMove(int fromRow, int fromCol, int toRow, int toCol)
    {
        return ValidateRookMove(fromRow, fromCol, toRow, toCol) || ValidateBishopMove(fromRow, fromCol, toRow, toCol);
    }

    static bool ValidateKingMove(int fromRow, int fromCol, int toRow, int toCol)
    {
        return Math.Abs(fromRow - toRow) <= 1 && Math.Abs(fromCol - toCol) <= 1;
    }

    static bool IsPathClear(int fromRow, int fromCol, int toRow, int toCol)
    {
        int rowStep = Math.Sign(toRow - fromRow);
        int colStep = Math.Sign(toCol - fromCol);
        int r = fromRow + rowStep, c = fromCol + colStep;
        while (r != toRow || c != toCol)
        {
            if (board[r, c] != '.') return false;
            r += rowStep;
            c += colStep;
        }
        return true;
    }
}
