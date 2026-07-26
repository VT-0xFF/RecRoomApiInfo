# Gamesessions

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## POST `api/gamesessions/v1/`

*first seen: 2017-03-31_00-56-34 — last seen: 2017-06-13_22-34-57 (2 builds)*

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `You are already a member!` | `string` |
| `Application Installer ID` | `string` |
| `true` | `string` |

**Response:**

`200 OK` — JSON `KFGAGHEAONI`

```json
{
  "y": GDIMFBEIDHL,
  "scale": GDIMFBEIDHL,
  "C4": GDIMFBEIDHL,
  "SteamVR_RenderModel": GDIMFBEIDHL,
  "YourTeam": DateTime   // epoch ticks
}
```

<details><summary>Client-side callback</summary>

```cs
EGOJDIFBGAF
```

</details>

---

## GET `api/gamesessions/v1/?v={Version}`

*first seen: 2016-11-23_01-26-08 — last seen: 2017-02-03_23-53-02 (15 builds)*

**Declared by:** `GameSession.GetAllGameSessionsFromServer`, `GameSessions.GetAllGameSessionsFromServer`

**URI parameters:** `Version`

**Response:**

`200 OK` — JSON `GameSession`

```json
{
  "Id": string,
  "AppVersion": string,
  "Activity": string,
  "Private": bool,
  "AvailableSpace": int,
  "GameInProgress": bool,
  "PlayerIds": List<object>   // array
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `Id` | `string` | `Id` |
| `AppVersion` | `string` | `AppVersion` |
| `Activity` | `string` | `Activity` |
| `Private` | `bool` | `Private` |
| `AvailableSpace` | `int` | `AvailableSpace` |
| `GameInProgress` | `bool` | `GameInProgress` |
| `PlayerIds` | `List<object>` | — |

<details><summary>Client-side callback</summary>

```cs
callback
```

</details>

---

## GET `api/gamesessions/v1/{id}`

*first seen: 2016-11-23_01-26-08 — last seen: 2017-02-03_23-53-02 (15 builds)*

**Declared by:** `GameSession.GetGameSessionFromServer`, `GameSessions.GetGameSessionFromServer`

**URI parameters:** `id`

**Response:**

`200 OK` — JSON `GameSession`

```json
{
  "Id": string,
  "AppVersion": string,
  "Activity": string,
  "Private": bool,
  "AvailableSpace": int,
  "GameInProgress": bool,
  "PlayerIds": List<object>   // array
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `Id` | `string` | `Id` |
| `AppVersion` | `string` | `AppVersion` |
| `Activity` | `string` | `Activity` |
| `Private` | `bool` | `Private` |
| `AvailableSpace` | `int` | `AvailableSpace` |
| `GameInProgress` | `bool` | `GameInProgress` |
| `PlayerIds` | `List<object>` | — |

<details><summary>Client-side callback</summary>

```cs
callback
```

</details>

---

## GET `api/gamesessions/v2/`

*first seen: 2017-11-30_23-39-18 — last seen: 2018-06-21_00-30-05 (4 builds)*

**Declared by:** `LargeFileDownloadSample.KOGHHDMLONG`

**Response:**

`200 OK` — JSON `HICAMDGMEAH`

```json
{
  "AmplitudeKey": string
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `AmplitudeKey` | `string` | `KHJGACFJMEB` |

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF, HICAMDGMEAH DPBAECEJKMC) {
	if (!string.IsNullOrEmpty (DAKCKPMBKFF)) {
		Debug.LogError ("WebSocket" + DAKCKPMBKFF);
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, "OpusEncoder");
	} else {
		FDOMOOLJDIO (DPBAECEJKMC.JJNMJAPAFFA ());
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, null);
	}
}
```

</details>

---

## POST `api/gamesessions/v2/`

*first seen: 2017-09-02_00-25-13 — last seen: 2018-07-18_23-36-19 (18 builds)*

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `localProfileId not set!` | `string` |
| `http://j.mp/1FRAL5L` | `string` |
| `type` | `string` |

**Response:**

`200 OK` — JSON `JGJEOEMINLE`

```json
{
  "GlobalOverall": JDJMCFDIBED,
  "GlobalPeriodic": JDJMCFDIBED,
  "FriendsOverall": JDJMCFDIBED,
  "FriendsPeriodic": JDJMCFDIBED,
  "NextResetUTC": DateTime   // epoch ticks
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `GlobalOverall` | `JDJMCFDIBED` | `OMBHAENKKLC` |
| `GlobalPeriodic` | `JDJMCFDIBED` | `HMAPOIOBHJH` |
| `FriendsOverall` | `JDJMCFDIBED` | `IEECDDEEBMC` |
| `FriendsPeriodic` | `JDJMCFDIBED` | `ONPABGLKLFO` |
| `NextResetUTC` | `DateTime` | `PIBILFDNNGD` |

<details><summary>Client-side callback</summary>

```cs
JOINLHEALDL
```

</details>

---

## GET `api/gamesessions/v2/block`

*first seen: 2018-05-11_18-12-06 — last seen: 2018-08-10_22-16-20 (7 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/gamesessions/v2/block`

*first seen: 2017-10-31_21-37-38 — last seen: 2018-04-12_18-08-52 (7 builds)*

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
JOINLHEALDL
```

</details>

---

## GET `api/gamesessions/v2/create`

*first seen: 2018-05-11_18-12-06 — last seen: 2018-08-10_22-16-20 (7 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/gamesessions/v2/create`

*first seen: 2017-10-31_21-37-38 — last seen: 2018-04-12_18-08-52 (7 builds)*

**Request body:** application/json

**Response:**

`200 OK` — JSON `PEDNLMAHGBP+OHFDKOMCJPH` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
private static HEMCJJJMLKI.JMICPMCJMJF<OHFDKOMCJPH> MJMBNOEKJFG (string BHDHJEIHHJD, HEMCJJJMLKI.JMICPMCJMJF<OHFDKOMCJPH> JOINLHEALDL)
{
	return delegate(string DAKCKPMBKFF, OHFDKOMCJPH DKBBNNEBKMO) {
		if (!string.IsNullOrEmpty (DAKCKPMBKFF)) {
			Debug.LogErrorFormat ("RecNet game session join failed ({0}): {1}", BHDHJEIHHJD, DAKCKPMBKFF);
		} else if (DKBBNNEBKMO.DPLNNBKDDAH != MBMHAMAMPJO.Success) {
			Debug.LogWarningFormat ("RecNet game session join failed ({0}): {1}", BHDHJEIHHJD, DKBBNNEBKMO.DPLNNBKDDAH);
		} else {
			LNPBGKENDPK.AGMFAMBKBLP (DKBBNNEBKMO.EHLBEFKJLHJ);
		}
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, DKBBNNEBKMO);
	};
}
```

</details>

---

## GET `api/gamesessions/v2/join`

*first seen: 2018-05-11_18-12-06 — last seen: 2018-08-10_22-16-20 (7 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/gamesessions/v2/join`

*first seen: 2017-10-31_21-37-38 — last seen: 2018-04-12_18-08-52 (7 builds)*

**Request body:** application/json

**Response:**

`200 OK` — JSON `PEDNLMAHGBP+OHFDKOMCJPH` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
private static HEMCJJJMLKI.JMICPMCJMJF<OHFDKOMCJPH> MJMBNOEKJFG (string BHDHJEIHHJD, HEMCJJJMLKI.JMICPMCJMJF<OHFDKOMCJPH> JOINLHEALDL)
{
	return delegate(string DAKCKPMBKFF, OHFDKOMCJPH DKBBNNEBKMO) {
		if (!string.IsNullOrEmpty (DAKCKPMBKFF)) {
			Debug.LogErrorFormat ("RecNet game session join failed ({0}): {1}", BHDHJEIHHJD, DAKCKPMBKFF);
		} else if (DKBBNNEBKMO.DPLNNBKDDAH != MBMHAMAMPJO.Success) {
			Debug.LogWarningFormat ("RecNet game session join failed ({0}): {1}", BHDHJEIHHJD, DKBBNNEBKMO.DPLNNBKDDAH);
		} else {
			LNPBGKENDPK.AGMFAMBKBLP (DKBBNNEBKMO.EHLBEFKJLHJ);
		}
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, DKBBNNEBKMO);
	};
}
```

</details>

---

## GET `api/gamesessions/v2/joinevent`

*first seen: 2018-05-11_18-12-06 — last seen: 2018-08-10_22-16-20 (7 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/gamesessions/v2/joinevent`

*first seen: 2017-10-31_21-37-38 — last seen: 2018-04-12_18-08-52 (7 builds)*

**Request body:** application/json

**Response:**

`200 OK` — JSON `PEDNLMAHGBP+OHFDKOMCJPH` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
private static HEMCJJJMLKI.JMICPMCJMJF<OHFDKOMCJPH> MJMBNOEKJFG (string BHDHJEIHHJD, HEMCJJJMLKI.JMICPMCJMJF<OHFDKOMCJPH> JOINLHEALDL)
{
	return delegate(string DAKCKPMBKFF, OHFDKOMCJPH DKBBNNEBKMO) {
		if (!string.IsNullOrEmpty (DAKCKPMBKFF)) {
			Debug.LogErrorFormat ("RecNet game session join failed ({0}): {1}", BHDHJEIHHJD, DAKCKPMBKFF);
		} else if (DKBBNNEBKMO.DPLNNBKDDAH != MBMHAMAMPJO.Success) {
			Debug.LogWarningFormat ("RecNet game session join failed ({0}): {1}", BHDHJEIHHJD, DKBBNNEBKMO.DPLNNBKDDAH);
		} else {
			LNPBGKENDPK.AGMFAMBKBLP (DKBBNNEBKMO.EHLBEFKJLHJ);
		}
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, DKBBNNEBKMO);
	};
}
```

</details>

---

## GET `api/gamesessions/v2/joinplayer`

*first seen: 2018-05-11_18-12-06 — last seen: 2018-08-10_22-16-20 (7 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/gamesessions/v2/joinplayer`

*first seen: 2017-10-31_21-37-38 — last seen: 2018-04-12_18-08-52 (7 builds)*

**Request body:** application/json

**Response:**

`200 OK` — JSON `PEDNLMAHGBP+OHFDKOMCJPH` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
private static HEMCJJJMLKI.JMICPMCJMJF<OHFDKOMCJPH> MJMBNOEKJFG (string BHDHJEIHHJD, HEMCJJJMLKI.JMICPMCJMJF<OHFDKOMCJPH> JOINLHEALDL)
{
	return delegate(string DAKCKPMBKFF, OHFDKOMCJPH DKBBNNEBKMO) {
		if (!string.IsNullOrEmpty (DAKCKPMBKFF)) {
			Debug.LogErrorFormat ("RecNet game session join failed ({0}): {1}", BHDHJEIHHJD, DAKCKPMBKFF);
		} else if (DKBBNNEBKMO.DPLNNBKDDAH != MBMHAMAMPJO.Success) {
			Debug.LogWarningFormat ("RecNet game session join failed ({0}): {1}", BHDHJEIHHJD, DKBBNNEBKMO.DPLNNBKDDAH);
		} else {
			LNPBGKENDPK.AGMFAMBKBLP (DKBBNNEBKMO.EHLBEFKJLHJ);
		}
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, DKBBNNEBKMO);
	};
}
```

</details>

---

## GET `api/gamesessions/v2/joinrandom`

*first seen: 2018-05-11_18-12-06 — last seen: 2018-08-10_22-16-20 (7 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/gamesessions/v2/joinrandom`

*first seen: 2017-10-31_21-37-38 — last seen: 2018-04-12_18-08-52 (7 builds)*

**Request body:** application/json

**Response:**

`200 OK` — JSON `PEDNLMAHGBP+OHFDKOMCJPH` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
private static HEMCJJJMLKI.JMICPMCJMJF<OHFDKOMCJPH> MJMBNOEKJFG (string BHDHJEIHHJD, HEMCJJJMLKI.JMICPMCJMJF<OHFDKOMCJPH> JOINLHEALDL)
{
	return delegate(string DAKCKPMBKFF, OHFDKOMCJPH DKBBNNEBKMO) {
		if (!string.IsNullOrEmpty (DAKCKPMBKFF)) {
			Debug.LogErrorFormat ("RecNet game session join failed ({0}): {1}", BHDHJEIHHJD, DAKCKPMBKFF);
		} else if (DKBBNNEBKMO.DPLNNBKDDAH != MBMHAMAMPJO.Success) {
			Debug.LogWarningFormat ("RecNet game session join failed ({0}): {1}", BHDHJEIHHJD, DKBBNNEBKMO.DPLNNBKDDAH);
		} else {
			LNPBGKENDPK.AGMFAMBKBLP (DKBBNNEBKMO.EHLBEFKJLHJ);
		}
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, DKBBNNEBKMO);
	};
}
```

</details>

---

## GET `api/gamesessions/v2/joinroom`

*first seen: 2018-05-11_18-12-06 — last seen: 2018-08-10_22-16-20 (7 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/gamesessions/v2/joinroom`

*first seen: 2017-12-20_21-50-35 — last seen: 2018-04-12_18-08-52 (4 builds)*

**Request body:** application/json

**Response:**

`200 OK` — JSON `PEDNLMAHGBP+OHFDKOMCJPH` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
private static HEMCJJJMLKI.JMICPMCJMJF<OHFDKOMCJPH> MJMBNOEKJFG (string BHDHJEIHHJD, HEMCJJJMLKI.JMICPMCJMJF<OHFDKOMCJPH> JOINLHEALDL)
{
	return delegate(string DAKCKPMBKFF, OHFDKOMCJPH DKBBNNEBKMO) {
		if (!string.IsNullOrEmpty (DAKCKPMBKFF)) {
			Debug.LogErrorFormat ("RecNet game session join failed ({0}): {1}", BHDHJEIHHJD, DAKCKPMBKFF);
		} else if (DKBBNNEBKMO.DPLNNBKDDAH != MBMHAMAMPJO.Success) {
			Debug.LogWarningFormat ("RecNet game session join failed ({0}): {1}", BHDHJEIHHJD, DKBBNNEBKMO.DPLNNBKDDAH);
		} else {
			LNPBGKENDPK.AGMFAMBKBLP (DKBBNNEBKMO.EHLBEFKJLHJ);
		}
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, DKBBNNEBKMO);
	};
}
```

</details>

---

## POST `api/gamesessions/v2/joinroomcode`

*first seen: 2017-10-31_21-37-38 — last seen: 2017-11-30_23-39-18 (3 builds)*

**Request body:** application/json

**Response:**

`200 OK` — JSON `PEDNLMAHGBP+OHFDKOMCJPH` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
private static HEMCJJJMLKI.JMICPMCJMJF<OHFDKOMCJPH> MJMBNOEKJFG (string BHDHJEIHHJD, HEMCJJJMLKI.JMICPMCJMJF<OHFDKOMCJPH> JOINLHEALDL)
{
	return delegate(string DAKCKPMBKFF, OHFDKOMCJPH DKBBNNEBKMO) {
		if (!string.IsNullOrEmpty (DAKCKPMBKFF)) {
			Debug.LogErrorFormat ("RecNet game session join failed ({0}): {1}", BHDHJEIHHJD, DAKCKPMBKFF);
		} else if (DKBBNNEBKMO.DPLNNBKDDAH != MBMHAMAMPJO.Success) {
			Debug.LogWarningFormat ("RecNet game session join failed ({0}): {1}", BHDHJEIHHJD, DKBBNNEBKMO.DPLNNBKDDAH);
		} else {
			LNPBGKENDPK.AGMFAMBKBLP (DKBBNNEBKMO.EHLBEFKJLHJ);
		}
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, DKBBNNEBKMO);
	};
}
```

</details>

---

## POST `api/gamesessions/v2/listpublicevents`

*first seen: 2017-10-31_21-37-38 — last seen: 2017-11-30_23-39-18 (3 builds)*

**Request body:** System.Boolean

**Response:**

`200 OK` — JSON `EHLBEFKJLHJ`

```json
{
  "GameSessionId": long,
  "RegionId": string,
  "RoomId": string,
  "EventId": long?,
  "CreatorPlayerId": long?,
  "Name": string,
  "ActivityLevelId": string,
  "Private": bool,
  "GameInProgress": bool,
  "MaxCapacity": int,
  "IsFull": bool
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `GameSessionId` | `long` | `GPBHDHNNEBK` |
| `RegionId` | `string` | — |
| `RoomId` | `string` | `EDNBKCICCOC` |
| `EventId` | `long?` | `GBFAGGKLGKN` |
| `CreatorPlayerId` | `long?` | `EEDOGBONKHP` |
| `Name` | `string` | `GDIECAFDIMC` |
| `ActivityLevelId` | `string` | — |
| `Private` | `bool` | `BFBMOBHMMHI` |
| `GameInProgress` | `bool` | `GPPJMHAEABG` |
| `MaxCapacity` | `int` | `GCLLGNOEEFH` |
| `IsFull` | `bool` | `KMAFIMHNBOC` |

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF, List<EHLBEFKJLHJ> DKBBNNEBKMO) {
	if (string.IsNullOrEmpty (DAKCKPMBKFF)) {
		foreach (EHLBEFKJLHJ item in DKBBNNEBKMO) {
			ELKANNJMHDJ (item);
		}
	}
	HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, DKBBNNEBKMO);
}
```

</details>

---

## GET `api/gamesessions/v2/modify`

*first seen: 2018-05-11_18-12-06 — last seen: 2018-08-10_22-16-20 (7 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/gamesessions/v2/modify`

*first seen: 2017-10-31_21-37-38 — last seen: 2018-04-12_18-08-52 (7 builds)*

**Request body:** application/json

**Response:**

`200 OK` — JSON `EFDOILDKBFK`

```json
{
  "Success": bool,
  "Message": string
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `Success` | `bool` | `FOPNEFBADJB` |
| `Message` | `string` | `IMGPDLHMJEE` |

<details><summary>Client-side callback</summary>

```cs
JOINLHEALDL
```

</details>

---

## GET `api/gamesessions/v2/reportjoinresult`

*first seen: 2018-05-11_18-12-06 — last seen: 2018-08-10_22-16-20 (7 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/gamesessions/v2/reportjoinresult`

*first seen: 2017-10-31_21-37-38 — last seen: 2019-04-24_15-07-27 (12 builds)*

**Declared by:** `GameSessions.ReportGameJoinResult`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/gamesessions/v2/setinprogress`

*first seen: 2019-03-14_23-23-50 — last seen: 2019-04-24_15-07-27 (5 builds)*

**Declared by:** `GameSessions.SetGameInProgress`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/gamesessions/v2/v2/displayname`

*first seen: 2018-05-04_20-50-17 — last seen: 2018-05-04_20-50-17 (1 builds)*

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.` | `string` |
| `TrackingSpace` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF) {
	if (string.IsNullOrEmpty (DAKCKPMBKFF)) {
		JICEFBNKLHF.Remove (HEMCJJJMLKI.PLNKIILJKDA);
	} else {
		Debug.LogError ("GetPackageName" + DAKCKPMBKFF);
		DAKCKPMBKFF = "Id";
	}
	HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF);
}
```

</details>

---

