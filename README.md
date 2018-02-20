# HueDesktop
- - - -
HueDesktop is a simple Windows desktop application which can be used to **control** (turn ON/OFF, change brightness and color) a Philps Hue (Color Ambiance) system with at least one bridge and a light (bulb, lightstrip etc.)

## Pre-requisites
1. Hue Bridge (Gen 1) connected to the same network as the Windows PC running this app
2. Visual Studio 2015
3. .NET Framework > 4.5
4. NLog (NuGet package for logging)
5. Newtonsoft.JSON (NuGet package for JSON parsing)

## Instructions
1. Clone the repository and open `HueDesktop.sln` in Visual Studio 2015.
2. Clean and build the project (Debug or Release configurations).
3. Run `HueDesktop.exe` in `<project directory>/bin/Debug` or `<project directory>/bin/Release` folder.
4. Press Hue Bridge button once and click **Connect** in UI to perform a **ONE-TIME** pairing operation.
5. Select any light in the list and change brightness. 
6. Click **REFRESH** button in case the bridge is connected, but no lights are displayed.
7. Click **RESET APP** in case a hard-reset is performed on the bridge (recessed bridge button on the mount-side of bridge pressed and held for 10 seconds).

## Limitations
1. Application has only been tested with the following combinations/versions of hardware
   - Philips Hue Bridge Gen 1 (round)
   - Hue Lamp model LCT001
   - Hue Lamp model LCT007
   - Hue Lightstrip LST001
2. These models have restrictions on the color range that can be set. In case of chosen colors that are 
outside the range-capability of the Hue lamp, the nearest matching color is chosen.

See [Core Concepts](https://www.developers.meethue.com/documentation/core-concepts) and [Supported Lights](https://www.developers.meethue.com/documentation/supported-lights) for more information (requires login, registration is free).
