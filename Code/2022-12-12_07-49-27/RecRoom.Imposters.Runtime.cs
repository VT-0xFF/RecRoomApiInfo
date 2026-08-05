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
public class ImposterPreviewCustomFraming : MonoBehaviour, JOPHLLLJEFB
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float OGJGECIGMJK = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "4")]
	public void PrepareImposter(GHNKBGFFKIO JJDMBGDPAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x606F430", Offset = "0x606DA30", VA = "0x18606F430")]
	public void SetReferencePoint(Vector3 PBENCDOOEDL, Quaternion AILLHFOOINL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x606F2A0", Offset = "0x606D8A0", VA = "0x18606F2A0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x606F400", Offset = "0x606DA00", VA = "0x18606F400")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x18FED60", Offset = "0x18FD360", VA = "0x1818FED60")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct PEADFPJNIPK
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static PEADFPJNIPK CDBGNFEBDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public float KGPPCPKGBME;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x74C1E0", Offset = "0x74A7E0", VA = "0x18074C1E0")]
	public PEADFPJNIPK(float MFOBFKMAHKO)
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
		[EICDDLDLOGE(BHMLOOPGMEN.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const int KKLFDJNHNBN = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const int EAOKDKFNMOJ = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly List<Material> ALDMPKFCKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool AIFLCECGADJ;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x606F5A0", Offset = "0x606DBA0", VA = "0x18606F5A0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x606F4B0", Offset = "0x606DAB0", VA = "0x18606F4B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x606F7E0", Offset = "0x606DDE0", VA = "0x18606F7E0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class CenterInImposter : MonoBehaviour, JOPHLLLJEFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x606E790", Offset = "0x606CD90", VA = "0x18606E790", Slot = "4")]
		public void PrepareImposter(GHNKBGFFKIO JJDMBGDPAOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JOPHLLLJEFB
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(GHNKBGFFKIO JJDMBGDPAOA);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface NAPNHMPBIIP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> OPAIONFOAGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> IMGNKIDLBPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IPGJOEJEAAB
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DEGOIMLFLIG(params Type[] KJJNFLPAOCJ);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JLNDANININO(params Type[] KJJNFLPAOCJ);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject APKIDBLLIAG(GameObject BHIKNMNBHAG, Transform LFAIGCEGCPL, bool IINMNMPKMHA = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T APKIDBLLIAG<T>(T BHIKNMNBHAG, Transform LFAIGCEGCPL, bool IINMNMPKMHA = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T APKIDBLLIAG<T>(GameObject BHIKNMNBHAG, Transform LFAIGCEGCPL, bool IINMNMPKMHA = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject APKIDBLLIAG(GameObject BHIKNMNBHAG, Transform LFAIGCEGCPL, GHNKBGFFKIO JJDMBGDPAOA, bool IINMNMPKMHA);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T APKIDBLLIAG<T>(GameObject BHIKNMNBHAG, Transform LFAIGCEGCPL, GHNKBGFFKIO JJDMBGDPAOA, bool IINMNMPKMHA) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T APKIDBLLIAG<T>(T BHIKNMNBHAG, Transform LFAIGCEGCPL, GHNKBGFFKIO JJDMBGDPAOA, bool IINMNMPKMHA) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class PPHDGJLOFNE : IDisposable, IPGJOEJEAAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly HashSet<Type> NKNINGMPBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly HashSet<Type> BDDKOEIIIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Transform DJCJFLKFMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly List<Component> BNKMKNEIIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> GCGANEBPBEG;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x60706B0", Offset = "0x606ECB0", VA = "0x1860706B0")]
	[PILNOHNDGDF(KBMKLHMPDPB.None)]
	public static void COABAOIMNDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6070AB0", Offset = "0x606F0B0", VA = "0x186070AB0")]
	[Preserve]
	public PPHDGJLOFNE([KICKHKJFGOO(null)] NAPNHMPBIIP ADFHIKIBDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6070800", Offset = "0x606EE00", VA = "0x186070800", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x60707B0", Offset = "0x606EDB0", VA = "0x1860707B0", Slot = "5")]
	public void DEGOIMLFLIG(params Type[] KJJNFLPAOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6070900", Offset = "0x606EF00", VA = "0x186070900", Slot = "6")]
	public void JLNDANININO(params Type[] KJJNFLPAOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6070040", Offset = "0x606E640", VA = "0x186070040", Slot = "7")]
	public GameObject APKIDBLLIAG(GameObject BHIKNMNBHAG, Transform LFAIGCEGCPL, bool IINMNMPKMHA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x356CA70", Offset = "0x356B070", VA = "0x18356CA70", Slot = "8")]
	public T APKIDBLLIAG<T>(T BHIKNMNBHAG, Transform LFAIGCEGCPL, bool IINMNMPKMHA = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x356CB70", Offset = "0x356B170", VA = "0x18356CB70", Slot = "9")]
	public T APKIDBLLIAG<T>(GameObject BHIKNMNBHAG, Transform LFAIGCEGCPL, bool IINMNMPKMHA = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x60700D0", Offset = "0x606E6D0", VA = "0x1860700D0", Slot = "10")]
	public GameObject APKIDBLLIAG(GameObject BHIKNMNBHAG, Transform LFAIGCEGCPL, GHNKBGFFKIO JJDMBGDPAOA, bool IINMNMPKMHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x356D120", Offset = "0x356B720", VA = "0x18356D120", Slot = "11")]
	public T APKIDBLLIAG<T>(GameObject BHIKNMNBHAG, Transform LFAIGCEGCPL, GHNKBGFFKIO JJDMBGDPAOA, bool IINMNMPKMHA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x356CAE0", Offset = "0x356B0E0", VA = "0x18356CAE0", Slot = "12")]
	public T APKIDBLLIAG<T>(T BHIKNMNBHAG, Transform LFAIGCEGCPL, GHNKBGFFKIO JJDMBGDPAOA, bool IINMNMPKMHA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x356CBA0", Offset = "0x356B1A0", VA = "0x18356CBA0")]
	private T APKIDBLLIAG<T>(GameObject BHIKNMNBHAG, Transform LFAIGCEGCPL, GHNKBGFFKIO JJDMBGDPAOA, bool IINMNMPKMHA, out GameObject LFEHEBLOKOB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x356D170", Offset = "0x356B770", VA = "0x18356D170")]
	private T GIIGEGKFDDD<T>(GameObject EHEABJNEALG, GHNKBGFFKIO JJDMBGDPAOA, bool IINMNMPKMHA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x606FF10", Offset = "0x606E510", VA = "0x18606FF10")]
	private void AAJPECBPOKL(Component AALANACCLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6070160", Offset = "0x606E760", VA = "0x186070160")]
	private void BKKPMNOCADF(Component AALANACCLGM, GHNKBGFFKIO JJDMBGDPAOA, bool IINMNMPKMHA, bool MNKJDGIMEIA, [Optional] Type NFOGBAHHNMC, [Optional] Type NFDEHDBBHIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6070950", Offset = "0x606EF50", VA = "0x186070950")]
	private void MKBIDDHEOEC(GameObject EHEABJNEALG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct GHNKBGFFKIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Dictionary<Type, object> DFCAJKDCGJD;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x32C0A40", Offset = "0x32BF040", VA = "0x1832C0A40")]
	public GHNKBGFFKIO KMNEKDAGPNL<T>(T IAHPHHNFGHI)
	{
		return default(GHNKBGFFKIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x32C0920", Offset = "0x32BEF20", VA = "0x1832C0920")]
	public T DNJGGIFCOKL<T>(T BKMGNMEJDHA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x32C0180", Offset = "0x32BE780", VA = "0x1832C0180")]
	public bool DJEIEOEOGPA<T>(out T IAHPHHNFGHI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct OOLOCJDCMPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public bool COAAEJBGFFA;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xA24BA0", Offset = "0xA231A0", VA = "0x180A24BA0")]
	public OOLOCJDCMPM(bool MIEKIIDKOBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct PFMEEBHAPAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly bool OCJEIKOAFJN;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x606FF00", Offset = "0x606E500", VA = "0x18606FF00")]
	public PFMEEBHAPAO(bool POIHFPEEFCM)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ScaleInImposter : MonoBehaviour, JOPHLLLJEFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6070EF0", Offset = "0x606F4F0", VA = "0x186070EF0", Slot = "4")]
		public void PrepareImposter(GHNKBGFFKIO JJDMBGDPAOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
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
				[Cpp2IlInjected.Address(RVA = "0x606F870", Offset = "0x606DE70", VA = "0x18606F870")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x606F860", Offset = "0x606DE60", VA = "0x18606F860")]
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
		[Cpp2IlInjected.Address(RVA = "0x606F470", Offset = "0x606DA70", VA = "0x18606F470")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class BMALMKGJJHN
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<URPLight> KGIAAACCFHG;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly Vector3 MLKIHDKOEMB;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly Vector3 OMIHDMPCCEH;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static Camera FIKEEDGDAKB;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public const string FMCPLGMHBPG = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public const PHOGPHPFPIE KADAGOHBFLB = PHOGPHPFPIE.Water;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static readonly List<Renderer> KMCJIHHKJCD;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static AmbientMode OBEMIIAGFAI;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static Color IMEDGEFGIDN;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static Color FCFOEOCPFMO;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static Color OGEEJMDNGGI;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static Cubemap CDMDJCOBIEE;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static bool DBNFBBNHOAP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera GPPHEGHMPHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x606DF50", Offset = "0x606C550", VA = "0x18606DF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x606DAA0", Offset = "0x606C0A0", VA = "0x18606DAA0")]
	public static void LLNOIEPGAAB(Vector3 EDHMLKHCFFN, Quaternion FDIOPECEIEK, ImposterRenderConfig IGGACGJPFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x606D790", Offset = "0x606BD90", VA = "0x18606D790")]
	private static void LGKPJNKJDHH(Vector3 EDHMLKHCFFN, Quaternion FDIOPECEIEK, URPLight PMLGECLHKJD, ImposterRenderConfig.LightConfig LOHDOLJMFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x606E550", Offset = "0x606CB50", VA = "0x18606E550")]
	public static void PEGHDNMHILP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x606E180", Offset = "0x606C780", VA = "0x18606E180")]
	private static void OLFFBNHJACO(int LGDGENEKMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x606C950", Offset = "0x606AF50", VA = "0x18606C950")]
	public static void FFFJDHAHLHJ(ImposterRenderConfig IGGACGJPFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x606D4C0", Offset = "0x606BAC0", VA = "0x18606D4C0")]
	public static void JLFKKIKHKFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x606D5C0", Offset = "0x606BBC0", VA = "0x18606D5C0")]
	public static void LDOBFMPNCKG(GameObject NCJMCGKPNHC, RenderTexture GNBKNDLBAAB, ImposterRenderConfig IGGACGJPFBO, PEADFPJNIPK ABAJDCJIBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x606CAD0", Offset = "0x606B0D0", VA = "0x18606CAD0")]
	private static void GMBDJMDLNHD(GameObject NCJMCGKPNHC, RenderTexture GNBKNDLBAAB, ImposterRenderConfig IGGACGJPFBO, PEADFPJNIPK ABAJDCJIBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x606D070", Offset = "0x606B670", VA = "0x18606D070")]
	private static void IJKODDIMJAH(GameObject NCJMCGKPNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x606D320", Offset = "0x606B920", VA = "0x18606D320")]
	public static void IJOIEAIABBA(List<Renderer> CEOOJILCJDM, List<Material> OBKGJBPNGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x606C680", Offset = "0x606AC80", VA = "0x18606C680")]
	public static void EOKEFDGGCIB(GameObject BHIKNMNBHAG, Vector3 COOBHLIEHAA, Vector3 JDKKKGOLFIL, float MCJMPFBAPDA, PEADFPJNIPK ABAJDCJIBCM, out Vector3 FDJIHIBFAGP, out Quaternion LCBCMJJEDEP, out float BEHEILKIFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x606CFD0", Offset = "0x606B5D0", VA = "0x18606CFD0")]
	public static RenderTexture IDDOPFLAFFD(int LEFBNKJDKNL, int ELIEMKLAFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x606DD20", Offset = "0x606C320", VA = "0x18606DD20")]
	public static void MBMDOIAELHB()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public struct ICMAJDFEALJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public EONHFJBEBFJ FMCFGPOMGOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public GameObject FFNMJKCIODB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public RenderTexture AJKKNEFHPBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public ImposterRenderConfig DJNLGAHELDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public PEADFPJNIPK PEADFPJNIPK;

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x606F230", Offset = "0x606D830", VA = "0x18606F230")]
			public ICMAJDFEALJ(EONHFJBEBFJ KABGCAHOLIL, GameObject PPNLCOHNCNP, RenderTexture GNBKNDLBAAB, ImposterRenderConfig JPJFBAHNMNK, PEADFPJNIPK ABAJDCJIBCM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int EIBLENBGPBA = 1;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int CMIGGCPNIBF = 6;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static global::ELCIDDJLDCB<ICMAJDFEALJ, RenderTexture> JFFIPOMCDPP;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static readonly List<ICMAJDFEALJ> LLCBPNKAOIK;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int EJIELJBKMOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8146D0", Offset = "0x812CD0", VA = "0x1808146D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x606ECF0", Offset = "0x606D2F0", VA = "0x18606ECF0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject NCJMCGKPNHC, RenderTexture GNBKNDLBAAB, ImposterRenderConfig IGGACGJPFBO, PEADFPJNIPK ABAJDCJIBCM, CancellationToken JLIEBAENBAG, bool JDIHAJOIEIB = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x606E8F0", Offset = "0x606CEF0", VA = "0x18606E8F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x606EC50", Offset = "0x606D250", VA = "0x18606EC50", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x606EA80", Offset = "0x606D080", VA = "0x18606EA80")]
		private static Task<RenderTexture> LLKOIGKMKDM(ICMAJDFEALJ GONNBCINNCF, CancellationToken JLIEBAENBAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x606F1C0", Offset = "0x606D7C0", VA = "0x18606F1C0")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class MDBMMECDLKK
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static byte[] GADOFMLHAHJ;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static int HEJKOBPMNOJ;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static int HLKLMDMLFLE;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static BigInteger DBAKCFGFCLA;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public MDBMMECDLKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x606FBE0", Offset = "0x606E1E0", VA = "0x18606FBE0")]
	private static string LLKJKMBGMPE(byte[] LKLEFAIICIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x606F890", Offset = "0x606DE90", VA = "0x18606F890")]
	public static string FCKPDHOJNPG(byte[] PPJLGCLGPJE, bool KMFFDGBHCMI)
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
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
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
