# HoloLens2_MRTK
Test Build for the HoloLens2

Had issues with:
  1) Hololens 1 and 2 deployed application with objects fixed to the headset's orientation.
  2) Hololens2 ran MRTK application as on a window rather than in AR.
     - [Solution](https://simmer.io/@DreVinciGames/haven) : Project Settings->Player->XR Settings: Make sure Virtual Reality Supported is checked true and Windows Mixed Reality SDK is added. 
