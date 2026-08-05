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
	public class LogRegistrationIndex : LGGBAGMLBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7D57600", Offset = "0x7D56800", VA = "0x187D57600", Slot = "4")]
		public override void COGNOIDNGPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
		public enum GNGMMPGLJMG
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface EALCAOKLHFL
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void HEELOGLJLHD(ScriptableRenderContext IBLIOEFMDMM, List<Camera> GDGCIEIFADF);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface MOHPKCHNFGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void HEELOGLJLHD(ScriptableRenderContext IBLIOEFMDMM, RenderingData INANEPDNNAA);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class EKMKNCBEKNP : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7D51830", Offset = "0x7D50A30", VA = "0x187D51830")]
			public EKMKNCBEKNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7D517D0", Offset = "0x7D509D0", VA = "0x187D517D0", Slot = "9")]
			public override void Execute(ScriptableRenderContext IBLIOEFMDMM, RenderingData INANEPDNNAA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private EKMKNCBEKNP _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<EALCAOKLHFL> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<EALCAOKLHFL> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<MOHPKCHNFGF> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<MOHPKCHNFGF> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D5A3C0", Offset = "0x7D595C0", VA = "0x187D5A3C0")]
		public static void NDLIHDPPNIG(GNGMMPGLJMG IIGLLOEBIGF, EALCAOKLHFL ECIPPJCGEJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7D5A300", Offset = "0x7D59500", VA = "0x187D5A300")]
		public static void JIFLAJKHPBB(GNGMMPGLJMG IIGLLOEBIGF, EALCAOKLHFL ECIPPJCGEJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7D5A480", Offset = "0x7D59680", VA = "0x187D5A480")]
		public static void NDLIHDPPNIG(GNGMMPGLJMG IIGLLOEBIGF, MOHPKCHNFGF HKDPPDKHIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7D5A240", Offset = "0x7D59440", VA = "0x187D5A240")]
		public static void JIFLAJKHPBB(GNGMMPGLJMG IIGLLOEBIGF, MOHPKCHNFGF HKDPPDKHIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7D59550", Offset = "0x7D58750", VA = "0x187D59550", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7D594B0", Offset = "0x7D586B0", VA = "0x187D594B0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MONNLFCGBEF, RenderingData INANEPDNNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7D59730", Offset = "0x7D58930", VA = "0x187D59730", Slot = "9")]
		protected override void Dispose(bool DHMLAKKCBNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7D59D60", Offset = "0x7D58F60", VA = "0x187D59D60")]
		private static void FBBGAECCKOI(ScriptableRenderContext IBLIOEFMDMM, List<Camera> GDGCIEIFADF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7D59CF0", Offset = "0x7D58EF0", VA = "0x187D59CF0")]
		private static void EHMKAPLGIIP(ScriptableRenderContext IBLIOEFMDMM, List<Camera> GDGCIEIFADF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7D59840", Offset = "0x7D58A40", VA = "0x187D59840")]
		private static void ECDJJBKPAJJ(ScriptableRenderContext IBLIOEFMDMM, RenderingData INANEPDNNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x149F7B0", Offset = "0x149E9B0", VA = "0x18149F7B0")]
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
		private class PMFINDPJKMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool GIPODBJNOON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<CNCBMPLOMEE> FAHOJBPKFEI;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7D58FD0", Offset = "0x7D581D0", VA = "0x187D58FD0")]
			public PMFINDPJKMH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class MABMKPDJKOE : PreRenderManager.MOHPKCHNFGF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string BMJOLAEJILB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler FMPCBBAHPHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly PMFINDPJKMH CGPCILGNAIP;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7D57A80", Offset = "0x7D56C80", VA = "0x187D57A80")]
			public MABMKPDJKOE(PMFINDPJKMH MLBOPPGPPPK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7D57690", Offset = "0x7D56890", VA = "0x187D57690", Slot = "4")]
			public void HEELOGLJLHD(ScriptableRenderContext IBLIOEFMDMM, RenderingData INANEPDNNAA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class DIJKLLGPLNF : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string JGJOGNPBHGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly PMFINDPJKMH MLBOPPGPPPK;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7D50780", Offset = "0x7D4F980", VA = "0x187D50780")]
			public DIJKLLGPLNF(RenderPassEvent CDNHPBIABBJ, PMFINDPJKMH MLBOPPGPPPK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7D50470", Offset = "0x7D4F670", VA = "0x187D50470", Slot = "9")]
			public override void Execute(ScriptableRenderContext IBLIOEFMDMM, RenderingData INANEPDNNAA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<CNCBMPLOMEE> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private MABMKPDJKOE fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private DIJKLLGPLNF fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private PMFINDPJKMH sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7D52450", Offset = "0x7D51650", VA = "0x187D52450", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7D527D0", Offset = "0x7D519D0", VA = "0x187D527D0", Slot = "9")]
		protected override void Dispose(bool DHMLAKKCBNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7D523C0", Offset = "0x7D515C0", VA = "0x187D523C0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MONNLFCGBEF, RenderingData INANEPDNNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x149F7B0", Offset = "0x149E9B0", VA = "0x18149F7B0")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CNCBMPLOMEE
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OIBEJIDLLED(CommandBuffer ABBCLAJMJIB, Camera NBEMGKCACGL, [NotNull] UniversalAdditionalCameraData PIIEJNFCGEC, bool AIKONDLKHND);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PHBBOFBLCJA(Camera NBEMGKCACGL, CommandBuffer PONKKEBLNAG);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class HFAFBCDELDK
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool NAKKKLMNKAI;
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
		private DPBFMJAHBAB _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private HMIAJPBJLGB _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7D572E0", Offset = "0x7D564E0", VA = "0x187D572E0", Slot = "9")]
		protected override void Dispose(bool MMKPAIBBMCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7D57350", Offset = "0x7D56550", VA = "0x187D57350")]
		private void FIMGGCNMLPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7D56F90", Offset = "0x7D56190", VA = "0x187D56F90", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MONNLFCGBEF, RenderingData INANEPDNNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x149F7B0", Offset = "0x149E9B0", VA = "0x18149F7B0")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NGOPJDOLGBL
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7D58170", Offset = "0x7D57370", VA = "0x187D58170")]
	public static int DEFJJMGMMGD(bool DGMNCFHJBDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x191B2C0", Offset = "0x191A4C0", VA = "0x18191B2C0")]
	public static int OBKOHIOJCOF(bool DGMNCFHJBDM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct IGJMKDCDNJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType CGPDBKMONGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float EPJNKLKILJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float GFOLFGHIKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float EMLNIGPFBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 EDMNNMJMPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 BNIEPIIBEAK;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct MDBDAANHOBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort COAGDGNIPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float CLDJIBKJJHE;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct OGCMILKFJPB : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<IGJMKDCDNJM> GNPIONKLKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 JPMJPLIOLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 KFBBBGBHDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, MDBDAANHOBD>.ParallelWriter FEENIPJGHCA;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7D58180", Offset = "0x7D57380", VA = "0x187D58180", Slot = "4")]
	public void Execute(int COAGDGNIPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7D58C60", Offset = "0x7D57E60", VA = "0x187D58C60")]
	private void PIIFGPCKPKH(uint3 HNEKEJKPBPO, uint3 MDJLGNJELAC, ushort COAGDGNIPMM, float3 PDNPKJNGKOK, float GDCDEBLBCJC, float FJONGGKJJKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7D586C0", Offset = "0x7D578C0", VA = "0x187D586C0")]
	private void HJJJFLMBAMC(uint3 HNEKEJKPBPO, uint3 MDJLGNJELAC, ushort COAGDGNIPMM, float3 PDNPKJNGKOK, float3 HJPJEDPDNIP, float3 AIMEHMPFGJO, float GDCDEBLBCJC, float DPFFAIDKHLO, float FJONGGKJJKF, float FNPCNOPLLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7D58B70", Offset = "0x7D57D70", VA = "0x187D58B70")]
	private float3 IHJNBHKBIMP(uint3 HNEKEJKPBPO, float3 PDNPKJNGKOK)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7D532B0", Offset = "0x7D524B0", VA = "0x187D532B0")]
	private float HAKKADMAOOC(float EPJNKLKILJP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7D52A70", Offset = "0x7D51C70", VA = "0x187D52A70")]
	private float BMNHPPGFNAD(float3 JLKAMHFOBKN, float3 AIMEHMPFGJO, float DPFFAIDKHLO, float FJONGGKJJKF)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct CAKDIFOMEHC : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, MDBDAANHOBD> FEENIPJGHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint EMBJNFIPGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int AGMHNFGBACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int IABHBPJKKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> HLEAJKNOBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> DEELAPGEFCK;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7D4FCB0", Offset = "0x7D4EEB0", VA = "0x187D4FCB0", Slot = "4")]
	public void Execute(int DBNNMPCHFDA, int NCLOODMICPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7D4FE50", Offset = "0x7D4F050", VA = "0x187D4FE50")]
	private void LKOOPIHMKBB(int IFIFDHEDJLI, ushort NFCLAFOPOLI, int GMNLNNIHIPO, MDBDAANHOBD PMGEGAKJCGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct JGPMJPIJCMK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, MDBDAANHOBD> FEENIPJGHCA;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7D54890", Offset = "0x7D53A90", VA = "0x187D54890", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DPBFMJAHBAB : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool EPBDOGKLINF;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float BCJLPKJKFFL = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int ICHANALNALB = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int PPJBJMECGFP = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private OGCMILKFJPB KBDGALDOLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private CAKDIFOMEHC GFAHCBAPGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private JGPMJPIJCMK DKJFOIBKPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, MDBDAANHOBD> JEAFHLPPAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private LFBGIMLBIFP GLEPAENFEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool DDPCNIFCDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int KKDEIOGNIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<IGJMKDCDNJM> ABFDDNDDHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle MGDDPAJDHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle ABIMPAIEBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool OFNKMAAAFNG;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7D51720", Offset = "0x7D50920", VA = "0x187D51720")]
	public DPBFMJAHBAB(RenderPassEvent CDNHPBIABBJ, ComputeShader KOEGCMNHABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7D51610", Offset = "0x7D50810", VA = "0x187D51610")]
	private void KCKACKIDFOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7D513A0", Offset = "0x7D505A0", VA = "0x187D513A0")]
	public void ICOPFFPDJMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x32D2020", Offset = "0x32D1220", VA = "0x1832D2020")]
	public static void DAIEANMDAAK<T>(NativeArray<T> LGLFHJLCKKH, int IAGJHPFNLHJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7D50880", Offset = "0x7D4FA80", VA = "0x187D50880")]
	public void DJEMOOMOEDA(CameraData PIIEJNFCGEC, LightData AFCHGFBCFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7D50C20", Offset = "0x7D4FE20", VA = "0x187D50C20")]
	private void DKKAHJIHNMG(LightData AFCHGFBCFGD, NativeArray<IGJMKDCDNJM> ODIIKCAPCID, int EELNPJEECCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7D51160", Offset = "0x7D50360", VA = "0x187D51160")]
	private void GHDPHFEGNMD(CameraData PIIEJNFCGEC, LightData AFCHGFBCFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7D51480", Offset = "0x7D50680", VA = "0x187D51480")]
	private void IPPNCKBMHNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7D50F60", Offset = "0x7D50160", VA = "0x187D50F60")]
	private void EFEAMLFGCLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7D50860", Offset = "0x7D4FA60", VA = "0x187D50860")]
	private void DABDHPNDNAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7D51680", Offset = "0x7D50880", VA = "0x187D51680")]
	private void LCJGOGOGHHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7D51060", Offset = "0x7D50260", VA = "0x187D51060", Slot = "9")]
	public override void Execute(ScriptableRenderContext IBLIOEFMDMM, RenderingData INANEPDNNAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7D516B0", Offset = "0x7D508B0", VA = "0x187D516B0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer PONKKEBLNAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class HMIAJPBJLGB : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort CPOFEHCFBCH = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float BCJLPKJKFFL = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly LFBGIMLBIFP GLEPAENFEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int CLOHHJPPCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private IGJMKDCDNJM[] ABFDDNDDHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 MOCMAGIDPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 OIOFLFBDPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint PBLDEOIKGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int MGCBONMGEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int EBFNHJCNEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> HLEAJKNOBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> DEELAPGEFCK;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7D547E0", Offset = "0x7D539E0", VA = "0x187D547E0")]
	public HMIAJPBJLGB(RenderPassEvent CDNHPBIABBJ, ComputeShader KOEGCMNHABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7D52CE0", Offset = "0x7D51EE0", VA = "0x187D52CE0")]
	public void DJEMOOMOEDA(CameraData PIIEJNFCGEC, LightData AFCHGFBCFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7D53FD0", Offset = "0x7D531D0", VA = "0x187D53FD0")]
	private void KHNKIIHAEJB(CameraData PIIEJNFCGEC, LightData AFCHGFBCFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7D53E40", Offset = "0x7D53040", VA = "0x187D53E40")]
	public void ICOPFFPDJMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7D52E50", Offset = "0x7D52050", VA = "0x187D52E50")]
	private void DKKAHJIHNMG(LightData AFCHGFBCFGD, IGJMKDCDNJM[] ODIIKCAPCID, int EELNPJEECCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7D529C0", Offset = "0x7D51BC0", VA = "0x187D529C0")]
	private void BLPLBPLCOMF(int DBNNMPCHFDA, int NCLOODMICPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7D531A0", Offset = "0x7D523A0", VA = "0x187D531A0")]
	private void EBKGILFIILG(int DBNNMPCHFDA, int IPBKHOJKHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7D541D0", Offset = "0x7D533D0", VA = "0x187D541D0")]
	private ushort KNFMIILAOEE(int DBNNMPCHFDA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7D53F60", Offset = "0x7D53160", VA = "0x187D53F60")]
	private void JGBMAFADPPL(int DBNNMPCHFDA, int NCLOODMICPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7D53DD0", Offset = "0x7D52FD0", VA = "0x187D53DD0")]
	private void HKIGHNJBMLP(int IAGJHPFNLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7D52B30", Offset = "0x7D51D30", VA = "0x187D52B30")]
	private void BPOAEJKLJAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7D531D0", Offset = "0x7D523D0", VA = "0x187D531D0", Slot = "9")]
	public override void Execute(ScriptableRenderContext IBLIOEFMDMM, RenderingData INANEPDNNAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7D543A0", Offset = "0x7D535A0", VA = "0x187D543A0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer PONKKEBLNAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7D532D0", Offset = "0x7D524D0", VA = "0x187D532D0")]
	private void HBKBFFHBKPJ(int COAGDGNIPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7D543D0", Offset = "0x7D535D0", VA = "0x187D543D0")]
	private void PIIFGPCKPKH(uint3 HNEKEJKPBPO, uint3 MDJLGNJELAC, ushort COAGDGNIPMM, float3 PDNPKJNGKOK, float GDCDEBLBCJC, float FJONGGKJJKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7D53880", Offset = "0x7D52A80", VA = "0x187D53880")]
	private void HJJJFLMBAMC(uint3 HNEKEJKPBPO, uint3 MDJLGNJELAC, ushort COAGDGNIPMM, float3 PDNPKJNGKOK, float3 HJPJEDPDNIP, float3 AIMEHMPFGJO, float GDCDEBLBCJC, float DPFFAIDKHLO, float FJONGGKJJKF, float FNPCNOPLLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7D52BF0", Offset = "0x7D51DF0", VA = "0x187D52BF0")]
	private void DEJKBPFNHGG(ushort COAGDGNIPMM, uint FLDHDMJHNPC, float JLABICLIPPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7D53E60", Offset = "0x7D53060", VA = "0x187D53E60")]
	private float3 IHJNBHKBIMP(uint3 HNEKEJKPBPO, float3 PDNPKJNGKOK)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7D532B0", Offset = "0x7D524B0", VA = "0x187D532B0")]
	private float HAKKADMAOOC(float EPJNKLKILJP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7D52A70", Offset = "0x7D51C70", VA = "0x187D52A70")]
	private float BMNHPPGFNAD(float3 JLKAMHFOBKN, float3 AIMEHMPFGJO, float DPFFAIDKHLO, float FJONGGKJJKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7D54210", Offset = "0x7D53410", VA = "0x187D54210")]
	private void LKOOPIHMKBB(int IFIFDHEDJLI, ushort NFCLAFOPOLI, int GMNLNNIHIPO, MDBDAANHOBD PMGEGAKJCGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class LFBGIMLBIFP
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class BFFBNNFLDOA
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int GDPNPEFNDAH;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int ABPLGIBGJPO;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int PKEHAODABJF;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int FEOALMJHKPL;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int GCLFCKMCIDJ;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int CBPFPIBALAB;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int FCKDAJJPJGP;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int BPGAKMBOIAP = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int GFLOBGADLKH = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int KCOEJMAICGP = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int LOAJHIJEDBC = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int MKKMKDODKEB = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int EBCMBKNLBEH = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int MNMFNCCBLAM = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool JLBDEGKIPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer CMLPDMNEGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture GIKPADDDAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int EEPFABPNGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int PAFJPBENFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int EEJCJILEAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int HEOFPEMNHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int CKDADFLBBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader IEIOHGOKENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int EKHHDOJPBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int HJJFKACJFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 KCBEJCCJCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 FAOHLJKCHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> PLMFCBJILNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> GGNGOCFDGIL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> JPGBDEPNPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4A25E70", Offset = "0x4A25070", VA = "0x184A25E70")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> PHLGGAHJCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xFE8DD0", Offset = "0xFE7FD0", VA = "0x180FE8DD0")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int CEIAECLFIFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xB73CD0", Offset = "0xB72ED0", VA = "0x180B73CD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int EMEKFPPPBFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x96C080", Offset = "0x96B280", VA = "0x18096C080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader DPPEBHNHPPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7D55920", Offset = "0x7D54B20", VA = "0x187D55920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7D55CC0", Offset = "0x7D54EC0", VA = "0x187D55CC0")]
	public void GNPGDFFJFNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7D56100", Offset = "0x7D55300", VA = "0x187D56100")]
	public void OMCJGJEKKGG(CameraData PIIEJNFCGEC, LightData AFCHGFBCFGD, int FGJAGOGFMBO, bool DGMNCFHJBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x35300D0", Offset = "0x352F2D0", VA = "0x1835300D0")]
	private void DAIEANMDAAK<T>(NativeArray<T> LGLFHJLCKKH, int IAGJHPFNLHJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7D55DB0", Offset = "0x7D54FB0", VA = "0x187D55DB0")]
	public void JOJCBNEMNEP(CommandBuffer PONKKEBLNAG, ScriptableRenderContext IBLIOEFMDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7D56410", Offset = "0x7D55610", VA = "0x187D56410")]
	private static void PBJPGPPIKNM(int AAKLDIJFGOO, CommandBuffer PONKKEBLNAG, RenderBuffer COBNFHPKBGE, ComputeBuffer GPOLIONNLPC, ComputeShader OGECLIHDKMK, int HOOKADLMHOF, int IAPEAKKGKCM, int EAPEEJAGGIM, int LLFKKMGOHHD, int NCKJMIEHHOG, int EADBNJBACKP, int HMAJGDEHCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7D559B0", Offset = "0x7D54BB0", VA = "0x187D559B0")]
	public void GKBNOAEDEJN(CommandBuffer PONKKEBLNAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7D554B0", Offset = "0x7D546B0", VA = "0x187D554B0")]
	private RenderTexture DFICOHGMNIC(RenderTexture JPAELILIPKE, int HOOKADLMHOF, int IAPEAKKGKCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7D565F0", Offset = "0x7D557F0", VA = "0x187D565F0")]
	public void POINPPHCNKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7D55690", Offset = "0x7D54890", VA = "0x187D55690")]
	public void FGMOEGFKAJL(int KPDIJNMKKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7D56670", Offset = "0x7D55870", VA = "0x187D56670")]
	public LFBGIMLBIFP()
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
		public struct INEALIKHAKN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float NGEDMJIMPGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float DDMNMFDHCFH;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class DFCMENOPHAC : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string EIHHAMBKBPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler ABLANBMCKIF;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int ELFKDNKHIJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material MNNODCHDLIB;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7D50390", Offset = "0x7D4F590", VA = "0x187D50390")]
			public DFCMENOPHAC(RenderPassEvent CDNHPBIABBJ, Material MDMIJJAMBMD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7D4FFC0", Offset = "0x7D4F1C0", VA = "0x187D4FFC0", Slot = "9")]
			public override void Execute(ScriptableRenderContext IBLIOEFMDMM, RenderingData INANEPDNNAA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static INEALIKHAKN CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private DFCMENOPHAC m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x7D57E10", Offset = "0x7D57010", VA = "0x187D57E10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7D57DC0", Offset = "0x7D56FC0", VA = "0x187D57DC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7D57C10", Offset = "0x7D56E10", VA = "0x187D57C10", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7D57B40", Offset = "0x7D56D40", VA = "0x187D57B40", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MONNLFCGBEF, RenderingData INANEPDNNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x149F7B0", Offset = "0x149E9B0", VA = "0x18149F7B0")]
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
		public struct BHPMIACMDNG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float FPHPIEPEHDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color IABPOPGLAJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh KGDKMIJHGIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve CIBHKMFDLAG;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class FOFNODNIHGH : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string EIHHAMBKBPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler ABLANBMCKIF;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int DMNPGFICJEA;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int ECBCPLBJMOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material MNNODCHDLIB;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7D522E0", Offset = "0x7D514E0", VA = "0x187D522E0")]
			public FOFNODNIHGH(RenderPassEvent CDNHPBIABBJ, Material MDMIJJAMBMD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7D52040", Offset = "0x7D51240", VA = "0x187D52040", Slot = "9")]
			public override void Execute(ScriptableRenderContext IBLIOEFMDMM, RenderingData INANEPDNNAA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static BHPMIACMDNG CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private FOFNODNIHGH m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x7D58120", Offset = "0x7D57320", VA = "0x187D58120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7D57F70", Offset = "0x7D57170", VA = "0x187D57F70", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7D57E60", Offset = "0x7D57060", VA = "0x187D57E60", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MONNLFCGBEF, RenderingData INANEPDNNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x149F7B0", Offset = "0x149E9B0", VA = "0x18149F7B0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string PHDMHCGFDGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool HPFIEKJMLKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer PONKKEBLNAG, ScriptableRenderContext IBLIOEFMDMM, RenderingData INANEPDNNAA);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x962DF0", Offset = "0x961FF0", VA = "0x180962DF0")]
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
		private class FMJCOGOLEHB : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool BDIOEAFGHEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> DFDDNHMFNNC;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> AIFCNKLLKBN;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7D51F90", Offset = "0x7D51190", VA = "0x187D51F90")]
			public FMJCOGOLEHB(RenderPassEvent CDNHPBIABBJ, bool BDIOEAFGHEE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7D51970", Offset = "0x7D50B70", VA = "0x187D51970")]
			public bool BLPFNDJDHHM(CameraData PIIEJNFCGEC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7D51C50", Offset = "0x7D50E50", VA = "0x187D51C50", Slot = "9")]
			public override void Execute(ScriptableRenderContext IBLIOEFMDMM, RenderingData INANEPDNNAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7D51E20", Offset = "0x7D51020", VA = "0x187D51E20")]
			private void KBKCEHBIICB(PerCameraRenderEffect NJPJLFOKFGG, ScriptableRenderContext IBLIOEFMDMM, RenderingData INANEPDNNAA)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private FMJCOGOLEHB m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private FMJCOGOLEHB m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7D590F0", Offset = "0x7D582F0", VA = "0x187D590F0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7D59060", Offset = "0x7D58260", VA = "0x187D59060", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MONNLFCGBEF, RenderingData INANEPDNNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x149F7B0", Offset = "0x149E9B0", VA = "0x18149F7B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D59340", Offset = "0x7D58540", VA = "0x187D59340")]
		public static void EGDEDLDLHIO(ScriptableRenderPass AJNJONIHLJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7D591A0", Offset = "0x7D583A0", VA = "0x187D591A0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MONNLFCGBEF, RenderingData INANEPDNNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x149F7B0", Offset = "0x149E9B0", VA = "0x18149F7B0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class JHCMDJNLIFN
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 JDPMIPDHJHG;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 FPOENDGKFNK;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 HFIPENJOMBM;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 BHMMDJPEKNK;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 KDALPOOJFEM;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7D54AC0", Offset = "0x7D53CC0", VA = "0x187D54AC0")]
	public static uint INFIIBFHMBF(uint NNDJDIFFAID, uint AMFIBFNKFFJ, uint KPKBPJANJBF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7D548D0", Offset = "0x7D53AD0", VA = "0x187D548D0")]
	public static uint3 CMCNOHKJGNP(float3 LBPAIJGCICL, float3 JPMJPLIOLLH, float3 KFBBBGBHDKF)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7D55140", Offset = "0x7D54340", VA = "0x187D55140")]
	public static void PICJBCKEAPD(float3 CNMOCJKOJFO, float3 CNHGFPJFEHO, float3 MNNGKMABPAK, float LDCGEIMNGOD, [Out] uint3 OEJIAKNHHFA, [Out] uint3 LIPNBHCLAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7D54C70", Offset = "0x7D53E70", VA = "0x187D54C70")]
	public static void NGOGCIONJNO(float3 DGJHNLJHGGA, float3 JAMCMMBOKJB, float GFOLFGHIKIM, float BDOBDOOMGLN, [Out] float3 CIAJFKHDJNB, [Out] float LDCGEIMNGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7D54AD0", Offset = "0x7D53CD0", VA = "0x187D54AD0")]
	private static float3 JENKHLOPDFJ(float3 IKLJGHADCKF, float3 KGAPDHDIKDC, float3 GNLBPPOKPKH, float3 NELMHDOMBFO)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class FGIJONFFDMH
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly PBBCGFNIILA PJONFPLKCBJ;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly PBBCGFNIILA NDAJDNONCON;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly PBBCGFNIILA DOJIABJBDGN;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly PBBCGFNIILA FHLLFENJEJD;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly PBBCGFNIILA LALIEOBAFOB;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class LHDBHKGFLIF
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh KFFFELKNIEF;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7D56EF0", Offset = "0x7D560F0", VA = "0x187D56EF0")]
	public static Mesh ODBBCDOMPGH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7D56690", Offset = "0x7D55890", VA = "0x187D56690")]
	public static Matrix4x4 ENNLONDCLNE(Camera NBEMGKCACGL, bool BOINFGAJBOP = false, bool MMIGMCFMAEG = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7D56B30", Offset = "0x7D55D30", VA = "0x187D56B30")]
	private static Mesh HNMOKKMNCOD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2021919308
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7D5A760", Offset = "0x7D59960", VA = "0x187D5A760")]
	public static void LAKKIDAJBKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7D5A750", Offset = "0x7D59950", VA = "0x187D5A750")]
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
