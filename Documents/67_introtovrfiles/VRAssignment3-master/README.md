# GoogleCardboardSampleProject
Google Cardboard Sample Project Introduction to Virtual Reality at New College Of Florida

# UNITY VERSION
6000.3.2f1

## Tutorial video on project set up can be found [here](https://www.youtube.com/watch?v=pf2dd4sg7XQ).

## PROJECT SET UP
If you are having issues upon project installation, double check everything below:

### Under Edit > Project Settings > Player

and make sure you are under the **ANDROID** tab, NOT the Windows tab.

- Under Resolution and Presentation:
    - Set the Default Orientation to Landscape Left
    - Disable Optimized Frame Pacing
 
- Under Other Settings:
    - Choose OpenGLES3 in Graphics APIs
    - Select Android 8.0 'Oreo' (API level 26) in Minimum API Level
    - Select API level 35 in Target API Level.
    - Select IL2CPP in Scripting Backend.
    - Select wanted architectures by choosing both ARMv7 and ARM64 in Target Architectures.
    - Select Require in Internet Access.
    - Select BOTH in Active Input Handling.
      - **THIS IS BECAUSE we are using the old input system to test the code in the Unity editor. When building your project, it may say you have both enabled which can cause issues for android builds. For the sake of this build, it should be fine to leave it set to "BOTH" but you can play around with setting it back to "Input System Package (New)" if you have issues when building to your phone.**
    - Select Activity and clear GameActivity in Application Entry Point.

### Inside the project, under Assets > Plugins

- In gradleTemplate.properties:
  
  _Ensure the file says:_


  > unityStreamingAssets=\*\*STREAMING_ASSETS\*\*
  >
  > org.gradle.jvmargs=-Xmx4096M
  >
  >  org.gradle.parallel=true

  > \# Fix: must be a real boolean value (Unity 6 / AGP 8+ will crash if blank)
  >
  > android.enableR8=true

  > android.enableJetifier=true
  >
  > android.useAndroidX=true
  
  If not, replace it with the above ^

- In mainTemplate.gradle:
  
  _Ensure the following are under the dependencies section:_

  
  > implementation 'androidx.appcompat:appcompat:1.6.1'
  >
  > implementation 'com.google.android.gms:play-services-vision:20.1.3'
  >
  > implementation 'com.google.android.material:material:1.12.0'
  >
  > implementation 'com.google.protobuf:protobuf-javalite:3.19.4'
  > 
** DO NOT DELETE ANYTHING THAT IS ALREADY THERE

### Build Settings and Building
Navigate to File > Build Profiles 
- Select "Android" and then "Switch Platform"
- Wait for it to switch and restart if necessary
- Ensure VR Example is in the Scene List

Under "Run Device"
- Plug your phone into your computer and hit refresh under Run Device until you see your phone.
- Select your phone and then click Build and Run, it should build to your device and then run the example scene.

### Source
The instructions in this README are a modified version from the official Google Cardboard set up page, which can be found [here](https://developers.google.com/cardboard/develop/unity/quickstart).
