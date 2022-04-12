//    You are the owner of a courier company and you want to make a system for tracking your cars and their cargo.
//Define a class Car that holds a piece of information about the model, engine, and cargo.The Engine and Cargo
//    should be separate classes.Create a constructor that receives all of the information about the Car and creates and
//initializes its inner components (engine and cargo).
//On the first line of input, you will receive a number N – the number of cars you have.On each of the next N lines,
//you will receive the following information about a car: Model EngineSpeed EnginePower CargoWeight CargoType, where the speed, power and weight are all integers.
//After the N lines, you will receive a single line with one of 2 commands: &quot; fragile&quot; or &quot;flamable&quot;. If the
//command is &quot;fragile&quot; print all cars, whose Cargo Type is &quot;fragile&quot; with cargo, whose weight < 1000. If
//the command is &quot;flamable&quot; print all of the cars whose Cargo Type is &quot;flamable&quot; and has Engine Power >
//250. The cars should be printed in order of appearing in the input.