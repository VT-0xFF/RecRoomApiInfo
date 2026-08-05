using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.Logging.Attributes;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rendering_Core_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : EEFEEDICGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x827F290", Offset = "0x827E690", VA = "0x18827F290", Slot = "4")]
		public override void KECNLMAOALC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR PreRender Manager")]
	public class PreRenderManager : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public enum MPPLFKKCIBF
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface HIAOHOPPNNG
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void NBMDPHCGIHP(ScriptableRenderContext FAJBNOJIOHK, List<Camera> CIJNGEIHNEL);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface BFFPDDGGCLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void NBMDPHCGIHP(ScriptableRenderContext FAJBNOJIOHK, RenderingData EIGFLFBPNIA);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class AFEJNAJFKKB : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x827A130", Offset = "0x8279530", VA = "0x18827A130")]
			public AFEJNAJFKKB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x827A0D0", Offset = "0x82794D0", VA = "0x18827A0D0", Slot = "9")]
			public override void Execute(ScriptableRenderContext FAJBNOJIOHK, RenderingData EIGFLFBPNIA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private AFEJNAJFKKB _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<HIAOHOPPNNG> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<HIAOHOPPNNG> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<BFFPDDGGCLL> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<BFFPDDGGCLL> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8284BD0", Offset = "0x8283FD0", VA = "0x188284BD0")]
		public static void OPMJNGKABKD(MPPLFKKCIBF FOCOPPNCGLC, HIAOHOPPNNG LEAMJFHHHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8284480", Offset = "0x8283880", VA = "0x188284480")]
		public static void EOAGHKBBECA(MPPLFKKCIBF FOCOPPNCGLC, HIAOHOPPNNG LEAMJFHHHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8284B10", Offset = "0x8283F10", VA = "0x188284B10")]
		public static void OPMJNGKABKD(MPPLFKKCIBF FOCOPPNCGLC, BFFPDDGGCLL OBBOGNECGPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8284540", Offset = "0x8283940", VA = "0x188284540")]
		public static void EOAGHKBBECA(MPPLFKKCIBF FOCOPPNCGLC, BFFPDDGGCLL OBBOGNECGPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8284110", Offset = "0x8283510", VA = "0x188284110", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8284060", Offset = "0x8283460", VA = "0x188284060", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer JBNKAEBEMAK, RenderingData EIGFLFBPNIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8284300", Offset = "0x8283700", VA = "0x188284300", Slot = "9")]
		protected override void Dispose(bool KHGHABFJAOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8284600", Offset = "0x8283A00", VA = "0x188284600")]
		private static void GGDIGBCEBGF(ScriptableRenderContext FAJBNOJIOHK, List<Camera> CIJNGEIHNEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8284410", Offset = "0x8283810", VA = "0x188284410")]
		private static void EKNPFEPPLDK(ScriptableRenderContext FAJBNOJIOHK, List<Camera> CIJNGEIHNEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8283B80", Offset = "0x8282F80", VA = "0x188283B80")]
		private static void AEPEGACMFKB(ScriptableRenderContext FAJBNOJIOHK, RenderingData EIGFLFBPNIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x15D8B70", Offset = "0x15D7F70", VA = "0x1815D8B70")]
		public PreRenderManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[Tooltip("RR Fast Lines")]
	[DisallowMultipleRendererFeature(null)]
	public class FastLinesRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class NMAKNMIGPIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool BLPJOMHNLLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<JHDBLAJIHAB> MLBNNDCNLAO;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x827FE50", Offset = "0x827F250", VA = "0x18827FE50")]
			public NMAKNMIGPIJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class NCEKHKEFBHM : PreRenderManager.BFFPDDGGCLL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string HIAHHMPPMGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler FLJIHFENDPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly NMAKNMIGPIJ MNAHJFMDMHA;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x827FD90", Offset = "0x827F190", VA = "0x18827FD90")]
			public NCEKHKEFBHM(NMAKNMIGPIJ BABOJLFJCOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x827F980", Offset = "0x827ED80", VA = "0x18827F980", Slot = "4")]
			public void NBMDPHCGIHP(ScriptableRenderContext FAJBNOJIOHK, RenderingData EIGFLFBPNIA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class PJKDEINAKKF : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string GFGDIIBNGIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly NMAKNMIGPIJ BABOJLFJCOG;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8283650", Offset = "0x8282A50", VA = "0x188283650")]
			public PJKDEINAKKF(RenderPassEvent CEMDIHDCAHH, NMAKNMIGPIJ BABOJLFJCOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8283340", Offset = "0x8282740", VA = "0x188283340", Slot = "9")]
			public override void Execute(ScriptableRenderContext FAJBNOJIOHK, RenderingData EIGFLFBPNIA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<JHDBLAJIHAB> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private NCEKHKEFBHM fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private PJKDEINAKKF fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private NMAKNMIGPIJ sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x827DCB0", Offset = "0x827D0B0", VA = "0x18827DCB0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x827E040", Offset = "0x827D440", VA = "0x18827E040", Slot = "9")]
		protected override void Dispose(bool KHGHABFJAOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x827DC10", Offset = "0x827D010", VA = "0x18827DC10", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer JBNKAEBEMAK, RenderingData EIGFLFBPNIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x15D8B70", Offset = "0x15D7F70", VA = "0x1815D8B70")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JHDBLAJIHAB
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EGDDBGGDJGM(CommandBuffer JBFALIPKMAB, Camera OJMFDJBIJGL, [NotNull] UniversalAdditionalCameraData HNOALNGGHNC, bool OPPLCIKDDOL);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AIKOCOPPAJM(Camera OJMFDJBIJGL, CommandBuffer MAFGPAKILHL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PMNNGHALION
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool FKHOPLJLMMO;
}
namespace RecRoom.Core.Rendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleRendererFeature(null)]
	[ReloadGroup]
	internal class LightBinning : ScriptableRendererFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[Reload("Shaders/Utils/ComputeBufferTransfer.compute", ReloadAttribute.Package.Root)]
		public ComputeShader computeBufferTransferCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private OEAABMOLHNK _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private PDLIAGDFIGK _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x827EF60", Offset = "0x827E360", VA = "0x18827EF60", Slot = "9")]
		protected override void Dispose(bool PLMHPKHEFLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x827EFD0", Offset = "0x827E3D0", VA = "0x18827EFD0")]
		private void LKBEBGFJMAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x827EC10", Offset = "0x827E010", VA = "0x18827EC10", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer JBNKAEBEMAK, RenderingData EIGFLFBPNIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x15D8B70", Offset = "0x15D7F70", VA = "0x1815D8B70")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class JLNNEHLMKPG
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x827E860", Offset = "0x827DC60", VA = "0x18827E860")]
	public static int PJJJFNMNLOF(bool BELMLFEPNLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1A5DEF0", Offset = "0x1A5D2F0", VA = "0x181A5DEF0")]
	public static int AMNNHBHMJNJ(bool BELMLFEPNLH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct OHPCOIBPNCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType OBHIFEAHCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float ODOPJFFOHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float OGPEFHDLAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float BDMMKHAGKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 KCIHCCBLLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 DNINONFNNEJ;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct CKJCFGNMION
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort BKIMINALJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float EMNDDNNANGC;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct DLPEIFHBBDJ : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<OHPCOIBPNCF> KDKMAODENNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 EJJEKGHNCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 OIHJILJJMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, CKJCFGNMION>.ParallelWriter ABMEKOOGIDE;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x827BBB0", Offset = "0x827AFB0", VA = "0x18827BBB0", Slot = "4")]
	public void Execute(int BKIMINALJMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x827B2D0", Offset = "0x827A6D0", VA = "0x18827B2D0")]
	private void CPGLIBBEGHH(uint3 GGOJFPOLOMI, uint3 EIGAKOBPGJP, ushort BKIMINALJMH, float3 JBPDAGICMNJ, float PFNCAGMBPCN, float LBICDLJCNEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x827B700", Offset = "0x827AB00", VA = "0x18827B700")]
	private void EHEAMNOMHMC(uint3 GGOJFPOLOMI, uint3 EIGAKOBPGJP, ushort BKIMINALJMH, float3 JBPDAGICMNJ, float3 LBBFJKHKDDM, float3 JBEKCCJPPMJ, float PFNCAGMBPCN, float HJILHACCAGI, float LBICDLJCNEN, float PPHHPPJOOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x827B1E0", Offset = "0x827A5E0", VA = "0x18827B1E0")]
	private float3 CDBLGDNDECO(uint3 GGOJFPOLOMI, float3 JBPDAGICMNJ)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x827C0F0", Offset = "0x827B4F0", VA = "0x18827C0F0")]
	private float MEHNLBABHCE(float ODOPJFFOHDF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x827B640", Offset = "0x827AA40", VA = "0x18827B640")]
	private float DEALAKCDFBL(float3 PHPMHFINKMH, float3 JBEKCCJPPMJ, float HJILHACCAGI, float LBICDLJCNEN)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct CBFCLGDGLGD : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, CKJCFGNMION> ABMEKOOGIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint ACNFDBIHNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int OPABBGFLMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int PFILDPOKFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> PMKBEELKHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> PFFGCICBCDO;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x827A300", Offset = "0x8279700", VA = "0x18827A300", Slot = "4")]
	public void Execute(int ENALGKINEIE, int NPILIHDLMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x827A190", Offset = "0x8279590", VA = "0x18827A190")]
	private void CFOKJEOMIBB(int BDOGHBPBILG, ushort EENDAMINPGF, int JLGKCCIMEKO, CKJCFGNMION FLFCGMIEPFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct BKOBEBDFKIP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, CKJCFGNMION> ABMEKOOGIDE;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x827A150", Offset = "0x8279550", VA = "0x18827A150", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class OEAABMOLHNK : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool OPMLOJOAGCO;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float MMEMMGGEIBD = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int CCBOOHAHKPB = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int GEEPKIIKENG = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private DLPEIFHBBDJ FHDJJEMIOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private CBFCLGDGLGD BJOFDMJGDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private BKOBEBDFKIP LKHMOHBODGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, CKJCFGNMION> KAOPGDMEHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private FECDKAHCNKO JLGNHLDJHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool ODGOPFBBCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int LPONEDCPKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<OHPCOIBPNCF> EFDCNLHCEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle CNICOOGBFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle GFFMJEHDONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool HIDPBJIPKOP;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8280DC0", Offset = "0x82801C0", VA = "0x188280DC0")]
	public OEAABMOLHNK(RenderPassEvent CEMDIHDCAHH, ComputeShader HPKNAHOILMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x82805D0", Offset = "0x827F9D0", VA = "0x1882805D0")]
	private void FFIFONDBFML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8280920", Offset = "0x827FD20", VA = "0x188280920")]
	public void MOAHDBNGFPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x388C4E0", Offset = "0x388B8E0", VA = "0x18388C4E0")]
	public static void LOFKOMDCEKN<T>(NativeArray<T> IMLJIFPAFGH, int LLBNOFGPNDN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8280120", Offset = "0x827F520", VA = "0x188280120")]
	public void EMIFBLLBNBH(CameraData HNOALNGGHNC, LightData BCLIMCBINHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8280A00", Offset = "0x827FE00", VA = "0x188280A00")]
	private void OKNHABEOOAD(LightData BCLIMCBINHL, NativeArray<OHPCOIBPNCF> ENOHCFGGPPN, int DBNDCMFGFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x827FEE0", Offset = "0x827F2E0", VA = "0x18827FEE0")]
	private void CDDIBANDMCD(CameraData HNOALNGGHNC, LightData BCLIMCBINHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8280690", Offset = "0x827FA90", VA = "0x188280690")]
	private void IJHFHBBKFED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8280820", Offset = "0x827FC20", VA = "0x188280820")]
	private void LNKEEKOPLHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8280640", Offset = "0x827FA40", VA = "0x188280640")]
	private void GOBJDBMLEJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8280660", Offset = "0x827FA60", VA = "0x188280660")]
	private void IABOGPFNFAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x82804D0", Offset = "0x827F8D0", VA = "0x1882804D0", Slot = "9")]
	public override void Execute(ScriptableRenderContext FAJBNOJIOHK, RenderingData EIGFLFBPNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8280D40", Offset = "0x8280140", VA = "0x188280D40", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer MAFGPAKILHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PDLIAGDFIGK : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort BIGMPGJGFLD = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float MMEMMGGEIBD = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly FECDKAHCNKO JLGNHLDJHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int GKLHADMGDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private OHPCOIBPNCF[] EFDCNLHCEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 MPKBAPKLLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 MGEGPLNPBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint ELOBLCDLLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int BGACJIBFHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int DFACBHHACAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> PMKBEELKHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> PFFGCICBCDO;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8282BB0", Offset = "0x8281FB0", VA = "0x188282BB0")]
	public PDLIAGDFIGK(RenderPassEvent CEMDIHDCAHH, ComputeShader HPKNAHOILMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x82821B0", Offset = "0x82815B0", VA = "0x1882821B0")]
	public void EMIFBLLBNBH(CameraData HNOALNGGHNC, LightData BCLIMCBINHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x82824B0", Offset = "0x82818B0", VA = "0x1882824B0")]
	private void KBOFHJHBKDI(CameraData HNOALNGGHNC, LightData BCLIMCBINHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8282720", Offset = "0x8281B20", VA = "0x188282720")]
	public void MOAHDBNGFPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8282740", Offset = "0x8281B40", VA = "0x188282740")]
	private void OKNHABEOOAD(LightData BCLIMCBINHL, OHPCOIBPNCF[] ENOHCFGGPPN, int DBNDCMFGFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8281130", Offset = "0x8280530", VA = "0x188281130")]
	private void CPFCFNEMAOO(int ENALGKINEIE, int NPILIHDLMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8280F70", Offset = "0x8280370", VA = "0x188280F70")]
	private void CFFEELICEKB(int ENALGKINEIE, int PCGLBCNIEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8282470", Offset = "0x8281870", VA = "0x188282470")]
	private ushort JBCICGCOLMC(int ENALGKINEIE)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x82826B0", Offset = "0x8281AB0", VA = "0x1882826B0")]
	private void MCLNDOEAGBP(int ENALGKINEIE, int NPILIHDLMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8282400", Offset = "0x8281800", VA = "0x188282400")]
	private void JALKKOBGOOO(int LLBNOFGPNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8281BA0", Offset = "0x8280FA0", VA = "0x188281BA0")]
	private void ECDEJGMDGIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8282320", Offset = "0x8281720", VA = "0x188282320", Slot = "9")]
	public override void Execute(ScriptableRenderContext FAJBNOJIOHK, RenderingData EIGFLFBPNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8282A90", Offset = "0x8281E90", VA = "0x188282A90", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer MAFGPAKILHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x82815F0", Offset = "0x82809F0", VA = "0x1882815F0")]
	private void DBAADCNJLFL(int BKIMINALJMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x82811E0", Offset = "0x82805E0", VA = "0x1882811E0")]
	private void CPGLIBBEGHH(uint3 GGOJFPOLOMI, uint3 EIGAKOBPGJP, ushort BKIMINALJMH, float3 JBPDAGICMNJ, float PFNCAGMBPCN, float LBICDLJCNEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8281C60", Offset = "0x8281060", VA = "0x188281C60")]
	private void EHEAMNOMHMC(uint3 GGOJFPOLOMI, uint3 EIGAKOBPGJP, ushort BKIMINALJMH, float3 JBPDAGICMNJ, float3 LBBFJKHKDDM, float3 JBEKCCJPPMJ, float PFNCAGMBPCN, float HJILHACCAGI, float LBICDLJCNEN, float PPHHPPJOOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8282AC0", Offset = "0x8281EC0", VA = "0x188282AC0")]
	private void PKJNJNEANNE(ushort BKIMINALJMH, uint AGHMALLDHPK, float IOCDNLOOHLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8280E70", Offset = "0x8280270", VA = "0x188280E70")]
	private float3 CDBLGDNDECO(uint3 GGOJFPOLOMI, float3 JBPDAGICMNJ)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x827C0F0", Offset = "0x827B4F0", VA = "0x18827C0F0")]
	private float MEHNLBABHCE(float ODOPJFFOHDF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x827B640", Offset = "0x827AA40", VA = "0x18827B640")]
	private float DEALAKCDFBL(float3 PHPMHFINKMH, float3 JBEKCCJPPMJ, float HJILHACCAGI, float LBICDLJCNEN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8280FA0", Offset = "0x82803A0", VA = "0x188280FA0")]
	private void CFOKJEOMIBB(int BDOGHBPBILG, ushort EENDAMINPGF, int JLGKCCIMEKO, CKJCFGNMION FLFCGMIEPFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FECDKAHCNKO
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class IHLFJLGGENE
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int JDOKALLOJPO;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int OCPJDLLNFJJ;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int JPBNHNNJLPP;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int FPJPOJAIIDA;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int KIMKDFPJPKA;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int IMDCGFNJGBE;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int MHAFJGGILMA;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int DKLEJLGGDLJ = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int OGPIGGOPGCB = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int DPOFHIPGFIL = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int NIBKJAKLNDC = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int JFOHABOIJCN = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int IMIGHMGLGDJ = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int PEJLLJCNKAE = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool KKHBIMNFIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer DPHLLNOFNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture BMPBBCGHFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int MCEBLOCICAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int ANFHDMCNMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int NONABEKCIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int DFKFGIPIGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int FAHODCDPJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader EKFJFBMOLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int APHOHAFMMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int CAJHMKBLBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 OCNIIAEBLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 AFMDLBCBJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> NNPGLCAKMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> AHABODPMAEM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> GBLLJLFGBOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4D48840", Offset = "0x4D47C40", VA = "0x184D48840")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> FADMMENGPMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x10F3AD0", Offset = "0x10F2ED0", VA = "0x1810F3AD0")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int HFLIEMMGIAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xC330B0", Offset = "0xC324B0", VA = "0x180C330B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int KKJBDENCBGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9CFCD0", Offset = "0x9CF0D0", VA = "0x1809CFCD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader DCAEJJPGGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x827C110", Offset = "0x827B510", VA = "0x18827C110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x827C4F0", Offset = "0x827B8F0", VA = "0x18827C4F0")]
	public void BKMLDGFOOLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x827CB60", Offset = "0x827BF60", VA = "0x18827CB60")]
	public void MADOHOBMKFD(CameraData HNOALNGGHNC, LightData BCLIMCBINHL, int BHBPBEDEGMF, bool BELMLFEPNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3686A10", Offset = "0x3685E10", VA = "0x183686A10")]
	private void LOFKOMDCEKN<T>(NativeArray<T> IMLJIFPAFGH, int LLBNOFGPNDN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x827C1A0", Offset = "0x827B5A0", VA = "0x18827C1A0")]
	public void ADLGNBDOHJL(CommandBuffer MAFGPAKILHL, ScriptableRenderContext FAJBNOJIOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x827CE70", Offset = "0x827C270", VA = "0x18827CE70")]
	private static void NGGLPGCPHJB(int HNBHDCLAHNO, CommandBuffer MAFGPAKILHL, RenderBuffer IHNNLGFHIPA, ComputeBuffer AMAPGMKAOOG, ComputeShader KMDBONFAIFO, int NCLGOFCNHFM, int JMGFLBAFMKO, int DKBBODIHMIA, int CEJNAKCKGLD, int MNLFNPPFOGP, int NMKHNCEDNNE, int HELGDMJPJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x827C5E0", Offset = "0x827B9E0", VA = "0x18827C5E0")]
	public void EBAGMAFICDJ(CommandBuffer MAFGPAKILHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x827C900", Offset = "0x827BD00", VA = "0x18827C900")]
	private RenderTexture KKDJOIMBNKB(RenderTexture GGPAGKHPEPJ, int NCLGOFCNHFM, int JMGFLBAFMKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x827CAE0", Offset = "0x827BEE0", VA = "0x18827CAE0")]
	public void LGHDHADENMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x827D050", Offset = "0x827C450", VA = "0x18827D050")]
	public void OHIEENIBFCL(int NABPJEIGKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x827D2E0", Offset = "0x827C6E0", VA = "0x18827D2E0")]
	public FECDKAHCNKO()
	{
	}
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Mobile Fade")]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public struct NAKFLFNMICH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float NNELNKLEEBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float AOCPLNKFLCM;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class IEOGPFOGJJM : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string OGIEFMPDEOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler BMELIOGHFIG;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int FFIANIOMDFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material FOLPCIPPHKD;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x827E620", Offset = "0x827DA20", VA = "0x18827E620")]
			public IEOGPFOGJJM(RenderPassEvent CEMDIHDCAHH, Material FFHFAEDNMPG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x827E240", Offset = "0x827D640", VA = "0x18827E240", Slot = "9")]
			public override void Execute(ScriptableRenderContext FAJBNOJIOHK, RenderingData EIGFLFBPNIA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static NAKFLFNMICH CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private IEOGPFOGJJM m_MobileFadePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Reload("Shaders/MobileFade.shader", ReloadAttribute.Package.Root)]
		public Shader m_Shader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private Material m_Material;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x827F5F0", Offset = "0x827E9F0", VA = "0x18827F5F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x827F5A0", Offset = "0x827E9A0", VA = "0x18827F5A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x827F3F0", Offset = "0x827E7F0", VA = "0x18827F3F0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x827F320", Offset = "0x827E720", VA = "0x18827F320", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer JBNKAEBEMAK, RenderingData EIGFLFBPNIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x15D8B70", Offset = "0x15D7F70", VA = "0x1815D8B70")]
		public MobileFadeRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Mobile Vignette")]
	public class MobileVignetteRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public struct MENBFAOEOCD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float EAIPCFIHJJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color CBLIGGJLECC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh LFDAPMEPDIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve PGFIHPFGCEE;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class KKAFCLAFMMI : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string OGIEFMPDEOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler BMELIOGHFIG;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int EGPJDMADPDN;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int IIDAFDOIDDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material FOLPCIPPHKD;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x827EB30", Offset = "0x827DF30", VA = "0x18827EB30")]
			public KKAFCLAFMMI(RenderPassEvent CEMDIHDCAHH, Material FFHFAEDNMPG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x827E870", Offset = "0x827DC70", VA = "0x18827E870", Slot = "9")]
			public override void Execute(ScriptableRenderContext FAJBNOJIOHK, RenderingData EIGFLFBPNIA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static MENBFAOEOCD CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private KKAFCLAFMMI m_MobileVignettePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Reload("Shaders/MobileVignette.shader", ReloadAttribute.Package.Root)]
		public Shader m_Shader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private Material m_Material;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x827F920", Offset = "0x827ED20", VA = "0x18827F920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x827F770", Offset = "0x827EB70", VA = "0x18827F770", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x827F650", Offset = "0x827EA50", VA = "0x18827F650", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer JBNKAEBEMAK, RenderingData EIGFLFBPNIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x15D8B70", Offset = "0x15D7F70", VA = "0x1815D8B70")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string BAIHCMLDHNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool DCBNMABMLDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA148A0", Offset = "0xA13CA0", VA = "0x180A148A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer MAFGPAKILHL, ScriptableRenderContext FAJBNOJIOHK, RenderingData EIGFLFBPNIA);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9CB220", Offset = "0x9CA620", VA = "0x1809CB220")]
		protected PerCameraRenderEffect()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Per-Camera Render Effects")]
	public class PerCameraRenderEffectsRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		private class PFAKNKOFGAL : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool BLMNFAPODFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> KMHPMNPJBFL;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> GONNIGCCDME;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8283290", Offset = "0x8282690", VA = "0x188283290")]
			public PFAKNKOFGAL(RenderPassEvent CEMDIHDCAHH, bool BLMNFAPODFL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8282F10", Offset = "0x8282310", VA = "0x188282F10")]
			public bool FLMBCCCBLNM(CameraData HNOALNGGHNC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8282D40", Offset = "0x8282140", VA = "0x188282D40", Slot = "9")]
			public override void Execute(ScriptableRenderContext FAJBNOJIOHK, RenderingData EIGFLFBPNIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8282C60", Offset = "0x8282060", VA = "0x188282C60")]
			private void DIADFKJPGFC(PerCameraRenderEffect PPLCLCGGNID, ScriptableRenderContext FAJBNOJIOHK, RenderingData EIGFLFBPNIA)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private PFAKNKOFGAL m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private PFAKNKOFGAL m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x82837C0", Offset = "0x8282BC0", VA = "0x1882837C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8283730", Offset = "0x8282B30", VA = "0x188283730", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer JBNKAEBEMAK, RenderingData EIGFLFBPNIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x15D8B70", Offset = "0x15D7F70", VA = "0x1815D8B70")]
		public PerCameraRenderEffectsRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[Tooltip("RR Persistent Buffer Effects")]
	[DisallowMultipleRendererFeature(null)]
	public class PersistentBufferEffectsRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private static readonly List<ScriptableRenderPass> passes;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private const RenderPassEvent RENDER_PASS_EVENT = RenderPassEvent.BeforeRenderingShadows;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8283A10", Offset = "0x8282E10", VA = "0x188283A10")]
		public static void KIIAOEBJDND(ScriptableRenderPass DNKACHNMKDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8283870", Offset = "0x8282C70", VA = "0x188283870", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer JBNKAEBEMAK, RenderingData EIGFLFBPNIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x15D8B70", Offset = "0x15D7F70", VA = "0x1815D8B70")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class DCCCNPBKHKM
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 JEBJGJKNIII;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 CPHGLGFIJAA;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 BFAOLOCIIIB;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 JPLLIMFGMFJ;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 PMOLNIDBKKL;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x827AA80", Offset = "0x8279E80", VA = "0x18827AA80")]
	public static uint LPBEMEBJBPL(uint COBPEJEHIHC, uint CEJJJCAALLM, uint CHKEBKHPLJG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x827A640", Offset = "0x8279A40", VA = "0x18827A640")]
	public static uint3 GEMOEMBFDIE(float3 KBPOHLLNAIG, float3 EJJEKGHNCDN, float3 OIHJILJJMJB)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x827A840", Offset = "0x8279C40", VA = "0x18827A840")]
	public static void GFJBKBGECHK(float3 AFOPLBLEPNJ, float3 OOBPNMADHDP, float3 NABDHHBEDMC, float PPFBOIIFNHM, [Out] uint3 NDOPMODABNN, [Out] uint3 PHPFHJHBIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x827AA90", Offset = "0x8279E90", VA = "0x18827AA90")]
	public static void MCIEENCLKJL(float3 LMFBJOJAMFL, float3 GGKCACHJMBA, float OGPEFHDLAJP, float GJCLOFHKKJD, [Out] float3 MDCFGAHHODF, [Out] float PPFBOIIFNHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x827A4A0", Offset = "0x82798A0", VA = "0x18827A4A0")]
	private static float3 DOIFOPNDHJK(float3 JCBBECAHODI, float3 GGPDJBOCIMB, float3 CPJKJENOAEK, float3 MHBALMOOJHN)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class DFKNIOBOPPK
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly LMKAPNBAFDO IMJADIHHHOM;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly LMKAPNBAFDO HENFIHABGCO;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly LMKAPNBAFDO CPOHPEGFJBC;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly LMKAPNBAFDO JDDPNCMDMDD;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly LMKAPNBAFDO MAEGNHFIPBH;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class FOAPOFGHEEE
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh MFHDLOMIDFF;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x827DB60", Offset = "0x827CF60", VA = "0x18827DB60")]
	public static Mesh MFDGJONPILP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x827D6C0", Offset = "0x827CAC0", VA = "0x18827D6C0")]
	public static Matrix4x4 GNKALDENLBM(Camera OJMFDJBIJGL, bool BHLIAOAONDK = false, bool IDODMGBDHMJ = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x827D300", Offset = "0x827C700", VA = "0x18827D300")]
	private static Mesh BNIJADEMNBK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__300365319
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8284EC0", Offset = "0x82842C0", VA = "0x188284EC0")]
	public static void CMABMGCGHPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8284F50", Offset = "0x8284350", VA = "0x188284F50")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
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
