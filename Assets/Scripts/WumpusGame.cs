using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This class describes a wumpus game.
/// </summary>
public class WumpusGame : MonoBehaviour {
    public static int size_ = 7;
    public static int holesAmmount_ = 10;
    int [,] map_ = new int[size_ + 2, size_ + 2];
    string [,] mindMap_ = new string[size_ + 2, size_ + 2];
    int playerX_ = 0;
    int playerY_ = 0;
    int wumpusX_ = 0;
    int wumpusY_ = 0;
    int treasureX_ = 0;
    int treasureY_ = 0;
    bool stentch_ = false;
    bool wind_ = false;
    public Text info_;
    public Text textMap_;
    public Text help_;
    public bool finished_;

    /// <summary>
    /// Executes before the program starts
    /// </summary>
    void Start() {
        finished_ = false;
        info_.text = "";
        textMap_.text = ""; 
        generateMap();
        searchWind();
        searchStentch();
        printMindMap();
    }


    /// <summary>
    /// Updates the object.
    /// </summary>
    void Update() {
        if (finished_) {
            if ((playerX_ == treasureX_) && (playerY_ == treasureY_))
                info_.text = "\n Contratulations! You won the game!";
            else
                info_.text = "\n Game Over!";
        }
        else {
            info_.text = getRoom();
            if (wind_ == true)
                info_.text += "\n Wind: true";
            else
                info_.text += "\n Wind: false";

            if (stentch_ == true)
                info_.text += "\n Stentch: true";
            else 
                info_.text += "\n Stentch: false";

            textMap_.text = printMindMap();
            help_.text = "P: Player\n S: Detected Stentch\n W: Detected Wind\nX: Detected Stentch and Wind";
        }
    }


    /// <summary>
    /// Moves the player one step on the given direction
    /// </summary>
    ///
    /// <param name="direction">The direction</param>
    public void movePlayer (string direction) {
        int posX = playerX_;
        int posY = playerY_;
        switch (direction) {
            case "East":
                if (playerY_ + 1 < size_ + 1)
                    playerY_ += 1;
                break;
            case "West":
                if (playerY_ - 1 > 0)
                    playerY_ -= 1;
                break;
            case "South":
                if (playerX_ - 1 > 0)
                    playerX_ -= 1;
                break;
            case "North":
                if (playerX_ + 1 < size_ + 1)
                    playerX_ += 1;
                break;
            default:
                break;
        }
        if (map_[playerX_, playerY_] != 0 && map_[playerX_, playerY_] != 1) {
            if (map_[playerX_, playerY_] == -1) {
                playerX_ = posX;
                playerY_ = posY;
            }
            else {
                Debug.Log("(" + playerX_ + ", " + playerY_ + ") = " + map_[playerX_, playerY_]);
                finished_ = true;
            }
        }
        else {
            map_[posX, posY] = 0;
            map_[playerX_, playerY_] = 1;
            if (stentch_ && wind_) 
                mindMap_[posX, posY] = "X";

            if (stentch_)
                mindMap_[posX, posY] = "S";
            else if (wind_)
                mindMap_[posX, posY] = "W";
            else
                 mindMap_[posX, posY] = "-";
            mindMap_[playerX_, playerY_] = "P";
            searchWind();
            searchStentch();
        }
    }

    /// <summary>
    /// Gets the room.
    /// </summary>
    ///
    /// <returns>The room.</returns>
    string getRoom () {
        string abc = "AABCDEFGHIJKLMNOPQRST";
        return "Room (" + playerX_ + ", " + abc[playerY_] + ")";
    }

    /// <summary>
    /// Searchs if there's a hole near the player.
    /// </summary>
    void searchWind () {
        if ((map_[playerX_ + 1, playerY_] == 2) || (map_[playerX_ - 1, playerY_] == 2) || (map_[playerX_, playerY_ + 1] == 2) || (map_[playerX_, playerY_ - 1] == 2)) 
            wind_ = true; 
        else
            wind_ = false;            
    }

    /// <summary>
    /// Searchs if the wumpus is near the player.
    /// </summary>
    void searchStentch () {
        if ((map_[playerX_ + 1, playerY_] == 3) || (map_[playerX_ - 1, playerY_] == 3) || (map_[playerX_, playerY_ + 1] == 3) || (map_[playerX_, playerY_ - 1] == 3))
            stentch_ = true;
        else
            stentch_ = false;
        
    }

    /// <summary>
    /// Determines if valid position.
    /// </summary>
    ///
    /// <param name="posX">The position x</param>
    /// <param name="posY">The position y</param>
    ///
    /// <returns>True if valid position, False otherwise.</returns>
    private bool isValidPosition (int posX, int posY) {
        if (map_[posX, posY] == 0)
            return true;

        return false;
    }

    /// <summary>
    /// Generates a random number between the lower and the upper number, including the lower and excluding the upper
    /// </summary>
    ///
    /// <param name="lower">The lower</param>
    /// <param name="upper">The upper</param>
    ///
    /// <returns>< The random number ></returns>
    private int generateRandomNumber (int lower, int upper) {
        return Random.Range(lower, upper);
    }

    /// <summary>
    /// Generates the map:
    ///  0    ->   Empty room
    ///  1    ->   Player's room
    ///  2    ->   Hole in room 
    ///  3    ->   Wumpus in room 
    ///  4    ->   Treasure in room 
    ///  -1   ->   Out of map
    /// </summary>
    private void generateMap () {
        // Initalize Map
        for (int i = 0; i < size_ + 2; i++)
            for (int j = 0; j < size_ + 2; j++)
                if (i == 0 || i == size_ + 1 || j == 0 || j == size_ + 1)
                    map_[i, j] = -1;
                else {
                    map_[i, j] = 0;
                    mindMap_[i, j] = " ";
                } 
        // Player Settings
        playerX_ = generateRandomNumber(1, size_ + 1);
        playerY_ = generateRandomNumber(1, size_ + 1);
        map_[playerX_, playerY_] = 1;
        mindMap_[playerX_, playerY_] = "P";
        // Generate Holes
        for (int i = 0; i < holesAmmount_; i++) {
            int posX = 0;
            int posY = 0;
            while (!isValidPosition(posX, posY)) {
                posX = generateRandomNumber(1, size_ + 1);
                posY = generateRandomNumber(1, size_ + 1);
            }
            map_[posX, posY] = 2;
        }
        // Generate Wumpus
        wumpusX_ = 0;
        wumpusY_ = 0;
        while (!isValidPosition(wumpusX_, wumpusY_)) {
            wumpusX_ = generateRandomNumber(1, size_ + 1);
            wumpusY_ = generateRandomNumber(1, size_ + 1);
        }
        map_[wumpusX_, wumpusY_] = 3;
        // Generate Treasure
        treasureX_ = 0;
        treasureY_ = 0;
        while (!isValidPosition(treasureX_, treasureY_)) {
            treasureX_ = generateRandomNumber(1, size_ + 1);
            treasureY_ = generateRandomNumber(1, size_ + 1);
        }
        map_[treasureX_, treasureY_] = 4;    
    }

    /// <summary>
    /// Prints the map in the console, for testing purposes.
    /// </summary>
    private void printMapConsole () {
        string str = "";
        for (int i = 1; i < size_ + 1; i++) {
            for (int j = 1; j < size_ + 1; j++)
                str += "\t" + map_[i, j];
            str += "\n";
        }
        Debug.Log(str);
    }

    /// <summary>
    /// Prints the map in canvas, for noob players.
    /// </summary>
    private string printFullMap () {
        string str = "";
        for (int i = size_; i > 0; i--) {
            for (int j = 1; j < size_ + 1; j++)
                str += "\t" + map_[i, j];
            str += "\n";
        }
        return str;
    }

    /// <summary>
    /// Prints the mind map in canvas.
    /// </summary>
    private string printMindMap () {
        string str = "";
        for (int i = size_; i > 0; i--) {
            for (int j = 1; j < size_ + 1; j++) {
                str += " |" + mindMap_[i, j];
                if (mindMap_[i, j] == " ") 
                    str += " ";
            }
            str += "|\n";
        }
        return str;
    }
}
