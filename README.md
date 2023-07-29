# Tic-Tac-Toe-AI-Game

 C# Windows Forms application for a Tic-Tac-Toe game. Two-player game where the user plays against the computer. The computer's moves are determined using either the MiniMax or Alpha-Beta pruning algorithm, depending on the selected option from the ComboBox.


# MinMax algorithm
This method is responsible for making the computer's move using the MiniMax algorithm in the Tic-Tac-Toe game. Let's go through the method step by step

1. The method DoMiniMaxJob takes an integer parameter position, which represents the position on the game board where the user (human player) has made their move.

2. The first conditional check (if statement) is to determine whether the computer starts the game. If the selected option in comboBox1 is "Computer starts," it means the computer plays the first move.

3. Inside the if block, the computer's move is simulated. The computer makes its move by assigning its symbol (seed) to the position that the user just played. In this code, the computer's seed is represented by c.oppSeed, which is set to "o" in the InitBoard method.

4. The MiniMax algorithm is then called to calculate the best move for the computer. c.MiniMax(c.mySeed, 8) is called, where c.mySeed is the computer's seed ("x") and 8 is the depth of the search tree. The 8 indicates how many moves ahead the MiniMax algorithm should look to find the best move. A larger depth allows the computer to look further into the future, but it also increases the computation time.

5. The MiniMax method returns a tuple with two values: the score of the best move and the index of the cell where the computer should play. [1] is used to access the second element of the tuple, which is the index of the cell.

6. The computer's move is then executed by updating the game board with its seed at the calculated position. The button corresponding to the calculated position is also updated to display the computer's symbol ("0"), and it's disabled to prevent further clicks.

7. After the computer's move, the code checks for a win or draw condition and updates the label label3 accordingly. If the game is not over, it allows the user to make their next move.

8. If the user starts the game (selected option in comboBox1 is not "Computer starts"), the else block will be executed. In this case, the user has already made their move before calling DoMiniMaxJob. The code then simulates the user's move on the game board, and the computer calculates and executes its move, just like in the previous case.

That's a summary of what the DoMiniMaxJob method does in the Tic-Tac-Toe game. It handles the logic for the computer's moves using the MiniMax algorithm and allows the user to start the game either as the first player or second player.

# AlphaBeta algorithm

1. The DoAlphaBetaJob method is similar to DoMiniMaxJob, and it also takes an integer parameter position, representing the position on the game board where the user (human player) has made their move.

2. The first conditional check (if statement) is to determine whether the computer starts the game. If the selected option in comboBox1 is "Computer starts," it means the computer plays the first move.

3. Inside the if block, the computer's move is simulated. The computer makes its move by assigning its symbol (seed) to the position that the user just played. In this code, the computer's seed is represented by c.oppSeed, which is set to "o" in the InitBoard method.

4. The Alpha-Beta pruning algorithm is then called to calculate the best move for the computer. c.AlphaBeta(c.mySeed, 8, int.MinValue, int.MaxValue) is called, where c.mySeed is the computer's seed ("x"), 8 is the depth of the search tree, int.MinValue represents the initial value of alpha, and int.MaxValue represents the initial value of beta.

5. The AlphaBeta method returns a tuple with two values: the score of the best move and the index of the cell where the computer should play. [1] is used to access the second element of the tuple, which is the index of the cell.

6. The computer's move is then executed by updating the game board with its seed at the calculated position. The button corresponding to the calculated position is also updated to display the computer's symbol ("0"), and it's disabled to prevent further clicks.

7. After the computer's move, the code checks for a win or draw condition and updates the label label3 accordingly. If the game is not over, it allows the user to make their next move.

8. If the user starts the game (selected option in comboBox1 is not "Computer starts"), the else block will be executed. In this case, the user has already made their move before calling DoAlphaBetaJob. The code then simulates the user's move on the game board, and the computer calculates and executes its move, just like in the previous case.

That's a summary of what the DoAlphaBetaJob method does in the Tic-Tac-Toe game. It handles the logic for the computer's moves using the Alpha-Beta pruning algorithm and allows the user to start the game either as the first player or second player. The Alpha-Beta pruning algorithm is an optimization over the MiniMax algorithm and helps to reduce the number of nodes explored during the search process.
