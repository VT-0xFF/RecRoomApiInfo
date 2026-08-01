# Royale

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## GET `api/royale/v1/current`

*first seen: 2018-06-07_23-55-49 — last seen: 2021-08-06_06-02-59 (160 builds)*

**Declared by:** `RecNetRecRoyaleStats.GetLocalPlayerProgress`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num2 != 0
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

## POST `api/royale/v1/matchcomplete`

*first seen: 2018-12-14_19-12-52 — last seen: 2019-02-07_18-24-01 (7 builds)*

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

## POST `api/royale/v2/matchcomplete`

*first seen: 2019-02-14_22-55-35 — last seen: 2021-08-06_06-02-59 (120 builds)*

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

