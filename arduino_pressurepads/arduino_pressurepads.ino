#define FORCE_SENSOR_PIN1 A0 
#define FORCE_SENSOR_PIN2 A1 
#define FORCE_SENSOR_PIN3 A2 

unsigned long last_time = 0;

void setup()
{
    Serial.begin(9600);
}

void loop()
{
    
   int analogReading1 = analogRead(FORCE_SENSOR_PIN1);
   int analogReading2 = analogRead(FORCE_SENSOR_PIN2);
   int analogReading3 = analogRead(FORCE_SENSOR_PIN3);

   if (analogReading1 > 5)
     Serial.println("S1On");
   else
     Serial.println("S1Off");
   if (analogReading2 > 5)     
     Serial.println("S2On");
   else
     Serial.println("S2Off");
   if (analogReading3 > 5)     
     Serial.println("S3On");
   else
     Serial.println("S3Off");

   
   delay(16);
}
