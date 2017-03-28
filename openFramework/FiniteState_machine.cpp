#include "ofApp.h"

int state;
const int S_BEGIN = 0;
const int S_GAME = 1;
const int S_WIN = 2;
const int S_LOOSE = 3;

int countPlayer = 0;

float T0;

int r = 0;
int g = 0;
int b = 0;

float compX = 500;
float compY = 500;
float compR = 9;

float playerR = 6;


void ofApp::SetState(int S0){
    state = S0;
    if(state == S_BEGIN || state == S_WIN || state == S_LOOSE){
        T0 = ofGetElapsedTimef();
    }
}

//--------------------------------------------------------------
void ofApp::setup(){
    SetState(S_BEGIN);
    r = 255;
    
}

//--------------------------------------------------------------
void ofApp::update(){
    
    if (state == S_BEGIN)
        if (ofGetElapsedTimef() > T0 + 3)
            SetState(S_GAME);
    
    if (state == S_WIN || state == S_LOOSE) {
        if (ofGetElapsedTimef() > T0 + 3) {
            SetState(S_BEGIN);
        }
    }
    
    if (state == S_GAME && ofGetElapsedTimef() > T0 + 7) {
        SetState(S_LOOSE);
    }
}

//--------------------------------------------------------------
void ofApp::draw(){
    
    ofDrawBitmapString(state, 100, 100);
    
    ofDrawBitmapString("Count = " + ofToString(countPlayer), 700, 100);
    
    ofSetColor(r, g, b);
    
    ofDrawCircle(compX, compY, compR);
    
    
    if (state == S_BEGIN) {
        ofDrawBitmapString(ofToString(state) + " Start game", 300, 300);
    }
    
    if (state == S_GAME) {
        
        ofDrawBitmapString(ofToString(state) + " Game in state game", 300, 300);
        
        ofSetColor(0, 0, 255);
        ofDrawCircle(mouseX, mouseY, playerR);
        
        if (ofDist(mouseX, mouseY, compX, compY) < compR + playerR) {
            countPlayer++;
            SetState(S_WIN);
        }
        
        
    }
    
    if (state == S_WIN) {
        ofDrawBitmapString(ofToString(state) + " Game win!", 300, 300);
    }
    if (state == S_LOOSE) {
        ofDrawBitmapString(ofToString(state) + " Game loose!", 300, 300);
    }
}

//--------------------------------------------------------------
void ofApp::keyPressed(int key){
    if (key == ' ') {
        SetState(S_BEGIN);
    }
    if (key == 'w' && state == S_GAME) {
        SetState(S_WIN);
    }
    if (key == 'l' && state == S_GAME) {
        SetState(S_LOOSE);
    }
    
}
