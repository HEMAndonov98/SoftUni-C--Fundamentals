3. MOBA Challenger


Peter is a pro-MOBA player, he is struggling to become а master of the Challenger tier. So he watches carefully the statistics in the tier.
You will receive several input lines in one of the following formats:

"{player} -> {position} -> {skill}"

"{player} vs {player}"

The player and position are strings, the given skill will be an integer number. You need to keep track of every player. 
When you receive a player and his position and skill, add him to the player pool, if he isn't present, else add his position and skill or update his skill, only if the current position skill is lower than the new value.

If you receive "{player} vs {player}" and both players exist in the tier, they duel with the following rules:
Compare their positions, if they got at least one in common, the player with better total skill points wins and the other is demoted from the tier -> remove him. If they have the same total skill points, the duel is a tie and they both continue in the Season.

If they don't have positions in common, the duel isn't happening and both continue in the Season.

You should end your program when you receive the command "Season end". At that point, you should print the players, ordered by total skill in descending order, then ordered by player name in ascending order. Foreach player prints their position and skill ordered descending by skill, then ordered by position name in ascending order

Input / Constraints

The input comes in the form of commands in one of the formats specified above.

Player and position will always be one-word string, containing no whitespaces.

Skill will be an integer in the range [0, 1000].

There will be no invalid input lines.

The program ends when you receive the command "Season end".

Output

The output format for each player is:

"{player}: {totalSkill} skill"

"- {position} <::> {skill}"

Examples

Peter -> Adc -> 400
George -> Jungle -> 300
Sam -> Mid -> 200
Sam -> Support -> 250
Season end

Output

Sam: 450 skill
- Support <::> 250
- Mid <::> 200
Peter: 400 skill
- Adc <::> 400
George: 300 skill
- Jungle <::> 300