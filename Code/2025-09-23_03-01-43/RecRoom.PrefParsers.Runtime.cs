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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD1900", Offset = "0xACFF00", VA = "0x180AD1900")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD1940", Offset = "0xACFF40", VA = "0x180AD1940")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CGICEFPDPAF : HAHHNFCMALN<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x88E1670", Offset = "0x88DFC70", VA = "0x1888E1670", Slot = "9")]
	public override string ANHNANMIGBP(bool ECBHOIMIBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x88E16C0", Offset = "0x88DFCC0", VA = "0x1888E16C0", Slot = "10")]
	protected override bool MEIFKFJCAFB(string ECBHOIMIBKD, [Out] bool KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x88E1720", Offset = "0x88DFD20", VA = "0x1888E1720")]
	public CGICEFPDPAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class NAELKJEIFEO : HAHHNFCMALN<DateTime>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x88E29B0", Offset = "0x88E0FB0", VA = "0x1888E29B0", Slot = "9")]
	public override string ANHNANMIGBP(DateTime ECBHOIMIBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x88E2A40", Offset = "0x88E1040", VA = "0x1888E2A40", Slot = "10")]
	protected override bool MEIFKFJCAFB(string ECBHOIMIBKD, [Out] DateTime KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x88E2AE0", Offset = "0x88E10E0", VA = "0x1888E2AE0")]
	public NAELKJEIFEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class DOAALMKPAGM<TEnum> : HAHHNFCMALN<TEnum> where TEnum : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly Type EFHHFOIKMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool AOJHNFNNEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly TEnum[] LGMBOCEBOMM;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x467A510", Offset = "0x4678B10", VA = "0x18467A510")]
	[Preserve]
	public DOAALMKPAGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x467A140", Offset = "0x4678740", VA = "0x18467A140", Slot = "9")]
	public override string ANHNANMIGBP(TEnum ECBHOIMIBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x467A340", Offset = "0x4678940", VA = "0x18467A340", Slot = "10")]
	protected override bool MEIFKFJCAFB(string ECBHOIMIBKD, [Out] TEnum KOPHBHGIACG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MOCFKEMGAFA<TEnum> : HAHHNFCMALN<TEnum> where TEnum : Enum
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Type EFHHFOIKMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly PMDIGBBIFEC CMLGCEKIICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly bool AOJHNFNNEGH;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5A23640", Offset = "0x5A21C40", VA = "0x185A23640")]
	[Preserve]
	public MOCFKEMGAFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5A22ED0", Offset = "0x5A214D0", VA = "0x185A22ED0", Slot = "9")]
	public override string ANHNANMIGBP(TEnum ECBHOIMIBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5A22FC0", Offset = "0x5A215C0", VA = "0x185A22FC0", Slot = "10")]
	protected override bool MEIFKFJCAFB(string ECBHOIMIBKD, [Out] TEnum KOPHBHGIACG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class IPJNELACFFE
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly Dictionary<Type, PMDIGBBIFEC> KKENHLECPDE;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x88E1E90", Offset = "0x88E0490", VA = "0x1888E1E90")]
	public static PMDIGBBIFEC DHBMJEFLGPD(Type PCGLJNGDHKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class BJFGANLBAML<T> : HAHHNFCMALN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3DFA310", Offset = "0x3DF8910", VA = "0x183DFA310", Slot = "9")]
	public override string ANHNANMIGBP(T ECBHOIMIBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6AF6FE0", Offset = "0x6AF55E0", VA = "0x186AF6FE0", Slot = "10")]
	protected override bool MEIFKFJCAFB(string ECBHOIMIBKD, [Out] T KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4AEA9E0", Offset = "0x4AE8FE0", VA = "0x184AEA9E0")]
	public BJFGANLBAML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class AMPJDEIJOKJ<TCollection, T> : HAHHNFCMALN<TCollection> where TCollection : IEnumerable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly DBKDDFMBAOI<T> EKOBCDLEOBP;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5836180", Offset = "0x5834780", VA = "0x185836180")]
	protected AMPJDEIJOKJ(DBKDDFMBAOI<T> EKOBCDLEOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x58325F0", Offset = "0x5830BF0", VA = "0x1858325F0", Slot = "9")]
	public override string ANHNANMIGBP(TCollection ECBHOIMIBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5834D20", Offset = "0x5833320", VA = "0x185834D20", Slot = "10")]
	protected override bool MEIFKFJCAFB(string ECBHOIMIBKD, [Out] TCollection KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract TCollection BPMPJGDBOEO(IEnumerable<T> PCCGPNIJDPB);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x58324E0", Offset = "0x5830AE0", VA = "0x1858324E0", Slot = "12")]
	internal virtual IEnumerable<string> ALPLDHEAGIG(string ECBHOIMIBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5833490", Offset = "0x5831A90", VA = "0x185833490")]
	[CompilerGenerated]
	private string JLJGFLJJHDM(T KMDIJJMODFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class HOAPFKJIGCB<T> : AMPJDEIJOKJ<T[], T>
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4FEB3B0", Offset = "0x4FE99B0", VA = "0x184FEB3B0")]
	[Preserve]
	public HOAPFKJIGCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x46494A0", Offset = "0x4647AA0", VA = "0x1846494A0")]
	[Preserve]
	public HOAPFKJIGCB(DBKDDFMBAOI<T> EKOBCDLEOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x517F850", Offset = "0x517DE50", VA = "0x18517F850", Slot = "11")]
	protected override T[] BPMPJGDBOEO(IEnumerable<T> PCCGPNIJDPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class AIDJOKLIBFI<T> : AMPJDEIJOKJ<List<T>, T>
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4FEB3B0", Offset = "0x4FE99B0", VA = "0x184FEB3B0")]
	[Preserve]
	public AIDJOKLIBFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x46494A0", Offset = "0x4647AA0", VA = "0x1846494A0")]
	[Preserve]
	public AIDJOKLIBFI([Optional] DBKDDFMBAOI<T> EKOBCDLEOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5413230", Offset = "0x5411830", VA = "0x185413230", Slot = "11")]
	protected override List<T> BPMPJGDBOEO(IEnumerable<T> PCCGPNIJDPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class JBFLDHJMKEN<T> : HAHHNFCMALN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JsonSerializerSettings? NPCCLNILHKL;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x54B5E50", Offset = "0x54B4450", VA = "0x1854B5E50")]
	public JBFLDHJMKEN(JsonSerializerSettings? IJIFLDLCHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x54B5D30", Offset = "0x54B4330", VA = "0x1854B5D30", Slot = "9")]
	public override string ANHNANMIGBP(T ECBHOIMIBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x54B5D90", Offset = "0x54B4390", VA = "0x1854B5D90", Slot = "10")]
	protected override bool MEIFKFJCAFB([NotNull] string ECBHOIMIBKD, [Out] T KOPHBHGIACG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class CAGGNIFFILC : HAHHNFCMALN<byte>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x88E1540", Offset = "0x88DFB40", VA = "0x1888E1540", Slot = "9")]
	public override string ANHNANMIGBP(byte ECBHOIMIBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x88E15A0", Offset = "0x88DFBA0", VA = "0x1888E15A0", Slot = "10")]
	protected override bool MEIFKFJCAFB(string ECBHOIMIBKD, [Out] byte KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x88E1630", Offset = "0x88DFC30", VA = "0x1888E1630")]
	public CAGGNIFFILC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class GPFCGFLLHND : HAHHNFCMALN<short>
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x88E1C20", Offset = "0x88E0220", VA = "0x1888E1C20", Slot = "9")]
	public override string ANHNANMIGBP(short ECBHOIMIBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x88E1C80", Offset = "0x88E0280", VA = "0x1888E1C80", Slot = "10")]
	protected override bool MEIFKFJCAFB(string ECBHOIMIBKD, [Out] short KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x88E1D20", Offset = "0x88E0320", VA = "0x1888E1D20")]
	public GPFCGFLLHND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal class CPHBAJCPNNE : HAHHNFCMALN<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x88E17C0", Offset = "0x88DFDC0", VA = "0x1888E17C0", Slot = "9")]
	public override string ANHNANMIGBP(ushort ECBHOIMIBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x88E1820", Offset = "0x88DFE20", VA = "0x1888E1820", Slot = "10")]
	protected override bool MEIFKFJCAFB(string ECBHOIMIBKD, [Out] ushort KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x88E18C0", Offset = "0x88DFEC0", VA = "0x1888E18C0")]
	public CPHBAJCPNNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HKJNMECHION : HAHHNFCMALN<int>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x88E1D60", Offset = "0x88E0360", VA = "0x1888E1D60", Slot = "9")]
	public override string ANHNANMIGBP(int ECBHOIMIBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x88E1DC0", Offset = "0x88E03C0", VA = "0x1888E1DC0", Slot = "10")]
	protected override bool MEIFKFJCAFB(string ECBHOIMIBKD, [Out] int KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x88E1E50", Offset = "0x88E0450", VA = "0x1888E1E50")]
	public HKJNMECHION()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class EEFCCKPBFOI : HAHHNFCMALN<uint>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x88E1900", Offset = "0x88DFF00", VA = "0x1888E1900", Slot = "9")]
	public override string ANHNANMIGBP(uint ECBHOIMIBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x88E1960", Offset = "0x88DFF60", VA = "0x1888E1960", Slot = "10")]
	protected override bool MEIFKFJCAFB(string ECBHOIMIBKD, [Out] uint KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x88E19F0", Offset = "0x88DFFF0", VA = "0x1888E19F0")]
	public EEFCCKPBFOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class GGDGFANECIM : HAHHNFCMALN<long>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x88E1AE0", Offset = "0x88E00E0", VA = "0x1888E1AE0", Slot = "9")]
	public override string ANHNANMIGBP(long ECBHOIMIBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x88E1B40", Offset = "0x88E0140", VA = "0x1888E1B40", Slot = "10")]
	protected override bool MEIFKFJCAFB(string ECBHOIMIBKD, [Out] long KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x88E1BE0", Offset = "0x88E01E0", VA = "0x1888E1BE0")]
	public GGDGFANECIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class NLCBEGKBANK : HAHHNFCMALN<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x88E2B20", Offset = "0x88E1120", VA = "0x1888E2B20", Slot = "9")]
	public override string ANHNANMIGBP(ulong ECBHOIMIBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x88E2B80", Offset = "0x88E1180", VA = "0x1888E2B80", Slot = "10")]
	protected override bool MEIFKFJCAFB(string ECBHOIMIBKD, [Out] ulong KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x88E2C20", Offset = "0x88E1220", VA = "0x1888E2C20")]
	public NLCBEGKBANK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class PKMJCKEPDGM : HAHHNFCMALN<float>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x88E2C60", Offset = "0x88E1260", VA = "0x1888E2C60", Slot = "9")]
	public override string ANHNANMIGBP(float ECBHOIMIBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x88E2CD0", Offset = "0x88E12D0", VA = "0x1888E2CD0", Slot = "10")]
	protected override bool MEIFKFJCAFB(string ECBHOIMIBKD, [Out] float KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x88E2D60", Offset = "0x88E1360", VA = "0x1888E2D60")]
	public PKMJCKEPDGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface PMDIGBBIFEC
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string FJLFFCPOCEO(object ECBHOIMIBKD);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BBBNNNNLPKG([CanBeNull] string ECBHOIMIBKD, [Out] object KOPHBHGIACG);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DBKDDFMBAOI<T> : PMDIGBBIFEC
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string ANHNANMIGBP(T ECBHOIMIBKD);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KKCEGINDOMB([CanBeNull] string ECBHOIMIBKD, [Out] T KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T DJLDABNKCKM([CanBeNull] string ECBHOIMIBKD, [Optional] T APJDJFMLEAP);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class HAHHNFCMALN<T> : DBKDDFMBAOI<T>, PMDIGBBIFEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Type MPEPKHANNAP;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x514D740", Offset = "0x514BD40", VA = "0x18514D740")]
	protected HAHHNFCMALN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x514CD90", Offset = "0x514B390", VA = "0x18514CD90")]
	private T NAJLLPCKMEJ(object MPIDDJPOOMJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract string ANHNANMIGBP(T ECBHOIMIBKD);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x514C320", Offset = "0x514A920", VA = "0x18514C320", Slot = "7")]
	public string FJLFFCPOCEO(object ECBHOIMIBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x514C530", Offset = "0x514AB30", VA = "0x18514C530", Slot = "5")]
	public bool KKCEGINDOMB(string ECBHOIMIBKD, [Out] T KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool MEIFKFJCAFB([NotNull] string ECBHOIMIBKD, [Out] T KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x514C7C0", Offset = "0x514ADC0", VA = "0x18514C7C0", Slot = "8")]
	private bool MGDINMOHHDC(string ECBHOIMIBKD, [Out] object KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x514C080", Offset = "0x514A680", VA = "0x18514C080", Slot = "6")]
	public T DJLDABNKCKM(string ECBHOIMIBKD, [Optional] T APJDJFMLEAP)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class PEGGEJNKHJH<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static DBKDDFMBAOI<T> DKABDBMACEB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4FDEEB0", Offset = "0x4FDD4B0", VA = "0x184FDEEB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x45434D0", Offset = "0x4541AD0", VA = "0x1845434D0")]
	public static DBKDDFMBAOI<TSerialized> AIHAMAJFELK<TSerialized>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5CAFC90", Offset = "0x5CAE290", VA = "0x185CAFC90")]
	public static PMDIGBBIFEC AIHAMAJFELK(Type HHEBLMHCIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5CB3690", Offset = "0x5CB1C90", VA = "0x185CB3690")]
	private static PMDIGBBIFEC DKLHIIPKFEC(Type NJLCGBCMDCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5CB7210", Offset = "0x5CB5810", VA = "0x185CB7210")]
	private static PMDIGBBIFEC HJEJDGLMFHG(Type NJLCGBCMDCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class INNMOLBJHGA<TCollection> : AMPJDEIJOKJ<TCollection, string> where TCollection : IEnumerable<string>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class PHJIPJOFGBE : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
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
		public INNMOLBJHGA<TCollection> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private HDIABMFJAIH<StringBuilder> <_>5__2;

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
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xBF4940", Offset = "0xBF2F40", VA = "0x180BF4940")]
		[DebuggerHidden]
		public PHJIPJOFGBE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4B26EC0", Offset = "0x4B254C0", VA = "0x184B26EC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5CD4120", Offset = "0x5CD2720", VA = "0x185CD4120", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5CD40D0", Offset = "0x5CD26D0", VA = "0x185CD40D0")]
		private void MPMIGDGBFBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5CD4650", Offset = "0x5CD2C50", VA = "0x185CD4650", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5CD4580", Offset = "0x5CD2B80", VA = "0x185CD4580", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x55A2660", Offset = "0x55A0C60", VA = "0x1855A2660", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool CLLHOFKFKBM;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x52A2F90", Offset = "0x52A1590", VA = "0x1852A2F90")]
	protected INNMOLBJHGA(bool CLLHOFKFKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x52A2CB0", Offset = "0x52A12B0", VA = "0x1852A2CB0", Slot = "9")]
	public override string ANHNANMIGBP(TCollection ECBHOIMIBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x52A2C00", Offset = "0x52A1200", VA = "0x1852A2C00", Slot = "12")]
	[IteratorStateMachine(typeof(INNMOLBJHGA<>.PHJIPJOFGBE))]
	internal override IEnumerable<string> ALPLDHEAGIG(string ECBHOIMIBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x52A2F10", Offset = "0x52A1510", VA = "0x1852A2F10")]
	[CompilerGenerated]
	internal static string IFBLIDCGLGB(StringBuilder PKEPAGIAPCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class LMOGBBPDACB : INNMOLBJHGA<List<string>>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x88E2960", Offset = "0x88E0F60", VA = "0x1888E2960")]
	[Preserve]
	public LMOGBBPDACB(bool CLLHOFKFKBM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x88E28D0", Offset = "0x88E0ED0", VA = "0x1888E28D0", Slot = "11")]
	protected override List<string> BPMPJGDBOEO(IEnumerable<string> PCCGPNIJDPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class EJFMHPGOEDO : INNMOLBJHGA<string[]>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x88E1A90", Offset = "0x88E0090", VA = "0x1888E1A90")]
	[Preserve]
	public EJFMHPGOEDO(bool CLLHOFKFKBM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x88E1A30", Offset = "0x88E0030", VA = "0x1888E1A30", Slot = "11")]
	protected override string[] BPMPJGDBOEO(IEnumerable<string> PCCGPNIJDPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class CPADPHAMICD : HAHHNFCMALN<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xB0AB10", Offset = "0xB09110", VA = "0x180B0AB10", Slot = "9")]
	public override string ANHNANMIGBP(string ECBHOIMIBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x88E1760", Offset = "0x88DFD60", VA = "0x1888E1760", Slot = "10")]
	protected override bool MEIFKFJCAFB(string ECBHOIMIBKD, [Out] string KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x88E1780", Offset = "0x88DFD80", VA = "0x1888E1780")]
	public CPADPHAMICD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class KINAMICIJKP : HAHHNFCMALN<TimeSpan>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x88E2600", Offset = "0x88E0C00", VA = "0x1888E2600", Slot = "9")]
	public override string ANHNANMIGBP(TimeSpan ECBHOIMIBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x88E2720", Offset = "0x88E0D20", VA = "0x1888E2720", Slot = "10")]
	protected override bool MEIFKFJCAFB(string ECBHOIMIBKD, [Out] TimeSpan KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x88E2890", Offset = "0x88E0E90", VA = "0x1888E2890")]
	public KINAMICIJKP()
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
