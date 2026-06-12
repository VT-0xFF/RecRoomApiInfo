# Images

## GetProfileImage

**GET** `api/images/v1/profile/id`

*(first seen: 2016-10-26_20-30-17, last seen: 2017-02-03_23-53-02)*

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(UnityWebRequest www) {
	string error = Core.GetError (www);
	Core.SafeInvoke (callback, error, www.downloadHandler.data);
}
```

---

## RefreshCachedProfileImage

**GET** `api/images/v1/profile/id`

*(first seen: 2016-11-23_01-26-08, last seen: 2017-02-03_23-53-02)*

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(UnityWebRequest www) {
	if (www.responseCode == 200) {
		if (!profileImages.TryGetValue (id, out cachedImage)) {
			cachedImage = new CachedImage ();
			profileImages.Add (id, cachedImage);
		}
		cachedImage.lastModified = www.GetResponseHeader ("LAST-MODIFIED");
		try {
			if (cachedImage.texture == null) {
				cachedImage.texture = new Texture2D (1, 1);
			}
			cachedImage.texture.LoadImage (www.downloadHandler.data);
		} catch (Exception exception) {
			Debug.LogException (exception);
			UnityEngine.Object.Destroy (cachedImage.texture);
			cachedImage.texture = null;
		}
		RaiseProfileImageUpdatedEvent (id, cachedImage.texture);
	}
}
```

---

## SetLocalProfileImage

**POST** `api/images/v1/profile/Profile.LocalProfile.Id`

*(first seen: 2016-10-26_20-30-17, last seen: 2016-11-29_21-32-10)*

**Body:** Form

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(WWW www) {
	RefreshCachedProfileImage (Profile.LocalProfile.Id);
	callback (www.error);
}
```

---

## SetLocalProfileImage

**POST** `api/images/v2/profile`

*(first seen: 2016-12-09_03-11-41, last seen: 2017-02-03_23-53-02)*

**Body:** Form

**Expected Response:**

200 Unhandled response content

**Callback(s):**
```cs
delegate(string error) {
	RefreshCachedProfileImage (Profiles.LocalProfile.Id);
	Core.SafeInvoke (callback, error);
}
```

---

