using System;
using System.Collections.Generic;
using System.IO;

namespace to_do_list
{
    class TaskList
    {
        private List<string> tasks = new List<string>();

        public int Count => tasks.Count;

        public void AddTask(string task)
        {
            tasks.Add(task);
            Console.WriteLine("Tarefa adicionada com sucesso!");
        }

        public void EditTask(int index, string newDescription)
        {
            tasks[index] = newDescription;
            Console.WriteLine("Tarefa editada com sucesso!");
        }

        public void MarkTaskAsCompleted(int index)
        {
            tasks.RemoveAt(index);
            Console.WriteLine("Tarefa marcada como concluída!");
        }

        public void RemoveTask(int index)
        {
            tasks.RemoveAt(index);
            Console.WriteLine("Tarefa removida com sucesso!");
        }

        public void ListTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa pendente.");
            }
            else
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i}. {tasks[i]}");
                }
            }
        }

        public void SaveTasksToFile(string fileName)
        {
            File.WriteAllLines(fileName, tasks);
            Console.WriteLine("Tarefas salvas com sucesso no arquivo.");
        }

        public void LoadTasksFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                tasks = new List<string>(File.ReadAllLines(fileName));
                Console.WriteLine("Tarefas carregadas com sucesso do arquivo.");
            }
            else
            {
                Console.WriteLine("O arquivo especificado não existe.");
            }
        }
    }
}
