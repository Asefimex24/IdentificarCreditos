using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Identifica.Logica
{
    public class LNoIdentificados
    {
        public DataTable iniciaNoIdentificados() {

            DataTable Noident  = new DataTable("NoIdentificados");
            //add columnas al datatable
            DataColumn A1 = new DataColumn("A1");
            DataColumn Referencia = new DataColumn("Referencia");
            DataColumn fecha = new DataColumn("fecha");
            DataColumn A2 = new DataColumn("A2");
            DataColumn Monto = new DataColumn("Monto");
            DataColumn Centavos = new DataColumn("Centavos");
            DataColumn A3 = new DataColumn("A3");

            Noident.Columns.Add(A1);
            Noident.Columns.Add(Referencia);
            Noident.Columns.Add(fecha);
            Noident.Columns.Add(A2);
            Noident.Columns.Add(Monto);
            Noident.Columns.Add(Centavos);
            Noident.Columns.Add(A3);
            return Noident;
        }
    }
}
