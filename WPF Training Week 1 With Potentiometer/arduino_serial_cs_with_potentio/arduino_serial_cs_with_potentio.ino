#include <Servo.h>

Servo myServo;
char c, a;
String DataIn, DataInLED;
int8_t indexOfA, indexOfB;
uint16_t analogData, degree, servodegree, buttondegree;
int  degree2;
const int LED = 7;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  myServo.attach(9);
  myServo.write(45);
  pinMode (12, INPUT_PULLUP);
  pinMode(7, OUTPUT);
  digitalWrite(7, LOW);
}


void Receive_Serial_Data(){
   
  while(Serial.available()>0){
    c = Serial.read();
    if (c =='\n') {
      break;
      }
    else          {
      DataIn+=c;
      }
  }
  
  if(c == '\n')
  {
   degree2 = DataIn.toInt();
   c=0;
   DataIn="";
  }

   if(DataIn == "ON#"){
      digitalWrite(LED, HIGH);
    }
    
   else if(DataIn == "OFF#") {
      digitalWrite(LED, LOW);
   }
   c=0;
   DataIn="";
      
  }


void perseData() {
  String servo, button;

  indexOfA = DataIn.indexOf("A");
  indexOfB = DataIn.indexOf("B");

  if (indexOfA > -1) {
    servo = DataIn.substring(0, indexOfA);
    servodegree = servo.toInt();
  }

  if (indexOfB > -1) {
    button = DataIn.substring(indexOfA - 2, indexOfB + 3);
    buttondegree = button.toInt();
  }
}
   void loop() {
  // put your main code here, to run repeatedly:
  analogData = analogRead(A0)/17;
  degree = 45 + analogData;
  Serial.println ((String)degree + "A");
  Receive_Serial_Data();
  myServo.write(degree2);
  if (digitalRead(12)==LOW) {
    Serial.println ((String)degree +"A" + degree + "B");
  }
    delay(15);
}
   
