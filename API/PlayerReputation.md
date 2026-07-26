# PlayerReputation

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## POST `api/playerReputation/v1/heal`

*first seen: 2017-01-18_01-10-07 — last seen: 2019-11-12_15-10-55 (48 builds)*

**Declared by:** `Profiles.UpdateLocalProfileKarma`

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `GoodKarmaMinutes` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
delegate(string wwwError) {
	if (!string.IsNullOrEmpty (wwwError)) {
		Debug.LogError ("Failed to update Rec Room player good karma: " + wwwError);
	}
}
```

</details>

---

