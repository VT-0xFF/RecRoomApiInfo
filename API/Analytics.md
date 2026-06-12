# Analytics

## Event

**POST** `api/analytics/v1/session/event`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Body:** Form

| Field | Value |
|-------|-------|
| `SessionId` | `Core.SessionId.ToString ()` |
| `Category` | `string` |
| `Action` | `string` |
| `Label` | `string` |
| `Value` | `value.Value.ToString ("F3")` |
| `Value2` | `value2.Value.ToString ("F3")` |
| `Value3` | `value3.Value.ToString ("F3")` |

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
callback
```

---

