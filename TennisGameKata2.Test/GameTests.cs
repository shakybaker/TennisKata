using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TennisGameKata2.Model;

namespace TennisGameKata2.Test
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void Player_score_is_incremented_when_a_point_is_scored()
        {
            var game = new Game();
            game.AddScoreToPlayer(1);

            Assert.AreEqual("15, Love", game.GetScore());
        }

        [TestMethod]
        public void Player_scores_4_times_and_opponent_does_not_score_then_player_wins()
        {
            var game = new Game();
            game.AddScoreToPlayer(1);
            game.AddScoreToPlayer(1);
            game.AddScoreToPlayer(1);
            game.AddScoreToPlayer(1);

            Assert.AreEqual("Player 1 Wins", game.GetScore());
        }

        [TestMethod]
        public void Both_players_are_on_40_then_deuce_is_shown_as_score()
        {
            var game = new Game();
            game.AddScoreToPlayer(1);
            game.AddScoreToPlayer(1);
            game.AddScoreToPlayer(1);
            game.AddScoreToPlayer(2);
            game.AddScoreToPlayer(2);
            game.AddScoreToPlayer(2);

            Assert.AreEqual("Deuce", game.GetScore());
        }

        [TestMethod]
        public void Players_on_deuce_and_player_scores_then_advantage_is_shown()
        {
            var game = new Game();
            game.AddScoreToPlayer(1);
            game.AddScoreToPlayer(1);
            game.AddScoreToPlayer(1);
            game.AddScoreToPlayer(2);
            game.AddScoreToPlayer(2);
            game.AddScoreToPlayer(2);
            game.AddScoreToPlayer(1);

            Assert.AreEqual("Advantage, 40", game.GetScore());
        }

        [TestMethod]
        public void Player_has_advantage_then_opponent_scores_then_deuce_is_shown()
        {
            var game = new Game();
            game.AddScoreToPlayer(1);
            game.AddScoreToPlayer(1);
            game.AddScoreToPlayer(1);
            game.AddScoreToPlayer(2);
            game.AddScoreToPlayer(2);
            game.AddScoreToPlayer(2);
            game.AddScoreToPlayer(1);
            game.AddScoreToPlayer(2);

            Assert.AreEqual("Deuce", game.GetScore());
        }

        [TestMethod]
        public void Player_has_advantage_then_scores_then_player_wins()
        {
            var game = new Game();
            game.AddScoreToPlayer(1);
            game.AddScoreToPlayer(1);
            game.AddScoreToPlayer(1);
            game.AddScoreToPlayer(2);
            game.AddScoreToPlayer(2);
            game.AddScoreToPlayer(2);
            game.AddScoreToPlayer(1);
            game.AddScoreToPlayer(1);

            Assert.AreEqual("Player 1 Wins", game.GetScore());
        }
    }
}
