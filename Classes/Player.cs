namespace Exercicio_Sobrescrita.Classes
{
    public class Player
    {
        private float Velocidade;

        private float Forca_Pulo;

        public virtual string Correr(){
            return "O Player Correu!";
        }
        public virtual string Pular(){
            return "O Player Pulou!";
        }
    }
}