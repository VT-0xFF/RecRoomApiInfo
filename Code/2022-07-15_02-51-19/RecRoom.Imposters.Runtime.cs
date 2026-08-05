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
public class ImposterPreviewCustomFraming : MonoBehaviour, PGMOJHKBDPM
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float EGNIJNJJBLN = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "4")]
	public void PrepareImposter(AJBBKPFHEPC HEBHFHEMFMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x51A6F00", Offset = "0x51A5F00", VA = "0x1851A6F00")]
	public void SetReferencePoint(Vector3 DANJPLHLHCE, Quaternion ONDKFDAKCBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x51A6C60", Offset = "0x51A5C60", VA = "0x1851A6C60")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x51A6E90", Offset = "0x51A5E90", VA = "0x1851A6E90")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xF18C90", Offset = "0xF17C90", VA = "0x180F18C90")]
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
		[EJHKBJPGPJF(KPKOFHBALGN.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const int JFOCHMGANFE = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int MALFFOPMNFE = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly List<Material> NMMHBNJDPOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool IHCDEBDINCD;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x51A70C0", Offset = "0x51A60C0", VA = "0x1851A70C0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x51A6FC0", Offset = "0x51A5FC0", VA = "0x1851A6FC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x51A72A0", Offset = "0x51A62A0", VA = "0x1851A72A0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class CenterInImposter : MonoBehaviour, PGMOJHKBDPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x51A5BC0", Offset = "0x51A4BC0", VA = "0x1851A5BC0", Slot = "4")]
		public void PrepareImposter(AJBBKPFHEPC HEBHFHEMFMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xDDCCF0", Offset = "0xDDBCF0", VA = "0x180DDCCF0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDDCCF0", Offset = "0xDDBCF0", VA = "0x180DDCCF0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PGMOJHKBDPM
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(AJBBKPFHEPC HEBHFHEMFMC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HDMJLEDJFMG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> BDGIDPHANFP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> CNGHBOLONJL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface JPLCKNANJFG
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BHECBDOHIOE(params Type[] MAGLJCOJOLH);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MGMNLOMOBDK(params Type[] MAGLJCOJOLH);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject BLOKIIIMPBK(GameObject PCLKDEOJIAH, Transform NKNFLMKNNCC, bool DBDAMKEJBFN = false);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T BLOKIIIMPBK<T>(T PCLKDEOJIAH, Transform NKNFLMKNNCC, bool DBDAMKEJBFN = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T BLOKIIIMPBK<T>(GameObject PCLKDEOJIAH, Transform NKNFLMKNNCC, bool DBDAMKEJBFN = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject BLOKIIIMPBK(GameObject PCLKDEOJIAH, Transform NKNFLMKNNCC, AJBBKPFHEPC HEBHFHEMFMC, bool DBDAMKEJBFN);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T BLOKIIIMPBK<T>(GameObject PCLKDEOJIAH, Transform NKNFLMKNNCC, AJBBKPFHEPC HEBHFHEMFMC, bool DBDAMKEJBFN) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T BLOKIIIMPBK<T>(T PCLKDEOJIAH, Transform NKNFLMKNNCC, AJBBKPFHEPC HEBHFHEMFMC, bool DBDAMKEJBFN) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class CFDBLJIEAIM : IDisposable, JPLCKNANJFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HashSet<Type> MGBIFLBGAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly HashSet<Type> PAGHBIFBMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Transform EEACNOJJMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<Component> GMJBFPNLLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> NOKPNJEIMDI;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x51A3120", Offset = "0x51A2120", VA = "0x1851A3120")]
	[LPDKEEGEILI]
	public static void DPOIAANJAJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x51A3AA0", Offset = "0x51A2AA0", VA = "0x1851A3AA0")]
	[Preserve]
	public CFDBLJIEAIM([ANHJONHGEFO(null)] HDMJLEDJFMG HBLENPEBNAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x51A3280", Offset = "0x51A2280", VA = "0x1851A3280", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x51A2FB0", Offset = "0x51A1FB0", VA = "0x1851A2FB0", Slot = "5")]
	public void BHECBDOHIOE(params Type[] MAGLJCOJOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x51A3910", Offset = "0x51A2910", VA = "0x1851A3910", Slot = "6")]
	public void MGMNLOMOBDK(params Type[] MAGLJCOJOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x51A3000", Offset = "0x51A2000", VA = "0x1851A3000", Slot = "7")]
	public GameObject BLOKIIIMPBK(GameObject PCLKDEOJIAH, Transform NKNFLMKNNCC, bool DBDAMKEJBFN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x20A5B20", Offset = "0x20A4B20", VA = "0x1820A5B20", Slot = "8")]
	public T BLOKIIIMPBK<T>(T PCLKDEOJIAH, Transform NKNFLMKNNCC, bool DBDAMKEJBFN = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x20A6230", Offset = "0x20A5230", VA = "0x1820A6230", Slot = "9")]
	public T BLOKIIIMPBK<T>(GameObject PCLKDEOJIAH, Transform NKNFLMKNNCC, bool DBDAMKEJBFN = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x51A3090", Offset = "0x51A2090", VA = "0x1851A3090", Slot = "10")]
	public GameObject BLOKIIIMPBK(GameObject PCLKDEOJIAH, Transform NKNFLMKNNCC, AJBBKPFHEPC HEBHFHEMFMC, bool DBDAMKEJBFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x20A5B90", Offset = "0x20A4B90", VA = "0x1820A5B90", Slot = "11")]
	public T BLOKIIIMPBK<T>(GameObject PCLKDEOJIAH, Transform NKNFLMKNNCC, AJBBKPFHEPC HEBHFHEMFMC, bool DBDAMKEJBFN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x20A5BE0", Offset = "0x20A4BE0", VA = "0x1820A5BE0", Slot = "12")]
	public T BLOKIIIMPBK<T>(T PCLKDEOJIAH, Transform NKNFLMKNNCC, AJBBKPFHEPC HEBHFHEMFMC, bool DBDAMKEJBFN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x20A5C70", Offset = "0x20A4C70", VA = "0x1820A5C70")]
	private T BLOKIIIMPBK<T>(GameObject PCLKDEOJIAH, Transform NKNFLMKNNCC, AJBBKPFHEPC HEBHFHEMFMC, bool DBDAMKEJBFN, out GameObject FNECOBBDGFH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x20A6260", Offset = "0x20A5260", VA = "0x1820A6260")]
	private T ODNFBFACGLB<T>(GameObject CPHKFFAMPLG, AJBBKPFHEPC HEBHFHEMFMC, bool DBDAMKEJBFN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x51A3380", Offset = "0x51A2380", VA = "0x1851A3380")]
	private void GIJPCJBLKAA(Component HMHKKCGCCCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x51A34A0", Offset = "0x51A24A0", VA = "0x1851A34A0")]
	private void JALAIDBKCCG(Component HMHKKCGCCCK, AJBBKPFHEPC HEBHFHEMFMC, bool DBDAMKEJBFN, [Optional] Type BGDHCDNCIFH, [Optional] Type DCOCDMGGGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x51A3960", Offset = "0x51A2960", VA = "0x1851A3960")]
	private void PNHDFEMHMCP(GameObject CPHKFFAMPLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct AJBBKPFHEPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<Type, object> HMPIOPHILGD;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1EDB530", Offset = "0x1EDA530", VA = "0x181EDB530")]
	public AJBBKPFHEPC IDLFALJALGN<T>(T BGAPAAKHGFB)
	{
		return default(AJBBKPFHEPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x20A2160", Offset = "0x20A1160", VA = "0x1820A2160")]
	public T PKIGOCNNHDN<T>(T PEOEDADAEIC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x232FEB0", Offset = "0x232EEB0", VA = "0x18232FEB0")]
	public bool FMFCOGJONGA<T>(out T BGAPAAKHGFB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct HPDKIPBGLCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public bool EFDONCOPMPL;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xDC0EB0", Offset = "0xDBFEB0", VA = "0x180DC0EB0")]
	public HPDKIPBGLCF(bool HFNACHLOKJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct HICOCGIMBKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly bool AOIBFDKFBDO;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x51A6660", Offset = "0x51A5660", VA = "0x1851A6660")]
	public HICOCGIMBKN(bool PGMKJJKBEIA)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xDDCCF0", Offset = "0xDDBCF0", VA = "0x180DDCCF0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ScaleInImposter : MonoBehaviour, PGMOJHKBDPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x51A7340", Offset = "0x51A6340", VA = "0x1851A7340", Slot = "4")]
		public void PrepareImposter(AJBBKPFHEPC HEBHFHEMFMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xDDCCF0", Offset = "0xDDBCF0", VA = "0x180DDCCF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x51A7320", Offset = "0x51A6320", VA = "0x1851A7320")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x51A7310", Offset = "0x51A6310", VA = "0x1851A7310")]
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
		[Cpp2IlInjected.Address(RVA = "0x51A6F40", Offset = "0x51A5F40", VA = "0x1851A6F40")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class CJPMBEDGCKP
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly List<URPLight> INAAMHODOEO;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly Vector3 HCPOKGNNENJ;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Vector3 EEBICJKANNB;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static Camera JMMMIAIAMPG;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public const string DNNFMHLEPAH = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public const HPOAJPNCBGM MGJDOADJLKC = HPOAJPNCBGM.Water;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly List<Renderer> CCLEPDFGKCA;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static AmbientMode MPMKBMKBFEO;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color POKNIJLMAGA;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static Color BIKHEOIOABA;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static Color KJMLLLINHJD;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static Cubemap IEMMNNKKFNI;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static bool BGKPOPJDFOO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera CHLCIMPGKKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x51A5870", Offset = "0x51A4870", VA = "0x1851A5870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x51A42F0", Offset = "0x51A32F0", VA = "0x1851A42F0")]
	public static void FMCJPGLJKBC(Vector3 MJKNMHFPCGI, Quaternion HGALMIFIIEO, ImposterRenderConfig EOIHBNCCMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x51A4D90", Offset = "0x51A3D90", VA = "0x1851A4D90")]
	private static void KPJDHCGEHBC(Vector3 MJKNMHFPCGI, Quaternion HGALMIFIIEO, URPLight HANGMEJKFNA, ImposterRenderConfig.LightConfig OEHEFDIBBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x51A5300", Offset = "0x51A4300", VA = "0x1851A5300")]
	public static void NCLOOMJLGNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x51A53E0", Offset = "0x51A43E0", VA = "0x1851A53E0")]
	private static void OJCLCNFPKBC(int FCGEABKJBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x51A4800", Offset = "0x51A3800", VA = "0x1851A4800")]
	public static void GOEDGBDMOAK(ImposterRenderConfig EOIHBNCCMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x51A4980", Offset = "0x51A3980", VA = "0x1851A4980")]
	public static void JJCOEIJCHJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x51A5170", Offset = "0x51A4170", VA = "0x1851A5170")]
	public static void MCFMAOCMMJI(GameObject JAMBEOAMKLN, RenderTexture GNIPLECAJFH, ImposterRenderConfig EOIHBNCCMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x51A3DD0", Offset = "0x51A2DD0", VA = "0x1851A3DD0")]
	private static void ELANFPJKICJ(GameObject JAMBEOAMKLN, RenderTexture GNIPLECAJFH, ImposterRenderConfig EOIHBNCCMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x51A4570", Offset = "0x51A3570", VA = "0x1851A4570")]
	private static void GAAONEPKKMA(GameObject JAMBEOAMKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x51A56E0", Offset = "0x51A46E0", VA = "0x1851A56E0")]
	public static void PFGJLGLFODL(List<Renderer> LNKBFOAMHLA, List<Material> PCNKDFEBMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x51A4A80", Offset = "0x51A3A80", VA = "0x1851A4A80")]
	private static void KDEDLGIEFHO(GameObject PCLKDEOJIAH, Vector3 GFNAGPPJCHF, Vector3 AJMOFGEFLAB, float PNADIHPFMCJ, out Vector3 IGDGGIGHJMN, out Quaternion MNGAAOCKCME, out float PLNBEOJDPJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x51A50D0", Offset = "0x51A40D0", VA = "0x1851A50D0")]
	public static RenderTexture MBCDMHLIJLF(int PONIFNELPFK, int GIGPIDHIFMI)
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
		public struct NKIBJPGPAPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public IHNBEKDFILG NIIHLAHDPDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public GameObject IHJDANIECCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public RenderTexture DIHIAEMBOFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public ImposterRenderConfig FBHMDAPDPIG;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x479D530", Offset = "0x479C530", VA = "0x18479D530")]
			public NKIBJPGPAPC(IHNBEKDFILG FPFKOMFNPJC, GameObject DCECCCHOABB, RenderTexture GNIPLECAJFH, ImposterRenderConfig CLLABKFIHPC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const int HAOMOJLBJHD = 1;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int HNMFCOFNBFC = 6;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static global::JMEKAPCCHLG<NKIBJPGPAPC, RenderTexture> PIAGLKMIJFH;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static readonly List<NKIBJPGPAPC> JPIFEIPFNJK;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int DMIHEDMBIKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8C4D10", Offset = "0x8C3D10", VA = "0x1808C4D10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x51A6220", Offset = "0x51A5220", VA = "0x1851A6220")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject JAMBEOAMKLN, RenderTexture GNIPLECAJFH, ImposterRenderConfig EOIHBNCCMLL, CancellationToken MCLPFBCBLEM, bool IHCHBKAGCDO = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x51A5D40", Offset = "0x51A4D40", VA = "0x1851A5D40", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x51A6190", Offset = "0x51A5190", VA = "0x1851A6190", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x51A5E60", Offset = "0x51A4E60", VA = "0x1851A5E60")]
		private static Task<RenderTexture> HPBEHAAOIGN(NKIBJPGPAPC AMAJEOOPIPN, CancellationToken MCLPFBCBLEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x51A6600", Offset = "0x51A5600", VA = "0x1851A6600")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IPBFNGMPFEA
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static byte[] FDFKLIHCMDI;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int IKEJBHOADAH;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static int BADMEAGLBCG;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static BigInteger LKFKJFPDNAJ;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public IPBFNGMPFEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x51A6670", Offset = "0x51A5670", VA = "0x1851A6670")]
	private static string OJNKOKJGCOH(byte[] BMEGDOGJIKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x51A6770", Offset = "0x51A5770", VA = "0x1851A6770")]
	public static string PLNHDMOHEMF(byte[] LNCIHJHIBKD, bool PDPJHLLFJEO)
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
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
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
