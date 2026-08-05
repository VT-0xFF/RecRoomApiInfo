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
	public class LogRegistrationIndex : NELPCBNCFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4730", Offset = "0x7BE3330", VA = "0x187BE4730", Slot = "4")]
		public override void CHOGICNNBDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
		public enum GEGKIMANHNC
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface OPENLHNCHKG
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void DOIAJGGJPHE(ScriptableRenderContext HJIAOGEIAJO, List<Camera> PPCKGADDGAE);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface ACINCODCKBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void DOIAJGGJPHE(ScriptableRenderContext HJIAOGEIAJO, RenderingData JCFGFMDCKBA);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class JOLGPDGBHPK : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7BE1950", Offset = "0x7BE0550", VA = "0x187BE1950")]
			public JOLGPDGBHPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7BE18F0", Offset = "0x7BE04F0", VA = "0x187BE18F0", Slot = "9")]
			public override void Execute(ScriptableRenderContext HJIAOGEIAJO, RenderingData JCFGFMDCKBA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private JOLGPDGBHPK _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<OPENLHNCHKG> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<OPENLHNCHKG> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<ACINCODCKBC> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<ACINCODCKBC> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BEA820", Offset = "0x7BE9420", VA = "0x187BEA820")]
		public static void ALKHLKGDOPJ(GEGKIMANHNC NBBBDHLFOHE, OPENLHNCHKG HBAGBIAGELN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7BEB1C0", Offset = "0x7BE9DC0", VA = "0x187BEB1C0")]
		public static void OHAPFDKBHFO(GEGKIMANHNC NBBBDHLFOHE, OPENLHNCHKG HBAGBIAGELN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7BEA760", Offset = "0x7BE9360", VA = "0x187BEA760")]
		public static void ALKHLKGDOPJ(GEGKIMANHNC NBBBDHLFOHE, ACINCODCKBC AFKNKLGGMHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7BEB280", Offset = "0x7BE9E80", VA = "0x187BEB280")]
		public static void OHAPFDKBHFO(GEGKIMANHNC NBBBDHLFOHE, ACINCODCKBC AFKNKLGGMHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7BEA980", Offset = "0x7BE9580", VA = "0x187BEA980", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7BEA8E0", Offset = "0x7BE94E0", VA = "0x187BEA8E0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer HHBLCPHFAAG, RenderingData JCFGFMDCKBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7BEAB60", Offset = "0x7BE9760", VA = "0x187BEAB60", Slot = "9")]
		protected override void Dispose(bool AGLEBEKBMMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7BEAC70", Offset = "0x7BE9870", VA = "0x187BEAC70")]
		private static void HICNMDAGPJM(ScriptableRenderContext HJIAOGEIAJO, List<Camera> PPCKGADDGAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7BEB150", Offset = "0x7BE9D50", VA = "0x187BEB150")]
		private static void JLGGGIMLCKE(ScriptableRenderContext HJIAOGEIAJO, List<Camera> PPCKGADDGAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7BEA2B0", Offset = "0x7BE8EB0", VA = "0x187BEA2B0")]
		private static void AAGPKHPCEKD(ScriptableRenderContext HJIAOGEIAJO, RenderingData JCFGFMDCKBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1435B70", Offset = "0x1434770", VA = "0x181435B70")]
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
		private class FAIIIGLPCBO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool BJFGPPGIMOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<DMFADGNJHFD> NMDCNJFJJLP;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7BE0DA0", Offset = "0x7BDF9A0", VA = "0x187BE0DA0")]
			public FAIIIGLPCBO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class OAONOFODGIE : PreRenderManager.ACINCODCKBC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string CNIAJJOLOCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler MNKAAIHPENK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly FAIIIGLPCBO OIFBPILIKCC;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7BE8280", Offset = "0x7BE6E80", VA = "0x187BE8280")]
			public OAONOFODGIE(FAIIIGLPCBO LENOHIDFJLN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7BE7E90", Offset = "0x7BE6A90", VA = "0x187BE7E90", Slot = "4")]
			public void DOIAJGGJPHE(ScriptableRenderContext HJIAOGEIAJO, RenderingData JCFGFMDCKBA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class LMDOLOAADJM : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string KJFIIEIAAHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly FAIIIGLPCBO LENOHIDFJLN;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7BE2F70", Offset = "0x7BE1B70", VA = "0x187BE2F70")]
			public LMDOLOAADJM(RenderPassEvent LGCDAMLMEBP, FAIIIGLPCBO LENOHIDFJLN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7BE2C60", Offset = "0x7BE1860", VA = "0x187BE2C60", Slot = "9")]
			public override void Execute(ScriptableRenderContext HJIAOGEIAJO, RenderingData JCFGFMDCKBA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<DMFADGNJHFD> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private OAONOFODGIE fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private LMDOLOAADJM fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private FAIIIGLPCBO sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7BE0EC0", Offset = "0x7BDFAC0", VA = "0x187BE0EC0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7BE1240", Offset = "0x7BDFE40", VA = "0x187BE1240", Slot = "9")]
		protected override void Dispose(bool AGLEBEKBMMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7BE0E30", Offset = "0x7BDFA30", VA = "0x187BE0E30", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer HHBLCPHFAAG, RenderingData JCFGFMDCKBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1435B70", Offset = "0x1434770", VA = "0x181435B70")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DMFADGNJHFD
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool POKBIHDBBLB(CommandBuffer PKBKLIGFEGI, Camera CBLDONJIECH, [NotNull] UniversalAdditionalCameraData GIJGHEMJNNB, bool PHIHLJDIGJA);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DDEICBCIHKF(Camera CBLDONJIECH, CommandBuffer KLHMGKEFLPH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class OPAJLKGFAOC
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool AFHHECHOIPC;
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
		private KIMMGOHKMIO _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private NOIMCOOEDBB _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7BE46C0", Offset = "0x7BE32C0", VA = "0x187BE46C0", Slot = "9")]
		protected override void Dispose(bool EGDAKFKJIIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4410", Offset = "0x7BE3010", VA = "0x187BE4410")]
		private void CINICADJBIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7BE40C0", Offset = "0x7BE2CC0", VA = "0x187BE40C0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer HHBLCPHFAAG, RenderingData JCFGFMDCKBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1435B70", Offset = "0x1434770", VA = "0x181435B70")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class IBCMKCBOJKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7BE18E0", Offset = "0x7BE04E0", VA = "0x187BE18E0")]
	public static int HAGBBJNMIJM(bool ENBCBNKLCKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x18A5470", Offset = "0x18A4070", VA = "0x1818A5470")]
	public static int PLJJLIKDCBB(bool ENBCBNKLCKA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct BEANJFDBGNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType NBAIBELIDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float KNLHMDEMKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float OKCFDJGMALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float PLJDAIBMFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 CEHIBMLKGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 NGMIOOBDDOA;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct GPAEPLIFLID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort BOEBCPFPDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float ABDIJPCPDGA;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct LOGEKKKAECK : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<BEANJFDBGNJ> JHFLHDKAHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 MOOHMGODMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 HEBHDAPCOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, GPAEPLIFLID>.ParallelWriter OPPMOGFALBE;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7BE3130", Offset = "0x7BE1D30", VA = "0x187BE3130", Slot = "4")]
	public void Execute(int BOEBCPFPDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7BE3C10", Offset = "0x7BE2810", VA = "0x187BE3C10")]
	private void NOOOGOBPJFI(uint3 CNEDOGMCJED, uint3 LEAEKDDPGDG, ushort BOEBCPFPDHE, float3 MLMIFHLMDNF, float GDNIMEFKEOM, float MICPGMADGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7BE3670", Offset = "0x7BE2270", VA = "0x187BE3670")]
	private void GGOCMLILBDA(uint3 CNEDOGMCJED, uint3 LEAEKDDPGDG, ushort BOEBCPFPDHE, float3 MLMIFHLMDNF, float3 PKOBFCIJKJH, float3 IKLHAIGGAHJ, float GDNIMEFKEOM, float BFBLJHJBPED, float MICPGMADGNL, float KFOBEJDDICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7BE3B20", Offset = "0x7BE2720", VA = "0x187BE3B20")]
	private float3 NLCLALBABDE(uint3 CNEDOGMCJED, float3 MLMIFHLMDNF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7BE3110", Offset = "0x7BE1D10", VA = "0x187BE3110")]
	private float CFDGFHEBPNE(float KNLHMDEMKKA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7BE3050", Offset = "0x7BE1C50", VA = "0x187BE3050")]
	private float BFNKHIIFMAG(float3 KKKGLIDHKHK, float3 IKLHAIGGAHJ, float BFBLJHJBPED, float MICPGMADGNL)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct BNGACLKMMDK : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, GPAEPLIFLID> OPPMOGFALBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint LLLABENABKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int CHGFNLLAONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int JNBEMPKCOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> MMINJPGBBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> LIKLKLNKLDC;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7BE0C00", Offset = "0x7BDF800", VA = "0x187BE0C00", Slot = "4")]
	public void Execute(int CGLIGJIEHPF, int LIOFPMEFDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7BE0A90", Offset = "0x7BDF690", VA = "0x187BE0A90")]
	private void BONJIBKLPKJ(int HFNJKJFDMAB, ushort GIIMPDNLFHM, int ILBIPKAKLFL, GPAEPLIFLID EJFJFEANOOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct PDAHCLCOGDJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, GPAEPLIFLID> OPPMOGFALBE;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7BE8340", Offset = "0x7BE6F40", VA = "0x187BE8340", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KIMMGOHKMIO : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool AHFCGDADOJF;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float ILFJNMGLAPG = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int FJCBJGOCKKH = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int LNFECEDIOCL = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private LOGEKKKAECK CHCBNFLKHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private BNGACLKMMDK EDPNHAOHGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private PDAHCLCOGDJ HNMIGKOIJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, GPAEPLIFLID> IJAIIDOFOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private PDKBDFGJMBN ALCHLMNOBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool GGPIICJDAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int JACDMCEJIJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<BEANJFDBGNJ> DFEPCLBKNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle NOOEBBPPBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle DCECKFACJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool KACACJLPNHO;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2BB0", Offset = "0x7BE17B0", VA = "0x187BE2BB0")]
	public KIMMGOHKMIO(RenderPassEvent LGCDAMLMEBP, ComputeShader LFKFICFKHPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2260", Offset = "0x7BE0E60", VA = "0x187BE2260")]
	private void HOPAGJJFEPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2180", Offset = "0x7BE0D80", VA = "0x187BE2180")]
	public void HHPKBJHOKAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x343ADC0", Offset = "0x34399C0", VA = "0x18343ADC0")]
	public static void CGNFHMOHJLK<T>(NativeArray<T> CPOMPIIIEGC, int FJJGAGKDECJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7BE27D0", Offset = "0x7BE13D0", VA = "0x187BE27D0")]
	public void PIPGIJCNJIE(CameraData GIJGHEMJNNB, LightData MPJNPALOMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7BE1CF0", Offset = "0x7BE08F0", VA = "0x187BE1CF0")]
	private void AKEHBGJCBNA(LightData MPJNPALOMDB, NativeArray<BEANJFDBGNJ> JNGKDBKOIFG, int NGDJHDODDHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2560", Offset = "0x7BE1160", VA = "0x187BE2560")]
	private void OBMAHHLIMJE(CameraData GIJGHEMJNNB, LightData MPJNPALOMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7BE22D0", Offset = "0x7BE0ED0", VA = "0x187BE22D0")]
	private void IBIPNFBLHBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2460", Offset = "0x7BE1060", VA = "0x187BE2460")]
	private void KOFNHLIGDIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2030", Offset = "0x7BE0C30", VA = "0x187BE2030")]
	private void EOGAOPAJMMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2150", Offset = "0x7BE0D50", VA = "0x187BE2150")]
	private void GJNOOGFIDEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2050", Offset = "0x7BE0C50", VA = "0x187BE2050", Slot = "9")]
	public override void Execute(ScriptableRenderContext HJIAOGEIAJO, RenderingData JCFGFMDCKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7BE27A0", Offset = "0x7BE13A0", VA = "0x187BE27A0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer KLHMGKEFLPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NOIMCOOEDBB : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort JMMMJAGPHKK = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float ILFJNMGLAPG = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly PDKBDFGJMBN ALCHLMNOBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int PCAKCOBEJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private BEANJFDBGNJ[] DFEPCLBKNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 IJCBGDHJMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 JKDBEPPHDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint NAEDAPPNOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int GNFGOABDEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int OJIDONIAEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> MMINJPGBBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> LIKLKLNKLDC;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7DE0", Offset = "0x7BE69E0", VA = "0x187BE7DE0")]
	public NOIMCOOEDBB(RenderPassEvent LGCDAMLMEBP, ComputeShader LFKFICFKHPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7C70", Offset = "0x7BE6870", VA = "0x187BE7C70")]
	public void PIPGIJCNJIE(CameraData GIJGHEMJNNB, LightData MPJNPALOMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7A40", Offset = "0x7BE6640", VA = "0x187BE7A40")]
	private void OAHJGMEIOJO(CameraData GIJGHEMJNNB, LightData MPJNPALOMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7BE6D50", Offset = "0x7BE5950", VA = "0x187BE6D50")]
	public void HHPKBJHOKAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7BE60A0", Offset = "0x7BE4CA0", VA = "0x187BE60A0")]
	private void AKEHBGJCBNA(LightData MPJNPALOMDB, BEANJFDBGNJ[] JNGKDBKOIFG, int NGDJHDODDHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7BE6DA0", Offset = "0x7BE59A0", VA = "0x187BE6DA0")]
	private void JAGPPILKMBF(int CGLIGJIEHPF, int LIOFPMEFDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7BE6D70", Offset = "0x7BE5970", VA = "0x187BE6D70")]
	private void HOBHAPELNNJ(int CGLIGJIEHPF, int EBDKDADIOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7BE63F0", Offset = "0x7BE4FF0", VA = "0x187BE63F0")]
	private ushort BMFMGKHINCJ(int CGLIGJIEHPF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7BE74C0", Offset = "0x7BE60C0", VA = "0x187BE74C0")]
	private void KBDINFJIPOP(int CGLIGJIEHPF, int LIOFPMEFDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7BE6430", Offset = "0x7BE5030", VA = "0x187BE6430")]
	private void BNNLJAJOOBL(int FJJGAGKDECJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7BE6E50", Offset = "0x7BE5A50", VA = "0x187BE6E50")]
	private void JNGLFCPOHBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7BE6720", Offset = "0x7BE5320", VA = "0x187BE6720", Slot = "9")]
	public override void Execute(ScriptableRenderContext HJIAOGEIAJO, RenderingData JCFGFMDCKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7C40", Offset = "0x7BE6840", VA = "0x187BE7C40", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer KLHMGKEFLPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7BE6F10", Offset = "0x7BE5B10", VA = "0x187BE6F10")]
	private void KAIAGGJDNJA(int BOEBCPFPDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7630", Offset = "0x7BE6230", VA = "0x187BE7630")]
	private void NOOOGOBPJFI(uint3 CNEDOGMCJED, uint3 LEAEKDDPGDG, ushort BOEBCPFPDHE, float3 MLMIFHLMDNF, float GDNIMEFKEOM, float MICPGMADGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7BE6800", Offset = "0x7BE5400", VA = "0x187BE6800")]
	private void GGOCMLILBDA(uint3 CNEDOGMCJED, uint3 LEAEKDDPGDG, ushort BOEBCPFPDHE, float3 MLMIFHLMDNF, float3 PKOBFCIJKJH, float3 IKLHAIGGAHJ, float GDNIMEFKEOM, float BFBLJHJBPED, float MICPGMADGNL, float KFOBEJDDICH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7BE6630", Offset = "0x7BE5230", VA = "0x187BE6630")]
	private void EGNBJIEAOIF(ushort BOEBCPFPDHE, uint PJJPKIPAJDM, float GICFKGMGGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7530", Offset = "0x7BE6130", VA = "0x187BE7530")]
	private float3 NLCLALBABDE(uint3 CNEDOGMCJED, float3 MLMIFHLMDNF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7BE3110", Offset = "0x7BE1D10", VA = "0x187BE3110")]
	private float CFDGFHEBPNE(float KNLHMDEMKKA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7BE3050", Offset = "0x7BE1C50", VA = "0x187BE3050")]
	private float BFNKHIIFMAG(float3 KKKGLIDHKHK, float3 IKLHAIGGAHJ, float BFBLJHJBPED, float MICPGMADGNL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7BE64A0", Offset = "0x7BE50A0", VA = "0x187BE64A0")]
	private void BONJIBKLPKJ(int HFNJKJFDMAB, ushort GIIMPDNLFHM, int ILBIPKAKLFL, GPAEPLIFLID EJFJFEANOOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class PDKBDFGJMBN
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class LOPGLFBIMAD
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int KIGMIIHJFDA;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int JPKBKDGLEMJ;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int EBFDOAEGLHH;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int EOCHGOFPGEB;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int ANOBPILMOJD;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int NJINMKOHGLM;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int DOFBHEDGENM;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int MCAOIGEMFOK = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int JCOJDMHHAPO = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int FGIFEOOKOCH = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int GKHIOCGLOAI = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int GJAPFOGOCCG = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int LFPPMPBICOG = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int BNNNIMNCHPB = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool NJEDOMKHOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer MIJEEEICDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture PFFMKMILOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int FJMNCEEDGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int CADKGLNMKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int HOMKBJNKIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int MPEAGFNNPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int FKCMELMCICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader DKLMMNMNJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int LICMGPHOMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int CIPEGGEBOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 OGKLHCNCDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 BDELLMNBPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> JMGFFMNNLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> FLIFBJBJDPI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> LIMGJJABIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x49DB4B0", Offset = "0x49DA0B0", VA = "0x1849DB4B0")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> CNNLDMFEKJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xF67380", Offset = "0xF65F80", VA = "0x180F67380")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int CCMEIFPCHCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xB0EFA0", Offset = "0xB0DBA0", VA = "0x180B0EFA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int PGPJPHBBMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x95B840", Offset = "0x95A440", VA = "0x18095B840")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader NPFFAFMOADA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7BE94B0", Offset = "0x7BE80B0", VA = "0x187BE94B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7BE90B0", Offset = "0x7BE7CB0", VA = "0x187BE90B0")]
	public void MPDBLNIHPLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7BE91A0", Offset = "0x7BE7DA0", VA = "0x187BE91A0")]
	public void MPFCHLFAIAE(CameraData GIJGHEMJNNB, LightData MPJNPALOMDB, int MMLBCMPPLKF, bool ENBCBNKLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x355A940", Offset = "0x3559540", VA = "0x18355A940")]
	private void CGNFHMOHJLK<T>(NativeArray<T> CPOMPIIIEGC, int FJJGAGKDECJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7BE8B80", Offset = "0x7BE7780", VA = "0x187BE8B80")]
	public void HOFBOENGGBF(CommandBuffer KLHMGKEFLPH, ScriptableRenderContext HJIAOGEIAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7BE89A0", Offset = "0x7BE75A0", VA = "0x187BE89A0")]
	private static void FOMFCPOKMKM(int BKHPAFHMEJO, CommandBuffer KLHMGKEFLPH, RenderBuffer JMMCKBNEPKA, ComputeBuffer JGOCDJCGAND, ComputeShader KCANADINKCD, int LIGLLJGMJJK, int OMAFPBMGOGO, int IEABHAPGEPN, int EIOIFINFCHA, int GHECADJMCLJ, int GEGEMPAKNCJ, int BJGDCKGJFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7BE8380", Offset = "0x7BE6F80", VA = "0x187BE8380")]
	public void ALFFKJNPKFH(CommandBuffer KLHMGKEFLPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7BE8ED0", Offset = "0x7BE7AD0", VA = "0x187BE8ED0")]
	private RenderTexture KLBKIJEDDGF(RenderTexture ODONPGPNIIA, int LIGLLJGMJJK, int OMAFPBMGOGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7BE8920", Offset = "0x7BE7520", VA = "0x187BE8920")]
	public void EFFJJLEHHGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7BE8690", Offset = "0x7BE7290", VA = "0x187BE8690")]
	public void CIGGDHGANHH(int DLEOKFIOOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7BE9540", Offset = "0x7BE8140", VA = "0x187BE9540")]
	public PDKBDFGJMBN()
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
		public struct MCHHJJKEAFN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float KMPNCJMCPJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float JBHIGIJABMH;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class GHOBLOLEBGA : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string BONJDJNBEMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler NKOBCBCJAKK;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int ONHJGAJAJNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material HLGKEHFCOMA;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7BE1800", Offset = "0x7BE0400", VA = "0x187BE1800")]
			public GHOBLOLEBGA(RenderPassEvent LGCDAMLMEBP, Material LBEFIBKFEIP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7BE1430", Offset = "0x7BE0030", VA = "0x187BE1430", Slot = "9")]
			public override void Execute(ScriptableRenderContext HJIAOGEIAJO, RenderingData JCFGFMDCKBA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static MCHHJJKEAFN CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private GHOBLOLEBGA m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x7BE4A90", Offset = "0x7BE3690", VA = "0x187BE4A90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7BE4A40", Offset = "0x7BE3640", VA = "0x187BE4A40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4890", Offset = "0x7BE3490", VA = "0x187BE4890", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7BE47C0", Offset = "0x7BE33C0", VA = "0x187BE47C0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer HHBLCPHFAAG, RenderingData JCFGFMDCKBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1435B70", Offset = "0x1434770", VA = "0x181435B70")]
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
		public struct BHFIJNFMGIO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float OJGOJAHGLCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color COJFBINLBFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh DMJKFDKMAEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve FADDHJGEGOP;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class JPLJIPFOJPJ : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string BONJDJNBEMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler NKOBCBCJAKK;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int GPAAEKCLMGG;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int DMBCIANBMIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material HLGKEHFCOMA;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7BE1C10", Offset = "0x7BE0810", VA = "0x187BE1C10")]
			public JPLJIPFOJPJ(RenderPassEvent LGCDAMLMEBP, Material LBEFIBKFEIP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7BE1970", Offset = "0x7BE0570", VA = "0x187BE1970", Slot = "9")]
			public override void Execute(ScriptableRenderContext HJIAOGEIAJO, RenderingData JCFGFMDCKBA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static BHFIJNFMGIO CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private JPLJIPFOJPJ m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x7BE4DA0", Offset = "0x7BE39A0", VA = "0x187BE4DA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4BF0", Offset = "0x7BE37F0", VA = "0x187BE4BF0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4AE0", Offset = "0x7BE36E0", VA = "0x187BE4AE0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer HHBLCPHFAAG, RenderingData JCFGFMDCKBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1435B70", Offset = "0x1434770", VA = "0x181435B70")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string KDCHCKJCNAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool LAJANGNBGOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer KLHMGKEFLPH, ScriptableRenderContext HJIAOGEIAJO, RenderingData JCFGFMDCKBA);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x959590", Offset = "0x958190", VA = "0x180959590")]
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
		private class NCOPCNIBIME : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool FKHGMCNFMMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> DCANCMOGAHE;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> FCJCOKECILI;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7BE5410", Offset = "0x7BE4010", VA = "0x187BE5410")]
			public NCOPCNIBIME(RenderPassEvent LGCDAMLMEBP, bool FKHGMCNFMMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7BE4DF0", Offset = "0x7BE39F0", VA = "0x187BE4DF0")]
			public bool CIKLMOOKNGA(CameraData GIJGHEMJNNB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7BE51B0", Offset = "0x7BE3DB0", VA = "0x187BE51B0", Slot = "9")]
			public override void Execute(ScriptableRenderContext HJIAOGEIAJO, RenderingData JCFGFMDCKBA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7BE50D0", Offset = "0x7BE3CD0", VA = "0x187BE50D0")]
			private void DJHIIHDNPOP(PerCameraRenderEffect OGLACPILOJJ, ScriptableRenderContext HJIAOGEIAJO, RenderingData JCFGFMDCKBA)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private NCOPCNIBIME m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private NCOPCNIBIME m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7BE9EF0", Offset = "0x7BE8AF0", VA = "0x187BE9EF0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7BE9E60", Offset = "0x7BE8A60", VA = "0x187BE9E60", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer HHBLCPHFAAG, RenderingData JCFGFMDCKBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1435B70", Offset = "0x1434770", VA = "0x181435B70")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BE9FA0", Offset = "0x7BE8BA0", VA = "0x187BE9FA0")]
		public static void ANCLHBJKBNK(ScriptableRenderPass LBILIMGCPKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7BEA080", Offset = "0x7BE8C80", VA = "0x187BEA080", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer HHBLCPHFAAG, RenderingData JCFGFMDCKBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1435B70", Offset = "0x1434770", VA = "0x181435B70")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class NDBAONDLJLP
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 AIPMGCDNEAI;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 IDKELAGDDIE;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 PDGGIPGJBGG;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 LONIBKMNDPD;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 GGGCKCMPLNK;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7BE54C0", Offset = "0x7BE40C0", VA = "0x187BE54C0")]
	public static uint DJGLEGPMOBO(uint MDFKHKOGFDI, uint ELJEANFLEPB, uint DLEGJEODNMB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7BE54D0", Offset = "0x7BE40D0", VA = "0x187BE54D0")]
	public static uint3 EEHGHPMDAFF(float3 FCININPMBGJ, float3 MOOHMGODMAC, float3 HEBHDAPCOIG)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5860", Offset = "0x7BE4460", VA = "0x187BE5860")]
	public static void KODCNKCDBCA(float3 GHAABOEFOJK, float3 AHINBKHDOFH, float3 HPKCDADJJEI, float GHONGHPPDGL, [Out] uint3 NJFKOCCAAAA, [Out] uint3 KEMAIHMPGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5AA0", Offset = "0x7BE46A0", VA = "0x187BE5AA0")]
	public static void NAJNGNLGPCE(float3 OOGLFOINICJ, float3 KBEKKACAHIF, float OKCFDJGMALL, float BOFPLHLKLLF, [Out] float3 PFBJDGCBOCL, [Out] float GHONGHPPDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7BE56C0", Offset = "0x7BE42C0", VA = "0x187BE56C0")]
	private static float3 FMMCMJAFJPN(float3 IAOBIBILJKC, float3 OMAIHAHDPDN, float3 GIODNHGHAPI, float3 OJKPCMPPIEL)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class ACLDEIJBKBM
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly NDNFAPMFFIF LHCPGHGBDCO;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly NDNFAPMFFIF HDFMPFBHJIO;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly NDNFAPMFFIF KPHADPOAGKD;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly NDNFAPMFFIF NEFENGEPPIA;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly NDNFAPMFFIF NFFFDKJJGFE;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class PIOLIOHAJHK
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh HIBBFBKCPBG;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7BE9560", Offset = "0x7BE8160", VA = "0x187BE9560")]
	public static Mesh ACAMNBMIAIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7BE99C0", Offset = "0x7BE85C0", VA = "0x187BE99C0")]
	public static Matrix4x4 NBGKMADGEPP(Camera CBLDONJIECH, bool CNPOCGCFAPI = false, bool CAHFBBDJGHM = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7BE9600", Offset = "0x7BE8200", VA = "0x187BE9600")]
	private static Mesh AEHNHPHCAJC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__781554493
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB560", Offset = "0x7BEA160", VA = "0x187BEB560")]
	public static void GJEHIDHJLAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB550", Offset = "0x7BEA150", VA = "0x187BEB550")]
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
