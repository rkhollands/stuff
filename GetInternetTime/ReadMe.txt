GetInternetTime.exe (GIT) is an application built specifically for Maleks. It is designed to run on the Primary 
computer and synchronizes the computer clock with a Network Time Protocol server. However, unlike the Windows
time utility, GIT can be set to run after closing. This will avoid the pitfalls of clocks suddenly changing in
the middle of a shift.

It does this through the Windows Task Scheduler. This has already been set up. However, if the task needs to
be changed, one can do so through the Task Scheduler App. Just remember to set the following options:

-Use the account Maleks Admin (supply password)
-Run whether user logged on or not
-Run with highest privileges.

GIT can run in edit mode, or automatic. Open the application without command-line parameters to enable edit
mode. There a user can change options, modify Daylight Savings Time (DST) rules, and even test the app.

Run the app with a 'R' command-line parameter to run in automatic. This will launch the app, get Greenwich
Mean Time, apply time zone and DST adjustments, and change the clock. Then it will exit. The shortcut
'Run Automatic GetInternetTime.exe' is configured to supply the appropriate argument.
