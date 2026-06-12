# PlayerPresence

## RefreshCachedPlayerPresence

**GET** `api/presence/v1/profileId`

*(first seen: 2016-11-23_01-26-08, last seen: 2016-11-29_21-32-10)*

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(WWW www) {
	if (string.IsNullOrEmpty (www.error)) {
		PlayerPresence playerPresence = ParseSingle (www.text);
		if (playerPresence == null) {
			playerPresenceCache.Remove (profileId);
		} else {
			playerPresenceCache [profileId] = playerPresence;
		}
		RaisePlayerPresenceUpdatedEvent (profileId, playerPresence);
	} else {
		Debug.LogError ("Failed to refresh player presence: " + www.error);
	}
}
```

---

## RefreshCachedPlayerPresences

**POST** `api/presence/v1/list`

*(first seen: 2016-11-23_01-26-08, last seen: 2016-11-29_21-32-10)*

**Body:** Form

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(WWW www) {
	if (string.IsNullOrEmpty (www.error)) {
		List<PlayerPresence> list = ParseArray (www.text);
		if (list != null) {
			foreach (ulong id in profileIds) {
				PlayerPresence playerPresence = list.FirstOrDefault ((PlayerPresence p) => p.PlayerId == id);
				if (playerPresence == null) {
					playerPresenceCache.Remove (id);
				} else {
					playerPresenceCache [id] = playerPresence;
				}
				RaisePlayerPresenceUpdatedEvent (id, playerPresence);
			}
		}
	} else {
		Debug.LogError ("Failed to refresh player presence: " + www.error);
	}
}
```

---

## UpdatePlayerPresence

**POST** `api/presence/v1/Profile.LocalProfile.Id`

*(first seen: 2016-11-23_01-26-08, last seen: 2016-11-29_21-32-10)*

**Body:** Form

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(WWW www) {
	if (!string.IsNullOrEmpty (www.error)) {
		Debug.LogError ("Failed to update player presence: " + www.error);
	}
}
```

---

