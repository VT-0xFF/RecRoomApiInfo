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
public class ImposterPreviewCustomFraming : MonoBehaviour, LFFFEJLLNDK
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float DNNFGGHFJPP = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x527E80", Offset = "0x527080", VA = "0x180527E80", Slot = "4")]
	public void PrepareImposter(KLLLKGDHCKN DIAMGKKPFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4BD02D0", Offset = "0x4BCF4D0", VA = "0x184BD02D0")]
	public void SetReferencePoint(Vector3 PGMGNJHJMJH, Quaternion DPMPGJGOGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4BD0030", Offset = "0x4BCF230", VA = "0x184BD0030")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4BD0260", Offset = "0x4BCF460", VA = "0x184BD0260")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xD8DC00", Offset = "0xD8CE00", VA = "0x180D8DC00")]
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
		[NLJOPEHPBNE(DIBELKIFKMM.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const int OJLIOCMGPPP = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int HKALDOIIDNO = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly List<Material> KHDBBKHNLAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool LNGINAANLHK;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4BD0490", Offset = "0x4BCF690", VA = "0x184BD0490")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4BD0390", Offset = "0x4BCF590", VA = "0x184BD0390")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4BD0670", Offset = "0x4BCF870", VA = "0x184BD0670")]
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
		[Cpp2IlInjected.Address(RVA = "0xD72680", Offset = "0xD71880", VA = "0x180D72680")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LFFFEJLLNDK
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(KLLLKGDHCKN DIAMGKKPFJA);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DEBHEPDNOIE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> PMNOMHHAGPO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> DNKEAMHAIGF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface ELJEEKOMAHL
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DMNKFCBAPHK(params Type[] EADAMJFHAPH);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MJPIFKIKMKN(params Type[] EADAMJFHAPH);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject NJCMJLBIAMP(GameObject MIBCPBFGHKI, Transform KJAPOBPIAAM, bool JMJIMFPEAFP = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T NJCMJLBIAMP<T>(T MIBCPBFGHKI, Transform KJAPOBPIAAM, bool JMJIMFPEAFP = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T NJCMJLBIAMP<T>(GameObject MIBCPBFGHKI, Transform KJAPOBPIAAM, bool JMJIMFPEAFP = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject NJCMJLBIAMP(GameObject MIBCPBFGHKI, Transform KJAPOBPIAAM, KLLLKGDHCKN DIAMGKKPFJA, bool JMJIMFPEAFP);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T NJCMJLBIAMP<T>(GameObject MIBCPBFGHKI, Transform KJAPOBPIAAM, KLLLKGDHCKN DIAMGKKPFJA, bool JMJIMFPEAFP) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T NJCMJLBIAMP<T>(T MIBCPBFGHKI, Transform KJAPOBPIAAM, KLLLKGDHCKN DIAMGKKPFJA, bool JMJIMFPEAFP) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class ICPGPIGPGKK : IDisposable, ELJEEKOMAHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly HashSet<Type> MDDJLCOFNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HashSet<Type> HIOMEIFIGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Transform EHNLFNPAFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly List<Component> BJBBIDHCENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> FGNEGOGMLIN;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4BCF230", Offset = "0x4BCE430", VA = "0x184BCF230")]
	[MEFKHICHEBG]
	public static void ANGKEEOEFPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4BCFD20", Offset = "0x4BCEF20", VA = "0x184BCFD20")]
	[Preserve]
	public ICPGPIGPGKK([NIPPPCCBAGO(null)] DEBHEPDNOIE AGDDHHOEMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4BCF3E0", Offset = "0x4BCE5E0", VA = "0x184BCF3E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4BCF390", Offset = "0x4BCE590", VA = "0x184BCF390", Slot = "5")]
	public void DMNKFCBAPHK(params Type[] EADAMJFHAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4BCFBB0", Offset = "0x4BCEDB0", VA = "0x184BCFBB0", Slot = "6")]
	public void MJPIFKIKMKN(params Type[] EADAMJFHAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4BCFC00", Offset = "0x4BCEE00", VA = "0x184BCFC00", Slot = "7")]
	public GameObject NJCMJLBIAMP(GameObject MIBCPBFGHKI, Transform KJAPOBPIAAM, bool JMJIMFPEAFP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1E4B7C0", Offset = "0x1E4A9C0", VA = "0x181E4B7C0", Slot = "8")]
	public T NJCMJLBIAMP<T>(T MIBCPBFGHKI, Transform KJAPOBPIAAM, bool JMJIMFPEAFP = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1E4B910", Offset = "0x1E4AB10", VA = "0x181E4B910", Slot = "9")]
	public T NJCMJLBIAMP<T>(GameObject MIBCPBFGHKI, Transform KJAPOBPIAAM, bool JMJIMFPEAFP = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4BCFC90", Offset = "0x4BCEE90", VA = "0x184BCFC90", Slot = "10")]
	public GameObject NJCMJLBIAMP(GameObject MIBCPBFGHKI, Transform KJAPOBPIAAM, KLLLKGDHCKN DIAMGKKPFJA, bool JMJIMFPEAFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1E4B830", Offset = "0x1E4AA30", VA = "0x181E4B830", Slot = "11")]
	public T NJCMJLBIAMP<T>(GameObject MIBCPBFGHKI, Transform KJAPOBPIAAM, KLLLKGDHCKN DIAMGKKPFJA, bool JMJIMFPEAFP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1E4B880", Offset = "0x1E4AA80", VA = "0x181E4B880", Slot = "12")]
	public T NJCMJLBIAMP<T>(T MIBCPBFGHKI, Transform KJAPOBPIAAM, KLLLKGDHCKN DIAMGKKPFJA, bool JMJIMFPEAFP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1E4B940", Offset = "0x1E4AB40", VA = "0x181E4B940")]
	private T NJCMJLBIAMP<T>(GameObject MIBCPBFGHKI, Transform KJAPOBPIAAM, KLLLKGDHCKN DIAMGKKPFJA, bool JMJIMFPEAFP, out GameObject FKEAAGOMDEN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1F66930", Offset = "0x1F65B30", VA = "0x181F66930")]
	private T BEDOLCNDIHJ<T>(GameObject KONKHHPIEFL, KLLLKGDHCKN DIAMGKKPFJA, bool JMJIMFPEAFP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4BCF620", Offset = "0x4BCE820", VA = "0x184BCF620")]
	private void JMOGPCLMDCN(Component POKGMNGDFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4BCF740", Offset = "0x4BCE940", VA = "0x184BCF740")]
	private void LLNJDJFMJPE(Component POKGMNGDFOO, KLLLKGDHCKN DIAMGKKPFJA, bool JMJIMFPEAFP, [Optional] Type MJPEGPEFIEO, [Optional] Type BADFICIIJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4BCF4E0", Offset = "0x4BCE6E0", VA = "0x184BCF4E0")]
	private void IGBIGMKOLNP(GameObject KONKHHPIEFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct KLLLKGDHCKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Dictionary<Type, object> PKFAEAPAABE;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x205C480", Offset = "0x205B680", VA = "0x18205C480")]
	public KLLLKGDHCKN PECNJBNEMJB<T>(T LEFAEJLKHHB)
	{
		return default(KLLLKGDHCKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1E53010", Offset = "0x1E52210", VA = "0x181E53010")]
	public T FDILAOMJFDA<T>(T KBCIJCBGHFN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2929920", Offset = "0x2928B20", VA = "0x182929920")]
	public bool ICBEDKAPJKO<T>(out T LEFAEJLKHHB)
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
				[Cpp2IlInjected.Address(RVA = "0x4BD06F0", Offset = "0x4BCF8F0", VA = "0x184BD06F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x4BD06E0", Offset = "0x4BCF8E0", VA = "0x184BD06E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BD0310", Offset = "0x4BCF510", VA = "0x184BD0310")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class AIMGKAGHPEE
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly List<URPLight> NFLKHLMOHNK;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly Vector3 HBLKALLPMKA;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly Vector3 FJKCLOOOIOK;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static Camera DJMHJFMNKPP;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public const string FOKFEACAAJJ = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const OLHGEENHJCI GMLGMGJOGDC = OLHGEENHJCI.Water;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<Renderer> NODOIDAHFGP;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static AmbientMode OFIFELLEOCI;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static Color KNJENLGPIME;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static Color NGAJICCLDKK;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static Color KALMMODLCDK;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Cubemap OFDNGJGODGP;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static bool FBAIOHJMBEK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera AJFNEMBFPIM
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4BCE110", Offset = "0x4BCD310", VA = "0x184BCE110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4BCE540", Offset = "0x4BCD740", VA = "0x184BCE540")]
	public static void PPFEEEGKDMI(Vector3 OKAOEIIDHCF, Quaternion FECPILFHHEM, ImposterRenderConfig HCBJJLNFFAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4BCD780", Offset = "0x4BCC980", VA = "0x184BCD780")]
	private static void GEJIPIDGFGI(Vector3 OKAOEIIDHCF, Quaternion FECPILFHHEM, URPLight PLDALPILBHA, ImposterRenderConfig.LightConfig LINNCHBGGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4BCDAC0", Offset = "0x4BCCCC0", VA = "0x184BCDAC0")]
	public static void INMINMIIJCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4BCD480", Offset = "0x4BCC680", VA = "0x184BCD480")]
	private static void FMCJNMNGNGE(int AHBKDNPJHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4BCDBA0", Offset = "0x4BCCDA0", VA = "0x184BCDBA0")]
	public static void IOKHKMHNHEJ(ImposterRenderConfig HCBJJLNFFAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4BCD1F0", Offset = "0x4BCC3F0", VA = "0x184BCD1F0")]
	public static void ELIGHEJFGNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4BCD2F0", Offset = "0x4BCC4F0", VA = "0x184BCD2F0")]
	public static void FJJGFAEJBHG(GameObject JMEMPHJECGM, RenderTexture COFEIENCIHG, ImposterRenderConfig HCBJJLNFFAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4BCCA10", Offset = "0x4BCBC10", VA = "0x184BCCA10")]
	private static void AKOJGNLHCDM(GameObject JMEMPHJECGM, RenderTexture COFEIENCIHG, ImposterRenderConfig HCBJJLNFFAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4BCCF60", Offset = "0x4BCC160", VA = "0x184BCCF60")]
	private static void DIPCBFMNLHJ(GameObject JMEMPHJECGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4BCE310", Offset = "0x4BCD510", VA = "0x184BCE310")]
	public static void OBIPLIIDJGK(List<Renderer> EDFLLJJIHPK, List<Material> LHPDFPKHFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4BCDD20", Offset = "0x4BCCF20", VA = "0x184BCDD20")]
	private static void NBJCBBKJEBM(List<Renderer> EDFLLJJIHPK, Vector3 GLLHCNAJMOC, Vector3 INAKJMBFICM, float ILDGJFFEHFC, out Vector3 AIEBANMGAKF, out Quaternion DCPDNHIJIFI, out float PKBPJMLLBJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4BCE4A0", Offset = "0x4BCD6A0", VA = "0x184BCE4A0")]
	public static RenderTexture PCOCMBBJAEF(int PJIIABFMCEC, int JDCAGDMDMDO)
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
		public struct OPFIEPEHBBC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public FLLJLIAPHLF HBBJKGPMEEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public GameObject CEPCICPHADP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public RenderTexture CKIFDGIDDDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public ImposterRenderConfig DCFKJEACHOH;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x14CB840", Offset = "0x14CAA40", VA = "0x1814CB840")]
			public OPFIEPEHBBC(FLLJLIAPHLF FKBBEAOAIAA, GameObject ACHBLBIFPOA, RenderTexture COFEIENCIHG, ImposterRenderConfig JNEFEFEEINM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const int OPJKAHMMEKG = 1;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const int HAOCJDNKAKI = 6;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static global::CMDKEABLBID<OPFIEPEHBBC, RenderTexture> AAEBDJNCIBA;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static readonly List<OPFIEPEHBBC> ELFELLDENFD;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int MCONPAEMMIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x881A10", Offset = "0x880C10", VA = "0x180881A10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4BCEDF0", Offset = "0x4BCDFF0", VA = "0x184BCEDF0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject JMEMPHJECGM, RenderTexture COFEIENCIHG, ImposterRenderConfig HCBJJLNFFAE, CancellationToken OOBFLHIIBLI, bool LAODGEJLOPE = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4BCE910", Offset = "0x4BCDB10", VA = "0x184BCE910", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4BCED60", Offset = "0x4BCDF60", VA = "0x184BCED60", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4BCEA30", Offset = "0x4BCDC30", VA = "0x184BCEA30")]
		private static Task<RenderTexture> HHGJAGKOMOK(OPFIEPEHBBC CEODBIKLDDD, CancellationToken OOBFLHIIBLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4BCF1D0", Offset = "0x4BCE3D0", VA = "0x184BCF1D0")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PEGOPLHHMHI
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static byte[] HIBFFCCJJHD;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static int BICBCGELOBK;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static int ILHMFLHJGFF;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static BigInteger OJJMNJJEBED;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
	public PEGOPLHHMHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4BD0A40", Offset = "0x4BCFC40", VA = "0x184BD0A40")]
	private static string MCCHLMPJJNK(byte[] DCOPGELFIOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4BD0710", Offset = "0x4BCF910", VA = "0x184BD0710")]
	public static string ACFPKMGBPMA(byte[] GMBNEFEOHLO, bool EDLKFPFOADI)
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
		[Cpp2IlInjected.Address(RVA = "0x529AB0", Offset = "0x528CB0", VA = "0x180529AB0")]
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
