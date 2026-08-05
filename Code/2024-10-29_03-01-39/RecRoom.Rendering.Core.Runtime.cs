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
	public class LogRegistrationIndex : FEPIOKBKKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x75406B0", Offset = "0x753F6B0", VA = "0x1875406B0", Slot = "4")]
		public override void EPIGOBOFFNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
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
		public enum HLAAFPMEFFA
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface NFIBALEOEJM
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void IALMCJCIBIH(ScriptableRenderContext NDMMIOJEOEB, List<Camera> CLLMAADLFBF);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface MJMIDFOOPCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void IALMCJCIBIH(ScriptableRenderContext NDMMIOJEOEB, RenderingData FLENNIEKDNP);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class HMHCMCEBKHA : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x753D4E0", Offset = "0x753C4E0", VA = "0x18753D4E0")]
			public HMHCMCEBKHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x753D480", Offset = "0x753C480", VA = "0x18753D480", Slot = "9")]
			public override void Execute(ScriptableRenderContext NDMMIOJEOEB, RenderingData FLENNIEKDNP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private HMHCMCEBKHA _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<NFIBALEOEJM> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<NFIBALEOEJM> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<MJMIDFOOPCD> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<MJMIDFOOPCD> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7543450", Offset = "0x7542450", VA = "0x187543450")]
		public static void IKKIMIMIJPM(HLAAFPMEFFA FGAAICMEFPM, NFIBALEOEJM HONHEOBNMNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7543510", Offset = "0x7542510", VA = "0x187543510")]
		public static void KNGEOBLAPDA(HLAAFPMEFFA FGAAICMEFPM, NFIBALEOEJM HONHEOBNMNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7543390", Offset = "0x7542390", VA = "0x187543390")]
		public static void IKKIMIMIJPM(HLAAFPMEFFA FGAAICMEFPM, MJMIDFOOPCD PEBAEIPAAHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x75435D0", Offset = "0x75425D0", VA = "0x1875435D0")]
		public static void KNGEOBLAPDA(HLAAFPMEFFA FGAAICMEFPM, MJMIDFOOPCD PEBAEIPAAHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x75430A0", Offset = "0x75420A0", VA = "0x1875430A0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7542B50", Offset = "0x7541B50", VA = "0x187542B50", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CONCMEKGEHE, RenderingData FLENNIEKDNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7543280", Offset = "0x7542280", VA = "0x187543280", Slot = "9")]
		protected override void Dispose(bool CCOFEAOPJMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7543690", Offset = "0x7542690", VA = "0x187543690")]
		private static void LLDIKKDBGBE(ScriptableRenderContext NDMMIOJEOEB, List<Camera> CLLMAADLFBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7543B70", Offset = "0x7542B70", VA = "0x187543B70")]
		private static void OBLCLMLAPCJ(ScriptableRenderContext NDMMIOJEOEB, List<Camera> CLLMAADLFBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7542BF0", Offset = "0x7541BF0", VA = "0x187542BF0")]
		private static void CPGEJEFIDOJ(ScriptableRenderContext NDMMIOJEOEB, RenderingData FLENNIEKDNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x11C0E10", Offset = "0x11BFE10", VA = "0x1811C0E10")]
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
		private class DBDFNLHJFAJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool BCPHIEKOONN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<CICIGCFHBDF> JBHHNNCHLIG;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x753A870", Offset = "0x7539870", VA = "0x18753A870")]
			public DBDFNLHJFAJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class JGDMPLCMAOB : PreRenderManager.MJMIDFOOPCD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string IGHCMCHPNKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler AJCLMPIJMOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly DBDFNLHJFAJ DHEKIJGAKMO;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x753D9E0", Offset = "0x753C9E0", VA = "0x18753D9E0")]
			public JGDMPLCMAOB(DBDFNLHJFAJ CDGIOMLOKEA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x753D5F0", Offset = "0x753C5F0", VA = "0x18753D5F0", Slot = "4")]
			public void IALMCJCIBIH(ScriptableRenderContext NDMMIOJEOEB, RenderingData FLENNIEKDNP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class EIKFBCILKOL : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string HBKLICEKDLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly DBDFNLHJFAJ CDGIOMLOKEA;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x753BDF0", Offset = "0x753ADF0", VA = "0x18753BDF0")]
			public EIKFBCILKOL(RenderPassEvent LBPBKOMAONI, DBDFNLHJFAJ CDGIOMLOKEA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x753BAE0", Offset = "0x753AAE0", VA = "0x18753BAE0", Slot = "9")]
			public override void Execute(ScriptableRenderContext NDMMIOJEOEB, RenderingData FLENNIEKDNP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<CICIGCFHBDF> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private JGDMPLCMAOB fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private EIKFBCILKOL fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private DBDFNLHJFAJ sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x753BF60", Offset = "0x753AF60", VA = "0x18753BF60", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x753C2E0", Offset = "0x753B2E0", VA = "0x18753C2E0", Slot = "9")]
		protected override void Dispose(bool CCOFEAOPJMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x753BED0", Offset = "0x753AED0", VA = "0x18753BED0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CONCMEKGEHE, RenderingData FLENNIEKDNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x11C0E10", Offset = "0x11BFE10", VA = "0x1811C0E10")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CICIGCFHBDF
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool APDMEOGCNCK(CommandBuffer GMMINFGDPKB, Camera LDOEPMDDGHA, [NotNull] UniversalAdditionalCameraData MGJKJDHCLLC, bool IJFDOAIODCN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FNEBMFADNOG(Camera LDOEPMDDGHA, CommandBuffer EBJLAFLLLIG);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class LNAMHLHGHFH
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool JGPNBAJOPNI;
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
		private HJBAODOFCKI _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private LIIIEPBCDNA _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7540390", Offset = "0x753F390", VA = "0x187540390", Slot = "9")]
		protected override void Dispose(bool AGLCNKIHDEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7540400", Offset = "0x753F400", VA = "0x187540400")]
		private void FLCMGPHKDPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7540040", Offset = "0x753F040", VA = "0x187540040", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CONCMEKGEHE, RenderingData FLENNIEKDNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x11C0E10", Offset = "0x11BFE10", VA = "0x1811C0E10")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class CKCOOEOAELM
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x753A860", Offset = "0x7539860", VA = "0x18753A860")]
	public static int PPCIFKBEIBJ(bool NELCBPJFHJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1604320", Offset = "0x1603320", VA = "0x181604320")]
	public static int JNOAIBHFFHD(bool NELCBPJFHJI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct PNIOKAJDOLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType PIIGGKJKMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float MCJNGMGCAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float FMPNIOHIOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float FKJAEOEBPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 ENMAHOFLCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 BCJNOFHLMCG;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct GCCBBHNGMNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort HNADCBNOBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float HEMFJIFMNFH;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct MBADOONKAOD : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<PNIOKAJDOLA> DMFGLGDJBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 CBPBJLKKCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 BGJAGCNPBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, GCCBBHNGMNG>.ParallelWriter GOHLPNEKACA;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7540740", Offset = "0x753F740", VA = "0x187540740", Slot = "4")]
	public void Execute(int HNADCBNOBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7540D70", Offset = "0x753FD70", VA = "0x187540D70")]
	private void LHNGCLDFFLP(uint3 CDGJPICHDNN, uint3 BIKDBELHBFA, ushort HNADCBNOBMD, float3 FKPLCKODFGA, float NABOHDCIEEH, float HNGGMGBDLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x75410E0", Offset = "0x75400E0", VA = "0x1875410E0")]
	private void NCGKCCBBMDH(uint3 CDGJPICHDNN, uint3 BIKDBELHBFA, ushort HNADCBNOBMD, float3 FKPLCKODFGA, float3 HKBPHNODEFE, float3 ADCKCDEOBDK, float NABOHDCIEEH, float JOPKLGIFFBG, float HNGGMGBDLII, float DMILHJMILNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7540C80", Offset = "0x753FC80", VA = "0x187540C80")]
	private float3 LGNPKNKAABE(uint3 CDGJPICHDNN, float3 FKPLCKODFGA)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x753E170", Offset = "0x753D170", VA = "0x18753E170")]
	private float AOAIPJJBGHM(float MCJNGMGCAKK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x753E320", Offset = "0x753D320", VA = "0x18753E320")]
	private float EDDNNCNDIGI(float3 PHBDOIIJFFH, float3 ADCKCDEOBDK, float JOPKLGIFFBG, float HNGGMGBDLII)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct OFENBDGOFMF : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, GCCBBHNGMNG> GOHLPNEKACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint GNPOEGIAKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int AFCCLBGKNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int CABLIPDAJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> MADBFNOGIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> KNBKBLHNJFD;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x75421E0", Offset = "0x75411E0", VA = "0x1875421E0", Slot = "4")]
	public void Execute(int OAPBBGAPFBH, int MMBCDBFBLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7542070", Offset = "0x7541070", VA = "0x187542070")]
	private void DGLBHBEDGPG(int KIGMLMBEBNC, ushort MGHAAJHDGFC, int ACMEHDEEBMB, GCCBBHNGMNG MDOOIEGCBCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct HKKNHOEDIEM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, GCCBBHNGMNG> GOHLPNEKACA;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x753D440", Offset = "0x753C440", VA = "0x18753D440", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HJBAODOFCKI : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool IHIAELFNBPG;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float OBGNIHPFAEB = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int NAEGEFIHBOG = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int FIMJKNEAFFH = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private MBADOONKAOD OEPEAHGKBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private OFENBDGOFMF IPCJMJCDBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private HKKNHOEDIEM PAPIANMMKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, GCCBBHNGMNG> JGECCHFEMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private DEBHAKONCCL HHOIFAPJFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool OHODBAALGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int BDBHOKOONPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<PNIOKAJDOLA> GLOKKGJCALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle GJDCBLLMMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle DKIFNPBEKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool NBHCDMPCNML;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x753D390", Offset = "0x753C390", VA = "0x18753D390")]
	public HJBAODOFCKI(RenderPassEvent LBPBKOMAONI, ComputeShader OMADAJIIGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x753D200", Offset = "0x753C200", VA = "0x18753D200")]
	private void PAJPLJEELBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x753D270", Offset = "0x753C270", VA = "0x18753D270")]
	public void PJDHFHKHMPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2F93B90", Offset = "0x2F92B90", VA = "0x182F93B90")]
	public static void LBCLIGKCMLO<T>(NativeArray<T> CHPMBGHOEJI, int MLDINGBBEHA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x753CCA0", Offset = "0x753BCA0", VA = "0x18753CCA0")]
	public void KDHKKOIBIPM(CameraData MGJKJDHCLLC, LightData DPHHAHGPOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x753C620", Offset = "0x753B620", VA = "0x18753C620")]
	private void FKDNNHAEIDL(LightData DPHHAHGPOOA, NativeArray<PNIOKAJDOLA> AHBKHNOJFEH, int MOADMLOLBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x753C960", Offset = "0x753B960", VA = "0x18753C960")]
	private void GLIPPOPLPMP(CameraData MGJKJDHCLLC, LightData DPHHAHGPOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x753D040", Offset = "0x753C040", VA = "0x18753D040")]
	private void NFHGMOBHJGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x753CBA0", Offset = "0x753BBA0", VA = "0x18753CBA0")]
	private void IMDINAHKHMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x753C500", Offset = "0x753B500", VA = "0x18753C500")]
	private void EBBDFOCPMOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x753C4D0", Offset = "0x753B4D0", VA = "0x18753C4D0")]
	private void CCMCFOEHKGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x753C520", Offset = "0x753B520", VA = "0x18753C520", Slot = "9")]
	public override void Execute(ScriptableRenderContext NDMMIOJEOEB, RenderingData FLENNIEKDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x753D1D0", Offset = "0x753C1D0", VA = "0x18753D1D0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer EBJLAFLLLIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class LIIIEPBCDNA : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort MNOGBMPKCAJ = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float OBGNIHPFAEB = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly DEBHAKONCCL HHOIFAPJFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int DLMPDBFMHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private PNIOKAJDOLA[] GLOKKGJCALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 ALOEGBCLLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 HAOGCLCAHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint AMJCDMCJGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int CFFAGAKBCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int GNDJMDLCBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> MADBFNOGIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> KNBKBLHNJFD;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x753FF90", Offset = "0x753EF90", VA = "0x18753FF90")]
	public LIIIEPBCDNA(RenderPassEvent LBPBKOMAONI, ComputeShader OMADAJIIGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x753EB00", Offset = "0x753DB00", VA = "0x18753EB00")]
	public void KDHKKOIBIPM(CameraData MGJKJDHCLLC, LightData DPHHAHGPOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x753E3E0", Offset = "0x753D3E0", VA = "0x18753E3E0")]
	private void EIJLAGEMOII(CameraData MGJKJDHCLLC, LightData DPHHAHGPOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x753FF70", Offset = "0x753EF70", VA = "0x18753FF70")]
	public void PJDHFHKHMPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x753E6C0", Offset = "0x753D6C0", VA = "0x18753E6C0")]
	private void FKDNNHAEIDL(LightData DPHHAHGPOOA, PNIOKAJDOLA[] AHBKHNOJFEH, int MOADMLOLBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x753EA10", Offset = "0x753DA10", VA = "0x18753EA10")]
	private void JHENFGCCGBH(int OAPBBGAPFBH, int MMBCDBFBLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x753FF10", Offset = "0x753EF10", VA = "0x18753FF10")]
	private void OKMDIABCPAN(int OAPBBGAPFBH, int DCEOMHJEBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x753EAC0", Offset = "0x753DAC0", VA = "0x18753EAC0")]
	private ushort JJLMEFKIAPH(int OAPBBGAPFBH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x753ED60", Offset = "0x753DD60", VA = "0x18753ED60")]
	private void KGEHGLKOMJI(int OAPBBGAPFBH, int MMBCDBFBLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x753F890", Offset = "0x753E890", VA = "0x18753F890")]
	private void MFCHLIEENDI(int MLDINGBBEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x753F900", Offset = "0x753E900", VA = "0x18753F900")]
	private void NAJMOMMLEGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x753E5E0", Offset = "0x753D5E0", VA = "0x18753E5E0", Slot = "9")]
	public override void Execute(ScriptableRenderContext NDMMIOJEOEB, RenderingData FLENNIEKDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x753FF40", Offset = "0x753EF40", VA = "0x18753FF40", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer EBJLAFLLLIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x753EDD0", Offset = "0x753DDD0", VA = "0x18753EDD0")]
	private void KGOPDJNGLBD(int HNADCBNOBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x753F480", Offset = "0x753E480", VA = "0x18753F480")]
	private void LHNGCLDFFLP(uint3 CDGJPICHDNN, uint3 BIKDBELHBFA, ushort HNADCBNOBMD, float3 FKPLCKODFGA, float NABOHDCIEEH, float HNGGMGBDLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x753F9C0", Offset = "0x753E9C0", VA = "0x18753F9C0")]
	private void NCGKCCBBMDH(uint3 CDGJPICHDNN, uint3 BIKDBELHBFA, ushort HNADCBNOBMD, float3 FKPLCKODFGA, float3 HKBPHNODEFE, float3 ADCKCDEOBDK, float NABOHDCIEEH, float JOPKLGIFFBG, float HNGGMGBDLII, float DMILHJMILNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x753EC70", Offset = "0x753DC70", VA = "0x18753EC70")]
	private void KFJPAHGDPCD(ushort HNADCBNOBMD, uint AOFKGDHCMHO, float BJMHLKEOHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x753F380", Offset = "0x753E380", VA = "0x18753F380")]
	private float3 LGNPKNKAABE(uint3 CDGJPICHDNN, float3 FKPLCKODFGA)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x753E170", Offset = "0x753D170", VA = "0x18753E170")]
	private float AOAIPJJBGHM(float MCJNGMGCAKK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x753E320", Offset = "0x753D320", VA = "0x18753E320")]
	private float EDDNNCNDIGI(float3 PHBDOIIJFFH, float3 ADCKCDEOBDK, float JOPKLGIFFBG, float HNGGMGBDLII)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x753E190", Offset = "0x753D190", VA = "0x18753E190")]
	private void DGLBHBEDGPG(int KIGMLMBEBNC, ushort MGHAAJHDGFC, int ACMEHDEEBMB, GCCBBHNGMNG MDOOIEGCBCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class DEBHAKONCCL
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class CCDFAABBAJK
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int DCMLPFFIKDN;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int PKCJFCJDFMI;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int LIJIJNGAHOE;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int JABJJPFEFCF;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int FMEMCIGNMOM;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int HMKDFAGIBMN;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int NNPBJDGOBMH;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int NAKCEOGNDOM = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int FHDGNEKLOOL = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int GDEHKKKLHHH = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int HDMDEDDBOOH = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int DMMKKFFIDNL = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int NBOBPCGCAJK = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int BDMNHOOBODN = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool LBDJMPCHKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer LIGMKNIBOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture PCDNGOHILAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int OJGJDCBNPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int BCDCKNMDIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int JKALEDELOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int BKNELGHEFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int MOLEBOIKBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader IGKAKIDLEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int CEHFFGKPDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int PDDLMHFLOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 KLJPHPKGIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 LJHOBPBDJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> NALAGKOCNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> NNEAANEAPPE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> EEFPGHHODLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x144C500", Offset = "0x144B500", VA = "0x18144C500")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> PPDBLAPMFFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1994540", Offset = "0x1993540", VA = "0x181994540")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int MAGIJGIMJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xCF4830", Offset = "0xCF3830", VA = "0x180CF4830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int DBJCNAFJACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8B6660", Offset = "0x8B5660", VA = "0x1808B6660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader DPICKDPMCLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x753B540", Offset = "0x753A540", VA = "0x18753B540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x753AB90", Offset = "0x7539B90", VA = "0x18753AB90")]
	public void HHBFEMLFOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x753B1B0", Offset = "0x753A1B0", VA = "0x18753B1B0")]
	public void KNIJAEBIKNI(CameraData MGJKJDHCLLC, LightData DPHHAHGPOOA, int FEFMHENHOGA, bool NELCBPJFHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2DB9250", Offset = "0x2DB8250", VA = "0x182DB9250")]
	private void LBCLIGKCMLO<T>(NativeArray<T> CHPMBGHOEJI, int MLDINGBBEHA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x753AC80", Offset = "0x7539C80", VA = "0x18753AC80")]
	public void HMAMANHENBB(CommandBuffer EBJLAFLLLIG, ScriptableRenderContext NDMMIOJEOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x753B5D0", Offset = "0x753A5D0", VA = "0x18753B5D0")]
	private static void NIOBLIIOOGE(int LFLLIKJFEKG, CommandBuffer EBJLAFLLLIG, RenderBuffer ELMGPLKIBMP, ComputeBuffer ALOPOJONHHB, ComputeShader OFCHDEMFJBM, int ELEPIDIPFCB, int IJLMKKJGEFP, int ICDLELIEFHJ, int KHNKLJMJEOF, int PENHICMLIKF, int MMJEKEALHAD, int PLKEKEFANJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x753B7B0", Offset = "0x753A7B0", VA = "0x18753B7B0")]
	public void PMEMDBODHPM(CommandBuffer EBJLAFLLLIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x753AFD0", Offset = "0x7539FD0", VA = "0x18753AFD0")]
	private RenderTexture KIAPLFOKHPA(RenderTexture IADCDMLKOPD, int ELEPIDIPFCB, int IJLMKKJGEFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x753B4C0", Offset = "0x753A4C0", VA = "0x18753B4C0")]
	public void NCIMHNNLHOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x753A900", Offset = "0x7539900", VA = "0x18753A900")]
	public void EIEJNPFEIGH(int MNICGDOGDLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x753BAC0", Offset = "0x753AAC0", VA = "0x18753BAC0")]
	public DEBHAKONCCL()
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
		public struct HGFNPONKKIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float NGKJOEMDJAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float LLAGEGAPEAF;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class MKMFJECIJFL : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string NJNIHNDGJDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler JBMHJNBIFGN;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int ELNNCCMIAKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material AJBDLHDCCHD;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7541960", Offset = "0x7540960", VA = "0x187541960")]
			public MKMFJECIJFL(RenderPassEvent LBPBKOMAONI, Material BIDMCIBAHOL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7541590", Offset = "0x7540590", VA = "0x187541590", Slot = "9")]
			public override void Execute(ScriptableRenderContext NDMMIOJEOEB, RenderingData FLENNIEKDNP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static HGFNPONKKIH CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private MKMFJECIJFL m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x7541D10", Offset = "0x7540D10", VA = "0x187541D10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7541CC0", Offset = "0x7540CC0", VA = "0x187541CC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7541B10", Offset = "0x7540B10", VA = "0x187541B10", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7541A40", Offset = "0x7540A40", VA = "0x187541A40", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CONCMEKGEHE, RenderingData FLENNIEKDNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x11C0E10", Offset = "0x11BFE10", VA = "0x1811C0E10")]
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
		public struct BEEGJAMDIOC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float CCLFBPOANHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color OPPBDGJNOGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh ABGLAKEDCGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve HBBALMHBNIB;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class OMPOFNACBLP : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string NJNIHNDGJDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler JBMHJNBIFGN;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int HOFCDCJHBFN;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int JKFLMGEFOMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material AJBDLHDCCHD;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7542620", Offset = "0x7541620", VA = "0x187542620")]
			public OMPOFNACBLP(RenderPassEvent LBPBKOMAONI, Material BIDMCIBAHOL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7542380", Offset = "0x7541380", VA = "0x187542380", Slot = "9")]
			public override void Execute(ScriptableRenderContext NDMMIOJEOEB, RenderingData FLENNIEKDNP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static BEEGJAMDIOC CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private OMPOFNACBLP m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x7542020", Offset = "0x7541020", VA = "0x187542020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7541E70", Offset = "0x7540E70", VA = "0x187541E70", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7541D60", Offset = "0x7540D60", VA = "0x187541D60", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CONCMEKGEHE, RenderingData FLENNIEKDNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x11C0E10", Offset = "0x11BFE10", VA = "0x1811C0E10")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string DCHAFKLLEDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool NIGDIAKFBDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer EBJLAFLLLIG, ScriptableRenderContext NDMMIOJEOEB, RenderingData FLENNIEKDNP);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
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
		private class LGDGLFJIGJB : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool EKMNAOPENEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> IADFDBHOEAB;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> OBGFOANNEKI;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x753E0C0", Offset = "0x753D0C0", VA = "0x18753E0C0")]
			public LGDGLFJIGJB(RenderPassEvent LBPBKOMAONI, bool EKMNAOPENEM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x753DC70", Offset = "0x753CC70", VA = "0x18753DC70")]
			public bool GKAIGLPCJMK(CameraData MGJKJDHCLLC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x753DAA0", Offset = "0x753CAA0", VA = "0x18753DAA0", Slot = "9")]
			public override void Execute(ScriptableRenderContext NDMMIOJEOEB, RenderingData FLENNIEKDNP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x753DF50", Offset = "0x753CF50", VA = "0x18753DF50")]
			private void GODIMMMPDAO(PerCameraRenderEffect GHLAAFBFOMB, ScriptableRenderContext NDMMIOJEOEB, RenderingData FLENNIEKDNP)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private LGDGLFJIGJB m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private LGDGLFJIGJB m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7542790", Offset = "0x7541790", VA = "0x187542790", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7542700", Offset = "0x7541700", VA = "0x187542700", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CONCMEKGEHE, RenderingData FLENNIEKDNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x11C0E10", Offset = "0x11BFE10", VA = "0x1811C0E10")]
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
		[Cpp2IlInjected.Address(RVA = "0x75429E0", Offset = "0x75419E0", VA = "0x1875429E0")]
		public static void JOBOGFBBPEH(ScriptableRenderPass OIKEEMKGIGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7542840", Offset = "0x7541840", VA = "0x187542840", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CONCMEKGEHE, RenderingData FLENNIEKDNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x11C0E10", Offset = "0x11BFE10", VA = "0x1811C0E10")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class CIPCPPHDBKP
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 LDGEJBCLLJP;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 IPGGEMKAEAL;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 MOKNLHEPFNK;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 DPHLIHKAKNB;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 MOMLHBENLAB;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x753A0B0", Offset = "0x75390B0", VA = "0x18753A0B0")]
	public static uint KDPEJBNADHA(uint GOCMFEAMGHO, uint AEFHGLLPABH, uint CCKBGLJDEOI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7539C80", Offset = "0x7538C80", VA = "0x187539C80")]
	public static uint3 FKAJJDLJKNN(float3 PAMMLHPIJIB, float3 CBPBJLKKCMN, float3 BGJAGCNPBBC)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7539E70", Offset = "0x7538E70", VA = "0x187539E70")]
	public static void KCFOHDAIPCJ(float3 OCPCDKAHFEP, float3 GIDHPFEHMOH, float3 DGOOFNJBOAP, float PEGACPFCNHH, [Out] uint3 IDEJOMDOGOG, [Out] uint3 LBLNBMCEHAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x753A0C0", Offset = "0x75390C0", VA = "0x18753A0C0")]
	public static void LECEFAHEKCH(float3 POHHNMPDNKG, float3 BFEKGIFBOKK, float FMPNIOHIOBP, float PAAFMAGDHMK, [Out] float3 GBMBLDFBAHP, [Out] float PEGACPFCNHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x753A590", Offset = "0x7539590", VA = "0x18753A590")]
	private static float3 MDEDJPHIMJB(float3 NGBAAGLDFPN, float3 HLMAKEPLCFA, float3 NDDMINHJAHE, float3 KDGDAJEIMLM)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class JCJFHOKJNOK
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly CDBONJBDMGH ADOKMLFCPHK;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly CDBONJBDMGH MNIEILHLCMJ;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly CDBONJBDMGH IDLAKEFGFHA;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly CDBONJBDMGH GBLAPDKJNCN;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class ACEAEGJLMGE
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static Mesh GBOCNJDOPFO;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7539240", Offset = "0x7538240", VA = "0x187539240")]
	public static Mesh DNAGHHMFNJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x75396A0", Offset = "0x75386A0", VA = "0x1875396A0")]
	public static Matrix4x4 OFOIAALKPNF(Camera LDOEPMDDGHA, bool JPBJNKGMMMJ = false, bool KDOHKKGOKEA = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x75392E0", Offset = "0x75382E0", VA = "0x1875392E0")]
	private static Mesh LHBBCNJIEAA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3663159667
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7543E00", Offset = "0x7542E00", VA = "0x187543E00")]
	public static void LDFHKEIPJAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7543DF0", Offset = "0x7542DF0", VA = "0x187543DF0")]
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
