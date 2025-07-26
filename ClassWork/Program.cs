namespace ClassWork
{
    class Todo
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool IsComplete { get; set; }
    }
    
    
    
    internal class Program
    {
        static List<Todo> tasks = new List<Todo>();
        static int nextId = 1;


        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("===ToDo List===");
                Console.WriteLine("1.ToDo AddTask");
                Console.WriteLine("2.ToDo RemoveTask");
                Console.WriteLine("3.ToDo ShowTasks");
                Console.WriteLine("4.Exit");
                Console.WriteLine("Choice command:");

                string? command = Console.ReadLine();

                switch (command)
                {
                    case "1": AddTask(); break;
                    case "2": RemoveTask(); break;
                    case "3": ShowTasks(); break;
                    case "4": return;
                    default: Console.WriteLine("Choose properly command"); break;
                }
            }
            
            
        }
        static void AddTask()
        {
            Console.WriteLine("Enter title:");
            string title = Console.ReadLine()?.ToLower().Trim();
            Console.WriteLine("Enter description:");
            string? description = Console.ReadLine();

            tasks.Add(new Todo 
            { 
               Id = nextId++, 
               Title = title,
               Description=description,
               IsComplete=true
            });
        }
        static void RemoveTask()
        {
            Console.WriteLine("Enter Id Task:");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var task = tasks.Find(t => t.Id == id);
                if (task != null)
                {
                    tasks.Remove(task);
                    Console.WriteLine("Task removed.");
                }
                else Console.WriteLine("Task not found.");
            }

        }
        static void ShowTasks()
        {
            foreach (var t in tasks)
            {
                string status = t.IsComplete ? "yes" : "not found";
                Console.WriteLine($"{status} {t.Id}: {t.Title} - {t.Description}");
            }
        }




    }
    
    
}
