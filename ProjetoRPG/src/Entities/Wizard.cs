namespace ProjetoRPG.src.Entities
{
    public class Wizard : Hero
    {
       
       public Wizard(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.Name + " Atacou com magia! ";
        }

        public string Attack(int Bonus){

          if(Bonus > 20){

            return this.Name + " Realizou um Ataque com Super Magia! Dano: " + Bonus;
          }else{
                return this.Name + " Realizou um Ataque com Magia Comum! Dano: " + Bonus;
          }


        }

    }
}