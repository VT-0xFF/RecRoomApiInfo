# Settings

## DowloadLocalPlayerSettings

**GET** `api/settings/v1/Profile.LocalProfile.Id`

*(first seen: 2016-11-08_22-55-23, last seen: 2016-11-29_21-32-10)*

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(WWW www) {
	if (string.IsNullOrEmpty (www.error)) {
		List<object> list = ParsePlayerSettings (www.text);
		if (list != null) {
			callback2 (null, list);
		} else {
			callback2 ("Failed to parse player preferences '" + www.text + "'", null);
		}
	} else {
		callback2 (www.error, null);
	}
}
```

---

## DowloadLocalPlayerSettings

**GET** `api/settings/v2/`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(string error, List<Setting> settings) {
	if (string.IsNullOrEmpty (error)) {
		Core.SafeInvoke (callback2, null, settings);
	} else {
		Debug.LogError ("Failed to download player settings: " + error);
		Core.SafeInvoke (callback2, "Failed to download player settings", null);
	}
}
```

---

## Remove

**POST** `api/settings/v1/remove`

*(first seen: 2016-11-08_22-55-23, last seen: 2016-11-29_21-32-10)*

**Body:** Form

| Field | Value |
|-------|-------|
| `Key` | `string` |
| `PlayerId` | `profile.Id.ToString ()` |

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(WWW www) {
	callback2 (www.error);
}
```

---

## Set

**POST** `api/settings/v1/set`

*(first seen: 2016-11-08_22-55-23, last seen: 2016-11-29_21-32-10)*

**Body:** Form

| Field | Value |
|-------|-------|
| `Key` | `string` |
| `Value` | `string` |
| `PlayerId` | `profile.Id.ToString ()` |

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(WWW www) {
	callback2 (www.error);
}
```

---

## StoreLocalPlayerSetting

**POST** `api/settings/v2/action`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Body:** Form

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
callback
```

---

