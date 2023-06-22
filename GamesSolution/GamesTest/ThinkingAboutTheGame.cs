
using Games;

namespace Games.Test
{
    public class ThinkingAboutTheGame
    {

        [Fact]
        public void DuplicateNamesAreNotAllowed()
        {
            var game = new BowlingGame();

            game.AddPlayer("Jim", 120);
            game.AddPlayer("Kaliyah", 250);

        Assert.Throws<PlayerAlreadyAddedToGameException>(() => game.AddPlayer(" jim ", 200));

        }
    }
}

