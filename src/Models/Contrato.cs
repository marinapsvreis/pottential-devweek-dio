namespace src.Models;

public class Contrato
{
  public int Id { get; set; }
  public DateTime DataCriacao { get; set; }
  public string TokenId { get; set; }
  public double Valor { get; set; }
  public bool Pago { get; set; }
  public int IdPessoa { get; set; }

  public Contrato(string tokenId, double valor)
  {
    DataCriacao = DateTime.Now;
    Valor = valor;
    TokenId = tokenId;
    Pago = false;
  }
}