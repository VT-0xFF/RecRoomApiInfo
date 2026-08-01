# PlayersBanned

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## POST `api/PlayersBanned/v2/ban`

*first seen: 2017-05-08_22-53-45 — last seen: 2021-08-06_06-02-59 (224 builds)*

**Declared by:** `Moderation.LocalRequestPlayerBan`

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `PlayerId` | `string` |
| `Reason` | `string` |
| `BanType` | `string` |
| `DisplayReason` | `string` |
| `BannedUntil` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF) {
	if (!string.IsNullOrEmpty (DAKCKPMBKFF)) {
		Debug.LogError ("Failed to request PlayerBan : " + DAKCKPMBKFF);
	}
	HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF);
}
```

</details>

---

