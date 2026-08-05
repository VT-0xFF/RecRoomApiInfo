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
	public class LogRegistrationIndex : GEPCMJPGCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7639000", Offset = "0x7637800", VA = "0x187639000", Slot = "4")]
		public override void CCEDGNHHKOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
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
		public enum HBIMKJEBHNF
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface PNOHDKJHAPP
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void FPGKMMGLAFA(ScriptableRenderContext IKGPEBFFMPK, List<Camera> GEJOGGFKIHE);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface LOFCCPNOJHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void FPGKMMGLAFA(ScriptableRenderContext IKGPEBFFMPK, RenderingData IEAEPMDAJII);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class OJENFKGFDNI : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7639A70", Offset = "0x7638270", VA = "0x187639A70")]
			public OJENFKGFDNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7639A10", Offset = "0x7638210", VA = "0x187639A10", Slot = "9")]
			public override void Execute(ScriptableRenderContext IKGPEBFFMPK, RenderingData IEAEPMDAJII)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private OJENFKGFDNI _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<PNOHDKJHAPP> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<PNOHDKJHAPP> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<LOFCCPNOJHL> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<LOFCCPNOJHL> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x763AE60", Offset = "0x7639660", VA = "0x18763AE60")]
		public static void HGDPCKENDLI(HBIMKJEBHNF JBGNGODBJJE, PNOHDKJHAPP JNHLBHKHIMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x763B510", Offset = "0x7639D10", VA = "0x18763B510")]
		public static void MKOKAEGKGJP(HBIMKJEBHNF JBGNGODBJJE, PNOHDKJHAPP JNHLBHKHIMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x763ADA0", Offset = "0x76395A0", VA = "0x18763ADA0")]
		public static void HGDPCKENDLI(HBIMKJEBHNF JBGNGODBJJE, LOFCCPNOJHL DGEMOMGKALO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x763B450", Offset = "0x7639C50", VA = "0x18763B450")]
		public static void MKOKAEGKGJP(HBIMKJEBHNF JBGNGODBJJE, LOFCCPNOJHL DGEMOMGKALO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x763AAA0", Offset = "0x76392A0", VA = "0x18763AAA0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x763A500", Offset = "0x7638D00", VA = "0x18763A500", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer ALAKDHHJBKP, RenderingData IEAEPMDAJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x763AC90", Offset = "0x7639490", VA = "0x18763AC90", Slot = "9")]
		protected override void Dispose(bool GBAPJOMGEID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x763A5B0", Offset = "0x7638DB0", VA = "0x18763A5B0")]
		private static void BHJEKMNBPKA(ScriptableRenderContext IKGPEBFFMPK, List<Camera> GEJOGGFKIHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x763AF20", Offset = "0x7639720", VA = "0x18763AF20")]
		private static void HGJHGMCEDPP(ScriptableRenderContext IKGPEBFFMPK, List<Camera> GEJOGGFKIHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x763AF90", Offset = "0x7639790", VA = "0x18763AF90")]
		private static void LHHLILDJKLO(ScriptableRenderContext IKGPEBFFMPK, RenderingData IEAEPMDAJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x118AEC0", Offset = "0x11896C0", VA = "0x18118AEC0")]
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
		private class EPFHCANFOHJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool BFKKLPBNLIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<PHBOEMKHHMA> IJOBLDIDNLK;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x76360D0", Offset = "0x76348D0", VA = "0x1876360D0")]
			public EPFHCANFOHJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class KEENBOONMBM : PreRenderManager.LOFCCPNOJHL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string DHFKHBNNHDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler LMOPHFMDDGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly EPFHCANFOHJ HLKIBIDEDGK;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x76388C0", Offset = "0x76370C0", VA = "0x1876388C0")]
			public KEENBOONMBM(EPFHCANFOHJ NOMJKNEDLPI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x76384C0", Offset = "0x7636CC0", VA = "0x1876384C0", Slot = "4")]
			public void FPGKMMGLAFA(ScriptableRenderContext IKGPEBFFMPK, RenderingData IEAEPMDAJII)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class CCJMEHFGNPF : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string LDPGMGMKBHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly EPFHCANFOHJ NOMJKNEDLPI;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7634CC0", Offset = "0x76334C0", VA = "0x187634CC0")]
			public CCJMEHFGNPF(RenderPassEvent EFIODEKKONB, EPFHCANFOHJ NOMJKNEDLPI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x76349B0", Offset = "0x76331B0", VA = "0x1876349B0", Slot = "9")]
			public override void Execute(ScriptableRenderContext IKGPEBFFMPK, RenderingData IEAEPMDAJII)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<PHBOEMKHHMA> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private KEENBOONMBM fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private CCJMEHFGNPF fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private EPFHCANFOHJ sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x76368E0", Offset = "0x76350E0", VA = "0x1876368E0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7636C70", Offset = "0x7635470", VA = "0x187636C70", Slot = "9")]
		protected override void Dispose(bool GBAPJOMGEID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7636840", Offset = "0x7635040", VA = "0x187636840", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer ALAKDHHJBKP, RenderingData IEAEPMDAJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x118AEC0", Offset = "0x11896C0", VA = "0x18118AEC0")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PHBOEMKHHMA
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KHNGOHIHNJJ(CommandBuffer NHBIENACHMN, Camera NIGNOFHNFLO, [NotNull] UniversalAdditionalCameraData HDLIGIAHFHK, bool AMDNEKDENPD);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJFEJOOAIFP(Camera NIGNOFHNFLO, CommandBuffer CBAMPDLJPPG);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class CMHJHMECMKC
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool HKDLAEIOOJL;
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
		private CLEJMKNLGHH _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private BJCPIEKMMOH _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7638CD0", Offset = "0x76374D0", VA = "0x187638CD0", Slot = "9")]
		protected override void Dispose(bool DELOOKALIAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7638D40", Offset = "0x7637540", VA = "0x187638D40")]
		private void HJJGPAMCAJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7638980", Offset = "0x7637180", VA = "0x187638980", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer ALAKDHHJBKP, RenderingData IEAEPMDAJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x118AEC0", Offset = "0x11896C0", VA = "0x18118AEC0")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class MEJCPDIDNAE
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7639090", Offset = "0x7637890", VA = "0x187639090")]
	public static int AKPCHDNPLPH(bool MIBPBCIAMHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x15EE550", Offset = "0x15ECD50", VA = "0x1815EE550")]
	public static int ODINMIMLAGL(bool MIBPBCIAMHD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct AIEKMLPPCJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType ILLLHLJOBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float FOPGEJJLFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float DGMMIIPLMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float FGMPFHJGBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 LBFHOIHBJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 FHFONHOBDDK;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct FHKPKMHPHHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort FMONLAPDILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float CEGBKKEBCOA;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct APNODKHKOLC : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<AIEKMLPPCJO> PIHBAGCKLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 NIFENDLAHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 LLKEEBGMHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, FHKPKMHPHHB>.ParallelWriter INNLKDFIBHJ;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7630B60", Offset = "0x762F360", VA = "0x187630B60", Slot = "4")]
	public void Execute(int FMONLAPDILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7631550", Offset = "0x762FD50", VA = "0x187631550")]
	private void GNEDIIDCKCO(uint3 KCKOAOJFMJD, uint3 JLDPLKNJAEL, ushort FMONLAPDILI, float3 BIFJDMAGCJM, float ABDKNMPMKOB, float LIHAFDHMDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x76310A0", Offset = "0x762F8A0", VA = "0x1876310A0")]
	private void GANIDPNAINK(uint3 KCKOAOJFMJD, uint3 JLDPLKNJAEL, ushort FMONLAPDILI, float3 BIFJDMAGCJM, float3 MCEJPNPMFPG, float3 CKFEMPKOOJB, float ABDKNMPMKOB, float LHBDDGJCMJN, float LIHAFDHMDFD, float MBEJENFNLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x76318E0", Offset = "0x76300E0", VA = "0x1876318E0")]
	private float3 NPFAONBOFBH(uint3 KCKOAOJFMJD, float3 BIFJDMAGCJM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x76318C0", Offset = "0x76300C0", VA = "0x1876318C0")]
	private float HCFBFMFCGKI(float FOPGEJJLFNO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7630AA0", Offset = "0x762F2A0", VA = "0x187630AA0")]
	private float EBKCNGOGDKE(float3 KDEMKDBDNEH, float3 CKFEMPKOOJB, float LHBDDGJCMJN, float LIHAFDHMDFD)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct MGFDAMHAENK : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, FHKPKMHPHHB> INNLKDFIBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint DMJOODLLIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int KKOJNNCPGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int IEMHJMEKNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> HBMFOGBBPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> FCNOJKINJAP;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x76390A0", Offset = "0x76378A0", VA = "0x1876390A0", Slot = "4")]
	public void Execute(int EIJLLNMNAEA, int MDAKKDBMNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7639240", Offset = "0x7637A40", VA = "0x187639240")]
	private void JOECCDKNGJJ(int DKGJFJDODDP, ushort FIILAMHFGGA, int HNEOEICHJBG, FHKPKMHPHHB OIJKDCMBNNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct AHJMFAOGCHO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, FHKPKMHPHHB> INNLKDFIBHJ;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7630A60", Offset = "0x762F260", VA = "0x187630A60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class CLEJMKNLGHH : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool OMEFMPLKHJD;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float OACNCFAIHNP = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int GFKKOCAPBOE = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int MFHMMEFAENC = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private APNODKHKOLC DPJKOECBAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private MGFDAMHAENK NMNALGMINOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private AHJMFAOGCHO MKMJGKGCPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, FHKPKMHPHHB> KGJPCLCKGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private BCLGFOBCIFM BDAADBNGIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool ODLAOEPEIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int PILEJKAFEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<AIEKMLPPCJO> FFDDDPFIKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle AKIDCGLHAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle DDHKKLMLBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool DDLFIBJOBKG;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7636020", Offset = "0x7634820", VA = "0x187636020")]
	public CLEJMKNLGHH(RenderPassEvent EFIODEKKONB, ComputeShader NKCANLIOGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7635840", Offset = "0x7634040", VA = "0x187635840")]
	private void GDLNOMKNGMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7635AF0", Offset = "0x76342F0", VA = "0x187635AF0")]
	public void HLMHDDAEJMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2E67FE0", Offset = "0x2E667E0", VA = "0x182E67FE0")]
	public static void NDMLGKFLJPH<T>(NativeArray<T> GHAIAFELBIF, int BOOADEANLJB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7635BD0", Offset = "0x76343D0", VA = "0x187635BD0")]
	public void MNNFFNMOAMN(CameraData HDLIGIAHFHK, LightData PKEDHCFLKKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7635140", Offset = "0x7633940", VA = "0x187635140")]
	private void AFCECDCEPLF(LightData PKEDHCFLKKB, NativeArray<AIEKMLPPCJO> BBIHMNNHMCF, int FOMPGKGGDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x76358B0", Offset = "0x76340B0", VA = "0x1876358B0")]
	private void GIIHOFKCPHE(CameraData HDLIGIAHFHK, LightData PKEDHCFLKKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x76356B0", Offset = "0x7633EB0", VA = "0x1876356B0")]
	private void FHGACMMLKEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x76355B0", Offset = "0x7633DB0", VA = "0x1876355B0")]
	private void FGEIHJFHBPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7635F80", Offset = "0x7634780", VA = "0x187635F80")]
	private void ODOIHHELDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7635580", Offset = "0x7633D80", VA = "0x187635580")]
	private void FAOBLAHMFHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7635480", Offset = "0x7633C80", VA = "0x187635480", Slot = "9")]
	public override void Execute(ScriptableRenderContext IKGPEBFFMPK, RenderingData IEAEPMDAJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7635FA0", Offset = "0x76347A0", VA = "0x187635FA0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer CBAMPDLJPPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BJCPIEKMMOH : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort EMLOGBKIHGE = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float OACNCFAIHNP = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly BCLGFOBCIFM BDAADBNGIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int CNNPBPALIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private AIEKMLPPCJO[] FFDDDPFIKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 CMBHEMFEJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 CKOBMKEOLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint HADMNBNFPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int DJNBJLBCPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int JBPHMEBDBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> HBMFOGBBPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> FCNOJKINJAP;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7634900", Offset = "0x7633100", VA = "0x187634900")]
	public BJCPIEKMMOH(RenderPassEvent EFIODEKKONB, ComputeShader NKCANLIOGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x76345B0", Offset = "0x7632DB0", VA = "0x1876345B0")]
	public void MNNFFNMOAMN(CameraData HDLIGIAHFHK, LightData PKEDHCFLKKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7632BC0", Offset = "0x76313C0", VA = "0x187632BC0")]
	private void ACKBAJDPOFA(CameraData HDLIGIAHFHK, LightData PKEDHCFLKKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7633CB0", Offset = "0x76324B0", VA = "0x187633CB0")]
	public void HLMHDDAEJMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7632DC0", Offset = "0x76315C0", VA = "0x187632DC0")]
	private void AFCECDCEPLF(LightData PKEDHCFLKKB, AIEKMLPPCJO[] BBIHMNNHMCF, int FOMPGKGGDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7634720", Offset = "0x7632F20", VA = "0x187634720")]
	private void NIJDHANIPED(int EIJLLNMNAEA, int MDAKKDBMNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7633110", Offset = "0x7631910", VA = "0x187633110")]
	private void BCBMPGJKCLG(int EIJLLNMNAEA, int NELOIEKKMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7633CD0", Offset = "0x76324D0", VA = "0x187633CD0")]
	private ushort INNHFJADEDN(int EIJLLNMNAEA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7633140", Offset = "0x7631940", VA = "0x187633140")]
	private void CHMAFKGMOML(int EIJLLNMNAEA, int MDAKKDBMNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7634540", Offset = "0x7632D40", VA = "0x187634540")]
	private void MIAMEAMCPGN(int BOOADEANLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7633290", Offset = "0x7631A90", VA = "0x187633290")]
	private void FKBAIACLILH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x76331B0", Offset = "0x76319B0", VA = "0x1876331B0", Slot = "9")]
	public override void Execute(ScriptableRenderContext IKGPEBFFMPK, RenderingData IEAEPMDAJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x76348D0", Offset = "0x76330D0", VA = "0x1876348D0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer CBAMPDLJPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7633D10", Offset = "0x7632510", VA = "0x187633D10")]
	private void IPCKAEDEEOP(int FMONLAPDILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x76338A0", Offset = "0x76320A0", VA = "0x1876338A0")]
	private void GNEDIIDCKCO(uint3 KCKOAOJFMJD, uint3 JLDPLKNJAEL, ushort FMONLAPDILI, float3 BIFJDMAGCJM, float ABDKNMPMKOB, float LIHAFDHMDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7633350", Offset = "0x7631B50", VA = "0x187633350")]
	private void GANIDPNAINK(uint3 KCKOAOJFMJD, uint3 JLDPLKNJAEL, ushort FMONLAPDILI, float3 BIFJDMAGCJM, float3 MCEJPNPMFPG, float3 CKFEMPKOOJB, float ABDKNMPMKOB, float LHBDDGJCMJN, float LIHAFDHMDFD, float MBEJENFNLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x76342C0", Offset = "0x7632AC0", VA = "0x1876342C0")]
	private void JIOCOIJBCKA(ushort FMONLAPDILI, uint JIFJMILBCBB, float HFAKGKGOGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x76347D0", Offset = "0x7632FD0", VA = "0x1876347D0")]
	private float3 NPFAONBOFBH(uint3 KCKOAOJFMJD, float3 BIFJDMAGCJM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x76318C0", Offset = "0x76300C0", VA = "0x1876318C0")]
	private float HCFBFMFCGKI(float FOPGEJJLFNO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7630AA0", Offset = "0x762F2A0", VA = "0x187630AA0")]
	private float EBKCNGOGDKE(float3 KDEMKDBDNEH, float3 CKFEMPKOOJB, float LHBDDGJCMJN, float LIHAFDHMDFD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x76343B0", Offset = "0x7632BB0", VA = "0x1876343B0")]
	private void JOECCDKNGJJ(int DKGJFJDODDP, ushort FIILAMHFGGA, int HNEOEICHJBG, FHKPKMHPHHB OIJKDCMBNNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class BCLGFOBCIFM
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class PJPCECCOHLK
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int APADGDDMIFK;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int HJCOMLIIKNA;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int NGICMMKHAOH;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int CFMJHNFBOLF;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int JBNJGGDCIBC;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int PFFCLOGPGCN;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int IKGLIBFNBPK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int FELOBGFIAHP = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int DCDPFDJIDOD = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int ANCMFDKECDF = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int MKHKCAKKNMK = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int HOHBLFIOEKL = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int DOACELNFEIL = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int ENOIIANDEAO = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool ACKOOFEODJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer NIFNCODNEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture CPNMEDDBPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int PMEKNGHGJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int OGGDJECINFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int DOEMCGOGKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int NAPPGHECGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int BFAAAOHGHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader ELNKGKBONPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int KEBJPHMBMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int DPBEDNJCIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 FDHFKOABALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 GKBMHABOONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> BBPOBBDLIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> EONCGJKPNAA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> BKJANOHBBJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x14543A0", Offset = "0x1452BA0", VA = "0x1814543A0")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> JMKHKNBGJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xCF3910", Offset = "0xCF2110", VA = "0x180CF3910")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int EAIABDHLJDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xCEF3B0", Offset = "0xCEDBB0", VA = "0x180CEF3B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int HCCNFOLEKDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8B5250", Offset = "0x8B3A50", VA = "0x1808B5250")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader FNEHCLPMOMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7631E10", Offset = "0x7630610", VA = "0x187631E10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x76319D0", Offset = "0x76301D0", VA = "0x1876319D0")]
	public void BJHAOCCHMOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7632100", Offset = "0x7630900", VA = "0x187632100")]
	public void JJIBAGBIDLD(CameraData HDLIGIAHFHK, LightData PKEDHCFLKKB, int GMCPBJNDPDA, bool MIBPBCIAMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2DDC5E0", Offset = "0x2DDADE0", VA = "0x182DDC5E0")]
	private void NDMLGKFLJPH<T>(NativeArray<T> GHAIAFELBIF, int BOOADEANLJB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7631AC0", Offset = "0x76302C0", VA = "0x187631AC0")]
	public void CLGGDHOLJIM(CommandBuffer CBAMPDLJPPG, ScriptableRenderContext IKGPEBFFMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7632410", Offset = "0x7630C10", VA = "0x187632410")]
	private static void JNHFEKEAJKD(int IMNGLNLAJCE, CommandBuffer CBAMPDLJPPG, RenderBuffer IJMNOGCOMDJ, ComputeBuffer DCHNIBIPLDH, ComputeShader EDMCNGICBCO, int HMHHHBLNECN, int DJOFHCNDNJG, int IFCGPDNIJML, int MMKJDNACJMC, int BNNOMHFFJKI, int OILJKOPHPFD, int NHHEJHNKJDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x76325F0", Offset = "0x7630DF0", VA = "0x1876325F0")]
	public void NCFABFDAGOP(CommandBuffer CBAMPDLJPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7631F20", Offset = "0x7630720", VA = "0x187631F20")]
	private RenderTexture IPPBEBPDNDH(RenderTexture AMNALBIFABA, int HMHHHBLNECN, int DJOFHCNDNJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7631EA0", Offset = "0x76306A0", VA = "0x187631EA0")]
	public void FGFIELOBBJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7632910", Offset = "0x7631110", VA = "0x187632910")]
	public void NODBDCHFJBP(int NHPEEKJJOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7632BA0", Offset = "0x76313A0", VA = "0x187632BA0")]
	public BCLGFOBCIFM()
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
		public struct PIHDBIJDLJK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float MHFJMFMCGDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float LJADDENAELM;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class OPBPMEENLIC : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string KBIHMCIFIHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler ECEFAOFKELG;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int FMOKENIGCGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material LDIIALCANGE;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7639E70", Offset = "0x7638670", VA = "0x187639E70")]
			public OPBPMEENLIC(RenderPassEvent EFIODEKKONB, Material KMOLIAGHFFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7639A90", Offset = "0x7638290", VA = "0x187639A90", Slot = "9")]
			public override void Execute(ScriptableRenderContext IKGPEBFFMPK, RenderingData IEAEPMDAJII)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static PIHDBIJDLJK CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private OPBPMEENLIC m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x7639680", Offset = "0x7637E80", VA = "0x187639680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7639630", Offset = "0x7637E30", VA = "0x187639630")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7639480", Offset = "0x7637C80", VA = "0x187639480", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x76393B0", Offset = "0x7637BB0", VA = "0x1876393B0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer ALAKDHHJBKP, RenderingData IEAEPMDAJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x118AEC0", Offset = "0x11896C0", VA = "0x18118AEC0")]
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
		public struct LPBBMNBOKKF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float KJCIOHFGHDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color NLANPJNMENK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh POOPLMHJNCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve ACGIGNCKCAD;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class CKHBNGNNJGO : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string KBIHMCIFIHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler ECEFAOFKELG;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int NHPFFENLGMB;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int GOAIGNHOBBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material LDIIALCANGE;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7635060", Offset = "0x7633860", VA = "0x187635060")]
			public CKHBNGNNJGO(RenderPassEvent EFIODEKKONB, Material KMOLIAGHFFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7634DA0", Offset = "0x76335A0", VA = "0x187634DA0", Slot = "9")]
			public override void Execute(ScriptableRenderContext IKGPEBFFMPK, RenderingData IEAEPMDAJII)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static LPBBMNBOKKF CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private CKHBNGNNJGO m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x76399B0", Offset = "0x76381B0", VA = "0x1876399B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7639800", Offset = "0x7638000", VA = "0x187639800", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x76396E0", Offset = "0x7637EE0", VA = "0x1876396E0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer ALAKDHHJBKP, RenderingData IEAEPMDAJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x118AEC0", Offset = "0x11896C0", VA = "0x18118AEC0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string KGCNEJJDAEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool CHBKDJIDOOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer CBAMPDLJPPG, ScriptableRenderContext IKGPEBFFMPK, RenderingData IEAEPMDAJII);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8B6A90", Offset = "0x8B5290", VA = "0x1808B6A90")]
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
		private class FBJKGCKCAHP : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool PHALIBMEIFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> PNPJIJDMAAN;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> LBLIAHJKEFI;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7636790", Offset = "0x7634F90", VA = "0x187636790")]
			public FBJKGCKCAHP(RenderPassEvent EFIODEKKONB, bool PHALIBMEIFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7636410", Offset = "0x7634C10", VA = "0x187636410")]
			public bool NPBGKLCLCDF(CameraData HDLIGIAHFHK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7636160", Offset = "0x7634960", VA = "0x187636160", Slot = "9")]
			public override void Execute(ScriptableRenderContext IKGPEBFFMPK, RenderingData IEAEPMDAJII)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7636330", Offset = "0x7634B30", VA = "0x187636330")]
			private void HAIOJDNCGJC(PerCameraRenderEffect PFECADGFKEA, ScriptableRenderContext IKGPEBFFMPK, RenderingData IEAEPMDAJII)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private FBJKGCKCAHP m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private FBJKGCKCAHP m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x763A140", Offset = "0x7638940", VA = "0x18763A140", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x763A0B0", Offset = "0x76388B0", VA = "0x18763A0B0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer ALAKDHHJBKP, RenderingData IEAEPMDAJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x118AEC0", Offset = "0x11896C0", VA = "0x18118AEC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x763A390", Offset = "0x7638B90", VA = "0x18763A390")]
		public static void ICEMCIBBLGB(ScriptableRenderPass CGCFNPOGEAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x763A1F0", Offset = "0x76389F0", VA = "0x18763A1F0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer ALAKDHHJBKP, RenderingData IEAEPMDAJII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x118AEC0", Offset = "0x11896C0", VA = "0x18118AEC0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class KBCILCLOAOH
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 NGPCDAPDALP;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 FJNLIODEBBA;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 OPLDALALHFA;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 HHDBHFABBAN;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 DIHMEJMJMBH;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7637D90", Offset = "0x7636590", VA = "0x187637D90")]
	public static uint FBIPPFABKNG(uint KHINBLFKKED, uint NCCBPIFKDGE, uint FGIBHLJMFML)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7637DA0", Offset = "0x76365A0", VA = "0x187637DA0")]
	public static uint3 FHEILGIHKMH(float3 BALIIBCILHH, float3 NIFENDLAHNB, float3 LLKEEBGMHOP)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7637FA0", Offset = "0x76367A0", VA = "0x187637FA0")]
	public static void JHONLGPGOAP(float3 AJJEADDHFKP, float3 CMPCHLFICFK, float3 MFKOAHOIACE, float EKHPIDKNFIF, [Out] uint3 GKKPMMOINLN, [Out] uint3 JOFJHGCINPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x76378C0", Offset = "0x76360C0", VA = "0x1876378C0")]
	public static void BKGIAOPJDIM(float3 ADJBEGBKHAM, float3 AKJDNOGJHAN, float DGMMIIPLMEK, float HJDPOFJGDHO, [Out] float3 LILCKOIOLCF, [Out] float EKHPIDKNFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x76381E0", Offset = "0x76369E0", VA = "0x1876381E0")]
	private static float3 NBNIGKMIKGH(float3 HOBFHFHACFE, float3 NFGDJCDKAFI, float3 CDOJHGLKODA, float3 DOIIAHCDDMG)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class JKDJJCMPDND
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly FICDJCDJOAA NGBEFBGKLKH;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly FICDJCDJOAA LIONKBKJIBB;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly FICDJCDJOAA IIFKJLLLMAC;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly FICDJCDJOAA IPCGAJAAKCG;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly FICDJCDJOAA CENKNFKNOGP;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class HCCHNMPFDOI
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh FIDOEGFPNJC;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x76376D0", Offset = "0x7635ED0", VA = "0x1876376D0")]
	public static Mesh KKALAEHEIJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7637230", Offset = "0x7635A30", VA = "0x187637230")]
	public static Matrix4x4 KJBLKLKEFMM(Camera NIGNOFHNFLO, bool BMCMOBJGMCG = false, bool AJBGIDENFCC = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7636E70", Offset = "0x7635670", VA = "0x187636E70")]
	private static Mesh GNMNAMLAFKI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3624084607
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x763B810", Offset = "0x763A010", VA = "0x18763B810")]
	public static void JBKONBKIOAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x763B800", Offset = "0x763A000", VA = "0x18763B800")]
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
