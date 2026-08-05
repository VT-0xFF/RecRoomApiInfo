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
	public class LogRegistrationIndex : AOMECLICLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x89AF070", Offset = "0x89AE070", VA = "0x1889AF070", Slot = "4")]
		public override void AMNFOKHCMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
		public enum AMBPOOCKGHJ
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface LEALKLJDPFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void JOCGPOALKCE(ScriptableRenderContext IEGLIFIOOBM, List<Camera> MGFGHKANOIH);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface CEJKBILBMFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void JOCGPOALKCE(ScriptableRenderContext IEGLIFIOOBM, RenderingData IBLNNCEMGDN);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class DKDPLHOKOKC : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x89A8FD0", Offset = "0x89A7FD0", VA = "0x1889A8FD0")]
			public DKDPLHOKOKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x89A8F70", Offset = "0x89A7F70", VA = "0x1889A8F70", Slot = "9")]
			public override void Execute(ScriptableRenderContext IEGLIFIOOBM, RenderingData IBLNNCEMGDN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private DKDPLHOKOKC _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<LEALKLJDPFJ> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<LEALKLJDPFJ> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<CEJKBILBMFB> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<CEJKBILBMFB> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x89B2870", Offset = "0x89B1870", VA = "0x1889B2870")]
		public static void LBNNGKODKCI(AMBPOOCKGHJ GGBKMPHLKOG, LEALKLJDPFJ OLFFCCBNKNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x89B26F0", Offset = "0x89B16F0", VA = "0x1889B26F0")]
		public static void GPFJGOLBBFM(AMBPOOCKGHJ GGBKMPHLKOG, LEALKLJDPFJ OLFFCCBNKNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x89B2930", Offset = "0x89B1930", VA = "0x1889B2930")]
		public static void LBNNGKODKCI(AMBPOOCKGHJ GGBKMPHLKOG, CEJKBILBMFB NDOLKMMOKBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x89B27B0", Offset = "0x89B17B0", VA = "0x1889B27B0")]
		public static void GPFJGOLBBFM(AMBPOOCKGHJ GGBKMPHLKOG, CEJKBILBMFB NDOLKMMOKBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x89B23F0", Offset = "0x89B13F0", VA = "0x1889B23F0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x89B1900", Offset = "0x89B0900", VA = "0x1889B1900", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer LBNDIMGOFLA, RenderingData IBLNNCEMGDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x89B25E0", Offset = "0x89B15E0", VA = "0x1889B25E0", Slot = "9")]
		protected override void Dispose(bool EFFINLOFOIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x89B1EF0", Offset = "0x89B0EF0", VA = "0x1889B1EF0")]
		private static void CHHAJDJFDAG(ScriptableRenderContext IEGLIFIOOBM, List<Camera> MGFGHKANOIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x89B1E80", Offset = "0x89B0E80", VA = "0x1889B1E80")]
		private static void CABFIDDDJED(ScriptableRenderContext IEGLIFIOOBM, List<Camera> MGFGHKANOIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x89B19B0", Offset = "0x89B09B0", VA = "0x1889B19B0")]
		private static void BIFCGKFKKEE(ScriptableRenderContext IEGLIFIOOBM, RenderingData IBLNNCEMGDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x18A2120", Offset = "0x18A1120", VA = "0x1818A2120")]
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
		private class KLEKCNJICLI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool MJKJIOIINKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<KPIMOCNDIMD> AKGDJDABNEN;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x89AE960", Offset = "0x89AD960", VA = "0x1889AE960")]
			public KLEKCNJICLI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class IKCPNJEBKNC : PreRenderManager.CEJKBILBMFB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string CONIKMNAKAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler HNDEBCPPONA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly KLEKCNJICLI PFMMFIBGNFH;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x89AE890", Offset = "0x89AD890", VA = "0x1889AE890")]
			public IKCPNJEBKNC(KLEKCNJICLI AJMOHLMHGGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x89AE490", Offset = "0x89AD490", VA = "0x1889AE490", Slot = "4")]
			public void JOCGPOALKCE(ScriptableRenderContext IEGLIFIOOBM, RenderingData IBLNNCEMGDN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class ENAKKMHAKCK : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string ECADADJHJKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly KLEKCNJICLI AJMOHLMHGGJ;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x89AB8F0", Offset = "0x89AA8F0", VA = "0x1889AB8F0")]
			public ENAKKMHAKCK(RenderPassEvent BHEKJKJMJJC, KLEKCNJICLI AJMOHLMHGGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x89AB5E0", Offset = "0x89AA5E0", VA = "0x1889AB5E0", Slot = "9")]
			public override void Execute(ScriptableRenderContext IEGLIFIOOBM, RenderingData IBLNNCEMGDN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<KPIMOCNDIMD> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IKCPNJEBKNC fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private ENAKKMHAKCK fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private KLEKCNJICLI sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x89ABA70", Offset = "0x89AAA70", VA = "0x1889ABA70", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x89ABE00", Offset = "0x89AAE00", VA = "0x1889ABE00", Slot = "9")]
		protected override void Dispose(bool EFFINLOFOIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x89AB9D0", Offset = "0x89AA9D0", VA = "0x1889AB9D0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer LBNDIMGOFLA, RenderingData IBLNNCEMGDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x18A2120", Offset = "0x18A1120", VA = "0x1818A2120")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KPIMOCNDIMD
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OOBLINCJAJL(CommandBuffer MKMBDIMOJOD, Camera PBNOMALDNIM, [NotNull] UniversalAdditionalCameraData AELMKJMAPHI, bool DILOLAPMGOI);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NAADMKGEFLF(Camera PBNOMALDNIM, CommandBuffer BNLNEGCIGAL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class HOKCHADJHBE
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool EAIPEAIFKEJ;
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
		private PBFEICIBFDF _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private DPKBAMFIMMJ _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x89AED40", Offset = "0x89ADD40", VA = "0x1889AED40", Slot = "9")]
		protected override void Dispose(bool KFBHNDEGIEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x89AEDB0", Offset = "0x89ADDB0", VA = "0x1889AEDB0")]
		private void IPDCAPPBLKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x89AE9F0", Offset = "0x89AD9F0", VA = "0x1889AE9F0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer LBNDIMGOFLA, RenderingData IBLNNCEMGDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x18A2120", Offset = "0x18A1120", VA = "0x1818A2120")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class JHKHGHJKPAO
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x89AE950", Offset = "0x89AD950", VA = "0x1889AE950")]
	public static int BPMOLLKHPHJ(bool HHHGMNJFMIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1D762F0", Offset = "0x1D752F0", VA = "0x181D762F0")]
	public static int PNANKCGNDPJ(bool HHHGMNJFMIB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct DGFFCADEGHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType MCFLGNIPBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float KMBCFOHOEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float GHPPGCHDHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float NOPJCBGOJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 EILFCKMOPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 NBBGMBGGOAC;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct LFIEMGIELLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort ECEHGFNEIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float MAFLPECOLCJ;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct IBGNNBGCIME : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<DGFFCADEGHL> FKNMJLBCHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 OJHLBLGCAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 JMJOHHMNHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, LFIEMGIELLJ>.ParallelWriter PDNFAAHCCNE;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x89AD7E0", Offset = "0x89AC7E0", VA = "0x1889AD7E0", Slot = "4")]
	public void Execute(int ECEHGFNEIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x89ADD20", Offset = "0x89ACD20", VA = "0x1889ADD20")]
	private void INEGMBJCIGB(uint3 ODHAFDCNCJC, uint3 GJDDHABLIIL, ushort ECEHGFNEIJO, float3 KFHEMAAHFJI, float GNBHFBFEDOK, float ELFGKHODFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x89AD330", Offset = "0x89AC330", VA = "0x1889AD330")]
	private void AJNELMJNBPJ(uint3 ODHAFDCNCJC, uint3 GJDDHABLIIL, ushort ECEHGFNEIJO, float3 KFHEMAAHFJI, float3 NCNGPHIKLCC, float3 HHOOPBHGHDH, float GNBHFBFEDOK, float LKELPKDMAIL, float ELFGKHODFOC, float BLBNEHNPOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x89AE090", Offset = "0x89AD090", VA = "0x1889AE090")]
	private float3 PCFBMIOABKN(uint3 ODHAFDCNCJC, float3 KFHEMAAHFJI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x89AA8A0", Offset = "0x89A98A0", VA = "0x1889AA8A0")]
	private float JMKGGFLMMAI(float KMBCFOHOEBE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x89AABB0", Offset = "0x89A9BB0", VA = "0x1889AABB0")]
	private float ONBIMIJHGBG(float3 LFLNCFCMHLN, float3 HHOOPBHGHDH, float LKELPKDMAIL, float ELFGKHODFOC)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct IHEFFCMNFKF : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, LFIEMGIELLJ> PDNFAAHCCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint CBOKCAIDCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int KPPPOOBEFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int PGCDGPGOIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> LHAPPMCIPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> HONBHAKBCFF;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x89AE2F0", Offset = "0x89AD2F0", VA = "0x1889AE2F0", Slot = "4")]
	public void Execute(int LAHBLMJEBLM, int BFGLPEBAILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x89AE180", Offset = "0x89AD180", VA = "0x1889AE180")]
	private void EGKPJPOFHKC(int ELJMMNJHNCF, ushort IFEJAOKMGNJ, int LDDMIODDGHB, LFIEMGIELLJ ODOHHPHCPOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct EKGOLINOBKG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, LFIEMGIELLJ> PDNFAAHCCNE;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x89AB5A0", Offset = "0x89AA5A0", VA = "0x1889AB5A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PBFEICIBFDF : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool DFIMECJNIDH;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float FJJCMNLHHPB = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int KEPBILEGJDN = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int KMDBFLJECKP = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private IBGNNBGCIME GCGMNLHJBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private IHEFFCMNFKF ALKEMMCIPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private EKGOLINOBKG LGPHANBBAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, LFIEMGIELLJ> MBHHHJELAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private HGAOGKNNMAJ PGFGOFHJJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool NKCNMMCAHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int HKKCCMECFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<DGFFCADEGHL> IFKIGCNJGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle ENGPDMOMFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle ONIKOMFEKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool GHHDNNAIJKD;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x89B13A0", Offset = "0x89B03A0", VA = "0x1889B13A0")]
	public PBFEICIBFDF(RenderPassEvent BHEKJKJMJJC, ComputeShader NAFIHKMCJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x89B0780", Offset = "0x89AF780", VA = "0x1889B0780")]
	private void EIGABIIKIKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x89B0E90", Offset = "0x89AFE90", VA = "0x1889B0E90")]
	public void KCDPJJCGHGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3E332A0", Offset = "0x3E322A0", VA = "0x183E332A0")]
	public static void JLJCDOHKDDM<T>(NativeArray<T> MFIJBPNIELL, int BKLOHAHJLKP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x89B0F70", Offset = "0x89AFF70", VA = "0x1889B0F70")]
	public void KPMOADCODPN(CameraData AELMKJMAPHI, LightData NECOPKIIKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x89B0910", Offset = "0x89AF910", VA = "0x1889B0910")]
	private void HPCMCFABBKO(LightData NECOPKIIKHK, NativeArray<DGFFCADEGHL> MCLDMPGOIEH, int PPPFEHDBKII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x89B0C50", Offset = "0x89AFC50", VA = "0x1889B0C50")]
	private void JJHMEAIPCCB(CameraData AELMKJMAPHI, LightData NECOPKIIKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x89B04C0", Offset = "0x89AF4C0", VA = "0x1889B04C0")]
	private void BILAEIDBHLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x89B0680", Offset = "0x89AF680", VA = "0x1889B0680")]
	private void DNCNOOPEIFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x89B08F0", Offset = "0x89AF8F0", VA = "0x1889B08F0")]
	private void HCKFIIANMFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x89B0650", Offset = "0x89AF650", VA = "0x1889B0650")]
	private void BOGDLAHIBPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x89B07F0", Offset = "0x89AF7F0", VA = "0x1889B07F0", Slot = "9")]
	public override void Execute(ScriptableRenderContext IEGLIFIOOBM, RenderingData IBLNNCEMGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x89B1320", Offset = "0x89B0320", VA = "0x1889B1320", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer BNLNEGCIGAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DPKBAMFIMMJ : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort FILCPDHNFJN = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float FJJCMNLHHPB = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HGAOGKNNMAJ PGFGOFHJJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int ECOGDBDIKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private DGFFCADEGHL[] IFKIGCNJGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 FFDPJDMAION;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 JAGOKPOBKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint PONOMDJKIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int POGOIPOLGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int BDLFBGAJDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> LHAPPMCIPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> HONBHAKBCFF;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x89AAE10", Offset = "0x89A9E10", VA = "0x1889AAE10")]
	public DPKBAMFIMMJ(RenderPassEvent BHEKJKJMJJC, ComputeShader NAFIHKMCJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x89AA9D0", Offset = "0x89A99D0", VA = "0x1889AA9D0")]
	public void KPMOADCODPN(CameraData AELMKJMAPHI, LightData NECOPKIIKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x89A9540", Offset = "0x89A8540", VA = "0x1889A9540")]
	private void BDGCEKGHNKM(CameraData AELMKJMAPHI, LightData NECOPKIIKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x89AA8C0", Offset = "0x89A98C0", VA = "0x1889AA8C0")]
	public void KCDPJJCGHGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x89AA110", Offset = "0x89A9110", VA = "0x1889AA110")]
	private void HPCMCFABBKO(LightData NECOPKIIKHK, DGFFCADEGHL[] MCLDMPGOIEH, int PPPFEHDBKII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x89A9800", Offset = "0x89A8800", VA = "0x1889A9800")]
	private void CNIDFLIDPHL(int LAHBLMJEBLM, int BFGLPEBAILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x89AA870", Offset = "0x89A9870", VA = "0x1889AA870")]
	private void JHDOPCPKJAG(int LAHBLMJEBLM, int MFFPIAPMHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x89AA0D0", Offset = "0x89A90D0", VA = "0x1889AA0D0")]
	private ushort GOKBMOJKDOL(int LAHBLMJEBLM)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x89AADA0", Offset = "0x89A9DA0", VA = "0x1889AADA0")]
	private void PGAIHDGAPBD(int LAHBLMJEBLM, int BFGLPEBAILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x89AAB40", Offset = "0x89A9B40", VA = "0x1889AAB40")]
	private void MKOBOJDHFMC(int BKLOHAHJLKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x89A9740", Offset = "0x89A8740", VA = "0x1889A9740")]
	private void CAADFJKFKBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x89A9A40", Offset = "0x89A8A40", VA = "0x1889A9A40", Slot = "9")]
	public override void Execute(ScriptableRenderContext IEGLIFIOOBM, RenderingData IBLNNCEMGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x89AAC70", Offset = "0x89A9C70", VA = "0x1889AAC70", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer BNLNEGCIGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x89A9B20", Offset = "0x89A8B20", VA = "0x1889A9B20")]
	private void GDOFCPONLKL(int ECEHGFNEIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x89AA460", Offset = "0x89A9460", VA = "0x1889AA460")]
	private void INEGMBJCIGB(uint3 ODHAFDCNCJC, uint3 GJDDHABLIIL, ushort ECEHGFNEIJO, float3 KFHEMAAHFJI, float GNBHFBFEDOK, float ELFGKHODFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x89A8FF0", Offset = "0x89A7FF0", VA = "0x1889A8FF0")]
	private void AJNELMJNBPJ(uint3 ODHAFDCNCJC, uint3 GJDDHABLIIL, ushort ECEHGFNEIJO, float3 KFHEMAAHFJI, float3 NCNGPHIKLCC, float3 HHOOPBHGHDH, float GNBHFBFEDOK, float LKELPKDMAIL, float ELFGKHODFOC, float BLBNEHNPOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x89AA8E0", Offset = "0x89A98E0", VA = "0x1889AA8E0")]
	private void KIDAEKHAHLB(ushort ECEHGFNEIJO, uint EJDMAHBNBHO, float OKAFHJHAKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x89AACA0", Offset = "0x89A9CA0", VA = "0x1889AACA0")]
	private float3 PCFBMIOABKN(uint3 ODHAFDCNCJC, float3 KFHEMAAHFJI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x89AA8A0", Offset = "0x89A98A0", VA = "0x1889AA8A0")]
	private float JMKGGFLMMAI(float KMBCFOHOEBE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x89AABB0", Offset = "0x89A9BB0", VA = "0x1889AABB0")]
	private float ONBIMIJHGBG(float3 LFLNCFCMHLN, float3 HHOOPBHGHDH, float LKELPKDMAIL, float ELFGKHODFOC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x89A98B0", Offset = "0x89A88B0", VA = "0x1889A98B0")]
	private void EGKPJPOFHKC(int ELJMMNJHNCF, ushort IFEJAOKMGNJ, int LDDMIODDGHB, LFIEMGIELLJ ODOHHPHCPOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class HGAOGKNNMAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class OHLMDJFNBGF
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int MALHKHNPKEP;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int MOFNDEDEIMF;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int KMHGFEGOKIF;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int PJFANBMMEEP;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int JONGFOOBOEO;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int IEMEFDEGFFA;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int JLLNAHFJKDN;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int LCMAKNDMLOL = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int MKJBLJGPABP = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int ACMENLKGBCA = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int KOCDJBPLDJL = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int GGJEFMLGJIH = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int LDELNPGOGDE = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int BKKEEIKOHBL = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool NBNBBIGGLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer FNGGEKJCPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture JJCICLDNHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int DMAMKDMEBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int IABLJMOCAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int LFKIPAJMLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int FECFMEGNMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int OIJIMBOJGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader ICNEFLLDNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int BBFGMFFCEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int EKJFJDBCBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 FOJAIOHHOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 POGAIGPJNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> LMKJBPEHMFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> MEHKIMNMIDL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> FMACFMHEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x13CB500", Offset = "0x13CA500", VA = "0x1813CB500")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> GHPCLOBMABG
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x12CA2C0", Offset = "0x12C92C0", VA = "0x1812CA2C0")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int GLPBOKBDJNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAB2090", Offset = "0xAB1090", VA = "0x180AB2090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int ODJMOLIJENL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA655B0", Offset = "0xA645B0", VA = "0x180A655B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader AKMJBMHONCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x89AC5B0", Offset = "0x89AB5B0", VA = "0x1889AC5B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x89AC820", Offset = "0x89AB820", VA = "0x1889AC820")]
	public void NIIIKCLLCBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x89ACC30", Offset = "0x89ABC30", VA = "0x1889ACC30")]
	public void OPJIGFLPEGA(CameraData AELMKJMAPHI, LightData NECOPKIIKHK, int DDIBHCNODCJ, bool HHHGMNJFMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3C73570", Offset = "0x3C72570", VA = "0x183C73570")]
	private void JLJCDOHKDDM<T>(NativeArray<T> MFIJBPNIELL, int BKLOHAHJLKP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x89AC260", Offset = "0x89AB260", VA = "0x1889AC260")]
	public void GGGPCJEBDBJ(CommandBuffer BNLNEGCIGAL, ScriptableRenderContext IEGLIFIOOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x89AC640", Offset = "0x89AB640", VA = "0x1889AC640")]
	private static void NDDKOHJLIGJ(int OIOIAMKMHPJ, CommandBuffer BNLNEGCIGAL, RenderBuffer CDEGCAIEEJJ, ComputeBuffer IFOOABDBDDA, ComputeShader BFCBEDOFGLJ, int MBEICDEAPML, int DEFPPJJMNOD, int HINKMJLPNEI, int OBFPFIAJKOP, int IDKGDDGCNOE, int DKCGLBPICKM, int JDNCCBLBCFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x89AC910", Offset = "0x89AB910", VA = "0x1889AC910")]
	public void NIKLMMBMJPK(CommandBuffer BNLNEGCIGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x89AC080", Offset = "0x89AB080", VA = "0x1889AC080")]
	private RenderTexture CNNDEIBLJPB(RenderTexture NBCHIICGBIP, int MBEICDEAPML, int DEFPPJJMNOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x89AC000", Offset = "0x89AB000", VA = "0x1889AC000")]
	public void BIDPCKILNOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x89ACF40", Offset = "0x89ABF40", VA = "0x1889ACF40")]
	public void PINKLAPAHJJ(int NJLPLNMBJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x89AD1D0", Offset = "0x89AC1D0", VA = "0x1889AD1D0")]
	public HGAOGKNNMAJ()
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
		public struct EJDKLMENDME
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float BNGIGBEELFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float IAAFDDPJIKM;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class CAPMELOCJOL : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string NOBLCFMDPDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler CBNNMHJDHCJ;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int OKNMAKFFAAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material PHOMIPAKBON;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x89A8E90", Offset = "0x89A7E90", VA = "0x1889A8E90")]
			public CAPMELOCJOL(RenderPassEvent BHEKJKJMJJC, Material JNBIMACAHOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x89A8AB0", Offset = "0x89A7AB0", VA = "0x1889A8AB0", Slot = "9")]
			public override void Execute(ScriptableRenderContext IEGLIFIOOBM, RenderingData IBLNNCEMGDN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static EJDKLMENDME CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private CAPMELOCJOL m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x89AF3D0", Offset = "0x89AE3D0", VA = "0x1889AF3D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x89AF380", Offset = "0x89AE380", VA = "0x1889AF380")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x89AF1D0", Offset = "0x89AE1D0", VA = "0x1889AF1D0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x89AF100", Offset = "0x89AE100", VA = "0x1889AF100", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer LBNDIMGOFLA, RenderingData IBLNNCEMGDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x18A2120", Offset = "0x18A1120", VA = "0x1818A2120")]
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
		public struct CJODACDINLH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float MKJLFKAOOFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color EMFBAAPEKGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh CMEJPHBPLJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve KKOCPAHHLDO;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class ALKBNKFBBML : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string NOBLCFMDPDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler CBNNMHJDHCJ;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int EEFGDMNFIFP;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int FAJNFFMPIEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material PHOMIPAKBON;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x89A80C0", Offset = "0x89A70C0", VA = "0x1889A80C0")]
			public ALKBNKFBBML(RenderPassEvent BHEKJKJMJJC, Material JNBIMACAHOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x89A7E00", Offset = "0x89A6E00", VA = "0x1889A7E00", Slot = "9")]
			public override void Execute(ScriptableRenderContext IEGLIFIOOBM, RenderingData IBLNNCEMGDN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static CJODACDINLH CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private ALKBNKFBBML m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x89AF700", Offset = "0x89AE700", VA = "0x1889AF700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x89AF550", Offset = "0x89AE550", VA = "0x1889AF550", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x89AF430", Offset = "0x89AE430", VA = "0x1889AF430", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer LBNDIMGOFLA, RenderingData IBLNNCEMGDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x18A2120", Offset = "0x18A1120", VA = "0x1818A2120")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string OPLIPANOFCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool BJDBFCDLLKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer BNLNEGCIGAL, ScriptableRenderContext IEGLIFIOOBM, RenderingData IBLNNCEMGDN);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA60510", Offset = "0xA5F510", VA = "0x180A60510")]
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
		private class EDPIODLOKOP : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool KMMHMOIEMOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> KCBHLAPJCMO;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> CECIMDFDEED;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x89AB4F0", Offset = "0x89AA4F0", VA = "0x1889AB4F0")]
			public EDPIODLOKOP(RenderPassEvent BHEKJKJMJJC, bool KMMHMOIEMOI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x89AB170", Offset = "0x89AA170", VA = "0x1889AB170")]
			public bool KDGNCMBFHFE(CameraData AELMKJMAPHI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x89AAFA0", Offset = "0x89A9FA0", VA = "0x1889AAFA0", Slot = "9")]
			public override void Execute(ScriptableRenderContext IEGLIFIOOBM, RenderingData IBLNNCEMGDN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x89AAEC0", Offset = "0x89A9EC0", VA = "0x1889AAEC0")]
			private void ALGNNLKONJK(PerCameraRenderEffect INAGOJHCGHN, ScriptableRenderContext IEGLIFIOOBM, RenderingData IBLNNCEMGDN)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private EDPIODLOKOP m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private EDPIODLOKOP m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x89B14E0", Offset = "0x89B04E0", VA = "0x1889B14E0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x89B1450", Offset = "0x89B0450", VA = "0x1889B1450", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer LBNDIMGOFLA, RenderingData IBLNNCEMGDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x18A2120", Offset = "0x18A1120", VA = "0x1818A2120")]
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
		[Cpp2IlInjected.Address(RVA = "0x89B1730", Offset = "0x89B0730", VA = "0x1889B1730")]
		public static void GPLJFFFNIIP(ScriptableRenderPass PIJJAPACKBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x89B1590", Offset = "0x89B0590", VA = "0x1889B1590", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer LBNDIMGOFLA, RenderingData IBLNNCEMGDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x18A2120", Offset = "0x18A1120", VA = "0x1818A2120")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class NOCMFMOCPJM
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 MEOIOFEGEAG;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 COFBFDEBDGP;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 DEMMICLCDPB;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 FMDMJKKIIBC;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 LFGLOJHMKOD;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x89B0010", Offset = "0x89AF010", VA = "0x1889B0010")]
	public static uint FFLNGMOHHEO(uint OEFDFBLCHHF, uint GDBEEAKMPMB, uint MJLJNEFHIOB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x89B0020", Offset = "0x89AF020", VA = "0x1889B0020")]
	public static uint3 IOIMEDMGJPE(float3 EBGKGBGFPOC, float3 OJHLBLGCAHI, float3 JMJOHHMNHJA)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x89AF760", Offset = "0x89AE760", VA = "0x1889AF760")]
	public static void BHLJEBNGPOC(float3 DLJPLNBMDFJ, float3 FEJKJILJKBM, float3 DDPDMGAFOCB, float MGJGIJAADIJ, [Out] uint3 OFHNLOKGGJM, [Out] uint3 NOLIILBHNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x89AFB40", Offset = "0x89AEB40", VA = "0x1889AFB40")]
	public static void DDIOLOPIMBF(float3 HIKLKFKMFMP, float3 BCFEOEAGHNO, float GHPPGCHDHHL, float DJHBMOBMLLM, [Out] float3 MADKGCPLBKK, [Out] float MGJGIJAADIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x89AF9A0", Offset = "0x89AE9A0", VA = "0x1889AF9A0")]
	private static float3 COHBMFMDGOE(float3 AOANFHMEEAG, float3 IGLCCPKIOAL, float3 FPEJDPOLLEL, float3 NKPBILAOODK)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class HNENHFNIIOO
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly ONIHMLNNEEF BPEPCBNIJNP;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly ONIHMLNNEEF POHFLFKMEKP;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly ONIHMLNNEEF PCLFEGEOHMJ;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly ONIHMLNNEEF FLMEIBCDBNM;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly ONIHMLNNEEF HPPAMHNHGGB;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class BDOPDGPLJLO
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh KKLNMAPHPBC;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x89A8560", Offset = "0x89A7560", VA = "0x1889A8560")]
	public static Mesh LOBICFLBFCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x89A8610", Offset = "0x89A7610", VA = "0x1889A8610")]
	public static Matrix4x4 NMFBPEFOMNB(Camera PBNOMALDNIM, bool OHJDCFOAEME = false, bool PPOCPHBDHKK = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x89A81A0", Offset = "0x89A71A0", VA = "0x1889A81A0")]
	private static Mesh FLOBIMMEHGO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2816417071
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x89B2C20", Offset = "0x89B1C20", VA = "0x1889B2C20")]
	public static void ELOKOGMACMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x89B2CB0", Offset = "0x89B1CB0", VA = "0x1889B2CB0")]
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
