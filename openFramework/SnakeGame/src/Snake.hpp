//
//  Snake.hpp
//  SnakeGame
//
//  Created by Roman Bushuev on 31.03.17.
//
//

#ifndef Snake_hpp
#define Snake_hpp

#include <stdio.h>


class Snake
{
public:
    
    int x;
    int y;
    
    int speedX;
    int speedY;
    
    int width;
    int height;
    
    int countEatFood;
    
    int scale;
    
 
    Snake();
    
    void updateSnakeSpeed();
    void setMove(int x, int y);
    void rePosition();
    
};

#endif /* Snake_hpp */
