# Relationships

## AcceptFriendRequest

**GET** `api/relationships/v1/acceptfriendrequest?id1=Profile.LocalProfile.Id&id2=playerId`

*(first seen: 2016-11-23_01-26-08, last seen: 2016-11-29_21-32-10)*

**Expected Response:**

200 JSON
```json
{
  "PlayerID": ulong,
  "RelationshipType": int,
}
```

**Callback(s):**
```cs
private static Core.ApiCallback ParseRelationshipCallback (ApiCallback callback)
{
	return delegate(WWW www) {
		string text = www.error;
		if (string.IsNullOrEmpty (text)) {
			try {
				Relationship relation = ParseRelationship (www.text);
				AddRelationshipToCache (relation);
			} catch (Exception exception) {
				Debug.LogException (exception);
				text = "Parse error";
			}
		}
		SafeInvokeCallback (callback, text);
	};
}

```

---

## AcceptFriendRequest

**GET** `api/relationships/v2/acceptfriendrequest?id=playerId`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
private static Core.ApiCallback<Relationship> ParseRelationshipCallback (Core.ApiCallback callback)
{
	return delegate(string error, Relationship relationship) {
		if (string.IsNullOrEmpty (error)) {
			AddRelationshipToCache (relationship);
		}
		Core.SafeInvoke (callback, error);
	};
}

```

---

## AddFriend

**GET** `api/relationships/v1/addfriend?id1=Profile.LocalProfile.Id&id2=playerId`

*(first seen: 2016-11-23_01-26-08, last seen: 2016-11-29_21-32-10)*

**Expected Response:**

200 JSON
```json
{
  "PlayerID": ulong,
  "RelationshipType": int,
}
```

**Callback(s):**
```cs
private static Core.ApiCallback ParseRelationshipCallback (ApiCallback callback)
{
	return delegate(WWW www) {
		string text = www.error;
		if (string.IsNullOrEmpty (text)) {
			try {
				Relationship relation = ParseRelationship (www.text);
				AddRelationshipToCache (relation);
			} catch (Exception exception) {
				Debug.LogException (exception);
				text = "Parse error";
			}
		}
		SafeInvokeCallback (callback, text);
	};
}

```

---

## AddFriend

**GET** `api/relationships/v2/addfriend?id=playerId`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
private static Core.ApiCallback<Relationship> ParseRelationshipCallback (Core.ApiCallback callback)
{
	return delegate(string error, Relationship relationship) {
		if (string.IsNullOrEmpty (error)) {
			AddRelationshipToCache (relationship);
		}
		Core.SafeInvoke (callback, error);
	};
}

```

---

## BlockPlayer

**GET** `api/relationships/v1/blockplayer?id1=Profile.LocalProfile.Id&id2=playerId`

*(first seen: 2016-11-23_01-26-08, last seen: 2016-11-29_21-32-10)*

**Expected Response:**

200 JSON
```json
{
  "PlayerID": ulong,
  "RelationshipType": int,
}
```

**Callback(s):**
```cs
private static Core.ApiCallback ParseRelationshipCallback (ApiCallback callback)
{
	return delegate(WWW www) {
		string text = www.error;
		if (string.IsNullOrEmpty (text)) {
			try {
				Relationship relation = ParseRelationship (www.text);
				AddRelationshipToCache (relation);
			} catch (Exception exception) {
				Debug.LogException (exception);
				text = "Parse error";
			}
		}
		SafeInvokeCallback (callback, text);
	};
}

```

---

## BlockPlayer

**GET** `api/relationships/v2/blockplayer?id=playerId`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
private static Core.ApiCallback<Relationship> ParseRelationshipCallback (Core.ApiCallback callback)
{
	return delegate(string error, Relationship relationship) {
		if (string.IsNullOrEmpty (error)) {
			AddRelationshipToCache (relationship);
		}
		Core.SafeInvoke (callback, error);
	};
}

```

---

## RefreshList

**GET** `api/relationships/v1/get/Profile.LocalProfile.Id`

*(first seen: 2016-11-23_01-26-08, last seen: 2016-11-29_21-32-10)*

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(WWW www) {
	if (string.IsNullOrEmpty (www.error)) {
		try {
			RelationshipList = ParseRelationships (www.text);
		} catch (Exception exception) {
			Debug.LogException (exception);
		}
		RaiseRelationshipListUpdatedEvent ();
	} else {
		Debug.LogError (www.error);
		RefreshList ();
	}
}
```

---

## RefreshList

**GET** `api/relationships/v2/get`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(string error, List<Relationship> newRelationshipList) {
	if (string.IsNullOrEmpty (error)) {
		RelationshipList = newRelationshipList;
		RaiseRelationshipListUpdatedEvent ();
	} else {
		Debug.LogError ("Failed to refresh relationship list: " + error);
		RefreshList ();
	}
}
```

---

## RemoveFriend

**GET** `api/relationships/v1/removefriend?id1=Profile.LocalProfile.Id&id2=playerId`

*(first seen: 2016-11-23_01-26-08, last seen: 2016-11-29_21-32-10)*

**Expected Response:**

200 JSON
```json
{
  "PlayerID": ulong,
  "RelationshipType": int,
}
```

**Callback(s):**
```cs
private static Core.ApiCallback ParseRelationshipCallback (ApiCallback callback)
{
	return delegate(WWW www) {
		string text = www.error;
		if (string.IsNullOrEmpty (text)) {
			try {
				Relationship relation = ParseRelationship (www.text);
				AddRelationshipToCache (relation);
			} catch (Exception exception) {
				Debug.LogException (exception);
				text = "Parse error";
			}
		}
		SafeInvokeCallback (callback, text);
	};
}

```

---

## RemoveFriend

**GET** `api/relationships/v2/removefriend?id=playerId`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
private static Core.ApiCallback<Relationship> ParseRelationshipCallback (Core.ApiCallback callback)
{
	return delegate(string error, Relationship relationship) {
		if (string.IsNullOrEmpty (error)) {
			AddRelationshipToCache (relationship);
		}
		Core.SafeInvoke (callback, error);
	};
}

```

---

## SendFriendRequest

**GET** `api/relationships/v1/sendfriendrequest?id1=Profile.LocalProfile.Id&id2=playerId`

*(first seen: 2016-11-23_01-26-08, last seen: 2016-11-29_21-32-10)*

**Expected Response:**

200 JSON
```json
{
  "PlayerID": ulong,
  "RelationshipType": int,
}
```

**Callback(s):**
```cs
private static Core.ApiCallback ParseRelationshipCallback (ApiCallback callback)
{
	return delegate(WWW www) {
		string text = www.error;
		if (string.IsNullOrEmpty (text)) {
			try {
				Relationship relation = ParseRelationship (www.text);
				AddRelationshipToCache (relation);
			} catch (Exception exception) {
				Debug.LogException (exception);
				text = "Parse error";
			}
		}
		SafeInvokeCallback (callback, text);
	};
}

```

---

## SendFriendRequest

**GET** `api/relationships/v2/sendfriendrequest?id=playerId`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
private static Core.ApiCallback<Relationship> ParseRelationshipCallback (Core.ApiCallback callback)
{
	return delegate(string error, Relationship relationship) {
		if (string.IsNullOrEmpty (error)) {
			AddRelationshipToCache (relationship);
		}
		Core.SafeInvoke (callback, error);
	};
}

```

---

## UnblockPlayer

**GET** `api/relationships/v1/unblockplayer?id1=Profile.LocalProfile.Id&id2=playerId`

*(first seen: 2016-11-23_01-26-08, last seen: 2016-11-29_21-32-10)*

**Expected Response:**

200 JSON
```json
{
  "PlayerID": ulong,
  "RelationshipType": int,
}
```

**Callback(s):**
```cs
private static Core.ApiCallback ParseRelationshipCallback (ApiCallback callback)
{
	return delegate(WWW www) {
		string text = www.error;
		if (string.IsNullOrEmpty (text)) {
			try {
				Relationship relation = ParseRelationship (www.text);
				AddRelationshipToCache (relation);
			} catch (Exception exception) {
				Debug.LogException (exception);
				text = "Parse error";
			}
		}
		SafeInvokeCallback (callback, text);
	};
}

```

---

## UnblockPlayer

**GET** `api/relationships/v2/unblockplayer?id=playerId`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
private static Core.ApiCallback<Relationship> ParseRelationshipCallback (Core.ApiCallback callback)
{
	return delegate(string error, Relationship relationship) {
		if (string.IsNullOrEmpty (error)) {
			AddRelationshipToCache (relationship);
		}
		Core.SafeInvoke (callback, error);
	};
}

```

---

