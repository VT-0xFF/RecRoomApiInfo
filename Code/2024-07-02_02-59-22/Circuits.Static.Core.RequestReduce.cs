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
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1FE0EC0", Offset = "0x1FDFEC0", VA = "0x181FE0EC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x890740", Offset = "0x88F740", VA = "0x180890740")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x890780", Offset = "0x88F780", VA = "0x180890780")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate DGAGACGIHNN<TActionKind, TPayload> KPHMJPPHFMM<TActionKind, TSerializedAction, TPayload>(TSerializedAction FBBJCBJMJMM);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface MGAHMLHHLMO<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PIJKHLBEMKP<object, NJADGKCOIIE>> MPNMBGCPMBC(TDeps OJGLDAGFLKC, TRoot FMGEJNFFGHE, TSerializedAction FBBJCBJMJMM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class OCONACGNNLN<TActionKind, TSerializedAction, TRoot, TDeps> : JPAMHBNAPMB where TDeps : KNLGFLCJIEP.FCHBIPBEJEA<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps GNFPFODOMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction HNLDAEBEJAP;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4682C40", Offset = "0x4681C40", VA = "0x184682C40")]
	public OCONACGNNLN([In] TDeps OJGLDAGFLKC, [In] TSerializedAction FBBJCBJMJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4682A10", Offset = "0x4681A10", VA = "0x184682A10", Slot = "7")]
	public override string MKLJNMAODHM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct DGAGACGIHNN<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind EMCJHFMBHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload DDEPMJJIAPA;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x57F94A0", Offset = "0x57F84A0", VA = "0x1857F94A0")]
	internal DGAGACGIHNN(TActionKind LCEJNGBOIHI, [In] TPayload HJCJCIIFPJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class JDIIKJNMIAG
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2B858F0", Offset = "0x2B848F0", VA = "0x182B858F0")]
	public static DGAGACGIHNN<TActionKind, TPayload> HCLFOFEHDJP<TActionKind, TPayload>([In] TActionKind LCEJNGBOIHI, [In] TPayload HJCJCIIFPJE)
	{
		return default(DGAGACGIHNN<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<PIJKHLBEMKP<TOk, TErr>> BELEOFANPBB<TRoot, TPayload, TOk, TErr>(TRoot FMGEJNFFGHE, TPayload HJCJCIIFPJE);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate PIJKHLBEMKP<TOk, TErr> JPPNLMANOPC<TRoot, TPayload, TOk, TErr>(TRoot FMGEJNFFGHE, [In] TPayload HJCJCIIFPJE);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct MNOJACLHNCK<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : KNLGFLCJIEP.FCHBIPBEJEA<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LFNDKDAFGJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<object, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public MNOJACLHNCK<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<PIJKHLBEMKP<object, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x42CA070", Offset = "0x42C9070", VA = "0x1842CA070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x42CA950", Offset = "0x42C9950", VA = "0x1842CA950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, MGAHMLHHLMO<TSerializedAction, TRoot, TDeps>> LLFALFNDICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps GNFPFODOMGM;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xAB8760", Offset = "0xAB7760", VA = "0x180AB8760")]
	internal MNOJACLHNCK(Dictionary<TActionKind, MGAHMLHHLMO<TSerializedAction, TRoot, TDeps>> CHDDHEKCLMF, TDeps OJGLDAGFLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4505F40", Offset = "0x4504F40", VA = "0x184505F40")]
	[AsyncStateMachine(typeof(MNOJACLHNCK<, , , >.LFNDKDAFGJH))]
	public Task<PIJKHLBEMKP<object, NJADGKCOIIE>> MPNMBGCPMBC(TRoot FMGEJNFFGHE, TSerializedAction FBBJCBJMJMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class KNLGFLCJIEP
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface FCHBIPBEJEA<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind IOJBBFGABCC(TSerializedAction OLDDCPCBGIL);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MCBEFAKCIDD(TRoot FMGEJNFFGHE, TSerializedAction OGLJLDNLGIJ);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LGNGGGEOHDH(TRoot FMGEJNFFGHE, TSerializedAction OGLJLDNLGIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2B4A220", Offset = "0x2B49220", VA = "0x182B4A220")]
	internal static MNOJACLHNCK<TActionKind, TSerializedAction, TRoot, TDeps> HCLFOFEHDJP<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, MGAHMLHHLMO<TSerializedAction, TRoot, TDeps>> CHDDHEKCLMF, TDeps OJGLDAGFLKC) where TDeps : FCHBIPBEJEA<TActionKind, TSerializedAction, TRoot>
	{
		return default(MNOJACLHNCK<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class IMJMDNBIGIB<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, MGAHMLHHLMO<TSerializedAction, TRoot, TDeps>> LNFEFKHNPAN;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x86CB90", Offset = "0x86BB90", VA = "0x18086CB90")]
	private IMJMDNBIGIB(Dictionary<TActionKind, MGAHMLHHLMO<TSerializedAction, TRoot, TDeps>> CHDDHEKCLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3EDF2B0", Offset = "0x3EDE2B0", VA = "0x183EDF2B0")]
	public static IMJMDNBIGIB<TActionKind, TSerializedAction, TRoot, TDeps> HCLFOFEHDJP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct NLMPMICJONI<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, KNLGFLCJIEP.FCHBIPBEJEA<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class DKFGOIBPDFD<TPayload, TOk, TErr> : MGAHMLHHLMO<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, NJADGKCOIIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly KPHMJPPHFMM<TActionKind, TSerializedAction, TPayload> IDCKCBEMOGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly JPPNLMANOPC<TRoot, TPayload, TOk, TErr> MOMHMBHIPHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool KLEJOCCEKHA;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3CE2960", Offset = "0x3CE1960", VA = "0x183CE2960")]
		public DKFGOIBPDFD(KPHMJPPHFMM<TActionKind, TSerializedAction, TPayload> LBKCEAPAKHP, JPPNLMANOPC<TRoot, TPayload, TOk, TErr> PINNGLAIKDO, bool LFMBADLPAMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5845AA0", Offset = "0x5844AA0", VA = "0x185845AA0", Slot = "4")]
		public Task<PIJKHLBEMKP<object, NJADGKCOIIE>> MPNMBGCPMBC(TDeps OJGLDAGFLKC, TRoot FMGEJNFFGHE, TSerializedAction FBBJCBJMJMM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class ACGOMPKDMCJ<TPayload, TOk, TErr> : MGAHMLHHLMO<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, NJADGKCOIIE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct JFMCMJCODAA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<PIJKHLBEMKP<object?, NJADGKCOIIE>> <>t__builder;

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
			public ACGOMPKDMCJ<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private PIJKHLBEMKP<object?, NJADGKCOIIE> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<PIJKHLBEMKP<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x409F910", Offset = "0x409E910", VA = "0x18409F910", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x40A0940", Offset = "0x409F940", VA = "0x1840A0940", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly KPHMJPPHFMM<TActionKind, TSerializedAction, TPayload> IDCKCBEMOGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly BELEOFANPBB<TRoot, TPayload, TOk, TErr> MOMHMBHIPHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool KLEJOCCEKHA;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3CE2960", Offset = "0x3CE1960", VA = "0x183CE2960")]
		public ACGOMPKDMCJ(KPHMJPPHFMM<TActionKind, TSerializedAction, TPayload> LBKCEAPAKHP, BELEOFANPBB<TRoot, TPayload, TOk, TErr> PINNGLAIKDO, bool LFMBADLPAMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3CE2280", Offset = "0x3CE1280", VA = "0x183CE2280", Slot = "4")]
		[AsyncStateMachine(typeof(ACGOMPKDMCJ<, , >.JFMCMJCODAA))]
		public Task<PIJKHLBEMKP<object, NJADGKCOIIE>> MPNMBGCPMBC(TDeps OJGLDAGFLKC, TRoot FMGEJNFFGHE, TSerializedAction FBBJCBJMJMM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly IMJMDNBIGIB<TActionKind, TSerializedAction, TRoot, TDeps> CDDNPCEBPAP;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x93A5E0", Offset = "0x9395E0", VA = "0x18093A5E0")]
	private NLMPMICJONI(IMJMDNBIGIB<TActionKind, TSerializedAction, TRoot, TDeps> FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x45A8450", Offset = "0x45A7450", VA = "0x1845A8450")]
	public static NLMPMICJONI<TActionKind, TSerializedAction, TRoot, TDeps> HCLFOFEHDJP()
	{
		return default(NLMPMICJONI<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3830", Offset = "0x2AA2830", VA = "0x182AA3830")]
	public NLMPMICJONI<TActionKind, TSerializedAction, TRoot, TDeps> BEFMBDAJFNI<TPayload, TOk, TErr>(TActionKind LCEJNGBOIHI, KPHMJPPHFMM<TActionKind, TSerializedAction, TPayload> LBKCEAPAKHP, JPPNLMANOPC<TRoot, TPayload, TOk, TErr> PINNGLAIKDO, bool LFMBADLPAMJ = true) where TPayload : notnull where TOk : notnull where TErr : notnull, NJADGKCOIIE
	{
		return default(NLMPMICJONI<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3830", Offset = "0x2AA2830", VA = "0x182AA3830")]
	public NLMPMICJONI<TActionKind, TSerializedAction, TRoot, TDeps> ALKEEKCGEIB<TPayload, TOk, TErr>(TActionKind LCEJNGBOIHI, KPHMJPPHFMM<TActionKind, TSerializedAction, TPayload> LBKCEAPAKHP, BELEOFANPBB<TRoot, TPayload, TOk, TErr> PINNGLAIKDO, bool LFMBADLPAMJ = true) where TPayload : notnull where TOk : notnull where TErr : notnull, NJADGKCOIIE
	{
		return default(NLMPMICJONI<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x45A84F0", Offset = "0x45A74F0", VA = "0x1845A84F0")]
	public MNOJACLHNCK<TActionKind, TSerializedAction, TRoot, TDeps> LDKKJADJJFJ(TDeps OJGLDAGFLKC)
	{
		return default(MNOJACLHNCK<TActionKind, TSerializedAction, TRoot, TDeps>);
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
