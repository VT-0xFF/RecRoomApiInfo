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
public class ImposterPreviewCustomFraming : MonoBehaviour, PKHFNKAIGPD
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float EFMCOAKLAFG = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E80", Offset = "0x5E4E80", VA = "0x1805E5E80", Slot = "4")]
	public void PrepareImposter(JGKGPPBMMPH JAGFDHABEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x57F2AB0", Offset = "0x57F1AB0", VA = "0x1857F2AB0")]
	public void SetReferencePoint(Vector3 OOJHNKALAAE, Quaternion LOMDKHFBCEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x57F2810", Offset = "0x57F1810", VA = "0x1857F2810")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x57F2A40", Offset = "0x57F1A40", VA = "0x1857F2A40")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x11463C0", Offset = "0x11453C0", VA = "0x1811463C0")]
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
		[DMMPNBPEKOM(AACKNMMIFMG.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const int JELMMMGJONM = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int DIIHANAKHLJ = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly List<Material> DLNDAFPGOJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool NBFKNEBMNFA;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x57F2C70", Offset = "0x57F1C70", VA = "0x1857F2C70")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x57F2B70", Offset = "0x57F1B70", VA = "0x1857F2B70")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x57F2E50", Offset = "0x57F1E50", VA = "0x1857F2E50")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class CenterInImposter : MonoBehaviour, PKHFNKAIGPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x57EEB70", Offset = "0x57EDB70", VA = "0x1857EEB70", Slot = "4")]
		public void PrepareImposter(JGKGPPBMMPH JAGFDHABEOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xEA89A0", Offset = "0xEA79A0", VA = "0x180EA89A0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xEA89A0", Offset = "0xEA79A0", VA = "0x180EA89A0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PKHFNKAIGPD
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(JGKGPPBMMPH JAGFDHABEOM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FPOMJFKEAAK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> PCKKDHAJJCE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> KMAKALBGAGL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GPBEMECIOHD
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OMEIODJMCKO(params Type[] AKGOADBOKFP);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KHAKNBJFFOE(params Type[] AKGOADBOKFP);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject PMHFLHGPLEL(GameObject DOJHMGHFEFN, Transform ACNNFDIAAFM, bool CJHACAPMPHO = false);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T PMHFLHGPLEL<T>(T DOJHMGHFEFN, Transform ACNNFDIAAFM, bool CJHACAPMPHO = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T PMHFLHGPLEL<T>(GameObject DOJHMGHFEFN, Transform ACNNFDIAAFM, bool CJHACAPMPHO = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject PMHFLHGPLEL(GameObject DOJHMGHFEFN, Transform ACNNFDIAAFM, JGKGPPBMMPH JAGFDHABEOM, bool CJHACAPMPHO);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T PMHFLHGPLEL<T>(GameObject DOJHMGHFEFN, Transform ACNNFDIAAFM, JGKGPPBMMPH JAGFDHABEOM, bool CJHACAPMPHO) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T PMHFLHGPLEL<T>(T DOJHMGHFEFN, Transform ACNNFDIAAFM, JGKGPPBMMPH JAGFDHABEOM, bool CJHACAPMPHO) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class GNCDDDMNLBN : IDisposable, GPBEMECIOHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HashSet<Type> GDENFJLJCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly HashSet<Type> ADMILFCNANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Transform BPEJANCAHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<Component> KBFPEMBLNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> GFBIFIOCLNI;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x57F19F0", Offset = "0x57F09F0", VA = "0x1857F19F0")]
	[HJKJOFMFDMI]
	public static void CKGHFAKJFGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x57F24E0", Offset = "0x57F14E0", VA = "0x1857F24E0")]
	[Preserve]
	public GNCDDDMNLBN([MOLIPDINIIE(null)] FPOMJFKEAAK FLEOJGCDHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x57F1B50", Offset = "0x57F0B50", VA = "0x1857F1B50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x57F2250", Offset = "0x57F1250", VA = "0x1857F2250", Slot = "5")]
	public void OMEIODJMCKO(params Type[] AKGOADBOKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x57F20C0", Offset = "0x57F10C0", VA = "0x1857F20C0", Slot = "6")]
	public void KHAKNBJFFOE(params Type[] AKGOADBOKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x57F22A0", Offset = "0x57F12A0", VA = "0x1857F22A0", Slot = "7")]
	public GameObject PMHFLHGPLEL(GameObject DOJHMGHFEFN, Transform ACNNFDIAAFM, bool CJHACAPMPHO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x20B4310", Offset = "0x20B3310", VA = "0x1820B4310", Slot = "8")]
	public T PMHFLHGPLEL<T>(T DOJHMGHFEFN, Transform ACNNFDIAAFM, bool CJHACAPMPHO = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x20B3CC0", Offset = "0x20B2CC0", VA = "0x1820B3CC0", Slot = "9")]
	public T PMHFLHGPLEL<T>(GameObject DOJHMGHFEFN, Transform ACNNFDIAAFM, bool CJHACAPMPHO = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x57F2330", Offset = "0x57F1330", VA = "0x1857F2330", Slot = "10")]
	public GameObject PMHFLHGPLEL(GameObject DOJHMGHFEFN, Transform ACNNFDIAAFM, JGKGPPBMMPH JAGFDHABEOM, bool CJHACAPMPHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x20B42C0", Offset = "0x20B32C0", VA = "0x1820B42C0", Slot = "11")]
	public T PMHFLHGPLEL<T>(GameObject DOJHMGHFEFN, Transform ACNNFDIAAFM, JGKGPPBMMPH JAGFDHABEOM, bool CJHACAPMPHO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x20B3CF0", Offset = "0x20B2CF0", VA = "0x1820B3CF0", Slot = "12")]
	public T PMHFLHGPLEL<T>(T DOJHMGHFEFN, Transform ACNNFDIAAFM, JGKGPPBMMPH JAGFDHABEOM, bool CJHACAPMPHO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x20B3D80", Offset = "0x20B2D80", VA = "0x1820B3D80")]
	private T PMHFLHGPLEL<T>(GameObject DOJHMGHFEFN, Transform ACNNFDIAAFM, JGKGPPBMMPH JAGFDHABEOM, bool CJHACAPMPHO, out GameObject ELEKMHEFEJE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x20B3840", Offset = "0x20B2840", VA = "0x1820B3840")]
	private T KDJGIPDIHJH<T>(GameObject PKGBHIMGLPM, JGKGPPBMMPH JAGFDHABEOM, bool CJHACAPMPHO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x57F23C0", Offset = "0x57F13C0", VA = "0x1857F23C0")]
	private void PMOICLJEDIH(Component LIHCFPMBOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x57F1C50", Offset = "0x57F0C50", VA = "0x1857F1C50")]
	private void IIELBOENGLA(Component LIHCFPMBOOM, JGKGPPBMMPH JAGFDHABEOM, bool CJHACAPMPHO, [Optional] Type AFKMCJEFNKA, [Optional] Type GPGBCNHDAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x57F2110", Offset = "0x57F1110", VA = "0x1857F2110")]
	private void LEEEKPMDDJB(GameObject PKGBHIMGLPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct JGKGPPBMMPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<Type, object> ADLLBGNMHNA;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1DD0520", Offset = "0x1DCF520", VA = "0x181DD0520")]
	public JGKGPPBMMPH GALDMPBHILF<T>(T CDAABFMDHFI)
	{
		return default(JGKGPPBMMPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x20B5BF0", Offset = "0x20B4BF0", VA = "0x1820B5BF0")]
	public T FGPHONIFMEK<T>(T NIPAKKKNCAD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x24DFAA0", Offset = "0x24DEAA0", VA = "0x1824DFAA0")]
	public bool EAMIBAOAOOK<T>(out T CDAABFMDHFI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct IEMPOFGPMKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public bool AECFMOJAFLM;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xE3AC90", Offset = "0xE39C90", VA = "0x180E3AC90")]
	public IEMPOFGPMKB(bool KFGCMBOIHOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct OMOCPEHCIOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly bool JMKMCLAPCGI;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x57F2EF0", Offset = "0x57F1EF0", VA = "0x1857F2EF0")]
	public OMOCPEHCIOG(bool LFJJHFKOCEH)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xEA89A0", Offset = "0xEA79A0", VA = "0x180EA89A0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ScaleInImposter : MonoBehaviour, PKHFNKAIGPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x57F2F00", Offset = "0x57F1F00", VA = "0x1857F2F00", Slot = "4")]
		public void PrepareImposter(JGKGPPBMMPH JAGFDHABEOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xEA89A0", Offset = "0xEA79A0", VA = "0x180EA89A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x57F2ED0", Offset = "0x57F1ED0", VA = "0x1857F2ED0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x57F2EC0", Offset = "0x57F1EC0", VA = "0x1857F2EC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x57F2AF0", Offset = "0x57F1AF0", VA = "0x1857F2AF0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class DPJCEHNKIFK
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly List<URPLight> PGHMLAJLMEC;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly Vector3 DECJBDMHMAJ;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Vector3 HINEFEMKGJF;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static Camera CLMNGPJEGAN;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public const string LHDOJNKBODB = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public const DGDCHBPKGJJ DMIFEDELBGK = DGDCHBPKGJJ.Water;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly List<Renderer> OMCIGJJICBH;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static AmbientMode CLFGIKLHLEF;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color FPFOCEMLAJG;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static Color HPFKEEBHPAB;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static Color BDKIGONMGBH;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static Cubemap IELPCMGPPOO;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static bool FENOAAGPFHD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera NKIEPDBBFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x57EF350", Offset = "0x57EE350", VA = "0x1857EF350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x57EF0D0", Offset = "0x57EE0D0", VA = "0x1857EF0D0")]
	public static void BPHALGFPPJJ(Vector3 DGBPJEJNMPG, Quaternion JPKCABLCKMD, ImposterRenderConfig PEHIBLCNMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x57EECF0", Offset = "0x57EDCF0", VA = "0x1857EECF0")]
	private static void AAHMDPEECMM(Vector3 DGBPJEJNMPG, Quaternion JPKCABLCKMD, URPLight MKIPHGIEOKO, ImposterRenderConfig.LightConfig MBNELMEOOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x57EF650", Offset = "0x57EE650", VA = "0x1857EF650")]
	public static void IDAHFOHJLCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x57EFF60", Offset = "0x57EEF60", VA = "0x1857EFF60")]
	private static void JFDODIIPEGI(int EELDPHHDNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x57EF730", Offset = "0x57EE730", VA = "0x1857EF730")]
	public static void IGDFJMPPFMM(ImposterRenderConfig PEHIBLCNMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x57EF550", Offset = "0x57EE550", VA = "0x1857EF550")]
	public static void IDADEJLBOEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x57F0260", Offset = "0x57EF260", VA = "0x1857F0260")]
	public static void JJAKADGLCFO(GameObject EIGLDDOAJPN, RenderTexture HGMOOJHNDLL, ImposterRenderConfig PEHIBLCNMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x57EF8B0", Offset = "0x57EE8B0", VA = "0x1857EF8B0")]
	private static void IIMOIAEDHFL(GameObject EIGLDDOAJPN, RenderTexture HGMOOJHNDLL, ImposterRenderConfig PEHIBLCNMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x57F03F0", Offset = "0x57EF3F0", VA = "0x1857F03F0")]
	private static void KAKGJADGCCI(GameObject EIGLDDOAJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x57EFDD0", Offset = "0x57EEDD0", VA = "0x1857EFDD0")]
	public static void ILCHHEAKBCC(List<Renderer> FHBGNHNIDAP, List<Material> GLMCKBGCFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x57F0680", Offset = "0x57EF680", VA = "0x1857F0680")]
	private static void MLFLNHGLPAE(GameObject DOJHMGHFEFN, Vector3 DHLHCKLLKHL, Vector3 MOLAFDLGGKC, float IHPBKLPBABP, out Vector3 JEMPODIPBNM, out Quaternion GABODMBCIML, out float AIILPALJDME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x57EF030", Offset = "0x57EE030", VA = "0x1857EF030")]
	public static RenderTexture BCLEIOFMEKD(int GHGJDDLLLBP, int EKAJBPONJJD)
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
		public struct AKDJFCCDFJE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public IHDMPJIPDML LNFKFGPPLNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public GameObject NECKJKMOHFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public RenderTexture AINMAOEHFPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public ImposterRenderConfig MCKOFEMDMOO;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x4B51EC0", Offset = "0x4B50EC0", VA = "0x184B51EC0")]
			public AKDJFCCDFJE(IHDMPJIPDML FNNLBDHIJGE, GameObject HMGFBFIIGHA, RenderTexture HGMOOJHNDLL, ImposterRenderConfig OFOLEIKOEIG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const int DIGPEOIHGLE = 1;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int NNGCKPGGEOA = 6;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static global::IACEFLFLKCG<AKDJFCCDFJE, RenderTexture> NNAHJJAHAGM;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static readonly List<AKDJFCCDFJE> OHCFFCLFPKM;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int GCFCHOJFKLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x91D010", Offset = "0x91C010", VA = "0x18091D010")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x57F0FC0", Offset = "0x57EFFC0", VA = "0x1857F0FC0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject EIGLDDOAJPN, RenderTexture HGMOOJHNDLL, ImposterRenderConfig PEHIBLCNMBE, CancellationToken JNDOKGNDNMO, bool AFLNPHJPJMC = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x57F0AE0", Offset = "0x57EFAE0", VA = "0x1857F0AE0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x57F0F30", Offset = "0x57EFF30", VA = "0x1857F0F30", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x57F0C00", Offset = "0x57EFC00", VA = "0x1857F0C00")]
		private static Task<RenderTexture> HKOBHIBBHIM(AKDJFCCDFJE FMABNDHGMLJ, CancellationToken JNDOKGNDNMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x57F13A0", Offset = "0x57F03A0", VA = "0x1857F13A0")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EJDCELNBKPC
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static byte[] LJMFDKKPNGA;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int EGAGCALIJCE;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static int AMPJBPFCKBN;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static BigInteger PJENGKNDPGI;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
	public EJDCELNBKPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x57F1400", Offset = "0x57F0400", VA = "0x1857F1400")]
	private static string HACCFPOCPGB(byte[] GMPKOOIGMDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x57F1500", Offset = "0x57F0500", VA = "0x1857F1500")]
	public static string NOKDDKHJKOE(byte[] FCLFFFPNPCK, bool DHIAJMPKALJ)
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
		[Cpp2IlInjected.Address(RVA = "0x5E7AB0", Offset = "0x5E6AB0", VA = "0x1805E7AB0")]
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
