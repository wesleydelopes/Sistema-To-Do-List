using System;

namespace to_do_list
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskList taskList = new TaskList();

            while (true)
            {
                Console.WriteLine("To-Do List:");
                taskList.ListTasks();

                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Adicionar tarefa");
                Console.WriteLine("2 - Editar tarefa");
                Console.WriteLine("3 - Marcar tarefa como concluída");
                Console.WriteLine("4 - Remover tarefa");
                Console.WriteLine("5 - Salvar tarefas em um arquivo");
                Console.WriteLine("6 - Carregar tarefas de um arquivo");
                Console.WriteLine("7 - Sair");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Digite a nova tarefa: ");
                        string newTask = Console.ReadLine();
                        taskList.AddTask(newTask);
                        break;

                    case "2":
                        Console.Write("Digite o número da tarefa que deseja editar: ");
                        if (int.TryParse(Console.ReadLine(), out int editIndex) && editIndex >= 0 && editIndex < taskList.Count)
                        {
                            Console.Write("Digite a nova descrição da tarefa: ");
                            string newDescription = Console.ReadLine();
                            taskList.EditTask(editIndex, newDescription);
                        }
                        else
                        {
                            Console.WriteLine("Índice inválido.");
                        }
                        break;

                    case "3":
                        Console.Write("Digite o número da tarefa concluída: ");
                        if (int.TryParse(Console.ReadLine(), out int completeIndex) && completeIndex >= 0 && completeIndex < taskList.Count)
                        {
                            taskList.MarkTaskAsCompleted(completeIndex);
                        }
                        else
                        {
                            Console.WriteLine("Índice inválido.");
                        }
                        break;

                    case "4":
                        Console.Write("Digite o número da tarefa que deseja remover: ");
                        if (int.TryParse(Console.ReadLine(), out int removeIndex) && removeIndex >= 0 && removeIndex < taskList.Count)
                        {
                            taskList.RemoveTask(removeIndex);
                        }
                        else
                        {
                            Console.WriteLine("Índice inválido.");
                        }
                        break;

                    case "5":
                        Console.Write("Digite o nome do arquivo para salvar as tarefas: ");
                        string saveFileName = Console.ReadLine();
                        taskList.SaveTasksToFile(saveFileName);
                        break;

                    case "6":
                        Console.Write("Digite o nome do arquivo para carregar as tarefas: ");
                        string loadFileName = Console.ReadLine();
                        taskList.LoadTasksFromFile(loadFileName);
                        break;

                    case "7":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}
