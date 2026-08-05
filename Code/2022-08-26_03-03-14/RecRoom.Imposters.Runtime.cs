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
public class ImposterPreviewCustomFraming : MonoBehaviour, JBJHFKIJGPN
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float PPMHBNNGOIE = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "4")]
	public void PrepareImposter(HCHCHAGJBNM BEMMPFFAJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5832E40", Offset = "0x5831A40", VA = "0x185832E40")]
	public void SetReferencePoint(Vector3 BDAEFIHNJEN, Quaternion IBJBIKHAMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5832BA0", Offset = "0x58317A0", VA = "0x185832BA0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5832DD0", Offset = "0x58319D0", VA = "0x185832DD0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xF885E0", Offset = "0xF871E0", VA = "0x180F885E0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct GMEGAILJGCO
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static GMEGAILJGCO AIIJEIHGICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public float FJLFOEDJLBN;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x209AAD0", Offset = "0x20996D0", VA = "0x18209AAD0")]
	public GMEGAILJGCO(float HDJACEFPCIB)
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
		[FKJMAODFHJL(GIPDBINLIND.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const int KLPEHCPDAFE = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const int BKGEILPJHFO = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly List<Material> KBBEEGEJNBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool OAJFFADFNBN;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5833000", Offset = "0x5831C00", VA = "0x185833000")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5832F00", Offset = "0x5831B00", VA = "0x185832F00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x58331E0", Offset = "0x5831DE0", VA = "0x1858331E0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class CenterInImposter : MonoBehaviour, JBJHFKIJGPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x582EBF0", Offset = "0x582D7F0", VA = "0x18582EBF0", Slot = "4")]
		public void PrepareImposter(HCHCHAGJBNM BEMMPFFAJLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xE6E9A0", Offset = "0xE6D5A0", VA = "0x180E6E9A0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xE6E9A0", Offset = "0xE6D5A0", VA = "0x180E6E9A0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JBJHFKIJGPN
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(HCHCHAGJBNM BEMMPFFAJLN);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface CFNHHLDDFPN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> AKKEKCDMNOL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> POCMJGMABEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PCJMKAHOBPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGFEJEIEOPP(params Type[] EKIKCADEFHL);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PPGMAKMJLIN(params Type[] EKIKCADEFHL);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject AHAGNLHCGMP(GameObject PAMDOGALOKE, Transform MKOLBPGKLJP, bool MCKKMHBECNE = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T AHAGNLHCGMP<T>(T PAMDOGALOKE, Transform MKOLBPGKLJP, bool MCKKMHBECNE = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T AHAGNLHCGMP<T>(GameObject PAMDOGALOKE, Transform MKOLBPGKLJP, bool MCKKMHBECNE = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject AHAGNLHCGMP(GameObject PAMDOGALOKE, Transform MKOLBPGKLJP, HCHCHAGJBNM BEMMPFFAJLN, bool MCKKMHBECNE);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T AHAGNLHCGMP<T>(GameObject PAMDOGALOKE, Transform MKOLBPGKLJP, HCHCHAGJBNM BEMMPFFAJLN, bool MCKKMHBECNE) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T AHAGNLHCGMP<T>(T PAMDOGALOKE, Transform MKOLBPGKLJP, HCHCHAGJBNM BEMMPFFAJLN, bool MCKKMHBECNE) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class HONJMFEKEEH : IDisposable, PCJMKAHOBPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly HashSet<Type> LDHPLJDMJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly HashSet<Type> NCFKJOGGALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Transform IKMNAJFIJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly List<Component> DCLBENFDMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> PBFGIFONJMN;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5831F60", Offset = "0x5830B60", VA = "0x185831F60")]
	[GFJPFDCIFKC(GLALKNGODNM.None)]
	public static void AIOENCGFIEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5832870", Offset = "0x5831470", VA = "0x185832870")]
	[Preserve]
	public HONJMFEKEEH([CEABMBGCAIH(null)] CFNHHLDDFPN DKKPKNHJKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x58324C0", Offset = "0x58310C0", VA = "0x1858324C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5831DF0", Offset = "0x58309F0", VA = "0x185831DF0", Slot = "5")]
	public void AGFEJEIEOPP(params Type[] EKIKCADEFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5832820", Offset = "0x5831420", VA = "0x185832820", Slot = "6")]
	public void PPGMAKMJLIN(params Type[] EKIKCADEFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5831ED0", Offset = "0x5830AD0", VA = "0x185831ED0", Slot = "7")]
	public GameObject AHAGNLHCGMP(GameObject PAMDOGALOKE, Transform MKOLBPGKLJP, bool MCKKMHBECNE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x201DB80", Offset = "0x201C780", VA = "0x18201DB80", Slot = "8")]
	public T AHAGNLHCGMP<T>(T PAMDOGALOKE, Transform MKOLBPGKLJP, bool MCKKMHBECNE = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x201E1C0", Offset = "0x201CDC0", VA = "0x18201E1C0", Slot = "9")]
	public T AHAGNLHCGMP<T>(GameObject PAMDOGALOKE, Transform MKOLBPGKLJP, bool MCKKMHBECNE = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5831E40", Offset = "0x5830A40", VA = "0x185831E40", Slot = "10")]
	public GameObject AHAGNLHCGMP(GameObject PAMDOGALOKE, Transform MKOLBPGKLJP, HCHCHAGJBNM BEMMPFFAJLN, bool MCKKMHBECNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x201DBF0", Offset = "0x201C7F0", VA = "0x18201DBF0", Slot = "11")]
	public T AHAGNLHCGMP<T>(GameObject PAMDOGALOKE, Transform MKOLBPGKLJP, HCHCHAGJBNM BEMMPFFAJLN, bool MCKKMHBECNE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x201DAF0", Offset = "0x201C6F0", VA = "0x18201DAF0", Slot = "12")]
	public T AHAGNLHCGMP<T>(T PAMDOGALOKE, Transform MKOLBPGKLJP, HCHCHAGJBNM BEMMPFFAJLN, bool MCKKMHBECNE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x201DC40", Offset = "0x201C840", VA = "0x18201DC40")]
	private T AHAGNLHCGMP<T>(GameObject PAMDOGALOKE, Transform MKOLBPGKLJP, HCHCHAGJBNM BEMMPFFAJLN, bool MCKKMHBECNE, out GameObject DIFLOKEEGGJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x201E1F0", Offset = "0x201CDF0", VA = "0x18201E1F0")]
	private T KDEMOIMNPEM<T>(GameObject MHECAANKLIB, HCHCHAGJBNM BEMMPFFAJLN, bool MCKKMHBECNE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x58325C0", Offset = "0x58311C0", VA = "0x1858325C0")]
	private void GHPHPMPCKHJ(Component DGHFPMGLNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5832050", Offset = "0x5830C50", VA = "0x185832050")]
	private void DKGEHHHDOKL(Component DGHFPMGLNEJ, HCHCHAGJBNM BEMMPFFAJLN, bool MCKKMHBECNE, [Optional] Type NIGGJGMNLAD, [Optional] Type GPGFMDDANCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x58326E0", Offset = "0x58312E0", VA = "0x1858326E0")]
	private void OLDMCOIBCHN(GameObject MHECAANKLIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct HCHCHAGJBNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Dictionary<Type, object> JHAFFMJBNCG;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x20C8EE0", Offset = "0x20C7AE0", VA = "0x1820C8EE0")]
	public HCHCHAGJBNM GELHLBKPBFF<T>(T DHOMHGLAOFP)
	{
		return default(HCHCHAGJBNM);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x201A010", Offset = "0x2018C10", VA = "0x18201A010")]
	public T JHLAPKAGPFG<T>(T OGKBGGEDIAG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x27E2850", Offset = "0x27E1450", VA = "0x1827E2850")]
	public bool POIHJJLHJCC<T>(out T DHOMHGLAOFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct IMJLOECHKII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public bool HCDMGFGJKAD;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xE41C90", Offset = "0xE40890", VA = "0x180E41C90")]
	public IMJLOECHKII(bool NJNJNKFHNHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct FOENFMEMPNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly bool GDANLKEHMIK;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x582F750", Offset = "0x582E350", VA = "0x18582F750")]
	public FOENFMEMPNG(bool HBOAKICFMDE)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xE6E9A0", Offset = "0xE6D5A0", VA = "0x180E6E9A0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ScaleInImposter : MonoBehaviour, JBJHFKIJGPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5833280", Offset = "0x5831E80", VA = "0x185833280", Slot = "4")]
		public void PrepareImposter(HCHCHAGJBNM BEMMPFFAJLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xE6E9A0", Offset = "0xE6D5A0", VA = "0x180E6E9A0")]
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
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
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
				[Cpp2IlInjected.Address(RVA = "0x5833260", Offset = "0x5831E60", VA = "0x185833260")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5833250", Offset = "0x5831E50", VA = "0x185833250")]
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
		[Cpp2IlInjected.Address(RVA = "0x5832E80", Offset = "0x5831A80", VA = "0x185832E80")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class HIOKJLGJHEE
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<URPLight> MODKCBLALCJ;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly Vector3 ILANJNLMBIE;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly Vector3 ILAFILPEEKE;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static Camera AAPJBNLMBLD;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public const string DOIIMICLHJK = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public const AMEPBOCOAOA GHBKGKBDMOG = AMEPBOCOAOA.Water;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static readonly List<Renderer> OBDIMAOIJPC;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static AmbientMode INDKIFCLIMF;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static Color LFIKABDHKDP;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static Color MNKFBFGGGBC;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static Color MLDPGFHFHLM;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static Cubemap FJMILODBAFB;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static bool OIAAEAIEPED;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera IAFMLJJDMOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5830FB0", Offset = "0x582FBB0", VA = "0x185830FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x58308F0", Offset = "0x582F4F0", VA = "0x1858308F0")]
	public static void DGFMPJCKKEJ(Vector3 LFIHGLILMFE, Quaternion PHDLGGJEIOC, ImposterRenderConfig MOHNPBNLEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5830B70", Offset = "0x582F770", VA = "0x185830B70")]
	private static void ELELBPCFMDA(Vector3 LFIHGLILMFE, Quaternion PHDLGGJEIOC, URPLight IFAGJEKBJDE, ImposterRenderConfig.LightConfig JKNMEILAMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x58300B0", Offset = "0x582ECB0", VA = "0x1858300B0")]
	public static void CIAMHNNFOMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5831820", Offset = "0x5830420", VA = "0x185831820")]
	private static void NCOILFGDOHK(int PFPGPBCGNLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5831B20", Offset = "0x5830720", VA = "0x185831B20")]
	public static void NFPLHOLANNM(ImposterRenderConfig MOHNPBNLEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5830EB0", Offset = "0x582FAB0", VA = "0x185830EB0")]
	public static void FGGGJIGDGKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x58314E0", Offset = "0x58300E0", VA = "0x1858314E0")]
	public static void MMDCFOGGEFI(GameObject MOLDCBOOEDB, RenderTexture MMEAEJPMENN, ImposterRenderConfig MOHNPBNLEBO, GMEGAILJGCO NFGMBHBDFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x58303D0", Offset = "0x582EFD0", VA = "0x1858303D0")]
	private static void DDDJAFJDFLM(GameObject MOLDCBOOEDB, RenderTexture MMEAEJPMENN, ImposterRenderConfig MOHNPBNLEBO, GMEGAILJGCO NFGMBHBDFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5831250", Offset = "0x582FE50", VA = "0x185831250")]
	private static void KAMLIABKLAM(GameObject MOLDCBOOEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5831690", Offset = "0x5830290", VA = "0x185831690")]
	public static void MPECFFJFMGG(List<Renderer> GGAKMKKHKFF, List<Material> MEPPNDLMHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x582FD90", Offset = "0x582E990", VA = "0x18582FD90")]
	public static void BFIOGLLNJMG(GameObject PAMDOGALOKE, Vector3 EEFCIGOIJJM, Vector3 AMDPKFBGMJC, float EKHLPHBGCFO, GMEGAILJGCO NFGMBHBDFFE, out Vector3 CIIMOBGKBNP, out Quaternion HCMMMPBOEFP, out float CBABLEKJDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x58311B0", Offset = "0x582FDB0", VA = "0x1858311B0")]
	public static RenderTexture HPBPKFPFHLB(int ODJKCOFMAJL, int HEHBEAHJOKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5830190", Offset = "0x582ED90", VA = "0x185830190")]
	public static void DABNHAMGMKH()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public struct DKHPBJIAKHP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public HDIMBBGGJPD OMOFCJPIGKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public GameObject GMKMNCCJLMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public RenderTexture MPJJNFCODLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public ImposterRenderConfig NHEIDKOCEMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public GMEGAILJGCO GMEGAILJGCO;

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x582ED70", Offset = "0x582D970", VA = "0x18582ED70")]
			public DKHPBJIAKHP(HDIMBBGGJPD CBAJPFNDLCP, GameObject BECJLFPAKEC, RenderTexture MMEAEJPMENN, ImposterRenderConfig HKNFNNMCPDI, GMEGAILJGCO NFGMBHBDFFE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int FLPEEHGMLOH = 1;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int ADLAIOGHNNK = 6;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static global::MJGHCDCGIBB<DKHPBJIAKHP, RenderTexture> JEKANKCDCMD;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static readonly List<DKHPBJIAKHP> NLGEPAEMFLM;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int JFEGEJBDNFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x924010", Offset = "0x922C10", VA = "0x180924010")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x582F2E0", Offset = "0x582DEE0", VA = "0x18582F2E0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject MOLDCBOOEDB, RenderTexture MMEAEJPMENN, ImposterRenderConfig MOHNPBNLEBO, GMEGAILJGCO NFGMBHBDFFE, CancellationToken DHCIMDILIGO, bool KIIBDBLIIEN = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x582EDE0", Offset = "0x582D9E0", VA = "0x18582EDE0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x582F250", Offset = "0x582DE50", VA = "0x18582F250", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x582EF00", Offset = "0x582DB00", VA = "0x18582EF00")]
		private static Task<RenderTexture> DJJDCMCDJNM(DKHPBJIAKHP DEGMGFNNDFA, CancellationToken DHCIMDILIGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x582F6F0", Offset = "0x582E2F0", VA = "0x18582F6F0")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GGMACBOFMDA
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static byte[] HNILJCLIGCF;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static int MHDNNHPLAAF;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static int JKLLCIMILJG;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static BigInteger JLHIBEKHFGK;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public GGMACBOFMDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x582FA90", Offset = "0x582E690", VA = "0x18582FA90")]
	private static string PBMOEILNFIF(byte[] EDLPJGEPJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x582F760", Offset = "0x582E360", VA = "0x18582F760")]
	public static string EICDLCDOCAE(byte[] IAIFCDOPKGE, bool LFDDCGMHEMH)
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
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
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
