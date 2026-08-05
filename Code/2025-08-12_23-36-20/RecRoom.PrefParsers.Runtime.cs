using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABFA20", Offset = "0xABE820", VA = "0x180ABFA20")]
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

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xABFA60", Offset = "0xABE860", VA = "0x180ABFA60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CMMCKKDLOFI : JFLEFCOBODM<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x875FE10", Offset = "0x875EC10", VA = "0x18875FE10", Slot = "9")]
	public override string OFACCHGGJAP(bool DANFKLEPBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x875FDB0", Offset = "0x875EBB0", VA = "0x18875FDB0", Slot = "10")]
	protected override bool JIGLBFFFIJP(string DANFKLEPBNF, [Out] bool HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x875FE60", Offset = "0x875EC60", VA = "0x18875FE60")]
	public CMMCKKDLOFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class ECNJEIEFAPF : JFLEFCOBODM<DateTime>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8760070", Offset = "0x875EE70", VA = "0x188760070", Slot = "9")]
	public override string OFACCHGGJAP(DateTime DANFKLEPBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x875FFD0", Offset = "0x875EDD0", VA = "0x18875FFD0", Slot = "10")]
	protected override bool JIGLBFFFIJP(string DANFKLEPBNF, [Out] DateTime HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8760100", Offset = "0x875EF00", VA = "0x188760100")]
	public ECNJEIEFAPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class LOPILGOFLOH<TEnum> : JFLEFCOBODM<TEnum> where TEnum : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly Type JCNMFMNCKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool BEJPGAAFEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly TEnum[] OOFDDMCKJPA;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x56A2AB0", Offset = "0x56A18B0", VA = "0x1856A2AB0")]
	[Preserve]
	public LOPILGOFLOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x56A27C0", Offset = "0x56A15C0", VA = "0x1856A27C0", Slot = "9")]
	public override string OFACCHGGJAP(TEnum DANFKLEPBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x56A26E0", Offset = "0x56A14E0", VA = "0x1856A26E0", Slot = "10")]
	protected override bool JIGLBFFFIJP(string DANFKLEPBNF, [Out] TEnum HGMAIPELJHM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class JMEGMAEMAEF<TEnum> : JFLEFCOBODM<TEnum> where TEnum : Enum
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Type JCNMFMNCKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly KEHJFAPKDCD PDHPOLHNPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly bool BEJPGAAFEOE;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x54B62F0", Offset = "0x54B50F0", VA = "0x1854B62F0")]
	[Preserve]
	public JMEGMAEMAEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x54B6150", Offset = "0x54B4F50", VA = "0x1854B6150", Slot = "9")]
	public override string OFACCHGGJAP(TEnum DANFKLEPBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x54B5EF0", Offset = "0x54B4CF0", VA = "0x1854B5EF0", Slot = "10")]
	protected override bool JIGLBFFFIJP(string DANFKLEPBNF, [Out] TEnum HGMAIPELJHM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class CADOHONEOLH
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly Dictionary<Type, KEHJFAPKDCD> DHCCJFNBJCE;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x875F5A0", Offset = "0x875E3A0", VA = "0x18875F5A0")]
	public static KEHJFAPKDCD IGIKBFDDHCL(Type DCHOADPHLBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class AIFKFCBCMME<T> : JFLEFCOBODM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3DF8DB0", Offset = "0x3DF7BB0", VA = "0x183DF8DB0", Slot = "9")]
	public override string OFACCHGGJAP(T DANFKLEPBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x52AF170", Offset = "0x52ADF70", VA = "0x1852AF170", Slot = "10")]
	protected override bool JIGLBFFFIJP(string DANFKLEPBNF, [Out] T HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4A2CC90", Offset = "0x4A2BA90", VA = "0x184A2CC90")]
	public AIFKFCBCMME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class EMKPLMIAOAJ<TCollection, T> : JFLEFCOBODM<TCollection> where TCollection : IEnumerable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly GNBDNPIJLBI<T> OKCOBPFKLPA;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4A75E00", Offset = "0x4A74C00", VA = "0x184A75E00")]
	protected EMKPLMIAOAJ(GNBDNPIJLBI<T> OKCOBPFKLPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4A75540", Offset = "0x4A74340", VA = "0x184A75540", Slot = "9")]
	public override string OFACCHGGJAP(TCollection DANFKLEPBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4A744D0", Offset = "0x4A732D0", VA = "0x184A744D0", Slot = "10")]
	protected override bool JIGLBFFFIJP(string DANFKLEPBNF, [Out] TCollection HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract TCollection AGIFFGOFDKO(IEnumerable<T> LCAAPKFEJGM);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4A75270", Offset = "0x4A74070", VA = "0x184A75270", Slot = "12")]
	internal virtual IEnumerable<string> LPJJLKHFIOI(string DANFKLEPBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4A724C0", Offset = "0x4A712C0", VA = "0x184A724C0")]
	[CompilerGenerated]
	private string BLJNHNBAKAF(T MHBJBKNNPOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class KGBPLLKOPDD<T> : EMKPLMIAOAJ<T[], T>
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4F19AA0", Offset = "0x4F188A0", VA = "0x184F19AA0")]
	[Preserve]
	public KGBPLLKOPDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C1C0", Offset = "0x4A3AFC0", VA = "0x184A3C1C0")]
	[Preserve]
	public KGBPLLKOPDD(GNBDNPIJLBI<T> OKCOBPFKLPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x55D5E20", Offset = "0x55D4C20", VA = "0x1855D5E20", Slot = "11")]
	protected override T[] AGIFFGOFDKO(IEnumerable<T> LCAAPKFEJGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class OACEBNLCIMP<T> : EMKPLMIAOAJ<List<T>, T>
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4F19AA0", Offset = "0x4F188A0", VA = "0x184F19AA0")]
	[Preserve]
	public OACEBNLCIMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C1C0", Offset = "0x4A3AFC0", VA = "0x184A3C1C0")]
	[Preserve]
	public OACEBNLCIMP([Optional] GNBDNPIJLBI<T> OKCOBPFKLPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5AB5D30", Offset = "0x5AB4B30", VA = "0x185AB5D30", Slot = "11")]
	protected override List<T> AGIFFGOFDKO(IEnumerable<T> LCAAPKFEJGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class NOJMHKHKNNM<T> : JFLEFCOBODM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JsonSerializerSettings? DOKOGHOKBJK;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x594D6E0", Offset = "0x594C4E0", VA = "0x18594D6E0")]
	public NOJMHKHKNNM(JsonSerializerSettings? BFKMDIDPNOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x59B5930", Offset = "0x59B4730", VA = "0x1859B5930", Slot = "9")]
	public override string OFACCHGGJAP(T DANFKLEPBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x59B5870", Offset = "0x59B4670", VA = "0x1859B5870", Slot = "10")]
	protected override bool JIGLBFFFIJP([NotNull] string DANFKLEPBNF, [Out] T HGMAIPELJHM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class MAJHFLCKOLK : JFLEFCOBODM<byte>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8760B30", Offset = "0x875F930", VA = "0x188760B30", Slot = "9")]
	public override string OFACCHGGJAP(byte DANFKLEPBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8760AA0", Offset = "0x875F8A0", VA = "0x188760AA0", Slot = "10")]
	protected override bool JIGLBFFFIJP(string DANFKLEPBNF, [Out] byte HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8760B90", Offset = "0x875F990", VA = "0x188760B90")]
	public MAJHFLCKOLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class GBBCEFPPJNB : JFLEFCOBODM<short>
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8760310", Offset = "0x875F110", VA = "0x188760310", Slot = "9")]
	public override string OFACCHGGJAP(short DANFKLEPBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8760270", Offset = "0x875F070", VA = "0x188760270", Slot = "10")]
	protected override bool JIGLBFFFIJP(string DANFKLEPBNF, [Out] short HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8760370", Offset = "0x875F170", VA = "0x188760370")]
	public GBBCEFPPJNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal class LIEEBGGCGCF : JFLEFCOBODM<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8760730", Offset = "0x875F530", VA = "0x188760730", Slot = "9")]
	public override string OFACCHGGJAP(ushort DANFKLEPBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8760690", Offset = "0x875F490", VA = "0x188760690", Slot = "10")]
	protected override bool JIGLBFFFIJP(string DANFKLEPBNF, [Out] ushort HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8760790", Offset = "0x875F590", VA = "0x188760790")]
	public LIEEBGGCGCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class EHMCMBAPDBN : JFLEFCOBODM<int>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x87601D0", Offset = "0x875EFD0", VA = "0x1887601D0", Slot = "9")]
	public override string OFACCHGGJAP(int DANFKLEPBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8760140", Offset = "0x875EF40", VA = "0x188760140", Slot = "10")]
	protected override bool JIGLBFFFIJP(string DANFKLEPBNF, [Out] int HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8760230", Offset = "0x875F030", VA = "0x188760230")]
	public EHMCMBAPDBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class DHNKKIBCMBG : JFLEFCOBODM<uint>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x875FF30", Offset = "0x875ED30", VA = "0x18875FF30", Slot = "9")]
	public override string OFACCHGGJAP(uint DANFKLEPBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x875FEA0", Offset = "0x875ECA0", VA = "0x18875FEA0", Slot = "10")]
	protected override bool JIGLBFFFIJP(string DANFKLEPBNF, [Out] uint HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x875FF90", Offset = "0x875ED90", VA = "0x18875FF90")]
	public DHNKKIBCMBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class HHAFDCNFIIB : JFLEFCOBODM<long>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x87604B0", Offset = "0x875F2B0", VA = "0x1887604B0", Slot = "9")]
	public override string OFACCHGGJAP(long DANFKLEPBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8760410", Offset = "0x875F210", VA = "0x188760410", Slot = "10")]
	protected override bool JIGLBFFFIJP(string DANFKLEPBNF, [Out] long HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8760510", Offset = "0x875F310", VA = "0x188760510")]
	public HHAFDCNFIIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class LEADJNAHNIF : JFLEFCOBODM<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x87605F0", Offset = "0x875F3F0", VA = "0x1887605F0", Slot = "9")]
	public override string OFACCHGGJAP(ulong DANFKLEPBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8760550", Offset = "0x875F350", VA = "0x188760550", Slot = "10")]
	protected override bool JIGLBFFFIJP(string DANFKLEPBNF, [Out] ulong HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8760650", Offset = "0x875F450", VA = "0x188760650")]
	public LEADJNAHNIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class PFMNPKEIHME : JFLEFCOBODM<float>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8760C60", Offset = "0x875FA60", VA = "0x188760C60", Slot = "9")]
	public override string OFACCHGGJAP(float DANFKLEPBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8760BD0", Offset = "0x875F9D0", VA = "0x188760BD0", Slot = "10")]
	protected override bool JIGLBFFFIJP(string DANFKLEPBNF, [Out] float HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8760CD0", Offset = "0x875FAD0", VA = "0x188760CD0")]
	public PFMNPKEIHME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface KEHJFAPKDCD
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string DDPLOHBBBHA(object DANFKLEPBNF);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NMLFEFAECEF([CanBeNull] string DANFKLEPBNF, [Out] object HGMAIPELJHM);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface GNBDNPIJLBI<T> : KEHJFAPKDCD
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string OFACCHGGJAP(T DANFKLEPBNF);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PJKONFNNFCK([CanBeNull] string DANFKLEPBNF, [Out] T HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T DBFAOFJOGBI([CanBeNull] string DANFKLEPBNF, [Optional] T PGFMONBPOJI);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class JFLEFCOBODM<T> : GNBDNPIJLBI<T>, KEHJFAPKDCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Type BBPPEANNBLH;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5461560", Offset = "0x5460360", VA = "0x185461560")]
	protected JFLEFCOBODM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5460C00", Offset = "0x545FA00", VA = "0x185460C00")]
	private T GOJOBKKBLCP(object ALGAKMGCCLO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract string OFACCHGGJAP(T DANFKLEPBNF);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5460750", Offset = "0x545F550", VA = "0x185460750", Slot = "7")]
	public string DDPLOHBBBHA(object DANFKLEPBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5461540", Offset = "0x5460340", VA = "0x185461540", Slot = "5")]
	public bool PJKONFNNFCK(string DANFKLEPBNF, [Out] T HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool JIGLBFFFIJP([NotNull] string DANFKLEPBNF, [Out] T HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x54611C0", Offset = "0x545FFC0", VA = "0x1854611C0", Slot = "8")]
	private bool NBGODLFHFBF(string DANFKLEPBNF, [Out] object HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5460600", Offset = "0x545F400", VA = "0x185460600", Slot = "6")]
	public T DBFAOFJOGBI(string DANFKLEPBNF, [Optional] T PGFMONBPOJI)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class DJGEAENAPNP<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static GNBDNPIJLBI<T> HANIMDCJEMB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x455DA80", Offset = "0x455C880", VA = "0x18455DA80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x41A23B0", Offset = "0x41A11B0", VA = "0x1841A23B0")]
	public static GNBDNPIJLBI<TSerialized> GNJGELMLOAK<TSerialized>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x456B6E0", Offset = "0x456A4E0", VA = "0x18456B6E0")]
	public static KEHJFAPKDCD GNJGELMLOAK(Type ENKENIHECEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4564120", Offset = "0x4562F20", VA = "0x184564120")]
	private static KEHJFAPKDCD EEKEGBOJDJF(Type HKKOEHKPCHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4559F00", Offset = "0x4558D00", VA = "0x184559F00")]
	private static KEHJFAPKDCD CBFDEFHDNBP(Type HKKOEHKPCHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class PJININLGOAF<TCollection> : EMKPLMIAOAJ<TCollection, string> where TCollection : IEnumerable<string>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class OFFBAOEPHKM : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private string <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private string input;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public string <>3__input;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public PJININLGOAF<TCollection> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private CKALINJENEI<StringBuilder> <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private StringBuilder <partBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private bool <insideQuotes>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int <i>5__5;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		string IEnumerator<string>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1010120", Offset = "0x100EF20", VA = "0x181010120")]
		[DebuggerHidden]
		public OFFBAOEPHKM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4F90640", Offset = "0x4F8F440", VA = "0x184F90640", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5ABF2F0", Offset = "0x5ABE0F0", VA = "0x185ABF2F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5ABF750", Offset = "0x5ABE550", VA = "0x185ABF750")]
		private void POCLDLCLENG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5ABF870", Offset = "0x5ABE670", VA = "0x185ABF870", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5ABF7A0", Offset = "0x5ABE5A0", VA = "0x185ABF7A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5544120", Offset = "0x5542F20", VA = "0x185544120", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool FNBEDEDMCPK;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5C014C0", Offset = "0x5C002C0", VA = "0x185C014C0")]
	protected PJININLGOAF(bool FNBEDEDMCPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5C011F0", Offset = "0x5BFFFF0", VA = "0x185C011F0", Slot = "9")]
	public override string OFACCHGGJAP(TCollection DANFKLEPBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5C01140", Offset = "0x5BFFF40", VA = "0x185C01140", Slot = "12")]
	[IteratorStateMachine(typeof(PJININLGOAF<>.OFFBAOEPHKM))]
	internal override IEnumerable<string> LPJJLKHFIOI(string DANFKLEPBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5C01440", Offset = "0x5C00240", VA = "0x185C01440")]
	[CompilerGenerated]
	internal static string OILDIICGJNA(StringBuilder ABHPOMDMIKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class AJEEEKEHJGI : PJININLGOAF<List<string>>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x875F550", Offset = "0x875E350", VA = "0x18875F550")]
	[Preserve]
	public AJEEEKEHJGI(bool FNBEDEDMCPK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x875F4C0", Offset = "0x875E2C0", VA = "0x18875F4C0", Slot = "11")]
	protected override List<string> AGIFFGOFDKO(IEnumerable<string> LCAAPKFEJGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CIFIGJHLFOH : PJININLGOAF<string[]>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x875FD60", Offset = "0x875EB60", VA = "0x18875FD60")]
	[Preserve]
	public CIFIGJHLFOH(bool FNBEDEDMCPK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x875FD00", Offset = "0x875EB00", VA = "0x18875FD00", Slot = "11")]
	protected override string[] AGIFFGOFDKO(IEnumerable<string> LCAAPKFEJGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class GLPFBCOMBME : JFLEFCOBODM<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xAF9A00", Offset = "0xAF8800", VA = "0x180AF9A00", Slot = "9")]
	public override string OFACCHGGJAP(string DANFKLEPBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x87603B0", Offset = "0x875F1B0", VA = "0x1887603B0", Slot = "10")]
	protected override bool JIGLBFFFIJP(string DANFKLEPBNF, [Out] string HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x87603D0", Offset = "0x875F1D0", VA = "0x1887603D0")]
	public GLPFBCOMBME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class LIFGNPEPEDB : JFLEFCOBODM<TimeSpan>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8760940", Offset = "0x875F740", VA = "0x188760940", Slot = "9")]
	public override string OFACCHGGJAP(TimeSpan DANFKLEPBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x87607D0", Offset = "0x875F5D0", VA = "0x1887607D0", Slot = "10")]
	protected override bool JIGLBFFFIJP(string DANFKLEPBNF, [Out] TimeSpan HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8760A60", Offset = "0x875F860", VA = "0x188760A60")]
	public LIFGNPEPEDB()
	{
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
