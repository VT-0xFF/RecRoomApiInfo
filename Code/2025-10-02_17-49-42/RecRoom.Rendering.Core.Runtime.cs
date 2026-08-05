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
	public class LogRegistrationIndex : OPBNGIPOJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8D4DBC0", Offset = "0x8D4C5C0", VA = "0x188D4DBC0", Slot = "4")]
		public override void NFFNLBFBLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		public enum GBPDGBCLHEO
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface DLPMEAENGPI
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void EHJPGICEMNO(ScriptableRenderContext IJNPIDPIBFP, List<Camera> PDGANMOMPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface OMGBNFJBGCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void EHJPGICEMNO(ScriptableRenderContext IJNPIDPIBFP, RenderingData ELALNHAPKMO);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class OCAMNNMDPMA : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8D4ED30", Offset = "0x8D4D730", VA = "0x188D4ED30")]
			public OCAMNNMDPMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8D4ECD0", Offset = "0x8D4D6D0", VA = "0x188D4ECD0", Slot = "9")]
			public override void Execute(ScriptableRenderContext IJNPIDPIBFP, RenderingData ELALNHAPKMO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private OCAMNNMDPMA _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<DLPMEAENGPI> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<DLPMEAENGPI> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<OMGBNFJBGCN> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<OMGBNFJBGCN> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D501D0", Offset = "0x8D4EBD0", VA = "0x188D501D0")]
		public static void JOBKFNMACKF(GBPDGBCLHEO GIEBFCHLONF, DLPMEAENGPI EFIJODJIGGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8D4F250", Offset = "0x8D4DC50", VA = "0x188D4F250")]
		public static void BKNFMMEKNCH(GBPDGBCLHEO GIEBFCHLONF, DLPMEAENGPI EFIJODJIGGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8D50110", Offset = "0x8D4EB10", VA = "0x188D50110")]
		public static void JOBKFNMACKF(GBPDGBCLHEO GIEBFCHLONF, OMGBNFJBGCN GPILMGNBLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8D4F310", Offset = "0x8D4DD10", VA = "0x188D4F310")]
		public static void BKNFMMEKNCH(GBPDGBCLHEO GIEBFCHLONF, OMGBNFJBGCN GPILMGNBLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8D4F3D0", Offset = "0x8D4DDD0", VA = "0x188D4F3D0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8D4F1A0", Offset = "0x8D4DBA0", VA = "0x188D4F1A0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer ALKNEOONPNG, RenderingData ELALNHAPKMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8D50000", Offset = "0x8D4EA00", VA = "0x188D50000", Slot = "9")]
		protected override void Dispose(bool JCHDBFDPFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8D4FA90", Offset = "0x8D4E490", VA = "0x188D4FA90")]
		private static void DKENMJMCPBM(ScriptableRenderContext IJNPIDPIBFP, List<Camera> PDGANMOMPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8D4FF90", Offset = "0x8D4E990", VA = "0x188D4FF90")]
		private static void DNBIPAPPNPJ(ScriptableRenderContext IJNPIDPIBFP, List<Camera> PDGANMOMPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8D4F5C0", Offset = "0x8D4DFC0", VA = "0x188D4F5C0")]
		private static void DFJJKCGDIML(ScriptableRenderContext IJNPIDPIBFP, RenderingData ELALNHAPKMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x19B56E0", Offset = "0x19B40E0", VA = "0x1819B56E0")]
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
		private class NHIEOKCHCGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool DBCLMAJIPPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<NAOJKHACCEK> LJAIFOAOFED;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8D4E780", Offset = "0x8D4D180", VA = "0x188D4E780")]
			public NHIEOKCHCGP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class NHALGDCIBFG : PreRenderManager.OMGBNFJBGCN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string NJDCFEGEDAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler BCLKLHCMDNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly NHIEOKCHCGP PKBDNLGMBJE;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8D4E6C0", Offset = "0x8D4D0C0", VA = "0x188D4E6C0")]
			public NHALGDCIBFG(NHIEOKCHCGP ECHFMFHADJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8D4E2B0", Offset = "0x8D4CCB0", VA = "0x188D4E2B0", Slot = "4")]
			public void EHJPGICEMNO(ScriptableRenderContext IJNPIDPIBFP, RenderingData ELALNHAPKMO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class KKFBBDNOABJ : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string FICKNDNHPMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly NHIEOKCHCGP ECHFMFHADJB;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8D4C1A0", Offset = "0x8D4ABA0", VA = "0x188D4C1A0")]
			public KKFBBDNOABJ(RenderPassEvent BHNDPEOGHGG, NHIEOKCHCGP ECHFMFHADJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8D4BE90", Offset = "0x8D4A890", VA = "0x188D4BE90", Slot = "9")]
			public override void Execute(ScriptableRenderContext IJNPIDPIBFP, RenderingData ELALNHAPKMO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<NAOJKHACCEK> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private NHALGDCIBFG fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private KKFBBDNOABJ fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private NHIEOKCHCGP sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8D48660", Offset = "0x8D47060", VA = "0x188D48660", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8D489F0", Offset = "0x8D473F0", VA = "0x188D489F0", Slot = "9")]
		protected override void Dispose(bool JCHDBFDPFMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8D485C0", Offset = "0x8D46FC0", VA = "0x188D485C0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer ALKNEOONPNG, RenderingData ELALNHAPKMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x19B56E0", Offset = "0x19B40E0", VA = "0x1819B56E0")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NAOJKHACCEK
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BNAPGCBPFPN(CommandBuffer OGMLIHHKJPH, Camera GDINMNFHIGJ, [NotNull] UniversalAdditionalCameraData MMHLPLFCLJP, bool BPJBEBEDJKG);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OANFMOAHNMF(Camera GDINMNFHIGJ, CommandBuffer GNJOLAHHMOM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class KOAKHHIGFPL
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool BLHBBKBCPPH;
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
		private CBHMBNEDIOH _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private JAOONFOBFLE _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8D4D890", Offset = "0x8D4C290", VA = "0x188D4D890", Slot = "9")]
		protected override void Dispose(bool PAEAAMEJFPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8D4D900", Offset = "0x8D4C300", VA = "0x188D4D900")]
		private void EPGHPOJHGNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8D4D540", Offset = "0x8D4BF40", VA = "0x188D4D540", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer ALKNEOONPNG, RenderingData ELALNHAPKMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x19B56E0", Offset = "0x19B40E0", VA = "0x1819B56E0")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BDEBGBDANHD
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8D456F0", Offset = "0x8D440F0", VA = "0x188D456F0")]
	public static int LLMJLDEBBAI(bool KAKHEFKCDOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1E7AF50", Offset = "0x1E79950", VA = "0x181E7AF50")]
	public static int MCAMDJGKDNM(bool KAKHEFKCDOE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct OADKILADJGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType DIOHPHDDDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float JGPDHJLKFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float FBOHMIMNCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float OJPODKIFLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 FKMBPIIMLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 FFAIMOHFHME;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct KBAIOEIKPBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort ONFGDIPIBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float JKGLMJNOOFC;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct LDHBBBDIMOP : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<OADKILADJGB> PLOBFDMFJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 IPNIHLCPJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 IEMNBFHJDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, KBAIOEIKPBD>.ParallelWriter GINGAMHGIMB;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8D4C6F0", Offset = "0x8D4B0F0", VA = "0x188D4C6F0", Slot = "4")]
	public void Execute(int ONFGDIPIBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8D4D1D0", Offset = "0x8D4BBD0", VA = "0x188D4D1D0")]
	private void NMJKCJLPJKP(uint3 JNLHKBGFBLH, uint3 FKGLIHLPGIM, ushort ONFGDIPIBCK, float3 CMKDJAJJIOB, float OPEPHJBPJMP, float EDFABJEKJEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8D4CC30", Offset = "0x8D4B630", VA = "0x188D4CC30")]
	private void HBOECDNMLFE(uint3 JNLHKBGFBLH, uint3 FKGLIHLPGIM, ushort ONFGDIPIBCK, float3 CMKDJAJJIOB, float3 DKPOIOMMHFP, float3 FKMCABPOLEK, float OPEPHJBPJMP, float CMPBDMDDBCO, float EDFABJEKJEN, float EMNPLEINHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8D4D0E0", Offset = "0x8D4BAE0", VA = "0x188D4D0E0")]
	private float3 KBAKFICLKPI(uint3 JNLHKBGFBLH, float3 CMKDJAJJIOB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8D4BC00", Offset = "0x8D4A600", VA = "0x188D4BC00")]
	private float OPDOIOKKEKB(float JGPDHJLKFEF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8D4AB10", Offset = "0x8D49510", VA = "0x188D4AB10")]
	private float ICPMJMKCFIC(float3 PIGMJHBJLPC, float3 FKMCABPOLEK, float CMPBDMDDBCO, float EDFABJEKJEN)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct KNCAPEBGLDF : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, KBAIOEIKPBD> GINGAMHGIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint LOFPBOJLPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int MFOJNJCFBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int NFNGEIHFOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> DHDPENBKJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> CCJPPKJFKJE;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8D4C280", Offset = "0x8D4AC80", VA = "0x188D4C280", Slot = "4")]
	public void Execute(int FJKGHPKBKPH, int OGKMAGNOGAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8D4C420", Offset = "0x8D4AE20", VA = "0x188D4C420")]
	private void PAJALHHKOMB(int DPFCOJAINOB, ushort NGKNKJELAHA, int FNEAELHBLHO, KBAIOEIKPBD KDLAOBPPLJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct GADIACBLEPJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, KBAIOEIKPBD> GINGAMHGIMB;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8D48BF0", Offset = "0x8D475F0", VA = "0x188D48BF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class CBHMBNEDIOH : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool EEHEIBNPGKE;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float AMDCCOEDNPI = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int MDKHMKONKJI = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int NGOFLICPHNP = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private LDHBBBDIMOP ONNPGGIMKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private KNCAPEBGLDF MJJILMAHGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private GADIACBLEPJ KNAGOEJCADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, KBAIOEIKPBD> GCGIHAHDGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private EENHMMOINJH DFFEHOEOPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool JAIHBPEMFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int IEPLMHHIGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<OADKILADJGB> GIMAHCJHDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle GKKEFFBPBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle AHPIJFCJADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool EDOAPPPOHNF;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8D471E0", Offset = "0x8D45BE0", VA = "0x188D471E0")]
	public CBHMBNEDIOH(RenderPassEvent BHNDPEOGHGG, ComputeShader GBHKGFMICII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8D46C00", Offset = "0x8D45600", VA = "0x188D46C00")]
	private void KHFMLENBAID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8D46B20", Offset = "0x8D45520", VA = "0x188D46B20")]
	public void GGMOCDPHMNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3B84B50", Offset = "0x3B83550", VA = "0x183B84B50")]
	public static void OKAFMGEMNCH<T>(NativeArray<T> BHEONMJLANC, int BCAJFCGHDKI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8D46640", Offset = "0x8D45040", VA = "0x188D46640")]
	public void EJMACCOIDCA(CameraData MMHLPLFCLJP, LightData NAGINHDGPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8D46C70", Offset = "0x8D45670", VA = "0x188D46C70")]
	private void KMNPFGJJCDE(LightData NAGINHDGPLH, NativeArray<OADKILADJGB> NNECAGACEAH, int FLCKBEMICDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8D46400", Offset = "0x8D44E00", VA = "0x188D46400")]
	private void DFJFBAAIFBE(CameraData MMHLPLFCLJP, LightData NAGINHDGPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8D46FB0", Offset = "0x8D459B0", VA = "0x188D46FB0")]
	private void NKANLMLKAND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8D46300", Offset = "0x8D44D00", VA = "0x188D46300")]
	private void BEFJBODFMFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8D47170", Offset = "0x8D45B70", VA = "0x188D47170")]
	private void PIEIKCLKLMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8D46AF0", Offset = "0x8D454F0", VA = "0x188D46AF0")]
	private void FNNAOBHGOFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8D469F0", Offset = "0x8D453F0", VA = "0x188D469F0", Slot = "9")]
	public override void Execute(ScriptableRenderContext IJNPIDPIBFP, RenderingData ELALNHAPKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8D47140", Offset = "0x8D45B40", VA = "0x188D47140", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer GNJOLAHHMOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JAOONFOBFLE : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort CMMMELFCFEG = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float AMDCCOEDNPI = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly EENHMMOINJH DFFEHOEOPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int DMDDMGGICAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private OADKILADJGB[] GIMAHCJHDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 PKOAPJPNHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 DBOCGICLNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint OLLMEBHKAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int GCJMGLECGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int LFPMONFLMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> DHDPENBKJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> CCJPPKJFKJE;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8D4BDE0", Offset = "0x8D4A7E0", VA = "0x188D4BDE0")]
	public JAOONFOBFLE(RenderPassEvent BHNDPEOGHGG, ComputeShader GBHKGFMICII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8D4A2E0", Offset = "0x8D48CE0", VA = "0x188D4A2E0")]
	public void EJMACCOIDCA(CameraData MMHLPLFCLJP, LightData NAGINHDGPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8D4A0B0", Offset = "0x8D48AB0", VA = "0x188D4A0B0")]
	private void CLHLMIAPLEC(CameraData MMHLPLFCLJP, LightData NAGINHDGPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8D4A5A0", Offset = "0x8D48FA0", VA = "0x188D4A5A0")]
	public void GGMOCDPHMNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8D4B4A0", Offset = "0x8D49EA0", VA = "0x188D4B4A0")]
	private void KMNPFGJJCDE(LightData NAGINHDGPLH, OADKILADJGB[] NNECAGACEAH, int FLCKBEMICDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8D4A000", Offset = "0x8D48A00", VA = "0x188D4A000")]
	private void BLNLOANOFAE(int FJKGHPKBKPH, int OGKMAGNOGAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8D4A2B0", Offset = "0x8D48CB0", VA = "0x188D4A2B0")]
	private void DIJDBHHOHLL(int FJKGHPKBKPH, int MHMCOJIKNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8D49FC0", Offset = "0x8D489C0", VA = "0x188D49FC0")]
	private ushort BIPPENFOFPA(int FJKGHPKBKPH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8D4ABD0", Offset = "0x8D495D0", VA = "0x188D4ABD0")]
	private void IEKCBFGJKBO(int FJKGHPKBKPH, int OGKMAGNOGAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8D4A530", Offset = "0x8D48F30", VA = "0x188D4A530")]
	private void FJIBLLPCKIH(int BCAJFCGHDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8D4AC40", Offset = "0x8D49640", VA = "0x188D4AC40")]
	private void IIHABBNKNGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8D4A450", Offset = "0x8D48E50", VA = "0x188D4A450", Slot = "9")]
	public override void Execute(ScriptableRenderContext IJNPIDPIBFP, RenderingData ELALNHAPKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8D4BC20", Offset = "0x8D4A620", VA = "0x188D4BC20", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer GNJOLAHHMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8D4AD00", Offset = "0x8D49700", VA = "0x188D4AD00")]
	private void IMNDNOEOEKE(int ONFGDIPIBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8D4B7F0", Offset = "0x8D4A1F0", VA = "0x188D4B7F0")]
	private void NMJKCJLPJKP(uint3 JNLHKBGFBLH, uint3 FKGLIHLPGIM, ushort ONFGDIPIBCK, float3 CMKDJAJJIOB, float OPEPHJBPJMP, float EDFABJEKJEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8D4A5C0", Offset = "0x8D48FC0", VA = "0x188D4A5C0")]
	private void HBOECDNMLFE(uint3 JNLHKBGFBLH, uint3 FKGLIHLPGIM, ushort ONFGDIPIBCK, float3 CMKDJAJJIOB, float3 DKPOIOMMHFP, float3 FKMCABPOLEK, float OPEPHJBPJMP, float CMPBDMDDBCO, float EDFABJEKJEN, float EMNPLEINHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8D4B2B0", Offset = "0x8D49CB0", VA = "0x188D4B2B0")]
	private void JLBAGGHKBOI(ushort ONFGDIPIBCK, uint DAKGKMBIDBP, float ICFFMFFCIOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8D4B3A0", Offset = "0x8D49DA0", VA = "0x188D4B3A0")]
	private float3 KBAKFICLKPI(uint3 JNLHKBGFBLH, float3 CMKDJAJJIOB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8D4BC00", Offset = "0x8D4A600", VA = "0x188D4BC00")]
	private float OPDOIOKKEKB(float JGPDHJLKFEF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8D4AB10", Offset = "0x8D49510", VA = "0x188D4AB10")]
	private float ICPMJMKCFIC(float3 PIGMJHBJLPC, float3 FKMCABPOLEK, float CMPBDMDDBCO, float EDFABJEKJEN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8D4BC50", Offset = "0x8D4A650", VA = "0x188D4BC50")]
	private void PAJALHHKOMB(int DPFCOJAINOB, ushort NGKNKJELAHA, int FNEAELHBLHO, KBAIOEIKPBD KDLAOBPPLJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class EENHMMOINJH
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class LAJKNANBDPI
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int EINCFAMLPGN;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int FDIOPHIBJLP;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int BFHJFNBJCCN;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int JDHPBGAAIPH;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int GPFHBNJANEI;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int CLILMMJFBHA;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int PHGGCFGLCCP;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int DPCKKDEEIAL = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int CNAILCJCPMF = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int FILNMOIDAPL = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int MAFDBHPEKGI = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int CAHGEEDCKND = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int KPNNONBDHLO = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int AKPNKEANFKL = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool JGELBOGKFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer IJMGGEGDIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture KNJJGMLOKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int BGHDGMJBPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int FMJEPJJNOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int HJMGNNFHMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int AKKPFNNJBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int HKJIINCGGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader PNJOJNNGLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int IMLCHEDENDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int KCKLABLDPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 AJNJAPCFBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 DAINLDPPJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> FHEHOMMBPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> CKNLLONMMGM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> ICGBJINFICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x518C4B0", Offset = "0x518AEB0", VA = "0x18518C4B0")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> PCIKDBEDJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x136F430", Offset = "0x136DE30", VA = "0x18136F430")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int PONJLAIFEDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAFDAE0", Offset = "0xAFC4E0", VA = "0x180AFDAE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int IFKMLGJEPAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xAB33E0", Offset = "0xAB1DE0", VA = "0x180AB33E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader GHHOOHNDOGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8D47840", Offset = "0x8D46240", VA = "0x188D47840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8D47E50", Offset = "0x8D46850", VA = "0x188D47E50")]
	public void OKCDDGFOJCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8D48290", Offset = "0x8D46C90", VA = "0x188D48290")]
	public void PKNGAIEKGJD(CameraData MMHLPLFCLJP, LightData NAGINHDGPLH, int ANHHBKLHLLG, bool KAKHEFKCDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3BFFA40", Offset = "0x3BFE440", VA = "0x183BFFA40")]
	private void OKAFMGEMNCH<T>(NativeArray<T> BHEONMJLANC, int BCAJFCGHDKI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8D47F40", Offset = "0x8D46940", VA = "0x188D47F40")]
	public void ONIIHNLAIPD(CommandBuffer GNJOLAHHMOM, ScriptableRenderContext IJNPIDPIBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8D47BF0", Offset = "0x8D465F0", VA = "0x188D47BF0")]
	private static void LKPFJCFJPLG(int PEICIABHEHN, CommandBuffer GNJOLAHHMOM, RenderBuffer FADBNAHEAAK, ComputeBuffer OGKCBKELMBL, ComputeShader KJCOBHNCBNN, int GAAJIGKPKPB, int IMICJMJPCDK, int EGCBKKJBCLD, int PFANEOBALJD, int BCOODJLMJFM, int MDBCOCIBBGN, int LAKLCKOCBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8D478D0", Offset = "0x8D462D0", VA = "0x188D478D0")]
	public void IMDIFKPENGJ(CommandBuffer GNJOLAHHMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8D473D0", Offset = "0x8D45DD0", VA = "0x188D473D0")]
	private RenderTexture ELEPIPEHIHO(RenderTexture CIBOBJAJKFF, int GAAJIGKPKPB, int IMICJMJPCDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8D47DD0", Offset = "0x8D467D0", VA = "0x188D47DD0")]
	public void NEILHBHABDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8D475B0", Offset = "0x8D45FB0", VA = "0x188D475B0")]
	public void GDLIAAJOLNP(int BPGFPPMCEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8D485A0", Offset = "0x8D46FA0", VA = "0x188D485A0")]
	public EENHMMOINJH()
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
		public struct PPGIPJCOEEP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float ACONFELLDFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float KGEMCKMCGPG;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class OBGOIMJNILC : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string HLNEPAIEKEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler GDOKKEOFMGL;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int FIGHAIOJAIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material BLFPANOHAGO;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8D4EBF0", Offset = "0x8D4D5F0", VA = "0x188D4EBF0")]
			public OBGOIMJNILC(RenderPassEvent BHNDPEOGHGG, Material PJPBFBIEGMK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8D4E810", Offset = "0x8D4D210", VA = "0x188D4E810", Slot = "9")]
			public override void Execute(ScriptableRenderContext IJNPIDPIBFP, RenderingData ELALNHAPKMO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static PPGIPJCOEEP CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private OBGOIMJNILC m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x8D4DF20", Offset = "0x8D4C920", VA = "0x188D4DF20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8D4DED0", Offset = "0x8D4C8D0", VA = "0x188D4DED0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8D4DD20", Offset = "0x8D4C720", VA = "0x188D4DD20", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8D4DC50", Offset = "0x8D4C650", VA = "0x188D4DC50", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer ALKNEOONPNG, RenderingData ELALNHAPKMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x19B56E0", Offset = "0x19B40E0", VA = "0x1819B56E0")]
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
		public struct IGNFNEGPHEE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float OKLODPMJPMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color LFOPGHIGMKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh BFLFCPFDIDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve EIKFAMFGDLE;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class IBDMNFEBAOP : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string HLNEPAIEKEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler GDOKKEOFMGL;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int AECNOLBFBNC;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int GPNNIHMOACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material BLFPANOHAGO;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8D49800", Offset = "0x8D48200", VA = "0x188D49800")]
			public IBDMNFEBAOP(RenderPassEvent BHNDPEOGHGG, Material PJPBFBIEGMK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8D49540", Offset = "0x8D47F40", VA = "0x188D49540", Slot = "9")]
			public override void Execute(ScriptableRenderContext IJNPIDPIBFP, RenderingData ELALNHAPKMO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static IGNFNEGPHEE CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private IBDMNFEBAOP m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x8D4E250", Offset = "0x8D4CC50", VA = "0x188D4E250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8D4E0A0", Offset = "0x8D4CAA0", VA = "0x188D4E0A0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8D4DF80", Offset = "0x8D4C980", VA = "0x188D4DF80", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer ALKNEOONPNG, RenderingData ELALNHAPKMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x19B56E0", Offset = "0x19B40E0", VA = "0x1819B56E0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string DDIMEEPNCMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool CMAOMJCGPHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer GNJOLAHHMOM, ScriptableRenderContext IJNPIDPIBFP, RenderingData ELALNHAPKMO);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
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
		private class IJHNMNPNOPO : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool KICPNJINLIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> EIEDCAEGHKN;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> BEKPMNCFKAD;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8D49F10", Offset = "0x8D48910", VA = "0x188D49F10")]
			public IJHNMNPNOPO(RenderPassEvent BHNDPEOGHGG, bool KICPNJINLIB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8D49B90", Offset = "0x8D48590", VA = "0x188D49B90")]
			public bool JKJEBPBIKPO(CameraData MMHLPLFCLJP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8D499C0", Offset = "0x8D483C0", VA = "0x188D499C0", Slot = "9")]
			public override void Execute(ScriptableRenderContext IJNPIDPIBFP, RenderingData ELALNHAPKMO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8D498E0", Offset = "0x8D482E0", VA = "0x188D498E0")]
			private void BJAOOMOICKI(PerCameraRenderEffect FLJJDCDOJLJ, ScriptableRenderContext IJNPIDPIBFP, RenderingData ELALNHAPKMO)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IJHNMNPNOPO m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private IJHNMNPNOPO m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8D4EDE0", Offset = "0x8D4D7E0", VA = "0x188D4EDE0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8D4ED50", Offset = "0x8D4D750", VA = "0x188D4ED50", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer ALKNEOONPNG, RenderingData ELALNHAPKMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x19B56E0", Offset = "0x19B40E0", VA = "0x1819B56E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D4F030", Offset = "0x8D4DA30", VA = "0x188D4F030")]
		public static void OOPBNLPCJIN(ScriptableRenderPass EKJEBGGEDJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8D4EE90", Offset = "0x8D4D890", VA = "0x188D4EE90", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer ALKNEOONPNG, RenderingData ELALNHAPKMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x19B56E0", Offset = "0x19B40E0", VA = "0x1819B56E0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class BNFOIENNPEG
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 HPHFOBKMPPP;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 LCOEJLDANNJ;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 PMFHEMKIHNC;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 CAFOEELLGLL;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 HCGJCKPJBMD;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8D45F70", Offset = "0x8D44970", VA = "0x188D45F70")]
	public static uint MOCPNIBBEDD(uint FKPKEFAKAOE, uint KEEMKILMOML, uint JLNCPHFMCKO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8D45700", Offset = "0x8D44100", VA = "0x188D45700")]
	public static uint3 ELBKHHAJHHI(float3 KFJFDPLEJOD, float3 IPNIHLCPJKH, float3 IEMNBFHJDFH)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8D45F80", Offset = "0x8D44980", VA = "0x188D45F80")]
	public static void ODPBDENCOOJ(float3 NGBECLHNCPP, float3 KCHDDLIOPIE, float3 CJNFGELGFOF, float JBOIDCJHBGG, [Out] uint3 JLCJGIHAPGI, [Out] uint3 OCKJHNEEOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8D45AA0", Offset = "0x8D444A0", VA = "0x188D45AA0")]
	public static void JKEGCLNILNE(float3 DALHPGGIJHO, float3 NONHMMFJMKG, float FBOHMIMNCKO, float AEODLBECCNE, [Out] float3 AFLPBMPBNNJ, [Out] float JBOIDCJHBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8D45900", Offset = "0x8D44300", VA = "0x188D45900")]
	private static float3 IFFLOFGDJFC(float3 PBCHPENFHHM, float3 CHIELILKOPM, float3 DCGEJMAKJFF, float3 CJIIBEJJDEN)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class CNJJNBACDBJ
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly OLFEOKKCIEG DEGEKJJIFDB;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly OLFEOKKCIEG BDLNCDEENDP;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly OLFEOKKCIEG NGBFKAJLOLB;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly OLFEOKKCIEG JLDHIJCPBDD;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly OLFEOKKCIEG JOJMOEEJKGO;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class HOJKFKAJFGE
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh OBHIPLMPLJH;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8D48FF0", Offset = "0x8D479F0", VA = "0x188D48FF0")]
	public static Mesh FIAIGDMAEME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8D490A0", Offset = "0x8D47AA0", VA = "0x188D490A0")]
	public static Matrix4x4 NBLFFNHFPFJ(Camera GDINMNFHIGJ, bool HHHNDLKHKFA = false, bool HHJNOKKEPAM = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8D48C30", Offset = "0x8D47630", VA = "0x188D48C30")]
	private static Mesh DJJKLLOPJLJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2936423055
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8D504C0", Offset = "0x8D4EEC0", VA = "0x188D504C0")]
	public static void AEJPHIJJPKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8D50550", Offset = "0x8D4EF50", VA = "0x188D50550")]
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
