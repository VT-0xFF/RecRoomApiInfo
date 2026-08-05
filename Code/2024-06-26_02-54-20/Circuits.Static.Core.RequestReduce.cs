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
		[Cpp2IlInjected.Address(RVA = "0x88C9F0", Offset = "0x88AFF0", VA = "0x18088C9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FD34E0", Offset = "0x1FD1AE0", VA = "0x181FD34E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x88D740", Offset = "0x88BD40", VA = "0x18088D740")]
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
		[Cpp2IlInjected.Address(RVA = "0x88D780", Offset = "0x88BD80", VA = "0x18088D780")]
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
	[Cpp2IlInjected.Address(RVA = "0x46615B0", Offset = "0x465FBB0", VA = "0x1846615B0")]
	public OCONACGNNLN([In] TDeps OJGLDAGFLKC, [In] TSerializedAction FBBJCBJMJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4661380", Offset = "0x465F980", VA = "0x184661380", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x57D1330", Offset = "0x57CF930", VA = "0x1857D1330")]
	internal DGAGACGIHNN(TActionKind LCEJNGBOIHI, [In] TPayload HJCJCIIFPJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class JDIIKJNMIAG
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2B6CAE0", Offset = "0x2B6B0E0", VA = "0x182B6CAE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x42AA800", Offset = "0x42A8E00", VA = "0x1842AA800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x42AB0E0", Offset = "0x42A96E0", VA = "0x1842AB0E0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0xAB3FA0", Offset = "0xAB25A0", VA = "0x180AB3FA0")]
	internal MNOJACLHNCK(Dictionary<TActionKind, MGAHMLHHLMO<TSerializedAction, TRoot, TDeps>> CHDDHEKCLMF, TDeps OJGLDAGFLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x44E5750", Offset = "0x44E3D50", VA = "0x1844E5750")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B31450", Offset = "0x2B2FA50", VA = "0x182B31450")]
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
	[Cpp2IlInjected.Address(RVA = "0x869B90", Offset = "0x868190", VA = "0x180869B90")]
	private IMJMDNBIGIB(Dictionary<TActionKind, MGAHMLHHLMO<TSerializedAction, TRoot, TDeps>> CHDDHEKCLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3EC1E20", Offset = "0x3EC0420", VA = "0x183EC1E20")]
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
		[Cpp2IlInjected.Address(RVA = "0x3CC7F80", Offset = "0x3CC6580", VA = "0x183CC7F80")]
		public DKFGOIBPDFD(KPHMJPPHFMM<TActionKind, TSerializedAction, TPayload> LBKCEAPAKHP, JPPNLMANOPC<TRoot, TPayload, TOk, TErr> PINNGLAIKDO, bool LFMBADLPAMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x581CFA0", Offset = "0x581B5A0", VA = "0x18581CFA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4082010", Offset = "0x4080610", VA = "0x184082010", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4083040", Offset = "0x4081640", VA = "0x184083040", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3CC7F80", Offset = "0x3CC6580", VA = "0x183CC7F80")]
		public ACGOMPKDMCJ(KPHMJPPHFMM<TActionKind, TSerializedAction, TPayload> LBKCEAPAKHP, BELEOFANPBB<TRoot, TPayload, TOk, TErr> PINNGLAIKDO, bool LFMBADLPAMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3CC78A0", Offset = "0x3CC5EA0", VA = "0x183CC78A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x9368D0", Offset = "0x934ED0", VA = "0x1809368D0")]
	private NLMPMICJONI(IMJMDNBIGIB<TActionKind, TSerializedAction, TRoot, TDeps> FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4578950", Offset = "0x4576F50", VA = "0x184578950")]
	public static NLMPMICJONI<TActionKind, TSerializedAction, TRoot, TDeps> HCLFOFEHDJP()
	{
		return default(NLMPMICJONI<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2AA0670", Offset = "0x2A9EC70", VA = "0x182AA0670")]
	public NLMPMICJONI<TActionKind, TSerializedAction, TRoot, TDeps> BEFMBDAJFNI<TPayload, TOk, TErr>(TActionKind LCEJNGBOIHI, KPHMJPPHFMM<TActionKind, TSerializedAction, TPayload> LBKCEAPAKHP, JPPNLMANOPC<TRoot, TPayload, TOk, TErr> PINNGLAIKDO, bool LFMBADLPAMJ = true) where TPayload : notnull where TOk : notnull where TErr : notnull, NJADGKCOIIE
	{
		return default(NLMPMICJONI<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2AA0670", Offset = "0x2A9EC70", VA = "0x182AA0670")]
	public NLMPMICJONI<TActionKind, TSerializedAction, TRoot, TDeps> ALKEEKCGEIB<TPayload, TOk, TErr>(TActionKind LCEJNGBOIHI, KPHMJPPHFMM<TActionKind, TSerializedAction, TPayload> LBKCEAPAKHP, BELEOFANPBB<TRoot, TPayload, TOk, TErr> PINNGLAIKDO, bool LFMBADLPAMJ = true) where TPayload : notnull where TOk : notnull where TErr : notnull, NJADGKCOIIE
	{
		return default(NLMPMICJONI<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x45789F0", Offset = "0x4576FF0", VA = "0x1845789F0")]
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
