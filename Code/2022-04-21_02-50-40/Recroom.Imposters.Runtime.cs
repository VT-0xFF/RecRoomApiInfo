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
public class ImposterPreviewCustomFraming : MonoBehaviour, FOOBJOODGFL
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float CPFNKMLIHBP = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x523E80", Offset = "0x522E80", VA = "0x180523E80", Slot = "4")]
	public void PrepareImposter(KHIKFAOBBEJ DLHIOLCPDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4BA1BD0", Offset = "0x4BA0BD0", VA = "0x184BA1BD0")]
	public void SetReferencePoint(Vector3 IPPCGIJNPBE, Quaternion NPNENFOFOPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4BA1930", Offset = "0x4BA0930", VA = "0x184BA1930")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4BA1B60", Offset = "0x4BA0B60", VA = "0x184BA1B60")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x109AED0", Offset = "0x1099ED0", VA = "0x18109AED0")]
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
		[HDHOGJGJBFN(OGLALOIFFPF.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const int BFLBOMAGIOP = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int DNAPNCPJMJK = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly List<Material> PBNHDHMFJKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool JHGBPFNHHCM;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4BA1D90", Offset = "0x4BA0D90", VA = "0x184BA1D90")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4BA1C90", Offset = "0x4BA0C90", VA = "0x184BA1C90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4BA1F70", Offset = "0x4BA0F70", VA = "0x184BA1F70")]
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
		[Cpp2IlInjected.Address(RVA = "0xD6F9B0", Offset = "0xD6E9B0", VA = "0x180D6F9B0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FOOBJOODGFL
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(KHIKFAOBBEJ DLHIOLCPDPA);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface INIECGBEFFL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> FHLLBKNHKOH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> IFJAIIEBAJD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface DCLMKADMDDA
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGGEBAPPPKG(params Type[] IFBDHFJNLDO);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MOHCECBANML(params Type[] IFBDHFJNLDO);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject PMHEBKEEEOI(GameObject PCPNOKOCNGO, Transform BMCODBFOLMP, bool HDPMLFNOJFE = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T PMHEBKEEEOI<T>(T PCPNOKOCNGO, Transform BMCODBFOLMP, bool HDPMLFNOJFE = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T PMHEBKEEEOI<T>(GameObject PCPNOKOCNGO, Transform BMCODBFOLMP, bool HDPMLFNOJFE = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject PMHEBKEEEOI(GameObject PCPNOKOCNGO, Transform BMCODBFOLMP, KHIKFAOBBEJ DLHIOLCPDPA, bool HDPMLFNOJFE);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T PMHEBKEEEOI<T>(GameObject PCPNOKOCNGO, Transform BMCODBFOLMP, KHIKFAOBBEJ DLHIOLCPDPA, bool HDPMLFNOJFE) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T PMHEBKEEEOI<T>(T PCPNOKOCNGO, Transform BMCODBFOLMP, KHIKFAOBBEJ DLHIOLCPDPA, bool HDPMLFNOJFE) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class COCAEMKLOND : IDisposable, DCLMKADMDDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly HashSet<Type> HHPGKHMHECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HashSet<Type> IEPBJFEHLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Transform NPJNLMKKAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly List<Component> KLEELJPAFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> JFBIDGGLLHB;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4BA0440", Offset = "0x4B9F440", VA = "0x184BA0440")]
	[OGFMMECDAHJ]
	public static void LLBFJPJLKJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4BA0710", Offset = "0x4B9F710", VA = "0x184BA0710")]
	[Preserve]
	public COCAEMKLOND([LDNCLNECAKN(null)] INIECGBEFFL JFEAAIAHJDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4BA0090", Offset = "0x4B9F090", VA = "0x184BA0090", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4BA02D0", Offset = "0x4B9F2D0", VA = "0x184BA02D0", Slot = "5")]
	public void JGGEBAPPPKG(params Type[] IFBDHFJNLDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4BA05A0", Offset = "0x4B9F5A0", VA = "0x184BA05A0", Slot = "6")]
	public void MOHCECBANML(params Type[] IFBDHFJNLDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4BA0680", Offset = "0x4B9F680", VA = "0x184BA0680", Slot = "7")]
	public GameObject PMHEBKEEEOI(GameObject PCPNOKOCNGO, Transform BMCODBFOLMP, bool HDPMLFNOJFE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1FBC8B0", Offset = "0x1FBB8B0", VA = "0x181FBC8B0", Slot = "8")]
	public T PMHEBKEEEOI<T>(T PCPNOKOCNGO, Transform BMCODBFOLMP, bool HDPMLFNOJFE = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1FBC920", Offset = "0x1FBB920", VA = "0x181FBC920", Slot = "9")]
	public T PMHEBKEEEOI<T>(GameObject PCPNOKOCNGO, Transform BMCODBFOLMP, bool HDPMLFNOJFE = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4BA05F0", Offset = "0x4B9F5F0", VA = "0x184BA05F0", Slot = "10")]
	public GameObject PMHEBKEEEOI(GameObject PCPNOKOCNGO, Transform BMCODBFOLMP, KHIKFAOBBEJ DLHIOLCPDPA, bool HDPMLFNOJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1FBC860", Offset = "0x1FBB860", VA = "0x181FBC860", Slot = "11")]
	public T PMHEBKEEEOI<T>(GameObject PCPNOKOCNGO, Transform BMCODBFOLMP, KHIKFAOBBEJ DLHIOLCPDPA, bool HDPMLFNOJFE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1FBC950", Offset = "0x1FBB950", VA = "0x181FBC950", Slot = "12")]
	public T PMHEBKEEEOI<T>(T PCPNOKOCNGO, Transform BMCODBFOLMP, KHIKFAOBBEJ DLHIOLCPDPA, bool HDPMLFNOJFE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1FBC9E0", Offset = "0x1FBB9E0", VA = "0x181FBC9E0")]
	private T PMHEBKEEEOI<T>(GameObject PCPNOKOCNGO, Transform BMCODBFOLMP, KHIKFAOBBEJ DLHIOLCPDPA, bool HDPMLFNOJFE, out GameObject JCDMLMIDJBO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1FBC3B0", Offset = "0x1FBB3B0", VA = "0x181FBC3B0")]
	private T JEGILNGNEME<T>(GameObject CDELJLCJCHC, KHIKFAOBBEJ DLHIOLCPDPA, bool HDPMLFNOJFE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4BA0320", Offset = "0x4B9F320", VA = "0x184BA0320")]
	private void KLEDFLGMODJ(Component MBDAGOAGDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4B9FC20", Offset = "0x4B9EC20", VA = "0x184B9FC20")]
	private void ADKEIGEGHGI(Component MBDAGOAGDIP, KHIKFAOBBEJ DLHIOLCPDPA, bool HDPMLFNOJFE, [Optional] Type JKFFGKIFCBN, [Optional] Type PEPPKCGKCDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4BA0190", Offset = "0x4B9F190", VA = "0x184BA0190")]
	private void EDOEAJJLDAA(GameObject CDELJLCJCHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct KHIKFAOBBEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Dictionary<Type, object> KOOMLCPANDO;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2315800", Offset = "0x2314800", VA = "0x182315800")]
	public KHIKFAOBBEJ FHONGGKHMKA<T>(T KJJELHOLNJP)
	{
		return default(KHIKFAOBBEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1DE5DC0", Offset = "0x1DE4DC0", VA = "0x181DE5DC0")]
	public T ELOPIDONOEF<T>(T DDIFIHICGCI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x246CE00", Offset = "0x246BE00", VA = "0x18246CE00")]
	public bool OHHPOFFENOI<T>(out T KJJELHOLNJP)
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
				[Cpp2IlInjected.Address(RVA = "0x4BA3EF0", Offset = "0x4BA2EF0", VA = "0x184BA3EF0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x4BA3EE0", Offset = "0x4BA2EE0", VA = "0x184BA3EE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BA1C10", Offset = "0x4BA0C10", VA = "0x184BA1C10")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class KHAPNPHLKFC
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly List<URPLight> ODDNNHEFLMM;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly Vector3 GHLKILPHKMK;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly Vector3 PAIOEONNOOI;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static Camera OHMDFLJIBMB;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public const string GBCFLJAKCJE = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const EFOONIHNGIB PAGMFGCDLKN = EFOONIHNGIB.Water;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<Renderer> OFCOODBOEDF;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static AmbientMode JNMHMDFHIHG;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static Color NJJJPKCBCHA;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static Color BEIEFGKEPJK;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static Color MFFJJMDGEPL;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Cubemap MDGOIEGBLCC;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static bool BCKHGOHHNMP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera KJGEOJACEDD
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4BA2D60", Offset = "0x4BA1D60", VA = "0x184BA2D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2740", Offset = "0x4BA1740", VA = "0x184BA2740")]
	public static void FIGNJKHKLAN(Vector3 EMPAEADKIBI, Quaternion ICPBMNMHCNE, ImposterRenderConfig EMPCKBEEPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4BA3380", Offset = "0x4BA2380", VA = "0x184BA3380")]
	private static void OELKONEGLAP(Vector3 EMPAEADKIBI, Quaternion ICPBMNMHCNE, URPLight KEBKHPFPIKF, ImposterRenderConfig.LightConfig GCLBMEIJIKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2660", Offset = "0x4BA1660", VA = "0x184BA2660")]
	public static void DOMHDOCLKME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2A60", Offset = "0x4BA1A60", VA = "0x184BA2A60")]
	private static void JHECKHLJHIG(int PEJCGHLIMMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4BA36C0", Offset = "0x4BA26C0", VA = "0x184BA36C0")]
	public static void OGODKAEHODB(ImposterRenderConfig EMPCKBEEPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2170", Offset = "0x4BA1170", VA = "0x184BA2170")]
	public static void BMOLENHEMHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2F60", Offset = "0x4BA1F60", VA = "0x184BA2F60")]
	public static void LBLFKDBNFPH(GameObject EBDGEAGPNHJ, RenderTexture CBLPGLENDIH, ImposterRenderConfig EMPCKBEEPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4BA3840", Offset = "0x4BA2840", VA = "0x184BA3840")]
	private static void PIAFMPHNNOJ(GameObject EBDGEAGPNHJ, RenderTexture CBLPGLENDIH, ImposterRenderConfig EMPCKBEEPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4BA30F0", Offset = "0x4BA20F0", VA = "0x184BA30F0")]
	private static void LLNIBFKCACN(GameObject EBDGEAGPNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4BA1FE0", Offset = "0x4BA0FE0", VA = "0x184BA1FE0")]
	public static void BADGOAFLHPH(List<Renderer> GDHJAEEAMDF, List<Material> BPPLJGKPJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4BA2270", Offset = "0x4BA1270", VA = "0x184BA2270")]
	private static void CIAJLAPECPF(List<Renderer> GDHJAEEAMDF, Vector3 FCHPEJKACBD, Vector3 BGACCHAIKEA, float HEBKMPIKOJH, out Vector3 NODDFKFJFBM, out Quaternion PKBHGKPGANO, out float IPALAMANOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4BA29C0", Offset = "0x4BA19C0", VA = "0x184BA29C0")]
	public static RenderTexture GAGPPBDMCAP(int DNPKPAMDPOM, int OFPEKKPMEGK)
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
		public struct IAOJKOCGEDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public OGFJMEAGPLD EAHLFLFHLAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public GameObject APBDJJMBELD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public RenderTexture EAFFAEAAOPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public ImposterRenderConfig FKHECFKDMHC;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xECCC60", Offset = "0xECBC60", VA = "0x180ECCC60")]
			public IAOJKOCGEDP(OGFJMEAGPLD OEPJIAOCMFO, GameObject OMJIIBEKLAO, RenderTexture CBLPGLENDIH, ImposterRenderConfig APIBDEDKJMN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const int BLCMNBODGNO = 1;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const int ANDFJCAIFOD = 6;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static global::AMHEFDOLIFC<IAOJKOCGEDP, RenderTexture> PBHCFBHCPDA;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static readonly List<IAOJKOCGEDP> JCPIFFFJDCO;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int IAJHIIFMFHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x87DA10", Offset = "0x87CA10", VA = "0x18087DA10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4BA0F00", Offset = "0x4B9FF00", VA = "0x184BA0F00")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject EBDGEAGPNHJ, RenderTexture CBLPGLENDIH, ImposterRenderConfig EMPCKBEEPOP, CancellationToken NBKOFEKBJGA, bool BOCMFENGMKC = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4BA0A20", Offset = "0x4B9FA20", VA = "0x184BA0A20", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4BA0E70", Offset = "0x4B9FE70", VA = "0x184BA0E70", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4BA0B40", Offset = "0x4B9FB40", VA = "0x184BA0B40")]
		private static Task<RenderTexture> KGPFHMAKCIP(IAOJKOCGEDP MCBCPBJEAML, CancellationToken NBKOFEKBJGA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4BA12E0", Offset = "0x4BA02E0", VA = "0x184BA12E0")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class EMILBIDIJON
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static byte[] MHCBODEMNDA;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static int DAIOMNBGJFA;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static int DDGCDEKJNBF;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static BigInteger CONMBDBFJHL;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
	public EMILBIDIJON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4BA1670", Offset = "0x4BA0670", VA = "0x184BA1670")]
	private static string PDOGHHMIGDK(byte[] EJCAMPCKMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4BA1340", Offset = "0x4BA0340", VA = "0x184BA1340")]
	public static string KPIGCAGDHMH(byte[] BGILCKNBLBG, bool LCPNKOKDLIC)
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
		[Cpp2IlInjected.Address(RVA = "0x525AB0", Offset = "0x524AB0", VA = "0x180525AB0")]
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
