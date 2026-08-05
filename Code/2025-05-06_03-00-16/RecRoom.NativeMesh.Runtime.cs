using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Core.Creation.Shapes;
using RecRoom.Logging.Attributes;
using Unity.Burst;
using Unity.Burst.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _LogRegistration.RecRoom_NativeMesh_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : ONLGCKOFHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BBE510", Offset = "0x7BBCD10", VA = "0x187BBE510", Slot = "4")]
		public override void JNEAPGDNFGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class JGJMPCECMNM
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly LLPKKNNAIAE MGHIJPANJKN;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly LLPKKNNAIAE LNGKHPEOIEP;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly LLPKKNNAIAE APDDDONCIOA;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly LLPKKNNAIAE LNCKEDDCKEH;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly LLPKKNNAIAE GLIAJPMCONK;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public class FAAMFBBAENC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public IHLJGJEJFHB HCBFCADAOMC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int PKBFIOIHAOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public FAAMFBBAENC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[BurstCompile]
public struct IHLJGJEJFHB
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct NALGHMPKELB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public half KPJLAHKFFEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public ushort BKNOCHBLDJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public byte GKFPFCHEOHP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public unsafe delegate void PEKOMFKELHI([NoAlias] float3* JNKDBBJFFKP, [In][NoAlias] ushort* KHMHCAMLHIO, int PKBFIOIHAOL, [In] float3 NOKJBEEPBGK, [In] float3 BDAOACNGPKA);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal static class NGKKLBFFAEA
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0520", Offset = "0x7BBED20", VA = "0x187BC0520")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7BC03D0", Offset = "0x7BBEBD0", VA = "0x187BC03D0")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0860", Offset = "0x7BBF060", VA = "0x187BC0860")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0640", Offset = "0x7BBEE40", VA = "0x187BC0640")]
		public unsafe static void GINPGABDCGP([NoAlias] float3* JNKDBBJFFKP, [In][NoAlias] ushort* KHMHCAMLHIO, int PKBFIOIHAOL, [In] float3 NOKJBEEPBGK, [In] float3 BDAOACNGPKA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public unsafe delegate void FPMEMEAHLFF([NoAlias] PKKNLFDDHKF.MOOHCIFBECK* JNKDBBJFFKP, [In][NoAlias] ushort* KHMHCAMLHIO, int PKBFIOIHAOL, [In] float3 NOKJBEEPBGK, [In] float3 BDAOACNGPKA);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class FMCOLGKDIOO
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7BAC5D0", Offset = "0x7BAADD0", VA = "0x187BAC5D0")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7BAC480", Offset = "0x7BAAC80", VA = "0x187BAC480")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7BAC990", Offset = "0x7BAB190", VA = "0x187BAC990")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7BAC6F0", Offset = "0x7BAAEF0", VA = "0x187BAC6F0")]
		public unsafe static void GINPGABDCGP([NoAlias] PKKNLFDDHKF.MOOHCIFBECK* JNKDBBJFFKP, [In][NoAlias] ushort* KHMHCAMLHIO, int PKBFIOIHAOL, [In] float3 NOKJBEEPBGK, [In] float3 BDAOACNGPKA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public unsafe delegate void GEDOJEEAHOD([NoAlias] PKKNLFDDHKF.HOBMHNHOPFB* JNKDBBJFFKP, [In][NoAlias] ushort* KHMHCAMLHIO, int PKBFIOIHAOL, [In] float3 NOKJBEEPBGK, [In] float3 BDAOACNGPKA);

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal static class OBEMJJAJFOL
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1BC0", Offset = "0x7BC03C0", VA = "0x187BC1BC0")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1A70", Offset = "0x7BC0270", VA = "0x187BC1A70")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1F80", Offset = "0x7BC0780", VA = "0x187BC1F80")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1CE0", Offset = "0x7BC04E0", VA = "0x187BC1CE0")]
		public unsafe static void GINPGABDCGP([NoAlias] PKKNLFDDHKF.HOBMHNHOPFB* JNKDBBJFFKP, [In][NoAlias] ushort* KHMHCAMLHIO, int PKBFIOIHAOL, [In] float3 NOKJBEEPBGK, [In] float3 BDAOACNGPKA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public unsafe delegate void GOOOLGPDMFD([NoAlias] PKKNLFDDHKF.MDDBIEOGPIM* JNKDBBJFFKP, [In][NoAlias] ushort* KHMHCAMLHIO, int PKBFIOIHAOL, [In] float3 NOKJBEEPBGK, [In] float3 BDAOACNGPKA);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal static class HCKLFCGCENI
	{
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7BAD090", Offset = "0x7BAB890", VA = "0x187BAD090")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7BACF40", Offset = "0x7BAB740", VA = "0x187BACF40")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7BAD450", Offset = "0x7BABC50", VA = "0x187BAD450")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7BAD1B0", Offset = "0x7BAB9B0", VA = "0x187BAD1B0")]
		public unsafe static void GINPGABDCGP([NoAlias] PKKNLFDDHKF.MDDBIEOGPIM* JNKDBBJFFKP, [In][NoAlias] ushort* KHMHCAMLHIO, int PKBFIOIHAOL, [In] float3 NOKJBEEPBGK, [In] float3 BDAOACNGPKA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public unsafe delegate void ONMFKIMLGOA([NoAlias] PKKNLFDDHKF.LAFBFKCBMPA* JNKDBBJFFKP, [In][NoAlias] ushort* KHMHCAMLHIO, int PKBFIOIHAOL, [In] float3 NOKJBEEPBGK, [In] float3 BDAOACNGPKA);

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal static class LNHPLEBKNEI
	{
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7BBE0B0", Offset = "0x7BBC8B0", VA = "0x187BBE0B0")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7BBDF60", Offset = "0x7BBC760", VA = "0x187BBDF60")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7BBE470", Offset = "0x7BBCC70", VA = "0x187BBE470")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7BBE1D0", Offset = "0x7BBC9D0", VA = "0x187BBE1D0")]
		public unsafe static void GINPGABDCGP([NoAlias] PKKNLFDDHKF.LAFBFKCBMPA* JNKDBBJFFKP, [In][NoAlias] ushort* KHMHCAMLHIO, int PKBFIOIHAOL, [In] float3 NOKJBEEPBGK, [In] float3 BDAOACNGPKA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public unsafe delegate void FKHEDDLCJAK([NoAlias] PKKNLFDDHKF.MGOBFJFJINC* JNKDBBJFFKP, [In][NoAlias] ushort* KHMHCAMLHIO, int PKBFIOIHAOL, [In] float3 NOKJBEEPBGK, [In] float3 BDAOACNGPKA);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class CPCKOJJGIIN
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7BA9B90", Offset = "0x7BA8390", VA = "0x187BA9B90")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7BA9A40", Offset = "0x7BA8240", VA = "0x187BA9A40")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7BA9FE0", Offset = "0x7BA87E0", VA = "0x187BA9FE0")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7BA9CB0", Offset = "0x7BA84B0", VA = "0x187BA9CB0")]
		public unsafe static void GINPGABDCGP([NoAlias] PKKNLFDDHKF.MGOBFJFJINC* JNKDBBJFFKP, [In][NoAlias] ushort* KHMHCAMLHIO, int PKBFIOIHAOL, [In] float3 NOKJBEEPBGK, [In] float3 BDAOACNGPKA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public unsafe delegate void LHJEIIKCBAA([NoAlias] ushort* JNKDBBJFFKP, [Out] float3 DOJNAGKJEFC, [Out] float3 BDAOACNGPKA, [In][NoAlias] float3* KHMHCAMLHIO, int OMGJAJJIOFN, int HFGIBGEKDDK);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class IHPFKBMHHEK
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7BB91D0", Offset = "0x7BB79D0", VA = "0x187BB91D0")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7BB9080", Offset = "0x7BB7880", VA = "0x187BB9080")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7BB9520", Offset = "0x7BB7D20", VA = "0x187BB9520")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7BB92F0", Offset = "0x7BB7AF0", VA = "0x187BB92F0")]
		public unsafe static void GINPGABDCGP([NoAlias] ushort* JNKDBBJFFKP, [Out] float3 DOJNAGKJEFC, [Out] float3 BDAOACNGPKA, [In][NoAlias] float3* KHMHCAMLHIO, int OMGJAJJIOFN, int HFGIBGEKDDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public unsafe delegate void ONBALDOMOHJ([NoAlias] ushort* GIMAMDDJMPK, [In][NoAlias] float3* CCLLNIIJGJE, int HFGIBGEKDDK);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class HFLDDEDNFGM
	{
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7BAD640", Offset = "0x7BABE40", VA = "0x187BAD640")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7BAD4F0", Offset = "0x7BABCF0", VA = "0x187BAD4F0")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7BAD960", Offset = "0x7BAC160", VA = "0x187BAD960")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7BAD760", Offset = "0x7BABF60", VA = "0x187BAD760")]
		public unsafe static void GINPGABDCGP([NoAlias] ushort* GIMAMDDJMPK, [In][NoAlias] float3* CCLLNIIJGJE, int HFGIBGEKDDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void JNNPIDBOAOD([NoAlias] float3* NCFBIEKLIPN, [In][NoAlias] ushort* CCLLNIIJGJE, int PKBFIOIHAOL);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class KJCGINHMJMG
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7BBCD40", Offset = "0x7BBB540", VA = "0x187BBCD40")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7BBCBF0", Offset = "0x7BBB3F0", VA = "0x187BBCBF0")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7BBD060", Offset = "0x7BBB860", VA = "0x187BBD060")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7BBCE60", Offset = "0x7BBB660", VA = "0x187BBCE60")]
		public unsafe static void GINPGABDCGP([NoAlias] float3* NCFBIEKLIPN, [In][NoAlias] ushort* CCLLNIIJGJE, int PKBFIOIHAOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void KHOPLJECKGA([NoAlias] PKKNLFDDHKF.MOOHCIFBECK* JNKDBBJFFKP, [In][NoAlias] ushort* CCLLNIIJGJE, int PKBFIOIHAOL);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class FOADHOHGHBO
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7BACB80", Offset = "0x7BAB380", VA = "0x187BACB80")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7BACA30", Offset = "0x7BAB230", VA = "0x187BACA30")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7BACEA0", Offset = "0x7BAB6A0", VA = "0x187BACEA0")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7BACCA0", Offset = "0x7BAB4A0", VA = "0x187BACCA0")]
		public unsafe static void GINPGABDCGP([NoAlias] PKKNLFDDHKF.MOOHCIFBECK* JNKDBBJFFKP, [In][NoAlias] ushort* CCLLNIIJGJE, int PKBFIOIHAOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void NHLICHCILBF([NoAlias] PKKNLFDDHKF.HOBMHNHOPFB* JNKDBBJFFKP, [In][NoAlias] ushort* CCLLNIIJGJE, int PKBFIOIHAOL);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class INKBDEDJMPK
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7BB9810", Offset = "0x7BB8010", VA = "0x187BB9810")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7BB96C0", Offset = "0x7BB7EC0", VA = "0x187BB96C0")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7BB9C20", Offset = "0x7BB8420", VA = "0x187BB9C20")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7BB9930", Offset = "0x7BB8130", VA = "0x187BB9930")]
		public unsafe static void GINPGABDCGP([NoAlias] PKKNLFDDHKF.HOBMHNHOPFB* JNKDBBJFFKP, [In][NoAlias] ushort* CCLLNIIJGJE, int PKBFIOIHAOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public unsafe delegate void HIIDNHCFIME([NoAlias] PKKNLFDDHKF.MDDBIEOGPIM* JNKDBBJFFKP, [In][NoAlias] ushort* CCLLNIIJGJE, int PKBFIOIHAOL);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class JLIEMIKEMOI
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7BBBAE0", Offset = "0x7BBA2E0", VA = "0x187BBBAE0")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7BBB990", Offset = "0x7BBA190", VA = "0x187BBB990")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7BBBEF0", Offset = "0x7BBA6F0", VA = "0x187BBBEF0")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7BBBC00", Offset = "0x7BBA400", VA = "0x187BBBC00")]
		public unsafe static void GINPGABDCGP([NoAlias] PKKNLFDDHKF.MDDBIEOGPIM* JNKDBBJFFKP, [In][NoAlias] ushort* CCLLNIIJGJE, int PKBFIOIHAOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public unsafe delegate void IIABECCFJIH([NoAlias] PKKNLFDDHKF.LAFBFKCBMPA* JNKDBBJFFKP, [In][NoAlias] ushort* CCLLNIIJGJE, int PKBFIOIHAOL);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal static class NHEEIHNOOOD
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0A50", Offset = "0x7BBF250", VA = "0x187BC0A50")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0900", Offset = "0x7BBF100", VA = "0x187BC0900")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0E90", Offset = "0x7BBF690", VA = "0x187BC0E90")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0B70", Offset = "0x7BBF370", VA = "0x187BC0B70")]
		public unsafe static void GINPGABDCGP([NoAlias] PKKNLFDDHKF.LAFBFKCBMPA* JNKDBBJFFKP, [In][NoAlias] ushort* CCLLNIIJGJE, int PKBFIOIHAOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public unsafe delegate void MBGLNEFDNNK([NoAlias] PKKNLFDDHKF.MGOBFJFJINC* JNKDBBJFFKP, [In][NoAlias] ushort* CCLLNIIJGJE, int PKBFIOIHAOL);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal static class ODKCIIMPCCM
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2170", Offset = "0x7BC0970", VA = "0x187BC2170")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2020", Offset = "0x7BC0820", VA = "0x187BC2020")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7BC25B0", Offset = "0x7BC0DB0", VA = "0x187BC25B0")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2290", Offset = "0x7BC0A90", VA = "0x187BC2290")]
		public unsafe static void GINPGABDCGP([NoAlias] PKKNLFDDHKF.MGOBFJFJINC* JNKDBBJFFKP, [In][NoAlias] ushort* CCLLNIIJGJE, int PKBFIOIHAOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public unsafe delegate void JNGDBCBINHB([NoAlias] uint* GKOKOJPGHBG, [Out] float2 EGILMFMLDCO, [Out] float2 FAIAGJPDHEJ, [In][NoAlias] float2* KJPICJKEGIN, int OMGJAJJIOFN, int HFGIBGEKDDK);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class MGGPBKJAPJC
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7BBEB50", Offset = "0x7BBD350", VA = "0x187BBEB50")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7BBEA00", Offset = "0x7BBD200", VA = "0x187BBEA00")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7BBEEA0", Offset = "0x7BBD6A0", VA = "0x187BBEEA0")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7BBEC70", Offset = "0x7BBD470", VA = "0x187BBEC70")]
		public unsafe static void GINPGABDCGP([NoAlias] uint* GKOKOJPGHBG, [Out] float2 EGILMFMLDCO, [Out] float2 FAIAGJPDHEJ, [In][NoAlias] float2* KJPICJKEGIN, int OMGJAJJIOFN, int HFGIBGEKDDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public delegate void MHPJCKKMIBM([Out] float2 FALOLAKNOAA, uint CPIAKHMHDHF, [In] float2 DPMJCCLLCLN, [In] float2 FAIAGJPDHEJ);

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class FLFPHAKOEME
	{
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7BAC070", Offset = "0x7BAA870", VA = "0x187BAC070")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7BABF20", Offset = "0x7BAA720", VA = "0x187BABF20")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7BAC3E0", Offset = "0x7BAABE0", VA = "0x187BAC3E0")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7BAC190", Offset = "0x7BAA990", VA = "0x187BAC190")]
		public static void GINPGABDCGP([Out] float2 FALOLAKNOAA, uint CPIAKHMHDHF, [In] float2 DPMJCCLLCLN, [In] float2 FAIAGJPDHEJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public unsafe delegate void PMPPMOIOAHF([NoAlias] float2* GKOKOJPGHBG, [NoAlias] uint* KJPICJKEGIN, int PKBFIOIHAOL, [In] float2 DPMJCCLLCLN, [In] float2 FAIAGJPDHEJ);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal static class FFGBGNKNMFN
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB450", Offset = "0x7BA9C50", VA = "0x187BAB450")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB300", Offset = "0x7BA9B00", VA = "0x187BAB300")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB850", Offset = "0x7BAA050", VA = "0x187BAB850")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB570", Offset = "0x7BA9D70", VA = "0x187BAB570")]
		public unsafe static void GINPGABDCGP([NoAlias] float2* GKOKOJPGHBG, [NoAlias] uint* KJPICJKEGIN, int PKBFIOIHAOL, [In] float2 DPMJCCLLCLN, [In] float2 FAIAGJPDHEJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public unsafe delegate void ACNPOCODKOJ([NoAlias] PKKNLFDDHKF.MOOHCIFBECK* JNKDBBJFFKP, [NoAlias] uint* KJPICJKEGIN, int PKBFIOIHAOL, [In] float2 DPMJCCLLCLN, [In] float2 FAIAGJPDHEJ);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class JIPLEIPHKEI
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7BBA920", Offset = "0x7BB9120", VA = "0x187BBA920")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7BBA7D0", Offset = "0x7BB8FD0", VA = "0x187BBA7D0")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7BBAD60", Offset = "0x7BB9560", VA = "0x187BBAD60")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7BBAA40", Offset = "0x7BB9240", VA = "0x187BBAA40")]
		public unsafe static void GINPGABDCGP([NoAlias] PKKNLFDDHKF.MOOHCIFBECK* JNKDBBJFFKP, [NoAlias] uint* KJPICJKEGIN, int PKBFIOIHAOL, [In] float2 DPMJCCLLCLN, [In] float2 FAIAGJPDHEJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public unsafe delegate void IDIMDEONCDK([NoAlias] PKKNLFDDHKF.HOBMHNHOPFB* JNKDBBJFFKP, [NoAlias] uint* KJPICJKEGIN, int PKBFIOIHAOL, [In] float2 DPMJCCLLCLN, [In] float2 FAIAGJPDHEJ);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class EJHPJLFJEIO
	{
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7BAA800", Offset = "0x7BA9000", VA = "0x187BAA800")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7BAA6B0", Offset = "0x7BA8EB0", VA = "0x187BAA6B0")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7BAAC40", Offset = "0x7BA9440", VA = "0x187BAAC40")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7BAA920", Offset = "0x7BA9120", VA = "0x187BAA920")]
		public unsafe static void GINPGABDCGP([NoAlias] PKKNLFDDHKF.HOBMHNHOPFB* JNKDBBJFFKP, [NoAlias] uint* KJPICJKEGIN, int PKBFIOIHAOL, [In] float2 DPMJCCLLCLN, [In] float2 FAIAGJPDHEJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public unsafe delegate void BFECBPJDBFL([NoAlias] PKKNLFDDHKF.MDDBIEOGPIM* JNKDBBJFFKP, [NoAlias] uint* KJPICJKEGIN, int PKBFIOIHAOL, [In] float2 DPMJCCLLCLN, [In] float2 FAIAGJPDHEJ);

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class DGBIPFOKMKN
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7BAA1D0", Offset = "0x7BA89D0", VA = "0x187BAA1D0")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7BAA080", Offset = "0x7BA8880", VA = "0x187BAA080")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7BAA510", Offset = "0x7BA8D10", VA = "0x187BAA510")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7BAA2F0", Offset = "0x7BA8AF0", VA = "0x187BAA2F0")]
		public unsafe static void GINPGABDCGP([NoAlias] PKKNLFDDHKF.MDDBIEOGPIM* JNKDBBJFFKP, [NoAlias] uint* KJPICJKEGIN, int PKBFIOIHAOL, [In] float2 DPMJCCLLCLN, [In] float2 FAIAGJPDHEJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public unsafe delegate void MFFCCBDNKOM([NoAlias] PKKNLFDDHKF.LAFBFKCBMPA* JNKDBBJFFKP, [NoAlias] uint* KJPICJKEGIN, int PKBFIOIHAOL, [In] float2 DPMJCCLLCLN, [In] float2 FAIAGJPDHEJ);

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal static class JJKIEJPOBEI
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7BBAF50", Offset = "0x7BB9750", VA = "0x187BBAF50")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7BBAE00", Offset = "0x7BB9600", VA = "0x187BBAE00")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7BBB380", Offset = "0x7BB9B80", VA = "0x187BBB380")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7BBB070", Offset = "0x7BB9870", VA = "0x187BBB070")]
		public unsafe static void GINPGABDCGP([NoAlias] PKKNLFDDHKF.LAFBFKCBMPA* JNKDBBJFFKP, [NoAlias] uint* KJPICJKEGIN, int PKBFIOIHAOL, [In] float2 DPMJCCLLCLN, [In] float2 FAIAGJPDHEJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public unsafe delegate void HAFCEAFDPFB([NoAlias] PKKNLFDDHKF.MGOBFJFJINC* JNKDBBJFFKP, [NoAlias] uint* KJPICJKEGIN, int PKBFIOIHAOL, [In] float2 DPMJCCLLCLN, [In] float2 FAIAGJPDHEJ);

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class FCGIBKCGDPO
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7BAAE30", Offset = "0x7BA9630", VA = "0x187BAAE30")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7BAACE0", Offset = "0x7BA94E0", VA = "0x187BAACE0")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB260", Offset = "0x7BA9A60", VA = "0x187BAB260")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7BAAF50", Offset = "0x7BA9750", VA = "0x187BAAF50")]
		public unsafe static void GINPGABDCGP([NoAlias] PKKNLFDDHKF.MGOBFJFJINC* JNKDBBJFFKP, [NoAlias] uint* KJPICJKEGIN, int PKBFIOIHAOL, [In] float2 DPMJCCLLCLN, [In] float2 FAIAGJPDHEJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public unsafe delegate void IILOCAFKCAO([NoAlias] ushort* GOJFOAIJKHO, [In][NoAlias] float4* HMLPMPOMMDE, int OMGJAJJIOFN, int HFGIBGEKDDK);

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal static class MPBEGHPEDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF9E0", Offset = "0x7BBE1E0", VA = "0x187BBF9E0")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF890", Offset = "0x7BBE090", VA = "0x187BBF890")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7BBFD90", Offset = "0x7BBE590", VA = "0x187BBFD90")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7BBFB00", Offset = "0x7BBE300", VA = "0x187BBFB00")]
		public unsafe static void GINPGABDCGP([NoAlias] ushort* GOJFOAIJKHO, [In][NoAlias] float4* HMLPMPOMMDE, int OMGJAJJIOFN, int HFGIBGEKDDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate ushort DKDPDLAHIIF([In] float4 PNEBLLCACFD);

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal static class KGAAFMHJCJG
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC7E0", Offset = "0x7BBAFE0", VA = "0x187BBC7E0")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC690", Offset = "0x7BBAE90", VA = "0x187BBC690")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7BBCB50", Offset = "0x7BBB350", VA = "0x187BBCB50")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC900", Offset = "0x7BBB100", VA = "0x187BBC900")]
		public static ushort GINPGABDCGP([In] float4 PNEBLLCACFD)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public unsafe delegate void HAHGHEBGKKC([NoAlias] float4* GOJFOAIJKHO, [In][NoAlias] ushort* CFDIIPKIDOK, int PKBFIOIHAOL);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal static class NHHNABGNAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1080", Offset = "0x7BBF880", VA = "0x187BC1080")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0F30", Offset = "0x7BBF730", VA = "0x187BC0F30")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1430", Offset = "0x7BBFC30", VA = "0x187BC1430")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7BC11A0", Offset = "0x7BBF9A0", VA = "0x187BC11A0")]
		public unsafe static void GINPGABDCGP([NoAlias] float4* GOJFOAIJKHO, [In][NoAlias] ushort* CFDIIPKIDOK, int PKBFIOIHAOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public unsafe delegate void AFNOKKNBMFJ([NoAlias] PKKNLFDDHKF.MOOHCIFBECK* JNKDBBJFFKP, [In][NoAlias] ushort* CFDIIPKIDOK, int PKBFIOIHAOL);

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal static class CHFNBPJJNJB
	{
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7BA9050", Offset = "0x7BA7850", VA = "0x187BA9050")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7BA8F00", Offset = "0x7BA7700", VA = "0x187BA8F00")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7BA9370", Offset = "0x7BA7B70", VA = "0x187BA9370")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7BA9170", Offset = "0x7BA7970", VA = "0x187BA9170")]
		public unsafe static void GINPGABDCGP([NoAlias] PKKNLFDDHKF.MOOHCIFBECK* JNKDBBJFFKP, [In][NoAlias] ushort* CFDIIPKIDOK, int PKBFIOIHAOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public unsafe delegate void LAFNIFFHJKK([NoAlias] PKKNLFDDHKF.HOBMHNHOPFB* JNKDBBJFFKP, [In][NoAlias] ushort* CFDIIPKIDOK, int PKBFIOIHAOL);

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal static class FHNJHLKMDBO
	{
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7BABA40", Offset = "0x7BAA240", VA = "0x187BABA40")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB8F0", Offset = "0x7BAA0F0", VA = "0x187BAB8F0")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7BABE80", Offset = "0x7BAA680", VA = "0x187BABE80")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7BABB60", Offset = "0x7BAA360", VA = "0x187BABB60")]
		public unsafe static void GINPGABDCGP([NoAlias] PKKNLFDDHKF.HOBMHNHOPFB* JNKDBBJFFKP, [In][NoAlias] ushort* CFDIIPKIDOK, int PKBFIOIHAOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public unsafe delegate void DFNLNDNDBJP([NoAlias] PKKNLFDDHKF.MDDBIEOGPIM* JNKDBBJFFKP, [In][NoAlias] ushort* CFDIIPKIDOK, int PKBFIOIHAOL);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal static class CNACOMELCAG
	{
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7BA9560", Offset = "0x7BA7D60", VA = "0x187BA9560")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7BA9410", Offset = "0x7BA7C10", VA = "0x187BA9410")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7BA99A0", Offset = "0x7BA81A0", VA = "0x187BA99A0")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7BA9680", Offset = "0x7BA7E80", VA = "0x187BA9680")]
		public unsafe static void GINPGABDCGP([NoAlias] PKKNLFDDHKF.MDDBIEOGPIM* JNKDBBJFFKP, [In][NoAlias] ushort* CFDIIPKIDOK, int PKBFIOIHAOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public unsafe delegate void GDCEEOLAOOG([NoAlias] PKKNLFDDHKF.LAFBFKCBMPA* JNKDBBJFFKP, [In][NoAlias] ushort* CFDIIPKIDOK, int PKBFIOIHAOL);

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal static class HMOFIADHDOA
	{
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7BADB50", Offset = "0x7BAC350", VA = "0x187BADB50")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7BADA00", Offset = "0x7BAC200", VA = "0x187BADA00")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7BAE000", Offset = "0x7BAC800", VA = "0x187BAE000")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7BADC70", Offset = "0x7BAC470", VA = "0x187BADC70")]
		public unsafe static void GINPGABDCGP([NoAlias] PKKNLFDDHKF.LAFBFKCBMPA* JNKDBBJFFKP, [In][NoAlias] ushort* CFDIIPKIDOK, int PKBFIOIHAOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public unsafe delegate void FJKLHAJCAHF([NoAlias] PKKNLFDDHKF.MGOBFJFJINC* JNKDBBJFFKP, [In][NoAlias] ushort* CFDIIPKIDOK, int PKBFIOIHAOL);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	internal static class IHFOIMPMLKB
	{
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7BAEE50", Offset = "0x7BAD650", VA = "0x187BAEE50")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7BAED00", Offset = "0x7BAD500", VA = "0x187BAED00")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7BAF300", Offset = "0x7BADB00", VA = "0x187BAF300")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7BAEF70", Offset = "0x7BAD770", VA = "0x187BAEF70")]
		public unsafe static void GINPGABDCGP([NoAlias] PKKNLFDDHKF.MGOBFJFJINC* JNKDBBJFFKP, [In][NoAlias] ushort* CFDIIPKIDOK, int PKBFIOIHAOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public delegate void BAMBPHIDPOH([Out] float4 HLPIAOANGMD, ushort CPIAKHMHDHF);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal static class MPGPLJIMLIC
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7BBFF80", Offset = "0x7BBE780", VA = "0x187BBFF80")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7BBFE30", Offset = "0x7BBE630", VA = "0x187BBFE30")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0330", Offset = "0x7BBEB30", VA = "0x187BC0330")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7BC00A0", Offset = "0x7BBE8A0", VA = "0x187BC00A0")]
		public static void GINPGABDCGP([Out] float4 HLPIAOANGMD, ushort CPIAKHMHDHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public unsafe delegate void JFOGACCELDI([NoAlias] float4* EJGMBAJEOAA, [NoAlias] byte* FLDELKHHFPJ, [Out] int HBOMHPIIMMH, [Out] int FHCBINIFHGF, [NoAlias] float4* PFGOHPBHFJE, int OMGJAJJIOFN, int HFGIBGEKDDK);

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal static class OFOPIPKDODC
	{
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7BC27A0", Offset = "0x7BC0FA0", VA = "0x187BC27A0")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2650", Offset = "0x7BC0E50", VA = "0x187BC2650")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2AF0", Offset = "0x7BC12F0", VA = "0x187BC2AF0")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC28C0", Offset = "0x7BC10C0", VA = "0x187BC28C0")]
		public unsafe static void GINPGABDCGP([NoAlias] float4* EJGMBAJEOAA, [NoAlias] byte* FLDELKHHFPJ, [Out] int HBOMHPIIMMH, [Out] int FHCBINIFHGF, [NoAlias] float4* PFGOHPBHFJE, int OMGJAJJIOFN, int HFGIBGEKDDK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public unsafe delegate void LDADCILCIDM([NoAlias] float4* ELMDFHIGGOF, [In][NoAlias] NALGHMPKELB* BIAKPLJDFKD, [In][NoAlias] byte* BNNJCFNNDDB, int PKBFIOIHAOL);

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal static class KMHDOGJKKBC
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7BBD250", Offset = "0x7BBBA50", VA = "0x187BBD250")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7BBD100", Offset = "0x7BBB900", VA = "0x187BBD100")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7BBD670", Offset = "0x7BBBE70", VA = "0x187BBD670")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7BBD370", Offset = "0x7BBBB70", VA = "0x187BBD370")]
		public unsafe static void GINPGABDCGP([NoAlias] float4* ELMDFHIGGOF, [In][NoAlias] NALGHMPKELB* BIAKPLJDFKD, [In][NoAlias] byte* BNNJCFNNDDB, int PKBFIOIHAOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public unsafe delegate void OAMEOPPMBJF([NoAlias] PKKNLFDDHKF.MOOHCIFBECK* JNKDBBJFFKP, [In][NoAlias] NALGHMPKELB* BIAKPLJDFKD, [In][NoAlias] byte* BNNJCFNNDDB, int PKBFIOIHAOL);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	internal static class JAHCIDGJAJO
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7BB9E10", Offset = "0x7BB8610", VA = "0x187BB9E10")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7BB9CC0", Offset = "0x7BB84C0", VA = "0x187BB9CC0")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7BBA2E0", Offset = "0x7BB8AE0", VA = "0x187BBA2E0")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7BB9F30", Offset = "0x7BB8730", VA = "0x187BB9F30")]
		public unsafe static void GINPGABDCGP([NoAlias] PKKNLFDDHKF.MOOHCIFBECK* JNKDBBJFFKP, [In][NoAlias] NALGHMPKELB* BIAKPLJDFKD, [In][NoAlias] byte* BNNJCFNNDDB, int PKBFIOIHAOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public unsafe delegate void OJGBICNHOBA([NoAlias] PKKNLFDDHKF.HOBMHNHOPFB* JNKDBBJFFKP, [In][NoAlias] NALGHMPKELB* BIAKPLJDFKD, [In][NoAlias] byte* BNNJCFNNDDB, int PKBFIOIHAOL);

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal static class LLNEBDPLFLP
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7BBD9E0", Offset = "0x7BBC1E0", VA = "0x187BBD9E0")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7BBD890", Offset = "0x7BBC090", VA = "0x187BBD890")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7BBDEC0", Offset = "0x7BBC6C0", VA = "0x187BBDEC0")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7BBDB00", Offset = "0x7BBC300", VA = "0x187BBDB00")]
		public unsafe static void GINPGABDCGP([NoAlias] PKKNLFDDHKF.HOBMHNHOPFB* JNKDBBJFFKP, [In][NoAlias] NALGHMPKELB* BIAKPLJDFKD, [In][NoAlias] byte* BNNJCFNNDDB, int PKBFIOIHAOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public unsafe delegate void MHBMGCKMMLK([NoAlias] PKKNLFDDHKF.MDDBIEOGPIM* JNKDBBJFFKP, [In][NoAlias] NALGHMPKELB* BIAKPLJDFKD, [In][NoAlias] byte* BNNJCFNNDDB, int PKBFIOIHAOL);

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	internal static class PPDALHCDANN
	{
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7BCA110", Offset = "0x7BC8910", VA = "0x187BCA110")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7BC9FC0", Offset = "0x7BC87C0", VA = "0x187BC9FC0")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7BCA5E0", Offset = "0x7BC8DE0", VA = "0x187BCA5E0")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7BCA230", Offset = "0x7BC8A30", VA = "0x187BCA230")]
		public unsafe static void GINPGABDCGP([NoAlias] PKKNLFDDHKF.MDDBIEOGPIM* JNKDBBJFFKP, [In][NoAlias] NALGHMPKELB* BIAKPLJDFKD, [In][NoAlias] byte* BNNJCFNNDDB, int PKBFIOIHAOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public unsafe delegate void BGDADJKKGIC([NoAlias] PKKNLFDDHKF.LAFBFKCBMPA* JNKDBBJFFKP, [In][NoAlias] NALGHMPKELB* BIAKPLJDFKD, [In][NoAlias] byte* BNNJCFNNDDB, int PKBFIOIHAOL);

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal static class PAHINMCCMGC
	{
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2CE0", Offset = "0x7BC14E0", VA = "0x187BC2CE0")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2B90", Offset = "0x7BC1390", VA = "0x187BC2B90")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3020", Offset = "0x7BC1820", VA = "0x187BC3020")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2E00", Offset = "0x7BC1600", VA = "0x187BC2E00")]
		public unsafe static void GINPGABDCGP([NoAlias] PKKNLFDDHKF.LAFBFKCBMPA* JNKDBBJFFKP, [In][NoAlias] NALGHMPKELB* BIAKPLJDFKD, [In][NoAlias] byte* BNNJCFNNDDB, int PKBFIOIHAOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public unsafe delegate void ADOJJBIIEAI([NoAlias] PKKNLFDDHKF.MGOBFJFJINC* JNKDBBJFFKP, [In][NoAlias] NALGHMPKELB* BIAKPLJDFKD, [In][NoAlias] byte* BNNJCFNNDDB, int PKBFIOIHAOL);

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	internal static class IFOKKJPHKCD
	{
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7BAE920", Offset = "0x7BAD120", VA = "0x187BAE920")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7BAE7D0", Offset = "0x7BACFD0", VA = "0x187BAE7D0")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7BAEC60", Offset = "0x7BAD460", VA = "0x187BAEC60")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7BAEA40", Offset = "0x7BAD240", VA = "0x187BAEA40")]
		public unsafe static void GINPGABDCGP([NoAlias] PKKNLFDDHKF.MGOBFJFJINC* JNKDBBJFFKP, [In][NoAlias] NALGHMPKELB* BIAKPLJDFKD, [In][NoAlias] byte* BNNJCFNNDDB, int PKBFIOIHAOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public unsafe delegate int JPILCOFBLBP([NoAlias] byte* BHDLIFHPIBD, [In][NoAlias] int* NFGJIHDBFMG, int CDDKOLLCKEC);

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal static class NLCMBPJOJHK
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1620", Offset = "0x7BBFE20", VA = "0x187BC1620")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7BC14D0", Offset = "0x7BBFCD0", VA = "0x187BC14D0")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7BC19D0", Offset = "0x7BC01D0", VA = "0x187BC19D0")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1740", Offset = "0x7BBFF40", VA = "0x187BC1740")]
		public unsafe static int GINPGABDCGP([NoAlias] byte* BHDLIFHPIBD, [In][NoAlias] int* NFGJIHDBFMG, int CDDKOLLCKEC)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public unsafe delegate void OLAPBAEMNJJ([NoAlias] int* IGGINHIPFPC, [In][NoAlias] byte* LJKKINNANOD, int EKBBKNBDGCA);

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal static class JLEOACHCFEB
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7BBB570", Offset = "0x7BB9D70", VA = "0x187BBB570")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7BBB420", Offset = "0x7BB9C20", VA = "0x187BBB420")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7BBB8F0", Offset = "0x7BBA0F0", VA = "0x187BBB8F0")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7BBB690", Offset = "0x7BB9E90", VA = "0x187BBB690")]
		public unsafe static void GINPGABDCGP([NoAlias] int* IGGINHIPFPC, [In][NoAlias] byte* LJKKINNANOD, int EKBBKNBDGCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public unsafe delegate void DPGEEAOCDNI([NoAlias] ushort* IGGINHIPFPC, [In][NoAlias] byte* LJKKINNANOD, int EKBBKNBDGCA);

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal static class HPGFHOHIMDG
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7BAE3B0", Offset = "0x7BACBB0", VA = "0x187BAE3B0")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7BAE260", Offset = "0x7BACA60", VA = "0x187BAE260")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7BAE730", Offset = "0x7BACF30", VA = "0x187BAE730")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7BAE4D0", Offset = "0x7BACCD0", VA = "0x187BAE4D0")]
		public unsafe static void GINPGABDCGP([NoAlias] ushort* IGGINHIPFPC, [In][NoAlias] byte* LJKKINNANOD, int EKBBKNBDGCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public delegate void CAEABAONIEF([Out] float3 FALOLAKNOAA, ushort CPIAKHMHDHF);

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal static class MGKLMMLDCNL
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF090", Offset = "0x7BBD890", VA = "0x187BBF090")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7BBEF40", Offset = "0x7BBD740", VA = "0x187BBEF40")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF3B0", Offset = "0x7BBDBB0", VA = "0x187BBF3B0")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF1B0", Offset = "0x7BBD9B0", VA = "0x187BBF1B0")]
		public static void GINPGABDCGP([Out] float3 FALOLAKNOAA, ushort CPIAKHMHDHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public delegate ushort GOELNJENEOK([In] float3 PNEBLLCACFD);

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	internal static class KEJFACNNGNE
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC2E0", Offset = "0x7BBAAE0", VA = "0x187BBC2E0")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC190", Offset = "0x7BBA990", VA = "0x187BBC190")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC5F0", Offset = "0x7BBADF0", VA = "0x187BBC5F0")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC400", Offset = "0x7BBAC00", VA = "0x187BBC400")]
		public static ushort GINPGABDCGP([In] float3 PNEBLLCACFD)
		{
			return default(ushort);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly ProfilerMarker DJCPJALIEAG;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly ProfilerMarker BDHKEMLBMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int PKBFIOIHAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int EKBBKNBDGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NativeArray<ushort> FNMEPMNCJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public NativeArray<ushort> MGBCOPHNCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public NativeArray<ushort> FNNEEPHEDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NativeArray<uint> GFFDGIHFGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeArray<NALGHMPKELB> JDJEBBAHLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeArray<byte> CIJHMINEMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeArray<byte> NKDBAHNOGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 NOKJBEEPBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3 BDAOACNGPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public float2 DPMJCCLLCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float2 FAIAGJPDHEJ;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static long PIEMMLPPEEM;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static long LDFNHGNPCIL;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static float FDJHGCKEDMK;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static bool EJLPFHHINID;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool KBDBMNHHFOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7BB6810", Offset = "0x7BB5010", VA = "0x187BB6810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool ODPHDBFEPML
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7BAFB50", Offset = "0x7BAE350", VA = "0x187BAFB50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7BB8730", Offset = "0x7BB6F30", VA = "0x187BB8730")]
	public void OCOBEACFBKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7BB78C0", Offset = "0x7BB60C0", VA = "0x187BB78C0")]
	public static IHLJGJEJFHB NKIHIDGHACP(Allocator KKCJNCNIICO, NativeArray<float3> KHMHCAMLHIO, NativeArray<float3> CCLLNIIJGJE, NativeArray<float2> KJPICJKEGIN, NativeArray<float4> PFGOHPBHFJE, bool MJICMJNJLPO, NativeArray<float4> CFDIIPKIDOK, NativeArray<int> NFGJIHDBFMG, int PKBFIOIHAOL, int EGPENIMLBAJ, int EKBBKNBDGCA, int OMGJAJJIOFN)
	{
		return default(IHLJGJEJFHB);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7BB5280", Offset = "0x7BB3A80", VA = "0x187BB5280")]
	public PKKNLFDDHKF ILMHFKCKLNK(Allocator KKCJNCNIICO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7BB5320", Offset = "0x7BB3B20", VA = "0x187BB5320")]
	public void ILMHFKCKLNK(PKKNLFDDHKF HLPIAOANGMD, Allocator KKCJNCNIICO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7BAFCF0", Offset = "0x7BAE4F0", VA = "0x187BAFCF0")]
	public void BDAKODADCDP(Mesh ABAPBBKNPBC, bool CHEKCBNHAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7BB7690", Offset = "0x7BB5E90", VA = "0x187BB7690")]
	private void NIGCDLOMINM(Mesh ABAPBBKNPBC, NativeArray<ushort> MAKHNJGJMCI, bool CHEKCBNHAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7BAFE10", Offset = "0x7BAE610", VA = "0x187BAFE10")]
	public void BGPJDCJCMGL(Mesh ABAPBBKNPBC, bool CHEKCBNHAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7BB4C30", Offset = "0x7BB3430", VA = "0x187BB4C30")]
	public void ILEGHNOHKMG(Mesh ABAPBBKNPBC, bool CHEKCBNHAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7BB0730", Offset = "0x7BAEF30", VA = "0x187BB0730")]
	public void CBOLDHIAANM(Mesh ABAPBBKNPBC, bool CHEKCBNHAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2330", Offset = "0x7BB0B30", VA = "0x187BB2330")]
	public void EPLCDBJMNIH(Mesh ABAPBBKNPBC, bool CHEKCBNHAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7BB4620", Offset = "0x7BB2E20", VA = "0x187BB4620")]
	public void IIJOCKMMHPD(Mesh ABAPBBKNPBC, bool CHEKCBNHAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7BB8240", Offset = "0x7BB6A40", VA = "0x187BB8240")]
	public void OANKAIJJCOE(Mesh ABAPBBKNPBC, PKKNLFDDHKF.EHNEFMAHLAI CGJBGKAIMNA, bool CHEKCBNHAJH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7BB4560", Offset = "0x7BB2D60", VA = "0x187BB4560")]
	public long IFGEPPHAFJH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2FA0", Offset = "0x7BB17A0", VA = "0x187BB2FA0")]
	public long FINBLHBMFPG(PKKNLFDDHKF.EHNEFMAHLAI CGJBGKAIMNA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7BB5A50", Offset = "0x7BB4250", VA = "0x187BB5A50")]
	private void JDJGCBPDGJD(int JCDJHOHOPJC, int HFGIBGEKDDK, Allocator KKCJNCNIICO, bool CEAMFOHPAPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7BB37B0", Offset = "0x7BB1FB0", VA = "0x187BB37B0")]
	private void GPKJJOAOFMM(NativeArray<float3> JNKDBBJFFKP, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7BB3730", Offset = "0x7BB1F30", VA = "0x187BB3730")]
	[BurstCompile]
	private unsafe static void GPKJJOAOFMM([NoAlias] float3* JNKDBBJFFKP, [In][NoAlias] ushort* KHMHCAMLHIO, int PKBFIOIHAOL, [In] float3 NOKJBEEPBGK, [In] float3 BDAOACNGPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7BAF580", Offset = "0x7BADD80", VA = "0x187BAF580")]
	[BurstCompile]
	private unsafe static void ADJLFCMLKGH([NoAlias] PKKNLFDDHKF.MOOHCIFBECK* JNKDBBJFFKP, [In][NoAlias] ushort* KHMHCAMLHIO, int PKBFIOIHAOL, [In] float3 NOKJBEEPBGK, [In] float3 BDAOACNGPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2F20", Offset = "0x7BB1720", VA = "0x187BB2F20")]
	[BurstCompile]
	private unsafe static void FIEIFMDDHCE([NoAlias] PKKNLFDDHKF.HOBMHNHOPFB* JNKDBBJFFKP, [In][NoAlias] ushort* KHMHCAMLHIO, int PKBFIOIHAOL, [In] float3 NOKJBEEPBGK, [In] float3 BDAOACNGPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2B80", Offset = "0x7BB1380", VA = "0x187BB2B80")]
	[BurstCompile]
	private unsafe static void FEECBOHBBDK([NoAlias] PKKNLFDDHKF.MDDBIEOGPIM* JNKDBBJFFKP, [In][NoAlias] ushort* KHMHCAMLHIO, int PKBFIOIHAOL, [In] float3 NOKJBEEPBGK, [In] float3 BDAOACNGPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7BB36B0", Offset = "0x7BB1EB0", VA = "0x187BB36B0")]
	[BurstCompile]
	private unsafe static void GIPCLBFNIEH([NoAlias] PKKNLFDDHKF.LAFBFKCBMPA* JNKDBBJFFKP, [In][NoAlias] ushort* KHMHCAMLHIO, int PKBFIOIHAOL, [In] float3 NOKJBEEPBGK, [In] float3 BDAOACNGPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7BAF600", Offset = "0x7BADE00", VA = "0x187BAF600")]
	[BurstCompile]
	private unsafe static void AFMJMFCPIPP([NoAlias] PKKNLFDDHKF.MGOBFJFJINC* JNKDBBJFFKP, [In][NoAlias] ushort* KHMHCAMLHIO, int PKBFIOIHAOL, [In] float3 NOKJBEEPBGK, [In] float3 BDAOACNGPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7BB5CE0", Offset = "0x7BB44E0", VA = "0x187BB5CE0")]
	private void JOBGIDEPNBP(NativeArray<float3> KHMHCAMLHIO, int OMGJAJJIOFN, int HFGIBGEKDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7BB5E00", Offset = "0x7BB4600", VA = "0x187BB5E00")]
	[BurstCompile]
	private unsafe static void JOBGIDEPNBP([NoAlias] ushort* JNKDBBJFFKP, [Out] float3 DOJNAGKJEFC, [Out] float3 BDAOACNGPKA, [In][NoAlias] float3* KHMHCAMLHIO, int OMGJAJJIOFN, int HFGIBGEKDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2C00", Offset = "0x7BB1400", VA = "0x187BB2C00")]
	private void FGIBLFNKPCL(NativeArray<float3> CCLLNIIJGJE, int OMGJAJJIOFN, int HFGIBGEKDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2CE0", Offset = "0x7BB14E0", VA = "0x187BB2CE0")]
	[BurstCompile]
	private unsafe static void FGIBLFNKPCL([NoAlias] ushort* GIMAMDDJMPK, [In][NoAlias] float3* CCLLNIIJGJE, int HFGIBGEKDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7BB31C0", Offset = "0x7BB19C0", VA = "0x187BB31C0")]
	private void FODDOCMFJAB(NativeArray<float3> NCFBIEKLIPN, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7BB3280", Offset = "0x7BB1A80", VA = "0x187BB3280")]
	[BurstCompile]
	private unsafe static void FODDOCMFJAB([NoAlias] float3* NCFBIEKLIPN, [In][NoAlias] ushort* CCLLNIIJGJE, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7BB38D0", Offset = "0x7BB20D0", VA = "0x187BB38D0")]
	[BurstCompile]
	private unsafe static void GPLGKPFJKGG([NoAlias] PKKNLFDDHKF.MOOHCIFBECK* JNKDBBJFFKP, [In][NoAlias] ushort* CCLLNIIJGJE, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7BB3640", Offset = "0x7BB1E40", VA = "0x187BB3640")]
	[BurstCompile]
	private unsafe static void GIBPKFPMINN([NoAlias] PKKNLFDDHKF.HOBMHNHOPFB* JNKDBBJFFKP, [In][NoAlias] ushort* CCLLNIIJGJE, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7BB8BC0", Offset = "0x7BB73C0", VA = "0x187BB8BC0")]
	[BurstCompile]
	private unsafe static void PDFEEMNCBCF([NoAlias] PKKNLFDDHKF.MDDBIEOGPIM* JNKDBBJFFKP, [In][NoAlias] ushort* CCLLNIIJGJE, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7BB57A0", Offset = "0x7BB3FA0", VA = "0x187BB57A0")]
	[BurstCompile]
	private unsafe static void INOKILKDFGH([NoAlias] PKKNLFDDHKF.LAFBFKCBMPA* JNKDBBJFFKP, [In][NoAlias] ushort* CCLLNIIJGJE, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7BAF3A0", Offset = "0x7BADBA0", VA = "0x187BAF3A0")]
	[BurstCompile]
	private unsafe static void ACBJHFEEDCO([NoAlias] PKKNLFDDHKF.MGOBFJFJINC* JNKDBBJFFKP, [In][NoAlias] ushort* CCLLNIIJGJE, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7BB61B0", Offset = "0x7BB49B0", VA = "0x187BB61B0")]
	private void KGCHJBOJMFM(NativeArray<float2> KJPICJKEGIN, int OMGJAJJIOFN, int HFGIBGEKDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7BB62D0", Offset = "0x7BB4AD0", VA = "0x187BB62D0")]
	[BurstCompile]
	private unsafe static void KGCHJBOJMFM([NoAlias] uint* GKOKOJPGHBG, [Out] float2 EGILMFMLDCO, [Out] float2 FAIAGJPDHEJ, [In][NoAlias] float2* KJPICJKEGIN, int OMGJAJJIOFN, int HFGIBGEKDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7BB1DA0", Offset = "0x7BB05A0", VA = "0x187BB1DA0")]
	[BurstCompile]
	private static void DJFMGPHOHBA([Out] float2 FALOLAKNOAA, uint CPIAKHMHDHF, [In] float2 DPMJCCLLCLN, [In] float2 FAIAGJPDHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7BB8850", Offset = "0x7BB7050", VA = "0x187BB8850")]
	private void OGJBJNLLGHD(NativeArray<float2> GKOKOJPGHBG, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7BB8970", Offset = "0x7BB7170", VA = "0x187BB8970")]
	[BurstCompile]
	private unsafe static void OGJBJNLLGHD([NoAlias] float2* GKOKOJPGHBG, [NoAlias] uint* KJPICJKEGIN, int PKBFIOIHAOL, [In] float2 DPMJCCLLCLN, [In] float2 FAIAGJPDHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7BB22B0", Offset = "0x7BB0AB0", VA = "0x187BB22B0")]
	[BurstCompile]
	private unsafe static void EJNEHGIPOND([NoAlias] PKKNLFDDHKF.MOOHCIFBECK* JNKDBBJFFKP, [NoAlias] uint* KJPICJKEGIN, int PKBFIOIHAOL, [In] float2 DPMJCCLLCLN, [In] float2 FAIAGJPDHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7BB6360", Offset = "0x7BB4B60", VA = "0x187BB6360")]
	[BurstCompile]
	private unsafe static void KHHCBIGDGAJ([NoAlias] PKKNLFDDHKF.HOBMHNHOPFB* JNKDBBJFFKP, [NoAlias] uint* KJPICJKEGIN, int PKBFIOIHAOL, [In] float2 DPMJCCLLCLN, [In] float2 FAIAGJPDHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7BB7610", Offset = "0x7BB5E10", VA = "0x187BB7610")]
	[BurstCompile]
	private unsafe static void NHODMLEEILA([NoAlias] PKKNLFDDHKF.MDDBIEOGPIM* JNKDBBJFFKP, [NoAlias] uint* KJPICJKEGIN, int PKBFIOIHAOL, [In] float2 DPMJCCLLCLN, [In] float2 FAIAGJPDHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7BB74B0", Offset = "0x7BB5CB0", VA = "0x187BB74B0")]
	[BurstCompile]
	private unsafe static void NDEJIMBNGGJ([NoAlias] PKKNLFDDHKF.LAFBFKCBMPA* JNKDBBJFFKP, [NoAlias] uint* KJPICJKEGIN, int PKBFIOIHAOL, [In] float2 DPMJCCLLCLN, [In] float2 FAIAGJPDHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7BAFAD0", Offset = "0x7BAE2D0", VA = "0x187BAFAD0")]
	[BurstCompile]
	private unsafe static void APKNOJKPPIG([NoAlias] PKKNLFDDHKF.MGOBFJFJINC* JNKDBBJFFKP, [NoAlias] uint* KJPICJKEGIN, int PKBFIOIHAOL, [In] float2 DPMJCCLLCLN, [In] float2 FAIAGJPDHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7BB8CB0", Offset = "0x7BB74B0", VA = "0x187BB8CB0")]
	private void PJHPMCAKKBC(NativeArray<float4> CFDIIPKIDOK, int OMGJAJJIOFN, int HFGIBGEKDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7BB8C30", Offset = "0x7BB7430", VA = "0x187BB8C30")]
	[BurstCompile]
	private unsafe static void PJHPMCAKKBC([NoAlias] ushort* GOJFOAIJKHO, [In][NoAlias] float4* HMLPMPOMMDE, int OMGJAJJIOFN, int HFGIBGEKDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7BB8B70", Offset = "0x7BB7370", VA = "0x187BB8B70")]
	[BurstCompile]
	private static ushort PBAAPCNBCHB([In] float4 PNEBLLCACFD)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7BAFC00", Offset = "0x7BAE400", VA = "0x187BAFC00")]
	private void BCOAGIKDDBJ(NativeArray<float4> GOJFOAIJKHO, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7BAFB90", Offset = "0x7BAE390", VA = "0x187BAFB90")]
	[BurstCompile]
	private unsafe static void BCOAGIKDDBJ([NoAlias] float4* GOJFOAIJKHO, [In][NoAlias] ushort* CFDIIPKIDOK, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2940", Offset = "0x7BB1140", VA = "0x187BB2940")]
	[BurstCompile]
	private unsafe static void FAOADIMBCGM([NoAlias] PKKNLFDDHKF.MOOHCIFBECK* JNKDBBJFFKP, [In][NoAlias] ushort* CFDIIPKIDOK, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7BB7530", Offset = "0x7BB5D30", VA = "0x187BB7530")]
	[BurstCompile]
	private unsafe static void NEHNHHJAEMH([NoAlias] PKKNLFDDHKF.HOBMHNHOPFB* JNKDBBJFFKP, [In][NoAlias] ushort* CFDIIPKIDOK, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7BB89F0", Offset = "0x7BB71F0", VA = "0x187BB89F0")]
	[BurstCompile]
	private unsafe static void OHEKFOILAAJ([NoAlias] PKKNLFDDHKF.MDDBIEOGPIM* JNKDBBJFFKP, [In][NoAlias] ushort* CFDIIPKIDOK, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7BB75A0", Offset = "0x7BB5DA0", VA = "0x187BB75A0")]
	[BurstCompile]
	private unsafe static void NGJPDHBLJEP([NoAlias] PKKNLFDDHKF.LAFBFKCBMPA* JNKDBBJFFKP, [In][NoAlias] ushort* CFDIIPKIDOK, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7BB6140", Offset = "0x7BB4940", VA = "0x187BB6140")]
	[BurstCompile]
	private unsafe static void KFDBEKLOFMA([NoAlias] PKKNLFDDHKF.MGOBFJFJINC* JNKDBBJFFKP, [In][NoAlias] ushort* CFDIIPKIDOK, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7BB3FE0", Offset = "0x7BB27E0", VA = "0x187BB3FE0")]
	[BurstCompile]
	private static void HIAFPPFDHFM([Out] float4 HLPIAOANGMD, ushort CPIAKHMHDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7BB6D10", Offset = "0x7BB5510", VA = "0x187BB6D10")]
	private void MEPFIDJADCC(Allocator KKCJNCNIICO, NativeArray<float4> PFGOHPBHFJE, int OMGJAJJIOFN, int HFGIBGEKDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7BB7150", Offset = "0x7BB5950", VA = "0x187BB7150")]
	[BurstCompile]
	private unsafe static void MEPFIDJADCC([NoAlias] float4* EJGMBAJEOAA, [NoAlias] byte* FLDELKHHFPJ, [Out] int HBOMHPIIMMH, [Out] int FHCBINIFHGF, [NoAlias] float4* PFGOHPBHFJE, int OMGJAJJIOFN, int HFGIBGEKDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7BB3090", Offset = "0x7BB1890", VA = "0x187BB3090")]
	private static void FMEANKKLBMA(NativeArray<float4> ELMDFHIGGOF, NativeArray<NALGHMPKELB> BIAKPLJDFKD, NativeArray<byte> BNNJCFNNDDB, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7BB3010", Offset = "0x7BB1810", VA = "0x187BB3010")]
	[BurstCompile]
	private unsafe static void FMEANKKLBMA([NoAlias] float4* ELMDFHIGGOF, [In][NoAlias] NALGHMPKELB* BIAKPLJDFKD, [In][NoAlias] byte* BNNJCFNNDDB, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7BB3F60", Offset = "0x7BB2760", VA = "0x187BB3F60")]
	[BurstCompile]
	private unsafe static void HEECELBFBHB([NoAlias] PKKNLFDDHKF.MOOHCIFBECK* JNKDBBJFFKP, [In][NoAlias] NALGHMPKELB* BIAKPLJDFKD, [In][NoAlias] byte* BNNJCFNNDDB, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7BB1BE0", Offset = "0x7BB03E0", VA = "0x187BB1BE0")]
	[BurstCompile]
	private unsafe static void DDICINLLFKG([NoAlias] PKKNLFDDHKF.HOBMHNHOPFB* JNKDBBJFFKP, [In][NoAlias] NALGHMPKELB* BIAKPLJDFKD, [In][NoAlias] byte* BNNJCFNNDDB, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7BB34C0", Offset = "0x7BB1CC0", VA = "0x187BB34C0")]
	[BurstCompile]
	private unsafe static void GBKMDOEMGDF([NoAlias] PKKNLFDDHKF.MDDBIEOGPIM* JNKDBBJFFKP, [In][NoAlias] NALGHMPKELB* BIAKPLJDFKD, [In][NoAlias] byte* BNNJCFNNDDB, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7BAF740", Offset = "0x7BADF40", VA = "0x187BAF740")]
	[BurstCompile]
	private unsafe static void AJNGPOPMLEK([NoAlias] PKKNLFDDHKF.LAFBFKCBMPA* JNKDBBJFFKP, [In][NoAlias] NALGHMPKELB* BIAKPLJDFKD, [In][NoAlias] byte* BNNJCFNNDDB, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2050", Offset = "0x7BB0850", VA = "0x187BB2050")]
	[BurstCompile]
	private unsafe static void EFFBIJMCBAO([NoAlias] PKKNLFDDHKF.MGOBFJFJINC* JNKDBBJFFKP, [In][NoAlias] NALGHMPKELB* BIAKPLJDFKD, [In][NoAlias] byte* BNNJCFNNDDB, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7BB73B0", Offset = "0x7BB5BB0", VA = "0x187BB73B0")]
	private void NDCIHKILPCB(Allocator KKCJNCNIICO, NativeArray<int> NFGJIHDBFMG, int OMGJAJJIOFN, int HFGIBGEKDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7BB0460", Offset = "0x7BAEC60", VA = "0x187BB0460")]
	private static NativeArray<byte> BOIPGPOHLGC(Allocator KKCJNCNIICO, NativeArray<int> NFGJIHDBFMG, int CDDKOLLCKEC)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7BB03F0", Offset = "0x7BAEBF0", VA = "0x187BB03F0")]
	[BurstCompile]
	private unsafe static int BOIPGPOHLGC([NoAlias] byte* BHDLIFHPIBD, [In][NoAlias] int* NFGJIHDBFMG, int CDDKOLLCKEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7BB5BF0", Offset = "0x7BB43F0", VA = "0x187BB5BF0")]
	private static void JIKEMGBPEIG(NativeArray<int> IGGINHIPFPC, NativeArray<byte> LJKKINNANOD, int EKBBKNBDGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7BB5B80", Offset = "0x7BB4380", VA = "0x187BB5B80")]
	[BurstCompile]
	private unsafe static void JIKEMGBPEIG([NoAlias] int* IGGINHIPFPC, [In][NoAlias] byte* LJKKINNANOD, int EKBBKNBDGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7BB4040", Offset = "0x7BB2840", VA = "0x187BB4040")]
	[BurstCompile]
	private unsafe static void HLNDECANCOF([NoAlias] ushort* IGGINHIPFPC, [In][NoAlias] byte* LJKKINNANOD, int EKBBKNBDGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7BB1E20", Offset = "0x7BB0620", VA = "0x187BB1E20")]
	[BurstCompile]
	private static void EBBKBNJGIGB([Out] float3 FALOLAKNOAA, ushort CPIAKHMHDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7BB63E0", Offset = "0x7BB4BE0", VA = "0x187BB63E0")]
	[BurstCompile]
	private static ushort KJDCCBICCNP([In] float3 PNEBLLCACFD)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7BA7150", Offset = "0x7BA5950", VA = "0x187BA7150")]
	[BurstCompile]
	public unsafe static void FLOFFDDFFPG([NoAlias] float3* JNKDBBJFFKP, [In][NoAlias] ushort* KHMHCAMLHIO, int PKBFIOIHAOL, [In] float3 NOKJBEEPBGK, [In] float3 BDAOACNGPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7BAF680", Offset = "0x7BADE80", VA = "0x187BAF680")]
	[BurstCompile]
	public unsafe static void AGEBIJHMKBP([NoAlias] PKKNLFDDHKF.MOOHCIFBECK* JNKDBBJFFKP, [In][NoAlias] ushort* KHMHCAMLHIO, int PKBFIOIHAOL, [In] float3 NOKJBEEPBGK, [In] float3 BDAOACNGPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7BB56E0", Offset = "0x7BB3EE0", VA = "0x187BB56E0")]
	[BurstCompile]
	public unsafe static void ILPDAOPOKKE([NoAlias] PKKNLFDDHKF.HOBMHNHOPFB* JNKDBBJFFKP, [In][NoAlias] ushort* KHMHCAMLHIO, int PKBFIOIHAOL, [In] float3 NOKJBEEPBGK, [In] float3 BDAOACNGPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7BB0F60", Offset = "0x7BAF760", VA = "0x187BB0F60")]
	[BurstCompile]
	public unsafe static void CGONNJJALME([NoAlias] PKKNLFDDHKF.MDDBIEOGPIM* JNKDBBJFFKP, [In][NoAlias] ushort* KHMHCAMLHIO, int PKBFIOIHAOL, [In] float3 NOKJBEEPBGK, [In] float3 BDAOACNGPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7BB0F60", Offset = "0x7BAF760", VA = "0x187BB0F60")]
	[BurstCompile]
	public unsafe static void FCKAMDPOMND([NoAlias] PKKNLFDDHKF.LAFBFKCBMPA* JNKDBBJFFKP, [In][NoAlias] ushort* KHMHCAMLHIO, int PKBFIOIHAOL, [In] float3 NOKJBEEPBGK, [In] float3 BDAOACNGPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7BB6BB0", Offset = "0x7BB53B0", VA = "0x187BB6BB0")]
	[BurstCompile]
	public unsafe static void LOJBOKCENMC([NoAlias] PKKNLFDDHKF.MGOBFJFJINC* JNKDBBJFFKP, [In][NoAlias] ushort* KHMHCAMLHIO, int PKBFIOIHAOL, [In] float3 NOKJBEEPBGK, [In] float3 BDAOACNGPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6750", Offset = "0x7BA4F50", VA = "0x187BA6750")]
	[BurstCompile]
	public unsafe static void DEHDGACPGBO([NoAlias] ushort* JNKDBBJFFKP, [Out] float3 DOJNAGKJEFC, [Out] float3 BDAOACNGPKA, [In][NoAlias] float3* KHMHCAMLHIO, int OMGJAJJIOFN, int HFGIBGEKDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7BB1610", Offset = "0x7BAFE10", VA = "0x187BB1610")]
	[BurstCompile]
	public unsafe static void CPMGMMCNBPJ([NoAlias] ushort* GIMAMDDJMPK, [In][NoAlias] float3* CCLLNIIJGJE, int HFGIBGEKDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7BB6910", Offset = "0x7BB5110", VA = "0x187BB6910")]
	[BurstCompile]
	public unsafe static void LHNPGBABELH([NoAlias] float3* NCFBIEKLIPN, [In][NoAlias] ushort* CCLLNIIJGJE, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7BB1990", Offset = "0x7BB0190", VA = "0x187BB1990")]
	[BurstCompile]
	public unsafe static void DBIBFCJEEGC([NoAlias] PKKNLFDDHKF.MOOHCIFBECK* JNKDBBJFFKP, [In][NoAlias] ushort* CCLLNIIJGJE, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7BB1150", Offset = "0x7BAF950", VA = "0x187BB1150")]
	[BurstCompile]
	public unsafe static void CKHJEHKHPPK([NoAlias] PKKNLFDDHKF.HOBMHNHOPFB* JNKDBBJFFKP, [In][NoAlias] ushort* CCLLNIIJGJE, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7BB1290", Offset = "0x7BAFA90", VA = "0x187BB1290")]
	[BurstCompile]
	public unsafe static void CPCAONNFGKN([NoAlias] PKKNLFDDHKF.MDDBIEOGPIM* JNKDBBJFFKP, [In][NoAlias] ushort* CCLLNIIJGJE, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7BAF410", Offset = "0x7BADC10", VA = "0x187BAF410")]
	[BurstCompile]
	public unsafe static void ADJCLJAEODO([NoAlias] PKKNLFDDHKF.LAFBFKCBMPA* JNKDBBJFFKP, [In][NoAlias] ushort* CCLLNIIJGJE, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7BB5E90", Offset = "0x7BB4690", VA = "0x187BB5E90")]
	[BurstCompile]
	public unsafe static void KDIAHKLNIFH([NoAlias] PKKNLFDDHKF.MGOBFJFJINC* JNKDBBJFFKP, [In][NoAlias] ushort* CCLLNIIJGJE, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6E90", Offset = "0x7BA5690", VA = "0x187BA6E90")]
	[BurstCompile]
	public unsafe static void EDEABNKPPNO([NoAlias] uint* GKOKOJPGHBG, [Out] float2 EGILMFMLDCO, [Out] float2 FAIAGJPDHEJ, [In][NoAlias] float2* KJPICJKEGIN, int OMGJAJJIOFN, int HFGIBGEKDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7BB43B0", Offset = "0x7BB2BB0", VA = "0x187BB43B0")]
	[BurstCompile]
	public static void ICPBNBFKAFO([Out] float2 FALOLAKNOAA, uint CPIAKHMHDHF, [In] float2 DPMJCCLLCLN, [In] float2 FAIAGJPDHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7BB8A60", Offset = "0x7BB7260", VA = "0x187BB8A60")]
	[BurstCompile]
	public unsafe static void OPFPPCFAFHI([NoAlias] float2* GKOKOJPGHBG, [NoAlias] uint* KJPICJKEGIN, int PKBFIOIHAOL, [In] float2 DPMJCCLLCLN, [In] float2 FAIAGJPDHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7BB6000", Offset = "0x7BB4800", VA = "0x187BB6000")]
	[BurstCompile]
	public unsafe static void KFBMNBFNJDI([NoAlias] PKKNLFDDHKF.MOOHCIFBECK* JNKDBBJFFKP, [NoAlias] uint* KJPICJKEGIN, int PKBFIOIHAOL, [In] float2 DPMJCCLLCLN, [In] float2 FAIAGJPDHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7BB71E0", Offset = "0x7BB59E0", VA = "0x187BB71E0")]
	[BurstCompile]
	public unsafe static void MJBKIACPHII([NoAlias] PKKNLFDDHKF.HOBMHNHOPFB* JNKDBBJFFKP, [NoAlias] uint* KJPICJKEGIN, int PKBFIOIHAOL, [In] float2 DPMJCCLLCLN, [In] float2 FAIAGJPDHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7BB40B0", Offset = "0x7BB28B0", VA = "0x187BB40B0")]
	[BurstCompile]
	public unsafe static void HMJJOEGPNOL([NoAlias] PKKNLFDDHKF.MDDBIEOGPIM* JNKDBBJFFKP, [NoAlias] uint* KJPICJKEGIN, int PKBFIOIHAOL, [In] float2 DPMJCCLLCLN, [In] float2 FAIAGJPDHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7BAF9A0", Offset = "0x7BAE1A0", VA = "0x187BAF9A0")]
	[BurstCompile]
	public unsafe static void AOLHBCBIKOF([NoAlias] PKKNLFDDHKF.LAFBFKCBMPA* JNKDBBJFFKP, [NoAlias] uint* KJPICJKEGIN, int PKBFIOIHAOL, [In] float2 DPMJCCLLCLN, [In] float2 FAIAGJPDHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7BB1020", Offset = "0x7BAF820", VA = "0x187BB1020")]
	[BurstCompile]
	public unsafe static void CIENDHEFFBH([NoAlias] PKKNLFDDHKF.MGOBFJFJINC* JNKDBBJFFKP, [NoAlias] uint* KJPICJKEGIN, int PKBFIOIHAOL, [In] float2 DPMJCCLLCLN, [In] float2 FAIAGJPDHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7BB42D0", Offset = "0x7BB2AD0", VA = "0x187BB42D0")]
	[BurstCompile]
	public unsafe static void HNLOACKINIH([NoAlias] ushort* GOJFOAIJKHO, [In][NoAlias] float4* HMLPMPOMMDE, int OMGJAJJIOFN, int HFGIBGEKDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7BB7320", Offset = "0x7BB5B20", VA = "0x187BB7320")]
	[BurstCompile]
	public static ushort NBDJAEFINMD([In] float4 PNEBLLCACFD)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7BB18B0", Offset = "0x7BB00B0", VA = "0x187BB18B0")]
	[BurstCompile]
	public unsafe static void DACCCGPKLEE([NoAlias] float4* GOJFOAIJKHO, [In][NoAlias] ushort* CFDIIPKIDOK, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7BB7F50", Offset = "0x7BB6750", VA = "0x187BB7F50")]
	[BurstCompile]
	public unsafe static void NPNNGBGMPOD([NoAlias] PKKNLFDDHKF.MOOHCIFBECK* JNKDBBJFFKP, [In][NoAlias] ushort* CFDIIPKIDOK, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7BB43F0", Offset = "0x7BB2BF0", VA = "0x187BB43F0")]
	[BurstCompile]
	public unsafe static void ICPONAPCLHC([NoAlias] PKKNLFDDHKF.HOBMHNHOPFB* JNKDBBJFFKP, [In][NoAlias] ushort* CFDIIPKIDOK, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7BB6600", Offset = "0x7BB4E00", VA = "0x187BB6600")]
	[BurstCompile]
	public unsafe static void LCHGLFJOHEJ([NoAlias] PKKNLFDDHKF.MDDBIEOGPIM* JNKDBBJFFKP, [In][NoAlias] ushort* CFDIIPKIDOK, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7BB7D80", Offset = "0x7BB6580", VA = "0x187BB7D80")]
	[BurstCompile]
	public unsafe static void NOOGCABPAFA([NoAlias] PKKNLFDDHKF.LAFBFKCBMPA* JNKDBBJFFKP, [In][NoAlias] ushort* CFDIIPKIDOK, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7BB3D90", Offset = "0x7BB2590", VA = "0x187BB3D90")]
	[BurstCompile]
	public unsafe static void HDBJOHNBIKJ([NoAlias] PKKNLFDDHKF.MGOBFJFJINC* JNKDBBJFFKP, [In][NoAlias] ushort* CFDIIPKIDOK, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7BB6850", Offset = "0x7BB5050", VA = "0x187BB6850")]
	[BurstCompile]
	public static void LFBNHMEPLPM([Out] float4 HLPIAOANGMD, ushort CPIAKHMHDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6CD0", Offset = "0x7BA54D0", VA = "0x187BA6CD0")]
	[BurstCompile]
	public unsafe static void EBPJKKIFDPN([NoAlias] float4* EJGMBAJEOAA, [NoAlias] byte* FLDELKHHFPJ, [Out] int HBOMHPIIMMH, [Out] int FHCBINIFHGF, [NoAlias] float4* PFGOHPBHFJE, int OMGJAJJIOFN, int HFGIBGEKDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7BB1C60", Offset = "0x7BB0460", VA = "0x187BB1C60")]
	[BurstCompile]
	public unsafe static void DEBGGCDPIOG([NoAlias] float4* ELMDFHIGGOF, [In][NoAlias] NALGHMPKELB* BIAKPLJDFKD, [In][NoAlias] byte* BNNJCFNNDDB, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7BB0D80", Offset = "0x7BAF580", VA = "0x187BB0D80")]
	[BurstCompile]
	public unsafe static void CGGOGOLPJCH([NoAlias] PKKNLFDDHKF.MOOHCIFBECK* JNKDBBJFFKP, [In][NoAlias] NALGHMPKELB* BIAKPLJDFKD, [In][NoAlias] byte* BNNJCFNNDDB, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7BB3BB0", Offset = "0x7BB23B0", VA = "0x187BB3BB0")]
	[BurstCompile]
	public unsafe static void HBEGPAJAAHC([NoAlias] PKKNLFDDHKF.HOBMHNHOPFB* JNKDBBJFFKP, [In][NoAlias] NALGHMPKELB* BIAKPLJDFKD, [In][NoAlias] byte* BNNJCFNNDDB, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7BB8DC0", Offset = "0x7BB75C0", VA = "0x187BB8DC0")]
	[BurstCompile]
	public unsafe static void PJIINCCMLCK([NoAlias] PKKNLFDDHKF.MDDBIEOGPIM* JNKDBBJFFKP, [In][NoAlias] NALGHMPKELB* BIAKPLJDFKD, [In][NoAlias] byte* BNNJCFNNDDB, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7BB13D0", Offset = "0x7BAFBD0", VA = "0x187BB13D0")]
	[BurstCompile]
	public unsafe static void CPFDDICDHDM([NoAlias] PKKNLFDDHKF.LAFBFKCBMPA* JNKDBBJFFKP, [In][NoAlias] NALGHMPKELB* BIAKPLJDFKD, [In][NoAlias] byte* BNNJCFNNDDB, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7BB5810", Offset = "0x7BB4010", VA = "0x187BB5810")]
	[BurstCompile]
	public unsafe static void JDCOIEDDFMP([NoAlias] PKKNLFDDHKF.MGOBFJFJINC* JNKDBBJFFKP, [In][NoAlias] NALGHMPKELB* BIAKPLJDFKD, [In][NoAlias] byte* BNNJCFNNDDB, int PKBFIOIHAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7BB3540", Offset = "0x7BB1D40", VA = "0x187BB3540")]
	[BurstCompile]
	public unsafe static int GDAFPENCFLM([NoAlias] byte* BHDLIFHPIBD, [In][NoAlias] int* NFGJIHDBFMG, int CDDKOLLCKEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7BB6770", Offset = "0x7BB4F70", VA = "0x187BB6770")]
	[BurstCompile]
	public unsafe static void LDHCOAIJFBJ([NoAlias] int* IGGINHIPFPC, [In][NoAlias] byte* LJKKINNANOD, int EKBBKNBDGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7BB3B10", Offset = "0x7BB2310", VA = "0x187BB3B10")]
	[BurstCompile]
	public unsafe static void GPOGPNHDFKO([NoAlias] ushort* IGGINHIPFPC, [In][NoAlias] byte* LJKKINNANOD, int EKBBKNBDGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7BA6B30", Offset = "0x7BA5330", VA = "0x187BA6B30")]
	[BurstCompile]
	public static void DGCPKKBLLLA([Out] float3 FALOLAKNOAA, ushort CPIAKHMHDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7BA75D0", Offset = "0x7BA5DD0", VA = "0x187BA75D0")]
	[BurstCompile]
	public static ushort IOLJMCMIIDK([In] float3 PNEBLLCACFD)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[BurstCompile]
public class PKKNLFDDHKF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public enum EHNEFMAHLAI
	{
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		PosFixedPoint16NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		LAST
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public enum MBHJGDAOABC
	{
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		_,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		_VERTEX_FORMAT_NORMTANOCT8_MATUINT,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		_VERTEX_FORMAT_POSFIXED16_NORMTANOCT8_MATUINT,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		LAST
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct EKLNJDIDCDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public EHNEFMAHLAI CGJBGKAIMNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public bool LBDDJPFBNPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int NNKALAANOOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public VertexAttributeDescriptor[] KKDDIDCGHGK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[BurstCompile]
	public struct JCHIDJDNHBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public float3 NCGKJMOKFAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public float3 GLANACDLEOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float4 EFPHCCMNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public float2 KIPNKFLJOJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float4 JDJEBBAHLBG;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static readonly VertexAttributeDescriptor[] KKDDIDCGHGK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[BurstCompile]
	public struct MOOHCIFBECK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public float3 NCGKJMOKFAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public half4 GLANACDLEOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public half4 EFPHCCMNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public float2 KIPNKFLJOJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public half4 JDJEBBAHLBG;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public static readonly VertexAttributeDescriptor[] KKDDIDCGHGK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[BurstCompile]
	public struct HOBMHNHOPFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public float3 NCGKJMOKFAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public uint GLANACDLEOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public uint EFPHCCMNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public float2 KIPNKFLJOJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public half4 JDJEBBAHLBG;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly VertexAttributeDescriptor[] KKDDIDCGHGK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[BurstCompile]
	public struct MDDBIEOGPIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public float3 NCGKJMOKFAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public uint GLANACDLEOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public uint EFPHCCMNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public half2 KIPNKFLJOJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public half4 JDJEBBAHLBG;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public static readonly VertexAttributeDescriptor[] KKDDIDCGHGK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[BurstCompile]
	public struct LAFBFKCBMPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public float3 NCGKJMOKFAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public uint AFHBLKEJONJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public float2 KIPNKFLJOJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public uint OBCAOAFBBCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public uint PBMCIAKIPDK;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public static readonly VertexAttributeDescriptor[] KKDDIDCGHGK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[BurstCompile]
	public struct MGOBFJFJINC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public KJEODGEEHDG.LIAFEBMGADO LECGCBPNDBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public uint AFHBLKEJONJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public float2 KIPNKFLJOJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public uint OBCAOAFBBCA;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly VertexAttributeDescriptor[] KKDDIDCGHGK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate int NFBNHPBBKCG(float LEFBJAGNHCD);

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	internal static class AKAIMAABICO
	{
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x7BA89E0", Offset = "0x7BA71E0", VA = "0x187BA89E0")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7BA8890", Offset = "0x7BA7090", VA = "0x187BA8890")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7BA8D60", Offset = "0x7BA7560", VA = "0x187BA8D60")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x7BA8B00", Offset = "0x7BA7300", VA = "0x187BA8B00")]
		public static int GINPGABDCGP(float LEFBJAGNHCD)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public delegate uint AAOHPPKIEGH([In] float4 AALALMNDJKO);

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	internal static class FINGPHBGFIE
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2FB0", Offset = "0x7BD17B0", VA = "0x187BD2FB0")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2E60", Offset = "0x7BD1660", VA = "0x187BD2E60")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7BD3340", Offset = "0x7BD1B40", VA = "0x187BD3340")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x7BD30D0", Offset = "0x7BD18D0", VA = "0x187BD30D0")]
		public static uint GINPGABDCGP([In] float4 AALALMNDJKO)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public delegate uint ONJGCGHFFOH([In] float3 AALALMNDJKO);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class KBILMDPAPHL
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB190", Offset = "0x7BD9990", VA = "0x187BDB190")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB040", Offset = "0x7BD9840", VA = "0x187BDB040")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB4F0", Offset = "0x7BD9CF0", VA = "0x187BDB4F0")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7BDB2B0", Offset = "0x7BD9AB0", VA = "0x187BDB2B0")]
		public static uint GINPGABDCGP([In] float3 AALALMNDJKO)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public unsafe delegate void MBDCDEIEJPK([NoAlias] HOBMHNHOPFB* JNKDBBJFFKP, int PKBFIOIHAOL, [In][NoAlias] float3* DKGIBCAMBPD, [In][NoAlias] float3* MGBCOPHNCOE, [In][NoAlias] float4* FNNEEPHEDNF, [In][NoAlias] float2* GFFDGIHFGGJ, [In][NoAlias] float4* JDJEBBAHLBG);

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	internal static class DOBEDMGEHCH
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2350", Offset = "0x7BD0B50", VA = "0x187BD2350")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2200", Offset = "0x7BD0A00", VA = "0x187BD2200")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7BD26A0", Offset = "0x7BD0EA0", VA = "0x187BD26A0")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2470", Offset = "0x7BD0C70", VA = "0x187BD2470")]
		public unsafe static void GINPGABDCGP([NoAlias] HOBMHNHOPFB* JNKDBBJFFKP, int PKBFIOIHAOL, [In][NoAlias] float3* DKGIBCAMBPD, [In][NoAlias] float3* MGBCOPHNCOE, [In][NoAlias] float4* FNNEEPHEDNF, [In][NoAlias] float2* GFFDGIHFGGJ, [In][NoAlias] float4* JDJEBBAHLBG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public unsafe delegate void LIGIFNBFMHM([NoAlias] MDDBIEOGPIM* JNKDBBJFFKP, int PKBFIOIHAOL, [In][NoAlias] float3* DKGIBCAMBPD, [In][NoAlias] float3* MGBCOPHNCOE, [In][NoAlias] float4* FNNEEPHEDNF, [In][NoAlias] float2* GFFDGIHFGGJ, [In][NoAlias] float4* JDJEBBAHLBG);

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	internal static class IPFKJMLHIGC
	{
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7BDAC50", Offset = "0x7BD9450", VA = "0x187BDAC50")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7BDAB00", Offset = "0x7BD9300", VA = "0x187BDAB00")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7BDAFA0", Offset = "0x7BD97A0", VA = "0x187BDAFA0")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7BDAD70", Offset = "0x7BD9570", VA = "0x187BDAD70")]
		public unsafe static void GINPGABDCGP([NoAlias] MDDBIEOGPIM* JNKDBBJFFKP, int PKBFIOIHAOL, [In][NoAlias] float3* DKGIBCAMBPD, [In][NoAlias] float3* MGBCOPHNCOE, [In][NoAlias] float4* FNNEEPHEDNF, [In][NoAlias] float2* GFFDGIHFGGJ, [In][NoAlias] float4* JDJEBBAHLBG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public unsafe delegate void GCLICKGMIJP([NoAlias] LAFBFKCBMPA* JNKDBBJFFKP, int PKBFIOIHAOL, [In][NoAlias] float3* DKGIBCAMBPD, [In][NoAlias] float3* MGBCOPHNCOE, [In][NoAlias] float4* FNNEEPHEDNF, [In][NoAlias] float2* GFFDGIHFGGJ, [In][NoAlias] float4* JDJEBBAHLBG);

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	internal static class BCGNIIMKAOG
	{
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7BCE480", Offset = "0x7BCCC80", VA = "0x187BCE480")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7BCE330", Offset = "0x7BCCB30", VA = "0x187BCE330")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7BCE980", Offset = "0x7BCD180", VA = "0x187BCE980")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7BCE5A0", Offset = "0x7BCCDA0", VA = "0x187BCE5A0")]
		public unsafe static void GINPGABDCGP([NoAlias] LAFBFKCBMPA* JNKDBBJFFKP, int PKBFIOIHAOL, [In][NoAlias] float3* DKGIBCAMBPD, [In][NoAlias] float3* MGBCOPHNCOE, [In][NoAlias] float4* FNNEEPHEDNF, [In][NoAlias] float2* GFFDGIHFGGJ, [In][NoAlias] float4* JDJEBBAHLBG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public unsafe delegate void EHMNABIKPID([NoAlias] MGOBFJFJINC* JNKDBBJFFKP, int PKBFIOIHAOL, [In][NoAlias] float3* DKGIBCAMBPD, [In][NoAlias] float3* MGBCOPHNCOE, [In][NoAlias] float4* FNNEEPHEDNF, [In][NoAlias] float2* GFFDGIHFGGJ, [In][NoAlias] float4* JDJEBBAHLBG, [Out] float3 MOKMFBMDNFI, [Out] float3 LGMEIOBDBJK);

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal static class HAJGMAHJAJH
	{
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7BD73E0", Offset = "0x7BD5BE0", VA = "0x187BD73E0")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7BD7290", Offset = "0x7BD5A90", VA = "0x187BD7290")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x7BD7A50", Offset = "0x7BD6250", VA = "0x187BD7A50")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7BD7500", Offset = "0x7BD5D00", VA = "0x187BD7500")]
		public unsafe static void GINPGABDCGP([NoAlias] MGOBFJFJINC* JNKDBBJFFKP, int PKBFIOIHAOL, [In][NoAlias] float3* DKGIBCAMBPD, [In][NoAlias] float3* MGBCOPHNCOE, [In][NoAlias] float4* FNNEEPHEDNF, [In][NoAlias] float2* GFFDGIHFGGJ, [In][NoAlias] float4* JDJEBBAHLBG, [Out] float3 MOKMFBMDNFI, [Out] float3 LGMEIOBDBJK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public const int KINPHPCCFLD = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeList<float3> KFFLNGKEBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<float3> BOIAIJHJDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeArray<float4> FDFGDLFCJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeArray<float4> MMBNDMCBFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeArray<float2> MHJBKADOJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeList<int> COCKEFNFHKL;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly VertexAttributeDescriptor[][] LNKBLCMMCLC;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static bool LFDBBOFAJOE;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public static EKLNJDIDCDL[] NODFJDJFOLL;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool KBDBMNHHFOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7D20", Offset = "0x7BC6520", VA = "0x187BC7D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int ADDMENBCPDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7BC6610", Offset = "0x7BC4E10", VA = "0x187BC6610")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int EEBNJGNDFLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B20", Offset = "0x7BC6320", VA = "0x187BC7B20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool ODPHDBFEPML
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7BC30C0", Offset = "0x7BC18C0", VA = "0x187BC30C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7CD0", Offset = "0x7BC64D0", VA = "0x187BC7CD0")]
	public static MBHJGDAOABC KFJFLGHENLM(EHNEFMAHLAI CGJBGKAIMNA)
	{
		return default(MBHJGDAOABC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9520", Offset = "0x7BC7D20", VA = "0x187BC9520")]
	public static void NPNOAKNEFDC(MBHJGDAOABC HACNDDMNEGK, Material OALKCGACMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7BC49F0", Offset = "0x7BC31F0", VA = "0x187BC49F0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7BC78B0", Offset = "0x7BC60B0", VA = "0x187BC78B0")]
	public void JDJGCBPDGJD(int JCDJHOHOPJC, int HFGIBGEKDDK, Allocator KKCJNCNIICO, bool AIPCNDHHDGD, bool CEAMFOHPAPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4B00", Offset = "0x7BC3300", VA = "0x187BC4B00")]
	public void EEFNCBMHIHE(int JCDJHOHOPJC, int HFGIBGEKDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B60", Offset = "0x7BC6360", VA = "0x187BC7B60", Slot = "6")]
	public bool JPABNJJAPDJ(Mesh ABAPBBKNPBC, bool MKIJKFGDBFB = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3160", Offset = "0x7BC1960", VA = "0x187BC3160")]
	public bool BDAKODADCDP(Mesh ABAPBBKNPBC, bool MKIJKFGDBFB, bool CHEKCBNHAJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x7BC81B0", Offset = "0x7BC69B0", VA = "0x187BC81B0")]
	public bool MGIFHJDAGNJ(Mesh ABAPBBKNPBC, PKKNLFDDHKF DADFBDAHAIB, bool MKIJKFGDBFB = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3560", Offset = "0x7BC1D60", VA = "0x187BC3560")]
	public bool BFKAJLHAFBI(Mesh ABAPBBKNPBC, PKKNLFDDHKF DADFBDAHAIB, EHNEFMAHLAI CGJBGKAIMNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7BC89C0", Offset = "0x7BC71C0", VA = "0x187BC89C0")]
	private void MHJPBGPFIEN(Mesh ABAPBBKNPBC, PKKNLFDDHKF DADFBDAHAIB, bool CHEKCBNHAJH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7BC86B0", Offset = "0x7BC6EB0", VA = "0x187BC86B0")]
	public void MHJPBGPFIEN(NativeArray<ushort> IFHIHNBDALK, NativeArray<LAFBFKCBMPA> BNLIMBNGDCJ, Mesh ABAPBBKNPBC, PKKNLFDDHKF DADFBDAHAIB, bool CHEKCBNHAJH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3630", Offset = "0x7BC1E30", VA = "0x187BC3630")]
	public void BGPJDCJCMGL(Mesh ABAPBBKNPBC, bool CHEKCBNHAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9150", Offset = "0x7BC7950", VA = "0x187BC9150")]
	[BurstCompile]
	public static int MOHGKNLIOFN(float LEFBJAGNHCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7BC91F0", Offset = "0x7BC79F0", VA = "0x187BC91F0")]
	[BurstCompile]
	public static uint MOHGKNLIOFN([In] float4 AALALMNDJKO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7BC91A0", Offset = "0x7BC79A0", VA = "0x187BC91A0")]
	[BurstCompile]
	public static uint MOHGKNLIOFN([In] float3 AALALMNDJKO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7220", Offset = "0x7BC5A20", VA = "0x187BC7220")]
	public void ILEGHNOHKMG(Mesh ABAPBBKNPBC, bool CHEKCBNHAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7BC59B0", Offset = "0x7BC41B0", VA = "0x187BC59B0")]
	[BurstCompile]
	private unsafe static void FHEEIHEOFOI([NoAlias] HOBMHNHOPFB* JNKDBBJFFKP, int PKBFIOIHAOL, [In][NoAlias] float3* DKGIBCAMBPD, [In][NoAlias] float3* MGBCOPHNCOE, [In][NoAlias] float4* FNNEEPHEDNF, [In][NoAlias] float2* GFFDGIHFGGJ, [In][NoAlias] float4* JDJEBBAHLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7BC42E0", Offset = "0x7BC2AE0", VA = "0x187BC42E0")]
	public void CBOLDHIAANM(Mesh ABAPBBKNPBC, bool CHEKCBNHAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4970", Offset = "0x7BC3170", VA = "0x187BC4970")]
	[BurstCompile]
	private unsafe static void DLGKLJFOICN([NoAlias] MDDBIEOGPIM* JNKDBBJFFKP, int PKBFIOIHAOL, [In][NoAlias] float3* DKGIBCAMBPD, [In][NoAlias] float3* MGBCOPHNCOE, [In][NoAlias] float4* FNNEEPHEDNF, [In][NoAlias] float2* GFFDGIHFGGJ, [In][NoAlias] float4* JDJEBBAHLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4F30", Offset = "0x7BC3730", VA = "0x187BC4F30")]
	public void EPLCDBJMNIH(Mesh ABAPBBKNPBC, bool CHEKCBNHAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4B80", Offset = "0x7BC3380", VA = "0x187BC4B80")]
	public void EPLCDBJMNIH(NativeArray<ushort> MAKHNJGJMCI, NativeArray<LAFBFKCBMPA> LIHIDAINJML, Mesh ABAPBBKNPBC, bool CHEKCBNHAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7AA0", Offset = "0x7BC62A0", VA = "0x187BC7AA0")]
	[BurstCompile]
	public unsafe static void JEMEJEBGMPE([NoAlias] LAFBFKCBMPA* JNKDBBJFFKP, int PKBFIOIHAOL, [In][NoAlias] float3* DKGIBCAMBPD, [In][NoAlias] float3* MGBCOPHNCOE, [In][NoAlias] float4* FNNEEPHEDNF, [In][NoAlias] float2* GFFDGIHFGGJ, [In][NoAlias] float4* JDJEBBAHLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7BC6AE0", Offset = "0x7BC52E0", VA = "0x187BC6AE0")]
	public void IIJOCKMMHPD(Mesh ABAPBBKNPBC, bool CHEKCBNHAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7C50", Offset = "0x7BC6450", VA = "0x187BC7C50")]
	[BurstCompile]
	private unsafe static void KEMPIIKOIIB([NoAlias] MGOBFJFJINC* JNKDBBJFFKP, int PKBFIOIHAOL, [In][NoAlias] float3* DKGIBCAMBPD, [In][NoAlias] float3* MGBCOPHNCOE, [In][NoAlias] float4* FNNEEPHEDNF, [In][NoAlias] float2* GFFDGIHFGGJ, [In][NoAlias] float4* JDJEBBAHLBG, [Out] float3 MOKMFBMDNFI, [Out] float3 LGMEIOBDBJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7BC95E0", Offset = "0x7BC7DE0", VA = "0x187BC95E0")]
	public void OANKAIJJCOE(Mesh ABAPBBKNPBC, EHNEFMAHLAI CGJBGKAIMNA, bool CHEKCBNHAJH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7BC4070", Offset = "0x7BC2870", VA = "0x187BC4070")]
	public void BJOHCNAKMFD(PKKNLFDDHKF ABAPBBKNPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7BC5300", Offset = "0x7BC3B00", VA = "0x187BC5300")]
	public void FAEJOEEGNJE(PKKNLFDDHKF MDFGJCKGNHP, Allocator KKCJNCNIICO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7BC6930", Offset = "0x7BC5130", VA = "0x187BC6930")]
	public long IFGEPPHAFJH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7BC6A80", Offset = "0x7BC5280", VA = "0x187BC6A80")]
	public static long IFGEPPHAFJH(int MEMHAABPKNK, int GPPJPLIJLPO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7BC5AF0", Offset = "0x7BC42F0", VA = "0x187BC5AF0")]
	public static long FINBLHBMFPG(int MEMHAABPKNK, int GPPJPLIJLPO, EHNEFMAHLAI CGJBGKAIMNA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7BC5A30", Offset = "0x7BC4230", VA = "0x187BC5A30")]
	public long FINBLHBMFPG(EHNEFMAHLAI CGJBGKAIMNA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3100", Offset = "0x7BC1900", VA = "0x187BC3100")]
	public void BCHPADICDIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7BC5400", Offset = "0x7BC3C00", VA = "0x187BC5400")]
	public static void FENBCEAADLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7BC5B90", Offset = "0x7BC4390", VA = "0x187BC5B90")]
	public EHNEFMAHLAI FLLDKLHBJJF()
	{
		return default(EHNEFMAHLAI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7B80", Offset = "0x7BC6380", VA = "0x187BC7B80")]
	public static (int, int) KBFBOBPEPEC(Mesh ABAPBBKNPBC)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9440", Offset = "0x7BC7C40", VA = "0x187BC9440")]
	public static int NGGPPPIKGBO(VertexAttributeDescriptor[] IEJMILMFMEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7BC97A0", Offset = "0x7BC7FA0", VA = "0x187BC97A0")]
	public static long OEDLAEPKLHG(Mesh ABAPBBKNPBC, int HGBCGCKLJDB, int FOFEILIFFBN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9670", Offset = "0x7BC7E70", VA = "0x187BC9670")]
	public static long OEDLAEPKLHG(Mesh ABAPBBKNPBC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public PKKNLFDDHKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7BC6650", Offset = "0x7BC4E50", VA = "0x187BC6650")]
	[BurstCompile]
	public static int HOCLABPACPP(float LEFBJAGNHCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7BC66F0", Offset = "0x7BC4EF0", VA = "0x187BC66F0")]
	[BurstCompile]
	public static uint HOCLABPACPP([In] float4 AALALMNDJKO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7BC6880", Offset = "0x7BC5080", VA = "0x187BC6880")]
	[BurstCompile]
	public static uint HOCLABPACPP([In] float3 AALALMNDJKO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9810", Offset = "0x7BC8010", VA = "0x187BC9810")]
	[BurstCompile]
	public unsafe static void PPGHOJJIDBD([NoAlias] HOBMHNHOPFB* JNKDBBJFFKP, int PKBFIOIHAOL, [In][NoAlias] float3* DKGIBCAMBPD, [In][NoAlias] float3* MGBCOPHNCOE, [In][NoAlias] float4* FNNEEPHEDNF, [In][NoAlias] float2* GFFDGIHFGGJ, [In][NoAlias] float4* JDJEBBAHLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7D60", Offset = "0x7BC6560", VA = "0x187BC7D60")]
	[BurstCompile]
	public unsafe static void LNEGNMEGCEH([NoAlias] MDDBIEOGPIM* JNKDBBJFFKP, int PKBFIOIHAOL, [In][NoAlias] float3* DKGIBCAMBPD, [In][NoAlias] float3* MGBCOPHNCOE, [In][NoAlias] float4* FNNEEPHEDNF, [In][NoAlias] float2* GFFDGIHFGGJ, [In][NoAlias] float4* JDJEBBAHLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9240", Offset = "0x7BC7A40", VA = "0x187BC9240")]
	[BurstCompile]
	public unsafe static void NFDJMPEBHFE([NoAlias] LAFBFKCBMPA* JNKDBBJFFKP, int PKBFIOIHAOL, [In][NoAlias] float3* DKGIBCAMBPD, [In][NoAlias] float3* MGBCOPHNCOE, [In][NoAlias] float4* FNNEEPHEDNF, [In][NoAlias] float2* GFFDGIHFGGJ, [In][NoAlias] float4* JDJEBBAHLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7BC62D0", Offset = "0x7BC4AD0", VA = "0x187BC62D0")]
	[BurstCompile]
	public unsafe static void GCAOCGMKONL([NoAlias] MGOBFJFJINC* JNKDBBJFFKP, int PKBFIOIHAOL, [In][NoAlias] float3* DKGIBCAMBPD, [In][NoAlias] float3* MGBCOPHNCOE, [In][NoAlias] float4* FNNEEPHEDNF, [In][NoAlias] float2* GFFDGIHFGGJ, [In][NoAlias] float4* JDJEBBAHLBG, [Out] float3 MOKMFBMDNFI, [Out] float3 LGMEIOBDBJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct NMKPDINEIGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public int LPFEEFMGMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public float3 PCPABHBNEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public quaternion DLFNBPAFJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public float3 JKNCAMFHFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public int AHJGKHIHKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public int GEHPAEKDJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public int CFLADAFCBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public float FKJMKHIOOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public float3 GNKAJCNAHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public bool KICEFEOMBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public NGMFIBACAJD CBDDGJODMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float3 DKIDMBMJPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float BDEBNCMLGLG;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class HHMLJOBPGPN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static EJNEKDLJOBA ODONJJNFEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public NativeList<NMKPDINEIGF> DNNECIKPMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public NativeList<LGKOIALHGCP> OEPJLKBGPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public NativeList<OAKFPMCOKHO> CDJMJLPIIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public NativeArray<OFEAEHKGGHH> KOGNBAPFBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public NativeList<LGKOIALHGCP> AFACHBBFJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public NativeList<OOFLKEBEPGD> KOMECOFIFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private List<NativeArray<OFEAEHKGGHH>> OECDOJPMBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private NativeList<CJAEGNMKJDM> IIPDGNPCEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private NativeArray<int> KBIEPMECIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private NativeArray<int> LEGNMJLCPIK;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static NativeList<DOPJHPLPMNH.GAOGLDLCJKM> ONICPPGGBMD;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int ADDMENBCPDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x9EB350", Offset = "0x9E9B50", VA = "0x1809EB350")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x9EB340", Offset = "0x9E9B40", VA = "0x1809EB340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int EEBNJGNDFLH
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xBFC940", Offset = "0xBFB140", VA = "0x180BFC940")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xBFC950", Offset = "0xBFB150", VA = "0x180BFC950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x7BD9B30", Offset = "0x7BD8330", VA = "0x187BD9B30")]
	public HHMLJOBPGPN(int OKFIOLICJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x7BD8DC0", Offset = "0x7BD75C0", VA = "0x187BD8DC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x7BD9690", Offset = "0x7BD7E90", VA = "0x187BD9690")]
	public void OCOBEACFBKJ(JobHandle OHHKLKBFKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7BD8FA0", Offset = "0x7BD77A0", VA = "0x187BD8FA0")]
	public void FKDABEFHEFH(NMKPDINEIGF NFNBKNAJBPN, CJAEGNMKJDM DBOJHIIPJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7BD91C0", Offset = "0x7BD79C0", VA = "0x187BD91C0")]
	public void GPBMEECDPHG(OAKFPMCOKHO NFNBKNAJBPN, NativeArray<OFEAEHKGGHH> PEHEMDKODFB, int PKBFIOIHAOL, int EKBBKNBDGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD7AF0", Offset = "0x7BD62F0", VA = "0x187BD7AF0")]
	public JobHandle BANJIPBEICI(PKKNLFDDHKF KFBIDFFCDEN, PDCIDHGFBFE EONOKBFIFOG, float3 JKPPPLCFJJJ, quaternion DOALAMJJBIB, float GOLEOEPNKNI, bool PCEGDPIHCDJ, int CFINJKCNKOP = 0, int CHDJGLLIHJG = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7BD7C10", Offset = "0x7BD6410", VA = "0x187BD7C10")]
	public JobHandle BANJIPBEICI(PKKNLFDDHKF KFBIDFFCDEN, PDCIDHGFBFE EONOKBFIFOG, NativeList<DOPJHPLPMNH.GAOGLDLCJKM> EJBGMOCDJAD, float3 JKPPPLCFJJJ, quaternion DOALAMJJBIB, float GOLEOEPNKNI, bool PCEGDPIHCDJ, bool PFONPPAHDKD, int CFINJKCNKOP = 0, int CHDJGLLIHJG = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7BD9320", Offset = "0x7BD7B20", VA = "0x187BD9320")]
	public static JobHandle JOOIELEEACK(BMKLKEJKGJM JPCHALMJIGP, PKKNLFDDHKF KFBIDFFCDEN, NativeArray<int> LEGNMJLCPIK, NMKPDINEIGF NFNBKNAJBPN, JobHandle OHHKLKBFKLA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x7BD9880", Offset = "0x7BD8080", VA = "0x187BD9880")]
	public static JobHandle PMBCKNPABMP(GCKLBHCDKPL JPCHALMJIGP, PKKNLFDDHKF KFBIDFFCDEN, OAKFPMCOKHO NFNBKNAJBPN, NativeArray<OFEAEHKGGHH> PEHEMDKODFB, int PKBFIOIHAOL, int EKBBKNBDGCA, JobHandle OHHKLKBFKLA)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class GHBINHEDMEG
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal struct IIJAFBPBIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public MeshRenderer JGPHFKDOCBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public MDBJHJFFFAJ.FCJLJCGIKLN GJDMHJPDODH;

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x5B3E840", Offset = "0x5B3D040", VA = "0x185B3E840")]
		public IIJAFBPBIAM(MeshRenderer JGPHFKDOCBN, MDBJHJFFFAJ.FCJLJCGIKLN GJDMHJPDODH)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x7BDAA80", Offset = "0x7BD9280", VA = "0x187BDAA80")]
		public static IIJAFBPBIAM FGIKKMMHFBO((MeshRenderer, MDBJHJFFFAJ.FCJLJCGIKLN) LNPNEODPLIC)
		{
			return default(IIJAFBPBIAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ProfilerMarker BGLCOBEINOK;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly ProfilerMarker HFANKGCEKBJ;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ProfilerMarker HPMHPDAHPCD;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly ProfilerMarker JBHPODPIJDB;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7BD66D0", Offset = "0x7BD4ED0", VA = "0x187BD66D0")]
	internal void LJFNINNENAL(GameObject ILHHBBPGOCH, MDBJHJFFFAJ.OJEFENAHNCN FGHHAGPMJLO, List<IIJAFBPBIAM> PIBKMLFALDL, Material OALKCGACMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7BD5E50", Offset = "0x7BD4650", VA = "0x187BD5E50")]
	internal void KJDNNFKFPPP(GameObject ILHHBBPGOCH, MDBJHJFFFAJ.OJEFENAHNCN FGHHAGPMJLO, List<IIJAFBPBIAM> PIBKMLFALDL, List<LODGroup> HHOCKBFLJAF, Material OALKCGACMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7BD4460", Offset = "0x7BD2C60", VA = "0x187BD4460")]
	private MeshRenderer IOCMHDNLKIJ(MDBJHJFFFAJ.OJEFENAHNCN FGHHAGPMJLO, Material OALKCGACMLD, List<IIJAFBPBIAM> PIBKMLFALDL, bool HPMKMCIBKCM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7BD4F10", Offset = "0x7BD3710", VA = "0x187BD4F10")]
	private List<(List<IIJAFBPBIAM>, float)> KCNCGKJMNDH(MDBJHJFFFAJ.OJEFENAHNCN FGHHAGPMJLO, List<LODGroup> HHOCKBFLJAF, Material OALKCGACMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3700", Offset = "0x7BD1F00", VA = "0x187BD3700")]
	private List<List<(List<IIJAFBPBIAM>, float)>> GEFCFAJNJLH(MDBJHJFFFAJ.OJEFENAHNCN FGHHAGPMJLO, List<LODGroup> HHOCKBFLJAF, Material OALKCGACMLD, [Out] int JOLPNDPOIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public GHBINHEDMEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x7BD6FC0", Offset = "0x7BD57C0", VA = "0x187BD6FC0")]
	[CompilerGenerated]
	internal static (float, int) OKDCNKICEKJ(List<List<(List<IIJAFBPBIAM> meshList, float lodTransition)>> GFFFPHNMCHK, int[] LFLEEOEGIBG)
	{
		return default((float, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class BFEDNMIDNNB
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static readonly ProfilerMarker KDCLGFABHCF;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static readonly ProfilerMarker EHIHBLKDBKL;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static readonly ProfilerMarker LGHMEEPKOLL;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static readonly ProfilerMarker DGINANMOJGG;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly ProfilerMarker CGOACHLFNDJ;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly ProfilerMarker CDCDHIMIPEA;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly ProfilerMarker JEDJIAAGBNL;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly LLPKKNNAIAE LCPOGBBBFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private MDBJHJFFFAJ FJPADADONPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private GHBINHEDMEG EKFGGMJJCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private Shader GGCHJLGFBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private MaterialPropertyBlock EACPCNDKBAL;

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x7BCFB70", Offset = "0x7BCE370", VA = "0x187BCFB70")]
	public static void FMBLHIJIDHJ(GameObject ILHHBBPGOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x7BD05D0", Offset = "0x7BCEDD0", VA = "0x187BD05D0")]
	public void NPIOKLMMDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0360", Offset = "0x7BCEB60", VA = "0x187BD0360")]
	public void LLIOADDPCAH(GameObject ILHHBBPGOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x7BD01E0", Offset = "0x7BCE9E0", VA = "0x187BD01E0")]
	private bool LECBCJHOEHJ(MeshRenderer JGPHFKDOCBN, [Out] MeshFilter IJIMEMLJMOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x7BCFED0", Offset = "0x7BCE6D0", VA = "0x187BCFED0")]
	private bool HEHPDJEAKDM(int FPEOONOJHML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x7BCF0B0", Offset = "0x7BCD8B0", VA = "0x187BCF0B0")]
	private void ENPFHILAGNC(GameObject ILHHBBPGOCH, int FPEOONOJHML, Material OALKCGACMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x7BCF390", Offset = "0x7BCDB90", VA = "0x187BCF390")]
	private List<GHBINHEDMEG.IIJAFBPBIAM> EPHCDHBABMG(int FPEOONOJHML, [Out] List<LODGroup> HHOCKBFLJAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0DB0", Offset = "0x7BCF5B0", VA = "0x187BD0DB0")]
	private List<(int, Material)> PJCEIMBABGD(float NDEDIFLKOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x7BD0130", Offset = "0x7BCE930", VA = "0x187BD0130")]
	public void IMAIJACFOFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x7BCEA20", Offset = "0x7BCD220", VA = "0x187BCEA20")]
	private bool BELDBPIDOME(GameObject KJMBGAPFJAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x7BD15B0", Offset = "0x7BCFDB0", VA = "0x187BD15B0")]
	public BFEDNMIDNNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[BurstCompile]
public class MDBJHJFFFAJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[BurstCompatible]
	public struct OJEFENAHNCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public float3 FGNFJAMALCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public float3 EDGENFDJJHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public float GLLOJMFDPHM;

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7BE22B0", Offset = "0x7BE0AB0", VA = "0x187BE22B0")]
		public OJEFENAHNCN(Bounds KBODAPIGKJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7BE2420", Offset = "0x7BE0C20", VA = "0x187BE2420")]
		public OJEFENAHNCN(float3 FGNFJAMALCL, float3 EDGENFDJJHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[BurstCompatible]
	public struct ELKMPFGDDFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public OJEFENAHNCN OHHCLDLGIOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public int CBJHNHALJLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int EKOHLPLGKOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public float PMGELMBJJNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int JCDJHOHOPJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int DMAFLBNAJDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public int DOBPAEPPPMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int ABDAKIKAMML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public int LMHONPPPFAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public bool KAPMOGJFGCC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public struct FCJLJCGIKLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public Mesh ECLDOGPLLOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public Matrix4x4 BOIABGKDNPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public int CPIAPONGABA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[BurstCompile]
	private struct AAHHFKKABBD : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[ReadOnly]
		public NativeArray<ELKMPFGDDFM> CHHNLHCEBAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[WriteOnly]
		public NativeArray<float> ENLECGNCFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public int HCFHIHNJIII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public OJEFENAHNCN KBODAPIGKJN;

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7BCAF40", Offset = "0x7BC9740", VA = "0x187BCAF40")]
		private float BMOJGECEPFD(OJEFENAHNCN BINANFFLHIK, OJEFENAHNCN NOAPPAEGHOH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7BCB070", Offset = "0x7BC9870", VA = "0x187BCB070", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly ProfilerMarker ADPAGCMHCAP;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly ProfilerMarker HDLNOBPBFBD;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly ProfilerMarker GPHAKCIHOJK;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static readonly ProfilerMarker DDFFPOFNALH;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static readonly ProfilerMarker KMIAOGFOHEI;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static readonly ProfilerMarker FOJGOOJLBHP;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static readonly ProfilerMarker OABLPLCMMFK;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static readonly ProfilerMarker KOPMMBAIDMI;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly ProfilerMarker OAGPLMMFKMG;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly ProfilerMarker HBAPJNOKPEN;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly ProfilerMarker MNKCHKCGOKL;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly ProfilerMarker HFDJKEGIPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public NativeArray<ELKMPFGDDFM> CHHNLHCEBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeQueue<int> LADCLDIGHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int LGFFGJJOHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public Dictionary<Material, int> CDMAJDBBAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public List<FCJLJCGIKLN> DPIOBILHGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public List<LODGroup> HHOCKBFLJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public Dictionary<int, MeshRenderer> HMDPJIMGIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private Queue<int> JNEJEBBEKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Shader NIPFGFNIGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Shader PEPFCLMGAPK;

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x7BE1990", Offset = "0x7BE0190", VA = "0x187BE1990")]
	public MDBJHJFFFAJ(int PPNBELKMDHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x7BDFBE0", Offset = "0x7BDE3E0", VA = "0x187BDFBE0")]
	private void HCJELCJNAAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x7BDE010", Offset = "0x7BDC810", VA = "0x187BDE010")]
	public bool CFHMNPLCGJI(MeshRenderer GNLJHOFLOPC, MeshFilter KDGBAEDKGPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x7BDE520", Offset = "0x7BDCD20", VA = "0x187BDE520")]
	public bool CFHMNPLCGJI(LODGroup OJAABLOINNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x7BE1640", Offset = "0x7BDFE40", VA = "0x187BE1640")]
	private bool PHEIEKKHJKM(MeshRenderer GNLJHOFLOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x7BDDEF0", Offset = "0x7BDC6F0", VA = "0x187BDDEF0")]
	private int CEBFENFDIAK(MeshRenderer GNLJHOFLOPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x7BDF250", Offset = "0x7BDDA50", VA = "0x187BDF250")]
	private int CKBGIOOOFAL(LODGroup OJAABLOINNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x7BE10F0", Offset = "0x7BDF8F0", VA = "0x187BE10F0")]
	private int OAIAOEDFHKG(MeshFilter KDGBAEDKGPN, int OKBBCMAODEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x7BDD8E0", Offset = "0x7BDC0E0", VA = "0x187BDD8E0")]
	private int APIMKDJONEI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x7BE1250", Offset = "0x7BDFA50", VA = "0x187BE1250")]
	private static OJEFENAHNCN PBJHFELPNIM(OJEFENAHNCN BINANFFLHIK, OJEFENAHNCN NOAPPAEGHOH)
	{
		return default(OJEFENAHNCN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x7BE04A0", Offset = "0x7BDECA0", VA = "0x187BE04A0")]
	private static float MFMADOJCCJH(Vector3 FGNFJAMALCL, Vector3 EDGENFDJJHO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x7BDF370", Offset = "0x7BDDB70", VA = "0x187BDF370")]
	private int GEOGOFEGNOF(int GDPCBCFGABH, OJEFENAHNCN EOLMKJLNEKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x7BDFD50", Offset = "0x7BDE550", VA = "0x187BDFD50")]
	private void KOKJJLPDPEN(OJEFENAHNCN EOLMKJLNEKF, int FPEOONOJHML, [Out] float IEPHMINOJKN, [Out] float MFHDPEALMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x7BDF6E0", Offset = "0x7BDDEE0", VA = "0x187BDF6E0")]
	private void HAJKGJCFNPO(OJEFENAHNCN EOLMKJLNEKF, int NLBKGOFEKJH, Material OALKCGACMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x7BDDC70", Offset = "0x7BDC470", VA = "0x187BDDC70")]
	private float BMOJGECEPFD(OJEFENAHNCN BINANFFLHIK, OJEFENAHNCN NOAPPAEGHOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x7BDFFE0", Offset = "0x7BDE7E0", VA = "0x187BDFFE0")]
	private void LNLJMDAJFDL(int FPEOONOJHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x7BE0C60", Offset = "0x7BDF460", VA = "0x187BE0C60")]
	private void NELLFHCIFHO(int DAIOOLAPDNA, int FEPMNIMMOAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x7BE0630", Offset = "0x7BDEE30", VA = "0x187BE0630")]
	private void MHAPOIIJOPI(int DAIOOLAPDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x7BDF2C0", Offset = "0x7BDDAC0", VA = "0x187BDF2C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct BKENLNNLKHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public float2 AAMJOBPGPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public float2 FEAICKLKFBD;
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class IFGGMIBDNMF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public NativeArray<BKENLNNLKHI> CJLOFJJBJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public NativeArray<int> GMOAHCLMPCL;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int ADDMENBCPDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x9E9470", Offset = "0x9E7C70", VA = "0x1809E9470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int EEBNJGNDFLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF90", Offset = "0x9EA790", VA = "0x1809EBF90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x7BDA9C0", Offset = "0x7BD91C0", VA = "0x187BDA9C0")]
	public IFGGMIBDNMF(int JCDJHOHOPJC, int HFGIBGEKDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x7BDA960", Offset = "0x7BD9160", VA = "0x187BDA960", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x7BDA880", Offset = "0x7BD9080", VA = "0x187BDA880")]
	public void BJOHCNAKMFD(IFGGMIBDNMF KGOOLMOCDLJ, int KGBJBAAHHIL, int IFOFOJHAFEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public static class ACPDHMABEFF
{
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static IFGGMIBDNMF PBEABBGBCMN;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static NativeList<LGKOIALHGCP> ECONMKMLGMH;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static int[] EFJGKOJIMKI;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static bool ICKIEOABOJJ;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static Dictionary<int, IFGGMIBDNMF> AIDAFCIKPIG;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static Dictionary<int, IFGGMIBDNMF> FGGOMNILENN;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool MLHPFEINMLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7BCB340", Offset = "0x7BC9B40", VA = "0x187BCB340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NativeList<LGKOIALHGCP> ICIGELPEABH
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7BCBA30", Offset = "0x7BCA230", VA = "0x187BCBA30")]
		get
		{
			return default(NativeList<LGKOIALHGCP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static IFGGMIBDNMF OPEBMEEIIEB
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7BCB3C0", Offset = "0x7BC9BC0", VA = "0x187BCB3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x7BCBCD0", Offset = "0x7BCA4D0", VA = "0x187BCBCD0")]
	private static void OFBBEDKDKGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x7BCB850", Offset = "0x7BCA050", VA = "0x187BCB850")]
	public static int FCMGPMNFFEG(bool JDJNEMHBEDI, int AKBMOMGLMJK, bool ECAMHOKOPCE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x7BCB290", Offset = "0x7BC9A90", VA = "0x187BCB290")]
	private static int AGOFFBLIDAL(int AKBMOMGLMJK, bool PLNDJAIOCMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x7BCBCC0", Offset = "0x7BCA4C0", VA = "0x187BCBCC0")]
	private static int MEKDAFKAKJG(int AKBMOMGLMJK, bool PLNDJAIOCMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x7BCB910", Offset = "0x7BCA110", VA = "0x187BCB910")]
	public static int HJDLAGOLHJC(int BIPGHKPGBAC, int AKBMOMGLMJK, int MKNPDGHKJMP, bool PLNDJAIOCMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x7BCB880", Offset = "0x7BCA080", VA = "0x187BCB880")]
	public static int GHJADCPLEDI(int BIPGHKPGBAC, int AKBMOMGLMJK, int MKNPDGHKJMP, bool PLNDJAIOCMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x7BCBCB0", Offset = "0x7BCA4B0", VA = "0x187BCBCB0")]
	public static int MBBGHCDOKLN(int MKNPDGHKJMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x7BCBCA0", Offset = "0x7BCA4A0", VA = "0x187BCBCA0")]
	private static int LGGAJJMOFJF(int AKBMOMGLMJK, bool PLNDJAIOCMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x7BCC950", Offset = "0x7BCB150", VA = "0x187BCC950")]
	private static int PJADIIAEFBG(int AKBMOMGLMJK, bool PLNDJAIOCMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7BCB2B0", Offset = "0x7BC9AB0", VA = "0x187BCB2B0")]
	public static int CBKKBCJJHDP(int BIPGHKPGBAC, int AKBMOMGLMJK, int MKNPDGHKJMP, bool PLNDJAIOCMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7BCB9A0", Offset = "0x7BCA1A0", VA = "0x187BCB9A0")]
	public static int HKCCIOFMMAD(int BIPGHKPGBAC, int AKBMOMGLMJK, int MKNPDGHKJMP, bool PLNDJAIOCMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x7BCB320", Offset = "0x7BC9B20", VA = "0x187BCB320")]
	public static int CCEEOKFBMMK(int MKNPDGHKJMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x7BCBBB0", Offset = "0x7BCA3B0", VA = "0x187BCBBB0")]
	public static IFGGMIBDNMF IKHBLOLIOHA(int AKBMOMGLMJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x7BCC380", Offset = "0x7BCAB80", VA = "0x187BCC380")]
	private static IFGGMIBDNMF OKGAGEDNJCE(int AKBMOMGLMJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x7BCBAC0", Offset = "0x7BCA2C0", VA = "0x187BCBAC0")]
	public static IFGGMIBDNMF IDPKKDHECBB(int AKBMOMGLMJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x7BCC610", Offset = "0x7BCAE10", VA = "0x187BCC610")]
	private static IFGGMIBDNMF PIOANAKLMJH(int AKBMOMGLMJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x7BCB450", Offset = "0x7BC9C50", VA = "0x187BCB450")]
	public static void FBJANABPJBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct OAKFPMCOKHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public int DMIKAPPMKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public float3 PCPABHBNEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public quaternion DLFNBPAFJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public float JKNCAMFHFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public float FCBNGMAIDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public int AHJGKHIHKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public int GEHPAEKDJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public int CFLADAFCBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public bool FNGMLJPGLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public bool DJNMNHLHCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public float FKJMKHIOOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public float3 GNKAJCNAHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public bool EFLDALGNHID;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct OOFLKEBEPGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public int APEGBELKNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public int CGMOKNHDMHN;
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct GCKLBHCDKPL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public NativeList<OAKFPMCOKHO> DGNFJNEJAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public NativeArray<OFEAEHKGGHH> PFPEPHJFEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public NativeArray<LGKOIALHGCP> MHEFFAJDJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public NativeArray<OOFLKEBEPGD> MIJBAEIFDOD;

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7BD34D0", Offset = "0x7BD1CD0", VA = "0x187BD34D0")]
	public GCKLBHCDKPL(NativeArray<OFEAEHKGGHH> PFPEPHJFEEI, int LBLAFDELPAC = 1, Allocator KKCJNCNIICO = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD33E0", Offset = "0x7BD1BE0", VA = "0x187BD33E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[BurstCompile]
public struct KECDKNECBLO : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	[ReadOnly]
	private NativeArray<BKENLNNLKHI> MKGOPLJOIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	[ReadOnly]
	private NativeArray<int> GOKCIGEHOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	[ReadOnly]
	private NativeList<LGKOIALHGCP> FDHLDEJHDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	[ReadOnly]
	private NativeList<OAKFPMCOKHO> DGNFJNEJAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	[ReadOnly]
	private NativeArray<OFEAEHKGGHH> PFPEPHJFEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	[ReadOnly]
	private NativeArray<LGKOIALHGCP> MHEFFAJDJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	[ReadOnly]
	public NativeArray<OOFLKEBEPGD> MIJBAEIFDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	[ReadOnly]
	private int PFCIDPHDJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	[ReadOnly]
	private int BHGABILNAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	[ReadOnly]
	private float3 POFNJFILIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	[ReadOnly]
	private quaternion MAOCJAHPJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	[ReadOnly]
	private float3 ONPDMNDAOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> EAGGLHHLDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> PBJMFIPKLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FMHAHCJINPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> JDHDIEEEPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> ACCINAHJEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> MGBEFELHEMP;

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x7BDD430", Offset = "0x7BDBC30", VA = "0x187BDD430")]
	public KECDKNECBLO(HHMLJOBPGPN OPJNIIHNOAB, PKKNLFDDHKF LMPJJMEBDPG, float3 DIGBFODAMLP, quaternion HCJKDCONPLB, float PLPCFLNEKIF, int CFINJKCNKOP = 0, int CHDJGLLIHJG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x7BDD6B0", Offset = "0x7BDBEB0", VA = "0x187BDD6B0")]
	public KECDKNECBLO(GCKLBHCDKPL OPJNIIHNOAB, PKKNLFDDHKF LMPJJMEBDPG, float3 DIGBFODAMLP, quaternion HCJKDCONPLB, float3 PLPCFLNEKIF, int CFINJKCNKOP = 0, int CHDJGLLIHJG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x7BDD270", Offset = "0x7BDBA70", VA = "0x187BDD270")]
	private float3 KKMHCJHHLGE(float3 JBANIPICCMK, Matrix4x4 AHHFDPBHOMJ)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x7BDD3B0", Offset = "0x7BDBBB0", VA = "0x187BDD3B0")]
	private float3x3 PMDKOIAMANA(float3x3 LGDOKFLHDDB, float3x3 MJPPMOJJMGK)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x7BDB590", Offset = "0x7BD9D90", VA = "0x187BDB590")]
	private float BHLJIAHJLPF(float EGLHBCAIJLF, float NIFHAAECJND)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7BDBB50", Offset = "0x7BDA350", VA = "0x187BDBB50", Slot = "4")]
	public void Execute(int IGNBGDBAAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x7BDB5A0", Offset = "0x7BD9DA0", VA = "0x187BDB5A0")]
	private void DAILMBKBAGK(int IAKKJABMOPO, float3 NCGKJMOKFAF, float3 GLANACDLEOF, float3 EFPHCCMNKBP, float BCDEDKPOOJB, bool IHCLMLCGIDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x7BDB710", Offset = "0x7BD9F10", VA = "0x187BDB710")]
	private void DBBADALJMJF(OAKFPMCOKHO FJOCHAFDLOM, float3 NANJGAHEDND, float3x3 MODLABAKDKE, float EGLHBCAIJLF, int FOFPGMOOKPN, int HHNIKCPEPOI, int OAFBNIDHMEP, float EOBFBGBIGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x7BDCCF0", Offset = "0x7BDB4F0", VA = "0x187BDCCF0")]
	private void INIDDKAPOPK(int IAKKJABMOPO, int HOKEANNHDEA, OAKFPMCOKHO FJOCHAFDLOM, float3 NANJGAHEDND, float3x3 MODLABAKDKE, bool ACKOJJODHIL, float EGLHBCAIJLF, int LGHALFNPMOL, int NEMKOMLENGE, int OAFBNIDHMEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct BMKLKEJKGJM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public NativeList<NMKPDINEIGF> KGECLIMICCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public NativeList<LGKOIALHGCP> NGOMJBJBKMH;

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x7BD16B0", Offset = "0x7BCFEB0", VA = "0x187BD16B0")]
	public BMKLKEJKGJM(int LBLAFDELPAC, Allocator KKCJNCNIICO = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x7BD1610", Offset = "0x7BCFE10", VA = "0x187BD1610", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[BurstCompile]
public struct AOIALMFAGEJ : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private enum BFBOHMCCDBM
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		X,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		Z
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	[ReadOnly]
	private NativeList<float3> MFMCPGJOKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[ReadOnly]
	private NativeArray<float3> BGADIOCFEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[ReadOnly]
	private NativeList<int> HKBLFPIEIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	[ReadOnly]
	private NativeArray<int> FJIMNPEBJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[ReadOnly]
	private NativeArray<float4> GLNNEOAEEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[ReadOnly]
	private NativeArray<float4> GMPHIPPLOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	[ReadOnly]
	private NativeArray<float4> DBPCHDGEJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[ReadOnly]
	private NativeArray<int> BLLOFFOKBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[ReadOnly]
	private NativeList<float3> LIOHHAEKMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[ReadOnly]
	private NativeList<LGKOIALHGCP> FMOCANOAJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[ReadOnly]
	private NativeList<NMKPDINEIGF> KGECLIMICCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[ReadOnly]
	private NativeList<LGKOIALHGCP> NGOMJBJBKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[ReadOnly]
	private int PFCIDPHDJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[ReadOnly]
	private int BHGABILNAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> EAGGLHHLDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> PBJMFIPKLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FMHAHCJINPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> JDHDIEEEPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> ACCINAHJEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> LEGNMJLCPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> MGBEFELHEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	[ReadOnly]
	private float3 ONPDMNDAOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[ReadOnly]
	private quaternion MAOCJAHPJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	[ReadOnly]
	private float3 POFNJFILIKA;

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x7BCDF20", Offset = "0x7BCC720", VA = "0x187BCDF20")]
	public AOIALMFAGEJ(HHMLJOBPGPN OPJNIIHNOAB, PKKNLFDDHKF LMPJJMEBDPG, NativeArray<int> AMALGLPCFLE, float3 DIGBFODAMLP, quaternion HCJKDCONPLB, float PLPCFLNEKIF, int CFINJKCNKOP = 0, int CHDJGLLIHJG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x7BCE130", Offset = "0x7BCC930", VA = "0x187BCE130")]
	public AOIALMFAGEJ(BMKLKEJKGJM NFNBKNAJBPN, PKKNLFDDHKF LMPJJMEBDPG, NativeArray<int> AMALGLPCFLE, float3 DIGBFODAMLP, quaternion HCJKDCONPLB, float3 PLPCFLNEKIF, int CFINJKCNKOP = 0, int CHDJGLLIHJG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x7BCCAC0", Offset = "0x7BCB2C0", VA = "0x187BCCAC0", Slot = "4")]
	public void Execute(int IGNBGDBAAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x7BCDA70", Offset = "0x7BCC270", VA = "0x187BCDA70")]
	private void HCNIMBJEOHF(float4x4 PPGPACPMKJK, int IGNBGDBAAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7BCDE70", Offset = "0x7BCC670", VA = "0x187BCDE70")]
	private BFBOHMCCDBM JCBCFGIFICC(float3 GLANACDLEOF)
	{
		return default(BFBOHMCCDBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7BCDE20", Offset = "0x7BCC620", VA = "0x187BCDE20")]
	private float4 IBAEEAOPHDH(BFBOHMCCDBM IOOMCPCIDED, int FPEOONOJHML)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7BCDEE0", Offset = "0x7BCC6E0", VA = "0x187BCDEE0")]
	private float2 PPLABJLLOBO(BFBOHMCCDBM IOOMCPCIDED, float3 NCGKJMOKFAF)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct CJAEGNMKJDM
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public enum AJNLECBECBA
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static CJAEGNMKJDM HMAILHHHNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public float3 COFBFGOOFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public float3x3 PHMBAJJGPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public float3 OABHEPHNFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public AJNLECBECBA PALJBODIBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public float3 MOPLPOAJINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public float3 FOBMPFEANDA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool FFFKLPKJBMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1E10", Offset = "0x7BD0610", VA = "0x187BD1E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float3 GBEKDLEJDMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1890", Offset = "0x7BD0090", VA = "0x187BD1890")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7BD2110", Offset = "0x7BD0910", VA = "0x187BD2110")]
	public CJAEGNMKJDM(float3 NCGKJMOKFAF, quaternion PMHMEKBKJJA, float3 LBLAFDELPAC, AJNLECBECBA PIJHKCJDAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x7BD1A60", Offset = "0x7BD0260", VA = "0x187BD1A60")]
	public float FHPGNHIPOKH(float3 NANJGAHEDND, float JOBNALMNJDG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x7BD17A0", Offset = "0x7BCFFA0", VA = "0x187BD17A0")]
	public bool BBKHFDDPLGE(float3 GLANACDLEOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x7BD1C60", Offset = "0x7BD0460", VA = "0x187BD1C60")]
	public void GPBCHEKCCCA(float3 EAGKBNEMDFN, float3x3 KINNBLLOHCN, float OFJOGCKNOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x7BD1970", Offset = "0x7BD0170", VA = "0x187BD1970")]
	private void FFDCBKIHCOP(float3 AJNIOMMLJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7BD1E20", Offset = "0x7BD0620", VA = "0x187BD1E20")]
	public void NKBAAIKJMEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[BurstCompile]
public struct HLLPGOPOBKI : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[ReadOnly]
	private NativeList<CJAEGNMKJDM> NFNBKNAJBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[ReadOnly]
	private NativeList<float3> FNMEPMNCJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[ReadOnly]
	private NativeList<int> NKDBAHNOGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> KBIEPMECIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	[ReadOnly]
	private NativeList<LGKOIALHGCP> NGOMJBJBKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[ReadOnly]
	private int HAHEKJKCKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[ReadOnly]
	private int HOIOKLJBLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[ReadOnly]
	private float JOBNALMNJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	[ReadOnly]
	private float HKHIGPAEMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> CAODPNJDGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> IFGGDLICFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> AKKGPFGELLO;

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7BDA7E0", Offset = "0x7BD8FE0", VA = "0x187BDA7E0")]
	public HLLPGOPOBKI(PKKNLFDDHKF ABAPBBKNPBC, float MOIDLKBLOFO, int IFOFOJHAFEG, int FOFPGMOOKPN, NativeList<CJAEGNMKJDM> NFNBKNAJBPN, NativeArray<int> KBIEPMECIPN, NativeList<LGKOIALHGCP> NGOMJBJBKMH, PDCIDHGFBFE EONOKBFIFOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x7BD9D50", Offset = "0x7BD8550", VA = "0x187BD9D50", Slot = "4")]
	public void Execute(int DIKNJKGMNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7BDA490", Offset = "0x7BD8C90", VA = "0x187BDA490")]
	private bool FBECECGMBMG(CJAEGNMKJDM BINANFFLHIK, CJAEGNMKJDM NOAPPAEGHOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7BDA550", Offset = "0x7BD8D50", VA = "0x187BDA550")]
	private bool PNIADCPFLKL(CJAEGNMKJDM BDHNNIJDOJN, int LHKBFAIIFHG, int FDEOMMKBBDE, int LAJLDONLDCH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[BurstCompile]
public struct MPNKCHICHFB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private NativeList<DOPJHPLPMNH.GAOGLDLCJKM> EJBGMOCDJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[ReadOnly]
	private NativeArray<int> HFOIFBLCMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	[ReadOnly]
	private int CFINJKCNKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	[ReadOnly]
	private int CHDJGLLIHJG;

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2240", Offset = "0x7BE0A40", VA = "0x187BE2240")]
	public MPNKCHICHFB(NativeList<DOPJHPLPMNH.GAOGLDLCJKM> EJBGMOCDJAD, NativeArray<int> HFOIFBLCMOC, int CHDJGLLIHJG = 0, int CFINJKCNKOP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2190", Offset = "0x7BE0990", VA = "0x187BE2190", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class PDCIDHGFBFE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public NativeArray<bool> INAJNGFFEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public NativeArray<int> KNOOADDIIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public NativeArray<bool> LFLFMBFCKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public NativeArray<float> ECDOGIEEIJA;

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x7BE3BD0", Offset = "0x7BE23D0", VA = "0x187BE3BD0")]
	public void JDJGCBPDGJD(int JCDJHOHOPJC, int HFGIBGEKDDK, Allocator KKCJNCNIICO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x7BE3AC0", Offset = "0x7BE22C0", VA = "0x187BE3AC0")]
	public static long DOHKNGHBFJB(int JCDJHOHOPJC, int HFGIBGEKDDK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x7BE3AE0", Offset = "0x7BE22E0", VA = "0x187BE3AE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x7BE3CF0", Offset = "0x7BE24F0", VA = "0x187BE3CF0")]
	public void OCOBEACFBKJ(JobHandle OHHKLKBFKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public PDCIDHGFBFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[BurstCompile]
public struct MDFBNDFMMPP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private NativeList<float3> FNMEPMNCJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private NativeArray<float3> MGBCOPHNCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private NativeArray<float4> JDJEBBAHLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private NativeArray<float2> GFFDGIHFGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private NativeList<int> NKDBAHNOGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FNNEEPHEDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private NativeArray<int> MOFHPAMHGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	[ReadOnly]
	private NativeArray<bool> CAODPNJDGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	[ReadOnly]
	private NativeArray<bool> IFGGDLICFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	[ReadOnly]
	private int CFINJKCNKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	[ReadOnly]
	private int CHDJGLLIHJG;

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2110", Offset = "0x7BE0910", VA = "0x187BE2110")]
	public MDFBNDFMMPP(PKKNLFDDHKF ABAPBBKNPBC, PDCIDHGFBFE EONOKBFIFOG, int CHDJGLLIHJG = 0, int CFINJKCNKOP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x7BE1D30", Offset = "0x7BE0530", VA = "0x187BE1D30", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x7BE1CD0", Offset = "0x7BE04D0", VA = "0x187BE1CD0")]
	private void ELEADAOGNAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class DLADHAJIDMG
{
	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x35D8CE0", Offset = "0x35D74E0", VA = "0x1835D8CE0")]
	public static bool FGAEKLACLEP<T>(NativeArray<T> CPIDEKBKOPO, int LBLAFDELPAC, Allocator KKCJNCNIICO, NativeArrayOptions AKIEDMONOFM = NativeArrayOptions.ClearMemory, int KKCFDDDKOEJ = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x35D8EF0", Offset = "0x35D76F0", VA = "0x1835D8EF0")]
	public static bool FGAEKLACLEP<T>(NativeList<T> GIPAMJGJGNH, int LBLAFDELPAC, Allocator KKCJNCNIICO) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x35D8E60", Offset = "0x35D7660", VA = "0x1835D8E60")]
	public static bool FGAEKLACLEP<T>(NativeQueue<T> ICEHGIIKNAN, Allocator KKCJNCNIICO) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public enum IBLMMLLPHCM
{
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Near,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	Far,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	Force0,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	Force1,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Force2,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	AllOfThem
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public interface PPIHHPOBLHH
{
	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int HFOBGJGPENH(IBLMMLLPHCM BIPGHKPGBAC);

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int KLHKGOCDODI(IBLMMLLPHCM BIPGHKPGBAC);

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EMKIDKCECNG MMJKADEILOI();

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float NEGBPGDPJPH();

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AIAIAKLCEEF(IBLMMLLPHCM BIPGHKPGBAC, HHMLJOBPGPN AAEEGKJJJMM, int DCLEFLOOHJB = -1);

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int DPKDDIAPKBD(int JGJHLGAPPFL);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class NOMOOCEPAHH
{
	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2260", Offset = "0x7BE0A60", VA = "0x187BE2260")]
	public static void FBJANABPJBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class OKGKCPLKBHN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public NativeList<float3> KFFLNGKEBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public NativeArray<float3> BOIAIJHJDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public NativeArray<int> NCHOBMMNCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public NativeArray<float4> BGOPFLBLENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public NativeArray<float4> NNGKKKIDMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public NativeArray<float4> BLEKIICLFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public NativeArray<int> CBCAIDJCEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NativeList<float3> LHMHNKGKMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public NativeList<int> COCKEFNFHKL;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int ADDMENBCPDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x7BE2E50", Offset = "0x7BE1650", VA = "0x187BE2E50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int EEBNJGNDFLH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7BE2E90", Offset = "0x7BE1690", VA = "0x187BE2E90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int EMIMFDAMNGM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7BE2E10", Offset = "0x7BE1610", VA = "0x187BE2E10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7BE37A0", Offset = "0x7BE1FA0", VA = "0x187BE37A0")]
	public OKGKCPLKBHN(int JCDJHOHOPJC, int HFGIBGEKDDK, int OHCOIGJCFHC, Allocator KKCJNCNIICO = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x7BE3440", Offset = "0x7BE1C40", VA = "0x187BE3440")]
	public OKGKCPLKBHN(Mesh ABAPBBKNPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2860", Offset = "0x7BE1060", VA = "0x187BE2860", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2530", Offset = "0x7BE0D30", VA = "0x187BE2530")]
	public void BJOHCNAKMFD(OKGKCPLKBHN ABAPBBKNPBC, bool CLKMJEEEENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2980", Offset = "0x7BE1180", VA = "0x187BE2980")]
	private void EPFFADHKDOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2ED0", Offset = "0x7BE16D0", VA = "0x187BE2ED0")]
	private void OJHCPNBFIPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct LGKOIALHGCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public int GAOJNBKNDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public int ADDMENBCPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public int OACJPADGBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public int EEBNJGNDFLH;

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x1EFE5D0", Offset = "0x1EFCDD0", VA = "0x181EFE5D0")]
	public LGKOIALHGCP(int FOFPGMOOKPN, int PKBFIOIHAOL, int IFOFOJHAFEG, int EKBBKNBDGCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class EJNEKDLJOBA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NativeList<LGKOIALHGCP> BOHOJAMCELN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xF63890", Offset = "0xF62090", VA = "0x180F63890")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<LGKOIALHGCP>);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xF63950", Offset = "0xF62150", VA = "0x180F63950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public OKGKCPLKBHN ECLDOGPLLOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x7BD28B0", Offset = "0x7BD10B0", VA = "0x187BD28B0")]
	public EJNEKDLJOBA(IEnumerable<OKGKCPLKBHN> EPEHJJONMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7BD2840", Offset = "0x7BD1040", VA = "0x187BD2840", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public enum NGMFIBACAJD
{
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class GEAIPGHHFMG
{
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static NativeArray<float2> KEIGCMGACGG;

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private static NativeArray<float3> CKIMFHFFPIC;

	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private static NativeArray<float4> JOEKEGBGOID;

	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private static NativeArray<int> MIIBFMAOHBH;

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x7BF1180", Offset = "0x7BEF980", VA = "0x187BF1180")]
	public static void FBJANABPJBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x7BF1290", Offset = "0x7BEFA90", VA = "0x187BF1290")]
	public static NativeArray<float2> GHDCPJNOOIF(NativeArray<float2> DFJGENKPNNH, int FIGOIOCDLDO, NativeArray<float2> DHMJCHEPPKJ, int EFALMBIHNPO)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x7BF1390", Offset = "0x7BEFB90", VA = "0x187BF1390")]
	public static NativeArray<float3> IBBOCLKCJED(NativeArray<float3> DFJGENKPNNH, int FIGOIOCDLDO, NativeArray<float3> DHMJCHEPPKJ, int EFALMBIHNPO)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x7BF1590", Offset = "0x7BEFD90", VA = "0x187BF1590")]
	public static NativeArray<float4> MJGMJFBEMON(NativeArray<float4> DFJGENKPNNH, int FIGOIOCDLDO, NativeArray<float4> DHMJCHEPPKJ, int EFALMBIHNPO)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x7BF1490", Offset = "0x7BEFC90", VA = "0x187BF1490")]
	public static NativeArray<int> JKFIJDHKIKH(NativeArray<int> DFJGENKPNNH, int FIGOIOCDLDO, NativeArray<int> DHMJCHEPPKJ, int EFALMBIHNPO)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x3795010", Offset = "0x3793810", VA = "0x183795010")]
	private static void DKJFOCHKLCG<T>(NativeArray<T> CPIDEKBKOPO, int ANCHJAKGKDP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x3795210", Offset = "0x3793A10", VA = "0x183795210")]
	private static void EMJKFJEJIOM<T>(NativeArray<T> DFJGENKPNNH, int FIGOIOCDLDO, NativeArray<T> DHMJCHEPPKJ, int EFALMBIHNPO, NativeArray<T> GCPNLJNGDPA) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[BurstCompile]
public class KJEODGEEHDG
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public struct LIAFEBMGADO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public ushort LEFBJAGNHCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public ushort LLGPJHIECFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public ushort JIFGKBNPEMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public ushort MHBABFMKBKO;
	}

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7200", Offset = "0x7BF5A00", VA = "0x187BF7200")]
	public static uint HHDGONLGNMG(float LHGFPGFEPOI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x7BF6E90", Offset = "0x7BF5690", VA = "0x187BF6E90")]
	public static void COMEFAEJNFD(float4 JDJEBBAHLBG, float BIACDDEFMLH, [Out] uint OBCAOAFBBCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x7BF6FA0", Offset = "0x7BF57A0", VA = "0x187BF6FA0")]
	public static void COMEFAEJNFD(float4 JDJEBBAHLBG, uint IECJJEFJHEL, [Out] uint OBCAOAFBBCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x7BF75C0", Offset = "0x7BF5DC0", VA = "0x187BF75C0")]
	public static void KKIKLAHHOPN(float3 IKAJLJKFHBE, float3 DNPACDKLMIK, float4 FLFNKGGADNM, float2 PODDLGCCEPC, float4 JDJEBBAHLBG, [Out] PKKNLFDDHKF.LAFBFKCBMPA CNKANJLOMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7360", Offset = "0x7BF5B60", VA = "0x187BF7360")]
	public static void KKIKLAHHOPN(float3 IKAJLJKFHBE, float3 DNPACDKLMIK, float4 FLFNKGGADNM, float2 PODDLGCCEPC, float4 JDJEBBAHLBG, [Out] PKKNLFDDHKF.MGOBFJFJINC CNKANJLOMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7860", Offset = "0x7BF6060", VA = "0x187BF7860")]
	public static byte PMCCKCMJOBL(float OPMIAMEJKDH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7810", Offset = "0x7BF6010", VA = "0x187BF7810")]
	public static ushort NANKMFNFCDN(float OPMIAMEJKDH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7070", Offset = "0x7BF5870", VA = "0x187BF7070")]
	public static uint COPAMGGDBJC(float OPMIAMEJKDH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x7BF6CC0", Offset = "0x7BF54C0", VA = "0x187BF6CC0")]
	public static float2 BLPONGCBPMO(float2 AALALMNDJKO)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x7BF6D40", Offset = "0x7BF5540", VA = "0x187BF6D40")]
	public static float2 BOFHMODKANO(float3 PEDIPEHLBOO)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7210", Offset = "0x7BF5A10", VA = "0x187BF7210")]
	public static void KFLBEPOAEBO(float3 OPMIAMEJKDH, [Out] float3 DHHJNIKKLLG, [Out] uint3 MHBABFMKBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x7BF70A0", Offset = "0x7BF58A0", VA = "0x187BF70A0")]
	public static LIAFEBMGADO HBEFALMPEPM(float3 NCGKJMOKFAF)
	{
		return default(LIAFEBMGADO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class MMDFAHIFFEI
{
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly ProfilerMarker DFFFFCGJJGB;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public static float PICBCPPBGJM;

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
	private static void DPKPHJOJLNK(bool OGDDJEDBANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7F70", Offset = "0x7BF6770", VA = "0x187BF7F70")]
	public static float ICGLJNMDMHH(float CIKGJHMEANL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7E80", Offset = "0x7BF6680", VA = "0x187BF7E80")]
	public static long DJNGHGPBPFN(float CIKGJHMEANL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x7BF79E0", Offset = "0x7BF61E0", VA = "0x187BF79E0")]
	public static void BLMKNIBNIDH(float CIKGJHMEANL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public interface NBMIMIFKHBB
{
	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BLMKNIBNIDH(float PFIMCFCIEIA);

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	(long, long, int) MIJKHAHMDDJ(float CAABHPJGKOJ);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public static class PPOAONOPNIN
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public enum JHMMGMKKMMC
	{
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		ShapesStartTreeGeneration,
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		ShapesTreeRefresh,
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		ShapesTreeError,
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		ShapesLod012Error
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private struct DOOKGFBCILM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public JHMMGMKKMMC PIJHKCJDAHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public float IEAGNNNDKKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public BatchedMeshRenderer EKPFKKKJAED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public KGDMJFAMKAM OFODIBMPMCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public DOPJHPLPMNH EDLMENLIFID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public long DNIGGJFPPIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public long DBDLOMPCAFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public float EJDPEBCILIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public bool PBDNLKEJFFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public bool JEGAFKBIHBD;
	}

	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public static int KBLFFLHEPKF;

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public static int PNEPANFPKGG;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public static int IDNLODINKHJ;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public static long HEJHAJGBAGK;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public static long ONCADLHMLIP;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public static long GKIBHONGBHI;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public static long HCCLEOMKCNH;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public static int JPFMDGPIMJA;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public static float MPFPBOEFBCD;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public static bool CEFPFAHHCHM;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static int FIMKEPDCNMM;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public static int AHPCMKDHIBE;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public static int BHIBDAHFFPL;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public static long ADIMKLLDDDK;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public static int JONGPEBDLCF;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public static bool HDOHAPGEELE;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static List<DOOKGFBCILM> ONMDFMBDNCF;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static NBMIMIFKHBB DGIJNKEJJID;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static bool PNPHNEELAGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x7BFB990", Offset = "0x7BFA190", VA = "0x187BFB990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
	private static void OFMJBIHCGJJ(bool OGDDJEDBANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
	private static void DPKPHJOJLNK(bool OGDDJEDBANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
	private static void OFMJBIHCGJJ(bool OGDDJEDBANI, string NJAAPDELBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7BFAFB0", Offset = "0x7BF97B0", VA = "0x187BFAFB0")]
	public static void LNPBOBCKHOJ(NBMIMIFKHBB DOFEIMDJCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x7BFA730", Offset = "0x7BF8F30", VA = "0x187BFA730")]
	public static (long, long, long, int, int) EBIODPDPIMH(long OEJNJCJLMEM)
	{
		return default((long, long, long, int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x7BFBB90", Offset = "0x7BFA390", VA = "0x187BFBB90")]
	public static void PJGDNNEIHEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x7BF8150", Offset = "0x7BF6950", VA = "0x187BF8150")]
	public static void BLMKNIBNIDH(long OEJNJCJLMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x7BFAF10", Offset = "0x7BF9710", VA = "0x187BFAF10")]
	public static void KKOADDHHNGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x7BFAB80", Offset = "0x7BF9380", VA = "0x187BFAB80")]
	public static long JHOGLJNLPOF(long MLAFIFDIEPA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB8C0", Offset = "0x7BFA0C0", VA = "0x187BFB8C0")]
	public static bool NOHLLLNDKAM(long CABBBPALCFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x7BFAA00", Offset = "0x7BF9200", VA = "0x187BFAA00")]
	public static bool FBJFGDHKFMI(long CABBBPALCFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x7BFBC10", Offset = "0x7BFA410", VA = "0x187BFBC10")]
	public static float PNFAINOLMHK(long ALHPKBJDJMM, int OBDDLNDCKGF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB310", Offset = "0x7BF9B10", VA = "0x187BFB310")]
	public static (long, long, int) MIJKHAHMDDJ(float CIKGJHMEANL)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x7BFA5A0", Offset = "0x7BF8DA0", VA = "0x187BFA5A0")]
	public static void COGBMGOGNGF(DOPJHPLPMNH EDLMENLIFID, BatchedMeshRenderer EKPFKKKJAED, long AHEGFAOFNOB, long DBDLOMPCAFI, float FJPEHJCLFOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x7BFAD90", Offset = "0x7BF9590", VA = "0x187BFAD90")]
	public static void KDNGDBEDJEA(DOPJHPLPMNH EDLMENLIFID, BatchedMeshRenderer EKPFKKKJAED, long AHEGFAOFNOB, long DBDLOMPCAFI, float AKFCEGILIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB710", Offset = "0x7BF9F10", VA = "0x187BFB710")]
	public static void NGMJEFGAFBD(DOPJHPLPMNH EDLMENLIFID, BatchedMeshRenderer EKPFKKKJAED, long DBDLOMPCAFI, float AKFCEGILIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB9E0", Offset = "0x7BFA1E0", VA = "0x187BFB9E0")]
	public static void PDIJDCILABN(DOPJHPLPMNH EDLMENLIFID, BatchedMeshRenderer EKPFKKKJAED, long AHEGFAOFNOB, long DBDLOMPCAFI, float AKFCEGILIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB020", Offset = "0x7BF9820", VA = "0x187BFB020")]
	public static void LPIIMEKAKFK(JHMMGMKKMMC PIJHKCJDAHO, DOPJHPLPMNH EDLMENLIFID, KGDMJFAMKAM OFODIBMPMCH, BatchedMeshRenderer EKPFKKKJAED, long AHEGFAOFNOB, long DBDLOMPCAFI, float GDDEBOJLENK, bool PBDNLKEJFFC, bool JEGAFKBIHBD, float IEAGNNNDKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x7BFAAD0", Offset = "0x7BF92D0", VA = "0x187BFAAD0")]
	public static bool GGLIFJMJMIE(float ABBHJHJALCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x7BFAD20", Offset = "0x7BF9520", VA = "0x187BFAD20")]
	public static void KDACNAMHOED(float ABBHJHJALCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x7BFA8F0", Offset = "0x7BF90F0", VA = "0x187BFA8F0")]
	public static bool EGBPPENBENH(float ABBHJHJALCJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public class KGDMJFAMKAM
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	internal enum NMCMBLPNDAD
	{
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		UninitImmediate,
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		UninitImmediateInJob,
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		UninitAsync,
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		NoMeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		NoMeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		MeshNoData,
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		MeshNoDataFrozen,
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		MeshNoDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		MeshLodData,
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		MeshLodDataNaughty,
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		MeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		MeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		MeshAllData,
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		MeshAllDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		MeshAllDataInJob,
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		MeshAllDataInJob2,
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		LAST_VALUE
	}

	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private static readonly string BCIPHOLNOGP;

	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private static readonly string LOFGBOHGFOL;

	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private static readonly ProfilerMarker OEJINCLHMFG;

	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private static readonly ProfilerMarker FKLNAFBAKLN;

	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private static readonly ProfilerMarker DFFFFCGJJGB;

	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private static readonly ProfilerMarker LIHBCKDCGBK;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private static readonly ProfilerMarker AJBEFGHKFIL;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private static readonly ProfilerMarker LINONPLLOLG;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly ProfilerMarker KAICLKLECGP;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private static readonly ProfilerMarker KODPJIBCKNP;

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private static readonly ProfilerMarker NBFPPCPOPMC;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private static readonly ProfilerMarker EFJDALFFHAB;

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private static readonly ProfilerMarker HDJGMKMNJPO;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly ProfilerMarker DPLJHANOOPI;

	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private static readonly ProfilerMarker PGCKNOCKBEL;

	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly ProfilerMarker FAEAKHJPJEH;

	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private static readonly ProfilerMarker NIBHHHLDOAA;

	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private static readonly ProfilerMarker GMFMFPDKBND;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly ProfilerMarker EHNHHABONMM;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly ProfilerMarker NKKIKHODAKD;

	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private static readonly ProfilerMarker ILFDHKNHJON;

	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private static readonly ProfilerMarker GBFDPAPLAHH;

	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private static readonly ProfilerMarker OCMFOMIMFKP;

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly ProfilerMarker KOBGFMHJHKG;

	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private static readonly ProfilerMarker OJAANHFPAGF;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private static readonly ProfilerMarker KAJIHJAHGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	internal readonly List<DOPJHPLPMNH> CBGDAJFOFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	internal DOPJHPLPMNH OOBDOPPOCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly MBIIGEKJFNE EKIOANAOGLL;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public const bool LFECAKEBOED = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public bool ODMFIMECMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	internal NMCMBLPNDAD KDKHKBDNNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	internal int CHCCDEDCKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	internal int OGJHGHPODIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	internal int APNIJOLEGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	internal int EFHOLGBGHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	internal long ECOEGPPLMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	internal long PNMBDLHJNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	internal long FIKBBJDFNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private PKKNLFDDHKF MPBBDGGOJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private PKKNLFDDHKF MGLIDOHMKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private PKKNLFDDHKF.EHNEFMAHLAI DHGBEMHHBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private bool JPCJJBEMLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	private int FDJKOFOOONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	private PLFNJBAAGCP BGNCOBKKGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private float3 IIOOGOGENHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private float PCKNLMFNAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private float MODIICMPCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private float KKKDNEILPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private float CMGIABDJHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private float BJDGKEPDNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private float JPANLJKOAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private float3 FKAFEACLCBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private float CCBKKELDKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private float MFDGOFFMNPL;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	internal Mesh ECLDOGPLLOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MeshFilter GOFEPHADANP
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public MeshRenderer HPAJPOBNKEA
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DC0", Offset = "0x9DF5C0", VA = "0x1809E0DC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public List<Material> DBFJGADLELN
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x9E2460", Offset = "0x9E0C60", VA = "0x1809E2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DA0", Offset = "0x9DF5A0", VA = "0x1809E0DA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int KFMCEIJJLJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3AB0", Offset = "0x7BF22B0", VA = "0x187BF3AB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int IADDFFFBMDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0xD43E80", Offset = "0xD42680", VA = "0x180D43E80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int ADDMENBCPDG
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4880", Offset = "0x7BF3080", VA = "0x187BF4880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x7BF48B0", Offset = "0x7BF30B0", VA = "0x187BF48B0")]
	public void HLOJKAKECIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4C30", Offset = "0x7BF3430", VA = "0x187BF4C30")]
	public bool IPAFKFKAGPN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x7BF3080", Offset = "0x7BF1880", VA = "0x187BF3080")]
	private void CILMFOFIOLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x7BF3430", Offset = "0x7BF1C30", VA = "0x187BF3430")]
	private void DFLNJNFGEDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7BF6B20", Offset = "0x7BF5320", VA = "0x187BF6B20")]
	public KGDMJFAMKAM(string GLGOHIJMLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x7BF55E0", Offset = "0x7BF3DE0", VA = "0x187BF55E0")]
	public void OCOBEACFBKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x7BF2000", Offset = "0x7BF0800", VA = "0x187BF2000")]
	private void BBFFEABELNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7BF36A0", Offset = "0x7BF1EA0", VA = "0x187BF36A0")]
	private void DLCKNNIFKBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x7BF31A0", Offset = "0x7BF19A0", VA = "0x187BF31A0")]
	public Mesh CJNLHBFCJKA(MeshFilter IJIMEMLJMOF, Transform POFBAOBKAGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4B30", Offset = "0x7BF3330", VA = "0x187BF4B30")]
	private void IKCJFIIHPPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x7BF3930", Offset = "0x7BF2130", VA = "0x187BF3930")]
	public void DMAPEONODMJ(PPIHHPOBLHH ILIHIOEKKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x7BF49E0", Offset = "0x7BF31E0", VA = "0x187BF49E0")]
	public bool IDHKMHMBDEP(PPIHHPOBLHH ILIHIOEKKHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7BF63E0", Offset = "0x7BF4BE0", VA = "0x187BF63E0")]
	public bool PHEIEKKHJKM(PPIHHPOBLHH ILIHIOEKKHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5250", Offset = "0x7BF3A50", VA = "0x187BF5250", Slot = "4")]
	public virtual void KAENDCOHEFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4510", Offset = "0x7BF2D10", VA = "0x187BF4510")]
	public void GAFOJDCPHKL(Transform LJCNODBNLPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x7BF1BB0", Offset = "0x7BF03B0", VA = "0x187BF1BB0")]
	public bool APHMNKDLEDJ(Transform LJCNODBNLPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5920", Offset = "0x7BF4120", VA = "0x187BF5920")]
	public bool OKPBJKAPDOE(bool BGFCEOJPJLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x7BF3BE0", Offset = "0x7BF23E0", VA = "0x187BF3BE0")]
	private void EFFIGOIKCFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x7BF20A0", Offset = "0x7BF08A0", VA = "0x187BF20A0")]
	public bool BLMKNIBNIDH(float4x4 GGLAGEKANKP, BatchedMeshRenderer BNKAHDMCGHN, bool OMPLDMNNHMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5ED0", Offset = "0x7BF46D0", VA = "0x187BF5ED0")]
	public bool OLILCBJFADO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x7BF3C60", Offset = "0x7BF2460", VA = "0x187BF3C60")]
	public void FBDNBCIOKPF(PKKNLFDDHKF ABAPBBKNPBC, int GMCANLEKPPI, int NFHFMLBNHAN, float HKOGKMFJPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4AB0", Offset = "0x7BF32B0", VA = "0x187BF4AB0")]
	public (long, long, long) IFGEPPHAFJH()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x9DD1C0", Offset = "0x9DB9C0", VA = "0x1809DD1C0")]
	public long PADGOMFNCPP()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7BF3580", Offset = "0x7BF1D80", VA = "0x187BF3580")]
	private void DJILJJIPBHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5370", Offset = "0x7BF3B70", VA = "0x187BF5370")]
	public (long, long, int) MIJKHAHMDDJ(float CIKGJHMEANL, float4x4 GGLAGEKANKP)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x7BF6470", Offset = "0x7BF4C70", VA = "0x187BF6470")]
	internal void PILIEIDIMDG(NMCMBLPNDAD CKHCKOICGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x7BF3DE0", Offset = "0x7BF25E0", VA = "0x187BF3DE0")]
	internal (float, float, float, float) FMPOHEBNNOE(float OGLMKNEFHID, float4x4 GGLAGEKANKP)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5030", Offset = "0x7BF3830", VA = "0x187BF5030")]
	public void JLEPBPNIFIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x7BF3230", Offset = "0x7BF1A30", VA = "0x187BF3230")]
	private void DDMEAFAMBEL(PKKNLFDDHKF LPCDNEFNDOC, PKKNLFDDHKF.EHNEFMAHLAI AGOEGFGGBDP, bool CHEKCBNHAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x7BF44F0", Offset = "0x7BF2CF0", VA = "0x187BF44F0")]
	private void GAECKDKOEFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x7BF3AD0", Offset = "0x7BF22D0", VA = "0x187BF3AD0")]
	internal bool EDPAMEHEDBJ(bool BGFCEOJPJLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x7BF2DA0", Offset = "0x7BF15A0", VA = "0x187BF2DA0")]
	private void BOCIOMPGDJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x7BF17D0", Offset = "0x7BEFFD0", VA = "0x187BF17D0")]
	private void AIMPDJCMLEA([In] IHLJGJEJFHB LPCDNEFNDOC, PKKNLFDDHKF.EHNEFMAHLAI AGOEGFGGBDP, bool CHEKCBNHAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x7BF3D40", Offset = "0x7BF2540", VA = "0x187BF3D40")]
	private void FGMOMAHAFPB(PKKNLFDDHKF.EHNEFMAHLAI AGOEGFGGBDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x7BF3CA0", Offset = "0x7BF24A0", VA = "0x187BF3CA0")]
	private void FBPHFJAFBGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x7BF1690", Offset = "0x7BEFE90", VA = "0x187BF1690")]
	private void AEFBMKGEFPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4D50", Offset = "0x7BF3550", VA = "0x187BF4D50")]
	public long JHOGLJNLPOF(long MLAFIFDIEPA, int EMBCDHBDDAB)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class DOPJHPLPMNH
{
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	internal enum GGKMHBJKJPG
	{
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		UninitImmediate,
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		UninitImmediateInJob,
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		UninitAsync,
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		NoMeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		NoMeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		MeshNoData,
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		MeshNoDataFrozen,
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		MeshNoDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		MeshLodData,
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		MeshLodDataNaughty,
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		MeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		MeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		MeshAllData,
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		MeshAllDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		MeshAllDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		MeshAllDataInJob2,
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		LAST_VALUE
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public struct GAOGLDLCJKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public int MCBIGGDDMJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public int FCJOOPHGPGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public float IEPHMINOJKN;
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public struct KJLFIHOGLBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public IHLJGJEJFHB ABAPBBKNPBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public int JFFHJANBLGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public int BBDODJJOPAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public long ELAJEJBAHNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public long GKNPNLADFKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public float NCFBBNIIKFE;

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7930", Offset = "0x7BF6130", VA = "0x187BF7930")]
		public void ILJHHMHPGDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7960", Offset = "0x7BF6160", VA = "0x187BF7960")]
		public void OCOBEACFBKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private static readonly string BCIPHOLNOGP;

	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private static readonly string LOFGBOHGFOL;

	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private static readonly ProfilerMarker OEJINCLHMFG;

	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private static readonly ProfilerMarker FKLNAFBAKLN;

	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private static readonly ProfilerMarker DFFFFCGJJGB;

	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private static readonly ProfilerMarker LIHBCKDCGBK;

	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private static readonly ProfilerMarker AJBEFGHKFIL;

	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private static readonly ProfilerMarker LINONPLLOLG;

	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private static readonly ProfilerMarker KAICLKLECGP;

	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private static readonly ProfilerMarker KODPJIBCKNP;

	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private static readonly ProfilerMarker NBFPPCPOPMC;

	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private static readonly ProfilerMarker EFJDALFFHAB;

	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private static readonly ProfilerMarker HDJGMKMNJPO;

	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private static readonly ProfilerMarker DPLJHANOOPI;

	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private static readonly ProfilerMarker PGCKNOCKBEL;

	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private static readonly ProfilerMarker FAEAKHJPJEH;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private static readonly ProfilerMarker NIBHHHLDOAA;

	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private static readonly ProfilerMarker GMFMFPDKBND;

	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private static readonly ProfilerMarker EHNHHABONMM;

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static readonly ProfilerMarker NKKIKHODAKD;

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private static readonly ProfilerMarker ILFDHKNHJON;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private static readonly ProfilerMarker GBFDPAPLAHH;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private static readonly ProfilerMarker OCMFOMIMFKP;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private static readonly ProfilerMarker KOBGFMHJHKG;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static readonly ProfilerMarker OJAANHFPAGF;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static readonly ProfilerMarker KAJIHJAHGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	internal readonly List<PPIHHPOBLHH> MLOHNMJPFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	internal KGDMJFAMKAM CNKDHGPIGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private readonly MBIIGEKJFNE EKIOANAOGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	internal int CLLFMCICCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	internal int OAKIKEDLBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	internal bool BONONKODPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	internal bool DMGMAIIKOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	internal GGKMHBJKJPG OAGFPIJHNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	internal bool PGAHDPMCEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	internal float3 FJNDGCOBIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	internal float3 JCGJKJLALKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	internal float NCOIGGEELMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	internal int IHIOHAJDKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	internal int CLLHFHIGBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	internal float FKKBDCFKBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	internal float ENIOPLNJFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	internal int BLPBBNALCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	internal long OKNIKNCMKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public int OBHEBCHDHFL;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	internal const int ECJBHAEEJOI = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	internal float[] OIBIOFMLLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	internal int[] AHEFDKPLPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	internal long[] FDNLLEJLAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public List<KJLFIHOGLBL> IAMAONDLKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	internal PKKNLFDDHKF PONIGAJIMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	internal long IJIMHPBGBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	internal int DJHLAHEIJNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	internal float HDGBLBLNCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	internal PKKNLFDDHKF.EHNEFMAHLAI GKAIENLPNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	internal bool FIKGBKICHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	internal HDNPPECAKKJ GOCEBHJDCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	internal JobHandle NLPPKCIKLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	internal NativeList<GAOGLDLCJKM> KEEMPKFMALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	internal NativeArray<long> MFBHDNMHDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	internal bool BHFPIGOLJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	internal JobHandle IBMNFHFMMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	internal PKKNLFDDHKF JMAEFIPIAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	internal PDCIDHGFBFE DHMGELBLDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	internal NativeList<GAOGLDLCJKM> PKKCBDKDNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	internal Transform EFNMDONBJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	internal IBLMMLLPHCM MHLJPNELNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	internal long BJFMHMPGCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	internal long NDACEJLAHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	internal long JOEPMMCLJDP;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public List<PPIHHPOBLHH> OCJBJKEEEFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal int ADDMENBCPDG
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x7BEB9D0", Offset = "0x7BEA1D0", VA = "0x187BEB9D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x7BEBA90", Offset = "0x7BEA290", VA = "0x187BEBA90")]
	internal void HLOJKAKECIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x7BE9760", Offset = "0x7BE7F60", VA = "0x187BE9760")]
	internal void CILMFOFIOLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x7BF0E60", Offset = "0x7BEF660", VA = "0x187BF0E60")]
	internal DOPJHPLPMNH(string GLGOHIJMLFB, KGDMJFAMKAM DFPCBMGPBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x7BEEA10", Offset = "0x7BED210", VA = "0x187BEEA10")]
	internal void OCOBEACFBKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x7BEBB20", Offset = "0x7BEA320", VA = "0x187BEBB20")]
	internal void IKCJFIIHPPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x7BE9D10", Offset = "0x7BE8510", VA = "0x187BE9D10")]
	internal void DMAPEONODMJ(PPIHHPOBLHH ILIHIOEKKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x7BEBAA0", Offset = "0x7BEA2A0", VA = "0x187BEBAA0")]
	internal bool IDHKMHMBDEP(PPIHHPOBLHH ILIHIOEKKHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x7BF0720", Offset = "0x7BEEF20", VA = "0x187BF0720")]
	internal bool PHEIEKKHJKM(PPIHHPOBLHH ILIHIOEKKHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x7BED830", Offset = "0x7BEC030", VA = "0x187BED830", Slot = "4")]
	internal virtual void KAENDCOHEFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB140", Offset = "0x7BE9940", VA = "0x187BEB140")]
	internal long FJCAABEIMGL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x7BEDDD0", Offset = "0x7BEC5D0", VA = "0x187BEDDD0")]
	internal long MAKOMNBFDMM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7390", Offset = "0x7BE5B90", VA = "0x187BE7390")]
	internal bool APHMNKDLEDJ(Transform LJCNODBNLPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x7BEF7A0", Offset = "0x7BEDFA0", VA = "0x187BEF7A0")]
	internal (bool, PKKNLFDDHKF) OKPBJKAPDOE(bool BGFCEOJPJLG)
	{
		return default((bool, PKKNLFDDHKF));
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x7BE9F80", Offset = "0x7BE8780", VA = "0x187BE9F80")]
	internal void EFFIGOIKCFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7BE8030", Offset = "0x7BE6830", VA = "0x187BE8030")]
	internal bool BLMKNIBNIDH(float4x4 GGLAGEKANKP, BatchedMeshRenderer BNKAHDMCGHN, bool OMPLDMNNHMO, bool IKIALJJJLMG, float MODIICMPCHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x7BF03D0", Offset = "0x7BEEBD0", VA = "0x187BF03D0")]
	public (bool, IHLJGJEJFHB) OLILCBJFADO()
	{
		return default((bool, IHLJGJEJFHB));
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x7BED7B0", Offset = "0x7BEBFB0", VA = "0x187BED7B0")]
	internal void KAAFMDDCKPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC550", Offset = "0x7BEAD50", VA = "0x187BEC550")]
	internal bool JIPNOHFBFPO(bool BGFCEOJPJLG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x7BEDD30", Offset = "0x7BEC530", VA = "0x187BEDD30")]
	internal void LFOFMAAIHJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB0E0", Offset = "0x7BE98E0", VA = "0x187BEB0E0")]
	internal void FBDNBCIOKPF(PKKNLFDDHKF ABAPBBKNPBC, int GMCANLEKPPI, int NFHFMLBNHAN, float HKOGKMFJPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x7BE6C60", Offset = "0x7BE5460", VA = "0x187BE6C60")]
	internal void AGAPKOMOCHK(IHLJGJEJFHB MOALJDCLIPG, int GMCANLEKPPI, int NFHFMLBNHAN, float HKOGKMFJPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x7BE9920", Offset = "0x7BE8120", VA = "0x187BE9920")]
	internal void DJILJJIPBHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x7BEDEE0", Offset = "0x7BEC6E0", VA = "0x187BEDEE0")]
	internal (long, long, int) MIJKHAHMDDJ(float CIKGJHMEANL, float4x4 GGLAGEKANKP)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x7BF0780", Offset = "0x7BEEF80", VA = "0x187BF0780")]
	internal void PILIEIDIMDG(GGKMHBJKJPG CKHCKOICGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB1F0", Offset = "0x7BE99F0", VA = "0x187BEB1F0")]
	internal (float, float, float, float) FMPOHEBNNOE(float OGLMKNEFHID, float4x4 GGLAGEKANKP)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x7BEBDB0", Offset = "0x7BEA5B0", VA = "0x187BEBDB0")]
	private float JHMCJOAEOLC(float OGLMKNEFHID, float4x4 GGLAGEKANKP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x7BE6EE0", Offset = "0x7BE56E0", VA = "0x187BE6EE0")]
	private (int, int) ALOIHNNJLLN(float DIDBLCEPCEE)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB9F0", Offset = "0x7BEA1F0", VA = "0x187BEB9F0")]
	internal static float HIEFHKNLANM(PPIHHPOBLHH ABAPBBKNPBC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC880", Offset = "0x7BEB080", VA = "0x187BEC880")]
	internal void JLEPBPNIFIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB110", Offset = "0x7BE9910", VA = "0x187BEB110")]
	internal void FBPHFJAFBGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x7BE6940", Offset = "0x7BE5140", VA = "0x187BE6940")]
	internal void AEFBMKGEFPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x7BEBE10", Offset = "0x7BEA610", VA = "0x187BEBE10")]
	internal long JHOGLJNLPOF(long MLAFIFDIEPA, int EMBCDHBDDAB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x7BEEB60", Offset = "0x7BED360", VA = "0x187BEEB60")]
	private void OCPONOEOMCA(PKKNLFDDHKF PNFIDOHLINK, NativeList<GAOGLDLCJKM> OBMIONMHDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x7BED8C0", Offset = "0x7BEC0C0", VA = "0x187BED8C0")]
	internal void KBLFENADKPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x7BEE340", Offset = "0x7BECB40", VA = "0x187BEE340")]
	public static void MLHLBLDEOBI(NativeList<GAOGLDLCJKM> MJGNFHNFIAE, PKKNLFDDHKF PNFIDOHLINK, int HMHJBPLNEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x7BEDD40", Offset = "0x7BEC540", VA = "0x187BEDD40")]
	private float LNLIGAEMMHH(int IKBNJNJDLOD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x7BEA6B0", Offset = "0x7BE8EB0", VA = "0x187BEA6B0")]
	internal void EMOGIPLLPAH(PKKNLFDDHKF ABAPBBKNPBC, FAAMFBBAENC MOALJDCLIPG, int GMCANLEKPPI, int NFHFMLBNHAN, float HKOGKMFJPMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[BurstCompile]
internal struct CEPJAPBOOFF : IJob
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	internal struct CNCBLOPFLAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public int IBKMMCAIMDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public int CIBDPHPBEOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int CNEGHMIDOPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public float LHLLGHOJLDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public float BOCBALLKLFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public float JJGNCADMOLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public float EDIBCFBIKBG;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	internal struct LHKHMIMELJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public int IBKMMCAIMDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public int CIBDPHPBEOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public int CNEGHMIDOPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int OONFEMGDMGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public float LHLLGHOJLDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public float BOCBALLKLFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public float LONAEJDDHKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public float MKAILMMLKFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public float EDIBCFBIKBG;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public struct LKJIKOHDGGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public int BPKJCJEMFPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public int BLCKMFKEBOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public float CHBJGNNOCPH;
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public delegate void GCBHHJOMFMA(CEPJAPBOOFF PFMBOFFEKHL, [In] CNCBLOPFLAB IMDBABKBLCC);

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	internal static class KHKGJKHBCBI
	{
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x7C0CAA0", Offset = "0x7C0B2A0", VA = "0x187C0CAA0")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x7C0C950", Offset = "0x7C0B150", VA = "0x187C0C950")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x7C0CDA0", Offset = "0x7C0B5A0", VA = "0x187C0CDA0")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x7C0CBC0", Offset = "0x7C0B3C0", VA = "0x187C0CBC0")]
		public static void GINPGABDCGP(CEPJAPBOOFF PFMBOFFEKHL, [In] CNCBLOPFLAB IMDBABKBLCC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public delegate void DKOGKIHBLFG(CEPJAPBOOFF PFMBOFFEKHL, [In] LHKHMIMELJM KJNNPLOPMBB);

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	internal static class DPCEPNJGCJK
	{
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7C05380", Offset = "0x7C03B80", VA = "0x187C05380")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7C05230", Offset = "0x7C03A30", VA = "0x187C05230")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x7C05680", Offset = "0x7C03E80", VA = "0x187C05680")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7C054A0", Offset = "0x7C03CA0", VA = "0x187C054A0")]
		public static void GINPGABDCGP(CEPJAPBOOFF PFMBOFFEKHL, [In] LHKHMIMELJM KJNNPLOPMBB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public unsafe delegate void ICIECCBJMND(UnsafeList<int>* PHDLEOJNIKK, UnsafeList<float3>* IIDAHHEIMPN, [NoAlias] float3* CLENPOMPLHP, [NoAlias] float4* GPGLBGCFALN, [NoAlias] float2* PHOKGAEBPAE, [NoAlias] float4* GNCEKNKEAEM, UnsafeList<OHHCNHAKJIC>* ABEGKJCHJNO, UnsafeList<int>* IPNJCBMILFG, UnsafeList<float3>* NIMMHEBKLJD, [NoAlias] float3* ICKOCCBGIHG, [NoAlias] float4* NLOPPPKOINJ, [NoAlias] float2* FKEFDANLJEI, [NoAlias] float4* EJDACNCIBIP, int HFGIBGEKDDK, int JCDJHOHOPJC);

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	internal static class CPCIFIGLKPH
	{
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7C04D40", Offset = "0x7C03540", VA = "0x187C04D40")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x7C04BF0", Offset = "0x7C033F0", VA = "0x187C04BF0")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x7C05190", Offset = "0x7C03990", VA = "0x187C05190")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x7C04E60", Offset = "0x7C03660", VA = "0x187C04E60")]
		public unsafe static void GINPGABDCGP(UnsafeList<int>* PHDLEOJNIKK, UnsafeList<float3>* IIDAHHEIMPN, [NoAlias] float3* CLENPOMPLHP, [NoAlias] float4* GPGLBGCFALN, [NoAlias] float2* PHOKGAEBPAE, [NoAlias] float4* GNCEKNKEAEM, UnsafeList<OHHCNHAKJIC>* ABEGKJCHJNO, UnsafeList<int>* IPNJCBMILFG, UnsafeList<float3>* NIMMHEBKLJD, [NoAlias] float3* ICKOCCBGIHG, [NoAlias] float4* NLOPPPKOINJ, [NoAlias] float2* FKEFDANLJEI, [NoAlias] float4* EJDACNCIBIP, int HFGIBGEKDDK, int JCDJHOHOPJC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public float3 IIOOGOGENHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public float ACMGHEFJECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public float NDOAGCBPPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public float NCHMPGBPFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public LDJCMFGIOBD.NGBFHHNGGGF LPMOFMKGMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public bool FABJADIALEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<OHHCNHAKJIC>* ABEGKJCHJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<int>* IPNJCBMILFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<CNCBLOPFLAB>* ALEFOGJMGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<CNCBLOPFLAB>* PFNPINBMOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<LHKHMIMELJM>* GLJCBMGEKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<LHKHMIMELJM>* KOCPOEGLNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public int AGAHPHKJGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public int BPFDHKFGMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public int OPPAFMGKAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	[NoAlias]
	[NativeDisableUnsafePtrRestriction]
	public unsafe float3* NIMMHEBKLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	[NativeDisableUnsafePtrRestriction]
	[NoAlias]
	public unsafe int* MPDLAPPHPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	[NoAlias]
	[NativeDisableUnsafePtrRestriction]
	public unsafe LKJIKOHDGGP* FNEFJGHGJFO;

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x7BE68C0", Offset = "0x7BE50C0", VA = "0x187BE68C0")]
	private static float LPIEGBGFBNJ([In] CEPJAPBOOFF PFMBOFFEKHL, [In] float3 NNIAAFBAFDF, float EDIBCFBIKBG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x7BE4990", Offset = "0x7BE3190", VA = "0x187BE4990")]
	private static int DBKJOPABDFI(CEPJAPBOOFF PFMBOFFEKHL, [Out] OHHCNHAKJIC GBNBJMIKMJH, [In] OHHCNHAKJIC JMIOMKEPEDB, [In] OHHCNHAKJIC BDILFLDAIPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5330", Offset = "0x7BE3B30", VA = "0x187BE5330")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private static void FGBICMKHMBB(CEPJAPBOOFF PFMBOFFEKHL, [In] CNCBLOPFLAB IMDBABKBLCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5B30", Offset = "0x7BE4330", VA = "0x187BE5B30")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private static void KJEKMDEPCBJ(CEPJAPBOOFF PFMBOFFEKHL, [In] LHKHMIMELJM KJNNPLOPMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x7BE4B10", Offset = "0x7BE3310", VA = "0x187BE4B10", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5B90", Offset = "0x7BE4390", VA = "0x187BE5B90")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	internal void KJGGOAHCPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5AA0", Offset = "0x7BE42A0", VA = "0x187BE5AA0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	internal unsafe static void HOPLLAECLND(UnsafeList<int>* PHDLEOJNIKK, UnsafeList<float3>* IIDAHHEIMPN, [NoAlias] float3* CLENPOMPLHP, [NoAlias] float4* GPGLBGCFALN, [NoAlias] float2* PHOKGAEBPAE, [NoAlias] float4* GNCEKNKEAEM, UnsafeList<OHHCNHAKJIC>* ABEGKJCHJNO, UnsafeList<int>* IPNJCBMILFG, UnsafeList<float3>* NIMMHEBKLJD, [NoAlias] float3* ICKOCCBGIHG, [NoAlias] float4* NLOPPPKOINJ, [NoAlias] float2* FKEFDANLJEI, [NoAlias] float4* EJDACNCIBIP, int HFGIBGEKDDK, int JCDJHOHOPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x7BE3FF0", Offset = "0x7BE27F0", VA = "0x187BE3FF0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public static void BMCDPAGHENP(CEPJAPBOOFF PFMBOFFEKHL, [In] CNCBLOPFLAB IMDBABKBLCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x7BE4B20", Offset = "0x7BE3320", VA = "0x187BE4B20")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public static void FDDKBGAFBOL(CEPJAPBOOFF PFMBOFFEKHL, [In] LHKHMIMELJM KJNNPLOPMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5390", Offset = "0x7BE3B90", VA = "0x187BE5390")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public unsafe static void HGJCJLFBAMH(UnsafeList<int>* PHDLEOJNIKK, UnsafeList<float3>* IIDAHHEIMPN, [NoAlias] float3* CLENPOMPLHP, [NoAlias] float4* GPGLBGCFALN, [NoAlias] float2* PHOKGAEBPAE, [NoAlias] float4* GNCEKNKEAEM, UnsafeList<OHHCNHAKJIC>* ABEGKJCHJNO, UnsafeList<int>* IPNJCBMILFG, UnsafeList<float3>* NIMMHEBKLJD, [NoAlias] float3* ICKOCCBGIHG, [NoAlias] float4* NLOPPPKOINJ, [NoAlias] float2* FKEFDANLJEI, [NoAlias] float4* EJDACNCIBIP, int HFGIBGEKDDK, int JCDJHOHOPJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class PLFNJBAAGCP
{
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private static readonly ProfilerMarker LOPHGJJNAFJ;

	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	public const int MJPFHCPLCPA = 2;

	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private const int CEPDMHHMNAI = 1;

	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private static int GOLFLNJEBFE;

	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private static Stack<PLFNJBAAGCP> MPAGHEOJPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private PKKNLFDDHKF LPBOMFBPELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private NativeList<OHHCNHAKJIC> ABEGKJCHJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	private NativeList<int> IPNJCBMILFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	private NativeList<CEPJAPBOOFF.CNCBLOPFLAB> ALEFOGJMGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	private NativeList<CEPJAPBOOFF.CNCBLOPFLAB> PFNPINBMOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private NativeList<CEPJAPBOOFF.LHKHMIMELJM> GLJCBMGEKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	private NativeList<CEPJAPBOOFF.LHKHMIMELJM> KOCPOEGLNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	private CEPJAPBOOFF PFMBOFFEKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	private JobHandle OHHKLKBFKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private CEPJAPBOOFF.LKJIKOHDGGP GKCJDNAIKGG;

	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private const int OPPAFMGKAPD = 65530;

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x7C0F910", Offset = "0x7C0E110", VA = "0x187C0F910")]
	private PLFNJBAAGCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x7C0EC10", Offset = "0x7C0D410", VA = "0x187C0EC10")]
	public void IFCEGIODCPD(PKKNLFDDHKF IJHEBEALDEF, float3 ACHJNCFHEPG, float FELCJBMKDNA, float IDNFNDDNELL, float BCPKMGPNFFI, List<DOPJHPLPMNH.GAOGLDLCJKM> GLJPAPDPFPL, Allocator IGFFJEGANLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x7C0F0A0", Offset = "0x7C0D8A0", VA = "0x187C0F0A0")]
	public (bool, PKKNLFDDHKF, float) KOKJLBEDDKG(List<DOPJHPLPMNH.GAOGLDLCJKM> GLJPAPDPFPL, Allocator IGFFJEGANLL, bool BGFCEOJPJLG)
	{
		return default((bool, PKKNLFDDHKF, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x7C0F050", Offset = "0x7C0D850", VA = "0x187C0F050")]
	public static bool KDHHILDPIIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E810", Offset = "0x7C0D010", VA = "0x187C0E810")]
	public static int ALJAOLHNFAF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x7C0F6D0", Offset = "0x7C0DED0", VA = "0x187C0F6D0")]
	public static PLFNJBAAGCP LLGHECGKMLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E9E0", Offset = "0x7C0D1E0", VA = "0x187C0E9E0")]
	internal static void DGOMJDFAPBM(PLFNJBAAGCP NCIOLCDBIGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E880", Offset = "0x7C0D080", VA = "0x187C0E880")]
	public static void BEPEILGCDDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x7C0EA70", Offset = "0x7C0D270", VA = "0x187C0EA70")]
	[BOGLAMPKNMP(EGMDMPGLLBP.ExitingPlayMode, 0)]
	public static void FBJANABPJBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[BurstCompile]
internal struct OHHCNHAKJIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public float3 NANJGAHEDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public int KFMJGLIKBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	public int OKDEPDFCEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	public int EBDGNPKBCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	public float DGFGFPOFBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	public float DMLHNFBEAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	public int JCPGJOAGLEH;

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x7C0D160", Offset = "0x7C0B960", VA = "0x187C0D160")]
	public static void NKIHIDGHACP([Out] OHHCNHAKJIC HLPIAOANGMD, int CGDGHLFGBNO, [In] float3 KFCJMDEODJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x7C0CE70", Offset = "0x7C0B670", VA = "0x187C0CE70")]
	[IgnoreWarning(1371)]
	public static void NKIHIDGHACP([Out] OHHCNHAKJIC HLPIAOANGMD, [In] OHHCNHAKJIC HLKKJFHDJAB, [In] OHHCNHAKJIC KLHONOJLOLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[BurstCompile]
internal struct HDNPPECAKKJ : IJob
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private struct EGPNEJGDBII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public int EPDCKEGJKAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public int HDAJPPHODIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public int BFAONGFHFEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public int IGGELNMJHJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public int JNAFKBKLFDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public int HHFPOJBGPPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public int JFFHJANBLGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public int BBDODJJOPAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public float NCFBBNIIKFE;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private struct EHMLALNPGBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public LDJCMFGIOBD.MFEKICOIPOP ABOHDDAIPOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public float DHHAFCJCAAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public float HJALGEPJNKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public float JBOBNNCMBAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public float JFNKEIOOCID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public float KFLOEFLHHLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public float LHFLGNBNHEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public float CPDBOLOLFIF;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	private struct PKAFLICPNDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public NativeArray<float3> KFFLNGKEBLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public NativeArray<float3> BOIAIJHJDDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public NativeArray<float4> FDFGDLFCJHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public NativeArray<float4> MMBNDMCBFIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public NativeArray<float2> MHJBKADOJDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public NativeArray<int> COCKEFNFHKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public bool MJICMJNJLPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public int ADDMENBCPDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public int EEBNJGNDFLH;

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x7C0E320", Offset = "0x7C0CB20", VA = "0x187C0E320")]
		public void JDJGCBPDGJD(int JCDJHOHOPJC, int HFGIBGEKDDK, Allocator KKCJNCNIICO, bool CEAMFOHPAPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x7C0E500", Offset = "0x7C0CD00", VA = "0x187C0E500")]
		public static PKAFLICPNDN LKCEHHPNCBG(PKKNLFDDHKF GGBFBJAOFOK)
		{
			return default(PKAFLICPNDN);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x7C0E750", Offset = "0x7C0CF50", VA = "0x187C0E750")]
		public void OCOBEACFBKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	private static readonly ProfilerMarker OMFEAMGOIAF;

	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	private static readonly ProfilerMarker IJBJDHHCENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	private NativeArray<EGPNEJGDBII> PGEAJDADHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	private PKAFLICPNDN JLKDCIGICOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	private PKAFLICPNDN PNFIDOHLINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private float3 KMAKKBGLJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	private float3 OLFBEFCIPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	private EHMLALNPGBJ LKLKOCEPIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* HAJFNFEJBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private NativeArray<DOPJHPLPMNH.GAOGLDLCJKM> EPDALMCHAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private NativeList<DOPJHPLPMNH.GAOGLDLCJKM> JPJKLMLKCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private NativeArray<int> IPNJCBMILFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private NativeArray<bool> IFGGDLICFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private NativeArray<int> BNEIGNIGAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private NativeArray<int> ANNKMFMKBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	private NativeArray<float> OJEEDIFFCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	private NativeArray<int> FNHBMIDNBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	private NativeArray<float> PFHDBJKFCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	private NativeArray<int> EOJHJAKILAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	private NativeArray<int> PFKIHPFLOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	private NativeArray<float> IAODENEALEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private NativeArray<float> DBCFPAHGENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private NativeArray<int> DPGLBOEBJAB;

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x7C0BEC0", Offset = "0x7C0A6C0", VA = "0x187C0BEC0")]
	public HDNPPECAKKJ([In] List<DOPJHPLPMNH.KJLFIHOGLBL> GMILBAEGHOK, NativeList<DOPJHPLPMNH.GAOGLDLCJKM> KLJPFGCGADC, [In] PKKNLFDDHKF BIDCKIOPOOG, [In] NativeList<DOPJHPLPMNH.GAOGLDLCJKM> OBMIONMHDLF, [In] NativeArray<long> MFBHDNMHDON, float3 NPLCOOJJHFG, float3 GHAGEPBLABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x7C0B8B0", Offset = "0x7C0A0B0", VA = "0x187C0B8B0")]
	public static long IIFCNOFIPBE(int JCDJHOHOPJC, int HFGIBGEKDDK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C09F20", Offset = "0x7C08720", VA = "0x187C09F20", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x7C09420", Offset = "0x7C07C20", VA = "0x187C09420")]
	public void EPLCNIKLBAD(List<DOPJHPLPMNH.KJLFIHOGLBL> OBHNEFKBDKM, [In] DOPJHPLPMNH HDAKBEDCACJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x7C0B6B0", Offset = "0x7C09EB0", VA = "0x187C0B6B0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool GPDEGMHHIDN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x7C0B8D0", Offset = "0x7C0A0D0", VA = "0x187C0B8D0")]
	private IHLJGJEJFHB JGPHECBDFGP(int KIDCAHDEIJO, Allocator KKCJNCNIICO)
	{
		return default(IHLJGJEJFHB);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x7C09F70", Offset = "0x7C08770", VA = "0x187C09F70")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private void GDCKKBNAICC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x7C08DB0", Offset = "0x7C075B0", VA = "0x187C08DB0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private float BHBGODCOMIB(int IBHGELOFIFF, int IKJKMBHEPIP, bool PCMLIIBBIKI, bool KIOCDBBDANO, float IMPNFLLDMMB, float EPCEPMJOCFF, float NDIMIMDDOAA, float PAAHBNEHHLA, float IGAOKNGHOPF, float NMDKEMIIDCI, float BPAODPPJDIJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x7C0BB00", Offset = "0x7C0A300", VA = "0x187C0BB00")]
	[IgnoreWarning(1371)]
	private EGPNEJGDBII MCEMKMKMOHG([In] EGPNEJGDBII HLNHMKMOJGO, int LJGKCOMDNDO, [In] NativeArray<int> NKDBAHNOGCM, [In] NativeArray<bool> IFGGDLICFFJ, NativeArray<int> BNEIGNIGAKO)
	{
		return default(EGPNEJGDBII);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x7C0B6D0", Offset = "0x7C09ED0", VA = "0x187C0B6D0")]
	public static int HAJDBMOJAHP(NativeArray<int> NKDBAHNOGCM, NativeArray<int> DPGLBOEBJAB, int FGNFHMILKEH, int IKFAMAJBJOI, int CDBMKCDPJKA)
	{
		return default(int);
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public class BatchedMeshRenderer : MonoBehaviour, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000BA")]
		private struct MGMIMDHIOBG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031B")]
			public long JJFBACBKKBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400031C")]
			public EMKIDKCECNG KBODAPIGKJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400031D")]
			public PPIHHPOBLHH ABAPBBKNPBC;

			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x7C0CE40", Offset = "0x7C0B640", VA = "0x187C0CE40")]
			public MGMIMDHIOBG(EMKIDKCECNG JGKKDKONAGF, PPIHHPOBLHH IGBILGHCCEG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		private class PNKIFGIGOAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400031E")]
			public EMKIDKCECNG KBODAPIGKJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			public int PKBFIOIHAOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			public float NCOIGGEELMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			public List<MGMIMDHIOBG> EPEHJJONMPA;

			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x7C0FAB0", Offset = "0x7C0E2B0", VA = "0x187C0FAB0")]
			public PNKIFGIGOAC(EMKIDKCECNG JGKKDKONAGF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public static bool OpenGLSRPBatchSupport;

		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public static readonly LLPKKNNAIAE log;

		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private static readonly ProfilerMarker HFGNBBFPKEE;

		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private static readonly ProfilerMarker KOINJMPOCIG;

		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private static readonly ProfilerMarker KMPFLLOPLED;

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private static readonly ProfilerMarker BOLIPAJFPEK;

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private static readonly ProfilerMarker INEHBIMDMJE;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private static readonly ProfilerMarker KAICLKLECGP;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private static readonly ProfilerMarker PGEJEMGGIJG;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		internal const int GPPFKJGKEPL = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		internal static Dictionary<Material, List<Material>> CNBFFHLAIDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private Dictionary<Material, List<KGDMJFAMKAM>> NGLIJILMBIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		internal List<KGDMJFAMKAM> FJMDAMIAPLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private List<MeshRenderer> IBNFBNAEPMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private Transform KACHHHIDHKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private bool HCACJODEHND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private bool DKHNPBBOOKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private int OCCKFPGGBMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private KGDMJFAMKAM NEIFPHAIKPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private Material PELNLLBFPHH;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public static bool enableSRPBatcher;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private static bool? AKJFAAJJAGG;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private const int KCJDAAMGLKI = 1024;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private static List<MGMIMDHIOBG> LAKGIINPLKK;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public IReadOnlyList<MeshRenderer> MDAHNMCMEPB
		{
			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int AGMABOGPNHN
		{
			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x7C041D0", Offset = "0x7C029D0", VA = "0x187C041D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private static bool LBFMPEELLDD
		{
			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x7BFDE50", Offset = "0x7BFC650", VA = "0x187BFDE50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		private static void OFMJBIHCGJJ(bool OGDDJEDBANI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		private static void OFMJBIHCGJJ(bool OGDDJEDBANI, string NJAAPDELBNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		private static void MEMGBJLANEP(string GLGOHIJMLFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x7BFDE20", Offset = "0x7BFC620", VA = "0x187BFDE20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x7C00B50", Offset = "0x7BFF350", VA = "0x187C00B50")]
		internal bool OBANJGKBNNI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x7BFF380", Offset = "0x7BFDB80", VA = "0x187BFF380")]
		private Transform HDBPHBLGKHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x7C00C30", Offset = "0x7BFF430", VA = "0x187C00C30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7BFE1D0", Offset = "0x7BFC9D0", VA = "0x187BFE1D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x7BFDC10", Offset = "0x7BFC410", VA = "0x187BFDC10")]
		public KGDMJFAMKAM AddToBatchedMesh(PPIHHPOBLHH GPPAGJDFAFP, Material OALKCGACMLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x7C03CB0", Offset = "0x7C024B0", VA = "0x187C03CB0")]
		public void RemoveFromBatchedMesh(PPIHHPOBLHH ABAPBBKNPBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7BFE0A0", Offset = "0x7BFC8A0", VA = "0x187BFE0A0")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x7C00BB0", Offset = "0x7BFF3B0", VA = "0x187C00BB0")]
		private void OJOILEPGHNJ(Renderer JGPHFKDOCBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x7BFFC60", Offset = "0x7BFE460", VA = "0x187BFFC60")]
		public void ImmediateUpdateBatchedMeshOnGpuIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7BFFC50", Offset = "0x7BFE450", VA = "0x187BFFC50")]
		public void ImmediateUpdateBatchedMeshOnGpuEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7BFE5E0", Offset = "0x7BFCDE0", VA = "0x187BFE5E0")]
		private void FCGPHEEGEMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x7C000C0", Offset = "0x7BFE8C0", VA = "0x187C000C0")]
		public void MarkTemporarilyFrozen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x7BFFCD0", Offset = "0x7BFE4D0", VA = "0x187BFFCD0")]
		private KGDMJFAMKAM JCFKJFOOMCP(PPIHHPOBLHH ABAPBBKNPBC, Material OALKCGACMLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7C00650", Offset = "0x7BFEE50", VA = "0x187C00650")]
		private KGDMJFAMKAM NHIDDEILFBD(Material OALKCGACMLD, int FJODHPGEAPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7BFF400", Offset = "0x7BFDC00", VA = "0x187BFF400")]
		private KGDMJFAMKAM IOPJMALDAFJ(Material OALKCGACMLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7C00AB0", Offset = "0x7BFF2B0", VA = "0x187C00AB0")]
		internal float4x4 NMCNFDDOAPI()
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x7BFEBA0", Offset = "0x7BFD3A0", VA = "0x187BFEBA0")]
		public static List<Material> GenerateVertexFormatVariants(Material OALKCGACMLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x12D7F90", Offset = "0x12D6790", VA = "0x1812D7F90")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x7BFFF60", Offset = "0x7BFE760", VA = "0x187BFFF60")]
		public void MarkDirty(PPIHHPOBLHH ABAPBBKNPBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x7C009B0", Offset = "0x7BFF1B0", VA = "0x187C009B0")]
		[Conditional("CHECK_STATE")]
		private void NJEGFMKNEMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x7C00240", Offset = "0x7BFEA40", VA = "0x187C00240")]
		public (long, long, int) MemoryTrianglesForChosenDetail(float CIKGJHMEANL)
		{
			return default((long, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x7BFDF70", Offset = "0x7BFC770", VA = "0x187BFDF70")]
		[Conditional("CHECK_STATE")]
		public void CheckStateParanoid()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x7C02B50", Offset = "0x7C01350", VA = "0x187C02B50")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x7BFECC0", Offset = "0x7BFD4C0", VA = "0x187BFECC0")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7C00D10", Offset = "0x7BFF510", VA = "0x187C00D10")]
		public void RebatchOptimally(int FHBNLEHKKOB, int CINGAACNLAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x7C00C40", Offset = "0x7BFF440", VA = "0x187C00C40")]
		public static void RebatchOptimallyCacheClear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x7C040A0", Offset = "0x7C028A0", VA = "0x187C040A0")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public static class EDFHCINEKLI
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	private struct BMKCIHHDHFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public BatchedMeshRenderer JGPHFKDOCBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public KGDMJFAMKAM ABAPBBKNPBC;

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x19A52D0", Offset = "0x19A3AD0", VA = "0x1819A52D0")]
		public void NMHNCJGDKMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private struct GGDFGDIDFPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public float HBOBLKDPOOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public KGDMJFAMKAM ABBBCLLCCNA;
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class OODIDGBBHHH : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private bool <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private long totalAvailableBytesForScalability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public long <>3__totalAvailableBytesForScalability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private bool forceMeshCreationImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public bool <>3__forceMeshCreationImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private int <batchesPerYield>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private int <countdownBeforeYield>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private int <batchSizeNaughty>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private int <batchSizeNice>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private List<BatchedMeshRenderer>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool IEnumerator<bool>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x110C0D0", Offset = "0x110A8D0", VA = "0x18110C0D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x7C0E1B0", Offset = "0x7C0C9B0", VA = "0x187C0E1B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x1255610", Offset = "0x1253E10", VA = "0x181255610")]
		[DebuggerHidden]
		public OODIDGBBHHH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7C0E200", Offset = "0x7C0CA00", VA = "0x187C0E200", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x7C0D250", Offset = "0x7C0BA50", VA = "0x187C0D250", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x7C0D1B0", Offset = "0x7C0B9B0", VA = "0x187C0D1B0")]
		private void JCGGFCDKBHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x7C0D200", Offset = "0x7C0BA00", VA = "0x187C0D200")]
		private void LGFFOGMDBCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x7C0E160", Offset = "0x7C0C960", VA = "0x187C0E160", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x7C0E0B0", Offset = "0x7C0C8B0", VA = "0x187C0E0B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x7C0E0B0", Offset = "0x7C0C8B0", VA = "0x187C0E0B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000324")]
	public static readonly LLPKKNNAIAE NOMHFHBJHNN;

	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private static readonly ProfilerMarker KAICLKLECGP;

	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private static readonly ProfilerMarker CPDDIMOJBNA;

	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private static readonly ProfilerMarker DBMEJPNDOHG;

	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private static readonly ProfilerMarker OCMCFFINJOI;

	[Cpp2IlInjected.Token(Token = "0x4000329")]
	public static float3 PDJKPOAAIEP;

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	public static int HKNBACHPMKG;

	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public static int KLBMBOLIEBI;

	[Cpp2IlInjected.Token(Token = "0x400032C")]
	public static int INIGHNPCANG;

	[Cpp2IlInjected.Token(Token = "0x400032D")]
	public static int APGJOHMJFKE;

	[Cpp2IlInjected.Token(Token = "0x400032E")]
	public static int LGKFPLDFLFA;

	[Cpp2IlInjected.Token(Token = "0x400032F")]
	public static float GPONBKKOOLM;

	[Cpp2IlInjected.Token(Token = "0x4000330")]
	public static float DHENBPNIPPB;

	[Cpp2IlInjected.Token(Token = "0x4000331")]
	public static float HGJKMPDJINP;

	[Cpp2IlInjected.Token(Token = "0x4000332")]
	public static float GFODHMDGOKA;

	[Cpp2IlInjected.Token(Token = "0x4000333")]
	public static float JDJIJPMGJCA;

	[Cpp2IlInjected.Token(Token = "0x4000334")]
	public static float PHHKLAHFNNI;

	[Cpp2IlInjected.Token(Token = "0x4000335")]
	public static float LKNGJDFMPKG;

	[Cpp2IlInjected.Token(Token = "0x4000336")]
	public static float OCGNHKNLNAL;

	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private static List<BatchedMeshRenderer> CCLFFANDFAB;

	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private static Stack<PKKNLFDDHKF> MODOBBGLLOO;

	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private static Stack<PDCIDHGFBFE> ENHCPOOIDBJ;

	[Cpp2IlInjected.Token(Token = "0x400033A")]
	public static OJMGMPCIMIF MGOIJMAMEFL;

	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private static BMKCIHHDHFG MIGMJKFPAIH;

	[Cpp2IlInjected.Token(Token = "0x400033C")]
	public static int IMFGNEHHCII;

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
	private static void OFMJBIHCGJJ(bool OGDDJEDBANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
	private static void DPKPHJOJLNK(bool OGDDJEDBANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
	private static void OFMJBIHCGJJ(bool OGDDJEDBANI, string NJAAPDELBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x7C06F80", Offset = "0x7C05780", VA = "0x187C06F80")]
	public static void ILJHHMHPGDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x7C06980", Offset = "0x7C05180", VA = "0x187C06980")]
	public static void HDOIHOMAFBE(BatchedMeshRenderer MCJFFAMPDAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x7C081F0", Offset = "0x7C069F0", VA = "0x187C081F0")]
	public static void MBBKODFJIGK(BatchedMeshRenderer MCJFFAMPDAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x7C079A0", Offset = "0x7C061A0", VA = "0x187C079A0")]
	public static void KNAGNCIABJB(PPIHHPOBLHH ILIHIOEKKHL, bool DIDAGMGIAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x7C05720", Offset = "0x7C03F20", VA = "0x187C05720")]
	public static void AFCHOMCMJHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x7C05F40", Offset = "0x7C04740", VA = "0x187C05F40")]
	public static void BLMKNIBNIDH(float CIKGJHMEANL, bool ABEMGCLMCCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x7C08520", Offset = "0x7C06D20", VA = "0x187C08520")]
	private static void PENODACDMFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x7C07000", Offset = "0x7C05800", VA = "0x187C07000")]
	public static long JHOGLJNLPOF(int EMBCDHBDDAB, long MLAFIFDIEPA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x7C08310", Offset = "0x7C06B10", VA = "0x187C08310")]
	public static (long, long, int) MIJKHAHMDDJ(float CIKGJHMEANL)
	{
		return default((long, long, int));
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x7C06D70", Offset = "0x7C05570", VA = "0x187C06D70")]
	[IteratorStateMachine(typeof(OODIDGBBHHH))]
	public static IEnumerable<bool> HMLIAPNANGH(long BMLAKGKCPJB, bool FEANOGOADEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C05AA0", Offset = "0x7C042A0", VA = "0x187C05AA0")]
	public static void AGDOCNAAOEP(long BMLAKGKCPJB, bool FEANOGOADEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C00", Offset = "0x7C05400", VA = "0x187C06C00")]
	public static int HHFAPGIFLPC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x7C06E00", Offset = "0x7C05600", VA = "0x187C06E00")]
	internal static PKKNLFDDHKF IDPNDEFAHNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x7C06850", Offset = "0x7C05050", VA = "0x187C06850")]
	internal static void DGOMJDFAPBM(PKKNLFDDHKF OAFNJPDHGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x7C06AC0", Offset = "0x7C052C0", VA = "0x187C06AC0")]
	internal static PDCIDHGFBFE HHCHMOPGJKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x7C068F0", Offset = "0x7C050F0", VA = "0x187C068F0")]
	internal static void DGOMJDFAPBM(PDCIDHGFBFE EONOKBFIFOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x7C05D80", Offset = "0x7C04580", VA = "0x187C05D80")]
	public static void BEPEILGCDDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public class PLJPDLJPLMM<KeyType> : KGDMJFAMKAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private readonly Dictionary<KeyType, PPIHHPOBLHH> KEMKJHFPNHM;

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x5577300", Offset = "0x5575B00", VA = "0x185577300")]
	public PLJPDLJPLMM(string GLGOHIJMLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x5576DB0", Offset = "0x55755B0", VA = "0x185576DB0")]
	public void DMAPEONODMJ(KeyType BELIEAFHDAH, PPIHHPOBLHH ILIHIOEKKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x5577110", Offset = "0x5575910", VA = "0x185577110")]
	public bool POOPKPPALIL(KeyType BELIEAFHDAH, PPIHHPOBLHH KBKFMIFBBKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x5576E20", Offset = "0x5575620", VA = "0x185576E20")]
	public void IAFFJDCHJNK(KeyType BELIEAFHDAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x5576FC0", Offset = "0x55757C0", VA = "0x185576FC0", Slot = "4")]
	public override void KAENDCOHEFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public static class CICIDAKEOOK
{
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public static readonly ProfilerCategory CMHDDKEHIEM;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	internal static readonly ProfilerMarker PNFAINOLMHK;

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	internal static readonly CPOEGNJJJHD BLMKNIBNIDH;

	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private static readonly PIMKBFCBEBC<float> IAKIOBOKIKA;

	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private static readonly PIMKBFCBEBC<float> PCJMAHCHBFI;

	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private static readonly PIMKBFCBEBC<double> KIBDKFJNEDL;

	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private static readonly PIMKBFCBEBC<double> EPNLBEBCMNH;

	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private static readonly PIMKBFCBEBC<double> HEPFBEOEAJF;

	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private static readonly PIMKBFCBEBC<int> GLLKDEELAOB;

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private static readonly PIMKBFCBEBC<int> BBAPJMHJNAP;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private static readonly PIMKBFCBEBC<int> MHHPABFIHNH;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private static readonly PIMKBFCBEBC<int> KOFDLGMGLIA;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	private static readonly PIMKBFCBEBC<int> PJNONIEDKDJ;

	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private static readonly PIMKBFCBEBC<long> FGDMGEIBLOP;

	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private static readonly PIMKBFCBEBC<long> PFADEKGJDCC;

	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private static readonly PIMKBFCBEBC<long> OJDGMMLMNEP;

	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private static readonly PIMKBFCBEBC<long> LINBICOFMBG;

	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private static readonly PIMKBFCBEBC<long> IELCNPJHPEL;

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x7C04220", Offset = "0x7C02A20", VA = "0x187C04220")]
	public static void GGKEEDHMBMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x7C0FB60", Offset = "0x7C0E360", VA = "0x187C0FB60")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize()
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
