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
	public class LogRegistrationIndex : CFJIINPOLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x87C3990", Offset = "0x87C1F90", VA = "0x1887C3990", Slot = "4")]
		public override void CCHHFLKMKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		public enum MFOFCFPNKEP
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface PHMIGGKBDJO
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void NJPLCABILLF(ScriptableRenderContext HILCMKALFIH, List<Camera> BDPKBKFAADL);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface PONCBBFBKKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void NJPLCABILLF(ScriptableRenderContext HILCMKALFIH, RenderingData LKKIOIJICHO);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class GCPHOKJLLJK : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x87C20C0", Offset = "0x87C06C0", VA = "0x1887C20C0")]
			public GCPHOKJLLJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x87C2060", Offset = "0x87C0660", VA = "0x1887C2060", Slot = "9")]
			public override void Execute(ScriptableRenderContext HILCMKALFIH, RenderingData LKKIOIJICHO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private GCPHOKJLLJK _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<PHMIGGKBDJO> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<PHMIGGKBDJO> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<PONCBBFBKKM> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<PONCBBFBKKM> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87C6210", Offset = "0x87C4810", VA = "0x1887C6210")]
		public static void IHNIOFBJDEG(MFOFCFPNKEP JDGKBICGJPN, PHMIGGKBDJO FLKCAOOMLOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x87C6860", Offset = "0x87C4E60", VA = "0x1887C6860")]
		public static void LLFHMDIFINP(MFOFCFPNKEP JDGKBICGJPN, PHMIGGKBDJO FLKCAOOMLOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x87C62D0", Offset = "0x87C48D0", VA = "0x1887C62D0")]
		public static void IHNIOFBJDEG(MFOFCFPNKEP JDGKBICGJPN, PONCBBFBKKM PKMOCLDFMAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x87C6920", Offset = "0x87C4F20", VA = "0x1887C6920")]
		public static void LLFHMDIFINP(MFOFCFPNKEP JDGKBICGJPN, PONCBBFBKKM PKMOCLDFMAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x87C5F10", Offset = "0x87C4510", VA = "0x1887C5F10", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x87C5E60", Offset = "0x87C4460", VA = "0x1887C5E60", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer ILMDPGBOCFL, RenderingData LKKIOIJICHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x87C6100", Offset = "0x87C4700", VA = "0x1887C6100", Slot = "9")]
		protected override void Dispose(bool DGAIMJLCBIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x87C69E0", Offset = "0x87C4FE0", VA = "0x1887C69E0")]
		private static void MGAIBHGODOC(ScriptableRenderContext HILCMKALFIH, List<Camera> BDPKBKFAADL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x87C6EE0", Offset = "0x87C54E0", VA = "0x1887C6EE0")]
		private static void PJHBJDDJGFC(ScriptableRenderContext HILCMKALFIH, List<Camera> BDPKBKFAADL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x87C6390", Offset = "0x87C4990", VA = "0x1887C6390")]
		private static void IIJNMANKKOB(ScriptableRenderContext HILCMKALFIH, RenderingData LKKIOIJICHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x180D250", Offset = "0x180B850", VA = "0x18180D250")]
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
		private class DGGAICODDKN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool MJFAEINBGNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<MMHBOIJCKLD> EJLOLDHDECO;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x87BEA60", Offset = "0x87BD060", VA = "0x1887BEA60")]
			public DGGAICODDKN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class NAIIAEGALDE : PreRenderManager.PONCBBFBKKM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string NFBOBDKAHLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler FJPDDLFIPPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly DGGAICODDKN KAGBCKNDKPE;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x87C5420", Offset = "0x87C3A20", VA = "0x1887C5420")]
			public NAIIAEGALDE(DGGAICODDKN DFAMFMFDPJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x87C5010", Offset = "0x87C3610", VA = "0x1887C5010", Slot = "4")]
			public void NJPLCABILLF(ScriptableRenderContext HILCMKALFIH, RenderingData LKKIOIJICHO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class NGFOINPIKFG : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string FPOMOIJIEJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly DGGAICODDKN DFAMFMFDPJP;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x87C57F0", Offset = "0x87C3DF0", VA = "0x1887C57F0")]
			public NGFOINPIKFG(RenderPassEvent EIAEFJKKDOC, DGGAICODDKN DFAMFMFDPJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x87C54E0", Offset = "0x87C3AE0", VA = "0x1887C54E0", Slot = "9")]
			public override void Execute(ScriptableRenderContext HILCMKALFIH, RenderingData LKKIOIJICHO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<MMHBOIJCKLD> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private NAIIAEGALDE fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private NGFOINPIKFG fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private DGGAICODDKN sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x87C1AD0", Offset = "0x87C00D0", VA = "0x1887C1AD0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x87C1E60", Offset = "0x87C0460", VA = "0x1887C1E60", Slot = "9")]
		protected override void Dispose(bool DGAIMJLCBIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x87C1A30", Offset = "0x87C0030", VA = "0x1887C1A30", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer ILMDPGBOCFL, RenderingData LKKIOIJICHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x180D250", Offset = "0x180B850", VA = "0x18180D250")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MMHBOIJCKLD
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GKECCOCFCFM(CommandBuffer ODLNIBAGFNB, Camera CHOCCMBOAGC, [NotNull] UniversalAdditionalCameraData FOMILIBGBKF, bool PCHMKCOLBAD);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EAABBIBLFHP(Camera CHOCCMBOAGC, CommandBuffer FFKNKOEBEEH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PFIPEPHFNGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool IILAMCDGANH;
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
		private MJFLHFOJNJC _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private FEMJFAGILJN _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x87C3660", Offset = "0x87C1C60", VA = "0x1887C3660", Slot = "9")]
		protected override void Dispose(bool HBEEALGGPEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x87C36D0", Offset = "0x87C1CD0", VA = "0x1887C36D0")]
		private void FIJKCGPDECK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x87C3310", Offset = "0x87C1910", VA = "0x1887C3310", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer ILMDPGBOCFL, RenderingData LKKIOIJICHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x180D250", Offset = "0x180B850", VA = "0x18180D250")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DFPGDBMMMAP
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x87BEA50", Offset = "0x87BD050", VA = "0x1887BEA50")]
	public static int ENNABNGMNJL(bool KGPNMMGGLPH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1CCC520", Offset = "0x1CCAB20", VA = "0x181CCC520")]
	public static int GKHEILOAKGO(bool KGPNMMGGLPH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct NPOJBFBKICI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType HEKMKHFCBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float LDHMNPPJOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float EHECCAJFJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float EBGOFIMECLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 JHMOCOKHJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 BLNIBDEHFJA;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct PHGBCCBJHIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort HPONIDAOGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float MOLFNKCGKLO;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct JPPLNLGDPDM : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<NPOJBFBKICI> EGLGGEOCKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 OICHBFDLDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 FEFKINNFLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, PHGBCCBJHIO>.ParallelWriter CMKMOCOOCJJ;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x87C2570", Offset = "0x87C0B70", VA = "0x1887C2570", Slot = "4")]
	public void Execute(int HPONIDAOGIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x87C2F60", Offset = "0x87C1560", VA = "0x1887C2F60")]
	private void JCOJBMLBGBP(uint3 EMKPDNFPLBD, uint3 DHDNEAFHKBJ, ushort HPONIDAOGIA, float3 GIFPPBLIEHC, float KCMCPKJPDIB, float FDBFKNABCLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x87C2AB0", Offset = "0x87C10B0", VA = "0x1887C2AB0")]
	private void GAHEBHMGIPO(uint3 EMKPDNFPLBD, uint3 DHDNEAFHKBJ, ushort HPONIDAOGIA, float3 GIFPPBLIEHC, float3 LHNEDILHAJK, float3 DCGLBFEHLBB, float KCMCPKJPDIB, float DCMHJAAGFIM, float FDBFKNABCLL, float GNBLCNJKDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x87C2480", Offset = "0x87C0A80", VA = "0x1887C2480")]
	private float3 DEHDPEIMCCO(uint3 EMKPDNFPLBD, float3 GIFPPBLIEHC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x87C16C0", Offset = "0x87BFCC0", VA = "0x1887C16C0")]
	private float JFHOLMAGMGO(float LDHMNPPJOGE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x87C0AF0", Offset = "0x87BF0F0", VA = "0x1887C0AF0")]
	private float FDIFCKIJPMH(float3 HDKNGKEOJOA, float3 DCGLBFEHLBB, float DCMHJAAGFIM, float FDBFKNABCLL)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct EPJFHGMPKOL : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, PHGBCCBJHIO> CMKMOCOOCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint CIECPHNDOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int OFKJKOJHCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int HPIOIMOCLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> OADMIGKAMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> AKBPOMPNADC;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x87BF850", Offset = "0x87BDE50", VA = "0x1887BF850", Slot = "4")]
	public void Execute(int IGIDBGIPPGG, int MNANOIMGCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x87BF9F0", Offset = "0x87BDFF0", VA = "0x1887BF9F0")]
	private void JMOHJBIPMAB(int IPDPBMIKCKN, ushort DOFNOPLADFL, int IODNOJOPIMH, PHGBCCBJHIO NACPFLLOJIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct LPOOOPILBME : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, PHGBCCBJHIO> CMKMOCOOCJJ;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x87C32D0", Offset = "0x87C18D0", VA = "0x1887C32D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class MJFLHFOJNJC : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool INJDALJGLCC;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float KNECALKPHLL = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int JMIGIEKEELD = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int IGMNPPOJFOP = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private JPPLNLGDPDM CMHPAHNDDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private EPJFHGMPKOL GHEKJJOILIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private LPOOOPILBME HHLJBIBMNGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, PHGBCCBJHIO> MDFHNBMPKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private AJLNOAALFDC APPKAIADBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool OOPDHOINBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int LAEAOGPNBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<NPOJBFBKICI> KHBHMEMEIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle DKOLPNPNNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle BGOKOILJEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool PMFAJMAGCCI;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x87C4900", Offset = "0x87C2F00", VA = "0x1887C4900")]
	public MJFLHFOJNJC(RenderPassEvent EIAEFJKKDOC, ComputeShader NFOIHOIABPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x87C3D90", Offset = "0x87C2390", VA = "0x1887C3D90")]
	private void DGAAELIMLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x87C4780", Offset = "0x87C2D80", VA = "0x1887C4780")]
	public void KKOJFJHIMPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3C1CD00", Offset = "0x3C1B300", VA = "0x183C1CD00")]
	public static void GGCDJNMLCIJ<T>(NativeArray<T> DDENONPPKCL, int GPNBMIDFKMK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x87C43D0", Offset = "0x87C29D0", VA = "0x1887C43D0")]
	public void GMDOEIHDFPP(CameraData FOMILIBGBKF, LightData NIJKMHNEBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x87C3A50", Offset = "0x87C2050", VA = "0x1887C3A50")]
	private void DEKJEFIMNJI(LightData NIJKMHNEBKO, NativeArray<NPOJBFBKICI> MHKIJNGFFCF, int FELDLDAOKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x87C4090", Offset = "0x87C2690", VA = "0x1887C4090")]
	private void EMMHKJCFLGJ(CameraData FOMILIBGBKF, LightData NIJKMHNEBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x87C3E00", Offset = "0x87C2400", VA = "0x1887C3E00")]
	private void EBMJGEFNODO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x87C3F90", Offset = "0x87C2590", VA = "0x1887C3F90")]
	private void ECIDAGCNGDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x87C4860", Offset = "0x87C2E60", VA = "0x1887C4860")]
	private void MPBNBBFAHBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x87C3A20", Offset = "0x87C2020", VA = "0x1887C3A20")]
	private void AMKHPBCMPLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x87C42D0", Offset = "0x87C28D0", VA = "0x1887C42D0", Slot = "9")]
	public override void Execute(ScriptableRenderContext HILCMKALFIH, RenderingData LKKIOIJICHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x87C4880", Offset = "0x87C2E80", VA = "0x1887C4880", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer FFKNKOEBEEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class FEMJFAGILJN : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort IAMCAKFOLDL = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float KNECALKPHLL = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly AJLNOAALFDC APPKAIADBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int MNPEKGEOHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private NPOJBFBKICI[] KHBHMEMEIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 KCCFINGOPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 APCGGMPDKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint MEHICGBIJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int HLBJJAOCGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int FABBPAGNFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> OADMIGKAMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> AKBPOMPNADC;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x87C1980", Offset = "0x87BFF80", VA = "0x1887C1980")]
	public FEMJFAGILJN(RenderPassEvent EIAEFJKKDOC, ComputeShader NFOIHOIABPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x87C1100", Offset = "0x87BF700", VA = "0x1887C1100")]
	public void GMDOEIHDFPP(CameraData FOMILIBGBKF, LightData NIJKMHNEBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x87C0180", Offset = "0x87BE780", VA = "0x1887C0180")]
	private void BMNIJDFBFEK(CameraData FOMILIBGBKF, LightData NIJKMHNEBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x87C1870", Offset = "0x87BFE70", VA = "0x1887C1870")]
	public void KKOJFJHIMPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x87C04F0", Offset = "0x87BEAF0", VA = "0x1887C04F0")]
	private void DEKJEFIMNJI(LightData NIJKMHNEBKO, NPOJBFBKICI[] MHKIJNGFFCF, int FELDLDAOKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x87C0870", Offset = "0x87BEE70", VA = "0x1887C0870")]
	private void EDBIDJNAAEL(int IGIDBGIPPGG, int MNANOIMGCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x87C0840", Offset = "0x87BEE40", VA = "0x1887C0840")]
	private void DJJGCFBHBEP(int IGIDBGIPPGG, int FOAMCIPOLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x87C1270", Offset = "0x87BF870", VA = "0x1887C1270")]
	private ushort IDLJCCJHAGL(int IGIDBGIPPGG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x87BFB60", Offset = "0x87BE160", VA = "0x1887BFB60")]
	private void AOJHHFBNOFJ(int IGIDBGIPPGG, int MNANOIMGCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x87C0380", Offset = "0x87BE980", VA = "0x1887C0380")]
	private void CEBNKJPIJCI(int GPNBMIDFKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x87C1890", Offset = "0x87BFE90", VA = "0x1887C1890")]
	private void OPKDNHIEKEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x87C0A10", Offset = "0x87BF010", VA = "0x1887C0A10", Slot = "9")]
	public override void Execute(ScriptableRenderContext HILCMKALFIH, RenderingData LKKIOIJICHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x87C1950", Offset = "0x87BFF50", VA = "0x1887C1950", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer FFKNKOEBEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x87BFBD0", Offset = "0x87BE1D0", VA = "0x1887BFBD0")]
	private void BHDNFEOOBBN(int HPONIDAOGIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x87C12B0", Offset = "0x87BF8B0", VA = "0x1887C12B0")]
	private void JCOJBMLBGBP(uint3 EMKPDNFPLBD, uint3 DHDNEAFHKBJ, ushort HPONIDAOGIA, float3 GIFPPBLIEHC, float KCMCPKJPDIB, float FDBFKNABCLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x87C0BB0", Offset = "0x87BF1B0", VA = "0x1887C0BB0")]
	private void GAHEBHMGIPO(uint3 EMKPDNFPLBD, uint3 DHDNEAFHKBJ, ushort HPONIDAOGIA, float3 GIFPPBLIEHC, float3 LHNEDILHAJK, float3 DCGLBFEHLBB, float KCMCPKJPDIB, float DCMHJAAGFIM, float FDBFKNABCLL, float GNBLCNJKDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x87C0920", Offset = "0x87BEF20", VA = "0x1887C0920")]
	private void EPMMPLDKIMC(ushort HPONIDAOGIA, uint CFHJGDPGDJO, float KJPPMOFKCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x87C03F0", Offset = "0x87BE9F0", VA = "0x1887C03F0")]
	private float3 DEHDPEIMCCO(uint3 EMKPDNFPLBD, float3 GIFPPBLIEHC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x87C16C0", Offset = "0x87BFCC0", VA = "0x1887C16C0")]
	private float JFHOLMAGMGO(float LDHMNPPJOGE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x87C0AF0", Offset = "0x87BF0F0", VA = "0x1887C0AF0")]
	private float FDIFCKIJPMH(float3 HDKNGKEOJOA, float3 DCGLBFEHLBB, float DCMHJAAGFIM, float FDBFKNABCLL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x87C16E0", Offset = "0x87BFCE0", VA = "0x1887C16E0")]
	private void JMOHJBIPMAB(int IPDPBMIKCKN, ushort DOFNOPLADFL, int IODNOJOPIMH, PHGBCCBJHIO NACPFLLOJIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class AJLNOAALFDC
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class EDDELONBHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int AMHMAIJPKKG;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int ICNDMNJPMKG;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int HDANFDLHHAK;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int NKMPLAHBOJA;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int HPHACDFMKAO;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int PLEGNGDLAFB;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int GEBJKGBGBAO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int MCILFEGIPLO = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int JIJOGNCOFIG = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int KKIDODDDKGG = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int MMKOHFOHLFL = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int AOOKHGOMEKC = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int FGGJLDFCGEB = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int NFHKEGILNOH = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool CBGEMJDCIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer IFKAKJBNEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture HLEHGPAKIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int EFFBPOOGHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int GLOIMIBNCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int NFILGCDFLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int ALBKKNDGEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int BHHGDNJDGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader BEADLNJGDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int LMKEJPGJAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int IOGPKGLBCIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 GBFEPFGCLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 IHAEGOMDPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> GDOLPFGJMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> IOFKPDFEEOA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> PHJNHCLKDOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5267AC0", Offset = "0x52660C0", VA = "0x185267AC0")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> PNAGLACFBOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x125B3C0", Offset = "0x12599C0", VA = "0x18125B3C0")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int KFCOBFMJDAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xD1E880", Offset = "0xD1CE80", VA = "0x180D1E880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int MEIOPBIJEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA451A0", Offset = "0xA437A0", VA = "0x180A451A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader NMKDDDMDOEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x87BD4F0", Offset = "0x87BBAF0", VA = "0x1887BD4F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x87BC700", Offset = "0x87BAD00", VA = "0x1887BC700")]
	public void DIGOPEEDGGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x87BC7F0", Offset = "0x87BADF0", VA = "0x1887BC7F0")]
	public void FCPMGEPCACF(CameraData FOMILIBGBKF, LightData NIJKMHNEBKO, int CHODBHOOCLE, bool KGPNMMGGLPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x30B4C20", Offset = "0x30B3220", VA = "0x1830B4C20")]
	private void GGCDJNMLCIJ<T>(NativeArray<T> DDENONPPKCL, int GPNBMIDFKMK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x87BC3B0", Offset = "0x87BA9B0", VA = "0x1887BC3B0")]
	public void DDADKAGJIDK(CommandBuffer FFKNKOEBEEH, ScriptableRenderContext HILCMKALFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x87BCB00", Offset = "0x87BB100", VA = "0x1887BCB00")]
	private static void FEAONLEKBAO(int BFLFMKLJNAD, CommandBuffer FFKNKOEBEEH, RenderBuffer EABJNCAFIGD, ComputeBuffer NEBPPKKMLFE, ComputeShader CLGFOKFCELL, int FAIBANKNMMP, int CNFCGKDGMIG, int ILEHIIPGMGE, int DJJGFHEMCKI, int ELDPKGINGOP, int JLFHCBPAPJP, int MFBAOBACOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x87BD1D0", Offset = "0x87BB7D0", VA = "0x1887BD1D0")]
	public void OLOODDALFEP(CommandBuffer FFKNKOEBEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x87BCCE0", Offset = "0x87BB2E0", VA = "0x1887BCCE0")]
	private RenderTexture ICEDJIMIKHK(RenderTexture ENAJPOCBEGN, int FAIBANKNMMP, int CNFCGKDGMIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x87BD150", Offset = "0x87BB750", VA = "0x1887BD150")]
	public void OFDGNPEIPGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x87BCEC0", Offset = "0x87BB4C0", VA = "0x1887BCEC0")]
	public void NCEDEOMLFGH(int AHAIOAECFMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x87BD580", Offset = "0x87BBB80", VA = "0x1887BD580")]
	public AJLNOAALFDC()
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
		public struct NFBMHEOEIJJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float BJJDDFNBLGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float KLFDMEMLPGD;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class DCKJLGELOLO : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string HFNGLPPJGCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler HKCPEHAJDIH;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int FNINHDKJMHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material NHLGAKFHALJ;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x87BE970", Offset = "0x87BCF70", VA = "0x1887BE970")]
			public DCKJLGELOLO(RenderPassEvent EIAEFJKKDOC, Material KKIOJDIOKCM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x87BE590", Offset = "0x87BCB90", VA = "0x1887BE590", Slot = "9")]
			public override void Execute(ScriptableRenderContext HILCMKALFIH, RenderingData LKKIOIJICHO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static NFBMHEOEIJJ CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private DCKJLGELOLO m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x87C4C80", Offset = "0x87C3280", VA = "0x1887C4C80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x87C4C30", Offset = "0x87C3230", VA = "0x1887C4C30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x87C4A80", Offset = "0x87C3080", VA = "0x1887C4A80", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x87C49B0", Offset = "0x87C2FB0", VA = "0x1887C49B0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer ILMDPGBOCFL, RenderingData LKKIOIJICHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x180D250", Offset = "0x180B850", VA = "0x18180D250")]
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
		public struct POHIGJCHEIP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float LCHNGNMFDCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color GDLIEMBEOFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh PHIILCDDDAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve KJLMMBHFFDH;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class HMNCGGPEGBG : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string HFNGLPPJGCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler HKCPEHAJDIH;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int JENHPNNHBMG;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int DHKNNOKMNNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material NHLGAKFHALJ;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x87C23A0", Offset = "0x87C09A0", VA = "0x1887C23A0")]
			public HMNCGGPEGBG(RenderPassEvent EIAEFJKKDOC, Material KKIOJDIOKCM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x87C20E0", Offset = "0x87C06E0", VA = "0x1887C20E0", Slot = "9")]
			public override void Execute(ScriptableRenderContext HILCMKALFIH, RenderingData LKKIOIJICHO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static POHIGJCHEIP CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private HMNCGGPEGBG m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x87C4FB0", Offset = "0x87C35B0", VA = "0x1887C4FB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x87C4E00", Offset = "0x87C3400", VA = "0x1887C4E00", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x87C4CE0", Offset = "0x87C32E0", VA = "0x1887C4CE0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer ILMDPGBOCFL, RenderingData LKKIOIJICHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x180D250", Offset = "0x180B850", VA = "0x18180D250")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string BCGABAJKFAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool IPFMELICJBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer FFKNKOEBEEH, ScriptableRenderContext HILCMKALFIH, RenderingData LKKIOIJICHO);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA469E0", Offset = "0xA44FE0", VA = "0x180A469E0")]
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
		private class CLJAACCLHDK : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool MKPAAPFMEJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> AIBBHIIKAAH;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> PGINCCDANNA;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x87BDBD0", Offset = "0x87BC1D0", VA = "0x1887BDBD0")]
			public CLJAACCLHDK(RenderPassEvent EIAEFJKKDOC, bool MKPAAPFMEJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x87BD850", Offset = "0x87BBE50", VA = "0x1887BD850")]
			public bool PLMFPGAFJKI(CameraData FOMILIBGBKF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x87BD5A0", Offset = "0x87BBBA0", VA = "0x1887BD5A0", Slot = "9")]
			public override void Execute(ScriptableRenderContext HILCMKALFIH, RenderingData LKKIOIJICHO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x87BD770", Offset = "0x87BBD70", VA = "0x1887BD770")]
			private void PEFBGFOBMFF(PerCameraRenderEffect PIKIJCKLBBH, ScriptableRenderContext HILCMKALFIH, RenderingData LKKIOIJICHO)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private CLJAACCLHDK m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private CLJAACCLHDK m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x87C5AA0", Offset = "0x87C40A0", VA = "0x1887C5AA0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x87C5A10", Offset = "0x87C4010", VA = "0x1887C5A10", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer ILMDPGBOCFL, RenderingData LKKIOIJICHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x180D250", Offset = "0x180B850", VA = "0x18180D250")]
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
		[Cpp2IlInjected.Address(RVA = "0x87C5CF0", Offset = "0x87C42F0", VA = "0x1887C5CF0")]
		public static void BMBHOILNDCI(ScriptableRenderPass JCJGKILIIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x87C5B50", Offset = "0x87C4150", VA = "0x1887C5B50", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer ILMDPGBOCFL, RenderingData LKKIOIJICHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x180D250", Offset = "0x180B850", VA = "0x18180D250")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class EKGPALCIMKP
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 NGKAJAICMNJ;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 JBNILDEAIJP;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 JBPCLPEEOGM;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 MDEBEAAIAGG;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 AJNOMIMFCPN;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x87BEC50", Offset = "0x87BD250", VA = "0x1887BEC50")]
	public static uint EPLGLCIHPGO(uint POMHCCBBBGD, uint JKKMGDMGNFG, uint OMJKKEJFOJJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x87BF370", Offset = "0x87BD970", VA = "0x1887BF370")]
	public static uint3 JNEDLBLIBEK(float3 NHLFNDFGAHK, float3 OICHBFDLDCI, float3 FEFKINNFLIC)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x87BF130", Offset = "0x87BD730", VA = "0x1887BF130")]
	public static void IMPJFMDOEKP(float3 BMEBGFIDKBO, float3 PNBFHMKJPNF, float3 ABJEEPKMKDC, float OFCEKCJNBGJ, [Out] uint3 GOFDBINGOND, [Out] uint3 GILGAOMIIPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x87BEC60", Offset = "0x87BD260", VA = "0x1887BEC60")]
	public static void FPJMNHIDLJB(float3 CENPAAGEHLK, float3 PNKCDHJIMBM, float EHECCAJFJLF, float INBLIAEIPNK, [Out] float3 PFFIFMIDILB, [Out] float OFCEKCJNBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x87BF570", Offset = "0x87BDB70", VA = "0x1887BF570")]
	private static float3 NAHHFGIGFOE(float3 OGODLCPMPHL, float3 JJJKPPKJKDJ, float3 PJFCBGLCIDB, float3 HLOELOPJKFF)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class PKBKMLHLECL
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly LHMKAIAPMBI BOKAEJCNIMC;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly LHMKAIAPMBI KPGKIIIFLNH;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly LHMKAIAPMBI IEEGLJKDFMB;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly LHMKAIAPMBI KNOFIOJPKKJ;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly LHMKAIAPMBI HLEOLCPGMMO;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class CLLMEACCNDB
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh MHDFHENNOFF;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x87BDC80", Offset = "0x87BC280", VA = "0x1887BDC80")]
	public static Mesh DGMAEJDKPDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x87BE0F0", Offset = "0x87BC6F0", VA = "0x1887BE0F0")]
	public static Matrix4x4 HGMHKPOMMOB(Camera CHOCCMBOAGC, bool FIHDPCMCEBI = false, bool EAIENPMBJGF = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x87BDD30", Offset = "0x87BC330", VA = "0x1887BDD30")]
	private static Mesh DIDMJEIAGON()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__373846033
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x87C7190", Offset = "0x87C5790", VA = "0x1887C7190")]
	public static void ICDPAFJOCCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x87C7180", Offset = "0x87C5780", VA = "0x1887C7180")]
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
