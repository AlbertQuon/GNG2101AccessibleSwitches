const int butL = 12, butR = 11, butU = 10, butD = 9, butE = 8;


int bsL = 0, bsR = 0, bsU = 0, bsD = 0, bsE = 0;

void setup() {
  Serial.begin(9600);
  pinMode(butL, INPUT_PULLUP);
  pinMode(butR, INPUT_PULLUP);
  pinMode(butU, INPUT_PULLUP);
  pinMode(butD, INPUT_PULLUP);
  pinMode(butE, INPUT_PULLUP);
}
void loop() {

  bsL = digitalRead(butL);
  bsR = digitalRead(butR);
  bsU = digitalRead(butU);
  bsD = digitalRead(butD);
  bsE = digitalRead(butE);

  if (bsL == LOW) {Serial.println("Left");} 
  else {bsL = HIGH;}

  if (bsR == LOW) {Serial.println("Right");} 
  else {bsR = HIGH;}

  if (bsU == LOW) {Serial.println("Up");} 
  else {bsU = HIGH;}

  if (bsD == LOW) {Serial.println("Down");} 
  else {bsD = HIGH;}

  if (bsE == LOW) {Serial.println("Enter");} 
  else {bsE = HIGH;}

  delay(500);
}
