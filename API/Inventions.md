# Inventions

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## POST `api/inventions/v1/addversion?inventionId={newInstantiateCost}`

*first seen: 2018-12-14_19-12-52 — last seen: 2019-01-29_20-05-38 (6 builds)*

**Declared by:** `Inventions.AddInventionVersion`

**URI parameters:** `newInstantiateCost`

**Request body:** WWWForm (application/x-www-form-urlencoded)

| Field | Type |
|-------|------|
| `data` | `byte[]` |
| `newVersionRequest` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/inventions/v1/batch`

*first seen: 2019-02-07_18-24-01 — last seen: 2019-07-23_13-56-01 (18 builds)*

**Declared by:** `Inventions.GetInventionsAsBatch`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/inventions/v1/cheer`

*first seen: 2019-02-07_18-24-01 — last seen: 2019-07-23_13-56-01 (18 builds)*

**Declared by:** `Inventions.CheerInvention`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/inventions/v1/delete?inventionId={CS8__locals5}`

*first seen: 2018-12-14_19-12-52 — last seen: 2019-07-23_13-56-01 (24 builds)*

**Declared by:** `Inventions.DeleteInvention`

**URI parameters:** `CS8__locals5`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/inventions/v1/details?inventionId={num3}`

*first seen: 2019-01-18_19-43-25 — last seen: 2019-02-14_22-55-35 (5 builds)*

**Declared by:** `Inventions.GetInventionDetails`

**URI parameters:** `num3`

**Response:**

`200 OK` — JSON `InventionDetails` (schema not recovered)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/inventions/v1/download?inventionId={CS8__locals5}`

*first seen: 2019-01-18_19-43-25 — last seen: 2019-07-23_13-56-01 (21 builds)*

**Declared by:** `Inventions.DownloadInvention`

**URI parameters:** `CS8__locals3`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/inventions/v1/publish?inventionId={CS8__locals3}`

*first seen: 2019-01-18_19-43-25 — last seen: 2019-01-29_20-05-38 (3 builds)*

**Declared by:** `Inventions.PublishInvention`

**URI parameters:** `CS8__locals3`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/inventions/v1/report`

*first seen: 2019-02-07_18-24-01 — last seen: 2019-07-23_13-56-01 (18 builds)*

**Declared by:** `Inventions.ReportInvention`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num5 != 0
```

</details>

---

## POST `api/inventions/v1/save`

*first seen: 2018-12-14_19-12-52 — last seen: 2019-01-29_20-05-38 (6 builds)*

**Declared by:** `Inventions.UploadNewInvention`

**Request body:** WWWForm (application/x-www-form-urlencoded)

| Field | Type |
|-------|------|
| `data` | `byte[]` |
| `newInventionRequest` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/inventions/v1/search`

*first seen: 2019-01-18_19-43-25 — last seen: 2019-01-29_20-05-38 (3 builds)*

**Declared by:** `Inventions.SearchInventions`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/inventions/v1/settags`

*first seen: 2019-01-18_19-43-25 — last seen: 2019-07-23_13-56-01 (21 builds)*

**Declared by:** `Inventions.SetInventionTags`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num10 != 0
```

</details>

---

## GET `api/inventions/v1/unpublish?inventionId={CS8__locals4}`

*first seen: 2019-01-18_19-43-25 — last seen: 2019-07-23_13-56-01 (21 builds)*

**Declared by:** `Inventions.UnpublishInvention`

**URI parameters:** `CS8__locals3`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/inventions/v1/update?inventionId={CS8__locals7}&permission={CS8__locals72}`

*first seen: 2019-02-07_18-24-01 — last seen: 2019-07-23_13-56-01 (18 builds)*

**Declared by:** `Inventions.UpdateInventionGeneralPermission`

**URI parameters:** `CS8__locals6`, `CS8__locals62`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/inventions/v1/update?inventionId={flag}&imgName={imgName}`

*first seen: 2018-12-14_19-12-52 — last seen: 2019-07-23_13-56-01 (24 builds)*

**Declared by:** `Inventions.UpdateInventionImage`

**URI parameters:** `flag`, `imgName`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/inventions/v1/update?inventionId={flag}&name={name}`

*first seen: 2018-12-14_19-12-52 — last seen: 2019-07-23_13-56-01 (24 builds)*

**Declared by:** `Inventions.UpdateInventionName`

**URI parameters:** `flag`, `name`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/inventions/v1/version?inventionId={flag}&version={flag2}`

*first seen: 2018-12-14_19-12-52 — last seen: 2019-01-29_20-05-38 (6 builds)*

**Declared by:** `Inventions.GetInventionVersion`

**URI parameters:** `flag`, `flag2`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num4 != 0
```

</details>

---

## GET `api/inventions/v1?inventionId={invention}`

*first seen: 2018-12-14_19-12-52 — last seen: 2019-04-24_15-07-27 (13 builds)*

**Declared by:** `Inventions.GetInvention`

**URI parameters:** `invention`

**Response:**

`200 OK` — JSON `Invention`

```json
{
  "InventionId": long,
  "CreatorPlayerId": int,
  "Name": string,
  "Description": string,
  "ImageName": string,
  "CurrentVersionNumber": int,
  "IsPublished": bool,
  "ModifiedAt": DateTime,   // epoch ticks
  "CreatedAt": DateTime,   // epoch ticks
  "NumPlayersHaveUsedInRoom": int,
  "NumDownloads": int,
  "CheerCount": int,
  "CreatorPermission": int,
  "GeneralPermission": int
}
```

<details><summary>Client-side callback</summary>

```cs
(byte)num5 != 0
```

</details>

---

## POST `api/inventions/v2/addversion?inventionId={CS8__locals7}`

*first seen: 2019-02-07_18-24-01 — last seen: 2019-07-23_13-56-01 (18 builds)*

**Declared by:** `Inventions.AddInventionVersion`

**URI parameters:** `CS8__locals7`

**Request body:** WWWForm (application/x-www-form-urlencoded)

| Field | Type |
|-------|------|
| `data` | `byte[]` |
| `newVersionRequest` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/inventions/v2/publish?inventionId={CS8__locals8}&permissionLevel={CS8__locals82}`

*first seen: 2019-02-07_18-24-01 — last seen: 2019-07-23_13-56-01 (18 builds)*

**Declared by:** `Inventions.PublishInvention`

**URI parameters:** `CS8__locals7`, `CS8__locals72`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/inventions/v2/save`

*first seen: 2019-02-07_18-24-01 — last seen: 2019-07-23_13-56-01 (18 builds)*

**Declared by:** `Inventions.UploadNewInvention`

**Request body:** WWWForm (application/x-www-form-urlencoded)

| Field | Type |
|-------|------|
| `data` | `byte[]` |
| `newInventionRequest` | `string` |

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

