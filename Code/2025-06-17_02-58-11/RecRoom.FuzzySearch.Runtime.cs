using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Logging.Attributes;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C610", Offset = "0x7D7B010", VA = "0x187D7C610")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA35A80", Offset = "0xA34480", VA = "0x180A35A80")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA35AC0", Offset = "0xA344C0", VA = "0x180A35AC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_FuzzySearch_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : GIIBELOIOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C3D0", Offset = "0x7D7ADD0", VA = "0x187D7C3D0", Slot = "4")]
		public override void EPIAMCEAEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class CJOHMLJAEBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly EHCEGNIDAPH NCKMCOFLEHM;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7D783F0", Offset = "0x7D76DF0", VA = "0x187D783F0")]
	public CJOHMLJAEBD(IReadOnlyCollection<string> LOPJKMIHCBE, [In] LDADFAIBOHL BKOBIBOAODL, [Optional] EHCEGNIDAPH.DJOKDFDKMLF HMNAJNBHMDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7D781B0", Offset = "0x7D76BB0", VA = "0x187D781B0")]
	public IReadOnlyList<AGCPIHPLBDB> MMBJPLLNHFL(string MPJGCINHBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7D78010", Offset = "0x7D76A10", VA = "0x187D78010")]
	public void BPBKDABJBBC(string MPJGCINHBNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class EHCEGNIDAPH
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate int DJOKDFDKMLF(IReadOnlyList<char> MFDCNMOJJPK, int LBBPGAGCAIP, string POKJBIAAPNA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly LDADFAIBOHL EBLOCAHCMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly DJOKDFDKMLF FELNOBPGNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly char[] FFJPDGAMFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly AGCPIHPLBDB[] JONELKFDGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly bool[] OGCIGFKCJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly (int SearchStringIndex, int ConsecutiveCount, int Value)[] GELNBMCPLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly AGCPIHPLBDB[] FNNJPNPCJHP;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0")]
	public static int ENICEAEDOAF(IReadOnlyList<char> MFDCNMOJJPK, int LBBPGAGCAIP, string POKJBIAAPNA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7D794A0", Offset = "0x7D77EA0", VA = "0x187D794A0")]
	public EHCEGNIDAPH(IReadOnlyCollection<string> LOPJKMIHCBE, [In] LDADFAIBOHL BKOBIBOAODL, [Optional] DJOKDFDKMLF HMNAJNBHMDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7D79410", Offset = "0x7D77E10", VA = "0x187D79410")]
	public string LFEGNDGCNLF(string MPJGCINHBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7D79400", Offset = "0x7D77E00", VA = "0x187D79400")]
	public int JCIINBKPCDM(int GNFELOBOIOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7D78E00", Offset = "0x7D77800", VA = "0x187D78E00")]
	public int BPBKDABJBBC(string MPJGCINHBNH, int BGDJINPBPKN, int BLEBJDOHHKO, int LBBPGAGCAIP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct LDADFAIBOHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly bool DDGPPPDGLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool ONFALFDBJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly int CGMLOFPNHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly int JBKGJOBKICM;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly LDADFAIBOHL BADJEECFIJC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static LDADFAIBOHL MCHDAMDLAPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C2D0", Offset = "0x7D7ACD0", VA = "0x187D7C2D0")]
		get
		{
			return default(LDADFAIBOHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7D7C380", Offset = "0x7D7AD80", VA = "0x187D7C380")]
	public LDADFAIBOHL(bool HEHJJDLKGNG, bool KICHFPCCDIC, int AAENNGJMEPB, int MKOCKMDPOAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct AGCPIHPLBDB : IEquatable<AGCPIHPLBDB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly int FOIACCDFCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly int BPBKDABJBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly int EMEBCDODGHK;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xDC4DD0", Offset = "0xDC37D0", VA = "0x180DC4DD0")]
	public AGCPIHPLBDB(int MNFHMLCLFEB, int MCNKBDLMEDO, int OEJDNBCBFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7D77C60", Offset = "0x7D76660", VA = "0x187D77C60")]
	public static int ONDMPCEFLHH([In] AGCPIHPLBDB LCMCGCNDGLJ, [In] AGCPIHPLBDB JAOCPECLJLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x27A5C50", Offset = "0x27A4650", VA = "0x1827A5C50", Slot = "4")]
	public bool Equals(AGCPIHPLBDB NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7D77B40", Offset = "0x7D76540", VA = "0x187D77B40", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7D77BF0", Offset = "0x7D765F0", VA = "0x187D77BF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HLABBAJBIEB
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IPCJPAKNIHD(string MPJGCINHBNH, [Out][NotNullWhen(true)] IReadOnlyList<HDFFLNDLAHM>? NONPLOKGMEC);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class ACLPPFAFPJI : HLABBAJBIEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly int JMCGFEPJLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly List<(string searchString, IReadOnlyList<HDFFLNDLAHM> results)> DIAPHCLLMBP;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7D77AA0", Offset = "0x7D764A0", VA = "0x187D77AA0")]
	public ACLPPFAFPJI(int JMCGFEPJLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7D77920", Offset = "0x7D76320", VA = "0x187D77920", Slot = "4")]
	public bool IPCJPAKNIHD(string MPJGCINHBNH, [Out][NotNullWhen(true)] IReadOnlyList<HDFFLNDLAHM>? NONPLOKGMEC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class NFMDMIPJGFK
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate void GEKOGFCKEII(IReadOnlyList<HDFFLNDLAHM> NONPLOKGMEC);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class LKGDHIMHFHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public NFMDMIPJGFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public string searchString;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public LKGDHIMHFHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C3A0", Offset = "0x7D7ADA0", VA = "0x187D7C3A0")]
		internal HDFFLNDLAHM[] HEBFMNNHHBB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct BBOMDKAOFBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public NFMDMIPJGFK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string searchString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public GEKOGFCKEII onSearchComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private CancellationTokenSource <localCts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<HDFFLNDLAHM[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7D77C80", Offset = "0x7D76680", VA = "0x187D77C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private CancellationTokenSource? LCAAPFCGOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly GPEGIHIOIMC GBFELKCCCAM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool PKFPHGEBEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xBCF0D0", Offset = "0xBCDAD0", VA = "0x180BCF0D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xDAE760", Offset = "0xDAD160", VA = "0x180DAE760")]
	public NFMDMIPJGFK(GPEGIHIOIMC GBFELKCCCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7D7C4A0", Offset = "0x7D7AEA0", VA = "0x187D7C4A0")]
	[AsyncStateMachine(typeof(BBOMDKAOFBI))]
	public void MMBJPLLNHFL(string MPJGCINHBNH, GEKOGFCKEII JJNDMPDODDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7D7C460", Offset = "0x7D7AE60", VA = "0x187D7C460")]
	public void JCMHGMGGFCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class ELKINPCFMCB
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7D79F80", Offset = "0x7D78980", VA = "0x187D79F80")]
	public static NFMDMIPJGFK AEAFGIHPCDI(this GPEGIHIOIMC GBFELKCCCAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class GPEGIHIOIMC
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate int DPLFLPOINGO(ReadOnlySpan<char> MPJGCINHBNH, ReadOnlySpan<char> OBMGBFOLFFL, int IJGCHKBIIMH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly IKKJMPODAMH MPNLMIPKIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly FDMHKOKAKOB MCNGHICCIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly DPLFLPOINGO? BPNKPMNEEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private HDFFLNDLAHM[] NLECCJDJBPO;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7D7B060", Offset = "0x7D79A60", VA = "0x187D7B060")]
	public GPEGIHIOIMC(IKKJMPODAMH MPNLMIPKIOI, FDMHKOKAKOB MCNGHICCIEK, [Optional] DPLFLPOINGO? BPNKPMNEEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A9F0", Offset = "0x7D793F0", VA = "0x187D7A9F0")]
	public HDFFLNDLAHM[] MMBJPLLNHFL(string MPJGCINHBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A960", Offset = "0x7D79360", VA = "0x187D7A960")]
	private static int FNLLHPCADEN([In] HDFFLNDLAHM LCMCGCNDGLJ, [In] HDFFLNDLAHM JAOCPECLJLL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct HDFFLNDLAHM
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class PGFDFEIMEBM : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private bool <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public HDFFLNDLAHM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public HDFFLNDLAHM <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool IEnumerator<bool>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x11BEB10", Offset = "0x11BD510", VA = "0x1811BEB10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7D7C840", Offset = "0x7D7B240", VA = "0x187D7C840", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x13C4D70", Offset = "0x13C3770", VA = "0x1813C4D70")]
		[DebuggerHidden]
		public PGFDFEIMEBM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C690", Offset = "0x7D7B090", VA = "0x187D7C690", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C7F0", Offset = "0x7D7B1F0", VA = "0x187D7C7F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C730", Offset = "0x7D7B130", VA = "0x187D7C730", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C730", Offset = "0x7D7B130", VA = "0x187D7C730", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly float BPBKDABJBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly int FOIACCDFCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly ReadOnlyMemory<char> BAFJNFMGHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly BitArray ENOENDCFMJJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public readonly IEnumerable<bool> GIFIKFNPKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7D7B160", Offset = "0x7D79B60", VA = "0x187D7B160")]
		[IteratorStateMachine(typeof(PGFDFEIMEBM))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7D7B1F0", Offset = "0x7D79BF0", VA = "0x187D7B1F0")]
	public HDFFLNDLAHM(float MCNKBDLMEDO, int MNFHMLCLFEB, ReadOnlyMemory<char> DKLAGICAOGN, IEnumerable<int> ENOENDCFMJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct IJCNIGIOMHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly bool DDGPPPDGLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool ONFALFDBJHM;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5268460", Offset = "0x5266E60", VA = "0x185268460")]
	public IJCNIGIOMHO(bool FNMICNFOFHN, bool IPLKIPMIBBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7D7C240", Offset = "0x7D7AC40", VA = "0x187D7C240")]
	public string KNDMJJHCAJG(string JDGADODOANI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FDMHKOKAKOB
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	float BPBKDABJBBC(ReadOnlySpan<char> MPJGCINHBNH, ReadOnlySpan<char> OBMGBFOLFFL, [Optional] List<int>? EBHEICOMENK);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class GGOHDIOLBDI : FDMHKOKAKOB
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct CHCMJGGICPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly float MKHHBHEILIO;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2B1DA80", Offset = "0x2B1C480", VA = "0x182B1DA80")]
		public CHCMJGGICPA(float CBJOPGGAOLC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int[] GCLPBPDAAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int[] OLBPFMELGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private BitArray HMHNIEOIEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CHCMJGGICPA BKOBIBOAODL;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A880", Offset = "0x7D79280", VA = "0x187D7A880")]
	public GGOHDIOLBDI([In] CHCMJGGICPA BKOBIBOAODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7D79FF0", Offset = "0x7D789F0", VA = "0x187D79FF0", Slot = "4")]
	public float BPBKDABJBBC(ReadOnlySpan<char> MPJGCINHBNH, ReadOnlySpan<char> OBMGBFOLFFL, [Optional] List<int>? EBHEICOMENK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A480", Offset = "0x7D78E80", VA = "0x187D7A480")]
	private void NFDDKLLMKKL(int OPKPFANIILK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A510", Offset = "0x7D78F10", VA = "0x187D7A510")]
	private float OHJHHBHCCLA(ReadOnlySpan<char> MPJGCINHBNH, ReadOnlySpan<char> OBMGBFOLFFL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7D7A370", Offset = "0x7D78D70", VA = "0x187D7A370")]
	private int HPKDIEIPOHF(ReadOnlySpan<char> GBFELKCCCAM, ReadOnlySpan<char> DKLAGICAOGN, int PKCDCJMFFCN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class HGNOHAIAJLP : FDMHKOKAKOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int AAENNGJMEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private BitArray? IHHPPIHKOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private (int SearchStringIndex, int ConsecutiveCount, int Value)[] NOLPMOGCCGC;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7D7BB00", Offset = "0x7D7A500", VA = "0x187D7BB00")]
	public HGNOHAIAJLP(int AAENNGJMEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7D7B450", Offset = "0x7D79E50", VA = "0x187D7B450", Slot = "4")]
	public float BPBKDABJBBC(ReadOnlySpan<char> MPJGCINHBNH, ReadOnlySpan<char> OBMGBFOLFFL, [Optional] List<int>? EBHEICOMENK)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface IKKJMPODAMH
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IEnumerable<ReadOnlyMemory<char>> CNHEOKDIINJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class DHONIMICPKE : IKKJMPODAMH
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class IBHOODOKIFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public IJCNIGIOMHO settings;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public IBHOODOKIFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7D7BBB0", Offset = "0x7D7A5B0", VA = "0x187D7BBB0")]
		internal string HKNPEBJEBAB(string t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class ICNMIEIGALO : IEnumerable<ReadOnlyMemory<char>>, IEnumerable, IEnumerator<ReadOnlyMemory<char>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private ReadOnlyMemory<char> <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public DHONIMICPKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private ReadOnlyMemory<char> <targetsMemory>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private IEnumerator<BBBOGPEJDNL<char>> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		ReadOnlyMemory<char> IEnumerator<ReadOnlyMemory<char>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xC9A360", Offset = "0xC98D60", VA = "0x180C9A360", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(ReadOnlyMemory<char>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7D7C160", Offset = "0x7D7AB60", VA = "0x187D7C160", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2795330", Offset = "0x2793D30", VA = "0x182795330")]
		[DebuggerHidden]
		public ICNMIEIGALO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C1B0", Offset = "0x7D7ABB0", VA = "0x187D7C1B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7D7BC90", Offset = "0x7D7A690", VA = "0x187D7BC90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7D7BC40", Offset = "0x7D7A640", VA = "0x187D7BC40")]
		private void KIPLFAABBJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C110", Offset = "0x7D7AB10", VA = "0x187D7C110", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C060", Offset = "0x7D7AA60", VA = "0x187D7C060", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<ReadOnlyMemory<char>> IEnumerable<ReadOnlyMemory<char>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C060", Offset = "0x7D7AA60", VA = "0x187D7C060", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly char[] NHBPCNLKLAH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IEnumerable<ReadOnlyMemory<char>> CNHEOKDIINJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7D784A0", Offset = "0x7D76EA0", VA = "0x187D784A0", Slot = "4")]
		[IteratorStateMachine(typeof(ICNMIEIGALO))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7D78520", Offset = "0x7D76F20", VA = "0x187D78520")]
	public DHONIMICPKE(IEnumerable<string> MPNLMIPKIOI, IJCNIGIOMHO BKOBIBOAODL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class LHFIHCGLAMA<TSchedulerContext> : IDisposable where TSchedulerContext : notnull, MonoBehaviour, INBJDGLCFFF
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate void HJNEALOHFIO(IReadOnlyList<AGCPIHPLBDB> NONPLOKGMEC, IReadOnlyList<bool> GEIPDMIHHGM);

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private const string MMKCGKGMMND = "r2adoption_2025q2_better_palette_search";

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private const string BOANMKPKICB = "algorithm";

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static NDICJCLBPMH? DGDCHCJJMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly HLABBAJBIEB? DIAPHCLLMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly NFMDMIPJGFK GBFELKCCCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly IJCNIGIOMHO IIPFOJMHKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly LDADFAIBOHL BKOBIBOAODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly HJNEALOHFIO PCOHHBFJEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly GPEGIHIOIMC.DPLFLPOINGO? BPNKPMNEEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private IReadOnlyList<AGCPIHPLBDB> NAFBJNEPFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private IReadOnlyList<bool> EJENIAHOBEI;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<AGCPIHPLBDB> JFOMBFKOBLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA0A540", Offset = "0xA08F40", VA = "0x180A0A540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyList<bool> GBDFEDDOPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA091E0", Offset = "0xA07BE0", VA = "0x180A091E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool PKFPHGEBEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x528A680", Offset = "0x5289080", VA = "0x18528A680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x528AA30", Offset = "0x5289430", VA = "0x18528AA30")]
	public LHFIHCGLAMA(IReadOnlyList<string> LOPJKMIHCBE, [In] LDADFAIBOHL BKOBIBOAODL, HJNEALOHFIO JJNDMPDODDM, [Optional] GPEGIHIOIMC.DPLFLPOINGO? BPNKPMNEEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5289F30", Offset = "0x5288930", VA = "0x185289F30")]
	public void FFOFOIHCMKN(string MPJGCINHBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x528A0B0", Offset = "0x5288AB0", VA = "0x18528A0B0")]
	private void FKIEFEGNEAI(IReadOnlyList<HDFFLNDLAHM> NONPLOKGMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5289D30", Offset = "0x5288730", VA = "0x185289D30")]
	private int COHDMFENHCL(ReadOnlySpan<char> CHCCOOMJKLJ, ReadOnlySpan<char> DKLAGICAOGN, int BAAOCFBPLKK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x528A6A0", Offset = "0x52890A0", VA = "0x18528A6A0")]
	private FDMHKOKAKOB KFCHMBGDKME()
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
