#include <Servo.h>

Servo myServo;

char c;
String DataIn;
int degree;


void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  pinMode(7, OUTPUT);
  digitalWrite(7, LOW);
  myServo.attach(9);
}

void loop() {
  // put your main code here, to run repeatedly:
  Receive_Serial_Data();
  myServo.write(degree);

}
void Receive_Serial_Data(){
   
  while(Serial.available()>0){
    c = Serial.read();
    if (c =='\n') {break;}
    else          {DataIn+=c;}
  }
  
  if(c == '\n'){
    degree = DataIn.toInt();
   c=0;
   DataIn="";
  }
  
  else if(c == '#')
    {
      if(DataIn == "ON#"){
      digitalWrite(7, HIGH);
    }
    
   else if(DataIn == "OFF#") {
      digitalWrite(7, LOW);
   }
      c=0;
      DataIn="";
   }  
   }
