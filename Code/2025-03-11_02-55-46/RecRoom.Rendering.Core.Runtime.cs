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
	public class LogRegistrationIndex : KENHJELJHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7D41DF0", Offset = "0x7D411F0", VA = "0x187D41DF0", Slot = "4")]
		public override void ICLMLJMBJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
		public enum PLNOBCHALHI
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface FDDOAGCEEEB
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void HPGKBBIDPFC(ScriptableRenderContext MEBLJIBNLCL, List<Camera> BDJFEHOLOOK);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface IJKABKHDLML
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void HPGKBBIDPFC(ScriptableRenderContext MEBLJIBNLCL, RenderingData DHDEOKFNBBF);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class IKHFBJLFLKD : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7D41190", Offset = "0x7D40590", VA = "0x187D41190")]
			public IKHFBJLFLKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7D41130", Offset = "0x7D40530", VA = "0x187D41130", Slot = "9")]
			public override void Execute(ScriptableRenderContext MEBLJIBNLCL, RenderingData DHDEOKFNBBF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private IKHFBJLFLKD _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<FDDOAGCEEEB> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<FDDOAGCEEEB> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<IJKABKHDLML> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<IJKABKHDLML> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D45360", Offset = "0x7D44760", VA = "0x187D45360")]
		public static void IBCAKPCPBGB(PLNOBCHALHI EBAGNFMLIHO, FDDOAGCEEEB BPOLOBLDFOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7D45170", Offset = "0x7D44570", VA = "0x187D45170")]
		public static void EPICFCLBILA(PLNOBCHALHI EBAGNFMLIHO, FDDOAGCEEEB BPOLOBLDFOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7D452A0", Offset = "0x7D446A0", VA = "0x187D452A0")]
		public static void IBCAKPCPBGB(PLNOBCHALHI EBAGNFMLIHO, IJKABKHDLML GFBFLDJMKLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7D450B0", Offset = "0x7D444B0", VA = "0x187D450B0")]
		public static void EPICFCLBILA(PLNOBCHALHI EBAGNFMLIHO, IJKABKHDLML GFBFLDJMKLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7D448E0", Offset = "0x7D43CE0", VA = "0x187D448E0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7D44840", Offset = "0x7D43C40", VA = "0x187D44840", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CJJNPFGBHFH, RenderingData DHDEOKFNBBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7D44AC0", Offset = "0x7D43EC0", VA = "0x187D44AC0", Slot = "9")]
		protected override void Dispose(bool ECBDGHGAGNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7D44BD0", Offset = "0x7D43FD0", VA = "0x187D44BD0")]
		private static void EJBPCOIAKIO(ScriptableRenderContext MEBLJIBNLCL, List<Camera> BDJFEHOLOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7D45230", Offset = "0x7D44630", VA = "0x187D45230")]
		private static void HLKCLKFNCMF(ScriptableRenderContext MEBLJIBNLCL, List<Camera> BDJFEHOLOOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7D45420", Offset = "0x7D44820", VA = "0x187D45420")]
		private static void LLFDDHBBAHH(ScriptableRenderContext MEBLJIBNLCL, RenderingData DHDEOKFNBBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x149E580", Offset = "0x149D980", VA = "0x18149E580")]
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
		private class AAHAEEHIEIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool BKGMKPIBHPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<NDLKJHFOOMD> MIOGOPGFIPP;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7D3AEF0", Offset = "0x7D3A2F0", VA = "0x187D3AEF0")]
			public AAHAEEHIEIE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class BMMBCJGCLAL : PreRenderManager.IJKABKHDLML
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string BFNGAMGDKOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler BJMOCKLLDBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly AAHAEEHIEIE IHEOFJMOCJO;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7D3B690", Offset = "0x7D3AA90", VA = "0x187D3B690")]
			public BMMBCJGCLAL(AAHAEEHIEIE ODALIANIAOO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7D3B290", Offset = "0x7D3A690", VA = "0x187D3B290", Slot = "4")]
			public void HPGKBBIDPFC(ScriptableRenderContext MEBLJIBNLCL, RenderingData DHDEOKFNBBF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class PFMHEMMNCFI : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string MDDOOEOICLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly AAHAEEHIEIE ODALIANIAOO;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7D44310", Offset = "0x7D43710", VA = "0x187D44310")]
			public PFMHEMMNCFI(RenderPassEvent ENFFEBBPLHB, AAHAEEHIEIE ODALIANIAOO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7D44000", Offset = "0x7D43400", VA = "0x187D44000", Slot = "9")]
			public override void Execute(ScriptableRenderContext MEBLJIBNLCL, RenderingData DHDEOKFNBBF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<NDLKJHFOOMD> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private BMMBCJGCLAL fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private PFMHEMMNCFI fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private AAHAEEHIEIE sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7D402C0", Offset = "0x7D3F6C0", VA = "0x187D402C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7D40640", Offset = "0x7D3FA40", VA = "0x187D40640", Slot = "9")]
		protected override void Dispose(bool ECBDGHGAGNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7D40230", Offset = "0x7D3F630", VA = "0x187D40230", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CJJNPFGBHFH, RenderingData DHDEOKFNBBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x149E580", Offset = "0x149D980", VA = "0x18149E580")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NDLKJHFOOMD
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool COELHDMBNPJ(CommandBuffer IODGGGINLKJ, Camera MNKAMPFEKFJ, [NotNull] UniversalAdditionalCameraData CEDBPJIOBAL, bool MOKDCELLIIP);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KOONNACDFEJ(Camera MNKAMPFEKFJ, CommandBuffer AMIFMKNCGGH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class KGAJONMJIFF
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool GNLHKGKNOHG;
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
		private ODEEDHGFJLC _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private EIFALJECFFF _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7D41AD0", Offset = "0x7D40ED0", VA = "0x187D41AD0", Slot = "9")]
		protected override void Dispose(bool IAFDGADLNOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7D41B40", Offset = "0x7D40F40", VA = "0x187D41B40")]
		private void OFLJAGDGNFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7D41780", Offset = "0x7D40B80", VA = "0x187D41780", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CJJNPFGBHFH, RenderingData DHDEOKFNBBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x149E580", Offset = "0x149D980", VA = "0x18149E580")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FHCFKICAIOD
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7D3DD30", Offset = "0x7D3D130", VA = "0x187D3DD30")]
	public static int EGJAKKFGKCJ(bool JDCBIGFINOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x192CB00", Offset = "0x192BF00", VA = "0x18192CB00")]
	public static int OAADLCNMOBG(bool JDCBIGFINOC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct GLNHPHLLJKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType ADJIHEFJNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float PCILBMOLECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float NBKCBIBCKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float HBCAHKFAPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 NAAPIMHNBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 HPKCAODINCI;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct OLIHDJFOKNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort MMAOHFNNDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float DJNHKJLLALM;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct FHGJEIJBLCL : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<GLNHPHLLJKG> KLCPIBEOMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 FEMCKDJFAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 NGPMOFNAOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, OLIHDJFOKNG>.ParallelWriter GFCJKGGHFIC;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7D3E1F0", Offset = "0x7D3D5F0", VA = "0x187D3E1F0", Slot = "4")]
	public void Execute(int MMAOHFNNDIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7D3E730", Offset = "0x7D3DB30", VA = "0x187D3E730")]
	private void JFPFIGCHNLH(uint3 FKBCGDOLPJC, uint3 GOHHLCJMFOG, ushort MMAOHFNNDIH, float3 GOADOIIMBAI, float COKDCALKEPD, float HINNKHGCPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7D3DD40", Offset = "0x7D3D140", VA = "0x187D3DD40")]
	private void EGKMMNFAMGL(uint3 FKBCGDOLPJC, uint3 GOHHLCJMFOG, ushort MMAOHFNNDIH, float3 GOADOIIMBAI, float3 OOHOKNDLNOA, float3 GOGAKLFNJLA, float COKDCALKEPD, float CLEKDCBBCGJ, float HINNKHGCPIB, float EBKNNOHFKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7D3EAA0", Offset = "0x7D3DEA0", VA = "0x187D3EAA0")]
	private float3 MCIFAHHOGFI(uint3 FKBCGDOLPJC, float3 GOADOIIMBAI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7D3C890", Offset = "0x7D3BC90", VA = "0x187D3C890")]
	private float FLGKPFKJCMB(float PCILBMOLECJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7D3D7C0", Offset = "0x7D3CBC0", VA = "0x187D3D7C0")]
	private float LEDMMFLHMPP(float3 HEHKBBKFNKB, float3 GOGAKLFNJLA, float CLEKDCBBCGJ, float HINNKHGCPIB)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct BJBLFFFDANI : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, OLIHDJFOKNG> GFCJKGGHFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint OKGAEMFNEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int CKCAIOOMAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int GLIBMLJLNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> EGKAJOOCAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> FJHMFFNGMPE;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7D3AF80", Offset = "0x7D3A380", VA = "0x187D3AF80", Slot = "4")]
	public void Execute(int LFPNCHIIFGL, int LEPLBLHEEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7D3B120", Offset = "0x7D3A520", VA = "0x187D3B120")]
	private void LKCIFKAPOHC(int LBDMHLCFPFC, ushort OHBBPJOMKEE, int KFFECMNGGAP, OLIHDJFOKNG GKIHLKOLEMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct EJJMHJOIOII : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, OLIHDJFOKNG> GFCJKGGHFIC;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7D3DCF0", Offset = "0x7D3D0F0", VA = "0x187D3DCF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class ODEEDHGFJLC : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool CPOMMBBMKEG;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float GAJFHCCJNGH = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int IIDGPPJIALN = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int JCKCDNKMAGB = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private FHGJEIJBLCL MAMDNHJIIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private BJBLFFFDANI JMNEIKJAEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private EJJMHJOIOII ECAEBPPFHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, OLIHDJFOKNG> ENBGKHCLDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private FODBOEGGPNP DIMDCOGOHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool CFCPNBIALEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int IMEPBINLEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<GLNHPHLLJKG> KKEOEKILCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle MOCIKMEEAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle MFABPJGOKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool KAEHJHKDGDK;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7D43F50", Offset = "0x7D43350", VA = "0x187D43F50")]
	public ODEEDHGFJLC(RenderPassEvent ENFFEBBPLHB, ComputeShader LDBNLLCJNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7D43560", Offset = "0x7D42960", VA = "0x187D43560")]
	private void FIBCCOMEHNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7D43990", Offset = "0x7D42D90", VA = "0x187D43990")]
	public void HIDFFHIDIHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3651EB0", Offset = "0x36512B0", VA = "0x183651EB0")]
	public static void MKGGHDNDGGJ<T>(NativeArray<T> PHAPILEGACC, int NBPEDBIONNC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7D435D0", Offset = "0x7D429D0", VA = "0x187D435D0")]
	public void GLAECIFNNPD(CameraData CEDBPJIOBAL, LightData ADAJDKOOEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7D43AA0", Offset = "0x7D42EA0", VA = "0x187D43AA0")]
	private void JFDMHLJHJOI(LightData ADAJDKOOEOK, NativeArray<GLNHPHLLJKG> JAOAJNDNDGM, int HFEDCGJKLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7D43220", Offset = "0x7D42620", VA = "0x187D43220")]
	private void EHPFHEGAGBF(CameraData CEDBPJIOBAL, LightData ADAJDKOOEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7D43090", Offset = "0x7D42490", VA = "0x187D43090")]
	private void BMLADFGMLJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7D43DE0", Offset = "0x7D431E0", VA = "0x187D43DE0")]
	private void OBDOOBFHMHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7D43970", Offset = "0x7D42D70", VA = "0x187D43970")]
	private void HECLNNCFNFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7D43A70", Offset = "0x7D42E70", VA = "0x187D43A70")]
	private void IBOEIJKGCJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7D43460", Offset = "0x7D42860", VA = "0x187D43460", Slot = "9")]
	public override void Execute(ScriptableRenderContext MEBLJIBNLCL, RenderingData DHDEOKFNBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7D43EE0", Offset = "0x7D432E0", VA = "0x187D43EE0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer AMIFMKNCGGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class EIFALJECFFF : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort HAFNEKPDLGJ = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float GAJFHCCJNGH = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly FODBOEGGPNP DIMDCOGOHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int LFHIMDJLCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private GLNHPHLLJKG[] KKEOEKILCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 ONAGGNKJPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 MOKMDDFIELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint CHGMNJIKBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int MALGJOCIDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int DOKFBHPKOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> EGKAJOOCAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> FJHMFFNGMPE;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7D3DC40", Offset = "0x7D3D040", VA = "0x187D3DC40")]
	public EIFALJECFFF(RenderPassEvent ENFFEBBPLHB, ComputeShader LDBNLLCJNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7D3C920", Offset = "0x7D3BD20", VA = "0x187D3C920")]
	public void GLAECIFNNPD(CameraData CEDBPJIOBAL, LightData ADAJDKOOEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7D3BEC0", Offset = "0x7D3B2C0", VA = "0x187D3BEC0")]
	private void DECOJEPHPMK(CameraData CEDBPJIOBAL, LightData ADAJDKOOEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7D3CA90", Offset = "0x7D3BE90", VA = "0x187D3CA90")]
	public void HIDFFHIDIHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7D3CAB0", Offset = "0x7D3BEB0", VA = "0x187D3CAB0")]
	private void JFDMHLJHJOI(LightData ADAJDKOOEOK, GLNHPHLLJKG[] JAOAJNDNDGM, int HFEDCGJKLFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7D3C0C0", Offset = "0x7D3B4C0", VA = "0x187D3C0C0")]
	private void DOILGGFOEDC(int LFPNCHIIFGL, int LEPLBLHEEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7D3BE90", Offset = "0x7D3B290", VA = "0x187D3BE90")]
	private void ADLNHJKKCBA(int LFPNCHIIFGL, int LOHPPDCIAAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7D3DC00", Offset = "0x7D3D000", VA = "0x187D3DC00")]
	private ushort PLEMLNKJDPC(int LFPNCHIIFGL)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7D3C8B0", Offset = "0x7D3BCB0", VA = "0x187D3C8B0")]
	private void GGCCFDKCGPJ(int LFPNCHIIFGL, int LEPLBLHEEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7D3BE20", Offset = "0x7D3B220", VA = "0x187D3BE20")]
	private void ABCBMJNPKJO(int NBPEDBIONNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7D3DB10", Offset = "0x7D3CF10", VA = "0x187D3DB10")]
	private void OJPJAENBFOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7D3C7B0", Offset = "0x7D3BBB0", VA = "0x187D3C7B0", Slot = "9")]
	public override void Execute(ScriptableRenderContext MEBLJIBNLCL, RenderingData DHDEOKFNBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7D3DBD0", Offset = "0x7D3CFD0", VA = "0x187D3DBD0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer AMIFMKNCGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7D3D210", Offset = "0x7D3C610", VA = "0x187D3D210")]
	private void JLCJMBALLEF(int MMAOHFNNDIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7D3CE00", Offset = "0x7D3C200", VA = "0x187D3CE00")]
	private void JFPFIGCHNLH(uint3 FKBCGDOLPJC, uint3 GOHHLCJMFOG, ushort MMAOHFNNDIH, float3 GOADOIIMBAI, float COKDCALKEPD, float HINNKHGCPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7D3C170", Offset = "0x7D3B570", VA = "0x187D3C170")]
	private void EGKMMNFAMGL(uint3 FKBCGDOLPJC, uint3 GOHHLCJMFOG, ushort MMAOHFNNDIH, float3 GOADOIIMBAI, float3 OOHOKNDLNOA, float3 GOGAKLFNJLA, float COKDCALKEPD, float CLEKDCBBCGJ, float HINNKHGCPIB, float EBKNNOHFKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7D3C6C0", Offset = "0x7D3BAC0", VA = "0x187D3C6C0")]
	private void EOPAJBLFGMH(ushort MMAOHFNNDIH, uint BBNPLNEDJCE, float CHFPGLKHNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7D3DA10", Offset = "0x7D3CE10", VA = "0x187D3DA10")]
	private float3 MCIFAHHOGFI(uint3 FKBCGDOLPJC, float3 GOADOIIMBAI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7D3C890", Offset = "0x7D3BC90", VA = "0x187D3C890")]
	private float FLGKPFKJCMB(float PCILBMOLECJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7D3D7C0", Offset = "0x7D3CBC0", VA = "0x187D3D7C0")]
	private float LEDMMFLHMPP(float3 HEHKBBKFNKB, float3 GOGAKLFNJLA, float CLEKDCBBCGJ, float HINNKHGCPIB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7D3D880", Offset = "0x7D3CC80", VA = "0x187D3D880")]
	private void LKCIFKAPOHC(int LBDMHLCFPFC, ushort OHBBPJOMKEE, int KFFECMNGGAP, OLIHDJFOKNG GKIHLKOLEMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FODBOEGGPNP
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class FIPIKJKIKMG
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int OECCPKJOMMB;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int GMBJIICFMHA;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int KHEJADIOALE;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int ONOJJDNKNOJ;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int NGLDDGKCABP;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int GPKKFNKGNMI;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int DLHHFOHLALC;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int KFFLIMIDBAO = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int IEFFIDMBMDP = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int OBHAKKEFKMB = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int NKGJCIHEMED = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int BGEIBCDKOAI = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int LDLFDMLDBNC = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int DHBIBJHNPOI = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool KCPDCADCCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer GNBCHPMLEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture KDJHGMBPFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int MBFFDOFKDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int FPPGIGLMLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int MNLJEPLCFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int FMDJAOJIEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int BDILLMHHFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader JHGJABGANGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int KEDOEFLFNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int GICDHNDJJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 LEDBIOPPLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 GMBHACJAHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> PMMEPCAAIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> MLDGBLCFKGE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> MHODBEDCCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4ABD5A0", Offset = "0x4ABC9A0", VA = "0x184ABD5A0")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> OEIDBHCCODE
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xFE2B20", Offset = "0xFE1F20", VA = "0x180FE2B20")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int CJGCMPFGNKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xB69AB0", Offset = "0xB68EB0", VA = "0x180B69AB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int DJJFAIELLHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x968340", Offset = "0x967740", VA = "0x180968340")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader CNIKDBGADDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7D3F140", Offset = "0x7D3E540", VA = "0x187D3F140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7D3F050", Offset = "0x7D3E450", VA = "0x187D3F050")]
	public void AICKIPOBPIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7D3FCA0", Offset = "0x7D3F0A0", VA = "0x187D3FCA0")]
	public void IMPLFKCCGOO(CameraData CEDBPJIOBAL, LightData ADAJDKOOEOK, int DCIFHKLCALH, bool JDCBIGFINOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3484450", Offset = "0x3483850", VA = "0x183484450")]
	private void MKGGHDNDGGJ<T>(NativeArray<T> PHAPILEGACC, int NBPEDBIONNC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7D3F4E0", Offset = "0x7D3E8E0", VA = "0x187D3F4E0")]
	public void FFGPBGDDNEE(CommandBuffer AMIFMKNCGGH, ScriptableRenderContext MEBLJIBNLCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7D3FAC0", Offset = "0x7D3EEC0", VA = "0x187D3FAC0")]
	private static void GCMLPKGOCBJ(int IGFELCPGLJH, CommandBuffer AMIFMKNCGGH, RenderBuffer BIMDBBKFCPG, ComputeBuffer KJEMOPKCKAE, ComputeShader NHMMENGDEOO, int JGEOBBACOCK, int BOPOCLFJLIO, int NLNHCHADJGD, int PJFOHGHFCDL, int GBJDBOHNFGK, int EONJMECEFPI, int JNFHMIACONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7D3F1D0", Offset = "0x7D3E5D0", VA = "0x187D3F1D0")]
	public void DNJAECLGIFB(CommandBuffer AMIFMKNCGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7D3FFB0", Offset = "0x7D3F3B0", VA = "0x187D3FFB0")]
	private RenderTexture NJDOLBCELMN(RenderTexture PLKJDEDDLHH, int JGEOBBACOCK, int BOPOCLFJLIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7D40190", Offset = "0x7D3F590", VA = "0x187D40190")]
	public void PAEPCOHFMHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7D3F830", Offset = "0x7D3EC30", VA = "0x187D3F830")]
	public void FIHAJBLJODH(int ANKDJCAPGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7D40210", Offset = "0x7D3F610", VA = "0x187D40210")]
	public FODBOEGGPNP()
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
		public struct HDFKJCBHHPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float DOIIHADHDMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float JEOHAHMGFBO;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class KHLGBCEMOPC : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string AMOBEFBOBJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler HGIECFGHFJP;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int MNDOCDMOJME;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material NODIHBJNJBC;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7D41580", Offset = "0x7D40980", VA = "0x187D41580")]
			public KHLGBCEMOPC(RenderPassEvent ENFFEBBPLHB, Material GIEDFKFHBFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7D411B0", Offset = "0x7D405B0", VA = "0x187D411B0", Slot = "9")]
			public override void Execute(ScriptableRenderContext MEBLJIBNLCL, RenderingData DHDEOKFNBBF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static HDFKJCBHHPE CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private KHLGBCEMOPC m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x7D42150", Offset = "0x7D41550", VA = "0x187D42150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7D42100", Offset = "0x7D41500", VA = "0x187D42100")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7D41F50", Offset = "0x7D41350", VA = "0x187D41F50", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7D41E80", Offset = "0x7D41280", VA = "0x187D41E80", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CJJNPFGBHFH, RenderingData DHDEOKFNBBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x149E580", Offset = "0x149D980", VA = "0x18149E580")]
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
		public struct KAPHMOCELLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float NCIJJCHHIEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color DNFNKELKNPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh KOGIMKNAHDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve HNAMMGCMKHJ;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class FMLDOMNMOBD : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string AMOBEFBOBJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler HGIECFGHFJP;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int KLFEELLMPII;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int EPHBAGELGBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material NODIHBJNJBC;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7D3EF70", Offset = "0x7D3E370", VA = "0x187D3EF70")]
			public FMLDOMNMOBD(RenderPassEvent ENFFEBBPLHB, Material GIEDFKFHBFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7D3ECD0", Offset = "0x7D3E0D0", VA = "0x187D3ECD0", Slot = "9")]
			public override void Execute(ScriptableRenderContext MEBLJIBNLCL, RenderingData DHDEOKFNBBF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static KAPHMOCELLA CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private FMLDOMNMOBD m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x7D42460", Offset = "0x7D41860", VA = "0x187D42460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7D422B0", Offset = "0x7D416B0", VA = "0x187D422B0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7D421A0", Offset = "0x7D415A0", VA = "0x187D421A0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CJJNPFGBHFH, RenderingData DHDEOKFNBBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x149E580", Offset = "0x149D980", VA = "0x18149E580")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string CIMEBCCLJPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool HJKOFPKKBNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer AMIFMKNCGGH, ScriptableRenderContext MEBLJIBNLCL, RenderingData DHDEOKFNBBF);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9668F0", Offset = "0x965CF0", VA = "0x1809668F0")]
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
		private class CGEJDIMJNAK : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool JBDINPHCEKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> KJONDCLIGDC;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> PLGEPBDPODA;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7D3BD70", Offset = "0x7D3B170", VA = "0x187D3BD70")]
			public CGEJDIMJNAK(RenderPassEvent ENFFEBBPLHB, bool JBDINPHCEKM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7D3B750", Offset = "0x7D3AB50", VA = "0x187D3B750")]
			public bool DFGPGHHJBLN(CameraData CEDBPJIOBAL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7D3BA30", Offset = "0x7D3AE30", VA = "0x187D3BA30", Slot = "9")]
			public override void Execute(ScriptableRenderContext MEBLJIBNLCL, RenderingData DHDEOKFNBBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7D3BC00", Offset = "0x7D3B000", VA = "0x187D3BC00")]
			private void OEIKHHEJKPN(PerCameraRenderEffect JJLNEDMPLIA, ScriptableRenderContext MEBLJIBNLCL, RenderingData DHDEOKFNBBF)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private CGEJDIMJNAK m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private CGEJDIMJNAK m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7D44480", Offset = "0x7D43880", VA = "0x187D44480", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7D443F0", Offset = "0x7D437F0", VA = "0x187D443F0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CJJNPFGBHFH, RenderingData DHDEOKFNBBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x149E580", Offset = "0x149D980", VA = "0x18149E580")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D446D0", Offset = "0x7D43AD0", VA = "0x187D446D0")]
		public static void OBJBMBCANAM(ScriptableRenderPass ABFKFGOOOFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7D44530", Offset = "0x7D43930", VA = "0x187D44530", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CJJNPFGBHFH, RenderingData DHDEOKFNBBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x149E580", Offset = "0x149D980", VA = "0x18149E580")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class OBBKJJJHHGA
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 PMLLHJNJPKE;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 FEBEDAOCLLF;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 CCPNHMJNDNG;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 LKPDPLJDFAK;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 LBANNNKFMDB;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7D42D60", Offset = "0x7D42160", VA = "0x187D42D60")]
	public static uint OPGIGKAHJND(uint COMHOHNLIIN, uint PJGBAACMKFF, uint GFJKGKCEHBG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7D42D70", Offset = "0x7D42170", VA = "0x187D42D70")]
	public static uint3 PMBAPEGMNNP(float3 HJBDDDIFEBJ, float3 FEMCKDJFAIB, float3 NGPMOFNAOCI)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7D42B20", Offset = "0x7D41F20", VA = "0x187D42B20")]
	public static void KNOINAGODCL(float3 IHCLDGGDODF, float3 LDNEGABIOKE, float3 KHIJLCLKCNC, float EJOLINDBPPE, [Out] uint3 CGLHADPFFBJ, [Out] uint3 DFJGDDKPELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7D424B0", Offset = "0x7D418B0", VA = "0x187D424B0")]
	public static void AGIBELAEPJA(float3 DEDCDEJMOBN, float3 PGLCBCIIAKL, float NBKCBIBCKOC, float HPMFBPAJKCF, [Out] float3 FPBMNANBNNI, [Out] float EJOLINDBPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7D42980", Offset = "0x7D41D80", VA = "0x187D42980")]
	private static float3 BGPFHFEENLE(float3 JCMEBBJFDHF, float3 NOFCBPADMBA, float3 ACAINHLBCCG, float3 ONGANPGDHBK)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class LFGABIDEHFN
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly HLBHMADGLFA PBJLJCMCPBP;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly HLBHMADGLFA MFKCMKGJAEA;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly HLBHMADGLFA DAOBMOGGHMF;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly HLBHMADGLFA FKFHPFKGJEJ;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly HLBHMADGLFA FHEPDNJBJFI;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class HDBBPLICILG
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh FFJCFEOEEEP;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7D40830", Offset = "0x7D3FC30", VA = "0x187D40830")]
	public static Mesh JBMMNCNNDEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7D40C90", Offset = "0x7D40090", VA = "0x187D40C90")]
	public static Matrix4x4 MMABEIHKBEL(Camera MNKAMPFEKFJ, bool FNECOGOHKCI = false, bool CEIHHKBBBAJ = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7D408D0", Offset = "0x7D3FCD0", VA = "0x187D408D0")]
	private static Mesh KEPIIKCKAHK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__4096169291
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7D45AF0", Offset = "0x7D44EF0", VA = "0x187D45AF0")]
	public static void HIAMNDAEINL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7D45AE0", Offset = "0x7D44EE0", VA = "0x187D45AE0")]
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
