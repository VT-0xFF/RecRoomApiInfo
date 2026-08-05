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
public class ImposterPreviewCustomFraming : MonoBehaviour, LONCJFNJAPH
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float CMNOCOGOJCB = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x58CE80", Offset = "0x58BE80", VA = "0x18058CE80", Slot = "4")]
	public void PrepareImposter(BKDLCICDJCP JPEDDPLLBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x51AEE70", Offset = "0x51ADE70", VA = "0x1851AEE70")]
	public void SetReferencePoint(Vector3 HKFOFAKFPCG, Quaternion JNLFMDDMENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x51AEBD0", Offset = "0x51ADBD0", VA = "0x1851AEBD0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x51AEE00", Offset = "0x51ADE00", VA = "0x1851AEE00")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xFBA490", Offset = "0xFB9490", VA = "0x180FBA490")]
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
		[KDJOALBJPIO(KJNDCKKOGLL.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const int FKFFFMJJGPB = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int CECKNLNFMNK = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly List<Material> KLKGIFAEJII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool BACFFAPMGKJ;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x51AF030", Offset = "0x51AE030", VA = "0x1851AF030")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x51AEF30", Offset = "0x51ADF30", VA = "0x1851AEF30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x51AF210", Offset = "0x51AE210", VA = "0x1851AF210")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class CenterInImposter : MonoBehaviour, LONCJFNJAPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x51AAF30", Offset = "0x51A9F30", VA = "0x1851AAF30", Slot = "4")]
		public void PrepareImposter(BKDLCICDJCP JPEDDPLLBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xDE3E30", Offset = "0xDE2E30", VA = "0x180DE3E30")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDE3E30", Offset = "0xDE2E30", VA = "0x180DE3E30")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LONCJFNJAPH
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(BKDLCICDJCP JPEDDPLLBDM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface CILEDOGEOJO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> FMCLICJNFPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> DKOICGPFLEN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface CCHGMOFMHGL
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GMKHJLFBDPM(params Type[] HDDCIIMCGND);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void APGDKHBOJEO(params Type[] HDDCIIMCGND);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject HLKAIIOFOOH(GameObject LCEPMNHAOBK, Transform ACJKMIDAEJL, bool PFDAJDHBLFF = false);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T HLKAIIOFOOH<T>(T LCEPMNHAOBK, Transform ACJKMIDAEJL, bool PFDAJDHBLFF = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T HLKAIIOFOOH<T>(GameObject LCEPMNHAOBK, Transform ACJKMIDAEJL, bool PFDAJDHBLFF = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject HLKAIIOFOOH(GameObject LCEPMNHAOBK, Transform ACJKMIDAEJL, BKDLCICDJCP JPEDDPLLBDM, bool PFDAJDHBLFF);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T HLKAIIOFOOH<T>(GameObject LCEPMNHAOBK, Transform ACJKMIDAEJL, BKDLCICDJCP JPEDDPLLBDM, bool PFDAJDHBLFF) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T HLKAIIOFOOH<T>(T LCEPMNHAOBK, Transform ACJKMIDAEJL, BKDLCICDJCP JPEDDPLLBDM, bool PFDAJDHBLFF) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class DEHAJPGHNND : IDisposable, CCHGMOFMHGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HashSet<Type> HOCJCHLJJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly HashSet<Type> DIGKFOKCEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private Transform MLEFOKDNGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<Component> BPJKKNHIOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> ILDAIOHCELE;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x51ABA40", Offset = "0x51AAA40", VA = "0x1851ABA40")]
	[NKCNCMJLPMH]
	public static void NCCJLLHLICO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x51ABBA0", Offset = "0x51AABA0", VA = "0x1851ABBA0")]
	[Preserve]
	public DEHAJPGHNND([EEIPLMOCPEM(null)] CILEDOGEOJO HJCNEIPPEHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x51AB220", Offset = "0x51AA220", VA = "0x1851AB220", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x51AB790", Offset = "0x51AA790", VA = "0x1851AB790", Slot = "5")]
	public void GMKHJLFBDPM(params Type[] HDDCIIMCGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x51AB0B0", Offset = "0x51AA0B0", VA = "0x1851AB0B0", Slot = "6")]
	public void APGDKHBOJEO(params Type[] HDDCIIMCGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x51AB870", Offset = "0x51AA870", VA = "0x1851AB870", Slot = "7")]
	public GameObject HLKAIIOFOOH(GameObject LCEPMNHAOBK, Transform ACJKMIDAEJL, bool PFDAJDHBLFF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x212EE60", Offset = "0x212DE60", VA = "0x18212EE60", Slot = "8")]
	public T HLKAIIOFOOH<T>(T LCEPMNHAOBK, Transform ACJKMIDAEJL, bool PFDAJDHBLFF = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x212EE30", Offset = "0x212DE30", VA = "0x18212EE30", Slot = "9")]
	public T HLKAIIOFOOH<T>(GameObject LCEPMNHAOBK, Transform ACJKMIDAEJL, bool PFDAJDHBLFF = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x51AB7E0", Offset = "0x51AA7E0", VA = "0x1851AB7E0", Slot = "10")]
	public GameObject HLKAIIOFOOH(GameObject LCEPMNHAOBK, Transform ACJKMIDAEJL, BKDLCICDJCP JPEDDPLLBDM, bool PFDAJDHBLFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x212EED0", Offset = "0x212DED0", VA = "0x18212EED0", Slot = "11")]
	public T HLKAIIOFOOH<T>(GameObject LCEPMNHAOBK, Transform ACJKMIDAEJL, BKDLCICDJCP JPEDDPLLBDM, bool PFDAJDHBLFF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x212EDA0", Offset = "0x212DDA0", VA = "0x18212EDA0", Slot = "12")]
	public T HLKAIIOFOOH<T>(T LCEPMNHAOBK, Transform ACJKMIDAEJL, BKDLCICDJCP JPEDDPLLBDM, bool PFDAJDHBLFF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x212EF20", Offset = "0x212DF20", VA = "0x18212EF20")]
	private T HLKAIIOFOOH<T>(GameObject LCEPMNHAOBK, Transform ACJKMIDAEJL, BKDLCICDJCP JPEDDPLLBDM, bool PFDAJDHBLFF, out GameObject LHJMPKLDDKH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x212F4E0", Offset = "0x212E4E0", VA = "0x18212F4E0")]
	private T OOBLGPOEAFE<T>(GameObject EMHOKENKLPP, BKDLCICDJCP JPEDDPLLBDM, bool PFDAJDHBLFF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x51AB100", Offset = "0x51AA100", VA = "0x1851AB100")]
	private void DOFBBGBGMEI(Component IMENKKCALAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x51AB320", Offset = "0x51AA320", VA = "0x1851AB320")]
	private void FAHODCMPJLF(Component IMENKKCALAL, BKDLCICDJCP JPEDDPLLBDM, bool PFDAJDHBLFF, [Optional] Type MPNEGBOHAEO, [Optional] Type CICBKMDAMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x51AB900", Offset = "0x51AA900", VA = "0x1851AB900")]
	private void MNPLILCDMNF(GameObject EMHOKENKLPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct BKDLCICDJCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<Type, object> BGKMMALMOKP;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x25F9630", Offset = "0x25F8630", VA = "0x1825F9630")]
	public BKDLCICDJCP MLBPEOBGAOB<T>(T BNNJOKOOGLA)
	{
		return default(BKDLCICDJCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x212D040", Offset = "0x212C040", VA = "0x18212D040")]
	public T PPHNCEKAGCA<T>(T KAFJNIKIDEM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x25D5650", Offset = "0x25D4650", VA = "0x1825D5650")]
	public bool HNJCPFHMOPN<T>(out T BNNJOKOOGLA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct OPMOOPLLIFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public bool ILPFFDJBDBI;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xDBFEB0", Offset = "0xDBEEB0", VA = "0x180DBFEB0")]
	public OPMOOPLLIFJ(bool OKGMEHELIGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KKFBJAKGANJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly bool AAOBEBGFDAA;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x51AF280", Offset = "0x51AE280", VA = "0x1851AF280")]
	public KKFBJAKGANJ(bool IKNGLMIMMID)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xDE3E30", Offset = "0xDE2E30", VA = "0x180DE3E30")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ScaleInImposter : MonoBehaviour, LONCJFNJAPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x51AF2C0", Offset = "0x51AE2C0", VA = "0x1851AF2C0", Slot = "4")]
		public void PrepareImposter(BKDLCICDJCP JPEDDPLLBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xDE3E30", Offset = "0xDE2E30", VA = "0x180DE3E30")]
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
				[Cpp2IlInjected.Address(RVA = "0x51AF2A0", Offset = "0x51AE2A0", VA = "0x1851AF2A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x51AF290", Offset = "0x51AE290", VA = "0x1851AF290")]
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
		[Cpp2IlInjected.Address(RVA = "0x51AEEB0", Offset = "0x51ADEB0", VA = "0x1851AEEB0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class ICNAOBBNOAP
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly List<URPLight> GBBIPGDLPDM;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly Vector3 NHBANLMMDCG;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly Vector3 IFDKPFEDAGJ;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static Camera PLBAABNECNN;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public const string EILMNNNCGAF = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public const FMOKCDPEMPJ KCGLMOOFKEN = FMOKCDPEMPJ.Water;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly List<Renderer> BCCGGIHDBLB;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static AmbientMode DJBODEHMPGL;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static Color JIJOAOKJDCA;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static Color EANCGOHNNBF;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static Color PGBPPGLPCEG;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static Cubemap BGFJNNMGOKJ;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static bool AIOLCMGFNBH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera ALEBLNNGAKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x51AD520", Offset = "0x51AC520", VA = "0x1851AD520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x51ADA60", Offset = "0x51ACA60", VA = "0x1851ADA60")]
	public static void GELBGAOIDOC(Vector3 BJKCEJBHBDB, Quaternion AAPLGAIKECH, ImposterRenderConfig NGPNADLHNMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x51AD720", Offset = "0x51AC720", VA = "0x1851AD720")]
	private static void FLINNPLPPNM(Vector3 BJKCEJBHBDB, Quaternion AAPLGAIKECH, URPLight NOKLNKHFMBF, ImposterRenderConfig.LightConfig ELEMICMGKBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x51AE6A0", Offset = "0x51AD6A0", VA = "0x1851AE6A0")]
	public static void OAOCOAHKCOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x51AE780", Offset = "0x51AD780", VA = "0x1851AE780")]
	private static void PKHKAACCFMF(int GJEHJAIINDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x51ACDE0", Offset = "0x51ABDE0", VA = "0x1851ACDE0")]
	public static void CDKJDNMMACK(ImposterRenderConfig NGPNADLHNMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x51ACF60", Offset = "0x51ABF60", VA = "0x1851ACF60")]
	public static void DAAFNMNMKMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x51AE510", Offset = "0x51AD510", VA = "0x1851AE510")]
	public static void NMELIOAOFFB(GameObject BOGEBOPEOJD, RenderTexture FBKAAFGDBNB, ImposterRenderConfig NGPNADLHNMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x51ADFF0", Offset = "0x51ACFF0", VA = "0x1851ADFF0")]
	private static void NDCHMBELJLO(GameObject BOGEBOPEOJD, RenderTexture FBKAAFGDBNB, ImposterRenderConfig NGPNADLHNMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x51AD290", Offset = "0x51AC290", VA = "0x1851AD290")]
	private static void ENOMJFLJAPD(GameObject BOGEBOPEOJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x51AD060", Offset = "0x51AC060", VA = "0x1851AD060")]
	public static void DJNPDEHCGPE(List<Renderer> LEDILDOKOFL, List<Material> ENBFMKJNBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x51ADCE0", Offset = "0x51ACCE0", VA = "0x1851ADCE0")]
	private static void LOADOICOFKK(GameObject LCEPMNHAOBK, Vector3 LBKHNHFGGHK, Vector3 DCMDEIDNIIE, float ACDMLMFEJKJ, out Vector3 ABLIKOLNNPJ, out Quaternion OGNLBNEIINN, out float EGJCJLGANKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x51AD1F0", Offset = "0x51AC1F0", VA = "0x1851AD1F0")]
	public static RenderTexture EELEHFBGINJ(int DFGJDFLDIBI, int LDIDAFFCGNN)
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
		public struct EANDPONOMIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public FKDIGOMJOEO AKBDDHENEAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public GameObject DKJCNBKKKKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public RenderTexture CEMEHNKMLEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public ImposterRenderConfig PNILEEFJJMN;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x4668FC0", Offset = "0x4667FC0", VA = "0x184668FC0")]
			public EANDPONOMIG(FKDIGOMJOEO OINEJGIHCPE, GameObject BBHDJPNKDDM, RenderTexture FBKAAFGDBNB, ImposterRenderConfig OPCKMOOOMPC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const int PHLAGEJNMGA = 1;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int FLLDNHIFCCD = 6;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static global::GHFBOKABDDJ<EANDPONOMIG, RenderTexture> NMOPFFCGDEC;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static readonly List<EANDPONOMIG> NMGPAJINHJP;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int IPGJANECGOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8C3D10", Offset = "0x8C2D10", VA = "0x1808C3D10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x51AC3B0", Offset = "0x51AB3B0", VA = "0x1851AC3B0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject BOGEBOPEOJD, RenderTexture FBKAAFGDBNB, ImposterRenderConfig NGPNADLHNMH, CancellationToken DBKPHPKFAOL, bool GBHBHCMHBHH = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x51AC200", Offset = "0x51AB200", VA = "0x1851AC200", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x51AC320", Offset = "0x51AB320", VA = "0x1851AC320", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x51ABED0", Offset = "0x51AAED0", VA = "0x1851ABED0")]
		private static Task<RenderTexture> AFEMPJNFPKH(EANDPONOMIG JDFIBJPLHMH, CancellationToken DBKPHPKFAOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x51AC790", Offset = "0x51AB790", VA = "0x1851AC790")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class FIEGLPKEOLP
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static byte[] KGMNFGCKGCC;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int PACKDELFILO;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static int EAEPHMJCION;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static BigInteger BEBMPCAFPLJ;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
	public FIEGLPKEOLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x51AC7F0", Offset = "0x51AB7F0", VA = "0x1851AC7F0")]
	private static string EHOHANMBAEF(byte[] PEAHMNEGGIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x51AC8F0", Offset = "0x51AB8F0", VA = "0x1851AC8F0")]
	public static string GFDPFHBIGNB(byte[] KCNDJOGONOI, bool LFHPFEDNDMG)
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
		[Cpp2IlInjected.Address(RVA = "0x58EAB0", Offset = "0x58DAB0", VA = "0x18058EAB0")]
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
