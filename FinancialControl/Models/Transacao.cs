using System.ComponentModel.DataAnnotations;

namespace FinancialControl.Models {
    public class Transacao {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate{ get; set; }
        public string nameBank{ get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
    }
}
