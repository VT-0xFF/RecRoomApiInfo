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
public class ImposterPreviewCustomFraming : MonoBehaviour, EIOGPNBODKM
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float DFEEICIFEFJ = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "4")]
	public void PrepareImposter(ANFKOBHJBDA FHLNMMPFILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6082380", Offset = "0x6081380", VA = "0x186082380")]
	public void SetReferencePoint(Vector3 CEKGMIFMNMB, Quaternion OBFOOPGJBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60821F0", Offset = "0x60811F0", VA = "0x1860821F0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6082350", Offset = "0x6081350", VA = "0x186082350")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x182A990", Offset = "0x1829990", VA = "0x18182A990")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct IHDKPOEEKBM
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static IHDKPOEEKBM AMJOFGCMDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public float ECFJNEAIHAM;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2BC2480", Offset = "0x2BC1480", VA = "0x182BC2480")]
	public IHDKPOEEKBM(float HCBPHPMFPJB)
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
		[OBCALLPEFCG(CABHOIOLNCF.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const int BNDKFKFCGLB = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const int KHBHJLFGAAG = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly List<Material> CMBPDPJJLLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool EFDFGPNHODF;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x60824F0", Offset = "0x60814F0", VA = "0x1860824F0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6082400", Offset = "0x6081400", VA = "0x186082400")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6082730", Offset = "0x6081730", VA = "0x186082730")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class CenterInImposter : MonoBehaviour, EIOGPNBODKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6080730", Offset = "0x607F730", VA = "0x186080730", Slot = "4")]
		public void PrepareImposter(ANFKOBHJBDA FHLNMMPFILI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD75170", Offset = "0xD74170", VA = "0x180D75170")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xD75170", Offset = "0xD74170", VA = "0x180D75170")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EIOGPNBODKM
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(ANFKOBHJBDA FHLNMMPFILI);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface IJDGDANDEMG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> NPGHLJCICFI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> MPNOGFNPBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HKELJJJKLJG
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JFAMMMBMLFC(params Type[] ELKKGBGGKPO);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HFJIDCBOMBL(params Type[] ELKKGBGGKPO);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject KECJCOHHHKF(GameObject GLJOCEFKOFB, Transform ICMEPOIJCJO, bool OOEDFLOIILN = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T KECJCOHHHKF<T>(T GLJOCEFKOFB, Transform ICMEPOIJCJO, bool OOEDFLOIILN = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T KECJCOHHHKF<T>(GameObject GLJOCEFKOFB, Transform ICMEPOIJCJO, bool OOEDFLOIILN = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject KECJCOHHHKF(GameObject GLJOCEFKOFB, Transform ICMEPOIJCJO, ANFKOBHJBDA FHLNMMPFILI, bool OOEDFLOIILN);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T KECJCOHHHKF<T>(GameObject GLJOCEFKOFB, Transform ICMEPOIJCJO, ANFKOBHJBDA FHLNMMPFILI, bool OOEDFLOIILN) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T KECJCOHHHKF<T>(T GLJOCEFKOFB, Transform ICMEPOIJCJO, ANFKOBHJBDA FHLNMMPFILI, bool OOEDFLOIILN) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class IDMDOFLEHHL : IDisposable, HKELJJJKLJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly HashSet<Type> HAJFEKAEFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly HashSet<Type> CIJPHDCEOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Transform IAGGJPDEEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly List<Component> MHCPLNOMIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> CHFCKOKDPDF;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x60815F0", Offset = "0x60805F0", VA = "0x1860815F0")]
	[EJICMPGFCBP(CIKEJIGJNLD.None)]
	public static void MCFDGBFIIAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6081D70", Offset = "0x6080D70", VA = "0x186081D70")]
	[Preserve]
	public IDMDOFLEHHL([ELDNEOCBGIN(null)] IJDGDANDEMG PEOIOCGBCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6081330", Offset = "0x6080330", VA = "0x186081330", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6081480", Offset = "0x6080480", VA = "0x186081480", Slot = "5")]
	public void JFAMMMBMLFC(params Type[] ELKKGBGGKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6081430", Offset = "0x6080430", VA = "0x186081430", Slot = "6")]
	public void HFJIDCBOMBL(params Type[] ELKKGBGGKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x60814D0", Offset = "0x60804D0", VA = "0x1860814D0", Slot = "7")]
	public GameObject KECJCOHHHKF(GameObject GLJOCEFKOFB, Transform ICMEPOIJCJO, bool OOEDFLOIILN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x226B430", Offset = "0x226A430", VA = "0x18226B430", Slot = "8")]
	public T KECJCOHHHKF<T>(T GLJOCEFKOFB, Transform ICMEPOIJCJO, bool OOEDFLOIILN = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x226B4F0", Offset = "0x226A4F0", VA = "0x18226B4F0", Slot = "9")]
	public T KECJCOHHHKF<T>(GameObject GLJOCEFKOFB, Transform ICMEPOIJCJO, bool OOEDFLOIILN = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6081560", Offset = "0x6080560", VA = "0x186081560", Slot = "10")]
	public GameObject KECJCOHHHKF(GameObject GLJOCEFKOFB, Transform ICMEPOIJCJO, ANFKOBHJBDA FHLNMMPFILI, bool OOEDFLOIILN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x226B4A0", Offset = "0x226A4A0", VA = "0x18226B4A0", Slot = "11")]
	public T KECJCOHHHKF<T>(GameObject GLJOCEFKOFB, Transform ICMEPOIJCJO, ANFKOBHJBDA FHLNMMPFILI, bool OOEDFLOIILN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x226AE70", Offset = "0x2269E70", VA = "0x18226AE70", Slot = "12")]
	public T KECJCOHHHKF<T>(T GLJOCEFKOFB, Transform ICMEPOIJCJO, ANFKOBHJBDA FHLNMMPFILI, bool OOEDFLOIILN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x226AF00", Offset = "0x2269F00", VA = "0x18226AF00")]
	private T KECJCOHHHKF<T>(GameObject GLJOCEFKOFB, Transform ICMEPOIJCJO, ANFKOBHJBDA FHLNMMPFILI, bool OOEDFLOIILN, out GameObject LDLLIAHIJOC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x226A910", Offset = "0x2269910", VA = "0x18226A910")]
	private T HFNPAMLMIBL<T>(GameObject NCAOMIEGHPA, ANFKOBHJBDA FHLNMMPFILI, bool OOEDFLOIILN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x60816F0", Offset = "0x60806F0", VA = "0x1860816F0")]
	private void OJJEOBIECKM(Component KMJCJNGOPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6081820", Offset = "0x6080820", VA = "0x186081820")]
	private void OPNJKBLGAKB(Component KMJCJNGOPHM, ANFKOBHJBDA FHLNMMPFILI, bool OOEDFLOIILN, bool GJJACLLNMMJ, [Optional] Type DDDHOEGHJCI, [Optional] Type BAEFBFCLGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x60811D0", Offset = "0x60801D0", VA = "0x1860811D0")]
	private void BLGHLJALFDD(GameObject NCAOMIEGHPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct ANFKOBHJBDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Dictionary<Type, object> BEOMPJGIPAF;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x227E090", Offset = "0x227D090", VA = "0x18227E090")]
	public ANFKOBHJBDA FAFPJPFNCCD<T>(T ONHHPHCFHJN)
	{
		return default(ANFKOBHJBDA);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x227DF70", Offset = "0x227CF70", VA = "0x18227DF70")]
	public T CIGAFCHFFML<T>(T PGBDPKDFJME)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x227E7C0", Offset = "0x227D7C0", VA = "0x18227E7C0")]
	public bool MDMOKHFDALA<T>(out T ONHHPHCFHJN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct FONKMOIHLCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public bool KJGCEEBHHGN;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xDDE110", Offset = "0xDDD110", VA = "0x180DDE110")]
	public FONKMOIHLCA(bool JPALJPBPKCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct PJAJINMHKOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly bool DNOOOGKJMJP;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6082E10", Offset = "0x6081E10", VA = "0x186082E10")]
	public PJAJINMHKOH(bool FLCBDDCGHLF)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD75170", Offset = "0xD74170", VA = "0x180D75170")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ScaleInImposter : MonoBehaviour, EIOGPNBODKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6084FA0", Offset = "0x6083FA0", VA = "0x186084FA0", Slot = "4")]
		public void PrepareImposter(ANFKOBHJBDA FHLNMMPFILI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xD75170", Offset = "0xD74170", VA = "0x180D75170")]
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
				[Cpp2IlInjected.Address(RVA = "0x6082DF0", Offset = "0x6081DF0", VA = "0x186082DF0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6082DE0", Offset = "0x6081DE0", VA = "0x186082DE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x60823C0", Offset = "0x60813C0", VA = "0x1860823C0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class PMDLMNFEKDE
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<URPLight> DPLIEKILMJB;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly Vector3 OGNBLIKFMOJ;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly Vector3 LFAPJFIGMAI;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static Camera IIOHPLDADAL;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public const string GHLKBJKGPMD = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public const DAHFCCFBOLK LOPPPHEJBCG = DAHFCCFBOLK.Water;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static readonly List<Renderer> HAJJCDEGFAO;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static AmbientMode FAPIMBDHMIN;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static Color HIJCNNMINDN;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static Color POIIIFGHDBP;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static Color LAGBLLMIFPB;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static Cubemap DBPNFFJACAL;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static bool ELDPALHJFFM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera IPGCEJBAAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6082FC0", Offset = "0x6081FC0", VA = "0x186082FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6084110", Offset = "0x6083110", VA = "0x186084110")]
	public static void LKJNKCPHFHK(Vector3 LAKLOBEJDAI, Quaternion AEEBOLOKJJC, ImposterRenderConfig ILLGLKOBHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6083E00", Offset = "0x6082E00", VA = "0x186083E00")]
	private static void LCPKKPMPKAO(Vector3 LAKLOBEJDAI, Quaternion AEEBOLOKJJC, URPLight FCEBMPIPALJ, ImposterRenderConfig.LightConfig JCFPCJHANDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6083540", Offset = "0x6082540", VA = "0x186083540")]
	public static void IGKDCODBPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6084740", Offset = "0x6083740", VA = "0x186084740")]
	private static void OKNHKOLKIIH(int DLFEMGDIGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x60833C0", Offset = "0x60823C0", VA = "0x1860833C0")]
	public static void GODCKKEBKDP(ImposterRenderConfig ILLGLKOBHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6084390", Offset = "0x6083390", VA = "0x186084390")]
	public static void MEHNMGOMLCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x60831F0", Offset = "0x60821F0", VA = "0x1860831F0")]
	public static void CDLHOPBGENM(GameObject GAPLDMNMIKA, RenderTexture PDDLJOCHIHI, ImposterRenderConfig ILLGLKOBHMD, IHDKPOEEKBM MLJMGIEPDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6083630", Offset = "0x6082630", VA = "0x186083630")]
	private static void JNLEGCEEGDB(GameObject GAPLDMNMIKA, RenderTexture PDDLJOCHIHI, ImposterRenderConfig ILLGLKOBHMD, IHDKPOEEKBM MLJMGIEPDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6084490", Offset = "0x6083490", VA = "0x186084490")]
	private static void MHCIOLFKEIF(GameObject GAPLDMNMIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6082E20", Offset = "0x6081E20", VA = "0x186082E20")]
	public static void BDKEKMGDAHB(List<Renderer> DJELLLDCBJI, List<Material> MJFLJMJJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6084B10", Offset = "0x6083B10", VA = "0x186084B10")]
	public static void PLHNFLONECK(GameObject GLJOCEFKOFB, Vector3 LKIOECLOHGG, Vector3 EOKPOCBFDID, float MDDBACJHGLE, IHDKPOEEKBM MLJMGIEPDEF, out Vector3 HFHGBNKDHOF, out Quaternion DPBOMEHKHON, out float GBOPOJGLIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6083D60", Offset = "0x6082D60", VA = "0x186083D60")]
	public static RenderTexture KEKKIAHHLLL(int LBHCEBCJMEF, int MMPBKAKMEAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6083B30", Offset = "0x6082B30", VA = "0x186083B30")]
	public static void KEDAAHEODIG()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public struct PPLHCHFEBDH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public HGIFEALIPIB NOFEKBFPLGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public GameObject DIILDKICCDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public RenderTexture AINHCLOJPJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public ImposterRenderConfig HOCDEMDOHEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public IHDKPOEEKBM IHDKPOEEKBM;

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6084F30", Offset = "0x6083F30", VA = "0x186084F30")]
			public PPLHCHFEBDH(HGIFEALIPIB HNFKIAKOCJI, GameObject LCAKFMIKAHF, RenderTexture PDDLJOCHIHI, ImposterRenderConfig JBEOMNDDOCO, IHDKPOEEKBM MLJMGIEPDEF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int NCLGBGBEHAG = 1;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int OMBGOMIELJA = 6;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static global::FMDELPMLIIP<PPLHCHFEBDH, RenderTexture> MIKHNCEFLEJ;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static readonly List<PPLHCHFEBDH> GIMJGKAEOFN;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int CAFGCCELAIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7B1C90", Offset = "0x7B0C90", VA = "0x1807B1C90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6080C90", Offset = "0x607FC90", VA = "0x186080C90")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject GAPLDMNMIKA, RenderTexture PDDLJOCHIHI, ImposterRenderConfig ILLGLKOBHMD, IHDKPOEEKBM MLJMGIEPDEF, CancellationToken NIEOBBGKEFJ, bool HGEENIHMGNN = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6080890", Offset = "0x607F890", VA = "0x186080890", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6080BF0", Offset = "0x607FBF0", VA = "0x186080BF0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6080A20", Offset = "0x607FA20", VA = "0x186080A20")]
		private static Task<RenderTexture> OHPHPDKNJDF(PPLHCHFEBDH CHKABKNGDMP, CancellationToken NIEOBBGKEFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6081160", Offset = "0x6080160", VA = "0x186081160")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KJPGGDKBIND
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static byte[] CFKIOPKCLEE;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static int PODCBGNELNF;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static int DIHMJLLDPDD;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static BigInteger MMOCJBNMKFM;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
	public KJPGGDKBIND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6082B00", Offset = "0x6081B00", VA = "0x186082B00")]
	private static string EAILEDEPOEM(byte[] OPGAGDBKIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x60827B0", Offset = "0x60817B0", VA = "0x1860827B0")]
	public static string AMGIJLDMAAM(byte[] CCFMJPPGPDK, bool IEFNHKOPNBP)
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
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
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
