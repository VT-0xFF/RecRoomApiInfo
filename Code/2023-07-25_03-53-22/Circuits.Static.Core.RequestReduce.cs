using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
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
		[Cpp2IlInjected.Address(RVA = "0x86EBE0", Offset = "0x86DBE0", VA = "0x18086EBE0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x730FDC0", Offset = "0x730EDC0", VA = "0x18730FDC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA3FB40", Offset = "0xA3EB40", VA = "0x180A3FB40")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xCF9C40", Offset = "0xCF8C40", VA = "0x180CF9C40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct PMIOBCIBJNC<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly TActionKind EEPAEOCADGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TPayload AHDLHKFBPDP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x203FF30", Offset = "0x203EF30", VA = "0x18203FF30")]
	internal PMIOBCIBJNC(TActionKind AKOHLODMGDA, in TPayload EMBONFDCNJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class DJIJOGGAONC
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x23E52A0", Offset = "0x23E42A0", VA = "0x1823E52A0")]
	public static PMIOBCIBJNC<TActionKind, TPayload> DAABCIFNKOF<TActionKind, TPayload>(in TActionKind AKOHLODMGDA, in TPayload EMBONFDCNJA)
	{
		return default(PMIOBCIBJNC<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal interface POGPGINCALD<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<EEONHCOMEMH<object, BINCKAOMJCF>> ODLFNGAKEDA(TDeps OCBMLBBNJOG, TRoot EMIPEAKIENF, TSerializedAction ACGPMKCEAAM);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct NADHLLKHFCI<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : OOCPGIGGJEF.MDPIHKONIOP<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class LDOCBJHHBEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AsyncTaskMethodBuilder<EEONHCOMEMH<object, BINCKAOMJCF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public NADHLLKHFCI<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private EEONHCOMEMH<object, BINCKAOMJCF> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TActionKind <kind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private POGPGINCALD<TSerializedAction, TRoot, TDeps> <reducer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private EEONHCOMEMH<object, BINCKAOMJCF> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter<EEONHCOMEMH<object, BINCKAOMJCF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public LDOCBJHHBEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2686100", Offset = "0x2685100", VA = "0x182686100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TActionKind, POGPGINCALD<TSerializedAction, TRoot, TDeps>> BGDOJGBHMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly TDeps KBILNMMJIAF;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xA891D0", Offset = "0xA881D0", VA = "0x180A891D0")]
	internal NADHLLKHFCI(Dictionary<TActionKind, POGPGINCALD<TSerializedAction, TRoot, TDeps>> CBOMJIBOFEL, TDeps OCBMLBBNJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2976470", Offset = "0x2975470", VA = "0x182976470")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NADHLLKHFCI<, , , >.LDOCBJHHBEM))]
	public Task<EEONHCOMEMH<object, BINCKAOMJCF>> ODLFNGAKEDA(TRoot EMIPEAKIENF, TSerializedAction ACGPMKCEAAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class OOCPGIGGJEF
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface MDPIHKONIOP<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind HDHJKJALNEM(TSerializedAction FKGCCPKFEDE);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GPBHFIAPJMO(TRoot EMIPEAKIENF, TSerializedAction OKCPFPFJOFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3371C80", Offset = "0x3370C80", VA = "0x183371C80")]
	internal static NADHLLKHFCI<TActionKind, TSerializedAction, TRoot, TDeps> DAABCIFNKOF<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, POGPGINCALD<TSerializedAction, TRoot, TDeps>> CBOMJIBOFEL, TDeps OCBMLBBNJOG) where TDeps : MDPIHKONIOP<TActionKind, TSerializedAction, TRoot>
	{
		return default(NADHLLKHFCI<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate EEONHCOMEMH<TOk, TErr> PHKCJBOCKOA<TRoot, TPayload, TOk, TErr>(TRoot EMIPEAKIENF, in TPayload EMBONFDCNJA);
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal sealed class KFFMFICINCB<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Dictionary<TActionKind, POGPGINCALD<TSerializedAction, TRoot, TDeps>> KAHMGLOEMCH;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xBFE350", Offset = "0xBFD350", VA = "0x180BFE350")]
	private KFFMFICINCB(Dictionary<TActionKind, POGPGINCALD<TSerializedAction, TRoot, TDeps>> CBOMJIBOFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x353F030", Offset = "0x353E030", VA = "0x18353F030")]
	public static KFFMFICINCB<TActionKind, TSerializedAction, TRoot, TDeps> DAABCIFNKOF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate Task<EEONHCOMEMH<TOk, TErr>> BHIBOBEFKNO<TRoot, TPayload, TOk, TErr>(TRoot EMIPEAKIENF, TPayload EMBONFDCNJA);
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class MNJIBLMEBHM<TActionKind, TSerializedAction, TRoot, TDeps> : FNPAPHHOPJD where TDeps : OOCPGIGGJEF.MDPIHKONIOP<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly TDeps KBILNMMJIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly TSerializedAction HGJNMGECEOI;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x272F6C0", Offset = "0x272E6C0", VA = "0x18272F6C0")]
	public MNJIBLMEBHM(in TDeps OCBMLBBNJOG, in TSerializedAction ACGPMKCEAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x272F4F0", Offset = "0x272E4F0", VA = "0x18272F4F0", Slot = "7")]
	public override string PHAGEMDPKEM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public delegate PMIOBCIBJNC<TActionKind, TPayload> EKJMKOHALFA<TActionKind, TSerializedAction, TPayload>(TSerializedAction ACGPMKCEAAM);
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct EMLCOCAIDJC<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, OOCPGIGGJEF.MDPIHKONIOP<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class FNLLMLDAJOA<TPayload, TOk, TErr> : POGPGINCALD<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, BINCKAOMJCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly EKJMKOHALFA<TActionKind, TSerializedAction, TPayload> HKPFFPBPBFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly PHKCJBOCKOA<TRoot, TPayload, TOk, TErr> GEABBAJLHBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly bool KEFIOHLIMBN;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2747110", Offset = "0x2746110", VA = "0x182747110")]
		public FNLLMLDAJOA(EKJMKOHALFA<TActionKind, TSerializedAction, TPayload> FDHACNCAKJB, PHKCJBOCKOA<TRoot, TPayload, TOk, TErr> AIOHCOKDABH, bool IMCKKELFDPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x32D2FA0", Offset = "0x32D1FA0", VA = "0x1832D2FA0", Slot = "4")]
		public Task<EEONHCOMEMH<object, BINCKAOMJCF>> ODLFNGAKEDA(TDeps OCBMLBBNJOG, TRoot EMIPEAKIENF, TSerializedAction ACGPMKCEAAM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class MDJJKPOLIJF<TPayload, TOk, TErr> : POGPGINCALD<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, BINCKAOMJCF
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class BIGDDCKIIFN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A8C20", Offset = "0x7A8020")]
			public AsyncTaskMethodBuilder<EEONHCOMEMH<object, BINCKAOMJCF>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public TDeps deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public TRoot root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public TSerializedAction serializedAction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public MDJJKPOLIJF<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A8C80", Offset = "0x7A8080")]
			private EEONHCOMEMH<object, BINCKAOMJCF> <r>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A8CE0", Offset = "0x7A80E0")]
			private PMIOBCIBJNC<TActionKind, TPayload> <action>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A8D40", Offset = "0x7A8140")]
			private EEONHCOMEMH<TOk, TErr> <result>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A8DA0", Offset = "0x7A81A0")]
			private EEONHCOMEMH<TOk, TErr> <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A8E00", Offset = "0x7A8200")]
			private TaskAwaiter<EEONHCOMEMH<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
			public BIGDDCKIIFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x23B64A0", Offset = "0x23B54A0", VA = "0x1823B64A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly EKJMKOHALFA<TActionKind, TSerializedAction, TPayload> HKPFFPBPBFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly BHIBOBEFKNO<TRoot, TPayload, TOk, TErr> GEABBAJLHBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly bool KEFIOHLIMBN;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2747110", Offset = "0x2746110", VA = "0x182747110")]
		public MDJJKPOLIJF(EKJMKOHALFA<TActionKind, TSerializedAction, TPayload> FDHACNCAKJB, BHIBOBEFKNO<TRoot, TPayload, TOk, TErr> AIOHCOKDABH, bool IMCKKELFDPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2746990", Offset = "0x2745990", VA = "0x182746990", Slot = "4")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(MDJJKPOLIJF<, , >.BIGDDCKIIFN))]
		public Task<EEONHCOMEMH<object, BINCKAOMJCF>> ODLFNGAKEDA(TDeps OCBMLBBNJOG, TRoot EMIPEAKIENF, TSerializedAction ACGPMKCEAAM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly KFFMFICINCB<TActionKind, TSerializedAction, TRoot, TDeps> BBJLJGINJII;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xA2BF10", Offset = "0xA2AF10", VA = "0x180A2BF10")]
	private EMLCOCAIDJC(KFFMFICINCB<TActionKind, TSerializedAction, TRoot, TDeps> HHCEHFFEAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xC3D520", Offset = "0xC3C520", VA = "0x180C3D520")]
	public static EMLCOCAIDJC<TActionKind, TSerializedAction, TRoot, TDeps> DAABCIFNKOF()
	{
		return default(EMLCOCAIDJC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xE5FC70", Offset = "0xE5EC70", VA = "0x180E5FC70")]
	public EMLCOCAIDJC<TActionKind, TSerializedAction, TRoot, TDeps> EDCIKKGCHJE<TPayload, TOk, TErr>(TActionKind AKOHLODMGDA, EKJMKOHALFA<TActionKind, TSerializedAction, TPayload> FDHACNCAKJB, PHKCJBOCKOA<TRoot, TPayload, TOk, TErr> AIOHCOKDABH, bool IMCKKELFDPE = true) where TPayload : notnull where TOk : notnull where TErr : notnull, BINCKAOMJCF
	{
		return default(EMLCOCAIDJC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xE5FC70", Offset = "0xE5EC70", VA = "0x180E5FC70")]
	public EMLCOCAIDJC<TActionKind, TSerializedAction, TRoot, TDeps> MDMBCNBAHFH<TPayload, TOk, TErr>(TActionKind AKOHLODMGDA, EKJMKOHALFA<TActionKind, TSerializedAction, TPayload> FDHACNCAKJB, BHIBOBEFKNO<TRoot, TPayload, TOk, TErr> AIOHCOKDABH, bool IMCKKELFDPE = true) where TPayload : notnull where TOk : notnull where TErr : notnull, BINCKAOMJCF
	{
		return default(EMLCOCAIDJC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xC3D5B0", Offset = "0xC3C5B0", VA = "0x180C3D5B0")]
	public NADHLLKHFCI<TActionKind, TSerializedAction, TRoot, TDeps> ILIAJIKNDAM(TDeps OCBMLBBNJOG)
	{
		return default(NADHLLKHFCI<TActionKind, TSerializedAction, TRoot, TDeps>);
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
