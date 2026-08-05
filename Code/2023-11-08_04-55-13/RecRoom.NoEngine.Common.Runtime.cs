using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5E69EF0", Offset = "0x5E68CF0", VA = "0x185E69EF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x799B60", Offset = "0x798960", VA = "0x180799B60")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x799BA0", Offset = "0x7989A0", VA = "0x180799BA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class LIBOMGMFGCD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E678A0", Offset = "0x5E666A0", VA = "0x185E678A0")]
	public LIBOMGMFGCD(bool ANIBCIAOGKP, string KINPJKOKLLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KJPGMOBPLDA<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate Task<TResult> CKEOFELNLPH(CancellationToken ELPOPHCEGNN);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct NDPNDNBKDJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public KJPGMOBPLDA<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CKEOFELNLPH taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskCompletionSource<TResult> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private CancellationTokenSource <runningCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3D08B60", Offset = "0x3D07960", VA = "0x183D08B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3D09BC0", Offset = "0x3D089C0", VA = "0x183D09BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CancellationTokenSource MHPFKGBLOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CancellationTokenSource? AKLJMFGHEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private TaskCompletionSource<TResult>? PIEHMMABIEI;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3A3E830", Offset = "0x3A3D630", VA = "0x183A3E830")]
	[AsyncStateMachine(typeof(KJPGMOBPLDA<>.NDPNDNBKDJP))]
	public Task<TResult> CACNMBKEFBF(CKEOFELNLPH IIMIAFCMFOB, [Optional] CancellationToken ELPOPHCEGNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3A3E970", Offset = "0x3A3D770", VA = "0x183A3E970", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3A3E9E0", Offset = "0x3A3D7E0", VA = "0x183A3E9E0")]
	public KJPGMOBPLDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class PFNODEBDPPM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly EqualityComparer<T> KIMEODJDCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public T DHGNDNJJJIH;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3AA31F0", Offset = "0x3AA1FF0", VA = "0x183AA31F0")]
	public PFNODEBDPPM([In] T PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3EE2650", Offset = "0x3EE1450", VA = "0x183EE2650", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3EE2A00", Offset = "0x3EE1800", VA = "0x183EE2A00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3EE2B50", Offset = "0x3EE1950", VA = "0x183EE2B50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class EELCBBGDBEB
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E66180", Offset = "0x5E64F80", VA = "0x185E66180")]
	public static void FGFDBBIKMFH(this CancellationTokenSource MHPFKGBLOGM, bool BAMKDGAFGON = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class HJOACPGEJDF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
	public HJOACPGEJDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class JGLJCKHOFCF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
	public JGLJCKHOFCF(string LLJLJEEAFKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Parameter)]
public class BKDBJMNHKAC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
	public BKDBJMNHKAC(string LLJLJEEAFKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class CJOFHIJFKBH
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x23177B0", Offset = "0x23165B0", VA = "0x1823177B0")]
	public static BABFNHJHLKP NJFOEIPBLBE<T>()
	{
		return default(BABFNHJHLKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2317620", Offset = "0x2316420", VA = "0x182317620")]
	public static BABFNHJHLKP IJOPHDGGJNH<T>([CallerMemberName] string NDLLBBKGIJD = "") where T : notnull
	{
		return default(BABFNHJHLKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2317830", Offset = "0x2316630", VA = "0x182317830")]
	public static BABFNHJHLKP NJFOEIPBLBE<T>(this T ANLNKNAJGIA) where T : notnull
	{
		return default(BABFNHJHLKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2317400", Offset = "0x2316200", VA = "0x182317400")]
	public static BABFNHJHLKP DGDHEHNLNMD<T>(this T ANLNKNAJGIA, [CallerMemberName] string NDLLBBKGIJD = "") where T : notnull
	{
		return default(BABFNHJHLKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2317580", Offset = "0x2316380", VA = "0x182317580")]
	public static BABFNHJHLKP IJOPHDGGJNH<T>(this T HLCOOGAGOEK, [CallerMemberName] string NDLLBBKGIJD = "") where T : notnull
	{
		return default(BABFNHJHLKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E634A0", Offset = "0x5E622A0", VA = "0x185E634A0")]
	public static BABFNHJHLKP IJOPHDGGJNH(string CHPLDBOKOFB, [CallerMemberName] string NDLLBBKGIJD = "")
	{
		return default(BABFNHJHLKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E63520", Offset = "0x5E62320", VA = "0x185E63520")]
	public static string MBGBJFFNMAO(this object HLCOOGAGOEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[HJOACPGEJDF]
public delegate long GBOCOMCHHHL();
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PKAHCMIPBPG
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static OHKBEFFEANJ DDECGNCKBGK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static OHKBEFFEANJ NBMJPPDMLPP
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C230", Offset = "0x5E6B030", VA = "0x185E6C230")]
		get
		{
			return default(OHKBEFFEANJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static NIOCDPPHCNG ENMJJJFMAFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C1E0", Offset = "0x5E6AFE0", VA = "0x185E6C1E0")]
		get
		{
			return default(NIOCDPPHCNG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static MOLNBMFLEJJ AFGOKDLHHJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5E6BE70", Offset = "0x5E6AC70", VA = "0x185E6BE70")]
		get
		{
			return default(MOLNBMFLEJJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BAB0", Offset = "0x5E6A8B0", VA = "0x185E6BAB0")]
	public static void AAJMOJEAIEH([In] OHKBEFFEANJ KEGPEFNICID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BCD0", Offset = "0x5E6AAD0", VA = "0x185E6BCD0")]
	public static void CLFELIEFDPO(string KHIFMDJDLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C110", Offset = "0x5E6AF10", VA = "0x185E6C110")]
	public static void MBLBKGHLOBI(string KHIFMDJDLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2646CE0", Offset = "0x2645AE0", VA = "0x182646CE0")]
	public static void MBLBKGHLOBI<T>(T DGPDINALLHC, FLGIHDPKPJA<T> KHIFMDJDLEG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BC30", Offset = "0x5E6AA30", VA = "0x185E6BC30")]
	public static void CHIKOFMCJKA(Exception OLGCAAMGCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C030", Offset = "0x5E6AE30", VA = "0x185E6C030")]
	public static void IKFPKAPCGPJ(string NDLLBBKGIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BE10", Offset = "0x5E6AC10", VA = "0x185E6BE10")]
	public static void ELIJJLAGGND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C090", Offset = "0x5E6AE90", VA = "0x185E6C090")]
	public static string MBGBJFFNMAO(object KANAGAAAGHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BDA0", Offset = "0x5E6ABA0", VA = "0x185E6BDA0")]
	public static long EIGPIIEOCAH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BF90", Offset = "0x5E6AD90", VA = "0x185E6BF90")]
	public static bool IBODOIHMGIG(bool NACBPFCOKIC, string KHIFMDJDLEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BEC0", Offset = "0x5E6ACC0", VA = "0x185E6BEC0")]
	public static double GFBEOCIIDPO()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct OHKBEFFEANJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly NIOCDPPHCNG ENMJJJFMAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly MOLNBMFLEJJ AFGOKDLHHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly NBOGGKHJPAK NIOMPLCOCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly GBOCOMCHHHL PLHDCNEFEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly CJCGFCBHDGO ILHOPMHDLOP;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly NBOGGKHJPAK ODGGNPEEIMO;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly GBOCOMCHHHL EIHBCAKGAAL;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly CJCGFCBHDGO NIPAKFMNIPB;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly OHKBEFFEANJ EAKJMFHJPNI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool BGJCPKHADFA
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5E6A070", Offset = "0x5E68E70", VA = "0x185E6A070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A7D0", Offset = "0x5E695D0", VA = "0x185E6A7D0")]
	public OHKBEFFEANJ([In] NIOCDPPHCNG IAIKGBDABMK, [In] MOLNBMFLEJJ MJDDMGCMOIO, NBOGGKHJPAK LINBPOEGCNA, GBOCOMCHHHL CPHHBEAKEDM, CJCGFCBHDGO KOHOMHOMMNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A1D0", Offset = "0x5E68FD0", VA = "0x185E6A1D0")]
	private static string OHGLGHBIPCE(object KANAGAAAGHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E010", VA = "0x18076F210")]
	private static long GNKGPANEMHC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8146C0", Offset = "0x8134C0", VA = "0x1808146C0")]
	private static string MBIJINLBGBE(string MPLLGADEBOG, string? ENFDGODKGDK, bool JIOBBHPBKOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5E69F70", Offset = "0x5E68D70", VA = "0x185E69F70")]
	private static OHKBEFFEANJ GELGIIBGMFP()
	{
		return default(OHKBEFFEANJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface IAEOEEBMAEO
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PHDBALEHNCM ONGCPBCDKDC();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PHDBALEHNCM : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool GGHFBALOGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ALDPMIFBMCD();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface AEHDPJNHKCC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PBIEABNKMNG([In] T LCIDHBCOPEO);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void IFJFAFJJAHJ<T>([In] T DGPDINALLHC);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct MPJLJIODHGI<T> : IEquatable<MPJLJIODHGI<T>>, AEHDPJNHKCC<MPJLJIODHGI<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly T DHGNDNJJJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly int FNPAHLCJLFK;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1CC0860", Offset = "0x1CBF660", VA = "0x181CC0860")]
	public MPJLJIODHGI([In] T PHPDIJICBJO, int NGIPPLLBEKC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3CC9930", Offset = "0x3CC8730", VA = "0x183CC9930")]
	public static bool HIHGGPGGFPN([In] MPJLJIODHGI<T> CJNLLBDPPAC, [In] MPJLJIODHGI<T> CCDAOMDJCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x34455A0", Offset = "0x34443A0", VA = "0x1834455A0", Slot = "4")]
	public bool Equals(MPJLJIODHGI<T> LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x35EA8D0", Offset = "0x35E96D0", VA = "0x1835EA8D0", Slot = "0")]
	public override bool Equals(object LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3CCA2F0", Offset = "0x3CC90F0", VA = "0x183CCA2F0")]
	public bool PBIEABNKMNG([In] MPJLJIODHGI<T> LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3CC95D0", Offset = "0x3CC83D0", VA = "0x183CC95D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3CCA8B0", Offset = "0x3CC96B0", VA = "0x183CCA8B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3CC8E90", Offset = "0x3CC7C90", VA = "0x183CC8E90")]
	public void CEKAEOJBACK([Out] T PHPDIJICBJO, [Out] int NGIPPLLBEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3CCA030", Offset = "0x3CC8E30", VA = "0x183CCA030")]
	public (T, int) OMBHCMCLGOK()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3CC9490", Offset = "0x3CC8290", VA = "0x183CC9490", Slot = "5")]
	private bool FLLCLIFBHEF([In] MPJLJIODHGI<T> LCIDHBCOPEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class KHBEBPGBFMP
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x25515A0", Offset = "0x25503A0", VA = "0x1825515A0")]
	public static MPJLJIODHGI<T> FMIHPEHEFKO<T>([In] T PHPDIJICBJO, int NGIPPLLBEKC) where T : notnull
	{
		return default(MPJLJIODHGI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class PPALDPNFEPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x264BCE0", Offset = "0x264AAE0", VA = "0x18264BCE0")]
	public static bool PBIEABNKMNG<T, U>([In] T HLCOOGAGOEK, [In] U KANAGAAAGHJ) where T : notnull, AEHDPJNHKCC<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public delegate TResult DKHLJEINEKA<T, out TResult>([In] T DGPDINALLHC);
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate TResult NIFDGPGOGDD<T1, T2, out TResult>([In] T1 IPJOAKBHJHE, [In] T2 CCNFCJNGOHI);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface NKIMNIANPPG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	TimeSpan OAKAGLBPLJC
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	Action? MLFEDBLLDHB
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FKBNENBLEJE();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NKHLJIMEIMC();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GGDFNKIBDKM();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct NIOCDPPHCNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly KHOOAGDMNIN MHHPAHCGCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly IMMLGMGPGCJ HFIEEICMIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly KHOOAGDMNIN LPIHHIANELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly IMMLGMGPGCJ GPINEPLNKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly KHOOAGDMNIN NCALAPMLONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly IMMLGMGPGCJ BGEBKPOKHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly DHDOCEHPDFI HNIMPODCEBP;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly KHOOAGDMNIN EEICAPBDLKD;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly IMMLGMGPGCJ KCDGGJAAKGO;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly KHOOAGDMNIN LOOBMDBJEEK;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IMMLGMGPGCJ OCMBEAKDIHA;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly KHOOAGDMNIN NCPEGFEHFGG;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly IMMLGMGPGCJ GHGMNCIMKHH;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly DHDOCEHPDFI HMPNOIEKHBO;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly NIOCDPPHCNG EAKJMFHJPNI;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly KHOOAGDMNIN JKIPGNLJDFK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool BGJCPKHADFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5E695C0", Offset = "0x5E683C0", VA = "0x185E695C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x8B9120", Offset = "0x8B7F20", VA = "0x1808B9120")]
	public NIOCDPPHCNG(KHOOAGDMNIN IFHDONMIDAN, IMMLGMGPGCJ DDNJCEFNHHD, KHOOAGDMNIN DHAGKDDEEEL, IMMLGMGPGCJ OCJMKJHNMJB, KHOOAGDMNIN HOHEKGENJDF, IMMLGMGPGCJ PEPCHLEHFMD, DHDOCEHPDFI AKPKOGFNOMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0")]
	private static bool NCPKAFNEMFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200")]
	private static void HAMABEGJDGA(string KHIFMDJDLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0")]
	private static bool BEBBANGBBHK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200")]
	private static void HKIILEMOLAD(string KHIFMDJDLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0")]
	private static bool FPODJALGOLM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200")]
	private static void HHPNLDHOBOB(string KHIFMDJDLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200")]
	private static void KONLHAIHEPD(Exception OLGCAAMGCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5E693B0", Offset = "0x5E681B0", VA = "0x185E693B0")]
	private static NIOCDPPHCNG GELGIIBGMFP()
	{
		return default(NIOCDPPHCNG);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x78A100", Offset = "0x788F00", VA = "0x18078A100")]
	private static bool PDDOEEPABIC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5E69340", Offset = "0x5E68140", VA = "0x185E69340")]
	public void CLFELIEFDPO(object KHIFMDJDLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5E697C0", Offset = "0x5E685C0", VA = "0x185E697C0")]
	public void MBLBKGHLOBI(object KHIFMDJDLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x20C7990", Offset = "0x20C6790", VA = "0x1820C7990")]
	public void CHIKOFMCJKA(Exception OLGCAAMGCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5E69830", Offset = "0x5E68630", VA = "0x185E69830")]
	public void MBLBKGHLOBI(GKOJBJFACDH KHIFMDJDLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2606470", Offset = "0x2605270", VA = "0x182606470")]
	public void MBLBKGHLOBI<T>(T DGPDINALLHC, FLGIHDPKPJA<T> KHIFMDJDLEG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2606230", Offset = "0x2605030", VA = "0x182606230")]
	public void CLFELIEFDPO<T>([In] T DGPDINALLHC, LEIPOLOHFCP<T> KHIFMDJDLEG) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5E694F0", Offset = "0x5E682F0", VA = "0x185E694F0")]
	public bool IBODOIHMGIG(bool NACBPFCOKIC, string KHIFMDJDLEG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct BABFNHJHLKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly string DHGNDNJJJIH;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x83D460", Offset = "0x83C260", VA = "0x18083D460")]
	public BABFNHJHLKP(string PHPDIJICBJO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
	public static string DNODACOFDOB([In] BABFNHJHLKP HLCOOGAGOEK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1377CD0", Offset = "0x1376AD0", VA = "0x181377CD0")]
	public static BABFNHJHLKP DNODACOFDOB(string LCIDHBCOPEO)
	{
		return default(BABFNHJHLKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5E63210", Offset = "0x5E62010", VA = "0x185E63210")]
	public string MKGPMMJOKJH(string CCCJFICLKCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5E63130", Offset = "0x5E61F30", VA = "0x185E63130")]
	public string BNJNANLFOGK(object IDKBCMAGCGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct CJPHMHJPNKO : IEquatable<CJPHMHJPNKO>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x78A100", Offset = "0x788F00", VA = "0x18078A100", Slot = "4")]
	public bool Equals(CJPHMHJPNKO LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5E635C0", Offset = "0x5E623C0", VA = "0x185E635C0", Slot = "0")]
	public override bool Equals(object LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5E63610", Offset = "0x5E62410", VA = "0x185E63610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5E63620", Offset = "0x5E62420", VA = "0x185E63620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DLHFDGJCDNB("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct FGFONOFPPEN<T> : IEquatable<FGFONOFPPEN<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly T DHGNDNJJJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly bool ACMHHGPDIBB;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool CMCFOBFKCGG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3446110", Offset = "0x3444F10", VA = "0x183446110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3446480", Offset = "0x3445280", VA = "0x183446480")]
	public FGFONOFPPEN([In] T PHPDIJICBJO, bool DNHELIHABCL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3445DA0", Offset = "0x3444BA0", VA = "0x183445DA0")]
	public static bool HIHGGPGGFPN([In] FGFONOFPPEN<T> CJNLLBDPPAC, [In] FGFONOFPPEN<T> CCDAOMDJCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x34455A0", Offset = "0x34443A0", VA = "0x1834455A0", Slot = "4")]
	public bool Equals(FGFONOFPPEN<T> LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x34452C0", Offset = "0x34440C0", VA = "0x1834452C0", Slot = "0")]
	public override bool Equals(object LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3445C60", Offset = "0x3444A60", VA = "0x183445C60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3446120", Offset = "0x3444F20", VA = "0x183446120", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class NOEPMHFDIKP
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2608CF0", Offset = "0x2607AF0", VA = "0x182608CF0")]
	public static FGFONOFPPEN<T> ENIMFKENNPF<T>([In] T PHPDIJICBJO) where T : notnull
	{
		return default(FGFONOFPPEN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2608E20", Offset = "0x2607C20", VA = "0x182608E20")]
	public static FGFONOFPPEN<T?> NBFMDKMFCIC<T>()
	{
		return default(FGFONOFPPEN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2608ED0", Offset = "0x2607CD0", VA = "0x182608ED0")]
	public static bool OLGCGBMBCBF<T>([In] this FGFONOFPPEN<T> CDPOKCMKLDD, [Out][NotNullWhen(true)] T PHPDIJICBJO) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct MOLNBMFLEJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly IntPtr IKFPKAPCGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly IntPtr ELIJJLAGGND;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly IntPtr JDKKIENBOJI;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly IntPtr CGBGPGJIGGF;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly MOLNBMFLEJJ EAKJMFHJPNI;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool BGJCPKHADFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5E688C0", Offset = "0x5E676C0", VA = "0x185E688C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x801630", Offset = "0x800430", VA = "0x180801630")]
	public MOLNBMFLEJJ(IntPtr NEHHKBHLDLO, IntPtr FIFOJGNMODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200")]
	private static void KDLOAGLNOHN(string NDLLBBKGIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200")]
	private static void IJAPBHAJKLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5E68830", Offset = "0x5E67630", VA = "0x185E68830")]
	private static MOLNBMFLEJJ GELGIIBGMFP()
	{
		return default(MOLNBMFLEJJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct EKKCPOKPJIJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IntPtr GCMKBIDGINM;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x83D460", Offset = "0x83C260", VA = "0x18083D460")]
	private EKKCPOKPJIJ(IntPtr FIFOJGNMODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5E661B0", Offset = "0x5E64FB0", VA = "0x185E661B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5E661C0", Offset = "0x5E64FC0", VA = "0x185E661C0")]
	public static EKKCPOKPJIJ FMIHPEHEFKO(string NDLLBBKGIJD)
	{
		return default(EKKCPOKPJIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1CB7860", Offset = "0x1CB6660", VA = "0x181CB7860")]
	public static EKKCPOKPJIJ FMIHPEHEFKO([In] MOLNBMFLEJJ MJDDMGCMOIO, string NDLLBBKGIJD)
	{
		return default(EKKCPOKPJIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1CB7450", Offset = "0x1CB6250", VA = "0x181CB7450")]
	public static EKKCPOKPJIJ FMIHPEHEFKO([In] MOLNBMFLEJJ MJDDMGCMOIO, Func<string> NDLLBBKGIJD)
	{
		return default(EKKCPOKPJIJ);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class CNJBMCJPFIC
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public delegate bool IBFACDKKGEA<in TInput, TResult>(TInput JHAPDKALKLI, [Out] TResult OKONIBAEEBP);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private sealed class PLDHMAGGNCF : IAEOEEBMAEO
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		private sealed class DGEGJBPLJNN : PHDBALEHNCM, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public static readonly DGEGJBPLJNN ANGIAPALHML;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool GGHFBALOGGH
			{
				[Cpp2IlInjected.Token(Token = "0x60000AA")]
				[Cpp2IlInjected.Address(RVA = "0x5E65030", Offset = "0x5E63E30", VA = "0x185E65030", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x5E65090", Offset = "0x5E63E90", VA = "0x185E65090", Slot = "6")]
			public void OnCompleted(Action CCEHCDHAOAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "5")]
			public void ALDPMIFBMCD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
			public DGEGJBPLJNN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly PLDHMAGGNCF ANGIAPALHML;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		private PLDHMAGGNCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C330", Offset = "0x5E6B130", VA = "0x185E6C330", Slot = "4")]
		public PHDBALEHNCM ONGCPBCDKDC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private sealed class HICHAMIIAHN : IAEOEEBMAEO
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		private sealed class CMDPHGLMJJO : PHDBALEHNCM, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly CMDPHGLMJJO ANGIAPALHML;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool GGHFBALOGGH
			{
				[Cpp2IlInjected.Token(Token = "0x60000B5")]
				[Cpp2IlInjected.Address(RVA = "0x5E63650", Offset = "0x5E62450", VA = "0x185E63650", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x5E63670", Offset = "0x5E62470", VA = "0x185E63670", Slot = "6")]
			public void OnCompleted(Action CCEHCDHAOAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "5")]
			public void ALDPMIFBMCD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
			public CMDPHGLMJJO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly HICHAMIIAHN ANGIAPALHML;

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		private HICHAMIIAHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5E66C30", Offset = "0x5E65A30", VA = "0x185E66C30", Slot = "4")]
		public PHDBALEHNCM ONGCPBCDKDC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class NOFFNCBCDNC<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public NOFFNCBCDNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3D30AE0", Offset = "0x3D2F8E0", VA = "0x183D30AE0")]
		internal void HJHPNNLLAHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class IPLNIGDANCB<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public IPLNIGDANCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3770E90", Offset = "0x376FC90", VA = "0x183770E90")]
		internal void GJDIDIGOFAD(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct GPHFEKBDNHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5E66AD0", Offset = "0x5E658D0", VA = "0x185E66AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8A0", Offset = "0x8BE6A0", VA = "0x1808BF8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct OIMPJMHAPEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5E6A870", Offset = "0x5E69670", VA = "0x185E6A870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8BF8A0", Offset = "0x8BE6A0", VA = "0x1808BF8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct CMDEABIIIKP<TException> : IAsyncStateMachine where TException : notnull, Exception
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x49C08C0", Offset = "0x49BF6C0", VA = "0x1849C08C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x49C0A30", Offset = "0x49BF830", VA = "0x1849C0A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct NNFBLPEIBNE<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public Task<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter<T> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D660", Offset = "0x3D2C460", VA = "0x183D2D660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3D2DED0", Offset = "0x3D2CCD0", VA = "0x183D2DED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct KOOBABFGMFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Task self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5E67630", Offset = "0x5E66430", VA = "0x185E67630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5E67830", Offset = "0x5E66630", VA = "0x185E67830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class PMFEKJPABPN<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public TaskCompletionSource<T> taskCompletionSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public PMFEKJPABPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3D30AE0", Offset = "0x3D2F8E0", VA = "0x183D30AE0")]
		internal void FMAACOGCHCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x3F06F40", Offset = "0x3F05D40", VA = "0x183F06F40")]
		internal void NOAKDOPIDFK(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct FEAAFNKGLPB<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Task<List<TInput>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public IBFACDKKGEA<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3435830", Offset = "0x3434630", VA = "0x183435830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3435F20", Offset = "0x3434D20", VA = "0x183435F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct NECMOFDJAEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Func<CancellationToken, Task> innerTaskConstructor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private CancellationTokenSource <innerTaskCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private Task <innerTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter<TaskStatus> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5E68AF0", Offset = "0x5E678F0", VA = "0x185E68AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5E692E0", Offset = "0x5E680E0", VA = "0x185E692E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct OKGFHLMECIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Func<CancellationToken, Task> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5E6A980", Offset = "0x5E69780", VA = "0x185E6A980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AEC0", Offset = "0x5E69CC0", VA = "0x185E6AEC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct NNCDLJKIEBL<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<CancellationToken, Task<T>> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Func<OperationCanceledException, T> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3D24E50", Offset = "0x3D23C50", VA = "0x183D24E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3560CF0", Offset = "0x355FAF0", VA = "0x183560CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct FGBPKCKAGBI<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public AsyncTaskMethodBuilder<IEnumerable<Task<T>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public IEnumerable<Task<T>> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private Task<T>[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3437D10", Offset = "0x3436B10", VA = "0x183437D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x34384D0", Offset = "0x34372D0", VA = "0x1834384D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct GJEEPKOPHKF<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public AsyncTaskMethodBuilder<(T1, T2, T3, T4)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Task<T4> task4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x35DCE10", Offset = "0x35DBC10", VA = "0x1835DCE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x35DDAE0", Offset = "0x35DC8E0", VA = "0x1835DDAE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct PBMBPLMPLLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AF20", Offset = "0x5E69D20", VA = "0x185E6AF20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5E6B290", Offset = "0x5E6A090", VA = "0x185E6B290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct PHOJIMCDNAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x5E6B760", Offset = "0x5E6A560", VA = "0x185E6B760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5E6BA50", Offset = "0x5E6A850", VA = "0x185E6BA50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class JDJJCFFLLMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public JDJJCFFLLMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5E67230", Offset = "0x5E66030", VA = "0x185E67230")]
		internal Task IDLBCAOCFDI(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct MAPDHPNJLDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5E67D40", Offset = "0x5E66B40", VA = "0x185E67D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5E67FA0", Offset = "0x5E66DA0", VA = "0x185E67FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct BMCCEPJGOGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5E63260", Offset = "0x5E62060", VA = "0x185E63260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5E63440", Offset = "0x5E62240", VA = "0x185E63440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct LNAGBFLHFLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E67970", Offset = "0x5E66770", VA = "0x185E67970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5E67CE0", Offset = "0x5E66AE0", VA = "0x185E67CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct HNGOCLBCCKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5E66D00", Offset = "0x5E65B00", VA = "0x185E66D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5E66FF0", Offset = "0x5E65DF0", VA = "0x185E66FF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class DHMCHGNCBCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public DHMCHGNCBCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5E65270", Offset = "0x5E64070", VA = "0x185E65270")]
		internal Task MNLOMNDINIF(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct KMDOANPICLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5E67370", Offset = "0x5E66170", VA = "0x185E67370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5E675D0", Offset = "0x5E663D0", VA = "0x185E675D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct IABKHALBFJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Action then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5E67050", Offset = "0x5E65E50", VA = "0x185E67050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E671D0", Offset = "0x5E65FD0", VA = "0x185E671D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct LNLJCEFBCDL<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public Action<T> then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3ACDC90", Offset = "0x3ACCA90", VA = "0x183ACDC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3ACDEF0", Offset = "0x3ACCCF0", VA = "0x183ACDEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct PHKCCMGPKFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Func<Task> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private object <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5E6B2F0", Offset = "0x5E6A0F0", VA = "0x185E6B2F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5E6B700", Offset = "0x5E6A500", VA = "0x185E6B700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static SynchronizationContext? FOCEJAGJFHP;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly TaskCompletionSource<CJPHMHJPNKO> FLDNEHMPBKD;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static Task IEFKMHNCMFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5E63E30", Offset = "0x5E62C30", VA = "0x185E63E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x23311D0", Offset = "0x232FFD0", VA = "0x1823311D0")]
	public static Task<T> GLKODLHPOLJ<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5E64210", Offset = "0x5E63010", VA = "0x185E64210")]
	public static Task FLPMOIKBOMD(this Task JFHMPGCGNFN, CancellationToken HOBAPMCPFML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x232FFD0", Offset = "0x232EDD0", VA = "0x18232FFD0")]
	public static Task<TResult> FLPMOIKBOMD<TResult>(this Task<TResult> JFHMPGCGNFN, CancellationToken HOBAPMCPFML) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x23309F0", Offset = "0x232F7F0", VA = "0x1823309F0")]
	public static TaskCompletionSource<TResult> FLPMOIKBOMD<TResult>(this TaskCompletionSource<TResult> MEFJIINLLLH, CancellationToken HOBAPMCPFML) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5E64A00", Offset = "0x5E63800", VA = "0x185E64A00")]
	[AsyncStateMachine(typeof(GPHFEKBDNHC))]
	public static void NDBCBLIIMJA(this Task KMHHCKOIFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5E63790", Offset = "0x5E62590", VA = "0x185E63790")]
	[AsyncStateMachine(typeof(OIMPJMHAPEK))]
	public static void AIAELLBGHPA(this Task KMHHCKOIFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2331100", Offset = "0x232FF00", VA = "0x182331100")]
	[AsyncStateMachine(typeof(CMDEABIIIKP<>))]
	public static Task GDLLIOEDKKK<TException>(this Task KMHHCKOIFKM) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x232E500", Offset = "0x232D300", VA = "0x18232E500")]
	[AsyncStateMachine(typeof(NNFBLPEIBNE<>))]
	public static Task<T> DCNBBKMCHDC<T>(this Task<T> HLCOOGAGOEK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5E64660", Offset = "0x5E63460", VA = "0x185E64660")]
	[AsyncStateMachine(typeof(KOOBABFGMFP))]
	public static Task<TaskStatus> HCFHBEBMBEN(this Task HLCOOGAGOEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x232E2C0", Offset = "0x232D0C0", VA = "0x18232E2C0")]
	public static (Task<T?>?, Action<T?>?) CNKHMDBBFJC<T>([Optional] CancellationToken ELPOPHCEGNN)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x232E1C0", Offset = "0x232CFC0", VA = "0x18232E1C0")]
	[AsyncStateMachine(typeof(FEAAFNKGLPB<, >))]
	public static Task<List<TResult>> AJHEOPGPLJF<TResult, TInput>(this Task<List<TInput>> JFHMPGCGNFN, IBFACDKKGEA<TInput, TResult> BKLBKLDGDMF) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5E64750", Offset = "0x5E63550", VA = "0x185E64750")]
	[AsyncStateMachine(typeof(NECMOFDJAEK))]
	public static Task HMKJABLCPBL(Task KMHHCKOIFKM, CancellationToken FODMGJKDOOC, Func<CancellationToken, Task> AJPCAEFJDJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5E64880", Offset = "0x5E63680", VA = "0x185E64880")]
	[AsyncStateMachine(typeof(OKGFHLMECIM))]
	public static Task IMDHBFDOLDI(Func<CancellationToken, Task> HACCNHLJAJG, TimeSpan ILLDINKMDEN, [Optional] CancellationToken FODMGJKDOOC, [Optional] Action<OperationCanceledException>? KPGKAHFAEAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2331320", Offset = "0x2330120", VA = "0x182331320")]
	[AsyncStateMachine(typeof(NNCDLJKIEBL<>))]
	public static Task<T> IMDHBFDOLDI<T>(Func<CancellationToken, Task<T>> HACCNHLJAJG, TimeSpan ILLDINKMDEN, [Optional] CancellationToken FODMGJKDOOC, [Optional] Func<OperationCanceledException, T>? KPGKAHFAEAJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2331020", Offset = "0x232FE20", VA = "0x182331020")]
	[AsyncStateMachine(typeof(FGBPKCKAGBI<>))]
	public static Task<IEnumerable<Task<T>>> GDEPOBPMEEL<T>(IEnumerable<Task<T>> CEHMPIEEFAK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x232E6C0", Offset = "0x232D4C0", VA = "0x18232E6C0")]
	[AsyncStateMachine(typeof(GJEEPKOPHKF<, , , >))]
	public static Task<(T1, T2, T3, T4)> DKBDGFHOCAE<T1, T2, T3, T4>(Task<T1> HIEOFAJLCKO, Task<T2> BOCOAHLBDNL, Task<T3> BCBIIBCOKNF, Task<T4> FAMCFDDCFBA) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5E63F70", Offset = "0x5E62D70", VA = "0x185E63F70")]
	[AsyncStateMachine(typeof(PBMBPLMPLLN))]
	public static Task EKLPNKCFEJM(Func<bool> NACBPFCOKIC, TimeSpan OHOMGAGKKND, [Optional] CancellationToken ELPOPHCEGNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5E63840", Offset = "0x5E62640", VA = "0x185E63840")]
	[AsyncStateMachine(typeof(PHOJIMCDNAF))]
	public static Task BCMGOGFGPGD(Func<bool> NACBPFCOKIC, TimeSpan ILLDINKMDEN, [Optional] CancellationToken ELPOPHCEGNN, [Optional] Action<OperationCanceledException>? KPGKAHFAEAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5E63970", Offset = "0x5E62770", VA = "0x185E63970")]
	[AsyncStateMachine(typeof(MAPDHPNJLDO))]
	public static Task BCMGOGFGPGD(Func<bool> NACBPFCOKIC, TimeSpan ILLDINKMDEN, TimeSpan OHOMGAGKKND, [Optional] CancellationToken ELPOPHCEGNN, [Optional] Action<OperationCanceledException>? KPGKAHFAEAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5E64BC0", Offset = "0x5E639C0", VA = "0x185E64BC0")]
	[AsyncStateMachine(typeof(BMCCEPJGOGH))]
	public static Task NJLJFANCNOH(Func<bool> NACBPFCOKIC, [Optional] CancellationToken ELPOPHCEGNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5E64AB0", Offset = "0x5E638B0", VA = "0x185E64AB0")]
	[AsyncStateMachine(typeof(LNAGBFLHFLB))]
	public static Task NJLJFANCNOH(Func<bool> NACBPFCOKIC, TimeSpan OHOMGAGKKND, [Optional] CancellationToken ELPOPHCEGNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5E64CB0", Offset = "0x5E63AB0", VA = "0x185E64CB0")]
	[AsyncStateMachine(typeof(HNGOCLBCCKK))]
	public static Task NKFGHPKIKPM(Func<bool> NACBPFCOKIC, TimeSpan ILLDINKMDEN, [Optional] CancellationToken ELPOPHCEGNN, [Optional] Action<OperationCanceledException>? KPGKAHFAEAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5E64DE0", Offset = "0x5E63BE0", VA = "0x185E64DE0")]
	[AsyncStateMachine(typeof(KMDOANPICLA))]
	public static Task NKFGHPKIKPM(Func<bool> NACBPFCOKIC, TimeSpan ILLDINKMDEN, TimeSpan OHOMGAGKKND, [Optional] CancellationToken ELPOPHCEGNN, [Optional] Action<OperationCanceledException>? KPGKAHFAEAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5E64450", Offset = "0x5E63250", VA = "0x185E64450")]
	[Obsolete]
	[AsyncStateMachine(typeof(IABKHALBFJM))]
	public static Task FMCHBFIDAKF(this Task JFHMPGCGNFN, Action MGIJCLHKCNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2330E50", Offset = "0x232FC50", VA = "0x182330E50")]
	[Obsolete]
	[AsyncStateMachine(typeof(LNLJCEFBCDL<>))]
	public static Task FMCHBFIDAKF<T>(this Task<T> JFHMPGCGNFN, Action<T> MGIJCLHKCNK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5E63AB0", Offset = "0x5E628B0", VA = "0x185E63AB0")]
	public static bool BFMPKEIOJPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5E64080", Offset = "0x5E62E80", VA = "0x185E64080")]
	private static void EONFHBPKFFH(SynchronizationContext PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5E64540", Offset = "0x5E63340", VA = "0x185E64540")]
	private static void GNPMABLGKKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5E63740", Offset = "0x5E62540", VA = "0x185E63740")]
	public static IAEOEEBMAEO AAJJGJKIBCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5E649B0", Offset = "0x5E637B0", VA = "0x185E649B0")]
	public static IAEOEEBMAEO JAOHMMFAGPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5E63EA0", Offset = "0x5E62CA0", VA = "0x185E63EA0")]
	[AsyncStateMachine(typeof(PHKCCMGPKFC))]
	public static Task DIFKNPILJEO(Func<Task> MGDCGIGLBNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class KBJLIMKPDCA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
	public KBJLIMKPDCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class EKLEJKAMNOE : LPIODFHGMMJ
{
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static readonly LPIODFHGMMJ ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public DateTime BCJFBLOFBHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5E66310", Offset = "0x5E65110", VA = "0x185E66310", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTimeOffset HEFJBHEBBCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5E662B0", Offset = "0x5E650B0", VA = "0x185E662B0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public EKLEJKAMNOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface LPIODFHGMMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	DateTime BCJFBLOFBHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DateTimeOffset HEFJBHEBBCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class MHLELINIAFO
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static long GLKADINEMAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5E68050", Offset = "0x5E66E50", VA = "0x185E68050")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long ADBAOHNNOPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5E68000", Offset = "0x5E66E00", VA = "0x185E68000")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static double DICCCKPJMNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5E680F0", Offset = "0x5E66EF0", VA = "0x185E680F0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double PDENALHKIGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5E680A0", Offset = "0x5E66EA0", VA = "0x185E680A0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double EIAKIJMPLNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5E68480", Offset = "0x5E67280", VA = "0x185E68480")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double BBEJBBAJKND
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5E681D0", Offset = "0x5E66FD0", VA = "0x185E681D0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5E68280", Offset = "0x5E67080", VA = "0x185E68280")]
	public static double ILNHGOCNNCC(long BLJMHNKGEKO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5E68140", Offset = "0x5E66F40", VA = "0x185E68140")]
	public static double EODMBGOMIGF(long BLJMHNKGEKO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5E68320", Offset = "0x5E67120", VA = "0x185E68320")]
	public static double MFLCDCCMEEI(double EABEAEGEJJD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5E684D0", Offset = "0x5E672D0", VA = "0x185E684D0")]
	public static long OHLEMDPCAME(long IGPHDAEBEMO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5E68310", Offset = "0x5E67110", VA = "0x185E68310")]
	public static long KFMBNFGNCHJ(long NBLMNCHFFNP, long GDIGNNNJBFA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5E683B0", Offset = "0x5E671B0", VA = "0x185E683B0")]
	public static double MIPFEOCHEAA(long NBLMNCHFFNP, long GDIGNNNJBFA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5E68220", Offset = "0x5E67020", VA = "0x185E68220")]
	public static double FKNGFLIGPFF(long NBLMNCHFFNP, long GDIGNNNJBFA)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public sealed class FMLBOIOHDOI : NKIMNIANPPG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static readonly TimeSpan IDFLKAAOCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly System.Timers.Timer CGEFCMPOECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private TimeSpan ILLDINKMDEN;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public TimeSpan OAKAGLBPLJC
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x775E10", Offset = "0x774C10", VA = "0x180775E10", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5E665D0", Offset = "0x5E653D0", VA = "0x185E665D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public Action? MLFEDBLLDHB
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x770F00", Offset = "0x76FD00", VA = "0x180770F00", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5E66A60", Offset = "0x5E65860", VA = "0x185E66A60")]
	[Preserve]
	public FMLBOIOHDOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5E66810", Offset = "0x5E65610", VA = "0x185E66810")]
	public FMLBOIOHDOI(TimeSpan ILLDINKMDEN, [Optional] Action? FCJMBPDBPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5E66510", Offset = "0x5E65310", VA = "0x185E66510", Slot = "7")]
	public void FKBNENBLEJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5E66730", Offset = "0x5E65530", VA = "0x185E66730", Slot = "8")]
	public void NKHLJIMEIMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5E665A0", Offset = "0x5E653A0", VA = "0x185E665A0", Slot = "9")]
	public void GGDFNKIBDKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0xB2C710", Offset = "0xB2B510", VA = "0x180B2C710")]
	private void HMIAADHFNBL(object ANLNKNAJGIA, ElapsedEventArgs NJMPHLAOHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5E66470", Offset = "0x5E65270", VA = "0x185E66470")]
	private static void EDIFOEAEGAP(TimeSpan MMEPADEPAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5E663D0", Offset = "0x5E651D0", VA = "0x185E663D0", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class DLHFDGJCDNB : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public readonly string JPMHFKJJBLO;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x799B60", Offset = "0x798960", VA = "0x180799B60")]
	public DLHFDGJCDNB(string HBNFGFDAEMN)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct DOMMGGKCPDI : IEquatable<DOMMGGKCPDI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public uint CDMFKODPIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public int AMKPPKIPLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public float MCEOLFEPNHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public ushort CLKAOGPGKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public ushort BEGBEAOFHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public short NNEDLMJDOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public short OKLFJDPHGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public char IPEEGNLOBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public char PMECIJDCMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public byte MOPMEFJJBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte MPPILNGMJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public byte ENBDFIGGCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public byte KLNLHFNHKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public bool PMPJLMPEIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public bool HDCBAKLPKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public bool EKIGMGIINJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public bool DPBIIBLMAAD;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0xD518E0", Offset = "0xD506E0", VA = "0x180D518E0")]
	public static DOMMGGKCPDI FKJPHMMDKLH(uint MGAIOMDCLIM)
	{
		return default(DOMMGGKCPDI);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0xD518E0", Offset = "0xD506E0", VA = "0x180D518E0")]
	public static DOMMGGKCPDI FBBBDHCDOEE(int PLDFJGFCBMH)
	{
		return default(DOMMGGKCPDI);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5E652E0", Offset = "0x5E640E0", VA = "0x185E652E0")]
	public static DOMMGGKCPDI CKOJMBINNAP(float GIHMKGLCCAF)
	{
		return default(DOMMGGKCPDI);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5E65370", Offset = "0x5E64170", VA = "0x185E65370")]
	public static DOMMGGKCPDI PDGJLMJKCBC(byte PJMEBNDAIKD, byte MAFKJLDCACN, byte DKCMKGONAEF, byte LKKCHJOLEHC)
	{
		return default(DOMMGGKCPDI);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5E65370", Offset = "0x5E64170", VA = "0x185E65370")]
	public static DOMMGGKCPDI NEJPNFOLNMA(bool LFMKJHEMIBH, bool INOLNBNIICB, bool LDNNPBKGHKO, bool OMELHIGCCEG)
	{
		return default(DOMMGGKCPDI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x16C9C50", Offset = "0x16C8A50", VA = "0x1816C9C50")]
	public static bool HIHGGPGGFPN(DOMMGGKCPDI KADNMONNONH, DOMMGGKCPDI DCAFNABOJJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x16C9C30", Offset = "0x16C8A30", VA = "0x1816C9C30", Slot = "4")]
	public bool Equals(DOMMGGKCPDI LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5E652F0", Offset = "0x5E640F0", VA = "0x185E652F0", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x83F780", Offset = "0x83E580", VA = "0x18083F780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5E65390", Offset = "0x5E64190", VA = "0x185E65390", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct DEEHFDFNNLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public ulong FACLIJAOJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public long GKEJKNMOMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public double GJPCIMLEIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint JOCJACOLLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint GDMFJAMDGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public int FFFHFIPPBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public int LCIBLHLKIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public float IAFDDNHNMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public float IPOLDPJLPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public ushort CLKAOGPGKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public ushort BEGBEAOFHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public ushort FDFBFKPAJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public ushort EODLDKDPJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public short NNEDLMJDOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public short OKLFJDPHGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public short MLFPBGLLLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public short CAHCJDOOIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public char IPEEGNLOBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public char PMECIJDCMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public char DNGICKJAGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public char MCBGPGJCCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public byte MOPMEFJJBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public byte MPPILNGMJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public byte ENBDFIGGCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public byte KLNLHFNHKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public byte JPEAKDPCFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public byte KKHIFAINPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public byte JHFCIINBHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public byte MCEEDIJAKHF;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5E64FE0", Offset = "0x5E63DE0", VA = "0x185E64FE0")]
	public static DEEHFDFNNLM FMIHPEHEFKO(byte PJMEBNDAIKD, byte MAFKJLDCACN, byte DKCMKGONAEF, byte LKKCHJOLEHC, byte OEBLHEGCEFP, byte HNMHIKOFDEO, byte JPLNOCDAEAE, byte ELNHFKCPMEC)
	{
		return default(DEEHFDFNNLM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class JIDOPEKMJKE
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x24E8330", Offset = "0x24E7130", VA = "0x1824E8330")]
	public static IEnumerable<T> EHGDPPJDILM<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x8146C0", Offset = "0x8134C0", VA = "0x1808146C0")]
	public static T[] AGNFIMJGAKC<T>(params T[] EMNFGEPEEDJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x8146C0", Offset = "0x8134C0", VA = "0x1808146C0")]
	public static IEnumerable<T> LBOIBHNPFNM<T>(params T[] EMNFGEPEEDJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x253C320", Offset = "0x253B120", VA = "0x18253C320")]
	public static HashSet<T> GFAMLDABIIL<T>(params T[] EMNFGEPEEDJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x253C390", Offset = "0x253B190", VA = "0x18253C390")]
	public static KeyValuePair<TKey, TValue> KINGIIDNOHA<TKey, TValue>([In] TKey GAMCILOFBAF, [In] TValue PHPDIJICBJO) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x253C320", Offset = "0x253B120", VA = "0x18253C320")]
	public static List<T> EBGPMOPOJIH<T>(IEnumerable<T> BLKANEONNOI) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[AttributeUsage(AttributeTargets.All)]
public sealed class BGJFAJEOEPL : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public readonly string BHALONBANDB;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x799B60", Offset = "0x798960", VA = "0x180799B60")]
	public BGJFAJEOEPL(string GGPAEIENLAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public delegate object LEIPOLOHFCP<T>([In] T BONEGMDLPMG);
[Cpp2IlInjected.Token(Token = "0x2000052")]
public delegate object FLGIHDPKPJA<T>(T BONEGMDLPMG);
[Cpp2IlInjected.Token(Token = "0x2000053")]
[HJOACPGEJDF]
public delegate string CJCGFCBHDGO(string MPLLGADEBOG, string? ENFDGODKGDK, bool JIOBBHPBKOJ);
[Cpp2IlInjected.Token(Token = "0x2000054")]
[HJOACPGEJDF]
public delegate void IMMLGMGPGCJ(string KHIFMDJDLEG);
[Cpp2IlInjected.Token(Token = "0x2000055")]
[HJOACPGEJDF]
public delegate void DHDOCEHPDFI(Exception OLGCAAMGCBK);
[Cpp2IlInjected.Token(Token = "0x2000056")]
public delegate object GKOJBJFACDH();
[Cpp2IlInjected.Token(Token = "0x2000057")]
[HJOACPGEJDF]
public delegate bool KHOOAGDMNIN();
[Cpp2IlInjected.Token(Token = "0x2000058")]
[HJOACPGEJDF]
public delegate string NBOGGKHJPAK(object KANAGAAAGHJ);
[Cpp2IlInjected.Token(Token = "0x2000059")]
[AttributeUsage(AttributeTargets.Enum)]
public class JEOJOKDKFCJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
	public JEOJOKDKFCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class FPKMPMCFFOC
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private sealed class OPINMKEAIOD<T> : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public static readonly ISet<T> ANGIAPALHML;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public int BMGCAELLGLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E010", VA = "0x18076F210", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool FDJGALFBLIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x78A100", Offset = "0x788F00", VA = "0x18078A100", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3E26DB0", Offset = "0x3E25BB0", VA = "0x183E26DB0", Slot = "4")]
		public bool Add(T DAPKCDOOBFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "6")]
		public void IntersectWith(IEnumerable<T> LCIDHBCOPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3E26FB0", Offset = "0x3E25DB0", VA = "0x183E26FB0", Slot = "5")]
		public void UnionWith(IEnumerable<T> LCIDHBCOPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x3E26F50", Offset = "0x3E25D50", VA = "0x183E26F50", Slot = "9")]
		void ICollection<T>.Add(T DAPKCDOOBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "10")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "11")]
		public bool Contains(T DAPKCDOOBFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "12")]
		public void CopyTo(T[] LPMIAHOCPLL, int LKGKKAPFOFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
		public bool Remove(T DAPKCDOOBFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3E26E70", Offset = "0x3E25C70", VA = "0x183E26E70", Slot = "14")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x34C89D0", Offset = "0x34C77D0", VA = "0x1834C89D0", Slot = "15")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public OPINMKEAIOD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7DA890", Offset = "0x7D9690", VA = "0x1807DA890")]
	public static ISet<T> AMDIANNDHAM<T>() where T : notnull
	{
		return null;
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
