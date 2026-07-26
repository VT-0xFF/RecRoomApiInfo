# Versioncheck

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## GET `api/versioncheck/v1`

*first seen: 2016-12-09_03-11-41 — last seen: 2017-06-26_22-41-58 (52 builds)*

**Declared by:** `<Get>c__AnonStorey3.TestConnection`, `<TestConnection>c__Iterator93.TestConnection`, `<TestConnection>c__Iterator96.TestConnection`, `<TestConnection>c__IteratorA2.TestConnection`, `<TestConnection>c__IteratorAE.MoveNext`, `<TestConnection>c__IteratorAF.MoveNext`, `<TestConnection>c__IteratorC1.MoveNext`, `<TestConnection>c__IteratorDC.CFANNDPOPFD`, `<TestConnection>c__IteratorDC.IHNNMIAPIJP`, `<TestConnection>c__IteratorDC.MLINOAHAPEP`, `<TestConnection>c__IteratorE4.FDOFPBDPEOL`, `<TestConnection>c__IteratorE4.MoveNext`, `<TestConnection>c__IteratorE6.BMBDFIKFFEA`, `<TestConnection>c__IteratorE6.KHPFAGLFGMO`, `<TestConnection>c__IteratorEA.LPPJDNPNOFM`, `<TestConnection>c__IteratorEB.NCGBOJPJKFM`, `<TestConnection>c__IteratorF7.DBMKJMPMAAB`, `<TestConnection>c__IteratorF7.GEOECJPMOBP`, `<TestConnection>c__IteratorF8.JKCKACNEIPG`, `<TestConnection>c__IteratorF9.CFFMGDHIGBN`, `<TestConnection>c__IteratorF9.GNCOEMKGOIA`, `<TestConnection>c__IteratorF9.MoveNext`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
delegate(UnityWebRequest unityWebRequest) {
	responseCode = unityWebRequest.responseCode;
	error = GetError (unityWebRequest);
}
```

</details>

---

## POST `api/versioncheck/v1`

*first seen: 2017-04-07_21-06-02 — last seen: 2017-04-07_21-06-02 (1 builds)*

**Declared by:** `<DowloadLocalPlayerSettings>c__IteratorEA.CGAECCKLPJG`

**Request body:** System.Boolean

**Response:**

`200 OK` — JSON `HAOPGDCFCHD`

```json
{
  "up": string,
  "reported_player_id": string
}
```

<details><summary>Client-side callback</summary>

```cs
internal void OKBCHKOENFI (string HJLPPIBIGNJ, List<HAOPGDCFCHD> PLFHIDKPHFI)
{
	if (string.IsNullOrEmpty (HJLPPIBIGNJ)) {
		COGCNMJCNKN.BFNFLFBCDCC (EGOJDIFBGAF, null, PLFHIDKPHFI);
		return;
	}
	UnityEngine.Debug.LogError (") failed: " + HJLPPIBIGNJ);
	COGCNMJCNKN.BFNFLFBCDCC (EGOJDIFBGAF, "Error: Someone else(", null);
}
```

</details>

---

## GET `api/versioncheck/v2`

*first seen: 2017-07-11_00-44-03 — last seen: 2017-08-14_22-16-49 (10 builds)*

**Response:**

`200 OK` — JSON `HEMCJJJMLKI+BPPMLPMDHCI` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
delegate(string CBDEIDDMHKE, BPPMLPMDHCI GJAPMDIMMKN) {
	PHEKPLPEFPH = GJAPMDIMMKN?.JGOJGIKKGBM ?? false;
	DAKCKPMBKFF = CBDEIDDMHKE;
}
```

</details>

---

## GET `api/versioncheck/v3?v=`

*first seen: 2018-02-02_20-35-48 — last seen: 2018-11-21_18-28-53 (3 builds)*

**Response:**

`200 OK` — JSON `HELBDLFLEJG+LDDBCPLEFDA` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
private static void HCELKCNEEAI (string DAKCKPMBKFF, LDDBCPLEFDA DKBBNNEBKMO)
{
	if (string.IsNullOrEmpty (DAKCKPMBKFF)) {
		EFJGAOFBIOO (DKBBNNEBKMO.FOCPKIKMCLO ());
		if (string.IsNullOrEmpty (DKBBNNEBKMO.GICCGGIABFI ())) {
			DAKCKPMBKFF = "ImageName";
			Debug.LogError (DAKCKPMBKFF);
			Application.Quit ();
		} else {
			Debug.LogWarning ("noPlayer");
		}
	} else {
		Debug.LogError ("PlayerId" + DAKCKPMBKFF);
	}
}
```

</details>

---

## GET `api/versioncheck/v3?v={param}`

*first seen: 2018-01-18_01-17-10 — last seen: 2018-12-06_21-26-17 (60 builds)*

**URI parameters:** `param`

**Response:**

`200 OK` — JSON `HEMCJJJMLKI+BPPMLPMDHCI` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
delegate(string CBDEIDDMHKE, BPPMLPMDHCI GJAPMDIMMKN) {
	PHEKPLPEFPH = GJAPMDIMMKN?.JGOJGIKKGBM ?? false;
	DAKCKPMBKFF = CBDEIDDMHKE;
}
```

</details>

---

