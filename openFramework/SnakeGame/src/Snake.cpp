//
//  Snake.cpp
//  SnakeGame
//
//  Created by Roman Bushuev on 31.03.17.
//
//

#include "Snake.hpp"

Snake::Snake()
{
    x = 200;
    y = 200;
    
    speedX = 1;
    speedY = 0;
    
    width = 10;
    height = 10;
    
    countEatFood = 0;
    
    scale = 10;
}


void Snake::updateSnakeSpeed() {
    x = x + speedX * scale;
    y = y + speedY * scale;
}
void Snake::setMove(int x, int y) {
    speedX = x;
    speedY = y;
}
void Snake::rePosition() {
    x = 200;
    y = 200;
}
