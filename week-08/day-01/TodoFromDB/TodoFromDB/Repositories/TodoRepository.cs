﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoFromDB.Entities;
using TodoFromDB.Models;

namespace TodoFromDB.Repositories
{
    public class TodoRepository
    {
        public TodoRepository(TodoContext todoContext)
        {
            TodoContext = todoContext;
        }

        public TodoContext TodoContext { get; set; }

        public List<Todo> ListOfToDos()
        {
            List<Todo> ListOfToDos = new List<Todo>();

            foreach (var item in TodoContext.Todos)
            {
                ListOfToDos.Add(item);
            }

            return ListOfToDos;
        }

        public void AddTodo(Todo todo)
        {
            TodoContext.Add(todo);
            TodoContext.SaveChanges();
        }

        public void DeletTodo(long id)
        {
            var RemoveList = TodoContext.Todos.FirstOrDefault(t => t.Id == id);
            if (RemoveList != null)
            {
                TodoContext.Todos.Remove(RemoveList);
            }
            TodoContext.SaveChanges();
        }

    }
}
