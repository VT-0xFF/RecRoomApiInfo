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
public class ImposterPreviewCustomFraming : MonoBehaviour, KAPGEIIMBMC
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float IICPIEJIOFM = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x513200", Offset = "0x511800", VA = "0x180513200", Slot = "4")]
	public void PrepareImposter(LECJJIFLPFG NFFOAIJMGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1FED830", Offset = "0x1FEBE30", VA = "0x181FED830")]
	public void SetReferencePoint(Vector3 MPKHLDLHNCN, Quaternion FBEONHELNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1FED590", Offset = "0x1FEBB90", VA = "0x181FED590")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1FED7C0", Offset = "0x1FEBDC0", VA = "0x181FED7C0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1392B40", Offset = "0x1391140", VA = "0x181392B40")]
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
		[EHHJIFONIMG(DPOJEDLGDJE.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const int EJNHLIEGAGB = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int NKOINMLBPFB = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly List<Material> GAJHAMEFCNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool LFMOICNAAEC;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1FED9F0", Offset = "0x1FEBFF0", VA = "0x181FED9F0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1FED8F0", Offset = "0x1FEBEF0", VA = "0x181FED8F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1FEDBD0", Offset = "0x1FEC1D0", VA = "0x181FEDBD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x517B90", Offset = "0x516190", VA = "0x180517B90")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KAPGEIIMBMC
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(LECJJIFLPFG NFFOAIJMGGN);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MOPFPFMGDAM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> DGBIJBCJBCO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> AIMEFDDKDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JJDFKCEEFMN
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OOCDBFBGIJA(params Type[] HCMLLCPFBBO);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KIAFJHFMHEO(params Type[] HCMLLCPFBBO);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject JPCICMLGIJL(GameObject IPDAPNHLDPL, Transform EPJKFCLNEED, bool OANLGLEMBPF = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T JPCICMLGIJL<T>(T IPDAPNHLDPL, Transform EPJKFCLNEED, bool OANLGLEMBPF = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T JPCICMLGIJL<T>(GameObject IPDAPNHLDPL, Transform EPJKFCLNEED, bool OANLGLEMBPF = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject JPCICMLGIJL(GameObject IPDAPNHLDPL, Transform EPJKFCLNEED, LECJJIFLPFG NFFOAIJMGGN, bool OANLGLEMBPF);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T JPCICMLGIJL<T>(GameObject IPDAPNHLDPL, Transform EPJKFCLNEED, LECJJIFLPFG NFFOAIJMGGN, bool OANLGLEMBPF) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T JPCICMLGIJL<T>(T IPDAPNHLDPL, Transform EPJKFCLNEED, LECJJIFLPFG NFFOAIJMGGN, bool OANLGLEMBPF) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MLPOIIKNGFC : IDisposable, JJDFKCEEFMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly HashSet<Type> NPOEIJMNJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HashSet<Type> NHAHNDKIKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Transform NLBCODCGGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly List<Component> LHDNLDJPJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> IABOLHFNBNH;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0AA0", Offset = "0x1FEF0A0", VA = "0x181FF0AA0")]
	[DOKCMCFCJJB]
	public static void OFHEJLGLLBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0C50", Offset = "0x1FEF250", VA = "0x181FF0C50")]
	[Preserve]
	public MLPOIIKNGFC([BOCMEEBEKJN(null)] MOPFPFMGDAM PBOAIKIDPIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0710", Offset = "0x1FEED10", VA = "0x181FF0710", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0C00", Offset = "0x1FEF200", VA = "0x181FF0C00", Slot = "5")]
	public void OOCDBFBGIJA(params Type[] HCMLLCPFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0A50", Offset = "0x1FEF050", VA = "0x181FF0A50", Slot = "6")]
	public void KIAFJHFMHEO(params Type[] HCMLLCPFBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1FF09C0", Offset = "0x1FEEFC0", VA = "0x181FF09C0", Slot = "7")]
	public GameObject JPCICMLGIJL(GameObject IPDAPNHLDPL, Transform EPJKFCLNEED, bool OANLGLEMBPF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2F4C9D0", Offset = "0x2F4AFD0", VA = "0x182F4C9D0", Slot = "8")]
	public T JPCICMLGIJL<T>(T IPDAPNHLDPL, Transform EPJKFCLNEED, bool OANLGLEMBPF = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2F4CA40", Offset = "0x2F4B040", VA = "0x182F4CA40", Slot = "9")]
	public T JPCICMLGIJL<T>(GameObject IPDAPNHLDPL, Transform EPJKFCLNEED, bool OANLGLEMBPF = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0930", Offset = "0x1FEEF30", VA = "0x181FF0930", Slot = "10")]
	public GameObject JPCICMLGIJL(GameObject IPDAPNHLDPL, Transform EPJKFCLNEED, LECJJIFLPFG NFFOAIJMGGN, bool OANLGLEMBPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2F4CA70", Offset = "0x2F4B070", VA = "0x182F4CA70", Slot = "11")]
	public T JPCICMLGIJL<T>(GameObject IPDAPNHLDPL, Transform EPJKFCLNEED, LECJJIFLPFG NFFOAIJMGGN, bool OANLGLEMBPF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2F4C940", Offset = "0x2F4AF40", VA = "0x182F4C940", Slot = "12")]
	public T JPCICMLGIJL<T>(T IPDAPNHLDPL, Transform EPJKFCLNEED, LECJJIFLPFG NFFOAIJMGGN, bool OANLGLEMBPF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2F4C5E0", Offset = "0x2F4ABE0", VA = "0x182F4C5E0")]
	private T JPCICMLGIJL<T>(GameObject IPDAPNHLDPL, Transform EPJKFCLNEED, LECJJIFLPFG NFFOAIJMGGN, bool OANLGLEMBPF, out GameObject JDFLBEMMFEE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2F4C130", Offset = "0x2F4A730", VA = "0x182F4C130")]
	private T ECGLHLBFJKD<T>(GameObject POBIIKOLKCO, LECJJIFLPFG NFFOAIJMGGN, bool OANLGLEMBPF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0810", Offset = "0x1FEEE10", VA = "0x181FF0810")]
	private void IJLKCABEOMJ(Component AJCPBFDANOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1FF02A0", Offset = "0x1FEE8A0", VA = "0x181FF02A0")]
	private void CKOMNKHAPDD(Component AJCPBFDANOM, LECJJIFLPFG NFFOAIJMGGN, bool OANLGLEMBPF, [Optional] Type BMCOKKEBODC, [Optional] Type OIKFCMKNOBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0160", Offset = "0x1FEE760", VA = "0x181FF0160")]
	private void BPHDDLGHBLC(GameObject POBIIKOLKCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct LECJJIFLPFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Dictionary<Type, object> APANMNEMCAF;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2FF7420", Offset = "0x2FF5A20", VA = "0x182FF7420")]
	public LECJJIFLPFG CBFNCDEHMFE<T>(T CANMLEHJDGL)
	{
		return default(LECJJIFLPFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2F4BE20", Offset = "0x2F4A420", VA = "0x182F4BE20")]
	public T JDHJFFECIGH<T>(T PGBGCEJMLBM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x30879E0", Offset = "0x3085FE0", VA = "0x1830879E0")]
	public bool MOPFFPLGNFH<T>(out T CANMLEHJDGL)
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
				[Cpp2IlInjected.Address(RVA = "0x1FF0140", Offset = "0x1FEE740", VA = "0x181FF0140")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x1FF0130", Offset = "0x1FEE730", VA = "0x181FF0130")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FED870", Offset = "0x1FEBE70", VA = "0x181FED870")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LGCCFOPAPFH
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly List<URPLight> PCDFCDADHGD;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly Vector3 NKBGDPLLOCF;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly Vector3 LJDLPBKDCKH;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static Camera MEKOBBPDCGO;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public const string AHHCPNLKLHM = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const NMPNINDJOGP EJNNBNCCBHF = NMPNINDJOGP.Water;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<Renderer> KLJJGGNJKKG;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static AmbientMode PIGIKJHPJDM;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static Color JALKPJJKENN;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static Color OKIGEFHDGLJ;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static Color LEDEMJFHMGH;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Cubemap BNCOGCHCDMD;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static bool KAEELADEADI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera HFFCBCAPGLG
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE4C0", Offset = "0x1FECAC0", VA = "0x181FEE4C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1FEEA30", Offset = "0x1FED030", VA = "0x181FEEA30")]
	public static void HLBGGNDDKAM(Vector3 MGNDKOKOIFE, Quaternion DPFLCKACKKN, ImposterRenderConfig EBJBCBICFJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1FEFB10", Offset = "0x1FEE110", VA = "0x181FEFB10")]
	private static void PAGJOBLICAN(Vector3 MGNDKOKOIFE, Quaternion DPFLCKACKKN, URPLight IKEEAPLFPHD, ImposterRenderConfig.LightConfig EBEIOOFGIFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE950", Offset = "0x1FECF50", VA = "0x181FEE950")]
	public static void HIPPCPIHNAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF810", Offset = "0x1FEDE10", VA = "0x181FEF810")]
	private static void OIGHDKKPGKJ(int DILEAGMPOGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF690", Offset = "0x1FEDC90", VA = "0x181FEF690")]
	public static void NKMICDNCPFK(ImposterRenderConfig EBJBCBICFJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE3C0", Offset = "0x1FEC9C0", VA = "0x181FEE3C0")]
	public static void EFJBBAHIHIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1FEFE50", Offset = "0x1FEE450", VA = "0x181FEFE50")]
	public static void PJCDPDKGEEC(GameObject AGIECGBGEFH, RenderTexture LBNPNDDHGAP, ImposterRenderConfig EBJBCBICFJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF0A0", Offset = "0x1FED6A0", VA = "0x181FEF0A0")]
	private static void LEONIILDEFK(GameObject AGIECGBGEFH, RenderTexture LBNPNDDHGAP, ImposterRenderConfig EBJBCBICFJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE6C0", Offset = "0x1FECCC0", VA = "0x181FEE6C0")]
	private static void HBPIAIHGDFE(GameObject AGIECGBGEFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE230", Offset = "0x1FEC830", VA = "0x181FEE230")]
	public static void BEOBDPLMLGI(List<Renderer> FGHIGMOGCKI, List<Material> PALIKCBHGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1FEECB0", Offset = "0x1FED2B0", VA = "0x181FEECB0")]
	private static void IDNIEAAJDBI(List<Renderer> FGHIGMOGCKI, Vector3 EKOGJFDCNML, Vector3 JEBMOMCODJJ, float IBJLAKBGEED, out Vector3 EKPKIOLADCD, out Quaternion AKFBOMHMJAK, out float EHAEHKPMIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1FEF5F0", Offset = "0x1FEDBF0", VA = "0x181FEF5F0")]
	public static RenderTexture MOMPEEDLPPF(int OMKIDNPFIFC, int JEGDAENABFA)
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
		public struct ENGDFAGGHGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public IABAIOOKIMF DFOHOMMNCNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public GameObject HNHCNIOJMJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public RenderTexture ABKCMFLKNMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public ImposterRenderConfig ACPNBAAOLGO;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x1FED530", Offset = "0x1FEBB30", VA = "0x181FED530")]
			public ENGDFAGGHGP(IABAIOOKIMF OOLNGCNGGEE, GameObject EDPFHFOGHOB, RenderTexture LBNPNDDHGAP, ImposterRenderConfig LJMIOGOHGMO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const int PDFLPBJOGDE = 1;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const int JMBEDMJMKGB = 6;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static global::NHIPFPHPBON<ENGDFAGGHGP, RenderTexture> EINKNMINODH;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static readonly List<ENGDFAGGHGP> JDABCNAHFIB;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int GJJJFAOGLKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA0F5C0", Offset = "0xA0DBC0", VA = "0x180A0F5C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1FED0F0", Offset = "0x1FEB6F0", VA = "0x181FED0F0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject AGIECGBGEFH, RenderTexture LBNPNDDHGAP, ImposterRenderConfig EBJBCBICFJP, CancellationToken CKLMBBKFAGN, bool LOBOOEHFDIE = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1FECC10", Offset = "0x1FEB210", VA = "0x181FECC10", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1FED060", Offset = "0x1FEB660", VA = "0x181FED060", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1FECD30", Offset = "0x1FEB330", VA = "0x181FECD30")]
		private static Task<RenderTexture> MLHDDOOPGKI(ENGDFAGGHGP INFAAPLHDNL, CancellationToken CKLMBBKFAGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1FED4D0", Offset = "0x1FEBAD0", VA = "0x181FED4D0")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class KKINEKHOKMG
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static byte[] DOJNIBDEPHD;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static int KFPMCEOFNHF;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static int FPHJGLDCBHD;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static BigInteger HMCNEAFPECA;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
	public KKINEKHOKMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1FEDF70", Offset = "0x1FEC570", VA = "0x181FEDF70")]
	private static string IOLHAJOLOLL(byte[] CGENIFKMPBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1FEDC40", Offset = "0x1FEC240", VA = "0x181FEDC40")]
	public static string FFHDEGOGLMA(byte[] LDGCJAPEANM, bool ONIHJAEONNB)
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
		[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
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
