# Activities

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## GET `api/activities/charades/v1/words`

*first seen: 2017-04-07_21-06-02 — last seen: 2018-09-29_21-19-48 (102 builds)*

**Declared by:** `BootSequence.MoveNext`

**Response:**

`200 OK` — JSON `AEEBGEPFAHL`

```json
{
  "EN_US": string,
  "Difficulty": int   // enum LALPHIGHJBP
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `EN_US` | `string` | `HOBAALJLIAK` |
| `Difficulty` | `int` | `HJJNKEMONBN` |

<details><summary>Client-side callback</summary>

```cs
private static void ECGFHAMMCCJ (string HJLPPIBIGNJ, List<AEEBGEPFAHL> DANPLDJOBGP)
{
	if (string.IsNullOrEmpty (HJLPPIBIGNJ)) {
		SingletonMonoBehaviour<SessionManager>.OPEJBBNAHFK.DBMPEPPDDBC = DANPLDJOBGP;
		return;
	}
	UnityEngine.Debug.LogError ("Error retrieving charades words:" + HJLPPIBIGNJ);
	HJLPPIBIGNJ = "Failed to retrive Charades words.";
}
```

</details>

---

## POST `api/activities/charades/v1/words`

*first seen: 2018-03-01_20-14-27 — last seen: 2018-04-29_17-28-39 (2 builds)*

**Request body:** System.Boolean

**Response:**

`200 OK` — JSON `NDKILGAFGDP`

```json
{
  "EventId": long,
  "Name": string,
  "Description": string,
  "StartTime": DateTime,   // epoch ticks
  "EndTime": DateTime,   // epoch ticks
  "PosterImageName": string,
  "CreatorPlayerId": long
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `EventId` | `long` | `GBFAGGKLGKN` |
| `Name` | `string` | `GDIECAFDIMC` |
| `Description` | `string` | `MJLCELIIAJF` |
| `StartTime` | `DateTime` | `PAPNOCOMOBF` |
| `EndTime` | `DateTime` | `GFFNBAPKENA` |
| `PosterImageName` | `string` | `DOPEGJNHIPC` |
| `CreatorPlayerId` | `long` | `EEDOGBONKHP` |

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF, List<NDKILGAFGDP> KINJLJBFIPI) {
	if (string.IsNullOrEmpty (DAKCKPMBKFF)) {
		OBKAAIKHHHP.Clear ();
		OBKAAIKHHHP.AddRange (KINJLJBFIPI);
		OBKAAIKHHHP.Sort ((NDKILGAFGDP FKOFGIJFIKA, NDKILGAFGDP GNNBOMAEBGK) => FKOFGIJFIKA.OAKBKMBAIFP ().CompareTo (GNNBOMAEBGK.PAPNOCOMOBF));
		NDKILGAFGDP nDKILGAFGDP = NCNNAELLCMH ();
		if (nDKILGAFGDP != null) {
			EHGDGFBEMJF.NBICOMGHILO (nDKILGAFGDP.CMDOHJCAIEN (), LGPLKNGHMPI: false);
		}
		HEMCJJJMLKI.KLPECEEEOPF (JOINLHEALDL, null);
	} else {
		Debug.LogError ("u3eqds43" + DAKCKPMBKFF);
		HEMCJJJMLKI.KLPECEEEOPF (JOINLHEALDL, "blockedDuration");
	}
}
```

</details>

---

