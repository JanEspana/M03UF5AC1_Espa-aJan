using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace M03UF5AC1_EspañaJan
{
    public class Score
    {
        public string? player { get; set; }
        public string? mission { get; set; }
        public int score { get; set; }
        public void GetPlayer()
        {
            Console.WriteLine();
            Console.WriteLine("Introduce el nombre del jugador: ");
            player = Console.ReadLine();
            if (!PlayerRegex(player))
            {
                Console.WriteLine("El nombre del jugador no es válido.");
                GetPlayer();
            }
        }
        public void GetMission()
        {
            Console.WriteLine();
            Console.WriteLine("Introduce la misión: ");
            mission = Console.ReadLine();
            if (!MissionRegex(mission))
            {
                Console.WriteLine("La misión no es válida.");
                GetMission();
            }
        }
        public void GetScore()
        {
            Console.WriteLine();
            Console.WriteLine("Introduce la puntuación: ");
            try
            {
                score = Convert.ToInt32(Console.ReadLine());
                if (!ScoreRegex(score))
                {
                    Console.WriteLine("La puntuación no es válida.");
                    GetScore();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("La puntuación no es válida.");
                GetScore();
            }
        }

        public bool PlayerRegex(string player)
        {
            Regex regex = new Regex(@"^[a-zA-Z]+$");
            return regex.IsMatch(player);
        }
        public bool MissionRegex(string mission)
        {
            Regex regex = new Regex(@"^(Beta|Gamma|Delta|Zeta|Theta|Kappa|Lambda|Mi|Ni|Ksi|Rho|Sigma|Tau|Fi|Khi|Psi)-[0-9]{3}$");
            return regex.IsMatch(mission);
        }
        public bool ScoreRegex(int score)
        {
            if (score >= 0 && score <= 500)
            {
                return true;
            }
            return false;
        }
    }
}
