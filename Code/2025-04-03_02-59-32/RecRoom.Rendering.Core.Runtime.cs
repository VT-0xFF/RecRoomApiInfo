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
	public class LogRegistrationIndex : BDONJGGEMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7FEF940", Offset = "0x7FEED40", VA = "0x187FEF940", Slot = "4")]
		public override void GEAMIGHEOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
		public enum JFAKKLNPNKN
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface AEDNPGHNCIO
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void ADOFNKOFPAL(ScriptableRenderContext PCJJKLDOJMD, List<Camera> NHFFEEAAFMA);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface JAPLLJLKGFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void ADOFNKOFPAL(ScriptableRenderContext PCJJKLDOJMD, RenderingData EODOJGHICMH);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class ALEDIFLKNKL : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7FE8240", Offset = "0x7FE7640", VA = "0x187FE8240")]
			public ALEDIFLKNKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7FE81E0", Offset = "0x7FE75E0", VA = "0x187FE81E0", Slot = "9")]
			public override void Execute(ScriptableRenderContext PCJJKLDOJMD, RenderingData EODOJGHICMH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ALEDIFLKNKL _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<AEDNPGHNCIO> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<AEDNPGHNCIO> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<JAPLLJLKGFG> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<JAPLLJLKGFG> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7FF2550", Offset = "0x7FF1950", VA = "0x187FF2550")]
		public static void HKJFKKLDEMB(JFAKKLNPNKN KNJDMBJEOBN, AEDNPGHNCIO PENMIFFIJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7FF2740", Offset = "0x7FF1B40", VA = "0x187FF2740")]
		public static void PPJEJGKFLJF(JFAKKLNPNKN KNJDMBJEOBN, AEDNPGHNCIO PENMIFFIJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7FF2610", Offset = "0x7FF1A10", VA = "0x187FF2610")]
		public static void HKJFKKLDEMB(JFAKKLNPNKN KNJDMBJEOBN, JAPLLJLKGFG GPAIBLFAOBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7FF2800", Offset = "0x7FF1C00", VA = "0x187FF2800")]
		public static void PPJEJGKFLJF(JFAKKLNPNKN KNJDMBJEOBN, JAPLLJLKGFG GPAIBLFAOBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1D40", Offset = "0x7FF1140", VA = "0x187FF1D40", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1C90", Offset = "0x7FF1090", VA = "0x187FF1C90", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IDCFNEAMCIG, RenderingData EODOJGHICMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1F30", Offset = "0x7FF1330", VA = "0x187FF1F30", Slot = "9")]
		protected override void Dispose(bool MEBDJMLJEJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7FF2040", Offset = "0x7FF1440", VA = "0x187FF2040")]
		private static void EKNBONHOPIN(ScriptableRenderContext PCJJKLDOJMD, List<Camera> NHFFEEAAFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7FF26D0", Offset = "0x7FF1AD0", VA = "0x187FF26D0")]
		private static void JFAFPFBMDGK(ScriptableRenderContext PCJJKLDOJMD, List<Camera> NHFFEEAAFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7FF28C0", Offset = "0x7FF1CC0", VA = "0x187FF28C0")]
		private static void PPOBDJPFAHI(ScriptableRenderContext PCJJKLDOJMD, RenderingData EODOJGHICMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1547AF0", Offset = "0x1546EF0", VA = "0x181547AF0")]
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
		private class NBDONEKLNEC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool PEDKIFCPBBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<JLLKFDEBDFP> CPDLGBEGBBO;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7FF0190", Offset = "0x7FEF590", VA = "0x187FF0190")]
			public NBDONEKLNEC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class KEMEKDGKIBE : PreRenderManager.JAPLLJLKGFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string JFALBLFNMPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler HEHIJFFNFKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly NBDONEKLNEC GJPOPGPLGBA;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7FECD30", Offset = "0x7FEC130", VA = "0x187FECD30")]
			public KEMEKDGKIBE(NBDONEKLNEC ENLLHONJJNN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7FEC920", Offset = "0x7FEBD20", VA = "0x187FEC920", Slot = "4")]
			public void ADOFNKOFPAL(ScriptableRenderContext PCJJKLDOJMD, RenderingData EODOJGHICMH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class OICJFFOIELC : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string CBJJBCODNGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly NBDONEKLNEC ENLLHONJJNN;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7FF1720", Offset = "0x7FF0B20", VA = "0x187FF1720")]
			public OICJFFOIELC(RenderPassEvent KLCAIGNGMAO, NBDONEKLNEC ENLLHONJJNN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7FF1410", Offset = "0x7FF0810", VA = "0x187FF1410", Slot = "9")]
			public override void Execute(ScriptableRenderContext PCJJKLDOJMD, RenderingData EODOJGHICMH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<JLLKFDEBDFP> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private KEMEKDGKIBE fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private OICJFFOIELC fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private NBDONEKLNEC sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7FE95C0", Offset = "0x7FE89C0", VA = "0x187FE95C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7FE9950", Offset = "0x7FE8D50", VA = "0x187FE9950", Slot = "9")]
		protected override void Dispose(bool MEBDJMLJEJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7FE9520", Offset = "0x7FE8920", VA = "0x187FE9520", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IDCFNEAMCIG, RenderingData EODOJGHICMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1547AF0", Offset = "0x1546EF0", VA = "0x181547AF0")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JLLKFDEBDFP
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AJJBJNAHCDB(CommandBuffer LKGNCJKOINH, Camera FDBJNHOEMAN, [NotNull] UniversalAdditionalCameraData JCMIHJHMAAE, bool GJFFKDDIHNA);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HIDPGDHKIEE(Camera FDBJNHOEMAN, CommandBuffer HJJDDDEIKEG);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class KBDIBJBBKKI
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool EGBFCILNDNA;
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
		private JFOKJNPMFGH _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private KLPMGGFOGCG _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7FEF610", Offset = "0x7FEEA10", VA = "0x187FEF610", Slot = "9")]
		protected override void Dispose(bool EIKEBLMJPDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7FEF680", Offset = "0x7FEEA80", VA = "0x187FEF680")]
		private void KHLFKPPGNOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7FEF2C0", Offset = "0x7FEE6C0", VA = "0x187FEF2C0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IDCFNEAMCIG, RenderingData EODOJGHICMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1547AF0", Offset = "0x1546EF0", VA = "0x181547AF0")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class CEAMKJAPFPA
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7FE8910", Offset = "0x7FE7D10", VA = "0x187FE8910")]
	public static int OHCAIKGCKPA(bool FMLBAACBKKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x19C6860", Offset = "0x19C5C60", VA = "0x1819C6860")]
	public static int JLMJEIAPDKH(bool FMLBAACBKKM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct JLHENOLDFDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType MJAHGHAAFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float JPKILBAKOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float KEDOGBHAGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float DPCDINNNNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 NGDMKDPOAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 NPGBFJJNKKE;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct HNMBLBHNEMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort CMPHHOJFBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float BEIOHMAOPJJ;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct JKNOLNJEMCD : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<JLHENOLDFDO> DDDAFOBPOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 GBDCHMGOEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 KHAEJIGJILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, HNMBLBHNEMJ>.ParallelWriter AMMBPICLGMN;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBF30", Offset = "0x7FEB330", VA = "0x187FEBF30", Slot = "4")]
	public void Execute(int CMPHHOJFBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBAB0", Offset = "0x7FEAEB0", VA = "0x187FEBAB0")]
	private void ABLOLHNDFJM(uint3 JEBJHABIIBG, uint3 OHNFAMPMAPA, ushort CMPHHOJFBAA, float3 MAIFALIHAOG, float IFJMNGFNBII, float POPANEFHKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7FEC470", Offset = "0x7FEB870", VA = "0x187FEC470")]
	private void LLMOPBDBCIA(uint3 JEBJHABIIBG, uint3 OHNFAMPMAPA, ushort CMPHHOJFBAA, float3 MAIFALIHAOG, float3 PNAMCFHEBNP, float3 LABGNGMHBCB, float IFJMNGFNBII, float LDEHNBCEEGD, float POPANEFHKLF, float MMJGOAOMGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBE40", Offset = "0x7FEB240", VA = "0x187FEBE40")]
	private float3 DKCPCNOMIPD(uint3 JEBJHABIIBG, float3 MAIFALIHAOG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBE20", Offset = "0x7FEB220", VA = "0x187FEBE20")]
	private float BEIBAMBDFNK(float JPKILBAKOEL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB9F0", Offset = "0x7FEADF0", VA = "0x187FEB9F0")]
	private float AAKOHHBDLBE(float3 HDILIPHLFIM, float3 LABGNGMHBCB, float LDEHNBCEEGD, float POPANEFHKLF)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct BPNGOFFPGDM : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, HNMBLBHNEMJ> AMMBPICLGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint GELKDALLCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int MCGBMGGADEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int JEGNBBMMHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> CMICOCPGCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> LPBMPAOFDDH;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7FE8600", Offset = "0x7FE7A00", VA = "0x187FE8600", Slot = "4")]
	public void Execute(int FOAOELPHLDF, int FFDOJEBHPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7FE87A0", Offset = "0x7FE7BA0", VA = "0x187FE87A0")]
	private void INOCBJFKAMB(int NAPLCCKCHPF, ushort LHKMCDGOHLH, int OJFHHGMDKOC, HNMBLBHNEMJ EFBHDFIJKDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct PCPJBOBBDPI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, HNMBLBHNEMJ> AMMBPICLGMN;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7FF1800", Offset = "0x7FF0C00", VA = "0x187FF1800", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JFOKJNPMFGH : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool PADADMFPMIA;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float AIJMCLEGJNM = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int DCBMKENNBFK = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int FCIICIJBEBB = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private JKNOLNJEMCD KIMDAPPPGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private BPNGOFFPGDM GOAGOEFHKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private PCPJBOBBDPI DGJPPJJNPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, HNMBLBHNEMJ> GPEFKDPHKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private NMLNBFGLGLB CLNMJKEBEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool ICJMHCJCLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int KDCGECKIBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<JLHENOLDFDO> HLHGMKGMMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle HINIDOOHNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle DNGODEMCLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool FNCJCDENLCO;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB940", Offset = "0x7FEAD40", VA = "0x187FEB940")]
	public JFOKJNPMFGH(RenderPassEvent KLCAIGNGMAO, ComputeShader MAAGIDMOHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB4E0", Offset = "0x7FEA8E0", VA = "0x187FEB4E0")]
	private void IHMMABMGEGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7FEAA80", Offset = "0x7FE9E80", VA = "0x187FEAA80")]
	public void BPNLAJKJCBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3673770", Offset = "0x3672B70", VA = "0x183673770")]
	public static void FKADBNMGKDN<T>(NativeArray<T> LLPLHOOOAEB, int MNDMOIHIBEI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7FEAB60", Offset = "0x7FE9F60", VA = "0x187FEAB60")]
	public void DMAEDHBFKHA(CameraData JCMIHJHMAAE, LightData FAIJOGKCDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7FEAF10", Offset = "0x7FEA310", VA = "0x187FEAF10")]
	private void ECLENMKNDPM(LightData FAIJOGKCDJJ, NativeArray<JLHENOLDFDO> GFIDNMPOLAP, int MBEKDMKIMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB550", Offset = "0x7FEA950", VA = "0x187FEB550")]
	private void IOIKCBNCLJD(CameraData JCMIHJHMAAE, LightData FAIJOGKCDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB350", Offset = "0x7FEA750", VA = "0x187FEB350")]
	private void HHJPBBKPIML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB7C0", Offset = "0x7FEABC0", VA = "0x187FEB7C0")]
	private void LKPBHIMDBJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7FEAA60", Offset = "0x7FE9E60", VA = "0x187FEAA60")]
	private void BPEJPJDNPBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB790", Offset = "0x7FEAB90", VA = "0x187FEB790")]
	private void JNCJACFKPPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB250", Offset = "0x7FEA650", VA = "0x187FEB250", Slot = "9")]
	public override void Execute(ScriptableRenderContext PCJJKLDOJMD, RenderingData EODOJGHICMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB8C0", Offset = "0x7FEACC0", VA = "0x187FEB8C0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer HJJDDDEIKEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class KLPMGGFOGCG : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort JANNPGIFGOJ = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float AIJMCLEGJNM = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly NMLNBFGLGLB CLNMJKEBEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int IEHBJCECIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private JLHENOLDFDO[] HLHGMKGMMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 NOFGOHGPCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 FILAFKOKFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint IMPMLHPNNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int PHEBHKKGOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int CLNGIDHPHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> CMICOCPGCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> LPBMPAOFDDH;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7FEEB30", Offset = "0x7FEDF30", VA = "0x187FEEB30")]
	public KLPMGGFOGCG(RenderPassEvent KLCAIGNGMAO, ComputeShader MAAGIDMOHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7FED440", Offset = "0x7FEC840", VA = "0x187FED440")]
	public void DMAEDHBFKHA(CameraData JCMIHJHMAAE, LightData FAIJOGKCDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7FEE250", Offset = "0x7FED650", VA = "0x187FEE250")]
	private void KFPCEMHHJMB(CameraData JCMIHJHMAAE, LightData FAIJOGKCDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7FED320", Offset = "0x7FEC720", VA = "0x187FED320")]
	public void BPNLAJKJCBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7FED5B0", Offset = "0x7FEC9B0", VA = "0x187FED5B0")]
	private void ECLENMKNDPM(LightData FAIJOGKCDJJ, JLHENOLDFDO[] GFIDNMPOLAP, int MBEKDMKIMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7FED270", Offset = "0x7FEC670", VA = "0x187FED270")]
	private void BBHJFDPDHHD(int FOAOELPHLDF, int FFDOJEBHPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7FEEA90", Offset = "0x7FEDE90", VA = "0x187FEEA90")]
	private void OAJMAPAHDHF(int FOAOELPHLDF, int ECKHNAPCKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7FEEAF0", Offset = "0x7FEDEF0", VA = "0x187FEEAF0")]
	private ushort PHHKEIJLDFN(int FOAOELPHLDF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7FEE050", Offset = "0x7FED450", VA = "0x187FEE050")]
	private void HJDLPJHNLOJ(int FOAOELPHLDF, int FFDOJEBHPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7FED200", Offset = "0x7FEC600", VA = "0x187FED200")]
	private void AHKEDKENKIA(int MNDMOIHIBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7FED9E0", Offset = "0x7FECDE0", VA = "0x187FED9E0")]
	private void FNDJICHJLKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7FED900", Offset = "0x7FECD00", VA = "0x187FED900", Slot = "9")]
	public override void Execute(ScriptableRenderContext PCJJKLDOJMD, RenderingData EODOJGHICMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7FEEAC0", Offset = "0x7FEDEC0", VA = "0x187FEEAC0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer HJJDDDEIKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7FEDAA0", Offset = "0x7FECEA0", VA = "0x187FEDAA0")]
	private void GFPNKAHKNFM(int CMPHHOJFBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7FECDF0", Offset = "0x7FEC1F0", VA = "0x187FECDF0")]
	private void ABLOLHNDFJM(uint3 JEBJHABIIBG, uint3 OHNFAMPMAPA, ushort CMPHHOJFBAA, float3 MAIFALIHAOG, float IFJMNGFNBII, float POPANEFHKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7FEE450", Offset = "0x7FED850", VA = "0x187FEE450")]
	private void LLMOPBDBCIA(uint3 JEBJHABIIBG, uint3 OHNFAMPMAPA, ushort CMPHHOJFBAA, float3 MAIFALIHAOG, float3 PNAMCFHEBNP, float3 LABGNGMHBCB, float IFJMNGFNBII, float LDEHNBCEEGD, float POPANEFHKLF, float MMJGOAOMGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7FEE9A0", Offset = "0x7FEDDA0", VA = "0x187FEE9A0")]
	private void LMGAMKCDFJG(ushort CMPHHOJFBAA, uint EKCKHHBFGCL, float IBJGDMBKCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7FED340", Offset = "0x7FEC740", VA = "0x187FED340")]
	private float3 DKCPCNOMIPD(uint3 JEBJHABIIBG, float3 MAIFALIHAOG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBE20", Offset = "0x7FEB220", VA = "0x187FEBE20")]
	private float BEIBAMBDFNK(float JPKILBAKOEL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB9F0", Offset = "0x7FEADF0", VA = "0x187FEB9F0")]
	private float AAKOHHBDLBE(float3 HDILIPHLFIM, float3 LABGNGMHBCB, float LDEHNBCEEGD, float POPANEFHKLF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7FEE0C0", Offset = "0x7FED4C0", VA = "0x187FEE0C0")]
	private void INOCBJFKAMB(int NAPLCCKCHPF, ushort LHKMCDGOHLH, int OJFHHGMDKOC, HNMBLBHNEMJ EFBHDFIJKDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class NMLNBFGLGLB
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class MHIKOEDBEBN
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int GJGPLMCMFEC;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int AKLHPJIAHMA;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int ODIKBGGFAKD;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int JDBJCGEEIGG;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int MNLIIPBJPJL;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int GDGJPCPNEMJ;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int BLLNFPELDMA;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int KGAHAJBBCGI = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int FDLEALAGHCC = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int DKLGGGKANII = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int PEBPKPCIPDK = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int BECPDIDIHME = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int NEGPCHFGMPL = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int FDPJCANJOAD = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool CGJKJCIFMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer KHCJNPHKDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture GLOAKCAIOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int ADKOBBKKJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int HBINBEAEGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int MOMJDHBANAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int OIGDLICJMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int HKFKDLDPHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader KOCNANDBLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int MAEJADGGEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int MCCIOKCOACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 BJOJPPFEOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 ILENPCDNPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> IMMDIHGAJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> HLBGCFGLJKP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> KEFDOJMFBGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x48D5460", Offset = "0x48D4860", VA = "0x1848D5460")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> JFMHPAACEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1057690", Offset = "0x1056A90", VA = "0x181057690")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int CNPMCKJEKII
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xBB7280", Offset = "0xBB6680", VA = "0x180BB7280")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int KCFHJMMPCHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x993220", Offset = "0x992620", VA = "0x180993220")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader DGOONIJIDGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7FF09B0", Offset = "0x7FEFDB0", VA = "0x187FF09B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7FF0E10", Offset = "0x7FF0210", VA = "0x187FF0E10")]
	public void LIPICMLEJBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7FF10E0", Offset = "0x7FF04E0", VA = "0x187FF10E0")]
	public void OABICGNBLJI(CameraData JCMIHJHMAAE, LightData FAIJOGKCDJJ, int EOBDCAJKJHB, bool FMLBAACBKKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x37C69A0", Offset = "0x37C5DA0", VA = "0x1837C69A0")]
	private void FKADBNMGKDN<T>(NativeArray<T> LLPLHOOOAEB, int MNDMOIHIBEI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7FF0A40", Offset = "0x7FEFE40", VA = "0x187FF0A40")]
	public void GLHKOEJKONI(CommandBuffer HJJDDDEIKEG, ScriptableRenderContext PCJJKLDOJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7FF0220", Offset = "0x7FEF620", VA = "0x187FF0220")]
	private static void AGHNCGOGIIC(int OBNIDDGNPAF, CommandBuffer HJJDDDEIKEG, RenderBuffer OBJIGGDEPFK, ComputeBuffer PICNOMMCPMJ, ComputeShader LCBLGCFGLGB, int DDLNJFPAHKL, int PFJJBFOMNNF, int EBFBGPKPKFL, int BIMKLKKNLKL, int MLGGINBJKFK, int JLKOMAJFMCE, int PALEEIONCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7FF0400", Offset = "0x7FEF800", VA = "0x187FF0400")]
	public void DODOFFEMGMF(CommandBuffer HJJDDDEIKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7FF0F00", Offset = "0x7FF0300", VA = "0x187FF0F00")]
	private RenderTexture NKJDBHILIFH(RenderTexture MJGJEGIEFLL, int DDLNJFPAHKL, int PFJJBFOMNNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7FF0D90", Offset = "0x7FF0190", VA = "0x187FF0D90")]
	public void KIAOJAIOKDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7FF0720", Offset = "0x7FEFB20", VA = "0x187FF0720")]
	public void DPADAENIPPL(int LLGAJMALNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7FF13F0", Offset = "0x7FF07F0", VA = "0x187FF13F0")]
	public NMLNBFGLGLB()
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
		public struct LIHNMIJGOEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float DHCINDEBBPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float HMABBIOJCBJ;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class IBALBJJNIEL : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string GEGALCBBLEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler EEELHPKFKAA;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int KKCFAHDNOCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material ALLOHPFNEPL;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7FE9F30", Offset = "0x7FE9330", VA = "0x187FE9F30")]
			public IBALBJJNIEL(RenderPassEvent KLCAIGNGMAO, Material ANOGJJADLNE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7FE9B50", Offset = "0x7FE8F50", VA = "0x187FE9B50", Slot = "9")]
			public override void Execute(ScriptableRenderContext PCJJKLDOJMD, RenderingData EODOJGHICMH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static LIHNMIJGOEK CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private IBALBJJNIEL m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x7FEFE00", Offset = "0x7FEF200", VA = "0x187FEFE00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7FEFDB0", Offset = "0x7FEF1B0", VA = "0x187FEFDB0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7FEFC00", Offset = "0x7FEF000", VA = "0x187FEFC00", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7FEFB30", Offset = "0x7FEEF30", VA = "0x187FEFB30", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IDCFNEAMCIG, RenderingData EODOJGHICMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1547AF0", Offset = "0x1546EF0", VA = "0x181547AF0")]
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
		public struct FFLCHNLKKIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float DCFNILMCBIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color PFBPGFFHLGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh FOEBKHLEKPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve KDEMOBLINOM;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class BCMBCHNNMOF : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string GEGALCBBLEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler EEELHPKFKAA;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int HLJLAKKBEGF;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int NKJEHPEFFKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material ALLOHPFNEPL;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7FE8520", Offset = "0x7FE7920", VA = "0x187FE8520")]
			public BCMBCHNNMOF(RenderPassEvent KLCAIGNGMAO, Material ANOGJJADLNE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7FE8260", Offset = "0x7FE7660", VA = "0x187FE8260", Slot = "9")]
			public override void Execute(ScriptableRenderContext PCJJKLDOJMD, RenderingData EODOJGHICMH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static FFLCHNLKKIB CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private BCMBCHNNMOF m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x7FF0130", Offset = "0x7FEF530", VA = "0x187FF0130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7FEFF80", Offset = "0x7FEF380", VA = "0x187FEFF80", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7FEFE60", Offset = "0x7FEF260", VA = "0x187FEFE60", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IDCFNEAMCIG, RenderingData EODOJGHICMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1547AF0", Offset = "0x1546EF0", VA = "0x181547AF0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string IMDLFHJLGOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool PMIHKFIDOLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer HJJDDDEIKEG, ScriptableRenderContext PCJJKLDOJMD, RenderingData EODOJGHICMH);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x996AD0", Offset = "0x995ED0", VA = "0x180996AD0")]
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
		private class LAJKFENIDMI : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool FLNJINEFCOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> ELFDMHIMILA;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> FMCFBDILFEJ;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7FEF210", Offset = "0x7FEE610", VA = "0x187FEF210")]
			public LAJKFENIDMI(RenderPassEvent KLCAIGNGMAO, bool FLNJINEFCOP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7FEEE90", Offset = "0x7FEE290", VA = "0x187FEEE90")]
			public bool PBDFCMIDHFP(CameraData JCMIHJHMAAE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7FEEBE0", Offset = "0x7FEDFE0", VA = "0x187FEEBE0", Slot = "9")]
			public override void Execute(ScriptableRenderContext PCJJKLDOJMD, RenderingData EODOJGHICMH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7FEEDB0", Offset = "0x7FEE1B0", VA = "0x187FEEDB0")]
			private void PAJPLLEHGPH(PerCameraRenderEffect JGKFOCKBGNH, ScriptableRenderContext PCJJKLDOJMD, RenderingData EODOJGHICMH)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private LAJKFENIDMI m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private LAJKFENIDMI m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7FF18D0", Offset = "0x7FF0CD0", VA = "0x187FF18D0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1840", Offset = "0x7FF0C40", VA = "0x187FF1840", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IDCFNEAMCIG, RenderingData EODOJGHICMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1547AF0", Offset = "0x1546EF0", VA = "0x181547AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FF1980", Offset = "0x7FF0D80", VA = "0x187FF1980")]
		public static void ABKMEBDBNKL(ScriptableRenderPass CPCNPKHGHMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7FF1A60", Offset = "0x7FF0E60", VA = "0x187FF1A60", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IDCFNEAMCIG, RenderingData EODOJGHICMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1547AF0", Offset = "0x1546EF0", VA = "0x181547AF0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class FHDFHEIJKKO
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 KCNDOHGFHHA;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 BLJFHMAMABI;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 DEFFAPKNDED;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 NMHDOJBDJHP;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 PEPNKDCPGDO;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7FE9190", Offset = "0x7FE8590", VA = "0x187FE9190")]
	public static uint GHOFGGOJAFM(uint MEAMPLHPPKP, uint KDELALKKKOF, uint LLMEPBBBHGG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7FE8F90", Offset = "0x7FE8390", VA = "0x187FE8F90")]
	public static uint3 GEAFMAEHMPG(float3 INHMOEHIHAJ, float3 GBDCHMGOEKF, float3 KHAEJIGJILC)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7FE91A0", Offset = "0x7FE85A0", VA = "0x187FE91A0")]
	public static void GOAONDJPODP(float3 GKHLKGFKBHG, float3 LEFBBFEHIHJ, float3 OGHILLGDPLH, float JAINCGFCEKN, [Out] uint3 CPEFPOFBHPI, [Out] uint3 MLIOFAOFDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7FE8920", Offset = "0x7FE7D20", VA = "0x187FE8920")]
	public static void DJLHCOPEMOH(float3 MEBMPAKMKNK, float3 LMHFJFBIHDF, float KEDOGBHAGPB, float JGLHPFIJMCF, [Out] float3 FCNGDLNIIPJ, [Out] float JAINCGFCEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7FE8DF0", Offset = "0x7FE81F0", VA = "0x187FE8DF0")]
	private static float3 ECAPCEDLDCC(float3 EFPHNPJFNFK, float3 JBLIEDOMPMC, float3 EALHBLOHGBN, float3 AIIAIOLFCBO)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class JDMOJDGDFLJ
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly GBHBOJAPDOA HNGCCNFLMMA;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly GBHBOJAPDOA MNLANJMNBBJ;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly GBHBOJAPDOA CGFLCKPHLNE;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly GBHBOJAPDOA BHONDAJFGJE;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly GBHBOJAPDOA OMMBNKJONCF;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class IPNALNIIIKP
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh HKCOKKHIOPG;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7FEA870", Offset = "0x7FE9C70", VA = "0x187FEA870")]
	public static Mesh OKHFHCODJMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7FEA3D0", Offset = "0x7FE97D0", VA = "0x187FEA3D0")]
	public static Matrix4x4 MKNPDEJBDHF(Camera FDBJNHOEMAN, bool GFIOHOAIMHN = false, bool JDEBBLBNFNI = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7FEA010", Offset = "0x7FE9410", VA = "0x187FEA010")]
	private static Mesh GDINNFGBMGA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__1164651655
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7FF2FE0", Offset = "0x7FF23E0", VA = "0x187FF2FE0")]
	public static void MNMBNDKFEBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7FF2FD0", Offset = "0x7FF23D0", VA = "0x187FF2FD0")]
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
