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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
		[Cpp2IlInjected.Address(RVA = "0x2721260", Offset = "0x2720660", VA = "0x182721260")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9F5340", Offset = "0x9F4740", VA = "0x1809F5340")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F5380", Offset = "0x9F4780", VA = "0x1809F5380")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate AAGFGDLMNJI<TActionKind, TPayload> DCBJBMOEKFM<TActionKind, TSerializedAction, TPayload>(TSerializedAction CEGHFJHKELG);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface LJNPPAKAEPK<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BECHBBIPIFM<object, FFKOEKDBPON>> HALFAMCMEEJ(TDeps BGLHIFBEGOD, TRoot DGFFJNKGDJD, TSerializedAction CEGHFJHKELG);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class INJDIBDLHIL<TActionKind, TSerializedAction, TRoot, TDeps> : BCMJKIOOIBO where TDeps : DFEACKPIPPA.GIGBFNDFAEE<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps DGDPNOACCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction CGPJCGJPMFH;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4A77500", Offset = "0x4A76900", VA = "0x184A77500")]
	public INJDIBDLHIL([In] TDeps BGLHIFBEGOD, [In] TSerializedAction CEGHFJHKELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4A77430", Offset = "0x4A76830", VA = "0x184A77430", Slot = "7")]
	public override string CPMOFLNCDEP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct AAGFGDLMNJI<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind KEOLCLOFDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload JPGPOFIPKJJ;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x48685B0", Offset = "0x48679B0", VA = "0x1848685B0")]
	internal AAGFGDLMNJI(TActionKind KHAFNLACGAD, [In] TPayload CFFKMBGFAOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class FIJBPEPPCLI
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x368F280", Offset = "0x368E680", VA = "0x18368F280")]
	public static AAGFGDLMNJI<TActionKind, TPayload> FABCCGGAHMJ<TActionKind, TPayload>([In] TActionKind KHAFNLACGAD, [In] TPayload CFFKMBGFAOG)
	{
		return default(AAGFGDLMNJI<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<BECHBBIPIFM<TOk, TErr>> MIKJBMFDAAG<TRoot, TPayload, TOk, TErr>(TRoot DGFFJNKGDJD, TPayload CFFKMBGFAOG);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate BECHBBIPIFM<TOk, TErr> MCOOHBMCBKG<TRoot, TPayload, TOk, TErr>(TRoot DGFFJNKGDJD, [In] TPayload CFFKMBGFAOG);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct IGMDGJHNAKG<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : DFEACKPIPPA.GIGBFNDFAEE<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct BNIJMNLHDIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<BECHBBIPIFM<object?, FFKOEKDBPON>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IGMDGJHNAKG<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<BECHBBIPIFM<object, FFKOEKDBPON>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6083460", Offset = "0x6082860", VA = "0x186083460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6083970", Offset = "0x6082D70", VA = "0x186083970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, LJNPPAKAEPK<TSerializedAction, TRoot, TDeps>> CLFCFKLAFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps DGDPNOACCCN;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA813A0", Offset = "0xA807A0", VA = "0x180A813A0")]
	internal IGMDGJHNAKG(Dictionary<TActionKind, LJNPPAKAEPK<TSerializedAction, TRoot, TDeps>> OBHEMNLKPCA, TDeps BGLHIFBEGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4A5A780", Offset = "0x4A59B80", VA = "0x184A5A780")]
	[AsyncStateMachine(typeof(IGMDGJHNAKG<, , , >.BNIJMNLHDIO))]
	public Task<BECHBBIPIFM<object, FFKOEKDBPON>> HALFAMCMEEJ(TRoot DGFFJNKGDJD, TSerializedAction CEGHFJHKELG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class DFEACKPIPPA
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface GIGBFNDFAEE<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind PELEDOLKKGF(TSerializedAction KBBJDOAJMAF);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NJFKMBLNDOH(TRoot DGFFJNKGDJD, TSerializedAction PDHMHKIHKPF);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void HNLDCCCGMII(TRoot DGFFJNKGDJD, TSerializedAction PDHMHKIHKPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x34FD060", Offset = "0x34FC460", VA = "0x1834FD060")]
	internal static IGMDGJHNAKG<TActionKind, TSerializedAction, TRoot, TDeps> FABCCGGAHMJ<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, LJNPPAKAEPK<TSerializedAction, TRoot, TDeps>> OBHEMNLKPCA, TDeps BGLHIFBEGOD) where TDeps : GIGBFNDFAEE<TActionKind, TSerializedAction, TRoot>
	{
		return default(IGMDGJHNAKG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class HCEFJEMGIIH<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, LJNPPAKAEPK<TSerializedAction, TRoot, TDeps>> CJOBOLKOGOE;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x9D4E40", Offset = "0x9D4240", VA = "0x1809D4E40")]
	private HCEFJEMGIIH(Dictionary<TActionKind, LJNPPAKAEPK<TSerializedAction, TRoot, TDeps>> OBHEMNLKPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4910050", Offset = "0x490F450", VA = "0x184910050")]
	public static HCEFJEMGIIH<TActionKind, TSerializedAction, TRoot, TDeps> FABCCGGAHMJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct JDHPDAPAGED<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, DFEACKPIPPA.GIGBFNDFAEE<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class NCLIBBABBIK<TPayload, TOk, TErr> : LJNPPAKAEPK<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, FFKOEKDBPON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly DCBJBMOEKFM<TActionKind, TSerializedAction, TPayload> OLCBAKHGMDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly MCOOHBMCBKG<TRoot, TPayload, TOk, TErr> LEPNHLHPAFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool OOCLGCPNMGB;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x190CA30", Offset = "0x190BE30", VA = "0x18190CA30")]
		public NCLIBBABBIK(DCBJBMOEKFM<TActionKind, TSerializedAction, TPayload> NBLFOINBAHI, MCOOHBMCBKG<TRoot, TPayload, TOk, TErr> ONFEOACCCFJ, bool EGNCJIDNFKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x515AAB0", Offset = "0x5159EB0", VA = "0x18515AAB0", Slot = "4")]
		public Task<BECHBBIPIFM<object, FFKOEKDBPON>> HALFAMCMEEJ(TDeps BGLHIFBEGOD, TRoot DGFFJNKGDJD, TSerializedAction CEGHFJHKELG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class PKPCHAHPPOP<TPayload, TOk, TErr> : LJNPPAKAEPK<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, FFKOEKDBPON
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct BBAJLNBEODL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<BECHBBIPIFM<object?, FFKOEKDBPON>> <>t__builder;

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
			public PKPCHAHPPOP<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private BECHBBIPIFM<object?, FFKOEKDBPON> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<BECHBBIPIFM<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5E8FDF0", Offset = "0x5E8F1F0", VA = "0x185E8FDF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5E91200", Offset = "0x5E90600", VA = "0x185E91200", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly DCBJBMOEKFM<TActionKind, TSerializedAction, TPayload> OLCBAKHGMDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly MIKJBMFDAAG<TRoot, TPayload, TOk, TErr> LEPNHLHPAFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool OOCLGCPNMGB;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x190CA30", Offset = "0x190BE30", VA = "0x18190CA30")]
		public PKPCHAHPPOP(DCBJBMOEKFM<TActionKind, TSerializedAction, TPayload> NBLFOINBAHI, MIKJBMFDAAG<TRoot, TPayload, TOk, TErr> ONFEOACCCFJ, bool EGNCJIDNFKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x54AD0E0", Offset = "0x54AC4E0", VA = "0x1854AD0E0", Slot = "4")]
		[AsyncStateMachine(typeof(PKPCHAHPPOP<, , >.BBAJLNBEODL))]
		public Task<BECHBBIPIFM<object, FFKOEKDBPON>> HALFAMCMEEJ(TDeps BGLHIFBEGOD, TRoot DGFFJNKGDJD, TSerializedAction CEGHFJHKELG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly HCEFJEMGIIH<TActionKind, TSerializedAction, TRoot, TDeps> JJMDGJOCOGL;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xCE6E00", Offset = "0xCE6200", VA = "0x180CE6E00")]
	private JDHPDAPAGED(HCEFJEMGIIH<TActionKind, TSerializedAction, TRoot, TDeps> AOFGGGKINCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4C86A60", Offset = "0x4C85E60", VA = "0x184C86A60")]
	public static JDHPDAPAGED<TActionKind, TSerializedAction, TRoot, TDeps> FABCCGGAHMJ()
	{
		return default(JDHPDAPAGED<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3AE3E30", Offset = "0x3AE3230", VA = "0x183AE3E30")]
	public JDHPDAPAGED<TActionKind, TSerializedAction, TRoot, TDeps> BBHKFMOIMOD<TPayload, TOk, TErr>(TActionKind KHAFNLACGAD, DCBJBMOEKFM<TActionKind, TSerializedAction, TPayload> NBLFOINBAHI, MCOOHBMCBKG<TRoot, TPayload, TOk, TErr> ONFEOACCCFJ, bool EGNCJIDNFKD = true) where TPayload : notnull where TOk : notnull where TErr : notnull, FFKOEKDBPON
	{
		return default(JDHPDAPAGED<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3AE3E30", Offset = "0x3AE3230", VA = "0x183AE3E30")]
	public JDHPDAPAGED<TActionKind, TSerializedAction, TRoot, TDeps> IGCFLKNEIDP<TPayload, TOk, TErr>(TActionKind KHAFNLACGAD, DCBJBMOEKFM<TActionKind, TSerializedAction, TPayload> NBLFOINBAHI, MIKJBMFDAAG<TRoot, TPayload, TOk, TErr> ONFEOACCCFJ, bool EGNCJIDNFKD = true) where TPayload : notnull where TOk : notnull where TErr : notnull, FFKOEKDBPON
	{
		return default(JDHPDAPAGED<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4C86B00", Offset = "0x4C85F00", VA = "0x184C86B00")]
	public IGMDGJHNAKG<TActionKind, TSerializedAction, TRoot, TDeps> JKFMEKJLDPJ(TDeps BGLHIFBEGOD)
	{
		return default(IGMDGJHNAKG<TActionKind, TSerializedAction, TRoot, TDeps>);
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
