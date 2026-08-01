# Groups

_Generated from the mono-era `Assembly-CSharp.dll` builds in `DLLs/`._

## GET `api/groups/v1`

*first seen: 2018-05-26_01-00-13 — last seen: 2018-12-06_21-26-17 (36 builds)*

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
lNIOBJAMBGA
```

</details>

---

## POST `api/groups/v1`

*first seen: 2018-12-14_19-12-52 — last seen: 2021-08-06_06-02-59 (127 builds)*

**Declared by:** `Groups.CreateNewGroup`

**Request body:** application/json

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## POST `api/groups/v1/delete/{CS8__locals5}`

*first seen: 2018-12-14_19-12-52 — last seen: 2021-08-06_06-02-59 (74 builds)*

**Declared by:** `Groups.DeleteGroup`

**URI parameters:** `CS8__locals5`

**Request body:** form fields (Dictionary<string,string>)

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
true
```

</details>

---

## GET `api/groups/v1/delete/{param}`

*first seen: 2018-05-26_01-00-13 — last seen: 2018-12-06_21-26-17 (36 builds)*

**URI parameters:** `param`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
dictionary
```

</details>

---

## GET `api/groups/v1/name/{param}`

*first seen: 2018-05-26_01-00-13 — last seen: 2021-08-06_06-02-59 (163 builds)*

**Declared by:** `Groups.GetGroupByName`

**URI parameters:** `groupName`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num2 != 0
```

</details>

---

## GET `api/groups/v1/{arg}`

*first seen: 2018-05-26_01-00-13 — last seen: 2021-03-12_03-49-58 (91 builds)*

**Declared by:** `Groups.GetGroupDetails`

**URI parameters:** `arg`

**Response:**

`200 OK` — body not consumed by the client (error-only callback)

<details><summary>Client-side callback</summary>

```cs
(byte)num2 != 0
```

</details>

---

