# Avatar

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## GET `api/avatar/v1/defaultunlocked`

*first seen: 2021-04-15_02-51-29 — last seen: 2021-08-06_06-02-59 (16 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num != 0
```

</details>

---

## POST `api/avatar/v1/gifts/consume/`

*first seen: 2016-11-23_01-26-08 — last seen: 2016-11-29_21-32-10 (3 builds)*

**Declared by:** `Avatar.ConsumeGiftPackage`

**Request body:** WWWForm (application/x-www-form-urlencoded)

| Field | Type |
|-------|------|
| `Id` | `string` |
| `PlayerId` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
callback
```

</details>

---

## POST `api/avatar/v1/gifts/create/{Id}`

*first seen: 2016-11-23_01-26-08 — last seen: 2016-11-29_21-32-10 (3 builds)*

**Declared by:** `Avatar.CreateGiftPackage`

**URI parameters:** `Id`

**Request body:** WWWForm (application/x-www-form-urlencoded)

| Field | Type |
|-------|------|
| `AvatarItemDesc` | `string` |
| `Xp` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
callback
```

</details>

---

## POST `api/avatar/v1/gifts/requestDrop`

*first seen: 2017-07-11_00-44-03 — last seen: 2018-04-05_19-22-43 (46 builds)*

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `GiftContext` | `string` |
| `GiftDropId` | `string` |
| `Message` | `string` |

**Response:**

`200 OK` — JSON `IOIGNLEIABB+PGMLKNLPFJM` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF, PGMLKNLPFJM DPKOIHELCFF) {
	COBMJACLDOL (DAKCKPMBKFF, DPKOIHELCFF, JOINLHEALDL);
}
```

</details>

---

## GET `api/avatar/v1/gifts/{Id}`

*first seen: 2016-11-23_01-26-08 — last seen: 2016-11-29_21-32-10 (3 builds)*

**Declared by:** `Avatar.DowloadGiftPackages`

**URI parameters:** `Id`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

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

</details>

---

## POST `api/avatar/v1/items/create`

*first seen: 2016-11-08_22-55-23 — last seen: 2016-11-29_21-32-10 (6 builds)*

**Declared by:** `Avatar.Unlock`

**Request body:** WWWForm (application/x-www-form-urlencoded)

| Field | Type |
|-------|------|
| `AvatarItemDesc` | `string` |
| `UnlockedLevel` | `int` |
| `PlayerId` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
callback
```

</details>

---

## GET `api/avatar/v1/items/{recnetProfileId}`

*first seen: 2016-11-08_22-55-23 — last seen: 2016-11-16_19-34-45 (3 builds)*

**Declared by:** `Avatar.DowloadUnlockedAvatarItems`

**URI parameters:** `recnetProfileId`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

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

</details>

---

## GET `api/avatar/v1/saved`

*first seen: 2018-05-09_19-37-59 — last seen: 2018-06-22_00-34-04 (11 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
HEGFLJKILKM: false
```

</details>

---

## POST `api/avatar/v1/saved`

*first seen: 2017-12-15_01-29-10 — last seen: 2018-05-04_20-50-17 (23 builds)*

**Request body:** System.Boolean

**Response:**

`200 OK` — JSON `AMCAHFINIJM`

```json
{
  "Slot": int,
  "PreviewImageName": string,
  "OutfitSelections": string,
  "HairColor": string,
  "SkinColor": string
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `Slot` | `int` | `CLDOJNJEEIA` |
| `PreviewImageName` | `string` | `GLABJEFIIHO` |
| `OutfitSelections` | `string` | `PAKHCIDILIE` |
| `HairColor` | `string` | `FABLGOLJOHB` |
| `SkinColor` | `string` | `LANLCJKDHPL` |

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF, List<AMCAHFINIJM> CFDDDDCPOKP) {
	if (string.IsNullOrEmpty (DAKCKPMBKFF)) {
		foreach (AMCAHFINIJM item in CFDDDDCPOKP) {
			DLKOOCEALHE [item.CLDOJNJEEIA] = item;
		}
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, null);
	} else {
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, "Failed to download saved outfits : " + DAKCKPMBKFF);
	}
}
```

</details>

---

## POST `api/avatar/v1/saved/set`

*first seen: 2017-12-15_01-29-10 — last seen: 2018-06-22_00-34-04 (34 builds)*

**Request body:** RecNet.AMCAHFINIJM

**Response:**

`200 OK` — JSON `AMCAHFINIJM`

```json
{
  "Slot": int,
  "PreviewImageName": string,
  "OutfitSelections": string,
  "HairColor": string,
  "SkinColor": string
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `Slot` | `int` | `CLDOJNJEEIA` |
| `PreviewImageName` | `string` | `GLABJEFIIHO` |
| `OutfitSelections` | `string` | `PAKHCIDILIE` |
| `HairColor` | `string` | `FABLGOLJOHB` |
| `SkinColor` | `string` | `LANLCJKDHPL` |

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF) {
	if (string.IsNullOrEmpty (DAKCKPMBKFF)) {
		if (DLKOOCEALHE.ContainsKey (BHADEOGHJEJ.CLDOJNJEEIA)) {
			DLKOOCEALHE.Remove (BHADEOGHJEJ.CLDOJNJEEIA);
		}
		DLKOOCEALHE [BHADEOGHJEJ.CLDOJNJEEIA] = BHADEOGHJEJ;
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, null);
	} else {
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, "Failed to save outfit ");
	}
}
```

</details>

---

## POST `api/avatar/v1/set`

*first seen: 2016-11-08_22-55-23 — last seen: 2016-11-29_21-32-10 (6 builds)*

**Declared by:** `Avatar.SaveSetting`

**Request body:** System.Byte[]

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
delegate(WWW www) {
	callback (www.error);
}
```

</details>

---

## GET `api/avatar/v1/{id}`

*first seen: 2016-11-08_22-55-23 — last seen: 2016-11-29_21-32-10 (6 builds)*

**Declared by:** `Avatar.GetSetting`

**URI parameters:** `id`

**Response:**

`200 OK` — JSON `Avatar`

```json
{
  "OutfitSelections": string,
  "HairColor": string,
  "SkinColor": string
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `OutfitSelections` | `string` | `avatar.OutfitSelections` |
| `HairColor` | `string` | `avatar.HairColor` |
| `SkinColor` | `string` | `avatar.SkinColor` |

<details><summary>Client-side callback</summary>

```cs
private static Core.ApiCallback ParseAvatarCallback (GetAvatarCallback callback)
{
	return delegate(WWW www) {
		Avatar avatar = ((!string.IsNullOrEmpty (www.error)) ? null : ParseAvatar (www.text));
		callback (www.error, avatar);
	};
}
```

</details>

---

## GET `api/avatar/v2`

*first seen: 2016-12-09_03-11-41 — last seen: 2021-08-06_06-02-59 (175 builds)*

**Declared by:** `Avatars.DownloadLocalAvatar`

**Response:**

`200 OK` — JSON `Avatar`

```json
{
  "OutfitSelections": string,
  "HairColor": string,
  "SkinColor": string
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `OutfitSelections` | `string` | `OutfitSelections` |
| `HairColor` | `string` | `HairColor` |
| `SkinColor` | `string` | `SkinColor` |

<details><summary>Client-side callback</summary>

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

</details>

---

## POST `api/avatar/v2`

*first seen: 2017-02-22_19-52-07 — last seen: 2018-05-04_20-50-17 (88 builds)*

**Request body:** System.Boolean

**Response:**

`200 OK` — JSON `HKJEONFHLGO`

```json
{
  "RelationshipType": string,
  "movetopath": string,
  "empty": string
}
```

<details><summary>Client-side callback</summary>

```cs
delegate(string GHJBJJPHNHD, HKJEONFHLGO HDBKDBPCJFI) {
	if (string.IsNullOrEmpty (GHJBJJPHNHD)) {
		HJOKHHEHIFK = HDBKDBPCJFI;
		BFEONIELEAH.FOBBKGGGEKD (ADHBNDGBJCE, null);
	} else {
		UnityEngine.Debug.LogError ("Failed to load Rec Room player avatar settings: " + GHJBJJPHNHD);
		BFEONIELEAH.FOBBKGGGEKD (ADHBNDGBJCE, "Failed to load Rec Room player avatar settings");
	}
}
```

</details>

---

## POST `api/avatar/v2/delete`

*first seen: 2017-03-13_23-52-18 — last seen: 2017-03-17_19-39-02 (2 builds)*

**Declared by:** `<GetCoroutine>c__IteratorE1.HJCACEHIDMF`, `<GetCoroutine>c__IteratorE2.CGLICACCHBB`

**Request body:** WWWForm (application/x-www-form-urlencoded)

| Field | Type |
|-------|------|
| `VRDeviceName` | `byte[]` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
delegate(string HJLPPIBIGNJ) {
	BEJAAHBJOMG (COGCNMJCNKN.FKNANEKOEEP ());
	COGCNMJCNKN.BFNFLFBCDCC (EGOJDIFBGAF, HJLPPIBIGNJ);
}
```

</details>

---

## GET `api/avatar/v2/gifts`

*first seen: 2016-12-09_03-11-41 — last seen: 2021-08-06_06-02-59 (175 builds)*

**Declared by:** `Avatars.DowloadGiftPackages`

**Response:**

`200 OK` — JSON `Avatars+GiftPackage` (schema not recovered)

<details><summary>Client-side callback</summary>

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

</details>

---

## POST `api/avatar/v2/gifts`

*first seen: 2017-02-22_19-52-07 — last seen: 2018-05-04_20-50-17 (88 builds)*

**Request body:** System.Boolean

**Response:**

`200 OK` — JSON `MOAOFCHIAKJ+OEBDCPDFCEM` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
delegate(string GHJBJJPHNHD, List<OEBDCPDFCEM> ODKMANJEBGL) {
	if (string.IsNullOrEmpty (GHJBJJPHNHD)) {
		JMDDFBEAPHI = ODKMANJEBGL;
		BFEONIELEAH.FOBBKGGGEKD (ADHBNDGBJCE, null);
	} else {
		UnityEngine.Debug.LogError ("Failed to download gifts: " + GHJBJJPHNHD);
		BFEONIELEAH.FOBBKGGGEKD (ADHBNDGBJCE, "Failed to download gifts");
	}
}
```

</details>

---

## POST `api/avatar/v2/gifts/consume/`

*first seen: 2016-12-09_03-11-41 — last seen: 2021-08-06_06-02-59 (256 builds)*

**Declared by:** `<LocalConsumeGiftPackage>c__IteratorAC.MoveNext`, `<LocalConsumeGiftPackage>c__IteratorAD.MoveNext`, `<LocalConsumeGiftPackage>c__IteratorBF.MoveNext`, `<LocalConsumeGiftPackage>c__IteratorDA.MoveNext`, `<LocalConsumeGiftPackage>c__IteratorE2.MoveNext`, `<LocalConsumeGiftPackage>c__IteratorE4.MoveNext`, `<LocalConsumeGiftPackage>c__IteratorE8.MoveNext`, `<LocalConsumeGiftPackage>c__IteratorE9.MoveNext`, `<LocalConsumeGiftPackage>c__IteratorF5.MoveNext`, `<LocalConsumeGiftPackage>c__IteratorF6.MoveNext`, `<LocalConsumeGiftPackage>c__IteratorF7.MoveNext`, `Avatars.LocalConsumeGiftPackage`, `Avatars.MoveNext`

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `Id` | `string` |
| `UnlockedLevel` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

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

</details>

---

## POST `api/avatar/v2/gifts/create`

*first seen: 2016-12-09_03-11-41 — last seen: 2017-04-14_23-03-37 (35 builds)*

**Declared by:** `Avatars.LocalCreateGiftPackage`

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `AvatarItemDesc` | `string` |
| `Xp` | `string` |

**Response:**

`200 OK` — JSON `Avatars+GiftPackage` (schema not recovered)

<details><summary>Client-side callback</summary>

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

</details>

---

## POST `api/avatar/v2/gifts/generate`

*first seen: 2017-04-20_22-49-30 — last seen: 2021-08-06_06-02-59 (221 builds)*

**Declared by:** `Avatars.LocalRequestGiftPackage`

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `PackageType` | `string` |
| `GiftContext` | `string` |
| `Message` | `string` |

**Response:**

`200 OK` — JSON `IOIGNLEIABB+PGMLKNLPFJM` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF, PGMLKNLPFJM DPKOIHELCFF) {
	if (string.IsNullOrEmpty (DAKCKPMBKFF)) {
		if (!GPCCMPENICN.Contains (DPKOIHELCFF)) {
			GPCCMPENICN.Add (DPKOIHELCFF);
			HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, null, DPKOIHELCFF);
		} else {
			HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, "Generated duplicate gift!", null);
		}
	} else {
		UnityEngine.Debug.LogError ("Failed to generate new gift: " + DAKCKPMBKFF);
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, "Failed to generate new gift.", null);
	}
}
```

</details>

---

## GET `api/avatar/v2/items/{recnetProfileId}`

*first seen: 2016-11-23_01-26-08 — last seen: 2016-11-29_21-32-10 (3 builds)*

**Declared by:** `Avatar.DowloadUnlockedAvatarItems`

**URI parameters:** `recnetProfileId`

**Response:**

`200 OK` — JSON `UnlockedSelectionsMap`

```json
{
  "AvatarItemDesc": string,
  "UnlockedLevel": int
}
```

<details><summary>Client-side callback</summary>

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

</details>

---

## GET `api/avatar/v2/saved`

*first seen: 2018-07-13_17-30-36 — last seen: 2018-07-20_20-10-36 (4 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
HEGFLJKILKM: false
```

</details>

---

## POST `api/avatar/v2/saved/set`

*first seen: 2018-07-13_17-30-36 — last seen: 2018-07-20_20-10-36 (4 builds)*

**Request body:** RecNet.AMCAHFINIJM

**Response:**

`200 OK` — JSON `AMCAHFINIJM`

```json
{
  "Slot": int,
  "PreviewImageName": string,
  "OutfitSelections": string
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `Slot` | `int` | `CLDOJNJEEIA` |
| `PreviewImageName` | `string` | `GLABJEFIIHO` |
| `OutfitSelections` | `string` | `PAKHCIDILIE` |

<details><summary>Client-side callback</summary>

```cs
HEGFLJKILKM: false
```

</details>

---

## POST `api/avatar/v2/set`

*first seen: 2016-12-09_03-11-41 — last seen: 2021-08-06_06-02-59 (263 builds)*

**Declared by:** `Avatars.SaveLocalAvatarSettings`

**Request body:** RecNet.Avatar

**Response:**

`200 OK` — JSON `Avatar`

```json
{
  "OutfitSelections": string,
  "HairColor": string,
  "SkinColor": string,
  "FaceFeatures": string
}
```

<details><summary>Client-side callback</summary>

```cs
(byte)num != 0
```

</details>

---

## POST `api/avatar/v3/gifts/generate`

*first seen: 2020-11-17_03-57-26 — last seen: 2021-08-06_06-02-59 (27 builds)*

**Request body:** System.Collections.Generic.IEnumerable

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num2 != 0
```

</details>

---

## GET `api/avatar/v3/items`

*first seen: 2016-12-09_03-11-41 — last seen: 2019-09-10_14-23-19 (81 builds)*

**Declared by:** `<DowloadUnlockedAvatarItems>c__IteratorAD.MoveNext`, `<DowloadUnlockedAvatarItems>c__IteratorAE.MoveNext`, `Avatars.DowloadUnlockedAvatarItems`, `Avatars.MoveNext`

**Response:**

`200 OK` — JSON `Avatars+UnlockedAvatarItem` (schema not recovered)

<details><summary>Client-side callback</summary>

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

</details>

---

## POST `api/avatar/v3/items`

*first seen: 2017-02-22_19-52-07 — last seen: 2018-05-04_20-50-17 (88 builds)*

**Declared by:** `<DowloadUnlockedAvatarItems>c__IteratorC0.MoveNext`, `<DowloadUnlockedAvatarItems>c__IteratorDB.MoveNext`, `<DowloadUnlockedAvatarItems>c__IteratorE3.MoveNext`, `<DowloadUnlockedAvatarItems>c__IteratorE5.MoveNext`, `<DowloadUnlockedAvatarItems>c__IteratorE9.MoveNext`, `<DowloadUnlockedAvatarItems>c__IteratorEA.MoveNext`, `<DowloadUnlockedAvatarItems>c__IteratorF6.MoveNext`, `<DowloadUnlockedAvatarItems>c__IteratorF7.MoveNext`, `<DowloadUnlockedAvatarItems>c__IteratorF8.MoveNext`

**Request body:** System.Boolean

**Response:**

`200 OK` — JSON `MOAOFCHIAKJ+KODMOLPDANI` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
internal void LANIJAAOAJF (string GHJBJJPHNHD, List<KODMOLPDANI> DKIBCKJFDEK)
{
	if (string.IsNullOrEmpty (GHJBJJPHNHD)) {
		List<OutfitSelection> list = new List<OutfitSelection> (DKIBCKJFDEK.Count);
		foreach (KODMOLPDANI item in DKIBCKJFDEK) {
			OutfitSelection outfitSelection = OutfitSelection.GGLDFHGKDHK (item.AFINBMHOGDM);
			if (OutfitSelection.PCLLDMMHNLD (outfitSelection, null)) {
				outfitSelection.UnlockedLevel = item.IJBCKGHPDON;
				list.Add (outfitSelection);
			}
		}
		BFEONIELEAH.FOBBKGGGEKD (ADHBNDGBJCE, null, list);
	} else {
		UnityEngine.Debug.LogError ("Failed to download unlocked avatar items: " + GHJBJJPHNHD);
		BFEONIELEAH.FOBBKGGGEKD (ADHBNDGBJCE, "Failed to download unlocked avatar items", null);
	}
}
```

</details>

---

## GET `api/avatar/v3/saved`

*first seen: 2018-07-26_22-13-12 — last seen: 2021-08-06_06-02-59 (144 builds)*

**Declared by:** `Avatars.DowloadSavedOutfitSlots`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num != 0
```

</details>

---

## POST `api/avatar/v3/saved/set`

*first seen: 2018-07-26_22-13-12 — last seen: 2021-08-06_06-02-59 (91 builds)*

**Request body:** RecNet.AMCAHFINIJM

**Response:**

`200 OK` — JSON `AMCAHFINIJM`

```json
{
  "Slot": int,
  "PreviewImageName": string,
  "OutfitSelections": string,
  "HairColor": string,
  "SkinColor": string,
  "FaceFeatures": string
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `Slot` | `int` | `CLDOJNJEEIA` |
| `PreviewImageName` | `string` | `GLABJEFIIHO` |
| `OutfitSelections` | `string` | `PAKHCIDILIE` |
| `HairColor` | `string` | `FABLGOLJOHB` |
| `SkinColor` | `string` | `LANLCJKDHPL` |
| `FaceFeatures` | `string` | `FOAJFEIIPOE` |

<details><summary>Client-side callback</summary>

```cs
HEGFLJKILKM: false
```

</details>

---

## GET `api/avatar/v4/items`

*first seen: 2019-09-17_14-26-51 — last seen: 2021-08-06_06-02-59 (94 builds)*

**Declared by:** `Avatars.MoveNext`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num != 0
```

</details>

---

