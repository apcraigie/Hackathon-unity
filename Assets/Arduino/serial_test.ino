 int led = 10;
char myCol[20];

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(led, OUTPUT);

  digitalWrite(led, HIGH);
}

void loop() {
  // put your main code here, to run repeatedly:
  int lf = 10;
  Serial.readBytesUntil(lf, myCol, 1);

  if(strcmp(myCol, "o") ==0){
    digitalWrite(led, HIGH);
  }

  if(strcmp(myCol, "f") ==0){
    digitalWrite(led, LOW);  
  }
  
  }
