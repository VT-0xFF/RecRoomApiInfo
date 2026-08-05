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
	public class LogRegistrationIndex : PNJEOLJBAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7F76C30", Offset = "0x7F76030", VA = "0x187F76C30", Slot = "4")]
		public override void ELBDPICAHPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
		public enum PEFAPGMPGJG
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface LDOKFOLGBEO
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void MKBKFOOCCNJ(ScriptableRenderContext PFPNPMCGHHC, List<Camera> GJEADHENHAJ);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface CMKCJKFGPJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void MKBKFOOCCNJ(ScriptableRenderContext PFPNPMCGHHC, RenderingData CABKJGPKBNN);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class MBGIFBBNMHK : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7F76D20", Offset = "0x7F76120", VA = "0x187F76D20")]
			public MBGIFBBNMHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7F76CC0", Offset = "0x7F760C0", VA = "0x187F76CC0", Slot = "9")]
			public override void Execute(ScriptableRenderContext PFPNPMCGHHC, RenderingData CABKJGPKBNN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private MBGIFBBNMHK _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<LDOKFOLGBEO> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<LDOKFOLGBEO> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<CMKCJKFGPJM> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<CMKCJKFGPJM> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7F79C70", Offset = "0x7F79070", VA = "0x187F79C70")]
		public static void FHNAJKMJLDH(PEFAPGMPGJG KIJJIIHAJML, LDOKFOLGBEO JPPLONDEKHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7F79DF0", Offset = "0x7F791F0", VA = "0x187F79DF0")]
		public static void KENFKIHGCDA(PEFAPGMPGJG KIJJIIHAJML, LDOKFOLGBEO JPPLONDEKHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7F79BB0", Offset = "0x7F78FB0", VA = "0x187F79BB0")]
		public static void FHNAJKMJLDH(PEFAPGMPGJG KIJJIIHAJML, CMKCJKFGPJM BKFCANDJPHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7F79D30", Offset = "0x7F79130", VA = "0x187F79D30")]
		public static void KENFKIHGCDA(PEFAPGMPGJG KIJJIIHAJML, CMKCJKFGPJM BKFCANDJPHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7F798C0", Offset = "0x7F78CC0", VA = "0x187F798C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7F797B0", Offset = "0x7F78BB0", VA = "0x187F797B0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MNIHJHLOJKH, RenderingData CABKJGPKBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7F79AA0", Offset = "0x7F78EA0", VA = "0x187F79AA0", Slot = "9")]
		protected override void Dispose(bool AJLIDIGCFDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7F7A370", Offset = "0x7F79770", VA = "0x187F7A370")]
		private static void PKIEFGIINEL(ScriptableRenderContext PFPNPMCGHHC, List<Camera> GJEADHENHAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7F79850", Offset = "0x7F78C50", VA = "0x187F79850")]
		private static void BEILIBONEJJ(ScriptableRenderContext PFPNPMCGHHC, List<Camera> GJEADHENHAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7F79EB0", Offset = "0x7F792B0", VA = "0x187F79EB0")]
		private static void MPCMKLCCBAH(ScriptableRenderContext PFPNPMCGHHC, RenderingData CABKJGPKBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x153A4E0", Offset = "0x15398E0", VA = "0x18153A4E0")]
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
		private class DNJADEOGFKP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool OHJODNJLKFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<CDBNMPLIBEN> BOCGPLJMICC;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7F71C20", Offset = "0x7F71020", VA = "0x187F71C20")]
			public DNJADEOGFKP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class DJOIJHIEDNE : PreRenderManager.CMKCJKFGPJM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string MEAOLDKEBAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler JPNEIMCHHDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly DNJADEOGFKP MLDPGBHDFKB;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7F71B60", Offset = "0x7F70F60", VA = "0x187F71B60")]
			public DJOIJHIEDNE(DNJADEOGFKP LOGPKBGGKPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7F71760", Offset = "0x7F70B60", VA = "0x187F71760", Slot = "4")]
			public void MKBKFOOCCNJ(ScriptableRenderContext PFPNPMCGHHC, RenderingData CABKJGPKBNN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class NABDEJKCCDL : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string IMALGJJPGLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly DNJADEOGFKP LOGPKBGGKPD;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7F77B30", Offset = "0x7F76F30", VA = "0x187F77B30")]
			public NABDEJKCCDL(RenderPassEvent LIJAPOOCIAO, DNJADEOGFKP LOGPKBGGKPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7F77820", Offset = "0x7F76C20", VA = "0x187F77820", Slot = "9")]
			public override void Execute(ScriptableRenderContext PFPNPMCGHHC, RenderingData CABKJGPKBNN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<CDBNMPLIBEN> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private DJOIJHIEDNE fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private NABDEJKCCDL fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private DNJADEOGFKP sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7F75040", Offset = "0x7F74440", VA = "0x187F75040", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7F753C0", Offset = "0x7F747C0", VA = "0x187F753C0", Slot = "9")]
		protected override void Dispose(bool AJLIDIGCFDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7F74FB0", Offset = "0x7F743B0", VA = "0x187F74FB0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MNIHJHLOJKH, RenderingData CABKJGPKBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x153A4E0", Offset = "0x15398E0", VA = "0x18153A4E0")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CDBNMPLIBEN
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LDCGLGMEFED(CommandBuffer KEHKEHAIEAC, Camera HJODJFKAMBL, [NotNull] UniversalAdditionalCameraData ALKFKOFDJNG, bool PADMGKFIAEH);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KMGMLAMDAEE(Camera HJODJFKAMBL, CommandBuffer BDHLLEGFLCA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class ADPKGJDMLNM
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool FKFJNBFEJKK;
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
		private FMNLFJOHEPD _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private DOEJIAPCPNG _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7F76910", Offset = "0x7F75D10", VA = "0x187F76910", Slot = "9")]
		protected override void Dispose(bool JJNLNHPPLOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7F76980", Offset = "0x7F75D80", VA = "0x187F76980")]
		private void GHOKFPHNKBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7F765C0", Offset = "0x7F759C0", VA = "0x187F765C0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MNIHJHLOJKH, RenderingData CABKJGPKBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x153A4E0", Offset = "0x15398E0", VA = "0x18153A4E0")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class AMDLHBPMADE
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7F6FE60", Offset = "0x7F6F260", VA = "0x187F6FE60")]
	public static int OKNBNLHEGPJ(bool MMNHBFJMNPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x19B5A90", Offset = "0x19B4E90", VA = "0x1819B5A90")]
	public static int GECCNPKEHDE(bool MMNHBFJMNPN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct JOFCHLHBFPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType LCFFLGKFBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float KNNJPLIJFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float IAJIOGCMJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float HBPPGEGPNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 ODKEFJOEPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 FABPEKOBEHL;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct GGEOILKPLHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort CGDJBINDNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float DJMLGHNDDGP;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct PONGNEJGOII : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<JOFCHLHBFPL> BKGEIKBFADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 AGEOOEIADAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 OMLLCKFMAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, GGEOILKPLHK>.ParallelWriter LHOPIKHAFKP;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7F78510", Offset = "0x7F77910", VA = "0x187F78510", Slot = "4")]
	public void Execute(int CGDJBINDNHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7F78F00", Offset = "0x7F78300", VA = "0x187F78F00")]
	private void FPHMGMMHHFC(uint3 ONFNFAMCFCM, uint3 KMKFDICEKGM, ushort CGDJBINDNHL, float3 AGGEBGCAJLM, float OKIHMDMLIBB, float AGPPHIKCMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7F78A50", Offset = "0x7F77E50", VA = "0x187F78A50")]
	private void FAJMHLIFMBP(uint3 ONFNFAMCFCM, uint3 KMKFDICEKGM, ushort CGDJBINDNHL, float3 AGGEBGCAJLM, float3 AOKLPKEEPFF, float3 DOHKKIBDAMK, float OKIHMDMLIBB, float CAIGAICHBMJ, float AGPPHIKCMNI, float JJKACHKIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7F79270", Offset = "0x7F78670", VA = "0x187F79270")]
	private float3 OPAGGEFEOGM(uint3 ONFNFAMCFCM, float3 AGGEBGCAJLM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7F73700", Offset = "0x7F72B00", VA = "0x187F73700")]
	private float OFJODFBDEHJ(float KNNJPLIJFGJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7F73640", Offset = "0x7F72A40", VA = "0x187F73640")]
	private float NAGDHAICPDP(float3 HPHIDGDAPFK, float3 DOHKKIBDAMK, float CAIGAICHBMJ, float AGPPHIKCMNI)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct KNBPLAHLMKP : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, GGEOILKPLHK> LHOPIKHAFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint MMANLDIMOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int DJAHEDKDMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int EHEOKFMHAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> CICKMALMOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> PLOLDEEDJMB;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7F762B0", Offset = "0x7F756B0", VA = "0x187F762B0", Slot = "4")]
	public void Execute(int JCPCBAEFNFI, int BJEJIGGIDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7F76450", Offset = "0x7F75850", VA = "0x187F76450")]
	private void OOOCJGIBIAJ(int NKLECKELNCN, ushort CMHMAMFFPPJ, int PGFFDIFLMGC, GGEOILKPLHK FAMBPJIICJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct COPNGJBMNNP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, GGEOILKPLHK> LHOPIKHAFKP;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7F71720", Offset = "0x7F70B20", VA = "0x187F71720", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FMNLFJOHEPD : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool KNIFFLOMFEH;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float BCIBJBEHKDF = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int EPOLNMNKJEN = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int IEDFMAHLNDB = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private PONGNEJGOII CMNNGKBMPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private KNBPLAHLMKP MPPNHLMJONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private COPNGJBMNNP PKIPKFOJDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, GGEOILKPLHK> ADEFKONNNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private BBIKNPJJPGA DJHOAMIPKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool CNONNFKBMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int HEFPNGFJAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<JOFCHLHBFPL> NMAFNMBPHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle BBNHLFKPBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle HENGFBFIKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool CJOJKKNMJNM;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7F74F00", Offset = "0x7F74300", VA = "0x187F74F00")]
	public FMNLFJOHEPD(RenderPassEvent LIJAPOOCIAO, ComputeShader MMFOADFDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7F74820", Offset = "0x7F73C20", VA = "0x187F74820")]
	private void HBBANPFCCNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7F74B50", Offset = "0x7F73F50", VA = "0x187F74B50")]
	public void LPFOHBKOIBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x35AE1F0", Offset = "0x35AD5F0", VA = "0x1835AE1F0")]
	public static void HOLGOEIOGLL<T>(NativeArray<T> KCPGIJAPEHH, int EOKAMHLPIFK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7F74380", Offset = "0x7F73780", VA = "0x187F74380")]
	public void DGGKBICBMNP(CameraData ALKFKOFDJNG, LightData DMLBEKFIHEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7F74040", Offset = "0x7F73440", VA = "0x187F74040")]
	private void BHHMDNDFFAB(LightData DMLBEKFIHEG, NativeArray<JOFCHLHBFPL> IFFAAFACNDH, int GMBKLIHBBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7F74C30", Offset = "0x7F74030", VA = "0x187F74C30")]
	private void MDKIMBMFIJL(CameraData ALKFKOFDJNG, LightData DMLBEKFIHEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7F749C0", Offset = "0x7F73DC0", VA = "0x187F749C0")]
	private void LEHCBGFOJIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7F74890", Offset = "0x7F73C90", VA = "0x187F74890")]
	private void IMFGMPGHKEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7F74EA0", Offset = "0x7F742A0", VA = "0x187F74EA0")]
	private void PKOKAJGCEDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7F74990", Offset = "0x7F73D90", VA = "0x187F74990")]
	private void JNPEDCLPMLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7F74720", Offset = "0x7F73B20", VA = "0x187F74720", Slot = "9")]
	public override void Execute(ScriptableRenderContext PFPNPMCGHHC, RenderingData CABKJGPKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7F74E70", Offset = "0x7F74270", VA = "0x187F74E70", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer BDHLLEGFLCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DOEJIAPCPNG : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort LCIMCPLBEOA = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float BCIBJBEHKDF = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly BBIKNPJJPGA DJHOAMIPKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int DJBCJMMGOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private JOFCHLHBFPL[] NMAFNMBPHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 GJGLBLPLHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 JLGJHBDGNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint MPOFGHBPDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int BCKKCBIAGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int AIGHJHBDBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> CICKMALMOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> PLOLDEEDJMB;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7F73AD0", Offset = "0x7F72ED0", VA = "0x187F73AD0")]
	public DOEJIAPCPNG(RenderPassEvent LIJAPOOCIAO, ComputeShader MMFOADFDABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7F72030", Offset = "0x7F71430", VA = "0x187F72030")]
	public void DGGKBICBMNP(CameraData ALKFKOFDJNG, LightData DMLBEKFIHEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7F73420", Offset = "0x7F72820", VA = "0x187F73420")]
	private void LKPCFFMPBAJ(CameraData ALKFKOFDJNG, LightData DMLBEKFIHEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7F73620", Offset = "0x7F72A20", VA = "0x187F73620")]
	public void LPFOHBKOIBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7F71CB0", Offset = "0x7F710B0", VA = "0x187F71CB0")]
	private void BHHMDNDFFAB(LightData DMLBEKFIHEG, JOFCHLHBFPL[] IFFAAFACNDH, int GMBKLIHBBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7F73370", Offset = "0x7F72770", VA = "0x187F73370")]
	private void KPLJODDEMDC(int JCPCBAEFNFI, int BJEJIGGIDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7F72000", Offset = "0x7F71400", VA = "0x187F72000")]
	private void CHHFOJIABBK(int JCPCBAEFNFI, int PPLOBPJCNII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7F72D80", Offset = "0x7F72180", VA = "0x187F72D80")]
	private ushort HNNJBDPFCEJ(int JCPCBAEFNFI)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7F72D10", Offset = "0x7F72110", VA = "0x187F72D10")]
	private void HKPICKCFPBJ(int JCPCBAEFNFI, int BJEJIGGIDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7F72CA0", Offset = "0x7F720A0", VA = "0x187F72CA0")]
	private void GENFLGPCCOI(int EOKAMHLPIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7F721A0", Offset = "0x7F715A0", VA = "0x187F721A0")]
	private void DJIKDEPNDBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7F72260", Offset = "0x7F71660", VA = "0x187F72260", Slot = "9")]
	public override void Execute(ScriptableRenderContext PFPNPMCGHHC, RenderingData CABKJGPKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7F73AA0", Offset = "0x7F72EA0", VA = "0x187F73AA0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer BDHLLEGFLCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7F72DC0", Offset = "0x7F721C0", VA = "0x187F72DC0")]
	private void JABKHIGDNEN(int CGDJBINDNHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7F72890", Offset = "0x7F71C90", VA = "0x187F72890")]
	private void FPHMGMMHHFC(uint3 ONFNFAMCFCM, uint3 KMKFDICEKGM, ushort CGDJBINDNHL, float3 AGGEBGCAJLM, float OKIHMDMLIBB, float AGPPHIKCMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7F72340", Offset = "0x7F71740", VA = "0x187F72340")]
	private void FAJMHLIFMBP(uint3 ONFNFAMCFCM, uint3 KMKFDICEKGM, ushort CGDJBINDNHL, float3 AGGEBGCAJLM, float3 AOKLPKEEPFF, float3 DOHKKIBDAMK, float OKIHMDMLIBB, float CAIGAICHBMJ, float AGPPHIKCMNI, float JJKACHKIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7F73720", Offset = "0x7F72B20", VA = "0x187F73720")]
	private void OGFKAGFEDPJ(ushort CGDJBINDNHL, uint BPOJIHNDJOE, float GFKPPAOLHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7F739A0", Offset = "0x7F72DA0", VA = "0x187F739A0")]
	private float3 OPAGGEFEOGM(uint3 ONFNFAMCFCM, float3 AGGEBGCAJLM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7F73700", Offset = "0x7F72B00", VA = "0x187F73700")]
	private float OFJODFBDEHJ(float KNNJPLIJFGJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7F73640", Offset = "0x7F72A40", VA = "0x187F73640")]
	private float NAGDHAICPDP(float3 HPHIDGDAPFK, float3 DOHKKIBDAMK, float CAIGAICHBMJ, float AGPPHIKCMNI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7F73810", Offset = "0x7F72C10", VA = "0x187F73810")]
	private void OOOCJGIBIAJ(int NKLECKELNCN, ushort CMHMAMFFPPJ, int PGFFDIFLMGC, GGEOILKPLHK FAMBPJIICJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class BBIKNPJJPGA
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class EIIEHIBMDAM
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int OGLJHPLCJPA;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int LIHENBKMDLE;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int FKOJPBFHOBD;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int GCDHNHJIHAO;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int FCONMBPPPAD;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int IDEHAACLLGL;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int HPIAAGFJJNN;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int IMOJEPBGGOC = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int CJOMMEKOPCF = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int CJAGFOKOHFA = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int IOGIMLKKEIM = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int KCIHNNGCABP = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int HJLFHANAKPD = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int DHFDCBLBDCB = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool MAEILCOHBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer FKIGAEHKPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture BMKIKEMHBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int DBFECOHHDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int IBHDNHKJKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int CPNKHDFIIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int DBMANIDOALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int MNOIHMNJGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader JCDJPMBAAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int LIPJKJKFOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int IKAMOJFDNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 GOAALDDBBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 FKNEAHFLFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> OJKMAJEDOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> GPGNNKDPJEI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> HGMNDLKPKMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4C95930", Offset = "0x4C94D30", VA = "0x184C95930")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> HGNCHLBFJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1057690", Offset = "0x1056A90", VA = "0x181057690")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int JHNNOGGGLNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xBB54C0", Offset = "0xBB48C0", VA = "0x180BB54C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int AKCCBBBDCPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x992560", Offset = "0x991960", VA = "0x180992560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader JHLCNPFBALL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7F71670", Offset = "0x7F70A70", VA = "0x187F71670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7F71050", Offset = "0x7F70450", VA = "0x187F71050")]
	public void JNOHBLLEJCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7F70D40", Offset = "0x7F70140", VA = "0x187F70D40")]
	public void JFIPLLBOBNH(CameraData ALKFKOFDJNG, LightData DMLBEKFIHEG, int PEJCKCIEGHN, bool MMNHBFJMNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3359D80", Offset = "0x3359180", VA = "0x183359D80")]
	private void HOLGOEIOGLL<T>(NativeArray<T> KCPGIJAPEHH, int EOKAMHLPIFK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7F71320", Offset = "0x7F70720", VA = "0x187F71320")]
	public void OFHHNHCOGJO(CommandBuffer BDHLLEGFLCA, ScriptableRenderContext PFPNPMCGHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7F70540", Offset = "0x7F6F940", VA = "0x187F70540")]
	private static void ADNBKILLENE(int ILICINOGJGI, CommandBuffer BDHLLEGFLCA, RenderBuffer HFKHJDABADD, ComputeBuffer LJFMGEJHIBA, ComputeShader PAGACAAKBBA, int GJDMPFEOIEA, int CBGBDGHLJKB, int HPLBFFHNKFC, int JKMHHLDFBOL, int NLKDHJJAIGP, int CIPFDDGAODB, int KFEMLKBKLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7F707A0", Offset = "0x7F6FBA0", VA = "0x187F707A0")]
	public void DJGEBDIIAFO(CommandBuffer BDHLLEGFLCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7F71140", Offset = "0x7F70540", VA = "0x187F71140")]
	private RenderTexture KLEHCCOHDFO(RenderTexture NIFFDOJPPFD, int GJDMPFEOIEA, int CBGBDGHLJKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7F70720", Offset = "0x7F6FB20", VA = "0x187F70720")]
	public void ALPFBBFJALH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7F70AB0", Offset = "0x7F6FEB0", VA = "0x187F70AB0")]
	public void GHFFKAPNNMP(int GIMAFNIKIMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7F71700", Offset = "0x7F70B00", VA = "0x187F71700")]
	public BBIKNPJJPGA()
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
		public struct OHHCOOLBOLD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float ILKKKLMBNCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float KJCGDKFMCFH;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class MIJFMBKOJKH : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string BJOCKLJJLDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler LHNIAOHICBM;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int KALADLMFHND;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material PNNMDAKOOHI;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7F77110", Offset = "0x7F76510", VA = "0x187F77110")]
			public MIJFMBKOJKH(RenderPassEvent LIJAPOOCIAO, Material KIEAKCEGOFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7F76D40", Offset = "0x7F76140", VA = "0x187F76D40", Slot = "9")]
			public override void Execute(ScriptableRenderContext PFPNPMCGHHC, RenderingData CABKJGPKBNN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static OHHCOOLBOLD CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private MIJFMBKOJKH m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x7F774C0", Offset = "0x7F768C0", VA = "0x187F774C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7F77470", Offset = "0x7F76870", VA = "0x187F77470")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7F772C0", Offset = "0x7F766C0", VA = "0x187F772C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7F771F0", Offset = "0x7F765F0", VA = "0x187F771F0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MNIHJHLOJKH, RenderingData CABKJGPKBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x153A4E0", Offset = "0x15398E0", VA = "0x18153A4E0")]
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
		public struct DHDLLNNKBPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float HAPFDNBMINP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color MCMDGPIHLMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh JGCNHDLFCFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve JOEKFMEKIIE;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class EJKBOMEFKOP : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string BJOCKLJJLDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler LHNIAOHICBM;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int MOINEPLANEK;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int HPCBFCMCDOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material PNNMDAKOOHI;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7F73F60", Offset = "0x7F73360", VA = "0x187F73F60")]
			public EJKBOMEFKOP(RenderPassEvent LIJAPOOCIAO, Material KIEAKCEGOFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7F73CC0", Offset = "0x7F730C0", VA = "0x187F73CC0", Slot = "9")]
			public override void Execute(ScriptableRenderContext PFPNPMCGHHC, RenderingData CABKJGPKBNN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static DHDLLNNKBPL CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private EJKBOMEFKOP m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x7F777D0", Offset = "0x7F76BD0", VA = "0x187F777D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7F77620", Offset = "0x7F76A20", VA = "0x187F77620", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7F77510", Offset = "0x7F76910", VA = "0x187F77510", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MNIHJHLOJKH, RenderingData CABKJGPKBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x153A4E0", Offset = "0x15398E0", VA = "0x18153A4E0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string AJBOBHFKIOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool CEJPBJHIMFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer BDHLLEGFLCA, ScriptableRenderContext PFPNPMCGHHC, RenderingData CABKJGPKBNN);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
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
		private class ANAKAALIFLK : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool GMPJGAEFILL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> EDKJDPOAEFF;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> DGIIIFLKNFC;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7F70490", Offset = "0x7F6F890", VA = "0x187F70490")]
			public ANAKAALIFLK(RenderPassEvent LIJAPOOCIAO, bool GMPJGAEFILL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7F6FE70", Offset = "0x7F6F270", VA = "0x187F6FE70")]
			public bool EOIGNCBPFDD(CameraData ALKFKOFDJNG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7F70150", Offset = "0x7F6F550", VA = "0x187F70150", Slot = "9")]
			public override void Execute(ScriptableRenderContext PFPNPMCGHHC, RenderingData CABKJGPKBNN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7F70320", Offset = "0x7F6F720", VA = "0x187F70320")]
			private void FJENALMGHID(PerCameraRenderEffect DLAHJNFEDNI, ScriptableRenderContext PFPNPMCGHHC, RenderingData CABKJGPKBNN)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private ANAKAALIFLK m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private ANAKAALIFLK m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7F793F0", Offset = "0x7F787F0", VA = "0x187F793F0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7F79360", Offset = "0x7F78760", VA = "0x187F79360", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MNIHJHLOJKH, RenderingData CABKJGPKBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x153A4E0", Offset = "0x15398E0", VA = "0x18153A4E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F79640", Offset = "0x7F78A40", VA = "0x187F79640")]
		public static void IDANAHENFIP(ScriptableRenderPass EDNGBLAHOCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7F794A0", Offset = "0x7F788A0", VA = "0x187F794A0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MNIHJHLOJKH, RenderingData CABKJGPKBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x153A4E0", Offset = "0x15398E0", VA = "0x18153A4E0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class JBMBLMMPPIJ
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 LFBOIKNBOGM;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 KGCENCNJEOD;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 FKIICBEAAEN;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 JDBBPFFOAGJ;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 LLEEAPACGLN;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7F75B00", Offset = "0x7F74F00", VA = "0x187F75B00")]
	public static uint HEMHCIMPAIH(uint JFJPEDLJOKC, uint MJINJIJLGDP, uint PCPOJEKHENA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7F75910", Offset = "0x7F74D10", VA = "0x187F75910")]
	public static uint3 FBPNGBGJPMM(float3 JPKKPDPLAGA, float3 AGEOOEIADAN, float3 OMLLCKFMAHN)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7F756D0", Offset = "0x7F74AD0", VA = "0x187F756D0")]
	public static void BOGDICMBMML(float3 GNNPNFBDAKK, float3 OAOIEKHIDEH, float3 BLLDPKFKAEK, float MCIPFGHOGIP, [Out] uint3 PGMBIFEKFAA, [Out] uint3 OFHEAJJLMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7F75CB0", Offset = "0x7F750B0", VA = "0x187F75CB0")]
	public static void NFCMEKHDHPF(float3 IHOOCPLMFNJ, float3 EAFFNCNDPGB, float IAJIOGCMJAG, float LBLCFAIMKLB, [Out] float3 DHDLAJGGBDP, [Out] float MCIPFGHOGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7F75B10", Offset = "0x7F74F10", VA = "0x187F75B10")]
	private static float3 HNJLEMPGPLB(float3 ADNONBAKIAA, float3 OACOPPHKFAA, float3 CKIMFBHNOKH, float3 PIDJABGNBBA)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class GAJMNMHGDBN
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly ABDDJEPKCOD AELOEGAHJCB;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly ABDDJEPKCOD CLFFKMDLAID;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly ABDDJEPKCOD HNDHACLDNOM;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly ABDDJEPKCOD PBDEMJOILLK;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly ABDDJEPKCOD EHFOFIBNCJD;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class PHELMFNKPPN
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh NKLHBGALLEK;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7F780B0", Offset = "0x7F774B0", VA = "0x187F780B0")]
	public static Mesh OAIPGFLINFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7F77C10", Offset = "0x7F77010", VA = "0x187F77C10")]
	public static Matrix4x4 JEBGCFPDAPK(Camera HJODJFKAMBL, bool JIGGGKNNONL = false, bool FEDBHDEKFNK = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7F78150", Offset = "0x7F77550", VA = "0x187F78150")]
	private static Mesh PDFJNBBALHA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__1464263112
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7F7AA80", Offset = "0x7F79E80", VA = "0x187F7AA80")]
	public static void NLACCDPEEHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7F7AA70", Offset = "0x7F79E70", VA = "0x187F7AA70")]
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
