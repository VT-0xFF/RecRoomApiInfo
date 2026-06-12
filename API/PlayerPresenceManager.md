# PlayerPresenceManager

## RefreshCachedPlayerPresence

**GET** `api/presence/v1/profileId`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Expected Response:**

200 Unhandled response content

**Callback(s):**
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

---

## RefreshCachedPlayerPresences

**POST** `api/presence/v1/list`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Body:** Form

**Expected Response:**

200 Unhandled response content

**Callback(s):**
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

---

## UpdatePlayerPresence

**POST** `api/presence/v2`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Body:** Form

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(string error) {
	if (!string.IsNullOrEmpty (error)) {
		Debug.LogError ("Failed to update player presence: " + error);
	}
}
```

---

