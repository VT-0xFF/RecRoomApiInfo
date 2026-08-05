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
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
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
		[Cpp2IlInjected.Address(RVA = "0x20CD4E0", Offset = "0x20CBEE0", VA = "0x1820CD4E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AEC90", Offset = "0x8AD690", VA = "0x1808AEC90")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AECD0", Offset = "0x8AD6D0", VA = "0x1808AECD0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate HPLECPIBIIH<TActionKind, TPayload> MNIMHPNMKOA<TActionKind, TSerializedAction, TPayload>(TSerializedAction EHPLPJFOHKK);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface EDPKKHHEMKC<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MOKFKOEPKDB<object, JNDPMGELPNI>> NCBFHFABHGH(TDeps JPDKLLDNBGD, TRoot MGPJOGDJPHA, TSerializedAction EHPLPJFOHKK);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class MKNDEPENOPN<TActionKind, TSerializedAction, TRoot, TDeps> : LAEJIKKOMKB where TDeps : EINFKNJDJCL.AKGGBJEONCP<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps OIIMCPAPNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction KCMHNOGJMCF;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4629AD0", Offset = "0x46284D0", VA = "0x184629AD0")]
	public MKNDEPENOPN([In] TDeps JPDKLLDNBGD, [In] TSerializedAction EHPLPJFOHKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x46299A0", Offset = "0x46283A0", VA = "0x1846299A0", Slot = "7")]
	public override string PDDPMMJGDDN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct HPLECPIBIIH<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind LPHJLIFMBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload BDIPEGBKFNJ;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3F030C0", Offset = "0x3F01AC0", VA = "0x183F030C0")]
	internal HPLECPIBIIH(TActionKind DLCNFDMDJBL, [In] TPayload NGDEBDJEGEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class HKHHHAMGCNB
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2C97DD0", Offset = "0x2C967D0", VA = "0x182C97DD0")]
	public static HPLECPIBIIH<TActionKind, TPayload> MMKGNMBHOIH<TActionKind, TPayload>([In] TActionKind DLCNFDMDJBL, [In] TPayload NGDEBDJEGEI)
	{
		return default(HPLECPIBIIH<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<MOKFKOEPKDB<TOk, TErr>> ILGIDEONDKJ<TRoot, TPayload, TOk, TErr>(TRoot MGPJOGDJPHA, TPayload NGDEBDJEGEI);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate MOKFKOEPKDB<TOk, TErr> GBCHPBLNCLE<TRoot, TPayload, TOk, TErr>(TRoot MGPJOGDJPHA, [In] TPayload NGDEBDJEGEI);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct PHFJLKJHNDO<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : EINFKNJDJCL.AKGGBJEONCP<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct KBKGONNMDDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<MOKFKOEPKDB<object, JNDPMGELPNI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public PHFJLKJHNDO<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<MOKFKOEPKDB<object, JNDPMGELPNI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x42F0FC0", Offset = "0x42EF9C0", VA = "0x1842F0FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x42F1900", Offset = "0x42F0300", VA = "0x1842F1900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, EDPKKHHEMKC<TSerializedAction, TRoot, TDeps>> CDCHPPEJGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps OIIMCPAPNGD;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xC4E920", Offset = "0xC4D320", VA = "0x180C4E920")]
	internal PHFJLKJHNDO(Dictionary<TActionKind, EDPKKHHEMKC<TSerializedAction, TRoot, TDeps>> CIHBNAPGOAM, TDeps JPDKLLDNBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4931B30", Offset = "0x4930530", VA = "0x184931B30")]
	[AsyncStateMachine(typeof(PHFJLKJHNDO<, , , >.KBKGONNMDDP))]
	public Task<MOKFKOEPKDB<object, JNDPMGELPNI>> NCBFHFABHGH(TRoot MGPJOGDJPHA, TSerializedAction EHPLPJFOHKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class EINFKNJDJCL
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface AKGGBJEONCP<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind FHOMFPILOBF(TSerializedAction PECHDAFMNOO);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OJKOFKPMEMP(TRoot MGPJOGDJPHA, TSerializedAction ENNGIICFMFD);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void JPDCDFAPMPH(TRoot MGPJOGDJPHA, TSerializedAction ENNGIICFMFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2B23F50", Offset = "0x2B22950", VA = "0x182B23F50")]
	internal static PHFJLKJHNDO<TActionKind, TSerializedAction, TRoot, TDeps> MMKGNMBHOIH<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, EDPKKHHEMKC<TSerializedAction, TRoot, TDeps>> CIHBNAPGOAM, TDeps JPDKLLDNBGD) where TDeps : AKGGBJEONCP<TActionKind, TSerializedAction, TRoot>
	{
		return default(PHFJLKJHNDO<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class HKANEPFAIKN<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, EDPKKHHEMKC<TSerializedAction, TRoot, TDeps>> HHILHPEEJFL;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x882870", Offset = "0x881270", VA = "0x180882870")]
	private HKANEPFAIKN(Dictionary<TActionKind, EDPKKHHEMKC<TSerializedAction, TRoot, TDeps>> CIHBNAPGOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3EEA4F0", Offset = "0x3EE8EF0", VA = "0x183EEA4F0")]
	public static HKANEPFAIKN<TActionKind, TSerializedAction, TRoot, TDeps> MMKGNMBHOIH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct FHHLCBPGANA<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, EINFKNJDJCL.AKGGBJEONCP<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class EJOHLHKJFAH<TPayload, TOk, TErr> : EDPKKHHEMKC<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, JNDPMGELPNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly MNIMHPNMKOA<TActionKind, TSerializedAction, TPayload> IOGILEDFIBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly GBCHPBLNCLE<TRoot, TPayload, TOk, TErr> COMHGEIAPLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool MGHAPJGAHJK;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x399AAD0", Offset = "0x39994D0", VA = "0x18399AAD0")]
		public EJOHLHKJFAH(MNIMHPNMKOA<TActionKind, TSerializedAction, TPayload> EMJLLGEJNKN, GBCHPBLNCLE<TRoot, TPayload, TOk, TErr> KGPLBLNHNLK, bool BBHAFDFMLFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3983800", Offset = "0x3982200", VA = "0x183983800", Slot = "4")]
		public Task<MOKFKOEPKDB<object, JNDPMGELPNI>> NCBFHFABHGH(TDeps JPDKLLDNBGD, TRoot MGPJOGDJPHA, TSerializedAction EHPLPJFOHKK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class OFAOCFLHNKC<TPayload, TOk, TErr> : EDPKKHHEMKC<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, JNDPMGELPNI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct EAJKKMCILEE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<MOKFKOEPKDB<object?, JNDPMGELPNI>> <>t__builder;

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
			public OFAOCFLHNKC<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private MOKFKOEPKDB<object?, JNDPMGELPNI> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<MOKFKOEPKDB<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x394AA00", Offset = "0x3949400", VA = "0x18394AA00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x394BF10", Offset = "0x394A910", VA = "0x18394BF10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly MNIMHPNMKOA<TActionKind, TSerializedAction, TPayload> IOGILEDFIBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly ILGIDEONDKJ<TRoot, TPayload, TOk, TErr> COMHGEIAPLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool MGHAPJGAHJK;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x399AAD0", Offset = "0x39994D0", VA = "0x18399AAD0")]
		public OFAOCFLHNKC(MNIMHPNMKOA<TActionKind, TSerializedAction, TPayload> EMJLLGEJNKN, ILGIDEONDKJ<TRoot, TPayload, TOk, TErr> KGPLBLNHNLK, bool BBHAFDFMLFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4824580", Offset = "0x4822F80", VA = "0x184824580", Slot = "4")]
		[AsyncStateMachine(typeof(OFAOCFLHNKC<, , >.EAJKKMCILEE))]
		public Task<MOKFKOEPKDB<object, JNDPMGELPNI>> NCBFHFABHGH(TDeps JPDKLLDNBGD, TRoot MGPJOGDJPHA, TSerializedAction EHPLPJFOHKK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly HKANEPFAIKN<TActionKind, TSerializedAction, TRoot, TDeps> LHPOENJKDLD;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xACCA10", Offset = "0xACB410", VA = "0x180ACCA10")]
	private FHHLCBPGANA(HKANEPFAIKN<TActionKind, TSerializedAction, TRoot, TDeps> OIGMDCDEKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3D4C810", Offset = "0x3D4B210", VA = "0x183D4C810")]
	public static FHHLCBPGANA<TActionKind, TSerializedAction, TRoot, TDeps> MMKGNMBHOIH()
	{
		return default(FHHLCBPGANA<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2BCCEB0", Offset = "0x2BCB8B0", VA = "0x182BCCEB0")]
	public FHHLCBPGANA<TActionKind, TSerializedAction, TRoot, TDeps> KLHBPDFGIPE<TPayload, TOk, TErr>(TActionKind DLCNFDMDJBL, MNIMHPNMKOA<TActionKind, TSerializedAction, TPayload> EMJLLGEJNKN, GBCHPBLNCLE<TRoot, TPayload, TOk, TErr> KGPLBLNHNLK, bool BBHAFDFMLFI = true) where TPayload : notnull where TOk : notnull where TErr : notnull, JNDPMGELPNI
	{
		return default(FHHLCBPGANA<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2BCCEB0", Offset = "0x2BCB8B0", VA = "0x182BCCEB0")]
	public FHHLCBPGANA<TActionKind, TSerializedAction, TRoot, TDeps> CCGLPOCAAJB<TPayload, TOk, TErr>(TActionKind DLCNFDMDJBL, MNIMHPNMKOA<TActionKind, TSerializedAction, TPayload> EMJLLGEJNKN, ILGIDEONDKJ<TRoot, TPayload, TOk, TErr> KGPLBLNHNLK, bool BBHAFDFMLFI = true) where TPayload : notnull where TOk : notnull where TErr : notnull, JNDPMGELPNI
	{
		return default(FHHLCBPGANA<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3D4C750", Offset = "0x3D4B150", VA = "0x183D4C750")]
	public PHFJLKJHNDO<TActionKind, TSerializedAction, TRoot, TDeps> JNJBOFHMEBM(TDeps JPDKLLDNBGD)
	{
		return default(PHFJLKJHNDO<TActionKind, TSerializedAction, TRoot, TDeps>);
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
