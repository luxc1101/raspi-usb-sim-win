<div style='text-align: center;'><h1>User Guide</h1></div>

## Introduction:
The USB Emulator is a windows application tool. 
It is designed to simplify the testing of USB devices and enhance the team's media-device testing capabilities

---
## Precondition
- Prepare hardware (RaspberryPi zero W, USB Mico-B Cable (OTG), USB Mico-B Cable (Power), microSD Card, etc.)
- Plug in a fully prepared microSD card with the desired OS, necessary scripts, and installed packages
- Power Rpi by connecting its PWR port to a PC USB port or an external power supply (of output 5V). Hint: A solid green light indicates a proper connection
- Connect the Rpi OTG Port and the DUT through a USB Micro-B to USB-A/C cable
- Plug in a USB WiFi receiver/adapter to the test PC (if your computer cannot receive WiFi without an adapter)

---
## Configuration
Click on SSH Connect (Raspberry icon) to configure the SSHClient and WiFi parameters and establish an SSH connection

---
## Features

### Mass Storage Class (MSC):
- The MSC Tab enables the tester to simulate their desired File System (FS), such as exFAT and NTFS, etc. To begin, select your desired FS and click on Mount
- If the selected FS exists, the LED will indicate its existence. If not, this file system will first be created first, 
for which the tester must define parameters such as the disc size in the command window

### USB Peripherals: (Ethernet Control Model, Human Interface Device, Communication Device Class)
- The ECM, HID and CDC Tabs enable the user to test whether the DUT supports an emulated USB device. 
- These tabs usually list all devices that could be mounted directly. However, if the tester wants to see if some device from beyond the list is supported, they must input its customized VID and PID numbers