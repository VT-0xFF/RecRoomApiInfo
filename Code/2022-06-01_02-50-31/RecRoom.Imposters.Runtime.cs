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
public class ImposterPreviewCustomFraming : MonoBehaviour, HCHJIPDHNAK
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float PPOKMAJOPFB = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "4")]
	public void PrepareImposter(LODKDHHIFMC KCABGBBCLOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4D43280", Offset = "0x4D41C80", VA = "0x184D43280")]
	public void SetReferencePoint(Vector3 IANNLLCEEPH, Quaternion HJNGHCCLHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4D42FE0", Offset = "0x4D419E0", VA = "0x184D42FE0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4D43210", Offset = "0x4D41C10", VA = "0x184D43210")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xCC5DD0", Offset = "0xCC47D0", VA = "0x180CC5DD0")]
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
		[LJOCGMMGCIH(JAJEGMAJLMP.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const int DEOPANHCBCE = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int KGFAFEJINKC = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly List<Material> MMAGIMLAEOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool CCHHFALFKMJ;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4D43440", Offset = "0x4D41E40", VA = "0x184D43440")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4D43340", Offset = "0x4D41D40", VA = "0x184D43340")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4D43620", Offset = "0x4D42020", VA = "0x184D43620")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class CenterInImposter : MonoBehaviour, HCHJIPDHNAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4D42530", Offset = "0x4D40F30", VA = "0x184D42530", Slot = "4")]
		public void PrepareImposter(LODKDHHIFMC KCABGBBCLOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x54FA60", Offset = "0x54E460", VA = "0x18054FA60")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x54FA60", Offset = "0x54E460", VA = "0x18054FA60")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HCHJIPDHNAK
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(LODKDHHIFMC KCABGBBCLOF);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface PCLJMDIMBIN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> DOJIKNGLDHC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> OGMLHNGLEIA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface CLOKIPOOCEF
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ADDPDOCOBKP(params Type[] IPIGBILBNLD);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MLGIJJHLJBP(params Type[] IPIGBILBNLD);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject JEMJMNNFKPN(GameObject OHCKICLFOCE, Transform MMEAACHMALE, bool KNIKPPBAAJJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T JEMJMNNFKPN<T>(T OHCKICLFOCE, Transform MMEAACHMALE, bool KNIKPPBAAJJ = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T JEMJMNNFKPN<T>(GameObject OHCKICLFOCE, Transform MMEAACHMALE, bool KNIKPPBAAJJ = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject JEMJMNNFKPN(GameObject OHCKICLFOCE, Transform MMEAACHMALE, LODKDHHIFMC KCABGBBCLOF, bool KNIKPPBAAJJ);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T JEMJMNNFKPN<T>(GameObject OHCKICLFOCE, Transform MMEAACHMALE, LODKDHHIFMC KCABGBBCLOF, bool KNIKPPBAAJJ) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T JEMJMNNFKPN<T>(T OHCKICLFOCE, Transform MMEAACHMALE, LODKDHHIFMC KCABGBBCLOF, bool KNIKPPBAAJJ) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class CAKFBECLHOH : IDisposable, CLOKIPOOCEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HashSet<Type> BAJPHNPKKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly HashSet<Type> GNNBNDMIDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Transform FAMEGPIBCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<Component> KHDJOEKJKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> BJKBKMOKAJO;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4D41CD0", Offset = "0x4D406D0", VA = "0x184D41CD0")]
	[OCMHJDCAMOC]
	public static void HPKPPDLCMHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4D42200", Offset = "0x4D40C00", VA = "0x184D42200")]
	[Preserve]
	public CAKFBECLHOH([GEKAHLKFDNK(null)] PCLJMDIMBIN KDLGDHCMDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4D41760", Offset = "0x4D40160", VA = "0x184D41760", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4D41710", Offset = "0x4D40110", VA = "0x184D41710", Slot = "5")]
	public void ADDPDOCOBKP(params Type[] IPIGBILBNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4D42070", Offset = "0x4D40A70", VA = "0x184D42070", Slot = "6")]
	public void MLGIJJHLJBP(params Type[] IPIGBILBNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4D41F50", Offset = "0x4D40950", VA = "0x184D41F50", Slot = "7")]
	public GameObject JEMJMNNFKPN(GameObject OHCKICLFOCE, Transform MMEAACHMALE, bool KNIKPPBAAJJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x275A8C0", Offset = "0x27592C0", VA = "0x18275A8C0", Slot = "8")]
	public T JEMJMNNFKPN<T>(T OHCKICLFOCE, Transform MMEAACHMALE, bool KNIKPPBAAJJ = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x275A7B0", Offset = "0x27591B0", VA = "0x18275A7B0", Slot = "9")]
	public T JEMJMNNFKPN<T>(GameObject OHCKICLFOCE, Transform MMEAACHMALE, bool KNIKPPBAAJJ = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4D41FE0", Offset = "0x4D409E0", VA = "0x184D41FE0", Slot = "10")]
	public GameObject JEMJMNNFKPN(GameObject OHCKICLFOCE, Transform MMEAACHMALE, LODKDHHIFMC KCABGBBCLOF, bool KNIKPPBAAJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x275A7E0", Offset = "0x27591E0", VA = "0x18275A7E0", Slot = "11")]
	public T JEMJMNNFKPN<T>(GameObject OHCKICLFOCE, Transform MMEAACHMALE, LODKDHHIFMC KCABGBBCLOF, bool KNIKPPBAAJJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x275A830", Offset = "0x2759230", VA = "0x18275A830", Slot = "12")]
	public T JEMJMNNFKPN<T>(T OHCKICLFOCE, Transform MMEAACHMALE, LODKDHHIFMC KCABGBBCLOF, bool KNIKPPBAAJJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x275A270", Offset = "0x2758C70", VA = "0x18275A270")]
	private T JEMJMNNFKPN<T>(GameObject OHCKICLFOCE, Transform MMEAACHMALE, LODKDHHIFMC KCABGBBCLOF, bool KNIKPPBAAJJ, out GameObject DEEAMBJDBEL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x275A930", Offset = "0x2759330", VA = "0x18275A930")]
	private T NHOHCIGIIOL<T>(GameObject BHNNPCJCNFB, LODKDHHIFMC KCABGBBCLOF, bool KNIKPPBAAJJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4D41E30", Offset = "0x4D40830", VA = "0x184D41E30")]
	private void IFOFFDICHCK(Component ENHKEICGIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4D41860", Offset = "0x4D40260", VA = "0x184D41860")]
	private void FMLEBOGEEPH(Component ENHKEICGIAL, LODKDHHIFMC KCABGBBCLOF, bool KNIKPPBAAJJ, [Optional] Type IPLOONBKKND, [Optional] Type PHGOCMLJKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4D420C0", Offset = "0x4D40AC0", VA = "0x184D420C0")]
	private void OBPMLGHJGDA(GameObject BHNNPCJCNFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct LODKDHHIFMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<Type, object> FNFELKOMEND;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2405690", Offset = "0x2404090", VA = "0x182405690")]
	public LODKDHHIFMC DDDJGAONDCK<T>(T BGOKFFKFKBE)
	{
		return default(LODKDHHIFMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2762DE0", Offset = "0x27617E0", VA = "0x182762DE0")]
	public T POIAOKDLGFC<T>(T PHOLMDNLIEE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x27B4D10", Offset = "0x27B3710", VA = "0x1827B4D10")]
	public bool FHLLGNFGHGE<T>(out T BGOKFFKFKBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct KBFFBOLFMMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public bool AABDBGBPJJI;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xE2E060", Offset = "0xE2CA60", VA = "0x180E2E060")]
	public KBFFBOLFMMM(bool DOOMCBLMGHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct GLCCGMOCIGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly bool MPHCHFMIEFG;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4D42FD0", Offset = "0x4D419D0", VA = "0x184D42FD0")]
	public GLCCGMOCIGC(bool JIEHGDHHPBL)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x54FA60", Offset = "0x54E460", VA = "0x18054FA60")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ScaleInImposter : MonoBehaviour, HCHJIPDHNAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4D43CB0", Offset = "0x4D426B0", VA = "0x184D43CB0", Slot = "4")]
		public void PrepareImposter(LODKDHHIFMC KCABGBBCLOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x54FA60", Offset = "0x54E460", VA = "0x18054FA60")]
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
				[Cpp2IlInjected.Address(RVA = "0x4D43C90", Offset = "0x4D42690", VA = "0x184D43C90")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x4D43C80", Offset = "0x4D42680", VA = "0x184D43C80")]
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
		[Cpp2IlInjected.Address(RVA = "0x4D432C0", Offset = "0x4D41CC0", VA = "0x184D432C0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class ALIFMCPAFKI
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly List<URPLight> HKLKLLMGPGI;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly Vector3 GNOOPEMLCDJ;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Vector3 PGIFMIGLDGE;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static Camera JDKHBHLPAOO;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public const string IJDGKGAPKDF = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public const MHJBHNPEIFN NBCEEDONGFI = MHJBHNPEIFN.Water;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly List<Renderer> PNICHMMMHDB;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static AmbientMode PFJDPCDPBEN;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color NGOFEGCJLGI;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static Color GFEEACGHGAK;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static Color JGNKAIMGGOP;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static Cubemap IBMFDCBCMMA;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static bool DKHFLIGDPCK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera LGEAEPNDIDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4D413C0", Offset = "0x4D3FDC0", VA = "0x184D413C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4D40350", Offset = "0x4D3ED50", VA = "0x184D40350")]
	public static void GMKCHIGGMAP(Vector3 ONFBFECLFCP, Quaternion GICDJKBFDNF, ImposterRenderConfig MLHMPPCIPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4D40010", Offset = "0x4D3EA10", VA = "0x184D40010")]
	private static void GLLJMPFLLDG(Vector3 ONFBFECLFCP, Quaternion GICDJKBFDNF, URPLight GMMLPMMFIOC, ImposterRenderConfig.LightConfig AAACHPOAADD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4D3FDB0", Offset = "0x4D3E7B0", VA = "0x184D3FDB0")]
	public static void EDBMHBOLLHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4D3F920", Offset = "0x4D3E320", VA = "0x184D3F920")]
	private static void AKHNEAFNFNH(int IGLMDAFFHEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4D3FE90", Offset = "0x4D3E890", VA = "0x184D3FE90")]
	public static void GAOEFOLDPNO(ImposterRenderConfig MLHMPPCIPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4D408E0", Offset = "0x4D3F2E0", VA = "0x184D408E0")]
	public static void IFDKIIDMKOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4D3FC20", Offset = "0x4D3E620", VA = "0x184D3FC20")]
	public static void AMEAPINDEEC(GameObject KGCKBLDOPGH, RenderTexture CAPOKNNNMHJ, ImposterRenderConfig MLHMPPCIPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4D40D10", Offset = "0x4D3F710", VA = "0x184D40D10")]
	private static void KOHEGCJNIOD(GameObject KGCKBLDOPGH, RenderTexture CAPOKNNNMHJ, ImposterRenderConfig MLHMPPCIPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4D409E0", Offset = "0x4D3F3E0", VA = "0x184D409E0")]
	private static void ILKMOEPFLBP(GameObject KGCKBLDOPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4D41230", Offset = "0x4D3FC30", VA = "0x184D41230")]
	public static void MKBAAAOMIJN(List<Renderer> JLDFIPPEBLG, List<Material> POBLMOBJPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4D405D0", Offset = "0x4D3EFD0", VA = "0x184D405D0")]
	private static void HDNDLMILBGI(GameObject OHCKICLFOCE, Vector3 BBHCEPGMMPN, Vector3 LLKDGEHBFLE, float IJCLFEJNADN, out Vector3 MJGPNNOAIGJ, out Quaternion BAPHOHFBLGK, out float NDFDHGOBMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4D40C70", Offset = "0x4D3F670", VA = "0x184D40C70")]
	public static RenderTexture KEJALIEKGJP(int IHCNDPNEGKP, int CNICIJGDLJM)
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
		public struct DFFEHLDDLDA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public FLCLHLLPKNN KJHMDIECKAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public GameObject IEPIAGAGMDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public RenderTexture CHOLMFPAOBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public ImposterRenderConfig NFMDMADBGEM;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x1B77D00", Offset = "0x1B76700", VA = "0x181B77D00")]
			public DFFEHLDDLDA(FLCLHLLPKNN NFMNDONCHFK, GameObject JNDGMDMEMEN, RenderTexture CAPOKNNNMHJ, ImposterRenderConfig LKFGMCNKCEG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const int ALEHFEMMOFN = 1;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int DAFABIPKCGH = 6;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static global::JAAJCBFBODG<DFFEHLDDLDA, RenderTexture> GJCHCMKILMD;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static readonly List<DFFEHLDDLDA> GDNGCJGGLJE;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int JJALJEOIHNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAC0480", Offset = "0xABEE80", VA = "0x180AC0480")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4D42B90", Offset = "0x4D41590", VA = "0x184D42B90")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject KGCKBLDOPGH, RenderTexture CAPOKNNNMHJ, ImposterRenderConfig MLHMPPCIPFE, CancellationToken PKFOPLIPJOL, bool DMONFADKLEL = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4D426B0", Offset = "0x4D410B0", VA = "0x184D426B0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4D42B00", Offset = "0x4D41500", VA = "0x184D42B00", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4D427D0", Offset = "0x4D411D0", VA = "0x184D427D0")]
		private static Task<RenderTexture> MPMDDPGKOKI(DFFEHLDDLDA KLOBBKKIJFM, CancellationToken PKFOPLIPJOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4D42F70", Offset = "0x4D41970", VA = "0x184D42F70")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class LGGEBEFKHFL
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static byte[] BNGJCABJHMJ;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int DABHOAMPMJG;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static int JKHLNLJIIMI;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static BigInteger DBPEINBOKAP;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public LGGEBEFKHFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4D439C0", Offset = "0x4D423C0", VA = "0x184D439C0")]
	private static string OGKENCFMFPL(byte[] ODMIEFIFOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4D43690", Offset = "0x4D42090", VA = "0x184D43690")]
	public static string KDPIBNPAHEL(byte[] MCBNAPIFOAJ, bool LELELDJDMBB)
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
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
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
