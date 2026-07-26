# Images

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## POST `api/images/v1/cheer`

*first seen: 2019-03-14_23-23-50 — last seen: 2021-08-06_06-02-59 (105 builds)*

**Declared by:** `<>c__DisplayClass48_0.CheerImage`, `Images.CheerImage`

**Request body:** RecNet.Images.ImageCheerRequestDTO

**Response:**

`200 OK` — JSON `Images+ImageCheerRequestDTO` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/images/v1/deletesaved`

*first seen: 2017-05-20_00-29-28 — last seen: 2021-08-06_06-02-59 (128 builds)*

**Declared by:** `<>c__DisplayClass48_0.DeleteSavedImage`, `<DownloadAndCacheImage>c__AnonStorey17F.ELNCDLJECNP`, `<DownloadAndCacheImage>c__AnonStorey180.ELNCDLJECNP`, `Images.DeleteSavedImage`

**Request body:** RecNet.EHGDGFBEMJF.MDGHHNGHILI

**Response:**

`200 OK` — JSON `EHGDGFBEMJF+MDGHHNGHILI` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
JOINLHEALDL
```

</details>

---

## POST `api/images/v1/deletetransient`

*first seen: 2017-05-20_00-29-28 — last seen: 2017-05-23_19-12-22 (4 builds)*

**Declared by:** `<DownloadAndCacheImage>c__AnonStorey17F.ACIMNLJKKPN`, `<DownloadAndCacheImage>c__AnonStorey180.ACIMNLJKKPN`

**Request body:** RecNet.EHGDGFBEMJF.MDGHHNGHILI

**Response:**

`200 OK` — JSON `EHGDGFBEMJF+MDGHHNGHILI` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
JOINLHEALDL
```

</details>

---

## GET `api/images/v1/listsaved`

*first seen: 2017-05-20_00-29-28 — last seen: 2021-08-06_06-02-59 (128 builds)*

**Declared by:** `<>c__DisplayClass48_0.GetSavedImageList`, `<DownloadAndCacheImage>c__AnonStorey17F.CHGBEOFIPBO`, `<DownloadAndCacheImage>c__AnonStorey180.CHGBEOFIPBO`, `Images.GetSavedImageList`

**Response:**

`200 OK` — JSON `EHGDGFBEMJF+OMDAOHGDFPA` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF, OMDAOHGDFPA DKBBNNEBKMO) {
	List<string> dKBBNNEBKMO = DKBBNNEBKMO?.EHGDGFBEMJF;
	HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, dKBBNNEBKMO);
}
```

</details>

---

## POST `api/images/v1/modifyaccessibility`

*first seen: 2018-02-01_20-04-59 — last seen: 2021-08-06_06-02-59 (120 builds)*

**Declared by:** `<>c__DisplayClass48_0.ModifySavedImageAccessibility`, `Images.ModifySavedImageAccessibility`

**Request body:** RecNet.Images.SavedImageAccessibilityDTO

**Response:**

`200 OK` — JSON `Images+SavedImageAccessibilityDTO` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/images/v1/named?img={param}`

*first seen: 2017-12-15_01-29-10 — last seen: 2018-04-13_22-58-42 (19 builds)*

**URI parameters:** `param`

**Request body:** System.Boolean

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
jOINLHEALDL
```

</details>

---

## POST `api/images/v1/profile/{Id}`

*first seen: 2016-10-26_20-30-17 — last seen: 2017-03-17_19-39-02 (11 builds)*

**Declared by:** `<GetCoroutine>c__IteratorE1.BBLMCMCIPEL`, `<GetCoroutine>c__IteratorE2.BBLMCMCIPEL`, `Images.SetLocalProfileImage`

**URI parameters:** `param`

**Request body:** application/json

**Response:**

`200 OK` — JSON `JNOIJBMICPI` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
delegate(string HJLPPIBIGNJ, JNOIJBMICPI IHDJJHKDMCF) {
	KOKPFFFFMCB.Remove (GDAMLBILGPM);
	if (!string.IsNullOrEmpty (HJLPPIBIGNJ)) {
		Debug.LogError ("Failed to download profile image: " + HJLPPIBIGNJ);
	} else if (!IHDJJHKDMCF.KJOOEHDLLMA) {
		if (!PKBEMJCLPPG.TryGetValue (GDAMLBILGPM, out GMECINKCKEM)) {
			GMECINKCKEM = new CHKKJIKNMPA ();
			PKBEMJCLPPG.Add (GDAMLBILGPM, GMECINKCKEM);
		}
		GMECINKCKEM.JDPIPAIKIGN = IHDJJHKDMCF.FPFNIMNLNDE;
		try {
			if (GMECINKCKEM.AHCODLLEOGF == null) {
				GMECINKCKEM.AHCODLLEOGF = new Texture2D (1, 1);
			}
			GMECINKCKEM.AHCODLLEOGF.LoadImage (IHDJJHKDMCF.ONPAGMGBEMC);
		} catch (Exception exception) {
			Debug.LogException (exception);
			UnityEngine.Object.Destroy (GMECINKCKEM.AHCODLLEOGF);
			GMECINKCKEM.AHCODLLEOGF = null;
		}
		BJJAIFAPMAC (GDAMLBILGPM);
	}
}
```

</details>

---

## GET `api/images/v1/profile/{id}`

*first seen: 2016-10-26_20-30-17 — last seen: 2017-02-03_23-53-02 (21 builds)*

**Declared by:** `Images.GetProfileImage`

**URI parameters:** `id`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
delegate(WWW www) {
	callback (www.error, www.bytes);
}
```

</details>

---

## POST `api/images/v1/sendlink`

*first seen: 2017-05-20_00-29-28 — last seen: 2021-08-06_06-02-59 (128 builds)*

**Declared by:** `<>c__DisplayClass48_0.SendImageLink`, `<DownloadAndCacheImage>c__AnonStorey17F.JPIMNCBHPKG`, `<DownloadAndCacheImage>c__AnonStorey180.JPIMNCBHPKG`, `Images.SendImageLink`

**Request body:** RecNet.EHGDGFBEMJF.MDGHHNGHILI

**Response:**

`200 OK` — JSON `EHGDGFBEMJF+MDGHHNGHILI` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
JOINLHEALDL
```

</details>

---

## GET `api/images/v1/slideshow`

*first seen: 2019-04-23_15-25-47 — last seen: 2021-08-06_06-02-59 (102 builds)*

**Declared by:** `Images.GetCurrentSlideshowInfo`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/images/v1/uploadsaved`

*first seen: 2017-05-20_00-29-28 — last seen: 2017-05-23_19-12-22 (4 builds)*

**Declared by:** `<DownloadAndCacheImage>c__AnonStorey17F.HCPNLDECBBE`, `<DownloadAndCacheImage>c__AnonStorey180.HCPNLDECBBE`

**Request body:** WWWForm (application/x-www-form-urlencoded)

| Field | Type |
|-------|------|
| `image` | `byte[]` |

**Response:**

`200 OK` — JSON `EHGDGFBEMJF+MDGHHNGHILI` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF, MDGHHNGHILI DKBBNNEBKMO) {
	string dKBBNNEBKMO = DKBBNNEBKMO?.GAKPGOHFAHD;
	HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, dKBBNNEBKMO);
}
```

</details>

---

## POST `api/images/v1/uploadtransient?gameSessionId={param}`

*first seen: 2017-05-20_00-29-28 — last seen: 2017-05-23_19-12-22 (4 builds)*

**Declared by:** `<DownloadAndCacheImage>c__AnonStorey17F.EPOJJIOBPCN`, `<DownloadAndCacheImage>c__AnonStorey180.EPOJJIOBPCN`

**URI parameters:** `param`

**Request body:** WWWForm (application/x-www-form-urlencoded)

| Field | Type |
|-------|------|
| `image` | `byte[]` |

**Response:**

`200 OK` — JSON `EHGDGFBEMJF+MDGHHNGHILI` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF, MDGHHNGHILI DKBBNNEBKMO) {
	string dKBBNNEBKMO = DKBBNNEBKMO?.GAKPGOHFAHD;
	HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, dKBBNNEBKMO);
}
```

</details>

---

## POST `api/images/v1/{CS8__locals3}/report`

*first seen: 2020-12-18_20-04-40 — last seen: 2021-08-06_06-02-59 (15 builds)*

**URI parameters:** `CS8__locals3`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num != 0
```

</details>

---

## POST `api/images/v2/deletetransient`

*first seen: 2017-12-15_01-29-10 — last seen: 2019-07-23_13-56-01 (35 builds)*

**Declared by:** `<>c__DisplayClass48_0.DeleteTransientImage`, `Images.DeleteTransientImage`

**Request body:** RecNet.Images.ImageNameDTO

**Response:**

`200 OK` — JSON `Images+ImageNameDTO` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/images/v2/named`

*first seen: 2019-03-14_23-23-50 — last seen: 2021-08-06_06-02-59 (103 builds)*

**Declared by:** `<>c__DisplayClass48_0.DownloadNamedImageMappings`, `Images.DownloadNamedImageMappings`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num != 0
```

</details>

---

## POST `api/images/v2/profile`

*first seen: 2016-12-09_03-11-41 — last seen: 2017-05-23_19-12-22 (36 builds)*

**Declared by:** `<DownloadAndCacheImage>c__AnonStorey14C.PCNGBLGIFBF`, `<DownloadAndCacheImage>c__AnonStorey14E.PCNGBLGIFBF`, `<DownloadAndCacheImage>c__AnonStorey151.PCNGBLGIFBF`, `<DownloadAndCacheImage>c__AnonStorey152.KJDOKNGILOP`, `<DownloadAndCacheImage>c__AnonStorey153.PCNGBLGIFBF`, `<DownloadAndCacheImage>c__AnonStorey156.KJDOKNGILOP`, `<DownloadAndCacheImage>c__AnonStorey157.KJDOKNGILOP`, `<DownloadAndCacheImage>c__AnonStorey168.KJDOKNGILOP`, `<DownloadAndCacheImage>c__AnonStorey16A.KJDOKNGILOP`, `<DownloadAndCacheImage>c__AnonStorey17F.KJDOKNGILOP`, `<DownloadAndCacheImage>c__AnonStorey180.KJDOKNGILOP`, `<GetCoroutine>c__IteratorE1.PCNGBLGIFBF`, `<GetCoroutine>c__IteratorE2.PCNGBLGIFBF`, `Images.SetLocalProfileImage`

**Request body:** WWWForm (application/x-www-form-urlencoded)

| Field | Type |
|-------|------|
| `image` | `byte[]` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
delegate(string error) {
	RefreshCachedProfileImage (Profiles.LocalProfile.Id);
	Core.SafeInvoke (callback, error);
}
```

</details>

---

## POST `api/images/v2/send`

*first seen: 2017-10-02_18-15-46 — last seen: 2017-10-02_18-15-46 (1 builds)*

**Request body:** WWWForm (application/x-www-form-urlencoded)

| Field | Type |
|-------|------|
| `http://j.mp/1gxg1tf` | `byte[]` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
JOINLHEALDL
```

</details>

---

## POST `api/images/v3/profile`

*first seen: 2017-12-15_01-29-10 — last seen: 2018-04-13_22-58-42 (19 builds)*

**Request body:** WWWForm (application/x-www-form-urlencoded)

| Field | Type |
|-------|------|
| `image` | `string` |
| `altimage` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
JOINLHEALDL
```

</details>

---

## POST `api/images/v3/uploadsaved`

*first seen: 2018-02-01_20-04-59 — last seen: 2018-04-13_22-58-42 (15 builds)*

**Request body:** BestHTTP.Forms.EAFJIFILMAF

**Response:**

`200 OK` — JSON `EHGDGFBEMJF+MDGHHNGHILI` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF, MDGHHNGHILI DKBBNNEBKMO) {
	string text = DKBBNNEBKMO?.GAKPGOHFAHD;
	bool flag = FKJHLNJDEKK.LECFBEBMLIC == null || ObscuredBool.EDHNDLCFIOL (FKJHLNJDEKK.LECFBEBMLIC.JMMJGMOBGJM);
	BLJJLANALAD [text] = ((!flag) ? KIBIPLAPDAH.mainImage : KIBIPLAPDAH.altImage);
	HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, text);
}
```

</details>

---

## POST `api/images/v4/profile`

*first seen: 2019-03-14_23-23-50 — last seen: 2019-11-12_15-10-55 (39 builds)*

**Declared by:** `<>c.<SetLocalProfileImage>b__35_0`, `Images.<SetLocalProfileImage>b__35_0`, `Images.<SetLocalProfileImage>b__39_0`, `Images.<SetLocalProfileImage>b__41_0`, `Images.<SetLocalProfileImage>b__43_0`

**Request body:** BestHTTP.Forms.HTTPMultiPartForm

| Field | Type |
|-------|------|
| `image` | `byte[]` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `https://recroom.azurewebsites.net/api/images/v1/profile/{Id}`

*first seen: 2016-09-08_01-33-59 — last seen: 2016-10-18_01-49-40 (8 builds)*

**Declared by:** `<UpdateLocalPlayerModelCoroutine>c__Iterator89.GetPlayerImage`, `<UpdateLocalPlayerModelCoroutine>c__Iterator8B.GetPlayerImage`, `<UpdateLocalPlayerModelCoroutine>c__IteratorAA.GetPlayerImage`, `<UpdateLocalPlayerModelCoroutine>c__IteratorAF.GetPlayerImage`

**URI parameters:** `Id`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
delegate(WWW www) {
	callback (www.error, www.bytes);
}
```

</details>

---

## POST `https://recroom.azurewebsites.net/api/images/v1/profile/{Id}`

*first seen: 2016-09-08_01-33-59 — last seen: 2016-10-18_01-49-40 (8 builds)*

**Declared by:** `<UpdateLocalPlayerModelCoroutine>c__Iterator89.SetLocalPlayerImage`, `<UpdateLocalPlayerModelCoroutine>c__Iterator8B.SetLocalPlayerImage`, `<UpdateLocalPlayerModelCoroutine>c__IteratorAA.SetLocalPlayerImage`, `<UpdateLocalPlayerModelCoroutine>c__IteratorAF.SetLocalPlayerImage`

**URI parameters:** `Id`

**Request body:** WWWForm (application/x-www-form-urlencoded)

| Field | Type |
|-------|------|
| `image` | `byte[]` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
null
```

</details>

---

