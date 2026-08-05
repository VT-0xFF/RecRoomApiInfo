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
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x7374EE0", Offset = "0x73740E0", VA = "0x187374EE0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CIFJBMBLDLJ : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	DCBMCJIAAJO HPBJMIAFNBO
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
public interface BGDBFOHPBAA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ONGAKBOCCMI(Entity KPFAGKHHMMH, object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MHJCEIPBPND(Entity KPFAGKHHMMH, object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PHLKHHGLLGE(Entity KPFAGKHHMMH);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class KDMLBFEDMDL<TComponentData, TValue> : BCNGLGLNCJE<TValue>, IDisposable where TComponentData : struct, CIFJBMBLDLJ
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class CNLPMBODDOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> AFNGOKKOBOC;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int BIMHEMDFFPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3C34EB0", Offset = "0x3C340B0", VA = "0x183C34EB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5888DA0", Offset = "0x5887FA0", VA = "0x185888DA0")]
		public bool JCIDPCIHEEI([Out] TValue OMEFCJCOLII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5888C10", Offset = "0x5887E10", VA = "0x185888C10")]
		public void CKLHJOINNOK(object BCOHKLCJCPM, TValue OMEFCJCOLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5888CF0", Offset = "0x5887EF0", VA = "0x185888CF0")]
		public bool GMODDBABBFK(object BCOHKLCJCPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5888B30", Offset = "0x5887D30", VA = "0x185888B30")]
		public int CGOOINFGAFC(object BCOHKLCJCPM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5888EB0", Offset = "0x58880B0", VA = "0x185888EB0")]
		public CNLPMBODDOC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<CNLPMBODDOC> MEOGNCNAPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private LMLIDGCPNKC<DCBMCJIAAJO, CNLPMBODDOC> AMNLOOLFEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager ACAAJNNIMJL;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x49265D0", Offset = "0x49257D0", VA = "0x1849265D0")]
	public KDMLBFEDMDL(EntityManager ACAAJNNIMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4926350", Offset = "0x4925550", VA = "0x184926350", Slot = "4")]
	public void ONGAKBOCCMI(Entity KPFAGKHHMMH, object BCOHKLCJCPM, TValue OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4926160", Offset = "0x4925360", VA = "0x184926160", Slot = "5")]
	public bool MHJCEIPBPND(Entity KPFAGKHHMMH, object BCOHKLCJCPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4925F90", Offset = "0x4925190", VA = "0x184925F90", Slot = "6")]
	public bool JCIDPCIHEEI(Entity KPFAGKHHMMH, [Out] TValue OMEFCJCOLII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4925F50", Offset = "0x4925150", VA = "0x184925F50", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x49260A0", Offset = "0x49252A0", VA = "0x1849260A0")]
	private void KODDJHNBIDI(CNLPMBODDOC EHEFLPOKIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4925D70", Offset = "0x4924F70", VA = "0x184925D70")]
	private bool AJGJKPLFFCJ(Entity KPFAGKHHMMH, [Out] DCBMCJIAAJO AINDMPLBNFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x49264D0", Offset = "0x49256D0", VA = "0x1849264D0")]
	private void PPEBBBNMIFN(Entity KPFAGKHHMMH, DCBMCJIAAJO AINDMPLBNFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4925F70", Offset = "0x4925170", VA = "0x184925F70")]
	private bool FIBOCPOLEDP(DCBMCJIAAJO AINDMPLBNFF, [Out] CNLPMBODDOC EHEFLPOKIBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4925E30", Offset = "0x4925030", VA = "0x184925E30")]
	private CNLPMBODDOC DKPKCGGKBAI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BCNGLGLNCJE<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ONGAKBOCCMI(Entity KPFAGKHHMMH, object BCOHKLCJCPM, TValue OMEFCJCOLII);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MHJCEIPBPND(Entity KPFAGKHHMMH, object BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JCIDPCIHEEI(Entity KPFAGKHHMMH, [Out] TValue OMEFCJCOLII);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct DCBMCJIAAJO : LODJCBKGHME, IEquatable<DCBMCJIAAJO>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly DCBMCJIAAJO EPGHELDKPDG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int JDABKJNJMBH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xC4F0E0", Offset = "0xC4E2E0", VA = "0x180C4F0E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xF9C790", Offset = "0xF9B990", VA = "0x180F9C790", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int DCLMEHAOAAA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B3F0", Offset = "0x2B3A5F0", VA = "0x182B3B3F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x655CDD0", Offset = "0x655BFD0", VA = "0x18655CDD0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7374DC0", Offset = "0x7373FC0", VA = "0x187374DC0", Slot = "8")]
	public bool Equals(DCBMCJIAAJO JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7374E10", Offset = "0x7374010", VA = "0x187374E10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class LJHINNGLCEA<THasTokensTag> : BGDBFOHPBAA, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly KJMCEDJMPPA MOKKIOIDAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, DCBMCJIAAJO> LIOODFLOGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> MEOGNCNAPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private LMLIDGCPNKC<DCBMCJIAAJO, HashSet<object>> AMNLOOLFEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager ACAAJNNIMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem MLMLNFOKANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool HAOFCOOGPMB;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x49FD1D0", Offset = "0x49FC3D0", VA = "0x1849FD1D0")]
	public LJHINNGLCEA(EntityManager ACAAJNNIMJL, EntityCommandBufferSystem MLMLNFOKANM, KJMCEDJMPPA HAAMPHOKNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x49FCD90", Offset = "0x49FBF90", VA = "0x1849FCD90", Slot = "4")]
	public bool ONGAKBOCCMI(Entity KPFAGKHHMMH, object BCOHKLCJCPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x49FCBC0", Offset = "0x49FBDC0", VA = "0x1849FCBC0", Slot = "5")]
	public bool MHJCEIPBPND(Entity KPFAGKHHMMH, object BCOHKLCJCPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x49FD000", Offset = "0x49FC200", VA = "0x1849FD000", Slot = "6")]
	public bool PHLKHHGLLGE(Entity KPFAGKHHMMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x49FD0B0", Offset = "0x49FC2B0", VA = "0x1849FD0B0", Slot = "8")]
	public bool PHLKHHGLLGE(DCBMCJIAAJO AINDMPLBNFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x49FC9B0", Offset = "0x49FBBB0", VA = "0x1849FC9B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x49FCB50", Offset = "0x49FBD50", VA = "0x1849FCB50")]
	private void KODDJHNBIDI(HashSet<object> EHEFLPOKIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x49FC680", Offset = "0x49FB880", VA = "0x1849FC680")]
	private bool AJGJKPLFFCJ(Entity KPFAGKHHMMH, [Out] DCBMCJIAAJO AINDMPLBNFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x49FC750", Offset = "0x49FB950", VA = "0x1849FC750")]
	private bool BCHDJPFJDJD(Entity KPFAGKHHMMH, [Out] DCBMCJIAAJO AINDMPLBNFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x49FC9F0", Offset = "0x49FBBF0", VA = "0x1849FC9F0")]
	private void EBEDEEBJGOO(Entity KPFAGKHHMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x49FC810", Offset = "0x49FBA10", VA = "0x1849FC810")]
	private void CHNHMCCLMLE(Entity KPFAGKHHMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x49FCF60", Offset = "0x49FC160", VA = "0x1849FCF60")]
	private void PFKEKNPIAFD(Entity KPFAGKHHMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x49FD160", Offset = "0x49FC360", VA = "0x1849FD160")]
	private void PPEBBBNMIFN(Entity KPFAGKHHMMH, DCBMCJIAAJO AINDMPLBNFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x49FCAF0", Offset = "0x49FBCF0", VA = "0x1849FCAF0")]
	private bool JCHPBOLDPOI(DCBMCJIAAJO AINDMPLBNFF, [Out] HashSet<object> EHEFLPOKIBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x49FC910", Offset = "0x49FBB10", VA = "0x1849FC910")]
	private HashSet<object> DKPKCGGKBAI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class HDHCLMDLDOJ
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct BDOFBNJCOCL : JGBODDMGBND<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7374820", Offset = "0x7373A20", VA = "0x187374820")]
	public float GNFPIFCFBIL([In] float3 OMEFCJCOLII)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7374820", Offset = "0x7373A20", VA = "0x187374820", Slot = "4")]
	private float KFJELNMEHNE([In] float3 OMEFCJCOLII)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct BAHPMBHDEIF : JGBODDMGBND<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7374770", Offset = "0x7373970", VA = "0x187374770")]
	public float GNFPIFCFBIL([In] float3 OMEFCJCOLII)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7374770", Offset = "0x7373970", VA = "0x187374770", Slot = "4")]
	private float KFJELNMEHNE([In] float3 OMEFCJCOLII)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct JAPFHBJBEEF : JGBODDMGBND<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xCF9050", Offset = "0xCF8250", VA = "0x180CF9050")]
	public float GNFPIFCFBIL([In] float3 OMEFCJCOLII)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xCF9050", Offset = "0xCF8250", VA = "0x180CF9050", Slot = "4")]
	private float KFJELNMEHNE([In] float3 OMEFCJCOLII)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct KBKKAPCOEBK : JGBODDMGBND<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1ECCDB0", Offset = "0x1ECBFB0", VA = "0x181ECCDB0")]
	public int GNFPIFCFBIL([In] int3 OMEFCJCOLII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1ECCDB0", Offset = "0x1ECBFB0", VA = "0x181ECCDB0", Slot = "4")]
	private int MPFDCNEBHDG([In] int3 OMEFCJCOLII)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct PELOMGDIMDI : JGBODDMGBND<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7375700", Offset = "0x7374900", VA = "0x187375700")]
	public int GNFPIFCFBIL([In] int3 OMEFCJCOLII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7375700", Offset = "0x7374900", VA = "0x187375700", Slot = "4")]
	private int MPFDCNEBHDG([In] int3 OMEFCJCOLII)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct CFKEMFIDHMK : JGBODDMGBND<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xCDD9C0", Offset = "0xCDCBC0", VA = "0x180CDD9C0")]
	public int GNFPIFCFBIL([In] int3 OMEFCJCOLII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xCDD9C0", Offset = "0xCDCBC0", VA = "0x180CDD9C0", Slot = "4")]
	private int MPFDCNEBHDG([In] int3 OMEFCJCOLII)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class GFACLBDNDOF : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1DC7970", Offset = "0x1DC6B70", VA = "0x181DC7970")]
	public GFACLBDNDOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class CGIKCMPOGCF : SystemBase, KMCPEAAGGMH
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7374920", Offset = "0x7373B20", VA = "0x187374920")]
	public JobHandle FEKPNLAHADD(ReadOnlySpan<int> HHPPLAAJDPC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x30BADA0", Offset = "0x30B9FA0", VA = "0x1830BADA0")]
	public void NMIOLKFIMEC<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x30BA6A0", Offset = "0x30B98A0", VA = "0x1830BA6A0")]
	public JobHandle NMIOLKFIMEC<T>(JobHandle AINDMPLBNFF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7374970", Offset = "0x7373B70", VA = "0x187374970")]
	public JobHandle NMIOLKFIMEC(ReadOnlySpan<int> HHPPLAAJDPC, JobHandle AINDMPLBNFF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x30BA400", Offset = "0x30B9600", VA = "0x1830BA400")]
	public JobHandle GMPLELACLNM<T>(JobHandle AINDMPLBNFF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7374860", Offset = "0x7373A60", VA = "0x187374860")]
	public ComponentDataFromEntity ENNDFBCKFAI(int KBFEGFMJPHI, bool DKFPOAHKPFF = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x73749E0", Offset = "0x7373BE0", VA = "0x1873749E0")]
	public EntityExistenceLookupByEntity OPOOMJLPKCP()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7374A00", Offset = "0x7373C00", VA = "0x187374A00", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1DC7970", Offset = "0x1DC6B70", VA = "0x181DC7970")]
	protected CGIKCMPOGCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class BPNALJOPHKP : CGIKCMPOGCF
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7374830", Offset = "0x7373A30", VA = "0x187374830", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1DC7970", Offset = "0x1DC6B70", VA = "0x181DC7970")]
	protected BPNALJOPHKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class DLNOFAIABGI
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class IFBMOKNHKDE : EntityCommandBufferSystem, KMCPEAAGGMH
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1DC7970", Offset = "0x1DC6B70", VA = "0x181DC7970")]
	protected IFBMOKNHKDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface JGBODDMGBND<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo GNFPIFCFBIL([In] TFrom OMEFCJCOLII);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface ALDHIEOANEB<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OKFJBPCDGCE(T OMEFCJCOLII);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BurstCompile]
internal struct MFNFDLEDMHA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[ReadOnly]
	public NativeArray<Entity> NNDJLDGDLBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public EntityCommandBuffer AKGNCLGMMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public ComponentTypes NNEIOMHFFHH;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x73752B0", Offset = "0x73744B0", VA = "0x1873752B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct BBHNHIHEHHL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> NNDJLDGDLBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer AKGNCLGMMPD;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7374780", Offset = "0x7373980", VA = "0x187374780", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct EKJIAHPJCOK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public NativeArray<Entity> NNDJLDGDLBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public EntityCommandBuffer AKGNCLGMMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public ComponentType IICDGDMCODD;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7374E60", Offset = "0x7374060", VA = "0x187374E60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct ANJFFGBMIGG<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> NNDJLDGDLBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public NativeArray<T> LFDKFEEPNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public EntityCommandBuffer AKGNCLGMMPD;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4537ED0", Offset = "0x45370D0", VA = "0x184537ED0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal struct FIILIOHEAJF<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> NNDJLDGDLBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> CJALOAIIOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer AKGNCLGMMPD;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct NOINPGACMFN<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> NNDJLDGDLBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public T OMEFCJCOLII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer AKGNCLGMMPD;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4CADE50", Offset = "0x4CAD050", VA = "0x184CADE50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BurstCompile]
internal struct GLEPHIHJPKP<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, JGBODDMGBND<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<TFrom> HDFJPBPPKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[WriteOnly]
	public NativeArray<TTo> BHCNFFDGFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public TMap KOMGLJOLBFC;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct IDPPMNKGLOA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public ComponentDataFromEntity OKKMLIALABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> HDFJPBPPKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[WriteOnly]
	public NativeArray<byte> BHCNFFDGFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int LHHJLPFFIMF;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7375120", Offset = "0x7374320", VA = "0x187375120", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct CNOEPLNNIGF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public ComponentDataFromEntity<T> ABMCFIPDNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public NativeArray<Entity> HDFJPBPPKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[WriteOnly]
	public NativeList<T> HKCCEKLBPJN;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct EAMBEFFDILM<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, JGBODDMGBND<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> BEDGJOPOEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeList<TTo> BHCNFFDGFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap KOMGLJOLBFC;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct GDMFCCEFPNG<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity<T> DANKHMGBBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> PGBNACKOMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<bool> GFGFBACNIGC;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct NOKGEOFFLOO<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> DANKHMGBBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> PGBNACKOMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> GFGFBACNIGC;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4CADF20", Offset = "0x4CAD120", VA = "0x184CADF20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct LCPONBIMEID<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<T> HDFJPBPPKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeList<T> HKCCEKLBPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeParallelHashSet<T> EAFLMLPMBIP;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x49D40B0", Offset = "0x49D32B0", VA = "0x1849D40B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct ACDOCFDIDPI<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : JGBODDMGBND<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<TFrom> HDFJPBPPKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<TFrom> HKCCEKLBPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<TTo> EAFLMLPMBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public TMap KOMGLJOLBFC;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct IOOELJGGMLC<T, TPredicate> : IJob where T : struct where TPredicate : struct, ALDHIEOANEB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public NativeArray<T> HDFJPBPPKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> IILANFDELPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeList<Entity> CNDNBHMGFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public TPredicate KOMGLJOLBFC;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct IBOBIDMBBHE<T, TPredicate> : IJob where T : struct where TPredicate : struct, ALDHIEOANEB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<T> HDFJPBPPKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<T> HKCCEKLBPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate KOMGLJOLBFC;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct LKPABLBDJJO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public ComponentDataFromEntity DANKHMGBBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	public NativeArray<Entity> PGBNACKOMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeList<Entity> HLNBGMHGCBC;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7375220", Offset = "0x7374420", VA = "0x187375220", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct AJCGIJDIMEJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity DANKHMGBBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> PGBNACKOMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> HLNBGMHGCBC;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x73746E0", Offset = "0x73738E0", VA = "0x1873746E0", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class KNAKNNMAHKD
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class NNBALHFIJND
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x33F7340", Offset = "0x33F6540", VA = "0x1833F7340")]
	public static bool LBIFBANONOL<T>(this NativeArray<Entity> PGBNACKOMBO, EntityManager ACAAJNNIMJL, Allocator NNHCNMKJHLF = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class PAENNPMCLLF
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class OAFLJJJCHJC<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		public OAFLJJJCHJC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class BMEEFKGONMH<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		public BMEEFKGONMH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly List<Func<JobHandle, JobHandle>> FDLBDELOCKL;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7375670", Offset = "0x7374870", VA = "0x187375670")]
	public PAENNPMCLLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class OJEMLIGOINL
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class APNBLNJINCM
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct BIAAKHENDLP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct JJEACHFEPKN<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			internal BIAAKHENDLP<TFrom> DBEHKFODEEL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal Allocator NNHCNMKJHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal NativeArray<TFrom> BGKIOALJNDJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct JFFJKIPADPD<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct GHLNJEGHMIK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal JFFJKIPADPD<TFrom> DBEHKFODEEL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator NNHCNMKJHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeList<TFrom> BGKIOALJNDJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct OIBLEFGGNAA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct HDAJAJMNGPB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal OIBLEFGGNAA<TFrom> DBEHKFODEEL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator NNHCNMKJHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeArrayAsync<TFrom> BGKIOALJNDJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct EJDMIEMIKEA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct DJOHNKIKGKL<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal EJDMIEMIKEA<TFrom> DBEHKFODEEL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator NNHCNMKJHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeListAsync<TFrom> BGKIOALJNDJ;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class JEFHGEOAGFL
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class BJCEDNBFMII
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3052300", Offset = "0x3051500", VA = "0x183052300")]
	public static NativeList<T> ELFOLGCPHCH<T>(this NativeArray<T> EDBAMDEJCNN, Allocator NNHCNMKJHLF = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class OIJMEMGOBDH
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class OGOLOCPHJCG
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x34379D0", Offset = "0x3436BD0", VA = "0x1834379D0")]
	[OCMIEGDEGIL]
	public static JobHandle KOCOKFNKCLG<T>(this EntityCommandBufferSystem MLMLNFOKANM, NativeArrayAsync<Entity> NNDJLDGDLBA, NativeArrayAsync<T> LFDKFEEPNFP, [Optional] JobHandle DAAGEMOLLIL) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3437C80", Offset = "0x3436E80", VA = "0x183437C80")]
	[OCMIEGDEGIL]
	public static JobHandle KOCOKFNKCLG<T>(this EntityCommandBufferSystem MLMLNFOKANM, NativeArrayAsync<Entity> NNDJLDGDLBA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3437B50", Offset = "0x3436D50", VA = "0x183437B50")]
	[OCMIEGDEGIL]
	public static JobHandle KOCOKFNKCLG<T>(this EntityCommandBufferSystem MLMLNFOKANM, NativeArray<Entity> NNDJLDGDLBA, [Optional] JobHandle DAAGEMOLLIL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x73753B0", Offset = "0x73745B0", VA = "0x1873753B0")]
	[OCMIEGDEGIL]
	public static JobHandle KOCOKFNKCLG(this EntityCommandBufferSystem MLMLNFOKANM, NativeArray<Entity> NNDJLDGDLBA, ComponentTypes NNEIOMHFFHH, [Optional] JobHandle DAAGEMOLLIL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7375520", Offset = "0x7374720", VA = "0x187375520")]
	[OCMIEGDEGIL]
	public static JobHandle KOCOKFNKCLG(this EntityCommandBufferSystem MLMLNFOKANM, EntityCommandBuffer AKGNCLGMMPD, NativeArray<Entity> NNDJLDGDLBA, ComponentTypes NNEIOMHFFHH, [Optional] JobHandle DAAGEMOLLIL)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class DCFHPMINNLG
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x30F1BF0", Offset = "0x30F0DF0", VA = "0x1830F1BF0")]
	[OCMIEGDEGIL]
	public static JobHandle MENPEBKFMND<T>(this EntityCommandBufferSystem MLMLNFOKANM, EntityCommandBuffer AKGNCLGMMPD, EntityQuery BEAAEGFHIAL, T OMEFCJCOLII) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class CKIKCMJHLGP
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7374B30", Offset = "0x7373D30", VA = "0x187374B30")]
	[OCMIEGDEGIL]
	public static JobHandle MMMFEJLALFE(this EntityCommandBufferSystem MLMLNFOKANM, NativeList<Entity> NNDJLDGDLBA, [Optional] JobHandle DAAGEMOLLIL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7374CC0", Offset = "0x7373EC0", VA = "0x187374CC0")]
	[OCMIEGDEGIL]
	public static JobHandle MMMFEJLALFE(this EntityCommandBufferSystem MLMLNFOKANM, NativeArrayAsync<Entity> NNDJLDGDLBA)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class CCBDEIKOHLF
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class OCJIMJJCFIA
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x34339A0", Offset = "0x3432BA0", VA = "0x1834339A0")]
	[OCMIEGDEGIL]
	public static JobHandle BDMJBMIGDFN<T>(this EntityCommandBufferSystem MLMLNFOKANM, NativeArray<Entity> NNDJLDGDLBA, NativeArray<T> LFDKFEEPNFP, JobHandle DAAGEMOLLIL) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class HIKEEFJGOBL
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x32905D0", Offset = "0x328F7D0", VA = "0x1832905D0")]
	[OCMIEGDEGIL]
	public static JobHandle HIGPAJEIPKM<T>(this EntityCommandBufferSystem MLMLNFOKANM, NativeArray<Entity> NNDJLDGDLBA, T OMEFCJCOLII, [Optional] JobHandle DAAGEMOLLIL) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x32906C0", Offset = "0x328F8C0", VA = "0x1832906C0")]
	[OCMIEGDEGIL]
	public static JobHandle HIGPAJEIPKM<T>(this EntityCommandBufferSystem MLMLNFOKANM, EntityCommandBuffer AKGNCLGMMPD, NativeArray<Entity> NNDJLDGDLBA, T OMEFCJCOLII, [Optional] JobHandle DAAGEMOLLIL) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class MGHKGNOKFKK
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class HKHNKNJHDAN
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3291880", Offset = "0x3290A80", VA = "0x183291880")]
	public static NativeArray<T> LFIEOGEAJFE<T>(this NativeArray<Entity> EDBAMDEJCNN, EntityManager ACAAJNNIMJL, Allocator NNHCNMKJHLF = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7374F40", Offset = "0x7374140", VA = "0x187374F40")]
	public static NativeArray<Entity> DMOKLAAHBFL(this NativeArray<Entity> EDBAMDEJCNN, EntityManager ACAAJNNIMJL, ComponentType IICDGDMCODD, Allocator NNHCNMKJHLF = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x32917A0", Offset = "0x32909A0", VA = "0x1832917A0")]
	public static NativeArray<T> FJHKEKMKENJ<T>(this NativeArray<Entity> EDBAMDEJCNN, EntityManager ACAAJNNIMJL, Allocator NNHCNMKJHLF = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class NFAGHHKBBCI
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct HDKFMJHEOMN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct FJLNMDPAECP<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public HDKFMJHEOMN<TFrom> BGKIOALJNDJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Allocator NNHCNMKJHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public NativeArray<TFrom> HDFJPBPPKMF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct FOPEBAOJGLO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct AOFDBCFEOEC<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public FOPEBAOJGLO<TFrom> BGKIOALJNDJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator NNHCNMKJHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArrayAsync<TFrom> HDFJPBPPKMF;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct IHFJFLMOCCO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct PBCGPFCALEN<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public IHFJFLMOCCO<TFrom> BGKIOALJNDJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator NNHCNMKJHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeListAsync<TFrom> HDFJPBPPKMF;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class BIDDFAFPEHL
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class CDJBCPLBCHD
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct NFAKHDPDBFD : JGBODDMGBND<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> KGBAMDCPEEN;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x73753A0", Offset = "0x73745A0", VA = "0x1873753A0")]
		[BurstCompatible]
		public Entity GNFPIFCFBIL([In] Entity OMEFCJCOLII)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x73753A0", Offset = "0x73745A0", VA = "0x1873753A0", Slot = "4")]
		private Entity NKILGPDDEDN([In] Entity OMEFCJCOLII)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class MLKNOCNKKAB
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct IPKMPKMHFJG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator NNHCNMKJHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<Entity> IILANFDELPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<T> HDFJPBPPKMF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct DJCNECCKKOH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator NNHCNMKJHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeList<Entity> IILANFDELPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> HDFJPBPPKMF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct ODBBEKIHDMO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator NNHCNMKJHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArrayAsync<Entity> IILANFDELPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArrayAsync<T> HDFJPBPPKMF;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class NPLIJIEIFML
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class BHBPDKOJCEE
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct PNELIAMPJCD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator NNHCNMKJHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> HDFJPBPPKMF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct INBLIDOLAJI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator NNHCNMKJHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> HDFJPBPPKMF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct LMAEFKPKGNN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator NNHCNMKJHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeArrayAsync<T> HDFJPBPPKMF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct LJDALLDPNBH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator NNHCNMKJHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NativeListAsync<T> HDFJPBPPKMF;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class NMHIGEOOAIA
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class FCHFFOOPPGG
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3247600", Offset = "0x3246800", VA = "0x183247600")]
	public static NativeList<Entity> JKICFAJCOPI<T>(this NativeArray<Entity> PGBNACKOMBO, EntityManager ACAAJNNIMJL, Allocator NNHCNMKJHLF = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class HPHELOCCBGG
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class IKNDOPEMDIN
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public readonly struct FOIEAGACBEN<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NativeArray<TSrc> HCOCCGHLKNN;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1036AC0", Offset = "0x1035CC0", VA = "0x181036AC0")]
		public FOIEAGACBEN(NativeArray<TSrc> HCOCCGHLKNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0")]
		public HCEKKBPBIKA<TSrc, TValue> HCIELNPDHGO<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(HCEKKBPBIKA<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct HCEKKBPBIKA<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> HCOCCGHLKNN;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1036AC0", Offset = "0x1035CC0", VA = "0x181036AC0")]
		public HCEKKBPBIKA(NativeArray<TSrc> HCOCCGHLKNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0")]
		public GGEIBDPBKAN<TSrc, TValue, TSelector> HCKLIGDNHFD<TSelector>() where TSelector : struct, JGBODDMGBND<TSrc, TValue>
		{
			return default(GGEIBDPBKAN<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct GGEIBDPBKAN<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, JGBODDMGBND<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> HCOCCGHLKNN;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1036AC0", Offset = "0x1035CC0", VA = "0x181036AC0")]
		public GGEIBDPBKAN(NativeArray<TSrc> HCOCCGHLKNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x44347D0", Offset = "0x44339D0", VA = "0x1844347D0")]
		public JKJIFNFOAOL<TSrc, TValue, TSelector> NELENNFECCI()
		{
			return default(JKJIFNFOAOL<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct CDLPNPNCCFK<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, JGBODDMGBND<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> HCOCCGHLKNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TSelector EOHPFDHOECK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int CPLNODNGKGB;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TValue AJGNMEAPLII
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x56E88B0", Offset = "0x56E7AB0", VA = "0x1856E88B0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int JDABKJNJMBH
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xA3D4D0", Offset = "0xA3C6D0", VA = "0x180A3D4D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int JBMLOIOBDME
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2516260", Offset = "0x2515460", VA = "0x182516260")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x56E8A80", Offset = "0x56E7C80", VA = "0x1856E8A80")]
		public CDLPNPNCCFK(NativeArray<TSrc> HCOCCGHLKNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x56E88A0", Offset = "0x56E7AA0", VA = "0x1856E88A0")]
		public bool ACEFONMJBCA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x56E88F0", Offset = "0x56E7AF0", VA = "0x1856E88F0")]
		private TSrc IHHCAMCDFKN(int KPGFBDAMCDA)
		{
			return (TSrc)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x56E89F0", Offset = "0x56E7BF0", VA = "0x1856E89F0")]
		private TValue MENPHCJMHHJ()
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct JKJIFNFOAOL<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, JGBODDMGBND<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private CDLPNPNCCFK<TSrc, TValue, TSelector> PDIDANFNIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TValue MMJAAEFJMPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int EINJGMILBKO;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public FCLIOCDNHNC PAOHAKAKIGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x48324F0", Offset = "0x48316F0", VA = "0x1848324F0")]
			get
			{
				return default(FCLIOCDNHNC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue OLKOOMICKML
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D30", Offset = "0x8F3F30", VA = "0x1808F4D30")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, FCLIOCDNHNC range) AJGNMEAPLII
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x4832420", Offset = "0x4831620", VA = "0x184832420")]
			get
			{
				return default((TValue, FCLIOCDNHNC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x4832550", Offset = "0x4831750", VA = "0x184832550")]
		public JKJIFNFOAOL(NativeArray<TSrc> HCOCCGHLKNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4832530", Offset = "0x4831730", VA = "0x184832530")]
		public JKJIFNFOAOL<TSrc, TValue, TSelector> EMKBHPPGLAN()
		{
			return default(JKJIFNFOAOL<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x48322A0", Offset = "0x48314A0", VA = "0x1848322A0")]
		public bool ACEFONMJBCA()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x32B58C0", Offset = "0x32B4AC0", VA = "0x1832B58C0")]
	public static FOIEAGACBEN<T> KKFOKEDKHLN<T>(this NativeList<T> AFNGOKKOBOC) where T : struct
	{
		return default(FOIEAGACBEN<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1036AB0", Offset = "0x1035CB0", VA = "0x181036AB0")]
	public static FOIEAGACBEN<T> KKFOKEDKHLN<T>(this NativeArray<T> HCOCCGHLKNN) where T : struct
	{
		return default(FOIEAGACBEN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class DKECEBDLDCG
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct MLNLCOFPJBP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly NativeArray<T>.ReadOnly HCOCCGHLKNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int EINJGMILBKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int NNHJPBLAPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T MMJAAEFJMPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private T ODLNJKLIOPC;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public FCLIOCDNHNC PAOHAKAKIGD
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x49FAEE0", Offset = "0x49FA0E0", VA = "0x1849FAEE0")]
			get
			{
				return default(FCLIOCDNHNC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T OLKOOMICKML
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x3FBAF90", Offset = "0x3FBA190", VA = "0x183FBAF90")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, FCLIOCDNHNC) AJGNMEAPLII
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x4C1CDE0", Offset = "0x4C1BFE0", VA = "0x184C1CDE0")]
			get
			{
				return default((T, FCLIOCDNHNC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4C1CF90", Offset = "0x4C1C190", VA = "0x184C1CF90")]
		public MLNLCOFPJBP(NativeArray<T> HCOCCGHLKNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4C1CF50", Offset = "0x4C1C150", VA = "0x184C1CF50")]
		public MLNLCOFPJBP<T> EMKBHPPGLAN()
		{
			return default(MLNLCOFPJBP<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4C1CA30", Offset = "0x4C1BC30", VA = "0x184C1CA30")]
		public bool ACEFONMJBCA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x341AA80", Offset = "0x3419C80", VA = "0x18341AA80")]
		public LIMOMCMFCEG<T, TComparer> FMDBLABKFCN<TComparer>([Optional] TComparer AFJJHALDCLK) where TComparer : struct, IEqualityComparer<T>
		{
			return default(LIMOMCMFCEG<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct LIMOMCMFCEG<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly NativeArray<T>.ReadOnly HCOCCGHLKNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int EINJGMILBKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int NNHJPBLAPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private T MMJAAEFJMPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private T ODLNJKLIOPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TComparer AFJJHALDCLK;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public FCLIOCDNHNC PAOHAKAKIGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x49FAEE0", Offset = "0x49FA0E0", VA = "0x1849FAEE0")]
			get
			{
				return default(FCLIOCDNHNC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T OLKOOMICKML
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x3FBAF90", Offset = "0x3FBA190", VA = "0x183FBAF90")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x49FAEF0", Offset = "0x49FA0F0", VA = "0x1849FAEF0")]
		public LIMOMCMFCEG(NativeArray<T>.ReadOnly HCOCCGHLKNN, TComparer AFJJHALDCLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x49FAD00", Offset = "0x49F9F00", VA = "0x1849FAD00")]
		public bool ACEFONMJBCA()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x30F56C0", Offset = "0x30F48C0", VA = "0x1830F56C0")]
	public static MLNLCOFPJBP<T> NELENNFECCI<T>(this NativeArray<T> HCOCCGHLKNN) where T : struct
	{
		return default(MLNLCOFPJBP<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface JFFAKPCICCM
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class HEFJLDCOBOE
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct JHGPFGBNHDI<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class BAHLHHMOIPP : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public JHGPFGBNHDI<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xAAB970", Offset = "0xAAAB70", VA = "0x180AAB970", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x435EFF0", Offset = "0x435E1F0", VA = "0x18435EFF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CE0", Offset = "0x8F1EE0", VA = "0x1808F2CE0")]
		[DebuggerHidden]
		public BAHLHHMOIPP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5630240", Offset = "0x562F440", VA = "0x185630240", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5630410", Offset = "0x562F610", VA = "0x185630410", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly Action<Protobuf> JKFFKCOLLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly MemoryStream OPLAKFCFCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly CodedInputStream IKEDLEOBKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Protobuf CFNJPDBBFFB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int JBMLOIOBDME
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA960C0", Offset = "0xA952C0", VA = "0x180A960C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x482C5E0", Offset = "0x482B7E0", VA = "0x18482C5E0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x482C620", Offset = "0x482B820", VA = "0x18482C620", Slot = "4")]
	[IteratorStateMachine(typeof(JHGPFGBNHDI<>.BAHLHHMOIPP))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x482C720", Offset = "0x482B920", VA = "0x18482C720", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct IMAEOKPPEOO<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly byte[] HJDGEKDMIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Protobuf CFNJPDBBFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream OPLAKFCFCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedOutputStream DDLMKGLCDFK;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4650AB0", Offset = "0x464FCB0", VA = "0x184650AB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct GDGEFKDEJFJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly MemoryStream OPLAKFCFCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly CodedInputStream IKEDLEOBKBM;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7374F00", Offset = "0x7374100", VA = "0x187374F00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct CJJHKDJJFIC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly byte[] HJDGEKDMIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly MemoryStream OPLAKFCFCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CodedOutputStream DDLMKGLCDFK;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7374A10", Offset = "0x7373C10", VA = "0x187374A10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class HBFCBNLBIPG
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class DEHOOOLJOBJ
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Flags]
public enum JJMKPPDMCJK
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Live = 1,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Editor = 3,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Main = 5,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Simulation = 9,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Conversion = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Staging = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Shadow = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Loading = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Saving = 0x100
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal static class IPAOIMKPHBE
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class ODLABCMJMIE
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public ODLABCMJMIE()
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
