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
public class ImposterPreviewCustomFraming : MonoBehaviour, MNEPFKKHCIM
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float OMAGINIENFP = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5AA220", Offset = "0x5A9220", VA = "0x1805AA220", Slot = "4")]
	public void PrepareImposter(NDJKOALONAI FHLPJMHKMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1DAC6D0", Offset = "0x1DAB6D0", VA = "0x181DAC6D0")]
	public void SetReferencePoint(Vector3 LFIBJEOHDKD, Quaternion NOHAMBCGIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1DAC430", Offset = "0x1DAB430", VA = "0x181DAC430")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1DAC660", Offset = "0x1DAB660", VA = "0x181DAC660")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x12ECE50", Offset = "0x12EBE50", VA = "0x1812ECE50")]
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
		[DPGOFBBDGFL(BHKPCKHAKLF.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const int NNKKFNJJBCA = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int GDKNBFOAHFC = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly List<Material> DAKAHJNPOKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool MOJPPGMCLPE;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1DAC890", Offset = "0x1DAB890", VA = "0x181DAC890")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1DAC790", Offset = "0x1DAB790", VA = "0x181DAC790")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1DACA70", Offset = "0x1DABA70", VA = "0x181DACA70")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5C83F0", Offset = "0x5C73F0", VA = "0x1805C83F0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MNEPFKKHCIM
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(NDJKOALONAI FHLPJMHKMFC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BDPOCNEDLNI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> HNIKPCHCAAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> KIHAPIMCIKA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface DCPBDABJIPL
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBMODGPKMNG(params Type[] OGHPIEEPAII);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PDAKMAPHJLE(params Type[] OGHPIEEPAII);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject AGKPPLLNBCK(GameObject EKKOANIDOHH, Transform COLFLONKFJK, bool HFJJDBDDCJL = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T AGKPPLLNBCK<T>(T EKKOANIDOHH, Transform COLFLONKFJK, bool HFJJDBDDCJL = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T AGKPPLLNBCK<T>(GameObject EKKOANIDOHH, Transform COLFLONKFJK, bool HFJJDBDDCJL = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject AGKPPLLNBCK(GameObject EKKOANIDOHH, Transform COLFLONKFJK, NDJKOALONAI FHLPJMHKMFC, bool HFJJDBDDCJL);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T AGKPPLLNBCK<T>(GameObject EKKOANIDOHH, Transform COLFLONKFJK, NDJKOALONAI FHLPJMHKMFC, bool HFJJDBDDCJL) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T AGKPPLLNBCK<T>(T EKKOANIDOHH, Transform COLFLONKFJK, NDJKOALONAI FHLPJMHKMFC, bool HFJJDBDDCJL) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class PGAGMBBFIMO : IDisposable, DCPBDABJIPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly HashSet<Type> GKCCHIPAAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HashSet<Type> CFAIKCJOCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Transform BHBLPPHOHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly List<Component> JJOJHFEEHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> ECMNPEBBNNE;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1DACD30", Offset = "0x1DABD30", VA = "0x181DACD30")]
	[MBNOPHMLNBM]
	public static void FCKCGNJAGPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1DAD600", Offset = "0x1DAC600", VA = "0x181DAD600")]
	[Preserve]
	public PGAGMBBFIMO([IOLMGJIHJFK(null)] BDPOCNEDLNI IPHHAHJIHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1DACC30", Offset = "0x1DABC30", VA = "0x181DACC30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1DACE90", Offset = "0x1DABE90", VA = "0x181DACE90", Slot = "5")]
	public void GBMODGPKMNG(params Type[] OGHPIEEPAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1DAD5B0", Offset = "0x1DAC5B0", VA = "0x181DAD5B0", Slot = "6")]
	public void PDAKMAPHJLE(params Type[] OGHPIEEPAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1DACB10", Offset = "0x1DABB10", VA = "0x181DACB10", Slot = "7")]
	public GameObject AGKPPLLNBCK(GameObject EKKOANIDOHH, Transform COLFLONKFJK, bool HFJJDBDDCJL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2E44DA0", Offset = "0x2E43DA0", VA = "0x182E44DA0", Slot = "8")]
	public T AGKPPLLNBCK<T>(T EKKOANIDOHH, Transform COLFLONKFJK, bool HFJJDBDDCJL = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2E44EA0", Offset = "0x2E43EA0", VA = "0x182E44EA0", Slot = "9")]
	public T AGKPPLLNBCK<T>(GameObject EKKOANIDOHH, Transform COLFLONKFJK, bool HFJJDBDDCJL = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1DACBA0", Offset = "0x1DABBA0", VA = "0x181DACBA0", Slot = "10")]
	public GameObject AGKPPLLNBCK(GameObject EKKOANIDOHH, Transform COLFLONKFJK, NDJKOALONAI FHLPJMHKMFC, bool HFJJDBDDCJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2E45410", Offset = "0x2E44410", VA = "0x182E45410", Slot = "11")]
	public T AGKPPLLNBCK<T>(GameObject EKKOANIDOHH, Transform COLFLONKFJK, NDJKOALONAI FHLPJMHKMFC, bool HFJJDBDDCJL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2E44E10", Offset = "0x2E43E10", VA = "0x182E44E10", Slot = "12")]
	public T AGKPPLLNBCK<T>(T EKKOANIDOHH, Transform COLFLONKFJK, NDJKOALONAI FHLPJMHKMFC, bool HFJJDBDDCJL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2E44ED0", Offset = "0x2E43ED0", VA = "0x182E44ED0")]
	private T AGKPPLLNBCK<T>(GameObject EKKOANIDOHH, Transform COLFLONKFJK, NDJKOALONAI FHLPJMHKMFC, bool HFJJDBDDCJL, out GameObject KJLOKBIPMLO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2E45460", Offset = "0x2E44460", VA = "0x182E45460")]
	private T DMBHDHMADJH<T>(GameObject NIKGFIPEJKD, NDJKOALONAI FHLPJMHKMFC, bool HFJJDBDDCJL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1DACEE0", Offset = "0x1DABEE0", VA = "0x181DACEE0")]
	private void HIKJKJNKJAM(Component LPKJELLIJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1DAD000", Offset = "0x1DAC000", VA = "0x181DAD000")]
	private void KKMACICKCEH(Component LPKJELLIJFF, NDJKOALONAI FHLPJMHKMFC, bool HFJJDBDDCJL, [Optional] Type PKNCBNALKMC, [Optional] Type ANFDOIELCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1DAD470", Offset = "0x1DAC470", VA = "0x181DAD470")]
	private void LCDJBEJPCHG(GameObject NIKGFIPEJKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct NDJKOALONAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Dictionary<Type, object> LJJNJHEPOLJ;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2E99160", Offset = "0x2E98160", VA = "0x182E99160")]
	public NDJKOALONAI KJOMPIGOOHG<T>(T JIGKFMMLBHO)
	{
		return default(NDJKOALONAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3172C40", Offset = "0x3171C40", VA = "0x183172C40")]
	public T NELNIMGBJDL<T>(T IEELHBAALFA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2F71520", Offset = "0x2F70520", VA = "0x182F71520")]
	public bool ODOHFJDGPNB<T>(out T JIGKFMMLBHO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct JHFMIODOANA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public bool MDDIKAHCACM;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7E64F0", Offset = "0x7E54F0", VA = "0x1807E64F0")]
	public JHFMIODOANA(bool DNMACKEAFBC)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CreateAssetMenu]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			[Header("Shadows")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x1DACAF0", Offset = "0x1DABAF0", VA = "0x181DACAF0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1DACAE0", Offset = "0x1DABAE0", VA = "0x181DACAE0")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1DAC710", Offset = "0x1DAB710", VA = "0x181DAC710")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class CICNOFFPODB
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly List<URPLight> FMOFMFGFHMK;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly Vector3 COHFBNMAIMC;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly Vector3 CLEHCBHGJDF;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Camera BLFOCFKBLAA;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const string EAINKBPGKKO = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public const NLGDOBMOMBI CFJLEKGOKLK = NLGDOBMOMBI.Water;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<Renderer> CGMIOIGNCEH;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static AmbientMode EHANNHJCOPM;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static Color BIGPDMCGKND;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static Color FNFPPHMPMKE;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color AIBAGKJFKGH;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Cubemap BFCIMCNAKJP;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static bool JAFCKCLJPEC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera FIICOBDEHOL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1DAAD60", Offset = "0x1DA9D60", VA = "0x181DAAD60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1DAAAE0", Offset = "0x1DA9AE0", VA = "0x181DAAAE0")]
	public static void JPMDEJCNEKJ(Vector3 LGPCMFPILIC, Quaternion JDGDJDDAEDA, ImposterRenderConfig ILNLFCNJHOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1DAA2A0", Offset = "0x1DA92A0", VA = "0x181DAA2A0")]
	private static void GGABHHPICHM(Vector3 LGPCMFPILIC, Quaternion JDGDJDDAEDA, URPLight LKKPEKPEHDI, ImposterRenderConfig.LightConfig GNFLLKBNHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1DAAA00", Offset = "0x1DA9A00", VA = "0x181DAAA00")]
	public static void JJINPDHBHAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1DA9770", Offset = "0x1DA8770", VA = "0x181DA9770")]
	private static void CPMIHLAOMDB(int HDEFIMIIMOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1DAB1F0", Offset = "0x1DAA1F0", VA = "0x181DAB1F0")]
	public static void LIPGBIOHHEB(ImposterRenderConfig ILNLFCNJHOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1DAA5E0", Offset = "0x1DA95E0", VA = "0x181DAA5E0")]
	public static void HFNHFGKLOPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1DAA870", Offset = "0x1DA9870", VA = "0x181DAA870")]
	public static void HPDGKANLKIK(GameObject MCGPLOOPFBP, RenderTexture GKKMFGHFBIE, ImposterRenderConfig ILNLFCNJHOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1DA9A70", Offset = "0x1DA8A70", VA = "0x181DA9A70")]
	private static void DELHLIGLNPA(GameObject MCGPLOOPFBP, RenderTexture GKKMFGHFBIE, ImposterRenderConfig ILNLFCNJHOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1DAAF60", Offset = "0x1DA9F60", VA = "0x181DAAF60")]
	private static void LGGILOAGBGG(GameObject MCGPLOOPFBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1DAA6E0", Offset = "0x1DA96E0", VA = "0x181DAA6E0")]
	public static void HMOFKNMAMCP(List<Renderer> GAILPBMMGNB, List<Material> LNLMDDPLJPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1DA9F90", Offset = "0x1DA8F90", VA = "0x181DA9F90")]
	private static void ELBGMGBIIIM(GameObject EKKOANIDOHH, Vector3 LJKEHNMIKKP, Vector3 DLFCPFIHODF, float MDGIMENOPCD, out Vector3 OEPGNFNFJFG, out Quaternion EPPJPDFCJHF, out float CCAFDDKPKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1DA96D0", Offset = "0x1DA86D0", VA = "0x181DA96D0")]
	public static RenderTexture BDPFPEHNPOD(int KIDBPFAHLEE, int CNJPPLLLBHD)
	{
		return null;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct HOMOFOPAFPA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public BNGELMJMADH LKNHLIONGOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public GameObject LKIOONIBIAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public RenderTexture KHFGOHDDADG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public ImposterRenderConfig GGHANJIDEBE;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x1DAC3D0", Offset = "0x1DAB3D0", VA = "0x181DAC3D0")]
			public HOMOFOPAFPA(BNGELMJMADH PNEBNJNAOIA, GameObject FCHLDGCMMKN, RenderTexture GKKMFGHFBIE, ImposterRenderConfig MNPIOGADDAH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const int AOKJPLKCGNG = 1;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private const int HBMEGMFKLOG = 6;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static global::EKHPPECGNEP<HOMOFOPAFPA, RenderTexture> ADMEKCDCBIA;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly List<HOMOFOPAFPA> POPDHIJEKOH;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int CJOKGNFEJCF
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x9B7F00", Offset = "0x9B6F00", VA = "0x1809B7F00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1DAB9A0", Offset = "0x1DAA9A0", VA = "0x181DAB9A0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject MCGPLOOPFBP, RenderTexture GKKMFGHFBIE, ImposterRenderConfig ILNLFCNJHOD, CancellationToken CMOIBOJIACL, bool IHDILNMDICD = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1DAB4C0", Offset = "0x1DAA4C0", VA = "0x181DAB4C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1DAB910", Offset = "0x1DAA910", VA = "0x181DAB910", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1DAB5E0", Offset = "0x1DAA5E0", VA = "0x181DAB5E0")]
		private static Task<RenderTexture> MDMPIJPOMCF(HOMOFOPAFPA BFMBHECMCAO, CancellationToken CMOIBOJIACL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1DABD80", Offset = "0x1DAAD80", VA = "0x181DABD80")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HGPPKMCDCLL
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static byte[] PIDGMPFPDGI;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static int CONMIAOECKG;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static int PDHBFKNINGO;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static BigInteger EDLLKHJPMCN;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
	public HGPPKMCDCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1DABDE0", Offset = "0x1DAADE0", VA = "0x181DABDE0")]
	private static string CKGLFMJKOPM(byte[] IIFMPDAMAIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1DABEE0", Offset = "0x1DAAEE0", VA = "0x181DABEE0")]
	public static string IOHOBOIOFIG(byte[] KFCJKMJDFKE, bool OLNJLDMOIJP)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x54F440", Offset = "0x54E440", VA = "0x18054F440")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
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
