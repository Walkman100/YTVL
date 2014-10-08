YouTube Video Linker [![YTVL Icon](http://walkman100.github.io/Walkman/Images/WindowsProjectsOriginalImages/youtube_withLink.png)](http://walkman100.github.io/Walkman/Images/WindowsProjectsOriginalImages/youtube_withLink.png "YTVL Icon")
===
[![Gitter](https://badges.gitter.im/Join Chat.svg)](https://gitter.im/Walkman100/Walkman?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

YouTube Video Linker - MS Windows version of [YTVAL](http://walkman100.github.io/Walkman/HTML/YTVL.html)

Many thanks to [Deavmi](http://github.com/Deavmi) for his code, quite a bit of the code used in this project I learnt from his projects

Jump to:  
•<a href="#requirements">Requirements</a> 
•<a href="#how-to-use">How to use</a> 
•<a href="#what-the-links--flags-do">What the Links & Flags do</a> 
•[Screenshots](http://walkman100.github.io/Walkman/HTML/YTVLWindowsScreenshots.html) 
•[Future releases/ideas](https://gist.github.com/Walkman100/5b4103857f8f3a7a3f57#ytvl) 
•<a href="#want-to-suggest-a-feature">Suggest a feature</a> 
•<a href="#debugging">Debugging</a> 
•[Donate](http://walkman100.github.io/Walkman/HTML/Donate.html) 

The source code is also available on [Visual Studio online](https://walkman.visualstudio.com/DefaultCollection/YTVL).

# Requirements

- Windows `(tested on Windows 7 HP SP1 64-bit & Windows 8.1 Pro Update 1 64-bit)`

- In order for the update checker and the video name loader to work, you need an active internet connection and at least Internet Explorer 7 installed and enabled (even if you don't use it. ever.)

# How to use
It is very simple to use this program. Simply paste your YouTube Video ID<sup>(<a href="#f-note-1" name="ref1" id="ref1">1</a>)</sup> into the first box, and click the `Video` button to open the page with the video, sharing options and comments; click the `comments` option to view only the comments (useful if you watched the video in Embedded mode); click the `Video Info` button to download a file with the video's info in it; click the `Embed Page Handler` button to open a page that has JUST the video on it, which is even more lightweight than YouTube Feather<sup>(<a href="#f-note-2" name="ref2" id="ref2">2</a>)</sup> was; click the `Reset` button to reset the form to how it was  when you opened it. If you expand the window to the right, you will see an `Exit` button, which is not visible by default since it allows you to press <kbd>Esc</kbd> to close the program.

If you want to copy the generated URL to the clipboard instead of opening it in the browser, you can right-click an output button and click `Generate URL to Clipboard`, this will generate the URL and copy it to your clipboard.

There is an option to the right of the `Outputs` group box that shows the notification icon. This icon can be useful if you want to open multiple pages without having to open the program again, it has all the options from the `Outputs` group box in it's context menu (when you right-click). It has an option to show the program, to hide the icon (same as unchecking the option in the main program) and to exit the program completely - which also removes the icon until you open the program again.

The `Keep window on top` checkbox at the top-right of the window makes the window stay on top of all other windows. This checkbox and the option in the notification context menu do the same thing.

The `Check for updates automatically` checkbox & option, if you are using a version below `v1.3.3`, loads the file at [Walkman.Github.io/ver.txt](http://walkman100.github.io/Walkman/YTVL/ver.txt) and checks the current version against the version listed in that file whenever you tick the option, or if the option is ticked when the program opens. Versions later than and including `v1.3.3` load the url [here](http://github.com/Walkman100/YTVL/releases/latest) instead, since that is automatically redirected to the current version by GitHub, which returns e.g. `https://github.com/Walkman100/YTVL/releases/tag/v1.3.3`.
_______________________________________________________________________________
<a name="f-note-1" id="f-note-1">1</a>. A YouTube Video ID is the random letters at the end of a YouTube video URL, e.g. the id of the URL
> https://www.youtube.com/watch?v=z9Uz1icjwrM

is `z9Uz1icjwrM`. This ID is found in any Page's URL containing a video, even embedded ones.<a href="#ref1" title="Jump back to footnote 1 above">↩</a>

<a name="f-note-2" id="f-note-2">2</a>. As the page on [their website](https://www.youtube.com/feather_beta) says, "The "Feather" project is intended to serve YouTube video watch pages with the lowest latency possible. It achieves this by severely limiting the features available to the viewer and making use of advanced web techniques for reducing the total amount of bytes downloaded by the browser. It is a work in progress and may not work for all videos." Enable it [here](https://www.youtube.com/feather_beta). **Note**: YouTube Feather has been discontinued.<a href="#ref2" title="Jump back to footnote 2 above">↩</a>

# What the Links & Flags do
Links:
- **Original page** goes here: http://walkman100.github.io/Walkman/HTML/YTVL.html
- **Source code** goes here: https://github.com/Walkman100/YTVL/
- **Report a problem** goes here: https://github.com/Walkman100/YTVL/issues/new
- **Latest release** goes here: https://github.com/Walkman100/YTVL/releases/latest where it automatically redirects to the latest version

Generally, the name of the flag speaks for itself, but here is a short description:

The advanced options are mostly useful for embedded videos:
- **AutoPlay**: if this is set to `1`, the video will automatically begin playing when the page loads

***_<kbd>`WIP`</kbd>_***

# Screenshots
Screenshots available [here](http://walkman100.github.io/Walkman/HTML/YTVLWindowsScreenshots.html).

# Future releases/ideas
See [this gist](https://gist.github.com/Walkman100/5b4103857f8f3a7a3f57#ytvl).

# Want to suggest a feature?
Go ahead! Anyone is welcome to submit a PR (Pull/Push Request) or an Issue as long as the feature/addition doesn't make the program file size significantly bigger, or increases the time it takes to start. Also, keep in mind the KISS principle (Keep It Simple, Stupid). Notice I haven't added a settings window because there are only three settings, and my application interface has space for those settings without it looking too cluttered.

# Debugging
Press <kbd>Alt</kbd> + <kbd>D</kbd> to show the Browser windows to the right of the buttons in the Outputs group box, these show the page that is loaded to show the current version and the object that is loaded to get the video name. It is possible to play videos from this object.

![Screenshot with Debugging info shown](http://walkman100.github.io/Walkman/Images/WindowsProjectsScreenshots/YTVL/AdvancedOptionsWithDebugKeyCombinationPressed.png "Screenshot with Debugging info shown")

If this page does not show a valid version, then the program might give an error message. Unchecking the `Check for updates automatically` checkbox will prevent this page from ever being loaded until you select the checkbox again.

### [AppVeyor](http://ci.appveyor.com/) build status
[![Build status](https://ci.appveyor.com/api/projects/status/ao70dapbuoho2yk2)](https://ci.appveyor.com/project/Walkman100/ytvl)
