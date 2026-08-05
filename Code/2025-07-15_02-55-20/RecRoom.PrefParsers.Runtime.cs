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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA87960", Offset = "0xA86560", VA = "0x180A87960")]
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
		[Cpp2IlInjected.Address(RVA = "0xA879A0", Offset = "0xA865A0", VA = "0x180A879A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HEAPNDIGKDJ : JAFMKCHMNCM<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x84DC190", Offset = "0x84DAD90", VA = "0x1884DC190", Slot = "9")]
	public override string PBHGMJKEMBG(bool HOKNBAKODNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x84DC130", Offset = "0x84DAD30", VA = "0x1884DC130", Slot = "10")]
	protected override bool CBGBJHBJJNJ(string HOKNBAKODNG, [Out] bool BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x84DC1E0", Offset = "0x84DADE0", VA = "0x1884DC1E0")]
	public HEAPNDIGKDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class KDIDJHCBEGM : JAFMKCHMNCM<DateTime>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x84DC930", Offset = "0x84DB530", VA = "0x1884DC930", Slot = "9")]
	public override string PBHGMJKEMBG(DateTime HOKNBAKODNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x84DC890", Offset = "0x84DB490", VA = "0x1884DC890", Slot = "10")]
	protected override bool CBGBJHBJJNJ(string HOKNBAKODNG, [Out] DateTime BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x84DC9C0", Offset = "0x84DB5C0", VA = "0x1884DC9C0")]
	public KDIDJHCBEGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HCMLPFGPMLI<TEnum> : JAFMKCHMNCM<TEnum> where TEnum : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly Type IPGKEGBKDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool BAHDLDGNDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly TEnum[] OKFGGFMLPHB;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4F668F0", Offset = "0x4F654F0", VA = "0x184F668F0")]
	[Preserve]
	public HCMLPFGPMLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4F66610", Offset = "0x4F65210", VA = "0x184F66610", Slot = "9")]
	public override string PBHGMJKEMBG(TEnum HOKNBAKODNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4F66540", Offset = "0x4F65140", VA = "0x184F66540", Slot = "10")]
	protected override bool CBGBJHBJJNJ(string HOKNBAKODNG, [Out] TEnum BKMPCFIAHIG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class JAOIDJBNKOP<TEnum> : JAFMKCHMNCM<TEnum> where TEnum : Enum
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Type IPGKEGBKDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly FCADKPOOBJF AHHHAAMPKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly bool BAHDLDGNDPJ;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x529ECE0", Offset = "0x529D8E0", VA = "0x18529ECE0")]
	[Preserve]
	public JAOIDJBNKOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x529EAA0", Offset = "0x529D6A0", VA = "0x18529EAA0", Slot = "9")]
	public override string PBHGMJKEMBG(TEnum HOKNBAKODNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x529E4E0", Offset = "0x529D0E0", VA = "0x18529E4E0", Slot = "10")]
	protected override bool CBGBJHBJJNJ(string HOKNBAKODNG, [Out] TEnum BKMPCFIAHIG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class BFJMOGBPLFO
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly Dictionary<Type, FCADKPOOBJF> KNOMKDLEOKJ;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x84DB4F0", Offset = "0x84DA0F0", VA = "0x1884DB4F0")]
	public static FCADKPOOBJF MKNDKOHAHCL(Type NOMMBJCMDKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class JAFGIKJNEAE<T> : JAFMKCHMNCM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3CC5700", Offset = "0x3CC4300", VA = "0x183CC5700", Slot = "9")]
	public override string PBHGMJKEMBG(T HOKNBAKODNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5295600", Offset = "0x5294200", VA = "0x185295600", Slot = "10")]
	protected override bool CBGBJHBJJNJ(string HOKNBAKODNG, [Out] T BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x48B9E40", Offset = "0x48B8A40", VA = "0x1848B9E40")]
	public JAFGIKJNEAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class DIMAPLHCCAI<TCollection, T> : JAFMKCHMNCM<TCollection> where TCollection : IEnumerable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly GALLHJHCGIC<T> ONMEDPKKGDG;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x446A760", Offset = "0x4469360", VA = "0x18446A760")]
	protected DIMAPLHCCAI(GALLHJHCGIC<T> ONMEDPKKGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x446A220", Offset = "0x4468E20", VA = "0x18446A220", Slot = "9")]
	public override string PBHGMJKEMBG(TCollection HOKNBAKODNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x44690A0", Offset = "0x4467CA0", VA = "0x1844690A0", Slot = "10")]
	protected override bool CBGBJHBJJNJ(string HOKNBAKODNG, [Out] TCollection BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract TCollection NHNBKMJMLID(IEnumerable<T> CLKDMEDAKFD);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4469BD0", Offset = "0x44687D0", VA = "0x184469BD0", Slot = "12")]
	internal virtual IEnumerable<string> OMDNBOBHGNB(string HOKNBAKODNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4469B20", Offset = "0x4468720", VA = "0x184469B20")]
	[CompilerGenerated]
	private string LJPPGLMEHFL(T DNDKHMOJDEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class LGNPFMEAOOE<T> : DIMAPLHCCAI<T[], T>
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4EA72C0", Offset = "0x4EA5EC0", VA = "0x184EA72C0")]
	[Preserve]
	public LGNPFMEAOOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x445D2A0", Offset = "0x445BEA0", VA = "0x18445D2A0")]
	[Preserve]
	public LGNPFMEAOOE(GALLHJHCGIC<T> ONMEDPKKGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5461DF0", Offset = "0x54609F0", VA = "0x185461DF0", Slot = "11")]
	protected override T[] NHNBKMJMLID(IEnumerable<T> CLKDMEDAKFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class IIMPLOPPIOF<T> : DIMAPLHCCAI<List<T>, T>
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4EA72C0", Offset = "0x4EA5EC0", VA = "0x184EA72C0")]
	[Preserve]
	public IIMPLOPPIOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x445D2A0", Offset = "0x445BEA0", VA = "0x18445D2A0")]
	[Preserve]
	public IIMPLOPPIOF([Optional] GALLHJHCGIC<T> ONMEDPKKGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x50795B0", Offset = "0x50781B0", VA = "0x1850795B0", Slot = "11")]
	protected override List<T> NHNBKMJMLID(IEnumerable<T> CLKDMEDAKFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PFNEHKMJENC<T> : JAFMKCHMNCM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JsonSerializerSettings? FPDGHGMMJFI;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x56E3640", Offset = "0x56E2240", VA = "0x1856E3640")]
	public PFNEHKMJENC(JsonSerializerSettings? CLEPLKICHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x59BFF00", Offset = "0x59BEB00", VA = "0x1859BFF00", Slot = "9")]
	public override string PBHGMJKEMBG(T HOKNBAKODNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x59BFE40", Offset = "0x59BEA40", VA = "0x1859BFE40", Slot = "10")]
	protected override bool CBGBJHBJJNJ([NotNull] string HOKNBAKODNG, [Out] T BKMPCFIAHIG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class HGJBCBJHCNJ : JAFMKCHMNCM<byte>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x84DC2B0", Offset = "0x84DAEB0", VA = "0x1884DC2B0", Slot = "9")]
	public override string PBHGMJKEMBG(byte HOKNBAKODNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x84DC220", Offset = "0x84DAE20", VA = "0x1884DC220", Slot = "10")]
	protected override bool CBGBJHBJJNJ(string HOKNBAKODNG, [Out] byte BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x84DC310", Offset = "0x84DAF10", VA = "0x1884DC310")]
	public HGJBCBJHCNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class JCGNNACKEPK : JAFMKCHMNCM<short>
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x84DC530", Offset = "0x84DB130", VA = "0x1884DC530", Slot = "9")]
	public override string PBHGMJKEMBG(short HOKNBAKODNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x84DC490", Offset = "0x84DB090", VA = "0x1884DC490", Slot = "10")]
	protected override bool CBGBJHBJJNJ(string HOKNBAKODNG, [Out] short BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x84DC590", Offset = "0x84DB190", VA = "0x1884DC590")]
	public JCGNNACKEPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal class NDBFJFCINAN : JAFMKCHMNCM<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x84DCAA0", Offset = "0x84DB6A0", VA = "0x1884DCAA0", Slot = "9")]
	public override string PBHGMJKEMBG(ushort HOKNBAKODNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x84DCA00", Offset = "0x84DB600", VA = "0x1884DCA00", Slot = "10")]
	protected override bool CBGBJHBJJNJ(string HOKNBAKODNG, [Out] ushort BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x84DCB00", Offset = "0x84DB700", VA = "0x1884DCB00")]
	public NDBFJFCINAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JLDJFBJHODB : JAFMKCHMNCM<int>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x84DC790", Offset = "0x84DB390", VA = "0x1884DC790", Slot = "9")]
	public override string PBHGMJKEMBG(int HOKNBAKODNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x84DC700", Offset = "0x84DB300", VA = "0x1884DC700", Slot = "10")]
	protected override bool CBGBJHBJJNJ(string HOKNBAKODNG, [Out] int BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x84DC7F0", Offset = "0x84DB3F0", VA = "0x1884DC7F0")]
	public JLDJFBJHODB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class JCLLFMGCECO : JAFMKCHMNCM<uint>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x84DC660", Offset = "0x84DB260", VA = "0x1884DC660", Slot = "9")]
	public override string PBHGMJKEMBG(uint HOKNBAKODNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x84DC5D0", Offset = "0x84DB1D0", VA = "0x1884DC5D0", Slot = "10")]
	protected override bool CBGBJHBJJNJ(string HOKNBAKODNG, [Out] uint BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x84DC6C0", Offset = "0x84DB2C0", VA = "0x1884DC6C0")]
	public JCLLFMGCECO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class AGFGPAOGMGF : JAFMKCHMNCM<long>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x84DB450", Offset = "0x84DA050", VA = "0x1884DB450", Slot = "9")]
	public override string PBHGMJKEMBG(long HOKNBAKODNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x84DB3B0", Offset = "0x84D9FB0", VA = "0x1884DB3B0", Slot = "10")]
	protected override bool CBGBJHBJJNJ(string HOKNBAKODNG, [Out] long BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x84DB4B0", Offset = "0x84DA0B0", VA = "0x1884DB4B0")]
	public AGFGPAOGMGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class DMJPPNFCKMO : JAFMKCHMNCM<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x84DBFB0", Offset = "0x84DABB0", VA = "0x1884DBFB0", Slot = "9")]
	public override string PBHGMJKEMBG(ulong HOKNBAKODNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x84DBF10", Offset = "0x84DAB10", VA = "0x1884DBF10", Slot = "10")]
	protected override bool CBGBJHBJJNJ(string HOKNBAKODNG, [Out] ulong BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x84DC010", Offset = "0x84DAC10", VA = "0x1884DC010")]
	public DMJPPNFCKMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class HOOPMEFAOHG : JAFMKCHMNCM<float>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x84DC3E0", Offset = "0x84DAFE0", VA = "0x1884DC3E0", Slot = "9")]
	public override string PBHGMJKEMBG(float HOKNBAKODNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x84DC350", Offset = "0x84DAF50", VA = "0x1884DC350", Slot = "10")]
	protected override bool CBGBJHBJJNJ(string HOKNBAKODNG, [Out] float BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x84DC450", Offset = "0x84DB050", VA = "0x1884DC450")]
	public HOOPMEFAOHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface FCADKPOOBJF
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string MNFEFKLHEDE(object HOKNBAKODNG);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HCIBDMFGEKG([CanBeNull] string HOKNBAKODNG, [Out] object BKMPCFIAHIG);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface GALLHJHCGIC<T> : FCADKPOOBJF
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string PBHGMJKEMBG(T HOKNBAKODNG);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NEKBDFCIJDE([CanBeNull] string HOKNBAKODNG, [Out] T BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T FHPJMPLPPCO([CanBeNull] string HOKNBAKODNG, [Optional] T PLEDLJICBFM);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class JAFMKCHMNCM<T> : GALLHJHCGIC<T>, FCADKPOOBJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Type HLNNCMEACIH;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5296CB0", Offset = "0x52958B0", VA = "0x185296CB0")]
	protected JAFMKCHMNCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5295E40", Offset = "0x5294A40", VA = "0x185295E40")]
	private T BIFJMNHHGHO(object KOJLNGLNBMH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract string PBHGMJKEMBG(T HOKNBAKODNG);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5296AE0", Offset = "0x52956E0", VA = "0x185296AE0", Slot = "7")]
	public string MNFEFKLHEDE(object HOKNBAKODNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5296C30", Offset = "0x5295830", VA = "0x185296C30", Slot = "5")]
	public bool NEKBDFCIJDE(string HOKNBAKODNG, [Out] T BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool CBGBJHBJJNJ([NotNull] string HOKNBAKODNG, [Out] T BKMPCFIAHIG);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x52960C0", Offset = "0x5294CC0", VA = "0x1852960C0", Slot = "8")]
	private bool CFECJJKPGFC(string HOKNBAKODNG, [Out] object BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5296780", Offset = "0x5295380", VA = "0x185296780", Slot = "6")]
	public T FHPJMPLPPCO(string HOKNBAKODNG, [Optional] T PLEDLJICBFM)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class CEGLKDJOIEH<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static GALLHJHCGIC<T> JOFMPALJJOB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4D46770", Offset = "0x4D45370", VA = "0x184D46770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3EAA260", Offset = "0x3EA8E60", VA = "0x183EAA260")]
	public static GALLHJHCGIC<TSerialized> MGDGHBPBCMO<TSerialized>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C390", Offset = "0x6A7AF90", VA = "0x186A7C390")]
	public static FCADKPOOBJF MGDGHBPBCMO(Type AMMMGEJJKKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6A76910", Offset = "0x6A75510", VA = "0x186A76910")]
	private static FCADKPOOBJF EHKEAOGOFAG(Type LDDADBFCAAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6A793E0", Offset = "0x6A77FE0", VA = "0x186A793E0")]
	private static FCADKPOOBJF MAFPNHNINJO(Type LDDADBFCAAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class DNEABKPABPK<TCollection> : DIMAPLHCCAI<TCollection, string> where TCollection : IEnumerable<string>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class EHOENFNHNKL : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
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
		public DNEABKPABPK<TCollection> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private PDMICMOCKGB<StringBuilder> <_>5__2;

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
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xF91620", Offset = "0xF90220", VA = "0x180F91620")]
		[DebuggerHidden]
		public EHOENFNHNKL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x48D83C0", Offset = "0x48D6FC0", VA = "0x1848D83C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x48D7E40", Offset = "0x48D6A40", VA = "0x1848D7E40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x48D7DF0", Offset = "0x48D69F0", VA = "0x1848D7DF0")]
		private void BOPPOGEKEOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x48D8370", Offset = "0x48D6F70", VA = "0x1848D8370", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x48D8290", Offset = "0x48D6E90", VA = "0x1848D8290", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x48D8350", Offset = "0x48D6F50", VA = "0x1848D8350", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool AIPOLIBMNHD;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4477CF0", Offset = "0x44768F0", VA = "0x184477CF0")]
	protected DNEABKPABPK(bool AIPOLIBMNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4477AB0", Offset = "0x44766B0", VA = "0x184477AB0", Slot = "9")]
	public override string PBHGMJKEMBG(TCollection HOKNBAKODNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4477A00", Offset = "0x4476600", VA = "0x184477A00", Slot = "12")]
	[IteratorStateMachine(typeof(DNEABKPABPK<>.EHOENFNHNKL))]
	internal override IEnumerable<string> OMDNBOBHGNB(string HOKNBAKODNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4477980", Offset = "0x4476580", VA = "0x184477980")]
	[CompilerGenerated]
	internal static string IJBFALDODLD(StringBuilder APECMGHDCNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class FABDDKGFACO : DNEABKPABPK<List<string>>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x84DC0E0", Offset = "0x84DACE0", VA = "0x1884DC0E0")]
	[Preserve]
	public FABDDKGFACO(bool AIPOLIBMNHD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x84DC050", Offset = "0x84DAC50", VA = "0x1884DC050", Slot = "11")]
	protected override List<string> NHNBKMJMLID(IEnumerable<string> CLKDMEDAKFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class NKHEEFPHADG : DNEABKPABPK<string[]>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x84DCBA0", Offset = "0x84DB7A0", VA = "0x1884DCBA0")]
	[Preserve]
	public NKHEEFPHADG(bool AIPOLIBMNHD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x84DCB40", Offset = "0x84DB740", VA = "0x1884DCB40", Slot = "11")]
	protected override string[] NHNBKMJMLID(IEnumerable<string> CLKDMEDAKFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class JLJNGDHDHEK : JAFMKCHMNCM<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xAE5310", Offset = "0xAE3F10", VA = "0x180AE5310", Slot = "9")]
	public override string PBHGMJKEMBG(string HOKNBAKODNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x84DC830", Offset = "0x84DB430", VA = "0x1884DC830", Slot = "10")]
	protected override bool CBGBJHBJJNJ(string HOKNBAKODNG, [Out] string BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x84DC850", Offset = "0x84DB450", VA = "0x1884DC850")]
	public JLJNGDHDHEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class CNCOLMIMFKE : JAFMKCHMNCM<TimeSpan>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x84DBDB0", Offset = "0x84DA9B0", VA = "0x1884DBDB0", Slot = "9")]
	public override string PBHGMJKEMBG(TimeSpan HOKNBAKODNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x84DBC40", Offset = "0x84DA840", VA = "0x1884DBC40", Slot = "10")]
	protected override bool CBGBJHBJJNJ(string HOKNBAKODNG, [Out] TimeSpan BKMPCFIAHIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x84DBED0", Offset = "0x84DAAD0", VA = "0x1884DBED0")]
	public CNCOLMIMFKE()
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
