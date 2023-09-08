# Blue-Lagoon-Crypter
Training project for educational purposes. The project represents a crypter that should take your PE as an input, take  it as the payload, and inject the payload in the self-decrypting stub. Once the stub is compiled by crypter, it should decrypt the payload in runtime, executing it step by step. [Fixing] [Debugging]

Work in progress.

Now i am struggling with payload not being injected in the stub when compiled.
The Key and IV being injected in the Stub sucessfully, but something is going wrong with convertation or decryption.
Will appreciate any helpful comments! ;) ty <3

TO DO:
- Fix payload convertation, decryption & placement to the placeholder "%BASE64%". [STUB]
- Add checkboxes for Stub settings. [UI]
- Implement interfaces for Persistence mechanism, Delay, Anti-Debugger, Anti-SafeMode, Mutation (random junk instructions at the start) settings. [Stub.cs & Form1.cs]
- Implement setings. [Stub.cs & Form1.cs]
- Improve UI, add visible icon when icon is selected. [UI]
- Add junk and null bytes after EOF overlay to the output PE. (If selected.)
- Add fake certificate to the output PE.
