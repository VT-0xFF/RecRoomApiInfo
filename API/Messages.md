# Messages

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## POST `api/messages/v1/IOSClearDeviceToken`

*first seen: 2019-06-27_14-02-36 — last seen: 2021-08-06_06-02-59 (109 builds)*

**Declared by:** `Messages.IOSClearDeviceToken`

**Request body:** BestHTTP.Forms.HTTPUrlEncodedForm

| Field | Type |
|-------|------|
| `platformId` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num != 0
```

</details>

---

## GET `api/messages/v1/IOSGetNotificationPreferences`

*first seen: 2019-10-02_14-21-06 — last seen: 2021-06-15_02-50-02 (85 builds)*

**Declared by:** `Messages.IOSGetNotificationPreferences`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num != 0
```

</details>

---

## POST `api/messages/v1/IOSModifyNotificationPreferences`

*first seen: 2019-10-02_14-21-06 — last seen: 2021-08-06_06-02-59 (92 builds)*

**Declared by:** `Messages.IOSModifyNotificationPreferences`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num != 0
```

</details>

---

## POST `api/messages/v1/IOSResetNotificationPreferencesBadgeCount`

*first seen: 2019-10-02_14-21-06 — last seen: 2021-06-02_02-50-56 (83 builds)*

**Declared by:** `Messages.IOSResetNotificationPreferencesBadgeCount`

**Request body:** BestHTTP.Forms.HTTPUrlEncodedForm

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num != 0
```

</details>

---

## POST `api/messages/v1/IOSSaveDeviceToken`

*first seen: 2019-06-27_14-02-36 — last seen: 2021-08-06_06-02-59 (109 builds)*

**Declared by:** `Messages.IOSSaveDeviceToken`

**Request body:** BestHTTP.Forms.HTTPUrlEncodedForm

| Field | Type |
|-------|------|
| `platformId` | `string` |
| `deviceToken` | `string` |
| `appBundleId` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num2 != 0
```

</details>

---

## POST `api/messages/v1/delete`

*first seen: 2016-11-23_01-26-08 — last seen: 2016-11-29_21-32-10 (3 builds)*

**Declared by:** `Message.DeleteMessage`

**URI parameters:** `messageId`

**Request body:** WWWForm (application/x-www-form-urlencoded)

| Field | Type |
|-------|------|
| `Id` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
delegate(WWW www) {
	SafeInvokeCallback (callback, www.error);
}
```

</details>

---

## GET `api/messages/v1/favoriteFriendOnlineStatus`

*first seen: 2019-10-02_14-21-06 — last seen: 2021-08-06_06-02-59 (92 builds)*

**Declared by:** `Messages.SendOnlineStatusToFavoriteFriendsAsMobilePushNotification`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num != 0
```

</details>

---

## GET `api/messages/v1/get/{Id}`

*first seen: 2016-11-23_01-26-08 — last seen: 2016-11-29_21-32-10 (3 builds)*

**Declared by:** `Message.RefreshList`

**URI parameters:** `Id`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

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

</details>

---

## POST `api/messages/v1/send`

*first seen: 2016-11-23_01-26-08 — last seen: 2016-11-29_21-32-10 (3 builds)*

**Declared by:** `Message.SendMessage`

**Request body:** WWWForm (application/x-www-form-urlencoded)

| Field | Type |
|-------|------|
| `FromPlayerId` | `string` |
| `ToPlayerId` | `string` |
| `Type` | `int` |
| `Data` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
delegate(WWW www) {
	SafeInvokeCallback (callback, www.error);
}
```

</details>

---

## POST `api/messages/v1/sendMultiple`

*first seen: 2017-03-09_02-36-59 — last seen: 2021-08-06_06-02-59 (131 builds)*

**Declared by:** `Messages.SendStatusOnlineToFriends`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num3 != 0
```

</details>

---

## POST `api/messages/v2/delete`

*first seen: 2016-12-09_03-11-41 — last seen: 2019-06-28_13-58-34 (156 builds)*

**Declared by:** `Messages.DeleteMessage`

**URI parameters:** `messageId`

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `Id` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
callback
```

</details>

---

## GET `api/messages/v2/get`

*first seen: 2016-12-09_03-11-41 — last seen: 2019-09-05_17-54-23 (167 builds)*

**Declared by:** `Messages.RefreshList`

**Response:**

`200 OK` — JSON `Message`

```json
{
  "Id": long,
  "FromPlayerId": ulong,
  "SentTime": DateTime,   // epoch ticks
  "Type": int,   // enum MessageType
  "Data": string
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `Id` | `long` | `Id` |
| `FromPlayerId` | `ulong` | `FromPlayerId` |
| `SentTime` | `DateTime` | `SentTime` |
| `Type` | `int` | `Type` |
| `Data` | `string` | `Data` |

<details><summary>Client-side callback</summary>

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

</details>

---

## POST `api/messages/v2/send`

*first seen: 2016-12-09_03-11-41 — last seen: 2021-08-06_06-02-59 (256 builds)*

**Declared by:** `Messages.SendMessage`

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `ToPlayerId` | `string` |
| `Type` | `string` |
| `Data` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
callback
```

</details>

---

## POST `api/messages/v3/delete`

*first seen: 2019-07-02_17-01-39 — last seen: 2021-08-06_06-02-59 (107 builds)*

**Declared by:** `Messages.DeleteMessages`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num4 != 0
```

</details>

---

