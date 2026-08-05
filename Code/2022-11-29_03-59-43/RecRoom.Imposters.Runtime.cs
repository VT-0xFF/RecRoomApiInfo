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
public class ImposterPreviewCustomFraming : MonoBehaviour, MGIPPONLCOA
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float FOKOINEDKHM = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "4")]
	public void PrepareImposter(HKLNIJOKGFB ENIALHNPBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x60075C0", Offset = "0x60061C0", VA = "0x1860075C0")]
	public void SetReferencePoint(Vector3 LDFDHMMJHKJ, Quaternion FFJKKBHOOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6007430", Offset = "0x6006030", VA = "0x186007430")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6007590", Offset = "0x6006190", VA = "0x186007590")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x11A00E0", Offset = "0x119ECE0", VA = "0x1811A00E0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct CALBKNNPNAA
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static CALBKNNPNAA NDLEDDIOENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public float DBCPMDDDOJH;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7210", Offset = "0x2CE5E10", VA = "0x182CE7210")]
	public CALBKNNPNAA(float KNLOAKDANIC)
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
		[CKCNFJDLOHN(ALDDFIJCEMJ.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const int JDGAHIPJJMC = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const int NLMCEMGECIN = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly List<Material> EKCPOELLLGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private bool FHLAAMLNDLF;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6007730", Offset = "0x6006330", VA = "0x186007730")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6007640", Offset = "0x6006240", VA = "0x186007640")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6007970", Offset = "0x6006570", VA = "0x186007970")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class CenterInImposter : MonoBehaviour, MGIPPONLCOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6004880", Offset = "0x6003480", VA = "0x186004880", Slot = "4")]
		public void PrepareImposter(HKLNIJOKGFB ENIALHNPBKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xF03490", Offset = "0xF02090", VA = "0x180F03490")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xF03490", Offset = "0xF02090", VA = "0x180F03490")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MGIPPONLCOA
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(HKLNIJOKGFB ENIALHNPBKC);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface LCKMBGGMGDG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> DIKJPPNMGBO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> HHCADFNPCOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface KFODKLNNCKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OMIMCCCGJCB(params Type[] BIPGMHLAMBH);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DDGAJBEMNPB(params Type[] BIPGMHLAMBH);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject GPLHFBAOFPB(GameObject CNGLOEJDOMG, Transform GEOFAMNLJNK, bool HHGMJHLAHEA = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T GPLHFBAOFPB<T>(T CNGLOEJDOMG, Transform GEOFAMNLJNK, bool HHGMJHLAHEA = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T GPLHFBAOFPB<T>(GameObject CNGLOEJDOMG, Transform GEOFAMNLJNK, bool HHGMJHLAHEA = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject GPLHFBAOFPB(GameObject CNGLOEJDOMG, Transform GEOFAMNLJNK, HKLNIJOKGFB ENIALHNPBKC, bool HHGMJHLAHEA);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T GPLHFBAOFPB<T>(GameObject CNGLOEJDOMG, Transform GEOFAMNLJNK, HKLNIJOKGFB ENIALHNPBKC, bool HHGMJHLAHEA) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T GPLHFBAOFPB<T>(T CNGLOEJDOMG, Transform GEOFAMNLJNK, HKLNIJOKGFB ENIALHNPBKC, bool HHGMJHLAHEA) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class LLBMKJBJLGK : IDisposable, KFODKLNNCKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly HashSet<Type> JKAIPBMDMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly HashSet<Type> ALHNEAAFCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Transform IAALBBBFDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly List<Component> KLNJHHLEAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> PFNHJIBCFFN;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x60087E0", Offset = "0x60073E0", VA = "0x1860087E0")]
	[IIBELCEICEH(INPGEEFAPCN.None)]
	public static void HFGCFLBPFBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6008BC0", Offset = "0x60077C0", VA = "0x186008BC0")]
	[Preserve]
	public LLBMKJBJLGK([MAEEAOEDELI(null)] LCKMBGGMGDG OAJIIKDFKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x60085C0", Offset = "0x60071C0", VA = "0x1860085C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6008A10", Offset = "0x6007610", VA = "0x186008A10", Slot = "5")]
	public void OMIMCCCGJCB(params Type[] BIPGMHLAMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6008570", Offset = "0x6007170", VA = "0x186008570", Slot = "6")]
	public void DDGAJBEMNPB(params Type[] BIPGMHLAMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6008750", Offset = "0x6007350", VA = "0x186008750", Slot = "7")]
	public GameObject GPLHFBAOFPB(GameObject CNGLOEJDOMG, Transform GEOFAMNLJNK, bool HHGMJHLAHEA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x29F8930", Offset = "0x29F7530", VA = "0x1829F8930", Slot = "8")]
	public T GPLHFBAOFPB<T>(T CNGLOEJDOMG, Transform GEOFAMNLJNK, bool HHGMJHLAHEA = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x29F8900", Offset = "0x29F7500", VA = "0x1829F8900", Slot = "9")]
	public T GPLHFBAOFPB<T>(GameObject CNGLOEJDOMG, Transform GEOFAMNLJNK, bool HHGMJHLAHEA = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x60086C0", Offset = "0x60072C0", VA = "0x1860086C0", Slot = "10")]
	public GameObject GPLHFBAOFPB(GameObject CNGLOEJDOMG, Transform GEOFAMNLJNK, HKLNIJOKGFB ENIALHNPBKC, bool HHGMJHLAHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x29F8A30", Offset = "0x29F7630", VA = "0x1829F8A30", Slot = "11")]
	public T GPLHFBAOFPB<T>(GameObject CNGLOEJDOMG, Transform GEOFAMNLJNK, HKLNIJOKGFB ENIALHNPBKC, bool HHGMJHLAHEA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x29F89A0", Offset = "0x29F75A0", VA = "0x1829F89A0", Slot = "12")]
	public T GPLHFBAOFPB<T>(T CNGLOEJDOMG, Transform GEOFAMNLJNK, HKLNIJOKGFB ENIALHNPBKC, bool HHGMJHLAHEA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x29F8A80", Offset = "0x29F7680", VA = "0x1829F8A80")]
	private T GPLHFBAOFPB<T>(GameObject CNGLOEJDOMG, Transform GEOFAMNLJNK, HKLNIJOKGFB ENIALHNPBKC, bool HHGMJHLAHEA, out GameObject JJCHHFIKBPO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x29F8FB0", Offset = "0x29F7BB0", VA = "0x1829F8FB0")]
	private T PNCNDIJBCMA<T>(GameObject ENOCMPCACJI, HKLNIJOKGFB ENIALHNPBKC, bool HHGMJHLAHEA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x60088E0", Offset = "0x60074E0", VA = "0x1860088E0")]
	private void KHJMLOGIBFJ(Component NMNKGKHKMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6008020", Offset = "0x6006C20", VA = "0x186008020")]
	private void AJEPGBGOKCI(Component NMNKGKHKMCB, HKLNIJOKGFB ENIALHNPBKC, bool HHGMJHLAHEA, bool FBLAMGHEBPE, [Optional] Type OHHICFOACBG, [Optional] Type HBGKJLKLDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6008A60", Offset = "0x6007660", VA = "0x186008A60")]
	private void PEBNOFGAJDJ(GameObject ENOCMPCACJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct HKLNIJOKGFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Dictionary<Type, object> HMIADDCNCMI;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2C825A0", Offset = "0x2C811A0", VA = "0x182C825A0")]
	public HKLNIJOKGFB NMFBOCJEJOB<T>(T BHOMHPIPDNM)
	{
		return default(HKLNIJOKGFB);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2C82480", Offset = "0x2C81080", VA = "0x182C82480")]
	public T HMFHOBMDMGG<T>(T BJJKLHEAKLF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2C81CE0", Offset = "0x2C808E0", VA = "0x182C81CE0")]
	public bool GIGGJMBFKKD<T>(out T BHOMHPIPDNM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct JGFLJBJDENG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public bool OMEBDKAHOOJ;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xF77220", Offset = "0xF75E20", VA = "0x180F77220")]
	public JGFLJBJDENG(bool OOPPFHHEIJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct PMJCHJAAJKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly bool LOJNNBMPNNL;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x60090A0", Offset = "0x6007CA0", VA = "0x1860090A0")]
	public PMJCHJAAJKN(bool LGKMBGCONGD)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xF03490", Offset = "0xF02090", VA = "0x180F03490")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ScaleInImposter : MonoBehaviour, MGIPPONLCOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x60090B0", Offset = "0x6007CB0", VA = "0x1860090B0", Slot = "4")]
		public void PrepareImposter(HKLNIJOKGFB ENIALHNPBKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xF03490", Offset = "0xF02090", VA = "0x180F03490")]
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
				[Cpp2IlInjected.Address(RVA = "0x6009010", Offset = "0x6007C10", VA = "0x186009010")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6009000", Offset = "0x6007C00", VA = "0x186009000")]
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
		[Cpp2IlInjected.Address(RVA = "0x6007600", Offset = "0x6006200", VA = "0x186007600")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class FLACBFDDLOI
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<URPLight> MLJHLHILGFM;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly Vector3 EDFFBJDDKNK;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly Vector3 FLBAJGAOGAF;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static Camera NNEEMAJGPOH;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public const string LJDFBDDLPJP = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public const FEAIKJEIIHM JFHLLMCENMM = FEAIKJEIIHM.Water;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static readonly List<Renderer> FFGEMGNCBCG;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static AmbientMode GMANIBHMAKB;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static Color EFEDOGGGIMK;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static Color PCMLCGALHGP;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static Color PNGABONPKHI;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static Cubemap EHKAFDIOLDK;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static bool BKDPFLDDOEK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera GHEMMKINPAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x60070B0", Offset = "0x6005CB0", VA = "0x1860070B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6006100", Offset = "0x6004D00", VA = "0x186006100")]
	public static void LBJCLEJMJLC(Vector3 NKOJKGHMMNL, Quaternion PDGANABLDIE, ImposterRenderConfig NPGBFFIKANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6005920", Offset = "0x6004520", VA = "0x186005920")]
	private static void EOLAFGLKKEA(Vector3 NKOJKGHMMNL, Quaternion PDGANABLDIE, URPLight BGIFPKDPDIO, ImposterRenderConfig.LightConfig PMAFBAPPIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6006AC0", Offset = "0x60056C0", VA = "0x186006AC0")]
	public static void OAAFJLLDCBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6006550", Offset = "0x6005150", VA = "0x186006550")]
	private static void NFMLBBMPBJB(int ONNBGMHDGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6005C30", Offset = "0x6004830", VA = "0x186005C30")]
	public static void KADJBOODOJC(ImposterRenderConfig NPGBFFIKANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6005820", Offset = "0x6004420", VA = "0x186005820")]
	public static void EJNGEFHCIPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6006380", Offset = "0x6004F80", VA = "0x186006380")]
	public static void LPKJHPGKACB(GameObject DLPEOEMGGBM, RenderTexture FKMIGOOPCII, ImposterRenderConfig NPGBFFIKANJ, CALBKNNPNAA EGMMPOEMOOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6006BB0", Offset = "0x60057B0", VA = "0x186006BB0")]
	private static void OJOOMOACIGC(GameObject DLPEOEMGGBM, RenderTexture FKMIGOOPCII, ImposterRenderConfig NPGBFFIKANJ, CALBKNNPNAA EGMMPOEMOOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6005E50", Offset = "0x6004A50", VA = "0x186005E50")]
	private static void KOKDCLJJCGK(GameObject DLPEOEMGGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6006920", Offset = "0x6005520", VA = "0x186006920")]
	public static void NJALMMIJFPF(List<Renderer> KGOFBBKBAAL, List<Material> FKOAPGEICPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6005320", Offset = "0x6003F20", VA = "0x186005320")]
	public static void AGGLGFLCHNN(GameObject CNGLOEJDOMG, Vector3 CAEKFBJCMDA, Vector3 GLMHEKDEPIP, float HKBKNJLBNGM, CALBKNNPNAA EGMMPOEMOOK, out Vector3 GJLPJOGDNCB, out Quaternion IMINCCMIJGF, out float DJEKKIHFECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6005DB0", Offset = "0x60049B0", VA = "0x186005DB0")]
	public static RenderTexture KELCHCOGOCC(int BDBMIEBKIGN, int KDPLJDNGPBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x60055F0", Offset = "0x60041F0", VA = "0x1860055F0")]
	public static void EEIOIPIGLCO()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public struct PCDMGPGELMD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public LNEJMGPOKKP BHMNJBPECAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public GameObject AJOAKMPOMID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public RenderTexture EPEEFFNJMDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public ImposterRenderConfig NFMBNMFBKIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public CALBKNNPNAA CALBKNNPNAA;

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6009030", Offset = "0x6007C30", VA = "0x186009030")]
			public PCDMGPGELMD(LNEJMGPOKKP NMLBIEFPGAJ, GameObject DHPDKBMCKLJ, RenderTexture FKMIGOOPCII, ImposterRenderConfig KFJJJLMABKA, CALBKNNPNAA EGMMPOEMOOK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int KBJGJMOHLPL = 1;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int FDMBFNOBHHF = 6;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static global::IDPLKMIMIEO<PCDMGPGELMD, RenderTexture> KNOMPHPLMFJ;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static readonly List<PCDMGPGELMD> LAJPDBDMDAN;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int LLGEIANFIDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7CC510", Offset = "0x7CB110", VA = "0x1807CC510")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6004DE0", Offset = "0x60039E0", VA = "0x186004DE0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject DLPEOEMGGBM, RenderTexture FKMIGOOPCII, ImposterRenderConfig NPGBFFIKANJ, CALBKNNPNAA EGMMPOEMOOK, CancellationToken ADCKNELPFOJ, bool JKLDGBEAIOF = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x60049E0", Offset = "0x60035E0", VA = "0x1860049E0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6004D40", Offset = "0x6003940", VA = "0x186004D40", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6004B70", Offset = "0x6003770", VA = "0x186004B70")]
		private static Task<RenderTexture> FHMMGAICEDH(PCDMGPGELMD KFHNMNPDOKK, CancellationToken ADCKNELPFOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x60052B0", Offset = "0x6003EB0", VA = "0x1860052B0")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KEJBIFLOMJJ
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static byte[] POAMPPAGKIJ;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static int DNBFJGDJLJG;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static int JPELDCGMMIM;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static BigInteger LIKOKONEDPL;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public KEJBIFLOMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x60079F0", Offset = "0x60065F0", VA = "0x1860079F0")]
	private static string EBPBHFJLCAL(byte[] GHDGKPNPOBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6007B00", Offset = "0x6006700", VA = "0x186007B00")]
	public static string HPJOPLJIOMI(byte[] EHAMCGPFFID, bool BLMJHFAPIFG)
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
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
