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
public class ImposterPreviewCustomFraming : MonoBehaviour, GOABACBCJBG
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float COAOIECOHDA = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "4")]
	public void PrepareImposter(ABOCEGGFIII OKFGJOLPNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x57D7630", Offset = "0x57D6230", VA = "0x1857D7630")]
	public void SetReferencePoint(Vector3 PHMCCHPIHON, Quaternion FNKFECDNDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x57D7390", Offset = "0x57D5F90", VA = "0x1857D7390")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x57D75C0", Offset = "0x57D61C0", VA = "0x1857D75C0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x126D5D0", Offset = "0x126C1D0", VA = "0x18126D5D0")]
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
		[FKBMPBMBLBA(PFBNBFOHPDG.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const int DBPEDFMBECB = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int CPLMNDGAJGC = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly List<Material> JPIOOKJAIKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool PJHAMPHIMDF;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x57D77F0", Offset = "0x57D63F0", VA = "0x1857D77F0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x57D76F0", Offset = "0x57D62F0", VA = "0x1857D76F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x57D79D0", Offset = "0x57D65D0", VA = "0x1857D79D0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class CenterInImposter : MonoBehaviour, GOABACBCJBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x57D36F0", Offset = "0x57D22F0", VA = "0x1857D36F0", Slot = "4")]
		public void PrepareImposter(ABOCEGGFIII OKFGJOLPNEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE66B60", Offset = "0xE65760", VA = "0x180E66B60")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xE66B60", Offset = "0xE65760", VA = "0x180E66B60")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GOABACBCJBG
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(ABOCEGGFIII OKFGJOLPNEO);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface ALJMGCEILBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> EEIPAIBMABE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> EOLNALCLBDK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface PEBHHMBKHJI
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MCEGGLJMKCA(params Type[] GMEAGHGEJOI);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MJFEINIJDHL(params Type[] GMEAGHGEJOI);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject LAAKOGPAJFJ(GameObject LILAAJNNHHA, Transform PPHLLODMENC, bool EMIDIBHMIHA = false);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T LAAKOGPAJFJ<T>(T LILAAJNNHHA, Transform PPHLLODMENC, bool EMIDIBHMIHA = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T LAAKOGPAJFJ<T>(GameObject LILAAJNNHHA, Transform PPHLLODMENC, bool EMIDIBHMIHA = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject LAAKOGPAJFJ(GameObject LILAAJNNHHA, Transform PPHLLODMENC, ABOCEGGFIII OKFGJOLPNEO, bool EMIDIBHMIHA);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T LAAKOGPAJFJ<T>(GameObject LILAAJNNHHA, Transform PPHLLODMENC, ABOCEGGFIII OKFGJOLPNEO, bool EMIDIBHMIHA) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T LAAKOGPAJFJ<T>(T LILAAJNNHHA, Transform PPHLLODMENC, ABOCEGGFIII OKFGJOLPNEO, bool EMIDIBHMIHA) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class IGHBDFFNECA : IDisposable, PEBHHMBKHJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HashSet<Type> DPHNBPCHHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly HashSet<Type> MKPHKIPAKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Transform KMBKBKCNOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<Component> POFMEBBILHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> HNNEBPGOLDN;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x57D49C0", Offset = "0x57D35C0", VA = "0x1857D49C0")]
	[DHIFEAMMLEG]
	public static void EEACHKEKNAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x57D5270", Offset = "0x57D3E70", VA = "0x1857D5270")]
	[Preserve]
	public IGHBDFFNECA([MKAKJMIGCBM(null)] ALJMGCEILBJ BLIGCNCAHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x57D48C0", Offset = "0x57D34C0", VA = "0x1857D48C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x57D51D0", Offset = "0x57D3DD0", VA = "0x1857D51D0", Slot = "5")]
	public void MCEGGLJMKCA(params Type[] GMEAGHGEJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x57D5220", Offset = "0x57D3E20", VA = "0x1857D5220", Slot = "6")]
	public void MJFEINIJDHL(params Type[] GMEAGHGEJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x57D50B0", Offset = "0x57D3CB0", VA = "0x1857D50B0", Slot = "7")]
	public GameObject LAAKOGPAJFJ(GameObject LILAAJNNHHA, Transform PPHLLODMENC, bool EMIDIBHMIHA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x33DCBE0", Offset = "0x33DB7E0", VA = "0x1833DCBE0", Slot = "8")]
	public T LAAKOGPAJFJ<T>(T LILAAJNNHHA, Transform PPHLLODMENC, bool EMIDIBHMIHA = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x33DCBB0", Offset = "0x33DB7B0", VA = "0x1833DCBB0", Slot = "9")]
	public T LAAKOGPAJFJ<T>(GameObject LILAAJNNHHA, Transform PPHLLODMENC, bool EMIDIBHMIHA = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x57D5140", Offset = "0x57D3D40", VA = "0x1857D5140", Slot = "10")]
	public GameObject LAAKOGPAJFJ(GameObject LILAAJNNHHA, Transform PPHLLODMENC, ABOCEGGFIII OKFGJOLPNEO, bool EMIDIBHMIHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x33DC620", Offset = "0x33DB220", VA = "0x1833DC620", Slot = "11")]
	public T LAAKOGPAJFJ<T>(GameObject LILAAJNNHHA, Transform PPHLLODMENC, ABOCEGGFIII OKFGJOLPNEO, bool EMIDIBHMIHA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x33DC590", Offset = "0x33DB190", VA = "0x1833DC590", Slot = "12")]
	public T LAAKOGPAJFJ<T>(T LILAAJNNHHA, Transform PPHLLODMENC, ABOCEGGFIII OKFGJOLPNEO, bool EMIDIBHMIHA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x33DC670", Offset = "0x33DB270", VA = "0x1833DC670")]
	private T LAAKOGPAJFJ<T>(GameObject LILAAJNNHHA, Transform PPHLLODMENC, ABOCEGGFIII OKFGJOLPNEO, bool EMIDIBHMIHA, out GameObject AFHLJOIDDOA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x33DC110", Offset = "0x33DAD10", VA = "0x1833DC110")]
	private T CMLFFNCJIEO<T>(GameObject JPIPKHMPCNE, ABOCEGGFIII OKFGJOLPNEO, bool EMIDIBHMIHA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x57D4B20", Offset = "0x57D3720", VA = "0x1857D4B20")]
	private void IOGFMHKFLNE(Component GPCFBGLDMBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x57D4C40", Offset = "0x57D3840", VA = "0x1857D4C40")]
	private void IONEOMJPHKK(Component GPCFBGLDMBJ, ABOCEGGFIII OKFGJOLPNEO, bool EMIDIBHMIHA, [Optional] Type HDFKNHOPNGI, [Optional] Type PBANILEGDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x57D4780", Offset = "0x57D3380", VA = "0x1857D4780")]
	private void DJPMOCLMHDN(GameObject JPIPKHMPCNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct ABOCEGGFIII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<Type, object> FIMMLEPDFJJ;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x23852D0", Offset = "0x2383ED0", VA = "0x1823852D0")]
	public ABOCEGGFIII KCACFLLCKKN<T>(T HPLLIJEIOJA)
	{
		return default(ABOCEGGFIII);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1D83AE0", Offset = "0x1D826E0", VA = "0x181D83AE0")]
	public T LBHEOGGFILM<T>(T NGILKOOHDPD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x28A20B0", Offset = "0x28A0CB0", VA = "0x1828A20B0")]
	public bool KKAHJGPJCBE<T>(out T HPLLIJEIOJA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct IJBKMNOHBBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public bool KICKBBGIPBB;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xE39C90", Offset = "0xE38890", VA = "0x180E39C90")]
	public IJBKMNOHBBH(bool ABIJOLILHOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct JHJEMJGIDGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly bool CFDIGPJEPOO;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x57D7A40", Offset = "0x57D6640", VA = "0x1857D7A40")]
	public JHJEMJGIDGB(bool GOLIDLFPHFO)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xE66B60", Offset = "0xE65760", VA = "0x180E66B60")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ScaleInImposter : MonoBehaviour, GOABACBCJBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x57D7A80", Offset = "0x57D6680", VA = "0x1857D7A80", Slot = "4")]
		public void PrepareImposter(ABOCEGGFIII OKFGJOLPNEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xE66B60", Offset = "0xE65760", VA = "0x180E66B60")]
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
				[Cpp2IlInjected.Address(RVA = "0x57D7A60", Offset = "0x57D6660", VA = "0x1857D7A60")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x57D7A50", Offset = "0x57D6650", VA = "0x1857D7A50")]
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
		[Cpp2IlInjected.Address(RVA = "0x57D7670", Offset = "0x57D6270", VA = "0x1857D7670")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class IJCOPKIONHI
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly List<URPLight> PBCMDDPBIEM;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly Vector3 APCIMFIFGCG;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Vector3 EMFDKIHAIOJ;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static Camera HEHEJGMNIMF;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public const string IAKOMICDKCJ = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public const NIFMNKJCMHB GFJIDPLENOL = NIFMNKJCMHB.Water;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly List<Renderer> HOJHHELCGBE;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static AmbientMode FBLBAJEAOKM;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color NPMHGFPGNAE;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static Color ODJFOINEKFD;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static Color BKAPMFJEEBI;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static Cubemap DNCHDLAJEAG;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static bool BEJOIFKIHKE;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera DLNOBEADFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x57D5980", Offset = "0x57D4580", VA = "0x1857D5980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x57D6510", Offset = "0x57D5110", VA = "0x1857D6510")]
	public static void COKFBDLOCFL(Vector3 OCHIGGKJAEO, Quaternion IDGANPOGIPL, ImposterRenderConfig APLDMENHBPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x57D55A0", Offset = "0x57D41A0", VA = "0x1857D55A0")]
	private static void AAGBLHHGHIN(Vector3 OCHIGGKJAEO, Quaternion IDGANPOGIPL, URPLight JGANJLPGEOO, ImposterRenderConfig.LightConfig DNPJIGMGGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x57D6430", Offset = "0x57D5030", VA = "0x1857D6430")]
	public static void CJGCCEGLGMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x57D6C30", Offset = "0x57D5830", VA = "0x1857D6C30")]
	private static void MDOBJHNJCGH(int NDGNFNJBDLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x57D70C0", Offset = "0x57D5CC0", VA = "0x1857D70C0")]
	public static void PJKHKNBCEFI(ImposterRenderConfig APLDMENHBPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x57D5B80", Offset = "0x57D4780", VA = "0x1857D5B80")]
	public static void BNJGFMDIODD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x57D6F30", Offset = "0x57D5B30", VA = "0x1857D6F30")]
	public static void MMDFCIAKMCA(GameObject MACFNAHNABD, RenderTexture IACMDDLPFPA, ImposterRenderConfig APLDMENHBPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x57D5F10", Offset = "0x57D4B10", VA = "0x1857D5F10")]
	private static void CDJCHOLKPHC(GameObject MACFNAHNABD, RenderTexture IACMDDLPFPA, ImposterRenderConfig APLDMENHBPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x57D5C80", Offset = "0x57D4880", VA = "0x1857D5C80")]
	private static void BOMIBEJIDCF(GameObject MACFNAHNABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x57D6AA0", Offset = "0x57D56A0", VA = "0x1857D6AA0")]
	public static void IIIILMJLIDM(List<Renderer> KMMBIOCPCMK, List<Material> OKIKPJOFOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x57D6790", Offset = "0x57D5390", VA = "0x1857D6790")]
	private static void HKBDAHNGCNF(GameObject LILAAJNNHHA, Vector3 ALICDFKPCMJ, Vector3 NDNNCCBHJKL, float LNHOCNJEJBK, out Vector3 PEFEDMPOOOG, out Quaternion PIELEGKMLIA, out float DDLAAOLDKIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x57D58E0", Offset = "0x57D44E0", VA = "0x1857D58E0")]
	public static RenderTexture AIMOKJCKCKN(int OMHAPPIIDLM, int HPMPKHBFKPL)
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
		public struct BKJAIKJEHFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public DLLPNBKFAHM IAJPBKAIKDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public GameObject JJEJBKFJIEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public RenderTexture FICCFJBGFON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public ImposterRenderConfig LNCLONJDKLF;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x4B75670", Offset = "0x4B74270", VA = "0x184B75670")]
			public BKJAIKJEHFJ(DLLPNBKFAHM FPDFPEPCDEA, GameObject OEOGPKLGHCO, RenderTexture IACMDDLPFPA, ImposterRenderConfig LBPFCAAHNCI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const int JKNOMHNIOEI = 1;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int JNMIFHPJMIE = 6;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static global::BFCIFNGJBLJ<BKJAIKJEHFJ, RenderTexture> OIKJPAHIEJN;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static readonly List<BKJAIKJEHFJ> NNIFAAFBMNI;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int EFOAPMMLOEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x91C010", Offset = "0x91AC10", VA = "0x18091C010")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x57D3D50", Offset = "0x57D2950", VA = "0x1857D3D50")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject MACFNAHNABD, RenderTexture IACMDDLPFPA, ImposterRenderConfig APLDMENHBPH, CancellationToken NKLNCNDPFGD, bool HCDOCAAHBGM = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x57D3870", Offset = "0x57D2470", VA = "0x1857D3870", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x57D3CC0", Offset = "0x57D28C0", VA = "0x1857D3CC0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x57D3990", Offset = "0x57D2590", VA = "0x1857D3990")]
		private static Task<RenderTexture> ILMNCGKGFIE(BKJAIKJEHFJ NNNMACPKJNA, CancellationToken NKLNCNDPFGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x57D4130", Offset = "0x57D2D30", VA = "0x1857D4130")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FFJPKCHAMHH
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static byte[] JNJHEFFMOCP;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int IPFMGPPGOLG;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static int LHFIEOGDAOP;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static BigInteger AMDHHIFBNAO;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public FFJPKCHAMHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x57D44C0", Offset = "0x57D30C0", VA = "0x1857D44C0")]
	private static string OFIDAIMKACA(byte[] DBJNEGCCKCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x57D4190", Offset = "0x57D2D90", VA = "0x1857D4190")]
	public static string MOEDIEOHEKO(byte[] DNJADMBKFKK, bool KBNEPACBOAE)
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
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
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
