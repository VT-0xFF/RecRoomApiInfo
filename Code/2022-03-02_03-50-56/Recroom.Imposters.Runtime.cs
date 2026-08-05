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
public class ImposterPreviewCustomFraming : MonoBehaviour, FGGGKAOAKDB
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float LJMMPJIBDKN = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x50DB30", Offset = "0x50CB30", VA = "0x18050DB30", Slot = "4")]
	public void PrepareImposter(GOGKGFJDHFL INNGGBGHBPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x49B1930", Offset = "0x49B0930", VA = "0x1849B1930")]
	public void SetReferencePoint(Vector3 HPOBHBMBPBE, Quaternion POFECIHKPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x49B1690", Offset = "0x49B0690", VA = "0x1849B1690")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x49B18C0", Offset = "0x49B08C0", VA = "0x1849B18C0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xC839B0", Offset = "0xC829B0", VA = "0x180C839B0")]
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
		[KOMIOHHCHBI(EOFKBLFJCEN.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const int GKGOJHDEICM = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int OEEADJBNCGN = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly List<Material> EEPFJGIELBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool EANLDMENCFJ;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x49B1AF0", Offset = "0x49B0AF0", VA = "0x1849B1AF0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x49B19F0", Offset = "0x49B09F0", VA = "0x1849B19F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x49B1CD0", Offset = "0x49B0CD0", VA = "0x1849B1CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x50DA60", Offset = "0x50CA60", VA = "0x18050DA60")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FGGGKAOAKDB
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(GOGKGFJDHFL INNGGBGHBPE);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DDNPLKNAPLG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> AGDCKMDNHFL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> MJNPPACJLNI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EHPKJCOBLLC
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBKHNPHNFMP(params Type[] NCPOJLMGENN);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OOPBNEOMEIC(params Type[] NCPOJLMGENN);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject JLGFEAPJCEE(GameObject HKEIKNBJEAC, Transform OACJHOOKBCN, bool EPGEHBHPOLN = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T JLGFEAPJCEE<T>(T HKEIKNBJEAC, Transform OACJHOOKBCN, bool EPGEHBHPOLN = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T JLGFEAPJCEE<T>(GameObject HKEIKNBJEAC, Transform OACJHOOKBCN, bool EPGEHBHPOLN = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject JLGFEAPJCEE(GameObject HKEIKNBJEAC, Transform OACJHOOKBCN, GOGKGFJDHFL INNGGBGHBPE, bool EPGEHBHPOLN);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T JLGFEAPJCEE<T>(GameObject HKEIKNBJEAC, Transform OACJHOOKBCN, GOGKGFJDHFL INNGGBGHBPE, bool EPGEHBHPOLN) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T JLGFEAPJCEE<T>(T HKEIKNBJEAC, Transform OACJHOOKBCN, GOGKGFJDHFL INNGGBGHBPE, bool EPGEHBHPOLN) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class AJABFBGLAEC : IDisposable, EHPKJCOBLLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly HashSet<Type> APCFIGNDDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HashSet<Type> CFDKGAAAMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Transform MHJPKFPCLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly List<Component> LAJFBNAEDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> HAMPONFOIBC;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x49AF980", Offset = "0x49AE980", VA = "0x1849AF980")]
	[OMADDHCKKDI]
	public static void DHABPNIAJJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x49B0470", Offset = "0x49AF470", VA = "0x1849B0470")]
	[Preserve]
	public AJABFBGLAEC([NEDLFOAEMOK(null)] DDNPLKNAPLG LHPHFBHHKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x49AFC00", Offset = "0x49AEC00", VA = "0x1849AFC00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x49AFD00", Offset = "0x49AED00", VA = "0x1849AFD00", Slot = "5")]
	public void GBKHNPHNFMP(params Type[] NCPOJLMGENN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x49B0420", Offset = "0x49AF420", VA = "0x1849B0420", Slot = "6")]
	public void OOPBNEOMEIC(params Type[] NCPOJLMGENN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x49AFE90", Offset = "0x49AEE90", VA = "0x1849AFE90", Slot = "7")]
	public GameObject JLGFEAPJCEE(GameObject HKEIKNBJEAC, Transform OACJHOOKBCN, bool EPGEHBHPOLN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x262E470", Offset = "0x262D470", VA = "0x18262E470", Slot = "8")]
	public T JLGFEAPJCEE<T>(T HKEIKNBJEAC, Transform OACJHOOKBCN, bool EPGEHBHPOLN = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x262E4E0", Offset = "0x262D4E0", VA = "0x18262E4E0", Slot = "9")]
	public T JLGFEAPJCEE<T>(GameObject HKEIKNBJEAC, Transform OACJHOOKBCN, bool EPGEHBHPOLN = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x49AFF20", Offset = "0x49AEF20", VA = "0x1849AFF20", Slot = "10")]
	public GameObject JLGFEAPJCEE(GameObject HKEIKNBJEAC, Transform OACJHOOKBCN, GOGKGFJDHFL INNGGBGHBPE, bool EPGEHBHPOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x262E510", Offset = "0x262D510", VA = "0x18262E510", Slot = "11")]
	public T JLGFEAPJCEE<T>(GameObject HKEIKNBJEAC, Transform OACJHOOKBCN, GOGKGFJDHFL INNGGBGHBPE, bool EPGEHBHPOLN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x262E080", Offset = "0x262D080", VA = "0x18262E080", Slot = "12")]
	public T JLGFEAPJCEE<T>(T HKEIKNBJEAC, Transform OACJHOOKBCN, GOGKGFJDHFL INNGGBGHBPE, bool EPGEHBHPOLN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x262E110", Offset = "0x262D110", VA = "0x18262E110")]
	private T JLGFEAPJCEE<T>(GameObject HKEIKNBJEAC, Transform OACJHOOKBCN, GOGKGFJDHFL INNGGBGHBPE, bool EPGEHBHPOLN, out GameObject HJHDHGGOOJP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x262DBD0", Offset = "0x262CBD0", VA = "0x18262DBD0")]
	private T EGOOIMJPCOI<T>(GameObject MNCBMNIPDNH, GOGKGFJDHFL INNGGBGHBPE, bool EPGEHBHPOLN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x49AFAE0", Offset = "0x49AEAE0", VA = "0x1849AFAE0")]
	private void DNOPLJJBHBO(Component PGAOKOADAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x49AFFB0", Offset = "0x49AEFB0", VA = "0x1849AFFB0")]
	private void NABFPFIIIPH(Component PGAOKOADAHN, GOGKGFJDHFL INNGGBGHBPE, bool EPGEHBHPOLN, [Optional] Type MAJACHNAFLP, [Optional] Type EMKLDMDDHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x49AFD50", Offset = "0x49AED50", VA = "0x1849AFD50")]
	private void GGGPMGDJOOL(GameObject MNCBMNIPDNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct GOGKGFJDHFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Dictionary<Type, object> OGLMENEOPNG;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x225E180", Offset = "0x225D180", VA = "0x18225E180")]
	public GOGKGFJDHFL NOIJBADHPIF<T>(T FAFNNELAHLD)
	{
		return default(GOGKGFJDHFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2638F20", Offset = "0x2637F20", VA = "0x182638F20")]
	public T AKCFEJPPDDL<T>(T NNAJIOOELOL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2517AE0", Offset = "0x2516AE0", VA = "0x182517AE0")]
	public bool ONDACHGCFFH<T>(out T FAFNNELAHLD)
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
				[Cpp2IlInjected.Address(RVA = "0x49B1D50", Offset = "0x49B0D50", VA = "0x1849B1D50")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x49B1D40", Offset = "0x49B0D40", VA = "0x1849B1D40")]
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
		[Cpp2IlInjected.Address(RVA = "0x49B1970", Offset = "0x49B0970", VA = "0x1849B1970")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class PKHONOBHDCO
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly List<URPLight> GGEAOCAPNLC;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly Vector3 KDOECLNMBAO;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly Vector3 FCHAOJJGPBM;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static Camera ICJJJGJNOKH;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public const string NEMOLKJKMEO = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const GCDNKCGGGGA GMJBFJMHCHB = GCDNKCGGGGA.Water;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<Renderer> JABKOOJGHDO;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static AmbientMode GBJDBFNMONO;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static Color FGKCILJLBPA;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static Color PMKBEIAFMGF;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static Color JEINDENJHNH;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Cubemap NCGJMDEGFNE;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static bool LDFDAJMLBMK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera MIDJHMNMMHO
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x49B2300", Offset = "0x49B1300", VA = "0x1849B2300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x49B3720", Offset = "0x49B2720", VA = "0x1849B3720")]
	public static void MADMDLLOKNE(Vector3 FNNAJEICHFB, Quaternion CBNEBJMDHJH, ImposterRenderConfig OAMHNNKHFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x49B2AA0", Offset = "0x49B1AA0", VA = "0x1849B2AA0")]
	private static void IEEPFMIAHAP(Vector3 FNNAJEICHFB, Quaternion CBNEBJMDHJH, URPLight HEBOLLALKDA, ImposterRenderConfig.LightConfig GCJHIOOPCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x49B3A40", Offset = "0x49B2A40", VA = "0x1849B3A40")]
	public static void PPIBNNNIBIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x49B2000", Offset = "0x49B1000", VA = "0x1849B2000")]
	private static void CCNBDILFJNG(int FNHHGHHLFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x49B2920", Offset = "0x49B1920", VA = "0x1849B2920")]
	public static void IDGBLACNBIE(ImposterRenderConfig OAMHNNKHFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x49B1F00", Offset = "0x49B0F00", VA = "0x1849B1F00")]
	public static void BILAHCBAJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x49B2790", Offset = "0x49B1790", VA = "0x1849B2790")]
	public static void HPHDBJHKMBA(GameObject OHJLOLOADAP, RenderTexture FBDGJPAMFGN, ImposterRenderConfig OAMHNNKHFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x49B31D0", Offset = "0x49B21D0", VA = "0x1849B31D0")]
	private static void LLJPIDPPDDH(GameObject OHJLOLOADAP, RenderTexture FBDGJPAMFGN, ImposterRenderConfig OAMHNNKHFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x49B2500", Offset = "0x49B1500", VA = "0x1849B2500")]
	private static void FLFFDECIMKE(GameObject OHJLOLOADAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x49B1D70", Offset = "0x49B0D70", VA = "0x1849B1D70")]
	public static void BHKAAPBEKGB(List<Renderer> FGNKMPJMIEA, List<Material> EMEBPMBEBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x49B2DE0", Offset = "0x49B1DE0", VA = "0x1849B2DE0")]
	private static void IGIILDPMPFF(List<Renderer> FGNKMPJMIEA, Vector3 DGOBOEADBFC, Vector3 AKIBCNPEODM, float ANJGEKGLELK, out Vector3 NFLAAAGGNND, out Quaternion OKCBEGBKEJJ, out float AMNPGGHMNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x49B39A0", Offset = "0x49B29A0", VA = "0x1849B39A0")]
	public static RenderTexture NDLDJKMPNJE(int AGCGFKAOCBO, int DGPMNFKJNDI)
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
		public struct BDCJOHJKPGN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public MNDNBPKLGEA PNJPFEEPODJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public GameObject HBCCAIBLHGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public RenderTexture DIHPDEMODAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public ImposterRenderConfig LJMNEALNHDE;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x19FF640", Offset = "0x19FE640", VA = "0x1819FF640")]
			public BDCJOHJKPGN(MNDNBPKLGEA BONEIOHHFOL, GameObject LINLGACBDPA, RenderTexture FBDGJPAMFGN, ImposterRenderConfig DCNDBJGEKHF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const int HHKGODNEHKL = 1;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const int MHMFIIBIKKJ = 6;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static global::NPPBDKHLLFI<BDCJOHJKPGN, RenderTexture> LHJENOMLIEP;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static readonly List<BDCJOHJKPGN> OMNICPNBGKM;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int ODABBFIKOFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA67620", Offset = "0xA66620", VA = "0x180A67620")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x49B1250", Offset = "0x49B0250", VA = "0x1849B1250")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject OHJLOLOADAP, RenderTexture FBDGJPAMFGN, ImposterRenderConfig OAMHNNKHFBH, CancellationToken LDBMCJENAKJ, bool ALOGDMOFGCC = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x49B0D70", Offset = "0x49AFD70", VA = "0x1849B0D70", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x49B11C0", Offset = "0x49B01C0", VA = "0x1849B11C0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x49B0E90", Offset = "0x49AFE90", VA = "0x1849B0E90")]
		private static Task<RenderTexture> HNLBOJKELFF(BDCJOHJKPGN CFFNAHCEOHC, CancellationToken LDBMCJENAKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x49B1630", Offset = "0x49B0630", VA = "0x1849B1630")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class DLAOCNHHHPI
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static byte[] HDGCOIJLNAH;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static int OFJBPIBPJGA;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static int DJDAKEIMIDA;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static BigInteger JAEJMLKAHIB;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
	public DLAOCNHHHPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x49B0AB0", Offset = "0x49AFAB0", VA = "0x1849B0AB0")]
	private static string MKDMGNIMLKE(byte[] FFKAJGPOGIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x49B0780", Offset = "0x49AF780", VA = "0x1849B0780")]
	public static string KDCKFNHEIFO(byte[] CPFFKFOFBAE, bool FPKNOKKBPNA)
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
		[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
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
