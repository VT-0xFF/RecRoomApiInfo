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
public class ImposterPreviewCustomFraming : MonoBehaviour, PMAMDKKFHJM
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float BBKJKDJKMEG = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x522E80", Offset = "0x521C80", VA = "0x180522E80", Slot = "4")]
	public void PrepareImposter(ABMFKPKEKAG FBDPIHJPGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4B8D170", Offset = "0x4B8BF70", VA = "0x184B8D170")]
	public void SetReferencePoint(Vector3 PLMINJIAFFM, Quaternion EOGMFIAAJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4B8CED0", Offset = "0x4B8BCD0", VA = "0x184B8CED0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4B8D100", Offset = "0x4B8BF00", VA = "0x184B8D100")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xDFF980", Offset = "0xDFE780", VA = "0x180DFF980")]
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
		[MHEMHMNNFNI(ILJAFDCKKEB.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const int MBFNHMMDFNJ = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int KBHEHIJKKBK = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly List<Material> KENBBAKOICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool PLIGPACMEMF;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4B8D330", Offset = "0x4B8C130", VA = "0x184B8D330")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4B8D230", Offset = "0x4B8C030", VA = "0x184B8D230")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4B8D510", Offset = "0x4B8C310", VA = "0x184B8D510")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CDBD0", Offset = "0x5CC9D0", VA = "0x1805CDBD0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PMAMDKKFHJM
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(ABMFKPKEKAG FBDPIHJPGGL);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BBEBLIJKHPE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> BEHFFCIEDLP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> IEPNHMGLODP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface CEONNOIKNII
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LBKFCNCEJMO(params Type[] GAFJJEMPHFG);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CGEMCDGNBLB(params Type[] GAFJJEMPHFG);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject DCFMGDACOAM(GameObject ILDJEFEDOLC, Transform ABHIDEANEGM, bool JJIPCMIJNBD = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T DCFMGDACOAM<T>(T ILDJEFEDOLC, Transform ABHIDEANEGM, bool JJIPCMIJNBD = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T DCFMGDACOAM<T>(GameObject ILDJEFEDOLC, Transform ABHIDEANEGM, bool JJIPCMIJNBD = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject DCFMGDACOAM(GameObject ILDJEFEDOLC, Transform ABHIDEANEGM, ABMFKPKEKAG FBDPIHJPGGL, bool JJIPCMIJNBD);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T DCFMGDACOAM<T>(GameObject ILDJEFEDOLC, Transform ABHIDEANEGM, ABMFKPKEKAG FBDPIHJPGGL, bool JJIPCMIJNBD) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T DCFMGDACOAM<T>(T ILDJEFEDOLC, Transform ABHIDEANEGM, ABMFKPKEKAG FBDPIHJPGGL, bool JJIPCMIJNBD) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class GAPNAKDGPLL : IDisposable, CEONNOIKNII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly HashSet<Type> IOADJCAOANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HashSet<Type> BCJFPPOMOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Transform FPOLALCADOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly List<Component> EPBBHKJBKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> DEIPHCLGAOD;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4B8C8D0", Offset = "0x4B8B6D0", VA = "0x184B8C8D0")]
	[LKBOCBPCLAE]
	public static void JHKOAOMFFCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4B8CBC0", Offset = "0x4B8B9C0", VA = "0x184B8CBC0")]
	[Preserve]
	public GAPNAKDGPLL([NHOFCLMALPB(null)] BBEBLIJKHPE FMDPHFIKFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4B8C7D0", Offset = "0x4B8B5D0", VA = "0x184B8C7D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4B8CA30", Offset = "0x4B8B830", VA = "0x184B8CA30", Slot = "5")]
	public void LBKFCNCEJMO(params Type[] GAFJJEMPHFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4B8C0D0", Offset = "0x4B8AED0", VA = "0x184B8C0D0", Slot = "6")]
	public void CGEMCDGNBLB(params Type[] GAFJJEMPHFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4B8C1B0", Offset = "0x4B8AFB0", VA = "0x184B8C1B0", Slot = "7")]
	public GameObject DCFMGDACOAM(GameObject ILDJEFEDOLC, Transform ABHIDEANEGM, bool JJIPCMIJNBD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2B59BC0", Offset = "0x2B589C0", VA = "0x182B59BC0", Slot = "8")]
	public T DCFMGDACOAM<T>(T ILDJEFEDOLC, Transform ABHIDEANEGM, bool JJIPCMIJNBD = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2B59B90", Offset = "0x2B58990", VA = "0x182B59B90", Slot = "9")]
	public T DCFMGDACOAM<T>(GameObject ILDJEFEDOLC, Transform ABHIDEANEGM, bool JJIPCMIJNBD = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4B8C120", Offset = "0x4B8AF20", VA = "0x184B8C120", Slot = "10")]
	public GameObject DCFMGDACOAM(GameObject ILDJEFEDOLC, Transform ABHIDEANEGM, ABMFKPKEKAG FBDPIHJPGGL, bool JJIPCMIJNBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2B59CC0", Offset = "0x2B58AC0", VA = "0x182B59CC0", Slot = "11")]
	public T DCFMGDACOAM<T>(GameObject ILDJEFEDOLC, Transform ABHIDEANEGM, ABMFKPKEKAG FBDPIHJPGGL, bool JJIPCMIJNBD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2B59C30", Offset = "0x2B58A30", VA = "0x182B59C30", Slot = "12")]
	public T DCFMGDACOAM<T>(T ILDJEFEDOLC, Transform ABHIDEANEGM, ABMFKPKEKAG FBDPIHJPGGL, bool JJIPCMIJNBD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2B59D10", Offset = "0x2B58B10", VA = "0x182B59D10")]
	private T DCFMGDACOAM<T>(GameObject ILDJEFEDOLC, Transform ABHIDEANEGM, ABMFKPKEKAG FBDPIHJPGGL, bool JJIPCMIJNBD, out GameObject ICHMANGAFDB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2B5A070", Offset = "0x2B58E70", VA = "0x182B5A070")]
	private T JMAKHPPOJLM<T>(GameObject LHOMOGPNLAL, ABMFKPKEKAG FBDPIHJPGGL, bool JJIPCMIJNBD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4B8C240", Offset = "0x4B8B040", VA = "0x184B8C240")]
	private void DFCAHLOBHJM(Component OLNLGGPFPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4B8C360", Offset = "0x4B8B160", VA = "0x184B8C360")]
	private void DPNNFODDHJB(Component OLNLGGPFPEI, ABMFKPKEKAG FBDPIHJPGGL, bool JJIPCMIJNBD, [Optional] Type HGECHHNJJNI, [Optional] Type IDHGHDKDIEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4B8CA80", Offset = "0x4B8B880", VA = "0x184B8CA80")]
	private void PDDEPIMEPEH(GameObject LHOMOGPNLAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct ABMFKPKEKAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Dictionary<Type, object> ADAHCEPABEH;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x26A3CB0", Offset = "0x26A2AB0", VA = "0x1826A3CB0")]
	public ABMFKPKEKAG OKBEIPOGICA<T>(T CDNIMMGEDLB)
	{
		return default(ABMFKPKEKAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C410", Offset = "0x2B4B210", VA = "0x182B4C410")]
	public T HPAAPNLJBAF<T>(T AJDOLHPLHJE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2C2C4C0", Offset = "0x2C2B2C0", VA = "0x182C2C4C0")]
	public bool KHKICPAOJJO<T>(out T CDNIMMGEDLB)
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
				[Cpp2IlInjected.Address(RVA = "0x4B8D590", Offset = "0x4B8C390", VA = "0x184B8D590")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x4B8D580", Offset = "0x4B8C380", VA = "0x184B8D580")]
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
		[Cpp2IlInjected.Address(RVA = "0x4B8D1B0", Offset = "0x4B8BFB0", VA = "0x184B8D1B0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class FPAPCMGJPGB
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly List<URPLight> LDCGIHKJJLA;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly Vector3 IDDCACIMFFE;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly Vector3 CPOJCGOAEIE;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static Camera PFJJAFIEKAG;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public const string PJODELBILAE = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const GAIFDECOBKD NCHOIPPBGKM = GAIFDECOBKD.Water;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<Renderer> EOCLBDAGBPI;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static AmbientMode OGCCILEHION;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static Color HGAOEAHMOAB;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static Color MOKLGCGFIOL;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static Color GPMDOEEHGEA;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Cubemap HEGNBCAIAEN;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static bool DJNODFLEGBE;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera LNGFADDDFNB
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4B8AA20", Offset = "0x4B89820", VA = "0x184B8AA20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4B8BD00", Offset = "0x4B8AB00", VA = "0x184B8BD00")]
	public static void OJFDHAMPCIH(Vector3 DOPANACNHOL, Quaternion AEOAGMBOBAF, ImposterRenderConfig ICECPENLFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4B8A5E0", Offset = "0x4B893E0", VA = "0x184B8A5E0")]
	private static void FAMBLMPGKDN(Vector3 DOPANACNHOL, Quaternion AEOAGMBOBAF, URPLight OHFOHJECLPK, ImposterRenderConfig.LightConfig NBNFLGAFNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4B8B790", Offset = "0x4B8A590", VA = "0x184B8B790")]
	public static void MADJLHPHPLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4B8BA00", Offset = "0x4B8A800", VA = "0x184B8BA00")]
	private static void NKLJJGCNJAJ(int PBCKMACFFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4B8A1D0", Offset = "0x4B88FD0", VA = "0x184B8A1D0")]
	public static void ADMFMBEMFEF(ImposterRenderConfig ICECPENLFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4B8A920", Offset = "0x4B89720", VA = "0x184B8A920")]
	public static void FHBNHPNFEJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4B8B010", Offset = "0x4B89E10", VA = "0x184B8B010")]
	public static void HHACCJBDMME(GameObject JGFPMGPNKPB, RenderTexture BPACPMEOMHK, ImposterRenderConfig ICECPENLFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4B8B1A0", Offset = "0x4B89FA0", VA = "0x184B8B1A0")]
	private static void KNHMDONANGB(GameObject JGFPMGPNKPB, RenderTexture BPACPMEOMHK, ImposterRenderConfig ICECPENLFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4B8A350", Offset = "0x4B89150", VA = "0x184B8A350")]
	private static void CBPBDLLHILC(GameObject JGFPMGPNKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4B8B870", Offset = "0x4B8A670", VA = "0x184B8B870")]
	public static void MLEMLPOBNLA(List<Renderer> AGMJDPBLAFJ, List<Material> HJBCGFBNPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4B8AC20", Offset = "0x4B89A20", VA = "0x184B8AC20")]
	private static void GLFCPCCECPO(List<Renderer> AGMJDPBLAFJ, Vector3 EMDABJPMLFP, Vector3 OHEKOBJCILP, float CJEPJJMENKD, out Vector3 JCMHGJIMENI, out Quaternion OPFJKNNKPCF, out float AEHACLKDIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4B8B6F0", Offset = "0x4B8A4F0", VA = "0x184B8B6F0")]
	public static RenderTexture LCJDBKMNCHH(int AGFGCPCKPEN, int LNBHIGPMBFM)
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
		public struct IEFGFJAONDL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public NLHJDENEFGK EBJFBJOEHEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public GameObject HPECBLKJDKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public RenderTexture HBAMKOLNGNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public ImposterRenderConfig EPHPAPAJMIL;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x1ECF780", Offset = "0x1ECE580", VA = "0x181ECF780")]
			public IEFGFJAONDL(NLHJDENEFGK ONDLHLPELBB, GameObject CEEJGJNBFEL, RenderTexture BPACPMEOMHK, ImposterRenderConfig KAMPEEJAHDI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const int IMENKKJPHDP = 1;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const int OKMBNNOJEIC = 6;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static global::LKNJJECFMIC<IEFGFJAONDL, RenderTexture> ENBKHMHJFFG;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static readonly List<IEFGFJAONDL> DGMJGFEJJMK;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int HFFEJIOPFLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xB0CAA0", Offset = "0xB0B8A0", VA = "0x180B0CAA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4B89D90", Offset = "0x4B88B90", VA = "0x184B89D90")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject JGFPMGPNKPB, RenderTexture BPACPMEOMHK, ImposterRenderConfig ICECPENLFJL, CancellationToken NPNNOOBBHFE, bool HLOPLONOOCK = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4B898B0", Offset = "0x4B886B0", VA = "0x184B898B0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4B89D00", Offset = "0x4B88B00", VA = "0x184B89D00", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4B899D0", Offset = "0x4B887D0", VA = "0x184B899D0")]
		private static Task<RenderTexture> OJDFNBLEFHL(IEFGFJAONDL JNNIIOLOCEL, CancellationToken NPNNOOBBHFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4B8A170", Offset = "0x4B88F70", VA = "0x184B8A170")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PNNMOCCLFDL
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static byte[] MBBLNMFMFMG;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static int MGBCGAMEIAA;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static int GGINOEAOLGL;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static BigInteger FIINFAJLNBA;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
	public PNNMOCCLFDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4B8D5B0", Offset = "0x4B8C3B0", VA = "0x184B8D5B0")]
	private static string NFPHDFCNCGP(byte[] BAHCPBFJIGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4B8D6B0", Offset = "0x4B8C4B0", VA = "0x184B8D6B0")]
	public static string NLBDLCJIPCH(byte[] IEDOMBJDKEO, bool HAFBALPHMDI)
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
		[Cpp2IlInjected.Address(RVA = "0x524AB0", Offset = "0x5238B0", VA = "0x180524AB0")]
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
