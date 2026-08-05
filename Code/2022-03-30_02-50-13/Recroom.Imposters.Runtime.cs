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
public class ImposterPreviewCustomFraming : MonoBehaviour, GCLBGDKBNED
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float AKDDLCKIJFF = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x520E80", Offset = "0x51F480", VA = "0x180520E80", Slot = "4")]
	public void PrepareImposter(LLLHAPLCAJC HMGNHMCNGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4AD9760", Offset = "0x4AD7D60", VA = "0x184AD9760")]
	public void SetReferencePoint(Vector3 DHDEEJIDFKF, Quaternion CHJAMPEPHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4AD94C0", Offset = "0x4AD7AC0", VA = "0x184AD94C0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4AD96F0", Offset = "0x4AD7CF0", VA = "0x184AD96F0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xB967F0", Offset = "0xB94DF0", VA = "0x180B967F0")]
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
		[HBIKBANNKLO(IEPJIHIMMDL.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const int PJBJOJJFKNF = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int GOKABOHMAMB = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly List<Material> OCNKGPDJIHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool PPEPLAAHCIG;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4AD9920", Offset = "0x4AD7F20", VA = "0x184AD9920")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4AD9820", Offset = "0x4AD7E20", VA = "0x184AD9820")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4AD9B00", Offset = "0x4AD8100", VA = "0x184AD9B00")]
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
		[Cpp2IlInjected.Address(RVA = "0x9E59B0", Offset = "0x9E3FB0", VA = "0x1809E59B0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GCLBGDKBNED
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(LLLHAPLCAJC HMGNHMCNGBD);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FONBOENNCAF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEnumerable<Type> MAPDPDCIGPG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	IEnumerable<Type> GFALDAFGKGE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BAIIEPBOLLE
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JKKAMDJGJPD(params Type[] NJDLJALJJHC);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IKFEDLNEBCG(params Type[] NJDLJALJJHC);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject BBMIOFDIALI(GameObject OBCMINAKHJC, Transform ODFEOHMNKLG, bool GKMIJHMHODO = false);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T BBMIOFDIALI<T>(T OBCMINAKHJC, Transform ODFEOHMNKLG, bool GKMIJHMHODO = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T BBMIOFDIALI<T>(GameObject OBCMINAKHJC, Transform ODFEOHMNKLG, bool GKMIJHMHODO = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject BBMIOFDIALI(GameObject OBCMINAKHJC, Transform ODFEOHMNKLG, LLLHAPLCAJC HMGNHMCNGBD, bool GKMIJHMHODO);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T BBMIOFDIALI<T>(GameObject OBCMINAKHJC, Transform ODFEOHMNKLG, LLLHAPLCAJC HMGNHMCNGBD, bool GKMIJHMHODO) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T BBMIOFDIALI<T>(T OBCMINAKHJC, Transform ODFEOHMNKLG, LLLHAPLCAJC HMGNHMCNGBD, bool GKMIJHMHODO) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class AIKMFFEINAP : IDisposable, BAIIEPBOLLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly HashSet<Type> NGPEJAGMIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HashSet<Type> HMICHKOAAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Transform MAFHOICEFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly List<Component> LIBOLLEOGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> AADIEMHDGHN;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4AD7E40", Offset = "0x4AD6440", VA = "0x184AD7E40")]
	[FFEDPJMKNFO]
	public static void EIDMKHLFNJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4AD82A0", Offset = "0x4AD68A0", VA = "0x184AD82A0")]
	[Preserve]
	public AIKMFFEINAP([IBNCCJHLCBP(null)] FONBOENNCAF CIGMOHGKCAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4AD7D40", Offset = "0x4AD6340", VA = "0x184AD7D40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4AD8110", Offset = "0x4AD6710", VA = "0x184AD8110", Slot = "5")]
	public void JKKAMDJGJPD(params Type[] NJDLJALJJHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4AD7FA0", Offset = "0x4AD65A0", VA = "0x184AD7FA0", Slot = "6")]
	public void IKFEDLNEBCG(params Type[] NJDLJALJJHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4AD77B0", Offset = "0x4AD5DB0", VA = "0x184AD77B0", Slot = "7")]
	public GameObject BBMIOFDIALI(GameObject OBCMINAKHJC, Transform ODFEOHMNKLG, bool GKMIJHMHODO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x19A3340", Offset = "0x19A1940", VA = "0x1819A3340", Slot = "8")]
	public T BBMIOFDIALI<T>(T OBCMINAKHJC, Transform ODFEOHMNKLG, bool GKMIJHMHODO = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x19A3310", Offset = "0x19A1910", VA = "0x1819A3310", Slot = "9")]
	public T BBMIOFDIALI<T>(GameObject OBCMINAKHJC, Transform ODFEOHMNKLG, bool GKMIJHMHODO = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4AD7840", Offset = "0x4AD5E40", VA = "0x184AD7840", Slot = "10")]
	public GameObject BBMIOFDIALI(GameObject OBCMINAKHJC, Transform ODFEOHMNKLG, LLLHAPLCAJC HMGNHMCNGBD, bool GKMIJHMHODO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x19A33B0", Offset = "0x19A19B0", VA = "0x1819A33B0", Slot = "11")]
	public T BBMIOFDIALI<T>(GameObject OBCMINAKHJC, Transform ODFEOHMNKLG, LLLHAPLCAJC HMGNHMCNGBD, bool GKMIJHMHODO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x19A2F20", Offset = "0x19A1520", VA = "0x1819A2F20", Slot = "12")]
	public T BBMIOFDIALI<T>(T OBCMINAKHJC, Transform ODFEOHMNKLG, LLLHAPLCAJC HMGNHMCNGBD, bool GKMIJHMHODO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x19A2FB0", Offset = "0x19A15B0", VA = "0x1819A2FB0")]
	private T BBMIOFDIALI<T>(GameObject OBCMINAKHJC, Transform ODFEOHMNKLG, LLLHAPLCAJC HMGNHMCNGBD, bool GKMIJHMHODO, out GameObject FPOFLCNFMDC) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x19A3400", Offset = "0x19A1A00", VA = "0x1819A3400")]
	private T LJGLJEFDDAA<T>(GameObject NEBFDMDBLJL, LLLHAPLCAJC HMGNHMCNGBD, bool GKMIJHMHODO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4AD7FF0", Offset = "0x4AD65F0", VA = "0x184AD7FF0")]
	private void IOEOCAHKGDC(Component FCDBKPGBIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4AD78D0", Offset = "0x4AD5ED0", VA = "0x184AD78D0")]
	private void CECKHIIDIBN(Component FCDBKPGBIPA, LLLHAPLCAJC HMGNHMCNGBD, bool GKMIJHMHODO, [Optional] Type ACGFBCKMGKG, [Optional] Type LNGCAFGDKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4AD8160", Offset = "0x4AD6760", VA = "0x184AD8160")]
	private void NPMJGPEPOBO(GameObject NEBFDMDBLJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct LLLHAPLCAJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Dictionary<Type, object> DGGMFJLEIHJ;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x18B02F0", Offset = "0x18AE8F0", VA = "0x1818B02F0")]
	public LLLHAPLCAJC IPGBKMGOHCG<T>(T OHMJBOCKFPJ)
	{
		return default(LLLHAPLCAJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x19B8F90", Offset = "0x19B7590", VA = "0x1819B8F90")]
	public T CLAMHKPLIPF<T>(T IAFLOBMOKKF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1C64B00", Offset = "0x1C63100", VA = "0x181C64B00")]
	public bool NBBLKCIGCBJ<T>(out T OHMJBOCKFPJ)
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
				[Cpp2IlInjected.Address(RVA = "0x4AD9B80", Offset = "0x4AD8180", VA = "0x184AD9B80")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x4AD9B70", Offset = "0x4AD8170", VA = "0x184AD9B70")]
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
		[Cpp2IlInjected.Address(RVA = "0x4AD97A0", Offset = "0x4AD7DA0", VA = "0x184AD97A0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class OLJHCDDDOAD
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly List<URPLight> HCLALAJLEBB;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly Vector3 DPHHLDLDPFI;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly Vector3 NMPNMICPEHJ;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static Camera CCEFCCHAOPJ;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public const string OBEDDLLJHBH = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const IAHGGBFHDGD EAMJKKMLCIA = IAHGGBFHDGD.Water;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<Renderer> BPGAFPJMOPP;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static AmbientMode DJDHOLBIPCA;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static Color ALLOGJFPAEE;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static Color DDANMDNBCGP;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static Color JHDLPMHBJJL;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static Cubemap MALOMIKEIHC;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static bool EOEIMBONLMC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static Camera NFFKPEDFLAG
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4ADB280", Offset = "0x4AD9880", VA = "0x184ADB280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4ADA680", Offset = "0x4AD8C80", VA = "0x184ADA680")]
	public static void HMPEGFIKNCB(Vector3 HCMKBBBPKEL, Quaternion JGJKCLNLMLP, ImposterRenderConfig JLLPFDGKODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4ADB480", Offset = "0x4AD9A80", VA = "0x184ADB480")]
	private static void PBMAKCMLILI(Vector3 HCMKBBBPKEL, Quaternion JGJKCLNLMLP, URPLight DCFFIINDODD, ImposterRenderConfig.LightConfig CICHFOBIADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4AD9D20", Offset = "0x4AD8320", VA = "0x184AD9D20")]
	public static void CGJBEGJOLGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4ADACF0", Offset = "0x4AD92F0", VA = "0x184ADACF0")]
	private static void KGNCIAJCLIA(int FCGNJMCPGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4AD9BA0", Offset = "0x4AD81A0", VA = "0x184AD9BA0")]
	public static void ABHIKIGNBLP(ImposterRenderConfig JLLPFDGKODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4ADB180", Offset = "0x4AD9780", VA = "0x184ADB180")]
	public static void LICGNNHGCIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4ADAFF0", Offset = "0x4AD95F0", VA = "0x184ADAFF0")]
	public static void KLIMMICDDKL(GameObject NDMLPIINJBM, RenderTexture MCKKAPCNBMB, ImposterRenderConfig JLLPFDGKODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4ADA090", Offset = "0x4AD8690", VA = "0x184ADA090")]
	private static void HEAICFFMBJA(GameObject NDMLPIINJBM, RenderTexture MCKKAPCNBMB, ImposterRenderConfig JLLPFDGKODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4AD9E00", Offset = "0x4AD8400", VA = "0x184AD9E00")]
	private static void GMHLOACJHCN(GameObject NDMLPIINJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4ADB7C0", Offset = "0x4AD9DC0", VA = "0x184ADB7C0")]
	public static void POCDMJNFOIA(List<Renderer> JKDDLGDMOGL, List<Material> EMNCPLKACKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4ADA900", Offset = "0x4AD8F00", VA = "0x184ADA900")]
	private static void JBPEJJKHMGB(List<Renderer> JKDDLGDMOGL, Vector3 NACMJGAKPAM, Vector3 HNAMIDEMBCG, float LDNEBJJLCKE, out Vector3 CIJFGOKIMDN, out Quaternion GNIJMBECPNM, out float HNJAOJDLDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4ADA5E0", Offset = "0x4AD8BE0", VA = "0x184ADA5E0")]
	public static RenderTexture HEMFFLOLDOA(int NABAGIDNPBH, int LCHOEMIECIB)
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
		public struct NPONEGMAGBM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public CANEJGJNLDJ IDNLEEMOIOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public GameObject KEKBNHLHJHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public RenderTexture CMLFMHOEBIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public ImposterRenderConfig DAJEGFMHPFB;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x18159E0", Offset = "0x1813FE0", VA = "0x1818159E0")]
			public NPONEGMAGBM(CANEJGJNLDJ IKPCHBIFCLH, GameObject KDJPHGDLDKC, RenderTexture MCKKAPCNBMB, ImposterRenderConfig AODCNHIFAKF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const int PPEHFOBGFNG = 1;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const int IGGJPPCHOKJ = 6;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static global::CJBGLIMGGBJ<NPONEGMAGBM, RenderTexture> MIJKPJKFOON;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static readonly List<NPONEGMAGBM> IFBIEDDDOLB;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private static int LPBMPPAANMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x718E00", Offset = "0x717400", VA = "0x180718E00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4AD8A90", Offset = "0x4AD7090", VA = "0x184AD8A90")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject NDMLPIINJBM, RenderTexture MCKKAPCNBMB, ImposterRenderConfig JLLPFDGKODM, CancellationToken NJLCMLGACFJ, bool EPKPIGDKDBA = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4AD85B0", Offset = "0x4AD6BB0", VA = "0x184AD85B0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4AD8A00", Offset = "0x4AD7000", VA = "0x184AD8A00", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4AD86D0", Offset = "0x4AD6CD0", VA = "0x184AD86D0")]
		private static Task<RenderTexture> GPPEKCPDLNB(NPONEGMAGBM JNLCPKFHCNJ, CancellationToken NJLCMLGACFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4AD8E70", Offset = "0x4AD7470", VA = "0x184AD8E70")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class EEDIADJHOAL
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static byte[] GGHPKOFMNIO;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static int KCKCMMJGOCO;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static int BOFMOMDGGBC;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static BigInteger PJEPEPBBIPN;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
	public EEDIADJHOAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4AD9200", Offset = "0x4AD7800", VA = "0x184AD9200")]
	private static string IAEECNCONGN(byte[] KFLJJIMMFKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4AD8ED0", Offset = "0x4AD74D0", VA = "0x184AD8ED0")]
	public static string AGDFJGHALKO(byte[] MOPADMGKCOG, bool CNBJECBCBOC)
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
		[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
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
