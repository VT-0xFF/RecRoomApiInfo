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
public class ImposterPreviewCustomFraming : MonoBehaviour, EMMKNPMEGDI
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float ICFLHNKMMFO = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "4")]
	public void PrepareImposter(JBNLBJGPPII INOCFKIFMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5F9F3D0", Offset = "0x5F9DDD0", VA = "0x185F9F3D0")]
	public void SetReferencePoint(Vector3 JJPMPKMDDHD, Quaternion JOJONLKIPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5F9F240", Offset = "0x5F9DC40", VA = "0x185F9F240")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5F9F3A0", Offset = "0x5F9DDA0", VA = "0x185F9F3A0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1160060", Offset = "0x115EA60", VA = "0x181160060")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct AFPGAPFLAAI
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static AFPGAPFLAAI IBBELFFAKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public float PHBMCPCGPEC;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2478730", Offset = "0x2477130", VA = "0x182478730")]
	public AFPGAPFLAAI(float OCGLPIGNDOA)
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		[OBEBELAGOGC(FDCMDMMJJJI.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const int IKKJPCOAIHK = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const int CAMBLDDDKGM = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly List<Material> HLMGFBAGMHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool JELJKBOLFPM;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F540", Offset = "0x5F9DF40", VA = "0x185F9F540")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F450", Offset = "0x5F9DE50", VA = "0x185F9F450")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F780", Offset = "0x5F9E180", VA = "0x185F9F780")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class CenterInImposter : MonoBehaviour, EMMKNPMEGDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5F9E7A0", Offset = "0x5F9D1A0", VA = "0x185F9E7A0", Slot = "4")]
		public void PrepareImposter(JBNLBJGPPII INOCFKIFMHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7519E0", Offset = "0x7503E0", VA = "0x1807519E0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7519E0", Offset = "0x7503E0", VA = "0x1807519E0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EMMKNPMEGDI
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(JBNLBJGPPII INOCFKIFMHI);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface PJEPKFHGNNN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> CDCJJAFEPAB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> MDNKDOJPLFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JKJJMIKKBOK
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KJFANAPMFCH(params Type[] GKLDKDMPMKM);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GFBCKJIICFL(params Type[] GKLDKDMPMKM);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject OLIGDGHBBGB(GameObject CDBJBIDGEMD, Transform EGNCPOLPGCD, bool POBNJOACFMA = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T OLIGDGHBBGB<T>(T CDBJBIDGEMD, Transform EGNCPOLPGCD, bool POBNJOACFMA = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T OLIGDGHBBGB<T>(GameObject CDBJBIDGEMD, Transform EGNCPOLPGCD, bool POBNJOACFMA = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject OLIGDGHBBGB(GameObject CDBJBIDGEMD, Transform EGNCPOLPGCD, JBNLBJGPPII INOCFKIFMHI, bool POBNJOACFMA);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T OLIGDGHBBGB<T>(GameObject CDBJBIDGEMD, Transform EGNCPOLPGCD, JBNLBJGPPII INOCFKIFMHI, bool POBNJOACFMA) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T OLIGDGHBBGB<T>(T CDBJBIDGEMD, Transform EGNCPOLPGCD, JBNLBJGPPII INOCFKIFMHI, bool POBNJOACFMA) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class OFNDIHKCAJA : IDisposable, JKJJMIKKBOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly HashSet<Type> ENFGDPCBHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly HashSet<Type> MKOBOBGPGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Transform PCGDDMGLOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly List<Component> CKDGCPIGDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> PPJJHNCKHCI;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2900", Offset = "0x5FA1300", VA = "0x185FA2900")]
	[PBIPNKEGBNL(MIDPNFMDJEE.None)]
	public static void LLBCFMIOPFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2B20", Offset = "0x5FA1520", VA = "0x185FA2B20")]
	[Preserve]
	public OFNDIHKCAJA([BJBHEPNDCKM(null)] PJEPKFHGNNN BPEMHMDKFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2630", Offset = "0x5FA1030", VA = "0x185FA2630", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2780", Offset = "0x5FA1180", VA = "0x185FA2780", Slot = "5")]
	public void KJFANAPMFCH(params Type[] GKLDKDMPMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2730", Offset = "0x5FA1130", VA = "0x185FA2730", Slot = "6")]
	public void GFBCKJIICFL(params Type[] GKLDKDMPMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2A90", Offset = "0x5FA1490", VA = "0x185FA2A90", Slot = "7")]
	public GameObject OLIGDGHBBGB(GameObject CDBJBIDGEMD, Transform EGNCPOLPGCD, bool POBNJOACFMA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2214A60", Offset = "0x2213460", VA = "0x182214A60", Slot = "8")]
	public T OLIGDGHBBGB<T>(T CDBJBIDGEMD, Transform EGNCPOLPGCD, bool POBNJOACFMA = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x22143D0", Offset = "0x2212DD0", VA = "0x1822143D0", Slot = "9")]
	public T OLIGDGHBBGB<T>(GameObject CDBJBIDGEMD, Transform EGNCPOLPGCD, bool POBNJOACFMA = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5FA2A00", Offset = "0x5FA1400", VA = "0x185FA2A00", Slot = "10")]
	public GameObject OLIGDGHBBGB(GameObject CDBJBIDGEMD, Transform EGNCPOLPGCD, JBNLBJGPPII INOCFKIFMHI, bool POBNJOACFMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2214400", Offset = "0x2212E00", VA = "0x182214400", Slot = "11")]
	public T OLIGDGHBBGB<T>(GameObject CDBJBIDGEMD, Transform EGNCPOLPGCD, JBNLBJGPPII INOCFKIFMHI, bool POBNJOACFMA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2214450", Offset = "0x2212E50", VA = "0x182214450", Slot = "12")]
	public T OLIGDGHBBGB<T>(T CDBJBIDGEMD, Transform EGNCPOLPGCD, JBNLBJGPPII INOCFKIFMHI, bool POBNJOACFMA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x22144E0", Offset = "0x2212EE0", VA = "0x1822144E0")]
	private T OLIGDGHBBGB<T>(GameObject CDBJBIDGEMD, Transform EGNCPOLPGCD, JBNLBJGPPII INOCFKIFMHI, bool POBNJOACFMA, out GameObject KGFLJKJFMMF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2213E70", Offset = "0x2212870", VA = "0x182213E70")]
	private T KDNPFFIMKLM<T>(GameObject OOAFGPFKNDK, JBNLBJGPPII INOCFKIFMHI, bool POBNJOACFMA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5FA27D0", Offset = "0x5FA11D0", VA = "0x185FA27D0")]
	private void KOFMJLFDMFI(Component PAHLILOLPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5FA20E0", Offset = "0x5FA0AE0", VA = "0x185FA20E0")]
	private void BHGAHHFEKCN(Component PAHLILOLPHD, JBNLBJGPPII INOCFKIFMHI, bool POBNJOACFMA, bool LBFBECCAHKK, [Optional] Type BPBHFEJNNPM, [Optional] Type CEOHFNIBFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1F80", Offset = "0x5FA0980", VA = "0x185FA1F80")]
	private void BEPMBNLEMOP(GameObject OOAFGPFKNDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct JBNLBJGPPII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Dictionary<Type, object> BJLADHEGEOA;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1764DA0", Offset = "0x17637A0", VA = "0x181764DA0")]
	public JBNLBJGPPII LMCGMFHIJLB<T>(T HOCPDJAJOIH)
	{
		return default(JBNLBJGPPII);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1764400", Offset = "0x1762E00", VA = "0x181764400")]
	public T DNANCALJAPO<T>(T DJFOKMFDJPD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x17644C0", Offset = "0x1762EC0", VA = "0x1817644C0")]
	public bool FJMGOOAKNCK<T>(out T HOCPDJAJOIH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct NMCMLHDBFEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public bool MIJAFHGDMJG;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xFE8250", Offset = "0xFE6C50", VA = "0x180FE8250")]
	public NMCMLHDBFEO(bool KMAEPEGPMCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct KCENOJMAAJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly bool CJHFAEHOHFD;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1910", Offset = "0x5FA0310", VA = "0x185FA1910")]
	public KCENOJMAAJH(bool LNMELKHDHBJ)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7519E0", Offset = "0x7503E0", VA = "0x1807519E0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ScaleInImposter : MonoBehaviour, EMMKNPMEGDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5FA2FD0", Offset = "0x5FA19D0", VA = "0x185FA2FD0", Slot = "4")]
		public void PrepareImposter(JBNLBJGPPII INOCFKIFMHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7519E0", Offset = "0x7503E0", VA = "0x1807519E0")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CreateAssetMenu]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			[Header("Shadows")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x5FA1F60", Offset = "0x5FA0960", VA = "0x185FA1F60")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5FA1F50", Offset = "0x5FA0950", VA = "0x185FA1F50")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F410", Offset = "0x5F9DE10", VA = "0x185F9F410")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class JMFIECBBFHH
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<URPLight> EFLLBKAAAKB;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly Vector3 DKNJPCLILPJ;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly Vector3 GGKHGLIAMDB;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static Camera DLAFPKENHMF;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public const string HKDHACKLLGH = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public const LCAEFPNNEFC CIPMEPLPBKN = LCAEFPNNEFC.Water;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static readonly List<Renderer> LLCPFPKHLNF;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static AmbientMode OEMMFKCFOIN;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static Color FGHMDDOJMIA;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static Color OEFBICNPDMN;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static Color FGEKJMAAECJ;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static Cubemap GPPICPFMIIM;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static bool PDGABDLHFNC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera CLNJFBGKDFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5FA0B90", Offset = "0x5F9F590", VA = "0x185FA0B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5FA10D0", Offset = "0x5F9FAD0", VA = "0x185FA10D0")]
	public static void NAFILAMOKAL(Vector3 CIBHKHFLNGP, Quaternion NIKOEDGJJKF, ImposterRenderConfig KMAGGENOCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5FA0DC0", Offset = "0x5F9F7C0", VA = "0x185FA0DC0")]
	private static void LNDNIPIIGBI(Vector3 CIBHKHFLNGP, Quaternion NIKOEDGJJKF, URPLight EMJDJMJLAOE, ImposterRenderConfig.LightConfig NEHFGCNCGIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5F9F800", Offset = "0x5F9E200", VA = "0x185F9F800")]
	public static void ECCADFPNAGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5FA0290", Offset = "0x5F9EC90", VA = "0x185FA0290")]
	private static void JAFDJNOJCBG(int BBOMJNHHOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5FA0660", Offset = "0x5F9F060", VA = "0x185FA0660")]
	public static void JGJNGPABLGN(ImposterRenderConfig KMAGGENOCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5FA07E0", Offset = "0x5F9F1E0", VA = "0x185FA07E0")]
	public static void KIDDFKAPAND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5F9FB20", Offset = "0x5F9E520", VA = "0x185F9FB20")]
	public static void HHFKAGDHPJA(GameObject EENFPCOAAFC, RenderTexture CLJDNKIKEPN, ImposterRenderConfig KMAGGENOCMM, AFPGAPFLAAI MBPCLLOFHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5F9FD90", Offset = "0x5F9E790", VA = "0x185F9FD90")]
	private static void IEJHJGMPMCJ(GameObject EENFPCOAAFC, RenderTexture CLJDNKIKEPN, ImposterRenderConfig KMAGGENOCMM, AFPGAPFLAAI MBPCLLOFHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5FA08E0", Offset = "0x5F9F2E0", VA = "0x185FA08E0")]
	private static void KPLLBMFCHOH(GameObject EENFPCOAAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1620", Offset = "0x5FA0020", VA = "0x185FA1620")]
	public static void PBHDAKHKANK(List<Renderer> BMOCBDOIFFD, List<Material> KILDFMDHNMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1350", Offset = "0x5F9FD50", VA = "0x185FA1350")]
	public static void NAHIEICGILO(GameObject CDBJBIDGEMD, Vector3 FKEFKOACEOP, Vector3 EOHAHLGFFNB, float NGGIFBMDLDL, AFPGAPFLAAI MBPCLLOFHEI, out Vector3 FNCNOKEACPH, out Quaternion LHHLGLILHHJ, out float BAJLDLMHPKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5F9FCF0", Offset = "0x5F9E6F0", VA = "0x185F9FCF0")]
	public static RenderTexture HPLPFPNBFFJ(int KAJKGOBCCGF, int FOAFPMPLOCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5F9F8F0", Offset = "0x5F9E2F0", VA = "0x185F9F8F0")]
	public static void ENEBMCGDHBD()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public struct OGJLJAGHIFP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public OGALPGFNGBA FMHIPKBIHOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public GameObject JOABHDPGCOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public RenderTexture JJMOIMLKDKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public ImposterRenderConfig BHIBGGKIGAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public AFPGAPFLAAI AFPGAPFLAAI;

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5FA2F60", Offset = "0x5FA1960", VA = "0x185FA2F60")]
			public OGJLJAGHIFP(OGALPGFNGBA AHLNHPIIHCB, GameObject LEBMNNNAGEL, RenderTexture CLJDNKIKEPN, ImposterRenderConfig GIMGJCJFIIF, AFPGAPFLAAI MBPCLLOFHEI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int PBKFJMHJCKO = 1;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int PNGDADFGGLO = 6;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static global::ODGHJMHABMI<OGJLJAGHIFP, RenderTexture> FACILOALGND;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static readonly List<OGJLJAGHIFP> BGBJODKDNBO;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int PCOOFHFJBFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7E39F0", Offset = "0x7E23F0", VA = "0x1807E39F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5F9ED00", Offset = "0x5F9D700", VA = "0x185F9ED00")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject EENFPCOAAFC, RenderTexture CLJDNKIKEPN, ImposterRenderConfig KMAGGENOCMM, AFPGAPFLAAI MBPCLLOFHEI, CancellationToken OGOJJPCADFI, bool CAIMBBPBAAE = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5F9E900", Offset = "0x5F9D300", VA = "0x185F9E900", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5F9EA90", Offset = "0x5F9D490", VA = "0x185F9EA90", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5F9EB30", Offset = "0x5F9D530", VA = "0x185F9EB30")]
		private static Task<RenderTexture> PCGOLJBFJOJ(OGJLJAGHIFP KMKOHPNBJON, CancellationToken OGOJJPCADFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F1D0", Offset = "0x5F9DBD0", VA = "0x185F9F1D0")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LHIPOBGMLKE
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static byte[] PNBNOGIJBMC;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static int DGEFGPNJFGJ;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static int GBGLKCBJBIA;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static BigInteger EPCGLFJDNLL;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public LHIPOBGMLKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1920", Offset = "0x5FA0320", VA = "0x185FA1920")]
	private static string GKOJACPJHAL(byte[] KCHCODPDAGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5FA1A30", Offset = "0x5FA0430", VA = "0x185FA1A30")]
	public static string MEDIDALCMKC(byte[] GHEBPHBJKNK, bool FPEGHFMMINI)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
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
