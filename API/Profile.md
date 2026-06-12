# Profile

## CompleteObjective

**POST** `api/players/v1/objective/LocalProfile.Id`

*(first seen: 2016-11-23_01-26-08, last seen: 2016-11-29_21-32-10)*

**Body:** Form

| Field | Value |
|-------|-------|
| `objectiveType` | `int` |
| `additionalXp` | `int` |
| `inParty` | `inParty.ToString ()` |

**Expected Response:**

200 JSON
```json
{
  "deltaXp": int,
  "currentLevel": int,
  "currentXp": int,
  "xpRequiredToLevelUp": int,
}
```

**Callback(s):**
```cs
private static Core.ApiCallback ParseObjectiveCompleteCallback (GetObjectiveCompletedCallback callback)
{
	return delegate(WWW www) {
		ObjectiveComplete objectiveComplete = ((!string.IsNullOrEmpty (www.error)) ? null : ParseObjectiveComplete (www.text));
		callback (www.error, objectiveComplete);
	};
}

```

---

## Create

**POST** `api/players/v1/create`

*(first seen: 2016-10-26_20-30-17, last seen: 2016-11-29_21-32-10)*

**Body:** Form

| Field | Value |
|-------|-------|
| `Platform` | `int` |
| `PlatformId` | `platformPlayerId.ToString ()` |
| `Name` | `string` |

**Expected Response:**

200 JSON
```json
{
  "Id": ulong,
  "Username": string,
  "DisplayName": string,
  "XP": int,
  "Level": int,
  "Reputation": int,
  "Verified": bool,
}
```

**Callback(s):**
```cs
private static Core.ApiCallback ParseProfileCallback (GetProfileCallback callback)
{
	return delegate(WWW www) {
		Profile profile = ((!string.IsNullOrEmpty (www.error)) ? null : ParseProfile (www.text));
		callback (www.error, profile);
	};
}

```

---

## Get

**GET** `api/players/v1/?p=(int)platform&id=platformPlayerId`

*(first seen: 2016-10-26_20-30-17, last seen: 2016-11-29_21-32-10)*

**Expected Response:**

200 JSON
```json
{
  "Id": ulong,
  "Username": string,
  "DisplayName": string,
  "XP": int,
  "Level": int,
  "Reputation": int,
  "Verified": bool,
}
```

**Callback(s):**
```cs
private static Core.ApiCallback ParseProfileCallback (GetProfileCallback callback)
{
	return delegate(WWW www) {
		Profile profile = ((!string.IsNullOrEmpty (www.error)) ? null : ParseProfile (www.text));
		callback (www.error, profile);
	};
}

```

---

## Get

**GET** `api/players/v1/id`

*(first seen: 2016-10-26_20-30-17, last seen: 2016-11-29_21-32-10)*

**Expected Response:**

200 JSON
```json
{
  "Id": ulong,
  "Username": string,
  "DisplayName": string,
  "XP": int,
  "Level": int,
  "Reputation": int,
  "Verified": bool,
}
```

**Callback(s):**
```cs
private static Core.ApiCallback ParseProfileCallback (GetProfileCallback callback)
{
	return delegate(WWW www) {
		Profile profile = ((!string.IsNullOrEmpty (www.error)) ? null : ParseProfile (www.text));
		callback (www.error, profile);
	};
}

```

---

## Get

**POST** `api/players/v1/list`

*(first seen: 2016-11-23_01-26-08, last seen: 2016-11-29_21-32-10)*

**Body:** Form

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
private static Core.ApiCallback ParseProfilesCallback (GetProfilesCallback callback)
{
	return delegate(WWW www) {
		List<Profile> profiles = ((!string.IsNullOrEmpty (www.error)) ? null : ParseProfiles (www.text));
		callback (www.error, profiles);
	};
}

```

---

## Save

**POST** `api/players/v1/update/profile.Id`

*(first seen: 2016-10-26_20-30-17, last seen: 2016-11-16_19-34-45)*

**Body:** Form

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(WWW www) {
	callback (www.error);
}
```

---

## SendRegistrationEmail

**POST** `api/players/v1/verify/LocalProfile.Id`

*(first seen: 2016-10-26_20-30-17, last seen: 2016-11-29_21-32-10)*

**Body:** Form

| Field | Value |
|-------|-------|
| `email` | `string` |

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(WWW www) {
	string text = www.text.Replace ("{\"Message\":\"", string.Empty).Replace ("\"}", string.Empty);
	callback (text, www.error);
}
```

---

## UpdateReputation

**POST** `api/players/v1/updateReputation/profile.Id`

*(first seen: 2016-11-23_01-26-08, last seen: 2016-11-29_21-32-10)*

**Body:** Form

| Field | Value |
|-------|-------|
| `reputation` | `profile.Reputation` |

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(WWW www) {
	callback (www.error);
}
```

---

