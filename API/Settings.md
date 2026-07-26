# Settings

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## POST `api/settings/v1/remove`

*first seen: 2016-11-08_22-55-23 — last seen: 2016-11-29_21-32-10 (6 builds)*

**Declared by:** `Settings.Remove`

**Request body:** WWWForm (application/x-www-form-urlencoded)

| Field | Type |
|-------|------|
| `Key` | `string` |
| `PlayerId` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
delegate(WWW www) {
	callback2 (www.error);
}
```

</details>

---

## POST `api/settings/v1/set`

*first seen: 2016-11-08_22-55-23 — last seen: 2016-11-29_21-32-10 (6 builds)*

**Declared by:** `Settings.Set`

**Request body:** WWWForm (application/x-www-form-urlencoded)

| Field | Type |
|-------|------|
| `Key` | `string` |
| `Value` | `string` |
| `PlayerId` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
delegate(WWW www) {
	callback2 (www.error);
}
```

</details>

---

## GET `api/settings/v1/{Id}`

*first seen: 2016-11-08_22-55-23 — last seen: 2016-11-29_21-32-10 (6 builds)*

**Declared by:** `Settings.DowloadLocalPlayerSettings`

**URI parameters:** `Id`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
delegate(WWW www) {
	if (string.IsNullOrEmpty (www.error)) {
		List<object> list = ParsePlayerSettings (www.text);
		if (list != null) {
			callback2 (null, list);
		} else {
			callback2 ("Failed to parse player preferences '" + www.text + "'", null);
		}
	} else {
		callback2 (www.error, null);
	}
}
```

</details>

---

## GET `api/settings/v2/`

*first seen: 2016-12-09_03-11-41 — last seen: 2021-08-06_06-02-59 (175 builds)*

**Declared by:** `<DowloadLocalPlayerSettings>c__IteratorB3.MoveNext`, `<DowloadLocalPlayerSettings>c__IteratorB4.MoveNext`, `Settings.DowloadLocalPlayerSettings`, `Settings.MoveNext`

**Response:**

`200 OK` — JSON `Setting`

```json
{
  "Key": string,
  "Value": string
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `Key` | `string` | `Key` |
| `Value` | `string` | `Value` |

<details><summary>Client-side callback</summary>

```cs
delegate(string error, List<Setting> settings) {
	if (string.IsNullOrEmpty (error)) {
		Core.SafeInvoke (callback2, null, settings);
	} else {
		Debug.LogError ("Failed to download player settings: " + error);
		Core.SafeInvoke (callback2, "Failed to download player settings", null);
	}
}
```

</details>

---

## POST `api/settings/v2/`

*first seen: 2017-02-22_19-52-07 — last seen: 2018-05-04_20-50-17 (88 builds)*

**Declared by:** `<DowloadLocalPlayerSettings>c__Iterator100.MoveNext`, `<DowloadLocalPlayerSettings>c__IteratorC6.MoveNext`, `<DowloadLocalPlayerSettings>c__IteratorE1.MoveNext`, `<DowloadLocalPlayerSettings>c__IteratorE2.MoveNext`, `<DowloadLocalPlayerSettings>c__IteratorE3.MoveNext`, `<DowloadLocalPlayerSettings>c__IteratorEA.MoveNext`, `<DowloadLocalPlayerSettings>c__IteratorEC.MoveNext`, `<DowloadLocalPlayerSettings>c__IteratorF0.MoveNext`, `<DowloadLocalPlayerSettings>c__IteratorF1.MoveNext`, `<DowloadLocalPlayerSettings>c__IteratorFD.MoveNext`, `<DowloadLocalPlayerSettings>c__IteratorFE.MoveNext`

**Request body:** System.Boolean

**Response:**

`200 OK` — JSON `JBODKDEGMDO`

```json
{
  "RpcFireShot": string,
  "locked_idle": string
}
```

<details><summary>Client-side callback</summary>

```cs
internal void GCILAJMMLCE (string GHJBJJPHNHD, List<JBODKDEGMDO> CKJKCMPGGPE)
{
	if (string.IsNullOrEmpty (GHJBJJPHNHD)) {
		BFEONIELEAH.FOBBKGGGEKD (ADHBNDGBJCE, null, CKJKCMPGGPE);
		return;
	}
	UnityEngine.Debug.LogError ("Failed to download player settings: " + GHJBJJPHNHD);
	BFEONIELEAH.FOBBKGGGEKD (ADHBNDGBJCE, "Failed to download player settings", null);
}
```

</details>

---

## POST `api/settings/v2/set`

*first seen: 2019-03-14_23-23-50 — last seen: 2019-09-05_17-54-23 (23 builds)*

**Declared by:** `Settings.StoreLocalPlayerSetting`

**Request body:** RecNet.Setting

**Response:**

`200 OK` — JSON `Setting`

```json
{
  "Key": string,
  "Value": string
}
```

<details><summary>Client-side callback</summary>

```cs
(byte)num != 0
```

</details>

---

## POST `api/settings/v2/{action}`

*first seen: 2016-12-09_03-11-41 — last seen: 2018-12-06_21-26-17 (144 builds)*

**Declared by:** `<StoreLocalPlayerSetting>c__IteratorB4.HKBGKMBEOHN`, `<StoreLocalPlayerSetting>c__IteratorB5.HKBGKMBEOHN`, `<StoreLocalPlayerSetting>c__IteratorC7.HKBGKMBEOHN`, `<StoreLocalPlayerSetting>c__IteratorE2.IBEECPJPFFB`, `<StoreLocalPlayerSetting>c__IteratorE3.IBEECPJPFFB`, `<StoreLocalPlayerSetting>c__IteratorE4.IBEECPJPFFB`, `Settings.StoreLocalPlayerSetting`

**URI parameters:** `arg`

**Request body:** RecNet.HAOPGDCFCHD

**Response:**

`200 OK` — JSON `HAOPGDCFCHD`

```json
{
  "Key": string,
  "Value": string
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `Key` | `string` | `LBKODLELGDF` |
| `Value` | `string` | `HJOPBCLAIPD` |

<details><summary>Client-side callback</summary>

```cs
EGOJDIFBGAF
```

</details>

---

