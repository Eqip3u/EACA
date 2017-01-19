#include "ofApp.h"

float h = 100;
int n = 20;
float r = 60;
float x_0 = 500;
float y_0 = 200;
float z_0 = 10;

//--------------------------------------------------------------
void ofApp::setup(){

}

//--------------------------------------------------------------
void ofApp::update(){
    
}

//--------------------------------------------------------------
void ofApp::draw(){
    
    ofCircle(x_0, y_0, 5);
    
    float time = ofGetElapsedTimef();
    
    ofEnableDepthTest();
    glBegin(GL_TRIANGLES);
    
    for (int i = 0; i < n; i++) {
        
        float a = i * 2 * PI / n + time;
        float x1 = r * cos(a) + x_0;
        float y1 = y_0 + 400;
        float z1 = r * sin(a);
        
        float b = (i + 1) * 2 * PI / n + time;
        float x2 = r * cos(b) + x_0;
        float y2 = y_0 + 400;
        float z2 = r * sin(b);
        
        ofSetColor((i % 2) * 128 + 127);
        glVertex3f(x_0, y_0, z_0);
        glVertex3f(x1, y1, z1);
        glVertex3f(x2, y2, z2);
    }
    
    glEnd();
}
