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
public class ImposterPreviewCustomFraming : MonoBehaviour, CNJOEGAMAHD
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float CGPIFACHIMH = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "4")]
	public void PrepareImposter(CHIKGHDCOLJ KAHMNDPAILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x518F780", Offset = "0x518E980", VA = "0x18518F780")]
	public void SetReferencePoint(Vector3 PDPHIJPONFO, Quaternion COABOHLOHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x518F4E0", Offset = "0x518E6E0", VA = "0x18518F4E0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x518F710", Offset = "0x518E910", VA = "0x18518F710")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x117A880", Offset = "0x1179A80", VA = "0x18117A880")]
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
		[PLCNAFAOAOP(BAKNHFGGKOC.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const int PMIDLNPPNBJ = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int LCMKCDCJHAD = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly List<Material> OCBIHMENENB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool GJBELFPKIOG;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x518F940", Offset = "0x518EB40", VA = "0x18518F940")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x518F840", Offset = "0x518EA40", VA = "0x18518F840")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x518FB20", Offset = "0x518ED20", VA = "0x18518FB20")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class CenterInImposter : MonoBehaviour, CNJOEGAMAHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x518BE20", Offset = "0x518B020", VA = "0x18518BE20", Slot = "4")]
		public void PrepareImposter(CHIKGHDCOLJ KAHMNDPAILI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xDD9CF0", Offset = "0xDD8EF0", VA = "0x180DD9CF0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDD9CF0", Offset = "0xDD8EF0", VA = "0x180DD9CF0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CNJOEGAMAHD
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(CHIKGHDCOLJ KAHMNDPAILI);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface IENNCBOGKMK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> KFDKCJHOIAI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> DICNIPIBIKE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface CJPAFFOLGBA
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LABADKENEBO(params Type[] BPGJMFPFBMC);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MDOOHOFGIBP(params Type[] BPGJMFPFBMC);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject HLMJAKCFLDC(GameObject HAAOGJGGGGK, Transform DBICPFPGAAP, bool GIDKMIIHFMO = false);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T HLMJAKCFLDC<T>(T HAAOGJGGGGK, Transform DBICPFPGAAP, bool GIDKMIIHFMO = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T HLMJAKCFLDC<T>(GameObject HAAOGJGGGGK, Transform DBICPFPGAAP, bool GIDKMIIHFMO = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject HLMJAKCFLDC(GameObject HAAOGJGGGGK, Transform DBICPFPGAAP, CHIKGHDCOLJ KAHMNDPAILI, bool GIDKMIIHFMO);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T HLMJAKCFLDC<T>(GameObject HAAOGJGGGGK, Transform DBICPFPGAAP, CHIKGHDCOLJ KAHMNDPAILI, bool GIDKMIIHFMO) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T HLMJAKCFLDC<T>(T HAAOGJGGGGK, Transform DBICPFPGAAP, CHIKGHDCOLJ KAHMNDPAILI, bool GIDKMIIHFMO) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class GAEHAPPJBBL : IDisposable, CJPAFFOLGBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HashSet<Type> LHEKIKNJCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly HashSet<Type> NGPFBKAPLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Transform JCHCKHFMLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<Component> DAOAGBOGJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> DINAEDIGOHE;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x518C8D0", Offset = "0x518BAD0", VA = "0x18518C8D0")]
	[CFCNMFNLFMK]
	public static void APOKIHMDCPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x518D3C0", Offset = "0x518C5C0", VA = "0x18518D3C0")]
	[Preserve]
	public GAEHAPPJBBL([CHFCOGGIEGO(null)] IENNCBOGKMK EIFEGNAMKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x518CA30", Offset = "0x518BC30", VA = "0x18518CA30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x518D320", Offset = "0x518C520", VA = "0x18518D320", Slot = "5")]
	public void LABADKENEBO(params Type[] BPGJMFPFBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x518D370", Offset = "0x518C570", VA = "0x18518D370", Slot = "6")]
	public void MDOOHOFGIBP(params Type[] BPGJMFPFBMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x518D0C0", Offset = "0x518C2C0", VA = "0x18518D0C0", Slot = "7")]
	public GameObject HLMJAKCFLDC(GameObject HAAOGJGGGGK, Transform DBICPFPGAAP, bool GIDKMIIHFMO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x243D2C0", Offset = "0x243C4C0", VA = "0x18243D2C0", Slot = "8")]
	public T HLMJAKCFLDC<T>(T HAAOGJGGGGK, Transform DBICPFPGAAP, bool GIDKMIIHFMO = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x243D940", Offset = "0x243CB40", VA = "0x18243D940", Slot = "9")]
	public T HLMJAKCFLDC<T>(GameObject HAAOGJGGGGK, Transform DBICPFPGAAP, bool GIDKMIIHFMO = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x518D150", Offset = "0x518C350", VA = "0x18518D150", Slot = "10")]
	public GameObject HLMJAKCFLDC(GameObject HAAOGJGGGGK, Transform DBICPFPGAAP, CHIKGHDCOLJ KAHMNDPAILI, bool GIDKMIIHFMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x243D330", Offset = "0x243C530", VA = "0x18243D330", Slot = "11")]
	public T HLMJAKCFLDC<T>(GameObject HAAOGJGGGGK, Transform DBICPFPGAAP, CHIKGHDCOLJ KAHMNDPAILI, bool GIDKMIIHFMO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x243D230", Offset = "0x243C430", VA = "0x18243D230", Slot = "12")]
	public T HLMJAKCFLDC<T>(T HAAOGJGGGGK, Transform DBICPFPGAAP, CHIKGHDCOLJ KAHMNDPAILI, bool GIDKMIIHFMO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x243D380", Offset = "0x243C580", VA = "0x18243D380")]
	private T HLMJAKCFLDC<T>(GameObject HAAOGJGGGGK, Transform DBICPFPGAAP, CHIKGHDCOLJ KAHMNDPAILI, bool GIDKMIIHFMO, out GameObject NLBPAFCLEKL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x243D970", Offset = "0x243CB70", VA = "0x18243D970")]
	private T ICJPPJNMBMK<T>(GameObject BCGNPHHHPEM, CHIKGHDCOLJ KAHMNDPAILI, bool GIDKMIIHFMO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x518CB30", Offset = "0x518BD30", VA = "0x18518CB30")]
	private void EFINKCMLCIH(Component HELLEBCPPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x518CC50", Offset = "0x518BE50", VA = "0x18518CC50")]
	private void FPIPONPHAPF(Component HELLEBCPPCA, CHIKGHDCOLJ KAHMNDPAILI, bool GIDKMIIHFMO, [Optional] Type CJDMNIJKFDL, [Optional] Type ONDCICMBDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x518D1E0", Offset = "0x518C3E0", VA = "0x18518D1E0")]
	private void JFOHAFMEHFI(GameObject BCGNPHHHPEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct CHIKGHDCOLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<Type, object> GHMLCIPGLBK;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2D13CC0", Offset = "0x2D12EC0", VA = "0x182D13CC0")]
	public CHIKGHDCOLJ AMBCHILDJAC<T>(T DDBPFEGDPNC)
	{
		return default(CHIKGHDCOLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2436A90", Offset = "0x2435C90", VA = "0x182436A90")]
	public T FMKAFPOODOK<T>(T HHFDEALBOBE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2783070", Offset = "0x2782270", VA = "0x182783070")]
	public bool IHNEFFJOGBK<T>(out T DDBPFEGDPNC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct HCMLJOOMCJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public bool ALDLLPKHIDH;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xDBDEB0", Offset = "0xDBD0B0", VA = "0x180DBDEB0")]
	public HCMLJOOMCJM(bool FHLMJFFNMLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct FMLBAKPAINK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly bool DMFPHMDFIAE;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x518C8C0", Offset = "0x518BAC0", VA = "0x18518C8C0")]
	public FMLBAKPAINK(bool GCEINAOPHKO)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xDD9CF0", Offset = "0xDD8EF0", VA = "0x180DD9CF0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ScaleInImposter : MonoBehaviour, CNJOEGAMAHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x51901B0", Offset = "0x518F3B0", VA = "0x1851901B0", Slot = "4")]
		public void PrepareImposter(CHIKGHDCOLJ KAHMNDPAILI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xDD9CF0", Offset = "0xDD8EF0", VA = "0x180DD9CF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x5190190", Offset = "0x518F390", VA = "0x185190190")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5190180", Offset = "0x518F380", VA = "0x185190180")]
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
		[Cpp2IlInjected.Address(RVA = "0x518F7C0", Offset = "0x518E9C0", VA = "0x18518F7C0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class HFIJJEFBCPO
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly List<URPLight> AAEJGIJACOB;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly Vector3 IHABNDBLNBP;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Vector3 PGMNIFFFLFH;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static Camera NBPDHEDCPNA;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public const string NPDCAACILCB = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public const ADCFIAPBBEP AFBCHKODIME = ADCFIAPBBEP.Water;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly List<Renderer> MAFNONMJEIC;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static AmbientMode KGDGKCLBDEJ;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color BFBKCJCKDHO;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static Color OICLPLCPJCO;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static Color OKGEAMONCHN;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static Cubemap IJGOLGPOLOD;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static bool FBCCCCKHBDD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera DJNIMCLBGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x518E7F0", Offset = "0x518D9F0", VA = "0x18518E7F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x518E9F0", Offset = "0x518DBF0", VA = "0x18518E9F0")]
	public static void KMNLMPMGMPH(Vector3 PPMHHCOFJBO, Quaternion IDABIIBBDPN, ImposterRenderConfig BOJNMNPBCML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x518E4B0", Offset = "0x518D6B0", VA = "0x18518E4B0")]
	private static void KIMNKGMGEKE(Vector3 PPMHHCOFJBO, Quaternion IDABIIBBDPN, URPLight HMMLAPCFMBF, ImposterRenderConfig.LightConfig NLBMCFNDCIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x518F2B0", Offset = "0x518E4B0", VA = "0x18518F2B0")]
	public static void MOBHGMNLGKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x518D7F0", Offset = "0x518C9F0", VA = "0x18518D7F0")]
	private static void EGJNBMJNKLM(int PJIMBCLDJJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x518DAF0", Offset = "0x518CCF0", VA = "0x18518DAF0")]
	public static void EIJCEIBNODF(ImposterRenderConfig BOJNMNPBCML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x518D6F0", Offset = "0x518C8F0", VA = "0x18518D6F0")]
	public static void CDHKFNNCPDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x518E320", Offset = "0x518D520", VA = "0x18518E320")]
	public static void HMLBOBJICIB(GameObject PLIICDLMOGE, RenderTexture PJJNEPFJNLD, ImposterRenderConfig BOJNMNPBCML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x518DC70", Offset = "0x518CE70", VA = "0x18518DC70")]
	private static void FOFIBOBMELL(GameObject PLIICDLMOGE, RenderTexture PJJNEPFJNLD, ImposterRenderConfig BOJNMNPBCML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x518EF80", Offset = "0x518E180", VA = "0x18518EF80")]
	private static void LJPHCPEGBBJ(GameObject PLIICDLMOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x518E190", Offset = "0x518D390", VA = "0x18518E190")]
	public static void GJEDHNNDPNF(List<Renderer> APHLKAGFBLI, List<Material> DEJPEEPIMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x518EC70", Offset = "0x518DE70", VA = "0x18518EC70")]
	private static void LBDIKDPDMLB(GameObject HAAOGJGGGGK, Vector3 HOFAFNLGOEE, Vector3 OKBBOOLDFDJ, float LBLLCHLECMM, out Vector3 IAPIHABKAFO, out Quaternion AOHOPGLDJLM, out float JPDHNHKLJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x518F210", Offset = "0x518E410", VA = "0x18518F210")]
	public static RenderTexture LLGMFIKLGDJ(int HDKAONFKHGH, int IPFKOEAAMDI)
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
		public struct GCIGIPEEFMM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public JLGLDFIOJOP EBOLFNGJDHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public GameObject LKFAJEGANLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public RenderTexture HEOAIHBLILP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public ImposterRenderConfig HLBBDHOFPNF;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x46C4120", Offset = "0x46C3320", VA = "0x1846C4120")]
			public GCIGIPEEFMM(JLGLDFIOJOP DBBNLJKOLFO, GameObject PGNBFOLHFMM, RenderTexture PJJNEPFJNLD, ImposterRenderConfig GJFEHLCLACF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const int DAIAGIHPONL = 1;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int NIKINOPKOJG = 6;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static global::MDJPDDGIJFC<GCIGIPEEFMM, RenderTexture> BFODJHIGEHO;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static readonly List<GCIGIPEEFMM> OBMAGLAGBEK;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int OKLNJIMECBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8C1D10", Offset = "0x8C0F10", VA = "0x1808C1D10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x518C480", Offset = "0x518B680", VA = "0x18518C480")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject PLIICDLMOGE, RenderTexture PJJNEPFJNLD, ImposterRenderConfig BOJNMNPBCML, CancellationToken IHCDPGIEMEN, bool DGMGPNEIEKB = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x518BFA0", Offset = "0x518B1A0", VA = "0x18518BFA0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x518C3F0", Offset = "0x518B5F0", VA = "0x18518C3F0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x518C0C0", Offset = "0x518B2C0", VA = "0x18518C0C0")]
		private static Task<RenderTexture> IELEMENPFNN(GCIGIPEEFMM JINNFHMKLFD, CancellationToken IHCDPGIEMEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x518C860", Offset = "0x518BA60", VA = "0x18518C860")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class JABMDOENCKP
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static byte[] CDGDAHNLLDM;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int FDPMPGKGLAJ;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static int LAEDHJMCKNO;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static BigInteger CJEJEKHBKEN;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public JABMDOENCKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x518FEC0", Offset = "0x518F0C0", VA = "0x18518FEC0")]
	private static string DMHFLPDODAP(byte[] DLFOEJDCAKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x518FB90", Offset = "0x518ED90", VA = "0x18518FB90")]
	public static string AJIDJKNPAKB(byte[] NGIBJOEMFPL, bool MFLHBEHGGNL)
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
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
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
