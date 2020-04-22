# Dice game

## Getting started

Git pull instructions for new users
Any library's or dependencies the project has

## Inspector overview

The main game contains two managers, the EventHandler for ui events and the Gamemanager that handles states and static objects. If a required component is missing from a manager it will throw an error with the 
Extension method `Extensions.IsGameObjectSet()`

The game is set up as a MVC where the UI controls the state of the game and invokes the actions / events from them. 

### Main classes: 
`GameManager` Takes care of all the objects instanced to control the game.

`Game` Handles the game logic, including players, Invoking the game, logic and turns. 

`Dice` Handles the set of die `Die` logic. 

`Roll` This class contains the data to return to be used in the Game controller.

`Player` Player class containing the stats to be used in the stat page as well as the general data contined for gameplay.

