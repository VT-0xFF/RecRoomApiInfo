using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[AttributeUsage(AttributeTargets.Class)]
public class OBMCANMDCDH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
	public OBMCANMDCDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Class)]
public class CKFEEMGHLEM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7C6B550", Offset = "0x7C6A750", VA = "0x187C6B550")]
	public CKFEEMGHLEM(int GCFCAGDGDIN, int OGGINKJJPCC, int FOKJKCDCBGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Class)]
public class NFAIMJFIIIA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA2C5A0", Offset = "0xA2B7A0", VA = "0x180A2C5A0")]
	public NFAIMJFIIIA(bool LNMNLBKABHC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Class)]
public class FKAOLCNIOAK : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C6BD50", Offset = "0x7C6AF50", VA = "0x187C6BD50")]
	public FKAOLCNIOAK(string GBOCGPJOEEK, string AOOEEPGFGKK = "")
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Class)]
public class NOKBGCHHEIH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int LFLEGEJLLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA00110", Offset = "0x9FF310", VA = "0x180A00110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2277DA0", Offset = "0x2276FA0", VA = "0x182277DA0")]
	public NOKBGCHHEIH(int KJIOHKMJAPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
public enum EEODNOBFJGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	NonNetworked = 1,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Incoming = 2,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Outgoing = 4,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Suppressed = 8,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	FastForward = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	CacheRemove = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Default = 0x3F,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	All = 0x3F
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ACDIIOFPHNF
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CGLOCFFICMN<T> : ACDIIOFPHNF
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DGHHLKCMNFH([In] CNOCNLPFEAP CBCAJOFGMOH, T KJIOHKMJAPE);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KKCOHLBALOA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool IFGIEJOOMEE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int HAPKNAGAFGN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int LHHIGJLPIAK(Type GDHKDBJPDLG);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BNIHGIGCICA(NativeParallelHashMap<int, BMJBNELGBIH> CFPNMKPLIJH, NativeArray<byte> CAIGHLKIDBF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OLJDGLPLFLA
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class BGLEMGHLIHG
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class MPPBKOLEGOD<T> : OHLDAFPOPKG<T> where T : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x462DEB0", Offset = "0x462D0B0", VA = "0x18462DEB0")]
	protected MPPBKOLEGOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class OHLDAFPOPKG<T> : CGLOCFFICMN<T>, ACDIIOFPHNF where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x52309A0", Offset = "0x522FBA0", VA = "0x1852309A0")]
	public void DGHHLKCMNFH([In] CNOCNLPFEAP CBCAJOFGMOH, T KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	protected OHLDAFPOPKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5230A80", Offset = "0x522FC80", VA = "0x185230A80", Slot = "4")]
	private void KANAEKHPLGD([In] CNOCNLPFEAP CBCAJOFGMOH, T KJIOHKMJAPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class KEAFNJDEDIG<T> : CGLOCFFICMN<NativeArray<T>>, ACDIIOFPHNF where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x512AE30", Offset = "0x512A030", VA = "0x18512AE30")]
	public void DGHHLKCMNFH([In] CNOCNLPFEAP CBCAJOFGMOH, NativeArray<T> KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3B63A70", Offset = "0x3B62C70", VA = "0x183B63A70")]
	public static ReadOnlySpan<T> MMMBGCLMKJJ<T>(NativeArray<T> KBILCKNPAKO) where T : struct
	{
		return default(ReadOnlySpan<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	protected KEAFNJDEDIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x512AF80", Offset = "0x512A180", VA = "0x18512AF80", Slot = "4")]
	private void HMCOJCNKBEO([In] CNOCNLPFEAP CBCAJOFGMOH, NativeArray<T> KJIOHKMJAPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FDPMJDABLCM : CGLOCFFICMN<FDPMJDABLCM.DKMGJEDEBMP>, ACDIIOFPHNF
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct DKMGJEDEBMP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
	public void DGHHLKCMNFH([In] CNOCNLPFEAP CBCAJOFGMOH, DKMGJEDEBMP KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public FDPMJDABLCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "4")]
	private void LLKECGOLCGL([In] CNOCNLPFEAP CBCAJOFGMOH, DKMGJEDEBMP KJIOHKMJAPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class BEPJPLPNKDH : CGLOCFFICMN<string>, ACDIIOFPHNF
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly BEPJPLPNKDH AIBLJDBPKAO;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7C6B180", Offset = "0x7C6A380", VA = "0x187C6B180")]
	public void DGHHLKCMNFH([In] CNOCNLPFEAP CBCAJOFGMOH, string KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public BEPJPLPNKDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C6B4D0", Offset = "0x7C6A6D0", VA = "0x187C6B4D0", Slot = "4")]
	private void PJNLKPJHFEJ([In] CNOCNLPFEAP CBCAJOFGMOH, string KJIOHKMJAPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class GGNFLOJOBPB<T> : LPHGBPPJLOI<T> where T : struct, IComparable<T>
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x462DEB0", Offset = "0x462D0B0", VA = "0x18462DEB0")]
	protected GGNFLOJOBPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class LPHGBPPJLOI<T> : CGLOCFFICMN<T>, ACDIIOFPHNF where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5230610", Offset = "0x522F810", VA = "0x185230610")]
	public void DGHHLKCMNFH([In] CNOCNLPFEAP CBCAJOFGMOH, T KJIOHKMJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	protected LPHGBPPJLOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5230AA0", Offset = "0x522FCA0", VA = "0x185230AA0", Slot = "4")]
	private void KANAEKHPLGD([In] CNOCNLPFEAP CBCAJOFGMOH, T KJIOHKMJAPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct CNOCNLPFEAP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct CMHIBCNGDJN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly CNOCNLPFEAP CBCAJOFGMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly int MPCGIMOCDCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly int GKOGOAJJGKL;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5D11E70", Offset = "0x5D11070", VA = "0x185D11E70")]
		public CMHIBCNGDJN(CNOCNLPFEAP CBCAJOFGMOH, int MPCGIMOCDCA, int GKOGOAJJGKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7C6B5A0", Offset = "0x7C6A7A0", VA = "0x187C6B5A0")]
		public CMHIBCNGDJN DEJGIIIHBBJ(ReadOnlySpan<byte> CAIGHLKIDBF)
		{
			return default(CMHIBCNGDJN);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4115E00", Offset = "0x4115000", VA = "0x184115E00")]
		public CMHIBCNGDJN DEJGIIIHBBJ<T>(T CAIGHLKIDBF) where T : struct
		{
			return default(CMHIBCNGDJN);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7C6B600", Offset = "0x7C6A800", VA = "0x187C6B600", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private KKCOHLBALOA GKNAPOCEKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private NativeParallelHashMap<int, BMJBNELGBIH> CFPNMKPLIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeList<byte> CAIGHLKIDBF;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7C6BB60", Offset = "0x7C6AD60", VA = "0x187C6BB60")]
	public CNOCNLPFEAP(KKCOHLBALOA GKNAPOCEKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7C6B8D0", Offset = "0x7C6AAD0", VA = "0x187C6B8D0")]
	public int ILKFPOIECKO(ACDIIOFPHNF EPPBECKMJNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7C6BA70", Offset = "0x7C6AC70", VA = "0x187C6BA70")]
	public CMHIBCNGDJN PBNJBPJFBFA(ACDIIOFPHNF EPPBECKMJNH)
	{
		return default(CMHIBCNGDJN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7C6B9C0", Offset = "0x7C6ABC0", VA = "0x187C6B9C0")]
	public CMHIBCNGDJN PBNJBPJFBFA(int JLOHKMLOFJN)
	{
		return default(CMHIBCNGDJN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7C6B7A0", Offset = "0x7C6A9A0", VA = "0x187C6B7A0")]
	public void HEKPIJMPPOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7C6B6A0", Offset = "0x7C6A8A0", VA = "0x187C6B6A0")]
	public CNOCNLPFEAP BHDHLEMKOHM()
	{
		return default(CNOCNLPFEAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7C6B740", Offset = "0x7C6A940", VA = "0x187C6B740", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class OLHACPJMCBA
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3BBBE70", Offset = "0x3BBB070", VA = "0x183BBBE70")]
	public static CNOCNLPFEAP LHOMNBOIMGH<T>([In] this CNOCNLPFEAP CBCAJOFGMOH, CGLOCFFICMN<T> EPPBECKMJNH, T KJIOHKMJAPE)
	{
		return default(CNOCNLPFEAP);
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
