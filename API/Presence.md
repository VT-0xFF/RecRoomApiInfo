# Presence

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## POST `api/presence/v1/list`

*first seen: 2016-11-23_01-26-08 — last seen: 2017-08-22_22-54-30 (67 builds)*

**Declared by:** `PlayerPresence.RefreshCachedPlayerPresences`, `PlayerPresenceManager.RefreshCachedPlayerPresences`

**Request body:** application/json

**Response:**

`200 OK` — JSON `PlayerPresence`

```json
{
  "PlayerId": ulong,
  "GameSessionId": string,
  "AppVersion": string,
  "LastUpdateTime": DateTime,   // epoch ticks
  "Activity": string,
  "Private": bool,
  "AvailableSpace": int,
  "GameInProgress": bool
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `PlayerId` | `ulong` | `PlayerId` |
| `GameSessionId` | `string` | `GameSessionId` |
| `AppVersion` | `string` | `AppVersion` |
| `LastUpdateTime` | `DateTime` | `LastUpdateTime` |
| `Activity` | `string` | `Activity` |
| `Private` | `bool` | `Private` |
| `AvailableSpace` | `int` | `AvailableSpace` |
| `GameInProgress` | `bool` | `GameInProgress` |

<details><summary>Client-side callback</summary>

```cs
delegate(string error, List<PlayerPresence> playerPresenceList) {
	if (string.IsNullOrEmpty (error)) {
		{
			foreach (ulong id in profileIds) {
				PlayerPresence playerPresence = playerPresenceList.FirstOrDefault ((PlayerPresence p) => p.PlayerId == id);
				if (playerPresence == null) {
					playerPresenceCache.Remove (id);
				} else {
					playerPresenceCache [id] = playerPresence;
				}
				RaisePlayerPresenceUpdatedEvent (id, playerPresence);
			}
			return;
		}
	}
	Debug.LogError ("Failed to refresh player presence: " + error);
}
```

</details>

---

## GET `api/presence/v1/playerDisconnected`

*first seen: 2018-07-31_22-35-15 — last seen: 2018-12-06_21-26-17 (23 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/presence/v1/playerDisconnected`

*first seen: 2018-12-14_19-12-52 — last seen: 2019-04-24_15-07-27 (13 builds)*

**Declared by:** `Presence.SendRemotePlayerDisconnectRequest`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/presence/v1/setplayerstatusvisibility`

*first seen: 2018-12-14_19-12-52 — last seen: 2019-04-24_15-07-27 (13 builds)*

**Declared by:** `Presence.SetPlayerStatusVisibility`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/presence/v1/setplayertype`

*first seen: 2018-08-28_16-00-26 — last seen: 2018-12-06_21-26-17 (19 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/presence/v1/setplayertype`

*first seen: 2018-12-14_19-12-52 — last seen: 2019-04-24_15-07-27 (13 builds)*

**Declared by:** `Presence.SetPlayerType`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/presence/v1/{Id}`

*first seen: 2016-11-23_01-26-08 — last seen: 2016-11-29_21-32-10 (3 builds)*

**Declared by:** `PlayerPresence.UpdatePlayerPresence`

**URI parameters:** `Id`

**Request body:** System.Byte[]

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
delegate(WWW www) {
	if (!string.IsNullOrEmpty (www.error)) {
		Debug.LogError ("Failed to update player presence: " + www.error);
	}
}
```

</details>

---

## GET `api/presence/v1/{profileId}`

*first seen: 2016-11-23_01-26-08 — last seen: 2017-02-03_23-53-02 (15 builds)*

**Declared by:** `PlayerPresence.RefreshCachedPlayerPresence`, `PlayerPresenceManager.RefreshCachedPlayerPresence`

**URI parameters:** `profileId`

**Response:**

`200 OK` — JSON `PlayerPresence`

```json
{
  "PlayerId": ulong,
  "GameSessionId": string,
  "AppVersion": string,
  "LastUpdateTime": DateTime,   // epoch ticks
  "Activity": string,
  "Private": bool,
  "AvailableSpace": int,
  "GameInProgress": bool
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `PlayerId` | `ulong` | `PlayerId` |
| `GameSessionId` | `string` | `GameSessionId` |
| `AppVersion` | `string` | `AppVersion` |
| `LastUpdateTime` | `DateTime` | `LastUpdateTime` |
| `Activity` | `string` | `Activity` |
| `Private` | `bool` | `Private` |
| `AvailableSpace` | `int` | `AvailableSpace` |
| `GameInProgress` | `bool` | `GameInProgress` |

<details><summary>Client-side callback</summary>

```cs
delegate(string error, PlayerPresence playerPresence) {
	if (string.IsNullOrEmpty (error)) {
		playerPresenceCache [profileId] = playerPresence;
		RaisePlayerPresenceUpdatedEvent (profileId, playerPresence);
	} else {
		Debug.LogError ("Failed to refresh player presence: " + error);
	}
}
```

</details>

---

## POST `api/presence/v2`

*first seen: 2016-12-09_03-11-41 — last seen: 2017-02-14_02-05-12 (16 builds)*

**Declared by:** `PlayerPresenceManager.UpdatePlayerPresence`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
delegate(string error) {
	if (!string.IsNullOrEmpty (error)) {
		Debug.LogError ("Failed to update player presence: " + error);
	}
}
```

</details>

---

## GET `api/presence/v2/list`

*first seen: 2018-05-09_19-37-59 — last seen: 2018-12-06_21-26-17 (40 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/presence/v2/list`

*first seen: 2017-09-01_01-07-05 — last seen: 2019-04-24_15-07-27 (53 builds)*

**Declared by:** `Presence.RefreshCachedPlayerPresences`

**Request body:** application/json

**Response:**

`200 OK` — JSON `DBHHFILLFLC`

```json
{
  "noop": ulong,
  "sa": bool,
  "facebook": EHLBEFKJLHJ
}
```

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF, List<DBHHFILLFLC> DGOFFDNDFNG) {
	if (string.IsNullOrEmpty (DAKCKPMBKFF)) {
		foreach (ulong HPCOKMAPCHB in FPCKOPEEOEO) {
			DBHHFILLFLC dBHHFILLFLC = DGOFFDNDFNG.FirstOrDefault ((DBHHFILLFLC CECDNGGHGAK) => CECDNGGHGAK.NAJBCPFNBAB == HPCOKMAPCHB);
			if (dBHHFILLFLC == null) {
				KPBHCFKIOMA.Remove (HPCOKMAPCHB);
				PIGKIJNDGBI (HPCOKMAPCHB);
			} else {
				DEMNDPFILGG (dBHHFILLFLC);
			}
		}
		return;
	}
	Debug.LogError ("Failed to refresh player presence: " + DAKCKPMBKFF);
}
```

</details>

---

## GET `api/presence/v2/setscreenmode`

*first seen: 2018-07-13_17-30-36 — last seen: 2018-08-10_22-16-20 (10 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/presence/v3/heartbeat`

*first seen: 2018-09-27_21-32-54 — last seen: 2018-12-06_21-26-17 (14 builds)*

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
OKBCAHBFJBL: false
```

</details>

---

