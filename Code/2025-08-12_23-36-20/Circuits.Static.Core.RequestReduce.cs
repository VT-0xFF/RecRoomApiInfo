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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AF2370", Offset = "0x2AF1170", VA = "0x182AF2370")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xABFA20", Offset = "0xABE820", VA = "0x180ABFA20")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFA60", Offset = "0xABE860", VA = "0x180ABFA60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate NIFGKJHNJGM<TActionKind, TPayload> KAKMFKNAAFM<TActionKind, TSerializedAction, TPayload>(TSerializedAction EEFKOCNFOLP);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface GNKMEGEIMPA<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GECIHKBMECG<object, HFPJGMECLBA>> BFNEMLPPEPI(TDeps OPJFEEDOIEH, TRoot MMENCBNBOBJ, TSerializedAction EEFKOCNFOLP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class FBLGBAMDEKK<TActionKind, TSerializedAction, TRoot, TDeps> : FCKCACEJLLC where TDeps : DGIPADKNHEC.DLNKAAIKDOH<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps BFCDJMDIFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction DHLBBANOJNN;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7EF0", Offset = "0x4EF6CF0", VA = "0x184EF7EF0")]
	public FBLGBAMDEKK([In] TDeps OPJFEEDOIEH, [In] TSerializedAction EEFKOCNFOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7DC0", Offset = "0x4EF6BC0", VA = "0x184EF7DC0", Slot = "7")]
	public override string PGDOAEFAHEB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct NIFGKJHNJGM<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind BOBPKNJKAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload POAPMEOJEKO;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5985890", Offset = "0x5984690", VA = "0x185985890")]
	internal NIFGKJHNJGM(TActionKind ADACACCHGFC, [In] TPayload OBBABGHFJAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class FCHJAPDFOIC
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3CDB3D0", Offset = "0x3CDA1D0", VA = "0x183CDB3D0")]
	public static NIFGKJHNJGM<TActionKind, TPayload> ELDPFIHNJDG<TActionKind, TPayload>([In] TActionKind ADACACCHGFC, [In] TPayload OBBABGHFJAB)
	{
		return default(NIFGKJHNJGM<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<GECIHKBMECG<TOk, TErr>> MLEILCKHAKP<TRoot, TPayload, TOk, TErr>(TRoot MMENCBNBOBJ, TPayload OBBABGHFJAB);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate GECIHKBMECG<TOk, TErr> DBKMJCJHKNI<TRoot, TPayload, TOk, TErr>(TRoot MMENCBNBOBJ, [In] TPayload OBBABGHFJAB);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct HEJCFPNPMFG<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : DGIPADKNHEC.DLNKAAIKDOH<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NGLPPKBLBFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<GECIHKBMECG<object?, HFPJGMECLBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public HEJCFPNPMFG<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<GECIHKBMECG<object, HFPJGMECLBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x597F9C0", Offset = "0x597E7C0", VA = "0x18597F9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x597FEB0", Offset = "0x597ECB0", VA = "0x18597FEB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, GNKMEGEIMPA<TSerializedAction, TRoot, TDeps>> LDHOMFGEGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps BFCDJMDIFNA;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xC55370", Offset = "0xC54170", VA = "0x180C55370")]
	internal HEJCFPNPMFG(Dictionary<TActionKind, GNKMEGEIMPA<TSerializedAction, TRoot, TDeps>> JMBHAADOHAP, TDeps OPJFEEDOIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x508A6B0", Offset = "0x50894B0", VA = "0x18508A6B0")]
	[AsyncStateMachine(typeof(HEJCFPNPMFG<, , , >.NGLPPKBLBFB))]
	public Task<GECIHKBMECG<object, HFPJGMECLBA>> BFNEMLPPEPI(TRoot MMENCBNBOBJ, TSerializedAction EEFKOCNFOLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class DGIPADKNHEC
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface DLNKAAIKDOH<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind KPGMBOHHOAD(TSerializedAction DBBEADIHLKO);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DBIIJNMKDME(TRoot MMENCBNBOBJ, TSerializedAction IJBAPONMLAP);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KCFJPMBADEC(TRoot MMENCBNBOBJ, TSerializedAction IJBAPONMLAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3B584E0", Offset = "0x3B572E0", VA = "0x183B584E0")]
	internal static HEJCFPNPMFG<TActionKind, TSerializedAction, TRoot, TDeps> ELDPFIHNJDG<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, GNKMEGEIMPA<TSerializedAction, TRoot, TDeps>> JMBHAADOHAP, TDeps OPJFEEDOIEH) where TDeps : DLNKAAIKDOH<TActionKind, TSerializedAction, TRoot>
	{
		return default(HEJCFPNPMFG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class KKOFBAJNPBA<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, GNKMEGEIMPA<TSerializedAction, TRoot, TDeps>> CEMIOIFFEFC;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xA9BE10", Offset = "0xA9AC10", VA = "0x180A9BE10")]
	private KKOFBAJNPBA(Dictionary<TActionKind, GNKMEGEIMPA<TSerializedAction, TRoot, TDeps>> JMBHAADOHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x55EE9C0", Offset = "0x55ED7C0", VA = "0x1855EE9C0")]
	public static KKOFBAJNPBA<TActionKind, TSerializedAction, TRoot, TDeps> ELDPFIHNJDG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct IGNLLKEIMEG<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, DGIPADKNHEC.DLNKAAIKDOH<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class MMLLHFHGDJG<TPayload, TOk, TErr> : GNKMEGEIMPA<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, HFPJGMECLBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly KAKMFKNAAFM<TActionKind, TSerializedAction, TPayload> PNIOLKOMDHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly DBKMJCJHKNI<TRoot, TPayload, TOk, TErr> MKNIGKIAEAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool IDCLGMOGCAK;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1C88AF0", Offset = "0x1C878F0", VA = "0x181C88AF0")]
		public MMLLHFHGDJG(KAKMFKNAAFM<TActionKind, TSerializedAction, TPayload> NFHOIMOFGNG, DBKMJCJHKNI<TRoot, TPayload, TOk, TErr> KCGBNCGKHKF, bool LANHIIENGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x58D3240", Offset = "0x58D2040", VA = "0x1858D3240", Slot = "4")]
		public Task<GECIHKBMECG<object, HFPJGMECLBA>> BFNEMLPPEPI(TDeps OPJFEEDOIEH, TRoot MMENCBNBOBJ, TSerializedAction EEFKOCNFOLP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class JBFKDCOJMHI<TPayload, TOk, TErr> : GNKMEGEIMPA<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, HFPJGMECLBA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct FJANJMBFLLM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<GECIHKBMECG<object?, HFPJGMECLBA>> <>t__builder;

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
			public JBFKDCOJMHI<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private GECIHKBMECG<object?, HFPJGMECLBA> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<GECIHKBMECG<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4F13530", Offset = "0x4F12330", VA = "0x184F13530", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4F158F0", Offset = "0x4F146F0", VA = "0x184F158F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly KAKMFKNAAFM<TActionKind, TSerializedAction, TPayload> PNIOLKOMDHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly MLEILCKHAKP<TRoot, TPayload, TOk, TErr> MKNIGKIAEAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool IDCLGMOGCAK;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1C88AF0", Offset = "0x1C878F0", VA = "0x181C88AF0")]
		public JBFKDCOJMHI(KAKMFKNAAFM<TActionKind, TSerializedAction, TPayload> NFHOIMOFGNG, MLEILCKHAKP<TRoot, TPayload, TOk, TErr> KCGBNCGKHKF, bool LANHIIENGLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x545A0E0", Offset = "0x5458EE0", VA = "0x18545A0E0", Slot = "4")]
		[AsyncStateMachine(typeof(JBFKDCOJMHI<, , >.FJANJMBFLLM))]
		public Task<GECIHKBMECG<object, HFPJGMECLBA>> BFNEMLPPEPI(TDeps OPJFEEDOIEH, TRoot MMENCBNBOBJ, TSerializedAction EEFKOCNFOLP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly KKOFBAJNPBA<TActionKind, TSerializedAction, TRoot, TDeps> OHJBKIGEIPA;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xEA8530", Offset = "0xEA7330", VA = "0x180EA8530")]
	private IGNLLKEIMEG(KKOFBAJNPBA<TActionKind, TSerializedAction, TRoot, TDeps> KANAIIDGHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x52146E0", Offset = "0x52134E0", VA = "0x1852146E0")]
	public static IGNLLKEIMEG<TActionKind, TSerializedAction, TRoot, TDeps> ELDPFIHNJDG()
	{
		return default(IGNLLKEIMEG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x44899E0", Offset = "0x44887E0", VA = "0x1844899E0")]
	public IGNLLKEIMEG<TActionKind, TSerializedAction, TRoot, TDeps> BEFKMGABCBK<TPayload, TOk, TErr>(TActionKind ADACACCHGFC, KAKMFKNAAFM<TActionKind, TSerializedAction, TPayload> NFHOIMOFGNG, DBKMJCJHKNI<TRoot, TPayload, TOk, TErr> KCGBNCGKHKF, bool LANHIIENGLJ = true) where TPayload : notnull where TOk : notnull where TErr : notnull, HFPJGMECLBA
	{
		return default(IGNLLKEIMEG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x44899E0", Offset = "0x44887E0", VA = "0x1844899E0")]
	public IGNLLKEIMEG<TActionKind, TSerializedAction, TRoot, TDeps> FCJGFLONJLO<TPayload, TOk, TErr>(TActionKind ADACACCHGFC, KAKMFKNAAFM<TActionKind, TSerializedAction, TPayload> NFHOIMOFGNG, MLEILCKHAKP<TRoot, TPayload, TOk, TErr> KCGBNCGKHKF, bool LANHIIENGLJ = true) where TPayload : notnull where TOk : notnull where TErr : notnull, HFPJGMECLBA
	{
		return default(IGNLLKEIMEG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5214770", Offset = "0x5213570", VA = "0x185214770")]
	public HEJCFPNPMFG<TActionKind, TSerializedAction, TRoot, TDeps> OKAPFDDJAJF(TDeps OPJFEEDOIEH)
	{
		return default(HEJCFPNPMFG<TActionKind, TSerializedAction, TRoot, TDeps>);
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
