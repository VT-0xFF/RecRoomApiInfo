# RecRoom Build Info
*A full list of every recroom version and their API request URLs, and their expected responses, Along with CPP2IL Decompiled game code.*
# Pausing updating the auto API docs until I can fix the auto API Docs to also document the endpoint (ROOMS / API / NOTIFICATION / ECON / etc.).
- All of the builds code or "Code" *(For builds using CPP2IL's IL to ASM)* will be inside of the "Code" folder in this repo.
- All of the API documentation will be as MD files inside of the "API" folder in this repo.
# How can You Help?
* The best way you can contribute, is editing the auto generated .md files to fix any issues or missing definitions. This whole project was started by me alone, being very ambitious. I will get some things wrong, or outright missing some things, so I hope that if you care about making sure anyone can read this information if they wanted to make a custom and/or private server for old versions of RecRoom if they wanted to as much as I do, that you can provide your own help or information to assist others projects as well as my own.
# Information
I am aiming to have this automated, but fully accurate, Baseline known information is that:
* All versions before `26 October 2016 – 20:30:17 UTC` do NOT use "RecNet.Core" for web requests, instead manually using UnityEngine.WWW to make requests, or the build has no HTTP requests
* For the dumps for versions `11 February 2017 – 00:57:56 UTC` and beyond, Although I can try my best to provide accurate information, please note that some things may be wrong, or missing due to the obfuscation.
* All versions before `23 June 2017 – 17:23:52 UTC` do NOT use BestHTTP, they use a custom made "RecNet.Core" Namespace that uses UnityEngine.WWW to make requests.
* All versions between `10 February 2017 – 01:48:05 UTC` and `6 December 2018 – 21:26:17 UTC` then versions `8 April 2020 – 02:56:55 UTC` and beyond have BeeByte Obfuscation.
* All versions after `6 December 2018 – 21:26:17 UTC` are Il2Cpp builds, and have been dumped with CPP2IL's Experimental IL to Assembly flags.
## Additional Dumping information
* Some of the dumping process was assisted, and documentation on how things such as metadata encryption was worked around can be read in [DUMPING.md](https://github.com/VT-0xFF/RecRoom_Info/blob/main/DUMPING.md) 
