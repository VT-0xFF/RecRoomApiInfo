# Objectives

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## POST `api/objectives/v1/cleargroup`

*first seen: 2017-12-15_01-29-10 — last seen: 2021-08-06_06-02-59 (182 builds)*

**Declared by:** `Objectives.ClearGroup`

**Request body:** application/json

**Response:**

`200 OK` — JSON `PONHJPOJILN`

```json
{
  "Group": int,
  "IsCompleted": bool,
  "ClearedAt": DateTime   // epoch ticks
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `Group` | `int` | `GIAHLPPDOFK` |
| `IsCompleted` | `bool` | `AJGOLPDKINK` |
| `ClearedAt` | `DateTime` | `EGGFHDLMEAF` |

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF, PONHJPOJILN DKBBNNEBKMO) {
	if (string.IsNullOrEmpty (DAKCKPMBKFF) && DKBBNNEBKMO != null) {
		PONHJPOJILN pONHJPOJILN3 = NNAPJAEPEEK (CNFNEDGMCEL);
		if (pONHJPOJILN3 != null) {
			IIOEJKABKIL.Remove (pONHJPOJILN3);
		}
		IIOEJKABKIL.Add (DKBBNNEBKMO);
	} else {
		UnityEngine.Debug.LogErrorFormat ("Error on server call: {0}. Local objective state will not be reflected in server!", (DAKCKPMBKFF == null) ? string.Empty : DAKCKPMBKFF);
	}
	LMKEDPJGEDJ--;
	HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, DKBBNNEBKMO);
}
```

</details>

---

## POST `api/objectives/v1/completegroup`

*first seen: 2017-12-15_01-29-10 — last seen: 2020-04-02_02-51-01 (108 builds)*

**Declared by:** `Objectives.MoveNext`

**Request body:** application/json

**Response:**

`200 OK` — JSON `PONHJPOJILN`

```json
{
  "Group": int,
  "IsCompleted": bool,
  "ClearedAt": DateTime   // epoch ticks
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `Group` | `int` | `GIAHLPPDOFK` |
| `IsCompleted` | `bool` | `AJGOLPDKINK` |
| `ClearedAt` | `DateTime` | `EGGFHDLMEAF` |

<details><summary>Client-side callback</summary>

```cs
internal void OJKNBNGGBEC (string DAKCKPMBKFF, GMJJCBDJADA DKBBNNEBKMO)
{
	if (string.IsNullOrEmpty (DAKCKPMBKFF)) {
		JDMNLJKENDI = DKBBNNEBKMO.EMGHBOPCHKP;
		IIOEJKABKIL = DKBBNNEBKMO.NPDLBNIMAAK;
		CHEBKPBPCJE ();
	} else {
		UnityEngine.Debug.LogErrorFormat ("Error on server call: {0}. Local objective state will not be reflected in server!", (DAKCKPMBKFF == null) ? string.Empty : DAKCKPMBKFF);
	}
	HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF);
}
```

</details>

---

## GET `api/objectives/v1/myprogress`

*first seen: 2018-05-09_19-37-59 — last seen: 2021-08-06_06-02-59 (159 builds)*

**Declared by:** `Objectives.GetMyObjectiveProgress`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num != 0
```

</details>

---

## POST `api/objectives/v1/myprogress`

*first seen: 2017-12-15_01-29-10 — last seen: 2018-05-04_20-50-17 (23 builds)*

**Request body:** System.Boolean

**Response:**

`200 OK` — JSON `EMGHBOPCHKP+GMJJCBDJADA` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF, GMJJCBDJADA DKBBNNEBKMO) {
	if (string.IsNullOrEmpty (DAKCKPMBKFF)) {
		JDMNLJKENDI = DKBBNNEBKMO.EMGHBOPCHKP;
		IIOEJKABKIL = DKBBNNEBKMO.NPDLBNIMAAK;
		CHEBKPBPCJE ();
	} else {
		UnityEngine.Debug.LogErrorFormat ("Error on server call: {0}. Local objective state will not be reflected in server!", (DAKCKPMBKFF == null) ? string.Empty : DAKCKPMBKFF);
	}
	HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF);
}
```

</details>

---

## POST `api/objectives/v1/updateobjective`

*first seen: 2017-12-15_01-29-10 — last seen: 2020-07-22_03-00-56 (131 builds)*

**Declared by:** `Objectives.MoveNext`

**Request body:** RecNet.ObjectiveProgress

**Response:**

`200 OK` — JSON `ObjectiveProgress`

```json
{
  "Index": int,
  "Group": int,
  "Progress": float,
  "VisualProgress": float,
  "IsCompleted": bool,
  "IsRewarded": bool
}
```

<details><summary>Client-side callback</summary>

```cs
(byte)num3 != 0
```

</details>

---

