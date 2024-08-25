using System.Text.Json.Serialization;

namespace AmbevConexao.Model.Dtos;

public class AdicionarCursoDto
{
    public string Titulo { get; set; }
    public string Descricao { get; set; }
}

public class IniciarCursoDto
{
    [JsonIgnore]
    public int Id { get; set; }
    public int IdProfessor { get; set; }
    public DateTime DataInicio { get; set; }
}
