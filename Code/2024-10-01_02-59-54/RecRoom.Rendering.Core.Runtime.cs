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
	public class LogRegistrationIndex : OACCHOKJOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7480770", Offset = "0x747FB70", VA = "0x187480770", Slot = "4")]
		public override void PFLPBBOAAPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
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
		public enum IGDNNBNIBIB
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface LNNFMAFKKFA
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void DOPLNLJCLAM(ScriptableRenderContext JCPOMHNJOIE, List<Camera> IDJMHFJMFLI);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface LNKNNMJDEJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void DOPLNLJCLAM(ScriptableRenderContext JCPOMHNJOIE, RenderingData PMJMDFLFIHN);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class OGCFABPIDNI : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7481350", Offset = "0x7480750", VA = "0x187481350")]
			public OGCFABPIDNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x74812F0", Offset = "0x74806F0", VA = "0x1874812F0", Slot = "9")]
			public override void Execute(ScriptableRenderContext JCPOMHNJOIE, RenderingData PMJMDFLFIHN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private OGCFABPIDNI _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<LNNFMAFKKFA> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<LNNFMAFKKFA> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<LNKNNMJDEJC> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<LNKNNMJDEJC> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7482180", Offset = "0x7481580", VA = "0x187482180")]
		public static void FMMDDHJJOFI(IGDNNBNIBIB EDMHHCIIMIK, LNNFMAFKKFA KEBJEMNNNMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7482300", Offset = "0x7481700", VA = "0x187482300")]
		public static void GKHEDCKLAOE(IGDNNBNIBIB EDMHHCIIMIK, LNNFMAFKKFA KEBJEMNNNMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7482240", Offset = "0x7481640", VA = "0x187482240")]
		public static void FMMDDHJJOFI(IGDNNBNIBIB EDMHHCIIMIK, LNKNNMJDEJC LCFBDPLAJCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x74823C0", Offset = "0x74817C0", VA = "0x1874823C0")]
		public static void GKHEDCKLAOE(IGDNNBNIBIB EDMHHCIIMIK, LNKNNMJDEJC LCFBDPLAJCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7481E90", Offset = "0x7481290", VA = "0x187481E90", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7481DF0", Offset = "0x74811F0", VA = "0x187481DF0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer OEGINKHKPKI, RenderingData PMJMDFLFIHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7482070", Offset = "0x7481470", VA = "0x187482070", Slot = "9")]
		protected override void Dispose(bool BJEBDEDMAPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x74824F0", Offset = "0x74818F0", VA = "0x1874824F0")]
		private static void PFBEEEGDMNH(ScriptableRenderContext JCPOMHNJOIE, List<Camera> IDJMHFJMFLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7482480", Offset = "0x7481880", VA = "0x187482480")]
		private static void LHEBGPICOAA(ScriptableRenderContext JCPOMHNJOIE, List<Camera> IDJMHFJMFLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7481940", Offset = "0x7480D40", VA = "0x187481940")]
		private static void AMMNEFPMPLB(ScriptableRenderContext JCPOMHNJOIE, RenderingData PMJMDFLFIHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x10D3490", Offset = "0x10D2890", VA = "0x1810D3490")]
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
		private class PKELCJFJIBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool IFIIILKIPEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<DMKHKADLCBH> CENAIBBHMMK;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7481460", Offset = "0x7480860", VA = "0x187481460")]
			public PKELCJFJIBL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class GLNFIFBBLEG : PreRenderManager.LNKNNMJDEJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string PLJFLLFEBJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler OIMGHIKOMMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly PKELCJFJIBL CCBOGHMKMGO;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x747C640", Offset = "0x747BA40", VA = "0x18747C640")]
			public GLNFIFBBLEG(PKELCJFJIBL POFILOCGPGL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x747C250", Offset = "0x747B650", VA = "0x18747C250", Slot = "4")]
			public void DOPLNLJCLAM(ScriptableRenderContext JCPOMHNJOIE, RenderingData PMJMDFLFIHN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class GPBPGHPFJPJ : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string BFJJEBJKACB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly PKELCJFJIBL POFILOCGPGL;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x747CA10", Offset = "0x747BE10", VA = "0x18747CA10")]
			public GPBPGHPFJPJ(RenderPassEvent PAMPKMKNLHB, PKELCJFJIBL POFILOCGPGL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x747C700", Offset = "0x747BB00", VA = "0x18747C700", Slot = "9")]
			public override void Execute(ScriptableRenderContext JCPOMHNJOIE, RenderingData PMJMDFLFIHN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<DMKHKADLCBH> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private GLNFIFBBLEG fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private GPBPGHPFJPJ fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private PKELCJFJIBL sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x747BCE0", Offset = "0x747B0E0", VA = "0x18747BCE0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x747C060", Offset = "0x747B460", VA = "0x18747C060", Slot = "9")]
		protected override void Dispose(bool BJEBDEDMAPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x747BC50", Offset = "0x747B050", VA = "0x18747BC50", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer OEGINKHKPKI, RenderingData PMJMDFLFIHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x10D3490", Offset = "0x10D2890", VA = "0x1810D3490")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DMKHKADLCBH
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BKOGOPNCABB(CommandBuffer GPJDMMNCCKD, Camera HOFAFOENMKG, [NotNull] UniversalAdditionalCameraData OGEOKEONIBJ, bool DOFPOALOGJM);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LKFHFCJMEEO(Camera HOFAFOENMKG, CommandBuffer ALAHKFHHBDO);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class NBBEKICCHJA
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool ECLANPBJELG;
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
		private LKHFGIDDLII _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private EOILHDIBEJP _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7480700", Offset = "0x747FB00", VA = "0x187480700", Slot = "9")]
		protected override void Dispose(bool GOMHCFMDIOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7480100", Offset = "0x747F500", VA = "0x187480100")]
		private void ABCBIIPDHNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x74803B0", Offset = "0x747F7B0", VA = "0x1874803B0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer OEGINKHKPKI, RenderingData PMJMDFLFIHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x10D3490", Offset = "0x10D2890", VA = "0x1810D3490")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FCGIHKEJKEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x747BC40", Offset = "0x747B040", VA = "0x18747BC40")]
	public static int GIOIJDPELCH(bool BLNEJIMLLPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x151C320", Offset = "0x151B720", VA = "0x18151C320")]
	public static int GLJDMNJLBFB(bool BLNEJIMLLPC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct NOAPLCJPCPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType FHLHGKHDGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float IMGBBOJHIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float JBJDGFHGGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float FMANBEJIJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 FOCMFKLAELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 IGJDBKPNOMN;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct ECIIPOFEDLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort OIMAMIOCDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float EFDFNNELGGA;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct BNOJPCMKOMM : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<NOAPLCJPCPA> KDOLBPPOCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 EIAGIHIHEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 PBFCKDHPMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, ECIIPOFEDLJ>.ParallelWriter CDOOPFDGAEK;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7478430", Offset = "0x7477830", VA = "0x187478430", Slot = "4")]
	public void Execute(int OIMAMIOCDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7478EE0", Offset = "0x74782E0", VA = "0x187478EE0")]
	private void IGGBJJJGIKE(uint3 MCBEABJNMPJ, uint3 EAMHBEJGCNI, ushort OIMAMIOCDEG, float3 EGLFMOBAPFJ, float NHGEFKJNEEJ, float OFHIHPMEBBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7478970", Offset = "0x7477D70", VA = "0x187478970")]
	private void GDKBEFOPGBK(uint3 MCBEABJNMPJ, uint3 EAMHBEJGCNI, ushort OIMAMIOCDEG, float3 EGLFMOBAPFJ, float3 BEECPBLCPDI, float3 IMMPHOKDIHA, float NHGEFKJNEEJ, float AKJIPHDACHC, float OFHIHPMEBBC, float OLIEAAKMMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7478340", Offset = "0x7477740", VA = "0x187478340")]
	private float3 CPKFIOLNGOD(uint3 MCBEABJNMPJ, float3 EGLFMOBAPFJ)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7479250", Offset = "0x7478650", VA = "0x187479250")]
	private float NDKHPOMCICM(float IMGBBOJHIMJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7478E20", Offset = "0x7478220", VA = "0x187478E20")]
	private float GOOEPLODIIF(float3 GHHMBPOIFDB, float3 IMMPHOKDIHA, float AKJIPHDACHC, float OFHIHPMEBBC)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct BBNJPKIKOML : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, ECIIPOFEDLJ> CDOOPFDGAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint ENILHIJEDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int GDAHGCOAILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int IFHDAGJIEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> FPOBPMDFDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> GCCEILHBBPK;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x74781A0", Offset = "0x74775A0", VA = "0x1874781A0", Slot = "4")]
	public void Execute(int ACMONGLDKFL, int MNHOAFHOIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7478030", Offset = "0x7477430", VA = "0x187478030")]
	private void DOOAEMGIGIN(int FCNHPKPDAEM, ushort IFMPOCHEJLC, int BBNLBCPIFAN, ECIIPOFEDLJ ONGEMLOKMMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct IOCDCNMIEMG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, ECIIPOFEDLJ> CDOOPFDGAEK;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x747D1C0", Offset = "0x747C5C0", VA = "0x18747D1C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LKHFGIDDLII : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool IKNPADGCHOJ;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float AAFGIPGMOGH = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int NPAFBCPHCEI = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int FPCMECIEAGJ = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private BNOJPCMKOMM AAHLBMJCADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private BBNJPKIKOML BEFKGFFBOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private IOCDCNMIEMG OIOANGMBKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, ECIIPOFEDLJ> MIIKBGJOPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private JBGGIHCODLL GCIEDOHIAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool BIMFHGINLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int MLLFMHBNIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<NOAPLCJPCPA> BGBEEPHJCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle DIEILMNGDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle KKEEHCINKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool FALKOIJLIPM;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7480050", Offset = "0x747F450", VA = "0x187480050")]
	public LKHFGIDDLII(RenderPassEvent PAMPKMKNLHB, ComputeShader DPGIAGJOONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x747F530", Offset = "0x747E930", VA = "0x18747F530")]
	private void ANMBBGKNKOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x747F730", Offset = "0x747EB30", VA = "0x18747F730")]
	public void EAPONMAICOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2F39430", Offset = "0x2F38830", VA = "0x182F39430")]
	public static void JPPJFEDOMCK<T>(NativeArray<T> AFBDFGIDJPF, int MFKKELONDCC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x747F190", Offset = "0x747E590", VA = "0x18747F190")]
	public void AGOOJCAOBEG(CameraData OGEOKEONIBJ, LightData DJKLMMEIINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x747FA10", Offset = "0x747EE10", VA = "0x18747FA10")]
	private void GFGDLGBJPML(LightData DJKLMMEIINB, NativeArray<NOAPLCJPCPA> CHKJKNPKCJM, int JOBNPMNNPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x747FDA0", Offset = "0x747F1A0", VA = "0x18747FDA0")]
	private void LAPOLBJEGCB(CameraData OGEOKEONIBJ, LightData DJKLMMEIINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x747F5A0", Offset = "0x747E9A0", VA = "0x18747F5A0")]
	private void BIJEPFJGLMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x747F810", Offset = "0x747EC10", VA = "0x18747F810")]
	private void EIFLONJLOBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x747FD80", Offset = "0x747F180", VA = "0x18747FD80")]
	private void KPEGGBOICOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x747FD50", Offset = "0x747F150", VA = "0x18747FD50")]
	private void KDNFKOJIIFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x747F910", Offset = "0x747ED10", VA = "0x18747F910", Slot = "9")]
	public override void Execute(ScriptableRenderContext JCPOMHNJOIE, RenderingData PMJMDFLFIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x747FFE0", Offset = "0x747F3E0", VA = "0x18747FFE0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer ALAHKFHHBDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class EOILHDIBEJP : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort AAPMKLLDHKC = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float AAFGIPGMOGH = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly JBGGIHCODLL GCIEDOHIAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int CPPMCDIBNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private NOAPLCJPCPA[] BGBEEPHJCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 KKDKGHMNOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 CPBEALPPGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint ECHLMNIMNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int BNEDFNICILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int BCHPALPLODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> FPOBPMDFDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> GCCEILHBBPK;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x747BB90", Offset = "0x747AF90", VA = "0x18747BB90")]
	public EOILHDIBEJP(RenderPassEvent PAMPKMKNLHB, ComputeShader DPGIAGJOONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7479E50", Offset = "0x7479250", VA = "0x187479E50")]
	public void AGOOJCAOBEG(CameraData OGEOKEONIBJ, LightData DJKLMMEIINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x747B960", Offset = "0x747AD60", VA = "0x18747B960")]
	private void KFJHNBOFPLK(CameraData OGEOKEONIBJ, LightData DJKLMMEIINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x747A450", Offset = "0x7479850", VA = "0x18747A450")]
	public void EAPONMAICOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x747B140", Offset = "0x747A540", VA = "0x18747B140")]
	private void GFGDLGBJPML(LightData DJKLMMEIINB, NOAPLCJPCPA[] CHKJKNPKCJM, int JOBNPMNNPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7479FC0", Offset = "0x74793C0", VA = "0x187479FC0")]
	private void BHNJEBDBGKL(int ACMONGLDKFL, int MNHOAFHOIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x747A290", Offset = "0x7479690", VA = "0x18747A290")]
	private void DGOBLJOIOOP(int ACMONGLDKFL, int MGEMHICLKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x747A0E0", Offset = "0x74794E0", VA = "0x18747A0E0")]
	private ushort CPGKLIDBIEL(int ACMONGLDKFL)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x747A220", Offset = "0x7479620", VA = "0x18747A220")]
	private void DCPBHDDKDJN(int ACMONGLDKFL, int MNHOAFHOIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x747A070", Offset = "0x7479470", VA = "0x18747A070")]
	private void BKALGCGBLPJ(int MFKKELONDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x747B490", Offset = "0x747A890", VA = "0x18747B490")]
	private void HKODGFKJNFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x747A560", Offset = "0x7479960", VA = "0x18747A560", Slot = "9")]
	public override void Execute(ScriptableRenderContext JCPOMHNJOIE, RenderingData PMJMDFLFIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x747BB60", Offset = "0x747AF60", VA = "0x18747BB60", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer ALAHKFHHBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x747A640", Offset = "0x7479A40", VA = "0x18747A640")]
	private void FJLAMJIMBMM(int OIMAMIOCDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x747B550", Offset = "0x747A950", VA = "0x18747B550")]
	private void IGGBJJJGIKE(uint3 MCBEABJNMPJ, uint3 EAMHBEJGCNI, ushort OIMAMIOCDEG, float3 EGLFMOBAPFJ, float NHGEFKJNEEJ, float OFHIHPMEBBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x747ABF0", Offset = "0x7479FF0", VA = "0x18747ABF0")]
	private void GDKBEFOPGBK(uint3 MCBEABJNMPJ, uint3 EAMHBEJGCNI, ushort OIMAMIOCDEG, float3 EGLFMOBAPFJ, float3 BEECPBLCPDI, float3 IMMPHOKDIHA, float NHGEFKJNEEJ, float AKJIPHDACHC, float OFHIHPMEBBC, float OLIEAAKMMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x747A470", Offset = "0x7479870", VA = "0x18747A470")]
	private void EPOPIAPPFAO(ushort OIMAMIOCDEG, uint IIEJLDHNPFH, float GJOPJAHNIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x747A120", Offset = "0x7479520", VA = "0x18747A120")]
	private float3 CPKFIOLNGOD(uint3 MCBEABJNMPJ, float3 EGLFMOBAPFJ)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7479250", Offset = "0x7478650", VA = "0x187479250")]
	private float NDKHPOMCICM(float IMGBBOJHIMJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7478E20", Offset = "0x7478220", VA = "0x187478E20")]
	private float GOOEPLODIIF(float3 GHHMBPOIFDB, float3 IMMPHOKDIHA, float AKJIPHDACHC, float OFHIHPMEBBC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x747A2C0", Offset = "0x74796C0", VA = "0x18747A2C0")]
	private void DOOAEMGIGIN(int FCNHPKPDAEM, ushort IFMPOCHEJLC, int BBNLBCPIFAN, ECIIPOFEDLJ ONGEMLOKMMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class JBGGIHCODLL
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class MODEOCILNFK
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int OONKMMJEHED;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int KGLLJPKJEAO;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int EKOICFJJLHG;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int HEDDLCGJJNI;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int MLENNBKAIMP;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int KEBOELIBOLA;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int DNAEBMOAINK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int OMBKMOLNKHH = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int OOJIBIFPPEG = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int KFKFHBECHDN = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int BPMINKJLODL = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int NHOFEHIFICI = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int KDPLPKGDDHB = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int EEDMDAKKJJJ = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool HKCILJNDGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer JJHFDLGEIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture LMDBGLDNMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int IGLLIMPGIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int CEMOEHAFKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int ILGBEFLBEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int CHAEMJBALEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int NCEIACLJAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader NIPAKAABHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int FPEODDGCGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int HBOLGKNCGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 NHEGEFHFMGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 OMGEMJOMPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> BMBELOBLGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> DECPOHDDANH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> MLNCLGPHGNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x137E1F0", Offset = "0x137D5F0", VA = "0x18137E1F0")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> EFOMIPKBJFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x18B4A80", Offset = "0x18B3E80", VA = "0x1818B4A80")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int EENDCCPNLCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xC20730", Offset = "0xC1FB30", VA = "0x180C20730")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NGDODFPPGJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8AEC60", Offset = "0x8AE060", VA = "0x1808AEC60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader JHAIOPIEODE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x747D460", Offset = "0x747C860", VA = "0x18747D460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x747D9E0", Offset = "0x747CDE0", VA = "0x18747D9E0")]
	public void KMANLEPJEHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x747D6D0", Offset = "0x747CAD0", VA = "0x18747D6D0")]
	public void JNLKALNGOPP(CameraData OGEOKEONIBJ, LightData DJKLMMEIINB, int HEPHJGHBCAA, bool BLNEJIMLLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2ECBA10", Offset = "0x2ECAE10", VA = "0x182ECBA10")]
	private void JPPJFEDOMCK<T>(NativeArray<T> AFBDFGIDJPF, int MFKKELONDCC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x747E070", Offset = "0x747D470", VA = "0x18747E070")]
	public void PBHKPGHPLCB(CommandBuffer ALAHKFHHBDO, ScriptableRenderContext JCPOMHNJOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x747D200", Offset = "0x747C600", VA = "0x18747D200")]
	private static void BEBGJJNDPLF(int MGDOKOHHFFG, CommandBuffer ALAHKFHHBDO, RenderBuffer DENDMLAGGGD, ComputeBuffer KMJJKAPBMJP, ComputeShader CKBPGFNLCLP, int ICBIGBPNBOG, int ILNNAOHDIJB, int CIFADBKMPPE, int EDDCMMLOBMK, int OINNDAFJOIE, int DGIJCLNFMLP, int IOCALJAEJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x747DD60", Offset = "0x747D160", VA = "0x18747DD60")]
	public void LFPEJMNHOOB(CommandBuffer ALAHKFHHBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x747D4F0", Offset = "0x747C8F0", VA = "0x18747D4F0")]
	private RenderTexture JNBBPFKMCCH(RenderTexture ECPMPGKJGKC, int ICBIGBPNBOG, int ILNNAOHDIJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x747D3E0", Offset = "0x747C7E0", VA = "0x18747D3E0")]
	public void EBKCNFAKJII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x747DAD0", Offset = "0x747CED0", VA = "0x18747DAD0")]
	public void KOHPGAHDJCD(int CGCMGIJJIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x747E3C0", Offset = "0x747D7C0", VA = "0x18747E3C0")]
	public JBGGIHCODLL()
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
		public struct ODDMFJHCFHC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float HJGMJKDCBPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float KCNILMLLPCF;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class LCAKOONOLCK : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string JPBHCILACOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler PBPPENCOAPD;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int HHIJMEGMJPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material PKNGPFFMNGO;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x747F0B0", Offset = "0x747E4B0", VA = "0x18747F0B0")]
			public LCAKOONOLCK(RenderPassEvent PAMPKMKNLHB, Material LBOPCEJDNFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x747ECE0", Offset = "0x747E0E0", VA = "0x18747ECE0", Slot = "9")]
			public override void Execute(ScriptableRenderContext JCPOMHNJOIE, RenderingData PMJMDFLFIHN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static ODDMFJHCFHC CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private LCAKOONOLCK m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x7480C10", Offset = "0x7480010", VA = "0x187480C10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7480BC0", Offset = "0x747FFC0", VA = "0x187480BC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7480A10", Offset = "0x747FE10", VA = "0x187480A10", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7480940", Offset = "0x747FD40", VA = "0x187480940", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer OEGINKHKPKI, RenderingData PMJMDFLFIHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x10D3490", Offset = "0x10D2890", VA = "0x1810D3490")]
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
		public struct HHAGCDNGHFP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float IPDMKKEOOBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color OICAILFLOBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh BBCPLANGEEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve KMMNKGFAMJP;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class NPEFGGFPFPH : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string JPBHCILACOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler PBPPENCOAPD;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int ABJIDNGIEPC;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int NENCJIFEOGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material PKNGPFFMNGO;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7481210", Offset = "0x7480610", VA = "0x187481210")]
			public NPEFGGFPFPH(RenderPassEvent PAMPKMKNLHB, Material LBOPCEJDNFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7480F70", Offset = "0x7480370", VA = "0x187480F70", Slot = "9")]
			public override void Execute(ScriptableRenderContext JCPOMHNJOIE, RenderingData PMJMDFLFIHN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static HHAGCDNGHFP CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private NPEFGGFPFPH m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x7480F20", Offset = "0x7480320", VA = "0x187480F20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7480D70", Offset = "0x7480170", VA = "0x187480D70", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7480C60", Offset = "0x7480060", VA = "0x187480C60", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer OEGINKHKPKI, RenderingData PMJMDFLFIHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x10D3490", Offset = "0x10D2890", VA = "0x1810D3490")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string LHLMAKHHFGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool GIOPKFICBNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer ALAHKFHHBDO, ScriptableRenderContext JCPOMHNJOIE, RenderingData PMJMDFLFIHN);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
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
		private class HMLHOAIMMIP : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool DPHLMLNPGHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> LKLIDCPFIHP;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> GBIJOFMHAMO;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x747D110", Offset = "0x747C510", VA = "0x18747D110")]
			public HMLHOAIMMIP(RenderPassEvent PAMPKMKNLHB, bool DPHLMLNPGHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x747CDA0", Offset = "0x747C1A0", VA = "0x18747CDA0")]
			public bool MOEMEFJEFDG(CameraData OGEOKEONIBJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x747CAF0", Offset = "0x747BEF0", VA = "0x18747CAF0", Slot = "9")]
			public override void Execute(ScriptableRenderContext JCPOMHNJOIE, RenderingData PMJMDFLFIHN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x747CCC0", Offset = "0x747C0C0", VA = "0x18747CCC0")]
			private void GBBIJHAJPJF(PerCameraRenderEffect DOPNKJOIOPP, ScriptableRenderContext JCPOMHNJOIE, RenderingData PMJMDFLFIHN)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private HMLHOAIMMIP m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private HMLHOAIMMIP m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7481580", Offset = "0x7480980", VA = "0x187481580", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x74814F0", Offset = "0x74808F0", VA = "0x1874814F0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer OEGINKHKPKI, RenderingData PMJMDFLFIHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x10D3490", Offset = "0x10D2890", VA = "0x1810D3490")]
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
		[Cpp2IlInjected.Address(RVA = "0x74817D0", Offset = "0x7480BD0", VA = "0x1874817D0")]
		public static void CCMJKGIDNCK(ScriptableRenderPass HCNMCHHOEON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7481630", Offset = "0x7480A30", VA = "0x187481630", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer OEGINKHKPKI, RenderingData PMJMDFLFIHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x10D3490", Offset = "0x10D2890", VA = "0x1810D3490")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class CBKPACKPDGA
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 CPENHLDJPNM;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 JPICELHNGAE;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 JDGGCBDHDEJ;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 LOAKCDFNFEI;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 AGDJNMELOFC;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7479600", Offset = "0x7478A00", VA = "0x187479600")]
	public static uint KPLLLJCMLAO(uint CFANGCOBGCF, uint HHLCHNICLGA, uint CLBJBMGHOBK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7479410", Offset = "0x7478810", VA = "0x187479410")]
	public static uint3 IGGDIEEADIB(float3 MBJNFCDOKCE, float3 EIAGIHIHEMA, float3 PBFCKDHPMJM)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7479610", Offset = "0x7478A10", VA = "0x187479610")]
	public static void LDOCFIKHDMH(float3 AKNLEOKEFOD, float3 PNCFEOJGIBI, float3 OGMDPMDFCEJ, float MINBCCGNENH, [Out] uint3 LADHHOOACPI, [Out] uint3 EHKHCAJAPOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7479850", Offset = "0x7478C50", VA = "0x187479850")]
	public static void NBDCPIEPMDN(float3 DIEJCODMOCN, float3 FGFGFBDIIHM, float JBJDGFHGGAA, float EDBGGPCEOPG, [Out] float3 PGEKNODKOLA, [Out] float MINBCCGNENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7479270", Offset = "0x7478670", VA = "0x187479270")]
	private static float3 FIEKMPBPJHJ(float3 OFJJEJJFMGG, float3 LBJJKNHJFDG, float3 MKGAFOLPNFO, float3 CDDOBEHEEFA)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class OIPJBEAKLJJ
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly EGGMDNJPOBA LDNFLJCPGEA;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly EGGMDNJPOBA MMMEBMCMMCE;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly EGGMDNJPOBA ALMOIAFKGOA;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly EGGMDNJPOBA OOBDPIKKEJM;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class KLDBBMOMPBC
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static Mesh CMKMHKBLBFF;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x747E3E0", Offset = "0x747D7E0", VA = "0x18747E3E0")]
	public static Mesh GIFENDMNOGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x747E480", Offset = "0x747D880", VA = "0x18747E480")]
	public static Matrix4x4 NKOLNANDGMA(Camera HOFAFOENMKG, bool CEKAGJFLNAM = false, bool FOMAHDIHPDP = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x747E920", Offset = "0x747DD20", VA = "0x18747E920")]
	private static Mesh PAEBFJCLJME()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3906515218
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7482BF0", Offset = "0x7481FF0", VA = "0x187482BF0")]
	public static void OCOPPMEBFOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7482BE0", Offset = "0x7481FE0", VA = "0x187482BE0")]
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
