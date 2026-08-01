# Bugreporting

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## GET `api/bugreporting/v1/reportbug`

*first seen: 2018-11-15_20-00-52 — last seen: 2018-12-06_21-26-17 (5 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
hCJMNAIFNNE
```

</details>

---

## POST `api/bugreporting/v1/reportbug`

*first seen: 2018-12-14_19-12-52 — last seen: 2019-04-24_15-07-27 (13 builds)*

**Declared by:** `BugReporting.ReportBug`

**Request body:** BestHTTP.Forms.HTTPMultiPartForm

| Field | Type |
|-------|------|
| `bugReport` | `string` |
| `screenshotData` | `byte[]` |
| `outputLogData` | `byte[]` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/bugreporting/v2/reportbug`

*first seen: 2019-04-30_21-58-27 — last seen: 2021-08-06_06-02-59 (114 builds)*

**Declared by:** `BugReporting.ReportBug`

**Request body:** BestHTTP.Forms.HTTPMultiPartForm

| Field | Type |
|-------|------|
| `bugReport` | `string` |
| `screenshotData` | `byte[]` |
| `outputLogData` | `byte[]` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

