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
	public class LogRegistrationIndex : LALFEIIPPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x844A4D0", Offset = "0x84496D0", VA = "0x18844A4D0", Slot = "4")]
		public override void ELDCOJNOKAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
		public enum PHHEBHBHPFM
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface GJDGJGLELPG
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void FAIPCIDKNKC(ScriptableRenderContext BKDMJHGCDEA, List<Camera> HEIMLAFDAIF);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface CNKCCFDGJFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void FAIPCIDKNKC(ScriptableRenderContext BKDMJHGCDEA, RenderingData DLHINPMCACP);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class BBNFDLNDGBH : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8442090", Offset = "0x8441290", VA = "0x188442090")]
			public BBNFDLNDGBH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8442030", Offset = "0x8441230", VA = "0x188442030", Slot = "9")]
			public override void Execute(ScriptableRenderContext BKDMJHGCDEA, RenderingData DLHINPMCACP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private BBNFDLNDGBH _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<GJDGJGLELPG> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<GJDGJGLELPG> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<CNKCCFDGJFH> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<CNKCCFDGJFH> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x844C510", Offset = "0x844B710", VA = "0x18844C510")]
		public static void LFMBHPEEHDG(PHHEBHBHPFM CNLJNFDHJED, GJDGJGLELPG HAIOCBDPBNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x844C2D0", Offset = "0x844B4D0", VA = "0x18844C2D0")]
		public static void HLBGIPEOHEM(PHHEBHBHPFM CNLJNFDHJED, GJDGJGLELPG HAIOCBDPBNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x844C450", Offset = "0x844B650", VA = "0x18844C450")]
		public static void LFMBHPEEHDG(PHHEBHBHPFM CNLJNFDHJED, CNKCCFDGJFH LDAOBEGMLNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x844C390", Offset = "0x844B590", VA = "0x18844C390")]
		public static void HLBGIPEOHEM(PHHEBHBHPFM CNLJNFDHJED, CNKCCFDGJFH LDAOBEGMLNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x844B630", Offset = "0x844A830", VA = "0x18844B630", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x844B520", Offset = "0x844A720", VA = "0x18844B520", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer HLIOBIEFOPB, RenderingData DLHINPMCACP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x844BCD0", Offset = "0x844AED0", VA = "0x18844BCD0", Slot = "9")]
		protected override void Dispose(bool DLKHEECPKFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x844BDE0", Offset = "0x844AFE0", VA = "0x18844BDE0")]
		private static void EMDENEDBOGI(ScriptableRenderContext BKDMJHGCDEA, List<Camera> HEIMLAFDAIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x844B5C0", Offset = "0x844A7C0", VA = "0x18844B5C0")]
		private static void CCPIKHDPCMC(ScriptableRenderContext BKDMJHGCDEA, List<Camera> HEIMLAFDAIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x844B810", Offset = "0x844AA10", VA = "0x18844B810")]
		private static void DDNHJOKCIEI(ScriptableRenderContext BKDMJHGCDEA, RenderingData DLHINPMCACP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x175F0A0", Offset = "0x175E2A0", VA = "0x18175F0A0")]
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
		private class JJFFCHGAGAJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool EGECGKJPBFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<NCIAKACLOFN> IAAJGHMLABE;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x84487A0", Offset = "0x84479A0", VA = "0x1884487A0")]
			public JJFFCHGAGAJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class ANNGHGLGNGN : PreRenderManager.CNKCCFDGJFH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string GDAOKLKADFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler ICINOHHKGHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly JJFFCHGAGAJ KDHCNDOMLBC;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8441F70", Offset = "0x8441170", VA = "0x188441F70")]
			public ANNGHGLGNGN(JJFFCHGAGAJ PBMFDFHPGIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8441B70", Offset = "0x8440D70", VA = "0x188441B70", Slot = "4")]
			public void FAIPCIDKNKC(ScriptableRenderContext BKDMJHGCDEA, RenderingData DLHINPMCACP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class FBDALKNGCHO : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string BKFEPGIBMEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly JJFFCHGAGAJ PBMFDFHPGIA;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x84478C0", Offset = "0x8446AC0", VA = "0x1884478C0")]
			public FBDALKNGCHO(RenderPassEvent INMBPJOALLG, JJFFCHGAGAJ PBMFDFHPGIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x84475B0", Offset = "0x84467B0", VA = "0x1884475B0", Slot = "9")]
			public override void Execute(ScriptableRenderContext BKDMJHGCDEA, RenderingData DLHINPMCACP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<NCIAKACLOFN> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private ANNGHGLGNGN fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private FBDALKNGCHO fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private JJFFCHGAGAJ sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8447A30", Offset = "0x8446C30", VA = "0x188447A30", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8447DB0", Offset = "0x8446FB0", VA = "0x188447DB0", Slot = "9")]
		protected override void Dispose(bool DLKHEECPKFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x84479A0", Offset = "0x8446BA0", VA = "0x1884479A0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer HLIOBIEFOPB, RenderingData DLHINPMCACP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x175F0A0", Offset = "0x175E2A0", VA = "0x18175F0A0")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NCIAKACLOFN
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IKOECLJCNAB(CommandBuffer BGIJAFDADFD, Camera HEKBGKAPFJN, [NotNull] UniversalAdditionalCameraData EAOCBBOMEFH, bool OEGEHFICFCA);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ECIKFIGHEHG(Camera HEKBGKAPFJN, CommandBuffer MNOPFHLOEGH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class NPINOCKEIEH
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool FGPOKCJEPCC;
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
		private BJLNAKIECJK _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private EHKDEAHFIFE _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x844A1A0", Offset = "0x84493A0", VA = "0x18844A1A0", Slot = "9")]
		protected override void Dispose(bool HDCBMHHKGHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x844A210", Offset = "0x8449410", VA = "0x18844A210")]
		private void JPDODIMPMEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8449E50", Offset = "0x8449050", VA = "0x188449E50", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer HLIOBIEFOPB, RenderingData DLHINPMCACP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x175F0A0", Offset = "0x175E2A0", VA = "0x18175F0A0")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GIBKPJEHBDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8447FA0", Offset = "0x84471A0", VA = "0x188447FA0")]
	public static int NIMOPKNEPOC(bool EDJBGPFCEJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1C03210", Offset = "0x1C02410", VA = "0x181C03210")]
	public static int FPPGOIBIEPF(bool EDJBGPFCEJO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct GCGNJCAEFHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType LPLCENEABNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float EMMAGGPJAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float CFPNMKPLIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float IIHNMPBHEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 IJDBLOIPCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 EJJKKCPOBJG;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct FBCBOOKEIPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort CJDOKLGDLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float NIHBINGDAJC;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct KHBOADANFMF : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<GCGNJCAEFHD> HKHAACNGAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 HJLPAEKPMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 HBELJKDGNOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, FBCBOOKEIPE>.ParallelWriter PFILFDBNAJB;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8448BB0", Offset = "0x8447DB0", VA = "0x188448BB0", Slot = "4")]
	public void Execute(int CJDOKLGDLDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8449690", Offset = "0x8448890", VA = "0x188449690")]
	private void OPKMNDDBFFJ(uint3 IKJFHGAGMIG, uint3 PDLPOBFFPAE, ushort CJDOKLGDLDD, float3 BBGIGJBAKAM, float OKJPOMFOBEH, float AKCCEJFMJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x84491E0", Offset = "0x84483E0", VA = "0x1884491E0")]
	private void ODLJOPDGJCI(uint3 IKJFHGAGMIG, uint3 PDLPOBFFPAE, ushort CJDOKLGDLDD, float3 BBGIGJBAKAM, float3 JIKGCBBIDNN, float3 NGMKHPAFPMG, float OKJPOMFOBEH, float FJKAJFCNBKO, float AKCCEJFMJFO, float GBCPPCKEHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x84490F0", Offset = "0x84482F0", VA = "0x1884490F0")]
	private float3 KKMOHLEJLCM(uint3 IKJFHGAGMIG, float3 BBGIGJBAKAM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8445F90", Offset = "0x8445190", VA = "0x188445F90")]
	private float GEKLNEGKOAC(float EMMAGGPJAFH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8445AA0", Offset = "0x8444CA0", VA = "0x188445AA0")]
	private float CCHKEMKDDAP(float3 ENCKGALINFP, float3 NGMKHPAFPMG, float FJKAJFCNBKO, float AKCCEJFMJFO)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct KODJGGDBKPK : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, FBCBOOKEIPE> PFILFDBNAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint FBFBODDBGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int JOOHGDDDKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int LMOBHGNFFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> OJBCFAFAEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> EPFDKHPIIKH;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8449A00", Offset = "0x8448C00", VA = "0x188449A00", Slot = "4")]
	public void Execute(int BFILPENBCFK, int LLHOJHAPPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8449BA0", Offset = "0x8448DA0", VA = "0x188449BA0")]
	private void MDABCDBFKAL(int NCGDENNNIKG, ushort MEBCKHLPIJP, int KHJGDLPPLCN, FBCBOOKEIPE AJPBMIIHMIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct ODCIHDBNAAH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, FBCBOOKEIPE> PFILFDBNAJB;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x844B040", Offset = "0x844A240", VA = "0x18844B040", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BJLNAKIECJK : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool OJKPKOJMINB;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float PONAJNLMIGH = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int NMCKOBLJGLL = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int IHNDPAKJKMI = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private KHBOADANFMF EJKLBIMPDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private KODJGGDBKPK MJLCKHPLAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private ODCIHDBNAAH MEPHHJIBNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, FBCBOOKEIPE> IGLELNCNPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private DLOMDMNAEGB APPBLOKOEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool AEFBNLCKLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int BMPJLEJNFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<GCGNJCAEFHD> KLFAJDMLNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle IFDONGBPAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle GKKJOBPDAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool CDGFGHCPILP;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8443870", Offset = "0x8442A70", VA = "0x188443870")]
	public BJLNAKIECJK(RenderPassEvent INMBPJOALLG, ComputeShader DMJLPGLKBFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x84429B0", Offset = "0x8441BB0", VA = "0x1884429B0")]
	private void AHDNGBEOMLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8443720", Offset = "0x8442920", VA = "0x188443720")]
	public void NIOOPBNOALC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x378E700", Offset = "0x378D900", VA = "0x18378E700")]
	public static void EKFMLNKPIML<T>(NativeArray<T> KBILCKNPAKO, int GCFCAGDGDIN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8442FA0", Offset = "0x84421A0", VA = "0x188442FA0")]
	public void DHFGHLNEAFE(CameraData EAOCBBOMEFH, LightData MIAJMAMEBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8442C60", Offset = "0x8441E60", VA = "0x188442C60")]
	private void BGKILEOFJCP(LightData MIAJMAMEBPK, NativeArray<GCGNJCAEFHD> DAELBAHDDLG, int HFOKOEGCDEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8442A20", Offset = "0x8441C20", VA = "0x188442A20")]
	private void AHLLHPJMOHP(CameraData EAOCBBOMEFH, LightData MIAJMAMEBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8443540", Offset = "0x8442740", VA = "0x188443540")]
	private void HADEOAIPHJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8443440", Offset = "0x8442640", VA = "0x188443440")]
	private void FOIKHPCGPPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x84436D0", Offset = "0x84428D0", VA = "0x1884436D0")]
	private void ILCHKDIPMAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x84436F0", Offset = "0x84428F0", VA = "0x1884436F0")]
	private void LNLLMDKBEPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8443340", Offset = "0x8442540", VA = "0x188443340", Slot = "9")]
	public override void Execute(ScriptableRenderContext BKDMJHGCDEA, RenderingData DLHINPMCACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8443800", Offset = "0x8442A00", VA = "0x188443800", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer MNOPFHLOEGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class EHKDEAHFIFE : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort MJEPEDHKGJO = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float PONAJNLMIGH = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly DLOMDMNAEGB APPBLOKOEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int GOKMAOCHOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private GCGNJCAEFHD[] KLFAJDMLNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 CEJDGPGPPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 PLCJNCIEDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint GIHKNEFNKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int LDMIGGLEPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int LJAEOFPKCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> OJBCFAFAEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> EPFDKHPIIKH;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8447500", Offset = "0x8446700", VA = "0x188447500")]
	public EHKDEAHFIFE(RenderPassEvent INMBPJOALLG, ComputeShader DMJLPGLKBFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8445C10", Offset = "0x8444E10", VA = "0x188445C10")]
	public void DHFGHLNEAFE(CameraData EAOCBBOMEFH, LightData MIAJMAMEBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x84462B0", Offset = "0x84454B0", VA = "0x1884462B0")]
	private void MKHOADJJANL(CameraData EAOCBBOMEFH, LightData MIAJMAMEBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x84464B0", Offset = "0x84456B0", VA = "0x1884464B0")]
	public void NIOOPBNOALC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8445750", Offset = "0x8444950", VA = "0x188445750")]
	private void BGKILEOFJCP(LightData MIAJMAMEBPK, GCGNJCAEFHD[] DAELBAHDDLG, int HFOKOEGCDEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8445B60", Offset = "0x8444D60", VA = "0x188445B60")]
	private void DFDFAMAOHEP(int BFILPENBCFK, int LLHOJHAPPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8446F20", Offset = "0x8446120", VA = "0x188446F20")]
	private void PFNMHLIHBJI(int BFILPENBCFK, int OCEHNHGKKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8445F50", Offset = "0x8445150", VA = "0x188445F50")]
	private ushort GAFONCJHOMF(int BFILPENBCFK)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8445FB0", Offset = "0x84451B0", VA = "0x188445FB0")]
	private void HJKGJGGFPHA(int BFILPENBCFK, int LLHOJHAPPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x84456E0", Offset = "0x84448E0", VA = "0x1884456E0")]
	private void BDICIMMCNKG(int GCFCAGDGDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8446E60", Offset = "0x8446060", VA = "0x188446E60")]
	private void PAIMKJKNKNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8445E70", Offset = "0x8445070", VA = "0x188445E70", Slot = "9")]
	public override void Execute(ScriptableRenderContext BKDMJHGCDEA, RenderingData DLHINPMCACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8446E30", Offset = "0x8446030", VA = "0x188446E30", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer MNOPFHLOEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8446F50", Offset = "0x8446150", VA = "0x188446F50")]
	private void PKHLECOFAKF(int CJDOKLGDLDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8446A20", Offset = "0x8445C20", VA = "0x188446A20")]
	private void OPKMNDDBFFJ(uint3 IKJFHGAGMIG, uint3 PDLPOBFFPAE, ushort CJDOKLGDLDD, float3 BBGIGJBAKAM, float OKJPOMFOBEH, float AKCCEJFMJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x84464D0", Offset = "0x84456D0", VA = "0x1884464D0")]
	private void ODLJOPDGJCI(uint3 IKJFHGAGMIG, uint3 PDLPOBFFPAE, ushort CJDOKLGDLDD, float3 BBGIGJBAKAM, float3 JIKGCBBIDNN, float3 NGMKHPAFPMG, float OKJPOMFOBEH, float FJKAJFCNBKO, float AKCCEJFMJFO, float GBCPPCKEHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8445D80", Offset = "0x8444F80", VA = "0x188445D80")]
	private void ELOLJHHGAAL(ushort CJDOKLGDLDD, uint MJGEHEOBPGM, float GGIAJDPEDOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8446020", Offset = "0x8445220", VA = "0x188446020")]
	private float3 KKMOHLEJLCM(uint3 IKJFHGAGMIG, float3 BBGIGJBAKAM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8445F90", Offset = "0x8445190", VA = "0x188445F90")]
	private float GEKLNEGKOAC(float EMMAGGPJAFH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8445AA0", Offset = "0x8444CA0", VA = "0x188445AA0")]
	private float CCHKEMKDDAP(float3 ENCKGALINFP, float3 NGMKHPAFPMG, float FJKAJFCNBKO, float AKCCEJFMJFO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8446120", Offset = "0x8445320", VA = "0x188446120")]
	private void MDABCDBFKAL(int NCGDENNNIKG, ushort MEBCKHLPIJP, int KHJGDLPPLCN, FBCBOOKEIPE AJPBMIIHMIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class DLOMDMNAEGB
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class LLKKBHNPLMI
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int CBPMAFMHEEL;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int DMJACNKFEOM;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int EMCBCKEDNCJ;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int JEKNAAPCPFL;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int DAFOBKIOLJG;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int EMNJANGMDJP;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int IDBMDLKNNJH;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int CGONAMDHGHK = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int OAODIJNDGHC = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int JKOFBDPAJJA = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int OMKNCKAPDPP = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int HOOEKBBPKMP = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int BGAIONKACFA = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int PDIGKHGOIFK = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool AJAHNIFOCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer KIPIKIEPLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture OOBFAHIJJGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int AHKMBAFABMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int JLPBOAFFNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int BKKLDBEEFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int LFHGCGJBNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int LCBLJCDJHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader LENJEBPEENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int JKAKKBJIHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int GMHMGECDALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 PMAOEPJMDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 PBLGBIMHBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> KLBFNGMIFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> DGPJKEBOCON;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> CEDLIKOIGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x50FC420", Offset = "0x50FB620", VA = "0x1850FC420")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> LMJEEDPODIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1197B40", Offset = "0x1196D40", VA = "0x181197B40")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int EAFFGKFDEAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xCB7D00", Offset = "0xCB6F00", VA = "0x180CB7D00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int DEOJJMGLDPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA036F0", Offset = "0xA028F0", VA = "0x180A036F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader BBAIHAELFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x84453A0", Offset = "0x84445A0", VA = "0x1884453A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8444500", Offset = "0x8443700", VA = "0x188444500")]
	public void BHPGJKNEABL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8444940", Offset = "0x8443B40", VA = "0x188444940")]
	public void DMMIBJNJCKD(CameraData EAOCBBOMEFH, LightData MIAJMAMEBPK, int AFBBNKAGNDP, bool EDJBGPFCEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x38640D0", Offset = "0x38632D0", VA = "0x1838640D0")]
	private void EKFMLNKPIML<T>(NativeArray<T> KBILCKNPAKO, int GCFCAGDGDIN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x84445F0", Offset = "0x84437F0", VA = "0x1884445F0")]
	public void DBLCHDEILKL(CommandBuffer MNOPFHLOEGH, ScriptableRenderContext BKDMJHGCDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8444FE0", Offset = "0x84441E0", VA = "0x188444FE0")]
	private static void KJCKFOBLBJJ(int MADEOLGOJCE, CommandBuffer MNOPFHLOEGH, RenderBuffer LLBBKGGGJLA, ComputeBuffer KJAHLNEJCHF, ComputeShader OKKDOLJKMNP, int BOPBGJHCLJH, int LPHDNJCABHC, int DEBOMGDBCHL, int NAGCODINKPP, int OILAEPDEOKB, int HGACAGKFJLH, int BLANBLGKFIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8444C50", Offset = "0x8443E50", VA = "0x188444C50")]
	public void GEGLNPJAMOO(CommandBuffer MNOPFHLOEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x84451C0", Offset = "0x84443C0", VA = "0x1884451C0")]
	private RenderTexture KJLJLHNDKDJ(RenderTexture OIJBHOKBIDP, int BOPBGJHCLJH, int LPHDNJCABHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8444F60", Offset = "0x8444160", VA = "0x188444F60")]
	public void JEBHMPDFMDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8445430", Offset = "0x8444630", VA = "0x188445430")]
	public void PMDAMDEPJFE(int MKDFDMABOHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x84456C0", Offset = "0x84448C0", VA = "0x1884456C0")]
	public DLOMDMNAEGB()
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
		public struct NJNOAFBMDGL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float IFJDJLPKAIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float HDJMNKNKFFE;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class MNOLPGGPCLM : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string FMEHMBICBCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler BACGMLLKPCE;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int FIEFHPOEHDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material OANIFLHIEKK;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x844A930", Offset = "0x8449B30", VA = "0x18844A930")]
			public MNOLPGGPCLM(RenderPassEvent INMBPJOALLG, Material ADKDGJDNNAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x844A560", Offset = "0x8449760", VA = "0x18844A560", Slot = "9")]
			public override void Execute(ScriptableRenderContext BKDMJHGCDEA, RenderingData DLHINPMCACP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static NJNOAFBMDGL CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private MNOLPGGPCLM m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x844ACE0", Offset = "0x8449EE0", VA = "0x18844ACE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x844AC90", Offset = "0x8449E90", VA = "0x18844AC90")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x844AAE0", Offset = "0x8449CE0", VA = "0x18844AAE0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x844AA10", Offset = "0x8449C10", VA = "0x18844AA10", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer HLIOBIEFOPB, RenderingData DLHINPMCACP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x175F0A0", Offset = "0x175E2A0", VA = "0x18175F0A0")]
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
		public struct GAPMADNEBFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float KHHMMFFODDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color HNGDMFLEOED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh GNNNEPOCCIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve EGLHCCHOOPJ;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class KCJHHCINJDD : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string FMEHMBICBCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler BACGMLLKPCE;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int LNJBJCLMPGE;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int IEFLBLMJDDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material OANIFLHIEKK;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8448AD0", Offset = "0x8447CD0", VA = "0x188448AD0")]
			public KCJHHCINJDD(RenderPassEvent INMBPJOALLG, Material ADKDGJDNNAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8448830", Offset = "0x8447A30", VA = "0x188448830", Slot = "9")]
			public override void Execute(ScriptableRenderContext BKDMJHGCDEA, RenderingData DLHINPMCACP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static GAPMADNEBFG CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private KCJHHCINJDD m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x844AFF0", Offset = "0x844A1F0", VA = "0x18844AFF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x844AE40", Offset = "0x844A040", VA = "0x18844AE40", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x844AD30", Offset = "0x8449F30", VA = "0x18844AD30", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer HLIOBIEFOPB, RenderingData DLHINPMCACP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x175F0A0", Offset = "0x175E2A0", VA = "0x18175F0A0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string FGFCICKHMBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool KJHPBCJKMOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA4C7C0", Offset = "0xA4B9C0", VA = "0x180A4C7C0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer MNOPFHLOEGH, ScriptableRenderContext BKDMJHGCDEA, RenderingData DLHINPMCACP);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA02C50", Offset = "0xA01E50", VA = "0x180A02C50")]
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
		private class HNPAJLJBFAA : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool JFDBOLLLAGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> NMAGKALHBMK;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> BIOIDICKCIH;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x84485D0", Offset = "0x84477D0", VA = "0x1884485D0")]
			public HNPAJLJBFAA(RenderPassEvent INMBPJOALLG, bool JFDBOLLLAGA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8448260", Offset = "0x8447460", VA = "0x188448260")]
			public bool NHBKNEGAGFE(CameraData EAOCBBOMEFH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8447FB0", Offset = "0x84471B0", VA = "0x188447FB0", Slot = "9")]
			public override void Execute(ScriptableRenderContext BKDMJHGCDEA, RenderingData DLHINPMCACP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8448180", Offset = "0x8447380", VA = "0x188448180")]
			private void JLHNOCPKEGC(PerCameraRenderEffect MBBNNANFMKD, ScriptableRenderContext BKDMJHGCDEA, RenderingData DLHINPMCACP)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private HNPAJLJBFAA m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private HNPAJLJBFAA m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x844B110", Offset = "0x844A310", VA = "0x18844B110", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x844B080", Offset = "0x844A280", VA = "0x18844B080", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer HLIOBIEFOPB, RenderingData DLHINPMCACP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x175F0A0", Offset = "0x175E2A0", VA = "0x18175F0A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x844B360", Offset = "0x844A560", VA = "0x18844B360")]
		public static void MPPFMFCCJEG(ScriptableRenderPass JALMIGGKFDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x844B1C0", Offset = "0x844A3C0", VA = "0x18844B1C0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer HLIOBIEFOPB, RenderingData DLHINPMCACP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x175F0A0", Offset = "0x175E2A0", VA = "0x18175F0A0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class CELINPKPBAL
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 AKOAFGDBOEG;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 AOAKEEJEBNN;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 FAACPICNCFL;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 EFOAAAAGGHL;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 JMALEMBEEFE;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8443CB0", Offset = "0x8442EB0", VA = "0x188443CB0")]
	public static uint GFBDBKIHAMJ(uint HGCMPGNMMIB, uint PIALGICKFLK, uint AKEKIBJOPCD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8443AC0", Offset = "0x8442CC0", VA = "0x188443AC0")]
	public static uint3 EKIBHJBNIKB(float3 FICCENLPJEL, float3 HJLPAEKPMOF, float3 HBELJKDGNOD)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8443CC0", Offset = "0x8442EC0", VA = "0x188443CC0")]
	public static void HCEFAGDPNOJ(float3 FAPEFAPHNKL, float3 GGGECLGOLBP, float3 KHOJCJOBIAO, float DKGEGBLOEHH, [Out] uint3 LMFDLBIJMAA, [Out] uint3 PLMBNNOAOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8443F00", Offset = "0x8443100", VA = "0x188443F00")]
	public static void KPNHBHCLFNN(float3 JNFPENFPJOE, float3 IBPELMOEPEE, float CFPNMKPLIJH, float HJCMFJDGPAP, [Out] float3 IMEAKGLMLJJ, [Out] float DKGEGBLOEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8443920", Offset = "0x8442B20", VA = "0x188443920")]
	private static float3 BHCOMJFJNCI(float3 DGBMDPELNNB, float3 LPGBFLOOKLL, float3 GBBGABOIFFA, float3 ABDIJOAKGKB)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class IEOHPMAEAOA
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly KEPOMIIOHBM JKAEJMOOLFG;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly KEPOMIIOHBM AEFOPBLLOOG;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly KEPOMIIOHBM HNMKFIHCIMA;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly KEPOMIIOHBM AFDFGAHHNKF;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly KEPOMIIOHBM OFNLLLFNKPK;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class BGIHGKPGOJO
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh NIPNDBJMGPN;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8442470", Offset = "0x8441670", VA = "0x188442470")]
	public static Mesh DLJPBFEDIHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8442510", Offset = "0x8441710", VA = "0x188442510")]
	public static Matrix4x4 FNBJDMGCOEG(Camera HEKBGKAPFJN, bool BHCCDFFCDNK = false, bool KDGBHDAIFJJ = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x84420B0", Offset = "0x84412B0", VA = "0x1884420B0")]
	private static Mesh BDFPEKBEOJG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__795506606
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x844C7F0", Offset = "0x844B9F0", VA = "0x18844C7F0")]
	public static void KJOJENNPCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x844C7E0", Offset = "0x844B9E0", VA = "0x18844C7E0")]
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
