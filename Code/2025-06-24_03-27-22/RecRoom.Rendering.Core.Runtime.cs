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
	public class LogRegistrationIndex : KHEEPBINELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x85CCA30", Offset = "0x85CB630", VA = "0x1885CCA30", Slot = "4")]
		public override void KHPGHNAFBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		public enum GDONEGCDIKC
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface CPFGANOFCMD
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void LGHBMANLFPL(ScriptableRenderContext CBLPKFIJGLH, List<Camera> BNCPEEPEIJN);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface HAIJINDLJKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void LGHBMANLFPL(ScriptableRenderContext CBLPKFIJGLH, RenderingData KGPFAOGNLNG);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class KICPOGOBDLL : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x85CBEE0", Offset = "0x85CAAE0", VA = "0x1885CBEE0")]
			public KICPOGOBDLL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x85CBE80", Offset = "0x85CAA80", VA = "0x1885CBE80", Slot = "9")]
			public override void Execute(ScriptableRenderContext CBLPKFIJGLH, RenderingData KGPFAOGNLNG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private KICPOGOBDLL _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<CPFGANOFCMD> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<CPFGANOFCMD> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<HAIJINDLJKC> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<HAIJINDLJKC> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x85D0360", Offset = "0x85CEF60", VA = "0x1885D0360")]
		public static void EJLECJLHCBN(GDONEGCDIKC KJLFIHIMENB, CPFGANOFCMD OCGAKCBJNMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x85D0E20", Offset = "0x85CFA20", VA = "0x1885D0E20")]
		public static void POCDAGLIMMO(GDONEGCDIKC KJLFIHIMENB, CPFGANOFCMD OCGAKCBJNMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x85D02A0", Offset = "0x85CEEA0", VA = "0x1885D02A0")]
		public static void EJLECJLHCBN(GDONEGCDIKC KJLFIHIMENB, HAIJINDLJKC LEHPFEOAKMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85D0EE0", Offset = "0x85CFAE0", VA = "0x1885D0EE0")]
		public static void POCDAGLIMMO(GDONEGCDIKC KJLFIHIMENB, HAIJINDLJKC LEHPFEOAKMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x85CFFB0", Offset = "0x85CEBB0", VA = "0x1885CFFB0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x85CFF10", Offset = "0x85CEB10", VA = "0x1885CFF10", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer GJIEBJCNJLG, RenderingData KGPFAOGNLNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x85D0190", Offset = "0x85CED90", VA = "0x1885D0190", Slot = "9")]
		protected override void Dispose(bool LKEAJHCAOAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x85D0490", Offset = "0x85CF090", VA = "0x1885D0490")]
		private static void JMKMGJBIOAG(ScriptableRenderContext CBLPKFIJGLH, List<Camera> BNCPEEPEIJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x85D0420", Offset = "0x85CF020", VA = "0x1885D0420")]
		private static void GOKNEABOMOD(ScriptableRenderContext CBLPKFIJGLH, List<Camera> BNCPEEPEIJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x85D0970", Offset = "0x85CF570", VA = "0x1885D0970")]
		private static void NDEMLNIFLEC(ScriptableRenderContext CBLPKFIJGLH, RenderingData KGPFAOGNLNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x17D48A0", Offset = "0x17D34A0", VA = "0x1817D48A0")]
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
		private class IMNCBHLOCJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool KKMAHOOFNBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<FFDHLLMCOIM> FFADBIBDFBG;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x85CB4A0", Offset = "0x85CA0A0", VA = "0x1885CB4A0")]
			public IMNCBHLOCJA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class JFJFAFPOHKA : PreRenderManager.HAIJINDLJKC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string KLMOCMBPFIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler JDLMBCDBEIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly IMNCBHLOCJA NNOJMGOJEGE;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x85CB920", Offset = "0x85CA520", VA = "0x1885CB920")]
			public JFJFAFPOHKA(IMNCBHLOCJA ALONJODIHLK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x85CB530", Offset = "0x85CA130", VA = "0x1885CB530", Slot = "4")]
			public void LGHBMANLFPL(ScriptableRenderContext CBLPKFIJGLH, RenderingData KGPFAOGNLNG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class NBNDEDDDNME : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string BEODOKNAJOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly IMNCBHLOCJA ALONJODIHLK;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x85CD540", Offset = "0x85CC140", VA = "0x1885CD540")]
			public NBNDEDDDNME(RenderPassEvent CCCPMLIFCCC, IMNCBHLOCJA ALONJODIHLK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x85CD230", Offset = "0x85CBE30", VA = "0x1885CD230", Slot = "9")]
			public override void Execute(ScriptableRenderContext CBLPKFIJGLH, RenderingData KGPFAOGNLNG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<FFDHLLMCOIM> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private JFJFAFPOHKA fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private NBNDEDDDNME fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private IMNCBHLOCJA sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x85CAF30", Offset = "0x85C9B30", VA = "0x1885CAF30", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x85CB2B0", Offset = "0x85C9EB0", VA = "0x1885CB2B0", Slot = "9")]
		protected override void Dispose(bool LKEAJHCAOAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x85CAEA0", Offset = "0x85C9AA0", VA = "0x1885CAEA0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer GJIEBJCNJLG, RenderingData KGPFAOGNLNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x17D48A0", Offset = "0x17D34A0", VA = "0x1817D48A0")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FFDHLLMCOIM
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PBNNINEPIMG(CommandBuffer MMIHOGIFKCB, Camera DNKADDGBBMH, [NotNull] UniversalAdditionalCameraData OOFADIBNFON, bool LCLCAHJLCHF);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JJEEBMAGIIG(Camera DNKADDGBBMH, CommandBuffer NEJGIBHBGHE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class NEENEHOMONK
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool MCGKEAHBEED;
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
		private NNOKGDOAMKJ _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private CHCMEGOAGNJ _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x85CC700", Offset = "0x85CB300", VA = "0x1885CC700", Slot = "9")]
		protected override void Dispose(bool HAFOKDBDDHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x85CC770", Offset = "0x85CB370", VA = "0x1885CC770")]
		private void HGPGHPBJEFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x85CC3B0", Offset = "0x85CAFB0", VA = "0x1885CC3B0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer GJIEBJCNJLG, RenderingData KGPFAOGNLNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x17D48A0", Offset = "0x17D34A0", VA = "0x1817D48A0")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DJMDANNBIBI
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x85CAE90", Offset = "0x85C9A90", VA = "0x1885CAE90")]
	public static int PLIMDHHNFMN(bool IJLKJGHFMDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1C64600", Offset = "0x1C63200", VA = "0x181C64600")]
	public static int DLFDFCGMNDO(bool IJLKJGHFMDM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct KJGBIDAADFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType KPJJBEMIGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float KNIIOEEJCDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float BNCKDCNKIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float EKEFJFNCNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 DBEBOPMAEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 MEBGHFHKNPM;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct KPJEAPJLGMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort FJECOBLJDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float BPHGCAPDODI;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct DBMBDDFDFBE : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<KJGBIDAADFB> NEHPCOLELIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 MELNLDNBBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 IGDBHEIDGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, KPJEAPJLGMM>.ParallelWriter JHHBGFKICLK;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x85CA130", Offset = "0x85C8D30", VA = "0x1885CA130", Slot = "4")]
	public void Execute(int FJECOBLJDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x85CAB20", Offset = "0x85C9720", VA = "0x1885CAB20")]
	private void NFJLBPPMJLM(uint3 FKEFGMINIAO, uint3 MHFPCABKEAE, ushort FJECOBLJDPK, float3 OACGFGEFCNP, float OLHPGLCHFOF, float GBHADHEBCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x85CA670", Offset = "0x85C9270", VA = "0x1885CA670")]
	private void LGKOEOAODKD(uint3 FKEFGMINIAO, uint3 MHFPCABKEAE, ushort FJECOBLJDPK, float3 OACGFGEFCNP, float3 DGDBHPANAHN, float3 ANFJLGEBFEP, float OLHPGLCHFOF, float JFLKOKOOIGH, float GBHADHEBCBK, float HOMPAPCAFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x85CA040", Offset = "0x85C8C40", VA = "0x1885CA040")]
	private float3 EMGNBLFJPFK(uint3 FKEFGMINIAO, float3 OACGFGEFCNP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x85C7880", Offset = "0x85C6480", VA = "0x1885C7880")]
	private float AFAPPHODJDH(float KNIIOEEJCDM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x85C78A0", Offset = "0x85C64A0", VA = "0x1885C78A0")]
	private float ANHKBNNFKBH(float3 FBHNDMGINJC, float3 ANFJLGEBFEP, float JFLKOKOOIGH, float GBHADHEBCBK)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct CJHLHIHDDOB : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, KPJEAPJLGMM> JHHBGFKICLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint CMOHAMLPHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int CDAANOBHILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int CJJCKOPHHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> NEKFIDAACBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> DKJNOOHKAPG;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x85C9660", Offset = "0x85C8260", VA = "0x1885C9660", Slot = "4")]
	public void Execute(int OLHCHALPLMM, int AGAMANIKBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x85C9800", Offset = "0x85C8400", VA = "0x1885C9800")]
	private void HPFAGIGLPMJ(int DPNJENGEBDD, ushort MBHKOAKOGCL, int PHLMALKEIJH, KPJEAPJLGMM FOLJFBNCBJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct AMNMMEEBBCF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, KPJEAPJLGMM> JHHBGFKICLK;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x85C6570", Offset = "0x85C5170", VA = "0x1885C6570", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NNOKGDOAMKJ : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool PIONICPJIMI;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float JOFKDNIOOFN = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int NDONEJCOMCJ = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int MEMLMFHPBBD = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private DBMBDDFDFBE LLKCEJMEMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private CJHLHIHDDOB APEPAFKLNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private AMNMMEEBBCF IMFBFAMOPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, KPJEAPJLGMM> GMDNHAPMBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private BDGFHJAIGLB IDHFGGEFLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool MIAPFIIKJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int DMKJINLPLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<KJGBIDAADFB> LPBGBLCMAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle GHGHDPBNKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle DOKGEOBMDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool MMDDFHDIJFC;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x85CEDE0", Offset = "0x85CD9E0", VA = "0x1885CEDE0")]
	public NNOKGDOAMKJ(RenderPassEvent CCCPMLIFCCC, ComputeShader PIAFCJEBAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x85CE470", Offset = "0x85CD070", VA = "0x1885CE470")]
	private void GBPBBACMLEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x85CDF50", Offset = "0x85CCB50", VA = "0x1885CDF50")]
	public void DBMPHLFAGIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3C44CE0", Offset = "0x3C438E0", VA = "0x183C44CE0")]
	public static void DEMILAHMDHI<T>(NativeArray<T> IKALPCJBCLK, int DKFJGBGJGBG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x85CE790", Offset = "0x85CD390", VA = "0x1885CE790")]
	public void JKICOLBBIFK(CameraData OOFADIBNFON, LightData NMOHPKGBBAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x85CE130", Offset = "0x85CCD30", VA = "0x1885CE130")]
	private void FDIAMPDOIMD(LightData NMOHPKGBBAE, NativeArray<KJGBIDAADFB> ABBENOMIIIJ, int JJNHPJBIMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x85CEB30", Offset = "0x85CD730", VA = "0x1885CEB30")]
	private void MNJGMCGIMDK(CameraData OOFADIBNFON, LightData NMOHPKGBBAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x85CE600", Offset = "0x85CD200", VA = "0x1885CE600")]
	private void IDHOJDMHDIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x85CE500", Offset = "0x85CD100", VA = "0x1885CE500")]
	private void HHMGDOPNPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x85CE4E0", Offset = "0x85CD0E0", VA = "0x1885CE4E0")]
	private void GPGGEJLLKLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x85CDF20", Offset = "0x85CCB20", VA = "0x1885CDF20")]
	private void BELGBKCKHHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x85CE030", Offset = "0x85CCC30", VA = "0x1885CE030", Slot = "9")]
	public override void Execute(ScriptableRenderContext CBLPKFIJGLH, RenderingData KGPFAOGNLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x85CED70", Offset = "0x85CD970", VA = "0x1885CED70", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer NEJGIBHBGHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class CHCMEGOAGNJ : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort HKKCLDPFEBI = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float JOFKDNIOOFN = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly BDGFHJAIGLB IDHFGGEFLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int DFOAGAJMDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private KJGBIDAADFB[] LPBGBLCMAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 PICPHFCODMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 LMMLDFNBMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint BGNIHGKLHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int NLAJPLNCBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int KBCNGLECJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> NEKFIDAACBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> DKJNOOHKAPG;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x85C95B0", Offset = "0x85C81B0", VA = "0x1885C95B0")]
	public CHCMEGOAGNJ(RenderPassEvent CCCPMLIFCCC, ComputeShader PIAFCJEBAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x85C81B0", Offset = "0x85C6DB0", VA = "0x1885C81B0")]
	public void JKICOLBBIFK(CameraData OOFADIBNFON, LightData NMOHPKGBBAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x85C8D60", Offset = "0x85C7960", VA = "0x1885C8D60")]
	private void OELCLOBKEFL(CameraData OOFADIBNFON, LightData NMOHPKGBBAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x85C79A0", Offset = "0x85C65A0", VA = "0x1885C79A0")]
	public void DBMPHLFAGIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x85C7C10", Offset = "0x85C6810", VA = "0x1885C7C10")]
	private void FDIAMPDOIMD(LightData NMOHPKGBBAE, KJGBIDAADFB[] ABBENOMIIIJ, int JJNHPJBIMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x85C8CB0", Offset = "0x85C78B0", VA = "0x1885C8CB0")]
	private void NPDDALPNMHL(int OLHCHALPLMM, int AGAMANIKBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x85C8870", Offset = "0x85C7470", VA = "0x1885C8870")]
	private void LPHFKAAAHPA(int OLHCHALPLMM, int DPOOEAFKIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x85C7960", Offset = "0x85C6560", VA = "0x1885C7960")]
	private ushort BJJDHDFHAKE(int OLHCHALPLMM)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x85C79C0", Offset = "0x85C65C0", VA = "0x1885C79C0")]
	private void EIGHCLEAENB(int OLHCHALPLMM, int AGAMANIKBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x85C8F90", Offset = "0x85C7B90", VA = "0x1885C8F90")]
	private void PEKOLEHCEOP(int DKFJGBGJGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x85C7F60", Offset = "0x85C6B60", VA = "0x1885C7F60")]
	private void HIBMMGBCIHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x85C7B30", Offset = "0x85C6730", VA = "0x1885C7B30", Slot = "9")]
	public override void Execute(ScriptableRenderContext CBLPKFIJGLH, RenderingData KGPFAOGNLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x85C8F60", Offset = "0x85C7B60", VA = "0x1885C8F60", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer NEJGIBHBGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x85C9000", Offset = "0x85C7C00", VA = "0x1885C9000")]
	private void PJPJMJGCCFJ(int FJECOBLJDPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x85C88A0", Offset = "0x85C74A0", VA = "0x1885C88A0")]
	private void NFJLBPPMJLM(uint3 FKEFGMINIAO, uint3 MHFPCABKEAE, ushort FJECOBLJDPK, float3 OACGFGEFCNP, float OLHPGLCHFOF, float GBHADHEBCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x85C8320", Offset = "0x85C6F20", VA = "0x1885C8320")]
	private void LGKOEOAODKD(uint3 FKEFGMINIAO, uint3 MHFPCABKEAE, ushort FJECOBLJDPK, float3 OACGFGEFCNP, float3 DGDBHPANAHN, float3 ANFJLGEBFEP, float OLHPGLCHFOF, float JFLKOKOOIGH, float GBHADHEBCBK, float HOMPAPCAFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x85C7790", Offset = "0x85C6390", VA = "0x1885C7790")]
	private void ACKKMLKDADB(ushort FJECOBLJDPK, uint BDHAAEKLGEB, float CAFPAIBJMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x85C7A30", Offset = "0x85C6630", VA = "0x1885C7A30")]
	private float3 EMGNBLFJPFK(uint3 FKEFGMINIAO, float3 OACGFGEFCNP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x85C7880", Offset = "0x85C6480", VA = "0x1885C7880")]
	private float AFAPPHODJDH(float KNIIOEEJCDM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x85C78A0", Offset = "0x85C64A0", VA = "0x1885C78A0")]
	private float ANHKBNNFKBH(float3 FBHNDMGINJC, float3 ANFJLGEBFEP, float JFLKOKOOIGH, float GBHADHEBCBK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x85C8020", Offset = "0x85C6C20", VA = "0x1885C8020")]
	private void HPFAGIGLPMJ(int DPNJENGEBDD, ushort MBHKOAKOGCL, int PHLMALKEIJH, KPJEAPJLGMM FOLJFBNCBJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class BDGFHJAIGLB
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class MLEDJIHOCBN
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int LBHCBIHLABE;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int FEMNLMKHAJJ;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int JGMKBOKAOGB;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int HICNBAHKPJP;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int CPJMDEENEJE;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int PMDKPBLEIDA;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int PKOKEKFAECP;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int LFINFENDIGP = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int KCGEKNHLKOH = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int LEICOJJOFOP = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int MHOBNDAIMGE = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int AEADOFIEAKB = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int JELGLOKBJJE = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int COCLLGCCEJA = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool PIPPGPJFECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer JBHCOJGHGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture CGNHHNEDKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int PMLFEHOIAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int EIJADNPOFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int GMJOONLDLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int IEJDGOCNCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int FDMNFJCAFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader HAAIKBLGABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int OJPFMIIPILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int IOHIAKOLPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 EOMLPPLHEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 HBDCFCEKOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> OEOFBOICCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> OGODNECBCMO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> BLPELJALCDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x47267C0", Offset = "0x47253C0", VA = "0x1847267C0")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> KHAHFPOFHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1216050", Offset = "0x1214C50", VA = "0x181216050")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int FAFHDNHNKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA6D8E0", Offset = "0xA6C4E0", VA = "0x180A6D8E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int CDNPCICICFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA20E70", Offset = "0xA1FA70", VA = "0x180A20E70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader KLNLGFBNLPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x85C65B0", Offset = "0x85C51B0", VA = "0x1885C65B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x85C7680", Offset = "0x85C6280", VA = "0x1885C7680")]
	public void LDCCMKMJIMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x85C70E0", Offset = "0x85C5CE0", VA = "0x1885C70E0")]
	public void INJJKNEFJPL(CameraData OOFADIBNFON, LightData NMOHPKGBBAE, int HJPIJLJAFGA, bool IJLKJGHFMDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3834CD0", Offset = "0x38338D0", VA = "0x183834CD0")]
	private void DEMILAHMDHI<T>(NativeArray<T> IKALPCJBCLK, int DKFJGBGJGBG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x85C66C0", Offset = "0x85C52C0", VA = "0x1885C66C0")]
	public void DOAEHCLHLPG(CommandBuffer NEJGIBHBGHE, ScriptableRenderContext CBLPKFIJGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x85C6D20", Offset = "0x85C5920", VA = "0x1885C6D20")]
	private static void FEGJKCEIIMB(int JJEBFGNKEJJ, CommandBuffer NEJGIBHBGHE, RenderBuffer BGCAHAIDEIG, ComputeBuffer GMHADEJMNKA, ComputeShader MCIICCFAIMD, int CONDEDPDDOI, int EKNLECEKCCD, int JLIOCBAJGCE, int PAHHMKEFIPG, int MMLILIGPHPC, int LDMNCCIDBPM, int GCLKBJDKCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x85C6A10", Offset = "0x85C5610", VA = "0x1885C6A10")]
	public void EBPCOICBOCC(CommandBuffer NEJGIBHBGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x85C6F00", Offset = "0x85C5B00", VA = "0x1885C6F00")]
	private RenderTexture FJEDEJLGOHG(RenderTexture GHMNBIJOHNK, int CONDEDPDDOI, int EKNLECEKCCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x85C6640", Offset = "0x85C5240", VA = "0x1885C6640")]
	public void DCLKJGPDJMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x85C73F0", Offset = "0x85C5FF0", VA = "0x1885C73F0")]
	public void JEHOABMCFGF(int LONLLBAHHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x85C7770", Offset = "0x85C6370", VA = "0x1885C7770")]
	public BDGFHJAIGLB()
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
		public struct MKAJHGNMABC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float LFNFDGKHEHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float FCKDGCCNKDP;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class LFDFCFPHIHM : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string PPNJPDDGFBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler EDCFKOENGND;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int CBCNJOEBLAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material DEPFNPPMBOC;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x85CC2D0", Offset = "0x85CAED0", VA = "0x1885CC2D0")]
			public LFDFCFPHIHM(RenderPassEvent CCCPMLIFCCC, Material IMKAMKEPJBL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x85CBF00", Offset = "0x85CAB00", VA = "0x1885CBF00", Slot = "9")]
			public override void Execute(ScriptableRenderContext CBLPKFIJGLH, RenderingData KGPFAOGNLNG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static MKAJHGNMABC CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private LFDFCFPHIHM m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x85CCED0", Offset = "0x85CBAD0", VA = "0x1885CCED0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x85CCE80", Offset = "0x85CBA80", VA = "0x1885CCE80")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x85CCCD0", Offset = "0x85CB8D0", VA = "0x1885CCCD0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x85CCC00", Offset = "0x85CB800", VA = "0x1885CCC00", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer GJIEBJCNJLG, RenderingData KGPFAOGNLNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x17D48A0", Offset = "0x17D34A0", VA = "0x1817D48A0")]
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
		public struct MMOALLAPCGB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float LDADJIMDDKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color JGCACHJGNGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh NEIKADCDELK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve FNPCECCMMNN;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class KCBGKBFKFMO : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string PPNJPDDGFBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler EDCFKOENGND;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int OJMDPFOCFHA;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int MHFNKGCONPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material DEPFNPPMBOC;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x85CBDA0", Offset = "0x85CA9A0", VA = "0x1885CBDA0")]
			public KCBGKBFKFMO(RenderPassEvent CCCPMLIFCCC, Material IMKAMKEPJBL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x85CBB00", Offset = "0x85CA700", VA = "0x1885CBB00", Slot = "9")]
			public override void Execute(ScriptableRenderContext CBLPKFIJGLH, RenderingData KGPFAOGNLNG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static MMOALLAPCGB CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private KCBGKBFKFMO m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x85CD1E0", Offset = "0x85CBDE0", VA = "0x1885CD1E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x85CD030", Offset = "0x85CBC30", VA = "0x1885CD030", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x85CCF20", Offset = "0x85CBB20", VA = "0x1885CCF20", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer GJIEBJCNJLG, RenderingData KGPFAOGNLNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x17D48A0", Offset = "0x17D34A0", VA = "0x1817D48A0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string FIHGHGJJBEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool IPCAPKIMDGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer NEJGIBHBGHE, ScriptableRenderContext CBLPKFIJGLH, RenderingData KGPFAOGNLNG);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE70", Offset = "0xA1CA70", VA = "0x180A1DE70")]
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
		private class CNKNHAPKLLI : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool LPCECGMMOJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> CECILMNLNAK;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> IPDOMNJCEAH;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x85C9F90", Offset = "0x85C8B90", VA = "0x1885C9F90")]
			public CNKNHAPKLLI(RenderPassEvent CCCPMLIFCCC, bool LPCECGMMOJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x85C9B40", Offset = "0x85C8740", VA = "0x1885C9B40")]
			public bool LFDKLMDJMNB(CameraData OOFADIBNFON)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x85C9970", Offset = "0x85C8570", VA = "0x1885C9970", Slot = "9")]
			public override void Execute(ScriptableRenderContext CBLPKFIJGLH, RenderingData KGPFAOGNLNG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x85C9E20", Offset = "0x85C8A20", VA = "0x1885C9E20")]
			private void OFNDIAFFJCN(PerCameraRenderEffect GPHKFKBJNCM, ScriptableRenderContext CBLPKFIJGLH, RenderingData KGPFAOGNLNG)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private CNKNHAPKLLI m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private CNKNHAPKLLI m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x85CFB00", Offset = "0x85CE700", VA = "0x1885CFB00", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x85CFA70", Offset = "0x85CE670", VA = "0x1885CFA70", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer GJIEBJCNJLG, RenderingData KGPFAOGNLNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x17D48A0", Offset = "0x17D34A0", VA = "0x1817D48A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85CFD50", Offset = "0x85CE950", VA = "0x1885CFD50")]
		public static void LOELHCHFNDB(ScriptableRenderPass IIMGKPMNDFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x85CFBB0", Offset = "0x85CE7B0", VA = "0x1885CFBB0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer GJIEBJCNJLG, RenderingData KGPFAOGNLNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x17D48A0", Offset = "0x17D34A0", VA = "0x1817D48A0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class OKPPOHCAOFA
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 EJKMFLKKOLK;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 OOABBNOHEOI;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 OODBHDNOKAO;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 GMAGMNGPAMK;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 BIEKIHJGMMH;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x85CEE90", Offset = "0x85CDA90", VA = "0x1885CEE90")]
	public static uint CKGNEGDDBHB(uint KFGAJBKADFK, uint FEABMDLFEMA, uint LKCFDBIMIBE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x85CEEA0", Offset = "0x85CDAA0", VA = "0x1885CEEA0")]
	public static uint3 CMCLKOIKDNA(float3 IIBJECFMAJC, float3 MELNLDNBBJF, float3 IGDBHEIDGCK)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x85CF230", Offset = "0x85CDE30", VA = "0x1885CF230")]
	public static void JLJCMOOGFCL(float3 JMBIMJDLMBO, float3 POJBGADGMKM, float3 CBLCHOILBJL, float HPDHPFDMAAO, [Out] uint3 FNNEMBJPCAL, [Out] uint3 PCNOFGIJJFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x85CF470", Offset = "0x85CE070", VA = "0x1885CF470")]
	public static void PIEDHNBKKAM(float3 IKLKNFIFDBG, float3 KEKDJABOMKF, float BNCKDCNKIDE, float IKAKKMFHIAA, [Out] float3 MKJDLLMDMCK, [Out] float HPDHPFDMAAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x85CF090", Offset = "0x85CDC90", VA = "0x1885CF090")]
	private static float3 EHFOPMMJICD(float3 NJLBCBHIANN, float3 HOENFEKDFEB, float3 OCDMAGMJNHM, float3 CNEJBPPAPIH)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class JHPHLEHIKLC
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly JPIBGNDAFKP LLAJNHFENNM;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly JPIBGNDAFKP ACEEHMHNDKN;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly JPIBGNDAFKP OBKBJFOCKAD;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly JPIBGNDAFKP NHAOEKIEHMN;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly JPIBGNDAFKP EDEJMEBJLOK;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class NCJBNKPJIAP
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh JHOLADCKOHL;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x85CD620", Offset = "0x85CC220", VA = "0x1885CD620")]
	public static Mesh DFODFOPFJLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x85CDA80", Offset = "0x85CC680", VA = "0x1885CDA80")]
	public static Matrix4x4 OKJHCMGOBBK(Camera DNKADDGBBMH, bool MBDPGDAAMLC = false, bool BIIKKIOAMJI = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x85CD6C0", Offset = "0x85CC2C0", VA = "0x1885CD6C0")]
	private static Mesh LEMLLIHMPDN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__349571641
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x85D11C0", Offset = "0x85CFDC0", VA = "0x1885D11C0")]
	public static void PPEFGBJBMGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x85D11B0", Offset = "0x85CFDB0", VA = "0x1885D11B0")]
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
