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
using RecRoom;
using Unity.Burst;
using Unity.Burst.CompilerServices;
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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
		public IsUnmanagedAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86C8880", Offset = "0x86C6E80", VA = "0x1886C8880")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD1900", Offset = "0xACFF00", VA = "0x180AD1900")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAD1940", Offset = "0xACFF40", VA = "0x180AD1940")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class EntityExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x86C7FB0", Offset = "0x86C65B0", VA = "0x1886C7FB0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JBMENPDAFLO : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	KKEEAGOOBJN OFOPPBFBONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface PACCCJKFPGP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HJIJIBBLPEJ(Entity JAPNANJIKLB, object INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EMCHPHCMGAH(Entity JAPNANJIKLB, object INEEADCBMPK, [Out] bool CBEBNIBBCLE);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FADAEHCBFDL(Entity JAPNANJIKLB);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class HMFADGHHJDD<TComponentData, TValue> : DBBNEEJIBLG<TValue>, IDisposable where TComponentData : struct, JBMENPDAFLO
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class ADJDHJFJBIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<(object token, TValue value)> BBBJHCKNPGO;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int EEGOGBABKAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x45C9C40", Offset = "0x45C8240", VA = "0x1845C9C40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5328B10", Offset = "0x5327110", VA = "0x185328B10")]
		public bool LGMHGFADLHI([Out] TValue KOPHBHGIACG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5328C00", Offset = "0x5327200", VA = "0x185328C00")]
		public void MEFAAGOGBHI(object INEEADCBMPK, TValue KOPHBHGIACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x53289B0", Offset = "0x5326FB0", VA = "0x1853289B0")]
		public bool CBELOMAGFLH(object INEEADCBMPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5328A30", Offset = "0x5327030", VA = "0x185328A30")]
		public int CKEBEBFKOFK(object INEEADCBMPK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5328CB0", Offset = "0x53272B0", VA = "0x185328CB0")]
		public ADJDHJFJBIA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stack<ADJDHJFJBIA> OPGBBELBCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private DAKCEKOKKEA<KKEEAGOOBJN, ADJDHJFJBIA> CEKMOPNAGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EntityManager OLNPNJLIAFG;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5175F80", Offset = "0x5174580", VA = "0x185175F80")]
	public HMFADGHHJDD(EntityManager OLNPNJLIAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5175C50", Offset = "0x5174250", VA = "0x185175C50", Slot = "4")]
	public void HJIJIBBLPEJ(Entity JAPNANJIKLB, object INEEADCBMPK, TValue KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5175AB0", Offset = "0x51740B0", VA = "0x185175AB0", Slot = "5")]
	public bool EMCHPHCMGAH(Entity JAPNANJIKLB, object INEEADCBMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5175D90", Offset = "0x5174390", VA = "0x185175D90", Slot = "6")]
	public bool LGMHGFADLHI(Entity JAPNANJIKLB, [Out] TValue KOPHBHGIACG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5175A90", Offset = "0x5174090", VA = "0x185175A90", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5175920", Offset = "0x5173F20", VA = "0x185175920")]
	private void BDHJIGKONLC(ADJDHJFJBIA PJIOOCPKNEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x51759B0", Offset = "0x5173FB0", VA = "0x1851759B0")]
	private bool CLNCABPKICJ(Entity JAPNANJIKLB, [Out] KKEEAGOOBJN MNHLJANEAIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5175830", Offset = "0x5173E30", VA = "0x185175830")]
	private void AMMLOAPAPHE(Entity JAPNANJIKLB, KKEEAGOOBJN MNHLJANEAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5175A70", Offset = "0x5174070", VA = "0x185175A70")]
	private bool CODPKOCLGDN(KKEEAGOOBJN MNHLJANEAIO, [Out] ADJDHJFJBIA PJIOOCPKNEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5175E90", Offset = "0x5174490", VA = "0x185175E90")]
	private ADJDHJFJBIA MDPGJPPEMPA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DBBNEEJIBLG<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HJIJIBBLPEJ(Entity JAPNANJIKLB, object INEEADCBMPK, TValue KOPHBHGIACG);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EMCHPHCMGAH(Entity JAPNANJIKLB, object INEEADCBMPK);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LGMHGFADLHI(Entity JAPNANJIKLB, [Out] TValue KOPHBHGIACG);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KKEEAGOOBJN : EDMHOEDPFHJ, IEquatable<KKEEAGOOBJN>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly KKEEAGOOBJN IDBBECHCNHL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int GKFLGCDAIDH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xDB2450", Offset = "0xDB0A50", VA = "0x180DB2450", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x15C7B70", Offset = "0x15C6170", VA = "0x1815C7B70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int AMOFDJHKCMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x30A0350", Offset = "0x309E950", VA = "0x1830A0350", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x30A0340", Offset = "0x309E940", VA = "0x1830A0340", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x86C82E0", Offset = "0x86C68E0", VA = "0x1886C82E0", Slot = "8")]
	public bool Equals(KKEEAGOOBJN AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x86C8330", Offset = "0x86C6930", VA = "0x1886C8330", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GDBFCMPLHHG<THasTokensTag> : PACCCJKFPGP, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Dictionary<Entity, KKEEAGOOBJN> NGMPBOLCEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Stack<HashSet<object>> OPGBBELBCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private DAKCEKOKKEA<KKEEAGOOBJN, HashSet<object>> CEKMOPNAGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EntityManager OLNPNJLIAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EntityCommandBufferSystem LPDGJCPFNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool AJNGKKLNKMJ;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x50E7780", Offset = "0x50E5D80", VA = "0x1850E7780")]
	public GDBFCMPLHHG(EntityManager OLNPNJLIAFG, EntityCommandBufferSystem LPDGJCPFNGO, IPHNFELODMJ JJFAONLFOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x50E6330", Offset = "0x50E4930", VA = "0x1850E6330", Slot = "4")]
	public bool HJIJIBBLPEJ(Entity JAPNANJIKLB, object INEEADCBMPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x50E53E0", Offset = "0x50E39E0", VA = "0x1850E53E0", Slot = "5")]
	public bool EMCHPHCMGAH(Entity JAPNANJIKLB, object INEEADCBMPK, [Out] bool CBEBNIBBCLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x50E5AA0", Offset = "0x50E40A0", VA = "0x1850E5AA0", Slot = "6")]
	public bool FADAEHCBFDL(Entity JAPNANJIKLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x50E5BE0", Offset = "0x50E41E0", VA = "0x1850E5BE0", Slot = "8")]
	public bool FADAEHCBFDL(KKEEAGOOBJN MNHLJANEAIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x50E5320", Offset = "0x50E3920", VA = "0x1850E5320", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x50E4DE0", Offset = "0x50E33E0", VA = "0x1850E4DE0")]
	private void BDHJIGKONLC(HashSet<object> PJIOOCPKNEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x50E5140", Offset = "0x50E3740", VA = "0x1850E5140")]
	private bool CLNCABPKICJ(Entity JAPNANJIKLB, [Out] KKEEAGOOBJN MNHLJANEAIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x50E6730", Offset = "0x50E4D30", VA = "0x1850E6730")]
	private bool IGKJDBLJFBC(Entity JAPNANJIKLB, [Out] KKEEAGOOBJN MNHLJANEAIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x50E71B0", Offset = "0x50E57B0", VA = "0x1850E71B0")]
	private void OEONIDCAOPP(Entity JAPNANJIKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x50E6B90", Offset = "0x50E5190", VA = "0x1850E6B90")]
	private void KDHAKGLLCEO(Entity JAPNANJIKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x50E5EF0", Offset = "0x50E44F0", VA = "0x1850E5EF0")]
	private void GJFPJHGFNJB(Entity JAPNANJIKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x50E4D00", Offset = "0x50E3300", VA = "0x1850E4D00")]
	private void AMMLOAPAPHE(Entity JAPNANJIKLB, KKEEAGOOBJN MNHLJANEAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x50E6E10", Offset = "0x50E5410", VA = "0x1850E6E10")]
	private bool LCMEJMGHBBL(KKEEAGOOBJN MNHLJANEAIO, [Out] HashSet<object> PJIOOCPKNEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x50E6FD0", Offset = "0x50E55D0", VA = "0x1850E6FD0")]
	private HashSet<object> MDPGJPPEMPA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class ANOHJNGKEJP
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct ENFNKMGHFOJ : GEBNFLCLKHG<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x86C7FA0", Offset = "0x86C65A0", VA = "0x1886C7FA0")]
	public float OGFENCLDCDN([In] float3 KOPHBHGIACG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x86C7FA0", Offset = "0x86C65A0", VA = "0x1886C7FA0", Slot = "4")]
	private float CGFCLIHDMEL([In] float3 KOPHBHGIACG)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct PIODJMMADMC : GEBNFLCLKHG<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x86C8900", Offset = "0x86C6F00", VA = "0x1886C8900")]
	public float OGFENCLDCDN([In] float3 KOPHBHGIACG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x86C8900", Offset = "0x86C6F00", VA = "0x1886C8900", Slot = "4")]
	private float CGFCLIHDMEL([In] float3 KOPHBHGIACG)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct NIEHKFIBADB : GEBNFLCLKHG<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x86C8870", Offset = "0x86C6E70", VA = "0x1886C8870")]
	public float OGFENCLDCDN([In] float3 KOPHBHGIACG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x86C8870", Offset = "0x86C6E70", VA = "0x1886C8870", Slot = "4")]
	private float CGFCLIHDMEL([In] float3 KOPHBHGIACG)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct MMOBJJEPFON : GEBNFLCLKHG<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x14B5E40", Offset = "0x14B4440", VA = "0x1814B5E40")]
	public int OGFENCLDCDN([In] int3 KOPHBHGIACG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x14B5E40", Offset = "0x14B4440", VA = "0x1814B5E40", Slot = "4")]
	private int FGNOCLMGHJF([In] int3 KOPHBHGIACG)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct NAHFCNEACBH : GEBNFLCLKHG<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1416890", Offset = "0x1414E90", VA = "0x181416890")]
	public int OGFENCLDCDN([In] int3 KOPHBHGIACG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1416890", Offset = "0x1414E90", VA = "0x181416890", Slot = "4")]
	private int FGNOCLMGHJF([In] int3 KOPHBHGIACG)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct LLGNLCHPLEN : GEBNFLCLKHG<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xFF7C50", Offset = "0xFF6250", VA = "0x180FF7C50")]
	public int OGFENCLDCDN([In] int3 KOPHBHGIACG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xFF7C50", Offset = "0xFF6250", VA = "0x180FF7C50", Slot = "4")]
	private int FGNOCLMGHJF([In] int3 KOPHBHGIACG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class AJLKLPOKMCB : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x241B440", Offset = "0x2419A40", VA = "0x18241B440")]
	public AJLKLPOKMCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class CJOAGKPBBIM : SystemBase, KFBNOAGGEDA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string EEABAFMMHKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x86C77C0", Offset = "0x86C5DC0", VA = "0x1886C77C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3BDFAC0", Offset = "0x3BDE0C0", VA = "0x183BDFAC0")]
	public void MJEFFIBDBKA<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3BDFAC0", Offset = "0x3BDE0C0", VA = "0x183BDFAC0")]
	public void PJOAHHAIPDE<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x86C7770", Offset = "0x86C5D70", VA = "0x1886C7770")]
	public JobHandle IAHJNLCEMIF(ReadOnlySpan<int> BHBGCICFLHE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3BDF6C0", Offset = "0x3BDDCC0", VA = "0x183BDF6C0")]
	public JobHandle CPCKBMKGKGB<T>() where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x86C76B0", Offset = "0x86C5CB0", VA = "0x1886C76B0")]
	public JobHandle CPCKBMKGKGB(ReadOnlySpan<int> BHBGCICFLHE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3BDED60", Offset = "0x3BDD360", VA = "0x183BDED60")]
	public void ADNINFOLDFK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3BDEDE0", Offset = "0x3BDD3E0", VA = "0x183BDEDE0")]
	public JobHandle ADNINFOLDFK<T>(JobHandle MNHLJANEAIO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x86C7640", Offset = "0x86C5C40", VA = "0x1886C7640")]
	public JobHandle ADNINFOLDFK(ReadOnlySpan<int> BHBGCICFLHE, JobHandle MNHLJANEAIO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3BDED60", Offset = "0x3BDD360", VA = "0x183BDED60")]
	public void EPLHPJMMAJJ<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3BDF760", Offset = "0x3BDDD60", VA = "0x183BDF760")]
	public JobHandle EPLHPJMMAJJ<T>(JobHandle MNHLJANEAIO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x86C7700", Offset = "0x86C5D00", VA = "0x1886C7700")]
	public JobHandle EPLHPJMMAJJ(Span<int> BHBGCICFLHE, JobHandle MNHLJANEAIO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3BDFB10", Offset = "0x3BDE110", VA = "0x183BDFB10")]
	public ComponentDataFromEntity PCFEGILDEMI<T>(bool MJCFBEAEKHN = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x86C7810", Offset = "0x86C5E10", VA = "0x1886C7810")]
	public ComponentDataFromEntity PCFEGILDEMI(int FHIPANGHNKE, bool MJCFBEAEKHN = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3BDF620", Offset = "0x3BDDC20", VA = "0x183BDF620")]
	public SharedComponentIndexFromEntity<T> ANPGBHCJEIO<T>() where T : ISharedComponentData
	{
		return default(SharedComponentIndexFromEntity<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x86C78D0", Offset = "0x86C5ED0", VA = "0x1886C78D0")]
	[BurstCompatible]
	public ComponentTypeHandle PEHANGBOBJH(ComponentType PMNAAAFILCL)
	{
		return default(ComponentTypeHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x86C77F0", Offset = "0x86C5DF0", VA = "0x1886C77F0")]
	public EntityExistenceLookupByEntity JAJBGJJFAMC()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x86C7930", Offset = "0x86C5F30", VA = "0x1886C7930", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3BDF9A0", Offset = "0x3BDDFA0", VA = "0x183BDF9A0")]
	public bool IKGKBJKLKJB<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "7")]
	protected sealed override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x241B440", Offset = "0x2419A40", VA = "0x18241B440")]
	protected CJOAGKPBBIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class KLLJINMBLNE : CJOAGKPBBIM
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x86C8380", Offset = "0x86C6980", VA = "0x1886C8380", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x241B440", Offset = "0x2419A40", VA = "0x18241B440")]
	protected KLLJINMBLNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class DDMGJEDPPFL
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class CBNLGMGDLAB : EntityCommandBufferSystem, KFBNOAGGEDA
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private IPHNFELODMJ EANLMHBELEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xF29610", Offset = "0xF27C10", VA = "0x180F29610")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x86C7610", Offset = "0x86C5C10", VA = "0x1886C7610")]
	public CBNLGMGDLAB(IPHNFELODMJ AMCHCCAPJNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface GEBNFLCLKHG<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo OGFENCLDCDN([In] TFrom KOPHBHGIACG);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface KHLKKKJEKNC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JICGEGLPHON(T KOPHBHGIACG);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct JMLDMBHDFLA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> MEJIKACDFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer NAJBNKLGADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public ComponentTypes DGCBDOMMKIK;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x86C81F0", Offset = "0x86C67F0", VA = "0x1886C81F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct EFFCHDCMKEF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> MEJIKACDFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer NAJBNKLGADP;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x86C7E80", Offset = "0x86C6480", VA = "0x1886C7E80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct EHFHGKLKGAC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> MEJIKACDFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer NAJBNKLGADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public ComponentType PMNAAAFILCL;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x86C7F20", Offset = "0x86C6520", VA = "0x1886C7F20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[BurstCompile]
internal struct EAEOJMKEBPC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> MEJIKACDFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> CDDIADBJAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer NAJBNKLGADP;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4AF6460", Offset = "0x4AF4A60", VA = "0x184AF6460", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct ACJNPOJMNFM<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> MEJIKACDFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<T> LGMBOCEBOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer NAJBNKLGADP;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal struct ICDKMJGNLFD<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<Entity> MEJIKACDFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public T KOPHBHGIACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EntityCommandBuffer NAJBNKLGADP;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct IJDODBHAMFN<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, GEBNFLCLKHG<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<TFrom> LIIIHGKAFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<TTo> FJBIFAPEPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public TMap PMBBLAOPHON;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct MBABCEJGBBO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity HLGILCMMNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> LIIIHGKAFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeArray<byte> FJBIFAPEPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int FOAPODGGKFC;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x86C8640", Offset = "0x86C6C40", VA = "0x1886C8640", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct PIEIIKKCCLE<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> PNJOKGLIHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<Entity> LIIIHGKAFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<T> PNGLIAEFJID;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct PJHODNHEAMB<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, GEBNFLCLKHG<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<TFrom> DLHFHFIKOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[WriteOnly]
	public NativeList<TTo> FJBIFAPEPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public TMap PMBBLAOPHON;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct ENMIADDCPAP<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> LDLCBPGOEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> APFGKPFDDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> PBMJLMPCJGP;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct MIPIELLDINN<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public ComponentDataFromEntity<T> LDLCBPGOEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<Entity> APFGKPFDDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<bool> PBMJLMPCJGP;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5A177F0", Offset = "0x5A15DF0", VA = "0x185A177F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct EAFIMENMABO<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<T> LIIIHGKAFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<T> PNGLIAEFJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<T> OAJFEAKGCDG;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4AF7390", Offset = "0x4AF5990", VA = "0x184AF7390", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct NIOIPKAODHG<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : GEBNFLCLKHG<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<TFrom> LIIIHGKAFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public NativeList<TFrom> PNGLIAEFJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeParallelHashSet<TTo> OAJFEAKGCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TMap PMBBLAOPHON;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct DGGBINAAHIN<T, TPredicate> : IJob where T : struct where TPredicate : struct, KHLKKKJEKNC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> LIIIHGKAFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<Entity> OMLMEDODGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<Entity> AFPLEDBOBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate PMBBLAOPHON;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct HMMCACKPOGA<T, TPredicate> : IJob where T : struct where TPredicate : struct, KHLKKKJEKNC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> LIIIHGKAFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> PNGLIAEFJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TPredicate PMBBLAOPHON;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct CPIKGBHHCGI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity LDLCBPGOEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> APFGKPFDDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> ALKKPPAFKNJ;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x86C7950", Offset = "0x86C5F50", VA = "0x1886C7950", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct BKLKDBOANOC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[ReadOnly]
	public ComponentDataFromEntity LDLCBPGOEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<Entity> APFGKPFDDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<Entity> ALKKPPAFKNJ;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x86C7580", Offset = "0x86C5B80", VA = "0x1886C7580", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class JAFJKMDPPNB
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class NMEOGJHMMCL
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3F52B10", Offset = "0x3F51110", VA = "0x183F52B10")]
	public static bool PCDACLBJJLE<T>(this NativeArray<Entity> APFGKPFDDGI, EntityManager OLNPNJLIAFG, Allocator EEDCBHBBPKF = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class FJBDJMNIIBM
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class NOOADOHFAPB<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		public NOOADOHFAPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class CIPFKNMBJPO<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public CIPFKNMBJPO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly List<Func<JobHandle, JobHandle>> OEKNGABJGIG;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x86C7FD0", Offset = "0x86C65D0", VA = "0x1886C7FD0")]
	public FJBDJMNIIBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class EKOMMENNCNH
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class JJCJDFMFBDA
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct IKACJFLIGND<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct EDCPGDHKAOP<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal IKACJFLIGND<TFrom> BEBONNCPGLF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator EEDCBHBBPKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeArray<TFrom> PPEFJKBNOEP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct IFJLLNBEJGA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct NGGLKBHJGOP<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal IFJLLNBEJGA<TFrom> BEBONNCPGLF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator EEDCBHBBPKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeList<TFrom> PPEFJKBNOEP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct MCMPAMOOBNJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct EPGKNBDAFHG<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal MCMPAMOOBNJ<TFrom> BEBONNCPGLF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator EEDCBHBBPKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeArrayAsync<TFrom> PPEFJKBNOEP;
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct NHOGJEHLKHO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public struct JAHIFAGDBKA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			internal NHOGJEHLKHO<TFrom> BEBONNCPGLF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal Allocator EEDCBHBBPKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal NativeListAsync<TFrom> PPEFJKBNOEP;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class DNNEJEJPFKD
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class FPBEJBDJIBE
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3DC57F0", Offset = "0x3DC3DF0", VA = "0x183DC57F0")]
	public static NativeList<T> PCIKBNIMDHO<T>(this NativeArray<T> MHEDPFPLJMF, Allocator EEDCBHBBPKF = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class FKMHPNHMOHB
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class DHNELJFBLDE
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3C2C160", Offset = "0x3C2A760", VA = "0x183C2C160")]
	[DPPBNBGFJCC]
	public static JobHandle CAEHGIOFMCH<T>(this EntityCommandBufferSystem LPDGJCPFNGO, NativeArray<Entity> MEJIKACDFLB, NativeArray<T> CDDIADBJAOB) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3C2BEA0", Offset = "0x3C2A4A0", VA = "0x183C2BEA0")]
	[DPPBNBGFJCC]
	public static JobHandle CAEHGIOFMCH<T>(this EntityCommandBufferSystem LPDGJCPFNGO, NativeArrayAsync<Entity> MEJIKACDFLB, NativeArrayAsync<T> CDDIADBJAOB, [Optional] JobHandle BPIOJMHPPEL) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3C2BD80", Offset = "0x3C2A380", VA = "0x183C2BD80")]
	[DPPBNBGFJCC]
	public static JobHandle CAEHGIOFMCH<T>(this EntityCommandBufferSystem LPDGJCPFNGO, NativeArray<Entity> MEJIKACDFLB, [Optional] JobHandle BPIOJMHPPEL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x86C79E0", Offset = "0x86C5FE0", VA = "0x1886C79E0")]
	[DPPBNBGFJCC]
	public static JobHandle CAEHGIOFMCH(this EntityCommandBufferSystem LPDGJCPFNGO, NativeArray<Entity> MEJIKACDFLB, ComponentTypes DGCBDOMMKIK, [Optional] JobHandle BPIOJMHPPEL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x86C7B50", Offset = "0x86C6150", VA = "0x1886C7B50")]
	[DPPBNBGFJCC]
	public static JobHandle CAEHGIOFMCH(this EntityCommandBufferSystem LPDGJCPFNGO, EntityCommandBuffer NAJBNKLGADP, NativeArray<Entity> MEJIKACDFLB, ComponentTypes DGCBDOMMKIK, [Optional] JobHandle BPIOJMHPPEL)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class HCJJEMIGKAE
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class LPCFLKBKMFK
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x86C83B0", Offset = "0x86C69B0", VA = "0x1886C83B0")]
	[DPPBNBGFJCC]
	public static JobHandle LAFMOFCEIIF(this EntityCommandBufferSystem LPDGJCPFNGO, NativeList<Entity> MEJIKACDFLB, [Optional] JobHandle BPIOJMHPPEL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x86C8540", Offset = "0x86C6B40", VA = "0x1886C8540")]
	[DPPBNBGFJCC]
	public static JobHandle LAFMOFCEIIF(this EntityCommandBufferSystem LPDGJCPFNGO, NativeArrayAsync<Entity> MEJIKACDFLB)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class GHJFCHPNELM
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3DDB3B0", Offset = "0x3DD99B0", VA = "0x183DDB3B0")]
	public static void NFBEJCHJHFC<T>(this EntityCommandBufferSystem LPDGJCPFNGO, EntityQuery PHFHKEANJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3DDB770", Offset = "0x3DD9D70", VA = "0x183DDB770")]
	[DPPBNBGFJCC]
	public static JobHandle OGPCOGNBDAH<T>(this EntityCommandBufferSystem LPDGJCPFNGO, NativeArrayAsync<Entity> MEJIKACDFLB, [Optional] JobHandle BPIOJMHPPEL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x86C8060", Offset = "0x86C6660", VA = "0x1886C8060")]
	[DPPBNBGFJCC]
	public static JobHandle OGPCOGNBDAH(this EntityCommandBufferSystem LPDGJCPFNGO, NativeArrayAsync<Entity> MEJIKACDFLB, ComponentType PMNAAAFILCL, [Optional] JobHandle BPIOJMHPPEL)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class JIIOOEPBLAM
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3E557E0", Offset = "0x3E53DE0", VA = "0x183E557E0")]
	[DPPBNBGFJCC]
	public static JobHandle BMCKLJJJKAO<T>(this EntityCommandBufferSystem LPDGJCPFNGO, NativeArray<Entity> MEJIKACDFLB, NativeArray<T> CDDIADBJAOB, JobHandle BPIOJMHPPEL) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class BFDNBGONFIB
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class CPPFNGDHCGD
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class DJPJFBPDGOF
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3C2CA20", Offset = "0x3C2B020", VA = "0x183C2CA20")]
	public static NativeArray<T> OKJHNEGPEKH<T>(this NativeList<Entity> MHEDPFPLJMF, EntityManager OLNPNJLIAFG, Allocator EEDCBHBBPKF = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3C2C6A0", Offset = "0x3C2ACA0", VA = "0x183C2C6A0")]
	public static NativeArray<T> OKJHNEGPEKH<T>(this NativeArray<Entity> MHEDPFPLJMF, EntityManager OLNPNJLIAFG, Allocator EEDCBHBBPKF = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x86C7CA0", Offset = "0x86C62A0", VA = "0x1886C7CA0")]
	public static NativeArray<Entity> MMOGPCLMDIN(this NativeArray<Entity> MHEDPFPLJMF, EntityManager OLNPNJLIAFG, ComponentType PMNAAAFILCL, Allocator EEDCBHBBPKF = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3C2C5A0", Offset = "0x3C2ABA0", VA = "0x183C2C5A0")]
	public static NativeArray<T> GCIPLBLKDFJ<T>(this NativeArray<Entity> MHEDPFPLJMF, EntityManager OLNPNJLIAFG, Allocator EEDCBHBBPKF = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class HOPEMGLENJG
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct JJFHEKMIBGI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct FNLJKIODPBI<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public JJFHEKMIBGI<TFrom> PPEFJKBNOEP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator EEDCBHBBPKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArray<TFrom> LIIIHGKAFCA;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct JBOMBOPBIIH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct BCEFEDDLCJI<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public JBOMBOPBIIH<TFrom> PPEFJKBNOEP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator EEDCBHBBPKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeArrayAsync<TFrom> LIIIHGKAFCA;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct HNLLJBANLNN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public struct DLHKJMFOBJG<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public HNLLJBANLNN<TFrom> PPEFJKBNOEP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator EEDCBHBBPKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeListAsync<TFrom> LIIIHGKAFCA;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class FONHACGMJDE
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class FOGBGKHIPDI
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct CMBDPJEIJMP : GEBNFLCLKHG<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> CFGKIEMOCOD;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x86C7940", Offset = "0x86C5F40", VA = "0x1886C7940")]
		[BurstCompatible]
		public Entity OGFENCLDCDN([In] Entity KOPHBHGIACG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x86C7940", Offset = "0x86C5F40", VA = "0x1886C7940", Slot = "4")]
		private Entity LBNDGKBCOEP([In] Entity KOPHBHGIACG)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class OEPGAHJJPIK
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct DJFKCBKEFHE<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x466DE00", Offset = "0x466C400", VA = "0x18466DE00", Slot = "4")]
		public int Compare((TKey, TValue) GBNAKFLHCOE, (TKey, TValue) ODEKEFJCIIL)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3F7C620", Offset = "0x3F7AC20", VA = "0x183F7C620")]
	public static void PBLOBOGDKOD<TKey, TValue>(NativeList<TKey> PHHFFFKMIOP, NativeList<TValue> LGMBOCEBOMM) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3F7C460", Offset = "0x3F7AA60", VA = "0x183F7C460")]
	public static void PBLOBOGDKOD<TKey, TValue>(NativeArray<TKey> PHHFFFKMIOP, NativeArray<TValue> LGMBOCEBOMM) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3F7C890", Offset = "0x3F7AE90", VA = "0x183F7C890")]
	public static void PBLOBOGDKOD<TKey, TValue, U>(NativeArray<TKey> PHHFFFKMIOP, NativeArray<TValue> LGMBOCEBOMM, U LFKNOMIKBIA) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class OFLPGCHNAIB
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct HNHINFDBLMO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator EEDCBHBBPKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<Entity> OMLMEDODGGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> LIIIHGKAFCA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct FDCPBGAKAAF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator EEDCBHBBPKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeList<Entity> OMLMEDODGGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArray<T> LIIIHGKAFCA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct GBKLABHDLIN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator EEDCBHBBPKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArrayAsync<Entity> OMLMEDODGGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArrayAsync<T> LIIIHGKAFCA;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class DBNMPLLOOCF
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class NHGDGIGNMCM
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct FBMMGEPNJMH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator EEDCBHBBPKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArray<T> LIIIHGKAFCA;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct KCOJLENBPCE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator EEDCBHBBPKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeList<T> LIIIHGKAFCA;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct KHOMAIHABMK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator EEDCBHBBPKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<T> LIIIHGKAFCA;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct NEEPFEPAKKN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Allocator EEDCBHBBPKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NativeListAsync<T> LIIIHGKAFCA;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class NNKEEABAKML
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class LMGIMAGPNDD
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3EBC350", Offset = "0x3EBA950", VA = "0x183EBC350")]
	public static NativeList<Entity> KIILMPKAKPA<T>(this NativeList<Entity> APFGKPFDDGI, EntityManager OLNPNJLIAFG, Allocator EEDCBHBBPKF = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3EBBBD0", Offset = "0x3EBA1D0", VA = "0x183EBBBD0")]
	public static NativeList<Entity> KIILMPKAKPA<T>(this NativeArray<Entity> APFGKPFDDGI, EntityManager OLNPNJLIAFG, Allocator EEDCBHBBPKF = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class EAFJHNDHFBP
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3C48EA0", Offset = "0x3C474A0", VA = "0x183C48EA0")]
	public static NativeList<Entity> IJOBNKLGLFM<T>(this NativeArray<Entity> APFGKPFDDGI, EntityManager OLNPNJLIAFG, Allocator EEDCBHBBPKF = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class GEIDDLLLABM
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public readonly struct DDGMHPJPGKC<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> GHKPAFFMJAO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public readonly struct EMIAJBBCOPB<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> GHKPAFFMJAO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public readonly struct BAENDOKFCOP<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, GEBNFLCLKHG<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly NativeArray<TSrc> GHKPAFFMJAO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct JPDAOLGNJEI<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, GEBNFLCLKHG<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly NativeArray<TSrc> GHKPAFFMJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TSelector JHJIOCIGOMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int PMIGBJGNLLP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct CACLNIHDGPK<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, GEBNFLCLKHG<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private JPDAOLGNJEI<TSrc, TValue, TSelector> DPOHFMKDFJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TValue ADOFEFNJALJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int NDMFOILAFKD;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class DFMHCDHDHEO
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct MBNCMMPBGKK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<T> GHKPAFFMJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int NDMFOILAFKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int IHFNFBHFEGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private T ADOFEFNJALJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T MMECEGJNALC;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public NDDIGIFKAJC GIOHEJMMFMM
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x59F26C0", Offset = "0x59F0CC0", VA = "0x1859F26C0")]
			get
			{
				return default(NDDIGIFKAJC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public T BNLEKDBHAIH
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public (T, NDDIGIFKAJC) MIECLPJBKEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x59F23E0", Offset = "0x59F09E0", VA = "0x1859F23E0")]
			get
			{
				return default((T, NDDIGIFKAJC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x59F26F0", Offset = "0x59F0CF0", VA = "0x1859F26F0")]
		public MBNCMMPBGKK(NativeArray<T> GHKPAFFMJAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4C2F5D0", Offset = "0x4C2DBD0", VA = "0x184C2F5D0")]
		public MBNCMMPBGKK<T> ABGODHCJODA()
		{
			return default(MBNCMMPBGKK<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x59F2000", Offset = "0x59F0600", VA = "0x1859F2000")]
		public bool DDPDBHDONME()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4540A80", Offset = "0x453F080", VA = "0x184540A80")]
		public BKJFCGBLFED<T, TComparer> DIHOKGCIACF<TComparer>([Optional] TComparer LFKNOMIKBIA) where TComparer : struct, IEqualityComparer<T>
		{
			return default(BKJFCGBLFED<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct BKJFCGBLFED<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly NativeArray<T> GHKPAFFMJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int NDMFOILAFKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int IHFNFBHFEGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private T ADOFEFNJALJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private T MMECEGJNALC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TComparer LFKNOMIKBIA;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public NDDIGIFKAJC GIOHEJMMFMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x59F26C0", Offset = "0x59F0CC0", VA = "0x1859F26C0")]
			get
			{
				return default(NDDIGIFKAJC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T BNLEKDBHAIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public (T value, NDDIGIFKAJC range) MIECLPJBKEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x59F23E0", Offset = "0x59F09E0", VA = "0x1859F23E0")]
			get
			{
				return default((T, NDDIGIFKAJC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6AF98D0", Offset = "0x6AF7ED0", VA = "0x186AF98D0")]
		public BKJFCGBLFED(NativeArray<T> GHKPAFFMJAO, TComparer LFKNOMIKBIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3DC5040", Offset = "0x3DC3640", VA = "0x183DC5040")]
		public BKJFCGBLFED<T, TComparer> ABGODHCJODA()
		{
			return default(BKJFCGBLFED<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6AF9740", Offset = "0x6AF7D40", VA = "0x186AF9740")]
		public bool DDPDBHDONME()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3C23C00", Offset = "0x3C22200", VA = "0x183C23C00")]
	public static MBNCMMPBGKK<T> ILJDODPOJNM<T>(this NativeArray<T> GHKPAFFMJAO) where T : struct
	{
		return default(MBNCMMPBGKK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface AGEBLJPMMAJ
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class HCIOHENPONM
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct OADIMHBBEGI<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class MCLEFPDBOFA : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public OADIMHBBEGI<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xBF19C0", Offset = "0xBEFFC0", VA = "0x180BF19C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x511BD80", Offset = "0x511A380", VA = "0x18511BD80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
		[DebuggerHidden]
		public MCLEFPDBOFA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x59F5470", Offset = "0x59F3A70", VA = "0x1859F5470", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x59F5620", Offset = "0x59F3C20", VA = "0x1859F5620", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly Action<Protobuf> LGEIICDGIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MemoryStream ICLFABGEPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CodedInputStream MHECJCKCFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Protobuf LMKHOCAFFFE;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly int AOCLJDLKDLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAFC970", Offset = "0xAFAF70", VA = "0x180AFC970")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5B8AEF0", Offset = "0x5B894F0", VA = "0x185B8AEF0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5B8AF30", Offset = "0x5B89530", VA = "0x185B8AF30", Slot = "4")]
	[IteratorStateMachine(typeof(OADIMHBBEGI<>.MCLEFPDBOFA))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5B8B020", Offset = "0x5B89620", VA = "0x185B8B020", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct IKMGPHKPKNO<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly byte[] DNGAEEFBGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Protobuf LMKHOCAFFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream ICLFABGEPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedOutputStream EMEBHHIHBEE;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x529BA70", Offset = "0x529A070", VA = "0x18529BA70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct BDDEAEPFBHF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream ICLFABGEPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedInputStream MHECJCKCFLP;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x86C7540", Offset = "0x86C5B40", VA = "0x1886C7540", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct MEKCCMHNCPM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] DNGAEEFBGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly MemoryStream ICLFABGEPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly CodedOutputStream EMEBHHIHBEE;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x86C8740", Offset = "0x86C6D40", VA = "0x1886C8740", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class HNPGGEEAABD
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class PEKFOMPMBMG
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[Flags]
public enum OBNGOJICLOM
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Main = 5,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class PHADLFKNANO
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class IDEENHLMJMC
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public IDEENHLMJMC()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
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
