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
	public class LogRegistrationIndex : HJMIPPBHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8791690", Offset = "0x878FE90", VA = "0x188791690", Slot = "4")]
		public override void KELFLPPCOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		public enum GGEPNBFCKPP
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface GOJFBKEKKHK
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void BFIONFFGJIC(ScriptableRenderContext MJAGIMDGJBK, List<Camera> GJDADGAKLPP);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface HPLPICHFKDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void BFIONFFGJIC(ScriptableRenderContext MJAGIMDGJBK, RenderingData HJEINGEGIBA);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class OPMNCEPNKFC : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8792D80", Offset = "0x8791580", VA = "0x188792D80")]
			public OPMNCEPNKFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8792D20", Offset = "0x8791520", VA = "0x188792D20", Slot = "9")]
			public override void Execute(ScriptableRenderContext MJAGIMDGJBK, RenderingData HJEINGEGIBA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private OPMNCEPNKFC _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<GOJFBKEKKHK> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<GOJFBKEKKHK> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<HPLPICHFKDA> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<HPLPICHFKDA> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8793B60", Offset = "0x8792360", VA = "0x188793B60")]
		public static void FPNMJEGJCMH(GGEPNBFCKPP BEBDJDNEKMB, GOJFBKEKKHK KHKKEMFDEBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8793D50", Offset = "0x8792550", VA = "0x188793D50")]
		public static void MDJNBIJAIHG(GGEPNBFCKPP BEBDJDNEKMB, GOJFBKEKKHK KHKKEMFDEBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8793AA0", Offset = "0x87922A0", VA = "0x188793AA0")]
		public static void FPNMJEGJCMH(GGEPNBFCKPP BEBDJDNEKMB, HPLPICHFKDA FNDGAIFIEBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8793C90", Offset = "0x8792490", VA = "0x188793C90")]
		public static void MDJNBIJAIHG(GGEPNBFCKPP BEBDJDNEKMB, HPLPICHFKDA FNDGAIFIEBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x87932D0", Offset = "0x8791AD0", VA = "0x1887932D0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8793230", Offset = "0x8791A30", VA = "0x188793230", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FKGIDFBJGGD, RenderingData HJEINGEGIBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x87934B0", Offset = "0x8791CB0", VA = "0x1887934B0", Slot = "9")]
		protected override void Dispose(bool OMBOBNKKHMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x87935C0", Offset = "0x8791DC0", VA = "0x1887935C0")]
		private static void FJPCDBIBPFI(ScriptableRenderContext MJAGIMDGJBK, List<Camera> GJDADGAKLPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8793C20", Offset = "0x8792420", VA = "0x188793C20")]
		private static void HMJDCLAEODP(ScriptableRenderContext MJAGIMDGJBK, List<Camera> GJDADGAKLPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8793E10", Offset = "0x8792610", VA = "0x188793E10")]
		private static void OHGIPDMFHGO(ScriptableRenderContext MJAGIMDGJBK, RenderingData HJEINGEGIBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1767B30", Offset = "0x1766330", VA = "0x181767B30")]
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
		private class DKBGFFEJEHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool KNLCFMDIABB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<JINFJHPLONB> MJGKFDJIMJP;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x878DC80", Offset = "0x878C480", VA = "0x18878DC80")]
			public DKBGFFEJEHF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class BJEJKAKLGCE : PreRenderManager.HPLPICHFKDA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string BHHHNNCGNDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler LJCGOIKKLDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly DKBGFFEJEHF KJMGAADODLI;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x878AC40", Offset = "0x8789440", VA = "0x18878AC40")]
			public BJEJKAKLGCE(DKBGFFEJEHF CDKBBBJHBMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x878A850", Offset = "0x8789050", VA = "0x18878A850", Slot = "4")]
			public void BFIONFFGJIC(ScriptableRenderContext MJAGIMDGJBK, RenderingData HJEINGEGIBA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class LBDNCILAFMB : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string MEJBEKIEMIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly DKBGFFEJEHF CDKBBBJHBMG;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x87900F0", Offset = "0x878E8F0", VA = "0x1887900F0")]
			public LBDNCILAFMB(RenderPassEvent GPLJMGHJPHO, DKBGFFEJEHF CDKBBBJHBMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x878FDE0", Offset = "0x878E5E0", VA = "0x18878FDE0", Slot = "9")]
			public override void Execute(ScriptableRenderContext MJAGIMDGJBK, RenderingData HJEINGEGIBA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<JINFJHPLONB> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private BJEJKAKLGCE fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private LBDNCILAFMB fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private DKBGFFEJEHF sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x878EF80", Offset = "0x878D780", VA = "0x18878EF80", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x878F300", Offset = "0x878DB00", VA = "0x18878F300", Slot = "9")]
		protected override void Dispose(bool OMBOBNKKHMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x878EEF0", Offset = "0x878D6F0", VA = "0x18878EEF0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FKGIDFBJGGD, RenderingData HJEINGEGIBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1767B30", Offset = "0x1766330", VA = "0x181767B30")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JINFJHPLONB
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CKLCCCBGJED(CommandBuffer KOCIDLKHEMF, Camera KBMHMGBHCFM, [NotNull] UniversalAdditionalCameraData MBMMNELFKDC, bool NJCNMCFAAHP);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKFPAJEFCCD(Camera KBMHMGBHCFM, CommandBuffer CAGFFDPMGEA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class DIKLLAIBENO
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool JKAJLNICMCD;
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
		private DACLFCCHHOP _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private BKECDPBENPE _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8791370", Offset = "0x878FB70", VA = "0x188791370", Slot = "9")]
		protected override void Dispose(bool KIDLLCPIILK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x87913E0", Offset = "0x878FBE0", VA = "0x1887913E0")]
		private void LPLBNHACKPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8791020", Offset = "0x878F820", VA = "0x188791020", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FKGIDFBJGGD, RenderingData HJEINGEGIBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1767B30", Offset = "0x1766330", VA = "0x181767B30")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class JABNMBMGNKP
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x878F610", Offset = "0x878DE10", VA = "0x18878F610")]
	public static int NGIKMEENIOJ(bool NJKKOFBAKPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1C0DED0", Offset = "0x1C0C6D0", VA = "0x181C0DED0")]
	public static int CFOMDCHMLOK(bool NJKKOFBAKPP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct EAGOJMJDGDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType POIEFCFBGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float OIJDAOIGJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float LGACFNJFHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float DOEOBGBOPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 MLCDLBBPIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 GFCAIMOBCKD;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct BPFCBKOOOAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort LCLOJFJPMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float KJMOFNNBBJM;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct LIIMCJCIAAP : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<EAGOJMJDGDL> IFFONCDOMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 EOCOCNJPBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 AHHPIPPHAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, BPFCBKOOOAG>.ParallelWriter HMMCPFFFGEI;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8790AE0", Offset = "0x878F2E0", VA = "0x188790AE0", Slot = "4")]
	public void Execute(int LCLOJFJPMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8790680", Offset = "0x878EE80", VA = "0x188790680")]
	private void DLHNCMHCLDN(uint3 KNELHDAMDMM, uint3 NEJNFNMAEKB, ushort LCLOJFJPMFP, float3 LACCKGGOPGM, float DCPHILPFHMP, float NPFBBLCKOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x87901D0", Offset = "0x878E9D0", VA = "0x1887901D0")]
	private void CCNCOEOCCBP(uint3 KNELHDAMDMM, uint3 NEJNFNMAEKB, ushort LCLOJFJPMFP, float3 LACCKGGOPGM, float3 BCOANMGNEPC, float3 DHALCJLJEFJ, float DCPHILPFHMP, float OMOOLKJGKCI, float NPFBBLCKOJJ, float LGABABFGBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x87909F0", Offset = "0x878F1F0", VA = "0x1887909F0")]
	private float3 DNIBPPDHGHN(uint3 KNELHDAMDMM, float3 LACCKGGOPGM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x878C320", Offset = "0x878AB20", VA = "0x18878C320")]
	private float FNHOOHEJMBP(float OIJDAOIGJEM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x878B250", Offset = "0x8789A50", VA = "0x18878B250")]
	private float CDGGHJMKMFE(float3 ICIPPEHHOGO, float3 DHALCJLJEFJ, float OMOOLKJGKCI, float NPFBBLCKOJJ)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct KDFEHOCBDKM : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, BPFCBKOOOAG> HMMCPFFFGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint DFNDCLCBNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int EOOMGDMELLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int FBKODBOPPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> EGHEIIFKFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> BIAINIAHEMP;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x878F620", Offset = "0x878DE20", VA = "0x18878F620", Slot = "4")]
	public void Execute(int CPFHJKLLOAP, int OBKCCFOHJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x878F7C0", Offset = "0x878DFC0", VA = "0x18878F7C0")]
	private void OOJMAHMNPFJ(int IDLEOONNFGC, ushort OFJEKAOALCF, int NJLBHIOJDLC, BPFCBKOOOAG AFEAFNINKEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct PHIBIPAEDLH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, BPFCBKOOOAG> HMMCPFFFGEI;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8792DA0", Offset = "0x87915A0", VA = "0x188792DA0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DACLFCCHHOP : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool AIEHPAIKMJN;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float EKIHOHPKPAD = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int OPMBBDAHAHN = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int NBHLFFPFIBL = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private LIIMCJCIAAP LPPBBBBOOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private KDFEHOCBDKM JALFDFELJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private PHIBIPAEDLH OOHLFIEBJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, BPFCBKOOOAG> CEGHDOFAMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private FPMIALDNMJI GFCGNANPDFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool AFKEFNGGGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int NLLAEFJNHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<EAGOJMJDGDL> KIHDEKJDCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle DCMMLBEDOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle CPEEOJLALFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool FDGHEKDFHJA;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x878DBD0", Offset = "0x878C3D0", VA = "0x18878DBD0")]
	public DACLFCCHHOP(RenderPassEvent GPLJMGHJPHO, ComputeShader IPLIJEENGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x878D9C0", Offset = "0x878C1C0", VA = "0x18878D9C0")]
	private void NDMEMEENONI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x878D520", Offset = "0x878BD20", VA = "0x18878D520")]
	public void KKFHGPBNMNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x37F2AD0", Offset = "0x37F12D0", VA = "0x1837F2AD0")]
	public static void IENPEICCDAJ<T>(NativeArray<T> LPBOBEPEKNH, int GGIJOHIPOOO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x878D620", Offset = "0x878BE20", VA = "0x18878D620")]
	public void MPMDLDOACNH(CameraData MBMMNELFKDC, LightData DCAOIJKICAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x878CD10", Offset = "0x878B510", VA = "0x18878CD10")]
	private void EDKNGJEGABH(LightData DCAOIJKICAG, NativeArray<EAGOJMJDGDL> LGIMJDDFMMN, int OIDPDKILGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x878D2E0", Offset = "0x878BAE0", VA = "0x18878D2E0")]
	private void IKFJPPIJEAP(CameraData MBMMNELFKDC, LightData DCAOIJKICAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x878D050", Offset = "0x878B850", VA = "0x18878D050")]
	private void EMCEOLCAPGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x878DA30", Offset = "0x878C230", VA = "0x18878DA30")]
	private void OEKONPCPPLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x878D600", Offset = "0x878BE00", VA = "0x18878D600")]
	private void MJOAJCELJOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x878DB60", Offset = "0x878C360", VA = "0x18878DB60")]
	private void PJFMEEIOLFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x878D1E0", Offset = "0x878B9E0", VA = "0x18878D1E0", Slot = "9")]
	public override void Execute(ScriptableRenderContext MJAGIMDGJBK, RenderingData HJEINGEGIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x878DB30", Offset = "0x878C330", VA = "0x18878DB30", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer CAGFFDPMGEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BKECDPBENPE : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort NAKBHHIBKNO = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float EKIHOHPKPAD = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly FPMIALDNMJI GFCGNANPDFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int OCEIGDJBNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private EAGOJMJDGDL[] KIHDEKJDCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 DJPJGFBGEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 OCOJFNANBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint GBNNAMCDGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int BCDIBEFJLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int IBALNPMLCKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> EGHEIIFKFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> BIAINIAHEMP;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x878CB20", Offset = "0x878B320", VA = "0x18878CB20")]
	public BKECDPBENPE(RenderPassEvent GPLJMGHJPHO, ComputeShader IPLIJEENGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x878C580", Offset = "0x878AD80", VA = "0x18878C580")]
	public void MPMDLDOACNH(CameraData MBMMNELFKDC, LightData DCAOIJKICAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x878C760", Offset = "0x878AF60", VA = "0x18878C760")]
	private void OKDIKCKNOKL(CameraData MBMMNELFKDC, LightData DCAOIJKICAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x878C4A0", Offset = "0x878ACA0", VA = "0x18878C4A0")]
	public void KKFHGPBNMNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x878BEF0", Offset = "0x878A6F0", VA = "0x18878BEF0")]
	private void EDKNGJEGABH(LightData DCAOIJKICAG, EAGOJMJDGDL[] LGIMJDDFMMN, int OIDPDKILGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x878B8C0", Offset = "0x878A0C0", VA = "0x18878B8C0")]
	private void DIJBDFJHCLF(int CPFHJKLLOAP, int OBKCCFOHJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x878C430", Offset = "0x878AC30", VA = "0x18878C430")]
	private void HBOPDDNKEDP(int CPFHJKLLOAP, int FMGALNGIOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x878C460", Offset = "0x878AC60", VA = "0x18878C460")]
	private ushort IBDPGJHDBKJ(int CPFHJKLLOAP)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x878C6F0", Offset = "0x878AEF0", VA = "0x18878C6F0")]
	private void OEEKAAMKFPN(int CPFHJKLLOAP, int OBKCCFOHJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x878BE80", Offset = "0x878A680", VA = "0x18878BE80")]
	private void EAAANPGDOGN(int GGIJOHIPOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x878C4C0", Offset = "0x878ACC0", VA = "0x18878C4C0")]
	private void LKCLEKHGDEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x878C240", Offset = "0x878AA40", VA = "0x18878C240", Slot = "9")]
	public override void Execute(ScriptableRenderContext MJAGIMDGJBK, RenderingData HJEINGEGIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x878CAF0", Offset = "0x878B2F0", VA = "0x18878CAF0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer CAGFFDPMGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x878B310", Offset = "0x8789B10", VA = "0x18878B310")]
	private void CPJIIIKNOCM(int LCLOJFJPMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x878B970", Offset = "0x878A170", VA = "0x18878B970")]
	private void DLHNCMHCLDN(uint3 KNELHDAMDMM, uint3 NEJNFNMAEKB, ushort LCLOJFJPMFP, float3 LACCKGGOPGM, float DCPHILPFHMP, float NPFBBLCKOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x878AD00", Offset = "0x8789500", VA = "0x18878AD00")]
	private void CCNCOEOCCBP(uint3 KNELHDAMDMM, uint3 NEJNFNMAEKB, ushort LCLOJFJPMFP, float3 LACCKGGOPGM, float3 BCOANMGNEPC, float3 DHALCJLJEFJ, float DCPHILPFHMP, float OMOOLKJGKCI, float NPFBBLCKOJJ, float LGABABFGBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x878C340", Offset = "0x878AB40", VA = "0x18878C340")]
	private void HAKFPBABPJC(ushort LCLOJFJPMFP, uint LHBHFAIMPOJ, float JKHKPDHHNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x878BD80", Offset = "0x878A580", VA = "0x18878BD80")]
	private float3 DNIBPPDHGHN(uint3 KNELHDAMDMM, float3 LACCKGGOPGM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x878C320", Offset = "0x878AB20", VA = "0x18878C320")]
	private float FNHOOHEJMBP(float OIJDAOIGJEM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x878B250", Offset = "0x8789A50", VA = "0x18878B250")]
	private float CDGGHJMKMFE(float3 ICIPPEHHOGO, float3 DHALCJLJEFJ, float OMOOLKJGKCI, float NPFBBLCKOJJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x878C960", Offset = "0x878B160", VA = "0x18878C960")]
	private void OOJMAHMNPFJ(int IDLEOONNFGC, ushort OFJEKAOALCF, int NJLBHIOJDLC, BPFCBKOOOAG AFEAFNINKEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FPMIALDNMJI
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class CLCLBLOBLHP
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int JIMINKFEEKJ;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int JGJFPNLGDBP;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int BNNBDLFCEIC;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int APMGHAFMIIF;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int JDHLBGOEGLD;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int CDMFGGINGAD;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int KIPKLGFELEP;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int KDLMNGIDKOB = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int GKGJFEHPNHM = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int IOIDKPOIJNP = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int BAKICJLIMJL = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int PMHNJKJJIDL = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int HCMKDAHCCCH = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int AKEJFLJFCDM = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool PDFCDOHKBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer LIMGKDEEJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture LLFECIKLOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int GGMDHGHKICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int APIIDDHHCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int JFHPLNGKIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int HECKPEFLLBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int AFPBGLLGCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader NEKNOLKBJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int LGCBKKBOCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int FHPDKHCJIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 HEDBMLLKLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 DABMIPIBOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> ADCJDHIGNDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> DNCLHHMIHLB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> PFCOBCELMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x515EAF0", Offset = "0x515D2F0", VA = "0x18515EAF0")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> CFJKKJLGHPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x11AEDA0", Offset = "0x11AD5A0", VA = "0x1811AEDA0")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int CBOJPEAKABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xCF4D80", Offset = "0xCF3580", VA = "0x180CF4D80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int IJOPMFDKIPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA32B70", Offset = "0xA31370", VA = "0x180A32B70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader FDFIGAKCPCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x878DFA0", Offset = "0x878C7A0", VA = "0x18878DFA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x878E210", Offset = "0x878CA10", VA = "0x18878E210")]
	public void JGAHMDKPFDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x878E6D0", Offset = "0x878CED0", VA = "0x18878E6D0")]
	public void MNMPDAMLMAJ(CameraData MBMMNELFKDC, LightData DCAOIJKICAG, int EINMDHBKMDK, bool NJKKOFBAKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x39D2510", Offset = "0x39D0D10", VA = "0x1839D2510")]
	private void IENPEICCDAJ<T>(NativeArray<T> LPBOBEPEKNH, int GGIJOHIPOOO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x878E300", Offset = "0x878CB00", VA = "0x18878E300")]
	public void LGFJLCEOGKD(CommandBuffer CAGFFDPMGEA, ScriptableRenderContext MJAGIMDGJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x878E030", Offset = "0x878C830", VA = "0x18878E030")]
	private static void IGLGHLMIPPA(int FICPBLPHOKD, CommandBuffer CAGFFDPMGEA, RenderBuffer FKGFINNBFKE, ComputeBuffer CMHHLNCNMNH, ComputeShader AFHBLELFNLP, int LFAOLADNPCM, int OMFJAJGLFDI, int PIJIJLKGMLN, int DJHIKIGANLP, int EKFDBNNHMOB, int OCJDCLCOHNO, int FEPKLNGMLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x878EBC0", Offset = "0x878D3C0", VA = "0x18878EBC0")]
	public void PECNGGPFGDA(CommandBuffer CAGFFDPMGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x878E9E0", Offset = "0x878D1E0", VA = "0x18878E9E0")]
	private RenderTexture NMHBOGKKAGN(RenderTexture EEJJJPIMBFO, int LFAOLADNPCM, int OMFJAJGLFDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x878E650", Offset = "0x878CE50", VA = "0x18878E650")]
	public void LMLALEPFPDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x878DD10", Offset = "0x878C510", VA = "0x18878DD10")]
	public void BMJHFLNEHCC(int HNILCDPOOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x878EED0", Offset = "0x878D6D0", VA = "0x18878EED0")]
	public FPMIALDNMJI()
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
		public struct GAFJCPOPMOI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float FCLAPIOAJNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float CHEMCGGKOAA;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class KGKOPAKPIHA : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string OGAGOBIMJPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler APMHENHPOMN;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int GDEPJLBGDDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material HINAFKHEOMI;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x878FD00", Offset = "0x878E500", VA = "0x18878FD00")]
			public KGKOPAKPIHA(RenderPassEvent GPLJMGHJPHO, Material IPKNLMFNGIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x878F930", Offset = "0x878E130", VA = "0x18878F930", Slot = "9")]
			public override void Execute(ScriptableRenderContext MJAGIMDGJBK, RenderingData HJEINGEGIBA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static GAFJCPOPMOI CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private KGKOPAKPIHA m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x87929C0", Offset = "0x87911C0", VA = "0x1887929C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8792970", Offset = "0x8791170", VA = "0x188792970")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x87927C0", Offset = "0x8790FC0", VA = "0x1887927C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x87926F0", Offset = "0x8790EF0", VA = "0x1887926F0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FKGIDFBJGGD, RenderingData HJEINGEGIBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1767B30", Offset = "0x1766330", VA = "0x181767B30")]
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
		public struct KLHMOKINFBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float MPIOFDFDFIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color HNALGLDGHPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh PIKCKOKFEGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve OKHFKODLNDN;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class ANKHJKJHJIE : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string OGAGOBIMJPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler APMHENHPOMN;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int LGFNDNLIDAL;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int EMGKBNKMINK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material HINAFKHEOMI;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8789B90", Offset = "0x8788390", VA = "0x188789B90")]
			public ANKHJKJHJIE(RenderPassEvent GPLJMGHJPHO, Material IPKNLMFNGIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x87898F0", Offset = "0x87880F0", VA = "0x1887898F0", Slot = "9")]
			public override void Execute(ScriptableRenderContext MJAGIMDGJBK, RenderingData HJEINGEGIBA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static KLHMOKINFBL CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private ANKHJKJHJIE m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x8792CD0", Offset = "0x87914D0", VA = "0x188792CD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8792B20", Offset = "0x8791320", VA = "0x188792B20", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8792A10", Offset = "0x8791210", VA = "0x188792A10", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FKGIDFBJGGD, RenderingData HJEINGEGIBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1767B30", Offset = "0x1766330", VA = "0x181767B30")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string KINCANNPMBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool MMMACHIJHNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer CAGFFDPMGEA, ScriptableRenderContext MJAGIMDGJBK, RenderingData HJEINGEGIBA);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA28D30", Offset = "0xA27530", VA = "0x180A28D30")]
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
		private class MKCDLHILJFK : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool CHHOMFDIFJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> MEBMMOPOOAE;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> PCLFBCFGBDD;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8792640", Offset = "0x8790E40", VA = "0x188792640")]
			public MKCDLHILJFK(RenderPassEvent GPLJMGHJPHO, bool CHHOMFDIFJD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x87922D0", Offset = "0x8790AD0", VA = "0x1887922D0")]
			public bool HPIMFHNOKNC(CameraData MBMMNELFKDC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8792100", Offset = "0x8790900", VA = "0x188792100", Slot = "9")]
			public override void Execute(ScriptableRenderContext MJAGIMDGJBK, RenderingData HJEINGEGIBA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8792020", Offset = "0x8790820", VA = "0x188792020")]
			private void ANPPHFEGLNG(PerCameraRenderEffect DIIHJIBLPIK, ScriptableRenderContext MJAGIMDGJBK, RenderingData HJEINGEGIBA)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private MKCDLHILJFK m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private MKCDLHILJFK m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8792E70", Offset = "0x8791670", VA = "0x188792E70", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8792DE0", Offset = "0x87915E0", VA = "0x188792DE0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FKGIDFBJGGD, RenderingData HJEINGEGIBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1767B30", Offset = "0x1766330", VA = "0x181767B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x87930C0", Offset = "0x87918C0", VA = "0x1887930C0")]
		public static void IJOCPFBMPJM(ScriptableRenderPass AAKEKAIKMGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8792F20", Offset = "0x8791720", VA = "0x188792F20", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FKGIDFBJGGD, RenderingData HJEINGEGIBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1767B30", Offset = "0x1766330", VA = "0x181767B30")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class ANOKFPHCOPI
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 KLBKAMDCFJH;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 DGCJEJDCLEA;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 PAKMGLIIPIM;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 FHACOFLDJLB;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 CIGGMLDLPHA;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x878A140", Offset = "0x8788940", VA = "0x18878A140")]
	public static uint EHGPADBEPAO(uint BDGPJOKJNIL, uint HDAFCDJNHAK, uint GJHIHKIOKLH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x878A530", Offset = "0x8788D30", VA = "0x18878A530")]
	public static uint3 IPFDFFNIEAK(float3 KKEEFCOJJFM, float3 EOCOCNJPBBL, float3 AHHPIPPHAMB)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x878A150", Offset = "0x8788950", VA = "0x18878A150")]
	public static void HBHLFKALAIF(float3 JGJMFHFGPPM, float3 CFNCNEBCDND, float3 NDKLLPCCCMN, float ANIHENNGJAL, [Out] uint3 HNJGNBEEMOB, [Out] uint3 GJLONNGOJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8789C70", Offset = "0x8788470", VA = "0x188789C70")]
	public static void ACFHFDACCGI(float3 LKNFGDDBFHH, float3 OKIOHFOEJKJ, float LGACFNJFHND, float NHACLOPHJHD, [Out] float3 IIAOCOIFEJJ, [Out] float ANIHENNGJAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x878A390", Offset = "0x8788B90", VA = "0x18878A390")]
	private static float3 INCOKEEAJME(float3 DLACNDOMFIH, float3 GBKOHMMILLC, float3 KNCFOFBOLOH, float3 EPIKDDFMIGI)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class IMEMOLOLOOD
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly BMELPJIFPCL BAHNNBOIHLB;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly BMELPJIFPCL GHOPNLJPBHB;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly BMELPJIFPCL BFLGBCAHKGD;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly BMELPJIFPCL OGKIGAKNPCA;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly BMELPJIFPCL NFFGLFOJMIM;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class MFJOIJMHOCO
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh DIJCCPKAHHB;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8791F80", Offset = "0x8790780", VA = "0x188791F80")]
	public static Mesh JPBNDIEPKJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8791AE0", Offset = "0x87902E0", VA = "0x188791AE0")]
	public static Matrix4x4 HPCFPFPPCPN(Camera KBMHMGBHCFM, bool MEMPPPKMAAG = false, bool FADMBDKMMNM = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8791720", Offset = "0x878FF20", VA = "0x188791720")]
	private static Mesh DMLFLNGAFFL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__1631202251
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x87944E0", Offset = "0x8792CE0", VA = "0x1887944E0")]
	public static void IDNJGMJBKEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x87944D0", Offset = "0x8792CD0", VA = "0x1887944D0")]
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
