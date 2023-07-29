using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI2
{

   

    class Controller
    {
        public string mySeed;
        public string oppSeed;
        public string[] gameBoard = new string[9];
        public int totalMoves;



        public int[] AlphaBeta(string level, int depth, int alpha, int beta)
        {
            List<int> successors = SuccessorsGenerator();
            int score;
            int bestPosition = -1;
            int currentScore;
            if (depth == 0 || successors.Count == 0)
            {
                score = GetScore();
                return new int[] { score, bestPosition };
            }
            else
            {
                foreach (var succ in successors)
                {

                    gameBoard[succ] = level;
                    if (level == mySeed)
                    {
                        currentScore = AlphaBeta(InverseLevel(level), depth - 1, alpha, beta)[0];
                        if (currentScore > alpha)
                        {
                            alpha = currentScore;
                            bestPosition = succ;
                        }

                    }
                    else
                    {
                        currentScore = AlphaBeta(InverseLevel(level), depth - 1, alpha, beta)[0];
                        if (currentScore < beta)
                        {
                            beta = currentScore;
                            bestPosition = succ;
                        }
                    }
                    gameBoard[succ] = " ";
                    if (alpha >= beta) break;
                }

            }
            return new int[] { (level == mySeed) ? alpha : beta, bestPosition };
        }

        public int[] MiniMax(string level, int depth)
        {
            List<int> successors = SuccessorsGenerator();
            int bestScore = (level == mySeed) ? int.MinValue : int.MaxValue;
            int bestPosition = -1;
            int currentScore;
            if (depth == 0 || successors.Count == 0)
            {
                bestScore = GetScore();
            }
            else
            {
                foreach (var succ in successors)
                {

                    gameBoard[succ] = level;
                    if (level == mySeed)
                    {
                        currentScore = MiniMax(InverseLevel(level), depth - 1)[0];
                        if (currentScore > bestScore)
                        {
                            bestScore = currentScore;
                            bestPosition = succ;
                        }

                    }
                    else
                    {
                        currentScore = MiniMax(InverseLevel(level), depth - 1)[0];
                        if (currentScore < bestScore)
                        {
                            bestScore = currentScore;
                            bestPosition = succ;
                        }
                    }
                    gameBoard[succ] = " ";
                }

            }

            return new int[] { bestScore, bestPosition };
        }
        public string InverseLevel(string level)
        {
            totalMoves++;
            if (level == "o")
            {
                return "x";
            }
            return "o";
        }


        public List<int> SuccessorsGenerator()
        {
            List<int> successors = new List<int>();

            if (HasWon(mySeed) || HasWon(oppSeed))
            {
                return successors;
            }
            for (int i = 0; i < 9; i++)
            {
                if (gameBoard[i] == " ")
                {
                    successors.Add(i);
                }
            }
            return successors;
        }


        public int GetScore()
        {
            int score = 0;
            score += GetScoreFromLine(0, 1, 2);
            score += GetScoreFromLine(3, 4, 5);
            score += GetScoreFromLine(6, 7, 8);
            score += GetScoreFromLine(0, 3, 6);
            score += GetScoreFromLine(1, 4, 7);
            score += GetScoreFromLine(2, 5, 8);
            score += GetScoreFromLine(0, 4, 8);
            score += GetScoreFromLine(2, 4, 6);
            return score;

        }
        public int GetScoreFromLine(int cell1, int cell2, int cell3)
        {
            int score = 0;
            if (gameBoard[cell1] == " " && gameBoard[cell2] == " " && gameBoard[cell3] == " ")
            {
                return 0;
            }
            if ((gameBoard[cell1] == mySeed) || (gameBoard[cell1] == " "))
            {
                if ((gameBoard[cell2] == mySeed) || (gameBoard[cell2] == " "))
                {
                    if ((gameBoard[cell3] == mySeed) || (gameBoard[cell2] == " "))
                    {
                        score += 1;
                    }
                }
            }
            if ((gameBoard[cell1] == oppSeed) || (gameBoard[cell1] == " "))
            {
                if ((gameBoard[cell2] == oppSeed) || (gameBoard[cell2] == " "))
                {
                    if ((gameBoard[cell3] == oppSeed) || (gameBoard[cell2] == " "))
                    {
                        score += -1;
                    }
                }
            }
            if((gameBoard[cell1] == oppSeed)&& (gameBoard[cell2] == oppSeed)&& (gameBoard[cell3] == oppSeed))
            {
                score += -10;
            }
            if ((gameBoard[cell1] == mySeed) && (gameBoard[cell2] == mySeed) && (gameBoard[cell3] == mySeed))
            {
                score += 10;
            }
            return score;
        }
        public bool HasWon(string seed)
        {
            if ((gameBoard[0].ToLower() == seed && gameBoard[1].ToLower() == seed && gameBoard[2].ToLower() == seed) ||//3 lines
                (gameBoard[3].ToLower() == seed && gameBoard[4].ToLower() == seed && gameBoard[5].ToLower() == seed) ||
                (gameBoard[6].ToLower() == seed && gameBoard[7].ToLower() == seed && gameBoard[8].ToLower() == seed) ||
                (gameBoard[0].ToLower() == seed && gameBoard[3].ToLower() == seed && gameBoard[6].ToLower() == seed) ||//3 rows
                (gameBoard[1].ToLower() == seed && gameBoard[4].ToLower() == seed && gameBoard[7].ToLower() == seed) ||
                (gameBoard[2].ToLower() == seed && gameBoard[5].ToLower() == seed && gameBoard[8].ToLower() == seed) ||
                (gameBoard[0].ToLower() == seed && gameBoard[4].ToLower() == seed && gameBoard[8].ToLower() == seed) ||//2 diagonals
                (gameBoard[6].ToLower() == seed && gameBoard[4].ToLower() == seed && gameBoard[2].ToLower() == seed))
            {
                return true;


            }
            return false;
        }
        public bool areSomeSpacesLeft()
        {
            int counter = 0;
            for (int i = 0; i < 9; i++)
            {
                if (gameBoard[i] == " ")
                    counter++;
            }
            if (counter > 0)
                return true;
            return false;
        }
    }


    
}
