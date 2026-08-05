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
	public class LogRegistrationIndex : IMPGLFODBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x76D0CE0", Offset = "0x76D00E0", VA = "0x1876D0CE0", Slot = "4")]
		public override void EMOBGIHOLPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
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
		public enum FFJJPEDIACL
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface PJLPJGMLILI
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void POOMJEGGIFP(ScriptableRenderContext NOIHGGNEIML, List<Camera> JBFAAIJIMDC);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface DEHBAEJCJMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void POOMJEGGIFP(ScriptableRenderContext NOIHGGNEIML, RenderingData DAAGLNICKFH);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class KGBPNHOOPKD : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x76D0650", Offset = "0x76CFA50", VA = "0x1876D0650")]
			public KGBPNHOOPKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x76D05F0", Offset = "0x76CF9F0", VA = "0x1876D05F0", Slot = "9")]
			public override void Execute(ScriptableRenderContext NOIHGGNEIML, RenderingData DAAGLNICKFH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private KGBPNHOOPKD _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<PJLPJGMLILI> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<PJLPJGMLILI> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<DEHBAEJCJMN> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<DEHBAEJCJMN> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x76D3590", Offset = "0x76D2990", VA = "0x1876D3590")]
		public static void ECBCDHHFFNH(FFJJPEDIACL HLLCDPIPCAG, PJLPJGMLILI LNKOCOGPGGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x76D3D20", Offset = "0x76D3120", VA = "0x1876D3D20")]
		public static void OKLCOADAHMJ(FFJJPEDIACL HLLCDPIPCAG, PJLPJGMLILI LNKOCOGPGGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x76D3650", Offset = "0x76D2A50", VA = "0x1876D3650")]
		public static void ECBCDHHFFNH(FFJJPEDIACL HLLCDPIPCAG, DEHBAEJCJMN NENHPCACFGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x76D3C60", Offset = "0x76D3060", VA = "0x1876D3C60")]
		public static void OKLCOADAHMJ(FFJJPEDIACL HLLCDPIPCAG, DEHBAEJCJMN NENHPCACFGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x76D32A0", Offset = "0x76D26A0", VA = "0x1876D32A0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x76D2D50", Offset = "0x76D2150", VA = "0x1876D2D50", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IEBCHEIKEKK, RenderingData DAAGLNICKFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x76D3480", Offset = "0x76D2880", VA = "0x1876D3480", Slot = "9")]
		protected override void Dispose(bool FHGNNHNKNGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x76D3780", Offset = "0x76D2B80", VA = "0x1876D3780")]
		private static void FIMINAPIKKF(ScriptableRenderContext NOIHGGNEIML, List<Camera> JBFAAIJIMDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x76D3710", Offset = "0x76D2B10", VA = "0x1876D3710")]
		private static void EMNCBDMHDHK(ScriptableRenderContext NOIHGGNEIML, List<Camera> JBFAAIJIMDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x76D2DF0", Offset = "0x76D21F0", VA = "0x1876D2DF0")]
		private static void BJPLFDLABOP(ScriptableRenderContext NOIHGGNEIML, RenderingData DAAGLNICKFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x11BB1A0", Offset = "0x11BA5A0", VA = "0x1811BB1A0")]
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
		private class CHCAJPABJPD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool MIMBLHNOPJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<KIOMKAFHJNB> MGMEKKFEDOJ;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x76CC100", Offset = "0x76CB500", VA = "0x1876CC100")]
			public CHCAJPABJPD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class ENCNAIEJBCM : PreRenderManager.DEHBAEJCJMN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string FHOLGFPJOOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler EGHJOFANFBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly CHCAJPABJPD HBPLPCHJHCM;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x76CEA70", Offset = "0x76CDE70", VA = "0x1876CEA70")]
			public ENCNAIEJBCM(CHCAJPABJPD JGKNJMMHODN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x76CE680", Offset = "0x76CDA80", VA = "0x1876CE680", Slot = "4")]
			public void POOMJEGGIFP(ScriptableRenderContext NOIHGGNEIML, RenderingData DAAGLNICKFH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class DENEMHBAPNG : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string OFLGDNLILID;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly CHCAJPABJPD JGKNJMMHODN;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x76CE290", Offset = "0x76CD690", VA = "0x1876CE290")]
			public DENEMHBAPNG(RenderPassEvent GMKNLOPAONI, CHCAJPABJPD JGKNJMMHODN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x76CDF80", Offset = "0x76CD380", VA = "0x1876CDF80", Slot = "9")]
			public override void Execute(ScriptableRenderContext NOIHGGNEIML, RenderingData DAAGLNICKFH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<KIOMKAFHJNB> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private ENCNAIEJBCM fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private DENEMHBAPNG fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private CHCAJPABJPD sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x76CF3B0", Offset = "0x76CE7B0", VA = "0x1876CF3B0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x76CF730", Offset = "0x76CEB30", VA = "0x1876CF730", Slot = "9")]
		protected override void Dispose(bool FHGNNHNKNGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x76CF320", Offset = "0x76CE720", VA = "0x1876CF320", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IEBCHEIKEKK, RenderingData DAAGLNICKFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x11BB1A0", Offset = "0x11BA5A0", VA = "0x1811BB1A0")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KIOMKAFHJNB
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GFFEEPAHFMA(CommandBuffer KOEKDFCCNEG, Camera HNKNJAPAGLP, [NotNull] UniversalAdditionalCameraData MMIPAINCFHD, bool CBIDNDDKJNP);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IJPGCAIBJEC(Camera HNKNJAPAGLP, CommandBuffer OLNMHEANBDK);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class AFHIGLGLKFN
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool HOEAAFLJANN;
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
		private MPHPHCIFLLL _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private CHPCKGGIKFA _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x76D09C0", Offset = "0x76CFDC0", VA = "0x1876D09C0", Slot = "9")]
		protected override void Dispose(bool IGGKOFCAPFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x76D0A30", Offset = "0x76CFE30", VA = "0x1876D0A30")]
		private void EBOMJDLNMHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x76D0670", Offset = "0x76CFA70", VA = "0x1876D0670", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IEBCHEIKEKK, RenderingData DAAGLNICKFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x11BB1A0", Offset = "0x11BA5A0", VA = "0x1811BB1A0")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class JFFDAANELON
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x76D05E0", Offset = "0x76CF9E0", VA = "0x1876D05E0")]
	public static int DFFOOADNPJE(bool ADKMPGGNJIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x15F8E60", Offset = "0x15F8260", VA = "0x1815F8E60")]
	public static int OJOFBAIMEEF(bool ADKMPGGNJIH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct DNBGBJLIBCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType CPGOBFAFEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float OJGMGMAFKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float OCBAIMLDLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float HGEKAFMCNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 ABOGGEAFEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 BGEIBCBLPGK;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct CKONEEPAICE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort JMKOCNDEFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float OIHJHEDCKDC;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct AKJKMEAILGO : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<DNBGBJLIBCK> BFLHBJGEAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 MDDLCCMFMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 FEAIHMPNJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, CKONEEPAICE>.ParallelWriter KCEEBEOKALJ;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x76CAB90", Offset = "0x76C9F90", VA = "0x1876CAB90", Slot = "4")]
	public void Execute(int JMKOCNDEFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x76CB190", Offset = "0x76CA590", VA = "0x1876CB190")]
	private void JLMMNCEAJKI(uint3 JJNKHLAEDLF, uint3 MBBAGJEGGAB, ushort JMKOCNDEFEF, float3 DILGMBFOAOK, float ELMFEPEABOI, float LDALFCFBMOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x76CA5F0", Offset = "0x76C99F0", VA = "0x1876CA5F0")]
	private void CHMKGEEPGJN(uint3 JJNKHLAEDLF, uint3 MBBAGJEGGAB, ushort JMKOCNDEFEF, float3 DILGMBFOAOK, float3 AKBGKHJEFAE, float3 FLHOFCBDBON, float ELMFEPEABOI, float BGOJDFLPBOB, float LDALFCFBMOE, float MAEBPOBLBIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x76CAAA0", Offset = "0x76C9EA0", VA = "0x1876CAAA0")]
	private float3 CMFIJNNEOOE(uint3 JJNKHLAEDLF, float3 DILGMBFOAOK)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x76CB500", Offset = "0x76CA900", VA = "0x1876CB500")]
	private float MHBNKCFEBIB(float OJGMGMAFKBH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x76CB0D0", Offset = "0x76CA4D0", VA = "0x1876CB0D0")]
	private float GIDFGIPHHLD(float3 PCPDIMMCBMH, float3 FLHOFCBDBON, float BGOJDFLPBOB, float LDALFCFBMOE)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct DHKNEGIOPHA : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, CKONEEPAICE> KCEEBEOKALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint BDIJHPDJGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int GKJJHAEFGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int LDMKPCLMIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> KCJEJALGGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> JGILIAMFAGL;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x76CE4E0", Offset = "0x76CD8E0", VA = "0x1876CE4E0", Slot = "4")]
	public void Execute(int PODFIKBOLNH, int AAOHEAOBAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x76CE370", Offset = "0x76CD770", VA = "0x1876CE370")]
	private void BEKJIEKBOFN(int FMCPKFLDHAA, ushort BCJGLJIKFCJ, int KPJGLFHFHLC, CKONEEPAICE DPJPOHGMLAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct INCPFEDOPHH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, CKONEEPAICE> KCEEBEOKALJ;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x76D05A0", Offset = "0x76CF9A0", VA = "0x1876D05A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class MPHPHCIFLLL : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool MEMLAJNNCIO;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float NONCCFEFMFL = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int LODFDBBKILG = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int DLNOHEHIIKI = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private AKJKMEAILGO LEMGDBIAOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private DHKNEGIOPHA ODKEOJGIMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private INCPFEDOPHH GCIEEFKJLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, CKONEEPAICE> NBDPLOKLEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private ACIOJHDMNDG APNOHIHIHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool ECGDCJIKDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int EKPFLGDGKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<DNBGBJLIBCK> LIDCLEEPMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle BBPKCBKDJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle LILABBGHCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool CKPNCODHFMG;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x76D1C30", Offset = "0x76D1030", VA = "0x1876D1C30")]
	public MPHPHCIFLLL(RenderPassEvent GMKNLOPAONI, ComputeShader OLHKGODLNII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x76D1B50", Offset = "0x76D0F50", VA = "0x1876D1B50")]
	private void MMJODFOPLLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x76D1790", Offset = "0x76D0B90", VA = "0x1876D1790")]
	public void FHBPEMHEEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3145200", Offset = "0x3144600", VA = "0x183145200")]
	public static void DJPDDLECONN<T>(NativeArray<T> CHDCMIMONFN, int BGDDCGNLDBK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x76D13F0", Offset = "0x76D07F0", VA = "0x1876D13F0")]
	public void FBPKGNAFJHN(CameraData MMIPAINCFHD, LightData JGLJNLDOGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x76D0FB0", Offset = "0x76D03B0", VA = "0x1876D0FB0")]
	private void BPLDAKLCDFN(LightData JGLJNLDOGIH, NativeArray<DNBGBJLIBCK> HAJHFANKMLB, int KLKBNCMHFAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x76D0D70", Offset = "0x76D0170", VA = "0x1876D0D70")]
	private void ALMJOGBJLND(CameraData MMIPAINCFHD, LightData JGLJNLDOGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x76D18A0", Offset = "0x76D0CA0", VA = "0x1876D18A0")]
	private void KHHPMJOBHIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x76D1A30", Offset = "0x76D0E30", VA = "0x1876D1A30")]
	private void LIPNNOCIEDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x76D1B30", Offset = "0x76D0F30", VA = "0x1876D1B30")]
	private void LLGFOKODIPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x76D1870", Offset = "0x76D0C70", VA = "0x1876D1870")]
	private void HPOJKBOAJPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x76D12F0", Offset = "0x76D06F0", VA = "0x1876D12F0", Slot = "9")]
	public override void Execute(ScriptableRenderContext NOIHGGNEIML, RenderingData DAAGLNICKFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x76D1BC0", Offset = "0x76D0FC0", VA = "0x1876D1BC0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer OLNMHEANBDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class CHPCKGGIKFA : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort COOCMKGOGKI = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float NONCCFEFMFL = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly ACIOJHDMNDG APNOHIHIHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int JFEHJAEGDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private DNBGBJLIBCK[] LIDCLEEPMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 CEHGJHNHHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 DLHDNEGFKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint IKBBOLBCLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int FADJFBOJDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int IDHELLCACGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> KCJEJALGGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> JGILIAMFAGL;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x76CDED0", Offset = "0x76CD2D0", VA = "0x1876CDED0")]
	public CHPCKGGIKFA(RenderPassEvent GMKNLOPAONI, ComputeShader OLHKGODLNII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x76CCE80", Offset = "0x76CC280", VA = "0x1876CCE80")]
	public void FBPKGNAFJHN(CameraData MMIPAINCFHD, LightData JGLJNLDOGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x76CD010", Offset = "0x76CC410", VA = "0x1876CD010")]
	private void HGICCKPLLPL(CameraData MMIPAINCFHD, LightData JGLJNLDOGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x76CCFF0", Offset = "0x76CC3F0", VA = "0x1876CCFF0")]
	public void FHBPEMHEEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x76CC360", Offset = "0x76CB760", VA = "0x1876CC360")]
	private void BPLDAKLCDFN(LightData JGLJNLDOGIH, DNBGBJLIBCK[] HAJHFANKMLB, int KLKBNCMHFAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x76CD7C0", Offset = "0x76CCBC0", VA = "0x1876CD7C0")]
	private void ICMJDHFCFIB(int PODFIKBOLNH, int AAOHEAOBAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x76CCD70", Offset = "0x76CC170", VA = "0x1876CCD70")]
	private void COKIHAJBFGO(int PODFIKBOLNH, int ABPDJOGPHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x76CC190", Offset = "0x76CB590", VA = "0x1876CC190")]
	private ushort APKHOEAIACD(int PODFIKBOLNH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x76CCC00", Offset = "0x76CC000", VA = "0x1876CCC00")]
	private void CIOJGMBKBJJ(int PODFIKBOLNH, int AAOHEAOBAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x76CDE30", Offset = "0x76CD230", VA = "0x1876CDE30")]
	private void NLPHPAIENLB(int BGDDCGNLDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x76CDC80", Offset = "0x76CD080", VA = "0x1876CDC80")]
	private void LJABJFFGKJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x76CCDA0", Offset = "0x76CC1A0", VA = "0x1876CCDA0", Slot = "9")]
	public override void Execute(ScriptableRenderContext NOIHGGNEIML, RenderingData DAAGLNICKFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x76CDEA0", Offset = "0x76CD2A0", VA = "0x1876CDEA0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer OLNMHEANBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x76CD210", Offset = "0x76CC610", VA = "0x1876CD210")]
	private void IALHMBOPOCF(int JMKOCNDEFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x76CD870", Offset = "0x76CCC70", VA = "0x1876CD870")]
	private void JLMMNCEAJKI(uint3 JJNKHLAEDLF, uint3 MBBAGJEGGAB, ushort JMKOCNDEFEF, float3 DILGMBFOAOK, float ELMFEPEABOI, float LDALFCFBMOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x76CC6B0", Offset = "0x76CBAB0", VA = "0x1876CC6B0")]
	private void CHMKGEEPGJN(uint3 JJNKHLAEDLF, uint3 MBBAGJEGGAB, ushort JMKOCNDEFEF, float3 DILGMBFOAOK, float3 AKBGKHJEFAE, float3 FLHOFCBDBON, float ELMFEPEABOI, float BGOJDFLPBOB, float LDALFCFBMOE, float MAEBPOBLBIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x76CDD40", Offset = "0x76CD140", VA = "0x1876CDD40")]
	private void MGACFBGBPBF(ushort JMKOCNDEFEF, uint DGPHKLPLDOA, float IFNDGNFLLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x76CCC70", Offset = "0x76CC070", VA = "0x1876CCC70")]
	private float3 CMFIJNNEOOE(uint3 JJNKHLAEDLF, float3 DILGMBFOAOK)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x76CB500", Offset = "0x76CA900", VA = "0x1876CB500")]
	private float MHBNKCFEBIB(float OJGMGMAFKBH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x76CB0D0", Offset = "0x76CA4D0", VA = "0x1876CB0D0")]
	private float GIDFGIPHHLD(float3 PCPDIMMCBMH, float3 FLHOFCBDBON, float BGOJDFLPBOB, float LDALFCFBMOE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x76CC1D0", Offset = "0x76CB5D0", VA = "0x1876CC1D0")]
	private void BEKJIEKBOFN(int FMCPKFLDHAA, ushort BCJGLJIKFCJ, int KPJGLFHFHLC, CKONEEPAICE DPJPOHGMLAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class ACIOJHDMNDG
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class PBMLMNIEJPA
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int DFCMALAEMLC;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int FFFGGNLFCAP;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int GBFCDMKAICA;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int IJAHCIAFBLF;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int PANBLACGFDG;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int JFBMDKHPOBG;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int GMLBKMBFOHK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int BGCKOIGPBOP = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int CBNOABMDPKE = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int KOGFOMBINJB = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int HKKACALKHOG = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int CIDFHCNIMBM = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int HPPCLHGPPCL = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int KHBEKGHDMOG = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool KLANACLPJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer HDNNAKOPGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture EHDNKBIPEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int AHFKPLHBNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int HDLICOENIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int MEBLCENPOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int MADJLLGNENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int FCELJIEGION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader IOLKDHBJEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int KCMMABMKNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int MBCIMGPHEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 BGCIEPGPJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 EOBCONEHLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> NFALFHHPIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> KKNADANCFDD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> GPKFPDAGDCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x14606C0", Offset = "0x145FAC0", VA = "0x1814606C0")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> PLPDGAAMJCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xD07EE0", Offset = "0xD072E0", VA = "0x180D07EE0")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int DMBLDCODPKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xCF6F40", Offset = "0xCF6340", VA = "0x180CF6F40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int GOFGMIMNDPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C50", Offset = "0x8C8050", VA = "0x1808C8C50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader CEICBAMPKPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x76CA540", Offset = "0x76C9940", VA = "0x1876CA540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x76C9900", Offset = "0x76C8D00", VA = "0x1876C9900")]
	public void GMPAFBLCGBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x76C9EE0", Offset = "0x76C92E0", VA = "0x1876C9EE0")]
	public void MMKOLNGPKIG(CameraData MMIPAINCFHD, LightData JGLJNLDOGIH, int GOCGNJKIEBM, bool ADKMPGGNJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3725C30", Offset = "0x3725030", VA = "0x183725C30")]
	private void DJPDDLECONN<T>(NativeArray<T> CHDCMIMONFN, int BGDDCGNLDBK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x76CA1F0", Offset = "0x76C95F0", VA = "0x1876CA1F0")]
	public void MPKMNAGIPLL(CommandBuffer OLNMHEANBDK, ScriptableRenderContext NOIHGGNEIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x76C9410", Offset = "0x76C8810", VA = "0x1876C9410")]
	private static void FGOAMAAMFDO(int EMHFILEILBE, CommandBuffer OLNMHEANBDK, RenderBuffer BDCIFEBABOK, ComputeBuffer DOMJICLAGFK, ComputeShader DPHCJPDNFEM, int NCPCPKPNNML, int MLDKOOMMIFP, int DEIDEDKONIK, int IFOGPJEHDGM, int BPACMENIFHA, int LABNAEINMOA, int NJGEHJBNBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x76C95F0", Offset = "0x76C89F0", VA = "0x1876C95F0")]
	public void FHDCNEFLBLA(CommandBuffer OLNMHEANBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x76C99F0", Offset = "0x76C8DF0", VA = "0x1876C99F0")]
	private RenderTexture IEFLOHDLMPC(RenderTexture AALCPPOBMKI, int NCPCPKPNNML, int MLDKOOMMIFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x76C9BD0", Offset = "0x76C8FD0", VA = "0x1876C9BD0")]
	public void JHCNLGJDFGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x76C9C50", Offset = "0x76C9050", VA = "0x1876C9C50")]
	public void JNJOGKJDHNO(int MGMACBGKJJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x76CA5D0", Offset = "0x76C99D0", VA = "0x1876CA5D0")]
	public ACIOJHDMNDG()
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
		public struct NDGLPECFMHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float EGACKEKJIFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float CKKLIMMEMKA;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class PDMLFFJNKAA : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string GHIKAGENGNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler MHKGKCPDDIN;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int ELNGCNJFOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material BIAIPCBECKJ;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x76D2820", Offset = "0x76D1C20", VA = "0x1876D2820")]
			public PDMLFFJNKAA(RenderPassEvent GMKNLOPAONI, Material BEDNCOELNMN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x76D2450", Offset = "0x76D1850", VA = "0x1876D2450", Slot = "9")]
			public override void Execute(ScriptableRenderContext NOIHGGNEIML, RenderingData DAAGLNICKFH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static NDGLPECFMHK CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private PDMLFFJNKAA m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x76D1FB0", Offset = "0x76D13B0", VA = "0x1876D1FB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x76D1F60", Offset = "0x76D1360", VA = "0x1876D1F60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x76D1DB0", Offset = "0x76D11B0", VA = "0x1876D1DB0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x76D1CE0", Offset = "0x76D10E0", VA = "0x1876D1CE0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IEBCHEIKEKK, RenderingData DAAGLNICKFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x11BB1A0", Offset = "0x11BA5A0", VA = "0x1811BB1A0")]
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
		public struct IBAHGJAJIPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float OBMIPGFAFKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color PEDGLECIGCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh JNPMJIICFNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve LDLHMFDCHDP;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class HOJBFDJDDFN : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string GHIKAGENGNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler MHKGKCPDDIN;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int BKMBAKKMONB;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int BHOAEPEHOBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material BIAIPCBECKJ;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x76D04C0", Offset = "0x76CF8C0", VA = "0x1876D04C0")]
			public HOJBFDJDDFN(RenderPassEvent GMKNLOPAONI, Material BEDNCOELNMN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x76D0220", Offset = "0x76CF620", VA = "0x1876D0220", Slot = "9")]
			public override void Execute(ScriptableRenderContext NOIHGGNEIML, RenderingData DAAGLNICKFH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static IBAHGJAJIPL CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private HOJBFDJDDFN m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x76D22C0", Offset = "0x76D16C0", VA = "0x1876D22C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x76D2110", Offset = "0x76D1510", VA = "0x1876D2110", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x76D2000", Offset = "0x76D1400", VA = "0x1876D2000", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IEBCHEIKEKK, RenderingData DAAGLNICKFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x11BB1A0", Offset = "0x11BA5A0", VA = "0x1811BB1A0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string FFCNMPPLIOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool EHMIPICDBBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer OLNMHEANBDK, ScriptableRenderContext NOIHGGNEIML, RenderingData DAAGLNICKFH);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D70", Offset = "0x8C6170", VA = "0x1808C6D70")]
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
		private class FPOLBLDDAHH : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool EPNNAKPDBPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> NOLJHJHOKEB;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> OOAAJINHOFN;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x76CF270", Offset = "0x76CE670", VA = "0x1876CF270")]
			public FPOLBLDDAHH(RenderPassEvent GMKNLOPAONI, bool EPNNAKPDBPN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x76CEE20", Offset = "0x76CE220", VA = "0x1876CEE20")]
			public bool GONHHJMDKMK(CameraData MMIPAINCFHD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x76CEC50", Offset = "0x76CE050", VA = "0x1876CEC50", Slot = "9")]
			public override void Execute(ScriptableRenderContext NOIHGGNEIML, RenderingData DAAGLNICKFH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x76CF100", Offset = "0x76CE500", VA = "0x1876CF100")]
			private void LJLKIGIIDDA(PerCameraRenderEffect PALCGHJGLIC, ScriptableRenderContext NOIHGGNEIML, RenderingData DAAGLNICKFH)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private FPOLBLDDAHH m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private FPOLBLDDAHH m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x76D2990", Offset = "0x76D1D90", VA = "0x1876D2990", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x76D2900", Offset = "0x76D1D00", VA = "0x1876D2900", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IEBCHEIKEKK, RenderingData DAAGLNICKFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x11BB1A0", Offset = "0x11BA5A0", VA = "0x1811BB1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x76D2BE0", Offset = "0x76D1FE0", VA = "0x1876D2BE0")]
		public static void HOKNHDPCBPC(ScriptableRenderPass BNFPDIIHGCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x76D2A40", Offset = "0x76D1E40", VA = "0x1876D2A40", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IEBCHEIKEKK, RenderingData DAAGLNICKFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x11BB1A0", Offset = "0x11BA5A0", VA = "0x1811BB1A0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class CHALBBJPNLC
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 NOCHOFHELCH;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 NOELKPNLAMP;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 HNDEKGHGMDE;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 LPHPKPGNCIO;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 DEADJAEHAJP;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x76CB520", Offset = "0x76CA920", VA = "0x1876CB520")]
	public static uint COFILNILANO(uint KENGFOGLPKI, uint IFGPABAHODO, uint HJPNCMLKJPE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x76CB770", Offset = "0x76CAB70", VA = "0x1876CB770")]
	public static uint3 LNEJKIMGLKE(float3 CPGMOBFHDAC, float3 MDDLCCMFMNK, float3 FEAIHMPNJFJ)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x76CB530", Offset = "0x76CA930", VA = "0x1876CB530")]
	public static void DFEFGOBIPFA(float3 LJGNKKCCDJN, float3 BPJAHPEGBCO, float3 IIGELEBKCAA, float NCJKDICMFFP, [Out] uint3 LGGKAKHPFNG, [Out] uint3 LHEMDCOFAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x76CB960", Offset = "0x76CAD60", VA = "0x1876CB960")]
	public static void NDCAJJLOFLB(float3 CCHCGOMFABN, float3 OFPPPLJBMHP, float OCBAIMLDLCF, float LAJNEMAABPL, [Out] float3 DJHCDMMFNHJ, [Out] float NCJKDICMFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x76CBE30", Offset = "0x76CB230", VA = "0x1876CBE30")]
	private static float3 PCAHPIONCAM(float3 OMJGBEENCHD, float3 LEECICDMGDK, float3 AKEBHKDALDF, float3 POIBICEAKJF)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class FPDDJPJFHOP
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly GKOKEEMOOFG BPKLOHPEGEI;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly GKOKEEMOOFG KKDEKCMLIBG;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly GKOKEEMOOFG KALFDHILHNN;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly GKOKEEMOOFG DMCIGPBECAE;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly GKOKEEMOOFG EKKDGEMNEFE;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class HCNHCGCGJGF
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh HKCGHICCKFI;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x76CFDC0", Offset = "0x76CF1C0", VA = "0x1876CFDC0")]
	public static Mesh KJFBEBFDPKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x76CF920", Offset = "0x76CED20", VA = "0x1876CF920")]
	public static Matrix4x4 EAPKKDKGGLP(Camera HNKNJAPAGLP, bool OHACHIFDMIL = false, bool BAIKNDBEINH = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x76CFE60", Offset = "0x76CF260", VA = "0x1876CFE60")]
	private static Mesh NNGNPLMJNCO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3835878577
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x76D3FF0", Offset = "0x76D33F0", VA = "0x1876D3FF0")]
	public static void EAAEBHHHNNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x76D4080", Offset = "0x76D3480", VA = "0x1876D4080")]
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
