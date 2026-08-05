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
public class ImposterPreviewCustomFraming : MonoBehaviour, GCMDDGMCMMA
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float MAMBGLIOFMN = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x51CE80", Offset = "0x51BC80", VA = "0x18051CE80", Slot = "4")]
	public void PrepareImposter(DCMOKPHCMKA BEIAGOKKKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4A85610", Offset = "0x4A84410", VA = "0x184A85610")]
	public void SetReferencePoint(Vector3 CDDIHEHPKML, Quaternion OLJEEKIABGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4A85370", Offset = "0x4A84170", VA = "0x184A85370")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4A855A0", Offset = "0x4A843A0", VA = "0x184A855A0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1412B20", Offset = "0x1411920", VA = "0x181412B20")]
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
		[HMEPOPIIEBM(ABJMOFPOMCO.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const int KIANGLOCGJG = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int MBBHLAJIMBH = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly List<Material> BLAHEAAIKEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool DPGLNLPDPNO;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4A857D0", Offset = "0x4A845D0", VA = "0x184A857D0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4A856D0", Offset = "0x4A844D0", VA = "0x184A856D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4A859B0", Offset = "0x4A847B0", VA = "0x184A859B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD85B10", Offset = "0xD84910", VA = "0x180D85B10")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GCMDDGMCMMA
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(DCMOKPHCMKA BEIAGOKKKBD);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface JEAOPCBJKLI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> MDGAHBCLOHO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> EEDJIMHPKMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OGKDCPBGHHI
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KDDLOJOJIDK(params Type[] HKMABDGLMEI);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LKPPOECAACN(params Type[] HKMABDGLMEI);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject NDKFDNDANAP(GameObject ICEEAEGPFDJ, Transform DEGLKKAFDCN, bool LCFGIFDAFPL = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T NDKFDNDANAP<T>(T ICEEAEGPFDJ, Transform DEGLKKAFDCN, bool LCFGIFDAFPL = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T NDKFDNDANAP<T>(GameObject ICEEAEGPFDJ, Transform DEGLKKAFDCN, bool LCFGIFDAFPL = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject NDKFDNDANAP(GameObject ICEEAEGPFDJ, Transform DEGLKKAFDCN, DCMOKPHCMKA BEIAGOKKKBD, bool LCFGIFDAFPL);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T NDKFDNDANAP<T>(GameObject ICEEAEGPFDJ, Transform DEGLKKAFDCN, DCMOKPHCMKA BEIAGOKKKBD, bool LCFGIFDAFPL) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T NDKFDNDANAP<T>(T ICEEAEGPFDJ, Transform DEGLKKAFDCN, DCMOKPHCMKA BEIAGOKKKBD, bool LCFGIFDAFPL) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class NBKKCDAKGHO : IDisposable, OGKDCPBGHHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly HashSet<Type> HIAFEIKFEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HashSet<Type> JKOKJALICKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Transform FIBEPFEMDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly List<Component> GHGOMIHNIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> MOLDLIEENML;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4A880E0", Offset = "0x4A86EE0", VA = "0x184A880E0")]
	[PFGPCENLGFP]
	public static void MDPLDFABEPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4A88A30", Offset = "0x4A87830", VA = "0x184A88A30")]
	[Preserve]
	public NBKKCDAKGHO([APCBDNIBNNJ(null)] JEAOPCBJKLI DEELNDNOFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4A87F40", Offset = "0x4A86D40", VA = "0x184A87F40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4A88040", Offset = "0x4A86E40", VA = "0x184A88040", Slot = "5")]
	public void KDDLOJOJIDK(params Type[] HKMABDGLMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4A88090", Offset = "0x4A86E90", VA = "0x184A88090", Slot = "6")]
	public void LKPPOECAACN(params Type[] HKMABDGLMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4A882D0", Offset = "0x4A870D0", VA = "0x184A882D0", Slot = "7")]
	public GameObject NDKFDNDANAP(GameObject ICEEAEGPFDJ, Transform DEGLKKAFDCN, bool LCFGIFDAFPL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1C6D410", Offset = "0x1C6C210", VA = "0x181C6D410", Slot = "8")]
	public T NDKFDNDANAP<T>(T ICEEAEGPFDJ, Transform DEGLKKAFDCN, bool LCFGIFDAFPL = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1C6D4D0", Offset = "0x1C6C2D0", VA = "0x181C6D4D0", Slot = "9")]
	public T NDKFDNDANAP<T>(GameObject ICEEAEGPFDJ, Transform DEGLKKAFDCN, bool LCFGIFDAFPL = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4A88240", Offset = "0x4A87040", VA = "0x184A88240", Slot = "10")]
	public GameObject NDKFDNDANAP(GameObject ICEEAEGPFDJ, Transform DEGLKKAFDCN, DCMOKPHCMKA BEIAGOKKKBD, bool LCFGIFDAFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1C6D480", Offset = "0x1C6C280", VA = "0x181C6D480", Slot = "11")]
	public T NDKFDNDANAP<T>(GameObject ICEEAEGPFDJ, Transform DEGLKKAFDCN, DCMOKPHCMKA BEIAGOKKKBD, bool LCFGIFDAFPL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1C6D380", Offset = "0x1C6C180", VA = "0x181C6D380", Slot = "12")]
	public T NDKFDNDANAP<T>(T ICEEAEGPFDJ, Transform DEGLKKAFDCN, DCMOKPHCMKA BEIAGOKKKBD, bool LCFGIFDAFPL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1C6D020", Offset = "0x1C6BE20", VA = "0x181C6D020")]
	private T NDKFDNDANAP<T>(GameObject ICEEAEGPFDJ, Transform DEGLKKAFDCN, DCMOKPHCMKA BEIAGOKKKBD, bool LCFGIFDAFPL, out GameObject EBGGDBCLBKJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1C6CB70", Offset = "0x1C6B970", VA = "0x181C6CB70")]
	private T FDDHKFODJIA<T>(GameObject HJMLHPKHBHJ, DCMOKPHCMKA BEIAGOKKKBD, bool LCFGIFDAFPL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4A88910", Offset = "0x4A87710", VA = "0x184A88910")]
	private void PLELNBACEFB(Component LFKGOLJOIDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4A88360", Offset = "0x4A87160", VA = "0x184A88360")]
	private void OFJMGDNLLNH(Component LFKGOLJOIDI, DCMOKPHCMKA BEIAGOKKKBD, bool LCFGIFDAFPL, [Optional] Type FDFELOBKBCN, [Optional] Type JCEEPPHAEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4A887D0", Offset = "0x4A875D0", VA = "0x184A887D0")]
	private void OJPCMEHPLFK(GameObject HJMLHPKHBHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct DCMOKPHCMKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Dictionary<Type, object> LGHDJOHFAHA;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x22530C0", Offset = "0x2251EC0", VA = "0x1822530C0")]
	public DCMOKPHCMKA OOLACCNIHHO<T>(T HCHCDFNJLNP)
	{
		return default(DCMOKPHCMKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1C5C460", Offset = "0x1C5B260", VA = "0x181C5C460")]
	public T IOKAOCCJEBM<T>(T DKGEGKEDJEM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x288AE40", Offset = "0x2889C40", VA = "0x18288AE40")]
	public bool JBGHHOHELLE<T>(out T HCHCDFNJLNP)
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
				[Cpp2IlInjected.Address(RVA = "0x4A87930", Offset = "0x4A86730", VA = "0x184A87930")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x4A87920", Offset = "0x4A86720", VA = "0x184A87920")]
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
		[Cpp2IlInjected.Address(RVA = "0x4A85650", Offset = "0x4A84450", VA = "0x184A85650")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LFJDNNIKGBJ
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly List<URPLight> BINNFOIBJJH;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly Vector3 BLIEBDIGEBE;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly Vector3 JAPLCMLFMAA;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static Camera HKGOIEICNMN;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public const string LEJADKNPDLG = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const FCJMPKGEBFG JDHJNJDJHCE = FCJMPKGEBFG.Water;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<Renderer> HKOGLOABLNI;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static AmbientMode CNPKPMNLPMA;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static Color PKDKIGHKCPA;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static Color AKJKALLEANO;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static Color MLLKGEGOONE;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Cubemap CCOJNHILBAH;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static bool LAJEGMDAGAJ;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera JGHOAKBFDOK
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4A86C10", Offset = "0x4A85A10", VA = "0x184A86C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4A85E30", Offset = "0x4A84C30", VA = "0x184A85E30")]
	public static void GCGNIKEFAPA(Vector3 OOEFFLAKCFI, Quaternion AIGLKBPOOIH, ImposterRenderConfig MLKDCEIPNIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4A870A0", Offset = "0x4A85EA0", VA = "0x184A870A0")]
	private static void MOEOIBOEGCF(Vector3 OOEFFLAKCFI, Quaternion AIGLKBPOOIH, URPLight APDHMPJOIKL, ImposterRenderConfig.LightConfig KJAIEIPGFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4A85B20", Offset = "0x4A84920", VA = "0x184A85B20")]
	public static void FBKIICEMCOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4A86910", Offset = "0x4A85710", VA = "0x184A86910")]
	private static void KGFELMFJBIK(int FKPFAMEKDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4A86600", Offset = "0x4A85400", VA = "0x184A86600")]
	public static void IMCNAAEJGID(ImposterRenderConfig MLKDCEIPNIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4A85A20", Offset = "0x4A84820", VA = "0x184A85A20")]
	public static void EJIOCOHIALK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4A85CA0", Offset = "0x4A84AA0", VA = "0x184A85CA0")]
	public static void FPCFAPBGIFJ(GameObject MDMBMMJNMBA, RenderTexture GHKOBLGBEOA, ImposterRenderConfig MLKDCEIPNIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4A860B0", Offset = "0x4A84EB0", VA = "0x184A860B0")]
	private static void IFMKHOEGLEH(GameObject MDMBMMJNMBA, RenderTexture GHKOBLGBEOA, ImposterRenderConfig MLKDCEIPNIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4A86E10", Offset = "0x4A85C10", VA = "0x184A86E10")]
	private static void MOBCMDKINEK(GameObject MDMBMMJNMBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4A86780", Offset = "0x4A85580", VA = "0x184A86780")]
	public static void JPDNEPFIEPH(List<Renderer> PNLCAFBKMHB, List<Material> ABCHFOBCJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4A873E0", Offset = "0x4A861E0", VA = "0x184A873E0")]
	private static void OLLPOCLDIHC(List<Renderer> PNLCAFBKMHB, Vector3 NBFJGJGJEAL, Vector3 GKHONJDPACA, float FKPEKALLCBG, out Vector3 PDIPDFHMFCI, out Quaternion EHAHAOCKBEB, out float AIOGKNBJBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4A85C00", Offset = "0x4A84A00", VA = "0x184A85C00")]
	public static RenderTexture FOEBEGKDAOO(int HALPAOLACGJ, int GJLNADLHOLD)
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
		public struct LMMKGMBOLNE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public JMFCAGKBFOE LFIAEJIFAJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public GameObject LPFAOINOBPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public RenderTexture JBAMLFANPJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public ImposterRenderConfig DCIHNFJHLGI;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x115A520", Offset = "0x1159320", VA = "0x18115A520")]
			public LMMKGMBOLNE(JMFCAGKBFOE GDJKJKEPKOD, GameObject GEPFFHFKBPM, RenderTexture GHKOBLGBEOA, ImposterRenderConfig BBLIDNCFIHN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const int LBPEEFAOIKJ = 1;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const int OFENAIBOAFI = 6;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static global::INCKKKCKMCI<LMMKGMBOLNE, RenderTexture> BLNNCGGJBOF;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static readonly List<LMMKGMBOLNE> PIIHKEMDBMC;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int IHBKOGKIECA
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x876140", Offset = "0x874F40", VA = "0x180876140")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4A84F30", Offset = "0x4A83D30", VA = "0x184A84F30")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject MDMBMMJNMBA, RenderTexture GHKOBLGBEOA, ImposterRenderConfig MLKDCEIPNIB, CancellationToken OJFMOLFGPOF, bool BBNOEPIGFNF = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4A84A50", Offset = "0x4A83850", VA = "0x184A84A50", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4A84EA0", Offset = "0x4A83CA0", VA = "0x184A84EA0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4A84B70", Offset = "0x4A83970", VA = "0x184A84B70")]
		private static Task<RenderTexture> KBHIEPGPLIL(LMMKGMBOLNE MBMJHPPLIAC, CancellationToken OJFMOLFGPOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4A85310", Offset = "0x4A84110", VA = "0x184A85310")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class MLACDHJHDFG
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static byte[] PCFDJLIAIEK;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static int CNEHBAAIPJM;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static int NEIKIABHABD;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static BigInteger NOAFCEFHHAN;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
	public MLACDHJHDFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4A87950", Offset = "0x4A86750", VA = "0x184A87950")]
	private static string JLOFJIHEBDA(byte[] KBBKPHEOPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4A87A50", Offset = "0x4A86850", VA = "0x184A87A50")]
	public static string NCFNLEDFEPP(byte[] NBHAFAAIDII, bool IGLBINIMLIE)
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
		[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
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
