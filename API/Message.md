# Message

## DeleteMessage

**POST** `api/messages/v1/delete`

*(first seen: 2016-11-23_01-26-08, last seen: 2016-11-29_21-32-10)*

**Body:** Form

| Field | Value |
|-------|-------|
| `Id` | `messageId.ToString ()` |

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(WWW www) {
	SafeInvokeCallback (callback, www.error);
}
```

---

## RefreshList

**GET** `api/messages/v1/get/Profile.LocalProfile.Id`

*(first seen: 2016-11-23_01-26-08, last seen: 2016-11-29_21-32-10)*

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(WWW www) {
	if (string.IsNullOrEmpty (www.error)) {
		try {
			MessageList = ParseMessages (www.text);
			RaiseMessageListUpdatedEvent (UpdateType.Initial);
			return;
		} catch (Exception exception) {
			Debug.LogException (exception);
			return;
		}
	}
	Debug.LogError (www.error);
	RefreshList ();
}
```

---

## SendMessage

**POST** `api/messages/v1/send`

*(first seen: 2016-11-23_01-26-08, last seen: 2016-11-29_21-32-10)*

**Body:** Form

| Field | Value |
|-------|-------|
| `FromPlayerId` | `Profile.LocalProfile.Id.ToString ()` |
| `ToPlayerId` | `playerId.ToString ()` |
| `Type` | `int` |
| `Data` | `string` |

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(WWW www) {
	SafeInvokeCallback (callback, www.error);
}
```

---

