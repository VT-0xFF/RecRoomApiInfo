using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80DE80", VA = "0x18080EA80")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F8ED10", Offset = "0x6F8E110", VA = "0x186F8ED10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x881BC0", Offset = "0x880FC0", VA = "0x180881BC0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD72FB0", Offset = "0xD723B0", VA = "0x180D72FB0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class JGAMJCFKCDP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xD72FB0", Offset = "0xD723B0", VA = "0x180D72FB0")]
	public JGAMJCFKCDP(bool EICEALMGHNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class NDHNGFOGLOL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xD72FB0", Offset = "0xD723B0", VA = "0x180D72FB0")]
	public NDHNGFOGLOL(bool EICEALMGHNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
public sealed class PDLKJKANJMO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F8F7C0", Offset = "0x6F8EBC0", VA = "0x186F8F7C0")]
	public PDLKJKANJMO(bool EICEALMGHNI, string MOAMCEKIJBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.All)]
public class NEHMDNJAMFB : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly string MMFJONPJLOH;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x881BC0", Offset = "0x880FC0", VA = "0x180881BC0")]
	public NEHMDNJAMFB(string ACGAMIEDLEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class IIJBDOJKHBB
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class LHONANOJJDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public Task selfInternal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Exception <ex>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public LHONANOJJDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6F8DA80", Offset = "0x6F8CE80", VA = "0x186F8DA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D410", Offset = "0x6F8C810", VA = "0x186F8D410")]
	public static Task<TaskStatus> FMIDODNPPII(this Task LGKAJJKAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x29BC2B0", Offset = "0x29BB6B0", VA = "0x1829BC2B0")]
	public static Task<T> DNHHHKAOCGA<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D560", Offset = "0x6F8C960", VA = "0x186F8D560")]
	public static Task MCDKFKJMOAD(this Task AFHGFPNANEH, CancellationToken IJNLJGNNJFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x29BCEB0", Offset = "0x29BC2B0", VA = "0x1829BCEB0")]
	public static Task<TResult> MCDKFKJMOAD<TResult>(this Task<TResult> AFHGFPNANEH, CancellationToken IJNLJGNNJFA) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D2C0", Offset = "0x6F8C6C0", VA = "0x186F8D2C0")]
	[DebuggerStepThrough]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(LHONANOJJDG))]
	internal static Task<TaskStatus> FBKINNBGDMD(Task OPBODIMPKBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LKIAJBAFEJJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	TimeSpan BFPBCHIFJIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Action? PCNCBMPPCMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HEAHMDNBJFC();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MJJIADCBGBF();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BMKMOHAKHFJ();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct MDDKMKAKMAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly string DEMEBAENMIP;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0xB8F880", Offset = "0xB8EC80", VA = "0x180B8F880")]
	public MDDKMKAKMAN(string EOEKGHMNIDN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x854A20", Offset = "0x853E20", VA = "0x180854A20")]
	public static string ILINJACDGKH(in MDDKMKAKMAN LGKAJJKAMAG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x15726C0", Offset = "0x1571AC0", VA = "0x1815726C0")]
	public static MDDKMKAKMAN ILINJACDGKH(string CCJMBGJFGLH)
	{
		return default(MDDKMKAKMAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E440", Offset = "0x6F8D840", VA = "0x186F8E440")]
	public string MBFKHCKGDPM(string KBPNDAMNPEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E490", Offset = "0x6F8D890", VA = "0x186F8E490")]
	public string PBENBGFMIIE(object BPHFJOJKBBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x854A20", Offset = "0x853E20", VA = "0x180854A20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct JIAHEONOOCJ<T> : IEquatable<global::JIAHEONOOCJ<T>>, global::KDMGKNEFMID<global::JIAHEONOOCJ<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly T DEMEBAENMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly int BEOOPJIPEDJ;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x15752A0", Offset = "0x15746A0", VA = "0x1815752A0")]
	public JIAHEONOOCJ(in T EOEKGHMNIDN, int CJOLACIBAJH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3083950", Offset = "0x3082D50", VA = "0x183083950")]
	public static bool MHCPIEGNOBB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B94A0", Offset = "0x7B88A0")] in global::JIAHEONOOCJ<T> BJDJCEOCPLA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B9510", Offset = "0x7B8910")] in global::JIAHEONOOCJ<T> LGGFOIJEFNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x30831B0", Offset = "0x30825B0", VA = "0x1830831B0", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B9580", Offset = "0x7B8980")] global::JIAHEONOOCJ<T> CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3083240", Offset = "0x3082640", VA = "0x183083240", Slot = "0")]
	public override bool Equals(object CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3083120", Offset = "0x3082520", VA = "0x183083120")]
	public bool BINBLAKLHFD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B95E0", Offset = "0x7B89E0")] in global::JIAHEONOOCJ<T> CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3083520", Offset = "0x3082920", VA = "0x183083520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x30846D0", Offset = "0x3083AD0", VA = "0x1830846D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3083F80", Offset = "0x3083380", VA = "0x183083F80")]
	public void PIEPGKNGNEP(out T EOEKGHMNIDN, out int CJOLACIBAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3082EA0", Offset = "0x30822A0", VA = "0x183082EA0")]
	public (T, int) BELDNHHPBLM()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3082D10", Offset = "0x3082110", VA = "0x183082D10", Slot = "5")]
	private bool AIIJKBDGGLH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B9650", Offset = "0x7B8A50")] in global::JIAHEONOOCJ<T> CCJMBGJFGLH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class KDBJODEGMCO
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2CF9380", Offset = "0x2CF8780", VA = "0x182CF9380")]
	public static global::JIAHEONOOCJ<T> FHHJOGLDILM<T>(in T EOEKGHMNIDN, int CJOLACIBAJH) where T : notnull
	{
		return default(global::JIAHEONOOCJ<T>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct CPKDLGGKAMN : IEquatable<CPKDLGGKAMN>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x811730", Offset = "0x810B30", VA = "0x180811730", Slot = "4")]
	public bool Equals(CPKDLGGKAMN CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D180", Offset = "0x6F8C580", VA = "0x186F8D180", Slot = "0")]
	public override bool Equals(object CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D1D0", Offset = "0x6F8C5D0", VA = "0x186F8D1D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D1E0", Offset = "0x6F8C5E0", VA = "0x186F8D1E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct PKLJNKKJOAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly PPMGOFKHNAI LJLACNOHCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly LEBHPFKIBBD KEJDLGMFFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly IJCDDJMOBOJ OHHGIDMAGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly JEDPFIIBKFI NEJDCGIDIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly PBOPAMDNGFL OIOBBDHLMAB;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly IJCDDJMOBOJ OIOLMADMJMI;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly JEDPFIIBKFI GIPLPHGOEMF;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly PBOPAMDNGFL KBAFMNACIBK;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly PKLJNKKJOAI LCFFDKCHEPM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool IMMNJJKMOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6F8F8A0", Offset = "0x6F8ECA0", VA = "0x186F8F8A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6F8FE70", Offset = "0x6F8F270", VA = "0x186F8FE70")]
	public PKLJNKKJOAI(in PPMGOFKHNAI BMHONMGKCIK, in LEBHPFKIBBD NEJCCPPIGHI, IJCDDJMOBOJ JOPCKJLCOIC, JEDPFIIBKFI DDABEOOOAPJ, PBOPAMDNGFL ACHGGDPFBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6F8F9E0", Offset = "0x6F8EDE0", VA = "0x186F8F9E0")]
	private static string HLMDFIADHEI(object GHHNOPFOGCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7F1D90", Offset = "0x7F1190", VA = "0x1807F1D90")]
	private static long LANPBMACNPH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x991BC0", Offset = "0x990FC0", VA = "0x180991BC0")]
	private static string KAMJAACMPKG(string NEMKEJKFJAE, string? IEFFFOCHLLF, bool LDNGCGEKHLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6F8FA20", Offset = "0x6F8EE20", VA = "0x186F8FA20")]
	private static PKLJNKKJOAI KFBJHMMNMBB()
	{
		return default(PKLJNKKJOAI);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct BCDEPNCKPGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public ulong KJBNOGMJFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public long OMAJMLLEGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public double GEPBBJOLKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public uint KIMPLFFLDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public uint HHDDIKCCEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public int IBJCMFEMJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public int FJICDAJIIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float LOLKIJKGJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float DHCCDNKHCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public ushort BKACMMJLPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public ushort DBPLKMDDIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public ushort OOLNEFFFHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public ushort MGPLKFBEODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public short AIBGFMMDCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public short LPKBJGADIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public short PIBEKEDFGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public short KPMHJEFAAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public char LNHPBDFEGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public char GCPNPMNNCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public char PCJLLHMDMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public char IDBJOLPFGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public byte BJJHLCNMCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public byte OOGIBLIAKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public byte MMGNNMHOIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public byte JJAOJKHELGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte PILBMHJIDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public byte CBLMPDHEJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public byte JCCCAJIHHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public byte EOMOKIJCAGC;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D120", Offset = "0x6F8C520", VA = "0x186F8D120")]
	public static BCDEPNCKPGJ FHHJOGLDILM(byte CAENFOFFIBL, byte LBPBCKCCBPP, byte JKGEBNFHANJ, byte ADNPNMMGNJM, byte KMMACCJKMFH, byte BCBGLFBHKLD, byte ONOCKHMANEJ, byte BJNGOEOFOHC)
	{
		return default(BCDEPNCKPGJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct PPMGOFKHNAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly BGBDKCFGDPF ADGEIJEKCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly BJICIPLFLBL DLMKAILNCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly BGBDKCFGDPF NAEGFHKPJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly BJICIPLFLBL ENLIACLLDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly BGBDKCFGDPF PCEDJINAJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly BJICIPLFLBL APCNLEEGMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly OAEOOILNFFL PAALFILGFLJ;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly BGBDKCFGDPF DGBCFFPLHEN;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly BJICIPLFLBL OOOAEHDPEMM;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly BGBDKCFGDPF KMLIEDPKAEH;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly BJICIPLFLBL CIMAJHFLHJO;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly BGBDKCFGDPF OPCPMFFBGMC;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly BJICIPLFLBL ACBDEFLMHNO;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly OAEOOILNFFL CLKALIICLKC;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly PPMGOFKHNAI LCFFDKCHEPM;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly BGBDKCFGDPF FMHILDDLJKC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool IMMNJJKMOPK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6F8FF70", Offset = "0x6F8F370", VA = "0x186F8FF70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1994F50", Offset = "0x1994350", VA = "0x181994F50")]
	public PPMGOFKHNAI(BGBDKCFGDPF GFDEGMLKELM, BJICIPLFLBL OLPALKKDEBG, BGBDKCFGDPF HJGNAANKMLK, BJICIPLFLBL GCKBGEFNBDB, BGBDKCFGDPF GOJJJCCOMPO, BJICIPLFLBL NIDMOMJDPGF, OAEOOILNFFL CCABDCLKFAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7FB3B0", Offset = "0x7FA7B0", VA = "0x1807FB3B0")]
	private static bool GGLLIHCJDKH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
	private static void PIPOEICKCDC(string HGJOENLBDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7FB3B0", Offset = "0x7FA7B0", VA = "0x1807FB3B0")]
	private static bool BPGNMDEAMCG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
	private static void IPECFAMGGCI(string HGJOENLBDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7FB3B0", Offset = "0x7FA7B0", VA = "0x1807FB3B0")]
	private static bool CBODNDECJPK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
	private static void AFGBADHFDCI(string HGJOENLBDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
	private static void JKGHGOLIFML(Exception AIDLJEMJKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6F901B0", Offset = "0x6F8F5B0", VA = "0x186F901B0")]
	private static PPMGOFKHNAI KFBJHMMNMBB()
	{
		return default(PPMGOFKHNAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x811730", Offset = "0x810B30", VA = "0x180811730")]
	private static bool HBMCPNOLJOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6F90390", Offset = "0x6F8F790", VA = "0x186F90390")]
	public void OGCEGKIJJAP(object HGJOENLBDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6F8FF00", Offset = "0x6F8F300", VA = "0x186F8FF00")]
	public void ACMGBHDAFDO(object HGJOENLBDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F902F0", Offset = "0x6F8F6F0", VA = "0x186F902F0")]
	public void LPLAGMIJFFD(Exception AIDLJEMJKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x24E0E90", Offset = "0x24E0290", VA = "0x1824E0E90")]
	public void ACMGBHDAFDO<T>(T GNIDPCMALKM, global::IJMINPDGPIO<T> HGJOENLBDNH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x24E0F10", Offset = "0x24E0310", VA = "0x1824E0F10")]
	public void OGCEGKIJJAP<T>(in T GNIDPCMALKM, global::NMNNKHJCCNP<T> HGJOENLBDNH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6F90310", Offset = "0x6F8F710", VA = "0x186F90310")]
	public bool NPDEEIAHAGL(bool BLFNHGEHPOE, string HGJOENLBDNH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class EFPJKACIEFE
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x24D99E0", Offset = "0x24D8DE0", VA = "0x1824D99E0")]
	public static IEnumerable<T> FNHMJDKBEND<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x991BC0", Offset = "0x990FC0", VA = "0x180991BC0")]
	public static T[] AAJAANOPOLC<T>(params T[] AFBEOJLPDNH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x991BC0", Offset = "0x990FC0", VA = "0x180991BC0")]
	public static IEnumerable<T> LPLMCPBKABO<T>(params T[] AFBEOJLPDNH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1A4C830", Offset = "0x1A4BC30", VA = "0x181A4C830")]
	public static HashSet<T> FBDOPLCELKE<T>(params T[] AFBEOJLPDNH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x32EF840", Offset = "0x32EEC40", VA = "0x1832EF840")]
	public static KeyValuePair<TKey, TValue> BHEFMNOIOAI<TKey, TValue>(in TKey LOLIOKKJLEH, in TValue EOEKGHMNIDN) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1A4C830", Offset = "0x1A4BC30", VA = "0x181A4C830")]
	public static List<T> BJKLOMCPEAH<T>(IEnumerable<T> OGHMIAGGFBJ) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[AttributeUsage(AttributeTargets.All)]
public sealed class IMGMHPOMEBN : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly string FFBHIGFEAAD;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x881BC0", Offset = "0x880FC0", VA = "0x180881BC0")]
	public IMGMHPOMEBN(string PHMNLFAHIGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class NEAIEILIHMG
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2915840", Offset = "0x2914C40", VA = "0x182915840")]
	public static MDDKMKAKMAN LECAJMIHMKE<T>()
	{
		return default(MDDKMKAKMAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2915560", Offset = "0x2914960", VA = "0x182915560")]
	public static MDDKMKAKMAN IGLONDNPCMM<T>([CallerMemberName] string LMAOKJPAKEM = "") where T : notnull
	{
		return default(MDDKMKAKMAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x29157B0", Offset = "0x2914BB0", VA = "0x1829157B0")]
	public static MDDKMKAKMAN LECAJMIHMKE<T>(this T OGBFKHOJHOO) where T : notnull
	{
		return default(MDDKMKAKMAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x29153E0", Offset = "0x29147E0", VA = "0x1829153E0")]
	public static MDDKMKAKMAN EJONBBFDNPP<T>(this T OGBFKHOJHOO, [CallerMemberName] string LMAOKJPAKEM = "") where T : notnull
	{
		return default(MDDKMKAKMAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x29155F0", Offset = "0x29149F0", VA = "0x1829155F0")]
	public static MDDKMKAKMAN IGLONDNPCMM<T>(this T LGKAJJKAMAG, [CallerMemberName] string LMAOKJPAKEM = "") where T : notnull
	{
		return default(MDDKMKAKMAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E590", Offset = "0x6F8D990", VA = "0x186F8E590")]
	public static MDDKMKAKMAN IGLONDNPCMM(string FEJOBIPGGLF, [CallerMemberName] string LMAOKJPAKEM = "")
	{
		return default(MDDKMKAKMAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E610", Offset = "0x6F8DA10", VA = "0x186F8E610")]
	public static string MGALLNDDOOA(this object LGKAJJKAMAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[MIAPNFJCKKI]
public delegate long JEDPFIIBKFI();
[Cpp2IlInjected.Token(Token = "0x2000019")]
public delegate void PACGJIFEBOI<T>(in T GNIDPCMALKM);
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class LIFEBGGOGIK
{
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static PKLJNKKJOAI CMJCMDGIDCB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static PKLJNKKJOAI EFFOAOPKFGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6F8DD80", Offset = "0x6F8D180", VA = "0x186F8DD80")]
		get
		{
			return default(PKLJNKKJOAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static PPMGOFKHNAI LJLACNOHCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6F8DD20", Offset = "0x6F8D120", VA = "0x186F8DD20")]
		get
		{
			return default(PPMGOFKHNAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static LEBHPFKIBBD KEJDLGMFFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6F8E240", Offset = "0x6F8D640", VA = "0x186F8E240")]
		get
		{
			return default(LEBHPFKIBBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DE50", Offset = "0x6F8D250", VA = "0x186F8DE50")]
	public static void KNMLNKCCCFI(in PKLJNKKJOAI KHLLACKHAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E190", Offset = "0x6F8D590", VA = "0x186F8E190")]
	public static void OGCEGKIJJAP(string HGJOENLBDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DC70", Offset = "0x6F8D070", VA = "0x186F8DC70")]
	public static void ACMGBHDAFDO(string HGJOENLBDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3027380", Offset = "0x3026780", VA = "0x183027380")]
	public static void ACMGBHDAFDO<T>(T GNIDPCMALKM, global::IJMINPDGPIO<T> HGJOENLBDNH) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DFB0", Offset = "0x6F8D3B0", VA = "0x186F8DFB0")]
	public static void LPLAGMIJFFD(Exception AIDLJEMJKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E030", Offset = "0x6F8D430", VA = "0x186F8E030")]
	public static string MGALLNDDOOA(object GHHNOPFOGCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6F8DDE0", Offset = "0x6F8D1E0", VA = "0x186F8DDE0")]
	public static long JNDCKOBGKDM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E0B0", Offset = "0x6F8D4B0", VA = "0x186F8E0B0")]
	public static bool NPDEEIAHAGL(bool BLFNHGEHPOE, string HGJOENLBDNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E2A0", Offset = "0x6F8D6A0", VA = "0x186F8E2A0")]
	public static double OMJAEOELJIC()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class HOFOIFECGJK : BBLJDIINEFL
{
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly BBLJDIINEFL BGHJOACDLLH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DateTime MBPOLEJNNFN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6F8D210", Offset = "0x6F8C610", VA = "0x186F8D210", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public HOFOIFECGJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate)]
public class MIAPNFJCKKI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80DE80", VA = "0x18080EA80")]
	public MIAPNFJCKKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public delegate TResult PJKMOJHEJMC<T, out TResult>(in T GNIDPCMALKM);
[Cpp2IlInjected.Token(Token = "0x200001E")]
public delegate TResult GCFGAHBKMED<T1, T2, out TResult>(in T1 KCPBLAMEMIJ, in T2 OMHNDNFHNAP);
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class NJBFBNLBDAO : LKIAJBAFEJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly TimeSpan AHIMGBJDPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly System.Timers.Timer JLHLJFGHKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private TimeSpan KGMNGICIPNF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public TimeSpan BFPBCHIFJIN
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x855AE0", Offset = "0x854EE0", VA = "0x180855AE0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6F8E8C0", Offset = "0x6F8DCC0", VA = "0x186F8E8C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Action? PCNCBMPPCMA
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x856480", Offset = "0x855880", VA = "0x180856480", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x87D040", Offset = "0x87C440", VA = "0x18087D040", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EA80", Offset = "0x6F8DE80", VA = "0x186F8EA80")]
	[Preserve]
	public NJBFBNLBDAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EAF0", Offset = "0x6F8DEF0", VA = "0x186F8EAF0")]
	public NJBFBNLBDAO(TimeSpan KGMNGICIPNF, [Optional] Action? EAJEOCAKLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E820", Offset = "0x6F8DC20", VA = "0x186F8E820", Slot = "7")]
	public void HEAHMDNBJFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E880", Offset = "0x6F8DC80", VA = "0x186F8E880", Slot = "8")]
	public void MJJIADCBGBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E6D0", Offset = "0x6F8DAD0", VA = "0x186F8E6D0", Slot = "9")]
	public void BMKMOHAKHFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x180C610", Offset = "0x180BA10", VA = "0x18180C610")]
	private void MNEDBBFEDOP(object OGBFKHOJHOO, ElapsedEventArgs MKCBPHPONGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E700", Offset = "0x6F8DB00", VA = "0x186F8E700")]
	private static void DDKLBDDNMJO(ref TimeSpan JABGBGLELFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6F8E780", Offset = "0x6F8DB80", VA = "0x186F8E780", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[AttributeUsage(AttributeTargets.Class)]
public class HNGHGBCLJCP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80DE80", VA = "0x18080EA80")]
	public HNGHGBCLJCP()
	{
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80DE80", VA = "0x18080EA80")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
public class INHHDNKJHCF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80DE80", VA = "0x18080EA80")]
	public INHHDNKJHCF(string OGPMEEOMEND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface BBLJDIINEFL
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DateTime MBPOLEJNNFN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct BBJLBDPLDLP : IEquatable<BBJLBDPLDLP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public uint PGBFHHGKFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int HPFNNFKOEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public float OCOBMMIPHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public ushort BKACMMJLPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public ushort DBPLKMDDIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public short AIBGFMMDCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public short LPKBJGADIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public char LNHPBDFEGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public char GCPNPMNNCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public byte BJJHLCNMCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public byte OOGIBLIAKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public byte MMGNNMHOIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public byte JJAOJKHELGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public bool AKOHBNICLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public bool ALIELMBDBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool BPHBBLJMEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public bool LFAOIINDLNB;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xB46270", Offset = "0xB45670", VA = "0x180B46270")]
	public static BBJLBDPLDLP GLFHBLLNJIJ(uint PCKCAENKMFP)
	{
		return default(BBJLBDPLDLP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0xB46270", Offset = "0xB45670", VA = "0x180B46270")]
	public static BBJLBDPLDLP ACFCEOEHPBC(int PPCHCPIAAJK)
	{
		return default(BBJLBDPLDLP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x12301F0", Offset = "0x122F5F0", VA = "0x1812301F0")]
	public static BBJLBDPLDLP DNPNJHCIAMH(float OOOFKINPILO)
	{
		return default(BBJLBDPLDLP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C180", Offset = "0x6F8B580", VA = "0x186F8C180")]
	public static BBJLBDPLDLP JCGJOADPIOE(byte CAENFOFFIBL, byte LBPBCKCCBPP, byte JKGEBNFHANJ, byte ADNPNMMGNJM)
	{
		return default(BBJLBDPLDLP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C180", Offset = "0x6F8B580", VA = "0x186F8C180")]
	public static BBJLBDPLDLP FFKGFNDADAD(bool LDFDPHMLMDC, bool KPGMGLKCBII, bool MJCBPAGMAKB, bool IPOAGFJIGMJ)
	{
		return default(BBJLBDPLDLP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x578A9B0", Offset = "0x5789DB0", VA = "0x18578A9B0")]
	public static bool MHCPIEGNOBB(BBJLBDPLDLP JMFOJDPECFB, BBJLBDPLDLP PHAPIDHPFME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xB446B0", Offset = "0xB43AB0", VA = "0x180B446B0", Slot = "4")]
	public bool Equals(BBJLBDPLDLP CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C0F0", Offset = "0x6F8B4F0", VA = "0x186F8C0F0", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xD6AB80", Offset = "0xD69F80", VA = "0x180D6AB80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6F8C1A0", Offset = "0x6F8B5A0", VA = "0x186F8C1A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[NEHMDNJAMFB("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct JIPMFFHDKLF<T> : IEquatable<global::JIPMFFHDKLF<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public readonly T DEMEBAENMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly bool FJLFIPNKMDK;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool FNEEIAAEKBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3085A80", Offset = "0x3084E80", VA = "0x183085A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3086630", Offset = "0x3085A30", VA = "0x183086630")]
	public JIPMFFHDKLF(in T EOEKGHMNIDN, bool HOHIBELPHJL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3085AA0", Offset = "0x3084EA0", VA = "0x183085AA0")]
	public static bool MHCPIEGNOBB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B99C0", Offset = "0x7B8DC0")] in global::JIPMFFHDKLF<T> BJDJCEOCPLA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B9A30", Offset = "0x7B8E30")] in global::JIPMFFHDKLF<T> LGGFOIJEFNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x30832D0", Offset = "0x30826D0", VA = "0x1830832D0", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B9AA0", Offset = "0x7B8EA0")] global::JIPMFFHDKLF<T> CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3085440", Offset = "0x3084840", VA = "0x183085440", Slot = "0")]
	public override bool Equals(object CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x30856B0", Offset = "0x3084AB0", VA = "0x1830856B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3086180", Offset = "0x3085580", VA = "0x183086180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class DLAPEIEBHEB
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3E0BF00", Offset = "0x3E0B300", VA = "0x183E0BF00")]
	public static global::JIPMFFHDKLF<T> NIFPAMONKGN<T>(in T EOEKGHMNIDN) where T : notnull
	{
		return default(global::JIPMFFHDKLF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3E0C010", Offset = "0x3E0B410", VA = "0x183E0C010")]
	public static global::JIPMFFHDKLF<T?> OOGBNCGHPJK<T>()
	{
		return default(global::JIPMFFHDKLF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3E0BEA0", Offset = "0x3E0B2A0", VA = "0x183E0BEA0")]
	public static bool FGHHACKCLBL<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7B9B40", Offset = "0x7B8F40")] this in global::JIPMFFHDKLF<T> ICOLICNBPEA, [JGAMJCFKCDP(true)] out T EOEKGHMNIDN) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface KDMGKNEFMID<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BINBLAKLHFD(in T CCJMBGJFGLH);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct LEBHPFKIBBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public readonly HJLDBMNMNLF BBJFNDLLNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly AMENAMMFFHP IOHPCIEPEDN;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly HJLDBMNMNLF BNCGGHFLLEH;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly AMENAMMFFHP PCDDHPMJJGJ;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly LEBHPFKIBBD LCFFDKCHEPM;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool IMMNJJKMOPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F8D790", Offset = "0x6F8CB90", VA = "0x186F8D790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xA1F0E0", Offset = "0xA1E4E0", VA = "0x180A1F0E0")]
	public LEBHPFKIBBD(HJLDBMNMNLF JPBPPDKPJCD, AMENAMMFFHP CCCGKBIMEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
	private static void NPKMJMMCCMK(string LMAOKJPAKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70")]
	private static void PBKHJKIJKNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6F8D860", Offset = "0x6F8CC60", VA = "0x186F8D860")]
	private static LEBHPFKIBBD KFBJHMMNMBB()
	{
		return default(LEBHPFKIBBD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class HGDAHADKNPN
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x29A5C60", Offset = "0x29A5060", VA = "0x1829A5C60")]
	public static bool BINBLAKLHFD<T, U>(in T LGKAJJKAMAG, in U GHHNOPFOGCC) where T : notnull, global::KDMGKNEFMID<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class KKHMJOEKIJI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly EqualityComparer<T> GDFNFCKMKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public T DEMEBAENMIP;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x42F32F0", Offset = "0x42F26F0", VA = "0x1842F32F0")]
	public KKHMJOEKIJI(in T EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x42F2890", Offset = "0x42F1C90", VA = "0x1842F2890", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x42F2F10", Offset = "0x42F2310", VA = "0x1842F2F10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x42F2F80", Offset = "0x42F2380", VA = "0x1842F2F80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class OJNEMDCGOLL
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static long GJFPLLNKLDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6F8F1E0", Offset = "0x6F8E5E0", VA = "0x186F8F1E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static long PCMBHBKCMEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EEC0", Offset = "0x6F8E2C0", VA = "0x186F8EEC0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static double MALOLHPPKEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F8F360", Offset = "0x6F8E760", VA = "0x186F8F360")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static double LHOFHOLNALM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EF20", Offset = "0x6F8E320", VA = "0x186F8EF20")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static double GLNKPCJPMAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6F8F3C0", Offset = "0x6F8E7C0", VA = "0x186F8F3C0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static double OHKBILAAOMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EE50", Offset = "0x6F8E250", VA = "0x186F8EE50")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EDA0", Offset = "0x6F8E1A0", VA = "0x186F8EDA0")]
	public static double AEJIJDHOCFM(long PBLABMJELFF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EF80", Offset = "0x6F8E380", VA = "0x186F8EF80")]
	public static double FIDMBCLFADC(long PBLABMJELFF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F8F240", Offset = "0x6F8E640", VA = "0x186F8F240")]
	public static double MOENDMAHCGJ(double IBEMFEENAJG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6F8F030", Offset = "0x6F8E430", VA = "0x186F8F030")]
	public static long HBOKCMIAJDG(long BLFHJAPLEGL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EEB0", Offset = "0x6F8E2B0", VA = "0x186F8EEB0")]
	public static long ALFPNLBDMLJ(long DMCNDPFBMHI, long JCLEAGDGFPA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6F8F0E0", Offset = "0x6F8E4E0", VA = "0x186F8F0E0")]
	public static double HOOGMJGNJJF(long DMCNDPFBMHI, long JCLEAGDGFPA)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6F8F2F0", Offset = "0x6F8E6F0", VA = "0x186F8F2F0")]
	public static double NHAIBDDPDBJ(long DMCNDPFBMHI, long JCLEAGDGFPA)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[MIAPNFJCKKI]
public delegate void BJICIPLFLBL(string HGJOENLBDNH);
[Cpp2IlInjected.Token(Token = "0x200002D")]
[MIAPNFJCKKI]
public delegate string IJCDDJMOBOJ(object GHHNOPFOGCC);
[Cpp2IlInjected.Token(Token = "0x200002E")]
[MIAPNFJCKKI]
public delegate void AMENAMMFFHP();
[Cpp2IlInjected.Token(Token = "0x200002F")]
public delegate object NMNNKHJCCNP<T>(in T KBOOOAILJFG);
[Cpp2IlInjected.Token(Token = "0x2000030")]
public delegate object ADGNPLIAILH();
[Cpp2IlInjected.Token(Token = "0x2000031")]
[MIAPNFJCKKI]
public delegate string PBOPAMDNGFL(string NEMKEJKFJAE, string? IEFFFOCHLLF, bool LDNGCGEKHLK);
[Cpp2IlInjected.Token(Token = "0x2000032")]
[MIAPNFJCKKI]
public delegate bool BGBDKCFGDPF();
[Cpp2IlInjected.Token(Token = "0x2000033")]
public delegate object IJMINPDGPIO<T>(T KBOOOAILJFG);
[Cpp2IlInjected.Token(Token = "0x2000034")]
[MIAPNFJCKKI]
public delegate void HJLDBMNMNLF(string LMAOKJPAKEM);
[Cpp2IlInjected.Token(Token = "0x2000035")]
[MIAPNFJCKKI]
public delegate void OAEOOILNFFL(Exception AIDLJEMJKAK);
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
