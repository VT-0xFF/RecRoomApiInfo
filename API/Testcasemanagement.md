# Testcasemanagement

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## GET `api/testcasemanagement/v1/testcase/{param}`

*first seen: 2018-11-15_20-00-52 — last seen: 2021-08-06_06-02-59 (132 builds)*

**Declared by:** `TestCaseManagement.GetTestCase`

**URI parameters:** `id`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/testcasemanagement/v1/testcase/{param}/claim`

*first seen: 2018-11-05_23-42-06 — last seen: 2018-12-06_21-26-17 (7 builds)*

**URI parameters:** `param`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
kBBKBACEPDG
```

</details>

---

## POST `api/testcasemanagement/v1/testcase/{param}/claim`

*first seen: 2018-12-14_19-12-52 — last seen: 2021-08-06_06-02-59 (127 builds)*

**Declared by:** `TestCaseManagement.ClaimTestCase`

**URI parameters:** `testCaseId`

**Request body:** form fields (Dictionary<string,string>)

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/testcasemanagement/v1/testcase/{param}/status`

*first seen: 2018-11-05_23-42-06 — last seen: 2018-12-06_21-26-17 (7 builds)*

**URI parameters:** `param`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
hKBGPJJNELK
```

</details>

---

## POST `api/testcasemanagement/v1/testcase/{param}/status`

*first seen: 2018-12-14_19-12-52 — last seen: 2021-08-06_06-02-59 (127 builds)*

**Declared by:** `TestCaseManagement.UpdateTestCaseStatus`

**URI parameters:** `testCaseId`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/testcasemanagement/v1/testcase/{param}/unclaim`

*first seen: 2018-11-05_23-42-06 — last seen: 2018-12-06_21-26-17 (7 builds)*

**URI parameters:** `param`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
kBBKBACEPDG
```

</details>

---

## POST `api/testcasemanagement/v1/testcase/{param}/unclaim`

*first seen: 2018-12-14_19-12-52 — last seen: 2021-08-06_06-02-59 (127 builds)*

**Declared by:** `TestCaseManagement.UnclaimTestCase`

**URI parameters:** `testCaseId`

**Request body:** form fields (Dictionary<string,string>)

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/testcasemanagement/v1/testpass/{param}`

*first seen: 2018-11-15_20-00-52 — last seen: 2018-12-06_21-26-17 (5 builds)*

**URI parameters:** `param`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
eBFAHANHHHI
```

</details>

---

## GET `api/testcasemanagement/v1/testpasssummary`

*first seen: 2018-11-15_20-00-52 — last seen: 2021-08-06_06-02-59 (132 builds)*

**Declared by:** `TestCaseManagement.GetTestPassSummaries`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

