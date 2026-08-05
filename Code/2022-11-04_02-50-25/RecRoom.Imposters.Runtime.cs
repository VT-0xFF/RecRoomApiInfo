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
public class ImposterPreviewCustomFraming : MonoBehaviour, JMABJLPNEGH
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float DBJKOACIIJG = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "4")]
	public void PrepareImposter(BNLKOAIBODD DALCKALNCCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5F762F0", Offset = "0x5F756F0", VA = "0x185F762F0")]
	public void SetReferencePoint(Vector3 CFOIIIPLIFA, Quaternion HKBDKOEBLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5F76160", Offset = "0x5F75560", VA = "0x185F76160")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5F762C0", Offset = "0x5F756C0", VA = "0x185F762C0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x19253B0", Offset = "0x19247B0", VA = "0x1819253B0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct HHMCKJOGJFP
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static HHMCKJOGJFP CDOPNMBPMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public float LLIADKAPIKA;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2C43F20", Offset = "0x2C43320", VA = "0x182C43F20")]
	public HHMCKJOGJFP(float BFMAMPGCMNG)
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
		[GCACDPGGFIJ(HNCKKAEODPP.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const int HALLENDMBOO = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const int MHHCJOIJEDN = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly List<Material> NIAHDIGKOFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool GGEGIINBCDO;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5F76460", Offset = "0x5F75860", VA = "0x185F76460")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5F76370", Offset = "0x5F75770", VA = "0x185F76370")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5F766A0", Offset = "0x5F75AA0", VA = "0x185F766A0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class CenterInImposter : MonoBehaviour, JMABJLPNEGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5F75050", Offset = "0x5F74450", VA = "0x185F75050", Slot = "4")]
		public void PrepareImposter(BNLKOAIBODD DALCKALNCCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xFA9F60", Offset = "0xFA9360", VA = "0x180FA9F60")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xFA9F60", Offset = "0xFA9360", VA = "0x180FA9F60")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JMABJLPNEGH
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(BNLKOAIBODD DALCKALNCCE);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface DGLBMGLFEGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> BEOLIBNJOMH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> OJCGLOFLBGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DGPFFIHIPNA
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PHMAGKILEDI(params Type[] LLKPCNGMKKA);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OGHLLPIILKI(params Type[] LLKPCNGMKKA);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject FAKNINDNFPD(GameObject LPLLOMCCPLH, Transform BLENCGKHIJI, bool FGACMDHDDEN = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T FAKNINDNFPD<T>(T LPLLOMCCPLH, Transform BLENCGKHIJI, bool FGACMDHDDEN = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T FAKNINDNFPD<T>(GameObject LPLLOMCCPLH, Transform BLENCGKHIJI, bool FGACMDHDDEN = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject FAKNINDNFPD(GameObject LPLLOMCCPLH, Transform BLENCGKHIJI, BNLKOAIBODD DALCKALNCCE, bool FGACMDHDDEN);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T FAKNINDNFPD<T>(GameObject LPLLOMCCPLH, Transform BLENCGKHIJI, BNLKOAIBODD DALCKALNCCE, bool FGACMDHDDEN) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T FAKNINDNFPD<T>(T LPLLOMCCPLH, Transform BLENCGKHIJI, BNLKOAIBODD DALCKALNCCE, bool FGACMDHDDEN) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class KJBEFCCEMGA : IDisposable, DGPFFIHIPNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly HashSet<Type> OFPMOAMPKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly HashSet<Type> BIOGEHHJGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Transform GPEEFOBGCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly List<Component> PBIPCLEBNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> CDAPCFGAJKB;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5F791C0", Offset = "0x5F785C0", VA = "0x185F791C0")]
	[AMOLIILEGPJ(OPIFOMJNBJD.None)]
	public static void IFHPELFOHHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5F79360", Offset = "0x5F78760", VA = "0x185F79360")]
	[Preserve]
	public KJBEFCCEMGA([FFFBKAEBNFI(null)] DGLBMGLFEGJ DKCDPHGANLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5F78AC0", Offset = "0x5F77EC0", VA = "0x185F78AC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5F79310", Offset = "0x5F78710", VA = "0x185F79310", Slot = "5")]
	public void PHMAGKILEDI(params Type[] LLKPCNGMKKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5F792C0", Offset = "0x5F786C0", VA = "0x185F792C0", Slot = "6")]
	public void OGHLLPIILKI(params Type[] LLKPCNGMKKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5F790A0", Offset = "0x5F784A0", VA = "0x185F790A0", Slot = "7")]
	public GameObject FAKNINDNFPD(GameObject LPLLOMCCPLH, Transform BLENCGKHIJI, bool FGACMDHDDEN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2BB39B0", Offset = "0x2BB2DB0", VA = "0x182BB39B0", Slot = "8")]
	public T FAKNINDNFPD<T>(T LPLLOMCCPLH, Transform BLENCGKHIJI, bool FGACMDHDDEN = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2BB3980", Offset = "0x2BB2D80", VA = "0x182BB3980", Slot = "9")]
	public T FAKNINDNFPD<T>(GameObject LPLLOMCCPLH, Transform BLENCGKHIJI, bool FGACMDHDDEN = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5F79130", Offset = "0x5F78530", VA = "0x185F79130", Slot = "10")]
	public GameObject FAKNINDNFPD(GameObject LPLLOMCCPLH, Transform BLENCGKHIJI, BNLKOAIBODD DALCKALNCCE, bool FGACMDHDDEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2BB3930", Offset = "0x2BB2D30", VA = "0x182BB3930", Slot = "11")]
	public T FAKNINDNFPD<T>(GameObject LPLLOMCCPLH, Transform BLENCGKHIJI, BNLKOAIBODD DALCKALNCCE, bool FGACMDHDDEN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2BB3F50", Offset = "0x2BB3350", VA = "0x182BB3F50", Slot = "12")]
	public T FAKNINDNFPD<T>(T LPLLOMCCPLH, Transform BLENCGKHIJI, BNLKOAIBODD DALCKALNCCE, bool FGACMDHDDEN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2BB3A20", Offset = "0x2BB2E20", VA = "0x182BB3A20")]
	private T FAKNINDNFPD<T>(GameObject LPLLOMCCPLH, Transform BLENCGKHIJI, BNLKOAIBODD DALCKALNCCE, bool FGACMDHDDEN, out GameObject PEGJBCGLLMD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2BB3FE0", Offset = "0x2BB33E0", VA = "0x182BB3FE0")]
	private T OPMALEKGBNB<T>(GameObject MGDBDEJKIMA, BNLKOAIBODD DALCKALNCCE, bool FGACMDHDDEN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5F78990", Offset = "0x5F77D90", VA = "0x185F78990")]
	private void CPHNLDPLLKB(Component NDJEINDKPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5F78BC0", Offset = "0x5F77FC0", VA = "0x185F78BC0")]
	private void EIJMGJDBIJL(Component NDJEINDKPBB, BNLKOAIBODD DALCKALNCCE, bool FGACMDHDDEN, [Optional] Type DAIDJPJJILL, [Optional] Type IILKPGKDGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5F78830", Offset = "0x5F77C30", VA = "0x185F78830")]
	private void AGLEINBKBNP(GameObject MGDBDEJKIMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct BNLKOAIBODD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Dictionary<Type, object> MBNLBEKABCA;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2E757C0", Offset = "0x2E74BC0", VA = "0x182E757C0")]
	public BNLKOAIBODD JKDFMHKJMMK<T>(T FMOFDIPGIHC)
	{
		return default(BNLKOAIBODD);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2E74F00", Offset = "0x2E74300", VA = "0x182E74F00")]
	public T DPALGOGEJPD<T>(T NANCDEAMBKG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2E75020", Offset = "0x2E74420", VA = "0x182E75020")]
	public bool DPPKACEDDDN<T>(out T FMOFDIPGIHC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct DFNFLAACGKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public bool JBHPHJIFNFM;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xF541A0", Offset = "0xF535A0", VA = "0x180F541A0")]
	public DFNFLAACGKC(bool AMNGJCNEMHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct NJCAKADABNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly bool PIFFPBKNFGO;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5F79840", Offset = "0x5F78C40", VA = "0x185F79840")]
	public NJCAKADABNO(bool FNLMLNBOKKI)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xFA9F60", Offset = "0xFA9360", VA = "0x180FA9F60")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ScaleInImposter : MonoBehaviour, JMABJLPNEGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5F79850", Offset = "0x5F78C50", VA = "0x185F79850", Slot = "4")]
		public void PrepareImposter(BNLKOAIBODD DALCKALNCCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xFA9F60", Offset = "0xFA9360", VA = "0x180FA9F60")]
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
				[Cpp2IlInjected.Address(RVA = "0x5F79820", Offset = "0x5F78C20", VA = "0x185F79820")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5F79810", Offset = "0x5F78C10", VA = "0x185F79810")]
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
		[Cpp2IlInjected.Address(RVA = "0x5F76330", Offset = "0x5F75730", VA = "0x185F76330")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class JPJBHMEKOGN
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<URPLight> AMMNOGFJODA;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly Vector3 NIJODANDPEK;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly Vector3 EBIGKOABILN;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static Camera GNPBMKHLCGD;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public const string ECDJGJLHLIG = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public const FIDPIFAIEON INAHILPCPHB = FIDPIFAIEON.Water;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static readonly List<Renderer> ALNFAMJMIHB;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static AmbientMode CDKPGLBNIPP;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static Color ECJPJPFGGGF;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static Color FLAMHBPIOGP;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static Color PGNMLJKGBDI;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static Cubemap HKMOCJHFMIO;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static bool LFAAHLMKCFB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera GFJEEEHEGLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5F78110", Offset = "0x5F77510", VA = "0x185F78110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5F77750", Offset = "0x5F76B50", VA = "0x185F77750")]
	public static void ECJOCHOHFAE(Vector3 OHACMNNMILF, Quaternion FLIEFBKKFJG, ImposterRenderConfig EDHNLPDCCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5F76720", Offset = "0x5F75B20", VA = "0x185F76720")]
	private static void AHFCGPHPDAM(Vector3 OHACMNNMILF, Quaternion FLIEFBKKFJG, URPLight CACGJFKBBGG, ImposterRenderConfig.LightConfig ICHDNOCKIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5F78340", Offset = "0x5F77740", VA = "0x185F78340")]
	public static void MGBNHDLOLMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5F77D40", Offset = "0x5F77140", VA = "0x185F77D40")]
	private static void KNKPLPFCEKE(int JIOIKOIINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5F76A30", Offset = "0x5F75E30", VA = "0x185F76A30")]
	public static void AIMOHOPOLBM(ImposterRenderConfig EDHNLPDCCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5F77C40", Offset = "0x5F77040", VA = "0x185F77C40")]
	public static void KCECAMCHOCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5F77A70", Offset = "0x5F76E70", VA = "0x185F77A70")]
	public static void IHEAJIBNIBN(GameObject APBNGJJJNAI, RenderTexture BIHPNNBGLKP, ImposterRenderConfig EDHNLPDCCNB, HHMCKJOGJFP FOFGBEFCOPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5F77250", Offset = "0x5F76650", VA = "0x185F77250")]
	private static void CNCDMGEFLEO(GameObject APBNGJJJNAI, RenderTexture BIHPNNBGLKP, ImposterRenderConfig EDHNLPDCCNB, HHMCKJOGJFP FOFGBEFCOPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5F78430", Offset = "0x5F77830", VA = "0x185F78430")]
	private static void MGGKMPMBEAM(GameObject APBNGJJJNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5F770B0", Offset = "0x5F764B0", VA = "0x185F770B0")]
	public static void BOJNFANBDBG(List<Renderer> DLODCGNKCFG, List<Material> IBFAJKJKPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5F76DE0", Offset = "0x5F761E0", VA = "0x185F76DE0")]
	public static void ANFKAAGIJJG(GameObject LPLLOMCCPLH, Vector3 JEAMOCMEOAP, Vector3 GBKONCBPBME, float IADHEMBGPAJ, HHMCKJOGJFP FOFGBEFCOPF, out Vector3 GJLBCJHLPGK, out Quaternion DBBNFAMJONM, out float MKKGHJLDNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5F779D0", Offset = "0x5F76DD0", VA = "0x185F779D0")]
	public static RenderTexture HIJCNMGIGDM(int ILNHJCKAKCL, int LGPCJCBIAHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5F76BB0", Offset = "0x5F75FB0", VA = "0x185F76BB0")]
	public static void AINCKAELOJI()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public struct LHEFBALAHFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public ONOPCBLOPNP PIDNIIEOHDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public GameObject GAKEOHNFNKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public RenderTexture EACLKMJDILC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public ImposterRenderConfig MNOOIHFJJCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public HHMCKJOGJFP HHMCKJOGJFP;

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5F797A0", Offset = "0x5F78BA0", VA = "0x185F797A0")]
			public LHEFBALAHFE(ONOPCBLOPNP BCHMFIOFJEC, GameObject HKEMPNJEILE, RenderTexture BIHPNNBGLKP, ImposterRenderConfig LCINJBJKBCH, HHMCKJOGJFP FOFGBEFCOPF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int PHHPLLFIBDE = 1;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int AHIKCAOLLOF = 6;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static global::HEENDAAJDNM<LHEFBALAHFE, RenderTexture> HMIOPHBCCHL;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static readonly List<LHEFBALAHFE> KLPJCBDLEBC;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int BJPJOMFBKMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7C2510", Offset = "0x7C1910", VA = "0x1807C2510")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5F755B0", Offset = "0x5F749B0", VA = "0x185F755B0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject APBNGJJJNAI, RenderTexture BIHPNNBGLKP, ImposterRenderConfig EDHNLPDCCNB, HHMCKJOGJFP FOFGBEFCOPF, CancellationToken BJBDGBAHFDE, bool JONDCIGOBJN = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5F751B0", Offset = "0x5F745B0", VA = "0x185F751B0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5F75510", Offset = "0x5F74910", VA = "0x185F75510", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5F75340", Offset = "0x5F74740", VA = "0x185F75340")]
		private static Task<RenderTexture> DJJBNCNNDHE(LHEFBALAHFE EBGJMHKEHHJ, CancellationToken BJBDGBAHFDE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5F75A80", Offset = "0x5F74E80", VA = "0x185F75A80")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class ILPMCCIAAOO
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static byte[] EFCNCHAHCDJ;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static int IFHOEBNLHGF;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static int CLAMAIDAIOM;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static BigInteger ADBDIIFGHNH;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public ILPMCCIAAOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5F75E80", Offset = "0x5F75280", VA = "0x185F75E80")]
	private static string PINDCOCBOMG(byte[] ABBMKKCGFBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5F75B30", Offset = "0x5F74F30", VA = "0x185F75B30")]
	public static string OEPGMAKGOND(byte[] OGILIIFBKAD, bool GHCIENBALCN)
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
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
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
