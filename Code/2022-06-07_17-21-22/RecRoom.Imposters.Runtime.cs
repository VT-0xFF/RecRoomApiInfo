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
	[Cpp2IlInjected.Address(RVA = "0x561E80", Offset = "0x560680", VA = "0x180561E80", Slot = "4")]
	public void PrepareImposter(BAGDEAMBINE OLMBEJDJKAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4EA0350", Offset = "0x4E9EB50", VA = "0x184EA0350")]
	public void SetReferencePoint(Vector3 HNJDIOBFDFH, Quaternion INBPMOJHGEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4EA00B0", Offset = "0x4E9E8B0", VA = "0x184EA00B0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4EA02E0", Offset = "0x4E9EAE0", VA = "0x184EA02E0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xCC5F30", Offset = "0xCC4730", VA = "0x180CC5F30")]
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
		[Cpp2IlInjected.Address(RVA = "0x4EA0510", Offset = "0x4E9ED10", VA = "0x184EA0510")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4EA0410", Offset = "0x4E9EC10", VA = "0x184EA0410")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4EA06F0", Offset = "0x4E9EEF0", VA = "0x184EA06F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E9F610", Offset = "0x4E9DE10", VA = "0x184E9F610", Slot = "4")]
		public void PrepareImposter(BAGDEAMBINE OLMBEJDJKAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC71680", Offset = "0xC6FE80", VA = "0x180C71680")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC71680", Offset = "0xC6FE80", VA = "0x180C71680")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EA10F0", Offset = "0x4E9F8F0", VA = "0x184EA10F0")]
	[BFAJCGBKNMF]
	public static void PLMBNDNINPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1250", Offset = "0x4E9FA50", VA = "0x184EA1250")]
	[Preserve]
	public KHEPPDMJPJO([FPOHDCDDHBH(null)] FKANBGGIFEI NFFDLNMODOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4EA0880", Offset = "0x4E9F080", VA = "0x184EA0880", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4EA0980", Offset = "0x4E9F180", VA = "0x184EA0980", Slot = "5")]
	public void FECIPKFOPIF(params Type[] ACLMIOCMKEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4EA0F80", Offset = "0x4E9F780", VA = "0x184EA0F80", Slot = "6")]
	public void LJNOFOJHDPD(params Type[] ACLMIOCMKEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4EA0760", Offset = "0x4E9EF60", VA = "0x184EA0760", Slot = "7")]
	public GameObject DBHNHBEAMME(GameObject GDCMHMHOFPL, Transform HNINKJAJDDL, bool NEHCMPAMGCD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x21E45D0", Offset = "0x21E2DD0", VA = "0x1821E45D0", Slot = "8")]
	public T DBHNHBEAMME<T>(T GDCMHMHOFPL, Transform HNINKJAJDDL, bool NEHCMPAMGCD = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x21E4720", Offset = "0x21E2F20", VA = "0x1821E4720", Slot = "9")]
	public T DBHNHBEAMME<T>(GameObject GDCMHMHOFPL, Transform HNINKJAJDDL, bool NEHCMPAMGCD = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4EA07F0", Offset = "0x4E9EFF0", VA = "0x184EA07F0", Slot = "10")]
	public GameObject DBHNHBEAMME(GameObject GDCMHMHOFPL, Transform HNINKJAJDDL, BAGDEAMBINE OLMBEJDJKAO, bool NEHCMPAMGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x21E4640", Offset = "0x21E2E40", VA = "0x1821E4640", Slot = "11")]
	public T DBHNHBEAMME<T>(GameObject GDCMHMHOFPL, Transform HNINKJAJDDL, BAGDEAMBINE OLMBEJDJKAO, bool NEHCMPAMGCD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x21E4690", Offset = "0x21E2E90", VA = "0x1821E4690", Slot = "12")]
	public T DBHNHBEAMME<T>(T GDCMHMHOFPL, Transform HNINKJAJDDL, BAGDEAMBINE OLMBEJDJKAO, bool NEHCMPAMGCD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x21E4010", Offset = "0x21E2810", VA = "0x1821E4010")]
	private T DBHNHBEAMME<T>(GameObject GDCMHMHOFPL, Transform HNINKJAJDDL, BAGDEAMBINE OLMBEJDJKAO, bool NEHCMPAMGCD, out GameObject LEFEGNECOGN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x21E4750", Offset = "0x21E2F50", VA = "0x1821E4750")]
	private T JLODGKLLFDD<T>(GameObject NJCEGNEAEJH, BAGDEAMBINE OLMBEJDJKAO, bool NEHCMPAMGCD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4EA0FD0", Offset = "0x4E9F7D0", VA = "0x184EA0FD0")]
	private void NLEBADJJIAG(Component DHLJMKBEJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4EA0B10", Offset = "0x4E9F310", VA = "0x184EA0B10")]
	private void KEHMJFACEMA(Component DHLJMKBEJFJ, BAGDEAMBINE OLMBEJDJKAO, bool NEHCMPAMGCD, [Optional] Type FIFNBNAIFGC, [Optional] Type PNIPOMCIECG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4EA09D0", Offset = "0x4E9F1D0", VA = "0x184EA09D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FB6470", Offset = "0x1FB4C70", VA = "0x181FB6470")]
	public BAGDEAMBINE GCLFAKHIAMJ<T>(T GLCBACNALCL)
	{
		return default(BAGDEAMBINE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x21D5A50", Offset = "0x21D4250", VA = "0x1821D5A50")]
	public T FLCFGOMKECP<T>(T IGDEECCNPFM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x23E8860", Offset = "0x23E7060", VA = "0x1823E8860")]
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
	[Cpp2IlInjected.Address(RVA = "0xC54210", Offset = "0xC52A10", VA = "0x180C54210")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EA1580", Offset = "0x4E9FD80", VA = "0x184EA1580")]
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
		[Cpp2IlInjected.Address(RVA = "0xC71680", Offset = "0xC6FE80", VA = "0x180C71680")]
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
		[Cpp2IlInjected.Address(RVA = "0x4EA1BB0", Offset = "0x4EA03B0", VA = "0x184EA1BB0", Slot = "4")]
		public void PrepareImposter(BAGDEAMBINE OLMBEJDJKAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xC71680", Offset = "0xC6FE80", VA = "0x180C71680")]
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
				[Cpp2IlInjected.Address(RVA = "0x4EA1B90", Offset = "0x4EA0390", VA = "0x184EA1B90")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x4EA1B80", Offset = "0x4EA0380", VA = "0x184EA1B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x4EA0390", Offset = "0x4E9EB90", VA = "0x184EA0390")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E9E200", Offset = "0x4E9CA00", VA = "0x184E9E200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4E9DC40", Offset = "0x4E9C440", VA = "0x184E9DC40")]
	public static void FCOBCOCCHNJ(Vector3 FLECPJLDHMO, Quaternion JNOGMHHKFDI, ImposterRenderConfig IHPIBEKPHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4E9DEC0", Offset = "0x4E9C6C0", VA = "0x184E9DEC0")]
	private static void GALAPEHOEPI(Vector3 FLECPJLDHMO, Quaternion JNOGMHHKFDI, URPLight MKGGONAMBFA, ImposterRenderConfig.LightConfig DJHFHFGNONB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4E9F0D0", Offset = "0x4E9D8D0", VA = "0x184E9F0D0")]
	public static void PEBLCKPIFMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4E9E590", Offset = "0x4E9CD90", VA = "0x184E9E590")]
	private static void IPJHOIKONBH(int EJLOPPJFDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4E9E890", Offset = "0x4E9D090", VA = "0x184E9E890")]
	public static void JLDDDKIMKCP(ImposterRenderConfig IHPIBEKPHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4E9EAB0", Offset = "0x4E9D2B0", VA = "0x184E9EAB0")]
	public static void OEDJBLMDPHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4E9E400", Offset = "0x4E9CC00", VA = "0x184E9E400")]
	public static void IBCEBMDCMCI(GameObject KANBGKOGKNF, RenderTexture AGNICJKNAMO, ImposterRenderConfig IHPIBEKPHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4E9EBB0", Offset = "0x4E9D3B0", VA = "0x184E9EBB0")]
	private static void PANHOHMBOOA(GameObject KANBGKOGKNF, RenderTexture AGNICJKNAMO, ImposterRenderConfig IHPIBEKPHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D820", Offset = "0x4E9C020", VA = "0x184E9D820")]
	private static void CMEMIBPLDOK(GameObject KANBGKOGKNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4E9DAB0", Offset = "0x4E9C2B0", VA = "0x184E9DAB0")]
	public static void DHKCONMIEHP(List<Renderer> IJLEPMKKDPC, List<Material> AAHINNNGONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4E9F1B0", Offset = "0x4E9D9B0", VA = "0x184E9F1B0")]
	private static void PPLPEOKFCJJ(GameObject GDCMHMHOFPL, Vector3 IHHDKKPPGNO, Vector3 LKDEMNBGCCJ, float KGJGKAIKEBO, out Vector3 NEHLGBECOCN, out Quaternion GEPHHBAPMFE, out float LHPMLAEMMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4E9EA10", Offset = "0x4E9D210", VA = "0x184E9EA10")]
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
			[Cpp2IlInjected.Address(RVA = "0x3BC6720", Offset = "0x3BC4F20", VA = "0x183BC6720")]
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
			[Cpp2IlInjected.Address(RVA = "0x8253C0", Offset = "0x823BC0", VA = "0x1808253C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4E9FC70", Offset = "0x4E9E470", VA = "0x184E9FC70")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject KANBGKOGKNF, RenderTexture AGNICJKNAMO, ImposterRenderConfig IHPIBEKPHMJ, CancellationToken LFOGICEEHBE, bool PEDCFICAAKF = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4E9F790", Offset = "0x4E9DF90", VA = "0x184E9F790", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4E9FBE0", Offset = "0x4E9E3E0", VA = "0x184E9FBE0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4E9F8B0", Offset = "0x4E9E0B0", VA = "0x184E9F8B0")]
		private static Task<RenderTexture> IPLLIIHLEFC(KICLODJJHMI IDPACHNPMKL, CancellationToken LFOGICEEHBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4EA0050", Offset = "0x4E9E850", VA = "0x184EA0050")]
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
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	public LCEEBCMBKCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1590", Offset = "0x4E9FD90", VA = "0x184EA1590")]
	private static string AFJLFGLOHPO(byte[] FMMAACMCILJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1690", Offset = "0x4E9FE90", VA = "0x184EA1690")]
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
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
