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
public class ImposterPreviewCustomFraming : MonoBehaviour, AGHFIJEIHPE
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float PPEDPMCOFGK = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "4")]
	public void PrepareImposter(APAJPIIFALO CNMIOIIAHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x601E930", Offset = "0x601DD30", VA = "0x18601E930")]
	public void SetReferencePoint(Vector3 BMHPNHLDACF, Quaternion BHFNLNKHCPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x601E7A0", Offset = "0x601DBA0", VA = "0x18601E7A0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x601E900", Offset = "0x601DD00", VA = "0x18601E900")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1DB7750", Offset = "0x1DB6B50", VA = "0x181DB7750")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct DBJEKKNFFGK
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static DBJEKKNFFGK EHBHFBGGIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public float LHHAPKEAGMP;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2CD3D50", Offset = "0x2CD3150", VA = "0x182CD3D50")]
	public DBJEKKNFFGK(float GHHNAHLOLLP)
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
		[OMNCBHLNHGK(IJIMEJPPCDF.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const int LOCCLAEMCLN = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const int CPPIDOKFFII = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly List<Material> CEKOGPIPPKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool JHFJFKFEBFG;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x601EAA0", Offset = "0x601DEA0", VA = "0x18601EAA0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x601E9B0", Offset = "0x601DDB0", VA = "0x18601E9B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x601ECE0", Offset = "0x601E0E0", VA = "0x18601ECE0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class CenterInImposter : MonoBehaviour, AGHFIJEIHPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x601DCB0", Offset = "0x601D0B0", VA = "0x18601DCB0", Slot = "4")]
		public void PrepareImposter(APAJPIIFALO CNMIOIIAHLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xEE3F40", Offset = "0xEE3340", VA = "0x180EE3F40")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xEE3F40", Offset = "0xEE3340", VA = "0x180EE3F40")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface AGHFIJEIHPE
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(APAJPIIFALO CNMIOIIAHLH);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface DHMFALHBMLM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> BMKFOBDANGM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> HNPGDAEKKKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GNLBJFBEEJH
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KPCDHIGEPBF(params Type[] NONJEDCGPEF);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PIICCIAFMCJ(params Type[] NONJEDCGPEF);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject LAJOLLAKHNP(GameObject JLHMEAKALNB, Transform JFCNGAACNEO, bool EGHHOMFPKFO = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T LAJOLLAKHNP<T>(T JLHMEAKALNB, Transform JFCNGAACNEO, bool EGHHOMFPKFO = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T LAJOLLAKHNP<T>(GameObject JLHMEAKALNB, Transform JFCNGAACNEO, bool EGHHOMFPKFO = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject LAJOLLAKHNP(GameObject JLHMEAKALNB, Transform JFCNGAACNEO, APAJPIIFALO CNMIOIIAHLH, bool EGHHOMFPKFO);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T LAJOLLAKHNP<T>(GameObject JLHMEAKALNB, Transform JFCNGAACNEO, APAJPIIFALO CNMIOIIAHLH, bool EGHHOMFPKFO) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T LAJOLLAKHNP<T>(T JLHMEAKALNB, Transform JFCNGAACNEO, APAJPIIFALO CNMIOIIAHLH, bool EGHHOMFPKFO) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class OPMJKIKPGIP : IDisposable, GNLBJFBEEJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly HashSet<Type> KODBPMBILOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly HashSet<Type> DNDBNPLKCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Transform JAGPCOGJKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly List<Component> BELFPKKHHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> ODLAGADDGJJ;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x60218D0", Offset = "0x6020CD0", VA = "0x1860218D0")]
	[PCIIMDKJBPO(GGLAACLIDJL.None)]
	public static void GHCFAKCMOAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x60220E0", Offset = "0x60214E0", VA = "0x1860220E0")]
	[Preserve]
	public OPMJKIKPGIP([IMNCNOGBAJI(null)] DHMFALHBMLM FHPAOBONAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x60217D0", Offset = "0x6020BD0", VA = "0x1860217D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6021F20", Offset = "0x6021320", VA = "0x186021F20", Slot = "5")]
	public void KPCDHIGEPBF(params Type[] NONJEDCGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6022090", Offset = "0x6021490", VA = "0x186022090", Slot = "6")]
	public void PIICCIAFMCJ(params Type[] NONJEDCGPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6022000", Offset = "0x6021400", VA = "0x186022000", Slot = "7")]
	public GameObject LAJOLLAKHNP(GameObject JLHMEAKALNB, Transform JFCNGAACNEO, bool EGHHOMFPKFO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFC90", Offset = "0x1FBF090", VA = "0x181FBFC90", Slot = "8")]
	public T LAJOLLAKHNP<T>(T JLHMEAKALNB, Transform JFCNGAACNEO, bool EGHHOMFPKFO = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0310", Offset = "0x1FBF710", VA = "0x181FC0310", Slot = "9")]
	public T LAJOLLAKHNP<T>(GameObject JLHMEAKALNB, Transform JFCNGAACNEO, bool EGHHOMFPKFO = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6021F70", Offset = "0x6021370", VA = "0x186021F70", Slot = "10")]
	public GameObject LAJOLLAKHNP(GameObject JLHMEAKALNB, Transform JFCNGAACNEO, APAJPIIFALO CNMIOIIAHLH, bool EGHHOMFPKFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFC40", Offset = "0x1FBF040", VA = "0x181FBFC40", Slot = "11")]
	public T LAJOLLAKHNP<T>(GameObject JLHMEAKALNB, Transform JFCNGAACNEO, APAJPIIFALO CNMIOIIAHLH, bool EGHHOMFPKFO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0280", Offset = "0x1FBF680", VA = "0x181FC0280", Slot = "12")]
	public T LAJOLLAKHNP<T>(T JLHMEAKALNB, Transform JFCNGAACNEO, APAJPIIFALO CNMIOIIAHLH, bool EGHHOMFPKFO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1FBFD00", Offset = "0x1FBF100", VA = "0x181FBFD00")]
	private T LAJOLLAKHNP<T>(GameObject JLHMEAKALNB, Transform JFCNGAACNEO, APAJPIIFALO CNMIOIIAHLH, bool EGHHOMFPKFO, out GameObject DDBDPGGJOGI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1FC0340", Offset = "0x1FBF740", VA = "0x181FC0340")]
	private T NMAICKGEDOC<T>(GameObject FLFBOHHHJJB, APAJPIIFALO CNMIOIIAHLH, bool EGHHOMFPKFO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x60216A0", Offset = "0x6020AA0", VA = "0x1860216A0")]
	private void CDNLKFPMLGL(Component HEKOHKDELMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x60219D0", Offset = "0x6020DD0", VA = "0x1860219D0")]
	private void JDBPEBJGDIH(Component HEKOHKDELMN, APAJPIIFALO CNMIOIIAHLH, bool EGHHOMFPKFO, bool EJAHLDBDOFF, [Optional] Type LPOHHMPAJON, [Optional] Type HDLNCCNPHKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6021540", Offset = "0x6020940", VA = "0x186021540")]
	private void BNPAAPJKKPN(GameObject FLFBOHHHJJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct APAJPIIFALO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Dictionary<Type, object> NIKALLNLJJM;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x15D8600", Offset = "0x15D7A00", VA = "0x1815D8600")]
	public APAJPIIFALO KNBGLHDOKIA<T>(T CDDIFFKMAEP)
	{
		return default(APAJPIIFALO);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x15D84E0", Offset = "0x15D78E0", VA = "0x1815D84E0")]
	public T JLHLNIPLDNM<T>(T HNGNIFMJFIP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x15D7D40", Offset = "0x15D7140", VA = "0x1815D7D40")]
	public bool HIJHOGNBHHL<T>(out T CDDIFFKMAEP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct PEHIKEMOCBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public bool JAIJIFKBHNN;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xF57CD0", Offset = "0xF570D0", VA = "0x180F57CD0")]
	public PEHIKEMOCBI(bool OIMFBOHHAEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct GEKONHHACOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly bool GLMBIMDNPFC;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x601E790", Offset = "0x601DB90", VA = "0x18601E790")]
	public GEKONHHACOJ(bool FEAMIEDPFGE)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xEE3F40", Offset = "0xEE3340", VA = "0x180EE3F40")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ScaleInImposter : MonoBehaviour, AGHFIJEIHPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6022520", Offset = "0x6021920", VA = "0x186022520", Slot = "4")]
		public void PrepareImposter(APAJPIIFALO CNMIOIIAHLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xEE3F40", Offset = "0xEE3340", VA = "0x180EE3F40")]
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
				[Cpp2IlInjected.Address(RVA = "0x6020EF0", Offset = "0x60202F0", VA = "0x186020EF0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6020EE0", Offset = "0x60202E0", VA = "0x186020EE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x601E970", Offset = "0x601DD70", VA = "0x18601E970")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class LALPNMMCDIO
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<URPLight> PDLBOMBACAA;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly Vector3 PACKNNNFIOP;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly Vector3 LGGCLLGOBLN;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static Camera JAGNPJOKPLM;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public const string CHEFPNCCHOH = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public const KEJMMPNHHNM CJIMEAOGCLK = KEJMMPNHHNM.Water;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static readonly List<Renderer> PNBLCLMBIGO;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static AmbientMode HDOHENOFIHJ;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static Color KIPBPCGGFPD;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static Color EFAOBBBHFGI;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static Color GDNPEJBGAPD;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static Cubemap HLMBJCCIHEA;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static bool INBNJIDLPKO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera NMMJPFMAOFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6020B60", Offset = "0x601FF60", VA = "0x186020B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x601F140", Offset = "0x601E540", VA = "0x18601F140")]
	public static void BOELOHMBGLN(Vector3 PMOFPMPIKPI, Quaternion JIPPJMBKHHK, ImposterRenderConfig NIKNMHKHDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x60201B0", Offset = "0x601F5B0", VA = "0x1860201B0")]
	private static void MHJDLJPNCEC(Vector3 PMOFPMPIKPI, Quaternion JIPPJMBKHHK, URPLight EOLGELNDMGC, ImposterRenderConfig.LightConfig CMLFAFDOILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x601F3C0", Offset = "0x601E7C0", VA = "0x18601F3C0")]
	public static void DAAMPLMGJNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6020790", Offset = "0x601FB90", VA = "0x186020790")]
	private static void NIMBFGHLKID(int BEPHCFNDJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x601F4B0", Offset = "0x601E8B0", VA = "0x18601F4B0")]
	public static void EFFKAGOBLDM(ImposterRenderConfig NIKNMHKHDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x601FD60", Offset = "0x601F160", VA = "0x18601FD60")]
	public static void HHBBGMKLMGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x601EF70", Offset = "0x601E370", VA = "0x18601EF70")]
	public static void BBCAONAHBJC(GameObject NHCJNCAFHLE, RenderTexture GHHBMJDAPIB, ImposterRenderConfig NIKNMHKHDHO, DBJEKKNFFGK NHBMANMJMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x601F630", Offset = "0x601EA30", VA = "0x18601F630")]
	private static void FKJEODNBLMF(GameObject NHCJNCAFHLE, RenderTexture GHHBMJDAPIB, ImposterRenderConfig NIKNMHKHDHO, DBJEKKNFFGK NHBMANMJMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x601FF00", Offset = "0x601F300", VA = "0x18601FF00")]
	private static void KBBLIOHEOIC(GameObject NHCJNCAFHLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x601EDD0", Offset = "0x601E1D0", VA = "0x18601EDD0")]
	public static void BAHABAODNJP(List<Renderer> JFCHJNILPHD, List<Material> PGEOIAFMAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x60204C0", Offset = "0x601F8C0", VA = "0x1860204C0")]
	public static void MMEDJNNFMDL(GameObject JLHMEAKALNB, Vector3 GKDBGJOPMLJ, Vector3 ABMMHFLEBCB, float EGIMIHJPENK, DBJEKKNFFGK NHBMANMJMIB, out Vector3 GKIMCKANDKH, out Quaternion LPALFKPCJCI, out float FHJLFNDPAOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x601FE60", Offset = "0x601F260", VA = "0x18601FE60")]
	public static RenderTexture IIGIEKJLFKD(int HGELIJGMFCF, int INLFDHDPLNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x601FB30", Offset = "0x601EF30", VA = "0x18601FB30")]
	public static void FOBDEKPOPHN()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public struct JGFEEAEANFI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public HADFCENGJKO IBKLPADLJGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public GameObject NIOCMNGKFAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public RenderTexture EEGNCKIHFNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public ImposterRenderConfig FGPILMKDCFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public DBJEKKNFFGK DBJEKKNFFGK;

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x601ED60", Offset = "0x601E160", VA = "0x18601ED60")]
			public JGFEEAEANFI(HADFCENGJKO AEEFFNAAFFK, GameObject DPKEBBIKHLA, RenderTexture GHHBMJDAPIB, ImposterRenderConfig JMHGIIKHBNC, DBJEKKNFFGK NHBMANMJMIB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int GGOAJEILEIC = 1;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int IEAHGCBHEBN = 6;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static global::JHCBLGEPLFP<JGFEEAEANFI, RenderTexture> OKDAIBELJJJ;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static readonly List<JGFEEAEANFI> GDMAAGAGMEE;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int FCFFOEPDPGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7CD510", Offset = "0x7CC910", VA = "0x1807CD510")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x601E250", Offset = "0x601D650", VA = "0x18601E250")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject NHCJNCAFHLE, RenderTexture GHHBMJDAPIB, ImposterRenderConfig NIKNMHKHDHO, DBJEKKNFFGK NHBMANMJMIB, CancellationToken BJOMIPBBJKO, bool OFDCJCEFPLE = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x601DE50", Offset = "0x601D250", VA = "0x18601DE50", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x601E1B0", Offset = "0x601D5B0", VA = "0x18601E1B0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x601DFE0", Offset = "0x601D3E0", VA = "0x18601DFE0")]
		private static Task<RenderTexture> CGHEOBMMOPF(JGFEEAEANFI OAAAJOOJKGP, CancellationToken BJOMIPBBJKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x601E720", Offset = "0x601DB20", VA = "0x18601E720")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NLJAGALCJKH
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static byte[] JCLCDCCNAPM;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static int BKAHGFCDIKL;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static int GJMNCFGIJLO;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static BigInteger MOEAOMJCPNL;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public NLJAGALCJKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6020F10", Offset = "0x6020310", VA = "0x186020F10")]
	private static string EMKPABEMONO(byte[] IKDBBHHKFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6021020", Offset = "0x6020420", VA = "0x186021020")]
	public static string NJEIEMNKMPN(byte[] EEMDNKKFCBK, bool DIMJIPPBEJB)
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
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
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
