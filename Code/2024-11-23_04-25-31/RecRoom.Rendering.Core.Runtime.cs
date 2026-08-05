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
	public class LogRegistrationIndex : IGBHOMLLHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x749E8F0", Offset = "0x749D2F0", VA = "0x18749E8F0", Slot = "4")]
		public override void KFMGLABNFNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
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
		public enum EDEBPBBNODC
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface DKLGDCHIONJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void EJNOFFABAJA(ScriptableRenderContext KMDNOIPDFGB, List<Camera> HKJBCOCFACO);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface AKACIGLCJPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void EJNOFFABAJA(ScriptableRenderContext KMDNOIPDFGB, RenderingData GLBKAKPGMBH);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class KABOJBJMBOE : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x749BFC0", Offset = "0x749A9C0", VA = "0x18749BFC0")]
			public KABOJBJMBOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x749BF60", Offset = "0x749A960", VA = "0x18749BF60", Slot = "9")]
			public override void Execute(ScriptableRenderContext KMDNOIPDFGB, RenderingData GLBKAKPGMBH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private KABOJBJMBOE _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<DKLGDCHIONJ> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<DKLGDCHIONJ> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<AKACIGLCJPL> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<AKACIGLCJPL> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x74A1250", Offset = "0x749FC50", VA = "0x1874A1250")]
		public static void KEEEGKPLMME(EDEBPBBNODC ACNPPHLJKKA, DKLGDCHIONJ FMNGCIINIAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x74A1E40", Offset = "0x74A0840", VA = "0x1874A1E40")]
		public static void PHLFHNDOBDI(EDEBPBBNODC ACNPPHLJKKA, DKLGDCHIONJ FMNGCIINIAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x74A1310", Offset = "0x749FD10", VA = "0x1874A1310")]
		public static void KEEEGKPLMME(EDEBPBBNODC ACNPPHLJKKA, AKACIGLCJPL ACNOHAKADEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x74A1D80", Offset = "0x74A0780", VA = "0x1874A1D80")]
		public static void PHLFHNDOBDI(EDEBPBBNODC ACNPPHLJKKA, AKACIGLCJPL ACNOHAKADEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x74A0F60", Offset = "0x749F960", VA = "0x1874A0F60", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x74A0E50", Offset = "0x749F850", VA = "0x1874A0E50", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer OJIILOMBDFN, RenderingData GLBKAKPGMBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x74A1140", Offset = "0x749FB40", VA = "0x1874A1140", Slot = "9")]
		protected override void Dispose(bool PKNPDEHDNLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x74A13D0", Offset = "0x749FDD0", VA = "0x1874A13D0")]
		private static void MDHFFGGMBJH(ScriptableRenderContext KMDNOIPDFGB, List<Camera> HKJBCOCFACO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x74A0EF0", Offset = "0x749F8F0", VA = "0x1874A0EF0")]
		private static void CJOCLFIFAOO(ScriptableRenderContext KMDNOIPDFGB, List<Camera> HKJBCOCFACO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x74A18C0", Offset = "0x74A02C0", VA = "0x1874A18C0")]
		private static void NDJPIAICIIB(ScriptableRenderContext KMDNOIPDFGB, RenderingData GLBKAKPGMBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC0C0", Offset = "0x10FAAC0", VA = "0x1810FC0C0")]
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
		private class IIPKBKKAJHM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool BAGGHGOCMFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<GOCMFMDNJEK> AFGJHJGCCAO;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x749BED0", Offset = "0x749A8D0", VA = "0x18749BED0")]
			public IIPKBKKAJHM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class NEEIPFEHBFD : PreRenderManager.AKACIGLCJPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string PDEDBBAIKFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler KHKJAIEADDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly IIPKBKKAJHM AHIIEBDGDDC;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x749F3B0", Offset = "0x749DDB0", VA = "0x18749F3B0")]
			public NEEIPFEHBFD(IIPKBKKAJHM PNKMIFDCNPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x749EFB0", Offset = "0x749D9B0", VA = "0x18749EFB0", Slot = "4")]
			public void EJNOFFABAJA(ScriptableRenderContext KMDNOIPDFGB, RenderingData GLBKAKPGMBH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class FANKNPCEFND : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string MMBKFNBIPBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly IIPKBKKAJHM PNKMIFDCNPC;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x749A300", Offset = "0x7498D00", VA = "0x18749A300")]
			public FANKNPCEFND(RenderPassEvent JBPJIGBJHOK, IIPKBKKAJHM PNKMIFDCNPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7499FF0", Offset = "0x74989F0", VA = "0x187499FF0", Slot = "9")]
			public override void Execute(ScriptableRenderContext KMDNOIPDFGB, RenderingData GLBKAKPGMBH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<GOCMFMDNJEK> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private NEEIPFEHBFD fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private FANKNPCEFND fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private IIPKBKKAJHM sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x749A480", Offset = "0x7498E80", VA = "0x18749A480", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x749A800", Offset = "0x7499200", VA = "0x18749A800", Slot = "9")]
		protected override void Dispose(bool PKNPDEHDNLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x749A3F0", Offset = "0x7498DF0", VA = "0x18749A3F0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer OJIILOMBDFN, RenderingData GLBKAKPGMBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x10FC0C0", Offset = "0x10FAAC0", VA = "0x1810FC0C0")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GOCMFMDNJEK
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DEJKCLHKNPD(CommandBuffer IEJCGEFCHFM, Camera ALHGNMGOIIM, [NotNull] UniversalAdditionalCameraData ANMHAHMJFKK, bool ANHCAAKCHDI);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DJIPJIKAINH(Camera ALHGNMGOIIM, CommandBuffer LJPLEKNFOKJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GBJJJDDJIMM
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool GOGIIOPNCMN;
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
		private OKDADIANHKK _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private LOLOAIADDMN _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x749E5D0", Offset = "0x749CFD0", VA = "0x18749E5D0", Slot = "9")]
		protected override void Dispose(bool ONGNOBALICL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x749E640", Offset = "0x749D040", VA = "0x18749E640")]
		private void FDKNPFJCMNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x749E280", Offset = "0x749CC80", VA = "0x18749E280", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer OJIILOMBDFN, RenderingData GLBKAKPGMBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x10FC0C0", Offset = "0x10FAAC0", VA = "0x1810FC0C0")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FCDLABFCCCA
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x749A3E0", Offset = "0x7498DE0", VA = "0x18749A3E0")]
	public static int HDFFDJEILLB(bool ACHBOHDFNEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x154BB80", Offset = "0x154A580", VA = "0x18154BB80")]
	public static int LEMDHFODMAF(bool ACHBOHDFNEJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct OLIDLDLCAGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType MBDEENEGEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float JBJCPCAPDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float MLLPFLJHOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float IIKHJLONPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 ACIAPDJAPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 GONCBMMCAIO;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct MOFCIDELKAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort EEANDMPKBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float MOJGMAGGJAE;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct BBJILCAMIDE : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<OLIDLDLCAGI> JKKDOJHONID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 HMIDHNDECNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 DCHOHCIHLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, MOFCIDELKAI>.ParallelWriter CPBJAFFPFJC;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7497F00", Offset = "0x7496900", VA = "0x187497F00", Slot = "4")]
	public void Execute(int EEANDMPKBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7498530", Offset = "0x7496F30", VA = "0x187498530")]
	private void HHPGPLIGGIO(uint3 DGEGIIEBJMD, uint3 IFJFBFAHDCB, ushort EEANDMPKBKG, float3 OPIIPFDKANK, float AEIELGNBLCC, float BBHPGKPNCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x74988A0", Offset = "0x74972A0", VA = "0x1874988A0")]
	private void IEHFDDCJBNL(uint3 DGEGIIEBJMD, uint3 IFJFBFAHDCB, ushort EEANDMPKBKG, float3 OPIIPFDKANK, float3 PAJOINGONGP, float3 CLOIIFNJPGJ, float AEIELGNBLCC, float HJMPPODLACC, float BBHPGKPNCAJ, float CJGDABJJLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7498440", Offset = "0x7496E40", VA = "0x187498440")]
	private float3 GIPPNLFGNJJ(uint3 DGEGIIEBJMD, float3 OPIIPFDKANK)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7497EE0", Offset = "0x74968E0", VA = "0x187497EE0")]
	private float AFJLKDOFADI(float JBJCPCAPDLL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7498D50", Offset = "0x7497750", VA = "0x187498D50")]
	private float MENHGNMIIMF(float3 EEPDCIGPHFP, float3 CLOIIFNJPGJ, float HJMPPODLACC, float BBHPGKPNCAJ)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct AIEFFFKLPHB : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, MOFCIDELKAI> CPBJAFFPFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint LHHJJKNFPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int DEBBLMMPFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int PEHFOKBIINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> DBBBIFEOLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> JDGNINKBADC;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7497BD0", Offset = "0x74965D0", VA = "0x187497BD0", Slot = "4")]
	public void Execute(int MEKMEFAGGNO, int AHKMKCDLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7497D70", Offset = "0x7496770", VA = "0x187497D70")]
	private void NKCBFEGKLEJ(int LPMJLENMOKH, ushort MNDENNEPLGP, int NMMCLMOIDEH, MOFCIDELKAI OMHCCKHPMIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct OIJIKKEMJNG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, MOFCIDELKAI> CPBJAFFPFJC;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x749F470", Offset = "0x749DE70", VA = "0x18749F470", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class OKDADIANHKK : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool NMMIJBNDPNC;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float OMNOKKDGOIC = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int CAFHHKGPFGI = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int EEEMIDCKJPL = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private BBJILCAMIDE LNBIFKMOFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private AIEFFFKLPHB CPEFNNHAJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private OIJIKKEMJNG LGDGNOGNDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, MOFCIDELKAI> DGNHMMOPBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private EFIFOHOJPPO KDBHAANOCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool GLAKINEAMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int GKLNMCKEAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<OLIDLDLCAGI> NNIAIHCJHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle BKNCLHILJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle NHGJGHGEFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool MNBCBODGOKA;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x74A0370", Offset = "0x749ED70", VA = "0x1874A0370")]
	public OKDADIANHKK(RenderPassEvent JBPJIGBJHOK, ComputeShader ENKDMPPLGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x749F7F0", Offset = "0x749E1F0", VA = "0x18749F7F0")]
	private void DOOCDMFFJCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x749F710", Offset = "0x749E110", VA = "0x18749F710")]
	public void DMAPKNCAIAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x307A670", Offset = "0x3079070", VA = "0x18307A670")]
	public static void AMKDMBICBFH<T>(NativeArray<T> LOCJOHPCANM, int LEGDMNLNDAK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x749FF60", Offset = "0x749E960", VA = "0x18749FF60")]
	public void LOAACMLCBJD(CameraData ANMHAHMJFKK, LightData IDJHPLABNOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x749FBF0", Offset = "0x749E5F0", VA = "0x18749FBF0")]
	private void JCCAMODPLML(LightData IDJHPLABNOH, NativeArray<OLIDLDLCAGI> PEIHDEILDIK, int DENJLOMDEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x749F4D0", Offset = "0x749DED0", VA = "0x18749F4D0")]
	private void CDELKCLOKCE(CameraData ANMHAHMJFKK, LightData IDJHPLABNOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x749FA60", Offset = "0x749E460", VA = "0x18749FA60")]
	private void GEMBIKLCNNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x749F960", Offset = "0x749E360", VA = "0x18749F960")]
	private void FJHHDLLHINB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x749F4B0", Offset = "0x749DEB0", VA = "0x18749F4B0")]
	private void ACBAABJCIJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x749FF30", Offset = "0x749E930", VA = "0x18749FF30")]
	private void KMJBDMDLJCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x749F860", Offset = "0x749E260", VA = "0x18749F860", Slot = "9")]
	public override void Execute(ScriptableRenderContext KMDNOIPDFGB, RenderingData GLBKAKPGMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x74A0300", Offset = "0x749ED00", VA = "0x1874A0300", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer LJPLEKNFOKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class LOLOAIADDMN : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort MGLEOOHOGEN = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float OMNOKKDGOIC = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly EFIFOHOJPPO KDBHAANOCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int FLGIGHECDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private OLIDLDLCAGI[] NNIAIHCJHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 ACMDEICGLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 NDONCJAGFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint KLBKMPJFINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int JEBACJKCJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int JPEHGEIFEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> DBBBIFEOLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> JDGNINKBADC;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x749E1D0", Offset = "0x749CBD0", VA = "0x18749E1D0")]
	public LOLOAIADDMN(RenderPassEvent JBPJIGBJHOK, ComputeShader ENKDMPPLGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x749DDB0", Offset = "0x749C7B0", VA = "0x18749DDB0")]
	public void LOAACMLCBJD(CameraData ANMHAHMJFKK, LightData IDJHPLABNOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x749C500", Offset = "0x749AF00", VA = "0x18749C500")]
	private void DAIEAJJNGAE(CameraData ANMHAHMJFKK, LightData IDJHPLABNOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x749C700", Offset = "0x749B100", VA = "0x18749C700")]
	public void DMAPKNCAIAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x749D2A0", Offset = "0x749BCA0", VA = "0x18749D2A0")]
	private void JCCAMODPLML(LightData IDJHPLABNOH, OLIDLDLCAGI[] PEIHDEILDIK, int DENJLOMDEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x749DBA0", Offset = "0x749C5A0", VA = "0x18749DBA0")]
	private void JLAEJKPPNCL(int MEKMEFAGGNO, int AHKMKCDLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x749E1A0", Offset = "0x749CBA0", VA = "0x18749E1A0")]
	private void PLODKBONIPJ(int MEKMEFAGGNO, int FPDJICFHLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x749CD10", Offset = "0x749B710", VA = "0x18749CD10")]
	private ushort IDKPIHIAAJD(int MEKMEFAGGNO)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x749C490", Offset = "0x749AE90", VA = "0x18749C490")]
	private void APFHOINADFG(int MEKMEFAGGNO, int AHKMKCDLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x749DC50", Offset = "0x749C650", VA = "0x18749DC50")]
	private void KCOAMLLDOHP(int LEGDMNLNDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x749DF20", Offset = "0x749C920", VA = "0x18749DF20")]
	private void NACKEBDHKOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x749C720", Offset = "0x749B120", VA = "0x18749C720", Slot = "9")]
	public override void Execute(ScriptableRenderContext KMDNOIPDFGB, RenderingData GLBKAKPGMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x749E170", Offset = "0x749CB70", VA = "0x18749E170", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer LJPLEKNFOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x749D5F0", Offset = "0x749BFF0", VA = "0x18749D5F0")]
	private void JCGDKKKJJIH(int EEANDMPKBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x749C900", Offset = "0x749B300", VA = "0x18749C900")]
	private void HHPGPLIGGIO(uint3 DGEGIIEBJMD, uint3 IFJFBFAHDCB, ushort EEANDMPKBKG, float3 OPIIPFDKANK, float AEIELGNBLCC, float BBHPGKPNCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x749CD50", Offset = "0x749B750", VA = "0x18749CD50")]
	private void IEHFDDCJBNL(uint3 DGEGIIEBJMD, uint3 IFJFBFAHDCB, ushort EEANDMPKBKG, float3 OPIIPFDKANK, float3 PAJOINGONGP, float3 CLOIIFNJPGJ, float AEIELGNBLCC, float HJMPPODLACC, float BBHPGKPNCAJ, float CJGDABJJLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x749DCC0", Offset = "0x749C6C0", VA = "0x18749DCC0")]
	private void LDDDIKDJHOB(ushort EEANDMPKBKG, uint NEOANPIBJCH, float LMGADHBHLCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x749C800", Offset = "0x749B200", VA = "0x18749C800")]
	private float3 GIPPNLFGNJJ(uint3 DGEGIIEBJMD, float3 OPIIPFDKANK)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7497EE0", Offset = "0x74968E0", VA = "0x187497EE0")]
	private float AFJLKDOFADI(float JBJCPCAPDLL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7498D50", Offset = "0x7497750", VA = "0x187498D50")]
	private float MENHGNMIIMF(float3 EEPDCIGPHFP, float3 CLOIIFNJPGJ, float HJMPPODLACC, float BBHPGKPNCAJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x749DFE0", Offset = "0x749C9E0", VA = "0x18749DFE0")]
	private void NKCBFEGKLEJ(int LPMJLENMOKH, ushort MNDENNEPLGP, int NMMCLMOIDEH, MOFCIDELKAI OMHCCKHPMIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class EFIFOHOJPPO
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class PCAGAIHFGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int KGPHMJHINHB;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int PKINDGNGBDF;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int KHMAOLMBCBG;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int AKONACAHHJK;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int CLEJEIMPNOA;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int KIPMFLDBHMP;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int EBOKEKKFACL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int HDMCPEPBHFC = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int ODEPABNCMJM = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int LCNGABIDONM = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int CGDOAOLPOMM = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int IBCBLPNIKFP = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int JPKFLMLNOBN = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int OFNKLOPCHCD = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool MGNDFEJKHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer PGEAALCHOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture OLJGFAMEAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int KJACBKONOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int PEBNHFFNKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int PCIIKJIGPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int GHHNODNPODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int IEJIEHKHMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader IAHGGMNNBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int NOKKLLGACML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int PJOIPAOAFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 JLPODAPPOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 OIJDLFHDIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> HOBKCJOMNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> ELDHKAIJKED;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> NHLFGECNBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x13B4540", Offset = "0x13B2F40", VA = "0x1813B4540")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> OPFAGAGPKJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1879CA0", Offset = "0x18786A0", VA = "0x181879CA0")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int KLOBIPAHMAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xC6F620", Offset = "0xC6E020", VA = "0x180C6F620")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int IOEKICEEJGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8AF7D0", Offset = "0x8AE1D0", VA = "0x1808AF7D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader PLLMELAJNCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7499F40", Offset = "0x7498940", VA = "0x187499F40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7499B40", Offset = "0x7498540", VA = "0x187499B40")]
	public void JFMJGMNFMJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7499C30", Offset = "0x7498630", VA = "0x187499C30")]
	public void LHMDGNDKHBE(CameraData ANMHAHMJFKK, LightData IDJHPLABNOH, int BLBLNLCMPDP, bool ACHBOHDFNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2D46FA0", Offset = "0x2D459A0", VA = "0x182D46FA0")]
	private void AMKDMBICBFH<T>(NativeArray<T> LOCJOHPCANM, int LEGDMNLNDAK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7498E10", Offset = "0x7497810", VA = "0x187498E10")]
	public void BECIJBAKHCH(CommandBuffer LJPLEKNFOKJ, ScriptableRenderContext KMDNOIPDFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7499960", Offset = "0x7498360", VA = "0x187499960")]
	private static void JCDFLCANMLG(int HOJMDCMLAAI, CommandBuffer LJPLEKNFOKJ, RenderBuffer GKHKCOGOILK, ComputeBuffer CFFLCDKBLDB, ComputeShader MJNDGGDHFLO, int JNCOIGLAAMN, int AGGEOFPJJFD, int DBOPDPPINPC, int DPFNGMBBNAO, int KFBILMKGIDJ, int AENHLLPDPKD, int OFKOCNFMOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7499650", Offset = "0x7498050", VA = "0x187499650")]
	public void JCCPBKGGMME(CommandBuffer LJPLEKNFOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x74993F0", Offset = "0x7497DF0", VA = "0x1874993F0")]
	private RenderTexture EFMKDIMCDAC(RenderTexture PACOOJIAKCD, int JNCOIGLAAMN, int AGGEOFPJJFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x74995D0", Offset = "0x7497FD0", VA = "0x1874995D0")]
	public void HGLILPEPMBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7499160", Offset = "0x7497B60", VA = "0x187499160")]
	public void BIOLJELAOKC(int IMDJADGMCCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7499FD0", Offset = "0x74989D0", VA = "0x187499FD0")]
	public EFIFOHOJPPO()
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
		public struct PNGPNPKBFAB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float FKHEGHKGOOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float BPPGCJNACMB;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class KLEPBLCIHAG : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string EAHAAANHNIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler FHLBIOHHNBL;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int MHJJMHDCECG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material FOPBLPLLNEO;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x749C3B0", Offset = "0x749ADB0", VA = "0x18749C3B0")]
			public KLEPBLCIHAG(RenderPassEvent JBPJIGBJHOK, Material FLBCMGELMBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x749BFE0", Offset = "0x749A9E0", VA = "0x18749BFE0", Slot = "9")]
			public override void Execute(ScriptableRenderContext KMDNOIPDFGB, RenderingData GLBKAKPGMBH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static PNGPNPKBFAB CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private KLEPBLCIHAG m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x749EC50", Offset = "0x749D650", VA = "0x18749EC50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x749EC00", Offset = "0x749D600", VA = "0x18749EC00")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x749EA50", Offset = "0x749D450", VA = "0x18749EA50", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x749E980", Offset = "0x749D380", VA = "0x18749E980", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer OJIILOMBDFN, RenderingData GLBKAKPGMBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x10FC0C0", Offset = "0x10FAAC0", VA = "0x1810FC0C0")]
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
		public struct MKMLOJAIDOD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float NBLMCHCCCJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color IPFKKGBFEAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh EOFOCDHCDDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve GEEGMBMONEO;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class PABKJJKCHKN : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string EAHAAANHNIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler FHLBIOHHNBL;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int MNFFBBHLNJO;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int FKKDPNDEEMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material FOPBLPLLNEO;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x74A06C0", Offset = "0x749F0C0", VA = "0x1874A06C0")]
			public PABKJJKCHKN(RenderPassEvent JBPJIGBJHOK, Material FLBCMGELMBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x74A0420", Offset = "0x749EE20", VA = "0x1874A0420", Slot = "9")]
			public override void Execute(ScriptableRenderContext KMDNOIPDFGB, RenderingData GLBKAKPGMBH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static MKMLOJAIDOD CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private PABKJJKCHKN m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x749EF60", Offset = "0x749D960", VA = "0x18749EF60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x749EDB0", Offset = "0x749D7B0", VA = "0x18749EDB0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x749ECA0", Offset = "0x749D6A0", VA = "0x18749ECA0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer OJIILOMBDFN, RenderingData GLBKAKPGMBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x10FC0C0", Offset = "0x10FAAC0", VA = "0x1810FC0C0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string NCFNKPKOGNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool BLHHPAJBDHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer LJPLEKNFOKJ, ScriptableRenderContext KMDNOIPDFGB, RenderingData GLBKAKPGMBH);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA40", Offset = "0x8AB440", VA = "0x1808ACA40")]
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
		private class AAKHGBIOFJH : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool DIJFHMJKNFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> IICGFKNNHNH;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> CHMKMGKPLNK;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7497B20", Offset = "0x7496520", VA = "0x187497B20")]
			public AAKHGBIOFJH(RenderPassEvent JBPJIGBJHOK, bool DIJFHMJKNFE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x74976D0", Offset = "0x74960D0", VA = "0x1874976D0")]
			public bool KKEBDKBINBN(CameraData ANMHAHMJFKK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7497500", Offset = "0x7495F00", VA = "0x187497500", Slot = "9")]
			public override void Execute(ScriptableRenderContext KMDNOIPDFGB, RenderingData GLBKAKPGMBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x74979B0", Offset = "0x74963B0", VA = "0x1874979B0")]
			private void MJHKAGHPLLJ(PerCameraRenderEffect APLOHJHJEAE, ScriptableRenderContext KMDNOIPDFGB, RenderingData GLBKAKPGMBH)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private AAKHGBIOFJH m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private AAKHGBIOFJH m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x74A0A90", Offset = "0x749F490", VA = "0x1874A0A90", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x74A0A00", Offset = "0x749F400", VA = "0x1874A0A00", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer OJIILOMBDFN, RenderingData GLBKAKPGMBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x10FC0C0", Offset = "0x10FAAC0", VA = "0x1810FC0C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x74A0CE0", Offset = "0x749F6E0", VA = "0x1874A0CE0")]
		public static void OFHFKHKOADH(ScriptableRenderPass ACMNIEDCMHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x74A0B40", Offset = "0x749F540", VA = "0x1874A0B40", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer OJIILOMBDFN, RenderingData GLBKAKPGMBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x10FC0C0", Offset = "0x10FAAC0", VA = "0x1810FC0C0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class IFGEODGCBPP
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 ILGBOHMHHBG;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 OIPHNEFGAOF;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 HFDMBCJPMPM;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 IEFKINHNDGC;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 FLCCDBBGNOJ;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x749B960", Offset = "0x749A360", VA = "0x18749B960")]
	public static uint MHNFEJNPANH(uint PMBJFHIMJKC, uint HBABDGBANAP, uint BDLPODAGJJB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x749BBB0", Offset = "0x749A5B0", VA = "0x18749BBB0")]
	public static uint3 OJIPHGEOMCJ(float3 PCPIJKGKPCE, float3 HMIDHNDECNL, float3 DCHOHCIHLNO)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x749B970", Offset = "0x749A370", VA = "0x18749B970")]
	public static void NAOMMPFBMII(float3 DFHDKDJBHMI, float3 MFACGMIDCFP, float3 NLAOELFOADA, float JNPCONGOFCD, [Out] uint3 CIOGOLCGGHE, [Out] uint3 PPCNLDEDKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x749B490", Offset = "0x7499E90", VA = "0x18749B490")]
	public static void KMOJKKALGID(float3 LKJMPEMLFOL, float3 CEKGBCACHMG, float MLLPFLJHOGO, float AGHLIOADMGE, [Out] float3 AOLMAPLOJMH, [Out] float JNPCONGOFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x749B2F0", Offset = "0x7499CF0", VA = "0x18749B2F0")]
	private static float3 JAIFLMFLDOF(float3 MCHPLADIFKB, float3 NEGJCNOGDHP, float3 GACIPJLAAAG, float3 NPAOLFGFNOI)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class POMALCKNLLP
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly KLEHBGEJMBN LMBDKEEJDAM;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly KLEHBGEJMBN LIENGCEMHKH;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly KLEHBGEJMBN BOBFHJBEILD;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly KLEHBGEJMBN DJFJBGJMMII;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly KLEHBGEJMBN KLODIEDBOGC;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class IABJBGODGNO
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh PFKKGDBNHJI;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x749ADB0", Offset = "0x74997B0", VA = "0x18749ADB0")]
	public static Mesh IIKEFLKJKNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x749AE50", Offset = "0x7499850", VA = "0x18749AE50")]
	public static Matrix4x4 KCKEKLDFDAO(Camera ALHGNMGOIIM, bool AHFCBPCKBLE = false, bool OMFOODBHHDN = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x749A9F0", Offset = "0x74993F0", VA = "0x18749A9F0")]
	private static Mesh AFOLACGNIKB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2436714501
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x74A2120", Offset = "0x74A0B20", VA = "0x1874A2120")]
	public static void KHCKEMENAFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x74A2110", Offset = "0x74A0B10", VA = "0x1874A2110")]
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
