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
	public class LogRegistrationIndex : FIPEGIMCDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6660", Offset = "0x8AF5A60", VA = "0x188AF6660", Slot = "4")]
		public override void AAGBOPIEMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		public enum IKHMGKBOIKK
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface NPFHLGDNNMG
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void KMBBCCKJAHA(ScriptableRenderContext HFJHENFIDEF, List<Camera> OOMIIOOFMKN);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface CPNPJNOLMHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void KMBBCCKJAHA(ScriptableRenderContext HFJHENFIDEF, RenderingData EDDGCGMKKIK);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class FEJBDKDJADC : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8AF40B0", Offset = "0x8AF34B0", VA = "0x188AF40B0")]
			public FEJBDKDJADC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8AF4050", Offset = "0x8AF3450", VA = "0x188AF4050", Slot = "9")]
			public override void Execute(ScriptableRenderContext HFJHENFIDEF, RenderingData EDDGCGMKKIK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private FEJBDKDJADC _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<NPFHLGDNNMG> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<NPFHLGDNNMG> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<CPNPJNOLMHE> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<CPNPJNOLMHE> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9AC0", Offset = "0x8AF8EC0", VA = "0x188AF9AC0")]
		public static void EGAFNGKBFNJ(IKHMGKBOIKK BMKJIKGGKNJ, NPFHLGDNNMG DPOMEMPIKFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9640", Offset = "0x8AF8A40", VA = "0x188AF9640")]
		public static void BIIHKDJMLNK(IKHMGKBOIKK BMKJIKGGKNJ, NPFHLGDNNMG DPOMEMPIKFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9B80", Offset = "0x8AF8F80", VA = "0x188AF9B80")]
		public static void EGAFNGKBFNJ(IKHMGKBOIKK BMKJIKGGKNJ, CPNPJNOLMHE CIGOFPLNHMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9700", Offset = "0x8AF8B00", VA = "0x188AF9700")]
		public static void BIIHKDJMLNK(IKHMGKBOIKK BMKJIKGGKNJ, CPNPJNOLMHE CIGOFPLNHMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8AF97C0", Offset = "0x8AF8BC0", VA = "0x188AF97C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9590", Offset = "0x8AF8990", VA = "0x188AF9590", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FOGLHINMCEC, RenderingData EDDGCGMKKIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8AF99B0", Offset = "0x8AF8DB0", VA = "0x188AF99B0", Slot = "9")]
		protected override void Dispose(bool GHOPBBENGHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8AFA100", Offset = "0x8AF9500", VA = "0x188AFA100")]
		private static void IFPKEKNKOBD(ScriptableRenderContext HFJHENFIDEF, List<Camera> OOMIIOOFMKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8AFA5F0", Offset = "0x8AF99F0", VA = "0x188AFA5F0")]
		private static void IPMLBNCBPNB(ScriptableRenderContext HFJHENFIDEF, List<Camera> OOMIIOOFMKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9C40", Offset = "0x8AF9040", VA = "0x188AF9C40")]
		private static void GIFFFEAOPII(ScriptableRenderContext HFJHENFIDEF, RenderingData EDDGCGMKKIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x190FB10", Offset = "0x190EF10", VA = "0x18190FB10")]
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
		private class NJLALECFGMC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool JLGBOGKGJPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<AICBFPKMNBL> MPBBIHHPOIP;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8AF7250", Offset = "0x8AF6650", VA = "0x188AF7250")]
			public NJLALECFGMC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class MNDFAECBDIB : PreRenderManager.CPNPJNOLMHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string OKFBIBDMLII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler MBFCPCJDBNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly NJLALECFGMC OPNDEPPJEPA;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6B30", Offset = "0x8AF5F30", VA = "0x188AF6B30")]
			public MNDFAECBDIB(NJLALECFGMC DHDCFDKFJPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6730", Offset = "0x8AF5B30", VA = "0x188AF6730", Slot = "4")]
			public void KMBBCCKJAHA(ScriptableRenderContext HFJHENFIDEF, RenderingData EDDGCGMKKIK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class IDCHFJBKNJC : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string PHBNBPHLNJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly NJLALECFGMC DHDCFDKFJPH;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8AF5A20", Offset = "0x8AF4E20", VA = "0x188AF5A20")]
			public IDCHFJBKNJC(RenderPassEvent FLOCCDKNNLL, NJLALECFGMC DHDCFDKFJPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8AF5710", Offset = "0x8AF4B10", VA = "0x188AF5710", Slot = "9")]
			public override void Execute(ScriptableRenderContext HFJHENFIDEF, RenderingData EDDGCGMKKIK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<AICBFPKMNBL> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private MNDFAECBDIB fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IDCHFJBKNJC fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private NJLALECFGMC sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8AF4170", Offset = "0x8AF3570", VA = "0x188AF4170", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8AF4500", Offset = "0x8AF3900", VA = "0x188AF4500", Slot = "9")]
		protected override void Dispose(bool GHOPBBENGHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8AF40D0", Offset = "0x8AF34D0", VA = "0x188AF40D0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FOGLHINMCEC, RenderingData EDDGCGMKKIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x190FB10", Offset = "0x190EF10", VA = "0x18190FB10")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface AICBFPKMNBL
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KPCDBLKBGEJ(CommandBuffer JINAAECIMEH, Camera MLFNHNIBMNH, [NotNull] UniversalAdditionalCameraData JMNELOGLEIH, bool AFOANKMDNAN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KDBBJFCAJIA(Camera MLFNHNIBMNH, CommandBuffer BNKGCCLNMBE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class ECDHELLKNPP
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool NBDPJEBCDEC;
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
		private EHODFECFKAK _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private OJLKDBDIMLL _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6330", Offset = "0x8AF5730", VA = "0x188AF6330", Slot = "9")]
		protected override void Dispose(bool EMHMNEBMOBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8AF63A0", Offset = "0x8AF57A0", VA = "0x188AF63A0")]
		private void HMKJBOKCFFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8AF5FE0", Offset = "0x8AF53E0", VA = "0x188AF5FE0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FOGLHINMCEC, RenderingData EDDGCGMKKIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x190FB10", Offset = "0x190EF10", VA = "0x18190FB10")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class PBDGNCEFIIB
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8AF90D0", Offset = "0x8AF84D0", VA = "0x188AF90D0")]
	public static int IICHAPPNCHK(bool FHLCMHICBOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1DB7A70", Offset = "0x1DB6E70", VA = "0x181DB7A70")]
	public static int DODNEILGDPG(bool FHLCMHICBOD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct MOOJHDMPDIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType OEAEBJDKJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float JGPJGFPIPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float CLIKJBPKKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float AMLIJIFMDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 PAEBFHLDPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 EODFHKJCIID;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct LNFJFNGKDGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort BIMHBDJEEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float MNHBBKBJLKN;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct DNLNEJKGDPN : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<MOOJHDMPDIL> BBCPPDFNHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 LIJAGGJAPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 CFBDCBENLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, LNFJFNGKDGC>.ParallelWriter FFEBKAHIPEJ;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8AF2250", Offset = "0x8AF1650", VA = "0x188AF2250", Slot = "4")]
	public void Execute(int BIMHBDJEEKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8AF2790", Offset = "0x8AF1B90", VA = "0x188AF2790")]
	private void FFMBPHJAHPH(uint3 EBILMBCNLDK, uint3 MCNKJFBOHBH, ushort BIMHBDJEEKE, float3 PMNOBJAMJPP, float CCNKPNHNJFI, float AGOKFFJGPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8AF2B00", Offset = "0x8AF1F00", VA = "0x188AF2B00")]
	private void HONHCCODCDG(uint3 EBILMBCNLDK, uint3 MCNKJFBOHBH, ushort BIMHBDJEEKE, float3 PMNOBJAMJPP, float3 COFCMFIGJBB, float3 FBIDBCLOKGM, float CCNKPNHNJFI, float KEFDKNGKKAH, float AGOKFFJGPEH, float HEDBONKOABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8AF2FD0", Offset = "0x8AF23D0", VA = "0x188AF2FD0")]
	private float3 KDCIJDGEOPO(uint3 EBILMBCNLDK, float3 PMNOBJAMJPP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8AF2FB0", Offset = "0x8AF23B0", VA = "0x188AF2FB0")]
	private float IDDMDJLEAJL(float JGPJGFPIPNG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8AF2190", Offset = "0x8AF1590", VA = "0x188AF2190")]
	private float DNEDALBIABO(float3 DJJBHJIJHKA, float3 FBIDBCLOKGM, float KEFDKNGKKAH, float AGOKFFJGPEH)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct HCCCICKNNGM : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, LNFJFNGKDGC> FFEBKAHIPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint FANMNHDLCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int EPIIHIPEJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int PLCMDOELMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> HEAJKNGFDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> PPFNLAJBGHA;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8AF52A0", Offset = "0x8AF46A0", VA = "0x188AF52A0", Slot = "4")]
	public void Execute(int AFOMEGIEOAK, int JOAMMONIJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8AF5440", Offset = "0x8AF4840", VA = "0x188AF5440")]
	private void OAOCNOFFEDM(int IIBCOCNGDCP, ushort FABCGELNNDA, int OOOIGJJJCMI, LNFJFNGKDGC AJODIHHAOOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct MCEBMMLAHHJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, LNFJFNGKDGC> FFEBKAHIPEJ;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8AF66F0", Offset = "0x8AF5AF0", VA = "0x188AF66F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class EHODFECFKAK : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool LBGPDADHKMB;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float IHLBFEBHKPK = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int AOLLPNBFOGH = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int BLKIJPGKKBB = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private DNLNEJKGDPN OJHHHBAIJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private HCCCICKNNGM PACCGHJPILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private MCEBMMLAHHJ CLKAIPCKOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, LNFJFNGKDGC> NEAAMGFKHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private BBEOOFPFHAO GJCOLHDCNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool EEHGGHIAPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int EEAOOJABNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<MOOJHDMPDIL> LKJAHIHMCIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle BBOPOFHPJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle NPDDGMCFIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool AKOONJPHHFH;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8AF3FA0", Offset = "0x8AF33A0", VA = "0x188AF3FA0")]
	public EHODFECFKAK(RenderPassEvent FLOCCDKNNLL, ComputeShader OPFFAGKLPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8AF3330", Offset = "0x8AF2730", VA = "0x188AF3330")]
	private void ELEAOOGCIMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8AF3750", Offset = "0x8AF2B50", VA = "0x188AF3750")]
	public void IMBFNMNBGIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3B30F40", Offset = "0x3B30340", VA = "0x183B30F40")]
	public static void NCNBKDCDKBK<T>(NativeArray<T> LMLCJEFLFMP, int MPDDFCCPIOM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8AF3BA0", Offset = "0x8AF2FA0", VA = "0x188AF3BA0")]
	public void PFBBCBKOCOG(CameraData JMNELOGLEIH, LightData MNODLACPIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8AF3830", Offset = "0x8AF2C30", VA = "0x188AF3830")]
	private void JPCJGOPFBCN(LightData MNODLACPIJJ, NativeArray<MOOJHDMPDIL> BMFAIFMCMKD, int LFHKEBHKONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8AF30C0", Offset = "0x8AF24C0", VA = "0x188AF30C0")]
	private void BBLILPKKMEE(CameraData JMNELOGLEIH, LightData MNODLACPIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8AF34C0", Offset = "0x8AF28C0", VA = "0x188AF34C0")]
	private void HALBCIIKCOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8AF3650", Offset = "0x8AF2A50", VA = "0x188AF3650")]
	private void ICIDIBGEIAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8AF34A0", Offset = "0x8AF28A0", VA = "0x188AF34A0")]
	private void GMJDHKGOJCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8AF3300", Offset = "0x8AF2700", VA = "0x188AF3300")]
	private void BDNPLEJPFMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8AF33A0", Offset = "0x8AF27A0", VA = "0x188AF33A0", Slot = "9")]
	public override void Execute(ScriptableRenderContext HFJHENFIDEF, RenderingData EDDGCGMKKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8AF3B70", Offset = "0x8AF2F70", VA = "0x188AF3B70", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer BNKGCCLNMBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class OJLKDBDIMLL : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort OAKBLIBOLKD = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float IHLBFEBHKPK = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly BBEOOFPFHAO GJCOLHDCNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int FHJIBIPCKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private MOOJHDMPDIL[] LKJAHIHMCIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 LGBPCABBBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 JEHJIBELKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint BHEBOGAHNDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int GKEKHEIKGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int EPJPHFHBDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> HEAJKNGFDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> PPFNLAJBGHA;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8AF9020", Offset = "0x8AF8420", VA = "0x188AF9020")]
	public OJLKDBDIMLL(RenderPassEvent FLOCCDKNNLL, ComputeShader OPFFAGKLPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8AF8E80", Offset = "0x8AF8280", VA = "0x188AF8E80")]
	public void PFBBCBKOCOG(CameraData JMNELOGLEIH, LightData MNODLACPIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8AF8430", Offset = "0x8AF7830", VA = "0x188AF8430")]
	private void KHEPJEIJIOG(CameraData JMNELOGLEIH, LightData MNODLACPIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8AF7FC0", Offset = "0x8AF73C0", VA = "0x188AF7FC0")]
	public void IMBFNMNBGIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8AF7FE0", Offset = "0x8AF73E0", VA = "0x188AF7FE0")]
	private void JPCJGOPFBCN(LightData MNODLACPIJJ, MOOJHDMPDIL[] BMFAIFMCMKD, int LFHKEBHKONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8AF72E0", Offset = "0x8AF66E0", VA = "0x188AF72E0")]
	private void CFAEBDBKJFJ(int AFOMEGIEOAK, int JOAMMONIJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8AF8FF0", Offset = "0x8AF83F0", VA = "0x188AF8FF0")]
	private void PJICOEEECDF(int AFOMEGIEOAK, int PPNAGMANAKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8AF7940", Offset = "0x8AF6D40", VA = "0x188AF7940")]
	private ushort HAIABHIGIDC(int AFOMEGIEOAK)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8AF8630", Offset = "0x8AF7A30", VA = "0x188AF8630")]
	private void LKAHOJDPANC(int AFOMEGIEOAK, int JOAMMONIJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8AF86A0", Offset = "0x8AF7AA0", VA = "0x188AF86A0")]
	private void NAIIIOPJJLI(int MPDDFCCPIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8AF7390", Offset = "0x8AF6790", VA = "0x188AF7390")]
	private void DNBBHFAEGIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8AF7450", Offset = "0x8AF6850", VA = "0x188AF7450", Slot = "9")]
	public override void Execute(ScriptableRenderContext HFJHENFIDEF, RenderingData EDDGCGMKKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8AF8E50", Offset = "0x8AF8250", VA = "0x188AF8E50", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer BNKGCCLNMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8AF8710", Offset = "0x8AF7B10", VA = "0x188AF8710")]
	private void NDECFLHFFDD(int BIMHBDJEEKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8AF7530", Offset = "0x8AF6930", VA = "0x188AF7530")]
	private void FFMBPHJAHPH(uint3 EBILMBCNLDK, uint3 MCNKJFBOHBH, ushort BIMHBDJEEKE, float3 PMNOBJAMJPP, float CCNKPNHNJFI, float AGOKFFJGPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8AF7A70", Offset = "0x8AF6E70", VA = "0x188AF7A70")]
	private void HONHCCODCDG(uint3 EBILMBCNLDK, uint3 MCNKJFBOHBH, ushort BIMHBDJEEKE, float3 PMNOBJAMJPP, float3 COFCMFIGJBB, float3 FBIDBCLOKGM, float CCNKPNHNJFI, float KEFDKNGKKAH, float AGOKFFJGPEH, float HEDBONKOABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8AF7980", Offset = "0x8AF6D80", VA = "0x188AF7980")]
	private void HOCINCPNLHL(ushort BIMHBDJEEKE, uint EAOIJPAMKJM, float IEMDFMHIKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8AF8330", Offset = "0x8AF7730", VA = "0x188AF8330")]
	private float3 KDCIJDGEOPO(uint3 EBILMBCNLDK, float3 PMNOBJAMJPP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8AF2FB0", Offset = "0x8AF23B0", VA = "0x188AF2FB0")]
	private float IDDMDJLEAJL(float JGPJGFPIPNG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8AF2190", Offset = "0x8AF1590", VA = "0x188AF2190")]
	private float DNEDALBIABO(float3 DJJBHJIJHKA, float3 FBIDBCLOKGM, float KEFDKNGKKAH, float AGOKFFJGPEH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8AF8CC0", Offset = "0x8AF80C0", VA = "0x188AF8CC0")]
	private void OAOCNOFFEDM(int IIBCOCNGDCP, ushort FABCGELNNDA, int OOOIGJJJCMI, LNFJFNGKDGC AJODIHHAOOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class BBEOOFPFHAO
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class IBBMOBCKKCA
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int KFHLGMBOBIK;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int DPHDNCCPNAD;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int AFHBKGJPDFJ;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int BDLNKBMHFDK;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int BDAAMJCLFDF;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int KMLJAGJDHCI;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int CEKKGADKGOG;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int ICMMMCGBGIJ = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int HKBONCLJOEB = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int NHEDFCKIJGO = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int GDGMDOFGFME = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int PGEJLOIJMBC = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int OMIBKLFJGJF = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int JILBEJPHIJO = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool PDBNLHHKNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer BHBIKKELBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture CGIPPCPCGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int BMNAJKKDBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int JGLCGIFJABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int ABEEGBAFCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int MKNEOJCEAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int DBFGKFFKPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader NIJGGMCFBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int BBMKAINBGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int LFDBKGLOMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 IOKALKNFLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 HIJNFDELCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> IGAKGLPBIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> AJJMJEBOKKP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> DACDACHIHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x13F8360", Offset = "0x13F7760", VA = "0x1813F8360")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> EMCBPHNDGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x12F8B60", Offset = "0x12F7F60", VA = "0x1812F8B60")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int CEKMOOJEBFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xABF670", Offset = "0xABEA70", VA = "0x180ABF670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int CNBKOGKLDFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA6D130", Offset = "0xA6C530", VA = "0x180A6D130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader JBBGAFKEMNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8AF0BD0", Offset = "0x8AEFFD0", VA = "0x188AF0BD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8AF0430", Offset = "0x8AEF830", VA = "0x188AF0430")]
	public void HNJLALOFPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8AF08C0", Offset = "0x8AEFCC0", VA = "0x188AF08C0")]
	public void OCIBOPLMHNE(CameraData JMNELOGLEIH, LightData MNODLACPIJJ, int AFNPGBHBHPB, bool FHLCMHICBOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3A3D6D0", Offset = "0x3A3CAD0", VA = "0x183A3D6D0")]
	private void NCNBKDCDKBK<T>(NativeArray<T> LMLCJEFLFMP, int MPDDFCCPIOM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8AEFE50", Offset = "0x8AEF250", VA = "0x188AEFE50")]
	public void DDMFBFMANMI(CommandBuffer BNKGCCLNMBE, ScriptableRenderContext HFJHENFIDEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8AEFA90", Offset = "0x8AEEE90", VA = "0x188AEFA90")]
	private static void BLDDNEIIELG(int OFHBJIOCLKN, CommandBuffer BNKGCCLNMBE, RenderBuffer HNDLFBEFLPA, ComputeBuffer HCBBOBEHLGB, ComputeShader EEMKDLNBAAL, int CCJAOOFIEKD, int FKHPKGKJDMO, int MMIAMELOJNK, int BPIKOJDEBDM, int GDLIGAKAPNK, int GJJHJDOPNHC, int MNEHKENJLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8AF0520", Offset = "0x8AEF920", VA = "0x188AF0520")]
	public void LDJKNKPFOJF(CommandBuffer BNKGCCLNMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8AEFC70", Offset = "0x8AEF070", VA = "0x188AEFC70")]
	private RenderTexture COABFGMJABH(RenderTexture DPBPJJBPODL, int CCJAOOFIEKD, int FKHPKGKJDMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8AF0840", Offset = "0x8AEFC40", VA = "0x188AF0840")]
	public void NNFNMAHOKKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8AF01A0", Offset = "0x8AEF5A0", VA = "0x188AF01A0")]
	public void EAMBKFBCHGO(int MAEEBHAPLIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8AF0C60", Offset = "0x8AF0060", VA = "0x188AF0C60")]
	public BBEOOFPFHAO()
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
		public struct DCJNFLHFMKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float OJMKFNHMKOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float ADEMCGLIOGI;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class GNNKEMJAFPM : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string NDCNHJOKCDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler JHGCPFGLINH;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int ELHCGKBIOHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material JJIIHFKEFGP;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8AF51C0", Offset = "0x8AF45C0", VA = "0x188AF51C0")]
			public GNNKEMJAFPM(RenderPassEvent FLOCCDKNNLL, Material GMFBEMFEGJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8AF4DE0", Offset = "0x8AF41E0", VA = "0x188AF4DE0", Slot = "9")]
			public override void Execute(ScriptableRenderContext HFJHENFIDEF, RenderingData EDDGCGMKKIK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static DCJNFLHFMKJ CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private GNNKEMJAFPM m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x8AF6EC0", Offset = "0x8AF62C0", VA = "0x188AF6EC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E70", Offset = "0x8AF6270", VA = "0x188AF6E70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6CC0", Offset = "0x8AF60C0", VA = "0x188AF6CC0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6BF0", Offset = "0x8AF5FF0", VA = "0x188AF6BF0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FOGLHINMCEC, RenderingData EDDGCGMKKIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x190FB10", Offset = "0x190EF10", VA = "0x18190FB10")]
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
		public struct LAPNOGNCKJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float GFIBCIKDONP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color ELHGFPDACFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh BPMNKBEEGMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve GLBIEAECJFC;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class KCPCHCFJCNE : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string NDCNHJOKCDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler JHGCPFGLINH;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int FEJGNAFGEHN;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int MAMDKOOBIAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material JJIIHFKEFGP;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8AF5F00", Offset = "0x8AF5300", VA = "0x188AF5F00")]
			public KCPCHCFJCNE(RenderPassEvent FLOCCDKNNLL, Material GMFBEMFEGJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8AF5C40", Offset = "0x8AF5040", VA = "0x188AF5C40", Slot = "9")]
			public override void Execute(ScriptableRenderContext HFJHENFIDEF, RenderingData EDDGCGMKKIK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static LAPNOGNCKJD CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private KCPCHCFJCNE m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x8AF71F0", Offset = "0x8AF65F0", VA = "0x188AF71F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8AF7040", Offset = "0x8AF6440", VA = "0x188AF7040", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6F20", Offset = "0x8AF6320", VA = "0x188AF6F20", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FOGLHINMCEC, RenderingData EDDGCGMKKIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x190FB10", Offset = "0x190EF10", VA = "0x18190FB10")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string OIFFBDJEDBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool JEPHMJKPPBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer BNKGCCLNMBE, ScriptableRenderContext HFJHENFIDEF, RenderingData EDDGCGMKKIK);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
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
		private class GHCLHCMEKFD : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool JPIDLDEBCFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> DCEGHLMDOOD;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> PKMKFJLFHPH;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8AF4D30", Offset = "0x8AF4130", VA = "0x188AF4D30")]
			public GHCLHCMEKFD(RenderPassEvent FLOCCDKNNLL, bool JPIDLDEBCFK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8AF4700", Offset = "0x8AF3B00", VA = "0x188AF4700")]
			public bool BOLDNADPGLN(CameraData JMNELOGLEIH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8AF49F0", Offset = "0x8AF3DF0", VA = "0x188AF49F0", Slot = "9")]
			public override void Execute(ScriptableRenderContext HFJHENFIDEF, RenderingData EDDGCGMKKIK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8AF4BC0", Offset = "0x8AF3FC0", VA = "0x188AF4BC0")]
			private void KJDFIOKCIEF(PerCameraRenderEffect EIDFOCCHGMN, ScriptableRenderContext HFJHENFIDEF, RenderingData EDDGCGMKKIK)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private GHCLHCMEKFD m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private GHCLHCMEKFD m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9170", Offset = "0x8AF8570", VA = "0x188AF9170", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8AF90E0", Offset = "0x8AF84E0", VA = "0x188AF90E0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FOGLHINMCEC, RenderingData EDDGCGMKKIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x190FB10", Offset = "0x190EF10", VA = "0x18190FB10")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AF93C0", Offset = "0x8AF87C0", VA = "0x188AF93C0")]
		public static void ODOKLPDHIHK(ScriptableRenderPass EGAMPBCJEGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9220", Offset = "0x8AF8620", VA = "0x188AF9220", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FOGLHINMCEC, RenderingData EDDGCGMKKIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x190FB10", Offset = "0x190EF10", VA = "0x18190FB10")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class DJIJBLCKAOD
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 NMKLAJLAAPN;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 GBIOINPFEAJ;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 EFALODLGMGH;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 JJFGKODMFJP;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 LMPGHKIPNBC;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8AF1EA0", Offset = "0x8AF12A0", VA = "0x188AF1EA0")]
	public static uint JJMCKAPKNCC(uint FNBJHADJBNG, uint MODFPFNICHM, uint CACADFINDPI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8AF1590", Offset = "0x8AF0990", VA = "0x188AF1590")]
	public static uint3 CJDHBLCMCGE(float3 LBCFHLNAPLC, float3 LIJAGGJAPNA, float3 CFBDCBENLKA)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8AF1C60", Offset = "0x8AF1060", VA = "0x188AF1C60")]
	public static void DMFHIPPHKNB(float3 HLGMPNDKDDI, float3 MHFFLPKGPBA, float3 KGEPFMDFDOM, float FLMDAOGEKMO, [Out] uint3 EBGCEHJGCPC, [Out] uint3 INCNJGKELPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8AF1790", Offset = "0x8AF0B90", VA = "0x188AF1790")]
	public static void COHNMPDFFPK(float3 MEIOCFLNFAO, float3 DAKDMBLJEON, float CLIKJBPKKKI, float BCLMELACLGK, [Out] float3 GHMCFDBPIAB, [Out] float FLMDAOGEKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8AF1EB0", Offset = "0x8AF12B0", VA = "0x188AF1EB0")]
	private static float3 OHIECHIMHAM(float3 BABGMICDGCB, float3 AABCNDJPMPJ, float3 OHAFKNFDIML, float3 CKNBDICCBKE)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class JBJBPECFEAG
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly AKNCNLDICPO DHJGONIIKOK;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly AKNCNLDICPO MFDAFBOKBLL;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly AKNCNLDICPO KNMNBMJCBAC;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly AKNCNLDICPO EPCFFDNGJFG;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly AKNCNLDICPO CAKNBGEIBPP;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class CCMJONCDEKJ
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh PLOLIIBPLPK;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8AF1120", Offset = "0x8AF0520", VA = "0x188AF1120")]
	public static Mesh IDKNGPEMEJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8AF0C80", Offset = "0x8AF0080", VA = "0x188AF0C80")]
	public static Matrix4x4 EOGDOMDJODG(Camera MLFNHNIBMNH, bool IBECAGHPJMK = false, bool EMMAPLFFLJB = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8AF11D0", Offset = "0x8AF05D0", VA = "0x188AF11D0")]
	private static Mesh LMKHACLAJDC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3458916346
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8AFA8A0", Offset = "0x8AF9CA0", VA = "0x188AFA8A0")]
	public static void GFGHLGNFNKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8AFA890", Offset = "0x8AF9C90", VA = "0x188AFA890")]
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
