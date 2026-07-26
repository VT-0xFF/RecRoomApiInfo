# External

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## POST `http://docs.unity3d.com/ScriptReference/PlayerPrefs.html`

*first seen: 2017-04-14_23-03-37 — last seen: 2017-04-14_23-03-37 (1 builds)*

**Declared by:** `<DowloadLocalPlayerSettings>c__IteratorEC.BFCGEJLLNAO`

**Request body:** System.Boolean

**Response:**

`200 OK` — JSON `FOOKEGKHBOD`

```json
{
  "Key": string,
  "Value": string
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `Key` | `string` | `IEDGFJHOLGH` |
| `Value` | `string` | `ANKACHDHNCL` |

<details><summary>Client-side callback</summary>

```cs
internal void HPDLCCPNEMO (string DAKCKPMBKFF, List<FOOKEGKHBOD> OGICBDLPIJO)
{
	if (string.IsNullOrEmpty (DAKCKPMBKFF)) {
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, null, OGICBDLPIJO);
		return;
	}
	UnityEngine.Debug.LogError (". This client's player: " + DAKCKPMBKFF);
	HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, "ObscuredVector3 vs Vector3, ", null);
}
```

</details>

---

## GET `http://j.mp/1FRAL5L`

*first seen: 2018-05-11_18-12-06 — last seen: 2018-08-30_21-05-57 (3 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
nFAAJNFPOGP
```

</details>

---

## POST `http://j.mp/1LCdpDa`

*first seen: 2017-04-14_23-03-37 — last seen: 2017-12-15_01-29-10 (3 builds)*

**Request body:** application/json

**Response:**

`200 OK` — JSON `IICACCMPGKH+RewardBalanceModificationDTO]]` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
private static HEMCJJJMLKI.JMICPMCJMJF<T> PDIOHPCAPPC<T> (HEMCJJJMLKI.JMICPMCJMJF<T> JOINLHEALDL) where T : BalanceResponseDTO
{
	return delegate(string DAKCKPMBKFF, T DKBBNNEBKMO) {
		if (string.IsNullOrEmpty (DAKCKPMBKFF)) {
			CCEIIHOIFGB storefrontType = DKBBNNEBKMO.StorefrontType;
			if (KGLPELKMOAI.TryGetValue (storefrontType, out var value)) {
				if (value != DKBBNNEBKMO.Balance) {
					HMIANADPOMJ (storefrontType, value, DKBBNNEBKMO.Balance);
				}
			} else {
				HMIANADPOMJ (storefrontType, null, DKBBNNEBKMO.Balance);
			}
			KGLPELKMOAI [storefrontType] = DKBBNNEBKMO.Balance;
		}
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, DKBBNNEBKMO);
	};
}
```

</details>

---

## POST `http://j.mp/1gxg1tf`

*first seen: 2017-03-13_23-52-18 — last seen: 2017-03-13_23-52-18 (1 builds)*

**Declared by:** `<DowloadLocalPlayerSettings>c__IteratorE2.CGAECCKLPJG`

**Request body:** System.Boolean

**Response:**

`200 OK` — JSON `HAOPGDCFCHD`

```json
{
  "to": string,
  "type": string
}
```

<details><summary>Client-side callback</summary>

```cs
internal void DLDKOIEPIMP (string HJLPPIBIGNJ, List<HAOPGDCFCHD> PLFHIDKPHFI)
{
	if (string.IsNullOrEmpty (HJLPPIBIGNJ)) {
		COGCNMJCNKN.BFNFLFBCDCC (EGOJDIFBGAF, null, PLFHIDKPHFI);
		return;
	}
	UnityEngine.Debug.LogError ("Failed to download player settings: " + HJLPPIBIGNJ);
	COGCNMJCNKN.BFNFLFBCDCC (EGOJDIFBGAF, "Failed to download player settings", null);
}
```

</details>

---

## GET `http://j.mp/1iBK5pz`

*first seen: 2018-06-07_23-55-49 — last seen: 2018-08-30_21-05-57 (3 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
HEGFLJKILKM: false
```

</details>

---

## GET `http://ns.exitgames.com:80/photon/n`

*first seen: 2017-02-13_21-47-24 — last seen: 2017-08-22_22-54-30 (4 builds)*

**Declared by:** `LargeFileDownloadSample.OMLJDPJDLDD`

**Response:**

`200 OK` — JSON `HKJEONFHLGO`

```json
{
  "network_zombie_room": string,
  "Bastadis": string,
  "time": string
}
```

<details><summary>Client-side callback</summary>

```cs
delegate(string GHJBJJPHNHD, HKJEONFHLGO HDBKDBPCJFI) {
	if (string.IsNullOrEmpty (GHJBJJPHNHD)) {
		DNPMEIAIPLP (HDBKDBPCJFI);
		BFEONIELEAH.FOBBKGGGEKD (ADHBNDGBJCE, null);
	} else {
		UnityEngine.Debug.LogError ("Depth" + GHJBJJPHNHD);
		BFEONIELEAH.FOBBKGGGEKD (ADHBNDGBJCE, " Scores!");
	}
}
```

</details>

---

## POST `http://ns.exitgames.com:80/photon/n`

*first seen: 2017-03-25_00-00-09 — last seen: 2018-05-30_00-27-44 (3 builds)*

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `Unignore` | `string` |
| `AppVersion` | `string` |
| `Value` | `string` |

**Response:**

`200 OK` — JSON `PFFJGKLPKEP+MNECEMGADHK` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
delegate(string HJLPPIBIGNJ, MNECEMGADHK CHNMKEMPOBD) {
	if (string.IsNullOrEmpty (HJLPPIBIGNJ)) {
		if (!OAKEDMOPMIF ().Contains (CHNMKEMPOBD)) {
			BBHMHLFNCOB ().Add (CHNMKEMPOBD);
			COGCNMJCNKN.BFNFLFBCDCC (EGOJDIFBGAF, null, CHNMKEMPOBD);
		} else {
			COGCNMJCNKN.BFNFLFBCDCC (EGOJDIFBGAF, "Latency", null);
		}
	} else {
		UnityEngine.Debug.LogError ("string: " + HJLPPIBIGNJ);
		COGCNMJCNKN.BFNFLFBCDCC (EGOJDIFBGAF, " is missing Animation Attack Trigger.", null);
	}
}
```

</details>

---

## GET `http://uk3.testmy.net/dl-102400`

*first seen: 2017-06-23_17-23-52 — last seen: 2018-12-06_21-26-17 (95 builds)*

**Declared by:** `LargeFileDownloadSample.KGJOCJGAEIP`, `LargeFileDownloadSample.OHLEOLDHBJF`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

---

## POST `http://uk3.testmy.net/dl-102400`

*first seen: 2018-02-01_20-04-59 — last seen: 2018-12-06_21-26-17 (3 builds)*

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `z` | `string` |
| `!` | `string` |
| `invalid block type` | `string` |

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

## GET `http://www.againstgrav.com/motd`

*first seen: 2016-06-28_23-56-39 — last seen: 2016-10-07_18-37-37 (30 builds)*

**Declared by:** `IntroActivityManager.DownloadMessageOfTheDayCoroutine`, `MessageOfTheDay.Start`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

---

## GET `http://www.google-analytics.com/collect`

*first seen: 2017-12-15_01-29-10 — last seen: 2018-12-06_21-26-17 (5 builds)*

**Response:**

`200 OK` — JSON `OPOHNGAOCCD`

```json
{
  "MessageOfTheDay": string,
  "CdnBaseUri": string,
  "MatchmakingParams": LOIBFONMHMF,
  "Level": int,
  "RequiredXp": int,
  "type": int,   // enum ProgressionManager.MPBMNKHKCEE
  "score": int,
  "Key": string,
  "Value": string,
  "PhotonConfig": PDLLPCKFLOP,
  "LevelProgressionMaps": object[],   // array
  "DailyObjectives": object[],   // array
  "ConfigTable": object[]   // array
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `MessageOfTheDay` | `string` | `NHHPFOBMAMK` |
| `CdnBaseUri` | `string` | `EFJLNNPMBJK` |
| `MatchmakingParams` | `LOIBFONMHMF` | `OCKPIMOBPCC` |
| `Level` | `int` | — |
| `RequiredXp` | `int` | — |
| `type` | `int` | `ObjectiveType` |
| `score` | `int` | `RequiredScore` |
| `Key` | `string` | — |
| `Value` | `string` | — |
| `PhotonConfig` | `PDLLPCKFLOP` | `PDLLPCKFLOP` |
| `LevelProgressionMaps` | `object[]` | — |
| `DailyObjectives` | `object[]` | — |
| `ConfigTable` | `object[]` | — |

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF, OPOHNGAOCCD DPBAECEJKMC) {
	FCDPFLMFDBC = DPBAECEJKMC;
	if (!string.IsNullOrEmpty (DAKCKPMBKFF)) {
		Debug.LogError ("{0}\\SavedOutfitSlot_{1}.png" + DAKCKPMBKFF);
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, "Received OnSerialization for view ID ");
	} else {
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, null);
	}
}
```

</details>

---

## POST `http://www.google-analytics.com/collect`

*first seen: 2018-03-01_20-14-27 — last seen: 2018-03-01_20-14-27 (1 builds)*

**Request body:** RecNet.FGKGBENHFOL

**Response:**

`200 OK` — JSON `FGKGBENHFOL`

```json
{
  "Index": int,
  "Group": int,
  "Progress": float,
  "VisualProgress": float,
  "IsCompleted": bool,
  "IsRewarded": bool
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `Index` | `int` | `EGKGDAPOEEI` |
| `Group` | `int` | `GIAHLPPDOFK` |
| `Progress` | `float` | `FIJEENLLBFJ` |
| `VisualProgress` | `float` | `INCDIJPLODO` |
| `IsCompleted` | `bool` | `AJGOLPDKINK` |
| `IsRewarded` | `bool` | `AGJDAMFHOCI` |

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF) {
	if (!string.IsNullOrEmpty (DAKCKPMBKFF)) {
		CCKGAHDELBD.OGEPLIKCBFC.NHJFFNLGFDN (NOBAPCOKFIL: true);
		UnityEngine.Debug.LogErrorFormat ("type", (DAKCKPMBKFF == null) ? string.Empty : DAKCKPMBKFF);
	}
}
```

</details>

---

## GET `http://www.google.com/generate_204`

*first seen: 2016-12-09_03-11-41 — last seen: 2018-12-06_21-26-17 (144 builds)*

**Declared by:** `<Get>c__AnonStorey3.TestConnection`, `<TestConnection>c__Iterator93.TestConnection`, `<TestConnection>c__Iterator96.TestConnection`, `<TestConnection>c__IteratorA2.TestConnection`, `<TestConnection>c__IteratorAE.MoveNext`, `<TestConnection>c__IteratorAF.MoveNext`, `<TestConnection>c__IteratorC1.MoveNext`, `<TestConnection>c__IteratorDC.MoveNext`, `<TestConnection>c__IteratorE4.MoveNext`, `<TestConnection>c__IteratorE6.MoveNext`, `<TestConnection>c__IteratorEA.MoveNext`, `<TestConnection>c__IteratorEB.MoveNext`, `<TestConnection>c__IteratorF7.MoveNext`, `<TestConnection>c__IteratorF8.MoveNext`, `<TestConnection>c__IteratorF9.MoveNext`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
"http://www.google.com/generate_204"
```

</details>

---

## POST `http://www.google.com/generate_204`

*first seen: 2017-02-11_00-57-56 — last seen: 2018-03-05_19-39-58 (2 builds)*

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `\f` | `string` |
| `FULL_SCREEN_DESATURATION` | `string` |
| `IVROverlay_013` | `string` |

**Response:**

`200 OK` — JSON `OKIKKLAPNOI`

```json
{
  "GlobalOverall": EOCFCNKKGPL,
  "GlobalPeriodic": EOCFCNKKGPL,
  "FriendsOverall": EOCFCNKKGPL,
  "FriendsPeriodic": EOCFCNKKGPL,
  "NextResetUTC": DateTime   // epoch ticks
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `GlobalOverall` | `EOCFCNKKGPL` | `LGHEIOHKEAN` |
| `GlobalPeriodic` | `EOCFCNKKGPL` | `FAKCNBLELME` |
| `FriendsOverall` | `EOCFCNKKGPL` | `BCEHOLDNPAE` |
| `FriendsPeriodic` | `EOCFCNKKGPL` | `OHPEGHEDCPA` |
| `NextResetUTC` | `DateTime` | `MKGFCGNNFAP` |

<details><summary>Client-side callback</summary>

```cs
ADHBNDGBJCE
```

</details>

---

## GET `https://besthttp.azurewebsites.net/Content/AssetBundle.html`

*first seen: 2017-06-23_17-23-52 — last seen: 2018-12-20_21-03-57 (98 builds)*

**Declared by:** `AssetBundleSample.ALCEEJJOHGI`, `AssetBundleSample.BDGKMLGMIKG`, `AssetBundleSample.CCCMNFCJJAM`, `AssetBundleSample.CCOKNKKOELE`, `AssetBundleSample.CPAHEFLGHKO`, `AssetBundleSample.DFAPEEIBGDE`, `AssetBundleSample.DFNGEKOINJA`, `AssetBundleSample.EHEKIIIHGAM`, `AssetBundleSample.FBDLGIHOFFF`, `AssetBundleSample.FDAMOFOFAJM`, `AssetBundleSample.FIMIEBIEFJJ`, `AssetBundleSample.FJGHOHOOOJC`, `AssetBundleSample.GHHNIPIMHIF`, `AssetBundleSample.GOBDDIFGHFP`, `AssetBundleSample.GONHBNKCHGO`, `AssetBundleSample.HIIHKFHFFKP`, `AssetBundleSample.HJCAPLGFGBI`, `AssetBundleSample.HLKFKBDKGHK`, `AssetBundleSample.IDOLJHMCFOB`, `AssetBundleSample.IEDLMDCJOHE`, `AssetBundleSample.IPCNAHGJJHN`, `AssetBundleSample.IPJDELJOALI`, `AssetBundleSample.JAHCPBDOILI`, `AssetBundleSample.JDFPDPLDODM`, `AssetBundleSample.JEBBFJIALCG`, `AssetBundleSample.JGGKPFBOJAD`, `AssetBundleSample.LMHOHECBGIN`, `AssetBundleSample.LNELEFLMNJE`, `AssetBundleSample.LNMMKLABHKP`, `AssetBundleSample.LONEPNJLENB`, `AssetBundleSample.MANCNIPAPLG`, `AssetBundleSample.MGBOAKIDPIP`, `AssetBundleSample.MKGFICAELJE`, `AssetBundleSample.MoveNext`, `AssetBundleSample.NDCJKEOLGGH`, `AssetBundleSample.NJPMMHHODPM`, `AssetBundleSample.OAGKHEJLKJP`, `AssetBundleSample.OBIPCEDIDKP`, `AssetBundleSample.OKLHOHNPAJI`, `AssetBundleSample.ONNIAMFCDJG`, `AssetBundleSample.POEBLFLPFIH`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

---

## POST `https://besthttp.azurewebsites.net/Content/AssetBundle.html`

*first seen: 2017-07-11_00-44-03 — last seen: 2018-05-04_20-50-17 (2 builds)*

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| ` ` | `string` |
| `Complex Array Works!` | `string` |
| `SniperScope: Missing camera or renderer.` | `string` |

**Response:**

`200 OK` — JSON `JGJEOEMINLE`

```json
{
  "GlobalOverall": JDJMCFDIBED,
  "GlobalPeriodic": JDJMCFDIBED,
  "FriendsOverall": JDJMCFDIBED,
  "FriendsPeriodic": JDJMCFDIBED,
  "NextResetUTC": DateTime   // epoch ticks
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `GlobalOverall` | `JDJMCFDIBED` | `OMBHAENKKLC` |
| `GlobalPeriodic` | `JDJMCFDIBED` | `HMAPOIOBHJH` |
| `FriendsOverall` | `JDJMCFDIBED` | `IEECDDEEBMC` |
| `FriendsPeriodic` | `JDJMCFDIBED` | `ONPABGLKLFO` |
| `NextResetUTC` | `DateTime` | `PIBILFDNNGD` |

<details><summary>Client-side callback</summary>

```cs
JOINLHEALDL
```

</details>

---

## GET `https://besthttp.azurewebsites.net/Content/{param}`

*first seen: 2017-06-23_17-23-52 — last seen: 2018-12-06_21-26-17 (95 builds)*

**Declared by:** `TextureDownloadSample.JADDMCDLIEE`, `TextureDownloadSample.PILFGFHCGLN`

**URI parameters:** `param`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

---

## POST `https://besthttpsignalr.azurewebsites.net/signalr`

*first seen: 2017-10-02_18-15-46 — last seen: 2017-11-30_23-39-18 (2 builds)*

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `ObscuredFloat vs float, ` | `string` |
| `gizmos` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
JOINLHEALDL
```

</details>

---

## GET `https://ns.rec.net/?v=1`

*first seen: 2018-04-27_18-51-13 — last seen: 2018-09-29_21-19-48 (34 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
HEGFLJKILKM: false
```

</details>

---

## GET `https://ns.rec.net/?v=2`

*first seen: 2018-10-11_23-46-07 — last seen: 2018-12-06_21-26-17 (10 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

---

## POST `https://ssl.google-analytics.com/collect`

*first seen: 2017-05-23_19-12-22 — last seen: 2018-02-15_18-48-13 (2 builds)*

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `activityNameFriendly` | `string` |

**Response:**

`200 OK` — JSON `EFDOILDKBFK`

```json
{
  "Success": bool,
  "Message": string
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `Success` | `bool` | `FOPNEFBADJB` |
| `Message` | `string` | `IMGPDLHMJEE` |

<details><summary>Client-side callback</summary>

```cs
JOINLHEALDL
```

</details>

---

## GET `https://www.againstgrav.com/help-center/`

*first seen: 2018-03-16_20-35-40 — last seen: 2018-03-16_20-35-40 (1 builds)*

**Response:**

`200 OK` — JSON `OPOHNGAOCCD`

```json
{
  "MessageOfTheDay": string,
  "CdnBaseUri": string,
  "MatchmakingParams": LOIBFONMHMF,
  "Level": int,
  "RequiredXp": int,
  "type": int,   // enum ProgressionManager.MPBMNKHKCEE
  "score": int,
  "Key": string,
  "Value": string,
  "PhotonConfig": PDLLPCKFLOP,
  "LevelProgressionMaps": object[],   // array
  "DailyObjectives": object[],   // array
  "ConfigTable": object[]   // array
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `MessageOfTheDay` | `string` | `NHHPFOBMAMK` |
| `CdnBaseUri` | `string` | `EFJLNNPMBJK` |
| `MatchmakingParams` | `LOIBFONMHMF` | `OCKPIMOBPCC` |
| `Level` | `int` | — |
| `RequiredXp` | `int` | — |
| `type` | `int` | `ObjectiveType` |
| `score` | `int` | `RequiredScore` |
| `Key` | `string` | — |
| `Value` | `string` | — |
| `PhotonConfig` | `PDLLPCKFLOP` | `PDLLPCKFLOP` |
| `LevelProgressionMaps` | `object[]` | — |
| `DailyObjectives` | `object[]` | — |
| `ConfigTable` | `object[]` | — |

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF, OPOHNGAOCCD DPBAECEJKMC) {
	FCDPFLMFDBC = DPBAECEJKMC;
	if (!string.IsNullOrEmpty (DAKCKPMBKFF)) {
		Debug.LogError ("_EmissionColor" + DAKCKPMBKFF);
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, " - First to ");
	} else {
		HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, null);
	}
}
```

</details>

---

## POST `https://www.againstgrav.com/privacy-policy/`

*first seen: 2017-11-18_17-11-39 — last seen: 2018-04-12_18-08-52 (2 builds)*

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `
` | `string` |
| `,` | `string` |
| `CATCHES` | `string` |
| `null` | `string` |
| `position` | `string` |

**Response:**

`200 OK` — JSON `EFDOILDKBFK`

```json
{
  "Join": bool,
  "WebSocketResponse": string
}
```

<details><summary>Client-side callback</summary>

```cs
JOINLHEALDL
```

</details>

---

## POST `https://www.assetstore.unity3d.com/en/#!/content/34483`

*first seen: 2018-10-12_21-50-41 — last seen: 2018-10-12_21-50-41 (1 builds)*

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `AQUAS Water contains a set of 9 flat water shaders for all types of platforms, environments and games. It is highly customizable and feature rich to suit all needs.
            
AQUAS contains 4 mobile shaders for different performance levels and 5 high-quality shaders for web and desktop applications.

Features:

Rendering:
- Multi-Light-Support
- Distorted Realtime Reflections
- Realtime Refraction
- Depth Based Color Absorption
- Self-Sustaining Fog System, that works with any custom lighting
- Dual-layered Caustic effects

Underwater Effects
- Limited & Distorted Vision
- Bloom, Blur & Godrays
- 3D Morphing Bubbles
- Realistic Bubble Spawner
- Advanced Wet Lens Effect

Ease of use
- Works out of the box (Demo Scene included)
- Highly customizable
- Quick Setup

AQUAS works with Unity Free & Pro` | `string` |
| `Error creating room. Permission was denied.` | `string` |
| `This activity is not available to juniors` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
OKBCAHBFJBL: false
```

</details>

---

## POST `https://www.assetstore.unity3d.com/en/#!/content/51881`

*first seen: 2018-09-14_18-44-25 — last seen: 2018-11-21_18-28-53 (2 builds)*

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `x` | `string` |
| `UsingSplitTestingOverride` | `string` |
| `NEXT MAP: ` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
HEGFLJKILKM: false
```

</details>

---

## POST `https://www.assetstore.unity3d.com/en/#!/content/52103`

*first seen: 2018-07-20_20-10-36 — last seen: 2018-07-27_23-32-16 (2 builds)*

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `uploadsaved` | `string` |
| `Message` | `string` |
| `Unknown message type` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
HEGFLJKILKM: false
```

</details>

---

