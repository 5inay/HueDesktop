# HueDesktop
- - - -
HueDesktop is a simple Windows desktop application which can be used to **control** (turn ON/OFF, change brightness and color) a Philps Hue (Color Ambiance) system
with at least one bridge and a light (bulb, lightstrip etc.)

## Pre-requisites
1. Hue Bridge (Gen 1) connected to the same network as the Desktop running this app
2. Visual Studio 2015
3. .NET Framework > 4.5
4. NLog (NuGet package for logging)
5. Newtonsoft.JSON (NuGet package for JSON parsing)

## Instructions
1. Clone the repository and open *HueDesktop.sln* in Visual Studio 2015.
2. Clean and build the project (Debug or Release configuratons).
3. Run *HueDesktop.exe* in ***{project directory}/bin/Debug*** or ***{project directory}/bin/Release*** folder.
4. Press Hue Bridge button once and click *Connect* in UI to perform a *ONE_TIME* pairing operation.
5. Select any light in the list and change brightness. 
6. Click *Refresh* button in case the bridge is connected, but no lights are displayed.

## Limitations
1. Application has only been tested with the following combinations/versions of hardware
 a. Philips Hue Bridge Gen 1 (round)
 b. Hue Lamp model LCT001
 c. Hue Lamp model LCT007
 d. Hue Lightstrip LST001
2. These models have restrictions on the color range that can be set. In case of chosen colors that are 
outside the range-capability of the Hue lamp, the nearest matching color is chosen.

See https://www.developers.meethue.com/documentation/core-concepts and https://www.developers.meethue.com/documentation/supported-lights for more information. 
