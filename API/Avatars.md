# Avatars

## DowloadGiftPackages

**GET** `api/avatar/v2/gifts`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(string error, List<GiftPackage> newGifts) {
	if (string.IsNullOrEmpty (error)) {
		GiftPackages = newGifts;
		Core.SafeInvoke (callback, null);
	} else {
		Debug.LogError ("Failed to download gifts: " + error);
		Core.SafeInvoke (callback, "Failed to download gifts");
	}
}
```

---

## DowloadUnlockedAvatarItems

**GET** `api/avatar/v3/items`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(string error, List<UnlockedAvatarItem> items) {
	if (string.IsNullOrEmpty (error)) {
		List<OutfitSelection> list = new List<OutfitSelection> (items.Count);
		foreach (UnlockedAvatarItem item in items) {
			OutfitSelection outfitSelection = OutfitSelection.Parse (item.AvatarItemDesc);
			if (outfitSelection != null) {
				outfitSelection.UnlockedLevel = item.UnlockedLevel;
				list.Add (outfitSelection);
			}
		}
		Core.SafeInvoke (callback2, null, list);
	} else {
		Debug.LogError ("Failed to download unlocked avatar items: " + error);
		Core.SafeInvoke (callback2, "Failed to download unlocked avatar items", null);
	}
}
```

---

## DownloadLocalAvatar

**GET** `api/avatar/v2`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(string error, Avatar avatar) {
	if (string.IsNullOrEmpty (error)) {
		LocalAvatar = avatar;
		Core.SafeInvoke (callback, null);
	} else {
		Debug.LogError ("Failed to load Rec Room player avatar settings: " + error);
		Core.SafeInvoke (callback, "Failed to load Rec Room player avatar settings");
	}
}
```

---

## LocalConsumeGiftPackage

**POST** `api/avatar/v2/gifts/consume/`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Body:** Form

| Field | Value |
|-------|-------|
| `Id` | `gift.Id.ToString ()` |
| `UnlockedLevel` | `unlockedLevel.ToString ()` |

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(string error) {
	if (string.IsNullOrEmpty (error)) {
		gift.Consumed = true;
		GiftPackages.RemoveAt (0);
		Core.SafeInvoke (callback, null);
	} else {
		Core.SafeInvoke (callback, error);
	}
}
```

---

## LocalCreateGiftPackage

**POST** `api/avatar/v2/gifts/create`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Body:** Form

| Field | Value |
|-------|-------|
| `AvatarItemDesc` | `string` |
| `Xp` | `xp.ToString ()` |

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(string error, GiftPackage newGift) {
	if (string.IsNullOrEmpty (error)) {
		if (!GiftPackages.Contains (newGift)) {
			GiftPackages.Add (newGift);
			Core.SafeInvoke (callback, null, newGift);
		} else {
			Core.SafeInvoke (callback, "Created duplicate gift!", null);
		}
	} else {
		Debug.LogError ("Failed to create new gift: " + error);
		Core.SafeInvoke (callback, "Failed to create new gift.", null);
	}
}
```

---

## SaveLocalAvatarSettings

**POST** `api/avatar/v2/set`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Body:** Form

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(string wwwError) {
	localAvatarSaveInProgress = false;
	if (!string.IsNullOrEmpty (wwwError)) {
		Debug.LogError ("Failed to upload Rec Room player avatar changes: " + wwwError);
		localAvatarSaveRequested = true;
	}
	if (localAvatarSaveRequested) {
		SaveLocalAvatarSettings ();
	}
}
```

---

