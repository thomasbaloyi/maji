// generate a map

int mapSize = 20;
Random randomNumberGenerator = new Random();

int[,] terrain = new int[mapSize,mapSize];

for (int outer = 0; outer < mapSize; outer++) { 
    for (int inner = 0; inner < mapSize; inner++)
    {
        terrain[outer, inner] = randomNumberGenerator.Next(0, 4);
    }
}

// start a gui