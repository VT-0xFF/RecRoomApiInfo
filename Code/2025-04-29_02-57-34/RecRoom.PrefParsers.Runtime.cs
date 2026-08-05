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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F5340", Offset = "0x9F4740", VA = "0x1809F5340")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F5380", Offset = "0x9F4780", VA = "0x1809F5380")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NIDAJHBFLIJ : JLJMOHNJPKF<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7E76C70", Offset = "0x7E76070", VA = "0x187E76C70", Slot = "9")]
	public override string PEGKBLBFNLH(bool EOMFNMMGCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7E76C10", Offset = "0x7E76010", VA = "0x187E76C10", Slot = "10")]
	protected override bool BMOOHPBBDGC(string EOMFNMMGCEC, [Out] bool OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7E76CC0", Offset = "0x7E760C0", VA = "0x187E76CC0")]
	public NIDAJHBFLIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class CIEJLJGHLNC : JLJMOHNJPKF<DateTime>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7E75A30", Offset = "0x7E74E30", VA = "0x187E75A30", Slot = "9")]
	public override string PEGKBLBFNLH(DateTime EOMFNMMGCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7E75990", Offset = "0x7E74D90", VA = "0x187E75990", Slot = "10")]
	protected override bool BMOOHPBBDGC(string EOMFNMMGCEC, [Out] DateTime OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7E75AC0", Offset = "0x7E74EC0", VA = "0x187E75AC0")]
	public CIEJLJGHLNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class GJPPOBIHMEA<TEnum> : JLJMOHNJPKF<TEnum> where TEnum : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly Type HGEDOBCBGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool LNGKMAMAFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly TEnum[] LMNAOMMMDJP;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x48C2B90", Offset = "0x48C1F90", VA = "0x1848C2B90")]
	[Preserve]
	public GJPPOBIHMEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x48C2850", Offset = "0x48C1C50", VA = "0x1848C2850", Slot = "9")]
	public override string PEGKBLBFNLH(TEnum EOMFNMMGCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x48C2770", Offset = "0x48C1B70", VA = "0x1848C2770", Slot = "10")]
	protected override bool BMOOHPBBDGC(string EOMFNMMGCEC, [Out] TEnum OOEMJLHLIHJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class IOLOPHOGJHN<TEnum> : JLJMOHNJPKF<TEnum> where TEnum : Enum
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Type HGEDOBCBGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly ANAPHPKBNPH CAGBICALDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly bool LNGKMAMAFNH;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4A7D640", Offset = "0x4A7CA40", VA = "0x184A7D640")]
	[Preserve]
	public IOLOPHOGJHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4A7D4A0", Offset = "0x4A7C8A0", VA = "0x184A7D4A0", Slot = "9")]
	public override string PEGKBLBFNLH(TEnum EOMFNMMGCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4A7D230", Offset = "0x4A7C630", VA = "0x184A7D230", Slot = "10")]
	protected override bool BMOOHPBBDGC(string EOMFNMMGCEC, [Out] TEnum OOEMJLHLIHJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class IDJOAOAOLEE
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly Dictionary<Type, ANAPHPKBNPH> CNFOIGAOKIB;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7E75C90", Offset = "0x7E75090", VA = "0x187E75C90")]
	public static ANAPHPKBNPH LMHOFKCCJNJ(Type KGAKMAALMOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class BABPGGIDJPN<T> : JLJMOHNJPKF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x38C09C0", Offset = "0x38BFDC0", VA = "0x1838C09C0", Slot = "9")]
	public override string PEGKBLBFNLH(T EOMFNMMGCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5DA3880", Offset = "0x5DA2C80", VA = "0x185DA3880", Slot = "10")]
	protected override bool BMOOHPBBDGC(string EOMFNMMGCEC, [Out] T OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4377080", Offset = "0x4376480", VA = "0x184377080")]
	public BABPGGIDJPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class DMJOLAINDAE<TCollection, T> : JLJMOHNJPKF<TCollection> where TCollection : IEnumerable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly LHMHCDCFGHO<T> NPEPBAEHILB;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x68F2050", Offset = "0x68F1450", VA = "0x1868F2050")]
	protected DMJOLAINDAE(LHMHCDCFGHO<T> NPEPBAEHILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x68F1630", Offset = "0x68F0A30", VA = "0x1868F1630", Slot = "9")]
	public override string PEGKBLBFNLH(TCollection EOMFNMMGCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x68EF470", Offset = "0x68EE870", VA = "0x1868EF470", Slot = "10")]
	protected override bool BMOOHPBBDGC(string EOMFNMMGCEC, [Out] TCollection OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract TCollection OBEMJLGGNEH(IEnumerable<T> GKIPCPOAHBN);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x68EDF40", Offset = "0x68ED340", VA = "0x1868EDF40", Slot = "12")]
	internal virtual IEnumerable<string> ACFCGKMHABI(string EOMFNMMGCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x68F0FD0", Offset = "0x68F03D0", VA = "0x1868F0FD0")]
	[CompilerGenerated]
	private string FEJPELHMLHH(T LLEKGMDPLMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class DGAFODFJACA<T> : DMJOLAINDAE<T[], T>
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4A64D70", Offset = "0x4A64170", VA = "0x184A64D70")]
	[Preserve]
	public DGAFODFJACA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x47C3890", Offset = "0x47C2C90", VA = "0x1847C3890")]
	[Preserve]
	public DGAFODFJACA(LHMHCDCFGHO<T> NPEPBAEHILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6892ED0", Offset = "0x68922D0", VA = "0x186892ED0", Slot = "11")]
	protected override T[] OBEMJLGGNEH(IEnumerable<T> GKIPCPOAHBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class IKCPHKDOIGK<T> : DMJOLAINDAE<List<T>, T>
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4A64D70", Offset = "0x4A64170", VA = "0x184A64D70")]
	[Preserve]
	public IKCPHKDOIGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x47C3890", Offset = "0x47C2C90", VA = "0x1847C3890")]
	[Preserve]
	public IKCPHKDOIGK([Optional] LHMHCDCFGHO<T> NPEPBAEHILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4A64CC0", Offset = "0x4A640C0", VA = "0x184A64CC0", Slot = "11")]
	protected override List<T> OBEMJLGGNEH(IEnumerable<T> GKIPCPOAHBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class MAHBMFMIOLE<T> : JLJMOHNJPKF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JsonSerializerSettings? IBMCHNLBNPI;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x509FC00", Offset = "0x509F000", VA = "0x18509FC00")]
	public MAHBMFMIOLE(JsonSerializerSettings? EMJPJLIHPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x509FBA0", Offset = "0x509EFA0", VA = "0x18509FBA0", Slot = "9")]
	public override string PEGKBLBFNLH(T EOMFNMMGCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x509FAD0", Offset = "0x509EED0", VA = "0x18509FAD0", Slot = "10")]
	protected override bool BMOOHPBBDGC([NotNull] string EOMFNMMGCEC, [Out] T OOEMJLHLIHJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class GKLIMODMCPM : JLJMOHNJPKF<byte>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7E75BF0", Offset = "0x7E74FF0", VA = "0x187E75BF0", Slot = "9")]
	public override string PEGKBLBFNLH(byte EOMFNMMGCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7E75B60", Offset = "0x7E74F60", VA = "0x187E75B60", Slot = "10")]
	protected override bool BMOOHPBBDGC(string EOMFNMMGCEC, [Out] byte OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7E75C50", Offset = "0x7E75050", VA = "0x187E75C50")]
	public GKLIMODMCPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class BIHGFHEADGP : JLJMOHNJPKF<short>
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7E758F0", Offset = "0x7E74CF0", VA = "0x187E758F0", Slot = "9")]
	public override string PEGKBLBFNLH(short EOMFNMMGCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7E75850", Offset = "0x7E74C50", VA = "0x187E75850", Slot = "10")]
	protected override bool BMOOHPBBDGC(string EOMFNMMGCEC, [Out] short OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7E75950", Offset = "0x7E74D50", VA = "0x187E75950")]
	public BIHGFHEADGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal class APOGIDEPBAP : JLJMOHNJPKF<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7E75680", Offset = "0x7E74A80", VA = "0x187E75680", Slot = "9")]
	public override string PEGKBLBFNLH(ushort EOMFNMMGCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7E755E0", Offset = "0x7E749E0", VA = "0x187E755E0", Slot = "10")]
	protected override bool BMOOHPBBDGC(string EOMFNMMGCEC, [Out] ushort OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7E756E0", Offset = "0x7E74AE0", VA = "0x187E756E0")]
	public APOGIDEPBAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class INAFFFJIHAE : JLJMOHNJPKF<int>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7E76980", Offset = "0x7E75D80", VA = "0x187E76980", Slot = "9")]
	public override string PEGKBLBFNLH(int EOMFNMMGCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7E768F0", Offset = "0x7E75CF0", VA = "0x187E768F0", Slot = "10")]
	protected override bool BMOOHPBBDGC(string EOMFNMMGCEC, [Out] int OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7E769E0", Offset = "0x7E75DE0", VA = "0x187E769E0")]
	public INAFFFJIHAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class BBGHAKLOCJI : JLJMOHNJPKF<uint>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7E757B0", Offset = "0x7E74BB0", VA = "0x187E757B0", Slot = "9")]
	public override string PEGKBLBFNLH(uint EOMFNMMGCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7E75720", Offset = "0x7E74B20", VA = "0x187E75720", Slot = "10")]
	protected override bool BMOOHPBBDGC(string EOMFNMMGCEC, [Out] uint OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7E75810", Offset = "0x7E74C10", VA = "0x187E75810")]
	public BBGHAKLOCJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class AAPPEFLNKAC : JLJMOHNJPKF<long>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7E75540", Offset = "0x7E74940", VA = "0x187E75540", Slot = "9")]
	public override string PEGKBLBFNLH(long EOMFNMMGCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7E754A0", Offset = "0x7E748A0", VA = "0x187E754A0", Slot = "10")]
	protected override bool BMOOHPBBDGC(string EOMFNMMGCEC, [Out] long OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7E755A0", Offset = "0x7E749A0", VA = "0x187E755A0")]
	public AAPPEFLNKAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class JBDNHPKOLLF : JLJMOHNJPKF<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7E76AC0", Offset = "0x7E75EC0", VA = "0x187E76AC0", Slot = "9")]
	public override string PEGKBLBFNLH(ulong EOMFNMMGCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7E76A20", Offset = "0x7E75E20", VA = "0x187E76A20", Slot = "10")]
	protected override bool BMOOHPBBDGC(string EOMFNMMGCEC, [Out] ulong OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7E76B20", Offset = "0x7E75F20", VA = "0x187E76B20")]
	public JBDNHPKOLLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class IMIKOMIADFI : JLJMOHNJPKF<float>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7E76840", Offset = "0x7E75C40", VA = "0x187E76840", Slot = "9")]
	public override string PEGKBLBFNLH(float EOMFNMMGCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7E767B0", Offset = "0x7E75BB0", VA = "0x187E767B0", Slot = "10")]
	protected override bool BMOOHPBBDGC(string EOMFNMMGCEC, [Out] float OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7E768B0", Offset = "0x7E75CB0", VA = "0x187E768B0")]
	public IMIKOMIADFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface ANAPHPKBNPH
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string DIMNPMGBLBA(object EOMFNMMGCEC);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KJMAMIINEEN([CanBeNull] string EOMFNMMGCEC, [Out] object OOEMJLHLIHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LHMHCDCFGHO<T> : ANAPHPKBNPH
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string PEGKBLBFNLH(T EOMFNMMGCEC);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FHKPBMIIJEA([CanBeNull] string EOMFNMMGCEC, [Out] T OOEMJLHLIHJ);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T KKJLLBBGHCF([CanBeNull] string EOMFNMMGCEC, [Optional] T JMBBJHIBCGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class JLJMOHNJPKF<T> : LHMHCDCFGHO<T>, ANAPHPKBNPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Type GGFNDHFCLFA;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4CBA3C0", Offset = "0x4CB97C0", VA = "0x184CBA3C0")]
	protected JLJMOHNJPKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4CBA1B0", Offset = "0x4CB95B0", VA = "0x184CBA1B0")]
	private T MAFINOOPLAF(object KLANNNFBLNB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract string PEGKBLBFNLH(T EOMFNMMGCEC);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4CB9170", Offset = "0x4CB8570", VA = "0x184CB9170", Slot = "7")]
	public string DIMNPMGBLBA(object EOMFNMMGCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4CB93C0", Offset = "0x4CB87C0", VA = "0x184CB93C0", Slot = "5")]
	public bool FHKPBMIIJEA(string EOMFNMMGCEC, [Out] T OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool BMOOHPBBDGC([NotNull] string EOMFNMMGCEC, [Out] T OOEMJLHLIHJ);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4CB9680", Offset = "0x4CB8A80", VA = "0x184CB9680", Slot = "8")]
	private bool HPAJLEAJJHK(string EOMFNMMGCEC, [Out] object OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4CB9D10", Offset = "0x4CB9110", VA = "0x184CB9D10", Slot = "6")]
	public T KKJLLBBGHCF(string EOMFNMMGCEC, [Optional] T JMBBJHIBCGJ)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class HLAGHBIPOIO<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static LHMHCDCFGHO<T> GCAAODGDGAI
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x47C2DF0", Offset = "0x47C21F0", VA = "0x1847C2DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3ADB020", Offset = "0x3ADA420", VA = "0x183ADB020")]
	public static LHMHCDCFGHO<TSerialized> DHFKFFBLGIM<TSerialized>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x494ECA0", Offset = "0x494E0A0", VA = "0x18494ECA0")]
	public static ANAPHPKBNPH DHFKFFBLGIM(Type KMEHPELFJNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x494DB80", Offset = "0x494CF80", VA = "0x18494DB80")]
	private static ANAPHPKBNPH CHOIMCDCIEG(Type JIHGIEGKKAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4953A80", Offset = "0x4952E80", VA = "0x184953A80")]
	private static ANAPHPKBNPH KHINJNIOOJH(Type JIHGIEGKKAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class BMMPOJEPEEO<TCollection> : DMJOLAINDAE<TCollection, string> where TCollection : IEnumerable<string>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class KNBAMIBKKKK : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
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
		public BMMPOJEPEEO<TCollection> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private HINNEHFLCMG<StringBuilder> <_>5__2;

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
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xE69660", Offset = "0xE68A60", VA = "0x180E69660")]
		[DebuggerHidden]
		public KNBAMIBKKKK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4826C30", Offset = "0x4826030", VA = "0x184826C30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4E0EDF0", Offset = "0x4E0E1F0", VA = "0x184E0EDF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4E0EDA0", Offset = "0x4E0E1A0", VA = "0x184E0EDA0")]
		private void BIIMICBPMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4E0F350", Offset = "0x4E0E750", VA = "0x184E0F350", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4E0F270", Offset = "0x4E0E670", VA = "0x184E0F270", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4D58A10", Offset = "0x4D57E10", VA = "0x184D58A10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool BLDBEKEGPHH;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6082900", Offset = "0x6081D00", VA = "0x186082900")]
	protected BMMPOJEPEEO(bool BLDBEKEGPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x60826A0", Offset = "0x6081AA0", VA = "0x1860826A0", Slot = "9")]
	public override string PEGKBLBFNLH(TCollection EOMFNMMGCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6082560", Offset = "0x6081960", VA = "0x186082560", Slot = "12")]
	[IteratorStateMachine(typeof(BMMPOJEPEEO<>.KNBAMIBKKKK))]
	internal override IEnumerable<string> ACFCGKMHABI(string EOMFNMMGCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6082620", Offset = "0x6081A20", VA = "0x186082620")]
	[CompilerGenerated]
	internal static string NMOLLHLDENO(StringBuilder MFKCMECFFAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class IDMCKJCNEHH : BMMPOJEPEEO<List<string>>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7E76490", Offset = "0x7E75890", VA = "0x187E76490")]
	[Preserve]
	public IDMCKJCNEHH(bool BLDBEKEGPHH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7E76400", Offset = "0x7E75800", VA = "0x187E76400", Slot = "11")]
	protected override List<string> OBEMJLGGNEH(IEnumerable<string> GKIPCPOAHBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class MFAPGEPBNGJ : BMMPOJEPEEO<string[]>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7E76BC0", Offset = "0x7E75FC0", VA = "0x187E76BC0")]
	[Preserve]
	public MFAPGEPBNGJ(bool BLDBEKEGPHH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7E76B60", Offset = "0x7E75F60", VA = "0x187E76B60", Slot = "11")]
	protected override string[] OBEMJLGGNEH(IEnumerable<string> GKIPCPOAHBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class DPKNJHDHBGB : JLJMOHNJPKF<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA4EED0", Offset = "0xA4E2D0", VA = "0x180A4EED0", Slot = "9")]
	public override string PEGKBLBFNLH(string EOMFNMMGCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7E75B00", Offset = "0x7E74F00", VA = "0x187E75B00", Slot = "10")]
	protected override bool BMOOHPBBDGC(string EOMFNMMGCEC, [Out] string OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7E75B20", Offset = "0x7E74F20", VA = "0x187E75B20")]
	public DPKNJHDHBGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class IDMIFJNKOAN : JLJMOHNJPKF<TimeSpan>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7E76650", Offset = "0x7E75A50", VA = "0x187E76650", Slot = "9")]
	public override string PEGKBLBFNLH(TimeSpan EOMFNMMGCEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7E764E0", Offset = "0x7E758E0", VA = "0x187E764E0", Slot = "10")]
	protected override bool BMOOHPBBDGC(string EOMFNMMGCEC, [Out] TimeSpan OOEMJLHLIHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7E76770", Offset = "0x7E75B70", VA = "0x187E76770")]
	public IDMIFJNKOAN()
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
