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
		[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D23430", Offset = "0x1D22830", VA = "0x181D23430")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BB450", Offset = "0x7BA850", VA = "0x1807BB450")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BB490", Offset = "0x7BA890", VA = "0x1807BB490")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate LCIMBLMCMNC<TActionKind, TPayload> LILIEFKMLKF<TActionKind, TSerializedAction, TPayload>(TSerializedAction LCFGGFPFEME);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface MKFFAEOMGOM<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EGECKPFNJNE<object, APEAMGBOOBA>> DPKPFNOLLKN(TDeps BFMHNHDBGGN, TRoot MMKDJDGOBEM, TSerializedAction LCFGGFPFEME);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class BJKADHPILAK<TActionKind, TSerializedAction, TRoot, TDeps> : GOLJEOBBMJE where TDeps : GHNFMAMPACM.KOONEAABNAH<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps BCBDJODLAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction PPHBIOPBDIA;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4710C70", Offset = "0x4710070", VA = "0x184710C70")]
	public BJKADHPILAK([In] TDeps BFMHNHDBGGN, [In] TSerializedAction LCFGGFPFEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4710AA0", Offset = "0x470FEA0", VA = "0x184710AA0", Slot = "7")]
	public override string GPDEFFKCMGK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct LCIMBLMCMNC<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind EEKILNPNJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload NHMFLMAEMHJ;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3BF5620", Offset = "0x3BF4A20", VA = "0x183BF5620")]
	internal LCIMBLMCMNC(TActionKind ODDKELCKCLB, [In] TPayload JFKHFDHADBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class IEHFNFOKANI
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x263E6B0", Offset = "0x263DAB0", VA = "0x18263E6B0")]
	public static LCIMBLMCMNC<TActionKind, TPayload> PIJMMFMEPKL<TActionKind, TPayload>([In] TActionKind ODDKELCKCLB, [In] TPayload JFKHFDHADBL)
	{
		return default(LCIMBLMCMNC<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<EGECKPFNJNE<TOk, TErr>> OJNKLIECMDI<TRoot, TPayload, TOk, TErr>(TRoot MMKDJDGOBEM, TPayload JFKHFDHADBL);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate EGECKPFNJNE<TOk, TErr> JLBBKFFGNKJ<TRoot, TPayload, TOk, TErr>(TRoot MMKDJDGOBEM, [In] TPayload JFKHFDHADBL);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct AGDGPALHBLG<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : GHNFMAMPACM.KOONEAABNAH<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct IAPMDIHGOLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<object, APEAMGBOOBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AGDGPALHBLG<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<EGECKPFNJNE<object, APEAMGBOOBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x38C6F30", Offset = "0x38C6330", VA = "0x1838C6F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x38C7850", Offset = "0x38C6C50", VA = "0x1838C7850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, MKFFAEOMGOM<TSerializedAction, TRoot, TDeps>> GHAHEOMMGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps BCBDJODLAEE;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x863610", Offset = "0x862A10", VA = "0x180863610")]
	internal AGDGPALHBLG(Dictionary<TActionKind, MKFFAEOMGOM<TSerializedAction, TRoot, TDeps>> EMLHFKMNJKD, TDeps BFMHNHDBGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3746740", Offset = "0x3745B40", VA = "0x183746740")]
	[AsyncStateMachine(typeof(AGDGPALHBLG<, , , >.IAPMDIHGOLF))]
	public Task<EGECKPFNJNE<object, APEAMGBOOBA>> DPKPFNOLLKN(TRoot MMKDJDGOBEM, TSerializedAction LCFGGFPFEME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class GHNFMAMPACM
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface KOONEAABNAH<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind OEOBLLBCLNC(TSerializedAction LHCHBOKBAPK);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BLCJABPEKOE(TRoot MMKDJDGOBEM, TSerializedAction EEEBGEOHFMI);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void IAEEHKPNGMD(TRoot MMKDJDGOBEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x24B4760", Offset = "0x24B3B60", VA = "0x1824B4760")]
	internal static AGDGPALHBLG<TActionKind, TSerializedAction, TRoot, TDeps> PIJMMFMEPKL<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, MKFFAEOMGOM<TSerializedAction, TRoot, TDeps>> EMLHFKMNJKD, TDeps BFMHNHDBGGN) where TDeps : KOONEAABNAH<TActionKind, TSerializedAction, TRoot>
	{
		return default(AGDGPALHBLG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class BLNKJDEAFLO<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, MKFFAEOMGOM<TSerializedAction, TRoot, TDeps>> ANICFGLFCGL;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7967D0", Offset = "0x795BD0", VA = "0x1807967D0")]
	private BLNKJDEAFLO(Dictionary<TActionKind, MKFFAEOMGOM<TSerializedAction, TRoot, TDeps>> EMLHFKMNJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4718E80", Offset = "0x4718280", VA = "0x184718E80")]
	public static BLNKJDEAFLO<TActionKind, TSerializedAction, TRoot, TDeps> PIJMMFMEPKL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct GDNIGEHJANO<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, GHNFMAMPACM.KOONEAABNAH<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class FFGNGLMEBIP<TPayload, TOk, TErr> : MKFFAEOMGOM<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, APEAMGBOOBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LILIEFKMLKF<TActionKind, TSerializedAction, TPayload> IPLKAHDGBHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly JLBBKFFGNKJ<TRoot, TPayload, TOk, TErr> GCNOAOIHEHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool BIMMFGOMCNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly bool JFBFAINOMBL;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3664B50", Offset = "0x3663F50", VA = "0x183664B50")]
		public FFGNGLMEBIP(LILIEFKMLKF<TActionKind, TSerializedAction, TPayload> JOPPAIKACFA, JLBBKFFGNKJ<TRoot, TPayload, TOk, TErr> BGFJGOGLHGA, bool EIHLIJHJMMI, bool DDJFBHACNFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3662450", Offset = "0x3661850", VA = "0x183662450", Slot = "4")]
		public Task<EGECKPFNJNE<object, APEAMGBOOBA>> DPKPFNOLLKN(TDeps BFMHNHDBGGN, TRoot MMKDJDGOBEM, TSerializedAction LCFGGFPFEME)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class LIFGLOMNPPL<TPayload, TOk, TErr> : MKFFAEOMGOM<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, APEAMGBOOBA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct AAKGLKBIDMJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<EGECKPFNJNE<object?, APEAMGBOOBA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public LIFGLOMNPPL<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public TDeps deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public TRoot root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public TSerializedAction serializedAction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private EGECKPFNJNE<object?, APEAMGBOOBA> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private TaskAwaiter<EGECKPFNJNE<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x3716950", Offset = "0x3715D50", VA = "0x183716950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x3717400", Offset = "0x3716800", VA = "0x183717400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly LILIEFKMLKF<TActionKind, TSerializedAction, TPayload> IPLKAHDGBHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly OJNKLIECMDI<TRoot, TPayload, TOk, TErr> GCNOAOIHEHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly bool BIMMFGOMCNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly bool JFBFAINOMBL;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3664B50", Offset = "0x3663F50", VA = "0x183664B50")]
		public LIFGLOMNPPL(LILIEFKMLKF<TActionKind, TSerializedAction, TPayload> JOPPAIKACFA, OJNKLIECMDI<TRoot, TPayload, TOk, TErr> BGFJGOGLHGA, bool EIHLIJHJMMI, bool DDJFBHACNFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3C2B4B0", Offset = "0x3C2A8B0", VA = "0x183C2B4B0", Slot = "4")]
		[AsyncStateMachine(typeof(LIFGLOMNPPL<, , >.AAKGLKBIDMJ))]
		public Task<EGECKPFNJNE<object, APEAMGBOOBA>> DPKPFNOLLKN(TDeps BFMHNHDBGGN, TRoot MMKDJDGOBEM, TSerializedAction LCFGGFPFEME)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly BLNKJDEAFLO<TActionKind, TSerializedAction, TRoot, TDeps> LPJCKAJGIJA;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8BCA20", Offset = "0x8BBE20", VA = "0x1808BCA20")]
	private GDNIGEHJANO(BLNKJDEAFLO<TActionKind, TSerializedAction, TRoot, TDeps> GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3773090", Offset = "0x3772490", VA = "0x183773090")]
	public static GDNIGEHJANO<TActionKind, TSerializedAction, TRoot, TDeps> PIJMMFMEPKL()
	{
		return default(GDNIGEHJANO<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x247A490", Offset = "0x2479890", VA = "0x18247A490")]
	public GDNIGEHJANO<TActionKind, TSerializedAction, TRoot, TDeps> AFEBAGCJLLC<TPayload, TOk, TErr>(TActionKind ODDKELCKCLB, LILIEFKMLKF<TActionKind, TSerializedAction, TPayload> JOPPAIKACFA, JLBBKFFGNKJ<TRoot, TPayload, TOk, TErr> BGFJGOGLHGA, bool EIHLIJHJMMI = true, bool DDJFBHACNFB = true) where TPayload : notnull where TOk : notnull where TErr : notnull, APEAMGBOOBA
	{
		return default(GDNIGEHJANO<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x247A490", Offset = "0x2479890", VA = "0x18247A490")]
	public GDNIGEHJANO<TActionKind, TSerializedAction, TRoot, TDeps> OMFLBCFPNOH<TPayload, TOk, TErr>(TActionKind ODDKELCKCLB, LILIEFKMLKF<TActionKind, TSerializedAction, TPayload> JOPPAIKACFA, OJNKLIECMDI<TRoot, TPayload, TOk, TErr> BGFJGOGLHGA, bool EIHLIJHJMMI = true, bool DDJFBHACNFB = true) where TPayload : notnull where TOk : notnull where TErr : notnull, APEAMGBOOBA
	{
		return default(GDNIGEHJANO<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3772FE0", Offset = "0x37723E0", VA = "0x183772FE0")]
	public AGDGPALHBLG<TActionKind, TSerializedAction, TRoot, TDeps> BKNLDEHFEEK(TDeps BFMHNHDBGGN)
	{
		return default(AGDGPALHBLG<TActionKind, TSerializedAction, TRoot, TDeps>);
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
