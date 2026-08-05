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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FDC710", Offset = "0x7FDAD10", VA = "0x187FDC710")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA705D0", Offset = "0xA6EBD0", VA = "0x180A705D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA70610", Offset = "0xA6EC10", VA = "0x180A70610")]
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
	public class LogRegistrationIndex : CFJIINPOLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7FDBCC0", Offset = "0x7FDA2C0", VA = "0x187FDBCC0", Slot = "4")]
		public override void CCHHFLKMKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class EJFIBNMDKPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly AODIHCKPBBI ACKBIKMHOKC;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7FDA200", Offset = "0x7FD8800", VA = "0x187FDA200")]
	public EJFIBNMDKPI(IReadOnlyCollection<string> JAMEBDABGOA, [In] PEEKJJMBGOO IKFHIBIOKMD, [Optional] AODIHCKPBBI.OEBLMDGMKGK OALJKJIKIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9FC0", Offset = "0x7FD85C0", VA = "0x187FD9FC0")]
	public IReadOnlyList<BAOKLPAENKM> IBIJIIPOLOC(string LNFGPPIGAFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9E20", Offset = "0x7FD8420", VA = "0x187FD9E20")]
	public void AMPGDMAFAJC(string LNFGPPIGAFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class AODIHCKPBBI
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate int OEBLMDGMKGK(IReadOnlyList<char> HIBKCKCAJBK, int PJDMKAGIGDM, string MCDKNCDFMGG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly PEEKJJMBGOO HPFMLDCEFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly OEBLMDGMKGK KMFPIHPDEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly char[] KEINAIMNEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly BAOKLPAENKM[] ILBKEFOPONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly bool[] HFAMBIFBMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly (int SearchStringIndex, int ConsecutiveCount, int Value)[] BDHKJIJIBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly BAOKLPAENKM[] GBMLDHKLJFN;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00")]
	public static int LCBNCNBJEOG(IReadOnlyList<char> HIBKCKCAJBK, int PJDMKAGIGDM, string MCDKNCDFMGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7FD87D0", Offset = "0x7FD6DD0", VA = "0x187FD87D0")]
	public AODIHCKPBBI(IReadOnlyCollection<string> JAMEBDABGOA, [In] PEEKJJMBGOO IKFHIBIOKMD, [Optional] OEBLMDGMKGK OALJKJIKIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7FD8740", Offset = "0x7FD6D40", VA = "0x187FD8740")]
	public string JJPDANJOACL(string LNFGPPIGAFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7FD8730", Offset = "0x7FD6D30", VA = "0x187FD8730")]
	public int DMBKJBAPJHD(int EOEGIEAPNKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7FD8130", Offset = "0x7FD6730", VA = "0x187FD8130")]
	public int AMPGDMAFAJC(string LNFGPPIGAFI, int MIAOLBMBNAJ, int HMKFJFMEKGD, int PJDMKAGIGDM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct PEEKJJMBGOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly bool PCNKLBAADJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool NFDGOAOHNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly int LLKGKACIGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly int OOGCAKHIILE;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly PEEKJJMBGOO OLFNOGIALKE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static PEEKJJMBGOO JLODNOEBAIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7FDCF80", Offset = "0x7FDB580", VA = "0x187FDCF80")]
		get
		{
			return default(PEEKJJMBGOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD030", Offset = "0x7FDB630", VA = "0x187FDD030")]
	public PEEKJJMBGOO(bool IOLCKJKEELF, bool HPAFDPKHDMB, int HGKNNOHCABO, int MMKNJGIJJHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct BAOKLPAENKM : IEquatable<BAOKLPAENKM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly int BPENJJIEFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly int AMPGDMAFAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly int HOMGELIPIEI;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xDF0150", Offset = "0xDEE750", VA = "0x180DF0150")]
	public BAOKLPAENKM(int KHMHPNKMLMD, int NBGOFDINNHI, int IHFBMBPCMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7FD93E0", Offset = "0x7FD79E0", VA = "0x187FD93E0")]
	public static int MLPBFPHNABL([In] BAOKLPAENKM IAPIHBICBOE, [In] BAOKLPAENKM FJDIHEBKFED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x283C200", Offset = "0x283A800", VA = "0x18283C200", Slot = "4")]
	public bool Equals(BAOKLPAENKM HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7FD92C0", Offset = "0x7FD78C0", VA = "0x187FD92C0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9370", Offset = "0x7FD7970", VA = "0x187FD9370", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GOAGDHKDKHM
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BIAIKADCIEC(string LNFGPPIGAFI, [Out][NotNullWhen(true)] IReadOnlyList<CKEPINONLCM>? JMMJIFKPGAE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class FHHNPKNDGDG : GOAGDHKDKHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly int KCKNICLCAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly List<(string searchString, IReadOnlyList<CKEPINONLCM> results)> BBCMOCJMBOF;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7FDAC60", Offset = "0x7FD9260", VA = "0x187FDAC60")]
	public FHHNPKNDGDG(int KCKNICLCAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7FDAAE0", Offset = "0x7FD90E0", VA = "0x187FDAAE0", Slot = "4")]
	public bool BIAIKADCIEC(string LNFGPPIGAFI, [Out][NotNullWhen(true)] IReadOnlyList<CKEPINONLCM>? JMMJIFKPGAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class IKGIAEPLKID
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate void HACCKFDCKNF(IReadOnlyList<CKEPINONLCM> JMMJIFKPGAE);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class CAGPEAJBJLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public IKGIAEPLKID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CancellationTokenSource localCts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string searchString;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public CAGPEAJBJLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9400", Offset = "0x7FD7A00", VA = "0x187FD9400")]
		internal CKEPINONLCM[] FMOKNMHHPNP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct LLICOKNIKFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public IKGIAEPLKID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public string searchString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private CAGPEAJBJLD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HACCKFDCKNF onSearchComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<CKEPINONLCM[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7FDB8A0", Offset = "0x7FD9EA0", VA = "0x187FDB8A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xAA6DB0", Offset = "0xAA53B0", VA = "0x180AA6DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly COLOMBGGJLB CIEPDNPGAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IPDGMNAHDLP BOMCKOICKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly CPOEMMKCGLB.KPMEKAFLFGC? KFGOFAOMBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private CKEPINONLCM[] GGIDDFCHLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private CancellationTokenSource? OLINDFJIJKJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool GGFFJMFFOHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x11732E0", Offset = "0x11718E0", VA = "0x1811732E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB4C0", Offset = "0x7FD9AC0", VA = "0x187FDB4C0")]
	public IKGIAEPLKID(COLOMBGGJLB CIEPDNPGAMI, IPDGMNAHDLP BOMCKOICKAF, [Optional] CPOEMMKCGLB.KPMEKAFLFGC? KFGOFAOMBIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB340", Offset = "0x7FD9940", VA = "0x187FDB340")]
	[AsyncStateMachine(typeof(LLICOKNIKFN))]
	public void IBIJIIPOLOC(string LNFGPPIGAFI, HACCKFDCKNF MFJJKNGGDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7FDB300", Offset = "0x7FD9900", VA = "0x187FDB300")]
	public void FJGIFBPLLNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CPOEMMKCGLB
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate int KPMEKAFLFGC(ReadOnlySpan<char> LNFGPPIGAFI, ReadOnlySpan<char> KEEKAHFNPAK, int NFMCMIPPPJB);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9D90", Offset = "0x7FD8390", VA = "0x187FD9D90")]
	public static int DJHEBAODNII([In] CKEPINONLCM IAPIHBICBOE, [In] CKEPINONLCM FJDIHEBKFED)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct CKEPINONLCM
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class LBGHACHBBHP : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
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
		public CKEPINONLCM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public CKEPINONLCM <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool IEnumerator<bool>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x12003E0", Offset = "0x11FE9E0", VA = "0x1812003E0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FDB850", Offset = "0x7FD9E50", VA = "0x187FDB850", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x142AB90", Offset = "0x1429190", VA = "0x18142AB90")]
		[DebuggerHidden]
		public LBGHACHBBHP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7FDB6A0", Offset = "0x7FD9CA0", VA = "0x187FDB6A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7FDB800", Offset = "0x7FD9E00", VA = "0x187FDB800", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7FDB740", Offset = "0x7FD9D40", VA = "0x187FDB740", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7FDB740", Offset = "0x7FD9D40", VA = "0x187FDB740", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly float AMPGDMAFAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly int BPENJJIEFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly ReadOnlyMemory<char> EHKNIPKFOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly BitArray LMNOMNAFJLA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public readonly IEnumerable<bool> BJCPPFHCNIB
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9AA0", Offset = "0x7FD80A0", VA = "0x187FD9AA0")]
		[IteratorStateMachine(typeof(LBGHACHBBHP))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9B30", Offset = "0x7FD8130", VA = "0x187FD9B30")]
	public CKEPINONLCM(float NBGOFDINNHI, int KHMHPNKMLMD, ReadOnlyMemory<char> OKOGHNMMGGB, IEnumerable<int> LMNOMNAFJLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct ONDLIANJKPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly bool PCNKLBAADJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool NFDGOAOHNKM;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4C5A5E0", Offset = "0x4C58BE0", VA = "0x184C5A5E0")]
	public ONDLIANJKPI(bool MEFPMKCDAHK, bool IDFBJGKAMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7FDCEF0", Offset = "0x7FDB4F0", VA = "0x187FDCEF0")]
	public string EPIKLCKNAIK(string IKLHNGEBLBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface IPDGMNAHDLP
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	float AMPGDMAFAJC(ReadOnlySpan<char> LNFGPPIGAFI, ReadOnlySpan<char> KEEKAHFNPAK, [Optional] List<int>? DIHNOLJOFNK);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NGNPGEIDMMP : IPDGMNAHDLP
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct BIOKLLKBALJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly float CMKBAKLHNLM;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2BCDDD0", Offset = "0x2BCC3D0", VA = "0x182BCDDD0")]
		public BIOKLLKBALJ(float JENKOKEAENJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int[] JGAMELEOCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int[] PGCBBAAANOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private BitArray JLJHDHIHIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly BIOKLLKBALJ IKFHIBIOKMD;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC630", Offset = "0x7FDAC30", VA = "0x187FDC630")]
	public NGNPGEIDMMP([In] BIOKLLKBALJ IKFHIBIOKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7FDBD50", Offset = "0x7FDA350", VA = "0x187FDBD50", Slot = "4")]
	public float AMPGDMAFAJC(ReadOnlySpan<char> LNFGPPIGAFI, ReadOnlySpan<char> KEEKAHFNPAK, [Optional] List<int>? DIHNOLJOFNK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC5A0", Offset = "0x7FDABA0", VA = "0x187FDC5A0")]
	private void PPGKKGCKKEF(int GPNBMIDFKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC0D0", Offset = "0x7FDA6D0", VA = "0x187FDC0D0")]
	private float DHDOABFNAEN(ReadOnlySpan<char> LNFGPPIGAFI, ReadOnlySpan<char> KEEKAHFNPAK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC490", Offset = "0x7FDAA90", VA = "0x187FDC490")]
	private int NBCPIDLHDHF(ReadOnlySpan<char> KGIFCCLIIMJ, ReadOnlySpan<char> OKOGHNMMGGB, int PBDALKDDLFE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class OKGMDKHMONG : IPDGMNAHDLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int HGKNNOHCABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private BitArray? LNBDLPPGCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private (int SearchStringIndex, int ConsecutiveCount, int Value)[] KHPJJFPCKBP;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7FDCE40", Offset = "0x7FDB440", VA = "0x187FDCE40")]
	public OKGMDKHMONG(int HGKNNOHCABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7FDC790", Offset = "0x7FDAD90", VA = "0x187FDC790", Slot = "4")]
	public float AMPGDMAFAJC(ReadOnlySpan<char> LNFGPPIGAFI, ReadOnlySpan<char> KEEKAHFNPAK, [Optional] List<int>? DIHNOLJOFNK)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface COLOMBGGJLB
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IEnumerable<ReadOnlyMemory<char>> GJOHFMBJIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FGBHGGHKGOE : COLOMBGGJLB
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class ACEENMOHGIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public ONDLIANJKPI settings;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public ACEENMOHGIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7FD80A0", Offset = "0x7FD66A0", VA = "0x187FD80A0")]
		internal string NFGNFMIJEJA(string t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class HIIIHCKACML : IEnumerable<ReadOnlyMemory<char>>, IEnumerable, IEnumerator<ReadOnlyMemory<char>>, IEnumerator, IDisposable
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
		public FGBHGGHKGOE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private ReadOnlyMemory<char> <targetsMemory>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private IEnumerator<HIFKEOIAIOH<char>> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		ReadOnlyMemory<char> IEnumerator<ReadOnlyMemory<char>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xCBDE70", Offset = "0xCBC470", VA = "0x180CBDE70", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FDB220", Offset = "0x7FD9820", VA = "0x187FDB220", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x282B800", Offset = "0x2829E00", VA = "0x18282B800")]
		[DebuggerHidden]
		public HIIIHCKACML(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7FDB270", Offset = "0x7FD9870", VA = "0x187FDB270", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7FDAD50", Offset = "0x7FD9350", VA = "0x187FDAD50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7FDAD00", Offset = "0x7FD9300", VA = "0x187FDAD00")]
		private void APENNGMAANK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7FDB1D0", Offset = "0x7FD97D0", VA = "0x187FDB1D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7FDB120", Offset = "0x7FD9720", VA = "0x187FDB120", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<ReadOnlyMemory<char>> IEnumerable<ReadOnlyMemory<char>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7FDB120", Offset = "0x7FD9720", VA = "0x187FDB120", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly char[] MOLFDOELOJJ;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IEnumerable<ReadOnlyMemory<char>> GJOHFMBJIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7FDA2B0", Offset = "0x7FD88B0", VA = "0x187FDA2B0", Slot = "4")]
		[IteratorStateMachine(typeof(HIIIHCKACML))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7FDA330", Offset = "0x7FD8930", VA = "0x187FDA330")]
	public FGBHGGHKGOE(IEnumerable<string> CIEPDNPGAMI, ONDLIANJKPI IKFHIBIOKMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class PEGJGPDDPHI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void NIDEFFBNEHD(IReadOnlyList<BAOKLPAENKM> JMMJIFKPGAE, IReadOnlyList<bool> FFNILILDFCG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly GOAGDHKDKHM? BBCMOCJMBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly IKGIAEPLKID KGIFCCLIIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly ONDLIANJKPI ANIHENEJFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly PEEKJJMBGOO IKFHIBIOKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly NIDEFFBNEHD OEFEBECDEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly CPOEMMKCGLB.KPMEKAFLFGC? KFGOFAOMBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private IReadOnlyList<BAOKLPAENKM> CDJMFODGHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private IReadOnlyList<bool> CDMLGDMGABB;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<BAOKLPAENKM> MDKFJKILDPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA47BC0", Offset = "0xA461C0", VA = "0x180A47BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyList<bool> ODFEOOJJMIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4D0", Offset = "0xA4AAD0", VA = "0x180A4C4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool GGFFJMFFOHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7FDD770", Offset = "0x7FDBD70", VA = "0x187FDD770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7FDDB30", Offset = "0x7FDC130", VA = "0x187FDDB30")]
	public PEGJGPDDPHI(IReadOnlyList<string> JAMEBDABGOA, [In] PEEKJJMBGOO IKFHIBIOKMD, NIDEFFBNEHD MFJJKNGGDNE, [Optional] CPOEMMKCGLB.KPMEKAFLFGC? KFGOFAOMBIG, [Optional] IPDGMNAHDLP? KIANLGMHEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD790", Offset = "0x7FDBD90", VA = "0x187FDD790")]
	public void OJLEGICKLMC(string LNFGPPIGAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD250", Offset = "0x7FDB850", VA = "0x187FDD250")]
	private void EFEKMMJIODM(IReadOnlyList<CKEPINONLCM> JMMJIFKPGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7FDD050", Offset = "0x7FDB650", VA = "0x187FDD050")]
	private int DKDNBIDEOFN(ReadOnlySpan<char> INCFEGIJJJL, ReadOnlySpan<char> OKOGHNMMGGB, int AKNPGOPEDCE)
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
