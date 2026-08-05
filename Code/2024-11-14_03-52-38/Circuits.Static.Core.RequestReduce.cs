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
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
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
		[Cpp2IlInjected.Address(RVA = "0x2292DD0", Offset = "0x22921D0", VA = "0x182292DD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C5B80", Offset = "0x8C4F80", VA = "0x1808C5B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C5BC0", Offset = "0x8C4FC0", VA = "0x1808C5BC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate DOIPFJMFMMP<TActionKind, TPayload> FIBIIGGDOBF<TActionKind, TSerializedAction, TPayload>(TSerializedAction AHOALFBDPCC);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface MEFMMDFONAC<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BMFECDODLAB<object, JLOPLHOLGBP>> AOFHOEOCMPE(TDeps PJBENGOCCDF, TRoot DADDPLMNJHB, TSerializedAction AHOALFBDPCC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class OCDNFFJJPIG<TActionKind, TSerializedAction, TRoot, TDeps> : PBKMDGOJDEJ where TDeps : IDMDJNIGDML.JHLOFCFNCNK<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps ACLONILLIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction EGALJIDPOBF;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4A45E10", Offset = "0x4A45210", VA = "0x184A45E10")]
	public OCDNFFJJPIG([In] TDeps PJBENGOCCDF, [In] TSerializedAction AHOALFBDPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4A45CF0", Offset = "0x4A450F0", VA = "0x184A45CF0", Slot = "7")]
	public override string ECJFEDANMLC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct DOIPFJMFMMP<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind JFANHPEKKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload AKLMFCNBCNG;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5C1D0A0", Offset = "0x5C1C4A0", VA = "0x185C1D0A0")]
	internal DOIPFJMFMMP(TActionKind FMNNALNGIJD, [In] TPayload AKKEJIFPDJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class MODHKEOMJFO
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6CA0", Offset = "0x2FC60A0", VA = "0x182FC6CA0")]
	public static DOIPFJMFMMP<TActionKind, TPayload> GIIIFAJNKEL<TActionKind, TPayload>([In] TActionKind FMNNALNGIJD, [In] TPayload AKKEJIFPDJM)
	{
		return default(DOIPFJMFMMP<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<BMFECDODLAB<TOk, TErr>> MDKKMDIHCPL<TRoot, TPayload, TOk, TErr>(TRoot DADDPLMNJHB, TPayload AKKEJIFPDJM);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate BMFECDODLAB<TOk, TErr> ODBLNHBDBNH<TRoot, TPayload, TOk, TErr>(TRoot DADDPLMNJHB, [In] TPayload AKKEJIFPDJM);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct JEDHPHBJKJA<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : IDMDJNIGDML.JHLOFCFNCNK<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PBILCGPMHOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<object, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public JEDHPHBJKJA<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<BMFECDODLAB<object, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4B12D00", Offset = "0x4B12100", VA = "0x184B12D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4B13190", Offset = "0x4B12590", VA = "0x184B13190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, MEFMMDFONAC<TSerializedAction, TRoot, TDeps>> DMDONNEGOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps ACLONILLIHG;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xDEC7B0", Offset = "0xDEBBB0", VA = "0x180DEC7B0")]
	internal JEDHPHBJKJA(Dictionary<TActionKind, MEFMMDFONAC<TSerializedAction, TRoot, TDeps>> CAAOAKAKCEH, TDeps PJBENGOCCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x43DB8C0", Offset = "0x43DACC0", VA = "0x1843DB8C0")]
	[AsyncStateMachine(typeof(JEDHPHBJKJA<, , , >.PBILCGPMHOL))]
	public Task<BMFECDODLAB<object, JLOPLHOLGBP>> AOFHOEOCMPE(TRoot DADDPLMNJHB, TSerializedAction AHOALFBDPCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class IDMDJNIGDML
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface JHLOFCFNCNK<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind DENDOLKFPMD(TSerializedAction EAFEIEDNLNL);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CJMBJENLGIJ(TRoot DADDPLMNJHB, TSerializedAction LLIKOHELCCA);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void JALHJJLBOGF(TRoot DADDPLMNJHB, TSerializedAction LLIKOHELCCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2EE0380", Offset = "0x2EDF780", VA = "0x182EE0380")]
	internal static JEDHPHBJKJA<TActionKind, TSerializedAction, TRoot, TDeps> GIIIFAJNKEL<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, MEFMMDFONAC<TSerializedAction, TRoot, TDeps>> CAAOAKAKCEH, TDeps PJBENGOCCDF) where TDeps : JHLOFCFNCNK<TActionKind, TSerializedAction, TRoot>
	{
		return default(JEDHPHBJKJA<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class FAMPJOIFKMP<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, MEFMMDFONAC<TSerializedAction, TRoot, TDeps>> CLMLDKLEIIO;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x89A2A0", Offset = "0x8996A0", VA = "0x18089A2A0")]
	private FAMPJOIFKMP(Dictionary<TActionKind, MEFMMDFONAC<TSerializedAction, TRoot, TDeps>> CAAOAKAKCEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3F16B80", Offset = "0x3F15F80", VA = "0x183F16B80")]
	public static FAMPJOIFKMP<TActionKind, TSerializedAction, TRoot, TDeps> GIIIFAJNKEL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct OBGJCPOEFJF<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, IDMDJNIGDML.JHLOFCFNCNK<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class KHIKFMOKFAM<TPayload, TOk, TErr> : MEFMMDFONAC<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, JLOPLHOLGBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly FIBIIGGDOBF<TActionKind, TSerializedAction, TPayload> FFMPLODJGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly ODBLNHBDBNH<TRoot, TPayload, TOk, TErr> DGJEJMBOPJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool OKABBPLOODF;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x451ABF0", Offset = "0x4519FF0", VA = "0x18451ABF0")]
		public KHIKFMOKFAM(FIBIIGGDOBF<TActionKind, TSerializedAction, TPayload> PKEKAEECIKI, ODBLNHBDBNH<TRoot, TPayload, TOk, TErr> HNGOMADGHNJ, bool GICHGNHCGPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4519460", Offset = "0x4518860", VA = "0x184519460", Slot = "4")]
		public Task<BMFECDODLAB<object, JLOPLHOLGBP>> AOFHOEOCMPE(TDeps PJBENGOCCDF, TRoot DADDPLMNJHB, TSerializedAction AHOALFBDPCC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class NNICONHKBFH<TPayload, TOk, TErr> : MEFMMDFONAC<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, JLOPLHOLGBP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct MKBKBPOGFFJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<BMFECDODLAB<object?, JLOPLHOLGBP>> <>t__builder;

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
			public NNICONHKBFH<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private BMFECDODLAB<object?, JLOPLHOLGBP> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<BMFECDODLAB<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x48D42B0", Offset = "0x48D36B0", VA = "0x1848D42B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x48D5100", Offset = "0x48D4500", VA = "0x1848D5100", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly FIBIIGGDOBF<TActionKind, TSerializedAction, TPayload> FFMPLODJGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly MDKKMDIHCPL<TRoot, TPayload, TOk, TErr> DGJEJMBOPJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool OKABBPLOODF;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x451ABF0", Offset = "0x4519FF0", VA = "0x18451ABF0")]
		public NNICONHKBFH(FIBIIGGDOBF<TActionKind, TSerializedAction, TPayload> PKEKAEECIKI, MDKKMDIHCPL<TRoot, TPayload, TOk, TErr> HNGOMADGHNJ, bool GICHGNHCGPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4967270", Offset = "0x4966670", VA = "0x184967270", Slot = "4")]
		[AsyncStateMachine(typeof(NNICONHKBFH<, , >.MKBKBPOGFFJ))]
		public Task<BMFECDODLAB<object, JLOPLHOLGBP>> AOFHOEOCMPE(TDeps PJBENGOCCDF, TRoot DADDPLMNJHB, TSerializedAction AHOALFBDPCC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly FAMPJOIFKMP<TActionKind, TSerializedAction, TRoot, TDeps> MLLHAONLDHA;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x948260", Offset = "0x947660", VA = "0x180948260")]
	private OBGJCPOEFJF(FAMPJOIFKMP<TActionKind, TSerializedAction, TRoot, TDeps> EIFGKHNPLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4A454F0", Offset = "0x4A448F0", VA = "0x184A454F0")]
	public static OBGJCPOEFJF<TActionKind, TSerializedAction, TRoot, TDeps> GIIIFAJNKEL()
	{
		return default(OBGJCPOEFJF<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3072170", Offset = "0x3071570", VA = "0x183072170")]
	public OBGJCPOEFJF<TActionKind, TSerializedAction, TRoot, TDeps> BMAOPLHFOPD<TPayload, TOk, TErr>(TActionKind FMNNALNGIJD, FIBIIGGDOBF<TActionKind, TSerializedAction, TPayload> PKEKAEECIKI, ODBLNHBDBNH<TRoot, TPayload, TOk, TErr> HNGOMADGHNJ, bool GICHGNHCGPG = true) where TPayload : notnull where TOk : notnull where TErr : notnull, JLOPLHOLGBP
	{
		return default(OBGJCPOEFJF<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3072170", Offset = "0x3071570", VA = "0x183072170")]
	public OBGJCPOEFJF<TActionKind, TSerializedAction, TRoot, TDeps> GGAMOCOIJKJ<TPayload, TOk, TErr>(TActionKind FMNNALNGIJD, FIBIIGGDOBF<TActionKind, TSerializedAction, TPayload> PKEKAEECIKI, MDKKMDIHCPL<TRoot, TPayload, TOk, TErr> HNGOMADGHNJ, bool GICHGNHCGPG = true) where TPayload : notnull where TOk : notnull where TErr : notnull, JLOPLHOLGBP
	{
		return default(OBGJCPOEFJF<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4A45590", Offset = "0x4A44990", VA = "0x184A45590")]
	public JEDHPHBJKJA<TActionKind, TSerializedAction, TRoot, TDeps> KOJLHCDBCGN(TDeps PJBENGOCCDF)
	{
		return default(JEDHPHBJKJA<TActionKind, TSerializedAction, TRoot, TDeps>);
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
