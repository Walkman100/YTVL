YouTube Video Linker
====

YouTube Video Linker - MS Windows version of [YTVAL](http://walkman100.github.io/Walkman/youtube-video-stuff.htm)

Many thanks to [Deavmi](http://github.com/Deavmi) for his code, quite a bit of the code used in this project I learnt from his projects

Jump to:  
•<a href="#how-to-use">How to use</a> 
•<a href="#want-to-suggest-a-feature">Suggest a feature</a> 
•<a href="#future-releasesideas">Future releases/ideas</a> 
•<a href="#what-the-links--flags-do">What the Links & Flags do</a> 
•<a href="http://walkman100.github.io/Walkman/YTVL/">Screenshots</a> 
•<a href="#debugging">Debugging</a>

How to use
====
It is very simple to use this program. Simply paste your YouTube Video ID<sup>(<a href="#f-note-1" name="ref1" id="ref1">1</a>)</sup> into the first box, and click the `Video` button to open the page with the video, sharing options and comments; click the `comments` option to view only the comments (useful if you use YouTube Feather<sup>(<a href="#f-note-2" name="ref2" id="ref2">2</a>)</sup>); click the `Video Info` button to download a file with the video's info in it; click the `Embed Page Handler` button to open a page that has JUST the video on it, which is even more lightweght than YouTube Feather<sup>(<a href="#f-note-2" name="ref2" id="ref2">2</a>)</sup>; click the `Reset` button to reset the form to how it was  when you opened it. If you expand the window to the right, you will see an `Exit` button, which is not visible by default since it allows you to press <kbd>Esc</kbd> to close the program.

There is an option to the right of the `Outputs` group box that shows the notification icon. This icon can be useful if you want to open multiple pages without having to open the program again, it has all the options from the `Outputs` group box in it's context menu (when you right-click). It has an option to show the program, to hide the icon (same as unchecking the option in the main program) and to exit the program completely - which also removes the icon until you open the program again.

The `Check for updates automatically` checkbox & option loads the file at [Walkman.Github.io/ver.txt](http://walkman100.github.io/Walkman/YTVL/ver.txt) and checks the current version against the version listed in that file whenever you tick the option, or if the option is ticked when the program opens. I have future plans for it instead to load the url [here](http://github.com/Walkman100/YTVL/releases/latest) instead, since that is automatically redirected to the current version by GitHub, but that would return e.g. `https://github.com/Walkman100/YTVL/releases/tag/v1.2` and I don't currently know how to trim characters in VB to just get the `1.2` from it.
___
<a name="f-note-1" id="f-note-1">1</a>. A YouTube Video ID is the random letters at the end of a YouTube video URL, e.g. the id of the URL
> https://www.youtube.com/watch?v=z9Uz1icjwrM

is `z9Uz1icjwrM`. This ID is found in any Page's URL containing a video, even embedded ones.<a href="#ref1" title="Jump back to footnote 1 above.">↩</a>

<a name="f-note-2" id="f-note-2">2</a>. As the page on [their website](https://www.youtube.com/feather_beta) says, "The "Feather" project is intended to serve YouTube video watch pages with the lowest latency possible. It achieves this by severely limiting the features available to the viewer and making use of advanced web techniques for reducing the total amount of bytes downloaded by the browser. It is a work in progress and may not work for all videos." Enable it [here](https://www.youtube.com/feather_beta).<a href="#ref2" title="Jump back to footnote 2">↩</a>

Want to suggest a feature?
====
Go ahead! Anyone is welcome to submit a PR (Pull/Push Request) or an Issue as long as the feature/addition doesn't make the program file size significantly bigger, or increases the time it takes to start. Also, keep in mind the KISS principle (Keep It Simple, Stupid). Notice I haven't added a settings window because there are only three settings, and my application interface has space for those settings without it looking too cluttered.

Future releases/ideas
====
`v1.4` will have a box/text that automatically loads and tells the title of the video ID entered, and a button to generate the embedded video HTML or BB code which will be copied to the clipboard. A context menu for when you right-click on any of the `outputs` buttons that allows you to generate the URL and copy it will also be in this release.

`v1.5` will probably have buttons to open the download pages for FullRip.net; MP3, Video or Video(alternative); KeepVid e.t.c.

What the Links & Flags do
====
Links:
* **Enable YouTube Feather**<sup>(<a href="#f-note-2" name="ref2" id="ref2">2</a>)</sup> here: https://www.youtube.com/testtube even though the direct URL is https://www.youtube.com/feather_beta
* **Original page** goes here: http://walkman100.github.io/Walkman/youtube-video-stuff.htm
* **Source code** goes here: https://github.com/Walkman100/YTVL/
* **Report a problem** goes here: https://github.com/Walkman100/YTVL/issues/new
* **Latest release** goes here: https://github.com/Walkman100/YTVL/releases/latest where it automatically redirects to the latest version

Generally, the name of the flag speaks for itself, but here is a short description:
* **NoFeather**<sup>(<a href="#f-note-2" name="ref2" id="ref2">2</a>)</sup>: this flag temporarily (for the page it's on) disables YouTube Feather

Other than noFeather, the advanced options are mostly useful for embedded videos
* **AutoPlay** if this is set to `1`, the video will automatically begin playing when the page loads

***_<kbd>`WIP`</kbd>_***

Screenshots
====
Screenshots available <a href="http://walkman100.github.io/Walkman/YTVL/">here</a>.

Debugging
====
Press <kbd>Alt</kbd> + <kbd>D</kbd> to show the Browser window to the right of the `Developed by...` link, this shows the page that is loaded to show the current version.

![Screenshot with Debugging info shown](http://walkman100.github.io/Walkman/YTVL/AdvancedOptionsWithDebugKeyCombinationPressed.png "Screenshot with Debugging info shown")

If this page does not show a valid version, then the program might give an error message. Unchecking the `Check for updates automatically` checkbox will prevent this page from ever being loaded until you select the checkbox again.

Minimum Requirements
====

The minimum requirements for YTVL can be found on [this](https://github.com/Walkman100/YTVL/wiki/Minimum-Requirements) page on the YTVL wiki.
