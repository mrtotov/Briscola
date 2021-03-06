using Grappachu.Briscola.Model;

namespace Grappachu.Briscola.Interfaces
{
    /// <summary>
    ///     Rappresenta la strategia di gioco di per un generico giocatore (umano o robot)
    /// </summary>
    public interface IStrategy
    {
        /// <summary>
        ///     Ottiene un valore che indica che la strategia richiede una interazione con l'utente
        /// </summary>
        bool IsHuman { get; }

        /// <summary>
        ///     Ottiene il nome di questa strategia
        /// </summary>
        string Name { get; }

        /// <summary>
        ///     Viene richiamato ad ogni turno di gioco da parte di un giocatore per chiedergli di giocare una carta
        /// </summary>
        /// <param name="player"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        Card Choose(IPlayer player, GameState state);

        /// <summary>
        ///     Viene richiamato al termine di ogni mano per notificare il risultato parziale
        /// </summary>
        /// <param name="player"></param>
        /// <param name="state"></param>
        void Watch(IPlayer player, GameState state);
    }
}