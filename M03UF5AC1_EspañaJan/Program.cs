using System;
using System.CodeDom.Compiler;
namespace M03UF5AC1_EspañaJan
{
    public class Program
    {
        public static void Main()
        {
            List<Score> scoreList = new List<Score>();
            Console.WriteLine("---LISTA DE MISIONES---\n\n¡Bienvenido al listado de jugadores!");
            for (int i = 0; i < 3; i++)
            {
                Score score = new Score();
                score.GetPlayer();
                score.GetMission();
                score.GetScoring();
                scoreList.Add(score);
            }
            GenerateUniqueRanking(scoreList);
        }

        public static void GenerateUniqueRanking(List<Score> scoreList)
        {
            List<Score> scoreListUnique = new List<Score>();
            foreach (Score score in scoreList)
            {
                if (scoreListUnique.Any(x => x.player == score.player && x.mission == score.mission))
                {
                    Score scoreToUpdate = scoreListUnique.First(x => x.player == score.player && x.mission == score.mission);
                    if (scoreToUpdate.scoring < score.scoring)
                    {
                        scoreToUpdate.scoring = score.scoring;
                    }
                }
                else
                {
                    scoreListUnique.Add(score);
                }
            }
            Console.WriteLine("\n\n---RANKING---");
            scoreListUnique = scoreListUnique.OrderByDescending(x => x.scoring).ToList();
            foreach (Score score in scoreListUnique)
            {
                Console.WriteLine($"Jugador: {score.player}, Misión {score.mission} - Puntuación: {score.scoring}");
            }
        }
    }
}