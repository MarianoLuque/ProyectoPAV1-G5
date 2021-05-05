using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PAV1_G5.Clases
{
    class Grid01 : DataGridView
    {
        /// <summary>
        /// Esta función permite darle a la grilla el siguiente formato
        /// dentro del parametro de entrada como texto:
        /// (textoCabecera, ancho; ...; textCabecera, ancho)
        /// </summary>
        /// <param name="formato"></param>
        public void Formatear(string formato) // para que el DataGridView tenga el formato, hago un estandar
        {
            string[] datos_Columna = formato.Split(';'); // dice que fraccione el ingreso en distintos indices (texto cabera+ancho)

            for (int i = 0; i < datos_Columna.Length; i++)
            {
                string[] datos = datos_Columna[i].Split(',');
                this.Columns.Add("columna" + i.ToString(), datos[0].ToString());
                // me obliga a poner el nombre de la columna y el texto del header
                this.Columns[i].Width = int.Parse(datos[1].ToString());
                // con esto se cual es el ancho de la columna porque esta en el segundo indice de la matriz datos
            }
        }
    }
}
