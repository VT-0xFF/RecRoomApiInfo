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
	public class LogRegistrationIndex : GIIBELOIOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8549780", Offset = "0x8548180", VA = "0x188549780", Slot = "4")]
		public override void EPIAMCEAEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
		public enum HCCCBJIGDDO
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface OHKDCNJLDGK
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void FGCPOFKMMBC(ScriptableRenderContext GJIMIGJJJKI, List<Camera> KBJFNOCPKNF);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface MCIOKIFIOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void FGCPOFKMMBC(ScriptableRenderContext GJIMIGJJJKI, RenderingData KMDGJPFFLDO);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class KDFDMAJFBKL : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8546240", Offset = "0x8544C40", VA = "0x188546240")]
			public KDFDMAJFBKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x85461E0", Offset = "0x8544BE0", VA = "0x1885461E0", Slot = "9")]
			public override void Execute(ScriptableRenderContext GJIMIGJJJKI, RenderingData KMDGJPFFLDO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private KDFDMAJFBKL _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<OHKDCNJLDGK> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<OHKDCNJLDGK> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<MCIOKIFIOOJ> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<MCIOKIFIOOJ> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x854CC00", Offset = "0x854B600", VA = "0x18854CC00")]
		public static void ALJJAEOOMFC(HCCCBJIGDDO BGFNJCCFKAL, OHKDCNJLDGK OFDNNCEIDOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x854CE20", Offset = "0x854B820", VA = "0x18854CE20")]
		public static void BAGPPKECMDI(HCCCBJIGDDO BGFNJCCFKAL, OHKDCNJLDGK OFDNNCEIDOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x854CCC0", Offset = "0x854B6C0", VA = "0x18854CCC0")]
		public static void ALJJAEOOMFC(HCCCBJIGDDO BGFNJCCFKAL, MCIOKIFIOOJ MKCPPMKFODL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x854CEE0", Offset = "0x854B8E0", VA = "0x18854CEE0")]
		public static void BAGPPKECMDI(HCCCBJIGDDO BGFNJCCFKAL, MCIOKIFIOOJ MKCPPMKFODL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x854CFA0", Offset = "0x854B9A0", VA = "0x18854CFA0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x854CD80", Offset = "0x854B780", VA = "0x18854CD80", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EDDLIJIPFEO, RenderingData KMDGJPFFLDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x854D630", Offset = "0x854C030", VA = "0x18854D630", Slot = "9")]
		protected override void Dispose(bool KDBPBCNACOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x854D740", Offset = "0x854C140", VA = "0x18854D740")]
		private static void OLKDLIMKOHF(ScriptableRenderContext GJIMIGJJJKI, List<Camera> KBJFNOCPKNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x854CB90", Offset = "0x854B590", VA = "0x18854CB90")]
		private static void AEIHCKFICOP(ScriptableRenderContext GJIMIGJJJKI, List<Camera> KBJFNOCPKNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x854D180", Offset = "0x854BB80", VA = "0x18854D180")]
		private static void DECGMIFLIEH(ScriptableRenderContext GJIMIGJJJKI, RenderingData KMDGJPFFLDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x17B2C70", Offset = "0x17B1670", VA = "0x1817B2C70")]
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
		private class PLIIHBECPOP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool LKJEAKGNKBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<CNOECNGCBPJ> LJJHHNGFMPC;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x854C660", Offset = "0x854B060", VA = "0x18854C660")]
			public PLIIHBECPOP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class BNDBOIDGLIF : PreRenderManager.MCIOKIFIOOJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string BCKCPMDHGFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler EHBEKEMKDND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly PLIIHBECPOP MLBMJLDPAEI;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8543620", Offset = "0x8542020", VA = "0x188543620")]
			public BNDBOIDGLIF(PLIIHBECPOP OAHLEIIHNBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8543220", Offset = "0x8541C20", VA = "0x188543220", Slot = "4")]
			public void FGCPOFKMMBC(ScriptableRenderContext GJIMIGJJJKI, RenderingData KMDGJPFFLDO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class KGLMKEIGBPD : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string IIHKGAFKFFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly PLIIHBECPOP OAHLEIIHNBB;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8546570", Offset = "0x8544F70", VA = "0x188546570")]
			public KGLMKEIGBPD(RenderPassEvent ANLKELNPHHF, PLIIHBECPOP OAHLEIIHNBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8546260", Offset = "0x8544C60", VA = "0x188546260", Slot = "9")]
			public override void Execute(ScriptableRenderContext GJIMIGJJJKI, RenderingData KMDGJPFFLDO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<CNOECNGCBPJ> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private BNDBOIDGLIF fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private KGLMKEIGBPD fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private PLIIHBECPOP sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8544840", Offset = "0x8543240", VA = "0x188544840", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8544BC0", Offset = "0x85435C0", VA = "0x188544BC0", Slot = "9")]
		protected override void Dispose(bool KDBPBCNACOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x85447B0", Offset = "0x85431B0", VA = "0x1885447B0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EDDLIJIPFEO, RenderingData KMDGJPFFLDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x17B2C70", Offset = "0x17B1670", VA = "0x1817B2C70")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CNOECNGCBPJ
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MLOPEMAHFPI(CommandBuffer IJIPMPBLLNM, Camera HJDABGIDKHH, [NotNull] UniversalAdditionalCameraData CBMGEBKNAKM, bool NHBACHBKGPH);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PJCFHBAMFID(Camera HJDABGIDKHH, CommandBuffer FEALIBPFKFF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class OPGHKCBCBKB
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool DONPMGGCACK;
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
		private HIGFMPNILIG _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private KNCDBGNHAOH _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8549450", Offset = "0x8547E50", VA = "0x188549450", Slot = "9")]
		protected override void Dispose(bool ALIHELNOADI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x85494C0", Offset = "0x8547EC0", VA = "0x1885494C0")]
		private void HLMPDGDNDDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8549100", Offset = "0x8547B00", VA = "0x188549100", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EDDLIJIPFEO, RenderingData KMDGJPFFLDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x17B2C70", Offset = "0x17B1670", VA = "0x1817B2C70")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class EPFLKEKJDCB
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x85447A0", Offset = "0x85431A0", VA = "0x1885447A0")]
	public static int OLOJIAIJMOG(bool EGEIKNKHBLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1C36BD0", Offset = "0x1C355D0", VA = "0x181C36BD0")]
	public static int NAICOGPOBBP(bool EGEIKNKHBLI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct HEFCBEOKPEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType CEILBKDMGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float LBKALNNKMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float GMBPOMFEMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float EIJPAOHIJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 CMNPGFNEKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 FKHACBHPFBG;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct IFCLEKFIGCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort PEPIOIHBAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float GLCIACDAPAJ;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct PIKPECFDODM : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<HEFCBEOKPEL> JGJBOBDMLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 CKGJGHCEKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 MAMECJDJIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, IFCLEKFIGCJ>.ParallelWriter OOPKBGAOBMB;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x854A9A0", Offset = "0x85493A0", VA = "0x18854A9A0", Slot = "4")]
	public void Execute(int PEPIOIHBAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x854A630", Offset = "0x8549030", VA = "0x18854A630")]
	private void EJNMDCHIFHC(uint3 JJDBOKAOGHA, uint3 COLFDFEBJBB, ushort PEPIOIHBAPC, float3 JLBCGJIEEMB, float IOHBFHCJCMG, float FPKPPKJJNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x854AFD0", Offset = "0x85499D0", VA = "0x18854AFD0")]
	private void MIOMFGEMLHO(uint3 JJDBOKAOGHA, uint3 COLFDFEBJBB, ushort PEPIOIHBAPC, float3 JLBCGJIEEMB, float3 JLEILFOMLNH, float3 FOHJJIPNCAA, float IOHBFHCJCMG, float PKBILGHGPHF, float FPKPPKJJNMN, float NPKBLNIJACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x854AEE0", Offset = "0x85498E0", VA = "0x18854AEE0")]
	private float3 HPNLEABJBKN(uint3 JJDBOKAOGHA, float3 JLBCGJIEEMB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8546650", Offset = "0x8545050", VA = "0x188546650")]
	private float ABEPDMMIDHP(float LBKALNNKMKC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x85471A0", Offset = "0x8545BA0", VA = "0x1885471A0")]
	private float GKAMNBJJKNN(float3 GAOKDMHAIEB, float3 FOHJJIPNCAA, float PKBILGHGPHF, float FPKPPKJJNMN)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct EGOBMLPNNCH : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, IFCLEKFIGCJ> OOPKBGAOBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint NFKCMLDAHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int JOPGEGLPHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int GFPIPEPGLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> LOFHMFOMABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> ANGCJJDMJOL;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8544490", Offset = "0x8542E90", VA = "0x188544490", Slot = "4")]
	public void Execute(int EBKOKLJIFMN, int IPCMJKDKNBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8544630", Offset = "0x8543030", VA = "0x188544630")]
	private void PBPAHBNGBFO(int KIGGEGANINK, ushort GFHJLCICCKP, int NMKHMEBCHLE, IFCLEKFIGCJ IMIBENELCEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct AGLNIBLPDNJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, IFCLEKFIGCJ> OOPKBGAOBMB;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x85431E0", Offset = "0x8541BE0", VA = "0x1885431E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HIGFMPNILIG : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool AGFLMJEMKDH;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float BAIDCFIFCCA = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int PBINLFEDENM = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int MLOALDDJCBJ = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private PIKPECFDODM FLMADHNALHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private EGOBMLPNNCH HEOMOGFJOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private AGLNIBLPDNJ AMEFABLOIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, IFCLEKFIGCJ> PNICKINNNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private PJMDOEOMNBA IFIBKFGDJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool FOKPACPEMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int AKNMDEBKFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<HEFCBEOKPEL> ANJMKKJAMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle IJCLAEGHFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle PDNMENGKCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool NDKFKHNOEAK;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8546130", Offset = "0x8544B30", VA = "0x188546130")]
	public HIGFMPNILIG(RenderPassEvent ANLKELNPHHF, ComputeShader KMJIPBHLAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8546020", Offset = "0x8544A20", VA = "0x188546020")]
	private void GNFOHHAAMHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8545390", Offset = "0x8543D90", VA = "0x188545390")]
	public void DIINIGOBCJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3A84040", Offset = "0x3A82A40", VA = "0x183A84040")]
	public static void JFALPGBHLDA<T>(NativeArray<T> KLDOGKPLNJA, int OPKPFANIILK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8545470", Offset = "0x8543E70", VA = "0x188545470")]
	public void DMIBJCABCHI(CameraData CBMGEBKNAKM, LightData KBPMPKNMCOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8545810", Offset = "0x8544210", VA = "0x188545810")]
	private void EFFKDAHPBMJ(LightData KBPMPKNMCOD, NativeArray<HEFCBEOKPEL> PBCNABHJOMA, int DAMADCMFLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8545B50", Offset = "0x8544550", VA = "0x188545B50")]
	private void EMFJMDJPJKO(CameraData CBMGEBKNAKM, LightData KBPMPKNMCOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8545E90", Offset = "0x8544890", VA = "0x188545E90")]
	private void FGNPBBHAFIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8545270", Offset = "0x8543C70", VA = "0x188545270")]
	private void BMGHMBPNNBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8545370", Offset = "0x8543D70", VA = "0x188545370")]
	private void DABINFBGNPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8546090", Offset = "0x8544A90", VA = "0x188546090")]
	private void HKNNHBBAEGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8545D90", Offset = "0x8544790", VA = "0x188545D90", Slot = "9")]
	public override void Execute(ScriptableRenderContext GJIMIGJJJKI, RenderingData KMDGJPFFLDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x85460C0", Offset = "0x8544AC0", VA = "0x1885460C0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer FEALIBPFKFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class KNCDBGNHAOH : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort DMMPOHLPALK = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float BAIDCFIFCCA = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly PJMDOEOMNBA IFIBKFGDJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int ILFHMDDLDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private HEFCBEOKPEL[] ANJMKKJAMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 LIEKGPAAJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 MFFGKFDMBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint JBOKFECJLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int PKEAJBJHHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int IDOJJHLAFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> LOFHMFOMABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> ANGCJJDMJOL;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8548470", Offset = "0x8546E70", VA = "0x188548470")]
	public KNCDBGNHAOH(RenderPassEvent ANLKELNPHHF, ComputeShader KMJIPBHLAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x85467C0", Offset = "0x85451C0", VA = "0x1885467C0")]
	public void DMIBJCABCHI(CameraData CBMGEBKNAKM, LightData KBPMPKNMCOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x85480B0", Offset = "0x8546AB0", VA = "0x1885480B0")]
	private void OHCKDPALCME(CameraData CBMGEBKNAKM, LightData KBPMPKNMCOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x85466E0", Offset = "0x85450E0", VA = "0x1885466E0")]
	public void DIINIGOBCJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8546930", Offset = "0x8545330", VA = "0x188546930")]
	private void EFFKDAHPBMJ(LightData KBPMPKNMCOD, HEFCBEOKPEL[] PBCNABHJOMA, int DAMADCMFLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x85473D0", Offset = "0x8545DD0", VA = "0x1885473D0")]
	private void KDLGCCOLKFK(int EBKOKLJIFMN, int IPCMJKDKNBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8547170", Offset = "0x8545B70", VA = "0x188547170")]
	private void FEJEDAGNPJB(int EBKOKLJIFMN, int IMCIONKBBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8547AC0", Offset = "0x85464C0", VA = "0x188547AC0")]
	private ushort NCBOMBMGPCG(int EBKOKLJIFMN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8547260", Offset = "0x8545C60", VA = "0x188547260")]
	private void HKKIMIGKNDA(int EBKOKLJIFMN, int IPCMJKDKNBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8546670", Offset = "0x8545070", VA = "0x188546670")]
	private void COHDOHMABBH(int OPKPFANIILK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8546700", Offset = "0x8545100", VA = "0x188546700")]
	private void DIJBPGCOCPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8547090", Offset = "0x8545A90", VA = "0x188547090", Slot = "9")]
	public override void Execute(ScriptableRenderContext GJIMIGJJJKI, RenderingData KMDGJPFFLDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x85482B0", Offset = "0x8546CB0", VA = "0x1885482B0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer FEALIBPFKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8547B00", Offset = "0x8546500", VA = "0x188547B00")]
	private void OBALOCMLLEO(int PEPIOIHBAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8546C80", Offset = "0x8545680", VA = "0x188546C80")]
	private void EJNMDCHIFHC(uint3 JJDBOKAOGHA, uint3 COLFDFEBJBB, ushort PEPIOIHBAPC, float3 JLBCGJIEEMB, float IOHBFHCJCMG, float FPKPPKJJNMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8547570", Offset = "0x8545F70", VA = "0x188547570")]
	private void MIOMFGEMLHO(uint3 JJDBOKAOGHA, uint3 COLFDFEBJBB, ushort PEPIOIHBAPC, float3 JLBCGJIEEMB, float3 JLEILFOMLNH, float3 FOHJJIPNCAA, float IOHBFHCJCMG, float PKBILGHGPHF, float FPKPPKJJNMN, float NPKBLNIJACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8547480", Offset = "0x8545E80", VA = "0x188547480")]
	private void LEDAFOLNHMB(ushort PEPIOIHBAPC, uint JLJFIPJHGIK, float NKDPAPKFNCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x85472D0", Offset = "0x8545CD0", VA = "0x1885472D0")]
	private float3 HPNLEABJBKN(uint3 JJDBOKAOGHA, float3 JLBCGJIEEMB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8546650", Offset = "0x8545050", VA = "0x188546650")]
	private float ABEPDMMIDHP(float LBKALNNKMKC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x85471A0", Offset = "0x8545BA0", VA = "0x1885471A0")]
	private float GKAMNBJJKNN(float3 GAOKDMHAIEB, float3 FOHJJIPNCAA, float PKBILGHGPHF, float FPKPPKJJNMN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x85482E0", Offset = "0x8546CE0", VA = "0x1885482E0")]
	private void PBPAHBNGBFO(int KIGGEGANINK, ushort GFHJLCICCKP, int NMKHMEBCHLE, IFCLEKFIGCJ IMIBENELCEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class PJMDOEOMNBA
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class HFBLKONHEFF
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int HJFMGIJFMMF;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int LDADLHPJKAE;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int CBBJGCGBADE;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int FCBPNKDAKDO;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int BCNJGIHHNHO;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int MIJJKJKOEMN;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int PHGNFFEAGNO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int JDGDHFPMHCE = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int KNFNBGBMJGF = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int JMFOAPHEDPA = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int NFDELIKKMDC = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int MNMCDNEBFFJ = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int IIBOAJAGEPI = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int EDAEBOJIBFB = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool OOIINAPDMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer AJHAPPNGJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture NHHMOBOPBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int LBMJADFPKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int HBCOFFMDJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int AJGOIODPBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int FBDDJGHACJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int NKHLBGDMJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader EPMEEENAOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int DJDLIIEDMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int LKOJIPGKDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 GPJGOJBDNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 NPHDLKHNHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> PMKEKPHPELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> PAIFNCKHPKO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> CLBBJENCKJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x504E020", Offset = "0x504CA20", VA = "0x18504E020")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> KDOLCDBLMAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x12030F0", Offset = "0x1201AF0", VA = "0x1812030F0")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int KJBMKHGAIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA5A900", Offset = "0xA59300", VA = "0x180A5A900")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int HGMCDFJOEIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA155B0", Offset = "0xA13FB0", VA = "0x180A155B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader HCBCCEKMLMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x854BDB0", Offset = "0x854A7B0", VA = "0x18854BDB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x854BC40", Offset = "0x854A640", VA = "0x18854BC40")]
	public void IIPIKJHBJDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x854C020", Offset = "0x854AA20", VA = "0x18854C020")]
	public void PNAHAPBAHAC(CameraData CBMGEBKNAKM, LightData KBPMPKNMCOD, int DCIMFDGPKAJ, bool EGEIKNKHBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3C23790", Offset = "0x3C22190", VA = "0x183C23790")]
	private void JFALPGBHLDA<T>(NativeArray<T> KLDOGKPLNJA, int OPKPFANIILK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x854B660", Offset = "0x854A060", VA = "0x18854B660")]
	public void CHIAKCGMKNO(CommandBuffer FEALIBPFKFF, ScriptableRenderContext GJIMIGJJJKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x854B480", Offset = "0x8549E80", VA = "0x18854B480")]
	private static void ABJDCIDNMDJ(int LCIMOPGLIKA, CommandBuffer FEALIBPFKFF, RenderBuffer KLGJKFOPJKL, ComputeBuffer DBAGBKMDMLI, ComputeShader FMDKJIAKFMK, int NOEHIDGFBGF, int PEBLALFBMOG, int DHAFNNNCBKM, int JJHLKKJDDHL, int KMHHFCCONCG, int IIKLHIIAFIN, int POKDDBFFCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x854C330", Offset = "0x854AD30", VA = "0x18854C330")]
	public void POCEOIOJEJP(CommandBuffer FEALIBPFKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x854BE40", Offset = "0x854A840", VA = "0x18854BE40")]
	private RenderTexture OMJOPMPDOHA(RenderTexture BPFJIKLMEEJ, int NOEHIDGFBGF, int PEBLALFBMOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x854BD30", Offset = "0x854A730", VA = "0x18854BD30")]
	public void KJIDAGACNDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x854B9B0", Offset = "0x854A3B0", VA = "0x18854B9B0")]
	public void ECNOGOMJMAP(int HGGEGFPAKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x854C640", Offset = "0x854B040", VA = "0x18854C640")]
	public PJMDOEOMNBA()
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
		public struct INMBDLEAIOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float BLENNJFAPDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float MGLBOFLHBKL;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class EBEJHHGIDOK : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string ADMMOJCNBJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler CDONLJNOOFL;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int FEANJJLDAML;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material CLLMMDMEFGB;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x85443B0", Offset = "0x8542DB0", VA = "0x1885443B0")]
			public EBEJHHGIDOK(RenderPassEvent ANLKELNPHHF, Material NJABANIHMHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8543FE0", Offset = "0x85429E0", VA = "0x188543FE0", Slot = "9")]
			public override void Execute(ScriptableRenderContext GJIMIGJJJKI, RenderingData KMDGJPFFLDO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static INMBDLEAIOO CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private EBEJHHGIDOK m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x8549AE0", Offset = "0x85484E0", VA = "0x188549AE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8549A90", Offset = "0x8548490", VA = "0x188549A90")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x85498E0", Offset = "0x85482E0", VA = "0x1885498E0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8549810", Offset = "0x8548210", VA = "0x188549810", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EDDLIJIPFEO, RenderingData KMDGJPFFLDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x17B2C70", Offset = "0x17B1670", VA = "0x1817B2C70")]
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
		public struct IKDCCLMFGNK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float NAOFEKEFPPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color BHIODCOMABF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh ONDINAINAGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve IDNFKDPGGMG;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class HBPPFPMKIAE : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string ADMMOJCNBJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler CDONLJNOOFL;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int CGJPEEDKHFD;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int LJLPHFBOKCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material CLLMMDMEFGB;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8545050", Offset = "0x8543A50", VA = "0x188545050")]
			public HBPPFPMKIAE(RenderPassEvent ANLKELNPHHF, Material NJABANIHMHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8544DB0", Offset = "0x85437B0", VA = "0x188544DB0", Slot = "9")]
			public override void Execute(ScriptableRenderContext GJIMIGJJJKI, RenderingData KMDGJPFFLDO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static IKDCCLMFGNK CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private HBPPFPMKIAE m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x8549DF0", Offset = "0x85487F0", VA = "0x188549DF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8549C40", Offset = "0x8548640", VA = "0x188549C40", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8549B30", Offset = "0x8548530", VA = "0x188549B30", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EDDLIJIPFEO, RenderingData KMDGJPFFLDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x17B2C70", Offset = "0x17B1670", VA = "0x1817B2C70")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string CNAPGDHIFIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool JHBLEJHJJPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer FEALIBPFKFF, ScriptableRenderContext GJIMIGJJJKI, RenderingData KMDGJPFFLDO);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
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
		private class PDGEBDDNCKP : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool FPEMLFJABCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> KPAPAGBKGDE;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> DHFDJAMLMID;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x854A580", Offset = "0x8548F80", VA = "0x18854A580")]
			public PDGEBDDNCKP(RenderPassEvent ANLKELNPHHF, bool FPEMLFJABCP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x854A210", Offset = "0x8548C10", VA = "0x18854A210")]
			public bool MLDAOFMBOBO(CameraData CBMGEBKNAKM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8549F60", Offset = "0x8548960", VA = "0x188549F60", Slot = "9")]
			public override void Execute(ScriptableRenderContext GJIMIGJJJKI, RenderingData KMDGJPFFLDO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x854A130", Offset = "0x8548B30", VA = "0x18854A130")]
			private void JNFOGMIAPCK(PerCameraRenderEffect HOJJPNAAAAD, ScriptableRenderContext GJIMIGJJJKI, RenderingData KMDGJPFFLDO)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private PDGEBDDNCKP m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private PDGEBDDNCKP m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x854C780", Offset = "0x854B180", VA = "0x18854C780", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x854C6F0", Offset = "0x854B0F0", VA = "0x18854C6F0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EDDLIJIPFEO, RenderingData KMDGJPFFLDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x17B2C70", Offset = "0x17B1670", VA = "0x1817B2C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x854C9D0", Offset = "0x854B3D0", VA = "0x18854C9D0")]
		public static void FFFAFBHOKDJ(ScriptableRenderPass JLDMDFGHGBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x854C830", Offset = "0x854B230", VA = "0x18854C830", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EDDLIJIPFEO, RenderingData KMDGJPFFLDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x17B2C70", Offset = "0x17B1670", VA = "0x1817B2C70")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class LLPODHABHHJ
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 HCOHJOAMAEF;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 LMNDNJFFEPO;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 ECLFKLEMJJB;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 DJGLFJBHBBA;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 BFPIJBKLAGD;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8548520", Offset = "0x8546F20", VA = "0x188548520")]
	public static uint ACCLIELAMEP(uint CBPCNABIALH, uint CBOHEKOGGHJ, uint KJDMNPADKBF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8548770", Offset = "0x8547170", VA = "0x188548770")]
	public static uint3 KBDOONBDFEC(float3 JFMEMBGKAOB, float3 CKGJGHCEKKN, float3 MAMECJDJIKJ)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8548530", Offset = "0x8546F30", VA = "0x188548530")]
	public static void BIEMBLDAGKD(float3 BGMCOEADFJO, float3 ALBDJNEFDOP, float3 OOAHCPNKMLC, float BGJJMJPDNJC, [Out] uint3 PIBGFHPCHFA, [Out] uint3 EHIIBKNLOCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8548B00", Offset = "0x8547500", VA = "0x188548B00")]
	public static void NJIJDMNHABF(float3 ALEIODOPFMB, float3 KIGJAHHBCLE, float GMBPOMFEMOJ, float LKABBIFFEOK, [Out] float3 HIJNILBHEJP, [Out] float BGJJMJPDNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8548960", Offset = "0x8547360", VA = "0x188548960")]
	private static float3 MGKOEHOLJBB(float3 KINOMEGIBLD, float3 ILHHEKMOMJI, float3 KLCMIKJEFGC, float3 MBHFMFODPHF)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class NINFLPBMEKE
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly COJJKFBGGKB AGJFMEINKLI;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly COJJKFBGGKB JDIBEGPFKDL;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly COJJKFBGGKB FKKDLDBBACL;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly COJJKFBGGKB AMCOPBLOLAD;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly COJJKFBGGKB DIBIGJLOFCA;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class DMOIMMDDKBP
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh EHFAJDNLHCB;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8543F40", Offset = "0x8542940", VA = "0x188543F40")]
	public static Mesh OBBBJGHIHCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8543AA0", Offset = "0x85424A0", VA = "0x188543AA0")]
	public static Matrix4x4 HEDNPCILGDH(Camera HJDABGIDKHH, bool EAKFKHLPNLA = false, bool GOHPIGFCGGH = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x85436E0", Offset = "0x85420E0", VA = "0x1885436E0")]
	private static Mesh GNHEOIGGAFD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2737764351
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x854DE40", Offset = "0x854C840", VA = "0x18854DE40")]
	public static void GLFEIEJEHNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x854DE30", Offset = "0x854C830", VA = "0x18854DE30")]
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
