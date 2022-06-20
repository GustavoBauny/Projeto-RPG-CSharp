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

          if(Bonus > 40){

            return this.Name + " Realizou um Ataque Crítico com Espada! Dano: " + Bonus;
          }else{
                return this.Name + " Realizou um Ataque com Espada! Dano: " + Bonus;
          }

        }



    }
}