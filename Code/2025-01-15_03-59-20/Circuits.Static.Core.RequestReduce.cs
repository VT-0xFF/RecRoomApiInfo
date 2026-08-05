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
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x234D530", Offset = "0x234C930", VA = "0x18234D530")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F1670", Offset = "0x8F0A70", VA = "0x1808F1670")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F16B0", Offset = "0x8F0AB0", VA = "0x1808F16B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate KGAAMPHMJKE<TActionKind, TPayload> LJBAHKBLANE<TActionKind, TSerializedAction, TPayload>(TSerializedAction NKEIDGPHBGA);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface MDNDCFPPELA<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ABNAGONECLM<object, IAAGGMEHHFI>> OFALIHCNEIG(TDeps CFAPAOIIPAA, TRoot NIMLNKDMKHI, TSerializedAction NKEIDGPHBGA);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class JECPGEOLOLP<TActionKind, TSerializedAction, TRoot, TDeps> : JMMAFLLBCOF where TDeps : IEOOEIMIMBE.BMBJHFCAIBG<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps OIKLGOFBDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction ENKLHKGAJGI;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x457CC30", Offset = "0x457C030", VA = "0x18457CC30")]
	public JECPGEOLOLP([In] TDeps CFAPAOIIPAA, [In] TSerializedAction NKEIDGPHBGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x457CB00", Offset = "0x457BF00", VA = "0x18457CB00", Slot = "7")]
	public override string MMDDBBBPGKC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct KGAAMPHMJKE<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind FBMPGIIKLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload CMKFDMGAMFP;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x46661F0", Offset = "0x46655F0", VA = "0x1846661F0")]
	internal KGAAMPHMJKE(TActionKind BICDPMBDAOC, [In] TPayload PBJNGGAILNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LLBLNMLJCCH
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x311B7B0", Offset = "0x311ABB0", VA = "0x18311B7B0")]
	public static KGAAMPHMJKE<TActionKind, TPayload> ODOFIFAGLAJ<TActionKind, TPayload>([In] TActionKind BICDPMBDAOC, [In] TPayload PBJNGGAILNG)
	{
		return default(KGAAMPHMJKE<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<ABNAGONECLM<TOk, TErr>> PMPBPPOGEBI<TRoot, TPayload, TOk, TErr>(TRoot NIMLNKDMKHI, TPayload PBJNGGAILNG);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate ABNAGONECLM<TOk, TErr> MKBOLIDIJFL<TRoot, TPayload, TOk, TErr>(TRoot NIMLNKDMKHI, [In] TPayload PBJNGGAILNG);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct JIGOMCKFOAL<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : IEOOEIMIMBE.BMBJHFCAIBG<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PDMEPIHJEDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<ABNAGONECLM<object?, IAAGGMEHHFI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public JIGOMCKFOAL<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<ABNAGONECLM<object, IAAGGMEHHFI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4C5A510", Offset = "0x4C59910", VA = "0x184C5A510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4C5AEC0", Offset = "0x4C5A2C0", VA = "0x184C5AEC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, MDNDCFPPELA<TSerializedAction, TRoot, TDeps>> HGOBCALHCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps OIKLGOFBDMC;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xE8EEE0", Offset = "0xE8E2E0", VA = "0x180E8EEE0")]
	internal JIGOMCKFOAL(Dictionary<TActionKind, MDNDCFPPELA<TSerializedAction, TRoot, TDeps>> AHALNFPLNJJ, TDeps CFAPAOIIPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4585950", Offset = "0x4584D50", VA = "0x184585950")]
	[AsyncStateMachine(typeof(JIGOMCKFOAL<, , , >.PDMEPIHJEDJ))]
	public Task<ABNAGONECLM<object, IAAGGMEHHFI>> OFALIHCNEIG(TRoot NIMLNKDMKHI, TSerializedAction NKEIDGPHBGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class IEOOEIMIMBE
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface BMBJHFCAIBG<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind KOKKBADJNCP(TSerializedAction MPLBPEBNKFP);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IAAJINEHFAN(TRoot NIMLNKDMKHI, TSerializedAction OLHFOBIBHCJ);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KPMCIHEFICN(TRoot NIMLNKDMKHI, TSerializedAction OLHFOBIBHCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x306A3A0", Offset = "0x30697A0", VA = "0x18306A3A0")]
	internal static JIGOMCKFOAL<TActionKind, TSerializedAction, TRoot, TDeps> ODOFIFAGLAJ<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, MDNDCFPPELA<TSerializedAction, TRoot, TDeps>> AHALNFPLNJJ, TDeps CFAPAOIIPAA) where TDeps : BMBJHFCAIBG<TActionKind, TSerializedAction, TRoot>
	{
		return default(JIGOMCKFOAL<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class DGMPABADBPK<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, MDNDCFPPELA<TSerializedAction, TRoot, TDeps>> OEJNFGHLNHN;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8CADF0", Offset = "0x8CA1F0", VA = "0x1808CADF0")]
	private DGMPABADBPK(Dictionary<TActionKind, MDNDCFPPELA<TSerializedAction, TRoot, TDeps>> AHALNFPLNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B6B0", Offset = "0x5E6AAB0", VA = "0x185E6B6B0")]
	public static DGMPABADBPK<TActionKind, TSerializedAction, TRoot, TDeps> ODOFIFAGLAJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct HPGGHNPBFOM<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, IEOOEIMIMBE.BMBJHFCAIBG<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class BMKBHGBNIDA<TPayload, TOk, TErr> : MDNDCFPPELA<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, IAAGGMEHHFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LJBAHKBLANE<TActionKind, TSerializedAction, TPayload> IDCMCKFBEED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly MKBOLIDIJFL<TRoot, TPayload, TOk, TErr> HIMJLLAEPEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool EJLCLNHKGDG;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x419F1F0", Offset = "0x419E5F0", VA = "0x18419F1F0")]
		public BMKBHGBNIDA(LJBAHKBLANE<TActionKind, TSerializedAction, TPayload> HIFGLJMEFKI, MKBOLIDIJFL<TRoot, TPayload, TOk, TErr> FLLKDBMCFPL, bool IGNLBFPCAFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x53DFB00", Offset = "0x53DEF00", VA = "0x1853DFB00", Slot = "4")]
		public Task<ABNAGONECLM<object, IAAGGMEHHFI>> OFALIHCNEIG(TDeps CFAPAOIIPAA, TRoot NIMLNKDMKHI, TSerializedAction NKEIDGPHBGA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class GIOBJCLLNGB<TPayload, TOk, TErr> : MDNDCFPPELA<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, IAAGGMEHHFI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct JLKKFOLADKK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<ABNAGONECLM<object?, IAAGGMEHHFI>> <>t__builder;

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
			public GIOBJCLLNGB<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private ABNAGONECLM<object?, IAAGGMEHHFI> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<ABNAGONECLM<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4590D40", Offset = "0x4590140", VA = "0x184590D40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4592C80", Offset = "0x4592080", VA = "0x184592C80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly LJBAHKBLANE<TActionKind, TSerializedAction, TPayload> IDCMCKFBEED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly PMPBPPOGEBI<TRoot, TPayload, TOk, TErr> HIMJLLAEPEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool EJLCLNHKGDG;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x419F1F0", Offset = "0x419E5F0", VA = "0x18419F1F0")]
		public GIOBJCLLNGB(LJBAHKBLANE<TActionKind, TSerializedAction, TPayload> HIFGLJMEFKI, PMPBPPOGEBI<TRoot, TPayload, TOk, TErr> FLLKDBMCFPL, bool IGNLBFPCAFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x419E9B0", Offset = "0x419DDB0", VA = "0x18419E9B0", Slot = "4")]
		[AsyncStateMachine(typeof(GIOBJCLLNGB<, , >.JLKKFOLADKK))]
		public Task<ABNAGONECLM<object, IAAGGMEHHFI>> OFALIHCNEIG(TDeps CFAPAOIIPAA, TRoot NIMLNKDMKHI, TSerializedAction NKEIDGPHBGA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly DGMPABADBPK<TActionKind, TSerializedAction, TRoot, TDeps> OCPNIGJCMEA;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x96A9A0", Offset = "0x969DA0", VA = "0x18096A9A0")]
	private HPGGHNPBFOM(DGMPABADBPK<TActionKind, TSerializedAction, TRoot, TDeps> JGCOLLOOLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4276860", Offset = "0x4275C60", VA = "0x184276860")]
	public static HPGGHNPBFOM<TActionKind, TSerializedAction, TRoot, TDeps> ODOFIFAGLAJ()
	{
		return default(HPGGHNPBFOM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x31873E0", Offset = "0x31867E0", VA = "0x1831873E0")]
	public HPGGHNPBFOM<TActionKind, TSerializedAction, TRoot, TDeps> MKOONEHJAKE<TPayload, TOk, TErr>(TActionKind BICDPMBDAOC, LJBAHKBLANE<TActionKind, TSerializedAction, TPayload> HIFGLJMEFKI, MKBOLIDIJFL<TRoot, TPayload, TOk, TErr> FLLKDBMCFPL, bool IGNLBFPCAFJ = true) where TPayload : notnull where TOk : notnull where TErr : notnull, IAAGGMEHHFI
	{
		return default(HPGGHNPBFOM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x31873E0", Offset = "0x31867E0", VA = "0x1831873E0")]
	public HPGGHNPBFOM<TActionKind, TSerializedAction, TRoot, TDeps> LEGMAGFCBMH<TPayload, TOk, TErr>(TActionKind BICDPMBDAOC, LJBAHKBLANE<TActionKind, TSerializedAction, TPayload> HIFGLJMEFKI, PMPBPPOGEBI<TRoot, TPayload, TOk, TErr> FLLKDBMCFPL, bool IGNLBFPCAFJ = true) where TPayload : notnull where TOk : notnull where TErr : notnull, IAAGGMEHHFI
	{
		return default(HPGGHNPBFOM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x42767A0", Offset = "0x4275BA0", VA = "0x1842767A0")]
	public JIGOMCKFOAL<TActionKind, TSerializedAction, TRoot, TDeps> ACFPBEHFGAK(TDeps CFAPAOIIPAA)
	{
		return default(JIGOMCKFOAL<TActionKind, TSerializedAction, TRoot, TDeps>);
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
