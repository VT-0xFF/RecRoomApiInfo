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
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "4")]
	public void PrepareImposter(GHNKBGFFKIO JJDMBGDPAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x600DC10", Offset = "0x600C610", VA = "0x18600DC10")]
	public void SetReferencePoint(Vector3 PBENCDOOEDL, Quaternion AILLHFOOINL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x600DA80", Offset = "0x600C480", VA = "0x18600DA80")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x600DBE0", Offset = "0x600C5E0", VA = "0x18600DBE0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1C6DCB0", Offset = "0x1C6C6B0", VA = "0x181C6DCB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CE3040", Offset = "0x2CE1A40", VA = "0x182CE3040")]
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
		[Cpp2IlInjected.Address(RVA = "0x600DD80", Offset = "0x600C780", VA = "0x18600DD80")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x600DC90", Offset = "0x600C690", VA = "0x18600DC90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x600DFC0", Offset = "0x600C9C0", VA = "0x18600DFC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x600CF70", Offset = "0x600B970", VA = "0x18600CF70", Slot = "4")]
		public void PrepareImposter(GHNKBGFFKIO JJDMBGDPAOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xEC9410", Offset = "0xEC7E10", VA = "0x180EC9410")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xEC9410", Offset = "0xEC7E10", VA = "0x180EC9410")]
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
	[Cpp2IlInjected.Address(RVA = "0x600EE90", Offset = "0x600D890", VA = "0x18600EE90")]
	[PILNOHNDGDF(KBMKLHMPDPB.None)]
	public static void COABAOIMNDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x600F290", Offset = "0x600DC90", VA = "0x18600F290")]
	[Preserve]
	public PPHDGJLOFNE([KICKHKJFGOO(null)] NAPNHMPBIIP ADFHIKIBDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x600EFE0", Offset = "0x600D9E0", VA = "0x18600EFE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x600EF90", Offset = "0x600D990", VA = "0x18600EF90", Slot = "5")]
	public void DEGOIMLFLIG(params Type[] KJJNFLPAOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x600F0E0", Offset = "0x600DAE0", VA = "0x18600F0E0", Slot = "6")]
	public void JLNDANININO(params Type[] KJJNFLPAOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x600E820", Offset = "0x600D220", VA = "0x18600E820", Slot = "7")]
	public GameObject APKIDBLLIAG(GameObject BHIKNMNBHAG, Transform LFAIGCEGCPL, bool IINMNMPKMHA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x279ED50", Offset = "0x279D750", VA = "0x18279ED50", Slot = "8")]
	public T APKIDBLLIAG<T>(T BHIKNMNBHAG, Transform LFAIGCEGCPL, bool IINMNMPKMHA = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x279EE50", Offset = "0x279D850", VA = "0x18279EE50", Slot = "9")]
	public T APKIDBLLIAG<T>(GameObject BHIKNMNBHAG, Transform LFAIGCEGCPL, bool IINMNMPKMHA = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x600E8B0", Offset = "0x600D2B0", VA = "0x18600E8B0", Slot = "10")]
	public GameObject APKIDBLLIAG(GameObject BHIKNMNBHAG, Transform LFAIGCEGCPL, GHNKBGFFKIO JJDMBGDPAOA, bool IINMNMPKMHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x279F400", Offset = "0x279DE00", VA = "0x18279F400", Slot = "11")]
	public T APKIDBLLIAG<T>(GameObject BHIKNMNBHAG, Transform LFAIGCEGCPL, GHNKBGFFKIO JJDMBGDPAOA, bool IINMNMPKMHA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x279EDC0", Offset = "0x279D7C0", VA = "0x18279EDC0", Slot = "12")]
	public T APKIDBLLIAG<T>(T BHIKNMNBHAG, Transform LFAIGCEGCPL, GHNKBGFFKIO JJDMBGDPAOA, bool IINMNMPKMHA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x279EE80", Offset = "0x279D880", VA = "0x18279EE80")]
	private T APKIDBLLIAG<T>(GameObject BHIKNMNBHAG, Transform LFAIGCEGCPL, GHNKBGFFKIO JJDMBGDPAOA, bool IINMNMPKMHA, out GameObject LFEHEBLOKOB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x279F450", Offset = "0x279DE50", VA = "0x18279F450")]
	private T GIIGEGKFDDD<T>(GameObject EHEABJNEALG, GHNKBGFFKIO JJDMBGDPAOA, bool IINMNMPKMHA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x600E6F0", Offset = "0x600D0F0", VA = "0x18600E6F0")]
	private void AAJPECBPOKL(Component AALANACCLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x600E940", Offset = "0x600D340", VA = "0x18600E940")]
	private void BKKPMNOCADF(Component AALANACCLGM, GHNKBGFFKIO JJDMBGDPAOA, bool IINMNMPKMHA, bool MNKJDGIMEIA, [Optional] Type NFOGBAHHNMC, [Optional] Type NFDEHDBBHIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x600F130", Offset = "0x600DB30", VA = "0x18600F130")]
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
	[Cpp2IlInjected.Address(RVA = "0x24F2220", Offset = "0x24F0C20", VA = "0x1824F2220")]
	public GHNKBGFFKIO KMNEKDAGPNL<T>(T IAHPHHNFGHI)
	{
		return default(GHNKBGFFKIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x24F2100", Offset = "0x24F0B00", VA = "0x1824F2100")]
	public T DNJGGIFCOKL<T>(T BKMGNMEJDHA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x24F1960", Offset = "0x24F0360", VA = "0x1824F1960")]
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
	[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF34AA0", VA = "0x180F360A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x600E6E0", Offset = "0x600D0E0", VA = "0x18600E6E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xEC9410", Offset = "0xEC7E10", VA = "0x180EC9410")]
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
		[Cpp2IlInjected.Address(RVA = "0x600F6D0", Offset = "0x600E0D0", VA = "0x18600F6D0", Slot = "4")]
		public void PrepareImposter(GHNKBGFFKIO JJDMBGDPAOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xEC9410", Offset = "0xEC7E10", VA = "0x180EC9410")]
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
				[Cpp2IlInjected.Address(RVA = "0x600E050", Offset = "0x600CA50", VA = "0x18600E050")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x600E040", Offset = "0x600CA40", VA = "0x18600E040")]
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
		[Cpp2IlInjected.Address(RVA = "0x600DC50", Offset = "0x600C650", VA = "0x18600DC50")]
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
		[Cpp2IlInjected.Address(RVA = "0x600C730", Offset = "0x600B130", VA = "0x18600C730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x600C280", Offset = "0x600AC80", VA = "0x18600C280")]
	public static void LLNOIEPGAAB(Vector3 EDHMLKHCFFN, Quaternion FDIOPECEIEK, ImposterRenderConfig IGGACGJPFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x600BF70", Offset = "0x600A970", VA = "0x18600BF70")]
	private static void LGKPJNKJDHH(Vector3 EDHMLKHCFFN, Quaternion FDIOPECEIEK, URPLight PMLGECLHKJD, ImposterRenderConfig.LightConfig LOHDOLJMFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x600CD30", Offset = "0x600B730", VA = "0x18600CD30")]
	public static void PEGHDNMHILP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x600C960", Offset = "0x600B360", VA = "0x18600C960")]
	private static void OLFFBNHJACO(int LGDGENEKMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x600B130", Offset = "0x6009B30", VA = "0x18600B130")]
	public static void FFFJDHAHLHJ(ImposterRenderConfig IGGACGJPFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x600BCA0", Offset = "0x600A6A0", VA = "0x18600BCA0")]
	public static void JLFKKIKHKFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x600BDA0", Offset = "0x600A7A0", VA = "0x18600BDA0")]
	public static void LDOBFMPNCKG(GameObject NCJMCGKPNHC, RenderTexture GNBKNDLBAAB, ImposterRenderConfig IGGACGJPFBO, PEADFPJNIPK ABAJDCJIBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x600B2B0", Offset = "0x6009CB0", VA = "0x18600B2B0")]
	private static void GMBDJMDLNHD(GameObject NCJMCGKPNHC, RenderTexture GNBKNDLBAAB, ImposterRenderConfig IGGACGJPFBO, PEADFPJNIPK ABAJDCJIBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x600B850", Offset = "0x600A250", VA = "0x18600B850")]
	private static void IJKODDIMJAH(GameObject NCJMCGKPNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x600BB00", Offset = "0x600A500", VA = "0x18600BB00")]
	public static void IJOIEAIABBA(List<Renderer> CEOOJILCJDM, List<Material> OBKGJBPNGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x600AE60", Offset = "0x6009860", VA = "0x18600AE60")]
	public static void EOKEFDGGCIB(GameObject BHIKNMNBHAG, Vector3 COOBHLIEHAA, Vector3 JDKKKGOLFIL, float MCJMPFBAPDA, PEADFPJNIPK ABAJDCJIBCM, out Vector3 FDJIHIBFAGP, out Quaternion LCBCMJJEDEP, out float BEHEILKIFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x600B7B0", Offset = "0x600A1B0", VA = "0x18600B7B0")]
	public static RenderTexture IDDOPFLAFFD(int LEFBNKJDKNL, int ELIEMKLAFPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x600C500", Offset = "0x600AF00", VA = "0x18600C500")]
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
			[Cpp2IlInjected.Address(RVA = "0x600DA10", Offset = "0x600C410", VA = "0x18600DA10")]
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
			[Cpp2IlInjected.Address(RVA = "0x7CC510", Offset = "0x7CAF10", VA = "0x1807CC510")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x600D4D0", Offset = "0x600BED0", VA = "0x18600D4D0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject NCJMCGKPNHC, RenderTexture GNBKNDLBAAB, ImposterRenderConfig IGGACGJPFBO, PEADFPJNIPK ABAJDCJIBCM, CancellationToken JLIEBAENBAG, bool JDIHAJOIEIB = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x600D0D0", Offset = "0x600BAD0", VA = "0x18600D0D0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x600D430", Offset = "0x600BE30", VA = "0x18600D430", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x600D260", Offset = "0x600BC60", VA = "0x18600D260")]
		private static Task<RenderTexture> LLKOIGKMKDM(ICMAJDFEALJ GONNBCINNCF, CancellationToken JLIEBAENBAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x600D9A0", Offset = "0x600C3A0", VA = "0x18600D9A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public MDBMMECDLKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x600E3C0", Offset = "0x600CDC0", VA = "0x18600E3C0")]
	private static string LLKJKMBGMPE(byte[] LKLEFAIICIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x600E070", Offset = "0x600CA70", VA = "0x18600E070")]
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
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
