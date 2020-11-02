#include "Mouse.h"
// pins of the switch
//const int upButton = 10;
//const int downButton = 9;
//const int leftButton = 11;
//const int rightButton = 12;
const int mouseButton = 8;

//int upState = digitalRead(upButton);
//int downState = digitalRead(downButton);
//int rightState = digitalRead(rightButton);
//int leftState = digitalRead(leftButton);
int clickState = digitalRead(mouseButton);

int d = 5;
int range = 5;

// variables will change:or reading the pushbutton status

void setup() {
  Serial.begin(9600);
//  pinMode(upButton, INPUT_PULLUP);
//  pinMode(downButton, INPUT_PULLUP);
//  pinMode(leftButton, INPUT_PULLUP);
//  pinMode(rightButton, INPUT_PULLUP);
  pinMode(mouseButton, INPUT_PULLUP);
}
void loop() {
//  upState = digitalRead(upButton);
//  downState = digitalRead(downButton);
//  leftState = digitalRead(leftButton);
//  rightState = digitalRead(rightButton);
  clickState = digitalRead(mouseButton);

  //begin of the program loop

  // calculate the movement distance based on the button states:
  int  xDistance;
  int  yDistance;

  //values for comparison
  int xCompare;
  int yCompare;


//Moving in the x direction
  while(clickState == HIGH){
    xDistance = (leftState - rightState) * range;
    xCompare = xDistance;
    Mouse.move(1, 0, 0);
    if(xCompare==xDistance){
      while(clickState == HIGH){
        xDistance = (leftState - rightState) * range;
        xCompare = xDistance;
        Mouse.move(-1, 0, 0);
        if(xCompare==xDistance){
          break;
          }
      }
     }
    }

//Moving in the y direction
  while(clickState == HIGH){
    yDistance = (upState - downState) * range;
    yCompare = yDistance;
    Mouse.move(0, 1, 0);
    if(yCompare==yDistance){
      while(clickState == HIGH){
        yDistance = (upState - downState) * range;
        yCompare = yDistance;
        Mouse.move(0, -1, 0);
        if(yCompare==yDistance){
          break;
          }
      }
     }
    }

if(clickState == LOW) { 
    Mouse.click(); 
    delay(100);
  }
  
//  if(upState == LOW) { Mouse.move(0, 1, 0); }
//  else if(downState == LOW) { Mouse.move(0, -1, 0); }
//  else if(leftState == LOW) { Mouse.move(-1, 0, 0); }
//  else if(rightState == LOW) { Mouse.move(1, 0, 0); }
//  //else if(clickState == LOW) { Mouse.click(); }
//  else if(clickState == LOW) { 
//    Mouse.click(); 
//    delay(100);
//  }

  delay(d);

}
