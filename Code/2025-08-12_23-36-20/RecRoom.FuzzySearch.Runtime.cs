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

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x83BBE30", Offset = "0x83BAC30", VA = "0x1883BBE30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xABFA20", Offset = "0xABE820", VA = "0x180ABFA20")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xABFA60", Offset = "0xABE860", VA = "0x180ABFA60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_FuzzySearch_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : GDJKPKDCEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x83BB630", Offset = "0x83BA430", VA = "0x1883BB630", Slot = "4")]
		public override void FAIIODDINIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class CDLJIJNIANL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly CBDJDICEKOK OHJBKIGEIPA;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x83B9170", Offset = "0x83B7F70", VA = "0x1883B9170")]
	public CDLJIJNIANL(IReadOnlyCollection<string> IKGIJKKMJJP, [In] NALFKNIINOF KOEIEIJLGHF, [Optional] CBDJDICEKOK.EDHCOOBDAPD MDNBHHIMEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x83B8F30", Offset = "0x83B7D30", VA = "0x1883B8F30")]
	public IReadOnlyList<HCCLCHFHGOJ> KKNLPKOAOML(string EMKHPHOFHMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x83B8D90", Offset = "0x83B7B90", VA = "0x1883B8D90")]
	public void GEOIJKFGJFP(string EMKHPHOFHMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class CBDJDICEKOK
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate int EDHCOOBDAPD(IReadOnlyList<char> ALLABDGFDDF, int IHMJJDKHBKN, string LLPBOLIEBAC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly NALFKNIINOF AAGMEGOIGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly EDHCOOBDAPD OHNAGMIOAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly char[] LEIPDGIIICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly HCCLCHFHGOJ[] JOLJDOILEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly bool[] JDOPFEIMGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly (int SearchStringIndex, int ConsecutiveCount, int Value)[] LADKCFPLJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly HCCLCHFHGOJ[] NGABGBGCELF;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00")]
	public static int EHGGDMOBILG(IReadOnlyList<char> ALLABDGFDDF, int IHMJJDKHBKN, string LLPBOLIEBAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x83B82A0", Offset = "0x83B70A0", VA = "0x1883B82A0")]
	public CBDJDICEKOK(IReadOnlyCollection<string> IKGIJKKMJJP, [In] NALFKNIINOF KOEIEIJLGHF, [Optional] EDHCOOBDAPD MDNBHHIMEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x83B7C00", Offset = "0x83B6A00", VA = "0x1883B7C00")]
	public string CEFCECDHAHM(string EMKHPHOFHMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x83B7C90", Offset = "0x83B6A90", VA = "0x1883B7C90")]
	public int CMECMOALFLM(int CHOJDPJBBGP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x83B7CA0", Offset = "0x83B6AA0", VA = "0x1883B7CA0")]
	public int GEOIJKFGJFP(string EMKHPHOFHMN, int LNOCIHNBPDF, int LCGIGHEKPME, int IHMJJDKHBKN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct NALFKNIINOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly bool MGNAMNDEFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool HNCIKIAOKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly int BJCHFCIFKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly int HEIIKPCGFPK;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly NALFKNIINOF GPDMHGDJPMH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static NALFKNIINOF HANIMDCJEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x83BBD60", Offset = "0x83BAB60", VA = "0x1883BBD60")]
		get
		{
			return default(NALFKNIINOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x83BBE10", Offset = "0x83BAC10", VA = "0x1883BBE10")]
	public NALFKNIINOF(bool JDEOLBDFIHK, bool MOMGBBOANBE, int CCHPMNFMGMA, int IDDOJGEGPLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct HCCLCHFHGOJ : IEquatable<HCCLCHFHGOJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly int NELPMDCEMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly int GEOIJKFGJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly int MNLNHNAKIIL;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xE9E8B0", Offset = "0xE9D6B0", VA = "0x180E9E8B0")]
	public HCCLCHFHGOJ(int JJJJBEGKNIN, int JDFDDINNLMP, int BEOJDLNPCNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x83BA540", Offset = "0x83B9340", VA = "0x1883BA540")]
	public static int DKPBPPFBIBL([In] HCCLCHFHGOJ CHAEOFDBIAH, [In] HCCLCHFHGOJ EBEGEKLHGJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2950280", Offset = "0x294F080", VA = "0x182950280", Slot = "4")]
	public bool Equals(HCCLCHFHGOJ FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x83BA560", Offset = "0x83B9360", VA = "0x1883BA560", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x83BA610", Offset = "0x83B9410", VA = "0x1883BA610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IPOJLCCPBHB
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AMJHJJBKDMO(string EMKHPHOFHMN, [Out][NotNullWhen(true)] IReadOnlyList<BEPKINPMOOB>? LFLGOCOHDIN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class DLBEAIIACBO : IPOJLCCPBHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly int JBGBFEPENFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly List<(string searchString, IReadOnlyList<BEPKINPMOOB> results)> FAJIBAIPGCN;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x83B9430", Offset = "0x83B8230", VA = "0x1883B9430")]
	public DLBEAIIACBO(int JBGBFEPENFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x83B92B0", Offset = "0x83B80B0", VA = "0x1883B92B0", Slot = "4")]
	public bool AMJHJJBKDMO(string EMKHPHOFHMN, [Out][NotNullWhen(true)] IReadOnlyList<BEPKINPMOOB>? LFLGOCOHDIN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class JOEGKEFNKCF
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate void EGGKBOCBAFH(IReadOnlyList<BEPKINPMOOB> LFLGOCOHDIN);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class MHJOHDAOIFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public JOEGKEFNKCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CancellationTokenSource localCts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string searchString;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public MHJOHDAOIFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x83BB6C0", Offset = "0x83BA4C0", VA = "0x1883BB6C0")]
		internal BEPKINPMOOB[] FENMAHNHKHK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct IDDAANNAGEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public JOEGKEFNKCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public string searchString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private MHJOHDAOIFB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public EGGKBOCBAFH onSearchComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<BEPKINPMOOB[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x83BAC80", Offset = "0x83B9A80", VA = "0x1883BAC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xAE56D0", Offset = "0xAE44D0", VA = "0x180AE56D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly BEJFNDMKLIP CPPEAAHODOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly GBHOBCGGGDM OGJKCKCGMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly EAFNKBIMELC.JBJMCILPBME? CDBLPMNEMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private BEPKINPMOOB[] HFHBEGLCOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private CancellationTokenSource? OBNLICOECJC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool PKJHPKDONAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1276120", Offset = "0x1274F20", VA = "0x181276120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x83BB580", Offset = "0x83BA380", VA = "0x1883BB580")]
	public JOEGKEFNKCF(BEJFNDMKLIP CPPEAAHODOM, GBHOBCGGGDM OGJKCKCGMOA, [Optional] EAFNKBIMELC.JBJMCILPBME? CDBLPMNEMIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x83BB410", Offset = "0x83BA210", VA = "0x1883BB410")]
	[AsyncStateMachine(typeof(IDDAANNAGEC))]
	public void KKNLPKOAOML(string EMKHPHOFHMN, EGGKBOCBAFH AHFOFNGHMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x83BB3D0", Offset = "0x83BA1D0", VA = "0x1883BB3D0")]
	public void HHJCEDNCEAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class EAFNKBIMELC
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate int JBJMCILPBME(ReadOnlySpan<char> EMKHPHOFHMN, ReadOnlySpan<char> HIOHILJMNDF, int GNILEOFEGFC);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x83BA420", Offset = "0x83B9220", VA = "0x1883BA420")]
	public static int HMDPOLKDGFI([In] BEPKINPMOOB CHAEOFDBIAH, [In] BEPKINPMOOB EBEGEKLHGJL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct BEPKINPMOOB
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class JBAANFNKPNK : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
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
		public BEPKINPMOOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public BEPKINPMOOB <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool IEnumerator<bool>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x12FD860", Offset = "0x12FC660", VA = "0x1812FD860", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x83BB250", Offset = "0x83BA050", VA = "0x1883BB250", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x15522F0", Offset = "0x15510F0", VA = "0x1815522F0")]
		[DebuggerHidden]
		public JBAANFNKPNK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x83BB0A0", Offset = "0x83B9EA0", VA = "0x1883BB0A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x83BB200", Offset = "0x83BA000", VA = "0x1883BB200", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x83BB140", Offset = "0x83B9F40", VA = "0x1883BB140", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x83BB140", Offset = "0x83B9F40", VA = "0x1883BB140", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly float GEOIJKFGJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly int NELPMDCEMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly ReadOnlyMemory<char> GCHGJLEBDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly BitArray KNDAMKMOEDC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public readonly IEnumerable<bool> HNKHEIECJDK
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x83B7900", Offset = "0x83B6700", VA = "0x1883B7900")]
		[IteratorStateMachine(typeof(JBAANFNKPNK))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x83B7990", Offset = "0x83B6790", VA = "0x1883B7990")]
	public BEPKINPMOOB(float JDFDDINNLMP, int JJJJBEGKNIN, ReadOnlyMemory<char> BNIHAACOHPG, IEnumerable<int> KNDAMKMOEDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct COMCIJMOAFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly bool MGNAMNDEFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool HNCIKIAOKDD;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4575180", Offset = "0x4573F80", VA = "0x184575180")]
	public COMCIJMOAFA(bool NBJCANBJABG, bool FEICDFDKCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x83B9220", Offset = "0x83B8020", VA = "0x1883B9220")]
	public string FIJDHCIEGJF(string PBHOCHKFEPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface GBHOBCGGGDM
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	float GEOIJKFGJFP(ReadOnlySpan<char> EMKHPHOFHMN, ReadOnlySpan<char> HIOHILJMNDF, [Optional] List<int>? LAKMDGNMOLL);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class ODKEBGFMBLD : GBHOBCGGGDM
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct ILJNDABGLKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly float IFKOLPIBHBD;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2D58AE0", Offset = "0x2D578E0", VA = "0x182D58AE0")]
		public ILJNDABGLKK(float JBEALKLNELP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int[] CDBKPGMOKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int[] HNPCHEEMGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private BitArray PDAGPGLLPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly ILJNDABGLKK KOEIEIJLGHF;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x83BC790", Offset = "0x83BB590", VA = "0x1883BC790")]
	public ODKEBGFMBLD([In] ILJNDABGLKK KOEIEIJLGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x83BBEB0", Offset = "0x83BACB0", VA = "0x1883BBEB0", Slot = "4")]
	public float GEOIJKFGJFP(ReadOnlySpan<char> EMKHPHOFHMN, ReadOnlySpan<char> HIOHILJMNDF, [Optional] List<int>? LAKMDGNMOLL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x83BC340", Offset = "0x83BB140", VA = "0x1883BC340")]
	private void OMBDBMEEOLM(int BCMFMCHGEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x83BC3D0", Offset = "0x83BB1D0", VA = "0x1883BC3D0")]
	private float PNIMONEHABK(ReadOnlySpan<char> EMKHPHOFHMN, ReadOnlySpan<char> HIOHILJMNDF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x83BC230", Offset = "0x83BB030", VA = "0x1883BC230")]
	private int JKBBOJPEOHF(ReadOnlySpan<char> NGBDOCEICHL, ReadOnlySpan<char> BNIHAACOHPG, int MJLFFIJGIKP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class OGKAABEOIOA : GBHOBCGGGDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int CCHPMNFMGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private BitArray? OHEMMBGIGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private (int SearchStringIndex, int ConsecutiveCount, int Value)[] ODFGPGMCIJJ;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x83BCF20", Offset = "0x83BBD20", VA = "0x1883BCF20")]
	public OGKAABEOIOA(int CCHPMNFMGMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x83BC870", Offset = "0x83BB670", VA = "0x1883BC870", Slot = "4")]
	public float GEOIJKFGJFP(ReadOnlySpan<char> EMKHPHOFHMN, ReadOnlySpan<char> HIOHILJMNDF, [Optional] List<int>? LAKMDGNMOLL)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface BEJFNDMKLIP
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IEnumerable<ReadOnlyMemory<char>> CDHKJFKOIDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class AAFJGGIDADK : BEJFNDMKLIP
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class EPKPPBPAKCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public COMCIJMOAFA settings;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public EPKPPBPAKCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x83BA4B0", Offset = "0x83B92B0", VA = "0x1883BA4B0")]
		internal string LHBPIFBKPOF(string t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class HFOCLHBJHJN : IEnumerable<ReadOnlyMemory<char>>, IEnumerable, IEnumerator<ReadOnlyMemory<char>>, IEnumerator, IDisposable
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
		public AAFJGGIDADK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private ReadOnlyMemory<char> <targetsMemory>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private IEnumerator<EHKDCEDMABE<char>> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		ReadOnlyMemory<char> IEnumerator<ReadOnlyMemory<char>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xD81A70", Offset = "0xD80870", VA = "0x180D81A70", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(ReadOnlyMemory<char>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x83BABA0", Offset = "0x83B99A0", VA = "0x1883BABA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x293FA40", Offset = "0x293E840", VA = "0x18293FA40")]
		[DebuggerHidden]
		public HFOCLHBJHJN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x83BABF0", Offset = "0x83B99F0", VA = "0x1883BABF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x83BA680", Offset = "0x83B9480", VA = "0x1883BA680", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x83BAA50", Offset = "0x83B9850", VA = "0x1883BAA50")]
		private void POCLDLCLENG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x83BAB50", Offset = "0x83B9950", VA = "0x1883BAB50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x83BAAA0", Offset = "0x83B98A0", VA = "0x1883BAAA0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<ReadOnlyMemory<char>> IEnumerable<ReadOnlyMemory<char>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x83BAAA0", Offset = "0x83B98A0", VA = "0x1883BAAA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly char[] OKDLPIAHOBP;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IEnumerable<ReadOnlyMemory<char>> CDHKJFKOIDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x83B70C0", Offset = "0x83B5EC0", VA = "0x1883B70C0", Slot = "4")]
		[IteratorStateMachine(typeof(HFOCLHBJHJN))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x83B7140", Offset = "0x83B5F40", VA = "0x1883B7140")]
	public AAFJGGIDADK(IEnumerable<string> CPPEAAHODOM, COMCIJMOAFA KOEIEIJLGHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class EACHNNFHLJD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void CKIMKNAHBLE(IReadOnlyList<HCCLCHFHGOJ> LFLGOCOHDIN, IReadOnlyList<bool> AOIKGJNIADK);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly IPOJLCCPBHB? FAJIBAIPGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly JOEGKEFNKCF NGBDOCEICHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly COMCIJMOAFA BEHLIBNNCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly NALFKNIINOF KOEIEIJLGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly CKIMKNAHBLE DONIDABECCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly EAFNKBIMELC.JBJMCILPBME? CDBLPMNEMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private IReadOnlyList<HCCLCHFHGOJ> HNOGEJODPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private IReadOnlyList<bool> MNGAIONGOBD;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<HCCLCHFHGOJ> OBEOFDHLPHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyList<bool> BIMGGKFJIMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool PKJHPKDONAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x83B9FC0", Offset = "0x83B8DC0", VA = "0x1883B9FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x83B9FE0", Offset = "0x83B8DE0", VA = "0x1883B9FE0")]
	public EACHNNFHLJD(IReadOnlyList<string> IKGIJKKMJJP, [In] NALFKNIINOF KOEIEIJLGHF, CKIMKNAHBLE AHFOFNGHMCA, [Optional] EAFNKBIMELC.JBJMCILPBME? CDBLPMNEMIC, [Optional] GBHOBCGGGDM? ODHBMLIMIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x83B9710", Offset = "0x83B8510", VA = "0x1883B9710")]
	public void GHLJCAEGPOD(string EMKHPHOFHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x83B96D0", Offset = "0x83B84D0", VA = "0x1883B96D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x83B9AB0", Offset = "0x83B88B0", VA = "0x1883B9AB0")]
	private void HFAPKNEDEHK(IReadOnlyList<BEPKINPMOOB> LFLGOCOHDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x83B94D0", Offset = "0x83B82D0", VA = "0x1883B94D0")]
	private int AKEMOPGLPJF(ReadOnlySpan<char> MKPEOGPFEFH, ReadOnlySpan<char> BNIHAACOHPG, int JHCMMKABBOE)
	{
		return default(int);
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
