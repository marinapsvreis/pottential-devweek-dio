namespace src.Models;
using System.Collections.Generic;
public class Pessoa
{
  public int Id { get; set; }
  public string Nome { get; set; }
  public int Idade { get; set; }
  public string? Cpf { get; set; } // interrogação depois do tipo significa que aceita o valor nulo.
  public bool Ativado { get; set; }
  public List<Contrato> Contratos { get; set; } = new List<Contrato>();

  public Pessoa()
  {

  }

  public Pessoa(string nome, int idade, string cpf)
  {
    Nome = nome;
    Idade = idade;
    Cpf = cpf;
    Ativado = true;
  }
}