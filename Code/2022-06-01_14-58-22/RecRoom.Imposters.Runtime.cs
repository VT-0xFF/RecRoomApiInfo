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
	[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "4")]
	public void PrepareImposter(LODKDHHIFMC KCABGBBCLOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4E5C030", Offset = "0x4E5AA30", VA = "0x184E5C030")]
	public void SetReferencePoint(Vector3 IANNLLCEEPH, Quaternion HJNGHCCLHMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4E5BD90", Offset = "0x4E5A790", VA = "0x184E5BD90")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4E5BFC0", Offset = "0x4E5A9C0", VA = "0x184E5BFC0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xEFBA40", Offset = "0xEFA440", VA = "0x180EFBA40")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E5C1F0", Offset = "0x4E5ABF0", VA = "0x184E5C1F0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4E5C0F0", Offset = "0x4E5AAF0", VA = "0x184E5C0F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4E5C3D0", Offset = "0x4E5ADD0", VA = "0x184E5C3D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E5B2E0", Offset = "0x4E59CE0", VA = "0x184E5B2E0", Slot = "4")]
		public void PrepareImposter(LODKDHHIFMC KCABGBBCLOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x560A60", Offset = "0x55F460", VA = "0x180560A60")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x560A60", Offset = "0x55F460", VA = "0x180560A60")]
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
	[Cpp2IlInjected.Address(RVA = "0x4E5AA80", Offset = "0x4E59480", VA = "0x184E5AA80")]
	[OCMHJDCAMOC]
	public static void HPKPPDLCMHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4E5AFB0", Offset = "0x4E599B0", VA = "0x184E5AFB0")]
	[Preserve]
	public CAKFBECLHOH([GEKAHLKFDNK(null)] PCLJMDIMBIN KDLGDHCMDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4E5A510", Offset = "0x4E58F10", VA = "0x184E5A510", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4E5A4C0", Offset = "0x4E58EC0", VA = "0x184E5A4C0", Slot = "5")]
	public void ADDPDOCOBKP(params Type[] IPIGBILBNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4E5AE20", Offset = "0x4E59820", VA = "0x184E5AE20", Slot = "6")]
	public void MLGIJJHLJBP(params Type[] IPIGBILBNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4E5AD00", Offset = "0x4E59700", VA = "0x184E5AD00", Slot = "7")]
	public GameObject JEMJMNNFKPN(GameObject OHCKICLFOCE, Transform MMEAACHMALE, bool KNIKPPBAAJJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2932CD0", Offset = "0x29316D0", VA = "0x182932CD0", Slot = "8")]
	public T JEMJMNNFKPN<T>(T OHCKICLFOCE, Transform MMEAACHMALE, bool KNIKPPBAAJJ = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2932BC0", Offset = "0x29315C0", VA = "0x182932BC0", Slot = "9")]
	public T JEMJMNNFKPN<T>(GameObject OHCKICLFOCE, Transform MMEAACHMALE, bool KNIKPPBAAJJ = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4E5AD90", Offset = "0x4E59790", VA = "0x184E5AD90", Slot = "10")]
	public GameObject JEMJMNNFKPN(GameObject OHCKICLFOCE, Transform MMEAACHMALE, LODKDHHIFMC KCABGBBCLOF, bool KNIKPPBAAJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2932BF0", Offset = "0x29315F0", VA = "0x182932BF0", Slot = "11")]
	public T JEMJMNNFKPN<T>(GameObject OHCKICLFOCE, Transform MMEAACHMALE, LODKDHHIFMC KCABGBBCLOF, bool KNIKPPBAAJJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2932C40", Offset = "0x2931640", VA = "0x182932C40", Slot = "12")]
	public T JEMJMNNFKPN<T>(T OHCKICLFOCE, Transform MMEAACHMALE, LODKDHHIFMC KCABGBBCLOF, bool KNIKPPBAAJJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2932600", Offset = "0x2931000", VA = "0x182932600")]
	private T JEMJMNNFKPN<T>(GameObject OHCKICLFOCE, Transform MMEAACHMALE, LODKDHHIFMC KCABGBBCLOF, bool KNIKPPBAAJJ, out GameObject DEEAMBJDBEL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2932D40", Offset = "0x2931740", VA = "0x182932D40")]
	private T NHOHCIGIIOL<T>(GameObject BHNNPCJCNFB, LODKDHHIFMC KCABGBBCLOF, bool KNIKPPBAAJJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4E5ABE0", Offset = "0x4E595E0", VA = "0x184E5ABE0")]
	private void IFOFFDICHCK(Component ENHKEICGIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4E5A610", Offset = "0x4E59010", VA = "0x184E5A610")]
	private void FMLEBOGEEPH(Component ENHKEICGIAL, LODKDHHIFMC KCABGBBCLOF, bool KNIKPPBAAJJ, [Optional] Type IPLOONBKKND, [Optional] Type PHGOCMLJKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4E5AE70", Offset = "0x4E59870", VA = "0x184E5AE70")]
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
	[Cpp2IlInjected.Address(RVA = "0x29A74D0", Offset = "0x29A5ED0", VA = "0x1829A74D0")]
	public LODKDHHIFMC DDDJGAONDCK<T>(T BGOKFFKFKBE)
	{
		return default(LODKDHHIFMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x293EB40", Offset = "0x293D540", VA = "0x18293EB40")]
	public T POIAOKDLGFC<T>(T PHOLMDNLIEE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2D0CE60", Offset = "0x2D0B860", VA = "0x182D0CE60")]
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
	[Cpp2IlInjected.Address(RVA = "0x10FC240", Offset = "0x10FAC40", VA = "0x1810FC240")]
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
	[Cpp2IlInjected.Address(RVA = "0x4E5BD80", Offset = "0x4E5A780", VA = "0x184E5BD80")]
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
		[Cpp2IlInjected.Address(RVA = "0x560A60", Offset = "0x55F460", VA = "0x180560A60")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E5CA60", Offset = "0x4E5B460", VA = "0x184E5CA60", Slot = "4")]
		public void PrepareImposter(LODKDHHIFMC KCABGBBCLOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x560A60", Offset = "0x55F460", VA = "0x180560A60")]
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
				[Cpp2IlInjected.Address(RVA = "0x4E5CA40", Offset = "0x4E5B440", VA = "0x184E5CA40")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x4E5CA30", Offset = "0x4E5B430", VA = "0x184E5CA30")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E5C070", Offset = "0x4E5AA70", VA = "0x184E5C070")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E5A170", Offset = "0x4E58B70", VA = "0x184E5A170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4E59100", Offset = "0x4E57B00", VA = "0x184E59100")]
	public static void GMKCHIGGMAP(Vector3 ONFBFECLFCP, Quaternion GICDJKBFDNF, ImposterRenderConfig MLHMPPCIPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4E58DC0", Offset = "0x4E577C0", VA = "0x184E58DC0")]
	private static void GLLJMPFLLDG(Vector3 ONFBFECLFCP, Quaternion GICDJKBFDNF, URPLight GMMLPMMFIOC, ImposterRenderConfig.LightConfig AAACHPOAADD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4E58B60", Offset = "0x4E57560", VA = "0x184E58B60")]
	public static void EDBMHBOLLHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4E586D0", Offset = "0x4E570D0", VA = "0x184E586D0")]
	private static void AKHNEAFNFNH(int IGLMDAFFHEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4E58C40", Offset = "0x4E57640", VA = "0x184E58C40")]
	public static void GAOEFOLDPNO(ImposterRenderConfig MLHMPPCIPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4E59690", Offset = "0x4E58090", VA = "0x184E59690")]
	public static void IFDKIIDMKOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4E589D0", Offset = "0x4E573D0", VA = "0x184E589D0")]
	public static void AMEAPINDEEC(GameObject KGCKBLDOPGH, RenderTexture CAPOKNNNMHJ, ImposterRenderConfig MLHMPPCIPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4E59AC0", Offset = "0x4E584C0", VA = "0x184E59AC0")]
	private static void KOHEGCJNIOD(GameObject KGCKBLDOPGH, RenderTexture CAPOKNNNMHJ, ImposterRenderConfig MLHMPPCIPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4E59790", Offset = "0x4E58190", VA = "0x184E59790")]
	private static void ILKMOEPFLBP(GameObject KGCKBLDOPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4E59FE0", Offset = "0x4E589E0", VA = "0x184E59FE0")]
	public static void MKBAAAOMIJN(List<Renderer> JLDFIPPEBLG, List<Material> POBLMOBJPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4E59380", Offset = "0x4E57D80", VA = "0x184E59380")]
	private static void HDNDLMILBGI(GameObject OHCKICLFOCE, Vector3 BBHCEPGMMPN, Vector3 LLKDGEHBFLE, float IJCLFEJNADN, out Vector3 MJGPNNOAIGJ, out Quaternion BAPHOHFBLGK, out float NDFDHGOBMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4E59A20", Offset = "0x4E58420", VA = "0x184E59A20")]
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
			[Cpp2IlInjected.Address(RVA = "0x458B2F0", Offset = "0x4589CF0", VA = "0x18458B2F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x85EED0", Offset = "0x85D8D0", VA = "0x18085EED0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4E5B940", Offset = "0x4E5A340", VA = "0x184E5B940")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject KGCKBLDOPGH, RenderTexture CAPOKNNNMHJ, ImposterRenderConfig MLHMPPCIPFE, CancellationToken PKFOPLIPJOL, bool DMONFADKLEL = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4E5B460", Offset = "0x4E59E60", VA = "0x184E5B460", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4E5B8B0", Offset = "0x4E5A2B0", VA = "0x184E5B8B0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4E5B580", Offset = "0x4E59F80", VA = "0x184E5B580")]
		private static Task<RenderTexture> MPMDDPGKOKI(DFFEHLDDLDA KLOBBKKIJFM, CancellationToken PKFOPLIPJOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4E5BD20", Offset = "0x4E5A720", VA = "0x184E5BD20")]
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
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	public LGGEBEFKHFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4E5C770", Offset = "0x4E5B170", VA = "0x184E5C770")]
	private static string OGKENCFMFPL(byte[] ODMIEFIFOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4E5C440", Offset = "0x4E5AE40", VA = "0x184E5C440")]
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
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
