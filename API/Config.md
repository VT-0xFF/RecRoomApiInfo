# Config

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## GET `api/config/v1/amplitude`

*first seen: 2017-09-15_00-01-47 — last seen: 2021-08-06_06-02-59 (196 builds)*

**Declared by:** `Config.DownloadAmplitudeSettings`

**Response:**

`200 OK` — JSON `HICAMDGMEAH`

```json
{
  "looktarget": string
}
```

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF, HICAMDGMEAH DPBAECEJKMC) {
	if (!string.IsNullOrEmpty (DAKCKPMBKFF)) {
		Debug.LogError ("Failed to download config settings: " + DAKCKPMBKFF);
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, "Failed to connect to RecNet");
	} else {
		KHJGACFJMEB = DPBAECEJKMC.KHJGACFJMEB;
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, null);
	}
}
```

</details>

---

## GET `api/config/v1/motd`

*first seen: 2016-10-26_20-30-17 — last seen: 2016-11-29_21-32-10 (9 builds)*

**Declared by:** `Config.GetMessageOfTheDay`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
delegate(WWW www) {
	callback (www.error, www.text);
}
```

</details>

---

## GET `api/config/v1/objectives`

*first seen: 2016-10-26_20-30-17 — last seen: 2016-11-29_21-32-10 (9 builds)*

**Declared by:** `Config.GetDailyObjectives`

**Response:**

`200 OK` — JSON `DailyObjectives`

```json
{
  "type": int,   // enum PlayerObjectiveTracker.ObjectiveType
  "score": int,
  "xp": int
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `type` | `int` | `ObjectiveType` |
| `score` | `int` | `RequiredScore` |
| `xp` | `int` | `Xp` |

<details><summary>Client-side callback</summary>

```cs
delegate(WWW www) {
	PlayerObjectiveTracker.Objective[][] objectives = ((!string.IsNullOrEmpty (www.error)) ? null : ParseDailyObjectives (www.text));
	callback (www.error, objectives);
}
```

</details>

---

## GET `api/config/v2`

*first seen: 2016-12-09_03-11-41 — last seen: 2021-08-06_06-02-59 (263 builds)*

**Declared by:** `Config.DownloadConfigSettings`

**Response:**

`200 OK` — JSON `EJJFODBLAFM`

```json
{
  "MessageOfTheDay": string,
  "CdnBaseUri": string,
  "MatchmakingParams": CGKMIEOHHHL,
  "Level": int,
  "RequiredXp": int,
  "type": int,   // enum ProgressionManager.NJIKFKFAOGJ
  "score": int,
  "Key": string,
  "Value": string,
  "PhotonConfig": KFOJHKGMBBF,
  "LevelProgressionMaps": object[],   // array
  "DailyObjectives": object[],   // array
  "ConfigTable": object[]   // array
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `MessageOfTheDay` | `string` | `DABNANGOKGJ` |
| `CdnBaseUri` | `string` | `DPELOBIIMBI` |
| `MatchmakingParams` | `CGKMIEOHHHL` | `HPKFCONNGFM` |
| `Level` | `int` | — |
| `RequiredXp` | `int` | — |
| `type` | `int` | `ObjectiveType` |
| `score` | `int` | `RequiredScore` |
| `Key` | `string` | — |
| `Value` | `string` | — |
| `PhotonConfig` | `KFOJHKGMBBF` | `KFOJHKGMBBF` |
| `LevelProgressionMaps` | `object[]` | — |
| `DailyObjectives` | `object[]` | — |
| `ConfigTable` | `object[]` | — |

<details><summary>Client-side callback</summary>

```cs
delegate(string HJLPPIBIGNJ, EJJFODBLAFM DOABIGNFJPA) {
	FDIDPKOPGAM = DOABIGNFJPA;
	if (!string.IsNullOrEmpty (HJLPPIBIGNJ)) {
		Debug.LogError ("Failed to download config settings: " + HJLPPIBIGNJ);
		COGCNMJCNKN.BFNFLFBCDCC (EGOJDIFBGAF, "Failed to connect to RecNet");
	} else {
		COGCNMJCNKN.BFNFLFBCDCC (EGOJDIFBGAF, null);
	}
}
```

</details>

---

## GET `https://recroom.azurewebsites.net/api/config/v1/motd`

*first seen: 2016-10-18_01-49-40 — last seen: 2016-10-18_01-49-40 (1 builds)*

**Declared by:** `<UpdateLocalPlayerModelCoroutine>c__Iterator8B.GetMessageOfTheDay`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
delegate(WWW www) {
	callback (www.error, www.text);
}
```

</details>

---

## GET `https://recroom.azurewebsites.net/api/config/v1/objectives`

*first seen: 2016-10-18_01-49-40 — last seen: 2016-10-18_01-49-40 (1 builds)*

**Declared by:** `<UpdateLocalPlayerModelCoroutine>c__Iterator8B.GetDailyObjectives`

**Response:**

`200 OK` — JSON `DailyObjectives`

```json
{
  "type": object,   // enum PlayerObjectiveTracker.ObjectiveType
  "score": object,
  "xp": object
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `type` | `object` | `ObjectiveType` |
| `score` | `object` | `RequiredScore` |
| `xp` | `object` | `Xp` |

<details><summary>Client-side callback</summary>

```cs
delegate(WWW www) {
	string text = www.error;
	PlayerObjectiveTracker.Objective[][] array = null;
	if (string.IsNullOrEmpty (text)) {
		array = ParseDailyObjectives (www.text);
		if (array == null) {
			text = "Unable to parse!";
		}
	}
	callback (text, array);
}
```

</details>

---

