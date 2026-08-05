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
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "4")]
	public void PrepareImposter(HKLNIJOKGFB ENIALHNPBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E49880", Offset = "0x5E48680", VA = "0x185E49880")]
	public void SetReferencePoint(Vector3 LDFDHMMJHKJ, Quaternion FFJKKBHOOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E496F0", Offset = "0x5E484F0", VA = "0x185E496F0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E49850", Offset = "0x5E48650", VA = "0x185E49850")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1202D10", Offset = "0x1201B10", VA = "0x181202D10")]
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
	[Cpp2IlInjected.Address(RVA = "0x66D210", Offset = "0x66C010", VA = "0x18066D210")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E499F0", Offset = "0x5E487F0", VA = "0x185E499F0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5E49900", Offset = "0x5E48700", VA = "0x185E49900")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5E49C30", Offset = "0x5E48A30", VA = "0x185E49C30")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E46B40", Offset = "0x5E45940", VA = "0x185E46B40", Slot = "4")]
		public void PrepareImposter(HKLNIJOKGFB ENIALHNPBKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6529C0", Offset = "0x6517C0", VA = "0x1806529C0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6529C0", Offset = "0x6517C0", VA = "0x1806529C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E4AAA0", Offset = "0x5E498A0", VA = "0x185E4AAA0")]
	[IIBELCEICEH(INPGEEFAPCN.None)]
	public static void HFGCFLBPFBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5E4AE80", Offset = "0x5E49C80", VA = "0x185E4AE80")]
	[Preserve]
	public LLBMKJBJLGK([MAEEAOEDELI(null)] LCKMBGGMGDG OAJIIKDFKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E4A880", Offset = "0x5E49680", VA = "0x185E4A880", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E4ACD0", Offset = "0x5E49AD0", VA = "0x185E4ACD0", Slot = "5")]
	public void OMIMCCCGJCB(params Type[] BIPGMHLAMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5E4A830", Offset = "0x5E49630", VA = "0x185E4A830", Slot = "6")]
	public void DDGAJBEMNPB(params Type[] BIPGMHLAMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5E4AA10", Offset = "0x5E49810", VA = "0x185E4AA10", Slot = "7")]
	public GameObject GPLHFBAOFPB(GameObject CNGLOEJDOMG, Transform GEOFAMNLJNK, bool HHGMJHLAHEA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2DD7860", Offset = "0x2DD6660", VA = "0x182DD7860", Slot = "8")]
	public T GPLHFBAOFPB<T>(T CNGLOEJDOMG, Transform GEOFAMNLJNK, bool HHGMJHLAHEA = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2DD7830", Offset = "0x2DD6630", VA = "0x182DD7830", Slot = "9")]
	public T GPLHFBAOFPB<T>(GameObject CNGLOEJDOMG, Transform GEOFAMNLJNK, bool HHGMJHLAHEA = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5E4A980", Offset = "0x5E49780", VA = "0x185E4A980", Slot = "10")]
	public GameObject GPLHFBAOFPB(GameObject CNGLOEJDOMG, Transform GEOFAMNLJNK, HKLNIJOKGFB ENIALHNPBKC, bool HHGMJHLAHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2DD7960", Offset = "0x2DD6760", VA = "0x182DD7960", Slot = "11")]
	public T GPLHFBAOFPB<T>(GameObject CNGLOEJDOMG, Transform GEOFAMNLJNK, HKLNIJOKGFB ENIALHNPBKC, bool HHGMJHLAHEA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2DD78D0", Offset = "0x2DD66D0", VA = "0x182DD78D0", Slot = "12")]
	public T GPLHFBAOFPB<T>(T CNGLOEJDOMG, Transform GEOFAMNLJNK, HKLNIJOKGFB ENIALHNPBKC, bool HHGMJHLAHEA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2DD79B0", Offset = "0x2DD67B0", VA = "0x182DD79B0")]
	private T GPLHFBAOFPB<T>(GameObject CNGLOEJDOMG, Transform GEOFAMNLJNK, HKLNIJOKGFB ENIALHNPBKC, bool HHGMJHLAHEA, out GameObject JJCHHFIKBPO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2DD7EE0", Offset = "0x2DD6CE0", VA = "0x182DD7EE0")]
	private T PNCNDIJBCMA<T>(GameObject ENOCMPCACJI, HKLNIJOKGFB ENIALHNPBKC, bool HHGMJHLAHEA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E4ABA0", Offset = "0x5E499A0", VA = "0x185E4ABA0")]
	private void KHJMLOGIBFJ(Component NMNKGKHKMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E4A2E0", Offset = "0x5E490E0", VA = "0x185E4A2E0")]
	private void AJEPGBGOKCI(Component NMNKGKHKMCB, HKLNIJOKGFB ENIALHNPBKC, bool HHGMJHLAHEA, bool FBLAMGHEBPE, [Optional] Type OHHICFOACBG, [Optional] Type HBGKJLKLDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5E4AD20", Offset = "0x5E49B20", VA = "0x185E4AD20")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D99F20", Offset = "0x2D98D20", VA = "0x182D99F20")]
	public HKLNIJOKGFB NMFBOCJEJOB<T>(T BHOMHPIPDNM)
	{
		return default(HKLNIJOKGFB);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2D99E00", Offset = "0x2D98C00", VA = "0x182D99E00")]
	public T HMFHOBMDMGG<T>(T BJJKLHEAKLF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2D99660", Offset = "0x2D98460", VA = "0x182D99660")]
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
	[Cpp2IlInjected.Address(RVA = "0x8156D0", Offset = "0x8144D0", VA = "0x1808156D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E4B360", Offset = "0x5E4A160", VA = "0x185E4B360")]
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
		[Cpp2IlInjected.Address(RVA = "0x6529C0", Offset = "0x6517C0", VA = "0x1806529C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E4B370", Offset = "0x5E4A170", VA = "0x185E4B370", Slot = "4")]
		public void PrepareImposter(HKLNIJOKGFB ENIALHNPBKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6529C0", Offset = "0x6517C0", VA = "0x1806529C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x5E4B2D0", Offset = "0x5E4A0D0", VA = "0x185E4B2D0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5E4B2C0", Offset = "0x5E4A0C0", VA = "0x185E4B2C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E498C0", Offset = "0x5E486C0", VA = "0x185E498C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E49370", Offset = "0x5E48170", VA = "0x185E49370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5E483C0", Offset = "0x5E471C0", VA = "0x185E483C0")]
	public static void LBJCLEJMJLC(Vector3 NKOJKGHMMNL, Quaternion PDGANABLDIE, ImposterRenderConfig NPGBFFIKANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5E47BE0", Offset = "0x5E469E0", VA = "0x185E47BE0")]
	private static void EOLAFGLKKEA(Vector3 NKOJKGHMMNL, Quaternion PDGANABLDIE, URPLight BGIFPKDPDIO, ImposterRenderConfig.LightConfig PMAFBAPPIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5E48D80", Offset = "0x5E47B80", VA = "0x185E48D80")]
	public static void OAAFJLLDCBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5E48810", Offset = "0x5E47610", VA = "0x185E48810")]
	private static void NFMLBBMPBJB(int ONNBGMHDGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5E47EF0", Offset = "0x5E46CF0", VA = "0x185E47EF0")]
	public static void KADJBOODOJC(ImposterRenderConfig NPGBFFIKANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5E47AE0", Offset = "0x5E468E0", VA = "0x185E47AE0")]
	public static void EJNGEFHCIPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5E48640", Offset = "0x5E47440", VA = "0x185E48640")]
	public static void LPKJHPGKACB(GameObject DLPEOEMGGBM, RenderTexture FKMIGOOPCII, ImposterRenderConfig NPGBFFIKANJ, CALBKNNPNAA EGMMPOEMOOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5E48E70", Offset = "0x5E47C70", VA = "0x185E48E70")]
	private static void OJOOMOACIGC(GameObject DLPEOEMGGBM, RenderTexture FKMIGOOPCII, ImposterRenderConfig NPGBFFIKANJ, CALBKNNPNAA EGMMPOEMOOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5E48110", Offset = "0x5E46F10", VA = "0x185E48110")]
	private static void KOKDCLJJCGK(GameObject DLPEOEMGGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5E48BE0", Offset = "0x5E479E0", VA = "0x185E48BE0")]
	public static void NJALMMIJFPF(List<Renderer> KGOFBBKBAAL, List<Material> FKOAPGEICPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5E475E0", Offset = "0x5E463E0", VA = "0x185E475E0")]
	public static void AGGLGFLCHNN(GameObject CNGLOEJDOMG, Vector3 CAEKFBJCMDA, Vector3 GLMHEKDEPIP, float HKBKNJLBNGM, CALBKNNPNAA EGMMPOEMOOK, out Vector3 GJLPJOGDNCB, out Quaternion IMINCCMIJGF, out float DJEKKIHFECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5E48070", Offset = "0x5E46E70", VA = "0x185E48070")]
	public static RenderTexture KELCHCOGOCC(int BDBMIEBKIGN, int KDPLJDNGPBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5E478B0", Offset = "0x5E466B0", VA = "0x185E478B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E4B2F0", Offset = "0x5E4A0F0", VA = "0x185E4B2F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9BE110", Offset = "0x9BCF10", VA = "0x1809BE110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5E470A0", Offset = "0x5E45EA0", VA = "0x185E470A0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject DLPEOEMGGBM, RenderTexture FKMIGOOPCII, ImposterRenderConfig NPGBFFIKANJ, CALBKNNPNAA EGMMPOEMOOK, CancellationToken ADCKNELPFOJ, bool JKLDGBEAIOF = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5E46CA0", Offset = "0x5E45AA0", VA = "0x185E46CA0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5E47000", Offset = "0x5E45E00", VA = "0x185E47000", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5E46E30", Offset = "0x5E45C30", VA = "0x185E46E30")]
		private static Task<RenderTexture> FHMMGAICEDH(PCDMGPGELMD KFHNMNPDOKK, CancellationToken ADCKNELPFOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5E47570", Offset = "0x5E46370", VA = "0x185E47570")]
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
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public KEJBIFLOMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5E49CB0", Offset = "0x5E48AB0", VA = "0x185E49CB0")]
	private static string EBPBHFJLCAL(byte[] GHDGKPNPOBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5E49DC0", Offset = "0x5E48BC0", VA = "0x185E49DC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
