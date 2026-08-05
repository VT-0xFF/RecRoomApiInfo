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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D84D0", Offset = "0x9D6ED0", VA = "0x1809D84D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class JHANGBLOOIH : NFMMBNJABEI<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7C7AC10", Offset = "0x7C79610", VA = "0x187C7AC10", Slot = "9")]
	public override string CFLEALCFLNK(bool OBMEHBOBMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C7AC60", Offset = "0x7C79660", VA = "0x187C7AC60", Slot = "10")]
	protected override bool IMBMNGPCGHB(string OBMEHBOBMDK, [Out] bool PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C7ACC0", Offset = "0x7C796C0", VA = "0x187C7ACC0")]
	public JHANGBLOOIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class AFODAADEIKO : NFMMBNJABEI<DateTime>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7C7A020", Offset = "0x7C78A20", VA = "0x187C7A020", Slot = "9")]
	public override string CFLEALCFLNK(DateTime OBMEHBOBMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C7A0B0", Offset = "0x7C78AB0", VA = "0x187C7A0B0", Slot = "10")]
	protected override bool IMBMNGPCGHB(string OBMEHBOBMDK, [Out] DateTime PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7C7A150", Offset = "0x7C78B50", VA = "0x187C7A150")]
	public AFODAADEIKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class IDIPKAEMIDF<TEnum> : NFMMBNJABEI<TEnum> where TEnum : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly Type CFBHLGDMOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool JGJCGKGBJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly TEnum[] IOMEFCNHNJN;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4A73870", Offset = "0x4A72270", VA = "0x184A73870")]
	[Preserve]
	public IDIPKAEMIDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4A73470", Offset = "0x4A71E70", VA = "0x184A73470", Slot = "9")]
	public override string CFLEALCFLNK(TEnum OBMEHBOBMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4A736B0", Offset = "0x4A720B0", VA = "0x184A736B0", Slot = "10")]
	protected override bool IMBMNGPCGHB(string OBMEHBOBMDK, [Out] TEnum PPJFMHBDGNA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class GPICMCGIDBB<TEnum> : NFMMBNJABEI<TEnum> where TEnum : Enum
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Type CFBHLGDMOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly OGNMMOHFBEF IKNIIDMBAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly bool JGJCGKGBJNH;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x48FEB70", Offset = "0x48FD570", VA = "0x1848FEB70")]
	[Preserve]
	public GPICMCGIDBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x48FE4B0", Offset = "0x48FCEB0", VA = "0x1848FE4B0", Slot = "9")]
	public override string CFLEALCFLNK(TEnum OBMEHBOBMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x48FE650", Offset = "0x48FD050", VA = "0x1848FE650", Slot = "10")]
	protected override bool IMBMNGPCGHB(string OBMEHBOBMDK, [Out] TEnum PPJFMHBDGNA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class POHIDADNLOI
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly Dictionary<Type, OGNMMOHFBEF> DAGEOJIKBAK;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B110", Offset = "0x7C79B10", VA = "0x187C7B110")]
	public static OGNMMOHFBEF GJKKHAOPHEG(Type OFHCBDHDMDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class GFDDAAJPFLG<T> : NFMMBNJABEI<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x34C5440", Offset = "0x34C3E40", VA = "0x1834C5440", Slot = "9")]
	public override string CFLEALCFLNK(T OBMEHBOBMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x488E760", Offset = "0x488D160", VA = "0x18488E760", Slot = "10")]
	protected override bool IMBMNGPCGHB(string OBMEHBOBMDK, [Out] T PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x43420D0", Offset = "0x4340AD0", VA = "0x1843420D0")]
	public GFDDAAJPFLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class CLFNAKLBACN<TCollection, T> : NFMMBNJABEI<TCollection> where TCollection : IEnumerable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly DNOCHDMNPCJ<T> FAAAPJCDDKH;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6586EB0", Offset = "0x65858B0", VA = "0x186586EB0")]
	protected CLFNAKLBACN(DNOCHDMNPCJ<T> FAAAPJCDDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6582FD0", Offset = "0x65819D0", VA = "0x186582FD0", Slot = "9")]
	public override string CFLEALCFLNK(TCollection OBMEHBOBMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6586460", Offset = "0x6584E60", VA = "0x186586460", Slot = "10")]
	protected override bool IMBMNGPCGHB(string OBMEHBOBMDK, [Out] TCollection PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract TCollection NJHLOIPJOJM(IEnumerable<T> NBCCNBKOOIE);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6584220", Offset = "0x6582C20", VA = "0x186584220", Slot = "12")]
	internal virtual IEnumerable<string> DPECFEJANOF(string OBMEHBOBMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6583DA0", Offset = "0x65827A0", VA = "0x186583DA0")]
	[CompilerGenerated]
	private string CKNGNJFDMKD(T LFDANFLODKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class IDOAEFAKCLL<T> : CLFNAKLBACN<T[], T>
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x438E2E0", Offset = "0x438CCE0", VA = "0x18438E2E0")]
	[Preserve]
	public IDOAEFAKCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x435B870", Offset = "0x435A270", VA = "0x18435B870")]
	[Preserve]
	public IDOAEFAKCLL(DNOCHDMNPCJ<T> FAAAPJCDDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4A73B20", Offset = "0x4A72520", VA = "0x184A73B20", Slot = "11")]
	protected override T[] NJHLOIPJOJM(IEnumerable<T> NBCCNBKOOIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class LEDOJJBBAMF<T> : CLFNAKLBACN<List<T>, T>
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x438E2E0", Offset = "0x438CCE0", VA = "0x18438E2E0")]
	[Preserve]
	public LEDOJJBBAMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x435B870", Offset = "0x435A270", VA = "0x18435B870")]
	[Preserve]
	public LEDOJJBBAMF([Optional] DNOCHDMNPCJ<T> FAAAPJCDDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4EB8E00", Offset = "0x4EB7800", VA = "0x184EB8E00", Slot = "11")]
	protected override List<T> NJHLOIPJOJM(IEnumerable<T> NBCCNBKOOIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class CDFLCNJMBAK<T> : NFMMBNJABEI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JsonSerializerSettings? HKDDFFBOPOE;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5179C50", Offset = "0x5178650", VA = "0x185179C50")]
	public CDFLCNJMBAK(JsonSerializerSettings? BPDMAGOBMEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x655E580", Offset = "0x655CF80", VA = "0x18655E580", Slot = "9")]
	public override string CFLEALCFLNK(T OBMEHBOBMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x655E5E0", Offset = "0x655CFE0", VA = "0x18655E5E0", Slot = "10")]
	protected override bool IMBMNGPCGHB([NotNull] string OBMEHBOBMDK, [Out] T PPJFMHBDGNA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class CCAODNLNDGE : NFMMBNJABEI<byte>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7C7A2C0", Offset = "0x7C78CC0", VA = "0x187C7A2C0", Slot = "9")]
	public override string CFLEALCFLNK(byte OBMEHBOBMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7C7A320", Offset = "0x7C78D20", VA = "0x187C7A320", Slot = "10")]
	protected override bool IMBMNGPCGHB(string OBMEHBOBMDK, [Out] byte PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7C7A3B0", Offset = "0x7C78DB0", VA = "0x187C7A3B0")]
	public CCAODNLNDGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class IOHPLLAKCJI : NFMMBNJABEI<short>
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7C7A6C0", Offset = "0x7C790C0", VA = "0x187C7A6C0", Slot = "9")]
	public override string CFLEALCFLNK(short OBMEHBOBMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7C7A720", Offset = "0x7C79120", VA = "0x187C7A720", Slot = "10")]
	protected override bool IMBMNGPCGHB(string OBMEHBOBMDK, [Out] short PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C7A7C0", Offset = "0x7C791C0", VA = "0x187C7A7C0")]
	public IOHPLLAKCJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal class PGPKJOBLAHK : NFMMBNJABEI<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7C7AE40", Offset = "0x7C79840", VA = "0x187C7AE40", Slot = "9")]
	public override string CFLEALCFLNK(ushort OBMEHBOBMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7C7AEA0", Offset = "0x7C798A0", VA = "0x187C7AEA0", Slot = "10")]
	protected override bool IMBMNGPCGHB(string OBMEHBOBMDK, [Out] ushort PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7C7AF40", Offset = "0x7C79940", VA = "0x187C7AF40")]
	public PGPKJOBLAHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CLKIPAKFCFF : NFMMBNJABEI<int>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7C7A530", Offset = "0x7C78F30", VA = "0x187C7A530", Slot = "9")]
	public override string CFLEALCFLNK(int OBMEHBOBMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7C7A590", Offset = "0x7C78F90", VA = "0x187C7A590", Slot = "10")]
	protected override bool IMBMNGPCGHB(string OBMEHBOBMDK, [Out] int PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7C7A620", Offset = "0x7C79020", VA = "0x187C7A620")]
	public CLKIPAKFCFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class AMCOOPPJBGN : NFMMBNJABEI<uint>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7C7A190", Offset = "0x7C78B90", VA = "0x187C7A190", Slot = "9")]
	public override string CFLEALCFLNK(uint OBMEHBOBMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7C7A1F0", Offset = "0x7C78BF0", VA = "0x187C7A1F0", Slot = "10")]
	protected override bool IMBMNGPCGHB(string OBMEHBOBMDK, [Out] uint PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7C7A280", Offset = "0x7C78C80", VA = "0x187C7A280")]
	public AMCOOPPJBGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class LOMDMFIHAIE : NFMMBNJABEI<long>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7C7AD00", Offset = "0x7C79700", VA = "0x187C7AD00", Slot = "9")]
	public override string CFLEALCFLNK(long OBMEHBOBMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7C7AD60", Offset = "0x7C79760", VA = "0x187C7AD60", Slot = "10")]
	protected override bool IMBMNGPCGHB(string OBMEHBOBMDK, [Out] long PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7C7AE00", Offset = "0x7C79800", VA = "0x187C7AE00")]
	public LOMDMFIHAIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class CCDLFHNGOBH : NFMMBNJABEI<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7C7A3F0", Offset = "0x7C78DF0", VA = "0x187C7A3F0", Slot = "9")]
	public override string CFLEALCFLNK(ulong OBMEHBOBMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7C7A450", Offset = "0x7C78E50", VA = "0x187C7A450", Slot = "10")]
	protected override bool IMBMNGPCGHB(string OBMEHBOBMDK, [Out] ulong PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7C7A4F0", Offset = "0x7C78EF0", VA = "0x187C7A4F0")]
	public CCDLFHNGOBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class JBPHGLCBLDN : NFMMBNJABEI<float>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7C7AAD0", Offset = "0x7C794D0", VA = "0x187C7AAD0", Slot = "9")]
	public override string CFLEALCFLNK(float OBMEHBOBMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7C7AB40", Offset = "0x7C79540", VA = "0x187C7AB40", Slot = "10")]
	protected override bool IMBMNGPCGHB(string OBMEHBOBMDK, [Out] float PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7C7ABD0", Offset = "0x7C795D0", VA = "0x187C7ABD0")]
	public JBPHGLCBLDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface OGNMMOHFBEF
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string OKJICAELJPB(object OBMEHBOBMDK);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MCOFPEENPCL([CanBeNull] string OBMEHBOBMDK, [Out] object PPJFMHBDGNA);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DNOCHDMNPCJ<T> : OGNMMOHFBEF
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string CFLEALCFLNK(T OBMEHBOBMDK);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BODMEEJLOED([CanBeNull] string OBMEHBOBMDK, [Out] T PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T PLKIDJIDKPA([CanBeNull] string OBMEHBOBMDK, [Optional] T LPJIMLBFHAO);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class NFMMBNJABEI<T> : DNOCHDMNPCJ<T>, OGNMMOHFBEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Type JMIIINDPING;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x51ABC30", Offset = "0x51AA630", VA = "0x1851ABC30")]
	protected NFMMBNJABEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x51AB0F0", Offset = "0x51A9AF0", VA = "0x1851AB0F0")]
	private T PIIBIEJGJDB(object OIIGDBLKEDN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract string CFLEALCFLNK(T OBMEHBOBMDK);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x51AAC30", Offset = "0x51A9630", VA = "0x1851AAC30", Slot = "7")]
	public string OKJICAELJPB(object OBMEHBOBMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x51AA580", Offset = "0x51A8F80", VA = "0x1851AA580", Slot = "5")]
	public bool BODMEEJLOED(string OBMEHBOBMDK, [Out] T PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool IMBMNGPCGHB([NotNull] string OBMEHBOBMDK, [Out] T PPJFMHBDGNA);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x51AA6E0", Offset = "0x51A90E0", VA = "0x1851AA6E0", Slot = "8")]
	private bool COFOCJPIDDN(string OBMEHBOBMDK, [Out] object PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x51AB560", Offset = "0x51A9F60", VA = "0x1851AB560", Slot = "6")]
	public T PLKIDJIDKPA(string OBMEHBOBMDK, [Optional] T LPJIMLBFHAO)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class KCDKHGEABOJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static DNOCHDMNPCJ<T> JKECEEFIAPF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x47A3260", Offset = "0x47A1C60", VA = "0x1847A3260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3BBBE70", Offset = "0x3BBA870", VA = "0x183BBBE70")]
	public static DNOCHDMNPCJ<TSerialized> KDJLEMMKCMH<TSerialized>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4DE90A0", Offset = "0x4DE7AA0", VA = "0x184DE90A0")]
	public static OGNMMOHFBEF KDJLEMMKCMH(Type OJEDFNMHJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4DE6620", Offset = "0x4DE5020", VA = "0x184DE6620")]
	private static OGNMMOHFBEF IOIFMKJJGCJ(Type KLIIKAALBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4DE1120", Offset = "0x4DDFB20", VA = "0x184DE1120")]
	private static OGNMMOHFBEF ABNBNKANNEJ(Type KLIIKAALBNF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class HCKKDKNNIBB<TCollection> : CLFNAKLBACN<TCollection, string> where TCollection : IEnumerable<string>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class HJFEGJHDDGH : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
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
		public HCKKDKNNIBB<TCollection> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private OHGGLHHAFJE<StringBuilder> <_>5__2;

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
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xE17BE0", Offset = "0xE165E0", VA = "0x180E17BE0")]
		[DebuggerHidden]
		public HJFEGJHDDGH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4365E40", Offset = "0x4364840", VA = "0x184365E40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4966350", Offset = "0x4964D50", VA = "0x184966350", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4966300", Offset = "0x4964D00", VA = "0x184966300")]
		private void JKNFIIFCPDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x49668E0", Offset = "0x49652E0", VA = "0x1849668E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x49667C0", Offset = "0x49651C0", VA = "0x1849667C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x49668A0", Offset = "0x49652A0", VA = "0x1849668A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool PKOJHDJOPIN;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x493C650", Offset = "0x493B050", VA = "0x18493C650")]
	protected HCKKDKNNIBB(bool PKOJHDJOPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x493C2D0", Offset = "0x493ACD0", VA = "0x18493C2D0", Slot = "9")]
	public override string CFLEALCFLNK(TCollection OBMEHBOBMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x493C510", Offset = "0x493AF10", VA = "0x18493C510", Slot = "12")]
	[IteratorStateMachine(typeof(HCKKDKNNIBB<>.HJFEGJHDDGH))]
	internal override IEnumerable<string> DPECFEJANOF(string OBMEHBOBMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x493C5D0", Offset = "0x493AFD0", VA = "0x18493C5D0")]
	[CompilerGenerated]
	internal static string MGDJCKIACMF(StringBuilder CPKHDNICNAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PKFGFLNANED : HCKKDKNNIBB<List<string>>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B010", Offset = "0x7C79A10", VA = "0x187C7B010")]
	[Preserve]
	public PKFGFLNANED(bool PKOJHDJOPIN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7C7AF80", Offset = "0x7C79980", VA = "0x187C7AF80", Slot = "11")]
	protected override List<string> NJHLOIPJOJM(IEnumerable<string> NBCCNBKOOIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class PKFJAKANBHD : HCKKDKNNIBB<string[]>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B0C0", Offset = "0x7C79AC0", VA = "0x187C7B0C0")]
	[Preserve]
	public PKFJAKANBHD(bool PKOJHDJOPIN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7C7B060", Offset = "0x7C79A60", VA = "0x187C7B060", Slot = "11")]
	protected override string[] NJHLOIPJOJM(IEnumerable<string> NBCCNBKOOIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class IMPHMLBFFEJ : NFMMBNJABEI<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA2E020", Offset = "0xA2CA20", VA = "0x180A2E020", Slot = "9")]
	public override string CFLEALCFLNK(string OBMEHBOBMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7C7A660", Offset = "0x7C79060", VA = "0x187C7A660", Slot = "10")]
	protected override bool IMBMNGPCGHB(string OBMEHBOBMDK, [Out] string PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7C7A680", Offset = "0x7C79080", VA = "0x187C7A680")]
	public IMPHMLBFFEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class IPFOEFCJKJO : NFMMBNJABEI<TimeSpan>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7C7A800", Offset = "0x7C79200", VA = "0x187C7A800", Slot = "9")]
	public override string CFLEALCFLNK(TimeSpan OBMEHBOBMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7C7A920", Offset = "0x7C79320", VA = "0x187C7A920", Slot = "10")]
	protected override bool IMBMNGPCGHB(string OBMEHBOBMDK, [Out] TimeSpan PPJFMHBDGNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7C7AA90", Offset = "0x7C79490", VA = "0x187C7AA90")]
	public IPFOEFCJKJO()
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
