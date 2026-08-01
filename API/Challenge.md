# Challenge

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## GET `api/challenge/v1/getCurrent`

*first seen: 2017-07-11_00-44-03 — last seen: 2019-06-11_14-05-32 (110 builds)*

**Declared by:** `Challenges.GetCurrentChallenges`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/challenge/v1/updateProgress`

*first seen: 2017-07-11_00-44-03 — last seen: 2018-04-05_19-22-43 (46 builds)*

**Request body:** application/json

| Field | Type |
|-------|------|
| `ChallengeMapId` | `string` |
| `ChallengeId` | `string` |
| `Config` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
HEMCJJJMLKI.CKANGALNHCO ("Failed to update objective")
```

</details>

---

## GET `api/challenge/v2/getCurrent`

*first seen: 2019-06-27_14-02-36 — last seen: 2021-08-06_06-02-59 (102 builds)*

**Declared by:** `Challenges.GetCurrentChallenges`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num != 0
```

</details>

---

## GET `api/challenge/v2/updateProgress`

*first seen: 2018-04-27_18-51-13 — last seen: 2018-12-06_21-26-17 (44 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
HOEKEPDDBBF.DNGBHIBIGLN (dictionary)
```

</details>

---

## POST `api/challenge/v2/updateProgress`

*first seen: 2018-04-12_18-08-52 — last seen: 2021-08-06_06-02-59 (18 builds)*

**Declared by:** `Challenges.UpdateChallengeProgress`

**Request body:** application/json

| Field | Type |
|-------|------|
| `ChallengeMapId` | `string` |
| `ChallengeId` | `string` |
| `Config` | `string` |
| `Complete` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
HEMCJJJMLKI.CKANGALNHCO ("Failed to update objective")
```

</details>

---

