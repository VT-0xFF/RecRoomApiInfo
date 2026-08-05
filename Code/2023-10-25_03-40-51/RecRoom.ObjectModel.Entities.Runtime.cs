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
		[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D4D050", Offset = "0x5D4BE50", VA = "0x185D4D050")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class BONFNKAEIII<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] MKLHOGGCNAI;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2D06EA0", Offset = "0x2D05CA0", VA = "0x182D06EA0")]
	public static void FODAMHPOJNO<TField>(int OCMJNDDMDAL, string MEBBBIMBIJO, NPIECMPEGKH JCEOCAELONC, [Out] KPOPJMLJIEE<TField> GHOAJKHDDHN) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2D0A090", Offset = "0x2D08E90", VA = "0x182D0A090")]
	public static void PMLPIPJMCHA<TField>(int OCMJNDDMDAL, string MEBBBIMBIJO, [Out] HPFFBCFNPLK<TField> CJKMAIBCGPM) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class BCPCGEJPJKG
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5D4CBC0", Offset = "0x5D4B9C0", VA = "0x185D4CBC0")]
	public static FieldInfo[] BAGOFHOELMJ(Type FLHOFPAHPKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class AHLIJBNOAKK<View, Data> : KHNKJBOEAPI where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType OMIDCDABMGL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type KPHEHAOIFAI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x34A86C0", Offset = "0x34A74C0", VA = "0x1834A86C0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override int OIBIDIPIPAD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x34A8340", Offset = "0x34A7140", VA = "0x1834A8340", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x34AAAC0", Offset = "0x34A98C0", VA = "0x1834AAAC0")]
	public Data KMNBMBOPFLI(Entity HHHGBIJCKBC)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View DGIGADFKFPO(Entity HHHGBIJCKBC);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x20487F0", Offset = "0x20475F0", VA = "0x1820487F0", Slot = "14")]
	public override T DGIGADFKFPO<T>(Entity HHHGBIJCKBC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
	protected AHLIJBNOAKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class KHNKJBOEAPI : NPIECMPEGKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle KPEHCPLFLHD;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EntityManager LHLNHKNJLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1181400", Offset = "0x1180200", VA = "0x181181400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract Type KPHEHAOIFAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int OIBIDIPIPAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Type BEBLFOMMNEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8B8940", Offset = "0x8B7740", VA = "0x1808B8940", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int BECCLIIAPKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5D4D9C0", Offset = "0x5D4C7C0", VA = "0x185D4D9C0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private JAPFLFMMLAJ[] HJIHCBACGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3BCE930", Offset = "0x3BCD730", VA = "0x183BCE930", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected internal virtual JAPFLFMMLAJ[] LLIHFMLNDEG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5D4D930", Offset = "0x5D4C730", VA = "0x185D4D930", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5D4DA30", Offset = "0x5D4C830", VA = "0x185D4DA30")]
	public void HCKCHEHGBKI(EntityManager GMDAKDJOHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract T DGIGADFKFPO<T>(Entity HHHGBIJCKBC) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5D4D750", Offset = "0x5D4C550", VA = "0x185D4D750", Slot = "8")]
	public (uint, uint) AECMIHCCDAK(Entity HHHGBIJCKBC)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5D4D840", Offset = "0x5D4C640", VA = "0x185D4D840", Slot = "9")]
	public bool CJIHFPEMOHB(Entity HHHGBIJCKBC, (uint order, uint change) FBJEHMGCPKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	protected KHNKJBOEAPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BGCPMHNFAIE
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KMGHKNHPEGG : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	KMDPNCANKMK IOLFAPGDCDJ
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
public interface FLHKDBJMMJA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OMLEBFNCMFA(Entity HHHGBIJCKBC, object EKDHBKMFLGI);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HKHHCGMNEOA(Entity HHHGBIJCKBC, object EKDHBKMFLGI);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IGIJGGJFLFM(Entity HHHGBIJCKBC);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KENGHJCNJIM(Entity HHHGBIJCKBC);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class FDPPKGIBNLD<TComponentData, TValue> : JKCHEBEIFJC<TValue>, IDisposable where TComponentData : struct, KMGHKNHPEGG
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class FKHOCFHALKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private List<(object token, TValue value)> MJLHCFFNENL;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int GJPDNICHPHI
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x2EC8160", Offset = "0x2EC6F60", VA = "0x182EC8160")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x33BD0A0", Offset = "0x33BBEA0", VA = "0x1833BD0A0")]
		public bool PNNPPOOLBPG([Out] TValue POACLGOFKAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x33BCE90", Offset = "0x33BBC90", VA = "0x1833BCE90")]
		public void EJEJBLJEAIN(object EKDHBKMFLGI, TValue POACLGOFKAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x33BD020", Offset = "0x33BBE20", VA = "0x1833BD020")]
		public bool KCJHGNBNEJA(object EKDHBKMFLGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x33BCF40", Offset = "0x33BBD40", VA = "0x1833BCF40")]
		public int ELOENOEFLLK(object EKDHBKMFLGI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x33BD190", Offset = "0x33BBF90", VA = "0x1833BD190")]
		public FKHOCFHALKC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Stack<FKHOCFHALKC> AEIFIIJDOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private OGJMEHDNBBP<KMDPNCANKMK, FKHOCFHALKC> LCIMBLNKMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EntityManager GMDAKDJOHKE;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3397D50", Offset = "0x3396B50", VA = "0x183397D50")]
	public FDPPKGIBNLD(EntityManager GMDAKDJOHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3397B10", Offset = "0x3396910", VA = "0x183397B10", Slot = "4")]
	public void OMLEBFNCMFA(Entity HHHGBIJCKBC, object EKDHBKMFLGI, TValue POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3397710", Offset = "0x3396510", VA = "0x183397710", Slot = "5")]
	public bool HKHHCGMNEOA(Entity HHHGBIJCKBC, object EKDHBKMFLGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3397C50", Offset = "0x3396A50", VA = "0x183397C50", Slot = "6")]
	public bool PNNPPOOLBPG(Entity HHHGBIJCKBC, [Out] TValue POACLGOFKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3397600", Offset = "0x3396400", VA = "0x183397600", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x33978D0", Offset = "0x33966D0", VA = "0x1833978D0")]
	private void JBNFBIELDFC(FKHOCFHALKC GABPNJFKJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3397960", Offset = "0x3396760", VA = "0x183397960")]
	private bool MPDOMDONLBM(Entity HHHGBIJCKBC, [Out] KMDPNCANKMK OFGGCMDABFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3397620", Offset = "0x3396420", VA = "0x183397620")]
	private void EGLBFGGANKM(Entity HHHGBIJCKBC, KMDPNCANKMK OFGGCMDABFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x33978B0", Offset = "0x33966B0", VA = "0x1833978B0")]
	private bool JBIEKAMBEHA(KMDPNCANKMK OFGGCMDABFP, [Out] FKHOCFHALKC GABPNJFKJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3397A20", Offset = "0x3396820", VA = "0x183397A20")]
	private FKHOCFHALKC OKKFABLKAOF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JKCHEBEIFJC<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OMLEBFNCMFA(Entity HHHGBIJCKBC, object EKDHBKMFLGI, TValue POACLGOFKAJ);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HKHHCGMNEOA(Entity HHHGBIJCKBC, object EKDHBKMFLGI);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PNNPPOOLBPG(Entity HHHGBIJCKBC, [Out] TValue POACLGOFKAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct KMDPNCANKMK : ACFFPCDNNOH, IEquatable<KMDPNCANKMK>
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly KMDPNCANKMK GNIJDJEELLH;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[CreateProperty]
	public int FCFMLMDMJIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7D5330", Offset = "0x7D4130", VA = "0x1807D5330", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7D5350", Offset = "0x7D4150", VA = "0x1807D5350", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[CreateProperty]
	public int MNNENJOIOME
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x200C8C0", Offset = "0x200B6C0", VA = "0x18200C8C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5184420", Offset = "0x5183220", VA = "0x185184420", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5D4DF30", Offset = "0x5D4CD30", VA = "0x185D4DF30", Slot = "8")]
	public bool Equals(KMDPNCANKMK LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5D4DF80", Offset = "0x5D4CD80", VA = "0x185D4DF80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CPPFANIHADA<THasTokensTag> : FLHKDBJMMJA, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<Entity, KMDPNCANKMK> BMJHBGNBBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly Stack<HashSet<object>> AEIFIIJDOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private OGJMEHDNBBP<KMDPNCANKMK, HashSet<object>> LCIMBLNKMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private EntityManager GMDAKDJOHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private EntityCommandBufferSystem NFGGBBOFGOH;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4A46740", Offset = "0x4A45540", VA = "0x184A46740")]
	public CPPFANIHADA(EntityManager GMDAKDJOHKE, EntityCommandBufferSystem NFGGBBOFGOH, HICMFDICNOL ELMOHPEMBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4A45A10", Offset = "0x4A44810", VA = "0x184A45A10", Slot = "4")]
	public bool OMLEBFNCMFA(Entity HHHGBIJCKBC, object EKDHBKMFLGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4A43920", Offset = "0x4A42720", VA = "0x184A43920", Slot = "5")]
	public bool HKHHCGMNEOA(Entity HHHGBIJCKBC, object EKDHBKMFLGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4A44090", Offset = "0x4A42E90", VA = "0x184A44090", Slot = "6")]
	public bool IGIJGGJFLFM(Entity HHHGBIJCKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4A441D0", Offset = "0x4A42FD0", VA = "0x184A441D0", Slot = "9")]
	public bool IGIJGGJFLFM(KMDPNCANKMK OFGGCMDABFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4A44A90", Offset = "0x4A43890", VA = "0x184A44A90", Slot = "7")]
	public bool KENGHJCNJIM(Entity HHHGBIJCKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4A42C30", Offset = "0x4A41A30", VA = "0x184A42C30", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4A444C0", Offset = "0x4A432C0", VA = "0x184A444C0")]
	private void JBNFBIELDFC(HashSet<object> GABPNJFKJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4A44D90", Offset = "0x4A43B90", VA = "0x184A44D90")]
	private bool MPDOMDONLBM(Entity HHHGBIJCKBC, [Out] KMDPNCANKMK OFGGCMDABFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4A432A0", Offset = "0x4A420A0", VA = "0x184A432A0")]
	private bool GOAAPKFCGOP(Entity HHHGBIJCKBC, [Out] KMDPNCANKMK OFGGCMDABFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4A43DC0", Offset = "0x4A42BC0", VA = "0x184A43DC0")]
	private void HMGFNDGGAHA(Entity HHHGBIJCKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4A451A0", Offset = "0x4A43FA0", VA = "0x184A451A0")]
	private void NNMJPCJJBDA(Entity HHHGBIJCKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4A44710", Offset = "0x4A43510", VA = "0x184A44710")]
	private void KEJFMBPCHKB(Entity HHHGBIJCKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4A42E50", Offset = "0x4A41C50", VA = "0x184A42E50")]
	private void EGLBFGGANKM(Entity HHHGBIJCKBC, KMDPNCANKMK OFGGCMDABFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4A42A50", Offset = "0x4A41850", VA = "0x184A42A50")]
	private bool CIPDMENJKNG(KMDPNCANKMK OFGGCMDABFP, [Out] HashSet<object> GABPNJFKJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4A45790", Offset = "0x4A44590", VA = "0x184A45790")]
	private HashSet<object> OKKFABLKAOF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class NEBBFDHAANO
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct IAIFOJGGPJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int NNACFOFLCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int NENAAIFMEME;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int IKKFEAHBANE
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7D5330", Offset = "0x7D4130", VA = "0x1807D5330")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int GJPDNICHPHI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x200C8C0", Offset = "0x200B6C0", VA = "0x18200C8C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5184420", Offset = "0x5183220", VA = "0x185184420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int IOFCHKBGOAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7D5330", Offset = "0x7D4130", VA = "0x1807D5330")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7D5350", Offset = "0x7D4150", VA = "0x1807D5350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int OACGCGFLLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5D4D5F0", Offset = "0x5D4C3F0", VA = "0x185D4D5F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5D4D600", Offset = "0x5D4C400", VA = "0x185D4D600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x97A610", Offset = "0x979410", VA = "0x18097A610")]
	private IAIFOJGGPJK(int NNACFOFLCKF, int NENAAIFMEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1C75050", Offset = "0x1C73E50", VA = "0x181C75050")]
	public static IAIFOJGGPJK HNOGOCKLNNJ(int NNACFOFLCKF, int NENAAIFMEME)
	{
		return default(IAIFOJGGPJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5D4D5E0", Offset = "0x5D4C3E0", VA = "0x185D4D5E0")]
	public static IAIFOJGGPJK HEKMCEPHDEO(int IHNKLCGMFDI, int MBGJPMIDMIA)
	{
		return default(IAIFOJGGPJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5D4D610", Offset = "0x5D4C410", VA = "0x185D4D610", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct ONCODCBLEIP : GHLDNAHLONK<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5D31DA0", Offset = "0x5D30BA0", VA = "0x185D31DA0")]
	public float DENFBJJPHJF([In] float3 POACLGOFKAJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5D31DA0", Offset = "0x5D30BA0", VA = "0x185D31DA0", Slot = "4")]
	private float BCILODKFCFH([In] float3 POACLGOFKAJ)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct AOFCCBJFIHN : GHLDNAHLONK<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5D342E0", Offset = "0x5D330E0", VA = "0x185D342E0")]
	public float DENFBJJPHJF([In] float3 POACLGOFKAJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5D342E0", Offset = "0x5D330E0", VA = "0x185D342E0", Slot = "4")]
	private float BCILODKFCFH([In] float3 POACLGOFKAJ)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct BOMKAJNKLPN : GHLDNAHLONK<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x18BC310", Offset = "0x18BB110", VA = "0x1818BC310")]
	public float DENFBJJPHJF([In] float3 POACLGOFKAJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x18BC310", Offset = "0x18BB110", VA = "0x1818BC310", Slot = "4")]
	private float BCILODKFCFH([In] float3 POACLGOFKAJ)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct PGIGNFNAIDI : GHLDNAHLONK<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1220F20", Offset = "0x121FD20", VA = "0x181220F20")]
	public int DENFBJJPHJF([In] int3 POACLGOFKAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1220F20", Offset = "0x121FD20", VA = "0x181220F20", Slot = "4")]
	private int JLEJCHFIJPD([In] int3 POACLGOFKAJ)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct BAFCJGPMNHP : GHLDNAHLONK<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5D332F0", Offset = "0x5D320F0", VA = "0x185D332F0")]
	public int DENFBJJPHJF([In] int3 POACLGOFKAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5D332F0", Offset = "0x5D320F0", VA = "0x185D332F0", Slot = "4")]
	private int JLEJCHFIJPD([In] int3 POACLGOFKAJ)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct GKECCKGIKGD : GHLDNAHLONK<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x14F0890", Offset = "0x14EF690", VA = "0x1814F0890")]
	public int DENFBJJPHJF([In] int3 POACLGOFKAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x14F0890", Offset = "0x14EF690", VA = "0x1814F0890", Slot = "4")]
	private int JLEJCHFIJPD([In] int3 POACLGOFKAJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class BODJMCHONBD : ANIFJPLLIHB
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Type ABMDBLKFKLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Type LAEBBCKEDNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5D4CD90", Offset = "0x5D4BB90", VA = "0x185D4CD90")]
	public BODJMCHONBD(Type FGACHIPLLOL, Type GEBLBKGFJHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class HHEFILAIABA : ANIFJPLLIHB
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Type LAEBBCKEDNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5C6B2F0", Offset = "0x5C6A0F0", VA = "0x185C6B2F0")]
	public HHEFILAIABA(Type GEBLBKGFJHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FKLDPMHNDNC : ANIFJPLLIHB
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x76E100", Offset = "0x76CF00", VA = "0x18076E100")]
	public FKLDPMHNDNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class PHABDGFMDOO<Data> : GIIOFPANJDM where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public virtual Data IKMLLOOIGKE
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x75DC40", Offset = "0x75CA40", VA = "0x18075DC40", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3DB8900", Offset = "0x3DB7700", VA = "0x183DB8900", Slot = "8")]
	protected virtual bool NGJOIMFOKBM(ReadOnlySpan<Data> KJFBOMAGMGG, KGPPHNCOAFD DPJAFHOCHKL, [Out] ReadOnlySpan<byte> HGPPIPGOKCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "9")]
	protected virtual bool ENADNEDIEBN(int FBJEHMGCPKI, Span<Data> KJFBOMAGMGG, [In] ReadOnlySpan<byte> HGPPIPGOKCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3DB8840", Offset = "0x3DB7640", VA = "0x183DB8840", Slot = "5")]
	internal sealed override bool NGJOIMFOKBM(Unity.Entities.Chunk PKPEFKLAONK, int FDIKGJDICEP, KGPPHNCOAFD DPJAFHOCHKL, [Out] ReadOnlySpan<byte> HGPPIPGOKCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3DB6E50", Offset = "0x3DB5C50", VA = "0x183DB6E50", Slot = "6")]
	internal sealed override bool ENADNEDIEBN(int FBJEHMGCPKI, Unity.Entities.Chunk PKPEFKLAONK, int FDIKGJDICEP, [In] ReadOnlySpan<byte> HGPPIPGOKCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x22D2160", Offset = "0x22D0F60", VA = "0x1822D2160")]
	protected GECAEAINBIL<Protobuf> AGGEMPIMDND<Protobuf>(ReadOnlySpan<Data> KJFBOMAGMGG) where Protobuf : IMessage, new()
	{
		return default(GECAEAINBIL<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x22D21B0", Offset = "0x22D0FB0", VA = "0x1822D21B0")]
	protected INJELCGHFKL<Protobuf> DHBAAEMOCNB<Protobuf>(ReadOnlySpan<byte> HGPPIPGOKCB, ReadOnlySpan<Data> KJFBOMAGMGG, Action<Protobuf> PIBBOAEEKCA) where Protobuf : IMessage, new()
	{
		return default(INJELCGHFKL<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
	protected PHABDGFMDOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class GIIOFPANJDM
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected abstract int MNNENJOIOME
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5D4D080", Offset = "0x5D4BE80", VA = "0x185D4D080", Slot = "5")]
	internal virtual bool NGJOIMFOKBM(Unity.Entities.Chunk PKPEFKLAONK, int FDIKGJDICEP, KGPPHNCOAFD DPJAFHOCHKL, [Out] ReadOnlySpan<byte> HGPPIPGOKCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "6")]
	internal virtual bool ENADNEDIEBN(int FBJEHMGCPKI, Unity.Entities.Chunk PKPEFKLAONK, int FDIKGJDICEP, [In] ReadOnlySpan<byte> HGPPIPGOKCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	protected GIIOFPANJDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface DHLOIFDDGPH
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class DBMABBOGEPD : SystemBase, DHLOIFDDGPH
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5D4CE80", Offset = "0x5D4BC80", VA = "0x185D4CE80")]
	public ComponentDataFromEntity LHFCEFAEPPF(int NGICFBMMBFC, bool IGEJIDKFEOB = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5D4CE60", Offset = "0x5D4BC60", VA = "0x185D4CE60")]
	public EntityExistenceLookupByEntity AMJMJAPAOMF()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5D4CF40", Offset = "0x5D4BD40", VA = "0x185D4CF40", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x76E100", Offset = "0x76CF00", VA = "0x18076E100")]
	protected DBMABBOGEPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public abstract class LLHIKPBJIAL : DBMABBOGEPD
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E0C0", Offset = "0x5D4CEC0", VA = "0x185D4E0C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x76E100", Offset = "0x76CF00", VA = "0x18076E100")]
	protected LLHIKPBJIAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class NKLFLLOGAAG
{
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public abstract class MJGNCFJNMEO : MOBNIBIKMKJ
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E210", Offset = "0x5D4D010", VA = "0x185D4E210", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase LEEJNJLKEEP();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E1C0", Offset = "0x5D4CFC0", VA = "0x185D4E1C0")]
	protected ComponentSystemBase IMBIONFONNE(params ComponentSystemBase[] LJGJEFKLGIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x24831A0", Offset = "0x2481FA0", VA = "0x1824831A0")]
	protected ComponentSystemBase IMBIONFONNE<T>(params ComponentSystemBase[] LJGJEFKLGIF) where T : MOBNIBIKMKJ, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2483230", Offset = "0x2482030", VA = "0x182483230")]
	protected ComponentSystemBase PAHCBJAMDDE<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2483230", Offset = "0x2482030", VA = "0x182483230")]
	protected ComponentSystemBase NNLNCFIIDLC<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E260", Offset = "0x5D4D060", VA = "0x185D4E260")]
	protected ComponentSystemBase PJBAENGAHED(params SystemHandleUntyped[] LJGJEFKLGIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2483270", Offset = "0x2482070", VA = "0x182483270")]
	protected ComponentSystemBase PJBAENGAHED<T>(params SystemHandleUntyped[] LJGJEFKLGIF) where T : MOBNIBIKMKJ, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2483140", Offset = "0x2481F40", VA = "0x182483140")]
	protected SystemHandleUntyped FCBOGPKKNAD<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5D4CAE0", Offset = "0x5D4B8E0", VA = "0x185D4CAE0")]
	protected MJGNCFJNMEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class MOBNIBIKMKJ : BAABILOAFLF
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E2B0", Offset = "0x5D4D0B0", VA = "0x185D4E2B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5D4CAE0", Offset = "0x5D4B8E0", VA = "0x185D4CAE0")]
	public MOBNIBIKMKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class BAABILOAFLF : ComponentSystemGroup, DHLOIFDDGPH
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5D4CAE0", Offset = "0x5D4B8E0", VA = "0x185D4CAE0")]
	protected BAABILOAFLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class HHGLAFOEFFN : EntityCommandBufferSystem, DHLOIFDDGPH
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x76E100", Offset = "0x76CF00", VA = "0x18076E100")]
	protected HHGLAFOEFFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface GHLDNAHLONK<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo DENFBJJPHJF([In] TFrom POACLGOFKAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface CHEGBPBCJJE<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LPCEPMDACBO(T POACLGOFKAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct KKFECNKOPBC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<Entity> DDIFFODKOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public EntityCommandBuffer LLLOCGMAOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public ComponentTypes EPGGIHGBGEL;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5D4DE40", Offset = "0x5D4CC40", VA = "0x185D4DE40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct JIFGNBIBLJG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<Entity> DDIFFODKOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public EntityCommandBuffer LLLOCGMAOIH;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5D4D6A0", Offset = "0x5D4C4A0", VA = "0x185D4D6A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct CNCBEGGPHJI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<Entity> DDIFFODKOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer LLLOCGMAOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public ComponentType AGCPJNMOOIE;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5D4CDE0", Offset = "0x5D4BBE0", VA = "0x185D4CDE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct HOOJNMNPKMK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public NativeArray<Entity> DDIFFODKOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[ReadOnly]
	public NativeArray<T> LMCJHCIOIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public EntityCommandBuffer LLLOCGMAOIH;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x35EDCC0", Offset = "0x35ECAC0", VA = "0x1835EDCC0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal struct AJKCIJDBOJP<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> DDIFFODKOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public NativeArray<T> MFELMHKMEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public EntityCommandBuffer LLLOCGMAOIH;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal struct HDLOEJADBEM<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> DDIFFODKOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public T POACLGOFKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public EntityCommandBuffer LLLOCGMAOIH;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x35D1FC0", Offset = "0x35D0DC0", VA = "0x1835D1FC0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct GMLBKJCMFIL<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, GHLDNAHLONK<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> GBHPBMLPNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<TTo> PNONHLOKLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap IPGJPNDBCJD;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct DGNJCCIBNAO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity DHJIPEHBECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> GBHPBMLPNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[WriteOnly]
	public NativeArray<byte> PNONHLOKLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public int IIHCPBHDJII;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5D4CF50", Offset = "0x5D4BD50", VA = "0x185D4CF50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct KOHPMMFGPPB<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public ComponentDataFromEntity<T> OLCCIOAHOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<Entity> GBHPBMLPNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[WriteOnly]
	public NativeList<T> IPJLMNBJMAJ;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct BOJPAPKHDEP<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, GHLDNAHLONK<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<TFrom> LHMKALKLPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[WriteOnly]
	public NativeList<TTo> PNONHLOKLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public TMap IPGJPNDBCJD;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct OCCCLIJODFP<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	public ComponentDataFromEntity<T> GEBLBKGFJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<Entity> GECODIGACIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public NativeArray<bool> LOBFJIJLPMN;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct GILKPJECCEM<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> GEBLBKGFJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> GECODIGACIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeArray<bool> LOBFJIJLPMN;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3521F70", Offset = "0x3520D70", VA = "0x183521F70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct CMJMOCDOGCA<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> GBHPBMLPNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public NativeList<T> IPJLMNBJMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeParallelHashSet<T> ADJNHCLNKGJ;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4A39C80", Offset = "0x4A38A80", VA = "0x184A39C80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct IIBODCDGHEN<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : GHLDNAHLONK<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public NativeArray<TFrom> GBHPBMLPNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public NativeList<TFrom> IPJLMNBJMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeParallelHashSet<TTo> ADJNHCLNKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TMap IPGJPNDBCJD;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[BurstCompile]
internal struct HANEEOLOJLJ<T, TPredicate> : IJob where T : struct where TPredicate : struct, CHEGBPBCJJE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<T> GBHPBMLPNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> CIMOFDGBIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> KHBFEFMEDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TPredicate IPGJPNDBCJD;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x35A8E70", Offset = "0x35A7C70", VA = "0x1835A8E70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[BurstCompile]
internal struct BFKGHLDOLEE<T, TPredicate> : IJob where T : struct where TPredicate : struct, CHEGBPBCJJE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> GBHPBMLPNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> IPJLMNBJMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate IPGJPNDBCJD;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[BurstCompile]
internal struct LNFMPAAGHFK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public ComponentDataFromEntity GEBLBKGFJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> GECODIGACIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> FJOLMAGIGMI;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E0F0", Offset = "0x5D4CEF0", VA = "0x185D4E0F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[BurstCompile]
internal struct BGLPFLDNDFN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public ComponentDataFromEntity GEBLBKGFJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> GECODIGACIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> FJOLMAGIGMI;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5D4CD00", Offset = "0x5D4BB00", VA = "0x185D4CD00", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class DMIGANDNFEH
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class FAOJMHLEDMG
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x23669A0", Offset = "0x23657A0", VA = "0x1823669A0")]
	public static bool FDLNEGJOAIE<T>(this NativeArray<Entity> GECODIGACIA, EntityManager GMDAKDJOHKE, Allocator MBGJLDPPIJN = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class BAIEBEBHKJN
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class OMAMCLPOMBM<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		public OMAMCLPOMBM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class FPFOIONIMFM<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		public FPFOIONIMFM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> NCAAIMLIIOG;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5D4CB30", Offset = "0x5D4B930", VA = "0x185D4CB30")]
	public BAIEBEBHKJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class JKHCCODAJPH
{
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class JCOCLFBFABO
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct AKBAEHMPFGL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct FOLDPICLPLC<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal AKBAEHMPFGL<TFrom> LPDGANJNOMK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator MBGJLDPPIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> ECAFGEFAJGI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct OLFEDJIEBNO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct DAHCGHEJJJC<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal OLFEDJIEBNO<TFrom> LPDGANJNOMK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator MBGJLDPPIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> ECAFGEFAJGI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct MGHBFPKBPGN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public struct JBNGHJLKILB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal MGHBFPKBPGN<TFrom> LPDGANJNOMK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator MBGJLDPPIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal NativeArrayAsync<TFrom> ECAFGEFAJGI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public struct HIHLLDKBHNG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public struct HGNLIBJLDND<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal HIHLLDKBHNG<TFrom> LPDGANJNOMK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator MBGJLDPPIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal NativeListAsync<TFrom> ECAFGEFAJGI;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class CGEOHIJKPOH
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class HJHHBEFKPFF
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x23D4140", Offset = "0x23D2F40", VA = "0x1823D4140")]
	public static NativeList<T> PGILMIJHCMJ<T>(this NativeList<T> DEJNCBLIGJI, Allocator MBGJLDPPIJN = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x23D41C0", Offset = "0x23D2FC0", VA = "0x1823D41C0")]
	public static NativeList<T> PGILMIJHCMJ<T>(this NativeArray<T> DEJNCBLIGJI, Allocator MBGJLDPPIJN = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class DKIBCMNBOIJ
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class HDAEMPANOBD
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x23AF130", Offset = "0x23ADF30", VA = "0x1823AF130")]
	[PIEKGPHBGIP]
	public static JobHandle JAPJEIDCGBD<T>(this EntityCommandBufferSystem NFGGBBOFGOH, NativeArrayAsync<Entity> DDIFFODKOKJ, NativeArrayAsync<T> LMCJHCIOIIP, [Optional] JobHandle EJGMMMMHMMK) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x23AF090", Offset = "0x23ADE90", VA = "0x1823AF090")]
	[PIEKGPHBGIP]
	public static JobHandle JAPJEIDCGBD<T>(this EntityCommandBufferSystem NFGGBBOFGOH, NativeArrayAsync<Entity> DDIFFODKOKJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x23AEF70", Offset = "0x23ADD70", VA = "0x1823AEF70")]
	[PIEKGPHBGIP]
	public static JobHandle JAPJEIDCGBD<T>(this EntityCommandBufferSystem NFGGBBOFGOH, NativeArray<Entity> DDIFFODKOKJ, [Optional] JobHandle EJGMMMMHMMK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5D4D1E0", Offset = "0x5D4BFE0", VA = "0x185D4D1E0")]
	[PIEKGPHBGIP]
	public static JobHandle JAPJEIDCGBD(this EntityCommandBufferSystem NFGGBBOFGOH, NativeArray<Entity> DDIFFODKOKJ, ComponentTypes EPGGIHGBGEL, [Optional] JobHandle EJGMMMMHMMK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5D4D090", Offset = "0x5D4BE90", VA = "0x185D4D090")]
	[PIEKGPHBGIP]
	public static JobHandle JAPJEIDCGBD(this EntityCommandBufferSystem NFGGBBOFGOH, EntityCommandBuffer LLLOCGMAOIH, NativeArray<Entity> DDIFFODKOKJ, ComponentTypes EPGGIHGBGEL, [Optional] JobHandle EJGMMMMHMMK)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class PAGLOBKBLJM
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x250DA30", Offset = "0x250C830", VA = "0x18250DA30")]
	[PIEKGPHBGIP]
	public static JobHandle KABOFAHIAHJ<T>(this EntityCommandBufferSystem NFGGBBOFGOH, EntityCommandBuffer LLLOCGMAOIH, EntityQuery GJGJMLNNIOK, T POACLGOFKAJ) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class HGIDMHNMIBG
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5D4D350", Offset = "0x5D4C150", VA = "0x185D4D350")]
	[PIEKGPHBGIP]
	public static JobHandle OGJMDMPAGIF(this EntityCommandBufferSystem NFGGBBOFGOH, NativeList<Entity> DDIFFODKOKJ, [Optional] JobHandle EJGMMMMHMMK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5D4D4E0", Offset = "0x5D4C2E0", VA = "0x185D4D4E0")]
	[PIEKGPHBGIP]
	public static JobHandle OGJMDMPAGIF(this EntityCommandBufferSystem NFGGBBOFGOH, NativeArrayAsync<Entity> DDIFFODKOKJ)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class PDAMPMCOBMO
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x250FD10", Offset = "0x250EB10", VA = "0x18250FD10")]
	public static void BGCFPKAENIN<T>(this EntityCommandBufferSystem NFGGBBOFGOH, EntityQuery GJGJMLNNIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x25104C0", Offset = "0x250F2C0", VA = "0x1825104C0")]
	[PIEKGPHBGIP]
	public static JobHandle PBJMAMCLODF<T>(this EntityCommandBufferSystem NFGGBBOFGOH, NativeListAsync<Entity> DDIFFODKOKJ, [Optional] JobHandle EJGMMMMHMMK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x2510330", Offset = "0x250F130", VA = "0x182510330")]
	[PIEKGPHBGIP]
	public static JobHandle PBJMAMCLODF<T>(this EntityCommandBufferSystem NFGGBBOFGOH, NativeArrayAsync<Entity> DDIFFODKOKJ, [Optional] JobHandle EJGMMMMHMMK)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class NONKMBCOEGC
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x24EA120", Offset = "0x24E8F20", VA = "0x1824EA120")]
	[PIEKGPHBGIP]
	public static JobHandle AIPECNIDDOF<T>(this EntityCommandBufferSystem NFGGBBOFGOH, NativeArray<Entity> DDIFFODKOKJ, NativeArray<T> LMCJHCIOIIP, JobHandle EJGMMMMHMMK) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class PKBGAKFDPDH
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x251AE40", Offset = "0x2519C40", VA = "0x18251AE40")]
	[PIEKGPHBGIP]
	public static JobHandle CKGPCECGDAE<T>(this EntityCommandBufferSystem NFGGBBOFGOH, NativeArray<Entity> DDIFFODKOKJ, T POACLGOFKAJ, [Optional] JobHandle EJGMMMMHMMK) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x251AF20", Offset = "0x2519D20", VA = "0x18251AF20")]
	[PIEKGPHBGIP]
	public static JobHandle CKGPCECGDAE<T>(this EntityCommandBufferSystem NFGGBBOFGOH, EntityCommandBuffer LLLOCGMAOIH, NativeArray<Entity> DDIFFODKOKJ, T POACLGOFKAJ, [Optional] JobHandle EJGMMMMHMMK) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class JCCBDFEIHBE
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x23F9870", Offset = "0x23F8670", VA = "0x1823F9870")]
	public static NativeList<T> PGILMIJHCMJ<T>(NativeList<T> DEJNCBLIGJI, Allocator MBGJLDPPIJN) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class PPIEJPNAPOM
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2526520", Offset = "0x2525320", VA = "0x182526520")]
	public static NativeArray<T> POBOLGHHMFC<T>(this NativeList<Entity> DEJNCBLIGJI, EntityManager GMDAKDJOHKE, Allocator MBGJLDPPIJN = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2525FE0", Offset = "0x2524DE0", VA = "0x182525FE0")]
	public static NativeArray<T> POBOLGHHMFC<T>(this NativeArray<Entity> DEJNCBLIGJI, EntityManager GMDAKDJOHKE, Allocator MBGJLDPPIJN = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class EGGJFMENFHB
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct LLGHJNAMBMJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public struct LLHCJFFDMLC<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public LLGHJNAMBMJ<TFrom> ECAFGEFAJGI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator MBGJLDPPIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> GBHPBMLPNIH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct JOAHNMHGGGL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public struct PECBKLGBDLA<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public JOAHNMHGGGL<TFrom> ECAFGEFAJGI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator MBGJLDPPIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArrayAsync<TFrom> GBHPBMLPNIH;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct DNLMLEFFBIP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public struct MGBBFHPAJOA<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public DNLMLEFFBIP<TFrom> ECAFGEFAJGI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator MBGJLDPPIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeListAsync<TFrom> GBHPBMLPNIH;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class NBLGMODNCOO
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class KCHJAOFGINI
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private struct FECHHEGLIAK : GHLDNAHLONK<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> DEKNLKOGFGM;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5D4D070", Offset = "0x5D4BE70", VA = "0x185D4D070")]
		[BurstCompatible]
		public Entity DENFBJJPHJF([In] Entity POACLGOFKAJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5D4D070", Offset = "0x5D4BE70", VA = "0x185D4D070", Slot = "4")]
		private Entity ONFJKNNCEJL([In] Entity POACLGOFKAJ)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class FLBFJMEBNBO
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public struct KGBFIGOFDJM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator MBGJLDPPIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArray<Entity> CIMOFDGBIMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeArray<T> GBHPBMLPNIH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct MGLDPDAGCNN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator MBGJLDPPIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeList<Entity> CIMOFDGBIMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeArray<T> GBHPBMLPNIH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct CDFOIIJHNKP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator MBGJLDPPIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<Entity> CIMOFDGBIMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public NativeArrayAsync<T> GBHPBMLPNIH;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2D0A670", Offset = "0x2D09470", VA = "0x182D0A670")]
		public NativeListAsync<Entity> LPCEPMDACBO<TPredicate>() where TPredicate : struct, CHEGBPBCJJE<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2391580", Offset = "0x2390380", VA = "0x182391580")]
	public static CDFOIIJHNKP<T> KCDJCPMCLMJ<T>(this NativeArrayAsync<Entity> GECODIGACIA, NativeArrayAsync<T> DEJNCBLIGJI, Allocator MBGJLDPPIJN = Allocator.TempJob) where T : struct
	{
		return default(CDFOIIJHNKP<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class ODEDFCCPJMG
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x24FFBD0", Offset = "0x24FE9D0", VA = "0x1824FFBD0")]
	public static NativeListAsync<Entity> DLPCNDKDNNE<T, TPredicate>(this NativeArrayAsync<T> DEJNCBLIGJI, NativeArrayAsync<Entity> GECODIGACIA, Allocator MBGJLDPPIJN = Allocator.TempJob) where T : struct where TPredicate : struct, CHEGBPBCJJE<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x24FFC90", Offset = "0x24FEA90", VA = "0x1824FFC90")]
	private static NativeListAsync<Entity> NFGBLKNMFAK<T, TPredicate>(NativeArrayAsync<T> FKGAHMGLPGK, NativeArrayAsync<Entity> GECODIGACIA, int JGMNJBPPKGP, Allocator MBGJLDPPIJN) where T : struct where TPredicate : struct, CHEGBPBCJJE<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class ACPIGAGGBPG
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct IODNOIILJPO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Allocator MBGJLDPPIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public NativeArray<T> GBHPBMLPNIH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct DFJHNOKFEBA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Allocator MBGJLDPPIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public NativeList<T> GBHPBMLPNIH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct IBHAFKBHLNB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Allocator MBGJLDPPIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public NativeArrayAsync<T> GBHPBMLPNIH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct AHJPFNPEFDN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Allocator MBGJLDPPIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public NativeListAsync<T> GBHPBMLPNIH;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class FMEIGKNNOPE
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class IOIJGPKFDGD
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x23EC030", Offset = "0x23EAE30", VA = "0x1823EC030")]
	public static NativeList<Entity> HJFJLMAHALD<T>(this NativeArray<Entity> GECODIGACIA, EntityManager GMDAKDJOHKE, Allocator MBGJLDPPIJN = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class AIIGPDJAPEC
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class DLKNLNHFOEI
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public readonly struct JFLLBHOBKOG<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly NativeArray<TSrc> OBEMKDLNKLE;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1C65C40", Offset = "0x1C64A40", VA = "0x181C65C40")]
		public JFLLBHOBKOG(NativeArray<TSrc> OBEMKDLNKLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0")]
		public PNJBDKFNOFH<TSrc, TValue> OLGFEMFOIMP<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(PNJBDKFNOFH<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public readonly struct PNJBDKFNOFH<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly NativeArray<TSrc> OBEMKDLNKLE;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1C65C40", Offset = "0x1C64A40", VA = "0x181C65C40")]
		public PNJBDKFNOFH(NativeArray<TSrc> OBEMKDLNKLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0")]
		public CEALMJMFFHJ<TSrc, TValue, TSelector> OGDCPFBPIHC<TSelector>() where TSelector : struct, GHLDNAHLONK<TSrc, TValue>
		{
			return default(CEALMJMFFHJ<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public readonly struct CEALMJMFFHJ<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, GHLDNAHLONK<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<TSrc> OBEMKDLNKLE;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1C65C40", Offset = "0x1C64A40", VA = "0x181C65C40")]
		public CEALMJMFFHJ(NativeArray<TSrc> OBEMKDLNKLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4781620", Offset = "0x4780420", VA = "0x184781620")]
		public NLBFCDLKIPL<TSrc, TValue, TSelector> IMBIONFONNE()
		{
			return default(NLBFCDLKIPL<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public struct HIGJPCFBHAD<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, GHLDNAHLONK<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly NativeArray<TSrc> OBEMKDLNKLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TSelector CFJOCOJCJCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int OCMJNDDMDAL;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public TValue CPKIHOLEKMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x35DD350", Offset = "0x35DC150", VA = "0x1835DD350")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int FCFMLMDMJIH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x8C0580", Offset = "0x8BF380", VA = "0x1808C0580")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int GFHGMKIJCDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x1C77C70", Offset = "0x1C76A70", VA = "0x181C77C70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x35DD3E0", Offset = "0x35DC1E0", VA = "0x1835DD3E0")]
		public HIGJPCFBHAD(NativeArray<TSrc> OBEMKDLNKLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x35DD260", Offset = "0x35DC060", VA = "0x1835DD260")]
		public bool ABDGKBAABMG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x35DD270", Offset = "0x35DC070", VA = "0x1835DD270")]
		private TSrc GJAOGCHDKPD(int NAKKFLBPDCC)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public struct NLBFCDLKIPL<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, GHLDNAHLONK<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private HIGJPCFBHAD<TSrc, TValue, TSelector> GHEOPKGDCOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TValue ICNKDMLDBKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int IJBCLDGENAJ;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IAIFOJGGPJK NEEIGJGKBIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x3BF2F70", Offset = "0x3BF1D70", VA = "0x183BF2F70")]
			get
			{
				return default(IAIFOJGGPJK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public TValue ANPIIIACHNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x7638A0", Offset = "0x7626A0", VA = "0x1807638A0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public (TValue value, IAIFOJGGPJK range) CPKIHOLEKMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x3BF2FB0", Offset = "0x3BF1DB0", VA = "0x183BF2FB0")]
			get
			{
				return default((TValue, IAIFOJGGPJK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3BF3090", Offset = "0x3BF1E90", VA = "0x183BF3090")]
		public NLBFCDLKIPL(NativeArray<TSrc> OBEMKDLNKLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3391890", Offset = "0x3390690", VA = "0x183391890")]
		public NLBFCDLKIPL<TSrc, TValue, TSelector> LMOHIMMBLMJ()
		{
			return default(NLBFCDLKIPL<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3BF2E30", Offset = "0x3BF1C30", VA = "0x183BF2E30")]
		public bool ABDGKBAABMG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x221EFC0", Offset = "0x221DDC0", VA = "0x18221EFC0")]
	public static JFLLBHOBKOG<T> LFNOAHAOGKG<T>(this NativeList<T> MJLHCFFNENL) where T : struct
	{
		return default(JFLLBHOBKOG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0")]
	public static JFLLBHOBKOG<T> LFNOAHAOGKG<T>(this NativeArray<T> OBEMKDLNKLE) where T : struct
	{
		return default(JFLLBHOBKOG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class HDANJAJMBEO
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public struct FCJNIMGKHCF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly NativeArray<T>.ReadOnly OBEMKDLNKLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int IJBCLDGENAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int ONLIPBLDFDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private T ICNKDMLDBKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private T LHFEOECNFKJ;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IAIFOJGGPJK NEEIGJGKBIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x3391700", Offset = "0x3390500", VA = "0x183391700")]
			get
			{
				return default(IAIFOJGGPJK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T ANPIIIACHNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x30A8FB0", Offset = "0x30A7DB0", VA = "0x1830A8FB0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public (T, IAIFOJGGPJK) CPKIHOLEKMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x3391710", Offset = "0x3390510", VA = "0x183391710")]
			get
			{
				return default((T, IAIFOJGGPJK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x33918F0", Offset = "0x33906F0", VA = "0x1833918F0")]
		public FCJNIMGKHCF(NativeArray<T> OBEMKDLNKLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x33918B0", Offset = "0x33906B0", VA = "0x1833918B0")]
		public FCJNIMGKHCF<T> LMOHIMMBLMJ()
		{
			return default(FCJNIMGKHCF<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3391520", Offset = "0x3390320", VA = "0x183391520")]
		public bool ABDGKBAABMG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2182DF0", Offset = "0x2181BF0", VA = "0x182182DF0")]
		public JCKLAGFOOND<T, TComparer> HLHGFJFABFG<TComparer>([Optional] TComparer IJJHJPJNMGH) where TComparer : struct, IEqualityComparer<T>
		{
			return default(JCKLAGFOOND<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public struct JCKLAGFOOND<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly NativeArray<T>.ReadOnly OBEMKDLNKLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int IJBCLDGENAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int ONLIPBLDFDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private T ICNKDMLDBKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private T LHFEOECNFKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private TComparer IJJHJPJNMGH;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public IAIFOJGGPJK NEEIGJGKBIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x3391700", Offset = "0x3390500", VA = "0x183391700")]
			get
			{
				return default(IAIFOJGGPJK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public T ANPIIIACHNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x30A8FB0", Offset = "0x30A7DB0", VA = "0x1830A8FB0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public (T value, IAIFOJGGPJK range) CPKIHOLEKMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x38343B0", Offset = "0x38331B0", VA = "0x1838343B0")]
			get
			{
				return default((T, IAIFOJGGPJK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x38344C0", Offset = "0x38332C0", VA = "0x1838344C0")]
		public JCKLAGFOOND(NativeArray<T>.ReadOnly OBEMKDLNKLE, TComparer IJJHJPJNMGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3834480", Offset = "0x3833280", VA = "0x183834480")]
		public JCKLAGFOOND<T, TComparer> LMOHIMMBLMJ()
		{
			return default(JCKLAGFOOND<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3834200", Offset = "0x3833000", VA = "0x183834200")]
		public bool ABDGKBAABMG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x23AF690", Offset = "0x23AE490", VA = "0x1823AF690")]
	public static FCJNIMGKHCF<T> IMBIONFONNE<T>(this NativeArray<T> OBEMKDLNKLE) where T : struct
	{
		return default(FCJNIMGKHCF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface INECBMGLKMC
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class KFANCHOGMHP
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct INJELCGHFKL<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class MEDHOPJGJIP : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public INJELCGHFKL<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x95F230", Offset = "0x95E030", VA = "0x18095F230", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x3053A10", Offset = "0x3052810", VA = "0x183053A10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x761980", Offset = "0x760780", VA = "0x180761980")]
		[DebuggerHidden]
		public MEDHOPJGJIP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3B5B8B0", Offset = "0x3B5A6B0", VA = "0x183B5B8B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3B5BA60", Offset = "0x3B5A860", VA = "0x183B5BA60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Action<Protobuf> PIBBOAEEKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream PLOOMBBCGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedInputStream GAOIGPDFJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Protobuf IBFMBEFLNAJ;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public readonly int GFHGMKIJCDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x806B40", Offset = "0x805940", VA = "0x180806B40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x36A7A20", Offset = "0x36A6820", VA = "0x1836A7A20")]
	private INJELCGHFKL(byte[] BLPPMOBNKNN, Action<Protobuf> PIBBOAEEKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x22A8D90", Offset = "0x22A7B90", VA = "0x1822A8D90")]
	public static INJELCGHFKL<Protobuf> FLMMCOJOBIA<Data>(ReadOnlySpan<byte> HGPPIPGOKCB, ReadOnlySpan<Data> KJFBOMAGMGG, Action<Protobuf> PIBBOAEEKCA)
	{
		return default(INJELCGHFKL<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x36A7890", Offset = "0x36A6690", VA = "0x1836A7890", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x36A78D0", Offset = "0x36A66D0", VA = "0x1836A78D0", Slot = "4")]
	[IteratorStateMachine(typeof(INJELCGHFKL<>.MEDHOPJGJIP))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x36A79C0", Offset = "0x36A67C0", VA = "0x1836A79C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct GECAEAINBIL<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] BLPPMOBNKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Protobuf IBFMBEFLNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly MemoryStream PLOOMBBCGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly CodedOutputStream KJMJGIKCDPP;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3482F50", Offset = "0x3481D50", VA = "0x183482F50")]
	private GECAEAINBIL(byte[] BLPPMOBNKNN, [In] Protobuf IBFMBEFLNAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x21853E0", Offset = "0x21841E0", VA = "0x1821853E0")]
	public static GECAEAINBIL<Protobuf> FLMMCOJOBIA<T>(ReadOnlySpan<T> KJFBOMAGMGG)
	{
		return default(GECAEAINBIL<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3482F20", Offset = "0x3481D20", VA = "0x183482F20")]
	public void PBAJMELDJPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3482E90", Offset = "0x3481C90", VA = "0x183482E90")]
	public ByteString JCPPJPIDNDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3482D60", Offset = "0x3481B60", VA = "0x183482D60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct MDJMFGBPJCB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly MemoryStream PLOOMBBCGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly CodedInputStream GAOIGPDFJAC;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E180", Offset = "0x5D4CF80", VA = "0x185D4E180", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct MODJBCAEBPJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly byte[] BLPPMOBNKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly MemoryStream PLOOMBBCGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly CodedOutputStream KJMJGIKCDPP;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E2E0", Offset = "0x5D4D0E0", VA = "0x185D4E2E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class KJIJADEDIKG
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public delegate void ONNIBMNKJHB<From, To>(From ECAFGEFAJGI, To HPMEJLCHJFA, KGPPHNCOAFD DPJAFHOCHKL);

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class AIKDKKGJGEP<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static ONNIBMNKJHB<From, To> MKNFOJJJHNE;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public AIKDKKGJGEP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5D4DB70", Offset = "0x5D4C970", VA = "0x185D4DB70")]
	static KJIJADEDIKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x242ABD0", Offset = "0x24299D0", VA = "0x18242ABD0")]
	public static void EGCKGANBHEF<T>(ONNIBMNKJHB<T, T> IPIEGCEOKKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x242B490", Offset = "0x242A290", VA = "0x18242B490")]
	public static void EGCKGANBHEF<From, To>(ONNIBMNKJHB<From, To> IPIEGCEOKKJ, ONNIBMNKJHB<To, From> HGHEPHPHGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x242A8E0", Offset = "0x24296E0", VA = "0x18242A8E0")]
	public static void EGCKGANBHEF<From, To>(ONNIBMNKJHB<From, To> MKNFOJJJHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x242E9E0", Offset = "0x242D7E0", VA = "0x18242E9E0")]
	public static ONNIBMNKJHB<From, To> IDIFGDLPMIK<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x24281F0", Offset = "0x2426FF0", VA = "0x1824281F0")]
	public static void BOBJGBBPJMA<From, To>(From ECAFGEFAJGI, To HPMEJLCHJFA, KGPPHNCOAFD DPJAFHOCHKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class KGPPHNCOAFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> LJGJHNIEIHN;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x1C3DCF0", Offset = "0x1C3CAF0", VA = "0x181C3DCF0")]
	public KGPPHNCOAFD(NativeArray<EntityRemapUtility.EntityRemapInfo> LJGJHNIEIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5D4D740", Offset = "0x5D4C540", VA = "0x185D4D740")]
	public Entity KMKIOKEIGAM(Entity PGGBKFCMLMO)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class LKIHLCPGOII
{
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5D4DFD0", Offset = "0x5D4CDD0", VA = "0x185D4DFD0")]
	public static ulong PLFDGPIBKIP(Type FLHOFPAHPKL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5D4E060", Offset = "0x5D4CE60", VA = "0x185D4E060")]
	public static ulong PLFDGPIBKIP(string MNNCPMDJOCA)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[Flags]
public enum JDCCDMKNOIF
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
public class PBAOBINEJJG : ANIFJPLLIHB
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x76E100", Offset = "0x76CF00", VA = "0x18076E100")]
	public PBAOBINEJJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal static class APAKMGAKCED
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5D4CA10", Offset = "0x5D4B810", VA = "0x185D4CA10")]
	private unsafe static Span<byte> PNNKAONEIEO(Unity.Entities.Chunk* PKPEFKLAONK, int FDIKGJDICEP)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x29C62D0", Offset = "0x29C50D0", VA = "0x1829C62D0")]
	public unsafe static Span<T> NCCJAACCPFK<T>(Unity.Entities.Chunk* PKPEFKLAONK, int FDIKGJDICEP)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x21E7D20", Offset = "0x21E6B20", VA = "0x1821E7D20")]
	public static Span<T> NCCJAACCPFK<T>(this Unity.Entities.Chunk PKPEFKLAONK, int FDIKGJDICEP)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5D4C9B0", Offset = "0x5D4B7B0", VA = "0x185D4C9B0")]
	public unsafe static Span<Entity> PCPJFJKCKMI(Unity.Entities.Chunk* PKPEFKLAONK)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5D4C840", Offset = "0x5D4B640", VA = "0x185D4C840")]
	public unsafe static void LHLJEDFLAKN(Unity.Entities.Chunk* PKPEFKLAONK, int FDIKGJDICEP)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class LCOCJIOOHJG
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public LCOCJIOOHJG()
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
