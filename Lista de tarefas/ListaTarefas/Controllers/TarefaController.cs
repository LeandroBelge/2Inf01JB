using ListaTarefas.Models;
using Microsoft.AspNetCore.Mvc;

namespace ListaTarefas.Controllers;
public class TarefaController : Controller
{
    public List<Tarefa> listaTarefas = new();
    public IActionResult Index()
    {
        Tarefa tarefaUm = new(){ 
            Id = 1, Descricao = "Tarefa Um", Concluida = false };
        listaTarefas.Add(tarefaUm);
        Tarefa tarefaDois = new(){ 
            Id = 2, Descricao = "Tarefa Dois", Concluida = false };
        listaTarefas.Add(tarefaDois);
        return View(listaTarefas);
    }
}