using System;

namespace RoboNRL.Dialogs
{
    [Serializable]
    public class ContrutorDialogo
    {
        public Random Rnd { get; set; } = new Random();
        int random = 0;
        string resposta;      

        public string DialogoCumprimento()
        {
            random = Rnd.Next(1,6);
            switch (random)
            {
                case 1:
                    random = Rnd.Next(1, 6);
                    return resposta = "Opa tudo legal e por ai?";

                case 2:
                    random = Rnd.Next(1, 6);
                    return resposta = "Eu vou bem, e você como está?";
                    
                case 3:
                    random = Rnd.Next(1, 6);
                    return resposta = "Queria poder tomar uma cervejinha, mas tirando isso tá tudo maravilhoso";
                    
                    
                case 4:
                    random = Rnd.Next(1, 6);
                    return resposta = "Estou bem, obrigada por perguntar.";

                default:
                    random = Rnd.Next(1, 6);
                    return resposta = "E ai, tudo bem?";
            }
        }

        public string DialogoExpectativa()
        {
            random = Rnd.Next(1, 6);
            switch (random)
            {
                case 1:
                    random = Rnd.Next(1, 6);
                    return resposta = "Aposto que será um ótimo evento, afinal tem você como palestrante.";

                case 2:
                    random = Rnd.Next(1, 6);
                    return resposta = "Esse evento vai ser legen... espere um pouco, dário! Legendário!";

                case 3:
                    random = Rnd.Next(1, 6);
                    return resposta = "Cara, mal posso esperar para começar, e ai quando você vai anunciar o primeiro palestrante?";

                case 4:
                    random = Rnd.Next(1, 6);
                    return resposta = "Tudo indica que vai ser excelente, quando vou poder olhar as estrelas?";
                default:
                    random = Rnd.Next(1, 6);
                    return resposta = "Poxa, estou bem animada para o evento";
            }
        }      
    }
}