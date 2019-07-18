This is a simple Pong game with two players.

## Controls
P to pause the game

### player 1
* Z to move UP
* S to move DOWN
* Left shift to move faster

### player 2
* Up arrow to move UP
* Down arrow to move DOWN
* Numpad0 to move faster

## Scoring

This pong game implements a simplified version of Tennis scoring

* Each player can have a score of 0, 15, 30 or 40.
* A player wins the set if they score again while their score is 40 and the game is not deuce
* The game is deuce when both player reach a score of 40
* A player that scores while the game is deuce and both scores are 40 gets an advantage (The score will be "Adv.")
* A player that scores while they have the advantage wins the set.
* A player that scores while the other player has the advantage makes them lose their advantage and reset the score to 40 - 40
* The first player to win 6 sets wins the game.
