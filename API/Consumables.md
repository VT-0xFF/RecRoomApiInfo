# Consumables

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## GET `api/consumables/v1/consume`

*first seen: 2018-05-09_19-37-59 — last seen: 2018-12-06_21-26-17 (40 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/consumables/v1/consume`

*first seen: 2018-03-15_20-55-21 — last seen: 2021-05-04_02-50-19 (124 builds)*

**Declared by:** `Consumables.UseConsumable`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num9 != 0
```

</details>

---

## GET `api/consumables/v1/getUnlocked`

*first seen: 2018-05-09_19-37-59 — last seen: 2020-07-17_03-00-52 (107 builds)*

**Declared by:** `Consumables.MoveNext`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num != 0
```

</details>

---

## POST `api/consumables/v1/getUnlocked`

*first seen: 2018-03-15_20-55-21 — last seen: 2018-05-04_20-50-17 (10 builds)*

**Request body:** System.Boolean

**Response:**

`200 OK` — JSON `AHKHIEFNBMK`

```json
{
  "Id": long,
  "ConsumableItemDesc": string,
  "CreatedAt": DateTime,   // epoch ticks
  "Count": int,
  "UnlockedLevel": int,
  "IsActive": bool
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `Id` | `long` | `PKJFPDJKJAH` |
| `ConsumableItemDesc` | `string` | `JGPCCJHDACB` |
| `CreatedAt` | `DateTime` | `OCNHFBMLPIC` |
| `Count` | `int` | `NKEHDKABAPE` |
| `UnlockedLevel` | `int` | `NGJPBAMKJBH` |
| `IsActive` | `bool` | `ACBKNECAIAN` |

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF, List<AHKHIEFNBMK> CFDDDDCPOKP) {
	if (string.IsNullOrEmpty (DAKCKPMBKFF)) {
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, null, CFDDDDCPOKP);
	} else {
		Debug.LogError ("Failed to download unlocked Consumables: " + DAKCKPMBKFF);
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, "Failed to download unlocked Consumables", null);
	}
}
```

</details>

---

## GET `api/consumables/v1/updateActive`

*first seen: 2018-05-09_19-37-59 — last seen: 2018-12-06_21-26-17 (40 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/consumables/v1/updateActive`

*first seen: 2018-04-12_18-08-52 — last seen: 2021-08-06_06-02-59 (133 builds)*

**Declared by:** `Consumables.ActivateConsumable`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/consumables/v2/getUnlocked`

*first seen: 2020-07-22_03-00-56 — last seen: 2021-08-06_06-02-59 (52 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num != 0
```

</details>

---

