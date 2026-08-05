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
public class ImposterPreviewCustomFraming : MonoBehaviour, ACNBFALONLD
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float EBKBPDHHBOF = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x670EB0", Offset = "0x66FEB0", VA = "0x180670EB0", Slot = "4")]
	public void PrepareImposter(GHCDKOPCJJO PJGALDPNBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E01B00", Offset = "0x5E00B00", VA = "0x185E01B00")]
	public void SetReferencePoint(Vector3 LHHNEMEAJHG, Quaternion FBGPAJBMOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E01970", Offset = "0x5E00970", VA = "0x185E01970")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E01AD0", Offset = "0x5E00AD0", VA = "0x185E01AD0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x111E790", Offset = "0x111D790", VA = "0x18111E790")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct HOHDCJFFAJD
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static HOHDCJFFAJD LFJFDMFLPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public float BMHLKFHOMPM;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2C490E0", Offset = "0x2C480E0", VA = "0x182C490E0")]
	public HOHDCJFFAJD(float BHLNFEDIALI)
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
		[KFIFBFNJECK(GHKBHIFBDKF.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const int OAANJIMGEFE = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const int JGHPOKPAGEL = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly List<Material> GDNLFFCIIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool KFKJGIJDJPK;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5E01C70", Offset = "0x5E00C70", VA = "0x185E01C70")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5E01B80", Offset = "0x5E00B80", VA = "0x185E01B80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5E01EB0", Offset = "0x5E00EB0", VA = "0x185E01EB0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class CenterInImposter : MonoBehaviour, ACNBFALONLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5E00E90", Offset = "0x5DFFE90", VA = "0x185E00E90", Slot = "4")]
		public void PrepareImposter(GHCDKOPCJJO PJGALDPNBKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xF9D450", Offset = "0xF9C450", VA = "0x180F9D450")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xF9D450", Offset = "0xF9C450", VA = "0x180F9D450")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface ACNBFALONLD
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(GHCDKOPCJJO PJGALDPNBKH);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface OOBPHKFFBMM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> MGLBNKDPACI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> DGBONKFEDHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IPJCOFAKHEE
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HPHNNBFIFIH(params Type[] DCPGKOEBMPG);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AELAHDGEAMD(params Type[] DCPGKOEBMPG);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject LLNMPGPMAIJ(GameObject AAICEAICAMA, Transform ADECAOLBLPJ, bool IFAJFGHFIAJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T LLNMPGPMAIJ<T>(T AAICEAICAMA, Transform ADECAOLBLPJ, bool IFAJFGHFIAJ = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T LLNMPGPMAIJ<T>(GameObject AAICEAICAMA, Transform ADECAOLBLPJ, bool IFAJFGHFIAJ = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject LLNMPGPMAIJ(GameObject AAICEAICAMA, Transform ADECAOLBLPJ, GHCDKOPCJJO PJGALDPNBKH, bool IFAJFGHFIAJ);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T LLNMPGPMAIJ<T>(GameObject AAICEAICAMA, Transform ADECAOLBLPJ, GHCDKOPCJJO PJGALDPNBKH, bool IFAJFGHFIAJ) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T LLNMPGPMAIJ<T>(T AAICEAICAMA, Transform ADECAOLBLPJ, GHCDKOPCJJO PJGALDPNBKH, bool IFAJFGHFIAJ) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class JNGKPJLJFOB : IDisposable, IPJCOFAKHEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly HashSet<Type> KCJOEHBEDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly HashSet<Type> LMDOALNBMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Transform ELOHAKKBJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly List<Component> JAJIBIEBMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> NKHCFHNAPHD;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5E04A70", Offset = "0x5E03A70", VA = "0x185E04A70")]
	[IMCONJMNGLO(KJBNBKOGAAL.None)]
	public static void OHLOIMPCKED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5E04B70", Offset = "0x5E03B70", VA = "0x185E04B70")]
	[Preserve]
	public JNGKPJLJFOB([CDAJDCGEMGI(null)] OOBPHKFFBMM JBHLIKPCOEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E041F0", Offset = "0x5E031F0", VA = "0x185E041F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E042F0", Offset = "0x5E032F0", VA = "0x185E042F0", Slot = "5")]
	public void HPHNNBFIFIH(params Type[] DCPGKOEBMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5E04040", Offset = "0x5E03040", VA = "0x185E04040", Slot = "6")]
	public void AELAHDGEAMD(params Type[] DCPGKOEBMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5E04950", Offset = "0x5E03950", VA = "0x185E04950", Slot = "7")]
	public GameObject LLNMPGPMAIJ(GameObject AAICEAICAMA, Transform ADECAOLBLPJ, bool IFAJFGHFIAJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x25DFA10", Offset = "0x25DEA10", VA = "0x1825DFA10", Slot = "8")]
	public T LLNMPGPMAIJ<T>(T AAICEAICAMA, Transform ADECAOLBLPJ, bool IFAJFGHFIAJ = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x25DF990", Offset = "0x25DE990", VA = "0x1825DF990", Slot = "9")]
	public T LLNMPGPMAIJ<T>(GameObject AAICEAICAMA, Transform ADECAOLBLPJ, bool IFAJFGHFIAJ = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5E049E0", Offset = "0x5E039E0", VA = "0x185E049E0", Slot = "10")]
	public GameObject LLNMPGPMAIJ(GameObject AAICEAICAMA, Transform ADECAOLBLPJ, GHCDKOPCJJO PJGALDPNBKH, bool IFAJFGHFIAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x25DF9C0", Offset = "0x25DE9C0", VA = "0x1825DF9C0", Slot = "11")]
	public T LLNMPGPMAIJ<T>(GameObject AAICEAICAMA, Transform ADECAOLBLPJ, GHCDKOPCJJO PJGALDPNBKH, bool IFAJFGHFIAJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x25DFFB0", Offset = "0x25DEFB0", VA = "0x1825DFFB0", Slot = "12")]
	public T LLNMPGPMAIJ<T>(T AAICEAICAMA, Transform ADECAOLBLPJ, GHCDKOPCJJO PJGALDPNBKH, bool IFAJFGHFIAJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x25DFA80", Offset = "0x25DEA80", VA = "0x1825DFA80")]
	private T LLNMPGPMAIJ<T>(GameObject AAICEAICAMA, Transform ADECAOLBLPJ, GHCDKOPCJJO PJGALDPNBKH, bool IFAJFGHFIAJ, out GameObject BCNHIHKCFDO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x25DF4E0", Offset = "0x25DE4E0", VA = "0x1825DF4E0")]
	private T BEEAHKAKHIK<T>(GameObject BFJMKCMPBKG, GHCDKOPCJJO PJGALDPNBKH, bool IFAJFGHFIAJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E04340", Offset = "0x5E03340", VA = "0x185E04340")]
	private void IFBNGLMDFJN(Component AFOPPLDIMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E04470", Offset = "0x5E03470", VA = "0x185E04470")]
	private void JNPAFFCPPJD(Component AFOPPLDIMJL, GHCDKOPCJJO PJGALDPNBKH, bool IFAJFGHFIAJ, [Optional] Type HNIOEAJMLPK, [Optional] Type JHJGLHGAMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5E04090", Offset = "0x5E03090", VA = "0x185E04090")]
	private void DICDBEKBEEK(GameObject BFJMKCMPBKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct GHCDKOPCJJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Dictionary<Type, object> IKOGCJNHFEA;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2540D20", Offset = "0x253FD20", VA = "0x182540D20")]
	public GHCDKOPCJJO PIGMJENILDA<T>(T EPHCHIPDIOJ)
	{
		return default(GHCDKOPCJJO);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2540460", Offset = "0x253F460", VA = "0x182540460")]
	public T BOPAOPJOHPG<T>(T OGCEKMMDJKC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2540580", Offset = "0x253F580", VA = "0x182540580")]
	public bool KNMEGLCAMII<T>(out T EPHCHIPDIOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct GPOLAPJKLIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public bool FADMMKOLGMB;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xF51E90", Offset = "0xF50E90", VA = "0x180F51E90")]
	public GPOLAPJKLIP(bool CNMFCMFMHGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct KAPIDGKKMDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly bool GHNHFMAFGOK;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5E04FB0", Offset = "0x5E03FB0", VA = "0x185E04FB0")]
	public KAPIDGKKMDG(bool JLAJKPOAECL)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xF9D450", Offset = "0xF9C450", VA = "0x180F9D450")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ScaleInImposter : MonoBehaviour, ACNBFALONLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5E04FF0", Offset = "0x5E03FF0", VA = "0x185E04FF0", Slot = "4")]
		public void PrepareImposter(GHCDKOPCJJO PJGALDPNBKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xF9D450", Offset = "0xF9C450", VA = "0x180F9D450")]
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
				[Cpp2IlInjected.Address(RVA = "0x5E04FD0", Offset = "0x5E03FD0", VA = "0x185E04FD0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5E04FC0", Offset = "0x5E03FC0", VA = "0x185E04FC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E01B40", Offset = "0x5E00B40", VA = "0x185E01B40")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class JJJCCMHDIIP
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<URPLight> EEAIFGPBNHK;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly Vector3 MAJEPKAGIOL;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly Vector3 JOKKEKFHNGM;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static Camera IGEKDELEGMC;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public const string JNCANGJHJNG = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public const LINCODEOJON CAAHLNOECHK = LINCODEOJON.Water;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static readonly List<Renderer> DAPLFKKJIOC;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static AmbientMode JGGLJGKDOCI;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static Color CJPFJGBBHGM;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static Color KOJJNJMJDNG;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static Color ECBEJJLCGGO;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static Cubemap FIJKLMIOAPO;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static bool LNDFDAHPKIN;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera ICPCMBPJPFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5E01F30", Offset = "0x5E00F30", VA = "0x185E01F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5E038A0", Offset = "0x5E028A0", VA = "0x185E038A0")]
	public static void KLBMMENOFGF(Vector3 GMNGHKBKAPC, Quaternion KBNMONGOCKF, ImposterRenderConfig KJEFINEMONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5E03410", Offset = "0x5E02410", VA = "0x185E03410")]
	private static void HJCAGCAMNBD(Vector3 GMNGHKBKAPC, Quaternion KBNMONGOCKF, URPLight GDKICHPMMLI, ImposterRenderConfig.LightConfig CNEINPIACGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5E02160", Offset = "0x5E01160", VA = "0x185E02160")]
	public static void BHAKKEIJNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5E03040", Offset = "0x5E02040", VA = "0x185E03040")]
	private static void FCNKKPHABIK(int JBCGLKNGKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5E03720", Offset = "0x5E02720", VA = "0x185E03720")]
	public static void JINMODFFPNJ(ImposterRenderConfig KJEFINEMONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5E03B20", Offset = "0x5E02B20", VA = "0x185E03B20")]
	public static void KLIKHKFJEAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5E02500", Offset = "0x5E01500", VA = "0x185E02500")]
	public static void BOAPMMPDJLI(GameObject IHMMFKEAFAC, RenderTexture BOPKABBIJAM, ImposterRenderConfig KJEFINEMONC, HOHDCJFFAJD FEGJAAMOCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5E02870", Offset = "0x5E01870", VA = "0x185E02870")]
	private static void COBFIIKLPBM(GameObject IHMMFKEAFAC, RenderTexture BOPKABBIJAM, ImposterRenderConfig KJEFINEMONC, HOHDCJFFAJD FEGJAAMOCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5E02250", Offset = "0x5E01250", VA = "0x185E02250")]
	private static void BLJMMCNPJEA(GameObject IHMMFKEAFAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5E026D0", Offset = "0x5E016D0", VA = "0x185E026D0")]
	public static void BOMBMFMCJGL(List<Renderer> NPBKAMNMPNH, List<Material> HJFLOKGDOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5E02D70", Offset = "0x5E01D70", VA = "0x185E02D70")]
	public static void DBKCDHDGHKI(GameObject AAICEAICAMA, Vector3 EPOBLFLGOEN, Vector3 EDGELPJKGAH, float ENCECGLHCGK, HOHDCJFFAJD FEGJAAMOCDN, out Vector3 DEEDJCBNILE, out Quaternion OGCAGFHJJIK, out float LBEEDLGLMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5E03C20", Offset = "0x5E02C20", VA = "0x185E03C20")]
	public static RenderTexture OAOAMLGIPJI(int KLFKELPFFNF, int AGONAJNGCCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5E03CC0", Offset = "0x5E02CC0", VA = "0x185E03CC0")]
	public static void PNLOJHAPOPB()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public struct CDKOAOKGILJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public ENDBBJEPCAJ NHIMCFLACOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public GameObject GOHFNPHGPMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public RenderTexture AFLMOBFNDBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public ImposterRenderConfig HLIMHLGLJAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public HOHDCJFFAJD HOHDCJFFAJD;

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5E00E20", Offset = "0x5DFFE20", VA = "0x185E00E20")]
			public CDKOAOKGILJ(ENDBBJEPCAJ ENCJCIACFFP, GameObject GFMFIKAEGOG, RenderTexture BOPKABBIJAM, ImposterRenderConfig JEHIHEHOHKK, HOHDCJFFAJD FEGJAAMOCDN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int PFDLNHGNJHI = 1;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int GMHKADMHABN = 6;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static global::DNBNOMMLHDF<CDKOAOKGILJ, RenderTexture> HFACBHMAPAH;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static readonly List<CDKOAOKGILJ> JJIMIAADILA;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int MIOFEIKBBKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7C7050", Offset = "0x7C6050", VA = "0x1807C7050")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5E013F0", Offset = "0x5E003F0", VA = "0x185E013F0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject IHMMFKEAFAC, RenderTexture BOPKABBIJAM, ImposterRenderConfig KJEFINEMONC, HOHDCJFFAJD FEGJAAMOCDN, CancellationToken GPNLCIOKAPO, bool JPNCDBNDMAK = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5E00FF0", Offset = "0x5DFFFF0", VA = "0x185E00FF0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5E01350", Offset = "0x5E00350", VA = "0x185E01350", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5E01180", Offset = "0x5E00180", VA = "0x185E01180")]
		private static Task<RenderTexture> HDAMAKGABPG(CDKOAOKGILJ FJMLFCKIDGG, CancellationToken GPNLCIOKAPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5E018C0", Offset = "0x5E008C0", VA = "0x185E018C0")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class ABAJDIGBNMI
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static byte[] GCDEGNDFAID;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static int BBIOPAKABFB;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static int ACMEFJOAGOE;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static BigInteger MCNKOBABGEE;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
	public ABAJDIGBNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5E007F0", Offset = "0x5DFF7F0", VA = "0x185E007F0")]
	private static string DPCKFJIDOBP(byte[] BMMLDIMMAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5E00900", Offset = "0x5DFF900", VA = "0x185E00900")]
	public static string FBACHCLJNPO(byte[] HFAIGCGNPJJ, bool KDMKCCLJMIF)
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
		[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
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
