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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0x854B0D0", Offset = "0x8549ED0", VA = "0x18854B0D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xABFA20", Offset = "0xABE820", VA = "0x180ABFA20")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFA60", Offset = "0xABE860", VA = "0x180ABFA60")]
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
		[Cpp2IlInjected.Address(RVA = "0x854A5F0", Offset = "0x85493F0", VA = "0x18854A5F0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FFLKHEHEBKG : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	CLKBEOKLHMI FIGLOPPLCPG
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
public interface FDGPEDCPLIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NGHNDGDGOOI(Entity DJHHEAHBFFL, object OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MFKHPOAMDFB(Entity DJHHEAHBFFL, object OBGCPOCPFIJ, [Out] bool LGOKLGHMGCA);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ACHEFJFHKGJ(Entity DJHHEAHBFFL);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class JCKGGFHCKEC<TComponentData, TValue> : AAOEJPHGOOI<TValue>, IDisposable where TComponentData : struct, FFLKHEHEBKG
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class PGONOKNCJBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<(object token, TValue value)> NGGCNGNMEBF;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int KFMIHBFLPLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x4516A90", Offset = "0x4515890", VA = "0x184516A90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5BFA410", Offset = "0x5BF9210", VA = "0x185BFA410")]
		public bool IPPCHMDPBJH([Out] TValue HGMAIPELJHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5BFA360", Offset = "0x5BF9160", VA = "0x185BFA360")]
		public void DPHJBDIDPOG(object OBGCPOCPFIJ, TValue HGMAIPELJHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5BFA500", Offset = "0x5BF9300", VA = "0x185BFA500")]
		public bool MDNHCHGJFLC(object OBGCPOCPFIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5BFA280", Offset = "0x5BF9080", VA = "0x185BFA280")]
		public int AAEPANPJFBI(object OBGCPOCPFIJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5BFA580", Offset = "0x5BF9380", VA = "0x185BFA580")]
		public PGONOKNCJBE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stack<PGONOKNCJBE> GALEHAPJIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private KJFLFLNJIOG<CLKBEOKLHMI, PGONOKNCJBE> MGNHDKLCEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EntityManager OPLCAABCINH;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x545C030", Offset = "0x545AE30", VA = "0x18545C030")]
	public JCKGGFHCKEC(EntityManager OPLCAABCINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x545BE60", Offset = "0x545AC60", VA = "0x18545BE60", Slot = "4")]
	public void NGHNDGDGOOI(Entity DJHHEAHBFFL, object OBGCPOCPFIJ, TValue HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x545BCA0", Offset = "0x545AAA0", VA = "0x18545BCA0", Slot = "5")]
	public bool MFKHPOAMDFB(Entity DJHHEAHBFFL, object OBGCPOCPFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x545BBA0", Offset = "0x545A9A0", VA = "0x18545BBA0", Slot = "6")]
	public bool IPPCHMDPBJH(Entity DJHHEAHBFFL, [Out] TValue HGMAIPELJHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x545BAC0", Offset = "0x545A8C0", VA = "0x18545BAC0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x545BFA0", Offset = "0x545ADA0", VA = "0x18545BFA0")]
	private void NKJOCDBIBOJ(PGONOKNCJBE HEHEIIMBBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x545BAE0", Offset = "0x545A8E0", VA = "0x18545BAE0")]
	private bool INOMIGCPMDI(Entity DJHHEAHBFFL, [Out] CLKBEOKLHMI MJIBDELKIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x545B8E0", Offset = "0x545A6E0", VA = "0x18545B8E0")]
	private void BCBAIENGJIP(Entity DJHHEAHBFFL, CLKBEOKLHMI MJIBDELKIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x545BE40", Offset = "0x545AC40", VA = "0x18545BE40")]
	private bool MHOMGNFGFDH(CLKBEOKLHMI MJIBDELKIML, [Out] PGONOKNCJBE HEHEIIMBBAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x545B9D0", Offset = "0x545A7D0", VA = "0x18545B9D0")]
	private PGONOKNCJBE BENAMNGFKLH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface AAOEJPHGOOI<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGHNDGDGOOI(Entity DJHHEAHBFFL, object OBGCPOCPFIJ, TValue HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MFKHPOAMDFB(Entity DJHHEAHBFFL, object OBGCPOCPFIJ);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IPPCHMDPBJH(Entity DJHHEAHBFFL, [Out] TValue HGMAIPELJHM);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct CLKBEOKLHMI : JNOBALCJGHO, IEquatable<CLKBEOKLHMI>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly CLKBEOKLHMI EBFKLKOBJOD;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int NELPMDCEMJE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xD91780", Offset = "0xD90580", VA = "0x180D91780", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x156A1B0", Offset = "0x1568FB0", VA = "0x18156A1B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int ALOAEDJGJPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x300A170", Offset = "0x3008F70", VA = "0x18300A170", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x300A160", Offset = "0x3008F60", VA = "0x18300A160", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x854A140", Offset = "0x8548F40", VA = "0x18854A140", Slot = "8")]
	public bool Equals(CLKBEOKLHMI FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x854A190", Offset = "0x8548F90", VA = "0x18854A190", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PJFIHMMPOKC<THasTokensTag> : FDGPEDCPLIL, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly ALMLLDBPKBM IPEKLICENHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Dictionary<Entity, CLKBEOKLHMI> PHLGHKJLPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Stack<HashSet<object>> GALEHAPJIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private KJFLFLNJIOG<CLKBEOKLHMI, HashSet<object>> MGNHDKLCEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EntityManager OPLCAABCINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EntityCommandBufferSystem PMFHNPOBHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool JAABGCKHGLN;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5BFEB30", Offset = "0x5BFD930", VA = "0x185BFEB30")]
	public PJFIHMMPOKC(EntityManager OPLCAABCINH, EntityCommandBufferSystem PMFHNPOBHPO, ALMLLDBPKBM EEPDHIPNMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5BFE920", Offset = "0x5BFD720", VA = "0x185BFE920", Slot = "4")]
	public bool NGHNDGDGOOI(Entity DJHHEAHBFFL, object OBGCPOCPFIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5BFE660", Offset = "0x5BFD460", VA = "0x185BFE660", Slot = "5")]
	public bool MFKHPOAMDFB(Entity DJHHEAHBFFL, object OBGCPOCPFIJ, [Out] bool LGOKLGHMGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5BFE060", Offset = "0x5BFCE60", VA = "0x185BFE060", Slot = "6")]
	public bool ACHEFJFHKGJ(Entity DJHHEAHBFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5BFE0F0", Offset = "0x5BFCEF0", VA = "0x185BFE0F0", Slot = "8")]
	public bool ACHEFJFHKGJ(CLKBEOKLHMI MJIBDELKIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5BFE2B0", Offset = "0x5BFD0B0", VA = "0x185BFE2B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5BFEAC0", Offset = "0x5BFD8C0", VA = "0x185BFEAC0")]
	private void NKJOCDBIBOJ(HashSet<object> HEHEIIMBBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5BFE4C0", Offset = "0x5BFD2C0", VA = "0x185BFE4C0")]
	private bool INOMIGCPMDI(Entity DJHHEAHBFFL, [Out] CLKBEOKLHMI MJIBDELKIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5BFE2F0", Offset = "0x5BFD0F0", VA = "0x185BFE2F0")]
	private bool FFDCNBDALLL(Entity DJHHEAHBFFL, [Out] CLKBEOKLHMI MJIBDELKIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5BFE810", Offset = "0x5BFD610", VA = "0x185BFE810")]
	private void MHEENGCBCDJ(Entity DJHHEAHBFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5BFE3B0", Offset = "0x5BFD1B0", VA = "0x185BFE3B0")]
	private void FINMCJNKNDD(Entity DJHHEAHBFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5BFE5E0", Offset = "0x5BFD3E0", VA = "0x185BFE5E0")]
	private void LKOEGHBOPOP(Entity DJHHEAHBFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5BFE1A0", Offset = "0x5BFCFA0", VA = "0x185BFE1A0")]
	private void BCBAIENGJIP(Entity DJHHEAHBFFL, CLKBEOKLHMI MJIBDELKIML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5BFE580", Offset = "0x5BFD380", VA = "0x185BFE580")]
	private bool KNAFIECPIBC(CLKBEOKLHMI MJIBDELKIML, [Out] HashSet<object> HEHEIIMBBAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5BFE210", Offset = "0x5BFD010", VA = "0x185BFE210")]
	private HashSet<object> BENAMNGFKLH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class IBJKAMKMMDG
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct CKFKIJBGJGN : NOPBJELJPLJ<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x854A130", Offset = "0x8548F30", VA = "0x18854A130")]
	public float LMIOGFGFMDJ([In] float3 HGMAIPELJHM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x854A130", Offset = "0x8548F30", VA = "0x18854A130", Slot = "4")]
	private float AMGFDKGJBNJ([In] float3 HGMAIPELJHM)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct FLEDIKBMOJM : NOPBJELJPLJ<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x854A930", Offset = "0x8549730", VA = "0x18854A930")]
	public float LMIOGFGFMDJ([In] float3 HGMAIPELJHM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x854A930", Offset = "0x8549730", VA = "0x18854A930", Slot = "4")]
	private float AMGFDKGJBNJ([In] float3 HGMAIPELJHM)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct AIGJCEIFJKF : NOPBJELJPLJ<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x10047A0", Offset = "0x10035A0", VA = "0x1810047A0")]
	public float LMIOGFGFMDJ([In] float3 HGMAIPELJHM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x10047A0", Offset = "0x10035A0", VA = "0x1810047A0", Slot = "4")]
	private float AMGFDKGJBNJ([In] float3 HGMAIPELJHM)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct BGMMFECPEEE : NOPBJELJPLJ<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1469A30", Offset = "0x1468830", VA = "0x181469A30")]
	public int LMIOGFGFMDJ([In] int3 HGMAIPELJHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1469A30", Offset = "0x1468830", VA = "0x181469A30", Slot = "4")]
	private int FNIFJKBCFLM([In] int3 HGMAIPELJHM)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct LJIFIBKJKBM : NOPBJELJPLJ<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x13E7BD0", Offset = "0x13E69D0", VA = "0x1813E7BD0")]
	public int LMIOGFGFMDJ([In] int3 HGMAIPELJHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x13E7BD0", Offset = "0x13E69D0", VA = "0x1813E7BD0", Slot = "4")]
	private int FNIFJKBCFLM([In] int3 HGMAIPELJHM)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct MDLJIPMOCJL : NOPBJELJPLJ<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xFCADD0", Offset = "0xFC9BD0", VA = "0x180FCADD0")]
	public int LMIOGFGFMDJ([In] int3 HGMAIPELJHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xFCADD0", Offset = "0xFC9BD0", VA = "0x180FCADD0", Slot = "4")]
	private int FNIFJKBCFLM([In] int3 HGMAIPELJHM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BJBEJJODCNF : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x23B06A0", Offset = "0x23AF4A0", VA = "0x1823B06A0")]
	public BJBEJJODCNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class MECAHDPAGBH : SystemBase, CIHIOMCEGOC
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x854B030", Offset = "0x8549E30", VA = "0x18854B030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3DF9AB0", Offset = "0x3DF88B0", VA = "0x183DF9AB0")]
	public void FGBCMCLCEOD<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3DF9AB0", Offset = "0x3DF88B0", VA = "0x183DF9AB0")]
	public void EMPJJIOEBFF<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x854AF00", Offset = "0x8549D00", VA = "0x18854AF00")]
	public JobHandle DKGLFBIEOLM(ReadOnlySpan<int> DDBDEKMNPJB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3DF9B00", Offset = "0x3DF8900", VA = "0x183DF9B00")]
	public JobHandle LBKNNEFAEKD<T>() where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x854AF50", Offset = "0x8549D50", VA = "0x18854AF50")]
	public JobHandle LBKNNEFAEKD(ReadOnlySpan<int> DDBDEKMNPJB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3DF9790", Offset = "0x3DF8590", VA = "0x183DF9790")]
	public void LOLJGMNEAGA<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3DF9BA0", Offset = "0x3DF89A0", VA = "0x183DF9BA0")]
	public JobHandle LOLJGMNEAGA<T>(JobHandle MJIBDELKIML)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x854AFA0", Offset = "0x8549DA0", VA = "0x18854AFA0")]
	public JobHandle LOLJGMNEAGA(ReadOnlySpan<int> DDBDEKMNPJB, JobHandle MJIBDELKIML)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3DF9790", Offset = "0x3DF8590", VA = "0x183DF9790")]
	public void CKAEMBDAEHK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3DF96D0", Offset = "0x3DF84D0", VA = "0x183DF96D0")]
	public JobHandle CKAEMBDAEHK<T>(JobHandle MJIBDELKIML)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x854AE90", Offset = "0x8549C90", VA = "0x18854AE90")]
	public JobHandle CKAEMBDAEHK(Span<int> DDBDEKMNPJB, JobHandle MJIBDELKIML)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3DF9620", Offset = "0x3DF8420", VA = "0x183DF9620")]
	public ComponentDataFromEntity AHNNJLAJKJC<T>(bool GEOECIKGMFI = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x854ADD0", Offset = "0x8549BD0", VA = "0x18854ADD0")]
	public ComponentDataFromEntity AHNNJLAJKJC(int BIAFEEFNILC, bool GEOECIKGMFI = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3DFA3E0", Offset = "0x3DF91E0", VA = "0x183DFA3E0")]
	public SharedComponentIndexFromEntity<T> MFEPIICKGKA<T>() where T : ISharedComponentData
	{
		return default(SharedComponentIndexFromEntity<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x854B060", Offset = "0x8549E60", VA = "0x18854B060")]
	[BurstCompatible]
	public ComponentTypeHandle PGPPLPOCKLE(ComponentType MPNOOBCJBLD)
	{
		return default(ComponentTypeHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x854B010", Offset = "0x8549E10", VA = "0x18854B010")]
	public EntityExistenceLookupByEntity NNDKNPLPOOI()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x854B0C0", Offset = "0x8549EC0", VA = "0x18854B0C0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3DF9990", Offset = "0x3DF8790", VA = "0x183DF9990")]
	public bool ELKICACEFAL<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "7")]
	protected sealed override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x23B06A0", Offset = "0x23AF4A0", VA = "0x1823B06A0")]
	protected MECAHDPAGBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class ECDEMOLLNMM : MECAHDPAGBH
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x854A5C0", Offset = "0x85493C0", VA = "0x18854A5C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x23B06A0", Offset = "0x23AF4A0", VA = "0x1823B06A0")]
	protected ECDEMOLLNMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class NLGKOMFJNHC
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class OJDAHHAEMMI : EntityCommandBufferSystem, CIHIOMCEGOC
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private ALMLLDBPKBM ICNEBIIBIEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xEF7510", Offset = "0xEF6310", VA = "0x180EF7510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x854B150", Offset = "0x8549F50", VA = "0x18854B150")]
	public OJDAHHAEMMI(ALMLLDBPKBM IPEKLICENHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface NOPBJELJPLJ<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo LMIOGFGFMDJ([In] TFrom HGMAIPELJHM);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface LODCHBJDHGP<T>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EAFFAMBJHNI(T HGMAIPELJHM);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct JLNHBGPHJGG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> ALJPELHALEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer DFJCBGCMANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public ComponentTypes BFJMCPLMMNO;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x854A9E0", Offset = "0x85497E0", VA = "0x18854A9E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct GILONOIJHDM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> ALJPELHALEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer DFJCBGCMANC;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x854A940", Offset = "0x8549740", VA = "0x18854A940", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct JODAIGKPCJD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> ALJPELHALEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer DFJCBGCMANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public ComponentType MPNOOBCJBLD;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x854AAD0", Offset = "0x85498D0", VA = "0x18854AAD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[BurstCompile]
internal struct MGHJJGBNLBN<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> ALJPELHALEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> KANAIIDGHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer DFJCBGCMANC;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x58A7ED0", Offset = "0x58A6CD0", VA = "0x1858A7ED0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct NPBCFFPNBIH<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> ALJPELHALEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<T> OOFDDMCKJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer DFJCBGCMANC;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal struct BFAJKDDCECO<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<Entity> ALJPELHALEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public T HGMAIPELJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EntityCommandBuffer DFJCBGCMANC;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct AKFOAHBCHKE<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, NOPBJELJPLJ<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<TFrom> FGNBNNKCBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<TTo> GHFHOBFOGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public TMap IJBAPONMLAP;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct FAILBOGIPEA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity DBFBNKCPPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> FGNBNNKCBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeArray<byte> GHFHOBFOGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int CMCLBOPCOIO;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x854A610", Offset = "0x8549410", VA = "0x18854A610", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct EGHCOMCPCEN<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> NJBLBMHLHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<Entity> FGNBNNKCBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<T> DAEBOOGJNNG;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct LKBJDOBIJEL<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, NOPBJELJPLJ<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<TFrom> PDGJNHEOICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[WriteOnly]
	public NativeList<TTo> GHFHOBFOGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public TMap IJBAPONMLAP;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct CINGHNNLNNP<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> GMMDHHBGFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> EPMBMCCLIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> HBKDNFPCCDH;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct BPGFFOAJGDP<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public ComponentDataFromEntity<T> GMMDHHBGFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<Entity> EPMBMCCLIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<bool> HBKDNFPCCDH;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x68D1860", Offset = "0x68D0660", VA = "0x1868D1860", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct CNCODLMBOJD<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<T> FGNBNNKCBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<T> DAEBOOGJNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<T> GPGPOLEHPBC;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6D413C0", Offset = "0x6D401C0", VA = "0x186D413C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct GABFADHIDOP<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : NOPBJELJPLJ<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<TFrom> FGNBNNKCBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public NativeList<TFrom> DAEBOOGJNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeParallelHashSet<TTo> GPGPOLEHPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TMap IJBAPONMLAP;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct KFEBCIPGIME<T, TPredicate> : IJob where T : struct where TPredicate : struct, LODCHBJDHGP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> FGNBNNKCBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<Entity> KHMLBNPLNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<Entity> MIEPAGACMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate IJBAPONMLAP;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct HDFKDEFFAMG<T, TPredicate> : IJob where T : struct where TPredicate : struct, LODCHBJDHGP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> FGNBNNKCBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> DAEBOOGJNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TPredicate IJBAPONMLAP;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct FFNICFIADJM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity GMMDHHBGFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> EPMBMCCLIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> AKAFPNHEFID;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x854A8A0", Offset = "0x85496A0", VA = "0x18854A8A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct PIHDANAMBHE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[ReadOnly]
	public ComponentDataFromEntity GMMDHHBGFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<Entity> EPMBMCCLIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<Entity> AKAFPNHEFID;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x854B180", Offset = "0x8549F80", VA = "0x18854B180", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class KKJBEOJDDJD
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class ELDPCNEMPHE
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3B835F0", Offset = "0x3B823F0", VA = "0x183B835F0")]
	public static bool LOBFBHKJAID<T>(this NativeArray<Entity> EPMBMCCLIEK, EntityManager OPLCAABCINH, Allocator GIEDOJCOPKP = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class LGMHPGJDMKO
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class LDAAJOLOGPM<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		public LDAAJOLOGPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class CHHBDEAOJKI<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public CHHBDEAOJKI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly List<Func<JobHandle, JobHandle>> KDMLOMHJBDJ;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x854AD30", Offset = "0x8549B30", VA = "0x18854AD30")]
	public LGMHPGJDMKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class IGFODGDPFBM
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class AAAOOCNIFJK
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct EMBJMONJLOK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct KKOMJJBEHEJ<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal EMBJMONJLOK<TFrom> PJGOIMBEKPK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator GIEDOJCOPKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeArray<TFrom> HNLFFLNNKGK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct EADGGHHGAIP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct KAHAEDMEHLE<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal EADGGHHGAIP<TFrom> PJGOIMBEKPK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator GIEDOJCOPKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeList<TFrom> HNLFFLNNKGK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct KKAOMPDHFME<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct LHHLKCHDODF<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal KKAOMPDHFME<TFrom> PJGOIMBEKPK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator GIEDOJCOPKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeArrayAsync<TFrom> HNLFFLNNKGK;
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct IPAEALNKGJA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public struct ONEMMDLLCBG<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			internal IPAEALNKGJA<TFrom> PJGOIMBEKPK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal Allocator GIEDOJCOPKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal NativeListAsync<TFrom> HNLFFLNNKGK;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class EDJJCKKFIBN
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class GAMJLNKFAHC
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3CF2260", Offset = "0x3CF1060", VA = "0x183CF2260")]
	public static NativeList<T> CNILDMAOPDB<T>(this NativeArray<T> EDNBKBFLIDL, Allocator GIEDOJCOPKP = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class DPDMPDBAKLO
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class DDIIHMPBDFH
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3B55530", Offset = "0x3B54330", VA = "0x183B55530")]
	[AFEBFGJMFHG]
	public static JobHandle PDMBKFJFLEN<T>(this EntityCommandBufferSystem PMFHNPOBHPO, NativeArray<Entity> ALJPELHALEH, NativeArray<T> KANAIIDGHCH) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3B553D0", Offset = "0x3B541D0", VA = "0x183B553D0")]
	[AFEBFGJMFHG]
	public static JobHandle PDMBKFJFLEN<T>(this EntityCommandBufferSystem PMFHNPOBHPO, NativeArrayAsync<Entity> ALJPELHALEH, NativeArrayAsync<T> KANAIIDGHCH, [Optional] JobHandle JCCEIFLBMMA) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3B552B0", Offset = "0x3B540B0", VA = "0x183B552B0")]
	[AFEBFGJMFHG]
	public static JobHandle PDMBKFJFLEN<T>(this EntityCommandBufferSystem PMFHNPOBHPO, NativeArray<Entity> ALJPELHALEH, [Optional] JobHandle JCCEIFLBMMA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x854A300", Offset = "0x8549100", VA = "0x18854A300")]
	[AFEBFGJMFHG]
	public static JobHandle PDMBKFJFLEN(this EntityCommandBufferSystem PMFHNPOBHPO, NativeArray<Entity> ALJPELHALEH, ComponentTypes BFJMCPLMMNO, [Optional] JobHandle JCCEIFLBMMA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x854A470", Offset = "0x8549270", VA = "0x18854A470")]
	[AFEBFGJMFHG]
	public static JobHandle PDMBKFJFLEN(this EntityCommandBufferSystem PMFHNPOBHPO, EntityCommandBuffer DFJCBGCMANC, NativeArray<Entity> ALJPELHALEH, ComponentTypes BFJMCPLMMNO, [Optional] JobHandle JCCEIFLBMMA)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class IAFEMFFENMC
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class ADHNEKKLDEO
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8549E60", Offset = "0x8548C60", VA = "0x188549E60")]
	[AFEBFGJMFHG]
	public static JobHandle MMOCMDIDCLD(this EntityCommandBufferSystem PMFHNPOBHPO, NativeList<Entity> ALJPELHALEH, [Optional] JobHandle JCCEIFLBMMA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8549FF0", Offset = "0x8548DF0", VA = "0x188549FF0")]
	[AFEBFGJMFHG]
	public static JobHandle MMOCMDIDCLD(this EntityCommandBufferSystem PMFHNPOBHPO, NativeArrayAsync<Entity> ALJPELHALEH)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class FCBOLNHNJJO
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3CDABF0", Offset = "0x3CD99F0", VA = "0x183CDABF0")]
	public static void LMDOHFCDDKP<T>(this EntityCommandBufferSystem PMFHNPOBHPO, EntityQuery ENBMOIDBGKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3CDAB50", Offset = "0x3CD9950", VA = "0x183CDAB50")]
	[AFEBFGJMFHG]
	public static JobHandle DHAIEDOFOJD<T>(this EntityCommandBufferSystem PMFHNPOBHPO, NativeArrayAsync<Entity> ALJPELHALEH, [Optional] JobHandle JCCEIFLBMMA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x854A710", Offset = "0x8549510", VA = "0x18854A710")]
	[AFEBFGJMFHG]
	public static JobHandle DHAIEDOFOJD(this EntityCommandBufferSystem PMFHNPOBHPO, NativeArrayAsync<Entity> ALJPELHALEH, ComponentType MPNOOBCJBLD, [Optional] JobHandle JCCEIFLBMMA)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class JEJIAEEDKBM
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3D69BD0", Offset = "0x3D689D0", VA = "0x183D69BD0")]
	[AFEBFGJMFHG]
	public static JobHandle DEAPPKBIAFH<T>(this EntityCommandBufferSystem PMFHNPOBHPO, NativeArray<Entity> ALJPELHALEH, NativeArray<T> KANAIIDGHCH, JobHandle JCCEIFLBMMA) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class GFBLFDDIGMC
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class CBKOHMBEHML
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class KCDBMFJEHJM
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3DA4FD0", Offset = "0x3DA3DD0", VA = "0x183DA4FD0")]
	public static NativeArray<T> PJPLCDKKEBA<T>(this NativeList<Entity> EDNBKBFLIDL, EntityManager OPLCAABCINH, Allocator GIEDOJCOPKP = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3DA4C50", Offset = "0x3DA3A50", VA = "0x183DA4C50")]
	public static NativeArray<T> PJPLCDKKEBA<T>(this NativeArray<Entity> EDNBKBFLIDL, EntityManager OPLCAABCINH, Allocator GIEDOJCOPKP = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x854AB50", Offset = "0x8549950", VA = "0x18854AB50")]
	public static NativeArray<Entity> CIELEOJFHGB(this NativeArray<Entity> EDNBKBFLIDL, EntityManager OPLCAABCINH, ComponentType MPNOOBCJBLD, Allocator GIEDOJCOPKP = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3DA4B50", Offset = "0x3DA3950", VA = "0x183DA4B50")]
	public static NativeArray<T> JIKBIEGAFPM<T>(this NativeArray<Entity> EDNBKBFLIDL, EntityManager OPLCAABCINH, Allocator GIEDOJCOPKP = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class IEININHPCJO
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct PLNLKHPFLGK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct KCHJCOBMMEP<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public PLNLKHPFLGK<TFrom> HNLFFLNNKGK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator GIEDOJCOPKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArray<TFrom> FGNBNNKCBGI;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct DIOCCDIPEGC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct LLNCIAOBCGO<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public DIOCCDIPEGC<TFrom> HNLFFLNNKGK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator GIEDOJCOPKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeArrayAsync<TFrom> FGNBNNKCBGI;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct IMGEGLEIDBG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public struct FBCDMJFNLCN<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public IMGEGLEIDBG<TFrom> HNLFFLNNKGK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator GIEDOJCOPKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeListAsync<TFrom> FGNBNNKCBGI;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class LKONKBLDPDG
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class KHCGIGCPAPB
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct MBMLEGIDPMM : NOPBJELJPLJ<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> GMODDMIJDOG;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x854ADC0", Offset = "0x8549BC0", VA = "0x18854ADC0")]
		[BurstCompatible]
		public Entity LMIOGFGFMDJ([In] Entity HGMAIPELJHM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x854ADC0", Offset = "0x8549BC0", VA = "0x18854ADC0", Slot = "4")]
		private Entity FLKGLKFCLII([In] Entity HGMAIPELJHM)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class DBMABEKJEGM
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct PJOMKDHDHGD<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5C02B30", Offset = "0x5C01930", VA = "0x185C02B30", Slot = "4")]
		public int Compare((TKey, TValue) DBBMOEGPNPP, (TKey, TValue) COFKGIHGCOO)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3B4F410", Offset = "0x3B4E210", VA = "0x183B4F410")]
	public static void IMBOEMCPKHB<TKey, TValue>(NativeList<TKey> HHBNDGLMMPK, NativeList<TValue> OOFDDMCKJPA) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3B4F890", Offset = "0x3B4E690", VA = "0x183B4F890")]
	public static void IMBOEMCPKHB<TKey, TValue>(NativeArray<TKey> HHBNDGLMMPK, NativeArray<TValue> OOFDDMCKJPA) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3B4F680", Offset = "0x3B4E480", VA = "0x183B4F680")]
	public static void IMBOEMCPKHB<TKey, TValue, U>(NativeArray<TKey> HHBNDGLMMPK, NativeArray<TValue> OOFDDMCKJPA, U AFNPGFLCAAK) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class FBBOBONJHBA
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct NEDKMNKKOBG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator GIEDOJCOPKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<Entity> KHMLBNPLNEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> FGNBNNKCBGI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct MLHDEPEMHJG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator GIEDOJCOPKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeList<Entity> KHMLBNPLNEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArray<T> FGNBNNKCBGI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct EFDHJIFHJAD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator GIEDOJCOPKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArrayAsync<Entity> KHMLBNPLNEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArrayAsync<T> FGNBNNKCBGI;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class IPODDCFMPPC
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class EGNPGPOPBFL
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct LKAFJNEJNLI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator GIEDOJCOPKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArray<T> FGNBNNKCBGI;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct FHBJCELDOON<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator GIEDOJCOPKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeList<T> FGNBNNKCBGI;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct CAMBLHLKALI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator GIEDOJCOPKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<T> FGNBNNKCBGI;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct KANOCLELNII<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Allocator GIEDOJCOPKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NativeListAsync<T> FGNBNNKCBGI;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class GFPDKNFPLFC
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class BODFGJHJOIB
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3AA6AA0", Offset = "0x3AA58A0", VA = "0x183AA6AA0")]
	public static NativeList<Entity> DMHFBMJMFHD<T>(this NativeList<Entity> EPMBMCCLIEK, EntityManager OPLCAABCINH, Allocator GIEDOJCOPKP = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3AA64A0", Offset = "0x3AA52A0", VA = "0x183AA64A0")]
	public static NativeList<Entity> DMHFBMJMFHD<T>(this NativeArray<Entity> EPMBMCCLIEK, EntityManager OPLCAABCINH, Allocator GIEDOJCOPKP = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class NBFGFEKEHFG
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3E6F140", Offset = "0x3E6DF40", VA = "0x183E6F140")]
	public static NativeList<Entity> CFHEAKOCFMB<T>(this NativeArray<Entity> EPMBMCCLIEK, EntityManager OPLCAABCINH, Allocator GIEDOJCOPKP = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class BFJCKHNHHAL
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public readonly struct CDOCHOPCAGD<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> ELLFIONNNHC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public readonly struct ODJPLMIEKMP<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> ELLFIONNNHC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public readonly struct CNLOJHMCLII<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, NOPBJELJPLJ<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly NativeArray<TSrc> ELLFIONNNHC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct HPLLGCDJBFK<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, NOPBJELJPLJ<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly NativeArray<TSrc> ELLFIONNNHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TSelector PJDJOLIJCBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int JJJJBEGKNIN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct LACPLCBACCJ<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, NOPBJELJPLJ<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private HPLLGCDJBFK<TSrc, TValue, TSelector> IFLDEFEGGME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TValue BANABODNPKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int DOCKBMMINED;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class GLPOHKAHFIM
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct AKDMNKLILOA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<T> ELLFIONNNHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int DOCKBMMINED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int CLJMGHAJOFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private T BANABODNPKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T PHELNMFFAEL;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public EFHLFJNDJJB EBKEJEDDGAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x520B260", Offset = "0x520A060", VA = "0x18520B260")]
			get
			{
				return default(EFHLFJNDJJB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public T HBLIIJGJJLI
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public (T, EFHLFJNDJJB) BONNGALDEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x520B480", Offset = "0x520A280", VA = "0x18520B480")]
			get
			{
				return default((T, EFHLFJNDJJB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x52B74D0", Offset = "0x52B62D0", VA = "0x1852B74D0")]
		public AKDMNKLILOA(NativeArray<T> ELLFIONNNHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4B304D0", Offset = "0x4B2F2D0", VA = "0x184B304D0")]
		public AKDMNKLILOA<T> OLGNAIIDMLF()
		{
			return default(AKDMNKLILOA<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x52B7020", Offset = "0x52B5E20", VA = "0x1852B7020")]
		public bool DMJFHJJLFGD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x32235A0", Offset = "0x32223A0", VA = "0x1832235A0")]
		public ICDGGJNILCI<T, TComparer> FPDINKFGNMJ<TComparer>([Optional] TComparer AFNPGFLCAAK) where TComparer : struct, IEqualityComparer<T>
		{
			return default(ICDGGJNILCI<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct ICDGGJNILCI<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly NativeArray<T> ELLFIONNNHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int DOCKBMMINED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int CLJMGHAJOFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private T BANABODNPKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private T PHELNMFFAEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TComparer AFNPGFLCAAK;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public EFHLFJNDJJB EBKEJEDDGAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x520B260", Offset = "0x520A060", VA = "0x18520B260")]
			get
			{
				return default(EFHLFJNDJJB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T HBLIIJGJJLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public (T value, EFHLFJNDJJB range) BONNGALDEBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x520B480", Offset = "0x520A280", VA = "0x18520B480")]
			get
			{
				return default((T, EFHLFJNDJJB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x520B690", Offset = "0x520A490", VA = "0x18520B690")]
		public ICDGGJNILCI(NativeArray<T> ELLFIONNNHC, TComparer AFNPGFLCAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7710", Offset = "0x3CF6510", VA = "0x183CF7710")]
		public ICDGGJNILCI<T, TComparer> OLGNAIIDMLF()
		{
			return default(ICDGGJNILCI<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x520B270", Offset = "0x520A070", VA = "0x18520B270")]
		public bool DMJFHJJLFGD()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3D01990", Offset = "0x3D00790", VA = "0x183D01990")]
	public static AKDMNKLILOA<T> EFNDCEMNJAM<T>(this NativeArray<T> ELLFIONNNHC) where T : struct
	{
		return default(AKDMNKLILOA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface NIHIOAJPJCH
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class MDJNHJLINEO
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct FBDKJAMPMCP<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class OPIGHLKJIJE : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public FBDKJAMPMCP<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xD81A70", Offset = "0xD80870", VA = "0x180D81A70", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4FA5F30", Offset = "0x4FA4D30", VA = "0x184FA5F30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA943B0", Offset = "0xA931B0", VA = "0x180A943B0")]
		[DebuggerHidden]
		public OPIGHLKJIJE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5B2EB30", Offset = "0x5B2D930", VA = "0x185B2EB30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5B2ECE0", Offset = "0x5B2DAE0", VA = "0x185B2ECE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly Action<Protobuf> OMPIJMGHNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MemoryStream NHGEKAGHMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CodedInputStream COILLFJAPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Protobuf MNKEFBDJGBG;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly int PJDGOCCOECF
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7130", Offset = "0x4EF5F30", VA = "0x184EF7130", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7170", Offset = "0x4EF5F70", VA = "0x184EF7170", Slot = "4")]
	[IteratorStateMachine(typeof(FBDKJAMPMCP<>.OPIGHLKJIJE))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7260", Offset = "0x4EF6060", VA = "0x184EF7260", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct LEAIDGLFHDF<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly byte[] ALPKAMHLIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Protobuf MNKEFBDJGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream NHGEKAGHMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedOutputStream BHNLOJKACGG;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5683450", Offset = "0x5682250", VA = "0x185683450", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct AKILOGPJHOJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream NHGEKAGHMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedInputStream COILLFJAPMM;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x854A0F0", Offset = "0x8548EF0", VA = "0x18854A0F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct DCPJBLKJOPE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] ALPKAMHLIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly MemoryStream NHGEKAGHMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly CodedOutputStream BHNLOJKACGG;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x854A1E0", Offset = "0x8548FE0", VA = "0x18854A1E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class GOANGGANJGC
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class OLEICDIJMID
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[Flags]
public enum IOHDEFIEJBG
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
internal static class LPLGCNOFCDD
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class EDFFLPDHNEN
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public EDFFLPDHNEN()
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
