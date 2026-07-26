# Checklist

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## POST `api/checklist/v1/complete`

*first seen: 2018-06-07_23-55-49 — last seen: 2020-07-01_03-10-54 (98 builds)*

**Declared by:** `Checklist.ClaimOrientationChallengeReward`, `Checklist.CompleteChecklistItem`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num != 0
```

</details>

---

## GET `api/checklist/v1/current`

*first seen: 2018-06-07_23-55-49 — last seen: 2020-07-01_03-10-54 (98 builds)*

**Declared by:** `Checklist.GetCurrentChecklist`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num != 0
```

</details>

---

