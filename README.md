# WpfPackUriErrorRepro

A minimum-code reproduction of the error I've been facing while trying to use WPF Pack Uris / resources in a program that also references the Windows App SDK.

## Expected behavior

The app should be able to run without encountering an exception. In this case, you should be able to see the text "Smiley image is 16 wide." printed to the debugger's output view/console, and you should see the window appear with a star icon in the middle of the window.

## Licensing

The code here is written by me, Jayke R. Huempfner, although a decent amount of it is just the boilerplate code that is created by selecting the "WPF Application" option from Visual Studio's New Project dialog. For the purposes of getting the issue solved and allowing anyone access to view/edit/use the code, this code is licensed under the [Unlicense](https://opensource.org/licenses/unlicense).

The images found in this repository are made by me, Jayke R. Huempfner, and are licensed under [Creative Commons BY-SA 4.0](https://creativecommons.org/licenses/by-sa/4.0/).

## Relevant Links

Windows App SDK Issue page: https://github.com/microsoft/WindowsAppSDK/issues/3410

Microsoft Learn page on WPF Pack Uris: https://learn.microsoft.com/en-us/dotnet/desktop/wpf/app-development/pack-uris-in-wpf?view=netframeworkdesktop-4.8