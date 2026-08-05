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
	public class LogRegistrationIndex : LLMIPJJKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x88DC060", Offset = "0x88DAE60", VA = "0x1888DC060", Slot = "4")]
		public override void HIMDKAKGPHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		public enum KKGICLOBCLM
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface EDGAJKECHKO
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void BFLCGMAIILH(ScriptableRenderContext IEOOLFDDEEF, List<Camera> ABKGDJJCDJG);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface FJFDMACEMLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void BFLCGMAIILH(ScriptableRenderContext IEOOLFDDEEF, RenderingData IEIECJKAOLJ);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class DNHKHBKCILC : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x88D6820", Offset = "0x88D5620", VA = "0x1888D6820")]
			public DNHKHBKCILC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x88D67C0", Offset = "0x88D55C0", VA = "0x1888D67C0", Slot = "9")]
			public override void Execute(ScriptableRenderContext IEOOLFDDEEF, RenderingData IEIECJKAOLJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private DNHKHBKCILC _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<EDGAJKECHKO> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<EDGAJKECHKO> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<FJFDMACEMLK> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<FJFDMACEMLK> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x88DE9D0", Offset = "0x88DD7D0", VA = "0x1888DE9D0")]
		public static void KFBOBBJKCNE(KKGICLOBCLM MNMHOBEFAAL, EDGAJKECHKO DPMECDCBNBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x88DDE80", Offset = "0x88DCC80", VA = "0x1888DDE80")]
		public static void GAKBMLCJNBK(KKGICLOBCLM MNMHOBEFAAL, EDGAJKECHKO DPMECDCBNBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x88DE910", Offset = "0x88DD710", VA = "0x1888DE910")]
		public static void KFBOBBJKCNE(KKGICLOBCLM MNMHOBEFAAL, FJFDMACEMLK FPOEDMLOKJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x88DDDC0", Offset = "0x88DCBC0", VA = "0x1888DDDC0")]
		public static void GAKBMLCJNBK(KKGICLOBCLM MNMHOBEFAAL, FJFDMACEMLK FPOEDMLOKJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x88DDA50", Offset = "0x88DC850", VA = "0x1888DDA50", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x88DD9A0", Offset = "0x88DC7A0", VA = "0x1888DD9A0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MIFBMDMJHAH, RenderingData IEIECJKAOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x88DDC40", Offset = "0x88DCA40", VA = "0x1888DDC40", Slot = "9")]
		protected override void Dispose(bool DLBGJLLIBEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x88DE410", Offset = "0x88DD210", VA = "0x1888DE410")]
		private static void HPJOEODLEAG(ScriptableRenderContext IEOOLFDDEEF, List<Camera> ABKGDJJCDJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x88DDD50", Offset = "0x88DCB50", VA = "0x1888DDD50")]
		private static void FEIIEBFMKOK(ScriptableRenderContext IEOOLFDDEEF, List<Camera> ABKGDJJCDJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x88DDF40", Offset = "0x88DCD40", VA = "0x1888DDF40")]
		private static void GGMGOJOCIDA(ScriptableRenderContext IEOOLFDDEEF, RenderingData IEIECJKAOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x186CAB0", Offset = "0x186B8B0", VA = "0x18186CAB0")]
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
		private class BPOPMDGKAFA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool NIOLGNGFKMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<KDKGDCGKNIL> BFGLGMGEHJL;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x88D4E60", Offset = "0x88D3C60", VA = "0x1888D4E60")]
			public BPOPMDGKAFA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class NIEBOOCOJBO : PreRenderManager.FJFDMACEMLK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string NLHJFMDDBBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler PHMBOBGJOON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly BPOPMDGKAFA KLFHIKMIHBL;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x88DD020", Offset = "0x88DBE20", VA = "0x1888DD020")]
			public NIEBOOCOJBO(BPOPMDGKAFA OAKGHOAIMAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x88DCC10", Offset = "0x88DBA10", VA = "0x1888DCC10", Slot = "4")]
			public void BFLCGMAIILH(ScriptableRenderContext IEOOLFDDEEF, RenderingData IEIECJKAOLJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class FJEOIBLEIBM : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string EPLHABMICNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly BPOPMDGKAFA OAKGHOAIMAD;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x88D6B50", Offset = "0x88D5950", VA = "0x1888D6B50")]
			public FJEOIBLEIBM(RenderPassEvent CCJDFKPDEOH, BPOPMDGKAFA OAKGHOAIMAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x88D6840", Offset = "0x88D5640", VA = "0x1888D6840", Slot = "9")]
			public override void Execute(ScriptableRenderContext IEOOLFDDEEF, RenderingData IEIECJKAOLJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<KDKGDCGKNIL> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private NIEBOOCOJBO fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private FJEOIBLEIBM fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private BPOPMDGKAFA sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x88D6CD0", Offset = "0x88D5AD0", VA = "0x1888D6CD0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x88D7060", Offset = "0x88D5E60", VA = "0x1888D7060", Slot = "9")]
		protected override void Dispose(bool DLBGJLLIBEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x88D6C30", Offset = "0x88D5A30", VA = "0x1888D6C30", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MIFBMDMJHAH, RenderingData IEIECJKAOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x186CAB0", Offset = "0x186B8B0", VA = "0x18186CAB0")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KDKGDCGKNIL
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IDFBJLEPNKJ(CommandBuffer ONGOOGFIEKF, Camera NODAPINLHKL, [NotNull] UniversalAdditionalCameraData JBCMDHNBJMJ, bool EBHIIBKMHGH);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BMJBBOAKJIJ(Camera NODAPINLHKL, CommandBuffer NFNJLJCKIKE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class EIHPFCKBMAD
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool GOKKKEJJMNM;
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
		private LLBAIFBCIGB _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private HJPOLPLDOOG _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x88DBD30", Offset = "0x88DAB30", VA = "0x1888DBD30", Slot = "9")]
		protected override void Dispose(bool PKPMEDDMNHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x88DBDA0", Offset = "0x88DABA0", VA = "0x1888DBDA0")]
		private void JPHDICKKPHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x88DB9E0", Offset = "0x88DA7E0", VA = "0x1888DB9E0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MIFBMDMJHAH, RenderingData IEIECJKAOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x186CAB0", Offset = "0x186B8B0", VA = "0x18186CAB0")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KEBMMPNNDAG
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x88D9AA0", Offset = "0x88D88A0", VA = "0x1888D9AA0")]
	public static int JOCPLMNICBM(bool MDIMJBFLOGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1D4C6F0", Offset = "0x1D4B4F0", VA = "0x181D4C6F0")]
	public static int JBBMPLPOHNE(bool MDIMJBFLOGO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct HKBCFADBPFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType LIMAPFCHNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float JJGDOLNLOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float FANOBLNBIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float LGACOAONLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 JHDBBOAJIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 KBLCFJFGMAC;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct PNBKFJAEAOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort HJIPDIEMDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float KFMANPAEBHC;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct BNODCFHPPCH : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<HKBCFADBPFO> LFBJNNIEMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 IILHMJEIEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 IILFCMMPGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, PNBKFJAEAOE>.ParallelWriter FEAAGFCAILA;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x88D42A0", Offset = "0x88D30A0", VA = "0x1888D42A0", Slot = "4")]
	public void Execute(int HJIPDIEMDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x88D3F30", Offset = "0x88D2D30", VA = "0x1888D3F30")]
	private void BOCBFLIIDEA(uint3 LMMFEKJFMDF, uint3 HBFOLDDCLCI, ushort HJIPDIEMDEK, float3 EAMFPOPFAFK, float KMPKMJIKECI, float HEMNMCKGGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x88D4990", Offset = "0x88D3790", VA = "0x1888D4990")]
	private void MJAKNBPIHDJ(uint3 LMMFEKJFMDF, uint3 HBFOLDDCLCI, ushort HJIPDIEMDEK, float3 EAMFPOPFAFK, float3 LMJGPGLAHCI, float3 CINNPCILLMB, float KMPKMJIKECI, float KOAFPCOFIJG, float HEMNMCKGGPL, float OELAFGFLGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x88D48A0", Offset = "0x88D36A0", VA = "0x1888D48A0")]
	private float3 LOPLHJJLIJD(uint3 LMMFEKJFMDF, float3 EAMFPOPFAFK)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x88D4E40", Offset = "0x88D3C40", VA = "0x1888D4E40")]
	private float OBOILNKCHOD(float JJGDOLNLOOF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x88D47E0", Offset = "0x88D35E0", VA = "0x1888D47E0")]
	private float GPJCOJAIHAL(float3 JPDKANNPHJO, float3 CINNPCILLMB, float KOAFPCOFIJG, float HEMNMCKGGPL)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct OMIADDPBGEI : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, PNBKFJAEAOE> FEAAGFCAILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint MBDNHPGNLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int GIHKNBJAJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int EGFKFFBOKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> LNDHLFHLLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> MCPJEIEMAFG;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x88DD250", Offset = "0x88DC050", VA = "0x1888DD250", Slot = "4")]
	public void Execute(int PHEPBDLOAKN, int CDAGHKJHCOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x88DD0E0", Offset = "0x88DBEE0", VA = "0x1888DD0E0")]
	private void ENBCKFNOPCK(int MGEAGNOCPMA, ushort BKBIKEDNNFA, int GGHMAPMABPG, PNBKFJAEAOE AGLKJNPGJHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct ANCNOEBPKLJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, PNBKFJAEAOE> FEAAGFCAILA;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x88D3EF0", Offset = "0x88D2CF0", VA = "0x1888D3EF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LLBAIFBCIGB : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool MEAENKOFGAH;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float JKMHLCNKNEP = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int OLFLJJKEMJP = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int OCDEMHPNDIC = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private BNODCFHPPCH NJBFEHAEKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private OMIADDPBGEI DOLAMGLDDFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private ANCNOEBPKLJ AMEIODDGJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, PNBKFJAEAOE> DKKNKGPBOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private CHLCAPFKCGH DNIHKMGGJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool NOBCDCFAFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int LNPFMFCADKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<HKBCFADBPFO> KAHALLHLGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle HMDIFFPOICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle GEAJDIGDLJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool IODMNIEBOCH;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x88DB930", Offset = "0x88DA730", VA = "0x1888DB930")]
	public LLBAIFBCIGB(RenderPassEvent CCJDFKPDEOH, ComputeShader CEDGBLCKLAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x88DB250", Offset = "0x88DA050", VA = "0x1888DB250")]
	private void KHNOCLOPEIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x88DAA50", Offset = "0x88D9850", VA = "0x1888DAA50")]
	public void CGKANNEECOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3C588C0", Offset = "0x3C576C0", VA = "0x183C588C0")]
	public static void PAFNMIBAHCH<T>(NativeArray<T> COPOPHFGNFG, int DFCCCGNJINK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x88DAB30", Offset = "0x88D9930", VA = "0x1888DAB30")]
	public void COIHOFBJOED(CameraData JBCMDHNBJMJ, LightData OJODIBFELOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x88DB470", Offset = "0x88DA270", VA = "0x1888DB470")]
	private void OKNHOBFLMNP(LightData OJODIBFELOA, NativeArray<HKBCFADBPFO> ILLMJEJCCGE, int JACIJKECOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x88DB010", Offset = "0x88D9E10", VA = "0x1888DB010")]
	private void KECNPCKCDPD(CameraData JBCMDHNBJMJ, LightData OJODIBFELOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x88DB2C0", Offset = "0x88DA0C0", VA = "0x1888DB2C0")]
	private void LEIMOMPOOCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x88DB7B0", Offset = "0x88DA5B0", VA = "0x1888DB7B0")]
	private void OLNDKNINKEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x88DB450", Offset = "0x88DA250", VA = "0x1888DB450")]
	private void MAIINKHLGGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x88DAEE0", Offset = "0x88D9CE0", VA = "0x1888DAEE0")]
	private void DFFJDJBHHLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x88DAF10", Offset = "0x88D9D10", VA = "0x1888DAF10", Slot = "9")]
	public override void Execute(ScriptableRenderContext IEOOLFDDEEF, RenderingData IEIECJKAOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x88DB8B0", Offset = "0x88DA6B0", VA = "0x1888DB8B0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer NFNJLJCKIKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class HJPOLPLDOOG : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort OPECLHJFIDE = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float JKMHLCNKNEP = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly CHLCAPFKCGH DNIHKMGGJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int NHFJMHOHDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private HKBCFADBPFO[] KAHALLHLGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 FKJODDIKECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 CCHKBCPOOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint OIFANJMBFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int DNNNPBACMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int GKDFGFDALJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> LNDHLFHLLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> MCPJEIEMAFG;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x88D90E0", Offset = "0x88D7EE0", VA = "0x1888D90E0")]
	public HJPOLPLDOOG(RenderPassEvent CCJDFKPDEOH, ComputeShader CEDGBLCKLAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x88D77D0", Offset = "0x88D65D0", VA = "0x1888D77D0")]
	public void COIHOFBJOED(CameraData JBCMDHNBJMJ, LightData OJODIBFELOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x88D8B60", Offset = "0x88D7960", VA = "0x1888D8B60")]
	private void NJCIDLOAKJO(CameraData JBCMDHNBJMJ, LightData OJODIBFELOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x88D77B0", Offset = "0x88D65B0", VA = "0x1888D77B0")]
	public void CGKANNEECOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x88D8D60", Offset = "0x88D7B60", VA = "0x1888D8D60")]
	private void OKNHOBFLMNP(LightData OJODIBFELOA, HKBCFADBPFO[] ILLMJEJCCGE, int JACIJKECOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x88D8560", Offset = "0x88D7360", VA = "0x1888D8560")]
	private void MCOJBDLMCNB(int PHEPBDLOAKN, int CDAGHKJHCOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x88D8430", Offset = "0x88D7230", VA = "0x1888D8430")]
	private void KFMMEMKMGCN(int PHEPBDLOAKN, int LJEIHABMGGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x88D7C20", Offset = "0x88D6A20", VA = "0x1888D7C20")]
	private ushort IOPJPNAPAIJ(int PHEPBDLOAKN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x88D7940", Offset = "0x88D6740", VA = "0x1888D7940")]
	private void DGCHFPMHHMN(int PHEPBDLOAKN, int CDAGHKJHCOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x88D8210", Offset = "0x88D7010", VA = "0x1888D8210")]
	private void JMPHPJNJBLH(int DFCCCGNJINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x88D8280", Offset = "0x88D7080", VA = "0x1888D8280")]
	private void JOOMBEGAHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x88D7B40", Offset = "0x88D6940", VA = "0x1888D7B40", Slot = "9")]
	public override void Execute(ScriptableRenderContext IEOOLFDDEEF, RenderingData IEIECJKAOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x88D90B0", Offset = "0x88D7EB0", VA = "0x1888D90B0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer NFNJLJCKIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x88D7C60", Offset = "0x88D6A60", VA = "0x1888D7C60")]
	private void JGOADNEGGPA(int HJIPDIEMDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x88D73A0", Offset = "0x88D61A0", VA = "0x1888D73A0")]
	private void BOCBFLIIDEA(uint3 LMMFEKJFMDF, uint3 HBFOLDDCLCI, ushort HJIPDIEMDEK, float3 EAMFPOPFAFK, float KMPKMJIKECI, float HEMNMCKGGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x88D8610", Offset = "0x88D7410", VA = "0x1888D8610")]
	private void MJAKNBPIHDJ(uint3 LMMFEKJFMDF, uint3 HBFOLDDCLCI, ushort HJIPDIEMDEK, float3 EAMFPOPFAFK, float3 LMJGPGLAHCI, float3 CINNPCILLMB, float KMPKMJIKECI, float KOAFPCOFIJG, float HEMNMCKGGPL, float OELAFGFLGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x88D8340", Offset = "0x88D7140", VA = "0x1888D8340")]
	private void KBEGJLJCJKN(ushort HJIPDIEMDEK, uint OJBAGKIBJDH, float LPKGCJPIBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x88D8460", Offset = "0x88D7260", VA = "0x1888D8460")]
	private float3 LOPLHJJLIJD(uint3 LMMFEKJFMDF, float3 EAMFPOPFAFK)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x88D4E40", Offset = "0x88D3C40", VA = "0x1888D4E40")]
	private float OBOILNKCHOD(float JJGDOLNLOOF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x88D47E0", Offset = "0x88D35E0", VA = "0x1888D47E0")]
	private float GPJCOJAIHAL(float3 JPDKANNPHJO, float3 CINNPCILLMB, float KOAFPCOFIJG, float HEMNMCKGGPL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x88D79B0", Offset = "0x88D67B0", VA = "0x1888D79B0")]
	private void ENBCKFNOPCK(int MGEAGNOCPMA, ushort BKBIKEDNNFA, int GGHMAPMABPG, PNBKFJAEAOE AGLKJNPGJHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class CHLCAPFKCGH
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class PONOKBKAOPK
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int GGGOAAPCBHK;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int ELKPCFFPOKL;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int DOFMMNGBLFA;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int CAMFBOKGHIJ;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int LNJAIEAOICO;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int HHBOKOHEOOO;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int AMHKNLIKNGI;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int JHOLIKHCJGN = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int GKPPEEEJFEO = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int OCDPNFNPMDN = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int PHOHOBECFFM = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int HMAJHAMKEMO = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int DCLFHGGONFM = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int DKGFHHHBHHC = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool FJBHIFFEDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer KOOLKFCHJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture GCEKPKNDDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int BMDIKEIBJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int KPKCHLHLCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int OPMHNOELIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int KDFPANCOCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int NNDHIKNCHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader ICDHJCFMIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int JEHLBJCFHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int LDKIADHCKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 PKOLDNBDHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 LLDCEMFKIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> GIHBOBILCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> DNGIDMDBHKN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> DHDOJEJMJFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5274340", Offset = "0x5273140", VA = "0x185274340")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> PLOPKCDBDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x12B58D0", Offset = "0x12B46D0", VA = "0x1812B58D0")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int PFDNALCGNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAA74E0", Offset = "0xAA62E0", VA = "0x180AA74E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int PCNACHFAMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA5A420", Offset = "0xA59220", VA = "0x180A5A420")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader OGGKMOABLOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x88D50D0", Offset = "0x88D3ED0", VA = "0x1888D50D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x88D5780", Offset = "0x88D4580", VA = "0x1888D5780")]
	public void LEFDKMKGENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x88D51E0", Offset = "0x88D3FE0", VA = "0x1888D51E0")]
	public void IJIPAEFLBMP(CameraData JBCMDHNBJMJ, LightData OJODIBFELOA, int ODMEHDPDCJH, bool MDIMJBFLOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3996790", Offset = "0x3995590", VA = "0x183996790")]
	private void PAFNMIBAHCH<T>(NativeArray<T> COPOPHFGNFG, int DFCCCGNJINK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x88D5D70", Offset = "0x88D4B70", VA = "0x1888D5D70")]
	public void PGKBMJMKJKI(CommandBuffer NFNJLJCKIKE, ScriptableRenderContext IEOOLFDDEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x88D5870", Offset = "0x88D4670", VA = "0x1888D5870")]
	private static void MBADOLMMNGF(int DCCGHBNLDGD, CommandBuffer NFNJLJCKIKE, RenderBuffer NMKFJIGNPNM, ComputeBuffer JKCFLBPGEGC, ComputeShader HGIJIPOGFOA, int PCBEBONEPHP, int LGCKCIMIHGA, int PLLEANBKDMK, int OPPAAMLJFGA, int HGNIHIENBOL, int JFDIDJHKFJC, int JKMBPBGPKGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x88D5A50", Offset = "0x88D4850", VA = "0x1888D5A50")]
	public void OKNBOPEOEKJ(CommandBuffer NFNJLJCKIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x88D4EF0", Offset = "0x88D3CF0", VA = "0x1888D4EF0")]
	private RenderTexture BMJIHPNJLIF(RenderTexture MCKGDEEKKAE, int PCBEBONEPHP, int LGCKCIMIHGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x88D5160", Offset = "0x88D3F60", VA = "0x1888D5160")]
	public void HENOHGGKPCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x88D54F0", Offset = "0x88D42F0", VA = "0x1888D54F0")]
	public void LAJOMDLPHOE(int JIDAKNCMECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x88D60C0", Offset = "0x88D4EC0", VA = "0x1888D60C0")]
	public CHLCAPFKCGH()
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
		public struct LFLKIABAMDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float GFHPJJJAGJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float MEJNDODNNLO;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class MONBHIEOMCF : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string LGKDNBMMAEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler GDPJGIINMCI;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int LIDHEFAMMDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material ANIGKLDPPNA;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x88DC4D0", Offset = "0x88DB2D0", VA = "0x1888DC4D0")]
			public MONBHIEOMCF(RenderPassEvent CCJDFKPDEOH, Material KKBOKCGIENM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x88DC0F0", Offset = "0x88DAEF0", VA = "0x1888DC0F0", Slot = "9")]
			public override void Execute(ScriptableRenderContext IEOOLFDDEEF, RenderingData IEIECJKAOLJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static LFLKIABAMDC CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private MONBHIEOMCF m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x88DC880", Offset = "0x88DB680", VA = "0x1888DC880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x88DC830", Offset = "0x88DB630", VA = "0x1888DC830")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x88DC680", Offset = "0x88DB480", VA = "0x1888DC680", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x88DC5B0", Offset = "0x88DB3B0", VA = "0x1888DC5B0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MIFBMDMJHAH, RenderingData IEIECJKAOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x186CAB0", Offset = "0x186B8B0", VA = "0x18186CAB0")]
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
		public struct LMEPNPCNJMI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float CDLEHGBCBDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color CDCPPHKGAII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh EKCDPBALFJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve PNOHBKIPNFL;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class KGOHNLJLDGN : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string LGKDNBMMAEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler GDPJGIINMCI;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int HOOHIEAAELD;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int FMHMLCGGICI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material ANIGKLDPPNA;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x88D9D70", Offset = "0x88D8B70", VA = "0x1888D9D70")]
			public KGOHNLJLDGN(RenderPassEvent CCJDFKPDEOH, Material KKBOKCGIENM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x88D9AB0", Offset = "0x88D88B0", VA = "0x1888D9AB0", Slot = "9")]
			public override void Execute(ScriptableRenderContext IEOOLFDDEEF, RenderingData IEIECJKAOLJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static LMEPNPCNJMI CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private KGOHNLJLDGN m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x88DCBB0", Offset = "0x88DB9B0", VA = "0x1888DCBB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x88DCA00", Offset = "0x88DB800", VA = "0x1888DCA00", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x88DC8E0", Offset = "0x88DB6E0", VA = "0x1888DC8E0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MIFBMDMJHAH, RenderingData IEIECJKAOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x186CAB0", Offset = "0x186B8B0", VA = "0x18186CAB0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string POKDKCNPBKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool ODBPJAMPCGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer NFNJLJCKIKE, ScriptableRenderContext IEOOLFDDEEF, RenderingData IEIECJKAOLJ);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
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
		private class DIJCADLFPDI : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool BEOKBOHEGNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> IFJGLAEELKP;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> OBEMPAHGJME;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x88D6710", Offset = "0x88D5510", VA = "0x1888D6710")]
			public DIJCADLFPDI(RenderPassEvent CCJDFKPDEOH, bool BEOKBOHEGNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x88D60E0", Offset = "0x88D4EE0", VA = "0x1888D60E0")]
			public bool BEAFHACIJMN(CameraData JBCMDHNBJMJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x88D64B0", Offset = "0x88D52B0", VA = "0x1888D64B0", Slot = "9")]
			public override void Execute(ScriptableRenderContext IEOOLFDDEEF, RenderingData IEIECJKAOLJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x88D63D0", Offset = "0x88D51D0", VA = "0x1888D63D0")]
			private void BGILGDDIBLO(PerCameraRenderEffect FEHBOGAAAEP, ScriptableRenderContext IEOOLFDDEEF, RenderingData IEIECJKAOLJ)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private DIJCADLFPDI m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private DIJCADLFPDI m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x88DD5E0", Offset = "0x88DC3E0", VA = "0x1888DD5E0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x88DD550", Offset = "0x88DC350", VA = "0x1888DD550", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MIFBMDMJHAH, RenderingData IEIECJKAOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x186CAB0", Offset = "0x186B8B0", VA = "0x18186CAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x88DD830", Offset = "0x88DC630", VA = "0x1888DD830")]
		public static void MBJLKLNNILJ(ScriptableRenderPass FKFDMKMMBIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x88DD690", Offset = "0x88DC490", VA = "0x1888DD690", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MIFBMDMJHAH, RenderingData IEIECJKAOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x186CAB0", Offset = "0x186B8B0", VA = "0x18186CAB0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class KMCGMIEKMKK
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 NKGNMNPDHOP;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 GPKCPJHAONN;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 EJFLDGFFBOM;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 PPAHFOOKIDD;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 GKKEEGODGBC;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x88D9E50", Offset = "0x88D8C50", VA = "0x1888D9E50")]
	public static uint AEFAAEJEHOP(uint DHOMBGCEEAK, uint EDBCCDDDLPI, uint OIBFEOGMFMP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x88D9E60", Offset = "0x88D8C60", VA = "0x1888D9E60")]
	public static uint3 AFEEJJEMDAC(float3 EMECBHNHILC, float3 IILHMJEIEIN, float3 IILFCMMPGPB)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x88DA6D0", Offset = "0x88D94D0", VA = "0x1888DA6D0")]
	public static void PAAOPBLCDCO(float3 MKFKLHGPLGM, float3 OMNNGILHNNE, float3 OOGCMAGOBDM, float LNLGAMEGNNM, [Out] uint3 FBOMDNPHHKO, [Out] uint3 OOCDCHDBLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x88DA060", Offset = "0x88D8E60", VA = "0x1888DA060")]
	public static void KNJKPKKCKOB(float3 IGAIPHHLOFM, float3 JJJKPBKLDMG, float FANOBLNBIII, float CGHLMLIBCMJ, [Out] float3 KNIALLIIKDG, [Out] float LNLGAMEGNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x88DA530", Offset = "0x88D9330", VA = "0x1888DA530")]
	private static float3 NKFMJHCDBFB(float3 PJDMLBHJNLB, float3 FHKBEIHFELD, float3 JBDDDLLDENL, float3 CPKJEHALJKN)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class GAFONEEOJPH
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly PHLHEDGDBJO GIJJGCFHFNB;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly PHLHEDGDBJO HNPCMFMGLGL;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly PHLHEDGDBJO CFHGJKBMGLM;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly PHLHEDGDBJO OPDBHMLKFPM;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly PHLHEDGDBJO JOIJBDCIFMP;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class JBHOAHIHHGG
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh BKJCHLMPPJK;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x88D99F0", Offset = "0x88D87F0", VA = "0x1888D99F0")]
	public static Mesh GOEPBPCHFKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x88D9550", Offset = "0x88D8350", VA = "0x1888D9550")]
	public static Matrix4x4 GBKNDNIAGJA(Camera NODAPINLHKL, bool GEOMDOOBMDK = false, bool FGFLPELHMBO = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x88D9190", Offset = "0x88D7F90", VA = "0x1888D9190")]
	private static Mesh GABDIEOGKFM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__387840619
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x88DECD0", Offset = "0x88DDAD0", VA = "0x1888DECD0")]
	public static void KJKFPIHJHAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x88DECC0", Offset = "0x88DDAC0", VA = "0x1888DECC0")]
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
