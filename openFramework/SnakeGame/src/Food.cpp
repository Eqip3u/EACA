//
//  Food.cpp
//  SnakeGame
//
//  Created by Roman Bushuev on 31.03.17.
//
//

#include "Food.hpp"
#include "stdlib.h"

Food::Food()
{
    width = 10;
    height = 10;
    
    x = 100 +  rand() % (1000 - 100);
    y = 100 +  rand() % (600 - 100);
    
}

void Food::reLocation() {
    x = 100 +  rand() % (1000 - 100);
    y = 100 +  rand() % (600 - 100);
}
