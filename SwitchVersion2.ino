  
#include "Mouse.h"

// pins of the switch
const int mouseButton = 8;

int clickState = digitalRead(mouseButton);

int d = 50;

// variables will change:or reading the pushbutton status

void setup() {
  Serial.begin(9600);
  pinMode(mouseButton, INPUT_PULLUP);
}

void loop() {

  clickState = digitalRead(mouseButton);

  if(clickState == LOW) { 
    Serial.write("switch");
    delay(100);
  }

  delay(d);
  
}
