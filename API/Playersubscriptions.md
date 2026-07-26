# Playersubscriptions

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## GET `api/playersubscriptions/v1/my`

*first seen: 2018-03-01_20-14-27 — last seen: 2020-06-09_07-58-29 (116 builds)*

**Declared by:** `PlayerSubscriptions.OnPushNotificationConnectCallback`

**Response:**

`200 OK` — JSON `LOFJKKPPKPC`

```json
{
  "update": long
}
```

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF, List<LOFJKKPPKPC> LOEIKDBOJBF) {
	if (string.IsNullOrEmpty (DAKCKPMBKFF)) {
		EKDFAAEEFGB.Clear ();
		foreach (LOFJKKPPKPC item in LOEIKDBOJBF) {
			if (item != null && !EKDFAAEEFGB.Contains (item.NKOFKNBPBIP)) {
				EKDFAAEEFGB.Add (item.NKOFKNBPBIP);
			}
		}
		JMHAEFGIBJA (null);
	} else {
		Debug.LogError ("Failed to refresh subscription list: " + DAKCKPMBKFF);
	}
}
```

</details>

---

## GET `api/playersubscriptions/v1/subscribe/{param}`

*first seen: 2018-05-09_19-37-59 — last seen: 2018-12-06_21-26-17 (40 builds)*

**URI parameters:** `param`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
dictionary
```

</details>

---

## POST `api/playersubscriptions/v1/subscribe/{param}`

*first seen: 2018-03-01_20-14-27 — last seen: 2018-05-04_20-50-17 (14 builds)*

**URI parameters:** `param`

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `PlayerId` | `string` |

**Response:**

`200 OK` — JSON `HJCEPJOJKGK+OJBJDOKBOLN` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
private static HEMCJJJMLKI.JMICPMCJMJF<OJBJDOKBOLN> IJHFFIHFIAC (long GKPEOHGOGCF, bool HBODOIEIMPK, HEMCJJJMLKI.CBJHDCMGOCN JOINLHEALDL)
{
	return delegate(string DAKCKPMBKFF, OJBJDOKBOLN DKBBNNEBKMO) {
		if (string.IsNullOrEmpty (DAKCKPMBKFF) && DKBBNNEBKMO != null && DKBBNNEBKMO.CMINJOGMKCG == HHHJJPPECGD.Success) {
			if (HBODOIEIMPK && !EKDFAAEEFGB.Contains (GKPEOHGOGCF)) {
				EKDFAAEEFGB.Add (GKPEOHGOGCF);
				JMHAEFGIBJA (GKPEOHGOGCF);
			} else if (!HBODOIEIMPK && EKDFAAEEFGB.Contains (GKPEOHGOGCF)) {
				EKDFAAEEFGB.Remove (GKPEOHGOGCF);
				JMHAEFGIBJA (GKPEOHGOGCF);
			}
		}
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF);
	};
}
```

</details>

---

## GET `api/playersubscriptions/v1/unsubscribe/{param}`

*first seen: 2018-05-09_19-37-59 — last seen: 2018-12-06_21-26-17 (40 builds)*

**URI parameters:** `param`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
dictionary
```

</details>

---

## POST `api/playersubscriptions/v1/unsubscribe/{param}`

*first seen: 2018-03-01_20-14-27 — last seen: 2018-05-04_20-50-17 (14 builds)*

**URI parameters:** `param`

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `PlayerId` | `string` |

**Response:**

`200 OK` — JSON `HJCEPJOJKGK+OJBJDOKBOLN` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
private static HEMCJJJMLKI.JMICPMCJMJF<OJBJDOKBOLN> IJHFFIHFIAC (long GKPEOHGOGCF, bool HBODOIEIMPK, HEMCJJJMLKI.CBJHDCMGOCN JOINLHEALDL)
{
	return delegate(string DAKCKPMBKFF, OJBJDOKBOLN DKBBNNEBKMO) {
		if (string.IsNullOrEmpty (DAKCKPMBKFF) && DKBBNNEBKMO != null && DKBBNNEBKMO.CMINJOGMKCG == HHHJJPPECGD.Success) {
			if (HBODOIEIMPK && !EKDFAAEEFGB.Contains (GKPEOHGOGCF)) {
				EKDFAAEEFGB.Add (GKPEOHGOGCF);
				JMHAEFGIBJA (GKPEOHGOGCF);
			} else if (!HBODOIEIMPK && EKDFAAEEFGB.Contains (GKPEOHGOGCF)) {
				EKDFAAEEFGB.Remove (GKPEOHGOGCF);
				JMHAEFGIBJA (GKPEOHGOGCF);
			}
		}
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF);
	};
}
```

</details>

---

## POST `api/playersubscriptions/v2/acceptfriendrequest?id={1}`

*first seen: 2018-11-17_00-31-17 — last seen: 2018-11-17_00-31-17 (1 builds)*

**Request body:** RecNet.OFJJINFICPM

**Response:**

`200 OK` — JSON `OFJJINFICPM`

```json
{
  "Index": int,
  "Group": int,
  "Progress": float,
  "VisualProgress": float,
  "IsCompleted": bool,
  "IsRewarded": bool
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `Index` | `int` | `NIGGPNOEPFD` |
| `Group` | `int` | `HHBDEGFDDKL` |
| `Progress` | `float` | `ADPDIBAPMPG` |
| `VisualProgress` | `float` | `BACKDCFPPLI` |
| `IsCompleted` | `bool` | `GPLOGNEPAAI` |
| `IsRewarded` | `bool` | `BLKOCEECNNO` |

<details><summary>Client-side callback</summary>

```cs
OKBCAHBFJBL: false
```

</details>

---

