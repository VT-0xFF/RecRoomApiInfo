# Events

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## POST `api/events/v1/list`

*first seen: 2017-07-11_00-44-03 — last seen: 2017-07-28_01-14-51 (6 builds)*

**Request body:** System.Boolean

**Response:**

`200 OK` — JSON `NDKILGAFGDP`

```json
{
  "EventId": ulong,
  "Name": string,
  "Description": string,
  "StartTime": DateTime,   // epoch ticks
  "EndTime": DateTime,   // epoch ticks
  "Activity": int,   // enum PGOPAPIFECA
  "ActivityLevel": int,   // enum KANCFPONEKJ
  "PosterImageName": string,
  "GameSessionId": string,
  "MaxPlayers": int?,
  "HostPlayerId": ulong?
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `EventId` | `ulong` | `GBFAGGKLGKN` |
| `Name` | `string` | `GDIECAFDIMC` |
| `Description` | `string` | `MJLCELIIAJF` |
| `StartTime` | `DateTime` | `PAPNOCOMOBF` |
| `EndTime` | `DateTime` | `GFFNBAPKENA` |
| `Activity` | `int` | `KAPOBAEMBKL` |
| `ActivityLevel` | `int` | `OOAECNOOFID` |
| `PosterImageName` | `string` | `DOPEGJNHIPC` |
| `GameSessionId` | `string` | `GPBHDHNNEBK` |
| `MaxPlayers` | `int?` | `NPKLJMCJBEH` |
| `HostPlayerId` | `ulong?` | `NFPCLNPOCGH` |

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF, List<NDKILGAFGDP> KINJLJBFIPI) {
	if (string.IsNullOrEmpty (DAKCKPMBKFF)) {
		OBKAAIKHHHP.Clear ();
		OBKAAIKHHHP.AddRange (KINJLJBFIPI);
		OBKAAIKHHHP.Sort ((NDKILGAFGDP FKOFGIJFIKA, NDKILGAFGDP GNNBOMAEBGK) => FKOFGIJFIKA.PAPNOCOMOBF.CompareTo (GNNBOMAEBGK.PAPNOCOMOBF));
		NDKILGAFGDP nDKILGAFGDP = NCNNAELLCMH ();
		if (nDKILGAFGDP != null) {
			EHGDGFBEMJF.OJLBMECODCF (nDKILGAFGDP.DOPEGJNHIPC);
		}
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, null);
	} else {
		UnityEngine.Debug.LogError ("Failed to download event list: " + DAKCKPMBKFF);
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, "Failed to download event list");
	}
}
```

</details>

---

## GET `api/events/v1/status/{param}`

*first seen: 2018-05-09_19-37-59 — last seen: 2019-06-28_13-58-34 (60 builds)*

**Declared by:** `Events.RefreshEventStatus`

**URI parameters:** `eventId`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num2 != 0
```

</details>

---

## POST `api/events/v1/status/{param}`

*first seen: 2017-09-01_01-07-05 — last seen: 2018-05-04_20-50-17 (40 builds)*

**URI parameters:** `param`

**Request body:** System.Boolean

**Response:**

`200 OK` — JSON `ECMDPOAMDGE+MOODMNCIEHL` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF, MOODMNCIEHL DKBBNNEBKMO) {
	if (!string.IsNullOrEmpty (DAKCKPMBKFF)) {
		Debug.LogError ("Unable to get event status: " + DAKCKPMBKFF);
		PEOMCELCFDA.EMABBOFHCEP = AGKDJJFKDPL.Unknown;
	} else {
		PEOMCELCFDA.EMABBOFHCEP = DKBBNNEBKMO.EMABBOFHCEP;
	}
}
```

</details>

---

## POST `api/events/v2/list`

*first seen: 2017-08-04_00-54-25 — last seen: 2017-08-22_22-54-30 (6 builds)*

**Request body:** System.Boolean

**Response:**

`200 OK` — JSON `NDKILGAFGDP`

```json
{
  "EventId": ulong,
  "Name": string,
  "Description": string,
  "StartTime": DateTime,   // epoch ticks
  "EndTime": DateTime,   // epoch ticks
  "Activity": int,   // enum PGOPAPIFECA
  "ActivityLevel": int,   // enum KANCFPONEKJ
  "PosterImageName": string,
  "GameSessionId": string,
  "MaxPlayers": int?,
  "CreatorPlayerId": ulong?
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `EventId` | `ulong` | `GBFAGGKLGKN` |
| `Name` | `string` | `GDIECAFDIMC` |
| `Description` | `string` | `MJLCELIIAJF` |
| `StartTime` | `DateTime` | `PAPNOCOMOBF` |
| `EndTime` | `DateTime` | `GFFNBAPKENA` |
| `Activity` | `int` | `KAPOBAEMBKL` |
| `ActivityLevel` | `int` | `OOAECNOOFID` |
| `PosterImageName` | `string` | `DOPEGJNHIPC` |
| `GameSessionId` | `string` | `GPBHDHNNEBK` |
| `MaxPlayers` | `int?` | `NPKLJMCJBEH` |
| `CreatorPlayerId` | `ulong?` | `EEDOGBONKHP` |

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF, List<NDKILGAFGDP> KINJLJBFIPI) {
	if (string.IsNullOrEmpty (DAKCKPMBKFF)) {
		OBKAAIKHHHP.Clear ();
		OBKAAIKHHHP.AddRange (KINJLJBFIPI);
		OBKAAIKHHHP.Sort ((NDKILGAFGDP FKOFGIJFIKA, NDKILGAFGDP GNNBOMAEBGK) => FKOFGIJFIKA.PAPNOCOMOBF.CompareTo (GNNBOMAEBGK.PAPNOCOMOBF));
		NDKILGAFGDP nDKILGAFGDP = NCNNAELLCMH ();
		if (nDKILGAFGDP != null) {
			EHGDGFBEMJF.OJLBMECODCF (nDKILGAFGDP.DOPEGJNHIPC);
		}
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, null);
	} else {
		UnityEngine.Debug.LogError ("Failed to download event list: " + DAKCKPMBKFF);
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, "Failed to download event list");
	}
}
```

</details>

---

## GET `api/events/v3/list`

*first seen: 2018-05-09_19-37-59 — last seen: 2019-06-28_13-58-34 (60 builds)*

**Declared by:** `Events.RefreshEventList`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num4 != 0
```

</details>

---

## POST `api/events/v3/list`

*first seen: 2017-09-01_01-07-05 — last seen: 2018-05-04_20-50-17 (40 builds)*

**Request body:** System.Boolean

**Response:**

`200 OK` — JSON `NDKILGAFGDP`

```json
{
  "EventId": ulong,
  "Name": string,
  "Description": string,
  "StartTime": DateTime,   // epoch ticks
  "EndTime": DateTime,   // epoch ticks
  "PosterImageName": string,
  "CreatorPlayerId": ulong?
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `EventId` | `ulong` | `GBFAGGKLGKN` |
| `Name` | `string` | `GDIECAFDIMC` |
| `Description` | `string` | `MJLCELIIAJF` |
| `StartTime` | `DateTime` | `PAPNOCOMOBF` |
| `EndTime` | `DateTime` | `GFFNBAPKENA` |
| `PosterImageName` | `string` | `DOPEGJNHIPC` |
| `CreatorPlayerId` | `ulong?` | `EEDOGBONKHP` |

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF, List<NDKILGAFGDP> KINJLJBFIPI) {
	if (string.IsNullOrEmpty (DAKCKPMBKFF)) {
		OBKAAIKHHHP.Clear ();
		OBKAAIKHHHP.AddRange (KINJLJBFIPI);
		OBKAAIKHHHP.Sort ((NDKILGAFGDP FKOFGIJFIKA, NDKILGAFGDP GNNBOMAEBGK) => FKOFGIJFIKA.PAPNOCOMOBF.CompareTo (GNNBOMAEBGK.PAPNOCOMOBF));
		NDKILGAFGDP nDKILGAFGDP = NCNNAELLCMH ();
		if (nDKILGAFGDP != null) {
			EHGDGFBEMJF.OJLBMECODCF (nDKILGAFGDP.DOPEGJNHIPC);
		}
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, null);
	} else {
		Debug.LogError ("Failed to download event list: " + DAKCKPMBKFF);
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, "Failed to download event list");
	}
}
```

</details>

---

