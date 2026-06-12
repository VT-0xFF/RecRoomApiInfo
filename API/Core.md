# Core

## TestConnection

**GET** `api/versioncheck/v1`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(UnityWebRequest unityWebRequest) {
	responseCode = unityWebRequest.responseCode;
	error = GetError (unityWebRequest);
}
```

---

