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
	public class LogRegistrationIndex : ADNHPIGEHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x73F4090", Offset = "0x73F3490", VA = "0x1873F4090", Slot = "4")]
		public override void CIGOIKFLIDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
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
		public enum BDLDHEPKLKJ
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface FCIMFMLGGOA
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void EFGADDMOLKO(ScriptableRenderContext EPLPPJHJIIM, List<Camera> PGBJNNNNAMN);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface NPLIFGBNCKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void EFGADDMOLKO(ScriptableRenderContext EPLPPJHJIIM, RenderingData FNJDAPBBICC);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class LGBMMNOIIEO : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x73F39E0", Offset = "0x73F2DE0", VA = "0x1873F39E0")]
			public LGBMMNOIIEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x73F3980", Offset = "0x73F2D80", VA = "0x1873F3980", Slot = "9")]
			public override void Execute(ScriptableRenderContext EPLPPJHJIIM, RenderingData FNJDAPBBICC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private LGBMMNOIIEO _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<FCIMFMLGGOA> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<FCIMFMLGGOA> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<NPLIFGBNCKD> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<NPLIFGBNCKD> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x73F8CD0", Offset = "0x73F80D0", VA = "0x1873F8CD0")]
		public static void EGCLIADAIPK(BDLDHEPKLKJ JHEEONFFFFF, FCIMFMLGGOA IGJLBLCNCME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x73F82C0", Offset = "0x73F76C0", VA = "0x1873F82C0")]
		public static void BDEDMMNFIEB(BDLDHEPKLKJ JHEEONFFFFF, FCIMFMLGGOA IGJLBLCNCME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x73F8C10", Offset = "0x73F8010", VA = "0x1873F8C10")]
		public static void EGCLIADAIPK(BDLDHEPKLKJ JHEEONFFFFF, NPLIFGBNCKD BLCDJAHADKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x73F8380", Offset = "0x73F7780", VA = "0x1873F8380")]
		public static void BDEDMMNFIEB(BDLDHEPKLKJ JHEEONFFFFF, NPLIFGBNCKD BLCDJAHADKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x73F8910", Offset = "0x73F7D10", VA = "0x1873F8910", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x73F8210", Offset = "0x73F7610", VA = "0x1873F8210", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CJAGOGFODOI, RenderingData FNJDAPBBICC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x73F8B00", Offset = "0x73F7F00", VA = "0x1873F8B00", Slot = "9")]
		protected override void Dispose(bool PDNLBOINEDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x73F8D90", Offset = "0x73F8190", VA = "0x1873F8D90")]
		private static void HJIHOANHIAL(ScriptableRenderContext EPLPPJHJIIM, List<Camera> PGBJNNNNAMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x73F9290", Offset = "0x73F8690", VA = "0x1873F9290")]
		private static void KFPNOCNKBHK(ScriptableRenderContext EPLPPJHJIIM, List<Camera> PGBJNNNNAMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x73F8440", Offset = "0x73F7840", VA = "0x1873F8440")]
		private static void BGPLNGDNJAI(ScriptableRenderContext EPLPPJHJIIM, RenderingData FNJDAPBBICC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x10EC460", Offset = "0x10EB860", VA = "0x1810EC460")]
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
		private class NOEFNNIPOOE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool GBOPEMHEJBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<AMHCMHEAMDN> GAHOBECDHAD;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x73F4D50", Offset = "0x73F4150", VA = "0x1873F4D50")]
			public NOEFNNIPOOE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class NHLIBFNENLO : PreRenderManager.NPLIFGBNCKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string AHBNIJEFIDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler MPFFMDCMIDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly NOEFNNIPOOE LEHOGOIFBJN;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x73F4B90", Offset = "0x73F3F90", VA = "0x1873F4B90")]
			public NHLIBFNENLO(NOEFNNIPOOE JGHNJONBIGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x73F4780", Offset = "0x73F3B80", VA = "0x1873F4780", Slot = "4")]
			public void EFGADDMOLKO(ScriptableRenderContext EPLPPJHJIIM, RenderingData FNJDAPBBICC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class GOODMJOGAAL : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string NBBKBFOBPIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly NOEFNNIPOOE JGHNJONBIGJ;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x73F0F80", Offset = "0x73F0380", VA = "0x1873F0F80")]
			public GOODMJOGAAL(RenderPassEvent PGLNBAELOLB, NOEFNNIPOOE JGHNJONBIGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x73F0C70", Offset = "0x73F0070", VA = "0x1873F0C70", Slot = "9")]
			public override void Execute(ScriptableRenderContext EPLPPJHJIIM, RenderingData FNJDAPBBICC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<AMHCMHEAMDN> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private NHLIBFNENLO fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private GOODMJOGAAL fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private NOEFNNIPOOE sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x73F0220", Offset = "0x73EF620", VA = "0x1873F0220", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x73F05B0", Offset = "0x73EF9B0", VA = "0x1873F05B0", Slot = "9")]
		protected override void Dispose(bool PDNLBOINEDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x73F0180", Offset = "0x73EF580", VA = "0x1873F0180", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CJAGOGFODOI, RenderingData FNJDAPBBICC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x10EC460", Offset = "0x10EB860", VA = "0x1810EC460")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface AMHCMHEAMDN
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HJCMFDBODOB(CommandBuffer NIGBGHGPAEP, Camera EHNMIPIEOKK, [NotNull] UniversalAdditionalCameraData JHPIJPECNNI, bool AIEOICIBINH);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BJOIACMPDAI(Camera EHNMIPIEOKK, CommandBuffer HILAPBJMMLJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PCMIHEPAIJC
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool GDDKCIGEKEE;
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
		private HLICFHPDCKH _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private PPLOHIOIPJN _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x73F3D60", Offset = "0x73F3160", VA = "0x1873F3D60", Slot = "9")]
		protected override void Dispose(bool MIFLDHNDHKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x73F3DD0", Offset = "0x73F31D0", VA = "0x1873F3DD0")]
		private void PCECCJDFMIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x73F3A10", Offset = "0x73F2E10", VA = "0x1873F3A10", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CJAGOGFODOI, RenderingData FNJDAPBBICC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x10EC460", Offset = "0x10EB860", VA = "0x1810EC460")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LMEDPCHONAH
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x73F3A00", Offset = "0x73F2E00", VA = "0x1873F3A00")]
	public static int JNOCJNAPAIJ(bool LANBJCIGEIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x153BFF0", Offset = "0x153B3F0", VA = "0x18153BFF0")]
	public static int GDIPLGAICMA(bool LANBJCIGEIL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct EKABEOOKAEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType DOBFCGGCLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float ALMBJBMMFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float GOLOFNEFPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float NPIPGJBLFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 PALAHHDIMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 LKPADJMJEJO;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct BLBEJMJPEKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort JILAIOMBAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float DKCBAJNEFBC;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct DOOPNGHIBBO : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<EKABEOOKAEL> KNDBNCMLFJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 FJLHHNBLHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 FAINHKELBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, BLBEJMJPEKA>.ParallelWriter LCIGEGKKCLI;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x73EF260", Offset = "0x73EE660", VA = "0x1873EF260", Slot = "4")]
	public void Execute(int JILAIOMBAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x73EFC70", Offset = "0x73EF070", VA = "0x1873EFC70")]
	private void NJPPOFKNIKB(uint3 AKKMLDFPHNC, uint3 MJGJJFBIDMK, ushort JILAIOMBAJF, float3 OAPDNFKBFLE, float MNKOLDDNKFC, float DPBLKAKKDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x73EF7A0", Offset = "0x73EEBA0", VA = "0x1873EF7A0")]
	private void JGNNGCLHKCD(uint3 AKKMLDFPHNC, uint3 MJGJJFBIDMK, ushort JILAIOMBAJF, float3 OAPDNFKBFLE, float3 OFGKNICJLCL, float3 ADPKKMDJFHO, float MNKOLDDNKFC, float MGGODPANHEC, float DPBLKAKKDAC, float CBJABMGCAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x73EF170", Offset = "0x73EE570", VA = "0x1873EF170")]
	private float3 DOEPKLFPFDE(uint3 AKKMLDFPHNC, float3 OAPDNFKBFLE)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x73EFC50", Offset = "0x73EF050", VA = "0x1873EFC50")]
	private float MOLMEPMFEOE(float ALMBJBMMFIB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x73EF0B0", Offset = "0x73EE4B0", VA = "0x1873EF0B0")]
	private float BJCCBKOFBIG(float3 KHLBPJLPOPG, float3 ADPKKMDJFHO, float MGGODPANHEC, float DPBLKAKKDAC)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct HGFMIOHCMCA : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, BLBEJMJPEKA> LCIGEGKKCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint BHGJPBPDOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int HPCLFMJIJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int IKKODKFDJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> FNPLBLGOBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> KHHGKFGJGLF;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x73F11D0", Offset = "0x73F05D0", VA = "0x1873F11D0", Slot = "4")]
	public void Execute(int HDJOFECABIK, int PAFACABOPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x73F1060", Offset = "0x73F0460", VA = "0x1873F1060")]
	private void EIGHMENEIGE(int NNICJGIHPKJ, ushort FNCMABBHGDN, int AMFLKMECEHO, BLBEJMJPEKA ABENBGMDBHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct FNCEGDLIBHN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, BLBEJMJPEKA> LCIGEGKKCLI;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x73F0140", Offset = "0x73EF540", VA = "0x1873F0140", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HLICFHPDCKH : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool MAGJMLPDIJD;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float NFMKHFOHIJG = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int MIDLBBPPPPM = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int OCLNKKMGLBM = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private DOOPNGHIBBO DAAIKACDJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private HGFMIOHCMCA PPAGFOFPEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private FNCEGDLIBHN IEAMHKMLEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, BLBEJMJPEKA> GBFAKHPBFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private PLBJHAGFGLJ NJPMMOAOPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool HKPKOHBHMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int LKLDMAEIPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<EKABEOOKAEL> LLEGEJJJJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle AABLLCKDNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle EKIPKKKIEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool FLJAAHLIOJO;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x73F2250", Offset = "0x73F1650", VA = "0x1873F2250")]
	public HLICFHPDCKH(RenderPassEvent PGLNBAELOLB, ComputeShader KAOMDLACCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x73F1450", Offset = "0x73F0850", VA = "0x1873F1450")]
	private void DDAJCKOPEML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x73F1370", Offset = "0x73F0770", VA = "0x1873F1370")]
	public void CPIGGLAFJFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2ECCC00", Offset = "0x2ECC000", VA = "0x182ECCC00")]
	public static void DBDEJHHCNID<T>(NativeArray<T> EFKOIGFMOHD, int JKIIGJDNBMO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x73F1E50", Offset = "0x73F1250", VA = "0x1873F1E50")]
	public void PJLDMLHHEMD(CameraData JHPIJPECNNI, LightData PHFELIDEIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x73F17A0", Offset = "0x73F0BA0", VA = "0x1873F17A0")]
	private void IOJPBIKIBPJ(LightData PHFELIDEIJD, NativeArray<EKABEOOKAEL> IOANJILCGBI, int HAHLNJBBHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x73F1AE0", Offset = "0x73F0EE0", VA = "0x1873F1AE0")]
	private void MGECIBEENHL(CameraData JHPIJPECNNI, LightData PHFELIDEIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x73F15F0", Offset = "0x73F09F0", VA = "0x1873F15F0")]
	private void FGALAMBLODL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x73F1D50", Offset = "0x73F1150", VA = "0x1873F1D50")]
	private void PEDCFNNHOCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x73F1780", Offset = "0x73F0B80", VA = "0x1873F1780")]
	private void HFCAIABGBDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x73F14C0", Offset = "0x73F08C0", VA = "0x1873F14C0")]
	private void EJIMMCMCDIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x73F14F0", Offset = "0x73F08F0", VA = "0x1873F14F0", Slot = "9")]
	public override void Execute(ScriptableRenderContext EPLPPJHJIIM, RenderingData FNJDAPBBICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x73F1D20", Offset = "0x73F1120", VA = "0x1873F1D20", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer HILAPBJMMLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PPLOHIOIPJN : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort CDCEIOMNBKC = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float NFMKHFOHIJG = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly PLBJHAGFGLJ NJPMMOAOPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int FFBDIPLJGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private EKABEOOKAEL[] LLEGEJJJJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 NKEECLBGBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 IIMAEMGGDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint LAMEDHJAOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int DJEDPLBLFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int BGGJOCBGAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> FNPLBLGOBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> KHHGKFGJGLF;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x73F7D10", Offset = "0x73F7110", VA = "0x1873F7D10")]
	public PPLOHIOIPJN(RenderPassEvent PGLNBAELOLB, ComputeShader KAOMDLACCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x73F7B30", Offset = "0x73F6F30", VA = "0x1873F7B30")]
	public void PJLDMLHHEMD(CameraData JHPIJPECNNI, LightData PHFELIDEIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x73F7930", Offset = "0x73F6D30", VA = "0x1873F7930")]
	private void PDLDKFOFOKA(CameraData JHPIJPECNNI, LightData PHFELIDEIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x73F60F0", Offset = "0x73F54F0", VA = "0x1873F60F0")]
	public void CPIGGLAFJFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x73F6C20", Offset = "0x73F6020", VA = "0x1873F6C20")]
	private void IOJPBIKIBPJ(LightData PHFELIDEIJD, EKABEOOKAEL[] IOANJILCGBI, int HAHLNJBBHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x73F6040", Offset = "0x73F5440", VA = "0x1873F6040")]
	private void BFPMOPINDLB(int HDJOFECABIK, int PAFACABOPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x73F74C0", Offset = "0x73F68C0", VA = "0x1873F74C0")]
	private void LCLDMHPMNLG(int HDJOFECABIK, int GMOPHNCDIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x73F6570", Offset = "0x73F5970", VA = "0x1873F6570")]
	private ushort FNMDPBJOEPE(int HDJOFECABIK)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x73F7CA0", Offset = "0x73F70A0", VA = "0x1873F7CA0")]
	private void PNHBGDAKFKC(int HDJOFECABIK, int PAFACABOPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x73F5FD0", Offset = "0x73F53D0", VA = "0x1873F5FD0")]
	private void BABEKKENNCC(int JKIIGJDNBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x73F65B0", Offset = "0x73F59B0", VA = "0x1873F65B0")]
	private void GBIGKKKGGNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x73F63A0", Offset = "0x73F57A0", VA = "0x1873F63A0", Slot = "9")]
	public override void Execute(ScriptableRenderContext EPLPPJHJIIM, RenderingData FNJDAPBBICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x73F7900", Offset = "0x73F6D00", VA = "0x1873F7900", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer HILAPBJMMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x73F6670", Offset = "0x73F5A70", VA = "0x1873F6670")]
	private void HEFEJLNGLPA(int JILAIOMBAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x73F74F0", Offset = "0x73F68F0", VA = "0x1873F74F0")]
	private void NJPPOFKNIKB(uint3 AKKMLDFPHNC, uint3 MJGJJFBIDMK, ushort JILAIOMBAJF, float3 OAPDNFKBFLE, float MNKOLDDNKFC, float DPBLKAKKDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x73F6F70", Offset = "0x73F6370", VA = "0x1873F6F70")]
	private void JGNNGCLHKCD(uint3 AKKMLDFPHNC, uint3 MJGJJFBIDMK, ushort JILAIOMBAJF, float3 OAPDNFKBFLE, float3 OFGKNICJLCL, float3 ADPKKMDJFHO, float MNKOLDDNKFC, float MGGODPANHEC, float DPBLKAKKDAC, float CBJABMGCAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x73F6480", Offset = "0x73F5880", VA = "0x1873F6480")]
	private void FHJNHKGDFIA(ushort JILAIOMBAJF, uint EEIFIKKCCAC, float PMAHKCIIHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x73F6110", Offset = "0x73F5510", VA = "0x1873F6110")]
	private float3 DOEPKLFPFDE(uint3 AKKMLDFPHNC, float3 OAPDNFKBFLE)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x73EFC50", Offset = "0x73EF050", VA = "0x1873EFC50")]
	private float MOLMEPMFEOE(float ALMBJBMMFIB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x73EF0B0", Offset = "0x73EE4B0", VA = "0x1873EF0B0")]
	private float BJCCBKOFBIG(float3 KHLBPJLPOPG, float3 ADPKKMDJFHO, float MGGODPANHEC, float DPBLKAKKDAC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x73F6210", Offset = "0x73F5610", VA = "0x1873F6210")]
	private void EIGHMENEIGE(int NNICJGIHPKJ, ushort FNCMABBHGDN, int AMFLKMECEHO, BLBEJMJPEKA ABENBGMDBHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class PLBJHAGFGLJ
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class EHMHAEMMMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int PKMCPDBBGFA;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int MCNKHFOLHKB;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int GLKDPOKBDAP;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int HBIJOGDFJOB;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int NNAMOPMNAEH;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int CFDKFDJGIAO;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int HCHBLEDHIEN;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int GKIPCLIHANB = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int GGHLIJNLOJB = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int LBNHKNIGJPN = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int EGJDJJEACFI = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int HPNAMLAILHH = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int JIAAKEFMJJC = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int JNDIMIFDMCP = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool EDMNOEGFOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer HCNPBIPNGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture EOHGAKOIDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int CBBIKKCGAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int MKOBBKELEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int NALMANLAPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int GGFNABLNGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int JGJAADJGEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader PBFMLHACLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int JHMFMBFLPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int EMINHEJMAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 AHHPOJADNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 GLIGEAKLGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> DCPKNMMEPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> PKIBPMEEHEG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> EODPADDIMBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x13A40B0", Offset = "0x13A34B0", VA = "0x1813A40B0")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> LMDIMBPDJJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1869360", Offset = "0x1868760", VA = "0x181869360")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int KCKFDHOPJLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xC4FD10", Offset = "0xC4F110", VA = "0x180C4FD10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int GPEHLLCJFOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8A6040", Offset = "0x8A5440", VA = "0x1808A6040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader LFEAPAOENPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x73F5A60", Offset = "0x73F4E60", VA = "0x1873F5A60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x73F5E40", Offset = "0x73F5240", VA = "0x1873F5E40")]
	public void PBEAHLLBJJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x73F5430", Offset = "0x73F4830", VA = "0x1873F5430")]
	public void HIPDBIHIJJO(CameraData JHPIJPECNNI, LightData PHFELIDEIJD, int EGCGMNBEIGN, bool LANBJCIGEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x30A1A10", Offset = "0x30A0E10", VA = "0x1830A1A10")]
	private void DBDEJHHCNID<T>(NativeArray<T> EFKOIGFMOHD, int JKIIGJDNBMO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x73F5AF0", Offset = "0x73F4EF0", VA = "0x1873F5AF0")]
	public void MPMNNPEDBIJ(CommandBuffer HILAPBJMMLJ, ScriptableRenderContext EPLPPJHJIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x73F5070", Offset = "0x73F4470", VA = "0x1873F5070")]
	private static void BEMPNEFIDAN(int HKLJMIFLIDO, CommandBuffer HILAPBJMMLJ, RenderBuffer LMLDFJNBMFP, ComputeBuffer FIGEDBNCLIA, ComputeShader EBCFOBNGPMP, int GMEJEHAOCBK, int IINJCOBJHIM, int NLLPMHBDOHF, int MFCOCGOHIPJ, int PCFBBKAJDJE, int ELGAKAFGIKM, int FBJCLLHCLJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x73F5740", Offset = "0x73F4B40", VA = "0x1873F5740")]
	public void MAPCGEDHIBO(CommandBuffer HILAPBJMMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x73F5250", Offset = "0x73F4650", VA = "0x1873F5250")]
	private RenderTexture EILAANCOBFC(RenderTexture FJHDPJIPJNE, int GMEJEHAOCBK, int IINJCOBJHIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x73F5F30", Offset = "0x73F5330", VA = "0x1873F5F30")]
	public void PEEDHJHBCJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x73F4DE0", Offset = "0x73F41E0", VA = "0x1873F4DE0")]
	public void APNICLCDMEP(int ACEGEBCNMJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x73F5FB0", Offset = "0x73F53B0", VA = "0x1873F5FB0")]
	public PLBJHAGFGLJ()
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
		public struct ADKJPJHHJIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float BPEIGGFLAEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float GLENGOMCMAK;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class GLCFGMKLPOJ : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string HPCNLJGMBHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler JDLOCMINIOG;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int FCOELMFLBDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material GHJFCIDDKHN;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x73F0B90", Offset = "0x73EFF90", VA = "0x1873F0B90")]
			public GLCFGMKLPOJ(RenderPassEvent PGLNBAELOLB, Material JAEJMKKLMIE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x73F07B0", Offset = "0x73EFBB0", VA = "0x1873F07B0", Slot = "9")]
			public override void Execute(ScriptableRenderContext EPLPPJHJIIM, RenderingData FNJDAPBBICC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static ADKJPJHHJIN CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private GLCFGMKLPOJ m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x73F43F0", Offset = "0x73F37F0", VA = "0x1873F43F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x73F43A0", Offset = "0x73F37A0", VA = "0x1873F43A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x73F41F0", Offset = "0x73F35F0", VA = "0x1873F41F0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x73F4120", Offset = "0x73F3520", VA = "0x1873F4120", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CJAGOGFODOI, RenderingData FNJDAPBBICC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x10EC460", Offset = "0x10EB860", VA = "0x1810EC460")]
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
		public struct LFJGKCAMJAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float HIGCEOELOJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color NIAPLBMJOLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh GDIPLLMILCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve LAIEHIGHJCN;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class IBOHECLHNNC : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string HPCNLJGMBHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler JDLOCMINIOG;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int CLBJGLAIIFL;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int LAJEMMGFJHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material GHJFCIDDKHN;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x73F2CA0", Offset = "0x73F20A0", VA = "0x1873F2CA0")]
			public IBOHECLHNNC(RenderPassEvent PGLNBAELOLB, Material JAEJMKKLMIE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x73F29E0", Offset = "0x73F1DE0", VA = "0x1873F29E0", Slot = "9")]
			public override void Execute(ScriptableRenderContext EPLPPJHJIIM, RenderingData FNJDAPBBICC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static LFJGKCAMJAC CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private IBOHECLHNNC m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x73F4720", Offset = "0x73F3B20", VA = "0x1873F4720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x73F4570", Offset = "0x73F3970", VA = "0x1873F4570", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x73F4450", Offset = "0x73F3850", VA = "0x1873F4450", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CJAGOGFODOI, RenderingData FNJDAPBBICC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x10EC460", Offset = "0x10EB860", VA = "0x1810EC460")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string CELALKCJGKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool NMMCODIADNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer HILAPBJMMLJ, ScriptableRenderContext EPLPPJHJIIM, RenderingData FNJDAPBBICC);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x89BD20", Offset = "0x89B120", VA = "0x18089BD20")]
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
		private class IBNFNLEECBN : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool NJNOJLBEAFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> CNCMNNBGMAD;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> HLEIEKAHDAB;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x73F2930", Offset = "0x73F1D30", VA = "0x1873F2930")]
			public IBNFNLEECBN(RenderPassEvent PGLNBAELOLB, bool NJNOJLBEAFL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x73F24D0", Offset = "0x73F18D0", VA = "0x1873F24D0")]
			public bool HPPLPACIMHC(CameraData JHPIJPECNNI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x73F2300", Offset = "0x73F1700", VA = "0x1873F2300", Slot = "9")]
			public override void Execute(ScriptableRenderContext EPLPPJHJIIM, RenderingData FNJDAPBBICC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x73F27C0", Offset = "0x73F1BC0", VA = "0x1873F27C0")]
			private void JPMMIMPLKIJ(PerCameraRenderEffect MKMGLKLIFAO, ScriptableRenderContext EPLPPJHJIIM, RenderingData FNJDAPBBICC)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IBNFNLEECBN m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private IBNFNLEECBN m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x73F7E50", Offset = "0x73F7250", VA = "0x1873F7E50", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x73F7DC0", Offset = "0x73F71C0", VA = "0x1873F7DC0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CJAGOGFODOI, RenderingData FNJDAPBBICC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x10EC460", Offset = "0x10EB860", VA = "0x1810EC460")]
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
		[Cpp2IlInjected.Address(RVA = "0x73F80A0", Offset = "0x73F74A0", VA = "0x1873F80A0")]
		public static void DBCCHMCJHAJ(ScriptableRenderPass NPNOJOFPIBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x73F7F00", Offset = "0x73F7300", VA = "0x1873F7F00", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CJAGOGFODOI, RenderingData FNJDAPBBICC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x10EC460", Offset = "0x10EB860", VA = "0x1810EC460")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class ILNPGFKFBGI
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 MDFEDNIHNAP;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 PGAMPKLEOCO;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 IBPBLEHOOJO;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 NCEFAPEFGOJ;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 DPGECAOKKJO;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x73F2D80", Offset = "0x73F2180", VA = "0x1873F2D80")]
	public static uint CAEIELCBGNB(uint KPPEBBOFEKD, uint EJAKPDCBGAD, uint NECLOIHPKAD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x73F2FD0", Offset = "0x73F23D0", VA = "0x1873F2FD0")]
	public static uint3 IEAKMEKHPGN(float3 OGKCMCMHLOD, float3 FJLHHNBLHNM, float3 FAINHKELBGC)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x73F2D90", Offset = "0x73F2190", VA = "0x1873F2D90")]
	public static void CIKHHOJKKJL(float3 JMINBDHIFFN, float3 NOLCMFGHKLB, float3 DMHJAHAAKCF, float JBJFBPBLEOH, [Out] uint3 OCIMOHKNNMO, [Out] uint3 PMOPLCCELOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x73F3370", Offset = "0x73F2770", VA = "0x1873F3370")]
	public static void OMJHIGIJEHO(float3 KDBAMKLAIEG, float3 IGNNGBDBJBF, float GOLOFNEFPEG, float AIKJIEJJFMD, [Out] float3 LGFBEOALLIP, [Out] float JBJFBPBLEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x73F31D0", Offset = "0x73F25D0", VA = "0x1873F31D0")]
	private static float3 MNMHFIOHPPP(float3 CNEFHFCPAOJ, float3 ODDBHGBDJPN, float3 KBFKCCELGHP, float3 PEOFCLGKNAH)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class NNNGEBKLBCE
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly LDGDBHIGNCI MJHDPMGAFDE;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly LDGDBHIGNCI DKHEDJMHEDM;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly LDGDBHIGNCI JIFPJIKNPHG;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly LDGDBHIGNCI CDBJFEMPLCJ;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class BELKPPPHJCP
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static Mesh ABCEJOPDDJN;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x73EE7A0", Offset = "0x73EDBA0", VA = "0x1873EE7A0")]
	public static Mesh EHMOCFDJBID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x73EEC10", Offset = "0x73EE010", VA = "0x1873EEC10")]
	public static Matrix4x4 PHILBCHOAKB(Camera EHNMIPIEOKK, bool OPJHMIENEMC = false, bool CAOFJEFDPBF = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x73EE850", Offset = "0x73EDC50", VA = "0x1873EE850")]
	private static Mesh JCKNDCIPKDP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2311772
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x73F9530", Offset = "0x73F8930", VA = "0x1873F9530")]
	public static void CJDJNHJPHKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x73F95C0", Offset = "0x73F89C0", VA = "0x1873F95C0")]
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
