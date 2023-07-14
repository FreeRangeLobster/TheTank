#include <Arduino.h>
#include <WiFi.h>
//https://randomnerdtutorials.com/esp32-web-server-arduino-ide/
#include <DS18B20.h>
#include "time.h"
#include <EEPROM.h>

#define LOW_ALARM 20
#define HIGH_ALARM 25

DS18B20 ds(13);   //IO13

//Wifi credentials
const char* ssid = "DeaHT-Uffici";
const char* password = "*r6pHoPh-c";

// Set web server port number to 80
WiFiServer server(80);

// Variable to store the HTTP request
String header;

// Auxiliar variables to store the current output state
String output26State = "off";
String output27State = "off";
String output3State  = "off";
String output4State  = "off";

// Assign output variables to GPIO pins
const int output26 = 2;
const int output27 = 15;

struct tm timeCurrentinfo;
// Current time
unsigned long currentTime = millis();
// Previous time
unsigned long previousTime = 0; 
// Define timeout time in milliseconds (example: 2000ms = 2s)
const long timeoutTime = 2000;

//Buzzer pin
#define BUZZER_PIN 18
 
//Relay Pins
byte pins[] = {2, 15, 5, 4};
byte pos = 0;

//Inputs
#define INPUT_PIN1 36
#define INPUT_PIN2 39
#define INPUT_PIN3 27
#define INPUT_PIN4 14

//time
const char* ntpServer = "pool.ntp.org";
const long  gmtOffset_sec = 3600;
const int   daylightOffset_sec = 3600;


//Serial commms
// pos++;
String content = "";
char character;

// define the number of bytes you want to access
#define EEPROM_SIZE 255

void printLocalTime(){
  struct tm timeinfo;
  if(!getLocalTime(&timeinfo)){
    Serial.println("Failed to obtain time");
    return;
  }
  Serial.println(&timeinfo, "%A, %B %d %Y %H:%M:%S");
  Serial.print("Day of week: ");
  Serial.println(&timeinfo, "%A");
 
  Serial.printf("Days from sunday: %d", timeinfo.tm_wday);   //tm_wday
  Serial.println();
  Serial.print("Month: ");
  Serial.println(&timeinfo, "%B");
  Serial.print("Day of Month: ");
  Serial.println(&timeinfo, "%d");
  Serial.print("Year: ");
  Serial.println(&timeinfo, "%Y");
  Serial.print("Hour: ");
  Serial.println(&timeinfo, "%H");
  Serial.print("Hour (12 hour format): ");
  Serial.println(&timeinfo, "%I");
  Serial.print("Minute: ");
  Serial.println(&timeinfo, "%M");
  Serial.print("Second: ");
  Serial.println(&timeinfo, "%S");

  Serial.println("Time variables");
  char timeHour[3];
  strftime(timeHour,3, "%H", &timeinfo);
  Serial.println(timeHour);
  char timeWeekDay[10];
  strftime(timeWeekDay,10, "%A", &timeinfo);
  Serial.println(timeWeekDay);
  Serial.println();
}

void setTime(int yr, int month, int mday, int hr, int minute, int sec, int isDst){
  struct tm tm;

  tm.tm_year = yr - 1900;   // Set date
  tm.tm_mon = month-1;
  tm.tm_mday = mday;
  tm.tm_hour = hr;      // Set time
  tm.tm_min = minute;
  tm.tm_sec = sec;
  tm.tm_isdst = isDst;  // 1 or 0
  time_t t = mktime(&tm);
  Serial.printf("Setting time: %s", asctime(&tm));
  struct timeval now = { .tv_sec = t };
  settimeofday(&now, NULL);
}

uint CurrentTimeGetHour(tm timeinfo){
  // Serial.printf("Hour: %d", timeinfo.tm_hour);
  return timeinfo.tm_hour;
}

uint CurrentTimeGetMinute(tm timeinfo){
  // Serial.printf("Min: %d", timeinfo.tm_min);
  return timeinfo.tm_min;
}

uint CurrentTimeGetDayFromSun(tm timeinfo){
  // Serial.printf("Days from sunday: %d", timeinfo.tm_wday);
  return timeinfo.tm_wday;
}

void setup() {

  Serial.begin(115200);
  Serial.println("Start Kincony KC868-A4 Relays example…");
  pinMode(pins[0], OUTPUT);
  pinMode(pins[1], OUTPUT);
  pinMode(pins[2], OUTPUT);
  pinMode(pins[3], OUTPUT);
  pinMode(BUZZER_PIN, OUTPUT);

  Serial.print(ds.getTempC());
  Serial.println(" C\n");

  //Buzzer
  //digitalWrite(BUZZER_PIN, HIGH); delay(200);
  //digitalWrite(BUZZER_PIN, LOW);  delay(500);
  
  pinMode(INPUT_PIN1, INPUT);
  pinMode(INPUT_PIN2, INPUT);
  pinMode(INPUT_PIN3, INPUT);
  pinMode(INPUT_PIN4, INPUT);


// Connect to Wi-Fi network with SSID and password
  Serial.print("Connecting to ");
  Serial.println(ssid);
  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }
  // Print local IP address and start web server
  Serial.println("");
  Serial.println("WiFi connected.");
  Serial.println("IP address: ");
  Serial.println(WiFi.localIP());
  server.begin();


  // Initialise time
  //
  //configTime(gmtOffset_sec, daylightOffset_sec, ntpServer);
  setTime(2023,01,01,9,29,0,1);



  printLocalTime();

  EEPROM.begin(EEPROM_SIZE);

  // EEPROM.write(0, 255);
  // EEPROM.commit();
  // int a=0;
  // a=EEPROM.read(0);
  // Serial.print("Saved: ");
  // Serial.println(a);

   //ledState = EEPROM.read(0);
   //EEPROM.write(address, value);

}


#pragma region Get details of events from memory

//|  2bit        | 3 bit     | 5  bit    |   5  bit     |   1 bit   |
//|--------------|-----------|-----------|--------------|-----------|
//| Output(0-3)  |  Day(0-7) | Hour(0-24)|  Min*2(0-60) | State(0-1)|

//Where 
//Output = 00-11 (0-3)
//  [Position in reg 14- 15]
//Day=000-110
//  [Position in reg 11- 13]
// 	  Mon(000)
//	  Tue(001)
//	  Wed(010)
//	  Thr(011)
//	  Fri(100)
//	  Sat(101)
//	  Sun(110)
//    Everyday(111)
//  Hour= 0 - 10111 (0-23) 
//  [Position in reg 6- 10] 
//	  1am= 00001
//	  2am= 00010
//	  12am= 12		 
//	  12pm= 0
//Minutes= 00000 - 11 11 0 () Due to the design constrains to reduce the number of bits in memory, odd numbers are rounded eg 11m is actually 10m 
//  [Position in reg 1- 5] 
//	  10m - 00101 => 5*2 = 10m
//	  11m - 11/2 =5 => 5*2 = 10m 
//	  20m - 01010 => 10*2= 20m
//	  30m - 01111 => 15*2= 30m
//	  40m - 10100 => 20*2= 10m
//	  50m - 11001 => 25*2= 10m
//State = 0-1 (0-1)
//  [Position in reg 0] 
//    1 On
//    0 Off

//| Address  0,1  | Event 0| 
//|-------|---------|
//Output =(1) 01
//Day = Tuesday 001
//Hour=23 1 0111
//Minute=30 11 11 0
//State= 0

//Summary: 01 001 1 0111 11 11 00
//binary   0100 1101 1111 1100 
//hex 0x4DFC
//Dec 19964



/// @brief Gets the output from the memory register
/// @param MemValue Memory value 0-255
/// @return value between 1-4
int GetFullEventFromMemRegisters(uint8_t MemValueLow, uint8_t MemValueHigh){
  uint16_t value;
  uint16_t FullValue;

  FullValue = (MemValueHigh << 8 ) | (MemValueLow & 0xff);
  //value = GetValueFromReg(FullValue,0b1100000000000000);
  return FullValue;
}

/// @brief Gets the relevant information from a memory position
/// @param MemValue 
/// @param mask 
/// @return 
uint16_t GetValueFromReg(uint16_t nFullEvent, uint16_t mask,uint8_t Position ){  
  uint16_t a=0;  
  //Build mask
  //Serial.println("---GetValueFromReg-----");
  //Serial.printf("Mask: %X \r",mask);
  //Serial.printf("GetValueFromReg ->Received: %X \r",nFullEvent);
  a = nFullEvent & mask;
  //Serial.printf("Conversion: %d \r",a);
  //Serial.printf("Conversion: %X \r",a);
  //Serial.println("-----------------------");
  a = a >> Position;
  //Convert to integer
  return a;
}

/// @brief Gets the output's number from  memory register
/// @param MemValue Memory value 0-255
/// @return value between 0-3
uint8_t GetOutputNumber(uint16_t MemValue){
    uint8_t a=0;
    a=GetValueFromReg(MemValue,0b1100000000000000,14);
    return a;
}

/// @brief Gets the output's state from the memory register
/// @param MemValue Memory value 0-255
/// @return value between 0-1
uint8_t GetOutputState(uint16_t MemValue){
   uint8_t a=0;
    a=GetValueFromReg(MemValue,0b0000000000000001,0);
    return a;
}

/// @brief Gets hour from the memory register
/// @param MemValue Memory value 0-255
/// @return value between 0-1
int GetDayFromMemReg(uint16_t MemValue){
  //|  2bit        | 3 bit     | 5  bit    |   5  bit     |   1 bit   |
  //|--------------|-----------|-----------|--------------|-----------|
  //| Output(0-3)  |  Day(0-7) | Hour(0-24)|  Min*2(0-60) | State(0-1)|
  uint8_t a=0;
  a=GetValueFromReg(MemValue,0b0011100000000000,11);
  return a;
}

/// @brief Gets hour from the memory register
/// @param MemValue Memory value 0-255
/// @return value between 0-1
int GetHourFromMemReg(uint16_t MemValue){
  //|  2bit        | 3 bit     | 5  bit    |   5  bit     |   1 bit   |
  //|--------------|-----------|-----------|--------------|-----------|
  //| Output(0-3)  |  Day(0-7) | Hour(0-24)|  Min*2(0-60) | State(0-1)|

  uint8_t a=0;
  a=GetValueFromReg(MemValue,0b0000011111000000,6);
  return a;
}

/// @brief Gets the output's state from the memory register
/// @param MemValue Memory value 0-255
/// @return value between 0-1
int GetMinFromMemReg(uint16_t MemValue){
  uint8_t a=0;
  a=GetValueFromReg(MemValue,0b0000000000111110,1);
  return a*2;
}

void PrintEventDetails(uint8_t MemValueLow, uint8_t MemValueHigh){  
  int FullMemValue = GetFullEventFromMemRegisters(MemValueLow,MemValueHigh);
  int nDay=GetDayFromMemReg(FullMemValue);
  int nHour=GetHourFromMemReg(FullMemValue);
  int nMinute=GetMinFromMemReg(FullMemValue);
  int OutputNumber=GetOutputNumber(FullMemValue);
  int OutputState=GetOutputState(FullMemValue);

  Serial.printf("Event dec: %d - High %X Low %X \t DayFromSun:%d \t Hour:%d \t Minute:%d \t Output:%d \t State: %d",FullMemValue,MemValueHigh,MemValueLow,nDay,nHour,nMinute,OutputNumber,OutputState);
  Serial.println("");
}


void ReadMemory(){

  for (size_t i = 0; i < 50; i++)
  {
    int a=EEPROM.read(i);
    Serial.printf("Flash Raw Position: %d \t Value: %X",i,a);
    Serial.println("");
  }  

  for (size_t i = 0; i < 50; i++)
  {
    int HightReg=EEPROM.read(i*2);
    int LowReg=EEPROM.read(1+(i*2)); //low
    Serial.printf("Mem Pos: %d \t :Value %X %X  ",i,HightReg,LowReg); 
    PrintEventDetails(LowReg,HightReg);
  }  
}

#pragma endregion








void clearAllOutputs() {

  digitalWrite(pins[0], LOW);

  digitalWrite(pins[1], LOW);

  digitalWrite(pins[2], LOW);

  digitalWrite(pins[3], LOW);

}

void ModStateOutput(byte nOutput,byte nState) 
{

  //Update the web server
  if (nOutput==0)
  {
    if (nState==0)
    {
      output26State = "off";
    }
    else{
      output26State = "on";
    }    
  }

  if (nOutput==1)
  {
    if (nState==0)
    {
      output27State = "off";
    }
    else{
      output27State = "on";
    }    
  }

  if (nOutput==2)
  {
    if (nState==0)
    {
      output3State = "off";
    }
    else{
      output3State = "on";
    }    
  }

  if (nOutput==3)
  {
    if (nState==0)
    {
      output4State = "off";
    }
    else{
      output4State = "on";
    }    
  }
  
  //Update the pcb outputs
  if (nState==1)
  {
    digitalWrite(pins[nOutput], HIGH);
  }
  else{
     digitalWrite(pins[nOutput],LOW);
  }
}

/// @brief Checks if the string received is compliant with the lenght expected
/// @param sReceived String received
/// @return true if the string has the correct lenght
bool ValidateStringEvent(String sReceived){
  if(sReceived.length()>=8){
    return true;
  }    
  else{
    return false;
  }       
}


int StrToHex(char str[])
{
  return (int) strtol(str, 0, 16);
}

/// @brief Get the address where the information should be saved
/// @param sReceived string received from the serial number
/// @return byte address of the position
int GetAddress(String sReceived){
  // E:004DFC
  String sAddress="";
  sAddress=sReceived.substring(2,4);  
  Serial.print("Address: ");
  Serial.print(sAddress);
  Serial.print("In Integer: "); 
  byte byteNumber=1; 
  byteNumber=sAddress.toInt();
  Serial.println(byteNumber);
  return byteNumber;
}


byte TopSide(String sReceived){
  // E:004DFC
  String sStrInterest="";
  sStrInterest=sReceived.substring(4,6);  
  Serial.print("Top Side: ");
  Serial.print(sStrInterest);
  Serial.print("In Integer: "); 
  byte byteNumber=1; 

  char input[3];
  int charsRead;
  int val;

  // Define 
  String str = sStrInterest; 
  // Length (with one extra character for the null terminator)
  int str_len = str.length() + 1; 
  // Prepare the character array (the buffer) 
  char char_array[str_len];
  // Copy it over 
  str.toCharArray(char_array, str_len);
  byteNumber=StrToHex(char_array);
  Serial.print("numero: "); 
  Serial.println(byteNumber);
  return byteNumber;
}


byte SplitAndConvertByte(String sReceived, byte nStart, byte nFinish ){
   // E:004DFC
  String sStrInterest="";
  sStrInterest=sReceived.substring(nStart,nFinish);  
  Serial.println(sStrInterest);
  Serial.printf(" -Split And Convert Byte: Start:%d  Finish:%d",nStart,nFinish);
  Serial.print(" In Integer: "); 
  byte byteNumber=1; 

  // Define 
  String str = sStrInterest; 
  // Length (with one extra character for the null terminator)
  int str_len = str.length() + 1; 
  // Prepare the character array (the buffer) 
  char char_array[str_len];
  // Copy it over 
  str.toCharArray(char_array, str_len);
  byteNumber=StrToHex(char_array);
  Serial.print("numero: "); 
  Serial.println(byteNumber);
  return byteNumber;
}

bool CheckEvent( uint8_t MemValueHigh,uint8_t MemValueLow, tm timeinfo){
      //Current time
      uint nHour;
      uint nMinute;
      uint nDay;
      uint nOutput;

      nHour= CurrentTimeGetHour(timeinfo);
      nMinute =CurrentTimeGetMinute(timeinfo);
      nDay= CurrentTimeGetDayFromSun(timeinfo);

      int FullMemValue = GetFullEventFromMemRegisters(MemValueLow,MemValueHigh);
      //Serial.printf("--Current Hour: %d,Minute: %d,Day from Sun: %d, --HighVal %d, --LowVal %d, Mem Val 0x%X, value in dec %d ", nHour,nMinute,nDay,MemValueHigh,MemValueLow,FullMemValue, FullMemValue);         
      Serial.println("");

      //Memory
      uint nMemHour;
      uint nMemMinute;
      uint nMemDay;
      uint nMemOutputState;
      uint nMemOutputNumber;

      nMemOutputNumber=GetOutputNumber(FullMemValue);     
      nMemDay=GetDayFromMemReg(FullMemValue);      
      nMemHour=GetHourFromMemReg(FullMemValue);    
      nMemMinute=GetMinFromMemReg(FullMemValue);     
      nMemOutputState =GetOutputState(FullMemValue);

      if (FullMemValue==65535)
      {
        Serial.println("Event Empty"); 
        return false;
      }
      
      Serial.printf("--Memory \t nDay: %d,\t Hour: %d,\t Min: %d, OutputNumber %d, State %d", nMemDay,nMemHour,nMemMinute,nMemOutputNumber,nMemOutputState );
      Serial.println(""); 
      Serial.printf("-Current \t nDay: %d,\t Hour: %d,\t Min: %d,\t --HighVal %d, --LowVal %d, Mem Val 0x%X, value in dec %d ", nDay,nHour,nMinute,MemValueHigh,MemValueLow,FullMemValue, FullMemValue);                        
      Serial.println(""); 


      //If the event is empty
      if (FullMemValue==65535)
      {
        Serial.print("Event Empty"); 
        return false;
      }
      
      //Day day=111 everyday
      if(nMemDay!=0b111){
        if ( nMemDay!=nDay)
            {
              Serial.println("DayNOK "); 
              return false;
            }
      }

      //Hour
      if (nMemHour!=nHour)
      {
        Serial.print("HourNOK "); 
        return false;
      }

      //Minute

      if (nMemMinute !=nMinute)
      {
        Serial.printf("CalcMem: %d ,Current: %d   ",nMemMinute,nMinute );
        Serial.println("MinuteNOK "); 
        return false;
      }

      ModStateOutput(nMemOutputNumber,nMemOutputState);

      //Update output
      Serial.printf("Updated output: %d state %d\r",nMemOutputNumber,nMemOutputState);
      Serial.println(""); 
      return true; 
}

bool TimeToCheckEvenMinute(){
      struct tm timeinfo;

      if(!getLocalTime(&timeinfo)){
        Serial.println("Failed to obtain time");
        return false;
      }

      uint nSecond;
      nSecond=timeinfo.tm_sec;
      if (nSecond==0)
      {
        Serial.printf("Second: %d", nSecond);
        Serial.println("Checking minutes");

      }
      else{
        return false;
      }
      
      uint nMinute;
      nMinute= CurrentTimeGetMinute(timeinfo);         
      if ( nMinute % 2 == 0)
      {
        Serial.printf("Even minute: %d", nMinute);
      }
      else {
        Serial.printf("Odd minute: %d", nMinute);
      }

      return true;
}

void loop() {

  WiFiClient client = server.available();   // Listen for incoming clients

  //Web Server
  if (client) {                             // If a new client connects,
    currentTime = millis();
    previousTime = currentTime;
    Serial.println("New Client.");          // print a message out in the serial port
    String currentLine = "";                // make a String to hold incoming data from the client
    while (client.connected() && currentTime - previousTime <= timeoutTime) {  // loop while the client's connected
      currentTime = millis();
      if (client.available()) {             // if there's bytes to read from the client,
        char c = client.read();             // read a byte, then
        Serial.write(c);                    // print it out the serial monitor
        header += c;
        if (c == '\n') {                    // if the byte is a newline character
          // if the current line is blank, you got two newline characters in a row.
          // that's the end of the client HTTP request, so send a response:
          if (currentLine.length() == 0) {
            // HTTP headers always start with a response code (e.g. HTTP/1.1 200 OK)
            // and a content-type so the client knows what's coming, then a blank line:
            client.println("HTTP/1.1 200 OK");
            client.println("Content-type:text/html");
            client.println("Connection: close");
            client.println();
            
            // turns the GPIOs on and off
            if (header.indexOf("GET /26/on") >= 0) {
              Serial.println("GPIO 26 on");
              output26State = "on";
              digitalWrite(output26, HIGH);
            } else if (header.indexOf("GET /26/off") >= 0) {
              Serial.println("GPIO 26 off");
              output26State = "off";
              digitalWrite(output26, LOW);
            } else if (header.indexOf("GET /27/on") >= 0) {
              Serial.println("GPIO 27 on");
              output27State = "on";
              digitalWrite(output27, HIGH);
            } else if (header.indexOf("GET /27/off") >= 0) {
              Serial.println("GPIO 27 off");
              output27State = "off";
              digitalWrite(output27, LOW);
            } else if (header.indexOf("GET /3/on") >= 0) {
              Serial.println("GPIO 3 on");
              output3State = "on";
              digitalWrite(pins[2], HIGH);
            } else if (header.indexOf("GET /3/off") >= 0) {
              Serial.println("GPIO 3 off");
              output3State = "off";
              digitalWrite(pins[2], LOW);
            }else if (header.indexOf("GET /4/on") >= 0) {
              Serial.println("GPIO 4 on");
              output4State = "on";
              digitalWrite(pins[3], HIGH);
            } else if (header.indexOf("GET /4/off") >= 0) {
              Serial.println("GPIO 4 off");
              output4State = "off";
              digitalWrite(pins[3], LOW);
            }
            




            // Display the HTML web page
            client.println("<!DOCTYPE html><html>");
            client.println("<head><meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">");
            client.println("<link rel=\"icon\" href=\"data:,\">");
            // CSS to style the on/off buttons 
            // Feel free to change the background-color and font-size attributes to fit your preferences
            client.println("<style>html { font-family: Helvetica; display: inline-block; margin: 0px auto; text-align: center;}");
            client.println(".button { background-color: #4CAF50; border: none; color: white; padding: 16px 40px;");
            client.println("text-decoration: none; font-size: 30px; margin: 2px; cursor: pointer;}");
            client.println(".button2 {background-color: #555555;}</style></head>");
            
            // Web Page Heading
            client.println("<body><h1>Llama Tank Web Server</h1>");


            // Display current Temperature  
             float temperature;
             temperature= ds.getTempC();
             String sTemperature= (String)temperature;
            client.println("<p>Temperature[deg C] " + sTemperature + "</p>");

            //display current time
            struct tm timeinfo;
            if(!getLocalTime(&timeinfo)){
              Serial.println("Failed to obtain time");      
            }                          
            client.printf("<p>Timestamp  %d:%d:%d  </p>",timeinfo.tm_hour,timeinfo.tm_min,timeinfo.tm_sec);
          
            
            // Display current state, and ON/OFF buttons for GPIO 26  
            client.println("<p>GPIO 26 - State " + output26State + "</p>");
            // If the output26State is off, it displays the ON button       
            if (output26State=="off") {
              client.println("<p><a href=\"/26/on\"><button class=\"button\">ON</button></a></p>");
            } else {
              client.println("<p><a href=\"/26/off\"><button class=\"button button2\">OFF</button></a></p>");
            } 
               
            // Display current state, and ON/OFF buttons for GPIO 27  
            client.println("<p>GPIO 27 - State " + output27State + "</p>");
            // If the output27State is off, it displays the ON button       
            if (output27State=="off") {
              client.println("<p><a href=\"/27/on\"><button class=\"button\">ON</button></a></p>");
            } else {
              client.println("<p><a href=\"/27/off\"><button class=\"button button2\">OFF</button></a></p>");
            }
          
            // Display current state, and ON/OFF buttons for GPIO 5 
            client.println("<p>GPIO 3 - State " + output3State + "</p>");
            // If the output27State is off, it displays the ON button       
            if (output3State=="off") {
              client.println("<p><a href=\"/3/on\"><button class=\"button\">ON</button></a></p>");
            } else {
              client.println("<p><a href=\"/3/off\"><button class=\"button button2\">OFF</button></a></p>");
            }

            // Display current state, and ON/OFF buttons for GPIO 5 
            client.println("<p>GPIO 4 - State " + output4State + "</p>");
            // If the output27State is off, it displays the ON button       
            if (output4State=="off") {
              client.println("<p><a href=\"/4/on\"><button class=\"button\">ON</button></a></p>");
            } else {
              client.println("<p><a href=\"/4/off\"><button class=\"button button2\">OFF</button></a></p>");
            }


            client.println("</body></html>");
            
            // The HTTP response ends with another blank line
            client.println();
            // Break out of the while loop
            break;
          } else { // if you got a newline, then clear currentLine
            currentLine = "";
          }
        } else if (c != '\r') {  // if you got anything else but a carriage return character,
          currentLine += c;      // add it to the end of the currentLine
        }
      }
    }
    // Clear the header variable
    header = "";
    // Close the connection
    client.stop();
    Serial.println("Client disconnected.");
    Serial.println("");
  }
  
  

  delay(500);

  //switch case to deal with serial commands
  if(Serial.available()){
    //get the serial contents
    while(Serial.available()) {
      character = Serial.read();
      content.concat(character);
    }
    Serial.println(content);


    if (content.startsWith("Show"))
    {

     
      
      uint16_t FullMemValue;
      uint16_t OutputNumber;
      uint16_t OutputState;
      uint16_t nDay;
      uint16_t nHour;
      uint16_t nMinute;
   
      FullMemValue = GetFullEventFromMemRegisters(252,77);
      Serial.printf("Full Number in dec: %d \n: Value:",FullMemValue);
      Serial.printf("Full Number in hex: %X \r: Value:",FullMemValue);
      Serial.println("-----");


       ReadMemory();


      Serial.println("OutputNumber");
      OutputNumber=GetOutputNumber(FullMemValue);
      Serial.printf("Output: %d \r",OutputNumber);
      Serial.println("-----");

      Serial.println();
      Serial.println("GetDayFromMemReg");
      nDay=GetDayFromMemReg(FullMemValue);
      Serial.printf("nDay=: %d \r",nDay);
      Serial.println("-----");

      Serial.println();
      Serial.println("GetHourFromMemReg");
      nHour=GetHourFromMemReg(FullMemValue);
      Serial.printf("nHour: %d \r",nHour);
      Serial.println("-----");

      Serial.println();
      Serial.println("GetMinFromMemReg");
      nMinute=GetMinFromMemReg(FullMemValue);
      Serial.printf("nMinute: %d \r",nMinute);
      Serial.println("-----");


      Serial.println();
      Serial.println("GetOutputState");
      OutputState=GetOutputState(FullMemValue);
      Serial.printf("State: %d \r",OutputState);
      Serial.println("------------------------------------------");

      //3DF2
      FullMemValue = GetFullEventFromMemRegisters(242,61);
      Serial.printf("Full Number in dec: %d \n: Value:",FullMemValue);
      Serial.printf("Full Number in hex: %X \r: Value:",FullMemValue);
      Serial.println("-----");


      Serial.println("OutputNumber");
      OutputNumber=GetOutputNumber(FullMemValue);
      Serial.printf("Output: %d \r",OutputNumber);
      Serial.println("-----");

      Serial.println();
      Serial.println("GetDayFromMemReg");
      nDay=GetDayFromMemReg(FullMemValue);
      Serial.printf("nDay=: %d \r",nDay);
      Serial.println("-----");

      Serial.println();
      Serial.println("GetHourFromMemReg");
      nHour=GetHourFromMemReg(FullMemValue);
      Serial.printf("nHour: %d \r",nHour);
      Serial.println("-----");

      Serial.println();
      Serial.println("GetMinFromMemReg");
      nMinute=GetMinFromMemReg(FullMemValue);
      Serial.printf("nMinute: %d \r",nMinute);
      Serial.println("-----");

      Serial.println();
      Serial.println("GetOutputState");
      OutputState=GetOutputState(FullMemValue);
      Serial.printf("State: %d \r",OutputState);
      Serial.println("------------------------------------------");



    }


    if (content.startsWith("CheckEvent"))
    {
   
      Serial.println("-----Start-------");
     struct tm timeinfo;
      if(!getLocalTime(&timeinfo)){
        Serial.println("Failed to obtain time");      
      }
      CheckEvent(10,10,timeinfo);
      Serial.println("-----Finish-------");  
      Serial.println();
      Serial.println();
      Serial.println();

    }   

    if(ValidateStringEvent(content)) {
      Serial.println("OK lenght"); 
      GetAddress(content); 
      TopSide(content); 
      //BottomSide(content); 

      byte val;
      byte Address;
      byte HighSide;
      byte LowSide;
      Address = SplitAndConvertByte(content,2,4);
      HighSide = SplitAndConvertByte(content,4,6);    
      LowSide = SplitAndConvertByte(content,6,8); 

      EEPROM.write((Address*2), HighSide); 
      EEPROM.write((Address*2)+1, LowSide);
      EEPROM.commit(); 

      Serial.printf("Address: %d HighByte: %d LowByte: %d \n", Address,HighSide,LowSide );
       

      int nhighSide=0;
      int nlowSide=0;
      nhighSide=EEPROM.read(Address*2);
      nlowSide=EEPROM.read((Address*2)+1); 

      Serial.printf("In Memory Address: %d HighByte: In Memory Address: %d \n", Address*2,nhighSide);
      Serial.printf("In Memory Address: %d LowByte: In Memory Address: %d  \n",(Address*2)+1,nlowSide);
      Serial.println("----");

      ReadMemory();

    }  
    content="";   

      // //change(pos);
  //  Serial.println("Hello cruel world of serial");
      Serial.print("IN1: "); Serial.println(digitalRead(INPUT_PIN1));
      Serial.print("IN2: "); Serial.println(digitalRead(INPUT_PIN2));
      Serial.print("IN3: "); Serial.println(digitalRead(INPUT_PIN3));
      Serial.print("IN4: "); Serial.println(digitalRead(INPUT_PIN4));

  // delay(10000);


  }    
    
  //Event catching
  if(TimeToCheckEvenMinute()==true)  {
    Serial.println("Checking from main");

    byte byLow;
    byte byHigh;

    struct tm timeinfo;
    if(!getLocalTime(&timeinfo)){
      Serial.println("Failed to obtain time");      
    }

   
    for (int i = 0; i < 50; i++)
    {
      byLow=1;
      byHigh=1;
   
      byHigh = EEPROM.read(i*2);
      byLow = EEPROM.read(1+(i*2));


      if (CheckEvent(byHigh,byLow,timeinfo)==true)
      {
        Serial.println("***************Event Found******************");
      }

    }
    Serial.print("Out0: "); Serial.println(digitalRead(pins[0]));
    Serial.print("Out1: "); Serial.println(digitalRead(pins[1]));
    Serial.print("Out2: "); Serial.println(digitalRead(pins[2]));
    Serial.print("Out3: "); Serial.println(digitalRead(pins[3]));



  }


}


