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
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
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
		[Cpp2IlInjected.Address(RVA = "0x2318C60", Offset = "0x2317C60", VA = "0x182318C60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0550", Offset = "0x8DF550", VA = "0x1808E0550")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E0590", Offset = "0x8DF590", VA = "0x1808E0590")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate DBJDFKLHOGP<TActionKind, TPayload> JDCKBDEEMAC<TActionKind, TSerializedAction, TPayload>(TSerializedAction NHEEEODKMPH);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface EHGPJGEMHFJ<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OBFFLKDLIBJ<object, FGHJECBDJBN>> KICADFKANDI(TDeps IKBDGBPPCAB, TRoot BAOAKGNNKEP, TSerializedAction NHEEEODKMPH);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class OKDFFGEOACJ<TActionKind, TSerializedAction, TRoot, TDeps> : DCDJFOHHJCP where TDeps : MNKKGBFNDJP.MNGJFPJAFCM<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps PBAEBCPCIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction DNILKDJEBCO;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4B1D710", Offset = "0x4B1C710", VA = "0x184B1D710")]
	public OKDFFGEOACJ([In] TDeps IKBDGBPPCAB, [In] TSerializedAction NHEEEODKMPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4B1D5E0", Offset = "0x4B1C5E0", VA = "0x184B1D5E0", Slot = "7")]
	public override string DOJAIBMDODD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct DBJDFKLHOGP<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind JKPDJNFHDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload PKGMMHJMOKB;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E330", Offset = "0x5D4D330", VA = "0x185D4E330")]
	internal DBJDFKLHOGP(TActionKind ALABGBIIFLM, [In] TPayload NDBAHEIEDNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GFCKKABGKKJ
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2F7F490", Offset = "0x2F7E490", VA = "0x182F7F490")]
	public static DBJDFKLHOGP<TActionKind, TPayload> EJLELCHFLID<TActionKind, TPayload>([In] TActionKind ALABGBIIFLM, [In] TPayload NDBAHEIEDNL)
	{
		return default(DBJDFKLHOGP<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<OBFFLKDLIBJ<TOk, TErr>> CMAJCGMIMHO<TRoot, TPayload, TOk, TErr>(TRoot BAOAKGNNKEP, TPayload NDBAHEIEDNL);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate OBFFLKDLIBJ<TOk, TErr> FMMGADLADOG<TRoot, TPayload, TOk, TErr>(TRoot BAOAKGNNKEP, [In] TPayload NDBAHEIEDNL);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct FCIELBGBPJB<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : MNKKGBFNDJP.MNGJFPJAFCM<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct EJHAPEDDOIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<OBFFLKDLIBJ<object, FGHJECBDJBN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public FCIELBGBPJB<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<OBFFLKDLIBJ<object, FGHJECBDJBN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3C5E9A0", Offset = "0x3C5D9A0", VA = "0x183C5E9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3C5F2F0", Offset = "0x3C5E2F0", VA = "0x183C5F2F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, EHGPJGEMHFJ<TSerializedAction, TRoot, TDeps>> LNMIKILIJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps PBAEBCPCIME;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xE8C760", Offset = "0xE8B760", VA = "0x180E8C760")]
	internal FCIELBGBPJB(Dictionary<TActionKind, EHGPJGEMHFJ<TSerializedAction, TRoot, TDeps>> JEJDHAHICFB, TDeps IKBDGBPPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3FF0AF0", Offset = "0x3FEFAF0", VA = "0x183FF0AF0")]
	[AsyncStateMachine(typeof(FCIELBGBPJB<, , , >.EJHAPEDDOIF))]
	public Task<OBFFLKDLIBJ<object, FGHJECBDJBN>> KICADFKANDI(TRoot BAOAKGNNKEP, TSerializedAction NHEEEODKMPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class MNKKGBFNDJP
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface MNGJFPJAFCM<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind FLLLBHNMOIF(TSerializedAction GFJPFDOHONG);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GDGJCPFFLOH(TRoot BAOAKGNNKEP, TSerializedAction NDLMGANFCBJ);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void DHHJPBBHCHJ(TRoot BAOAKGNNKEP, TSerializedAction NDLMGANFCBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2D5F9D0", Offset = "0x2D5E9D0", VA = "0x182D5F9D0")]
	internal static FCIELBGBPJB<TActionKind, TSerializedAction, TRoot, TDeps> EJLELCHFLID<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, EHGPJGEMHFJ<TSerializedAction, TRoot, TDeps>> JEJDHAHICFB, TDeps IKBDGBPPCAB) where TDeps : MNGJFPJAFCM<TActionKind, TSerializedAction, TRoot>
	{
		return default(FCIELBGBPJB<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class FPKOABCGKGH<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, EHGPJGEMHFJ<TSerializedAction, TRoot, TDeps>> LEPPHNHCDCJ;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8B9C70", Offset = "0x8B8C70", VA = "0x1808B9C70")]
	private FPKOABCGKGH(Dictionary<TActionKind, EHGPJGEMHFJ<TSerializedAction, TRoot, TDeps>> JEJDHAHICFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4020A00", Offset = "0x401FA00", VA = "0x184020A00")]
	public static FPKOABCGKGH<TActionKind, TSerializedAction, TRoot, TDeps> EJLELCHFLID()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct LDIGABEBEBD<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, MNKKGBFNDJP.MNGJFPJAFCM<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class CFPHEFMKDJB<TPayload, TOk, TErr> : EHGPJGEMHFJ<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, FGHJECBDJBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly JDCKBDEEMAC<TActionKind, TSerializedAction, TPayload> GKFCFPDHBBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly FMMGADLADOG<TRoot, TPayload, TOk, TErr> PNBBFNJBKHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool DLFADEPMOHH;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x467BE80", Offset = "0x467AE80", VA = "0x18467BE80")]
		public CFPHEFMKDJB(JDCKBDEEMAC<TActionKind, TSerializedAction, TPayload> FNLJEKMFNIJ, FMMGADLADOG<TRoot, TPayload, TOk, TErr> HDPGLALCNCB, bool FKNACJJADLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x57194F0", Offset = "0x57184F0", VA = "0x1857194F0", Slot = "4")]
		public Task<OBFFLKDLIBJ<object, FGHJECBDJBN>> KICADFKANDI(TDeps IKBDGBPPCAB, TRoot BAOAKGNNKEP, TSerializedAction NHEEEODKMPH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class KHKBMEKDNHG<TPayload, TOk, TErr> : EHGPJGEMHFJ<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, FGHJECBDJBN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct JGMDPNPDDFG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<OBFFLKDLIBJ<object?, FGHJECBDJBN>> <>t__builder;

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
			public KHKBMEKDNHG<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private OBFFLKDLIBJ<object?, FGHJECBDJBN> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<OBFFLKDLIBJ<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x458C0E0", Offset = "0x458B0E0", VA = "0x18458C0E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x458D5F0", Offset = "0x458C5F0", VA = "0x18458D5F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly JDCKBDEEMAC<TActionKind, TSerializedAction, TPayload> GKFCFPDHBBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly CMAJCGMIMHO<TRoot, TPayload, TOk, TErr> PNBBFNJBKHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool DLFADEPMOHH;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x467BE80", Offset = "0x467AE80", VA = "0x18467BE80")]
		public KHKBMEKDNHG(JDCKBDEEMAC<TActionKind, TSerializedAction, TPayload> FNLJEKMFNIJ, CMAJCGMIMHO<TRoot, TPayload, TOk, TErr> HDPGLALCNCB, bool FKNACJJADLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x467BBC0", Offset = "0x467ABC0", VA = "0x18467BBC0", Slot = "4")]
		[AsyncStateMachine(typeof(KHKBMEKDNHG<, , >.JGMDPNPDDFG))]
		public Task<OBFFLKDLIBJ<object, FGHJECBDJBN>> KICADFKANDI(TDeps IKBDGBPPCAB, TRoot BAOAKGNNKEP, TSerializedAction NHEEEODKMPH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly FPKOABCGKGH<TActionKind, TSerializedAction, TRoot, TDeps> GKCMKFABJAM;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x997970", Offset = "0x996970", VA = "0x180997970")]
	private LDIGABEBEBD(FPKOABCGKGH<TActionKind, TSerializedAction, TRoot, TDeps> CONAFKKIHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x473E830", Offset = "0x473D830", VA = "0x18473E830")]
	public static LDIGABEBEBD<TActionKind, TSerializedAction, TRoot, TDeps> EJLELCHFLID()
	{
		return default(LDIGABEBEBD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3273840", Offset = "0x3272840", VA = "0x183273840")]
	public LDIGABEBEBD<TActionKind, TSerializedAction, TRoot, TDeps> DJJONFGABLG<TPayload, TOk, TErr>(TActionKind ALABGBIIFLM, JDCKBDEEMAC<TActionKind, TSerializedAction, TPayload> FNLJEKMFNIJ, FMMGADLADOG<TRoot, TPayload, TOk, TErr> HDPGLALCNCB, bool FKNACJJADLO = true) where TPayload : notnull where TOk : notnull where TErr : notnull, FGHJECBDJBN
	{
		return default(LDIGABEBEBD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3273840", Offset = "0x3272840", VA = "0x183273840")]
	public LDIGABEBEBD<TActionKind, TSerializedAction, TRoot, TDeps> ADEKBMAEBGJ<TPayload, TOk, TErr>(TActionKind ALABGBIIFLM, JDCKBDEEMAC<TActionKind, TSerializedAction, TPayload> FNLJEKMFNIJ, CMAJCGMIMHO<TRoot, TPayload, TOk, TErr> HDPGLALCNCB, bool FKNACJJADLO = true) where TPayload : notnull where TOk : notnull where TErr : notnull, FGHJECBDJBN
	{
		return default(LDIGABEBEBD<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x473E8D0", Offset = "0x473D8D0", VA = "0x18473E8D0")]
	public FCIELBGBPJB<TActionKind, TSerializedAction, TRoot, TDeps> ENFIFPOLOLK(TDeps IKBDGBPPCAB)
	{
		return default(FCIELBGBPJB<TActionKind, TSerializedAction, TRoot, TDeps>);
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
