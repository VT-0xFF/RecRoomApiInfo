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
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x22196A0", Offset = "0x22188A0", VA = "0x1822196A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C0750", Offset = "0x8BF950", VA = "0x1808C0750")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C0790", Offset = "0x8BF990", VA = "0x1808C0790")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate NOJOABDLLEK<TActionKind, TPayload> HJGFFCGHCGB<TActionKind, TSerializedAction, TPayload>(TSerializedAction OIBOLKBHHPO);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface CAEFDOFEKIB<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KJEOKHCIBGM<object, IJNOPJPLCIM>> BBMBAHICDII(TDeps LJHLMAFOMCA, TRoot LPLEFLJFGNH, TSerializedAction OIBOLKBHHPO);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class JOKBIOOOIDI<TActionKind, TSerializedAction, TRoot, TDeps> : GDNNKDPAIAP where TDeps : LOLLCAOFNBL.GOCGCEFLNLE<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps LPKKIADABBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction BBFDABLLBNP;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x43BDA90", Offset = "0x43BCC90", VA = "0x1843BDA90")]
	public JOKBIOOOIDI([In] TDeps LJHLMAFOMCA, [In] TSerializedAction OIBOLKBHHPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x43BD870", Offset = "0x43BCA70", VA = "0x1843BD870", Slot = "7")]
	public override string PBDEAEJPOGL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct NOJOABDLLEK<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind PNOMPGEEHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload AEAPJABDPIP;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4868A30", Offset = "0x4867C30", VA = "0x184868A30")]
	internal NOJOABDLLEK(TActionKind ODLAINJCFFK, [In] TPayload EGCKKGGNFOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class ANHJICCAPDB
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x352D9B0", Offset = "0x352CBB0", VA = "0x18352D9B0")]
	public static NOJOABDLLEK<TActionKind, TPayload> MIFIOLMMIDE<TActionKind, TPayload>([In] TActionKind ODLAINJCFFK, [In] TPayload EGCKKGGNFOO)
	{
		return default(NOJOABDLLEK<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<KJEOKHCIBGM<TOk, TErr>> CPDADLOKKCH<TRoot, TPayload, TOk, TErr>(TRoot LPLEFLJFGNH, TPayload EGCKKGGNFOO);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate KJEOKHCIBGM<TOk, TErr> MIKKMDJCJNJ<TRoot, TPayload, TOk, TErr>(TRoot LPLEFLJFGNH, [In] TPayload EGCKKGGNFOO);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct BBLFJNEINJN<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : LOLLCAOFNBL.GOCGCEFLNLE<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct ABILAFMIENE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<KJEOKHCIBGM<object, IJNOPJPLCIM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public BBLFJNEINJN<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<KJEOKHCIBGM<object, IJNOPJPLCIM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3F00B60", Offset = "0x3EFFD60", VA = "0x183F00B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3F00FE0", Offset = "0x3F001E0", VA = "0x183F00FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, CAEFDOFEKIB<TSerializedAction, TRoot, TDeps>> JGNHFHHNJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps LPKKIADABBC;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xD62DE0", Offset = "0xD61FE0", VA = "0x180D62DE0")]
	internal BBLFJNEINJN(Dictionary<TActionKind, CAEFDOFEKIB<TSerializedAction, TRoot, TDeps>> KAMOHEADCOJ, TDeps LJHLMAFOMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x51C0170", Offset = "0x51BF370", VA = "0x1851C0170")]
	[AsyncStateMachine(typeof(BBLFJNEINJN<, , , >.ABILAFMIENE))]
	public Task<KJEOKHCIBGM<object, IJNOPJPLCIM>> BBMBAHICDII(TRoot LPLEFLJFGNH, TSerializedAction OIBOLKBHHPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class LOLLCAOFNBL
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface GOCGCEFLNLE<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind GBJFLKFEJMH(TSerializedAction AEFKHDNCNFD);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BPHHFDELPFG(TRoot LPLEFLJFGNH, TSerializedAction ECFGAICLGCA);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void COMIKNCFAGE(TRoot LPLEFLJFGNH, TSerializedAction ECFGAICLGCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2DF9F70", Offset = "0x2DF9170", VA = "0x182DF9F70")]
	internal static BBLFJNEINJN<TActionKind, TSerializedAction, TRoot, TDeps> MIFIOLMMIDE<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, CAEFDOFEKIB<TSerializedAction, TRoot, TDeps>> KAMOHEADCOJ, TDeps LJHLMAFOMCA) where TDeps : GOCGCEFLNLE<TActionKind, TSerializedAction, TRoot>
	{
		return default(BBLFJNEINJN<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class IJHFEEOLFIL<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, CAEFDOFEKIB<TSerializedAction, TRoot, TDeps>> NCLLPNDBDPE;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x89D490", Offset = "0x89C690", VA = "0x18089D490")]
	private IJHFEEOLFIL(Dictionary<TActionKind, CAEFDOFEKIB<TSerializedAction, TRoot, TDeps>> KAMOHEADCOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x41774E0", Offset = "0x41766E0", VA = "0x1841774E0")]
	public static IJHFEEOLFIL<TActionKind, TSerializedAction, TRoot, TDeps> MIFIOLMMIDE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct JIPBALMMOGA<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, LOLLCAOFNBL.GOCGCEFLNLE<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class OACKHNLCFDB<TPayload, TOk, TErr> : CAEFDOFEKIB<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, IJNOPJPLCIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly HJGFFCGHCGB<TActionKind, TSerializedAction, TPayload> CKJFNEBFLAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly MIKKMDJCJNJ<TRoot, TPayload, TOk, TErr> OMOFKAMACAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool CBLEOHFNEAE;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x47CA190", Offset = "0x47C9390", VA = "0x1847CA190")]
		public OACKHNLCFDB(HJGFFCGHCGB<TActionKind, TSerializedAction, TPayload> GOHOPPGPFJK, MIKKMDJCJNJ<TRoot, TPayload, TOk, TErr> MJAJINCIECB, bool GFKOAKNNKON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x494A3D0", Offset = "0x49495D0", VA = "0x18494A3D0", Slot = "4")]
		public Task<KJEOKHCIBGM<object, IJNOPJPLCIM>> BBMBAHICDII(TDeps LJHLMAFOMCA, TRoot LPLEFLJFGNH, TSerializedAction OIBOLKBHHPO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class MOADLCLPEGL<TPayload, TOk, TErr> : CAEFDOFEKIB<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, IJNOPJPLCIM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct DNBECGOGCAJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<KJEOKHCIBGM<object?, IJNOPJPLCIM>> <>t__builder;

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
			public MOADLCLPEGL<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private KJEOKHCIBGM<object?, IJNOPJPLCIM> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<KJEOKHCIBGM<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5B42BA0", Offset = "0x5B41DA0", VA = "0x185B42BA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5B431B0", Offset = "0x5B423B0", VA = "0x185B431B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly HJGFFCGHCGB<TActionKind, TSerializedAction, TPayload> CKJFNEBFLAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly CPDADLOKKCH<TRoot, TPayload, TOk, TErr> OMOFKAMACAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool CBLEOHFNEAE;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x47CA190", Offset = "0x47C9390", VA = "0x1847CA190")]
		public MOADLCLPEGL(HJGFFCGHCGB<TActionKind, TSerializedAction, TPayload> GOHOPPGPFJK, CPDADLOKKCH<TRoot, TPayload, TOk, TErr> MJAJINCIECB, bool GFKOAKNNKON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x47CA040", Offset = "0x47C9240", VA = "0x1847CA040", Slot = "4")]
		[AsyncStateMachine(typeof(MOADLCLPEGL<, , >.DNBECGOGCAJ))]
		public Task<KJEOKHCIBGM<object, IJNOPJPLCIM>> BBMBAHICDII(TDeps LJHLMAFOMCA, TRoot LPLEFLJFGNH, TSerializedAction OIBOLKBHHPO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly IJHFEEOLFIL<TActionKind, TSerializedAction, TRoot, TDeps> DIFBOAKKIII;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xBD6E30", Offset = "0xBD6030", VA = "0x180BD6E30")]
	private JIPBALMMOGA(IJHFEEOLFIL<TActionKind, TSerializedAction, TRoot, TDeps> LJIEGDEDOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4361CA0", Offset = "0x4360EA0", VA = "0x184361CA0")]
	public static JIPBALMMOGA<TActionKind, TSerializedAction, TRoot, TDeps> MIFIOLMMIDE()
	{
		return default(JIPBALMMOGA<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3188050", Offset = "0x3187250", VA = "0x183188050")]
	public JIPBALMMOGA<TActionKind, TSerializedAction, TRoot, TDeps> JEFOJLPLFGG<TPayload, TOk, TErr>(TActionKind ODLAINJCFFK, HJGFFCGHCGB<TActionKind, TSerializedAction, TPayload> GOHOPPGPFJK, MIKKMDJCJNJ<TRoot, TPayload, TOk, TErr> MJAJINCIECB, bool GFKOAKNNKON = true) where TPayload : notnull where TOk : notnull where TErr : notnull, IJNOPJPLCIM
	{
		return default(JIPBALMMOGA<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3188050", Offset = "0x3187250", VA = "0x183188050")]
	public JIPBALMMOGA<TActionKind, TSerializedAction, TRoot, TDeps> CALJAEHLONK<TPayload, TOk, TErr>(TActionKind ODLAINJCFFK, HJGFFCGHCGB<TActionKind, TSerializedAction, TPayload> GOHOPPGPFJK, CPDADLOKKCH<TRoot, TPayload, TOk, TErr> MJAJINCIECB, bool GFKOAKNNKON = true) where TPayload : notnull where TOk : notnull where TErr : notnull, IJNOPJPLCIM
	{
		return default(JIPBALMMOGA<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4361BE0", Offset = "0x4360DE0", VA = "0x184361BE0")]
	public BBLFJNEINJN<TActionKind, TSerializedAction, TRoot, TDeps> ECFIGNEHKMP(TDeps LJHLMAFOMCA)
	{
		return default(BBLFJNEINJN<TActionKind, TSerializedAction, TRoot, TDeps>);
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
