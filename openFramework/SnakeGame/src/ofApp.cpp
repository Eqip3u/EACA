#include "ofApp.h"
#include "Snake.hpp"
#include "Food.hpp"

int state;
const int S_BEGIN = 0;
const int S_GAME = 1;
const int S_WIN = 2;
const int S_LOOSE = 3;

float T0;

Snake snake;
Food food;

void ofApp::CheckWinOrLoose ()
{
    
    if(ofDist(snake.x, snake.y, food.x, food.y) < snake.width) {
        snake.countEatFood++;
        food.reLocation();
    }
    
    if(snake.x < 0 || snake.x > ofGetWidth() || snake.y > ofGetHeight() || snake.y < 0) {
        SetState(S_LOOSE);
    }
}

void ofApp::showSnake() {
    ofDrawRectangle(snake.x, snake.y, snake.width, snake.height);
    snake.updateSnakeSpeed();
}

void ofApp::showFood() {
    ofDrawRectangle(food.x, food.y, food.width, food.height);
}

void ofApp::SetState(int S0){
    state = S0;
    if(state == S_BEGIN || state == S_WIN || state == S_LOOSE){
        T0 = ofGetElapsedTimef();
    }
}

//--------------------------------------------------------------
void ofApp::setup(){
    ofSetFrameRate(20);
    SetState(S_BEGIN);
    
}

//--------------------------------------------------------------
void ofApp::update(){
    
    
    if (state == S_BEGIN)
        if (ofGetElapsedTimef() > T0 + 3)
            SetState(S_GAME);
    
    if (state == S_WIN || state == S_LOOSE)
        if (ofGetElapsedTimef() > T0 + 3)
            SetState(S_BEGIN);
    
    if (state == S_BEGIN) {
    }
    
    if (state == S_GAME) {
        CheckWinOrLoose();
    }
    
    if (state == S_WIN) {
    }
    
    if (state == S_LOOSE) {
    }
}

//--------------------------------------------------------------
void ofApp::draw(){
    
    ofDrawBitmapString(state, 100, 100);
    ofDrawBitmapString(snake.countEatFood, 800, 100);
    
    if (state == S_BEGIN) {
        ofDrawBitmapString(ofToString(state) + " Start game", 300, 300);
    }
    
    if (state == S_GAME) {
        
        ofDrawBitmapString(ofToString(state) + " Game in state game", 300, 300);
        
        
        showSnake();
        showFood();
        
    }
    
    if (state == S_WIN) {
        ofDrawBitmapString(ofToString(state) + " Game win!", 300, 300);
        
        snake.rePosition();
    }
    if (state == S_LOOSE) {
        ofDrawBitmapString(ofToString(state) + " Game loose!", 300, 300);
        
        snake.rePosition();
        
    }
}

//--------------------------------------------------------------
void ofApp::keyPressed(int key){
    
    if (key == OF_KEY_UP) {
        snake.setMove(0, -1);
    }
    if (key == OF_KEY_DOWN) {
        snake.setMove(0, 1);
    }
    if (key == OF_KEY_LEFT) {
        snake.setMove(-1, 0);
    }
    if (key == OF_KEY_RIGHT) {
        snake.setMove(1, 0);
    }
    
    if (key == ' ') {
        SetState(S_BEGIN);
    }
    if (key == 'g') {
        SetState(S_GAME);
    }
    
    if (key == 'w' && state == S_GAME) {
        SetState(S_WIN);
    }
    if (key == 'l' && state == S_GAME) {
        SetState(S_LOOSE);
    }
    
}
//--------------------------------------------------------------
void ofApp::keyReleased(int key){

}

//--------------------------------------------------------------
void ofApp::mouseMoved(int x, int y ){

}

//--------------------------------------------------------------
void ofApp::mouseDragged(int x, int y, int button){

}

//--------------------------------------------------------------
void ofApp::mousePressed(int x, int y, int button){

}

//--------------------------------------------------------------
void ofApp::mouseReleased(int x, int y, int button){

}

//--------------------------------------------------------------
void ofApp::mouseEntered(int x, int y){

}

//--------------------------------------------------------------
void ofApp::mouseExited(int x, int y){

}

//--------------------------------------------------------------
void ofApp::windowResized(int w, int h){

}

//--------------------------------------------------------------
void ofApp::gotMessage(ofMessage msg){

}

//--------------------------------------------------------------
void ofApp::dragEvent(ofDragInfo dragInfo){ 

}
