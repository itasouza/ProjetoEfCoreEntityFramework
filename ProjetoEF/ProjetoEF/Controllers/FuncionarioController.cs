using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoEF.Database;
using ProjetoEF.Models;

namespace ProjetoEF.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly ApplicationDbContext database;

        public FuncionarioController(ApplicationDbContext database)
        {
            this.database = database;
        }

        public IActionResult Index()
        {
            var funcionarios = database.Funcionarios.ToList();
            return View(funcionarios);
        }


        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            Funcionario funcionario = database.Funcionarios.First(registro => registro.id == id); 
            return View("Cadastrar", funcionario);
        }


        public IActionResult Deletar(int id)
        {
            Funcionario funcionario = database.Funcionarios.First(registro => registro.id == id);
            database.Funcionarios.Remove(funcionario);
            database.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Salvar(Funcionario dados)
        {
            if(dados.id == 0)
            {
                database.Funcionarios.Add(dados);
            }
            else
            {
                Funcionario funcionario = database.Funcionarios.First(registro => registro.id == dados.id);
                funcionario.nome = dados.nome;
                funcionario.salario = dados.salario;
                funcionario.cpf = dados.cpf;
            }
            database.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}