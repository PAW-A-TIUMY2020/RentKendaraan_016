using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_016.Models
{
    public partial class Peminjaman
    {
        public Peminjaman()
        {
            Pengembalian = new HashSet<Pengembalian>();
        }

        public int IdPeminjaman { get; set; }

        [Required(ErrorMessage = "Tanggal peminjaman harus diisi")]
        public DateTime? TglPeminjaman { get; set; }

        [Required(ErrorMessage = "Kendaraan tidak boleh kosong")]
        public int? IdKendaraan { get; set; }

        [Required(ErrorMessage = "Customer tidak boleh kosong")]
        public int? IdCustomer { get; set; }

        [Required(ErrorMessage = "Jaminan tidak boleh kosong")]
        public int? IdJaminan { get; set; }

        [Required(ErrorMessage = "Biaya tidak boleh kosong")]
        public int? Biaya { get; set; }

        public Customer IdCustomerNavigation { get; set; }
        public Jaminan IdJaminanNavigation { get; set; }
        public Kendaraan IdKendaraanNavigation { get; set; }
        public ICollection<Pengembalian> Pengembalian { get; set; }
    }
}
