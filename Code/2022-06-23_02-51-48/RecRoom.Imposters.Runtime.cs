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
public class ImposterPreviewCustomFraming : MonoBehaviour, MKCBCLJGHMP
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float MDNFIKJBKEL = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573B10", VA = "0x180574910", Slot = "4")]
	public void PrepareImposter(HPHDLMCLBBA KBKLLMLPIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4F837E0", Offset = "0x4F829E0", VA = "0x184F837E0")]
	public void SetReferencePoint(Vector3 LFGBEDCJDFB, Quaternion KEHDGCBDDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4F83540", Offset = "0x4F82740", VA = "0x184F83540")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4F83770", Offset = "0x4F82970", VA = "0x184F83770")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x12AA9D0", Offset = "0x12A9BD0", VA = "0x1812AA9D0")]
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
		[MCJNGMPEMLD(EAEFHBMFHFN.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const int KPDKHEKGOGG = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int JOADKJGJJAE = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly List<Material> KFEOBOHCNEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool FEMEJNKJNHM;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4F839A0", Offset = "0x4F82BA0", VA = "0x184F839A0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4F838A0", Offset = "0x4F82AA0", VA = "0x184F838A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4F83B80", Offset = "0x4F82D80", VA = "0x184F83B80")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class CenterInImposter : MonoBehaviour, MKCBCLJGHMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4F81690", Offset = "0x4F80890", VA = "0x184F81690", Slot = "4")]
		public void PrepareImposter(HPHDLMCLBBA KBKLLMLPIOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8C3B50", Offset = "0x8C2D50", VA = "0x1808C3B50")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8C3B50", Offset = "0x8C2D50", VA = "0x1808C3B50")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MKCBCLJGHMP
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(HPHDLMCLBBA KBKLLMLPIOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NKFBMLFBMKD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> LMNNOMICBNN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> NEOIABOLFPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface PEJNMEKIEIH
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AINPGKJGGCG(params Type[] GNBMPEAFGKB);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJILGCPFCLN(params Type[] GNBMPEAFGKB);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject HGKOOLCMBNF(GameObject LKMDFAIEDCO, Transform KJHHLEFOCFM, bool KKJHEDJIGCI = false);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T HGKOOLCMBNF<T>(T LKMDFAIEDCO, Transform KJHHLEFOCFM, bool KKJHEDJIGCI = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T HGKOOLCMBNF<T>(GameObject LKMDFAIEDCO, Transform KJHHLEFOCFM, bool KKJHEDJIGCI = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject HGKOOLCMBNF(GameObject LKMDFAIEDCO, Transform KJHHLEFOCFM, HPHDLMCLBBA KBKLLMLPIOJ, bool KKJHEDJIGCI);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T HGKOOLCMBNF<T>(GameObject LKMDFAIEDCO, Transform KJHHLEFOCFM, HPHDLMCLBBA KBKLLMLPIOJ, bool KKJHEDJIGCI) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T HGKOOLCMBNF<T>(T LKMDFAIEDCO, Transform KJHHLEFOCFM, HPHDLMCLBBA KBKLLMLPIOJ, bool KKJHEDJIGCI) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class FDOLFAMBCIK : IDisposable, PEJNMEKIEIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HashSet<Type> GHFDODNAOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly HashSet<Type> KEPLNPKDDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Transform ENCHOOFNDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<Component> CPCFGMANMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> HOIODLPBGBP;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4F82950", Offset = "0x4F81B50", VA = "0x184F82950")]
	[CJGIHNHLEPI]
	public static void ICKPCOLEPHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4F82C20", Offset = "0x4F81E20", VA = "0x184F82C20")]
	[Preserve]
	public FDOLFAMBCIK([AFDDHPBBNKH(null)] NKFBMLFBMKD BPBCIIKOAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4F82730", Offset = "0x4F81930", VA = "0x184F82730", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4F82130", Offset = "0x4F81330", VA = "0x184F82130", Slot = "5")]
	public void AINPGKJGGCG(params Type[] GNBMPEAFGKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4F82BD0", Offset = "0x4F81DD0", VA = "0x184F82BD0", Slot = "6")]
	public void NJILGCPFCLN(params Type[] GNBMPEAFGKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4F82830", Offset = "0x4F81A30", VA = "0x184F82830", Slot = "7")]
	public GameObject HGKOOLCMBNF(GameObject LKMDFAIEDCO, Transform KJHHLEFOCFM, bool KKJHEDJIGCI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x193AA10", Offset = "0x1939C10", VA = "0x18193AA10", Slot = "8")]
	public T HGKOOLCMBNF<T>(T LKMDFAIEDCO, Transform KJHHLEFOCFM, bool KKJHEDJIGCI = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x193AA80", Offset = "0x1939C80", VA = "0x18193AA80", Slot = "9")]
	public T HGKOOLCMBNF<T>(GameObject LKMDFAIEDCO, Transform KJHHLEFOCFM, bool KKJHEDJIGCI = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4F828C0", Offset = "0x4F81AC0", VA = "0x184F828C0", Slot = "10")]
	public GameObject HGKOOLCMBNF(GameObject LKMDFAIEDCO, Transform KJHHLEFOCFM, HPHDLMCLBBA KBKLLMLPIOJ, bool KKJHEDJIGCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x193AAB0", Offset = "0x1939CB0", VA = "0x18193AAB0", Slot = "11")]
	public T HGKOOLCMBNF<T>(GameObject LKMDFAIEDCO, Transform KJHHLEFOCFM, HPHDLMCLBBA KBKLLMLPIOJ, bool KKJHEDJIGCI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x193A980", Offset = "0x1939B80", VA = "0x18193A980", Slot = "12")]
	public T HGKOOLCMBNF<T>(T LKMDFAIEDCO, Transform KJHHLEFOCFM, HPHDLMCLBBA KBKLLMLPIOJ, bool KKJHEDJIGCI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x193AB00", Offset = "0x1939D00", VA = "0x18193AB00")]
	private T HGKOOLCMBNF<T>(GameObject LKMDFAIEDCO, Transform KJHHLEFOCFM, HPHDLMCLBBA KBKLLMLPIOJ, bool KKJHEDJIGCI, out GameObject PGNCNDEDIHA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x193B0C0", Offset = "0x193A2C0", VA = "0x18193B0C0")]
	private T KHNHNLBAODD<T>(GameObject JMCMCLEMHIC, HPHDLMCLBBA KBKLLMLPIOJ, bool KKJHEDJIGCI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4F82AB0", Offset = "0x4F81CB0", VA = "0x184F82AB0")]
	private void NINLAFGNMKD(Component FHHNJKNMCDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4F82180", Offset = "0x4F81380", VA = "0x184F82180")]
	private void DGDNINCKDPD(Component FHHNJKNMCDB, HPHDLMCLBBA KBKLLMLPIOJ, bool KKJHEDJIGCI, [Optional] Type FDLFNGFBBOL, [Optional] Type CIFCOLOMIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4F825F0", Offset = "0x4F817F0", VA = "0x184F825F0")]
	private void DMDCKEPIKAH(GameObject JMCMCLEMHIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct HPHDLMCLBBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<Type, object> LGIHMMFMJPP;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1A1E940", Offset = "0x1A1DB40", VA = "0x181A1E940")]
	public HPHDLMCLBBA BIGDAPHKFNM<T>(T AMJBPOHLKIK)
	{
		return default(HPHDLMCLBBA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x193C560", Offset = "0x193B760", VA = "0x18193C560")]
	public T DCCAFIHBGKB<T>(T IDNAMJJDDGK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x282E530", Offset = "0x282D730", VA = "0x18282E530")]
	public bool FJDDEAOBJHK<T>(out T AMJBPOHLKIK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct IIMKBMMBFGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public bool LCPHBCDFFGN;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8A9810", Offset = "0x8A8A10", VA = "0x1808A9810")]
	public IIMKBMMBFGP(bool ECIFLKKPHIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct NODLKJOPPNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly bool DKGKCOJIGMC;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4F85A10", Offset = "0x4F84C10", VA = "0x184F85A10")]
	public NODLKJOPPNN(bool IAHDMBEOFBA)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8C3B50", Offset = "0x8C2D50", VA = "0x1808C3B50")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ScaleInImposter : MonoBehaviour, MKCBCLJGHMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4F85A20", Offset = "0x4F84C20", VA = "0x184F85A20", Slot = "4")]
		public void PrepareImposter(HPHDLMCLBBA KBKLLMLPIOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8C3B50", Offset = "0x8C2D50", VA = "0x1808C3B50")]
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
				[Cpp2IlInjected.Address(RVA = "0x4F83C00", Offset = "0x4F82E00", VA = "0x184F83C00")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x4F83BF0", Offset = "0x4F82DF0", VA = "0x184F83BF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F83820", Offset = "0x4F82A20", VA = "0x184F83820")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MNLKKDEINBE
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly List<URPLight> OLGIEGGDBBJ;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly Vector3 NEMGPEFCBFK;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Vector3 PJAAFIMJLBI;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static Camera ENJHBEBCLMM;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public const string LHLHPMLCBKO = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public const KKMBNMGCOFB NJMMMBPJOKB = KKMBNMGCOFB.Water;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly List<Renderer> FNDFMMEIBIN;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static AmbientMode NHFJPIFHMHN;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color NDKMKHCIEEP;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static Color ACIGAKBOKDL;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static Color HLFBDEHEPAG;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static Cubemap FOIEELCINAA;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static bool IBCIOCDNDAE;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera ALIILCNNCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4F85490", Offset = "0x4F84690", VA = "0x184F85490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4F83DB0", Offset = "0x4F82FB0", VA = "0x184F83DB0")]
	public static void CEFHLGHGDBO(Vector3 JONEPEPOELK, Quaternion PIKPEFGMDCH, ImposterRenderConfig BJIJFFGKLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4F84130", Offset = "0x4F83330", VA = "0x184F84130")]
	private static void DOEFOEFIJKE(Vector3 JONEPEPOELK, Quaternion PIKPEFGMDCH, URPLight ABPBIKPIGMI, ImposterRenderConfig.LightConfig CJLILAFEOED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4F853B0", Offset = "0x4F845B0", VA = "0x184F853B0")]
	public static void NEKAKBHPDPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4F850B0", Offset = "0x4F842B0", VA = "0x184F850B0")]
	private static void MAMJJMOLDBB(int NFHBIMFLFDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4F84470", Offset = "0x4F83670", VA = "0x184F84470")]
	public static void FGFNLJAFLFF(ImposterRenderConfig BJIJFFGKLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4F84030", Offset = "0x4F83230", VA = "0x184F84030")]
	public static void DMFDFDHPHKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4F83C20", Offset = "0x4F82E20", VA = "0x184F83C20")]
	public static void AOKGMFIDDIE(GameObject PDECKHANPOK, RenderTexture EPDBKCHKEGL, ImposterRenderConfig BJIJFFGKLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4F84900", Offset = "0x4F83B00", VA = "0x184F84900")]
	private static void JMLGEGIFBBG(GameObject PDECKHANPOK, RenderTexture EPDBKCHKEGL, ImposterRenderConfig BJIJFFGKLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4F84E20", Offset = "0x4F84020", VA = "0x184F84E20")]
	private static void LMJNEOGIOHD(GameObject PDECKHANPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4F85690", Offset = "0x4F84890", VA = "0x184F85690")]
	public static void OCNCMMGLDMN(List<Renderer> ICEJDGHOOKK, List<Material> BEFJGNLJAJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4F845F0", Offset = "0x4F837F0", VA = "0x184F845F0")]
	private static void GLCBKGINCPN(GameObject LKMDFAIEDCO, Vector3 GJOHAHOEFOA, Vector3 OLNPMHKBJOE, float ONFADKHMAIB, out Vector3 DCJEGJGMFOH, out Quaternion FAFCCMLPACA, out float MMJGPCMHDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4F85820", Offset = "0x4F84A20", VA = "0x184F85820")]
	public static RenderTexture OGPJNHKJFDG(int MLMOINPPPFB, int LDAGEPJGJAH)
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
		public struct BIHDIAMLDKC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public FOIHHBNLNAM KDLMOPBIKOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public GameObject JMOKDPIDFJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public RenderTexture JMHIKKHLMGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public ImposterRenderConfig KIEOPAOBNPL;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x46ACB60", Offset = "0x46ABD60", VA = "0x1846ACB60")]
			public BIHDIAMLDKC(FOIHHBNLNAM BOLGHLAFKJM, GameObject DCDBGEDGEFJ, RenderTexture EPDBKCHKEGL, ImposterRenderConfig ECECGBCPLOP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const int BDGPPLKEPDK = 1;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int AKBCJOLIICC = 6;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static global::ANBDCELLPFH<BIHDIAMLDKC, RenderTexture> NCDGMGDAAPL;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static readonly List<BIHDIAMLDKC> KLELKEKHEAJ;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int PBGAOHGFFKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x66BEB0", Offset = "0x66B0B0", VA = "0x18066BEB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4F81CF0", Offset = "0x4F80EF0", VA = "0x184F81CF0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject PDECKHANPOK, RenderTexture EPDBKCHKEGL, ImposterRenderConfig BJIJFFGKLCD, CancellationToken MNPKHBAPNDC, bool MMBGOHGBAAE = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4F81810", Offset = "0x4F80A10", VA = "0x184F81810", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4F81C60", Offset = "0x4F80E60", VA = "0x184F81C60", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4F81930", Offset = "0x4F80B30", VA = "0x184F81930")]
		private static Task<RenderTexture> MPEEACMOMOL(BIHDIAMLDKC JFKFJBJIMPO, CancellationToken MNPKHBAPNDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4F820D0", Offset = "0x4F812D0", VA = "0x184F820D0")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FNGEDJFFIEL
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static byte[] JKCEPOEAODE;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int HMIFPHDBAAL;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static int JLNLCKONFPG;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static BigInteger EBGIPPCOABB;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
	public FNGEDJFFIEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4F82F50", Offset = "0x4F82150", VA = "0x184F82F50")]
	private static string CHCKGNJAKBF(byte[] CJCOEBBKILK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4F83050", Offset = "0x4F82250", VA = "0x184F83050")]
	public static string PEFJMDOFNMG(byte[] PKBLLNJJAGK, bool HCHELKBPHNG)
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
		[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
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
