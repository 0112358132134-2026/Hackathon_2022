using System;
namespace Solución
{
    class Funciones
    {
        public bool Scramble(string cadena_1, string cadena_2) {

            if (cadena_1.Length != cadena_2.Length) {
                return false;
            }

            for (int contador = 0; contador < cadena_1.Length; contador++)
            {
                if (cadena_2[0].Equals(cadena_1[contador]))
                {
                    cadena_1 = cadena_1.Remove(contador,1);
                    cadena_2 = cadena_2.Remove(0,1);
                    contador = -1;
                }
                if ((contador == cadena_1.Length - 1) && (cadena_1.Length != 0 && cadena_2.Length != 0)) {
                    return false;
                }
            }
            return true;
        }

        public string CadenasSubsecuentes(string cadena_1, string cadena_2) {

            for (int i = 0; i < cadena_1.Length; i++) {
                if (cadena_2.Contains(cadena_1[i])){

                }
            }
            return "vacío";
        }

        public int AbuelaBinaria(int N, int numero_1, int numero_2) {
            if (numero_1 + numero_2 != N) {
                return -1;
            }
            string binario_1 = Convert.ToString(numero_1, 2);
            string binario_2 = Convert.ToString(numero_2,2);
            string binarios =  binario_1 + binario_2;
            string comparar = "10";
            int cantidadUnos = 0;
            for (int i = 0; i < binarios.Length; i++) {
                if (binarios[i].Equals(comparar[0]))
                {
                    cantidadUnos += 1;
                }
            }            
            return cantidadUnos;
        }
    }
}