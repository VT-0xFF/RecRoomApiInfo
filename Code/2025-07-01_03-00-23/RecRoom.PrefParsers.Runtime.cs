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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0xA705D0", Offset = "0xA6EBD0", VA = "0x180A705D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA70610", Offset = "0xA6EC10", VA = "0x180A70610")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MAKPFAOGOHF : ODILPPNGKKC<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8382CA0", Offset = "0x83812A0", VA = "0x188382CA0", Slot = "9")]
	public override string LGGJGPOGIBH(bool FCHACHIDAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8382C40", Offset = "0x8381240", VA = "0x188382C40", Slot = "10")]
	protected override bool JHKPHHHKKLH(string FCHACHIDAGA, [Out] bool KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8382CF0", Offset = "0x83812F0", VA = "0x188382CF0")]
	public MAKPFAOGOHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class CEKJGEKFGEC : ODILPPNGKKC<DateTime>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8382410", Offset = "0x8380A10", VA = "0x188382410", Slot = "9")]
	public override string LGGJGPOGIBH(DateTime FCHACHIDAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8382370", Offset = "0x8380970", VA = "0x188382370", Slot = "10")]
	protected override bool JHKPHHHKKLH(string FCHACHIDAGA, [Out] DateTime KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x83824A0", Offset = "0x8380AA0", VA = "0x1883824A0")]
	public CEKJGEKFGEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class ECBHEBFMKKH<TEnum> : ODILPPNGKKC<TEnum> where TEnum : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly Type PFLBLPBNFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool JMCFNEIKCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly TEnum[] NIJLHKNCLKB;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4759620", Offset = "0x4757C20", VA = "0x184759620")]
	[Preserve]
	public ECBHEBFMKKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4759330", Offset = "0x4757930", VA = "0x184759330", Slot = "9")]
	public override string LGGJGPOGIBH(TEnum FCHACHIDAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4759250", Offset = "0x4757850", VA = "0x184759250", Slot = "10")]
	protected override bool JHKPHHHKKLH(string FCHACHIDAGA, [Out] TEnum KKGBKLFKCPO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class OKEOOEMMNKF<TEnum> : ODILPPNGKKC<TEnum> where TEnum : Enum
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Type PFLBLPBNFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly DEDADICAFME CODGIOOAGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly bool JMCFNEIKCAB;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x57D9250", Offset = "0x57D7850", VA = "0x1857D9250")]
	[Preserve]
	public OKEOOEMMNKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x57D90B0", Offset = "0x57D76B0", VA = "0x1857D90B0", Slot = "9")]
	public override string LGGJGPOGIBH(TEnum FCHACHIDAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x57D8E50", Offset = "0x57D7450", VA = "0x1857D8E50", Slot = "10")]
	protected override bool JHKPHHHKKLH(string FCHACHIDAGA, [Out] TEnum KKGBKLFKCPO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class PLGAHJDMEPA
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly Dictionary<Type, DEDADICAFME> PDCGJEIHFED;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8383190", Offset = "0x8381790", VA = "0x188383190")]
	public static DEDADICAFME CMMDONOOBPE(Type JJCJNCNKLEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class IHFAGCMLCFD<T> : ODILPPNGKKC<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x39CDBE0", Offset = "0x39CC1E0", VA = "0x1839CDBE0", Slot = "9")]
	public override string LGGJGPOGIBH(T FCHACHIDAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4F652C0", Offset = "0x4F638C0", VA = "0x184F652C0", Slot = "10")]
	protected override bool JHKPHHHKKLH(string FCHACHIDAGA, [Out] T KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x474B6E0", Offset = "0x4749CE0", VA = "0x18474B6E0")]
	public IHFAGCMLCFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class PGEEACIGFBD<TCollection, T> : ODILPPNGKKC<TCollection> where TCollection : IEnumerable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly DAKEOIAHFIL<T> AGBINALFAAH;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x58D8F40", Offset = "0x58D7540", VA = "0x1858D8F40")]
	protected PGEEACIGFBD(DAKEOIAHFIL<T> AGBINALFAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x58D8680", Offset = "0x58D6C80", VA = "0x1858D8680", Slot = "9")]
	public override string LGGJGPOGIBH(TCollection FCHACHIDAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x58D5AF0", Offset = "0x58D40F0", VA = "0x1858D5AF0", Slot = "10")]
	protected override bool JHKPHHHKKLH(string FCHACHIDAGA, [Out] TCollection KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract TCollection DHGGBKLEDHK(IEnumerable<T> LBGECFLOADF);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x58D83B0", Offset = "0x58D69B0", VA = "0x1858D83B0", Slot = "12")]
	internal virtual IEnumerable<string> KIMCGLPDFIM(string FCHACHIDAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x58D53A0", Offset = "0x58D39A0", VA = "0x1858D53A0")]
	[CompilerGenerated]
	private string JAGLFGABGCN(T JIJNMCDLDDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class BFIMNBKDFML<T> : PGEEACIGFBD<T[], T>
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4E1CC60", Offset = "0x4E1B260", VA = "0x184E1CC60")]
	[Preserve]
	public BFIMNBKDFML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x479A440", Offset = "0x4798A40", VA = "0x18479A440")]
	[Preserve]
	public BFIMNBKDFML(DAKEOIAHFIL<T> AGBINALFAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6151C00", Offset = "0x6150200", VA = "0x186151C00", Slot = "11")]
	protected override T[] DHGGBKLEDHK(IEnumerable<T> LBGECFLOADF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class KFEGNHDJBHI<T> : PGEEACIGFBD<List<T>, T>
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4E1CC60", Offset = "0x4E1B260", VA = "0x184E1CC60")]
	[Preserve]
	public KFEGNHDJBHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x479A440", Offset = "0x4798A40", VA = "0x18479A440")]
	[Preserve]
	public KFEGNHDJBHI([Optional] DAKEOIAHFIL<T> AGBINALFAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x529AA40", Offset = "0x5299040", VA = "0x18529AA40", Slot = "11")]
	protected override List<T> DHGGBKLEDHK(IEnumerable<T> LBGECFLOADF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class BHFEONBBMPF<T> : ODILPPNGKKC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JsonSerializerSettings? INNCHOFGNAN;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x566D020", Offset = "0x566B620", VA = "0x18566D020")]
	public BHFEONBBMPF(JsonSerializerSettings? GIHMBAJJMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x615E000", Offset = "0x615C600", VA = "0x18615E000", Slot = "9")]
	public override string LGGJGPOGIBH(T FCHACHIDAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x615DF40", Offset = "0x615C540", VA = "0x18615DF40", Slot = "10")]
	protected override bool JHKPHHHKKLH([NotNull] string FCHACHIDAGA, [Out] T KKGBKLFKCPO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class FPMKICBJKIP : ODILPPNGKKC<byte>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8382570", Offset = "0x8380B70", VA = "0x188382570", Slot = "9")]
	public override string LGGJGPOGIBH(byte FCHACHIDAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x83824E0", Offset = "0x8380AE0", VA = "0x1883824E0", Slot = "10")]
	protected override bool JHKPHHHKKLH(string FCHACHIDAGA, [Out] byte KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x83825D0", Offset = "0x8380BD0", VA = "0x1883825D0")]
	public FPMKICBJKIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class PDEIGKLHMCE : ODILPPNGKKC<short>
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x83830F0", Offset = "0x83816F0", VA = "0x1883830F0", Slot = "9")]
	public override string LGGJGPOGIBH(short FCHACHIDAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8383050", Offset = "0x8381650", VA = "0x188383050", Slot = "10")]
	protected override bool JHKPHHHKKLH(string FCHACHIDAGA, [Out] short KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8383150", Offset = "0x8381750", VA = "0x188383150")]
	public PDEIGKLHMCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal class NDDBOMECCMF : ODILPPNGKKC<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8382E80", Offset = "0x8381480", VA = "0x188382E80", Slot = "9")]
	public override string LGGJGPOGIBH(ushort FCHACHIDAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8382DE0", Offset = "0x83813E0", VA = "0x188382DE0", Slot = "10")]
	protected override bool JHKPHHHKKLH(string FCHACHIDAGA, [Out] ushort KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8382EE0", Offset = "0x83814E0", VA = "0x188382EE0")]
	public NDDBOMECCMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class OIHBKMCDPHF : ODILPPNGKKC<int>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8382FB0", Offset = "0x83815B0", VA = "0x188382FB0", Slot = "9")]
	public override string LGGJGPOGIBH(int FCHACHIDAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8382F20", Offset = "0x8381520", VA = "0x188382F20", Slot = "10")]
	protected override bool JHKPHHHKKLH(string FCHACHIDAGA, [Out] int KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8383010", Offset = "0x8381610", VA = "0x188383010")]
	public OIHBKMCDPHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class BNMNLADJNDL : ODILPPNGKKC<uint>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8382270", Offset = "0x8380870", VA = "0x188382270", Slot = "9")]
	public override string LGGJGPOGIBH(uint FCHACHIDAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x83821E0", Offset = "0x83807E0", VA = "0x1883821E0", Slot = "10")]
	protected override bool JHKPHHHKKLH(string FCHACHIDAGA, [Out] uint KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x83822D0", Offset = "0x83808D0", VA = "0x1883822D0")]
	public BNMNLADJNDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class ACLCFJLMBPG : ODILPPNGKKC<long>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8382140", Offset = "0x8380740", VA = "0x188382140", Slot = "9")]
	public override string LGGJGPOGIBH(long FCHACHIDAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x83820A0", Offset = "0x83806A0", VA = "0x1883820A0", Slot = "10")]
	protected override bool JHKPHHHKKLH(string FCHACHIDAGA, [Out] long KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x83821A0", Offset = "0x83807A0", VA = "0x1883821A0")]
	public ACLCFJLMBPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class JEGNIMPPBAC : ODILPPNGKKC<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x83828D0", Offset = "0x8380ED0", VA = "0x1883828D0", Slot = "9")]
	public override string LGGJGPOGIBH(ulong FCHACHIDAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8382830", Offset = "0x8380E30", VA = "0x188382830", Slot = "10")]
	protected override bool JHKPHHHKKLH(string FCHACHIDAGA, [Out] ulong KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8382930", Offset = "0x8380F30", VA = "0x188382930")]
	public JEGNIMPPBAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class HMLMMJJDNPD : ODILPPNGKKC<float>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8382780", Offset = "0x8380D80", VA = "0x188382780", Slot = "9")]
	public override string LGGJGPOGIBH(float FCHACHIDAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x83826F0", Offset = "0x8380CF0", VA = "0x1883826F0", Slot = "10")]
	protected override bool JHKPHHHKKLH(string FCHACHIDAGA, [Out] float KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x83827F0", Offset = "0x8380DF0", VA = "0x1883827F0")]
	public HMLMMJJDNPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface DEDADICAFME
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string FAGPKPCPHFF(object FCHACHIDAGA);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NEJNHDMMGIP([CanBeNull] string FCHACHIDAGA, [Out] object KKGBKLFKCPO);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DAKEOIAHFIL<T> : DEDADICAFME
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string LGGJGPOGIBH(T FCHACHIDAGA);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BCPBDAOBLPL([CanBeNull] string FCHACHIDAGA, [Out] T KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T BACPDMDCCKJ([CanBeNull] string FCHACHIDAGA, [Optional] T COMAGLLDBOM);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class ODILPPNGKKC<T> : DAKEOIAHFIL<T>, DEDADICAFME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Type DEGJKLFNAHD;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x57B0BA0", Offset = "0x57AF1A0", VA = "0x1857B0BA0")]
	protected ODILPPNGKKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x57AFF10", Offset = "0x57AE510", VA = "0x1857AFF10")]
	private T BJAIHKCABAO(object ODCICEDDLMB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract string LGGJGPOGIBH(T FCHACHIDAGA);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x57B0380", Offset = "0x57AE980", VA = "0x1857B0380", Slot = "7")]
	public string FAGPKPCPHFF(object FCHACHIDAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x57AFD50", Offset = "0x57AE350", VA = "0x1857AFD50", Slot = "5")]
	public bool BCPBDAOBLPL(string FCHACHIDAGA, [Out] T KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool JHKPHHHKKLH([NotNull] string FCHACHIDAGA, [Out] T KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x57B0610", Offset = "0x57AEC10", VA = "0x1857B0610", Slot = "8")]
	private bool GOFNMMCEGPA(string FCHACHIDAGA, [Out] object KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x57AFAC0", Offset = "0x57AE0C0", VA = "0x1857AFAC0", Slot = "6")]
	public T BACPDMDCCKJ(string FCHACHIDAGA, [Optional] T COMAGLLDBOM)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class PGABDCKHFHL<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static DAKEOIAHFIL<T> JLODNOEBAIE
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4BDB170", Offset = "0x4BD9770", VA = "0x184BDB170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x42B4270", Offset = "0x42B2870", VA = "0x1842B4270")]
	public static DAKEOIAHFIL<TSerialized> MIFHELPIJAP<TSerialized>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x58C1F10", Offset = "0x58C0510", VA = "0x1858C1F10")]
	public static DEDADICAFME MIFHELPIJAP(Type FMJFPNIIHLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x58C8E10", Offset = "0x58C7410", VA = "0x1858C8E10")]
	private static DEDADICAFME NMGICGFHAOA(Type BEGAKDHOPNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x58BA490", Offset = "0x58B8A90", VA = "0x1858BA490")]
	private static DEDADICAFME CCOBFHGMKCE(Type BEGAKDHOPNB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class KPDILFAOLIH<TCollection> : PGEEACIGFBD<TCollection, string> where TCollection : IEnumerable<string>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class JLCINCNIOFE : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
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
		public KPDILFAOLIH<TCollection> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private NHNOBABIOMF<StringBuilder> <_>5__2;

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
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xF4E730", Offset = "0xF4CD30", VA = "0x180F4E730")]
		[DebuggerHidden]
		public JLCINCNIOFE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4CDD9C0", Offset = "0x4CDBFC0", VA = "0x184CDD9C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x51DA690", Offset = "0x51D8C90", VA = "0x1851DA690", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x51DA640", Offset = "0x51D8C40", VA = "0x1851DA640")]
		private void APENNGMAANK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x51DABF0", Offset = "0x51D91F0", VA = "0x1851DABF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x51DAAF0", Offset = "0x51D90F0", VA = "0x1851DAAF0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x51DABC0", Offset = "0x51D91C0", VA = "0x1851DABC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool ALHHPEINDLN;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x52E92F0", Offset = "0x52E78F0", VA = "0x1852E92F0")]
	protected KPDILFAOLIH(bool ALHHPEINDLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x52E9010", Offset = "0x52E7610", VA = "0x1852E9010", Slot = "9")]
	public override string LGGJGPOGIBH(TCollection FCHACHIDAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x52E8F60", Offset = "0x52E7560", VA = "0x1852E8F60", Slot = "12")]
	[IteratorStateMachine(typeof(KPDILFAOLIH<>.JLCINCNIOFE))]
	internal override IEnumerable<string> KIMCGLPDFIM(string FCHACHIDAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x52E9270", Offset = "0x52E7870", VA = "0x1852E9270")]
	[CompilerGenerated]
	internal static string NFOACHBKLAB(StringBuilder HNHFGEPMHEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class HJNPCHBCNNH : KPDILFAOLIH<List<string>>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x83826A0", Offset = "0x8380CA0", VA = "0x1883826A0")]
	[Preserve]
	public HJNPCHBCNNH(bool ALHHPEINDLN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8382610", Offset = "0x8380C10", VA = "0x188382610", Slot = "11")]
	protected override List<string> DHGGBKLEDHK(IEnumerable<string> LBGECFLOADF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class NAPBGNOIPHN : KPDILFAOLIH<string[]>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8382D90", Offset = "0x8381390", VA = "0x188382D90")]
	[Preserve]
	public NAPBGNOIPHN(bool ALHHPEINDLN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8382D30", Offset = "0x8381330", VA = "0x188382D30", Slot = "11")]
	protected override string[] DHGGBKLEDHK(IEnumerable<string> LBGECFLOADF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class CAMOMPACBCL : ODILPPNGKKC<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xAC6580", Offset = "0xAC4B80", VA = "0x180AC6580", Slot = "9")]
	public override string LGGJGPOGIBH(string FCHACHIDAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8382310", Offset = "0x8380910", VA = "0x188382310", Slot = "10")]
	protected override bool JHKPHHHKKLH(string FCHACHIDAGA, [Out] string KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8382330", Offset = "0x8380930", VA = "0x188382330")]
	public CAMOMPACBCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JMNHOCCOIJI : ODILPPNGKKC<TimeSpan>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8382AE0", Offset = "0x83810E0", VA = "0x188382AE0", Slot = "9")]
	public override string LGGJGPOGIBH(TimeSpan FCHACHIDAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8382970", Offset = "0x8380F70", VA = "0x188382970", Slot = "10")]
	protected override bool JHKPHHHKKLH(string FCHACHIDAGA, [Out] TimeSpan KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8382C00", Offset = "0x8381200", VA = "0x188382C00")]
	public JMNHOCCOIJI()
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
