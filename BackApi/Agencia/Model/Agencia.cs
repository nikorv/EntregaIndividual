using System.ComponentModel.DataAnnotations.Schema;

namespace Agencia.Model
{
  [Table("clients")]
  public class Client
  {
    [Column("id")]
    public int Id { get; set; }

    [Column("client_name")]
    public string Name { get; set; } = string.Empty;

    [Column("client_datanasc")]
    public string DataNasc { get; set; } = string.Empty;
    
    [Column("client_email")]
    public string Email { get; set; } = string.Empty;

    [Column("client_phone")]
    public string Phone { get; set; } = string.Empty;

    [Column("client_iconeclient")]
    public string IconeClient { get; set; } = string.Empty;
    
  }
}