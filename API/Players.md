# Players

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## GET `api/players/v1/?p={platform}&id={platformPlayerId}`

*first seen: 2016-10-26_20-30-17 — last seen: 2016-11-29_21-32-10 (9 builds)*

**Declared by:** `Profile.Get`

**URI parameters:** `platform`, `platformPlayerId`

**Response:**

`200 OK` — JSON `Profile`

```json
{
  "Id": ulong,
  "Username": string,
  "DisplayName": string,
  "XP": int,
  "Level": int,
  "Reputation": int,
  "Verified": bool
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `Id` | `ulong` | `profile.Id` |
| `Username` | `string` | `profile.Username` |
| `DisplayName` | `string` | `profile.DisplayName` |
| `XP` | `int` | `profile.XP` |
| `Level` | `int` | `profile.Level` |
| `Reputation` | `int` | `profile.Reputation` |
| `Verified` | `bool` | `profile.Verified` |

<details><summary>Client-side callback</summary>

```cs
private static Core.ApiCallback ParseProfileCallback (GetProfileCallback callback)
{
	return delegate(WWW www) {
		Profile profile = ((!string.IsNullOrEmpty (www.error)) ? null : ParseProfile (www.text));
		callback (www.error, profile);
	};
}
```

</details>

---

## GET `api/players/v1/GetGeneratedNameOptions`

*first seen: 2018-07-17_17-57-37 — last seen: 2019-11-12_15-10-55 (48 builds)*

**Declared by:** `Profiles.GetNameGenerationOptions`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/players/v1/avoidJuniors`

*first seen: 2018-12-14_19-12-52 — last seen: 2019-04-24_15-07-27 (13 builds)*

**Declared by:** `Profiles.UpdateAvoidJunior`

**Request body:** form fields (Dictionary<string,string>)

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/players/v1/bio`

*first seen: 2018-12-14_19-12-52 — last seen: 2019-11-12_15-10-55 (47 builds)*

**Declared by:** `Profiles.UpdateLocalProfileBio`

**Request body:** form fields (Dictionary<string,string>)

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/players/v1/birthday`

*first seen: 2018-12-14_19-12-52 — last seen: 2019-11-12_15-10-55 (47 builds)*

**Declared by:** `Profiles.UpdateLocalProfileBirthday`

**Request body:** form fields (Dictionary<string,string>)

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/players/v1/create`

*first seen: 2016-10-26_20-30-17 — last seen: 2016-11-29_21-32-10 (9 builds)*

**Declared by:** `Profile.Create`

**Request body:** WWWForm (application/x-www-form-urlencoded)

| Field | Type |
|-------|------|
| `Platform` | `int` |
| `PlatformId` | `string` |
| `Name` | `string` |

**Response:**

`200 OK` — JSON `Profile`

```json
{
  "Id": ulong,
  "Username": string,
  "DisplayName": string,
  "XP": int,
  "Level": int,
  "Reputation": int,
  "Verified": bool
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `Id` | `ulong` | `profile.Id` |
| `Username` | `string` | `profile.Username` |
| `DisplayName` | `string` | `profile.DisplayName` |
| `XP` | `int` | `profile.XP` |
| `Level` | `int` | `profile.Level` |
| `Reputation` | `int` | `profile.Reputation` |
| `Verified` | `bool` | `profile.Verified` |

<details><summary>Client-side callback</summary>

```cs
private static Core.ApiCallback ParseProfileCallback (GetProfileCallback callback)
{
	return delegate(WWW www) {
		Profile profile = ((!string.IsNullOrEmpty (www.error)) ? null : ParseProfile (www.text));
		callback (www.error, profile);
	};
}
```

</details>

---

## POST `api/players/v1/createProfile`

*first seen: 2018-12-14_19-12-52 — last seen: 2019-11-12_15-10-55 (46 builds)*

**Declared by:** `Profiles.CreateNewProfile`

**Request body:** form fields (Dictionary<string,string>)

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/players/v1/deleteProfile`

*first seen: 2018-12-14_19-12-52 — last seen: 2019-11-12_15-10-55 (46 builds)*

**Declared by:** `Profiles.DeleteProfile`

**Request body:** form fields (Dictionary<string,string>)

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/players/v1/disallowInAppPurchases`

*first seen: 2019-02-14_22-55-35 — last seen: 2019-11-12_15-10-55 (37 builds)*

**Declared by:** `Profiles.GetDisallowInAppPurchases`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num3 != 0
```

</details>

---

## POST `api/players/v1/getorcreate`

*first seen: 2016-12-09_03-11-41 — last seen: 2017-02-13_21-47-24 (14 builds)*

**Declared by:** `Profiles.GetOrCreate`

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `Platform` | `string` |
| `PlatformId` | `string` |
| `Name` | `string` |

**Response:**

`200 OK` — JSON `Profile`

```json
{
  "Id": ulong,
  "Username": string,
  "DisplayName": string,
  "XP": int,
  "Level": int,
  "Reputation": int,
  "Verified": bool,
  "Developer": bool
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `Id` | `ulong` | `Id` |
| `Username` | `string` | `Username` |
| `DisplayName` | `string` | `DisplayName` |
| `XP` | `int` | `XP` |
| `Level` | `int` | `Level` |
| `Reputation` | `int` | `Reputation` |
| `Verified` | `bool` | `Verified` |
| `Developer` | `bool` | `Developer` |

<details><summary>Client-side callback</summary>

```cs
callback
```

</details>

---

## POST `api/players/v1/list`

*first seen: 2016-11-23_01-26-08 — last seen: 2019-11-12_15-10-55 (65 builds)*

**Declared by:** `Profile.Get`, `Profiles.Get`, `Profiles.GetFromServer`, `Profiles.MoveNext`

**Request body:** application/json

**Response:**

`200 OK` — JSON `Profile`

```json
{
  "Id": ulong,
  "Username": string,
  "DisplayName": string,
  "XP": int,
  "Level": int,
  "Reputation": int,
  "Verified": bool,
  "Developer": bool
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `Id` | `ulong` | `Id` |
| `Username` | `string` | `Username` |
| `DisplayName` | `string` | `DisplayName` |
| `XP` | `int` | `XP` |
| `Level` | `int` | `Level` |
| `Reputation` | `int` | `Reputation` |
| `Verified` | `bool` | `Verified` |
| `Developer` | `bool` | `Developer` |

<details><summary>Client-side callback</summary>

```cs
callback
```

</details>

---

## POST `api/players/v1/objective/{Id}`

*first seen: 2016-11-23_01-26-08 — last seen: 2016-11-29_21-32-10 (3 builds)*

**Declared by:** `Profile.CompleteObjective`

**URI parameters:** `Id`

**Request body:** WWWForm (application/x-www-form-urlencoded)

| Field | Type |
|-------|------|
| `objectiveType` | `int` |
| `additionalXp` | `int` |
| `inParty` | `string` |

**Response:**

`200 OK` — JSON `ObjectiveComplete`

```json
{
  "deltaXp": int,
  "currentLevel": int,
  "currentXp": int,
  "xpRequiredToLevelUp": int
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `deltaXp` | `int` | `objectiveComplete.deltaXp` |
| `currentLevel` | `int` | `objectiveComplete.currentLevel` |
| `currentXp` | `int` | `objectiveComplete.currentXp` |
| `xpRequiredToLevelUp` | `int` | `objectiveComplete.xpRequiredToLevelUp` |

<details><summary>Client-side callback</summary>

```cs
private static Core.ApiCallback ParseObjectiveCompleteCallback (GetObjectiveCompletedCallback callback)
{
	return delegate(WWW www) {
		ObjectiveComplete objectiveComplete = ((!string.IsNullOrEmpty (www.error)) ? null : ParseObjectiveComplete (www.text));
		callback (www.error, objectiveComplete);
	};
}
```

</details>

---

## GET `api/players/v1/phonelastfour`

*first seen: 2018-07-17_17-57-37 — last seen: 2019-11-12_15-10-55 (48 builds)*

**Declared by:** `Profiles.GetPhoneLastFour`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/players/v1/score`

*first seen: 2016-12-09_03-11-41 — last seen: 2017-02-11_00-57-56 (13 builds)*

**Declared by:** `Profiles.LocalAddScore`

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `SessionId` | `string` |
| `Activity` | `string` |
| `Category` | `string` |
| `Score` | `string` |
| `Comment` | `string` |
| `SecondaryScore` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
delegate(string wwwError) {
	if (!string.IsNullOrEmpty (wwwError)) {
		Debug.LogError ("Failed to add score : " + wwwError);
	}
}
```

</details>

---

## POST `api/players/v1/update/{Id}`

*first seen: 2016-10-26_20-30-17 — last seen: 2016-11-16_19-34-45 (6 builds)*

**Declared by:** `Profile.Save`

**URI parameters:** `Id`

**Request body:** System.Byte[]

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
delegate(WWW www) {
	callback (www.error);
}
```

</details>

---

## POST `api/players/v1/updateReputation/{Id}`

*first seen: 2016-11-23_01-26-08 — last seen: 2016-11-29_21-32-10 (3 builds)*

**Declared by:** `Profile.UpdateReputation`

**URI parameters:** `Id`

**Request body:** WWWForm (application/x-www-form-urlencoded)

| Field | Type |
|-------|------|
| `reputation` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
delegate(WWW www) {
	callback (www.error);
}
```

</details>

---

## POST `api/players/v1/username`

*first seen: 2019-10-10_18-00-53 — last seen: 2019-11-12_15-10-55 (11 builds)*

**Declared by:** `Profiles.UpdateLocalProfileUsername`

**Request body:** System.Collections.Generic.IEnumerable

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/players/v1/verify/{Id}`

*first seen: 2016-10-26_20-30-17 — last seen: 2016-11-29_21-32-10 (9 builds)*

**Declared by:** `Profile.SendRegistrationEmail`

**URI parameters:** `Id`

**Request body:** WWWForm (application/x-www-form-urlencoded)

| Field | Type |
|-------|------|
| `email` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
delegate(WWW www) {
	string text = www.text.Replace ("{\"Message\":\"", string.Empty).Replace ("\"}", string.Empty);
	callback (text, www.error);
}
```

</details>

---

## GET `api/players/v1/{id}`

*first seen: 2016-10-26_20-30-17 — last seen: 2019-11-12_15-10-55 (73 builds)*

**Declared by:** `Profile.Get`, `Profiles.Get`, `Profiles.GetFromServer`, `Profiles.GetPlayerById_DoNotUse`

**URI parameters:** `id`

**Response:**

`200 OK` — JSON `Profile`

```json
{
  "Id": ulong,
  "Username": string,
  "DisplayName": string,
  "XP": int,
  "Level": int,
  "Reputation": int,
  "Verified": bool,
  "Developer": bool
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `Id` | `ulong` | `Id` |
| `Username` | `string` | `Username` |
| `DisplayName` | `string` | `DisplayName` |
| `XP` | `int` | `XP` |
| `Level` | `int` | `Level` |
| `Reputation` | `int` | `Reputation` |
| `Verified` | `bool` | `Verified` |
| `Developer` | `bool` | `Developer` |

<details><summary>Client-side callback</summary>

```cs
callback
```

</details>

---

## GET `api/players/v2/?p={platform}&id={platformPlayerId}`

*first seen: 2016-12-09_03-11-41 — last seen: 2017-02-13_21-47-24 (14 builds)*

**Declared by:** `Profiles.Get`

**URI parameters:** `platform`, `platformPlayerId`

**Response:**

`200 OK` — JSON `Profile`

```json
{
  "Id": ulong,
  "Username": string,
  "DisplayName": string,
  "XP": int,
  "Level": int,
  "Reputation": int,
  "Verified": bool,
  "Developer": bool
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `Id` | `ulong` | `Id` |
| `Username` | `string` | `Username` |
| `DisplayName` | `string` | `DisplayName` |
| `XP` | `int` | `XP` |
| `Level` | `int` | `Level` |
| `Reputation` | `int` | `Reputation` |
| `Verified` | `bool` | `Verified` |
| `Developer` | `bool` | `Developer` |

<details><summary>Client-side callback</summary>

```cs
callback
```

</details>

---

## POST `api/players/v2/displayname`

*first seen: 2018-12-14_19-12-52 — last seen: 2019-11-12_15-10-55 (47 builds)*

**Declared by:** `Profiles.UpdateLocalProfileDisplayName`

**Request body:** form fields (Dictionary<string,string>)

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/players/v2/listByPlatformId`

*first seen: 2018-07-17_17-57-37 — last seen: 2019-10-02_14-21-06 (5 builds)*

**Declared by:** `Profiles.GetFromServer`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num != 0
```

</details>

---

## POST `api/players/v2/objective`

*first seen: 2016-12-09_03-11-41 — last seen: 2017-02-13_21-47-24 (14 builds)*

**Declared by:** `Profiles.CompleteObjective`

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `objectiveType` | `string` |
| `additionalXp` | `string` |
| `inParty` | `string` |

**Response:**

`200 OK` — JSON `Profiles+ObjectiveComplete` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
callback
```

</details>

---

## POST `api/players/v2/objectives`

*first seen: 2020-04-20_03-32-18 — last seen: 2020-07-22_03-00-56 (14 builds)*

**URI parameters:** `args`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/players/v2/phone`

*first seen: 2018-12-14_19-12-52 — last seen: 2019-11-12_15-10-55 (47 builds)*

**Declared by:** `Profiles.UpdateLocalProfilePhoneNumber`

**Request body:** form fields (Dictionary<string,string>)

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/players/v2/phone/verify`

*first seen: 2018-12-14_19-12-52 — last seen: 2019-11-12_15-10-55 (47 builds)*

**Declared by:** `Profiles.VerifyLocalProfilePhoneNumber`

**Request body:** form fields (Dictionary<string,string>)

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/players/v2/search?name={searchString}`

*first seen: 2018-07-17_17-57-37 — last seen: 2019-11-12_15-10-55 (48 builds)*

**Declared by:** `Profiles.SearchForPlayer`

**URI parameters:** `searchString`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num2 != 0
```

</details>

---

## POST `api/players/v2/updateReputation`

*first seen: 2016-12-09_03-11-41 — last seen: 2019-11-12_15-10-55 (60 builds)*

**Declared by:** `Profiles.UpdateLocalProfileReputation`

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `reputationDelta` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
delegate(string wwwError) {
	if (!string.IsNullOrEmpty (wwwError)) {
		Debug.LogError ("Failed to upload Rec Room player profile reputation changes: " + wwwError);
	} else {
		LocalProfile.Reputation -= reputationDelta;
	}
}
```

</details>

---

## POST `api/players/v2/verify`

*first seen: 2016-12-09_03-11-41 — last seen: 2017-02-13_21-47-24 (14 builds)*

**Declared by:** `Profiles.SendRegistrationEmail`

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `Email` | `string` |

**Response:**

`200 OK` — JSON `Profiles+RegistrationEmailResponse` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
delegate(string error, RegistrationEmailResponse response) {
	string response2 = response?.Message;
	Core.SafeInvoke (callback, error, response2);
}
```

</details>

---

## GET `http://recroomwebapplication2.azurewebsites.net/api/players/`

*first seen: 2016-08-11_02-36-31 — last seen: 2016-08-17_18-41-19 (6 builds)*

**Declared by:** `WebManager.CreateLocalPlayer`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

---

## GET `http://recroomwebapplication2.azurewebsites.net/api/players/?steamId={m_SteamID}`

*first seen: 2016-08-11_02-36-31 — last seen: 2016-08-17_18-41-19 (6 builds)*

**Declared by:** `WebManager.GetPlayer`

**URI parameters:** `m_SteamID`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

---

## GET `http://recroomwebapplication2.azurewebsites.net/api/players/{Id}`

*first seen: 2016-08-11_02-36-31 — last seen: 2016-08-17_18-41-19 (6 builds)*

**Declared by:** `WebManager.UpdateLocalPlayerModelAsync`

**URI parameters:** `Id`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
requestUriString
```

</details>

---

## GET `http://recroomwebapplication3.azurewebsites.net/api/players/`

*first seen: 2016-08-24_18-52-50 — last seen: 2016-08-24_18-52-50 (1 builds)*

**Declared by:** `WebManager.CreateLocalPlayer`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

---

## GET `http://recroomwebapplication3.azurewebsites.net/api/players/?steamId={m_SteamID}`

*first seen: 2016-08-24_18-52-50 — last seen: 2016-08-24_18-52-50 (1 builds)*

**Declared by:** `WebManager.GetPlayer`

**URI parameters:** `m_SteamID`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

---

## GET `http://recroomwebapplication3.azurewebsites.net/api/players/{Id}`

*first seen: 2016-08-24_18-52-50 — last seen: 2016-08-24_18-52-50 (1 builds)*

**Declared by:** `WebManager.UpdateLocalPlayerModelAsync`

**URI parameters:** `Id`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
requestUriString
```

</details>

---

## GET `https://recroom.azurewebsites.net/api/players/v1/?p={0}&id={m_SteamID}`

*first seen: 2016-08-31_03-41-47 — last seen: 2016-10-18_01-49-40 (10 builds)*

**Declared by:** `<UpdateLocalPlayerModelCoroutine>c__Iterator89.GetProfileFromServer`, `<UpdateLocalPlayerModelCoroutine>c__Iterator8B.GetProfileFromServer`, `<UpdateLocalPlayerModelCoroutine>c__IteratorAA.GetProfileFromServer`, `<UpdateLocalPlayerModelCoroutine>c__IteratorAF.GetProfileFromServer`, `WebManager.GetSteamPlayer`

**URI parameters:** `platform`, `platformPlayerId`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
private static AutoRetryWWWCompletionCallback ParseProfileCallback (GetProfileCallback callback)
{
	return delegate(WWW www) {
		PlayerModel profile = ((!string.IsNullOrEmpty (www.error)) ? null : PlayerModel.Parse (www.text));
		callback (www.error, profile);
	};
}
```

</details>

---

## GET `https://recroom.azurewebsites.net/api/players/v1/create`

*first seen: 2016-08-31_03-41-47 — last seen: 2016-08-31_03-43-43 (2 builds)*

**Declared by:** `WebManager.CreateLocalPlayer`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

---

## POST `https://recroom.azurewebsites.net/api/players/v1/create`

*first seen: 2016-09-08_01-33-59 — last seen: 2016-10-18_01-49-40 (8 builds)*

**Declared by:** `<UpdateLocalPlayerModelCoroutine>c__Iterator89.CreateProfileOnServer`, `<UpdateLocalPlayerModelCoroutine>c__Iterator8B.CreateProfileOnServer`, `<UpdateLocalPlayerModelCoroutine>c__IteratorAA.CreateProfileOnServer`, `<UpdateLocalPlayerModelCoroutine>c__IteratorAF.CreateProfileOnServer`

**Request body:** WWWForm (application/x-www-form-urlencoded)

| Field | Type |
|-------|------|
| `Platform` | `int` |
| `PlatformId` | `string` |
| `Name` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
private static AutoRetryWWWCompletionCallback ParseProfileCallback (GetProfileCallback callback)
{
	return delegate(WWW www) {
		PlayerModel profile = ((!string.IsNullOrEmpty (www.error)) ? null : PlayerModel.Parse (www.text));
		callback (www.error, profile);
	};
}
```

</details>

---

## GET `https://recroom.azurewebsites.net/api/players/v1/update/{Id}`

*first seen: 2016-08-31_03-41-47 — last seen: 2016-10-18_01-49-40 (10 builds)*

**Declared by:** `<UpdateLocalPlayerModelCoroutine>c__Iterator89.UpdateLocalPlayerModelCoroutine`, `<UpdateLocalPlayerModelCoroutine>c__Iterator8B.UpdateLocalPlayerModelCoroutine`, `<UpdateLocalPlayerModelCoroutine>c__IteratorAA.UpdateLocalPlayerModelCoroutine`, `<UpdateLocalPlayerModelCoroutine>c__IteratorAF.UpdateLocalPlayerModelCoroutine`, `WebManager.UpdateLocalPlayerModelCoroutine`

**URI parameters:** `Id`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

---

## POST `https://recroom.azurewebsites.net/api/players/v1/verify/{Id}`

*first seen: 2016-09-21_02-09-09 — last seen: 2016-10-18_01-49-40 (6 builds)*

**Declared by:** `<UpdateLocalPlayerModelCoroutine>c__Iterator89.SendRegistrationEmail`, `<UpdateLocalPlayerModelCoroutine>c__Iterator8B.SendRegistrationEmail`, `<UpdateLocalPlayerModelCoroutine>c__IteratorAF.SendRegistrationEmail`

**URI parameters:** `Id`

**Request body:** WWWForm (application/x-www-form-urlencoded)

| Field | Type |
|-------|------|
| `email` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
delegate(WWW www) {
	if (callback2 != null) {
		callback2 (www.text.Replace ("{\"Message\":\"", string.Empty).Replace ("\"}", string.Empty), www.error);
	}
}
```

</details>

---

## GET `https://recroom.azurewebsites.net/api/players/v1/{id}`

*first seen: 2016-09-08_01-33-59 — last seen: 2016-10-18_01-49-40 (8 builds)*

**Declared by:** `<UpdateLocalPlayerModelCoroutine>c__Iterator89.GetProfileFromServer`, `<UpdateLocalPlayerModelCoroutine>c__Iterator8B.GetProfileFromServer`, `<UpdateLocalPlayerModelCoroutine>c__IteratorAA.GetProfileFromServer`, `<UpdateLocalPlayerModelCoroutine>c__IteratorAF.GetProfileFromServer`

**URI parameters:** `id`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
private static AutoRetryWWWCompletionCallback ParseProfileCallback (GetProfileCallback callback)
{
	return delegate(WWW www) {
		PlayerModel profile = ((!string.IsNullOrEmpty (www.error)) ? null : PlayerModel.Parse (www.text));
		callback (www.error, profile);
	};
}
```

</details>

---

