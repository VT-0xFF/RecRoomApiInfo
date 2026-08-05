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
	public class LogRegistrationIndex : IHAELNMODEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x844F200", Offset = "0x844E400", VA = "0x18844F200", Slot = "4")]
		public override void OOCHIMKFMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		public enum GDLPFOIDIHG
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface PGMIIOKFOBE
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void LKPFOCCLOAA(ScriptableRenderContext OPJOIGJBJKN, List<Camera> ILMNDABJLBE);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface ANJALCIFEDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void LKPFOCCLOAA(ScriptableRenderContext OPJOIGJBJKN, RenderingData OIHDNGPDHCH);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class CADKMDGNOFL : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x84480C0", Offset = "0x84472C0", VA = "0x1884480C0")]
			public CADKMDGNOFL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8448060", Offset = "0x8447260", VA = "0x188448060", Slot = "9")]
			public override void Execute(ScriptableRenderContext OPJOIGJBJKN, RenderingData OIHDNGPDHCH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private CADKMDGNOFL _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<PGMIIOKFOBE> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<PGMIIOKFOBE> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<ANJALCIFEDF> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<ANJALCIFEDF> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8451EC0", Offset = "0x84510C0", VA = "0x188451EC0")]
		public static void IHJDHGGFIGL(GDLPFOIDIHG HEODBPOGJFH, PGMIIOKFOBE OJBIMJNJGGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x84519E0", Offset = "0x8450BE0", VA = "0x1884519E0")]
		public static void CDOMMLDEANA(GDLPFOIDIHG HEODBPOGJFH, PGMIIOKFOBE OJBIMJNJGGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8451E00", Offset = "0x8451000", VA = "0x188451E00")]
		public static void IHJDHGGFIGL(GDLPFOIDIHG HEODBPOGJFH, ANJALCIFEDF GNGCKHLBOFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8451920", Offset = "0x8450B20", VA = "0x188451920")]
		public static void CDOMMLDEANA(GDLPFOIDIHG HEODBPOGJFH, ANJALCIFEDF GNGCKHLBOFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8451AA0", Offset = "0x8450CA0", VA = "0x188451AA0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8451880", Offset = "0x8450A80", VA = "0x188451880", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer JFBIEOOKIGH, RenderingData OIHDNGPDHCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8451C80", Offset = "0x8450E80", VA = "0x188451C80", Slot = "9")]
		protected override void Dispose(bool FGLACMFJBCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8451F80", Offset = "0x8451180", VA = "0x188451F80")]
		private static void JBFLAHBDCKJ(ScriptableRenderContext OPJOIGJBJKN, List<Camera> ILMNDABJLBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8451D90", Offset = "0x8450F90", VA = "0x188451D90")]
		private static void GKFNJEALBLH(ScriptableRenderContext OPJOIGJBJKN, List<Camera> ILMNDABJLBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8452460", Offset = "0x8451660", VA = "0x188452460")]
		private static void LOJJLJIAHEB(ScriptableRenderContext OPJOIGJBJKN, RenderingData OIHDNGPDHCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x16773F0", Offset = "0x16765F0", VA = "0x1816773F0")]
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
		private class GAGBIGGDOOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool FKCHDKGDHKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<BNNLMLOBJCM> PDJBAGEKNDM;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x844A400", Offset = "0x8449600", VA = "0x18844A400")]
			public GAGBIGGDOOG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class CEFJIIGLOPC : PreRenderManager.ANJALCIFEDF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string IGABFNHFFFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler OOMPDDCMNOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly GAGBIGGDOOG FMAJOMCNDGN;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x84484D0", Offset = "0x84476D0", VA = "0x1884484D0")]
			public CEFJIIGLOPC(GAGBIGGDOOG DPBJGGFFANB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x84480E0", Offset = "0x84472E0", VA = "0x1884480E0", Slot = "4")]
			public void LKPFOCCLOAA(ScriptableRenderContext OPJOIGJBJKN, RenderingData OIHDNGPDHCH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class HJMPGLKHMBF : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string AAIMAOMCFNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly GAGBIGGDOOG DPBJGGFFANB;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x844D050", Offset = "0x844C250", VA = "0x18844D050")]
			public HJMPGLKHMBF(RenderPassEvent ALOIKGNLFKN, GAGBIGGDOOG DPBJGGFFANB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x844CD40", Offset = "0x844BF40", VA = "0x18844CD40", Slot = "9")]
			public override void Execute(ScriptableRenderContext OPJOIGJBJKN, RenderingData OIHDNGPDHCH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<BNNLMLOBJCM> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private CEFJIIGLOPC fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private HJMPGLKHMBF fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private GAGBIGGDOOG sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8449E90", Offset = "0x8449090", VA = "0x188449E90", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x844A210", Offset = "0x8449410", VA = "0x18844A210", Slot = "9")]
		protected override void Dispose(bool FGLACMFJBCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8449E00", Offset = "0x8449000", VA = "0x188449E00", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer JFBIEOOKIGH, RenderingData OIHDNGPDHCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x16773F0", Offset = "0x16765F0", VA = "0x1816773F0")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BNNLMLOBJCM
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IOKDHOKKDDP(CommandBuffer KOGNOJFCDGN, Camera KGPBHINDLND, [NotNull] UniversalAdditionalCameraData PDBDNKLOCEN, bool BEMACNCNBDB);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFGPCMENEJH(Camera KGPBHINDLND, CommandBuffer FHKIEMDLHCP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class OEEFJCOEFIN
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool LJLCEECOIJC;
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
		private DOOCHJECEBN _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private GFOJGONDFLD _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x844EEE0", Offset = "0x844E0E0", VA = "0x18844EEE0", Slot = "9")]
		protected override void Dispose(bool DLJJKHAHNIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x844EF50", Offset = "0x844E150", VA = "0x18844EF50")]
		private void INBIJEHOKAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x844EB90", Offset = "0x844DD90", VA = "0x18844EB90", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer JFBIEOOKIGH, RenderingData OIHDNGPDHCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x16773F0", Offset = "0x16765F0", VA = "0x1816773F0")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LDHLPAACPEC
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x844E350", Offset = "0x844D550", VA = "0x18844E350")]
	public static int ILDKHKHKLJA(bool BKKAGEJAMDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1B02400", Offset = "0x1B01600", VA = "0x181B02400")]
	public static int GEPHFIMGEJP(bool BKKAGEJAMDA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct MMDFFILDPBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType FEENFEEDPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float HJEGBGPPCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float IKOPOIHFBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float KBGEEPLLAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 HFDKFKJPKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 CEKGJEPPOCM;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct OBEKBKMFJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort KEFJMNBHMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float KLMPHBELHGN;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct POMKHEIAMMK : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<MMDFFILDPBD> AENGENPKBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 GLGPLFPPFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 HLDBHCDFKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, OBEKBKMFJJJ>.ParallelWriter JFEFACADNGI;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x84505E0", Offset = "0x844F7E0", VA = "0x1884505E0", Slot = "4")]
	public void Execute(int KEFJMNBHMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8450B20", Offset = "0x844FD20", VA = "0x188450B20")]
	private void KMDFGKGAJGO(uint3 DNEFFFFLJIO, uint3 INIDIEBKDMC, ushort KEFJMNBHMMF, float3 IAABBFEEELC, float DAHPHFKGBBJ, float IPHEHBNMANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8450F80", Offset = "0x8450180", VA = "0x188450F80")]
	private void MJLGEMKAPEJ(uint3 DNEFFFFLJIO, uint3 INIDIEBKDMC, ushort KEFJMNBHMMF, float3 IAABBFEEELC, float3 LKMOMJHAJMP, float3 KADJPDANIKD, float DAHPHFKGBBJ, float ACNKBBPLILO, float IPHEHBNMANN, float JCCFICPKLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8450E90", Offset = "0x8450090", VA = "0x188450E90")]
	private float3 LMLJMNBNBEM(uint3 DNEFFFFLJIO, float3 IAABBFEEELC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x844AB60", Offset = "0x8449D60", VA = "0x18844AB60")]
	private float BPGHBIAPHLL(float HJEGBGPPCKD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x844B230", Offset = "0x844A430", VA = "0x18844B230")]
	private float FLNGONNEBCC(float3 JHKLJBBEPGM, float3 KADJPDANIKD, float ACNKBBPLILO, float IPHEHBNMANN)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct HDNILHOAOCD : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, OBEKBKMFJJJ> JFEFACADNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint JANJBIJADGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int IPBENGINBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int NBDFBBBJPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> KMPHHCDMOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> HDLKEOPAOLB;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x844CA30", Offset = "0x844BC30", VA = "0x18844CA30", Slot = "4")]
	public void Execute(int GDCDGPKOFKO, int MEHNKBECLNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x844CBD0", Offset = "0x844BDD0", VA = "0x18844CBD0")]
	private void NNFOAKCDJFF(int LHAEFKINNGB, ushort JABCJNKMOJH, int KHBCGNJJBED, OBEKBKMFJJJ ABKOECKOGNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct ICADCPDDECG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, OBEKBKMFJJJ> JFEFACADNGI;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x844D130", Offset = "0x844C330", VA = "0x18844D130", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DOOCHJECEBN : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool GOFFKJALOFO;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float FEFPDCCJECC = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int DONIOPICMJN = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int AJDPLLALHNC = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private POMKHEIAMMK FECDBEAMOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private HDNILHOAOCD MDDIDGOPCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private ICADCPDDECG NMDKGCOFGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, OBEKBKMFJJJ> PKNOPAKBNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private ICGDFNIECDA ACNAEKICMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool CJJCCFBJCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int NBKGFPMLHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<MMDFFILDPBD> MGLAOPFNFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle GGBNENONMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle EENPJEOKKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool FPHDPKHJCAA;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8449D50", Offset = "0x8448F50", VA = "0x188449D50")]
	public DOOCHJECEBN(RenderPassEvent ALOIKGNLFKN, ComputeShader HJHCCDBLBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8449C70", Offset = "0x8448E70", VA = "0x188449C70")]
	private void MHFKLLKHDJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8449280", Offset = "0x8448480", VA = "0x188449280")]
	public void CPAPJPOHGKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3674B80", Offset = "0x3673D80", VA = "0x183674B80")]
	public static void BIIPFGINODJ<T>(NativeArray<T> CABEAFGDMFF, int JAFKPMJIGFL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8448EE0", Offset = "0x84480E0", VA = "0x188448EE0")]
	public void CBJOLOPGOGL(CameraData PDBDNKLOCEN, LightData GHALIMGEIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8449360", Offset = "0x8448560", VA = "0x188449360")]
	private void DPNFOGJKKJL(LightData GHALIMGEIEP, NativeArray<MMDFFILDPBD> PDKFACPGKEM, int KJKLOCJCJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8449A30", Offset = "0x8448C30", VA = "0x188449A30")]
	private void LFBFJOLDALE(CameraData PDBDNKLOCEN, LightData GHALIMGEIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x84496A0", Offset = "0x84488A0", VA = "0x1884496A0")]
	private void EDPOHFDNLJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8449830", Offset = "0x8448A30", VA = "0x188449830")]
	private void EIPJBPFNHEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8448E90", Offset = "0x8448090", VA = "0x188448E90")]
	private void AGIPIBNCJLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8448EB0", Offset = "0x84480B0", VA = "0x188448EB0")]
	private void ANEIAEIJCIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8449930", Offset = "0x8448B30", VA = "0x188449930", Slot = "9")]
	public override void Execute(ScriptableRenderContext OPJOIGJBJKN, RenderingData OIHDNGPDHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8449CE0", Offset = "0x8448EE0", VA = "0x188449CE0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer FHKIEMDLHCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class GFOJGONDFLD : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort NKCNHFBLNBC = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float FEFPDCCJECC = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly ICGDFNIECDA ACNAEKICMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int DGACMEBHNBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private MMDFFILDPBD[] MGLAOPFNFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 KBJBIEENEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 HIDPKLAHHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint HLMCHAEOBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int IJHKPLLEHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int AMNOMODCDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> KMPHHCDMOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> HDLKEOPAOLB;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x844C980", Offset = "0x844BB80", VA = "0x18844C980")]
	public GFOJGONDFLD(RenderPassEvent ALOIKGNLFKN, ComputeShader HJHCCDBLBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x844AB80", Offset = "0x8449D80", VA = "0x18844AB80")]
	public void CBJOLOPGOGL(CameraData PDBDNKLOCEN, LightData GHALIMGEIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x844B8A0", Offset = "0x844AAA0", VA = "0x18844B8A0")]
	private void JJIBIHBCJMG(CameraData PDBDNKLOCEN, LightData GHALIMGEIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x844ACF0", Offset = "0x8449EF0", VA = "0x18844ACF0")]
	public void CPAPJPOHGKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x844AD10", Offset = "0x8449F10", VA = "0x18844AD10")]
	private void DPNFOGJKKJL(LightData GHALIMGEIEP, MMDFFILDPBD[] PDKFACPGKEM, int KJKLOCJCJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x844C090", Offset = "0x844B290", VA = "0x18844C090")]
	private void MEBCCGOGNLF(int GDCDGPKOFKO, int MEHNKBECLNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x844B120", Offset = "0x844A320", VA = "0x18844B120")]
	private void ELNLLHDIJOC(int GDCDGPKOFKO, int KIFHGDECLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x844C940", Offset = "0x844BB40", VA = "0x18844C940")]
	private ushort PACIDIBENFK(int GDCDGPKOFKO)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x844C020", Offset = "0x844B220", VA = "0x18844C020")]
	private void MAJJJAJFMNJ(int GDCDGPKOFKO, int MEHNKBECLNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x844BAA0", Offset = "0x844ACA0", VA = "0x18844BAA0")]
	private void JKHFONBIEBL(int JAFKPMJIGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x844B060", Offset = "0x844A260", VA = "0x18844B060")]
	private void ELHCCOPEMKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x844B150", Offset = "0x844A350", VA = "0x18844B150", Slot = "9")]
	public override void Execute(ScriptableRenderContext OPJOIGJBJKN, RenderingData OIHDNGPDHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x844C910", Offset = "0x844BB10", VA = "0x18844C910", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer FHKIEMDLHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x844B2F0", Offset = "0x844A4F0", VA = "0x18844B2F0")]
	private void HPGPIHIPJOI(int KEFJMNBHMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x844BB10", Offset = "0x844AD10", VA = "0x18844BB10")]
	private void KMDFGKGAJGO(uint3 DNEFFFFLJIO, uint3 INIDIEBKDMC, ushort KEFJMNBHMMF, float3 IAABBFEEELC, float DAHPHFKGBBJ, float IPHEHBNMANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x844C140", Offset = "0x844B340", VA = "0x18844C140")]
	private void MJLGEMKAPEJ(uint3 DNEFFFFLJIO, uint3 INIDIEBKDMC, ushort KEFJMNBHMMF, float3 IAABBFEEELC, float3 LKMOMJHAJMP, float3 KADJPDANIKD, float DAHPHFKGBBJ, float ACNKBBPLILO, float IPHEHBNMANN, float JCCFICPKLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x844C690", Offset = "0x844B890", VA = "0x18844C690")]
	private void NIEHAHOIBNL(ushort KEFJMNBHMMF, uint KFJIHNFKONJ, float LPHMMKPACAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x844BF20", Offset = "0x844B120", VA = "0x18844BF20")]
	private float3 LMLJMNBNBEM(uint3 DNEFFFFLJIO, float3 IAABBFEEELC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x844AB60", Offset = "0x8449D60", VA = "0x18844AB60")]
	private float BPGHBIAPHLL(float HJEGBGPPCKD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x844B230", Offset = "0x844A430", VA = "0x18844B230")]
	private float FLNGONNEBCC(float3 JHKLJBBEPGM, float3 KADJPDANIKD, float ACNKBBPLILO, float IPHEHBNMANN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x844C780", Offset = "0x844B980", VA = "0x18844C780")]
	private void NNFOAKCDJFF(int LHAEFKINNGB, ushort JABCJNKMOJH, int KHBCGNJJBED, OBEKBKMFJJJ ABKOECKOGNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class ICGDFNIECDA
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class OKHLCDMOPIM
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int OCGJHMNEFFJ;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int NEENBCMBEJK;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int LJJHGPPBADN;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int HFHJILIIMDG;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int NOPOPEFIABP;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int EHHJIFPMEDD;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int JBGDCBFBIAH;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int JKELONPNOFF = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int KELJMDMLMDK = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int LDLCNENBPNJ = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int PINGHBGAOGE = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int JIAOOACMEFA = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int PLHCIJNNHCF = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int LPGPFLGNKMK = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool MACHOAJECHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer IAFGLHCLHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture DEBKGBIMGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int HLNMENEPFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int MFNBFLDJIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int HFIDMEDKHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int JJKCHNBMDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int FHIAFEPGPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader HBEBCPKOCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int CACEACPFCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int GFCHCHIPCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 CKJEIPBNJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 GOHLMIAOFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> FFAGNAOIAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> LPECPGBIOJC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> HANHJEDANAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4FA0180", Offset = "0x4F9F380", VA = "0x184FA0180")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> FLMHKKJGEFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1173810", Offset = "0x1172A10", VA = "0x181173810")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int FCDPFKIBCMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xC73E60", Offset = "0xC73060", VA = "0x180C73E60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int BFGGGIOHPME
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3A0", Offset = "0x9FA5A0", VA = "0x1809FB3A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader CIEDEDEAIPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x844DAD0", Offset = "0x844CCD0", VA = "0x18844DAD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x844DB60", Offset = "0x844CD60", VA = "0x18844DB60")]
	public void GNJBDGKPLLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x844E020", Offset = "0x844D220", VA = "0x18844E020")]
	public void NKCKPMGJHGN(CameraData PDBDNKLOCEN, LightData GHALIMGEIEP, int CPFKNADHBHL, bool BKKAGEJAMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x38442B0", Offset = "0x38434B0", VA = "0x1838442B0")]
	private void BIIPFGINODJ<T>(NativeArray<T> CABEAFGDMFF, int JAFKPMJIGFL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x844DC50", Offset = "0x844CE50", VA = "0x18844DC50")]
	public void KHELLCPOOHF(CommandBuffer FHKIEMDLHCP, ScriptableRenderContext OPJOIGJBJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x844D350", Offset = "0x844C550", VA = "0x18844D350")]
	private static void CEBICHOCLNI(int FKALKDOAGNP, CommandBuffer FHKIEMDLHCP, RenderBuffer NJCHDACFOMJ, ComputeBuffer DNABALINMIL, ComputeShader JJDJAOODNJP, int EHIEMKKEGKM, int CKGLGMIBHCO, int IPOOCDNIEAM, int BEIIGJGPPOJ, int IJONJCDNLHA, int OMJBIFLMBDM, int NCMILBFLDJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x844D530", Offset = "0x844C730", VA = "0x18844D530")]
	public void CGAAFNMNJLK(CommandBuffer FHKIEMDLHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x844D170", Offset = "0x844C370", VA = "0x18844D170")]
	private RenderTexture AKLKAJHNGGD(RenderTexture AHHLCDHPHLA, int EHIEMKKEGKM, int CKGLGMIBHCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x844DFA0", Offset = "0x844D1A0", VA = "0x18844DFA0")]
	public void LGIKJJOCOCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x844D840", Offset = "0x844CA40", VA = "0x18844D840")]
	public void DJKPNILOJHF(int KIIOLCLMEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x844E330", Offset = "0x844D530", VA = "0x18844E330")]
	public ICGDFNIECDA()
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
		public struct BPCDEJGCOBA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float GFEJADCHOLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float HFGNMHDLEHB;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class LGEGGINANOL : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string DLIHFMLELGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler GHBCDJICEAJ;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int DEPHKCIJLPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material HKMNLCCKCIC;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x844E730", Offset = "0x844D930", VA = "0x18844E730")]
			public LGEGGINANOL(RenderPassEvent ALOIKGNLFKN, Material OHHEKLKCMJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x844E360", Offset = "0x844D560", VA = "0x18844E360", Slot = "9")]
			public override void Execute(ScriptableRenderContext OPJOIGJBJKN, RenderingData OIHDNGPDHCH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static BPCDEJGCOBA CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private LGEGGINANOL m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x844F560", Offset = "0x844E760", VA = "0x18844F560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x844F510", Offset = "0x844E710", VA = "0x18844F510")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x844F360", Offset = "0x844E560", VA = "0x18844F360", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x844F290", Offset = "0x844E490", VA = "0x18844F290", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer JFBIEOOKIGH, RenderingData OIHDNGPDHCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x16773F0", Offset = "0x16765F0", VA = "0x1816773F0")]
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
		public struct AHGMGLDBDJG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float GGDPKDJKKAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color PENIKGHIPDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh KLIBGEJLBIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve MIEDJCBOBKF;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class LOIDHLOMCAO : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string DLIHFMLELGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler GHBCDJICEAJ;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int EBMKHNJMEBF;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int MMEMMBIMBBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material HKMNLCCKCIC;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x844EAB0", Offset = "0x844DCB0", VA = "0x18844EAB0")]
			public LOIDHLOMCAO(RenderPassEvent ALOIKGNLFKN, Material OHHEKLKCMJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x844E810", Offset = "0x844DA10", VA = "0x18844E810", Slot = "9")]
			public override void Execute(ScriptableRenderContext OPJOIGJBJKN, RenderingData OIHDNGPDHCH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static AHGMGLDBDJG CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private LOIDHLOMCAO m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x844F870", Offset = "0x844EA70", VA = "0x18844F870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x844F6C0", Offset = "0x844E8C0", VA = "0x18844F6C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x844F5B0", Offset = "0x844E7B0", VA = "0x18844F5B0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer JFBIEOOKIGH, RenderingData OIHDNGPDHCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x16773F0", Offset = "0x16765F0", VA = "0x1816773F0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string EDGKHOGHMJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool BGHKNEADJJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer FHKIEMDLHCP, ScriptableRenderContext OPJOIGJBJKN, RenderingData OIHDNGPDHCH);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
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
		private class GAJDBICDJEK : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool IJJBMGJBANN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> ONDCLHEHIMB;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> IECKNANNDAL;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x844AAB0", Offset = "0x8449CB0", VA = "0x18844AAB0")]
			public GAJDBICDJEK(RenderPassEvent ALOIKGNLFKN, bool IJJBMGJBANN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x844A490", Offset = "0x8449690", VA = "0x18844A490")]
			public bool BDOPOEJBFHA(CameraData PDBDNKLOCEN)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x844A770", Offset = "0x8449970", VA = "0x18844A770", Slot = "9")]
			public override void Execute(ScriptableRenderContext OPJOIGJBJKN, RenderingData OIHDNGPDHCH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x844A940", Offset = "0x8449B40", VA = "0x18844A940")]
			private void MOIMNEEGBNA(PerCameraRenderEffect EPPEECHLMHD, ScriptableRenderContext OPJOIGJBJKN, RenderingData OIHDNGPDHCH)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private GAJDBICDJEK m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private GAJDBICDJEK m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x84514C0", Offset = "0x84506C0", VA = "0x1884514C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8451430", Offset = "0x8450630", VA = "0x188451430", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer JFBIEOOKIGH, RenderingData OIHDNGPDHCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x16773F0", Offset = "0x16765F0", VA = "0x1816773F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8451710", Offset = "0x8450910", VA = "0x188451710")]
		public static void MOHGHNAGIFN(ScriptableRenderPass IBBHOGCMJHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8451570", Offset = "0x8450770", VA = "0x188451570", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer JFBIEOOKIGH, RenderingData OIHDNGPDHCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x16773F0", Offset = "0x16765F0", VA = "0x1816773F0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class NABDLKCKLMM
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 GAFILKFKBFK;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 NDBBCFENDAB;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 LFEBNGAHMOE;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 MPBFJDJHPNL;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 HBHOOCBCFLH;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8450120", Offset = "0x844F320", VA = "0x188450120")]
	public static uint NNKBGNKADNB(uint CCOLDGJALNH, uint JCBKIOEHCDD, uint OMKCPOJOENH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x844FF30", Offset = "0x844F130", VA = "0x18844FF30")]
	public static uint3 NALNBDHMLFD(float3 BJHAAAPCKLC, float3 GLGPLFPPFHC, float3 HLDBHCDFKBI)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8450130", Offset = "0x844F330", VA = "0x188450130")]
	public static void PCPMBOMFKCD(float3 IGBONLEIJIB, float3 BHJCHHNICOI, float3 DMPIAONLEBM, float IHBIKJPLAHJ, [Out] uint3 LNGMLCFMMKN, [Out] uint3 EJHFODIPJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x844FA60", Offset = "0x844EC60", VA = "0x18844FA60")]
	public static void KBLNEHLJKEF(float3 MCBAMGIGDMK, float3 KKBCBHHEOPP, float IKOPOIHFBKC, float JKHMFMGGACB, [Out] float3 OGKOLPMBODD, [Out] float IHBIKJPLAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x844F8C0", Offset = "0x844EAC0", VA = "0x18844F8C0")]
	private static float3 GMCJCLBHGPH(float3 NECFCMJHHCH, float3 MBAKOLEHIFI, float3 HOHCDMACPMM, float3 MEFCDHMFBEJ)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class AJGDCLFPJPL
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly FODGIOKBGBI EEGDELJEKCD;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly FODGIOKBGBI LHOJDMEMCDN;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly FODGIOKBGBI EMDOKOBKDOO;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly FODGIOKBGBI MGGMKAEPOMI;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly FODGIOKBGBI ABBDLCFCDJN;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class CIAFHJCNGBP
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh JBDCNIGJMCO;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8448DF0", Offset = "0x8447FF0", VA = "0x188448DF0")]
	public static Mesh PCHLKGHPIOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8448950", Offset = "0x8447B50", VA = "0x188448950")]
	public static Matrix4x4 DGPKILPGHEM(Camera KGPBHINDLND, bool ENEFNLFNFLK = false, bool LPPGFMOEHBE = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8448590", Offset = "0x8447790", VA = "0x188448590")]
	private static Mesh AAPAAGCOBNJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__1056213900
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8452B30", Offset = "0x8451D30", VA = "0x188452B30")]
	public static void NJBGNBNNMNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8452B20", Offset = "0x8451D20", VA = "0x188452B20")]
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
