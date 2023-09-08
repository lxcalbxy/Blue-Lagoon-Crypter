# Blue-Lagoon-Crypter
[Fixing] [Debugging]
![Blue Lagoon Crypter](https://github.com/lxcalbxy/Blue-Lagoon-Crypter/assets/71847945/63132c59-ed0d-4f7c-aec4-00fb346f809f)




Training project for educational purposes. The project represents a crypter.
|Program workflow|

1. Take an executable as an input.
2. Read bytes from that executable
3. Convert the bytes to base64 format
4. Encrypt the base64 string with AES encryption
5. Pass the encrypted base64 sting to the stub file
6. The compiler itself will try Using this stub file to compile a final product that will have: Stub itself + encrypted base64 string that represents the input file.



Work in progress.



Now i am struggling with payload not being injected in the stub when compiled.
The Key and IV being injected in the Stub sucessfully, but something is going wrong with convertation or decryption of BASE64 payload data.
Will appreciate any helpful comments! ;) ty <3

#NEED_DAMN_HELP_!!!



TO DO:
- Fix payload convertation, decryption & placement to the placeholder "%BASE64%". [STUB]
- Add checkboxes for Stub settings. [UI]
- Implement interfaces for Persistence mechanism, Delay, Anti-Debugger, Anti-SafeMode, Mutation (random junk instructions at the start) settings. [Stub.cs & Form1.cs]
- Implement setings. [Stub.cs & Form1.cs]
- Improve UI, add visible icon when icon is selected. [UI]
- Add junk and null bytes after EOF overlay to the output PE. (If selected.)
- Add fake certificate to the output PE.
