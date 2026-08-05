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
	public class LogRegistrationIndex : BDONJGGEMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x803BD20", Offset = "0x803B120", VA = "0x18803BD20", Slot = "4")]
		public override void GEAMIGHEOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		public enum JFAKKLNPNKN
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface AEDNPGHNCIO
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void ADOFNKOFPAL(ScriptableRenderContext PCJJKLDOJMD, List<Camera> NHFFEEAAFMA);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface JAPLLJLKGFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void ADOFNKOFPAL(ScriptableRenderContext PCJJKLDOJMD, RenderingData EODOJGHICMH);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class ALEDIFLKNKL : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8034720", Offset = "0x8033B20", VA = "0x188034720")]
			public ALEDIFLKNKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x80346C0", Offset = "0x8033AC0", VA = "0x1880346C0", Slot = "9")]
			public override void Execute(ScriptableRenderContext PCJJKLDOJMD, RenderingData EODOJGHICMH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ALEDIFLKNKL _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<AEDNPGHNCIO> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<AEDNPGHNCIO> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<JAPLLJLKGFG> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<JAPLLJLKGFG> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x803E880", Offset = "0x803DC80", VA = "0x18803E880")]
		public static void HKJFKKLDEMB(JFAKKLNPNKN KNJDMBJEOBN, AEDNPGHNCIO PENMIFFIJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x803EA70", Offset = "0x803DE70", VA = "0x18803EA70")]
		public static void PPJEJGKFLJF(JFAKKLNPNKN KNJDMBJEOBN, AEDNPGHNCIO PENMIFFIJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x803E940", Offset = "0x803DD40", VA = "0x18803E940")]
		public static void HKJFKKLDEMB(JFAKKLNPNKN KNJDMBJEOBN, JAPLLJLKGFG GPAIBLFAOBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x803EB30", Offset = "0x803DF30", VA = "0x18803EB30")]
		public static void PPJEJGKFLJF(JFAKKLNPNKN KNJDMBJEOBN, JAPLLJLKGFG GPAIBLFAOBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x803E0B0", Offset = "0x803D4B0", VA = "0x18803E0B0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x803E010", Offset = "0x803D410", VA = "0x18803E010", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IDCFNEAMCIG, RenderingData EODOJGHICMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x803E290", Offset = "0x803D690", VA = "0x18803E290", Slot = "9")]
		protected override void Dispose(bool MEBDJMLJEJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x803E3A0", Offset = "0x803D7A0", VA = "0x18803E3A0")]
		private static void EKNBONHOPIN(ScriptableRenderContext PCJJKLDOJMD, List<Camera> NHFFEEAAFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x803EA00", Offset = "0x803DE00", VA = "0x18803EA00")]
		private static void JFAFPFBMDGK(ScriptableRenderContext PCJJKLDOJMD, List<Camera> NHFFEEAAFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x803EBF0", Offset = "0x803DFF0", VA = "0x18803EBF0")]
		private static void PPOBDJPFAHI(ScriptableRenderContext PCJJKLDOJMD, RenderingData EODOJGHICMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x155C0E0", Offset = "0x155B4E0", VA = "0x18155C0E0")]
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
		private class NBDONEKLNEC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool PEDKIFCPBBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<JLLKFDEBDFP> CPDLGBEGBBO;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x803C520", Offset = "0x803B920", VA = "0x18803C520")]
			public NBDONEKLNEC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class KEMEKDGKIBE : PreRenderManager.JAPLLJLKGFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string JFALBLFNMPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler HEHIJFFNFKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly NBDONEKLNEC GJPOPGPLGBA;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8039130", Offset = "0x8038530", VA = "0x188039130")]
			public KEMEKDGKIBE(NBDONEKLNEC ENLLHONJJNN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8038D30", Offset = "0x8038130", VA = "0x188038D30", Slot = "4")]
			public void ADOFNKOFPAL(ScriptableRenderContext PCJJKLDOJMD, RenderingData EODOJGHICMH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class OICJFFOIELC : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string CBJJBCODNGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly NBDONEKLNEC ENLLHONJJNN;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x803DAA0", Offset = "0x803CEA0", VA = "0x18803DAA0")]
			public OICJFFOIELC(RenderPassEvent KLCAIGNGMAO, NBDONEKLNEC ENLLHONJJNN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x803D790", Offset = "0x803CB90", VA = "0x18803D790", Slot = "9")]
			public override void Execute(ScriptableRenderContext PCJJKLDOJMD, RenderingData EODOJGHICMH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<JLLKFDEBDFP> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private KEMEKDGKIBE fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private OICJFFOIELC fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private NBDONEKLNEC sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8035A50", Offset = "0x8034E50", VA = "0x188035A50", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8035DD0", Offset = "0x80351D0", VA = "0x188035DD0", Slot = "9")]
		protected override void Dispose(bool MEBDJMLJEJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x80359C0", Offset = "0x8034DC0", VA = "0x1880359C0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IDCFNEAMCIG, RenderingData EODOJGHICMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x155C0E0", Offset = "0x155B4E0", VA = "0x18155C0E0")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JLLKFDEBDFP
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AJJBJNAHCDB(CommandBuffer LKGNCJKOINH, Camera FDBJNHOEMAN, [NotNull] UniversalAdditionalCameraData JCMIHJHMAAE, bool GJFFKDDIHNA);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HIDPGDHKIEE(Camera FDBJNHOEMAN, CommandBuffer HJJDDDEIKEG);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class KBDIBJBBKKI
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool EGBFCILNDNA;
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
		private JFOKJNPMFGH _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private KLPMGGFOGCG _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x803BA00", Offset = "0x803AE00", VA = "0x18803BA00", Slot = "9")]
		protected override void Dispose(bool EIKEBLMJPDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x803BA70", Offset = "0x803AE70", VA = "0x18803BA70")]
		private void KHLFKPPGNOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x803B6B0", Offset = "0x803AAB0", VA = "0x18803B6B0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IDCFNEAMCIG, RenderingData EODOJGHICMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x155C0E0", Offset = "0x155B4E0", VA = "0x18155C0E0")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class CEAMKJAPFPA
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8034DD0", Offset = "0x80341D0", VA = "0x188034DD0")]
	public static int OHCAIKGCKPA(bool FMLBAACBKKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x19D98B0", Offset = "0x19D8CB0", VA = "0x1819D98B0")]
	public static int JLMJEIAPDKH(bool FMLBAACBKKM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct JLHENOLDFDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType MJAHGHAAFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float JPKILBAKOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float KEDOGBHAGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float DPCDINNNNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 NGDMKDPOAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 NPGBFJJNKKE;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct HNMBLBHNEMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort CMPHHOJFBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float BEIOHMAOPJJ;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct JKNOLNJEMCD : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<JLHENOLDFDO> DDDAFOBPOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 GBDCHMGOEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 KHAEJIGJILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, HNMBLBHNEMJ>.ParallelWriter AMMBPICLGMN;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8038340", Offset = "0x8037740", VA = "0x188038340", Slot = "4")]
	public void Execute(int CMPHHOJFBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8037EC0", Offset = "0x80372C0", VA = "0x188037EC0")]
	private void ABLOLHNDFJM(uint3 JEBJHABIIBG, uint3 OHNFAMPMAPA, ushort CMPHHOJFBAA, float3 MAIFALIHAOG, float IFJMNGFNBII, float POPANEFHKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8038880", Offset = "0x8037C80", VA = "0x188038880")]
	private void LLMOPBDBCIA(uint3 JEBJHABIIBG, uint3 OHNFAMPMAPA, ushort CMPHHOJFBAA, float3 MAIFALIHAOG, float3 PNAMCFHEBNP, float3 LABGNGMHBCB, float IFJMNGFNBII, float LDEHNBCEEGD, float POPANEFHKLF, float MMJGOAOMGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8038250", Offset = "0x8037650", VA = "0x188038250")]
	private float3 DKCPCNOMIPD(uint3 JEBJHABIIBG, float3 MAIFALIHAOG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8038230", Offset = "0x8037630", VA = "0x188038230")]
	private float BEIBAMBDFNK(float JPKILBAKOEL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8037E00", Offset = "0x8037200", VA = "0x188037E00")]
	private float AAKOHHBDLBE(float3 HDILIPHLFIM, float3 LABGNGMHBCB, float LDEHNBCEEGD, float POPANEFHKLF)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct BPNGOFFPGDM : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, HNMBLBHNEMJ> AMMBPICLGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint GELKDALLCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int MCGBMGGADEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int JEGNBBMMHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> CMICOCPGCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> LPBMPAOFDDH;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8034AC0", Offset = "0x8033EC0", VA = "0x188034AC0", Slot = "4")]
	public void Execute(int FOAOELPHLDF, int FFDOJEBHPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8034C60", Offset = "0x8034060", VA = "0x188034C60")]
	private void INOCBJFKAMB(int NAPLCCKCHPF, ushort LHKMCDGOHLH, int OJFHHGMDKOC, HNMBLBHNEMJ EFBHDFIJKDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct PCPJBOBBDPI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, HNMBLBHNEMJ> AMMBPICLGMN;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x803DB80", Offset = "0x803CF80", VA = "0x18803DB80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JFOKJNPMFGH : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool PADADMFPMIA;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float AIJMCLEGJNM = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int DCBMKENNBFK = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int FCIICIJBEBB = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private JKNOLNJEMCD KIMDAPPPGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private BPNGOFFPGDM GOAGOEFHKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private PCPJBOBBDPI DGJPPJJNPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, HNMBLBHNEMJ> GPEFKDPHKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private NMLNBFGLGLB CLNMJKEBEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool ICJMHCJCLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int KDCGECKIBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<JLHENOLDFDO> HLHGMKGMMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle HINIDOOHNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle DNGODEMCLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool FNCJCDENLCO;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8037D50", Offset = "0x8037150", VA = "0x188037D50")]
	public JFOKJNPMFGH(RenderPassEvent KLCAIGNGMAO, ComputeShader MAAGIDMOHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8037900", Offset = "0x8036D00", VA = "0x188037900")]
	private void IHMMABMGEGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8036EB0", Offset = "0x80362B0", VA = "0x188036EB0")]
	public void BPNLAJKJCBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3686C30", Offset = "0x3686030", VA = "0x183686C30")]
	public static void FKADBNMGKDN<T>(NativeArray<T> LLPLHOOOAEB, int MNDMOIHIBEI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8036F90", Offset = "0x8036390", VA = "0x188036F90")]
	public void DMAEDHBFKHA(CameraData JCMIHJHMAAE, LightData FAIJOGKCDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8037330", Offset = "0x8036730", VA = "0x188037330")]
	private void ECLENMKNDPM(LightData FAIJOGKCDJJ, NativeArray<JLHENOLDFDO> GFIDNMPOLAP, int MBEKDMKIMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8037970", Offset = "0x8036D70", VA = "0x188037970")]
	private void IOIKCBNCLJD(CameraData JCMIHJHMAAE, LightData FAIJOGKCDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8037770", Offset = "0x8036B70", VA = "0x188037770")]
	private void HHJPBBKPIML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8037BE0", Offset = "0x8036FE0", VA = "0x188037BE0")]
	private void LKPBHIMDBJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8036E90", Offset = "0x8036290", VA = "0x188036E90")]
	private void BPEJPJDNPBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8037BB0", Offset = "0x8036FB0", VA = "0x188037BB0")]
	private void JNCJACFKPPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8037670", Offset = "0x8036A70", VA = "0x188037670", Slot = "9")]
	public override void Execute(ScriptableRenderContext PCJJKLDOJMD, RenderingData EODOJGHICMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8037CE0", Offset = "0x80370E0", VA = "0x188037CE0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer HJJDDDEIKEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class KLPMGGFOGCG : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort JANNPGIFGOJ = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float AIJMCLEGJNM = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly NMLNBFGLGLB CLNMJKEBEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int IEHBJCECIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private JLHENOLDFDO[] HLHGMKGMMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 NOFGOHGPCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 FILAFKOKFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint IMPMLHPNNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int PHEBHKKGOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int CLNGIDHPHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> CMICOCPGCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> LPBMPAOFDDH;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x803AF30", Offset = "0x803A330", VA = "0x18803AF30")]
	public KLPMGGFOGCG(RenderPassEvent KLCAIGNGMAO, ComputeShader MAAGIDMOHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8039840", Offset = "0x8038C40", VA = "0x188039840")]
	public void DMAEDHBFKHA(CameraData JCMIHJHMAAE, LightData FAIJOGKCDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x803A650", Offset = "0x8039A50", VA = "0x18803A650")]
	private void KFPCEMHHJMB(CameraData JCMIHJHMAAE, LightData FAIJOGKCDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8039720", Offset = "0x8038B20", VA = "0x188039720")]
	public void BPNLAJKJCBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x80399B0", Offset = "0x8038DB0", VA = "0x1880399B0")]
	private void ECLENMKNDPM(LightData FAIJOGKCDJJ, JLHENOLDFDO[] GFIDNMPOLAP, int MBEKDMKIMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8039670", Offset = "0x8038A70", VA = "0x188039670")]
	private void BBHJFDPDHHD(int FOAOELPHLDF, int FFDOJEBHPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x803AE90", Offset = "0x803A290", VA = "0x18803AE90")]
	private void OAJMAPAHDHF(int FOAOELPHLDF, int ECKHNAPCKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x803AEF0", Offset = "0x803A2F0", VA = "0x18803AEF0")]
	private ushort PHHKEIJLDFN(int FOAOELPHLDF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x803A450", Offset = "0x8039850", VA = "0x18803A450")]
	private void HJDLPJHNLOJ(int FOAOELPHLDF, int FFDOJEBHPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8039600", Offset = "0x8038A00", VA = "0x188039600")]
	private void AHKEDKENKIA(int MNDMOIHIBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8039DE0", Offset = "0x80391E0", VA = "0x188039DE0")]
	private void FNDJICHJLKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8039D00", Offset = "0x8039100", VA = "0x188039D00", Slot = "9")]
	public override void Execute(ScriptableRenderContext PCJJKLDOJMD, RenderingData EODOJGHICMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x803AEC0", Offset = "0x803A2C0", VA = "0x18803AEC0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer HJJDDDEIKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8039EA0", Offset = "0x80392A0", VA = "0x188039EA0")]
	private void GFPNKAHKNFM(int CMPHHOJFBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x80391F0", Offset = "0x80385F0", VA = "0x1880391F0")]
	private void ABLOLHNDFJM(uint3 JEBJHABIIBG, uint3 OHNFAMPMAPA, ushort CMPHHOJFBAA, float3 MAIFALIHAOG, float IFJMNGFNBII, float POPANEFHKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x803A850", Offset = "0x8039C50", VA = "0x18803A850")]
	private void LLMOPBDBCIA(uint3 JEBJHABIIBG, uint3 OHNFAMPMAPA, ushort CMPHHOJFBAA, float3 MAIFALIHAOG, float3 PNAMCFHEBNP, float3 LABGNGMHBCB, float IFJMNGFNBII, float LDEHNBCEEGD, float POPANEFHKLF, float MMJGOAOMGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x803ADA0", Offset = "0x803A1A0", VA = "0x18803ADA0")]
	private void LMGAMKCDFJG(ushort CMPHHOJFBAA, uint EKCKHHBFGCL, float IBJGDMBKCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8039740", Offset = "0x8038B40", VA = "0x188039740")]
	private float3 DKCPCNOMIPD(uint3 JEBJHABIIBG, float3 MAIFALIHAOG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8038230", Offset = "0x8037630", VA = "0x188038230")]
	private float BEIBAMBDFNK(float JPKILBAKOEL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8037E00", Offset = "0x8037200", VA = "0x188037E00")]
	private float AAKOHHBDLBE(float3 HDILIPHLFIM, float3 LABGNGMHBCB, float LDEHNBCEEGD, float POPANEFHKLF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x803A4C0", Offset = "0x80398C0", VA = "0x18803A4C0")]
	private void INOCBJFKAMB(int NAPLCCKCHPF, ushort LHKMCDGOHLH, int OJFHHGMDKOC, HNMBLBHNEMJ EFBHDFIJKDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class NMLNBFGLGLB
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class MHIKOEDBEBN
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int GJGPLMCMFEC;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int AKLHPJIAHMA;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int ODIKBGGFAKD;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int JDBJCGEEIGG;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int MNLIIPBJPJL;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int GDGJPCPNEMJ;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int BLLNFPELDMA;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int KGAHAJBBCGI = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int FDLEALAGHCC = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int DKLGGGKANII = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int PEBPKPCIPDK = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int BECPDIDIHME = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int NEGPCHFGMPL = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int FDPJCANJOAD = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool CGJKJCIFMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer KHCJNPHKDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture GLOAKCAIOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int ADKOBBKKJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int HBINBEAEGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int MOMJDHBANAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int OIGDLICJMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int HKFKDLDPHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader KOCNANDBLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int MAEJADGGEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int MCCIOKCOACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 BJOJPPFEOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 ILENPCDNPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> IMMDIHGAJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> HLBGCFGLJKP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> KEFDOJMFBGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x48CF830", Offset = "0x48CEC30", VA = "0x1848CF830")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> JFMHPAACEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1067610", Offset = "0x1066A10", VA = "0x181067610")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int CNPMCKJEKII
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xBBE5D0", Offset = "0xBBD9D0", VA = "0x180BBE5D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int KCFHJMMPCHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9A9220", Offset = "0x9A8620", VA = "0x1809A9220")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader DGOONIJIDGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x803CD30", Offset = "0x803C130", VA = "0x18803CD30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x803D190", Offset = "0x803C590", VA = "0x18803D190")]
	public void LIPICMLEJBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x803D460", Offset = "0x803C860", VA = "0x18803D460")]
	public void OABICGNBLJI(CameraData JCMIHJHMAAE, LightData FAIJOGKCDJJ, int EOBDCAJKJHB, bool FMLBAACBKKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x37D8CE0", Offset = "0x37D80E0", VA = "0x1837D8CE0")]
	private void FKADBNMGKDN<T>(NativeArray<T> LLPLHOOOAEB, int MNDMOIHIBEI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x803CDC0", Offset = "0x803C1C0", VA = "0x18803CDC0")]
	public void GLHKOEJKONI(CommandBuffer HJJDDDEIKEG, ScriptableRenderContext PCJJKLDOJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x803C5B0", Offset = "0x803B9B0", VA = "0x18803C5B0")]
	private static void AGHNCGOGIIC(int OBNIDDGNPAF, CommandBuffer HJJDDDEIKEG, RenderBuffer OBJIGGDEPFK, ComputeBuffer PICNOMMCPMJ, ComputeShader LCBLGCFGLGB, int DDLNJFPAHKL, int PFJJBFOMNNF, int EBFBGPKPKFL, int BIMKLKKNLKL, int MLGGINBJKFK, int JLKOMAJFMCE, int PALEEIONCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x803C790", Offset = "0x803BB90", VA = "0x18803C790")]
	public void DODOFFEMGMF(CommandBuffer HJJDDDEIKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x803D280", Offset = "0x803C680", VA = "0x18803D280")]
	private RenderTexture NKJDBHILIFH(RenderTexture MJGJEGIEFLL, int DDLNJFPAHKL, int PFJJBFOMNNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x803D110", Offset = "0x803C510", VA = "0x18803D110")]
	public void KIAOJAIOKDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x803CAA0", Offset = "0x803BEA0", VA = "0x18803CAA0")]
	public void DPADAENIPPL(int LLGAJMALNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x803D770", Offset = "0x803CB70", VA = "0x18803D770")]
	public NMLNBFGLGLB()
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
		public struct LIHNMIJGOEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float DHCINDEBBPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float HMABBIOJCBJ;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class IBALBJJNIEL : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string GEGALCBBLEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler EEELHPKFKAA;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int KKCFAHDNOCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material ALLOHPFNEPL;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8036390", Offset = "0x8035790", VA = "0x188036390")]
			public IBALBJJNIEL(RenderPassEvent KLCAIGNGMAO, Material ANOGJJADLNE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8035FC0", Offset = "0x80353C0", VA = "0x188035FC0", Slot = "9")]
			public override void Execute(ScriptableRenderContext PCJJKLDOJMD, RenderingData EODOJGHICMH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static LIHNMIJGOEK CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private IBALBJJNIEL m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x803C1C0", Offset = "0x803B5C0", VA = "0x18803C1C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x803C170", Offset = "0x803B570", VA = "0x18803C170")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x803BFC0", Offset = "0x803B3C0", VA = "0x18803BFC0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x803BEF0", Offset = "0x803B2F0", VA = "0x18803BEF0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IDCFNEAMCIG, RenderingData EODOJGHICMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x155C0E0", Offset = "0x155B4E0", VA = "0x18155C0E0")]
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
		public struct FFLCHNLKKIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float DCFNILMCBIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color PFBPGFFHLGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh FOEBKHLEKPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve KDEMOBLINOM;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class BCMBCHNNMOF : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string GEGALCBBLEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler EEELHPKFKAA;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int HLJLAKKBEGF;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int NKJEHPEFFKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material ALLOHPFNEPL;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x80349E0", Offset = "0x8033DE0", VA = "0x1880349E0")]
			public BCMBCHNNMOF(RenderPassEvent KLCAIGNGMAO, Material ANOGJJADLNE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8034740", Offset = "0x8033B40", VA = "0x188034740", Slot = "9")]
			public override void Execute(ScriptableRenderContext PCJJKLDOJMD, RenderingData EODOJGHICMH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static FFLCHNLKKIB CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private BCMBCHNNMOF m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x803C4D0", Offset = "0x803B8D0", VA = "0x18803C4D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x803C320", Offset = "0x803B720", VA = "0x18803C320", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x803C210", Offset = "0x803B610", VA = "0x18803C210", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IDCFNEAMCIG, RenderingData EODOJGHICMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x155C0E0", Offset = "0x155B4E0", VA = "0x18155C0E0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string IMDLFHJLGOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool PMIHKFIDOLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer HJJDDDEIKEG, ScriptableRenderContext PCJJKLDOJMD, RenderingData EODOJGHICMH);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA80", Offset = "0x9ABE80", VA = "0x1809ACA80")]
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
		private class LAJKFENIDMI : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool FLNJINEFCOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> ELFDMHIMILA;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> FMCFBDILFEJ;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x803B600", Offset = "0x803AA00", VA = "0x18803B600")]
			public LAJKFENIDMI(RenderPassEvent KLCAIGNGMAO, bool FLNJINEFCOP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x803B290", Offset = "0x803A690", VA = "0x18803B290")]
			public bool PBDFCMIDHFP(CameraData JCMIHJHMAAE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x803AFE0", Offset = "0x803A3E0", VA = "0x18803AFE0", Slot = "9")]
			public override void Execute(ScriptableRenderContext PCJJKLDOJMD, RenderingData EODOJGHICMH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x803B1B0", Offset = "0x803A5B0", VA = "0x18803B1B0")]
			private void PAJPLLEHGPH(PerCameraRenderEffect JGKFOCKBGNH, ScriptableRenderContext PCJJKLDOJMD, RenderingData EODOJGHICMH)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private LAJKFENIDMI m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private LAJKFENIDMI m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x803DC50", Offset = "0x803D050", VA = "0x18803DC50", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x803DBC0", Offset = "0x803CFC0", VA = "0x18803DBC0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IDCFNEAMCIG, RenderingData EODOJGHICMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x155C0E0", Offset = "0x155B4E0", VA = "0x18155C0E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x803DD00", Offset = "0x803D100", VA = "0x18803DD00")]
		public static void ABKMEBDBNKL(ScriptableRenderPass CPCNPKHGHMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x803DDE0", Offset = "0x803D1E0", VA = "0x18803DDE0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IDCFNEAMCIG, RenderingData EODOJGHICMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x155C0E0", Offset = "0x155B4E0", VA = "0x18155C0E0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class FHDFHEIJKKO
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 KCNDOHGFHHA;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 BLJFHMAMABI;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 DEFFAPKNDED;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 NMHDOJBDJHP;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 PEPNKDCPGDO;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8035640", Offset = "0x8034A40", VA = "0x188035640")]
	public static uint GHOFGGOJAFM(uint MEAMPLHPPKP, uint KDELALKKKOF, uint LLMEPBBBHGG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8035450", Offset = "0x8034850", VA = "0x188035450")]
	public static uint3 GEAFMAEHMPG(float3 INHMOEHIHAJ, float3 GBDCHMGOEKF, float3 KHAEJIGJILC)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8035650", Offset = "0x8034A50", VA = "0x188035650")]
	public static void GOAONDJPODP(float3 GKHLKGFKBHG, float3 LEFBBFEHIHJ, float3 OGHILLGDPLH, float JAINCGFCEKN, [Out] uint3 CPEFPOFBHPI, [Out] uint3 MLIOFAOFDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8034DE0", Offset = "0x80341E0", VA = "0x188034DE0")]
	public static void DJLHCOPEMOH(float3 MEBMPAKMKNK, float3 LMHFJFBIHDF, float KEDOGBHAGPB, float JGLHPFIJMCF, [Out] float3 FCNGDLNIIPJ, [Out] float JAINCGFCEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x80352B0", Offset = "0x80346B0", VA = "0x1880352B0")]
	private static float3 ECAPCEDLDCC(float3 EFPHNPJFNFK, float3 JBLIEDOMPMC, float3 EALHBLOHGBN, float3 AIIAIOLFCBO)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class JDMOJDGDFLJ
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly GBHBOJAPDOA HNGCCNFLMMA;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly GBHBOJAPDOA MNLANJMNBBJ;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly GBHBOJAPDOA CGFLCKPHLNE;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly GBHBOJAPDOA BHONDAJFGJE;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly GBHBOJAPDOA OMMBNKJONCF;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class IPNALNIIIKP
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh HKCOKKHIOPG;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8036CD0", Offset = "0x80360D0", VA = "0x188036CD0")]
	public static Mesh OKHFHCODJMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8036830", Offset = "0x8035C30", VA = "0x188036830")]
	public static Matrix4x4 MKNPDEJBDHF(Camera FDBJNHOEMAN, bool GFIOHOAIMHN = false, bool JDEBBLBNFNI = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8036470", Offset = "0x8035870", VA = "0x188036470")]
	private static Mesh GDINNFGBMGA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2002930785
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x803F2C0", Offset = "0x803E6C0", VA = "0x18803F2C0")]
	public static void MNMBNDKFEBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x803F2B0", Offset = "0x803E6B0", VA = "0x18803F2B0")]
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
