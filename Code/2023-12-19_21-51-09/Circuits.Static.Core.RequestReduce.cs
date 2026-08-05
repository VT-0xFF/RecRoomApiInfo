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
		[Cpp2IlInjected.Address(RVA = "0x79B4F0", Offset = "0x79A0F0", VA = "0x18079B4F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CCF0D0", Offset = "0x1CCDCD0", VA = "0x181CCF0D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79BDE0", Offset = "0x79A9E0", VA = "0x18079BDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79BE20", Offset = "0x79AA20", VA = "0x18079BE20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate EDPOFAHCIMN<TActionKind, TPayload> MOIIIAFKMFJ<TActionKind, TSerializedAction, TPayload>(TSerializedAction CJGDKPECOFB);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface FBMPEGHNPAH<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MEPDFJNPAPE<object, HEHIEEOHMHH>> IJNFDKDLLMD(TDeps BKGJDHEGAMG, TRoot NMHGPHBIAIB, TSerializedAction CJGDKPECOFB);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class EFAPHHJHIFL<TActionKind, TSerializedAction, TRoot, TDeps> : BIDCBADFDJH where TDeps : PJNIJFOPCAC.AALKCMNGEIE<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps JDKBNPIOBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction ICPNOJOGONF;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3160760", Offset = "0x315F360", VA = "0x183160760")]
	public EFAPHHJHIFL([In] TDeps BKGJDHEGAMG, [In] TSerializedAction CJGDKPECOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3160530", Offset = "0x315F130", VA = "0x183160530", Slot = "7")]
	public override string KDELHCHBOAN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct EDPOFAHCIMN<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind FLIKCLHBNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload LFJJDPDINEO;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3158530", Offset = "0x3157130", VA = "0x183158530")]
	internal EDPOFAHCIMN(TActionKind GJHGILFHEIK, [In] TPayload AGEBEEELPDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class FEEBOAMGGHG
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x24DD850", Offset = "0x24DC450", VA = "0x1824DD850")]
	public static EDPOFAHCIMN<TActionKind, TPayload> OOMHMBNJBCG<TActionKind, TPayload>([In] TActionKind GJHGILFHEIK, [In] TPayload AGEBEEELPDJ)
	{
		return default(EDPOFAHCIMN<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<MEPDFJNPAPE<TOk, TErr>> JGPIDFDNGPI<TRoot, TPayload, TOk, TErr>(TRoot NMHGPHBIAIB, TPayload AGEBEEELPDJ);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate MEPDFJNPAPE<TOk, TErr> EHMELEGFCBO<TRoot, TPayload, TOk, TErr>(TRoot NMHGPHBIAIB, [In] TPayload AGEBEEELPDJ);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct NDLBMGKJALA<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : PJNIJFOPCAC.AALKCMNGEIE<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct JLDHGEDKEHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<MEPDFJNPAPE<object, HEHIEEOHMHH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public NDLBMGKJALA<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<MEPDFJNPAPE<object, HEHIEEOHMHH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3915D30", Offset = "0x3914930", VA = "0x183915D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x39165D0", Offset = "0x39151D0", VA = "0x1839165D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, FBMPEGHNPAH<TSerializedAction, TRoot, TDeps>> JKOOECEONGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps JDKBNPIOBLG;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x835CA0", Offset = "0x8348A0", VA = "0x180835CA0")]
	internal NDLBMGKJALA(Dictionary<TActionKind, FBMPEGHNPAH<TSerializedAction, TRoot, TDeps>> PGPNDHFPPDK, TDeps BKGJDHEGAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3CFE550", Offset = "0x3CFD150", VA = "0x183CFE550")]
	[AsyncStateMachine(typeof(NDLBMGKJALA<, , , >.JLDHGEDKEHH))]
	public Task<MEPDFJNPAPE<object, HEHIEEOHMHH>> IJNFDKDLLMD(TRoot NMHGPHBIAIB, TSerializedAction CJGDKPECOFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class PJNIJFOPCAC
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface AALKCMNGEIE<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind DADGGDAMBEO(TSerializedAction HHHLENOMLMP);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CBILOAAGAAN(TRoot NMHGPHBIAIB, TSerializedAction GAFABDCELFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2590990", Offset = "0x258F590", VA = "0x182590990")]
	internal static NDLBMGKJALA<TActionKind, TSerializedAction, TRoot, TDeps> OOMHMBNJBCG<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, FBMPEGHNPAH<TSerializedAction, TRoot, TDeps>> PGPNDHFPPDK, TDeps BKGJDHEGAMG) where TDeps : AALKCMNGEIE<TActionKind, TSerializedAction, TRoot>
	{
		return default(NDLBMGKJALA<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class LMALNNFJGHJ<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, FBMPEGHNPAH<TSerializedAction, TRoot, TDeps>> ALHBILLCEAM;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x77D010", Offset = "0x77BC10", VA = "0x18077D010")]
	private LMALNNFJGHJ(Dictionary<TActionKind, FBMPEGHNPAH<TSerializedAction, TRoot, TDeps>> PGPNDHFPPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3A55DD0", Offset = "0x3A549D0", VA = "0x183A55DD0")]
	public static LMALNNFJGHJ<TActionKind, TSerializedAction, TRoot, TDeps> OOMHMBNJBCG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct PJHIEFLBCFO<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, PJNIJFOPCAC.AALKCMNGEIE<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class AGMEBANMELL<TPayload, TOk, TErr> : FBMPEGHNPAH<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, HEHIEEOHMHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly MOIIIAFKMFJ<TActionKind, TSerializedAction, TPayload> FBGNKHNLJDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly EHMELEGFCBO<TRoot, TPayload, TOk, TErr> DBBLMBNMMLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool GDOINPCEOFK;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x357D0E0", Offset = "0x357BCE0", VA = "0x18357D0E0")]
		public AGMEBANMELL(MOIIIAFKMFJ<TActionKind, TSerializedAction, TPayload> BGEEBIDFJKD, EHMELEGFCBO<TRoot, TPayload, TOk, TErr> BFPAMNOFPIN, bool GAHALHFEEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3577890", Offset = "0x3576490", VA = "0x183577890", Slot = "4")]
		public Task<MEPDFJNPAPE<object, HEHIEEOHMHH>> IJNFDKDLLMD(TDeps BKGJDHEGAMG, TRoot NMHGPHBIAIB, TSerializedAction CJGDKPECOFB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class AKNNIHNFEIJ<TPayload, TOk, TErr> : FBMPEGHNPAH<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, HEHIEEOHMHH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct PIAKLLOHACE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<MEPDFJNPAPE<object?, HEHIEEOHMHH>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public AKNNIHNFEIJ<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public TDeps deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public TRoot root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public TSerializedAction serializedAction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private MEPDFJNPAPE<object?, HEHIEEOHMHH> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<MEPDFJNPAPE<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x3E9E610", Offset = "0x3E9D210", VA = "0x183E9E610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x3E9EA40", Offset = "0x3E9D640", VA = "0x183E9EA40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly MOIIIAFKMFJ<TActionKind, TSerializedAction, TPayload> FBGNKHNLJDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly JGPIDFDNGPI<TRoot, TPayload, TOk, TErr> DBBLMBNMMLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool GDOINPCEOFK;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x357D0E0", Offset = "0x357BCE0", VA = "0x18357D0E0")]
		public AKNNIHNFEIJ(MOIIIAFKMFJ<TActionKind, TSerializedAction, TPayload> BGEEBIDFJKD, JGPIDFDNGPI<TRoot, TPayload, TOk, TErr> BFPAMNOFPIN, bool GAHALHFEEOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x371CB10", Offset = "0x371B710", VA = "0x18371CB10", Slot = "4")]
		[AsyncStateMachine(typeof(AKNNIHNFEIJ<, , >.PIAKLLOHACE))]
		public Task<MEPDFJNPAPE<object, HEHIEEOHMHH>> IJNFDKDLLMD(TDeps BKGJDHEGAMG, TRoot NMHGPHBIAIB, TSerializedAction CJGDKPECOFB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly LMALNNFJGHJ<TActionKind, TSerializedAction, TRoot, TDeps> JFFNBPDIOOE;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8739C0", Offset = "0x8725C0", VA = "0x1808739C0")]
	private PJHIEFLBCFO(LMALNNFJGHJ<TActionKind, TSerializedAction, TRoot, TDeps> IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3EAAB90", Offset = "0x3EA9790", VA = "0x183EAAB90")]
	public static PJHIEFLBCFO<TActionKind, TSerializedAction, TRoot, TDeps> OOMHMBNJBCG()
	{
		return default(PJHIEFLBCFO<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x243F170", Offset = "0x243DD70", VA = "0x18243F170")]
	public PJHIEFLBCFO<TActionKind, TSerializedAction, TRoot, TDeps> PFNFLIBPFCD<TPayload, TOk, TErr>(TActionKind GJHGILFHEIK, MOIIIAFKMFJ<TActionKind, TSerializedAction, TPayload> BGEEBIDFJKD, EHMELEGFCBO<TRoot, TPayload, TOk, TErr> BFPAMNOFPIN, bool GAHALHFEEOD = true) where TPayload : notnull where TOk : notnull where TErr : notnull, HEHIEEOHMHH
	{
		return default(PJHIEFLBCFO<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x243F170", Offset = "0x243DD70", VA = "0x18243F170")]
	public PJHIEFLBCFO<TActionKind, TSerializedAction, TRoot, TDeps> OPOCHOHMLEE<TPayload, TOk, TErr>(TActionKind GJHGILFHEIK, MOIIIAFKMFJ<TActionKind, TSerializedAction, TPayload> BGEEBIDFJKD, JGPIDFDNGPI<TRoot, TPayload, TOk, TErr> BFPAMNOFPIN, bool GAHALHFEEOD = true) where TPayload : notnull where TOk : notnull where TErr : notnull, HEHIEEOHMHH
	{
		return default(PJHIEFLBCFO<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3EAAAE0", Offset = "0x3EA96E0", VA = "0x183EAAAE0")]
	public NDLBMGKJALA<TActionKind, TSerializedAction, TRoot, TDeps> GPGNCMFFFIF(TDeps BKGJDHEGAMG)
	{
		return default(NDLBMGKJALA<TActionKind, TSerializedAction, TRoot, TDeps>);
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
