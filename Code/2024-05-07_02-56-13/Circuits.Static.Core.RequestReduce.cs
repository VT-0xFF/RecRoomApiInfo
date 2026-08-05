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
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E58FE0", Offset = "0x1E581E0", VA = "0x181E58FE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DF880", Offset = "0x7DEA80", VA = "0x1807DF880")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DF8C0", Offset = "0x7DEAC0", VA = "0x1807DF8C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate GBKNCFEJMKO<TActionKind, TPayload> EPLDBMIMEON<TActionKind, TSerializedAction, TPayload>(TSerializedAction NNJENHFDHIG);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface JMHDIMNAGNA<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NFMFLMAOFMP<object, CEGADOEINOB>> JBFFLKBLKCL(TDeps NMAKCOKENKA, TRoot MIAAKEAGJGI, TSerializedAction NNJENHFDHIG);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class LGLANAPOJLH<TActionKind, TSerializedAction, TRoot, TDeps> : NNADKGMIMDE where TDeps : MDFHMEIIDDC.HIKMGFAPFPD<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps KDDFIFIFPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction HPBFMLGGODA;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3D3C2B0", Offset = "0x3D3B4B0", VA = "0x183D3C2B0")]
	public LGLANAPOJLH([In] TDeps NMAKCOKENKA, [In] TSerializedAction NNJENHFDHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3D3C190", Offset = "0x3D3B390", VA = "0x183D3C190", Slot = "7")]
	public override string FIHEJJCABJP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct GBKNCFEJMKO<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind BHLEPNNAJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload GDFDNDOAHEB;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x389EAA0", Offset = "0x389DCA0", VA = "0x18389EAA0")]
	internal GBKNCFEJMKO(TActionKind DHDGFICEEPJ, [In] TPayload AENCBMJJMMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class BCFMMENBAIK
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x26A42E0", Offset = "0x26A34E0", VA = "0x1826A42E0")]
	public static GBKNCFEJMKO<TActionKind, TPayload> MIJABIECKKD<TActionKind, TPayload>([In] TActionKind DHDGFICEEPJ, [In] TPayload AENCBMJJMMB)
	{
		return default(GBKNCFEJMKO<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<NFMFLMAOFMP<TOk, TErr>> DDJJBACPKOB<TRoot, TPayload, TOk, TErr>(TRoot MIAAKEAGJGI, TPayload AENCBMJJMMB);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate NFMFLMAOFMP<TOk, TErr> LFOILPHOMDJ<TRoot, TPayload, TOk, TErr>(TRoot MIAAKEAGJGI, [In] TPayload AENCBMJJMMB);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct GJFNHENNBOO<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : MDFHMEIIDDC.HIKMGFAPFPD<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct AGOIELFBCMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<object, CEGADOEINOB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public GJFNHENNBOO<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<NFMFLMAOFMP<object, CEGADOEINOB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x38E9730", Offset = "0x38E8930", VA = "0x1838E9730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x38EA010", Offset = "0x38E9210", VA = "0x1838EA010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, JMHDIMNAGNA<TSerializedAction, TRoot, TDeps>> GJANFCFILIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps KDDFIFIFPAP;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x947190", Offset = "0x946390", VA = "0x180947190")]
	internal GJFNHENNBOO(Dictionary<TActionKind, JMHDIMNAGNA<TSerializedAction, TRoot, TDeps>> PFINMEJBMOB, TDeps NMAKCOKENKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x38BE6E0", Offset = "0x38BD8E0", VA = "0x1838BE6E0")]
	[AsyncStateMachine(typeof(GJFNHENNBOO<, , , >.AGOIELFBCMF))]
	public Task<NFMFLMAOFMP<object, CEGADOEINOB>> JBFFLKBLKCL(TRoot MIAAKEAGJGI, TSerializedAction NNJENHFDHIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class MDFHMEIIDDC
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface HIKMGFAPFPD<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind MJDLEDELCFK(TSerializedAction KNKOEEEKHDK);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NCDKMAGKJDH(TRoot MIAAKEAGJGI, TSerializedAction GKGLDBAJJCH);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NEJBKHMBFHL(TRoot MIAAKEAGJGI, TSerializedAction GKGLDBAJJCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x28F8F90", Offset = "0x28F8190", VA = "0x1828F8F90")]
	internal static GJFNHENNBOO<TActionKind, TSerializedAction, TRoot, TDeps> MIJABIECKKD<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, JMHDIMNAGNA<TSerializedAction, TRoot, TDeps>> PFINMEJBMOB, TDeps NMAKCOKENKA) where TDeps : HIKMGFAPFPD<TActionKind, TSerializedAction, TRoot>
	{
		return default(GJFNHENNBOO<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class MBOJJGPPHJE<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, JMHDIMNAGNA<TSerializedAction, TRoot, TDeps>> JJICGHKOBOP;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7B8790", Offset = "0x7B7990", VA = "0x1807B8790")]
	private MBOJJGPPHJE(Dictionary<TActionKind, JMHDIMNAGNA<TSerializedAction, TRoot, TDeps>> PFINMEJBMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3F48E30", Offset = "0x3F48030", VA = "0x183F48E30")]
	public static MBOJJGPPHJE<TActionKind, TSerializedAction, TRoot, TDeps> MIJABIECKKD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct JLEBMEOEKFB<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, MDFHMEIIDDC.HIKMGFAPFPD<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class MKCFILPNKHB<TPayload, TOk, TErr> : JMHDIMNAGNA<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, CEGADOEINOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly EPLDBMIMEON<TActionKind, TSerializedAction, TPayload> MEBFNMALKAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly LFOILPHOMDJ<TRoot, TPayload, TOk, TErr> IMFNDMMOLCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool AAPHNMPEDHA;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3A56A30", Offset = "0x3A55C30", VA = "0x183A56A30")]
		public MKCFILPNKHB(EPLDBMIMEON<TActionKind, TSerializedAction, TPayload> MNEPFHKIECO, LFOILPHOMDJ<TRoot, TPayload, TOk, TErr> AAMBMOMGENE, bool GCJBFJKJEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3F69F40", Offset = "0x3F69140", VA = "0x183F69F40", Slot = "4")]
		public Task<NFMFLMAOFMP<object, CEGADOEINOB>> JBFFLKBLKCL(TDeps NMAKCOKENKA, TRoot MIAAKEAGJGI, TSerializedAction NNJENHFDHIG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class IKNBBPILIEJ<TPayload, TOk, TErr> : JMHDIMNAGNA<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, CEGADOEINOB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct DLKONEMHNAJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<NFMFLMAOFMP<object?, CEGADOEINOB>> <>t__builder;

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
			public IKNBBPILIEJ<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private NFMFLMAOFMP<object?, CEGADOEINOB> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<NFMFLMAOFMP<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x51307F0", Offset = "0x512F9F0", VA = "0x1851307F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x51323B0", Offset = "0x51315B0", VA = "0x1851323B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly EPLDBMIMEON<TActionKind, TSerializedAction, TPayload> MEBFNMALKAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly DDJJBACPKOB<TRoot, TPayload, TOk, TErr> IMFNDMMOLCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool AAPHNMPEDHA;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3A56A30", Offset = "0x3A55C30", VA = "0x183A56A30")]
		public IKNBBPILIEJ(EPLDBMIMEON<TActionKind, TSerializedAction, TPayload> MNEPFHKIECO, DDJJBACPKOB<TRoot, TPayload, TOk, TErr> AAMBMOMGENE, bool GCJBFJKJEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3A568E0", Offset = "0x3A55AE0", VA = "0x183A568E0", Slot = "4")]
		[AsyncStateMachine(typeof(IKNBBPILIEJ<, , >.DLKONEMHNAJ))]
		public Task<NFMFLMAOFMP<object, CEGADOEINOB>> JBFFLKBLKCL(TDeps NMAKCOKENKA, TRoot MIAAKEAGJGI, TSerializedAction NNJENHFDHIG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly MBOJJGPPHJE<TActionKind, TSerializedAction, TRoot, TDeps> OCGPEKKJCHN;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x94F0A0", Offset = "0x94E2A0", VA = "0x18094F0A0")]
	private JLEBMEOEKFB(MBOJJGPPHJE<TActionKind, TSerializedAction, TRoot, TDeps> FODGEDCJIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3C29FD0", Offset = "0x3C291D0", VA = "0x183C29FD0")]
	public static JLEBMEOEKFB<TActionKind, TSerializedAction, TRoot, TDeps> MIJABIECKKD()
	{
		return default(JLEBMEOEKFB<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2580780", Offset = "0x257F980", VA = "0x182580780")]
	public JLEBMEOEKFB<TActionKind, TSerializedAction, TRoot, TDeps> MBJIFEIMEOP<TPayload, TOk, TErr>(TActionKind DHDGFICEEPJ, EPLDBMIMEON<TActionKind, TSerializedAction, TPayload> MNEPFHKIECO, LFOILPHOMDJ<TRoot, TPayload, TOk, TErr> AAMBMOMGENE, bool GCJBFJKJEEN = true) where TPayload : notnull where TOk : notnull where TErr : notnull, CEGADOEINOB
	{
		return default(JLEBMEOEKFB<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2580780", Offset = "0x257F980", VA = "0x182580780")]
	public JLEBMEOEKFB<TActionKind, TSerializedAction, TRoot, TDeps> NMCDIPIKLIC<TPayload, TOk, TErr>(TActionKind DHDGFICEEPJ, EPLDBMIMEON<TActionKind, TSerializedAction, TPayload> MNEPFHKIECO, DDJJBACPKOB<TRoot, TPayload, TOk, TErr> AAMBMOMGENE, bool GCJBFJKJEEN = true) where TPayload : notnull where TOk : notnull where TErr : notnull, CEGADOEINOB
	{
		return default(JLEBMEOEKFB<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3C29F20", Offset = "0x3C29120", VA = "0x183C29F20")]
	public GJFNHENNBOO<TActionKind, TSerializedAction, TRoot, TDeps> GHOBLBEPOCJ(TDeps NMAKCOKENKA)
	{
		return default(GJFNHENNBOO<TActionKind, TSerializedAction, TRoot, TDeps>);
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
