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
	public class LogRegistrationIndex : CCAGPMFGEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8077860", Offset = "0x8076260", VA = "0x188077860", Slot = "4")]
		public override void BLLBFFICICF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
		public enum PHCLHBECKFM
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface FDFOHCAOFMO
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void BALGFNNJCDG(ScriptableRenderContext OJFCDDMGKNP, List<Camera> PIPJGDHLAAE);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface PNAMKIEMMEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void BALGFNNJCDG(ScriptableRenderContext OJFCDDMGKNP, RenderingData OMILIGDPMMK);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class PIEEHEANHKB : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x80785F0", Offset = "0x8076FF0", VA = "0x1880785F0")]
			public PIEEHEANHKB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8078590", Offset = "0x8076F90", VA = "0x188078590", Slot = "9")]
			public override void Execute(ScriptableRenderContext OJFCDDMGKNP, RenderingData OMILIGDPMMK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private PIEEHEANHKB _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<FDFOHCAOFMO> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<FDFOHCAOFMO> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<PNAMKIEMMEC> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<PNAMKIEMMEC> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8079750", Offset = "0x8078150", VA = "0x188079750")]
		public static void FLFPCKNDCMG(PHCLHBECKFM ECMELILBDJG, FDFOHCAOFMO JDFFGCLCOFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x807A1A0", Offset = "0x8078BA0", VA = "0x18807A1A0")]
		public static void MPEOLEMNBGC(PHCLHBECKFM ECMELILBDJG, FDFOHCAOFMO JDFFGCLCOFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8079690", Offset = "0x8078090", VA = "0x188079690")]
		public static void FLFPCKNDCMG(PHCLHBECKFM ECMELILBDJG, PNAMKIEMMEC FLFCHLFEEHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x807A260", Offset = "0x8078C60", VA = "0x18807A260")]
		public static void MPEOLEMNBGC(PHCLHBECKFM ECMELILBDJG, PNAMKIEMMEC FLFCHLFEEHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x80793A0", Offset = "0x8077DA0", VA = "0x1880793A0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8079290", Offset = "0x8077C90", VA = "0x188079290", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IBNNGOPMLGG, RenderingData OMILIGDPMMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8079580", Offset = "0x8077F80", VA = "0x188079580", Slot = "9")]
		protected override void Dispose(bool EBBBDGCKGOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8079810", Offset = "0x8078210", VA = "0x188079810")]
		private static void JCNAEMBNNEG(ScriptableRenderContext OJFCDDMGKNP, List<Camera> PIPJGDHLAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8079330", Offset = "0x8077D30", VA = "0x188079330")]
		private static void CEJKFKCOHGC(ScriptableRenderContext OJFCDDMGKNP, List<Camera> PIPJGDHLAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8079CF0", Offset = "0x80786F0", VA = "0x188079CF0")]
		private static void LGKJIMDJAKL(ScriptableRenderContext OJFCDDMGKNP, RenderingData OMILIGDPMMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x158A650", Offset = "0x1589050", VA = "0x18158A650")]
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
		private class MOHGBBDPNJG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool DMDCMOJOIHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<NKMEGGDOKOK> DNAAJMHIGHP;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8077DB0", Offset = "0x80767B0", VA = "0x188077DB0")]
			public MOHGBBDPNJG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class MFOAFNAKDPN : PreRenderManager.PNAMKIEMMEC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string FNBNJKEKPNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler IGDFHOKLCLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly MOHGBBDPNJG DFDDCNEMFMF;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8077CF0", Offset = "0x80766F0", VA = "0x188077CF0")]
			public MFOAFNAKDPN(MOHGBBDPNJG LOEGLCFJFDO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x80778F0", Offset = "0x80762F0", VA = "0x1880778F0", Slot = "4")]
			public void BALGFNNJCDG(ScriptableRenderContext OJFCDDMGKNP, RenderingData OMILIGDPMMK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class FOAHOGOLEFB : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string IPNHEBPFKIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly MOHGBBDPNJG LOEGLCFJFDO;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8074C00", Offset = "0x8073600", VA = "0x188074C00")]
			public FOAHOGOLEFB(RenderPassEvent DKOJJABANLG, MOHGBBDPNJG LOEGLCFJFDO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x80748F0", Offset = "0x80732F0", VA = "0x1880748F0", Slot = "9")]
			public override void Execute(ScriptableRenderContext OJFCDDMGKNP, RenderingData OMILIGDPMMK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<NKMEGGDOKOK> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private MFOAFNAKDPN fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private FOAHOGOLEFB fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MOHGBBDPNJG sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8074D70", Offset = "0x8073770", VA = "0x188074D70", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x80750F0", Offset = "0x8073AF0", VA = "0x1880750F0", Slot = "9")]
		protected override void Dispose(bool EBBBDGCKGOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8074CE0", Offset = "0x80736E0", VA = "0x188074CE0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IBNNGOPMLGG, RenderingData OMILIGDPMMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x158A650", Offset = "0x1589050", VA = "0x18158A650")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NKMEGGDOKOK
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NAJEKIPJLNE(CommandBuffer MMOFOGMFKOH, Camera KPHFKOFDKOL, [NotNull] UniversalAdditionalCameraData EBDPKOPEFFO, bool KBHBCPEGIBH);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OMOHBKMIALO(Camera KPHFKOFDKOL, CommandBuffer FLBFPNANBKH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class KNDEOCKEOLA
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool HCEPAHEKLMF;
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
		private CDPDLKOIJCJ _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private DEDGBAINACA _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8077540", Offset = "0x8075F40", VA = "0x188077540", Slot = "9")]
		protected override void Dispose(bool KCDECNFFHPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x80775B0", Offset = "0x8075FB0", VA = "0x1880775B0")]
		private void HGAMELLOACK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x80771F0", Offset = "0x8075BF0", VA = "0x1880771F0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IBNNGOPMLGG, RenderingData OMILIGDPMMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x158A650", Offset = "0x1589050", VA = "0x18158A650")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KIFNMHGIAAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8076600", Offset = "0x8075000", VA = "0x188076600")]
	public static int LFFOKCBKKEG(bool PDHMNDPAIJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1A0C2C0", Offset = "0x1A0ACC0", VA = "0x181A0C2C0")]
	public static int BMEPAJPCIHB(bool PDHMNDPAIJO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct OJIHABJGJOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType GJAKIKMFGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float JHAKOFPAIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float BAKNOLAPDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float LMFKCKOBHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 CJEAPDIFHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 HCHFFADFPJA;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct FMDEGJGFOIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort LABKDMADAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float COPFPFFICBF;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct EAGEOFFOGEN : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<OJIHABJGJOP> NDMKNKDMFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 FPOFLIEIGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 LFHGAJCIGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, FMDEGJGFOIN>.ParallelWriter GCPDHBDIOKK;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8073930", Offset = "0x8072330", VA = "0x188073930", Slot = "4")]
	public void Execute(int LABKDMADAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8073E70", Offset = "0x8072870", VA = "0x188073E70")]
	private void GLPMJNGEMAN(uint3 HIJLKHBBOJA, uint3 DCPMIALEMID, ushort LABKDMADAKE, float3 MDNPLIAGHEA, float DNBBBGNMMAA, float LAAIJNIJGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8073480", Offset = "0x8071E80", VA = "0x188073480")]
	private void EGKDFBLIMEJ(uint3 HIJLKHBBOJA, uint3 DCPMIALEMID, ushort LABKDMADAKE, float3 MDNPLIAGHEA, float3 DKLEAMAJGLK, float3 MOONFCNFGMB, float DNBBBGNMMAA, float JFGELMMHKMI, float LAAIJNIJGMH, float DEGLHHOEEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8073390", Offset = "0x8071D90", VA = "0x188073390")]
	private float3 DNFFFHNHAAK(uint3 HIJLKHBBOJA, float3 MDNPLIAGHEA)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x80731B0", Offset = "0x8071BB0", VA = "0x1880731B0")]
	private float NLKAMEPJFAL(float JHAKOFPAIKA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x80731F0", Offset = "0x8071BF0", VA = "0x1880731F0")]
	private float OIIJFGOHJIM(float3 NJNHIMELJMG, float3 MOONFCNFGMB, float JFGELMMHKMI, float LAAIJNIJGMH)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct BBGHIAJGJMP : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, FMDEGJGFOIN> GCPDHBDIOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint EMGHHPDIGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int JFNMADEPLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int NDBNBHAFACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> DOBFJJKBPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> HIDAHLCAIIE;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8070240", Offset = "0x806EC40", VA = "0x188070240", Slot = "4")]
	public void Execute(int NOFPKGEJGPM, int LNOIGBDDMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x80703E0", Offset = "0x806EDE0", VA = "0x1880703E0")]
	private void HJLDJGKKCJL(int EKPDCFJANOK, ushort EPAEGJFGFKO, int FFEFIJLFMDJ, FMDEGJGFOIN OBPFDNGIBGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct EAKPFAININB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, FMDEGJGFOIN> GCPDHBDIOKK;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x80748B0", Offset = "0x80732B0", VA = "0x1880748B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class CDPDLKOIJCJ : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool GMFBAKDEBPD;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float IMPHEBAAKMB = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int MMABDBCMGCC = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int JHLBNBOLDHL = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private EAGEOFFOGEN DJGFKKFMMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private BBGHIAJGJMP LDLIDGMDNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private EAKPFAININB NLPMAALCJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, FMDEGJGFOIN> HLEDJOPJLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private HIGNBEILPAE HPEKLOEDMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool OLGFEOBBJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int NINLDFAEDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<OJIHABJGJOP> KEDAPOJBHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle IPJGAAPJOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle EAHMPLEINNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool GACCNOOKMCB;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8071410", Offset = "0x806FE10", VA = "0x188071410")]
	public CDPDLKOIJCJ(RenderPassEvent DKOJJABANLG, ComputeShader NKBDIGMNCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8071010", Offset = "0x806FA10", VA = "0x188071010")]
	private void JHPJIEOFDOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8071080", Offset = "0x806FA80", VA = "0x188071080")]
	public void OANOBIBFMPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x341F340", Offset = "0x341DD40", VA = "0x18341F340")]
	public static void DGKPOIOKEMC<T>(NativeArray<T> NAKGFAINKPB, int PICLDLMFMMM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8070710", Offset = "0x806F110", VA = "0x188070710")]
	public void DJEKKBJOHPM(CameraData EBDPKOPEFFO, LightData LEHBAGEIKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8070CD0", Offset = "0x806F6D0", VA = "0x188070CD0")]
	private void ICJCMBNADCA(LightData LEHBAGEIKBL, NativeArray<OJIHABJGJOP> DHMFIMLACLL, int BFFNLCNPDIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8071190", Offset = "0x806FB90", VA = "0x188071190")]
	private void PEICLGAMILG(CameraData EBDPKOPEFFO, LightData LEHBAGEIKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8070580", Offset = "0x806EF80", VA = "0x188070580")]
	private void BMMCGPGLCCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8070BB0", Offset = "0x806F5B0", VA = "0x188070BB0")]
	private void GHJFCNPKENJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8070CB0", Offset = "0x806F6B0", VA = "0x188070CB0")]
	private void HADPEHHHGMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8070550", Offset = "0x806EF50", VA = "0x188070550")]
	private void AEBNLBMGGHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8070AB0", Offset = "0x806F4B0", VA = "0x188070AB0", Slot = "9")]
	public override void Execute(ScriptableRenderContext OJFCDDMGKNP, RenderingData OMILIGDPMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8071160", Offset = "0x806FB60", VA = "0x188071160", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer FLBFPNANBKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DEDGBAINACA : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort PIPIKAOFPAO = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float IMPHEBAAKMB = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HIGNBEILPAE HPEKLOEDMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int KEGFOENDAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private OJIHABJGJOP[] KEDAPOJBHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 ADBMJHKDPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 MBJBIBMKOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint NPNPCGFMPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int OAIOIBDGOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int GNIOJPNAGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> DOBFJJKBPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> HIDAHLCAIIE;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x80732E0", Offset = "0x8071CE0", VA = "0x1880732E0")]
	public DEDGBAINACA(RenderPassEvent DKOJJABANLG, ComputeShader NKBDIGMNCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8071530", Offset = "0x806FF30", VA = "0x188071530")]
	public void DJEKKBJOHPM(CameraData EBDPKOPEFFO, LightData LEHBAGEIKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8072E90", Offset = "0x8071890", VA = "0x188072E90")]
	private void LJKGNAHIPPN(CameraData EBDPKOPEFFO, LightData LEHBAGEIKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x80731D0", Offset = "0x8071BD0", VA = "0x1880731D0")]
	public void OANOBIBFMPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8072B00", Offset = "0x8071500", VA = "0x188072B00")]
	private void ICJCMBNADCA(LightData LEHBAGEIKBL, OJIHABJGJOP[] DHMFIMLACLL, int BFFNLCNPDIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8072A50", Offset = "0x8071450", VA = "0x188072A50")]
	private void HKDGFBHBGDP(int NOFPKGEJGPM, int LNOIGBDDMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8073090", Offset = "0x8071A90", VA = "0x188073090")]
	private void LPPKDEOKADP(int NOFPKGEJGPM, int PGJKBFGEJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8072E50", Offset = "0x8071850", VA = "0x188072E50")]
	private ushort IFABBFMBIIM(int NOFPKGEJGPM)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x80714C0", Offset = "0x806FEC0", VA = "0x1880714C0")]
	private void ANEBPADAEFI(int NOFPKGEJGPM, int LNOIGBDDMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x80717A0", Offset = "0x80701A0", VA = "0x1880717A0")]
	private void EDNHHEPHCHG(int PICLDLMFMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8071D60", Offset = "0x8070760", VA = "0x188071D60")]
	private void EHOEPKNPHMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8071E20", Offset = "0x8070820", VA = "0x188071E20", Slot = "9")]
	public override void Execute(ScriptableRenderContext OJFCDDMGKNP, RenderingData OMILIGDPMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x80732B0", Offset = "0x8071CB0", VA = "0x1880732B0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer FLBFPNANBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8072310", Offset = "0x8070D10", VA = "0x188072310")]
	private void HFOLAEMNBFI(int LABKDMADAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8071F00", Offset = "0x8070900", VA = "0x188071F00")]
	private void GLPMJNGEMAN(uint3 HIJLKHBBOJA, uint3 DCPMIALEMID, ushort LABKDMADAKE, float3 MDNPLIAGHEA, float DNBBBGNMMAA, float LAAIJNIJGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8071810", Offset = "0x8070210", VA = "0x188071810")]
	private void EGKDFBLIMEJ(uint3 HIJLKHBBOJA, uint3 DCPMIALEMID, ushort LABKDMADAKE, float3 MDNPLIAGHEA, float3 DKLEAMAJGLK, float3 MOONFCNFGMB, float DNBBBGNMMAA, float JFGELMMHKMI, float LAAIJNIJGMH, float DEGLHHOEEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x80730C0", Offset = "0x8071AC0", VA = "0x1880730C0")]
	private void MABMPEMKCJO(ushort LABKDMADAKE, uint FBENBADCMDL, float CBAEOKKLEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x80716A0", Offset = "0x80700A0", VA = "0x1880716A0")]
	private float3 DNFFFHNHAAK(uint3 HIJLKHBBOJA, float3 MDNPLIAGHEA)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x80731B0", Offset = "0x8071BB0", VA = "0x1880731B0")]
	private float NLKAMEPJFAL(float JHAKOFPAIKA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x80731F0", Offset = "0x8071BF0", VA = "0x1880731F0")]
	private float OIIJFGOHJIM(float3 NJNHIMELJMG, float3 MOONFCNFGMB, float JFGELMMHKMI, float LAAIJNIJGMH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x80728C0", Offset = "0x80712C0", VA = "0x1880728C0")]
	private void HJLDJGKKCJL(int EKPDCFJANOK, ushort EPAEGJFGFKO, int FFEFIJLFMDJ, FMDEGJGFOIN OBPFDNGIBGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class HIGNBEILPAE
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class ILGDDFFGNLN
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int DOOLJIOMNPL;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int JOFODNLGFOM;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int HPAMNNLKOPJ;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int DBFGMDADHFJ;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int DLMBGNEAHKM;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int NOCELAFEAEI;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int LCODPJMLHEO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int GEJBPACCGGI = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int PJBGOIECOIO = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int JIENNJDCCAC = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int KLCPPCPAEKJ = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int MPALBLOPIIB = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int BMBJJJNLGMF = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int PMNGKJDDJAM = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool GCCJJAGLNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer CGMGEJIEPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture ANPJBLKIFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int PKALDJPIMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int KHHOPDJHCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int AGLMJOLAFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int BKNEBELAPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int AFDODMBJPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader EELMFNICBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int OENPDCDPFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int IFEGBHKJPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 KCDFOKFDJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 KHPLDGCLJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> ACFGGIDANIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> BAJOCKKHMDK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> NBAILJOBABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x492CE10", Offset = "0x492B810", VA = "0x18492CE10")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> GKOHLONPFNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1094B60", Offset = "0x1093560", VA = "0x181094B60")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int MPMFEBGDMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xBF57B0", Offset = "0xBF41B0", VA = "0x180BF57B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int LLJGBHBMBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9B5540", Offset = "0x9B3F40", VA = "0x1809B5540")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader IAHMFMCJKDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8076410", Offset = "0x8074E10", VA = "0x188076410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x80752E0", Offset = "0x8073CE0", VA = "0x1880752E0")]
	public void CHMHFDMILHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x80753D0", Offset = "0x8073DD0", VA = "0x1880753D0")]
	public void FFPBDDKELOB(CameraData EBDPKOPEFFO, LightData LEHBAGEIKBL, int PNJAKHFLGJM, bool PDHMNDPAIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3681210", Offset = "0x367FC10", VA = "0x183681210")]
	private void DGKPOIOKEMC<T>(NativeArray<T> NAKGFAINKPB, int PICLDLMFMMM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x80760C0", Offset = "0x8074AC0", VA = "0x1880760C0")]
	public void PCFJJMPCLLF(CommandBuffer FLBFPNANBKH, ScriptableRenderContext OJFCDDMGKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8075D00", Offset = "0x8074700", VA = "0x188075D00")]
	private static void JMJOIAELANE(int IFPOAPDPHIH, CommandBuffer FLBFPNANBKH, RenderBuffer LEPAMPAJDDL, ComputeBuffer ABBLMHCGDEB, ComputeShader HBFCOMOLOBA, int JOGJPHGHLDL, int HPNFPJJHNLF, int GKHDFLLOGAI, int JKBJFMKAMOE, int OJJKNOOGLEN, int IGFKEFAKKDH, int GBAJNLFGLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8075760", Offset = "0x8074160", VA = "0x188075760")]
	public void IFMDNDHGIJJ(CommandBuffer FLBFPNANBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8075EE0", Offset = "0x80748E0", VA = "0x188075EE0")]
	private RenderTexture NDDIJPNONHH(RenderTexture MBLOJMBDJKE, int JOGJPHGHLDL, int HPNFPJJHNLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x80756E0", Offset = "0x80740E0", VA = "0x1880756E0")]
	public void GDONIOIKOFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8075A70", Offset = "0x8074470", VA = "0x188075A70")]
	public void JHFHKENBGKL(int BDLBCMJPJHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x80764A0", Offset = "0x8074EA0", VA = "0x1880764A0")]
	public HIGNBEILPAE()
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
		public struct ENBBDAOPOKM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float LMBOHFKDIKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float PMMMEBKJFNJ;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class POHMKLONHNJ : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string COEDJGLJDCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler AHBBHPBGHEC;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int KDDKNOCBLNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material JECONHNKBAE;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x80789E0", Offset = "0x80773E0", VA = "0x1880789E0")]
			public POHMKLONHNJ(RenderPassEvent DKOJJABANLG, Material GMIALIBEKEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8078610", Offset = "0x8077010", VA = "0x188078610", Slot = "9")]
			public override void Execute(ScriptableRenderContext OJFCDDMGKNP, RenderingData OMILIGDPMMK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static ENBBDAOPOKM CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private POHMKLONHNJ m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x8078110", Offset = "0x8076B10", VA = "0x188078110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x80780C0", Offset = "0x8076AC0", VA = "0x1880780C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8077F10", Offset = "0x8076910", VA = "0x188077F10", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8077E40", Offset = "0x8076840", VA = "0x188077E40", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IBNNGOPMLGG, RenderingData OMILIGDPMMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x158A650", Offset = "0x1589050", VA = "0x18158A650")]
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
		public struct OHCLOLGOGGJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float PPEPPHOEMDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color CCEDDENGKJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh KNAGPEEOFAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve PGLDLIOPICB;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class PPFGJMFOCOP : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string COEDJGLJDCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler AHBBHPBGHEC;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int LLHIFMPGCFL;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int LJCBKBPAEPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material JECONHNKBAE;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8078D60", Offset = "0x8077760", VA = "0x188078D60")]
			public PPFGJMFOCOP(RenderPassEvent DKOJJABANLG, Material GMIALIBEKEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8078AC0", Offset = "0x80774C0", VA = "0x188078AC0", Slot = "9")]
			public override void Execute(ScriptableRenderContext OJFCDDMGKNP, RenderingData OMILIGDPMMK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static OHCLOLGOGGJ CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private PPFGJMFOCOP m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x8078420", Offset = "0x8076E20", VA = "0x188078420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8078270", Offset = "0x8076C70", VA = "0x188078270", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8078160", Offset = "0x8076B60", VA = "0x188078160", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IBNNGOPMLGG, RenderingData OMILIGDPMMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x158A650", Offset = "0x1589050", VA = "0x18158A650")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string MMPCJKOBODI
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool JBJILKBEECB
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer FLBFPNANBKH, ScriptableRenderContext OJFCDDMGKNP, RenderingData OMILIGDPMMK);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9AE050", Offset = "0x9ACA50", VA = "0x1809AE050")]
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
		private class EAKOCAJMOIP : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool IELIMEAJNMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> OCCOFKNPJGE;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> JFOEKLKFKKC;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8074800", Offset = "0x8073200", VA = "0x188074800")]
			public EAKOCAJMOIP(RenderPassEvent DKOJJABANLG, bool IELIMEAJNMD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8074490", Offset = "0x8072E90", VA = "0x188074490")]
			public bool OPJAALLODOJ(CameraData EBDPKOPEFFO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x80742C0", Offset = "0x8072CC0", VA = "0x1880742C0", Slot = "9")]
			public override void Execute(ScriptableRenderContext OJFCDDMGKNP, RenderingData OMILIGDPMMK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x80741E0", Offset = "0x8072BE0", VA = "0x1880741E0")]
			private void EDHJCLDKGNM(PerCameraRenderEffect LOKJIHDGPEO, ScriptableRenderContext OJFCDDMGKNP, RenderingData OMILIGDPMMK)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private EAKOCAJMOIP m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private EAKOCAJMOIP m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8078ED0", Offset = "0x80778D0", VA = "0x188078ED0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8078E40", Offset = "0x8077840", VA = "0x188078E40", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IBNNGOPMLGG, RenderingData OMILIGDPMMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x158A650", Offset = "0x1589050", VA = "0x18158A650")]
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
		[Cpp2IlInjected.Address(RVA = "0x8079120", Offset = "0x8077B20", VA = "0x188079120")]
		public static void CJIINAOKCGI(ScriptableRenderPass IHLMBMONNHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8078F80", Offset = "0x8077980", VA = "0x188078F80", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IBNNGOPMLGG, RenderingData OMILIGDPMMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x158A650", Offset = "0x1589050", VA = "0x18158A650")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class LGFGLHPKLIJ
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 JNJCIIFILOL;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 JGDNALKBDPC;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 ABGCDCLEHDO;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 PCLJKIFEHDA;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 EKGDOFMACBB;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8076CD0", Offset = "0x80756D0", VA = "0x188076CD0")]
	public static uint HEPMMIBFCJM(uint CJBFFOKBLHB, uint CNBLFOFLDDG, uint KCDOIPKCFFN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8076AE0", Offset = "0x80754E0", VA = "0x188076AE0")]
	public static uint3 GCLIAGDDJDG(float3 KKIJMCHODGC, float3 FPOFLIEIGGB, float3 LFHGAJCIGIL)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8076CE0", Offset = "0x80756E0", VA = "0x188076CE0")]
	public static void KDHJBMLCIIH(float3 JIBHNKACFGF, float3 CKBCNNNCNNG, float3 DBOGLOOBFOL, float OAIHKLDEKFL, [Out] uint3 LBPBBMOILDD, [Out] uint3 FFEHENFLAAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8076610", Offset = "0x8075010", VA = "0x188076610")]
	public static void FFJLABJJEFO(float3 ODFNFLEBJPN, float3 FBFNAIDPNCN, float BAKNOLAPDBG, float OMOLJHGNJMD, [Out] float3 BAICAHEDIPF, [Out] float OAIHKLDEKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8076F20", Offset = "0x8075920", VA = "0x188076F20")]
	private static float3 LGOPFHONFEL(float3 PIPBHJOLNGA, float3 DJBJHLAFBJE, float3 PCJDPFAKPGM, float3 IHCOMEBCING)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class OMJEICBMDNC
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly LMPJBEBLCLM HGLDNOBIACL;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly LMPJBEBLCLM NEICIHHCCPK;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly LMPJBEBLCLM MAKLIGMLJKM;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly LMPJBEBLCLM OIDNMBJGALO;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly LMPJBEBLCLM FFLCJEAAAJI;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class ABDPMEHPCGB
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh OAMCEDKILLE;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x80701A0", Offset = "0x806EBA0", VA = "0x1880701A0")]
	public static Mesh LPAIDGOPIEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x806FD00", Offset = "0x806E700", VA = "0x18806FD00")]
	public static Matrix4x4 IIOBLIANJIL(Camera KPHFKOFDKOL, bool MACHFNCAPJD = false, bool JIINDMHHIEL = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x806F940", Offset = "0x806E340", VA = "0x18806F940")]
	private static Mesh CPICKIGGLGM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__539208670
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x807A540", Offset = "0x8078F40", VA = "0x18807A540")]
	public static void PBGLILIDOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x807A530", Offset = "0x8078F30", VA = "0x18807A530")]
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
