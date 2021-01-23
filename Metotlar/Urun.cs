using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
     class Urun
    {
        public int Id { get; set; } //Datayı diğerlerinden ayırt etmek için kullanırız

        public string Adi { get; set; }

        public double Fiyati { get; set; }

        public string Açiklama { get; set; }

        public int StokAdedi { get; set; }
    }
}
// Burdakilerin hepsi Property 'dir yani özellikleri (Ürünün özellikleri)