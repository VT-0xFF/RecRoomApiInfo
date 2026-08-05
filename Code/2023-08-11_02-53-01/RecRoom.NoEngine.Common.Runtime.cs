using System;
using System.Collections.Generic;
using System.Diagnostics;
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
		[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6E3FDF0", Offset = "0x6E3E5F0", VA = "0x186E3FDF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7EEC40", Offset = "0x7ED440", VA = "0x1807EEC40")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA14660", Offset = "0xA12E60", VA = "0x180A14660")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
public sealed class BPKDJGJIPFB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
	public BPKDJGJIPFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class OBCNCOMAAEA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xA14660", Offset = "0xA12E60", VA = "0x180A14660")]
	public OBCNCOMAAEA(bool PNDKCJNJJNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class BLPKINHPFHO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xA14660", Offset = "0xA12E60", VA = "0x180A14660")]
	public BLPKINHPFHO(bool PNDKCJNJJNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
public sealed class AKEDGJMIMCI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
	public AKEDGJMIMCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
public sealed class OCDJNGIPDMN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6E3FE80", Offset = "0x6E3E680", VA = "0x186E3FE80")]
	public OCDJNGIPDMN(bool PNDKCJNJJNP, string FCHMKCMADPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.All)]
public class MHJPGPDBDDN : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly string LKIEICODGFB;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7EEC40", Offset = "0x7ED440", VA = "0x1807EEC40")]
	public MHJPGPDBDDN(string PNEPJANIHCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class LBBFDFOIPGI
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class NKIFIPKPLBL<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public NKIFIPKPLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3315B20", Offset = "0x3314320", VA = "0x183315B20")]
		internal void GCLDLAFCCPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class GAMADENOEIK<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public GAMADENOEIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2A58790", Offset = "0x2A56F90", VA = "0x182A58790")]
		internal void CBAHFFJKEHI(Task<TResult> _)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class KNBDAEBFNCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public Task selfInternal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Exception <ex>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public KNBDAEBFNCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6E3E6D0", Offset = "0x6E3CED0", VA = "0x186E3E6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6E3E8D0", Offset = "0x6E3D0D0", VA = "0x186E3E8D0")]
	public static Task<TaskStatus> KBMKJKBEGGL(this Task PECDBPPMOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1D9D1B0", Offset = "0x1D9B9B0", VA = "0x181D9D1B0")]
	public static Task<T> KPHNOAAENPF<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6E3EA20", Offset = "0x6E3D220", VA = "0x186E3EA20")]
	public static Task NJDBJADKHEP(this Task KOOMIGAFDLJ, CancellationToken AMCDGOPKAOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1D9EA30", Offset = "0x1D9D230", VA = "0x181D9EA30")]
	public static Task<TResult> NJDBJADKHEP<TResult>(this Task<TResult> KOOMIGAFDLJ, CancellationToken AMCDGOPKAOE) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1D9F1F0", Offset = "0x1D9D9F0", VA = "0x181D9F1F0")]
	public static TaskCompletionSource<TResult> NJDBJADKHEP<TResult>(this TaskCompletionSource<TResult> FDPDMNLGALI, CancellationToken AMCDGOPKAOE) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6E3EC50", Offset = "0x6E3D450", VA = "0x186E3EC50")]
	[DebuggerStepThrough]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(KNBDAEBFNCA))]
	internal static Task<TaskStatus> OOHCHKLHDPP(Task FANGKPNKBLF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface IIGCLKAJIGA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	TimeSpan PBIENJLLJAI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Action? KGOPCDDOFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ACKODCLINCL();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OHACDJEAOED();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NGABIPLGKEG();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct AKKFNIOJIPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string PGHJLABHLGJ;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x9E4D50", Offset = "0x9E3550", VA = "0x1809E4D50")]
	public AKKFNIOJIPN(string MENBIMCLIOI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7DF100", Offset = "0x7DD900", VA = "0x1807DF100")]
	public static string HFMFJLJFEMO(in AKKFNIOJIPN PECDBPPMOJP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xB52CC0", Offset = "0xB514C0", VA = "0x180B52CC0")]
	public static AKKFNIOJIPN HFMFJLJFEMO(string OALEAAIPGBP)
	{
		return default(AKKFNIOJIPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6E3B7D0", Offset = "0x6E39FD0", VA = "0x186E3B7D0")]
	public string EOGNMOLMFAG(string KFBMNNOPDNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6E3B820", Offset = "0x6E3A020", VA = "0x186E3B820")]
	public string GDMPJNHPBDC(object HPHNHGOPBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7DF100", Offset = "0x7DD900", VA = "0x1807DF100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public readonly struct FJPNPFLKKKA<T> : IEquatable<FJPNPFLKKKA<T>>, PKABNOGAKFM<FJPNPFLKKKA<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly T PGHJLABHLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly int JNDMMPHMODJ;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1AB0200", Offset = "0x1AAEA00", VA = "0x181AB0200")]
	public FJPNPFLKKKA(in T MENBIMCLIOI, int AMOEKOMGDLG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x20353F0", Offset = "0x2033BF0", VA = "0x1820353F0")]
	public static bool MJNLEMCBPOF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0720", Offset = "0x6DFB20")] in FJPNPFLKKKA<T> KJDIMBCAJIJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0790", Offset = "0x6DFB90")] in FJPNPFLKKKA<T> EAIBHFHJJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x19D51C0", Offset = "0x19D39C0", VA = "0x1819D51C0", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0800", Offset = "0x6DFC00")] FJPNPFLKKKA<T> OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2034380", Offset = "0x2032B80", VA = "0x182034380", Slot = "0")]
	public override bool Equals(object OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2035570", Offset = "0x2033D70", VA = "0x182035570")]
	public bool OCGDGBEGKOE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0860", Offset = "0x6DFC60")] in FJPNPFLKKKA<T> OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x20347A0", Offset = "0x2032FA0", VA = "0x1820347A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x20355F0", Offset = "0x2033DF0", VA = "0x1820355F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2034B40", Offset = "0x2033340", VA = "0x182034B40")]
	public void LCNJHOAPLCH(out T MENBIMCLIOI, out int AMOEKOMGDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2034030", Offset = "0x2032830", VA = "0x182034030")]
	public (T, int) EDFPDCIGAJG()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2033F00", Offset = "0x2032700", VA = "0x182033F00", Slot = "5")]
	private bool CDBNLJNMIMA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E08D0", Offset = "0x6DFCD0")] in FJPNPFLKKKA<T> OALEAAIPGBP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class HMKMGHNKAHH
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2A1EB80", Offset = "0x2A1D380", VA = "0x182A1EB80")]
	public static FJPNPFLKKKA<T> NKAIHPJAMOL<T>(in T MENBIMCLIOI, int AMOEKOMGDLG) where T : notnull
	{
		return default(FJPNPFLKKKA<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct GADODCKGMOI : IEquatable<GADODCKGMOI>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7EE860", Offset = "0x7ED060", VA = "0x1807EE860", Slot = "4")]
	public bool Equals(GADODCKGMOI OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6E3C520", Offset = "0x6E3AD20", VA = "0x186E3C520", Slot = "0")]
	public override bool Equals(object OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6E3C570", Offset = "0x6E3AD70", VA = "0x186E3C570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6E3C580", Offset = "0x6E3AD80", VA = "0x186E3C580", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct LDGIJOFGMLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly GAENKJKIEPM GCPIIBOFCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly CBKDELGAFKL GCHAEDPANLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly MAFLFPDGEMN LBFGKDHNLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly HOLGEPODJOH PEBLLONEGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly KJNNOPOFHJJ PJHCLALAKJK;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly MAFLFPDGEMN JAJCPPNPIPB;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly HOLGEPODJOH AKNJOAHJLJG;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly KJNNOPOFHJJ AACCMHIEAAM;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly LDGIJOFGMLC GMPFDGPOJIJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BCALMCDLPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6E3EF00", Offset = "0x6E3D700", VA = "0x186E3EF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6E3F370", Offset = "0x6E3DB70", VA = "0x186E3F370")]
	public LDGIJOFGMLC(in GAENKJKIEPM LMIJEPBDAHN, in CBKDELGAFKL BNLNDPLOHPM, MAFLFPDGEMN FHBABADPBLP, HOLGEPODJOH ANLBMCMKHJP, KJNNOPOFHJJ JDMJMAKALGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6E3EEC0", Offset = "0x6E3D6C0", VA = "0x186E3EEC0")]
	private static string ILGLONKNPIL(object CEPDEAHBHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x893100", Offset = "0x891900", VA = "0x180893100")]
	private static long MFIAEEHELAH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x907390", Offset = "0x905B90", VA = "0x180907390")]
	private static string NFJIFONDEMH(string LBGIBGKJABF, string? DJBHHOHIDBJ, bool CMOJJHHHFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6E3EDA0", Offset = "0x6E3D5A0", VA = "0x186E3EDA0")]
	private static LDGIJOFGMLC AOLENGGLIIF()
	{
		return default(LDGIJOFGMLC);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct LEDMFJJGCEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public ulong EMMOCOIMIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public long GEDFMMFKOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public double EHAICJBHDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public uint AJLCJLLNKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public uint CFPAHHEBLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int ANOLPNFFPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int DIOBFBIJHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float CODPHOEIFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float LEFEFGAJJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public ushort AIKPPBDOODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public ushort KDHNIKLJAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public ushort FFGOMNDGCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public ushort EJCFCDKPODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public short DFBMHDOIKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public short HONIBONCCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public short GIEOIHGFAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public short IMIGEMPACHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public char BDGNCHHIOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public char HMPCNCIDHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public char AKLHIKFJACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public char JJHEKPADFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public byte EDDEDEMMFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte EHFMMLLMNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public byte KLHJADPJOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public byte GMNMENLMACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public byte OBEFIGBGKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public byte BMAKDHLKKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public byte FBDCIIJLKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public byte KLPPBJMHOID;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6E3F400", Offset = "0x6E3DC00", VA = "0x186E3F400")]
	public static LEDMFJJGCEB NKAIHPJAMOL(byte HEBJFAOIOJI, byte BHCLJDJAGGD, byte NDAIJGNNFII, byte IMHJBCOOLEK, byte PBBAPLPIFGF, byte EKCOIMEBNBK, byte EAPMAIOMAEI, byte IFJHHIHKMMF)
	{
		return default(LEDMFJJGCEB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct GAENKJKIEPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly LBNFEBLGDDO CBNEGPMBDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly BLHADBMDAID CGOCBKIMMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly LBNFEBLGDDO MIJFGOOCPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly BLHADBMDAID DDJGHGAJLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly LBNFEBLGDDO IPJPJMNLGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly BLHADBMDAID KOFENGDEAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly GEKHELADJJA DOHIEAGDMCG;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly LBNFEBLGDDO BMGHKIDCLMK;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly BLHADBMDAID JIDCFHKPKBI;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly LBNFEBLGDDO AHNPOCOLNCH;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly BLHADBMDAID FJKPLPBNFJL;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly LBNFEBLGDDO NPPLADAACGD;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly BLHADBMDAID CDHJGHEKKDM;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly GEKHELADJJA JEEOKNPNBNL;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly GAENKJKIEPM GMPFDGPOJIJ;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly LBNFEBLGDDO COJNNDAHHJL;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool BCALMCDLPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6E3C900", Offset = "0x6E3B100", VA = "0x186E3C900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1A501A0", Offset = "0x1A4E9A0", VA = "0x181A501A0")]
	public GAENKJKIEPM(LBNFEBLGDDO DACPIDHAOAD, BLHADBMDAID CCLLEFFFNII, LBNFEBLGDDO MKKJMHKOFKN, BLHADBMDAID BEHMPAIMCEP, LBNFEBLGDDO JMAMFKANEEO, BLHADBMDAID IIFLOPIEADI, GEKHELADJJA GIIICIEGCBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870")]
	private static bool NFHDPPPCCLH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	private static void OOFNMFLGGNH(string AKADEFDGONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870")]
	private static bool PIGMEADCDLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	private static void DFAPMNAADLK(string AKADEFDGONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870")]
	private static bool KJDBKKPAEAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	private static void FDAFEGBBCDF(string AKADEFDGONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	private static void DNIBIBGBGEO(Exception IDAOICDGJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6E3C6B0", Offset = "0x6E3AEB0", VA = "0x186E3C6B0")]
	private static GAENKJKIEPM AOLENGGLIIF()
	{
		return default(GAENKJKIEPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7EE860", Offset = "0x7ED060", VA = "0x1807EE860")]
	private static bool BHAHABELLCJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6E3C890", Offset = "0x6E3B090", VA = "0x186E3C890")]
	public void MFCLMPLONOJ(object AKADEFDGONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6E3C640", Offset = "0x6E3AE40", VA = "0x186E3C640")]
	public void AKOAFCLPEMF(object AKADEFDGONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6E3C870", Offset = "0x6E3B070", VA = "0x186E3C870")]
	public void LPAOFDMODNK(Exception IDAOICDGJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6E3C5B0", Offset = "0x6E3ADB0", VA = "0x186E3C5B0")]
	public void AKOAFCLPEMF(NAFGCKFJJPM AKADEFDGONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1B8DA70", Offset = "0x1B8C270", VA = "0x181B8DA70")]
	public void AKOAFCLPEMF<T>(T FFIGANEHPFB, ABADLMLJMLP<T> AKADEFDGONP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1B8DAF0", Offset = "0x1B8C2F0", VA = "0x181B8DAF0")]
	public void MFCLMPLONOJ<T>(in T FFIGANEHPFB, HMIBDMHOODK<T> AKADEFDGONP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6E3C7F0", Offset = "0x6E3AFF0", VA = "0x186E3C7F0")]
	public bool FPMBNPPACNH(bool KINAKFGHJFA, string AKADEFDGONP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class PFDCBKIFFEK
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1DF4AE0", Offset = "0x1DF32E0", VA = "0x181DF4AE0")]
	public static IEnumerable<T> KPFGLLJPGBG<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x907390", Offset = "0x905B90", VA = "0x180907390")]
	public static T[] JPOGCBPOMOA<T>(params T[] FJLHDJIJDMJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x907390", Offset = "0x905B90", VA = "0x180907390")]
	public static IEnumerable<T> JMEMKPFHGGL<T>(params T[] FJLHDJIJDMJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1AEE010", Offset = "0x1AEC810", VA = "0x181AEE010")]
	public static HashSet<T> JEFMLJMHDPN<T>(params T[] FJLHDJIJDMJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x22F76B0", Offset = "0x22F5EB0", VA = "0x1822F76B0")]
	public static KeyValuePair<TKey, TValue> ODOGMGIJKJJ<TKey, TValue>(in TKey EECINICJCLK, in TValue MENBIMCLIOI) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1AEE010", Offset = "0x1AEC810", VA = "0x181AEE010")]
	public static List<T> CNGPOBEIEJH<T>(IEnumerable<T> GFONPGDKJGC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[AttributeUsage(AttributeTargets.All)]
public sealed class KEDNLIFCNEC : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly string OAAFMIKLCND;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7EEC40", Offset = "0x7ED440", VA = "0x1807EEC40")]
	public KEDNLIFCNEC(string PPOOPCLIJJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class DCMNIEKBPAM
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3BE12B0", Offset = "0x3BDFAB0", VA = "0x183BE12B0")]
	public static AKKFNIOJIPN JAOFLFMADNG<T>()
	{
		return default(AKKFNIOJIPN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3BE1070", Offset = "0x3BDF870", VA = "0x183BE1070")]
	public static AKKFNIOJIPN GGJGMMFEOAC<T>([CallerMemberName] string MDOAADHDBMA = "") where T : notnull
	{
		return default(AKKFNIOJIPN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3BE1220", Offset = "0x3BDFA20", VA = "0x183BE1220")]
	public static AKKFNIOJIPN JAOFLFMADNG<T>(this T FFEHKCANNDI) where T : notnull
	{
		return default(AKKFNIOJIPN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3BE1340", Offset = "0x3BDFB40", VA = "0x183BE1340")]
	public static AKKFNIOJIPN KLBNDGICKHP<T>(this T FFEHKCANNDI, [CallerMemberName] string MDOAADHDBMA = "") where T : notnull
	{
		return default(AKKFNIOJIPN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3BE0FD0", Offset = "0x3BDF7D0", VA = "0x183BE0FD0")]
	public static AKKFNIOJIPN GGJGMMFEOAC<T>(this T PECDBPPMOJP, [CallerMemberName] string MDOAADHDBMA = "") where T : notnull
	{
		return default(AKKFNIOJIPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6E3C3E0", Offset = "0x6E3ABE0", VA = "0x186E3C3E0")]
	public static AKKFNIOJIPN GGJGMMFEOAC(string NMJELOJOPIH, [CallerMemberName] string MDOAADHDBMA = "")
	{
		return default(AKKFNIOJIPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6E3C460", Offset = "0x6E3AC60", VA = "0x186E3C460")]
	public static string PFLAMIBFIEH(this object PECDBPPMOJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[OGDGDBJEMGH]
public delegate long HOLGEPODJOH();
[Cpp2IlInjected.Token(Token = "0x200001D")]
public delegate void MCMEADJABPD<T>(in T FFIGANEHPFB);
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class ALEGIBJKPPP
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static LDGIJOFGMLC PHMNAEACGBH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static LDGIJOFGMLC POAPKELDIGC
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6E3BA40", Offset = "0x6E3A240", VA = "0x186E3BA40")]
		get
		{
			return default(LDGIJOFGMLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static GAENKJKIEPM GCPIIBOFCHA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6E3BCE0", Offset = "0x6E3A4E0", VA = "0x186E3BCE0")]
		get
		{
			return default(GAENKJKIEPM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static CBKDELGAFKL GCHAEDPANLF
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6E3BD40", Offset = "0x6E3A540", VA = "0x186E3BD40")]
		get
		{
			return default(CBKDELGAFKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6E3BAA0", Offset = "0x6E3A2A0", VA = "0x186E3BAA0")]
	public static void DDLOOGMPAKJ(in LDGIJOFGMLC EDLEIPEBGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6E3BF10", Offset = "0x6E3A710", VA = "0x186E3BF10")]
	public static void MFCLMPLONOJ(string AKADEFDGONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6E3B990", Offset = "0x6E3A190", VA = "0x186E3B990")]
	public static void AKOAFCLPEMF(string AKADEFDGONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1DF2290", Offset = "0x1DF0A90", VA = "0x181DF2290")]
	public static void AKOAFCLPEMF<T>(T FFIGANEHPFB, ABADLMLJMLP<T> AKADEFDGONP) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6E3BE90", Offset = "0x6E3A690", VA = "0x186E3BE90")]
	public static void LPAOFDMODNK(Exception IDAOICDGJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6E3BFC0", Offset = "0x6E3A7C0", VA = "0x186E3BFC0")]
	public static string PFLAMIBFIEH(object CEPDEAHBHLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6E3B920", Offset = "0x6E3A120", VA = "0x186E3B920")]
	public static long AKDIBMENNEE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6E3BC00", Offset = "0x6E3A400", VA = "0x186E3BC00")]
	public static bool FPMBNPPACNH(bool KINAKFGHJFA, string AKADEFDGONP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6E3BDA0", Offset = "0x6E3A5A0", VA = "0x186E3BDA0")]
	public static double JBOPGNEABAD()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class PHEDKGCCAKD : LHGDCPPHBDG
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly LHGDCPPHBDG OEFAOPMNMGM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DateTime LBNEKGJEKIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6E3FF60", Offset = "0x6E3E760", VA = "0x186E3FF60", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public PHEDKGCCAKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate)]
public class OGDGDBJEMGH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
	public OGDGDBJEMGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate TResult HLGLPMPGPPG<T, out TResult>(in T FFIGANEHPFB);
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate TResult IOPIMNFAOPF<T1, T2, out TResult>(in T1 IFGMPPOKIKC, in T2 LHEBIMPEACL);
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class JOFBIDLBDDH : IIGCLKAJIGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly TimeSpan DDAPNGCDCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly System.Timers.Timer FMGNKDAMMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private TimeSpan FKDBGBDFJED;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public TimeSpan PBIENJLLJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7EC6C0", Offset = "0x7EAEC0", VA = "0x1807EC6C0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6E3D140", Offset = "0x6E3B940", VA = "0x186E3D140", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Action? KGOPCDDOFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x892CB0", Offset = "0x8914B0", VA = "0x180892CB0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D590", Offset = "0x6E3BD90", VA = "0x186E3D590")]
	[Preserve]
	public JOFBIDLBDDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D370", Offset = "0x6E3BB70", VA = "0x186E3D370")]
	public JOFBIDLBDDH(TimeSpan FKDBGBDFJED, [Optional] Action? OEGNHJGCDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6E3CFC0", Offset = "0x6E3B7C0", VA = "0x186E3CFC0", Slot = "7")]
	public void ACKODCLINCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D2C0", Offset = "0x6E3BAC0", VA = "0x186E3D2C0", Slot = "8")]
	public void OHACDJEAOED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D290", Offset = "0x6E3BA90", VA = "0x186E3D290", Slot = "9")]
	public void NGABIPLGKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xAB2A80", Offset = "0xAB1280", VA = "0x180AB2A80")]
	private void KDCPNODDOLP(object FFEHKCANNDI, ElapsedEventArgs IJBNIMGCAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D0C0", Offset = "0x6E3B8C0", VA = "0x186E3D0C0")]
	private static void EKFDGLFIGKJ(ref TimeSpan IMPKKPHPMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D020", Offset = "0x6E3B820", VA = "0x186E3D020", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[AttributeUsage(AttributeTargets.Class)]
public class ACFLGLMHDEN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
	public ACFLGLMHDEN()
	{
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
public class KPHHNAMNHGD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
	public KPHHNAMNHGD(string FKMHBJMIHKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface LHGDCPPHBDG
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DateTime LBNEKGJEKIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct KGCPFKEFDKP : IEquatable<KGCPFKEFDKP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public uint JCCNDDEKENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public int GLNAGHFHBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float FMECJMBIFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public ushort AIKPPBDOODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public ushort KDHNIKLJAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public short DFBMHDOIKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public short HONIBONCCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public char BDGNCHHIOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public char HMPCNCIDHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public byte EDDEDEMMFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public byte EHFMMLLMNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public byte KLHJADPJOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public byte GMNMENLMACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public bool NGGIGPCBBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public bool OBCIAPHIFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public bool MPCBCEBHHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public bool ELOIKCEOFNB;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1560180", Offset = "0x155E980", VA = "0x181560180")]
	public static KGCPFKEFDKP FJMIBJOCCEC(uint AJBHICMABJK)
	{
		return default(KGCPFKEFDKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1560180", Offset = "0x155E980", VA = "0x181560180")]
	public static KGCPFKEFDKP HHOKDCNGFJA(int KEFBMLGFKNK)
	{
		return default(KGCPFKEFDKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D600", Offset = "0x6E3BE00", VA = "0x186E3D600")]
	public static KGCPFKEFDKP EBLFNKJKJEH(float IBMCMEBKIAH)
	{
		return default(KGCPFKEFDKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D6A0", Offset = "0x6E3BEA0", VA = "0x186E3D6A0")]
	public static KGCPFKEFDKP OIKGGIDKPFI(byte HEBJFAOIOJI, byte BHCLJDJAGGD, byte NDAIJGNNFII, byte IMHJBCOOLEK)
	{
		return default(KGCPFKEFDKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D6A0", Offset = "0x6E3BEA0", VA = "0x186E3D6A0")]
	public static KGCPFKEFDKP OLOKFFIIOJP(bool AEKNIHOPBPG, bool HBNPCENDBKH, bool LAFNBJDIJNF, bool KFMBHGGHOOP)
	{
		return default(KGCPFKEFDKP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x524B2E0", Offset = "0x5249AE0", VA = "0x18524B2E0")]
	public static bool MJNLEMCBPOF(KGCPFKEFDKP BENALFHNIOG, KGCPFKEFDKP EMAOEIAIOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3B90590", Offset = "0x3B8ED90", VA = "0x183B90590", Slot = "4")]
	public bool Equals(KGCPFKEFDKP OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D610", Offset = "0x6E3BE10", VA = "0x186E3D610", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x12450B0", Offset = "0x12438B0", VA = "0x1812450B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D6C0", Offset = "0x6E3BEC0", VA = "0x186E3D6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[MHJPGPDBDDN("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct IEHOCFMJKHE<T> : IEquatable<IEHOCFMJKHE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly T PGHJLABHLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly bool KFMPFIBHFNL;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool KFFMLEMHGOO
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x19D5020", Offset = "0x19D3820", VA = "0x1819D5020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x19D61D0", Offset = "0x19D49D0", VA = "0x1819D61D0")]
	public IEHOCFMJKHE(in T MENBIMCLIOI, bool HADPMMPANLC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x19D5A90", Offset = "0x19D4290", VA = "0x1819D5A90")]
	public static bool MJNLEMCBPOF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0C00", Offset = "0x6E0000")] in IEHOCFMJKHE<T> KJDIMBCAJIJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0C70", Offset = "0x6E0070")] in IEHOCFMJKHE<T> EAIBHFHJJFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x19D51C0", Offset = "0x19D39C0", VA = "0x1819D51C0", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0CE0", Offset = "0x6E00E0")] IEHOCFMJKHE<T> OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x19D5520", Offset = "0x19D3D20", VA = "0x1819D5520", Slot = "0")]
	public override bool Equals(object OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x19D5A10", Offset = "0x19D4210", VA = "0x1819D5A10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x19D5FB0", Offset = "0x19D47B0", VA = "0x1819D5FB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class PMMOFCCNOGF
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x22FC080", Offset = "0x22FA880", VA = "0x1822FC080")]
	public static IEHOCFMJKHE<T> EIJCOFKBDFE<T>(in T MENBIMCLIOI) where T : notnull
	{
		return default(IEHOCFMJKHE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x22FC190", Offset = "0x22FA990", VA = "0x1822FC190")]
	public static IEHOCFMJKHE<T?> GEGMAPEKCEL<T>()
	{
		return default(IEHOCFMJKHE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x22FC2D0", Offset = "0x22FAAD0", VA = "0x1822FC2D0")]
	public static bool HLPPNLLCDJB<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E0D40", Offset = "0x6E0140")] this in IEHOCFMJKHE<T> HJPHEPDMJKK, [OBCNCOMAAEA(true)] out T MENBIMCLIOI) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface PKABNOGAKFM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OCGDGBEGKOE(in T OALEAAIPGBP);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public readonly struct CBKDELGAFKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly PALJKONAPEJ BNCCHGLMFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public readonly EKBPGDIJOGP MCODMCDCKFD;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly PALJKONAPEJ OPNKMNBAHMO;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public static readonly EKBPGDIJOGP MALAHIFBPBD;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly CBKDELGAFKL GMPFDGPOJIJ;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool BCALMCDLPAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6E3C180", Offset = "0x6E3A980", VA = "0x186E3C180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0xB84550", Offset = "0xB82D50", VA = "0x180B84550")]
	public CBKDELGAFKL(PALJKONAPEJ EPJNDHLLAED, EKBPGDIJOGP BOMIEJPFCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	private static void HJGOPFJNEHB(string MDOAADHDBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
	private static void ONJFNHEJGMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6E3C0F0", Offset = "0x6E3A8F0", VA = "0x186E3C0F0")]
	private static CBKDELGAFKL AOLENGGLIIF()
	{
		return default(CBKDELGAFKL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class ANDEPLHGODN
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x1DF3BC0", Offset = "0x1DF23C0", VA = "0x181DF3BC0")]
	public static bool OCGDGBEGKOE<T, U>(in T PECDBPPMOJP, in U CEPDEAHBHLF) where T : notnull, PKABNOGAKFM<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class HMJIPLGJGAM<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly EqualityComparer<T> EKCJANBOLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public T PGHJLABHLGJ;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x21A8B10", Offset = "0x21A7310", VA = "0x1821A8B10")]
	public HMJIPLGJGAM(in T MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3A2EB00", Offset = "0x3A2D300", VA = "0x183A2EB00", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3A2F0C0", Offset = "0x3A2D8C0", VA = "0x183A2F0C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3A2F3B0", Offset = "0x3A2DBB0", VA = "0x183A2F3B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class LOIENGPOOCL
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static long AEPOINFLPAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6E3F9C0", Offset = "0x6E3E1C0", VA = "0x186E3F9C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static long BMCEFKLBFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6E3F750", Offset = "0x6E3DF50", VA = "0x186E3F750")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static double PGGPILAHFMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6E3F6F0", Offset = "0x6E3DEF0", VA = "0x186E3F6F0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static double NFJCOLJAIGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6E3F8B0", Offset = "0x6E3E0B0", VA = "0x186E3F8B0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static double JGEGKOKJKLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6E3F690", Offset = "0x6E3DE90", VA = "0x186E3F690")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static double OEKMJNFFDKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6E3F510", Offset = "0x6E3DD10", VA = "0x186E3F510")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6E3F910", Offset = "0x6E3E110", VA = "0x186E3F910")]
	public static double MNCIFFKOAHA(long BAPGPENJHAJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6E3F570", Offset = "0x6E3DD70", VA = "0x186E3F570")]
	public static double DPKMJBMLGOD(long BAPGPENJHAJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6E3F460", Offset = "0x6E3DC60", VA = "0x186E3F460")]
	public static double CBBBHFBKEGK(double OLPLGGNOCKK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6E3FA20", Offset = "0x6E3E220", VA = "0x186E3FA20")]
	public static long NCBIMJBKLKA(long MDHEGNJEGJG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6E3FAD0", Offset = "0x6E3E2D0", VA = "0x186E3FAD0")]
	public static long PJKNCODMLCB(long AOGDNMCOJFA, long KJLPMLBEHLM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6E3F7B0", Offset = "0x6E3DFB0", VA = "0x186E3F7B0")]
	public static double KCEILDKPHOF(long AOGDNMCOJFA, long KJLPMLBEHLM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6E3F620", Offset = "0x6E3DE20", VA = "0x186E3F620")]
	public static double FOIMEHCJKCD(long AOGDNMCOJFA, long KJLPMLBEHLM)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[OGDGDBJEMGH]
public delegate void BLHADBMDAID(string AKADEFDGONP);
[Cpp2IlInjected.Token(Token = "0x2000031")]
[OGDGDBJEMGH]
public delegate string MAFLFPDGEMN(object CEPDEAHBHLF);
[Cpp2IlInjected.Token(Token = "0x2000032")]
[OGDGDBJEMGH]
public delegate void EKBPGDIJOGP();
[Cpp2IlInjected.Token(Token = "0x2000033")]
public delegate object HMIBDMHOODK<T>(in T HPDOEALAHJH);
[Cpp2IlInjected.Token(Token = "0x2000034")]
public delegate object NAFGCKFJJPM();
[Cpp2IlInjected.Token(Token = "0x2000035")]
[OGDGDBJEMGH]
public delegate string KJNNOPOFHJJ(string LBGIBGKJABF, string? DJBHHOHIDBJ, bool CMOJJHHHFND);
[Cpp2IlInjected.Token(Token = "0x2000036")]
[OGDGDBJEMGH]
public delegate bool LBNFEBLGDDO();
[Cpp2IlInjected.Token(Token = "0x2000037")]
public delegate object ABADLMLJMLP<T>(T HPDOEALAHJH);
[Cpp2IlInjected.Token(Token = "0x2000038")]
[OGDGDBJEMGH]
public delegate void PALJKONAPEJ(string MDOAADHDBMA);
[Cpp2IlInjected.Token(Token = "0x2000039")]
[OGDGDBJEMGH]
public delegate void GEKHELADJJA(Exception IDAOICDGJBJ);
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
