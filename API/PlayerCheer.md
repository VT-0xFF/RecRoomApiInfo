# PlayerCheer

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## GET `api/PlayerCheer/v1/SetSelectedCheer`

*first seen: 2018-05-09_19-37-59 — last seen: 2018-12-06_21-26-17 (40 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
dictionary
```

</details>

---

## POST `api/PlayerCheer/v1/SetSelectedCheer`

*first seen: 2017-10-27_20-21-58 — last seen: 2021-08-06_06-02-59 (151 builds)*

**Declared by:** `PlayerCheering.UpdateSelectedCheer`

**Request body:** form fields (Dictionary<string,string>)

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/PlayerCheer/v1/create`

*first seen: 2018-05-09_19-37-59 — last seen: 2018-12-06_21-26-17 (40 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
dictionary
```

</details>

---

## POST `api/PlayerCheer/v1/create`

*first seen: 2017-10-27_20-21-58 — last seen: 2018-05-04_20-50-17 (31 builds)*

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `PlayerIdTo` | `string` |
| `CheerCategory` | `string` |
| `ActivityLevelId` | `string` |
| `Anonymous` | `string` |

**Response:**

`200 OK` — JSON `EFDOILDKBFK`

```json
{
  "icon": bool,
  "_Dirt_Add": string
}
```

<details><summary>Client-side callback</summary>

```cs
JOINLHEALDL
```

</details>

---

## GET `api/PlayerCheer/v1/removehost`

*first seen: 2018-02-16_22-16-39 — last seen: 2018-02-21_23-13-28 (2 builds)*

**Response:**

`200 OK` — JSON `LNHNJOOAEPB`

```json
{
  "ReportCategory": int,   // enum HLAPBDKLDHG.PMEFEHPFOEJ
  "Duration": int,
  "GameSessionId": long,
  "Message": string
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `ReportCategory` | `int` | `PMEFEHPFOEJ` |
| `Duration` | `int` | `KBKLOFPFPBD` |
| `GameSessionId` | `long` | `GPBHDHNNEBK` |
| `Message` | `string` | `IMGPDLHMJEE` |

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

