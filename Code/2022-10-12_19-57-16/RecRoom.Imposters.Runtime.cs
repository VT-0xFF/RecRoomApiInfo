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
public class ImposterPreviewCustomFraming : MonoBehaviour, GFGAFDNCAEH
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float OLNPBNPKILN = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "4")]
	public void PrepareImposter(FHNIIPGPJHO EPEIMBEMAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4730", Offset = "0x5DB3730", VA = "0x185DB4730")]
	public void SetReferencePoint(Vector3 BIFOHEGELJH, Quaternion LLCDBICBDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5DB45A0", Offset = "0x5DB35A0", VA = "0x185DB45A0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4700", Offset = "0x5DB3700", VA = "0x185DB4700")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1670140", Offset = "0x166F140", VA = "0x181670140")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct NPIPIFPNOEI
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static NPIPIFPNOEI OPLHEBLPEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public float JEPJNBLCHEJ;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x27D65E0", Offset = "0x27D55E0", VA = "0x1827D65E0")]
	public NPIPIFPNOEI(float BJNMGHFMFDC)
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
		[HOEJGCAGKOC(APAJCDGALOH.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const int BCKCHJOCOKD = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const int KGAGCHMFIPF = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly List<Material> MJHICKLKNFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool IMMHEFEFANF;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5DB48A0", Offset = "0x5DB38A0", VA = "0x185DB48A0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5DB47B0", Offset = "0x5DB37B0", VA = "0x185DB47B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4AE0", Offset = "0x5DB3AE0", VA = "0x185DB4AE0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class CenterInImposter : MonoBehaviour, GFGAFDNCAEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0A80", Offset = "0x5DAFA80", VA = "0x185DB0A80", Slot = "4")]
		public void PrepareImposter(FHNIIPGPJHO EPEIMBEMAJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GFGAFDNCAEH
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(FHNIIPGPJHO EPEIMBEMAJE);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface HPGGALHKNMC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> FMNEAKEHCDO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> CMKDADNGDHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CIIDKCOCKKC
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void APCPEMJLBCA(params Type[] CEJOIBBGIME);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BDCEEFCHPMB(params Type[] CEJOIBBGIME);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject BLLBOFBIELJ(GameObject LGELJKPCDJN, Transform OJKLIAPCMPJ, bool AELBGMCLNLE = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T BLLBOFBIELJ<T>(T LGELJKPCDJN, Transform OJKLIAPCMPJ, bool AELBGMCLNLE = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T BLLBOFBIELJ<T>(GameObject LGELJKPCDJN, Transform OJKLIAPCMPJ, bool AELBGMCLNLE = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject BLLBOFBIELJ(GameObject LGELJKPCDJN, Transform OJKLIAPCMPJ, FHNIIPGPJHO EPEIMBEMAJE, bool AELBGMCLNLE);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T BLLBOFBIELJ<T>(GameObject LGELJKPCDJN, Transform OJKLIAPCMPJ, FHNIIPGPJHO EPEIMBEMAJE, bool AELBGMCLNLE) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T BLLBOFBIELJ<T>(T LGELJKPCDJN, Transform OJKLIAPCMPJ, FHNIIPGPJHO EPEIMBEMAJE, bool AELBGMCLNLE) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class IPGJKNELKJI : IDisposable, CIIDKCOCKKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly HashSet<Type> FDJEGJAOINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly HashSet<Type> ALBINHJENLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Transform COIEKHAHHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly List<Component> GGOAEHACJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> DIOFILBMOHJ;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3F30", Offset = "0x5DB2F30", VA = "0x185DB3F30")]
	[FBDCEBOAGGK(ABMKJHLOOPK.None)]
	public static void PBMNJAAGLPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4160", Offset = "0x5DB3160", VA = "0x185DB4160")]
	[Preserve]
	public IPGJKNELKJI([NBLPGINBDGI(null)] HPGGALHKNMC FAKFKKKGAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3E30", Offset = "0x5DB2E30", VA = "0x185DB3E30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3630", Offset = "0x5DB2630", VA = "0x185DB3630", Slot = "5")]
	public void APCPEMJLBCA(params Type[] CEJOIBBGIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3680", Offset = "0x5DB2680", VA = "0x185DB3680", Slot = "6")]
	public void BDCEEFCHPMB(params Type[] CEJOIBBGIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3830", Offset = "0x5DB2830", VA = "0x185DB3830", Slot = "7")]
	public GameObject BLLBOFBIELJ(GameObject LGELJKPCDJN, Transform OJKLIAPCMPJ, bool AELBGMCLNLE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2499870", Offset = "0x2498870", VA = "0x182499870", Slot = "8")]
	public T BLLBOFBIELJ<T>(T LGELJKPCDJN, Transform OJKLIAPCMPJ, bool AELBGMCLNLE = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2499220", Offset = "0x2498220", VA = "0x182499220", Slot = "9")]
	public T BLLBOFBIELJ<T>(GameObject LGELJKPCDJN, Transform OJKLIAPCMPJ, bool AELBGMCLNLE = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5DB38C0", Offset = "0x5DB28C0", VA = "0x185DB38C0", Slot = "10")]
	public GameObject BLLBOFBIELJ(GameObject LGELJKPCDJN, Transform OJKLIAPCMPJ, FHNIIPGPJHO EPEIMBEMAJE, bool AELBGMCLNLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2499820", Offset = "0x2498820", VA = "0x182499820", Slot = "11")]
	public T BLLBOFBIELJ<T>(GameObject LGELJKPCDJN, Transform OJKLIAPCMPJ, FHNIIPGPJHO EPEIMBEMAJE, bool AELBGMCLNLE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2499250", Offset = "0x2498250", VA = "0x182499250", Slot = "12")]
	public T BLLBOFBIELJ<T>(T LGELJKPCDJN, Transform OJKLIAPCMPJ, FHNIIPGPJHO EPEIMBEMAJE, bool AELBGMCLNLE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x24992E0", Offset = "0x24982E0", VA = "0x1824992E0")]
	private T BLLBOFBIELJ<T>(GameObject LGELJKPCDJN, Transform OJKLIAPCMPJ, FHNIIPGPJHO EPEIMBEMAJE, bool AELBGMCLNLE, out GameObject JGHPNKGEKCN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2498D70", Offset = "0x2497D70", VA = "0x182498D70")]
	private T BEGGFPIPCGC<T>(GameObject HBGIADIFHEC, FHNIIPGPJHO EPEIMBEMAJE, bool AELBGMCLNLE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4030", Offset = "0x5DB3030", VA = "0x185DB4030")]
	private void PDEPLMKHJFG(Component CHHHDNBJJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3950", Offset = "0x5DB2950", VA = "0x185DB3950")]
	private void DMLIHKPOKFE(Component CHHHDNBJJIO, FHNIIPGPJHO EPEIMBEMAJE, bool AELBGMCLNLE, [Optional] Type KJJDELIDEFN, [Optional] Type NAJCPFHKNAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5DB36D0", Offset = "0x5DB26D0", VA = "0x185DB36D0")]
	private void BLIGPBIOFEC(GameObject HBGIADIFHEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct FHNIIPGPJHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Dictionary<Type, object> HGPGDMHMFBF;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2B51750", Offset = "0x2B50750", VA = "0x182B51750")]
	public FHNIIPGPJHO DIMECELKFHA<T>(T KDAIJKFCLIH)
	{
		return default(FHNIIPGPJHO);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2B51E80", Offset = "0x2B50E80", VA = "0x182B51E80")]
	public T KEEHOGKCDPF<T>(T KFOCAJEFKKD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2B51FA0", Offset = "0x2B50FA0", VA = "0x182B51FA0")]
	public bool MFJHFJBDKOG<T>(out T KDAIJKFCLIH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct IAIPLHNBMEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public bool OJJCOBALCFI;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xF44290", Offset = "0xF43290", VA = "0x180F44290")]
	public IAIPLHNBMEB(bool BMCHPGOMCID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct MJMIANDPGCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly bool EPLNLPGFIKF;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4B90", Offset = "0x5DB3B90", VA = "0x185DB4B90")]
	public MJMIANDPGCE(bool FIKDFPIGDEB)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ScaleInImposter : MonoBehaviour, GFGAFDNCAEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4BE0", Offset = "0x5DB3BE0", VA = "0x185DB4BE0", Slot = "4")]
		public void PrepareImposter(FHNIIPGPJHO EPEIMBEMAJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
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
				[Cpp2IlInjected.Address(RVA = "0x5DB4B70", Offset = "0x5DB3B70", VA = "0x185DB4B70")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5DB4B60", Offset = "0x5DB3B60", VA = "0x185DB4B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DB4770", Offset = "0x5DB3770", VA = "0x185DB4770")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class GJPLAHOFHOP
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<URPLight> OIEJMDAFNMI;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly Vector3 MHDGGNPPEBC;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly Vector3 INFLHFCBOLM;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static Camera PCCBAMEMMKJ;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public const string MHPMHKJADBP = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public const LPAFLNJGKJG CLJKOCOKCNK = LPAFLNJGKJG.Water;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static readonly List<Renderer> CJCHKGBJMEB;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static AmbientMode DFPECDGPECC;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static Color HEMPNOCGJMK;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static Color ADOPGNIKNIG;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static Color BIADHCFGBEF;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static Cubemap BDJNJENNEJL;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static bool KCEDJJPFIPH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera JCIIPNAGOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1520", Offset = "0x5DB0520", VA = "0x185DB1520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5DB24C0", Offset = "0x5DB14C0", VA = "0x185DB24C0")]
	public static void KPLDLJNEIAI(Vector3 BGPBOFEAGPA, Quaternion LNOEGPJAHHC, ImposterRenderConfig ALEDLOJENJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5DB19E0", Offset = "0x5DB09E0", VA = "0x185DB19E0")]
	private static void GJJBNGMEMHK(Vector3 BGPBOFEAGPA, Quaternion LNOEGPJAHHC, URPLight HONJKNCCKLF, ImposterRenderConfig.LightConfig KNOFLFIPPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1750", Offset = "0x5DB0750", VA = "0x185DB1750")]
	public static void CIBCGELAKBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2740", Offset = "0x5DB1740", VA = "0x185DB2740")]
	private static void LPEDLLAOKIB(int HBIMMBHDKIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3360", Offset = "0x5DB2360", VA = "0x185DB3360")]
	public static void PJIKFCCKAEG(ImposterRenderConfig ALEDLOJENJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5DB23C0", Offset = "0x5DB13C0", VA = "0x185DB23C0")]
	public static void JMDOAKGBACP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1CF0", Offset = "0x5DB0CF0", VA = "0x185DB1CF0")]
	public static void HOKCOELJJKB(GameObject MCOJOCEAACL, RenderTexture ODOFOGGBBAF, ImposterRenderConfig ALEDLOJENJA, NPIPIFPNOEI DDMPPNIAEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1EC0", Offset = "0x5DB0EC0", VA = "0x185DB1EC0")]
	private static void JKBKPBOIELD(GameObject MCOJOCEAACL, RenderTexture ODOFOGGBBAF, ImposterRenderConfig ALEDLOJENJA, NPIPIFPNOEI DDMPPNIAEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3010", Offset = "0x5DB2010", VA = "0x185DB3010")]
	private static void OCGEHCJMGIM(GameObject MCOJOCEAACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1840", Offset = "0x5DB0840", VA = "0x185DB1840")]
	public static void DLEONDODCIP(List<Renderer> KOBHIMJAJIL, List<Material> EOGAPNJDPBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2B10", Offset = "0x5DB1B10", VA = "0x185DB2B10")]
	public static void MCMBHAHKHHB(GameObject LGELJKPCDJN, Vector3 FPGHKOGOAEF, Vector3 KDGFDEAOBPG, float HCHKLEDDLAP, NPIPIFPNOEI DDMPPNIAEEN, out Vector3 EIGNMCKMHKF, out Quaternion BNDIIMODLCJ, out float KEMPGKIPBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5DB32C0", Offset = "0x5DB22C0", VA = "0x185DB32C0")]
	public static RenderTexture PFBAJCFBMOL(int BHAMBKDMALL, int PEJBJHOOMHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2DE0", Offset = "0x5DB1DE0", VA = "0x185DB2DE0")]
	public static void MJAADNPPDKC()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public struct BOEBKAACIDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public AMPMBAOHAPE IFPFFGFEPLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public GameObject BHEHHDOLPLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public RenderTexture NHPKAGMMCLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public ImposterRenderConfig IFNEPHIIBOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public NPIPIFPNOEI NPIPIFPNOEI;

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5DB0A10", Offset = "0x5DAFA10", VA = "0x185DB0A10")]
			public BOEBKAACIDC(AMPMBAOHAPE FBOICHJLBEO, GameObject AOOLBBCPPJG, RenderTexture ODOFOGGBBAF, ImposterRenderConfig FCEPCPNJGJD, NPIPIFPNOEI DDMPPNIAEEN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int ENBDNJMEKJN = 1;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int NEDGNLCEBGF = 6;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static global::OMCCPEBFHLA<BOEBKAACIDC, RenderTexture> HPEGGHGPGDK;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static readonly List<BOEBKAACIDC> EGKLMAPMPKO;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int EBNGPGHGCNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7BA050", Offset = "0x7B9050", VA = "0x1807BA050")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0FE0", Offset = "0x5DAFFE0", VA = "0x185DB0FE0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject MCOJOCEAACL, RenderTexture ODOFOGGBBAF, ImposterRenderConfig ALEDLOJENJA, NPIPIFPNOEI DDMPPNIAEEN, CancellationToken OHJGLBPIBBN, bool DFNLEDLJAHH = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0BE0", Offset = "0x5DAFBE0", VA = "0x185DB0BE0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0D70", Offset = "0x5DAFD70", VA = "0x185DB0D70", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0E10", Offset = "0x5DAFE10", VA = "0x185DB0E10")]
		private static Task<RenderTexture> PIPLMAJOFOG(BOEBKAACIDC JLMCHOKNNIM, CancellationToken OHJGLBPIBBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5DB14B0", Offset = "0x5DB04B0", VA = "0x185DB14B0")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BAADKGJHJEL
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static byte[] ANBHIGGKLGA;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static int CIBDKMIJIHM;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static int HHBBDHEOEDG;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static BigInteger JHIBJFGIFBI;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public BAADKGJHJEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5DB03E0", Offset = "0x5DAF3E0", VA = "0x185DB03E0")]
	private static string DPBKDPCCPCK(byte[] ENHIJCCJFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5DB04F0", Offset = "0x5DAF4F0", VA = "0x185DB04F0")]
	public static string NNIAAAJCFNJ(byte[] CDDAIIMDJCN, bool FNAKCEJPGOO)
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
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
