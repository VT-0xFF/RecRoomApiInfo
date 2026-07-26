# Analytics

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## POST `api/analytics/v1/session/event`

*first seen: 2016-12-09_03-11-41 — last seen: 2017-02-03_23-53-02 (12 builds)*

**Declared by:** `Analytics.Event`

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `SessionId` | `string` |
| `Category` | `string` |
| `Action` | `string` |
| `Label` | `string` |
| `Value` | `string` |
| `Value2` | `string` |
| `Value3` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
callback
```

</details>

---

