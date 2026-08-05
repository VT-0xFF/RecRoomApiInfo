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
public class ImposterPreviewCustomFraming : MonoBehaviour, GHMIBKEOECC
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float LDEKIFCIBNC = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x180523B30", Slot = "4")]
	public void PrepareImposter(NHKMGNBDPFG JAPENIOBDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1A44A50", Offset = "0x1A43850", VA = "0x181A44A50")]
	public void SetReferencePoint(Vector3 JHJAJAKBCFJ, Quaternion NEMAPAHOIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1A447B0", Offset = "0x1A435B0", VA = "0x181A447B0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1A449E0", Offset = "0x1A437E0", VA = "0x181A449E0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x101A660", Offset = "0x1019460", VA = "0x18101A660")]
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
		[GOENDBONKAK(NEMAIODNDOF.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const int GIBBDKJNMGB = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int CGMEKGLNCDL = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly List<Material> OCCPDNOJHAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool GBECJJLCFAB;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1A44C10", Offset = "0x1A43A10", VA = "0x181A44C10")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1A44B10", Offset = "0x1A43910", VA = "0x181A44B10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1A44DF0", Offset = "0x1A43BF0", VA = "0x181A44DF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x523A60", Offset = "0x522860", VA = "0x180523A60")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GHMIBKEOECC
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(NHKMGNBDPFG JAPENIOBDEK);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HAOKLIPBHKL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> CGNADIEKGHM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> DLHAFOIFCAA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LPOMOMPCGLO
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AIPHDDAKEBC(params Type[] PHHLHLODACC);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HOHLDDPFMEG(params Type[] PHHLHLODACC);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject PAPGBLPFAHC(GameObject BBOBMKHHMJP, Transform MGDGFFLAOJF, bool ALLANGIBIOI = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T PAPGBLPFAHC<T>(T BBOBMKHHMJP, Transform MGDGFFLAOJF, bool ALLANGIBIOI = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T PAPGBLPFAHC<T>(GameObject BBOBMKHHMJP, Transform MGDGFFLAOJF, bool ALLANGIBIOI = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject PAPGBLPFAHC(GameObject BBOBMKHHMJP, Transform MGDGFFLAOJF, NHKMGNBDPFG JAPENIOBDEK, bool ALLANGIBIOI);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T PAPGBLPFAHC<T>(GameObject BBOBMKHHMJP, Transform MGDGFFLAOJF, NHKMGNBDPFG JAPENIOBDEK, bool ALLANGIBIOI) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T PAPGBLPFAHC<T>(T BBOBMKHHMJP, Transform MGDGFFLAOJF, NHKMGNBDPFG JAPENIOBDEK, bool ALLANGIBIOI) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class GGLNPKHPMCN : IDisposable, LPOMOMPCGLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly HashSet<Type> LPJMKGCGICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HashSet<Type> LOMCJLLDHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Transform LKPEJMHLNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly List<Component> KMGEKEPDJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> EKABJPFHFHO;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1A43B00", Offset = "0x1A42900", VA = "0x181A43B00")]
	[BMPLDOFAONG]
	public static void HEMFOLCPFLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1A444A0", Offset = "0x1A432A0", VA = "0x181A444A0")]
	[Preserve]
	public GGLNPKHPMCN([AHMGCHNNJBE(null)] HAOKLIPBHKL BDAPCDPKNAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1A43A00", Offset = "0x1A42800", VA = "0x181A43A00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1A439B0", Offset = "0x1A427B0", VA = "0x181A439B0", Slot = "5")]
	public void AIPHDDAKEBC(params Type[] PHHLHLODACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1A43C60", Offset = "0x1A42A60", VA = "0x181A43C60", Slot = "6")]
	public void HOHLDDPFMEG(params Type[] PHHLHLODACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1A44380", Offset = "0x1A43180", VA = "0x181A44380", Slot = "7")]
	public GameObject PAPGBLPFAHC(GameObject BBOBMKHHMJP, Transform MGDGFFLAOJF, bool ALLANGIBIOI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2E3D7F0", Offset = "0x2E3C5F0", VA = "0x182E3D7F0", Slot = "8")]
	public T PAPGBLPFAHC<T>(T BBOBMKHHMJP, Transform MGDGFFLAOJF, bool ALLANGIBIOI = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2E3D460", Offset = "0x2E3C260", VA = "0x182E3D460", Slot = "9")]
	public T PAPGBLPFAHC<T>(GameObject BBOBMKHHMJP, Transform MGDGFFLAOJF, bool ALLANGIBIOI = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1A44410", Offset = "0x1A43210", VA = "0x181A44410", Slot = "10")]
	public GameObject PAPGBLPFAHC(GameObject BBOBMKHHMJP, Transform MGDGFFLAOJF, NHKMGNBDPFG JAPENIOBDEK, bool ALLANGIBIOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2E3D860", Offset = "0x2E3C660", VA = "0x182E3D860", Slot = "11")]
	public T PAPGBLPFAHC<T>(GameObject BBOBMKHHMJP, Transform MGDGFFLAOJF, NHKMGNBDPFG JAPENIOBDEK, bool ALLANGIBIOI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2E3D3D0", Offset = "0x2E3C1D0", VA = "0x182E3D3D0", Slot = "12")]
	public T PAPGBLPFAHC<T>(T BBOBMKHHMJP, Transform MGDGFFLAOJF, NHKMGNBDPFG JAPENIOBDEK, bool ALLANGIBIOI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2E3D490", Offset = "0x2E3C290", VA = "0x182E3D490")]
	private T PAPGBLPFAHC<T>(GameObject BBOBMKHHMJP, Transform MGDGFFLAOJF, NHKMGNBDPFG JAPENIOBDEK, bool ALLANGIBIOI, out GameObject IDPBIGAJEOL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2E3CF20", Offset = "0x2E3BD20", VA = "0x182E3CF20")]
	private T KMMADGNLGHM<T>(GameObject MHCMMACILPC, NHKMGNBDPFG JAPENIOBDEK, bool ALLANGIBIOI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1A43DF0", Offset = "0x1A42BF0", VA = "0x181A43DF0")]
	private void NLFGAPBCKKA(Component DPMAGKBINEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1A43F10", Offset = "0x1A42D10", VA = "0x181A43F10")]
	private void OAHJOHAMMKN(Component DPMAGKBINEJ, NHKMGNBDPFG JAPENIOBDEK, bool ALLANGIBIOI, [Optional] Type OPHKCFOBFPO, [Optional] Type CHIGBHCJJEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1A43CB0", Offset = "0x1A42AB0", VA = "0x181A43CB0")]
	private void MGAABFOKMAP(GameObject MHCMMACILPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct NHKMGNBDPFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Dictionary<Type, object> JBKIINLJINN;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2B3A540", Offset = "0x2B39340", VA = "0x182B3A540")]
	public NHKMGNBDPFG EDLAGHPBKKE<T>(T EDLFDAMBHJB)
	{
		return default(NHKMGNBDPFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F440", Offset = "0x2A3E240", VA = "0x182A3F440")]
	public T DNADPOIAFHF<T>(T EOFCNOJGOOE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2F58BC0", Offset = "0x2F579C0", VA = "0x182F58BC0")]
	public bool NOOJLMIMJBL<T>(out T EDLFDAMBHJB)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CreateAssetMenu]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			[Header("Shadows")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x1A46DD0", Offset = "0x1A45BD0", VA = "0x181A46DD0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x1A46DC0", Offset = "0x1A45BC0", VA = "0x181A46DC0")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1A44A90", Offset = "0x1A43890", VA = "0x181A44A90")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class KPMNNAHPMJG
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly List<URPLight> OOGHBDJLBND;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly Vector3 LDLPGLGPNIJ;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly Vector3 PNOGKJCDPHE;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static Camera ENCKIMFJILM;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public const string CBMCBAHMLLE = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const JLJBAKAFHNF KIBDLHJEEDD = JLJBAKAFHNF.Water;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<Renderer> CDJIKOJDNLL;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static AmbientMode HCOIKIGAPKF;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static Color APKDKFAFDGP;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static Color FFKIPGDELEN;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static Color EELPPCMEEKK;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Cubemap LLOBKLEKCKP;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static bool DCJDJAEAFEE;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera NFAHJBHBFDD
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1A45300", Offset = "0x1A44100", VA = "0x181A45300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1A46700", Offset = "0x1A45500", VA = "0x181A46700")]
	public static void PAGHGKAPLBI(Vector3 CLELCMAEGEO, Quaternion LONAADBFEEB, ImposterRenderConfig LIJMMHONIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1A45820", Offset = "0x1A44620", VA = "0x181A45820")]
	private static void FJFEJAGLIAM(Vector3 CLELCMAEGEO, Quaternion LONAADBFEEB, URPLight GEMGMEMHJKB, ImposterRenderConfig.LightConfig MCNGKOHDLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1A460D0", Offset = "0x1A44ED0", VA = "0x181A460D0")]
	public static void KLBINGIPCGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1A45000", Offset = "0x1A43E00", VA = "0x181A45000")]
	private static void BMAIPMEDDFO(int GDEMJCJDPNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1A45B60", Offset = "0x1A44960", VA = "0x181A45B60")]
	public static void IOCGLAOONDB(ImposterRenderConfig LIJMMHONIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1A44F00", Offset = "0x1A43D00", VA = "0x181A44F00")]
	public static void AELBMCNGIGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1A45690", Offset = "0x1A44490", VA = "0x181A45690")]
	public static void FDADMGANNAE(GameObject FKEJGNDFELA, RenderTexture FBFAFHHJDNG, ImposterRenderConfig LIJMMHONIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1A461B0", Offset = "0x1A44FB0", VA = "0x181A461B0")]
	private static void NNHGGKANLIJ(GameObject FKEJGNDFELA, RenderTexture FBFAFHHJDNG, ImposterRenderConfig LIJMMHONIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1A46980", Offset = "0x1A45780", VA = "0x181A46980")]
	private static void PIDNOGPCEAK(GameObject FKEJGNDFELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1A45500", Offset = "0x1A44300", VA = "0x181A45500")]
	public static void DHMBNLIBCFF(List<Renderer> PCKELMDGGJG, List<Material> DGFMAFPJCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1A45CE0", Offset = "0x1A44AE0", VA = "0x181A45CE0")]
	private static void KFJJLJLKCIA(List<Renderer> PCKELMDGGJG, Vector3 IJPOOCHLOPK, Vector3 IEJDNBBDNBM, float DLJPIJNFKFK, out Vector3 FJAHJBHIHCF, out Quaternion PJMMIFFLEDE, out float CFAFDGFCADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1A44E60", Offset = "0x1A43C60", VA = "0x181A44E60")]
	public static RenderTexture ABCJKODGBFK(int CEKEOJFHGKE, int GNPEIMEDGFJ)
	{
		return null;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct LEIBCNPNAOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public LBEDEENLGHL INJCGPOLAOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public GameObject FHHBHDPHHDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public RenderTexture PDAHKEJMFOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public ImposterRenderConfig NJMIFIHOPKF;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x1A46D60", Offset = "0x1A45B60", VA = "0x181A46D60")]
			public LEIBCNPNAOG(LBEDEENLGHL EKLJEEAJMIC, GameObject CMNOAINCNGK, RenderTexture FBFAFHHJDNG, ImposterRenderConfig GIFKBMNECDP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const int JCHIGNOCIGN = 1;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const int PANFKCCKDIA = 6;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static global::NDHKPJMCBGN<LEIBCNPNAOG, RenderTexture> GFAKLKDKGKK;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static readonly List<LEIBCNPNAOG> KKNNKGOPFJC;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int EHNNJNLOEBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8180D0", Offset = "0x816ED0", VA = "0x1808180D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1A43570", Offset = "0x1A42370", VA = "0x181A43570")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject FKEJGNDFELA, RenderTexture FBFAFHHJDNG, ImposterRenderConfig LIJMMHONIKK, CancellationToken JPKIDIFCNPO, bool JAEFJLPKBPE = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1A43090", Offset = "0x1A41E90", VA = "0x181A43090", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1A434E0", Offset = "0x1A422E0", VA = "0x181A434E0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1A431B0", Offset = "0x1A41FB0", VA = "0x181A431B0")]
		private static Task<RenderTexture> BNCPDDIMBGJ(LEIBCNPNAOG KDFDDDADCMF, CancellationToken JPKIDIFCNPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1A43950", Offset = "0x1A42750", VA = "0x181A43950")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class DFPNJGLKJCK
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static byte[] BHKGCCOPMJC;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static int GBDAOKLIGMK;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static int OHPBAKOKAFL;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static BigInteger DGIAGADGPEN;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
	public DFPNJGLKJCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1A42DD0", Offset = "0x1A41BD0", VA = "0x181A42DD0")]
	private static string JPCMDGFJHKL(byte[] JLGJJNEIJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1A42AA0", Offset = "0x1A418A0", VA = "0x181A42AA0")]
	public static string FNPNBMDGJBN(byte[] LPHHCMJDKLK, bool DODMIEKCDBF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
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
