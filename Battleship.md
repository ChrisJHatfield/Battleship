Things to do:

Classes:
    [] 1) Players
    public:
        [X] - Name
        [X] - Each has 1 of each ship
        [] - Player Grid Class
        [-x-] - Methods:
            ` Greeting (Player Name)
    [] 2) Ship Class
    public:
        [X] - Name
            ~ Carrier (5)
            ~ Destroyer (2)
            ~ Battleship (4)
            ~ Submarine (3)
            ~ Cruiser (3)
        [X] - Length
        [X] - Health Bar (= Length)
        [] - Position: X & Y
            ` Can't overlap positions.
    [] 3) Grid Class
    public:
        [] `2d Array (10x10)(row = 1-10, column = a-j)
    [] 4) Game Class
    public:
        [] - Methods:
            ` Place
                [] - List of Coordinates
            ` Display all Attacks
                [] - Returns list of all inputted commands e.g.: {a1, a2, b4, j7}
            ` Attack
                [] - First: Check list of inputted commands to verify new input
                [] - Hit
                    (optional) display as X
                [] - Miss
                    (optional) display as O
            ` Sink
                [] - Remove Ship from List of Coordinates
            ` Win / Lose
            