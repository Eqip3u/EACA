//
//  Food.hpp
//  SnakeGame
//
//  Created by Roman Bushuev on 31.03.17.
//
//

#ifndef Food_hpp
#define Food_hpp

#include <stdio.h>

class Food
{
public:
    
    Food();
    
    int x;
    int y;
    
    int width;
    int height;
    
    int color[3];
    
    void reLocation();
    
};

#endif /* Food_hpp */
