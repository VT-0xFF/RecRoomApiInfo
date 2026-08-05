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
public class ImposterPreviewCustomFraming : MonoBehaviour, GNGCFGAOLFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float CFNFCOPIFBO = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x552E80", Offset = "0x552280", VA = "0x180552E80", Slot = "4")]
	public void PrepareImposter(EIMNFPLGNED INFLOKAIDAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4D5D4C0", Offset = "0x4D5C8C0", VA = "0x184D5D4C0")]
	public void SetReferencePoint(Vector3 BCONKEJFNEF, Quaternion EFJFJAHLJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4D5D220", Offset = "0x4D5C620", VA = "0x184D5D220")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4D5D450", Offset = "0x4D5C850", VA = "0x184D5D450")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xEE1670", Offset = "0xEE0A70", VA = "0x180EE1670")]
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
		[JGOEDCMEHLE(KOOLODOPKJP.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const int INPODHDJAJG = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int NBMOOPHBNOD = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly List<Material> NAPGDGPNJMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool FBGOJNDOHHL;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4D5D680", Offset = "0x4D5CA80", VA = "0x184D5D680")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4D5D580", Offset = "0x4D5C980", VA = "0x184D5D580")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4D5D860", Offset = "0x4D5CC60", VA = "0x184D5D860")]
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
		[Cpp2IlInjected.Address(RVA = "0xD9EBF0", Offset = "0xD9DFF0", VA = "0x180D9EBF0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GNGCFGAOLFJ
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(EIMNFPLGNED INFLOKAIDAB);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LCCAPLBCLEM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> NMCIKADFJLL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> APIPPGEFCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MHEPFODJMHE
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LMGPKGPGKHJ(params Type[] BKOHDMBEGOJ);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MOAFKCENPKF(params Type[] BKOHDMBEGOJ);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject INPEAJIBFIL(GameObject PLJPLOAFBDE, Transform PDIGOPINEPN, bool JOJMAHGOLHM = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T INPEAJIBFIL<T>(T PLJPLOAFBDE, Transform PDIGOPINEPN, bool JOJMAHGOLHM = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T INPEAJIBFIL<T>(GameObject PLJPLOAFBDE, Transform PDIGOPINEPN, bool JOJMAHGOLHM = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject INPEAJIBFIL(GameObject PLJPLOAFBDE, Transform PDIGOPINEPN, EIMNFPLGNED INFLOKAIDAB, bool JOJMAHGOLHM);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T INPEAJIBFIL<T>(GameObject PLJPLOAFBDE, Transform PDIGOPINEPN, EIMNFPLGNED INFLOKAIDAB, bool JOJMAHGOLHM) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T INPEAJIBFIL<T>(T PLJPLOAFBDE, Transform PDIGOPINEPN, EIMNFPLGNED INFLOKAIDAB, bool JOJMAHGOLHM) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class FGCIIFEGIHP : IDisposable, MHEPFODJMHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly HashSet<Type> OFCINJIOBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HashSet<Type> FEOJGKCCLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Transform JFOOAECKBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly List<Component> MICDDLKJDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> MNCKJEJIGBP;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4D5A930", Offset = "0x4D59D30", VA = "0x184D5A930")]
	[MGFKGABAPBG]
	public static void KBLINPEPNIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4D5AB30", Offset = "0x4D59F30", VA = "0x184D5AB30")]
	[Preserve]
	public FGCIIFEGIHP([GOCFELBGFAM(null)] LCCAPLBCLEM BJPCJEEAIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4D5A040", Offset = "0x4D59440", VA = "0x184D5A040", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4D5AA90", Offset = "0x4D59E90", VA = "0x184D5AA90", Slot = "5")]
	public void LMGPKGPGKHJ(params Type[] BKOHDMBEGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4D5AAE0", Offset = "0x4D59EE0", VA = "0x184D5AAE0", Slot = "6")]
	public void MOAFKCENPKF(params Type[] BKOHDMBEGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4D5A8A0", Offset = "0x4D59CA0", VA = "0x184D5A8A0", Slot = "7")]
	public GameObject INPEAJIBFIL(GameObject PLJPLOAFBDE, Transform PDIGOPINEPN, bool JOJMAHGOLHM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1E07EF0", Offset = "0x1E072F0", VA = "0x181E07EF0", Slot = "8")]
	public T INPEAJIBFIL<T>(T PLJPLOAFBDE, Transform PDIGOPINEPN, bool JOJMAHGOLHM = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1E07EC0", Offset = "0x1E072C0", VA = "0x181E07EC0", Slot = "9")]
	public T INPEAJIBFIL<T>(GameObject PLJPLOAFBDE, Transform PDIGOPINEPN, bool JOJMAHGOLHM = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4D5A810", Offset = "0x4D59C10", VA = "0x184D5A810", Slot = "10")]
	public GameObject INPEAJIBFIL(GameObject PLJPLOAFBDE, Transform PDIGOPINEPN, EIMNFPLGNED INFLOKAIDAB, bool JOJMAHGOLHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1E08520", Offset = "0x1E07920", VA = "0x181E08520", Slot = "11")]
	public T INPEAJIBFIL<T>(GameObject PLJPLOAFBDE, Transform PDIGOPINEPN, EIMNFPLGNED INFLOKAIDAB, bool JOJMAHGOLHM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1E07E30", Offset = "0x1E07230", VA = "0x181E07E30", Slot = "12")]
	public T INPEAJIBFIL<T>(T PLJPLOAFBDE, Transform PDIGOPINEPN, EIMNFPLGNED INFLOKAIDAB, bool JOJMAHGOLHM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1E07F60", Offset = "0x1E07360", VA = "0x181E07F60")]
	private T INPEAJIBFIL<T>(GameObject PLJPLOAFBDE, Transform PDIGOPINEPN, EIMNFPLGNED INFLOKAIDAB, bool JOJMAHGOLHM, out GameObject KHGPIEDGPJM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1E08570", Offset = "0x1E07970", VA = "0x181E08570")]
	private T KFGBDPDPODM<T>(GameObject OPNEJBACONM, EIMNFPLGNED INFLOKAIDAB, bool JOJMAHGOLHM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4D5A6F0", Offset = "0x4D59AF0", VA = "0x184D5A6F0")]
	private void IHKMEOBGNJE(Component GDJGGGALMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4D5A140", Offset = "0x4D59540", VA = "0x184D5A140")]
	private void EFLINGNIEHG(Component GDJGGGALMJF, EIMNFPLGNED INFLOKAIDAB, bool JOJMAHGOLHM, [Optional] Type JKLCGHMPHAL, [Optional] Type ILKFGBGMCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4D5A5B0", Offset = "0x4D599B0", VA = "0x184D5A5B0")]
	private void FFGMLHPGPBI(GameObject OPNEJBACONM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct EIMNFPLGNED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Dictionary<Type, object> HCFOOAOOLHO;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x21D3740", Offset = "0x21D2B40", VA = "0x1821D3740")]
	public EIMNFPLGNED GCIBODCAOML<T>(T DNMFIMLLNDL)
	{
		return default(EIMNFPLGNED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1E07AE0", Offset = "0x1E06EE0", VA = "0x181E07AE0")]
	public T CEDINIMJBIG<T>(T JJNACOJNFEB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2831BB0", Offset = "0x2830FB0", VA = "0x182831BB0")]
	public bool OPAPHKJEMEB<T>(out T DNMFIMLLNDL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct OIPKJFOKBFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public bool EBBEJBHAIEC;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xD81DC0", Offset = "0xD811C0", VA = "0x180D81DC0")]
	public OIPKJFOKBFH(bool FENNGCOJHNM)
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
				[Cpp2IlInjected.Address(RVA = "0x4D5D8E0", Offset = "0x4D5CCE0", VA = "0x184D5D8E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x4D5D8D0", Offset = "0x4D5CCD0", VA = "0x184D5D8D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4D5D500", Offset = "0x4D5C900", VA = "0x184D5D500")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class FLAAPDCJBBE
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly List<URPLight> EBCALOOOKNN;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly Vector3 JBCMNABNGBJ;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly Vector3 FEJKAMGELGD;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Camera CNOPHMGBIJC;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const string HKBLELCPBFM = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public const ALLPCPPPGOA NOICFDOBOHF = ALLPCPPPGOA.Water;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<Renderer> FELBMEMGELN;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static AmbientMode PACHNGBHEGO;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static Color CLBELMKFCPD;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static Color FFGCJMLKNJE;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color JGCDKFGACIC;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Cubemap JHEEAPPBHAO;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static bool OCBLELKICFE;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera HGDGHJCKMNN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4D5C8E0", Offset = "0x4D5BCE0", VA = "0x184D5C8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4D5BB70", Offset = "0x4D5AF70", VA = "0x184D5BB70")]
	public static void ICENKPNKCEP(Vector3 LKIBOHDIPND, Quaternion IGIFLMBFAAB, ImposterRenderConfig LLCDCKIOGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4D5BDF0", Offset = "0x4D5B1F0", VA = "0x184D5BDF0")]
	private static void JHEJGHMPPKJ(Vector3 LKIBOHDIPND, Quaternion IGIFLMBFAAB, URPLight EJAGLIHCDLJ, ImposterRenderConfig.LightConfig HHBCEMAEKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4D5B4F0", Offset = "0x4D5A8F0", VA = "0x184D5B4F0")]
	public static void GFIIPLIDKCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4D5AEE0", Offset = "0x4D5A2E0", VA = "0x184D5AEE0")]
	private static void DCNFEFGJPOH(int JNCCJKEKECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4D5B370", Offset = "0x4D5A770", VA = "0x184D5B370")]
	public static void FBBJCJLPIDF(ImposterRenderConfig LLCDCKIOGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4D5C7E0", Offset = "0x4D5BBE0", VA = "0x184D5C7E0")]
	public static void NONMPDOECNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4D5C130", Offset = "0x4D5B530", VA = "0x184D5C130")]
	public static void JNEHDANGMGM(GameObject LLHDGOGNMLD, RenderTexture LPFBNIKMKHL, ImposterRenderConfig LLCDCKIOGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4D5C2C0", Offset = "0x4D5B6C0", VA = "0x184D5C2C0")]
	private static void NMJHDIEBIMH(GameObject LLHDGOGNMLD, RenderTexture LPFBNIKMKHL, ImposterRenderConfig LLCDCKIOGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4D5B5D0", Offset = "0x4D5A9D0", VA = "0x184D5B5D0")]
	private static void GGOKKKJPJMI(GameObject LLHDGOGNMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4D5B1E0", Offset = "0x4D5A5E0", VA = "0x184D5B1E0")]
	public static void EJCLGHLKDOK(List<Renderer> IDEKFEJDDMM, List<Material> HCKEKBDKPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4D5B860", Offset = "0x4D5AC60", VA = "0x184D5B860")]
	private static void HLPINJCHAIH(GameObject PLJPLOAFBDE, Vector3 EADOLNAHNBJ, Vector3 DIKAPPABKLD, float JLAHLHPMMFA, out Vector3 MLEJMAOPDMK, out Quaternion KDNFPKNNGMP, out float IGIFDDJKPJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4D5AE40", Offset = "0x4D5A240", VA = "0x184D5AE40")]
	public static RenderTexture AGCGCOMJBEF(int PGJMBKLMNBH, int FBPGHOCBINA)
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
		public struct JNEAELHACNL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public DDLKDBDLBFL BNFIAGBGNLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public GameObject DAGGFIEEBLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public RenderTexture DKJEAFMNOIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public ImposterRenderConfig GBKLHOBLBEN;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x1111200", Offset = "0x1110600", VA = "0x181111200")]
			public JNEAELHACNL(DDLKDBDLBFL OJCDBLDFDBK, GameObject EKIGDAGIODL, RenderTexture LPFBNIKMKHL, ImposterRenderConfig KILNCOKIHMD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const int IKMEFONBPKM = 1;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private const int AJMONCDCGDF = 6;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static global::EGDFIGJNIDH<JNEAELHACNL, RenderTexture> NJHIFHAEEHE;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly List<JNEAELHACNL> MJPHCMDDHAK;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int MOEONMCKFBD
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8ACA10", Offset = "0x8ABE10", VA = "0x1808ACA10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4D59C00", Offset = "0x4D59000", VA = "0x184D59C00")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject LLHDGOGNMLD, RenderTexture LPFBNIKMKHL, ImposterRenderConfig LLCDCKIOGJA, CancellationToken MBCDFHLPEDE, bool IDBLMNBKDPF = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4D59720", Offset = "0x4D58B20", VA = "0x184D59720", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4D59B70", Offset = "0x4D58F70", VA = "0x184D59B70", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4D59840", Offset = "0x4D58C40", VA = "0x184D59840")]
		private static Task<RenderTexture> KOCBBCKJPCM(JNEAELHACNL LBODEJCPPKA, CancellationToken MBCDFHLPEDE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4D59FE0", Offset = "0x4D593E0", VA = "0x184D59FE0")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HAEMGHNAAMP
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static byte[] AOHONNKPCGG;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static int JJMCEBLKFDI;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static int GDGIIBGHMLJ;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static BigInteger PODBKFNIFLC;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
	public HAEMGHNAAMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4D5CC30", Offset = "0x4D5C030", VA = "0x184D5CC30")]
	private static string BJIMPFHNNLK(byte[] FFOHEAHJJEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4D5CD30", Offset = "0x4D5C130", VA = "0x184D5CD30")]
	public static string LFJGIPFBMOM(byte[] MFCIHENGNMD, bool MBOLNOOKBJO)
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
		[Cpp2IlInjected.Address(RVA = "0x554AB0", Offset = "0x553EB0", VA = "0x180554AB0")]
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
