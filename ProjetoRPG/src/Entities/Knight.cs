namespace ProjetoRPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.Name + " Atacou com espada! ";
        }

        public string Attack(int Bonus){
            return this.Name + " Bonus de ataque com espada: " + Bonus;
        }   



    }
}