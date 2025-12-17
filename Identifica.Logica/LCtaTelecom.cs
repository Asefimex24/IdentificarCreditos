using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SpreadsheetLight;


namespace Identifica.Logica
{
    public class LCtaTelecom
    {
        public DataTable setTableTelecom() {

           DataTable TableCtaTelecomm = new DataTable("RepCtaTelecom");
            //add columnas al datatable
            DataColumn A1 = new DataColumn("A1");
            DataColumn Referencia = new DataColumn("Referencia");
            DataColumn fecha = new DataColumn("fecha");
            DataColumn A2 = new DataColumn("A2");
            DataColumn Monto = new DataColumn("Monto");
            DataColumn Centavos = new DataColumn("Centavos");
            DataColumn A3 = new DataColumn("A3");

            TableCtaTelecomm.Columns.Add(A1);
            TableCtaTelecomm.Columns.Add(Referencia);
            TableCtaTelecomm.Columns.Add(fecha);
            TableCtaTelecomm.Columns.Add(A2);
            TableCtaTelecomm.Columns.Add(Monto);
            TableCtaTelecomm.Columns.Add(Centavos);
            TableCtaTelecomm.Columns.Add(A3);

            return TableCtaTelecomm;
        }

        public DataTable iniciaTabletelecom() {
            DataTable telecm = new DataTable();
            return telecm;
        }

        public void loadCtaTelecom(DataTable tabla, SLDocument documento ) {
            
            int valorX = 3;
            //recorre cada fila del archivo de ctaTelecomm de acuerdo a los valores (posicion-fila , posicion-columna)
            while (!string.IsNullOrEmpty(documento.GetCellValueAsString(valorX, 3)))
            {
                //validar si hay centavos
                decimal monto = Convert.ToDecimal(documento.GetCellValueAsString(valorX, 5));
                decimal centavos = Convert.ToDecimal(documento.GetCellValueAsString(valorX, 6));

                if (centavos > 0)
                {
                    monto = monto + (centavos / 100);
                }
                //agrega cada fila del archivo edo cta telecom al datatable
                tabla.Rows.Add(documento.GetCellValueAsString(valorX, 1), documento.GetCellValueAsString(valorX, 2), documento.GetCellValueAsDateTime(valorX, 3).ToShortDateString(), documento.GetCellValueAsString(valorX, 4), monto.ToString(), documento.GetCellValueAsString(valorX, 6), documento.GetCellValueAsString(valorX, 7));

                valorX++;
            }
        }
    }
}
