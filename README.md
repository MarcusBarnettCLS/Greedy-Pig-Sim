# Greedy-Pig-Sim
## Generate Greedy Pig Data

![Window Screenshot](https://github.com/MarcusBarnettCLS/Greedy-Pig-Sim/blob/main/Screenshot%202025-03-21%20124558.png)

## How to use
### **Select Simulation Type**

*Go Until n*
- Will continue to roll until reaching n
  
*Go for n Rounds*
- Will continue to roll until reaching n rolls

### **Select Simulation Parameters**

*nMin & nMax*
- The simulation will repeat for all values between nMin & nMax, generating new spreadsheet pages for each simulation for n.
  Example:
  Running the sim with nMin = 5 and nMax = 10 will generate 10 pages, first 5 being the raw data for each game, last 5 being frequency tables.

*Data Points*
- How many times you want the game to be played, also how many rows will be on each sheet, each row representing a game cycle.

*Target*
- The target score to reach before recording game data and continuing to next round. Default is 100 as that is what the game is commonly played with.


### **Reading the Spreadsheet**

*First half of sheets (n = num)*
- Column A records the raw data of the game, showing the increase of score from round to round in format "a, b, c...", if a value equals its following value that means the game rolled a 1, and therefore no score was added.
- Column B records how many rounds it took for the simulation to reach target score

*Second half of sheets (Freq. n = num)*
- Column A records the amount of rounds taken to reach the target score
- Column B records the amount of times in the simulation that took that amount of turns to reach the target score.

*Helpful Use Cases*
- The 2nd half of sheets can easily be used to produce tables such as a bar graph given its already been formatted as a frequency table.
- I have not yet tested with Box plots in excel, but I assume they'd be done using the first half of sheets and by selecting Column B
