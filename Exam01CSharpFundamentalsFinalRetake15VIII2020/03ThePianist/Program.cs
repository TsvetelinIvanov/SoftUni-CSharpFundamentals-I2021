using System;
using System.Collections.Generic;
using System.Linq;

namespace _03ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string[]> pieces = new Dictionary<string, string[]>();
            int piecesCountN = int.Parse(Console.ReadLine());
            for (int i = 0; i < piecesCountN; i++)
            {
                string[] pieceData = Console.ReadLine().Split('|');
                string pieceName = pieceData[0];
                string pieceComposer = pieceData[1];
                string pieceKey = pieceData[2];
                pieces.Add(pieceName, new string[] { pieceComposer, pieceKey});
            }

            string pieceCommandLineString;
            while ((pieceCommandLineString = Console.ReadLine()) != "Stop")
            {
                string[] pieceCommandLine = pieceCommandLineString.Split('|');
                string pieceCommand = pieceCommandLine[0];
                string[] pieceArguments = pieceCommandLine.Skip(1).ToArray();
                string message;
                switch (pieceCommand)
                {
                    case "Add":
                        message = TryAddPiece(pieces, pieceArguments);
                        break;
                    case "Remove":
                        message = TryRemovePiece(pieces, pieceArguments);
                        break;
                    case "ChangeKey":
                        message = TryChangePieceKey(pieces, pieceArguments);
                        break;
                    default:
                        throw new ArgumentException("Invalid command!");
                }

                Console.WriteLine(message);
            }

            foreach (KeyValuePair<string, string[]> piece in pieces.OrderBy(p => p.Key).ThenBy(p => p.Value[0]))
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value[0]}, Key: {piece.Value[1]}");
            }
        }

        private static string TryAddPiece(Dictionary<string, string[]> pieces, string[] pieceArguments)
        {            
            string pieceName = pieceArguments[0];
            string pieceComposer = pieceArguments[1];
            string pieceKey = pieceArguments[2];

            if (pieces.ContainsKey(pieceName))
            {
                return pieceName + " is already in the collection!";
            }

            pieces.Add(pieceName, new string[] { pieceComposer, pieceKey });

            return $"{pieceName} by {pieceComposer} in {pieceKey} added to the collection!";
        }

        private static string TryRemovePiece(Dictionary<string, string[]> pieces, string[] pieceArguments)
        {
            string pieceName = pieceArguments[0];
            if (pieces.Remove(pieceName))
            {
                return $"Successfully removed {pieceName}!";
            }
            else
            {
                return $"Invalid operation! {pieceName} does not exist in the collection.";
            }            
        }

        private static string TryChangePieceKey(Dictionary<string, string[]> pieces, string[] pieceArguments)
        {
            string pieceName = pieceArguments[0];
            string pieceKey = pieceArguments[1];
            if (!pieces.ContainsKey(pieceName))
            {
                return $"Invalid operation! {pieceName} does not exist in the collection.";
            }

            pieces[pieceName][1] = pieceKey;

            return $"Changed the key of {pieceName} to {pieceKey}!";
        }
    }
}