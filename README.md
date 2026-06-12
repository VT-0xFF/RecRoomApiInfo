# RecRoomApiInfo
A full list of every recroom version and their API request urls, and their expected responses.
# How can You Help?
The best way that you can help, is to look for any IPAs, or APKs (Quest And Google Play) for RecRoom versions made after `6 December 2018 – 21:26:17 UTC` (When they switched from Mono to Il2Cpp), and not after `20 August 2024 – 03:07:46 UTC` (When they added Metadata Encryption)
APKs and IPAs AFTER metadata encription Can be useful, but only if the metadata encryption is ever reverse engineered.
# Information
I am aiming to have this automated, but fully accurate, Baseline information is that:
* All versions before`23 June 2017 – 17:23:52 UTC` do NOT use besthttp, they use a custom made "RecNet.Core" Namespace that uses UnityEngine.WWW to make requests.
* All versions before `10 February 2017 – 01:48:05 UTC` do NOT use Beebyte Obfuscator, making it lightyears easier to read and understand the implementation.
* All versions before `26 October 2016 – 20:30:17 UTC` do NOT use "RecNet.Core" for web requests, instead manually using UnityEngine.WWW to make requests, or the build has no HTTP requests
* For the dumps for versions `11 February 2017 – 00:57:56 UTC` and beyond, Although I can try my best to provide accurate information, please note that some things may be wrong, or missing due to the obfuscation.

All of the API documentation will be as MD files inside of the "API" folder in this repo.
