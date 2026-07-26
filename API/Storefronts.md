# Storefronts

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## POST `api/storefronts/v1/PurchaseRoomKeyWithCurrency`

*first seen: 2021-06-08_02-49-57 — last seen: 2021-08-06_06-02-59 (9 builds)*

**Request body:** System.Collections.Generic.IEnumerable

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num != 0
```

</details>

---

## GET `api/storefronts/v1/allGiftDrops/{param}`

*first seen: 2018-05-09_19-37-59 — last seen: 2018-06-06_18-52-43 (7 builds)*

**URI parameters:** `param`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
HEGFLJKILKM: false
```

</details>

---

## GET `api/storefronts/v1/balance`

*first seen: 2018-05-09_19-37-59 — last seen: 2018-06-06_18-52-43 (7 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/storefronts/v1/balance`

*first seen: 2017-11-10_00-49-07 — last seen: 2018-05-04_20-50-17 (27 builds)*

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `StorefrontType` | `string` |
| `BalanceChange` | `string` |

**Response:**

`200 OK` — JSON `IICACCMPGKH+BalanceDTO` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
private static HEMCJJJMLKI.JMICPMCJMJF<T> PDIOHPCAPPC<T> (HEMCJJJMLKI.JMICPMCJMJF<T> JOINLHEALDL) where T : BalanceDTO
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

## GET `api/storefronts/v1/balance/{param}`

*first seen: 2018-05-09_19-37-59 — last seen: 2018-06-06_18-52-43 (7 builds)*

**URI parameters:** `param`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
HEGFLJKILKM: false
```

</details>

---

## POST `api/storefronts/v1/balance/{param}`

*first seen: 2017-11-10_00-49-07 — last seen: 2018-05-04_20-50-17 (27 builds)*

**URI parameters:** `param`

**Request body:** System.Boolean

**Response:**

`200 OK` — JSON `IICACCMPGKH+BalanceDTO` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
private static HEMCJJJMLKI.JMICPMCJMJF<T> PDIOHPCAPPC<T> (HEMCJJJMLKI.JMICPMCJMJF<T> JOINLHEALDL) where T : BalanceDTO
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

## GET `api/storefronts/v1/balanceAddType/{param}/{param2}`

*first seen: 2018-05-09_19-37-59 — last seen: 2018-12-06_21-26-17 (40 builds)*

**URI parameters:** `param`, `param2`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
HEGFLJKILKM: false
```

</details>

---

## POST `api/storefronts/v1/balanceAddType/{param}/{param2}`

*first seen: 2018-03-01_20-14-27 — last seen: 2018-05-04_20-50-17 (14 builds)*

**URI parameters:** `param`, `param2`

**Request body:** System.Boolean

**Response:**

`200 OK` — JSON `BNIKGKLMEKM]]` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
JOINLHEALDL
```

</details>

---

## POST `api/storefronts/v1/buy`

*first seen: 2017-11-10_00-49-07 — last seen: 2018-05-04_20-50-17 (27 builds)*

**Request body:** form fields (Dictionary<string,string>)

| Field | Type |
|-------|------|
| `StorefrontType` | `string` |
| `ItemId` | `string` |

**Response:**

`200 OK` — JSON `IOIGNLEIABB+PGMLKNLPFJM]]` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
private static HEMCJJJMLKI.JMICPMCJMJF<T> PDIOHPCAPPC<T> (HEMCJJJMLKI.JMICPMCJMJF<T> JOINLHEALDL) where T : BalanceDTO
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

## GET `api/storefronts/v1/buyElite`

*first seen: 2018-06-07_23-55-49 — last seen: 2018-12-06_21-26-17 (33 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## GET `api/storefronts/v1/buyInvention?inventionId={CS8__locals3}`

*first seen: 2020-05-27_06-02-14 — last seen: 2020-08-04_04-00-43 (11 builds)*

**URI parameters:** `CS8__locals3`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num != 0
```

</details>

---

## GET `api/storefronts/v1/buyItem`

*first seen: 2018-06-07_23-55-49 — last seen: 2018-12-06_21-26-17 (33 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## GET `api/storefronts/v1/buyTier`

*first seen: 2018-06-07_23-55-49 — last seen: 2018-12-06_21-26-17 (33 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## GET `api/storefronts/v1/objectives`

*first seen: 2018-04-27_18-51-13 — last seen: 2018-12-06_21-26-17 (44 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/storefronts/v1/objectives`

*first seen: 2018-02-15_18-48-13 — last seen: 2021-08-06_06-02-59 (52 builds)*

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
HEMCJJJMLKI.CKANGALNHCO ("Failed to complete storefront objectives")
```

</details>

---

## GET `api/storefronts/v1/season/{param}`

*first seen: 2018-05-26_01-00-13 — last seen: 2018-12-06_21-26-17 (36 builds)*

**URI parameters:** `param`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
HEGFLJKILKM: false
```

</details>

---

## POST `api/storefronts/v1/{param}`

*first seen: 2017-11-10_00-49-07 — last seen: 2018-05-04_20-50-17 (27 builds)*

**URI parameters:** `param`

**Request body:** System.Boolean

**Response:**

`200 OK` — JSON `EJEKDDHHIGF`

```json
{
  "StoreItems": Dictionary<string, object>,
  "StartAt": DateTime,
  "EndAt": DateTime
}
```

| JSON key | Type | Maps to |
|----------|------|---------|
| `StoreItems` | `Dictionary<string, object>` | — |
| `StartAt` | `DateTime` | `NIMHLBKFIHJ` |
| `EndAt` | `DateTime` | `KAKNHDIEFEG` |

<details><summary>Client-side callback</summary>

```cs
JOINLHEALDL
```

</details>

---

## GET `api/storefronts/v2/balance`

*first seen: 2018-06-07_23-55-49 — last seen: 2018-12-06_21-26-17 (33 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/storefronts/v2/balance`

*first seen: 2019-03-14_23-23-50 — last seen: 2021-08-06_06-02-59 (119 builds)*

**Declared by:** `Storefronts.ModifyBalance`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/storefronts/v2/buy`

*first seen: 2018-05-09_19-37-59 — last seen: 2018-06-06_18-52-43 (7 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
text
```

</details>

---

## POST `api/storefronts/v2/buyElite`

*first seen: 2019-03-14_23-23-50 — last seen: 2021-08-06_06-02-59 (119 builds)*

**Declared by:** `Storefronts.PurchaseSeasonEliteTrack`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/storefronts/v2/buyInvention?inventionId={CS8__locals6}&requestedPrice={CS8__locals62}`

*first seen: 2020-08-10_02-57-31 — last seen: 2021-08-06_06-02-59 (49 builds)*

**URI parameters:** `CS8__locals6`, `CS8__locals62`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num2 != 0
```

</details>

---

## POST `api/storefronts/v2/buyItem`

*first seen: 2019-03-14_23-23-50 — last seen: 2021-07-09_02-51-36 (115 builds)*

**Declared by:** `Storefronts.PurchaseHelper`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/storefronts/v2/buyTier`

*first seen: 2019-03-14_23-23-50 — last seen: 2021-08-06_06-02-59 (119 builds)*

**Declared by:** `Storefronts.PurchaseSeasonTier`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/storefronts/v2/{param}`

*first seen: 2018-05-09_19-37-59 — last seen: 2018-06-06_18-52-43 (7 builds)*

**URI parameters:** `param`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
HEGFLJKILKM: false
```

</details>

---

## GET `api/storefronts/v3/balance/{param}`

*first seen: 2018-06-07_23-55-49 — last seen: 2018-12-06_21-26-17 (33 builds)*

**URI parameters:** `param`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
HEGFLJKILKM: false
```

</details>

---

## GET `api/storefronts/v3/giftdropstore/{param}`

*first seen: 2018-06-07_23-55-49 — last seen: 2018-12-06_21-26-17 (33 builds)*

**URI parameters:** `param`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
HEGFLJKILKM: false
```

</details>

---

## GET `api/storefronts/v4/balance/{flag}`

*first seen: 2019-03-14_23-23-50 — last seen: 2021-08-06_06-02-59 (119 builds)*

**Declared by:** `Storefronts.GetBalance`

**URI parameters:** `flag`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num != 0
```

</details>

---

