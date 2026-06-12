# Messages

## DeleteMessage

**POST** `api/messages/v2/delete`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Body:** Form

| Field | Value |
|-------|-------|
| `Id` | `messageId.ToString ()` |

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
callback
```

---

## RefreshList

**GET** `api/messages/v2/get`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(string error, List<Message> newMessageList) {
	if (string.IsNullOrEmpty (error)) {
		MessageList = newMessageList;
		RaiseMessageListUpdatedEvent (UpdateType.Initial);
	} else {
		Debug.LogError ("Failed to refresh message list: " + error);
		RefreshList ();
	}
}
```

---

## SendMessage

**POST** `api/messages/v2/send`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Body:** Form

| Field | Value |
|-------|-------|
| `ToPlayerId` | `playerId.ToString ()` |
| `Type` | `num.ToString ()` |
| `Data` | `string` |

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
callback
```

---

