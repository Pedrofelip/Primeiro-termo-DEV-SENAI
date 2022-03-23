namespace POO_estaticos
{
    public static class Conversor
    {
        private static float valorDolar = 5.37f;  
        private static float valorEuro = 6.52f;

        public static float DolarParaReal(float valor){

                return valor*valorDolar;

        }
        public static float RealParaDolar(float valor){

            return valor/valorDolar;

        }
        public static float EuroParaReal(float valor){

            return valor*valorEuro;

        }
        public static float RealParaEuro(float valor){

            return valorEuro/valor;

        }
    }
}