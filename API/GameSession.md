# GameSession

## GetAllGameSessionsFromServer

**GET** `api/gamesessions/v1/?v=BuildSettings.Version`

*(first seen: 2016-11-23_01-26-08, last seen: 2016-11-29_21-32-10)*

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(WWW www) {
	List<GameSession> gameSessions = ((!string.IsNullOrEmpty (www.error)) ? null : ParseArray (www.text));
	SafeInvokeCallback (callback, www.error, gameSessions);
}
```

---

## GetGameSessionFromServer

**GET** `api/gamesessions/v1/WWW.EscapeURL (id)`

*(first seen: 2016-11-23_01-26-08, last seen: 2016-11-29_21-32-10)*

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(WWW www) {
	GameSession gameSession = ((!string.IsNullOrEmpty (www.error)) ? null : ParseSingle (www.text));
	SafeInvokeCallback (callback, www.error, gameSession);
}
```

---

