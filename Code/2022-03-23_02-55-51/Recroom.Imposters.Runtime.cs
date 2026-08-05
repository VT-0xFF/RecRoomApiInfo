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
public class ImposterPreviewCustomFraming : MonoBehaviour, IGELHOHBEMM
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float GJNDDOIEBEI = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x521E80", Offset = "0x520680", VA = "0x180521E80", Slot = "4")]
	public void PrepareImposter(PGCGKNLNFPH EIKGONFCOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4AC2FD0", Offset = "0x4AC17D0", VA = "0x184AC2FD0")]
	public void SetReferencePoint(Vector3 DGMPJHLCNKC, Quaternion HCGGEEDCADJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4AC2D30", Offset = "0x4AC1530", VA = "0x184AC2D30")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4AC2F60", Offset = "0x4AC1760", VA = "0x184AC2F60")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1792310", Offset = "0x1790B10", VA = "0x181792310")]
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
		[LBKCPHKKGJL(PCCPJPANDII.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const int NJJDIKNFNHJ = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int EALFCLEHCJF = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly List<Material> FJEMONFEJLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool MMILLJDNNKC;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4AC3190", Offset = "0x4AC1990", VA = "0x184AC3190")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4AC3090", Offset = "0x4AC1890", VA = "0x184AC3090")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4AC3370", Offset = "0x4AC1B70", VA = "0x184AC3370")]
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
		[Cpp2IlInjected.Address(RVA = "0xD192F0", Offset = "0xD17AF0", VA = "0x180D192F0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IGELHOHBEMM
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(PGCGKNLNFPH EIKGONFCOOE);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface EGMCBLCHGKP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> KCKFOJPFHBB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> GAINANDMNPI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface IHLOKLKANLE
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMFIOLGNHNK(params Type[] NIHLHOFPMNE);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MBJDMDDBIEL(params Type[] NIHLHOFPMNE);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject MAKMCGCECJM(GameObject ODBJDILHDBE, Transform AIECLMDDNDL, bool KEFAAAEJFHF = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T MAKMCGCECJM<T>(T ODBJDILHDBE, Transform AIECLMDDNDL, bool KEFAAAEJFHF = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T MAKMCGCECJM<T>(GameObject ODBJDILHDBE, Transform AIECLMDDNDL, bool KEFAAAEJFHF = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject MAKMCGCECJM(GameObject ODBJDILHDBE, Transform AIECLMDDNDL, PGCGKNLNFPH EIKGONFCOOE, bool KEFAAAEJFHF);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T MAKMCGCECJM<T>(GameObject ODBJDILHDBE, Transform AIECLMDDNDL, PGCGKNLNFPH EIKGONFCOOE, bool KEFAAAEJFHF) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T MAKMCGCECJM<T>(T ODBJDILHDBE, Transform AIECLMDDNDL, PGCGKNLNFPH EIKGONFCOOE, bool KEFAAAEJFHF) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class OHHBBNENJNK : IDisposable, IHLOKLKANLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly HashSet<Type> FDBAPBPBNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HashSet<Type> PAIJJHPIGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Transform LFNFJMOAFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly List<Component> MMBIGFJMDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> BNGFBELFDOC;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4AC40E0", Offset = "0x4AC28E0", VA = "0x184AC40E0")]
	[GHGHOICNHGA]
	public static void JAHJDCHOFNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4AC44F0", Offset = "0x4AC2CF0", VA = "0x184AC44F0")]
	[Preserve]
	public OHHBBNENJNK([NNEBMIDHMPC(null)] EGMCBLCHGKP HPAJBKIFJMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4AC3B70", Offset = "0x4AC2370", VA = "0x184AC3B70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4AC3B20", Offset = "0x4AC2320", VA = "0x184AC3B20", Slot = "5")]
	public void CMFIOLGNHNK(params Type[] NIHLHOFPMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4AC44A0", Offset = "0x4AC2CA0", VA = "0x184AC44A0", Slot = "6")]
	public void MBJDMDDBIEL(params Type[] NIHLHOFPMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4AC4410", Offset = "0x4AC2C10", VA = "0x184AC4410", Slot = "7")]
	public GameObject MAKMCGCECJM(GameObject ODBJDILHDBE, Transform AIECLMDDNDL, bool KEFAAAEJFHF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1CAB070", Offset = "0x1CA9870", VA = "0x181CAB070", Slot = "8")]
	public T MAKMCGCECJM<T>(T ODBJDILHDBE, Transform AIECLMDDNDL, bool KEFAAAEJFHF = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1CAAFF0", Offset = "0x1CA97F0", VA = "0x181CAAFF0", Slot = "9")]
	public T MAKMCGCECJM<T>(GameObject ODBJDILHDBE, Transform AIECLMDDNDL, bool KEFAAAEJFHF = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4AC4380", Offset = "0x4AC2B80", VA = "0x184AC4380", Slot = "10")]
	public GameObject MAKMCGCECJM(GameObject ODBJDILHDBE, Transform AIECLMDDNDL, PGCGKNLNFPH EIKGONFCOOE, bool KEFAAAEJFHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1CAB020", Offset = "0x1CA9820", VA = "0x181CAB020", Slot = "11")]
	public T MAKMCGCECJM<T>(GameObject ODBJDILHDBE, Transform AIECLMDDNDL, PGCGKNLNFPH EIKGONFCOOE, bool KEFAAAEJFHF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1CAAF60", Offset = "0x1CA9760", VA = "0x181CAAF60", Slot = "12")]
	public T MAKMCGCECJM<T>(T ODBJDILHDBE, Transform AIECLMDDNDL, PGCGKNLNFPH EIKGONFCOOE, bool KEFAAAEJFHF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1CAB0E0", Offset = "0x1CA98E0", VA = "0x181CAB0E0")]
	private T MAKMCGCECJM<T>(GameObject ODBJDILHDBE, Transform AIECLMDDNDL, PGCGKNLNFPH EIKGONFCOOE, bool KEFAAAEJFHF, out GameObject IEHNEPLDGDD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1CAAAB0", Offset = "0x1CA92B0", VA = "0x181CAAAB0")]
	private T KHFBBMHKPPL<T>(GameObject EMIOHDNKBKG, PGCGKNLNFPH EIKGONFCOOE, bool KEFAAAEJFHF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4AC3A00", Offset = "0x4AC2200", VA = "0x184AC3A00")]
	private void AFCOJHPGPMO(Component HFHBPDDENLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4AC3C70", Offset = "0x4AC2470", VA = "0x184AC3C70")]
	private void ECJHCECIJOL(Component HFHBPDDENLH, PGCGKNLNFPH EIKGONFCOOE, bool KEFAAAEJFHF, [Optional] Type KLOHAKMGGED, [Optional] Type OMCCKAFFEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4AC4240", Offset = "0x4AC2A40", VA = "0x184AC4240")]
	private void JBNHBJJDFKJ(GameObject EMIOHDNKBKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct PGCGKNLNFPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Dictionary<Type, object> CEFNOABJBEM;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9B70", Offset = "0x1CF8370", VA = "0x181CF9B70")]
	public PGCGKNLNFPH FCOKICFHMIC<T>(T BBMLHLLDABG)
	{
		return default(PGCGKNLNFPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1CABEC0", Offset = "0x1CAA6C0", VA = "0x181CABEC0")]
	public T ACAMCBFIHPP<T>(T KABCHKGNPLL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1F20550", Offset = "0x1F1ED50", VA = "0x181F20550")]
	public bool HHNLKFFHOIA<T>(out T BBMLHLLDABG)
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
				[Cpp2IlInjected.Address(RVA = "0x4AC39E0", Offset = "0x4AC21E0", VA = "0x184AC39E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x4AC39D0", Offset = "0x4AC21D0", VA = "0x184AC39D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4AC3010", Offset = "0x4AC1810", VA = "0x184AC3010")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class CIBKJOEKBCH
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly List<URPLight> FFMDCFNGAFE;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly Vector3 IHBHMDBFPOO;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly Vector3 KJKPIOOPHJO;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static Camera FGKKOCJGBCI;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public const string FPMABNJBDML = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const MFJNEMBFEJB KCOJHIOOKDC = MFJNEMBFEJB.Water;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<Renderer> KDJPKHNNNKB;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static AmbientMode JCOBJAFPIKH;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static Color IBGKGBPAHKL;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static Color EMHGOKPMPJI;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static Color DGKCJIPAGEA;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Cubemap OCBMOJBFICJ;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static bool GIKHHHNNKNM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera BFAICDCPNMO
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4AC0790", Offset = "0x4ABEF90", VA = "0x184AC0790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4AC0510", Offset = "0x4ABED10", VA = "0x184AC0510")]
	public static void BEHHIOMPOFK(Vector3 HHPKEIAFKNB, Quaternion BMPMHGOFGIC, ImposterRenderConfig LMBFECKMDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4AC1C80", Offset = "0x4AC0480", VA = "0x184AC1C80")]
	private static void NCACCDACGPI(Vector3 HHPKEIAFKNB, Quaternion BMPMHGOFGIC, URPLight AKACGAIFHLK, ImposterRenderConfig.LightConfig CHODMJLEFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4AC1600", Offset = "0x4ABFE00", VA = "0x184AC1600")]
	public static void IOMAFPKHPDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4AC1FC0", Offset = "0x4AC07C0", VA = "0x184AC1FC0")]
	private static void PLPPHKKHEIB(int EABABGAJMIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4AC16E0", Offset = "0x4ABFEE0", VA = "0x184AC16E0")]
	public static void LHGEKDABEEH(ImposterRenderConfig LMBFECKMDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4AC1500", Offset = "0x4ABFD00", VA = "0x184AC1500")]
	public static void IHJPAKIKDEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4AC0990", Offset = "0x4ABF190", VA = "0x184AC0990")]
	public static void FEJDOHIKLKB(GameObject GPEBAJNGLBM, RenderTexture FJDPMAINILB, ImposterRenderConfig LMBFECKMDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4AC0F10", Offset = "0x4ABF710", VA = "0x184AC0F10")]
	private static void HILEMOFIOMG(GameObject GPEBAJNGLBM, RenderTexture FJDPMAINILB, ImposterRenderConfig LMBFECKMDLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4AC19F0", Offset = "0x4AC01F0", VA = "0x184AC19F0")]
	private static void MFADBAFNGDK(GameObject GPEBAJNGLBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4AC1860", Offset = "0x4AC0060", VA = "0x184AC1860")]
	public static void MDLNMGOEJPH(List<Renderer> EGJLOHEICOF, List<Material> FFHNFEPFMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4AC0B20", Offset = "0x4ABF320", VA = "0x184AC0B20")]
	private static void GLGNLNCGOPM(List<Renderer> EGJLOHEICOF, Vector3 GNPFLANNJON, Vector3 JOKGEOPNOJO, float FHIDMDPIMOM, out Vector3 LJGOGFHJKOH, out Quaternion CGAEACNHFBG, out float KOEPLMONIKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4AC1460", Offset = "0x4ABFC60", VA = "0x184AC1460")]
	public static RenderTexture IFAJELCHKLA(int JBENCIOJCIN, int DHDPHMHHLFN)
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
		public struct JANGDMHGPKE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public EMAJIFEKEMH KCELLIAEHKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public GameObject FLMLANKBPEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public RenderTexture HPMMAFBDMAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public ImposterRenderConfig COCLNKNNACO;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x141DB40", Offset = "0x141C340", VA = "0x18141DB40")]
			public JANGDMHGPKE(EMAJIFEKEMH LAPKAMHCPGL, GameObject FDMLLGKKCKF, RenderTexture FJDPMAINILB, ImposterRenderConfig KKLLIOIEPFN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const int EDFDNKHNDEK = 1;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const int KODPHDGGDDG = 6;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static global::HFNNDBKNEDK<JANGDMHGPKE, RenderTexture> BAOMNKBHBPD;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static readonly List<JANGDMHGPKE> AMKFGEAKPMO;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int AMCEFJFFCJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x85D200", Offset = "0x85BA00", VA = "0x18085D200")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4AC28F0", Offset = "0x4AC10F0", VA = "0x184AC28F0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject GPEBAJNGLBM, RenderTexture FJDPMAINILB, ImposterRenderConfig LMBFECKMDLA, CancellationToken MOIIDJBIJCG, bool PKMMDKKOGOD = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4AC2740", Offset = "0x4AC0F40", VA = "0x184AC2740", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4AC2860", Offset = "0x4AC1060", VA = "0x184AC2860", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4AC2410", Offset = "0x4AC0C10", VA = "0x184AC2410")]
		private static Task<RenderTexture> AAIJIOGBCEF(JANGDMHGPKE HAAPGJLJPBL, CancellationToken MOIIDJBIJCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4AC2CD0", Offset = "0x4AC14D0", VA = "0x184AC2CD0")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class LPHGEELGLMB
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static byte[] GPJANLJHPME;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static int PPCKGPBBLCP;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static int JEFPLDJMJDE;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static BigInteger ABCMBKBOAFJ;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
	public LPHGEELGLMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4AC33E0", Offset = "0x4AC1BE0", VA = "0x184AC33E0")]
	private static string EOENAFMMDNF(byte[] DOMNMKJGGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4AC34E0", Offset = "0x4AC1CE0", VA = "0x184AC34E0")]
	public static string OPCCKPNHHLB(byte[] MIIBCOAJABM, bool NJCHAECDCAB)
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
		[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
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
