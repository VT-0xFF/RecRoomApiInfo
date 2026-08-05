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
public class ImposterPreviewCustomFraming : MonoBehaviour, GMJDICEKHMG
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float AINPNJKCPLK = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "4")]
	public void PrepareImposter(FEPKHCOAHIE FPLMCNNAFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6031140", Offset = "0x602FD40", VA = "0x186031140")]
	public void SetReferencePoint(Vector3 LHHJFJDBODB, Quaternion EOGJNLADAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6030FB0", Offset = "0x602FBB0", VA = "0x186030FB0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6031110", Offset = "0x602FD10", VA = "0x186031110")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1331340", Offset = "0x132FF40", VA = "0x181331340")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct LHBCBIBBEGM
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static LHBCBIBBEGM FIKHIKEGGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public float NLCFGIFMPDP;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6B2930", Offset = "0x6B1530", VA = "0x1806B2930")]
	public LHBCBIBBEGM(float CCOCCCCDBEP)
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
		[MBKFNACBIPJ(GHABDIHKABP.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const int AIAHOOBAFJH = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const int PJCKHGDADLH = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly List<Material> GAKMFNELLLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool FHFHEFAPOHE;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x60312B0", Offset = "0x602FEB0", VA = "0x1860312B0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x60311C0", Offset = "0x602FDC0", VA = "0x1860311C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x60314F0", Offset = "0x60300F0", VA = "0x1860314F0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class CenterInImposter : MonoBehaviour, GMJDICEKHMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x602D420", Offset = "0x602C020", VA = "0x18602D420", Slot = "4")]
		public void PrepareImposter(FEPKHCOAHIE FPLMCNNAFEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x698110", Offset = "0x696D10", VA = "0x180698110")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x698110", Offset = "0x696D10", VA = "0x180698110")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GMJDICEKHMG
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(FEPKHCOAHIE FPLMCNNAFEE);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface LJIGBENJLPN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> NDCOHLLDFDM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> JLNMAEPADIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DHKJBDNDBMO
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNGLOLDPAOF(params Type[] HAAPMPEHPPA);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KPBGHMPLJFI(params Type[] HAAPMPEHPPA);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject HBGEFLOJALI(GameObject HLABNIGHLFE, Transform NIGFDFKEKGM, bool PPKAKFEPJOH = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T HBGEFLOJALI<T>(T HLABNIGHLFE, Transform NIGFDFKEKGM, bool PPKAKFEPJOH = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T HBGEFLOJALI<T>(GameObject HLABNIGHLFE, Transform NIGFDFKEKGM, bool PPKAKFEPJOH = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject HBGEFLOJALI(GameObject HLABNIGHLFE, Transform NIGFDFKEKGM, FEPKHCOAHIE FPLMCNNAFEE, bool PPKAKFEPJOH);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T HBGEFLOJALI<T>(GameObject HLABNIGHLFE, Transform NIGFDFKEKGM, FEPKHCOAHIE FPLMCNNAFEE, bool PPKAKFEPJOH) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T HBGEFLOJALI<T>(T HLABNIGHLFE, Transform NIGFDFKEKGM, FEPKHCOAHIE FPLMCNNAFEE, bool PPKAKFEPJOH) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FJGANKBLNPH : IDisposable, DHKJBDNDBMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly HashSet<Type> FAMAALJGOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly HashSet<Type> LONNGKOBBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Transform GGEDIEDMJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly List<Component> GKFOMMHICFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> CHHPKIDDKBA;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x602DEC0", Offset = "0x602CAC0", VA = "0x18602DEC0")]
	[JGJJPBKAAKL(HKPPGBCDEPD.None)]
	public static void AKPBJPOJHGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x602EA60", Offset = "0x602D660", VA = "0x18602EA60")]
	[Preserve]
	public FJGANKBLNPH([MLOIHELMKFH(null)] LJIGBENJLPN ADNGNMHJDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x602E510", Offset = "0x602D110", VA = "0x18602E510", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x602E9C0", Offset = "0x602D5C0", VA = "0x18602E9C0", Slot = "5")]
	public void JNGLOLDPAOF(params Type[] HAAPMPEHPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x602EA10", Offset = "0x602D610", VA = "0x18602EA10", Slot = "6")]
	public void KPBGHMPLJFI(params Type[] HAAPMPEHPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x602E610", Offset = "0x602D210", VA = "0x18602E610", Slot = "7")]
	public GameObject HBGEFLOJALI(GameObject HLABNIGHLFE, Transform NIGFDFKEKGM, bool PPKAKFEPJOH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2B5F490", Offset = "0x2B5E090", VA = "0x182B5F490", Slot = "8")]
	public T HBGEFLOJALI<T>(T HLABNIGHLFE, Transform NIGFDFKEKGM, bool PPKAKFEPJOH = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2B5F500", Offset = "0x2B5E100", VA = "0x182B5F500", Slot = "9")]
	public T HBGEFLOJALI<T>(GameObject HLABNIGHLFE, Transform NIGFDFKEKGM, bool PPKAKFEPJOH = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x602E6A0", Offset = "0x602D2A0", VA = "0x18602E6A0", Slot = "10")]
	public GameObject HBGEFLOJALI(GameObject HLABNIGHLFE, Transform NIGFDFKEKGM, FEPKHCOAHIE FPLMCNNAFEE, bool PPKAKFEPJOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2B5F440", Offset = "0x2B5E040", VA = "0x182B5F440", Slot = "11")]
	public T HBGEFLOJALI<T>(GameObject HLABNIGHLFE, Transform NIGFDFKEKGM, FEPKHCOAHIE FPLMCNNAFEE, bool PPKAKFEPJOH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2B5F530", Offset = "0x2B5E130", VA = "0x182B5F530", Slot = "12")]
	public T HBGEFLOJALI<T>(T HLABNIGHLFE, Transform NIGFDFKEKGM, FEPKHCOAHIE FPLMCNNAFEE, bool PPKAKFEPJOH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2B5F5C0", Offset = "0x2B5E1C0", VA = "0x182B5F5C0")]
	private T HBGEFLOJALI<T>(GameObject HLABNIGHLFE, Transform NIGFDFKEKGM, FEPKHCOAHIE FPLMCNNAFEE, bool PPKAKFEPJOH, out GameObject IBDIFDGEJLI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2B5EEE0", Offset = "0x2B5DAE0", VA = "0x182B5EEE0")]
	private T CFCAPKJFLLC<T>(GameObject OKGHLJEDAEA, FEPKHCOAHIE FPLMCNNAFEE, bool PPKAKFEPJOH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x602E730", Offset = "0x602D330", VA = "0x18602E730")]
	private void IDJKIBHIPMK(Component CNBPNBOALAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x602DFC0", Offset = "0x602CBC0", VA = "0x18602DFC0")]
	private void DPOLGDIFDJO(Component CNBPNBOALAL, FEPKHCOAHIE FPLMCNNAFEE, bool PPKAKFEPJOH, bool EBOGIMAELOH, [Optional] Type NAODIPGIICH, [Optional] Type EFENNEBCFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x602E860", Offset = "0x602D460", VA = "0x18602E860")]
	private void IFMGGPHDDKO(GameObject OKGHLJEDAEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct FEPKHCOAHIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Dictionary<Type, object> PCPFKAJIGKB;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2B5D080", Offset = "0x2B5BC80", VA = "0x182B5D080")]
	public FEPKHCOAHIE CKBKODEFPCJ<T>(T IHJLHGLAGGE)
	{
		return default(FEPKHCOAHIE);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2B5D7B0", Offset = "0x2B5C3B0", VA = "0x182B5D7B0")]
	public T FABELHKIKFB<T>(T DOOMMHJABHL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2B5D8D0", Offset = "0x2B5C4D0", VA = "0x182B5D8D0")]
	public bool JIJNIMCPPHN<T>(out T IHJLHGLAGGE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct HIFFPCLJCAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public bool GLAOECHDHHL;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x85ADB0", Offset = "0x8599B0", VA = "0x18085ADB0")]
	public HIFFPCLJCAL(bool BLPILNOHHGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct MHDGNAJHJLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly bool HPJFIAHDCEM;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6031C10", Offset = "0x6030810", VA = "0x186031C10")]
	public MHDGNAJHJLK(bool KJBKOBMANAI)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x698110", Offset = "0x696D10", VA = "0x180698110")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ScaleInImposter : MonoBehaviour, GMJDICEKHMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6031C20", Offset = "0x6030820", VA = "0x186031C20", Slot = "4")]
		public void PrepareImposter(FEPKHCOAHIE FPLMCNNAFEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x698110", Offset = "0x696D10", VA = "0x180698110")]
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
				[Cpp2IlInjected.Address(RVA = "0x6031BF0", Offset = "0x60307F0", VA = "0x186031BF0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6031BE0", Offset = "0x60307E0", VA = "0x186031BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6031180", Offset = "0x602FD80", VA = "0x186031180")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class GGABBNJGODP
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<URPLight> NLKALGBPJFA;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly Vector3 IACOGHMIJJC;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly Vector3 ENPDGOKKBPP;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static Camera IGGDLMHKDFO;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public const string ALCJILLJBLE = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public const MGKMCJJLCLF OBGAMFBANDF = MGKMCJJLCLF.Water;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static readonly List<Renderer> FDNIFBKCGNA;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static AmbientMode MOBOJFHJPIM;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static Color PGOKNOCFKIN;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static Color INFBCKJHBEJ;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static Color HAKBGDLDHOJ;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static Cubemap BNPBKMAGPAB;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static bool MGIPACKKDON;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera FAGIIFHAILG
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x602F7A0", Offset = "0x602E3A0", VA = "0x18602F7A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x602EEA0", Offset = "0x602DAA0", VA = "0x18602EEA0")]
	public static void AAFCEFEOFIB(Vector3 NKGAOHNMBID, Quaternion JPFPNOEPNLD, ImposterRenderConfig EGIDBEEGKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6030180", Offset = "0x602ED80", VA = "0x186030180")]
	private static void LMCFFFPCCCI(Vector3 NKGAOHNMBID, Quaternion JPFPNOEPNLD, URPLight KKOJMKNMJOA, ImposterRenderConfig.LightConfig NGDANKCKBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6030C70", Offset = "0x602F870", VA = "0x186030C70")]
	public static void PCMPINJOJCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x60306D0", Offset = "0x602F2D0", VA = "0x1860306D0")]
	private static void MMIPILJCHGO(int BDJFNONPPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x602F620", Offset = "0x602E220", VA = "0x18602F620")]
	public static void BBJMOOPLHLA(ImposterRenderConfig EGIDBEEGKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6030D60", Offset = "0x602F960", VA = "0x186030D60")]
	public static void PKGDNLBAFOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6030AA0", Offset = "0x602F6A0", VA = "0x186030AA0")]
	public static void OLENLAONOAO(GameObject HIGOGGOKIFF, RenderTexture HCMEPCIHKGF, ImposterRenderConfig EGIDBEEGKJM, LHBCBIBBEGM FOHANHOFHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x602F120", Offset = "0x602DD20", VA = "0x18602F120")]
	private static void ADNKMOFKDHB(GameObject HIGOGGOKIFF, RenderTexture HCMEPCIHKGF, ImposterRenderConfig EGIDBEEGKJM, LHBCBIBBEGM FOHANHOFHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x602F9D0", Offset = "0x602E5D0", VA = "0x18602F9D0")]
	private static void CFLPNPCNGDD(GameObject HIGOGGOKIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6030530", Offset = "0x602F130", VA = "0x186030530")]
	public static void MGBLCKLEKBL(List<Renderer> JBIBLGNECDB, List<Material> OICNGAAGKII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x602FEB0", Offset = "0x602EAB0", VA = "0x18602FEB0")]
	public static void JEHAGNLIGDK(GameObject HLABNIGHLFE, Vector3 DOGPNKEHMMJ, Vector3 ILMIOFILPFC, float FHCCNFEJHMA, LHBCBIBBEGM FOHANHOFHFK, out Vector3 FHPBLIIAMPC, out Quaternion CDHEHIMELFO, out float MGGOBFBBGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6030490", Offset = "0x602F090", VA = "0x186030490")]
	public static RenderTexture MBAEBCBLHMH(int EFDIFNHGBMG, int KEJDIAAOACK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x602FC80", Offset = "0x602E880", VA = "0x18602FC80")]
	public static void GPFJPPENHCI()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public struct CNMHFJFGOPM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public OBDOOKDFCDE HLIOBLIGJGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public GameObject IGAGMAGNLKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public RenderTexture OCBHCDHGEFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public ImposterRenderConfig OPBPJHHIKGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public LHBCBIBBEGM LHBCBIBBEGM;

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x602D3B0", Offset = "0x602BFB0", VA = "0x18602D3B0")]
			public CNMHFJFGOPM(OBDOOKDFCDE HJIKPPAKAGC, GameObject ODGFFJNBEJB, RenderTexture HCMEPCIHKGF, ImposterRenderConfig BDLGGEAOLIK, LHBCBIBBEGM FOHANHOFHFK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int LNPOMJLMCMJ = 1;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int IMMICCAAOPA = 6;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static global::PMGJDHMIOHC<CNMHFJFGOPM, RenderTexture> ADAEEBCECKO;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static readonly List<CNMHFJFGOPM> MAOLEGOKAOJ;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int NLFHBAKNDOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA92340", Offset = "0xA90F40", VA = "0x180A92340")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x602D980", Offset = "0x602C580", VA = "0x18602D980")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject HIGOGGOKIFF, RenderTexture HCMEPCIHKGF, ImposterRenderConfig EGIDBEEGKJM, LHBCBIBBEGM FOHANHOFHFK, CancellationToken OKPCBPJCBCJ, bool GGPOFEJCAGM = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x602D580", Offset = "0x602C180", VA = "0x18602D580", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x602D8E0", Offset = "0x602C4E0", VA = "0x18602D8E0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x602D710", Offset = "0x602C310", VA = "0x18602D710")]
		private static Task<RenderTexture> LDNJOCCKMEP(CNMHFJFGOPM MOFCFDMCFPN, CancellationToken OKPCBPJCBCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x602DE50", Offset = "0x602CA50", VA = "0x18602DE50")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JKMMEKILHLE
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static byte[] AGGHFJMNIJN;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static int BFFGPOMCPJB;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static int MBPNPBCPPJJ;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static BigInteger ELICCIFCIHI;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public JKMMEKILHLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6031570", Offset = "0x6030170", VA = "0x186031570")]
	private static string HIPMGELGEMF(byte[] APLKEMLCGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6031680", Offset = "0x6030280", VA = "0x186031680")]
	public static string OIADEFGOGFH(byte[] FCLGIGIIKEH, bool ABEBLNADKAB)
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
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
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
