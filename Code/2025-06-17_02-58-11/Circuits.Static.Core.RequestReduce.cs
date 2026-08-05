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
		[Cpp2IlInjected.Address(RVA = "0x290EE90", Offset = "0x290D890", VA = "0x18290EE90")]
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
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate PHLLKCOMGND<TActionKind, TPayload> AJDKGNIIEEJ<TActionKind, TSerializedAction, TPayload>(TSerializedAction AGFMADBPGID);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface FNJICEOFCAM<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KAFLOHEKGBO<object, EOIBCJECGDC>> ICHGCMOAIBG(TDeps BFPFMKIIKBG, TRoot ALPBGLGCPNB, TSerializedAction AGFMADBPGID);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class MJEMDKGLCBM<TActionKind, TSerializedAction, TRoot, TDeps> : NNALLDHJADJ where TDeps : KHGBCPGMOGM.LLCNBECMJAB<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps JIMKFPLDKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction MBCBKBFPIIK;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5482230", Offset = "0x5480C30", VA = "0x185482230")]
	public MJEMDKGLCBM([In] TDeps BFPFMKIIKBG, [In] TSerializedAction AGFMADBPGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5482110", Offset = "0x5480B10", VA = "0x185482110", Slot = "7")]
	public override string BKOEAJIGHJJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct PHLLKCOMGND<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind OLCODEGMMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload HGDFEIFJCIA;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5775150", Offset = "0x5773B50", VA = "0x185775150")]
	internal PHLLKCOMGND(TActionKind NEHFLILIPEH, [In] TPayload MGDBGDNLMCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class BEOAFPHAPCD
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x37F1050", Offset = "0x37EFA50", VA = "0x1837F1050")]
	public static PHLLKCOMGND<TActionKind, TPayload> FMDOFBCLPJB<TActionKind, TPayload>([In] TActionKind NEHFLILIPEH, [In] TPayload MGDBGDNLMCM)
	{
		return default(PHLLKCOMGND<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<KAFLOHEKGBO<TOk, TErr>> ANFINFEMCAE<TRoot, TPayload, TOk, TErr>(TRoot ALPBGLGCPNB, TPayload MGDBGDNLMCM);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate KAFLOHEKGBO<TOk, TErr> KKIBAEDABFO<TRoot, TPayload, TOk, TErr>(TRoot ALPBGLGCPNB, [In] TPayload MGDBGDNLMCM);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct JBKADDLOPAJ<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : KHGBCPGMOGM.LLCNBECMJAB<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HPMOFDMJACP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<KAFLOHEKGBO<object?, EOIBCJECGDC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public JBKADDLOPAJ<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<KAFLOHEKGBO<object, EOIBCJECGDC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4D12A50", Offset = "0x4D11450", VA = "0x184D12A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4D13330", Offset = "0x4D11D30", VA = "0x184D13330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, FNJICEOFCAM<TSerializedAction, TRoot, TDeps>> IMHCJDOFGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps JIMKFPLDKKF;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xB64460", Offset = "0xB62E60", VA = "0x180B64460")]
	internal JBKADDLOPAJ(Dictionary<TActionKind, FNJICEOFCAM<TSerializedAction, TRoot, TDeps>> NKEGMOIHDIL, TDeps BFPFMKIIKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5054B60", Offset = "0x5053560", VA = "0x185054B60")]
	[AsyncStateMachine(typeof(JBKADDLOPAJ<, , , >.HPMOFDMJACP))]
	public Task<KAFLOHEKGBO<object, EOIBCJECGDC>> ICHGCMOAIBG(TRoot ALPBGLGCPNB, TSerializedAction AGFMADBPGID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class KHGBCPGMOGM
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface LLCNBECMJAB<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind CGKFACLPLCM(TSerializedAction NMEFAPBBOCD);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LEMAMJODMBO(TRoot ALPBGLGCPNB, TSerializedAction KPGBPPBMJJK);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OONOMJOFGEE(TRoot ALPBGLGCPNB, TSerializedAction KPGBPPBMJJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2FF2A60", Offset = "0x2FF1460", VA = "0x182FF2A60")]
	internal static JBKADDLOPAJ<TActionKind, TSerializedAction, TRoot, TDeps> FMDOFBCLPJB<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, FNJICEOFCAM<TSerializedAction, TRoot, TDeps>> NKEGMOIHDIL, TDeps BFPFMKIIKBG) where TDeps : LLCNBECMJAB<TActionKind, TSerializedAction, TRoot>
	{
		return default(JBKADDLOPAJ<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class DPJAJAJFAJB<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, FNJICEOFCAM<TSerializedAction, TRoot, TDeps>> NHJNMBEABMN;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xA14510", Offset = "0xA12F10", VA = "0x180A14510")]
	private DPJAJAJFAJB(Dictionary<TActionKind, FNJICEOFCAM<TSerializedAction, TRoot, TDeps>> NKEGMOIHDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x425EFD0", Offset = "0x425D9D0", VA = "0x18425EFD0")]
	public static DPJAJAJFAJB<TActionKind, TSerializedAction, TRoot, TDeps> FMDOFBCLPJB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct CNJLCIJAIEL<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, KHGBCPGMOGM.LLCNBECMJAB<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class FPGOLGMJPNF<TPayload, TOk, TErr> : FNJICEOFCAM<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, EOIBCJECGDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly AJDKGNIIEEJ<TActionKind, TSerializedAction, TPayload> NKJFACPBNNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly KKIBAEDABFO<TRoot, TPayload, TOk, TErr> CJDDIMAFDPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool JNGADOACBHN;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1AF47E0", Offset = "0x1AF31E0", VA = "0x181AF47E0")]
		public FPGOLGMJPNF(AJDKGNIIEEJ<TActionKind, TSerializedAction, TPayload> PDEMGJGPGLC, KKIBAEDABFO<TRoot, TPayload, TOk, TErr> GHCDFMOHBGD, bool IDPMGHAJNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4B8CE20", Offset = "0x4B8B820", VA = "0x184B8CE20", Slot = "4")]
		public Task<KAFLOHEKGBO<object, EOIBCJECGDC>> ICHGCMOAIBG(TDeps BFPFMKIIKBG, TRoot ALPBGLGCPNB, TSerializedAction AGFMADBPGID)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class HFLJLMFKFLP<TPayload, TOk, TErr> : FNJICEOFCAM<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, EOIBCJECGDC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct NPBHMCMJKBB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<KAFLOHEKGBO<object?, EOIBCJECGDC>> <>t__builder;

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
			public HFLJLMFKFLP<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private KAFLOHEKGBO<object?, EOIBCJECGDC> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<KAFLOHEKGBO<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5555B80", Offset = "0x5554580", VA = "0x185555B80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x55574C0", Offset = "0x5555EC0", VA = "0x1855574C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly AJDKGNIIEEJ<TActionKind, TSerializedAction, TPayload> NKJFACPBNNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly ANFINFEMCAE<TRoot, TPayload, TOk, TErr> CJDDIMAFDPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool JNGADOACBHN;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1AF47E0", Offset = "0x1AF31E0", VA = "0x181AF47E0")]
		public HFLJLMFKFLP(AJDKGNIIEEJ<TActionKind, TSerializedAction, TPayload> PDEMGJGPGLC, ANFINFEMCAE<TRoot, TPayload, TOk, TErr> GHCDFMOHBGD, bool IDPMGHAJNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4CEE1C0", Offset = "0x4CECBC0", VA = "0x184CEE1C0", Slot = "4")]
		[AsyncStateMachine(typeof(HFLJLMFKFLP<, , >.NPBHMCMJKBB))]
		public Task<KAFLOHEKGBO<object, EOIBCJECGDC>> ICHGCMOAIBG(TDeps BFPFMKIIKBG, TRoot ALPBGLGCPNB, TSerializedAction AGFMADBPGID)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly DPJAJAJFAJB<TActionKind, TSerializedAction, TRoot, TDeps> NCKMCOFLEHM;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xDCCB40", Offset = "0xDCB540", VA = "0x180DCCB40")]
	private CNJLCIJAIEL(DPJAJAJFAJB<TActionKind, TSerializedAction, TRoot, TDeps> HPGIDELCODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x674F250", Offset = "0x674DC50", VA = "0x18674F250")]
	public static CNJLCIJAIEL<TActionKind, TSerializedAction, TRoot, TDeps> FMDOFBCLPJB()
	{
		return default(CNJLCIJAIEL<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3ECA340", Offset = "0x3EC8D40", VA = "0x183ECA340")]
	public CNJLCIJAIEL<TActionKind, TSerializedAction, TRoot, TDeps> BDNHIBLLNID<TPayload, TOk, TErr>(TActionKind NEHFLILIPEH, AJDKGNIIEEJ<TActionKind, TSerializedAction, TPayload> PDEMGJGPGLC, KKIBAEDABFO<TRoot, TPayload, TOk, TErr> GHCDFMOHBGD, bool IDPMGHAJNPH = true) where TPayload : notnull where TOk : notnull where TErr : notnull, EOIBCJECGDC
	{
		return default(CNJLCIJAIEL<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3ECA340", Offset = "0x3EC8D40", VA = "0x183ECA340")]
	public CNJLCIJAIEL<TActionKind, TSerializedAction, TRoot, TDeps> GEJJIHACOBK<TPayload, TOk, TErr>(TActionKind NEHFLILIPEH, AJDKGNIIEEJ<TActionKind, TSerializedAction, TPayload> PDEMGJGPGLC, ANFINFEMCAE<TRoot, TPayload, TOk, TErr> GHCDFMOHBGD, bool IDPMGHAJNPH = true) where TPayload : notnull where TOk : notnull where TErr : notnull, EOIBCJECGDC
	{
		return default(CNJLCIJAIEL<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x674F1A0", Offset = "0x674DBA0", VA = "0x18674F1A0")]
	public JBKADDLOPAJ<TActionKind, TSerializedAction, TRoot, TDeps> EKDNODFNLJP(TDeps BFPFMKIIKBG)
	{
		return default(JBKADDLOPAJ<TActionKind, TSerializedAction, TRoot, TDeps>);
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
