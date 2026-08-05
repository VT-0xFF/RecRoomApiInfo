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
	public class LogRegistrationIndex : MPFOBEHAELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x72FC8E0", Offset = "0x72FBAE0", VA = "0x1872FC8E0", Slot = "4")]
		public override void ALGAFMBJNNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
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
		public enum PADBFBFOLGP
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface OLJDKIMNMFC
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void OOOLIJIHFCP(ScriptableRenderContext GFIAFOEJCDD, List<Camera> HIBGJHMPNHC);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface MCNGMGIFMOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void OOOLIJIHFCP(ScriptableRenderContext GFIAFOEJCDD, RenderingData FJLFIELHBJM);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class LIMJNELCBKN : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x72FBDA0", Offset = "0x72FAFA0", VA = "0x1872FBDA0")]
			public LIMJNELCBKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x72FBD40", Offset = "0x72FAF40", VA = "0x1872FBD40", Slot = "9")]
			public override void Execute(ScriptableRenderContext GFIAFOEJCDD, RenderingData FJLFIELHBJM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private LIMJNELCBKN _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<OLJDKIMNMFC> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<OLJDKIMNMFC> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<MCNGMGIFMOE> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<MCNGMGIFMOE> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x72FFA90", Offset = "0x72FEC90", VA = "0x1872FFA90")]
		public static void CBHCAHKEKPP(PADBFBFOLGP CENDLIHLHAK, OLJDKIMNMFC LEKOFFLAONN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x72FFF00", Offset = "0x72FF100", VA = "0x1872FFF00")]
		public static void IJOMFFIJHHO(PADBFBFOLGP CENDLIHLHAK, OLJDKIMNMFC LEKOFFLAONN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x72FF9D0", Offset = "0x72FEBD0", VA = "0x1872FF9D0")]
		public static void CBHCAHKEKPP(PADBFBFOLGP CENDLIHLHAK, MCNGMGIFMOE OOHDLNHFNEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x72FFE40", Offset = "0x72FF040", VA = "0x1872FFE40")]
		public static void IJOMFFIJHHO(PADBFBFOLGP CENDLIHLHAK, MCNGMGIFMOE OOHDLNHFNEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x72FFB50", Offset = "0x72FED50", VA = "0x1872FFB50", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x72FF450", Offset = "0x72FE650", VA = "0x1872FF450", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IDGAFEEHOAC, RenderingData FJLFIELHBJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x72FFD30", Offset = "0x72FEF30", VA = "0x1872FFD30", Slot = "9")]
		protected override void Dispose(bool FOAHCEHAJHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x72FF4F0", Offset = "0x72FE6F0", VA = "0x1872FF4F0")]
		private static void CBCAGMOGELF(ScriptableRenderContext GFIAFOEJCDD, List<Camera> HIBGJHMPNHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x72FF3E0", Offset = "0x72FE5E0", VA = "0x1872FF3E0")]
		private static void AJLNFNOGMMK(ScriptableRenderContext GFIAFOEJCDD, List<Camera> HIBGJHMPNHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72FFFC0", Offset = "0x72FF1C0", VA = "0x1872FFFC0")]
		private static void OIPGDDNKCFF(ScriptableRenderContext GFIAFOEJCDD, RenderingData FJLFIELHBJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1082CF0", Offset = "0x1081EF0", VA = "0x181082CF0")]
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
		private class JNCOMAJNBJJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool AACBFIIDMFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<EBMEKIDKJEL> LIHHEJAFKMB;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x72FB030", Offset = "0x72FA230", VA = "0x1872FB030")]
			public JNCOMAJNBJJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class HBBFNEFFFKD : PreRenderManager.MCNGMGIFMOE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string NKCECDCGOGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler GFGBLCDLOJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly JNCOMAJNBJJ EOAEJJOIIHG;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x72F8E70", Offset = "0x72F8070", VA = "0x1872F8E70")]
			public HBBFNEFFFKD(JNCOMAJNBJJ CHOBIIBKFNE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x72F8A70", Offset = "0x72F7C70", VA = "0x1872F8A70", Slot = "4")]
			public void OOOLIJIHFCP(ScriptableRenderContext GFIAFOEJCDD, RenderingData FJLFIELHBJM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class ANBJIFLKPKE : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string GHDOBEIHNOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly JNCOMAJNBJJ CHOBIIBKFNE;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x72F5DD0", Offset = "0x72F4FD0", VA = "0x1872F5DD0")]
			public ANBJIFLKPKE(RenderPassEvent BCAJFLJCEPH, JNCOMAJNBJJ CHOBIIBKFNE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x72F5AC0", Offset = "0x72F4CC0", VA = "0x1872F5AC0", Slot = "9")]
			public override void Execute(ScriptableRenderContext GFIAFOEJCDD, RenderingData FJLFIELHBJM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<EBMEKIDKJEL> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private HBBFNEFFFKD fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private ANBJIFLKPKE fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private JNCOMAJNBJJ sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x72F7590", Offset = "0x72F6790", VA = "0x1872F7590", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x72F7910", Offset = "0x72F6B10", VA = "0x1872F7910", Slot = "9")]
		protected override void Dispose(bool FOAHCEHAJHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x72F7500", Offset = "0x72F6700", VA = "0x1872F7500", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IDGAFEEHOAC, RenderingData FJLFIELHBJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1082CF0", Offset = "0x1081EF0", VA = "0x181082CF0")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EBMEKIDKJEL
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CFPKAFMPHLC(CommandBuffer OLAFJFECFNI, Camera MPMEEHICOGB, [NotNull] UniversalAdditionalCameraData CHGBGCKFFDI, bool HHFJFGOKHFN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AGFIDAIDCBA(Camera MPMEEHICOGB, CommandBuffer GLIPPBIHDNK);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class EHODFKGINJE
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool NOKKJMMLEAK;
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
		private FJKHDEMMAJC _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private JKGCAPCKFGO _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x72FC870", Offset = "0x72FBA70", VA = "0x1872FC870", Slot = "9")]
		protected override void Dispose(bool OIPJKFNPAHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x72FC5C0", Offset = "0x72FB7C0", VA = "0x1872FC5C0")]
		private void CIMNIJIAOJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x72FC270", Offset = "0x72FB470", VA = "0x1872FC270", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IDGAFEEHOAC, RenderingData FJLFIELHBJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1082CF0", Offset = "0x1081EF0", VA = "0x181082CF0")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FOLHFLKJNMF
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x72F74F0", Offset = "0x72F66F0", VA = "0x1872F74F0")]
	public static int LBLKPFGEAEI(bool NMOKBOCFEOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x14CB220", Offset = "0x14CA420", VA = "0x1814CB220")]
	public static int GIBNHBOKEPK(bool NMOKBOCFEOJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct PNLENOENICH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType LGNFMDCBDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float NPAKNHPJOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float GELGLJHAMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float IBKJIHBDHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 KBPOHNDCNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 GDPCALFLIBK;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct BMMACPIAAOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort KDCEDDLPCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float OLKGEKGKLJD;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct GHGBIFKOIBI : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<PNLENOENICH> MMFHBBFNPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 LHNDLGGLDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 IBNPLNJBIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, BMMACPIAAOB>.ParallelWriter AHDKMIFPAMF;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x72F7E70", Offset = "0x72F7070", VA = "0x1872F7E70", Slot = "4")]
	public void Execute(int KDCEDDLPCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x72F7B00", Offset = "0x72F6D00", VA = "0x1872F7B00")]
	private void BMFIGGDOEFM(uint3 JMJPACDHAGE, uint3 IELDOBJHALI, ushort KDCEDDLPCBI, float3 ODIGBGFMHMH, float JBDOOHHIECB, float FNOMAJJOHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x72F8490", Offset = "0x72F7690", VA = "0x1872F8490")]
	private void NCLCPOHFAOG(uint3 JMJPACDHAGE, uint3 IELDOBJHALI, ushort KDCEDDLPCBI, float3 ODIGBGFMHMH, float3 OBJBEMNOKHO, float3 MNBDPOKABMA, float JBDOOHHIECB, float EGCIEKMPGNG, float FNOMAJJOHKN, float PJKIDDEMPMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x72F8940", Offset = "0x72F7B40", VA = "0x1872F8940")]
	private float3 NLHNEPCAKPC(uint3 JMJPACDHAGE, float3 ODIGBGFMHMH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x72F83B0", Offset = "0x72F75B0", VA = "0x1872F83B0")]
	private float GDINAOJMJAB(float NPAKNHPJOMP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x72F83D0", Offset = "0x72F75D0", VA = "0x1872F83D0")]
	private float KPNGBPPKFDF(float3 MGDLNGKDJOE, float3 MNBDPOKABMA, float EGCIEKMPGNG, float FNOMAJJOHKN)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct INAMLKGPIAP : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, BMMACPIAAOB> AHDKMIFPAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint LDECKECBHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int OEFFGGHJEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int DHHDEJNPJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> BNLECMGLKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> OBPGHHMGEAD;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x72F8F30", Offset = "0x72F8130", VA = "0x1872F8F30", Slot = "4")]
	public void Execute(int ONJLFFHGELP, int IACFDOIFAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x72F90D0", Offset = "0x72F82D0", VA = "0x1872F90D0")]
	private void PFLOBCOGINL(int BILGGOMALJK, ushort MGKGOEKIBCM, int LKDNEKHAPIJ, BMMACPIAAOB PMPDIGHNLOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct GMACHPHIEKC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, BMMACPIAAOB> AHDKMIFPAMF;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x72F8A30", Offset = "0x72F7C30", VA = "0x1872F8A30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FJKHDEMMAJC : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool HNFMBEFDOKB;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float AEGAHNLDJJA = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int KLOMFHGMOPF = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int KOGOILGENLH = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private GHGBIFKOIBI HODLDLBMLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private INAMLKGPIAP PGJDKNGFECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private GMACHPHIEKC OJOONNPKOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, BMMACPIAAOB> KDFIDEDLDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private NGINABPFHJB GIEKGHLCBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool ACDDIJDIIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int BIJKFDLIMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<PNLENOENICH> CBCGMDHGMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle IBJJKPHPJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle BPABFMKFKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool AEDOCJDJONM;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x72F7440", Offset = "0x72F6640", VA = "0x1872F7440")]
	public FJKHDEMMAJC(RenderPassEvent BCAJFLJCEPH, ComputeShader NALOIELIKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x72F6DB0", Offset = "0x72F5FB0", VA = "0x1872F6DB0")]
	private void KFGIDEOBBHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x72F6E20", Offset = "0x72F6020", VA = "0x1872F6E20")]
	public void KPFBLAGPIEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2DFCF30", Offset = "0x2DFC130", VA = "0x182DFCF30")]
	public static void LHLIGDNMFJD<T>(NativeArray<T> IEIBCNCHGJN, int JAICOMOJIGD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x72F7060", Offset = "0x72F6260", VA = "0x1872F7060")]
	public void PHGLCNPPEEB(CameraData CHGBGCKFFDI, LightData AIHMMALFMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x72F68C0", Offset = "0x72F5AC0", VA = "0x1872F68C0")]
	private void FDFJDEFKOAA(LightData AIHMMALFMEF, NativeArray<PNLENOENICH> EPPIGPBMONA, int JNDBDIIKPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x72F6580", Offset = "0x72F5780", VA = "0x1872F6580")]
	private void DCIFOPPLEDN(CameraData CHGBGCKFFDI, LightData AIHMMALFMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x72F6C00", Offset = "0x72F5E00", VA = "0x1872F6C00")]
	private void GNPOIHKFBHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x72F6F00", Offset = "0x72F6100", VA = "0x1872F6F00")]
	private void LBHHHPIDCLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x72F6D90", Offset = "0x72F5F90", VA = "0x1872F6D90")]
	private void HKPBINIKGBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x72F7000", Offset = "0x72F6200", VA = "0x1872F7000")]
	private void OEEDLOBOJGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x72F67C0", Offset = "0x72F59C0", VA = "0x1872F67C0", Slot = "9")]
	public override void Execute(ScriptableRenderContext GFIAFOEJCDD, RenderingData FJLFIELHBJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x72F7030", Offset = "0x72F6230", VA = "0x1872F7030", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer GLIPPBIHDNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JKGCAPCKFGO : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort PMOGKLMEJDL = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float AEGAHNLDJJA = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly NGINABPFHJB GIEKGHLCBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int AJLNLLNNBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private PNLENOENICH[] CBCGMDHGMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 HCEPAODJDDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 EEFJHMENMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint HPFIGGAOCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int FJCKPBDKLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int EDFOPGPICKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> BNLECMGLKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> OBPGHHMGEAD;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x72FAF80", Offset = "0x72FA180", VA = "0x1872FAF80")]
	public JKGCAPCKFGO(RenderPassEvent BCAJFLJCEPH, ComputeShader NALOIELIKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x72FAE10", Offset = "0x72FA010", VA = "0x1872FAE10")]
	public void PHGLCNPPEEB(CameraData CHGBGCKFFDI, LightData AIHMMALFMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x72F9BE0", Offset = "0x72F8DE0", VA = "0x1872F9BE0")]
	private void IHCHBMLDIED(CameraData CHGBGCKFFDI, LightData AIHMMALFMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x72F9E20", Offset = "0x72F9020", VA = "0x1872F9E20")]
	public void KPFBLAGPIEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x72F9890", Offset = "0x72F8A90", VA = "0x1872F9890")]
	private void FDFJDEFKOAA(LightData AIHMMALFMEF, PNLENOENICH[] EPPIGPBMONA, int JNDBDIIKPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x72FAAE0", Offset = "0x72F9CE0", VA = "0x1872FAAE0")]
	private void OJINMOAACCN(int ONJLFFHGELP, int IACFDOIFAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x72F9E40", Offset = "0x72F9040", VA = "0x1872F9E40")]
	private void LMBPLNGFIJF(int ONJLFFHGELP, int NDEFEFEFLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x72F9DE0", Offset = "0x72F8FE0", VA = "0x1872F9DE0")]
	private ushort JBIEJLCBJEB(int ONJLFFHGELP)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x72FA3C0", Offset = "0x72F95C0", VA = "0x1872FA3C0")]
	private void NDAHGBOBEAH(int ONJLFFHGELP, int IACFDOIFAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x72F9740", Offset = "0x72F8940", VA = "0x1872F9740")]
	private void EGFKFGKKGCD(int JAICOMOJIGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x72FAB90", Offset = "0x72F9D90", VA = "0x1872FAB90")]
	private void OLOJIIBPDDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x72F97B0", Offset = "0x72F89B0", VA = "0x1872F97B0", Slot = "9")]
	public override void Execute(ScriptableRenderContext GFIAFOEJCDD, RenderingData FJLFIELHBJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x72FAC50", Offset = "0x72F9E50", VA = "0x1872FAC50", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer GLIPPBIHDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x72FA530", Offset = "0x72F9730", VA = "0x1872FA530")]
	private void NLPMGGFKKJM(int KDCEDDLPCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x72F9240", Offset = "0x72F8440", VA = "0x1872F9240")]
	private void BMFIGGDOEFM(uint3 JMJPACDHAGE, uint3 IELDOBJHALI, ushort KDCEDDLPCBI, float3 ODIGBGFMHMH, float JBDOOHHIECB, float FNOMAJJOHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x72F9E70", Offset = "0x72F9070", VA = "0x1872F9E70")]
	private void NCLCPOHFAOG(uint3 JMJPACDHAGE, uint3 IELDOBJHALI, ushort KDCEDDLPCBI, float3 ODIGBGFMHMH, float3 OBJBEMNOKHO, float3 MNBDPOKABMA, float JBDOOHHIECB, float EGCIEKMPGNG, float FNOMAJJOHKN, float PJKIDDEMPMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x72F9650", Offset = "0x72F8850", VA = "0x1872F9650")]
	private void CNHMGMAEHBN(ushort KDCEDDLPCBI, uint MNEIGDEDJFD, float ABNNHMMIMMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x72FA430", Offset = "0x72F9630", VA = "0x1872FA430")]
	private float3 NLHNEPCAKPC(uint3 JMJPACDHAGE, float3 ODIGBGFMHMH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x72F83B0", Offset = "0x72F75B0", VA = "0x1872F83B0")]
	private float GDINAOJMJAB(float NPAKNHPJOMP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x72F83D0", Offset = "0x72F75D0", VA = "0x1872F83D0")]
	private float KPNGBPPKFDF(float3 MGDLNGKDJOE, float3 MNBDPOKABMA, float EGCIEKMPGNG, float FNOMAJJOHKN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x72FAC80", Offset = "0x72F9E80", VA = "0x1872FAC80")]
	private void PFLOBCOGINL(int BILGGOMALJK, ushort MGKGOEKIBCM, int LKDNEKHAPIJ, BMMACPIAAOB PMPDIGHNLOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class NGINABPFHJB
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class OMPPKLIFEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int AJMECABAMEL;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int CGLHLICMLNG;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int ODMACNJALEL;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int DGNADDGPDMH;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int NMOKCEHKPIN;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int AEODDDDKHMN;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int BEDCEJAMMNJ;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int AFIOJNAELHO = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int AADIGBCOJOF = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int GFCHFPCCNLK = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int JABHDGIHHJB = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int EACOMNLKEDG = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int OFBPGCLFLFD = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int FNBILABEHAJ = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool HFNAGKPJNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer IOPEHDHFEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture PKFCLBBLMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int INGIKIBAIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int DDDOJNHALEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int MGDMOOAKLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int DMOENELNGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int GNLIHCDNFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader DHNDNILMIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int AMNEMEMPHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int CICJGDIJNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 LEIBGKHPOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 FJMCHHLGLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> GIHMKICILAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> MPNKJPMOOPO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> KPLBOCJGJIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x132BE00", Offset = "0x132B000", VA = "0x18132BE00")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> DOHFCLPLJNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1860770", Offset = "0x185F970", VA = "0x181860770")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int BJJJPJGMEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xBCA8D0", Offset = "0xBC9AD0", VA = "0x180BCA8D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int JLFDFNCHBHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x897BF0", Offset = "0x896DF0", VA = "0x180897BF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader NMNHMHFGGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x72FD330", Offset = "0x72FC530", VA = "0x1872FD330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x72FDB40", Offset = "0x72FCD40", VA = "0x1872FDB40")]
	public void OAFCGGBDEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x72FD020", Offset = "0x72FC220", VA = "0x1872FD020")]
	public void IJONPJLMJMB(CameraData CHGBGCKFFDI, LightData AIHMMALFMEF, int KMHLANGJOAJ, bool NMOKBOCFEOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2F7C730", Offset = "0x2F7B930", VA = "0x182F7C730")]
	private void LHLIGDNMFJD<T>(NativeArray<T> IEIBCNCHGJN, int JAICOMOJIGD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x72FDC30", Offset = "0x72FCE30", VA = "0x1872FDC30")]
	public void OBOBABCMMHB(CommandBuffer GLIPPBIHDNK, ScriptableRenderContext GFIAFOEJCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x72FD960", Offset = "0x72FCB60", VA = "0x1872FD960")]
	private static void LINNGIPEABE(int JDOLDNENDMC, CommandBuffer GLIPPBIHDNK, RenderBuffer KHNICFJNDIA, ComputeBuffer FANBGGKFMKI, ComputeShader GPJJLELFCMI, int GJONHMIMAAP, int LHKPCBGIKOI, int JGGFNBIPFLP, int MGNEKMCEHJH, int OIGEEBIICGA, int KKEGIBHPIOM, int FLIANENBAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x72FD650", Offset = "0x72FC850", VA = "0x1872FD650")]
	public void LECNEMBIKHO(CommandBuffer GLIPPBIHDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x72FDF80", Offset = "0x72FD180", VA = "0x1872FDF80")]
	private RenderTexture OOAOKIAJCFC(RenderTexture GEMLICIIDDF, int GJONHMIMAAP, int LHKPCBGIKOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x72FCFA0", Offset = "0x72FC1A0", VA = "0x1872FCFA0")]
	public void CDCALNJDNLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x72FD3C0", Offset = "0x72FC5C0", VA = "0x1872FD3C0")]
	public void KHPDANIJNCC(int MCMOGONOJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x72FE160", Offset = "0x72FD360", VA = "0x1872FE160")]
	public NGINABPFHJB()
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
		public struct GEPEAPCPELF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float KGMIKGNLEFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float HHCNJIFCLNJ;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class LKMMNIFMICB : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string NLEEIHFPBFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler KJEHLNILIIC;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int EOMPGECIHEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material LHMHCOFHCGA;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x72FC190", Offset = "0x72FB390", VA = "0x1872FC190")]
			public LKMMNIFMICB(RenderPassEvent BCAJFLJCEPH, Material JEDKLDMCCCG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x72FBDC0", Offset = "0x72FAFC0", VA = "0x1872FBDC0", Slot = "9")]
			public override void Execute(ScriptableRenderContext GFIAFOEJCDD, RenderingData FJLFIELHBJM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static GEPEAPCPELF CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private LKMMNIFMICB m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x72FCC40", Offset = "0x72FBE40", VA = "0x1872FCC40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x72FCBF0", Offset = "0x72FBDF0", VA = "0x1872FCBF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x72FCA40", Offset = "0x72FBC40", VA = "0x1872FCA40", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x72FC970", Offset = "0x72FBB70", VA = "0x1872FC970", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IDGAFEEHOAC, RenderingData FJLFIELHBJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1082CF0", Offset = "0x1081EF0", VA = "0x181082CF0")]
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
		public struct CHOPKLCILJI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float NHGJGNFAGFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color FBIFFDNJBIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh JAFNNCINNDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve NCFDENEPCLG;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class KLNHHICCAGD : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string NLEEIHFPBFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler KJEHLNILIIC;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int CBAPBIPJJCA;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int EOBKFIHAFPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material LHMHCOFHCGA;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x72FBC60", Offset = "0x72FAE60", VA = "0x1872FBC60")]
			public KLNHHICCAGD(RenderPassEvent BCAJFLJCEPH, Material JEDKLDMCCCG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x72FB9C0", Offset = "0x72FABC0", VA = "0x1872FB9C0", Slot = "9")]
			public override void Execute(ScriptableRenderContext GFIAFOEJCDD, RenderingData FJLFIELHBJM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static CHOPKLCILJI CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private KLNHHICCAGD m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x72FCF50", Offset = "0x72FC150", VA = "0x1872FCF50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x72FCDA0", Offset = "0x72FBFA0", VA = "0x1872FCDA0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x72FCC90", Offset = "0x72FBE90", VA = "0x1872FCC90", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IDGAFEEHOAC, RenderingData FJLFIELHBJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1082CF0", Offset = "0x1081EF0", VA = "0x181082CF0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string PEKHKPBJNDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool FDDNJCNGINJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer GLIPPBIHDNK, ScriptableRenderContext GFIAFOEJCDD, RenderingData FJLFIELHBJM);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8966A0", Offset = "0x8958A0", VA = "0x1808966A0")]
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
		private class CGNLEIALLGJ : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool BCEOFNBGMJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> MMEOJBINPBM;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> KKOJHOKAOIH;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x72F64D0", Offset = "0x72F56D0", VA = "0x1872F64D0")]
			public CGNLEIALLGJ(RenderPassEvent BCAJFLJCEPH, bool BCEOFNBGMJN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x72F6080", Offset = "0x72F5280", VA = "0x1872F6080")]
			public bool FPAEFDFBCCH(CameraData CHGBGCKFFDI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x72F5EB0", Offset = "0x72F50B0", VA = "0x1872F5EB0", Slot = "9")]
			public override void Execute(ScriptableRenderContext GFIAFOEJCDD, RenderingData FJLFIELHBJM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x72F6360", Offset = "0x72F5560", VA = "0x1872F6360")]
			private void HHNIEEFEGNL(PerCameraRenderEffect FAIMNEOHLFN, ScriptableRenderContext GFIAFOEJCDD, RenderingData FJLFIELHBJM)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private CGNLEIALLGJ m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private CGNLEIALLGJ m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x72FF020", Offset = "0x72FE220", VA = "0x1872FF020", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x72FEF90", Offset = "0x72FE190", VA = "0x1872FEF90", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IDGAFEEHOAC, RenderingData FJLFIELHBJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1082CF0", Offset = "0x1081EF0", VA = "0x181082CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72FF270", Offset = "0x72FE470", VA = "0x1872FF270")]
		public static void BKKHHNLJOIP(ScriptableRenderPass FHEGBDKGNFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x72FF0D0", Offset = "0x72FE2D0", VA = "0x1872FF0D0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer IDGAFEEHOAC, RenderingData FJLFIELHBJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1082CF0", Offset = "0x1081EF0", VA = "0x181082CF0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class PHEEOGLIEOO
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 AFABABICOIE;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 FHDMFFFLEFA;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 OIIPLBMINNP;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 OGPJFLNKBLG;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 CJMFKBMJGJG;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x72FEE50", Offset = "0x72FE050", VA = "0x1872FEE50")]
	public static uint KPFIFGGAINL(uint AKHPALIKFFK, uint PGLPHKNNCEF, uint HMKOFHHFHNJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x72FEAC0", Offset = "0x72FDCC0", VA = "0x1872FEAC0")]
	public static uint3 GPGBMCIFPCP(float3 FJFKFIAGEPM, float3 LHNDLGGLDPB, float3 IBNPLNJBIDM)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x72FE880", Offset = "0x72FDA80", VA = "0x1872FE880")]
	public static void ENPDLDNCKJD(float3 ONFGBJEMPNG, float3 AKDDFDLJHLG, float3 JJBAHNMPPKP, float DLNPAPKJAEH, [Out] uint3 EIHBOAINAKM, [Out] uint3 INDDBPDOKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x72FE3B0", Offset = "0x72FD5B0", VA = "0x1872FE3B0")]
	public static void EBNEMGBPBLJ(float3 NKNNNPLHAJO, float3 PBJMEOAEBBG, float GELGLJHAMIN, float NNFOFFAOGNB, [Out] float3 AIGEMNMEKFO, [Out] float DLNPAPKJAEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x72FECB0", Offset = "0x72FDEB0", VA = "0x1872FECB0")]
	private static float3 IFKOIPCNJLI(float3 IGNELEJMLBE, float3 CBEEBNMNPJD, float3 JHCOPOCGGIA, float3 GOACOEGJJNE)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class OJGBMFBJGGB
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly GAFGFHIJEHD NEMFLEDJPDH;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly GAFGFHIJEHD NECPHLIMOOC;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly GAFGFHIJEHD ACEHAPJJDEJ;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly GAFGFHIJEHD NDNEHDNPEHE;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class KLEPDAEJCGF
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static Mesh CELFEHKPONB;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x72FB920", Offset = "0x72FAB20", VA = "0x1872FB920")]
	public static Mesh KBONKEGFIIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x72FB0C0", Offset = "0x72FA2C0", VA = "0x1872FB0C0")]
	public static Matrix4x4 AJDJIOGGECJ(Camera MPMEEHICOGB, bool MIJOPAFCIFO = false, bool DNJHEBILBMH = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x72FB560", Offset = "0x72FA760", VA = "0x1872FB560")]
	private static Mesh IPDOFFLONFC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__824918847
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7300690", Offset = "0x72FF890", VA = "0x187300690")]
	public static void LDGPJILIGBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7300680", Offset = "0x72FF880", VA = "0x187300680")]
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
