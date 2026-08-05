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
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
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
		[Cpp2IlInjected.Address(RVA = "0x6204C10", Offset = "0x6203E10", VA = "0x186204C10")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CKDCONOAFHB : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	PGLFKBNKEPI KAMHMDIJLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface KNGLCEJOPNI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MHOPJLDGKLF(Entity ACPAMCNIKHM, object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OJPJJHGOFCA(Entity ACPAMCNIKHM, object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IJICBJLOJNN(Entity ACPAMCNIKHM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GFAPDOAKLHO(Entity ACPAMCNIKHM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class IAFCCJFIMIO<TComponentData, TValue> : GLCKFHFNNBC<TValue>, IDisposable where TComponentData : struct, CKDCONOAFHB
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class PCPGHFHDNIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> LBDHFFKKBHH;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int GIHIJMKOGEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x322EEE0", Offset = "0x322E0E0", VA = "0x18322EEE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x41955C0", Offset = "0x41947C0", VA = "0x1841955C0")]
		public bool NMBNOBAAHEG([Out] TValue EKDDCPALANJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4195510", Offset = "0x4194710", VA = "0x184195510")]
		public void GHBEENLPKLN(object GMMJMENGHCD, TValue EKDDCPALANJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x41953B0", Offset = "0x41945B0", VA = "0x1841953B0")]
		public bool FBCLMIGJMFH(object GMMJMENGHCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4195430", Offset = "0x4194630", VA = "0x184195430")]
		public int FDEBALNGCCB(object GMMJMENGHCD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4195690", Offset = "0x4194890", VA = "0x184195690")]
		public PCPGHFHDNIG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<PCPGHFHDNIG> PHFJPAIPCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private GHOIJHGAPPI<PGLFKBNKEPI, PCPGHFHDNIG> EEENPFEDNFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager EIHNJKMOIAM;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3A15A70", Offset = "0x3A14C70", VA = "0x183A15A70")]
	public IAFCCJFIMIO(EntityManager EIHNJKMOIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3A155F0", Offset = "0x3A147F0", VA = "0x183A155F0", Slot = "4")]
	public void MHOPJLDGKLF(Entity ACPAMCNIKHM, object GMMJMENGHCD, TValue EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3A158F0", Offset = "0x3A14AF0", VA = "0x183A158F0", Slot = "5")]
	public bool OJPJJHGOFCA(Entity ACPAMCNIKHM, object GMMJMENGHCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3A15710", Offset = "0x3A14910", VA = "0x183A15710", Slot = "6")]
	public bool NMBNOBAAHEG(Entity ACPAMCNIKHM, [Out] TValue EKDDCPALANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3A153B0", Offset = "0x3A145B0", VA = "0x183A153B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3A15560", Offset = "0x3A14760", VA = "0x183A15560")]
	private void LPABIPOBMEI(PCPGHFHDNIG MADMLBIJBGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3A153D0", Offset = "0x3A145D0", VA = "0x183A153D0")]
	private bool HLPLPDDDDEB(Entity ACPAMCNIKHM, [Out] PGLFKBNKEPI OEHGECKOHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3A15480", Offset = "0x3A14680", VA = "0x183A15480")]
	private void JNGEBCNLGFK(Entity ACPAMCNIKHM, PGLFKBNKEPI OEHGECKOHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3A157F0", Offset = "0x3A149F0", VA = "0x183A157F0")]
	private bool OHHGGGALAAO(PGLFKBNKEPI OEHGECKOHPK, [Out] PCPGHFHDNIG MADMLBIJBGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3A15810", Offset = "0x3A14A10", VA = "0x183A15810")]
	private PCPGHFHDNIG OJKFAKGBJFN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GLCKFHFNNBC<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MHOPJLDGKLF(Entity ACPAMCNIKHM, object GMMJMENGHCD, TValue EKDDCPALANJ);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OJPJJHGOFCA(Entity ACPAMCNIKHM, object GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NMBNOBAAHEG(Entity ACPAMCNIKHM, [Out] TValue EKDDCPALANJ);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct PGLFKBNKEPI : GBFEIFPHLOE, IEquatable<PGLFKBNKEPI>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly PGLFKBNKEPI BMBGBFLCPKI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int ABDHHHCLNNL
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x906BA0", Offset = "0x905DA0", VA = "0x180906BA0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x906BC0", Offset = "0x905DC0", VA = "0x180906BC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int OGIJDDFLLOB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2335DF0", Offset = "0x2334FF0", VA = "0x182335DF0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5587230", Offset = "0x5586430", VA = "0x185587230", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6205530", Offset = "0x6204730", VA = "0x186205530", Slot = "8")]
	public bool Equals(PGLFKBNKEPI MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6205580", Offset = "0x6204780", VA = "0x186205580", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HMJLOBPKEMN<THasTokensTag> : KNGLCEJOPNI, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly IOBNAOMELJK AOBMECMACLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, PGLFKBNKEPI> PBDPJOLGKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> PHFJPAIPCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private GHOIJHGAPPI<PGLFKBNKEPI, HashSet<object>> EEENPFEDNFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager EIHNJKMOIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem FHGCOJAKMHG;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3981700", Offset = "0x3980900", VA = "0x183981700")]
	public HMJLOBPKEMN(EntityManager EIHNJKMOIAM, EntityCommandBufferSystem FHGCOJAKMHG, IOBNAOMELJK PCBBMOKGKNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x39802F0", Offset = "0x397F4F0", VA = "0x1839802F0", Slot = "4")]
	public bool MHOPJLDGKLF(Entity ACPAMCNIKHM, object GMMJMENGHCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x39810D0", Offset = "0x39802D0", VA = "0x1839810D0", Slot = "5")]
	public bool OJPJJHGOFCA(Entity ACPAMCNIKHM, object GMMJMENGHCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x397F2E0", Offset = "0x397E4E0", VA = "0x18397F2E0", Slot = "6")]
	public bool IJICBJLOJNN(Entity ACPAMCNIKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x397F410", Offset = "0x397E610", VA = "0x18397F410", Slot = "9")]
	public bool IJICBJLOJNN(PGLFKBNKEPI OEHGECKOHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x397EB60", Offset = "0x397DD60", VA = "0x18397EB60", Slot = "7")]
	public bool GFAPDOAKLHO(Entity ACPAMCNIKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x397E790", Offset = "0x397D990", VA = "0x18397E790", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x397F900", Offset = "0x397EB00", VA = "0x18397F900")]
	private void LPABIPOBMEI(HashSet<object> MADMLBIJBGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x397F220", Offset = "0x397E420", VA = "0x18397F220")]
	private bool HLPLPDDDDEB(Entity ACPAMCNIKHM, [Out] PGLFKBNKEPI OEHGECKOHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3981440", Offset = "0x3980640", VA = "0x183981440")]
	private bool PLFBIGKEGCI(Entity ACPAMCNIKHM, [Out] PGLFKBNKEPI OEHGECKOHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x397FE30", Offset = "0x397F030", VA = "0x18397FE30")]
	private void MGOHCAJBBKI(Entity ACPAMCNIKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x397E550", Offset = "0x397D750", VA = "0x18397E550")]
	private void DNCCCHGGPAJ(Entity ACPAMCNIKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3980890", Offset = "0x397FA90", VA = "0x183980890")]
	private void NAKGKLJIJGD(Entity ACPAMCNIKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x397F890", Offset = "0x397EA90", VA = "0x18397F890")]
	private void JNGEBCNLGFK(Entity ACPAMCNIKHM, PGLFKBNKEPI OEHGECKOHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x397E890", Offset = "0x397DA90", VA = "0x18397E890")]
	private bool EICOBBLODNP(PGLFKBNKEPI OEHGECKOHPK, [Out] HashSet<object> MADMLBIJBGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3980990", Offset = "0x397FB90", VA = "0x183980990")]
	private HashSet<object> OJKFAKGBJFN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class BHICBCHOOLA
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct AAPJDGGJHCP : FBMOAOBEIHP<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6204660", Offset = "0x6203860", VA = "0x186204660")]
	public float LGMEBLFBOIB([In] float3 EKDDCPALANJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6204660", Offset = "0x6203860", VA = "0x186204660", Slot = "4")]
	private float DAKHPIFFPBB([In] float3 EKDDCPALANJ)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct NJLMAMMMBPE : FBMOAOBEIHP<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6205510", Offset = "0x6204710", VA = "0x186205510")]
	public float LGMEBLFBOIB([In] float3 EKDDCPALANJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6205510", Offset = "0x6204710", VA = "0x186205510", Slot = "4")]
	private float DAKHPIFFPBB([In] float3 EKDDCPALANJ)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct HLGBPHNIDCC : FBMOAOBEIHP<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1AE4AF0", Offset = "0x1AE3CF0", VA = "0x181AE4AF0")]
	public float LGMEBLFBOIB([In] float3 EKDDCPALANJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1AE4AF0", Offset = "0x1AE3CF0", VA = "0x181AE4AF0", Slot = "4")]
	private float DAKHPIFFPBB([In] float3 EKDDCPALANJ)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct MJOLABKJJNO : FBMOAOBEIHP<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x13E4320", Offset = "0x13E3520", VA = "0x1813E4320")]
	public int LGMEBLFBOIB([In] int3 EKDDCPALANJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x13E4320", Offset = "0x13E3520", VA = "0x1813E4320", Slot = "4")]
	private int HCIGBAGOLBL([In] int3 EKDDCPALANJ)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct MCMDFIACPMD : FBMOAOBEIHP<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6205170", Offset = "0x6204370", VA = "0x186205170")]
	public int LGMEBLFBOIB([In] int3 EKDDCPALANJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6205170", Offset = "0x6204370", VA = "0x186205170", Slot = "4")]
	private int HCIGBAGOLBL([In] int3 EKDDCPALANJ)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct NADLHDLPAHK : FBMOAOBEIHP<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x16EA480", Offset = "0x16E9680", VA = "0x1816EA480")]
	public int LGMEBLFBOIB([In] int3 EKDDCPALANJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x16EA480", Offset = "0x16E9680", VA = "0x1816EA480", Slot = "4")]
	private int HCIGBAGOLBL([In] int3 EKDDCPALANJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class PHHPIHDONBA : GNEIIAKNNFI
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F40", Offset = "0x7C3140", VA = "0x1807C3F40")]
	public PHHPIHDONBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class EMJPOHDAGIF : SystemBase, LCBIAEGCKBO
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2747900", Offset = "0x2746B00", VA = "0x182747900")]
	public void JMPPFIHGGOF<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x27476C0", Offset = "0x27468C0", VA = "0x1827476C0")]
	public JobHandle JMPPFIHGGOF<T>(JobHandle MIEHEEKPCGJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2747900", Offset = "0x2746B00", VA = "0x182747900")]
	public void LBHEJGIMHGP<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2747D40", Offset = "0x2746F40", VA = "0x182747D40")]
	public JobHandle LBHEJGIMHGP<T>(JobHandle MIEHEEKPCGJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6204B20", Offset = "0x6203D20", VA = "0x186204B20")]
	public ComponentDataFromEntity BINNOFPEPKI(int IPGPCGDBEKF, bool CGFOLMGDJGL = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6204BE0", Offset = "0x6203DE0", VA = "0x186204BE0")]
	public EntityExistenceLookupByEntity BNCDLFKGGLC()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6204C00", Offset = "0x6203E00", VA = "0x186204C00", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F40", Offset = "0x7C3140", VA = "0x1807C3F40")]
	protected EMJPOHDAGIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class IAEDBAAJJKP : EMJPOHDAGIF
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6205050", Offset = "0x6204250", VA = "0x186205050", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F40", Offset = "0x7C3140", VA = "0x1807C3F40")]
	protected IAEDBAAJJKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class KJFJMBDJLFO
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class KPAPENIIIBP : EntityCommandBufferSystem, LCBIAEGCKBO
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F40", Offset = "0x7C3140", VA = "0x1807C3F40")]
	protected KPAPENIIIBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FBMOAOBEIHP<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo LGMEBLFBOIB([In] TFrom EKDDCPALANJ);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface MPHDBJNJNHF<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EGPGGHNNCOC(T EKDDCPALANJ);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BurstCompile]
internal struct IHFAMHOJAPP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[ReadOnly]
	public NativeArray<Entity> GKCCDIIKKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public EntityCommandBuffer CJGBJJABLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public ComponentTypes NOJCNPEKCMF;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6205080", Offset = "0x6204280", VA = "0x186205080", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct HNIJBMEGNGF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[ReadOnly]
	public NativeArray<Entity> GKCCDIIKKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public EntityCommandBuffer CJGBJJABLKD;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6204FB0", Offset = "0x62041B0", VA = "0x186204FB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct FGELIOINDNE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public NativeArray<Entity> GKCCDIIKKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public EntityCommandBuffer CJGBJJABLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public ComponentType NBEIOIJKHCJ;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6204E10", Offset = "0x6204010", VA = "0x186204E10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct LCKFEEDCPPB<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	[ReadOnly]
	public NativeArray<Entity> GKCCDIIKKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<T> MJGHOBDIDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer CJGBJJABLKD;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3D55ED0", Offset = "0x3D550D0", VA = "0x183D55ED0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal struct NNJPIKFNHPD<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<Entity> GKCCDIIKKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<T> DBIFCPFENHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public EntityCommandBuffer CJGBJJABLKD;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct JDJDABKODNH<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<Entity> GKCCDIIKKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public T EKDDCPALANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public EntityCommandBuffer CJGBJJABLKD;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3BECA10", Offset = "0x3BEBC10", VA = "0x183BECA10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BurstCompile]
internal struct EDOPEIFPNLL<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, FBMOAOBEIHP<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[ReadOnly]
	public NativeArray<TFrom> DCPNMBBBCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[WriteOnly]
	public NativeArray<TTo> KLOHFBEPDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public TMap OFOIHENMFDE;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct NGANOFCBELF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[ReadOnly]
	public ComponentDataFromEntity ICHCAECGHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<Entity> DCPNMBBBCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<byte> KLOHFBEPDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int PGHJIKBMPKK;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6205180", Offset = "0x6204380", VA = "0x186205180", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct DIDFCBEIBPJ<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity<T> HFIFGNAPKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> DCPNMBBBCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeList<T> LOMDKBNBMFN;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct HOBHIIMIEPL<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, FBMOAOBEIHP<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public NativeArray<TFrom> MLHJHNCLPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[WriteOnly]
	public NativeList<TTo> KLOHFBEPDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public TMap OFOIHENMFDE;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct OLJFJLHKICA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public ComponentDataFromEntity<T> BIBFMGJFMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<Entity> BIFPCGJFOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<bool> KIPPKEMMPFK;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct CODKEPKBBLC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ComponentDataFromEntity<T> BIBFMGJFMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public NativeArray<Entity> BIFPCGJFOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public NativeArray<bool> KIPPKEMMPFK;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4BE6B20", Offset = "0x4BE5D20", VA = "0x184BE6B20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct CJKJMLLBPFK<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<T> DCPNMBBBCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeList<T> LOMDKBNBMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeParallelHashSet<T> HOGIEKCHMOH;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4A22B80", Offset = "0x4A21D80", VA = "0x184A22B80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct DDEBPEDGIED<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : FBMOAOBEIHP<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public NativeArray<TFrom> DCPNMBBBCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeList<TFrom> LOMDKBNBMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeParallelHashSet<TTo> HOGIEKCHMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public TMap OFOIHENMFDE;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct HCGMIIADHLL<T, TPredicate> : IJob where T : struct where TPredicate : struct, MPHDBJNJNHF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<T> DCPNMBBBCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public NativeArray<Entity> KDMJFDGBADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeList<Entity> MIJAAMLJKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TPredicate OFOIHENMFDE;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3943170", Offset = "0x3942370", VA = "0x183943170", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct IGDGBLPOBIM<T, TPredicate> : IJob where T : struct where TPredicate : struct, MPHDBJNJNHF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> DCPNMBBBCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public NativeList<T> LOMDKBNBMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public TPredicate OFOIHENMFDE;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct EHNMINELHIC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public ComponentDataFromEntity BIBFMGJFMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<Entity> BIFPCGJFOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<Entity> LGPLOGNMEIL;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6204A90", Offset = "0x6203C90", VA = "0x186204A90", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct DPKMBELPPEC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[ReadOnly]
	public ComponentDataFromEntity BIBFMGJFMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<Entity> BIFPCGJFOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<Entity> LGPLOGNMEIL;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x62049C0", Offset = "0x6203BC0", VA = "0x1862049C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class HAGKKOMCGJM
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class LKDPLBBJOBE
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2911E10", Offset = "0x2911010", VA = "0x182911E10")]
	public static bool DMIOGLGOEEN<T>(this NativeArray<Entity> BIFPCGJFOKE, EntityManager EIHNJKMOIAM, Allocator HOJMCOLANAB = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class BMLPLBGLGMD
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class KKIOGPGAFIC<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		public KKIOGPGAFIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class NJJOEPNFEJL<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		public NJJOEPNFEJL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<Func<JobHandle, JobHandle>> EFOGANAIDCA;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6204670", Offset = "0x6203870", VA = "0x186204670")]
	public BMLPLBGLGMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class MBCDBFBOIKH
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class NOKHLCDJBKG
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct HCPEPFOMBEL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct JNCNCLGCLEE<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			internal HCPEPFOMBEL<TFrom> DLAKBCKOLFN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal Allocator HOJMCOLANAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal NativeArray<TFrom> NGGIHAOFJPD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct AKONNOOLOEC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct KHDIKFNMNDG<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			internal AKONNOOLOEC<TFrom> DLAKBCKOLFN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal Allocator HOJMCOLANAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal NativeList<TFrom> NGGIHAOFJPD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct DEBGPLJDBHN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct COFAPFNPNNE<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			internal DEBGPLJDBHN<TFrom> DLAKBCKOLFN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal Allocator HOJMCOLANAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal NativeArrayAsync<TFrom> NGGIHAOFJPD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct DFFBNLKJHFJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct FCBPFDNGPMO<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			internal DFFBNLKJHFJ<TFrom> DLAKBCKOLFN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal Allocator HOJMCOLANAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal NativeListAsync<TFrom> NGGIHAOFJPD;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class AMHHCINGOKL
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class LJNFNCFLFLN
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x29118D0", Offset = "0x2910AD0", VA = "0x1829118D0")]
	public static NativeList<T> LOBOCCIKEMJ<T>(this NativeArray<T> DHMHIDFJNBK, Allocator HOJMCOLANAB = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class KKFCCIOCLKP
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class CJNMAOADGIL
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x26C9AD0", Offset = "0x26C8CD0", VA = "0x1826C9AD0")]
	[DKPJCDIAFFL]
	public static JobHandle JOGHNMNLMKB<T>(this EntityCommandBufferSystem FHGCOJAKMHG, NativeArrayAsync<Entity> GKCCDIIKKCI, NativeArrayAsync<T> MJGHOBDIDHD, [Optional] JobHandle MIEHEEKPCGJ) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x26C9C30", Offset = "0x26C8E30", VA = "0x1826C9C30")]
	[DKPJCDIAFFL]
	public static JobHandle JOGHNMNLMKB<T>(this EntityCommandBufferSystem FHGCOJAKMHG, NativeArrayAsync<Entity> GKCCDIIKKCI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x26C99B0", Offset = "0x26C8BB0", VA = "0x1826C99B0")]
	[DKPJCDIAFFL]
	public static JobHandle JOGHNMNLMKB<T>(this EntityCommandBufferSystem FHGCOJAKMHG, NativeArray<Entity> GKCCDIIKKCI, [Optional] JobHandle MIEHEEKPCGJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6204850", Offset = "0x6203A50", VA = "0x186204850")]
	[DKPJCDIAFFL]
	public static JobHandle JOGHNMNLMKB(this EntityCommandBufferSystem FHGCOJAKMHG, NativeArray<Entity> GKCCDIIKKCI, ComponentTypes NOJCNPEKCMF, [Optional] JobHandle MIEHEEKPCGJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6204700", Offset = "0x6203900", VA = "0x186204700")]
	[DKPJCDIAFFL]
	public static JobHandle JOGHNMNLMKB(this EntityCommandBufferSystem FHGCOJAKMHG, EntityCommandBuffer CJGBJJABLKD, NativeArray<Entity> GKCCDIIKKCI, ComponentTypes NOJCNPEKCMF, [Optional] JobHandle MIEHEEKPCGJ)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class GCFOGCPMMPH
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2884B30", Offset = "0x2883D30", VA = "0x182884B30")]
	[DKPJCDIAFFL]
	public static JobHandle NLGGENNGLPN<T>(this EntityCommandBufferSystem FHGCOJAKMHG, EntityCommandBuffer CJGBJJABLKD, EntityQuery FEEIOFCCLAE, T EKDDCPALANJ) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class NHBMEFFOFNH
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6205280", Offset = "0x6204480", VA = "0x186205280")]
	[DKPJCDIAFFL]
	public static JobHandle AEPHCAIOBHF(this EntityCommandBufferSystem FHGCOJAKMHG, NativeList<Entity> GKCCDIIKKCI, [Optional] JobHandle MIEHEEKPCGJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6205410", Offset = "0x6204610", VA = "0x186205410")]
	[DKPJCDIAFFL]
	public static JobHandle AEPHCAIOBHF(this EntityCommandBufferSystem FHGCOJAKMHG, NativeArrayAsync<Entity> GKCCDIIKKCI)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class EMIEGNDMFHL
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x27474C0", Offset = "0x27466C0", VA = "0x1827474C0")]
	public static void LJKEJFIGMOI<T>(this EntityCommandBufferSystem FHGCOJAKMHG, EntityQuery FEEIOFCCLAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2747400", Offset = "0x2746600", VA = "0x182747400")]
	[DKPJCDIAFFL]
	public static JobHandle CMBJMLPIJPF<T>(this EntityCommandBufferSystem FHGCOJAKMHG, NativeListAsync<Entity> GKCCDIIKKCI, [Optional] JobHandle MIEHEEKPCGJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2747270", Offset = "0x2746470", VA = "0x182747270")]
	[DKPJCDIAFFL]
	public static JobHandle CMBJMLPIJPF<T>(this EntityCommandBufferSystem FHGCOJAKMHG, NativeArrayAsync<Entity> GKCCDIIKKCI, [Optional] JobHandle MIEHEEKPCGJ)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class KNIAMEONMEC
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2902CB0", Offset = "0x2901EB0", VA = "0x182902CB0")]
	[DKPJCDIAFFL]
	public static JobHandle CFOHONAOELA<T>(this EntityCommandBufferSystem FHGCOJAKMHG, NativeArray<Entity> GKCCDIIKKCI, NativeArray<T> MJGHOBDIDHD, JobHandle MIEHEEKPCGJ) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class LLIKNCENONN
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x29249A0", Offset = "0x2923BA0", VA = "0x1829249A0")]
	[DKPJCDIAFFL]
	public static JobHandle CDDOHHOPEII<T>(this EntityCommandBufferSystem FHGCOJAKMHG, NativeArray<Entity> GKCCDIIKKCI, T EKDDCPALANJ, [Optional] JobHandle MIEHEEKPCGJ) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x29248D0", Offset = "0x2923AD0", VA = "0x1829248D0")]
	[DKPJCDIAFFL]
	public static JobHandle CDDOHHOPEII<T>(this EntityCommandBufferSystem FHGCOJAKMHG, EntityCommandBuffer CJGBJJABLKD, NativeArray<Entity> GKCCDIIKKCI, T EKDDCPALANJ, [Optional] JobHandle MIEHEEKPCGJ) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class KLBFFHEPNDN
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class FDKCMFACJNB
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x286D0A0", Offset = "0x286C2A0", VA = "0x18286D0A0")]
	public static NativeArray<T> GEAHHFJLKFE<T>(this NativeList<Entity> DHMHIDFJNBK, EntityManager EIHNJKMOIAM, Allocator HOJMCOLANAB = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x286CB60", Offset = "0x286BD60", VA = "0x18286CB60")]
	public static NativeArray<T> GEAHHFJLKFE<T>(this NativeArray<Entity> DHMHIDFJNBK, EntityManager EIHNJKMOIAM, Allocator HOJMCOLANAB = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6204C30", Offset = "0x6203E30", VA = "0x186204C30")]
	public static NativeArray<Entity> IDKBHCKCMEP(this NativeArray<Entity> DHMHIDFJNBK, EntityManager EIHNJKMOIAM, ComponentType NBEIOIJKHCJ, Allocator HOJMCOLANAB = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x286CA80", Offset = "0x286BC80", VA = "0x18286CA80")]
	public static NativeArray<T> CIGCPCJGCGB<T>(this NativeArray<Entity> DHMHIDFJNBK, EntityManager EIHNJKMOIAM, Allocator HOJMCOLANAB = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class MLGLOGENJAN
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct IMIBPNPOGPL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct HLOGNPAOHAJ<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public IMIBPNPOGPL<TFrom> NGGIHAOFJPD;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public Allocator HOJMCOLANAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeArray<TFrom> DCPNMBBBCEL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct IKBIHKNLCCA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct IJEJELDFEBM<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public IKBIHKNLCCA<TFrom> NGGIHAOFJPD;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Allocator HOJMCOLANAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeArrayAsync<TFrom> DCPNMBBBCEL;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct LDGDBDDPIFL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct MCMCHICIMFI<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public LDGDBDDPIFL<TFrom> NGGIHAOFJPD;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Allocator HOJMCOLANAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public NativeListAsync<TFrom> DCPNMBBBCEL;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class CLMANPGNJOF
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class DIMHPNDKCEM
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct PCKCGIGIDLP : FBMOAOBEIHP<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> DOCOILCCIMN;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6205520", Offset = "0x6204720", VA = "0x186205520")]
		[BurstCompatible]
		public Entity LGMEBLFBOIB([In] Entity EKDDCPALANJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6205520", Offset = "0x6204720", VA = "0x186205520", Slot = "4")]
		private Entity JKLFAKAMCKM([In] Entity EKDDCPALANJ)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class PDFMDLPFABJ
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct KNEOMNOGMID<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator HOJMCOLANAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeArray<Entity> KDMJFDGBADI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<T> DCPNMBBBCEL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct EMGCMKGLDKO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Allocator HOJMCOLANAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<Entity> KDMJFDGBADI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<T> DCPNMBBBCEL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct GMEBJNJLPPB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Allocator HOJMCOLANAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArrayAsync<Entity> KDMJFDGBADI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArrayAsync<T> DCPNMBBBCEL;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x278AF30", Offset = "0x278A130", VA = "0x18278AF30")]
		public NativeListAsync<Entity> EGPGGHNNCOC<TPredicate>() where TPredicate : struct, MPHDBJNJNHF<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2A0ECE0", Offset = "0x2A0DEE0", VA = "0x182A0ECE0")]
	public static GMEBJNJLPPB<T> HKLNFDKPHAP<T>(this NativeArrayAsync<Entity> BIFPCGJFOKE, NativeArrayAsync<T> DHMHIDFJNBK, Allocator HOJMCOLANAB = Allocator.TempJob) where T : struct
	{
		return default(GMEBJNJLPPB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class AMHIJGPIPHO
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2EAD970", Offset = "0x2EACB70", VA = "0x182EAD970")]
	public static NativeListAsync<Entity> JHLOHHFKHMG<T, TPredicate>(this NativeArrayAsync<T> DHMHIDFJNBK, NativeArrayAsync<Entity> BIFPCGJFOKE, Allocator HOJMCOLANAB = Allocator.TempJob) where T : struct where TPredicate : struct, MPHDBJNJNHF<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2EADA30", Offset = "0x2EACC30", VA = "0x182EADA30")]
	private static NativeListAsync<Entity> NKAEFAIDJJD<T, TPredicate>(NativeArrayAsync<T> CHNKMKCMOCI, NativeArrayAsync<Entity> BIFPCGJFOKE, int EAMNBPDOIFO, Allocator HOJMCOLANAB) where T : struct where TPredicate : struct, MPHDBJNJNHF<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class OJKOCIAGGLB
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct ODLBKHKPDBD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Allocator HOJMCOLANAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public NativeArray<T> DCPNMBBBCEL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct PLNFMCHEELD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator HOJMCOLANAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeList<T> DCPNMBBBCEL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct PDMENAOCKGM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator HOJMCOLANAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArrayAsync<T> DCPNMBBBCEL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct MBPFINEEHBK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator HOJMCOLANAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeListAsync<T> DCPNMBBBCEL;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class NMLCFDHPCII
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class CKAGPNOBKCO
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x26C9E10", Offset = "0x26C9010", VA = "0x1826C9E10")]
	public static NativeList<Entity> DOJBHPHDHEA<T>(this NativeArray<Entity> BIFPCGJFOKE, EntityManager EIHNJKMOIAM, Allocator HOJMCOLANAB = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class MODNBDIPCNP
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class FKHHFKIMPBN
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public readonly struct KHKPCIGNIIO<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly NativeArray<TSrc> BLGDAGLONDD;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1E0B980", Offset = "0x1E0AB80", VA = "0x181E0B980")]
		public KHKPCIGNIIO(NativeArray<TSrc> BLGDAGLONDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0")]
		public KGANBLIFABJ<TSrc, TValue> DKDNJDIACAP<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(KGANBLIFABJ<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct KGANBLIFABJ<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NativeArray<TSrc> BLGDAGLONDD;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1E0B980", Offset = "0x1E0AB80", VA = "0x181E0B980")]
		public KGANBLIFABJ(NativeArray<TSrc> BLGDAGLONDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0")]
		public HOLOBDCFNEC<TSrc, TValue, TSelector> JMEGPAHCDCC<TSelector>() where TSelector : struct, FBMOAOBEIHP<TSrc, TValue>
		{
			return default(HOLOBDCFNEC<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct HOLOBDCFNEC<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, FBMOAOBEIHP<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> BLGDAGLONDD;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1E0B980", Offset = "0x1E0AB80", VA = "0x181E0B980")]
		public HOLOBDCFNEC(NativeArray<TSrc> BLGDAGLONDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x398A200", Offset = "0x3989400", VA = "0x18398A200")]
		public BCCLPJLADBH<TSrc, TValue, TSelector> OODPFADCJAK()
		{
			return default(BCCLPJLADBH<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct MLBPFDFMDGG<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, FBMOAOBEIHP<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> BLGDAGLONDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TSelector HBECAFNFMKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int MBGANDEDPDN;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TValue KOOHOOFHLKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x3F41190", Offset = "0x3F40390", VA = "0x183F41190")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int ABDHHHCLNNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA50680", Offset = "0xA4F880", VA = "0x180A50680")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int OECJFLODMOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3F41230", Offset = "0x3F40430", VA = "0x183F41230")]
		public MLBPFDFMDGG(NativeArray<TSrc> BLGDAGLONDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3F41220", Offset = "0x3F40420", VA = "0x183F41220")]
		public bool MOFBNJHOKHH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3F410B0", Offset = "0x3F402B0", VA = "0x183F410B0")]
		private TSrc HBDKKJFOMOL(int IBNKLDKLAGI)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct BCCLPJLADBH<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, FBMOAOBEIHP<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private MLBPFDFMDGG<TSrc, TValue, TSelector> BJFMPKFKBNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TValue MHDIJOBNCLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private int BHOMKDDOKFH;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public FBGAHKLAIHP JAJOMKCECEF
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x47AD720", Offset = "0x47AC920", VA = "0x1847AD720")]
			get
			{
				return default(FBGAHKLAIHP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue NIJDHFONFOA
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F20", Offset = "0x7B8120", VA = "0x1807B8F20")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, FBGAHKLAIHP range) KOOHOOFHLKE
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x47AD510", Offset = "0x47AC710", VA = "0x1847AD510")]
			get
			{
				return default((TValue, FBGAHKLAIHP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x47AD760", Offset = "0x47AC960", VA = "0x1847AD760")]
		public BCCLPJLADBH(NativeArray<TSrc> BLGDAGLONDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3428A80", Offset = "0x3427C80", VA = "0x183428A80")]
		public BCCLPJLADBH<TSrc, TValue, TSelector> LEPKJMNOIOO()
		{
			return default(BCCLPJLADBH<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x47AD5E0", Offset = "0x47AC7E0", VA = "0x1847AD5E0")]
		public bool MOFBNJHOKHH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x287BE20", Offset = "0x287B020", VA = "0x18287BE20")]
	public static KHKPCIGNIIO<T> JGEEDHKBCPF<T>(this NativeList<T> LBDHFFKKBHH) where T : struct
	{
		return default(KHKPCIGNIIO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x885BD0", VA = "0x1808869D0")]
	public static KHKPCIGNIIO<T> JGEEDHKBCPF<T>(this NativeArray<T> BLGDAGLONDD) where T : struct
	{
		return default(KHKPCIGNIIO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class BFHMOLJCMAH
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct CECGDNHJNGE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly NativeArray<T>.ReadOnly BLGDAGLONDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int BHOMKDDOKFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int IAJAGKNGOOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private T MHDIJOBNCLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T NDFMONDGIGG;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public FBGAHKLAIHP JAJOMKCECEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x4A12B70", Offset = "0x4A11D70", VA = "0x184A12B70")]
			get
			{
				return default(FBGAHKLAIHP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T NIJDHFONFOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x348A860", Offset = "0x3489A60", VA = "0x18348A860")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, FBGAHKLAIHP) KOOHOOFHLKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x4A12630", Offset = "0x4A11830", VA = "0x184A12630")]
			get
			{
				return default((T, FBGAHKLAIHP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4A12B80", Offset = "0x4A11D80", VA = "0x184A12B80")]
		public CECGDNHJNGE(NativeArray<T> BLGDAGLONDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x4A127A0", Offset = "0x4A119A0", VA = "0x184A127A0")]
		public CECGDNHJNGE<T> LEPKJMNOIOO()
		{
			return default(CECGDNHJNGE<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x4A129A0", Offset = "0x4A11BA0", VA = "0x184A129A0")]
		public bool MOFBNJHOKHH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x238A600", Offset = "0x2389800", VA = "0x18238A600")]
		public DMFAPINJNOL<T, TComparer> MMNOGHMLJPC<TComparer>([Optional] TComparer NLIDFOOGKJO) where TComparer : struct, IEqualityComparer<T>
		{
			return default(DMFAPINJNOL<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct DMFAPINJNOL<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly NativeArray<T>.ReadOnly BLGDAGLONDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int BHOMKDDOKFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int IAJAGKNGOOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T MHDIJOBNCLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private T NDFMONDGIGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TComparer NLIDFOOGKJO;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public FBGAHKLAIHP JAJOMKCECEF
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x4A12B70", Offset = "0x4A11D70", VA = "0x184A12B70")]
			get
			{
				return default(FBGAHKLAIHP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T NIJDHFONFOA
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x348A860", Offset = "0x3489A60", VA = "0x18348A860")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x50A5A80", Offset = "0x50A4C80", VA = "0x1850A5A80")]
		public DMFAPINJNOL(NativeArray<T>.ReadOnly BLGDAGLONDD, TComparer NLIDFOOGKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x50A58B0", Offset = "0x50A4AB0", VA = "0x1850A58B0")]
		public bool MOFBNJHOKHH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2648970", Offset = "0x2647B70", VA = "0x182648970")]
	public static CECGDNHJNGE<T> OODPFADCJAK<T>(this NativeArray<T> BLGDAGLONDD) where T : struct
	{
		return default(CECGDNHJNGE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface JHEJCFOGAIB
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class LGNGKMNKIAI
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct HPHCCDGNCEB<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class ENPEABMGBCM : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public HPHCCDGNCEB<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xAD72C0", Offset = "0xAD64C0", VA = "0x180AD72C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x342E550", Offset = "0x342D750", VA = "0x18342E550", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC90", Offset = "0x7BAE90", VA = "0x1807BBC90")]
		[DebuggerHidden]
		public ENPEABMGBCM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x342E350", Offset = "0x342D550", VA = "0x18342E350", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x342E500", Offset = "0x342D700", VA = "0x18342E500", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly Action<Protobuf> CKAOJFJJFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly MemoryStream DBPNOPAPBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly CodedInputStream NBOMMODGFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Protobuf ANBEFLCFDCJ;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int OECJFLODMOD
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x95D910", Offset = "0x95CB10", VA = "0x18095D910")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x398D510", Offset = "0x398C710", VA = "0x18398D510", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x398D550", Offset = "0x398C750", VA = "0x18398D550", Slot = "4")]
	[IteratorStateMachine(typeof(HPHCCDGNCEB<>.ENPEABMGBCM))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x398D640", Offset = "0x398C840", VA = "0x18398D640", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct DBBPCDPMPBO<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly byte[] ENIOLEEEFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Protobuf ANBEFLCFDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly MemoryStream DBPNOPAPBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly CodedOutputStream IPBKNGLJDAA;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5083770", Offset = "0x5082970", VA = "0x185083770", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct EHBCJICKJJC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MemoryStream DBPNOPAPBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CodedInputStream NBOMMODGFCA;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6204A50", Offset = "0x6203C50", VA = "0x186204A50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct GAOCGAEPKJM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly byte[] ENIOLEEEFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream DBPNOPAPBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedOutputStream IPBKNGLJDAA;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6204E90", Offset = "0x6204090", VA = "0x186204E90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class OODLAPDKGKE
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class JJBHIEMGBFG
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Flags]
public enum DJJOOGHMCKJ
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Main = 5,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal static class FPNFFJKJECO
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class HDGKNGCCBDL
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public HDGKNGCCBDL()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
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
