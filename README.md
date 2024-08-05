In this project the command pattern was used to implement input handling of the player keys with respect to materials that were changed by the player,
utilising the Stack data structures to store the datas of the material

In game development, the Command Pattern can be employed in various ways to manage game mechanics, player interactions, 
and other aspects of gameplay. Here are some specific use cases for the Command Pattern in games:

1. Input Handling: Games often need to handle various player inputs such as keyboard, mouse, or controller actions. 
By using the Command Pattern, each input event can be encapsulated into a command object.
This allows for easy mapping of inputs to actions and enables features like customizable key bindings.

2. Player Actions and Abilities: Commands can represent player actions or abilities within the game. For example,
in a strategy game, commands could represent unit movements, attacks, or special abilities. By encapsulating
these actions into command objects, it becomes easier to implement features like undo, replay, or AI prediction.
Game AI: Command objects can be used to encapsulate AI behaviors or decisions. Instead of directly executing AI actions,
the game can generate command objects representing the AI's intentions. This allows for easier debugging, testing, and modification of AI behaviors.

3. Game State Management: Commands can be used to manage changes to the game state. For instance, commands could represent
state transitions such as starting a new level, pausing the game, or triggering scripted events. This approach makes
it easier to implement features like checkpoints and save/load functionality.
Scripting and Modding Support: By exposing game functionality through command objects, developers can provide
a scripting or modding interface for players to customize or extend the game. Players can create custom commands
or scripts to add new features, behaviors, or content to the game.

4. Networked Multiplayer Games: In multiplayer games, commands can be serialized and sent over the network to
synchronize game state between clients. By using the Command Pattern, the game can represent player actions as command objects,
making it easier to handle network latency, synchronization, and reconciliation.
Game Design Iteration: The Command Pattern can facilitate rapid iteration during game development.
By encapsulating game behaviors into command objects, developers can easily tweak, combine, or replace
these behaviors without affecting other parts of the game code.

Overall, the Command Pattern is a versatile design pattern that can be used in various aspects of game development, 
including input handling, player actions, AI behavior, game state management, modding support, multiplayer networking, 
and rapid iteration during development. Its flexibility and decoupling benefits make it a valuable tool for building complex and dynamic gameplay systems.
