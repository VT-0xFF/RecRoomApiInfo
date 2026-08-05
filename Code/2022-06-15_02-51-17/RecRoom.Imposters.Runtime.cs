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
public class ImposterPreviewCustomFraming : MonoBehaviour, GEFEIKHPEHP
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float OMOLNGCNJBC = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x55CE80", Offset = "0x55BA80", VA = "0x18055CE80", Slot = "4")]
	public void PrepareImposter(PFLLGAFLNIH AKCCEDBCHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4DE0840", Offset = "0x4DDF440", VA = "0x184DE0840")]
	public void SetReferencePoint(Vector3 OIEODNLHPKC, Quaternion BJDKEOAGHIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4DE05A0", Offset = "0x4DDF1A0", VA = "0x184DE05A0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4DE07D0", Offset = "0x4DDF3D0", VA = "0x184DE07D0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1566740", Offset = "0x1565340", VA = "0x181566740")]
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
		[HPEOBJOJFDN(JHOIPPOHMOA.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const int OIBJHLADEOL = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int NFOBEEPDPBB = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly List<Material> ECMONEKAFBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool IJPBMIIBNKC;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4DE0A00", Offset = "0x4DDF600", VA = "0x184DE0A00")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4DE0900", Offset = "0x4DDF500", VA = "0x184DE0900")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4DE0BE0", Offset = "0x4DDF7E0", VA = "0x184DE0BE0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class CenterInImposter : MonoBehaviour, GEFEIKHPEHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4DDE6E0", Offset = "0x4DDD2E0", VA = "0x184DDE6E0", Slot = "4")]
		public void PrepareImposter(PFLLGAFLNIH AKCCEDBCHFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xCEA600", Offset = "0xCE9200", VA = "0x180CEA600")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xCEA600", Offset = "0xCE9200", VA = "0x180CEA600")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GEFEIKHPEHP
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(PFLLGAFLNIH AKCCEDBCHFC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface ANLMFOMOBHP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> DGGNMMKHGLL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> KKAELKOELNL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GKAEPGNDHPO
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EBDLDLIPAMH(params Type[] MHHHIHBJPNH);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GNHJIAPLJJA(params Type[] MHHHIHBJPNH);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject PHELMPAGCPG(GameObject GNJOLAMAHPM, Transform JNKAEALDKKD, bool KJFIBMIGEMD = false);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T PHELMPAGCPG<T>(T GNJOLAMAHPM, Transform JNKAEALDKKD, bool KJFIBMIGEMD = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T PHELMPAGCPG<T>(GameObject GNJOLAMAHPM, Transform JNKAEALDKKD, bool KJFIBMIGEMD = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject PHELMPAGCPG(GameObject GNJOLAMAHPM, Transform JNKAEALDKKD, PFLLGAFLNIH AKCCEDBCHFC, bool KJFIBMIGEMD);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T PHELMPAGCPG<T>(GameObject GNJOLAMAHPM, Transform JNKAEALDKKD, PFLLGAFLNIH AKCCEDBCHFC, bool KJFIBMIGEMD) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T PHELMPAGCPG<T>(T GNJOLAMAHPM, Transform JNKAEALDKKD, PFLLGAFLNIH AKCCEDBCHFC, bool KJFIBMIGEMD) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class DLBKBFBLEHB : IDisposable, GKAEPGNDHPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HashSet<Type> HPJAHFFCFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly HashSet<Type> CAJACJPIKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Transform IDDHFJGLDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<Component> MANKAIGNAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> LGLFOMPFFOL;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4DDEB20", Offset = "0x4DDD720", VA = "0x184DDEB20")]
	[OBNHMGHBLAL]
	public static void MPCGFJEEPGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4DDF350", Offset = "0x4DDDF50", VA = "0x184DDF350")]
	[Preserve]
	public DLBKBFBLEHB([MOCCILPMCBP(null)] ANLMFOMOBHP EADCGHHCECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4DDE860", Offset = "0x4DDD460", VA = "0x184DDE860", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4DDE960", Offset = "0x4DDD560", VA = "0x184DDE960", Slot = "5")]
	public void EBDLDLIPAMH(params Type[] MHHHIHBJPNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4DDEAD0", Offset = "0x4DDD6D0", VA = "0x184DDEAD0", Slot = "6")]
	public void GNHJIAPLJJA(params Type[] MHHHIHBJPNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4DDF0F0", Offset = "0x4DDDCF0", VA = "0x184DDF0F0", Slot = "7")]
	public GameObject PHELMPAGCPG(GameObject GNJOLAMAHPM, Transform JNKAEALDKKD, bool KJFIBMIGEMD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1F4F020", Offset = "0x1F4DC20", VA = "0x181F4F020", Slot = "8")]
	public T PHELMPAGCPG<T>(T GNJOLAMAHPM, Transform JNKAEALDKKD, bool KJFIBMIGEMD = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1F4EFF0", Offset = "0x1F4DBF0", VA = "0x181F4EFF0", Slot = "9")]
	public T PHELMPAGCPG<T>(GameObject GNJOLAMAHPM, Transform JNKAEALDKKD, bool KJFIBMIGEMD = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4DDF180", Offset = "0x4DDDD80", VA = "0x184DDF180", Slot = "10")]
	public GameObject PHELMPAGCPG(GameObject GNJOLAMAHPM, Transform JNKAEALDKKD, PFLLGAFLNIH AKCCEDBCHFC, bool KJFIBMIGEMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1F4EFA0", Offset = "0x1F4DBA0", VA = "0x181F4EFA0", Slot = "11")]
	public T PHELMPAGCPG<T>(GameObject GNJOLAMAHPM, Transform JNKAEALDKKD, PFLLGAFLNIH AKCCEDBCHFC, bool KJFIBMIGEMD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1F4E9D0", Offset = "0x1F4D5D0", VA = "0x181F4E9D0", Slot = "12")]
	public T PHELMPAGCPG<T>(T GNJOLAMAHPM, Transform JNKAEALDKKD, PFLLGAFLNIH AKCCEDBCHFC, bool KJFIBMIGEMD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1F4EA60", Offset = "0x1F4D660", VA = "0x181F4EA60")]
	private T PHELMPAGCPG<T>(GameObject GNJOLAMAHPM, Transform JNKAEALDKKD, PFLLGAFLNIH AKCCEDBCHFC, bool KJFIBMIGEMD, out GameObject NCPDIHPCGFD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1F4E550", Offset = "0x1F4D150", VA = "0x181F4E550")]
	private T ECBMKCOFFCL<T>(GameObject JNOODOEOLDA, PFLLGAFLNIH AKCCEDBCHFC, bool KJFIBMIGEMD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4DDE9B0", Offset = "0x4DDD5B0", VA = "0x184DDE9B0")]
	private void FJCCGIIPCGH(Component MHMLJIFKLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4DDEC80", Offset = "0x4DDD880", VA = "0x184DDEC80")]
	private void OICLLAABDNE(Component MHMLJIFKLGF, PFLLGAFLNIH AKCCEDBCHFC, bool KJFIBMIGEMD, [Optional] Type GNPHJOEHJJO, [Optional] Type CALBJDGILID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4DDF210", Offset = "0x4DDDE10", VA = "0x184DDF210")]
	private void PLPCAGJDLHJ(GameObject JNOODOEOLDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct PFLLGAFLNIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<Type, object> CHAMMGGJAKO;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1DE6560", Offset = "0x1DE5160", VA = "0x181DE6560")]
	public PFLLGAFLNIH HJBFPPAGLDD<T>(T BAOBCCOJLOP)
	{
		return default(PFLLGAFLNIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1F3CA40", Offset = "0x1F3B640", VA = "0x181F3CA40")]
	public T AEJJABHJBEM<T>(T AEAPDKGDJBA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x20F1EC0", Offset = "0x20F0AC0", VA = "0x1820F1EC0")]
	public bool EEMBMCCICDG<T>(out T BAOBCCOJLOP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct ALIICBKDEGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public bool CNOFAKGJEHI;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xCCD1E0", Offset = "0xCCBDE0", VA = "0x180CCD1E0")]
	public ALIICBKDEGI(bool FJJMADCEHLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct GOHABCAPMEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly bool FBBAMKCOCPC;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4DDFFA0", Offset = "0x4DDEBA0", VA = "0x184DDFFA0")]
	public GOHABCAPMEO(bool DBGPJACCGAC)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xCEA600", Offset = "0xCE9200", VA = "0x180CEA600")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ScaleInImposter : MonoBehaviour, GEFEIKHPEHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4DE2A70", Offset = "0x4DE1670", VA = "0x184DE2A70", Slot = "4")]
		public void PrepareImposter(PFLLGAFLNIH AKCCEDBCHFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xCEA600", Offset = "0xCE9200", VA = "0x180CEA600")]
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
				[Cpp2IlInjected.Address(RVA = "0x4DE2A50", Offset = "0x4DE1650", VA = "0x184DE2A50")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x4DE2A40", Offset = "0x4DE1640", VA = "0x184DE2A40")]
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
		[Cpp2IlInjected.Address(RVA = "0x4DE0880", Offset = "0x4DDF480", VA = "0x184DE0880")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class JOGFMPENNBE
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly List<URPLight> BBLBPJFILBF;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly Vector3 KLFHOBPANFC;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Vector3 ENGMKANGMIA;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static Camera OMIPHLJEIOG;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public const string KODEOAPGHAO = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public const EIJBAPLBBBG DKDPPDDIDAO = EIJBAPLBBBG.Water;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly List<Renderer> MJCHAMBNMND;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static AmbientMode JDDCKHBDHJA;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color LIIGOKGHHEE;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static Color GPKIILEBKHH;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static Color GJLJOEGPAGM;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static Cubemap OMEEGAOGNGK;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static bool NJHNPMOPFOK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera JEPNBKAAOME
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4DE1EF0", Offset = "0x4DE0AF0", VA = "0x184DE1EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4DE0C50", Offset = "0x4DDF850", VA = "0x184DE0C50")]
	public static void ACCILPFAGJI(Vector3 BAAOBFECIFB, Quaternion JAMMNOACBDO, ImposterRenderConfig KNLBJADKOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4DE25B0", Offset = "0x4DE11B0", VA = "0x184DE25B0")]
	private static void OOKPIDFDFPP(Vector3 BAAOBFECIFB, Quaternion JAMMNOACBDO, URPLight PMIPGGNGICP, ImposterRenderConfig.LightConfig ELCOPCOPBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1060", Offset = "0x4DDFC60", VA = "0x184DE1060")]
	public static void ELIIFICHFDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1240", Offset = "0x4DDFE40", VA = "0x184DE1240")]
	private static void FOJMBPMPOAD(int CMHNLCPACJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1D70", Offset = "0x4DE0970", VA = "0x184DE1D70")]
	public static void JIPDLAHLFFA(ImposterRenderConfig KNLBJADKOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1140", Offset = "0x4DDFD40", VA = "0x184DE1140")]
	public static void FCPBKHHDBOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4DE0ED0", Offset = "0x4DDFAD0", VA = "0x184DE0ED0")]
	public static void AKFKKJHDAGB(GameObject BGPGAOICHII, RenderTexture CHFJABMOHCH, ImposterRenderConfig KNLBJADKOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1850", Offset = "0x4DE0450", VA = "0x184DE1850")]
	private static void JIPCFLHDGOO(GameObject BGPGAOICHII, RenderTexture CHFJABMOHCH, ImposterRenderConfig KNLBJADKOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4DE20F0", Offset = "0x4DE0CF0", VA = "0x184DE20F0")]
	private static void KCHGMKJENNO(GameObject BGPGAOICHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4DE2420", Offset = "0x4DE1020", VA = "0x184DE2420")]
	public static void MPMFOALFEBH(List<Renderer> BMHOGPFIIIH, List<Material> AMPFCMDIPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1540", Offset = "0x4DE0140", VA = "0x184DE1540")]
	private static void GFDELKEBBGF(GameObject GNJOLAMAHPM, Vector3 ICHDKNCEHHP, Vector3 FFAIOFGLCBG, float DBIOBKHNNID, out Vector3 CMKNJCCBMKN, out Quaternion JJHLGAALFGF, out float BEMILPBFICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4DE2380", Offset = "0x4DE0F80", VA = "0x184DE2380")]
	public static RenderTexture MBEHKLCLMFK(int BJKKDBNGOID, int HGMHHJIMLEJ)
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
		public struct JMOLDOPCDKO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public KOCFEPMOONC FOALNDEPENC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public GameObject KJHGOENKGOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public RenderTexture EIJFIJEIGFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public ImposterRenderConfig FEBHAGDNMNG;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x124D7E0", Offset = "0x124C3E0", VA = "0x18124D7E0")]
			public JMOLDOPCDKO(KOCFEPMOONC PKLMFFLCDAI, GameObject ELNCBBFCPMK, RenderTexture CHFJABMOHCH, ImposterRenderConfig NJGNLFCMDLH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const int EPLANMLHLIH = 1;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int PNGGJJJENBN = 6;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static global::HIEGHEFBCJI<JMOLDOPCDKO, RenderTexture> CGOHMMNHCMA;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static readonly List<JMOLDOPCDKO> PKPFEGOAGLA;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int LMMMEOOMCAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x81B3D0", Offset = "0x819FD0", VA = "0x18081B3D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4DDFB60", Offset = "0x4DDE760", VA = "0x184DDFB60")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject BGPGAOICHII, RenderTexture CHFJABMOHCH, ImposterRenderConfig KNLBJADKOAA, CancellationToken OPEHPHNEHDG, bool HPKICEAFMIM = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4DDF680", Offset = "0x4DDE280", VA = "0x184DDF680", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4DDFAD0", Offset = "0x4DDE6D0", VA = "0x184DDFAD0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4DDF7A0", Offset = "0x4DDE3A0", VA = "0x184DDF7A0")]
		private static Task<RenderTexture> KOLIEODNDNC(JMOLDOPCDKO FLHPEJCNNIH, CancellationToken OPEHPHNEHDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4DDFF40", Offset = "0x4DDEB40", VA = "0x184DDFF40")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HNGLDPHHCGI
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static byte[] HNCEJLIIPMJ;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int GPLDKCDHCAH;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static int JHGLEHDFIPO;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static BigInteger ALPCFLGFGJH;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
	public HNGLDPHHCGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4DDFFB0", Offset = "0x4DDEBB0", VA = "0x184DDFFB0")]
	private static string CHLEKPLKKKF(byte[] GONCOEMNHPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4DE00B0", Offset = "0x4DDECB0", VA = "0x184DE00B0")]
	public static string KBPCOEPOAHA(byte[] EDEEEGMMOHA, bool EDDELBNCJAF)
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
		[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
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
