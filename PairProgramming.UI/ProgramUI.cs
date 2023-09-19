using PairProgramming.Data.Entities;
using PairProgramming.Repository.StarWarsCharacterRepository;
using static System.Console;
// using consoleGame.PairProgramming.Repository.ProjectItemRepository;
// using consoleGame.PairProgramming.Data.Entities;

namespace consoleGame.PairProgramming.UI
{
    public class ProgramUI
    {

        // private readonly ProjectItemRepo _projRepo = new ProjectItemRepo();
        private readonly StarwarsCharacterRepo _swCharRepo = new StarwarsCharacterRepo();
        StarWarsCharacter chewbacca;
        StarWarsCharacter lukeSkywalker;
        StarWarsCharacter hanSolo;
        StarWarsCharacter princessLeia;
        StarWarsCharacter darthVader;
        StarWarsCharacter darthJarJar;
        private bool isMenu;

        public ProgramUI()
        {
            chewbacca = _swCharRepo.GetStarWarsCharacter("Chewbacca");
            lukeSkywalker = _swCharRepo.GetStarWarsCharacter("Luke Skywalker");
            hanSolo = _swCharRepo.GetStarWarsCharacter("Han Solo");
            princessLeia = _swCharRepo.GetStarWarsCharacter("Princess Leia");
            darthVader = _swCharRepo.GetStarWarsCharacter("Darth Vader");
            darthJarJar = _swCharRepo.GetStarWarsCharacter("Darth Jar Jar");
        }
        public void Run()
        {
            RunApplication();
        }

        private void RunApplication()
        {
            isMenu = true;
            while (isMenu)
            {
                // game code goes here
                System.Console.WriteLine("Welcome to StarWars Fight Game\n" +
                "1. Start Game\n" +
                "2. exit app\n");

                string userInput = ReadLine()!;

                switch (userInput)
                {
                    case "1":
                        StartGame();
                        break;
                    case "2":
                        ExitApplication();
                        break;

                    default:
                        WriteLine("invalid selection");
                        break;
                }
            }
        }

        private void StartGame()
        {
            Clear();
            WriteLine("Choose you character" +
           $"1. {lukeSkywalker}" +
           $"2. {princessLeia}" +
           $"3. {hanSolo}" +
           $"4. {chewbacca}");

           string userInput = ReadLine()!;

           switch (userInput)
           {
            case "1":
                LukeStory();
                break;
            case "2":
                LeiaStory();
                break;
            case "3":
                HanChewStory();
                break;
            case "4":
                HanChewStory();
                break;
           }
           
        }

        private bool ExitApplication()
        {
            
        
            Clear();
            WriteLine("Thanks for playing");
            ReadKey();
            return false;
        }
        
        private void LukeStory()
        {
            Clear();
            WriteLine("");

        }
        private void LeiaStory()
        {
            Clear();
            WriteLine("test");

        }
        private void HanChewStory()
        {
            Clear();
            WriteLine("test");

        }
       

    }
}