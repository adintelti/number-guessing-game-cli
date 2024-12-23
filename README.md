# Number-Guessing-Game-cli

Project Task URL: https://roadmap.sh/projects/number-guessing-game

.NET 8.0 Console app solution for the Number guessing game cli challenge from roadmap.sh.

## Features
It's a simple guessing number game, where a random number between 1 and 100 is randomly picked, the user select a level between easy, medium and hard, which will give him 10, 5 or 3 changes to guess the number in this respective order.

if the user guess wrong, it will tell him if the number if greater or less then his last guess and give him another change, if the user guess is correct he will receive a congratulations message with the number of attempts he used so far, if the user guess is wrong and if he ran out of attemps, a you lose message will be displayed with the number of attemps he used and revealing the number.

## Installation

To run this application, follow these steps:

1. Clone this repository:
    ```bash
    git clone https://github.com/adintelti/number-guessing-game-cli.git
    ```

2. Navigate to the project directory:
    ```bash
    cd number-guessing-game-cli
    ```

3. Restore dependencies:
    ```bash
    dotnet restore
    ```

4. Build the project:
    ```bash
    dotnet build
    ```

5. Run the application:
    ```bash
    dotnet run
    ```
