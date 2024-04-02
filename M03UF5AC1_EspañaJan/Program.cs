using System;
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
                score.GetScore();
                scoreList.Add(score);
            }
        }
    }
}