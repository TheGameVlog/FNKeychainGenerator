# What is FN Keychain Generator

A Simple tool to generate Keychain based on the input GUID and AES.

# Why Use FN Keychain Generator

-- When none of the Bots or Sources you get your keychain from are updated, use this utility to generate your own keychain for the recently decrypted pak.

## Where do I get AES and GUID from?

https://fortnite-api.com/v2/aes

## Features
-- Generate Keychain based on the given GUID and AES Key.
-- Fetch Available Keychains from Nitestats API.
-- Add the generated Keychain to the result.
-- Send to Pastebin.

## Get Pastebin Developer Key
Go to https://pastebin.com/doc_api and register an account. You need the developer key to save the keychain file on pastebin.
Once you get the Pastebin Developer Key
Add it to line 103 in Form1.vb

        Dim pasteRequest As New NameValueCollection
        pasteRequest.Add("api_dev_key", "") 'Simply login to Pastebin and go to https://pastebin.com/doc_api#1


## Screenshot
![](https://github.com/TheGameVlog/FNKeychainGenerator/blob/master/FNKeychain/screenshots/screenshot.png?raw=true)

## Developed by
[The Game Vlog](https://twitter.com/thegamevlog "The Game Vlog")
![](https://pbs.twimg.com/profile_images/579055007758032896/lFeK7nw0_200x200.png)

## Credits
- https://nitestats.com
- https://twitter.com/SizzyLeaks
