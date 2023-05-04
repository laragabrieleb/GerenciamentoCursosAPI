using System.Text.Json.Serialization;

namespace CursosAPI.Domain.Entities
{
    /// <summary>
    /// registrar cursos
    /// </summary>
    public class EntidadeCursos
    {
        public int Id { get; set; }

        public DateTime DataRegistro { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public decimal Valor { get; set; }
    }
}
