#include "Mouse.h"

// pins of the switch
const int upButton = 10;
const int downButton = 9;
const int leftButton = 11;
const int rightButton = 12;
const int mouseButton = 8;

int upState = digitalRead(upButton);
int downState = digitalRead(downButton);
int rightState = digitalRead(rightButton);
int leftState = digitalRead(leftButton);
int clickState = digitalRead(mouseButton);

int d = 5;

// variables will change:or reading the pushbutton status

void setup() {
  Serial.begin(9600);
  pinMode(upButton, INPUT_PULLUP);
  pinMode(downButton, INPUT_PULLUP);
  pinMode(leftButton, INPUT_PULLUP);
  pinMode(rightButton, INPUT_PULLUP);
  pinMode(mouseButton, INPUT_PULLUP);
}

void loop() {

  upState = digitalRead(upButton);
  downState = digitalRead(downButton);
  leftState = digitalRead(leftButton);
  rightState = digitalRead(rightButton);
  clickState = digitalRead(mouseButton);

  if(upState == LOW) { Mouse.move(0, 1, 0); }
  else if(downState == LOW) { Mouse.move(0, -1, 0); }
  else if(leftState == LOW) { Mouse.move(-1, 0, 0); }
  else if(rightState == LOW) { Mouse.move(1, 0, 0); }
  else if(clickState == LOW) { 
    Mouse.click(); 
    delay(100);
  }

  delay(d);
  
}
