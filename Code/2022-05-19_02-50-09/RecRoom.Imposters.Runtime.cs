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
public class ImposterPreviewCustomFraming : MonoBehaviour, LNCNKNOKJJK
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float KKHLKNIBDJN = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "4")]
	public void PrepareImposter(IPDBLAJIMKC DOPNIABFHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4D5DC30", Offset = "0x4D5C830", VA = "0x184D5DC30")]
	public void SetReferencePoint(Vector3 KFFNJIGFMIM, Quaternion CJPHOLFLHND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4D5D990", Offset = "0x4D5C590", VA = "0x184D5D990")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4D5DBC0", Offset = "0x4D5C7C0", VA = "0x184D5DBC0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xDCCBA0", Offset = "0xDCB7A0", VA = "0x180DCCBA0")]
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
		[DPPCAMLCCHE(JNPNDJBCKEE.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const int MCDDENAIFFB = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int OHHBHMMKBBO = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly List<Material> ILDGIOCCBDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool PCOOIHMJKID;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4D5DDF0", Offset = "0x4D5C9F0", VA = "0x184D5DDF0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4D5DCF0", Offset = "0x4D5C8F0", VA = "0x184D5DCF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4D5DFD0", Offset = "0x4D5CBD0", VA = "0x184D5DFD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x54FA60", Offset = "0x54E660", VA = "0x18054FA60")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LNCNKNOKJJK
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(IPDBLAJIMKC DOPNIABFHCI);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface OKEDADLDNMB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> LCOENKJIMOG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> CNAEAFICKFF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EIOLKPJJJAB
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void COJIDIJKPKM(params Type[] EAHELHHFOIJ);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CDNAKDEBOAA(params Type[] EAHELHHFOIJ);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject PFLINBNGAOI(GameObject HKKCOGKDLEG, Transform IDFFNMDMLBG, bool NBAJEJAJMJL = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T PFLINBNGAOI<T>(T HKKCOGKDLEG, Transform IDFFNMDMLBG, bool NBAJEJAJMJL = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T PFLINBNGAOI<T>(GameObject HKKCOGKDLEG, Transform IDFFNMDMLBG, bool NBAJEJAJMJL = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject PFLINBNGAOI(GameObject HKKCOGKDLEG, Transform IDFFNMDMLBG, IPDBLAJIMKC DOPNIABFHCI, bool NBAJEJAJMJL);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T PFLINBNGAOI<T>(GameObject HKKCOGKDLEG, Transform IDFFNMDMLBG, IPDBLAJIMKC DOPNIABFHCI, bool NBAJEJAJMJL) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T PFLINBNGAOI<T>(T HKKCOGKDLEG, Transform IDFFNMDMLBG, IPDBLAJIMKC DOPNIABFHCI, bool NBAJEJAJMJL) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class ONPNNJJDCKH : IDisposable, EIOLKPJJJAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly HashSet<Type> NOLGLCDOIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HashSet<Type> CLBGCAEDJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Transform CECIHJNCHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly List<Component> GHNAEKOHPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> BIHFDHGEFGM;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4D5E8E0", Offset = "0x4D5D4E0", VA = "0x184D5E8E0")]
	[AOGEBGNMPFC]
	public static void MEBOICEBNOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4D5EB60", Offset = "0x4D5D760", VA = "0x184D5EB60")]
	[Preserve]
	public ONPNNJJDCKH([GMHCFMNHLPO(null)] OKEDADLDNMB FCEJJNIMDJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4D5E6C0", Offset = "0x4D5D2C0", VA = "0x184D5E6C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4D5E200", Offset = "0x4D5CE00", VA = "0x184D5E200", Slot = "5")]
	public void COJIDIJKPKM(params Type[] EAHELHHFOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4D5E1B0", Offset = "0x4D5CDB0", VA = "0x184D5E1B0", Slot = "6")]
	public void CDNAKDEBOAA(params Type[] EAHELHHFOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4D5EAD0", Offset = "0x4D5D6D0", VA = "0x184D5EAD0", Slot = "7")]
	public GameObject PFLINBNGAOI(GameObject HKKCOGKDLEG, Transform IDFFNMDMLBG, bool NBAJEJAJMJL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x28C63F0", Offset = "0x28C4FF0", VA = "0x1828C63F0", Slot = "8")]
	public T PFLINBNGAOI<T>(T HKKCOGKDLEG, Transform IDFFNMDMLBG, bool NBAJEJAJMJL = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x28C64B0", Offset = "0x28C50B0", VA = "0x1828C64B0", Slot = "9")]
	public T PFLINBNGAOI<T>(GameObject HKKCOGKDLEG, Transform IDFFNMDMLBG, bool NBAJEJAJMJL = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4D5EA40", Offset = "0x4D5D640", VA = "0x184D5EA40", Slot = "10")]
	public GameObject PFLINBNGAOI(GameObject HKKCOGKDLEG, Transform IDFFNMDMLBG, IPDBLAJIMKC DOPNIABFHCI, bool NBAJEJAJMJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x28C6460", Offset = "0x28C5060", VA = "0x1828C6460", Slot = "11")]
	public T PFLINBNGAOI<T>(GameObject HKKCOGKDLEG, Transform IDFFNMDMLBG, IPDBLAJIMKC DOPNIABFHCI, bool NBAJEJAJMJL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x28C6A20", Offset = "0x28C5620", VA = "0x1828C6A20", Slot = "12")]
	public T PFLINBNGAOI<T>(T HKKCOGKDLEG, Transform IDFFNMDMLBG, IPDBLAJIMKC DOPNIABFHCI, bool NBAJEJAJMJL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x28C64E0", Offset = "0x28C50E0", VA = "0x1828C64E0")]
	private T PFLINBNGAOI<T>(GameObject HKKCOGKDLEG, Transform IDFFNMDMLBG, IPDBLAJIMKC DOPNIABFHCI, bool NBAJEJAJMJL, out GameObject OKEAGFAJFEM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x28C5F40", Offset = "0x28C4B40", VA = "0x1828C5F40")]
	private T LPONJOKHFOM<T>(GameObject HMMABJMEBLO, IPDBLAJIMKC DOPNIABFHCI, bool NBAJEJAJMJL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4D5E7C0", Offset = "0x4D5D3C0", VA = "0x184D5E7C0")]
	private void HECEKGOOPFP(Component FCANJIFOAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4D5E250", Offset = "0x4D5CE50", VA = "0x184D5E250")]
	private void DECGLCNKKGA(Component FCANJIFOAJB, IPDBLAJIMKC DOPNIABFHCI, bool NBAJEJAJMJL, [Optional] Type CFHGBIOBFKF, [Optional] Type JNNKFLPINFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4D5E070", Offset = "0x4D5CC70", VA = "0x184D5E070")]
	private void BDOMFPEMACH(GameObject HMMABJMEBLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct IPDBLAJIMKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Dictionary<Type, object> LCBNIMGMFCD;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2767A20", Offset = "0x2766620", VA = "0x182767A20")]
	public IPDBLAJIMKC MLPJBGOCDOH<T>(T BMMKEAHNPAG)
	{
		return default(IPDBLAJIMKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2C15F20", Offset = "0x2C14B20", VA = "0x182C15F20")]
	public T JFMNFJDNJKA<T>(T OLPENHCKIHM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3764CA0", Offset = "0x37638A0", VA = "0x183764CA0")]
	public bool ACFEEFLJJHO<T>(out T BMMKEAHNPAG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct LOACIDLKOKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public bool PICLBCJICEB;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE60", Offset = "0x8AAA60", VA = "0x1808ABE60")]
	public LOACIDLKOKG(bool DFAEHIHMPFN)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CreateAssetMenu]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			[Header("Shadows")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0x4D5E050", Offset = "0x4D5CC50", VA = "0x184D5E050")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x4D5E040", Offset = "0x4D5CC40", VA = "0x184D5E040")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4D5DC70", Offset = "0x4D5C870", VA = "0x184D5DC70")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class HJPMNNCCDDP
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly List<URPLight> JNCMFEKLAEB;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly Vector3 DODHDAEJIBA;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly Vector3 GGCICFAOAGP;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Camera GPOOFHNKNFN;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const string CDACGBODNIO = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public const OFIOPPECEDK FMIOLMFGFKD = OFIOPPECEDK.Water;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<Renderer> MDJJDKFLJOJ;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static AmbientMode EOKLIGLPGPP;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static Color BBIGMMOGMPL;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static Color KBCOEHBCIAH;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color GHPBJCMGGBN;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Cubemap LIMLLNDKMDJ;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static bool JADINEKEPHC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera LFOGJFCHABN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4D5C170", Offset = "0x4D5AD70", VA = "0x184D5C170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4D5C370", Offset = "0x4D5AF70", VA = "0x184D5C370")]
	public static void FIDAHEIPLFA(Vector3 MKPIKHIPKHE, Quaternion ICKOOGBJEHL, ImposterRenderConfig KLBPACBDEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4D5BD30", Offset = "0x4D5A930", VA = "0x184D5BD30")]
	private static void DGIHBMDLNCL(Vector3 MKPIKHIPKHE, Quaternion ICKOOGBJEHL, URPLight IDLFLMIONJK, ImposterRenderConfig.LightConfig AHPNFLFFHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4D5D6C0", Offset = "0x4D5C2C0", VA = "0x184D5D6C0")]
	public static void LOPMBEHENDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4D5CFA0", Offset = "0x4D5BBA0", VA = "0x184D5CFA0")]
	private static void JFOABGOJHIN(int BMNDNKOADFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4D5CE20", Offset = "0x4D5BA20", VA = "0x184D5CE20")]
	public static void HCKGGLMGBHC(ImposterRenderConfig KLBPACBDEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4D5C070", Offset = "0x4D5AC70", VA = "0x184D5C070")]
	public static void DIPKGMHFNPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4D5BBA0", Offset = "0x4D5A7A0", VA = "0x184D5BBA0")]
	public static void AKHDDEIOOFJ(GameObject OFOHGIGPJNM, RenderTexture OELHFLGPLLF, ImposterRenderConfig KLBPACBDEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4D5C900", Offset = "0x4D5B500", VA = "0x184D5C900")]
	private static void GEDLENMHFLN(GameObject OFOHGIGPJNM, RenderTexture OELHFLGPLLF, ImposterRenderConfig KLBPACBDEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4D5D2A0", Offset = "0x4D5BEA0", VA = "0x184D5D2A0")]
	private static void KIIEICCCPMD(GameObject OFOHGIGPJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4D5D530", Offset = "0x4D5C130", VA = "0x184D5D530")]
	public static void KNNMLJIOAIE(List<Renderer> CMFNBCPONFE, List<Material> DEDJIHIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4D5C5F0", Offset = "0x4D5B1F0", VA = "0x184D5C5F0")]
	private static void GADJAIPEABO(GameObject HKKCOGKDLEG, Vector3 JLBHNPKBHIP, Vector3 BNIDLHPECBG, float KBAPFIFBIKE, out Vector3 BLLPMBKDCCI, out Quaternion LLBOEKFLAFE, out float FHAJGNLHKND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4D5D7A0", Offset = "0x4D5C3A0", VA = "0x184D5D7A0")]
	public static RenderTexture OPNIAIKJPGB(int LOAJHEIDPPI, int KBNEJJFCEEJ)
	{
		return null;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct AKFPFFLNKNP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public MCMONDMICNG KNCNJHMLOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public GameObject NJJDLJCDHEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public RenderTexture KBKDBBFKOEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public ImposterRenderConfig NBJELJAOMFE;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x1C8FC40", Offset = "0x1C8E840", VA = "0x181C8FC40")]
			public AKFPFFLNKNP(MCMONDMICNG BBGFFDMJNNM, GameObject IIEGGMMIPFN, RenderTexture OELHFLGPLLF, ImposterRenderConfig PKDKKIOHNME)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const int EHPDDLPAKMH = 1;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private const int NCGGPPIJNOD = 6;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static global::ICOLBGBEOCD<AKFPFFLNKNP, RenderTexture> KNEMONPCMPC;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly List<AKFPFFLNKNP> IDANFOPBAJM;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int BPPEIDEFNKI
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7DCAB0", Offset = "0x7DB6B0", VA = "0x1807DCAB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4D5B760", Offset = "0x4D5A360", VA = "0x184D5B760")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject OFOHGIGPJNM, RenderTexture OELHFLGPLLF, ImposterRenderConfig KLBPACBDEDC, CancellationToken DDPNAGPNMPM, bool PCFFNBIDANI = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4D5B280", Offset = "0x4D59E80", VA = "0x184D5B280", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4D5B6D0", Offset = "0x4D5A2D0", VA = "0x184D5B6D0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4D5B3A0", Offset = "0x4D59FA0", VA = "0x184D5B3A0")]
		private static Task<RenderTexture> LLKBAHFMMEE(AKFPFFLNKNP HGPGEDEADNA, CancellationToken DDPNAGPNMPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4D5BB40", Offset = "0x4D5A740", VA = "0x184D5BB40")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DFHLNHOECAE
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static byte[] BPCJOEHDNHL;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static int JGOMGPKCOBP;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static int EJPBFKNOMCK;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static BigInteger DKHAKAEJLPK;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public DFHLNHOECAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4D5AC90", Offset = "0x4D59890", VA = "0x184D5AC90")]
	private static string ALAJABKKJNA(byte[] JCHDICMDCKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4D5AD90", Offset = "0x4D59990", VA = "0x184D5AD90")]
	public static string NBAPPGOEMPA(byte[] GLAICJAMEED, bool NFOOKAPIMMN)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
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
