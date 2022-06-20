namespace ProjetoRPG.src.Entities
{
    public class Ninja : Hero
    {
         public Ninja(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.Name + " Atacou com adaga! ";
        }


        public string Attack(string Tipo, int Bonus){
            if(Tipo == "Noite"){
                return this.Name + " Realizou um Ataque furtivo! Dano: " + Bonus;
            }else {
                 return this.Name + " Realizou um Ataque comum! Dano: " + Bonus;
            }
        }


    }
}