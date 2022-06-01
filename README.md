# FileRenamer App
This applicartion will rename all your files using a numeric ordering.

## Installation Instructions
You will need to build the project to create an exe at this point. In the project directory, run this command at the command line:

    dotnet publish -r win-x64 -c Release /p:PublishSingleFile=true /p:PublishTrimmed=true --self-contained true
    
Take the generated exe and place it in the directory where you want it to reside, ideally you will want to add it as a new Windows PATH Environment Variable, so you can run it from every directory you need.

## The idea
This application idea was borned out of my own needs to rename my drone images files in bulk, since i own a DJI Mini SE which currently does not supports Timelapse, so i'm forced to take a picture every 2, 3 or 5 seconds so I can stich them inside an app like Davinci Resolve, stabilize, render and upload to youtube. Out of this process i normally end up with a HUGE ammount of images and i think it's a good chance to build my own file renamer to test my skills and actually have something to show as a programmer who shares with the community using a tool like GitHub.

## Example
Lets assume you have a folder with 300 images named DJI_0300.jpg to DJI_0600.jpg and you need then renamed as Scene1_0001.jpg (for the 1st image) and Scene1_0300.jpg, you will have to run the application using this command FileRenamer "E:\DCIM\100MEDIA\*.jpg" -t Scene1_ -n 0001 (this command will tell "Take all jpg files inside the directory E:\DCIM\100MEDIA\ and rename them as Scene1_ and create a numeric order from 0001 up to the last file).

## Possible Ideas
 * Automatic Backup of original images in a subfolder called Backup
