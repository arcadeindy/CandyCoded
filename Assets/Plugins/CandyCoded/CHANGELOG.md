# Changelog

## [1.1.5] - 2019-02-10

### Bug Fixes

-   Fixed bug where Shuffle on ObservableList would return null. <https://github.com/CandyCoded/CandyCoded/pull/76>
-   Replaced reference to mousePosition in touch method. <https://github.com/CandyCoded/CandyCoded/pull/77>

### Features

-   Shuffle seed parameter <https://github.com/CandyCoded/CandyCoded/pull/75>
-   Refactored InputManager GetInputUp Methods <https://github.com/CandyCoded/CandyCoded/pull/78>

### Maintenance

-   Fixed code warnings <https://github.com/CandyCoded/CandyCoded/pull/79>
-   InputManager documentation <https://github.com/CandyCoded/CandyCoded/pull/80>

## [1.1.4] - 2019-02-03

### Maintenance

-   Sorted methods in code and documentation. <https://github.com/CandyCoded/CandyCoded/pull/72>

### Features

-   Added pop, shift and unshift list extensions. <https://github.com/CandyCoded/CandyCoded/pull/73>

## [1.1.3] - 2019-01-26

### Maintenance

-   Fixes recommendations by the Unity Package Validation Suite <https://github.com/CandyCoded/CandyCoded/pull/71>

## [1.1.2] - 2019-01-26

### Features

-   InputManager: Added new methods for working with 2d colliders. <https://github.com/CandyCoded/CandyCoded/pull/70>

## [1.1.1] - 2019-01-23

### Bug Fixes

-   Suppress warnings <https://github.com/CandyCoded/CandyCoded/pull/68>

### Features

-   Highlight gameobject on select. <https://github.com/CandyCoded/CandyCoded/pull/69>

## [1.1.0] - 2018-12-20

### Features

-   Updated to .NET 4 <https://github.com/CandyCoded/CandyCoded/pull/67>
-   Added namespace to files without it. <https://github.com/CandyCoded/CandyCoded/pull/66>
-   Unity Package Manager Support

## v1.0.0-beta.12 (Decemeber 14, 2018)

### Features

-   Added new EventProfiler. <https://github.com/CandyCoded/CandyCoded/pull/60>
-   Added Compare method to Transform objects. <https://github.com/CandyCoded/CandyCoded/pull/59>
-   Added Random method to Array and List. <https://github.com/CandyCoded/CandyCoded/pull/58>
-   Added Random method to ObservableList. <https://github.com/CandyCoded/CandyCoded/pull/57>

### Maintenance

-   Removed DisplayInInspector editor attribute. <https://github.com/CandyCoded/CandyCoded/pull/61>
-   Added missing ToList method to documentation.
-   Code cleanup on test files.

## v1.0.0-beta.11 (October 21, 2018)

### Bug Fixes

-   Prevent attempt to select color when no color exists. <https://github.com/neogeek/CandyCoded/pull/44>
-   Fixed issue with ObservableList RemoveRange method <https://github.com/neogeek/CandyCoded/pull/56>

### Features

-   Wrap Vector3 in Quaternion.Euler method call. <https://github.com/neogeek/CandyCoded/pull/45>
-   Added GetLayerMask extension. <https://github.com/neogeek/CandyCoded/pull/49>
-   Added LoadAssetBundle <https://github.com/neogeek/CandyCoded/pull/40>
-   Added InputManager <https://github.com/neogeek/CandyCoded/pull/48>
-   Added Permutations method. <https://github.com/neogeek/CandyCoded/pull/52>
-   Added RaycastHit to GetInputDown methods. <https://github.com/neogeek/CandyCoded/pull/53>
-   Return item on RemoveEvent. <https://github.com/neogeek/CandyCoded/pull/54>

### Maintenance

-   Removed all materials, shaders and textures. <https://github.com/neogeek/CandyCoded/pull/38>
-   Switch to remote Travis CI scripts <https://github.com/neogeek/CandyCoded/pull/41>
-   Removed camera components in favor of Cinemachine. <https://github.com/neogeek/CandyCoded/pull/42>
-   Test the routine value before calling StopCoroutine. <https://github.com/neogeek/CandyCoded/pull/46>

## v1.0.0-beta.10 (August 9, 2018)

### Bug Fixes

-   Put event handler call after the list is modified. <https://github.com/neogeek/CandyCoded/pull/33>

### Features

-   Added ToList method to ObservableList. <https://github.com/neogeek/CandyCoded/pull/34>
-   Added RotateTo that takes quaternion rather than Vector3. <https://github.com/neogeek/CandyCoded/pull/32>

### Maintenance

-   Improved code quality per recommendations via [Codacy](https://www.codacy.com/) and [Sonar C#](https://github.com/SonarSource/sonar-csharp)

## v1.0.0-beta.9 (July 16, 2018)

### Bug Fixes

-   Fixed invalid rotation reference. <https://github.com/neogeek/CandyCoded/pull/31>

## v1.0.0-beta.8 (July 16, 2018)

### Features

-   Added DisplayInInspector IEnumerator support <https://github.com/neogeek/CandyCoded/pull/28>

### Bug Fixes

-   Fixed issue with animation rotation <https://github.com/neogeek/CandyCoded/pull/30>

## v1.0.0-beta.7 (July 12, 2018)

### Features

-   Added Transform.GetChildrenByName method.
-   Added ObservableList object.

### Maintenance

-   Improved code quality per recommendations via [Codacy](https://www.codacy.com/) and [Sonar C#](https://github.com/SonarSource/sonar-csharp)

## v1.0.0-beta.6 (June 24, 2018)

### Bug Fixes

-   Fixed issue where a field was missing from the inspector in a ScriptableObject.

## v1.0.0-beta.5 (June 17, 2018)

### Features

-   Added billboard component <https://github.com/neogeek/CandyCoded/pull/23>
-   Added Update and Reset events to CustomGenericScriptableObject. <https://github.com/neogeek/CandyCoded/pull/22>
-   Added `Version.txt` to documentation folder.

### Maintenance

-   Improved code quality per recommendations via [Codacy](https://www.codacy.com/) and [Sonar C#](https://github.com/SonarSource/sonar-csharp)

## v1.0.0-beta.4 (June 8, 2018)

### Features

-   Added Runner OneShot method <https://github.com/neogeek/CandyCoded/pull/21>
-   Added relative end position toggle to line Gizmo component <https://github.com/neogeek/CandyCoded/pull/20>
-   Object pool reference <https://github.com/neogeek/CandyCoded/pull/19>

### Bug Fixes

-   Fix camera follow 3d position <https://github.com/neogeek/CandyCoded/pull/18>

## v1.0.0-beta.3 (April 15, 2018)

### Features

-   Plugin documentaion <https://github.com/neogeek/CandyCoded/pull/17>

### Bug Fixes

-   Changed variable name to prevent inherited member warning. <https://github.com/neogeek/CandyCoded/pull/16>

## v1.0.0-beta.2 (March 25, 2018)

### Features

-   Added Clone method to Vector3AnimationCurve.
-   Added Slice and Splice custom extensions to List objects
-   Added new overload method for Animation.RotateTo that takes quaternions.
-   Added EditKeyframeValue method.

### Bug Fixes

-   Fixed bug where bounds were incorrect when not starting at Vector3.zero <https://github.com/neogeek/CandyCoded/commit/3b6e860f43d580d4f6d20289d52a06dfa22fdc7b>

## v1.0.0-beta.1 (March 12, 2018)

-   Initial beta release.
