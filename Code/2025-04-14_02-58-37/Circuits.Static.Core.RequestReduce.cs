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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x26BFE60", Offset = "0x26BE860", VA = "0x1826BFE60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D8490", Offset = "0x9D6E90", VA = "0x1809D8490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D84D0", Offset = "0x9D6ED0", VA = "0x1809D84D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate FKHNAHCPKHN<TActionKind, TPayload> FMLEPKICKIG<TActionKind, TSerializedAction, TPayload>(TSerializedAction IIOKJLEMAAN);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface APBPBDLHAML<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CEGCKGHHPPP<object, LLCKKJAFJEM>> NDKPMJKJJCP(TDeps DODNABDPAAP, TRoot MHHKOMDGDID, TSerializedAction IIOKJLEMAAN);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class MDMKDLADFHP<TActionKind, TSerializedAction, TRoot, TDeps> : HELNIKNELLA where TDeps : NIDONOJJPOD.FEEEBELDDEC<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps LGCCMBFCAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction GCHJDIGGOKG;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5127270", Offset = "0x5125C70", VA = "0x185127270")]
	public MDMKDLADFHP([In] TDeps DODNABDPAAP, [In] TSerializedAction IIOKJLEMAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x51271A0", Offset = "0x5125BA0", VA = "0x1851271A0", Slot = "7")]
	public override string CENGCFKJIFH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct FKHNAHCPKHN<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind HNJCNEAHDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload GGIHIAKJICM;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x47D7130", Offset = "0x47D5B30", VA = "0x1847D7130")]
	internal FKHNAHCPKHN(TActionKind EIHGMKIOEDI, [In] TPayload ECGNDACMANN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class EJDOEKBGPHD
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x34C1830", Offset = "0x34C0230", VA = "0x1834C1830")]
	public static FKHNAHCPKHN<TActionKind, TPayload> DDDHPONDPCL<TActionKind, TPayload>([In] TActionKind EIHGMKIOEDI, [In] TPayload ECGNDACMANN)
	{
		return default(FKHNAHCPKHN<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<CEGCKGHHPPP<TOk, TErr>> EALAELEHNEL<TRoot, TPayload, TOk, TErr>(TRoot MHHKOMDGDID, TPayload ECGNDACMANN);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate CEGCKGHHPPP<TOk, TErr> DEDBJFDHHLP<TRoot, TPayload, TOk, TErr>(TRoot MHHKOMDGDID, [In] TPayload ECGNDACMANN);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct FIABPIPHIKM<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : NIDONOJJPOD.FEEEBELDDEC<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct JFLILAMKDFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<CEGCKGHHPPP<object?, LLCKKJAFJEM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public FIABPIPHIKM<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<CEGCKGHHPPP<object, LLCKKJAFJEM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4CC5350", Offset = "0x4CC3D50", VA = "0x184CC5350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4CC5CE0", Offset = "0x4CC46E0", VA = "0x184CC5CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, APBPBDLHAML<TSerializedAction, TRoot, TDeps>> FBDLNKBJGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps LGCCMBFCAMH;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA487F0", Offset = "0xA471F0", VA = "0x180A487F0")]
	internal FIABPIPHIKM(Dictionary<TActionKind, APBPBDLHAML<TSerializedAction, TRoot, TDeps>> LLLNCJAIGNK, TDeps DODNABDPAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x47CB1E0", Offset = "0x47C9BE0", VA = "0x1847CB1E0")]
	[AsyncStateMachine(typeof(FIABPIPHIKM<, , , >.JFLILAMKDFN))]
	public Task<CEGCKGHHPPP<object, LLCKKJAFJEM>> NDKPMJKJJCP(TRoot MHHKOMDGDID, TSerializedAction IIOKJLEMAAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class NIDONOJJPOD
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface FEEEBELDDEC<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind EHJGNGCCBPH(TSerializedAction IJPDNJELPLO);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OIBNBAIMMKH(TRoot MHHKOMDGDID, TSerializedAction HNDDBOOOBBE);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ILECKLECPNE(TRoot MHHKOMDGDID, TSerializedAction HNDDBOOOBBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x341E830", Offset = "0x341D230", VA = "0x18341E830")]
	internal static FIABPIPHIKM<TActionKind, TSerializedAction, TRoot, TDeps> DDDHPONDPCL<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, APBPBDLHAML<TSerializedAction, TRoot, TDeps>> LLLNCJAIGNK, TDeps DODNABDPAAP) where TDeps : FEEEBELDDEC<TActionKind, TSerializedAction, TRoot>
	{
		return default(FIABPIPHIKM<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class DPGFCODGDLG<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, APBPBDLHAML<TSerializedAction, TRoot, TDeps>> EFPGJPCIKGP;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x9B0720", Offset = "0x9AF120", VA = "0x1809B0720")]
	private DPGFCODGDLG(Dictionary<TActionKind, APBPBDLHAML<TSerializedAction, TRoot, TDeps>> LLLNCJAIGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3F347B0", Offset = "0x3F331B0", VA = "0x183F347B0")]
	public static DPGFCODGDLG<TActionKind, TSerializedAction, TRoot, TDeps> DDDHPONDPCL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct JEKLMJDOAEC<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, NIDONOJJPOD.FEEEBELDDEC<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class IBPFBEJOEHP<TPayload, TOk, TErr> : APBPBDLHAML<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, LLCKKJAFJEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly FMLEPKICKIG<TActionKind, TSerializedAction, TPayload> BKNOCBCJOII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly DEDBJFDHHLP<TRoot, TPayload, TOk, TErr> HDKODICGLMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool ODMFHKPEFEE;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x18B00E0", Offset = "0x18AEAE0", VA = "0x1818B00E0")]
		public IBPFBEJOEHP(FMLEPKICKIG<TActionKind, TSerializedAction, TPayload> PANOEONEKAC, DEDBJFDHHLP<TRoot, TPayload, TOk, TErr> HDECGHBFDNN, bool MNODNHGNAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4A40090", Offset = "0x4A3EA90", VA = "0x184A40090", Slot = "4")]
		public Task<CEGCKGHHPPP<object, LLCKKJAFJEM>> NDKPMJKJJCP(TDeps DODNABDPAAP, TRoot MHHKOMDGDID, TSerializedAction IIOKJLEMAAN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class KPDJKNKMPIF<TPayload, TOk, TErr> : APBPBDLHAML<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, LLCKKJAFJEM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct NPPCHAOLEOK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<CEGCKGHHPPP<object?, LLCKKJAFJEM>> <>t__builder;

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
			public KPDJKNKMPIF<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private CEGCKGHHPPP<object?, LLCKKJAFJEM> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<CEGCKGHHPPP<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x51CDA00", Offset = "0x51CC400", VA = "0x1851CDA00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x51CEF10", Offset = "0x51CD910", VA = "0x1851CEF10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly FMLEPKICKIG<TActionKind, TSerializedAction, TPayload> BKNOCBCJOII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly EALAELEHNEL<TRoot, TPayload, TOk, TErr> HDKODICGLMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool ODMFHKPEFEE;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x18B00E0", Offset = "0x18AEAE0", VA = "0x1818B00E0")]
		public KPDJKNKMPIF(FMLEPKICKIG<TActionKind, TSerializedAction, TPayload> PANOEONEKAC, EALAELEHNEL<TRoot, TPayload, TOk, TErr> HDECGHBFDNN, bool MNODNHGNAAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4E23CC0", Offset = "0x4E226C0", VA = "0x184E23CC0", Slot = "4")]
		[AsyncStateMachine(typeof(KPDJKNKMPIF<, , >.NPPCHAOLEOK))]
		public Task<CEGCKGHHPPP<object, LLCKKJAFJEM>> NDKPMJKJJCP(TDeps DODNABDPAAP, TRoot MHHKOMDGDID, TSerializedAction IIOKJLEMAAN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly DPGFCODGDLG<TActionKind, TSerializedAction, TRoot, TDeps> JAGGFOKDKOF;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xC9BA30", Offset = "0xC9A430", VA = "0x180C9BA30")]
	private JEKLMJDOAEC(DPGFCODGDLG<TActionKind, TSerializedAction, TRoot, TDeps> DFPGGEDGGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4CC3FA0", Offset = "0x4CC29A0", VA = "0x184CC3FA0")]
	public static JEKLMJDOAEC<TActionKind, TSerializedAction, TRoot, TDeps> DDDHPONDPCL()
	{
		return default(JEKLMJDOAEC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3A7EE90", Offset = "0x3A7D890", VA = "0x183A7EE90")]
	public JEKLMJDOAEC<TActionKind, TSerializedAction, TRoot, TDeps> JBGCEMBLBLF<TPayload, TOk, TErr>(TActionKind EIHGMKIOEDI, FMLEPKICKIG<TActionKind, TSerializedAction, TPayload> PANOEONEKAC, DEDBJFDHHLP<TRoot, TPayload, TOk, TErr> HDECGHBFDNN, bool MNODNHGNAAP = true) where TPayload : notnull where TOk : notnull where TErr : notnull, LLCKKJAFJEM
	{
		return default(JEKLMJDOAEC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3A7EE90", Offset = "0x3A7D890", VA = "0x183A7EE90")]
	public JEKLMJDOAEC<TActionKind, TSerializedAction, TRoot, TDeps> HPBAFLLBNLO<TPayload, TOk, TErr>(TActionKind EIHGMKIOEDI, FMLEPKICKIG<TActionKind, TSerializedAction, TPayload> PANOEONEKAC, EALAELEHNEL<TRoot, TPayload, TOk, TErr> HDECGHBFDNN, bool MNODNHGNAAP = true) where TPayload : notnull where TOk : notnull where TErr : notnull, LLCKKJAFJEM
	{
		return default(JEKLMJDOAEC<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4CC4040", Offset = "0x4CC2A40", VA = "0x184CC4040")]
	public FIABPIPHIKM<TActionKind, TSerializedAction, TRoot, TDeps> LLJAPGMKKAL(TDeps DODNABDPAAP)
	{
		return default(FIABPIPHIKM<TActionKind, TSerializedAction, TRoot, TDeps>);
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
