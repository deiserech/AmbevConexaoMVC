using System.Text.Json.Serialization;

namespace AmbevConexao.Model.Dtos;

public class AdicionarProfessorDto
{
    public string Nome { get; set; }
    public string Email { get; set; }
}

public class AlterarProfessorDto
{
    [JsonIgnore]
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Email { get; set; }
}

