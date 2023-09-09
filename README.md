# Blue-Lagoon-Crypter

[Fixing] [Debugging]
Work in progress.
Will appreciate any helpful comments! ;) ty <3
#NEED_DAMN_HELP_!!!

![Screenshot_61](https://github.com/lxcalbxy/Blue-Lagoon-Crypter/assets/71847945/edad55e6-c332-488f-a350-1b5c525558ce)






Training project for educational purposes. The project represents a crypter.
|Program workflow|



1. Take an executable as an input.
2. Read bytes from executable.
3. Convert the bytes to base64.
4. Encrypt the base64 string with AES.
5. Pass the encrypted base64 sting to the stub file.
6. Compile stub that has decryptor and encrypted payload



TO DO:
- Implement interfaces for Persistence mechanism, Delay, Anti-Debugger, Anti-SafeMode, Mutation (random junk instructions at the start) settings. [Stub.cs & Form1.cs]
- Implement setings. [Stub.cs & Form1.cs]
- Add junk and null bytes after EOF overlay to the output PE. (If selected.)
- Add fake certificate to the output PE.

Fixed:
- Payload not being injected in the stub.
- Added checkboxes for Stub settings.
- UI Improved, button higlights when selected.
