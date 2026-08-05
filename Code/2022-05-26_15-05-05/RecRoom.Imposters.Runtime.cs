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
public class ImposterPreviewCustomFraming : MonoBehaviour, MNEPFKKHCIM
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float OMAGINIENFP = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "4")]
	public void PrepareImposter(NDJKOALONAI FHLPJMHKMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4E1A270", Offset = "0x4E18870", VA = "0x184E1A270")]
	public void SetReferencePoint(Vector3 LFIBJEOHDKD, Quaternion NOHAMBCGIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4E19FD0", Offset = "0x4E185D0", VA = "0x184E19FD0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4E1A200", Offset = "0x4E18800", VA = "0x184E1A200")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1054070", Offset = "0x1052670", VA = "0x181054070")]
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
		[DPGOFBBDGFL(BHKPCKHAKLF.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const int NNKKFNJJBCA = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int GDKNBFOAHFC = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly List<Material> DAKAHJNPOKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool MOJPPGMCLPE;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4E1A430", Offset = "0x4E18A30", VA = "0x184E1A430")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4E1A330", Offset = "0x4E18930", VA = "0x184E1A330")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4E1A610", Offset = "0x4E18C10", VA = "0x184E1A610")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class CenterInImposter : MonoBehaviour, MNEPFKKHCIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4E18F60", Offset = "0x4E17560", VA = "0x184E18F60", Slot = "4")]
		public void PrepareImposter(NDJKOALONAI FHLPJMHKMFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xCE3700", Offset = "0xCE1D00", VA = "0x180CE3700")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xCE3700", Offset = "0xCE1D00", VA = "0x180CE3700")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MNEPFKKHCIM
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(NDJKOALONAI FHLPJMHKMFC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BDPOCNEDLNI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> HNIKPCHCAAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> KIHAPIMCIKA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface DCPBDABJIPL
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBMODGPKMNG(params Type[] OGHPIEEPAII);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PDAKMAPHJLE(params Type[] OGHPIEEPAII);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject AGKPPLLNBCK(GameObject EKKOANIDOHH, Transform COLFLONKFJK, bool HFJJDBDDCJL = false);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T AGKPPLLNBCK<T>(T EKKOANIDOHH, Transform COLFLONKFJK, bool HFJJDBDDCJL = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T AGKPPLLNBCK<T>(GameObject EKKOANIDOHH, Transform COLFLONKFJK, bool HFJJDBDDCJL = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject AGKPPLLNBCK(GameObject EKKOANIDOHH, Transform COLFLONKFJK, NDJKOALONAI FHLPJMHKMFC, bool HFJJDBDDCJL);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T AGKPPLLNBCK<T>(GameObject EKKOANIDOHH, Transform COLFLONKFJK, NDJKOALONAI FHLPJMHKMFC, bool HFJJDBDDCJL) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T AGKPPLLNBCK<T>(T EKKOANIDOHH, Transform COLFLONKFJK, NDJKOALONAI FHLPJMHKMFC, bool HFJJDBDDCJL) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class PGAGMBBFIMO : IDisposable, DCPBDABJIPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HashSet<Type> GKCCHIPAAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly HashSet<Type> CFAIKCJOCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Transform BHBLPPHOHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<Component> JJOJHFEEHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> ECMNPEBBNNE;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4E1A8D0", Offset = "0x4E18ED0", VA = "0x184E1A8D0")]
	[MBNOPHMLNBM]
	public static void FCKCGNJAGPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4E1B1A0", Offset = "0x4E197A0", VA = "0x184E1B1A0")]
	[Preserve]
	public PGAGMBBFIMO([IOLMGJIHJFK(null)] BDPOCNEDLNI IPHHAHJIHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4E1A7D0", Offset = "0x4E18DD0", VA = "0x184E1A7D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4E1AA30", Offset = "0x4E19030", VA = "0x184E1AA30", Slot = "5")]
	public void GBMODGPKMNG(params Type[] OGHPIEEPAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4E1B150", Offset = "0x4E19750", VA = "0x184E1B150", Slot = "6")]
	public void PDAKMAPHJLE(params Type[] OGHPIEEPAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4E1A6B0", Offset = "0x4E18CB0", VA = "0x184E1A6B0", Slot = "7")]
	public GameObject AGKPPLLNBCK(GameObject EKKOANIDOHH, Transform COLFLONKFJK, bool HFJJDBDDCJL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1E28330", Offset = "0x1E26930", VA = "0x181E28330", Slot = "8")]
	public T AGKPPLLNBCK<T>(T EKKOANIDOHH, Transform COLFLONKFJK, bool HFJJDBDDCJL = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1E28430", Offset = "0x1E26A30", VA = "0x181E28430", Slot = "9")]
	public T AGKPPLLNBCK<T>(GameObject EKKOANIDOHH, Transform COLFLONKFJK, bool HFJJDBDDCJL = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4E1A740", Offset = "0x4E18D40", VA = "0x184E1A740", Slot = "10")]
	public GameObject AGKPPLLNBCK(GameObject EKKOANIDOHH, Transform COLFLONKFJK, NDJKOALONAI FHLPJMHKMFC, bool HFJJDBDDCJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1E28A20", Offset = "0x1E27020", VA = "0x181E28A20", Slot = "11")]
	public T AGKPPLLNBCK<T>(GameObject EKKOANIDOHH, Transform COLFLONKFJK, NDJKOALONAI FHLPJMHKMFC, bool HFJJDBDDCJL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1E283A0", Offset = "0x1E269A0", VA = "0x181E283A0", Slot = "12")]
	public T AGKPPLLNBCK<T>(T EKKOANIDOHH, Transform COLFLONKFJK, NDJKOALONAI FHLPJMHKMFC, bool HFJJDBDDCJL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1E28460", Offset = "0x1E26A60", VA = "0x181E28460")]
	private T AGKPPLLNBCK<T>(GameObject EKKOANIDOHH, Transform COLFLONKFJK, NDJKOALONAI FHLPJMHKMFC, bool HFJJDBDDCJL, out GameObject KJLOKBIPMLO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1E28A70", Offset = "0x1E27070", VA = "0x181E28A70")]
	private T DMBHDHMADJH<T>(GameObject NIKGFIPEJKD, NDJKOALONAI FHLPJMHKMFC, bool HFJJDBDDCJL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4E1AA80", Offset = "0x4E19080", VA = "0x184E1AA80")]
	private void HIKJKJNKJAM(Component LPKJELLIJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4E1ABA0", Offset = "0x4E191A0", VA = "0x184E1ABA0")]
	private void KKMACICKCEH(Component LPKJELLIJFF, NDJKOALONAI FHLPJMHKMFC, bool HFJJDBDDCJL, [Optional] Type PKNCBNALKMC, [Optional] Type ANFDOIELCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4E1B010", Offset = "0x4E19610", VA = "0x184E1B010")]
	private void LCDJBEJPCHG(GameObject NIKGFIPEJKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct NDJKOALONAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<Type, object> LJJNJHEPOLJ;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1D9FC80", Offset = "0x1D9E280", VA = "0x181D9FC80")]
	public NDJKOALONAI KJOMPIGOOHG<T>(T JIGKFMMLBHO)
	{
		return default(NDJKOALONAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1E24880", Offset = "0x1E22E80", VA = "0x181E24880")]
	public T NELNIMGBJDL<T>(T IEELHBAALFA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1EF73D0", Offset = "0x1EF59D0", VA = "0x181EF73D0")]
	public bool ODOHFJDGPNB<T>(out T JIGKFMMLBHO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct JHFMIODOANA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public bool MDDIKAHCACM;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xCC6880", Offset = "0xCC4E80", VA = "0x180CC6880")]
	public JHFMIODOANA(bool DNMACKEAFBC)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xCE3700", Offset = "0xCE1D00", VA = "0x180CE3700")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ScaleInImposter : MonoBehaviour, MNEPFKKHCIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4E1B4D0", Offset = "0x4E19AD0", VA = "0x184E1B4D0", Slot = "4")]
		public void PrepareImposter(NDJKOALONAI FHLPJMHKMFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xCE3700", Offset = "0xCE1D00", VA = "0x180CE3700")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CreateAssetMenu]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0x4E1A690", Offset = "0x4E18C90", VA = "0x184E1A690")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x4E1A680", Offset = "0x4E18C80", VA = "0x184E1A680")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4E1A2B0", Offset = "0x4E188B0", VA = "0x184E1A2B0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class CICNOFFPODB
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly List<URPLight> FMOFMFGFHMK;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly Vector3 COHFBNMAIMC;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly Vector3 CLEHCBHGJDF;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static Camera BLFOCFKBLAA;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public const string EAINKBPGKKO = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public const NLGDOBMOMBI CFJLEKGOKLK = NLGDOBMOMBI.Water;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly List<Renderer> CGMIOIGNCEH;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static AmbientMode EHANNHJCOPM;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Color BIGPDMCGKND;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color FNFPPHMPMKE;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static Color AIBAGKJFKGH;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static Cubemap BFCIMCNAKJP;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static bool JAFCKCLJPEC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera FIICOBDEHOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4E18800", Offset = "0x4E16E00", VA = "0x184E18800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4E18580", Offset = "0x4E16B80", VA = "0x184E18580")]
	public static void JPMDEJCNEKJ(Vector3 LGPCMFPILIC, Quaternion JDGDJDDAEDA, ImposterRenderConfig ILNLFCNJHOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4E17D40", Offset = "0x4E16340", VA = "0x184E17D40")]
	private static void GGABHHPICHM(Vector3 LGPCMFPILIC, Quaternion JDGDJDDAEDA, URPLight LKKPEKPEHDI, ImposterRenderConfig.LightConfig GNFLLKBNHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4E184A0", Offset = "0x4E16AA0", VA = "0x184E184A0")]
	public static void JJINPDHBHAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4E17210", Offset = "0x4E15810", VA = "0x184E17210")]
	private static void CPMIHLAOMDB(int HDEFIMIIMOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4E18C90", Offset = "0x4E17290", VA = "0x184E18C90")]
	public static void LIPGBIOHHEB(ImposterRenderConfig ILNLFCNJHOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4E18080", Offset = "0x4E16680", VA = "0x184E18080")]
	public static void HFNHFGKLOPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4E18310", Offset = "0x4E16910", VA = "0x184E18310")]
	public static void HPDGKANLKIK(GameObject MCGPLOOPFBP, RenderTexture GKKMFGHFBIE, ImposterRenderConfig ILNLFCNJHOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4E17510", Offset = "0x4E15B10", VA = "0x184E17510")]
	private static void DELHLIGLNPA(GameObject MCGPLOOPFBP, RenderTexture GKKMFGHFBIE, ImposterRenderConfig ILNLFCNJHOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4E18A00", Offset = "0x4E17000", VA = "0x184E18A00")]
	private static void LGGILOAGBGG(GameObject MCGPLOOPFBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4E18180", Offset = "0x4E16780", VA = "0x184E18180")]
	public static void HMOFKNMAMCP(List<Renderer> GAILPBMMGNB, List<Material> LNLMDDPLJPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4E17A30", Offset = "0x4E16030", VA = "0x184E17A30")]
	private static void ELBGMGBIIIM(GameObject EKKOANIDOHH, Vector3 LJKEHNMIKKP, Vector3 DLFCPFIHODF, float MDGIMENOPCD, out Vector3 OEPGNFNFJFG, out Quaternion EPPJPDFCJHF, out float CCAFDDKPKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4E17170", Offset = "0x4E15770", VA = "0x184E17170")]
	public static RenderTexture BDPFPEHNPOD(int KIDBPFAHLEE, int CNJPPLLLBHD)
	{
		return null;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public struct HOMOFOPAFPA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public BNGELMJMADH LKNHLIONGOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public GameObject LKIOONIBIAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public RenderTexture KHFGOHDDADG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public ImposterRenderConfig GGHANJIDEBE;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x4358000", Offset = "0x4356600", VA = "0x184358000")]
			public HOMOFOPAFPA(BNGELMJMADH PNEBNJNAOIA, GameObject FCHLDGCMMKN, RenderTexture GKKMFGHFBIE, ImposterRenderConfig MNPIOGADDAH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const int AOKJPLKCGNG = 1;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const int HBMEGMFKLOG = 6;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static global::EKHPPECGNEP<HOMOFOPAFPA, RenderTexture> ADMEKCDCBIA;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static readonly List<HOMOFOPAFPA> POPDHIJEKOH;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int CJOKGNFEJCF
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8605C0", Offset = "0x85EBC0", VA = "0x1808605C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4E195A0", Offset = "0x4E17BA0", VA = "0x184E195A0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject MCGPLOOPFBP, RenderTexture GKKMFGHFBIE, ImposterRenderConfig ILNLFCNJHOD, CancellationToken CMOIBOJIACL, bool IHDILNMDICD = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4E190C0", Offset = "0x4E176C0", VA = "0x184E190C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4E19510", Offset = "0x4E17B10", VA = "0x184E19510", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4E191E0", Offset = "0x4E177E0", VA = "0x184E191E0")]
		private static Task<RenderTexture> MDMPIJPOMCF(HOMOFOPAFPA BFMBHECMCAO, CancellationToken CMOIBOJIACL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4E19980", Offset = "0x4E17F80", VA = "0x184E19980")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class HGPPKMCDCLL
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] PIDGMPFPDGI;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int CONMIAOECKG;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int PDHBFKNINGO;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger EDLLKHJPMCN;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public HGPPKMCDCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4E199E0", Offset = "0x4E17FE0", VA = "0x184E199E0")]
	private static string CKGLFMJKOPM(byte[] IIFMPDAMAIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4E19AE0", Offset = "0x4E180E0", VA = "0x184E19AE0")]
	public static string IOHOBOIOFIG(byte[] KFCJKMJDFKE, bool OLNJLDMOIJP)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
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
