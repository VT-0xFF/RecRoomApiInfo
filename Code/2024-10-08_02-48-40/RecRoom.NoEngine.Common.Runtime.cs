using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
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
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6D40FD0", Offset = "0x6D401D0", VA = "0x186D40FD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C0750", Offset = "0x8BF950", VA = "0x1808C0750")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8C0790", Offset = "0x8BF990", VA = "0x1808C0790")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CEPMMBGLHEC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6D37A30", Offset = "0x6D36C30", VA = "0x186D37A30")]
	public static string NGJGIFGOJDN(this Encoding NEDNJMOLOCO, [In] ReadOnlySequence<byte> IFEDAAIOIBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2C1F890", Offset = "0x2C1EA90", VA = "0x182C1F890")]
	private static void KJGAMONAMIP<T>(this ReadOnlySequence<T> MNKOLJPGIAD, [Out] ReadOnlySpan<T> DPBNICKABAM, [Out] SequencePosition MMJCFLDNHIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class PGNNGBNGIHD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6D41D30", Offset = "0x6D40F30", VA = "0x186D41D30")]
	public PGNNGBNGIHD(bool MJHPEKMNLJH, string NKEGCBEKKGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HJHPICDNPDN
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MCOAPOCCKEB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FBFPLABMDCL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BKGIKCEOMLL(string CPBLLDDDHEE, double JECHHBGMFLN, [Optional] string? PFKBDLGCLDN);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FBGOBAKECMC<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate Task<TResult> CGIGKIPFELK(CancellationToken DDNLBFLLCLM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct NEIKBMPIBBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public FBGOBAKECMC<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public CGIGKIPFELK taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private TaskCompletionSource<TResult> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private CancellationTokenSource <runningCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4828960", Offset = "0x4827B60", VA = "0x184828960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4829A20", Offset = "0x4828C20", VA = "0x184829A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CancellationTokenSource MOPJKINAACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CancellationTokenSource? POACNCHGEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private TaskCompletionSource<TResult>? IBHBFJFCIDO;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3E67CD0", Offset = "0x3E66ED0", VA = "0x183E67CD0")]
	[AsyncStateMachine(typeof(FBGOBAKECMC<>.NEIKBMPIBBH))]
	public Task<TResult> GLIGMDNICHN(CGIGKIPFELK DMGDJNOAFFD, [Optional] CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3E67C60", Offset = "0x3E66E60", VA = "0x183E67C60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3E67E10", Offset = "0x3E67010", VA = "0x183E67E10")]
	public FBGOBAKECMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class CJNIJGLMFOJ<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static readonly EqualityComparer<T> ODDKFGKCGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public T GOGBANOMEKC;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x47BD8B0", Offset = "0x47BCAB0", VA = "0x1847BD8B0")]
	public CJNIJGLMFOJ([In] T JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x57C52A0", Offset = "0x57C44A0", VA = "0x1857C52A0", Slot = "0")]
	public override bool Equals(object JMJAOKJJFGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x57C58D0", Offset = "0x57C4AD0", VA = "0x1857C58D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x57C5A60", Offset = "0x57C4C60", VA = "0x1857C5A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class DKLODKGGJGD
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2C25AD0", Offset = "0x2C24CD0", VA = "0x182C25AD0")]
	public static CJNIJGLMFOJ<T> MIFIOLMMIDE<T>([In] T JECHHBGMFLN) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GABGMAEOKJM
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6D3D110", Offset = "0x6D3C310", VA = "0x186D3D110")]
	public static void MDEBJEDGJJK(this CancellationTokenSource MOPJKINAACG, bool NDMOIINMEBH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class BNNEFMKMFDK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
	public BNNEFMKMFDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class EFPNGMIACCF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
	public EFPNGMIACCF(string JDMJEELPMDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class LNFAMOMBGEL
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2EF7780", Offset = "0x2EF6980", VA = "0x182EF7780")]
	public static AEIPCCBKKNC ONGPOMOLBNJ<T>()
	{
		return default(AEIPCCBKKNC);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2EF74B0", Offset = "0x2EF66B0", VA = "0x182EF74B0")]
	public static AEIPCCBKKNC ECOKNHHNNNF<T>([CallerMemberName] string EPPPGDEIJCI = "") where T : notnull
	{
		return default(AEIPCCBKKNC);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2EF7700", Offset = "0x2EF6900", VA = "0x182EF7700")]
	public static AEIPCCBKKNC ONGPOMOLBNJ<T>(this T JNLAAHCIJJI) where T : notnull
	{
		return default(AEIPCCBKKNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2EF7310", Offset = "0x2EF6510", VA = "0x182EF7310")]
	public static AEIPCCBKKNC DPNBHPELCIO<T>(this T JNLAAHCIJJI, [CallerMemberName] string EPPPGDEIJCI = "") where T : notnull
	{
		return default(AEIPCCBKKNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2EF7550", Offset = "0x2EF6750", VA = "0x182EF7550")]
	public static AEIPCCBKKNC ECOKNHHNNNF<T>(this T AEFKHDNCNFD, [CallerMemberName] string EPPPGDEIJCI = "") where T : notnull
	{
		return default(AEIPCCBKKNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6D3F7E0", Offset = "0x6D3E9E0", VA = "0x186D3F7E0")]
	public static AEIPCCBKKNC ECOKNHHNNNF(string JEEEJJDOLAK, [CallerMemberName] string EPPPGDEIJCI = "")
	{
		return default(AEIPCCBKKNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6D3F860", Offset = "0x6D3EA60", VA = "0x186D3F860")]
	public static string KPAIIIKMFJD(this object AEFKHDNCNFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate bool JFFFMNBPNCF();
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BNNEFMKMFDK]
public delegate long FFBAADFDENM();
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class ODIFMANOOBC
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static GGKIOICJJJL IAMDDCGEIBF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static GGKIOICJJJL MNLNFDEJDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6D416A0", Offset = "0x6D408A0", VA = "0x186D416A0")]
		get
		{
			return default(GGKIOICJJJL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static HKKDANEFDJO CKHLOPKNDPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6D41570", Offset = "0x6D40770", VA = "0x186D41570")]
		get
		{
			return default(HKKDANEFDJO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static DCEFINLNIIK PFHGNCOOOEM
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6D410C0", Offset = "0x6D402C0", VA = "0x186D410C0")]
		get
		{
			return default(DCEFINLNIIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool IANEJOEMAKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6D41630", Offset = "0x6D40830", VA = "0x186D41630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6D41260", Offset = "0x6D40460", VA = "0x186D41260")]
	public static void DJMNHMDGNFF([In] GGKIOICJJJL DIKDMEOBPAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6D41800", Offset = "0x6D40A00", VA = "0x186D41800")]
	public static void OBPAMGBPHCN(string ADNFLGLLNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6D414A0", Offset = "0x6D406A0", VA = "0x186D414A0")]
	public static void DLPKEHPJALN(string ADNFLGLLNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2FA98B0", Offset = "0x2FA8AB0", VA = "0x182FA98B0")]
	public static void DLPKEHPJALN<T>(T LFMCCJGKEKP, INPKHEDLAIO<T> ADNFLGLLNKI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6D416F0", Offset = "0x6D408F0", VA = "0x186D416F0")]
	public static void JOMMAGOJOKG(Exception JIAKIFPLAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6D411E0", Offset = "0x6D403E0", VA = "0x186D411E0")]
	public static void CFLFIIBOOKG(string EPPPGDEIJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6D41050", Offset = "0x6D40250", VA = "0x186D41050")]
	public static void ACJJBDLNOMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6D41790", Offset = "0x6D40990", VA = "0x186D41790")]
	public static string KPAIIIKMFJD(object JMJAOKJJFGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6D415C0", Offset = "0x6D407C0", VA = "0x186D415C0")]
	public static long HFHHALKOOMG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6D41400", Offset = "0x6D40600", VA = "0x186D41400")]
	public static bool DLOEPNOBKCN(bool MLDFEJJHIJL, string ADNFLGLLNKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6D41110", Offset = "0x6D40310", VA = "0x186D41110")]
	public static double BHAFMAAPCNM()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct GGKIOICJJJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly HKKDANEFDJO CKHLOPKNDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly DCEFINLNIIK PFHGNCOOOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly DGLDPCGFDPJ JEDOMBMFJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly FFBAADFDENM EFACAEFIDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly JOELALKCDID CNICDONIAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly JFFFMNBPNCF DIJHJLFJKCH;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly DGLDPCGFDPJ IOIJEMKLGJN;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly FFBAADFDENM GKGEKBKNACL;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly JOELALKCDID JGBMBFCGNEL;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly JFFFMNBPNCF JHGOKLPAADP;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly GGKIOICJJJL NPJAAMJGCPB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool IDJFCBEKMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6D3D5D0", Offset = "0x6D3C7D0", VA = "0x186D3D5D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6D3DE20", Offset = "0x6D3D020", VA = "0x186D3DE20")]
	public GGKIOICJJJL([In] HKKDANEFDJO NFIEFMKBGEC, [In] DCEFINLNIIK MIKKCMCLECI, DGLDPCGFDPJ GIPAPECDFFC, FFBAADFDENM PLPKAHJMGEH, JOELALKCDID IPMLMDBGNIG, JFFFMNBPNCF EGDDMJCKPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6D3D590", Offset = "0x6D3C790", VA = "0x186D3D590")]
	private static string IFBEAJOCICK(object JMJAOKJJFGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8966C0", Offset = "0x8958C0", VA = "0x1808966C0")]
	private static long BBGOOEJCLLF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x9964B0", Offset = "0x9956B0", VA = "0x1809964B0")]
	private static string PCHDIELCPOE(string JGFIBJEOOPG, string? AHJMNOJALCD, bool IGHBGMHAPHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80")]
	private static bool HFAPMFJEIFM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6D3D490", Offset = "0x6D3C690", VA = "0x186D3D490")]
	private static GGKIOICJJJL IEPOMPIJIGB()
	{
		return default(GGKIOICJJJL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface MDNIBCKFOLA
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OBJNJPNIMAN KHBMABMNGIM();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OBJNJPNIMAN : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool CMCDJGBNDPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LNBNKFJNAAJ();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface OKLAGBJBBOM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NFOFFGFCKAM([In] T KDHPJMADEAD);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate void NIBPMDFKJLL<T>([In] T LFMCCJGKEKP);
[Cpp2IlInjected.Token(Token = "0x200001B")]
public readonly struct EKGPGPMNKDF<T> : IEquatable<EKGPGPMNKDF<T>>, OKLAGBJBBOM<EKGPGPMNKDF<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T GOGBANOMEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly int NLHHONDOFEE;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x221FCA0", Offset = "0x221EEA0", VA = "0x18221FCA0")]
	public EKGPGPMNKDF([In] T JECHHBGMFLN, int KINMHNEMPOD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3AE0010", Offset = "0x3ADF210", VA = "0x183AE0010")]
	public static bool IELJJBKMIFI([In] EKGPGPMNKDF<T> PCICJLNHPMM, [In] EKGPGPMNKDF<T> OIJJJJFPNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3ADF890", Offset = "0x3ADEA90", VA = "0x183ADF890", Slot = "4")]
	public bool Equals(EKGPGPMNKDF<T> KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3ADF920", Offset = "0x3ADEB20", VA = "0x183ADF920", Slot = "0")]
	public override bool Equals(object KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3AE00F0", Offset = "0x3ADF2F0", VA = "0x183AE00F0")]
	public bool NFOFFGFCKAM([In] EKGPGPMNKDF<T> KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3ADFBA0", Offset = "0x3ADEDA0", VA = "0x183ADFBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3AE03E0", Offset = "0x3ADF5E0", VA = "0x183AE03E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3ADF210", Offset = "0x3ADE410", VA = "0x183ADF210")]
	public void BINADAOPODH([Out] T JECHHBGMFLN, [Out] int KINMHNEMPOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3ADF6A0", Offset = "0x3ADE8A0", VA = "0x183ADF6A0")]
	public (T, int) EHJOEFIMJLN()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3ADF5D0", Offset = "0x3ADE7D0", VA = "0x183ADF5D0", Slot = "5")]
	private bool CNHKIKCKLNM([In] EKGPGPMNKDF<T> KDHPJMADEAD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class AHJANFDBFEE
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3524E50", Offset = "0x3524050", VA = "0x183524E50")]
	public static EKGPGPMNKDF<T> MIFIOLMMIDE<T>([In] T JECHHBGMFLN, int KINMHNEMPOD) where T : notnull
	{
		return default(EKGPGPMNKDF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class IAFNNNJPHLI
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2E42CA0", Offset = "0x2E41EA0", VA = "0x182E42CA0")]
	public static bool NFOFFGFCKAM<T, U>([In] T AEFKHDNCNFD, [In] U JMJAOKJJFGJ) where T : notnull, OKLAGBJBBOM<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public delegate TResult BNOICIMLIBA<T, out TResult>([In] T LFMCCJGKEKP);
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface FONGHBBKBHN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	TimeSpan MFFIHKEGABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Action? NKENNCMMACM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LJGFOBFFBED();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KGEAEPNPNON();

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PNAEENCKMLL();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct HKKDANEFDJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly POEDOGMDLLN NFOGLNAHDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly MFKPBCPJNDD LLCIOMBLCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly POEDOGMDLLN JFFBBIMLCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly MFKPBCPJNDD FCIHLNBMLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly POEDOGMDLLN BLMEEBKJBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly MFKPBCPJNDD CKLBPHLKAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly BAMDLHGDELF ENGIHCBPDFP;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly POEDOGMDLLN BOPMLNINDLO;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly MFKPBCPJNDD PBMDEDIOFAC;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly POEDOGMDLLN FLAEOJKBDGI;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public static readonly MFKPBCPJNDD MLJHAGPJDCP;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly POEDOGMDLLN GCKKOCBEODI;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly MFKPBCPJNDD ICHFIAKGPIB;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly BAMDLHGDELF NCJPDDPOGJO;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly HKKDANEFDJO NPJAAMJGCPB;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly POEDOGMDLLN AMMLALELBNE;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool IDJFCBEKMDN
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6D3E230", Offset = "0x6D3D430", VA = "0x186D3E230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xDFAB70", Offset = "0xDF9D70", VA = "0x180DFAB70")]
	public HKKDANEFDJO(POEDOGMDLLN LKLNAPHNAJF, MFKPBCPJNDD EHFBJNDOIHG, POEDOGMDLLN EJLLAFKHKFH, MFKPBCPJNDD OEPAGNDFNNM, POEDOGMDLLN BOCGJJKDDAM, MFKPBCPJNDD ABEOPPKNNMH, BAMDLHGDELF GACPPBKAIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80")]
	private static bool HJHDFDFAEIG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
	private static void CCHJOELLHEC(string ADNFLGLLNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80")]
	private static bool DEBPIABKECB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
	private static void DKGFFAJICIK(string ADNFLGLLNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80")]
	private static bool JNDKDDKCPFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
	private static void NPCGBNNEBNE(string ADNFLGLLNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
	private static void IBCIBPDMDGA(Exception JIAKIFPLAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6D3E0F0", Offset = "0x6D3D2F0", VA = "0x186D3E0F0")]
	private static HKKDANEFDJO IEPOMPIJIGB()
	{
		return default(HKKDANEFDJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490")]
	private static bool LGJIFOIHFFL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6D3E410", Offset = "0x6D3D610", VA = "0x186D3E410")]
	public void OBPAMGBPHCN(object ADNFLGLLNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6D3E080", Offset = "0x6D3D280", VA = "0x186D3E080")]
	public void DLPKEHPJALN(object ADNFLGLLNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x2081510", Offset = "0x2080710", VA = "0x182081510")]
	public void JOMMAGOJOKG(Exception JIAKIFPLAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6D3DFA0", Offset = "0x6D3D1A0", VA = "0x186D3DFA0")]
	public void DLPKEHPJALN(IBBLBGKDFJI ADNFLGLLNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2E34E30", Offset = "0x2E34030", VA = "0x182E34E30")]
	public void DLPKEHPJALN<T>(T LFMCCJGKEKP, INPKHEDLAIO<T> ADNFLGLLNKI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2E34FD0", Offset = "0x2E341D0", VA = "0x182E34FD0")]
	public void OBPAMGBPHCN<T>([In] T LFMCCJGKEKP, GDFODKNBPGC<T> ADNFLGLLNKI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2E34C90", Offset = "0x2E33E90", VA = "0x182E34C90")]
	public void DLPKEHPJALN<T>([In] T LFMCCJGKEKP, GDFODKNBPGC<T> ADNFLGLLNKI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6D3DED0", Offset = "0x6D3D0D0", VA = "0x186D3DED0")]
	public bool DLOEPNOBKCN(bool MLDFEJJHIJL, string ADNFLGLLNKI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct AEIPCCBKKNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly string GOGBANOMEKC;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xBD6E30", Offset = "0xBD6030", VA = "0x180BD6E30")]
	public AEIPCCBKKNC(string JECHHBGMFLN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x9E9440", Offset = "0x9E8640", VA = "0x1809E9440")]
	public static string CFMDMKLGJEH([In] AEIPCCBKKNC AEFKHDNCNFD)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xC43E20", Offset = "0xC43020", VA = "0x180C43E20")]
	public static AEIPCCBKKNC CFMDMKLGJEH(string KDHPJMADEAD)
	{
		return default(AEIPCCBKKNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6D36B40", Offset = "0x6D35D40", VA = "0x186D36B40")]
	public string ILHKDNAFCOO(string GOCHEDLKNPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6D36A60", Offset = "0x6D35C60", VA = "0x186D36A60")]
	public string DIAMENCHPAL(object EDJAILJDEOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x9E9440", Offset = "0x9E8640", VA = "0x1809E9440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct EPFCCNCFAEJ : IEquatable<EPFCCNCFAEJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8B0490", Offset = "0x8AF690", VA = "0x1808B0490", Slot = "4")]
	public bool Equals(EPFCCNCFAEJ KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6D3B1B0", Offset = "0x6D3A3B0", VA = "0x186D3B1B0", Slot = "0")]
	public override bool Equals(object KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6D3B200", Offset = "0x6D3A400", VA = "0x186D3B200", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6D3B210", Offset = "0x6D3A410", VA = "0x186D3B210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[NLMOIDEGKNH("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct BMNACOJIPCO<T> : IEquatable<BMNACOJIPCO<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T GOGBANOMEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly bool HDLLKDEHHAI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool AGODJLPHFLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x52EB250", Offset = "0x52EA450", VA = "0x1852EB250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x52EBA10", Offset = "0x52EAC10", VA = "0x1852EBA10")]
	public BMNACOJIPCO([In] T JECHHBGMFLN, bool OOPNDGHNCJH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x52EAFB0", Offset = "0x52EA1B0", VA = "0x1852EAFB0")]
	public static bool IELJJBKMIFI([In] BMNACOJIPCO<T> PCICJLNHPMM, [In] BMNACOJIPCO<T> OIJJJJFPNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3ADF890", Offset = "0x3ADEA90", VA = "0x183ADF890", Slot = "4")]
	public bool Equals(BMNACOJIPCO<T> KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x52EA1E0", Offset = "0x52E93E0", VA = "0x1852EA1E0", Slot = "0")]
	public override bool Equals(object KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x52EA820", Offset = "0x52E9A20", VA = "0x1852EA820", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x52EB3F0", Offset = "0x52EA5F0", VA = "0x1852EB3F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class OCMFJKBNDDC
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2FA94C0", Offset = "0x2FA86C0", VA = "0x182FA94C0")]
	public static BMNACOJIPCO<T> IIGLPIIIFMD<T>([In] T JECHHBGMFLN) where T : notnull
	{
		return default(BMNACOJIPCO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2FA9340", Offset = "0x2FA8540", VA = "0x182FA9340")]
	public static BMNACOJIPCO<T?> FOFPBEGBHDK<T>()
	{
		return default(BMNACOJIPCO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2FA9550", Offset = "0x2FA8750", VA = "0x182FA9550")]
	public static bool IMGCNEPDIKO<T>([In] this BMNACOJIPCO<T> GIPHDMFMKIJ, [Out][NotNullWhen(true)] T JECHHBGMFLN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2FA9580", Offset = "0x2FA8780", VA = "0x182FA9580")]
	public static T? KEAGEDIKABG<T>([In] this BMNACOJIPCO<T> GIPHDMFMKIJ, T? IIGPKDCCLGH)
	{
		return (T?)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct DCEFINLNIIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly IntPtr CFLFIIBOOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly IntPtr ACJJBDLNOMF;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IntPtr GAPBCBJLJMN;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly IntPtr GEEHLDHLDPM;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly DCEFINLNIIK NPJAAMJGCPB;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool IDJFCBEKMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6D38340", Offset = "0x6D37540", VA = "0x186D38340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xD62DE0", Offset = "0xD61FE0", VA = "0x180D62DE0")]
	public DCEFINLNIIK(IntPtr MJGDFIOKBOK, IntPtr HLCOHEJKOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
	private static void CHNPFAMJMFH(string EPPPGDEIJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
	private static void FGOFGJMEPOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6D382B0", Offset = "0x6D374B0", VA = "0x186D382B0")]
	private static DCEFINLNIIK IEPOMPIJIGB()
	{
		return default(DCEFINLNIIK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct PNAJOPBGEAP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly IntPtr DBBNFKACKDF;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xBD6E30", Offset = "0xBD6030", VA = "0x180BD6E30")]
	private PNAJOPBGEAP(IntPtr HLCOHEJKOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6D421C0", Offset = "0x6D413C0", VA = "0x186D421C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6D421E0", Offset = "0x6D413E0", VA = "0x186D421E0")]
	public static PNAJOPBGEAP MIFIOLMMIDE(string EPPPGDEIJCI)
	{
		return default(PNAJOPBGEAP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x21FA150", Offset = "0x21F9350", VA = "0x1821FA150")]
	public static PNAJOPBGEAP MIFIOLMMIDE([In] DCEFINLNIIK MIKKCMCLECI, string EPPPGDEIJCI)
	{
		return default(PNAJOPBGEAP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x21F9CC0", Offset = "0x21F8EC0", VA = "0x1821F9CC0")]
	public static PNAJOPBGEAP MIFIOLMMIDE([In] DCEFINLNIIK MIKKCMCLECI, Func<string> EPPPGDEIJCI)
	{
		return default(PNAJOPBGEAP);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class ENHKICBLEDN
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public delegate bool OBKBBFCDAAJ<in TInput, TResult>(TInput GJDJIDOLBAE, [Out] TResult KHPJAGHLNBM);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private sealed class NOCKOKPHMND : MDNIBCKFOLA
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private sealed class MNBBONICHOD : OBJNJPNIMAN, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public static readonly MNBBONICHOD FAKOKDPOOAM;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			public bool CMCDJGBNDPI
			{
				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x6D3FED0", Offset = "0x6D3F0D0", VA = "0x186D3FED0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6D3FF30", Offset = "0x6D3F130", VA = "0x186D3FF30", Slot = "6")]
			public void OnCompleted(Action CAKKFAJNANN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
			public void LNBNKFJNAAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public MNBBONICHOD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly NOCKOKPHMND FAKOKDPOOAM;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		private NOCKOKPHMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6D40F10", Offset = "0x6D40110", VA = "0x186D40F10", Slot = "4")]
		public OBJNJPNIMAN KHBMABMNGIM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private sealed class OKEMIDAACKC : MDNIBCKFOLA
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private sealed class CBIDMJMCJPP : OBJNJPNIMAN, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly CBIDMJMCJPP FAKOKDPOOAM;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			public bool CMCDJGBNDPI
			{
				[Cpp2IlInjected.Token(Token = "0x60000C8")]
				[Cpp2IlInjected.Address(RVA = "0x6D37640", Offset = "0x6D36840", VA = "0x186D37640", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x6D37660", Offset = "0x6D36860", VA = "0x186D37660", Slot = "6")]
			public void OnCompleted(Action CAKKFAJNANN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
			public void LNBNKFJNAAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public CBIDMJMCJPP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly OKEMIDAACKC FAKOKDPOOAM;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		private OKEMIDAACKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6D41A00", Offset = "0x6D40C00", VA = "0x186D41A00", Slot = "4")]
		public OBJNJPNIMAN KHBMABMNGIM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class JKFCMDLAJHJ<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public JKFCMDLAJHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x3F653C0", Offset = "0x3F645C0", VA = "0x183F653C0")]
		internal void EOMABGGLNHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class HGBFAELKNEP<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public HGBFAELKNEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3FC7280", Offset = "0x3FC6480", VA = "0x183FC7280")]
		internal void EOLHFFKAMIL(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct IBNMFEHMDAG : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6D3EA30", Offset = "0x6D3DC30", VA = "0x186D3EA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x90BE20", Offset = "0x90B020", VA = "0x18090BE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct BCMCKMLBKDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6D371E0", Offset = "0x6D363E0", VA = "0x186D371E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x90BE20", Offset = "0x90B020", VA = "0x18090BE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct HJGMCKJHMKL<TException> : IAsyncStateMachine where TException : notnull, Exception
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x4039870", Offset = "0x4038A70", VA = "0x184039870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x40399E0", Offset = "0x4038BE0", VA = "0x1840399E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct BCCJHMBNNDG<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Task<T> self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<TaskStatus> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<T> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x51C6ED0", Offset = "0x51C60D0", VA = "0x1851C6ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x51C7300", Offset = "0x51C6500", VA = "0x1851C7300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct ONNCJEMFDDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Task self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6D41AC0", Offset = "0x6D40CC0", VA = "0x186D41AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6D41CC0", Offset = "0x6D40EC0", VA = "0x186D41CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class GHBJOJODKGP<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public TaskCompletionSource<T> taskCompletionSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public GHBJOJODKGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3F653C0", Offset = "0x3F645C0", VA = "0x183F653C0")]
		internal void COPLIFAMGDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3F65420", Offset = "0x3F64620", VA = "0x183F65420")]
		internal void NBFFCCDGJBO(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private struct JIOGPCLMBGC<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Task<List<TInput>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public OBKBBFCDAAJ<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x4361430", Offset = "0x4360630", VA = "0x184361430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x4361B40", Offset = "0x4360D40", VA = "0x184361B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct KDJBPLDOFBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Func<CancellationToken, Task> innerTaskConstructor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Task t;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private CancellationTokenSource <innerTaskCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private Task <innerTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<TaskStatus> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6D3EC90", Offset = "0x6D3DE90", VA = "0x186D3EC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6D3F490", Offset = "0x6D3E690", VA = "0x186D3F490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct NNAAFOAIHEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Func<CancellationToken, Task> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6D40960", Offset = "0x6D3FB60", VA = "0x186D40960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6D40EB0", Offset = "0x6D400B0", VA = "0x186D40EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct OIFIFKBLCMG<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<CancellationToken, Task<T>> taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Func<OperationCanceledException, T> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private CancellationTokenSource <linkedCTS>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x496ED00", Offset = "0x496DF00", VA = "0x18496ED00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x446D1A0", Offset = "0x446C3A0", VA = "0x18446D1A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class BEBCOOPMFMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public TaskCompletionSource<EPFCCNCFAEJ> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public BEBCOOPMFMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6D372F0", Offset = "0x6D364F0", VA = "0x186D372F0")]
		internal void KCHBDLLNOJE(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct AMMOAJAEIAK<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder<IEnumerable<Task<T>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public IEnumerable<Task<T>> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private Task<T>[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x4374200", Offset = "0x4373400", VA = "0x184374200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x382A660", Offset = "0x3829860", VA = "0x18382A660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct ECODCAEFHHJ<T1, T2, T3, T4> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder<(T1, T2, T3, T4)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Task<T4> task4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3ACAD80", Offset = "0x3AC9F80", VA = "0x183ACAD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3ACB490", Offset = "0x3ACA690", VA = "0x183ACB490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct MIMOIPJGLHA : IAsyncStateMachine
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
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6D3FC90", Offset = "0x6D3EE90", VA = "0x186D3FC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6D3FE70", Offset = "0x6D3F070", VA = "0x186D3FE70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct FDJNPAJBDDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6D3B290", Offset = "0x6D3A490", VA = "0x186D3B290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6D3B5F0", Offset = "0x6D3A7F0", VA = "0x186D3B5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct GDKBGNOHPBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6D3D140", Offset = "0x6D3C340", VA = "0x186D3D140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6D3D430", Offset = "0x6D3C630", VA = "0x186D3D430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class OFMPJAJOFIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public OFMPJAJOFIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6D41990", Offset = "0x6D40B90", VA = "0x186D41990")]
		internal Task GMMCHFCFEBH(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct CIIOACLNENJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6D37FF0", Offset = "0x6D371F0", VA = "0x186D37FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6D38250", Offset = "0x6D37450", VA = "0x186D38250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct BPANNANEIBG : IAsyncStateMachine
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
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6D37400", Offset = "0x6D36600", VA = "0x186D37400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6D375E0", Offset = "0x6D367E0", VA = "0x186D375E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct PIBJHNODMLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6D41E00", Offset = "0x6D41000", VA = "0x186D41E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6D42160", Offset = "0x6D41360", VA = "0x186D42160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct EPAKFGAEDJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6D3AE60", Offset = "0x6D3A060", VA = "0x186D3AE60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6D3B150", Offset = "0x6D3A350", VA = "0x186D3B150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class NFOFBFFBDAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public NFOFBFFBDAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6D408F0", Offset = "0x6D3FAF0", VA = "0x186D408F0")]
		internal Task KAGBFEGLEAJ(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct FIMLFGLDIPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6D3BFB0", Offset = "0x6D3B1B0", VA = "0x186D3BFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6D3C210", Offset = "0x6D3B410", VA = "0x186D3C210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct KLMAODHGEKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public Action then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6D3F4F0", Offset = "0x6D3E6F0", VA = "0x186D3F4F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6D3F670", Offset = "0x6D3E870", VA = "0x186D3F670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct DGLONJCAMAJ<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Action<T> then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5B2B780", Offset = "0x5B2A980", VA = "0x185B2B780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5B2B9E0", Offset = "0x5B2ABE0", VA = "0x185B2B9E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct MIMACJNEOME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Func<Task> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private object <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6D3F900", Offset = "0x6D3EB00", VA = "0x186D3F900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6D3FC30", Offset = "0x6D3EE30", VA = "0x186D3FC30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static SynchronizationContext? NPHIDNDIBLN;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly TaskCompletionSource<EPFCCNCFAEJ> HEGOCBDJAIF;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static Task MMAFHKAFFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6D39F60", Offset = "0x6D39160", VA = "0x186D39F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6D39860", Offset = "0x6D38A60", VA = "0x186D39860")]
	public static bool KEJMIEAPODB(this Task HMHJFGCCEGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2CBF060", Offset = "0x2CBE260", VA = "0x182CBF060")]
	public static Task<T> BBFKLEMKMMK<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6D39960", Offset = "0x6D38B60", VA = "0x186D39960")]
	public static Task KPMKGJOJGFI(this Task HMHJFGCCEGP, CancellationToken NIOIDOPDJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2CC1FA0", Offset = "0x2CC11A0", VA = "0x182CC1FA0")]
	public static Task<TResult> KPMKGJOJGFI<TResult>(this Task<TResult> HMHJFGCCEGP, CancellationToken NIOIDOPDJKO) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2CC2F10", Offset = "0x2CC2110", VA = "0x182CC2F10")]
	public static TaskCompletionSource<TResult> KPMKGJOJGFI<TResult>(this TaskCompletionSource<TResult> HNKDADPHGFG, CancellationToken NIOIDOPDJKO) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6D38C30", Offset = "0x6D37E30", VA = "0x186D38C30")]
	public static IDisposable? AEBMDFOCHJK(CancellationToken PCLLCGPEOJP, CancellationToken HCGKENDIHBF, [Out] CancellationToken LPFMAMDHLNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6D38E10", Offset = "0x6D38010", VA = "0x186D38E10")]
	[AsyncStateMachine(typeof(IBNMFEHMDAG))]
	public static void CIDBFEGHOGC(this Task EBCBPNKDEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6D39FD0", Offset = "0x6D391D0", VA = "0x186D39FD0")]
	[AsyncStateMachine(typeof(BCMCKMLBKDJ))]
	public static void MDHPKIOOGGI(this Task EBCBPNKDEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2CBF5A0", Offset = "0x2CBE7A0", VA = "0x182CBF5A0")]
	[AsyncStateMachine(typeof(HJGMCKJHMKL<>))]
	public static Task GGHEPFCLBFM<TException>(this Task EBCBPNKDEPP) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2CBF3C0", Offset = "0x2CBE5C0", VA = "0x182CBF3C0")]
	[AsyncStateMachine(typeof(BCCJHMBNNDG<>))]
	public static Task<T> FLBGDDJDECI<T>(this Task<T> AEFKHDNCNFD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6D396A0", Offset = "0x6D388A0", VA = "0x186D396A0")]
	[AsyncStateMachine(typeof(ONNCJEMFDDK))]
	public static Task<TaskStatus> HIOJNNNHOKP(this Task AEFKHDNCNFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2CBF760", Offset = "0x2CBE960", VA = "0x182CBF760")]
	public static (Task<T?>?, Action<T?>?) JMGGMDGGNDJ<T>([Optional] CancellationToken DDNLBFLLCLM)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2CC38A0", Offset = "0x2CC2AA0", VA = "0x182CC38A0")]
	[AsyncStateMachine(typeof(JIOGPCLMBGC<, >))]
	public static Task<List<TResult>> LKMNMHOOBJM<TResult, TInput>(this Task<List<TInput>> HMHJFGCCEGP, OBKBBFCDAAJ<TInput, TResult> NOBIEGPHFDN) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6D39570", Offset = "0x6D38770", VA = "0x186D39570")]
	[AsyncStateMachine(typeof(KDJBPLDOFBJ))]
	public static Task GLADIHKEJOK(Task EBCBPNKDEPP, CancellationToken ANFODAEMPAE, Func<CancellationToken, Task> HLKIEAFOJBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6D3AA70", Offset = "0x6D39C70", VA = "0x186D3AA70")]
	[AsyncStateMachine(typeof(NNAAFOAIHEN))]
	public static Task OGPIIKMNPHH(Func<CancellationToken, Task> HNANNMADFNF, TimeSpan ANKNBCMNEHH, [Optional] CancellationToken ANFODAEMPAE, [Optional] Action<OperationCanceledException>? OGOGJGAPKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2CC3C70", Offset = "0x2CC2E70", VA = "0x182CC3C70")]
	[AsyncStateMachine(typeof(OIFIFKBLCMG<>))]
	public static Task<T> OGPIIKMNPHH<T>(Func<CancellationToken, Task<T>> HNANNMADFNF, TimeSpan ANKNBCMNEHH, [Optional] CancellationToken ANFODAEMPAE, [Optional] Func<OperationCanceledException, T>? OGOGJGAPKJK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6D3A7B0", Offset = "0x6D399B0", VA = "0x186D3A7B0")]
	public static Task MMADKFMLMNA(params Task[] MNOHONJDMAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6D3A2F0", Offset = "0x6D394F0", VA = "0x186D3A2F0")]
	public static Task MMADKFMLMNA(IEnumerable<Task> MNOHONJDMAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x2CBF2D0", Offset = "0x2CBE4D0", VA = "0x182CBF2D0")]
	[AsyncStateMachine(typeof(AMMOAJAEIAK<>))]
	public static Task<IEnumerable<Task<T>>> DLBOJMDFCGA<T>(IEnumerable<Task<T>> MNOHONJDMAE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2CC39B0", Offset = "0x2CC2BB0", VA = "0x182CC39B0")]
	[AsyncStateMachine(typeof(ECODCAEFHHJ<, , , >))]
	public static Task<(T1, T2, T3, T4)> MKPMHCFBDOO<T1, T2, T3, T4>(Task<T1> ELDOGIPGELG, Task<T2> KNIIBCJNGDP, Task<T3> HMDBOAABKKH, Task<T4> GNNGJMFFODH) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6D38FD0", Offset = "0x6D381D0", VA = "0x186D38FD0")]
	[AsyncStateMachine(typeof(MIMOIPJGLHA))]
	public static Task DAILAEFOOPJ(Func<bool> MLDFEJJHIJL, [Optional] CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6D38EC0", Offset = "0x6D380C0", VA = "0x186D38EC0")]
	[AsyncStateMachine(typeof(FDJNPAJBDDG))]
	public static Task DAILAEFOOPJ(Func<bool> MLDFEJJHIJL, TimeSpan JIKCBDFHIKD, [Optional] CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6D3A080", Offset = "0x6D39280", VA = "0x186D3A080")]
	[AsyncStateMachine(typeof(GDKBGNOHPBC))]
	public static Task MIKKGGCKICN(Func<bool> MLDFEJJHIJL, TimeSpan ANKNBCMNEHH, [Optional] CancellationToken DDNLBFLLCLM, [Optional] Action<OperationCanceledException>? OGOGJGAPKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6D3A1B0", Offset = "0x6D393B0", VA = "0x186D3A1B0")]
	[AsyncStateMachine(typeof(CIIOACLNENJ))]
	public static Task MIKKGGCKICN(Func<bool> MLDFEJJHIJL, TimeSpan ANKNBCMNEHH, TimeSpan JIKCBDFHIKD, [Optional] CancellationToken DDNLBFLLCLM, [Optional] Action<OperationCanceledException>? OGOGJGAPKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6D3ACB0", Offset = "0x6D39EB0", VA = "0x186D3ACB0")]
	[AsyncStateMachine(typeof(BPANNANEIBG))]
	public static Task OLHMKIDCIGH(Func<bool> MLDFEJJHIJL, [Optional] CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6D3ABA0", Offset = "0x6D39DA0", VA = "0x186D3ABA0")]
	[AsyncStateMachine(typeof(PIBJHNODMLP))]
	public static Task OLHMKIDCIGH(Func<bool> MLDFEJJHIJL, TimeSpan JIKCBDFHIKD, [Optional] CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6D3A940", Offset = "0x6D39B40", VA = "0x186D3A940")]
	[AsyncStateMachine(typeof(EPAKFGAEDJC))]
	public static Task NLCPEIHEHOG(Func<bool> MLDFEJJHIJL, TimeSpan ANKNBCMNEHH, [Optional] CancellationToken DDNLBFLLCLM, [Optional] Action<OperationCanceledException>? OGOGJGAPKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6D3A800", Offset = "0x6D39A00", VA = "0x186D3A800")]
	[AsyncStateMachine(typeof(FIMLFGLDIPF))]
	public static Task NLCPEIHEHOG(Func<bool> MLDFEJJHIJL, TimeSpan ANKNBCMNEHH, TimeSpan JIKCBDFHIKD, [Optional] CancellationToken DDNLBFLLCLM, [Optional] Action<OperationCanceledException>? OGOGJGAPKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6D39480", Offset = "0x6D38680", VA = "0x186D39480")]
	[AsyncStateMachine(typeof(KLMAODHGEKK))]
	[Obsolete]
	public static Task GKHIOLOHHBF(this Task HMHJFGCCEGP, Action ABFGKDDDPIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2CBF670", Offset = "0x2CBE870", VA = "0x182CBF670")]
	[Obsolete]
	[AsyncStateMachine(typeof(DGLONJCAMAJ<>))]
	public static Task GKHIOLOHHBF<T>(this Task<T> HMHJFGCCEGP, Action<T> ABFGKDDDPIO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6D39250", Offset = "0x6D38450", VA = "0x186D39250")]
	private static void GFHJGPJAFGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6D39C00", Offset = "0x6D38E00", VA = "0x186D39C00")]
	public static bool LDPJMJMAKGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6D39300", Offset = "0x6D38500", VA = "0x186D39300")]
	private static void GIAMOKEHEIJ(SynchronizationContext JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6D390C0", Offset = "0x6D382C0", VA = "0x186D390C0")]
	private static void DOJCOALABCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6D39890", Offset = "0x6D38A90", VA = "0x186D39890")]
	public static void KIPJFADCAEE([Optional] string? ADNFLGLLNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6D391D0", Offset = "0x6D383D0", VA = "0x186D391D0")]
	public static void FLDAFINLHCD([Optional] string? ADNFLGLLNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6D38DC0", Offset = "0x6D37FC0", VA = "0x186D38DC0")]
	public static MDNIBCKFOLA AIMEDOECMNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6D39BB0", Offset = "0x6D38DB0", VA = "0x186D39BB0")]
	public static MDNIBCKFOLA LDIIBCNDMBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6D39790", Offset = "0x6D38990", VA = "0x186D39790")]
	[AsyncStateMachine(typeof(MIMACJNEOME))]
	public static Task HKFLEGLIFPP(Func<Task> OMCFGJPALAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class HAAHLEBGOKA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
	public HAAHLEBGOKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class LJFCEPJOEHB : CLMPFIKOBAD
{
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static readonly CLMPFIKOBAD FAKOKDPOOAM;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DateTime MHKJHAJHLHP
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6D3F730", Offset = "0x6D3E930", VA = "0x186D3F730", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public DateTimeOffset NJNEDACOGPB
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6D3F6D0", Offset = "0x6D3E8D0", VA = "0x186D3F6D0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public LJFCEPJOEHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface CLMPFIKOBAD
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DateTime MHKJHAJHLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DateTimeOffset NJNEDACOGPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class NBPHIJNFDGI
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static long GJPDANLHPEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6D405B0", Offset = "0x6D3F7B0", VA = "0x186D405B0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static long AAKOGDIIOLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6D40350", Offset = "0x6D3F550", VA = "0x186D40350")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static double KLHECLJGMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6D401C0", Offset = "0x6D3F3C0", VA = "0x186D401C0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static double NBANOEDHBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6D40300", Offset = "0x6D3F500", VA = "0x186D40300")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public static double JIIMGEIIMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6D402B0", Offset = "0x6D3F4B0", VA = "0x186D402B0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public static double LCPIBFMJDKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6D40600", Offset = "0x6D3F800", VA = "0x186D40600")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6D403A0", Offset = "0x6D3F5A0", VA = "0x186D403A0")]
	public static double GNKCFPBGMHI(long AHDOEGCICIA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6D40490", Offset = "0x6D3F690", VA = "0x186D40490")]
	public static double IBMGDLMFBAG(long AHDOEGCICIA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6D40520", Offset = "0x6D3F720", VA = "0x186D40520")]
	public static double LANPLOKGAOJ(double DPLJBMODCOP)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6D40220", Offset = "0x6D3F420", VA = "0x186D40220")]
	public static long CJAIPIKCJEE(long NPIKCMPEMNK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6D40210", Offset = "0x6D3F410", VA = "0x186D40210")]
	public static long CDFOIHMBBEK(long FFCDLMEGDDI, long MCEPGLFFBAB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6D400F0", Offset = "0x6D3F2F0", VA = "0x186D400F0")]
	public static double AJLHCGLNIOB(long FFCDLMEGDDI, long MCEPGLFFBAB)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6D40430", Offset = "0x6D3F630", VA = "0x186D40430")]
	public static double HMCPIKEMINM(long FFCDLMEGDDI, long MCEPGLFFBAB)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class DCIGCHPEDDI : FONGHBBKBHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static readonly TimeSpan GPBOKBJPAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly System.Timers.Timer MOKDAJBBPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private TimeSpan ANKNBCMNEHH;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public TimeSpan MFFIHKEGABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6D38780", Offset = "0x6D37980", VA = "0x186D38780", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Action? NKENNCMMACM
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8941F0", Offset = "0x8933F0", VA = "0x1808941F0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6D38980", Offset = "0x6D37B80", VA = "0x186D38980")]
	[Preserve]
	public DCIGCHPEDDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6D389E0", Offset = "0x6D37BE0", VA = "0x186D389E0")]
	public DCIGCHPEDDI(TimeSpan ANKNBCMNEHH, [Optional] Action? LLCGAFJLDIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6D38660", Offset = "0x6D37860", VA = "0x186D38660", Slot = "7")]
	public void LJGFOBFFBED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6D385F0", Offset = "0x6D377F0", VA = "0x186D385F0", Slot = "8")]
	public void KGEAEPNPNON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6D388E0", Offset = "0x6D37AE0", VA = "0x186D388E0", Slot = "9")]
	public void PNAEENCKMLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0xBD4A20", Offset = "0xBD3C20", VA = "0x180BD4A20")]
	private void OGJDEJMFBCO(object JNLAAHCIJJI, ElapsedEventArgs BLIKHDEPHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6D386F0", Offset = "0x6D378F0", VA = "0x186D386F0")]
	private static void MBDLFLNAPEB(TimeSpan JJNPIJFCEJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6D38550", Offset = "0x6D37750", VA = "0x186D38550", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class NLMOIDEGKNH : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public readonly string? EJJPJGMAEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public readonly string ELNEGBKEBPP;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x9D0760", Offset = "0x9CF960", VA = "0x1809D0760")]
	public NLMOIDEGKNH(string KFMEELLINJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x435CA60", Offset = "0x435BC60", VA = "0x18435CA60")]
	public NLMOIDEGKNH(string FIFHCLBFGGO, string KFMEELLINJF)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct FNOBPGNLGNO : IEquatable<FNOBPGNLGNO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint DDMABJIIMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public int OGKBHGBNELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public float MNGLEMFJBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public ushort OMFEICDJIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public ushort PCFOBIELFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public short OAADHPMLIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public short ADKAGJJPODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public char KEFCALLABHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public char NNJAIHGABKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public byte NLHNCIMIHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public byte NABCICADODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public byte LCHKHBCDAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public byte FDMBBJDPCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public bool PNKMIGHCADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public bool HNEAAPLJFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public bool JODJJNCOBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public bool KONMDPCKJFA;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x170B3E0", Offset = "0x170A5E0", VA = "0x18170B3E0")]
	public static FNOBPGNLGNO MMGBOOPEHDM(uint AAKBHNIBKAG)
	{
		return default(FNOBPGNLGNO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x170B3E0", Offset = "0x170A5E0", VA = "0x18170B3E0")]
	public static FNOBPGNLGNO KOELPHIJAHA(int DCFIBFODENM)
	{
		return default(FNOBPGNLGNO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C310", Offset = "0x6D3B510", VA = "0x186D3C310")]
	public static FNOBPGNLGNO JKNEMOHKKIE(float HFKPEIKFCJK)
	{
		return default(FNOBPGNLGNO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C270", Offset = "0x6D3B470", VA = "0x186D3C270")]
	public static FNOBPGNLGNO AHKMFEHMBON(byte MFHNHJOBCKA, byte AMFLPHELLJE, byte HPEJHMBGJLF, byte MPCEGJMEFLM)
	{
		return default(FNOBPGNLGNO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C270", Offset = "0x6D3B470", VA = "0x186D3C270")]
	public static FNOBPGNLGNO ACGHFBHNJLA(bool AJPCCCBDIOK, bool OBCDOFEIGOC, bool CELAFANGOIN, bool PNEEDNINCGC)
	{
		return default(FNOBPGNLGNO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C270", Offset = "0x6D3B470", VA = "0x186D3C270")]
	public static FNOBPGNLGNO OFIMDEJOHAG(byte AMNJBKKMJFI, byte AFCKEDCLDHE, byte KGGMFEPPBBK, byte GHKNJDAPNGI)
	{
		return default(FNOBPGNLGNO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x1EF9C20", Offset = "0x1EF8E20", VA = "0x181EF9C20")]
	public static bool IELJJBKMIFI(FNOBPGNLGNO ICLLFDEBJIO, FNOBPGNLGNO JPMAPOMKNPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0xCB9F50", Offset = "0xCB9150", VA = "0x180CB9F50", Slot = "4")]
	public bool Equals(FNOBPGNLGNO KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C290", Offset = "0x6D3B490", VA = "0x186D3C290", Slot = "0")]
	public override bool Equals(object JMJAOKJJFGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0xD62B10", Offset = "0xD61D10", VA = "0x180D62B10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6D3C320", Offset = "0x6D3B520", VA = "0x186D3C320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct FCAKBPOKMLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public ulong EGKKCHAFMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public long HAAIPNBBMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public double PPFLMLIPHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint MMEFKJJPHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint OLABKKFJCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public int FPPDIDEBBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public int IHLAGAKHPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public float GHHABDOFDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public float GOECIJKIOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public ushort OMFEICDJIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public ushort PCFOBIELFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public ushort AEJHOEIDKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public ushort AEALCHJGGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public short OAADHPMLIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public short ADKAGJJPODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public short JBEBIEJNCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public short LHGMCGOEAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public char KEFCALLABHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public char NNJAIHGABKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public char OMEECHODBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public char LLDEAKPPDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte NLHNCIMIHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte NABCICADODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte LCHKHBCDAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public byte FDMBBJDPCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public byte HIIIMMLPCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public byte DPLKNFNELKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public byte CEIAMILDLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public byte OKKIIIDKMOK;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x9964B0", Offset = "0x9956B0", VA = "0x1809964B0")]
	public static FCAKBPOKMLD MIFIOLMMIDE(long FILFJJPLAPC)
	{
		return default(FCAKBPOKMLD);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6D3B240", Offset = "0x6D3A440", VA = "0x186D3B240")]
	public static FCAKBPOKMLD MIFIOLMMIDE(byte MFHNHJOBCKA, byte AMFLPHELLJE, byte HPEJHMBGJLF, byte MPCEGJMEFLM, byte KAMKPIKCNOG, byte LECACCDEPIK, byte FCKKIGBLHHH, byte LACPAKJGFHL)
	{
		return default(FCAKBPOKMLD);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct CEPIFDPJNCN : IEquatable<CEPIFDPJNCN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public byte JMOBCCBGKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public bool GICKDLCGHBO;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x27D1EE0", Offset = "0x27D10E0", VA = "0x1827D1EE0")]
	public static CEPIFDPJNCN AHKMFEHMBON(byte FJGPINMMNAB)
	{
		return default(CEPIFDPJNCN);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x27D1EE0", Offset = "0x27D10E0", VA = "0x1827D1EE0")]
	public static CEPIFDPJNCN ACGHFBHNJLA(bool JBLJHDINHED)
	{
		return default(CEPIFDPJNCN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6D377C0", Offset = "0x6D369C0", VA = "0x186D377C0")]
	public static bool IELJJBKMIFI(CEPIFDPJNCN ICLLFDEBJIO, CEPIFDPJNCN JPMAPOMKNPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5EAF430", Offset = "0x5EAE630", VA = "0x185EAF430", Slot = "4")]
	public bool Equals(CEPIFDPJNCN KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6D37720", Offset = "0x6D36920", VA = "0x186D37720", Slot = "0")]
	public override bool Equals(object JMJAOKJJFGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6D377B0", Offset = "0x6D369B0", VA = "0x186D377B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6D377D0", Offset = "0x6D369D0", VA = "0x186D377D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class JLDDCPPJDNG<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public readonly T CAOLOCCONHI;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x4388050", Offset = "0x4387250", VA = "0x184388050")]
	public JLDDCPPJDNG(T PEHPJPACALD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class JIOOIPJOIHN
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x2E38F40", Offset = "0x2E38140", VA = "0x182E38F40")]
	public static IEnumerable<T> ELDBKKCAIBM<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x9964B0", Offset = "0x9956B0", VA = "0x1809964B0")]
	public static T[] MBHECFOPGMB<T>(params T[] OMHJKAGBBKO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x9964B0", Offset = "0x9956B0", VA = "0x1809964B0")]
	public static IEnumerable<T> LADIDOODOAO<T>(params T[] OMHJKAGBBKO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x2C25AD0", Offset = "0x2C24CD0", VA = "0x182C25AD0")]
	public static HashSet<T> IJPHALFEAFL<T>(params T[] OMHJKAGBBKO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2E796C0", Offset = "0x2E788C0", VA = "0x182E796C0")]
	public static KeyValuePair<TKey, TValue> HHIFBCMGKAK<TKey, TValue>([In] TKey CPBLLDDDHEE, [In] TValue JECHHBGMFLN) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2C25AD0", Offset = "0x2C24CD0", VA = "0x182C25AD0")]
	public static List<T> MNEHGHKBCCF<T>(IEnumerable<T> HJAFNJHIFIH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[AttributeUsage(AttributeTargets.All)]
public sealed class LBOOJLEKELP : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public readonly string OBBHNMFJOIB;

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x8C0750", Offset = "0x8BF950", VA = "0x1808C0750")]
	public LBOOJLEKELP(string LJAJEPCPDJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public delegate object GDFODKNBPGC<T>([In] T KLDEANCBDEG);
[Cpp2IlInjected.Token(Token = "0x200005A")]
public delegate object INPKHEDLAIO<T>(T KLDEANCBDEG);
[Cpp2IlInjected.Token(Token = "0x200005B")]
[BNNEFMKMFDK]
public delegate string JOELALKCDID(string JGFIBJEOOPG, string? AHJMNOJALCD, bool IGHBGMHAPHK);
[Cpp2IlInjected.Token(Token = "0x200005C")]
[BNNEFMKMFDK]
public delegate void MFKPBCPJNDD(string ADNFLGLLNKI);
[Cpp2IlInjected.Token(Token = "0x200005D")]
[BNNEFMKMFDK]
public delegate void BAMDLHGDELF(Exception JIAKIFPLAMP);
[Cpp2IlInjected.Token(Token = "0x200005E")]
public delegate object IBBLBGKDFJI();
[Cpp2IlInjected.Token(Token = "0x200005F")]
[BNNEFMKMFDK]
public delegate bool POEDOGMDLLN();
[Cpp2IlInjected.Token(Token = "0x2000060")]
[BNNEFMKMFDK]
public delegate string DGLDPCGFDPJ(object JMJAOKJJFGJ);
[Cpp2IlInjected.Token(Token = "0x2000061")]
[AttributeUsage(AttributeTargets.Enum)]
public class IDDJIPAOEDM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
	public IDDJIPAOEDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public static class AGHMLCNIGPA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct FFLMPJILJIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int millisecondsDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private CancellationTokenRegistration <cancellationTokenRegistration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private System.Threading.Timer <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private bool <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private object <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private int <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private bool <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private ValueTaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x6D3B650", Offset = "0x6D3A850", VA = "0x186D3B650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6D3BF40", Offset = "0x6D3B140", VA = "0x186D3BF40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly TimerCallback NMIKEIHIJME;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static readonly Action<object?> HBGLDPEDFAA;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6D36B90", Offset = "0x6D35D90", VA = "0x186D36B90")]
	public static Task<bool> ABPDBGLLDDC(int IBNJAKPEOCB, [Optional] CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6D36F20", Offset = "0x6D36120", VA = "0x186D36F20")]
	[AsyncStateMachine(typeof(FFLMPJILJIJ))]
	private static Task<bool> JJBNNFGBOLG(int IBNJAKPEOCB, CancellationToken DDNLBFLLCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6D37050", Offset = "0x6D36250", VA = "0x186D37050")]
	private static void KFGNIBHIMHD(object? NHDPLCKEAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6D36E90", Offset = "0x6D36090", VA = "0x186D36E90")]
	private static void BCIFPKGHLIJ(object? NHDPLCKEAAN)
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
