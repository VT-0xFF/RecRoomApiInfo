# Profiles

## CompleteObjective

**POST** `api/players/v2/objective`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Body:** Form

| Field | Value |
|-------|-------|
| `objectiveType` | `num.ToString ()` |
| `additionalXp` | `additionalXp.ToString ()` |
| `inParty` | `inParty.ToString ()` |

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
callback
```

---

## Get

**GET** `api/players/v1/id`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
callback
```

---

## Get

**POST** `api/players/v1/list`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Body:** Form

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
callback
```

---

## Get

**GET** `api/players/v2/?p=(int)platform&id=platformPlayerId`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
callback
```

---

## GetOrCreate

**POST** `api/players/v1/getorcreate`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Body:** Form

| Field | Value |
|-------|-------|
| `Platform` | `num.ToString ()` |
| `PlatformId` | `platformPlayerId.ToString ()` |
| `Name` | `string` |

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
callback
```

---

## LocalAddScore

**POST** `api/players/v1/score`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Body:** Form

| Field | Value |
|-------|-------|
| `SessionId` | `Core.SessionId.ToString ()` |
| `Activity` | `string` |
| `Category` | `string` |
| `Score` | `score.ToString ()` |
| `Comment` | `string` |
| `SecondaryScore` | `secondaryScore.Value.ToString ()` |

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(string wwwError) {
	if (!string.IsNullOrEmpty (wwwError)) {
		Debug.LogError ("Failed to add score : " + wwwError);
	}
}
```

---

## SendRegistrationEmail

**POST** `api/players/v2/verify`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Body:** Form

| Field | Value |
|-------|-------|
| `Email` | `string` |

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(string error, RegistrationEmailResponse response) {
	string response2 = response?.Message;
	Core.SafeInvoke (callback, error, response2);
}
```

---

## UpdateLocalProfileKarma

**POST** `api/playerReputation/v1/heal`

*(first seen: 2017-01-18_01-10-07, last seen: 2017-02-03_23-53-02)*

**Body:** Form

| Field | Value |
|-------|-------|
| `GoodKarmaMinutes` | `value` |

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(string wwwError) {
	if (!string.IsNullOrEmpty (wwwError)) {
		Debug.LogError ("Failed to update Rec Room player good karma: " + wwwError);
	}
}
```

---

## UpdateLocalProfileReputation

**POST** `api/players/v2/updateReputation`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Body:** Form

| Field | Value |
|-------|-------|
| `reputationDelta` | `reputationDelta.ToString ()` |

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(string wwwError) {
	if (!string.IsNullOrEmpty (wwwError)) {
		Debug.LogError ("Failed to upload Rec Room player profile reputation changes: " + wwwError);
	} else {
		Profile localProfile = LocalProfile;
		localProfile.Reputation = (int)localProfile.Reputation - reputationDelta;
	}
}
```

---

