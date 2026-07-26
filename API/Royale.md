# Royale

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## GET `api/royale/v1/current`

*first seen: 2018-06-07_23-55-49 — last seen: 2021-08-06_06-02-59 (152 builds)*

**Declared by:** `RecNetRecRoyaleStats.GetLocalPlayerProgress`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num != 0
```

</details>

---

## GET `api/royale/v1/matchcomplete`

*first seen: 2018-06-07_23-55-49 — last seen: 2018-12-06_21-26-17 (33 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/royale/v2/matchcomplete`

*first seen: 2019-03-14_23-23-50 — last seen: 2021-08-06_06-02-59 (119 builds)*

**Declared by:** `RecNetRecRoyaleStats.SendMatchStats`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

