
# react-native-race-motor-exhibition-show

## Getting started

`$ npm install react-native-race-motor-exhibition-show --save`

### Mostly automatic installation

`$ react-native link react-native-race-motor-exhibition-show`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-race-motor-exhibition-show` and add `RNRaceMotorExhibitionShow.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNRaceMotorExhibitionShow.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNRaceMotorExhibitionShowPackage;` to the imports at the top of the file
  - Add `new RNRaceMotorExhibitionShowPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-race-motor-exhibition-show'
  	project(':react-native-race-motor-exhibition-show').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-race-motor-exhibition-show/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-race-motor-exhibition-show')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNRaceMotorExhibitionShow.sln` in `node_modules/react-native-race-motor-exhibition-show/windows/RNRaceMotorExhibitionShow.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Race.Motor.Exhibition.Show.RNRaceMotorExhibitionShow;` to the usings at the top of the file
  - Add `new RNRaceMotorExhibitionShowPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNRaceMotorExhibitionShow from 'react-native-race-motor-exhibition-show';

// TODO: What to do with the module?
RNRaceMotorExhibitionShow;
```
  