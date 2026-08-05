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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA34390", Offset = "0xA33190", VA = "0x180A34390")]
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
		[Cpp2IlInjected.Address(RVA = "0xA343D0", Offset = "0xA331D0", VA = "0x180A343D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class DMMIHJMMCPK : HCLLCDKNBCK<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8160DF0", Offset = "0x815FBF0", VA = "0x188160DF0", Slot = "9")]
	public override string KIDMEGDOMCG(bool DGDLKJDMLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8160D90", Offset = "0x815FB90", VA = "0x188160D90", Slot = "10")]
	protected override bool HBBCFKILGIC(string DGDLKJDMLAD, [Out] bool OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8160E40", Offset = "0x815FC40", VA = "0x188160E40")]
	public DMMIHJMMCPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class PBAGJOGLKHO : HCLLCDKNBCK<DateTime>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8161C80", Offset = "0x8160A80", VA = "0x188161C80", Slot = "9")]
	public override string KIDMEGDOMCG(DateTime DGDLKJDMLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8161BE0", Offset = "0x81609E0", VA = "0x188161BE0", Slot = "10")]
	protected override bool HBBCFKILGIC(string DGDLKJDMLAD, [Out] DateTime OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8161D10", Offset = "0x8160B10", VA = "0x188161D10")]
	public PBAGJOGLKHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class IDPKBJGPPEF<TEnum> : HCLLCDKNBCK<TEnum> where TEnum : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly Type KHGGMDCPNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool MILLNLHFCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly TEnum[] BGBLHEHBHCD;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4D2ED20", Offset = "0x4D2DB20", VA = "0x184D2ED20")]
	[Preserve]
	public IDPKBJGPPEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4D2E9F0", Offset = "0x4D2D7F0", VA = "0x184D2E9F0", Slot = "9")]
	public override string KIDMEGDOMCG(TEnum DGDLKJDMLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4D2E910", Offset = "0x4D2D710", VA = "0x184D2E910", Slot = "10")]
	protected override bool HBBCFKILGIC(string DGDLKJDMLAD, [Out] TEnum OAIIHELJHLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class FONHKHBNOAN<TEnum> : HCLLCDKNBCK<TEnum> where TEnum : Enum
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Type KHGGMDCPNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CCKBCNBPKJF PBMBOEIOPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly bool MILLNLHFCEA;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4ADB970", Offset = "0x4ADA770", VA = "0x184ADB970")]
	[Preserve]
	public FONHKHBNOAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4ADB720", Offset = "0x4ADA520", VA = "0x184ADB720", Slot = "9")]
	public override string KIDMEGDOMCG(TEnum DGDLKJDMLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4ADB410", Offset = "0x4ADA210", VA = "0x184ADB410", Slot = "10")]
	protected override bool HBBCFKILGIC(string DGDLKJDMLAD, [Out] TEnum OAIIHELJHLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class CMFNMHKBDHF
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly Dictionary<Type, CCKBCNBPKJF> FPPLDMCOIMM;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8160640", Offset = "0x815F440", VA = "0x188160640")]
	public static CCKBCNBPKJF DDAFMBFBLDL(Type NLLPGNLLGHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class AIIHCDADBEB<T> : HCLLCDKNBCK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3B10600", Offset = "0x3B0F400", VA = "0x183B10600", Slot = "9")]
	public override string KIDMEGDOMCG(T DGDLKJDMLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4DC0D20", Offset = "0x4DBFB20", VA = "0x184DC0D20", Slot = "10")]
	protected override bool HBBCFKILGIC(string DGDLKJDMLAD, [Out] T OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x45BBA70", Offset = "0x45BA870", VA = "0x1845BBA70")]
	public AIIHCDADBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class DCLIOLPNIED<TCollection, T> : HCLLCDKNBCK<TCollection> where TCollection : IEnumerable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly LKFMLKMIODG<T> MICJAJEFKNO;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6AE9BE0", Offset = "0x6AE89E0", VA = "0x186AE9BE0")]
	protected DCLIOLPNIED(LKFMLKMIODG<T> MICJAJEFKNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6AE98B0", Offset = "0x6AE86B0", VA = "0x186AE98B0", Slot = "9")]
	public override string KIDMEGDOMCG(TCollection DGDLKJDMLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6AE8B30", Offset = "0x6AE7930", VA = "0x186AE8B30", Slot = "10")]
	protected override bool HBBCFKILGIC(string DGDLKJDMLAD, [Out] TCollection OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract TCollection BDDDNFCOJNO(IEnumerable<T> HDPPHEBDPDN);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6AE7E40", Offset = "0x6AE6C40", VA = "0x186AE7E40", Slot = "12")]
	internal virtual IEnumerable<string> BEGJJGBODCH(string DGDLKJDMLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6AE7ED0", Offset = "0x6AE6CD0", VA = "0x186AE7ED0")]
	[CompilerGenerated]
	private string GFKKBKPLMND(T LCFJFNFOMKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class OPFKNKDHHJL<T> : DCLIOLPNIED<T[], T>
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x45F6480", Offset = "0x45F5280", VA = "0x1845F6480")]
	[Preserve]
	public OPFKNKDHHJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x45F98E0", Offset = "0x45F86E0", VA = "0x1845F98E0")]
	[Preserve]
	public OPFKNKDHHJL(LKFMLKMIODG<T> MICJAJEFKNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5683C90", Offset = "0x5682A90", VA = "0x185683C90", Slot = "11")]
	protected override T[] BDDDNFCOJNO(IEnumerable<T> HDPPHEBDPDN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class BFELKKNNKEI<T> : DCLIOLPNIED<List<T>, T>
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x45F6480", Offset = "0x45F5280", VA = "0x1845F6480")]
	[Preserve]
	public BFELKKNNKEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x45F98E0", Offset = "0x45F86E0", VA = "0x1845F98E0")]
	[Preserve]
	public BFELKKNNKEI([Optional] LKFMLKMIODG<T> MICJAJEFKNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6086FE0", Offset = "0x6085DE0", VA = "0x186086FE0", Slot = "11")]
	protected override List<T> BDDDNFCOJNO(IEnumerable<T> HDPPHEBDPDN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class MKILCBFHBMB<T> : HCLLCDKNBCK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JsonSerializerSettings? BFHFMPBJLCB;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x53C9DB0", Offset = "0x53C8BB0", VA = "0x1853C9DB0")]
	public MKILCBFHBMB(JsonSerializerSettings? NPCGOELLFFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x53C9D50", Offset = "0x53C8B50", VA = "0x1853C9D50", Slot = "9")]
	public override string KIDMEGDOMCG(T DGDLKJDMLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x53C9C80", Offset = "0x53C8A80", VA = "0x1853C9C80", Slot = "10")]
	protected override bool HBBCFKILGIC([NotNull] string DGDLKJDMLAD, [Out] T OAIIHELJHLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class FAIMILENLHN : HCLLCDKNBCK<byte>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8160FF0", Offset = "0x815FDF0", VA = "0x188160FF0", Slot = "9")]
	public override string KIDMEGDOMCG(byte DGDLKJDMLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8160F60", Offset = "0x815FD60", VA = "0x188160F60", Slot = "10")]
	protected override bool HBBCFKILGIC(string DGDLKJDMLAD, [Out] byte OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8161050", Offset = "0x815FE50", VA = "0x188161050")]
	public FAIMILENLHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class HKBPLBDICGD : HCLLCDKNBCK<short>
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8161540", Offset = "0x8160340", VA = "0x188161540", Slot = "9")]
	public override string KIDMEGDOMCG(short DGDLKJDMLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x81614A0", Offset = "0x81602A0", VA = "0x1881614A0", Slot = "10")]
	protected override bool HBBCFKILGIC(string DGDLKJDMLAD, [Out] short OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x81615A0", Offset = "0x81603A0", VA = "0x1881615A0")]
	public HKBPLBDICGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal class OBNEJGGHAAK : HCLLCDKNBCK<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8161A00", Offset = "0x8160800", VA = "0x188161A00", Slot = "9")]
	public override string KIDMEGDOMCG(ushort DGDLKJDMLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8161960", Offset = "0x8160760", VA = "0x188161960", Slot = "10")]
	protected override bool HBBCFKILGIC(string DGDLKJDMLAD, [Out] ushort OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8161A60", Offset = "0x8160860", VA = "0x188161A60")]
	public OBNEJGGHAAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class AMFFENOLHBN : HCLLCDKNBCK<int>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x81605A0", Offset = "0x815F3A0", VA = "0x1881605A0", Slot = "9")]
	public override string KIDMEGDOMCG(int DGDLKJDMLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8160510", Offset = "0x815F310", VA = "0x188160510", Slot = "10")]
	protected override bool HBBCFKILGIC(string DGDLKJDMLAD, [Out] int OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8160600", Offset = "0x815F400", VA = "0x188160600")]
	public AMFFENOLHBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class IJGPFJGKHGL : HCLLCDKNBCK<uint>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8161720", Offset = "0x8160520", VA = "0x188161720", Slot = "9")]
	public override string KIDMEGDOMCG(uint DGDLKJDMLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8161690", Offset = "0x8160490", VA = "0x188161690", Slot = "10")]
	protected override bool HBBCFKILGIC(string DGDLKJDMLAD, [Out] uint OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8161780", Offset = "0x8160580", VA = "0x188161780")]
	public IJGPFJGKHGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class OOMJHKCBEID : HCLLCDKNBCK<long>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8161B40", Offset = "0x8160940", VA = "0x188161B40", Slot = "9")]
	public override string KIDMEGDOMCG(long DGDLKJDMLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8161AA0", Offset = "0x81608A0", VA = "0x188161AA0", Slot = "10")]
	protected override bool HBBCFKILGIC(string DGDLKJDMLAD, [Out] long OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8161BA0", Offset = "0x81609A0", VA = "0x188161BA0")]
	public OOMJHKCBEID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class KNFGGPDHIKJ : HCLLCDKNBCK<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x81618C0", Offset = "0x81606C0", VA = "0x1881618C0", Slot = "9")]
	public override string KIDMEGDOMCG(ulong DGDLKJDMLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8161820", Offset = "0x8160620", VA = "0x188161820", Slot = "10")]
	protected override bool HBBCFKILGIC(string DGDLKJDMLAD, [Out] ulong OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8161920", Offset = "0x8160720", VA = "0x188161920")]
	public KNFGGPDHIKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class FAKNMGGKOKD : HCLLCDKNBCK<float>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8161120", Offset = "0x815FF20", VA = "0x188161120", Slot = "9")]
	public override string KIDMEGDOMCG(float DGDLKJDMLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8161090", Offset = "0x815FE90", VA = "0x188161090", Slot = "10")]
	protected override bool HBBCFKILGIC(string DGDLKJDMLAD, [Out] float OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8161190", Offset = "0x815FF90", VA = "0x188161190")]
	public FAKNMGGKOKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface CCKBCNBPKJF
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string PIAELEPAGKB(object DGDLKJDMLAD);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BIIAEFAHIBK([CanBeNull] string DGDLKJDMLAD, [Out] object OAIIHELJHLG);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LKFMLKMIODG<T> : CCKBCNBPKJF
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string KIDMEGDOMCG(T DGDLKJDMLAD);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KFANGKAFJMA([CanBeNull] string DGDLKJDMLAD, [Out] T OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T DONAAFEKKBA([CanBeNull] string DGDLKJDMLAD, [Optional] T LDGCNLHOBMI);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class HCLLCDKNBCK<T> : LKFMLKMIODG<T>, CCKBCNBPKJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Type KMCCHFIHELL;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4C18A00", Offset = "0x4C17800", VA = "0x184C18A00")]
	protected HCLLCDKNBCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4C179B0", Offset = "0x4C167B0", VA = "0x184C179B0")]
	private T DOFJJDBPECC(object GLEBGNJJOHG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract string KIDMEGDOMCG(T DGDLKJDMLAD);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4C18760", Offset = "0x4C17560", VA = "0x184C18760", Slot = "7")]
	public string PIAELEPAGKB(object DGDLKJDMLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4C17E90", Offset = "0x4C16C90", VA = "0x184C17E90", Slot = "5")]
	public bool KFANGKAFJMA(string DGDLKJDMLAD, [Out] T OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool HBBCFKILGIC([NotNull] string DGDLKJDMLAD, [Out] T OAIIHELJHLG);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4C18100", Offset = "0x4C16F00", VA = "0x184C18100", Slot = "8")]
	private bool NAKDHJPLNCM(string DGDLKJDMLAD, [Out] object OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4C17CF0", Offset = "0x4C16AF0", VA = "0x184C17CF0", Slot = "6")]
	public T DONAAFEKKBA(string DGDLKJDMLAD, [Optional] T LDGCNLHOBMI)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class GEEHBJJOEKG<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static LKFMLKMIODG<T> OOIHKAJEMOK
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4A34740", Offset = "0x4A33540", VA = "0x184A34740")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3A74E50", Offset = "0x3A73C50", VA = "0x183A74E50")]
	public static LKFMLKMIODG<TSerialized> CFAGCNMILDA<TSerialized>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4B8AA10", Offset = "0x4B89810", VA = "0x184B8AA10")]
	public static CCKBCNBPKJF CFAGCNMILDA(Type PIOOKGPMLNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4B8CDF0", Offset = "0x4B8BBF0", VA = "0x184B8CDF0")]
	private static CCKBCNBPKJF HENEAEEBJDL(Type DBCOPINAGKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4B8EFF0", Offset = "0x4B8DDF0", VA = "0x184B8EFF0")]
	private static CCKBCNBPKJF LKHGOECLJPE(Type DBCOPINAGKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class MODMLPIMOIB<TCollection> : DCLIOLPNIED<TCollection, string> where TCollection : IEnumerable<string>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class PBNBJEPKCHB : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
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
		public MODMLPIMOIB<TCollection> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private DHIJAGFCGAN<StringBuilder> <_>5__2;

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
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xED60C0", Offset = "0xED4EC0", VA = "0x180ED60C0")]
		[DebuggerHidden]
		public PBNBJEPKCHB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4B1BBD0", Offset = "0x4B1A9D0", VA = "0x184B1BBD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x576D8A0", Offset = "0x576C6A0", VA = "0x18576D8A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x576DD10", Offset = "0x576CB10", VA = "0x18576DD10")]
		private void PPMJPANAFBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x576DE40", Offset = "0x576CC40", VA = "0x18576DE40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x576DD60", Offset = "0x576CB60", VA = "0x18576DD60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5070D40", Offset = "0x506FB40", VA = "0x185070D40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool FEIJBCCDKMM;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x53DAF30", Offset = "0x53D9D30", VA = "0x1853DAF30")]
	protected MODMLPIMOIB(bool FEIJBCCDKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x53DACE0", Offset = "0x53D9AE0", VA = "0x1853DACE0", Slot = "9")]
	public override string KIDMEGDOMCG(TCollection DGDLKJDMLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x53DABA0", Offset = "0x53D99A0", VA = "0x1853DABA0", Slot = "12")]
	[IteratorStateMachine(typeof(MODMLPIMOIB<>.PBNBJEPKCHB))]
	internal override IEnumerable<string> BEGJJGBODCH(string DGDLKJDMLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x53DAC60", Offset = "0x53D9A60", VA = "0x1853DAC60")]
	[CompilerGenerated]
	internal static string EDGIGCPPIJJ(StringBuilder AMFPIDDBNBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class ELOOOGIEAKK : MODMLPIMOIB<List<string>>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8160F10", Offset = "0x815FD10", VA = "0x188160F10")]
	[Preserve]
	public ELOOOGIEAKK(bool FEIJBCCDKMM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8160E80", Offset = "0x815FC80", VA = "0x188160E80", Slot = "11")]
	protected override List<string> BDDDNFCOJNO(IEnumerable<string> HDPPHEBDPDN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IEOKBMFFOKF : MODMLPIMOIB<string[]>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8161640", Offset = "0x8160440", VA = "0x188161640")]
	[Preserve]
	public IEOKBMFFOKF(bool FEIJBCCDKMM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x81615E0", Offset = "0x81603E0", VA = "0x1881615E0", Slot = "11")]
	protected override string[] BDDDNFCOJNO(IEnumerable<string> HDPPHEBDPDN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class KHIPLGKPOFB : HCLLCDKNBCK<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xABF9B0", Offset = "0xABE7B0", VA = "0x180ABF9B0", Slot = "9")]
	public override string KIDMEGDOMCG(string DGDLKJDMLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x81617C0", Offset = "0x81605C0", VA = "0x1881617C0", Slot = "10")]
	protected override bool HBBCFKILGIC(string DGDLKJDMLAD, [Out] string OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x81617E0", Offset = "0x81605E0", VA = "0x1881617E0")]
	public KHIPLGKPOFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class HDGAMOPJHOI : HCLLCDKNBCK<TimeSpan>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8161340", Offset = "0x8160140", VA = "0x188161340", Slot = "9")]
	public override string KIDMEGDOMCG(TimeSpan DGDLKJDMLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x81611D0", Offset = "0x815FFD0", VA = "0x1881611D0", Slot = "10")]
	protected override bool HBBCFKILGIC(string DGDLKJDMLAD, [Out] TimeSpan OAIIHELJHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8161460", Offset = "0x8160260", VA = "0x188161460")]
	public HDGAMOPJHOI()
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
