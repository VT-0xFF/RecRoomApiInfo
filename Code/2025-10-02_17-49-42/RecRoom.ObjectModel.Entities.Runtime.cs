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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86C2490", Offset = "0x86C0E90", VA = "0x1886C2490")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD85C0", Offset = "0xAD6FC0", VA = "0x180AD85C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD8600", Offset = "0xAD7000", VA = "0x180AD8600")]
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
		[Cpp2IlInjected.Address(RVA = "0x86C1650", Offset = "0x86C0050", VA = "0x1886C1650")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EJEHJDFAIBG : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	MMLCNGFADDA LBGLMLDPGDI
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
public interface BBINJILAPLB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JMMFKNELHCM(Entity BDOCGCBPBOC, object MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NJNANMMIJBD(Entity BDOCGCBPBOC, object MFKHKDDANII, [Out] bool MNMGMIKKKBF);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JJKMCPMLANG(Entity BDOCGCBPBOC);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class KMACIDKMDAK<TComponentData, TValue> : KNOEENPFPNI<TValue>, IDisposable where TComponentData : struct, EJEHJDFAIBG
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class NIBHPAACDAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<(object token, TValue value)> GBEHGKLEJFE;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int BEFNAMGOJCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x45C05E0", Offset = "0x45BEFE0", VA = "0x1845C05E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5A5F730", Offset = "0x5A5E130", VA = "0x185A5F730")]
		public bool BJLKAPIOMCH([Out] TValue KMAFNKGMDCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5A5F8F0", Offset = "0x5A5E2F0", VA = "0x185A5F8F0")]
		public void HMDNMGBNKIA(object MFKHKDDANII, TValue KMAFNKGMDCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5A5F9A0", Offset = "0x5A5E3A0", VA = "0x185A5F9A0")]
		public bool MCKODPOBNPM(object MFKHKDDANII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5A5F810", Offset = "0x5A5E210", VA = "0x185A5F810")]
		public int DBABOODDEOL(object MFKHKDDANII)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5A5FA20", Offset = "0x5A5E420", VA = "0x185A5FA20")]
		public NIBHPAACDAN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stack<NIBHPAACDAN> IOEKBBMHENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private JPIODALEDMD<MMLCNGFADDA, NIBHPAACDAN> LEAGHCKJGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EntityManager NCBHJFGCEMJ;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x56794D0", Offset = "0x5677ED0", VA = "0x1856794D0")]
	public KMACIDKMDAK(EntityManager NCBHJFGCEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5679030", Offset = "0x5677A30", VA = "0x185679030", Slot = "4")]
	public void JMMFKNELHCM(Entity BDOCGCBPBOC, object MFKHKDDANII, TValue KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5679270", Offset = "0x5677C70", VA = "0x185679270", Slot = "5")]
	public bool NJNANMMIJBD(Entity BDOCGCBPBOC, object MFKHKDDANII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5678D90", Offset = "0x5677790", VA = "0x185678D90", Slot = "6")]
	public bool BJLKAPIOMCH(Entity BDOCGCBPBOC, [Out] TValue KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5678E90", Offset = "0x5677890", VA = "0x185678E90", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5678FA0", Offset = "0x56779A0", VA = "0x185678FA0")]
	private void IHCFMANKAFD(NIBHPAACDAN HLOPOFGOMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5679410", Offset = "0x5677E10", VA = "0x185679410")]
	private bool PKIMJFFJBOG(Entity BDOCGCBPBOC, [Out] MMLCNGFADDA NOJLBGFGHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5679180", Offset = "0x5677B80", VA = "0x185679180")]
	private void MMEDLMODCKE(Entity BDOCGCBPBOC, MMLCNGFADDA NOJLBGFGHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5679160", Offset = "0x5677B60", VA = "0x185679160")]
	private bool LKNCHELGNLL(MMLCNGFADDA NOJLBGFGHBD, [Out] NIBHPAACDAN HLOPOFGOMCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5678EB0", Offset = "0x56778B0", VA = "0x185678EB0")]
	private NIBHPAACDAN HEEPAKLDIJE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KNOEENPFPNI<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JMMFKNELHCM(Entity BDOCGCBPBOC, object MFKHKDDANII, TValue KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NJNANMMIJBD(Entity BDOCGCBPBOC, object MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BJLKAPIOMCH(Entity BDOCGCBPBOC, [Out] TValue KMAFNKGMDCF);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct MMLCNGFADDA : BJILBADDCFN, IEquatable<MMLCNGFADDA>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly MMLCNGFADDA NAJKPDPODFG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int CIDCBGPMNFL
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xDB8930", Offset = "0xDB7330", VA = "0x180DB8930", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x15C5880", Offset = "0x15C4280", VA = "0x1815C5880", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int OKKDIMNKADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x30A5290", Offset = "0x30A3C90", VA = "0x1830A5290", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x30A52A0", Offset = "0x30A3CA0", VA = "0x1830A52A0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x86C23B0", Offset = "0x86C0DB0", VA = "0x1886C23B0", Slot = "8")]
	public bool Equals(MMLCNGFADDA GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x86C2400", Offset = "0x86C0E00", VA = "0x1886C2400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class FEMFPLEFMED<THasTokensTag> : BBINJILAPLB, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Dictionary<Entity, MMLCNGFADDA> KAJDLBIHNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Stack<HashSet<object>> IOEKBBMHENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private JPIODALEDMD<MMLCNGFADDA, HashSet<object>> LEAGHCKJGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EntityManager NCBHJFGCEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EntityCommandBufferSystem DNCODGAOKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool JPNPFIIDGCJ;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4FDCE50", Offset = "0x4FDB850", VA = "0x184FDCE50")]
	public FEMFPLEFMED(EntityManager NCBHJFGCEMJ, EntityCommandBufferSystem DNCODGAOKEJ, OLFEOKKCIEG NKLDCAJOHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4FDBBF0", Offset = "0x4FDA5F0", VA = "0x184FDBBF0", Slot = "4")]
	public bool JMMFKNELHCM(Entity BDOCGCBPBOC, object MFKHKDDANII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4FDC600", Offset = "0x4FDB000", VA = "0x184FDC600", Slot = "5")]
	public bool NJNANMMIJBD(Entity BDOCGCBPBOC, object MFKHKDDANII, [Out] bool MNMGMIKKKBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4FDB580", Offset = "0x4FD9F80", VA = "0x184FDB580", Slot = "6")]
	public bool JJKMCPMLANG(Entity BDOCGCBPBOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4FDB610", Offset = "0x4FDA010", VA = "0x184FDB610", Slot = "8")]
	public bool JJKMCPMLANG(MMLCNGFADDA NOJLBGFGHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4FDA880", Offset = "0x4FD9280", VA = "0x184FDA880", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4FDB430", Offset = "0x4FD9E30", VA = "0x184FDB430")]
	private void IHCFMANKAFD(HashSet<object> HLOPOFGOMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4FDCBE0", Offset = "0x4FDB5E0", VA = "0x184FDCBE0")]
	private bool PKIMJFFJBOG(Entity BDOCGCBPBOC, [Out] MMLCNGFADDA NOJLBGFGHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4FDA700", Offset = "0x4FD9100", VA = "0x184FDA700")]
	private bool ADDAGJMCIJN(Entity BDOCGCBPBOC, [Out] MMLCNGFADDA NOJLBGFGHBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4FDB2B0", Offset = "0x4FD9CB0", VA = "0x184FDB2B0")]
	private void HEHGIPPPPLP(Entity BDOCGCBPBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4FDA9D0", Offset = "0x4FD93D0", VA = "0x184FDA9D0")]
	private void FMJCGHGANKL(Entity BDOCGCBPBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4FDBF10", Offset = "0x4FDA910", VA = "0x184FDBF10")]
	private void MMDDGJDJIIM(Entity BDOCGCBPBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4FDC260", Offset = "0x4FDAC60", VA = "0x184FDC260")]
	private void MMEDLMODCKE(Entity BDOCGCBPBOC, MMLCNGFADDA NOJLBGFGHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4FDC3F0", Offset = "0x4FDADF0", VA = "0x184FDC3F0")]
	private bool MMLNIMIIMIJ(MMLCNGFADDA NOJLBGFGHBD, [Out] HashSet<object> HLOPOFGOMCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4FDAD00", Offset = "0x4FD9700", VA = "0x184FDAD00")]
	private HashSet<object> HEEPAKLDIJE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class FPBIIHDBCEL
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct BCANFFJJCEA : HJIEDECKDFK<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x86C14B0", Offset = "0x86BFEB0", VA = "0x1886C14B0")]
	public float IJOJCFOJHEJ([In] float3 KMAFNKGMDCF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x86C14B0", Offset = "0x86BFEB0", VA = "0x1886C14B0", Slot = "4")]
	private float DBOBPPGCAGG([In] float3 KMAFNKGMDCF)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct HBDLFLCOJPB : HJIEDECKDFK<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x86C1C20", Offset = "0x86C0620", VA = "0x1886C1C20")]
	public float IJOJCFOJHEJ([In] float3 KMAFNKGMDCF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x86C1C20", Offset = "0x86C0620", VA = "0x1886C1C20", Slot = "4")]
	private float DBOBPPGCAGG([In] float3 KMAFNKGMDCF)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct DLHNGFLMEFB : HJIEDECKDFK<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x86C1640", Offset = "0x86C0040", VA = "0x1886C1640")]
	public float IJOJCFOJHEJ([In] float3 KMAFNKGMDCF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x86C1640", Offset = "0x86C0040", VA = "0x1886C1640", Slot = "4")]
	private float DBOBPPGCAGG([In] float3 KMAFNKGMDCF)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct CFKEJGOCLEM : HJIEDECKDFK<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x14BB2B0", Offset = "0x14B9CB0", VA = "0x1814BB2B0")]
	public int IJOJCFOJHEJ([In] int3 KMAFNKGMDCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x14BB2B0", Offset = "0x14B9CB0", VA = "0x1814BB2B0", Slot = "4")]
	private int MKPKHHECALI([In] int3 KMAFNKGMDCF)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct CKJNDHELOPA : HJIEDECKDFK<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x141C4B0", Offset = "0x141AEB0", VA = "0x18141C4B0")]
	public int IJOJCFOJHEJ([In] int3 KMAFNKGMDCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x141C4B0", Offset = "0x141AEB0", VA = "0x18141C4B0", Slot = "4")]
	private int MKPKHHECALI([In] int3 KMAFNKGMDCF)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct CBCAPJPAJAL : HJIEDECKDFK<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xFFDE60", Offset = "0xFFC860", VA = "0x180FFDE60")]
	public int IJOJCFOJHEJ([In] int3 KMAFNKGMDCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xFFDE60", Offset = "0xFFC860", VA = "0x180FFDE60", Slot = "4")]
	private int MKPKHHECALI([In] int3 KMAFNKGMDCF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GODFPIDNIMM : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2421520", Offset = "0x241FF20", VA = "0x182421520")]
	public GODFPIDNIMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class HKCCMPBPDAG : SystemBase, CONODFJLLME
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x86C1DD0", Offset = "0x86C07D0", VA = "0x1886C1DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3DCE0C0", Offset = "0x3DCCAC0", VA = "0x183DCE0C0")]
	public void KHGPBFALADP<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3DCE0C0", Offset = "0x3DCCAC0", VA = "0x183DCE0C0")]
	public void PPLJIGKFMPA<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x86C1CB0", Offset = "0x86C06B0", VA = "0x1886C1CB0")]
	public JobHandle CKOHMFCEFHH(ReadOnlySpan<int> KPLLGJKDEED)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3DCD500", Offset = "0x3DCBF00", VA = "0x183DCD500")]
	public JobHandle CKIINMFJDLO<T>() where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x86C1C60", Offset = "0x86C0660", VA = "0x1886C1C60")]
	public JobHandle CKIINMFJDLO(ReadOnlySpan<int> KPLLGJKDEED)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3DCD8E0", Offset = "0x3DCC2E0", VA = "0x183DCD8E0")]
	public void HDMPILABJGG<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3DCD760", Offset = "0x3DCC160", VA = "0x183DCD760")]
	public JobHandle HDMPILABJGG<T>(JobHandle NOJLBGFGHBD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x86C1D00", Offset = "0x86C0700", VA = "0x1886C1D00")]
	public JobHandle HDMPILABJGG(ReadOnlySpan<int> KPLLGJKDEED, JobHandle NOJLBGFGHBD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3DCD8E0", Offset = "0x3DCC2E0", VA = "0x183DCD8E0")]
	public void OEKFNCMIFCA<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3DCE110", Offset = "0x3DCCB10", VA = "0x183DCE110")]
	public JobHandle OEKFNCMIFCA<T>(JobHandle NOJLBGFGHBD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x86C1EE0", Offset = "0x86C08E0", VA = "0x1886C1EE0")]
	public JobHandle OEKFNCMIFCA(Span<int> KPLLGJKDEED, JobHandle NOJLBGFGHBD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3DCE010", Offset = "0x3DCCA10", VA = "0x183DCE010")]
	public ComponentDataFromEntity JNOCJCPDMCA<T>(bool KPANGEBBCJL = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x86C1E20", Offset = "0x86C0820", VA = "0x1886C1E20")]
	public ComponentDataFromEntity JNOCJCPDMCA(int OEIMJBPIFAB, bool KPANGEBBCJL = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3DCD6C0", Offset = "0x3DCC0C0", VA = "0x183DCD6C0")]
	public SharedComponentIndexFromEntity<T> DJGGBMMMKFM<T>() where T : ISharedComponentData
	{
		return default(SharedComponentIndexFromEntity<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x86C1D70", Offset = "0x86C0770", VA = "0x1886C1D70")]
	[BurstCompatible]
	public ComponentTypeHandle IHMJJLMNFFE(ComponentType NNJKEIMHIIH)
	{
		return default(ComponentTypeHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x86C1E00", Offset = "0x86C0800", VA = "0x1886C1E00")]
	public EntityExistenceLookupByEntity JFHKFBKMDAG()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x86C1F50", Offset = "0x86C0950", VA = "0x1886C1F50", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3DCD5A0", Offset = "0x3DCBFA0", VA = "0x183DCD5A0")]
	public bool DIODAAFEHPE<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "7")]
	protected sealed override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2421520", Offset = "0x241FF20", VA = "0x182421520")]
	protected HKCCMPBPDAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class FBCLBDKKFKB : HKCCMPBPDAG
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x86C1670", Offset = "0x86C0070", VA = "0x1886C1670", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2421520", Offset = "0x241FF20", VA = "0x182421520")]
	protected FBCLBDKKFKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class JHBICKJLELI
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class HBJPGPGJBOB : EntityCommandBufferSystem, CONODFJLLME
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private OLFEOKKCIEG JAPFEIFECJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xF2CFC0", Offset = "0xF2B9C0", VA = "0x180F2CFC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x86C1C30", Offset = "0x86C0630", VA = "0x1886C1C30")]
	public HBJPGPGJBOB(OLFEOKKCIEG JHGFKLHHPJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface HJIEDECKDFK<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo IJOJCFOJHEJ([In] TFrom KMAFNKGMDCF);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface PKFPNFNPNPI<T>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AOMGENJHHLO(T KMAFNKGMDCF);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct CMNOFFDAPBI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> BKFKEKMLADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer OIMBDFOKNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public ComponentTypes JJHLJPNHIGP;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x86C1550", Offset = "0x86BFF50", VA = "0x1886C1550", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct LAKEHANFOMB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> BKFKEKMLADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer OIMBDFOKNBB;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x86C2310", Offset = "0x86C0D10", VA = "0x1886C2310", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct KLNAJEDEJKL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> BKFKEKMLADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer OIMBDFOKNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public ComponentType NNJKEIMHIIH;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x86C2200", Offset = "0x86C0C00", VA = "0x1886C2200", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[BurstCompile]
internal struct LOIEPLAAPDA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> BKFKEKMLADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> BLPDDGCLNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer OIMBDFOKNBB;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5748700", Offset = "0x5747100", VA = "0x185748700", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct JPEELHCNCHB<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> BKFKEKMLADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<T> FDOLNIMJMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer OIMBDFOKNBB;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal struct JOBFKDMMPKL<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<Entity> BKFKEKMLADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public T KMAFNKGMDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EntityCommandBuffer OIMBDFOKNBB;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct EFABECDPKBN<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, HJIEDECKDFK<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<TFrom> PEAHCMIEFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<TTo> EBMELHOFHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public TMap FCCCPABHDPG;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct FLDMOOHHEBC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity FPGGLOMNEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> PEAHCMIEFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeArray<byte> EBMELHOFHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int EMMIGKMMEHE;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x86C17D0", Offset = "0x86C01D0", VA = "0x1886C17D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct IBBGACGCHFH<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> IOGFMGPGADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<Entity> PEAHCMIEFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<T> IMNNJLCCLDH;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct FLLINANHFDC<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, HJIEDECKDFK<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<TFrom> BBGOBGMCJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[WriteOnly]
	public NativeList<TTo> EBMELHOFHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public TMap FCCCPABHDPG;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct OFEJINMAAOJ<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> DBHEMLELMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> MBONBFDBJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> KBDGFEBNKPF;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct NDDGBALPLNH<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public ComponentDataFromEntity<T> DBHEMLELMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<Entity> MBONBFDBJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<bool> KBDGFEBNKPF;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5A47C80", Offset = "0x5A46680", VA = "0x185A47C80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct EAEAJIEKDPG<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<T> PEAHCMIEFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<T> IMNNJLCCLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<T> IIEPPANKIKK;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4AF1ED0", Offset = "0x4AF08D0", VA = "0x184AF1ED0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct JOJMEMNMEKN<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : HJIEDECKDFK<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<TFrom> PEAHCMIEFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public NativeList<TFrom> IMNNJLCCLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeParallelHashSet<TTo> IIEPPANKIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TMap FCCCPABHDPG;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct HCDPPBMFFED<T, TPredicate> : IJob where T : struct where TPredicate : struct, PKFPNFNPNPI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> PEAHCMIEFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<Entity> ONLJFHPPEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<Entity> DDFNOJELMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate FCCCPABHDPG;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct ELPKBOJGALK<T, TPredicate> : IJob where T : struct where TPredicate : struct, PKFPNFNPNPI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> PEAHCMIEFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> IMNNJLCCLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TPredicate FCCCPABHDPG;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct GAIGNBKMCFI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity DBHEMLELMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> MBONBFDBJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> CELKBCAPKFD;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x86C18D0", Offset = "0x86C02D0", VA = "0x1886C18D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct CDGNCOGDEIO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[ReadOnly]
	public ComponentDataFromEntity DBHEMLELMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<Entity> MBONBFDBJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<Entity> CELKBCAPKFD;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x86C14C0", Offset = "0x86BFEC0", VA = "0x1886C14C0", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class GMEHJAMBBKM
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class GHDECGPOGBH
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3DB46C0", Offset = "0x3DB30C0", VA = "0x183DB46C0")]
	public static bool LEIHAAEIJMF<T>(this NativeArray<Entity> MBONBFDBJDK, EntityManager NCBHJFGCEMJ, Allocator EIOOMONCLID = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class KMCDAPJLPMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class KNANMCGLGHI<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		public KNANMCGLGHI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class OCOINIEAKMJ<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public OCOINIEAKMJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly List<Func<JobHandle, JobHandle>> JPAHGFEGGFD;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x86C2280", Offset = "0x86C0C80", VA = "0x1886C2280")]
	public KMCDAPJLPMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class OLAMOBILJLA
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class KNMNCBHAOKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct FNHMLEGIEPO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct GAGDNEDIBHO<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal FNHMLEGIEPO<TFrom> AEMEEJKFKNN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator EIOOMONCLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeArray<TFrom> KGCMICBGABJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct MKHNKLMOOJG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct PKJJKPLIPFA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal MKHNKLMOOJG<TFrom> AEMEEJKFKNN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator EIOOMONCLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeList<TFrom> KGCMICBGABJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct LDDBGBEDDJA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct NGEKKGGMDIL<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal LDDBGBEDDJA<TFrom> AEMEEJKFKNN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator EIOOMONCLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeArrayAsync<TFrom> KGCMICBGABJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct ACHMDOJNPCF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public struct FMPDEMGOBEM<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			internal ACHMDOJNPCF<TFrom> AEMEEJKFKNN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal Allocator EIOOMONCLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal NativeListAsync<TFrom> KGCMICBGABJ;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class GGINFJCBKIK
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class PJLGJLGCPPB
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3F6E9C0", Offset = "0x3F6D3C0", VA = "0x183F6E9C0")]
	public static NativeList<T> LNHELCLOJEP<T>(this NativeArray<T> IMKHADPJGME, Allocator EIOOMONCLID = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class KAMHEFFMCFB
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class GLAFCIGMEEG
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3DB7160", Offset = "0x3DB5B60", VA = "0x183DB7160")]
	[CNCMCJPPDCG]
	public static JobHandle EFLGADNCMDC<T>(this EntityCommandBufferSystem DNCODGAOKEJ, NativeArray<Entity> BKFKEKMLADJ, NativeArray<T> BLPDDGCLNPE) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3DB6EC0", Offset = "0x3DB58C0", VA = "0x183DB6EC0")]
	[CNCMCJPPDCG]
	public static JobHandle EFLGADNCMDC<T>(this EntityCommandBufferSystem DNCODGAOKEJ, NativeArrayAsync<Entity> BKFKEKMLADJ, NativeArrayAsync<T> BLPDDGCLNPE, [Optional] JobHandle POALLDLHIAK) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3DB6DA0", Offset = "0x3DB57A0", VA = "0x183DB6DA0")]
	[CNCMCJPPDCG]
	public static JobHandle EFLGADNCMDC<T>(this EntityCommandBufferSystem DNCODGAOKEJ, NativeArray<Entity> BKFKEKMLADJ, [Optional] JobHandle POALLDLHIAK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x86C1AB0", Offset = "0x86C04B0", VA = "0x1886C1AB0")]
	[CNCMCJPPDCG]
	public static JobHandle EFLGADNCMDC(this EntityCommandBufferSystem DNCODGAOKEJ, NativeArray<Entity> BKFKEKMLADJ, ComponentTypes JJHLJPNHIGP, [Optional] JobHandle POALLDLHIAK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x86C1960", Offset = "0x86C0360", VA = "0x1886C1960")]
	[CNCMCJPPDCG]
	public static JobHandle EFLGADNCMDC(this EntityCommandBufferSystem DNCODGAOKEJ, EntityCommandBuffer OIMBDFOKNBB, NativeArray<Entity> BKFKEKMLADJ, ComponentTypes JJHLJPNHIGP, [Optional] JobHandle POALLDLHIAK)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class NEOFNFICMGA
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class KDECMLKMOLD
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x86C2070", Offset = "0x86C0A70", VA = "0x1886C2070")]
	[CNCMCJPPDCG]
	public static JobHandle AJJJBAEJINB(this EntityCommandBufferSystem DNCODGAOKEJ, NativeList<Entity> BKFKEKMLADJ, [Optional] JobHandle POALLDLHIAK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x86C1F70", Offset = "0x86C0970", VA = "0x1886C1F70")]
	[CNCMCJPPDCG]
	public static JobHandle AJJJBAEJINB(this EntityCommandBufferSystem DNCODGAOKEJ, NativeArrayAsync<Entity> BKFKEKMLADJ)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class PLFKHGOIOGF
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3F6F480", Offset = "0x3F6DE80", VA = "0x183F6F480")]
	public static void BCIJECMFNNG<T>(this EntityCommandBufferSystem DNCODGAOKEJ, EntityQuery AGDKAEIBGFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3F6F840", Offset = "0x3F6E240", VA = "0x183F6F840")]
	[CNCMCJPPDCG]
	public static JobHandle ONNAFACFMEB<T>(this EntityCommandBufferSystem DNCODGAOKEJ, NativeArrayAsync<Entity> BKFKEKMLADJ, [Optional] JobHandle POALLDLHIAK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x86C26F0", Offset = "0x86C10F0", VA = "0x1886C26F0")]
	[CNCMCJPPDCG]
	public static JobHandle ONNAFACFMEB(this EntityCommandBufferSystem DNCODGAOKEJ, NativeArrayAsync<Entity> BKFKEKMLADJ, ComponentType NNJKEIMHIIH, [Optional] JobHandle POALLDLHIAK)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class BBNPBODNEMJ
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3B24230", Offset = "0x3B22C30", VA = "0x183B24230")]
	[CNCMCJPPDCG]
	public static JobHandle DKNEFAHCJGB<T>(this EntityCommandBufferSystem DNCODGAOKEJ, NativeArray<Entity> BKFKEKMLADJ, NativeArray<T> BLPDDGCLNPE, JobHandle POALLDLHIAK) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class CHHHPIFKPMM
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class DDDAKLJENIN
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class OOGIGOMBNOC
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3F5B660", Offset = "0x3F5A060", VA = "0x183F5B660")]
	public static NativeArray<T> PPCIFEDHLGM<T>(this NativeList<Entity> IMKHADPJGME, EntityManager NCBHJFGCEMJ, Allocator EIOOMONCLID = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3F5B710", Offset = "0x3F5A110", VA = "0x183F5B710")]
	public static NativeArray<T> PPCIFEDHLGM<T>(this NativeArray<Entity> IMKHADPJGME, EntityManager NCBHJFGCEMJ, Allocator EIOOMONCLID = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x86C2510", Offset = "0x86C0F10", VA = "0x1886C2510")]
	public static NativeArray<Entity> PEFIONPIEID(this NativeArray<Entity> IMKHADPJGME, EntityManager NCBHJFGCEMJ, ComponentType NNJKEIMHIIH, Allocator EIOOMONCLID = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3F5B560", Offset = "0x3F59F60", VA = "0x183F5B560")]
	public static NativeArray<T> CFKDOHFMLGJ<T>(this NativeArray<Entity> IMKHADPJGME, EntityManager NCBHJFGCEMJ, Allocator EIOOMONCLID = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class GOMMAKCKOAK
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct KKMCOLFLPPM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct CGJNOOECMHM<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public KKMCOLFLPPM<TFrom> KGCMICBGABJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator EIOOMONCLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArray<TFrom> PEAHCMIEFFA;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct OGJJMGEGHOM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct ONJPJGKCEJA<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public OGJJMGEGHOM<TFrom> KGCMICBGABJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator EIOOMONCLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeArrayAsync<TFrom> PEAHCMIEFFA;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct LCPJMDCBNEI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public struct KKGDHAOPPGG<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public LCPJMDCBNEI<TFrom> KGCMICBGABJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator EIOOMONCLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeListAsync<TFrom> PEAHCMIEFFA;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class HHLDGMBNOEM
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class HLMPBMLDIHE
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct JDFBJLMLKLD : HJIEDECKDFK<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> HICHIMHCJBG;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x86C1F60", Offset = "0x86C0960", VA = "0x1886C1F60")]
		[BurstCompatible]
		public Entity IJOJCFOJHEJ([In] Entity KMAFNKGMDCF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x86C1F60", Offset = "0x86C0960", VA = "0x1886C1F60", Slot = "4")]
		private Entity DNCHPFLPKCE([In] Entity KMAFNKGMDCF)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class FCPJNFFGLGA
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct MHMPNHCNKLL<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5962600", Offset = "0x5961000", VA = "0x185962600", Slot = "4")]
		public int Compare((TKey, TValue) FKPKEFAKAOE, (TKey, TValue) KEEMKILMOML)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3D68720", Offset = "0x3D67120", VA = "0x183D68720")]
	public static void JOCNICKKOGF<TKey, TValue>(NativeList<TKey> CKKEJCDBNGF, NativeList<TValue> FDOLNIMJMJM) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3D68350", Offset = "0x3D66D50", VA = "0x183D68350")]
	public static void JOCNICKKOGF<TKey, TValue>(NativeArray<TKey> CKKEJCDBNGF, NativeArray<TValue> FDOLNIMJMJM) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3D68510", Offset = "0x3D66F10", VA = "0x183D68510")]
	public static void JOCNICKKOGF<TKey, TValue, U>(NativeArray<TKey> CKKEJCDBNGF, NativeArray<TValue> FDOLNIMJMJM, U OLOKGJLKBDD) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class KAEIAFHHEML
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct ICKIFAIHNCB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator EIOOMONCLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<Entity> ONLJFHPPEHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> PEAHCMIEFFA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct KLKEGNIFAJF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator EIOOMONCLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeList<Entity> ONLJFHPPEHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArray<T> PEAHCMIEFFA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct PCOGPMMJKBO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator EIOOMONCLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArrayAsync<Entity> ONLJFHPPEHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArrayAsync<T> PEAHCMIEFFA;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class CPNMEJAJBAI
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class DDIGMMMDMDP
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct FMLFAOKAFIN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator EIOOMONCLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArray<T> PEAHCMIEFFA;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct MIBGLGDNGMC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator EIOOMONCLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeList<T> PEAHCMIEFFA;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct KMFKPDHHLAE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator EIOOMONCLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<T> PEAHCMIEFFA;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct MMKKEJLNNNH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Allocator EIOOMONCLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NativeListAsync<T> PEAHCMIEFFA;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class PCBAOOEAJCM
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class NIADICOCPIM
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3F0A870", Offset = "0x3F09270", VA = "0x183F0A870")]
	public static NativeList<Entity> ONCHPAPFELO<T>(this NativeList<Entity> MBONBFDBJDK, EntityManager NCBHJFGCEMJ, Allocator EIOOMONCLID = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3F0A270", Offset = "0x3F08C70", VA = "0x183F0A270")]
	public static NativeList<Entity> ONCHPAPFELO<T>(this NativeArray<Entity> MBONBFDBJDK, EntityManager NCBHJFGCEMJ, Allocator EIOOMONCLID = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class KPOELKGPKMN
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3E699F0", Offset = "0x3E683F0", VA = "0x183E699F0")]
	public static NativeList<Entity> IABGPLMNJNH<T>(this NativeArray<Entity> MBONBFDBJDK, EntityManager NCBHJFGCEMJ, Allocator EIOOMONCLID = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class FDHIGFNOHAD
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public readonly struct HKFOHBKIDCJ<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> BHEONMJLANC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public readonly struct GGALMMKPKKK<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> BHEONMJLANC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public readonly struct LHFIDPFKEGI<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, HJIEDECKDFK<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly NativeArray<TSrc> BHEONMJLANC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct KGMLAILAPJE<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, HJIEDECKDFK<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly NativeArray<TSrc> BHEONMJLANC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TSelector ODNIHKHDBNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int KABGMIEBEFC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct CLPJOHMLGGD<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, HJIEDECKDFK<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private KGMLAILAPJE<TSrc, TValue, TSelector> BNAAJHEIBMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TValue FGIDMNGLLIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int MHADOGLMBLF;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class FDLDDOBKCBD
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct CCBJNBBLLHI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<T> BHEONMJLANC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int MHADOGLMBLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int AMEDJFICDPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private T FGIDMNGLLIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T PGLIDIPPHJC;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JDHBPJJENDI HIPDCIPBGFB
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5B97580", Offset = "0x5B95F80", VA = "0x185B97580")]
			get
			{
				return default(JDHBPJJENDI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public T LPAHLFBDNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public (T, JDHBPJJENDI) IGCJDJEKHNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x5B97420", Offset = "0x5B95E20", VA = "0x185B97420")]
			get
			{
				return default((T, JDHBPJJENDI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6BFB260", Offset = "0x6BF9C60", VA = "0x186BFB260")]
		public CCBJNBBLLHI(NativeArray<T> BHEONMJLANC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2D9CCD0", Offset = "0x2D9B6D0", VA = "0x182D9CCD0")]
		public CCBJNBBLLHI<T> FIIFAFDLDFC()
		{
			return default(CCBJNBBLLHI<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6BFB170", Offset = "0x6BF9B70", VA = "0x186BFB170")]
		public bool MDPBHDIHDFH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3F269A0", Offset = "0x3F253A0", VA = "0x183F269A0")]
		public OBKFNMPCKOK<T, TComparer> HGNHJPIJKPN<TComparer>([Optional] TComparer OLOKGJLKBDD) where TComparer : struct, IEqualityComparer<T>
		{
			return default(OBKFNMPCKOK<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct OBKFNMPCKOK<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly NativeArray<T> BHEONMJLANC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int MHADOGLMBLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int AMEDJFICDPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private T FGIDMNGLLIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private T PGLIDIPPHJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TComparer OLOKGJLKBDD;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public JDHBPJJENDI HIPDCIPBGFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x5B97580", Offset = "0x5B95F80", VA = "0x185B97580")]
			get
			{
				return default(JDHBPJJENDI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T LPAHLFBDNEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public (T value, JDHBPJJENDI range) IGCJDJEKHNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x5B97420", Offset = "0x5B95E20", VA = "0x185B97420")]
			get
			{
				return default((T, JDHBPJJENDI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5B97800", Offset = "0x5B96200", VA = "0x185B97800")]
		public OBKFNMPCKOK(NativeArray<T> BHEONMJLANC, TComparer OLOKGJLKBDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x46888D0", Offset = "0x46872D0", VA = "0x1846888D0")]
		public OBKFNMPCKOK<T, TComparer> FIIFAFDLDFC()
		{
			return default(OBKFNMPCKOK<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5B976F0", Offset = "0x5B960F0", VA = "0x185B976F0")]
		public bool MDPBHDIHDFH()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3D68990", Offset = "0x3D67390", VA = "0x183D68990")]
	public static CCBJNBBLLHI<T> APCGJECJGJB<T>(this NativeArray<T> BHEONMJLANC) where T : struct
	{
		return default(CCBJNBBLLHI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface GPOIBDPCBHD
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class NAOLHCMDGMH
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct GFLGNFBBFGJ<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class BLNPKIILAHP : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public GFLGNFBBFGJ<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xBF9200", Offset = "0xBF7C00", VA = "0x180BF9200", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50FA650", Offset = "0x50F9050", VA = "0x1850FA650", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
		[DebuggerHidden]
		public BLNPKIILAHP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x677BE10", Offset = "0x677A810", VA = "0x18677BE10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x677BFC0", Offset = "0x677A9C0", VA = "0x18677BFC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly Action<Protobuf> LILBFEGIOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MemoryStream GDDPDAOPHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CodedInputStream EPEJLOBBNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Protobuf EANCNLNFGFP;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly int EJCBNJPPPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xB0E380", Offset = "0xB0CD80", VA = "0x180B0E380")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x512A440", Offset = "0x5128E40", VA = "0x18512A440", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x512A480", Offset = "0x5128E80", VA = "0x18512A480", Slot = "4")]
	[IteratorStateMachine(typeof(GFLGNFBBFGJ<>.BLNPKIILAHP))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x512A570", Offset = "0x5128F70", VA = "0x18512A570", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct LECMMEMOBNF<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly byte[] FPGJFOLEKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Protobuf EANCNLNFGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream GDDPDAOPHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedOutputStream CHKGMKCKPHL;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5720850", Offset = "0x571F250", VA = "0x185720850", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct NEDJAEHMGNJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream GDDPDAOPHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedInputStream EPEJLOBBNKG;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x86C2450", Offset = "0x86C0E50", VA = "0x1886C2450", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct FJGILJDHPHF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] FPGJFOLEKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly MemoryStream GDDPDAOPHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly CodedOutputStream CHKGMKCKPHL;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x86C16A0", Offset = "0x86C00A0", VA = "0x1886C16A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class PAANPAGGAKG
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class JPJKCBIHGOD
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[Flags]
public enum BIJABCALOPJ
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
internal static class PPCOJANCDDK
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class HOMBPOKEPHI
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public HOMBPOKEPHI()
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
