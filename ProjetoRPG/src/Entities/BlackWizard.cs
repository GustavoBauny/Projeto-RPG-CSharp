namespace ProjetoRPG.src.Entities
{
    public class BlackWizard : Hero
    {
         public BlackWizard(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.Name + " Atacou com magia negra! ";
        }


         public string Attack(string Tipo, int Bonus){
            if(Tipo == "Noite"){
                return this.Name + " Realizou um Ataque com Magia Negra! Dano extra: " + Bonus;
            }else {
                 return this.Name + " teve seu ataque reduzido! ";
            }
        }
    }
}