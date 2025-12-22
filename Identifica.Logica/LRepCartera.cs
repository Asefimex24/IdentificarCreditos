using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SpreadsheetLight;
using IdentificaEntidades;

namespace Identifica.Logica
{
    public class LRepCartera
    {

        public DataTable setRepCarteraTable() {

            DataTable TableAnalitico = new DataTable("RepAnalitico");

            DataColumn numCredit = new DataColumn("credito");
            DataColumn nombCliente = new DataColumn("cliente");

            TableAnalitico.Columns.Add(numCredit);
            TableAnalitico.Columns.Add(nombCliente);

            return TableAnalitico;
        }

        public DataTable iniciaTableCartera() {
            DataTable cartera = new DataTable();
            return cartera;
        }


        public DataTable setTableSimilares() {
            DataTable repetidos = new DataTable("Repetidos");

            DataColumn numCredit = new DataColumn("credito");
            DataColumn nombCliente = new DataColumn("cliente");

            return repetidos;
        }

        public DataTable loadCartera(DataTable tabla, SLDocument documento) {

            DataTable cartera = tabla;
            int valorXCartera = 10;            
            //recorre cada fila del archivo excel y llena el DAtatable con los datos
            while (!string.IsNullOrEmpty(documento.GetCellValueAsString(valorXCartera, 2)))
            {
                //agrega las filas de excel al datatable
                cartera.Rows.Add(documento.GetCellValueAsString(valorXCartera, 2), documento.GetCellValueAsString(valorXCartera, 8));
                valorXCartera++;
            }
            return cartera;
        }

        public int buscaCredit(string credito,DataTable cartera)
        {
            int intento = 0;
            foreach (DataRow filaCartera in cartera.Rows)
            {   
                string creditCartera = Convert.ToString(filaCartera["credito"]);

                //extraer ultimos 4 digitos del credito
                string digitosCredito = credito.Substring(credito.Length - 5, 4);
                //extraer ultimos 4 digitos del credito en cartera
                string digitosCredCartera = creditCartera.Substring(creditCartera.Length - 5, 4);
                
                if (credito == creditCartera)
                {
                    intento = 1;
                    return intento;
                }
            }
            return intento;
        }


        //busca creditos parecidos en sus ultimos 4 dígitos
        public DataTable buscaRepetido(string credito, DataTable cartera) {
            
            DataTable repetidos = new DataTable("Repetidos");            

            DataColumn numCredit = new DataColumn("credito");
            DataColumn nombCliente = new DataColumn("cliente");

            foreach (DataRow filaCartera in cartera.Rows)
            {
                string creditCartera = Convert.ToString(filaCartera["credito"]);

                //extraer ultimos 4 digitos del credito
                string digitosCredito = credito.Substring(credito.Length - 5, 4);

                //extraer ultimos 4 digitos del credito en cartera
                string digitosCredCartera = creditCartera.Substring(creditCartera.Length - 5, 4);

                if (digitosCredito == digitosCredCartera) {

                    repetidos.Rows.Add(Convert.ToString(filaCartera["credito"]), Convert.ToString(filaCartera["cliente"]));

                }
            }
            return repetidos;
        }
    }
}
