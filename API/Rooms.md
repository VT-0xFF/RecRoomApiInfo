# Rooms

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## POST `api/rooms/v1/addcoowner`

*first seen: 2018-01-12_22-13-25 — last seen: 2018-04-05_19-22-43 (15 builds)*

**Request body:** application/json

**Response:**

`200 OK` — JSON `HNIFBBFIBBG+IPGOHMDDGFL` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
JOINLHEALDL
```

</details>

---

## POST `api/rooms/v1/addhost`

*first seen: 2018-01-12_22-13-25 — last seen: 2018-04-05_19-22-43 (15 builds)*

**Request body:** application/json

**Response:**

`200 OK` — JSON `HNIFBBFIBBG+IPGOHMDDGFL` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
JOINLHEALDL
```

</details>

---

## GET `api/rooms/v1/bookmark`

*first seen: 2018-06-21_00-30-05 — last seen: 2018-12-06_21-26-17 (21 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/rooms/v1/bookmark`

*first seen: 2018-02-01_20-04-59 — last seen: 2019-02-14_22-55-35 (21 builds)*

**Declared by:** `Rooms.BookmarkRoom`

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
delegate(string DAKCKPMBKFF, EFDOILDKBFK DKBBNNEBKMO) {
	if (string.IsNullOrEmpty (DAKCKPMBKFF) && DKBBNNEBKMO.FOPNEFBADJB) {
		if (FIIFPLCNFHJ.DODDIDKODJL != null) {
			FIIFPLCNFHJ.DODDIDKODJL.MKFNFBAIGOE = OGOJHCPHDAL;
		}
		AJKDGODCOIM ();
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, DKBBNNEBKMO);
	}
}
```

</details>

---

## POST `api/rooms/v1/browse`

*first seen: 2018-01-12_22-13-25 — last seen: 2018-02-21_23-13-28 (7 builds)*

**Request body:** application/json

**Response:**

`200 OK` — JSON `PLOPPLAOICD`

```json
{
  "RoomId": long,
  "Name": string,
  "Description": string,
  "CreatorPlayerId": int,
  "ImageName": string,
  "DataBlobName": string,
  "ActivityLevelId": string,
  "IsSandbox": bool,
  "Instanced": bool,
  "MaxPlayers": int,
  "FeaturedOrder": int,
  "Accessibility": int,   // enum MJHMLOAMKCH
  "VisitorCount": int,
  "CheerCount": int,
  "ReportCount": int,
  "State": int,   // enum JECCIECOEID
  "StateModifiedAt": DateTime,   // epoch ticks
  "CreatedAt": DateTime,   // epoch ticks
  "ModifiedAt": DateTime,   // epoch ticks
  "LastVisitedAt": DateTime,   // epoch ticks
  "CoOwners": int,
  "Hosts": int,
  "PersonalDetails": GIJAOPNONJL
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `RoomId` | `long` | `EDNBKCICCOC` |
| `Name` | `string` | `GDIECAFDIMC` |
| `Description` | `string` | `MJLCELIIAJF` |
| `CreatorPlayerId` | `int` | `EEDOGBONKHP` |
| `ImageName` | `string` | `GAKPGOHFAHD` |
| `DataBlobName` | `string` | `OCDDOBNGFEF` |
| `ActivityLevelId` | `string` | — |
| `IsSandbox` | `bool` | `ACKCOLJODJB` |
| `Instanced` | `bool` | `JMEGODHEJDI` |
| `MaxPlayers` | `int` | `NPKLJMCJBEH` |
| `FeaturedOrder` | `int` | `GPODNKJFHJA` |
| `Accessibility` | `int` | `DOFCAKGHLMI` |
| `VisitorCount` | `int` | `EGJFKIDMGGP` |
| `CheerCount` | `int` | `BJDMPOGAGNB` |
| `ReportCount` | `int` | `CFEJLFFLJMJ` |
| `State` | `int` | `FBBMOMHACLA` |
| `StateModifiedAt` | `DateTime` | `GICBDENAPEG` |
| `CreatedAt` | `DateTime` | `OCNHFBMLPIC` |
| `ModifiedAt` | `DateTime` | `HFIOGLMCJGL` |
| `LastVisitedAt` | `DateTime` | `DGPKDEHOLIJ` |
| `CoOwners` | `int` | `LNJJLNJCCHK` |
| `Hosts` | `int` | `MGBCHDKPAJO` |
| `PersonalDetails` | `GIJAOPNONJL` | `DODDIDKODJL` |

<details><summary>Client-side callback</summary>

```cs
private static HEMCJJJMLKI.JMICPMCJMJF<List<PLOPPLAOICD>> PGJHJBCDJPO (HEMCJJJMLKI.JMICPMCJMJF<List<PLOPPLAOICD>> JOINLHEALDL)
{
	return delegate(string DAKCKPMBKFF, List<PLOPPLAOICD> DBONFHMCEGM) {
		if (string.IsNullOrEmpty (DAKCKPMBKFF)) {
			PMHJGBCLLII (DBONFHMCEGM);
		}
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, DBONFHMCEGM);
	};
}
```

</details>

---

## GET `api/rooms/v1/cheer`

*first seen: 2018-06-21_00-30-05 — last seen: 2018-12-06_21-26-17 (21 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/rooms/v1/cheer`

*first seen: 2017-12-15_01-29-10 — last seen: 2019-02-14_22-55-35 (25 builds)*

**Declared by:** `Rooms.CheerRoom`

**Request body:** application/json

**Response:**

`200 OK` — JSON `EFDOILDKBFK`

```json
{
  "RpcAuthorityDestroyEquipment": bool,
  "price": string
}
```

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF, EFDOILDKBFK DKBBNNEBKMO) {
	if (string.IsNullOrEmpty (DAKCKPMBKFF) && DKBBNNEBKMO.FOPNEFBADJB) {
		if (FIIFPLCNFHJ.DODDIDKODJL != null) {
			FIIFPLCNFHJ.DODDIDKODJL.NGGOBPHDDBP = PMDDJIDNJKF;
		}
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, DKBBNNEBKMO);
	}
}
```

</details>

---

## GET `api/rooms/v1/clone`

*first seen: 2018-06-21_00-30-05 — last seen: 2018-12-06_21-26-17 (21 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/rooms/v1/clone`

*first seen: 2018-03-01_20-14-27 — last seen: 2019-02-14_22-55-35 (16 builds)*

**Declared by:** `Rooms.CloneRoom`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/rooms/v1/datahistory/restore`

*first seen: 2018-06-21_00-30-05 — last seen: 2018-12-06_21-26-17 (21 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/rooms/v1/datahistory/restore`

*first seen: 2018-03-01_20-14-27 — last seen: 2019-02-14_22-55-35 (16 builds)*

**Declared by:** `Rooms.RestoreToRoomDataHistory`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/rooms/v1/datahistory/{param}`

*first seen: 2018-06-21_00-30-05 — last seen: 2018-12-06_21-26-17 (21 builds)*

**URI parameters:** `param`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
HEGFLJKILKM: false
```

</details>

---

## POST `api/rooms/v1/datahistory/{param}`

*first seen: 2018-03-01_20-14-27 — last seen: 2018-04-05_19-22-43 (8 builds)*

**URI parameters:** `param`

**Request body:** System.Boolean

**Response:**

`200 OK` — JSON `HNIFBBFIBBG+LFHKEAHEJNN` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
JOINLHEALDL
```

</details>

---

## POST `api/rooms/v1/details/{param}`

*first seen: 2018-01-12_22-13-25 — last seen: 2018-02-02_20-35-48 (4 builds)*

**URI parameters:** `param`

**Request body:** System.Boolean

**Response:**

`200 OK` — JSON `PFMOEEDCNBK`

```json
{
  "SOCCER_TIMER": int
}
```

<details><summary>Client-side callback</summary>

```cs
JOINLHEALDL
```

</details>

---

## POST `api/rooms/v1/featured`

*first seen: 2018-02-01_20-04-59 — last seen: 2018-04-05_19-22-43 (13 builds)*

**Request body:** System.Boolean

**Response:**

`200 OK` — JSON `PLOPPLAOICD`

```json
{
  "RoomId": long,
  "Name": string,
  "Description": string,
  "CreatorPlayerId": int,
  "ImageName": string,
  "DataBlobName": string,
  "ActivityLevelId": string,
  "IsSandbox": bool,
  "Instanced": bool,
  "MaxPlayers": int,
  "FeaturedOrder": int,
  "Accessibility": int,   // enum MJHMLOAMKCH
  "AccessibilityLocked": bool,
  "VisitorCount": int,
  "CheerCount": int,
  "ReportCount": int,
  "State": int,   // enum JECCIECOEID
  "StateModifiedAt": DateTime,   // epoch ticks
  "CreatedAt": DateTime,   // epoch ticks
  "ModifiedAt": DateTime,   // epoch ticks
  "LastVisitedAt": DateTime,   // epoch ticks
  "CoOwners": int,
  "Hosts": int,
  "PersonalDetails": GIJAOPNONJL
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `RoomId` | `long` | `EDNBKCICCOC` |
| `Name` | `string` | `GDIECAFDIMC` |
| `Description` | `string` | `MJLCELIIAJF` |
| `CreatorPlayerId` | `int` | `EEDOGBONKHP` |
| `ImageName` | `string` | `GAKPGOHFAHD` |
| `DataBlobName` | `string` | `OCDDOBNGFEF` |
| `ActivityLevelId` | `string` | — |
| `IsSandbox` | `bool` | `ACKCOLJODJB` |
| `Instanced` | `bool` | `JMEGODHEJDI` |
| `MaxPlayers` | `int` | `NPKLJMCJBEH` |
| `FeaturedOrder` | `int` | `GPODNKJFHJA` |
| `Accessibility` | `int` | `DOFCAKGHLMI` |
| `AccessibilityLocked` | `bool` | `GFGMFJNKLDO` |
| `VisitorCount` | `int` | `EGJFKIDMGGP` |
| `CheerCount` | `int` | `BJDMPOGAGNB` |
| `ReportCount` | `int` | `CFEJLFFLJMJ` |
| `State` | `int` | `FBBMOMHACLA` |
| `StateModifiedAt` | `DateTime` | `GICBDENAPEG` |
| `CreatedAt` | `DateTime` | `OCNHFBMLPIC` |
| `ModifiedAt` | `DateTime` | `HFIOGLMCJGL` |
| `LastVisitedAt` | `DateTime` | `DGPKDEHOLIJ` |
| `CoOwners` | `int` | `LNJJLNJCCHK` |
| `Hosts` | `int` | `MGBCHDKPAJO` |
| `PersonalDetails` | `GIJAOPNONJL` | `DODDIDKODJL` |

<details><summary>Client-side callback</summary>

```cs
private static HEMCJJJMLKI.JMICPMCJMJF<List<PLOPPLAOICD>> PGJHJBCDJPO (HEMCJJJMLKI.JMICPMCJMJF<List<PLOPPLAOICD>> JOINLHEALDL)
{
	return delegate(string DAKCKPMBKFF, List<PLOPPLAOICD> DBONFHMCEGM) {
		if (string.IsNullOrEmpty (DAKCKPMBKFF)) {
			PMHJGBCLLII (DBONFHMCEGM);
		}
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, DBONFHMCEGM);
	};
}
```

</details>

---

## GET `api/rooms/v1/featuredRoomGroup`

*first seen: 2018-12-14_19-12-52 — last seen: 2019-02-14_22-55-35 (8 builds)*

**Declared by:** `Rooms.GetCurrentFeaturedRoomGroup`

**Response:**

`200 OK` — JSON `Rooms+FeaturedRoomGroupDTO` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
(byte)num3 != 0
```

</details>

---

## POST `api/rooms/v1/featuredRoomGroup`

*first seen: 2018-08-28_16-00-26 — last seen: 2018-12-06_21-26-17 (19 builds)*

**Request body:** System.TimeSpan

**Response:**

`200 OK` — JSON `HNIFBBFIBBG+PMIJNIFAHDI` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
HEGFLJKILKM: false
```

</details>

---

## GET `api/rooms/v1/filters`

*first seen: 2018-12-14_19-12-52 — last seen: 2019-02-14_22-55-35 (8 builds)*

**Declared by:** `Rooms.GetTags`

**Response:**

`200 OK` — JSON `Rooms+GetFiltersResponse` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
(byte)num3 != 0
```

</details>

---

## POST `api/rooms/v1/filters`

*first seen: 2018-08-28_16-00-26 — last seen: 2018-12-06_21-26-17 (19 builds)*

**Request body:** System.TimeSpan

**Response:**

`200 OK` — JSON `HNIFBBFIBBG+EBLADHBEKIE` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
HEGFLJKILKM: false
```

</details>

---

## POST `api/rooms/v1/modify/accessibility`

*first seen: 2018-01-12_22-13-25 — last seen: 2018-04-05_19-22-43 (15 builds)*

**Request body:** application/json

**Response:**

`200 OK` — JSON `HNIFBBFIBBG+DELNGKJFONK` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
private static HEMCJJJMLKI.JMICPMCJMJF<DELNGKJFONK> FGECDLDEFIE (string BHDHJEIHHJD, HEMCJJJMLKI.JMICPMCJMJF<DELNGKJFONK> JOINLHEALDL)
{
	return delegate(string DAKCKPMBKFF, DELNGKJFONK DKBBNNEBKMO) {
		if (!string.IsNullOrEmpty (DAKCKPMBKFF)) {
			Debug.LogErrorFormat ("RecNet room modify failed ({0}): {1}", BHDHJEIHHJD, DAKCKPMBKFF);
		} else if (DKBBNNEBKMO.DPLNNBKDDAH != BOFMNGCCLNF.Success) {
			Debug.LogWarningFormat ("RecNet room modify failed ({0}): {1}", BHDHJEIHHJD, DKBBNNEBKMO.DPLNNBKDDAH);
		} else {
			MLOMMKCHAND (DKBBNNEBKMO.PLOPPLAOICD);
		}
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, DKBBNNEBKMO);
	};
}
```

</details>

---

## POST `api/rooms/v1/modify/description`

*first seen: 2017-12-15_01-29-10 — last seen: 2018-04-05_19-22-43 (17 builds)*

**Request body:** application/json

**Response:**

`200 OK` — JSON `HNIFBBFIBBG+DELNGKJFONK` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
private static HEMCJJJMLKI.JMICPMCJMJF<DELNGKJFONK> FGECDLDEFIE (string BHDHJEIHHJD, HEMCJJJMLKI.JMICPMCJMJF<DELNGKJFONK> JOINLHEALDL)
{
	return delegate(string DAKCKPMBKFF, DELNGKJFONK DKBBNNEBKMO) {
		if (!string.IsNullOrEmpty (DAKCKPMBKFF)) {
			Debug.LogErrorFormat ("RecNet room modify failed ({0}): {1}", BHDHJEIHHJD, DAKCKPMBKFF);
		} else if (DKBBNNEBKMO.DPLNNBKDDAH != BOFMNGCCLNF.Success) {
			Debug.LogWarningFormat ("RecNet room modify failed ({0}): {1}", BHDHJEIHHJD, DKBBNNEBKMO.DPLNNBKDDAH);
		} else {
			MLOMMKCHAND (DKBBNNEBKMO.PLOPPLAOICD);
		}
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, DKBBNNEBKMO);
	};
}
```

</details>

---

## POST `api/rooms/v1/modify/imagename`

*first seen: 2018-02-01_20-04-59 — last seen: 2018-04-05_19-22-43 (13 builds)*

**Request body:** application/json

**Response:**

`200 OK` — JSON `HNIFBBFIBBG+DELNGKJFONK` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
private static HEMCJJJMLKI.JMICPMCJMJF<DELNGKJFONK> FGECDLDEFIE (string BHDHJEIHHJD, HEMCJJJMLKI.JMICPMCJMJF<DELNGKJFONK> JOINLHEALDL)
{
	return delegate(string DAKCKPMBKFF, DELNGKJFONK DKBBNNEBKMO) {
		if (!string.IsNullOrEmpty (DAKCKPMBKFF)) {
			Debug.LogErrorFormat ("RecNet room modify failed ({0}): {1}", BHDHJEIHHJD, DAKCKPMBKFF);
		} else if (DKBBNNEBKMO.DPLNNBKDDAH != BOFMNGCCLNF.Success) {
			Debug.LogWarningFormat ("RecNet room modify failed ({0}): {1}", BHDHJEIHHJD, DKBBNNEBKMO.DPLNNBKDDAH);
		} else {
			MLOMMKCHAND (DKBBNNEBKMO.PLOPPLAOICD);
		}
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, DKBBNNEBKMO);
	};
}
```

</details>

---

## POST `api/rooms/v1/modify/instanced`

*first seen: 2018-02-15_18-48-13 — last seen: 2018-04-05_19-22-43 (11 builds)*

**Request body:** application/json

**Response:**

`200 OK` — JSON `HNIFBBFIBBG+DELNGKJFONK` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
private static HEMCJJJMLKI.JMICPMCJMJF<DELNGKJFONK> FGECDLDEFIE (string BHDHJEIHHJD, HEMCJJJMLKI.JMICPMCJMJF<DELNGKJFONK> JOINLHEALDL)
{
	return delegate(string DAKCKPMBKFF, DELNGKJFONK DKBBNNEBKMO) {
		if (!string.IsNullOrEmpty (DAKCKPMBKFF)) {
			Debug.LogErrorFormat ("RecNet room modify failed ({0}): {1}", BHDHJEIHHJD, DAKCKPMBKFF);
		} else if (DKBBNNEBKMO.DPLNNBKDDAH != BOFMNGCCLNF.Success) {
			Debug.LogWarningFormat ("RecNet room modify failed ({0}): {1}", BHDHJEIHHJD, DKBBNNEBKMO.DPLNNBKDDAH);
		} else {
			MLOMMKCHAND (DKBBNNEBKMO.PLOPPLAOICD);
		}
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, DKBBNNEBKMO);
	};
}
```

</details>

---

## POST `api/rooms/v1/modify/maxplayers`

*first seen: 2017-12-15_01-29-10 — last seen: 2018-04-05_19-22-43 (17 builds)*

**Request body:** application/json

**Response:**

`200 OK` — JSON `HNIFBBFIBBG+DELNGKJFONK` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
private static HEMCJJJMLKI.JMICPMCJMJF<DELNGKJFONK> FGECDLDEFIE (string BHDHJEIHHJD, HEMCJJJMLKI.JMICPMCJMJF<DELNGKJFONK> JOINLHEALDL)
{
	return delegate(string DAKCKPMBKFF, DELNGKJFONK DKBBNNEBKMO) {
		if (!string.IsNullOrEmpty (DAKCKPMBKFF)) {
			Debug.LogErrorFormat ("RecNet room modify failed ({0}): {1}", BHDHJEIHHJD, DAKCKPMBKFF);
		} else if (DKBBNNEBKMO.DPLNNBKDDAH != BOFMNGCCLNF.Success) {
			Debug.LogWarningFormat ("RecNet room modify failed ({0}): {1}", BHDHJEIHHJD, DKBBNNEBKMO.DPLNNBKDDAH);
		} else {
			MLOMMKCHAND (DKBBNNEBKMO.PLOPPLAOICD);
		}
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, DKBBNNEBKMO);
	};
}
```

</details>

---

## POST `api/rooms/v1/modify/name`

*first seen: 2017-12-15_01-29-10 — last seen: 2018-04-05_19-22-43 (17 builds)*

**Request body:** application/json

**Response:**

`200 OK` — JSON `HNIFBBFIBBG+DELNGKJFONK` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
private static HEMCJJJMLKI.JMICPMCJMJF<DELNGKJFONK> FGECDLDEFIE (string BHDHJEIHHJD, HEMCJJJMLKI.JMICPMCJMJF<DELNGKJFONK> JOINLHEALDL)
{
	return delegate(string DAKCKPMBKFF, DELNGKJFONK DKBBNNEBKMO) {
		if (!string.IsNullOrEmpty (DAKCKPMBKFF)) {
			Debug.LogErrorFormat ("RecNet room modify failed ({0}): {1}", BHDHJEIHHJD, DAKCKPMBKFF);
		} else if (DKBBNNEBKMO.DPLNNBKDDAH != BOFMNGCCLNF.Success) {
			Debug.LogWarningFormat ("RecNet room modify failed ({0}): {1}", BHDHJEIHHJD, DKBBNNEBKMO.DPLNNBKDDAH);
		} else {
			MLOMMKCHAND (DKBBNNEBKMO.PLOPPLAOICD);
		}
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, DKBBNNEBKMO);
	};
}
```

</details>

---

## GET `api/rooms/v1/modify/sceneParent`

*first seen: 2018-08-28_16-00-26 — last seen: 2018-12-06_21-26-17 (19 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/rooms/v1/modify/sceneParent`

*first seen: 2018-12-14_19-12-52 — last seen: 2019-02-14_22-55-35 (8 builds)*

**Declared by:** `Rooms.ModifySceneParent`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num9 != 0
```

</details>

---

## GET `api/rooms/v1/modify/tags`

*first seen: 2018-08-28_16-00-26 — last seen: 2018-12-06_21-26-17 (19 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/rooms/v1/modify/tags`

*first seen: 2018-12-14_19-12-52 — last seen: 2019-02-14_22-55-35 (8 builds)*

**Declared by:** `Rooms.ModifyRoomTags`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num10 != 0
```

</details>

---

## GET `api/rooms/v1/modifyPermissions`

*first seen: 2018-06-21_00-30-05 — last seen: 2018-10-25_22-07-23 (14 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## GET `api/rooms/v1/modifyscene`

*first seen: 2018-08-28_16-00-26 — last seen: 2018-12-06_21-26-17 (19 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/rooms/v1/modifyscene`

*first seen: 2018-12-14_19-12-52 — last seen: 2019-02-14_22-55-35 (8 builds)*

**Declared by:** `Rooms.ModifyRoomScene`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/rooms/v1/mybookmarkedrooms`

*first seen: 2018-02-01_20-04-59 — last seen: 2018-04-05_19-22-43 (13 builds)*

**Request body:** System.Boolean

**Response:**

`200 OK` — JSON `PLOPPLAOICD`

```json
{
  "RoomId": long,
  "Name": string,
  "Description": string,
  "CreatorPlayerId": int,
  "ImageName": string,
  "DataBlobName": string,
  "ActivityLevelId": string,
  "IsSandbox": bool,
  "Instanced": bool,
  "MaxPlayers": int,
  "FeaturedOrder": int,
  "Accessibility": int,   // enum MJHMLOAMKCH
  "AccessibilityLocked": bool,
  "VisitorCount": int,
  "CheerCount": int,
  "ReportCount": int,
  "State": int,   // enum JECCIECOEID
  "StateModifiedAt": DateTime,   // epoch ticks
  "CreatedAt": DateTime,   // epoch ticks
  "ModifiedAt": DateTime,   // epoch ticks
  "LastVisitedAt": DateTime,   // epoch ticks
  "CoOwners": int,
  "Hosts": int,
  "PersonalDetails": GIJAOPNONJL
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `RoomId` | `long` | `EDNBKCICCOC` |
| `Name` | `string` | `GDIECAFDIMC` |
| `Description` | `string` | `MJLCELIIAJF` |
| `CreatorPlayerId` | `int` | `EEDOGBONKHP` |
| `ImageName` | `string` | `GAKPGOHFAHD` |
| `DataBlobName` | `string` | `OCDDOBNGFEF` |
| `ActivityLevelId` | `string` | — |
| `IsSandbox` | `bool` | `ACKCOLJODJB` |
| `Instanced` | `bool` | `JMEGODHEJDI` |
| `MaxPlayers` | `int` | `NPKLJMCJBEH` |
| `FeaturedOrder` | `int` | `GPODNKJFHJA` |
| `Accessibility` | `int` | `DOFCAKGHLMI` |
| `AccessibilityLocked` | `bool` | `GFGMFJNKLDO` |
| `VisitorCount` | `int` | `EGJFKIDMGGP` |
| `CheerCount` | `int` | `BJDMPOGAGNB` |
| `ReportCount` | `int` | `CFEJLFFLJMJ` |
| `State` | `int` | `FBBMOMHACLA` |
| `StateModifiedAt` | `DateTime` | `GICBDENAPEG` |
| `CreatedAt` | `DateTime` | `OCNHFBMLPIC` |
| `ModifiedAt` | `DateTime` | `HFIOGLMCJGL` |
| `LastVisitedAt` | `DateTime` | `DGPKDEHOLIJ` |
| `CoOwners` | `int` | `LNJJLNJCCHK` |
| `Hosts` | `int` | `MGBCHDKPAJO` |
| `PersonalDetails` | `GIJAOPNONJL` | `DODDIDKODJL` |

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF, List<PLOPPLAOICD> DBONFHMCEGM) {
	if (string.IsNullOrEmpty (DAKCKPMBKFF)) {
		PMHJGBCLLII (DBONFHMCEGM);
	}
	AJKDGODCOIM ();
	HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, DBONFHMCEGM);
}
```

</details>

---

## POST `api/rooms/v1/myrooms`

*first seen: 2017-12-15_01-29-10 — last seen: 2018-04-05_19-22-43 (17 builds)*

**Request body:** System.Boolean

**Response:**

`200 OK` — JSON `PLOPPLAOICD`

```json
{
  "RoomId": long,
  "Name": string,
  "Description": string,
  "CreatorPlayerId": int,
  "ImageName": string,
  "DataBlobName": string,
  "ActivityLevelId": string,
  "IsSandbox": bool,
  "Instanced": bool,
  "MaxPlayers": int,
  "FeaturedOrder": int,
  "Accessibility": int,   // enum MJHMLOAMKCH
  "AccessibilityLocked": bool,
  "VisitorCount": int,
  "CheerCount": int,
  "ReportCount": int,
  "State": int,   // enum JECCIECOEID
  "StateModifiedAt": DateTime,   // epoch ticks
  "CreatedAt": DateTime,   // epoch ticks
  "ModifiedAt": DateTime,   // epoch ticks
  "LastVisitedAt": DateTime,   // epoch ticks
  "CoOwners": int,
  "Hosts": int,
  "PersonalDetails": GIJAOPNONJL
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `RoomId` | `long` | `EDNBKCICCOC` |
| `Name` | `string` | `GDIECAFDIMC` |
| `Description` | `string` | `MJLCELIIAJF` |
| `CreatorPlayerId` | `int` | `EEDOGBONKHP` |
| `ImageName` | `string` | `GAKPGOHFAHD` |
| `DataBlobName` | `string` | `OCDDOBNGFEF` |
| `ActivityLevelId` | `string` | — |
| `IsSandbox` | `bool` | `ACKCOLJODJB` |
| `Instanced` | `bool` | `JMEGODHEJDI` |
| `MaxPlayers` | `int` | `NPKLJMCJBEH` |
| `FeaturedOrder` | `int` | `GPODNKJFHJA` |
| `Accessibility` | `int` | `DOFCAKGHLMI` |
| `AccessibilityLocked` | `bool` | `GFGMFJNKLDO` |
| `VisitorCount` | `int` | `EGJFKIDMGGP` |
| `CheerCount` | `int` | `BJDMPOGAGNB` |
| `ReportCount` | `int` | `CFEJLFFLJMJ` |
| `State` | `int` | `FBBMOMHACLA` |
| `StateModifiedAt` | `DateTime` | `GICBDENAPEG` |
| `CreatedAt` | `DateTime` | `OCNHFBMLPIC` |
| `ModifiedAt` | `DateTime` | `HFIOGLMCJGL` |
| `LastVisitedAt` | `DateTime` | `DGPKDEHOLIJ` |
| `CoOwners` | `int` | `LNJJLNJCCHK` |
| `Hosts` | `int` | `MGBCHDKPAJO` |
| `PersonalDetails` | `GIJAOPNONJL` | `DODDIDKODJL` |

<details><summary>Client-side callback</summary>

```cs
private static HEMCJJJMLKI.JMICPMCJMJF<List<PLOPPLAOICD>> PGJHJBCDJPO (HEMCJJJMLKI.JMICPMCJMJF<List<PLOPPLAOICD>> JOINLHEALDL)
{
	return delegate(string DAKCKPMBKFF, List<PLOPPLAOICD> DBONFHMCEGM) {
		if (string.IsNullOrEmpty (DAKCKPMBKFF)) {
			PMHJGBCLLII (DBONFHMCEGM);
		}
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, DBONFHMCEGM);
	};
}
```

</details>

---

## POST `api/rooms/v1/name/{param}`

*first seen: 2017-12-15_01-29-10 — last seen: 2018-04-05_19-22-43 (17 builds)*

**URI parameters:** `param`

**Request body:** System.Boolean

**Response:**

`200 OK` — JSON `PLOPPLAOICD]]` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
private static HEMCJJJMLKI.JMICPMCJMJF<RecNet.LEBBEBAOKAL<PLOPPLAOICD>> AOEGGOLHJBD (HEMCJJJMLKI.JMICPMCJMJF<PLOPPLAOICD> JOINLHEALDL)
{
	return delegate(string DAKCKPMBKFF, RecNet.LEBBEBAOKAL<PLOPPLAOICD> FIIFPLCNFHJ) {
		if (string.IsNullOrEmpty (DAKCKPMBKFF) && FIIFPLCNFHJ != null) {
			MLOMMKCHAND (RecNet.LEBBEBAOKAL<PLOPPLAOICD>.EDHNDLCFIOL (FIIFPLCNFHJ));
		}
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, RecNet.LEBBEBAOKAL<PLOPPLAOICD>.EDHNDLCFIOL (FIIFPLCNFHJ));
	};
}
```

</details>

---

## POST `api/rooms/v1/removecoowner`

*first seen: 2018-01-12_22-13-25 — last seen: 2018-04-05_19-22-43 (15 builds)*

**Request body:** application/json

**Response:**

`200 OK` — JSON `HNIFBBFIBBG+IPGOHMDDGFL` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
JOINLHEALDL
```

</details>

---

## POST `api/rooms/v1/removehost`

*first seen: 2018-01-12_22-13-25 — last seen: 2018-04-05_19-22-43 (15 builds)*

**Request body:** application/json

**Response:**

`200 OK` — JSON `HNIFBBFIBBG+IPGOHMDDGFL` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
JOINLHEALDL
```

</details>

---

## GET `api/rooms/v1/report`

*first seen: 2018-06-21_00-30-05 — last seen: 2018-12-06_21-26-17 (21 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/rooms/v1/report`

*first seen: 2017-12-15_01-29-10 — last seen: 2018-04-05_19-22-43 (17 builds)*

**Request body:** application/json

**Response:**

`200 OK` — JSON `EFDOILDKBFK`

```json
{
  "RpcAuthorityDestroyEquipment": bool,
  "price": string
}
```

<details><summary>Client-side callback</summary>

```cs
JOINLHEALDL
```

</details>

---

## POST `api/rooms/v1/saveData/{Value}`

*first seen: 2017-12-15_01-29-10 — last seen: 2018-06-22_00-34-04 (19 builds)*

**URI parameters:** `Value`

**Request body:** WWWForm (application/x-www-form-urlencoded)

| Field | Type |
|-------|------|
| `data` | `byte[]` |
| `imgList` | `string` |
| `dataBlobList` | `string` |

**Response:**

`200 OK` — JSON `HNIFBBFIBBG+OECFKGPCPBD` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF, OECFKGPCPBD DKBBNNEBKMO) {
	string dKBBNNEBKMO = DKBBNNEBKMO?.OCDDOBNGFEF;
	HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, dKBBNNEBKMO);
}
```

</details>

---

## POST `api/rooms/v1/search`

*first seen: 2017-12-15_01-29-10 — last seen: 2018-06-22_00-34-04 (19 builds)*

**Request body:** application/json

**Response:**

`200 OK` — JSON `PLOPPLAOICD`

```json
{
  "RoomId": long,
  "Name": string,
  "Description": string,
  "CreatorPlayerId": int,
  "ImageName": string,
  "DataBlobName": string,
  "ActivityLevelId": string,
  "IsSandbox": bool,
  "Instanced": bool,
  "MaxPlayers": int,
  "FeaturedOrder": int,
  "Accessibility": int,   // enum MJHMLOAMKCH
  "AccessibilityLocked": bool,
  "VisitorCount": int,
  "CheerCount": int,
  "ReportCount": int,
  "State": int,   // enum JECCIECOEID
  "StateModifiedAt": DateTime,   // epoch ticks
  "CreatedAt": DateTime,   // epoch ticks
  "ModifiedAt": DateTime,   // epoch ticks
  "LastVisitedAt": DateTime,   // epoch ticks
  "CoOwners": int,
  "Hosts": int,
  "PersonalDetails": GIJAOPNONJL
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `RoomId` | `long` | `EDNBKCICCOC` |
| `Name` | `string` | `GDIECAFDIMC` |
| `Description` | `string` | `MJLCELIIAJF` |
| `CreatorPlayerId` | `int` | `EEDOGBONKHP` |
| `ImageName` | `string` | `GAKPGOHFAHD` |
| `DataBlobName` | `string` | `OCDDOBNGFEF` |
| `ActivityLevelId` | `string` | — |
| `IsSandbox` | `bool` | `ACKCOLJODJB` |
| `Instanced` | `bool` | `JMEGODHEJDI` |
| `MaxPlayers` | `int` | `NPKLJMCJBEH` |
| `FeaturedOrder` | `int` | `GPODNKJFHJA` |
| `Accessibility` | `int` | `DOFCAKGHLMI` |
| `AccessibilityLocked` | `bool` | `GFGMFJNKLDO` |
| `VisitorCount` | `int` | `EGJFKIDMGGP` |
| `CheerCount` | `int` | `BJDMPOGAGNB` |
| `ReportCount` | `int` | `CFEJLFFLJMJ` |
| `State` | `int` | `FBBMOMHACLA` |
| `StateModifiedAt` | `DateTime` | `GICBDENAPEG` |
| `CreatedAt` | `DateTime` | `OCNHFBMLPIC` |
| `ModifiedAt` | `DateTime` | `HFIOGLMCJGL` |
| `LastVisitedAt` | `DateTime` | `DGPKDEHOLIJ` |
| `CoOwners` | `int` | `LNJJLNJCCHK` |
| `Hosts` | `int` | `MGBCHDKPAJO` |
| `PersonalDetails` | `GIJAOPNONJL` | `DODDIDKODJL` |

<details><summary>Client-side callback</summary>

```cs
private static HEMCJJJMLKI.JMICPMCJMJF<List<PLOPPLAOICD>> PGJHJBCDJPO (HEMCJJJMLKI.JMICPMCJMJF<List<PLOPPLAOICD>> JOINLHEALDL)
{
	return delegate(string DAKCKPMBKFF, List<PLOPPLAOICD> DBONFHMCEGM) {
		if (string.IsNullOrEmpty (DAKCKPMBKFF)) {
			PMHJGBCLLII (DBONFHMCEGM);
		}
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, DBONFHMCEGM);
	};
}
```

</details>

---

## POST `api/rooms/v1/{param}`

*first seen: 2017-12-15_01-29-10 — last seen: 2018-04-05_19-22-43 (17 builds)*

**URI parameters:** `param`

**Request body:** System.Boolean

**Response:**

`200 OK` — JSON `PLOPPLAOICD]]` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
private static HEMCJJJMLKI.JMICPMCJMJF<RecNet.LEBBEBAOKAL<PLOPPLAOICD>> AOEGGOLHJBD (HEMCJJJMLKI.JMICPMCJMJF<PLOPPLAOICD> JOINLHEALDL)
{
	return delegate(string DAKCKPMBKFF, RecNet.LEBBEBAOKAL<PLOPPLAOICD> FIIFPLCNFHJ) {
		if (string.IsNullOrEmpty (DAKCKPMBKFF) && FIIFPLCNFHJ != null) {
			MLOMMKCHAND (RecNet.LEBBEBAOKAL<PLOPPLAOICD>.EDHNDLCFIOL (FIIFPLCNFHJ));
		}
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, RecNet.LEBBEBAOKAL<PLOPPLAOICD>.EDHNDLCFIOL (FIIFPLCNFHJ));
	};
}
```

</details>

---

## POST `api/rooms/v2/browse`

*first seen: 2018-03-01_20-14-27 — last seen: 2018-06-22_00-34-04 (10 builds)*

**Request body:** application/json

**Response:**

`200 OK` — JSON `PLOPPLAOICD`

```json
{
  "RoomId": long,
  "Name": string,
  "Description": string,
  "CreatorPlayerId": int,
  "ImageName": string,
  "DataBlobName": string,
  "ActivityLevelId": string,
  "IsSandbox": bool,
  "Instanced": bool,
  "MaxPlayers": int,
  "FeaturedOrder": int,
  "Accessibility": int,   // enum MJHMLOAMKCH
  "AccessibilityLocked": bool,
  "VisitorCount": int,
  "CheerCount": int,
  "ReportCount": int,
  "State": int,   // enum JECCIECOEID
  "StateModifiedAt": DateTime,   // epoch ticks
  "CreatedAt": DateTime,   // epoch ticks
  "ModifiedAt": DateTime,   // epoch ticks
  "LastVisitedAt": DateTime,   // epoch ticks
  "CoOwners": int,
  "Hosts": int,
  "PersonalDetails": GIJAOPNONJL
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `RoomId` | `long` | `EDNBKCICCOC` |
| `Name` | `string` | `GDIECAFDIMC` |
| `Description` | `string` | `MJLCELIIAJF` |
| `CreatorPlayerId` | `int` | `EEDOGBONKHP` |
| `ImageName` | `string` | `GAKPGOHFAHD` |
| `DataBlobName` | `string` | `OCDDOBNGFEF` |
| `ActivityLevelId` | `string` | — |
| `IsSandbox` | `bool` | `ACKCOLJODJB` |
| `Instanced` | `bool` | `JMEGODHEJDI` |
| `MaxPlayers` | `int` | `NPKLJMCJBEH` |
| `FeaturedOrder` | `int` | `GPODNKJFHJA` |
| `Accessibility` | `int` | `DOFCAKGHLMI` |
| `AccessibilityLocked` | `bool` | `GFGMFJNKLDO` |
| `VisitorCount` | `int` | `EGJFKIDMGGP` |
| `CheerCount` | `int` | `BJDMPOGAGNB` |
| `ReportCount` | `int` | `CFEJLFFLJMJ` |
| `State` | `int` | `FBBMOMHACLA` |
| `StateModifiedAt` | `DateTime` | `GICBDENAPEG` |
| `CreatedAt` | `DateTime` | `OCNHFBMLPIC` |
| `ModifiedAt` | `DateTime` | `HFIOGLMCJGL` |
| `LastVisitedAt` | `DateTime` | `DGPKDEHOLIJ` |
| `CoOwners` | `int` | `LNJJLNJCCHK` |
| `Hosts` | `int` | `MGBCHDKPAJO` |
| `PersonalDetails` | `GIJAOPNONJL` | `DODDIDKODJL` |

<details><summary>Client-side callback</summary>

```cs
private static HEMCJJJMLKI.JMICPMCJMJF<List<PLOPPLAOICD>> PGJHJBCDJPO (HEMCJJJMLKI.JMICPMCJMJF<List<PLOPPLAOICD>> JOINLHEALDL)
{
	return delegate(string DAKCKPMBKFF, List<PLOPPLAOICD> DBONFHMCEGM) {
		if (string.IsNullOrEmpty (DAKCKPMBKFF)) {
			PMHJGBCLLII (DBONFHMCEGM);
		}
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, DBONFHMCEGM);
	};
}
```

</details>

---

## POST `api/rooms/v2/create`

*first seen: 2018-01-12_22-13-25 — last seen: 2018-04-05_19-22-43 (15 builds)*

**Request body:** application/json

**Response:**

`200 OK` — JSON `HNIFBBFIBBG+DELNGKJFONK` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
private static HEMCJJJMLKI.JMICPMCJMJF<DELNGKJFONK> FGECDLDEFIE (string BHDHJEIHHJD, HEMCJJJMLKI.JMICPMCJMJF<DELNGKJFONK> JOINLHEALDL)
{
	return delegate(string DAKCKPMBKFF, DELNGKJFONK DKBBNNEBKMO) {
		if (!string.IsNullOrEmpty (DAKCKPMBKFF)) {
			Debug.LogErrorFormat ("RecNet room modify failed ({0}): {1}", BHDHJEIHHJD, DAKCKPMBKFF);
		} else if (DKBBNNEBKMO.DPLNNBKDDAH != BOFMNGCCLNF.Success) {
			Debug.LogWarningFormat ("RecNet room modify failed ({0}): {1}", BHDHJEIHHJD, DKBBNNEBKMO.DPLNNBKDDAH);
		} else {
			MLOMMKCHAND (DKBBNNEBKMO.PLOPPLAOICD);
		}
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, DKBBNNEBKMO);
	};
}
```

</details>

---

## POST `api/rooms/v2/details/{param}`

*first seen: 2018-02-15_18-48-13 — last seen: 2018-04-05_19-22-43 (11 builds)*

**URI parameters:** `param`

**Request body:** System.Boolean

**Response:**

`200 OK` — JSON `PFMOEEDCNBK`

```json
{
  "TeleportOutline_mat": int,
  "Score": int
}
```

<details><summary>Client-side callback</summary>

```cs
JOINLHEALDL
```

</details>

---

## GET `api/rooms/v2/instancedetails/{param}`

*first seen: 2018-08-28_16-00-26 — last seen: 2018-12-06_21-26-17 (19 builds)*

**URI parameters:** `param`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
HEGFLJKILKM: false
```

</details>

---

## GET `api/rooms/v2/modify`

*first seen: 2018-08-28_16-00-26 — last seen: 2018-12-06_21-26-17 (19 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/rooms/v2/modify`

*first seen: 2018-12-14_19-12-52 — last seen: 2019-02-14_22-55-35 (8 builds)*

**Declared by:** `Rooms.ModifyRoomImageName`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/rooms/v2/modifyPermissions`

*first seen: 2018-11-05_23-42-06 — last seen: 2018-12-06_21-26-17 (7 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
hKBGPJJNELK
```

</details>

---

## GET `api/rooms/v2/myRecent?skip=0&take=10`

*first seen: 2018-08-28_16-00-26 — last seen: 2019-02-14_22-55-35 (27 builds)*

**Declared by:** `Rooms.GetMyRecentRooms`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num2 != 0
```

</details>

---

## POST `api/rooms/v2/name/{param}`

*first seen: 2018-08-28_16-00-26 — last seen: 2018-12-06_21-26-17 (19 builds)*

**URI parameters:** `param`

**Request body:** System.TimeSpan

**Response:**

`200 OK` — JSON `PLOPPLAOICD`

```json
{
  "RoomId": long,
  "Name": string,
  "Description": string,
  "CreatorPlayerId": int,
  "ImageName": string,
  "State": int,   // enum JECCIECOEID
  "Accessibility": int,   // enum MJHMLOAMKCH
  "SupportsLevelVoting": bool,
  "CheerCount": int,
  "FavoriteCount": int,
  "IsAGRoom": bool,
  "CloningAllowed": bool,
  "SupportsScreens": bool,
  "SupportsWalkVR": bool,
  "SupportsTeleportVR": bool
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `RoomId` | `long` | `EDNBKCICCOC` |
| `Name` | `string` | `GDIECAFDIMC` |
| `Description` | `string` | `MJLCELIIAJF` |
| `CreatorPlayerId` | `int` | `EEDOGBONKHP` |
| `ImageName` | `string` | `GAKPGOHFAHD` |
| `State` | `int` | `FBBMOMHACLA` |
| `Accessibility` | `int` | `DOFCAKGHLMI` |
| `SupportsLevelVoting` | `bool` | `PCGBCEJPLHN` |
| `CheerCount` | `int` | `BJDMPOGAGNB` |
| `FavoriteCount` | `int` | `CPCPLOLHANO` |
| `IsAGRoom` | `bool` | `OCAPHHJICEH` |
| `CloningAllowed` | `bool` | `KGJHJMBMBIM` |
| `SupportsScreens` | `bool` | `FICEMCIKPMA` |
| `SupportsWalkVR` | `bool` | `MDKLIEPMCAO` |
| `SupportsTeleportVR` | `bool` | `NNFGOPCDEDH` |

<details><summary>Client-side callback</summary>

```cs
HEGFLJKILKM: false
```

</details>

---

## GET `api/rooms/v2/name/{stringToEscape}`

*first seen: 2018-12-14_19-12-52 — last seen: 2019-02-14_22-55-35 (8 builds)*

**Declared by:** `Rooms.GetRoomByName`

**URI parameters:** `stringToEscape`

**Response:**

`200 OK` — JSON `Room`

```json
{
  "RoomId": long,
  "Name": string,
  "Description": string,
  "CreatorPlayerId": int,
  "ImageName": string,
  "State": int,
  "Accessibility": int,
  "SupportsLevelVoting": bool,
  "IsAGRoom": bool,
  "CloningAllowed": bool,
  "SupportsScreens": bool,
  "SupportsWalkVR": bool,
  "SupportsTeleportVR": bool,
  "AllowsJuniors": bool,
  "DisableMicAutoMute": bool
}
```

<details><summary>Client-side callback</summary>

```cs
(byte)num5 != 0
```

</details>

---

## POST `api/rooms/v2/report`

*first seen: 2018-12-14_19-12-52 — last seen: 2019-02-14_22-55-35 (8 builds)*

**Declared by:** `Rooms.ReportRoom`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/rooms/v2/saveData/{param}`

*first seen: 2018-08-28_16-00-26 — last seen: 2019-01-29_20-05-38 (25 builds)*

**Declared by:** `Rooms.UploadLocalRoomSceneData`

**URI parameters:** `roomSceneId`

**Request body:** WWWForm (application/x-www-form-urlencoded)

| Field | Type |
|-------|------|
| `data` | `byte[]` |
| `imgList` | `string` |
| `dataBlobList` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/rooms/v2/{param}`

*first seen: 2018-08-28_16-00-26 — last seen: 2018-12-06_21-26-17 (19 builds)*

**URI parameters:** `param`

**Request body:** System.TimeSpan

**Response:**

`200 OK` — JSON `PLOPPLAOICD`

```json
{
  "RoomId": long,
  "Name": string,
  "Description": string,
  "CreatorPlayerId": int,
  "ImageName": string,
  "State": int,   // enum JECCIECOEID
  "Accessibility": int,   // enum MJHMLOAMKCH
  "SupportsLevelVoting": bool,
  "CheerCount": int,
  "FavoriteCount": int,
  "IsAGRoom": bool,
  "CloningAllowed": bool,
  "SupportsScreens": bool,
  "SupportsWalkVR": bool,
  "SupportsTeleportVR": bool
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `RoomId` | `long` | `EDNBKCICCOC` |
| `Name` | `string` | `GDIECAFDIMC` |
| `Description` | `string` | `MJLCELIIAJF` |
| `CreatorPlayerId` | `int` | `EEDOGBONKHP` |
| `ImageName` | `string` | `GAKPGOHFAHD` |
| `State` | `int` | `FBBMOMHACLA` |
| `Accessibility` | `int` | `DOFCAKGHLMI` |
| `SupportsLevelVoting` | `bool` | `PCGBCEJPLHN` |
| `CheerCount` | `int` | `BJDMPOGAGNB` |
| `FavoriteCount` | `int` | `CPCPLOLHANO` |
| `IsAGRoom` | `bool` | `OCAPHHJICEH` |
| `CloningAllowed` | `bool` | `KGJHJMBMBIM` |
| `SupportsScreens` | `bool` | `FICEMCIKPMA` |
| `SupportsWalkVR` | `bool` | `MDKLIEPMCAO` |
| `SupportsTeleportVR` | `bool` | `NNFGOPCDEDH` |

<details><summary>Client-side callback</summary>

```cs
HEGFLJKILKM: false
```

</details>

---

## GET `api/rooms/v3/featured`

*first seen: 2018-08-28_16-00-26 — last seen: 2019-02-14_22-55-35 (27 builds)*

**Declared by:** `Rooms.GetFeaturedRoom`

**Response:**

`200 OK` — JSON `Room`

```json
{
  "RoomId": long,
  "Name": string,
  "Description": string,
  "CreatorPlayerId": int,
  "ImageName": string,
  "State": int,
  "Accessibility": int,
  "SupportsLevelVoting": bool,
  "IsAGRoom": bool,
  "CloningAllowed": bool,
  "SupportsScreens": bool,
  "SupportsWalkVR": bool,
  "SupportsTeleportVR": bool,
  "AllowsJuniors": bool,
  "DisableMicAutoMute": bool
}
```

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/rooms/v3/saveData/{roomSceneId}`

*first seen: 2019-02-07_18-24-01 — last seen: 2019-02-14_22-55-35 (2 builds)*

**Declared by:** `Rooms.UploadLocalRoomSceneData`

**URI parameters:** `roomSceneId`

**Request body:** WWWForm (application/x-www-form-urlencoded)

| Field | Type |
|-------|------|
| `data` | `byte[]` |
| `imgList` | `string` |
| `dataBlobList` | `string` |
| `inventionUsages` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num16 != 0
```

</details>

---

## GET `api/rooms/v4/details/{param}`

*first seen: 2018-08-28_16-00-26 — last seen: 2018-12-06_21-26-17 (19 builds)*

**URI parameters:** `param`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
HEGFLJKILKM: false
```

</details>

---

