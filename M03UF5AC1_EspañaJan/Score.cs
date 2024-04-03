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
        public int scoring { get; set; }
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
        public void GetScoring()
        {
            Console.WriteLine();
            Console.WriteLine("Introduce la puntuación: ");
            try
            {
                scoring = Convert.ToInt32(Console.ReadLine());
                if (!ScoreRegex(scoring))
                {
                    Console.WriteLine("La puntuación no es válida.");
                    GetScoring();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("El formato no es válido, debe ser un número");
                GetScoring();
            }
        }

        public bool PlayerRegex(string player)
        {
            Regex regex = new Regex(@"^[a-zA-Z]+$");
            return regex.IsMatch(player);
        }
        public bool MissionRegex(string mission)
        {
            Regex regex = new Regex(@"^(Alpha|Beta|Gamma|Delta|Epsilon|Zeta|Eta|Theta|Iota|Kappa|Lambda|Mu|Nu|Xi|Omicron|Pi|Rho|Sigma|Tau|Ypsilon|Phi|Chi|Psi|Omega)-[0-9]{3}$");
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
