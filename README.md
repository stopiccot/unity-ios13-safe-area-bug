Bug occurs only when app is linked to iOS 13 SDK (You need to use Xcode 11 or higher).
When linked to iOS 13 SDK app is using new "sheet" appearance for modal view controllers.
Before modal view controller is shown safe area has non zero values.
After modal view controller was shown safe area values reset to zeroes.

<img src="https://raw.githubusercontent.com/stopiccot/unity-ios13-safe-area-bug/master/Screenshots/1.png" width="250" />  <img src="https://raw.githubusercontent.com/stopiccot/unity-ios13-safe-area-bug/master/Screenshots/2.png" width="250" />  <img src="https://raw.githubusercontent.com/stopiccot/unity-ios13-safe-area-bug/master/Screenshots/3.png" width="250" />
