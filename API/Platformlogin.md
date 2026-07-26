# Platformlogin

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## GET `api/platformlogin/v1/getcachedlogins`

*first seen: 2018-05-09_19-37-59 — last seen: 2018-12-06_21-26-17 (40 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
dictionary
```

</details>

---

## POST `api/platformlogin/v1/getcachedlogins`

*first seen: 2017-11-18_17-11-39 — last seen: 2018-05-04_20-50-17 (26 builds)*

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `Platform` | `string` |
| `PlatformId` | `string` |

**Response:**

`200 OK` — JSON `EEBPLECPEGD`

```json
{
  "Id": long,
  "Username": string,
  "DisplayName": string,
  "XP": int,
  "Level": int,
  "RegistrationStatus": int,
  "Developer": bool,
  "CanReceiveInvites": bool,
  "ProfileImageName": string,
  "JuniorProfile": bool,
  "ForceJuniorImages": bool,
  "PendingJunior": bool,
  "HasBirthday": bool,
  "AvoidJuniors": bool,
  "PlayerReputation": HOLNFPNKNGB,
  "PlatformIds": AHCLNKIOJBB
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `Id` | `long` | `PKJFPDJKJAH` |
| `Username` | `string` | `LOEPMFKLBKM` |
| `DisplayName` | `string` | `ENMNBBMDOHC` |
| `XP` | `int` | `BBPJPONKGOM` |
| `Level` | `int` | `EFHLFMMGAGP` |
| `RegistrationStatus` | `int` | `LEEMHDHPAJJ` |
| `Developer` | `bool` | `MNIMPHGNJMM` |
| `CanReceiveInvites` | `bool` | `GBEGGJHOBKL` |
| `ProfileImageName` | `string` | `LNHJELBMGDH` |
| `JuniorProfile` | `bool` | `JMMJGMOBGJM` |
| `ForceJuniorImages` | `bool` | `HDCFLLIBJGD` |
| `PendingJunior` | `bool` | `KIDLLMDFEEI` |
| `HasBirthday` | `bool` | `AOJHMPBIABL` |
| `AvoidJuniors` | `bool` | `LMPGKBHEICB` |
| `PlayerReputation` | `HOLNFPNKNGB` | `HOLNFPNKNGB` |
| `PlatformIds` | `AHCLNKIOJBB` | `CCELGOECPHD` |

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF, List<EEBPLECPEGD> AILIBDCECFM) {
	if (string.IsNullOrEmpty (DAKCKPMBKFF)) {
		FKJHLNJDEKK.HAKMKOAOMED (AILIBDCECFM);
		JICEFBNKLHF = new HashSet<long> (AILIBDCECFM.Select ((EEBPLECPEGD CECDNGGHGAK) => ObscuredLong.EDHNDLCFIOL (CECDNGGHGAK.PKJFPDJKJAH)));
	} else {
		Debug.LogError ("Failed to retrieve cached login profiles: " + DAKCKPMBKFF);
		DAKCKPMBKFF = "Failed to load Rec Room accounts";
	}
	HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF, AILIBDCECFM);
}
```

</details>

---

## POST `api/platformlogin/v1/profiles`

*first seen: 2017-07-11_00-44-03 — last seen: 2017-11-10_00-49-07 (26 builds)*

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `Platform` | `string` |
| `PlatformId` | `string` |

**Response:**

`200 OK` — JSON `EEBPLECPEGD`

```json
{
  "Id": long,
  "Username": string,
  "DisplayName": string,
  "XP": int,
  "Level": int,
  "Verified": bool,
  "Developer": bool,
  "HasEmail": bool,
  "CanReceiveInvites": bool,
  "ProfileImageName": string,
  "JuniorProfile": bool,
  "ForceJuniorImages": bool,
  "PendingJunior": bool,
  "HasBirthday": bool,
  "AvoidJuniors": bool,
  "EmailEnteredAt": DateTime?,
  "PlayerReputation": HOLNFPNKNGB,
  "PlatformIds": AHCLNKIOJBB
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `Id` | `long` | `PKJFPDJKJAH` |
| `Username` | `string` | `LOEPMFKLBKM` |
| `DisplayName` | `string` | `ENMNBBMDOHC` |
| `XP` | `int` | `BBPJPONKGOM` |
| `Level` | `int` | `EFHLFMMGAGP` |
| `Verified` | `bool` | `HPLFAJMJKGO` |
| `Developer` | `bool` | `MNIMPHGNJMM` |
| `HasEmail` | `bool` | `HINNOLKIJLG` |
| `CanReceiveInvites` | `bool` | `GBEGGJHOBKL` |
| `ProfileImageName` | `string` | `LNHJELBMGDH` |
| `JuniorProfile` | `bool` | `JMMJGMOBGJM` |
| `ForceJuniorImages` | `bool` | `HDCFLLIBJGD` |
| `PendingJunior` | `bool` | `KIDLLMDFEEI` |
| `HasBirthday` | `bool` | `AOJHMPBIABL` |
| `AvoidJuniors` | `bool` | `LMPGKBHEICB` |
| `EmailEnteredAt` | `DateTime?` | `MCPMFOPENKD` |
| `PlayerReputation` | `HOLNFPNKNGB` | `HOLNFPNKNGB` |
| `PlatformIds` | `AHCLNKIOJBB` | `CCELGOECPHD` |

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF, List<EEBPLECPEGD> AILIBDCECFM) {
	if (string.IsNullOrEmpty (DAKCKPMBKFF)) {
		ALEDPDMMBGI.AddRange (AILIBDCECFM);
		FKJHLNJDEKK.HAKMKOAOMED (AILIBDCECFM);
		MKFLPKAIDDJ (JOINLHEALDL, null);
	} else {
		UnityEngine.Debug.LogError ("Failed to retrieve player profiles: " + DAKCKPMBKFF);
		MKFLPKAIDDJ (JOINLHEALDL, "Failed to connect to RecNet");
	}
}
```

</details>

---

## GET `api/platformlogin/v1/refreshlogin`

*first seen: 2017-11-18_17-11-39 — last seen: 2019-11-12_15-10-55 (105 builds)*

**Declared by:** `Login.OnRefreshLogin`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/platformlogin/v1/registeraccount`

*first seen: 2018-05-09_19-37-59 — last seen: 2018-12-06_21-26-17 (40 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
dictionary
```

</details>

---

## POST `api/platformlogin/v1/registeraccount`

*first seen: 2017-11-18_17-11-39 — last seen: 2019-11-12_15-10-55 (65 builds)*

**Declared by:** `Login.ResetUnverifiedEmail`

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `Email` | `string` |

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

## GET `api/platformlogin/v1/removecachedlogin`

*first seen: 2018-05-09_19-37-59 — last seen: 2018-12-06_21-26-17 (40 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
dictionary
```

</details>

---

## POST `api/platformlogin/v1/removecachedlogin`

*first seen: 2017-11-18_17-11-39 — last seen: 2019-11-12_15-10-55 (65 builds)*

**Declared by:** `Login.RemoveCachedLogin`

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `Platform` | `string` |
| `PlatformId` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF) {
	if (string.IsNullOrEmpty (DAKCKPMBKFF)) {
		JICEFBNKLHF.Remove (HEMCJJJMLKI.PLNKIILJKDA);
	} else {
		Debug.LogError ("Failed to remove cached login: " + DAKCKPMBKFF);
		DAKCKPMBKFF = "Failed to remove cached login";
	}
	HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF);
}
```

</details>

---

## POST `api/platformlogin/v2/getcachedlogins`

*first seen: 2019-03-14_23-23-50 — last seen: 2019-10-02_14-21-06 (28 builds)*

**Declared by:** `Login.DownloadCachedLoginProfiles`

**Request body:** form fields (Dictionary<string,string>)

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num2 != 0
```

</details>

---

## POST `api/platformlogin/v6?EIO={1}&transport=polling&t={2}-{3}{5}`

*first seen: 2017-10-27_20-21-58 — last seen: 2017-10-28_01-35-02 (2 builds)*

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `ConnectToMaster() disabled the offline mode. No longer offline.` | `string` |
| `attach` | `string` |
| `Save` | `string` |

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

## GET `api/platformlogin/{param}`

*first seen: 2018-04-27_18-51-13 — last seen: 2018-12-06_21-26-17 (44 builds)*

**Declared by:** `TextureDownloadSample.OGFFOFPAALI`

**URI parameters:** `param`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

---

## POST `api/platformlogin/{param}`

*first seen: 2017-11-18_17-11-39 — last seen: 2018-04-13_22-58-42 (22 builds)*

**URI parameters:** `param`

**Request body:** application/json

**Response:**

`200 OK` — JSON `HELBDLFLEJG+FAPAEHEIANH` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
delegate(string DAKCKPMBKFF, FAPAEHEIANH DKBBNNEBKMO) {
	if (!string.IsNullOrEmpty (DAKCKPMBKFF)) {
		Debug.LogError ("RecNet login failed: " + DAKCKPMBKFF);
		DAKCKPMBKFF = "Unable to login (code: 3)";
	} else if (!string.IsNullOrEmpty (DKBBNNEBKMO.HMBKJEPDKOO)) {
		Debug.LogError ("RecNet login failed: " + DKBBNNEBKMO.HMBKJEPDKOO);
		DAKCKPMBKFF = DKBBNNEBKMO.HMBKJEPDKOO;
	} else {
		HEMCJJJMLKI.GPJEAADBPLJ (ObscuredLong.EDHNDLCFIOL (DKBBNNEBKMO.MBHLIAEFEAD.PKJFPDJKJAH));
		FKJHLNJDEKK.BKFNGIFNFBA (DKBBNNEBKMO.MBHLIAEFEAD);
		LAMNCNMGPDF = DKBBNNEBKMO.NKFLBAKCPLA;
		OONEBOCAKDB = DKBBNNEBKMO.OONEBOCAKDB;
		AmplitudeAnalyticsClient.EBKMJABKJJA = DKBBNNEBKMO.DHGLEPFEMEL;
		JICEFBNKLHF.Add (ObscuredLong.EDHNDLCFIOL (DKBBNNEBKMO.MBHLIAEFEAD.PKJFPDJKJAH));
	}
	HEMCJJJMLKI.MKFLPKAIDDJ (JOINLHEALDL, DAKCKPMBKFF);
}
```

</details>

---

