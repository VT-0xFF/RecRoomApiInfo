# Playerevents

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## GET `api/playerevents/v1/all`

*first seen: 2018-05-09_19-37-59 — last seen: 2021-08-06_06-02-59 (158 builds)*

**Declared by:** `PlayerEvents.DownloadPlayerEventList`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num2 != 0
```

</details>

---

## POST `api/playerevents/v1/all`

*first seen: 2018-04-27_18-51-13 — last seen: 2018-05-04_20-50-17 (4 builds)*

**Request body:** System.Boolean

**Response:**

`200 OK` — JSON `IEJNLOKMMKJ`

```json
{
  "Created": HNIHEBMNDFH,
  "Responses": KIKEJLCGMJG
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `Created` | `HNIHEBMNDFH` | `MAKBFBDFMMI` |
| `Responses` | `KIKEJLCGMJG` | `HDCCBBMDEKA` |

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF, IEJNLOKMMKJ KINJLJBFIPI) {
	if (string.IsNullOrEmpty (DAKCKPMBKFF)) {
		OPAGBNLKLHI = KINJLJBFIPI.NNGAJPGPGMP ();
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, null);
	} else {
		Debug.LogError ("Failed to download player event list: " + DAKCKPMBKFF);
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, "Failed to download player event list");
	}
}
```

</details>

---

## POST `api/playerevents/v1/bulkInvite`

*first seen: 2018-09-27_21-32-54 — last seen: 2021-08-06_06-02-59 (132 builds)*

**Declared by:** `PlayerEvents.InvitePlayers`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num4 != 0
```

</details>

---

## POST `api/playerevents/v1/deleteResponse`

*first seen: 2018-09-27_21-32-54 — last seen: 2021-08-06_06-02-59 (132 builds)*

**Declared by:** `PlayerEvents.DeleteResponse`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num3 != 0
```

</details>

---

## POST `api/playerevents/v1/report`

*first seen: 2018-09-27_21-32-54 — last seen: 2021-08-06_06-02-59 (132 builds)*

**Declared by:** `PlayerEvents.ReportEvent`

**Request body:** RecNet.PlayerEventReportRequest

**Response:**

`200 OK` — JSON `PlayerEventReportRequest` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
(byte)num4 != 0
```

</details>

---

## POST `api/playerevents/v1/respond`

*first seen: 2018-07-26_22-13-12 — last seen: 2021-08-06_06-02-59 (143 builds)*

**Declared by:** `PlayerEvents.RespondToEvent`

**Request body:** RecNet.PlayerEventResponseRequest

**Response:**

`200 OK` — JSON `PlayerEventResponseRequest` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
(byte)num5 != 0
```

</details>

---

## GET `api/playerevents/v1/{num}`

*first seen: 2018-07-26_22-13-12 — last seen: 2019-11-12_15-10-55 (72 builds)*

**Declared by:** `PlayerEvents.GetPlayerEventById`

**URI parameters:** `num`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num3 != 0
```

</details>

---

## POST `api/playerevents/v2`

*first seen: 2018-09-27_21-32-54 — last seen: 2021-08-06_06-02-59 (132 builds)*

**Declared by:** `PlayerEvents.CreateEvent`

**Request body:** RecNet.CreateModifyEventRequest

**Response:**

`200 OK` — JSON `CreateModifyEventRequest` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
(byte)num2 != 0
```

</details>

---

## POST `api/playerevents/v2/delete/{num4}`

*first seen: 2018-09-27_21-32-54 — last seen: 2021-08-06_06-02-59 (55 builds)*

**URI parameters:** `param`

**Request body:** form fields (Dictionary<string,string>)

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
OKBCAHBFJBL: false
```

</details>

---

## POST `api/playerevents/v2/{num2}`

*first seen: 2018-09-27_21-32-54 — last seen: 2021-08-06_06-02-59 (132 builds)*

**Declared by:** `PlayerEvents.ModifyEvent`

**URI parameters:** `num`

**Request body:** RecNet.CreateModifyEventRequest

**Response:**

`200 OK` — JSON `CreateModifyEventRequest` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
(byte)num4 != 0
```

</details>

---

