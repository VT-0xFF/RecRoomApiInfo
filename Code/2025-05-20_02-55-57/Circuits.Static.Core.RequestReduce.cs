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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x27E4830", Offset = "0x27E3A30", VA = "0x1827E4830")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B770", Offset = "0xA1A970", VA = "0x180A1B770")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B7B0", Offset = "0xA1A9B0", VA = "0x180A1B7B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate FLDEEDHJIKG<TActionKind, TPayload> LPDMOJIFDAF<TActionKind, TSerializedAction, TPayload>(TSerializedAction LKCIICBIAHH);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface GCEDKFHGNCG<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LOAMJJJEMNF<object, PLLHOMFPAAM>> KHFEAELDEDF(TDeps POLANHDJCNH, TRoot FHPKLENNKKO, TSerializedAction LKCIICBIAHH);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class BGGHHDEOJNE<TActionKind, TSerializedAction, TRoot, TDeps> : BHGOBKJBFOA where TDeps : BFFLPJPCMEL.LIIAMKACFFM<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps MPDDJFAHINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction KCCGKAMPMFD;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B6D0", Offset = "0x5E8A8D0", VA = "0x185E8B6D0")]
	public BGGHHDEOJNE([In] TDeps POLANHDJCNH, [In] TSerializedAction LKCIICBIAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B510", Offset = "0x5E8A710", VA = "0x185E8B510", Slot = "7")]
	public override string JOOGKGIFDEP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct FLDEEDHJIKG<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind PMOLLKNIAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload EDHFPJIJLND;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x49ADCA0", Offset = "0x49ACEA0", VA = "0x1849ADCA0")]
	internal FLDEEDHJIKG(TActionKind FLBFIKIAFGF, [In] TPayload MGEJNDCFBJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class COPCPCLJIKB
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3629D60", Offset = "0x3628F60", VA = "0x183629D60")]
	public static FLDEEDHJIKG<TActionKind, TPayload> OIKMHICCLEP<TActionKind, TPayload>([In] TActionKind FLBFIKIAFGF, [In] TPayload MGEJNDCFBJA)
	{
		return default(FLDEEDHJIKG<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<LOAMJJJEMNF<TOk, TErr>> DIHBDBFJOLI<TRoot, TPayload, TOk, TErr>(TRoot FHPKLENNKKO, TPayload MGEJNDCFBJA);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate LOAMJJJEMNF<TOk, TErr> MJLJMPKMAHO<TRoot, TPayload, TOk, TErr>(TRoot FHPKLENNKKO, [In] TPayload MGEJNDCFBJA);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct PIDEKIBKJPO<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : BFFLPJPCMEL.LIIAMKACFFM<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct AJAOEBALHPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<LOAMJJJEMNF<object?, PLLHOMFPAAM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public PIDEKIBKJPO<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<LOAMJJJEMNF<object, PLLHOMFPAAM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4B5C880", Offset = "0x4B5BA80", VA = "0x184B5C880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4B5CD70", Offset = "0x4B5BF70", VA = "0x184B5CD70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, GCEDKFHGNCG<TSerializedAction, TRoot, TDeps>> GOJLGPLEAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps MPDDJFAHINH;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xAE1FD0", Offset = "0xAE11D0", VA = "0x180AE1FD0")]
	internal PIDEKIBKJPO(Dictionary<TActionKind, GCEDKFHGNCG<TSerializedAction, TRoot, TDeps>> JADFEDDIKIC, TDeps POLANHDJCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x562A800", Offset = "0x5629A00", VA = "0x18562A800")]
	[AsyncStateMachine(typeof(PIDEKIBKJPO<, , , >.AJAOEBALHPF))]
	public Task<LOAMJJJEMNF<object, PLLHOMFPAAM>> KHFEAELDEDF(TRoot FHPKLENNKKO, TSerializedAction LKCIICBIAHH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class BFFLPJPCMEL
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface LIIAMKACFFM<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind PEACJLNAKNH(TSerializedAction CEENCLMGJAM);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OGGCHBODIDN(TRoot FHPKLENNKKO, TSerializedAction HDKINMMJOHF);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LOPHAEPMGAD(TRoot FHPKLENNKKO, TSerializedAction HDKINMMJOHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x35B55A0", Offset = "0x35B47A0", VA = "0x1835B55A0")]
	internal static PIDEKIBKJPO<TActionKind, TSerializedAction, TRoot, TDeps> OIKMHICCLEP<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, GCEDKFHGNCG<TSerializedAction, TRoot, TDeps>> JADFEDDIKIC, TDeps POLANHDJCNH) where TDeps : LIIAMKACFFM<TActionKind, TSerializedAction, TRoot>
	{
		return default(PIDEKIBKJPO<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class BGPJPCNANOF<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, GCEDKFHGNCG<TSerializedAction, TRoot, TDeps>> FOPPEOJBCFH;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	private BGPJPCNANOF(Dictionary<TActionKind, GCEDKFHGNCG<TSerializedAction, TRoot, TDeps>> JADFEDDIKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5E8BC50", Offset = "0x5E8AE50", VA = "0x185E8BC50")]
	public static BGPJPCNANOF<TActionKind, TSerializedAction, TRoot, TDeps> OIKMHICCLEP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct DHOEAEODOAI<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, BFFLPJPCMEL.LIIAMKACFFM<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class JKBPNFFJEOH<TPayload, TOk, TErr> : GCEDKFHGNCG<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, PLLHOMFPAAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LPDMOJIFDAF<TActionKind, TSerializedAction, TPayload> EBAGJAPELID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly MJLJMPKMAHO<TRoot, TPayload, TOk, TErr> JAJNLKIJPLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool KIDABMDKLIF;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x19BF950", Offset = "0x19BEB50", VA = "0x1819BF950")]
		public JKBPNFFJEOH(LPDMOJIFDAF<TActionKind, TSerializedAction, TPayload> AALIGJFLPKI, MJLJMPKMAHO<TRoot, TPayload, TOk, TErr> NNDGPELEDDI, bool HOPIPMICPLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4ECBC40", Offset = "0x4ECAE40", VA = "0x184ECBC40", Slot = "4")]
		public Task<LOAMJJJEMNF<object, PLLHOMFPAAM>> KHFEAELDEDF(TDeps POLANHDJCNH, TRoot FHPKLENNKKO, TSerializedAction LKCIICBIAHH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class KOLNEGOLGNM<TPayload, TOk, TErr> : GCEDKFHGNCG<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, PLLHOMFPAAM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct NPIBHPHPNML : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<LOAMJJJEMNF<object?, PLLHOMFPAAM>> <>t__builder;

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
			public KOLNEGOLGNM<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private LOAMJJJEMNF<object?, PLLHOMFPAAM> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<LOAMJJJEMNF<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x53C2AF0", Offset = "0x53C1CF0", VA = "0x1853C2AF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x53C4510", Offset = "0x53C3710", VA = "0x1853C4510", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly LPDMOJIFDAF<TActionKind, TSerializedAction, TPayload> EBAGJAPELID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly DIHBDBFJOLI<TRoot, TPayload, TOk, TErr> JAJNLKIJPLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool KIDABMDKLIF;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x19BF950", Offset = "0x19BEB50", VA = "0x1819BF950")]
		public KOLNEGOLGNM(LPDMOJIFDAF<TActionKind, TSerializedAction, TPayload> AALIGJFLPKI, DIHBDBFJOLI<TRoot, TPayload, TOk, TErr> NNDGPELEDDI, bool HOPIPMICPLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5025910", Offset = "0x5024B10", VA = "0x185025910", Slot = "4")]
		[AsyncStateMachine(typeof(KOLNEGOLGNM<, , >.NPIBHPHPNML))]
		public Task<LOAMJJJEMNF<object, PLLHOMFPAAM>> KHFEAELDEDF(TDeps POLANHDJCNH, TRoot FHPKLENNKKO, TSerializedAction LKCIICBIAHH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly BGPJPCNANOF<TActionKind, TSerializedAction, TRoot, TDeps> PLFNPOBLMKA;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xD42160", Offset = "0xD41360", VA = "0x180D42160")]
	private DHOEAEODOAI(BGPJPCNANOF<TActionKind, TSerializedAction, TRoot, TDeps> DHAOEHNLNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6A25040", Offset = "0x6A24240", VA = "0x186A25040")]
	public static DHOEAEODOAI<TActionKind, TSerializedAction, TRoot, TDeps> OIKMHICCLEP()
	{
		return default(DHOEAEODOAI<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3CEA1D0", Offset = "0x3CE93D0", VA = "0x183CEA1D0")]
	public DHOEAEODOAI<TActionKind, TSerializedAction, TRoot, TDeps> ALKFAANPPHL<TPayload, TOk, TErr>(TActionKind FLBFIKIAFGF, LPDMOJIFDAF<TActionKind, TSerializedAction, TPayload> AALIGJFLPKI, MJLJMPKMAHO<TRoot, TPayload, TOk, TErr> NNDGPELEDDI, bool HOPIPMICPLL = true) where TPayload : notnull where TOk : notnull where TErr : notnull, PLLHOMFPAAM
	{
		return default(DHOEAEODOAI<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3CEA1D0", Offset = "0x3CE93D0", VA = "0x183CEA1D0")]
	public DHOEAEODOAI<TActionKind, TSerializedAction, TRoot, TDeps> MFAPCJDGOEG<TPayload, TOk, TErr>(TActionKind FLBFIKIAFGF, LPDMOJIFDAF<TActionKind, TSerializedAction, TPayload> AALIGJFLPKI, DIHBDBFJOLI<TRoot, TPayload, TOk, TErr> NNDGPELEDDI, bool HOPIPMICPLL = true) where TPayload : notnull where TOk : notnull where TErr : notnull, PLLHOMFPAAM
	{
		return default(DHOEAEODOAI<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6A24F80", Offset = "0x6A24180", VA = "0x186A24F80")]
	public PIDEKIBKJPO<TActionKind, TSerializedAction, TRoot, TDeps> DJEBEGAHKBP(TDeps POLANHDJCNH)
	{
		return default(PIDEKIBKJPO<TActionKind, TSerializedAction, TRoot, TDeps>);
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
