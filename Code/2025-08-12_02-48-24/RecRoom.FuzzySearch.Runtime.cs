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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8495950", Offset = "0x8493F50", VA = "0x188495950")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC0AA0", Offset = "0xABF0A0", VA = "0x180AC0AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC0AE0", Offset = "0xABF0E0", VA = "0x180AC0AE0")]
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
	public class LogRegistrationIndex : EJFLMJDOOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8495090", Offset = "0x8493690", VA = "0x188495090", Slot = "4")]
		public override void CBPAAEAGBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class IEPICHKIFJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HLFIOEJGKOA NGCMHHMAMMK;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x84929F0", Offset = "0x8490FF0", VA = "0x1884929F0")]
	public IEPICHKIFJA(IReadOnlyCollection<string> DOMIFEGMNEB, [In] MJBOBPKMFNG FCMBNELMFMA, [Optional] HLFIOEJGKOA.LCKCIPCBPEI GLKEGBLIDKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8492610", Offset = "0x8490C10", VA = "0x188492610")]
	public IReadOnlyList<INAPMACDOLI> JAKGDJOAMBI(string MBGEGOMDOLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8492850", Offset = "0x8490E50", VA = "0x188492850")]
	public void OKKMJFDCDAD(string MBGEGOMDOLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class HLFIOEJGKOA
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate int LCKCIPCBPEI(IReadOnlyList<char> NGJANANKJNB, int PKCKNCEHFEI, string KHJMOJKNHIB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly MJBOBPKMFNG HBFPIDAINAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly LCKCIPCBPEI CJDHMHCDCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly char[] LBEKBNEJGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly INAPMACDOLI[] AJMNBCHCLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly bool[] OBMDNCAMDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly (int SearchStringIndex, int ConsecutiveCount, int Value)[] GKEKBBGBOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly INAPMACDOLI[] DGNADJHAKKA;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0")]
	public static int JLAMDLOPIID(IReadOnlyList<char> NGJANANKJNB, int PKCKNCEHFEI, string KHJMOJKNHIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8491B20", Offset = "0x8490120", VA = "0x188491B20")]
	public HLFIOEJGKOA(IReadOnlyCollection<string> DOMIFEGMNEB, [In] MJBOBPKMFNG FCMBNELMFMA, [Optional] LCKCIPCBPEI GLKEGBLIDKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8491480", Offset = "0x848FA80", VA = "0x188491480")]
	public string IBIHDLCIHKM(string MBGEGOMDOLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8491510", Offset = "0x848FB10", VA = "0x188491510")]
	public int NJPPGJCDFDP(int KFIEGNJAFOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8491520", Offset = "0x848FB20", VA = "0x188491520")]
	public int OKKMJFDCDAD(string MBGEGOMDOLF, int BPDNDMKADOM, int KNDMIKGPAMH, int PKCKNCEHFEI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct MJBOBPKMFNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly bool EJEKJFIHKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool MMLILOGMHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly int KKFAFLNODOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly int JCDJFAKCAPP;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly MJBOBPKMFNG ICEGPJKDBNL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static MJBOBPKMFNG COLNIIHALMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8495880", Offset = "0x8493E80", VA = "0x188495880")]
		get
		{
			return default(MJBOBPKMFNG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8495930", Offset = "0x8493F30", VA = "0x188495930")]
	public MJBOBPKMFNG(bool IGBPDIJLFNB, bool MEMCKHONGPC, int CIODMEIPNLP, int EBOKKJFBKBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct INAPMACDOLI : IEquatable<INAPMACDOLI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly int LBGMECNKHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly int OKKMJFDCDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly int HNDOHDIGLOF;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xEA5F00", Offset = "0xEA4500", VA = "0x180EA5F00")]
	public INAPMACDOLI(int LEPAEEGOBDO, int NJIHJCBIPID, int LIGDLFLLDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8492BC0", Offset = "0x84911C0", VA = "0x188492BC0")]
	public static int OMPGOIOJGIK([In] INAPMACDOLI KNPHEACNGDK, [In] INAPMACDOLI IMDBLBCMEAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x296F370", Offset = "0x296D970", VA = "0x18296F370", Slot = "4")]
	public bool Equals(INAPMACDOLI IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8492AA0", Offset = "0x84910A0", VA = "0x188492AA0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8492B50", Offset = "0x8491150", VA = "0x188492B50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NIICOECHFGO
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PFLLAALBAMH(string MBGEGOMDOLF, [Out][NotNullWhen(true)] IReadOnlyList<KEPKKOOOEEH>? CJDAJOJGDLD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class CDHOGFNLMIJ : NIICOECHFGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly int JMPMJLNMAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly List<(string searchString, IReadOnlyList<KEPKKOOOEEH> results)> GMBMBGKOJIH;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x84903F0", Offset = "0x848E9F0", VA = "0x1884903F0")]
	public CDHOGFNLMIJ(int JMPMJLNMAAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8490270", Offset = "0x848E870", VA = "0x188490270", Slot = "4")]
	public bool PFLLAALBAMH(string MBGEGOMDOLF, [Out][NotNullWhen(true)] IReadOnlyList<KEPKKOOOEEH>? CJDAJOJGDLD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class OKCBIFBMAKO
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate void OLLKDBDLACG(IReadOnlyList<KEPKKOOOEEH> CJDAJOJGDLD);

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class GOKOHEANKDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public OKCBIFBMAKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CancellationTokenSource localCts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string searchString;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public GOKOHEANKDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x84905B0", Offset = "0x848EBB0", VA = "0x1884905B0")]
		internal KEPKKOOOEEH[] BJCIEPKDJHD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct CDFNMPDELAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public OKCBIFBMAKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public string searchString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private GOKOHEANKDK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public OLLKDBDLACG onSearchComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<KEPKKOOOEEH[]> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x848FE50", Offset = "0x848E450", VA = "0x18848FE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xAE2D00", Offset = "0xAE1300", VA = "0x180AE2D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly JCNBMCECGGN FIEOCAHNJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly NLDANNEDBOL FDLCEEONEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly JFDEHCMMPBJ.OJEHKCNNBJB? JDAFBAMNPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private KEPKKOOOEEH[] MGMBOFHHBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private CancellationTokenSource? PHIDKGOIJJO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool AAJCEAMCABK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x127C830", Offset = "0x127AE30", VA = "0x18127C830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8495CC0", Offset = "0x84942C0", VA = "0x188495CC0")]
	public OKCBIFBMAKO(JCNBMCECGGN FIEOCAHNJDC, NLDANNEDBOL FDLCEEONEBP, [Optional] JFDEHCMMPBJ.OJEHKCNNBJB? JDAFBAMNPAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8495B00", Offset = "0x8494100", VA = "0x188495B00")]
	[AsyncStateMachine(typeof(CDFNMPDELAM))]
	public void JAKGDJOAMBI(string MBGEGOMDOLF, OLLKDBDLACG DGBHDAADIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8495BF0", Offset = "0x84941F0", VA = "0x188495BF0")]
	public void NEPOCHBBDNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JFDEHCMMPBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate int OJEHKCNNBJB(ReadOnlySpan<char> MBGEGOMDOLF, ReadOnlySpan<char> LCPDMIDCGKB, int NFEBIFAADKN);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8492BE0", Offset = "0x84911E0", VA = "0x188492BE0")]
	public static int DCOEABCGFAC([In] KEPKKOOOEEH KNPHEACNGDK, [In] KEPKKOOOEEH IMDBLBCMEAE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct KEPKKOOOEEH
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class JKMPJKGOADG : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
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
		public KEPKKOOOEEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public KEPKKOOOEEH <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool IEnumerator<bool>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x130DD00", Offset = "0x130C300", VA = "0x18130DD00", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8492E20", Offset = "0x8491420", VA = "0x188492E20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x154FAF0", Offset = "0x154E0F0", VA = "0x18154FAF0")]
		[DebuggerHidden]
		public JKMPJKGOADG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8492C70", Offset = "0x8491270", VA = "0x188492C70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8492DD0", Offset = "0x84913D0", VA = "0x188492DD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8492D10", Offset = "0x8491310", VA = "0x188492D10", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8492D10", Offset = "0x8491310", VA = "0x188492D10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly float OKKMJFDCDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly int LBGMECNKHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly ReadOnlyMemory<char> ANPDICCKLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly BitArray DEGJJMEKOCI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public readonly IEnumerable<bool> ENPGJNGBCLB
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8493470", Offset = "0x8491A70", VA = "0x188493470")]
		[IteratorStateMachine(typeof(JKMPJKGOADG))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8493500", Offset = "0x8491B00", VA = "0x188493500")]
	public KEPKKOOOEEH(float NJIHJCBIPID, int LEPAEEGOBDO, ReadOnlyMemory<char> LKEAKCADNOO, IEnumerable<int> DEGJJMEKOCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public readonly struct GAFIBKKOOGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly bool EJEKJFIHKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly bool MMLILOGMHFJ;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4A79560", Offset = "0x4A77B60", VA = "0x184A79560")]
	public GAFIBKKOOGB(bool JOEHACDHDGP, bool CEKEBIICNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8490520", Offset = "0x848EB20", VA = "0x188490520")]
	public string AIJCJONLLDB(string IAKFGDELOKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NLDANNEDBOL
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	float OKKMJFDCDAD(ReadOnlySpan<char> MBGEGOMDOLF, ReadOnlySpan<char> LCPDMIDCGKB, [Optional] List<int>? FKHENHMELBI);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class LECEAJDHJII : NLDANNEDBOL
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct HNDCOIFNLBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly float JDBBJPDEMMG;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2D7E5A0", Offset = "0x2D7CBA0", VA = "0x182D7E5A0")]
		public HNDCOIFNLBO(float IPEENAIIOGO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int[] OJHAGNBDLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int[] AEGKEFALGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private BitArray PIBJIBCMELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HNDCOIFNLBO FCMBNELMFMA;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8494FB0", Offset = "0x84935B0", VA = "0x188494FB0")]
	public LECEAJDHJII([In] HNDCOIFNLBO FCMBNELMFMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8494C30", Offset = "0x8493230", VA = "0x188494C30", Slot = "4")]
	public float OKKMJFDCDAD(ReadOnlySpan<char> MBGEGOMDOLF, ReadOnlySpan<char> LCPDMIDCGKB, [Optional] List<int>? FKHENHMELBI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8494BA0", Offset = "0x84931A0", VA = "0x188494BA0")]
	private void NAOHEJJNOLG(int MLMBLBFOLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x84946D0", Offset = "0x8492CD0", VA = "0x1884946D0")]
	private float EKBMBCEKLIJ(ReadOnlySpan<char> MBGEGOMDOLF, ReadOnlySpan<char> LCPDMIDCGKB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8494A90", Offset = "0x8493090", VA = "0x188494A90")]
	private int MKGLAIOMAJK(ReadOnlySpan<char> CADOHIHGEEH, ReadOnlySpan<char> LKEAKCADNOO, int EBJFMAAEICD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MIGOKFCGPMA : NLDANNEDBOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly int CIODMEIPNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private BitArray? GEEODMIGIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private (int SearchStringIndex, int ConsecutiveCount, int Value)[] OLDFMEHMDEE;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x84957D0", Offset = "0x8493DD0", VA = "0x1884957D0")]
	public MIGOKFCGPMA(int CIODMEIPNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8495120", Offset = "0x8493720", VA = "0x188495120", Slot = "4")]
	public float OKKMJFDCDAD(ReadOnlySpan<char> MBGEGOMDOLF, ReadOnlySpan<char> LCPDMIDCGKB, [Optional] List<int>? FKHENHMELBI)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface JCNBMCECGGN
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IEnumerable<ReadOnlyMemory<char>> BBOIGGNABNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HCGKDECLIKI : JCNBMCECGGN
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class EBCJBCJLBCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public GAFIBKKOOGB settings;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public EBCJBCJLBCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8490490", Offset = "0x848EA90", VA = "0x188490490")]
		internal string KHGBLAEHIPK(string t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class KCAKHFAKNID : IEnumerable<ReadOnlyMemory<char>>, IEnumerable, IEnumerator<ReadOnlyMemory<char>>, IEnumerator, IDisposable
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
		public HCGKDECLIKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private ReadOnlyMemory<char> <targetsMemory>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private IEnumerator<ADPAFALDCBO<char>> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		ReadOnlyMemory<char> IEnumerator<ReadOnlyMemory<char>>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xD84C50", Offset = "0xD83250", VA = "0x180D84C50", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8493390", Offset = "0x8491990", VA = "0x188493390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x295E940", Offset = "0x295CF40", VA = "0x18295E940")]
		[DebuggerHidden]
		public KCAKHFAKNID(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x84933E0", Offset = "0x84919E0", VA = "0x1884933E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8492E70", Offset = "0x8491470", VA = "0x188492E70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8493240", Offset = "0x8491840", VA = "0x188493240")]
		private void OFOMAIJNFMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8493340", Offset = "0x8491940", VA = "0x188493340", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8493290", Offset = "0x8491890", VA = "0x188493290", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<ReadOnlyMemory<char>> IEnumerable<ReadOnlyMemory<char>>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8493290", Offset = "0x8491890", VA = "0x188493290", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly char[] GBPAKCKDAMA;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IEnumerable<ReadOnlyMemory<char>> BBOIGGNABNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8490C50", Offset = "0x848F250", VA = "0x188490C50", Slot = "4")]
		[IteratorStateMachine(typeof(KCAKHFAKNID))]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8490CD0", Offset = "0x848F2D0", VA = "0x188490CD0")]
	public HCGKDECLIKI(IEnumerable<string> FIEOCAHNJDC, GAFIBKKOOGB FCMBNELMFMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class KOEBHHIIKPF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void HGFDBFNMFGH(IReadOnlyList<INAPMACDOLI> CJDAJOJGDLD, IReadOnlyList<bool> PCMNEFKPCBD);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly NIICOECHFGO? GMBMBGKOJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly OKCBIFBMAKO CADOHIHGEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly GAFIBKKOOGB KNHBOFJGGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly MJBOBPKMFNG FCMBNELMFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly HGFDBFNMFGH GDACDODKHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly JFDEHCMMPBJ.OJEHKCNNBJB? JDAFBAMNPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private IReadOnlyList<INAPMACDOLI> ILHHIPJFCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private IReadOnlyList<bool> HHPPAFGAODG;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IReadOnlyList<INAPMACDOLI> FGGIJOIDHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA99310", Offset = "0xA97910", VA = "0x180A99310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IReadOnlyList<bool> HGIFDINIALL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool AAJCEAMCABK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8493EC0", Offset = "0x84924C0", VA = "0x188493EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x8494280", Offset = "0x8492880", VA = "0x188494280")]
	public KOEBHHIIKPF(IReadOnlyList<string> DOMIFEGMNEB, [In] MJBOBPKMFNG FCMBNELMFMA, HGFDBFNMFGH DGBHDAADIFO, [Optional] JFDEHCMMPBJ.OJEHKCNNBJB? JDAFBAMNPAJ, [Optional] NLDANNEDBOL? PKNKMOMACKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8493EE0", Offset = "0x84924E0", VA = "0x188493EE0")]
	public void OMIOAGLNDKM(string MBGEGOMDOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8493760", Offset = "0x8491D60", VA = "0x188493760", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x84939A0", Offset = "0x8491FA0", VA = "0x1884939A0")]
	private void IDJNBLFCEFD(IReadOnlyList<KEPKKOOOEEH> CJDAJOJGDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x84937A0", Offset = "0x8491DA0", VA = "0x1884937A0")]
	private int GMONPHNKKGO(ReadOnlySpan<char> LBHNPIBFMBH, ReadOnlySpan<char> LKEAKCADNOO, int NILLHAGMEPN)
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
