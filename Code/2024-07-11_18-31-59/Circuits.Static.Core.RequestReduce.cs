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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87B0C0", VA = "0x18087C6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FDD240", Offset = "0x1FDBC40", VA = "0x181FDD240")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87D9C0", Offset = "0x87C3C0", VA = "0x18087D9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87DA00", Offset = "0x87C400", VA = "0x18087DA00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate OAINPMLGJPA<TActionKind, TPayload> LODNFCKKNEJ<TActionKind, TSerializedAction, TPayload>(TSerializedAction CHMLLBCHGFG);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface HLFNKHAHFNN<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CIKECDEKJAI<object, JPLAIBFIFBK>> BOHDCAOOIAI(TDeps HDLOJHGAFKF, TRoot GFFCILHEGII, TSerializedAction CHMLLBCHGFG);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class DOKBLHBEAOP<TActionKind, TSerializedAction, TRoot, TDeps> : DOBPMPCGNAB where TDeps : JMJAIJOJFFL.OOOLFHGFFGI<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps NMBACBFNMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction JDLCJEOGOPJ;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5778C20", Offset = "0x5777620", VA = "0x185778C20")]
	public DOKBLHBEAOP([In] TDeps HDLOJHGAFKF, [In] TSerializedAction CHMLLBCHGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5778B50", Offset = "0x5777550", VA = "0x185778B50", Slot = "7")]
	public override string AGNLMABPEGN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct OAINPMLGJPA<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind DIHDFGJPBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload PPFBACGMLII;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4603190", Offset = "0x4601B90", VA = "0x184603190")]
	internal OAINPMLGJPA(TActionKind FPKKAFNOOID, [In] TPayload MIJPDJDOIDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LKPKJJANMKO
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2C08E20", Offset = "0x2C07820", VA = "0x182C08E20")]
	public static OAINPMLGJPA<TActionKind, TPayload> FJAAFKPDAIA<TActionKind, TPayload>([In] TActionKind FPKKAFNOOID, [In] TPayload MIJPDJDOIDB)
	{
		return default(OAINPMLGJPA<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<CIKECDEKJAI<TOk, TErr>> ICLNCBDCEBF<TRoot, TPayload, TOk, TErr>(TRoot GFFCILHEGII, TPayload MIJPDJDOIDB);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate CIKECDEKJAI<TOk, TErr> MNJCJOLPFGM<TRoot, TPayload, TOk, TErr>(TRoot GFFCILHEGII, [In] TPayload MIJPDJDOIDB);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct GKEHAHJEGAM<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : JMJAIJOJFFL.OOOLFHGFFGI<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HHNOJGKBOEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<CIKECDEKJAI<object, JPLAIBFIFBK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public GKEHAHJEGAM<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<CIKECDEKJAI<object, JPLAIBFIFBK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3D16BF0", Offset = "0x3D155F0", VA = "0x183D16BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3D170D0", Offset = "0x3D15AD0", VA = "0x183D170D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, HLFNKHAHFNN<TSerializedAction, TRoot, TDeps>> OKCLPINGJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps NMBACBFNMGF;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xAB1600", Offset = "0xAB0000", VA = "0x180AB1600")]
	internal GKEHAHJEGAM(Dictionary<TActionKind, HLFNKHAHFNN<TSerializedAction, TRoot, TDeps>> MAJMAGGKNAN, TDeps HDLOJHGAFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3CC0B40", Offset = "0x3CBF540", VA = "0x183CC0B40")]
	[AsyncStateMachine(typeof(GKEHAHJEGAM<, , , >.HHNOJGKBOEJ))]
	public Task<CIKECDEKJAI<object, JPLAIBFIFBK>> BOHDCAOOIAI(TRoot GFFCILHEGII, TSerializedAction CHMLLBCHGFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class JMJAIJOJFFL
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface OOOLFHGFFGI<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind EKEDDDPCLPB(TSerializedAction HIKEOGPAJAF);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MFEBNAIKHDL(TRoot GFFCILHEGII, TSerializedAction ENGMCBPHJGL);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NBICLNPCDKA(TRoot GFFCILHEGII, TSerializedAction ENGMCBPHJGL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2995BF0", Offset = "0x29945F0", VA = "0x182995BF0")]
	internal static GKEHAHJEGAM<TActionKind, TSerializedAction, TRoot, TDeps> FJAAFKPDAIA<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, HLFNKHAHFNN<TSerializedAction, TRoot, TDeps>> MAJMAGGKNAN, TDeps HDLOJHGAFKF) where TDeps : OOOLFHGFFGI<TActionKind, TSerializedAction, TRoot>
	{
		return default(GKEHAHJEGAM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class EAHDAGDGPKK<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, HLFNKHAHFNN<TSerializedAction, TRoot, TDeps>> GPGPDKPEMAH;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x851BE0", VA = "0x1808531E0")]
	private EAHDAGDGPKK(Dictionary<TActionKind, HLFNKHAHFNN<TSerializedAction, TRoot, TDeps>> MAJMAGGKNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x37CEA30", Offset = "0x37CD430", VA = "0x1837CEA30")]
	public static EAHDAGDGPKK<TActionKind, TSerializedAction, TRoot, TDeps> FJAAFKPDAIA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct OKDNFLBHGEG<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, JMJAIJOJFFL.OOOLFHGFFGI<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class HNMBHHHJIIE<TPayload, TOk, TErr> : HLFNKHAHFNN<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, JPLAIBFIFBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LODNFCKKNEJ<TActionKind, TSerializedAction, TPayload> OFNBABAGNIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly MNJCJOLPFGM<TRoot, TPayload, TOk, TErr> NNMIGBKMDFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool KJNKPJOOICI;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3D40770", Offset = "0x3D3F170", VA = "0x183D40770")]
		public HNMBHHHJIIE(LODNFCKKNEJ<TActionKind, TSerializedAction, TPayload> APFDEGILJOH, MNJCJOLPFGM<TRoot, TPayload, TOk, TErr> FLPGFGKFFPB, bool NGNFOAPDBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3D3F9E0", Offset = "0x3D3E3E0", VA = "0x183D3F9E0", Slot = "4")]
		public Task<CIKECDEKJAI<object, JPLAIBFIFBK>> BOHDCAOOIAI(TDeps HDLOJHGAFKF, TRoot GFFCILHEGII, TSerializedAction CHMLLBCHGFG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class LOEJDCMMJDM<TPayload, TOk, TErr> : HLFNKHAHFNN<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, JPLAIBFIFBK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct ECNBNBFJMCD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<CIKECDEKJAI<object?, JPLAIBFIFBK>> <>t__builder;

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
			public LOEJDCMMJDM<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private CIKECDEKJAI<object?, JPLAIBFIFBK> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<CIKECDEKJAI<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x37D4740", Offset = "0x37D3140", VA = "0x1837D4740", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x37D5120", Offset = "0x37D3B20", VA = "0x1837D5120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly LODNFCKKNEJ<TActionKind, TSerializedAction, TPayload> OFNBABAGNIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly ICLNCBDCEBF<TRoot, TPayload, TOk, TErr> NNMIGBKMDFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool KJNKPJOOICI;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3D40770", Offset = "0x3D3F170", VA = "0x183D40770")]
		public LOEJDCMMJDM(LODNFCKKNEJ<TActionKind, TSerializedAction, TPayload> APFDEGILJOH, ICLNCBDCEBF<TRoot, TPayload, TOk, TErr> FLPGFGKFFPB, bool NGNFOAPDBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4295F60", Offset = "0x4294960", VA = "0x184295F60", Slot = "4")]
		[AsyncStateMachine(typeof(LOEJDCMMJDM<, , >.ECNBNBFJMCD))]
		public Task<CIKECDEKJAI<object, JPLAIBFIFBK>> BOHDCAOOIAI(TDeps HDLOJHGAFKF, TRoot GFFCILHEGII, TSerializedAction CHMLLBCHGFG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly EAHDAGDGPKK<TActionKind, TSerializedAction, TRoot, TDeps> FEANHFKPPKE;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x926780", Offset = "0x925180", VA = "0x180926780")]
	private OKDNFLBHGEG(EAHDAGDGPKK<TActionKind, TSerializedAction, TRoot, TDeps> LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4660940", Offset = "0x465F340", VA = "0x184660940")]
	public static OKDNFLBHGEG<TActionKind, TSerializedAction, TRoot, TDeps> FJAAFKPDAIA()
	{
		return default(OKDNFLBHGEG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2BC0780", Offset = "0x2BBF180", VA = "0x182BC0780")]
	public OKDNFLBHGEG<TActionKind, TSerializedAction, TRoot, TDeps> GLEEMOBEONO<TPayload, TOk, TErr>(TActionKind FPKKAFNOOID, LODNFCKKNEJ<TActionKind, TSerializedAction, TPayload> APFDEGILJOH, MNJCJOLPFGM<TRoot, TPayload, TOk, TErr> FLPGFGKFFPB, bool NGNFOAPDBNB = true) where TPayload : notnull where TOk : notnull where TErr : notnull, JPLAIBFIFBK
	{
		return default(OKDNFLBHGEG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2BC0780", Offset = "0x2BBF180", VA = "0x182BC0780")]
	public OKDNFLBHGEG<TActionKind, TSerializedAction, TRoot, TDeps> LMAADOJOLMD<TPayload, TOk, TErr>(TActionKind FPKKAFNOOID, LODNFCKKNEJ<TActionKind, TSerializedAction, TPayload> APFDEGILJOH, ICLNCBDCEBF<TRoot, TPayload, TOk, TErr> FLPGFGKFFPB, bool NGNFOAPDBNB = true) where TPayload : notnull where TOk : notnull where TErr : notnull, JPLAIBFIFBK
	{
		return default(OKDNFLBHGEG<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x46609E0", Offset = "0x465F3E0", VA = "0x1846609E0")]
	public GKEHAHJEGAM<TActionKind, TSerializedAction, TRoot, TDeps> JDLJCBHINAK(TDeps HDLOJHGAFKF)
	{
		return default(GKEHAHJEGAM<TActionKind, TSerializedAction, TRoot, TDeps>);
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
