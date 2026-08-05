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
	public class LogRegistrationIndex : IGKFPLMKJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x72F8C60", Offset = "0x72F7860", VA = "0x1872F8C60", Slot = "4")]
		public override void PEGPHNFMEDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
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
		public enum AIMELMGJOMA
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface NKCNEPNMFOG
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void NPJFPNAECEE(ScriptableRenderContext PDMONEGPHPK, List<Camera> GGAKPKFNMEF);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface LKKAKBNEDIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void NPJFPNAECEE(ScriptableRenderContext PDMONEGPHPK, RenderingData LMNAFHEGHMA);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class KNAENDABKKA : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x72F7C90", Offset = "0x72F6890", VA = "0x1872F7C90")]
			public KNAENDABKKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x72F7C30", Offset = "0x72F6830", VA = "0x1872F7C30", Slot = "9")]
			public override void Execute(ScriptableRenderContext PDMONEGPHPK, RenderingData LMNAFHEGHMA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private KNAENDABKKA _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<NKCNEPNMFOG> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<NKCNEPNMFOG> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<LKKAKBNEDIE> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<LKKAKBNEDIE> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x72FD360", Offset = "0x72FBF60", VA = "0x1872FD360")]
		public static void BCHFIIOFBLK(AIMELMGJOMA PPBOJNJEKKE, NKCNEPNMFOG HGBJPBBLACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x72FD840", Offset = "0x72FC440", VA = "0x1872FD840")]
		public static void GKPIIJFCOEM(AIMELMGJOMA PPBOJNJEKKE, NKCNEPNMFOG HGBJPBBLACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x72FD2A0", Offset = "0x72FBEA0", VA = "0x1872FD2A0")]
		public static void BCHFIIOFBLK(AIMELMGJOMA PPBOJNJEKKE, LKKAKBNEDIE OILKBNEMEOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x72FD780", Offset = "0x72FC380", VA = "0x1872FD780")]
		public static void GKPIIJFCOEM(AIMELMGJOMA PPBOJNJEKKE, LKKAKBNEDIE OILKBNEMEOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x72FD490", Offset = "0x72FC090", VA = "0x1872FD490", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x72FD200", Offset = "0x72FBE00", VA = "0x1872FD200", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer HKFOEGKIJPH, RenderingData LMNAFHEGHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x72FD670", Offset = "0x72FC270", VA = "0x1872FD670", Slot = "9")]
		protected override void Dispose(bool PKEHFLGFGFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x72FD900", Offset = "0x72FC500", VA = "0x1872FD900")]
		private static void NFPONGGCKIH(ScriptableRenderContext PDMONEGPHPK, List<Camera> GGAKPKFNMEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x72FD420", Offset = "0x72FC020", VA = "0x1872FD420")]
		private static void BNKFAJLNMCL(ScriptableRenderContext PDMONEGPHPK, List<Camera> GGAKPKFNMEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72FDDF0", Offset = "0x72FC9F0", VA = "0x1872FDDF0")]
		private static void PLOMJANHPFK(ScriptableRenderContext PDMONEGPHPK, RenderingData LMNAFHEGHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xF71DD0", Offset = "0xF709D0", VA = "0x180F71DD0")]
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
		private class BIJNMCHENKF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool MCKKBGKIDJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<DDICADEJJOD> EHCCLHEABNI;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x72F3D50", Offset = "0x72F2950", VA = "0x1872F3D50")]
			public BIJNMCHENKF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class OCCGLMPDEHH : PreRenderManager.LKKAKBNEDIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string ILODCPLFPCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler PODDDDBHILE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly BIJNMCHENKF JPPLHECNLLP;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x72FADC0", Offset = "0x72F99C0", VA = "0x1872FADC0")]
			public OCCGLMPDEHH(BIJNMCHENKF EJDOMPPNIKF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x72FA9C0", Offset = "0x72F95C0", VA = "0x1872FA9C0", Slot = "4")]
			public void NPJFPNAECEE(ScriptableRenderContext PDMONEGPHPK, RenderingData LMNAFHEGHMA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class MOLPDGLOGGC : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string HEPNDNPKMMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly BIJNMCHENKF EJDOMPPNIKF;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x72F9000", Offset = "0x72F7C00", VA = "0x1872F9000")]
			public MOLPDGLOGGC(RenderPassEvent LGPIICDBGBB, BIJNMCHENKF EJDOMPPNIKF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x72F8CF0", Offset = "0x72F78F0", VA = "0x1872F8CF0", Slot = "9")]
			public override void Execute(ScriptableRenderContext PDMONEGPHPK, RenderingData LMNAFHEGHMA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<DDICADEJJOD> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private OCCGLMPDEHH fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private MOLPDGLOGGC fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private BIJNMCHENKF sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x72F6750", Offset = "0x72F5350", VA = "0x1872F6750", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x72F6AD0", Offset = "0x72F56D0", VA = "0x1872F6AD0", Slot = "9")]
		protected override void Dispose(bool PKEHFLGFGFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x72F66C0", Offset = "0x72F52C0", VA = "0x1872F66C0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer HKFOEGKIJPH, RenderingData LMNAFHEGHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xF71DD0", Offset = "0xF709D0", VA = "0x180F71DD0")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DDICADEJJOD
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FIHLFKGDDOL(CommandBuffer HKMAGAJNIPO, Camera FDEJBGLBHHB, [NotNull] UniversalAdditionalCameraData JGPIOACDIBA, bool KCJDOIBBIHI);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void POLMEHMDPDE(Camera FDEJBGLBHHB, CommandBuffer EKFBBEMKDNF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class IJOLMEJNAND
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool NMKNHMMFKNH;
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
		private KAFAMADCFCI _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private OPOGPHLOPGL _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x72F8BF0", Offset = "0x72F77F0", VA = "0x1872F8BF0", Slot = "9")]
		protected override void Dispose(bool LOFOJGPEFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x72F8940", Offset = "0x72F7540", VA = "0x1872F8940")]
		private void CPGMMCADPGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x72F85F0", Offset = "0x72F71F0", VA = "0x1872F85F0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer HKFOEGKIJPH, RenderingData LMNAFHEGHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xF71DD0", Offset = "0xF709D0", VA = "0x180F71DD0")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DJPKAJADPEN
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x72F4D10", Offset = "0x72F3910", VA = "0x1872F4D10")]
	public static int PCKOKDMBDDB(bool LMNCGBLAFCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x13D7CF0", Offset = "0x13D68F0", VA = "0x1813D7CF0")]
	public static int CLJGCAMLLLO(bool LMNCGBLAFCG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct JAFEDPNGKMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType CAGOHGFFHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float ECFKHFFKOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float KNJGLEAPDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float COEELKPAJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 BMFOJNAJCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 NJPOAGPCMPB;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct FFLMFEHOOOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort MGJAGICBANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float FJOFFDFNBKA;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct CKFMLJLPLBO : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<JAFEDPNGKMD> MHDNCNCEPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 JECHIGPFHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 FEADADHNGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, FFLMFEHOOOD>.ParallelWriter CBPFFCAAHIA;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x72F3DE0", Offset = "0x72F29E0", VA = "0x1872F3DE0", Slot = "4")]
	public void Execute(int MGJAGICBANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x72F49A0", Offset = "0x72F35A0", VA = "0x1872F49A0")]
	private void PFBIFKEOMLN(uint3 BEEAGKPCOIM, uint3 BPLNMHDHODM, ushort MGJAGICBANO, float3 HGPKPDKPFAE, float DOKJIIIFBMG, float CDGBBFPNHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x72F4320", Offset = "0x72F2F20", VA = "0x1872F4320")]
	private void FFOCFCBFPHD(uint3 BEEAGKPCOIM, uint3 BPLNMHDHODM, ushort MGJAGICBANO, float3 HGPKPDKPFAE, float3 MKDDKHCKFJE, float3 EDDNFLLAOME, float DOKJIIIFBMG, float GALOKJJMELC, float CDGBBFPNHAP, float BFFLOMMMMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x72F47F0", Offset = "0x72F33F0", VA = "0x1872F47F0")]
	private float3 HENGOFKEMPM(uint3 BEEAGKPCOIM, float3 HGPKPDKPFAE)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x72F47D0", Offset = "0x72F33D0", VA = "0x1872F47D0")]
	private float FNGGLCACPPK(float ECFKHFFKOGC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x72F48E0", Offset = "0x72F34E0", VA = "0x1872F48E0")]
	private float JFMEMFBONPC(float3 EGDKENFHLKD, float3 EDDNFLLAOME, float GALOKJJMELC, float CDGBBFPNHAP)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct EJOAOMCIPAG : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, FFLMFEHOOOD> CBPFFCAAHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint KLNNHGNJPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int ODPCDJLNAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int ONLOLBKFFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> GFDPLFFLCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> EFAOILNFPLO;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x72F5340", Offset = "0x72F3F40", VA = "0x1872F5340", Slot = "4")]
	public void Execute(int JHJEBHKOHLN, int CAIHJBKDDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x72F51D0", Offset = "0x72F3DD0", VA = "0x1872F51D0")]
	private void CILHJGDGPAA(int OOEBODHCKKO, ushort ACBOCPBCJKN, int LECHJHPFJFB, FFLMFEHOOOD GMDNOBBNFND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct LBDDOMAIFIL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, FFLMFEHOOOD> CBPFFCAAHIA;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x72F7CB0", Offset = "0x72F68B0", VA = "0x1872F7CB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KAFAMADCFCI : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool KOAFPGMFKKE;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float KAKIAJGNGMJ = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int OCGEFBJIFIJ = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int FCDOLCGHCKK = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private CKFMLJLPLBO FJIOLMFEFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private EJOAOMCIPAG PAHDDHHHOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private LBDDOMAIFIL DBGKBKLBHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, FFLMFEHOOOD> JGNEELPJBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private FKLFOIECLGK JGIADJPJBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool DFJLNDJCBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int LIKFNNCFHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<JAFEDPNGKMD> GFCLEHKAKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle EGIMGJIFFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle OPFDDGGDKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool NMOLCHEJDLO;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x72F7B80", Offset = "0x72F6780", VA = "0x1872F7B80")]
	public KAFAMADCFCI(RenderPassEvent LGPIICDBGBB, ComputeShader BHJBLMBJGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x72F74C0", Offset = "0x72F60C0", VA = "0x1872F74C0")]
	private void MBLLOILDHCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x72F78A0", Offset = "0x72F64A0", VA = "0x1872F78A0")]
	public void OPDKPBPPBGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2EC2690", Offset = "0x2EC1290", VA = "0x182EC2690")]
	public static void GLIGDFKECAN<T>(NativeArray<T> BFDOCKABCPN, int OLKJNOHMJPI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x72F7120", Offset = "0x72F5D20", VA = "0x1872F7120")]
	public void LEMOMFEDAOP(CameraData JGPIOACDIBA, LightData GFLEMCMLGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x72F7530", Offset = "0x72F6130", VA = "0x1872F7530")]
	private void NHOIOEAFKCJ(LightData GFLEMCMLGAC, NativeArray<JAFEDPNGKMD> MJLJPGHNOPA, int LGMLMEPOOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x72F6CC0", Offset = "0x72F58C0", VA = "0x1872F6CC0")]
	private void CCDPJMCNKOI(CameraData JGPIOACDIBA, LightData GFLEMCMLGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x72F79B0", Offset = "0x72F65B0", VA = "0x1872F79B0")]
	private void PFIGBKAKPCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x72F7020", Offset = "0x72F5C20", VA = "0x1872F7020")]
	private void GMHLMAEGPAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x72F6F00", Offset = "0x72F5B00", VA = "0x1872F6F00")]
	private void CNBFMELDLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x72F7870", Offset = "0x72F6470", VA = "0x1872F7870")]
	private void OPBFJPGHJJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x72F6F20", Offset = "0x72F5B20", VA = "0x1872F6F20", Slot = "9")]
	public override void Execute(ScriptableRenderContext PDMONEGPHPK, RenderingData LMNAFHEGHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x72F7980", Offset = "0x72F6580", VA = "0x1872F7980", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer EKFBBEMKDNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class OPOGPHLOPGL : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort FEPDFPKDOJG = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float KAKIAJGNGMJ = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly FKLFOIECLGK JGIADJPJBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int NLAHHLKALIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private JAFEDPNGKMD[] GFCLEHKAKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 PAALBFEMKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 DPJDACHMGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint GBLKKIBHOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int CAOOPCILJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int EDNECAPNIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> GFDPLFFLCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> EFAOILNFPLO;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x72FCBC0", Offset = "0x72FB7C0", VA = "0x1872FCBC0")]
	public OPOGPHLOPGL(RenderPassEvent LGPIICDBGBB, ComputeShader BHJBLMBJGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x72FC1F0", Offset = "0x72FADF0", VA = "0x1872FC1F0")]
	public void LEMOMFEDAOP(CameraData JGPIOACDIBA, LightData GFLEMCMLGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x72FBD90", Offset = "0x72FA990", VA = "0x1872FBD90")]
	private void GBMBIIGMJCJ(CameraData JGPIOACDIBA, LightData GFLEMCMLGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x72FC760", Offset = "0x72FB360", VA = "0x1872FC760")]
	public void OPDKPBPPBGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x72FC410", Offset = "0x72FB010", VA = "0x1872FC410")]
	private void NHOIOEAFKCJ(LightData GFLEMCMLGAC, JAFEDPNGKMD[] MJLJPGHNOPA, int LGMLMEPOOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x72FC360", Offset = "0x72FAF60", VA = "0x1872FC360")]
	private void MICBDFNAGJO(int JHJEBHKOHLN, int CAIHJBKDDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x72FC150", Offset = "0x72FAD50", VA = "0x1872FC150")]
	private void IHBPJOAJPID(int JHJEBHKOHLN, int KNHHBEFLJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x72FB080", Offset = "0x72F9C80", VA = "0x1872FB080")]
	private ushort EDMFACAHDJG(int JHJEBHKOHLN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x72FAE80", Offset = "0x72F9A80", VA = "0x1872FAE80")]
	private void BIMDJNDNIPP(int JHJEBHKOHLN, int CAIHJBKDDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x72FC180", Offset = "0x72FAD80", VA = "0x1872FC180")]
	private void IPCNMMGJAEM(int OLKJNOHMJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x72FBF90", Offset = "0x72FAB90", VA = "0x1872FBF90")]
	private void GGFKMAFEJHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x72FB670", Offset = "0x72FA270", VA = "0x1872FB670", Slot = "9")]
	public override void Execute(ScriptableRenderContext PDMONEGPHPK, RenderingData LMNAFHEGHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x72FC780", Offset = "0x72FB380", VA = "0x1872FC780", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer EKFBBEMKDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x72FB0C0", Offset = "0x72F9CC0", VA = "0x1872FB0C0")]
	private void ELAEKDKKNMA(int MGJAGICBANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x72FC7B0", Offset = "0x72FB3B0", VA = "0x1872FC7B0")]
	private void PFBIFKEOMLN(uint3 BEEAGKPCOIM, uint3 BPLNMHDHODM, ushort MGJAGICBANO, float3 HGPKPDKPFAE, float DOKJIIIFBMG, float CDGBBFPNHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x72FB750", Offset = "0x72FA350", VA = "0x1872FB750")]
	private void FFOCFCBFPHD(uint3 BEEAGKPCOIM, uint3 BPLNMHDHODM, ushort MGJAGICBANO, float3 HGPKPDKPFAE, float3 MKDDKHCKFJE, float3 EDDNFLLAOME, float DOKJIIIFBMG, float GALOKJJMELC, float CDGBBFPNHAP, float BFFLOMMMMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x72FBCA0", Offset = "0x72FA8A0", VA = "0x1872FBCA0")]
	private void FIKPKJIFHNE(ushort MGJAGICBANO, uint AJHKDGKFBLE, float BKJIIBDFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x72FC050", Offset = "0x72FAC50", VA = "0x1872FC050")]
	private float3 HENGOFKEMPM(uint3 BEEAGKPCOIM, float3 HGPKPDKPFAE)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x72F47D0", Offset = "0x72F33D0", VA = "0x1872F47D0")]
	private float FNGGLCACPPK(float ECFKHFFKOGC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x72F48E0", Offset = "0x72F34E0", VA = "0x1872F48E0")]
	private float JFMEMFBONPC(float3 EGDKENFHLKD, float3 EDDNFLLAOME, float GALOKJJMELC, float CDGBBFPNHAP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x72FAEF0", Offset = "0x72F9AF0", VA = "0x1872FAEF0")]
	private void CILHJGDGPAA(int OOEBODHCKKO, ushort ACBOCPBCJKN, int LECHJHPFJFB, FFLMFEHOOOD GMDNOBBNFND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FKLFOIECLGK
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class PJMNMJPMMMH
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int MOJBJNEGALI;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int JNEBMKMELII;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int HBKNDFNPPOL;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int MPBCDNELJBF;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int MCHOMALGHHP;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int COIGBGMMFKO;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int FIIOFICBAAG;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int LFHBDDGDKIJ = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int FHNHOHDAMKL = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int CCCPHGCLHPA = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int FNHCBKLEKPH = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int FANECEFCEKJ = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int AFNLADGDCAO = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int BAMNBIFJDEC = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool ANBDCLOLPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer IKBJCHJCNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture ACGEBLOFGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int OKDLKKLJABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int BLPBGEGFBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int OJOOKAFEOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int NALNCMLODPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int LONJFFMBJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader BPODAGMJABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int EHLPADMPFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int DHGJBILDPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 POBIMALDFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 KHKLNPLNLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> KEPIDONEENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> KPIMOFCFNCP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> GBGAOOHGPJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x123ACB0", Offset = "0x12398B0", VA = "0x18123ACB0")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> DKMEEKGDPPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x165B1E0", Offset = "0x1659DE0", VA = "0x18165B1E0")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int JDMDKBKCBPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xADFAB0", Offset = "0xADE6B0", VA = "0x180ADFAB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int AHDHCFFGKAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x887AC0", Offset = "0x8866C0", VA = "0x180887AC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader HBBCAGOBNLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x72F5950", Offset = "0x72F4550", VA = "0x1872F5950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x72F59E0", Offset = "0x72F45E0", VA = "0x1872F59E0")]
	public void ICJAGPEAKJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x72F6080", Offset = "0x72F4C80", VA = "0x1872F6080")]
	public void PFLMMCFCGEP(CameraData JGPIOACDIBA, LightData GFLEMCMLGAC, int EHMCBAEFODB, bool LMNCGBLAFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2DED590", Offset = "0x2DEC190", VA = "0x182DED590")]
	private void GLIGDFKECAN<T>(NativeArray<T> BFDOCKABCPN, int OLKJNOHMJPI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x72F5CB0", Offset = "0x72F48B0", VA = "0x1872F5CB0")]
	public void JIOBFEDHJLN(CommandBuffer EKFBBEMKDNF, ScriptableRenderContext PDMONEGPHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x72F5770", Offset = "0x72F4370", VA = "0x1872F5770")]
	private static void DMNOJJEIAGL(int NCCOKCHANKL, CommandBuffer EKFBBEMKDNF, RenderBuffer KHFJMLONFCD, ComputeBuffer MMMPPIOAMEE, ComputeShader CAFJGAIFHAI, int CMMJGKNPCKD, int NGNDNFLMLOM, int CMPLPOOJBIH, int KMOFBJKDDOJ, int MCICAPGIMIG, int HFACLCNOHKF, int JIAIMHGHEEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x72F6390", Offset = "0x72F4F90", VA = "0x1872F6390")]
	public void PJFPCLGACIG(CommandBuffer EKFBBEMKDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x72F5AD0", Offset = "0x72F46D0", VA = "0x1872F5AD0")]
	private RenderTexture IPAGEKHNHOJ(RenderTexture DAJFCGCAPMN, int CMMJGKNPCKD, int NGNDNFLMLOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x72F6000", Offset = "0x72F4C00", VA = "0x1872F6000")]
	public void PDEBFALHOEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x72F54E0", Offset = "0x72F40E0", VA = "0x1872F54E0")]
	public void COBJBCHJEKO(int AHDFLEHIPJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x72F66A0", Offset = "0x72F52A0", VA = "0x1872F66A0")]
	public FKLFOIECLGK()
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
		public struct HHBADLEMICK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float LONLNFGBDPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float PLIJCFONPCB;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class ECIAILLFHKO : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string ELDHCCKCAHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler OFOAGOEGLBI;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int DCJNPOKNNKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material COOLMCDKHPA;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x72F50F0", Offset = "0x72F3CF0", VA = "0x1872F50F0")]
			public ECIAILLFHKO(RenderPassEvent LGPIICDBGBB, Material OFCNJEFMNEM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x72F4D20", Offset = "0x72F3920", VA = "0x1872F4D20", Slot = "9")]
			public override void Execute(ScriptableRenderContext PDMONEGPHPK, RenderingData LMNAFHEGHMA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static HHBADLEMICK CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private ECIAILLFHKO m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x72F93B0", Offset = "0x72F7FB0", VA = "0x1872F93B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x72F9360", Offset = "0x72F7F60", VA = "0x1872F9360")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x72F91B0", Offset = "0x72F7DB0", VA = "0x1872F91B0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x72F90E0", Offset = "0x72F7CE0", VA = "0x1872F90E0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer HKFOEGKIJPH, RenderingData LMNAFHEGHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xF71DD0", Offset = "0xF709D0", VA = "0x180F71DD0")]
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
		public struct OPEANENFMGJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float DIDLBNHMCCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color NONHDHKEGGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh LCKOECGBHHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve HHPGNBHDHDN;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class BBMGFIGFHPH : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string ELDHCCKCAHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler OFOAGOEGLBI;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int KHPDOGCDIOB;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int HJPCJICICHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material COOLMCDKHPA;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x72F3C70", Offset = "0x72F2870", VA = "0x1872F3C70")]
			public BBMGFIGFHPH(RenderPassEvent LGPIICDBGBB, Material OFCNJEFMNEM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x72F39D0", Offset = "0x72F25D0", VA = "0x1872F39D0", Slot = "9")]
			public override void Execute(ScriptableRenderContext PDMONEGPHPK, RenderingData LMNAFHEGHMA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static OPEANENFMGJ CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private BBMGFIGFHPH m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x72F96C0", Offset = "0x72F82C0", VA = "0x1872F96C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x72F9510", Offset = "0x72F8110", VA = "0x1872F9510", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x72F9400", Offset = "0x72F8000", VA = "0x1872F9400", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer HKFOEGKIJPH, RenderingData LMNAFHEGHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xF71DD0", Offset = "0xF709D0", VA = "0x180F71DD0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string FHJNCHIMELC
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool JMFNPGLCPPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer EKFBBEMKDNF, ScriptableRenderContext PDMONEGPHPK, RenderingData LMNAFHEGHMA);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x88A130", Offset = "0x888D30", VA = "0x18088A130")]
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
		private class NPFKILFAAJL : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool HPHGNFHPACJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> BHIOPCFNKDK;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> MHBFIAHEOCA;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x72F9D30", Offset = "0x72F8930", VA = "0x1872F9D30")]
			public NPFKILFAAJL(RenderPassEvent LGPIICDBGBB, bool HPHGNFHPACJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x72F98E0", Offset = "0x72F84E0", VA = "0x1872F98E0")]
			public bool JICAJABEHFI(CameraData JGPIOACDIBA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x72F9710", Offset = "0x72F8310", VA = "0x1872F9710", Slot = "9")]
			public override void Execute(ScriptableRenderContext PDMONEGPHPK, RenderingData LMNAFHEGHMA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x72F9BC0", Offset = "0x72F87C0", VA = "0x1872F9BC0")]
			private void OLDPNACMLMO(PerCameraRenderEffect MGPAOLKHIDF, ScriptableRenderContext PDMONEGPHPK, RenderingData LMNAFHEGHMA)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private NPFKILFAAJL m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private NPFKILFAAJL m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x72FCE40", Offset = "0x72FBA40", VA = "0x1872FCE40", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x72FCDB0", Offset = "0x72FB9B0", VA = "0x1872FCDB0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer HKFOEGKIJPH, RenderingData LMNAFHEGHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xF71DD0", Offset = "0xF709D0", VA = "0x180F71DD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72FD090", Offset = "0x72FBC90", VA = "0x1872FD090")]
		public static void IPABELDPGFH(ScriptableRenderPass EPGDHIEHKEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x72FCEF0", Offset = "0x72FBAF0", VA = "0x1872FCEF0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer HKFOEGKIJPH, RenderingData LMNAFHEGHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xF71DD0", Offset = "0xF709D0", VA = "0x180F71DD0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class OAACPMFIDEI
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 CIBHPFBGHJM;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 CMGNIGKONJP;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 PGLPCBGIGDE;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 LLFPHKJJNFH;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 HCAPEDNBCAI;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x72FA640", Offset = "0x72F9240", VA = "0x1872FA640")]
	public static uint FIGEJIPEKGP(uint MBJABMPNEHF, uint MNMGCDILGBO, uint FIMFCCOMLAB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x72F9F80", Offset = "0x72F8B80", VA = "0x1872F9F80")]
	public static uint3 BODNHPOAECE(float3 GKJAMFFKDLE, float3 JECHIGPFHDE, float3 FEADADHNGPL)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x72FA650", Offset = "0x72F9250", VA = "0x1872FA650")]
	public static void NAPGNAGPLDI(float3 NFLGLLODHOK, float3 NNJLOFBHNCE, float3 KPJHCNGBGHJ, float JLDCCBFCJGC, [Out] uint3 GLIDOALEBME, [Out] uint3 KLCHBDEPOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x72FA170", Offset = "0x72F8D70", VA = "0x1872FA170")]
	public static void DNEHMCFOPMG(float3 COKACAPKBJN, float3 GBGOKLIGIMN, float KNJGLEAPDIO, float HGMJCJNOBJH, [Out] float3 PHHIFEMAANE, [Out] float JLDCCBFCJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x72F9DE0", Offset = "0x72F89E0", VA = "0x1872F9DE0")]
	private static float3 BGIGKAGMGME(float3 OOIGIHPDGPM, float3 HKDKFOFKAMM, float3 LEHCKDBNPFF, float3 HGKHHBOGNIM)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class AGIEJLDLIJJ
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly BNHLDIHMNLF CHBLMKCFHCN;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly BNHLDIHMNLF OMLAIBDEFOL;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly BNHLDIHMNLF GJKHPFOCNDB;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly BNHLDIHMNLF AIEPLPNBABF;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly BNHLDIHMNLF IPABFOEMEEM;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class LFDDOOCEGKJ
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh PGLELGJKFLO;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x72F8550", Offset = "0x72F7150", VA = "0x1872F8550")]
	public static Mesh LDFEANCOHBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x72F7CF0", Offset = "0x72F68F0", VA = "0x1872F7CF0")]
	public static Matrix4x4 GGGHEHPKBNH(Camera FDEJBGLBHHB, bool IDEFCJFCHGM = false, bool PKFHMOKCJAM = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x72F8190", Offset = "0x72F6D90", VA = "0x1872F8190")]
	private static Mesh KELEECNOEAL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__380489689
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x72FE4D0", Offset = "0x72FD0D0", VA = "0x1872FE4D0")]
	public static void GENFCPCECLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x72FE4C0", Offset = "0x72FD0C0", VA = "0x1872FE4C0")]
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
