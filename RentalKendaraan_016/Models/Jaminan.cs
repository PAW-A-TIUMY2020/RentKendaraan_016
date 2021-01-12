using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_016.Models
{
    public partial class Jaminan
    {
        public Jaminan()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdJaminan { get; set; }
        [Required(ErrorMessage = "Nama jaminan tidak boleh kosong")]
        public string NamaJaminan { get; set; }

        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
