# PlayerReporting

## CreateReport

**POST** `api/PlayerReporting/v1/create`

*(first seen: 2017-01-18_01-10-07, last seen: 2017-02-03_23-53-02)*

**Body:** Form

| Field | Value |
|-------|-------|
| `PlayerIdReported` | `playerId.ToString ()` |
| `ReportCategory` | `num.ToString ()` |
| `Activity` | `RecRoomSceneManager.CurrentSceneName` |

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(string wwwError) {
	if (!string.IsNullOrEmpty (wwwError)) {
		Debug.LogError ("Failed to report player" + wwwError);
		reportedPlayerIds.Remove (playerId);
	}
}
```

---

