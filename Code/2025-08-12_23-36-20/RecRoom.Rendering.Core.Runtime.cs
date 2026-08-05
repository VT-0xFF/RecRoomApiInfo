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
	public class LogRegistrationIndex : GDJKPKDCEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD750", Offset = "0x8BBC550", VA = "0x188BBD750", Slot = "4")]
		public override void FAIIODDINIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		public enum HLKPKJLLOFH
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface IJFBIDHKDKO
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void NACBKBJFHJC(ScriptableRenderContext KKBNGKDBMPF, List<Camera> EMBBDGPFNAO);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface MEMELBCJKND
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void NACBKBJFHJC(ScriptableRenderContext KKBNGKDBMPF, RenderingData FPGBMCNDEDB);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class BCFAFIODMIO : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8BB83C0", Offset = "0x8BB71C0", VA = "0x188BB83C0")]
			public BCFAFIODMIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8BB8360", Offset = "0x8BB7160", VA = "0x188BB8360", Slot = "9")]
			public override void Execute(ScriptableRenderContext KKBNGKDBMPF, RenderingData FPGBMCNDEDB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private BCFAFIODMIO _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<IJFBIDHKDKO> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<IJFBIDHKDKO> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<MEMELBCJKND> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<MEMELBCJKND> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8BC2BE0", Offset = "0x8BC19E0", VA = "0x188BC2BE0")]
		public static void OGCKHMAOIFN(HLKPKJLLOFH AJILHLCPDLJ, IJFBIDHKDKO PJPFENFICFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8BC1D20", Offset = "0x8BC0B20", VA = "0x188BC1D20")]
		public static void ABNKMGCGHPE(HLKPKJLLOFH AJILHLCPDLJ, IJFBIDHKDKO PJPFENFICFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8BC2CA0", Offset = "0x8BC1AA0", VA = "0x188BC2CA0")]
		public static void OGCKHMAOIFN(HLKPKJLLOFH AJILHLCPDLJ, MEMELBCJKND HMLHDFHPEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8BC1DE0", Offset = "0x8BC0BE0", VA = "0x188BC1DE0")]
		public static void ABNKMGCGHPE(HLKPKJLLOFH AJILHLCPDLJ, MEMELBCJKND HMLHDFHPEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8BC1F40", Offset = "0x8BC0D40", VA = "0x188BC1F40", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8BC1EA0", Offset = "0x8BC0CA0", VA = "0x188BC1EA0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer NNEJGKAIJNN, RenderingData FPGBMCNDEDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8BC2120", Offset = "0x8BC0F20", VA = "0x188BC2120", Slot = "9")]
		protected override void Dispose(bool FLPNGMCKDML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8BC26F0", Offset = "0x8BC14F0", VA = "0x188BC26F0")]
		private static void MIDICHBPKCD(ScriptableRenderContext KKBNGKDBMPF, List<Camera> EMBBDGPFNAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8BC1CB0", Offset = "0x8BC0AB0", VA = "0x188BC1CB0")]
		private static void AAFKFHDNDMH(ScriptableRenderContext KKBNGKDBMPF, List<Camera> EMBBDGPFNAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8BC2230", Offset = "0x8BC1030", VA = "0x188BC2230")]
		private static void HMHLHOCEMMO(ScriptableRenderContext KKBNGKDBMPF, RenderingData FPGBMCNDEDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x194FC90", Offset = "0x194EA90", VA = "0x18194FC90")]
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
		private class LMCCCGLCHPH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool OLHAGLIIMIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<NCOMJGLKAKB> GPHNPHIIBEN;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8BBD040", Offset = "0x8BBBE40", VA = "0x188BBD040")]
			public LMCCCGLCHPH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class OCNPAEAFKGB : PreRenderManager.MEMELBCJKND
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string NNPKILLLAPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler MAJBGGJMHID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly LMCCCGLCHPH IGEFMCDJCJK;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8BC17A0", Offset = "0x8BC05A0", VA = "0x188BC17A0")]
			public OCNPAEAFKGB(LMCCCGLCHPH MPCMBFOHBKD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8BC13A0", Offset = "0x8BC01A0", VA = "0x188BC13A0", Slot = "4")]
			public void NACBKBJFHJC(ScriptableRenderContext KKBNGKDBMPF, RenderingData FPGBMCNDEDB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class NIHCCOMACGO : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string EKBPGOHGFDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly LMCCCGLCHPH MPCMBFOHBKD;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8BC0F70", Offset = "0x8BBFD70", VA = "0x188BC0F70")]
			public NIHCCOMACGO(RenderPassEvent IHIEAJGNFHC, LMCCCGLCHPH MPCMBFOHBKD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8BC0C60", Offset = "0x8BBFA60", VA = "0x188BC0C60", Slot = "9")]
			public override void Execute(ScriptableRenderContext KKBNGKDBMPF, RenderingData FPGBMCNDEDB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<NCOMJGLKAKB> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private OCNPAEAFKGB fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private NIHCCOMACGO fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private LMCCCGLCHPH sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8BBAD80", Offset = "0x8BB9B80", VA = "0x188BBAD80", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8BBB100", Offset = "0x8BB9F00", VA = "0x188BBB100", Slot = "9")]
		protected override void Dispose(bool FLPNGMCKDML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8BBACF0", Offset = "0x8BB9AF0", VA = "0x188BBACF0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer NNEJGKAIJNN, RenderingData FPGBMCNDEDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x194FC90", Offset = "0x194EA90", VA = "0x18194FC90")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NCOMJGLKAKB
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EIKPGMJJGIO(CommandBuffer HMHDMNJMLBL, Camera HOHEOKHPGEK, [NotNull] UniversalAdditionalCameraData HPEIEBCJMAM, bool HGFMLGOGIDM);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EFAEIEGIIAF(Camera HOHEOKHPGEK, CommandBuffer ELOEPMLDMON);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class DGECNMPAKDA
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool BIOBGDGCDOC;
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
		private NAEJJJLLKEK _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private DAKKMBHJAKE _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD420", Offset = "0x8BBC220", VA = "0x188BBD420", Slot = "9")]
		protected override void Dispose(bool GEBDGLCNGJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD490", Offset = "0x8BBC290", VA = "0x188BBD490")]
		private void IOIKGGFGNKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD0D0", Offset = "0x8BBBED0", VA = "0x188BBD0D0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer NNEJGKAIJNN, RenderingData FPGBMCNDEDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x194FC90", Offset = "0x194EA90", VA = "0x18194FC90")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BBNBPCBMBKO
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8BB8350", Offset = "0x8BB7150", VA = "0x188BB8350")]
	public static int NPJKILADHHB(bool PMHOALAGGIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1DF3BD0", Offset = "0x1DF29D0", VA = "0x181DF3BD0")]
	public static int KIOECPLJAMG(bool PMHOALAGGIP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct IIGDIHHKLBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType CECBLBJCMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float OBAPPOPHCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float JBEBIIPBGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float MEKNKGMPIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 OMNNNJMPPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 CFBNHKEEHKP;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct PGPPEDEDCKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort FBOLHDBJGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float DMLINFLHNCC;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct KLKPFEJCOIJ : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<IIGDIHHKLBC> BBOKFBDGLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 ICFONLNJAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 NDHGENMDJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, PGPPEDEDCKA>.ParallelWriter LCNBEDKDHON;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8BBB9C0", Offset = "0x8BBA7C0", VA = "0x188BBB9C0", Slot = "4")]
	public void Execute(int FBOLHDBJGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8BBBF00", Offset = "0x8BBAD00", VA = "0x188BBBF00")]
	private void FEMIALCCJMI(uint3 EKKEIIKBKFL, uint3 LCNGLAJAAPE, ushort FBOLHDBJGLC, float3 PMMBALOFMIB, float JMHAAJMJDLJ, float EPNOGKHJIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8BBC360", Offset = "0x8BBB160", VA = "0x188BBC360")]
	private void MCLAHIAHEMO(uint3 EKKEIIKBKFL, uint3 LCNGLAJAAPE, ushort FBOLHDBJGLC, float3 PMMBALOFMIB, float3 AABDLMBPIGO, float3 FMCNLJEFHJN, float JMHAAJMJDLJ, float BNJMNFAHCMH, float EPNOGKHJIBH, float GANFLGHNGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8BBC270", Offset = "0x8BBB070", VA = "0x188BBC270")]
	private float3 JBANAAFKIFO(uint3 EKKEIIKBKFL, float3 PMMBALOFMIB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8BB9C30", Offset = "0x8BB8A30", VA = "0x188BB9C30")]
	private float KHEFCALANAJ(float OBAPPOPHCNK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8BB96E0", Offset = "0x8BB84E0", VA = "0x188BB96E0")]
	private float INDNNLPKICF(float3 FIMJEIGGAAE, float3 FMCNLJEFHJN, float BNJMNFAHCMH, float EPNOGKHJIBH)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct NKJNKFOPGMG : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, PGPPEDEDCKA> LCNBEDKDHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint DEFDJOMGDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int KHHHBKPBPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int HNFPADLHOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> GCGPPKCFHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> HKFMGHJKNKJ;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8BC11C0", Offset = "0x8BBFFC0", VA = "0x188BC11C0", Slot = "4")]
	public void Execute(int FAEALBINNBA, int AHPHCJEKCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8BC1050", Offset = "0x8BBFE50", VA = "0x188BC1050")]
	private void EFJFMJLACDD(int GAOIPFAKHNK, ushort FJAGKGOEHGL, int MMKMOPGJIKD, PGPPEDEDCKA GFEPDEGAADH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct OAGLEPMHMBO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, PGPPEDEDCKA> LCNBEDKDHON;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8BC1360", Offset = "0x8BC0160", VA = "0x188BC1360", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NAEJJJLLKEK : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool JJHLPJFCDMO;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float IDBPHGGIOMF = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int DFLDMFMOCIK = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int NNAJIDOELCK = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private KLKPFEJCOIJ CJLLPGFDCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private NKJNKFOPGMG IMCBFOIKAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private OAGLEPMHMBO DJGMPNEMCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, PGPPEDEDCKA> NMBAOFMIHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private NELLLIJNHDI NMPDHFCAACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool LBCMBDCKLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int OAIICCKBGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<IIGDIHHKLBC> IPHAAOKNHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle BBEGMDHIKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle HNBMJLFMNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool LCCNHHBKJNE;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8BBF9D0", Offset = "0x8BBE7D0", VA = "0x188BBF9D0")]
	public NAEJJJLLKEK(RenderPassEvent IHIEAJGNFHC, ComputeShader FKOKELDDCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8BBF3F0", Offset = "0x8BBE1F0", VA = "0x188BBF3F0")]
	private void ICMDPCOAHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8BBEB10", Offset = "0x8BBD910", VA = "0x188BBEB10")]
	public void DHPBBDPNNGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3E6E210", Offset = "0x3E6D010", VA = "0x183E6E210")]
	public static void MNADCPLOOOA<T>(NativeArray<T> ELLFIONNNHC, int BCMFMCHGEKF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8BBF050", Offset = "0x8BBDE50", VA = "0x188BBF050")]
	public void HMGFFKHGIHL(CameraData HPEIEBCJMAM, LightData PIPIBGIKLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8BBF490", Offset = "0x8BBE290", VA = "0x188BBF490")]
	private void JENKHNMBMCF(LightData PIPIBGIKLMA, NativeArray<IIGDIHHKLBC> CNPBJBJHCJM, int GLBBJOHPPNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8BBEE10", Offset = "0x8BBDC10", VA = "0x188BBEE10")]
	private void FMDKIFNJJDP(CameraData HPEIEBCJMAM, LightData PIPIBGIKLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8BBF7D0", Offset = "0x8BBE5D0", VA = "0x188BBF7D0")]
	private void KEDLAAPNDMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8BBED10", Offset = "0x8BBDB10", VA = "0x188BBED10")]
	private void FAFNMBHABHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8BBEBF0", Offset = "0x8BBD9F0", VA = "0x188BBEBF0")]
	private void DOHLOGKOIKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8BBF460", Offset = "0x8BBE260", VA = "0x188BBF460")]
	private void IGPKBFJKFKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8BBEC10", Offset = "0x8BBDA10", VA = "0x188BBEC10", Slot = "9")]
	public override void Execute(ScriptableRenderContext KKBNGKDBMPF, RenderingData FPGBMCNDEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8BBF960", Offset = "0x8BBE760", VA = "0x188BBF960", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer ELOEPMLDMON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DAKKMBHJAKE : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort DBPGNMDCBEM = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float IDBPHGGIOMF = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly NELLLIJNHDI NMPDHFCAACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int EDHBNNJKNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private IIGDIHHKLBC[] IPHAAOKNHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 GHDDCGOIOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 LICHBLJAEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint HNONEKKDJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int KFBOCAMMBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int IBFMDGNCMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> GCGPPKCFHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> HKFMGHJKNKJ;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8BBA200", Offset = "0x8BB9000", VA = "0x188BBA200")]
	public DAKKMBHJAKE(RenderPassEvent IHIEAJGNFHC, ComputeShader FKOKELDDCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8BB9290", Offset = "0x8BB8090", VA = "0x188BB9290")]
	public void HMGFFKHGIHL(CameraData HPEIEBCJMAM, LightData PIPIBGIKLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8BB94E0", Offset = "0x8BB82E0", VA = "0x188BB94E0")]
	private void IHCNHMMCIJF(CameraData HPEIEBCJMAM, LightData PIPIBGIKLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8BB8A50", Offset = "0x8BB7850", VA = "0x188BB8A50")]
	public void DHPBBDPNNGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8BB98A0", Offset = "0x8BB86A0", VA = "0x188BB98A0")]
	private void JENKHNMBMCF(LightData PIPIBGIKLMA, IIGDIHHKLBC[] CNPBJBJHCJM, int GLBBJOHPPNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8BB90F0", Offset = "0x8BB7EF0", VA = "0x188BB90F0")]
	private void GMODGLFGAOH(int FAEALBINNBA, int AHPHCJEKCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8BB9C50", Offset = "0x8BB8A50", VA = "0x188BB9C50")]
	private void LANFKIKMHGP(int FAEALBINNBA, int FFKCBONKOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8BB9BF0", Offset = "0x8BB89F0", VA = "0x188BB9BF0")]
	private ushort JJAKMIOAMKN(int FAEALBINNBA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8BB9400", Offset = "0x8BB8200", VA = "0x188BB9400")]
	private void IBAFEMDHKNF(int FAEALBINNBA, int AHPHCJEKCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8BB9470", Offset = "0x8BB8270", VA = "0x188BB9470")]
	private void IGAMJFBKAGB(int BCMFMCHGEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8BB83E0", Offset = "0x8BB71E0", VA = "0x188BB83E0")]
	private void AAELPJACKAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8BB8C00", Offset = "0x8BB7A00", VA = "0x188BB8C00", Slot = "9")]
	public override void Execute(ScriptableRenderContext KKBNGKDBMPF, RenderingData FPGBMCNDEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8BBA1D0", Offset = "0x8BB8FD0", VA = "0x188BBA1D0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer ELOEPMLDMON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8BB84A0", Offset = "0x8BB72A0", VA = "0x188BB84A0")]
	private void CCDMHFCFDDF(int FBOLHDBJGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8BB8CE0", Offset = "0x8BB7AE0", VA = "0x188BB8CE0")]
	private void FEMIALCCJMI(uint3 EKKEIIKBKFL, uint3 LCNGLAJAAPE, ushort FBOLHDBJGLC, float3 PMMBALOFMIB, float JMHAAJMJDLJ, float EPNOGKHJIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8BB9C80", Offset = "0x8BB8A80", VA = "0x188BB9C80")]
	private void MCLAHIAHEMO(uint3 EKKEIIKBKFL, uint3 LCNGLAJAAPE, ushort FBOLHDBJGLC, float3 PMMBALOFMIB, float3 AABDLMBPIGO, float3 FMCNLJEFHJN, float JMHAAJMJDLJ, float BNJMNFAHCMH, float EPNOGKHJIBH, float GANFLGHNGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8BB91A0", Offset = "0x8BB7FA0", VA = "0x188BB91A0")]
	private void HHDBAMKIHNO(ushort FBOLHDBJGLC, uint JAHDIBPMNLG, float OJGAPPJPFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8BB97A0", Offset = "0x8BB85A0", VA = "0x188BB97A0")]
	private float3 JBANAAFKIFO(uint3 EKKEIIKBKFL, float3 PMMBALOFMIB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8BB9C30", Offset = "0x8BB8A30", VA = "0x188BB9C30")]
	private float KHEFCALANAJ(float OBAPPOPHCNK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8BB96E0", Offset = "0x8BB84E0", VA = "0x188BB96E0")]
	private float INDNNLPKICF(float3 FIMJEIGGAAE, float3 FMCNLJEFHJN, float BNJMNFAHCMH, float EPNOGKHJIBH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8BB8A70", Offset = "0x8BB7870", VA = "0x188BB8A70")]
	private void EFJFMJLACDD(int GAOIPFAKHNK, ushort FJAGKGOEHGL, int MMKMOPGJIKD, PGPPEDEDCKA GFEPDEGAADH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class NELLLIJNHDI
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class DKBHDKANFCP
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int LMOANFFHHMG;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int EFCLBBEAAJF;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int NNOMPBGFDGD;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int MLENDOHNOOL;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int NNIAEGAICDG;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int DDPFAIHMCEM;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int GFJBMBAJLIF;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int EPGJOKDONNM = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int FLAJENKLGJE = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int BNFKPLOJPCG = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int CFEAAMABGFD = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int GPHKEAOOOBJ = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int KEDBKPMHDJG = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int LCBMJGMOONL = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool CLFMBFCLCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer ILNCPPGLHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture DCNMAFGGKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int EKPKJEIGEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int JNEMBKEHEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int ADJCEGAPKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int DONBNCIPENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int PLCGJHABGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader GOBFFKKAAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int IANFPHNGJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int KJFBOPBGEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 PHCPIMGEPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 HECOBBAGGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> JCMCBOIEDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> AEINBFLKGEJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> FLOCJKDGHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1438BE0", Offset = "0x14379E0", VA = "0x181438BE0")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> KALKBMLFCOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x133C710", Offset = "0x133B510", VA = "0x18133C710")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int PHJFBDLDOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAE48E0", Offset = "0xAE36E0", VA = "0x180AE48E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NILALMBMBDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA94B30", Offset = "0xA93930", VA = "0x180A94B30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader LFCDMCMGDKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8BC04D0", Offset = "0x8BBF2D0", VA = "0x188BC04D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8BC0200", Offset = "0x8BBF000", VA = "0x188BC0200")]
	public void FFICDEPBOPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8BC05E0", Offset = "0x8BBF3E0", VA = "0x188BC05E0")]
	public void MFIHNDLJICJ(CameraData HPEIEBCJMAM, LightData PIPIBGIKLMA, int IBPCKGFCLJM, bool PMHOALAGGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3E73B00", Offset = "0x3E72900", VA = "0x183E73B00")]
	private void MNADCPLOOOA<T>(NativeArray<T> ELLFIONNNHC, int BCMFMCHGEKF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8BC08F0", Offset = "0x8BBF6F0", VA = "0x188BC08F0")]
	public void PPJICOMFFLP(CommandBuffer ELOEPMLDMON, ScriptableRenderContext KKBNGKDBMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8BC02F0", Offset = "0x8BBF0F0", VA = "0x188BC02F0")]
	private static void IHHIDCIPJGG(int EDDGEBAFLDA, CommandBuffer ELOEPMLDMON, RenderBuffer HHBEFJPLDJO, ComputeBuffer KOKLLKKOGID, ComputeShader EGPICGIHAHM, int AALJALOFFGF, int MDKDNPICJGF, int MAOHEBADFAP, int EMABEAFPOCE, int APMBCFMHOFI, int MPHMLAOIFME, int MAAIDJOAFMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8BBFEF0", Offset = "0x8BBECF0", VA = "0x188BBFEF0")]
	public void FFFGCMBIIEE(CommandBuffer ELOEPMLDMON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8BBFA80", Offset = "0x8BBE880", VA = "0x188BBFA80")]
	private RenderTexture DDHCEMKIMHB(RenderTexture IGAAPIKLKFE, int AALJALOFFGF, int MDKDNPICJGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8BC0560", Offset = "0x8BBF360", VA = "0x188BC0560")]
	public void LLKCCBLAOFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8BBFC60", Offset = "0x8BBEA60", VA = "0x188BBFC60")]
	public void DIIDADEOBJO(int DMCLCGHGNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8BC0C40", Offset = "0x8BBFA40", VA = "0x188BC0C40")]
	public NELLLIJNHDI()
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
		public struct CABBCOHNKFD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float DJOCFLAKOEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float CJDDHNLIKAG;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class LFCFCCGFONM : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string KMKBDLNKLJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler ENDKJEBOHDC;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int IANBBOEEBKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material FPICFCBFAOD;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8BBCBE0", Offset = "0x8BBB9E0", VA = "0x188BBCBE0")]
			public LFCFCCGFONM(RenderPassEvent IHIEAJGNFHC, Material GKIFPALLDIK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8BBC810", Offset = "0x8BBB610", VA = "0x188BBC810", Slot = "9")]
			public override void Execute(ScriptableRenderContext KKBNGKDBMPF, RenderingData FPGBMCNDEDB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static CABBCOHNKFD CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private LFCFCCGFONM m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x8BBE7B0", Offset = "0x8BBD5B0", VA = "0x188BBE7B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8BBE760", Offset = "0x8BBD560", VA = "0x188BBE760")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE5B0", Offset = "0x8BBD3B0", VA = "0x188BBE5B0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE4E0", Offset = "0x8BBD2E0", VA = "0x188BBE4E0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer NNEJGKAIJNN, RenderingData FPGBMCNDEDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x194FC90", Offset = "0x194EA90", VA = "0x18194FC90")]
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
		public struct AKMCOABCALJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float IHOAOAJNCLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color INDDEHLLOLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh DHPEIKDFLDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve FLKHGAIBJEL;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class LIOGPMNLHFO : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string KMKBDLNKLJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler ENDKJEBOHDC;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int CPGNANDBCKK;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int PFJFHNPPABI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material FPICFCBFAOD;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8BBCF60", Offset = "0x8BBBD60", VA = "0x188BBCF60")]
			public LIOGPMNLHFO(RenderPassEvent IHIEAJGNFHC, Material GKIFPALLDIK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8BBCCC0", Offset = "0x8BBBAC0", VA = "0x188BBCCC0", Slot = "9")]
			public override void Execute(ScriptableRenderContext KKBNGKDBMPF, RenderingData FPGBMCNDEDB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static AKMCOABCALJ CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private LIOGPMNLHFO m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x8BBEAC0", Offset = "0x8BBD8C0", VA = "0x188BBEAC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE910", Offset = "0x8BBD710", VA = "0x188BBE910", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8BBE800", Offset = "0x8BBD600", VA = "0x188BBE800", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer NNEJGKAIJNN, RenderingData FPGBMCNDEDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x194FC90", Offset = "0x194EA90", VA = "0x18194FC90")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string HNIPIHMAGBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool HADIEEMNOBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer ELOEPMLDMON, ScriptableRenderContext KKBNGKDBMPF, RenderingData FPGBMCNDEDB);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
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
		private class JACEBMLFCLI : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool BMAHMMJLJCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> GPILNCBBBAD;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> ELNOFBLNGBI;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8BBB910", Offset = "0x8BBA710", VA = "0x188BBB910")]
			public JACEBMLFCLI(RenderPassEvent IHIEAJGNFHC, bool BMAHMMJLJCE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8BBB5A0", Offset = "0x8BBA3A0", VA = "0x188BBB5A0")]
			public bool OPKPDOIHOAP(CameraData HPEIEBCJMAM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8BBB3D0", Offset = "0x8BBA1D0", VA = "0x188BBB3D0", Slot = "9")]
			public override void Execute(ScriptableRenderContext KKBNGKDBMPF, RenderingData FPGBMCNDEDB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8BBB2F0", Offset = "0x8BBA0F0", VA = "0x188BBB2F0")]
			private void BELPOAGNFAF(PerCameraRenderEffect EIACCAMPDOO, ScriptableRenderContext KKBNGKDBMPF, RenderingData FPGBMCNDEDB)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private JACEBMLFCLI m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private JACEBMLFCLI m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8BC18F0", Offset = "0x8BC06F0", VA = "0x188BC18F0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8BC1860", Offset = "0x8BC0660", VA = "0x188BC1860", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer NNEJGKAIJNN, RenderingData FPGBMCNDEDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x194FC90", Offset = "0x194EA90", VA = "0x18194FC90")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BC1B40", Offset = "0x8BC0940", VA = "0x188BC1B40")]
		public static void OPNDLAKHPPG(ScriptableRenderPass FJCAFNMJJML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8BC19A0", Offset = "0x8BC07A0", VA = "0x188BC19A0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer NNEJGKAIJNN, RenderingData FPGBMCNDEDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x194FC90", Offset = "0x194EA90", VA = "0x18194FC90")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class MIDFIHFPBIO
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 GIIFMFCBCCC;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 NCANHNEEGEL;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 EEFHLPGCLAL;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 PDKODDMKEGN;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 KLBKJFFLOJF;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8BBDD30", Offset = "0x8BBCB30", VA = "0x188BBDD30")]
	public static uint IMEEJAKBAPF(uint DBBMOEGPNPP, uint COFKGIHGCOO, uint OONOCAMNEIP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8BBDB40", Offset = "0x8BBC940", VA = "0x188BBDB40")]
	public static uint3 FIIIHJGGEBL(float3 FLAPAOJCDCM, float3 ICFONLNJAFB, float3 NDHGENMDJLF)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8BBD900", Offset = "0x8BBC700", VA = "0x188BBD900")]
	public static void BLCEBFGECBA(float3 AEABCHJEIOE, float3 LNKNAODKGEB, float3 PPDHJBIPINP, float GDMMFIOGDOL, [Out] uint3 ANOKDFBKCNM, [Out] uint3 BBIHHNFDGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8BBDD40", Offset = "0x8BBCB40", VA = "0x188BBDD40")]
	public static void LNDHGMJBENB(float3 LBMDIMOECMB, float3 IOAKNIPFFBP, float JBEBIIPBGHG, float NMJEMDKIJPO, [Out] float3 BOPNBJFLGMA, [Out] float GDMMFIOGDOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8BBE210", Offset = "0x8BBD010", VA = "0x188BBE210")]
	private static float3 POFDPMFINCP(float3 MFFKNPADLBO, float3 NELDNDDFMJA, float3 MHIMPCCKBFF, float3 CAEOJMHJCNF)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class MFNFPJBFLPH
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly ALMLLDBPKBM ANJNDEAPJCE;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly ALMLLDBPKBM GBAMMBJKKID;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly ALMLLDBPKBM DCLHPPAIOCK;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly ALMLLDBPKBM DJLEFCIBDEC;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly ALMLLDBPKBM BBIAAGNDBGC;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class FPLCBKLAOKI
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh KNDBGNIDDNP;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8BBAC50", Offset = "0x8BB9A50", VA = "0x188BBAC50")]
	public static Mesh JBKLEFHNKFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8BBA7B0", Offset = "0x8BB95B0", VA = "0x188BBA7B0")]
	public static Matrix4x4 FAOIIJNHPMM(Camera HOHEOKHPGEK, bool MBGFLMDONJJ = false, bool FMFLINKLFNE = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8BBA3F0", Offset = "0x8BB91F0", VA = "0x188BBA3F0")]
	private static Mesh AJJNENPPKPK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2132554876
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8BC2F70", Offset = "0x8BC1D70", VA = "0x188BC2F70")]
	public static void BHCFGFEPANM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8BC3000", Offset = "0x8BC1E00", VA = "0x188BC3000")]
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
