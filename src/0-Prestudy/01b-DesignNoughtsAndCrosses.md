// ================================
// Designing Noughts And Crosses
// ================================

For this exercise, come up with a design for playing "Noughts And Crosses" aka "Tic-Tac-Toe".
I chose this because it's simple and everybody knows the rules.

As always, there are no "right" answers -- I am interested in seeing different approaches. We will be discussing these answers in the first session of the course.

# 1. Write down a "design" for playing Noughts And Crosses

[answer in a few paragraphs, up to a page -- don't go into too much detail. No code allowed!]

So we need to define a board, the board needs to be 3x3 and needs to keep the state. Each cell can either be empty, x or o.
Then we need to define actions, turns, placements. One user needs to wait while the other plays, each user is allowed to place only x or o, depending on what it got and can only place them in empty cells.
After each turn we need to validate if we can continue, if someone won or if it is a tie. A tie is when there are no empty cells and no one won

# 2. How is your design different from code?

[answer briefly here]
My design is a set of requirements, ennumerating entities and relationships. Code is the actual implementation, in a specific language. Following specific grammar rules and semantics.