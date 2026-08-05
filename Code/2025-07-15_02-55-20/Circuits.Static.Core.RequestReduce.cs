using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A34F40", Offset = "0x2A33B40", VA = "0x182A34F40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA87960", Offset = "0xA86560", VA = "0x180A87960")]
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
		[Cpp2IlInjected.Address(RVA = "0xA879A0", Offset = "0xA865A0", VA = "0x180A879A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate GOLFFCNNNDP<TActionKind, TPayload> HFBPCFJMHFC<TActionKind, TSerializedAction, TPayload>(TSerializedAction PHDMDIFBLEK);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface OICAMCDKGFC<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IADHIMOENNN<object, KHGGKMBDLJL>> NOHMCCDBFPL(TDeps BNLBDNCLLFN, TRoot OLIIIAEGOLD, TSerializedAction PHDMDIFBLEK);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class DJJPOAHGKPO<TActionKind, TSerializedAction, TRoot, TDeps> : HIMPFMKCELK where TDeps : BGNBFGAMAPD.ADOEPCNAKOM<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps HIMLJAGALBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction NEPMNDHAGLN;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x446AC00", Offset = "0x4469800", VA = "0x18446AC00")]
	public DJJPOAHGKPO([In] TDeps BNLBDNCLLFN, [In] TSerializedAction PHDMDIFBLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x446A9F0", Offset = "0x44695F0", VA = "0x18446A9F0", Slot = "7")]
	public override string BAMDPIFKGNE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct GOLFFCNNNDP<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind CFKJBMNAHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload IHHPPJBGOCD;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4F27B00", Offset = "0x4F26700", VA = "0x184F27B00")]
	internal GOLFFCNNNDP(TActionKind HLOMFJPPHLH, [In] TPayload HGBKIACHBFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LLDPDDJLMBM
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3D2A910", Offset = "0x3D29510", VA = "0x183D2A910")]
	public static GOLFFCNNNDP<TActionKind, TPayload> MJMNOIPJNFN<TActionKind, TPayload>([In] TActionKind HLOMFJPPHLH, [In] TPayload HGBKIACHBFM)
	{
		return default(GOLFFCNNNDP<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<IADHIMOENNN<TOk, TErr>> LIMNIFHAPDF<TRoot, TPayload, TOk, TErr>(TRoot OLIIIAEGOLD, TPayload HGBKIACHBFM);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate IADHIMOENNN<TOk, TErr> CNLFBMHNGEH<TRoot, TPayload, TOk, TErr>(TRoot OLIIIAEGOLD, [In] TPayload HGBKIACHBFM);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct GEKBBFOBACE<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : BGNBFGAMAPD.ADOEPCNAKOM<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct OECBFJLPDBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IADHIMOENNN<object?, KHGGKMBDLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public GEKBBFOBACE<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<IADHIMOENNN<object, KHGGKMBDLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x58560C0", Offset = "0x5854CC0", VA = "0x1858560C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5856950", Offset = "0x5855550", VA = "0x185856950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, OICAMCDKGFC<TSerializedAction, TRoot, TDeps>> ALGEKPNLBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps HIMLJAGALBM;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xBCEBD0", Offset = "0xBCD7D0", VA = "0x180BCEBD0")]
	internal GEKBBFOBACE(Dictionary<TActionKind, OICAMCDKGFC<TSerializedAction, TRoot, TDeps>> FPNOAIJMJDL, TDeps BNLBDNCLLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4E8A040", Offset = "0x4E88C40", VA = "0x184E8A040")]
	[AsyncStateMachine(typeof(GEKBBFOBACE<, , , >.OECBFJLPDBJ))]
	public Task<IADHIMOENNN<object, KHGGKMBDLJL>> NOHMCCDBFPL(TRoot OLIIIAEGOLD, TSerializedAction PHDMDIFBLEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class BGNBFGAMAPD
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface ADOEPCNAKOM<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind KMFLPOMALKG(TSerializedAction JBDFDFABHKD);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JJHOAPPILKP(TRoot OLIIIAEGOLD, TSerializedAction KLIEOOEGDML);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void IMLIKJCBHHH(TRoot OLIIIAEGOLD, TSerializedAction KLIEOOEGDML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x39C3E30", Offset = "0x39C2A30", VA = "0x1839C3E30")]
	internal static GEKBBFOBACE<TActionKind, TSerializedAction, TRoot, TDeps> MJMNOIPJNFN<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, OICAMCDKGFC<TSerializedAction, TRoot, TDeps>> FPNOAIJMJDL, TDeps BNLBDNCLLFN) where TDeps : ADOEPCNAKOM<TActionKind, TSerializedAction, TRoot>
	{
		return default(GEKBBFOBACE<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class IHANNAAHKOC<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, OICAMCDKGFC<TSerializedAction, TRoot, TDeps>> HEDGPAIFKIH;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xA628A0", Offset = "0xA614A0", VA = "0x180A628A0")]
	private IHANNAAHKOC(Dictionary<TActionKind, OICAMCDKGFC<TSerializedAction, TRoot, TDeps>> FPNOAIJMJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5075310", Offset = "0x5073F10", VA = "0x185075310")]
	public static IHANNAAHKOC<TActionKind, TSerializedAction, TRoot, TDeps> MJMNOIPJNFN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct CCOJFJGDMPM<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, BGNBFGAMAPD.ADOEPCNAKOM<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class BIBLBLAAOEJ<TPayload, TOk, TErr> : OICAMCDKGFC<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, KHGGKMBDLJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly HFBPCFJMHFC<TActionKind, TSerializedAction, TPayload> NBCGDFMPEDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly CNLFBMHNGEH<TRoot, TPayload, TOk, TErr> NFGJJEJCCGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool HFDLLJMGEFN;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1BE86F0", Offset = "0x1BE72F0", VA = "0x181BE86F0")]
		public BIBLBLAAOEJ(HFBPCFJMHFC<TActionKind, TSerializedAction, TPayload> MPHKFMJLNBE, CNLFBMHNGEH<TRoot, TPayload, TOk, TErr> LOEHJGILKHB, bool FMIDNBLDNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x64394C0", Offset = "0x64380C0", VA = "0x1864394C0", Slot = "4")]
		public Task<IADHIMOENNN<object, KHGGKMBDLJL>> NOHMCCDBFPL(TDeps BNLBDNCLLFN, TRoot OLIIIAEGOLD, TSerializedAction PHDMDIFBLEK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class INAJKKHMBAG<TPayload, TOk, TErr> : OICAMCDKGFC<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, KHGGKMBDLJL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct KCNNDOEDBEG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<IADHIMOENNN<object?, KHGGKMBDLJL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public TDeps deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public TRoot root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public TSerializedAction serializedAction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public INAJKKHMBAG<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private IADHIMOENNN<object?, KHGGKMBDLJL> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<IADHIMOENNN<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x539BF20", Offset = "0x539AB20", VA = "0x18539BF20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x539CE40", Offset = "0x539BA40", VA = "0x18539CE40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly HFBPCFJMHFC<TActionKind, TSerializedAction, TPayload> NBCGDFMPEDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly LIMNIFHAPDF<TRoot, TPayload, TOk, TErr> NFGJJEJCCGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool HFDLLJMGEFN;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1BE86F0", Offset = "0x1BE72F0", VA = "0x181BE86F0")]
		public INAJKKHMBAG(HFBPCFJMHFC<TActionKind, TSerializedAction, TPayload> MPHKFMJLNBE, LIMNIFHAPDF<TRoot, TPayload, TOk, TErr> LOEHJGILKHB, bool FMIDNBLDNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x50B1780", Offset = "0x50B0380", VA = "0x1850B1780", Slot = "4")]
		[AsyncStateMachine(typeof(INAJKKHMBAG<, , >.KCNNDOEDBEG))]
		public Task<IADHIMOENNN<object, KHGGKMBDLJL>> NOHMCCDBFPL(TDeps BNLBDNCLLFN, TRoot OLIIIAEGOLD, TSerializedAction PHDMDIFBLEK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly IHANNAAHKOC<TActionKind, TSerializedAction, TRoot, TDeps> MJDJLDLPFCJ;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xE4EA80", Offset = "0xE4D680", VA = "0x180E4EA80")]
	private CCOJFJGDMPM(IHANNAAHKOC<TActionKind, TSerializedAction, TRoot, TDeps> CBCNBAPLLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B590", Offset = "0x6A6A190", VA = "0x186A6B590")]
	public static CCOJFJGDMPM<TActionKind, TSerializedAction, TRoot, TDeps> MJMNOIPJNFN()
	{
		return default(CCOJFJGDMPM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3EAA040", Offset = "0x3EA8C40", VA = "0x183EAA040")]
	public CCOJFJGDMPM<TActionKind, TSerializedAction, TRoot, TDeps> IIDFGIDCFJF<TPayload, TOk, TErr>(TActionKind HLOMFJPPHLH, HFBPCFJMHFC<TActionKind, TSerializedAction, TPayload> MPHKFMJLNBE, CNLFBMHNGEH<TRoot, TPayload, TOk, TErr> LOEHJGILKHB, bool FMIDNBLDNCI = true) where TPayload : notnull where TOk : notnull where TErr : notnull, KHGGKMBDLJL
	{
		return default(CCOJFJGDMPM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3EAA040", Offset = "0x3EA8C40", VA = "0x183EAA040")]
	public CCOJFJGDMPM<TActionKind, TSerializedAction, TRoot, TDeps> BKADHPAHFIA<TPayload, TOk, TErr>(TActionKind HLOMFJPPHLH, HFBPCFJMHFC<TActionKind, TSerializedAction, TPayload> MPHKFMJLNBE, LIMNIFHAPDF<TRoot, TPayload, TOk, TErr> LOEHJGILKHB, bool FMIDNBLDNCI = true) where TPayload : notnull where TOk : notnull where TErr : notnull, KHGGKMBDLJL
	{
		return default(CCOJFJGDMPM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6A6B4E0", Offset = "0x6A6A0E0", VA = "0x186A6B4E0")]
	public GEKBBFOBACE<TActionKind, TSerializedAction, TRoot, TDeps> ELIJGEBKLPM(TDeps BNLBDNCLLFN)
	{
		return default(GEKBBFOBACE<TActionKind, TSerializedAction, TRoot, TDeps>);
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
