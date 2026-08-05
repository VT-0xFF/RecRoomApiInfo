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
		[Cpp2IlInjected.Address(RVA = "0x8389E0", Offset = "0x8377E0", VA = "0x1808389E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1943A40", Offset = "0x1942840", VA = "0x181943A40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x917630", Offset = "0x916430", VA = "0x180917630")]
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
		[Cpp2IlInjected.Address(RVA = "0xF6F160", Offset = "0xF6DF60", VA = "0x180F6F160")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct JPICGGBKILE<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly TActionKind AOJLCPDLHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TPayload CMDEFNMIHDC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3E7B760", Offset = "0x3E7A560", VA = "0x183E7B760")]
	internal JPICGGBKILE(TActionKind NHPMMNJPGIF, in TPayload GNCDGJDGENH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CICIALFKEPD
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2CCEA60", Offset = "0x2CCD860", VA = "0x182CCEA60")]
	public static JPICGGBKILE<TActionKind, TPayload> PKJHFAGPFPD<TActionKind, TPayload>(in TActionKind NHPMMNJPGIF, in TPayload GNCDGJDGENH)
	{
		return default(JPICGGBKILE<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal interface ICCAKKCAFBP<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ABAABAMKHON<object, KCFDFNEEHDO>> DFIMPNMFKFD(TDeps AFCFPPCINLL, TRoot BHODGDEIEBD, TSerializedAction PCCMIEGIMFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct JDMOEMCJGEA<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : INMKNJKDAIM.MJPHBANMMLM<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class NGLFIHDIPIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AsyncTaskMethodBuilder<ABAABAMKHON<object, KCFDFNEEHDO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public JDMOEMCJGEA<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private ABAABAMKHON<object, KCFDFNEEHDO> <r>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TActionKind <kind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private ICCAKKCAFBP<TSerializedAction, TRoot, TDeps> <reducer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private ABAABAMKHON<object, KCFDFNEEHDO> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter<ABAABAMKHON<object, KCFDFNEEHDO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
		public NGLFIHDIPIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3EBE9C0", Offset = "0x3EBD7C0", VA = "0x183EBE9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<TActionKind, ICCAKKCAFBP<TSerializedAction, TRoot, TDeps>> CNJIHDDBGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly TDeps NJOIFFFGGEE;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xAFE080", Offset = "0xAFCE80", VA = "0x180AFE080")]
	internal JDMOEMCJGEA(Dictionary<TActionKind, ICCAKKCAFBP<TSerializedAction, TRoot, TDeps>> EPNBPAOGKII, TDeps AFCFPPCINLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3190840", Offset = "0x318F640", VA = "0x183190840")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JDMOEMCJGEA<, , , >.NGLFIHDIPIM))]
	public Task<ABAABAMKHON<object, KCFDFNEEHDO>> DFIMPNMFKFD(TRoot BHODGDEIEBD, TSerializedAction PCCMIEGIMFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class INMKNJKDAIM
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface MJPHBANMMLM<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind PLMJMECNMHD(TSerializedAction FEEMIHFJMDK);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DEOCPBFCJFP(TRoot BHODGDEIEBD, TSerializedAction EHPEOJCHKEM);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x25E93B0", Offset = "0x25E81B0", VA = "0x1825E93B0")]
	internal static JDMOEMCJGEA<TActionKind, TSerializedAction, TRoot, TDeps> PKJHFAGPFPD<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, ICCAKKCAFBP<TSerializedAction, TRoot, TDeps>> EPNBPAOGKII, TDeps AFCFPPCINLL) where TDeps : MJPHBANMMLM<TActionKind, TSerializedAction, TRoot>
	{
		return default(JDMOEMCJGEA<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate ABAABAMKHON<TOk, TErr> DJIJEJIIGMD<TRoot, TPayload, TOk, TErr>(TRoot BHODGDEIEBD, in TPayload GNCDGJDGENH);
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal sealed class CBJBLBNFJHI<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Dictionary<TActionKind, ICCAKKCAFBP<TSerializedAction, TRoot, TDeps>> JHPNCMDHPAK;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2372190", Offset = "0x2370F90", VA = "0x182372190")]
	private CBJBLBNFJHI(Dictionary<TActionKind, ICCAKKCAFBP<TSerializedAction, TRoot, TDeps>> EPNBPAOGKII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3AE5830", Offset = "0x3AE4630", VA = "0x183AE5830")]
	public static CBJBLBNFJHI<TActionKind, TSerializedAction, TRoot, TDeps> PKJHFAGPFPD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public delegate Task<ABAABAMKHON<TOk, TErr>> FKGHKHHNOCL<TRoot, TPayload, TOk, TErr>(TRoot BHODGDEIEBD, TPayload GNCDGJDGENH);
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class DPBNJJFAKKN<TActionKind, TSerializedAction, TRoot, TDeps> : OIMBAJDJINM where TDeps : INMKNJKDAIM.MJPHBANMMLM<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly TDeps NJOIFFFGGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly TSerializedAction PHKPCLHHGMC;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3BA3690", Offset = "0x3BA2490", VA = "0x183BA3690")]
	public DPBNJJFAKKN(in TDeps AFCFPPCINLL, in TSerializedAction PCCMIEGIMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3BA3560", Offset = "0x3BA2360", VA = "0x183BA3560", Slot = "7")]
	public override string AFBGODFOPHA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public delegate JPICGGBKILE<TActionKind, TPayload> HLBJCCAPJLO<TActionKind, TSerializedAction, TPayload>(TSerializedAction PCCMIEGIMFJ);
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct MFNOILNIBNC<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, INMKNJKDAIM.MJPHBANMMLM<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class ADFJDLBKLHE<TPayload, TOk, TErr> : ICCAKKCAFBP<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, KCFDFNEEHDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly HLBJCCAPJLO<TActionKind, TSerializedAction, TPayload> DNJNMCJOBLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly DJIJEJIIGMD<TRoot, TPayload, TOk, TErr> MAPJLLALCDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly bool FBACMGIANDK;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3B16FD0", Offset = "0x3B15DD0", VA = "0x183B16FD0")]
		public ADFJDLBKLHE(HLBJCCAPJLO<TActionKind, TSerializedAction, TPayload> FOLMAIOMCFK, DJIJEJIIGMD<TRoot, TPayload, TOk, TErr> OBCIMLECEHH, bool DDDAFGOGFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x457D260", Offset = "0x457C060", VA = "0x18457D260", Slot = "4")]
		public Task<ABAABAMKHON<object, KCFDFNEEHDO>> DFIMPNMFKFD(TDeps AFCFPPCINLL, TRoot BHODGDEIEBD, TSerializedAction PCCMIEGIMFJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class HOMOFIGADOD<TPayload, TOk, TErr> : ICCAKKCAFBP<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, KCFDFNEEHDO
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class KONAFBDGCPL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xC2420", Offset = "0xC1820")]
			public AsyncTaskMethodBuilder<ABAABAMKHON<object, KCFDFNEEHDO>> <>t__builder;

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
			public HOMOFIGADOD<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xC2480", Offset = "0xC1880")]
			private ABAABAMKHON<object, KCFDFNEEHDO> <r>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xC24E0", Offset = "0xC18E0")]
			private JPICGGBKILE<TActionKind, TPayload> <action>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xC2540", Offset = "0xC1940")]
			private ABAABAMKHON<TOk, TErr> <result>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xC25A0", Offset = "0xC19A0")]
			private ABAABAMKHON<TOk, TErr> <>s__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xC2600", Offset = "0xC1A00")]
			private TaskAwaiter<ABAABAMKHON<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
			public KONAFBDGCPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x3C0B310", Offset = "0x3C0A110", VA = "0x183C0B310", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly HLBJCCAPJLO<TActionKind, TSerializedAction, TPayload> DNJNMCJOBLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly FKGHKHHNOCL<TRoot, TPayload, TOk, TErr> MAPJLLALCDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly bool FBACMGIANDK;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3B16FD0", Offset = "0x3B15DD0", VA = "0x183B16FD0")]
		public HOMOFIGADOD(HLBJCCAPJLO<TActionKind, TSerializedAction, TPayload> FOLMAIOMCFK, FKGHKHHNOCL<TRoot, TPayload, TOk, TErr> OBCIMLECEHH, bool DDDAFGOGFCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3B16850", Offset = "0x3B15650", VA = "0x183B16850", Slot = "4")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(HOMOFIGADOD<, , >.KONAFBDGCPL))]
		public Task<ABAABAMKHON<object, KCFDFNEEHDO>> DFIMPNMFKFD(TDeps AFCFPPCINLL, TRoot BHODGDEIEBD, TSerializedAction PCCMIEGIMFJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly CBJBLBNFJHI<TActionKind, TSerializedAction, TRoot, TDeps> IHHGALHJPPM;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0xD2AC10", Offset = "0xD29A10", VA = "0x180D2AC10")]
	private MFNOILNIBNC(CBJBLBNFJHI<TActionKind, TSerializedAction, TRoot, TDeps> FAJCHBCCGOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3884440", Offset = "0x3883240", VA = "0x183884440")]
	public static MFNOILNIBNC<TActionKind, TSerializedAction, TRoot, TDeps> PKJHFAGPFPD()
	{
		return default(MFNOILNIBNC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2AB2C40", Offset = "0x2AB1A40", VA = "0x182AB2C40")]
	public MFNOILNIBNC<TActionKind, TSerializedAction, TRoot, TDeps> GFFKGOCJOBH<TPayload, TOk, TErr>(TActionKind NHPMMNJPGIF, HLBJCCAPJLO<TActionKind, TSerializedAction, TPayload> FOLMAIOMCFK, DJIJEJIIGMD<TRoot, TPayload, TOk, TErr> OBCIMLECEHH, bool DDDAFGOGFCN = true) where TPayload : notnull where TOk : notnull where TErr : notnull, KCFDFNEEHDO
	{
		return default(MFNOILNIBNC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2AB2C40", Offset = "0x2AB1A40", VA = "0x182AB2C40")]
	public MFNOILNIBNC<TActionKind, TSerializedAction, TRoot, TDeps> LDPKECMOEPN<TPayload, TOk, TErr>(TActionKind NHPMMNJPGIF, HLBJCCAPJLO<TActionKind, TSerializedAction, TPayload> FOLMAIOMCFK, FKGHKHHNOCL<TRoot, TPayload, TOk, TErr> OBCIMLECEHH, bool DDDAFGOGFCN = true) where TPayload : notnull where TOk : notnull where TErr : notnull, KCFDFNEEHDO
	{
		return default(MFNOILNIBNC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3884390", Offset = "0x3883190", VA = "0x183884390")]
	public JDMOEMCJGEA<TActionKind, TSerializedAction, TRoot, TDeps> EBLHJDEJOME(TDeps AFCFPPCINLL)
	{
		return default(JDMOEMCJGEA<TActionKind, TSerializedAction, TRoot, TDeps>);
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
