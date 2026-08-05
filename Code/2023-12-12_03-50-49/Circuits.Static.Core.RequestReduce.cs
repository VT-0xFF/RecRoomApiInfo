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
		[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CCFBF0", Offset = "0x1CCE3F0", VA = "0x181CCFBF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79CCC0", Offset = "0x79B4C0", VA = "0x18079CCC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79CD00", Offset = "0x79B500", VA = "0x18079CD00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate NJKBAHIFHIM<TActionKind, TPayload> MKJPCNHBBAA<TActionKind, TSerializedAction, TPayload>(TSerializedAction EEPKECDCJGN);
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal interface MDDOAAOKJPJ<TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LBFOJMHFNLD<object, AABCOILMPHO>> NACPJKEFMEB(TDeps JFHMOFHDJOF, TRoot PHEKGOFMNOB, TSerializedAction EEPKECDCJGN);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class EJKHJKFPJAJ<TActionKind, TSerializedAction, TRoot, TDeps> : IJJELFILJOP where TDeps : LCPNCEBBACA.IJBAKLDHLPI<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TDeps LPEEHBCIPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly TSerializedAction BBFLCIAHGKF;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3109DA0", Offset = "0x31085A0", VA = "0x183109DA0")]
	public EJKHJKFPJAJ([In] TDeps JFHMOFHDJOF, [In] TSerializedAction EEPKECDCJGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3109C70", Offset = "0x3108470", VA = "0x183109C70", Slot = "7")]
	public override string PJMGMONBGLC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct NJKBAHIFHIM<TActionKind, TPayload>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly TActionKind OODCNCGOCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly TPayload BENMHEPFIBI;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3D2A380", Offset = "0x3D28B80", VA = "0x183D2A380")]
	internal NJKBAHIFHIM(TActionKind GMMCJNGGPDM, [In] TPayload IOHCLNMNKCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class ABPJKNFCJJK
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2B07F10", Offset = "0x2B06710", VA = "0x182B07F10")]
	public static NJKBAHIFHIM<TActionKind, TPayload> AKKFLOCCMNP<TActionKind, TPayload>([In] TActionKind GMMCJNGGPDM, [In] TPayload IOHCLNMNKCI)
	{
		return default(NJKBAHIFHIM<TActionKind, TPayload>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate Task<LBFOJMHFNLD<TOk, TErr>> CHKBBBIGOBA<TRoot, TPayload, TOk, TErr>(TRoot PHEKGOFMNOB, TPayload IOHCLNMNKCI);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate LBFOJMHFNLD<TOk, TErr> EOGOMAEMKCD<TRoot, TPayload, TOk, TErr>(TRoot PHEKGOFMNOB, [In] TPayload IOHCLNMNKCI);
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct CFBLOFEPJKI<TActionKind, TSerializedAction, TRoot, TDeps> where TDeps : LCPNCEBBACA.IJBAKLDHLPI<TActionKind, TSerializedAction, TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HPLLDCJGCLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<LBFOJMHFNLD<object, AABCOILMPHO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CFBLOFEPJKI<TActionKind, TSerializedAction, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public TSerializedAction serializedAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private TaskAwaiter<LBFOJMHFNLD<object, AABCOILMPHO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x35F4070", Offset = "0x35F2870", VA = "0x1835F4070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x35F4A00", Offset = "0x35F3200", VA = "0x1835F4A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<TActionKind, MDDOAAOKJPJ<TSerializedAction, TRoot, TDeps>> LCHEEKHPMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly TDeps LPEEHBCIPOH;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8384B0", Offset = "0x836CB0", VA = "0x1808384B0")]
	internal CFBLOFEPJKI(Dictionary<TActionKind, MDDOAAOKJPJ<TSerializedAction, TRoot, TDeps>> NKEMNMEDFFE, TDeps JFHMOFHDJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x48F42C0", Offset = "0x48F2AC0", VA = "0x1848F42C0")]
	[AsyncStateMachine(typeof(CFBLOFEPJKI<, , , >.HPLLDCJGCLH))]
	public Task<LBFOJMHFNLD<object, AABCOILMPHO>> NACPJKEFMEB(TRoot PHEKGOFMNOB, TSerializedAction EEPKECDCJGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class LCPNCEBBACA
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface IJBAKLDHLPI<TActionKind, TSerializedAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TActionKind IMKPBAADDNM(TSerializedAction PIEBBHMNEOG);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IILPLKBGLOE(TRoot PHEKGOFMNOB, TSerializedAction KJDOCFCKCJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x24DAC20", Offset = "0x24D9420", VA = "0x1824DAC20")]
	internal static CFBLOFEPJKI<TActionKind, TSerializedAction, TRoot, TDeps> AKKFLOCCMNP<TActionKind, TSerializedAction, TRoot, TDeps>(Dictionary<TActionKind, MDDOAAOKJPJ<TSerializedAction, TRoot, TDeps>> NKEMNMEDFFE, TDeps JFHMOFHDJOF) where TDeps : IJBAKLDHLPI<TActionKind, TSerializedAction, TRoot>
	{
		return default(CFBLOFEPJKI<TActionKind, TSerializedAction, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class CONKBKAOBNG<TActionKind, TSerializedAction, TRoot, TDeps>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Dictionary<TActionKind, MDDOAAOKJPJ<TSerializedAction, TRoot, TDeps>> KIAFFCOCDOO;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x775290", Offset = "0x773A90", VA = "0x180775290")]
	private CONKBKAOBNG(Dictionary<TActionKind, MDDOAAOKJPJ<TSerializedAction, TRoot, TDeps>> NKEMNMEDFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4A9C300", Offset = "0x4A9AB00", VA = "0x184A9C300")]
	public static CONKBKAOBNG<TActionKind, TSerializedAction, TRoot, TDeps> AKKFLOCCMNP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct OBFNFIDHDKL<TActionKind, TSerializedAction, TRoot, TDeps> where TActionKind : notnull where TSerializedAction : notnull where TRoot : notnull where TDeps : notnull, LCPNCEBBACA.IJBAKLDHLPI<TActionKind, TSerializedAction, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class NEPKJDIBNPB<TPayload, TOk, TErr> : MDDOAAOKJPJ<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, AABCOILMPHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly MKJPCNHBBAA<TActionKind, TSerializedAction, TPayload> JOINPMJNIIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly EOGOMAEMKCD<TRoot, TPayload, TOk, TErr> ABOBOCLBHPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool EFKOHIMGOKP;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3516BB0", Offset = "0x35153B0", VA = "0x183516BB0")]
		public NEPKJDIBNPB(MKJPCNHBBAA<TActionKind, TSerializedAction, TPayload> DCADPPBGLAJ, EOGOMAEMKCD<TRoot, TPayload, TOk, TErr> CCIDGABNBCN, bool GNNBCHKFJPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3D15810", Offset = "0x3D14010", VA = "0x183D15810", Slot = "4")]
		public Task<LBFOJMHFNLD<object, AABCOILMPHO>> NACPJKEFMEB(TDeps JFHMOFHDJOF, TRoot PHEKGOFMNOB, TSerializedAction EEPKECDCJGN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class GBJOLGCHCOH<TPayload, TOk, TErr> : MDDOAAOKJPJ<TSerializedAction, TRoot, TDeps> where TPayload : notnull where TOk : notnull where TErr : notnull, AABCOILMPHO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct BPIAAOKHKCB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<LBFOJMHFNLD<object?, AABCOILMPHO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public GBJOLGCHCOH<TPayload, TOk, TErr> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public TDeps deps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public TRoot root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public TSerializedAction serializedAction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private LBFOJMHFNLD<object?, AABCOILMPHO> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<LBFOJMHFNLD<TOk, TErr>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4609250", Offset = "0x4607A50", VA = "0x184609250", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4609C00", Offset = "0x4608400", VA = "0x184609C00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly MKJPCNHBBAA<TActionKind, TSerializedAction, TPayload> JOINPMJNIIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly CHKBBBIGOBA<TRoot, TPayload, TOk, TErr> ABOBOCLBHPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly bool EFKOHIMGOKP;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3516BB0", Offset = "0x35153B0", VA = "0x183516BB0")]
		public GBJOLGCHCOH(MKJPCNHBBAA<TActionKind, TSerializedAction, TPayload> DCADPPBGLAJ, CHKBBBIGOBA<TRoot, TPayload, TOk, TErr> CCIDGABNBCN, bool GNNBCHKFJPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3516630", Offset = "0x3514E30", VA = "0x183516630", Slot = "4")]
		[AsyncStateMachine(typeof(GBJOLGCHCOH<, , >.BPIAAOKHKCB))]
		public Task<LBFOJMHFNLD<object, AABCOILMPHO>> NACPJKEFMEB(TDeps JFHMOFHDJOF, TRoot PHEKGOFMNOB, TSerializedAction EEPKECDCJGN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly CONKBKAOBNG<TActionKind, TSerializedAction, TRoot, TDeps> OBAHELACCIA;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x873730", Offset = "0x871F30", VA = "0x180873730")]
	private OBFNFIDHDKL(CONKBKAOBNG<TActionKind, TSerializedAction, TRoot, TDeps> FCHBDAMJEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3DFDE80", Offset = "0x3DFC680", VA = "0x183DFDE80")]
	public static OBFNFIDHDKL<TActionKind, TSerializedAction, TRoot, TDeps> AKKFLOCCMNP()
	{
		return default(OBFNFIDHDKL<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2425A20", Offset = "0x2424220", VA = "0x182425A20")]
	public OBFNFIDHDKL<TActionKind, TSerializedAction, TRoot, TDeps> ONCKJBAGJLD<TPayload, TOk, TErr>(TActionKind GMMCJNGGPDM, MKJPCNHBBAA<TActionKind, TSerializedAction, TPayload> DCADPPBGLAJ, EOGOMAEMKCD<TRoot, TPayload, TOk, TErr> CCIDGABNBCN, bool GNNBCHKFJPH = true) where TPayload : notnull where TOk : notnull where TErr : notnull, AABCOILMPHO
	{
		return default(OBFNFIDHDKL<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2425A20", Offset = "0x2424220", VA = "0x182425A20")]
	public OBFNFIDHDKL<TActionKind, TSerializedAction, TRoot, TDeps> NAIGCDOLAMI<TPayload, TOk, TErr>(TActionKind GMMCJNGGPDM, MKJPCNHBBAA<TActionKind, TSerializedAction, TPayload> DCADPPBGLAJ, CHKBBBIGOBA<TRoot, TPayload, TOk, TErr> CCIDGABNBCN, bool GNNBCHKFJPH = true) where TPayload : notnull where TOk : notnull where TErr : notnull, AABCOILMPHO
	{
		return default(OBFNFIDHDKL<TActionKind, TSerializedAction, TRoot, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3DFDF10", Offset = "0x3DFC710", VA = "0x183DFDF10")]
	public CFBLOFEPJKI<TActionKind, TSerializedAction, TRoot, TDeps> CGLCBLDLOFL(TDeps JFHMOFHDJOF)
	{
		return default(CFBLOFEPJKI<TActionKind, TSerializedAction, TRoot, TDeps>);
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
