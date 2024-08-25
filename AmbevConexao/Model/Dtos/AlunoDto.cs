using System.Text.Json.Serialization;

namespace AmbevConexao.Model.Dtos;

public class AdicionarAlunoDto
{
    public string Nome{ get; set; }
    public string Endereco{ get; set; }
    public string Email{ get; set; }
}

public class AlterarAlunoDto
{
    [JsonIgnore]
    public int? Id{ get; set; }
    public string? Nome{ get; set; }
    public string? Endereco{ get; set; }
    public string? Email{ get; set; }
}
