# Avatar

## ConsumeGiftPackage

**POST** `api/avatar/v1/gifts/consume/`

*(first seen: 2016-11-23_01-26-08, last seen: 2016-11-29_21-32-10)*

**Body:** Form

| Field | Value |
|-------|-------|
| `Id` | `gift.Id` |
| `PlayerId` | `profile.Id.ToString ()` |

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
callback
```

---

## CreateGiftPackage

**POST** `api/avatar/v1/gifts/create/profile.Id.ToString ()`

*(first seen: 2016-11-23_01-26-08, last seen: 2016-11-29_21-32-10)*

**Body:** Form

| Field | Value |
|-------|-------|
| `AvatarItemDesc` | `string` |
| `Xp` | `xp.ToString ()` |

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
callback
```

---

## DowloadGiftPackages

**GET** `api/avatar/v1/gifts/Profile.LocalProfile.Id.ToString ()`

*(first seen: 2016-11-23_01-26-08, last seen: 2016-11-29_21-32-10)*

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(WWW www) {
	if (string.IsNullOrEmpty (www.error)) {
		List<GiftPackage> list = ParseGiftPackages (www.text);
		if (list != null) {
			GiftPackages = list;
			callback (null);
		} else {
			Debug.LogError ("Gift packages parse error : " + www.text);
			callback ("Gift packages parse error");
		}
	} else {
		callback (www.error);
	}
}
```

---

## DowloadUnlockedAvatarItems

**GET** `api/avatar/v1/items/recnetProfileId`

*(first seen: 2016-11-08_22-55-23, last seen: 2016-11-16_19-34-45)*

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(WWW www) {
	if (string.IsNullOrEmpty (www.error)) {
		List<object> list = ParseUnlockedSelectionsMap (www.text);
		if (list != null) {
			callback2 (null, list);
		} else {
			callback2 ("Unlocked avatar items parse error", null);
		}
	} else {
		callback2 (www.error, null);
	}
}
```

---

## DowloadUnlockedAvatarItems

**GET** `api/avatar/v2/items/recnetProfileId`

*(first seen: 2016-11-23_01-26-08, last seen: 2016-11-29_21-32-10)*

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(WWW www) {
	if (string.IsNullOrEmpty (www.error)) {
		List<OutfitSelection> list = ParseUnlockedSelectionsMap (www.text);
		if (list != null) {
			callback2 (null, list);
		} else {
			callback2 ("Unlocked avatar items parse error", null);
		}
	} else {
		callback2 (www.error, null);
	}
}
```

---

## GetSetting

**GET** `api/avatar/v1/id`

*(first seen: 2016-11-08_22-55-23, last seen: 2016-11-29_21-32-10)*

**Expected Response:**

200 JSON
```json
{
  "OutfitSelections": string,
  "HairColor": string,
  "SkinColor": string,
}
```

**Callback(s):**
```cs
private static Core.ApiCallback ParseAvatarCallback (GetAvatarCallback callback)
{
	return delegate(WWW www) {
		Avatar avatar = ((!string.IsNullOrEmpty (www.error)) ? null : ParseAvatar (www.text));
		callback (www.error, avatar);
	};
}

```

---

## SaveSetting

**POST** `api/avatar/v1/set`

*(first seen: 2016-11-08_22-55-23, last seen: 2016-11-29_21-32-10)*

**Body:** Form

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(WWW www) {
	callback (www.error);
}
```

---

## Unlock

**POST** `api/avatar/v1/items/create`

*(first seen: 2016-11-08_22-55-23, last seen: 2016-11-29_21-32-10)*

**Body:** Form

| Field | Value |
|-------|-------|
| `AvatarItemDesc` | `string` |
| `UnlockedLevel` | `int` |
| `PlayerId` | `profile.Id.ToString ()` |

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
callback
```

---

