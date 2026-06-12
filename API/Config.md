# Config

## DownloadConfigSettings

**GET** `api/config/v2`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(string error, RecRoomConfig config) {
	instance = config;
	if (!string.IsNullOrEmpty (error)) {
		Debug.LogError ("Failed to download config settings: " + error);
		Core.SafeInvoke (callback, "Failed to connect to RecNet");
	} else {
		Core.SafeInvoke (callback, null);
	}
}
```

---

## GetDailyObjectives

**GET** `api/config/v1/objectives`

*(first seen: 2016-10-26_20-30-17, last seen: 2016-11-29_21-32-10)*

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(WWW www) {
	ProgressionManager.Objective[][] objectives = ((!string.IsNullOrEmpty (www.error)) ? null : ParseDailyObjectives (www.text));
	callback (www.error, objectives);
}
```

---

## GetMessageOfTheDay

**GET** `api/config/v1/motd`

*(first seen: 2016-10-26_20-30-17, last seen: 2016-11-29_21-32-10)*

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(WWW www) {
	callback (www.error, www.text);
}
```

---

