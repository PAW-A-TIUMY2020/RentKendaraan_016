using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_016.Models
{
    public partial class Pengembalian
    {
        public int IdPengembalian { get; set; }
        [Required(ErrorMessage = "Tanggal Pengembalian tidak boleh kosong")]
        public DateTime? TglPengembalian { get; set; }

        [Required(ErrorMessage = "Peminjaman tidak boleh kosong")]
        public int? IdPeminjaman { get; set; }

        [Required(ErrorMessage = "Kondisi tidak boleh kosong")]
        public int? IdKondisi { get; set; }
        public int? Denda { get; set; }

        public KondisiKendaraan IdKondisiNavigation { get; set; }
        public Peminjaman IdPeminjamanNavigation { get; set; }
    }
}
