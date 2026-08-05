using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Properties;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class EntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x60EDF50", Offset = "0x60ED350", VA = "0x1860EDF50")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class KFJJOCFDNMB<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] HOLGDBICBJC;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2532370", Offset = "0x2531770", VA = "0x182532370")]
	public static void GGFPDDKNDHM<TField>(int FGBBDGJMFEH, string ADLKEGECLOG, LHNANKOGOHB LCPLMJMGOII, [Out] NCAKJABDPBE<TField> JAOOJJKNLDO) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2533520", Offset = "0x2532920", VA = "0x182533520")]
	public static void MJDMFHMMLMC<TField>(int FGBBDGJMFEH, string ADLKEGECLOG, [Out] LAJKGOLNJIJ<TField> MAMIOIALJGO) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class NLLDCNABBMC
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x60EEB50", Offset = "0x60EDF50", VA = "0x1860EEB50")]
	public static FieldInfo[] FJPIEKHFMHP(Type KHENBEDBKDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class PGEHBEMCACF<View, Data> : EKIILBDMHIE where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType INCABJKCMBP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type HBBAGFEHELD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x404F530", Offset = "0x404E930", VA = "0x18404F530", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override int FKFHMMIBHAE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x404E310", Offset = "0x404D710", VA = "0x18404E310", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x404F830", Offset = "0x404EC30", VA = "0x18404F830")]
	public Data JLAIHEJGEMD(Entity HJECHGCECJI)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View MAFNLOEGPIP(Entity HJECHGCECJI);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x253F680", Offset = "0x253EA80", VA = "0x18253F680", Slot = "14")]
	public override T MAFNLOEGPIP<T>(Entity HJECHGCECJI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
	protected PGEHBEMCACF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class EKIILBDMHIE : LHNANKOGOHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle BJGOOOMCPJO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EntityManager MFEBCDLDBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1284A60", Offset = "0x1283E60", VA = "0x181284A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract Type HBBAGFEHELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int FKFHMMIBHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Type HHCPGENPPME
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9982D0", Offset = "0x9976D0", VA = "0x1809982D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int NNHPNOOIKLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x60EDC50", Offset = "0x60ED050", VA = "0x1860EDC50", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private BIPAFKAMHFJ[] KDIAHGMCAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1F80920", Offset = "0x1F7FD20", VA = "0x181F80920", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected internal virtual BIPAFKAMHFJ[] NACNNKBJPLO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x60ED990", Offset = "0x60ECD90", VA = "0x1860ED990", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x60EDA20", Offset = "0x60ECE20", VA = "0x1860EDA20")]
	public void FILODNFGCKM(EntityManager NJALJNGMKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract T MAFNLOEGPIP<T>(Entity HJECHGCECJI) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x60ED8A0", Offset = "0x60ECCA0", VA = "0x1860ED8A0", Slot = "8")]
	public (uint, uint) EMMBDHJKCGF(Entity HJECHGCECJI)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x60EDB60", Offset = "0x60ECF60", VA = "0x1860EDB60", Slot = "9")]
	public bool GADPGNDCJOM(Entity HJECHGCECJI, (uint order, uint change) IEOKPDEFBIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	protected EKIILBDMHIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface POAEJCOEGFC
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NDBCLHEPJHC : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	PKIIINKKDDE ADFHOLCJAEP
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PGBHCOOJFPM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FHBLBILKCJG(Entity HJECHGCECJI, object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BLCJJACICNF(Entity HJECHGCECJI, object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FIKLBLKEBCH(Entity HJECHGCECJI);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FKIHEIPGEFD(Entity HJECHGCECJI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class OEBDEIEKGDH<TComponentData, TValue> : NFFOJPBOIFK<TValue>, IDisposable where TComponentData : struct, NDBCLHEPJHC
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class JKPKBMNAKLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private List<(object token, TValue value)> EPAFMCCJAFF;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int IGPGGFCOPJC
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x3073330", Offset = "0x3072730", VA = "0x183073330")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8DB0", Offset = "0x3AD81B0", VA = "0x183AD8DB0")]
		public bool AEHNCLMANKI([Out] TValue PAHKKNONPEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8EA0", Offset = "0x3AD82A0", VA = "0x183AD8EA0")]
		public void DEAIBIAHPPK(object KNOHBODGPLL, TValue PAHKKNONPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3AD9030", Offset = "0x3AD8430", VA = "0x183AD9030")]
		public bool FKMFNEFKHJM(object KNOHBODGPLL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3AD8F50", Offset = "0x3AD8350", VA = "0x183AD8F50")]
		public int FDNMABIKJKM(object KNOHBODGPLL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3AD90B0", Offset = "0x3AD84B0", VA = "0x183AD90B0")]
		public JKPKBMNAKLC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Stack<JKPKBMNAKLC> IGJACEJBHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private MAIMDDEKDFN<PKIIINKKDDE, JKPKBMNAKLC> KKPPKEFELEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EntityManager NJALJNGMKOL;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3F8BD20", Offset = "0x3F8B120", VA = "0x183F8BD20")]
	public OEBDEIEKGDH(EntityManager NJALJNGMKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3F8BA10", Offset = "0x3F8AE10", VA = "0x183F8BA10", Slot = "4")]
	public void FHBLBILKCJG(Entity HJECHGCECJI, object KNOHBODGPLL, TValue PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3F8B850", Offset = "0x3F8AC50", VA = "0x183F8B850", Slot = "5")]
	public bool BLCJJACICNF(Entity HJECHGCECJI, object KNOHBODGPLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3F8B5D0", Offset = "0x3F8A9D0", VA = "0x183F8B5D0", Slot = "6")]
	public bool AEHNCLMANKI(Entity HJECHGCECJI, [Out] TValue PAHKKNONPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3F8B9F0", Offset = "0x3F8ADF0", VA = "0x183F8B9F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3F8B6D0", Offset = "0x3F8AAD0", VA = "0x183F8B6D0")]
	private void AJJBBBMPAFF(JKPKBMNAKLC PKHBDDNGJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3F8BC60", Offset = "0x3F8B060", VA = "0x183F8BC60")]
	private bool NGOFPCNGKCN(Entity HJECHGCECJI, [Out] PKIIINKKDDE AEBAPBHOHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3F8B760", Offset = "0x3F8AB60", VA = "0x183F8B760")]
	private void BJPDGGNGNCC(Entity HJECHGCECJI, PKIIINKKDDE AEBAPBHOHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3F8BB50", Offset = "0x3F8AF50", VA = "0x183F8BB50")]
	private bool IFEHEDMFAJJ(PKIIINKKDDE AEBAPBHOHLJ, [Out] JKPKBMNAKLC PKHBDDNGJKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3F8BB70", Offset = "0x3F8AF70", VA = "0x183F8BB70")]
	private JKPKBMNAKLC JFFAGPHBPNF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NFFOJPBOIFK<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FHBLBILKCJG(Entity HJECHGCECJI, object KNOHBODGPLL, TValue PAHKKNONPEO);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BLCJJACICNF(Entity HJECHGCECJI, object KNOHBODGPLL);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AEHNCLMANKI(Entity HJECHGCECJI, [Out] TValue PAHKKNONPEO);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct PKIIINKKDDE : BJIOFLLCOHO, IEquatable<PKIIINKKDDE>
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly PKIIINKKDDE INDMNNFEIGN;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[CreateProperty]
	public int GOBEDCIKOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x890610", Offset = "0x88FA10", VA = "0x180890610", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x890600", Offset = "0x88FA00", VA = "0x180890600", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[CreateProperty]
	public int FNFGJIKMFLK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2167AC0", Offset = "0x2166EC0", VA = "0x182167AC0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x549B270", Offset = "0x549A670", VA = "0x18549B270", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x60EEF50", Offset = "0x60EE350", VA = "0x1860EEF50", Slot = "8")]
	public bool Equals(PKIIINKKDDE JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x60EEFA0", Offset = "0x60EE3A0", VA = "0x1860EEFA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KECLOAJNMOH<THasTokensTag> : PGBHCOOJFPM, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly KBKFCGENGMC ADLBEINOKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<Entity, PKIIINKKDDE> CPHHAKJJJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly Stack<HashSet<object>> IGJACEJBHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private MAIMDDEKDFN<PKIIINKKDDE, HashSet<object>> KKPPKEFELEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private EntityManager NJALJNGMKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private EntityCommandBufferSystem ODAKOBGADED;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3B31EB0", Offset = "0x3B312B0", VA = "0x183B31EB0")]
	public KECLOAJNMOH(EntityManager NJALJNGMKOL, EntityCommandBufferSystem ODAKOBGADED, KBKFCGENGMC BNEEBMOGDGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3B30D30", Offset = "0x3B30130", VA = "0x183B30D30", Slot = "4")]
	public bool FHBLBILKCJG(Entity HJECHGCECJI, object KNOHBODGPLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3B30590", Offset = "0x3B2F990", VA = "0x183B30590", Slot = "5")]
	public bool BLCJJACICNF(Entity HJECHGCECJI, object KNOHBODGPLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3B310C0", Offset = "0x3B304C0", VA = "0x183B310C0", Slot = "6")]
	public bool FIKLBLKEBCH(Entity HJECHGCECJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3B31150", Offset = "0x3B30550", VA = "0x183B31150", Slot = "9")]
	public bool FIKLBLKEBCH(PKIIINKKDDE AEBAPBHOHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3B313B0", Offset = "0x3B307B0", VA = "0x183B313B0", Slot = "7")]
	public bool FKIHEIPGEFD(Entity HJECHGCECJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3B30B00", Offset = "0x3B2FF00", VA = "0x183B30B00", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3B30190", Offset = "0x3B2F590", VA = "0x183B30190")]
	private void AJJBBBMPAFF(HashSet<object> PKHBDDNGJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3B31DE0", Offset = "0x3B311E0", VA = "0x183B31DE0")]
	private bool NGOFPCNGKCN(Entity HJECHGCECJI, [Out] PKIIINKKDDE AEBAPBHOHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3B30380", Offset = "0x3B2F780", VA = "0x183B30380")]
	private bool BIHOMNGHHEE(Entity HJECHGCECJI, [Out] PKIIINKKDDE AEBAPBHOHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3B2FFA0", Offset = "0x3B2F3A0", VA = "0x183B2FFA0")]
	private void AJGKLJJOLAE(Entity HJECHGCECJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3B31910", Offset = "0x3B30D10", VA = "0x183B31910")]
	private void KFILCDKGJPK(Entity HJECHGCECJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3B316B0", Offset = "0x3B30AB0", VA = "0x183B316B0")]
	private void HKDMKDPELPH(Entity HJECHGCECJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3B30440", Offset = "0x3B2F840", VA = "0x183B30440")]
	private void BJPDGGNGNCC(Entity HJECHGCECJI, PKIIINKKDDE AEBAPBHOHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3B309E0", Offset = "0x3B2FDE0", VA = "0x183B309E0")]
	private bool DIGNMKHHPJA(PKIIINKKDDE AEBAPBHOHLJ, [Out] HashSet<object> PKHBDDNGJKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3B31730", Offset = "0x3B30B30", VA = "0x183B31730")]
	private HashSet<object> JFFAGPHBPNF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class PHHHOOPIFLK
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct JGAAELKHOPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int EIJFICIEABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int GNHCGOJHAJG;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int KOGNFLAHADF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x890610", Offset = "0x88FA10", VA = "0x180890610")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int IGPGGFCOPJC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x2167AC0", Offset = "0x2166EC0", VA = "0x182167AC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x549B270", Offset = "0x549A670", VA = "0x18549B270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int NDFIIJPHGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x890610", Offset = "0x88FA10", VA = "0x180890610")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x890600", Offset = "0x88FA00", VA = "0x180890600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int BKNLDEHFEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x60EE4D0", Offset = "0x60ED8D0", VA = "0x1860EE4D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x60EE4B0", Offset = "0x60ED8B0", VA = "0x1860EE4B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xA31A30", Offset = "0xA30E30", VA = "0x180A31A30")]
	private JGAAELKHOPM(int EIJFICIEABK, int GNHCGOJHAJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1D2F310", Offset = "0x1D2E710", VA = "0x181D2F310")]
	public static JGAAELKHOPM PAKAPIBIDIH(int EIJFICIEABK, int GNHCGOJHAJG)
	{
		return default(JGAAELKHOPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x60EE4C0", Offset = "0x60ED8C0", VA = "0x1860EE4C0")]
	public static JGAAELKHOPM DJDAMDLPFAE(int ANFKDBDICOO, int JICHEHMFLAF)
	{
		return default(JGAAELKHOPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x60EE4E0", Offset = "0x60ED8E0", VA = "0x1860EE4E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct LCJPHFNPNJB : OLBIJDCKEPB<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x60D56C0", Offset = "0x60D4AC0", VA = "0x1860D56C0")]
	public float FFILKOANIAP([In] float3 PAHKKNONPEO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x60D56C0", Offset = "0x60D4AC0", VA = "0x1860D56C0", Slot = "4")]
	private float CJNFCMKDCNH([In] float3 PAHKKNONPEO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct FFAAIEIBEGA : OLBIJDCKEPB<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x60D6310", Offset = "0x60D5710", VA = "0x1860D6310")]
	public float FFILKOANIAP([In] float3 PAHKKNONPEO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x60D6310", Offset = "0x60D5710", VA = "0x1860D6310", Slot = "4")]
	private float CJNFCMKDCNH([In] float3 PAHKKNONPEO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct MCMDNLCKOOO : OLBIJDCKEPB<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x19DD2C0", Offset = "0x19DC6C0", VA = "0x1819DD2C0")]
	public float FFILKOANIAP([In] float3 PAHKKNONPEO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x19DD2C0", Offset = "0x19DC6C0", VA = "0x1819DD2C0", Slot = "4")]
	private float CJNFCMKDCNH([In] float3 PAHKKNONPEO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct BICMNGKDEJG : OLBIJDCKEPB<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x131AA70", Offset = "0x1319E70", VA = "0x18131AA70")]
	public int FFILKOANIAP([In] int3 PAHKKNONPEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x131AA70", Offset = "0x1319E70", VA = "0x18131AA70", Slot = "4")]
	private int LDDPEDGKDIE([In] int3 PAHKKNONPEO)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct NAFLHBADLJC : OLBIJDCKEPB<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x60D5230", Offset = "0x60D4630", VA = "0x1860D5230")]
	public int FFILKOANIAP([In] int3 PAHKKNONPEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x60D5230", Offset = "0x60D4630", VA = "0x1860D5230", Slot = "4")]
	private int LDDPEDGKDIE([In] int3 PAHKKNONPEO)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct CGLCCCNNGDN : OLBIJDCKEPB<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x15E3E40", Offset = "0x15E3240", VA = "0x1815E3E40")]
	public int FFILKOANIAP([In] int3 PAHKKNONPEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x15E3E40", Offset = "0x15E3240", VA = "0x1815E3E40", Slot = "4")]
	private int LDDPEDGKDIE([In] int3 PAHKKNONPEO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class BNJMBECEKPH : CAIDALFNJKH
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Type DEJOIOCFJBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Type FMEPIBGOFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x60ED480", Offset = "0x60EC880", VA = "0x1860ED480")]
	public BNJMBECEKPH(Type MHHOPBNHDKI, Type KGBMMIDDELP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class NDPNLAOCIOM : CAIDALFNJKH
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Type FMEPIBGOFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5FFA220", Offset = "0x5FF9620", VA = "0x185FFA220")]
	public NDPNLAOCIOM(Type KGBMMIDDELP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BHMPOFNJJOJ : CAIDALFNJKH
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7A0100", Offset = "0x79F500", VA = "0x1807A0100")]
	public BHMPOFNJJOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class PIECHACDJKI<Data> : BIHEBKPBNLD where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public virtual Data DBFALPAOJDK
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x791450", Offset = "0x790850", VA = "0x180791450", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4057B00", Offset = "0x4056F00", VA = "0x184057B00", Slot = "8")]
	protected virtual bool DGOINLPNAEA(ReadOnlySpan<Data> KHBDFCDIBGP, BMKKLJMHPDP KHMDCJPKJFA, [Out] ReadOnlySpan<byte> PKBBOCAODJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "9")]
	protected virtual bool AJJFPHDPJNK(int IEOKPDEFBIP, Span<Data> KHBDFCDIBGP, [In] ReadOnlySpan<byte> PKBBOCAODJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4057A40", Offset = "0x4056E40", VA = "0x184057A40", Slot = "5")]
	internal sealed override bool DGOINLPNAEA(Unity.Entities.Chunk FCIKAFGOFEA, int KMLGMMBHJMA, BMKKLJMHPDP KHMDCJPKJFA, [Out] ReadOnlySpan<byte> PKBBOCAODJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4056A20", Offset = "0x4055E20", VA = "0x184056A20", Slot = "6")]
	internal sealed override bool AJJFPHDPJNK(int IEOKPDEFBIP, Unity.Entities.Chunk FCIKAFGOFEA, int KMLGMMBHJMA, [In] ReadOnlySpan<byte> PKBBOCAODJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x253FA30", Offset = "0x253EE30", VA = "0x18253FA30")]
	protected IGIGJBIONGN<Protobuf> NFFANFCMAFB<Protobuf>(ReadOnlySpan<Data> KHBDFCDIBGP) where Protobuf : IMessage, new()
	{
		return default(IGIGJBIONGN<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x253F9B0", Offset = "0x253EDB0", VA = "0x18253F9B0")]
	protected IEHGFDJILIC<Protobuf> JGCMLEBJILM<Protobuf>(ReadOnlySpan<byte> PKBBOCAODJK, ReadOnlySpan<Data> KHBDFCDIBGP, Action<Protobuf> OMBIJKPGGNP) where Protobuf : IMessage, new()
	{
		return default(IEHGFDJILIC<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
	protected PIECHACDJKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class BIHEBKPBNLD
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected abstract int FNFGJIKMFLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x60ED370", Offset = "0x60EC770", VA = "0x1860ED370", Slot = "5")]
	internal virtual bool DGOINLPNAEA(Unity.Entities.Chunk FCIKAFGOFEA, int KMLGMMBHJMA, BMKKLJMHPDP KHMDCJPKJFA, [Out] ReadOnlySpan<byte> PKBBOCAODJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "6")]
	internal virtual bool AJJFPHDPJNK(int IEOKPDEFBIP, Unity.Entities.Chunk FCIKAFGOFEA, int KMLGMMBHJMA, [In] ReadOnlySpan<byte> PKBBOCAODJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	protected BIHEBKPBNLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface KJGFDBLPJBK
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class DCICKNDNPAD : SystemBase, KJGFDBLPJBK
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x60ED6C0", Offset = "0x60ECAC0", VA = "0x1860ED6C0")]
	public ComponentDataFromEntity CIJAKAEDDOE(int JDDFBAGKFLF, bool JHGABILHHDP = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x60ED780", Offset = "0x60ECB80", VA = "0x1860ED780")]
	public EntityExistenceLookupByEntity KLNLGFJONJO()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x60ED7A0", Offset = "0x60ECBA0", VA = "0x1860ED7A0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7A0100", Offset = "0x79F500", VA = "0x1807A0100")]
	protected DCICKNDNPAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public abstract class NGLKBNLIHCJ : DCICKNDNPAD
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x60EEB20", Offset = "0x60EDF20", VA = "0x1860EEB20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7A0100", Offset = "0x79F500", VA = "0x1807A0100")]
	protected NGLKBNLIHCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class NDDDPCMJKNJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public abstract class JADFAFKHNMI : LLMPKAOBELO
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x60EE460", Offset = "0x60ED860", VA = "0x1860EE460", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase HLHNJHAKMOH();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x60EE410", Offset = "0x60ED810", VA = "0x1860EE410")]
	protected ComponentSystemBase INNEALAFDNE(params ComponentSystemBase[] ACFNMPOFKDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x265EE70", Offset = "0x265E270", VA = "0x18265EE70")]
	protected ComponentSystemBase INNEALAFDNE<T>(params ComponentSystemBase[] ACFNMPOFKDJ) where T : LLMPKAOBELO, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x265EDA0", Offset = "0x265E1A0", VA = "0x18265EDA0")]
	protected ComponentSystemBase EJPKOBFFCKH<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x265EDA0", Offset = "0x265E1A0", VA = "0x18265EDA0")]
	protected ComponentSystemBase KELEHKPCNOM<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x60EE3C0", Offset = "0x60ED7C0", VA = "0x1860EE3C0")]
	protected ComponentSystemBase IEBALOPMNGN(params SystemHandleUntyped[] ACFNMPOFKDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x265EDE0", Offset = "0x265E1E0", VA = "0x18265EDE0")]
	protected ComponentSystemBase IEBALOPMNGN<T>(params SystemHandleUntyped[] ACFNMPOFKDJ) where T : LLMPKAOBELO, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x265EF00", Offset = "0x265E300", VA = "0x18265EF00")]
	protected SystemHandleUntyped LAPBBAEMJBN<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x60ED840", Offset = "0x60ECC40", VA = "0x1860ED840")]
	protected JADFAFKHNMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class LLMPKAOBELO : DIENMONFAON
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x60EE790", Offset = "0x60EDB90", VA = "0x1860EE790", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x60ED840", Offset = "0x60ECC40", VA = "0x1860ED840")]
	public LLMPKAOBELO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class DIENMONFAON : ComponentSystemGroup, KJGFDBLPJBK
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x60ED840", Offset = "0x60ECC40", VA = "0x1860ED840")]
	protected DIENMONFAON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class GIGKMOOMPJM : EntityCommandBufferSystem, KJGFDBLPJBK
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7A0100", Offset = "0x79F500", VA = "0x1807A0100")]
	protected GIGKMOOMPJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface OLBIJDCKEPB<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo FFILKOANIAP([In] TFrom PAHKKNONPEO);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface CEDFJHBGIEL<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LEFHJBCKJHC(T PAHKKNONPEO);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct CEMIELBJHIE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<Entity> NNLFMKFJDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public EntityCommandBuffer GNJDNHCJBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public ComponentTypes ELCADBFPILF;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x60ED4D0", Offset = "0x60EC8D0", VA = "0x1860ED4D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct ICEGMDNKDEH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<Entity> NNLFMKFJDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public EntityCommandBuffer GNJDNHCJBHB;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x60EE290", Offset = "0x60ED690", VA = "0x1860EE290", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct FJHGINBKDFD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<Entity> NNLFMKFJDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer GNJDNHCJBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public ComponentType JDFGMDNJEND;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x60EDF70", Offset = "0x60ED370", VA = "0x1860EDF70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct EGDGEDBKNHO<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public NativeArray<Entity> NNLFMKFJDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[ReadOnly]
	public NativeArray<T> GMLIPIALCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public EntityCommandBuffer GNJDNHCJBHB;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x32B4760", Offset = "0x32B3B60", VA = "0x1832B4760", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal struct LCMGKBKBGMA<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> NNLFMKFJDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public NativeArray<T> HHMCIHBKJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public EntityCommandBuffer GNJDNHCJBHB;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal struct LEKPFJOMKKO<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> NNLFMKFJDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public T PAHKKNONPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public EntityCommandBuffer GNJDNHCJBHB;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3C0CB40", Offset = "0x3C0BF40", VA = "0x183C0CB40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct IEMIEPAPCEI<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, OLBIJDCKEPB<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> ILEKJKAODBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<TTo> EPLGMIGLBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap EEEBGEOHFMI;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct CKFEECLPACO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity ILHEBFBPLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> ILEKJKAODBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[WriteOnly]
	public NativeArray<byte> EPLGMIGLBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public int IKHICLJAGIM;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x60ED5C0", Offset = "0x60EC9C0", VA = "0x1860ED5C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct GJMNPEPEJBP<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public ComponentDataFromEntity<T> EDNDFGGFPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<Entity> ILEKJKAODBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[WriteOnly]
	public NativeList<T> PJFEEBDGNBP;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct GKNNOKDKDLI<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, OLBIJDCKEPB<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<TFrom> JIIDGPPBFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[WriteOnly]
	public NativeList<TTo> EPLGMIGLBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public TMap EEEBGEOHFMI;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct CJKNKMJJFOB<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	public ComponentDataFromEntity<T> KGBMMIDDELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<Entity> GPKFDFMDECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public NativeArray<bool> PLBLEEAMIAH;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct MMKHOBNOIJC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> KGBMMIDDELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> GPKFDFMDECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeArray<bool> PLBLEEAMIAH;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3E0FD30", Offset = "0x3E0F130", VA = "0x183E0FD30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct MKJMJJIGFMO<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> ILEKJKAODBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public NativeList<T> PJFEEBDGNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeParallelHashSet<T> CNKEMCPDLKD;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3E0C880", Offset = "0x3E0BC80", VA = "0x183E0C880", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct KDMLEFHPAAI<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : OLBIJDCKEPB<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public NativeArray<TFrom> ILEKJKAODBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public NativeList<TFrom> PJFEEBDGNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeParallelHashSet<TTo> CNKEMCPDLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TMap EEEBGEOHFMI;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[BurstCompile]
internal struct BLIKOLGLEKL<T, TPredicate> : IJob where T : struct where TPredicate : struct, CEDFJHBGIEL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<T> ILEKJKAODBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> BFDAJDFGDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> MAPOOMHEAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TPredicate EEEBGEOHFMI;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4714E00", Offset = "0x4714200", VA = "0x184714E00", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[BurstCompile]
internal struct IIKPGHIDBAM<T, TPredicate> : IJob where T : struct where TPredicate : struct, CEDFJHBGIEL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> ILEKJKAODBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> PJFEEBDGNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate EEEBGEOHFMI;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[BurstCompile]
internal struct NBBCDIPOILL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public ComponentDataFromEntity KGBMMIDDELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> GPKFDFMDECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> DINIHBOKGDJ;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x60EEA90", Offset = "0x60EDE90", VA = "0x1860EEA90", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[BurstCompile]
internal struct ILNADOBIEIH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public ComponentDataFromEntity KGBMMIDDELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> GPKFDFMDECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> DINIHBOKGDJ;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x60EE330", Offset = "0x60ED730", VA = "0x1860EE330", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class CNHMPCMDDMI
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class GNPEGLCKKKP
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x25FABD0", Offset = "0x25F9FD0", VA = "0x1825FABD0")]
	public static bool EPPECIBPDFL<T>(this NativeArray<Entity> GPKFDFMDECM, EntityManager NJALJNGMKOL, Allocator FHOLEANHCPH = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class DGOBIHEGBKD
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class DEHMNFMGLGI<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		public DEHMNFMGLGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class PLPACGPEJPD<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		public PLPACGPEJPD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> EFFAMFGJJFK;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x60ED7B0", Offset = "0x60ECBB0", VA = "0x1860ED7B0")]
	public DGOBIHEGBKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class DFODCEKMCGD
{
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class DNNKHFCPOJF
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct KCLDHBDMAHK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct NBDNKHMCJLI<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal KCLDHBDMAHK<TFrom> AOGBEAODJPP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator FHOLEANHCPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> CFACMKCEEBG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct GPLOPJFOLOF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct NMDNPPILGPH<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal GPLOPJFOLOF<TFrom> AOGBEAODJPP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator FHOLEANHCPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> CFACMKCEEBG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct BAADAJKFEHE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public struct NAIBACFLIKI<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal BAADAJKFEHE<TFrom> AOGBEAODJPP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator FHOLEANHCPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal NativeArrayAsync<TFrom> CFACMKCEEBG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public struct HBBNGPIAPKB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public struct EFEJACAJPCM<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal HBBNGPIAPKB<TFrom> AOGBEAODJPP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator FHOLEANHCPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal NativeListAsync<TFrom> CFACMKCEEBG;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class GLHFNAFFGHI
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class DPKKMJDEOAB
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x24B4790", Offset = "0x24B3B90", VA = "0x1824B4790")]
	public static NativeList<T> MAOCLGLNALP<T>(this NativeList<T> BPDDGMKMDJL, Allocator FHOLEANHCPH = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x24B4810", Offset = "0x24B3C10", VA = "0x1824B4810")]
	public static NativeList<T> MAOCLGLNALP<T>(this NativeArray<T> BPDDGMKMDJL, Allocator FHOLEANHCPH = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class EKBELCOHPLJ
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class OLMJFPOGLJG
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x27908A0", Offset = "0x278FCA0", VA = "0x1827908A0")]
	[PFCFOCCOBIE]
	public static JobHandle FFGPDGGOGIN<T>(this EntityCommandBufferSystem ODAKOBGADED, NativeArrayAsync<Entity> NNLFMKFJDMK, NativeArrayAsync<T> GMLIPIALCHN, [Optional] JobHandle NONMHDKIABH) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2790B60", Offset = "0x278FF60", VA = "0x182790B60")]
	[PFCFOCCOBIE]
	public static JobHandle FFGPDGGOGIN<T>(this EntityCommandBufferSystem ODAKOBGADED, NativeArrayAsync<Entity> NNLFMKFJDMK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2790780", Offset = "0x278FB80", VA = "0x182790780")]
	[PFCFOCCOBIE]
	public static JobHandle FFGPDGGOGIN<T>(this EntityCommandBufferSystem ODAKOBGADED, NativeArray<Entity> NNLFMKFJDMK, [Optional] JobHandle NONMHDKIABH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x60EEC90", Offset = "0x60EE090", VA = "0x1860EEC90")]
	[PFCFOCCOBIE]
	public static JobHandle FFGPDGGOGIN(this EntityCommandBufferSystem ODAKOBGADED, NativeArray<Entity> NNLFMKFJDMK, ComponentTypes ELCADBFPILF, [Optional] JobHandle NONMHDKIABH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x60EEE00", Offset = "0x60EE200", VA = "0x1860EEE00")]
	[PFCFOCCOBIE]
	public static JobHandle FFGPDGGOGIN(this EntityCommandBufferSystem ODAKOBGADED, EntityCommandBuffer GNJDNHCJBHB, NativeArray<Entity> NNLFMKFJDMK, ComponentTypes ELCADBFPILF, [Optional] JobHandle NONMHDKIABH)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class BFJONJKNDAE
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x23F1610", Offset = "0x23F0A10", VA = "0x1823F1610")]
	[PFCFOCCOBIE]
	public static JobHandle BLNGIILJCHN<T>(this EntityCommandBufferSystem ODAKOBGADED, EntityCommandBuffer GNJDNHCJBHB, EntityQuery AAPMPKHNKLN, T PAHKKNONPEO) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class EPNDKNHOOJH
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x60EDCC0", Offset = "0x60ED0C0", VA = "0x1860EDCC0")]
	[PFCFOCCOBIE]
	public static JobHandle FIEKPANLIMF(this EntityCommandBufferSystem ODAKOBGADED, NativeList<Entity> NNLFMKFJDMK, [Optional] JobHandle NONMHDKIABH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x60EDE50", Offset = "0x60ED250", VA = "0x1860EDE50")]
	[PFCFOCCOBIE]
	public static JobHandle FIEKPANLIMF(this EntityCommandBufferSystem ODAKOBGADED, NativeArrayAsync<Entity> NNLFMKFJDMK)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class IGLLGNHGGDL
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x263F540", Offset = "0x263E940", VA = "0x18263F540")]
	public static void FIBGAIEKDKK<T>(this EntityCommandBufferSystem ODAKOBGADED, EntityQuery AAPMPKHNKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x263FED0", Offset = "0x263F2D0", VA = "0x18263FED0")]
	[PFCFOCCOBIE]
	public static JobHandle IOEJANMOMEP<T>(this EntityCommandBufferSystem ODAKOBGADED, NativeListAsync<Entity> NNLFMKFJDMK, [Optional] JobHandle NONMHDKIABH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x263FCA0", Offset = "0x263F0A0", VA = "0x18263FCA0")]
	[PFCFOCCOBIE]
	public static JobHandle IOEJANMOMEP<T>(this EntityCommandBufferSystem ODAKOBGADED, NativeArrayAsync<Entity> NNLFMKFJDMK, [Optional] JobHandle NONMHDKIABH)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class ODIBKDFMEOG
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2782FC0", Offset = "0x27823C0", VA = "0x182782FC0")]
	[PFCFOCCOBIE]
	public static JobHandle LNNPDJLMNBL<T>(this EntityCommandBufferSystem ODAKOBGADED, NativeArray<Entity> NNLFMKFJDMK, NativeArray<T> GMLIPIALCHN, JobHandle NONMHDKIABH) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class EDNNGJJLPKD
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x24CD7D0", Offset = "0x24CCBD0", VA = "0x1824CD7D0")]
	[PFCFOCCOBIE]
	public static JobHandle MOKPCCLKEPG<T>(this EntityCommandBufferSystem ODAKOBGADED, NativeArray<Entity> NNLFMKFJDMK, T PAHKKNONPEO, [Optional] JobHandle NONMHDKIABH) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x24CD8B0", Offset = "0x24CCCB0", VA = "0x1824CD8B0")]
	[PFCFOCCOBIE]
	public static JobHandle MOKPCCLKEPG<T>(this EntityCommandBufferSystem ODAKOBGADED, EntityCommandBuffer GNJDNHCJBHB, NativeArray<Entity> NNLFMKFJDMK, T PAHKKNONPEO, [Optional] JobHandle NONMHDKIABH) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class CCPJPBKOCLO
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x24588F0", Offset = "0x2457CF0", VA = "0x1824588F0")]
	public static NativeList<T> MAOCLGLNALP<T>(NativeList<T> BPDDGMKMDJL, Allocator FHOLEANHCPH) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class LLBHCNKBHCM
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x26B4300", Offset = "0x26B3700", VA = "0x1826B4300")]
	public static NativeArray<T> CFPIPFDFCGO<T>(this NativeList<Entity> BPDDGMKMDJL, EntityManager NJALJNGMKOL, Allocator FHOLEANHCPH = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x26B3DC0", Offset = "0x26B31C0", VA = "0x1826B3DC0")]
	public static NativeArray<T> CFPIPFDFCGO<T>(this NativeArray<Entity> BPDDGMKMDJL, EntityManager NJALJNGMKOL, Allocator FHOLEANHCPH = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x60EE5B0", Offset = "0x60ED9B0", VA = "0x1860EE5B0")]
	public static NativeArray<Entity> EAFIBDFJCNO(this NativeArray<Entity> BPDDGMKMDJL, EntityManager NJALJNGMKOL, ComponentType JDFGMDNJEND, Allocator FHOLEANHCPH = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x26B43B0", Offset = "0x26B37B0", VA = "0x1826B43B0")]
	public static NativeArray<T> CGPDIBNDEDO<T>(this NativeArray<Entity> BPDDGMKMDJL, EntityManager NJALJNGMKOL, Allocator FHOLEANHCPH = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class ICNAKJLBNJL
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct JLGFANNJMII<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public struct BBAENINBECE<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public JLGFANNJMII<TFrom> CFACMKCEEBG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator FHOLEANHCPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> ILEKJKAODBO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct KPCCKNPPKHP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public struct JPALAGHDPOK<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public KPCCKNPPKHP<TFrom> CFACMKCEEBG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator FHOLEANHCPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArrayAsync<TFrom> ILEKJKAODBO;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct HLPBNCMAHIN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public struct PFBBNKMKOLJ<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public HLPBNCMAHIN<TFrom> CFACMKCEEBG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator FHOLEANHCPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeListAsync<TFrom> ILEKJKAODBO;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class KIOMCBPLKLP
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class HPNIENAGMDF
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private struct EJEKIOILDGO : OLBIJDCKEPB<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> BPMKKNJIOHO;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x60ED890", Offset = "0x60ECC90", VA = "0x1860ED890")]
		[BurstCompatible]
		public Entity FFILKOANIAP([In] Entity PAHKKNONPEO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x60ED890", Offset = "0x60ECC90", VA = "0x1860ED890", Slot = "4")]
		private Entity HJIOCDKHDEP([In] Entity PAHKKNONPEO)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class DMMKKFLHPHG
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public struct BHJLJIGEGHE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator FHOLEANHCPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArray<Entity> BFDAJDFGDMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeArray<T> ILEKJKAODBO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct FADCIPCIAHO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator FHOLEANHCPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeList<Entity> BFDAJDFGDMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeArray<T> ILEKJKAODBO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct NKBNNEGMLKM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator FHOLEANHCPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<Entity> BFDAJDFGDMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public NativeArrayAsync<T> ILEKJKAODBO;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x253D9D0", Offset = "0x253CDD0", VA = "0x18253D9D0")]
		public NativeListAsync<Entity> LEFHJBCKJHC<TPredicate>() where TPredicate : struct, CEDFJHBGIEL<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x24AF740", Offset = "0x24AEB40", VA = "0x1824AF740")]
	public static NKBNNEGMLKM<T> EINCPJFDOIM<T>(this NativeArrayAsync<Entity> GPKFDFMDECM, NativeArrayAsync<T> BPDDGMKMDJL, Allocator FHOLEANHCPH = Allocator.TempJob) where T : struct
	{
		return default(NKBNNEGMLKM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class HLGELHILJOL
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x261BFE0", Offset = "0x261B3E0", VA = "0x18261BFE0")]
	public static NativeListAsync<Entity> AMFNOKGBOPN<T, TPredicate>(this NativeArrayAsync<T> BPDDGMKMDJL, NativeArrayAsync<Entity> GPKFDFMDECM, Allocator FHOLEANHCPH = Allocator.TempJob) where T : struct where TPredicate : struct, CEDFJHBGIEL<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x261C0A0", Offset = "0x261B4A0", VA = "0x18261C0A0")]
	private static NativeListAsync<Entity> MOOFNJIIPII<T, TPredicate>(NativeArrayAsync<T> CDLNHNIECBF, NativeArrayAsync<Entity> GPKFDFMDECM, int OGHJPGGPGJL, Allocator FHOLEANHCPH) where T : struct where TPredicate : struct, CEDFJHBGIEL<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class DAKOHMKDKCG
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct KMBEKOJAICB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Allocator FHOLEANHCPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public NativeArray<T> ILEKJKAODBO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct CHOKMKDEDBN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Allocator FHOLEANHCPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public NativeList<T> ILEKJKAODBO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct OIFFMPOMIDD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Allocator FHOLEANHCPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public NativeArrayAsync<T> ILEKJKAODBO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct EICHJLDGOLI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Allocator FHOLEANHCPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public NativeListAsync<T> ILEKJKAODBO;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class BJKNBMOIOJF
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class OJMDMMGHDNA
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x278EFF0", Offset = "0x278E3F0", VA = "0x18278EFF0")]
	public static NativeList<Entity> BAAHMCODALK<T>(this NativeArray<Entity> GPKFDFMDECM, EntityManager NJALJNGMKOL, Allocator FHOLEANHCPH = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class MIEDGIDOIHP
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class HDPHNIDHMBA
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public readonly struct FLBLNBAGEHL<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly NativeArray<TSrc> CBCBEPHCJOP;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1D1BD60", Offset = "0x1D1B160", VA = "0x181D1BD60")]
		public FLBLNBAGEHL(NativeArray<TSrc> CBCBEPHCJOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7FA350", Offset = "0x7F9750", VA = "0x1807FA350")]
		public MBFNPOPMBFA<TSrc, TValue> LKNFNOLOMHM<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(MBFNPOPMBFA<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public readonly struct MBFNPOPMBFA<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly NativeArray<TSrc> CBCBEPHCJOP;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1D1BD60", Offset = "0x1D1B160", VA = "0x181D1BD60")]
		public MBFNPOPMBFA(NativeArray<TSrc> CBCBEPHCJOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7FA350", Offset = "0x7F9750", VA = "0x1807FA350")]
		public EODINDPNANO<TSrc, TValue, TSelector> MOPAEKCHIGL<TSelector>() where TSelector : struct, OLBIJDCKEPB<TSrc, TValue>
		{
			return default(EODINDPNANO<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public readonly struct EODINDPNANO<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, OLBIJDCKEPB<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<TSrc> CBCBEPHCJOP;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1D1BD60", Offset = "0x1D1B160", VA = "0x181D1BD60")]
		public EODINDPNANO(NativeArray<TSrc> CBCBEPHCJOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x32F8E40", Offset = "0x32F8240", VA = "0x1832F8E40")]
		public GLHDNODJDKJ<TSrc, TValue, TSelector> INNEALAFDNE()
		{
			return default(GLHDNODJDKJ<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public struct KMJJMOOPNJN<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, OLBIJDCKEPB<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly NativeArray<TSrc> CBCBEPHCJOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TSelector FPOKAEKKBKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int FGBBDGJMFEH;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public TValue POOCHKNOAMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x3B74B30", Offset = "0x3B73F30", VA = "0x183B74B30")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int GOBEDCIKOGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x9BF520", Offset = "0x9BE920", VA = "0x1809BF520")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int KNKPDIOFOKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x1D31860", Offset = "0x1D30C60", VA = "0x181D31860")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3B74CB0", Offset = "0x3B740B0", VA = "0x183B74CB0")]
		public KMJJMOOPNJN(NativeArray<TSrc> CBCBEPHCJOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3B74BC0", Offset = "0x3B73FC0", VA = "0x183B74BC0")]
		public bool JLBCKNFAMDH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3B74BD0", Offset = "0x3B73FD0", VA = "0x183B74BD0")]
		private TSrc NAJBEKECBEB(int AMJKHBKANHA)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public struct GLHDNODJDKJ<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, OLBIJDCKEPB<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private KMJJMOOPNJN<TSrc, TValue, TSelector> JHGKLMJBPBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TValue NLEAMLHCOEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int PNHIOPPHDJO;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public JGAAELKHOPM MLJLIPGMANI
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x37BB4D0", Offset = "0x37BA8D0", VA = "0x1837BB4D0")]
			get
			{
				return default(JGAAELKHOPM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public TValue KHHNIDCJPMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x78F1D0", Offset = "0x78E5D0", VA = "0x18078F1D0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public (TValue value, JGAAELKHOPM range) POOCHKNOAMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x37BB2B0", Offset = "0x37BA6B0", VA = "0x1837BB2B0")]
			get
			{
				return default((TValue, JGAAELKHOPM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x37BB510", Offset = "0x37BA910", VA = "0x1837BB510")]
		public GLHDNODJDKJ(NativeArray<TSrc> CBCBEPHCJOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x32E1C20", Offset = "0x32E1020", VA = "0x1832E1C20")]
		public GLHDNODJDKJ<TSrc, TValue, TSelector> FPDPCEFPILF()
		{
			return default(GLHDNODJDKJ<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x37BB390", Offset = "0x37BA790", VA = "0x1837BB390")]
		public bool JLBCKNFAMDH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2614680", Offset = "0x2613A80", VA = "0x182614680")]
	public static FLBLNBAGEHL<T> MELPFLCCLOF<T>(this NativeList<T> EPAFMCCJAFF) where T : struct
	{
		return default(FLBLNBAGEHL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7FA350", Offset = "0x7F9750", VA = "0x1807FA350")]
	public static FLBLNBAGEHL<T> MELPFLCCLOF<T>(this NativeArray<T> CBCBEPHCJOP) where T : struct
	{
		return default(FLBLNBAGEHL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class GMNHDOIJBKB
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public struct DFACOIIBMGB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly NativeArray<T>.ReadOnly CBCBEPHCJOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int PNHIOPPHDJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int ILCKDNOKKEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private T NLEAMLHCOEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private T ANJLIHAGPBC;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public JGAAELKHOPM MLJLIPGMANI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x3912000", Offset = "0x3911400", VA = "0x183912000")]
			get
			{
				return default(JGAAELKHOPM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T KHHNIDCJPMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x334B860", Offset = "0x334AC60", VA = "0x18334B860")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public (T, JGAAELKHOPM) POOCHKNOAMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x4F922D0", Offset = "0x4F916D0", VA = "0x184F922D0")]
			get
			{
				return default((T, JGAAELKHOPM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x4F92790", Offset = "0x4F91B90", VA = "0x184F92790")]
		public DFACOIIBMGB(NativeArray<T> CBCBEPHCJOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x4F923A0", Offset = "0x4F917A0", VA = "0x184F923A0")]
		public DFACOIIBMGB<T> FPDPCEFPILF()
		{
			return default(DFACOIIBMGB<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x4F925B0", Offset = "0x4F919B0", VA = "0x184F925B0")]
		public bool JLBCKNFAMDH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2470EB0", Offset = "0x24702B0", VA = "0x182470EB0")]
		public IKEIJNFCJHD<T, TComparer> EKOAPOPIHOJ<TComparer>([Optional] TComparer JDJDKJKOEPD) where TComparer : struct, IEqualityComparer<T>
		{
			return default(IKEIJNFCJHD<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public struct IKEIJNFCJHD<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly NativeArray<T>.ReadOnly CBCBEPHCJOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int PNHIOPPHDJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int ILCKDNOKKEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private T NLEAMLHCOEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private T ANJLIHAGPBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private TComparer JDJDKJKOEPD;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public JGAAELKHOPM MLJLIPGMANI
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x3912000", Offset = "0x3911400", VA = "0x183912000")]
			get
			{
				return default(JGAAELKHOPM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public T KHHNIDCJPMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x334B860", Offset = "0x334AC60", VA = "0x18334B860")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public (T value, JGAAELKHOPM range) POOCHKNOAMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x3911D10", Offset = "0x3911110", VA = "0x183911D10")]
			get
			{
				return default((T, JGAAELKHOPM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3912010", Offset = "0x3911410", VA = "0x183912010")]
		public IKEIJNFCJHD(NativeArray<T>.ReadOnly CBCBEPHCJOP, TComparer JDJDKJKOEPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3911DE0", Offset = "0x39111E0", VA = "0x183911DE0")]
		public IKEIJNFCJHD<T, TComparer> FPDPCEFPILF()
		{
			return default(IKEIJNFCJHD<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3911E20", Offset = "0x3911220", VA = "0x183911E20")]
		public bool JLBCKNFAMDH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x25FA390", Offset = "0x25F9790", VA = "0x1825FA390")]
	public static DFACOIIBMGB<T> INNEALAFDNE<T>(this NativeArray<T> CBCBEPHCJOP) where T : struct
	{
		return default(DFACOIIBMGB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface FPJDOKKKBIL
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class LFGCPCLDPJD
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct IEHGFDJILIC<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class CLCAFLHFFOC : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public IEHGFDJILIC<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA31A50", Offset = "0xA30E50", VA = "0x180A31A50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x3612FD0", Offset = "0x36123D0", VA = "0x183612FD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7953B0", Offset = "0x7947B0", VA = "0x1807953B0")]
		[DebuggerHidden]
		public CLCAFLHFFOC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x4BB33C0", Offset = "0x4BB27C0", VA = "0x184BB33C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4BB3570", Offset = "0x4BB2970", VA = "0x184BB3570", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Action<Protobuf> OMBIJKPGGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream JMIGFDFADED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedInputStream EPFJFAMADDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Protobuf EBLGFJNNLDA;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public readonly int KNKPDIOFOKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8C5130", Offset = "0x8C4530", VA = "0x1808C5130")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x38DB400", Offset = "0x38DA800", VA = "0x1838DB400")]
	private IEHGFDJILIC(byte[] NKGLIMPLOMB, Action<Protobuf> OMBIJKPGGNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x247DB20", Offset = "0x247CF20", VA = "0x18247DB20")]
	public static IEHGFDJILIC<Protobuf> CNMCABBAMHK<Data>(ReadOnlySpan<byte> PKBBOCAODJK, ReadOnlySpan<Data> KHBDFCDIBGP, Action<Protobuf> OMBIJKPGGNP)
	{
		return default(IEHGFDJILIC<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x38DB270", Offset = "0x38DA670", VA = "0x1838DB270", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x38DB2B0", Offset = "0x38DA6B0", VA = "0x1838DB2B0", Slot = "4")]
	[IteratorStateMachine(typeof(IEHGFDJILIC<>.CLCAFLHFFOC))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x38DB3A0", Offset = "0x38DA7A0", VA = "0x1838DB3A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct IGIGJBIONGN<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] NKGLIMPLOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Protobuf EBLGFJNNLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly MemoryStream JMIGFDFADED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly CodedOutputStream JOFGNGJMKMA;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x38DE980", Offset = "0x38DDD80", VA = "0x1838DE980")]
	private IGIGJBIONGN(byte[] NKGLIMPLOMB, [In] Protobuf EBLGFJNNLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2480000", Offset = "0x247F400", VA = "0x182480000")]
	public static IGIGJBIONGN<Protobuf> CNMCABBAMHK<T>(ReadOnlySpan<T> KHBDFCDIBGP)
	{
		return default(IGIGJBIONGN<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x38DE950", Offset = "0x38DDD50", VA = "0x1838DE950")]
	public void GCOKNOOPNEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x38DE8C0", Offset = "0x38DDCC0", VA = "0x1838DE8C0")]
	public ByteString FJAOMEMEKGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x38DE790", Offset = "0x38DDB90", VA = "0x1838DE790", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct KFCJFLAGCDH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly MemoryStream JMIGFDFADED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly CodedInputStream EPFJFAMADDE;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x60EE570", Offset = "0x60ED970", VA = "0x1860EE570", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct AMIDNLJLOII : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly byte[] NKGLIMPLOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly MemoryStream JMIGFDFADED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly CodedOutputStream JOFGNGJMKMA;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x60ED240", Offset = "0x60EC640", VA = "0x1860ED240", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class LMKNMNKNNLI
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public delegate void DAAKJGGNMDA<From, To>(From CFACMKCEEBG, To GDDIIAFGFJC, BMKKLJMHPDP KHMDCJPKJFA);

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class GMGCLOKLLFF<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static DAAKJGGNMDA<From, To> EMIBCBNLDMI;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public GMGCLOKLLFF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x60EE7C0", Offset = "0x60EDBC0", VA = "0x1860EE7C0")]
	static LMKNMNKNNLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x26BEBD0", Offset = "0x26BDFD0", VA = "0x1826BEBD0")]
	public static void PKLGGFJJCCO<T>(DAAKJGGNMDA<T, T> BLECAPHJJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x26BF490", Offset = "0x26BE890", VA = "0x1826BF490")]
	public static void PKLGGFJJCCO<From, To>(DAAKJGGNMDA<From, To> BLECAPHJJPI, DAAKJGGNMDA<To, From> KDECDNKNAHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x26BE6E0", Offset = "0x26BDAE0", VA = "0x1826BE6E0")]
	public static void PKLGGFJJCCO<From, To>(DAAKJGGNMDA<From, To> EMIBCBNLDMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x26B6B70", Offset = "0x26B5F70", VA = "0x1826B6B70")]
	public static DAAKJGGNMDA<From, To> MHGNIIHPDHF<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x26BBED0", Offset = "0x26BB2D0", VA = "0x1826BBED0")]
	public static void OAHCNPNIBKE<From, To>(From CFACMKCEEBG, To GDDIIAFGFJC, BMKKLJMHPDP KHMDCJPKJFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class BMKKLJMHPDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> OJLLNKKKNMA;

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1CF3140", Offset = "0x1CF2540", VA = "0x181CF3140")]
	public BMKKLJMHPDP(NativeArray<EntityRemapUtility.EntityRemapInfo> OJLLNKKKNMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x60ED470", Offset = "0x60EC870", VA = "0x1860ED470")]
	public Entity AINIBFBLHLG(Entity GDMGHBDKKDG)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class BLMPENCMCGA
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x60ED380", Offset = "0x60EC780", VA = "0x1860ED380")]
	public static ulong CJFDOBDKEKG(Type KHENBEDBKDI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x60ED410", Offset = "0x60EC810", VA = "0x1860ED410")]
	public static ulong CJFDOBDKEKG(string OCCOICCFLNK)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[Flags]
public enum IDCEPPFEEFA
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Main = 5,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[AttributeUsage(AttributeTargets.Class)]
public class POABBAGAKCL : CAIDALFNJKH
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7A0100", Offset = "0x79F500", VA = "0x1807A0100")]
	public POABBAGAKCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal static class GDBMHLHNCBP
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x60EE050", Offset = "0x60ED450", VA = "0x1860EE050")]
	private unsafe static Span<byte> EHAPDAEDHMK(Unity.Entities.Chunk* FCIKAFGOFEA, int KMLGMMBHJMA)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x25F0170", Offset = "0x25EF570", VA = "0x1825F0170")]
	public unsafe static Span<T> BEFMFGCKMOB<T>(Unity.Entities.Chunk* FCIKAFGOFEA, int KMLGMMBHJMA)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x24B4120", Offset = "0x24B3520", VA = "0x1824B4120")]
	public static Span<T> BEFMFGCKMOB<T>(this Unity.Entities.Chunk FCIKAFGOFEA, int KMLGMMBHJMA)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x60EDFF0", Offset = "0x60ED3F0", VA = "0x1860EDFF0")]
	public unsafe static Span<Entity> ECHMBHCKEKD(Unity.Entities.Chunk* FCIKAFGOFEA)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x60EE120", Offset = "0x60ED520", VA = "0x1860EE120")]
	public unsafe static void EKABOMHIFDI(Unity.Entities.Chunk* FCIKAFGOFEA, int KMLGMMBHJMA)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class MCHCGHGHNGD
{
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public MCHCGHGHNGD()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
