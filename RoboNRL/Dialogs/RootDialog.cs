using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;

namespace RoboNRL.Dialogs
{
    [LuisModel("SuaKey",
        domain: "westcentralus.api.cognitive.microsoft.com")]
    [Serializable]
    public class RootDialog : LuisDialog<object>
    {
        ContrutorDialogo dialogo = new ContrutorDialogo();
        
        [LuisIntent("None")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("Mal ae, mas não entendi o que você quis dizer.");
        }

        [LuisIntent("Cumprimento")]
        public async Task Cumprimento(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(dialogo.DialogoCumprimento());
        }

        [LuisIntent("Palestrante")]
        public async Task Palestrante(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("Uai pode chamá-lo! Esse cara é bom mesmo!");
        }

        [LuisIntent("Expectativa")]
        public async Task Expectativa(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(dialogo.DialogoExpectativa());
        }

        [LuisIntent("Grupo NRL")]
        public async Task Grupo_NRL(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("A galera do NRL tá de parabéns, muito bom o desempenho deles!");
        }

        [LuisIntent("Criador")]
        public async Task Criador(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("Fui criada pela espetacular galera do NRL!");
        }
    }
}