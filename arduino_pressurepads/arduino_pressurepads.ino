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
     Serial.println("Sensor1");
   if (analogReading2 > 5)     
     Serial.println("Sensor2");
   if (analogReading3 > 5)     
     Serial.println("Sensor3");

   Serial.println("No Signal");
   delay(200);
}
