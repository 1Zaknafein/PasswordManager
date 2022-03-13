# Password Manager

A simple password manager made in VS, allowing to save credentials or generate new strong passwords. Optional 'master password' can be set to use the program, up to the user.
File with credentials is saved on closing the program, in the same directory as the executable file.

![chrome_NakODCW7dh](https://user-images.githubusercontent.com/98032843/157570505-bc5170c4-681b-44d2-aea0-a608bb68d50a.gif)


## Update

- Saved passwords are now encrypted using AES encryption; if no 'master password' has been set, encrypting using keys set in code (not very secure). If master password was set, then it will be used for encrypting/decrypting the passwords.

![PasswordManager_VzDe5ce2So](https://user-images.githubusercontent.com/98032843/158069597-403823df-27be-43c3-ab18-c6e6ab525269.png)
