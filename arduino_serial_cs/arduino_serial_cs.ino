char c;
String SerialData;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(13, OUTPUT);
  digitalWrite(13, LOW);
}

void loop() {
  // put your main code here, to run repeatedly:
  if(c=="#"){
    if(SerialData=="uON#"){
      digitalWrite(13, HIGH);
    }
   else if(SerialData=="uOFF#") {
      digitalWrite(13, LOW);
   }
   c=0;
   SerialData="";
  }
}
