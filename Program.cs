namespace dio_series{
    class Program{
        static SerieRepository serieRepository = new SerieRepository();

        public static void Main(string[] args){
            string userOption = GetUserOption();

            while(userOption != "X") {
                switch(userOption) {
                    case "1":
                        ListSeries();
                        break;
                    case "2":
                        AddSerie();
                        break;
                    case "3":
                        UpdateSerie();
                        break;
                    case "4":
                        DeleteSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }   
            }
        }

        public static void ListSeries() {
            Console.WriteLine("Listar Séries");

            var Lista = serieRepository.List();

            if(Lista.Count == 0) {
                Console.WriteLine("Não há séries cadastradas");
            } else {
                Console.WriteLine("Séries cadastradas");
                Console.WriteLine("----------------------------------------------------");
                foreach(var serie in Lista) {
                    Console.WriteLine($"Id: {serie.Id}");
                    Console.WriteLine($"Título: {serie.Title}");
                    Console.WriteLine($"Gênero: {serie.Genre}");
                    Console.WriteLine($"Ano: {serie.Year}");
                    Console.WriteLine("----------------------------------------------------");
                }
            }
        }

        public static void AddSeries() {
            Console.WriteLine("Adicionar Série");
            Console.WriteLine("----------------------------------------------------");
            Console.Write("Digite o título da série: ");
            string title = Console.ReadLine();
            Console.Write("Digite o gênero da série: ");
            string genre = Console.ReadLine();
            Console.Write("Digite o ano da série: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------");
            serieRepository.Insert(new Serie(serieRepository.NextId(), (Genre)Enum.Parse(typeof(Genre), genre), title, "", year));
        }

        public static void UpdateSeries() {
            Console.WriteLine("Atualizar Série");
            Console.WriteLine("----------------------------------------------------");
            Console.Write("Digite o id da série: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Digite o título da série: ");
            string title = Console.ReadLine();
            Console.Write("Digite o gênero da série: ");
            string genre = Console.ReadLine();
            Console.Write("Digite o ano da série: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------");
            serieRepository.Update(id, new Serie(id, (Genre)Enum.Parse(typeof(Genre), genre), title, "", year));
        }

        public static void DeleteSeries() {
            Console.WriteLine("Deletar Série");
            Console.WriteLine("----------------------------------------------------");
            Console.Write("Digite o id da série: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------");
            serieRepository.Delete(id);
        }

        private static string GetUserOption(){
            Console.WriteLine("1 - Listar Series");
            Console.WriteLine("2 - Inserir Serie");
            Console.WriteLine("3 - Atualizar Serie");
            Console.WriteLine("4 - Deletar Serie");
            Console.WriteLine("C - Limpar Console");
            Console.WriteLine("Digite a opção desejada: ");

            string option = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return option;
        }
    }
}
