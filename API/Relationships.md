# Relationships

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## POST `api/relationships/sendfriendintroductions`

*first seen: 2021-05-24_02-50-09 — last seen: 2021-08-06_06-02-59 (11 builds)*

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num != 0
```

</details>

---

## GET `api/relationships/v1/acceptfriendrequest?id1={Id}&id2={playerId}`

*first seen: 2016-11-23_01-26-08 — last seen: 2016-11-29_21-32-10 (3 builds)*

**Declared by:** `Relationships.AcceptFriendRequest`

**URI parameters:** `Id`, `playerId`

**Response:**

`200 OK` — JSON `Relationship`

```json
{
  "PlayerID": ulong,
  "RelationshipType": int   // enum RelationshipType
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `PlayerID` | `ulong` | `PlayerID` |
| `RelationshipType` | `int` | `RelationshipType` |

<details><summary>Client-side callback</summary>

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

</details>

---

## GET `api/relationships/v1/addfriend?id1={Id}&id2={playerId}`

*first seen: 2016-11-23_01-26-08 — last seen: 2016-11-29_21-32-10 (3 builds)*

**Declared by:** `Relationships.AddFriend`

**URI parameters:** `Id`, `playerId`

**Response:**

`200 OK` — JSON `Relationship`

```json
{
  "PlayerID": ulong,
  "RelationshipType": int   // enum RelationshipType
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `PlayerID` | `ulong` | `PlayerID` |
| `RelationshipType` | `int` | `RelationshipType` |

<details><summary>Client-side callback</summary>

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

</details>

---

## GET `api/relationships/v1/blockplayer?id1={Id}&id2={playerId}`

*first seen: 2016-11-23_01-26-08 — last seen: 2016-11-29_21-32-10 (3 builds)*

**Declared by:** `Relationships.BlockPlayer`

**URI parameters:** `Id`, `playerId`

**Response:**

`200 OK` — JSON `Relationship`

```json
{
  "PlayerID": ulong,
  "RelationshipType": int   // enum RelationshipType
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `PlayerID` | `ulong` | `PlayerID` |
| `RelationshipType` | `int` | `RelationshipType` |

<details><summary>Client-side callback</summary>

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

</details>

---

## GET `api/relationships/v1/bulkignoreplatformusers`

*first seen: 2018-04-27_18-51-13 — last seen: 2018-12-06_21-26-17 (44 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/relationships/v1/bulkignoreplatformusers`

*first seen: 2017-10-27_20-21-58 — last seen: 2021-08-06_06-02-59 (154 builds)*

**Declared by:** `Relationships.BulkIgnorePlatformUsers`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/relationships/v1/favorite?id={flag}`

*first seen: 2018-05-09_19-37-59 — last seen: 2021-08-06_06-02-59 (167 builds)*

**Declared by:** `Relationships.FavoritePlayer`

**URI parameters:** `reciprocalStatus`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/relationships/v1/get/{Id}`

*first seen: 2016-11-23_01-26-08 — last seen: 2016-11-29_21-32-10 (3 builds)*

**Declared by:** `Relationships.RefreshList`

**URI parameters:** `Id`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

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

</details>

---

## GET `api/relationships/v1/removefriend?id1={Id}&id2={playerId}`

*first seen: 2016-11-23_01-26-08 — last seen: 2016-11-29_21-32-10 (3 builds)*

**Declared by:** `Relationships.RemoveFriend`

**URI parameters:** `Id`, `playerId`

**Response:**

`200 OK` — JSON `Relationship`

```json
{
  "PlayerID": ulong,
  "RelationshipType": int   // enum RelationshipType
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `PlayerID` | `ulong` | `PlayerID` |
| `RelationshipType` | `int` | `RelationshipType` |

<details><summary>Client-side callback</summary>

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

</details>

---

## GET `api/relationships/v1/sendfriendrequest?id1={Id}&id2={playerId}`

*first seen: 2016-11-23_01-26-08 — last seen: 2016-11-29_21-32-10 (3 builds)*

**Declared by:** `Relationships.SendFriendRequest`

**URI parameters:** `Id`, `playerId`

**Response:**

`200 OK` — JSON `Relationship`

```json
{
  "PlayerID": ulong,
  "RelationshipType": int   // enum RelationshipType
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `PlayerID` | `ulong` | `PlayerID` |
| `RelationshipType` | `int` | `RelationshipType` |

<details><summary>Client-side callback</summary>

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

</details>

---

## GET `api/relationships/v1/unblockplayer?id1={Id}&id2={playerId}`

*first seen: 2016-11-23_01-26-08 — last seen: 2016-11-29_21-32-10 (3 builds)*

**Declared by:** `Relationships.UnblockPlayer`

**URI parameters:** `Id`, `playerId`

**Response:**

`200 OK` — JSON `Relationship`

```json
{
  "PlayerID": ulong,
  "RelationshipType": int   // enum RelationshipType
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `PlayerID` | `ulong` | `PlayerID` |
| `RelationshipType` | `int` | `RelationshipType` |

<details><summary>Client-side callback</summary>

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

</details>

---

## GET `api/relationships/v1/unfavorite?id={flag}`

*first seen: 2018-05-09_19-37-59 — last seen: 2021-08-06_06-02-59 (167 builds)*

**Declared by:** `Relationships.UnfavoritePlayer`

**URI parameters:** `reciprocalStatus`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/relationships/v2/`

*first seen: 2017-02-10_01-48-05 — last seen: 2017-03-01_21-37-31 (2 builds)*

**Declared by:** `<DowloadLocalPlayerSettings>c__IteratorC6.JLOGBHHMCHE`

**Request body:** System.Boolean

**Response:**

`200 OK` — JSON `JBODKDEGMDO`

```json
{
  "Key": string,
  "Value": string
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `Key` | `string` | `DBIDKCJPCLA` |
| `Value` | `string` | `HHHHFHHEBJM` |

<details><summary>Client-side callback</summary>

```cs
internal void JHBPCOCGLDH (string GHJBJJPHNHD, List<JBODKDEGMDO> CKJKCMPGGPE)
{
	if (string.IsNullOrEmpty (GHJBJJPHNHD)) {
		BFEONIELEAH.FOBBKGGGEKD (ADHBNDGBJCE, null, CKJKCMPGGPE);
		return;
	}
	UnityEngine.Debug.LogError ("_EmissionColor" + GHJBJJPHNHD);
	BFEONIELEAH.FOBBKGGGEKD (ADHBNDGBJCE, "Can't set room properties when not in that room.", null);
}
```

</details>

---

## GET `api/relationships/v2/acceptfriendrequest?id={playerId}`

*first seen: 2016-12-09_03-11-41 — last seen: 2018-12-06_21-26-17 (144 builds)*

**Declared by:** `Relationships.AcceptFriendRequest`

**URI parameters:** `param`

**Response:**

`200 OK` — JSON `HAGGMKNIFHJ`

```json
{
  "PlayerID": ulong,
  "RelationshipType": int,   // enum KJBHIEHHHGM
  "Mute": bool,
  "Ignore": bool
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `PlayerID` | `ulong` | `PHJCIFFEFPF` |
| `RelationshipType` | `int` | `KMCELMEHOKG` |
| `Mute` | `bool` | `ADPOMHIKJBG` |
| `Ignore` | `bool` | `HEFJKCIFNKB` |

<details><summary>Client-side callback</summary>

```cs
private static COGCNMJCNKN.JBBHLKJLENC<HAGGMKNIFHJ> JPPKHOKPAPN (COGCNMJCNKN.AIIOLFAHKDP EGOJDIFBGAF)
{
	return delegate(string HJLPPIBIGNJ, HAGGMKNIFHJ AFONKDIFJPM) {
		if (string.IsNullOrEmpty (HJLPPIBIGNJ)) {
			KCNLMHGDALH (AFONKDIFJPM);
		}
		COGCNMJCNKN.BFNFLFBCDCC (EGOJDIFBGAF, HJLPPIBIGNJ);
	};
}
```

</details>

---

## GET `api/relationships/v2/addfriend?id={playerId}`

*first seen: 2016-12-09_03-11-41 — last seen: 2021-08-06_06-02-59 (195 builds)*

**Declared by:** `Relationships.AddFriend`

**URI parameters:** `param`

**Response:**

`200 OK` — JSON `HAGGMKNIFHJ`

```json
{
  "PlayerID": ulong,
  "RelationshipType": int,   // enum KJBHIEHHHGM
  "Mute": bool,
  "Ignore": bool
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `PlayerID` | `ulong` | `PHJCIFFEFPF` |
| `RelationshipType` | `int` | `KMCELMEHOKG` |
| `Mute` | `bool` | `ADPOMHIKJBG` |
| `Ignore` | `bool` | `HEFJKCIFNKB` |

<details><summary>Client-side callback</summary>

```cs
private static COGCNMJCNKN.JBBHLKJLENC<HAGGMKNIFHJ> JPPKHOKPAPN (COGCNMJCNKN.AIIOLFAHKDP EGOJDIFBGAF)
{
	return delegate(string HJLPPIBIGNJ, HAGGMKNIFHJ AFONKDIFJPM) {
		if (string.IsNullOrEmpty (HJLPPIBIGNJ)) {
			KCNLMHGDALH (AFONKDIFJPM);
		}
		COGCNMJCNKN.BFNFLFBCDCC (EGOJDIFBGAF, HJLPPIBIGNJ);
	};
}
```

</details>

---

## GET `api/relationships/v2/blockplayer?id={playerId}`

*first seen: 2016-12-09_03-11-41 — last seen: 2017-10-05_22-48-34 (71 builds)*

**Declared by:** `Relationships.BlockPlayer`

**URI parameters:** `param`

**Response:**

`200 OK` — JSON `HAGGMKNIFHJ`

```json
{
  "PlayerID": ulong,
  "RelationshipType": int,   // enum KJBHIEHHHGM
  "Mute": bool,
  "Ignore": bool
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `PlayerID` | `ulong` | `PHJCIFFEFPF` |
| `RelationshipType` | `int` | `KMCELMEHOKG` |
| `Mute` | `bool` | `ADPOMHIKJBG` |
| `Ignore` | `bool` | `HEFJKCIFNKB` |

<details><summary>Client-side callback</summary>

```cs
private static COGCNMJCNKN.JBBHLKJLENC<HAGGMKNIFHJ> JPPKHOKPAPN (COGCNMJCNKN.AIIOLFAHKDP EGOJDIFBGAF)
{
	return delegate(string HJLPPIBIGNJ, HAGGMKNIFHJ AFONKDIFJPM) {
		if (string.IsNullOrEmpty (HJLPPIBIGNJ)) {
			KCNLMHGDALH (AFONKDIFJPM);
		}
		COGCNMJCNKN.BFNFLFBCDCC (EGOJDIFBGAF, HJLPPIBIGNJ);
	};
}
```

</details>

---

## GET `api/relationships/v2/get`

*first seen: 2016-12-09_03-11-41 — last seen: 2021-08-06_06-02-59 (271 builds)*

**Declared by:** `Relationships.RefreshList`

**Response:**

`200 OK` — JSON `HAGGMKNIFHJ`

```json
{
  "PlayerID": ulong,
  "RelationshipType": int,   // enum KJBHIEHHHGM
  "Mute": bool,
  "Ignore": bool
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `PlayerID` | `ulong` | `PHJCIFFEFPF` |
| `RelationshipType` | `int` | `KMCELMEHOKG` |
| `Mute` | `bool` | `ADPOMHIKJBG` |
| `Ignore` | `bool` | `HEFJKCIFNKB` |

<details><summary>Client-side callback</summary>

```cs
delegate(string HJLPPIBIGNJ, List<HAGGMKNIFHJ> DFDCBHHGIOA) {
	if (string.IsNullOrEmpty (HJLPPIBIGNJ)) {
		AMGMCCHMOFO = DFDCBHHGIOA;
		NFAELLFHGFE ();
	} else {
		Debug.LogError ("Failed to refresh relationship list: " + HJLPPIBIGNJ);
		PANGFDLFKNF ();
	}
}
```

</details>

---

## GET `api/relationships/v2/removefriend?id={playerId}`

*first seen: 2016-12-09_03-11-41 — last seen: 2018-12-06_21-26-17 (144 builds)*

**Declared by:** `Relationships.RemoveFriend`

**URI parameters:** `param`

**Response:**

`200 OK` — JSON `HAGGMKNIFHJ`

```json
{
  "PlayerID": ulong,
  "RelationshipType": int,   // enum KJBHIEHHHGM
  "Mute": bool,
  "Ignore": bool
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `PlayerID` | `ulong` | `PHJCIFFEFPF` |
| `RelationshipType` | `int` | `KMCELMEHOKG` |
| `Mute` | `bool` | `ADPOMHIKJBG` |
| `Ignore` | `bool` | `HEFJKCIFNKB` |

<details><summary>Client-side callback</summary>

```cs
private static COGCNMJCNKN.JBBHLKJLENC<HAGGMKNIFHJ> JPPKHOKPAPN (COGCNMJCNKN.AIIOLFAHKDP EGOJDIFBGAF)
{
	return delegate(string HJLPPIBIGNJ, HAGGMKNIFHJ AFONKDIFJPM) {
		if (string.IsNullOrEmpty (HJLPPIBIGNJ)) {
			KCNLMHGDALH (AFONKDIFJPM);
		}
		COGCNMJCNKN.BFNFLFBCDCC (EGOJDIFBGAF, HJLPPIBIGNJ);
	};
}
```

</details>

---

## GET `api/relationships/v2/sendfriendrequest?id={playerId}`

*first seen: 2016-12-09_03-11-41 — last seen: 2018-12-06_21-26-17 (144 builds)*

**Declared by:** `Relationships.SendFriendRequest`

**URI parameters:** `param`

**Response:**

`200 OK` — JSON `HAGGMKNIFHJ`

```json
{
  "PlayerID": ulong,
  "RelationshipType": int,   // enum KJBHIEHHHGM
  "Mute": bool,
  "Ignore": bool
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `PlayerID` | `ulong` | `PHJCIFFEFPF` |
| `RelationshipType` | `int` | `KMCELMEHOKG` |
| `Mute` | `bool` | `ADPOMHIKJBG` |
| `Ignore` | `bool` | `HEFJKCIFNKB` |

<details><summary>Client-side callback</summary>

```cs
private static COGCNMJCNKN.JBBHLKJLENC<HAGGMKNIFHJ> JPPKHOKPAPN (COGCNMJCNKN.AIIOLFAHKDP EGOJDIFBGAF)
{
	return delegate(string HJLPPIBIGNJ, HAGGMKNIFHJ AFONKDIFJPM) {
		if (string.IsNullOrEmpty (HJLPPIBIGNJ)) {
			KCNLMHGDALH (AFONKDIFJPM);
		}
		COGCNMJCNKN.BFNFLFBCDCC (EGOJDIFBGAF, HJLPPIBIGNJ);
	};
}
```

</details>

---

## GET `api/relationships/v2/unblockplayer?id={playerId}`

*first seen: 2016-12-09_03-11-41 — last seen: 2017-10-05_22-48-34 (71 builds)*

**Declared by:** `Relationships.UnblockPlayer`

**URI parameters:** `param`

**Response:**

`200 OK` — JSON `HAGGMKNIFHJ`

```json
{
  "PlayerID": ulong,
  "RelationshipType": int,   // enum KJBHIEHHHGM
  "Mute": bool,
  "Ignore": bool
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `PlayerID` | `ulong` | `PHJCIFFEFPF` |
| `RelationshipType` | `int` | `KMCELMEHOKG` |
| `Mute` | `bool` | `ADPOMHIKJBG` |
| `Ignore` | `bool` | `HEFJKCIFNKB` |

<details><summary>Client-side callback</summary>

```cs
private static COGCNMJCNKN.JBBHLKJLENC<HAGGMKNIFHJ> JPPKHOKPAPN (COGCNMJCNKN.AIIOLFAHKDP EGOJDIFBGAF)
{
	return delegate(string HJLPPIBIGNJ, HAGGMKNIFHJ AFONKDIFJPM) {
		if (string.IsNullOrEmpty (HJLPPIBIGNJ)) {
			KCNLMHGDALH (AFONKDIFJPM);
		}
		COGCNMJCNKN.BFNFLFBCDCC (EGOJDIFBGAF, HJLPPIBIGNJ);
	};
}
```

</details>

---

## GET `api/relationships/{param}`

*first seen: 2018-05-09_19-37-59 — last seen: 2018-12-06_21-26-17 (40 builds)*

**Declared by:** `TextureDownloadSample.OBIGOJLGNBL`

**URI parameters:** `param`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

---

## POST `api/relationships/{param}`

*first seen: 2017-03-09_02-36-59 — last seen: 2021-08-06_06-02-59 (204 builds)*

**Declared by:** `Relationships.PostPreferenceChange`

**URI parameters:** `route`

**Request body:** form fields (Dictionary<string,string>)

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

