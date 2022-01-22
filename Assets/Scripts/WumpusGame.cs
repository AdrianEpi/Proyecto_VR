using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WumpusGame : MonoBehaviour {
    private static int size_ = 10;
    private static int holesAmmount_ = 20;
    int [,] map_ = new int[size_ + 2, size_ + 2];
    int playerX_ = 0;
    int playerY_ = 0;
    int wumpusX_ = 0;
    int wumpusY_ = 0;
    int treasureX_ = 0;
    int treasureY_ = 0;
    bool stentch_ = false;
    bool wind_ = false;


    // Start is called before the first frame update
    void Start() {
        generateMap();
        searchWind();
        searchStentch();
    }

    // Update is called once per frame
    void Update() {
        
    }


    /// <summary>
    /// Searchs if there's a hole near the player.
    /// </summary>
    void searchWind () {
        if ((map_[playerX_ + 1, playerY_] == 2) || (map_[playerX_ - 1, playerY_] == 2) || (map_[playerX_, playerY_ + 1] == 2) || (map_[playerX_, playerY_ - 1] == 2)) {
            wind_ = true;
        }
        wind_ = false;
    }

    /// <summary>
    /// Searchs if the wumpus is near the player.
    /// </summary>
    void searchStentch () {
        if ((map_[playerX_ + 1, playerY_] == 3) || (map_[playerX_ - 1, playerY_] == 3) || (map_[playerX_, playerY_ + 1] == 3) || (map_[playerX_, playerY_ - 1] == 3)) {
            stentch_ = true;
        }
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
        if (map_[posX, posY] == 0) {
            return true;
        }
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
        for (int i = 0; i < size_ + 2; i++) {
            for (int j = 0; j < size_ + 2; j++) {
                if (i == 0 || i == size_ + 1 || j == 0 || j == size_ + 1) {
                    map_[i, j] = -1;
                }
                else {
                    map_[i, j] = 0;
                } 
            }
        }
        // Player Settings
        playerX_ = 1;
        playerY_ = 1;
        map_[playerX_, playerY_] = 1;
        // Generate Holes
        for (int i = 0; i < holesAmmount_; i++) {
            int posX = 0;
            int posY = 0;
            while (!isValidPosition(posX, posY)) {
                posX = generateRandomNumber(1, 11);
                posY = generateRandomNumber(1, 11);
            }
            //Debug.Log("Hole: (" + posX + ", " + posY + ")");
            map_[posX, posY] = 2;
        }
        // Generate Wumpus
        wumpusX_ = 0;
        wumpusY_ = 0;
        while (!isValidPosition(wumpusX_, wumpusY_)) {
            wumpusX_ = generateRandomNumber(1, 11);
            wumpusY_ = generateRandomNumber(1, 11);
        }
        //Debug.Log("Wumpus: (" + wumpusX_ + ", " + wumpusY_ + ")");
        map_[wumpusX_, wumpusY_] = 3;
        // Generate Treasure
        treasureX_ = 0;
        treasureY_ = 0;
        while (!isValidPosition(treasureX_, treasureY_)) {
            treasureX_ = generateRandomNumber(1, 11);
            treasureY_ = generateRandomNumber(1, 11);
        }
        //Debug.Log("Treasure: (" + treasureX_ + ", " + treasureY_ + ")");
        map_[treasureX_, treasureY_] = 4;    
    }

    /// <summary>
    /// Prints the map in the console, for testing purposes.
    /// </summary>
    private void printMap () {
        string str = "";
        for (int i = 0; i < size_ + 2; i++) {
            for (int j = 0; j < size_ + 2; j++) {
                str += "\t" + map_[i, j];
            }
            str += "\n";
        }
        Debug.Log(str);
    }
}
