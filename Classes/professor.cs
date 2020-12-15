namespace teste.Classes
{
    public class professor
    {
        public string Professor;

        public float valorAula = 10.50f;

        public float hora;

        public float matematica(float hora){

            return hora * valorAula;

        }
    }
}