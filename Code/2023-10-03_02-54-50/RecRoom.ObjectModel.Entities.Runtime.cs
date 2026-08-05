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
		[Cpp2IlInjected.Address(RVA = "0x78B4D0", Offset = "0x789CD0", VA = "0x18078B4D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x78B4D0", Offset = "0x789CD0", VA = "0x18078B4D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D6B0C0", Offset = "0x5D698C0", VA = "0x185D6B0C0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class HMNLOMANJNK<TComponentData> where TComponentData : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FieldInfo[] OFCAHACDEKN;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2BFB1C0", Offset = "0x2BF99C0", VA = "0x182BFB1C0")]
	public static void KMAEGFIFCLA<TField>(int ADMJKDLHPCI, string BOBHOMKFHJB, BEMIKKNENEH OJFJEIOMBDK, [Out] DDMJLFGLNGL<TField> OLJMCOBAMDO) where TField : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2BFB100", Offset = "0x2BF9900", VA = "0x182BFB100")]
	public static void BAOKPBHBBFI<TField>(int ADMJKDLHPCI, string BOBHOMKFHJB, [Out] GOOBEKCPDHA<TField> JHFJPGOBMLL) where TField : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal static class BGHAAHIBFFP
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5D6AB60", Offset = "0x5D69360", VA = "0x185D6AB60")]
	public static FieldInfo[] JBNIDAAFICM(Type BJKOKHNAAID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class IKGCBKNCPCC<View, Data> : NGLBPOGABCB where View : struct, IComponent where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static ComponentType HNBFDMMNEIL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type NBFEDOIMECL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3669020", Offset = "0x3667820", VA = "0x183669020", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override int EHGHPMJPGOK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3668100", Offset = "0x3666900", VA = "0x183668100", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x366A070", Offset = "0x3668870", VA = "0x18366A070")]
	public Data KDJEAABNLGE(Entity MFFDEAINOPL)
	{
		return (Data)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected internal abstract View KENOOPILGCD(Entity MFFDEAINOPL);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2BFB500", Offset = "0x2BF9D00", VA = "0x182BFB500", Slot = "14")]
	public override T KENOOPILGCD<T>(Entity MFFDEAINOPL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x78B4D0", Offset = "0x789CD0", VA = "0x18078B4D0")]
	protected IKGCBKNCPCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class NGLBPOGABCB : BEMIKKNENEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DynamicComponentTypeHandle OCGIMADNLAH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EntityManager NHMANGHHOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x115C840", Offset = "0x115B040", VA = "0x18115C840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract Type NBFEDOIMECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int EHGHPMJPGOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Type NCCBNHEFLAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8B5500", Offset = "0x8B3D00", VA = "0x1808B5500", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int DKILHKKEMBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5D6C2F0", Offset = "0x5D6AAF0", VA = "0x185D6C2F0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private ACMAOFLJBJE[] EIJEDPHFDID
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3C8C3A0", Offset = "0x3C8ABA0", VA = "0x183C8C3A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	protected internal virtual ACMAOFLJBJE[] ALPOIMOAEHM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5D6C260", Offset = "0x5D6AA60", VA = "0x185D6C260", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5D6C450", Offset = "0x5D6AC50", VA = "0x185D6C450")]
	public void MJKJMKCCJMD(EntityManager DHDOKMIFNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public abstract T KENOOPILGCD<T>(Entity MFFDEAINOPL) where T : struct, IComponent;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5D6C590", Offset = "0x5D6AD90", VA = "0x185D6C590", Slot = "8")]
	public (uint, uint) PKKKKLICPFG(Entity MFFDEAINOPL)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5D6C360", Offset = "0x5D6AB60", VA = "0x185D6C360", Slot = "9")]
	public bool LJFAOGEEFGJ(Entity MFFDEAINOPL, (uint order, uint change) OJAHFIICKFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	protected NGLBPOGABCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LAOCAFBDDMI
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface AGEJPMDBIMB : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	AOCFLIIJOIB CJHFLCNLACK
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
public interface FHCJIGIFBJK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KEMEMNDDCPD(Entity MFFDEAINOPL, object PIPCHJCEPPJ);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LAPOLMKDJGK(Entity MFFDEAINOPL, object PIPCHJCEPPJ);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FAHMMLLCJID(Entity MFFDEAINOPL);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BPGFMNHENEA(Entity MFFDEAINOPL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class IIHIDPNJCHF<TComponentData, TValue> : EMBGDJPJLFI<TValue>, IDisposable where TComponentData : struct, AGEJPMDBIMB
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class AIJLELNHNCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private List<(object token, TValue value)> KAEOEAACCCG;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int EAAIJEAHMOH
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x2E90CF0", Offset = "0x2E8F4F0", VA = "0x182E90CF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x35A6C70", Offset = "0x35A5470", VA = "0x1835A6C70")]
		public bool GANPNNDNKEL([Out] TValue IFKKLLBODIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x35A6BC0", Offset = "0x35A53C0", VA = "0x1835A6BC0")]
		public void EIGFNHEIDIC(object PIPCHJCEPPJ, TValue IFKKLLBODIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x35A6D60", Offset = "0x35A5560", VA = "0x1835A6D60")]
		public bool OICBJJIPNIH(object PIPCHJCEPPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x35A6AE0", Offset = "0x35A52E0", VA = "0x1835A6AE0")]
		public int CDKCGFEGDAN(object PIPCHJCEPPJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x35A6DE0", Offset = "0x35A55E0", VA = "0x1835A6DE0")]
		public AIJLELNHNCD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Stack<AIJLELNHNCD> ENAMAEMJPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private DNHFEFFOCGA<AOCFLIIJOIB, AIJLELNHNCD> GMJOJEEPPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EntityManager DHDOKMIFNAD;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3664B40", Offset = "0x3663340", VA = "0x183664B40")]
	public IIHIDPNJCHF(EntityManager DHDOKMIFNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3664750", Offset = "0x3662F50", VA = "0x183664750", Slot = "4")]
	public void KEMEMNDDCPD(Entity MFFDEAINOPL, object PIPCHJCEPPJ, TValue IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x36648B0", Offset = "0x36630B0", VA = "0x1836648B0", Slot = "5")]
	public bool LAPOLMKDJGK(Entity MFFDEAINOPL, object PIPCHJCEPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3664650", Offset = "0x3662E50", VA = "0x183664650", Slot = "6")]
	public bool GANPNNDNKEL(Entity MFFDEAINOPL, [Out] TValue IFKKLLBODIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3664630", Offset = "0x3662E30", VA = "0x183664630", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x36644E0", Offset = "0x3662CE0", VA = "0x1836644E0")]
	private void DCECANIBLLC(AIJLELNHNCD MDMCJMMIAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3664570", Offset = "0x3662D70", VA = "0x183664570")]
	private bool DDNADEGEDNL(Entity MFFDEAINOPL, [Out] AOCFLIIJOIB FJFHMLGEMLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3664A50", Offset = "0x3663250", VA = "0x183664A50")]
	private void NOJKHJLEJDE(Entity MFFDEAINOPL, AOCFLIIJOIB FJFHMLGEMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3664890", Offset = "0x3663090", VA = "0x183664890")]
	private bool KIJNCNGDHLC(AOCFLIIJOIB FJFHMLGEMLM, [Out] AIJLELNHNCD MDMCJMMIAML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x36643F0", Offset = "0x3662BF0", VA = "0x1836643F0")]
	private AIJLELNHNCD BLIAPABCFIM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EMBGDJPJLFI<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KEMEMNDDCPD(Entity MFFDEAINOPL, object PIPCHJCEPPJ, TValue IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LAPOLMKDJGK(Entity MFFDEAINOPL, object PIPCHJCEPPJ);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GANPNNDNKEL(Entity MFFDEAINOPL, [Out] TValue IFKKLLBODIE);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct AOCFLIIJOIB : GDENHPGEPFJ, IEquatable<AOCFLIIJOIB>
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly AOCFLIIJOIB GCBDJIKNIJL;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[CreateProperty]
	public int DIEGBKIOLGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x98EA60", Offset = "0x98D260", VA = "0x18098EA60", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7ECFB0", Offset = "0x7EB7B0", VA = "0x1807ECFB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[CreateProperty]
	public int PEONAEBENMC
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1FBDFF0", Offset = "0x1FBC7F0", VA = "0x181FBDFF0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x51E9800", Offset = "0x51E8000", VA = "0x1851E9800", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5D6AAC0", Offset = "0x5D692C0", VA = "0x185D6AAC0", Slot = "8")]
	public bool Equals(AOCFLIIJOIB GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5D6AB10", Offset = "0x5D69310", VA = "0x185D6AB10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class OINIEIKILEF<THasTokensTag> : FHCJIGIFBJK, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Dictionary<Entity, AOCFLIIJOIB> LJBJMJOPDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly Stack<HashSet<object>> ENAMAEMJPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private DNHFEFFOCGA<AOCFLIIJOIB, HashSet<object>> GMJOJEEPPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private EntityManager DHDOKMIFNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private EntityCommandBufferSystem EMPKENPAECO;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3DBDA70", Offset = "0x3DBC270", VA = "0x183DBDA70")]
	public OINIEIKILEF(EntityManager DHDOKMIFNAD, EntityCommandBufferSystem EMPKENPAECO, PFECAMNMOCE HINJGPFMKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3DBC5A0", Offset = "0x3DBADA0", VA = "0x183DBC5A0", Slot = "4")]
	public bool KEMEMNDDCPD(Entity MFFDEAINOPL, object PIPCHJCEPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3DBCFB0", Offset = "0x3DBB7B0", VA = "0x183DBCFB0", Slot = "5")]
	public bool LAPOLMKDJGK(Entity MFFDEAINOPL, object PIPCHJCEPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3DBBC40", Offset = "0x3DBA440", VA = "0x183DBBC40", Slot = "6")]
	public bool FAHMMLLCJID(Entity MFFDEAINOPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3DBBF90", Offset = "0x3DBA790", VA = "0x183DBBF90", Slot = "9")]
	public bool FAHMMLLCJID(AOCFLIIJOIB FJFHMLGEMLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3DBAA70", Offset = "0x3DB9270", VA = "0x183DBAA70", Slot = "7")]
	public bool BPGFMNHENEA(Entity MFFDEAINOPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3DBBB80", Offset = "0x3DBA380", VA = "0x183DBBB80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3DBB610", Offset = "0x3DB9E10", VA = "0x183DBB610")]
	private void DCECANIBLLC(HashSet<object> MDMCJMMIAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3DBBA30", Offset = "0x3DBA230", VA = "0x183DBBA30")]
	private bool DDNADEGEDNL(Entity MFFDEAINOPL, [Out] AOCFLIIJOIB FJFHMLGEMLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3DBD4D0", Offset = "0x3DBBCD0", VA = "0x183DBD4D0")]
	private bool OINJDBJGLGG(Entity MFFDEAINOPL, [Out] AOCFLIIJOIB FJFHMLGEMLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3DBA640", Offset = "0x3DB8E40", VA = "0x183DBA640")]
	private void BCBGICOHOGB(Entity MFFDEAINOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3DBB080", Offset = "0x3DB9880", VA = "0x183DBB080")]
	private void CJCKOOEEJJC(Entity MFFDEAINOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3DBC240", Offset = "0x3DBAA40", VA = "0x183DBC240")]
	private void GHDCKJDJMMG(Entity MFFDEAINOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3DBD120", Offset = "0x3DBB920", VA = "0x183DBD120")]
	private void NOJKHJLEJDE(Entity MFFDEAINOPL, AOCFLIIJOIB FJFHMLGEMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3DBD890", Offset = "0x3DBC090", VA = "0x183DBD890")]
	private bool OPOIJMNIHEJ(AOCFLIIJOIB FJFHMLGEMLM, [Out] HashSet<object> MDMCJMMIAML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3DBA890", Offset = "0x3DB9090", VA = "0x183DBA890")]
	private HashSet<object> BLIAPABCFIM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class ECMJDOPDIKO
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct KIJOINBMBOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int INDDJJFOAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int JEDNJDDHFHB;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int LOILIENPDCM
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x98EA60", Offset = "0x98D260", VA = "0x18098EA60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1FBDFF0", Offset = "0x1FBC7F0", VA = "0x181FBDFF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x51E9800", Offset = "0x51E8000", VA = "0x1851E9800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int OGKJOKOGBBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x98EA60", Offset = "0x98D260", VA = "0x18098EA60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7ECFB0", Offset = "0x7EB7B0", VA = "0x1807ECFB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int EOKLOOHPCNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5D6BB90", Offset = "0x5D6A390", VA = "0x185D6BB90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5D6BBA0", Offset = "0x5D6A3A0", VA = "0x185D6BBA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x978550", Offset = "0x976D50", VA = "0x180978550")]
	private KIJOINBMBOF(int INDDJJFOAAH, int JEDNJDDHFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1C45850", Offset = "0x1C44050", VA = "0x181C45850")]
	public static KIJOINBMBOF GGKDMAJHNEP(int INDDJJFOAAH, int JEDNJDDHFHB)
	{
		return default(KIJOINBMBOF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5D6BBB0", Offset = "0x5D6A3B0", VA = "0x185D6BBB0")]
	public static KIJOINBMBOF JGLFOGFGMGE(int IAIBEBECMJB, int BMNCKBBLELB)
	{
		return default(KIJOINBMBOF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5D6BBC0", Offset = "0x5D6A3C0", VA = "0x185D6BBC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct JFOMLDLAJOA : HBKLCMOMIFB<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5D51210", Offset = "0x5D4FA10", VA = "0x185D51210")]
	public float FKHKJNCPLEN([In] float3 IFKKLLBODIE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5D51210", Offset = "0x5D4FA10", VA = "0x185D51210", Slot = "4")]
	private float DBEONBBFABD([In] float3 IFKKLLBODIE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct PMKLECGLMBE : HBKLCMOMIFB<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5D4EFF0", Offset = "0x5D4D7F0", VA = "0x185D4EFF0")]
	public float FKHKJNCPLEN([In] float3 IFKKLLBODIE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5D4EFF0", Offset = "0x5D4D7F0", VA = "0x185D4EFF0", Slot = "4")]
	private float DBEONBBFABD([In] float3 IFKKLLBODIE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct HOFGHNJPPMC : HBKLCMOMIFB<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x18A1C10", Offset = "0x18A0410", VA = "0x1818A1C10")]
	public float FKHKJNCPLEN([In] float3 IFKKLLBODIE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x18A1C10", Offset = "0x18A0410", VA = "0x1818A1C10", Slot = "4")]
	private float DBEONBBFABD([In] float3 IFKKLLBODIE)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct FKHKJDJLGIA : HBKLCMOMIFB<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x11FE650", Offset = "0x11FCE50", VA = "0x1811FE650")]
	public int FKHKJNCPLEN([In] int3 IFKKLLBODIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x11FE650", Offset = "0x11FCE50", VA = "0x1811FE650", Slot = "4")]
	private int BDFGAMEPLOJ([In] int3 IFKKLLBODIE)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct CAKDOKJHBKD : HBKLCMOMIFB<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5D54AF0", Offset = "0x5D532F0", VA = "0x185D54AF0")]
	public int FKHKJNCPLEN([In] int3 IFKKLLBODIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5D54AF0", Offset = "0x5D532F0", VA = "0x185D54AF0", Slot = "4")]
	private int BDFGAMEPLOJ([In] int3 IFKKLLBODIE)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct KGFIJDOKDHM : HBKLCMOMIFB<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x14AFA60", Offset = "0x14AE260", VA = "0x1814AFA60")]
	public int FKHKJNCPLEN([In] int3 IFKKLLBODIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x14AFA60", Offset = "0x14AE260", VA = "0x1814AFA60", Slot = "4")]
	private int BDFGAMEPLOJ([In] int3 IFKKLLBODIE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class CKCEHLDMEFM : KPKFEINJGIH
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public Type JLIIPHFJMHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Type NHKEDJMMDAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5D6AD30", Offset = "0x5D69530", VA = "0x185D6AD30")]
	public CKCEHLDMEFM(Type NCFNHNCDEMN, Type KHCHFAIAJKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class NJDDBDEFGHJ : KPKFEINJGIH
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Type NHKEDJMMDAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5C8B240", Offset = "0x5C89A40", VA = "0x185C8B240")]
	public NJDDBDEFGHJ(Type KHCHFAIAJKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class AOHPACHDGHC : KPKFEINJGIH
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x771100", Offset = "0x76F900", VA = "0x180771100")]
	public AOHPACHDGHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class MOCCJAOBKLK<Data> : EEIEPFPEPFC where Data : struct, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public virtual Data LMLHJGLFPJN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7B27F0", Offset = "0x7B0FF0", VA = "0x1807B27F0", Slot = "7")]
		get
		{
			return (Data)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3BEDB80", Offset = "0x3BEC380", VA = "0x183BEDB80", Slot = "8")]
	protected virtual bool BPCMDPCPAMD(ReadOnlySpan<Data> KBLIOPDOHJK, NMKCGFFAGNA MDDDOHLBGMH, [Out] ReadOnlySpan<byte> BGGDIKOMABC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "9")]
	protected virtual bool NKHIEONAJFJ(int OJAHFIICKFC, Span<Data> KBLIOPDOHJK, [In] ReadOnlySpan<byte> BGGDIKOMABC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3BEDB90", Offset = "0x3BEC390", VA = "0x183BEDB90", Slot = "5")]
	internal sealed override bool BPCMDPCPAMD(Unity.Entities.Chunk KIJHCPOKLEK, int PFKAOAAPHBK, NMKCGFFAGNA MDDDOHLBGMH, [Out] ReadOnlySpan<byte> BGGDIKOMABC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x3BEF520", Offset = "0x3BEDD20", VA = "0x183BEF520", Slot = "6")]
	internal sealed override bool NKHIEONAJFJ(int OJAHFIICKFC, Unity.Entities.Chunk KIJHCPOKLEK, int PFKAOAAPHBK, [In] ReadOnlySpan<byte> BGGDIKOMABC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x216F910", Offset = "0x216E110", VA = "0x18216F910")]
	protected KIKDIPEFJFN<Protobuf> ODIFFNALIAI<Protobuf>(ReadOnlySpan<Data> KBLIOPDOHJK) where Protobuf : IMessage, new()
	{
		return default(KIKDIPEFJFN<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x216F890", Offset = "0x216E090", VA = "0x18216F890")]
	protected FNDPFPGLIEH<Protobuf> HIHNNONOBBL<Protobuf>(ReadOnlySpan<byte> BGGDIKOMABC, ReadOnlySpan<Data> KBLIOPDOHJK, Action<Protobuf> CFBOOMLKCNJ) where Protobuf : IMessage, new()
	{
		return default(FNDPFPGLIEH<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x78B4D0", Offset = "0x789CD0", VA = "0x18078B4D0")]
	protected MOCCJAOBKLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class EEIEPFPEPFC
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	protected abstract int PEONAEBENMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B0B0", Offset = "0x5D698B0", VA = "0x185D6B0B0", Slot = "5")]
	internal virtual bool BPCMDPCPAMD(Unity.Entities.Chunk KIJHCPOKLEK, int PFKAOAAPHBK, NMKCGFFAGNA MDDDOHLBGMH, [Out] ReadOnlySpan<byte> BGGDIKOMABC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "6")]
	internal virtual bool NKHIEONAJFJ(int OJAHFIICKFC, Unity.Entities.Chunk KIJHCPOKLEK, int PFKAOAAPHBK, [In] ReadOnlySpan<byte> BGGDIKOMABC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	protected EEIEPFPEPFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface EJPKHDKBGHD
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class JMMMDIBDAGF : SystemBase, EJPKHDKBGHD
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B7A0", Offset = "0x5D69FA0", VA = "0x185D6B7A0")]
	public ComponentDataFromEntity ADGMGCJLCJC(int GIBOEKFJFBH, bool IDKHBHOLPCG = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B860", Offset = "0x5D6A060", VA = "0x185D6B860")]
	public EntityExistenceLookupByEntity DBELOBCEGGI()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B880", Offset = "0x5D6A080", VA = "0x185D6B880", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x771100", Offset = "0x76F900", VA = "0x180771100")]
	protected JMMMDIBDAGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public abstract class LDPLANFOAAB : JMMMDIBDAGF
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5D6BD40", Offset = "0x5D6A540", VA = "0x185D6BD40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x771100", Offset = "0x76F900", VA = "0x180771100")]
	protected LDPLANFOAAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class OJLFCFAHMCD
{
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public abstract class MGKMOGBIDJL : MNKKMIDHEPO
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5D6BE60", Offset = "0x5D6A660", VA = "0x185D6BE60", Slot = "5")]
	protected sealed override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	protected abstract ComponentSystemBase AEELHFJDNIO();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5D6BE10", Offset = "0x5D6A610", VA = "0x185D6BE10")]
	protected ComponentSystemBase IFNCDHDMIIG(params ComponentSystemBase[] BKIDEJBLOMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x246F070", Offset = "0x246D870", VA = "0x18246F070")]
	protected ComponentSystemBase IFNCDHDMIIG<T>(params ComponentSystemBase[] BKIDEJBLOMH) where T : MNKKMIDHEPO, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x246F030", Offset = "0x246D830", VA = "0x18246F030")]
	protected ComponentSystemBase CLBGAEIHOBL<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x246F030", Offset = "0x246D830", VA = "0x18246F030")]
	protected ComponentSystemBase HEBJGGFDDFL<T>() where T : ComponentSystemBase, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5D6BDC0", Offset = "0x5D6A5C0", VA = "0x185D6BDC0")]
	protected ComponentSystemBase CJFAAHFGBEE(params SystemHandleUntyped[] BKIDEJBLOMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x246EFA0", Offset = "0x246D7A0", VA = "0x18246EFA0")]
	protected ComponentSystemBase CJFAAHFGBEE<T>(params SystemHandleUntyped[] BKIDEJBLOMH) where T : MNKKMIDHEPO, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x246F100", Offset = "0x246D900", VA = "0x18246F100")]
	protected SystemHandleUntyped OHJIJJKIFHB<T>() where T : struct, ISystem
	{
		return default(SystemHandleUntyped);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5D6BD70", Offset = "0x5D6A570", VA = "0x185D6BD70")]
	protected MGKMOGBIDJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class MNKKMIDHEPO : LGOMPDENBAF
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5D6BEB0", Offset = "0x5D6A6B0", VA = "0x185D6BEB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5D6BD70", Offset = "0x5D6A570", VA = "0x185D6BD70")]
	public MNKKMIDHEPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class LGOMPDENBAF : ComponentSystemGroup, EJPKHDKBGHD
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5D6BD70", Offset = "0x5D6A570", VA = "0x185D6BD70")]
	protected LGOMPDENBAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public abstract class BLKAEPMAHDD : EntityCommandBufferSystem, EJPKHDKBGHD
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x771100", Offset = "0x76F900", VA = "0x180771100")]
	protected BLKAEPMAHDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface HBKLCMOMIFB<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo FKHKJNCPLEN([In] TFrom IFKKLLBODIE);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface GJHKKGKBNAO<T>
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HJPENCIBILD(T IFKKLLBODIE);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct LDELBEKPIJA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<Entity> EFLDIIILPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public EntityCommandBuffer KGGEMAPLOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public ComponentTypes APDLHEGDKMF;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5D6BC50", Offset = "0x5D6A450", VA = "0x185D6BC50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct JINPBIBHIOA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<Entity> EFLDIIILPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public EntityCommandBuffer KGGEMAPLOML;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B700", Offset = "0x5D69F00", VA = "0x185D6B700", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct KDINJFACJKA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<Entity> EFLDIIILPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer KGGEMAPLOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public ComponentType ANDCEPJBFFM;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B9D0", Offset = "0x5D6A1D0", VA = "0x185D6B9D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct FBCOJGILGHG<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public NativeArray<Entity> EFLDIIILPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[ReadOnly]
	public NativeArray<T> KOIMDAJNDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public EntityCommandBuffer KGGEMAPLOML;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3371D60", Offset = "0x3370560", VA = "0x183371D60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal struct LOBEGEAPNFE<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> EFLDIIILPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public NativeArray<T> EMKFAOJKFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public EntityCommandBuffer KGGEMAPLOML;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal struct POGBKNHEMDL<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> EFLDIIILPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public T IFKKLLBODIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public EntityCommandBuffer KGGEMAPLOML;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3E964C0", Offset = "0x3E94CC0", VA = "0x183E964C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
internal struct OGOLDMIAECA<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, HBKLCMOMIFB<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> OFCNNPIDOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<TTo> FKCGCFGJEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap POMIBLHGGHJ;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[BurstCompile]
internal struct KDIKOBMOPEJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity PBEPIMANOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> OFCNNPIDOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[WriteOnly]
	public NativeArray<byte> FKCGCFGJEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public int MPIMAFLNDEE;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B8D0", Offset = "0x5D6A0D0", VA = "0x185D6B8D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
internal struct MOJAMPDOEEF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public ComponentDataFromEntity<T> IELOPCOACDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<Entity> OFCNNPIDOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[WriteOnly]
	public NativeList<T> GHPEMKOLBCN;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[BurstCompile]
internal struct DCGIKENPNPF<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, HBKLCMOMIFB<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<TFrom> PNOILAHJBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[WriteOnly]
	public NativeList<TTo> FKCGCFGJEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public TMap POMIBLHGGHJ;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[BurstCompile]
internal struct GGEHMJOLOAB<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	public ComponentDataFromEntity<T> KHCHFAIAJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	public NativeArray<Entity> CHHLCPHPEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public NativeArray<bool> GOFCNOMKBOF;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[BurstCompile]
internal struct EGHJPPOOOCN<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> KHCHFAIAJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> CHHLCPHPEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeArray<bool> GOFCNOMKBOF;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2FF5DB0", Offset = "0x2FF45B0", VA = "0x182FF5DB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[BurstCompile]
internal struct APKAANLFDGL<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> OFCNNPIDOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public NativeList<T> GHPEMKOLBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeParallelHashSet<T> GAAKFFCHNLB;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x38AA520", Offset = "0x38A8D20", VA = "0x1838AA520", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[BurstCompile]
internal struct ONCKFNPBNHP<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : HBKLCMOMIFB<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public NativeArray<TFrom> OFCNNPIDOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public NativeList<TFrom> GHPEMKOLBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeParallelHashSet<TTo> GAAKFFCHNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TMap POMIBLHGGHJ;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[BurstCompile]
internal struct GPMNKNJCDPJ<T, TPredicate> : IJob where T : struct where TPredicate : struct, GJHKKGKBNAO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<T> OFCNNPIDOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> PGBAHNFKJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> MIHBECKDLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public TPredicate POMIBLHGGHJ;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x34E1AA0", Offset = "0x34E02A0", VA = "0x1834E1AA0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[BurstCompile]
internal struct NIKOLCMELAP<T, TPredicate> : IJob where T : struct where TPredicate : struct, GJHKKGKBNAO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<T> OFCNNPIDOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<T> GHPEMKOLBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public TPredicate POMIBLHGGHJ;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[BurstCompile]
internal struct FEFGPDKHMIG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	public ComponentDataFromEntity KHCHFAIAJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	public NativeArray<Entity> CHHLCPHPEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeList<Entity> FHCPJHIKJIE;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B0E0", Offset = "0x5D698E0", VA = "0x185D6B0E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[BurstCompile]
internal struct DAJHNPLNBPH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	public ComponentDataFromEntity KHCHFAIAJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	public NativeArray<Entity> CHHLCPHPEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeList<Entity> FHCPJHIKJIE;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B020", Offset = "0x5D69820", VA = "0x185D6B020", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class MKKGDJOKJIJ
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class OBDGPNGOKMF
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x24EF540", Offset = "0x24EDD40", VA = "0x1824EF540")]
	public static bool MNNPDCKGIJE<T>(this NativeArray<Entity> CHHLCPHPEKC, EntityManager DHDOKMIFNAD, Allocator OPPHPFNHPMG = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class BKBDIJBJHID
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class BHKBNODLKFK<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		public BHKBNODLKFK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class FDAJJCHJLIF<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		public FDAJJCHJLIF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly List<Func<JobHandle, JobHandle>> AJBGAICAEIB;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5D6ACA0", Offset = "0x5D694A0", VA = "0x185D6ACA0")]
	public BKBDIJBJHID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class EBLBKGGIECA
{
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class JPMNECOCNEA
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct BGKCFEAOBKJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public struct PIACMNFFHJF<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			internal BGKCFEAOBKJ<TFrom> KLGMOMIJPLM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal Allocator OPPHPFNHPMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		internal NativeArray<TFrom> PMFLLGPMIME;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct PAOOAGAFHKN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public struct HDPAKNAEHCA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			internal PAOOAGAFHKN<TFrom> KLGMOMIJPLM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal Allocator OPPHPFNHPMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		internal NativeList<TFrom> PMFLLGPMIME;
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct CNPPEPNLLOK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public struct JNBNLDOAACN<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			internal CNPPEPNLLOK<TFrom> KLGMOMIJPLM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		internal Allocator OPPHPFNHPMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		internal NativeArrayAsync<TFrom> PMFLLGPMIME;
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public struct JNOKONMKAFF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public struct AFIPBIGMCNG<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			internal JNOKONMKAFF<TFrom> KLGMOMIJPLM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		internal Allocator OPPHPFNHPMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal NativeListAsync<TFrom> PMFLLGPMIME;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class AKNHKOKLPNF
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class MFLKIHALKOI
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x246E4A0", Offset = "0x246CCA0", VA = "0x18246E4A0")]
	public static NativeList<T> GNFOJNBEGHN<T>(this NativeList<T> DJBDOMLABOE, Allocator OPPHPFNHPMG = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x246E520", Offset = "0x246CD20", VA = "0x18246E520")]
	public static NativeList<T> GNFOJNBEGHN<T>(this NativeArray<T> DJBDOMLABOE, Allocator OPPHPFNHPMG = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class IPMGCIMAFDO
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class JFKMDKGBLNF
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x24233C0", Offset = "0x2421BC0", VA = "0x1824233C0")]
	[IEIEKNOJBIB]
	public static JobHandle PPMJEBAMKIC<T>(this EntityCommandBufferSystem EMPKENPAECO, NativeArrayAsync<Entity> EFLDIIILPLM, NativeArrayAsync<T> KOIMDAJNDOD, [Optional] JobHandle AGGDNOGFFOD) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2423320", Offset = "0x2421B20", VA = "0x182423320")]
	[IEIEKNOJBIB]
	public static JobHandle PPMJEBAMKIC<T>(this EntityCommandBufferSystem EMPKENPAECO, NativeArrayAsync<Entity> EFLDIIILPLM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2423200", Offset = "0x2421A00", VA = "0x182423200")]
	[IEIEKNOJBIB]
	public static JobHandle PPMJEBAMKIC<T>(this EntityCommandBufferSystem EMPKENPAECO, NativeArray<Entity> EFLDIIILPLM, [Optional] JobHandle AGGDNOGFFOD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B440", Offset = "0x5D69C40", VA = "0x185D6B440")]
	[IEIEKNOJBIB]
	public static JobHandle PPMJEBAMKIC(this EntityCommandBufferSystem EMPKENPAECO, NativeArray<Entity> EFLDIIILPLM, ComponentTypes APDLHEGDKMF, [Optional] JobHandle AGGDNOGFFOD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B5B0", Offset = "0x5D69DB0", VA = "0x185D6B5B0")]
	[IEIEKNOJBIB]
	public static JobHandle PPMJEBAMKIC(this EntityCommandBufferSystem EMPKENPAECO, EntityCommandBuffer KGGEMAPLOML, NativeArray<Entity> EFLDIIILPLM, ComponentTypes APDLHEGDKMF, [Optional] JobHandle AGGDNOGFFOD)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class GNJKAAKBJIP
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2385AD0", Offset = "0x23842D0", VA = "0x182385AD0")]
	[IEIEKNOJBIB]
	public static JobHandle KHECLOLLHJE<T>(this EntityCommandBufferSystem EMPKENPAECO, EntityCommandBuffer KGGEMAPLOML, EntityQuery PMIADPKJDNK, T IFKKLLBODIE) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class NDCEEBPBJJG
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5D6C0D0", Offset = "0x5D6A8D0", VA = "0x185D6C0D0")]
	[IEIEKNOJBIB]
	public static JobHandle EHAABHEGOCC(this EntityCommandBufferSystem EMPKENPAECO, NativeList<Entity> EFLDIIILPLM, [Optional] JobHandle AGGDNOGFFOD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5D6BFD0", Offset = "0x5D6A7D0", VA = "0x185D6BFD0")]
	[IEIEKNOJBIB]
	public static JobHandle EHAABHEGOCC(this EntityCommandBufferSystem EMPKENPAECO, NativeArrayAsync<Entity> EFLDIIILPLM)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class HBONAKCBIIO
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x23A1F40", Offset = "0x23A0740", VA = "0x1823A1F40")]
	public static void KCBPPDAOFKA<T>(this EntityCommandBufferSystem EMPKENPAECO, EntityQuery PMIADPKJDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x23A26F0", Offset = "0x23A0EF0", VA = "0x1823A26F0")]
	[IEIEKNOJBIB]
	public static JobHandle MFGFNINPEGA<T>(this EntityCommandBufferSystem EMPKENPAECO, NativeListAsync<Entity> EFLDIIILPLM, [Optional] JobHandle AGGDNOGFFOD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x23A2560", Offset = "0x23A0D60", VA = "0x1823A2560")]
	[IEIEKNOJBIB]
	public static JobHandle MFGFNINPEGA<T>(this EntityCommandBufferSystem EMPKENPAECO, NativeArrayAsync<Entity> EFLDIIILPLM, [Optional] JobHandle AGGDNOGFFOD)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class AIMPHBPNECM
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x29B1C30", Offset = "0x29B0430", VA = "0x1829B1C30")]
	[IEIEKNOJBIB]
	public static JobHandle CHNIIOBHGKE<T>(this EntityCommandBufferSystem EMPKENPAECO, NativeArray<Entity> EFLDIIILPLM, NativeArray<T> KOIMDAJNDOD, JobHandle AGGDNOGFFOD) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class HGEMLBPKKEP
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x23ADB60", Offset = "0x23AC360", VA = "0x1823ADB60")]
	[IEIEKNOJBIB]
	public static JobHandle FGAIJPLPAAA<T>(this EntityCommandBufferSystem EMPKENPAECO, NativeArray<Entity> EFLDIIILPLM, T IFKKLLBODIE, [Optional] JobHandle AGGDNOGFFOD) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x23ADC40", Offset = "0x23AC440", VA = "0x1823ADC40")]
	[IEIEKNOJBIB]
	public static JobHandle FGAIJPLPAAA<T>(this EntityCommandBufferSystem EMPKENPAECO, EntityCommandBuffer KGGEMAPLOML, NativeArray<Entity> EFLDIIILPLM, T IFKKLLBODIE, [Optional] JobHandle AGGDNOGFFOD) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class OFKOHHLIOAP
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x24EFB70", Offset = "0x24EE370", VA = "0x1824EFB70")]
	public static NativeList<T> GNFOJNBEGHN<T>(NativeList<T> DJBDOMLABOE, Allocator OPPHPFNHPMG) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class GNLOMMFENID
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2386160", Offset = "0x2384960", VA = "0x182386160")]
	public static NativeArray<T> LNLOIKKAOMD<T>(this NativeList<Entity> DJBDOMLABOE, EntityManager DHDOKMIFNAD, Allocator OPPHPFNHPMG = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2385C20", Offset = "0x2384420", VA = "0x182385C20")]
	public static NativeArray<T> LNLOIKKAOMD<T>(this NativeArray<Entity> DJBDOMLABOE, EntityManager DHDOKMIFNAD, Allocator OPPHPFNHPMG = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class CCGKCPKGJGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct LGEMDPPDHKO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public struct LOOIBBKFOGB<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public LGEMDPPDHKO<TFrom> PMFLLGPMIME;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator OPPHPFNHPMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<TFrom> OFCNNPIDOOC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct MHBLFGMAMJB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public struct MJHIADIEFAL<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public MHBLFGMAMJB<TFrom> PMFLLGPMIME;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator OPPHPFNHPMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArrayAsync<TFrom> OFCNNPIDOOC;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct EMENIDFCEIP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public struct IIEFDJIAGGG<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public EMENIDFCEIP<TFrom> PMFLLGPMIME;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator OPPHPFNHPMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeListAsync<TFrom> OFCNNPIDOOC;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class PKONDFACDPN
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class LINPDIFOHJN
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private struct KIAANFAEJJJ : HBKLCMOMIFB<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> PKGKMENEINK;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5D6BB80", Offset = "0x5D6A380", VA = "0x185D6BB80")]
		[BurstCompatible]
		public Entity FKHKJNCPLEN([In] Entity IFKKLLBODIE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5D6BB80", Offset = "0x5D6A380", VA = "0x185D6BB80", Slot = "4")]
		private Entity HMGAJNNMKKC([In] Entity IFKKLLBODIE)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class NBGBCFMJHJB
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public struct AKAMFADNPPF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator OPPHPFNHPMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArray<Entity> PGBAHNFKJOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeArray<T> OFCNNPIDOOC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct AHHMFGDDAKK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator OPPHPFNHPMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeList<Entity> PGBAHNFKJOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeArray<T> OFCNNPIDOOC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct ILPNNEEOBHD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator OPPHPFNHPMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<Entity> PGBAHNFKJOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public NativeArrayAsync<T> OFCNNPIDOOC;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2CFD880", Offset = "0x2CFC080", VA = "0x182CFD880")]
		public NativeListAsync<Entity> HJPENCIBILD<TPredicate>() where TPredicate : struct, GJHKKGKBNAO<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x24CE990", Offset = "0x24CD190", VA = "0x1824CE990")]
	public static ILPNNEEOBHD<T> OJAGADPLGII<T>(this NativeArrayAsync<Entity> CHHLCPHPEKC, NativeArrayAsync<T> DJBDOMLABOE, Allocator OPPHPFNHPMG = Allocator.TempJob) where T : struct
	{
		return default(ILPNNEEOBHD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class AFEPJBEFMCE
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x29B05F0", Offset = "0x29AEDF0", VA = "0x1829B05F0")]
	public static NativeListAsync<Entity> BLPJAPKBCIM<T, TPredicate>(this NativeArrayAsync<T> DJBDOMLABOE, NativeArrayAsync<Entity> CHHLCPHPEKC, Allocator OPPHPFNHPMG = Allocator.TempJob) where T : struct where TPredicate : struct, GJHKKGKBNAO<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x29B06B0", Offset = "0x29AEEB0", VA = "0x1829B06B0")]
	private static NativeListAsync<Entity> LBIPGBEBOKJ<T, TPredicate>(NativeArrayAsync<T> IJINCAJLBCK, NativeArrayAsync<Entity> CHHLCPHPEKC, int OOHKMCMOCLB, Allocator OPPHPFNHPMG) where T : struct where TPredicate : struct, GJHKKGKBNAO<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class NMFNDLNMOEL
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct PPMEMPNLIOG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Allocator OPPHPFNHPMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public NativeArray<T> OFCNNPIDOOC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct BPGEENMIECP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Allocator OPPHPFNHPMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public NativeList<T> OFCNNPIDOOC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct EEDJPJKLLBK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Allocator OPPHPFNHPMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public NativeArrayAsync<T> OFCNNPIDOOC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct FOKNKMNCCCM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Allocator OPPHPFNHPMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public NativeListAsync<T> OFCNNPIDOOC;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class ELPELPJDALF
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class JKCMJINLDMD
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2425430", Offset = "0x2423C30", VA = "0x182425430")]
	public static NativeList<Entity> OINLPPFPIPF<T>(this NativeArray<Entity> CHHLCPHPEKC, EntityManager DHDOKMIFNAD, Allocator OPPHPFNHPMG = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class NKLBJBGJAEH
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class POHOLIKJGOJ
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public readonly struct CKJJJEHILFH<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly NativeArray<TSrc> JMHHCKCLFBI;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1C35600", Offset = "0x1C33E00", VA = "0x181C35600")]
		public CKJJJEHILFH(NativeArray<TSrc> JMHHCKCLFBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080")]
		public EJFIOBEPACM<TSrc, TValue> BKCKCCCFDPA<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(EJFIOBEPACM<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public readonly struct EJFIOBEPACM<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly NativeArray<TSrc> JMHHCKCLFBI;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1C35600", Offset = "0x1C33E00", VA = "0x181C35600")]
		public EJFIOBEPACM(NativeArray<TSrc> JMHHCKCLFBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080")]
		public FBPOFKJICLI<TSrc, TValue, TSelector> AMJMHPHHDBO<TSelector>() where TSelector : struct, HBKLCMOMIFB<TSrc, TValue>
		{
			return default(FBPOFKJICLI<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public readonly struct FBPOFKJICLI<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, HBKLCMOMIFB<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<TSrc> JMHHCKCLFBI;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1C35600", Offset = "0x1C33E00", VA = "0x181C35600")]
		public FBPOFKJICLI(NativeArray<TSrc> JMHHCKCLFBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3374330", Offset = "0x3372B30", VA = "0x183374330")]
		public AICBOPJPDCH<TSrc, TValue, TSelector> IFNCDHDMIIG()
		{
			return default(AICBOPJPDCH<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public struct PANJDDHKBIJ<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, HBKLCMOMIFB<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly NativeArray<TSrc> JMHHCKCLFBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TSelector OFJANJJHHBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int ADMJKDLHPCI;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public TValue IODFMFKEHHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x3E5D890", Offset = "0x3E5C090", VA = "0x183E5D890")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int DIEGBKIOLGK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x8C3140", Offset = "0x8C1940", VA = "0x1808C3140")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int FPGKKKADJDC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x1C47F70", Offset = "0x1C46770", VA = "0x181C47F70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3E5D930", Offset = "0x3E5C130", VA = "0x183E5D930")]
		public PANJDDHKBIJ(NativeArray<TSrc> JMHHCKCLFBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3E5D920", Offset = "0x3E5C120", VA = "0x183E5D920")]
		public bool NLCFEGLBAEP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3E5D7B0", Offset = "0x3E5BFB0", VA = "0x183E5D7B0")]
		private TSrc ANJGBPDLBLK(int PBGHCEIGALN)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public struct AICBOPJPDCH<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, HBKLCMOMIFB<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private PANJDDHKBIJ<TSrc, TValue, TSelector> AGGHFLICNAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private TValue LJKOAIOEEJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int GELOOBNLCJF;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public KIJOINBMBOF LEFHOIMPMEI
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x35A5160", Offset = "0x35A3960", VA = "0x1835A5160")]
			get
			{
				return default(KIJOINBMBOF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public TValue JABAKHNOIPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x76CBA0", Offset = "0x76B3A0", VA = "0x18076CBA0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public (TValue value, KIJOINBMBOF range) IODFMFKEHHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x35A51A0", Offset = "0x35A39A0", VA = "0x1835A51A0")]
			get
			{
				return default((TValue, KIJOINBMBOF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x35A53C0", Offset = "0x35A3BC0", VA = "0x1835A53C0")]
		public AICBOPJPDCH(NativeArray<TSrc> JMHHCKCLFBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2FDEF30", Offset = "0x2FDD730", VA = "0x182FDEF30")]
		public AICBOPJPDCH<TSrc, TValue, TSelector> NNHLEKOBGNG()
		{
			return default(AICBOPJPDCH<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x35A5280", Offset = "0x35A3A80", VA = "0x1835A5280")]
		public bool NLCFEGLBAEP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x25081E0", Offset = "0x25069E0", VA = "0x1825081E0")]
	public static CKJJJEHILFH<T> MGELHCFECPC<T>(this NativeList<T> KAEOEAACCCG) where T : struct
	{
		return default(CKJJJEHILFH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080")]
	public static CKJJJEHILFH<T> MGELHCFECPC<T>(this NativeArray<T> JMHHCKCLFBI) where T : struct
	{
		return default(CKJJJEHILFH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class GBJOFCHFIAM
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public struct KKCNOADKBNP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly NativeArray<T>.ReadOnly JMHHCKCLFBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int GELOOBNLCJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int CMBKAIIJKEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private T LJKOAIOEEJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private T IMFCBNHMGHI;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public KIJOINBMBOF LEFHOIMPMEI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x38DAB20", Offset = "0x38D9320", VA = "0x1838DAB20")]
			get
			{
				return default(KIJOINBMBOF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public T JABAKHNOIPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x2FFA4A0", Offset = "0x2FF8CA0", VA = "0x182FFA4A0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public (T, KIJOINBMBOF) IODFMFKEHHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x38DABE0", Offset = "0x38D93E0", VA = "0x1838DABE0")]
			get
			{
				return default((T, KIJOINBMBOF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x38DB110", Offset = "0x38D9910", VA = "0x1838DB110")]
		public KKCNOADKBNP(NativeArray<T> JMHHCKCLFBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x38DB060", Offset = "0x38D9860", VA = "0x1838DB060")]
		public KKCNOADKBNP<T> NNHLEKOBGNG()
		{
			return default(KKCNOADKBNP<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x38DAE80", Offset = "0x38D9680", VA = "0x1838DAE80")]
		public bool NLCFEGLBAEP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2167520", Offset = "0x2165D20", VA = "0x182167520")]
		public DLGBDFJAFMF<T, TComparer> OGGCIGHAHOH<TComparer>([Optional] TComparer OMJDOKICJMG) where TComparer : struct, IEqualityComparer<T>
		{
			return default(DLGBDFJAFMF<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public struct DLGBDFJAFMF<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly NativeArray<T>.ReadOnly JMHHCKCLFBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int GELOOBNLCJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private int CMBKAIIJKEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private T LJKOAIOEEJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private T IMFCBNHMGHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private TComparer OMJDOKICJMG;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public KIJOINBMBOF LEFHOIMPMEI
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x38DAB20", Offset = "0x38D9320", VA = "0x1838DAB20")]
			get
			{
				return default(KIJOINBMBOF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public T JABAKHNOIPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x2FFA4A0", Offset = "0x2FF8CA0", VA = "0x182FFA4A0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public (T value, KIJOINBMBOF range) IODFMFKEHHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x4CD96A0", Offset = "0x4CD7EA0", VA = "0x184CD96A0")]
			get
			{
				return default((T, KIJOINBMBOF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x4CD9990", Offset = "0x4CD8190", VA = "0x184CD9990")]
		public DLGBDFJAFMF(NativeArray<T>.ReadOnly JMHHCKCLFBI, TComparer OMJDOKICJMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x4CD9950", Offset = "0x4CD8150", VA = "0x184CD9950")]
		public DLGBDFJAFMF<T, TComparer> NNHLEKOBGNG()
		{
			return default(DLGBDFJAFMF<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x4CD9770", Offset = "0x4CD7F70", VA = "0x184CD9770")]
		public bool NLCFEGLBAEP()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x237A260", Offset = "0x2378A60", VA = "0x18237A260")]
	public static KKCNOADKBNP<T> IFNCDHDMIIG<T>(this NativeArray<T> JMHHCKCLFBI) where T : struct
	{
		return default(KKCNOADKBNP<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface GOCLKIPEDIO
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class ELAHFOIIIGM
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct FNDPFPGLIEH<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class PGHDLBGNJLK : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public FNDPFPGLIEH<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x954C10", Offset = "0x953410", VA = "0x180954C10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x33D7580", Offset = "0x33D5D80", VA = "0x1833D7580", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x76E060", Offset = "0x76C860", VA = "0x18076E060")]
		[DebuggerHidden]
		public PGHDLBGNJLK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3E7DEA0", Offset = "0x3E7C6A0", VA = "0x183E7DEA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3E7E050", Offset = "0x3E7C850", VA = "0x183E7E050", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Action<Protobuf> CFBOOMLKCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream NLHFJNBMIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedInputStream BAKBOOGCKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly Protobuf POHIAPLOGJF;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public readonly int FPGKKKADJDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x807520", Offset = "0x805D20", VA = "0x180807520")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x33B57D0", Offset = "0x33B3FD0", VA = "0x1833B57D0")]
	private FNDPFPGLIEH(byte[] NBCCIHGJKDM, Action<Protobuf> CFBOOMLKCNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2BF18B0", Offset = "0x2BF00B0", VA = "0x182BF18B0")]
	public static FNDPFPGLIEH<Protobuf> GFPEABNIECK<Data>(ReadOnlySpan<byte> BGGDIKOMABC, ReadOnlySpan<Data> KBLIOPDOHJK, Action<Protobuf> CFBOOMLKCNJ)
	{
		return default(FNDPFPGLIEH<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x33B5640", Offset = "0x33B3E40", VA = "0x1833B5640", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x33B5680", Offset = "0x33B3E80", VA = "0x1833B5680", Slot = "4")]
	[IteratorStateMachine(typeof(FNDPFPGLIEH<>.PGHDLBGNJLK))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x33B5770", Offset = "0x33B3F70", VA = "0x1833B5770", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct KIKDIPEFJFN<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] NBCCIHGJKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public readonly Protobuf POHIAPLOGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly MemoryStream NLHFJNBMIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly CodedOutputStream MIPCEMPLCFO;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x38DA8E0", Offset = "0x38D90E0", VA = "0x1838DA8E0")]
	private KIKDIPEFJFN(byte[] NBCCIHGJKDM, [In] Protobuf POHIAPLOGJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2162DA0", Offset = "0x21615A0", VA = "0x182162DA0")]
	public static KIKDIPEFJFN<Protobuf> GFPEABNIECK<T>(ReadOnlySpan<T> KBLIOPDOHJK)
	{
		return default(KIKDIPEFJFN<Protobuf>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x38DA6F0", Offset = "0x38D8EF0", VA = "0x1838DA6F0")]
	public void APOPPDAOJCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x38DA720", Offset = "0x38D8F20", VA = "0x1838DA720")]
	public ByteString CGIMOENKJPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x38DA7B0", Offset = "0x38D8FB0", VA = "0x1838DA7B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct KCKKOACOJBI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly MemoryStream NLHFJNBMIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly CodedInputStream BAKBOOGCKGK;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B890", Offset = "0x5D6A090", VA = "0x185D6B890", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct KEHGJIGMNJH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly byte[] NBCCIHGJKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly MemoryStream NLHFJNBMIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly CodedOutputStream MIPCEMPLCFO;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5D6BA50", Offset = "0x5D6A250", VA = "0x185D6BA50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class IJNNDIFGCKD
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public delegate void FPAHOGPFNMM<From, To>(From PMFLLGPMIME, To PCLAHFAGOCH, NMKCGFFAGNA MDDDOHLBGMH);

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class APDKMDLIGCH<From, To>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static FPAHOGPFNMM<From, To> HJMJHGAMPGF;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public APDKMDLIGCH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B170", Offset = "0x5D69970", VA = "0x185D6B170")]
	static IJNNDIFGCKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x24019E0", Offset = "0x24001E0", VA = "0x1824019E0")]
	public static void DDMFIEOPPJL<T>(FPAHOGPFNMM<T, T> FKJDAKDGICF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x24015F0", Offset = "0x23FFDF0", VA = "0x1824015F0")]
	public static void DDMFIEOPPJL<From, To>(FPAHOGPFNMM<From, To> FKJDAKDGICF, FPAHOGPFNMM<To, From> ECPEBFLIPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2401670", Offset = "0x23FFE70", VA = "0x182401670")]
	public static void DDMFIEOPPJL<From, To>(FPAHOGPFNMM<From, To> HJMJHGAMPGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2403A60", Offset = "0x2402260", VA = "0x182403A60")]
	public static FPAHOGPFNMM<From, To> EMBHCFKPDBL<From, To>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2409CD0", Offset = "0x24084D0", VA = "0x182409CD0")]
	public static void LNNHONMKPFF<From, To>(From PMFLLGPMIME, To PCLAHFAGOCH, NMKCGFFAGNA MDDDOHLBGMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class NMKCGFFAGNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	internal NativeArray<EntityRemapUtility.EntityRemapInfo> LBEBNNPKBOL;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x1C0FAE0", Offset = "0x1C0E2E0", VA = "0x181C0FAE0")]
	public NMKCGFFAGNA(NativeArray<EntityRemapUtility.EntityRemapInfo> LBEBNNPKBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5D6C680", Offset = "0x5D6AE80", VA = "0x185D6C680")]
	public Entity OEGMKPKPFCL(Entity MOHHJLIGFPM)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class MOCGHMBLOMA
{
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5D6BEE0", Offset = "0x5D6A6E0", VA = "0x185D6BEE0")]
	public static ulong KLBPOBHOJFB(Type BJKOKHNAAID)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5D6BF70", Offset = "0x5D6A770", VA = "0x185D6BF70")]
	public static ulong KLBPOBHOJFB(string GKBPEPPONME)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[Flags]
public enum IAANKBJLGOO
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
public class ABGLLKGMJHL : KPKFEINJGIH
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x771100", Offset = "0x76F900", VA = "0x180771100")]
	public ABGLLKGMJHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal static class CMCAEPFBHDN
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5D6AD80", Offset = "0x5D69580", VA = "0x185D6AD80")]
	private unsafe static Span<byte> KLOJOCCGOMK(Unity.Entities.Chunk* KIJHCPOKLEK, int PFKAOAAPHBK)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2200BB0", Offset = "0x21FF3B0", VA = "0x182200BB0")]
	public unsafe static Span<T> DOGJJKIAPHB<T>(Unity.Entities.Chunk* KIJHCPOKLEK, int PFKAOAAPHBK)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2200B80", Offset = "0x21FF380", VA = "0x182200B80")]
	public static Span<T> DOGJJKIAPHB<T>(this Unity.Entities.Chunk KIJHCPOKLEK, int PFKAOAAPHBK)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5D6AE50", Offset = "0x5D69650", VA = "0x185D6AE50")]
	public unsafe static Span<Entity> LJCHFKNIFLE(Unity.Entities.Chunk* KIJHCPOKLEK)
	{
		return default(Span<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5D6AEB0", Offset = "0x5D696B0", VA = "0x185D6AEB0")]
	public unsafe static void PAMPKEGOCOB(Unity.Entities.Chunk* KIJHCPOKLEK, int PFKAOAAPHBK)
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class OBJMCPPPHHO
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public OBJMCPPPHHO()
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
