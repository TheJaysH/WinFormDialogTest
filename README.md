# WinFormDialogTest
This is a utility to invoke a Windows MessageBox with specified criteria.

![Image](/Bin/Images/MainWindow.png "Optional title attribute")

## CommandLine Args

* ```--title, -t```
  * Title of the MessageBox
* ```--message, -m```
  * Message within the MessageBox 
* ```--buttons, -b```
  *  Buttons to display
  * Allowed Values:
    * OK
    * OKCancel
    * AbortRetryIgnore
    * YesNoCancel
    * YesNo
    * RetryCancel
* ```--icon, -i```
  * Icon of the MessageBox
  * Allowed Values:
    * None
    * Hand
    * Stop
    * Error
    * Question
    * Exclamation
    * Warning
    * Asterisk
    * Information

### Example Usage:
```
WinFormDialogTes.exe --title "Dialog Title" --message "This is a message box" --buttons "YesNo" --icon "Information"
```
