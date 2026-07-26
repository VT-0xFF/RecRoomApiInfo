# PlayerReporting

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## POST `api/PlayerReporting/v1/create`

*first seen: 2017-01-18_01-10-07 — last seen: 2017-09-11_18-46-16 (61 builds)*

**Declared by:** `PlayerReporting.CreateReport`

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `PlayerIdReported` | `string` |
| `ReportCategory` | `string` |
| `Activity` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
delegate(string wwwError) {
	if (!string.IsNullOrEmpty (wwwError)) {
		Debug.LogError ("Failed to report player" + wwwError);
		reportedPlayerIds.Remove (playerId);
	} else {
		AnalyticsHelper.ReportPlayer (playerId, reportCategory);
	}
}
```

</details>

---

## POST `api/PlayerReporting/v1/deviceId`

*first seen: 2020-07-17_03-00-52 — last seen: 2021-08-06_06-02-59 (46 builds)*

**Request body:** System.Collections.Generic.IEnumerable

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/PlayerReporting/v1/hile`

*first seen: 2018-09-27_21-32-54 — last seen: 2018-12-06_21-26-17 (14 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
dictionary
```

</details>

---

## POST `api/PlayerReporting/v1/hile`

*first seen: 2019-03-14_23-23-50 — last seen: 2021-08-06_06-02-59 (77 builds)*

**Declared by:** `PlayerReporting.CreateHileWarning`

**Request body:** BestHTTP.Forms.HTTPUrlEncodedForm

| Field | Type |
|-------|------|
| `Message` | `string` |
| `Type` | `string` |
| `ReportedPlayer` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num3 != 0
```

</details>

---

## POST `api/PlayerReporting/v1/instantKick`

*first seen: 2019-03-14_23-23-50 — last seen: 2021-08-06_06-02-59 (77 builds)*

**Declared by:** `PlayerReporting.InstantKickPlayer`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/PlayerReporting/v1/kickFromEvent`

*first seen: 2018-05-09_19-37-59 — last seen: 2018-12-06_21-26-17 (40 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
dictionary
```

</details>

---

## POST `api/PlayerReporting/v1/kickFromEvent`

*first seen: 2017-09-15_00-01-47 — last seen: 2018-05-04_20-50-17 (37 builds)*

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `PlayerId` | `string` |
| `ReportCategory` | `string` |
| `GameSessionId` | `string` |
| `Response` | `string` |

**Response:**

`200 OK` — JSON `EFDOILDKBFK`

```json
{
  "RpcAddControlPoint": bool,
  "Type": string
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `RpcAddControlPoint` | `bool` | — |
| `Type` | `string` | `IMGPDLHMJEE` |

<details><summary>Client-side callback</summary>

```cs
JOINLHEALDL
```

</details>

---

## GET `api/PlayerReporting/v1/moderationBlockDetails`

*first seen: 2017-09-15_00-01-47 — last seen: 2021-08-06_06-02-59 (154 builds)*

**Declared by:** `PlayerReporting.GetModerationBlockDetails`

**Response:**

`200 OK` — JSON `LNHNJOOAEPB`

```json
{
  "amount": int,   // enum HLAPBDKLDHG.PMEFEHPFOEJ
  "_placeholder": int,
  "PlatformId": long,
  "demoUint": string
}
```

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF, LNHNJOOAEPB DKBBNNEBKMO) {
	if (string.IsNullOrEmpty (DAKCKPMBKFF)) {
		NIHLDGLICJH = DKBBNNEBKMO;
	} else {
		Debug.LogError (DAKCKPMBKFF);
	}
	HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF);
}
```

</details>

---

## POST `api/PlayerReporting/v1/voteToKick`

*first seen: 2017-09-15_00-01-47 — last seen: 2018-01-18_01-17-10 (18 builds)*

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `PlayerId` | `string` |
| `ReportCategory` | `string` |
| `Response` | `string` |
| `GameSessionId` | `string` |

**Response:**

`200 OK` — JSON `EFDOILDKBFK`

```json
{
  "RpcAddControlPoint": bool,
  "Type": string
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `RpcAddControlPoint` | `bool` | — |
| `Type` | `string` | `IMGPDLHMJEE` |

<details><summary>Client-side callback</summary>

```cs
JOINLHEALDL
```

</details>

---

## GET `api/PlayerReporting/v1/voteToKickReasons`

*first seen: 2020-12-15_04-04-42 — last seen: 2021-08-06_06-02-59 (30 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num != 0
```

</details>

---

## POST `api/PlayerReporting/v2/create`

*first seen: 2017-09-15_00-01-47 — last seen: 2018-01-18_01-17-10 (18 builds)*

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `PlayerIdReported` | `string` |
| `ReportCategory` | `string` |
| `Activity` | `string` |
| `HeightReporter` | `string` |
| `HeightReported` | `string` |

**Response:**

`200 OK` — JSON `EFDOILDKBFK`

```json
{
  "MusicVolume": bool,
  "z": string
}
```

<details><summary>Client-side callback</summary>

```cs
JOINLHEALDL
```

</details>

---

## GET `api/PlayerReporting/v2/voteToKick`

*first seen: 2018-05-09_19-37-59 — last seen: 2018-12-06_21-26-17 (40 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
dictionary
```

</details>

---

## POST `api/PlayerReporting/v2/voteToKick`

*first seen: 2018-02-01_20-04-59 — last seen: 2019-04-24_15-07-27 (24 builds)*

**Declared by:** `PlayerReporting.VoteToKickPlayer`

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `PlayerId` | `string` |
| `Response` | `string` |
| `GameSessionId` | `string` |

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

## GET `api/PlayerReporting/v3/create`

*first seen: 2018-05-09_19-37-59 — last seen: 2018-12-06_21-26-17 (40 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
dictionary
```

</details>

---

## POST `api/PlayerReporting/v3/create`

*first seen: 2018-02-01_20-04-59 — last seen: 2018-05-04_20-50-17 (19 builds)*

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `PlayerIdReported` | `string` |
| `ReportCategory` | `string` |
| `Details` | `string` |
| `ActivityLevelId` | `string` |
| `HeightReporter` | `string` |
| `HeightReported` | `string` |
| `RoomId` | `string` |

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

## POST `api/PlayerReporting/v3/voteToKick`

*first seen: 2019-04-30_21-58-27 — last seen: 2021-08-06_06-02-59 (65 builds)*

**Declared by:** `PlayerReporting.VoteToKickPlayer`

**Request body:** System.Collections.Generic.IEnumerable

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

