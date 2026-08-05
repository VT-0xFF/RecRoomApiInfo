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
public class ImposterPreviewCustomFraming : MonoBehaviour, PEAJKFNPBEF
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float ELILJBLACIA = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "4")]
	public void PrepareImposter(BAGDEAMBINE OLMBEJDJKAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4D06F90", Offset = "0x4D05F90", VA = "0x184D06F90")]
	public void SetReferencePoint(Vector3 HNJDIOBFDFH, Quaternion INBPMOJHGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4D06CF0", Offset = "0x4D05CF0", VA = "0x184D06CF0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4D06F20", Offset = "0x4D05F20", VA = "0x184D06F20")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E35C0", Offset = "0x5E25C0", VA = "0x1805E35C0")]
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
		[PAOKLKEFIEK(ELHMLMEGENM.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const int LMKHBPKBIAM = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int EIBMBKBNCFE = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly List<Material> ILOAMLDABEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool ICPLECDBNFD;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4D07150", Offset = "0x4D06150", VA = "0x184D07150")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4D07050", Offset = "0x4D06050", VA = "0x184D07050")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4D07330", Offset = "0x4D06330", VA = "0x184D07330")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class CenterInImposter : MonoBehaviour, PEAJKFNPBEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4D06250", Offset = "0x4D05250", VA = "0x184D06250", Slot = "4")]
		public void PrepareImposter(BAGDEAMBINE OLMBEJDJKAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5BEEC0", Offset = "0x5BDEC0", VA = "0x1805BEEC0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5BEEC0", Offset = "0x5BDEC0", VA = "0x1805BEEC0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PEAJKFNPBEF
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(BAGDEAMBINE OLMBEJDJKAO);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FKANBGGIFEI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> JOLKHPDBABO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> JDKPMJEKOFD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface HGMJFAPPLEL
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FECIPKFOPIF(params Type[] ACLMIOCMKEB);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LJNOFOJHDPD(params Type[] ACLMIOCMKEB);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject DBHNHBEAMME(GameObject GDCMHMHOFPL, Transform HNINKJAJDDL, bool NEHCMPAMGCD = false);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T DBHNHBEAMME<T>(T GDCMHMHOFPL, Transform HNINKJAJDDL, bool NEHCMPAMGCD = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T DBHNHBEAMME<T>(GameObject GDCMHMHOFPL, Transform HNINKJAJDDL, bool NEHCMPAMGCD = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject DBHNHBEAMME(GameObject GDCMHMHOFPL, Transform HNINKJAJDDL, BAGDEAMBINE OLMBEJDJKAO, bool NEHCMPAMGCD);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T DBHNHBEAMME<T>(GameObject GDCMHMHOFPL, Transform HNINKJAJDDL, BAGDEAMBINE OLMBEJDJKAO, bool NEHCMPAMGCD) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T DBHNHBEAMME<T>(T GDCMHMHOFPL, Transform HNINKJAJDDL, BAGDEAMBINE OLMBEJDJKAO, bool NEHCMPAMGCD) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class KHEPPDMJPJO : IDisposable, HGMJFAPPLEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HashSet<Type> HLOJFIAMONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly HashSet<Type> CHCKLNLOPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Transform IDOCJMKCPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<Component> GOINOAPJPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> NBHIMGKAKMA;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4D07D30", Offset = "0x4D06D30", VA = "0x184D07D30")]
	[BFAJCGBKNMF]
	public static void PLMBNDNINPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4D07E90", Offset = "0x4D06E90", VA = "0x184D07E90")]
	[Preserve]
	public KHEPPDMJPJO([FPOHDCDDHBH(null)] FKANBGGIFEI NFFDLNMODOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4D074C0", Offset = "0x4D064C0", VA = "0x184D074C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4D075C0", Offset = "0x4D065C0", VA = "0x184D075C0", Slot = "5")]
	public void FECIPKFOPIF(params Type[] ACLMIOCMKEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4D07BC0", Offset = "0x4D06BC0", VA = "0x184D07BC0", Slot = "6")]
	public void LJNOFOJHDPD(params Type[] ACLMIOCMKEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4D073A0", Offset = "0x4D063A0", VA = "0x184D073A0", Slot = "7")]
	public GameObject DBHNHBEAMME(GameObject GDCMHMHOFPL, Transform HNINKJAJDDL, bool NEHCMPAMGCD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x19F5070", Offset = "0x19F4070", VA = "0x1819F5070", Slot = "8")]
	public T DBHNHBEAMME<T>(T GDCMHMHOFPL, Transform HNINKJAJDDL, bool NEHCMPAMGCD = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x19F51C0", Offset = "0x19F41C0", VA = "0x1819F51C0", Slot = "9")]
	public T DBHNHBEAMME<T>(GameObject GDCMHMHOFPL, Transform HNINKJAJDDL, bool NEHCMPAMGCD = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4D07430", Offset = "0x4D06430", VA = "0x184D07430", Slot = "10")]
	public GameObject DBHNHBEAMME(GameObject GDCMHMHOFPL, Transform HNINKJAJDDL, BAGDEAMBINE OLMBEJDJKAO, bool NEHCMPAMGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x19F50E0", Offset = "0x19F40E0", VA = "0x1819F50E0", Slot = "11")]
	public T DBHNHBEAMME<T>(GameObject GDCMHMHOFPL, Transform HNINKJAJDDL, BAGDEAMBINE OLMBEJDJKAO, bool NEHCMPAMGCD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x19F5130", Offset = "0x19F4130", VA = "0x1819F5130", Slot = "12")]
	public T DBHNHBEAMME<T>(T GDCMHMHOFPL, Transform HNINKJAJDDL, BAGDEAMBINE OLMBEJDJKAO, bool NEHCMPAMGCD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x19F4AB0", Offset = "0x19F3AB0", VA = "0x1819F4AB0")]
	private T DBHNHBEAMME<T>(GameObject GDCMHMHOFPL, Transform HNINKJAJDDL, BAGDEAMBINE OLMBEJDJKAO, bool NEHCMPAMGCD, out GameObject LEFEGNECOGN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x19F51F0", Offset = "0x19F41F0", VA = "0x1819F51F0")]
	private T JLODGKLLFDD<T>(GameObject NJCEGNEAEJH, BAGDEAMBINE OLMBEJDJKAO, bool NEHCMPAMGCD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4D07C10", Offset = "0x4D06C10", VA = "0x184D07C10")]
	private void NLEBADJJIAG(Component DHLJMKBEJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4D07750", Offset = "0x4D06750", VA = "0x184D07750")]
	private void KEHMJFACEMA(Component DHLJMKBEJFJ, BAGDEAMBINE OLMBEJDJKAO, bool NEHCMPAMGCD, [Optional] Type FIFNBNAIFGC, [Optional] Type PNIPOMCIECG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4D07610", Offset = "0x4D06610", VA = "0x184D07610")]
	private void GHDFOLKAJPI(GameObject NJCEGNEAEJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct BAGDEAMBINE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<Type, object> KPLLBANLFOJ;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x18C3340", Offset = "0x18C2340", VA = "0x1818C3340")]
	public BAGDEAMBINE GCLFAKHIAMJ<T>(T GLCBACNALCL)
	{
		return default(BAGDEAMBINE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x19E6BA0", Offset = "0x19E5BA0", VA = "0x1819E6BA0")]
	public T FLCFGOMKECP<T>(T IGDEECCNPFM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2092370", Offset = "0x2091370", VA = "0x182092370")]
	public bool KKACOOPIDFN<T>(out T GLCBACNALCL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct JMOPMPMKPJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public bool NHPLLJDHGHK;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x17449B0", Offset = "0x17439B0", VA = "0x1817449B0")]
	public JMOPMPMKPJB(bool IKOPBOHOPGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KJEJADBJOIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly bool PPEBFOEDKON;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4D081C0", Offset = "0x4D071C0", VA = "0x184D081C0")]
	public KJEJADBJOIL(bool LKJMANEIEME)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5BEEC0", Offset = "0x5BDEC0", VA = "0x1805BEEC0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ScaleInImposter : MonoBehaviour, PEAJKFNPBEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4D087F0", Offset = "0x4D077F0", VA = "0x184D087F0", Slot = "4")]
		public void PrepareImposter(BAGDEAMBINE OLMBEJDJKAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5BEEC0", Offset = "0x5BDEC0", VA = "0x1805BEEC0")]
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
				[Cpp2IlInjected.Address(RVA = "0x4D087D0", Offset = "0x4D077D0", VA = "0x184D087D0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x4D087C0", Offset = "0x4D077C0", VA = "0x184D087C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4D06FD0", Offset = "0x4D05FD0", VA = "0x184D06FD0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class BDAHOKDPDPN
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly List<URPLight> PNDIKCELDLN;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly Vector3 JCPBNONJHFB;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Vector3 NMAPFOAAPNI;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static Camera BPCNPEIPJAP;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public const string AGBNGCLIHLB = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public const PKOEPJCBKCO NOCKIAEMHED = PKOEPJCBKCO.Water;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly List<Renderer> CJKBIFHBCMM;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static AmbientMode OMCHOBBJEDP;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color HLJHBCABKGM;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static Color DGEOPHLBGOM;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static Color BDMCCPABPBK;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static Cubemap CCGCDCBBAKH;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static bool BIFCDBOBLKH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera NINBDEMHAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4D04E40", Offset = "0x4D03E40", VA = "0x184D04E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4D04880", Offset = "0x4D03880", VA = "0x184D04880")]
	public static void FCOBCOCCHNJ(Vector3 FLECPJLDHMO, Quaternion JNOGMHHKFDI, ImposterRenderConfig IHPIBEKPHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4D04B00", Offset = "0x4D03B00", VA = "0x184D04B00")]
	private static void GALAPEHOEPI(Vector3 FLECPJLDHMO, Quaternion JNOGMHHKFDI, URPLight MKGGONAMBFA, ImposterRenderConfig.LightConfig DJHFHFGNONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4D05D10", Offset = "0x4D04D10", VA = "0x184D05D10")]
	public static void PEBLCKPIFMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4D051D0", Offset = "0x4D041D0", VA = "0x184D051D0")]
	private static void IPJHOIKONBH(int EJLOPPJFDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4D054D0", Offset = "0x4D044D0", VA = "0x184D054D0")]
	public static void JLDDDKIMKCP(ImposterRenderConfig IHPIBEKPHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4D056F0", Offset = "0x4D046F0", VA = "0x184D056F0")]
	public static void OEDJBLMDPHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4D05040", Offset = "0x4D04040", VA = "0x184D05040")]
	public static void IBCEBMDCMCI(GameObject KANBGKOGKNF, RenderTexture AGNICJKNAMO, ImposterRenderConfig IHPIBEKPHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4D057F0", Offset = "0x4D047F0", VA = "0x184D057F0")]
	private static void PANHOHMBOOA(GameObject KANBGKOGKNF, RenderTexture AGNICJKNAMO, ImposterRenderConfig IHPIBEKPHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4D04460", Offset = "0x4D03460", VA = "0x184D04460")]
	private static void CMEMIBPLDOK(GameObject KANBGKOGKNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4D046F0", Offset = "0x4D036F0", VA = "0x184D046F0")]
	public static void DHKCONMIEHP(List<Renderer> IJLEPMKKDPC, List<Material> AAHINNNGONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4D05DF0", Offset = "0x4D04DF0", VA = "0x184D05DF0")]
	private static void PPLPEOKFCJJ(GameObject GDCMHMHOFPL, Vector3 IHHDKKPPGNO, Vector3 LKDEMNBGCCJ, float KGJGKAIKEBO, out Vector3 NEHLGBECOCN, out Quaternion GEPHHBAPMFE, out float LHPMLAEMMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4D05650", Offset = "0x4D04650", VA = "0x184D05650")]
	public static RenderTexture KNIOMDPAKLN(int GPPALIDPAOJ, int HBKDNCCDNCO)
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
		public struct KICLODJJHMI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public JLIHNEGNJFG FGAFOOLPPEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public GameObject DLGGLKHPDAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public RenderTexture AHCDBMJCALJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public ImposterRenderConfig EFKPDGCHJMM;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6FE080", Offset = "0x6FD080", VA = "0x1806FE080")]
			public KICLODJJHMI(JLIHNEGNJFG IGPEFPAFKHD, GameObject JGHMKNJMNIO, RenderTexture AGNICJKNAMO, ImposterRenderConfig MGCCFKMFEJP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const int BBLLNAONCHK = 1;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int EHFMOAICKIA = 6;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static global::LFCDHBKJMOA<KICLODJJHMI, RenderTexture> DPGGAGPCGDI;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static readonly List<KICLODJJHMI> HOJFIHGIJMA;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int FBAIFCDCPBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x641820", Offset = "0x640820", VA = "0x180641820")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4D068B0", Offset = "0x4D058B0", VA = "0x184D068B0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject KANBGKOGKNF, RenderTexture AGNICJKNAMO, ImposterRenderConfig IHPIBEKPHMJ, CancellationToken LFOGICEEHBE, bool PEDCFICAAKF = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4D063D0", Offset = "0x4D053D0", VA = "0x184D063D0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4D06820", Offset = "0x4D05820", VA = "0x184D06820", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4D064F0", Offset = "0x4D054F0", VA = "0x184D064F0")]
		private static Task<RenderTexture> IPLLIIHLEFC(KICLODJJHMI IDPACHNPMKL, CancellationToken LFOGICEEHBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4D06C90", Offset = "0x4D05C90", VA = "0x184D06C90")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class LCEEBCMBKCD
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static byte[] FOBLDOOIPBJ;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int MKBJJHBJLOC;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static int IFDBKDIOMPI;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static BigInteger GDKMPNMIOJK;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public LCEEBCMBKCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4D081D0", Offset = "0x4D071D0", VA = "0x184D081D0")]
	private static string AFJLFGLOHPO(byte[] FMMAACMCILJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4D082D0", Offset = "0x4D072D0", VA = "0x184D082D0")]
	public static string CAJPNALAKAJ(byte[] JNPIAJHKCKB, bool GKIDOBEBBAE)
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
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
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
