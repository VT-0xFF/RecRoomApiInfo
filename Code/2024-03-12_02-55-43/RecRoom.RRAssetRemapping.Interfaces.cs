using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.DataStructures;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7E57E0", Offset = "0x7E49E0", VA = "0x1807E57E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6773520", Offset = "0x6772720", VA = "0x186773520")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E5C40", Offset = "0x7E4E40", VA = "0x1807E5C40")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E5C80", Offset = "0x7E4E80", VA = "0x1807E5C80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MFIKMPADHPL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string CJMGAEMJONM(DFKLECHGIGF NKIKIMMJFMI);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DFKLECHGIGF APPDJDLGIOH(string NKIKIMMJFMI);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct DFKLECHGIGF : IEquatable<DFKLECHGIGF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly PDIIDNCDDGN JMJDLCNJBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly EKDOJINKEPA JDLPIGGKDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly Guid KJIMHJIGAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly RRColor? DMPIFNGMOHI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool NKMAIHCKPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6771B60", Offset = "0x6770D60", VA = "0x186771B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool PNGLEFPHAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6771C20", Offset = "0x6770E20", VA = "0x186771C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6772060", Offset = "0x6771260", VA = "0x186772060")]
	public DFKLECHGIGF(DFKLECHGIGF MLEDDICOLKD, [Optional] Guid INKPDPBADLC, [Optional] RRColor? DKDNEEAJCMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x67720F0", Offset = "0x67712F0", VA = "0x1867720F0")]
	public DFKLECHGIGF(PDIIDNCDDGN EIONKCLFADO, EKDOJINKEPA DGEHJADDFIB, [Optional] Guid INKPDPBADLC, [Optional] RRColor? DKDNEEAJCMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6771880", Offset = "0x6770A80", VA = "0x186771880", Slot = "4")]
	public bool Equals(DFKLECHGIGF NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6771980", Offset = "0x6770B80", VA = "0x186771980", Slot = "0")]
	public override bool Equals(object MFLACBLODGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6771A70", Offset = "0x6770C70", VA = "0x186771A70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x67717A0", Offset = "0x67709A0", VA = "0x1867717A0")]
	public static bool CDBCKLPENDN(DFKLECHGIGF GNBALBEAIKA, DFKLECHGIGF ODFCMCFCPMH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6771810", Offset = "0x6770A10", VA = "0x186771810")]
	public static bool DFHJMIKFMMI(DFKLECHGIGF GNBALBEAIKA, DFKLECHGIGF ODFCMCFCPMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6771C60", Offset = "0x6770E60", VA = "0x186771C60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct PDIIDNCDDGN : IEquatable<PDIIDNCDDGN>, IComparable<PDIIDNCDDGN>, IAIMFIMOFPD
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly PDIIDNCDDGN LNBIPJDBGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Guid OHJPHHKPEGL;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1DC10D0", Offset = "0x1DC02D0", VA = "0x181DC10D0")]
	public PDIIDNCDDGN(Guid OHJPHHKPEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x88BDD0", Offset = "0x88AFD0", VA = "0x18088BDD0", Slot = "6")]
	public Guid OBELGBODBJN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFE90", Offset = "0x3AAF090", VA = "0x183AAFE90", Slot = "4")]
	public bool Equals(PDIIDNCDDGN NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFCC0", Offset = "0x3AAEEC0", VA = "0x183AAFCC0", Slot = "5")]
	public int CompareTo(PDIIDNCDDGN NFMPGFPPFKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x67735A0", Offset = "0x67727A0", VA = "0x1867735A0", Slot = "0")]
	public override bool Equals(object MFLACBLODGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFE70", Offset = "0x3AAF070", VA = "0x183AAFE70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFE90", Offset = "0x3AAF090", VA = "0x183AAFE90")]
	public static bool CDBCKLPENDN(PDIIDNCDDGN GNBALBEAIKA, PDIIDNCDDGN ODFCMCFCPMH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6772180", Offset = "0x6771380", VA = "0x186772180")]
	public static bool DFHJMIKFMMI(PDIIDNCDDGN GNBALBEAIKA, PDIIDNCDDGN ODFCMCFCPMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6773640", Offset = "0x6772840", VA = "0x186773640", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct KIEOGEFBNEF : IEquatable<KIEOGEFBNEF>, IComparable<KIEOGEFBNEF>, IAIMFIMOFPD
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly KIEOGEFBNEF LNBIPJDBGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Guid OHJPHHKPEGL;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1DC10D0", Offset = "0x1DC02D0", VA = "0x181DC10D0")]
	public KIEOGEFBNEF(Guid OHJPHHKPEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x88BDD0", Offset = "0x88AFD0", VA = "0x18088BDD0", Slot = "6")]
	public Guid OBELGBODBJN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFE90", Offset = "0x3AAF090", VA = "0x183AAFE90", Slot = "4")]
	public bool Equals(KIEOGEFBNEF NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFCC0", Offset = "0x3AAEEC0", VA = "0x183AAFCC0", Slot = "5")]
	public int CompareTo(KIEOGEFBNEF NFMPGFPPFKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x67730E0", Offset = "0x67722E0", VA = "0x1867730E0", Slot = "0")]
	public override bool Equals(object MFLACBLODGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFE70", Offset = "0x3AAF070", VA = "0x183AAFE70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFE90", Offset = "0x3AAF090", VA = "0x183AAFE90")]
	public static bool CDBCKLPENDN(KIEOGEFBNEF GNBALBEAIKA, KIEOGEFBNEF ODFCMCFCPMH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6772180", Offset = "0x6771380", VA = "0x186772180")]
	public static bool DFHJMIKFMMI(KIEOGEFBNEF GNBALBEAIKA, KIEOGEFBNEF ODFCMCFCPMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6773180", Offset = "0x6772380", VA = "0x186773180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct NBAEPOOLOKD : IEquatable<NBAEPOOLOKD>, IComparable<NBAEPOOLOKD>, IAIMFIMOFPD
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly NBAEPOOLOKD LNBIPJDBGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Guid OHJPHHKPEGL;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1DC10D0", Offset = "0x1DC02D0", VA = "0x181DC10D0")]
	public NBAEPOOLOKD(Guid OHJPHHKPEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x88BDD0", Offset = "0x88AFD0", VA = "0x18088BDD0", Slot = "6")]
	public Guid OBELGBODBJN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFE90", Offset = "0x3AAF090", VA = "0x183AAFE90", Slot = "4")]
	public bool Equals(NBAEPOOLOKD NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFCC0", Offset = "0x3AAEEC0", VA = "0x183AAFCC0", Slot = "5")]
	public int CompareTo(NBAEPOOLOKD NFMPGFPPFKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6773300", Offset = "0x6772500", VA = "0x186773300", Slot = "0")]
	public override bool Equals(object MFLACBLODGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFE70", Offset = "0x3AAF070", VA = "0x183AAFE70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFE90", Offset = "0x3AAF090", VA = "0x183AAFE90")]
	public static bool CDBCKLPENDN(NBAEPOOLOKD GNBALBEAIKA, NBAEPOOLOKD ODFCMCFCPMH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6772180", Offset = "0x6771380", VA = "0x186772180")]
	public static bool DFHJMIKFMMI(NBAEPOOLOKD GNBALBEAIKA, NBAEPOOLOKD ODFCMCFCPMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x67733A0", Offset = "0x67725A0", VA = "0x1867733A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct EKDOJINKEPA : IEquatable<EKDOJINKEPA>, IComparable<EKDOJINKEPA>, IAIMFIMOFPD
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly EKDOJINKEPA LNBIPJDBGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly Guid OHJPHHKPEGL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public DFAGJJAKBLE BNODNAPNCJH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8507D0", Offset = "0x84F9D0", VA = "0x1808507D0")]
		[CompilerGenerated]
		get
		{
			return default(DFAGJJAKBLE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public DFAGJJAKBLE JOGFMGGJKDA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x106E0D0", Offset = "0x106D2D0", VA = "0x18106E0D0")]
		[CompilerGenerated]
		get
		{
			return default(DFAGJJAKBLE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public DFAGJJAKBLE ICMABBOIKCE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xED77D0", Offset = "0xED69D0", VA = "0x180ED77D0")]
		[CompilerGenerated]
		get
		{
			return default(DFAGJJAKBLE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x88BDD0", Offset = "0x88AFD0", VA = "0x18088BDD0", Slot = "6")]
	public Guid OBELGBODBJN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6772740", Offset = "0x6771940", VA = "0x186772740")]
	public EKDOJINKEPA(Guid OHJPHHKPEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x67726F0", Offset = "0x67718F0", VA = "0x1867726F0")]
	public EKDOJINKEPA(DFAGJJAKBLE JPDKKAGBPDG, DFAGJJAKBLE DGPDFDMPDCA, DFAGJJAKBLE HBEPMEMJJNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6772550", Offset = "0x6771750", VA = "0x186772550")]
	private Guid MOABMPOKECH()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6772520", Offset = "0x6771720", VA = "0x186772520", Slot = "4")]
	public bool Equals(EKDOJINKEPA NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6772470", Offset = "0x6771670", VA = "0x186772470", Slot = "0")]
	public override bool Equals(object MFLACBLODGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFE70", Offset = "0x3AAF070", VA = "0x183AAFE70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x67723B0", Offset = "0x67715B0", VA = "0x1867723B0")]
	public static bool CDBCKLPENDN(EKDOJINKEPA GNBALBEAIKA, EKDOJINKEPA ODFCMCFCPMH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6772430", Offset = "0x6771630", VA = "0x186772430")]
	public static bool DFHJMIKFMMI(EKDOJINKEPA GNBALBEAIKA, EKDOJINKEPA ODFCMCFCPMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x67723F0", Offset = "0x67715F0", VA = "0x1867723F0", Slot = "5")]
	public int CompareTo(EKDOJINKEPA NFMPGFPPFKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6772680", Offset = "0x6771880", VA = "0x186772680", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct LBJMMHJKKBP : IEquatable<LBJMMHJKKBP>, IComparable<LBJMMHJKKBP>, IAIMFIMOFPD
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly LBJMMHJKKBP LNBIPJDBGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly Guid OHJPHHKPEGL;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1DC10D0", Offset = "0x1DC02D0", VA = "0x181DC10D0")]
	public LBJMMHJKKBP(Guid OHJPHHKPEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x88BDD0", Offset = "0x88AFD0", VA = "0x18088BDD0", Slot = "6")]
	public Guid OBELGBODBJN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFE90", Offset = "0x3AAF090", VA = "0x183AAFE90", Slot = "4")]
	public bool Equals(LBJMMHJKKBP NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFCC0", Offset = "0x3AAEEC0", VA = "0x183AAFCC0", Slot = "5")]
	public int CompareTo(LBJMMHJKKBP NFMPGFPPFKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x67731F0", Offset = "0x67723F0", VA = "0x1867731F0", Slot = "0")]
	public override bool Equals(object MFLACBLODGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFE70", Offset = "0x3AAF070", VA = "0x183AAFE70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFE90", Offset = "0x3AAF090", VA = "0x183AAFE90")]
	public static bool CDBCKLPENDN(LBJMMHJKKBP GNBALBEAIKA, LBJMMHJKKBP ODFCMCFCPMH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6772180", Offset = "0x6771380", VA = "0x186772180")]
	public static bool DFHJMIKFMMI(LBJMMHJKKBP GNBALBEAIKA, LBJMMHJKKBP ODFCMCFCPMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6773290", Offset = "0x6772490", VA = "0x186773290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public readonly struct FIGLDHCCOLD : IEquatable<FIGLDHCCOLD>, IComparable<FIGLDHCCOLD>, IAIMFIMOFPD
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly FIGLDHCCOLD LNBIPJDBGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly Guid OHJPHHKPEGL;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1DC10D0", Offset = "0x1DC02D0", VA = "0x181DC10D0")]
	public FIGLDHCCOLD(Guid OHJPHHKPEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x88BDD0", Offset = "0x88AFD0", VA = "0x18088BDD0", Slot = "6")]
	public Guid OBELGBODBJN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFE90", Offset = "0x3AAF090", VA = "0x183AAFE90", Slot = "4")]
	public bool Equals(FIGLDHCCOLD NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFCC0", Offset = "0x3AAEEC0", VA = "0x183AAFCC0", Slot = "5")]
	public int CompareTo(FIGLDHCCOLD NFMPGFPPFKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6772EC0", Offset = "0x67720C0", VA = "0x186772EC0", Slot = "0")]
	public override bool Equals(object MFLACBLODGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFE70", Offset = "0x3AAF070", VA = "0x183AAFE70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFE90", Offset = "0x3AAF090", VA = "0x183AAFE90")]
	public static bool CDBCKLPENDN(FIGLDHCCOLD GNBALBEAIKA, FIGLDHCCOLD ODFCMCFCPMH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6772180", Offset = "0x6771380", VA = "0x186772180")]
	public static bool DFHJMIKFMMI(FIGLDHCCOLD GNBALBEAIKA, FIGLDHCCOLD ODFCMCFCPMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6772F60", Offset = "0x6772160", VA = "0x186772F60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct DGDKEOGIINL : IEquatable<DGDKEOGIINL>, IComparable<DGDKEOGIINL>, IAIMFIMOFPD
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly DGDKEOGIINL LNBIPJDBGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly Guid OHJPHHKPEGL;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1DC10D0", Offset = "0x1DC02D0", VA = "0x181DC10D0")]
	public DGDKEOGIINL(Guid OHJPHHKPEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x88BDD0", Offset = "0x88AFD0", VA = "0x18088BDD0", Slot = "6")]
	public Guid OBELGBODBJN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFE90", Offset = "0x3AAF090", VA = "0x183AAFE90", Slot = "4")]
	public bool Equals(DGDKEOGIINL NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFCC0", Offset = "0x3AAEEC0", VA = "0x183AAFCC0", Slot = "5")]
	public int CompareTo(DGDKEOGIINL NFMPGFPPFKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x67721B0", Offset = "0x67713B0", VA = "0x1867721B0", Slot = "0")]
	public override bool Equals(object MFLACBLODGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFE70", Offset = "0x3AAF070", VA = "0x183AAFE70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFE90", Offset = "0x3AAF090", VA = "0x183AAFE90")]
	public static bool CDBCKLPENDN(DGDKEOGIINL GNBALBEAIKA, DGDKEOGIINL ODFCMCFCPMH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6772180", Offset = "0x6771380", VA = "0x186772180")]
	public static bool DFHJMIKFMMI(DGDKEOGIINL GNBALBEAIKA, DGDKEOGIINL ODFCMCFCPMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6772250", Offset = "0x6771450", VA = "0x186772250", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct NLLCILIPDAL : IEquatable<NLLCILIPDAL>, IComparable<NLLCILIPDAL>, IAIMFIMOFPD
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly NLLCILIPDAL LNBIPJDBGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly Guid OHJPHHKPEGL;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1DC10D0", Offset = "0x1DC02D0", VA = "0x181DC10D0")]
	public NLLCILIPDAL(Guid OHJPHHKPEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x88BDD0", Offset = "0x88AFD0", VA = "0x18088BDD0", Slot = "6")]
	public Guid OBELGBODBJN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFE90", Offset = "0x3AAF090", VA = "0x183AAFE90", Slot = "4")]
	public bool Equals(NLLCILIPDAL NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFCC0", Offset = "0x3AAEEC0", VA = "0x183AAFCC0", Slot = "5")]
	public int CompareTo(NLLCILIPDAL NFMPGFPPFKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6773410", Offset = "0x6772610", VA = "0x186773410", Slot = "0")]
	public override bool Equals(object MFLACBLODGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFE70", Offset = "0x3AAF070", VA = "0x183AAFE70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFE90", Offset = "0x3AAF090", VA = "0x183AAFE90")]
	public static bool CDBCKLPENDN(NLLCILIPDAL GNBALBEAIKA, NLLCILIPDAL ODFCMCFCPMH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6772180", Offset = "0x6771380", VA = "0x186772180")]
	public static bool DFHJMIKFMMI(NLLCILIPDAL GNBALBEAIKA, NLLCILIPDAL ODFCMCFCPMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x67734B0", Offset = "0x67726B0", VA = "0x1867734B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct ELPECABHBIN : IEquatable<ELPECABHBIN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly string?[]? LOAEPJBGEEF;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool IOBGPOINBGP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6772780", Offset = "0x6771980", VA = "0x186772780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int KHJGAONNLFL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3B773B0", Offset = "0x3B765B0", VA = "0x183B773B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6772D00", Offset = "0x6771F00", VA = "0x186772D00")]
	public ELPECABHBIN(string? OBHACENNONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6772E40", Offset = "0x6772040", VA = "0x186772E40")]
	public ELPECABHBIN(string?[] DACDKGJJLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6772A40", Offset = "0x6771C40", VA = "0x186772A40")]
	private static string?[]? KFHNKMEMJBB(string?[]? DACDKGJJLBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x67727A0", Offset = "0x67719A0", VA = "0x1867727A0")]
	public string DMFIGGAOIED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6772890", Offset = "0x6771A90", VA = "0x186772890", Slot = "4")]
	public bool Equals(ELPECABHBIN NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6772800", Offset = "0x6771A00", VA = "0x186772800", Slot = "0")]
	public override bool Equals(object MFLACBLODGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6772960", Offset = "0x6771B60", VA = "0x186772960", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6772C70", Offset = "0x6771E70", VA = "0x186772C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct DFAGJJAKBLE : IEquatable<DFAGJJAKBLE>, IComparable<DFAGJJAKBLE>, IAIMFIMOFPD
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly DFAGJJAKBLE LNBIPJDBGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Guid OHJPHHKPEGL;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1DC10D0", Offset = "0x1DC02D0", VA = "0x181DC10D0")]
	public DFAGJJAKBLE(Guid OHJPHHKPEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x88BDD0", Offset = "0x88AFD0", VA = "0x18088BDD0", Slot = "6")]
	public Guid OBELGBODBJN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFE90", Offset = "0x3AAF090", VA = "0x183AAFE90", Slot = "4")]
	public bool Equals(DFAGJJAKBLE NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFCC0", Offset = "0x3AAEEC0", VA = "0x183AAFCC0", Slot = "5")]
	public int CompareTo(DFAGJJAKBLE NFMPGFPPFKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6771690", Offset = "0x6770890", VA = "0x186771690", Slot = "0")]
	public override bool Equals(object MFLACBLODGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFE70", Offset = "0x3AAF070", VA = "0x183AAFE70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFE90", Offset = "0x3AAF090", VA = "0x183AAFE90")]
	public static bool CDBCKLPENDN(DFAGJJAKBLE GNBALBEAIKA, DFAGJJAKBLE ODFCMCFCPMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6771730", Offset = "0x6770930", VA = "0x186771730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct JEMHKEANCEI : IEquatable<JEMHKEANCEI>, IComparable<JEMHKEANCEI>, IAIMFIMOFPD
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly JEMHKEANCEI LNBIPJDBGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Guid OHJPHHKPEGL;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1DC10D0", Offset = "0x1DC02D0", VA = "0x181DC10D0")]
	public JEMHKEANCEI(Guid OHJPHHKPEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x88BDD0", Offset = "0x88AFD0", VA = "0x18088BDD0", Slot = "6")]
	public Guid OBELGBODBJN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFE90", Offset = "0x3AAF090", VA = "0x183AAFE90", Slot = "4")]
	public bool Equals(JEMHKEANCEI NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFCC0", Offset = "0x3AAEEC0", VA = "0x183AAFCC0", Slot = "5")]
	public int CompareTo(JEMHKEANCEI NFMPGFPPFKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6772FD0", Offset = "0x67721D0", VA = "0x186772FD0", Slot = "0")]
	public override bool Equals(object MFLACBLODGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3AAFE70", Offset = "0x3AAF070", VA = "0x183AAFE70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6772180", Offset = "0x6771380", VA = "0x186772180")]
	public static bool DFHJMIKFMMI(JEMHKEANCEI GNBALBEAIKA, JEMHKEANCEI ODFCMCFCPMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6773070", Offset = "0x6772270", VA = "0x186773070", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GFFNECLDAKG<TModern> : MBBIONDAIDN<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string MMAKDJDNINO(TModern ACHMCOGEHEF);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface IAIMFIMOFPD
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Guid OBELGBODBJN();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface MBBIONDAIDN<out TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TModern FINGOIHHPIP(string ACHMCOGEHEF);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface ADAODNAENDD
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	GFFNECLDAKG<PDIIDNCDDGN> DLAJNNEKOPI
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	GFFNECLDAKG<LBJMMHJKKBP> CNEGPODCIDC
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	GFFNECLDAKG<NLLCILIPDAL> DBPCLMPCDID
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	GFFNECLDAKG<EKDOJINKEPA> FJBMKJJHANA
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	GFFNECLDAKG<NBAEPOOLOKD> FJINECILMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	GFFNECLDAKG<DGDKEOGIINL> NJLOOALIEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	GFFNECLDAKG<KIEOGEFBNEF> OEFBKEEEIFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	GFFNECLDAKG<FIGLDHCCOLD> HAAGGNEAHMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class EBBGCIIICHC
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x67722C0", Offset = "0x67714C0", VA = "0x1867722C0")]
	public static string[] COCEHGHALKO(string? OBHACENNONP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6772380", Offset = "0x6771580", VA = "0x186772380")]
	public static string? FPFMEDHODIJ(string? EIONKCLFADO)
	{
		return null;
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
