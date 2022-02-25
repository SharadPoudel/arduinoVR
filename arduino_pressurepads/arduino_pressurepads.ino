#define FORCE_SENSOR_PIN1 A0 
#define FORCE_SENSOR_PIN2 A1 
#define FORCE_SENSOR_PIN3 A2 
#define FORCE_SENSOR_PIN4 A3

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
   int analogReading4 = analogRead(FORCE_SENSOR_PIN4);

   if (analogReading1 > 5)
     Serial.println("Sensor1_On");
   else
     Serial.println("Sensor1_Off");
   if (analogReading2 > 5)     
     Serial.println("Sensor2_On");
   else
     Serial.println("Sensor2_Off");
   if (analogReading3 > 5)     
     Serial.println("Sensor3_On");
   else
     Serial.println("Sensor3_Off");
   if (analogReading4 > 5)     
     Serial.println("Sensor4_On");
   else
     Serial.println("Sensor4_Off");

   
   delay(16);
}
