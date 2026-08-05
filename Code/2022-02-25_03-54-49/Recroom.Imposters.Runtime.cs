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
public class ImposterPreviewCustomFraming : MonoBehaviour, ANNEHEHODCA
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float NHIBHLHEEMG = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x51A920", Offset = "0x518F20", VA = "0x18051A920", Slot = "4")]
	public void PrepareImposter(PHJJDAHGIEN AOMKOGGHMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x31AFFC0", Offset = "0x31AE5C0", VA = "0x1831AFFC0")]
	public void SetReferencePoint(Vector3 MLNNAGHLNEA, Quaternion DNCJAFCCDNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x31AFD20", Offset = "0x31AE320", VA = "0x1831AFD20")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x31AFF50", Offset = "0x31AE550", VA = "0x1831AFF50")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1777210", Offset = "0x1775810", VA = "0x181777210")]
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
		[AKDNOBOMHFK(JFEDCPFKCIP.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const int HPBGFGFEBML = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int ICCBGIIEPLN = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly List<Material> NJJAGLHLDPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool FOEFCIOMGOA;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x31B0180", Offset = "0x31AE780", VA = "0x1831B0180")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x31B0080", Offset = "0x31AE680", VA = "0x1831B0080")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x31B0360", Offset = "0x31AE960", VA = "0x1831B0360")]
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
		[Cpp2IlInjected.Address(RVA = "0x50D600", Offset = "0x50BC00", VA = "0x18050D600")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ANNEHEHODCA
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(PHJJDAHGIEN AOMKOGGHMNI);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MMFCIIFFPFO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> KDEOPPOPHEM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> AJNHEEGILLL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KFAHLNNCCAE
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMCBBDCFBOO(params Type[] OMDOOIJPNIN);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KCNPCFJEKIB(params Type[] OMDOOIJPNIN);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject KINONFMOAMP(GameObject KJKGGOGNIDD, Transform IJHBOGOHCCC, bool BEPCBNMEDOA = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T KINONFMOAMP<T>(T KJKGGOGNIDD, Transform IJHBOGOHCCC, bool BEPCBNMEDOA = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T KINONFMOAMP<T>(GameObject KJKGGOGNIDD, Transform IJHBOGOHCCC, bool BEPCBNMEDOA = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject KINONFMOAMP(GameObject KJKGGOGNIDD, Transform IJHBOGOHCCC, PHJJDAHGIEN AOMKOGGHMNI, bool BEPCBNMEDOA);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T KINONFMOAMP<T>(GameObject KJKGGOGNIDD, Transform IJHBOGOHCCC, PHJJDAHGIEN AOMKOGGHMNI, bool BEPCBNMEDOA) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T KINONFMOAMP<T>(T KJKGGOGNIDD, Transform IJHBOGOHCCC, PHJJDAHGIEN AOMKOGGHMNI, bool BEPCBNMEDOA) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MFOFDKONIKF : IDisposable, KFAHLNNCCAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly HashSet<Type> AMGLIGJADGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HashSet<Type> OCPINNCHACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Transform JJKMBIEDBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly List<Component> PGJADOBAGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> GHHPCNJMEHC;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x31B2490", Offset = "0x31B0A90", VA = "0x1831B2490")]
	[IABMDIJNELF]
	public static void CMFNLDFOIEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x31B2DF0", Offset = "0x31B13F0", VA = "0x1831B2DF0")]
	[Preserve]
	public MFOFDKONIKF([EALINMABAOK(null)] MMFCIIFFPFO MGMFAHJAOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x31B25F0", Offset = "0x31B0BF0", VA = "0x1831B25F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x31B2300", Offset = "0x31B0900", VA = "0x1831B2300", Slot = "5")]
	public void CMCBBDCFBOO(params Type[] OMDOOIJPNIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x31B2C80", Offset = "0x31B1280", VA = "0x1831B2C80", Slot = "6")]
	public void KCNPCFJEKIB(params Type[] OMDOOIJPNIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x31B2CD0", Offset = "0x31B12D0", VA = "0x1831B2CD0", Slot = "7")]
	public GameObject KINONFMOAMP(GameObject KJKGGOGNIDD, Transform IJHBOGOHCCC, bool BEPCBNMEDOA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4038E70", Offset = "0x4037470", VA = "0x184038E70", Slot = "8")]
	public T KINONFMOAMP<T>(T KJKGGOGNIDD, Transform IJHBOGOHCCC, bool BEPCBNMEDOA = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4038A50", Offset = "0x4037050", VA = "0x184038A50", Slot = "9")]
	public T KINONFMOAMP<T>(GameObject KJKGGOGNIDD, Transform IJHBOGOHCCC, bool BEPCBNMEDOA = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x31B2D60", Offset = "0x31B1360", VA = "0x1831B2D60", Slot = "10")]
	public GameObject KINONFMOAMP(GameObject KJKGGOGNIDD, Transform IJHBOGOHCCC, PHJJDAHGIEN AOMKOGGHMNI, bool BEPCBNMEDOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4038A00", Offset = "0x4037000", VA = "0x184038A00", Slot = "11")]
	public T KINONFMOAMP<T>(GameObject KJKGGOGNIDD, Transform IJHBOGOHCCC, PHJJDAHGIEN AOMKOGGHMNI, bool BEPCBNMEDOA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4038DE0", Offset = "0x40373E0", VA = "0x184038DE0", Slot = "12")]
	public T KINONFMOAMP<T>(T KJKGGOGNIDD, Transform IJHBOGOHCCC, PHJJDAHGIEN AOMKOGGHMNI, bool BEPCBNMEDOA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4038A80", Offset = "0x4037080", VA = "0x184038A80")]
	private T KINONFMOAMP<T>(GameObject KJKGGOGNIDD, Transform IJHBOGOHCCC, PHJJDAHGIEN AOMKOGGHMNI, bool BEPCBNMEDOA, out GameObject HKNFFIIBPJN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4038EE0", Offset = "0x40374E0", VA = "0x184038EE0")]
	private T PNHIKGBGPJK<T>(GameObject NPJKABNGMNJ, PHJJDAHGIEN AOMKOGGHMNI, bool BEPCBNMEDOA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x31B2B60", Offset = "0x31B1160", VA = "0x1831B2B60")]
	private void IGDBHCNHBIL(Component LMGNHHOKMNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x31B26F0", Offset = "0x31B0CF0", VA = "0x1831B26F0")]
	private void HJPFMOCAIBC(Component LMGNHHOKMNA, PHJJDAHGIEN AOMKOGGHMNI, bool BEPCBNMEDOA, [Optional] Type INABACBAICJ, [Optional] Type DDDKDGEJCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x31B2350", Offset = "0x31B0950", VA = "0x1831B2350")]
	private void CMCKPHDJBJH(GameObject NPJKABNGMNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct PHJJDAHGIEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Dictionary<Type, object> MDEANFNEGEL;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xC9ACC0", Offset = "0xC992C0", VA = "0x180C9ACC0")]
	public PHJJDAHGIEN ENJDGFBIGDL<T>(T PKDKJLKNGLA)
	{
		return default(PHJJDAHGIEN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x403C690", Offset = "0x403AC90", VA = "0x18403C690")]
	public T CFNFGAKIEIE<T>(T DKCCLMEOJBK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x87FF60", Offset = "0x87E560", VA = "0x18087FF60")]
	public bool ALPBBFNFCPD<T>(out T PKDKJLKNGLA)
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
				[Cpp2IlInjected.Address(RVA = "0x31B22E0", Offset = "0x31B08E0", VA = "0x1831B22E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x31B22D0", Offset = "0x31B08D0", VA = "0x1831B22D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x31B0000", Offset = "0x31AE600", VA = "0x1831B0000")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LDGAKGKAEDP
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly List<URPLight> HAEMDLEPEEI;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly Vector3 HGDNOLLFNAB;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly Vector3 AHDHNEMDPFK;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static Camera PAAPJEHMOGE;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public const string HNOBGKABHCM = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const JDNABKEGPMG LBGBPMHDPOF = JDNABKEGPMG.Water;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<Renderer> LGAFLBAJPIP;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static AmbientMode JBFKNEFIKJK;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static Color EBGLENDKBJL;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static Color BICBELCIFMN;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static Color OPHLCHPONFD;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Cubemap DCDFKFPCMFF;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static bool CEJKEPCDIGP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera MIJNDDFDHKC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x31B1A30", Offset = "0x31B0030", VA = "0x1831B1A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x31B03D0", Offset = "0x31AE9D0", VA = "0x1831B03D0")]
	public static void AHHDPGAPLPE(Vector3 DIMMLKEIMNO, Quaternion GFLNBFNCKJA, ImposterRenderConfig FEOPNDIHAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x31B1550", Offset = "0x31AFB50", VA = "0x1831B1550")]
	private static void KMOLECFBINF(Vector3 DIMMLKEIMNO, Quaternion GFLNBFNCKJA, URPLight LIKOEKJCFDB, ImposterRenderConfig.LightConfig PBMGNNEGAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x31B0BC0", Offset = "0x31AF1C0", VA = "0x1831B0BC0")]
	public static void EPMDLHFBAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x31B10C0", Offset = "0x31AF6C0", VA = "0x1831B10C0")]
	private static void IMNCNMFBEIJ(int JFFDEDJOBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x31B0A40", Offset = "0x31AF040", VA = "0x1831B0A40")]
	public static void DOBLBLPBHFO(ImposterRenderConfig FEOPNDIHAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x31B1890", Offset = "0x31AFE90", VA = "0x1831B1890")]
	public static void MGJBGFKECJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x31B0F30", Offset = "0x31AF530", VA = "0x1831B0F30")]
	public static void IFAEHJEJEOH(GameObject HNPECKAIOCD, RenderTexture HMGBLENEJII, ImposterRenderConfig FEOPNDIHAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x31B1C30", Offset = "0x31B0230", VA = "0x1831B1C30")]
	private static void OHKFPEEJLOP(GameObject HNPECKAIOCD, RenderTexture HMGBLENEJII, ImposterRenderConfig FEOPNDIHAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x31B0CA0", Offset = "0x31AF2A0", VA = "0x1831B0CA0")]
	private static void HNPLGMDCNHA(GameObject HNPECKAIOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x31B13C0", Offset = "0x31AF9C0", VA = "0x1831B13C0")]
	public static void JDEFHKGLIMN(List<Renderer> ACEMEIBOJKL, List<Material> KFAJDOCKFOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x31B0650", Offset = "0x31AEC50", VA = "0x1831B0650")]
	private static void CFKDJGCKMEM(List<Renderer> ACEMEIBOJKL, Vector3 PHDKIABHHLK, Vector3 DPIMOMMNIKC, float LPMMBECCKLM, out Vector3 CEBPAJABMMH, out Quaternion POOJBOJCFCH, out float PFHGNMHNCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x31B1990", Offset = "0x31AFF90", VA = "0x1831B1990")]
	public static RenderTexture NGGEPHMFODP(int PPFMJFLCFJD, int BIOALPENMMK)
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
		public struct CIIOANJHPEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public MNKIKGKHNHB DJLBDLLCOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public GameObject NFNOLMNDDAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public RenderTexture DEJKEENNOCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public ImposterRenderConfig MJMBBHPCAKJ;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x28361B0", Offset = "0x28347B0", VA = "0x1828361B0")]
			public CIIOANJHPEO(MNKIKGKHNHB HMGDBPCOADP, GameObject DBGCMNKMIIM, RenderTexture HMGBLENEJII, ImposterRenderConfig NNGFFLMFLBI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const int PNNIICFFAMF = 1;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const int IDOBEPOLGIO = 6;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static global::JOPMPLPBOKB<CIIOANJHPEO, RenderTexture> HNAHADOPMCB;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static readonly List<CIIOANJHPEO> DFKLIFFDALH;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int EAFBKABNGAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xD08250", Offset = "0xD06850", VA = "0x180D08250")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x31AF2F0", Offset = "0x31AD8F0", VA = "0x1831AF2F0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject HNPECKAIOCD, RenderTexture HMGBLENEJII, ImposterRenderConfig FEOPNDIHAGG, CancellationToken NOBLOPDMHIK, bool LOCCANGAFBL = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x31AF140", Offset = "0x31AD740", VA = "0x1831AF140", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x31AF260", Offset = "0x31AD860", VA = "0x1831AF260", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x31AEE10", Offset = "0x31AD410", VA = "0x1831AEE10")]
		private static Task<RenderTexture> ABECDCJPLPN(CIIOANJHPEO BBJEGILAOEB, CancellationToken NOBLOPDMHIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x31AF6D0", Offset = "0x31ADCD0", VA = "0x1831AF6D0")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class ELLJCHCKLPK
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static byte[] HCFMLFPGGCP;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static int NJDNHGIINNA;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static int NHIKDHEJBAF;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static BigInteger NKHCHBBJBBN;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
	public ELLJCHCKLPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x31AF730", Offset = "0x31ADD30", VA = "0x1831AF730")]
	private static string FLCHPOEFEII(byte[] BFBDMMHDNGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x31AF830", Offset = "0x31ADE30", VA = "0x1831AF830")]
	public static string GHPGBPLJMGG(byte[] FBEAOBEALBD, bool NJHPJLGMMPP)
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
		[Cpp2IlInjected.Address(RVA = "0x5321A0", Offset = "0x5307A0", VA = "0x1805321A0")]
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
