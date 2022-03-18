# Pure X11
### c# X11 library
containts only functions from dynamic X11 library

## requirements: 
    OS: linux

### most amount of code is generated by https://github.com/AnatolyRybchych/HeaderTranslator

## DLL only:
wget https://github.com/AnatolyRybchych/PureX11/blob/main/bin/Debug/net6.0/PureX11.dll?raw=true -O PureX11.dll

## adding X11 reference to C# project: 
<Reference Include="PureX11">
    <HintPath>path to dll</HintPath>
</Reference>

## c# code
using static X11.X;