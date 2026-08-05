using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mono.Math;
using RecRoom;
using RecRoom.Core.DataStructures;
using RecRoom.Core.Imposters;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class ImposterPreviewCustomFraming : MonoBehaviour, HNIHKNBJIHJ
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float FCHFANEFGNA = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "4")]
	public void PrepareImposter(LDHNKDAPIIM JJNHHBEBHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4FD5780", Offset = "0x4FD3F80", VA = "0x184FD5780")]
	public void SetReferencePoint(Vector3 LEPDGMMDMEF, Quaternion LDGPGIDFGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4FD54E0", Offset = "0x4FD3CE0", VA = "0x184FD54E0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4FD5710", Offset = "0x4FD3F10", VA = "0x184FD5710")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xBA2880", Offset = "0xBA1080", VA = "0x180BA2880")]
	public ImposterPreviewCustomFraming()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		[LDCIOLBBPHN(CDEHJIBIIED.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const int CLCFMMMIKND = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int GOGEOEECFBF = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly List<Material> MHNFCMDJBKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool LFFOBEBHOOP;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4FD5940", Offset = "0x4FD4140", VA = "0x184FD5940")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4FD5840", Offset = "0x4FD4040", VA = "0x184FD5840")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4FD5B20", Offset = "0x4FD4320", VA = "0x184FD5B20")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class CenterInImposter : MonoBehaviour, HNIHKNBJIHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4FD2C50", Offset = "0x4FD1450", VA = "0x184FD2C50", Slot = "4")]
		public void PrepareImposter(LDHNKDAPIIM JJNHHBEBHIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x60B930", Offset = "0x60A130", VA = "0x18060B930")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x60B930", Offset = "0x60A130", VA = "0x18060B930")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HNIHKNBJIHJ
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(LDHNKDAPIIM JJNHHBEBHIB);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JMIJBIOMLMM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> HHGDMJNIFHK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> PGNLMBJAIHD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface PJPMLFGLFNA
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BEEAAIOPFDM(params Type[] DLHOFIICGML);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BOHBBKBFOFJ(params Type[] DLHOFIICGML);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject PPBLJMOJGNB(GameObject ICJBKPICLMO, Transform BNOBPGHCIOL, bool BJLAALIPKJE = false);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T PPBLJMOJGNB<T>(T ICJBKPICLMO, Transform BNOBPGHCIOL, bool BJLAALIPKJE = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T PPBLJMOJGNB<T>(GameObject ICJBKPICLMO, Transform BNOBPGHCIOL, bool BJLAALIPKJE = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject PPBLJMOJGNB(GameObject ICJBKPICLMO, Transform BNOBPGHCIOL, LDHNKDAPIIM JJNHHBEBHIB, bool BJLAALIPKJE);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T PPBLJMOJGNB<T>(GameObject ICJBKPICLMO, Transform BNOBPGHCIOL, LDHNKDAPIIM JJNHHBEBHIB, bool BJLAALIPKJE) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T PPBLJMOJGNB<T>(T ICJBKPICLMO, Transform BNOBPGHCIOL, LDHNKDAPIIM JJNHHBEBHIB, bool BJLAALIPKJE) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class CGPKGJGPDDL : IDisposable, PJPMLFGLFNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HashSet<Type> IJFHFNIJOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly HashSet<Type> LCPNHIACHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Transform LCPKMBOBFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<Component> FNPJHNDMPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> IMFMKHBKEPN;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4FD1ED0", Offset = "0x4FD06D0", VA = "0x184FD1ED0")]
	[FNEIJLJADIG]
	public static void DFMMHLILBNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4FD2920", Offset = "0x4FD1120", VA = "0x184FD2920")]
	[Preserve]
	public CGPKGJGPDDL([APDFHCGIDJC(null)] JMIJBIOMLMM GBGAKEAAJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4FD2030", Offset = "0x4FD0830", VA = "0x184FD2030", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4FD1E30", Offset = "0x4FD0630", VA = "0x184FD1E30", Slot = "5")]
	public void BEEAAIOPFDM(params Type[] DLHOFIICGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4FD1E80", Offset = "0x4FD0680", VA = "0x184FD1E80", Slot = "6")]
	public void BOHBBKBFOFJ(params Type[] DLHOFIICGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4FD2890", Offset = "0x4FD1090", VA = "0x184FD2890", Slot = "7")]
	public GameObject PPBLJMOJGNB(GameObject ICJBKPICLMO, Transform BNOBPGHCIOL, bool BJLAALIPKJE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x238D710", Offset = "0x238BF10", VA = "0x18238D710", Slot = "8")]
	public T PPBLJMOJGNB<T>(T ICJBKPICLMO, Transform BNOBPGHCIOL, bool BJLAALIPKJE = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x238D860", Offset = "0x238C060", VA = "0x18238D860", Slot = "9")]
	public T PPBLJMOJGNB<T>(GameObject ICJBKPICLMO, Transform BNOBPGHCIOL, bool BJLAALIPKJE = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4FD2800", Offset = "0x4FD1000", VA = "0x184FD2800", Slot = "10")]
	public GameObject PPBLJMOJGNB(GameObject ICJBKPICLMO, Transform BNOBPGHCIOL, LDHNKDAPIIM JJNHHBEBHIB, bool BJLAALIPKJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x238D780", Offset = "0x238BF80", VA = "0x18238D780", Slot = "11")]
	public T PPBLJMOJGNB<T>(GameObject ICJBKPICLMO, Transform BNOBPGHCIOL, LDHNKDAPIIM JJNHHBEBHIB, bool BJLAALIPKJE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x238D7D0", Offset = "0x238BFD0", VA = "0x18238D7D0", Slot = "12")]
	public T PPBLJMOJGNB<T>(T ICJBKPICLMO, Transform BNOBPGHCIOL, LDHNKDAPIIM JJNHHBEBHIB, bool BJLAALIPKJE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x238D890", Offset = "0x238C090", VA = "0x18238D890")]
	private T PPBLJMOJGNB<T>(GameObject ICJBKPICLMO, Transform BNOBPGHCIOL, LDHNKDAPIIM JJNHHBEBHIB, bool BJLAALIPKJE, out GameObject BOPGOIMLCCF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x238D290", Offset = "0x238BA90", VA = "0x18238D290")]
	private T LAJLECCDMLC<T>(GameObject HDDLEPINJNG, LDHNKDAPIIM JJNHHBEBHIB, bool BJLAALIPKJE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4FD2130", Offset = "0x4FD0930", VA = "0x184FD2130")]
	private void EIFLBNGJBCO(Component BCKOJIOPJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4FD2390", Offset = "0x4FD0B90", VA = "0x184FD2390")]
	private void OMFIMPFDAKM(Component BCKOJIOPJJE, LDHNKDAPIIM JJNHHBEBHIB, bool BJLAALIPKJE, [Optional] Type IAHDNLIIDKK, [Optional] Type EJEKFMADBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4FD2250", Offset = "0x4FD0A50", VA = "0x184FD2250")]
	private void NBOEJNNPFIA(GameObject HDDLEPINJNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct LDHNKDAPIIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<Type, object> CDKKENDJOOG;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2231D50", Offset = "0x2230550", VA = "0x182231D50")]
	public LDHNKDAPIIM AGHFILABLHM<T>(T OHBEELPIGMD)
	{
		return default(LDHNKDAPIIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x239D720", Offset = "0x239BF20", VA = "0x18239D720")]
	public T NMFOBHDGKIK<T>(T MNPAPGJJFGJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2468910", Offset = "0x2467110", VA = "0x182468910")]
	public bool NMGABNCLOGE<T>(out T OHBEELPIGMD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct ICBPMMEEDAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public bool MCOPNLDNBNA;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x821FE0", Offset = "0x8207E0", VA = "0x180821FE0")]
	public ICBPMMEEDAE(bool BKDEBOGGGPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KBKAHGMHPNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly bool HMLIIOINCNF;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4FD6180", Offset = "0x4FD4980", VA = "0x184FD6180")]
	public KBKAHGMHPNJ(bool OAEOLDIHLIF)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x60B930", Offset = "0x60A130", VA = "0x18060B930")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ScaleInImposter : MonoBehaviour, HNIHKNBJIHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4FD61C0", Offset = "0x4FD49C0", VA = "0x184FD61C0", Slot = "4")]
		public void PrepareImposter(LDHNKDAPIIM JJNHHBEBHIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x60B930", Offset = "0x60A130", VA = "0x18060B930")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CreateAssetMenu]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x4FD61A0", Offset = "0x4FD49A0", VA = "0x184FD61A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x4FD6190", Offset = "0x4FD4990", VA = "0x184FD6190")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4FD57C0", Offset = "0x4FD3FC0", VA = "0x184FD57C0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class IEANCINEMAL
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly List<URPLight> NCJEHGKOFAN;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly Vector3 FAFJPGEHLMO;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Vector3 PFEGLNANCBG;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static Camera PMCJNMLOHJD;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public const string GMOELGBADJA = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public const NMMHFENHGMK LCDOLNBADNH = NMMHFENHGMK.Water;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly List<Renderer> NALDHBJCPCB;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static AmbientMode GAOOKHFECDP;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color KJMHIDOCCHH;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static Color NDFGABGGHJJ;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static Color DGOCBMFOIJE;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static Cubemap GLKDCMDKJEE;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static bool AJIEBHLLNNF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera EGFGNCOCLPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4FD3C00", Offset = "0x4FD2400", VA = "0x184FD3C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4FD37F0", Offset = "0x4FD1FF0", VA = "0x184FD37F0")]
	public static void CFNANGCAEON(Vector3 IEEHPPMFDPO, Quaternion AHIIDALFHCI, ImposterRenderConfig HKFFNMEPEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4FD4400", Offset = "0x4FD2C00", VA = "0x184FD4400")]
	private static void JNLOFAPOFCH(Vector3 IEEHPPMFDPO, Quaternion AHIIDALFHCI, URPLight OBHECAOPOCE, ImposterRenderConfig.LightConfig ILBBOIGNBJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4FD3E00", Offset = "0x4FD2600", VA = "0x184FD3E00")]
	public static void ELNKIPJPFLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4FD4100", Offset = "0x4FD2900", VA = "0x184FD4100")]
	private static void JEJDKOOFCDG(int NKECKBMFGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4FD3EE0", Offset = "0x4FD26E0", VA = "0x184FD3EE0")]
	public static void GGHLMEMLPJD(ImposterRenderConfig HKFFNMEPEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4FD36F0", Offset = "0x4FD1EF0", VA = "0x184FD36F0")]
	public static void AKAMODLFIHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4FD3A70", Offset = "0x4FD2270", VA = "0x184FD3A70")]
	public static void CJLABPOBGHM(GameObject NCKCEJOHJMI, RenderTexture KBGEANELAPL, ImposterRenderConfig HKFFNMEPEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4FD4CE0", Offset = "0x4FD34E0", VA = "0x184FD4CE0")]
	private static void NNFNAIKNKMG(GameObject NCKCEJOHJMI, RenderTexture KBGEANELAPL, ImposterRenderConfig HKFFNMEPEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4FD4A50", Offset = "0x4FD3250", VA = "0x184FD4A50")]
	private static void LPKCOHIFAJH(GameObject NCKCEJOHJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4FD5200", Offset = "0x4FD3A00", VA = "0x184FD5200")]
	public static void PPOLKBALBBI(List<Renderer> AHICLHBKAMO, List<Material> DOGIIODNDBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4FD4740", Offset = "0x4FD2F40", VA = "0x184FD4740")]
	private static void KJMPFMMMLME(GameObject ICJBKPICLMO, Vector3 IADHKAAPFKF, Vector3 DCNHHPEBDAF, float KOFMLILKHNA, out Vector3 BHHBJNDEBHF, out Quaternion CKCAEJNFJDJ, out float OCFBEHOGPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4FD4060", Offset = "0x4FD2860", VA = "0x184FD4060")]
	public static RenderTexture GNLNHKGNGIK(int CNIBEDGIPIB, int JMJIBONNFGD)
	{
		return null;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public struct EEAKNFKCAOK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public FLHPGANJIHL LGNJJLILBNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public GameObject FIEIMFMGGGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public RenderTexture BLLJHBCNFMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public ImposterRenderConfig KMIHFDBPLPM;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x48C9630", Offset = "0x48C7E30", VA = "0x1848C9630")]
			public EEAKNFKCAOK(FLHPGANJIHL LIODJCGLONF, GameObject IPMLJMPCIHN, RenderTexture KBGEANELAPL, ImposterRenderConfig FPCJEMDLKNO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const int OHCDFCEHFBG = 1;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int DJFNLOEOFMP = 6;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static global::KCGKCJBPPLJ<EEAKNFKCAOK, RenderTexture> DHEGIHOJHME;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static readonly List<EEAKNFKCAOK> MCNIIMJDMEO;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int GEODEDOIOCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x9E68B0", Offset = "0x9E50B0", VA = "0x1809E68B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4FD32B0", Offset = "0x4FD1AB0", VA = "0x184FD32B0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject NCKCEJOHJMI, RenderTexture KBGEANELAPL, ImposterRenderConfig HKFFNMEPEII, CancellationToken OFMMACGDFGM, bool LNNFBFEBIJK = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4FD2DD0", Offset = "0x4FD15D0", VA = "0x184FD2DD0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4FD3220", Offset = "0x4FD1A20", VA = "0x184FD3220", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4FD2EF0", Offset = "0x4FD16F0", VA = "0x184FD2EF0")]
		private static Task<RenderTexture> FOBCAMJKFBN(EEAKNFKCAOK LCKGJPIKDHE, CancellationToken OFMMACGDFGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4FD3690", Offset = "0x4FD1E90", VA = "0x184FD3690")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class JOLDJLBOGLF
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static byte[] NNDNCLBIBCO;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int BOAHHKDAAGN;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static int BEAECOMNAKK;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static BigInteger HPFDFIDLOGO;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
	public JOLDJLBOGLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4FD5B90", Offset = "0x4FD4390", VA = "0x184FD5B90")]
	private static string AAANGJFGDHI(byte[] EOEFACHALFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4FD5C90", Offset = "0x4FD4490", VA = "0x184FD5C90")]
	public static string CHJFNPPOLEP(byte[] IFAOIOLKGMC, bool CCLJOEHHPGP)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
