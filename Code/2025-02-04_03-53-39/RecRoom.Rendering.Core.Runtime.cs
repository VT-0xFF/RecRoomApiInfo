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
	public class LogRegistrationIndex : CGFLIBNDCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7982190", Offset = "0x7980F90", VA = "0x187982190", Slot = "4")]
		public override void EHDMJEMLBPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
		public enum KDJDAKIJCKJ
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface NAIGDCBKPKA
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void JEMOGMDLBLA(ScriptableRenderContext MOBMLKIIAJP, List<Camera> GPIFMLDIAEO);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface BAELFKBGGEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void JEMOGMDLBLA(ScriptableRenderContext MOBMLKIIAJP, RenderingData BDOCOICCCNP);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class JOIKPNJCLLK : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x797FD60", Offset = "0x797EB60", VA = "0x18797FD60")]
			public JOIKPNJCLLK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x797FD00", Offset = "0x797EB00", VA = "0x18797FD00", Slot = "9")]
			public override void Execute(ScriptableRenderContext MOBMLKIIAJP, RenderingData BDOCOICCCNP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private JOIKPNJCLLK _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<NAIGDCBKPKA> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<NAIGDCBKPKA> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<BAELFKBGGEG> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<BAELFKBGGEG> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7986B20", Offset = "0x7985920", VA = "0x187986B20")]
		public static void AMAELIKJGCK(KDJDAKIJCKJ GJDKGIMEHCF, NAIGDCBKPKA PLGGNICKGEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x79868E0", Offset = "0x79856E0", VA = "0x1879868E0")]
		public static void ADAJHFLLKKF(KDJDAKIJCKJ GJDKGIMEHCF, NAIGDCBKPKA PLGGNICKGEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7986A60", Offset = "0x7985860", VA = "0x187986A60")]
		public static void AMAELIKJGCK(KDJDAKIJCKJ GJDKGIMEHCF, BAELFKBGGEG HJCLOPNNCMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x79869A0", Offset = "0x79857A0", VA = "0x1879869A0")]
		public static void ADAJHFLLKKF(KDJDAKIJCKJ GJDKGIMEHCF, BAELFKBGGEG HJCLOPNNCMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7986C90", Offset = "0x7985A90", VA = "0x187986C90", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7986BE0", Offset = "0x79859E0", VA = "0x187986BE0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer ANNHGGDABAO, RenderingData BDOCOICCCNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7986E80", Offset = "0x7985C80", VA = "0x187986E80", Slot = "9")]
		protected override void Dispose(bool DDCDMFJGOEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7986F90", Offset = "0x7985D90", VA = "0x187986F90")]
		private static void FFENHLIMEAK(ScriptableRenderContext MOBMLKIIAJP, List<Camera> GPIFMLDIAEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7987940", Offset = "0x7986740", VA = "0x187987940")]
		private static void OOLHCPKLEAL(ScriptableRenderContext MOBMLKIIAJP, List<Camera> GPIFMLDIAEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7987480", Offset = "0x7986280", VA = "0x187987480")]
		private static void LFKPCBINHME(ScriptableRenderContext MOBMLKIIAJP, RenderingData BDOCOICCCNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1446EB0", Offset = "0x1445CB0", VA = "0x181446EB0")]
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
		private class NIINBKJJCCP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool CONJFHCALIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<PJPBHAODIEF> PCPGLGMMODA;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x79840C0", Offset = "0x7982EC0", VA = "0x1879840C0")]
			public NIINBKJJCCP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class JOHKAPBMLBC : PreRenderManager.BAELFKBGGEG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string KJIKBFOJMGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler LIGMBOEKOAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly NIINBKJJCCP LKLBAHBGNFI;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x797FC40", Offset = "0x797EA40", VA = "0x18797FC40")]
			public JOHKAPBMLBC(NIINBKJJCCP MMNFCJHEOLO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x797F840", Offset = "0x797E640", VA = "0x18797F840", Slot = "4")]
			public void JEMOGMDLBLA(ScriptableRenderContext MOBMLKIIAJP, RenderingData BDOCOICCCNP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class OKLBNKJJEAC : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string LOLJPOOOGMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly NIINBKJJCCP MMNFCJHEOLO;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x79845C0", Offset = "0x79833C0", VA = "0x1879845C0")]
			public OKLBNKJJEAC(RenderPassEvent GIDKEBKJBAL, NIINBKJJCCP MMNFCJHEOLO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x79842B0", Offset = "0x79830B0", VA = "0x1879842B0", Slot = "9")]
			public override void Execute(ScriptableRenderContext MOBMLKIIAJP, RenderingData BDOCOICCCNP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<PJPBHAODIEF> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private JOHKAPBMLBC fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private OKLBNKJJEAC fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private NIINBKJJCCP sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x797D6D0", Offset = "0x797C4D0", VA = "0x18797D6D0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x797DA60", Offset = "0x797C860", VA = "0x18797DA60", Slot = "9")]
		protected override void Dispose(bool DDCDMFJGOEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x797D630", Offset = "0x797C430", VA = "0x18797D630", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer ANNHGGDABAO, RenderingData BDOCOICCCNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1446EB0", Offset = "0x1445CB0", VA = "0x181446EB0")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PJPBHAODIEF
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JPNKPLIMFNM(CommandBuffer CPCMFMLGIOG, Camera IJAHNFGEONI, [NotNull] UniversalAdditionalCameraData BBNJIMAEEFH, bool AMDAJAJCOLB);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OHEPNEBDPNJ(Camera IJAHNFGEONI, CommandBuffer GPGKIICPFEN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class IBNAEEDDBLD
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool MBBGKFGPHLF;
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
		private GJHBOOJNPDB _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private OPNCLAAAJKG _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7982120", Offset = "0x7980F20", VA = "0x187982120", Slot = "9")]
		protected override void Dispose(bool MMIKBOLMGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7981E60", Offset = "0x7980C60", VA = "0x187981E60")]
		private void DOAFGLIOMME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7981B10", Offset = "0x7980910", VA = "0x187981B10", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer ANNHGGDABAO, RenderingData BDOCOICCCNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1446EB0", Offset = "0x1445CB0", VA = "0x181446EB0")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class JDFDEJJKPJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x797F830", Offset = "0x797E630", VA = "0x18797F830")]
	public static int IGEHMDLHPFC(bool CKJAFNICHFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x18AE600", Offset = "0x18AD400", VA = "0x1818AE600")]
	public static int JJEJHBIOMCN(bool CKJAFNICHFF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct HFMIGHFHEEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType GNLMBPEKGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float OOGLCONFNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float OIHMOLOEHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float ELIGAFGNCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 PCMLCLABPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 LGGFDLIGEHI;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct FGNOGGHKBJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort CLBFMAEPAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float JMNPODJFPPK;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct MDECCLKDMJI : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<HFMIGHFHEEG> CKMBAFAMDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 EGLGKAPJIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 MIILKNIBBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, FGNOGGHKBJP>.ParallelWriter HGNICNKKGDK;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7982310", Offset = "0x7981110", VA = "0x187982310", Slot = "4")]
	public void Execute(int CLBFMAEPAGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7982850", Offset = "0x7981650", VA = "0x187982850")]
	private void HOAFCGEAAKF(uint3 MHKCDEEFNME, uint3 CDAIABGIMFN, ushort CLBFMAEPAGP, float3 EJFLIJFEKEJ, float GNKLEFMJABN, float COMAOOFHLAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7982BC0", Offset = "0x79819C0", VA = "0x187982BC0")]
	private void KJIBHONMDGL(uint3 MHKCDEEFNME, uint3 CDAIABGIMFN, ushort CLBFMAEPAGP, float3 EJFLIJFEKEJ, float3 HALLHFIMHLE, float3 AOMBHPDAPAN, float GNKLEFMJABN, float FIJBEFBCMIN, float COMAOOFHLAG, float MPEJEDMLGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7982220", Offset = "0x7981020", VA = "0x187982220")]
	private float3 EOEPLPMDPED(uint3 MHKCDEEFNME, float3 EJFLIJFEKEJ)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7983130", Offset = "0x7981F30", VA = "0x187983130")]
	private float PKFOIDIOJAI(float OOGLCONFNCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7983070", Offset = "0x7981E70", VA = "0x187983070")]
	private float NHEONINMMGM(float3 HPFHDMANNKM, float3 AOMBHPDAPAN, float FIJBEFBCMIN, float COMAOOFHLAG)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct EBBGJMBDJEI : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, FGNOGGHKBJP> HGNICNKKGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint MADDOCDGLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int ONLCJOMHFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int AIDJMGFILAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> BECAKNEJOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> CJJAKGKBDHB;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x797D350", Offset = "0x797C150", VA = "0x18797D350", Slot = "4")]
	public void Execute(int MAOIBEGMIGO, int CLCLJHAFCEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x797D1E0", Offset = "0x797BFE0", VA = "0x18797D1E0")]
	private void AHCJHNBEIOC(int PLOAOIECIKH, ushort IPNABDMABDG, int JFAABLDNGEE, FGNOGGHKBJP LDNLBICHIDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct GICJEEACFGA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, FGNOGGHKBJP> HGNICNKKGDK;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x797DC60", Offset = "0x797CA60", VA = "0x18797DC60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GJHBOOJNPDB : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool OBAMILFHHGO;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float IKCLFNPNGFC = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int EEHJDEGNOFA = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int GNLBBNMLHFB = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private MDECCLKDMJI FPKKPNDJILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private EBBGJMBDJEI ENLPGGBFFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private GICJEEACFGA GDJCIBKKDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, FGNOGGHKBJP> GOFGHPHBAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private KPPNOOCPAMH NGBPDNOFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool GFKNKKJOGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int DBADJMGPOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<HFMIGHFHEEG> CABEEJLKAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle BJDJKPPFHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle KHFNEJKPBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool KHPPNJLPEEL;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x797EB80", Offset = "0x797D980", VA = "0x18797EB80")]
	public GJHBOOJNPDB(RenderPassEvent GIDKEBKJBAL, ComputeShader IEONGGCGNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x797E270", Offset = "0x797D070", VA = "0x18797E270")]
	private void FHBOGAJKPGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x797E920", Offset = "0x797D720", VA = "0x18797E920")]
	public void LHMPJGBKCCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x32B3CB0", Offset = "0x32B2AB0", VA = "0x1832B3CB0")]
	public static void JHEFLAEEKOM<T>(NativeArray<T> EOOCBMPNEML, int IECADCKMGOP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x797E570", Offset = "0x797D370", VA = "0x18797E570")]
	public void LDHLHHLDBCL(CameraData BBNJIMAEEFH, LightData KLOHMDAIBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x797DE30", Offset = "0x797CC30", VA = "0x18797DE30")]
	private void DOEFMNBGNDA(LightData KLOHMDAIBLH, NativeArray<HFMIGHFHEEG> GKKANELJHAH, int HPLDBOOAPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x797E2E0", Offset = "0x797D0E0", VA = "0x18797E2E0")]
	private void GHKBEDNLJEB(CameraData BBNJIMAEEFH, LightData KLOHMDAIBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x797DCA0", Offset = "0x797CAA0", VA = "0x18797DCA0")]
	private void BKJFHJMPKDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x797EA00", Offset = "0x797D800", VA = "0x18797EA00")]
	private void NPDGAHOACCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x797E520", Offset = "0x797D320", VA = "0x18797E520")]
	private void JIDKMEGNPFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x797E540", Offset = "0x797D340", VA = "0x18797E540")]
	private void KHNNJNFCBHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x797E170", Offset = "0x797CF70", VA = "0x18797E170", Slot = "9")]
	public override void Execute(ScriptableRenderContext MOBMLKIIAJP, RenderingData BDOCOICCCNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x797EB00", Offset = "0x797D900", VA = "0x18797EB00", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer GPGKIICPFEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class OPNCLAAAJKG : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort IIINADODKDE = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float IKCLFNPNGFC = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly KPPNOOCPAMH NGBPDNOFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int MNBFMLKPMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private HFMIGHFHEEG[] CABEEJLKAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 NOINOIAFMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 KCCALDIJNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint GNLEFMAACHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int NLOLLPIEJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int ECAMCPFBDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> BECAKNEJOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> CJJAKGKBDHB;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x79863E0", Offset = "0x79851E0", VA = "0x1879863E0")]
	public OPNCLAAAJKG(RenderPassEvent GIDKEBKJBAL, ComputeShader IEONGGCGNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7985FB0", Offset = "0x7984DB0", VA = "0x187985FB0")]
	public void LDHLHHLDBCL(CameraData BBNJIMAEEFH, LightData KLOHMDAIBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x79861E0", Offset = "0x7984FE0", VA = "0x1879861E0")]
	private void PFEMNEIOJJB(CameraData BBNJIMAEEFH, LightData KLOHMDAIBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7986120", Offset = "0x7984F20", VA = "0x187986120")]
	public void LHMPJGBKCCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7984DE0", Offset = "0x7983BE0", VA = "0x187984DE0")]
	private void DOEFMNBGNDA(LightData KLOHMDAIBLH, HFMIGHFHEEG[] GKKANELJHAH, int HPLDBOOAPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x79859B0", Offset = "0x79847B0", VA = "0x1879859B0")]
	private void JIBOKLAJEMN(int MAOIBEGMIGO, int CLCLJHAFCEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7985350", Offset = "0x7984150", VA = "0x187985350")]
	private void GFNMDIMIGDJ(int MAOIBEGMIGO, int BMGBDLLODJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7985310", Offset = "0x7984110", VA = "0x187985310")]
	private ushort FPAEMBIKCNF(int MAOIBEGMIGO)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7985440", Offset = "0x7984240", VA = "0x187985440")]
	private void HGMABOKPCPL(int MAOIBEGMIGO, int CLCLJHAFCEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7986140", Offset = "0x7984F40", VA = "0x187986140")]
	private void MPEEBBPOMGN(int IECADCKMGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7985380", Offset = "0x7984180", VA = "0x187985380")]
	private void GLHBDILIFHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7985230", Offset = "0x7984030", VA = "0x187985230", Slot = "9")]
	public override void Execute(ScriptableRenderContext MOBMLKIIAJP, RenderingData BDOCOICCCNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x79861B0", Offset = "0x7984FB0", VA = "0x1879861B0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer GPGKIICPFEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7984830", Offset = "0x7983630", VA = "0x187984830")]
	private void CGPLILBNHPM(int CLBFMAEPAGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x79854B0", Offset = "0x79842B0", VA = "0x1879854B0")]
	private void HOAFCGEAAKF(uint3 MHKCDEEFNME, uint3 CDAIABGIMFN, ushort CLBFMAEPAGP, float3 EJFLIJFEKEJ, float GNKLEFMJABN, float COMAOOFHLAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7985A60", Offset = "0x7984860", VA = "0x187985A60")]
	private void KJIBHONMDGL(uint3 MHKCDEEFNME, uint3 CDAIABGIMFN, ushort CLBFMAEPAGP, float3 EJFLIJFEKEJ, float3 HALLHFIMHLE, float3 AOMBHPDAPAN, float GNKLEFMJABN, float FIJBEFBCMIN, float COMAOOFHLAG, float MPEJEDMLGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x79858C0", Offset = "0x79846C0", VA = "0x1879858C0")]
	private void HOKLCIPJPGA(ushort CLBFMAEPAGP, uint AIPFGOAAFFA, float JOODHKFNNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7985130", Offset = "0x7983F30", VA = "0x187985130")]
	private float3 EOEPLPMDPED(uint3 MHKCDEEFNME, float3 EJFLIJFEKEJ)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7983130", Offset = "0x7981F30", VA = "0x187983130")]
	private float PKFOIDIOJAI(float OOGLCONFNCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7983070", Offset = "0x7981E70", VA = "0x187983070")]
	private float NHEONINMMGM(float3 HPFHDMANNKM, float3 AOMBHPDAPAN, float FIJBEFBCMIN, float COMAOOFHLAG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x79846A0", Offset = "0x79834A0", VA = "0x1879846A0")]
	private void AHCJHNBEIOC(int PLOAOIECIKH, ushort IPNABDMABDG, int JFAABLDNGEE, FGNOGGHKBJP LDNLBICHIDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class KPPNOOCPAMH
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class OJBPPCALNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int INLDADGDHEL;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int COCEPMLBEIC;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int NKBDLBJDHJK;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int JFCHPBOINHB;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int DFNDFEPLDJD;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int MMPKEKPPHNA;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int LHDCGEADDOF;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int IICABNAKMAJ = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int CMHGIGEJMOD = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int ELDIHEKOHDH = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int LNDEDCFGHKG = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int PKLJBGLDJNF = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int APCFEJCGMBK = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int OBGFLFHCCDG = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool NLAMDGDKLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer GFIBEHDMNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture HGCJAHNGMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int KCBKOCBNBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int HIHBEDFDDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int CPFDIKCICMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int PCDILOENHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int CDBJIAFLFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader PGIEHNMDMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int NKJHMLICKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int AMCKAKJPPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 PNHOKPGJGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 LGIPJEHOPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> AGMHPPPIDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> JLOPHBONLAC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> DIPBOCFBMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x16E4E40", Offset = "0x16E3C40", VA = "0x1816E4E40")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> DPILNIGGGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xFA4DC0", Offset = "0xFA3BC0", VA = "0x180FA4DC0")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int HIOJJCNMGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xB48030", Offset = "0xB46E30", VA = "0x180B48030")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int PNKIGEJJABF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8F8F70", Offset = "0x8F7D70", VA = "0x1808F8F70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader BHOOMKOOMFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7980770", Offset = "0x797F570", VA = "0x187980770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x79810C0", Offset = "0x797FEC0", VA = "0x1879810C0")]
	public void MOHLAAINEEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7980DB0", Offset = "0x797FBB0", VA = "0x187980DB0")]
	public void MBMCPMIJEJB(CameraData BBNJIMAEEFH, LightData KLOHMDAIBLH, int HEIHHHBPBLJ, bool CKJAFNICHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x339BE30", Offset = "0x339AC30", VA = "0x18339BE30")]
	private void JHEFLAEEKOM<T>(NativeArray<T> EOOCBMPNEML, int IECADCKMGOP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7980420", Offset = "0x797F220", VA = "0x187980420")]
	public void HECEDMPDDAP(CommandBuffer GPGKIICPFEN, ScriptableRenderContext MOBMLKIIAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x79811B0", Offset = "0x797FFB0", VA = "0x1879811B0")]
	private static void NMLNDPKDBBC(int LLMLLKAKCIM, CommandBuffer GPGKIICPFEN, RenderBuffer JKKEGELIPLD, ComputeBuffer MEKNKDFPLHN, ComputeShader KMEGONOOHKH, int NEDMPEFLHON, int NINDMGLCKGP, int CCHJKLPBFMO, int FPHDJMNMOHB, int NNEOMOHLOPM, int IDJLPPJNNPP, int EAEGPGBMMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7980800", Offset = "0x797F600", VA = "0x187980800")]
	public void JLMHNEDCCPP(CommandBuffer GPGKIICPFEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7980240", Offset = "0x797F040", VA = "0x187980240")]
	private RenderTexture CCIHBHEGADA(RenderTexture IKHCAJJINOK, int NEDMPEFLHON, int NINDMGLCKGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7981390", Offset = "0x7980190", VA = "0x187981390")]
	public void OAINDNJJJHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7980B20", Offset = "0x797F920", VA = "0x187980B20")]
	public void JPMOJBJHOIN(int KJJBNJBJLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7981410", Offset = "0x7980210", VA = "0x187981410")]
	public KPPNOOCPAMH()
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
		public struct GLDGPNKMJGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float FBEOHBGNKFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float KIDFIMEENPF;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class KJOAIIPOGKA : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string JEBCIJJOLLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler EENBEHDDLKM;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int JODEILGFGMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material HIJFDHABHCK;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7980160", Offset = "0x797EF60", VA = "0x187980160")]
			public KJOAIIPOGKA(RenderPassEvent GIDKEBKJBAL, Material FAGGGCGAPOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x797FD80", Offset = "0x797EB80", VA = "0x18797FD80", Slot = "9")]
			public override void Execute(ScriptableRenderContext MOBMLKIIAJP, RenderingData BDOCOICCCNP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static GLDGPNKMJGG CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private KJOAIIPOGKA m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x7983D30", Offset = "0x7982B30", VA = "0x187983D30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7983CE0", Offset = "0x7982AE0", VA = "0x187983CE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7983B30", Offset = "0x7982930", VA = "0x187983B30", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7983A60", Offset = "0x7982860", VA = "0x187983A60", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer ANNHGGDABAO, RenderingData BDOCOICCCNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1446EB0", Offset = "0x1445CB0", VA = "0x181446EB0")]
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
		public struct AEFPGFACKGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float LDDBKLAJKLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color NCBEGCPOPBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh BHDBKAKBKJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve POJLPACBIEL;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class BMIGNLCOMOJ : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string JEBCIJJOLLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler EENBEHDDLKM;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int PMGDNABNFFP;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int BHGMCKKIGCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material HIJFDHABHCK;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x797D100", Offset = "0x797BF00", VA = "0x18797D100")]
			public BMIGNLCOMOJ(RenderPassEvent GIDKEBKJBAL, Material FAGGGCGAPOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x797CE40", Offset = "0x797BC40", VA = "0x18797CE40", Slot = "9")]
			public override void Execute(ScriptableRenderContext MOBMLKIIAJP, RenderingData BDOCOICCCNP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static AEFPGFACKGG CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private BMIGNLCOMOJ m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x7984060", Offset = "0x7982E60", VA = "0x187984060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7983EB0", Offset = "0x7982CB0", VA = "0x187983EB0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7983D90", Offset = "0x7982B90", VA = "0x187983D90", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer ANNHGGDABAO, RenderingData BDOCOICCCNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1446EB0", Offset = "0x1445CB0", VA = "0x181446EB0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string PBHPMLONDHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool GJFAABJNNHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer GPGKIICPFEN, ScriptableRenderContext MOBMLKIIAJP, RenderingData BDOCOICCCNP);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D30", Offset = "0x8F5B30", VA = "0x1808F6D30")]
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
		private class LAGJJLDOIOC : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool MKJOHGELNKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> NAGLFOLDDBK;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> OHIHBKOCELP;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7981A60", Offset = "0x7980860", VA = "0x187981A60")]
			public LAGJJLDOIOC(RenderPassEvent GIDKEBKJBAL, bool MKJOHGELNKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x79816E0", Offset = "0x79804E0", VA = "0x1879816E0")]
			public bool LPEPLKKOAHN(CameraData BBNJIMAEEFH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7981510", Offset = "0x7980310", VA = "0x187981510", Slot = "9")]
			public override void Execute(ScriptableRenderContext MOBMLKIIAJP, RenderingData BDOCOICCCNP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7981430", Offset = "0x7980230", VA = "0x187981430")]
			private void CNIGGGBNOBH(PerCameraRenderEffect INOJNKEMJGL, ScriptableRenderContext MOBMLKIIAJP, RenderingData BDOCOICCCNP)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private LAGJJLDOIOC m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private LAGJJLDOIOC m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7986520", Offset = "0x7985320", VA = "0x187986520", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7986490", Offset = "0x7985290", VA = "0x187986490", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer ANNHGGDABAO, RenderingData BDOCOICCCNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1446EB0", Offset = "0x1445CB0", VA = "0x181446EB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7986770", Offset = "0x7985570", VA = "0x187986770")]
		public static void GJDLHEFFJJD(ScriptableRenderPass GKCBKGGHKHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x79865D0", Offset = "0x79853D0", VA = "0x1879865D0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer ANNHGGDABAO, RenderingData BDOCOICCCNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1446EB0", Offset = "0x1445CB0", VA = "0x181446EB0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class HDJGLOGFFLM
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 NNCJIPFCICN;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 EDAJAIHPCBD;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 DBHPBFPPNBC;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 EMNPFFGJICF;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 OBIMJDJBLOA;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x797EE70", Offset = "0x797DC70", VA = "0x18797EE70")]
	public static uint GBHJDNCLKCF(uint LBONEMFCDEA, uint IOKFBHNPJAN, uint INHPAGIMDBF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x797EE80", Offset = "0x797DC80", VA = "0x18797EE80")]
	public static uint3 IKNECGHKFDG(float3 AKEODPFBHJE, float3 EGLGKAPJIHJ, float3 MIILKNIBBJO)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x797EC30", Offset = "0x797DA30", VA = "0x18797EC30")]
	public static void DOLKGMPPGOL(float3 HLCKOOOPBAH, float3 IKGJKBCHJGA, float3 FANPKKLLJIG, float HCPBBIGLAFG, [Out] uint3 EKHKMJNKOPK, [Out] uint3 OKDKNJBMJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x797F220", Offset = "0x797E020", VA = "0x18797F220")]
	public static void PGEFIHGNFIA(float3 GPFGLJJFJOA, float3 CMCKCNFANCC, float OIHMOLOEHFC, float FOMBGCCAFDO, [Out] float3 OAEJNGPMFAP, [Out] float HCPBBIGLAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x797F080", Offset = "0x797DE80", VA = "0x18797F080")]
	private static float3 JCPHOKMGDDA(float3 LCPMOGOIBCL, float3 MHJHIMODDLH, float3 INMLILONJHM, float3 FGFAOLKBGEP)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class FACEDPBCBMJ
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly IMOCAMGHNDM OHKKCOLBCDI;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly IMOCAMGHNDM DLEDGIJOPMJ;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly IMOCAMGHNDM MCEIABOEPKG;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly IMOCAMGHNDM ICHDHHIOELN;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly IMOCAMGHNDM MCCAGEMLBBL;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class MDGLGFOGBBH
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh HEGIIKGEHDA;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7983150", Offset = "0x7981F50", VA = "0x187983150")]
	public static Mesh BLDODAIGIGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7983200", Offset = "0x7982000", VA = "0x187983200")]
	public static Matrix4x4 NDNIAMPGNJC(Camera IJAHNFGEONI, bool DDKCEHNNJAB = false, bool ECEPDPKHGIC = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x79836A0", Offset = "0x79824A0", VA = "0x1879836A0")]
	private static Mesh PCPENAFNIBG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__1503804934
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7987BF0", Offset = "0x79869F0", VA = "0x187987BF0")]
	public static void LKCLEJJFMMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7987BE0", Offset = "0x79869E0", VA = "0x187987BE0")]
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
