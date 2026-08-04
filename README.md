# RecRoom Build Info
A full list of every recroom version and their API request urls, and their expected responses.

# Pausing updating the auto API docs until I can get every version's DLL Folder I can dump uploaded to the repo, and fix them to also document the endpoint (ROOMS / API / NOTIFICATION / ECON / etc.).

## All of the builds DLLs will be inside of the "DLLs" folder in this repo.
## All of the API documentation will be as MD files inside of the "API" folder in this repo.

# How can You Help?
* The best way you can contribute, is editing the auto generated .md files to fix any issues or missing definitions. This whole project was started by me alone, being very ambitious. I will get some things wrong, or outright missing some things, so I hope that if you care about making sure anyone can read this information if they wanted to make a custom and/or private server for old versions of RecRoom if they wanted to as much as I do, that you can provide your own help or information to assist others projects as well as my own.

# Information
I am aiming to have this automated, but fully accurate, Baseline known information is that:
* All versions after `6 December 2018 – 21:26:17 UTC` are Il2Cpp builds, and would require decompilation of the game back to mono C#, or at least understandable function calls that could provide easy understanding of functions, what they do, and how they do it, and class definitions.
* All versions before `23 June 2017 – 17:23:52 UTC` do NOT use besthttp, they use a custom made "RecNet.Core" Namespace that uses UnityEngine.WWW to make requests.
* All versions before `26 October 2016 – 20:30:17 UTC` do NOT use "RecNet.Core" for web requests, instead manually using UnityEngine.WWW to make requests, or the build has no HTTP requests
* All versions beyond `10 February 2017 – 01:48:05 UTC` have Beebyte Obfuscation.
* All versions `14 December 2018 – 19:12:52 UTC` to `12 May 2026 – 18:46:14 UTC` can and have been dumped with Cpp2Il's `--just-give-me-dlls-asap-dammit` flag.
* For the dumps for versions `11 February 2017 – 00:57:56 UTC` and beyond, Although I can try my best to provide accurate information, please note that some things may be wrong, or missing due to the obfuscation.
