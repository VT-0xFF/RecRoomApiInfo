using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using CodeStage.AntiCheat.Common;
using CodeStage.AntiCheat.Detectors;
using CodeStage.AntiCheat.ObscuredTypes;
using CodeStage.AntiCheat.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: AssemblyVersion("0.0.0.0")]
namespace CodeStage.AntiCheat.Examples
{
	[AddComponentMenu("")]
	public class ActRotatorExample : MonoBehaviour
	{
		[Range(1f, 100f)]
		public float speed = 5f;

		private void Update()
		{
			base.transform.Rotate(0f, speed * Time.deltaTime, 0f);
		}
	}
	[AddComponentMenu("")]
	public class ActTesterGui : MonoBehaviour
	{
		private const string RED_COLOR = "#FF4040";

		private const string GREEN_COLOR = "#02C85F";

		private const string PREFS_STRING = "name";

		private const string PREFS_INT = "money";

		private const string PREFS_FLOAT = "lifeBar";

		private const string PREFS_BOOL = "gameComplete";

		private const string PREFS_UINT = "demoUint";

		private const string PREFS_LONG = "demoLong";

		private const string PREFS_DOUBLE = "demoDouble";

		private const string PREFS_VECTOR2 = "demoVector2";

		private const string PREFS_VECTOR3 = "demoVector3";

		private const string PREFS_QUATERNION = "demoQuaternion";

		private const string PREFS_RECT = "demoRect";

		private const string PREFS_COLOR = "demoColor";

		private const string PREFS_BYTE_ARRAY = "demoByteArray";

		private const string API_URL_LOCK_TO_DEVICE = "http://j.mp/1gxg1tf";

		private const string API_URL_PRESERVE_PREFS = "http://j.mp/1iBK5pz";

		private const string API_URL_EMERGENCY_MODE = "http://j.mp/1FRAL5L";

		private const string API_URL_READ_FOREIGN = "http://j.mp/1LCdpDa";

		private const string API_URL_UNOBSCURED_MODE = "http://j.mp/1KVrpxi";

		private const string API_URL_PLAYER_PREFS = "http://docs.unity3d.com/ScriptReference/PlayerPrefs.html";

		[Header("Regular variables")]
		public string regularString = "I'm regular string";

		public int regularInt = 1987;

		public float regularFloat = 2013.0524f;

		public Vector3 regularVector3 = new Vector3(10.5f, 11.5f, 12.5f);

		[Header("Obscured (secure) variables")]
		public ObscuredString obscuredString = "I'm obscured string";

		public ObscuredInt obscuredInt = 1987;

		public ObscuredFloat obscuredFloat = 2013.0524f;

		public ObscuredVector3 obscuredVector3 = new Vector3(10.5f, 11.5f, 12.5f);

		public ObscuredBool obscuredBool = true;

		public ObscuredLong obscuredLong = 945678987654123345L;

		public ObscuredDouble obscuredDouble = 9.45678987654;

		public ObscuredVector2 obscuredVector2 = new Vector2(8.5f, 9.5f);

		[Header("Other")]
		public string prefsEncryptionKey = "change me!";

		private readonly string[] tabs = new string[3] { "Variables protection", "Saves protection", "Cheating detectors" };

		private int currentTab;

		private string allSimpleObscuredTypes;

		private string regularPrefs;

		private string obscuredPrefs;

		private int savesLock;

		private bool savesAlterationDetected;

		private bool foreignSavesDetected;

		private bool injectionDetected;

		private bool speedHackDetected;

		private bool obscuredTypeCheatDetected;

		private bool wallHackCheatDetected;

		private readonly StringBuilder logBuilder = new StringBuilder();

		public void OnSpeedHackDetected()
		{
			speedHackDetected = true;
			UnityEngine.Debug.Log("Speed hack Detected!");
		}

		public void OnInjectionDetected()
		{
			injectionDetected = true;
			UnityEngine.Debug.Log("Injection Detected!");
		}

		public void OnInjectionDetectedWithCause(string cause)
		{
			injectionDetected = true;
			UnityEngine.Debug.Log("Injection Detected! Cause: " + cause);
		}

		public void OnObscuredTypeCheatingDetected()
		{
			obscuredTypeCheatDetected = true;
			UnityEngine.Debug.Log("Obscured Vars Cheating Detected!");
		}

		public void OnWallHackDetected()
		{
			wallHackCheatDetected = true;
			UnityEngine.Debug.Log("Wall hack Detected!");
		}

		private void OnValidate()
		{
			if (Application.isPlaying)
			{
				ObscuredPrefs.CryptoKey = prefsEncryptionKey;
			}
		}

		private void Awake()
		{
			ObscuredPrefs.CryptoKey = prefsEncryptionKey;
			ObscuredPrefs.onAlterationDetected = SavesAlterationDetected;
			ObscuredPrefs.onPossibleForeignSavesDetected = ForeignSavesDetected;
		}

		private void Start()
		{
			ObscuredStringExample();
			ObscuredIntExample();
			ObscuredFloatExample();
			ObscuredVector3Example();
			Invoke("RandomizeObscuredVars", UnityEngine.Random.Range(1f, 10f));
		}

		private void RandomizeObscuredVars()
		{
			obscuredInt.RandomizeCryptoKey();
			obscuredFloat.RandomizeCryptoKey();
			obscuredString.RandomizeCryptoKey();
			obscuredVector3.RandomizeCryptoKey();
			Invoke("RandomizeObscuredVars", UnityEngine.Random.Range(1f, 10f));
		}

		private void ObscuredStringExample()
		{
			logBuilder.Length = 0;
			logBuilder.AppendLine("[ACTk] <b>[ ObscuredString test ]</b>");
			ObscuredString.SetNewCryptoKey("I LOVE MY GIRLz");
			string text = "the Goscurry is not a lie ;)";
			logBuilder.AppendLine("Original string:\n" + text);
			ObscuredString obscuredString = text;
			logBuilder.AppendLine("How your string is stored in memory when obscured:\n" + obscuredString.GetEncrypted());
			UnityEngine.Debug.Log(logBuilder);
		}

		private void ObscuredIntExample()
		{
			logBuilder.Length = 0;
			logBuilder.AppendLine("[ACTk] <b>[ ObscuredInt test ]</b>");
			ObscuredInt.SetNewCryptoKey(434523);
			int num = 5;
			logBuilder.AppendLine("Original lives count: " + num);
			ObscuredInt obscuredInt = num;
			logBuilder.AppendLine("How your lives count is stored in memory when obscured: " + obscuredInt.GetEncrypted());
			ObscuredInt.SetNewCryptoKey(666);
			num = obscuredInt;
			obscuredInt = (int)obscuredInt - 2;
			obscuredInt = (int)obscuredInt + num + 10;
			obscuredInt = (int)obscuredInt / 2;
			++obscuredInt;
			ObscuredInt.SetNewCryptoKey(999);
			++obscuredInt;
			--obscuredInt;
			logBuilder.AppendLine(string.Concat("Lives count after few usual operations: ", obscuredInt, " (", obscuredInt.ToString("X"), "h)"));
			UnityEngine.Debug.Log(logBuilder);
		}

		private void ObscuredFloatExample()
		{
			logBuilder.Length = 0;
			logBuilder.AppendLine("[ACTk] <b>[ ObscuredFloat test ]</b>");
			ObscuredFloat.SetNewCryptoKey(404);
			float num = 99.9f;
			logBuilder.AppendLine("Original health bar: " + num);
			ObscuredFloat obscuredFloat = num;
			logBuilder.AppendLine("How your health bar is stored in memory when obscured: " + obscuredFloat.GetEncrypted());
			ObscuredFloat.SetNewCryptoKey(666);
			obscuredFloat = (float)obscuredFloat + 6f;
			obscuredFloat = (float)obscuredFloat - 1.5f;
			++obscuredFloat;
			--obscuredFloat;
			--obscuredFloat;
			obscuredFloat = num - (float)obscuredFloat + 10.5f;
			logBuilder.AppendLine("Health bar after few usual operations: " + obscuredFloat);
			UnityEngine.Debug.Log(logBuilder);
		}

		private void ObscuredVector3Example()
		{
			logBuilder.Length = 0;
			logBuilder.AppendLine("[ACTk] <b>[ ObscuredVector3 test ]</b>");
			ObscuredVector3.SetNewCryptoKey(404);
			Vector3 vector = new Vector3(54.1f, 64.3f, 63.2f);
			logBuilder.AppendLine("Original position: " + vector);
			ObscuredVector3.RawEncryptedVector3 encrypted = ((ObscuredVector3)vector).GetEncrypted();
			logBuilder.AppendLine("How your position is stored in memory when obscured: (" + encrypted.x + ", " + encrypted.y + ", " + encrypted.z + ")");
			UnityEngine.Debug.Log(logBuilder);
		}

		private void SavesAlterationDetected()
		{
			savesAlterationDetected = true;
		}

		private void ForeignSavesDetected()
		{
			foreignSavesDetected = true;
		}

		private void OnGUI()
		{
			GUIStyle gUIStyle = new GUIStyle(GUI.skin.label);
			gUIStyle.alignment = TextAnchor.UpperCenter;
			GUILayout.BeginArea(new Rect(10f, 5f, Screen.width - 20, Screen.height - 10));
			GUILayout.Label("<color=\"#0287C8\"><b>Anti-Cheat Toolkit Sandbox</b></color>", gUIStyle);
			GUILayout.Label("Here you can overview common ACTk features and try to cheat something yourself.", gUIStyle);
			GUILayout.Space(5f);
			currentTab = GUILayout.Toolbar(currentTab, tabs);
			if (currentTab == 0)
			{
				GUILayout.Label("ACTk offers own collection of the secure types to let you protect your variables from <b>ANY</b> memory hacking tools (Cheat Engine, ArtMoney, GameCIH, Game Guardian, etc.).");
				GUILayout.Space(5f);
				using (new HorizontalLayout())
				{
					GUILayout.Label("<b>Obscured types:</b>\n<color=\"#75C4EB\">" + GetAllSimpleObscuredTypes() + "</color>", GUILayout.MinWidth(130f));
					GUILayout.Space(10f);
					using (new VerticalLayout(GUI.skin.box))
					{
						GUILayout.Label("Below you can try to cheat few variables of the regular types and their obscured (secure) analogues (you may change initial values from Tester object inspector):");
						GUILayout.Space(10f);
						using (new HorizontalLayout())
						{
							GUILayout.Label("<b>string:</b> " + regularString, GUILayout.Width(250f));
							if (GUILayout.Button("Add random value"))
							{
								regularString += (char)UnityEngine.Random.Range(97, 122);
							}
							if (GUILayout.Button("Reset"))
							{
								regularString = string.Empty;
							}
						}
						using (new HorizontalLayout())
						{
							GUILayout.Label("<b>ObscuredString:</b> " + obscuredString, GUILayout.Width(250f));
							if (GUILayout.Button("Add random value"))
							{
								obscuredString = (string)obscuredString + (char)UnityEngine.Random.Range(97, 122);
							}
							if (GUILayout.Button("Reset"))
							{
								obscuredString = string.Empty;
							}
						}
						GUILayout.Space(10f);
						using (new HorizontalLayout())
						{
							GUILayout.Label("<b>int:</b> " + regularInt, GUILayout.Width(250f));
							if (GUILayout.Button("Add random value"))
							{
								regularInt += UnityEngine.Random.Range(1, 100);
							}
							if (GUILayout.Button("Reset"))
							{
								regularInt = 0;
							}
						}
						using (new HorizontalLayout())
						{
							GUILayout.Label("<b>ObscuredInt:</b> " + obscuredInt, GUILayout.Width(250f));
							if (GUILayout.Button("Add random value"))
							{
								obscuredInt = (int)obscuredInt + UnityEngine.Random.Range(1, 100);
							}
							if (GUILayout.Button("Reset"))
							{
								obscuredInt = 0;
							}
						}
						GUILayout.Space(10f);
						using (new HorizontalLayout())
						{
							GUILayout.Label("<b>float:</b> " + regularFloat, GUILayout.Width(250f));
							if (GUILayout.Button("Add random value"))
							{
								regularFloat += UnityEngine.Random.Range(1f, 100f);
							}
							if (GUILayout.Button("Reset"))
							{
								regularFloat = 0f;
							}
						}
						using (new HorizontalLayout())
						{
							GUILayout.Label("<b>ObscuredFloat:</b> " + obscuredFloat, GUILayout.Width(250f));
							if (GUILayout.Button("Add random value"))
							{
								obscuredFloat = (float)obscuredFloat + UnityEngine.Random.Range(1f, 100f);
							}
							if (GUILayout.Button("Reset"))
							{
								obscuredFloat = 0f;
							}
						}
						GUILayout.Space(10f);
						using (new HorizontalLayout())
						{
							GUILayout.Label("<b>Vector3:</b> " + regularVector3, GUILayout.Width(250f));
							if (GUILayout.Button("Add random value"))
							{
								regularVector3 += UnityEngine.Random.insideUnitSphere;
							}
							if (GUILayout.Button("Reset"))
							{
								regularVector3 = Vector3.zero;
							}
						}
						using (new HorizontalLayout())
						{
							GUILayout.Label("<b>ObscuredVector3:</b> " + obscuredVector3, GUILayout.Width(250f));
							if (GUILayout.Button("Add random value"))
							{
								obscuredVector3 += UnityEngine.Random.insideUnitSphere;
							}
							if (GUILayout.Button("Reset"))
							{
								obscuredVector3 = Vector3.zero;
							}
						}
					}
				}
			}
			else if (currentTab == 1)
			{
				GUILayout.Label("ACTk has secure layer for the PlayerPrefs: <color=\"#75C4EB\">ObscuredPrefs</color>. It protects data from view, detects any cheating attempts, optionally locks data to the current device and supports additional data types.");
				GUILayout.Space(5f);
				using (new HorizontalLayout())
				{
					GUILayout.Label("<b>Supported types:</b>\n" + GetAllObscuredPrefsDataTypes(), GUILayout.MinWidth(130f));
					using (new VerticalLayout(GUI.skin.box))
					{
						GUILayout.Label("Below you can try to cheat both regular PlayerPrefs and secure ObscuredPrefs:");
						using (new VerticalLayout())
						{
							GUILayout.Label("<color=\"#FF4040\"><b>PlayerPrefs:</b></color>\neasy to cheat, only 3 supported types", gUIStyle);
							GUILayout.Space(5f);
							if (string.IsNullOrEmpty(regularPrefs))
							{
								LoadRegularPrefs();
							}
							using (new HorizontalLayout())
							{
								GUILayout.Label(regularPrefs, GUILayout.Width(270f));
								using (new VerticalLayout())
								{
									using (new HorizontalLayout())
									{
										if (GUILayout.Button("Save"))
										{
											SaveRegularPrefs();
										}
										if (GUILayout.Button("Load"))
										{
											LoadRegularPrefs();
										}
									}
									if (GUILayout.Button("Delete"))
									{
										DeleteRegularPrefs();
									}
								}
							}
						}
						GUILayout.Space(5f);
						using (new VerticalLayout())
						{
							GUILayout.Label("<color=\"#02C85F\"><b>ObscuredPrefs:</b></color>\nsecure, lot of additional types and extra options", gUIStyle);
							GUILayout.Space(5f);
							if (string.IsNullOrEmpty(obscuredPrefs))
							{
								LoadObscuredPrefs();
							}
							using (new HorizontalLayout())
							{
								GUILayout.Label(obscuredPrefs, GUILayout.Width(270f));
								using (new VerticalLayout())
								{
									using (new HorizontalLayout())
									{
										if (GUILayout.Button("Save"))
										{
											SaveObscuredPrefs();
										}
										if (GUILayout.Button("Load"))
										{
											LoadObscuredPrefs();
										}
									}
									if (GUILayout.Button("Delete"))
									{
										DeleteObscuredPrefs();
									}
									using (new HorizontalLayout())
									{
										GUILayout.Label("LockToDevice level");
										PlaceUrlButton("http://j.mp/1gxg1tf");
									}
									savesLock = GUILayout.SelectionGrid(savesLock, new string[3]
									{
										ObscuredPrefs.DeviceLockLevel.None.ToString(),
										ObscuredPrefs.DeviceLockLevel.Soft.ToString(),
										ObscuredPrefs.DeviceLockLevel.Strict.ToString()
									}, 3);
									ObscuredPrefs.lockToDevice = (ObscuredPrefs.DeviceLockLevel)savesLock;
									GUILayout.Space(5f);
									using (new HorizontalLayout())
									{
										ObscuredPrefs.preservePlayerPrefs = GUILayout.Toggle(ObscuredPrefs.preservePlayerPrefs, "preservePlayerPrefs");
										PlaceUrlButton("http://j.mp/1iBK5pz");
									}
									using (new HorizontalLayout())
									{
										ObscuredPrefs.emergencyMode = GUILayout.Toggle(ObscuredPrefs.emergencyMode, "emergencyMode");
										PlaceUrlButton("http://j.mp/1FRAL5L");
									}
									using (new HorizontalLayout())
									{
										ObscuredPrefs.readForeignSaves = GUILayout.Toggle(ObscuredPrefs.readForeignSaves, "readForeignSaves");
										PlaceUrlButton("http://j.mp/1LCdpDa");
									}
									GUILayout.Space(5f);
									GUILayout.Label("<color=\"" + ((!savesAlterationDetected) ? "#02C85F" : "#FF4040") + "\">Saves modification detected: " + savesAlterationDetected + "</color>");
									GUILayout.Label("<color=\"" + ((!foreignSavesDetected) ? "#02C85F" : "#FF4040") + "\">Foreign saves detected: " + foreignSavesDetected + "</color>");
								}
							}
						}
						GUILayout.Space(5f);
						PlaceUrlButton("http://docs.unity3d.com/ScriptReference/PlayerPrefs.html", "Visit docs to see where PlayerPrefs are stored", -1);
					}
				}
			}
			else
			{
				GUILayout.Label("ACTk is able to detect some types of cheating to let you take action on the cheating players. This example scene has all possible detectors and all of them are automatically start on scene start.");
				GUILayout.Space(5f);
				using (new VerticalLayout(GUI.skin.box))
				{
					GUILayout.Label("<b>Speed Hack Detector</b>");
					GUILayout.Label("Allows to detect Cheat Engine's speed hack (and maybe some other speed hack tools) usage.");
					GUILayout.Label("<color=\"" + ((!speedHackDetected) ? "#02C85F" : "#FF4040") + "\">Detected: " + speedHackDetected.ToString().ToLower() + "</color>");
					GUILayout.Space(10f);
					GUILayout.Label("<b>Obscured Cheating Detector</b>");
					GUILayout.Label("Detects cheating of any Obscured type (except ObscuredPrefs, it has own detection features) used in project.");
					GUILayout.Label("<color=\"" + ((!obscuredTypeCheatDetected) ? "#02C85F" : "#FF4040") + "\">Detected: " + obscuredTypeCheatDetected.ToString().ToLower() + "</color>");
					GUILayout.Space(10f);
					GUILayout.Label("<b>WallHack Detector</b>");
					GUILayout.Label("Detects common types of wall hack cheating: walking through the walls (Rigidbody and CharacterController modules), shooting through the walls (Raycast module), looking through the walls (Wireframe module).");
					GUILayout.Label("<color=\"" + ((!wallHackCheatDetected) ? "#02C85F" : "#FF4040") + "\">Detected: " + wallHackCheatDetected.ToString().ToLower() + "</color>");
					GUILayout.Space(10f);
					GUILayout.Label("<b>Injection Detector</b>");
					GUILayout.Label("Allows to detect foreign managed assemblies in your application.");
					GUILayout.Label("<color=\"" + ((!injectionDetected) ? "#02C85F" : "#FF4040") + "\">Detected: " + injectionDetected.ToString().ToLower() + "</color>");
				}
			}
			GUILayout.EndArea();
		}

		private string GetAllSimpleObscuredTypes()
		{
			string result = "Can't use reflection here, sorry :(";
			string types = string.Empty;
			if (string.IsNullOrEmpty(allSimpleObscuredTypes))
			{
				Assembly assembly = AppDomain.CurrentDomain.GetAssemblies().SingleOrDefault((Assembly assembly2) => assembly2.GetName().Name == "Assembly-CSharp");
				if (assembly != null)
				{
					IEnumerable<Type> source = from t in assembly.GetTypes()
						where t.IsPublic && t.Namespace == "CodeStage.AntiCheat.ObscuredTypes" && t.Name != "ObscuredPrefs"
						select t;
					source.ToList().ForEach(delegate(Type t)
					{
						if (types.Length > 0)
						{
							types = types + "\n" + t.Name;
						}
						else
						{
							types += t.Name;
						}
					});
					if (!string.IsNullOrEmpty(types))
					{
						result = types;
						allSimpleObscuredTypes = types;
					}
				}
			}
			else
			{
				result = allSimpleObscuredTypes;
			}
			return result;
		}

		private string GetAllObscuredPrefsDataTypes()
		{
			return "int\nfloat\nstring\n<color=\"#75C4EB\">uint\ndouble\nlong\nbool\nbyte[]\nVector2\nVector3\nQuaternion\nColor\nRect</color>";
		}

		private void LoadRegularPrefs()
		{
			regularPrefs = "int: " + PlayerPrefs.GetInt("money", -1) + "\n";
			string text = regularPrefs;
			regularPrefs = text + "float: " + PlayerPrefs.GetFloat("lifeBar", -1f) + "\n";
			regularPrefs = regularPrefs + "string: " + PlayerPrefs.GetString("name", "No saved PlayerPrefs!");
		}

		private void SaveRegularPrefs()
		{
			PlayerPrefs.SetInt("money", 456);
			PlayerPrefs.SetFloat("lifeBar", 456.789f);
			PlayerPrefs.SetString("name", "Hey, there!");
			PlayerPrefs.Save();
		}

		private void DeleteRegularPrefs()
		{
			PlayerPrefs.DeleteKey("money");
			PlayerPrefs.DeleteKey("lifeBar");
			PlayerPrefs.DeleteKey("name");
			PlayerPrefs.Save();
		}

		private void LoadObscuredPrefs()
		{
			byte[] byteArray = ObscuredPrefs.GetByteArray("demoByteArray", 0, 4);
			obscuredPrefs = "int: " + ObscuredPrefs.GetInt("money", -1) + "\n";
			string text = obscuredPrefs;
			obscuredPrefs = text + "float: " + ObscuredPrefs.GetFloat("lifeBar", -1f) + "\n";
			obscuredPrefs = obscuredPrefs + "string: " + ObscuredPrefs.GetString("name", "No saved ObscuredPrefs!") + "\n";
			text = obscuredPrefs;
			obscuredPrefs = text + "bool: " + ObscuredPrefs.GetBool("gameComplete", defaultValue: false) + "\n";
			text = obscuredPrefs;
			obscuredPrefs = text + "uint: " + ObscuredPrefs.GetUInt("demoUint", 0u) + "\n";
			text = obscuredPrefs;
			obscuredPrefs = text + "long: " + ObscuredPrefs.GetLong("demoLong", -1L) + "\n";
			text = obscuredPrefs;
			obscuredPrefs = text + "double: " + ObscuredPrefs.GetDouble("demoDouble", -1.0) + "\n";
			text = obscuredPrefs;
			obscuredPrefs = string.Concat(text, "Vector2: ", ObscuredPrefs.GetVector2("demoVector2", Vector2.zero), "\n");
			text = obscuredPrefs;
			obscuredPrefs = string.Concat(text, "Vector3: ", ObscuredPrefs.GetVector3("demoVector3", Vector3.zero), "\n");
			text = obscuredPrefs;
			obscuredPrefs = string.Concat(text, "Quaternion: ", ObscuredPrefs.GetQuaternion("demoQuaternion", Quaternion.identity), "\n");
			text = obscuredPrefs;
			obscuredPrefs = string.Concat(text, "Rect: ", ObscuredPrefs.GetRect("demoRect", new Rect(0f, 0f, 0f, 0f)), "\n");
			text = obscuredPrefs;
			obscuredPrefs = string.Concat(text, "Color: ", ObscuredPrefs.GetColor("demoColor", Color.black), "\n");
			text = obscuredPrefs;
			obscuredPrefs = text + "byte[]: {" + byteArray[0] + "," + byteArray[1] + "," + byteArray[2] + "," + byteArray[3] + "}";
		}

		private void SaveObscuredPrefs()
		{
			ObscuredPrefs.SetInt("money", 123);
			ObscuredPrefs.SetFloat("lifeBar", 123.456f);
			ObscuredPrefs.SetString("name", "Goscurry is not a lie ;)");
			ObscuredPrefs.SetBool("gameComplete", value: true);
			ObscuredPrefs.SetUInt("demoUint", 1234567891u);
			ObscuredPrefs.SetLong("demoLong", 1234567891234567890L);
			ObscuredPrefs.SetDouble("demoDouble", 1.234567890123456);
			ObscuredPrefs.SetVector2("demoVector2", Vector2.one);
			ObscuredPrefs.SetVector3("demoVector3", Vector3.one);
			ObscuredPrefs.SetQuaternion("demoQuaternion", Quaternion.Euler(new Vector3(10f, 20f, 30f)));
			ObscuredPrefs.SetRect("demoRect", new Rect(1.5f, 2.6f, 3.7f, 4.8f));
			ObscuredPrefs.SetColor("demoColor", Color.red);
			ObscuredPrefs.SetByteArray("demoByteArray", new byte[4] { 44, 104, 43, 32 });
			ObscuredPrefs.Save();
		}

		private void DeleteObscuredPrefs()
		{
			ObscuredPrefs.DeleteKey("money");
			ObscuredPrefs.DeleteKey("lifeBar");
			ObscuredPrefs.DeleteKey("name");
			ObscuredPrefs.DeleteKey("gameComplete");
			ObscuredPrefs.DeleteKey("demoUint");
			ObscuredPrefs.DeleteKey("demoLong");
			ObscuredPrefs.DeleteKey("demoDouble");
			ObscuredPrefs.DeleteKey("demoVector2");
			ObscuredPrefs.DeleteKey("demoVector3");
			ObscuredPrefs.DeleteKey("demoQuaternion");
			ObscuredPrefs.DeleteKey("demoRect");
			ObscuredPrefs.DeleteKey("demoColor");
			ObscuredPrefs.DeleteKey("demoByteArray");
			ObscuredPrefs.Save();
		}

		private void PlaceUrlButton(string url)
		{
			PlaceUrlButton(url, 30);
		}

		private void PlaceUrlButton(string url, int width)
		{
			PlaceUrlButton(url, "?", width);
		}

		private void PlaceUrlButton(string url, string buttonName, int width)
		{
			GUILayoutOption[] array = new GUILayoutOption[1];
			if (width != -1)
			{
				array[0] = GUILayout.Width(width);
			}
			else
			{
				array = null;
			}
			if (GUILayout.Button(buttonName, array))
			{
				Application.OpenURL(url);
			}
		}

		private void OnApplicationQuit()
		{
			DeleteRegularPrefs();
			DeleteObscuredPrefs();
		}
	}
	internal class HorizontalLayout : IDisposable
	{
		public HorizontalLayout(params GUILayoutOption[] options)
		{
			GUILayout.BeginHorizontal(options);
		}

		public void Dispose()
		{
			GUILayout.EndHorizontal();
		}
	}
	internal class VerticalLayout : IDisposable
	{
		public VerticalLayout(params GUILayoutOption[] options)
		{
			GUILayout.BeginVertical(options);
		}

		public VerticalLayout(GUIStyle style)
		{
			GUILayout.BeginVertical(style);
		}

		public void Dispose()
		{
			GUILayout.EndHorizontal();
		}
	}
	[AddComponentMenu("")]
	public class ObscuredPerformanceTests : MonoBehaviour
	{
		public bool boolTest = true;

		public int boolIterations = 2500000;

		public bool byteTest = true;

		public int byteIterations = 2500000;

		public bool shortTest = true;

		public int shortIterations = 2500000;

		public bool ushortTest = true;

		public int ushortIterations = 2500000;

		public bool intTest = true;

		public int intIterations = 2500000;

		public bool uintTest = true;

		public int uintIterations = 2500000;

		public bool longTest = true;

		public int longIterations = 2500000;

		public bool floatTest = true;

		public int floatIterations = 2500000;

		public bool doubleTest = true;

		public int doubleIterations = 2500000;

		public bool stringTest = true;

		public int stringIterations = 250000;

		public bool vector3Test = true;

		public int vector3Iterations = 2500000;

		public bool prefsTest = true;

		public int prefsIterations = 2500;

		private readonly StringBuilder logBuilder = new StringBuilder();

		private void Start()
		{
			Invoke("StartTests", 1f);
		}

		private void StartTests()
		{
			logBuilder.Length = 0;
			logBuilder.AppendLine("[ACTk] <b>[ Performance tests ]</b>");
			if (boolTest)
			{
				TestBool();
			}
			if (byteTest)
			{
				TestByte();
			}
			if (shortTest)
			{
				TestShort();
			}
			if (ushortTest)
			{
				TestUShort();
			}
			if (intTest)
			{
				TestInt();
			}
			if (uintTest)
			{
				TestUInt();
			}
			if (longTest)
			{
				TestLong();
			}
			if (floatTest)
			{
				TestFloat();
			}
			if (doubleTest)
			{
				TestDouble();
			}
			if (stringTest)
			{
				TestString();
			}
			if (vector3Test)
			{
				TestVector3();
			}
			if (prefsTest)
			{
				TestPrefs();
			}
			UnityEngine.Debug.Log(logBuilder);
		}

		private void TestBool()
		{
			logBuilder.AppendLine("ObscuredBool vs bool, " + boolIterations + " iterations for read and write");
			ObscuredBool obscuredBool = true;
			bool flag = obscuredBool;
			bool flag2 = false;
			Stopwatch stopwatch = Stopwatch.StartNew();
			for (int i = 0; i < boolIterations; i++)
			{
				flag2 = obscuredBool;
			}
			for (int j = 0; j < boolIterations; j++)
			{
				obscuredBool = flag2;
			}
			stopwatch.Stop();
			logBuilder.AppendLine("ObscuredBool:").AppendLine(stopwatch.ElapsedMilliseconds + " ms");
			stopwatch.Reset();
			stopwatch.Start();
			for (int k = 0; k < boolIterations; k++)
			{
				flag2 = flag;
			}
			for (int l = 0; l < boolIterations; l++)
			{
				flag = flag2;
			}
			stopwatch.Stop();
			logBuilder.AppendLine("bool:").AppendLine(stopwatch.ElapsedMilliseconds + " ms");
			if (flag2)
			{
			}
			if ((bool)obscuredBool)
			{
			}
			if (!flag)
			{
			}
		}

		private void TestByte()
		{
			logBuilder.AppendLine("ObscuredByte vs byte, " + byteIterations + " iterations for read and write");
			ObscuredByte obscuredByte = (byte)100;
			byte b = obscuredByte;
			byte b2 = 0;
			Stopwatch stopwatch = Stopwatch.StartNew();
			for (int i = 0; i < byteIterations; i++)
			{
				b2 = obscuredByte;
			}
			for (int j = 0; j < byteIterations; j++)
			{
				obscuredByte = b2;
			}
			stopwatch.Stop();
			logBuilder.AppendLine("ObscuredByte:").AppendLine(stopwatch.ElapsedMilliseconds + " ms");
			stopwatch.Reset();
			stopwatch.Start();
			for (int k = 0; k < byteIterations; k++)
			{
				b2 = b;
			}
			for (int l = 0; l < byteIterations; l++)
			{
				b = b2;
			}
			stopwatch.Stop();
			logBuilder.AppendLine("byte:").AppendLine(stopwatch.ElapsedMilliseconds + " ms");
			if (b2 != 0)
			{
			}
			if ((byte)obscuredByte != 0)
			{
			}
			if (b == 0)
			{
			}
		}

		private void TestShort()
		{
			logBuilder.AppendLine("ObscuredShort vs short, " + shortIterations + " iterations for read and write");
			ObscuredShort obscuredShort = (short)100;
			short num = obscuredShort;
			short num2 = 0;
			Stopwatch stopwatch = Stopwatch.StartNew();
			for (int i = 0; i < shortIterations; i++)
			{
				num2 = obscuredShort;
			}
			for (int j = 0; j < shortIterations; j++)
			{
				obscuredShort = num2;
			}
			stopwatch.Stop();
			logBuilder.AppendLine("ObscuredShort:").AppendLine(stopwatch.ElapsedMilliseconds + " ms");
			stopwatch.Reset();
			stopwatch.Start();
			for (int k = 0; k < shortIterations; k++)
			{
				num2 = num;
			}
			for (int l = 0; l < shortIterations; l++)
			{
				num = num2;
			}
			stopwatch.Stop();
			logBuilder.AppendLine("short:").AppendLine(stopwatch.ElapsedMilliseconds + " ms");
			if (num2 != 0)
			{
			}
			if ((short)obscuredShort != 0)
			{
			}
			if (num == 0)
			{
			}
		}

		private void TestUShort()
		{
			logBuilder.AppendLine("ObscuredUShort vs ushort, " + ushortIterations + " iterations for read and write");
			ObscuredUShort obscuredUShort = (ushort)100;
			ushort num = obscuredUShort;
			ushort num2 = 0;
			Stopwatch stopwatch = Stopwatch.StartNew();
			for (int i = 0; i < ushortIterations; i++)
			{
				num2 = obscuredUShort;
			}
			for (int j = 0; j < ushortIterations; j++)
			{
				obscuredUShort = num2;
			}
			stopwatch.Stop();
			logBuilder.AppendLine("ObscuredUShort:").AppendLine(stopwatch.ElapsedMilliseconds + " ms");
			stopwatch.Reset();
			stopwatch.Start();
			for (int k = 0; k < ushortIterations; k++)
			{
				num2 = num;
			}
			for (int l = 0; l < ushortIterations; l++)
			{
				num = num2;
			}
			stopwatch.Stop();
			logBuilder.AppendLine("ushort:").AppendLine(stopwatch.ElapsedMilliseconds + " ms");
			if (num2 != 0)
			{
			}
			if ((ushort)obscuredUShort != 0)
			{
			}
			if (num == 0)
			{
			}
		}

		private void TestDouble()
		{
			logBuilder.AppendLine("ObscuredDouble vs double, " + doubleIterations + " iterations for read and write");
			ObscuredDouble obscuredDouble = 100.0;
			double num = obscuredDouble;
			double num2 = 0.0;
			Stopwatch stopwatch = Stopwatch.StartNew();
			for (int i = 0; i < doubleIterations; i++)
			{
				num2 = obscuredDouble;
			}
			for (int j = 0; j < doubleIterations; j++)
			{
				obscuredDouble = num2;
			}
			stopwatch.Stop();
			logBuilder.AppendLine("ObscuredDouble:").AppendLine(stopwatch.ElapsedMilliseconds + " ms");
			stopwatch.Reset();
			stopwatch.Start();
			for (int k = 0; k < doubleIterations; k++)
			{
				num2 = num;
			}
			for (int l = 0; l < doubleIterations; l++)
			{
				num = num2;
			}
			stopwatch.Stop();
			logBuilder.AppendLine("double:").AppendLine(stopwatch.ElapsedMilliseconds + " ms");
			if (num2 != 0.0)
			{
			}
			if ((double)obscuredDouble != 0.0)
			{
			}
			if (num == 0.0)
			{
			}
		}

		private void TestFloat()
		{
			logBuilder.AppendLine("ObscuredFloat vs float, " + floatIterations + " iterations for read and write");
			ObscuredFloat obscuredFloat = 100f;
			float num = obscuredFloat;
			float num2 = 0f;
			Stopwatch stopwatch = Stopwatch.StartNew();
			for (int i = 0; i < floatIterations; i++)
			{
				num2 = obscuredFloat;
			}
			for (int j = 0; j < floatIterations; j++)
			{
				obscuredFloat = num2;
			}
			stopwatch.Stop();
			logBuilder.AppendLine("ObscuredFloat:").AppendLine(stopwatch.ElapsedMilliseconds + " ms");
			stopwatch.Reset();
			stopwatch.Start();
			for (int k = 0; k < floatIterations; k++)
			{
				num2 = num;
			}
			for (int l = 0; l < floatIterations; l++)
			{
				num = num2;
			}
			stopwatch.Stop();
			logBuilder.AppendLine("float:").AppendLine(stopwatch.ElapsedMilliseconds + " ms");
			if (num2 != 0f)
			{
			}
			if ((float)obscuredFloat != 0f)
			{
			}
			if (num == 0f)
			{
			}
		}

		private void TestInt()
		{
			logBuilder.AppendLine("ObscuredInt vs int, " + intIterations + " iterations for read and write");
			ObscuredInt obscuredInt = 100;
			int num = obscuredInt;
			int num2 = 0;
			Stopwatch stopwatch = Stopwatch.StartNew();
			for (int i = 0; i < intIterations; i++)
			{
				num2 = obscuredInt;
			}
			for (int j = 0; j < intIterations; j++)
			{
				obscuredInt = num2;
			}
			stopwatch.Stop();
			logBuilder.AppendLine("ObscuredInt:").AppendLine(stopwatch.ElapsedMilliseconds + " ms");
			stopwatch.Reset();
			stopwatch.Start();
			for (int k = 0; k < intIterations; k++)
			{
				num2 = num;
			}
			for (int l = 0; l < intIterations; l++)
			{
				num = num2;
			}
			stopwatch.Stop();
			logBuilder.AppendLine("int:").AppendLine(stopwatch.ElapsedMilliseconds + " ms");
			if (num2 != 0)
			{
			}
			if ((int)obscuredInt != 0)
			{
			}
			if (num == 0)
			{
			}
		}

		private void TestLong()
		{
			logBuilder.AppendLine("ObscuredLong vs long, " + longIterations + " iterations for read and write");
			ObscuredLong obscuredLong = 100L;
			long num = obscuredLong;
			long num2 = 0L;
			Stopwatch stopwatch = Stopwatch.StartNew();
			for (int i = 0; i < longIterations; i++)
			{
				num2 = obscuredLong;
			}
			for (int j = 0; j < longIterations; j++)
			{
				obscuredLong = num2;
			}
			stopwatch.Stop();
			logBuilder.AppendLine("ObscuredLong:").AppendLine(stopwatch.ElapsedMilliseconds + " ms");
			stopwatch.Reset();
			stopwatch.Start();
			for (int k = 0; k < longIterations; k++)
			{
				num2 = num;
			}
			for (int l = 0; l < longIterations; l++)
			{
				num = num2;
			}
			stopwatch.Stop();
			logBuilder.AppendLine("long:").AppendLine(stopwatch.ElapsedMilliseconds + " ms");
			if (num2 != 0L)
			{
			}
			if ((long)obscuredLong != 0L)
			{
			}
			if (num == 0L)
			{
			}
		}

		private void TestString()
		{
			logBuilder.AppendLine("ObscuredString vs string, " + stringIterations + " iterations for read and write");
			ObscuredString obscuredString = "abcd";
			string text = obscuredString;
			string text2 = string.Empty;
			Stopwatch stopwatch = Stopwatch.StartNew();
			for (int i = 0; i < stringIterations; i++)
			{
				text2 = obscuredString;
			}
			for (int j = 0; j < stringIterations; j++)
			{
				obscuredString = text2;
			}
			stopwatch.Stop();
			logBuilder.AppendLine("ObscuredString:").AppendLine(stopwatch.ElapsedMilliseconds + " ms");
			stopwatch.Reset();
			stopwatch.Start();
			for (int k = 0; k < stringIterations; k++)
			{
				text2 = text;
			}
			for (int l = 0; l < stringIterations; l++)
			{
				text = text2;
			}
			stopwatch.Stop();
			logBuilder.AppendLine("string:").AppendLine(stopwatch.ElapsedMilliseconds + " ms");
			if (text2 != string.Empty)
			{
			}
			if (obscuredString != (ObscuredString)string.Empty)
			{
			}
			if (!(text != string.Empty))
			{
			}
		}

		private void TestUInt()
		{
			logBuilder.AppendLine("ObscuredUInt vs uint, " + uintIterations + " iterations for read and write");
			ObscuredUInt obscuredUInt = 100u;
			uint num = obscuredUInt;
			uint num2 = 0u;
			Stopwatch stopwatch = Stopwatch.StartNew();
			for (int i = 0; i < uintIterations; i++)
			{
				num2 = obscuredUInt;
			}
			for (int j = 0; j < uintIterations; j++)
			{
				obscuredUInt = num2;
			}
			stopwatch.Stop();
			logBuilder.AppendLine("ObscuredUInt:").AppendLine(stopwatch.ElapsedMilliseconds + " ms");
			stopwatch.Reset();
			stopwatch.Start();
			for (int k = 0; k < uintIterations; k++)
			{
				num2 = num;
			}
			for (int l = 0; l < uintIterations; l++)
			{
				num = num2;
			}
			stopwatch.Stop();
			logBuilder.AppendLine("uint:").AppendLine(stopwatch.ElapsedMilliseconds + " ms");
			if (num2 != 0)
			{
			}
			if ((uint)obscuredUInt != 0)
			{
			}
			if (num == 0)
			{
			}
		}

		private void TestVector3()
		{
			logBuilder.AppendLine("ObscuredVector3 vs Vector3, " + vector3Iterations + " iterations for read and write");
			ObscuredVector3 obscuredVector = new Vector3(1f, 2f, 3f);
			Vector3 vector = obscuredVector;
			Vector3 vector2 = new Vector3(0f, 0f, 0f);
			Stopwatch stopwatch = Stopwatch.StartNew();
			for (int i = 0; i < vector3Iterations; i++)
			{
				vector2 = obscuredVector;
			}
			for (int j = 0; j < vector3Iterations; j++)
			{
				obscuredVector = vector2;
			}
			stopwatch.Stop();
			logBuilder.AppendLine("ObscuredVector3:").AppendLine(stopwatch.ElapsedMilliseconds + " ms");
			stopwatch.Reset();
			stopwatch.Start();
			for (int k = 0; k < vector3Iterations; k++)
			{
				vector2 = vector;
			}
			for (int l = 0; l < vector3Iterations; l++)
			{
				vector = vector2;
			}
			stopwatch.Stop();
			logBuilder.AppendLine("Vector3:").AppendLine(stopwatch.ElapsedMilliseconds + " ms");
			if (vector2 != Vector3.zero)
			{
			}
			if (obscuredVector != Vector3.zero)
			{
			}
			if (!(vector != Vector3.zero))
			{
			}
		}

		private void TestPrefs()
		{
			logBuilder.AppendLine("ObscuredPrefs vs PlayerPrefs, " + prefsIterations + " iterations for read and write");
			Stopwatch stopwatch = Stopwatch.StartNew();
			for (int i = 0; i < prefsIterations; i++)
			{
				ObscuredPrefs.SetInt("__a", 1);
				ObscuredPrefs.SetFloat("__b", 2f);
				ObscuredPrefs.SetString("__c", "3");
			}
			for (int j = 0; j < prefsIterations; j++)
			{
				ObscuredPrefs.GetInt("__a", 1);
				ObscuredPrefs.GetFloat("__b", 2f);
				ObscuredPrefs.GetString("__c", "3");
			}
			stopwatch.Stop();
			logBuilder.AppendLine("ObscuredPrefs:").AppendLine(stopwatch.ElapsedMilliseconds + " ms");
			ObscuredPrefs.DeleteKey("__a");
			ObscuredPrefs.DeleteKey("__b");
			ObscuredPrefs.DeleteKey("__c");
			stopwatch.Reset();
			stopwatch.Start();
			for (int k = 0; k < prefsIterations; k++)
			{
				PlayerPrefs.SetInt("__a", 1);
				PlayerPrefs.SetFloat("__b", 2f);
				PlayerPrefs.SetString("__c", "3");
			}
			for (int l = 0; l < prefsIterations; l++)
			{
				PlayerPrefs.GetInt("__a", 1);
				PlayerPrefs.GetFloat("__b", 2f);
				PlayerPrefs.GetString("__c", "3");
			}
			stopwatch.Stop();
			logBuilder.AppendLine("PlayerPrefs:").AppendLine(stopwatch.ElapsedMilliseconds + " ms");
			PlayerPrefs.DeleteKey("__a");
			PlayerPrefs.DeleteKey("__b");
			PlayerPrefs.DeleteKey("__c");
		}
	}
}
namespace CodeStage.AntiCheat.Common
{
	[Serializable]
	public struct ACTkByte16
	{
		public byte b1;

		public byte b2;

		public byte b3;

		public byte b4;

		public byte b5;

		public byte b6;

		public byte b7;

		public byte b8;

		public byte b9;

		public byte b10;

		public byte b11;

		public byte b12;

		public byte b13;

		public byte b14;

		public byte b15;

		public byte b16;
	}
	[Serializable]
	public struct ACTkByte4
	{
		public byte b1;

		public byte b2;

		public byte b3;

		public byte b4;
	}
	[Serializable]
	public struct ACTkByte8
	{
		public byte b1;

		public byte b2;

		public byte b3;

		public byte b4;

		public byte b5;

		public byte b6;

		public byte b7;

		public byte b8;
	}
	internal class Constants
	{
		internal const string LOG_PREFIX = "[ACTk] ";
	}
}
namespace CodeStage.AntiCheat.Detectors
{
	[AddComponentMenu("")]
	public abstract class ActDetectorBase : MonoBehaviour
	{
		protected const string CONTAINER_NAME = "Anti-Cheat Toolkit Detectors";

		protected const string MENU_PATH = "Code Stage/Anti-Cheat Toolkit/";

		protected const string GAME_OBJECT_MENU_PATH = "GameObject/Create Other/Code Stage/Anti-Cheat Toolkit/";

		protected static GameObject detectorsContainer;

		[Tooltip("Automatically start detector. Detection Event will be called on detection.")]
		public bool autoStart = true;

		[Tooltip("Detector will survive new level (scene) load if checked.")]
		public bool keepAlive = true;

		[Tooltip("Automatically dispose Detector after firing callback.")]
		public bool autoDispose = true;

		[SerializeField]
		protected UnityEvent detectionEvent;

		protected UnityAction detectionAction;

		[SerializeField]
		protected bool detectionEventHasListener;

		protected bool isRunning;

		protected bool started;

		private void Start()
		{
			if (detectorsContainer == null && base.gameObject.name == "Anti-Cheat Toolkit Detectors")
			{
				detectorsContainer = base.gameObject;
			}
			if (autoStart && !started)
			{
				StartDetectionAutomatically();
			}
		}

		private void OnEnable()
		{
			if (started && (detectionEventHasListener || detectionAction != null || DetectorHasAdditionalCallbacks()))
			{
				ResumeDetector();
			}
		}

		private void OnDisable()
		{
			if (started)
			{
				PauseDetector();
			}
		}

		private void OnApplicationQuit()
		{
			DisposeInternal();
		}

		protected virtual void OnDestroy()
		{
			StopDetectionInternal();
			if (base.transform.childCount == 0 && GetComponentsInChildren<Component>().Length <= 2)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			else if (base.name == "Anti-Cheat Toolkit Detectors" && GetComponentsInChildren<ActDetectorBase>().Length <= 1)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}

		protected virtual bool Init(ActDetectorBase instance, string detectorName)
		{
			if (instance != null && instance != this && instance.keepAlive)
			{
				UnityEngine.Debug.LogWarning("[ACTk] " + base.name + ": self-destroying, other instance already exists & only one instance allowed!", base.gameObject);
				UnityEngine.Object.Destroy(this);
				return false;
			}
			UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
			return true;
		}

		protected virtual void DisposeInternal()
		{
			UnityEngine.Object.Destroy(this);
		}

		protected virtual bool DetectorHasAdditionalCallbacks()
		{
			return false;
		}

		internal virtual void OnCheatingDetected()
		{
			if (detectionAction != null)
			{
				detectionAction();
			}
			if (detectionEventHasListener)
			{
				detectionEvent.Invoke();
			}
			if (autoDispose)
			{
				DisposeInternal();
			}
			else
			{
				StopDetectionInternal();
			}
		}

		protected abstract void StartDetectionAutomatically();

		protected abstract void StopDetectionInternal();

		protected abstract void PauseDetector();

		protected abstract void ResumeDetector();
	}
	[AddComponentMenu("Code Stage/Anti-Cheat Toolkit/Injection Detector")]
	public class InjectionDetector : ActDetectorBase
	{
		private class AllowedAssembly
		{
			public readonly string name;

			public readonly int[] hashes;

			public AllowedAssembly(string name, int[] hashes)
			{
				this.name = name;
				this.hashes = hashes;
			}
		}

		internal const string COMPONENT_NAME = "Injection Detector";

		internal const string FINAL_LOG_PREFIX = "[ACTk] Injection Detector: ";

		protected UnityAction<string> detectionActionWithArgument;

		private static int instancesInScene;

		private bool signaturesAreNotGenuine;

		private AllowedAssembly[] allowedAssemblies;

		private string[] hexTable;

		public static InjectionDetector Instance { get; private set; }

		private static InjectionDetector GetOrCreateInstance
		{
			get
			{
				if (Instance != null)
				{
					return Instance;
				}
				if (ActDetectorBase.detectorsContainer == null)
				{
					ActDetectorBase.detectorsContainer = new GameObject("Anti-Cheat Toolkit Detectors");
				}
				Instance = ActDetectorBase.detectorsContainer.AddComponent<InjectionDetector>();
				return Instance;
			}
		}

		private InjectionDetector()
		{
		}

		public static void StartDetection()
		{
			if (Instance != null)
			{
				Instance.StartDetectionInternal(null, null);
			}
			else
			{
				UnityEngine.Debug.LogError("[ACTk] Injection Detector: can't be started since it doesn't exists in scene or not yet initialized!");
			}
		}

		public static void StartDetection(UnityAction callback)
		{
			GetOrCreateInstance.StartDetectionInternal(callback, null);
		}

		public static void StartDetection(UnityAction<string> callback)
		{
			GetOrCreateInstance.StartDetectionInternal(null, callback);
		}

		public static void StopDetection()
		{
			if (Instance != null)
			{
				Instance.StopDetectionInternal();
			}
		}

		public static void Dispose()
		{
			if (Instance != null)
			{
				Instance.DisposeInternal();
			}
		}

		private void Awake()
		{
			instancesInScene++;
			if (Init(Instance, "Injection Detector"))
			{
				Instance = this;
			}
			SceneManager.sceneLoaded += OnLevelWasLoadedNew;
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();
			instancesInScene--;
		}

		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
			OnLevelLoadedCallback();
		}

		private void OnLevelLoadedCallback()
		{
			if (instancesInScene < 2)
			{
				if (!keepAlive)
				{
					DisposeInternal();
				}
			}
			else if (!keepAlive && Instance != this)
			{
				DisposeInternal();
			}
		}

		private void StartDetectionInternal(UnityAction callback, UnityAction<string> callbackWithArgument)
		{
			if (isRunning)
			{
				UnityEngine.Debug.LogWarning("[ACTk] Injection Detector: already running!", this);
				return;
			}
			if (!base.enabled)
			{
				UnityEngine.Debug.LogWarning("[ACTk] Injection Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!", this);
				return;
			}
			if ((callback != null || callbackWithArgument != null) && detectionEventHasListener)
			{
				UnityEngine.Debug.LogWarning("[ACTk] Injection Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?", this);
			}
			if (callback == null && callbackWithArgument == null && !detectionEventHasListener)
			{
				UnityEngine.Debug.LogWarning("[ACTk] Injection Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method.", this);
				base.enabled = false;
				return;
			}
			detectionAction = callback;
			detectionActionWithArgument = callbackWithArgument;
			started = true;
			isRunning = true;
			if (allowedAssemblies == null)
			{
				LoadAndParseAllowedAssemblies();
			}
			string cause;
			if (signaturesAreNotGenuine)
			{
				OnCheatingDetected("signatures");
			}
			else if (!FindInjectionInCurrentAssemblies(out cause))
			{
				AppDomain.CurrentDomain.AssemblyLoad += OnNewAssemblyLoaded;
			}
			else
			{
				OnCheatingDetected(cause);
			}
		}

		protected override void StartDetectionAutomatically()
		{
			StartDetectionInternal(null, null);
		}

		protected override void PauseDetector()
		{
			isRunning = false;
			AppDomain.CurrentDomain.AssemblyLoad -= OnNewAssemblyLoaded;
		}

		protected override void ResumeDetector()
		{
			if (detectionAction != null || detectionActionWithArgument != null || detectionEventHasListener)
			{
				isRunning = true;
				AppDomain.CurrentDomain.AssemblyLoad += OnNewAssemblyLoaded;
			}
		}

		protected override void StopDetectionInternal()
		{
			if (started)
			{
				AppDomain.CurrentDomain.AssemblyLoad -= OnNewAssemblyLoaded;
				detectionAction = null;
				detectionActionWithArgument = null;
				started = false;
				isRunning = false;
			}
		}

		protected override void DisposeInternal()
		{
			base.DisposeInternal();
			if (Instance == this)
			{
				Instance = null;
			}
		}

		private void OnCheatingDetected(string cause)
		{
			if (detectionActionWithArgument != null)
			{
				detectionActionWithArgument(cause);
			}
			base.OnCheatingDetected();
		}

		private void OnNewAssemblyLoaded(object sender, AssemblyLoadEventArgs args)
		{
			if (!AssemblyAllowed(args.LoadedAssembly))
			{
				OnCheatingDetected(args.LoadedAssembly.FullName);
			}
		}

		private bool FindInjectionInCurrentAssemblies(out string cause)
		{
			cause = null;
			bool result = false;
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			if (assemblies.Length == 0)
			{
				cause = "no assemblies";
				result = true;
			}
			else
			{
				Assembly[] array = assemblies;
				foreach (Assembly assembly in array)
				{
					if (!AssemblyAllowed(assembly))
					{
						cause = assembly.FullName;
						result = true;
						break;
					}
				}
			}
			return result;
		}

		private bool AssemblyAllowed(Assembly ass)
		{
			string text = ass.GetName().Name;
			int assemblyHash = GetAssemblyHash(ass);
			bool result = false;
			for (int i = 0; i < allowedAssemblies.Length; i++)
			{
				AllowedAssembly allowedAssembly = allowedAssemblies[i];
				if (allowedAssembly.name == text && Array.IndexOf(allowedAssembly.hashes, assemblyHash) != -1)
				{
					result = true;
					break;
				}
			}
			return result;
		}

		private void LoadAndParseAllowedAssemblies()
		{
			TextAsset textAsset = (TextAsset)Resources.Load("fndid", typeof(TextAsset));
			if (textAsset == null)
			{
				signaturesAreNotGenuine = true;
				return;
			}
			string[] separator = new string[1] { ":" };
			MemoryStream memoryStream = new MemoryStream(textAsset.bytes);
			BinaryReader binaryReader = new BinaryReader(memoryStream);
			int num = binaryReader.ReadInt32();
			allowedAssemblies = new AllowedAssembly[num];
			for (int i = 0; i < num; i++)
			{
				string value = binaryReader.ReadString();
				value = ObscuredString.EncryptDecrypt(value, "Elina");
				string[] array = value.Split(separator, StringSplitOptions.RemoveEmptyEntries);
				int num2 = array.Length;
				if (num2 > 1)
				{
					string text = array[0];
					int[] array2 = new int[num2 - 1];
					for (int j = 1; j < num2; j++)
					{
						array2[j - 1] = int.Parse(array[j]);
					}
					allowedAssemblies[i] = new AllowedAssembly(text, array2);
					continue;
				}
				signaturesAreNotGenuine = true;
				binaryReader.Close();
				memoryStream.Close();
				return;
			}
			binaryReader.Close();
			memoryStream.Close();
			Resources.UnloadAsset(textAsset);
			hexTable = new string[256];
			for (int k = 0; k < 256; k++)
			{
				hexTable[k] = k.ToString("x2");
			}
		}

		private int GetAssemblyHash(Assembly ass)
		{
			AssemblyName assemblyName = ass.GetName();
			byte[] publicKeyToken = assemblyName.GetPublicKeyToken();
			string text = ((publicKeyToken.Length < 8) ? assemblyName.Name : (assemblyName.Name + PublicKeyTokenToString(publicKeyToken)));
			int num = 0;
			int length = text.Length;
			for (int i = 0; i < length; i++)
			{
				num += text[i];
				num += num << 10;
				num ^= num >> 6;
			}
			num += num << 3;
			num ^= num >> 11;
			return num + (num << 15);
		}

		private string PublicKeyTokenToString(byte[] bytes)
		{
			string text = string.Empty;
			for (int i = 0; i < 8; i++)
			{
				text += hexTable[bytes[i]];
			}
			return text;
		}
	}
	[AddComponentMenu("Code Stage/Anti-Cheat Toolkit/Obscured Cheating Detector")]
	public class ObscuredCheatingDetector : ActDetectorBase
	{
		internal const string COMPONENT_NAME = "Obscured Cheating Detector";

		internal const string FINAL_LOG_PREFIX = "[ACTk] Obscured Cheating Detector: ";

		private static int instancesInScene;

		[Tooltip("Max allowed difference between encrypted and fake values in ObscuredFloat. Increase in case of false positives.")]
		public float floatEpsilon = 0.0001f;

		[Tooltip("Max allowed difference between encrypted and fake values in ObscuredVector2. Increase in case of false positives.")]
		public float vector2Epsilon = 0.1f;

		[Tooltip("Max allowed difference between encrypted and fake values in ObscuredVector3. Increase in case of false positives.")]
		public float vector3Epsilon = 0.1f;

		[Tooltip("Max allowed difference between encrypted and fake values in ObscuredQuaternion. Increase in case of false positives.")]
		public float quaternionEpsilon = 0.1f;

		public static ObscuredCheatingDetector Instance { get; private set; }

		private static ObscuredCheatingDetector GetOrCreateInstance
		{
			get
			{
				if (Instance != null)
				{
					return Instance;
				}
				if (ActDetectorBase.detectorsContainer == null)
				{
					ActDetectorBase.detectorsContainer = new GameObject("Anti-Cheat Toolkit Detectors");
				}
				Instance = ActDetectorBase.detectorsContainer.AddComponent<ObscuredCheatingDetector>();
				return Instance;
			}
		}

		internal static bool IsRunning => (object)Instance != null && Instance.isRunning;

		private ObscuredCheatingDetector()
		{
		}

		public static void StartDetection()
		{
			if (Instance != null)
			{
				Instance.StartDetectionInternal(null);
			}
			else
			{
				UnityEngine.Debug.LogError("[ACTk] Obscured Cheating Detector: can't be started since it doesn't exists in scene or not yet initialized!");
			}
		}

		public static void StartDetection(UnityAction callback)
		{
			GetOrCreateInstance.StartDetectionInternal(callback);
		}

		public static void StopDetection()
		{
			if (Instance != null)
			{
				Instance.StopDetectionInternal();
			}
		}

		public static void Dispose()
		{
			if (Instance != null)
			{
				Instance.DisposeInternal();
			}
		}

		private void Awake()
		{
			instancesInScene++;
			if (Init(Instance, "Obscured Cheating Detector"))
			{
				Instance = this;
			}
			SceneManager.sceneLoaded += OnLevelWasLoadedNew;
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();
			instancesInScene--;
		}

		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
			OnLevelLoadedCallback();
		}

		private void OnLevelLoadedCallback()
		{
			if (instancesInScene < 2)
			{
				if (!keepAlive)
				{
					DisposeInternal();
				}
			}
			else if (!keepAlive && Instance != this)
			{
				DisposeInternal();
			}
		}

		private void StartDetectionInternal(UnityAction callback)
		{
			if (isRunning)
			{
				UnityEngine.Debug.LogWarning("[ACTk] Obscured Cheating Detector: already running!", this);
				return;
			}
			if (!base.enabled)
			{
				UnityEngine.Debug.LogWarning("[ACTk] Obscured Cheating Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!", this);
				return;
			}
			if (callback != null && detectionEventHasListener)
			{
				UnityEngine.Debug.LogWarning("[ACTk] Obscured Cheating Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?", this);
			}
			if (callback == null && !detectionEventHasListener)
			{
				UnityEngine.Debug.LogWarning("[ACTk] Obscured Cheating Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method.", this);
				base.enabled = false;
			}
			else
			{
				detectionAction = callback;
				started = true;
				isRunning = true;
			}
		}

		protected override void StartDetectionAutomatically()
		{
			StartDetectionInternal(null);
		}

		protected override void PauseDetector()
		{
			isRunning = false;
		}

		protected override void ResumeDetector()
		{
			if (detectionAction != null || detectionEventHasListener)
			{
				isRunning = true;
			}
		}

		protected override void StopDetectionInternal()
		{
			if (started)
			{
				detectionAction = null;
				started = false;
				isRunning = false;
			}
		}

		protected override void DisposeInternal()
		{
			base.DisposeInternal();
			if (Instance == this)
			{
				Instance = null;
			}
		}
	}
	[AddComponentMenu("Code Stage/Anti-Cheat Toolkit/Speed Hack Detector")]
	public class SpeedHackDetector : ActDetectorBase
	{
		internal const string COMPONENT_NAME = "Speed Hack Detector";

		internal const string FINAL_LOG_PREFIX = "[ACTk] Speed Hack Detector: ";

		private const long TICKS_PER_SECOND = 10000000L;

		private const int THRESHOLD = 5000000;

		private static int instancesInScene;

		[Tooltip("Time (in seconds) between detector checks.")]
		public float interval = 1f;

		[Tooltip("Maximum false positives count allowed before registering speed hack.")]
		public byte maxFalsePositives = 3;

		[Tooltip("Amount of sequential successful checks before clearing internal false positives counter.\nSet 0 to disable Cool Down feature.")]
		public int coolDown = 30;

		private byte currentFalsePositives;

		private int currentCooldownShots;

		private long ticksOnStart;

		private long vulnerableTicksOnStart;

		private long prevTicks;

		private long prevIntervalTicks;

		public static SpeedHackDetector Instance { get; private set; }

		private static SpeedHackDetector GetOrCreateInstance
		{
			get
			{
				if (Instance != null)
				{
					return Instance;
				}
				if (ActDetectorBase.detectorsContainer == null)
				{
					ActDetectorBase.detectorsContainer = new GameObject("Anti-Cheat Toolkit Detectors");
				}
				Instance = ActDetectorBase.detectorsContainer.AddComponent<SpeedHackDetector>();
				return Instance;
			}
		}

		private SpeedHackDetector()
		{
		}

		public static void StartDetection()
		{
			if (Instance != null)
			{
				Instance.StartDetectionInternal(null, Instance.interval, Instance.maxFalsePositives, Instance.coolDown);
			}
			else
			{
				UnityEngine.Debug.LogError("[ACTk] Speed Hack Detector: can't be started since it doesn't exists in scene or not yet initialized!");
			}
		}

		public static void StartDetection(UnityAction callback)
		{
			StartDetection(callback, GetOrCreateInstance.interval);
		}

		public static void StartDetection(UnityAction callback, float interval)
		{
			StartDetection(callback, interval, GetOrCreateInstance.maxFalsePositives);
		}

		public static void StartDetection(UnityAction callback, float interval, byte maxFalsePositives)
		{
			StartDetection(callback, interval, maxFalsePositives, GetOrCreateInstance.coolDown);
		}

		public static void StartDetection(UnityAction callback, float interval, byte maxFalsePositives, int coolDown)
		{
			GetOrCreateInstance.StartDetectionInternal(callback, interval, maxFalsePositives, coolDown);
		}

		public static void StopDetection()
		{
			if (Instance != null)
			{
				Instance.StopDetectionInternal();
			}
		}

		public static void Dispose()
		{
			if (Instance != null)
			{
				Instance.DisposeInternal();
			}
		}

		private void Awake()
		{
			instancesInScene++;
			if (Init(Instance, "Speed Hack Detector"))
			{
				Instance = this;
			}
			SceneManager.sceneLoaded += OnLevelWasLoadedNew;
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();
			instancesInScene--;
		}

		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
			OnLevelLoadedCallback();
		}

		private void OnLevelLoadedCallback()
		{
			if (instancesInScene < 2)
			{
				if (!keepAlive)
				{
					DisposeInternal();
				}
			}
			else if (!keepAlive && Instance != this)
			{
				DisposeInternal();
			}
		}

		private void OnApplicationPause(bool pause)
		{
			if (!pause)
			{
				ResetStartTicks();
			}
		}

		private void Update()
		{
			if (!isRunning)
			{
				return;
			}
			long ticks = DateTime.UtcNow.Ticks;
			long num = ticks - prevTicks;
			if (num < 0 || num > 10000000)
			{
				ResetStartTicks();
				return;
			}
			prevTicks = ticks;
			long num2 = (long)(interval * 10000000f);
			if (ticks - prevIntervalTicks < num2)
			{
				return;
			}
			long num3 = (long)Environment.TickCount * 10000L;
			if (Mathf.Abs(num3 - vulnerableTicksOnStart - (ticks - ticksOnStart)) > 5000000f)
			{
				currentFalsePositives++;
				if (currentFalsePositives > maxFalsePositives)
				{
					OnCheatingDetected();
				}
				else
				{
					currentCooldownShots = 0;
					ResetStartTicks();
				}
			}
			else if (currentFalsePositives > 0 && coolDown > 0)
			{
				currentCooldownShots++;
				if (currentCooldownShots >= coolDown)
				{
					currentFalsePositives = 0;
				}
			}
			prevIntervalTicks = ticks;
		}

		private void StartDetectionInternal(UnityAction callback, float checkInterval, byte falsePositives, int shotsTillCooldown)
		{
			if (!isRunning && base.enabled)
			{
				if (callback == null || detectionEventHasListener)
				{
				}
				if (callback == null && !detectionEventHasListener)
				{
					base.enabled = false;
					return;
				}
				detectionAction = callback;
				interval = checkInterval;
				maxFalsePositives = falsePositives;
				coolDown = shotsTillCooldown;
				ResetStartTicks();
				currentFalsePositives = 0;
				currentCooldownShots = 0;
				started = true;
				isRunning = true;
			}
		}

		protected override void StartDetectionAutomatically()
		{
			StartDetectionInternal(null, interval, maxFalsePositives, coolDown);
		}

		protected override void PauseDetector()
		{
			isRunning = false;
		}

		protected override void ResumeDetector()
		{
			if (detectionAction != null || detectionEventHasListener)
			{
				isRunning = true;
			}
		}

		protected override void StopDetectionInternal()
		{
			if (started)
			{
				detectionAction = null;
				started = false;
				isRunning = false;
			}
		}

		protected override void DisposeInternal()
		{
			base.DisposeInternal();
			if (Instance == this)
			{
				Instance = null;
			}
		}

		private void ResetStartTicks()
		{
			ticksOnStart = DateTime.UtcNow.Ticks;
			vulnerableTicksOnStart = (long)Environment.TickCount * 10000L;
			prevTicks = ticksOnStart;
			prevIntervalTicks = ticksOnStart;
		}
	}
	[AddComponentMenu("Code Stage/Anti-Cheat Toolkit/WallHack Detector")]
	public class WallHackDetector : ActDetectorBase
	{
		internal const string COMPONENT_NAME = "WallHack Detector";

		internal const string FINAL_LOG_PREFIX = "[ACTk] WallHack Detector: ";

		private const string SERVICE_CONTAINER_NAME = "[WH Detector Service]";

		private const string WIREFRAME_SHADER_NAME = "Hidden/ACTk/WallHackTexture";

		private const int SHADER_TEXTURE_SIZE = 4;

		private const int RENDER_TEXTURE_SIZE = 4;

		private readonly Vector3 rigidPlayerVelocity = new Vector3(0f, 0f, 1f);

		private static int instancesInScene;

		private readonly WaitForEndOfFrame waitForEndOfFrame = new WaitForEndOfFrame();

		[SerializeField]
		[Tooltip("Check for the \"walk through the walls\" kind of cheats made via Rigidbody hacks?")]
		private bool checkRigidbody = true;

		[SerializeField]
		[Tooltip("Check for the \"walk through the walls\" kind of cheats made via Character Controller hacks?")]
		private bool checkController = true;

		[SerializeField]
		[Tooltip("Check for the \"see through the walls\" kind of cheats made via shader or driver hacks (wireframe, color alpha, etc.)?")]
		private bool checkWireframe = true;

		[Tooltip("Check for the \"shoot through the walls\" kind of cheats made via Raycast hacks?")]
		[SerializeField]
		private bool checkRaycast = true;

		[Tooltip("Delay between Wireframe module checks, from 1 up to 60 secs.")]
		[Range(1f, 60f)]
		public int wireframeDelay = 10;

		[Range(1f, 60f)]
		[Tooltip("Delay between Raycast module checks, from 1 up to 60 secs.")]
		public int raycastDelay = 10;

		[Tooltip("World position of the container for service objects within 3x3x3 cube (drawn as red wire cube in scene).")]
		public Vector3 spawnPosition;

		[Tooltip("Maximum false positives in a row for each detection module before registering a wall hack.")]
		public byte maxFalsePositives = 3;

		private GameObject serviceContainer;

		private GameObject solidWall;

		private GameObject thinWall;

		private Camera wfCamera;

		private MeshRenderer foregroundRenderer;

		private MeshRenderer backgroundRenderer;

		private Color wfColor1 = Color.black;

		private Color wfColor2 = Color.black;

		private Shader wfShader;

		private Material wfMaterial;

		private Texture2D shaderTexture;

		private Texture2D targetTexture;

		private RenderTexture renderTexture;

		private int whLayer = -1;

		private int raycastMask = -1;

		private Rigidbody rigidPlayer;

		private CharacterController charControllerPlayer;

		private float charControllerVelocity;

		private byte rigidbodyDetections;

		private byte controllerDetections;

		private byte wireframeDetections;

		private byte raycastDetections;

		private bool wireframeDetected;

		public bool CheckRigidbody
		{
			get
			{
				return checkRigidbody;
			}
			set
			{
				if (checkRigidbody == value || !Application.isPlaying || !base.enabled || !base.gameObject.activeSelf)
				{
					return;
				}
				checkRigidbody = value;
				if (started)
				{
					UpdateServiceContainer();
					if (checkRigidbody)
					{
						StartRigidModule();
					}
					else
					{
						StopRigidModule();
					}
				}
			}
		}

		public bool CheckController
		{
			get
			{
				return checkController;
			}
			set
			{
				if (checkController == value || !Application.isPlaying || !base.enabled || !base.gameObject.activeSelf)
				{
					return;
				}
				checkController = value;
				if (started)
				{
					UpdateServiceContainer();
					if (checkController)
					{
						StartControllerModule();
					}
					else
					{
						StopControllerModule();
					}
				}
			}
		}

		public bool CheckWireframe
		{
			get
			{
				return checkWireframe;
			}
			set
			{
				if (checkWireframe == value || !Application.isPlaying || !base.enabled || !base.gameObject.activeSelf)
				{
					return;
				}
				checkWireframe = value;
				if (started)
				{
					UpdateServiceContainer();
					if (checkWireframe)
					{
						StartWireframeModule();
					}
					else
					{
						StopWireframeModule();
					}
				}
			}
		}

		public bool CheckRaycast
		{
			get
			{
				return checkRaycast;
			}
			set
			{
				if (checkRaycast == value || !Application.isPlaying || !base.enabled || !base.gameObject.activeSelf)
				{
					return;
				}
				checkRaycast = value;
				if (started)
				{
					UpdateServiceContainer();
					if (checkRaycast)
					{
						StartRaycastModule();
					}
					else
					{
						StopRaycastModule();
					}
				}
			}
		}

		public static WallHackDetector Instance { get; private set; }

		private static WallHackDetector GetOrCreateInstance
		{
			get
			{
				if (Instance != null)
				{
					return Instance;
				}
				if (ActDetectorBase.detectorsContainer == null)
				{
					ActDetectorBase.detectorsContainer = new GameObject("Anti-Cheat Toolkit Detectors");
				}
				Instance = ActDetectorBase.detectorsContainer.AddComponent<WallHackDetector>();
				return Instance;
			}
		}

		private WallHackDetector()
		{
		}

		public static void StartDetection()
		{
			if (Instance != null)
			{
				Instance.StartDetectionInternal(null, Instance.spawnPosition, Instance.maxFalsePositives);
			}
			else
			{
				UnityEngine.Debug.LogError("[ACTk] WallHack Detector: can't be started since it doesn't exists in scene or not yet initialized!");
			}
		}

		public static void StartDetection(UnityAction callback)
		{
			StartDetection(callback, GetOrCreateInstance.spawnPosition);
		}

		public static void StartDetection(UnityAction callback, Vector3 spawnPosition)
		{
			StartDetection(callback, spawnPosition, GetOrCreateInstance.maxFalsePositives);
		}

		public static void StartDetection(UnityAction callback, Vector3 spawnPosition, byte maxFalsePositives)
		{
			GetOrCreateInstance.StartDetectionInternal(callback, spawnPosition, maxFalsePositives);
		}

		public static void StopDetection()
		{
			if (Instance != null)
			{
				Instance.StopDetectionInternal();
			}
		}

		public static void Dispose()
		{
			if (Instance != null)
			{
				Instance.DisposeInternal();
			}
		}

		private void Awake()
		{
			instancesInScene++;
			if (Init(Instance, "WallHack Detector"))
			{
				Instance = this;
			}
			SceneManager.sceneLoaded += OnLevelWasLoadedNew;
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();
			StopAllCoroutines();
			if (serviceContainer != null)
			{
				UnityEngine.Object.Destroy(serviceContainer);
			}
			if (wfMaterial != null)
			{
				wfMaterial.mainTexture = null;
				wfMaterial.shader = null;
				wfMaterial = null;
				wfShader = null;
				shaderTexture = null;
				targetTexture = null;
				renderTexture.DiscardContents();
				renderTexture.Release();
				renderTexture = null;
			}
			instancesInScene--;
		}

		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
			OnLevelLoadedCallback();
		}

		private void OnLevelLoadedCallback()
		{
			if (instancesInScene < 2)
			{
				if (!keepAlive)
				{
					DisposeInternal();
				}
			}
			else if (!keepAlive && Instance != this)
			{
				DisposeInternal();
			}
		}

		private void FixedUpdate()
		{
			if (isRunning && checkRigidbody && !(rigidPlayer == null) && rigidPlayer.transform.localPosition.z > 1f)
			{
				rigidbodyDetections++;
				if (!Detect())
				{
					StopRigidModule();
					StartRigidModule();
				}
			}
		}

		private void Update()
		{
			if (!isRunning || !checkController || charControllerPlayer == null || !(charControllerVelocity > 0f))
			{
				return;
			}
			charControllerPlayer.Move(new Vector3(UnityEngine.Random.Range(-0.002f, 0.002f), 0f, charControllerVelocity));
			if (charControllerPlayer.transform.localPosition.z > 1f)
			{
				controllerDetections++;
				if (!Detect())
				{
					StopControllerModule();
					StartControllerModule();
				}
			}
		}

		private void StartDetectionInternal(UnityAction callback, Vector3 servicePosition, byte falsePositivesInRow)
		{
			if (isRunning)
			{
				UnityEngine.Debug.LogWarning("[ACTk] WallHack Detector: already running!", this);
				return;
			}
			if (!base.enabled)
			{
				UnityEngine.Debug.LogWarning("[ACTk] WallHack Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!", this);
				return;
			}
			if (callback != null && detectionEventHasListener)
			{
				UnityEngine.Debug.LogWarning("[ACTk] WallHack Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?", this);
			}
			if (callback == null && !detectionEventHasListener)
			{
				UnityEngine.Debug.LogWarning("[ACTk] WallHack Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method.", this);
				base.enabled = false;
				return;
			}
			detectionAction = callback;
			spawnPosition = servicePosition;
			maxFalsePositives = falsePositivesInRow;
			rigidbodyDetections = 0;
			controllerDetections = 0;
			wireframeDetections = 0;
			raycastDetections = 0;
			StartCoroutine(InitDetector());
			started = true;
			isRunning = true;
		}

		protected override void StartDetectionAutomatically()
		{
			StartDetectionInternal(null, spawnPosition, maxFalsePositives);
		}

		protected override void PauseDetector()
		{
			if (isRunning)
			{
				isRunning = false;
				StopRigidModule();
				StopControllerModule();
				StopWireframeModule();
				StopRaycastModule();
			}
		}

		protected override void ResumeDetector()
		{
			if (detectionAction != null || detectionEventHasListener)
			{
				isRunning = true;
				if (checkRigidbody)
				{
					StartRigidModule();
				}
				if (checkController)
				{
					StartControllerModule();
				}
				if (checkWireframe)
				{
					StartWireframeModule();
				}
				if (checkRaycast)
				{
					StartRaycastModule();
				}
			}
		}

		protected override void StopDetectionInternal()
		{
			if (started)
			{
				PauseDetector();
				detectionAction = null;
				isRunning = false;
			}
		}

		protected override void DisposeInternal()
		{
			base.DisposeInternal();
			if (Instance == this)
			{
				Instance = null;
			}
		}

		private void UpdateServiceContainer()
		{
			if (base.enabled && base.gameObject.activeSelf)
			{
				if (whLayer == -1)
				{
					whLayer = LayerMask.NameToLayer("Ignore Raycast");
				}
				if (raycastMask == -1)
				{
					raycastMask = LayerMask.GetMask("Ignore Raycast");
				}
				if (serviceContainer == null)
				{
					serviceContainer = new GameObject("[WH Detector Service]");
					serviceContainer.layer = whLayer;
					serviceContainer.transform.position = spawnPosition;
					UnityEngine.Object.DontDestroyOnLoad(serviceContainer);
				}
				if ((checkRigidbody || checkController) && solidWall == null)
				{
					solidWall = new GameObject("SolidWall");
					solidWall.AddComponent<BoxCollider>();
					solidWall.layer = whLayer;
					solidWall.transform.parent = serviceContainer.transform;
					solidWall.transform.localScale = new Vector3(3f, 3f, 0.5f);
					solidWall.transform.localPosition = Vector3.zero;
				}
				else if (!checkRigidbody && !checkController && solidWall != null)
				{
					UnityEngine.Object.Destroy(solidWall);
				}
				if (checkWireframe && wfCamera == null)
				{
					if (wfShader == null)
					{
						wfShader = Shader.Find("Hidden/ACTk/WallHackTexture");
					}
					if (wfShader == null)
					{
						UnityEngine.Debug.LogError("[ACTk] WallHack Detector: can't find 'Hidden/ACTk/WallHackTexture' shader!\nPlease make sure you have it included at the Editor > Project Settings > Graphics.", this);
						checkWireframe = false;
					}
					else if (!wfShader.isSupported)
					{
						UnityEngine.Debug.LogError("[ACTk] WallHack Detector: can't detect wireframe cheats on this platform!", this);
						checkWireframe = false;
					}
					else
					{
						if (wfColor1 == Color.black)
						{
							wfColor1 = GenerateColor();
							do
							{
								wfColor2 = GenerateColor();
							}
							while (ColorsSimilar(wfColor1, wfColor2, 10));
						}
						if (shaderTexture == null)
						{
							shaderTexture = new Texture2D(4, 4, TextureFormat.RGB24, mipmap: false);
							shaderTexture.filterMode = FilterMode.Point;
							Color[] array = new Color[16];
							for (int i = 0; i < 16; i++)
							{
								if (i < 8)
								{
									ref Color reference = ref array[i];
									reference = wfColor1;
								}
								else
								{
									ref Color reference2 = ref array[i];
									reference2 = wfColor2;
								}
							}
							shaderTexture.SetPixels(array, 0);
							shaderTexture.Apply();
						}
						if (renderTexture == null)
						{
							renderTexture = new RenderTexture(4, 4, 24, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
							renderTexture.generateMips = false;
							renderTexture.filterMode = FilterMode.Point;
							renderTexture.Create();
						}
						if (targetTexture == null)
						{
							targetTexture = new Texture2D(4, 4, TextureFormat.RGB24, mipmap: false);
							targetTexture.filterMode = FilterMode.Point;
						}
						if (wfMaterial == null)
						{
							wfMaterial = new Material(wfShader);
							wfMaterial.mainTexture = shaderTexture;
						}
						if (foregroundRenderer == null)
						{
							GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
							UnityEngine.Object.Destroy(gameObject.GetComponent<BoxCollider>());
							gameObject.name = "WireframeFore";
							gameObject.layer = whLayer;
							gameObject.transform.parent = serviceContainer.transform;
							gameObject.transform.localPosition = new Vector3(0f, 0f, 0f);
							foregroundRenderer = gameObject.GetComponent<MeshRenderer>();
							foregroundRenderer.sharedMaterial = wfMaterial;
							foregroundRenderer.shadowCastingMode = ShadowCastingMode.Off;
							foregroundRenderer.receiveShadows = false;
							foregroundRenderer.enabled = false;
						}
						if (backgroundRenderer == null)
						{
							GameObject gameObject2 = GameObject.CreatePrimitive(PrimitiveType.Quad);
							UnityEngine.Object.Destroy(gameObject2.GetComponent<MeshCollider>());
							gameObject2.name = "WireframeBack";
							gameObject2.layer = whLayer;
							gameObject2.transform.parent = serviceContainer.transform;
							gameObject2.transform.localPosition = new Vector3(0f, 0f, 1f);
							gameObject2.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
							backgroundRenderer = gameObject2.GetComponent<MeshRenderer>();
							backgroundRenderer.sharedMaterial = wfMaterial;
							backgroundRenderer.shadowCastingMode = ShadowCastingMode.Off;
							backgroundRenderer.receiveShadows = false;
							backgroundRenderer.enabled = false;
						}
						if (wfCamera == null)
						{
							wfCamera = new GameObject("WireframeCamera").AddComponent<Camera>();
							wfCamera.gameObject.layer = whLayer;
							wfCamera.transform.parent = serviceContainer.transform;
							wfCamera.transform.localPosition = new Vector3(0f, 0f, -1f);
							wfCamera.clearFlags = CameraClearFlags.Color;
							wfCamera.backgroundColor = Color.black;
							wfCamera.orthographic = true;
							wfCamera.orthographicSize = 0.5f;
							wfCamera.nearClipPlane = 0.01f;
							wfCamera.farClipPlane = 2.1f;
							wfCamera.depth = 0f;
							wfCamera.renderingPath = RenderingPath.Forward;
							wfCamera.useOcclusionCulling = false;
							wfCamera.hdr = false;
							wfCamera.targetTexture = renderTexture;
							wfCamera.enabled = false;
						}
					}
				}
				else if (!checkWireframe && wfCamera != null)
				{
					UnityEngine.Object.Destroy(foregroundRenderer.gameObject);
					UnityEngine.Object.Destroy(backgroundRenderer.gameObject);
					wfCamera.targetTexture = null;
					UnityEngine.Object.Destroy(wfCamera.gameObject);
				}
				if (checkRaycast && thinWall == null)
				{
					thinWall = GameObject.CreatePrimitive(PrimitiveType.Plane);
					thinWall.name = "ThinWall";
					thinWall.layer = whLayer;
					thinWall.transform.parent = serviceContainer.transform;
					thinWall.transform.localScale = new Vector3(0.2f, 1f, 0.2f);
					thinWall.transform.localRotation = Quaternion.Euler(270f, 0f, 0f);
					thinWall.transform.localPosition = new Vector3(0f, 0f, 1.4f);
					UnityEngine.Object.Destroy(thinWall.GetComponent<Renderer>());
					UnityEngine.Object.Destroy(thinWall.GetComponent<MeshFilter>());
				}
				else if (!checkRaycast && thinWall != null)
				{
					UnityEngine.Object.Destroy(thinWall);
				}
			}
			else if (serviceContainer != null)
			{
				UnityEngine.Object.Destroy(serviceContainer);
			}
		}

		private IEnumerator InitDetector()
		{
			yield return waitForEndOfFrame;
			UpdateServiceContainer();
			if (checkRigidbody)
			{
				StartRigidModule();
			}
			if (checkController)
			{
				StartControllerModule();
			}
			if (checkWireframe)
			{
				StartWireframeModule();
			}
			if (checkRaycast)
			{
				StartRaycastModule();
			}
		}

		private void StartRigidModule()
		{
			if (!checkRigidbody)
			{
				StopRigidModule();
				UninitRigidModule();
				UpdateServiceContainer();
				return;
			}
			if (!rigidPlayer)
			{
				InitRigidModule();
			}
			if (rigidPlayer.transform.localPosition.z <= 1f && rigidbodyDetections > 0)
			{
				rigidbodyDetections = 0;
			}
			rigidPlayer.rotation = Quaternion.identity;
			rigidPlayer.angularVelocity = Vector3.zero;
			rigidPlayer.transform.localPosition = new Vector3(0.75f, 0f, -1f);
			rigidPlayer.velocity = rigidPlayerVelocity;
			Invoke("StartRigidModule", 4f);
		}

		private void StartControllerModule()
		{
			if (!checkController)
			{
				StopControllerModule();
				UninitControllerModule();
				UpdateServiceContainer();
				return;
			}
			if (!charControllerPlayer)
			{
				InitControllerModule();
			}
			if (charControllerPlayer.transform.localPosition.z <= 1f && controllerDetections > 0)
			{
				controllerDetections = 0;
			}
			charControllerPlayer.transform.localPosition = new Vector3(-0.75f, 0f, -1f);
			charControllerVelocity = 0.01f;
			Invoke("StartControllerModule", 4f);
		}

		private void StartWireframeModule()
		{
			if (!checkWireframe)
			{
				StopWireframeModule();
				UpdateServiceContainer();
			}
			else if (!wireframeDetected)
			{
				Invoke("ShootWireframeModule", wireframeDelay);
			}
		}

		private void ShootWireframeModule()
		{
			StartCoroutine(CaptureFrame());
			Invoke("ShootWireframeModule", wireframeDelay);
		}

		private IEnumerator CaptureFrame()
		{
			wfCamera.enabled = true;
			yield return waitForEndOfFrame;
			foregroundRenderer.enabled = true;
			backgroundRenderer.enabled = true;
			RenderTexture previousActive = RenderTexture.active;
			RenderTexture.active = renderTexture;
			wfCamera.Render();
			foregroundRenderer.enabled = false;
			backgroundRenderer.enabled = false;
			while (!renderTexture.IsCreated())
			{
				yield return waitForEndOfFrame;
			}
			targetTexture.ReadPixels(new Rect(0f, 0f, 4f, 4f), 0, 0, recalculateMipMaps: false);
			targetTexture.Apply();
			RenderTexture.active = previousActive;
			if (wfCamera == null)
			{
				yield return null;
			}
			wfCamera.enabled = false;
			if (!(targetTexture.GetPixel(0, 3) != wfColor1) && !(targetTexture.GetPixel(0, 1) != wfColor2) && !(targetTexture.GetPixel(3, 3) != wfColor1) && !(targetTexture.GetPixel(3, 1) != wfColor2) && !(targetTexture.GetPixel(1, 3) != wfColor1) && !(targetTexture.GetPixel(2, 3) != wfColor1) && !(targetTexture.GetPixel(1, 1) != wfColor2) && !(targetTexture.GetPixel(2, 1) != wfColor2))
			{
				if (wireframeDetections > 0)
				{
					wireframeDetections = 0;
				}
			}
			else
			{
				wireframeDetections++;
				wireframeDetected = Detect();
			}
			yield return null;
		}

		private void StartRaycastModule()
		{
			if (!checkRaycast)
			{
				StopRaycastModule();
				UpdateServiceContainer();
			}
			else
			{
				Invoke("ShootRaycastModule", raycastDelay);
			}
		}

		private void ShootRaycastModule()
		{
			if (Physics.Raycast(serviceContainer.transform.position, serviceContainer.transform.TransformDirection(Vector3.forward), 1.5f, raycastMask))
			{
				if (raycastDetections > 0)
				{
					raycastDetections = 0;
				}
			}
			else
			{
				raycastDetections++;
				if (Detect())
				{
					return;
				}
			}
			Invoke("ShootRaycastModule", raycastDelay);
		}

		private void StopRigidModule()
		{
			if ((bool)rigidPlayer)
			{
				rigidPlayer.velocity = Vector3.zero;
			}
			CancelInvoke("StartRigidModule");
		}

		private void StopControllerModule()
		{
			if ((bool)charControllerPlayer)
			{
				charControllerVelocity = 0f;
			}
			CancelInvoke("StartControllerModule");
		}

		private void StopWireframeModule()
		{
			CancelInvoke("ShootWireframeModule");
		}

		private void StopRaycastModule()
		{
			CancelInvoke("ShootRaycastModule");
		}

		private void InitRigidModule()
		{
			GameObject gameObject = new GameObject("RigidPlayer");
			gameObject.AddComponent<CapsuleCollider>().height = 2f;
			gameObject.layer = whLayer;
			gameObject.transform.parent = serviceContainer.transform;
			gameObject.transform.localPosition = new Vector3(0.75f, 0f, -1f);
			rigidPlayer = gameObject.AddComponent<Rigidbody>();
			rigidPlayer.useGravity = false;
		}

		private void InitControllerModule()
		{
			GameObject gameObject = new GameObject("ControlledPlayer");
			gameObject.AddComponent<CapsuleCollider>().height = 2f;
			gameObject.layer = whLayer;
			gameObject.transform.parent = serviceContainer.transform;
			gameObject.transform.localPosition = new Vector3(-0.75f, 0f, -1f);
			charControllerPlayer = gameObject.AddComponent<CharacterController>();
		}

		private void UninitRigidModule()
		{
			if ((bool)rigidPlayer)
			{
				UnityEngine.Object.Destroy(rigidPlayer.gameObject);
				rigidPlayer = null;
			}
		}

		private void UninitControllerModule()
		{
			if ((bool)charControllerPlayer)
			{
				UnityEngine.Object.Destroy(charControllerPlayer.gameObject);
				charControllerPlayer = null;
			}
		}

		private bool Detect()
		{
			bool result = false;
			if (controllerDetections > maxFalsePositives || rigidbodyDetections > maxFalsePositives || wireframeDetections > maxFalsePositives || raycastDetections > maxFalsePositives)
			{
				OnCheatingDetected();
				result = true;
			}
			return result;
		}

		private static Color32 GenerateColor()
		{
			return new Color32((byte)UnityEngine.Random.Range(0, 256), (byte)UnityEngine.Random.Range(0, 256), (byte)UnityEngine.Random.Range(0, 256), byte.MaxValue);
		}

		private static bool ColorsSimilar(Color32 c1, Color32 c2, int tolerance)
		{
			return Math.Abs(c1.r - c2.r) < tolerance && Math.Abs(c1.g - c2.g) < tolerance && Math.Abs(c1.b - c2.b) < tolerance;
		}
	}
}
namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredBool : IEquatable<ObscuredBool>
	{
		private static byte cryptoKey = 215;

		[SerializeField]
		private byte currentCryptoKey;

		[SerializeField]
		private int hiddenValue;

		[SerializeField]
		private bool fakeValue;

		[SerializeField]
		private bool fakeValueChanged;

		[SerializeField]
		private bool inited;

		private ObscuredBool(int value)
		{
			currentCryptoKey = cryptoKey;
			hiddenValue = value;
			fakeValue = false;
			fakeValueChanged = false;
			inited = true;
		}

		public static void SetNewCryptoKey(byte newKey)
		{
			cryptoKey = newKey;
		}

		public static int Encrypt(bool value)
		{
			return Encrypt(value, 0);
		}

		public static int Encrypt(bool value, byte key)
		{
			if (key == 0)
			{
				key = cryptoKey;
			}
			int num = ((!value) ? 181 : 213);
			return num ^ key;
		}

		public static bool Decrypt(int value)
		{
			return Decrypt(value, 0);
		}

		public static bool Decrypt(int value, byte key)
		{
			if (key == 0)
			{
				key = cryptoKey;
			}
			value ^= key;
			return value != 181;
		}

		public void ApplyNewCryptoKey()
		{
			if (currentCryptoKey != cryptoKey)
			{
				hiddenValue = Encrypt(InternalDecrypt(), cryptoKey);
				currentCryptoKey = cryptoKey;
			}
		}

		public void RandomizeCryptoKey()
		{
			bool value = InternalDecrypt();
			currentCryptoKey = (byte)UnityEngine.Random.Range(1, 150);
			hiddenValue = Encrypt(value, currentCryptoKey);
		}

		public int GetEncrypted()
		{
			ApplyNewCryptoKey();
			return hiddenValue;
		}

		public void SetEncrypted(int encrypted)
		{
			inited = true;
			hiddenValue = encrypted;
			if (ObscuredCheatingDetector.IsRunning)
			{
				fakeValue = InternalDecrypt();
				fakeValueChanged = true;
			}
		}

		public bool GetDecrypted()
		{
			return InternalDecrypt();
		}

		private bool InternalDecrypt()
		{
			if (!inited)
			{
				currentCryptoKey = cryptoKey;
				hiddenValue = Encrypt(value: false);
				fakeValue = false;
				fakeValueChanged = true;
				inited = true;
			}
			int num = hiddenValue;
			num ^= currentCryptoKey;
			bool flag = num != 181;
			if (ObscuredCheatingDetector.IsRunning && fakeValueChanged && flag != fakeValue)
			{
				ObscuredCheatingDetector.Instance.OnCheatingDetected();
			}
			return flag;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is ObscuredBool))
			{
				return false;
			}
			return Equals((ObscuredBool)obj);
		}

		public bool Equals(ObscuredBool obj)
		{
			if (currentCryptoKey == obj.currentCryptoKey)
			{
				return hiddenValue == obj.hiddenValue;
			}
			return Decrypt(hiddenValue, currentCryptoKey) == Decrypt(obj.hiddenValue, obj.currentCryptoKey);
		}

		public override int GetHashCode()
		{
			return InternalDecrypt().GetHashCode();
		}

		public override string ToString()
		{
			return InternalDecrypt().ToString();
		}

		public static implicit operator ObscuredBool(bool value)
		{
			ObscuredBool result = new ObscuredBool(Encrypt(value));
			if (ObscuredCheatingDetector.IsRunning)
			{
				result.fakeValue = value;
				result.fakeValueChanged = true;
			}
			return result;
		}

		public static implicit operator bool(ObscuredBool value)
		{
			return value.InternalDecrypt();
		}
	}
	[Serializable]
	public struct ObscuredByte : IEquatable<ObscuredByte>, IFormattable
	{
		private static byte cryptoKey = 244;

		private byte currentCryptoKey;

		private byte hiddenValue;

		private byte fakeValue;

		private bool inited;

		private ObscuredByte(byte value)
		{
			currentCryptoKey = cryptoKey;
			hiddenValue = value;
			fakeValue = 0;
			inited = true;
		}

		public static void SetNewCryptoKey(byte newKey)
		{
			cryptoKey = newKey;
		}

		public static byte EncryptDecrypt(byte value)
		{
			return EncryptDecrypt(value, 0);
		}

		public static byte EncryptDecrypt(byte value, byte key)
		{
			if (key == 0)
			{
				return (byte)(value ^ cryptoKey);
			}
			return (byte)(value ^ key);
		}

		public void ApplyNewCryptoKey()
		{
			if (currentCryptoKey != cryptoKey)
			{
				hiddenValue = EncryptDecrypt(InternalDecrypt(), cryptoKey);
				currentCryptoKey = cryptoKey;
			}
		}

		public void RandomizeCryptoKey()
		{
			byte value = InternalDecrypt();
			currentCryptoKey = (byte)UnityEngine.Random.Range(1, 255);
			hiddenValue = EncryptDecrypt(value, currentCryptoKey);
		}

		public byte GetEncrypted()
		{
			ApplyNewCryptoKey();
			return hiddenValue;
		}

		public void SetEncrypted(byte encrypted)
		{
			inited = true;
			hiddenValue = encrypted;
			if (ObscuredCheatingDetector.IsRunning)
			{
				fakeValue = InternalDecrypt();
			}
		}

		public byte GetDecrypted()
		{
			return InternalDecrypt();
		}

		private byte InternalDecrypt()
		{
			if (!inited)
			{
				currentCryptoKey = cryptoKey;
				hiddenValue = EncryptDecrypt(0);
				fakeValue = 0;
				inited = true;
			}
			byte b = EncryptDecrypt(hiddenValue, currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning && fakeValue != 0 && b != fakeValue)
			{
				ObscuredCheatingDetector.Instance.OnCheatingDetected();
			}
			return b;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is ObscuredByte))
			{
				return false;
			}
			return Equals((ObscuredByte)obj);
		}

		public bool Equals(ObscuredByte obj)
		{
			if (currentCryptoKey == obj.currentCryptoKey)
			{
				return hiddenValue == obj.hiddenValue;
			}
			return EncryptDecrypt(hiddenValue, currentCryptoKey) == EncryptDecrypt(obj.hiddenValue, obj.currentCryptoKey);
		}

		public override string ToString()
		{
			return InternalDecrypt().ToString();
		}

		public string ToString(string format)
		{
			return InternalDecrypt().ToString(format);
		}

		public override int GetHashCode()
		{
			return InternalDecrypt().GetHashCode();
		}

		public string ToString(IFormatProvider provider)
		{
			return InternalDecrypt().ToString(provider);
		}

		public string ToString(string format, IFormatProvider provider)
		{
			return InternalDecrypt().ToString(format, provider);
		}

		public static implicit operator ObscuredByte(byte value)
		{
			ObscuredByte result = new ObscuredByte(EncryptDecrypt(value));
			if (ObscuredCheatingDetector.IsRunning)
			{
				result.fakeValue = value;
			}
			return result;
		}

		public static implicit operator byte(ObscuredByte value)
		{
			return value.InternalDecrypt();
		}

		public static ObscuredByte operator ++(ObscuredByte input)
		{
			byte value = (byte)(input.InternalDecrypt() + 1);
			input.hiddenValue = EncryptDecrypt(value, input.currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning)
			{
				input.fakeValue = value;
			}
			return input;
		}

		public static ObscuredByte operator --(ObscuredByte input)
		{
			byte value = (byte)(input.InternalDecrypt() - 1);
			input.hiddenValue = EncryptDecrypt(value, input.currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning)
			{
				input.fakeValue = value;
			}
			return input;
		}
	}
	[Serializable]
	public struct ObscuredChar : IEquatable<ObscuredChar>
	{
		private static char cryptoKey = '—';

		private char currentCryptoKey;

		private char hiddenValue;

		private char fakeValue;

		private bool inited;

		private ObscuredChar(char value)
		{
			currentCryptoKey = cryptoKey;
			hiddenValue = value;
			fakeValue = '\0';
			inited = true;
		}

		public static void SetNewCryptoKey(char newKey)
		{
			cryptoKey = newKey;
		}

		public static char EncryptDecrypt(char value)
		{
			return EncryptDecrypt(value, '\0');
		}

		public static char EncryptDecrypt(char value, char key)
		{
			if (key == '\0')
			{
				return (char)(value ^ cryptoKey);
			}
			return (char)(value ^ key);
		}

		public void ApplyNewCryptoKey()
		{
			if (currentCryptoKey != cryptoKey)
			{
				hiddenValue = EncryptDecrypt(InternalDecrypt(), cryptoKey);
				currentCryptoKey = cryptoKey;
			}
		}

		public void RandomizeCryptoKey()
		{
			char value = InternalDecrypt();
			currentCryptoKey = (char)UnityEngine.Random.Range(1, 65535);
			hiddenValue = EncryptDecrypt(value, currentCryptoKey);
		}

		public char GetEncrypted()
		{
			ApplyNewCryptoKey();
			return hiddenValue;
		}

		public void SetEncrypted(char encrypted)
		{
			inited = true;
			hiddenValue = encrypted;
			if (ObscuredCheatingDetector.IsRunning)
			{
				fakeValue = InternalDecrypt();
			}
		}

		public char GetDecrypted()
		{
			return InternalDecrypt();
		}

		private char InternalDecrypt()
		{
			if (!inited)
			{
				currentCryptoKey = cryptoKey;
				hiddenValue = EncryptDecrypt('\0');
				fakeValue = '\0';
				inited = true;
			}
			char c = EncryptDecrypt(hiddenValue, currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning && fakeValue != 0 && c != fakeValue)
			{
				ObscuredCheatingDetector.Instance.OnCheatingDetected();
			}
			return c;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is ObscuredChar))
			{
				return false;
			}
			return Equals((ObscuredChar)obj);
		}

		public bool Equals(ObscuredChar obj)
		{
			if (currentCryptoKey == obj.currentCryptoKey)
			{
				return hiddenValue == obj.hiddenValue;
			}
			return EncryptDecrypt(hiddenValue, currentCryptoKey) == EncryptDecrypt(obj.hiddenValue, obj.currentCryptoKey);
		}

		public override string ToString()
		{
			return InternalDecrypt().ToString();
		}

		public string ToString(IFormatProvider provider)
		{
			return InternalDecrypt().ToString(provider);
		}

		public override int GetHashCode()
		{
			return InternalDecrypt().GetHashCode();
		}

		public static implicit operator ObscuredChar(char value)
		{
			ObscuredChar result = new ObscuredChar(EncryptDecrypt(value));
			if (ObscuredCheatingDetector.IsRunning)
			{
				result.fakeValue = value;
			}
			return result;
		}

		public static implicit operator char(ObscuredChar value)
		{
			return value.InternalDecrypt();
		}

		public static ObscuredChar operator ++(ObscuredChar input)
		{
			char value = (char)(input.InternalDecrypt() + 1);
			input.hiddenValue = EncryptDecrypt(value, input.currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning)
			{
				input.fakeValue = value;
			}
			return input;
		}

		public static ObscuredChar operator --(ObscuredChar input)
		{
			char value = (char)(input.InternalDecrypt() - 1);
			input.hiddenValue = EncryptDecrypt(value, input.currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning)
			{
				input.fakeValue = value;
			}
			return input;
		}
	}
	[Serializable]
	public struct ObscuredDecimal : IEquatable<ObscuredDecimal>, IFormattable
	{
		[StructLayout(LayoutKind.Explicit)]
		private struct DecimalLongBytesUnion
		{
			[FieldOffset(0)]
			public decimal d;

			[FieldOffset(0)]
			public long l1;

			[FieldOffset(8)]
			public long l2;

			[FieldOffset(0)]
			public ACTkByte16 b16;
		}

		private static long cryptoKey = 209208L;

		private long currentCryptoKey;

		[FormerlySerializedAs("hiddenValue")]
		private byte[] hiddenValueOld;

		private ACTkByte16 hiddenValue;

		private decimal fakeValue;

		private bool inited;

		private ObscuredDecimal(ACTkByte16 value)
		{
			currentCryptoKey = cryptoKey;
			hiddenValue = value;
			hiddenValueOld = null;
			fakeValue = 0m;
			inited = true;
		}

		public static void SetNewCryptoKey(long newKey)
		{
			cryptoKey = newKey;
		}

		public static decimal Encrypt(decimal value)
		{
			return Encrypt(value, cryptoKey);
		}

		public static decimal Encrypt(decimal value, long key)
		{
			DecimalLongBytesUnion decimalLongBytesUnion = new DecimalLongBytesUnion
			{
				d = value
			};
			decimalLongBytesUnion.l1 ^= key;
			decimalLongBytesUnion.l2 ^= key;
			return decimalLongBytesUnion.d;
		}

		private static ACTkByte16 InternalEncrypt(decimal value)
		{
			return InternalEncrypt(value, 0L);
		}

		private static ACTkByte16 InternalEncrypt(decimal value, long key)
		{
			long num = key;
			if (num == 0L)
			{
				num = cryptoKey;
			}
			DecimalLongBytesUnion decimalLongBytesUnion = new DecimalLongBytesUnion
			{
				d = value
			};
			decimalLongBytesUnion.l1 ^= num;
			decimalLongBytesUnion.l2 ^= num;
			return decimalLongBytesUnion.b16;
		}

		public static decimal Decrypt(decimal value)
		{
			return Decrypt(value, cryptoKey);
		}

		public static decimal Decrypt(decimal value, long key)
		{
			DecimalLongBytesUnion decimalLongBytesUnion = new DecimalLongBytesUnion
			{
				d = value
			};
			decimalLongBytesUnion.l1 ^= key;
			decimalLongBytesUnion.l2 ^= key;
			return decimalLongBytesUnion.d;
		}

		public void ApplyNewCryptoKey()
		{
			if (currentCryptoKey != cryptoKey)
			{
				hiddenValue = InternalEncrypt(InternalDecrypt(), cryptoKey);
				currentCryptoKey = cryptoKey;
			}
		}

		public void RandomizeCryptoKey()
		{
			decimal value = InternalDecrypt();
			do
			{
				currentCryptoKey = UnityEngine.Random.Range(int.MinValue, int.MaxValue);
			}
			while (currentCryptoKey == 0L);
			hiddenValue = InternalEncrypt(value, currentCryptoKey);
		}

		public decimal GetEncrypted()
		{
			ApplyNewCryptoKey();
			DecimalLongBytesUnion decimalLongBytesUnion = new DecimalLongBytesUnion
			{
				b16 = hiddenValue
			};
			return decimalLongBytesUnion.d;
		}

		public void SetEncrypted(decimal encrypted)
		{
			inited = true;
			DecimalLongBytesUnion decimalLongBytesUnion = new DecimalLongBytesUnion
			{
				d = encrypted
			};
			hiddenValue = decimalLongBytesUnion.b16;
			if (ObscuredCheatingDetector.IsRunning)
			{
				fakeValue = InternalDecrypt();
			}
		}

		public decimal GetDecrypted()
		{
			return InternalDecrypt();
		}

		private decimal InternalDecrypt()
		{
			if (!inited)
			{
				currentCryptoKey = cryptoKey;
				hiddenValue = InternalEncrypt(0m);
				fakeValue = 0m;
				inited = true;
			}
			DecimalLongBytesUnion decimalLongBytesUnion = new DecimalLongBytesUnion
			{
				b16 = hiddenValue
			};
			decimalLongBytesUnion.l1 ^= currentCryptoKey;
			decimalLongBytesUnion.l2 ^= currentCryptoKey;
			decimal d = decimalLongBytesUnion.d;
			if (ObscuredCheatingDetector.IsRunning && fakeValue != 0m && d != fakeValue)
			{
				ObscuredCheatingDetector.Instance.OnCheatingDetected();
			}
			return d;
		}

		public override string ToString()
		{
			return InternalDecrypt().ToString();
		}

		public string ToString(string format)
		{
			return InternalDecrypt().ToString(format);
		}

		public string ToString(IFormatProvider provider)
		{
			return InternalDecrypt().ToString(provider);
		}

		public string ToString(string format, IFormatProvider provider)
		{
			return InternalDecrypt().ToString(format, provider);
		}

		public override bool Equals(object obj)
		{
			if (!(obj is ObscuredDecimal))
			{
				return false;
			}
			return Equals((ObscuredDecimal)obj);
		}

		public bool Equals(ObscuredDecimal obj)
		{
			return obj.InternalDecrypt().Equals(InternalDecrypt());
		}

		public override int GetHashCode()
		{
			return InternalDecrypt().GetHashCode();
		}

		public static implicit operator ObscuredDecimal(decimal value)
		{
			ObscuredDecimal result = new ObscuredDecimal(InternalEncrypt(value));
			if (ObscuredCheatingDetector.IsRunning)
			{
				result.fakeValue = value;
			}
			return result;
		}

		public static implicit operator decimal(ObscuredDecimal value)
		{
			return value.InternalDecrypt();
		}

		public static explicit operator ObscuredDecimal(ObscuredFloat f)
		{
			return (decimal)(float)f;
		}

		public static ObscuredDecimal operator ++(ObscuredDecimal input)
		{
			decimal value = input.InternalDecrypt() + 1m;
			input.hiddenValue = InternalEncrypt(value, input.currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning)
			{
				input.fakeValue = value;
			}
			return input;
		}

		public static ObscuredDecimal operator --(ObscuredDecimal input)
		{
			decimal value = input.InternalDecrypt() - 1m;
			input.hiddenValue = InternalEncrypt(value, input.currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning)
			{
				input.fakeValue = value;
			}
			return input;
		}
	}
	[Serializable]
	public struct ObscuredDouble : IEquatable<ObscuredDouble>, IFormattable
	{
		[StructLayout(LayoutKind.Explicit)]
		private struct DoubleLongBytesUnion
		{
			[FieldOffset(0)]
			public double d;

			[FieldOffset(0)]
			public long l;

			[FieldOffset(0)]
			public ACTkByte8 b8;
		}

		private static long cryptoKey = 210987L;

		[SerializeField]
		private long currentCryptoKey;

		[SerializeField]
		private ACTkByte8 hiddenValue;

		[FormerlySerializedAs("hiddenValue")]
		[SerializeField]
		private byte[] hiddenValueOld;

		[SerializeField]
		private double fakeValue;

		[SerializeField]
		private bool inited;

		private ObscuredDouble(ACTkByte8 value)
		{
			currentCryptoKey = cryptoKey;
			hiddenValue = value;
			hiddenValueOld = null;
			fakeValue = 0.0;
			inited = true;
		}

		public static void SetNewCryptoKey(long newKey)
		{
			cryptoKey = newKey;
		}

		public static long Encrypt(double value)
		{
			return Encrypt(value, cryptoKey);
		}

		public static long Encrypt(double value, long key)
		{
			DoubleLongBytesUnion doubleLongBytesUnion = new DoubleLongBytesUnion
			{
				d = value
			};
			doubleLongBytesUnion.l ^= key;
			return doubleLongBytesUnion.l;
		}

		private static ACTkByte8 InternalEncrypt(double value)
		{
			return InternalEncrypt(value, 0L);
		}

		private static ACTkByte8 InternalEncrypt(double value, long key)
		{
			long num = key;
			if (num == 0L)
			{
				num = cryptoKey;
			}
			DoubleLongBytesUnion doubleLongBytesUnion = new DoubleLongBytesUnion
			{
				d = value
			};
			doubleLongBytesUnion.l ^= num;
			return doubleLongBytesUnion.b8;
		}

		public static double Decrypt(long value)
		{
			return Decrypt(value, cryptoKey);
		}

		public static double Decrypt(long value, long key)
		{
			DoubleLongBytesUnion doubleLongBytesUnion = new DoubleLongBytesUnion
			{
				l = (value ^ key)
			};
			return doubleLongBytesUnion.d;
		}

		public void ApplyNewCryptoKey()
		{
			if (currentCryptoKey != cryptoKey)
			{
				hiddenValue = InternalEncrypt(InternalDecrypt(), cryptoKey);
				currentCryptoKey = cryptoKey;
			}
		}

		public void RandomizeCryptoKey()
		{
			double value = InternalDecrypt();
			do
			{
				currentCryptoKey = UnityEngine.Random.Range(int.MinValue, int.MaxValue);
			}
			while (currentCryptoKey == 0L);
			hiddenValue = InternalEncrypt(value, currentCryptoKey);
		}

		public long GetEncrypted()
		{
			ApplyNewCryptoKey();
			DoubleLongBytesUnion doubleLongBytesUnion = new DoubleLongBytesUnion
			{
				b8 = hiddenValue
			};
			return doubleLongBytesUnion.l;
		}

		public void SetEncrypted(long encrypted)
		{
			inited = true;
			DoubleLongBytesUnion doubleLongBytesUnion = new DoubleLongBytesUnion
			{
				l = encrypted
			};
			hiddenValue = doubleLongBytesUnion.b8;
			if (ObscuredCheatingDetector.IsRunning)
			{
				fakeValue = InternalDecrypt();
			}
		}

		public double GetDecrypted()
		{
			return InternalDecrypt();
		}

		private double InternalDecrypt()
		{
			if (!inited)
			{
				currentCryptoKey = cryptoKey;
				hiddenValue = InternalEncrypt(0.0);
				fakeValue = 0.0;
				inited = true;
			}
			DoubleLongBytesUnion doubleLongBytesUnion = new DoubleLongBytesUnion
			{
				b8 = hiddenValue
			};
			doubleLongBytesUnion.l ^= currentCryptoKey;
			double d = doubleLongBytesUnion.d;
			if (ObscuredCheatingDetector.IsRunning && fakeValue != 0.0 && Math.Abs(d - fakeValue) > 1E-06)
			{
				ObscuredCheatingDetector.Instance.OnCheatingDetected();
			}
			return d;
		}

		public override string ToString()
		{
			return InternalDecrypt().ToString();
		}

		public string ToString(string format)
		{
			return InternalDecrypt().ToString(format);
		}

		public string ToString(IFormatProvider provider)
		{
			return InternalDecrypt().ToString(provider);
		}

		public string ToString(string format, IFormatProvider provider)
		{
			return InternalDecrypt().ToString(format, provider);
		}

		public override bool Equals(object obj)
		{
			if (!(obj is ObscuredDouble))
			{
				return false;
			}
			return Equals((ObscuredDouble)obj);
		}

		public bool Equals(ObscuredDouble obj)
		{
			return obj.InternalDecrypt().Equals(InternalDecrypt());
		}

		public override int GetHashCode()
		{
			return InternalDecrypt().GetHashCode();
		}

		public static implicit operator ObscuredDouble(double value)
		{
			ObscuredDouble result = new ObscuredDouble(InternalEncrypt(value));
			if (ObscuredCheatingDetector.IsRunning)
			{
				result.fakeValue = value;
			}
			return result;
		}

		public static implicit operator double(ObscuredDouble value)
		{
			return value.InternalDecrypt();
		}

		public static ObscuredDouble operator ++(ObscuredDouble input)
		{
			double value = input.InternalDecrypt() + 1.0;
			input.hiddenValue = InternalEncrypt(value, input.currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning)
			{
				input.fakeValue = value;
			}
			return input;
		}

		public static ObscuredDouble operator --(ObscuredDouble input)
		{
			double value = input.InternalDecrypt() - 1.0;
			input.hiddenValue = InternalEncrypt(value, input.currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning)
			{
				input.fakeValue = value;
			}
			return input;
		}
	}
	[Serializable]
	public struct ObscuredFloat : IEquatable<ObscuredFloat>, IFormattable
	{
		[StructLayout(LayoutKind.Explicit)]
		private struct FloatIntBytesUnion
		{
			[FieldOffset(0)]
			public float f;

			[FieldOffset(0)]
			public int i;

			[FieldOffset(0)]
			public ACTkByte4 b4;
		}

		private static int cryptoKey = 230887;

		[SerializeField]
		private int currentCryptoKey;

		[SerializeField]
		private ACTkByte4 hiddenValue;

		[SerializeField]
		[FormerlySerializedAs("hiddenValue")]
		private byte[] hiddenValueOld;

		[SerializeField]
		private float fakeValue;

		[SerializeField]
		private bool inited;

		private ObscuredFloat(ACTkByte4 value)
		{
			currentCryptoKey = cryptoKey;
			hiddenValue = value;
			hiddenValueOld = null;
			fakeValue = 0f;
			inited = true;
		}

		public static void SetNewCryptoKey(int newKey)
		{
			cryptoKey = newKey;
		}

		public static int Encrypt(float value)
		{
			return Encrypt(value, cryptoKey);
		}

		public static int Encrypt(float value, int key)
		{
			FloatIntBytesUnion floatIntBytesUnion = new FloatIntBytesUnion
			{
				f = value
			};
			floatIntBytesUnion.i ^= key;
			return floatIntBytesUnion.i;
		}

		private static ACTkByte4 InternalEncrypt(float value)
		{
			return InternalEncrypt(value, 0);
		}

		private static ACTkByte4 InternalEncrypt(float value, int key)
		{
			int num = key;
			if (num == 0)
			{
				num = cryptoKey;
			}
			FloatIntBytesUnion floatIntBytesUnion = new FloatIntBytesUnion
			{
				f = value
			};
			floatIntBytesUnion.i ^= num;
			return floatIntBytesUnion.b4;
		}

		public static float Decrypt(int value)
		{
			return Decrypt(value, cryptoKey);
		}

		public static float Decrypt(int value, int key)
		{
			FloatIntBytesUnion floatIntBytesUnion = new FloatIntBytesUnion
			{
				i = (value ^ key)
			};
			return floatIntBytesUnion.f;
		}

		public void ApplyNewCryptoKey()
		{
			if (currentCryptoKey != cryptoKey)
			{
				hiddenValue = InternalEncrypt(InternalDecrypt(), cryptoKey);
				currentCryptoKey = cryptoKey;
			}
		}

		public void RandomizeCryptoKey()
		{
			float value = InternalDecrypt();
			do
			{
				currentCryptoKey = UnityEngine.Random.Range(int.MinValue, int.MaxValue);
			}
			while (currentCryptoKey == 0);
			hiddenValue = InternalEncrypt(value, currentCryptoKey);
		}

		public int GetEncrypted()
		{
			ApplyNewCryptoKey();
			FloatIntBytesUnion floatIntBytesUnion = new FloatIntBytesUnion
			{
				b4 = hiddenValue
			};
			return floatIntBytesUnion.i;
		}

		public void SetEncrypted(int encrypted)
		{
			inited = true;
			FloatIntBytesUnion floatIntBytesUnion = new FloatIntBytesUnion
			{
				i = encrypted
			};
			hiddenValue = floatIntBytesUnion.b4;
			if (ObscuredCheatingDetector.IsRunning)
			{
				fakeValue = InternalDecrypt();
			}
		}

		public float GetDecrypted()
		{
			return InternalDecrypt();
		}

		private float InternalDecrypt()
		{
			if (!inited)
			{
				currentCryptoKey = cryptoKey;
				hiddenValue = InternalEncrypt(0f);
				fakeValue = 0f;
				inited = true;
			}
			FloatIntBytesUnion floatIntBytesUnion = new FloatIntBytesUnion
			{
				b4 = hiddenValue
			};
			floatIntBytesUnion.i ^= currentCryptoKey;
			float f = floatIntBytesUnion.f;
			if (ObscuredCheatingDetector.IsRunning && fakeValue != 0f && Math.Abs(f - fakeValue) > ObscuredCheatingDetector.Instance.floatEpsilon)
			{
				ObscuredCheatingDetector.Instance.OnCheatingDetected();
			}
			return f;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is ObscuredFloat))
			{
				return false;
			}
			return Equals((ObscuredFloat)obj);
		}

		public bool Equals(ObscuredFloat obj)
		{
			double num = obj.InternalDecrypt();
			double obj2 = InternalDecrypt();
			return num.Equals(obj2);
		}

		public override int GetHashCode()
		{
			return InternalDecrypt().GetHashCode();
		}

		public override string ToString()
		{
			return InternalDecrypt().ToString();
		}

		public string ToString(string format)
		{
			return InternalDecrypt().ToString(format);
		}

		public string ToString(IFormatProvider provider)
		{
			return InternalDecrypt().ToString(provider);
		}

		public string ToString(string format, IFormatProvider provider)
		{
			return InternalDecrypt().ToString(format, provider);
		}

		public static implicit operator ObscuredFloat(float value)
		{
			ObscuredFloat result = new ObscuredFloat(InternalEncrypt(value));
			if (ObscuredCheatingDetector.IsRunning)
			{
				result.fakeValue = value;
			}
			return result;
		}

		public static implicit operator float(ObscuredFloat value)
		{
			return value.InternalDecrypt();
		}

		public static ObscuredFloat operator ++(ObscuredFloat input)
		{
			float value = input.InternalDecrypt() + 1f;
			input.hiddenValue = InternalEncrypt(value, input.currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning)
			{
				input.fakeValue = value;
			}
			return input;
		}

		public static ObscuredFloat operator --(ObscuredFloat input)
		{
			float value = input.InternalDecrypt() - 1f;
			input.hiddenValue = InternalEncrypt(value, input.currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning)
			{
				input.fakeValue = value;
			}
			return input;
		}
	}
	[Serializable]
	public struct ObscuredInt : IEquatable<ObscuredInt>, IFormattable
	{
		private static int cryptoKey = 444444;

		[SerializeField]
		private int currentCryptoKey;

		[SerializeField]
		private int hiddenValue;

		[SerializeField]
		private int fakeValue;

		[SerializeField]
		private bool inited;

		private ObscuredInt(int value)
		{
			currentCryptoKey = cryptoKey;
			hiddenValue = value;
			fakeValue = 0;
			inited = true;
		}

		public static void SetNewCryptoKey(int newKey)
		{
			cryptoKey = newKey;
		}

		public static int Encrypt(int value)
		{
			return Encrypt(value, 0);
		}

		public static int Encrypt(int value, int key)
		{
			if (key == 0)
			{
				return value ^ cryptoKey;
			}
			return value ^ key;
		}

		public static int Decrypt(int value)
		{
			return Decrypt(value, 0);
		}

		public static int Decrypt(int value, int key)
		{
			if (key == 0)
			{
				return value ^ cryptoKey;
			}
			return value ^ key;
		}

		public void ApplyNewCryptoKey()
		{
			if (currentCryptoKey != cryptoKey)
			{
				hiddenValue = Encrypt(InternalDecrypt(), cryptoKey);
				currentCryptoKey = cryptoKey;
			}
		}

		public void RandomizeCryptoKey()
		{
			hiddenValue = InternalDecrypt();
			do
			{
				currentCryptoKey = UnityEngine.Random.Range(int.MinValue, int.MaxValue);
			}
			while (currentCryptoKey == 0);
			hiddenValue = Encrypt(hiddenValue, currentCryptoKey);
		}

		public int GetEncrypted()
		{
			ApplyNewCryptoKey();
			return hiddenValue;
		}

		public void SetEncrypted(int encrypted)
		{
			inited = true;
			hiddenValue = encrypted;
			if (ObscuredCheatingDetector.IsRunning)
			{
				fakeValue = InternalDecrypt();
			}
		}

		public int GetDecrypted()
		{
			return InternalDecrypt();
		}

		private int InternalDecrypt()
		{
			if (!inited)
			{
				currentCryptoKey = cryptoKey;
				hiddenValue = Encrypt(0);
				fakeValue = 0;
				inited = true;
			}
			int num = Decrypt(hiddenValue, currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning && fakeValue != 0 && num != fakeValue)
			{
				ObscuredCheatingDetector.Instance.OnCheatingDetected();
			}
			return num;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is ObscuredInt))
			{
				return false;
			}
			return Equals((ObscuredInt)obj);
		}

		public bool Equals(ObscuredInt obj)
		{
			if (currentCryptoKey == obj.currentCryptoKey)
			{
				return hiddenValue == obj.hiddenValue;
			}
			return Decrypt(hiddenValue, currentCryptoKey) == Decrypt(obj.hiddenValue, obj.currentCryptoKey);
		}

		public override int GetHashCode()
		{
			return InternalDecrypt().GetHashCode();
		}

		public override string ToString()
		{
			return InternalDecrypt().ToString();
		}

		public string ToString(string format)
		{
			return InternalDecrypt().ToString(format);
		}

		public string ToString(IFormatProvider provider)
		{
			return InternalDecrypt().ToString(provider);
		}

		public string ToString(string format, IFormatProvider provider)
		{
			return InternalDecrypt().ToString(format, provider);
		}

		public static implicit operator ObscuredInt(int value)
		{
			ObscuredInt result = new ObscuredInt(Encrypt(value));
			if (ObscuredCheatingDetector.IsRunning)
			{
				result.fakeValue = value;
			}
			return result;
		}

		public static implicit operator int(ObscuredInt value)
		{
			return value.InternalDecrypt();
		}

		public static implicit operator ObscuredFloat(ObscuredInt value)
		{
			return value.InternalDecrypt();
		}

		public static implicit operator ObscuredDouble(ObscuredInt value)
		{
			return value.InternalDecrypt();
		}

		public static explicit operator ObscuredUInt(ObscuredInt value)
		{
			return (uint)value.InternalDecrypt();
		}

		public static ObscuredInt operator ++(ObscuredInt input)
		{
			int value = input.InternalDecrypt() + 1;
			input.hiddenValue = Encrypt(value, input.currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning)
			{
				input.fakeValue = value;
			}
			return input;
		}

		public static ObscuredInt operator --(ObscuredInt input)
		{
			int value = input.InternalDecrypt() - 1;
			input.hiddenValue = Encrypt(value, input.currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning)
			{
				input.fakeValue = value;
			}
			return input;
		}
	}
	[Serializable]
	public struct ObscuredLong : IEquatable<ObscuredLong>, IFormattable
	{
		private static long cryptoKey = 444442L;

		[SerializeField]
		private long currentCryptoKey;

		[SerializeField]
		private long hiddenValue;

		[SerializeField]
		private long fakeValue;

		[SerializeField]
		private bool inited;

		private ObscuredLong(long value)
		{
			currentCryptoKey = cryptoKey;
			hiddenValue = value;
			fakeValue = 0L;
			inited = true;
		}

		public static void SetNewCryptoKey(long newKey)
		{
			cryptoKey = newKey;
		}

		public static long Encrypt(long value)
		{
			return Encrypt(value, 0L);
		}

		public static long Decrypt(long value)
		{
			return Decrypt(value, 0L);
		}

		public static long Encrypt(long value, long key)
		{
			if (key == 0L)
			{
				return value ^ cryptoKey;
			}
			return value ^ key;
		}

		public static long Decrypt(long value, long key)
		{
			if (key == 0L)
			{
				return value ^ cryptoKey;
			}
			return value ^ key;
		}

		public void ApplyNewCryptoKey()
		{
			if (currentCryptoKey != cryptoKey)
			{
				hiddenValue = Encrypt(InternalDecrypt(), cryptoKey);
				currentCryptoKey = cryptoKey;
			}
		}

		public void RandomizeCryptoKey()
		{
			long value = InternalDecrypt();
			do
			{
				currentCryptoKey = UnityEngine.Random.Range(int.MinValue, int.MaxValue);
			}
			while (currentCryptoKey == 0L);
			hiddenValue = Encrypt(value, currentCryptoKey);
		}

		public long GetEncrypted()
		{
			ApplyNewCryptoKey();
			return hiddenValue;
		}

		public void SetEncrypted(long encrypted)
		{
			inited = true;
			hiddenValue = encrypted;
			if (ObscuredCheatingDetector.IsRunning)
			{
				fakeValue = InternalDecrypt();
			}
		}

		public long GetDecrypted()
		{
			return InternalDecrypt();
		}

		private long InternalDecrypt()
		{
			if (!inited)
			{
				currentCryptoKey = cryptoKey;
				hiddenValue = Encrypt(0L);
				fakeValue = 0L;
				inited = true;
			}
			long num = Decrypt(hiddenValue, currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning && fakeValue != 0L && num != fakeValue)
			{
				ObscuredCheatingDetector.Instance.OnCheatingDetected();
			}
			return num;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is ObscuredLong))
			{
				return false;
			}
			return Equals((ObscuredLong)obj);
		}

		public bool Equals(ObscuredLong obj)
		{
			if (currentCryptoKey == obj.currentCryptoKey)
			{
				return hiddenValue == obj.hiddenValue;
			}
			return Decrypt(hiddenValue, currentCryptoKey) == Decrypt(obj.hiddenValue, obj.currentCryptoKey);
		}

		public override int GetHashCode()
		{
			return InternalDecrypt().GetHashCode();
		}

		public override string ToString()
		{
			return InternalDecrypt().ToString();
		}

		public string ToString(string format)
		{
			return InternalDecrypt().ToString(format);
		}

		public string ToString(IFormatProvider provider)
		{
			return InternalDecrypt().ToString(provider);
		}

		public string ToString(string format, IFormatProvider provider)
		{
			return InternalDecrypt().ToString(format, provider);
		}

		public static implicit operator ObscuredLong(long value)
		{
			ObscuredLong result = new ObscuredLong(Encrypt(value));
			if (ObscuredCheatingDetector.IsRunning)
			{
				result.fakeValue = value;
			}
			return result;
		}

		public static implicit operator long(ObscuredLong value)
		{
			return value.InternalDecrypt();
		}

		public static ObscuredLong operator ++(ObscuredLong input)
		{
			long value = input.InternalDecrypt() + 1;
			input.hiddenValue = Encrypt(value, input.currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning)
			{
				input.fakeValue = value;
			}
			return input;
		}

		public static ObscuredLong operator --(ObscuredLong input)
		{
			long value = input.InternalDecrypt() - 1;
			input.hiddenValue = Encrypt(value, input.currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning)
			{
				input.fakeValue = value;
			}
			return input;
		}
	}
	public static class ObscuredPrefs
	{
		internal enum DataType : byte
		{
			Unknown = 0,
			Int = 5,
			UInt = 10,
			String = 15,
			Float = 20,
			Double = 25,
			Decimal = 27,
			Long = 30,
			ULong = 32,
			Bool = 35,
			ByteArray = 40,
			Vector2 = 45,
			Vector3 = 50,
			Quaternion = 55,
			Color = 60,
			Rect = 65
		}

		public enum DeviceLockLevel : byte
		{
			None,
			Soft,
			Strict
		}

		private const byte VERSION = 2;

		private const string RAW_NOT_FOUND = "{not_found}";

		private const string DATA_SEPARATOR = "|";

		private const char DEPRECATED_RAW_SEPARATOR = ':';

		private static bool foreignSavesReported;

		private static string cryptoKey = "e806f6";

		private static string deviceId;

		private static uint deviceIdHash;

		public static Action onAlterationDetected;

		public static bool preservePlayerPrefs;

		public static Action onPossibleForeignSavesDetected;

		public static DeviceLockLevel lockToDevice;

		public static bool readForeignSaves;

		public static bool emergencyMode;

		private static string deprecatedDeviceId;

		public static string CryptoKey
		{
			get
			{
				return cryptoKey;
			}
			set
			{
				cryptoKey = value;
			}
		}

		public static string DeviceId
		{
			get
			{
				if (string.IsNullOrEmpty(deviceId))
				{
					deviceId = GetDeviceId();
				}
				return deviceId;
			}
			set
			{
				deviceId = value;
			}
		}

		[Obsolete("This property is obsolete, please use DeviceId instead.")]
		internal static string DeviceID
		{
			get
			{
				return DeviceId;
			}
			set
			{
				DeviceId = value;
			}
		}

		private static uint DeviceIdHash
		{
			get
			{
				if (deviceIdHash == 0)
				{
					deviceIdHash = CalculateChecksum(DeviceId);
				}
				return deviceIdHash;
			}
		}

		private static string DeprecatedDeviceId
		{
			get
			{
				if (string.IsNullOrEmpty(deprecatedDeviceId))
				{
					deprecatedDeviceId = DeprecatedCalculateChecksum(DeviceId);
				}
				return deprecatedDeviceId;
			}
		}

		public static void ForceLockToDeviceInit()
		{
			if (string.IsNullOrEmpty(deviceId))
			{
				deviceId = GetDeviceId();
				deviceIdHash = CalculateChecksum(deviceId);
			}
			else
			{
				UnityEngine.Debug.LogWarning("[ACTk] ObscuredPrefs.ForceLockToDeviceInit() is called, but device ID is already obtained!");
			}
		}

		[Obsolete("This method is obsolete, use property CryptoKey instead")]
		internal static void SetNewCryptoKey(string newKey)
		{
			CryptoKey = newKey;
		}

		public static void SetInt(string key, int value)
		{
			PlayerPrefs.SetString(EncryptKey(key), EncryptIntValue(key, value));
		}

		public static int GetInt(string key)
		{
			return GetInt(key, 0);
		}

		public static int GetInt(string key, int defaultValue)
		{
			string text = EncryptKey(key);
			if (!PlayerPrefs.HasKey(text) && PlayerPrefs.HasKey(key))
			{
				int num = PlayerPrefs.GetInt(key, defaultValue);
				if (!preservePlayerPrefs)
				{
					SetInt(key, num);
					PlayerPrefs.DeleteKey(key);
				}
				return num;
			}
			string encryptedPrefsString = GetEncryptedPrefsString(key, text);
			return (!(encryptedPrefsString == "{not_found}")) ? DecryptIntValue(key, encryptedPrefsString, defaultValue) : defaultValue;
		}

		internal static string EncryptIntValue(string key, int value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			return EncryptData(key, bytes, DataType.Int);
		}

		internal static int DecryptIntValue(string key, string encryptedInput, int defaultValue)
		{
			if (encryptedInput.IndexOf(':') > -1)
			{
				string text = DeprecatedDecryptValue(encryptedInput);
				if (text == string.Empty)
				{
					return defaultValue;
				}
				int.TryParse(text, out var result);
				SetInt(key, result);
				return result;
			}
			byte[] array = DecryptData(key, encryptedInput);
			if (array == null)
			{
				return defaultValue;
			}
			return BitConverter.ToInt32(array, 0);
		}

		public static void SetUInt(string key, uint value)
		{
			PlayerPrefs.SetString(EncryptKey(key), EncryptUIntValue(key, value));
		}

		public static uint GetUInt(string key)
		{
			return GetUInt(key, 0u);
		}

		public static uint GetUInt(string key, uint defaultValue)
		{
			string encryptedPrefsString = GetEncryptedPrefsString(key, EncryptKey(key));
			return (!(encryptedPrefsString == "{not_found}")) ? DecryptUIntValue(key, encryptedPrefsString, defaultValue) : defaultValue;
		}

		private static string EncryptUIntValue(string key, uint value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			return EncryptData(key, bytes, DataType.UInt);
		}

		private static uint DecryptUIntValue(string key, string encryptedInput, uint defaultValue)
		{
			if (encryptedInput.IndexOf(':') > -1)
			{
				string text = DeprecatedDecryptValue(encryptedInput);
				if (text == string.Empty)
				{
					return defaultValue;
				}
				uint.TryParse(text, out var result);
				SetUInt(key, result);
				return result;
			}
			byte[] array = DecryptData(key, encryptedInput);
			if (array == null)
			{
				return defaultValue;
			}
			return BitConverter.ToUInt32(array, 0);
		}

		public static void SetString(string key, string value)
		{
			PlayerPrefs.SetString(EncryptKey(key), EncryptStringValue(key, value));
		}

		public static string GetString(string key)
		{
			return GetString(key, string.Empty);
		}

		public static string GetString(string key, string defaultValue)
		{
			string text = EncryptKey(key);
			if (!PlayerPrefs.HasKey(text) && PlayerPrefs.HasKey(key))
			{
				string text2 = PlayerPrefs.GetString(key, defaultValue);
				if (!preservePlayerPrefs)
				{
					SetString(key, text2);
					PlayerPrefs.DeleteKey(key);
				}
				return text2;
			}
			string encryptedPrefsString = GetEncryptedPrefsString(key, text);
			return (!(encryptedPrefsString == "{not_found}")) ? DecryptStringValue(key, encryptedPrefsString, defaultValue) : defaultValue;
		}

		internal static string EncryptStringValue(string key, string value)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(value);
			return EncryptData(key, bytes, DataType.String);
		}

		internal static string DecryptStringValue(string key, string encryptedInput, string defaultValue)
		{
			if (encryptedInput.IndexOf(':') > -1)
			{
				string text = DeprecatedDecryptValue(encryptedInput);
				if (text == string.Empty)
				{
					return defaultValue;
				}
				SetString(key, text);
				return text;
			}
			byte[] array = DecryptData(key, encryptedInput);
			if (array == null)
			{
				return defaultValue;
			}
			return Encoding.UTF8.GetString(array, 0, array.Length);
		}

		public static void SetFloat(string key, float value)
		{
			PlayerPrefs.SetString(EncryptKey(key), EncryptFloatValue(key, value));
		}

		public static float GetFloat(string key)
		{
			return GetFloat(key, 0f);
		}

		public static float GetFloat(string key, float defaultValue)
		{
			string text = EncryptKey(key);
			if (!PlayerPrefs.HasKey(text) && PlayerPrefs.HasKey(key))
			{
				float num = PlayerPrefs.GetFloat(key, defaultValue);
				if (!preservePlayerPrefs)
				{
					SetFloat(key, num);
					PlayerPrefs.DeleteKey(key);
				}
				return num;
			}
			string encryptedPrefsString = GetEncryptedPrefsString(key, text);
			return (!(encryptedPrefsString == "{not_found}")) ? DecryptFloatValue(key, encryptedPrefsString, defaultValue) : defaultValue;
		}

		internal static string EncryptFloatValue(string key, float value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			return EncryptData(key, bytes, DataType.Float);
		}

		internal static float DecryptFloatValue(string key, string encryptedInput, float defaultValue)
		{
			if (encryptedInput.IndexOf(':') > -1)
			{
				string text = DeprecatedDecryptValue(encryptedInput);
				if (text == string.Empty)
				{
					return defaultValue;
				}
				float.TryParse(text, out var result);
				SetFloat(key, result);
				return result;
			}
			byte[] array = DecryptData(key, encryptedInput);
			if (array == null)
			{
				return defaultValue;
			}
			return BitConverter.ToSingle(array, 0);
		}

		public static void SetDouble(string key, double value)
		{
			PlayerPrefs.SetString(EncryptKey(key), EncryptDoubleValue(key, value));
		}

		public static double GetDouble(string key)
		{
			return GetDouble(key, 0.0);
		}

		public static double GetDouble(string key, double defaultValue)
		{
			string encryptedPrefsString = GetEncryptedPrefsString(key, EncryptKey(key));
			return (!(encryptedPrefsString == "{not_found}")) ? DecryptDoubleValue(key, encryptedPrefsString, defaultValue) : defaultValue;
		}

		private static string EncryptDoubleValue(string key, double value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			return EncryptData(key, bytes, DataType.Double);
		}

		private static double DecryptDoubleValue(string key, string encryptedInput, double defaultValue)
		{
			if (encryptedInput.IndexOf(':') > -1)
			{
				string text = DeprecatedDecryptValue(encryptedInput);
				if (text == string.Empty)
				{
					return defaultValue;
				}
				double.TryParse(text, out var result);
				SetDouble(key, result);
				return result;
			}
			byte[] array = DecryptData(key, encryptedInput);
			if (array == null)
			{
				return defaultValue;
			}
			return BitConverter.ToDouble(array, 0);
		}

		public static void SetDecimal(string key, decimal value)
		{
			PlayerPrefs.SetString(EncryptKey(key), EncryptDecimalValue(key, value));
		}

		public static decimal GetDecimal(string key)
		{
			return GetDecimal(key, 0m);
		}

		public static decimal GetDecimal(string key, decimal defaultValue)
		{
			string encryptedPrefsString = GetEncryptedPrefsString(key, EncryptKey(key));
			return (!(encryptedPrefsString == "{not_found}")) ? DecryptDecimalValue(key, encryptedPrefsString, defaultValue) : defaultValue;
		}

		private static string EncryptDecimalValue(string key, decimal value)
		{
			byte[] bytes = BitconverterExt.GetBytes(value);
			return EncryptData(key, bytes, DataType.Decimal);
		}

		private static decimal DecryptDecimalValue(string key, string encryptedInput, decimal defaultValue)
		{
			if (encryptedInput.IndexOf(':') > -1)
			{
				string text = DeprecatedDecryptValue(encryptedInput);
				if (text == string.Empty)
				{
					return defaultValue;
				}
				decimal.TryParse(text, out var result);
				SetDecimal(key, result);
				return result;
			}
			byte[] array = DecryptData(key, encryptedInput);
			if (array == null)
			{
				return defaultValue;
			}
			return BitconverterExt.ToDecimal(array);
		}

		public static void SetLong(string key, long value)
		{
			PlayerPrefs.SetString(EncryptKey(key), EncryptLongValue(key, value));
		}

		public static long GetLong(string key)
		{
			return GetLong(key, 0L);
		}

		public static long GetLong(string key, long defaultValue)
		{
			string encryptedPrefsString = GetEncryptedPrefsString(key, EncryptKey(key));
			return (!(encryptedPrefsString == "{not_found}")) ? DecryptLongValue(key, encryptedPrefsString, defaultValue) : defaultValue;
		}

		private static string EncryptLongValue(string key, long value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			return EncryptData(key, bytes, DataType.Long);
		}

		private static long DecryptLongValue(string key, string encryptedInput, long defaultValue)
		{
			if (encryptedInput.IndexOf(':') > -1)
			{
				string text = DeprecatedDecryptValue(encryptedInput);
				if (text == string.Empty)
				{
					return defaultValue;
				}
				long.TryParse(text, out var result);
				SetLong(key, result);
				return result;
			}
			byte[] array = DecryptData(key, encryptedInput);
			if (array == null)
			{
				return defaultValue;
			}
			return BitConverter.ToInt64(array, 0);
		}

		public static void SetULong(string key, ulong value)
		{
			PlayerPrefs.SetString(EncryptKey(key), EncryptULongValue(key, value));
		}

		public static ulong GetULong(string key)
		{
			return GetULong(key, 0uL);
		}

		public static ulong GetULong(string key, ulong defaultValue)
		{
			string encryptedPrefsString = GetEncryptedPrefsString(key, EncryptKey(key));
			return (!(encryptedPrefsString == "{not_found}")) ? DecryptULongValue(key, encryptedPrefsString, defaultValue) : defaultValue;
		}

		private static string EncryptULongValue(string key, ulong value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			return EncryptData(key, bytes, DataType.ULong);
		}

		private static ulong DecryptULongValue(string key, string encryptedInput, ulong defaultValue)
		{
			if (encryptedInput.IndexOf(':') > -1)
			{
				string text = DeprecatedDecryptValue(encryptedInput);
				if (text == string.Empty)
				{
					return defaultValue;
				}
				ulong.TryParse(text, out var result);
				SetULong(key, result);
				return result;
			}
			byte[] array = DecryptData(key, encryptedInput);
			if (array == null)
			{
				return defaultValue;
			}
			return BitConverter.ToUInt64(array, 0);
		}

		public static void SetBool(string key, bool value)
		{
			PlayerPrefs.SetString(EncryptKey(key), EncryptBoolValue(key, value));
		}

		public static bool GetBool(string key)
		{
			return GetBool(key, defaultValue: false);
		}

		public static bool GetBool(string key, bool defaultValue)
		{
			string encryptedPrefsString = GetEncryptedPrefsString(key, EncryptKey(key));
			return (!(encryptedPrefsString == "{not_found}")) ? DecryptBoolValue(key, encryptedPrefsString, defaultValue) : defaultValue;
		}

		private static string EncryptBoolValue(string key, bool value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			return EncryptData(key, bytes, DataType.Bool);
		}

		private static bool DecryptBoolValue(string key, string encryptedInput, bool defaultValue)
		{
			if (encryptedInput.IndexOf(':') > -1)
			{
				string text = DeprecatedDecryptValue(encryptedInput);
				if (text == string.Empty)
				{
					return defaultValue;
				}
				int.TryParse(text, out var result);
				SetBool(key, result == 1);
				return result == 1;
			}
			byte[] array = DecryptData(key, encryptedInput);
			if (array == null)
			{
				return defaultValue;
			}
			return BitConverter.ToBoolean(array, 0);
		}

		public static void SetByteArray(string key, byte[] value)
		{
			PlayerPrefs.SetString(EncryptKey(key), EncryptByteArrayValue(key, value));
		}

		public static byte[] GetByteArray(string key)
		{
			return GetByteArray(key, 0, 0);
		}

		public static byte[] GetByteArray(string key, byte defaultValue, int defaultLength)
		{
			string encryptedPrefsString = GetEncryptedPrefsString(key, EncryptKey(key));
			if (encryptedPrefsString == "{not_found}")
			{
				return ConstructByteArray(defaultValue, defaultLength);
			}
			return DecryptByteArrayValue(key, encryptedPrefsString, defaultValue, defaultLength);
		}

		private static string EncryptByteArrayValue(string key, byte[] value)
		{
			return EncryptData(key, value, DataType.ByteArray);
		}

		private static byte[] DecryptByteArrayValue(string key, string encryptedInput, byte defaultValue, int defaultLength)
		{
			if (encryptedInput.IndexOf(':') > -1)
			{
				string text = DeprecatedDecryptValue(encryptedInput);
				if (text == string.Empty)
				{
					return ConstructByteArray(defaultValue, defaultLength);
				}
				byte[] bytes = Encoding.UTF8.GetBytes(text);
				SetByteArray(key, bytes);
				return bytes;
			}
			byte[] array = DecryptData(key, encryptedInput);
			if (array == null)
			{
				return ConstructByteArray(defaultValue, defaultLength);
			}
			return array;
		}

		private static byte[] ConstructByteArray(byte value, int length)
		{
			byte[] array = new byte[length];
			for (int i = 0; i < length; i++)
			{
				array[i] = value;
			}
			return array;
		}

		public static void SetVector2(string key, Vector2 value)
		{
			PlayerPrefs.SetString(EncryptKey(key), EncryptVector2Value(key, value));
		}

		public static Vector2 GetVector2(string key)
		{
			return GetVector2(key, Vector2.zero);
		}

		public static Vector2 GetVector2(string key, Vector2 defaultValue)
		{
			string encryptedPrefsString = GetEncryptedPrefsString(key, EncryptKey(key));
			return (!(encryptedPrefsString == "{not_found}")) ? DecryptVector2Value(key, encryptedPrefsString, defaultValue) : defaultValue;
		}

		private static string EncryptVector2Value(string key, Vector2 value)
		{
			byte[] array = new byte[8];
			Buffer.BlockCopy(BitConverter.GetBytes(value.x), 0, array, 0, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(value.y), 0, array, 4, 4);
			return EncryptData(key, array, DataType.Vector2);
		}

		private static Vector2 DecryptVector2Value(string key, string encryptedInput, Vector2 defaultValue)
		{
			if (encryptedInput.IndexOf(':') > -1)
			{
				string text = DeprecatedDecryptValue(encryptedInput);
				if (text == string.Empty)
				{
					return defaultValue;
				}
				string[] array = text.Split("|"[0]);
				float.TryParse(array[0], out var result);
				float.TryParse(array[1], out var result2);
				Vector2 vector = new Vector2(result, result2);
				SetVector2(key, vector);
				return vector;
			}
			byte[] array2 = DecryptData(key, encryptedInput);
			if (array2 == null)
			{
				return defaultValue;
			}
			Vector2 result3 = default(Vector2);
			result3.x = BitConverter.ToSingle(array2, 0);
			result3.y = BitConverter.ToSingle(array2, 4);
			return result3;
		}

		public static void SetVector3(string key, Vector3 value)
		{
			PlayerPrefs.SetString(EncryptKey(key), EncryptVector3Value(key, value));
		}

		public static Vector3 GetVector3(string key)
		{
			return GetVector3(key, Vector3.zero);
		}

		public static Vector3 GetVector3(string key, Vector3 defaultValue)
		{
			string encryptedPrefsString = GetEncryptedPrefsString(key, EncryptKey(key));
			return (!(encryptedPrefsString == "{not_found}")) ? DecryptVector3Value(key, encryptedPrefsString, defaultValue) : defaultValue;
		}

		private static string EncryptVector3Value(string key, Vector3 value)
		{
			byte[] array = new byte[12];
			Buffer.BlockCopy(BitConverter.GetBytes(value.x), 0, array, 0, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(value.y), 0, array, 4, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(value.z), 0, array, 8, 4);
			return EncryptData(key, array, DataType.Vector3);
		}

		private static Vector3 DecryptVector3Value(string key, string encryptedInput, Vector3 defaultValue)
		{
			if (encryptedInput.IndexOf(':') > -1)
			{
				string text = DeprecatedDecryptValue(encryptedInput);
				if (text == string.Empty)
				{
					return defaultValue;
				}
				string[] array = text.Split("|"[0]);
				float.TryParse(array[0], out var result);
				float.TryParse(array[1], out var result2);
				float.TryParse(array[2], out var result3);
				Vector3 vector = new Vector3(result, result2, result3);
				SetVector3(key, vector);
				return vector;
			}
			byte[] array2 = DecryptData(key, encryptedInput);
			if (array2 == null)
			{
				return defaultValue;
			}
			Vector3 result4 = default(Vector3);
			result4.x = BitConverter.ToSingle(array2, 0);
			result4.y = BitConverter.ToSingle(array2, 4);
			result4.z = BitConverter.ToSingle(array2, 8);
			return result4;
		}

		public static void SetQuaternion(string key, Quaternion value)
		{
			PlayerPrefs.SetString(EncryptKey(key), EncryptQuaternionValue(key, value));
		}

		public static Quaternion GetQuaternion(string key)
		{
			return GetQuaternion(key, Quaternion.identity);
		}

		public static Quaternion GetQuaternion(string key, Quaternion defaultValue)
		{
			string encryptedPrefsString = GetEncryptedPrefsString(key, EncryptKey(key));
			return (!(encryptedPrefsString == "{not_found}")) ? DecryptQuaternionValue(key, encryptedPrefsString, defaultValue) : defaultValue;
		}

		private static string EncryptQuaternionValue(string key, Quaternion value)
		{
			byte[] array = new byte[16];
			Buffer.BlockCopy(BitConverter.GetBytes(value.x), 0, array, 0, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(value.y), 0, array, 4, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(value.z), 0, array, 8, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(value.w), 0, array, 12, 4);
			return EncryptData(key, array, DataType.Quaternion);
		}

		private static Quaternion DecryptQuaternionValue(string key, string encryptedInput, Quaternion defaultValue)
		{
			if (encryptedInput.IndexOf(':') > -1)
			{
				string text = DeprecatedDecryptValue(encryptedInput);
				if (text == string.Empty)
				{
					return defaultValue;
				}
				string[] array = text.Split("|"[0]);
				float.TryParse(array[0], out var result);
				float.TryParse(array[1], out var result2);
				float.TryParse(array[2], out var result3);
				float.TryParse(array[3], out var result4);
				Quaternion quaternion = new Quaternion(result, result2, result3, result4);
				SetQuaternion(key, quaternion);
				return quaternion;
			}
			byte[] array2 = DecryptData(key, encryptedInput);
			if (array2 == null)
			{
				return defaultValue;
			}
			Quaternion result5 = default(Quaternion);
			result5.x = BitConverter.ToSingle(array2, 0);
			result5.y = BitConverter.ToSingle(array2, 4);
			result5.z = BitConverter.ToSingle(array2, 8);
			result5.w = BitConverter.ToSingle(array2, 12);
			return result5;
		}

		public static void SetColor(string key, Color32 value)
		{
			uint value2 = (uint)((value.a << 24) | (value.r << 16) | (value.g << 8) | value.b);
			PlayerPrefs.SetString(EncryptKey(key), EncryptColorValue(key, value2));
		}

		public static Color32 GetColor(string key)
		{
			return GetColor(key, new Color32(0, 0, 0, 1));
		}

		public static Color32 GetColor(string key, Color32 defaultValue)
		{
			string encryptedPrefsString = GetEncryptedPrefsString(key, EncryptKey(key));
			if (encryptedPrefsString == "{not_found}")
			{
				return defaultValue;
			}
			uint num = DecryptUIntValue(key, encryptedPrefsString, 16777216u);
			byte a = (byte)(num >> 24);
			byte r = (byte)(num >> 16);
			byte g = (byte)(num >> 8);
			byte b = (byte)num;
			return new Color32(r, g, b, a);
		}

		private static string EncryptColorValue(string key, uint value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			return EncryptData(key, bytes, DataType.Color);
		}

		public static void SetRect(string key, Rect value)
		{
			PlayerPrefs.SetString(EncryptKey(key), EncryptRectValue(key, value));
		}

		public static Rect GetRect(string key)
		{
			return GetRect(key, new Rect(0f, 0f, 0f, 0f));
		}

		public static Rect GetRect(string key, Rect defaultValue)
		{
			string encryptedPrefsString = GetEncryptedPrefsString(key, EncryptKey(key));
			return (!(encryptedPrefsString == "{not_found}")) ? DecryptRectValue(key, encryptedPrefsString, defaultValue) : defaultValue;
		}

		private static string EncryptRectValue(string key, Rect value)
		{
			byte[] array = new byte[16];
			Buffer.BlockCopy(BitConverter.GetBytes(value.x), 0, array, 0, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(value.y), 0, array, 4, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(value.width), 0, array, 8, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(value.height), 0, array, 12, 4);
			return EncryptData(key, array, DataType.Rect);
		}

		private static Rect DecryptRectValue(string key, string encryptedInput, Rect defaultValue)
		{
			if (encryptedInput.IndexOf(':') > -1)
			{
				string text = DeprecatedDecryptValue(encryptedInput);
				if (text == string.Empty)
				{
					return defaultValue;
				}
				string[] array = text.Split("|"[0]);
				float.TryParse(array[0], out var result);
				float.TryParse(array[1], out var result2);
				float.TryParse(array[2], out var result3);
				float.TryParse(array[3], out var result4);
				Rect rect = new Rect(result, result2, result3, result4);
				SetRect(key, rect);
				return rect;
			}
			byte[] array2 = DecryptData(key, encryptedInput);
			if (array2 == null)
			{
				return defaultValue;
			}
			return new Rect
			{
				x = BitConverter.ToSingle(array2, 0),
				y = BitConverter.ToSingle(array2, 4),
				width = BitConverter.ToSingle(array2, 8),
				height = BitConverter.ToSingle(array2, 12)
			};
		}

		public static void SetRawValue(string key, string encryptedValue)
		{
			PlayerPrefs.SetString(EncryptKey(key), encryptedValue);
		}

		public static string GetRawValue(string key)
		{
			string key2 = EncryptKey(key);
			return PlayerPrefs.GetString(key2);
		}

		internal static DataType GetRawValueType(string value)
		{
			DataType result = DataType.Unknown;
			byte[] array;
			try
			{
				array = Convert.FromBase64String(value);
			}
			catch (Exception)
			{
				return result;
			}
			if (array.Length < 7)
			{
				return result;
			}
			int num = array.Length;
			result = (DataType)array[num - 7];
			byte b = array[num - 6];
			if (b > 10)
			{
				result = DataType.Unknown;
			}
			return result;
		}

		internal static string EncryptKey(string key)
		{
			key = ObscuredString.EncryptDecrypt(key, cryptoKey);
			key = Convert.ToBase64String(Encoding.UTF8.GetBytes(key));
			return key;
		}

		public static bool HasKey(string key)
		{
			return PlayerPrefs.HasKey(key) || PlayerPrefs.HasKey(EncryptKey(key));
		}

		public static void DeleteKey(string key)
		{
			PlayerPrefs.DeleteKey(EncryptKey(key));
			if (!preservePlayerPrefs)
			{
				PlayerPrefs.DeleteKey(key);
			}
		}

		public static void DeleteAll()
		{
			PlayerPrefs.DeleteAll();
		}

		public static void Save()
		{
			PlayerPrefs.Save();
		}

		private static string GetEncryptedPrefsString(string key, string encryptedKey)
		{
			string text = PlayerPrefs.GetString(encryptedKey, "{not_found}");
			if (text == "{not_found}" && PlayerPrefs.HasKey(key))
			{
				UnityEngine.Debug.LogWarning("[ACTk] Are you trying to read regular PlayerPrefs data using ObscuredPrefs (key = " + key + ")?");
			}
			return text;
		}

		private static string EncryptData(string key, byte[] cleanBytes, DataType type)
		{
			int num = cleanBytes.Length;
			byte[] src = EncryptDecryptBytes(cleanBytes, num, key + cryptoKey);
			uint num2 = xxHash.CalculateHash(cleanBytes, num, 0u);
			byte[] src2 = new byte[4]
			{
				(byte)(num2 & 0xFF),
				(byte)((num2 >> 8) & 0xFF),
				(byte)((num2 >> 16) & 0xFF),
				(byte)((num2 >> 24) & 0xFF)
			};
			byte[] array = null;
			int num3;
			if (lockToDevice != DeviceLockLevel.None)
			{
				num3 = num + 11;
				uint num4 = DeviceIdHash;
				array = new byte[4]
				{
					(byte)(num4 & 0xFF),
					(byte)((num4 >> 8) & 0xFF),
					(byte)((num4 >> 16) & 0xFF),
					(byte)((num4 >> 24) & 0xFF)
				};
			}
			else
			{
				num3 = num + 7;
			}
			byte[] array2 = new byte[num3];
			Buffer.BlockCopy(src, 0, array2, 0, num);
			if (array != null)
			{
				Buffer.BlockCopy(array, 0, array2, num, 4);
			}
			array2[num3 - 7] = (byte)type;
			array2[num3 - 6] = 2;
			array2[num3 - 5] = (byte)lockToDevice;
			Buffer.BlockCopy(src2, 0, array2, num3 - 4, 4);
			return Convert.ToBase64String(array2);
		}

		internal static byte[] DecryptData(string key, string encryptedInput)
		{
			byte[] array;
			try
			{
				array = Convert.FromBase64String(encryptedInput);
			}
			catch (Exception)
			{
				SavesTampered();
				return null;
			}
			if (array.Length <= 0)
			{
				SavesTampered();
				return null;
			}
			int num = array.Length;
			byte b = array[num - 6];
			if (b != 2)
			{
				SavesTampered();
				return null;
			}
			DeviceLockLevel deviceLockLevel = (DeviceLockLevel)array[num - 5];
			byte[] array2 = new byte[4];
			Buffer.BlockCopy(array, num - 4, array2, 0, 4);
			uint num2 = (uint)(array2[0] | (array2[1] << 8) | (array2[2] << 16) | (array2[3] << 24));
			uint num3 = 0u;
			int num4;
			if (deviceLockLevel != DeviceLockLevel.None)
			{
				num4 = num - 11;
				if (lockToDevice != DeviceLockLevel.None)
				{
					byte[] array3 = new byte[4];
					Buffer.BlockCopy(array, num4, array3, 0, 4);
					num3 = (uint)(array3[0] | (array3[1] << 8) | (array3[2] << 16) | (array3[3] << 24));
				}
			}
			else
			{
				num4 = num - 7;
			}
			byte[] array4 = new byte[num4];
			Buffer.BlockCopy(array, 0, array4, 0, num4);
			byte[] array5 = EncryptDecryptBytes(array4, num4, key + cryptoKey);
			uint num5 = xxHash.CalculateHash(array5, num4, 0u);
			if (num5 != num2)
			{
				SavesTampered();
				return null;
			}
			if (lockToDevice == DeviceLockLevel.Strict && num3 == 0 && !emergencyMode && !readForeignSaves)
			{
				return null;
			}
			if (num3 != 0 && !emergencyMode)
			{
				uint num6 = DeviceIdHash;
				if (num3 != num6)
				{
					PossibleForeignSavesDetected();
					if (!readForeignSaves)
					{
						return null;
					}
				}
			}
			return array5;
		}

		private static uint CalculateChecksum(string input)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(input + cryptoKey);
			return xxHash.CalculateHash(bytes, bytes.Length, 0u);
		}

		private static void SavesTampered()
		{
			if (onAlterationDetected != null)
			{
				onAlterationDetected();
				onAlterationDetected = null;
			}
		}

		private static void PossibleForeignSavesDetected()
		{
			if (onPossibleForeignSavesDetected != null && !foreignSavesReported)
			{
				foreignSavesReported = true;
				onPossibleForeignSavesDetected();
			}
		}

		private static string GetDeviceId()
		{
			string text = string.Empty;
			if (string.IsNullOrEmpty(text))
			{
				text = SystemInfo.deviceUniqueIdentifier;
			}
			return text;
		}

		private static byte[] EncryptDecryptBytes(byte[] bytes, int dataLength, string key)
		{
			int length = key.Length;
			byte[] array = new byte[dataLength];
			for (int i = 0; i < dataLength; i++)
			{
				array[i] = (byte)(bytes[i] ^ key[i % length]);
			}
			return array;
		}

		private static string DeprecatedDecryptValue(string value)
		{
			string[] array = value.Split(':');
			if (array.Length < 2)
			{
				SavesTampered();
				return string.Empty;
			}
			string text = array[0];
			string text2 = array[1];
			byte[] array2;
			try
			{
				array2 = Convert.FromBase64String(text);
			}
			catch
			{
				SavesTampered();
				return string.Empty;
			}
			string value2 = Encoding.UTF8.GetString(array2, 0, array2.Length);
			string result = ObscuredString.EncryptDecrypt(value2, cryptoKey);
			if (array.Length == 3)
			{
				if (text2 != DeprecatedCalculateChecksum(text + DeprecatedDeviceId))
				{
					SavesTampered();
				}
			}
			else if (array.Length == 2)
			{
				if (text2 != DeprecatedCalculateChecksum(text))
				{
					SavesTampered();
				}
			}
			else
			{
				SavesTampered();
			}
			if (lockToDevice != DeviceLockLevel.None && !emergencyMode)
			{
				if (array.Length >= 3)
				{
					string text3 = array[2];
					if (text3 != DeprecatedDeviceId)
					{
						if (!readForeignSaves)
						{
							result = string.Empty;
						}
						PossibleForeignSavesDetected();
					}
				}
				else if (lockToDevice == DeviceLockLevel.Strict)
				{
					if (!readForeignSaves)
					{
						result = string.Empty;
					}
					PossibleForeignSavesDetected();
				}
				else if (text2 != DeprecatedCalculateChecksum(text))
				{
					if (!readForeignSaves)
					{
						result = string.Empty;
					}
					PossibleForeignSavesDetected();
				}
			}
			return result;
		}

		private static string DeprecatedCalculateChecksum(string input)
		{
			int num = 0;
			byte[] bytes = Encoding.UTF8.GetBytes(input + cryptoKey);
			int num2 = bytes.Length;
			int num3 = cryptoKey.Length ^ 0x40;
			for (int i = 0; i < num2; i++)
			{
				byte b = bytes[i];
				num += b + b * (i + num3) % 3;
			}
			return num.ToString("X2");
		}
	}
	internal class BitconverterExt
	{
		public static byte[] GetBytes(decimal dec)
		{
			int[] bits = decimal.GetBits(dec);
			List<byte> list = new List<byte>();
			int[] array = bits;
			foreach (int value in array)
			{
				list.AddRange(BitConverter.GetBytes(value));
			}
			return list.ToArray();
		}

		public static decimal ToDecimal(byte[] bytes)
		{
			if (bytes.Length != 16)
			{
				throw new Exception("[ACTk] A decimal must be created from exactly 16 bytes");
			}
			int[] array = new int[4];
			for (int i = 0; i <= 15; i += 4)
			{
				array[i / 4] = BitConverter.ToInt32(bytes, i);
			}
			return new decimal(array);
		}
	}
	[Serializable]
	public struct ObscuredQuaternion
	{
		[Serializable]
		public struct RawEncryptedQuaternion
		{
			public int x;

			public int y;

			public int z;

			public int w;
		}

		private static int cryptoKey = 120205;

		private static readonly Quaternion initialFakeValue = Quaternion.identity;

		[SerializeField]
		private int currentCryptoKey;

		[SerializeField]
		private RawEncryptedQuaternion hiddenValue;

		[SerializeField]
		private Quaternion fakeValue;

		[SerializeField]
		private bool inited;

		private ObscuredQuaternion(RawEncryptedQuaternion value)
		{
			currentCryptoKey = cryptoKey;
			hiddenValue = value;
			fakeValue = initialFakeValue;
			inited = true;
		}

		public ObscuredQuaternion(float x, float y, float z, float w)
		{
			currentCryptoKey = cryptoKey;
			hiddenValue = Encrypt(x, y, z, w, currentCryptoKey);
			fakeValue.x = x;
			fakeValue.y = y;
			fakeValue.z = z;
			fakeValue.w = w;
			inited = true;
		}

		public static void SetNewCryptoKey(int newKey)
		{
			cryptoKey = newKey;
		}

		public static RawEncryptedQuaternion Encrypt(Quaternion value)
		{
			return Encrypt(value, 0);
		}

		public static RawEncryptedQuaternion Encrypt(Quaternion value, int key)
		{
			return Encrypt(value.x, value.y, value.z, value.w, key);
		}

		public static RawEncryptedQuaternion Encrypt(float x, float y, float z, float w, int key)
		{
			if (key == 0)
			{
				key = cryptoKey;
			}
			RawEncryptedQuaternion result = default(RawEncryptedQuaternion);
			result.x = ObscuredFloat.Encrypt(x, key);
			result.y = ObscuredFloat.Encrypt(y, key);
			result.z = ObscuredFloat.Encrypt(z, key);
			result.w = ObscuredFloat.Encrypt(w, key);
			return result;
		}

		public static Quaternion Decrypt(RawEncryptedQuaternion value)
		{
			return Decrypt(value, 0);
		}

		public static Quaternion Decrypt(RawEncryptedQuaternion value, int key)
		{
			if (key == 0)
			{
				key = cryptoKey;
			}
			Quaternion result = default(Quaternion);
			result.x = ObscuredFloat.Decrypt(value.x, key);
			result.y = ObscuredFloat.Decrypt(value.y, key);
			result.z = ObscuredFloat.Decrypt(value.z, key);
			result.w = ObscuredFloat.Decrypt(value.w, key);
			return result;
		}

		public void ApplyNewCryptoKey()
		{
			if (currentCryptoKey != cryptoKey)
			{
				hiddenValue = Encrypt(InternalDecrypt(), cryptoKey);
				currentCryptoKey = cryptoKey;
			}
		}

		public void RandomizeCryptoKey()
		{
			Quaternion value = InternalDecrypt();
			do
			{
				currentCryptoKey = UnityEngine.Random.Range(int.MinValue, int.MaxValue);
			}
			while (currentCryptoKey == 0);
			hiddenValue = Encrypt(value, currentCryptoKey);
		}

		public RawEncryptedQuaternion GetEncrypted()
		{
			ApplyNewCryptoKey();
			return hiddenValue;
		}

		public void SetEncrypted(RawEncryptedQuaternion encrypted)
		{
			inited = true;
			hiddenValue = encrypted;
			if (ObscuredCheatingDetector.IsRunning)
			{
				fakeValue = InternalDecrypt();
			}
		}

		public Quaternion GetDecrypted()
		{
			return InternalDecrypt();
		}

		private Quaternion InternalDecrypt()
		{
			if (!inited)
			{
				currentCryptoKey = cryptoKey;
				hiddenValue = Encrypt(initialFakeValue);
				fakeValue = initialFakeValue;
				inited = true;
			}
			Quaternion quaternion = default(Quaternion);
			quaternion.x = ObscuredFloat.Decrypt(hiddenValue.x, currentCryptoKey);
			quaternion.y = ObscuredFloat.Decrypt(hiddenValue.y, currentCryptoKey);
			quaternion.z = ObscuredFloat.Decrypt(hiddenValue.z, currentCryptoKey);
			quaternion.w = ObscuredFloat.Decrypt(hiddenValue.w, currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning && !fakeValue.Equals(initialFakeValue) && !CompareQuaternionsWithTolerance(quaternion, fakeValue))
			{
				ObscuredCheatingDetector.Instance.OnCheatingDetected();
			}
			return quaternion;
		}

		private bool CompareQuaternionsWithTolerance(Quaternion q1, Quaternion q2)
		{
			float quaternionEpsilon = ObscuredCheatingDetector.Instance.quaternionEpsilon;
			return Math.Abs(q1.x - q2.x) < quaternionEpsilon && Math.Abs(q1.y - q2.y) < quaternionEpsilon && Math.Abs(q1.z - q2.z) < quaternionEpsilon && Math.Abs(q1.w - q2.w) < quaternionEpsilon;
		}

		public override int GetHashCode()
		{
			return InternalDecrypt().GetHashCode();
		}

		public override string ToString()
		{
			return InternalDecrypt().ToString();
		}

		public string ToString(string format)
		{
			return InternalDecrypt().ToString(format);
		}

		public static implicit operator ObscuredQuaternion(Quaternion value)
		{
			ObscuredQuaternion result = new ObscuredQuaternion(Encrypt(value));
			if (ObscuredCheatingDetector.IsRunning)
			{
				result.fakeValue = value;
			}
			return result;
		}

		public static implicit operator Quaternion(ObscuredQuaternion value)
		{
			return value.InternalDecrypt();
		}
	}
	[Serializable]
	public struct ObscuredSByte : IEquatable<ObscuredSByte>, IFormattable
	{
		private static sbyte cryptoKey = 112;

		private sbyte currentCryptoKey;

		private sbyte hiddenValue;

		private sbyte fakeValue;

		private bool inited;

		private ObscuredSByte(sbyte value)
		{
			currentCryptoKey = cryptoKey;
			hiddenValue = value;
			fakeValue = 0;
			inited = true;
		}

		public static void SetNewCryptoKey(sbyte newKey)
		{
			cryptoKey = newKey;
		}

		public static sbyte EncryptDecrypt(sbyte value)
		{
			return EncryptDecrypt(value, 0);
		}

		public static sbyte EncryptDecrypt(sbyte value, sbyte key)
		{
			if (key == 0)
			{
				return (sbyte)(value ^ cryptoKey);
			}
			return (sbyte)(value ^ key);
		}

		public void ApplyNewCryptoKey()
		{
			if (currentCryptoKey != cryptoKey)
			{
				hiddenValue = EncryptDecrypt(InternalDecrypt(), cryptoKey);
				currentCryptoKey = cryptoKey;
			}
		}

		public void RandomizeCryptoKey()
		{
			sbyte value = InternalDecrypt();
			do
			{
				currentCryptoKey = (sbyte)UnityEngine.Random.Range(-128, 127);
			}
			while (currentCryptoKey == 0);
			hiddenValue = EncryptDecrypt(value, currentCryptoKey);
		}

		public sbyte GetEncrypted()
		{
			ApplyNewCryptoKey();
			return hiddenValue;
		}

		public void SetEncrypted(sbyte encrypted)
		{
			inited = true;
			hiddenValue = encrypted;
			if (ObscuredCheatingDetector.IsRunning)
			{
				fakeValue = InternalDecrypt();
			}
		}

		public sbyte GetDecrypted()
		{
			return InternalDecrypt();
		}

		private sbyte InternalDecrypt()
		{
			if (!inited)
			{
				currentCryptoKey = cryptoKey;
				hiddenValue = EncryptDecrypt(0);
				fakeValue = 0;
				inited = true;
			}
			sbyte b = EncryptDecrypt(hiddenValue, currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning && fakeValue != 0 && b != fakeValue)
			{
				ObscuredCheatingDetector.Instance.OnCheatingDetected();
			}
			return b;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is ObscuredSByte))
			{
				return false;
			}
			return Equals((ObscuredSByte)obj);
		}

		public bool Equals(ObscuredSByte obj)
		{
			if (currentCryptoKey == obj.currentCryptoKey)
			{
				return hiddenValue == obj.hiddenValue;
			}
			return EncryptDecrypt(hiddenValue, currentCryptoKey) == EncryptDecrypt(obj.hiddenValue, obj.currentCryptoKey);
		}

		public override string ToString()
		{
			return InternalDecrypt().ToString();
		}

		public string ToString(string format)
		{
			return InternalDecrypt().ToString(format);
		}

		public override int GetHashCode()
		{
			return InternalDecrypt().GetHashCode();
		}

		public string ToString(IFormatProvider provider)
		{
			return InternalDecrypt().ToString(provider);
		}

		public string ToString(string format, IFormatProvider provider)
		{
			return InternalDecrypt().ToString(format, provider);
		}

		public static implicit operator ObscuredSByte(sbyte value)
		{
			ObscuredSByte result = new ObscuredSByte(EncryptDecrypt(value));
			if (ObscuredCheatingDetector.IsRunning)
			{
				result.fakeValue = value;
			}
			return result;
		}

		public static implicit operator sbyte(ObscuredSByte value)
		{
			return value.InternalDecrypt();
		}

		public static ObscuredSByte operator ++(ObscuredSByte input)
		{
			sbyte value = (sbyte)(input.InternalDecrypt() + 1);
			input.hiddenValue = EncryptDecrypt(value, input.currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning)
			{
				input.fakeValue = value;
			}
			return input;
		}

		public static ObscuredSByte operator --(ObscuredSByte input)
		{
			sbyte value = (sbyte)(input.InternalDecrypt() - 1);
			input.hiddenValue = EncryptDecrypt(value, input.currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning)
			{
				input.fakeValue = value;
			}
			return input;
		}
	}
	[Serializable]
	public struct ObscuredShort : IEquatable<ObscuredShort>, IFormattable
	{
		private static short cryptoKey = 214;

		[SerializeField]
		private short currentCryptoKey;

		[SerializeField]
		private short hiddenValue;

		[SerializeField]
		private short fakeValue;

		[SerializeField]
		private bool inited;

		private ObscuredShort(short value)
		{
			currentCryptoKey = cryptoKey;
			hiddenValue = value;
			fakeValue = 0;
			inited = true;
		}

		public static void SetNewCryptoKey(short newKey)
		{
			cryptoKey = newKey;
		}

		public static short EncryptDecrypt(short value)
		{
			return EncryptDecrypt(value, 0);
		}

		public static short EncryptDecrypt(short value, short key)
		{
			if (key == 0)
			{
				return (short)(value ^ cryptoKey);
			}
			return (short)(value ^ key);
		}

		public void ApplyNewCryptoKey()
		{
			if (currentCryptoKey != cryptoKey)
			{
				hiddenValue = EncryptDecrypt(InternalDecrypt(), cryptoKey);
				currentCryptoKey = cryptoKey;
			}
		}

		public void RandomizeCryptoKey()
		{
			short value = InternalDecrypt();
			do
			{
				currentCryptoKey = (short)UnityEngine.Random.Range(-32768, 32767);
			}
			while (currentCryptoKey == 0);
			hiddenValue = EncryptDecrypt(value, currentCryptoKey);
		}

		public short GetEncrypted()
		{
			ApplyNewCryptoKey();
			return hiddenValue;
		}

		public void SetEncrypted(short encrypted)
		{
			inited = true;
			hiddenValue = encrypted;
			if (ObscuredCheatingDetector.IsRunning)
			{
				fakeValue = InternalDecrypt();
			}
		}

		public short GetDecrypted()
		{
			return InternalDecrypt();
		}

		private short InternalDecrypt()
		{
			if (!inited)
			{
				currentCryptoKey = cryptoKey;
				hiddenValue = EncryptDecrypt(0);
				fakeValue = 0;
				inited = true;
			}
			short num = EncryptDecrypt(hiddenValue, currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning && fakeValue != 0 && num != fakeValue)
			{
				ObscuredCheatingDetector.Instance.OnCheatingDetected();
			}
			return num;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is ObscuredShort))
			{
				return false;
			}
			return Equals((ObscuredShort)obj);
		}

		public bool Equals(ObscuredShort obj)
		{
			if (currentCryptoKey == obj.currentCryptoKey)
			{
				return hiddenValue == obj.hiddenValue;
			}
			return EncryptDecrypt(hiddenValue, currentCryptoKey) == EncryptDecrypt(obj.hiddenValue, obj.currentCryptoKey);
		}

		public override string ToString()
		{
			return InternalDecrypt().ToString();
		}

		public string ToString(string format)
		{
			return InternalDecrypt().ToString(format);
		}

		public override int GetHashCode()
		{
			return InternalDecrypt().GetHashCode();
		}

		public string ToString(IFormatProvider provider)
		{
			return InternalDecrypt().ToString(provider);
		}

		public string ToString(string format, IFormatProvider provider)
		{
			return InternalDecrypt().ToString(format, provider);
		}

		public static implicit operator ObscuredShort(short value)
		{
			ObscuredShort result = new ObscuredShort(EncryptDecrypt(value));
			if (ObscuredCheatingDetector.IsRunning)
			{
				result.fakeValue = value;
			}
			return result;
		}

		public static implicit operator short(ObscuredShort value)
		{
			return value.InternalDecrypt();
		}

		public static ObscuredShort operator ++(ObscuredShort input)
		{
			short value = (short)(input.InternalDecrypt() + 1);
			input.hiddenValue = EncryptDecrypt(value);
			if (ObscuredCheatingDetector.IsRunning)
			{
				input.fakeValue = value;
			}
			return input;
		}

		public static ObscuredShort operator --(ObscuredShort input)
		{
			short value = (short)(input.InternalDecrypt() - 1);
			input.hiddenValue = EncryptDecrypt(value);
			if (ObscuredCheatingDetector.IsRunning)
			{
				input.fakeValue = value;
			}
			return input;
		}
	}
	[Serializable]
	public sealed class ObscuredString
	{
		private static string cryptoKey = "4441";

		[SerializeField]
		private string currentCryptoKey;

		[SerializeField]
		private byte[] hiddenValue;

		[SerializeField]
		private string fakeValue;

		[SerializeField]
		private bool inited;

		public int Length => hiddenValue.Length / 2;

		private ObscuredString()
		{
		}

		private ObscuredString(byte[] value)
		{
			currentCryptoKey = cryptoKey;
			hiddenValue = value;
			fakeValue = null;
			inited = true;
		}

		public static void SetNewCryptoKey(string newKey)
		{
			cryptoKey = newKey;
		}

		public static string EncryptDecrypt(string value)
		{
			return EncryptDecrypt(value, string.Empty);
		}

		public static string EncryptDecrypt(string value, string key)
		{
			if (string.IsNullOrEmpty(value))
			{
				return string.Empty;
			}
			if (string.IsNullOrEmpty(key))
			{
				key = cryptoKey;
			}
			int length = key.Length;
			int length2 = value.Length;
			char[] array = new char[length2];
			for (int i = 0; i < length2; i++)
			{
				array[i] = (char)(value[i] ^ key[i % length]);
			}
			return new string(array);
		}

		public void ApplyNewCryptoKey()
		{
			if (currentCryptoKey != cryptoKey)
			{
				hiddenValue = InternalEncrypt(InternalDecrypt());
				currentCryptoKey = cryptoKey;
			}
		}

		public void RandomizeCryptoKey()
		{
			string value = InternalDecrypt();
			currentCryptoKey = UnityEngine.Random.Range(int.MinValue, int.MaxValue).ToString();
			hiddenValue = InternalEncrypt(value, currentCryptoKey);
		}

		public string GetEncrypted()
		{
			ApplyNewCryptoKey();
			return GetString(hiddenValue);
		}

		public void SetEncrypted(string encrypted)
		{
			inited = true;
			hiddenValue = GetBytes(encrypted);
			if (ObscuredCheatingDetector.IsRunning)
			{
				fakeValue = InternalDecrypt();
			}
		}

		public string GetDecrypted()
		{
			return InternalDecrypt();
		}

		private static byte[] InternalEncrypt(string value)
		{
			return InternalEncrypt(value, cryptoKey);
		}

		private static byte[] InternalEncrypt(string value, string key)
		{
			return GetBytes(EncryptDecrypt(value, key));
		}

		private string InternalDecrypt()
		{
			if (!inited)
			{
				currentCryptoKey = cryptoKey;
				hiddenValue = InternalEncrypt(string.Empty);
				fakeValue = string.Empty;
				inited = true;
			}
			string text = currentCryptoKey;
			if (string.IsNullOrEmpty(text))
			{
				text = cryptoKey;
			}
			string text2 = EncryptDecrypt(GetString(hiddenValue), text);
			if (ObscuredCheatingDetector.IsRunning && !string.IsNullOrEmpty(fakeValue) && text2 != fakeValue)
			{
				ObscuredCheatingDetector.Instance.OnCheatingDetected();
			}
			return text2;
		}

		public override string ToString()
		{
			return InternalDecrypt();
		}

		public override bool Equals(object obj)
		{
			if (!(obj is ObscuredString))
			{
				return false;
			}
			return Equals((ObscuredString)obj);
		}

		public bool Equals(ObscuredString value)
		{
			if (value == null)
			{
				return false;
			}
			if (currentCryptoKey == value.currentCryptoKey)
			{
				return ArraysEquals(hiddenValue, value.hiddenValue);
			}
			return string.Equals(InternalDecrypt(), value.InternalDecrypt());
		}

		public bool Equals(ObscuredString value, StringComparison comparisonType)
		{
			if (value == null)
			{
				return false;
			}
			return string.Equals(InternalDecrypt(), value.InternalDecrypt(), comparisonType);
		}

		public override int GetHashCode()
		{
			return InternalDecrypt().GetHashCode();
		}

		private static byte[] GetBytes(string str)
		{
			byte[] array = new byte[str.Length * 2];
			Buffer.BlockCopy(str.ToCharArray(), 0, array, 0, array.Length);
			return array;
		}

		private static string GetString(byte[] bytes)
		{
			char[] array = new char[bytes.Length / 2];
			Buffer.BlockCopy(bytes, 0, array, 0, bytes.Length);
			return new string(array);
		}

		private static bool ArraysEquals(byte[] a1, byte[] a2)
		{
			if (a1 == a2)
			{
				return true;
			}
			if (a1 != null && a2 != null)
			{
				if (a1.Length != a2.Length)
				{
					return false;
				}
				for (int i = 0; i < a1.Length; i++)
				{
					if (a1[i] != a2[i])
					{
						return false;
					}
				}
				return true;
			}
			return false;
		}

		public static implicit operator ObscuredString(string value)
		{
			if (value == null)
			{
				return null;
			}
			ObscuredString obscuredString = new ObscuredString(InternalEncrypt(value));
			if (ObscuredCheatingDetector.IsRunning)
			{
				obscuredString.fakeValue = value;
			}
			return obscuredString;
		}

		public static implicit operator string(ObscuredString value)
		{
			if (value == null)
			{
				return null;
			}
			return value.InternalDecrypt();
		}

		public static bool operator ==(ObscuredString a, ObscuredString b)
		{
			if (object.ReferenceEquals(a, b))
			{
				return true;
			}
			if ((object)a == null || (object)b == null)
			{
				return false;
			}
			if (a.currentCryptoKey == b.currentCryptoKey)
			{
				return ArraysEquals(a.hiddenValue, b.hiddenValue);
			}
			return string.Equals(a.InternalDecrypt(), b.InternalDecrypt());
		}

		public static bool operator !=(ObscuredString a, ObscuredString b)
		{
			return !(a == b);
		}
	}
	[Serializable]
	public struct ObscuredUInt : IEquatable<ObscuredUInt>, IFormattable
	{
		private static uint cryptoKey = 240513u;

		[SerializeField]
		private uint currentCryptoKey;

		[SerializeField]
		private uint hiddenValue;

		[SerializeField]
		private uint fakeValue;

		[SerializeField]
		private bool inited;

		private ObscuredUInt(uint value)
		{
			currentCryptoKey = cryptoKey;
			hiddenValue = value;
			fakeValue = 0u;
			inited = true;
		}

		public static void SetNewCryptoKey(uint newKey)
		{
			cryptoKey = newKey;
		}

		public static uint Encrypt(uint value)
		{
			return Encrypt(value, 0u);
		}

		public static uint Decrypt(uint value)
		{
			return Decrypt(value, 0u);
		}

		public static uint Encrypt(uint value, uint key)
		{
			if (key == 0)
			{
				return value ^ cryptoKey;
			}
			return value ^ key;
		}

		public static uint Decrypt(uint value, uint key)
		{
			if (key == 0)
			{
				return value ^ cryptoKey;
			}
			return value ^ key;
		}

		public void ApplyNewCryptoKey()
		{
			if (currentCryptoKey != cryptoKey)
			{
				hiddenValue = Encrypt(InternalDecrypt(), cryptoKey);
				currentCryptoKey = cryptoKey;
			}
		}

		public void RandomizeCryptoKey()
		{
			uint value = InternalDecrypt();
			currentCryptoKey = (uint)UnityEngine.Random.Range(1, int.MaxValue);
			hiddenValue = Encrypt(value, currentCryptoKey);
		}

		public uint GetEncrypted()
		{
			ApplyNewCryptoKey();
			return hiddenValue;
		}

		public void SetEncrypted(uint encrypted)
		{
			inited = true;
			hiddenValue = encrypted;
			if (ObscuredCheatingDetector.IsRunning)
			{
				fakeValue = InternalDecrypt();
			}
		}

		public uint GetDecrypted()
		{
			return InternalDecrypt();
		}

		private uint InternalDecrypt()
		{
			if (!inited)
			{
				currentCryptoKey = cryptoKey;
				hiddenValue = Encrypt(0u);
				fakeValue = 0u;
				inited = true;
			}
			uint num = Decrypt(hiddenValue, currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning && fakeValue != 0 && num != fakeValue)
			{
				ObscuredCheatingDetector.Instance.OnCheatingDetected();
			}
			return num;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is ObscuredUInt))
			{
				return false;
			}
			return Equals((ObscuredUInt)obj);
		}

		public bool Equals(ObscuredUInt obj)
		{
			if (currentCryptoKey == obj.currentCryptoKey)
			{
				return hiddenValue == obj.hiddenValue;
			}
			return Decrypt(hiddenValue, currentCryptoKey) == Decrypt(obj.hiddenValue, obj.currentCryptoKey);
		}

		public override string ToString()
		{
			return InternalDecrypt().ToString();
		}

		public string ToString(string format)
		{
			return InternalDecrypt().ToString(format);
		}

		public override int GetHashCode()
		{
			return InternalDecrypt().GetHashCode();
		}

		public string ToString(IFormatProvider provider)
		{
			return InternalDecrypt().ToString(provider);
		}

		public string ToString(string format, IFormatProvider provider)
		{
			return InternalDecrypt().ToString(format, provider);
		}

		public static implicit operator ObscuredUInt(uint value)
		{
			ObscuredUInt result = new ObscuredUInt(Encrypt(value));
			if (ObscuredCheatingDetector.IsRunning)
			{
				result.fakeValue = value;
			}
			return result;
		}

		public static implicit operator uint(ObscuredUInt value)
		{
			return value.InternalDecrypt();
		}

		public static explicit operator ObscuredInt(ObscuredUInt value)
		{
			return (int)value.InternalDecrypt();
		}

		public static ObscuredUInt operator ++(ObscuredUInt input)
		{
			uint value = input.InternalDecrypt() + 1;
			input.hiddenValue = Encrypt(value, input.currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning)
			{
				input.fakeValue = value;
			}
			return input;
		}

		public static ObscuredUInt operator --(ObscuredUInt input)
		{
			uint value = input.InternalDecrypt() - 1;
			input.hiddenValue = Encrypt(value, input.currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning)
			{
				input.fakeValue = value;
			}
			return input;
		}
	}
	[Serializable]
	public struct ObscuredULong : IEquatable<ObscuredULong>, IFormattable
	{
		private static ulong cryptoKey = 444443uL;

		[SerializeField]
		private ulong currentCryptoKey;

		[SerializeField]
		private ulong hiddenValue;

		[SerializeField]
		private ulong fakeValue;

		[SerializeField]
		private bool inited;

		private ObscuredULong(ulong value)
		{
			currentCryptoKey = cryptoKey;
			hiddenValue = value;
			fakeValue = 0uL;
			inited = true;
		}

		public static void SetNewCryptoKey(ulong newKey)
		{
			cryptoKey = newKey;
		}

		public static ulong Encrypt(ulong value)
		{
			return Encrypt(value, 0uL);
		}

		public static ulong Decrypt(ulong value)
		{
			return Decrypt(value, 0uL);
		}

		public static ulong Encrypt(ulong value, ulong key)
		{
			if (key == 0L)
			{
				return value ^ cryptoKey;
			}
			return value ^ key;
		}

		public static ulong Decrypt(ulong value, ulong key)
		{
			if (key == 0L)
			{
				return value ^ cryptoKey;
			}
			return value ^ key;
		}

		public void ApplyNewCryptoKey()
		{
			if (currentCryptoKey != cryptoKey)
			{
				hiddenValue = Encrypt(InternalDecrypt(), cryptoKey);
				currentCryptoKey = cryptoKey;
			}
		}

		public void RandomizeCryptoKey()
		{
			ulong value = InternalDecrypt();
			currentCryptoKey = (ulong)UnityEngine.Random.Range(1, int.MaxValue);
			hiddenValue = Encrypt(value, currentCryptoKey);
		}

		public ulong GetEncrypted()
		{
			ApplyNewCryptoKey();
			return hiddenValue;
		}

		public void SetEncrypted(ulong encrypted)
		{
			inited = true;
			hiddenValue = encrypted;
			if (ObscuredCheatingDetector.IsRunning)
			{
				fakeValue = InternalDecrypt();
			}
		}

		public ulong GetDecrypted()
		{
			return InternalDecrypt();
		}

		private ulong InternalDecrypt()
		{
			if (!inited)
			{
				currentCryptoKey = cryptoKey;
				hiddenValue = Encrypt(0uL);
				fakeValue = 0uL;
				inited = true;
			}
			ulong num = Decrypt(hiddenValue, currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning && fakeValue != 0L && num != fakeValue)
			{
				ObscuredCheatingDetector.Instance.OnCheatingDetected();
			}
			return num;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is ObscuredULong))
			{
				return false;
			}
			return Equals((ObscuredULong)obj);
		}

		public bool Equals(ObscuredULong obj)
		{
			if (currentCryptoKey == obj.currentCryptoKey)
			{
				return hiddenValue == obj.hiddenValue;
			}
			return Decrypt(hiddenValue, currentCryptoKey) == Decrypt(obj.hiddenValue, obj.currentCryptoKey);
		}

		public override int GetHashCode()
		{
			return InternalDecrypt().GetHashCode();
		}

		public override string ToString()
		{
			return InternalDecrypt().ToString();
		}

		public string ToString(string format)
		{
			return InternalDecrypt().ToString(format);
		}

		public string ToString(IFormatProvider provider)
		{
			return InternalDecrypt().ToString(provider);
		}

		public string ToString(string format, IFormatProvider provider)
		{
			return InternalDecrypt().ToString(format, provider);
		}

		public static implicit operator ObscuredULong(ulong value)
		{
			ObscuredULong result = new ObscuredULong(Encrypt(value));
			if (ObscuredCheatingDetector.IsRunning)
			{
				result.fakeValue = value;
			}
			return result;
		}

		public static implicit operator ulong(ObscuredULong value)
		{
			return value.InternalDecrypt();
		}

		public static ObscuredULong operator ++(ObscuredULong input)
		{
			ulong value = input.InternalDecrypt() + 1;
			input.hiddenValue = Encrypt(value, input.currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning)
			{
				input.fakeValue = value;
			}
			return input;
		}

		public static ObscuredULong operator --(ObscuredULong input)
		{
			ulong value = input.InternalDecrypt() - 1;
			input.hiddenValue = Encrypt(value, input.currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning)
			{
				input.fakeValue = value;
			}
			return input;
		}
	}
	[Serializable]
	public struct ObscuredUShort : IEquatable<ObscuredUShort>, IFormattable
	{
		private static ushort cryptoKey = 224;

		private ushort currentCryptoKey;

		private ushort hiddenValue;

		private ushort fakeValue;

		private bool inited;

		private ObscuredUShort(ushort value)
		{
			currentCryptoKey = cryptoKey;
			hiddenValue = value;
			fakeValue = 0;
			inited = true;
		}

		public static void SetNewCryptoKey(ushort newKey)
		{
			cryptoKey = newKey;
		}

		public static ushort EncryptDecrypt(ushort value)
		{
			return EncryptDecrypt(value, 0);
		}

		public static ushort EncryptDecrypt(ushort value, ushort key)
		{
			if (key == 0)
			{
				return (ushort)(value ^ cryptoKey);
			}
			return (ushort)(value ^ key);
		}

		public void ApplyNewCryptoKey()
		{
			if (currentCryptoKey != cryptoKey)
			{
				hiddenValue = EncryptDecrypt(InternalDecrypt(), cryptoKey);
				currentCryptoKey = cryptoKey;
			}
		}

		public void RandomizeCryptoKey()
		{
			ushort value = InternalDecrypt();
			currentCryptoKey = (ushort)UnityEngine.Random.Range(1, 32767);
			hiddenValue = EncryptDecrypt(value, currentCryptoKey);
		}

		public ushort GetEncrypted()
		{
			ApplyNewCryptoKey();
			return hiddenValue;
		}

		public void SetEncrypted(ushort encrypted)
		{
			inited = true;
			hiddenValue = encrypted;
			if (ObscuredCheatingDetector.IsRunning)
			{
				fakeValue = InternalDecrypt();
			}
		}

		public ushort GetDecrypted()
		{
			return InternalDecrypt();
		}

		private ushort InternalDecrypt()
		{
			if (!inited)
			{
				currentCryptoKey = cryptoKey;
				hiddenValue = EncryptDecrypt(0);
				fakeValue = 0;
				inited = true;
			}
			ushort num = EncryptDecrypt(hiddenValue, currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning && fakeValue != 0 && num != fakeValue)
			{
				ObscuredCheatingDetector.Instance.OnCheatingDetected();
			}
			return num;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is ObscuredUShort))
			{
				return false;
			}
			return Equals((ObscuredUShort)obj);
		}

		public bool Equals(ObscuredUShort obj)
		{
			if (currentCryptoKey == obj.currentCryptoKey)
			{
				return hiddenValue == obj.hiddenValue;
			}
			return EncryptDecrypt(hiddenValue, currentCryptoKey) == EncryptDecrypt(obj.hiddenValue, obj.currentCryptoKey);
		}

		public override string ToString()
		{
			return InternalDecrypt().ToString();
		}

		public string ToString(string format)
		{
			return InternalDecrypt().ToString(format);
		}

		public override int GetHashCode()
		{
			return InternalDecrypt().GetHashCode();
		}

		public string ToString(IFormatProvider provider)
		{
			return InternalDecrypt().ToString(provider);
		}

		public string ToString(string format, IFormatProvider provider)
		{
			return InternalDecrypt().ToString(format, provider);
		}

		public static implicit operator ObscuredUShort(ushort value)
		{
			ObscuredUShort result = new ObscuredUShort(EncryptDecrypt(value));
			if (ObscuredCheatingDetector.IsRunning)
			{
				result.fakeValue = value;
			}
			return result;
		}

		public static implicit operator ushort(ObscuredUShort value)
		{
			return value.InternalDecrypt();
		}

		public static ObscuredUShort operator ++(ObscuredUShort input)
		{
			ushort value = (ushort)(input.InternalDecrypt() + 1);
			input.hiddenValue = EncryptDecrypt(value, input.currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning)
			{
				input.fakeValue = value;
			}
			return input;
		}

		public static ObscuredUShort operator --(ObscuredUShort input)
		{
			ushort value = (ushort)(input.InternalDecrypt() - 1);
			input.hiddenValue = EncryptDecrypt(value, input.currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning)
			{
				input.fakeValue = value;
			}
			return input;
		}
	}
	[Serializable]
	public struct ObscuredVector2
	{
		[Serializable]
		public struct RawEncryptedVector2
		{
			public int x;

			public int y;
		}

		private static int cryptoKey = 120206;

		private static readonly Vector2 initialFakeValue = Vector2.zero;

		[SerializeField]
		private int currentCryptoKey;

		[SerializeField]
		private RawEncryptedVector2 hiddenValue;

		[SerializeField]
		private Vector2 fakeValue;

		[SerializeField]
		private bool inited;

		public float x
		{
			get
			{
				float num = InternalDecryptField(hiddenValue.x);
				if (ObscuredCheatingDetector.IsRunning && !fakeValue.Equals(initialFakeValue) && Math.Abs(num - fakeValue.x) > ObscuredCheatingDetector.Instance.vector2Epsilon)
				{
					ObscuredCheatingDetector.Instance.OnCheatingDetected();
				}
				return num;
			}
			set
			{
				hiddenValue.x = InternalEncryptField(value);
				if (ObscuredCheatingDetector.IsRunning)
				{
					fakeValue.x = value;
				}
			}
		}

		public float y
		{
			get
			{
				float num = InternalDecryptField(hiddenValue.y);
				if (ObscuredCheatingDetector.IsRunning && !fakeValue.Equals(initialFakeValue) && Math.Abs(num - fakeValue.y) > ObscuredCheatingDetector.Instance.vector2Epsilon)
				{
					ObscuredCheatingDetector.Instance.OnCheatingDetected();
				}
				return num;
			}
			set
			{
				hiddenValue.y = InternalEncryptField(value);
				if (ObscuredCheatingDetector.IsRunning)
				{
					fakeValue.y = value;
				}
			}
		}

		public float this[int index]
		{
			get
			{
				return index switch
				{
					0 => x, 
					1 => y, 
					_ => throw new IndexOutOfRangeException("Invalid ObscuredVector2 index!"), 
				};
			}
			set
			{
				switch (index)
				{
				case 0:
					x = value;
					break;
				case 1:
					y = value;
					break;
				default:
					throw new IndexOutOfRangeException("Invalid ObscuredVector2 index!");
				}
			}
		}

		private ObscuredVector2(RawEncryptedVector2 value)
		{
			currentCryptoKey = cryptoKey;
			hiddenValue = value;
			fakeValue = initialFakeValue;
			inited = true;
		}

		public ObscuredVector2(float x, float y)
		{
			currentCryptoKey = cryptoKey;
			hiddenValue = Encrypt(x, y, currentCryptoKey);
			fakeValue.x = x;
			fakeValue.y = y;
			inited = true;
		}

		public static void SetNewCryptoKey(int newKey)
		{
			cryptoKey = newKey;
		}

		public static RawEncryptedVector2 Encrypt(Vector2 value)
		{
			return Encrypt(value, 0);
		}

		public static RawEncryptedVector2 Encrypt(Vector2 value, int key)
		{
			return Encrypt(value.x, value.y, key);
		}

		public static RawEncryptedVector2 Encrypt(float x, float y, int key)
		{
			if (key == 0)
			{
				key = cryptoKey;
			}
			RawEncryptedVector2 result = default(RawEncryptedVector2);
			result.x = ObscuredFloat.Encrypt(x, key);
			result.y = ObscuredFloat.Encrypt(y, key);
			return result;
		}

		public static Vector2 Decrypt(RawEncryptedVector2 value)
		{
			return Decrypt(value, 0);
		}

		public static Vector2 Decrypt(RawEncryptedVector2 value, int key)
		{
			if (key == 0)
			{
				key = cryptoKey;
			}
			Vector2 result = default(Vector2);
			result.x = ObscuredFloat.Decrypt(value.x, key);
			result.y = ObscuredFloat.Decrypt(value.y, key);
			return result;
		}

		public void ApplyNewCryptoKey()
		{
			if (currentCryptoKey != cryptoKey)
			{
				hiddenValue = Encrypt(InternalDecrypt(), cryptoKey);
				currentCryptoKey = cryptoKey;
			}
		}

		public void RandomizeCryptoKey()
		{
			Vector2 value = InternalDecrypt();
			do
			{
				currentCryptoKey = UnityEngine.Random.Range(int.MinValue, int.MaxValue);
			}
			while (currentCryptoKey == 0);
			hiddenValue = Encrypt(value, currentCryptoKey);
		}

		public RawEncryptedVector2 GetEncrypted()
		{
			ApplyNewCryptoKey();
			return hiddenValue;
		}

		public void SetEncrypted(RawEncryptedVector2 encrypted)
		{
			inited = true;
			hiddenValue = encrypted;
			if (ObscuredCheatingDetector.IsRunning)
			{
				fakeValue = InternalDecrypt();
			}
		}

		public Vector2 GetDecrypted()
		{
			return InternalDecrypt();
		}

		private Vector2 InternalDecrypt()
		{
			if (!inited)
			{
				currentCryptoKey = cryptoKey;
				hiddenValue = Encrypt(initialFakeValue);
				fakeValue = initialFakeValue;
				inited = true;
			}
			Vector2 vector = default(Vector2);
			vector.x = ObscuredFloat.Decrypt(hiddenValue.x, currentCryptoKey);
			vector.y = ObscuredFloat.Decrypt(hiddenValue.y, currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning && !fakeValue.Equals(initialFakeValue) && !CompareVectorsWithTolerance(vector, fakeValue))
			{
				ObscuredCheatingDetector.Instance.OnCheatingDetected();
			}
			return vector;
		}

		private bool CompareVectorsWithTolerance(Vector2 vector1, Vector2 vector2)
		{
			float vector2Epsilon = ObscuredCheatingDetector.Instance.vector2Epsilon;
			return Math.Abs(vector1.x - vector2.x) < vector2Epsilon && Math.Abs(vector1.y - vector2.y) < vector2Epsilon;
		}

		private float InternalDecryptField(int encrypted)
		{
			int key = cryptoKey;
			if (currentCryptoKey != cryptoKey)
			{
				key = currentCryptoKey;
			}
			return ObscuredFloat.Decrypt(encrypted, key);
		}

		private int InternalEncryptField(float encrypted)
		{
			return ObscuredFloat.Encrypt(encrypted, cryptoKey);
		}

		public override int GetHashCode()
		{
			return InternalDecrypt().GetHashCode();
		}

		public override string ToString()
		{
			return InternalDecrypt().ToString();
		}

		public string ToString(string format)
		{
			return InternalDecrypt().ToString(format);
		}

		public static implicit operator ObscuredVector2(Vector2 value)
		{
			ObscuredVector2 result = new ObscuredVector2(Encrypt(value));
			if (ObscuredCheatingDetector.IsRunning)
			{
				result.fakeValue = value;
			}
			return result;
		}

		public static implicit operator Vector2(ObscuredVector2 value)
		{
			return value.InternalDecrypt();
		}

		public static implicit operator Vector3(ObscuredVector2 value)
		{
			Vector2 vector = value.InternalDecrypt();
			return new Vector3(vector.x, vector.y, 0f);
		}
	}
	[Serializable]
	public struct ObscuredVector3
	{
		[Serializable]
		public struct RawEncryptedVector3
		{
			public int x;

			public int y;

			public int z;
		}

		private static int cryptoKey = 120207;

		private static readonly Vector3 initialFakeValue = Vector3.zero;

		[SerializeField]
		private int currentCryptoKey;

		[SerializeField]
		private RawEncryptedVector3 hiddenValue;

		[SerializeField]
		private Vector3 fakeValue;

		[SerializeField]
		private bool inited;

		public float x
		{
			get
			{
				float num = InternalDecryptField(hiddenValue.x);
				if (ObscuredCheatingDetector.IsRunning && !fakeValue.Equals(initialFakeValue) && Math.Abs(num - fakeValue.x) > ObscuredCheatingDetector.Instance.vector3Epsilon)
				{
					ObscuredCheatingDetector.Instance.OnCheatingDetected();
				}
				return num;
			}
			set
			{
				hiddenValue.x = InternalEncryptField(value);
				if (ObscuredCheatingDetector.IsRunning)
				{
					fakeValue.x = value;
				}
			}
		}

		public float y
		{
			get
			{
				float num = InternalDecryptField(hiddenValue.y);
				if (ObscuredCheatingDetector.IsRunning && !fakeValue.Equals(initialFakeValue) && Math.Abs(num - fakeValue.y) > ObscuredCheatingDetector.Instance.vector3Epsilon)
				{
					ObscuredCheatingDetector.Instance.OnCheatingDetected();
				}
				return num;
			}
			set
			{
				hiddenValue.y = InternalEncryptField(value);
				if (ObscuredCheatingDetector.IsRunning)
				{
					fakeValue.y = value;
				}
			}
		}

		public float z
		{
			get
			{
				float num = InternalDecryptField(hiddenValue.z);
				if (ObscuredCheatingDetector.IsRunning && !fakeValue.Equals(initialFakeValue) && Math.Abs(num - fakeValue.z) > ObscuredCheatingDetector.Instance.vector3Epsilon)
				{
					ObscuredCheatingDetector.Instance.OnCheatingDetected();
				}
				return num;
			}
			set
			{
				hiddenValue.z = InternalEncryptField(value);
				if (ObscuredCheatingDetector.IsRunning)
				{
					fakeValue.z = value;
				}
			}
		}

		public float this[int index]
		{
			get
			{
				return index switch
				{
					0 => x, 
					1 => y, 
					2 => z, 
					_ => throw new IndexOutOfRangeException("Invalid ObscuredVector3 index!"), 
				};
			}
			set
			{
				switch (index)
				{
				case 0:
					x = value;
					break;
				case 1:
					y = value;
					break;
				case 2:
					z = value;
					break;
				default:
					throw new IndexOutOfRangeException("Invalid ObscuredVector3 index!");
				}
			}
		}

		private ObscuredVector3(RawEncryptedVector3 encrypted)
		{
			currentCryptoKey = cryptoKey;
			hiddenValue = encrypted;
			fakeValue = initialFakeValue;
			inited = true;
		}

		public ObscuredVector3(float x, float y, float z)
		{
			currentCryptoKey = cryptoKey;
			hiddenValue = Encrypt(x, y, z, currentCryptoKey);
			fakeValue.x = x;
			fakeValue.y = y;
			fakeValue.z = z;
			inited = true;
		}

		public static void SetNewCryptoKey(int newKey)
		{
			cryptoKey = newKey;
		}

		public static RawEncryptedVector3 Encrypt(Vector3 value)
		{
			return Encrypt(value, 0);
		}

		public static RawEncryptedVector3 Encrypt(Vector3 value, int key)
		{
			return Encrypt(value.x, value.y, value.z, key);
		}

		public static RawEncryptedVector3 Encrypt(float x, float y, float z, int key)
		{
			if (key == 0)
			{
				key = cryptoKey;
			}
			RawEncryptedVector3 result = default(RawEncryptedVector3);
			result.x = ObscuredFloat.Encrypt(x, key);
			result.y = ObscuredFloat.Encrypt(y, key);
			result.z = ObscuredFloat.Encrypt(z, key);
			return result;
		}

		public static Vector3 Decrypt(RawEncryptedVector3 value)
		{
			return Decrypt(value, 0);
		}

		public static Vector3 Decrypt(RawEncryptedVector3 value, int key)
		{
			if (key == 0)
			{
				key = cryptoKey;
			}
			Vector3 result = default(Vector3);
			result.x = ObscuredFloat.Decrypt(value.x, key);
			result.y = ObscuredFloat.Decrypt(value.y, key);
			result.z = ObscuredFloat.Decrypt(value.z, key);
			return result;
		}

		public void ApplyNewCryptoKey()
		{
			if (currentCryptoKey != cryptoKey)
			{
				hiddenValue = Encrypt(InternalDecrypt(), cryptoKey);
				currentCryptoKey = cryptoKey;
			}
		}

		public void RandomizeCryptoKey()
		{
			Vector3 value = InternalDecrypt();
			do
			{
				currentCryptoKey = UnityEngine.Random.Range(int.MinValue, int.MaxValue);
			}
			while (currentCryptoKey == 0);
			hiddenValue = Encrypt(value, currentCryptoKey);
		}

		public RawEncryptedVector3 GetEncrypted()
		{
			ApplyNewCryptoKey();
			return hiddenValue;
		}

		public void SetEncrypted(RawEncryptedVector3 encrypted)
		{
			inited = true;
			hiddenValue = encrypted;
			if (ObscuredCheatingDetector.IsRunning)
			{
				fakeValue = InternalDecrypt();
			}
		}

		public Vector3 GetDecrypted()
		{
			return InternalDecrypt();
		}

		private Vector3 InternalDecrypt()
		{
			if (!inited)
			{
				currentCryptoKey = cryptoKey;
				hiddenValue = Encrypt(initialFakeValue, cryptoKey);
				fakeValue = initialFakeValue;
				inited = true;
			}
			Vector3 vector = default(Vector3);
			vector.x = ObscuredFloat.Decrypt(hiddenValue.x, currentCryptoKey);
			vector.y = ObscuredFloat.Decrypt(hiddenValue.y, currentCryptoKey);
			vector.z = ObscuredFloat.Decrypt(hiddenValue.z, currentCryptoKey);
			if (ObscuredCheatingDetector.IsRunning && !fakeValue.Equals(Vector3.zero) && !CompareVectorsWithTolerance(vector, fakeValue))
			{
				ObscuredCheatingDetector.Instance.OnCheatingDetected();
			}
			return vector;
		}

		private bool CompareVectorsWithTolerance(Vector3 vector1, Vector3 vector2)
		{
			float vector3Epsilon = ObscuredCheatingDetector.Instance.vector3Epsilon;
			return Math.Abs(vector1.x - vector2.x) < vector3Epsilon && Math.Abs(vector1.y - vector2.y) < vector3Epsilon && Math.Abs(vector1.z - vector2.z) < vector3Epsilon;
		}

		private float InternalDecryptField(int encrypted)
		{
			int key = cryptoKey;
			if (currentCryptoKey != cryptoKey)
			{
				key = currentCryptoKey;
			}
			return ObscuredFloat.Decrypt(encrypted, key);
		}

		private int InternalEncryptField(float encrypted)
		{
			return ObscuredFloat.Encrypt(encrypted, cryptoKey);
		}

		public override bool Equals(object other)
		{
			return InternalDecrypt().Equals(other);
		}

		public override int GetHashCode()
		{
			return InternalDecrypt().GetHashCode();
		}

		public override string ToString()
		{
			return InternalDecrypt().ToString();
		}

		public string ToString(string format)
		{
			return InternalDecrypt().ToString(format);
		}

		public static implicit operator ObscuredVector3(Vector3 value)
		{
			ObscuredVector3 result = new ObscuredVector3(Encrypt(value, cryptoKey));
			if (ObscuredCheatingDetector.IsRunning)
			{
				result.fakeValue = value;
			}
			return result;
		}

		public static implicit operator Vector3(ObscuredVector3 value)
		{
			return value.InternalDecrypt();
		}

		public static ObscuredVector3 operator +(ObscuredVector3 a, ObscuredVector3 b)
		{
			return a.InternalDecrypt() + b.InternalDecrypt();
		}

		public static ObscuredVector3 operator +(Vector3 a, ObscuredVector3 b)
		{
			return a + b.InternalDecrypt();
		}

		public static ObscuredVector3 operator +(ObscuredVector3 a, Vector3 b)
		{
			return a.InternalDecrypt() + b;
		}

		public static ObscuredVector3 operator -(ObscuredVector3 a, ObscuredVector3 b)
		{
			return a.InternalDecrypt() - b.InternalDecrypt();
		}

		public static ObscuredVector3 operator -(Vector3 a, ObscuredVector3 b)
		{
			return a - b.InternalDecrypt();
		}

		public static ObscuredVector3 operator -(ObscuredVector3 a, Vector3 b)
		{
			return a.InternalDecrypt() - b;
		}

		public static ObscuredVector3 operator -(ObscuredVector3 a)
		{
			return -a.InternalDecrypt();
		}

		public static ObscuredVector3 operator *(ObscuredVector3 a, float d)
		{
			return a.InternalDecrypt() * d;
		}

		public static ObscuredVector3 operator *(float d, ObscuredVector3 a)
		{
			return d * a.InternalDecrypt();
		}

		public static ObscuredVector3 operator /(ObscuredVector3 a, float d)
		{
			return a.InternalDecrypt() / d;
		}

		public static bool operator ==(ObscuredVector3 lhs, ObscuredVector3 rhs)
		{
			return lhs.InternalDecrypt() == rhs.InternalDecrypt();
		}

		public static bool operator ==(Vector3 lhs, ObscuredVector3 rhs)
		{
			return lhs == rhs.InternalDecrypt();
		}

		public static bool operator ==(ObscuredVector3 lhs, Vector3 rhs)
		{
			return lhs.InternalDecrypt() == rhs;
		}

		public static bool operator !=(ObscuredVector3 lhs, ObscuredVector3 rhs)
		{
			return lhs.InternalDecrypt() != rhs.InternalDecrypt();
		}

		public static bool operator !=(Vector3 lhs, ObscuredVector3 rhs)
		{
			return lhs != rhs.InternalDecrypt();
		}

		public static bool operator !=(ObscuredVector3 lhs, Vector3 rhs)
		{
			return lhs.InternalDecrypt() != rhs;
		}
	}
}
namespace CodeStage.AntiCheat.Utils
{
	internal class xxHash
	{
		private const uint PRIME32_1 = 2654435761u;

		private const uint PRIME32_2 = 2246822519u;

		private const uint PRIME32_3 = 3266489917u;

		private const uint PRIME32_4 = 668265263u;

		private const uint PRIME32_5 = 374761393u;

		public static uint CalculateHash(byte[] buf, int len, uint seed)
		{
			int i = 0;
			uint num7;
			if (len >= 16)
			{
				int num = len - 16;
				uint num2 = (uint)((int)seed + -1640531535 + -2048144777);
				uint num3 = seed + 2246822519u;
				uint num4 = seed;
				uint num5 = seed - 2654435761u;
				do
				{
					uint num6 = (uint)(buf[i++] | (buf[i++] << 8) | (buf[i++] << 16) | (buf[i++] << 24));
					num2 += (uint)((int)num6 * -2048144777);
					num2 = (num2 << 13) | (num2 >> 19);
					num2 *= 2654435761u;
					num6 = (uint)(buf[i++] | (buf[i++] << 8) | (buf[i++] << 16) | (buf[i++] << 24));
					num3 += (uint)((int)num6 * -2048144777);
					num3 = (num3 << 13) | (num3 >> 19);
					num3 *= 2654435761u;
					num6 = (uint)(buf[i++] | (buf[i++] << 8) | (buf[i++] << 16) | (buf[i++] << 24));
					num4 += (uint)((int)num6 * -2048144777);
					num4 = (num4 << 13) | (num4 >> 19);
					num4 *= 2654435761u;
					num6 = (uint)(buf[i++] | (buf[i++] << 8) | (buf[i++] << 16) | (buf[i++] << 24));
					num5 += (uint)((int)num6 * -2048144777);
					num5 = (num5 << 13) | (num5 >> 19);
					num5 *= 2654435761u;
				}
				while (i <= num);
				num7 = ((num2 << 1) | (num2 >> 31)) + ((num3 << 7) | (num3 >> 25)) + ((num4 << 12) | (num4 >> 20)) + ((num5 << 18) | (num5 >> 14));
			}
			else
			{
				num7 = seed + 374761393;
			}
			num7 += (uint)len;
			while (i <= len - 4)
			{
				num7 += (uint)((buf[i++] | (buf[i++] << 8) | (buf[i++] << 16) | (buf[i++] << 24)) * -1028477379);
				num7 = ((num7 << 17) | (num7 >> 15)) * 668265263;
			}
			for (; i < len; i++)
			{
				num7 += (uint)(buf[i] * 374761393);
				num7 = ((num7 << 11) | (num7 >> 21)) * 2654435761u;
			}
			num7 ^= num7 >> 15;
			num7 *= 2246822519u;
			num7 ^= num7 >> 13;
			num7 *= 3266489917u;
			return num7 ^ (num7 >> 16);
		}
	}
}
namespace UnityStandardAssets.CinematicEffects
{
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Anti-aliasing")]
	[ImageEffectAllowedInSceneView]
	[RequireComponent(typeof(Camera))]
	public class AntiAliasing : MonoBehaviour
	{
		public enum Method
		{
			Smaa,
			Fxaa
		}

		[SerializeField]
		private SMAA m_SMAA = new SMAA();

		[SerializeField]
		private FXAA m_FXAA = new FXAA();

		[SerializeField]
		[HideInInspector]
		private int m_Method;

		private Camera m_Camera;

		public int method
		{
			get
			{
				return m_Method;
			}
			set
			{
				if (m_Method != value)
				{
					m_Method = value;
				}
			}
		}

		public IAntiAliasing current
		{
			get
			{
				if (method == 0)
				{
					return m_SMAA;
				}
				return m_FXAA;
			}
		}

		public Camera cameraComponent
		{
			get
			{
				if (m_Camera == null)
				{
					m_Camera = GetComponent<Camera>();
				}
				return m_Camera;
			}
		}

		private void OnEnable()
		{
			m_SMAA.OnEnable(this);
			m_FXAA.OnEnable(this);
		}

		private void OnDisable()
		{
			m_SMAA.OnDisable();
			m_FXAA.OnDisable();
		}

		private void OnPreCull()
		{
			current.OnPreCull(cameraComponent);
		}

		private void OnPostRender()
		{
			current.OnPostRender(cameraComponent);
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			current.OnRenderImage(cameraComponent, source, destination);
		}
	}
	[Serializable]
	public class FXAA : IAntiAliasing
	{
		[Serializable]
		public struct QualitySettings
		{
			[Tooltip("The amount of desired sub-pixel aliasing removal. Effects the sharpeness of the output.")]
			[Range(0f, 1f)]
			public float subpixelAliasingRemovalAmount;

			[Range(0.063f, 0.333f)]
			[Tooltip("The minimum amount of local contrast required to qualify a region as containing an edge.")]
			public float edgeDetectionThreshold;

			[Range(0f, 0.0833f)]
			[Tooltip("Local contrast adaptation value to disallow the algorithm from executing on the darker regions.")]
			public float minimumRequiredLuminance;
		}

		[Serializable]
		public struct ConsoleSettings
		{
			[Range(0.33f, 0.5f)]
			[Tooltip("The amount of spread applied to the sampling coordinates while sampling for subpixel information.")]
			public float subpixelSpreadAmount;

			[Range(2f, 8f)]
			[Tooltip("This value dictates how sharp the edges in the image are kept; a higher value implies sharper edges.")]
			public float edgeSharpnessAmount;

			[Range(0.125f, 0.25f)]
			[Tooltip("The minimum amount of local contrast required to qualify a region as containing an edge.")]
			public float edgeDetectionThreshold;

			[Tooltip("Local contrast adaptation value to disallow the algorithm from executing on the darker regions.")]
			[Range(0.04f, 0.06f)]
			public float minimumRequiredLuminance;
		}

		[Serializable]
		public struct Preset
		{
			[AttributeUsage(AttributeTargets.Field)]
			public class LayoutAttribute : PropertyAttribute
			{
			}

			[Layout]
			public QualitySettings qualitySettings;

			[Layout]
			public ConsoleSettings consoleSettings;

			private static readonly Preset s_ExtremePerformance = new Preset
			{
				qualitySettings = new QualitySettings
				{
					subpixelAliasingRemovalAmount = 0f,
					edgeDetectionThreshold = 0.333f,
					minimumRequiredLuminance = 0.0833f
				},
				consoleSettings = new ConsoleSettings
				{
					subpixelSpreadAmount = 0.33f,
					edgeSharpnessAmount = 8f,
					edgeDetectionThreshold = 0.25f,
					minimumRequiredLuminance = 0.06f
				}
			};

			private static readonly Preset s_Performance = new Preset
			{
				qualitySettings = new QualitySettings
				{
					subpixelAliasingRemovalAmount = 0.25f,
					edgeDetectionThreshold = 0.25f,
					minimumRequiredLuminance = 0.0833f
				},
				consoleSettings = new ConsoleSettings
				{
					subpixelSpreadAmount = 0.33f,
					edgeSharpnessAmount = 8f,
					edgeDetectionThreshold = 0.125f,
					minimumRequiredLuminance = 0.06f
				}
			};

			private static readonly Preset s_Default = new Preset
			{
				qualitySettings = new QualitySettings
				{
					subpixelAliasingRemovalAmount = 0.75f,
					edgeDetectionThreshold = 0.166f,
					minimumRequiredLuminance = 0.0833f
				},
				consoleSettings = new ConsoleSettings
				{
					subpixelSpreadAmount = 0.5f,
					edgeSharpnessAmount = 8f,
					edgeDetectionThreshold = 0.125f,
					minimumRequiredLuminance = 0.05f
				}
			};

			private static readonly Preset s_Quality = new Preset
			{
				qualitySettings = new QualitySettings
				{
					subpixelAliasingRemovalAmount = 1f,
					edgeDetectionThreshold = 0.125f,
					minimumRequiredLuminance = 0.0625f
				},
				consoleSettings = new ConsoleSettings
				{
					subpixelSpreadAmount = 0.5f,
					edgeSharpnessAmount = 4f,
					edgeDetectionThreshold = 0.125f,
					minimumRequiredLuminance = 0.04f
				}
			};

			private static readonly Preset s_ExtremeQuality = new Preset
			{
				qualitySettings = new QualitySettings
				{
					subpixelAliasingRemovalAmount = 1f,
					edgeDetectionThreshold = 0.063f,
					minimumRequiredLuminance = 0.0312f
				},
				consoleSettings = new ConsoleSettings
				{
					subpixelSpreadAmount = 0.5f,
					edgeSharpnessAmount = 2f,
					edgeDetectionThreshold = 0.125f,
					minimumRequiredLuminance = 0.04f
				}
			};

			public static Preset extremePerformancePreset => s_ExtremePerformance;

			public static Preset performancePreset => s_Performance;

			public static Preset defaultPreset => s_Default;

			public static Preset qualityPreset => s_Quality;

			public static Preset extremeQualityPreset => s_ExtremeQuality;
		}

		private Shader m_Shader;

		private Material m_Material;

		[SerializeField]
		[HideInInspector]
		public Preset preset = Preset.defaultPreset;

		public static Preset[] availablePresets = new Preset[5]
		{
			Preset.extremePerformancePreset,
			Preset.performancePreset,
			Preset.defaultPreset,
			Preset.qualityPreset,
			Preset.extremeQualityPreset
		};

		private Shader shader
		{
			get
			{
				if (m_Shader == null)
				{
					m_Shader = Shader.Find("Hidden/Fast Approximate Anti-aliasing");
				}
				return m_Shader;
			}
		}

		public Material material
		{
			get
			{
				if (m_Material == null)
				{
					m_Material = ImageEffectHelper.CheckShaderAndCreateMaterial(shader);
				}
				return m_Material;
			}
		}

		public bool validSourceFormat { get; private set; }

		public void OnEnable(AntiAliasing owner)
		{
			if (!ImageEffectHelper.IsSupported(shader, needDepth: true, needHdr: false, owner))
			{
				owner.enabled = false;
			}
		}

		public void OnDisable()
		{
			if (m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(m_Material);
			}
		}

		public void OnPreCull(Camera camera)
		{
		}

		public void OnPostRender(Camera camera)
		{
		}

		public void OnRenderImage(Camera camera, RenderTexture source, RenderTexture destination)
		{
			material.SetVector("_QualitySettings", new Vector3(preset.qualitySettings.subpixelAliasingRemovalAmount, preset.qualitySettings.edgeDetectionThreshold, preset.qualitySettings.minimumRequiredLuminance));
			material.SetVector("_ConsoleSettings", new Vector4(preset.consoleSettings.subpixelSpreadAmount, preset.consoleSettings.edgeSharpnessAmount, preset.consoleSettings.edgeDetectionThreshold, preset.consoleSettings.minimumRequiredLuminance));
			Graphics.Blit(source, destination, material, 0);
		}
	}
	public interface IAntiAliasing
	{
		void OnEnable(AntiAliasing owner);

		void OnDisable();

		void OnPreCull(Camera camera);

		void OnPostRender(Camera camera);

		void OnRenderImage(Camera camera, RenderTexture source, RenderTexture destination);
	}
	[Serializable]
	public class SMAA : IAntiAliasing
	{
		[AttributeUsage(AttributeTargets.Field)]
		public class SettingsGroup : Attribute
		{
		}

		[AttributeUsage(AttributeTargets.Field)]
		public class TopLevelSettings : Attribute
		{
		}

		[AttributeUsage(AttributeTargets.Field)]
		public class ExperimentalGroup : Attribute
		{
		}

		public enum DebugPass
		{
			Off,
			Edges,
			Weights,
			Accumulation
		}

		public enum QualityPreset
		{
			Low,
			Medium,
			High,
			Ultra,
			Custom
		}

		public enum EdgeDetectionMethod
		{
			Luma = 1,
			Color,
			Depth
		}

		[Serializable]
		public struct GlobalSettings
		{
			[Tooltip("Use this to fine tune your settings when working in Custom quality mode. \"Accumulation\" only works when \"Temporal Filtering\" is enabled.")]
			public DebugPass debugPass;

			[Tooltip("Low: 60% of the quality.\nMedium: 80% of the quality.\nHigh: 95% of the quality.\nUltra: 99% of the quality (overkill).")]
			public QualityPreset quality;

			[Tooltip("You've three edge detection methods to choose from: luma, color or depth.\nThey represent different quality/performance and anti-aliasing/sharpness tradeoffs, so our recommendation is for you to choose the one that best suits your particular scenario:\n\n- Depth edge detection is usually the fastest but it may miss some edges.\n- Luma edge detection is usually more expensive than depth edge detection, but catches visible edges that depth edge detection can miss.\n- Color edge detection is usually the most expensive one but catches chroma-only edges.")]
			public EdgeDetectionMethod edgeDetectionMethod;

			public static GlobalSettings defaultSettings => new GlobalSettings
			{
				debugPass = DebugPass.Off,
				quality = QualityPreset.High,
				edgeDetectionMethod = EdgeDetectionMethod.Color
			};
		}

		[Serializable]
		public struct QualitySettings
		{
			[Tooltip("Enables/Disables diagonal processing.")]
			public bool diagonalDetection;

			[Tooltip("Enables/Disables corner detection. Leave this on to avoid blurry corners.")]
			public bool cornerDetection;

			[Tooltip("Specifies the threshold or sensitivity to edges. Lowering this value you will be able to detect more edges at the expense of performance.\n0.1 is a reasonable value, and allows to catch most visible edges. 0.05 is a rather overkill value, that allows to catch 'em all.")]
			[Range(0f, 0.5f)]
			public float threshold;

			[Tooltip("Specifies the threshold for depth edge detection. Lowering this value you will be able to detect more edges at the expense of performance.")]
			[Min(0.0001f)]
			public float depthThreshold;

			[Range(0f, 112f)]
			[Tooltip("Specifies the maximum steps performed in the horizontal/vertical pattern searches, at each side of the pixel.\nIn number of pixels, it's actually the double. So the maximum line length perfectly handled by, for example 16, is 64 (by perfectly, we meant that longer lines won't look as good, but still antialiased).")]
			public int maxSearchSteps;

			[Tooltip("Specifies the maximum steps performed in the diagonal pattern searches, at each side of the pixel. In this case we jump one pixel at time, instead of two.\nOn high-end machines it is cheap (between a 0.8x and 0.9x slower for 16 steps), but it can have a significant impact on older machines.")]
			[Range(0f, 20f)]
			public int maxDiagonalSearchSteps;

			[Range(0f, 100f)]
			[Tooltip("Specifies how much sharp corners will be rounded.")]
			public int cornerRounding;

			[Tooltip("If there is an neighbor edge that has a local contrast factor times bigger contrast than current edge, current edge will be discarded.\nThis allows to eliminate spurious crossing edges, and is based on the fact that, if there is too much contrast in a direction, that will hide perceptually contrast in the other neighbors.")]
			[Min(0f)]
			public float localContrastAdaptationFactor;

			public static QualitySettings[] presetQualitySettings = new QualitySettings[4]
			{
				new QualitySettings
				{
					diagonalDetection = false,
					cornerDetection = false,
					threshold = 0.15f,
					depthThreshold = 0.01f,
					maxSearchSteps = 4,
					maxDiagonalSearchSteps = 8,
					cornerRounding = 25,
					localContrastAdaptationFactor = 2f
				},
				new QualitySettings
				{
					diagonalDetection = false,
					cornerDetection = false,
					threshold = 0.1f,
					depthThreshold = 0.01f,
					maxSearchSteps = 8,
					maxDiagonalSearchSteps = 8,
					cornerRounding = 25,
					localContrastAdaptationFactor = 2f
				},
				new QualitySettings
				{
					diagonalDetection = true,
					cornerDetection = true,
					threshold = 0.1f,
					depthThreshold = 0.01f,
					maxSearchSteps = 16,
					maxDiagonalSearchSteps = 8,
					cornerRounding = 25,
					localContrastAdaptationFactor = 2f
				},
				new QualitySettings
				{
					diagonalDetection = true,
					cornerDetection = true,
					threshold = 0.05f,
					depthThreshold = 0.01f,
					maxSearchSteps = 32,
					maxDiagonalSearchSteps = 16,
					cornerRounding = 25,
					localContrastAdaptationFactor = 2f
				}
			};
		}

		[Serializable]
		public struct TemporalSettings
		{
			[Tooltip("Temporal filtering makes it possible for the SMAA algorithm to benefit from minute subpixel information available that has been accumulated over many frames.")]
			public bool enabled;

			[Range(0.5f, 10f)]
			[Tooltip("The size of the fuzz-displacement (jitter) in pixels applied to the camera's perspective projection matrix.\nUsed for 2x temporal anti-aliasing.")]
			public float fuzzSize;

			public static TemporalSettings defaultSettings => new TemporalSettings
			{
				enabled = false,
				fuzzSize = 2f
			};

			public bool UseTemporal()
			{
				return enabled;
			}
		}

		[Serializable]
		public struct PredicationSettings
		{
			[Tooltip("Predicated thresholding allows to better preserve texture details and to improve performance, by decreasing the number of detected edges using an additional buffer (the detph buffer).\nIt locally decreases the luma or color threshold if an edge is found in an additional buffer (so the global threshold can be higher).")]
			public bool enabled;

			[Tooltip("Threshold to be used in the additional predication buffer.")]
			[Min(0.0001f)]
			public float threshold;

			[Range(1f, 5f)]
			[Tooltip("How much to scale the global threshold used for luma or color edge detection when using predication.")]
			public float scale;

			[Range(0f, 1f)]
			[Tooltip("How much to locally decrease the threshold.")]
			public float strength;

			public static PredicationSettings defaultSettings => new PredicationSettings
			{
				enabled = false,
				threshold = 0.01f,
				scale = 2f,
				strength = 0.4f
			};
		}

		[TopLevelSettings]
		public GlobalSettings settings = GlobalSettings.defaultSettings;

		[SettingsGroup]
		public QualitySettings quality = QualitySettings.presetQualitySettings[2];

		[SettingsGroup]
		public PredicationSettings predication = PredicationSettings.defaultSettings;

		[ExperimentalGroup]
		[SettingsGroup]
		public TemporalSettings temporal = TemporalSettings.defaultSettings;

		private Matrix4x4 m_ProjectionMatrix;

		private Matrix4x4 m_PreviousViewProjectionMatrix;

		private float m_FlipFlop = 1f;

		private RenderTexture m_Accumulation;

		private Shader m_Shader;

		private Texture2D m_AreaTexture;

		private Texture2D m_SearchTexture;

		private Material m_Material;

		public Shader shader
		{
			get
			{
				if (m_Shader == null)
				{
					m_Shader = Shader.Find("Hidden/Subpixel Morphological Anti-aliasing");
				}
				return m_Shader;
			}
		}

		private Texture2D areaTexture
		{
			get
			{
				if (m_AreaTexture == null)
				{
					m_AreaTexture = Resources.Load<Texture2D>("AreaTex");
				}
				return m_AreaTexture;
			}
		}

		private Texture2D searchTexture
		{
			get
			{
				if (m_SearchTexture == null)
				{
					m_SearchTexture = Resources.Load<Texture2D>("SearchTex");
				}
				return m_SearchTexture;
			}
		}

		private Material material
		{
			get
			{
				if (m_Material == null)
				{
					m_Material = ImageEffectHelper.CheckShaderAndCreateMaterial(shader);
				}
				return m_Material;
			}
		}

		public void OnEnable(AntiAliasing owner)
		{
			if (!ImageEffectHelper.IsSupported(shader, needDepth: true, needHdr: false, owner))
			{
				owner.enabled = false;
			}
		}

		public void OnDisable()
		{
			if (m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(m_Material);
			}
			if (m_Accumulation != null)
			{
				UnityEngine.Object.DestroyImmediate(m_Accumulation);
			}
			m_Material = null;
			m_Accumulation = null;
		}

		public void OnPreCull(Camera camera)
		{
			if (temporal.UseTemporal())
			{
				m_ProjectionMatrix = camera.projectionMatrix;
				m_FlipFlop -= 2f * m_FlipFlop;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.m03 = 0.25f * m_FlipFlop * temporal.fuzzSize / (float)camera.pixelWidth;
				identity.m13 = -0.25f * m_FlipFlop * temporal.fuzzSize / (float)camera.pixelHeight;
				camera.projectionMatrix = identity * camera.projectionMatrix;
			}
		}

		public void OnPostRender(Camera camera)
		{
			if (temporal.UseTemporal())
			{
				camera.ResetProjectionMatrix();
			}
		}

		public void OnRenderImage(Camera camera, RenderTexture source, RenderTexture destination)
		{
			int pixelWidth = camera.pixelWidth;
			int pixelHeight = camera.pixelHeight;
			bool flag = false;
			QualitySettings qualitySettings = quality;
			if (settings.quality != QualityPreset.Custom)
			{
				qualitySettings = QualitySettings.presetQualitySettings[(int)settings.quality];
			}
			int edgeDetectionMethod = (int)settings.edgeDetectionMethod;
			int pass = 4;
			int pass2 = 5;
			int pass3 = 6;
			Matrix4x4 matrix4x = GL.GetGPUProjectionMatrix(m_ProjectionMatrix, renderIntoTexture: true) * camera.worldToCameraMatrix;
			material.SetTexture("_AreaTex", areaTexture);
			material.SetTexture("_SearchTex", searchTexture);
			material.SetVector("_Metrics", new Vector4(1f / (float)pixelWidth, 1f / (float)pixelHeight, pixelWidth, pixelHeight));
			material.SetVector("_Params1", new Vector4(qualitySettings.threshold, qualitySettings.depthThreshold, qualitySettings.maxSearchSteps, qualitySettings.maxDiagonalSearchSteps));
			material.SetVector("_Params2", new Vector2(qualitySettings.cornerRounding, qualitySettings.localContrastAdaptationFactor));
			material.SetMatrix("_ReprojectionMatrix", m_PreviousViewProjectionMatrix * Matrix4x4.Inverse(matrix4x));
			float num = ((!(m_FlipFlop < 0f)) ? 1f : 2f);
			material.SetVector("_SubsampleIndices", new Vector4(num, num, num, 0f));
			Shader.DisableKeyword("USE_PREDICATION");
			if (settings.edgeDetectionMethod == EdgeDetectionMethod.Depth)
			{
				camera.depthTextureMode |= DepthTextureMode.Depth;
			}
			else if (predication.enabled)
			{
				camera.depthTextureMode |= DepthTextureMode.Depth;
				Shader.EnableKeyword("USE_PREDICATION");
				material.SetVector("_Params3", new Vector3(predication.threshold, predication.scale, predication.strength));
			}
			Shader.DisableKeyword("USE_DIAG_SEARCH");
			Shader.DisableKeyword("USE_CORNER_DETECTION");
			if (qualitySettings.diagonalDetection)
			{
				Shader.EnableKeyword("USE_DIAG_SEARCH");
			}
			if (qualitySettings.cornerDetection)
			{
				Shader.EnableKeyword("USE_CORNER_DETECTION");
			}
			Shader.DisableKeyword("USE_UV_BASED_REPROJECTION");
			if (temporal.UseTemporal())
			{
				Shader.EnableKeyword("USE_UV_BASED_REPROJECTION");
			}
			if (m_Accumulation == null || m_Accumulation.width != pixelWidth || m_Accumulation.height != pixelHeight)
			{
				if ((bool)m_Accumulation)
				{
					RenderTexture.ReleaseTemporary(m_Accumulation);
				}
				m_Accumulation = RenderTexture.GetTemporary(pixelWidth, pixelHeight, 0, source.format, RenderTextureReadWrite.Linear);
				m_Accumulation.hideFlags = HideFlags.HideAndDontSave;
				flag = true;
			}
			RenderTexture renderTexture = TempRT(pixelWidth, pixelHeight, source.format);
			Graphics.Blit(null, renderTexture, material, 0);
			Graphics.Blit(source, renderTexture, material, edgeDetectionMethod);
			if (settings.debugPass == DebugPass.Edges)
			{
				Graphics.Blit(renderTexture, destination);
			}
			else
			{
				RenderTexture renderTexture2 = TempRT(pixelWidth, pixelHeight, source.format);
				Graphics.Blit(null, renderTexture2, material, 0);
				Graphics.Blit(renderTexture, renderTexture2, material, pass);
				if (settings.debugPass == DebugPass.Weights)
				{
					Graphics.Blit(renderTexture2, destination);
				}
				else
				{
					material.SetTexture("_BlendTex", renderTexture2);
					if (temporal.UseTemporal())
					{
						Graphics.Blit(source, renderTexture, material, pass2);
						if (settings.debugPass == DebugPass.Accumulation)
						{
							Graphics.Blit(m_Accumulation, destination);
						}
						else if (!flag)
						{
							material.SetTexture("_AccumulationTex", m_Accumulation);
							Graphics.Blit(renderTexture, destination, material, pass3);
						}
						else
						{
							Graphics.Blit(renderTexture, destination);
						}
						Graphics.Blit(destination, m_Accumulation);
						RenderTexture.active = null;
					}
					else
					{
						Graphics.Blit(source, destination, material, pass2);
					}
				}
				RenderTexture.ReleaseTemporary(renderTexture2);
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			m_PreviousViewProjectionMatrix = matrix4x;
		}

		private RenderTexture TempRT(int width, int height, RenderTextureFormat format)
		{
			int depthBuffer = 0;
			return RenderTexture.GetTemporary(width, height, depthBuffer, format, RenderTextureReadWrite.Linear);
		}
	}
	[RequireComponent(typeof(Camera))]
	[ImageEffectAllowedInSceneView]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Cinematic/Ambient Occlusion")]
	public class AmbientOcclusion : MonoBehaviour
	{
		private struct PropertyObserver
		{
			private bool _downsampling;

			private OcclusionSource _occlusionSource;

			private bool _ambientOnly;

			private int _pixelWidth;

			private int _pixelHeight;

			public bool CheckNeedsReset(Settings setting, Camera camera)
			{
				return _downsampling != setting.downsampling || _occlusionSource != setting.occlusionSource || _ambientOnly != setting.ambientOnly || _pixelWidth != camera.pixelWidth || _pixelHeight != camera.pixelHeight;
			}

			public void Update(Settings setting, Camera camera)
			{
				_downsampling = setting.downsampling;
				_occlusionSource = setting.occlusionSource;
				_ambientOnly = setting.ambientOnly;
				_pixelWidth = camera.pixelWidth;
				_pixelHeight = camera.pixelHeight;
			}
		}

		public enum SampleCount
		{
			Lowest,
			Low,
			Medium,
			High,
			Variable
		}

		public enum OcclusionSource
		{
			DepthTexture,
			DepthNormalsTexture,
			GBuffer
		}

		[Serializable]
		public class Settings
		{
			[Range(0f, 4f)]
			[Tooltip("Degree of darkness produced by the effect.")]
			[SerializeField]
			public float intensity;

			[SerializeField]
			[Tooltip("Radius of sample points, which affects extent of darkened areas.")]
			public float radius;

			[SerializeField]
			[Tooltip("Number of sample points, which affects quality and performance.")]
			public SampleCount sampleCount;

			[Tooltip("Determines the sample count when SampleCount.Variable is used.")]
			[SerializeField]
			public int sampleCountValue;

			[SerializeField]
			[Tooltip("Halves the resolution of the effect to increase performance.")]
			public bool downsampling;

			[SerializeField]
			[Tooltip("If checked, the effect only affects ambient lighting.")]
			public bool ambientOnly;

			[Tooltip("Source buffer on which the occlusion estimator is based.")]
			[SerializeField]
			public OcclusionSource occlusionSource;

			[SerializeField]
			public bool debug;

			public static Settings defaultSettings
			{
				get
				{
					Settings settings = new Settings();
					settings.intensity = 1f;
					settings.radius = 0.3f;
					settings.sampleCount = SampleCount.Medium;
					settings.sampleCountValue = 24;
					settings.downsampling = false;
					settings.ambientOnly = false;
					settings.occlusionSource = OcclusionSource.DepthNormalsTexture;
					return settings;
				}
			}
		}

		[SerializeField]
		public Settings settings = Settings.defaultSettings;

		[SerializeField]
		private Shader _aoShader;

		private Material _aoMaterial;

		private CommandBuffer _aoCommands;

		[SerializeField]
		private Mesh _quadMesh;

		public bool isAmbientOnlySupported => targetCamera.hdr && occlusionSource == OcclusionSource.GBuffer;

		public bool isGBufferAvailable => targetCamera.actualRenderingPath == RenderingPath.DeferredShading;

		private float intensity => settings.intensity;

		private float radius => Mathf.Max(settings.radius, 0.0001f);

		private SampleCount sampleCount => settings.sampleCount;

		private int sampleCountValue => settings.sampleCount switch
		{
			SampleCount.Lowest => 3, 
			SampleCount.Low => 6, 
			SampleCount.Medium => 12, 
			SampleCount.High => 20, 
			_ => Mathf.Clamp(settings.sampleCountValue, 1, 256), 
		};

		private OcclusionSource occlusionSource
		{
			get
			{
				if (settings.occlusionSource == OcclusionSource.GBuffer && !isGBufferAvailable)
				{
					return OcclusionSource.DepthNormalsTexture;
				}
				return settings.occlusionSource;
			}
		}

		private bool downsampling => settings.downsampling;

		private bool ambientOnly => settings.ambientOnly && isAmbientOnlySupported;

		private Shader aoShader
		{
			get
			{
				if (_aoShader == null)
				{
					_aoShader = Shader.Find("Hidden/Image Effects/Cinematic/AmbientOcclusion");
				}
				return _aoShader;
			}
		}

		private Material aoMaterial
		{
			get
			{
				if (_aoMaterial == null)
				{
					_aoMaterial = ImageEffectHelper.CheckShaderAndCreateMaterial(aoShader);
				}
				return _aoMaterial;
			}
		}

		private CommandBuffer aoCommands
		{
			get
			{
				if (_aoCommands == null)
				{
					_aoCommands = new CommandBuffer();
					_aoCommands.name = "AmbientOcclusion";
				}
				return _aoCommands;
			}
		}

		private Camera targetCamera => GetComponent<Camera>();

		private PropertyObserver propertyObserver { get; set; }

		private Mesh quadMesh => _quadMesh;

		private void BuildAOCommands()
		{
			CommandBuffer commandBuffer = aoCommands;
			int pixelWidth = targetCamera.pixelWidth;
			int pixelHeight = targetCamera.pixelHeight;
			int num = ((!downsampling) ? 1 : 2);
			RenderTextureFormat format = RenderTextureFormat.R8;
			RenderTextureReadWrite readWrite = RenderTextureReadWrite.Linear;
			FilterMode filter = FilterMode.Bilinear;
			Material material = aoMaterial;
			int num2 = Shader.PropertyToID("_OcclusionTexture");
			commandBuffer.GetTemporaryRT(num2, pixelWidth / num, pixelHeight / num, 0, filter, format, readWrite);
			commandBuffer.Blit((Texture)null, (RenderTargetIdentifier)num2, material, 0);
			int num3 = Shader.PropertyToID("_OcclusionBlurTexture");
			commandBuffer.GetTemporaryRT(num3, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("_BlurVector", Vector2.right * 2f);
			commandBuffer.Blit(num2, num3, material, 1);
			commandBuffer.ReleaseTemporaryRT(num2);
			commandBuffer.GetTemporaryRT(num2, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("_BlurVector", Vector2.up * 2f * num);
			commandBuffer.Blit(num3, num2, material, 1);
			commandBuffer.ReleaseTemporaryRT(num3);
			commandBuffer.GetTemporaryRT(num3, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("_BlurVector", Vector2.right * num);
			commandBuffer.Blit(num2, num3, material, 2);
			commandBuffer.ReleaseTemporaryRT(num2);
			commandBuffer.GetTemporaryRT(num2, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("_BlurVector", Vector2.up * num);
			commandBuffer.Blit(num3, num2, material, 2);
			commandBuffer.ReleaseTemporaryRT(num3);
			RenderTargetIdentifier[] colors = new RenderTargetIdentifier[2]
			{
				BuiltinRenderTextureType.GBuffer0,
				BuiltinRenderTextureType.CameraTarget
			};
			commandBuffer.SetRenderTarget(colors, BuiltinRenderTextureType.CameraTarget);
			commandBuffer.SetGlobalTexture("_OcclusionTexture", num2);
			commandBuffer.DrawMesh(quadMesh, Matrix4x4.identity, material, 0, 4);
			commandBuffer.ReleaseTemporaryRT(num2);
		}

		private void ExecuteAOPass(RenderTexture source, RenderTexture destination)
		{
			int width = source.width;
			int height = source.height;
			int num = ((!downsampling) ? 1 : 2);
			RenderTextureFormat format = RenderTextureFormat.R8;
			RenderTextureReadWrite readWrite = RenderTextureReadWrite.Linear;
			Material material = aoMaterial;
			RenderTexture temporary = RenderTexture.GetTemporary(width / num, height / num, 0, format, readWrite);
			Graphics.Blit(null, temporary, material, 0);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector("_BlurVector", Vector2.right * 2f);
			Graphics.Blit(temporary, temporary2, material, 1);
			RenderTexture.ReleaseTemporary(temporary);
			temporary = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector("_BlurVector", Vector2.up * 2f * num);
			Graphics.Blit(temporary2, temporary, material, 1);
			RenderTexture.ReleaseTemporary(temporary2);
			temporary2 = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector("_BlurVector", Vector2.right * num);
			Graphics.Blit(temporary, temporary2, material, 2);
			RenderTexture.ReleaseTemporary(temporary);
			temporary = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector("_BlurVector", Vector2.up * num);
			Graphics.Blit(temporary2, temporary, material, 2);
			RenderTexture.ReleaseTemporary(temporary2);
			material.SetTexture("_OcclusionTexture", temporary);
			if (!settings.debug)
			{
				Graphics.Blit(source, destination, material, 3);
			}
			else
			{
				Graphics.Blit(source, destination, material, 5);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		private void UpdateMaterialProperties()
		{
			Material material = aoMaterial;
			material.shaderKeywords = null;
			material.SetFloat("_Intensity", intensity);
			material.SetFloat("_Radius", radius);
			material.SetFloat("_TargetScale", (!downsampling) ? 1f : 0.5f);
			if (occlusionSource == OcclusionSource.GBuffer)
			{
				material.EnableKeyword("_SOURCE_GBUFFER");
			}
			else if (occlusionSource == OcclusionSource.DepthTexture)
			{
				material.EnableKeyword("_SOURCE_DEPTH");
			}
			else
			{
				material.EnableKeyword("_SOURCE_DEPTHNORMALS");
			}
			if (sampleCount == SampleCount.Lowest)
			{
				material.EnableKeyword("_SAMPLECOUNT_LOWEST");
			}
			else
			{
				material.SetInt("_SampleCount", sampleCountValue);
			}
		}

		private void OnEnable()
		{
			if (!ImageEffectHelper.IsSupported(aoShader, needDepth: true, needHdr: false, this))
			{
				base.enabled = false;
				return;
			}
			if (ambientOnly)
			{
				targetCamera.AddCommandBuffer(CameraEvent.BeforeReflections, aoCommands);
			}
			if (occlusionSource == OcclusionSource.DepthTexture)
			{
				targetCamera.depthTextureMode |= DepthTextureMode.Depth;
			}
			if (occlusionSource != OcclusionSource.GBuffer)
			{
				targetCamera.depthTextureMode |= DepthTextureMode.DepthNormals;
			}
		}

		private void OnDisable()
		{
			if (_aoMaterial != null)
			{
				UnityEngine.Object.DestroyImmediate(_aoMaterial);
			}
			_aoMaterial = null;
			if (_aoCommands != null)
			{
				targetCamera.RemoveCommandBuffer(CameraEvent.BeforeReflections, _aoCommands);
			}
			_aoCommands = null;
		}

		private void Update()
		{
			if (propertyObserver.CheckNeedsReset(settings, targetCamera))
			{
				OnDisable();
				OnEnable();
				if (ambientOnly)
				{
					aoCommands.Clear();
					BuildAOCommands();
				}
				propertyObserver.Update(settings, targetCamera);
			}
			if (ambientOnly)
			{
				UpdateMaterialProperties();
			}
		}

		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (ambientOnly)
			{
				Graphics.Blit(source, destination);
				return;
			}
			UpdateMaterialProperties();
			ExecuteAOPass(source, destination);
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Cinematic/Bloom")]
	[RequireComponent(typeof(Camera))]
	[ImageEffectAllowedInSceneView]
	public class Bloom : MonoBehaviour
	{
		[Serializable]
		public struct Settings
		{
			[Tooltip("Filters out pixels under this level of brightness.")]
			[SerializeField]
			public float threshold;

			[Range(1f, 7f)]
			[Tooltip("Changes extent of veiling effects in a screen resolution-independent fashion.")]
			[SerializeField]
			public float radius;

			[SerializeField]
			[Tooltip("Blend factor of the result image.")]
			public float intensity;

			[Tooltip("Controls filter quality and buffer resolution.")]
			[SerializeField]
			public bool highQuality;

			[Tooltip("Reduces flashing noise with an additional filter.")]
			[SerializeField]
			public bool antiFlicker;

			public float thresholdGamma
			{
				get
				{
					return Mathf.Max(0f, threshold);
				}
				set
				{
					threshold = value;
				}
			}

			public float thresholdLinear
			{
				get
				{
					return Mathf.GammaToLinearSpace(thresholdGamma);
				}
				set
				{
					threshold = Mathf.LinearToGammaSpace(value);
				}
			}

			public static Settings defaultSettings => new Settings
			{
				threshold = 0.9f,
				radius = 2f,
				intensity = 0.7f,
				highQuality = true,
				antiFlicker = false
			};
		}

		private const int kMaxIterations = 16;

		[SerializeField]
		public Settings settings = Settings.defaultSettings;

		[SerializeField]
		[HideInInspector]
		private Shader m_Shader;

		private Material m_Material;

		private RenderTexture[] m_blurBuffer1 = new RenderTexture[16];

		private RenderTexture[] m_blurBuffer2 = new RenderTexture[16];

		public Shader shader
		{
			get
			{
				if (m_Shader == null)
				{
					m_Shader = Shader.Find("Hidden/Image Effects/Cinematic/Bloom");
				}
				return m_Shader;
			}
		}

		public Material material
		{
			get
			{
				if (m_Material == null)
				{
					m_Material = ImageEffectHelper.CheckShaderAndCreateMaterial(shader);
				}
				return m_Material;
			}
		}

		private void OnEnable()
		{
			if (!ImageEffectHelper.IsSupported(shader, needDepth: true, needHdr: false, this))
			{
				base.enabled = false;
			}
		}

		private void OnDisable()
		{
			if (m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(m_Material);
			}
			m_Material = null;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = source.width;
			int num2 = source.height;
			if (!settings.highQuality)
			{
				num /= 2;
				num2 /= 2;
			}
			RenderTextureFormat format = ((!isMobilePlatform) ? RenderTextureFormat.DefaultHDR : RenderTextureFormat.Default);
			float num3 = Mathf.Log(num2, 2f) + settings.radius - 8f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 1, 16);
			float thresholdLinear = settings.thresholdLinear;
			material.SetFloat("_Threshold", thresholdLinear);
			float num6 = thresholdLinear * 0.5f + 1E-05f;
			Vector3 vector = new Vector3(thresholdLinear - num6, num6 * 2f, 0.25f / num6);
			material.SetVector("_Curve", vector);
			bool flag = !settings.highQuality && settings.antiFlicker;
			material.SetFloat("_PrefilterOffs", (!flag) ? 0f : (-0.5f));
			material.SetFloat("_SampleScale", 0.5f + num3 - (float)num4);
			material.SetFloat("_Intensity", Mathf.Max(0f, settings.intensity));
			if (settings.highQuality)
			{
				material.EnableKeyword("HIGH_QUALITY");
			}
			else
			{
				material.DisableKeyword("HIGH_QUALITY");
			}
			if (settings.antiFlicker)
			{
				material.EnableKeyword("ANTI_FLICKER");
			}
			else
			{
				material.DisableKeyword("ANTI_FLICKER");
			}
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, format);
			Graphics.Blit(source, temporary, material, 0);
			RenderTexture renderTexture = temporary;
			for (int i = 0; i < num5; i++)
			{
				m_blurBuffer1[i] = RenderTexture.GetTemporary(renderTexture.width / 2, renderTexture.height / 2, 0, format);
				Graphics.Blit(renderTexture, m_blurBuffer1[i], material, (i == 0) ? 1 : 2);
				renderTexture = m_blurBuffer1[i];
			}
			for (int num7 = num5 - 2; num7 >= 0; num7--)
			{
				RenderTexture renderTexture2 = m_blurBuffer1[num7];
				material.SetTexture("_BaseTex", renderTexture2);
				m_blurBuffer2[num7] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 0, format);
				Graphics.Blit(renderTexture, m_blurBuffer2[num7], material, 3);
				renderTexture = m_blurBuffer2[num7];
			}
			material.SetTexture("_BaseTex", source);
			Graphics.Blit(renderTexture, destination, material, 4);
			for (int j = 0; j < 16; j++)
			{
				if (m_blurBuffer1[j] != null)
				{
					RenderTexture.ReleaseTemporary(m_blurBuffer1[j]);
				}
				if (m_blurBuffer2[j] != null)
				{
					RenderTexture.ReleaseTemporary(m_blurBuffer2[j]);
				}
				m_blurBuffer1[j] = null;
				m_blurBuffer2[j] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}
	}
	public static class ImageEffectHelper
	{
		public static bool supportsDX11 => SystemInfo.graphicsShaderLevel >= 50 && SystemInfo.supportsComputeShaders;

		public static bool IsSupported(Shader s, bool needDepth, bool needHdr, MonoBehaviour effect)
		{
			if (s == null || !s.isSupported)
			{
				UnityEngine.Debug.LogWarningFormat("Missing shader for image effect {0}", effect);
				return false;
			}
			if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
			{
				UnityEngine.Debug.LogWarningFormat("Image effects aren't supported on this device ({0})", effect);
				return false;
			}
			if (needDepth && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				UnityEngine.Debug.LogWarningFormat("Depth textures aren't supported on this device ({0})", effect);
				return false;
			}
			if (needHdr && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf))
			{
				UnityEngine.Debug.LogWarningFormat("Floating point textures aren't supported on this device ({0})", effect);
				return false;
			}
			return true;
		}

		public static Material CheckShaderAndCreateMaterial(Shader s)
		{
			if (s == null || !s.isSupported)
			{
				return null;
			}
			Material material = new Material(s);
			material.hideFlags = HideFlags.DontSave;
			return material;
		}
	}
	public sealed class MinAttribute : PropertyAttribute
	{
		public readonly float min;

		public MinAttribute(float min)
		{
			this.min = min;
		}
	}
	public class RenderTextureUtility
	{
		private List<RenderTexture> m_TemporaryRTs = new List<RenderTexture>();

		public RenderTexture GetTemporaryRenderTexture(int width, int height, int depthBuffer = 0, RenderTextureFormat format = RenderTextureFormat.ARGBHalf, FilterMode filterMode = FilterMode.Bilinear)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, depthBuffer, format);
			temporary.filterMode = filterMode;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary.name = "RenderTextureUtilityTempTexture";
			m_TemporaryRTs.Add(temporary);
			return temporary;
		}

		public void ReleaseTemporaryRenderTexture(RenderTexture rt)
		{
			if (!(rt == null))
			{
				if (!m_TemporaryRTs.Contains(rt))
				{
					UnityEngine.Debug.LogErrorFormat("Attempting to remove texture that was not allocated: {0}", rt);
				}
				else
				{
					m_TemporaryRTs.Remove(rt);
					RenderTexture.ReleaseTemporary(rt);
				}
			}
		}

		public void ReleaseAllTemporaryRenderTextures()
		{
			for (int i = 0; i < m_TemporaryRTs.Count; i++)
			{
				RenderTexture.ReleaseTemporary(m_TemporaryRTs[i]);
			}
			m_TemporaryRTs.Clear();
		}
	}
	[AddComponentMenu("Image Effects/Cinematic/Depth Of Field")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class DepthOfField : MonoBehaviour
	{
		private enum Passes
		{
			BlurAlphaWeighted,
			BoxBlur,
			DilateFgCocFromColor,
			DilateFgCoc,
			CaptureCoc,
			CaptureCocExplicit,
			VisualizeCoc,
			VisualizeCocExplicit,
			CocPrefilter,
			CircleBlur,
			CircleBlurWithDilatedFg,
			CircleBlurLowQuality,
			CircleBlowLowQualityWithDilatedFg,
			Merge,
			MergeExplicit,
			MergeBicubic,
			MergeExplicitBicubic,
			ShapeLowQuality,
			ShapeLowQualityDilateFg,
			ShapeLowQualityMerge,
			ShapeLowQualityMergeDilateFg,
			ShapeMediumQuality,
			ShapeMediumQualityDilateFg,
			ShapeMediumQualityMerge,
			ShapeMediumQualityMergeDilateFg,
			ShapeHighQuality,
			ShapeHighQualityDilateFg,
			ShapeHighQualityMerge,
			ShapeHighQualityMergeDilateFg
		}

		private enum MedianPasses
		{
			Median3,
			Median3X3
		}

		private enum BokehTexturesPasses
		{
			Apply,
			Collect
		}

		public enum TweakMode
		{
			Basic,
			Advanced,
			Explicit
		}

		public enum ApertureShape
		{
			Circular,
			Hexagonal,
			Octogonal
		}

		public enum QualityPreset
		{
			Simple,
			Low,
			Medium,
			High,
			VeryHigh,
			Ultra,
			Custom
		}

		public enum FilterQuality
		{
			None,
			Normal,
			High
		}

		[AttributeUsage(AttributeTargets.Field)]
		public class TopLevelSettings : Attribute
		{
		}

		[AttributeUsage(AttributeTargets.Field)]
		public class SettingsGroup : Attribute
		{
		}

		[AttributeUsage(AttributeTargets.Field)]
		public class AllTweakModes : Attribute
		{
		}

		[AttributeUsage(AttributeTargets.Field)]
		public class Basic : Attribute
		{
		}

		[AttributeUsage(AttributeTargets.Field)]
		public class Advanced : Attribute
		{
		}

		[AttributeUsage(AttributeTargets.Field)]
		public class Explicit : Attribute
		{
		}

		[Serializable]
		public struct GlobalSettings
		{
			[Tooltip("Allows to view where the blur will be applied. Yellow for near blur, blue for far blur.")]
			public bool visualizeBluriness;

			[Tooltip("Setup mode. Use \"Advanced\" if you need more control on blur settings and/or want to use a bokeh texture. \"Explicit\" is the same as \"Advanced\" but makes use of \"Near Plane\" and \"Far Plane\" values instead of \"F-Stop\".")]
			public TweakMode tweakMode;

			[Tooltip("Quality presets. Use \"Custom\" for more advanced settings.")]
			public QualityPreset quality;

			[Tooltip("\"Circular\" is the fastest, followed by \"Hexagonal\" and \"Octogonal\".")]
			[Space]
			public ApertureShape apertureShape;

			[Tooltip("Rotates the aperture when working with \"Hexagonal\" and \"Ortogonal\".")]
			[Range(0f, 179f)]
			public float apertureOrientation;

			public static GlobalSettings defaultSettings => new GlobalSettings
			{
				visualizeBluriness = false,
				tweakMode = TweakMode.Basic,
				quality = QualityPreset.High,
				apertureShape = ApertureShape.Circular,
				apertureOrientation = 0f
			};
		}

		[Serializable]
		public struct QualitySettings
		{
			[Tooltip("Enable this to get smooth bokeh.")]
			public bool prefilterBlur;

			[Tooltip("Applies a median filter for even smoother bokeh.")]
			public FilterQuality medianFilter;

			[Tooltip("Dilates near blur over in focus area.")]
			public bool dilateNearBlur;

			[Tooltip("Uses high quality upsampling.")]
			public bool highQualityUpsampling;

			[Tooltip("Prevent haloing from bright in focus region over dark out of focus region.")]
			public bool preventHaloing;

			public static QualitySettings[] presetQualitySettings = new QualitySettings[6]
			{
				new QualitySettings
				{
					prefilterBlur = false,
					medianFilter = FilterQuality.None,
					dilateNearBlur = false,
					highQualityUpsampling = false,
					preventHaloing = false
				},
				new QualitySettings
				{
					prefilterBlur = true,
					medianFilter = FilterQuality.None,
					dilateNearBlur = false,
					highQualityUpsampling = false,
					preventHaloing = false
				},
				new QualitySettings
				{
					prefilterBlur = true,
					medianFilter = FilterQuality.Normal,
					dilateNearBlur = false,
					highQualityUpsampling = false,
					preventHaloing = false
				},
				new QualitySettings
				{
					prefilterBlur = true,
					medianFilter = FilterQuality.Normal,
					dilateNearBlur = true,
					highQualityUpsampling = false,
					preventHaloing = false
				},
				new QualitySettings
				{
					prefilterBlur = true,
					medianFilter = FilterQuality.High,
					dilateNearBlur = true,
					highQualityUpsampling = false,
					preventHaloing = true
				},
				new QualitySettings
				{
					prefilterBlur = true,
					medianFilter = FilterQuality.High,
					dilateNearBlur = true,
					highQualityUpsampling = true,
					preventHaloing = true
				}
			};
		}

		[Serializable]
		public struct FocusSettings
		{
			[Tooltip("Auto-focus on a selected transform.")]
			[Basic]
			[Explicit]
			[Advanced]
			public Transform transform;

			[Advanced]
			[Range(0f, 1f)]
			[Basic]
			[Tooltip("Focus distance.")]
			[Explicit]
			public float plane;

			[Explicit]
			[Tooltip("Near focus distance.")]
			[Range(0f, 1f)]
			public float nearPlane;

			[Range(0f, 1f)]
			[Tooltip("Far focus distance.")]
			[Explicit]
			public float farPlane;

			[Basic]
			[Advanced]
			[Range(0f, 32f)]
			[Tooltip("Simulates focal ratio. Lower values will result in a narrow depth of field.")]
			public float fStops;

			[Advanced]
			[Explicit]
			[Range(0f, 1f)]
			[Tooltip("Focus range/spread. Use this to fine-tune the F-Stop range.")]
			[Basic]
			public float rangeAdjustment;

			public static FocusSettings defaultSettings => new FocusSettings
			{
				transform = null,
				plane = 0.225f,
				nearPlane = 0f,
				farPlane = 1f,
				fStops = 5f,
				rangeAdjustment = 0.9f
			};
		}

		[Serializable]
		public struct BokehTextureSettings
		{
			[Explicit]
			[Tooltip("Adding a texture to this field will enable the use of \"Bokeh Textures\". Use with care. This feature is only available on Shader Model 5 compatible-hardware and performance scale with the amount of bokeh.")]
			[Advanced]
			public Texture2D texture;

			[Advanced]
			[Explicit]
			[Range(0.01f, 5f)]
			[Tooltip("Maximum size of bokeh textures on screen.")]
			public float scale;

			[Explicit]
			[Range(0.01f, 100f)]
			[Tooltip("Bokeh brightness.")]
			[Advanced]
			public float intensity;

			[Explicit]
			[Range(0.01f, 50f)]
			[Tooltip("Controls the amount of bokeh textures. Lower values mean more bokeh splats.")]
			[Advanced]
			public float threshold;

			[Advanced]
			[Explicit]
			[Range(0.01f, 1f)]
			[Tooltip("Controls the spawn conditions. Lower values mean more visible bokeh.")]
			public float spawnHeuristic;

			public static BokehTextureSettings defaultSettings => new BokehTextureSettings
			{
				texture = null,
				scale = 1f,
				intensity = 50f,
				threshold = 2f,
				spawnHeuristic = 0.15f
			};
		}

		[Serializable]
		public struct BlurSettings
		{
			[Advanced]
			[Explicit]
			[Range(0f, 35f)]
			[Tooltip("Maximum blur radius for the near plane.")]
			[Basic]
			public float nearRadius;

			[Basic]
			[Explicit]
			[Range(0f, 35f)]
			[Tooltip("Maximum blur radius for the far plane.")]
			[Advanced]
			public float farRadius;

			[Tooltip("Blur luminosity booster threshold for the near and far boost amounts.")]
			[Advanced]
			[Explicit]
			[Range(0.5f, 4f)]
			public float boostPoint;

			[Range(0f, 1f)]
			[Explicit]
			[Advanced]
			[Tooltip("Boosts luminosity in the near blur.")]
			public float nearBoostAmount;

			[Advanced]
			[Explicit]
			[Range(0f, 1f)]
			[Tooltip("Boosts luminosity in the far blur.")]
			public float farBoostAmount;

			public static BlurSettings defaultSettings => new BlurSettings
			{
				nearRadius = 20f,
				farRadius = 20f,
				boostPoint = 0.75f,
				nearBoostAmount = 0f,
				farBoostAmount = 0f
			};
		}

		private const float kMaxBlur = 35f;

		[TopLevelSettings]
		public GlobalSettings settings = GlobalSettings.defaultSettings;

		[SettingsGroup]
		[AllTweakModes]
		public QualitySettings quality = QualitySettings.presetQualitySettings[3];

		[SettingsGroup]
		public FocusSettings focus = FocusSettings.defaultSettings;

		[SettingsGroup]
		public BokehTextureSettings bokehTexture = BokehTextureSettings.defaultSettings;

		[SettingsGroup]
		public BlurSettings blur = BlurSettings.defaultSettings;

		[SerializeField]
		private Shader m_FilmicDepthOfFieldShader;

		[SerializeField]
		private Shader m_MedianFilterShader;

		[SerializeField]
		private Shader m_TextureBokehShader;

		private RenderTextureUtility m_RTU = new RenderTextureUtility();

		private Material m_FilmicDepthOfFieldMaterial;

		private Material m_MedianFilterMaterial;

		private Material m_TextureBokehMaterial;

		private ComputeBuffer m_ComputeBufferDrawArgs;

		private ComputeBuffer m_ComputeBufferPoints;

		private QualitySettings m_CurrentQualitySettings;

		private float m_LastApertureOrientation;

		private Vector4 m_OctogonalBokehDirection1;

		private Vector4 m_OctogonalBokehDirection2;

		private Vector4 m_OctogonalBokehDirection3;

		private Vector4 m_OctogonalBokehDirection4;

		private Vector4 m_HexagonalBokehDirection1;

		private Vector4 m_HexagonalBokehDirection2;

		private Vector4 m_HexagonalBokehDirection3;

		public Shader filmicDepthOfFieldShader
		{
			get
			{
				if (m_FilmicDepthOfFieldShader == null)
				{
					m_FilmicDepthOfFieldShader = Shader.Find("Hidden/DepthOfField/DepthOfField");
				}
				return m_FilmicDepthOfFieldShader;
			}
		}

		public Shader medianFilterShader
		{
			get
			{
				if (m_MedianFilterShader == null)
				{
					m_MedianFilterShader = Shader.Find("Hidden/DepthOfField/MedianFilter");
				}
				return m_MedianFilterShader;
			}
		}

		public Shader textureBokehShader
		{
			get
			{
				if (m_TextureBokehShader == null)
				{
					m_TextureBokehShader = Shader.Find("Hidden/DepthOfField/BokehSplatting");
				}
				return m_TextureBokehShader;
			}
		}

		public Material filmicDepthOfFieldMaterial
		{
			get
			{
				if (m_FilmicDepthOfFieldMaterial == null)
				{
					m_FilmicDepthOfFieldMaterial = ImageEffectHelper.CheckShaderAndCreateMaterial(filmicDepthOfFieldShader);
				}
				return m_FilmicDepthOfFieldMaterial;
			}
		}

		public Material medianFilterMaterial
		{
			get
			{
				if (m_MedianFilterMaterial == null)
				{
					m_MedianFilterMaterial = ImageEffectHelper.CheckShaderAndCreateMaterial(medianFilterShader);
				}
				return m_MedianFilterMaterial;
			}
		}

		public Material textureBokehMaterial
		{
			get
			{
				if (m_TextureBokehMaterial == null)
				{
					m_TextureBokehMaterial = ImageEffectHelper.CheckShaderAndCreateMaterial(textureBokehShader);
				}
				return m_TextureBokehMaterial;
			}
		}

		public ComputeBuffer computeBufferDrawArgs
		{
			get
			{
				if (m_ComputeBufferDrawArgs == null)
				{
					m_ComputeBufferDrawArgs = new ComputeBuffer(1, 16, ComputeBufferType.DrawIndirect);
					m_ComputeBufferDrawArgs.SetData(new int[4] { 0, 1, 0, 0 });
				}
				return m_ComputeBufferDrawArgs;
			}
		}

		public ComputeBuffer computeBufferPoints
		{
			get
			{
				if (m_ComputeBufferPoints == null)
				{
					m_ComputeBufferPoints = new ComputeBuffer(90000, 28, ComputeBufferType.Append);
				}
				return m_ComputeBufferPoints;
			}
		}

		private bool shouldPerformBokeh => ImageEffectHelper.supportsDX11 && bokehTexture.texture != null && (bool)textureBokehMaterial && settings.tweakMode != TweakMode.Basic;

		private void OnEnable()
		{
			if (!ImageEffectHelper.IsSupported(filmicDepthOfFieldShader, needDepth: true, needHdr: true, this) || !ImageEffectHelper.IsSupported(medianFilterShader, needDepth: true, needHdr: true, this))
			{
				base.enabled = false;
				return;
			}
			if (ImageEffectHelper.supportsDX11 && !ImageEffectHelper.IsSupported(textureBokehShader, needDepth: true, needHdr: true, this))
			{
				base.enabled = false;
				return;
			}
			ComputeBlurDirections(force: true);
			GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
		}

		private void OnDisable()
		{
			ReleaseComputeResources();
			if (m_FilmicDepthOfFieldMaterial != null)
			{
				UnityEngine.Object.DestroyImmediate(m_FilmicDepthOfFieldMaterial);
			}
			if (m_TextureBokehMaterial != null)
			{
				UnityEngine.Object.DestroyImmediate(m_TextureBokehMaterial);
			}
			if (m_MedianFilterMaterial != null)
			{
				UnityEngine.Object.DestroyImmediate(m_MedianFilterMaterial);
			}
			m_FilmicDepthOfFieldMaterial = null;
			m_TextureBokehMaterial = null;
			m_MedianFilterMaterial = null;
			m_RTU.ReleaseAllTemporaryRenderTextures();
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (medianFilterMaterial == null || filmicDepthOfFieldMaterial == null)
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (settings.visualizeBluriness)
			{
				ComputeCocParameters(out var blurParams, out var blurCoe);
				filmicDepthOfFieldMaterial.SetVector("_BlurParams", blurParams);
				filmicDepthOfFieldMaterial.SetVector("_BlurCoe", blurCoe);
				Graphics.Blit(null, destination, filmicDepthOfFieldMaterial, (settings.tweakMode != TweakMode.Explicit) ? 6 : 7);
			}
			else
			{
				DoDepthOfField(source, destination);
			}
			m_RTU.ReleaseAllTemporaryRenderTextures();
		}

		private void DoDepthOfField(RenderTexture source, RenderTexture destination)
		{
			m_CurrentQualitySettings = quality;
			if (settings.quality != QualityPreset.Custom)
			{
				m_CurrentQualitySettings = QualitySettings.presetQualitySettings[(int)settings.quality];
			}
			float num = (float)source.height / 720f;
			float num2 = num;
			float num3 = Mathf.Max(blur.nearRadius, blur.farRadius) * num2 * 0.75f;
			float num4 = blur.nearRadius * num;
			float num5 = blur.farRadius * num;
			float num6 = Mathf.Max(num4, num5);
			switch (settings.apertureShape)
			{
			case ApertureShape.Hexagonal:
				num6 *= 1.2f;
				break;
			case ApertureShape.Octogonal:
				num6 *= 1.15f;
				break;
			}
			if (num6 < 0.5f)
			{
				Graphics.Blit(source, destination);
				return;
			}
			int width = source.width / 2;
			int height = source.height / 2;
			Vector4 vector = new Vector4(num4 * 0.5f, num5 * 0.5f, 0f, 0f);
			RenderTexture temporaryRenderTexture = m_RTU.GetTemporaryRenderTexture(width, height);
			RenderTexture temporaryRenderTexture2 = m_RTU.GetTemporaryRenderTexture(width, height);
			if (m_CurrentQualitySettings.preventHaloing)
			{
				filmicDepthOfFieldMaterial.EnableKeyword("USE_SPECIAL_FETCH_FOR_COC");
			}
			else
			{
				filmicDepthOfFieldMaterial.DisableKeyword("USE_SPECIAL_FETCH_FOR_COC");
			}
			ComputeCocParameters(out var blurParams, out var blurCoe);
			filmicDepthOfFieldMaterial.SetVector("_BlurParams", blurParams);
			filmicDepthOfFieldMaterial.SetVector("_BlurCoe", blurCoe);
			filmicDepthOfFieldMaterial.SetVector("_BoostParams", new Vector4(num4 * blur.nearBoostAmount * -0.5f, num5 * blur.farBoostAmount * 0.5f, blur.boostPoint, 0f));
			Graphics.Blit(source, temporaryRenderTexture2, filmicDepthOfFieldMaterial, (settings.tweakMode != TweakMode.Explicit) ? 4 : 5);
			RenderTexture src = temporaryRenderTexture2;
			RenderTexture dst = temporaryRenderTexture;
			if (shouldPerformBokeh)
			{
				RenderTexture temporaryRenderTexture3 = m_RTU.GetTemporaryRenderTexture(width, height);
				Graphics.Blit(src, temporaryRenderTexture3, filmicDepthOfFieldMaterial, 1);
				filmicDepthOfFieldMaterial.SetVector("_Offsets", new Vector4(0f, 1.5f, 0f, 1.5f));
				Graphics.Blit(temporaryRenderTexture3, dst, filmicDepthOfFieldMaterial, 0);
				filmicDepthOfFieldMaterial.SetVector("_Offsets", new Vector4(1.5f, 0f, 0f, 1.5f));
				Graphics.Blit(dst, temporaryRenderTexture3, filmicDepthOfFieldMaterial, 0);
				textureBokehMaterial.SetTexture("_BlurredColor", temporaryRenderTexture3);
				textureBokehMaterial.SetFloat("_SpawnHeuristic", bokehTexture.spawnHeuristic);
				textureBokehMaterial.SetVector("_BokehParams", new Vector4(bokehTexture.scale * num2, bokehTexture.intensity, bokehTexture.threshold, num3));
				Graphics.SetRandomWriteTarget(1, computeBufferPoints);
				Graphics.Blit(src, dst, textureBokehMaterial, 1);
				Graphics.ClearRandomWriteTargets();
				SwapRenderTexture(ref src, ref dst);
				m_RTU.ReleaseTemporaryRenderTexture(temporaryRenderTexture3);
			}
			filmicDepthOfFieldMaterial.SetVector("_BlurParams", blurParams);
			filmicDepthOfFieldMaterial.SetVector("_BlurCoe", vector);
			filmicDepthOfFieldMaterial.SetVector("_BoostParams", new Vector4(num4 * blur.nearBoostAmount * -0.5f, num5 * blur.farBoostAmount * 0.5f, blur.boostPoint, 0f));
			RenderTexture renderTexture = null;
			if (m_CurrentQualitySettings.dilateNearBlur)
			{
				RenderTexture temporaryRenderTexture4 = m_RTU.GetTemporaryRenderTexture(width, height, 0, RenderTextureFormat.RGHalf);
				renderTexture = m_RTU.GetTemporaryRenderTexture(width, height, 0, RenderTextureFormat.RGHalf);
				filmicDepthOfFieldMaterial.SetVector("_Offsets", new Vector4(0f, num4 * 0.75f, 0f, 0f));
				Graphics.Blit(src, temporaryRenderTexture4, filmicDepthOfFieldMaterial, 2);
				filmicDepthOfFieldMaterial.SetVector("_Offsets", new Vector4(num4 * 0.75f, 0f, 0f, 0f));
				Graphics.Blit(temporaryRenderTexture4, renderTexture, filmicDepthOfFieldMaterial, 3);
				m_RTU.ReleaseTemporaryRenderTexture(temporaryRenderTexture4);
				renderTexture.filterMode = FilterMode.Point;
			}
			if (m_CurrentQualitySettings.prefilterBlur)
			{
				Graphics.Blit(src, dst, filmicDepthOfFieldMaterial, 8);
				SwapRenderTexture(ref src, ref dst);
			}
			switch (settings.apertureShape)
			{
			case ApertureShape.Circular:
				DoCircularBlur(renderTexture, ref src, ref dst, num6);
				break;
			case ApertureShape.Hexagonal:
				DoHexagonalBlur(renderTexture, ref src, ref dst, num6);
				break;
			case ApertureShape.Octogonal:
				DoOctogonalBlur(renderTexture, ref src, ref dst, num6);
				break;
			}
			switch (m_CurrentQualitySettings.medianFilter)
			{
			case FilterQuality.Normal:
				medianFilterMaterial.SetVector("_Offsets", new Vector4(1f, 0f, 0f, 0f));
				Graphics.Blit(src, dst, medianFilterMaterial, 0);
				SwapRenderTexture(ref src, ref dst);
				medianFilterMaterial.SetVector("_Offsets", new Vector4(0f, 1f, 0f, 0f));
				Graphics.Blit(src, dst, medianFilterMaterial, 0);
				SwapRenderTexture(ref src, ref dst);
				break;
			case FilterQuality.High:
				Graphics.Blit(src, dst, medianFilterMaterial, 1);
				SwapRenderTexture(ref src, ref dst);
				break;
			}
			filmicDepthOfFieldMaterial.SetVector("_BlurCoe", vector);
			filmicDepthOfFieldMaterial.SetVector("_Convolved_TexelSize", new Vector4(src.width, src.height, 1f / (float)src.width, 1f / (float)src.height));
			filmicDepthOfFieldMaterial.SetTexture("_SecondTex", src);
			int pass = ((settings.tweakMode != TweakMode.Explicit) ? 13 : 14);
			if (m_CurrentQualitySettings.highQualityUpsampling)
			{
				pass = ((settings.tweakMode != TweakMode.Explicit) ? 15 : 16);
			}
			if (shouldPerformBokeh)
			{
				RenderTexture temporaryRenderTexture5 = m_RTU.GetTemporaryRenderTexture(source.height, source.width, 0, source.format);
				Graphics.Blit(source, temporaryRenderTexture5, filmicDepthOfFieldMaterial, pass);
				Graphics.SetRenderTarget(temporaryRenderTexture5);
				ComputeBuffer.CopyCount(computeBufferPoints, computeBufferDrawArgs, 0);
				textureBokehMaterial.SetBuffer("pointBuffer", computeBufferPoints);
				textureBokehMaterial.SetTexture("_MainTex", bokehTexture.texture);
				textureBokehMaterial.SetVector("_Screen", new Vector3(1f / (1f * (float)source.width), 1f / (1f * (float)source.height), num3));
				textureBokehMaterial.SetPass(0);
				Graphics.DrawProceduralIndirect(MeshTopology.Points, computeBufferDrawArgs, 0);
				Graphics.Blit(temporaryRenderTexture5, destination);
			}
			else
			{
				Graphics.Blit(source, destination, filmicDepthOfFieldMaterial, pass);
			}
		}

		private void DoHexagonalBlur(RenderTexture blurredFgCoc, ref RenderTexture src, ref RenderTexture dst, float maxRadius)
		{
			ComputeBlurDirections(force: false);
			GetDirectionalBlurPassesFromRadius(blurredFgCoc, maxRadius, out var blurPass, out var blurAndMergePass);
			filmicDepthOfFieldMaterial.SetTexture("_SecondTex", blurredFgCoc);
			RenderTexture temporaryRenderTexture = m_RTU.GetTemporaryRenderTexture(src.width, src.height, 0, src.format);
			filmicDepthOfFieldMaterial.SetVector("_Offsets", m_HexagonalBokehDirection1);
			Graphics.Blit(src, temporaryRenderTexture, filmicDepthOfFieldMaterial, blurPass);
			filmicDepthOfFieldMaterial.SetVector("_Offsets", m_HexagonalBokehDirection2);
			Graphics.Blit(temporaryRenderTexture, src, filmicDepthOfFieldMaterial, blurPass);
			filmicDepthOfFieldMaterial.SetVector("_Offsets", m_HexagonalBokehDirection3);
			filmicDepthOfFieldMaterial.SetTexture("_ThirdTex", src);
			Graphics.Blit(temporaryRenderTexture, dst, filmicDepthOfFieldMaterial, blurAndMergePass);
			m_RTU.ReleaseTemporaryRenderTexture(temporaryRenderTexture);
			SwapRenderTexture(ref src, ref dst);
		}

		private void DoOctogonalBlur(RenderTexture blurredFgCoc, ref RenderTexture src, ref RenderTexture dst, float maxRadius)
		{
			ComputeBlurDirections(force: false);
			GetDirectionalBlurPassesFromRadius(blurredFgCoc, maxRadius, out var blurPass, out var blurAndMergePass);
			filmicDepthOfFieldMaterial.SetTexture("_SecondTex", blurredFgCoc);
			RenderTexture temporaryRenderTexture = m_RTU.GetTemporaryRenderTexture(src.width, src.height, 0, src.format);
			filmicDepthOfFieldMaterial.SetVector("_Offsets", m_OctogonalBokehDirection1);
			Graphics.Blit(src, temporaryRenderTexture, filmicDepthOfFieldMaterial, blurPass);
			filmicDepthOfFieldMaterial.SetVector("_Offsets", m_OctogonalBokehDirection2);
			Graphics.Blit(temporaryRenderTexture, dst, filmicDepthOfFieldMaterial, blurPass);
			filmicDepthOfFieldMaterial.SetVector("_Offsets", m_OctogonalBokehDirection3);
			Graphics.Blit(src, temporaryRenderTexture, filmicDepthOfFieldMaterial, blurPass);
			filmicDepthOfFieldMaterial.SetVector("_Offsets", m_OctogonalBokehDirection4);
			filmicDepthOfFieldMaterial.SetTexture("_ThirdTex", dst);
			Graphics.Blit(temporaryRenderTexture, src, filmicDepthOfFieldMaterial, blurAndMergePass);
			m_RTU.ReleaseTemporaryRenderTexture(temporaryRenderTexture);
		}

		private void DoCircularBlur(RenderTexture blurredFgCoc, ref RenderTexture src, ref RenderTexture dst, float maxRadius)
		{
			int pass;
			if (blurredFgCoc != null)
			{
				filmicDepthOfFieldMaterial.SetTexture("_SecondTex", blurredFgCoc);
				pass = ((!(maxRadius > 10f)) ? 12 : 10);
			}
			else
			{
				pass = ((!(maxRadius > 10f)) ? 11 : 9);
			}
			Graphics.Blit(src, dst, filmicDepthOfFieldMaterial, pass);
			SwapRenderTexture(ref src, ref dst);
		}

		private void ComputeCocParameters(out Vector4 blurParams, out Vector4 blurCoe)
		{
			Camera component = GetComponent<Camera>();
			float num = ((!focus.transform) ? (focus.plane * focus.plane * focus.plane * focus.plane) : (component.WorldToViewportPoint(focus.transform.position).z / component.farClipPlane));
			if (settings.tweakMode == TweakMode.Basic || settings.tweakMode == TweakMode.Advanced)
			{
				float w = focus.rangeAdjustment * focus.rangeAdjustment * focus.rangeAdjustment * focus.rangeAdjustment;
				float num2 = 4f / Mathf.Tan(0.5f * component.fieldOfView * ((float)Math.PI / 180f));
				float x = num2 / focus.fStops;
				blurCoe = new Vector4(0f, 0f, 1f, 1f);
				blurParams = new Vector4(x, num2, num, w);
				return;
			}
			float num3 = focus.nearPlane * focus.nearPlane * focus.nearPlane * focus.nearPlane;
			float num4 = focus.farPlane * focus.farPlane * focus.farPlane * focus.farPlane;
			float num5 = focus.rangeAdjustment * focus.rangeAdjustment * focus.rangeAdjustment * focus.rangeAdjustment;
			float num6 = num5;
			if (num <= num3)
			{
				num = num3 + 1E-07f;
			}
			if (num >= num4)
			{
				num = num4 - 1E-07f;
			}
			if (num - num5 <= num3)
			{
				num5 = num - num3 - 1E-07f;
			}
			if (num + num6 >= num4)
			{
				num6 = num4 - num - 1E-07f;
			}
			float num7 = 1f / (num3 - num + num5);
			float num8 = 1f / (num4 - num - num6);
			float num9 = 1f - num7 * num3;
			float num10 = 1f - num8 * num4;
			blurParams = new Vector4(-1f * num7, -1f * num9, 1f * num8, 1f * num10);
			blurCoe = new Vector4(0f, 0f, (num10 - num9) / (num7 - num8), 0f);
		}

		private void ReleaseComputeResources()
		{
			if (m_ComputeBufferDrawArgs != null)
			{
				m_ComputeBufferDrawArgs.Release();
			}
			if (m_ComputeBufferPoints != null)
			{
				m_ComputeBufferPoints.Release();
			}
			m_ComputeBufferDrawArgs = null;
			m_ComputeBufferPoints = null;
		}

		private void ComputeBlurDirections(bool force)
		{
			if (force || !(Math.Abs(m_LastApertureOrientation - settings.apertureOrientation) < float.Epsilon))
			{
				m_LastApertureOrientation = settings.apertureOrientation;
				float num = settings.apertureOrientation * ((float)Math.PI / 180f);
				float cosinus = Mathf.Cos(num);
				float sinus = Mathf.Sin(num);
				m_OctogonalBokehDirection1 = new Vector4(0.5f, 0f, 0f, 0f);
				m_OctogonalBokehDirection2 = new Vector4(0f, 0.5f, 1f, 0f);
				m_OctogonalBokehDirection3 = new Vector4(-0.353553f, 0.353553f, 1f, 0f);
				m_OctogonalBokehDirection4 = new Vector4(0.353553f, 0.353553f, 1f, 0f);
				m_HexagonalBokehDirection1 = new Vector4(0.5f, 0f, 0f, 0f);
				m_HexagonalBokehDirection2 = new Vector4(0.25f, 0.433013f, 1f, 0f);
				m_HexagonalBokehDirection3 = new Vector4(0.25f, -0.433013f, 1f, 0f);
				if (num > float.Epsilon)
				{
					Rotate2D(ref m_OctogonalBokehDirection1, cosinus, sinus);
					Rotate2D(ref m_OctogonalBokehDirection2, cosinus, sinus);
					Rotate2D(ref m_OctogonalBokehDirection3, cosinus, sinus);
					Rotate2D(ref m_OctogonalBokehDirection4, cosinus, sinus);
					Rotate2D(ref m_HexagonalBokehDirection1, cosinus, sinus);
					Rotate2D(ref m_HexagonalBokehDirection2, cosinus, sinus);
					Rotate2D(ref m_HexagonalBokehDirection3, cosinus, sinus);
				}
			}
		}

		private static void Rotate2D(ref Vector4 direction, float cosinus, float sinus)
		{
			Vector4 vector = direction;
			direction.x = vector.x * cosinus - vector.y * sinus;
			direction.y = vector.x * sinus + vector.y * cosinus;
		}

		private static void SwapRenderTexture(ref RenderTexture src, ref RenderTexture dst)
		{
			RenderTexture renderTexture = dst;
			dst = src;
			src = renderTexture;
		}

		private static void GetDirectionalBlurPassesFromRadius(RenderTexture blurredFgCoc, float maxRadius, out int blurPass, out int blurAndMergePass)
		{
			if (blurredFgCoc == null)
			{
				if (maxRadius > 10f)
				{
					blurPass = 25;
					blurAndMergePass = 27;
				}
				else if (maxRadius > 5f)
				{
					blurPass = 21;
					blurAndMergePass = 23;
				}
				else
				{
					blurPass = 17;
					blurAndMergePass = 19;
				}
			}
			else if (maxRadius > 10f)
			{
				blurPass = 26;
				blurAndMergePass = 28;
			}
			else if (maxRadius > 5f)
			{
				blurPass = 22;
				blurAndMergePass = 24;
			}
			else
			{
				blurPass = 18;
				blurAndMergePass = 20;
			}
		}
	}
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Cinematic/Lens Aberrations")]
	[ExecuteInEditMode]
	public class LensAberrations : MonoBehaviour
	{
		[AttributeUsage(AttributeTargets.Field)]
		public class SettingsGroup : Attribute
		{
		}

		[AttributeUsage(AttributeTargets.Field)]
		public class AdvancedSetting : Attribute
		{
		}

		[Serializable]
		public struct DistortionSettings
		{
			public bool enabled;

			[Range(-100f, 100f)]
			[Tooltip("Distortion amount.")]
			public float amount;

			[Range(-1f, 1f)]
			[Tooltip("Distortion center point (X axis).")]
			public float centerX;

			[Tooltip("Distortion center point (Y axis).")]
			[Range(-1f, 1f)]
			public float centerY;

			[Range(0f, 1f)]
			[Tooltip("Amount multiplier on X axis. Set it to 0 to disable distortion on this axis.")]
			public float amountX;

			[Range(0f, 1f)]
			[Tooltip("Amount multiplier on Y axis. Set it to 0 to disable distortion on this axis.")]
			public float amountY;

			[Range(0.01f, 5f)]
			[Tooltip("Global screen scaling.")]
			public float scale;

			public static DistortionSettings defaultSettings => new DistortionSettings
			{
				enabled = false,
				amount = 0f,
				centerX = 0f,
				centerY = 0f,
				amountX = 1f,
				amountY = 1f,
				scale = 1f
			};
		}

		[Serializable]
		public struct VignetteSettings
		{
			public bool enabled;

			[ColorUsage(false)]
			[Tooltip("Vignette color. Use the alpha channel for transparency.")]
			public Color color;

			[Tooltip("Sets the vignette center point (screen center is [0.5,0.5]).")]
			public Vector2 center;

			[Range(0f, 3f)]
			[Tooltip("Amount of vignetting on screen.")]
			public float intensity;

			[Tooltip("Smoothness of the vignette borders.")]
			[Range(0.01f, 3f)]
			public float smoothness;

			[AdvancedSetting]
			[Range(0f, 1f)]
			[Tooltip("Lower values will make a square-ish vignette.")]
			public float roundness;

			[Tooltip("Blurs the corners of the screen. Leave this at 0 to disable it.")]
			[Range(0f, 1f)]
			public float blur;

			[Tooltip("Desaturate the corners of the screen. Leave this to 0 to disable it.")]
			[Range(0f, 1f)]
			public float desaturate;

			public static VignetteSettings defaultSettings => new VignetteSettings
			{
				enabled = false,
				color = new Color(0f, 0f, 0f, 1f),
				center = new Vector2(0.5f, 0.5f),
				intensity = 1.4f,
				smoothness = 0.8f,
				roundness = 1f,
				blur = 0f,
				desaturate = 0f
			};
		}

		[Serializable]
		public struct ChromaticAberrationSettings
		{
			public bool enabled;

			[Tooltip("Channels to apply chromatic aberration to.")]
			[ColorUsage(false)]
			public Color color;

			[Tooltip("Amount of tangential distortion.")]
			[Range(-50f, 50f)]
			public float amount;

			public static ChromaticAberrationSettings defaultSettings => new ChromaticAberrationSettings
			{
				enabled = false,
				color = Color.green,
				amount = 0f
			};
		}

		private enum Pass
		{
			BlurPrePass,
			Chroma,
			Distort,
			Vignette,
			ChromaDistort,
			ChromaVignette,
			DistortVignette,
			ChromaDistortVignette
		}

		[SettingsGroup]
		public DistortionSettings distortion = DistortionSettings.defaultSettings;

		[SettingsGroup]
		public VignetteSettings vignette = VignetteSettings.defaultSettings;

		[SettingsGroup]
		public ChromaticAberrationSettings chromaticAberration = ChromaticAberrationSettings.defaultSettings;

		[SerializeField]
		private Shader m_Shader;

		private Material m_Material;

		private RenderTextureUtility m_RTU;

		public Shader shader
		{
			get
			{
				if (m_Shader == null)
				{
					m_Shader = Shader.Find("Hidden/LensAberrations");
				}
				return m_Shader;
			}
		}

		public Material material
		{
			get
			{
				if (m_Material == null)
				{
					m_Material = ImageEffectHelper.CheckShaderAndCreateMaterial(shader);
				}
				return m_Material;
			}
		}

		private void OnEnable()
		{
			if (!ImageEffectHelper.IsSupported(shader, needDepth: false, needHdr: false, this))
			{
				base.enabled = false;
			}
			m_RTU = new RenderTextureUtility();
		}

		private void OnDisable()
		{
			if (m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(m_Material);
			}
			m_Material = null;
			m_RTU.ReleaseAllTemporaryRenderTextures();
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!vignette.enabled && !chromaticAberration.enabled && !distortion.enabled)
			{
				Graphics.Blit(source, destination);
				return;
			}
			material.shaderKeywords = null;
			if (distortion.enabled)
			{
				float val = 1.6f * Math.Max(Mathf.Abs(distortion.amount), 1f);
				float num = (float)Math.PI / 180f * Math.Min(160f, val);
				float y = 2f * Mathf.Tan(num * 0.5f);
				Vector4 vector = new Vector4(distortion.centerX, distortion.centerY, Mathf.Max(distortion.amountX, 0.0001f), Mathf.Max(distortion.amountY, 0.0001f));
				Vector3 vector2 = new Vector3((!(distortion.amount >= 0f)) ? (1f / num) : num, y, 1f / distortion.scale);
				material.EnableKeyword((!(distortion.amount >= 0f)) ? "UNDISTORT" : "DISTORT");
				material.SetVector("_DistCenterScale", vector);
				material.SetVector("_DistAmount", vector2);
			}
			if (chromaticAberration.enabled)
			{
				material.EnableKeyword("CHROMATIC_ABERRATION");
				Vector4 vector3 = new Vector4(chromaticAberration.color.r, chromaticAberration.color.g, chromaticAberration.color.b, chromaticAberration.amount * 0.001f);
				material.SetVector("_ChromaticAberration", vector3);
			}
			if (vignette.enabled)
			{
				material.SetColor("_VignetteColor", vignette.color);
				if (vignette.blur > 0f)
				{
					int num2 = source.width / 2;
					int num3 = source.height / 2;
					RenderTexture temporaryRenderTexture = m_RTU.GetTemporaryRenderTexture(num2, num3, 0, source.format);
					RenderTexture temporaryRenderTexture2 = m_RTU.GetTemporaryRenderTexture(num2, num3, 0, source.format);
					material.SetVector("_BlurPass", new Vector2(1f / (float)num2, 0f));
					Graphics.Blit(source, temporaryRenderTexture, material, 0);
					if (distortion.enabled)
					{
						material.DisableKeyword("DISTORT");
						material.DisableKeyword("UNDISTORT");
					}
					material.SetVector("_BlurPass", new Vector2(0f, 1f / (float)num3));
					Graphics.Blit(temporaryRenderTexture, temporaryRenderTexture2, material, 0);
					material.SetVector("_BlurPass", new Vector2(1f / (float)num2, 0f));
					Graphics.Blit(temporaryRenderTexture2, temporaryRenderTexture, material, 0);
					material.SetVector("_BlurPass", new Vector2(0f, 1f / (float)num3));
					Graphics.Blit(temporaryRenderTexture, temporaryRenderTexture2, material, 0);
					material.SetTexture("_BlurTex", temporaryRenderTexture2);
					material.SetFloat("_VignetteBlur", vignette.blur * 3f);
					material.EnableKeyword("VIGNETTE_BLUR");
					if (distortion.enabled)
					{
						material.EnableKeyword((!(distortion.amount >= 0f)) ? "UNDISTORT" : "DISTORT");
					}
				}
				if (vignette.desaturate > 0f)
				{
					material.EnableKeyword("VIGNETTE_DESAT");
					material.SetFloat("_VignetteDesat", 1f - vignette.desaturate);
				}
				material.SetVector("_VignetteCenter", vignette.center);
				if (Mathf.Approximately(vignette.roundness, 1f))
				{
					material.EnableKeyword("VIGNETTE_CLASSIC");
					material.SetVector("_VignetteSettings", new Vector2(vignette.intensity, vignette.smoothness));
				}
				else
				{
					material.EnableKeyword("VIGNETTE_FILMIC");
					float z = (1f - vignette.roundness) * 6f + vignette.roundness;
					material.SetVector("_VignetteSettings", new Vector3(vignette.intensity, vignette.smoothness, z));
				}
			}
			int pass = 0;
			if (vignette.enabled && chromaticAberration.enabled && distortion.enabled)
			{
				pass = 7;
			}
			else if (vignette.enabled && chromaticAberration.enabled)
			{
				pass = 5;
			}
			else if (vignette.enabled && distortion.enabled)
			{
				pass = 6;
			}
			else if (chromaticAberration.enabled && distortion.enabled)
			{
				pass = 4;
			}
			else if (vignette.enabled)
			{
				pass = 3;
			}
			else if (chromaticAberration.enabled)
			{
				pass = 1;
			}
			else if (distortion.enabled)
			{
				pass = 2;
			}
			Graphics.Blit(source, destination, material, pass);
			m_RTU.ReleaseAllTemporaryRenderTextures();
		}
	}
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Cinematic/Tonemapping and Color Grading")]
	[ImageEffectAllowedInSceneView]
	[ExecuteInEditMode]
	public class TonemappingColorGrading : MonoBehaviour
	{
		[AttributeUsage(AttributeTargets.Field)]
		public class SettingsGroup : Attribute
		{
		}

		public class IndentedGroup : PropertyAttribute
		{
		}

		public class ChannelMixer : PropertyAttribute
		{
		}

		public class ColorWheelGroup : PropertyAttribute
		{
			public int minSizePerWheel = 60;

			public int maxSizePerWheel = 150;

			public ColorWheelGroup()
			{
			}

			public ColorWheelGroup(int minSizePerWheel, int maxSizePerWheel)
			{
				this.minSizePerWheel = minSizePerWheel;
				this.maxSizePerWheel = maxSizePerWheel;
			}
		}

		public class Curve : PropertyAttribute
		{
			public Color color = Color.white;

			public Curve()
			{
			}

			public Curve(float r, float g, float b, float a)
			{
				color = new Color(r, g, b, a);
			}
		}

		[Serializable]
		public struct EyeAdaptationSettings
		{
			public bool enabled;

			[Tooltip("Midpoint Adjustment.")]
			[Min(0f)]
			public float middleGrey;

			[Tooltip("The lowest possible exposure value; adjust this value to modify the brightest areas of your level.")]
			public float min;

			[Tooltip("The highest possible exposure value; adjust this value to modify the darkest areas of your level.")]
			public float max;

			[Tooltip("Speed of linear adaptation. Higher is faster.")]
			[Min(0f)]
			public float speed;

			[Tooltip("Displays a luminosity helper in the GameView.")]
			public bool showDebug;

			public static EyeAdaptationSettings defaultSettings => new EyeAdaptationSettings
			{
				enabled = false,
				showDebug = false,
				middleGrey = 0.5f,
				min = -3f,
				max = 3f,
				speed = 1.5f
			};
		}

		public enum Tonemapper
		{
			ACES,
			Curve,
			Hable,
			HejlDawson,
			Photographic,
			Reinhard,
			Neutral
		}

		[Serializable]
		public struct TonemappingSettings
		{
			public bool enabled;

			[Tooltip("Tonemapping technique to use. ACES is the recommended one.")]
			public Tonemapper tonemapper;

			[Min(0f)]
			[Tooltip("Adjusts the overall exposure of the scene.")]
			public float exposure;

			[Tooltip("Custom tonemapping curve.")]
			public AnimationCurve curve;

			[Range(-0.1f, 0.1f)]
			public float neutralBlackIn;

			[Range(1f, 20f)]
			public float neutralWhiteIn;

			[Range(-0.09f, 0.1f)]
			public float neutralBlackOut;

			[Range(1f, 19f)]
			public float neutralWhiteOut;

			[Range(0.1f, 20f)]
			public float neutralWhiteLevel;

			[Range(1f, 10f)]
			public float neutralWhiteClip;

			public static TonemappingSettings defaultSettings => new TonemappingSettings
			{
				enabled = false,
				tonemapper = Tonemapper.Neutral,
				exposure = 1f,
				curve = CurvesSettings.defaultCurve,
				neutralBlackIn = 0.02f,
				neutralWhiteIn = 10f,
				neutralBlackOut = 0f,
				neutralWhiteOut = 10f,
				neutralWhiteLevel = 5.3f,
				neutralWhiteClip = 10f
			};
		}

		[Serializable]
		public struct LUTSettings
		{
			public bool enabled;

			[Tooltip("Custom lookup texture (strip format, e.g. 256x16).")]
			public Texture texture;

			[Tooltip("Blending factor.")]
			[Range(0f, 1f)]
			public float contribution;

			public static LUTSettings defaultSettings => new LUTSettings
			{
				enabled = false,
				texture = null,
				contribution = 1f
			};
		}

		[Serializable]
		public struct ColorWheelsSettings
		{
			[ColorUsage(false)]
			public Color shadows;

			[ColorUsage(false)]
			public Color midtones;

			[ColorUsage(false)]
			public Color highlights;

			public static ColorWheelsSettings defaultSettings => new ColorWheelsSettings
			{
				shadows = Color.white,
				midtones = Color.white,
				highlights = Color.white
			};
		}

		[Serializable]
		public struct BasicsSettings
		{
			[Tooltip("Sets the white balance to a custom color temperature.")]
			[Range(-2f, 2f)]
			public float temperatureShift;

			[Range(-2f, 2f)]
			[Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
			public float tint;

			[Space]
			[Range(-0.5f, 0.5f)]
			[Tooltip("Shift the hue of all colors.")]
			public float hue;

			[Tooltip("Pushes the intensity of all colors.")]
			[Range(0f, 2f)]
			public float saturation;

			[Range(-1f, 1f)]
			[Tooltip("Adjusts the saturation so that clipping is minimized as colors approach full saturation.")]
			public float vibrance;

			[Range(0f, 10f)]
			[Tooltip("Brightens or darkens all colors.")]
			public float value;

			[Range(0f, 2f)]
			[Space]
			[Tooltip("Expands or shrinks the overall range of tonal values.")]
			public float contrast;

			[Range(0.01f, 5f)]
			[Tooltip("Contrast gain curve. Controls the steepness of the curve.")]
			public float gain;

			[Tooltip("Applies a pow function to the source.")]
			[Range(0.01f, 5f)]
			public float gamma;

			public static BasicsSettings defaultSettings => new BasicsSettings
			{
				temperatureShift = 0f,
				tint = 0f,
				contrast = 1f,
				hue = 0f,
				saturation = 1f,
				value = 1f,
				vibrance = 0f,
				gain = 1f,
				gamma = 1f
			};
		}

		[Serializable]
		public struct ChannelMixerSettings
		{
			public int currentChannel;

			public Vector3[] channels;

			public static ChannelMixerSettings defaultSettings => new ChannelMixerSettings
			{
				currentChannel = 0,
				channels = new Vector3[3]
				{
					new Vector3(1f, 0f, 0f),
					new Vector3(0f, 1f, 0f),
					new Vector3(0f, 0f, 1f)
				}
			};
		}

		[Serializable]
		public struct CurvesSettings
		{
			[Curve]
			public AnimationCurve master;

			[Curve(1f, 0f, 0f, 1f)]
			public AnimationCurve red;

			[Curve(0f, 1f, 0f, 1f)]
			public AnimationCurve green;

			[Curve(0f, 1f, 1f, 1f)]
			public AnimationCurve blue;

			public static CurvesSettings defaultSettings => new CurvesSettings
			{
				master = defaultCurve,
				red = defaultCurve,
				green = defaultCurve,
				blue = defaultCurve
			};

			public static AnimationCurve defaultCurve => new AnimationCurve(new Keyframe(0f, 0f, 1f, 1f), new Keyframe(1f, 1f, 1f, 1f));
		}

		public enum ColorGradingPrecision
		{
			Normal = 0x10,
			High = 0x20
		}

		[Serializable]
		public struct ColorGradingSettings
		{
			public bool enabled;

			[Tooltip("Internal LUT precision. \"Normal\" is 256x16, \"High\" is 1024x32. Prefer \"Normal\" on mobile devices.")]
			public ColorGradingPrecision precision;

			[ColorWheelGroup]
			[Space]
			public ColorWheelsSettings colorWheels;

			[IndentedGroup]
			[Space]
			public BasicsSettings basics;

			[ChannelMixer]
			[Space]
			public ChannelMixerSettings channelMixer;

			[Space]
			[IndentedGroup]
			public CurvesSettings curves;

			[Space]
			[Tooltip("Use dithering to try and minimize color banding in dark areas.")]
			public bool useDithering;

			[Tooltip("Displays the generated LUT in the top left corner of the GameView.")]
			public bool showDebug;

			public static ColorGradingSettings defaultSettings => new ColorGradingSettings
			{
				enabled = false,
				useDithering = false,
				showDebug = false,
				precision = ColorGradingPrecision.Normal,
				colorWheels = ColorWheelsSettings.defaultSettings,
				basics = BasicsSettings.defaultSettings,
				channelMixer = ChannelMixerSettings.defaultSettings,
				curves = CurvesSettings.defaultSettings
			};

			internal void Reset()
			{
				curves = CurvesSettings.defaultSettings;
			}
		}

		private enum Pass
		{
			LutGen,
			AdaptationLog,
			AdaptationExpBlend,
			AdaptationExp,
			TonemappingOff,
			TonemappingACES,
			TonemappingCurve,
			TonemappingHable,
			TonemappingHejlDawson,
			TonemappingPhotographic,
			TonemappingReinhard,
			TonemappingNeutral,
			AdaptationDebug
		}

		[SerializeField]
		[SettingsGroup]
		private EyeAdaptationSettings m_EyeAdaptation = EyeAdaptationSettings.defaultSettings;

		[SerializeField]
		[SettingsGroup]
		private TonemappingSettings m_Tonemapping = TonemappingSettings.defaultSettings;

		[SerializeField]
		[SettingsGroup]
		private LUTSettings m_Lut = LUTSettings.defaultSettings;

		[SerializeField]
		[SettingsGroup]
		private ColorGradingSettings m_ColorGrading = ColorGradingSettings.defaultSettings;

		[NonSerialized]
		public float MonochromeAmount;

		private Texture2D m_IdentityLut;

		private RenderTexture m_InternalLut;

		private Texture2D m_CurveTexture;

		private Texture2D m_TonemapperCurve;

		private float m_TonemapperCurveRange;

		[SerializeField]
		private Shader m_Shader;

		private Material m_Material;

		private bool m_Dirty = true;

		private bool m_TonemapperDirty = true;

		private RenderTexture m_SmallAdaptiveRt;

		private RenderTextureFormat m_AdaptiveRtFormat;

		public EyeAdaptationSettings eyeAdaptation
		{
			get
			{
				return m_EyeAdaptation;
			}
			set
			{
				m_EyeAdaptation = value;
			}
		}

		public TonemappingSettings tonemapping
		{
			get
			{
				return m_Tonemapping;
			}
			set
			{
				m_Tonemapping = value;
				SetTonemapperDirty();
			}
		}

		public LUTSettings lut
		{
			get
			{
				return m_Lut;
			}
			set
			{
				m_Lut = value;
				SetDirty();
			}
		}

		public ColorGradingSettings colorGrading
		{
			get
			{
				return m_ColorGrading;
			}
			set
			{
				m_ColorGrading = value;
				SetDirty();
			}
		}

		private Texture2D identityLut
		{
			get
			{
				if (m_IdentityLut == null || m_IdentityLut.height != lutSize)
				{
					UnityEngine.Object.DestroyImmediate(m_IdentityLut);
					m_IdentityLut = GenerateIdentityLut(lutSize);
				}
				return m_IdentityLut;
			}
		}

		private RenderTexture internalLutRt
		{
			get
			{
				if (m_InternalLut == null || !m_InternalLut.IsCreated() || m_InternalLut.height != lutSize)
				{
					UnityEngine.Object.DestroyImmediate(m_InternalLut);
					m_InternalLut = new RenderTexture(lutSize * lutSize, lutSize, 0, RenderTextureFormat.ARGB32)
					{
						name = "Internal LUT",
						filterMode = FilterMode.Bilinear,
						anisoLevel = 0,
						hideFlags = HideFlags.DontSave
					};
				}
				return m_InternalLut;
			}
		}

		private Texture2D curveTexture
		{
			get
			{
				if (m_CurveTexture == null)
				{
					m_CurveTexture = new Texture2D(256, 1, TextureFormat.ARGB32, mipmap: false, linear: true)
					{
						name = "Curve texture",
						wrapMode = TextureWrapMode.Clamp,
						filterMode = FilterMode.Bilinear,
						anisoLevel = 0,
						hideFlags = HideFlags.DontSave
					};
				}
				return m_CurveTexture;
			}
		}

		private Texture2D tonemapperCurve
		{
			get
			{
				if (m_TonemapperCurve == null)
				{
					TextureFormat format = TextureFormat.RGB24;
					if (SystemInfo.SupportsTextureFormat(TextureFormat.RFloat))
					{
						format = TextureFormat.RFloat;
					}
					else if (SystemInfo.SupportsTextureFormat(TextureFormat.RHalf))
					{
						format = TextureFormat.RHalf;
					}
					m_TonemapperCurve = new Texture2D(256, 1, format, mipmap: false, linear: true)
					{
						name = "Tonemapper curve texture",
						wrapMode = TextureWrapMode.Clamp,
						filterMode = FilterMode.Bilinear,
						anisoLevel = 0,
						hideFlags = HideFlags.DontSave
					};
				}
				return m_TonemapperCurve;
			}
		}

		public Shader shader
		{
			get
			{
				if (m_Shader == null)
				{
					m_Shader = Shader.Find("Hidden/TonemappingColorGrading");
				}
				return m_Shader;
			}
		}

		public Material material
		{
			get
			{
				if (m_Material == null)
				{
					m_Material = ImageEffectHelper.CheckShaderAndCreateMaterial(shader);
				}
				return m_Material;
			}
		}

		public bool isGammaColorSpace => QualitySettings.activeColorSpace == ColorSpace.Gamma;

		public int lutSize => (int)colorGrading.precision;

		public bool validRenderTextureFormat { get; private set; }

		public bool validUserLutSize { get; private set; }

		public void SetDirty()
		{
			m_Dirty = true;
		}

		public void SetTonemapperDirty()
		{
			m_TonemapperDirty = true;
		}

		private void OnEnable()
		{
			if (!ImageEffectHelper.IsSupported(shader, needDepth: false, needHdr: true, this))
			{
				base.enabled = false;
				return;
			}
			SetDirty();
			SetTonemapperDirty();
		}

		private void OnDisable()
		{
			if (m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(m_Material);
			}
			if (m_IdentityLut != null)
			{
				UnityEngine.Object.DestroyImmediate(m_IdentityLut);
			}
			if (m_InternalLut != null)
			{
				UnityEngine.Object.DestroyImmediate(internalLutRt);
			}
			if (m_SmallAdaptiveRt != null)
			{
				UnityEngine.Object.DestroyImmediate(m_SmallAdaptiveRt);
			}
			if (m_CurveTexture != null)
			{
				UnityEngine.Object.DestroyImmediate(m_CurveTexture);
			}
			if (m_TonemapperCurve != null)
			{
				UnityEngine.Object.DestroyImmediate(m_TonemapperCurve);
			}
			m_Material = null;
			m_IdentityLut = null;
			m_InternalLut = null;
			m_SmallAdaptiveRt = null;
			m_CurveTexture = null;
			m_TonemapperCurve = null;
		}

		private void OnValidate()
		{
			SetDirty();
			SetTonemapperDirty();
		}

		private static Texture2D GenerateIdentityLut(int dim)
		{
			Color[] array = new Color[dim * dim * dim];
			float num = 1f / ((float)dim - 1f);
			for (int i = 0; i < dim; i++)
			{
				for (int j = 0; j < dim; j++)
				{
					for (int k = 0; k < dim; k++)
					{
						ref Color reference = ref array[i + j * dim + k * dim * dim];
						reference = new Color((float)i * num, Mathf.Abs((float)k * num), (float)j * num, 1f);
					}
				}
			}
			Texture2D texture2D = new Texture2D(dim * dim, dim, TextureFormat.RGB24, mipmap: false, linear: true);
			texture2D.name = "Identity LUT";
			texture2D.filterMode = FilterMode.Bilinear;
			texture2D.anisoLevel = 0;
			texture2D.hideFlags = HideFlags.DontSave;
			Texture2D texture2D2 = texture2D;
			texture2D2.SetPixels(array);
			texture2D2.Apply();
			return texture2D2;
		}

		private float StandardIlluminantY(float x)
		{
			return 2.87f * x - 3f * x * x - 0.27509508f;
		}

		private Vector3 CIExyToLMS(float x, float y)
		{
			float num = 1f;
			float num2 = num * x / y;
			float num3 = num * (1f - x - y) / y;
			float x2 = 0.7328f * num2 + 0.4296f * num - 0.1624f * num3;
			float y2 = -0.7036f * num2 + 1.6975f * num + 0.0061f * num3;
			float z = 0.003f * num2 + 0.0136f * num + 0.9834f * num3;
			return new Vector3(x2, y2, z);
		}

		private Vector3 GetWhiteBalance()
		{
			float temperatureShift = colorGrading.basics.temperatureShift;
			float tint = colorGrading.basics.tint;
			float x = 0.31271f - temperatureShift * ((!(temperatureShift < 0f)) ? 0.05f : 0.1f);
			float y = StandardIlluminantY(x) + tint * 0.05f;
			Vector3 vector = new Vector3(0.949237f, 1.03542f, 1.08728f);
			Vector3 vector2 = CIExyToLMS(x, y);
			return new Vector3(vector.x / vector2.x, vector.y / vector2.y, vector.z / vector2.z);
		}

		private static Color NormalizeColor(Color c)
		{
			float num = (c.r + c.g + c.b) / 3f;
			if (Mathf.Approximately(num, 0f))
			{
				return new Color(1f, 1f, 1f, 1f);
			}
			return new Color
			{
				r = c.r / num,
				g = c.g / num,
				b = c.b / num,
				a = 1f
			};
		}

		private void GenerateLiftGammaGain(out Color lift, out Color gamma, out Color gain)
		{
			Color color = NormalizeColor(colorGrading.colorWheels.shadows);
			Color color2 = NormalizeColor(colorGrading.colorWheels.midtones);
			Color color3 = NormalizeColor(colorGrading.colorWheels.highlights);
			float num = (color.r + color.g + color.b) / 3f;
			float num2 = (color2.r + color2.g + color2.b) / 3f;
			float num3 = (color3.r + color3.g + color3.b) / 3f;
			float r = (color.r - num) * 0.1f;
			float g = (color.g - num) * 0.1f;
			float b = (color.b - num) * 0.1f;
			float b2 = Mathf.Pow(2f, (color2.r - num2) * 0.5f);
			float b3 = Mathf.Pow(2f, (color2.g - num2) * 0.5f);
			float b4 = Mathf.Pow(2f, (color2.b - num2) * 0.5f);
			float r2 = Mathf.Pow(2f, (color3.r - num3) * 0.5f);
			float g2 = Mathf.Pow(2f, (color3.g - num3) * 0.5f);
			float b5 = Mathf.Pow(2f, (color3.b - num3) * 0.5f);
			float r3 = 1f / Mathf.Max(0.01f, b2);
			float g3 = 1f / Mathf.Max(0.01f, b3);
			float b6 = 1f / Mathf.Max(0.01f, b4);
			lift = new Color(r, g, b);
			gamma = new Color(r3, g3, b6);
			gain = new Color(r2, g2, b5);
		}

		private void GenCurveTexture()
		{
			AnimationCurve master = colorGrading.curves.master;
			AnimationCurve red = colorGrading.curves.red;
			AnimationCurve green = colorGrading.curves.green;
			AnimationCurve blue = colorGrading.curves.blue;
			Color[] array = new Color[256];
			for (float num = 0f; num <= 1f; num += 0.003921569f)
			{
				float a = Mathf.Clamp(master.Evaluate(num), 0f, 1f);
				float r = Mathf.Clamp(red.Evaluate(num), 0f, 1f);
				float g = Mathf.Clamp(green.Evaluate(num), 0f, 1f);
				float b = Mathf.Clamp(blue.Evaluate(num), 0f, 1f);
				ref Color reference = ref array[(int)Mathf.Floor(num * 255f)];
				reference = new Color(r, g, b, a);
			}
			curveTexture.SetPixels(array);
			curveTexture.Apply();
		}

		private bool CheckUserLut()
		{
			validUserLutSize = lut.texture.height == (int)Mathf.Sqrt(lut.texture.width);
			return validUserLutSize;
		}

		private bool CheckSmallAdaptiveRt()
		{
			if (m_SmallAdaptiveRt != null)
			{
				return false;
			}
			m_AdaptiveRtFormat = RenderTextureFormat.ARGBHalf;
			if (SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGHalf))
			{
				m_AdaptiveRtFormat = RenderTextureFormat.RGHalf;
			}
			m_SmallAdaptiveRt = new RenderTexture(1, 1, 0, m_AdaptiveRtFormat);
			m_SmallAdaptiveRt.hideFlags = HideFlags.DontSave;
			return true;
		}

		private void OnGUI()
		{
			if (Event.current.type == EventType.Repaint)
			{
				int num = 0;
				if (m_InternalLut != null && colorGrading.enabled && colorGrading.showDebug)
				{
					Graphics.DrawTexture(new Rect(0f, num, lutSize * lutSize, lutSize), internalLutRt);
					num += lutSize;
				}
				if (m_SmallAdaptiveRt != null && eyeAdaptation.enabled && eyeAdaptation.showDebug)
				{
					m_Material.SetPass(12);
					Graphics.DrawTexture(new Rect(0f, num, 256f, 16f), m_SmallAdaptiveRt, m_Material);
				}
			}
		}

		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			material.shaderKeywords = null;
			Texture texture = null;
			float w = 1f;
			RenderTexture renderTexture = null;
			RenderTexture[] array = null;
			if (eyeAdaptation.enabled)
			{
				bool flag = CheckSmallAdaptiveRt();
				int num = ((source.width >= source.height) ? source.height : source.width);
				int num2 = num;
				num2 |= num2 >> 1;
				num2 |= num2 >> 2;
				num2 |= num2 >> 4;
				num2 |= num2 >> 8;
				num2 |= num2 >> 16;
				num2 -= num2 >> 1;
				renderTexture = RenderTexture.GetTemporary(num2, num2, 0, m_AdaptiveRtFormat);
				Graphics.Blit(source, renderTexture);
				int num3 = (int)Mathf.Log(renderTexture.width, 2f);
				int num4 = 2;
				array = new RenderTexture[num3];
				for (int i = 0; i < num3; i++)
				{
					array[i] = RenderTexture.GetTemporary(renderTexture.width / num4, renderTexture.width / num4, 0, m_AdaptiveRtFormat);
					num4 <<= 1;
				}
				RenderTexture source2 = array[num3 - 1];
				Graphics.Blit(renderTexture, array[0], material, 1);
				for (int j = 0; j < num3 - 1; j++)
				{
					Graphics.Blit(array[j], array[j + 1]);
					source2 = array[j + 1];
				}
				m_SmallAdaptiveRt.MarkRestoreExpected();
				material.SetFloat("_AdaptationSpeed", Mathf.Max(eyeAdaptation.speed, 0.001f));
				Graphics.Blit(source2, m_SmallAdaptiveRt, material, (!flag) ? 2 : 3);
				material.SetFloat("_MiddleGrey", eyeAdaptation.middleGrey);
				material.SetFloat("_AdaptationMin", Mathf.Pow(2f, eyeAdaptation.min));
				material.SetFloat("_AdaptationMax", Mathf.Pow(2f, eyeAdaptation.max));
				material.SetTexture("_LumTex", m_SmallAdaptiveRt);
				material.EnableKeyword("ENABLE_EYE_ADAPTATION");
			}
			int num5 = 4;
			if (tonemapping.enabled)
			{
				if (tonemapping.tonemapper == Tonemapper.Curve)
				{
					if (m_TonemapperDirty)
					{
						float num6 = 1f;
						if (tonemapping.curve.length > 0)
						{
							num6 = tonemapping.curve[tonemapping.curve.length - 1].time;
							for (float num7 = 0f; num7 <= 1f; num7 += 0.003921569f)
							{
								float num8 = tonemapping.curve.Evaluate(num7 * num6);
								tonemapperCurve.SetPixel(Mathf.FloorToInt(num7 * 255f), 0, new Color(num8, num8, num8));
							}
							tonemapperCurve.Apply();
						}
						m_TonemapperCurveRange = 1f / num6;
						m_TonemapperDirty = false;
					}
					material.SetFloat("_ToneCurveRange", m_TonemapperCurveRange);
					material.SetTexture("_ToneCurve", tonemapperCurve);
				}
				else if (tonemapping.tonemapper == Tonemapper.Neutral)
				{
					float num9 = tonemapping.neutralBlackIn * 20f + 1f;
					float num10 = tonemapping.neutralBlackOut * 10f + 1f;
					float num11 = tonemapping.neutralWhiteIn / 20f;
					float num12 = 1f - tonemapping.neutralWhiteOut / 20f;
					float t = num9 / num10;
					float t2 = num11 / num12;
					float y = Mathf.Max(0f, Mathf.LerpUnclamped(0.57f, 0.37f, t));
					float z = Mathf.LerpUnclamped(0.01f, 0.24f, t2);
					float w2 = Mathf.Max(0f, Mathf.LerpUnclamped(0.02f, 0.2f, t));
					material.SetVector("_NeutralTonemapperParams1", new Vector4(0.2f, y, z, w2));
					material.SetVector("_NeutralTonemapperParams2", new Vector4(0.02f, 0.3f, tonemapping.neutralWhiteLevel, tonemapping.neutralWhiteClip / 10f));
				}
				material.SetFloat("_Exposure", tonemapping.exposure);
				num5 = (int)(num5 + (tonemapping.tonemapper + 1));
			}
			if (lut.enabled)
			{
				Texture texture2 = lut.texture;
				if (lut.texture == null || !CheckUserLut())
				{
					texture2 = identityLut;
				}
				texture = texture2;
				w = lut.contribution;
				material.EnableKeyword("ENABLE_COLOR_GRADING");
			}
			if (colorGrading.enabled)
			{
				if (m_Dirty || !m_InternalLut.IsCreated())
				{
					if (texture == null)
					{
						material.SetVector("_UserLutParams", new Vector4(1f / (float)identityLut.width, 1f / (float)identityLut.height, (float)identityLut.height - 1f, 1f));
						material.SetTexture("_UserLutTex", identityLut);
					}
					else
					{
						material.SetVector("_UserLutParams", new Vector4(1f / (float)texture.width, 1f / (float)texture.height, (float)texture.height - 1f, lut.contribution));
						material.SetTexture("_UserLutTex", texture);
					}
					GenerateLiftGammaGain(out var lift, out var gamma, out var gain);
					GenCurveTexture();
					material.SetVector("_WhiteBalance", GetWhiteBalance());
					material.SetVector("_Lift", lift);
					material.SetVector("_Gamma", gamma);
					material.SetVector("_Gain", gain);
					material.SetVector("_ContrastGainGamma", new Vector3(colorGrading.basics.contrast, colorGrading.basics.gain, 1f / colorGrading.basics.gamma));
					material.SetFloat("_Vibrance", colorGrading.basics.vibrance);
					material.SetVector("_HSV", new Vector4(colorGrading.basics.hue, colorGrading.basics.saturation, colorGrading.basics.value));
					material.SetVector("_ChannelMixerRed", colorGrading.channelMixer.channels[0]);
					material.SetVector("_ChannelMixerGreen", colorGrading.channelMixer.channels[1]);
					material.SetVector("_ChannelMixerBlue", colorGrading.channelMixer.channels[2]);
					material.SetTexture("_CurveTex", curveTexture);
					internalLutRt.MarkRestoreExpected();
					Graphics.Blit(identityLut, internalLutRt, material, 0);
					m_Dirty = false;
				}
				texture = internalLutRt;
				w = 1f;
				material.EnableKeyword("ENABLE_COLOR_GRADING");
				if (colorGrading.useDithering)
				{
					material.EnableKeyword("ENABLE_DITHERING");
				}
			}
			if (texture != null)
			{
				material.SetTexture("_LutTex", texture);
				material.SetVector("_LutParams", new Vector4(1f / (float)texture.width, 1f / (float)texture.height, (float)texture.height - 1f, w));
			}
			material.SetFloat("_MonochromeAmount", MonochromeAmount);
			Graphics.Blit(source, destination, material, num5);
			if (eyeAdaptation.enabled)
			{
				for (int k = 0; k < array.Length; k++)
				{
					RenderTexture.ReleaseTemporary(array[k]);
				}
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		public Texture2D BakeLUT()
		{
			Texture2D texture2D = new Texture2D(internalLutRt.width, internalLutRt.height, TextureFormat.RGB24, mipmap: false, linear: true);
			RenderTexture.active = internalLutRt;
			texture2D.ReadPixels(new Rect(0f, 0f, texture2D.width, texture2D.height), 0, 0);
			RenderTexture.active = null;
			return texture2D;
		}
	}
}
namespace UnityStandardAssets.ImageEffects
{
	public enum AAMode
	{
		FXAA2,
		FXAA3Console,
		FXAA1PresetA,
		FXAA1PresetB,
		NFAA,
		SSAA,
		DLAA
	}
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Other/Antialiasing")]
	[ExecuteInEditMode]
	public class Antialiasing : PostEffectsBase
	{
		public AAMode mode = AAMode.FXAA3Console;

		public bool showGeneratedNormals;

		public float offsetScale = 0.2f;

		public float blurRadius = 18f;

		public float edgeThresholdMin = 0.05f;

		public float edgeThreshold = 0.2f;

		public float edgeSharpness = 4f;

		public bool dlaaSharp;

		public Shader ssaaShader;

		private Material ssaa;

		public Shader dlaaShader;

		private Material dlaa;

		public Shader nfaaShader;

		private Material nfaa;

		public Shader shaderFXAAPreset2;

		private Material materialFXAAPreset2;

		public Shader shaderFXAAPreset3;

		private Material materialFXAAPreset3;

		public Shader shaderFXAAII;

		private Material materialFXAAII;

		public Shader shaderFXAAIII;

		private Material materialFXAAIII;

		public Material CurrentAAMaterial()
		{
			Material material = null;
			return mode switch
			{
				AAMode.FXAA3Console => materialFXAAIII, 
				AAMode.FXAA2 => materialFXAAII, 
				AAMode.FXAA1PresetA => materialFXAAPreset2, 
				AAMode.FXAA1PresetB => materialFXAAPreset3, 
				AAMode.NFAA => nfaa, 
				AAMode.SSAA => ssaa, 
				AAMode.DLAA => dlaa, 
				_ => null, 
			};
		}

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			materialFXAAPreset2 = CreateMaterial(shaderFXAAPreset2, materialFXAAPreset2);
			materialFXAAPreset3 = CreateMaterial(shaderFXAAPreset3, materialFXAAPreset3);
			materialFXAAII = CreateMaterial(shaderFXAAII, materialFXAAII);
			materialFXAAIII = CreateMaterial(shaderFXAAIII, materialFXAAIII);
			nfaa = CreateMaterial(nfaaShader, nfaa);
			ssaa = CreateMaterial(ssaaShader, ssaa);
			dlaa = CreateMaterial(dlaaShader, dlaa);
			if (!ssaaShader.isSupported)
			{
				NotSupported();
				ReportAutoDisable();
			}
			return isSupported;
		}

		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
			}
			else if (mode == AAMode.FXAA3Console && materialFXAAIII != null)
			{
				materialFXAAIII.SetFloat("_EdgeThresholdMin", edgeThresholdMin);
				materialFXAAIII.SetFloat("_EdgeThreshold", edgeThreshold);
				materialFXAAIII.SetFloat("_EdgeSharpness", edgeSharpness);
				Graphics.Blit(source, destination, materialFXAAIII);
			}
			else if (mode == AAMode.FXAA1PresetB && materialFXAAPreset3 != null)
			{
				Graphics.Blit(source, destination, materialFXAAPreset3);
			}
			else if (mode == AAMode.FXAA1PresetA && materialFXAAPreset2 != null)
			{
				source.anisoLevel = 4;
				Graphics.Blit(source, destination, materialFXAAPreset2);
				source.anisoLevel = 0;
			}
			else if (mode == AAMode.FXAA2 && materialFXAAII != null)
			{
				Graphics.Blit(source, destination, materialFXAAII);
			}
			else if (mode == AAMode.SSAA && ssaa != null)
			{
				Graphics.Blit(source, destination, ssaa);
			}
			else if (mode == AAMode.DLAA && dlaa != null)
			{
				source.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(source.width, source.height);
				Graphics.Blit(source, temporary, dlaa, 0);
				Graphics.Blit(temporary, destination, dlaa, (!dlaaSharp) ? 1 : 2);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (mode == AAMode.NFAA && nfaa != null)
			{
				source.anisoLevel = 0;
				nfaa.SetFloat("_OffsetScale", offsetScale);
				nfaa.SetFloat("_BlurRadius", blurRadius);
				Graphics.Blit(source, destination, nfaa, showGeneratedNormals ? 1 : 0);
			}
			else
			{
				Graphics.Blit(source, destination);
			}
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom")]
	[RequireComponent(typeof(Camera))]
	public class Bloom : PostEffectsBase
	{
		public enum LensFlareStyle
		{
			Ghosting,
			Anamorphic,
			Combined
		}

		public enum TweakMode
		{
			Basic,
			Complex
		}

		public enum HDRBloomMode
		{
			Auto,
			On,
			Off
		}

		public enum BloomScreenBlendMode
		{
			Screen,
			Add
		}

		public enum BloomQuality
		{
			Cheap,
			High
		}

		public TweakMode tweakMode;

		public BloomScreenBlendMode screenBlendMode = BloomScreenBlendMode.Add;

		public HDRBloomMode hdr;

		private bool doHdr;

		public float sepBlurSpread = 2.5f;

		public BloomQuality quality = BloomQuality.High;

		public float bloomIntensity = 0.5f;

		public float bloomThreshold = 0.5f;

		public Color bloomThresholdColor = Color.white;

		public int bloomBlurIterations = 2;

		public int hollywoodFlareBlurIterations = 2;

		public float flareRotation;

		public LensFlareStyle lensflareMode = LensFlareStyle.Anamorphic;

		public float hollyStretchWidth = 2.5f;

		public float lensflareIntensity;

		public float lensflareThreshold = 0.3f;

		public float lensFlareSaturation = 0.75f;

		public Color flareColorA = new Color(0.4f, 0.4f, 0.8f, 0.75f);

		public Color flareColorB = new Color(0.4f, 0.8f, 0.8f, 0.75f);

		public Color flareColorC = new Color(0.8f, 0.4f, 0.8f, 0.75f);

		public Color flareColorD = new Color(0.8f, 0.4f, 0f, 0.75f);

		public Texture2D lensFlareVignetteMask;

		public Shader lensFlareShader;

		private Material lensFlareMaterial;

		public Shader screenBlendShader;

		private Material screenBlend;

		public Shader blurAndFlaresShader;

		private Material blurAndFlaresMaterial;

		public Shader brightPassFilterShader;

		private Material brightPassFilterMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			screenBlend = CheckShaderAndCreateMaterial(screenBlendShader, screenBlend);
			lensFlareMaterial = CheckShaderAndCreateMaterial(lensFlareShader, lensFlareMaterial);
			blurAndFlaresMaterial = CheckShaderAndCreateMaterial(blurAndFlaresShader, blurAndFlaresMaterial);
			brightPassFilterMaterial = CheckShaderAndCreateMaterial(brightPassFilterShader, brightPassFilterMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			doHdr = false;
			if (hdr == HDRBloomMode.Auto)
			{
				doHdr = source.format == RenderTextureFormat.ARGBHalf && GetComponent<Camera>().hdr;
			}
			else
			{
				doHdr = hdr == HDRBloomMode.On;
			}
			doHdr = doHdr && supportHDRTextures;
			BloomScreenBlendMode bloomScreenBlendMode = screenBlendMode;
			if (doHdr)
			{
				bloomScreenBlendMode = BloomScreenBlendMode.Add;
			}
			RenderTextureFormat format = ((!doHdr) ? RenderTextureFormat.Default : RenderTextureFormat.ARGBHalf);
			int width = source.width / 2;
			int height = source.height / 2;
			int width2 = source.width / 4;
			int height2 = source.height / 4;
			float num = 1f * (float)source.width / (1f * (float)source.height);
			float num2 = 0.001953125f;
			RenderTexture temporary = RenderTexture.GetTemporary(width2, height2, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, format);
			if (quality > BloomQuality.Cheap)
			{
				Graphics.Blit(source, temporary2, screenBlend, 2);
				RenderTexture temporary3 = RenderTexture.GetTemporary(width2, height2, 0, format);
				Graphics.Blit(temporary2, temporary3, screenBlend, 2);
				Graphics.Blit(temporary3, temporary, screenBlend, 6);
				RenderTexture.ReleaseTemporary(temporary3);
			}
			else
			{
				Graphics.Blit(source, temporary2);
				Graphics.Blit(temporary2, temporary, screenBlend, 6);
			}
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width2, height2, 0, format);
			BrightFilter(bloomThreshold * bloomThresholdColor, temporary, renderTexture);
			if (bloomBlurIterations < 1)
			{
				bloomBlurIterations = 1;
			}
			else if (bloomBlurIterations > 10)
			{
				bloomBlurIterations = 10;
			}
			for (int i = 0; i < bloomBlurIterations; i++)
			{
				float num3 = (1f + (float)i * 0.25f) * sepBlurSpread;
				RenderTexture temporary4 = RenderTexture.GetTemporary(width2, height2, 0, format);
				blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(0f, num3 * num2, 0f, 0f));
				Graphics.Blit(renderTexture, temporary4, blurAndFlaresMaterial, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				temporary4 = RenderTexture.GetTemporary(width2, height2, 0, format);
				blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num3 / num * num2, 0f, 0f, 0f));
				Graphics.Blit(renderTexture, temporary4, blurAndFlaresMaterial, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				if (quality > BloomQuality.Cheap)
				{
					if (i == 0)
					{
						Graphics.SetRenderTarget(temporary);
						GL.Clear(clearDepth: false, clearColor: true, Color.black);
						Graphics.Blit(renderTexture, temporary);
					}
					else
					{
						temporary.MarkRestoreExpected();
						Graphics.Blit(renderTexture, temporary, screenBlend, 10);
					}
				}
			}
			if (quality > BloomQuality.Cheap)
			{
				Graphics.SetRenderTarget(renderTexture);
				GL.Clear(clearDepth: false, clearColor: true, Color.black);
				Graphics.Blit(temporary, renderTexture, screenBlend, 6);
			}
			if (lensflareIntensity > Mathf.Epsilon)
			{
				RenderTexture temporary5 = RenderTexture.GetTemporary(width2, height2, 0, format);
				if (lensflareMode == LensFlareStyle.Ghosting)
				{
					BrightFilter(lensflareThreshold, renderTexture, temporary5);
					if (quality > BloomQuality.Cheap)
					{
						blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(0f, 1.5f / (1f * (float)temporary.height), 0f, 0f));
						Graphics.SetRenderTarget(temporary);
						GL.Clear(clearDepth: false, clearColor: true, Color.black);
						Graphics.Blit(temporary5, temporary, blurAndFlaresMaterial, 4);
						blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(1.5f / (1f * (float)temporary.width), 0f, 0f, 0f));
						Graphics.SetRenderTarget(temporary5);
						GL.Clear(clearDepth: false, clearColor: true, Color.black);
						Graphics.Blit(temporary, temporary5, blurAndFlaresMaterial, 4);
					}
					Vignette(0.975f, temporary5, temporary5);
					BlendFlares(temporary5, renderTexture);
				}
				else
				{
					float num4 = 1f * Mathf.Cos(flareRotation);
					float num5 = 1f * Mathf.Sin(flareRotation);
					float num6 = hollyStretchWidth * 1f / num * num2;
					blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num4, num5, 0f, 0f));
					blurAndFlaresMaterial.SetVector("_Threshhold", new Vector4(lensflareThreshold, 1f, 0f, 0f));
					blurAndFlaresMaterial.SetVector("_TintColor", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * flareColorA.a * lensflareIntensity);
					blurAndFlaresMaterial.SetFloat("_Saturation", lensFlareSaturation);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, blurAndFlaresMaterial, 2);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, blurAndFlaresMaterial, 3);
					blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num4 * num6, num5 * num6, 0f, 0f));
					blurAndFlaresMaterial.SetFloat("_StretchWidth", hollyStretchWidth);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, blurAndFlaresMaterial, 1);
					blurAndFlaresMaterial.SetFloat("_StretchWidth", hollyStretchWidth * 2f);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, blurAndFlaresMaterial, 1);
					blurAndFlaresMaterial.SetFloat("_StretchWidth", hollyStretchWidth * 4f);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, blurAndFlaresMaterial, 1);
					for (int j = 0; j < hollywoodFlareBlurIterations; j++)
					{
						num6 = hollyStretchWidth * 2f / num * num2;
						blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num6 * num4, num6 * num5, 0f, 0f));
						temporary5.DiscardContents();
						Graphics.Blit(temporary, temporary5, blurAndFlaresMaterial, 4);
						blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num6 * num4, num6 * num5, 0f, 0f));
						temporary.DiscardContents();
						Graphics.Blit(temporary5, temporary, blurAndFlaresMaterial, 4);
					}
					if (lensflareMode == LensFlareStyle.Anamorphic)
					{
						AddTo(1f, temporary, renderTexture);
					}
					else
					{
						Vignette(1f, temporary, temporary5);
						BlendFlares(temporary5, temporary);
						AddTo(1f, temporary, renderTexture);
					}
				}
				RenderTexture.ReleaseTemporary(temporary5);
			}
			int pass = (int)bloomScreenBlendMode;
			screenBlend.SetFloat("_Intensity", bloomIntensity);
			screenBlend.SetTexture("_ColorBuffer", source);
			if (quality > BloomQuality.Cheap)
			{
				RenderTexture temporary6 = RenderTexture.GetTemporary(width, height, 0, format);
				Graphics.Blit(renderTexture, temporary6);
				Graphics.Blit(temporary6, destination, screenBlend, pass);
				RenderTexture.ReleaseTemporary(temporary6);
			}
			else
			{
				Graphics.Blit(renderTexture, destination, screenBlend, pass);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
			screenBlend.SetFloat("_Intensity", intensity_);
			to.MarkRestoreExpected();
			Graphics.Blit(from, to, screenBlend, 9);
		}

		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
			lensFlareMaterial.SetVector("colorA", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorB", new Vector4(flareColorB.r, flareColorB.g, flareColorB.b, flareColorB.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorC", new Vector4(flareColorC.r, flareColorC.g, flareColorC.b, flareColorC.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorD", new Vector4(flareColorD.r, flareColorD.g, flareColorD.b, flareColorD.a) * lensflareIntensity);
			to.MarkRestoreExpected();
			Graphics.Blit(from, to, lensFlareMaterial);
		}

		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
			brightPassFilterMaterial.SetVector("_Threshhold", new Vector4(thresh, thresh, thresh, thresh));
			Graphics.Blit(from, to, brightPassFilterMaterial, 0);
		}

		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
			brightPassFilterMaterial.SetVector("_Threshhold", threshColor);
			Graphics.Blit(from, to, brightPassFilterMaterial, 1);
		}

		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
			if ((bool)lensFlareVignetteMask)
			{
				screenBlend.SetTexture("_ColorBuffer", lensFlareVignetteMask);
				to.MarkRestoreExpected();
				Graphics.Blit((!(from == to)) ? from : null, to, screenBlend, (!(from == to)) ? 3 : 7);
			}
			else if (from != to)
			{
				Graphics.SetRenderTarget(to);
				GL.Clear(clearDepth: false, clearColor: true, Color.black);
				Graphics.Blit(from, to);
			}
		}
	}
	public enum LensflareStyle34
	{
		Ghosting,
		Anamorphic,
		Combined
	}
	public enum TweakMode34
	{
		Basic,
		Complex
	}
	public enum HDRBloomMode
	{
		Auto,
		On,
		Off
	}
	public enum BloomScreenBlendMode
	{
		Screen,
		Add
	}
	[AddComponentMenu("Image Effects/Bloom and Glow/BloomAndFlares (3.5, Deprecated)")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class BloomAndFlares : PostEffectsBase
	{
		public TweakMode34 tweakMode;

		public BloomScreenBlendMode screenBlendMode = BloomScreenBlendMode.Add;

		public HDRBloomMode hdr;

		private bool doHdr;

		public float sepBlurSpread = 1.5f;

		public float useSrcAlphaAsMask = 0.5f;

		public float bloomIntensity = 1f;

		public float bloomThreshold = 0.5f;

		public int bloomBlurIterations = 2;

		public bool lensflares;

		public int hollywoodFlareBlurIterations = 2;

		public LensflareStyle34 lensflareMode = LensflareStyle34.Anamorphic;

		public float hollyStretchWidth = 3.5f;

		public float lensflareIntensity = 1f;

		public float lensflareThreshold = 0.3f;

		public Color flareColorA = new Color(0.4f, 0.4f, 0.8f, 0.75f);

		public Color flareColorB = new Color(0.4f, 0.8f, 0.8f, 0.75f);

		public Color flareColorC = new Color(0.8f, 0.4f, 0.8f, 0.75f);

		public Color flareColorD = new Color(0.8f, 0.4f, 0f, 0.75f);

		public Texture2D lensFlareVignetteMask;

		public Shader lensFlareShader;

		private Material lensFlareMaterial;

		public Shader vignetteShader;

		private Material vignetteMaterial;

		public Shader separableBlurShader;

		private Material separableBlurMaterial;

		public Shader addBrightStuffOneOneShader;

		private Material addBrightStuffBlendOneOneMaterial;

		public Shader screenBlendShader;

		private Material screenBlend;

		public Shader hollywoodFlaresShader;

		private Material hollywoodFlaresMaterial;

		public Shader brightPassFilterShader;

		private Material brightPassFilterMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			screenBlend = CheckShaderAndCreateMaterial(screenBlendShader, screenBlend);
			lensFlareMaterial = CheckShaderAndCreateMaterial(lensFlareShader, lensFlareMaterial);
			vignetteMaterial = CheckShaderAndCreateMaterial(vignetteShader, vignetteMaterial);
			separableBlurMaterial = CheckShaderAndCreateMaterial(separableBlurShader, separableBlurMaterial);
			addBrightStuffBlendOneOneMaterial = CheckShaderAndCreateMaterial(addBrightStuffOneOneShader, addBrightStuffBlendOneOneMaterial);
			hollywoodFlaresMaterial = CheckShaderAndCreateMaterial(hollywoodFlaresShader, hollywoodFlaresMaterial);
			brightPassFilterMaterial = CheckShaderAndCreateMaterial(brightPassFilterShader, brightPassFilterMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			doHdr = false;
			if (hdr == HDRBloomMode.Auto)
			{
				doHdr = source.format == RenderTextureFormat.ARGBHalf && GetComponent<Camera>().hdr;
			}
			else
			{
				doHdr = hdr == HDRBloomMode.On;
			}
			doHdr = doHdr && supportHDRTextures;
			BloomScreenBlendMode pass = screenBlendMode;
			if (doHdr)
			{
				pass = BloomScreenBlendMode.Add;
			}
			RenderTextureFormat format = ((!doHdr) ? RenderTextureFormat.Default : RenderTextureFormat.ARGBHalf);
			RenderTexture temporary = RenderTexture.GetTemporary(source.width / 2, source.height / 2, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0, format);
			float num = 1f * (float)source.width / (1f * (float)source.height);
			float num2 = 0.001953125f;
			Graphics.Blit(source, temporary, screenBlend, 2);
			Graphics.Blit(temporary, temporary2, screenBlend, 2);
			RenderTexture.ReleaseTemporary(temporary);
			BrightFilter(bloomThreshold, useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (bloomBlurIterations < 1)
			{
				bloomBlurIterations = 1;
			}
			for (int i = 0; i < bloomBlurIterations; i++)
			{
				float num3 = (1f + (float)i * 0.5f) * sepBlurSpread;
				separableBlurMaterial.SetVector("offsets", new Vector4(0f, num3 * num2, 0f, 0f));
				RenderTexture renderTexture = ((i != 0) ? temporary2 : temporary3);
				Graphics.Blit(renderTexture, temporary4, separableBlurMaterial);
				renderTexture.DiscardContents();
				separableBlurMaterial.SetVector("offsets", new Vector4(num3 / num * num2, 0f, 0f, 0f));
				Graphics.Blit(temporary4, temporary2, separableBlurMaterial);
				temporary4.DiscardContents();
			}
			if (lensflares)
			{
				if (lensflareMode == LensflareStyle34.Ghosting)
				{
					BrightFilter(lensflareThreshold, 0f, temporary2, temporary4);
					temporary2.DiscardContents();
					Vignette(0.975f, temporary4, temporary3);
					temporary4.DiscardContents();
					BlendFlares(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					hollywoodFlaresMaterial.SetVector("_threshold", new Vector4(lensflareThreshold, 1f / (1f - lensflareThreshold), 0f, 0f));
					hollywoodFlaresMaterial.SetVector("tintColor", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * flareColorA.a * lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, hollywoodFlaresMaterial, 2);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, hollywoodFlaresMaterial, 3);
					temporary3.DiscardContents();
					hollywoodFlaresMaterial.SetVector("offsets", new Vector4(sepBlurSpread * 1f / num * num2, 0f, 0f, 0f));
					hollywoodFlaresMaterial.SetFloat("stretchWidth", hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, hollywoodFlaresMaterial, 1);
					temporary4.DiscardContents();
					hollywoodFlaresMaterial.SetFloat("stretchWidth", hollyStretchWidth * 2f);
					Graphics.Blit(temporary3, temporary4, hollywoodFlaresMaterial, 1);
					temporary3.DiscardContents();
					hollywoodFlaresMaterial.SetFloat("stretchWidth", hollyStretchWidth * 4f);
					Graphics.Blit(temporary4, temporary3, hollywoodFlaresMaterial, 1);
					temporary4.DiscardContents();
					if (lensflareMode == LensflareStyle34.Anamorphic)
					{
						for (int j = 0; j < hollywoodFlareBlurIterations; j++)
						{
							separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary3, temporary4, separableBlurMaterial);
							temporary3.DiscardContents();
							separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary4, temporary3, separableBlurMaterial);
							temporary4.DiscardContents();
						}
						AddTo(1f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 0; k < hollywoodFlareBlurIterations; k++)
						{
							separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary3, temporary4, separableBlurMaterial);
							temporary3.DiscardContents();
							separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary4, temporary3, separableBlurMaterial);
							temporary4.DiscardContents();
						}
						Vignette(1f, temporary3, temporary4);
						temporary3.DiscardContents();
						BlendFlares(temporary4, temporary3);
						temporary4.DiscardContents();
						AddTo(1f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			screenBlend.SetFloat("_Intensity", bloomIntensity);
			screenBlend.SetTexture("_ColorBuffer", source);
			Graphics.Blit(temporary2, destination, screenBlend, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
			addBrightStuffBlendOneOneMaterial.SetFloat("_Intensity", intensity_);
			Graphics.Blit(from, to, addBrightStuffBlendOneOneMaterial);
		}

		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
			lensFlareMaterial.SetVector("colorA", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorB", new Vector4(flareColorB.r, flareColorB.g, flareColorB.b, flareColorB.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorC", new Vector4(flareColorC.r, flareColorC.g, flareColorC.b, flareColorC.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorD", new Vector4(flareColorD.r, flareColorD.g, flareColorD.b, flareColorD.a) * lensflareIntensity);
			Graphics.Blit(from, to, lensFlareMaterial);
		}

		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
			if (doHdr)
			{
				brightPassFilterMaterial.SetVector("threshold", new Vector4(thresh, 1f, 0f, 0f));
			}
			else
			{
				brightPassFilterMaterial.SetVector("threshold", new Vector4(thresh, 1f / (1f - thresh), 0f, 0f));
			}
			brightPassFilterMaterial.SetFloat("useSrcAlphaAsMask", useAlphaAsMask);
			Graphics.Blit(from, to, brightPassFilterMaterial);
		}

		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
			if ((bool)lensFlareVignetteMask)
			{
				screenBlend.SetTexture("_ColorBuffer", lensFlareVignetteMask);
				Graphics.Blit(from, to, screenBlend, 3);
			}
			else
			{
				vignetteMaterial.SetFloat("vignetteIntensity", amount);
				Graphics.Blit(from, to, vignetteMaterial);
			}
		}
	}
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom (Optimized)")]
	public class BloomOptimized : PostEffectsBase
	{
		public enum Resolution
		{
			Low,
			High
		}

		public enum BlurType
		{
			Standard,
			Sgx
		}

		[Range(0f, 1.5f)]
		public float threshold = 0.25f;

		[Range(0f, 2.5f)]
		public float intensity = 0.75f;

		[Range(0.25f, 5.5f)]
		public float blurSize = 1f;

		private Resolution resolution;

		[Range(1f, 4f)]
		public int blurIterations = 1;

		public BlurType blurType;

		public Shader fastBloomShader;

		private Material fastBloomMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			fastBloomMaterial = CheckShaderAndCreateMaterial(fastBloomShader, fastBloomMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnDisable()
		{
			if ((bool)fastBloomMaterial)
			{
				UnityEngine.Object.DestroyImmediate(fastBloomMaterial);
			}
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			int num = ((resolution != Resolution.Low) ? 2 : 4);
			float num2 = ((resolution != Resolution.Low) ? 1f : 0.5f);
			fastBloomMaterial.SetVector("_Parameter", new Vector4(blurSize * num2, 0f, threshold, intensity));
			source.filterMode = FilterMode.Bilinear;
			int width = source.width / num;
			int height = source.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, source.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, fastBloomMaterial, 1);
			int num3 = ((blurType != BlurType.Standard) ? 2 : 0);
			for (int i = 0; i < blurIterations; i++)
			{
				fastBloomMaterial.SetVector("_Parameter", new Vector4(blurSize * num2 + (float)i * 1f, 0f, threshold, intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, source.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, fastBloomMaterial, 2 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, source.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, fastBloomMaterial, 3 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			fastBloomMaterial.SetTexture("_Bloom", renderTexture);
			Graphics.Blit(source, destination, fastBloomMaterial, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Blur/Blur")]
	public class Blur : MonoBehaviour
	{
		[Range(0f, 10f)]
		public int iterations = 3;

		[Range(0f, 1f)]
		public float blurSpread = 0.6f;

		public Shader blurShader;

		private static Material m_Material;

		protected Material material
		{
			get
			{
				if (m_Material == null)
				{
					m_Material = new Material(blurShader);
					m_Material.hideFlags = HideFlags.DontSave;
				}
				return m_Material;
			}
		}

		protected void OnDisable()
		{
			if ((bool)m_Material)
			{
				UnityEngine.Object.DestroyImmediate(m_Material);
			}
		}

		protected void Start()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
			}
			else if (!blurShader || !material.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
			float num = 0.5f + (float)iteration * blurSpread;
			Graphics.BlitMultiTap(source, dest, material, new Vector2(0f - num, 0f - num), new Vector2(0f - num, num), new Vector2(num, num), new Vector2(num, 0f - num));
		}

		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
			float num = 1f;
			Graphics.BlitMultiTap(source, dest, material, new Vector2(0f - num, 0f - num), new Vector2(0f - num, num), new Vector2(num, num), new Vector2(num, 0f - num));
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			int width = source.width / 4;
			int height = source.height / 4;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0);
			DownSample4x(source, renderTexture);
			for (int i = 0; i < iterations; i++)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				FourTapCone(renderTexture, temporary, i);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, destination);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Blur/Blur (Optimized)")]
	[RequireComponent(typeof(Camera))]
	public class BlurOptimized : PostEffectsBase
	{
		public enum BlurType
		{
			StandardGauss,
			SgxGauss
		}

		[Range(0f, 2f)]
		public int downsample = 1;

		[Range(0f, 10f)]
		public float blurSize = 3f;

		[Range(1f, 4f)]
		public int blurIterations = 2;

		public BlurType blurType;

		public Shader blurShader;

		private Material blurMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			blurMaterial = CheckShaderAndCreateMaterial(blurShader, blurMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		public void OnDisable()
		{
			if ((bool)blurMaterial)
			{
				UnityEngine.Object.DestroyImmediate(blurMaterial);
			}
		}

		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			float num = 1f / (1f * (float)(1 << downsample));
			blurMaterial.SetVector("_Parameter", new Vector4(blurSize * num, (0f - blurSize) * num, 0f, 0f));
			source.filterMode = FilterMode.Bilinear;
			int width = source.width >> downsample;
			int height = source.height >> downsample;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, source.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, blurMaterial, 0);
			int num2 = ((blurType != BlurType.StandardGauss) ? 2 : 0);
			for (int i = 0; i < blurIterations; i++)
			{
				float num3 = (float)i * 1f;
				blurMaterial.SetVector("_Parameter", new Vector4(blurSize * num + num3, (0f - blurSize) * num - num3, 0f, 0f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, source.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, blurMaterial, 1 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, source.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, blurMaterial, 2 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, destination);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[AddComponentMenu("Image Effects/Camera/Camera Motion Blur")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class CameraMotionBlur : PostEffectsBase
	{
		public enum MotionBlurFilter
		{
			CameraMotion,
			LocalBlur,
			Reconstruction,
			ReconstructionDX11,
			ReconstructionDisc
		}

		private static float MAX_RADIUS = 10f;

		public MotionBlurFilter filterType = MotionBlurFilter.Reconstruction;

		public bool preview;

		public Vector3 previewScale = Vector3.one;

		public float movementScale;

		public float rotationScale = 1f;

		public float maxVelocity = 8f;

		public float minVelocity = 0.1f;

		public float velocityScale = 0.375f;

		public float softZDistance = 0.005f;

		public int velocityDownsample = 1;

		public LayerMask excludeLayers = 0;

		private GameObject tmpCam;

		public Shader shader;

		public Shader dx11MotionBlurShader;

		public Shader replacementClear;

		private Material motionBlurMaterial;

		private Material dx11MotionBlurMaterial;

		public Texture2D noiseTexture;

		public float jitter = 0.05f;

		public bool showVelocity;

		public float showVelocityScale = 1f;

		private Matrix4x4 currentViewProjMat;

		private Matrix4x4[] currentStereoViewProjMat;

		private Matrix4x4 prevViewProjMat;

		private Matrix4x4[] prevStereoViewProjMat;

		private int prevFrameCount;

		private bool wasActive;

		private Vector3 prevFrameForward = Vector3.forward;

		private Vector3 prevFrameUp = Vector3.up;

		private Vector3 prevFramePos = Vector3.zero;

		private Camera _camera;

		private void CalculateViewProjection()
		{
			Matrix4x4 worldToCameraMatrix = _camera.worldToCameraMatrix;
			Matrix4x4 gPUProjectionMatrix = GL.GetGPUProjectionMatrix(_camera.projectionMatrix, renderIntoTexture: true);
			currentViewProjMat = gPUProjectionMatrix * worldToCameraMatrix;
			if (_camera.stereoEnabled)
			{
				for (int i = 0; i < 2; i++)
				{
					Matrix4x4 stereoViewMatrix = _camera.GetStereoViewMatrix((i != 0) ? Camera.StereoscopicEye.Right : Camera.StereoscopicEye.Left);
					Matrix4x4 stereoProjectionMatrix = _camera.GetStereoProjectionMatrix((i != 0) ? Camera.StereoscopicEye.Right : Camera.StereoscopicEye.Left);
					stereoProjectionMatrix = GL.GetGPUProjectionMatrix(stereoProjectionMatrix, renderIntoTexture: true);
					ref Matrix4x4 reference = ref currentStereoViewProjMat[i];
					reference = stereoProjectionMatrix * stereoViewMatrix;
				}
			}
		}

		private new void Start()
		{
			CheckResources();
			if (_camera == null)
			{
				_camera = GetComponent<Camera>();
			}
			wasActive = base.gameObject.activeInHierarchy;
			currentStereoViewProjMat = new Matrix4x4[2];
			prevStereoViewProjMat = new Matrix4x4[2];
			CalculateViewProjection();
			Remember();
			wasActive = false;
		}

		private void OnEnable()
		{
			if (_camera == null)
			{
				_camera = GetComponent<Camera>();
			}
			_camera.depthTextureMode |= DepthTextureMode.Depth;
		}

		private void OnDisable()
		{
			if (null != motionBlurMaterial)
			{
				UnityEngine.Object.DestroyImmediate(motionBlurMaterial);
				motionBlurMaterial = null;
			}
			if (null != dx11MotionBlurMaterial)
			{
				UnityEngine.Object.DestroyImmediate(dx11MotionBlurMaterial);
				dx11MotionBlurMaterial = null;
			}
			if (null != tmpCam)
			{
				UnityEngine.Object.DestroyImmediate(tmpCam);
				tmpCam = null;
			}
		}

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true, needHdr: true);
			motionBlurMaterial = CheckShaderAndCreateMaterial(shader, motionBlurMaterial);
			if (supportDX11 && filterType == MotionBlurFilter.ReconstructionDX11)
			{
				dx11MotionBlurMaterial = CheckShaderAndCreateMaterial(dx11MotionBlurShader, dx11MotionBlurMaterial);
			}
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (filterType == MotionBlurFilter.CameraMotion)
			{
				StartFrame();
			}
			RenderTextureFormat format = ((!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGHalf)) ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.RGHalf);
			RenderTexture temporary = RenderTexture.GetTemporary(divRoundUp(source.width, velocityDownsample), divRoundUp(source.height, velocityDownsample), 0, format);
			int num = 1;
			int num2 = 1;
			maxVelocity = Mathf.Max(2f, maxVelocity);
			float num3 = maxVelocity;
			bool flag = filterType == MotionBlurFilter.ReconstructionDX11 && dx11MotionBlurMaterial == null;
			if (filterType == MotionBlurFilter.Reconstruction || flag || filterType == MotionBlurFilter.ReconstructionDisc)
			{
				maxVelocity = Mathf.Min(maxVelocity, MAX_RADIUS);
				num = divRoundUp(temporary.width, (int)maxVelocity);
				num2 = divRoundUp(temporary.height, (int)maxVelocity);
				num3 = temporary.width / num;
			}
			else
			{
				num = divRoundUp(temporary.width, (int)maxVelocity);
				num2 = divRoundUp(temporary.height, (int)maxVelocity);
				num3 = temporary.width / num;
			}
			RenderTexture temporary2 = RenderTexture.GetTemporary(num, num2, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(num, num2, 0, format);
			temporary.filterMode = FilterMode.Point;
			temporary2.filterMode = FilterMode.Point;
			temporary3.filterMode = FilterMode.Point;
			if ((bool)noiseTexture)
			{
				noiseTexture.filterMode = FilterMode.Point;
			}
			source.wrapMode = TextureWrapMode.Clamp;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary3.wrapMode = TextureWrapMode.Clamp;
			temporary2.wrapMode = TextureWrapMode.Clamp;
			CalculateViewProjection();
			if (base.gameObject.activeInHierarchy && !wasActive)
			{
				Remember();
			}
			wasActive = base.gameObject.activeInHierarchy;
			Matrix4x4 matrix4x = Matrix4x4.Inverse(currentViewProjMat);
			motionBlurMaterial.SetMatrix("_InvViewProj", matrix4x);
			motionBlurMaterial.SetMatrix("_PrevViewProj", prevViewProjMat);
			motionBlurMaterial.SetMatrix("_ToPrevViewProjCombined", prevViewProjMat * matrix4x);
			if (_camera.stereoEnabled)
			{
				Matrix4x4[] array = new Matrix4x4[2]
				{
					Matrix4x4.Inverse(currentStereoViewProjMat[0]),
					Matrix4x4.Inverse(currentStereoViewProjMat[1])
				};
				Matrix4x4 matrix = prevStereoViewProjMat[0] * array[0];
				motionBlurMaterial.SetMatrix("_StereoToPrevViewProjCombined0", matrix);
				motionBlurMaterial.SetMatrix("_StereoToPrevViewProjCombined1", prevStereoViewProjMat[1] * array[1]);
			}
			motionBlurMaterial.SetFloat("_MaxVelocity", num3);
			motionBlurMaterial.SetFloat("_MaxRadiusOrKInPaper", num3);
			motionBlurMaterial.SetFloat("_MinVelocity", minVelocity);
			motionBlurMaterial.SetFloat("_VelocityScale", velocityScale);
			motionBlurMaterial.SetFloat("_Jitter", jitter);
			motionBlurMaterial.SetTexture("_NoiseTex", noiseTexture);
			motionBlurMaterial.SetTexture("_VelTex", temporary);
			motionBlurMaterial.SetTexture("_NeighbourMaxTex", temporary3);
			motionBlurMaterial.SetTexture("_TileTexDebug", temporary2);
			if (preview)
			{
				Matrix4x4 worldToCameraMatrix = _camera.worldToCameraMatrix;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.SetTRS(previewScale * 0.3333f, Quaternion.identity, Vector3.one);
				Matrix4x4 gPUProjectionMatrix = GL.GetGPUProjectionMatrix(_camera.projectionMatrix, renderIntoTexture: true);
				prevViewProjMat = gPUProjectionMatrix * identity * worldToCameraMatrix;
				motionBlurMaterial.SetMatrix("_PrevViewProj", prevViewProjMat);
				motionBlurMaterial.SetMatrix("_ToPrevViewProjCombined", prevViewProjMat * matrix4x);
			}
			if (filterType == MotionBlurFilter.CameraMotion)
			{
				Vector4 zero = Vector4.zero;
				float num4 = Vector3.Dot(base.transform.up, Vector3.up);
				Vector3 rhs = prevFramePos - base.transform.position;
				float magnitude = rhs.magnitude;
				float num5 = 1f;
				num5 = Vector3.Angle(base.transform.up, prevFrameUp) / _camera.fieldOfView * ((float)source.width * 0.75f);
				zero.x = rotationScale * num5;
				num5 = Vector3.Angle(base.transform.forward, prevFrameForward) / _camera.fieldOfView * ((float)source.width * 0.75f);
				zero.y = rotationScale * num4 * num5;
				num5 = Vector3.Angle(base.transform.forward, prevFrameForward) / _camera.fieldOfView * ((float)source.width * 0.75f);
				zero.z = rotationScale * (1f - num4) * num5;
				if (magnitude > Mathf.Epsilon && movementScale > Mathf.Epsilon)
				{
					zero.w = movementScale * Vector3.Dot(base.transform.forward, rhs) * ((float)source.width * 0.5f);
					zero.x += movementScale * Vector3.Dot(base.transform.up, rhs) * ((float)source.width * 0.5f);
					zero.y += movementScale * Vector3.Dot(base.transform.right, rhs) * ((float)source.width * 0.5f);
				}
				if (preview)
				{
					motionBlurMaterial.SetVector("_BlurDirectionPacked", new Vector4(previewScale.y, previewScale.x, 0f, previewScale.z) * 0.5f * _camera.fieldOfView);
				}
				else
				{
					motionBlurMaterial.SetVector("_BlurDirectionPacked", zero);
				}
			}
			else
			{
				Graphics.Blit(source, temporary, motionBlurMaterial, 0);
				Camera camera = null;
				if (excludeLayers.value != 0)
				{
					camera = GetTmpCam();
				}
				if ((bool)camera && excludeLayers.value != 0 && (bool)replacementClear && replacementClear.isSupported)
				{
					camera.targetTexture = temporary;
					camera.cullingMask = excludeLayers;
					camera.RenderWithShader(replacementClear, string.Empty);
				}
			}
			if (!preview && Time.frameCount != prevFrameCount)
			{
				prevFrameCount = Time.frameCount;
				Remember();
			}
			source.filterMode = FilterMode.Bilinear;
			if (showVelocity)
			{
				motionBlurMaterial.SetFloat("_DisplayVelocityScale", showVelocityScale);
				Graphics.Blit(temporary, destination, motionBlurMaterial, 1);
			}
			else if (filterType == MotionBlurFilter.ReconstructionDX11 && !flag)
			{
				dx11MotionBlurMaterial.SetFloat("_MinVelocity", minVelocity);
				dx11MotionBlurMaterial.SetFloat("_VelocityScale", velocityScale);
				dx11MotionBlurMaterial.SetFloat("_Jitter", jitter);
				dx11MotionBlurMaterial.SetTexture("_NoiseTex", noiseTexture);
				dx11MotionBlurMaterial.SetTexture("_VelTex", temporary);
				dx11MotionBlurMaterial.SetTexture("_NeighbourMaxTex", temporary3);
				dx11MotionBlurMaterial.SetFloat("_SoftZDistance", Mathf.Max(0.00025f, softZDistance));
				dx11MotionBlurMaterial.SetFloat("_MaxRadiusOrKInPaper", num3);
				Graphics.Blit(temporary, temporary2, dx11MotionBlurMaterial, 0);
				Graphics.Blit(temporary2, temporary3, dx11MotionBlurMaterial, 1);
				Graphics.Blit(source, destination, dx11MotionBlurMaterial, 2);
			}
			else if (filterType == MotionBlurFilter.Reconstruction || flag)
			{
				motionBlurMaterial.SetFloat("_SoftZDistance", Mathf.Max(0.00025f, softZDistance));
				Graphics.Blit(temporary, temporary2, motionBlurMaterial, 2);
				Graphics.Blit(temporary2, temporary3, motionBlurMaterial, 3);
				Graphics.Blit(source, destination, motionBlurMaterial, 4);
			}
			else if (filterType == MotionBlurFilter.CameraMotion)
			{
				Graphics.Blit(source, destination, motionBlurMaterial, 6);
			}
			else if (filterType == MotionBlurFilter.ReconstructionDisc)
			{
				motionBlurMaterial.SetFloat("_SoftZDistance", Mathf.Max(0.00025f, softZDistance));
				Graphics.Blit(temporary, temporary2, motionBlurMaterial, 2);
				Graphics.Blit(temporary2, temporary3, motionBlurMaterial, 3);
				Graphics.Blit(source, destination, motionBlurMaterial, 7);
			}
			else
			{
				Graphics.Blit(source, destination, motionBlurMaterial, 5);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
		}

		private void Remember()
		{
			prevViewProjMat = currentViewProjMat;
			prevFrameForward = base.transform.forward;
			prevFrameUp = base.transform.up;
			prevFramePos = base.transform.position;
			ref Matrix4x4 reference = ref prevStereoViewProjMat[0];
			reference = currentStereoViewProjMat[0];
			ref Matrix4x4 reference2 = ref prevStereoViewProjMat[1];
			reference2 = currentStereoViewProjMat[1];
		}

		private Camera GetTmpCam()
		{
			if (tmpCam == null)
			{
				string text = "_" + _camera.name + "_MotionBlurTmpCam";
				GameObject gameObject = GameObject.Find(text);
				if (null == gameObject)
				{
					tmpCam = new GameObject(text, typeof(Camera));
				}
				else
				{
					tmpCam = gameObject;
				}
			}
			tmpCam.hideFlags = HideFlags.DontSave;
			tmpCam.transform.position = _camera.transform.position;
			tmpCam.transform.rotation = _camera.transform.rotation;
			tmpCam.transform.localScale = _camera.transform.localScale;
			tmpCam.GetComponent<Camera>().CopyFrom(_camera);
			tmpCam.GetComponent<Camera>().enabled = false;
			tmpCam.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			tmpCam.GetComponent<Camera>().clearFlags = CameraClearFlags.Nothing;
			return tmpCam.GetComponent<Camera>();
		}

		private void StartFrame()
		{
			prevFramePos = Vector3.Slerp(prevFramePos, base.transform.position, 0.75f);
		}

		private static int divRoundUp(int x, int d)
		{
			return (x + d - 1) / d;
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Curves, Saturation)")]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		public enum ColorCorrectionMode
		{
			Simple,
			Advanced
		}

		public AnimationCurve redChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public AnimationCurve greenChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public AnimationCurve blueChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public bool useDepthCorrection;

		public AnimationCurve zCurve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public AnimationCurve depthRedChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public AnimationCurve depthGreenChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public AnimationCurve depthBlueChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		private Material ccMaterial;

		private Material ccDepthMaterial;

		private Material selectiveCcMaterial;

		private Texture2D rgbChannelTex;

		private Texture2D rgbDepthChannelTex;

		private Texture2D zCurveTex;

		public float saturation = 1f;

		public bool selectiveCc;

		public Color selectiveFromColor = Color.white;

		public Color selectiveToColor = Color.white;

		public ColorCorrectionMode mode;

		public bool updateTextures = true;

		public Shader colorCorrectionCurvesShader;

		public Shader simpleColorCorrectionCurvesShader;

		public Shader colorCorrectionSelectiveShader;

		private bool updateTexturesOnStartup = true;

		private new void Start()
		{
			base.Start();
			updateTexturesOnStartup = true;
		}

		private void Awake()
		{
		}

		public override bool CheckResources()
		{
			CheckSupport(mode == ColorCorrectionMode.Advanced);
			ccMaterial = CheckShaderAndCreateMaterial(simpleColorCorrectionCurvesShader, ccMaterial);
			ccDepthMaterial = CheckShaderAndCreateMaterial(colorCorrectionCurvesShader, ccDepthMaterial);
			selectiveCcMaterial = CheckShaderAndCreateMaterial(colorCorrectionSelectiveShader, selectiveCcMaterial);
			if (!rgbChannelTex)
			{
				rgbChannelTex = new Texture2D(256, 4, TextureFormat.ARGB32, mipmap: false, linear: true);
			}
			if (!rgbDepthChannelTex)
			{
				rgbDepthChannelTex = new Texture2D(256, 4, TextureFormat.ARGB32, mipmap: false, linear: true);
			}
			if (!zCurveTex)
			{
				zCurveTex = new Texture2D(256, 1, TextureFormat.ARGB32, mipmap: false, linear: true);
			}
			rgbChannelTex.hideFlags = HideFlags.DontSave;
			rgbDepthChannelTex.hideFlags = HideFlags.DontSave;
			zCurveTex.hideFlags = HideFlags.DontSave;
			rgbChannelTex.wrapMode = TextureWrapMode.Clamp;
			rgbDepthChannelTex.wrapMode = TextureWrapMode.Clamp;
			zCurveTex.wrapMode = TextureWrapMode.Clamp;
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		public void UpdateParameters()
		{
			CheckResources();
			if (redChannel != null && greenChannel != null && blueChannel != null)
			{
				for (float num = 0f; num <= 1f; num += 0.003921569f)
				{
					float num2 = Mathf.Clamp(redChannel.Evaluate(num), 0f, 1f);
					float num3 = Mathf.Clamp(greenChannel.Evaluate(num), 0f, 1f);
					float num4 = Mathf.Clamp(blueChannel.Evaluate(num), 0f, 1f);
					rgbChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 0, new Color(num2, num2, num2));
					rgbChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 1, new Color(num3, num3, num3));
					rgbChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 2, new Color(num4, num4, num4));
					float num5 = Mathf.Clamp(zCurve.Evaluate(num), 0f, 1f);
					zCurveTex.SetPixel((int)Mathf.Floor(num * 255f), 0, new Color(num5, num5, num5));
					num2 = Mathf.Clamp(depthRedChannel.Evaluate(num), 0f, 1f);
					num3 = Mathf.Clamp(depthGreenChannel.Evaluate(num), 0f, 1f);
					num4 = Mathf.Clamp(depthBlueChannel.Evaluate(num), 0f, 1f);
					rgbDepthChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 0, new Color(num2, num2, num2));
					rgbDepthChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 1, new Color(num3, num3, num3));
					rgbDepthChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 2, new Color(num4, num4, num4));
				}
				rgbChannelTex.Apply();
				rgbDepthChannelTex.Apply();
				zCurveTex.Apply();
			}
		}

		private void UpdateTextures()
		{
			UpdateParameters();
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (updateTexturesOnStartup)
			{
				UpdateParameters();
				updateTexturesOnStartup = false;
			}
			if (useDepthCorrection)
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			RenderTexture renderTexture = destination;
			if (selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(source.width, source.height);
			}
			if (useDepthCorrection)
			{
				ccDepthMaterial.SetTexture("_RgbTex", rgbChannelTex);
				ccDepthMaterial.SetTexture("_ZCurve", zCurveTex);
				ccDepthMaterial.SetTexture("_RgbDepthTex", rgbDepthChannelTex);
				ccDepthMaterial.SetFloat("_Saturation", saturation);
				Graphics.Blit(source, renderTexture, ccDepthMaterial);
			}
			else
			{
				ccMaterial.SetTexture("_RgbTex", rgbChannelTex);
				ccMaterial.SetFloat("_Saturation", saturation);
				Graphics.Blit(source, renderTexture, ccMaterial);
			}
			if (selectiveCc)
			{
				selectiveCcMaterial.SetColor("selColor", selectiveFromColor);
				selectiveCcMaterial.SetColor("targetColor", selectiveToColor);
				Graphics.Blit(renderTexture, destination, selectiveCcMaterial);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}
	}
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (3D Lookup Texture)")]
	[ExecuteInEditMode]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		public Shader shader;

		private Material material;

		public Texture3D converted3DLut;

		public string basedOnTempTex = string.Empty;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			material = CheckShaderAndCreateMaterial(shader, material);
			if (!isSupported || !SystemInfo.supports3DTextures)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnDisable()
		{
			if ((bool)material)
			{
				UnityEngine.Object.DestroyImmediate(material);
				material = null;
			}
		}

		private void OnDestroy()
		{
			if ((bool)converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(converted3DLut);
			}
			converted3DLut = null;
		}

		public void SetIdentityLut()
		{
			int num = 16;
			Color[] array = new Color[num * num * num];
			float num2 = 1f / (1f * (float)num - 1f);
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 0; k < num; k++)
					{
						ref Color reference = ref array[i + j * num + k * num * num];
						reference = new Color((float)i * 1f * num2, (float)j * 1f * num2, (float)k * 1f * num2, 1f);
					}
				}
			}
			if ((bool)converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(converted3DLut);
			}
			converted3DLut = new Texture3D(num, num, num, TextureFormat.ARGB32, mipmap: false);
			converted3DLut.SetPixels(array);
			converted3DLut.Apply();
			basedOnTempTex = string.Empty;
		}

		public bool ValidDimensions(Texture2D tex2d)
		{
			if (!tex2d)
			{
				return false;
			}
			int height = tex2d.height;
			if (height != Mathf.FloorToInt(Mathf.Sqrt(tex2d.width)))
			{
				return false;
			}
			return true;
		}

		public void Convert(Texture2D temp2DTex, string path)
		{
			if ((bool)temp2DTex)
			{
				int num = temp2DTex.width * temp2DTex.height;
				num = temp2DTex.height;
				if (!ValidDimensions(temp2DTex))
				{
					UnityEngine.Debug.LogWarning("The given 2D texture " + temp2DTex.name + " cannot be used as a 3D LUT.");
					basedOnTempTex = string.Empty;
					return;
				}
				Color[] pixels = temp2DTex.GetPixels();
				Color[] array = new Color[pixels.Length];
				for (int i = 0; i < num; i++)
				{
					for (int j = 0; j < num; j++)
					{
						for (int k = 0; k < num; k++)
						{
							int num2 = num - j - 1;
							ref Color reference = ref array[i + j * num + k * num * num];
							reference = pixels[k * num + i + num2 * num * num];
						}
					}
				}
				if ((bool)converted3DLut)
				{
					UnityEngine.Object.DestroyImmediate(converted3DLut);
				}
				converted3DLut = new Texture3D(num, num, num, TextureFormat.ARGB32, mipmap: false);
				converted3DLut.SetPixels(array);
				converted3DLut.Apply();
				basedOnTempTex = path;
			}
			else
			{
				UnityEngine.Debug.LogError("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.");
			}
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (converted3DLut == null)
			{
				SetIdentityLut();
			}
			int width = converted3DLut.width;
			converted3DLut.wrapMode = TextureWrapMode.Clamp;
			material.SetFloat("_Scale", (float)(width - 1) / (1f * (float)width));
			material.SetFloat("_Offset", 1f / (2f * (float)width));
			material.SetTexture("_ClutTex", converted3DLut);
			Graphics.Blit(source, destination, material, (QualitySettings.activeColorSpace == ColorSpace.Linear) ? 1 : 0);
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Ramp)")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		public Texture textureRamp;

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			base.material.SetTexture("_RampTex", textureRamp);
			Graphics.Blit(source, destination, base.material);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Enhance (Unsharp Mask)")]
	public class ContrastEnhance : PostEffectsBase
	{
		[Range(0f, 1f)]
		public float intensity = 0.5f;

		[Range(0f, 0.999f)]
		public float threshold;

		private Material separableBlurMaterial;

		private Material contrastCompositeMaterial;

		[Range(0f, 1f)]
		public float blurSpread = 1f;

		public Shader separableBlurShader;

		public Shader contrastCompositeShader;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			contrastCompositeMaterial = CheckShaderAndCreateMaterial(contrastCompositeShader, contrastCompositeMaterial);
			separableBlurMaterial = CheckShaderAndCreateMaterial(separableBlurShader, separableBlurMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			int width = source.width;
			int height = source.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 2, height / 2, 0);
			Graphics.Blit(source, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 4, height / 4, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			separableBlurMaterial.SetVector("offsets", new Vector4(0f, blurSpread * 1f / (float)temporary2.height, 0f, 0f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 4, height / 4, 0);
			Graphics.Blit(temporary2, temporary3, separableBlurMaterial);
			RenderTexture.ReleaseTemporary(temporary2);
			separableBlurMaterial.SetVector("offsets", new Vector4(blurSpread * 1f / (float)temporary2.width, 0f, 0f, 0f));
			temporary2 = RenderTexture.GetTemporary(width / 4, height / 4, 0);
			Graphics.Blit(temporary3, temporary2, separableBlurMaterial);
			RenderTexture.ReleaseTemporary(temporary3);
			contrastCompositeMaterial.SetTexture("_MainTexBlurred", temporary2);
			contrastCompositeMaterial.SetFloat("intensity", intensity);
			contrastCompositeMaterial.SetFloat("threshold", threshold);
			Graphics.Blit(source, destination, contrastCompositeMaterial);
			RenderTexture.ReleaseTemporary(temporary2);
		}
	}
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Stretch")]
	[ExecuteInEditMode]
	public class ContrastStretch : MonoBehaviour
	{
		[Range(0.0001f, 1f)]
		public float adaptationSpeed = 0.02f;

		[Range(0f, 1f)]
		public float limitMinimum = 0.2f;

		[Range(0f, 1f)]
		public float limitMaximum = 0.6f;

		private RenderTexture[] adaptRenderTex = new RenderTexture[2];

		private int curAdaptIndex;

		public Shader shaderLum;

		private Material m_materialLum;

		public Shader shaderReduce;

		private Material m_materialReduce;

		public Shader shaderAdapt;

		private Material m_materialAdapt;

		public Shader shaderApply;

		private Material m_materialApply;

		protected Material materialLum
		{
			get
			{
				if (m_materialLum == null)
				{
					m_materialLum = new Material(shaderLum);
					m_materialLum.hideFlags = HideFlags.HideAndDontSave;
				}
				return m_materialLum;
			}
		}

		protected Material materialReduce
		{
			get
			{
				if (m_materialReduce == null)
				{
					m_materialReduce = new Material(shaderReduce);
					m_materialReduce.hideFlags = HideFlags.HideAndDontSave;
				}
				return m_materialReduce;
			}
		}

		protected Material materialAdapt
		{
			get
			{
				if (m_materialAdapt == null)
				{
					m_materialAdapt = new Material(shaderAdapt);
					m_materialAdapt.hideFlags = HideFlags.HideAndDontSave;
				}
				return m_materialAdapt;
			}
		}

		protected Material materialApply
		{
			get
			{
				if (m_materialApply == null)
				{
					m_materialApply = new Material(shaderApply);
					m_materialApply.hideFlags = HideFlags.HideAndDontSave;
				}
				return m_materialApply;
			}
		}

		private void Start()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
			}
			else if (!shaderAdapt.isSupported || !shaderApply.isSupported || !shaderLum.isSupported || !shaderReduce.isSupported)
			{
				base.enabled = false;
			}
		}

		private void OnEnable()
		{
			for (int i = 0; i < 2; i++)
			{
				if (!adaptRenderTex[i])
				{
					adaptRenderTex[i] = new RenderTexture(1, 1, 0);
					adaptRenderTex[i].hideFlags = HideFlags.HideAndDontSave;
				}
			}
		}

		private void OnDisable()
		{
			for (int i = 0; i < 2; i++)
			{
				UnityEngine.Object.DestroyImmediate(adaptRenderTex[i]);
				adaptRenderTex[i] = null;
			}
			if ((bool)m_materialLum)
			{
				UnityEngine.Object.DestroyImmediate(m_materialLum);
			}
			if ((bool)m_materialReduce)
			{
				UnityEngine.Object.DestroyImmediate(m_materialReduce);
			}
			if ((bool)m_materialAdapt)
			{
				UnityEngine.Object.DestroyImmediate(m_materialAdapt);
			}
			if ((bool)m_materialApply)
			{
				UnityEngine.Object.DestroyImmediate(m_materialApply);
			}
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(source.width / 1, source.height / 1);
			Graphics.Blit(source, renderTexture, materialLum);
			while (renderTexture.width > 1 || renderTexture.height > 1)
			{
				int num = renderTexture.width / 2;
				if (num < 1)
				{
					num = 1;
				}
				int num2 = renderTexture.height / 2;
				if (num2 < 1)
				{
					num2 = 1;
				}
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2);
				Graphics.Blit(renderTexture, temporary, materialReduce);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			CalculateAdaptation(renderTexture);
			materialApply.SetTexture("_AdaptTex", adaptRenderTex[curAdaptIndex]);
			Graphics.Blit(source, destination, materialApply);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		private void CalculateAdaptation(Texture curTexture)
		{
			int num = curAdaptIndex;
			curAdaptIndex = (curAdaptIndex + 1) % 2;
			float value = 1f - Mathf.Pow(1f - adaptationSpeed, 30f * Time.deltaTime);
			value = Mathf.Clamp(value, 0.01f, 1f);
			materialAdapt.SetTexture("_CurTex", curTexture);
			materialAdapt.SetVector("_AdaptParams", new Vector4(value, limitMinimum, limitMaximum, 0f));
			Graphics.SetRenderTarget(adaptRenderTex[curAdaptIndex]);
			GL.Clear(clearDepth: false, clearColor: true, Color.black);
			Graphics.Blit(adaptRenderTex[num], adaptRenderTex[curAdaptIndex], materialAdapt);
		}
	}
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Edge Detection/Crease Shading")]
	[ExecuteInEditMode]
	public class CreaseShading : PostEffectsBase
	{
		public float intensity = 0.5f;

		public int softness = 1;

		public float spread = 1f;

		public Shader blurShader;

		private Material blurMaterial;

		public Shader depthFetchShader;

		private Material depthFetchMaterial;

		public Shader creaseApplyShader;

		private Material creaseApplyMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			blurMaterial = CheckShaderAndCreateMaterial(blurShader, blurMaterial);
			depthFetchMaterial = CheckShaderAndCreateMaterial(depthFetchShader, depthFetchMaterial);
			creaseApplyMaterial = CheckShaderAndCreateMaterial(creaseApplyShader, creaseApplyMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			int width = source.width;
			int height = source.height;
			float num = 1f * (float)width / (1f * (float)height);
			float num2 = 0.001953125f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 2, height / 2, 0);
			Graphics.Blit(source, temporary, depthFetchMaterial);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 2, height / 2, 0);
				blurMaterial.SetVector("offsets", new Vector4(0f, spread * num2, 0f, 0f));
				Graphics.Blit(renderTexture, temporary2, blurMaterial);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 2, height / 2, 0);
				blurMaterial.SetVector("offsets", new Vector4(spread * num2 / num, 0f, 0f, 0f));
				Graphics.Blit(renderTexture, temporary2, blurMaterial);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			creaseApplyMaterial.SetTexture("_HrDepthTex", temporary);
			creaseApplyMaterial.SetTexture("_LrDepthTex", renderTexture);
			creaseApplyMaterial.SetFloat("intensity", intensity);
			Graphics.Blit(source, destination, creaseApplyMaterial);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Depth of Field (Lens Blur, Scatter, DX11)")]
	[ExecuteInEditMode]
	public class DepthOfField : PostEffectsBase
	{
		public enum BlurType
		{
			DiscBlur,
			DX11
		}

		public enum BlurSampleCount
		{
			Low,
			Medium,
			High
		}

		public bool visualizeFocus;

		public float focalLength = 10f;

		public float focalSize = 0.05f;

		public float aperture = 0.5f;

		public Transform focalTransform;

		public float maxBlurSize = 2f;

		public bool highResolution;

		public BlurType blurType;

		public BlurSampleCount blurSampleCount = BlurSampleCount.High;

		public bool nearBlur;

		public float foregroundOverlap = 1f;

		public Shader dofHdrShader;

		private Material dofHdrMaterial;

		public Shader dx11BokehShader;

		private Material dx11bokehMaterial;

		public float dx11BokehThreshold = 0.5f;

		public float dx11SpawnHeuristic = 0.0875f;

		public Texture2D dx11BokehTexture;

		public float dx11BokehScale = 1.2f;

		public float dx11BokehIntensity = 2.5f;

		private float focalDistance01 = 10f;

		private ComputeBuffer cbDrawArgs;

		private ComputeBuffer cbPoints;

		private float internalBlurWidth = 1f;

		private Camera cachedCamera;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			dofHdrMaterial = CheckShaderAndCreateMaterial(dofHdrShader, dofHdrMaterial);
			if (supportDX11 && blurType == BlurType.DX11)
			{
				dx11bokehMaterial = CheckShaderAndCreateMaterial(dx11BokehShader, dx11bokehMaterial);
				CreateComputeResources();
			}
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnEnable()
		{
			cachedCamera = GetComponent<Camera>();
			cachedCamera.depthTextureMode |= DepthTextureMode.Depth;
		}

		private void OnDisable()
		{
			ReleaseComputeResources();
			if ((bool)dofHdrMaterial)
			{
				UnityEngine.Object.DestroyImmediate(dofHdrMaterial);
			}
			dofHdrMaterial = null;
			if ((bool)dx11bokehMaterial)
			{
				UnityEngine.Object.DestroyImmediate(dx11bokehMaterial);
			}
			dx11bokehMaterial = null;
		}

		private void ReleaseComputeResources()
		{
			if (cbDrawArgs != null)
			{
				cbDrawArgs.Release();
			}
			cbDrawArgs = null;
			if (cbPoints != null)
			{
				cbPoints.Release();
			}
			cbPoints = null;
		}

		private void CreateComputeResources()
		{
			if (cbDrawArgs == null)
			{
				cbDrawArgs = new ComputeBuffer(1, 16, ComputeBufferType.DrawIndirect);
				int[] data = new int[4] { 0, 1, 0, 0 };
				cbDrawArgs.SetData(data);
			}
			if (cbPoints == null)
			{
				cbPoints = new ComputeBuffer(90000, 28, ComputeBufferType.Append);
			}
		}

		private float FocalDistance01(float worldDist)
		{
			return cachedCamera.WorldToViewportPoint((worldDist - cachedCamera.nearClipPlane) * cachedCamera.transform.forward + cachedCamera.transform.position).z / (cachedCamera.farClipPlane - cachedCamera.nearClipPlane);
		}

		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
			dofHdrMaterial.SetTexture("_FgOverlap", null);
			if (nearBlur && fgDilate)
			{
				int width = fromTo.width / 2;
				int height = fromTo.height / 2;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, fromTo.format);
				Graphics.Blit(fromTo, temporary, dofHdrMaterial, 4);
				float num = internalBlurWidth * foregroundOverlap;
				dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, num, 0f, num));
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, fromTo.format);
				Graphics.Blit(temporary, temporary2, dofHdrMaterial, 2);
				RenderTexture.ReleaseTemporary(temporary);
				dofHdrMaterial.SetVector("_Offsets", new Vector4(num, 0f, 0f, num));
				temporary = RenderTexture.GetTemporary(width, height, 0, fromTo.format);
				Graphics.Blit(temporary2, temporary, dofHdrMaterial, 2);
				RenderTexture.ReleaseTemporary(temporary2);
				dofHdrMaterial.SetTexture("_FgOverlap", temporary);
				fromTo.MarkRestoreExpected();
				Graphics.Blit(fromTo, fromTo, dofHdrMaterial, 13);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				fromTo.MarkRestoreExpected();
				Graphics.Blit(fromTo, fromTo, dofHdrMaterial, 0);
			}
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (aperture < 0f)
			{
				aperture = 0f;
			}
			if (maxBlurSize < 0.1f)
			{
				maxBlurSize = 0.1f;
			}
			focalSize = Mathf.Clamp(focalSize, 0f, 2f);
			internalBlurWidth = Mathf.Max(maxBlurSize, 0f);
			focalDistance01 = ((!focalTransform) ? FocalDistance01(focalLength) : (cachedCamera.WorldToViewportPoint(focalTransform.position).z / cachedCamera.farClipPlane));
			dofHdrMaterial.SetVector("_CurveParams", new Vector4(1f, focalSize, 1f / (1f - aperture) - 1f, focalDistance01));
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			RenderTexture renderTexture3 = null;
			RenderTexture renderTexture4 = null;
			float num = internalBlurWidth * foregroundOverlap;
			if (visualizeFocus)
			{
				WriteCoc(source, fgDilate: true);
				Graphics.Blit(source, destination, dofHdrMaterial, 16);
			}
			else if (blurType == BlurType.DX11 && (bool)dx11bokehMaterial)
			{
				if (highResolution)
				{
					internalBlurWidth = ((!(internalBlurWidth < 0.1f)) ? internalBlurWidth : 0.1f);
					num = internalBlurWidth * foregroundOverlap;
					renderTexture = RenderTexture.GetTemporary(source.width, source.height, 0, source.format);
					RenderTexture temporary = RenderTexture.GetTemporary(source.width, source.height, 0, source.format);
					WriteCoc(source, fgDilate: false);
					renderTexture3 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
					renderTexture4 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
					Graphics.Blit(source, renderTexture3, dofHdrMaterial, 15);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, 1.5f, 0f, 1.5f));
					Graphics.Blit(renderTexture3, renderTexture4, dofHdrMaterial, 19);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(1.5f, 0f, 0f, 1.5f));
					Graphics.Blit(renderTexture4, renderTexture3, dofHdrMaterial, 19);
					if (nearBlur)
					{
						Graphics.Blit(source, renderTexture4, dofHdrMaterial, 4);
					}
					dx11bokehMaterial.SetTexture("_BlurredColor", renderTexture3);
					dx11bokehMaterial.SetFloat("_SpawnHeuristic", dx11SpawnHeuristic);
					dx11bokehMaterial.SetVector("_BokehParams", new Vector4(dx11BokehScale, dx11BokehIntensity, Mathf.Clamp(dx11BokehThreshold, 0.005f, 4f), internalBlurWidth));
					dx11bokehMaterial.SetTexture("_FgCocMask", (!nearBlur) ? null : renderTexture4);
					Graphics.SetRandomWriteTarget(1, cbPoints);
					Graphics.Blit(source, renderTexture, dx11bokehMaterial, 0);
					Graphics.ClearRandomWriteTargets();
					if (nearBlur)
					{
						dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, num, 0f, num));
						Graphics.Blit(renderTexture4, renderTexture3, dofHdrMaterial, 2);
						dofHdrMaterial.SetVector("_Offsets", new Vector4(num, 0f, 0f, num));
						Graphics.Blit(renderTexture3, renderTexture4, dofHdrMaterial, 2);
						Graphics.Blit(renderTexture4, renderTexture, dofHdrMaterial, 3);
					}
					Graphics.Blit(renderTexture, temporary, dofHdrMaterial, 20);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(internalBlurWidth, 0f, 0f, internalBlurWidth));
					Graphics.Blit(renderTexture, source, dofHdrMaterial, 5);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0f, internalBlurWidth));
					Graphics.Blit(source, temporary, dofHdrMaterial, 21);
					Graphics.SetRenderTarget(temporary);
					ComputeBuffer.CopyCount(cbPoints, cbDrawArgs, 0);
					dx11bokehMaterial.SetBuffer("pointBuffer", cbPoints);
					dx11bokehMaterial.SetTexture("_MainTex", dx11BokehTexture);
					dx11bokehMaterial.SetVector("_Screen", new Vector3(1f / (1f * (float)source.width), 1f / (1f * (float)source.height), internalBlurWidth));
					dx11bokehMaterial.SetPass(2);
					Graphics.DrawProceduralIndirect(MeshTopology.Points, cbDrawArgs, 0);
					Graphics.Blit(temporary, destination);
					RenderTexture.ReleaseTemporary(temporary);
					RenderTexture.ReleaseTemporary(renderTexture3);
					RenderTexture.ReleaseTemporary(renderTexture4);
				}
				else
				{
					renderTexture = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
					renderTexture2 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
					num = internalBlurWidth * foregroundOverlap;
					WriteCoc(source, fgDilate: false);
					source.filterMode = FilterMode.Bilinear;
					Graphics.Blit(source, renderTexture, dofHdrMaterial, 6);
					renderTexture3 = RenderTexture.GetTemporary(renderTexture.width >> 1, renderTexture.height >> 1, 0, renderTexture.format);
					renderTexture4 = RenderTexture.GetTemporary(renderTexture.width >> 1, renderTexture.height >> 1, 0, renderTexture.format);
					Graphics.Blit(renderTexture, renderTexture3, dofHdrMaterial, 15);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, 1.5f, 0f, 1.5f));
					Graphics.Blit(renderTexture3, renderTexture4, dofHdrMaterial, 19);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(1.5f, 0f, 0f, 1.5f));
					Graphics.Blit(renderTexture4, renderTexture3, dofHdrMaterial, 19);
					RenderTexture renderTexture5 = null;
					if (nearBlur)
					{
						renderTexture5 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
						Graphics.Blit(source, renderTexture5, dofHdrMaterial, 4);
					}
					dx11bokehMaterial.SetTexture("_BlurredColor", renderTexture3);
					dx11bokehMaterial.SetFloat("_SpawnHeuristic", dx11SpawnHeuristic);
					dx11bokehMaterial.SetVector("_BokehParams", new Vector4(dx11BokehScale, dx11BokehIntensity, Mathf.Clamp(dx11BokehThreshold, 0.005f, 4f), internalBlurWidth));
					dx11bokehMaterial.SetTexture("_FgCocMask", renderTexture5);
					Graphics.SetRandomWriteTarget(1, cbPoints);
					Graphics.Blit(renderTexture, renderTexture2, dx11bokehMaterial, 0);
					Graphics.ClearRandomWriteTargets();
					RenderTexture.ReleaseTemporary(renderTexture3);
					RenderTexture.ReleaseTemporary(renderTexture4);
					if (nearBlur)
					{
						dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, num, 0f, num));
						Graphics.Blit(renderTexture5, renderTexture, dofHdrMaterial, 2);
						dofHdrMaterial.SetVector("_Offsets", new Vector4(num, 0f, 0f, num));
						Graphics.Blit(renderTexture, renderTexture5, dofHdrMaterial, 2);
						Graphics.Blit(renderTexture5, renderTexture2, dofHdrMaterial, 3);
					}
					dofHdrMaterial.SetVector("_Offsets", new Vector4(internalBlurWidth, 0f, 0f, internalBlurWidth));
					Graphics.Blit(renderTexture2, renderTexture, dofHdrMaterial, 5);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0f, internalBlurWidth));
					Graphics.Blit(renderTexture, renderTexture2, dofHdrMaterial, 5);
					Graphics.SetRenderTarget(renderTexture2);
					ComputeBuffer.CopyCount(cbPoints, cbDrawArgs, 0);
					dx11bokehMaterial.SetBuffer("pointBuffer", cbPoints);
					dx11bokehMaterial.SetTexture("_MainTex", dx11BokehTexture);
					dx11bokehMaterial.SetVector("_Screen", new Vector3(1f / (1f * (float)renderTexture2.width), 1f / (1f * (float)renderTexture2.height), internalBlurWidth));
					dx11bokehMaterial.SetPass(1);
					Graphics.DrawProceduralIndirect(MeshTopology.Points, cbDrawArgs, 0);
					dofHdrMaterial.SetTexture("_LowRez", renderTexture2);
					dofHdrMaterial.SetTexture("_FgOverlap", renderTexture5);
					dofHdrMaterial.SetVector("_Offsets", 1f * (float)source.width / (1f * (float)renderTexture2.width) * internalBlurWidth * Vector4.one);
					Graphics.Blit(source, destination, dofHdrMaterial, 9);
					if ((bool)renderTexture5)
					{
						RenderTexture.ReleaseTemporary(renderTexture5);
					}
				}
			}
			else
			{
				source.filterMode = FilterMode.Bilinear;
				if (highResolution)
				{
					internalBlurWidth *= 2f;
				}
				WriteCoc(source, fgDilate: true);
				renderTexture = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
				renderTexture2 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
				int pass = ((blurSampleCount != BlurSampleCount.High && blurSampleCount != BlurSampleCount.Medium) ? 11 : 17);
				if (highResolution)
				{
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0.025f, internalBlurWidth));
					Graphics.Blit(source, destination, dofHdrMaterial, pass);
				}
				else
				{
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0.1f, internalBlurWidth));
					Graphics.Blit(source, renderTexture, dofHdrMaterial, 6);
					Graphics.Blit(renderTexture, renderTexture2, dofHdrMaterial, pass);
					dofHdrMaterial.SetTexture("_LowRez", renderTexture2);
					dofHdrMaterial.SetTexture("_FgOverlap", null);
					dofHdrMaterial.SetVector("_Offsets", Vector4.one * (1f * (float)source.width / (1f * (float)renderTexture2.width)) * internalBlurWidth);
					Graphics.Blit(source, destination, dofHdrMaterial, (blurSampleCount != BlurSampleCount.High) ? 12 : 18);
				}
			}
			if ((bool)renderTexture)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
			if ((bool)renderTexture2)
			{
				RenderTexture.ReleaseTemporary(renderTexture2);
			}
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Camera/Depth of Field (deprecated)")]
	[RequireComponent(typeof(Camera))]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		public enum Dof34QualitySetting
		{
			OnlyBackground = 1,
			BackgroundAndForeground
		}

		public enum DofResolution
		{
			High = 2,
			Medium,
			Low
		}

		public enum DofBlurriness
		{
			Low = 1,
			High = 2,
			VeryHigh = 4
		}

		public enum BokehDestination
		{
			Background = 1,
			Foreground,
			BackgroundAndForeground
		}

		private static int SMOOTH_DOWNSAMPLE_PASS = 6;

		private static float BOKEH_EXTRA_BLUR = 2f;

		public Dof34QualitySetting quality = Dof34QualitySetting.OnlyBackground;

		public DofResolution resolution = DofResolution.Low;

		public bool simpleTweakMode = true;

		public float focalPoint = 1f;

		public float smoothness = 0.5f;

		public float focalZDistance;

		public float focalZStartCurve = 1f;

		public float focalZEndCurve = 1f;

		private float focalStartCurve = 2f;

		private float focalEndCurve = 2f;

		private float focalDistance01 = 0.1f;

		public Transform objectFocus;

		public float focalSize;

		public DofBlurriness bluriness = DofBlurriness.High;

		public float maxBlurSpread = 1.75f;

		public float foregroundBlurExtrude = 1.15f;

		public Shader dofBlurShader;

		private Material dofBlurMaterial;

		public Shader dofShader;

		private Material dofMaterial;

		public bool visualize;

		public BokehDestination bokehDestination = BokehDestination.Background;

		private float widthOverHeight = 1.25f;

		private float oneOverBaseSize = 0.001953125f;

		public bool bokeh;

		public bool bokehSupport = true;

		public Shader bokehShader;

		public Texture2D bokehTexture;

		public float bokehScale = 2.4f;

		public float bokehIntensity = 0.15f;

		public float bokehThresholdContrast = 0.1f;

		public float bokehThresholdLuminance = 0.55f;

		public int bokehDownsample = 1;

		private Material bokehMaterial;

		private Camera _camera;

		private RenderTexture foregroundTexture;

		private RenderTexture mediumRezWorkTexture;

		private RenderTexture finalDefocus;

		private RenderTexture lowRezWorkTexture;

		private RenderTexture bokehSource;

		private RenderTexture bokehSource2;

		private void CreateMaterials()
		{
			dofBlurMaterial = CheckShaderAndCreateMaterial(dofBlurShader, dofBlurMaterial);
			dofMaterial = CheckShaderAndCreateMaterial(dofShader, dofMaterial);
			bokehSupport = bokehShader.isSupported;
			if (bokeh && bokehSupport && (bool)bokehShader)
			{
				bokehMaterial = CheckShaderAndCreateMaterial(bokehShader, bokehMaterial);
			}
		}

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			dofBlurMaterial = CheckShaderAndCreateMaterial(dofBlurShader, dofBlurMaterial);
			dofMaterial = CheckShaderAndCreateMaterial(dofShader, dofMaterial);
			bokehSupport = bokehShader.isSupported;
			if (bokeh && bokehSupport && (bool)bokehShader)
			{
				bokehMaterial = CheckShaderAndCreateMaterial(bokehShader, bokehMaterial);
			}
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnDisable()
		{
			Quads.Cleanup();
		}

		private void OnEnable()
		{
			_camera = GetComponent<Camera>();
			_camera.depthTextureMode |= DepthTextureMode.Depth;
		}

		private float FocalDistance01(float worldDist)
		{
			return _camera.WorldToViewportPoint((worldDist - _camera.nearClipPlane) * _camera.transform.forward + _camera.transform.position).z / (_camera.farClipPlane - _camera.nearClipPlane);
		}

		private int GetDividerBasedOnQuality()
		{
			int result = 1;
			if (resolution == DofResolution.Medium)
			{
				result = 2;
			}
			else if (resolution == DofResolution.Low)
			{
				result = 2;
			}
			return result;
		}

		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			int num = baseDivider;
			if (resolution == DofResolution.High)
			{
				num *= 2;
			}
			if (resolution == DofResolution.Low)
			{
				num *= 2;
			}
			return num;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (smoothness < 0.1f)
			{
				smoothness = 0.1f;
			}
			bokeh = bokeh && bokehSupport;
			float num = ((!bokeh) ? 1f : BOKEH_EXTRA_BLUR);
			bool flag = quality > Dof34QualitySetting.OnlyBackground;
			float num2 = focalSize / (_camera.farClipPlane - _camera.nearClipPlane);
			if (simpleTweakMode)
			{
				focalDistance01 = ((!objectFocus) ? FocalDistance01(focalPoint) : (_camera.WorldToViewportPoint(objectFocus.position).z / _camera.farClipPlane));
				focalStartCurve = focalDistance01 * smoothness;
				focalEndCurve = focalStartCurve;
				flag = flag && focalPoint > _camera.nearClipPlane + Mathf.Epsilon;
			}
			else
			{
				if ((bool)objectFocus)
				{
					Vector3 vector = _camera.WorldToViewportPoint(objectFocus.position);
					vector.z /= _camera.farClipPlane;
					focalDistance01 = vector.z;
				}
				else
				{
					focalDistance01 = FocalDistance01(focalZDistance);
				}
				focalStartCurve = focalZStartCurve;
				focalEndCurve = focalZEndCurve;
				flag = flag && focalPoint > _camera.nearClipPlane + Mathf.Epsilon;
			}
			widthOverHeight = 1f * (float)source.width / (1f * (float)source.height);
			oneOverBaseSize = 0.001953125f;
			dofMaterial.SetFloat("_ForegroundBlurExtrude", foregroundBlurExtrude);
			dofMaterial.SetVector("_CurveParams", new Vector4((!simpleTweakMode) ? focalStartCurve : (1f / focalStartCurve), (!simpleTweakMode) ? focalEndCurve : (1f / focalEndCurve), num2 * 0.5f, focalDistance01));
			dofMaterial.SetVector("_InvRenderTargetSize", new Vector4(1f / (1f * (float)source.width), 1f / (1f * (float)source.height), 0f, 0f));
			int dividerBasedOnQuality = GetDividerBasedOnQuality();
			int lowResolutionDividerBasedOnQuality = GetLowResolutionDividerBasedOnQuality(dividerBasedOnQuality);
			AllocateTextures(flag, source, dividerBasedOnQuality, lowResolutionDividerBasedOnQuality);
			Graphics.Blit(source, source, dofMaterial, 3);
			Downsample(source, mediumRezWorkTexture);
			Blur(mediumRezWorkTexture, mediumRezWorkTexture, DofBlurriness.Low, 4, maxBlurSpread);
			if (bokeh && (BokehDestination.Foreground & bokehDestination) != 0)
			{
				dofMaterial.SetVector("_Threshhold", new Vector4(bokehThresholdContrast, bokehThresholdLuminance, 0.95f, 0f));
				Graphics.Blit(mediumRezWorkTexture, bokehSource2, dofMaterial, 11);
				Graphics.Blit(mediumRezWorkTexture, lowRezWorkTexture);
				Blur(lowRezWorkTexture, lowRezWorkTexture, bluriness, 0, maxBlurSpread * num);
			}
			else
			{
				Downsample(mediumRezWorkTexture, lowRezWorkTexture);
				Blur(lowRezWorkTexture, lowRezWorkTexture, bluriness, 0, maxBlurSpread);
			}
			dofBlurMaterial.SetTexture("_TapLow", lowRezWorkTexture);
			dofBlurMaterial.SetTexture("_TapMedium", mediumRezWorkTexture);
			Graphics.Blit(null, finalDefocus, dofBlurMaterial, 3);
			if (bokeh && (BokehDestination.Foreground & bokehDestination) != 0)
			{
				AddBokeh(bokehSource2, bokehSource, finalDefocus);
			}
			dofMaterial.SetTexture("_TapLowBackground", finalDefocus);
			dofMaterial.SetTexture("_TapMedium", mediumRezWorkTexture);
			Graphics.Blit(source, (!flag) ? destination : foregroundTexture, dofMaterial, visualize ? 2 : 0);
			if (flag)
			{
				Graphics.Blit(foregroundTexture, source, dofMaterial, 5);
				Downsample(source, mediumRezWorkTexture);
				BlurFg(mediumRezWorkTexture, mediumRezWorkTexture, DofBlurriness.Low, 2, maxBlurSpread);
				if (bokeh && (BokehDestination.Foreground & bokehDestination) != 0)
				{
					dofMaterial.SetVector("_Threshhold", new Vector4(bokehThresholdContrast * 0.5f, bokehThresholdLuminance, 0f, 0f));
					Graphics.Blit(mediumRezWorkTexture, bokehSource2, dofMaterial, 11);
					Graphics.Blit(mediumRezWorkTexture, lowRezWorkTexture);
					BlurFg(lowRezWorkTexture, lowRezWorkTexture, bluriness, 1, maxBlurSpread * num);
				}
				else
				{
					BlurFg(mediumRezWorkTexture, lowRezWorkTexture, bluriness, 1, maxBlurSpread);
				}
				Graphics.Blit(lowRezWorkTexture, finalDefocus);
				dofMaterial.SetTexture("_TapLowForeground", finalDefocus);
				Graphics.Blit(source, destination, dofMaterial, visualize ? 1 : 4);
				if (bokeh && (BokehDestination.Foreground & bokehDestination) != 0)
				{
					AddBokeh(bokehSource2, bokehSource, destination);
				}
			}
			ReleaseTextures();
		}

		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(to.width, to.height);
			if (iterations > DofBlurriness.Low)
			{
				BlurHex(from, to, blurPass, spread, temporary);
				if (iterations > DofBlurriness.High)
				{
					dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
					Graphics.Blit(to, temporary, dofBlurMaterial, blurPass);
					dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
					Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
				}
			}
			else
			{
				dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
				Graphics.Blit(from, temporary, dofBlurMaterial, blurPass);
				dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
				Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
			dofBlurMaterial.SetTexture("_TapHigh", from);
			RenderTexture temporary = RenderTexture.GetTemporary(to.width, to.height);
			if (iterations > DofBlurriness.Low)
			{
				BlurHex(from, to, blurPass, spread, temporary);
				if (iterations > DofBlurriness.High)
				{
					dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
					Graphics.Blit(to, temporary, dofBlurMaterial, blurPass);
					dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
					Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
				}
			}
			else
			{
				dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
				Graphics.Blit(from, temporary, dofBlurMaterial, blurPass);
				dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
				Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
			dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
			Graphics.Blit(from, tmp, dofBlurMaterial, blurPass);
			dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
			Graphics.Blit(tmp, to, dofBlurMaterial, blurPass);
			dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, spread * oneOverBaseSize, 0f, 0f));
			Graphics.Blit(to, tmp, dofBlurMaterial, blurPass);
			dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, (0f - spread) * oneOverBaseSize, 0f, 0f));
			Graphics.Blit(tmp, to, dofBlurMaterial, blurPass);
		}

		private void Downsample(RenderTexture from, RenderTexture to)
		{
			dofMaterial.SetVector("_InvRenderTargetSize", new Vector4(1f / (1f * (float)to.width), 1f / (1f * (float)to.height), 0f, 0f));
			Graphics.Blit(from, to, dofMaterial, SMOOTH_DOWNSAMPLE_PASS);
		}

		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
			if (!bokehMaterial)
			{
				return;
			}
			Mesh[] meshes = Quads.GetMeshes(tempTex.width, tempTex.height);
			RenderTexture.active = tempTex;
			GL.Clear(clearDepth: false, clearColor: true, new Color(0f, 0f, 0f, 0f));
			GL.PushMatrix();
			GL.LoadIdentity();
			bokehInfo.filterMode = FilterMode.Point;
			float num = (float)bokehInfo.width * 1f / ((float)bokehInfo.height * 1f);
			float num2 = 2f / (1f * (float)bokehInfo.width);
			num2 += bokehScale * maxBlurSpread * BOKEH_EXTRA_BLUR * oneOverBaseSize;
			bokehMaterial.SetTexture("_Source", bokehInfo);
			bokehMaterial.SetTexture("_MainTex", bokehTexture);
			bokehMaterial.SetVector("_ArScale", new Vector4(num2, num2 * num, 0.5f, 0.5f * num));
			bokehMaterial.SetFloat("_Intensity", bokehIntensity);
			bokehMaterial.SetPass(0);
			Mesh[] array = meshes;
			foreach (Mesh mesh in array)
			{
				if ((bool)mesh)
				{
					Graphics.DrawMeshNow(mesh, Matrix4x4.identity);
				}
			}
			GL.PopMatrix();
			Graphics.Blit(tempTex, finalTarget, dofMaterial, 8);
			bokehInfo.filterMode = FilterMode.Bilinear;
		}

		private void ReleaseTextures()
		{
			if ((bool)foregroundTexture)
			{
				RenderTexture.ReleaseTemporary(foregroundTexture);
			}
			if ((bool)finalDefocus)
			{
				RenderTexture.ReleaseTemporary(finalDefocus);
			}
			if ((bool)mediumRezWorkTexture)
			{
				RenderTexture.ReleaseTemporary(mediumRezWorkTexture);
			}
			if ((bool)lowRezWorkTexture)
			{
				RenderTexture.ReleaseTemporary(lowRezWorkTexture);
			}
			if ((bool)bokehSource)
			{
				RenderTexture.ReleaseTemporary(bokehSource);
			}
			if ((bool)bokehSource2)
			{
				RenderTexture.ReleaseTemporary(bokehSource2);
			}
		}

		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
			foregroundTexture = null;
			if (blurForeground)
			{
				foregroundTexture = RenderTexture.GetTemporary(source.width, source.height, 0);
			}
			mediumRezWorkTexture = RenderTexture.GetTemporary(source.width / divider, source.height / divider, 0);
			finalDefocus = RenderTexture.GetTemporary(source.width / divider, source.height / divider, 0);
			lowRezWorkTexture = RenderTexture.GetTemporary(source.width / lowTexDivider, source.height / lowTexDivider, 0);
			bokehSource = null;
			bokehSource2 = null;
			if (bokeh)
			{
				bokehSource = RenderTexture.GetTemporary(source.width / (lowTexDivider * bokehDownsample), source.height / (lowTexDivider * bokehDownsample), 0, RenderTextureFormat.ARGBHalf);
				bokehSource2 = RenderTexture.GetTemporary(source.width / (lowTexDivider * bokehDownsample), source.height / (lowTexDivider * bokehDownsample), 0, RenderTextureFormat.ARGBHalf);
				bokehSource.filterMode = FilterMode.Bilinear;
				bokehSource2.filterMode = FilterMode.Bilinear;
				RenderTexture.active = bokehSource2;
				GL.Clear(clearDepth: false, clearColor: true, new Color(0f, 0f, 0f, 0f));
			}
			source.filterMode = FilterMode.Bilinear;
			finalDefocus.filterMode = FilterMode.Bilinear;
			mediumRezWorkTexture.filterMode = FilterMode.Bilinear;
			lowRezWorkTexture.filterMode = FilterMode.Bilinear;
			if ((bool)foregroundTexture)
			{
				foregroundTexture.filterMode = FilterMode.Bilinear;
			}
		}
	}
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Edge Detection/Edge Detection")]
	[ExecuteInEditMode]
	public class EdgeDetection : PostEffectsBase
	{
		public enum EdgeDetectMode
		{
			TriangleDepthNormals,
			RobertsCrossDepthNormals,
			SobelDepth,
			SobelDepthThin,
			TriangleLuminance
		}

		public EdgeDetectMode mode = EdgeDetectMode.SobelDepthThin;

		public float sensitivityDepth = 1f;

		public float sensitivityNormals = 1f;

		public float lumThreshold = 0.2f;

		public float edgeExp = 1f;

		public float sampleDist = 1f;

		public float edgesOnly;

		public Color edgesOnlyBgColor = Color.white;

		public Shader edgeDetectShader;

		private Material edgeDetectMaterial;

		private EdgeDetectMode oldMode = EdgeDetectMode.SobelDepthThin;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			edgeDetectMaterial = CheckShaderAndCreateMaterial(edgeDetectShader, edgeDetectMaterial);
			if (mode != oldMode)
			{
				SetCameraFlag();
			}
			oldMode = mode;
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private new void Start()
		{
			oldMode = mode;
		}

		private void SetCameraFlag()
		{
			if (mode == EdgeDetectMode.SobelDepth || mode == EdgeDetectMode.SobelDepthThin)
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			else if (mode == EdgeDetectMode.TriangleDepthNormals || mode == EdgeDetectMode.RobertsCrossDepthNormals)
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.DepthNormals;
			}
		}

		private void OnEnable()
		{
			SetCameraFlag();
		}

		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			Vector2 vector = new Vector2(sensitivityDepth, sensitivityNormals);
			edgeDetectMaterial.SetVector("_Sensitivity", new Vector4(vector.x, vector.y, 1f, vector.y));
			edgeDetectMaterial.SetFloat("_BgFade", edgesOnly);
			edgeDetectMaterial.SetFloat("_SampleDistance", sampleDist);
			edgeDetectMaterial.SetVector("_BgColor", edgesOnlyBgColor);
			edgeDetectMaterial.SetFloat("_Exponent", edgeExp);
			edgeDetectMaterial.SetFloat("_Threshold", lumThreshold);
			Graphics.Blit(source, destination, edgeDetectMaterial, (int)mode);
		}
	}
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Displacement/Fisheye")]
	public class Fisheye : PostEffectsBase
	{
		[Range(0f, 1.5f)]
		public float strengthX = 0.05f;

		[Range(0f, 1.5f)]
		public float strengthY = 0.05f;

		public Shader fishEyeShader;

		private Material fisheyeMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			fisheyeMaterial = CheckShaderAndCreateMaterial(fishEyeShader, fisheyeMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			float num = 5f / 32f;
			float num2 = (float)source.width * 1f / ((float)source.height * 1f);
			fisheyeMaterial.SetVector("intensity", new Vector4(strengthX * num2 * num, strengthY * num, strengthX * num2 * num, strengthY * num));
			Graphics.Blit(source, destination, fisheyeMaterial);
		}
	}
	[AddComponentMenu("Image Effects/Rendering/Global Fog")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	internal class GlobalFog : PostEffectsBase
	{
		[Tooltip("Apply distance-based fog?")]
		public bool distanceFog = true;

		[Tooltip("Exclude far plane pixels from distance-based fog? (Skybox or clear color)")]
		public bool excludeFarPixels = true;

		[Tooltip("Distance fog is based on radial distance from camera when checked")]
		public bool useRadialDistance;

		[Tooltip("Apply height-based fog?")]
		public bool heightFog = true;

		[Tooltip("Fog top Y coordinate")]
		public float height = 1f;

		[Range(0.001f, 10f)]
		public float heightDensity = 2f;

		[Tooltip("Push fog away from the camera by this amount")]
		public float startDistance;

		public Shader fogShader;

		private Material fogMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			fogMaterial = CheckShaderAndCreateMaterial(fogShader, fogMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources() || (!distanceFog && !heightFog))
			{
				Graphics.Blit(source, destination);
				return;
			}
			Camera component = GetComponent<Camera>();
			Transform transform = component.transform;
			float nearClipPlane = component.nearClipPlane;
			float farClipPlane = component.farClipPlane;
			float fieldOfView = component.fieldOfView;
			float aspect = component.aspect;
			Matrix4x4 identity = Matrix4x4.identity;
			float num = fieldOfView * 0.5f;
			Vector3 vector = transform.right * nearClipPlane * Mathf.Tan(num * ((float)Math.PI / 180f)) * aspect;
			Vector3 vector2 = transform.up * nearClipPlane * Mathf.Tan(num * ((float)Math.PI / 180f));
			Vector3 vector3 = transform.forward * nearClipPlane - vector + vector2;
			float num2 = vector3.magnitude * farClipPlane / nearClipPlane;
			vector3.Normalize();
			vector3 *= num2;
			Vector3 vector4 = transform.forward * nearClipPlane + vector + vector2;
			vector4.Normalize();
			vector4 *= num2;
			Vector3 vector5 = transform.forward * nearClipPlane + vector - vector2;
			vector5.Normalize();
			vector5 *= num2;
			Vector3 vector6 = transform.forward * nearClipPlane - vector - vector2;
			vector6.Normalize();
			vector6 *= num2;
			identity.SetRow(0, vector3);
			identity.SetRow(1, vector4);
			identity.SetRow(2, vector5);
			identity.SetRow(3, vector6);
			Vector3 position = transform.position;
			float num3 = position.y - height;
			float z = ((!(num3 <= 0f)) ? 0f : 1f);
			float y = ((!excludeFarPixels) ? 2f : 1f);
			fogMaterial.SetMatrix("_FrustumCornersWS", identity);
			fogMaterial.SetVector("_CameraWS", position);
			fogMaterial.SetVector("_HeightParams", new Vector4(height, num3, z, heightDensity * 0.5f));
			fogMaterial.SetVector("_DistanceParams", new Vector4(0f - Mathf.Max(startDistance, 0f), y, 0f, 0f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == FogMode.Linear;
			float num4 = ((!flag) ? 0f : (fogEndDistance - fogStartDistance));
			float num5 = ((!(Mathf.Abs(num4) > 0.0001f)) ? 0f : (1f / num4));
			Vector4 vector7 = default(Vector4);
			vector7.x = fogDensity * 1.2011224f;
			vector7.y = fogDensity * 1.442695f;
			vector7.z = ((!flag) ? 0f : (0f - num5));
			vector7.w = ((!flag) ? 0f : (fogEndDistance * num5));
			fogMaterial.SetVector("_SceneFogParams", vector7);
			fogMaterial.SetVector("_SceneFogMode", new Vector4((float)fogMode, useRadialDistance ? 1 : 0, 0f, 0f));
			int num6 = 0;
			CustomGraphicsBlit(passNr: (!distanceFog || !heightFog) ? (distanceFog ? 1 : 2) : 0, source: source, dest: destination, fxMaterial: fogMaterial);
		}

		private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
		{
			RenderTexture.active = dest;
			fxMaterial.SetTexture("_MainTex", source);
			GL.PushMatrix();
			GL.LoadOrtho();
			fxMaterial.SetPass(passNr);
			GL.Begin(7);
			GL.MultiTexCoord2(0, 0f, 0f);
			GL.Vertex3(0f, 0f, 3f);
			GL.MultiTexCoord2(0, 1f, 0f);
			GL.Vertex3(1f, 0f, 2f);
			GL.MultiTexCoord2(0, 1f, 1f);
			GL.Vertex3(1f, 1f, 1f);
			GL.MultiTexCoord2(0, 0f, 1f);
			GL.Vertex3(0f, 1f, 0f);
			GL.End();
			GL.PopMatrix();
		}
	}
	[AddComponentMenu("Image Effects/Color Adjustments/Grayscale")]
	[ExecuteInEditMode]
	public class Grayscale : ImageEffectBase
	{
		public Texture textureRamp;

		[Range(-1f, 1f)]
		public float rampOffset;

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			base.material.SetTexture("_RampTex", textureRamp);
			base.material.SetFloat("_RampOffset", rampOffset);
			Graphics.Blit(source, destination, base.material);
		}
	}
	[AddComponentMenu("")]
	[RequireComponent(typeof(Camera))]
	public class ImageEffectBase : MonoBehaviour
	{
		public Shader shader;

		private Material m_Material;

		protected Material material
		{
			get
			{
				if (m_Material == null)
				{
					m_Material = new Material(shader);
					m_Material.hideFlags = HideFlags.HideAndDontSave;
				}
				return m_Material;
			}
		}

		protected virtual void Start()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
			}
			else if (!shader || !shader.isSupported)
			{
				base.enabled = false;
			}
		}

		protected virtual void OnDisable()
		{
			if ((bool)m_Material)
			{
				UnityEngine.Object.DestroyImmediate(m_Material);
			}
		}
	}
	[AddComponentMenu("")]
	public class ImageEffects
	{
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
			if (source.texelSize.y < 0f)
			{
				center.y = 1f - center.y;
				angle = 0f - angle;
			}
			Matrix4x4 matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(0f, 0f, angle), Vector3.one);
			material.SetMatrix("_RotationMatrix", matrix);
			material.SetVector("_CenterRadius", new Vector4(center.x, center.y, radius.x, radius.y));
			material.SetFloat("_Angle", angle * ((float)Math.PI / 180f));
			Graphics.Blit(source, destination, material);
		}

		[Obsolete("Use Graphics.Blit(source,dest) instead")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
			Graphics.Blit(source, dest);
		}

		[Obsolete("Use Graphics.Blit(source, destination, material) instead")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
			Graphics.Blit(source, dest, material);
		}
	}
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Blur/Motion Blur (Color Accumulation)")]
	public class MotionBlur : ImageEffectBase
	{
		[Range(0f, 0.92f)]
		public float blurAmount = 0.8f;

		public bool extraBlur;

		private RenderTexture accumTexture;

		protected override void Start()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
			}
			else
			{
				base.Start();
			}
		}

		protected override void OnDisable()
		{
			base.OnDisable();
			UnityEngine.Object.DestroyImmediate(accumTexture);
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (accumTexture == null || accumTexture.width != source.width || accumTexture.height != source.height)
			{
				UnityEngine.Object.DestroyImmediate(accumTexture);
				accumTexture = new RenderTexture(source.width, source.height, 0);
				accumTexture.hideFlags = HideFlags.HideAndDontSave;
				Graphics.Blit(source, accumTexture);
			}
			if (extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0);
				accumTexture.MarkRestoreExpected();
				Graphics.Blit(accumTexture, temporary);
				Graphics.Blit(temporary, accumTexture);
				RenderTexture.ReleaseTemporary(temporary);
			}
			blurAmount = Mathf.Clamp(blurAmount, 0f, 0.92f);
			base.material.SetTexture("_MainTex", accumTexture);
			base.material.SetFloat("_AccumOrig", 1f - blurAmount);
			accumTexture.MarkRestoreExpected();
			Graphics.Blit(source, accumTexture, base.material);
			Graphics.Blit(accumTexture, destination);
		}
	}
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Noise/Noise And Grain (Filmic)")]
	[ExecuteInEditMode]
	public class NoiseAndGrain : PostEffectsBase
	{
		public float intensityMultiplier = 0.25f;

		public float generalIntensity = 0.5f;

		public float blackIntensity = 1f;

		public float whiteIntensity = 1f;

		public float midGrey = 0.2f;

		public bool dx11Grain;

		public float softness;

		public bool monochrome;

		public Vector3 intensities = new Vector3(1f, 1f, 1f);

		public Vector3 tiling = new Vector3(64f, 64f, 64f);

		public float monochromeTiling = 64f;

		public FilterMode filterMode = FilterMode.Bilinear;

		public Texture2D noiseTexture;

		public Shader noiseShader;

		private Material noiseMaterial;

		public Shader dx11NoiseShader;

		private Material dx11NoiseMaterial;

		private static float TILE_AMOUNT = 64f;

		private Mesh mesh;

		private void Awake()
		{
			mesh = new Mesh();
		}

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			noiseMaterial = CheckShaderAndCreateMaterial(noiseShader, noiseMaterial);
			if (dx11Grain && supportDX11)
			{
				dx11NoiseMaterial = CheckShaderAndCreateMaterial(dx11NoiseShader, dx11NoiseMaterial);
			}
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources() || null == noiseTexture)
			{
				Graphics.Blit(source, destination);
				if (null == noiseTexture)
				{
					UnityEngine.Debug.LogWarning("Noise & Grain effect failing as noise texture is not assigned. please assign.", base.transform);
				}
				return;
			}
			softness = Mathf.Clamp(softness, 0f, 0.99f);
			if (dx11Grain && supportDX11)
			{
				dx11NoiseMaterial.SetFloat("_DX11NoiseTime", Time.frameCount);
				dx11NoiseMaterial.SetTexture("_NoiseTex", noiseTexture);
				dx11NoiseMaterial.SetVector("_NoisePerChannel", (!monochrome) ? intensities : Vector3.one);
				dx11NoiseMaterial.SetVector("_MidGrey", new Vector3(midGrey, 1f / (1f - midGrey), -1f / midGrey));
				dx11NoiseMaterial.SetVector("_NoiseAmount", new Vector3(generalIntensity, blackIntensity, whiteIntensity) * intensityMultiplier);
				if (softness > Mathf.Epsilon)
				{
					RenderTexture temporary = RenderTexture.GetTemporary((int)((float)source.width * (1f - softness)), (int)((float)source.height * (1f - softness)));
					DrawNoiseQuadGrid(source, temporary, dx11NoiseMaterial, noiseTexture, mesh, (!monochrome) ? 2 : 3);
					dx11NoiseMaterial.SetTexture("_NoiseTex", temporary);
					Graphics.Blit(source, destination, dx11NoiseMaterial, 4);
					RenderTexture.ReleaseTemporary(temporary);
				}
				else
				{
					DrawNoiseQuadGrid(source, destination, dx11NoiseMaterial, noiseTexture, mesh, monochrome ? 1 : 0);
				}
				return;
			}
			if ((bool)noiseTexture)
			{
				noiseTexture.wrapMode = TextureWrapMode.Repeat;
				noiseTexture.filterMode = filterMode;
			}
			noiseMaterial.SetTexture("_NoiseTex", noiseTexture);
			noiseMaterial.SetVector("_NoisePerChannel", (!monochrome) ? intensities : Vector3.one);
			noiseMaterial.SetVector("_NoiseTilingPerChannel", (!monochrome) ? tiling : (Vector3.one * monochromeTiling));
			noiseMaterial.SetVector("_MidGrey", new Vector3(midGrey, 1f / (1f - midGrey), -1f / midGrey));
			noiseMaterial.SetVector("_NoiseAmount", new Vector3(generalIntensity, blackIntensity, whiteIntensity) * intensityMultiplier);
			if (softness > Mathf.Epsilon)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary((int)((float)source.width * (1f - softness)), (int)((float)source.height * (1f - softness)));
				DrawNoiseQuadGrid(source, temporary2, noiseMaterial, noiseTexture, mesh, 2);
				noiseMaterial.SetTexture("_NoiseTex", temporary2);
				Graphics.Blit(source, destination, noiseMaterial, 1);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				DrawNoiseQuadGrid(source, destination, noiseMaterial, noiseTexture, mesh, 0);
			}
		}

		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, Mesh mesh, int passNr)
		{
			RenderTexture.active = dest;
			fxMaterial.SetTexture("_MainTex", source);
			GL.PushMatrix();
			GL.LoadOrtho();
			fxMaterial.SetPass(passNr);
			BuildMesh(mesh, source, noise);
			Transform transform = Camera.main.transform;
			Vector3 position = transform.position;
			Quaternion rotation = transform.rotation;
			transform.position = Vector3.zero;
			transform.rotation = Quaternion.identity;
			Graphics.DrawMeshNow(mesh, Matrix4x4.identity);
			transform.position = position;
			transform.rotation = rotation;
			GL.PopMatrix();
		}

		private static void BuildMesh(Mesh mesh, RenderTexture source, Texture2D noise)
		{
			float noiseSize = (float)noise.width * 1f;
			float num = 1f * (float)source.width / TILE_AMOUNT;
			float num2 = 1f * (float)source.width / (1f * (float)source.height);
			float num3 = 1f / num;
			float num4 = num3 * num2;
			int num5 = (int)Mathf.Ceil(num);
			int num6 = (int)Mathf.Ceil(1f / num4);
			if (mesh.vertices.Length != num5 * num6 * 4)
			{
				Vector3[] array = new Vector3[num5 * num6 * 4];
				Vector2[] array2 = new Vector2[num5 * num6 * 4];
				int[] array3 = new int[num5 * num6 * 6];
				int num7 = 0;
				int num8 = 0;
				for (float num9 = 0f; num9 < 1f; num9 += num3)
				{
					for (float num10 = 0f; num10 < 1f; num10 += num4)
					{
						ref Vector3 reference = ref array[num7];
						reference = new Vector3(num9, num10, 0.1f);
						ref Vector3 reference2 = ref array[num7 + 1];
						reference2 = new Vector3(num9 + num3, num10, 0.1f);
						ref Vector3 reference3 = ref array[num7 + 2];
						reference3 = new Vector3(num9 + num3, num10 + num4, 0.1f);
						ref Vector3 reference4 = ref array[num7 + 3];
						reference4 = new Vector3(num9, num10 + num4, 0.1f);
						ref Vector2 reference5 = ref array2[num7];
						reference5 = new Vector2(0f, 0f);
						ref Vector2 reference6 = ref array2[num7 + 1];
						reference6 = new Vector2(1f, 0f);
						ref Vector2 reference7 = ref array2[num7 + 2];
						reference7 = new Vector2(1f, 1f);
						ref Vector2 reference8 = ref array2[num7 + 3];
						reference8 = new Vector2(0f, 1f);
						array3[num8] = num7;
						array3[num8 + 1] = num7 + 1;
						array3[num8 + 2] = num7 + 2;
						array3[num8 + 3] = num7;
						array3[num8 + 4] = num7 + 2;
						array3[num8 + 5] = num7 + 3;
						num7 += 4;
						num8 += 6;
					}
				}
				mesh.vertices = array;
				mesh.uv2 = array2;
				mesh.triangles = array3;
			}
			BuildMeshUV0(mesh, num5, num6, noiseSize, noise.width);
		}

		private static void BuildMeshUV0(Mesh mesh, int width, int height, float noiseSize, int noiseWidth)
		{
			float num = noiseSize / ((float)noiseWidth * 1f);
			float num2 = 1f / noiseSize;
			Vector2[] array = new Vector2[width * height * 4];
			int num3 = 0;
			for (int i = 0; i < width * height; i++)
			{
				float f = UnityEngine.Random.Range(0f, noiseSize);
				float f2 = UnityEngine.Random.Range(0f, noiseSize);
				f = Mathf.Floor(f) * num2;
				f2 = Mathf.Floor(f2) * num2;
				ref Vector2 reference = ref array[num3];
				reference = new Vector2(f, f2);
				ref Vector2 reference2 = ref array[num3 + 1];
				reference2 = new Vector2(f + num * num2, f2);
				ref Vector2 reference3 = ref array[num3 + 2];
				reference3 = new Vector2(f + num * num2, f2 + num * num2);
				ref Vector2 reference4 = ref array[num3 + 3];
				reference4 = new Vector2(f, f2 + num * num2);
				num3 += 4;
			}
			mesh.uv = array;
		}
	}
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Noise/Noise and Scratches")]
	public class NoiseAndScratches : MonoBehaviour
	{
		public bool monochrome = true;

		private bool rgbFallback;

		[Range(0f, 5f)]
		public float grainIntensityMin = 0.1f;

		[Range(0f, 5f)]
		public float grainIntensityMax = 0.2f;

		[Range(0.1f, 50f)]
		public float grainSize = 2f;

		[Range(0f, 5f)]
		public float scratchIntensityMin = 0.05f;

		[Range(0f, 5f)]
		public float scratchIntensityMax = 0.25f;

		[Range(1f, 30f)]
		public float scratchFPS = 10f;

		[Range(0f, 1f)]
		public float scratchJitter = 0.01f;

		public Texture grainTexture;

		public Texture scratchTexture;

		public Shader shaderRGB;

		public Shader shaderYUV;

		private Material m_MaterialRGB;

		private Material m_MaterialYUV;

		private float scratchTimeLeft;

		private float scratchX;

		private float scratchY;

		protected Material material
		{
			get
			{
				if (m_MaterialRGB == null)
				{
					m_MaterialRGB = new Material(shaderRGB);
					m_MaterialRGB.hideFlags = HideFlags.HideAndDontSave;
				}
				if (m_MaterialYUV == null && !rgbFallback)
				{
					m_MaterialYUV = new Material(shaderYUV);
					m_MaterialYUV.hideFlags = HideFlags.HideAndDontSave;
				}
				return (rgbFallback || monochrome) ? m_MaterialRGB : m_MaterialYUV;
			}
		}

		protected void Start()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
			}
			else if (shaderRGB == null || shaderYUV == null)
			{
				UnityEngine.Debug.Log("Noise shaders are not set up! Disabling noise effect.");
				base.enabled = false;
			}
			else if (!shaderRGB.isSupported)
			{
				base.enabled = false;
			}
			else if (!shaderYUV.isSupported)
			{
				rgbFallback = true;
			}
		}

		protected void OnDisable()
		{
			if ((bool)m_MaterialRGB)
			{
				UnityEngine.Object.DestroyImmediate(m_MaterialRGB);
			}
			if ((bool)m_MaterialYUV)
			{
				UnityEngine.Object.DestroyImmediate(m_MaterialYUV);
			}
		}

		private void SanitizeParameters()
		{
			grainIntensityMin = Mathf.Clamp(grainIntensityMin, 0f, 5f);
			grainIntensityMax = Mathf.Clamp(grainIntensityMax, 0f, 5f);
			scratchIntensityMin = Mathf.Clamp(scratchIntensityMin, 0f, 5f);
			scratchIntensityMax = Mathf.Clamp(scratchIntensityMax, 0f, 5f);
			scratchFPS = Mathf.Clamp(scratchFPS, 1f, 30f);
			scratchJitter = Mathf.Clamp(scratchJitter, 0f, 1f);
			grainSize = Mathf.Clamp(grainSize, 0.1f, 50f);
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			SanitizeParameters();
			if (scratchTimeLeft <= 0f)
			{
				scratchTimeLeft = UnityEngine.Random.value * 2f / scratchFPS;
				scratchX = UnityEngine.Random.value;
				scratchY = UnityEngine.Random.value;
			}
			scratchTimeLeft -= Time.deltaTime;
			Material material = this.material;
			material.SetTexture("_GrainTex", grainTexture);
			material.SetTexture("_ScratchTex", scratchTexture);
			float num = 1f / grainSize;
			material.SetVector("_GrainOffsetScale", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)grainTexture.width * num, (float)Screen.height / (float)grainTexture.height * num));
			material.SetVector("_ScratchOffsetScale", new Vector4(scratchX + UnityEngine.Random.value * scratchJitter, scratchY + UnityEngine.Random.value * scratchJitter, (float)Screen.width / (float)scratchTexture.width, (float)Screen.height / (float)scratchTexture.height));
			material.SetVector("_Intensity", new Vector4(UnityEngine.Random.Range(grainIntensityMin, grainIntensityMax), UnityEngine.Random.Range(scratchIntensityMin, scratchIntensityMax), 0f, 0f));
			Graphics.Blit(source, destination, material);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class PostEffectsBase : MonoBehaviour
	{
		protected bool supportHDRTextures = true;

		protected bool supportDX11;

		protected bool isSupported = true;

		private List<Material> createdMaterials = new List<Material>();

		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			if (!s)
			{
				UnityEngine.Debug.Log("Missing shader in " + ToString());
				base.enabled = false;
				return null;
			}
			if (s.isSupported && (bool)m2Create && m2Create.shader == s)
			{
				return m2Create;
			}
			if (!s.isSupported)
			{
				NotSupported();
				UnityEngine.Debug.Log("The shader " + s.ToString() + " on effect " + ToString() + " is not supported on this platform!");
				return null;
			}
			m2Create = new Material(s);
			createdMaterials.Add(m2Create);
			m2Create.hideFlags = HideFlags.DontSave;
			return m2Create;
		}

		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			if (!s)
			{
				UnityEngine.Debug.Log("Missing shader in " + ToString());
				return null;
			}
			if ((bool)m2Create && m2Create.shader == s && s.isSupported)
			{
				return m2Create;
			}
			if (!s.isSupported)
			{
				return null;
			}
			m2Create = new Material(s);
			createdMaterials.Add(m2Create);
			m2Create.hideFlags = HideFlags.DontSave;
			return m2Create;
		}

		private void OnEnable()
		{
			isSupported = true;
		}

		private void OnDestroy()
		{
			RemoveCreatedMaterials();
		}

		private void RemoveCreatedMaterials()
		{
			while (createdMaterials.Count > 0)
			{
				Material obj = createdMaterials[0];
				createdMaterials.RemoveAt(0);
				UnityEngine.Object.Destroy(obj);
			}
		}

		protected bool CheckSupport()
		{
			return CheckSupport(needDepth: false);
		}

		public virtual bool CheckResources()
		{
			UnityEngine.Debug.LogWarning("CheckResources () for " + ToString() + " should be overwritten.");
			return isSupported;
		}

		protected void Start()
		{
			CheckResources();
		}

		protected bool CheckSupport(bool needDepth)
		{
			isSupported = true;
			supportHDRTextures = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf);
			supportDX11 = SystemInfo.graphicsShaderLevel >= 50 && SystemInfo.supportsComputeShaders;
			if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
			{
				NotSupported();
				return false;
			}
			if (needDepth && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				NotSupported();
				return false;
			}
			if (needDepth)
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			return true;
		}

		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			if (!CheckSupport(needDepth))
			{
				return false;
			}
			if (needHdr && !supportHDRTextures)
			{
				NotSupported();
				return false;
			}
			return true;
		}

		public bool Dx11Support()
		{
			return supportDX11;
		}

		protected void ReportAutoDisable()
		{
			UnityEngine.Debug.LogWarning("The image effect " + ToString() + " has been disabled as it's not supported on the current platform.");
		}

		private bool CheckShader(Shader s)
		{
			UnityEngine.Debug.Log("The shader " + s.ToString() + " on effect " + ToString() + " is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.");
			if (!s.isSupported)
			{
				NotSupported();
				return false;
			}
			return false;
		}

		protected void NotSupported()
		{
			base.enabled = false;
			isSupported = false;
		}

		protected void DrawBorder(RenderTexture dest, Material material)
		{
			RenderTexture.active = dest;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < material.passCount; i++)
			{
				material.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1f;
					y2 = 0f;
				}
				else
				{
					y = 0f;
					y2 = 1f;
				}
				float x = 0f;
				float x2 = 0f + 1f / ((float)dest.width * 1f);
				float y3 = 0f;
				float y4 = 1f;
				GL.Begin(7);
				GL.TexCoord2(0f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x, y4, 0.1f);
				x = 1f - 1f / ((float)dest.width * 1f);
				x2 = 1f;
				y3 = 0f;
				y4 = 1f;
				GL.TexCoord2(0f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x, y4, 0.1f);
				x = 0f;
				x2 = 1f;
				y3 = 0f;
				y4 = 0f + 1f / ((float)dest.height * 1f);
				GL.TexCoord2(0f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x, y4, 0.1f);
				x = 0f;
				x2 = 1f;
				y3 = 1f - 1f / ((float)dest.height * 1f);
				y4 = 1f;
				GL.TexCoord2(0f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.End();
			}
			GL.PopMatrix();
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	internal class PostEffectsHelper : MonoBehaviour
	{
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			UnityEngine.Debug.Log("OnRenderImage in Helper called ...");
		}

		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
			RenderTexture.active = dest;
			material.SetTexture("_MainTex", source);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(cameraForProjectionMatrix.projectionMatrix);
			float f = cameraForProjectionMatrix.fieldOfView * 0.5f * ((float)Math.PI / 180f);
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = cameraForProjectionMatrix.aspect;
			float num2 = aspect / (0f - num);
			float num3 = aspect / num;
			float num4 = 1f / (0f - num);
			float num5 = 1f / num;
			float num6 = 1f;
			num2 *= dist * num6;
			num3 *= dist * num6;
			num4 *= dist * num6;
			num5 *= dist * num6;
			float z = 0f - dist;
			for (int i = 0; i < material.passCount; i++)
			{
				material.SetPass(i);
				GL.Begin(7);
				float y;
				float y2;
				if (flag)
				{
					y = 1f;
					y2 = 0f;
				}
				else
				{
					y = 0f;
					y2 = 1f;
				}
				GL.TexCoord2(0f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(1f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		private static void DrawBorder(RenderTexture dest, Material material)
		{
			RenderTexture.active = dest;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < material.passCount; i++)
			{
				material.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1f;
					y2 = 0f;
				}
				else
				{
					y = 0f;
					y2 = 1f;
				}
				float x = 0f;
				float x2 = 0f + 1f / ((float)dest.width * 1f);
				float y3 = 0f;
				float y4 = 1f;
				GL.Begin(7);
				GL.TexCoord2(0f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x, y4, 0.1f);
				x = 1f - 1f / ((float)dest.width * 1f);
				x2 = 1f;
				y3 = 0f;
				y4 = 1f;
				GL.TexCoord2(0f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x, y4, 0.1f);
				x = 0f;
				x2 = 1f;
				y3 = 0f;
				y4 = 0f + 1f / ((float)dest.height * 1f);
				GL.TexCoord2(0f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x, y4, 0.1f);
				x = 0f;
				x2 = 1f;
				y3 = 1f - 1f / ((float)dest.height * 1f);
				y4 = 1f;
				GL.TexCoord2(0f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.End();
			}
			GL.PopMatrix();
		}

		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
			RenderTexture.active = dest;
			material.SetTexture("_MainTex", source);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < material.passCount; i++)
			{
				material.SetPass(i);
				GL.Begin(7);
				float y3;
				float y4;
				if (flag)
				{
					y3 = 1f;
					y4 = 0f;
				}
				else
				{
					y3 = 0f;
					y4 = 1f;
				}
				GL.TexCoord2(0f, y3);
				GL.Vertex3(x1, y1, 0.1f);
				GL.TexCoord2(1f, y3);
				GL.Vertex3(x2, y1, 0.1f);
				GL.TexCoord2(1f, y4);
				GL.Vertex3(x2, y2, 0.1f);
				GL.TexCoord2(0f, y4);
				GL.Vertex3(x1, y2, 0.1f);
				GL.End();
			}
			GL.PopMatrix();
		}
	}
	internal class Quads
	{
		private static Mesh[] meshes;

		private static int currentQuads;

		private static bool HasMeshes()
		{
			if (meshes == null)
			{
				return false;
			}
			Mesh[] array = meshes;
			foreach (Mesh mesh in array)
			{
				if (null == mesh)
				{
					return false;
				}
			}
			return true;
		}

		public static void Cleanup()
		{
			if (meshes == null)
			{
				return;
			}
			for (int i = 0; i < meshes.Length; i++)
			{
				if (null != meshes[i])
				{
					UnityEngine.Object.DestroyImmediate(meshes[i]);
					meshes[i] = null;
				}
			}
			meshes = null;
		}

		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			if (HasMeshes() && currentQuads == totalWidth * totalHeight)
			{
				return meshes;
			}
			int num = 10833;
			int num2 = (currentQuads = totalWidth * totalHeight);
			int num3 = Mathf.CeilToInt(1f * (float)num2 / (1f * (float)num));
			meshes = new Mesh[num3];
			int num4 = 0;
			int num5 = 0;
			for (num4 = 0; num4 < num2; num4 += num)
			{
				int triCount = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
				meshes[num5] = GetMesh(triCount, num4, totalWidth, totalHeight);
				num5++;
			}
			return meshes;
		}

		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			Mesh mesh = new Mesh();
			mesh.hideFlags = HideFlags.DontSave;
			Vector3[] array = new Vector3[triCount * 4];
			Vector2[] array2 = new Vector2[triCount * 4];
			Vector2[] array3 = new Vector2[triCount * 4];
			int[] array4 = new int[triCount * 6];
			for (int i = 0; i < triCount; i++)
			{
				int num = i * 4;
				int num2 = i * 6;
				int num3 = triOffset + i;
				float num4 = Mathf.Floor(num3 % totalWidth) / (float)totalWidth;
				float num5 = Mathf.Floor(num3 / totalWidth) / (float)totalHeight;
				Vector3 vector = new Vector3(num4 * 2f - 1f, num5 * 2f - 1f, 1f);
				array[num] = vector;
				array[num + 1] = vector;
				array[num + 2] = vector;
				array[num + 3] = vector;
				ref Vector2 reference = ref array2[num];
				reference = new Vector2(0f, 0f);
				ref Vector2 reference2 = ref array2[num + 1];
				reference2 = new Vector2(1f, 0f);
				ref Vector2 reference3 = ref array2[num + 2];
				reference3 = new Vector2(0f, 1f);
				ref Vector2 reference4 = ref array2[num + 3];
				reference4 = new Vector2(1f, 1f);
				ref Vector2 reference5 = ref array3[num];
				reference5 = new Vector2(num4, num5);
				ref Vector2 reference6 = ref array3[num + 1];
				reference6 = new Vector2(num4, num5);
				ref Vector2 reference7 = ref array3[num + 2];
				reference7 = new Vector2(num4, num5);
				ref Vector2 reference8 = ref array3[num + 3];
				reference8 = new Vector2(num4, num5);
				array4[num2] = num;
				array4[num2 + 1] = num + 1;
				array4[num2 + 2] = num + 2;
				array4[num2 + 3] = num + 1;
				array4[num2 + 4] = num + 2;
				array4[num2 + 5] = num + 3;
			}
			mesh.vertices = array;
			mesh.triangles = array4;
			mesh.uv = array2;
			mesh.uv2 = array3;
			return mesh;
		}
	}
	[AddComponentMenu("Image Effects/Other/Screen Overlay")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class ScreenOverlay : PostEffectsBase
	{
		public enum OverlayBlendMode
		{
			Additive,
			ScreenBlend,
			Multiply,
			Overlay,
			AlphaBlend
		}

		public OverlayBlendMode blendMode = OverlayBlendMode.Overlay;

		public float intensity = 1f;

		public Texture2D texture;

		public Shader overlayShader;

		private Material overlayMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			overlayMaterial = CheckShaderAndCreateMaterial(overlayShader, overlayMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			Vector4 vector = new Vector4(1f, 0f, 0f, 1f);
			overlayMaterial.SetVector("_UV_Transform", vector);
			overlayMaterial.SetFloat("_Intensity", intensity);
			overlayMaterial.SetTexture("_Overlay", texture);
			Graphics.Blit(source, destination, overlayMaterial, (int)blendMode);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Obscurance")]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Range(0f, 3f)]
		public float intensity = 0.5f;

		[Range(0.1f, 3f)]
		public float radius = 0.2f;

		[Range(0f, 3f)]
		public int blurIterations = 1;

		[Range(0f, 5f)]
		public float blurFilterDistance = 1.25f;

		[Range(0f, 1f)]
		public int downsample;

		public Texture2D rand;

		public Shader aoShader;

		private Material aoMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			aoMaterial = CheckShaderAndCreateMaterial(aoShader, aoMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnDisable()
		{
			if ((bool)aoMaterial)
			{
				UnityEngine.Object.DestroyImmediate(aoMaterial);
			}
			aoMaterial = null;
		}

		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			Camera component = GetComponent<Camera>();
			Matrix4x4 projectionMatrix = component.projectionMatrix;
			Matrix4x4 inverse = projectionMatrix.inverse;
			Vector4 vector = new Vector4(-2f / projectionMatrix[0, 0], -2f / projectionMatrix[1, 1], (1f - projectionMatrix[0, 2]) / projectionMatrix[0, 0], (1f + projectionMatrix[1, 2]) / projectionMatrix[1, 1]);
			if (component.stereoEnabled)
			{
				Matrix4x4 stereoProjectionMatrix = component.GetStereoProjectionMatrix(Camera.StereoscopicEye.Left);
				Matrix4x4 stereoProjectionMatrix2 = component.GetStereoProjectionMatrix(Camera.StereoscopicEye.Right);
				Vector4 vector2 = new Vector4(-2f / stereoProjectionMatrix[0, 0], -2f / stereoProjectionMatrix[1, 1], (1f - stereoProjectionMatrix[0, 2]) / stereoProjectionMatrix[0, 0], (1f + stereoProjectionMatrix[1, 2]) / stereoProjectionMatrix[1, 1]);
				Vector4 vector3 = new Vector4(-2f / stereoProjectionMatrix2[0, 0], -2f / stereoProjectionMatrix2[1, 1], (1f - stereoProjectionMatrix2[0, 2]) / stereoProjectionMatrix2[0, 0], (1f + stereoProjectionMatrix2[1, 2]) / stereoProjectionMatrix2[1, 1]);
				aoMaterial.SetVector("_ProjInfoLeft", vector2);
				aoMaterial.SetVector("_ProjInfoRight", vector3);
			}
			aoMaterial.SetVector("_ProjInfo", vector);
			aoMaterial.SetMatrix("_ProjectionInv", inverse);
			aoMaterial.SetTexture("_Rand", rand);
			aoMaterial.SetFloat("_Radius", radius);
			aoMaterial.SetFloat("_Radius2", radius * radius);
			aoMaterial.SetFloat("_Intensity", intensity);
			aoMaterial.SetFloat("_BlurFilterDistance", blurFilterDistance);
			int width = source.width;
			int height = source.height;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width >> downsample, height >> downsample);
			Graphics.Blit(source, renderTexture, aoMaterial, 0);
			if (downsample > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, aoMaterial, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			for (int i = 0; i < blurIterations; i++)
			{
				aoMaterial.SetVector("_Axis", new Vector2(1f, 0f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, aoMaterial, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				aoMaterial.SetVector("_Axis", new Vector2(0f, 1f));
				renderTexture = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(temporary, renderTexture, aoMaterial, 1);
				RenderTexture.ReleaseTemporary(temporary);
			}
			aoMaterial.SetTexture("_AOTex", renderTexture);
			Graphics.Blit(source, destination, aoMaterial, 2);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Occlusion")]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		public enum SSAOSamples
		{
			Low,
			Medium,
			High
		}

		[Range(0.05f, 1f)]
		public float m_Radius = 0.4f;

		public SSAOSamples m_SampleCount = SSAOSamples.Medium;

		[Range(0.5f, 4f)]
		public float m_OcclusionIntensity = 1.5f;

		[Range(0f, 4f)]
		public int m_Blur = 2;

		[Range(1f, 6f)]
		public int m_Downsampling = 2;

		[Range(0.2f, 2f)]
		public float m_OcclusionAttenuation = 1f;

		[Range(1E-05f, 0.5f)]
		public float m_MinZ = 0.01f;

		public Shader m_SSAOShader;

		private Material m_SSAOMaterial;

		public Texture2D m_RandomTexture;

		private bool m_Supported;

		private static Material CreateMaterial(Shader shader)
		{
			if (!shader)
			{
				return null;
			}
			Material material = new Material(shader);
			material.hideFlags = HideFlags.HideAndDontSave;
			return material;
		}

		private static void DestroyMaterial(Material mat)
		{
			if ((bool)mat)
			{
				UnityEngine.Object.DestroyImmediate(mat);
				mat = null;
			}
		}

		private void OnDisable()
		{
			DestroyMaterial(m_SSAOMaterial);
		}

		private void Start()
		{
			if (!SystemInfo.supportsImageEffects || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				m_Supported = false;
				base.enabled = false;
				return;
			}
			CreateMaterials();
			if (!m_SSAOMaterial || m_SSAOMaterial.passCount != 5)
			{
				m_Supported = false;
				base.enabled = false;
			}
			else
			{
				m_Supported = true;
			}
		}

		private void OnEnable()
		{
			GetComponent<Camera>().depthTextureMode |= DepthTextureMode.DepthNormals;
		}

		private void CreateMaterials()
		{
			if (!m_SSAOMaterial && m_SSAOShader.isSupported)
			{
				m_SSAOMaterial = CreateMaterial(m_SSAOShader);
				m_SSAOMaterial.SetTexture("_RandomTexture", m_RandomTexture);
			}
		}

		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!m_Supported || !m_SSAOShader.isSupported)
			{
				base.enabled = false;
				return;
			}
			CreateMaterials();
			m_Downsampling = Mathf.Clamp(m_Downsampling, 1, 6);
			m_Radius = Mathf.Clamp(m_Radius, 0.05f, 1f);
			m_MinZ = Mathf.Clamp(m_MinZ, 1E-05f, 0.5f);
			m_OcclusionIntensity = Mathf.Clamp(m_OcclusionIntensity, 0.5f, 4f);
			m_OcclusionAttenuation = Mathf.Clamp(m_OcclusionAttenuation, 0.2f, 2f);
			m_Blur = Mathf.Clamp(m_Blur, 0, 4);
			RenderTexture renderTexture = RenderTexture.GetTemporary(source.width / m_Downsampling, source.height / m_Downsampling, 0);
			float fieldOfView = GetComponent<Camera>().fieldOfView;
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			float num = Mathf.Tan(fieldOfView * ((float)Math.PI / 180f) * 0.5f) * farClipPlane;
			float x = num * GetComponent<Camera>().aspect;
			m_SSAOMaterial.SetVector("_FarCorner", new Vector3(x, num, farClipPlane));
			int num2;
			int num3;
			if ((bool)m_RandomTexture)
			{
				num2 = m_RandomTexture.width;
				num3 = m_RandomTexture.height;
			}
			else
			{
				num2 = 1;
				num3 = 1;
			}
			m_SSAOMaterial.SetVector("_NoiseScale", new Vector3((float)renderTexture.width / (float)num2, (float)renderTexture.height / (float)num3, 0f));
			m_SSAOMaterial.SetVector("_Params", new Vector4(m_Radius, m_MinZ, 1f / m_OcclusionAttenuation, m_OcclusionIntensity));
			bool flag = m_Blur > 0;
			Graphics.Blit((!flag) ? source : null, renderTexture, m_SSAOMaterial, (int)m_SampleCount);
			if (flag)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(source.width, source.height, 0);
				m_SSAOMaterial.SetVector("_TexelOffsetScale", new Vector4((float)m_Blur / (float)source.width, 0f, 0f, 0f));
				m_SSAOMaterial.SetTexture("_SSAO", renderTexture);
				Graphics.Blit(null, temporary, m_SSAOMaterial, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				RenderTexture temporary2 = RenderTexture.GetTemporary(source.width, source.height, 0);
				m_SSAOMaterial.SetVector("_TexelOffsetScale", new Vector4(0f, (float)m_Blur / (float)source.height, 0f, 0f));
				m_SSAOMaterial.SetTexture("_SSAO", temporary);
				Graphics.Blit(source, temporary2, m_SSAOMaterial, 3);
				RenderTexture.ReleaseTemporary(temporary);
				renderTexture = temporary2;
			}
			m_SSAOMaterial.SetTexture("_SSAO", renderTexture);
			Graphics.Blit(source, destination, m_SSAOMaterial, 4);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
}
namespace UnityStandardAssets.CinematicEffects
{
	[ImageEffectAllowedInSceneView]
	[AddComponentMenu("Image Effects/Rendering/Screen Space Reflection")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class ScreenSpaceReflection : MonoBehaviour
	{
		public enum SSRDebugMode
		{
			None,
			IncomingRadiance,
			SSRResult,
			FinalGlossyTerm,
			SSRMask,
			Roughness,
			BaseColor,
			SpecColor,
			Reflectivity,
			ReflectionProbeOnly,
			ReflectionProbeMinusSSR,
			SSRMinusReflectionProbe,
			NoGlossy,
			NegativeNoGlossy,
			MipLevel
		}

		public enum SSRResolution
		{
			FullResolution,
			HalfTraceFullResolve,
			HalfResolution
		}

		[Serializable]
		public struct SSRSettings
		{
			[AttributeUsage(AttributeTargets.Field)]
			public class LayoutAttribute : PropertyAttribute
			{
			}

			[Layout]
			public BasicSettings basicSettings;

			[Layout]
			public ReflectionSettings reflectionSettings;

			[Layout]
			public AdvancedSettings advancedSettings;

			[Layout]
			public DebugSettings debugSettings;

			private static readonly SSRSettings s_Performance = new SSRSettings
			{
				basicSettings = new BasicSettings
				{
					screenEdgeFading = 0f,
					maxDistance = 10f,
					fadeDistance = 10f,
					reflectionMultiplier = 1f,
					enableHDR = false,
					additiveReflection = false
				},
				reflectionSettings = new ReflectionSettings
				{
					maxSteps = 64,
					rayStepSize = 4,
					widthModifier = 0.5f,
					smoothFallbackThreshold = 0.4f,
					distanceBlur = 1f,
					fresnelFade = 0.2f,
					fresnelFadePower = 2f,
					smoothFallbackDistance = 0.05f
				},
				advancedSettings = new AdvancedSettings
				{
					useTemporalConfidence = false,
					temporalFilterStrength = 0f,
					treatBackfaceHitAsMiss = false,
					allowBackwardsRays = false,
					traceBehindObjects = true,
					highQualitySharpReflections = false,
					traceEverywhere = false,
					resolution = SSRResolution.HalfResolution,
					bilateralUpsample = false,
					improveCorners = false,
					reduceBanding = false,
					highlightSuppression = false
				},
				debugSettings = new DebugSettings
				{
					debugMode = SSRDebugMode.None
				}
			};

			private static readonly SSRSettings s_Default = new SSRSettings
			{
				basicSettings = new BasicSettings
				{
					screenEdgeFading = 0.03f,
					maxDistance = 100f,
					fadeDistance = 100f,
					reflectionMultiplier = 1f,
					enableHDR = true,
					additiveReflection = false
				},
				reflectionSettings = new ReflectionSettings
				{
					maxSteps = 128,
					rayStepSize = 3,
					widthModifier = 0.5f,
					smoothFallbackThreshold = 0.2f,
					distanceBlur = 1f,
					fresnelFade = 0.2f,
					fresnelFadePower = 2f,
					smoothFallbackDistance = 0.05f
				},
				advancedSettings = new AdvancedSettings
				{
					useTemporalConfidence = true,
					temporalFilterStrength = 0.7f,
					treatBackfaceHitAsMiss = false,
					allowBackwardsRays = false,
					traceBehindObjects = true,
					highQualitySharpReflections = true,
					traceEverywhere = true,
					resolution = SSRResolution.HalfTraceFullResolve,
					bilateralUpsample = true,
					improveCorners = true,
					reduceBanding = true,
					highlightSuppression = false
				},
				debugSettings = new DebugSettings
				{
					debugMode = SSRDebugMode.None
				}
			};

			private static readonly SSRSettings s_HighQuality = new SSRSettings
			{
				basicSettings = new BasicSettings
				{
					screenEdgeFading = 0.03f,
					maxDistance = 100f,
					fadeDistance = 100f,
					reflectionMultiplier = 1f,
					enableHDR = true,
					additiveReflection = false
				},
				reflectionSettings = new ReflectionSettings
				{
					maxSteps = 512,
					rayStepSize = 1,
					widthModifier = 0.5f,
					smoothFallbackThreshold = 0.2f,
					distanceBlur = 1f,
					fresnelFade = 0.2f,
					fresnelFadePower = 2f,
					smoothFallbackDistance = 0.05f
				},
				advancedSettings = new AdvancedSettings
				{
					useTemporalConfidence = true,
					temporalFilterStrength = 0.7f,
					treatBackfaceHitAsMiss = false,
					allowBackwardsRays = false,
					traceBehindObjects = true,
					highQualitySharpReflections = true,
					traceEverywhere = true,
					resolution = SSRResolution.HalfTraceFullResolve,
					bilateralUpsample = true,
					improveCorners = true,
					reduceBanding = true,
					highlightSuppression = false
				},
				debugSettings = new DebugSettings
				{
					debugMode = SSRDebugMode.None
				}
			};

			public static SSRSettings performanceSettings => s_Performance;

			public static SSRSettings defaultSettings => s_Default;

			public static SSRSettings highQualitySettings => s_HighQuality;
		}

		[Serializable]
		public struct BasicSettings
		{
			[Tooltip("Nonphysical multiplier for the SSR reflections. 1.0 is physically based.")]
			[Range(0f, 2f)]
			public float reflectionMultiplier;

			[Tooltip("Maximum reflection distance in world units.")]
			[Range(0.5f, 1000f)]
			public float maxDistance;

			[Range(0f, 1000f)]
			[Tooltip("How far away from the maxDistance to begin fading SSR.")]
			public float fadeDistance;

			[Range(0f, 1f)]
			[Tooltip("Higher = fade out SSRR near the edge of the screen so that reflections don't pop under camera motion.")]
			public float screenEdgeFading;

			[Tooltip("Enable for better reflections of very bright objects at a performance cost")]
			public bool enableHDR;

			[Tooltip("Add reflections on top of existing ones. Not physically correct.")]
			public bool additiveReflection;
		}

		[Serializable]
		public struct ReflectionSettings
		{
			[Range(16f, 2048f)]
			[Tooltip("Max raytracing length.")]
			public int maxSteps;

			[Range(0f, 4f)]
			[Tooltip("Log base 2 of ray tracing coarse step size. Higher traces farther, lower gives better quality silhouettes.")]
			public int rayStepSize;

			[Range(0.01f, 10f)]
			[Tooltip("Typical thickness of columns, walls, furniture, and other objects that reflection rays might pass behind.")]
			public float widthModifier;

			[Tooltip("Increase if reflections flicker on very rough surfaces.")]
			[Range(0f, 1f)]
			public float smoothFallbackThreshold;

			[Range(0f, 0.2f)]
			[Tooltip("Start falling back to non-SSR value solution at smoothFallbackThreshold - smoothFallbackDistance, with full fallback occuring at smoothFallbackThreshold.")]
			public float smoothFallbackDistance;

			[Tooltip("Amplify Fresnel fade out. Increase if floor reflections look good close to the surface and bad farther 'under' the floor.")]
			[Range(0f, 1f)]
			public float fresnelFade;

			[Tooltip("Higher values correspond to a faster Fresnel fade as the reflection changes from the grazing angle.")]
			[Range(0.1f, 10f)]
			public float fresnelFadePower;

			[Range(0f, 1f)]
			[Tooltip("Controls how blurry reflections get as objects are further from the camera. 0 is constant blur no matter trace distance or distance from camera. 1 fully takes into account both factors.")]
			public float distanceBlur;
		}

		[Serializable]
		public struct AdvancedSettings
		{
			[Range(0f, 0.99f)]
			[Tooltip("Increase to decrease flicker in scenes; decrease to prevent ghosting (especially in dynamic scenes). 0 gives maximum performance.")]
			public float temporalFilterStrength;

			[Tooltip("Enable to limit ghosting from applying the temporal filter.")]
			public bool useTemporalConfidence;

			[Tooltip("Enable to allow rays to pass behind objects. This can lead to more screen-space reflections, but the reflections are more likely to be wrong.")]
			public bool traceBehindObjects;

			[Tooltip("Enable to increase quality of the sharpest reflections (through filtering), at a performance cost.")]
			public bool highQualitySharpReflections;

			[Tooltip("Improves quality in scenes with varying smoothness, at a potential performance cost.")]
			public bool traceEverywhere;

			[Tooltip("Enable to force more surfaces to use reflection probes if you see streaks on the sides of objects or bad reflections of their backs.")]
			public bool treatBackfaceHitAsMiss;

			[Tooltip("Enable for a performance gain in scenes where most glossy objects are horizontal, like floors, water, and tables. Leave on for scenes with glossy vertical objects.")]
			public bool allowBackwardsRays;

			[Tooltip("Improve visual fidelity of reflections on rough surfaces near corners in the scene, at the cost of a small amount of performance.")]
			public bool improveCorners;

			[Tooltip("Half resolution SSRR is much faster, but less accurate. Quality can be reclaimed for some performance by doing the resolve at full resolution.")]
			public SSRResolution resolution;

			[Tooltip("Drastically improves reflection reconstruction quality at the expense of some performance.")]
			public bool bilateralUpsample;

			[Tooltip("Improve visual fidelity of mirror reflections at the cost of a small amount of performance.")]
			public bool reduceBanding;

			[Tooltip("Enable to limit the effect a few bright pixels can have on rougher surfaces")]
			public bool highlightSuppression;
		}

		[Serializable]
		public struct DebugSettings
		{
			[Tooltip("Various Debug Visualizations")]
			public SSRDebugMode debugMode;
		}

		private enum PassIndex
		{
			RayTraceStep1,
			RayTraceStep2,
			RayTraceStep4,
			RayTraceStep8,
			RayTraceStep16,
			CompositeFinal,
			Blur,
			CompositeSSR,
			Blit,
			EdgeGeneration,
			MinMipGeneration,
			HitPointToReflections,
			BilateralKeyPack,
			BlitDepthAsCSZ,
			TemporalFilter,
			AverageRayDistanceGeneration,
			PoissonBlur
		}

		[SerializeField]
		public SSRSettings settings = SSRSettings.defaultSettings;

		[Tooltip("Enable to try and bypass expensive bilateral upsampling away from edges. There is a slight performance hit for generating the edge buffers, but a potentially high performance savings from bypassing bilateral upsampling where it is unneeded. Test on your target platforms to see if performance improves.")]
		private bool useEdgeDetector;

		[Range(-4f, 4f)]
		private float mipBias;

		private bool useOcclusion = true;

		private bool fullResolutionFiltering;

		private bool fallbackToSky;

		private bool computeAverageRayDistance;

		private bool m_HasInformationFromPreviousFrame;

		private Matrix4x4 m_PreviousWorldToCameraMatrix;

		private RenderTexture m_PreviousDepthBuffer;

		private RenderTexture m_PreviousHitBuffer;

		private RenderTexture m_PreviousReflectionBuffer;

		[NonSerialized]
		private RenderTextureUtility m_RTU = new RenderTextureUtility();

		[SerializeField]
		private Shader m_Shader;

		private Material m_Material;

		public Shader shader
		{
			get
			{
				if (m_Shader == null)
				{
					m_Shader = Shader.Find("Hidden/ScreenSpaceReflection");
				}
				return m_Shader;
			}
		}

		public Material material
		{
			get
			{
				if (m_Material == null)
				{
					m_Material = ImageEffectHelper.CheckShaderAndCreateMaterial(shader);
				}
				return m_Material;
			}
		}

		private void OnEnable()
		{
			if (!ImageEffectHelper.IsSupported(shader, needDepth: false, needHdr: true, this))
			{
				base.enabled = false;
			}
			else
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
		}

		private void OnDisable()
		{
			if ((bool)m_Material)
			{
				UnityEngine.Object.DestroyImmediate(m_Material);
			}
			if ((bool)m_PreviousDepthBuffer)
			{
				UnityEngine.Object.DestroyImmediate(m_PreviousDepthBuffer);
			}
			if ((bool)m_PreviousHitBuffer)
			{
				UnityEngine.Object.DestroyImmediate(m_PreviousHitBuffer);
			}
			if ((bool)m_PreviousReflectionBuffer)
			{
				UnityEngine.Object.DestroyImmediate(m_PreviousReflectionBuffer);
			}
			m_Material = null;
			m_PreviousDepthBuffer = null;
			m_PreviousHitBuffer = null;
			m_PreviousReflectionBuffer = null;
		}

		private void PreparePreviousBuffers(int w, int h)
		{
			if (m_PreviousDepthBuffer != null && (m_PreviousDepthBuffer.width != w || m_PreviousDepthBuffer.height != h))
			{
				UnityEngine.Object.DestroyImmediate(m_PreviousDepthBuffer);
				UnityEngine.Object.DestroyImmediate(m_PreviousHitBuffer);
				UnityEngine.Object.DestroyImmediate(m_PreviousReflectionBuffer);
				m_PreviousDepthBuffer = null;
				m_PreviousHitBuffer = null;
				m_PreviousReflectionBuffer = null;
			}
			if (m_PreviousDepthBuffer == null)
			{
				m_PreviousDepthBuffer = new RenderTexture(w, h, 0, RenderTextureFormat.RFloat);
				m_PreviousHitBuffer = new RenderTexture(w, h, 0, RenderTextureFormat.ARGBHalf);
				m_PreviousReflectionBuffer = new RenderTexture(w, h, 0, RenderTextureFormat.ARGBHalf);
			}
		}

		[ImageEffectOpaque]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (material == null)
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (m_HasInformationFromPreviousFrame)
			{
				m_HasInformationFromPreviousFrame = m_PreviousDepthBuffer != null && source.width == m_PreviousDepthBuffer.width && source.height == m_PreviousDepthBuffer.height;
			}
			bool flag = m_HasInformationFromPreviousFrame && (double)settings.advancedSettings.temporalFilterStrength > 0.0;
			m_HasInformationFromPreviousFrame = false;
			if (Camera.current.actualRenderingPath != RenderingPath.DeferredShading)
			{
				Graphics.Blit(source, destination);
				return;
			}
			int width = source.width;
			int height = source.height;
			RenderTexture temporaryRenderTexture = m_RTU.GetTemporaryRenderTexture(width, height, 0, RenderTextureFormat.ARGB32);
			temporaryRenderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(source, temporaryRenderTexture, material, 12);
			material.SetTexture("_NormalAndRoughnessTexture", temporaryRenderTexture);
			float num = source.width;
			float num2 = source.height;
			Vector2 vector = new Vector2(num / (float)width, num2 / (float)height);
			int num3 = ((settings.advancedSettings.resolution == SSRResolution.FullResolution) ? 1 : 2);
			width /= num3;
			height /= num3;
			material.SetVector("_SourceToTempUV", new Vector4(vector.x, vector.y, 1f / vector.x, 1f / vector.y));
			Matrix4x4 projectionMatrix = GetComponent<Camera>().projectionMatrix;
			Vector4 vector2 = new Vector4(-2f / (num * projectionMatrix[0]), -2f / (num2 * projectionMatrix[5]), (1f - projectionMatrix[2]) / projectionMatrix[0], (1f + projectionMatrix[6]) / projectionMatrix[5]);
			float value = num / (-2f * (float)Math.Tan((double)GetComponent<Camera>().fieldOfView / 180.0 * Math.PI * 0.5));
			material.SetFloat("_PixelsPerMeterAtOneMeter", value);
			float num4 = num / 2f;
			float num5 = num2 / 2f;
			Matrix4x4 matrix4x = default(Matrix4x4);
			matrix4x.SetRow(0, new Vector4(num4, 0f, 0f, num4));
			matrix4x.SetRow(1, new Vector4(0f, num5, 0f, num5));
			matrix4x.SetRow(2, new Vector4(0f, 0f, 1f, 0f));
			matrix4x.SetRow(3, new Vector4(0f, 0f, 0f, 1f));
			Matrix4x4 matrix = matrix4x * projectionMatrix;
			material.SetVector("_ScreenSize", new Vector2(num, num2));
			material.SetVector("_ReflectionBufferSize", new Vector2(width, height));
			Vector2 vector3 = new Vector2((float)(1.0 / (double)num), (float)(1.0 / (double)num2));
			Matrix4x4 worldToCameraMatrix = GetComponent<Camera>().worldToCameraMatrix;
			Matrix4x4 inverse = GetComponent<Camera>().worldToCameraMatrix.inverse;
			material.SetVector("_InvScreenSize", vector3);
			material.SetVector("_ProjInfo", vector2);
			material.SetMatrix("_ProjectToPixelMatrix", matrix);
			material.SetMatrix("_WorldToCameraMatrix", worldToCameraMatrix);
			material.SetMatrix("_CameraToWorldMatrix", inverse);
			material.SetInt("_EnableRefine", settings.advancedSettings.reduceBanding ? 1 : 0);
			material.SetInt("_AdditiveReflection", settings.basicSettings.additiveReflection ? 1 : 0);
			material.SetInt("_ImproveCorners", settings.advancedSettings.improveCorners ? 1 : 0);
			material.SetFloat("_ScreenEdgeFading", settings.basicSettings.screenEdgeFading);
			material.SetFloat("_MipBias", mipBias);
			material.SetInt("_UseOcclusion", useOcclusion ? 1 : 0);
			material.SetInt("_BilateralUpsampling", settings.advancedSettings.bilateralUpsample ? 1 : 0);
			material.SetInt("_FallbackToSky", fallbackToSky ? 1 : 0);
			material.SetInt("_TreatBackfaceHitAsMiss", settings.advancedSettings.treatBackfaceHitAsMiss ? 1 : 0);
			material.SetInt("_AllowBackwardsRays", settings.advancedSettings.allowBackwardsRays ? 1 : 0);
			material.SetInt("_TraceEverywhere", settings.advancedSettings.traceEverywhere ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			float nearClipPlane = GetComponent<Camera>().nearClipPlane;
			Vector3 vector4 = ((!float.IsPositiveInfinity(farClipPlane)) ? new Vector3(nearClipPlane * farClipPlane, nearClipPlane - farClipPlane, farClipPlane) : new Vector3(nearClipPlane, -1f, 1f));
			material.SetVector("_CameraClipInfo", vector4);
			material.SetFloat("_MaxRayTraceDistance", settings.basicSettings.maxDistance);
			material.SetFloat("_FadeDistance", settings.basicSettings.fadeDistance);
			material.SetFloat("_LayerThickness", settings.reflectionSettings.widthModifier);
			RenderTextureFormat format = (settings.basicSettings.enableHDR ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.ARGB32);
			RenderTexture[] array = new RenderTexture[5];
			for (int i = 0; i < 5; i++)
			{
				if (fullResolutionFiltering)
				{
					array[i] = m_RTU.GetTemporaryRenderTexture(width, height, 0, format);
				}
				else
				{
					array[i] = m_RTU.GetTemporaryRenderTexture(width >> i, height >> i, 0, format);
				}
				array[i].filterMode = ((!settings.advancedSettings.bilateralUpsample) ? FilterMode.Bilinear : FilterMode.Point);
			}
			material.SetInt("_EnableSSR", 1);
			material.SetInt("_DebugMode", (int)settings.debugSettings.debugMode);
			material.SetInt("_TraceBehindObjects", settings.advancedSettings.traceBehindObjects ? 1 : 0);
			material.SetInt("_MaxSteps", settings.reflectionSettings.maxSteps);
			RenderTexture temporaryRenderTexture2 = m_RTU.GetTemporaryRenderTexture(width, height);
			int pass = Mathf.Clamp(settings.reflectionSettings.rayStepSize, 0, 4);
			Graphics.Blit(source, temporaryRenderTexture2, material, pass);
			material.SetTexture("_HitPointTexture", temporaryRenderTexture2);
			Graphics.Blit(source, array[0], material, 11);
			material.SetTexture("_ReflectionTexture0", array[0]);
			material.SetInt("_FullResolutionFiltering", fullResolutionFiltering ? 1 : 0);
			material.SetFloat("_MaxRoughness", 1f - settings.reflectionSettings.smoothFallbackThreshold);
			material.SetFloat("_RoughnessFalloffRange", settings.reflectionSettings.smoothFallbackDistance);
			material.SetFloat("_SSRMultiplier", settings.basicSettings.reflectionMultiplier);
			RenderTexture[] array2 = new RenderTexture[5];
			if (settings.advancedSettings.bilateralUpsample && useEdgeDetector)
			{
				array2[0] = m_RTU.GetTemporaryRenderTexture(width, height);
				Graphics.Blit(source, array2[0], material, 9);
				for (int j = 1; j < 5; j++)
				{
					array2[j] = m_RTU.GetTemporaryRenderTexture(width >> j, height >> j);
					material.SetInt("_LastMip", j - 1);
					Graphics.Blit(array2[j - 1], array2[j], material, 10);
				}
			}
			if (settings.advancedSettings.highQualitySharpReflections)
			{
				RenderTexture temporaryRenderTexture3 = m_RTU.GetTemporaryRenderTexture(array[0].width, array[0].height, 0, array[0].format);
				temporaryRenderTexture3.filterMode = array[0].filterMode;
				array[0].filterMode = FilterMode.Bilinear;
				Graphics.Blit(array[0], temporaryRenderTexture3, material, 16);
				m_RTU.ReleaseTemporaryRenderTexture(array[0]);
				array[0] = temporaryRenderTexture3;
				material.SetTexture("_ReflectionTexture0", array[0]);
			}
			for (int k = 1; k < 5; k++)
			{
				RenderTexture renderTexture = array[k - 1];
				RenderTexture temporaryRenderTexture4;
				if (fullResolutionFiltering)
				{
					temporaryRenderTexture4 = m_RTU.GetTemporaryRenderTexture(width, height, 0, format);
				}
				else
				{
					int num6 = k;
					temporaryRenderTexture4 = m_RTU.GetTemporaryRenderTexture(width >> num6, height >> k - 1, 0, format);
				}
				for (int l = 0; l < ((!fullResolutionFiltering) ? 1 : (k * k)); l++)
				{
					material.SetVector("_Axis", new Vector4(1f, 0f, 0f, 0f));
					material.SetFloat("_CurrentMipLevel", (float)k - 1f);
					Graphics.Blit(renderTexture, temporaryRenderTexture4, material, 6);
					material.SetVector("_Axis", new Vector4(0f, 1f, 0f, 0f));
					renderTexture = array[k];
					Graphics.Blit(temporaryRenderTexture4, renderTexture, material, 6);
				}
				material.SetTexture("_ReflectionTexture" + k, array[k]);
				m_RTU.ReleaseTemporaryRenderTexture(temporaryRenderTexture4);
			}
			if (settings.advancedSettings.bilateralUpsample && useEdgeDetector)
			{
				for (int m = 0; m < 5; m++)
				{
					material.SetTexture("_EdgeTexture" + m, array2[m]);
				}
			}
			material.SetInt("_UseEdgeDetector", useEdgeDetector ? 1 : 0);
			RenderTexture temporaryRenderTexture5 = m_RTU.GetTemporaryRenderTexture(source.width, source.height, 0, RenderTextureFormat.RHalf);
			if (computeAverageRayDistance)
			{
				Graphics.Blit(source, temporaryRenderTexture5, material, 15);
			}
			material.SetInt("_UseAverageRayDistance", computeAverageRayDistance ? 1 : 0);
			material.SetTexture("_AverageRayDistanceBuffer", temporaryRenderTexture5);
			bool flag2 = settings.advancedSettings.resolution == SSRResolution.HalfTraceFullResolve;
			RenderTexture temporaryRenderTexture6 = m_RTU.GetTemporaryRenderTexture((!flag2) ? width : source.width, (!flag2) ? height : source.height, 0, format);
			material.SetFloat("_FresnelFade", settings.reflectionSettings.fresnelFade);
			material.SetFloat("_FresnelFadePower", settings.reflectionSettings.fresnelFadePower);
			material.SetFloat("_DistanceBlur", settings.reflectionSettings.distanceBlur);
			material.SetInt("_HalfResolution", (settings.advancedSettings.resolution != SSRResolution.FullResolution) ? 1 : 0);
			material.SetInt("_HighlightSuppression", settings.advancedSettings.highlightSuppression ? 1 : 0);
			Graphics.Blit(array[0], temporaryRenderTexture6, material, 7);
			material.SetTexture("_FinalReflectionTexture", temporaryRenderTexture6);
			RenderTexture temporaryRenderTexture7 = m_RTU.GetTemporaryRenderTexture((!flag2) ? width : source.width, (!flag2) ? height : source.height, 0, format);
			if (flag)
			{
				material.SetInt("_UseTemporalConfidence", settings.advancedSettings.useTemporalConfidence ? 1 : 0);
				material.SetFloat("_TemporalAlpha", settings.advancedSettings.temporalFilterStrength);
				material.SetMatrix("_CurrentCameraToPreviousCamera", m_PreviousWorldToCameraMatrix * inverse);
				material.SetTexture("_PreviousReflectionTexture", m_PreviousReflectionBuffer);
				material.SetTexture("_PreviousCSZBuffer", m_PreviousDepthBuffer);
				Graphics.Blit(source, temporaryRenderTexture7, material, 14);
				material.SetTexture("_FinalReflectionTexture", temporaryRenderTexture7);
			}
			if ((double)settings.advancedSettings.temporalFilterStrength > 0.0)
			{
				m_PreviousWorldToCameraMatrix = worldToCameraMatrix;
				PreparePreviousBuffers(source.width, source.height);
				Graphics.Blit(source, m_PreviousDepthBuffer, material, 13);
				Graphics.Blit(temporaryRenderTexture2, m_PreviousHitBuffer);
				Graphics.Blit((!flag) ? temporaryRenderTexture6 : temporaryRenderTexture7, m_PreviousReflectionBuffer);
				m_HasInformationFromPreviousFrame = true;
			}
			Graphics.Blit(source, destination, material, 5);
			m_RTU.ReleaseAllTemporaryRenderTextures();
		}
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Sepia Tone")]
	public class SepiaTone : ImageEffectBase
	{
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			Graphics.Blit(source, destination, base.material);
		}
	}
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Sun Shafts")]
	[ExecuteInEditMode]
	public class SunShafts : PostEffectsBase
	{
		public enum SunShaftsResolution
		{
			Low,
			Normal,
			High
		}

		public enum ShaftsScreenBlendMode
		{
			Screen,
			Add
		}

		public SunShaftsResolution resolution = SunShaftsResolution.Normal;

		public ShaftsScreenBlendMode screenBlendMode;

		public Transform sunTransform;

		public int radialBlurIterations = 2;

		public Color sunColor = Color.white;

		public Color sunThreshold = new Color(0.87f, 0.74f, 0.65f);

		public float sunShaftBlurRadius = 2.5f;

		public float sunShaftIntensity = 1.15f;

		public float maxRadius = 0.75f;

		public bool useDepthTexture = true;

		public Shader sunShaftsShader;

		private Material sunShaftsMaterial;

		public Shader simpleClearShader;

		private Material simpleClearMaterial;

		public override bool CheckResources()
		{
			CheckSupport(useDepthTexture);
			sunShaftsMaterial = CheckShaderAndCreateMaterial(sunShaftsShader, sunShaftsMaterial);
			simpleClearMaterial = CheckShaderAndCreateMaterial(simpleClearShader, simpleClearMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (useDepthTexture)
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 4;
			if (resolution == SunShaftsResolution.Normal)
			{
				num = 2;
			}
			else if (resolution == SunShaftsResolution.High)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 0.5f;
			vector = ((!sunTransform) ? new Vector3(0.5f, 0.5f, 0f) : GetComponent<Camera>().WorldToViewportPoint(sunTransform.position));
			int width = source.width / num;
			int height = source.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(1f, 1f, 0f, 0f) * sunShaftBlurRadius);
			sunShaftsMaterial.SetVector("_SunPosition", new Vector4(vector.x, vector.y, vector.z, maxRadius));
			sunShaftsMaterial.SetVector("_SunThreshold", sunThreshold);
			if (!useDepthTexture)
			{
				RenderTextureFormat format = ((!GetComponent<Camera>().hdr) ? RenderTextureFormat.Default : RenderTextureFormat.DefaultHDR);
				RenderTexture renderTexture = (RenderTexture.active = RenderTexture.GetTemporary(source.width, source.height, 0, format));
				GL.ClearWithSkybox(clearDepth: false, GetComponent<Camera>());
				sunShaftsMaterial.SetTexture("_Skybox", renderTexture);
				Graphics.Blit(source, temporary, sunShaftsMaterial, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
			else
			{
				Graphics.Blit(source, temporary, sunShaftsMaterial, 2);
			}
			DrawBorder(temporary, simpleClearMaterial);
			radialBlurIterations = Mathf.Clamp(radialBlurIterations, 1, 4);
			float num2 = sunShaftBlurRadius * 0.0013020834f;
			sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(num2, num2, 0f, 0f));
			sunShaftsMaterial.SetVector("_SunPosition", new Vector4(vector.x, vector.y, vector.z, maxRadius));
			for (int i = 0; i < radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, sunShaftsMaterial, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = sunShaftBlurRadius * (((float)i * 2f + 1f) * 6f) / 768f;
				sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(num2, num2, 0f, 0f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, sunShaftsMaterial, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = sunShaftBlurRadius * (((float)i * 2f + 2f) * 6f) / 768f;
				sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(num2, num2, 0f, 0f));
			}
			if (vector.z >= 0f)
			{
				sunShaftsMaterial.SetVector("_SunColor", new Vector4(sunColor.r, sunColor.g, sunColor.b, sunColor.a) * sunShaftIntensity);
			}
			else
			{
				sunShaftsMaterial.SetVector("_SunColor", Vector4.zero);
			}
			sunShaftsMaterial.SetTexture("_ColorBuffer", temporary);
			Graphics.Blit(source, destination, sunShaftsMaterial, (screenBlendMode != ShaftsScreenBlendMode.Screen) ? 4 : 0);
			RenderTexture.ReleaseTemporary(temporary);
		}
	}
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Tilt Shift (Lens Blur)")]
	internal class TiltShift : PostEffectsBase
	{
		public enum TiltShiftMode
		{
			TiltShiftMode,
			IrisMode
		}

		public enum TiltShiftQuality
		{
			Preview,
			Normal,
			High
		}

		public TiltShiftMode mode;

		public TiltShiftQuality quality = TiltShiftQuality.Normal;

		[Range(0f, 15f)]
		public float blurArea = 1f;

		[Range(0f, 25f)]
		public float maxBlurSize = 5f;

		[Range(0f, 1f)]
		public int downsample;

		public Shader tiltShiftShader;

		private Material tiltShiftMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			tiltShiftMaterial = CheckShaderAndCreateMaterial(tiltShiftShader, tiltShiftMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			tiltShiftMaterial.SetFloat("_BlurSize", (!(maxBlurSize < 0f)) ? maxBlurSize : 0f);
			tiltShiftMaterial.SetFloat("_BlurArea", blurArea);
			source.filterMode = FilterMode.Bilinear;
			RenderTexture renderTexture = destination;
			if ((float)downsample > 0f)
			{
				renderTexture = RenderTexture.GetTemporary(source.width >> downsample, source.height >> downsample, 0, source.format);
				renderTexture.filterMode = FilterMode.Bilinear;
			}
			int num = (int)quality;
			num *= 2;
			Graphics.Blit(source, renderTexture, tiltShiftMaterial, (mode != TiltShiftMode.TiltShiftMode) ? (num + 1) : num);
			if (downsample > 0)
			{
				tiltShiftMaterial.SetTexture("_Blurred", renderTexture);
				Graphics.Blit(source, destination, tiltShiftMaterial, 6);
			}
			if (renderTexture != destination)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Color Adjustments/Tonemapping")]
	[ImageEffectAllowedInSceneView]
	public class Tonemapping : PostEffectsBase
	{
		public enum TonemapperType
		{
			SimpleReinhard,
			UserCurve,
			Hable,
			Photographic,
			OptimizedHejiDawson,
			AdaptiveReinhard,
			AdaptiveReinhardAutoWhite
		}

		public enum AdaptiveTexSize
		{
			Square16 = 0x10,
			Square32 = 0x20,
			Square64 = 0x40,
			Square128 = 0x80,
			Square256 = 0x100,
			Square512 = 0x200,
			Square1024 = 0x400
		}

		public TonemapperType type = TonemapperType.Photographic;

		public AdaptiveTexSize adaptiveTextureSize = AdaptiveTexSize.Square256;

		public AnimationCurve remapCurve;

		private Texture2D curveTex;

		public float exposureAdjustment = 1.5f;

		public float middleGrey = 0.4f;

		public float white = 2f;

		public float adaptionSpeed = 1.5f;

		public Shader tonemapper;

		public bool validRenderTextureFormat = true;

		private Material tonemapMaterial;

		private RenderTexture rt;

		private RenderTextureFormat rtFormat = RenderTextureFormat.ARGBHalf;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false, needHdr: true);
			tonemapMaterial = CheckShaderAndCreateMaterial(tonemapper, tonemapMaterial);
			if (!curveTex && type == TonemapperType.UserCurve)
			{
				curveTex = new Texture2D(256, 1, TextureFormat.ARGB32, mipmap: false, linear: true);
				curveTex.filterMode = FilterMode.Bilinear;
				curveTex.wrapMode = TextureWrapMode.Clamp;
				curveTex.hideFlags = HideFlags.DontSave;
			}
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		public float UpdateCurve()
		{
			float num = 1f;
			if (remapCurve.keys.Length < 1)
			{
				remapCurve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(2f, 1f));
			}
			if (remapCurve != null)
			{
				if (remapCurve.length > 0)
				{
					num = remapCurve[remapCurve.length - 1].time;
				}
				for (float num2 = 0f; num2 <= 1f; num2 += 0.003921569f)
				{
					float num3 = remapCurve.Evaluate(num2 * 1f * num);
					curveTex.SetPixel((int)Mathf.Floor(num2 * 255f), 0, new Color(num3, num3, num3));
				}
				curveTex.Apply();
			}
			return 1f / num;
		}

		private void OnDisable()
		{
			if ((bool)rt)
			{
				UnityEngine.Object.DestroyImmediate(rt);
				rt = null;
			}
			if ((bool)tonemapMaterial)
			{
				UnityEngine.Object.DestroyImmediate(tonemapMaterial);
				tonemapMaterial = null;
			}
			if ((bool)curveTex)
			{
				UnityEngine.Object.DestroyImmediate(curveTex);
				curveTex = null;
			}
		}

		private bool CreateInternalRenderTexture()
		{
			if ((bool)rt)
			{
				return false;
			}
			rtFormat = ((!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGHalf)) ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.RGHalf);
			rt = new RenderTexture(1, 1, 0, rtFormat);
			rt.hideFlags = HideFlags.DontSave;
			return true;
		}

		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			exposureAdjustment = ((!(exposureAdjustment < 0.001f)) ? exposureAdjustment : 0.001f);
			if (type == TonemapperType.UserCurve)
			{
				float value = UpdateCurve();
				tonemapMaterial.SetFloat("_RangeScale", value);
				tonemapMaterial.SetTexture("_Curve", curveTex);
				Graphics.Blit(source, destination, tonemapMaterial, 4);
				return;
			}
			if (type == TonemapperType.SimpleReinhard)
			{
				tonemapMaterial.SetFloat("_ExposureAdjustment", exposureAdjustment);
				Graphics.Blit(source, destination, tonemapMaterial, 6);
				return;
			}
			if (type == TonemapperType.Hable)
			{
				tonemapMaterial.SetFloat("_ExposureAdjustment", exposureAdjustment);
				Graphics.Blit(source, destination, tonemapMaterial, 5);
				return;
			}
			if (type == TonemapperType.Photographic)
			{
				tonemapMaterial.SetFloat("_ExposureAdjustment", exposureAdjustment);
				Graphics.Blit(source, destination, tonemapMaterial, 8);
				return;
			}
			if (type == TonemapperType.OptimizedHejiDawson)
			{
				tonemapMaterial.SetFloat("_ExposureAdjustment", 0.5f * exposureAdjustment);
				Graphics.Blit(source, destination, tonemapMaterial, 7);
				return;
			}
			bool flag = CreateInternalRenderTexture();
			RenderTexture temporary = RenderTexture.GetTemporary((int)adaptiveTextureSize, (int)adaptiveTextureSize, 0, rtFormat);
			Graphics.Blit(source, temporary);
			int num = (int)Mathf.Log((float)temporary.width * 1f, 2f);
			int num2 = 2;
			RenderTexture[] array = new RenderTexture[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = RenderTexture.GetTemporary(temporary.width / num2, temporary.width / num2, 0, rtFormat);
				num2 *= 2;
			}
			RenderTexture source2 = array[num - 1];
			Graphics.Blit(temporary, array[0], tonemapMaterial, 1);
			if (type == TonemapperType.AdaptiveReinhardAutoWhite)
			{
				for (int j = 0; j < num - 1; j++)
				{
					Graphics.Blit(array[j], array[j + 1], tonemapMaterial, 9);
					source2 = array[j + 1];
				}
			}
			else if (type == TonemapperType.AdaptiveReinhard)
			{
				for (int k = 0; k < num - 1; k++)
				{
					Graphics.Blit(array[k], array[k + 1]);
					source2 = array[k + 1];
				}
			}
			adaptionSpeed = ((!(adaptionSpeed < 0.001f)) ? adaptionSpeed : 0.001f);
			tonemapMaterial.SetFloat("_AdaptionSpeed", adaptionSpeed);
			rt.MarkRestoreExpected();
			Graphics.Blit(source2, rt, tonemapMaterial, (!flag) ? 2 : 3);
			middleGrey = ((!(middleGrey < 0.001f)) ? middleGrey : 0.001f);
			tonemapMaterial.SetVector("_HdrParams", new Vector4(middleGrey, middleGrey, middleGrey, white * white));
			tonemapMaterial.SetTexture("_SmallTex", rt);
			if (type == TonemapperType.AdaptiveReinhard)
			{
				Graphics.Blit(source, destination, tonemapMaterial, 0);
			}
			else if (type == TonemapperType.AdaptiveReinhardAutoWhite)
			{
				Graphics.Blit(source, destination, tonemapMaterial, 10);
			}
			else
			{
				UnityEngine.Debug.LogError("No valid adaptive tonemapper type found!");
				Graphics.Blit(source, destination);
			}
			for (int l = 0; l < num; l++)
			{
				RenderTexture.ReleaseTemporary(array[l]);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}
	}
	internal class Triangles
	{
		private static Mesh[] meshes;

		private static int currentTris;

		private static bool HasMeshes()
		{
			if (meshes == null)
			{
				return false;
			}
			for (int i = 0; i < meshes.Length; i++)
			{
				if (null == meshes[i])
				{
					return false;
				}
			}
			return true;
		}

		private static void Cleanup()
		{
			if (meshes == null)
			{
				return;
			}
			for (int i = 0; i < meshes.Length; i++)
			{
				if (null != meshes[i])
				{
					UnityEngine.Object.DestroyImmediate(meshes[i]);
					meshes[i] = null;
				}
			}
			meshes = null;
		}

		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			if (HasMeshes() && currentTris == totalWidth * totalHeight)
			{
				return meshes;
			}
			int num = 21666;
			int num2 = (currentTris = totalWidth * totalHeight);
			int num3 = Mathf.CeilToInt(1f * (float)num2 / (1f * (float)num));
			meshes = new Mesh[num3];
			int num4 = 0;
			int num5 = 0;
			for (num4 = 0; num4 < num2; num4 += num)
			{
				int triCount = Mathf.FloorToInt(Mathf.Clamp(num2 - num4, 0, num));
				meshes[num5] = GetMesh(triCount, num4, totalWidth, totalHeight);
				num5++;
			}
			return meshes;
		}

		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			Mesh mesh = new Mesh();
			mesh.hideFlags = HideFlags.DontSave;
			Vector3[] array = new Vector3[triCount * 3];
			Vector2[] array2 = new Vector2[triCount * 3];
			Vector2[] array3 = new Vector2[triCount * 3];
			int[] array4 = new int[triCount * 3];
			for (int i = 0; i < triCount; i++)
			{
				int num = i * 3;
				int num2 = triOffset + i;
				float num3 = Mathf.Floor(num2 % totalWidth) / (float)totalWidth;
				float num4 = Mathf.Floor(num2 / totalWidth) / (float)totalHeight;
				Vector3 vector = new Vector3(num3 * 2f - 1f, num4 * 2f - 1f, 1f);
				array[num] = vector;
				array[num + 1] = vector;
				array[num + 2] = vector;
				ref Vector2 reference = ref array2[num];
				reference = new Vector2(0f, 0f);
				ref Vector2 reference2 = ref array2[num + 1];
				reference2 = new Vector2(1f, 0f);
				ref Vector2 reference3 = ref array2[num + 2];
				reference3 = new Vector2(0f, 1f);
				ref Vector2 reference4 = ref array3[num];
				reference4 = new Vector2(num3, num4);
				ref Vector2 reference5 = ref array3[num + 1];
				reference5 = new Vector2(num3, num4);
				ref Vector2 reference6 = ref array3[num + 2];
				reference6 = new Vector2(num3, num4);
				array4[num] = num;
				array4[num + 1] = num + 1;
				array4[num + 2] = num + 2;
			}
			mesh.vertices = array;
			mesh.triangles = array4;
			mesh.uv = array2;
			mesh.uv2 = array3;
			return mesh;
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Displacement/Twirl")]
	public class Twirl : ImageEffectBase
	{
		public Vector2 radius = new Vector2(0.3f, 0.3f);

		[Range(0f, 360f)]
		public float angle = 50f;

		public Vector2 center = new Vector2(0.5f, 0.5f);

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			ImageEffects.RenderDistortion(base.material, source, destination, angle, center, radius);
		}
	}
	[AddComponentMenu("Image Effects/Camera/Vignette and Chromatic Aberration")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		public enum AberrationMode
		{
			Simple,
			Advanced
		}

		public AberrationMode mode;

		public float intensity = 0.036f;

		public float chromaticAberration = 0.2f;

		public float axialAberration = 0.5f;

		public float blur;

		public float blurSpread = 0.75f;

		public float luminanceDependency = 0.25f;

		public float blurDistance = 2.5f;

		public Shader vignetteShader;

		public Shader separableBlurShader;

		public Shader chromAberrationShader;

		private Material m_VignetteMaterial;

		private Material m_SeparableBlurMaterial;

		private Material m_ChromAberrationMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			m_VignetteMaterial = CheckShaderAndCreateMaterial(vignetteShader, m_VignetteMaterial);
			m_SeparableBlurMaterial = CheckShaderAndCreateMaterial(separableBlurShader, m_SeparableBlurMaterial);
			m_ChromAberrationMaterial = CheckShaderAndCreateMaterial(chromAberrationShader, m_ChromAberrationMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			int width = source.width;
			int height = source.height;
			bool flag = Mathf.Abs(blur) > 0f || Mathf.Abs(intensity) > 0f;
			float num = 1f * (float)width / (1f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, source.format);
				if (Mathf.Abs(blur) > 0f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 2, 0, source.format);
					Graphics.Blit(source, renderTexture2, m_ChromAberrationMaterial, 0);
					for (int i = 0; i < 2; i++)
					{
						m_SeparableBlurMaterial.SetVector("offsets", new Vector4(0f, blurSpread * 0.001953125f, 0f, 0f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 2, height / 2, 0, source.format);
						Graphics.Blit(renderTexture2, temporary, m_SeparableBlurMaterial);
						RenderTexture.ReleaseTemporary(renderTexture2);
						m_SeparableBlurMaterial.SetVector("offsets", new Vector4(blurSpread * 0.001953125f / num, 0f, 0f, 0f));
						renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 2, 0, source.format);
						Graphics.Blit(temporary, renderTexture2, m_SeparableBlurMaterial);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				m_VignetteMaterial.SetFloat("_Intensity", 1f / (1f - intensity) - 1f);
				m_VignetteMaterial.SetFloat("_Blur", 1f / (1f - blur) - 1f);
				m_VignetteMaterial.SetTexture("_VignetteTex", renderTexture2);
				Graphics.Blit(source, renderTexture, m_VignetteMaterial, 0);
			}
			m_ChromAberrationMaterial.SetFloat("_ChromaticAberration", chromaticAberration);
			m_ChromAberrationMaterial.SetFloat("_AxialAberration", axialAberration);
			m_ChromAberrationMaterial.SetVector("_BlurDistance", new Vector2(0f - blurDistance, blurDistance));
			m_ChromAberrationMaterial.SetFloat("_Luminance", 1f / Mathf.Max(Mathf.Epsilon, luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Clamp;
			}
			else
			{
				source.wrapMode = TextureWrapMode.Clamp;
			}
			Graphics.Blit((!flag) ? source : renderTexture, destination, m_ChromAberrationMaterial, (mode != AberrationMode.Advanced) ? 1 : 2);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Displacement/Vortex")]
	public class Vortex : ImageEffectBase
	{
		public Vector2 radius = new Vector2(0.4f, 0.4f);

		public float angle = 50f;

		public Vector2 center = new Vector2(0.5f, 0.5f);

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			ImageEffects.RenderDistortion(base.material, source, destination, angle, center, radius);
		}
	}
}
