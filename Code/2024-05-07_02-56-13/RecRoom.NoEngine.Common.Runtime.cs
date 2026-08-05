using System;
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
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x62A3560", Offset = "0x62A2760", VA = "0x1862A3560")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DF880", Offset = "0x7DEA80", VA = "0x1807DF880")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7DF8C0", Offset = "0x7DEAC0", VA = "0x1807DF8C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class LMAIOOBDOOL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x62A1550", Offset = "0x62A0750", VA = "0x1862A1550")]
	public LMAIOOBDOOL(bool MNEMKKADAKK, string GHDGDEPKAAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class LPEFOFLNEMH
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HCBJKGDLFML<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate Task<TResult> AODBIADANPC(CancellationToken AIHJHMPAHCH);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct PCOJJLMFNBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public HCBJKGDLFML<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AODBIADANPC taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x4262E40", Offset = "0x4262040", VA = "0x184262E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4263D70", Offset = "0x4262F70", VA = "0x184263D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CancellationTokenSource MODHBCLCLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CancellationTokenSource? MNCDKPCDDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private TaskCompletionSource<TResult>? ALPEMGJLDLJ;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3917400", Offset = "0x3916600", VA = "0x183917400")]
	[AsyncStateMachine(typeof(HCBJKGDLFML<>.PCOJJLMFNBF))]
	public Task<TResult> JIGNACCDBOJ(AODBIADANPC FKPIBJMKCPJ, [Optional] CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3917390", Offset = "0x3916590", VA = "0x183917390", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3917530", Offset = "0x3916730", VA = "0x183917530")]
	public HCBJKGDLFML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class BKJGJLKDNJI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly EqualityComparer<T> DJPAOHKBPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public T FJJHODHBEGH;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3F5FCC0", Offset = "0x3F5EEC0", VA = "0x183F5FCC0")]
	public BKJGJLKDNJI([In] T NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x48A7660", Offset = "0x48A6860", VA = "0x1848A7660", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x48A7BD0", Offset = "0x48A6DD0", VA = "0x1848A7BD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x48A7E50", Offset = "0x48A7050", VA = "0x1848A7E50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class PEDCEEHGDAM
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x271FBA0", Offset = "0x271EDA0", VA = "0x18271FBA0")]
	public static BKJGJLKDNJI<T> MIJABIECKKD<T>([In] T NICEPFIEJED) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class JMKKOLCEHAL
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x62A0B20", Offset = "0x629FD20", VA = "0x1862A0B20")]
	public static void FPGEGMKCCNN(this CancellationTokenSource MODHBCLCLKC, bool BEOJBECCBDA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class MOPDLKLMCFN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
	public MOPDLKLMCFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class CGEGMLFOCCL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
	public CGEGMLFOCCL(string AOLEPFGPAGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NCPJMFKKDHB
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2A0E670", Offset = "0x2A0D870", VA = "0x182A0E670")]
	public static BLKDCPILLAK FNBFAAEGJAJ<T>()
	{
		return default(BLKDCPILLAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2A0E820", Offset = "0x2A0DA20", VA = "0x182A0E820")]
	public static BLKDCPILLAK NMNNNNODDMG<T>([CallerMemberName] string IKEFBMMMAJB = "") where T : notnull
	{
		return default(BLKDCPILLAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2A0E5F0", Offset = "0x2A0D7F0", VA = "0x182A0E5F0")]
	public static BLKDCPILLAK FNBFAAEGJAJ<T>(this T PMBMOONGPPJ) where T : notnull
	{
		return default(BLKDCPILLAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2A0E4A0", Offset = "0x2A0D6A0", VA = "0x182A0E4A0")]
	public static BLKDCPILLAK EFNFLFEJDDO<T>(this T PMBMOONGPPJ, [CallerMemberName] string IKEFBMMMAJB = "") where T : notnull
	{
		return default(BLKDCPILLAK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2A0E8B0", Offset = "0x2A0DAB0", VA = "0x182A0E8B0")]
	public static BLKDCPILLAK NMNNNNODDMG<T>(this T KNKOEEEKHDK, [CallerMemberName] string IKEFBMMMAJB = "") where T : notnull
	{
		return default(BLKDCPILLAK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x62A3080", Offset = "0x62A2280", VA = "0x1862A3080")]
	public static BLKDCPILLAK NMNNNNODDMG(string BDPHNCDGPLB, [CallerMemberName] string IKEFBMMMAJB = "")
	{
		return default(BLKDCPILLAK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x62A2FE0", Offset = "0x62A21E0", VA = "0x1862A2FE0")]
	public static string MOALOKNLLCC(this object KNKOEEEKHDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public delegate bool GONIOLOFKAI();
[Cpp2IlInjected.Token(Token = "0x2000011")]
[MOPDLKLMCFN]
public delegate long EDLINIBOMKB();
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class CPEEJPHOKNA
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static LNKDPKIEHME KKPNDELMMMJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static LNKDPKIEHME BDGPKILDHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x629C6C0", Offset = "0x629B8C0", VA = "0x18629C6C0")]
		get
		{
			return default(LNKDPKIEHME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static FCCNDHIDGCJ AAJJLHCMOPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x629C670", Offset = "0x629B870", VA = "0x18629C670")]
		get
		{
			return default(FCCNDHIDGCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static IHMHECJDOHM BFMFOCLLCDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x629C8A0", Offset = "0x629BAA0", VA = "0x18629C8A0")]
		get
		{
			return default(IHMHECJDOHM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static bool HODGIECFANO
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x629CA30", Offset = "0x629BC30", VA = "0x18629CA30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x629C4D0", Offset = "0x629B6D0", VA = "0x18629C4D0")]
	public static void BOKCCDOPHLP([In] LNKDPKIEHME MFGMCCAAILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x629CBE0", Offset = "0x629BDE0", VA = "0x18629CBE0")]
	public static void PHDBFKGPBFI(string JGNAJPMGGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x629C710", Offset = "0x629B910", VA = "0x18629C710")]
	public static void ENCMOPKOEPF(string JGNAJPMGGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x27218E0", Offset = "0x2720AE0", VA = "0x1827218E0")]
	public static void ENCMOPKOEPF<T>(T GFMMLICJDDH, JFIOELPPJOC<T> JGNAJPMGGNE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x629C8F0", Offset = "0x629BAF0", VA = "0x18629C8F0")]
	public static void HEHPIJGHGHP(Exception PGAHDJGBLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x629C7E0", Offset = "0x629B9E0", VA = "0x18629C7E0")]
	public static void EPAMNMMPOJN(string IKEFBMMMAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x629C840", Offset = "0x629BA40", VA = "0x18629C840")]
	public static void GLMMHBDCOFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x629CAA0", Offset = "0x629BCA0", VA = "0x18629CAA0")]
	public static string MOALOKNLLCC(object JFJMICPDNDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x629C460", Offset = "0x629B660", VA = "0x18629C460")]
	public static long BMKCMOKGEFJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x629C990", Offset = "0x629BB90", VA = "0x18629C990")]
	public static bool LBOCOOAPKDJ(bool JOIPJBFGDKM, string JGNAJPMGGNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x629CB10", Offset = "0x629BD10", VA = "0x18629CB10")]
	public static double NEEIFKNLFGJ()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public readonly struct LNKDPKIEHME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly FCCNDHIDGCJ AAJJLHCMOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly IHMHECJDOHM BFMFOCLLCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly AHJPALFMGKO GDCLJKKOJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly EDLINIBOMKB NEGKFAPEABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly PHOPGFNBODB HFBJPKMDKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly GONIOLOFKAI FNEEHGMABCH;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly AHJPALFMGKO CNJAKOPHPMJ;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly EDLINIBOMKB BFPBEBDAGCD;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly PHOPGFNBODB EMAPGEELOOI;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly GONIOLOFKAI OALAEOJIBHG;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly LNKDPKIEHME CLJCIKPCCEE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool PPFMDOGEELH
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x62A1720", Offset = "0x62A0920", VA = "0x1862A1720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x62A1FB0", Offset = "0x62A11B0", VA = "0x1862A1FB0")]
	public LNKDPKIEHME([In] FCCNDHIDGCJ EFKNPHJBFJM, [In] IHMHECJDOHM HBPECAJBJME, AHJPALFMGKO LHHLFDHKOEB, EDLINIBOMKB DNLBOJJPMPJ, PHOPGFNBODB BEPKODEDCCG, GONIOLOFKAI KLJKEAIEHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x62A18B0", Offset = "0x62A0AB0", VA = "0x1862A18B0")]
	private static string NOHKGPLJAHP(object JFJMICPDNDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0")]
	private static long NLCCOAGHFJM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x81F220", Offset = "0x81E420", VA = "0x18081F220")]
	private static string LHMBIOEAJPP(string ENONAODCGNA, string? IDJMHOBOGAF, bool HBHALENFPLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130")]
	private static bool OOKNMLOJPHM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x62A1620", Offset = "0x62A0820", VA = "0x1862A1620")]
	private static LNKDPKIEHME DBELIIMMINF()
	{
		return default(LNKDPKIEHME);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KENAELPAMIE
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HCKOPCJNBLB LMNDHIIMHIN();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface HCKOPCJNBLB : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool IMBEDCOFPML
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JFIFOAFAFLO();
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface BLODAJINHJK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JLFMJDFPDBJ([In] T NOBJAPGNDAK);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public delegate void LNNFEFJLICC<T>([In] T GFMMLICJDDH);
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct MOFKMOJKBGA<T> : IEquatable<MOFKMOJKBGA<T>>, BLODAJINHJK<MOFKMOJKBGA<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T FJJHODHBEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly int JPDBMMOIFEO;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1E625E0", Offset = "0x1E617E0", VA = "0x181E625E0")]
	public MOFKMOJKBGA([In] T NICEPFIEJED, int HMFNCGHECPG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3F9E900", Offset = "0x3F9DB00", VA = "0x183F9E900")]
	public static bool AIPCENMEJFE([In] MOFKMOJKBGA<T> EBKLEGBLPGD, [In] MOFKMOJKBGA<T> JCPNHMOLDGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3F9EB40", Offset = "0x3F9DD40", VA = "0x183F9EB40", Slot = "4")]
	public bool Equals(MOFKMOJKBGA<T> NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3475920", Offset = "0x3474B20", VA = "0x183475920", Slot = "0")]
	public override bool Equals(object NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3F9F080", Offset = "0x3F9E280", VA = "0x183F9F080")]
	public bool JLFMJDFPDBJ([In] MOFKMOJKBGA<T> NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3F9EFF0", Offset = "0x3F9E1F0", VA = "0x183F9EFF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3F9FC10", Offset = "0x3F9EE10", VA = "0x183F9FC10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3F9F6F0", Offset = "0x3F9E8F0", VA = "0x183F9F6F0")]
	public void NAEOOGIIDLH([Out] T NICEPFIEJED, [Out] int HMFNCGHECPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3F9F100", Offset = "0x3F9E300", VA = "0x183F9F100")]
	public (T, int) LOGPIIKPOON()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3F9FB50", Offset = "0x3F9ED50", VA = "0x183F9FB50", Slot = "5")]
	private bool NIBOGJDIOCC([In] MOFKMOJKBGA<T> NOBJAPGNDAK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class CJCANDACJIK
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2718BC0", Offset = "0x2717DC0", VA = "0x182718BC0")]
	public static MOFKMOJKBGA<T> MIJABIECKKD<T>([In] T NICEPFIEJED, int HMFNCGHECPG) where T : notnull
	{
		return default(MOFKMOJKBGA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class EOFNADFIMHE
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x277EB70", Offset = "0x277DD70", VA = "0x18277EB70")]
	public static bool JLFMJDFPDBJ<T, U>([In] T KNKOEEEKHDK, [In] U JFJMICPDNDH) where T : notnull, BLODAJINHJK<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public delegate TResult LFANHHJKOEG<T, out TResult>([In] T GFMMLICJDDH);
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface GMICDKFFICD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	TimeSpan NKBKECGFNBH
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Action? OJNMIONOIID
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CHNNBJODNMB();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AOKBPAEHIKI();

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FJMPAKPHLPM();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct FCCNDHIDGCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly FMDOCEHMBDJ JHNCOLCPMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly GGIGLDGJJDM HJBOFEOEHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly FMDOCEHMBDJ EFKILJGIJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly GGIGLDGJJDM HJLKLPHNAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly FMDOCEHMBDJ NDBPJGBOMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly GGIGLDGJJDM MKIDNKAMBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly PMDLHBJMHFC HCJKKPNOKCP;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly FMDOCEHMBDJ BKINGHDKJBB;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly GGIGLDGJJDM FCBIPIGLNKA;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly FMDOCEHMBDJ MLKBPIKGCIC;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly GGIGLDGJJDM JJAOCACPGPF;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly FMDOCEHMBDJ CNBEKPFNJFI;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly GGIGLDGJJDM CNGPMDGACDE;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly PMDLHBJMHFC NENMGCKCPMP;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly FCCNDHIDGCJ CLJCIKPCCEE;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly FMDOCEHMBDJ GAGHIIAMPFO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool PPFMDOGEELH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x629D2A0", Offset = "0x629C4A0", VA = "0x18629D2A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x9E3AA0", Offset = "0x9E2CA0", VA = "0x1809E3AA0")]
	public FCCNDHIDGCJ(FMDOCEHMBDJ PPNEDJDPMIO, GGIGLDGJJDM NNPNAIADDDL, FMDOCEHMBDJ BLCLOLGGCML, GGIGLDGJJDM OBAMKLICBIN, FMDOCEHMBDJ GBMAIGKJJHM, GGIGLDGJJDM AMEJEAJMFDF, PMDLHBJMHFC EGGBPILBPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130")]
	private static bool EGIMKMPLBGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
	private static void LDDKINHPABE(string JGNAJPMGGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130")]
	private static bool LKJIPPICNKF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
	private static void AMJJODNKJHL(string JGNAJPMGGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130")]
	private static bool LLFOCLKEKKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
	private static void PFPLFIHIAIE(string JGNAJPMGGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
	private static void PHPPJLFLJOH(Exception PGAHDJGBLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x629D010", Offset = "0x629C210", VA = "0x18629D010")]
	private static FCCNDHIDGCJ DBELIIMMINF()
	{
		return default(FCCNDHIDGCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7CF850", Offset = "0x7CEA50", VA = "0x1807CF850")]
	private static bool FAPJGCJKPBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x629D550", Offset = "0x629C750", VA = "0x18629D550")]
	public void PHDBFKGPBFI(object JGNAJPMGGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x629D230", Offset = "0x629C430", VA = "0x18629D230")]
	public void ENCMOPKOEPF(object JGNAJPMGGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1A3E2D0", Offset = "0x1A3D4D0", VA = "0x181A3E2D0")]
	public void HEHPIJGHGHP(Exception PGAHDJGBLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x629D150", Offset = "0x629C350", VA = "0x18629D150")]
	public void ENCMOPKOEPF(IAGAMIIEFIJ JGNAJPMGGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x28BF070", Offset = "0x28BE270", VA = "0x1828BF070")]
	public void ENCMOPKOEPF<T>(T GFMMLICJDDH, JFIOELPPJOC<T> JGNAJPMGGNE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x28BF130", Offset = "0x28BE330", VA = "0x1828BF130")]
	public void PHDBFKGPBFI<T>([In] T GFMMLICJDDH, KEINDOEAGNC<T> JGNAJPMGGNE) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x629D480", Offset = "0x629C680", VA = "0x18629D480")]
	public bool LBOCOOAPKDJ(bool JOIPJBFGDKM, string JGNAJPMGGNE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct BLKDCPILLAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly string FJJHODHBEGH;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x94F0A0", Offset = "0x94E2A0", VA = "0x18094F0A0")]
	public BLKDCPILLAK(string NICEPFIEJED)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60")]
	public static string LOOIAEAGNBK([In] BLKDCPILLAK KNKOEEEKHDK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x82C970", Offset = "0x82BB70", VA = "0x18082C970")]
	public static BLKDCPILLAK LOOIAEAGNBK(string NOBJAPGNDAK)
	{
		return default(BLKDCPILLAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x629C300", Offset = "0x629B500", VA = "0x18629C300")]
	public string HOECFEAFEJD(string HHFLAHOCOCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x629C220", Offset = "0x629B420", VA = "0x18629C220")]
	public string HHBIMDAPOFF(object FOOMKMLAHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x87DF60", Offset = "0x87D160", VA = "0x18087DF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct LKEAICJEMFK : IEquatable<LKEAICJEMFK>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7CF850", Offset = "0x7CEA50", VA = "0x1807CF850", Slot = "4")]
	public bool Equals(LKEAICJEMFK NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x62A14C0", Offset = "0x62A06C0", VA = "0x1862A14C0", Slot = "0")]
	public override bool Equals(object NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x62A1510", Offset = "0x62A0710", VA = "0x1862A1510", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x62A1520", Offset = "0x62A0720", VA = "0x1862A1520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[HHAPCIPDAID("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct PKNGEFGGMEI<T> : IEquatable<PKNGEFGGMEI<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly T FJJHODHBEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool IAPKCFMLJFK;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool PJFLFJODHON
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x4273CC0", Offset = "0x4272EC0", VA = "0x184273CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4274E20", Offset = "0x4274020", VA = "0x184274E20")]
	public PKNGEFGGMEI([In] T NICEPFIEJED, bool OCNNEGBDAEK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4273CD0", Offset = "0x4272ED0", VA = "0x184273CD0")]
	public static bool AIPCENMEJFE([In] PKNGEFGGMEI<T> EBKLEGBLPGD, [In] PKNGEFGGMEI<T> JCPNHMOLDGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3F9EB40", Offset = "0x3F9DD40", VA = "0x183F9EB40", Slot = "4")]
	public bool Equals(PKNGEFGGMEI<T> NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4274310", Offset = "0x4273510", VA = "0x184274310", Slot = "0")]
	public override bool Equals(object NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x42748F0", Offset = "0x4273AF0", VA = "0x1842748F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4274BA0", Offset = "0x4273DA0", VA = "0x184274BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class DBMAAJEMFBA
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x274A440", Offset = "0x2749640", VA = "0x18274A440")]
	public static PKNGEFGGMEI<T> DGMLOLBNCFA<T>([In] T NICEPFIEJED) where T : notnull
	{
		return default(PKNGEFGGMEI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x274A5C0", Offset = "0x27497C0", VA = "0x18274A5C0")]
	public static PKNGEFGGMEI<T?> LIMNJOMFLKG<T>()
	{
		return default(PKNGEFGGMEI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x274A510", Offset = "0x2749710", VA = "0x18274A510")]
	public static bool LGIAKKNDGFD<T>([In] this PKNGEFGGMEI<T> ECIIPOIONPP, [Out][NotNullWhen(true)] T NICEPFIEJED) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct IHMHECJDOHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly IntPtr EPAMNMMPOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly IntPtr GLMMHBDCOFE;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IntPtr OCMFNOOHKOA;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IntPtr PAGJHNIPCPM;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IHMHECJDOHM CLJCIKPCCEE;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool PPFMDOGEELH
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x629EE80", Offset = "0x629E080", VA = "0x18629EE80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x947190", Offset = "0x946390", VA = "0x180947190")]
	public IHMHECJDOHM(IntPtr BBHPDGEPJBD, IntPtr DEKBACFBOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
	private static void LDHANKFDGGC(string IKEFBMMMAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
	private static void EOGGOFHJMCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x629EDF0", Offset = "0x629DFF0", VA = "0x18629EDF0")]
	private static IHMHECJDOHM DBELIIMMINF()
	{
		return default(IHMHECJDOHM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct AEHEFFNKPNA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IntPtr NOMNNLNAEGO;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x94F0A0", Offset = "0x94E2A0", VA = "0x18094F0A0")]
	private AEHEFFNKPNA(IntPtr DEKBACFBOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x629A460", Offset = "0x6299660", VA = "0x18629A460", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x629A470", Offset = "0x6299670", VA = "0x18629A470")]
	public static AEHEFFNKPNA MIJABIECKKD(string IKEFBMMMAJB)
	{
		return default(AEHEFFNKPNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1E42C10", Offset = "0x1E41E10", VA = "0x181E42C10")]
	public static AEHEFFNKPNA MIJABIECKKD([In] IHMHECJDOHM HBPECAJBJME, string IKEFBMMMAJB)
	{
		return default(AEHEFFNKPNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1E42B40", Offset = "0x1E41D40", VA = "0x181E42B40")]
	public static AEHEFFNKPNA MIJABIECKKD([In] IHMHECJDOHM HBPECAJBJME, Func<string> IKEFBMMMAJB)
	{
		return default(AEHEFFNKPNA);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class ALPEPIFLOLF
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate bool IDJFLNFGEKF<in TInput, TResult>(TInput CCAOJBHBKKC, [Out] TResult HCIDHCBMOPD);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private sealed class OHDLOJMJPLP : KENAELPAMIE
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private sealed class GBNKKGCDJNB : HCKOPCJNBLB, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public static readonly GBNKKGCDJNB KMGHIJMKCHH;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public bool IMBEDCOFPML
			{
				[Cpp2IlInjected.Token(Token = "0x60000B2")]
				[Cpp2IlInjected.Address(RVA = "0x629DBC0", Offset = "0x629CDC0", VA = "0x18629DBC0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x629DC20", Offset = "0x629CE20", VA = "0x18629DC20", Slot = "6")]
			public void OnCompleted(Action HHCGNKKBPNJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "5")]
			public void JFIFOAFAFLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public GBNKKGCDJNB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly OHDLOJMJPLP KMGHIJMKCHH;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		private OHDLOJMJPLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x62A38F0", Offset = "0x62A2AF0", VA = "0x1862A38F0", Slot = "4")]
		public HCKOPCJNBLB LMNDHIIMHIN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private sealed class DKPDPEKENIN : KENAELPAMIE
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private sealed class JMGKDNJHGAC : HCKOPCJNBLB, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly JMGKDNJHGAC KMGHIJMKCHH;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool IMBEDCOFPML
			{
				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x62A0A40", Offset = "0x629FC40", VA = "0x1862A0A40", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x62A0A60", Offset = "0x629FC60", VA = "0x1862A0A60", Slot = "6")]
			public void OnCompleted(Action HHCGNKKBPNJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "5")]
			public void JFIFOAFAFLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public JMGKDNJHGAC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly DKPDPEKENIN KMGHIJMKCHH;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		private DKPDPEKENIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x629CD70", Offset = "0x629BF70", VA = "0x18629CD70", Slot = "4")]
		public HCKOPCJNBLB LMNDHIIMHIN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class HAGCNLPKKPB<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public HAGCNLPKKPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x390BAF0", Offset = "0x390ACF0", VA = "0x18390BAF0")]
		internal void LFKJMAFMDNI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class IJMEFECLOEG<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public IJMEFECLOEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x38BB0A0", Offset = "0x38BA2A0", VA = "0x1838BB0A0")]
		internal void DNDPPPPPOAN(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct KKHCDPLIIDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x62A10F0", Offset = "0x62A02F0", VA = "0x1862A10F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8A5FC0", Offset = "0x8A51C0", VA = "0x1808A5FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct NNHLADBEJNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x62A3450", Offset = "0x62A2650", VA = "0x1862A3450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8A5FC0", Offset = "0x8A51C0", VA = "0x1808A5FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct MBGKCMNEDJM<TException> : IAsyncStateMachine where TException : notnull, Exception
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x3F47D30", Offset = "0x3F46F30", VA = "0x183F47D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x3F47EA0", Offset = "0x3F470A0", VA = "0x183F47EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct FFGHHCEEFDA<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Task<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<T> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x37FAB30", Offset = "0x37F9D30", VA = "0x1837FAB30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x37FAF50", Offset = "0x37FA150", VA = "0x1837FAF50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct LADDEMICGNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Task self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x62A1250", Offset = "0x62A0450", VA = "0x1862A1250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x62A1450", Offset = "0x62A0650", VA = "0x1862A1450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class DFHAKHINKPD<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public TaskCompletionSource<T> taskCompletionSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public DFHAKHINKPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x390BAF0", Offset = "0x390ACF0", VA = "0x18390BAF0")]
		internal void MBLJEIPACFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x51151E0", Offset = "0x51143E0", VA = "0x1851151E0")]
		internal void LLHOACGNIAK(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct HJCDEDPNKIG<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Task<List<TInput>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public IDJFLNFGEKF<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x397CFB0", Offset = "0x397C1B0", VA = "0x18397CFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x397D660", Offset = "0x397C860", VA = "0x18397D660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct JGOCCIFMMHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Func<CancellationToken, Task> innerTaskConstructor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private CancellationTokenSource <innerTaskCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Task <innerTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private TaskAwaiter<TaskStatus> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x629F350", Offset = "0x629E550", VA = "0x18629F350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x629FB40", Offset = "0x629ED40", VA = "0x18629FB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct KCKIIMILBHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Func<CancellationToken, Task> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x62A0B50", Offset = "0x629FD50", VA = "0x1862A0B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x62A1090", Offset = "0x62A0290", VA = "0x1862A1090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct HHOGMIDIBPC<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Func<CancellationToken, Task<T>> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Func<OperationCanceledException, T> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3923430", Offset = "0x3922630", VA = "0x183923430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x39242D0", Offset = "0x39234D0", VA = "0x1839242D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct BKHNELEHBCB<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder<IEnumerable<Task<T>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public IEnumerable<Task<T>> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private Task<T>[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x48A7170", Offset = "0x48A6370", VA = "0x1848A7170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x38A7C20", Offset = "0x38A6E20", VA = "0x1838A7C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct KIAMEGOCAAN<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<(T1, T2, T3, T4)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Task<T4> task4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3C938D0", Offset = "0x3C92AD0", VA = "0x183C938D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3C93FA0", Offset = "0x3C931A0", VA = "0x183C93FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct HMODAPDAIBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x629E7F0", Offset = "0x629D9F0", VA = "0x18629E7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x629E9D0", Offset = "0x629DBD0", VA = "0x18629E9D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct MJPBCDKMKKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x62A2420", Offset = "0x62A1620", VA = "0x1862A2420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x62A2780", Offset = "0x62A1980", VA = "0x1862A2780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct IDBABFLMCGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x629EA30", Offset = "0x629DC30", VA = "0x18629EA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x629ED20", Offset = "0x629DF20", VA = "0x18629ED20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class HCHBEOFHDOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public HCHBEOFHDOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x629E780", Offset = "0x629D980", VA = "0x18629E780")]
		internal Task GAFBEFJKPIJ(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct JCEJAKOHGAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x629F090", Offset = "0x629E290", VA = "0x18629F090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x629F2F0", Offset = "0x629E4F0", VA = "0x18629F2F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct PDMPBCJICHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x62A39B0", Offset = "0x62A2BB0", VA = "0x1862A39B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x62A3B90", Offset = "0x62A2D90", VA = "0x1862A3B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct MGAJMLMPPNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x62A2060", Offset = "0x62A1260", VA = "0x1862A2060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x62A23C0", Offset = "0x62A15C0", VA = "0x1862A23C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct NFBJLPCJOPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x62A3100", Offset = "0x62A2300", VA = "0x1862A3100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x62A33F0", Offset = "0x62A25F0", VA = "0x1862A33F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class IDBMLHNHPBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public IDBMLHNHPBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x629ED80", Offset = "0x629DF80", VA = "0x18629ED80")]
		internal Task KFENDBOHAPN(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct GEELABCHEIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x629DDE0", Offset = "0x629CFE0", VA = "0x18629DDE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x629E040", Offset = "0x629D240", VA = "0x18629E040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct DMMBMANGKMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x629CE30", Offset = "0x629C030", VA = "0x18629CE30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x629CFB0", Offset = "0x629C1B0", VA = "0x18629CFB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct KJOCFFIFINC<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public Action<T> then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3C99B30", Offset = "0x3C98D30", VA = "0x183C99B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3C99D80", Offset = "0x3C98F80", VA = "0x183C99D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct PKFBNNKCILG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Func<Task> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private object <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x62A3CF0", Offset = "0x62A2EF0", VA = "0x1862A3CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x62A4100", Offset = "0x62A3300", VA = "0x1862A4100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private static SynchronizationContext? HLAMOPMHMOK;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly TaskCompletionSource<LKEAICJEMFK> LGGBPCFNLEP;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static Task AKGJLPLEHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x629BE10", Offset = "0x629B010", VA = "0x18629BE10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x629B8A0", Offset = "0x629AAA0", VA = "0x18629B8A0")]
	public static bool NDNNNMFLMOL(this Task OCAKELEHPCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2F149F0", Offset = "0x2F13BF0", VA = "0x182F149F0")]
	public static Task<T> HMGAELHCFAG<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x629B160", Offset = "0x629A360", VA = "0x18629B160")]
	public static Task ILIMNMNJNNM(this Task OCAKELEHPCL, CancellationToken FCKLPDKGPKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2F15B90", Offset = "0x2F14D90", VA = "0x182F15B90")]
	public static Task<TResult> ILIMNMNJNNM<TResult>(this Task<TResult> OCAKELEHPCL, CancellationToken FCKLPDKGPKE) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2F15E50", Offset = "0x2F15050", VA = "0x182F15E50")]
	public static TaskCompletionSource<TResult> ILIMNMNJNNM<TResult>(this TaskCompletionSource<TResult> MECAMIGLBGF, CancellationToken FCKLPDKGPKE) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x629A960", Offset = "0x6299B60", VA = "0x18629A960")]
	public static IDisposable? DNBFLPJALHE(CancellationToken ALPMJMAKGMO, CancellationToken CFDDMGMCCIK, [Out] CancellationToken COLHGPJMLBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x629BC30", Offset = "0x629AE30", VA = "0x18629BC30")]
	[AsyncStateMachine(typeof(KKHCDPLIIDK))]
	public static void ODEFGHAHMFL(this Task MOAGOANMCEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x629AB70", Offset = "0x6299D70", VA = "0x18629AB70")]
	[AsyncStateMachine(typeof(NNHLADBEJNK))]
	public static void FONBILJKKAA(this Task MOAGOANMCEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2F17DB0", Offset = "0x2F16FB0", VA = "0x182F17DB0")]
	[AsyncStateMachine(typeof(MBGKCMNEDJM<>))]
	public static Task NPGLJPOAAPO<TException>(this Task MOAGOANMCEN) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2F17BF0", Offset = "0x2F16DF0", VA = "0x182F17BF0")]
	[AsyncStateMachine(typeof(FFGHHCEEFDA<>))]
	public static Task<T> LHIGFAOKGJB<T>(this Task<T> KNKOEEEKHDK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x629B7B0", Offset = "0x629A9B0", VA = "0x18629B7B0")]
	[AsyncStateMachine(typeof(LADDEMICGNB))]
	public static Task<TaskStatus> LNDHANLBAFC(this Task KNKOEEEKHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2F144F0", Offset = "0x2F136F0", VA = "0x182F144F0")]
	public static (Task<T?>?, Action<T?>?) DPPAPBGBKJF<T>([Optional] CancellationToken AIHJHMPAHCH)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2F14730", Offset = "0x2F13930", VA = "0x182F14730")]
	[AsyncStateMachine(typeof(HJCDEDPNKIG<, >))]
	public static Task<List<TResult>> ECKAKCLCKJE<TResult, TInput>(this Task<List<TInput>> OCAKELEHPCL, IDJFLNFGEKF<TInput, TResult> BCJIIIGNBMI) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x629B400", Offset = "0x629A600", VA = "0x18629B400")]
	[AsyncStateMachine(typeof(JGOCCIFMMHP))]
	public static Task JHDOCCPILIO(Task MOAGOANMCEN, CancellationToken OJHIOEGMMDB, Func<CancellationToken, Task> EIMMMLMBLPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x629BCE0", Offset = "0x629AEE0", VA = "0x18629BCE0")]
	[AsyncStateMachine(typeof(KCKIIMILBHD))]
	public static Task OGEBDGKGPFC(Func<CancellationToken, Task> GEHIKDCONBI, TimeSpan JGOFHIIJIIA, [Optional] CancellationToken OJHIOEGMMDB, [Optional] Action<OperationCanceledException>? MLFHPBEJOPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2F17E80", Offset = "0x2F17080", VA = "0x182F17E80")]
	[AsyncStateMachine(typeof(HHOGMIDIBPC<>))]
	public static Task<T> OGEBDGKGPFC<T>(Func<CancellationToken, Task<T>> GEHIKDCONBI, TimeSpan JGOFHIIJIIA, [Optional] CancellationToken OJHIOEGMMDB, [Optional] Func<OperationCanceledException, T>? MLFHPBEJOPH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2F14910", Offset = "0x2F13B10", VA = "0x182F14910")]
	[AsyncStateMachine(typeof(BKHNELEHBCB<>))]
	public static Task<IEnumerable<Task<T>>> GHBNIFIONFB<T>(IEnumerable<Task<T>> GPIDFBGICGI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2F17950", Offset = "0x2F16B50", VA = "0x182F17950")]
	[AsyncStateMachine(typeof(KIAMEGOCAAN<, , , >))]
	public static Task<(T1, T2, T3, T4)> KJLKNJHLHJG<T1, T2, T3, T4>(Task<T1> FGPLCIAAMLF, Task<T2> NOENFMBMIHI, Task<T3> KNLFFBKKLNG, Task<T4> CHGJDCFGGLF) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x629B640", Offset = "0x629A840", VA = "0x18629B640")]
	[AsyncStateMachine(typeof(HMODAPDAIBP))]
	public static Task JJKJFKENNNF(Func<bool> JOIPJBFGDKM, [Optional] CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x629B530", Offset = "0x629A730", VA = "0x18629B530")]
	[AsyncStateMachine(typeof(MJPBCDKMKKF))]
	public static Task JJKJFKENNNF(Func<bool> JOIPJBFGDKM, TimeSpan PIBIDIPJHAK, [Optional] CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x629A830", Offset = "0x6299A30", VA = "0x18629A830")]
	[AsyncStateMachine(typeof(IDBABFLMCGI))]
	public static Task CNHPDDDGJLM(Func<bool> JOIPJBFGDKM, TimeSpan JGOFHIIJIIA, [Optional] CancellationToken AIHJHMPAHCH, [Optional] Action<OperationCanceledException>? MLFHPBEJOPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x629A6F0", Offset = "0x62998F0", VA = "0x18629A6F0")]
	[AsyncStateMachine(typeof(JCEJAKOHGAC))]
	public static Task CNHPDDDGJLM(Func<bool> JOIPJBFGDKM, TimeSpan JGOFHIIJIIA, TimeSpan PIBIDIPJHAK, [Optional] CancellationToken AIHJHMPAHCH, [Optional] Action<OperationCanceledException>? MLFHPBEJOPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x629AFA0", Offset = "0x629A1A0", VA = "0x18629AFA0")]
	[AsyncStateMachine(typeof(PDMPBCJICHO))]
	public static Task HPDOGAPIGNP(Func<bool> JOIPJBFGDKM, [Optional] CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x629AE90", Offset = "0x629A090", VA = "0x18629AE90")]
	[AsyncStateMachine(typeof(MGAJMLMPPNL))]
	public static Task HPDOGAPIGNP(Func<bool> JOIPJBFGDKM, TimeSpan PIBIDIPJHAK, [Optional] CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x629AD60", Offset = "0x6299F60", VA = "0x18629AD60")]
	[AsyncStateMachine(typeof(NFBJLPCJOPJ))]
	public static Task HMLGPBPEDFI(Func<bool> JOIPJBFGDKM, TimeSpan JGOFHIIJIIA, [Optional] CancellationToken AIHJHMPAHCH, [Optional] Action<OperationCanceledException>? MLFHPBEJOPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x629AC20", Offset = "0x6299E20", VA = "0x18629AC20")]
	[AsyncStateMachine(typeof(GEELABCHEIA))]
	public static Task HMLGPBPEDFI(Func<bool> JOIPJBFGDKM, TimeSpan JGOFHIIJIIA, TimeSpan PIBIDIPJHAK, [Optional] CancellationToken AIHJHMPAHCH, [Optional] Action<OperationCanceledException>? MLFHPBEJOPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x629A550", Offset = "0x6299750", VA = "0x18629A550")]
	[Obsolete]
	[AsyncStateMachine(typeof(DMMBMANGKMB))]
	public static Task BHHONJFOBNL(this Task OCAKELEHPCL, Action PIKANKGGKCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2F14400", Offset = "0x2F13600", VA = "0x182F14400")]
	[Obsolete]
	[AsyncStateMachine(typeof(KJOCFFIFINC<>))]
	public static Task BHHONJFOBNL<T>(this Task<T> OCAKELEHPCL, Action<T> PIKANKGGKCA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x629A640", Offset = "0x6299840", VA = "0x18629A640")]
	private static void BHLLACNCION()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x629B8D0", Offset = "0x629AAD0", VA = "0x18629B8D0")]
	public static bool NECKNGJONIA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x629BFE0", Offset = "0x629B1E0", VA = "0x18629BFE0")]
	private static void PCHIIMMFOFE(SynchronizationContext NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x629BE80", Offset = "0x629B080", VA = "0x18629BE80")]
	private static void OKNPIJBODAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x629B090", Offset = "0x629A290", VA = "0x18629B090")]
	public static void IBEFCANJLOD([Optional] string? JGNAJPMGGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x629B730", Offset = "0x629A930", VA = "0x18629B730")]
	public static void JKKHFBDADJC([Optional] string? JGNAJPMGGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x629B3B0", Offset = "0x629A5B0", VA = "0x18629B3B0")]
	public static KENAELPAMIE JEEFONOHLJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x629BF90", Offset = "0x629B190", VA = "0x18629BF90")]
	public static KENAELPAMIE PAHPFGLDHLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x629AAA0", Offset = "0x6299CA0", VA = "0x18629AAA0")]
	[AsyncStateMachine(typeof(PKFBNNKCILG))]
	public static Task EDIDFFFIBDG(Func<Task> MGNENKLDBLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class PJKEGBNMNOG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
	public PJKEGBNMNOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class CABMDFOEAFH : DMEKHIFJEEK
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public static readonly DMEKHIFJEEK KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DateTime GNMEBJCOCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x629C350", Offset = "0x629B550", VA = "0x18629C350", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTimeOffset NCBKGBCGEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x629C390", Offset = "0x629B590", VA = "0x18629C390", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public CABMDFOEAFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface DMEKHIFJEEK
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DateTime GNMEBJCOCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTimeOffset NCBKGBCGEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class NCJEHLBPIHL
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static long FIDKMGAPHNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x62A2960", Offset = "0x62A1B60", VA = "0x1862A2960")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long DLKAOFMKPID
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x62A2870", Offset = "0x62A1A70", VA = "0x1862A2870")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double HGBDFCJOKLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x62A2CA0", Offset = "0x62A1EA0", VA = "0x1862A2CA0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double OCMLKGDANEC
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x62A2C50", Offset = "0x62A1E50", VA = "0x1862A2C50")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double GIDHMKJMCGC
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x62A2B70", Offset = "0x62A1D70", VA = "0x1862A2B70")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double FGKGNDAIIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x62A2CF0", Offset = "0x62A1EF0", VA = "0x1862A2CF0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x62A2BC0", Offset = "0x62A1DC0", VA = "0x1862A2BC0")]
	public static double GFJLGPIGABC(long DKOHHNIDLKJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x62A29B0", Offset = "0x62A1BB0", VA = "0x1862A29B0")]
	public static double EHECKKHNICA(long DKOHHNIDLKJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x62A27E0", Offset = "0x62A19E0", VA = "0x1862A27E0")]
	public static double ACMPOECNDHB(double JADAPJGFJDM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x62A28C0", Offset = "0x62A1AC0", VA = "0x1862A28C0")]
	public static long BBLEIKEPCJN(long IJJNDFLLAHB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x62A2950", Offset = "0x62A1B50", VA = "0x1862A2950")]
	public static long CCMNEGGNBEL(long IPCACOJONHL, long ENAJNGMFDHC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x62A2AA0", Offset = "0x62A1CA0", VA = "0x1862A2AA0")]
	public static double ENFDHBEIIMH(long IPCACOJONHL, long ENAJNGMFDHC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x62A2A40", Offset = "0x62A1C40", VA = "0x1862A2A40")]
	public static double ENEDIHIEADM(long IPCACOJONHL, long ENAJNGMFDHC)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public sealed class GENMJDHDNHC : GMICDKFFICD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static readonly TimeSpan PELLHOOKOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly System.Timers.Timer NEKANGAICOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private TimeSpan JGOFHIIJIIA;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public TimeSpan NKBKECGFNBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x629E300", Offset = "0x629D500", VA = "0x18629E300", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public Action? OJNMIONOIID
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7B6300", Offset = "0x7B5500", VA = "0x1807B6300", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x629E720", Offset = "0x629D920", VA = "0x18629E720")]
	[Preserve]
	public GENMJDHDNHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x629E4D0", Offset = "0x629D6D0", VA = "0x18629E4D0")]
	public GENMJDHDNHC(TimeSpan JGOFHIIJIIA, [Optional] Action? KBCIEINEFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x629E110", Offset = "0x629D310", VA = "0x18629E110", Slot = "7")]
	public void CHNNBJODNMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x629E0A0", Offset = "0x629D2A0", VA = "0x18629E0A0", Slot = "8")]
	public void AOKBPAEHIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x629E2D0", Offset = "0x629D4D0", VA = "0x18629E2D0", Slot = "9")]
	public void FJMPAKPHLPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0xC41AF0", Offset = "0xC40CF0", VA = "0x180C41AF0")]
	private void NHNAGIAOECG(object PMBMOONGPPJ, ElapsedEventArgs JMAPLMLMPMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x629E1A0", Offset = "0x629D3A0", VA = "0x18629E1A0")]
	private static void CONMFHHKFIH(TimeSpan MIKBDFBINAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x629E230", Offset = "0x629D430", VA = "0x18629E230", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class HHAPCIPDAID : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly string? OJFJNJIEFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public readonly string AEEKODOKDJA;

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5D902B0", Offset = "0x5D8F4B0", VA = "0x185D902B0")]
	public HHAPCIPDAID(string ALPNBPOHMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A3C0", Offset = "0x3B095C0", VA = "0x183B0A3C0")]
	public HHAPCIPDAID(string NOPGIOBJJNI, string ALPNBPOHMCC)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct JGPKAMILINE : IEquatable<JGPKAMILINE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public uint GDLPBGLHICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public int MGFBJBIOKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public float DBBPIFDENFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public ushort HNDJPJLKBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public ushort OEGPDLLKPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public short EGNLHLAOGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public short JFFKNDHAKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public char OFAANPODCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public char BEHCHGLKKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte ABAOONGDDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public byte GAEFKCLCGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte LPDACPALNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public byte BILNCPBHJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public bool ABDMHDOFPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public bool PCPEKEDNHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool LMBINGFOICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public bool HFCMMDDODFA;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0xD64C80", Offset = "0xD63E80", VA = "0x180D64C80")]
	public static JGPKAMILINE DCLCBNBCCCL(uint KFAHLPLDGPG)
	{
		return default(JGPKAMILINE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xD64C80", Offset = "0xD63E80", VA = "0x180D64C80")]
	public static JGPKAMILINE LHJLKBANEDF(int ELDHCKMABGJ)
	{
		return default(JGPKAMILINE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x629FC40", Offset = "0x629EE40", VA = "0x18629FC40")]
	public static JGPKAMILINE LIHHKJEILMI(float NKCKECLHMAD)
	{
		return default(JGPKAMILINE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x629FBA0", Offset = "0x629EDA0", VA = "0x18629FBA0")]
	public static JGPKAMILINE PHHINBNMGGP(byte IEIBNPCPNEN, byte ONCOHIBLNKD, byte BAJJBEDFKAG, byte PNIIAACJHIO)
	{
		return default(JGPKAMILINE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x629FBA0", Offset = "0x629EDA0", VA = "0x18629FBA0")]
	public static JGPKAMILINE MHKHENBKHLA(bool PBLDPJPGNNH, bool MHPGHOJBGOP, bool BEAKJCDHBGG, bool DGFKIEHBKLO)
	{
		return default(JGPKAMILINE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x629FBA0", Offset = "0x629EDA0", VA = "0x18629FBA0")]
	public static JGPKAMILINE DBFCGOMANOO(byte BGLIEENJDMA, byte HHCGBFJFACE, byte AAEMNMGANJA, byte IMMDCBNMDBP)
	{
		return default(JGPKAMILINE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x18A2530", Offset = "0x18A1730", VA = "0x1818A2530")]
	public static bool AIPCENMEJFE(JGPKAMILINE EFLJLNCMHDD, JGPKAMILINE DJDKOLONKNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x8A5400", Offset = "0x8A4600", VA = "0x1808A5400", Slot = "4")]
	public bool Equals(JGPKAMILINE NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x629FBC0", Offset = "0x629EDC0", VA = "0x18629FBC0", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x94C1B0", Offset = "0x94B3B0", VA = "0x18094C1B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x629FC50", Offset = "0x629EE50", VA = "0x18629FC50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct FPIAIBIFPHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public ulong NPDLHDGNBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public long IOMNNDOHMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public double IJOEBNKBDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint MAGGELHFFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint CLALKIBAGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public int FHNBNJGGMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public int KOEAHHFNBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public float BBJPLEEEAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public float KJAOJPKOKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public ushort HNDJPJLKBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public ushort OEGPDLLKPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort JEAIEEENKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public ushort LPEOCGMAKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public short EGNLHLAOGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public short JFFKNDHAKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public short NONGBJFGOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public short JKKAAIMPAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public char OFAANPODCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public char BEHCHGLKKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public char FOCCBIHJFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public char IDHOBOGIOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public byte ABAOONGDDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public byte GAEFKCLCGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public byte LPDACPALNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public byte BILNCPBHJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte BFKKHJMFEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte BEKENPKOJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte BMHLGLBNJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte HPOHBHDKCDJ;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x629DB70", Offset = "0x629CD70", VA = "0x18629DB70")]
	public static FPIAIBIFPHG MIJABIECKKD(byte IEIBNPCPNEN, byte ONCOHIBLNKD, byte BAJJBEDFKAG, byte PNIIAACJHIO, byte KEGKJGKODMF, byte DELFKJIEAIE, byte LALCNHPOGCL, byte DFGEGHGONFC)
	{
		return default(FPIAIBIFPHG);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct OCAONNGBMMO : IEquatable<OCAONNGBMMO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public byte EMLCKPDDNLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public bool FPGACJPDAAP;

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x23B22D0", Offset = "0x23B14D0", VA = "0x1823B22D0")]
	public static OCAONNGBMMO PHHINBNMGGP(byte DNLCABBEPBL)
	{
		return default(OCAONNGBMMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x23B22D0", Offset = "0x23B14D0", VA = "0x1823B22D0")]
	public static OCAONNGBMMO MHKHENBKHLA(bool OPKLDDNNKGH)
	{
		return default(OCAONNGBMMO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x62A35E0", Offset = "0x62A27E0", VA = "0x1862A35E0")]
	public static bool AIPCENMEJFE(OCAONNGBMMO EFLJLNCMHDD, OCAONNGBMMO DJDKOLONKNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x54CFEA0", Offset = "0x54CF0A0", VA = "0x1854CFEA0", Slot = "4")]
	public bool Equals(OCAONNGBMMO NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x62A35F0", Offset = "0x62A27F0", VA = "0x1862A35F0", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x62A3680", Offset = "0x62A2880", VA = "0x1862A3680", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x62A3690", Offset = "0x62A2890", VA = "0x1862A3690", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class MOALEMIKKNP<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public readonly T GDEIHLMIBKK;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3F9D8B0", Offset = "0x3F9CAB0", VA = "0x183F9D8B0")]
	public MOALEMIKKNP(T HNJKNBMJEBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class GGPANMFLOEP
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x26BC140", Offset = "0x26BB340", VA = "0x1826BC140")]
	public static IEnumerable<T> JLNLKKPDLPJ<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x81F220", Offset = "0x81E420", VA = "0x18081F220")]
	public static T[] EFEFIKJBJKC<T>(params T[] KNFDIPFDPAA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x81F220", Offset = "0x81E420", VA = "0x18081F220")]
	public static IEnumerable<T> OGLMMDMEAGG<T>(params T[] KNFDIPFDPAA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x271FBA0", Offset = "0x271EDA0", VA = "0x18271FBA0")]
	public static HashSet<T> MNNPOOJPDHA<T>(params T[] KNFDIPFDPAA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x28E3FD0", Offset = "0x28E31D0", VA = "0x1828E3FD0")]
	public static KeyValuePair<TKey, TValue> ENPCMBFLADB<TKey, TValue>([In] TKey GOBGGNLGONA, [In] TValue NICEPFIEJED) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x271FBA0", Offset = "0x271EDA0", VA = "0x18271FBA0")]
	public static List<T> PBMNMIHALEF<T>(IEnumerable<T> NOIICBHICIJ) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[AttributeUsage(AttributeTargets.All)]
public sealed class JFKICBKCEJP : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public readonly string GAMDPGKPMPK;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7DF880", Offset = "0x7DEA80", VA = "0x1807DF880")]
	public JFKICBKCEJP(string LKEJHNGNLDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public delegate object KEINDOEAGNC<T>([In] T JPEJCADBOCG);
[Cpp2IlInjected.Token(Token = "0x2000056")]
public delegate object JFIOELPPJOC<T>(T JPEJCADBOCG);
[Cpp2IlInjected.Token(Token = "0x2000057")]
[MOPDLKLMCFN]
public delegate string PHOPGFNBODB(string ENONAODCGNA, string? IDJMHOBOGAF, bool HBHALENFPLC);
[Cpp2IlInjected.Token(Token = "0x2000058")]
[MOPDLKLMCFN]
public delegate void GGIGLDGJJDM(string JGNAJPMGGNE);
[Cpp2IlInjected.Token(Token = "0x2000059")]
[MOPDLKLMCFN]
public delegate void PMDLHBJMHFC(Exception PGAHDJGBLJL);
[Cpp2IlInjected.Token(Token = "0x200005A")]
public delegate object IAGAMIIEFIJ();
[Cpp2IlInjected.Token(Token = "0x200005B")]
[MOPDLKLMCFN]
public delegate bool FMDOCEHMBDJ();
[Cpp2IlInjected.Token(Token = "0x200005C")]
[MOPDLKLMCFN]
public delegate string AHJPALFMGKO(object JFJMICPDNDH);
[Cpp2IlInjected.Token(Token = "0x200005D")]
[AttributeUsage(AttributeTargets.Enum)]
public class GKPMKMIOBBA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
	public GKPMKMIOBBA()
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
