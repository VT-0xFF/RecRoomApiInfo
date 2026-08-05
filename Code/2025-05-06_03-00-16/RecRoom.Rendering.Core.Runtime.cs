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
	public class LogRegistrationIndex : ONLGCKOFHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x82A2C90", Offset = "0x82A1490", VA = "0x1882A2C90", Slot = "4")]
		public override void JNEAPGDNFGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		public enum CAFMOKIPPFE
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface LOHBCGIHCPA
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void FIJDKNIDPMK(ScriptableRenderContext KLNHOILIBHH, List<Camera> GLNJPAOKPKI);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface OBOAFBDMFML
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void FIJDKNIDPMK(ScriptableRenderContext KLNHOILIBHH, RenderingData HNEGCPHIBHG);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class GOKFLLLONPH : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x82A0ED0", Offset = "0x829F6D0", VA = "0x1882A0ED0")]
			public GOKFLLLONPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x82A0E70", Offset = "0x829F670", VA = "0x1882A0E70", Slot = "9")]
			public override void Execute(ScriptableRenderContext KLNHOILIBHH, RenderingData HNEGCPHIBHG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private GOKFLLLONPH _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<LOHBCGIHCPA> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<LOHBCGIHCPA> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<OBOAFBDMFML> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<OBOAFBDMFML> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x82A6090", Offset = "0x82A4890", VA = "0x1882A6090")]
		public static void BBJLMAFJNOB(CAFMOKIPPFE POOANJNDCBN, LOHBCGIHCPA DBMHCGKFOHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x82A6E90", Offset = "0x82A5690", VA = "0x1882A6E90")]
		public static void OKBPNAFKHLD(CAFMOKIPPFE POOANJNDCBN, LOHBCGIHCPA DBMHCGKFOHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x82A5FD0", Offset = "0x82A47D0", VA = "0x1882A5FD0")]
		public static void BBJLMAFJNOB(CAFMOKIPPFE POOANJNDCBN, OBOAFBDMFML HLAHOCPIBIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x82A6DD0", Offset = "0x82A55D0", VA = "0x1882A6DD0")]
		public static void OKBPNAFKHLD(CAFMOKIPPFE POOANJNDCBN, OBOAFBDMFML HLAHOCPIBIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x82A6150", Offset = "0x82A4950", VA = "0x1882A6150", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x82A5F30", Offset = "0x82A4730", VA = "0x1882A5F30", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer JGPHFKDOCBN, RenderingData HNEGCPHIBHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x82A6330", Offset = "0x82A4B30", VA = "0x1882A6330", Slot = "9")]
		protected override void Dispose(bool DBCKCNEHCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x82A6440", Offset = "0x82A4C40", VA = "0x1882A6440")]
		private static void ILCEHCADHNP(ScriptableRenderContext KLNHOILIBHH, List<Camera> GLNJPAOKPKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x82A6F50", Offset = "0x82A5750", VA = "0x1882A6F50")]
		private static void PINDOGNIEDE(ScriptableRenderContext KLNHOILIBHH, List<Camera> GLNJPAOKPKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x82A6920", Offset = "0x82A5120", VA = "0x1882A6920")]
		private static void NDMLGMCBGMC(ScriptableRenderContext KLNHOILIBHH, RenderingData HNEGCPHIBHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1623F00", Offset = "0x1622700", VA = "0x181623F00")]
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
		private class IGLOBKIANON
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool LBMFPHBFDJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<GGBIEFNFIIF> IEJPCMIAMAN;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x82A20E0", Offset = "0x82A08E0", VA = "0x1882A20E0")]
			public IGLOBKIANON()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class ODLNNAKMKMM : PreRenderManager.OBOAFBDMFML
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string HAKMLNAIHAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler KBFKPBCEOAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly IGLOBKIANON CMEEHEEEIDM;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x82A5560", Offset = "0x82A3D60", VA = "0x1882A5560")]
			public ODLNNAKMKMM(IGLOBKIANON GAGNCOFKPNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x82A5170", Offset = "0x82A3970", VA = "0x1882A5170", Slot = "4")]
			public void FIJDKNIDPMK(ScriptableRenderContext KLNHOILIBHH, RenderingData HNEGCPHIBHG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class ABHCPKABBDJ : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string AAKHONGKPOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly IGLOBKIANON GAGNCOFKPNC;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x829C900", Offset = "0x829B100", VA = "0x18829C900")]
			public ABHCPKABBDJ(RenderPassEvent AHDJGIKMPCG, IGLOBKIANON GAGNCOFKPNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x829C5F0", Offset = "0x829ADF0", VA = "0x18829C5F0", Slot = "9")]
			public override void Execute(ScriptableRenderContext KLNHOILIBHH, RenderingData HNEGCPHIBHG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<GGBIEFNFIIF> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private ODLNNAKMKMM fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private ABHCPKABBDJ fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private IGLOBKIANON sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x82A08C0", Offset = "0x829F0C0", VA = "0x1882A08C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x82A0C40", Offset = "0x829F440", VA = "0x1882A0C40", Slot = "9")]
		protected override void Dispose(bool DBCKCNEHCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x82A0830", Offset = "0x829F030", VA = "0x1882A0830", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer JGPHFKDOCBN, RenderingData HNEGCPHIBHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1623F00", Offset = "0x1622700", VA = "0x181623F00")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GGBIEFNFIIF
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FMMHIPCELPH(CommandBuffer FNOCOJBMEFH, Camera DJHBAGBEEIN, [NotNull] UniversalAdditionalCameraData JPKLHEDKCGM, bool KPGKGNEENKM);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CNEGAEEAANB(Camera DJHBAGBEEIN, CommandBuffer NOACLCGHLMN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class HGEPCGMFJEA
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool EHHEPEDAPNI;
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
		private AHDBNPCDNJL _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private ENAGMDPJDCN _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x82A2970", Offset = "0x82A1170", VA = "0x1882A2970", Slot = "9")]
		protected override void Dispose(bool IDFLOIHLKIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x82A29E0", Offset = "0x82A11E0", VA = "0x1882A29E0")]
		private void HENHPCOFOIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x82A2620", Offset = "0x82A0E20", VA = "0x1882A2620", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer JGPHFKDOCBN, RenderingData HNEGCPHIBHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1623F00", Offset = "0x1622700", VA = "0x181623F00")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class IAFKBGDBHBI
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x82A20D0", Offset = "0x82A08D0", VA = "0x1882A20D0")]
	public static int PLKPEHFBGLO(bool BMMCGFMEEAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1AAB980", Offset = "0x1AAA180", VA = "0x181AAB980")]
	public static int BNDALNHBBLN(bool BMMCGFMEEAN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct AIFCDHEBKLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType FANIGHCMMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float MGKBJAGNIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float LPANGBAAEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float AOIKFNGOFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 LLAEGIBFMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 DEOCOAEOKCO;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct MPMAMMFHHEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort BEGBKKMIMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float JGCJGKEBJLN;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct MAFAKCHBCPK : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<AIFCDHEBKLB> CEPJFFKJFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 GIEBBGCFCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 KJPGBHKKLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, MPMAMMFHHEI>.ParallelWriter IGEMAKOPIFG;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x82A31D0", Offset = "0x82A19D0", VA = "0x1882A31D0", Slot = "4")]
	public void Execute(int BEGBKKMIMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x82A3800", Offset = "0x82A2000", VA = "0x1882A3800")]
	private void HHCNOKINFBK(uint3 NJOOMHGHEME, uint3 MDKODGNFJFB, ushort BEGBKKMIMMK, float3 EEFKKPBCPBF, float HOGLPHOECKK, float LFGPMNEHBOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x82A2D20", Offset = "0x82A1520", VA = "0x1882A2D20")]
	private void BDCMIAEIKNB(uint3 NJOOMHGHEME, uint3 MDKODGNFJFB, ushort BEGBKKMIMMK, float3 EEFKKPBCPBF, float3 EPHBHEANGGF, float3 KKAHEKCNFFI, float HOGLPHOECKK, float LNFICLBBFJC, float LFGPMNEHBOA, float DMONLAPDEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x82A3710", Offset = "0x82A1F10", VA = "0x1882A3710")]
	private float3 FFHAIADHKOD(uint3 NJOOMHGHEME, float3 EEFKKPBCPBF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x829F170", Offset = "0x829D970", VA = "0x18829F170")]
	private float GBHIKBIDLJA(float MGKBJAGNIMK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x829FDE0", Offset = "0x829E5E0", VA = "0x18829FDE0")]
	private float IPEDMJFGBGC(float3 CFNAHAIKION, float3 KKAHEKCNFFI, float LNFICLBBFJC, float LFGPMNEHBOA)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct BLHEKJOPHGI : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, MPMAMMFHHEI> IGEMAKOPIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint KLJNJMEINIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int IFMBFJNHHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int FACMMOKCPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> CAPNJPNDOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> NAKHAEKBDDM;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x829DA70", Offset = "0x829C270", VA = "0x18829DA70", Slot = "4")]
	public void Execute(int LPPAMNKFCNA, int OJJPEBCCDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x829DC10", Offset = "0x829C410", VA = "0x18829DC10")]
	private void MEADAEENKJO(int LKMPFIIMDOF, ushort OONFCADOEJP, int FDDFGNCJILK, MPMAMMFHHEI DBODPEGENEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct GEOODGOMBAM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, MPMAMMFHHEI> IGEMAKOPIFG;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x82A0E30", Offset = "0x829F630", VA = "0x1882A0E30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class AHDBNPCDNJL : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool OGHKKBGDNHE;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float PBFABLOIKNE = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int DBMGCEDELFA = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int NFEMCKHEPHD = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private MAFAKCHBCPK BEGBNFPBCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private BLHEKJOPHGI GDBGMLEBMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private GEOODGOMBAM LKNDELLOFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, MPMAMMFHHEI> CLNPMFHKCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private HMBPABDGDGM HDJJFFNJFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool DFNHAIAFDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int OLJNDKIIKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<AIFCDHEBKLB> PNHBDPKHHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle FDMDPPGIILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle FACPIBGDFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool BFCFDLCFKJI;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x829D8A0", Offset = "0x829C0A0", VA = "0x18829D8A0")]
	public AHDBNPCDNJL(RenderPassEvent AHDJGIKMPCG, ComputeShader AGJFLAGBGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x829D0C0", Offset = "0x829B8C0", VA = "0x18829D0C0")]
	private void IOLKKICAFKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x829D2E0", Offset = "0x829BAE0", VA = "0x18829D2E0")]
	public void JOAGLLFJNHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3F05DA0", Offset = "0x3F045A0", VA = "0x183F05DA0")]
	public static void CDHHHMILIJK<T>(NativeArray<T> CPIDEKBKOPO, int LBLAFDELPAC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x829CD20", Offset = "0x829B520", VA = "0x18829CD20")]
	public void HGIEOGIGEOF(CameraData JPKLHEDKCGM, LightData KINNHLELKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x829D520", Offset = "0x829BD20", VA = "0x18829D520")]
	private void PCLLCPBGEGG(LightData KINNHLELKMK, NativeArray<AIFCDHEBKLB> CPNNFLNPPPD, int MMJEIHEDJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x829C9E0", Offset = "0x829B1E0", VA = "0x18829C9E0")]
	private void AOIPNHIIPLF(CameraData JPKLHEDKCGM, LightData KINNHLELKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x829D130", Offset = "0x829B930", VA = "0x18829D130")]
	private void JGMAOFOJBJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x829D3F0", Offset = "0x829BBF0", VA = "0x18829D3F0")]
	private void ONPOGGAKMAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x829D2C0", Offset = "0x829BAC0", VA = "0x18829D2C0")]
	private void JJALJBGJKPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x829D3C0", Offset = "0x829BBC0", VA = "0x18829D3C0")]
	private void KLENLGMCICD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x829CC20", Offset = "0x829B420", VA = "0x18829CC20", Slot = "9")]
	public override void Execute(ScriptableRenderContext KLNHOILIBHH, RenderingData HNEGCPHIBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x829D4F0", Offset = "0x829BCF0", VA = "0x18829D4F0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer NOACLCGHLMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ENAGMDPJDCN : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort NCJIJLBPKEA = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float PBFABLOIKNE = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HMBPABDGDGM HDJJFFNJFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int NGPMEDAPBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private AIFCDHEBKLB[] PNHBDPKHHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 BDILLPKDAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 FEILDAHCOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint CNANADNNCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int BGDNIOKFBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int OBCDAFBMNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> CAPNJPNDOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> NAKHAEKBDDM;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x82A0780", Offset = "0x829EF80", VA = "0x1882A0780")]
	public ENAGMDPJDCN(RenderPassEvent AHDJGIKMPCG, ComputeShader AGJFLAGBGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x829F2B0", Offset = "0x829DAB0", VA = "0x18829F2B0")]
	public void HGIEOGIGEOF(CameraData JPKLHEDKCGM, LightData KINNHLELKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x82A0110", Offset = "0x829E910", VA = "0x1882A0110")]
	private void OKFDOOAFDHH(CameraData JPKLHEDKCGM, LightData KINNHLELKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x829FEA0", Offset = "0x829E6A0", VA = "0x18829FEA0")]
	public void JOAGLLFJNHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x82A0340", Offset = "0x829EB40", VA = "0x1882A0340")]
	private void PCLLCPBGEGG(LightData KINNHLELKMK, AIFCDHEBKLB[] CPNNFLNPPPD, int MMJEIHEDJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x829F190", Offset = "0x829D990", VA = "0x18829F190")]
	private void GGMEGNLNJHN(int LPPAMNKFCNA, int OJJPEBCCDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x829EEB0", Offset = "0x829D6B0", VA = "0x18829EEB0")]
	private void BPNLGIJFJDH(int LPPAMNKFCNA, int PCFOAHIEPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x829F130", Offset = "0x829D930", VA = "0x18829F130")]
	private ushort FPIIFGMDJNJ(int LPPAMNKFCNA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x829EEE0", Offset = "0x829D6E0", VA = "0x18829EEE0")]
	private void CAFJPGPNNBN(int LPPAMNKFCNA, int OJJPEBCCDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x829F240", Offset = "0x829DA40", VA = "0x18829F240")]
	private void GPDEBIDNFCE(int LBLAFDELPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x829FEC0", Offset = "0x829E6C0", VA = "0x18829FEC0")]
	private void LDCDJGMBKIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x829EF50", Offset = "0x829D750", VA = "0x18829EF50", Slot = "9")]
	public override void Execute(ScriptableRenderContext KLNHOILIBHH, RenderingData HNEGCPHIBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x82A0310", Offset = "0x829EB10", VA = "0x1882A0310", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer NOACLCGHLMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x829F830", Offset = "0x829E030", VA = "0x18829F830")]
	private void HIEPPCMJHAK(int BEGBKKMIMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x829F420", Offset = "0x829DC20", VA = "0x18829F420")]
	private void HHCNOKINFBK(uint3 NJOOMHGHEME, uint3 MDKODGNFJFB, ushort BEGBKKMIMMK, float3 EEFKKPBCPBF, float HOGLPHOECKK, float LFGPMNEHBOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x829E960", Offset = "0x829D160", VA = "0x18829E960")]
	private void BDCMIAEIKNB(uint3 NJOOMHGHEME, uint3 MDKODGNFJFB, ushort BEGBKKMIMMK, float3 EEFKKPBCPBF, float3 EPHBHEANGGF, float3 KKAHEKCNFFI, float HOGLPHOECKK, float LNFICLBBFJC, float LFGPMNEHBOA, float DMONLAPDEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x82A0690", Offset = "0x829EE90", VA = "0x1882A0690")]
	private void PJAICOKNDNH(ushort BEGBKKMIMMK, uint CGLHPFLJONO, float HAMFIFIGCBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x829F030", Offset = "0x829D830", VA = "0x18829F030")]
	private float3 FFHAIADHKOD(uint3 NJOOMHGHEME, float3 EEFKKPBCPBF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x829F170", Offset = "0x829D970", VA = "0x18829F170")]
	private float GBHIKBIDLJA(float MGKBJAGNIMK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x829FDE0", Offset = "0x829E5E0", VA = "0x18829FDE0")]
	private float IPEDMJFGBGC(float3 CFNAHAIKION, float3 KKAHEKCNFFI, float LNFICLBBFJC, float LFGPMNEHBOA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x829FF80", Offset = "0x829E780", VA = "0x18829FF80")]
	private void MEADAEENKJO(int LKMPFIIMDOF, ushort OONFCADOEJP, int FDDFGNCJILK, MPMAMMFHHEI DBODPEGENEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class HMBPABDGDGM
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class PBGMDLJLCBO
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int DIJGMLGJDCK;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int EPGPHFCGFCO;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int BJJFKEFNFJM;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int OHDNFOIJGHO;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int LIKJPPFDDJH;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int KDCNLHMIMJH;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int LFLGNGNOJOP;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int NHKBKOGMMDM = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int ALKIJKLAIPC = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int BPJAGBIHCOH = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int HHEMNJGJPCF = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int DNLCHPFLBBB = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int FHBNCFAEJDK = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int BEKOGBEBFLB = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool LGKJANBJBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer KIDHKDDIAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture BBBDGNDOMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int FMEHAFOIOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int KEELJOJIPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int KIFAOCHCOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int LBPNDMPGIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int MJJOJFKLDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader LKBFIIJHJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int NNOHHDJOODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int MJAIADGDDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 JFBOOBGJHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 DEPLCLHIIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> ONIFAMIDNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> MMKKKKCBBHI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> DBILAGAGKLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4DC0380", Offset = "0x4DBEB80", VA = "0x184DC0380")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> AJNHOKHHPJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1143A40", Offset = "0x1142240", VA = "0x181143A40")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int JDBIEANNPJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xC4B9C0", Offset = "0xC4A1C0", VA = "0x180C4B9C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int FLANDHIAOLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF90", Offset = "0x9EA790", VA = "0x1809EBF90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader HHLAFBFKDEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x82A1180", Offset = "0x829F980", VA = "0x1882A1180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x82A1FC0", Offset = "0x82A07C0", VA = "0x1882A1FC0")]
	public void OCOBEACFBKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x82A1210", Offset = "0x829FA10", VA = "0x1882A1210")]
	public void ECEDMKIGLMN(CameraData JPKLHEDKCGM, LightData KINNHLELKMK, int LHBLMJHMNLK, bool BMMCGFMEEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x37BFA70", Offset = "0x37BE270", VA = "0x1837BFA70")]
	private void CDHHHMILIJK<T>(NativeArray<T> CPIDEKBKOPO, int LBLAFDELPAC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x82A1A90", Offset = "0x82A0290", VA = "0x1882A1A90")]
	public void KOPFEMFNNFI(CommandBuffer NOACLCGHLMN, ScriptableRenderContext KLNHOILIBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x82A1DE0", Offset = "0x82A05E0", VA = "0x1882A1DE0")]
	private static void NHINIDINANN(int IGFIFPMOINN, CommandBuffer NOACLCGHLMN, RenderBuffer LOHGOJDBMGK, ComputeBuffer EPDALFMNFME, ComputeShader ICECPNBAGLA, int DIMELOOHBKC, int KNGALMOHDEF, int NEEEMKDNFNB, int HIFKMJMNBFM, int DALMDCCHEBI, int FCEBDNLAANP, int OIIEMMPDBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x82A1780", Offset = "0x829FF80", VA = "0x1882A1780")]
	public void KDAGBJBBBKO(CommandBuffer NOACLCGHLMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x82A1520", Offset = "0x829FD20", VA = "0x1882A1520")]
	private RenderTexture ELLGCCDNJGP(RenderTexture MKGBKIGHCHG, int DIMELOOHBKC, int KNGALMOHDEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x82A1700", Offset = "0x829FF00", VA = "0x1882A1700")]
	public void JODDHJIOBDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x82A0EF0", Offset = "0x829F6F0", VA = "0x1882A0EF0")]
	public void AHEIODHDKNB(int AJOHOLNDLHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x82A20B0", Offset = "0x82A08B0", VA = "0x1882A20B0")]
	public HMBPABDGDGM()
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
		public struct HBEOFKBEEBC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float ENHBEDCMJLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float GFBICMIGAHB;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class KIPGBNMCNHC : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string BHFMDEBIALG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler DNINIOOHNAP;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int BJCJCMNBIJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material ADBLJDOFMAK;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x82A2540", Offset = "0x82A0D40", VA = "0x1882A2540")]
			public KIPGBNMCNHC(RenderPassEvent AHDJGIKMPCG, Material OALKCGACMLD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x82A2170", Offset = "0x82A0970", VA = "0x1882A2170", Slot = "9")]
			public override void Execute(ScriptableRenderContext KLNHOILIBHH, RenderingData HNEGCPHIBHG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static HBEOFKBEEBC CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private KIPGBNMCNHC m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x82A3E40", Offset = "0x82A2640", VA = "0x1882A3E40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x82A3DF0", Offset = "0x82A25F0", VA = "0x1882A3DF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x82A3C40", Offset = "0x82A2440", VA = "0x1882A3C40", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x82A3B70", Offset = "0x82A2370", VA = "0x1882A3B70", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer JGPHFKDOCBN, RenderingData HNEGCPHIBHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1623F00", Offset = "0x1622700", VA = "0x181623F00")]
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
		public struct NDIECMIFFMD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float EOBFGFLCBDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color DFCJDKMOCHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh HIDJCPOENEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve IKEDCOABELP;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class PFJAMCCPAJB : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string BHFMDEBIALG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler DNINIOOHNAP;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int AFMDNONGDGM;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int NIAEBMAAACC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material ADBLJDOFMAK;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x82A5A00", Offset = "0x82A4200", VA = "0x1882A5A00")]
			public PFJAMCCPAJB(RenderPassEvent AHDJGIKMPCG, Material OALKCGACMLD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x82A5760", Offset = "0x82A3F60", VA = "0x1882A5760", Slot = "9")]
			public override void Execute(ScriptableRenderContext KLNHOILIBHH, RenderingData HNEGCPHIBHG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static NDIECMIFFMD CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private PFJAMCCPAJB m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x82A4150", Offset = "0x82A2950", VA = "0x1882A4150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x82A3FA0", Offset = "0x82A27A0", VA = "0x1882A3FA0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x82A3E90", Offset = "0x82A2690", VA = "0x1882A3E90", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer JGPHFKDOCBN, RenderingData HNEGCPHIBHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1623F00", Offset = "0x1622700", VA = "0x181623F00")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string KKMIEINCKCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool GLAOKEGCOKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer NOACLCGHLMN, ScriptableRenderContext KLNHOILIBHH, RenderingData HNEGCPHIBHG);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9DECA0", Offset = "0x9DD4A0", VA = "0x1809DECA0")]
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
		private class NGLDHBMEEJD : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool APMGCDAIEGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> EGCPCIPPANA;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> CGDJHJDNGMA;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x82A47C0", Offset = "0x82A2FC0", VA = "0x1882A47C0")]
			public NGLDHBMEEJD(RenderPassEvent AHDJGIKMPCG, bool APMGCDAIEGM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x82A4450", Offset = "0x82A2C50", VA = "0x1882A4450")]
			public bool NBMDJKMLJEF(CameraData JPKLHEDKCGM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x82A41A0", Offset = "0x82A29A0", VA = "0x1882A41A0", Slot = "9")]
			public override void Execute(ScriptableRenderContext KLNHOILIBHH, RenderingData HNEGCPHIBHG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x82A4370", Offset = "0x82A2B70", VA = "0x1882A4370")]
			private void LLEFOMAFOJF(PerCameraRenderEffect FLGCONNJOLN, ScriptableRenderContext KLNHOILIBHH, RenderingData HNEGCPHIBHG)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private NGLDHBMEEJD m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private NGLDHBMEEJD m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x82A5B70", Offset = "0x82A4370", VA = "0x1882A5B70", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x82A5AE0", Offset = "0x82A42E0", VA = "0x1882A5AE0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer JGPHFKDOCBN, RenderingData HNEGCPHIBHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1623F00", Offset = "0x1622700", VA = "0x181623F00")]
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
		[Cpp2IlInjected.Address(RVA = "0x82A5DC0", Offset = "0x82A45C0", VA = "0x1882A5DC0")]
		public static void OIKLEPCAPFJ(ScriptableRenderPass OJKJKDEHIDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x82A5C20", Offset = "0x82A4420", VA = "0x1882A5C20", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer JGPHFKDOCBN, RenderingData HNEGCPHIBHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1623F00", Offset = "0x1622700", VA = "0x181623F00")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class DFFOMJOHLBG
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 BCAONMDNGAO;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 OGFLADOLAEA;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 EINDPDBHBPL;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 OLNEHGCMCDN;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 GJLBPAIGKEF;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x829E820", Offset = "0x829D020", VA = "0x18829E820")]
	public static uint OOAJKBAEHJH(uint LEFBJAGNHCD, uint LLGPJHIECFH, uint JIFGKBNPEMN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x829E630", Offset = "0x829CE30", VA = "0x18829E630")]
	public static uint3 NFCMMEGMLBJ(float3 NCGKJMOKFAF, float3 GIEBBGCFCNJ, float3 KJPGBHKKLJB)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x829E3F0", Offset = "0x829CBF0", VA = "0x18829E3F0")]
	public static void JLMMKFDJCNE(float3 KAMFLEDPDNM, float3 HJLNPCMFGIP, float3 FJLLNGHBNPF, float BCDEDKPOOJB, [Out] uint3 NFBEFNBJFOK, [Out] uint3 GFHOMKNGDCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x829DD80", Offset = "0x829C580", VA = "0x18829DD80")]
	public static void CCMNHHFKCDO(float3 ADOHDMAJEEO, float3 NPEDIHJIBCL, float LPANGBAAEHJ, float CAIJPMDFDDK, [Out] float3 JMODEPAHCCJ, [Out] float BCDEDKPOOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x829E250", Offset = "0x829CA50", VA = "0x18829E250")]
	private static float3 IJGDCDOOMCK(float3 MJHDHBAJJGF, float3 BPAMMLJGEBO, float3 BNPCECFCMJI, float3 LMCFKKKDJEE)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class ALJBNHOFHGE
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly LLPKKNNAIAE JMCMHCKGGFP;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly LLPKKNNAIAE FGKIGJPIOBI;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly LLPKKNNAIAE AKOJDNBJFCN;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly LLPKKNNAIAE FPCOMNEMAOG;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly LLPKKNNAIAE FPNKHNDIOPE;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class OAMJFNGBJHF
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh OCFCCMPNEHB;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x82A50D0", Offset = "0x82A38D0", VA = "0x1882A50D0")]
	public static Mesh OMBGFKFIEAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x82A4C30", Offset = "0x82A3430", VA = "0x1882A4C30")]
	public static Matrix4x4 JPMIEBKDFJP(Camera DJHBAGBEEIN, bool ANFLDCLKKMH = false, bool JMKNDIAHNCF = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x82A4870", Offset = "0x82A3070", VA = "0x1882A4870")]
	private static Mesh ECOKICKCNPH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__4197501809
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x82A71E0", Offset = "0x82A59E0", VA = "0x1882A71E0")]
	public static void IABNMKOPMDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x82A71D0", Offset = "0x82A59D0", VA = "0x1882A71D0")]
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
