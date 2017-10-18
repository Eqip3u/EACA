#include "ofApp.h"

int A[750000];
int B[750000];

int w = 1000;
int h = 750;

bool state = true;
//--------------------------------------------------------------
void ofApp::setup(){
    ofSetFrameRate(30);

    for (int i=0; i<750000; i++)
        A[i] = 0;
}

//--------------------------------------------------------------
void ofApp::update(){
    if (!state)
        CycleLife();
}

//--------------------------------------------------------------
void ofApp::draw(){
    ofBackground(0,0,0);
    
    for (int y=0; y<h; y++)
        for (int x=0; x < w; x++){
            if (A[x+w*y] == 1) {
                ofSetColor(255,255,255);
                ofRect(x*3, y*3, 3, 3);
            }
        }
}

//--------------------------------------------------------------
void ofApp::keyPressed(int key){
    if(key == OF_KEY_RETURN)
        state = false;
}

//--------------------------------------------------------------
void ofApp::mousePressed(int x, int y, int button){
    A[(x/3) + w * (y/3)] = 1;
}

int ofApp::Check(int a, int b){
    if(a>=0 && a<w && b>=0 && b<h)
        return A[a+w*b];
    return 0;
}

void ofApp::CheckFriends()
{
    for(int x = 0; x < w; x++)
        for (int y = 0; y < h; y++)
        {
            int count = 0;
            count += Check(x - 1,y);
            count += Check(x - 1,y + 1);
            count += Check(x - 1,y - 1);
            count += Check(x,y + 1);
            count += Check(x,y - 1);
            count += Check(x + 1,y - 1);
            count += Check(x + 1,y);
            count += Check(x + 1,y + 1);
            
            if(count == 3 && A[x + y * w] == 0)
                B[x+w*y] = 1;
            
            if(count != 3 && count != 2 && A[x + y * w] == 1)
                B[x+w*y] = 0;
        }
}

void ofApp::CycleLife()
{
    for(int x = 0; x < w; x++)
        for (int y = 0; y < h; y++)
            B[x + y * w] = A[x + y * w];
    
    CheckFriends();
    
    for(int x = 0; x < w; x++)
        for (int y = 0; y < h; y++)
            A[x + w * y] = B[x + w * y];
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
//--------------------------------------------------------------
void ofApp::keyReleased(int key){
    
}

//--------------------------------------------------------------
void ofApp::mouseMoved(int x, int y ){
    
}

//--------------------------------------------------------------
void ofApp::mouseDragged(int x, int y, int button){
    
}
