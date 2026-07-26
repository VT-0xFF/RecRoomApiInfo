# Equipment

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## GET `api/equipment/v1/getUnlocked`

*first seen: 2018-05-09_19-37-59 — last seen: 2019-10-02_14-21-06 (68 builds)*

**Declared by:** `Equipments.MoveNext`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num != 0
```

</details>

---

## POST `api/equipment/v1/getUnlocked`

*first seen: 2017-05-20_00-29-28 — last seen: 2018-05-04_20-50-17 (62 builds)*

**Declared by:** `<DowloadUnlockedEquipments>c__IteratorFE.MoveNext`

**Request body:** System.Boolean

**Response:**

`200 OK` — JSON `MPPNEBFNBKJ`

```json
{
  "PrefabName": string,
  "ModificationGuid": string,
  "UnlockedLevel": int,
  "BackpackSlot": int
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `PrefabName` | `string` | `EHADOIIOJPA` |
| `ModificationGuid` | `string` | `HPDLPEBFGMN` |
| `UnlockedLevel` | `int` | `NGJPBAMKJBH` |
| `BackpackSlot` | `int` | `OIIHFKEHLKI` |

<details><summary>Client-side callback</summary>

```cs
internal void FPMNIIAMJCP (string DAKCKPMBKFF, List<MPPNEBFNBKJ> CFDDDDCPOKP)
{
	if (string.IsNullOrEmpty (DAKCKPMBKFF)) {
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, null, CFDDDDCPOKP);
		return;
	}
	UnityEngine.Debug.LogError ("Failed to download unlocked equipments: " + DAKCKPMBKFF);
	HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, "Failed to download unlocked items", null);
}
```

</details>

---

## GET `api/equipment/v1/update`

*first seen: 2018-05-09_19-37-59 — last seen: 2018-12-06_21-26-17 (40 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/equipment/v1/update`

*first seen: 2017-05-20_00-29-28 — last seen: 2021-08-06_06-02-59 (105 builds)*

**Declared by:** `Equipments.UpdateFavorites`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/equipment/v2/getUnlocked`

*first seen: 2019-10-10_18-00-53 — last seen: 2021-08-06_06-02-59 (91 builds)*

**Declared by:** `Equipments.MoveNext`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num != 0
```

</details>

---

