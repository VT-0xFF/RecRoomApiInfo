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
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D75B20", Offset = "0x6D74D20", VA = "0x186D75B20")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HEBBHPABFIC : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	GEBNEDGKNJP LBDCCKDLGCF
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
public interface BFGIGDFEEKK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FGFPOBDGDCN(Entity NCLCOHLPCDH, object NIOIDOPDJKO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MOAPEAOGJNN(Entity NCLCOHLPCDH, object NIOIDOPDJKO);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EBHLGDOBDFC(Entity NCLCOHLPCDH);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class PPMEFCJAIEA<TComponentData, TValue> : FLDIDDICPKE<TValue>, IDisposable where TComponentData : struct, HEBBHPABFIC
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class ELDGONPCPHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> NAGHBLHDGIK;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int HDFADKJDLLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x383DF00", Offset = "0x383D100", VA = "0x18383DF00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3AE5A00", Offset = "0x3AE4C00", VA = "0x183AE5A00")]
		public bool OOEAKGOPBFL([Out] TValue JECHHBGMFLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3AE5790", Offset = "0x3AE4990", VA = "0x183AE5790")]
		public void JIJNOIKPNBF(object NIOIDOPDJKO, TValue JECHHBGMFLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3AE5870", Offset = "0x3AE4A70", VA = "0x183AE5870")]
		public bool LOGGCHCCBFB(object NIOIDOPDJKO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3AE5920", Offset = "0x3AE4B20", VA = "0x183AE5920")]
		public int MHOEOPCMNNM(object NIOIDOPDJKO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3AE5B10", Offset = "0x3AE4D10", VA = "0x183AE5B10")]
		public ELDGONPCPHF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<ELDGONPCPHF> FINFGENFLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private APBBLCBEBKE<GEBNEDGKNJP, ELDGONPCPHF> FLMKKHJNEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager FFFGHCELNHC;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4AC3280", Offset = "0x4AC2480", VA = "0x184AC3280")]
	public PPMEFCJAIEA(EntityManager FFFGHCELNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4AC2C20", Offset = "0x4AC1E20", VA = "0x184AC2C20", Slot = "4")]
	public void FGFPOBDGDCN(Entity NCLCOHLPCDH, object NIOIDOPDJKO, TValue JECHHBGMFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4AC2F80", Offset = "0x4AC2180", VA = "0x184AC2F80", Slot = "5")]
	public bool MOAPEAOGJNN(Entity NCLCOHLPCDH, object NIOIDOPDJKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4AC3170", Offset = "0x4AC2370", VA = "0x184AC3170", Slot = "6")]
	public bool OOEAKGOPBFL(Entity NCLCOHLPCDH, [Out] TValue JECHHBGMFLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4AC2B40", Offset = "0x4AC1D40", VA = "0x184AC2B40", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4AC2DA0", Offset = "0x4AC1FA0", VA = "0x184AC2DA0")]
	private void IKOCPIMCHMF(ELDGONPCPHF GKNKPPMMOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4AC2B60", Offset = "0x4AC1D60", VA = "0x184AC2B60")]
	private bool EBNNHJDPIJD(Entity NCLCOHLPCDH, [Out] GEBNEDGKNJP OLMIMHPMKPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4AC2E60", Offset = "0x4AC2060", VA = "0x184AC2E60")]
	private void JBGLBGJGLBD(Entity NCLCOHLPCDH, GEBNEDGKNJP OLMIMHPMKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4AC2F60", Offset = "0x4AC2160", VA = "0x184AC2F60")]
	private bool LNCIPODPECL(GEBNEDGKNJP OLMIMHPMKPE, [Out] ELDGONPCPHF GKNKPPMMOFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4AC2A20", Offset = "0x4AC1C20", VA = "0x184AC2A20")]
	private ELDGONPCPHF CKPBLHFJALM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FLDIDDICPKE<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FGFPOBDGDCN(Entity NCLCOHLPCDH, object NIOIDOPDJKO, TValue JECHHBGMFLN);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MOAPEAOGJNN(Entity NCLCOHLPCDH, object NIOIDOPDJKO);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OOEAKGOPBFL(Entity NCLCOHLPCDH, [Out] TValue JECHHBGMFLN);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct GEBNEDGKNJP : EMEHIMPIDLI, IEquatable<GEBNEDGKNJP>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly GEBNEDGKNJP GGGKIMCNGIE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int NLHHONDOFEE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8FBD00", Offset = "0x8FAF00", VA = "0x1808FBD00", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xC02B40", Offset = "0xC01D40", VA = "0x180C02B40", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int CMFKKIIIDLC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x27BA930", Offset = "0x27B9B30", VA = "0x1827BA930", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x601C7D0", Offset = "0x601B9D0", VA = "0x18601C7D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6D75CD0", Offset = "0x6D74ED0", VA = "0x186D75CD0", Slot = "8")]
	public bool Equals(GEBNEDGKNJP KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6D75D20", Offset = "0x6D74F20", VA = "0x186D75D20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class AACOEOIAMBJ<THasTokensTag> : BFGIGDFEEKK, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly GAFGFHIJEHD ACKGBNDHEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, GEBNEDGKNJP> HHMCGKHNFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> FINFGENFLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private APBBLCBEBKE<GEBNEDGKNJP, HashSet<object>> FLMKKHJNEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager FFFGHCELNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem IJMJAJIILGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool HLBKMNGGNJD;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3EFD420", Offset = "0x3EFC620", VA = "0x183EFD420")]
	public AACOEOIAMBJ(EntityManager FFFGHCELNHC, EntityCommandBufferSystem IJMJAJIILGC, GAFGFHIJEHD JCLIMOFBGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3EFB400", Offset = "0x3EFA600", VA = "0x183EFB400", Slot = "4")]
	public bool FGFPOBDGDCN(Entity NCLCOHLPCDH, object NIOIDOPDJKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3EFCF30", Offset = "0x3EFC130", VA = "0x183EFCF30", Slot = "5")]
	public bool MOAPEAOGJNN(Entity NCLCOHLPCDH, object NIOIDOPDJKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3EFAE40", Offset = "0x3EFA040", VA = "0x183EFAE40", Slot = "6")]
	public bool EBHLGDOBDFC(Entity NCLCOHLPCDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3EFAEF0", Offset = "0x3EFA0F0", VA = "0x183EFAEF0", Slot = "8")]
	public bool EBHLGDOBDFC(GEBNEDGKNJP OLMIMHPMKPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3EFAD50", Offset = "0x3EF9F50", VA = "0x183EFAD50", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3EFBDA0", Offset = "0x3EFAFA0", VA = "0x183EFBDA0")]
	private void IKOCPIMCHMF(HashSet<object> GKNKPPMMOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3EFB340", Offset = "0x3EFA540", VA = "0x183EFB340")]
	private bool EBNNHJDPIJD(Entity NCLCOHLPCDH, [Out] GEBNEDGKNJP OLMIMHPMKPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3EFC5C0", Offset = "0x3EFB7C0", VA = "0x183EFC5C0")]
	private bool LNIPKGDMKOM(Entity NCLCOHLPCDH, [Out] GEBNEDGKNJP OLMIMHPMKPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3EFA990", Offset = "0x3EF9B90", VA = "0x183EFA990")]
	private void DMENFGFCNMD(Entity NCLCOHLPCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3EFC340", Offset = "0x3EFB540", VA = "0x183EFC340")]
	private void JFIDPPAGOOH(Entity NCLCOHLPCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3EFC920", Offset = "0x3EFBB20", VA = "0x183EFC920")]
	private void MEPPALJINOO(Entity NCLCOHLPCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3EFBEF0", Offset = "0x3EFB0F0", VA = "0x183EFBEF0")]
	private void JBGLBGJGLBD(Entity NCLCOHLPCDH, GEBNEDGKNJP OLMIMHPMKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3EFBC00", Offset = "0x3EFAE00", VA = "0x183EFBC00")]
	private bool HGHBLBLIENN(GEBNEDGKNJP OLMIMHPMKPE, [Out] HashSet<object> GKNKPPMMOFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3EFA7F0", Offset = "0x3EF99F0", VA = "0x183EFA7F0")]
	private HashSet<object> CKPBLHFJALM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class PIGBEKJFNGI
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct JGKGLIFMFEJ : LGECDGMPBAO<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6D75DA0", Offset = "0x6D74FA0", VA = "0x186D75DA0")]
	public float MMNDBOJPAOE([In] float3 JECHHBGMFLN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6D75DA0", Offset = "0x6D74FA0", VA = "0x186D75DA0", Slot = "4")]
	private float FGJNCDGNEFP([In] float3 JECHHBGMFLN)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct LDAAGHBHOIH : LGECDGMPBAO<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6D75DB0", Offset = "0x6D74FB0", VA = "0x186D75DB0")]
	public float MMNDBOJPAOE([In] float3 JECHHBGMFLN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6D75DB0", Offset = "0x6D74FB0", VA = "0x186D75DB0", Slot = "4")]
	private float FGJNCDGNEFP([In] float3 JECHHBGMFLN)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct AKMDNNPKPMP : LGECDGMPBAO<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x9A87A0", Offset = "0x9A79A0", VA = "0x1809A87A0")]
	public float MMNDBOJPAOE([In] float3 JECHHBGMFLN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x9A87A0", Offset = "0x9A79A0", VA = "0x1809A87A0", Slot = "4")]
	private float FGJNCDGNEFP([In] float3 JECHHBGMFLN)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct DJNLCPJHFNC : LGECDGMPBAO<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1A4E1B0", Offset = "0x1A4D3B0", VA = "0x181A4E1B0")]
	public int MMNDBOJPAOE([In] int3 JECHHBGMFLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1A4E1B0", Offset = "0x1A4D3B0", VA = "0x181A4E1B0", Slot = "4")]
	private int EBKLDNHIBIE([In] int3 JECHHBGMFLN)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct EBKLKALHDGD : LGECDGMPBAO<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6D75B10", Offset = "0x6D74D10", VA = "0x186D75B10")]
	public int MMNDBOJPAOE([In] int3 JECHHBGMFLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6D75B10", Offset = "0x6D74D10", VA = "0x186D75B10", Slot = "4")]
	private int EBKLDNHIBIE([In] int3 JECHHBGMFLN)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct AELEMOHJHBO : LGECDGMPBAO<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x98C900", Offset = "0x98BB00", VA = "0x18098C900")]
	public int MMNDBOJPAOE([In] int3 JECHHBGMFLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x98C900", Offset = "0x98BB00", VA = "0x18098C900", Slot = "4")]
	private int EBKLDNHIBIE([In] int3 JECHHBGMFLN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class BOADFMDNFED : OKIICLHPAHL
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1966710", Offset = "0x1965910", VA = "0x181966710")]
	public BOADFMDNFED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class PFEGOKKGDJD : SystemBase, PDIOHAPDFNE
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6D76060", Offset = "0x6D75260", VA = "0x186D76060")]
	public JobHandle HLJKKKIGKFL(ReadOnlySpan<int> GLBCDLIFIFB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2FC5DC0", Offset = "0x2FC4FC0", VA = "0x182FC5DC0")]
	public void GLGMHOHOBGA<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2FC5C00", Offset = "0x2FC4E00", VA = "0x182FC5C00")]
	public JobHandle GLGMHOHOBGA<T>(JobHandle OLMIMHPMKPE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6D75FF0", Offset = "0x6D751F0", VA = "0x186D75FF0")]
	public JobHandle GLGMHOHOBGA(ReadOnlySpan<int> GLBCDLIFIFB, JobHandle OLMIMHPMKPE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2FC6630", Offset = "0x2FC5830", VA = "0x182FC6630")]
	public JobHandle MKLDBLAAKHO<T>(JobHandle OLMIMHPMKPE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6D760D0", Offset = "0x6D752D0", VA = "0x186D760D0")]
	public ComponentDataFromEntity PCFGOINOIME(int MJFABBCHFHM, bool BMFPIGLLCJI = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6D760B0", Offset = "0x6D752B0", VA = "0x186D760B0")]
	public EntityExistenceLookupByEntity LHCHLDMGANH()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6D76190", Offset = "0x6D75390", VA = "0x186D76190", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1966710", Offset = "0x1965910", VA = "0x181966710")]
	protected PFEGOKKGDJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class HPBMKEBEJNH : PFEGOKKGDJD
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6D75D70", Offset = "0x6D74F70", VA = "0x186D75D70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1966710", Offset = "0x1965910", VA = "0x181966710")]
	protected HPBMKEBEJNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class OMJACJGJHEL
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class IEOIEOBFBJK : EntityCommandBufferSystem, PDIOHAPDFNE
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1966710", Offset = "0x1965910", VA = "0x181966710")]
	protected IEOIEOBFBJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LGECDGMPBAO<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo MMNDBOJPAOE([In] TFrom JECHHBGMFLN);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface JPJANKFLJDD<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MDFMNNNLDOH(T JECHHBGMFLN);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BurstCompile]
internal struct BBJPJIDIMFN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[ReadOnly]
	public NativeArray<Entity> HEECCMKMEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public EntityCommandBuffer JHODHHLBFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public ComponentTypes OALDCFEEKEL;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6D754D0", Offset = "0x6D746D0", VA = "0x186D754D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct PPGJAGHGHME : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> HEECCMKMEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer JHODHHLBFEC;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6D761A0", Offset = "0x6D753A0", VA = "0x186D761A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct COKEAFEIKGE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public NativeArray<Entity> HEECCMKMEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public EntityCommandBuffer JHODHHLBFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public ComponentType IPNKBHACDMK;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6D75850", Offset = "0x6D74A50", VA = "0x186D75850", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct OCLEHMMGGDA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> HEECCMKMEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public NativeArray<T> LJIEGDEDOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public EntityCommandBuffer JHODHHLBFEC;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4956190", Offset = "0x4955390", VA = "0x184956190", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal struct ACDANPAGGKB<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> HEECCMKMEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> JFBMKPGOEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer JHODHHLBFEC;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct KAGNEDLPHNM<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> HEECCMKMEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public T JECHHBGMFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer JHODHHLBFEC;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4469940", Offset = "0x4468B40", VA = "0x184469940", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BurstCompile]
internal struct AMDCKFGFADD<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, LGECDGMPBAO<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<TFrom> COMFGEABODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[WriteOnly]
	public NativeArray<TTo> PDCDDGMANMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public TMap ECFGAICLGCA;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct GDOCNNCNLOO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public ComponentDataFromEntity OLEBHJHHBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> COMFGEABODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[WriteOnly]
	public NativeArray<byte> PDCDDGMANMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int GCFEEIJAMBM;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6D75BD0", Offset = "0x6D74DD0", VA = "0x186D75BD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct HBOHJCJGOIB<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public ComponentDataFromEntity<T> DINDJLBGCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public NativeArray<Entity> COMFGEABODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[WriteOnly]
	public NativeList<T> MBKGBOILMMH;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct HPMDOLLKFBP<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, LGECDGMPBAO<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> OIFCOOAGFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeList<TTo> PDCDDGMANMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap ECFGAICLGCA;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct PFNMBMBKLNP<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity<T> FCOPDCLHJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> PPJJLNGJHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<bool> KGMJIEEKHEM;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct FHPOEJEDCHG<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> FCOPDCLHJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> PPJJLNGJHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> KGMJIEEKHEM;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3E997F0", Offset = "0x3E989F0", VA = "0x183E997F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct AHIFMINODPO<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<T> COMFGEABODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeList<T> MBKGBOILMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeParallelHashSet<T> LGEDMEBEGIJ;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3F3B2C0", Offset = "0x3F3A4C0", VA = "0x183F3B2C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct KCMHPNNALMA<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : LGECDGMPBAO<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<TFrom> COMFGEABODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<TFrom> MBKGBOILMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<TTo> LGEDMEBEGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public TMap ECFGAICLGCA;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct BJEMMLGPPPA<T, TPredicate> : IJob where T : struct where TPredicate : struct, JPJANKFLJDD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public NativeArray<T> COMFGEABODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> GNJKBKCJIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeList<Entity> BEFLILCGMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public TPredicate ECFGAICLGCA;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct JBHADLBHOBB<T, TPredicate> : IJob where T : struct where TPredicate : struct, JPJANKFLJDD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<T> COMFGEABODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<T> MBKGBOILMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate ECFGAICLGCA;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct GCHNFOMGLDL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public ComponentDataFromEntity FCOPDCLHJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	public NativeArray<Entity> PPJJLNGJHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeList<Entity> GPAKENFEIAL;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6D75B40", Offset = "0x6D74D40", VA = "0x186D75B40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct DCIGMAAOOCP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity FCOPDCLHJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> PPJJLNGJHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> GPAKENFEIAL;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6D759F0", Offset = "0x6D74BF0", VA = "0x186D759F0", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class DLIAPKPKKKA
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class FIBEOHHIBGO
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2DFCA00", Offset = "0x2DFBC00", VA = "0x182DFCA00")]
	public static bool NEANDKGNBEL<T>(this NativeArray<Entity> PPJJLNGJHAK, EntityManager FFFGHCELNHC, Allocator PKPCACFEGCG = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class DJBFIDKJIKD
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class JDFOBIOHKCK<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		public JDFOBIOHKCK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class CCGLFAIEDIE<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		public CCGLFAIEDIE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly List<Func<JobHandle, JobHandle>> FBCOPEEKMOP;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6D75A80", Offset = "0x6D74C80", VA = "0x186D75A80")]
	public DJBFIDKJIKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class PEBLLIGHAHG
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class LGBPFPKHNHP
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct NMJGILBLOHJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct IPBHEFCHKLB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			internal NMJGILBLOHJ<TFrom> MBOJNCFILKL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal Allocator PKPCACFEGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal NativeArray<TFrom> MMPBCCIBPMB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct EKAKNMCAAMK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct JMHOBPJKMJL<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal EKAKNMCAAMK<TFrom> MBOJNCFILKL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator PKPCACFEGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeList<TFrom> MMPBCCIBPMB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct PINCKGCGJAM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct PNNCOFLKIFA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal PINCKGCGJAM<TFrom> MBOJNCFILKL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator PKPCACFEGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeArrayAsync<TFrom> MMPBCCIBPMB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct KGDFHCIOKEK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct LHECHNMEJAB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal KGDFHCIOKEK<TFrom> MBOJNCFILKL;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator PKPCACFEGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeListAsync<TFrom> MMPBCCIBPMB;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class JMOABDENPOI
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class BGOFGGAAALI
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2BA81C0", Offset = "0x2BA73C0", VA = "0x182BA81C0")]
	public static NativeList<T> JIEECGGJCCH<T>(this NativeArray<T> JKDPIAPOCMC, Allocator PKPCACFEGCG = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class MJCFGBFOGEA
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class ABNKOALFNAE
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x34FC1D0", Offset = "0x34FB3D0", VA = "0x1834FC1D0")]
	[IICFKAJGBEP]
	public static JobHandle BIJLDBPFODJ<T>(this EntityCommandBufferSystem IJMJAJIILGC, NativeArrayAsync<Entity> HEECCMKMEOO, NativeArrayAsync<T> LJIEGDEDOHM, [Optional] JobHandle GAHDLBCEEBH) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x34FC350", Offset = "0x34FB550", VA = "0x1834FC350")]
	[IICFKAJGBEP]
	public static JobHandle BIJLDBPFODJ<T>(this EntityCommandBufferSystem IJMJAJIILGC, NativeArrayAsync<Entity> HEECCMKMEOO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x34FC0A0", Offset = "0x34FB2A0", VA = "0x1834FC0A0")]
	[IICFKAJGBEP]
	public static JobHandle BIJLDBPFODJ<T>(this EntityCommandBufferSystem IJMJAJIILGC, NativeArray<Entity> HEECCMKMEOO, [Optional] JobHandle GAHDLBCEEBH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6D75360", Offset = "0x6D74560", VA = "0x186D75360")]
	[IICFKAJGBEP]
	public static JobHandle BIJLDBPFODJ(this EntityCommandBufferSystem IJMJAJIILGC, NativeArray<Entity> HEECCMKMEOO, ComponentTypes OALDCFEEKEL, [Optional] JobHandle GAHDLBCEEBH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6D75210", Offset = "0x6D74410", VA = "0x186D75210")]
	[IICFKAJGBEP]
	public static JobHandle BIJLDBPFODJ(this EntityCommandBufferSystem IJMJAJIILGC, EntityCommandBuffer JHODHHLBFEC, NativeArray<Entity> HEECCMKMEOO, ComponentTypes OALDCFEEKEL, [Optional] JobHandle GAHDLBCEEBH)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class PGFOFAHKAGN
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2FC76D0", Offset = "0x2FC68D0", VA = "0x182FC76D0")]
	[IICFKAJGBEP]
	public static JobHandle PEPMGEOAMLM<T>(this EntityCommandBufferSystem IJMJAJIILGC, EntityCommandBuffer JHODHHLBFEC, EntityQuery AGPDEIFDIDJ, T JECHHBGMFLN) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class CJBADACGJFA
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6D755C0", Offset = "0x6D747C0", VA = "0x186D755C0")]
	[IICFKAJGBEP]
	public static JobHandle MBMNKCHFCCI(this EntityCommandBufferSystem IJMJAJIILGC, NativeList<Entity> HEECCMKMEOO, [Optional] JobHandle GAHDLBCEEBH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6D75750", Offset = "0x6D74950", VA = "0x186D75750")]
	[IICFKAJGBEP]
	public static JobHandle MBMNKCHFCCI(this EntityCommandBufferSystem IJMJAJIILGC, NativeArrayAsync<Entity> HEECCMKMEOO)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class EBOCLFBAIAM
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class HMABFENGNNJ
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2E37540", Offset = "0x2E36740", VA = "0x182E37540")]
	[IICFKAJGBEP]
	public static JobHandle BEBIDFFKDBJ<T>(this EntityCommandBufferSystem IJMJAJIILGC, NativeArray<Entity> HEECCMKMEOO, NativeArray<T> LJIEGDEDOHM, JobHandle GAHDLBCEEBH) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class FJAFDFGACKF
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2DFCBA0", Offset = "0x2DFBDA0", VA = "0x182DFCBA0")]
	[IICFKAJGBEP]
	public static JobHandle LDEIACDDNLD<T>(this EntityCommandBufferSystem IJMJAJIILGC, NativeArray<Entity> HEECCMKMEOO, T JECHHBGMFLN, [Optional] JobHandle GAHDLBCEEBH) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2DFCC90", Offset = "0x2DFBE90", VA = "0x182DFCC90")]
	[IICFKAJGBEP]
	public static JobHandle LDEIACDDNLD<T>(this EntityCommandBufferSystem IJMJAJIILGC, EntityCommandBuffer JHODHHLBFEC, NativeArray<Entity> HEECCMKMEOO, T JECHHBGMFLN, [Optional] JobHandle GAHDLBCEEBH) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class FLMPDIJIEMF
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class OEOFMLOHAOI
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2FA9FF0", Offset = "0x2FA91F0", VA = "0x182FA9FF0")]
	public static NativeArray<T> PBHCIPLDOAK<T>(this NativeList<Entity> JKDPIAPOCMC, EntityManager FFFGHCELNHC, Allocator PKPCACFEGCG = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2FA9A50", Offset = "0x2FA8C50", VA = "0x182FA9A50")]
	public static NativeArray<T> PBHCIPLDOAK<T>(this NativeArray<Entity> JKDPIAPOCMC, EntityManager FFFGHCELNHC, Allocator PKPCACFEGCG = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6D75E00", Offset = "0x6D75000", VA = "0x186D75E00")]
	public static NativeArray<Entity> IHPMHPGEOLH(this NativeArray<Entity> JKDPIAPOCMC, EntityManager FFFGHCELNHC, ComponentType IPNKBHACDMK, Allocator PKPCACFEGCG = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2FA9970", Offset = "0x2FA8B70", VA = "0x182FA9970")]
	public static NativeArray<T> HGNGICACPDP<T>(this NativeArray<Entity> JKDPIAPOCMC, EntityManager FFFGHCELNHC, Allocator PKPCACFEGCG = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class MKEIBIDMNKO
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct FNGBDBICIPO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct OIBNGCAGOOG<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public FNGBDBICIPO<TFrom> MMPBCCIBPMB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Allocator PKPCACFEGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public NativeArray<TFrom> COMFGEABODD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct BJCGDHEJGDC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct MOAPEBAPAEG<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public BJCGDHEJGDC<TFrom> MMPBCCIBPMB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator PKPCACFEGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArrayAsync<TFrom> COMFGEABODD;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct AIDGHGELPFJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct CKFMGKEMEKH<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public AIDGHGELPFJ<TFrom> MMPBCCIBPMB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator PKPCACFEGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeListAsync<TFrom> COMFGEABODD;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class IMGCADHIPKP
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class PAHGDOCGKHN
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct OPNBKMCOOFO : LGECDGMPBAO<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> BNNMNOODJDN;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6D75FE0", Offset = "0x6D751E0", VA = "0x186D75FE0")]
		[BurstCompatible]
		public Entity MMNDBOJPAOE([In] Entity JECHHBGMFLN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6D75FE0", Offset = "0x6D751E0", VA = "0x186D75FE0", Slot = "4")]
		private Entity GJMJKMLKHEC([In] Entity JECHHBGMFLN)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class NECPPHIHPHE
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct IJHOPDDEBJG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator PKPCACFEGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<Entity> GNJKBKCJIEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<T> COMFGEABODD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct NFJLHKNCDAM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator PKPCACFEGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeList<Entity> GNJKBKCJIEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> COMFGEABODD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct OLBGIMHOEMP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator PKPCACFEGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArrayAsync<Entity> GNJKBKCJIEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArrayAsync<T> COMFGEABODD;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class CEGNMCNFGJI
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class PNFDBOMFKNC
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct JKDEBCHMIMI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator PKPCACFEGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> COMFGEABODD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct NHMJADLABEL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator PKPCACFEGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> COMFGEABODD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct MPJGMHBELCC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator PKPCACFEGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeArrayAsync<T> COMFGEABODD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct APEIFKBFODG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator PKPCACFEGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NativeListAsync<T> COMFGEABODD;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class FOCMCGMJHDL
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class MFMCLCKGOOD
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2F13480", Offset = "0x2F12680", VA = "0x182F13480")]
	public static NativeList<Entity> NOGLLKAHOJN<T>(this NativeArray<Entity> PPJJLNGJHAK, EntityManager FFFGHCELNHC, Allocator PKPCACFEGCG = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class BMDMBJFHDMP
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class PDGFMPDNMMK
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public readonly struct OOJICBOLGGM<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NativeArray<TSrc> IEIBCNCHGJN;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xC99390", Offset = "0xC98590", VA = "0x180C99390")]
		public OOJICBOLGGM(NativeArray<TSrc> IEIBCNCHGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380")]
		public BICLDCLGCNO<TSrc, TValue> FMNCKCNAENM<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(BICLDCLGCNO<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct BICLDCLGCNO<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> IEIBCNCHGJN;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xC99390", Offset = "0xC98590", VA = "0x180C99390")]
		public BICLDCLGCNO(NativeArray<TSrc> IEIBCNCHGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380")]
		public DKPOEHEDAGC<TSrc, TValue, TSelector> ILHKDNAFCOO<TSelector>() where TSelector : struct, LGECDGMPBAO<TSrc, TValue>
		{
			return default(DKPOEHEDAGC<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct DKPOEHEDAGC<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, LGECDGMPBAO<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> IEIBCNCHGJN;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xC99390", Offset = "0xC98590", VA = "0x180C99390")]
		public DKPOEHEDAGC(NativeArray<TSrc> IEIBCNCHGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5B36AB0", Offset = "0x5B35CB0", VA = "0x185B36AB0")]
		public ONEJOIPFCKF<TSrc, TValue, TSelector> FKOGLDEBNHA()
		{
			return default(ONEJOIPFCKF<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct CIDJLGMBPGE<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, LGECDGMPBAO<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> IEIBCNCHGJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TSelector ENGIPNINEMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int KINMHNEMPOD;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TValue HLBNAJGJPKH
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x57B98B0", Offset = "0x57B8AB0", VA = "0x1857B98B0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int NLHHONDOFEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x99DF40", Offset = "0x99D140", VA = "0x18099DF40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int DIBMJIIAHIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x21F92F0", Offset = "0x21F84F0", VA = "0x1821F92F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x57B9A90", Offset = "0x57B8C90", VA = "0x1857B9A90")]
		public CIDJLGMBPGE(NativeArray<TSrc> IEIBCNCHGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x57B9A80", Offset = "0x57B8C80", VA = "0x1857B9A80")]
		public bool OLKLCFOLPIG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x57B98F0", Offset = "0x57B8AF0", VA = "0x1857B98F0")]
		private TSrc HDBLKHLAGPP(int ABKDFEIGMDF)
		{
			return (TSrc)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x57B99F0", Offset = "0x57B8BF0", VA = "0x1857B99F0")]
		private TValue KCBLIFGGGBD()
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct ONEJOIPFCKF<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, LGECDGMPBAO<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private CIDJLGMBPGE<TSrc, TValue, TSelector> IMIFNCDPODH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TValue BHJNCEOHFON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int GFHPFKLIAOK;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OJDOCFPBNPC LBOAFCEAPPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x49808B0", Offset = "0x497FAB0", VA = "0x1849808B0")]
			get
			{
				return default(OJDOCFPBNPC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue CNAFKFMGFLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x89A5B0", Offset = "0x8997B0", VA = "0x18089A5B0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, OJDOCFPBNPC range) HLBNAJGJPKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x49807E0", Offset = "0x497F9E0", VA = "0x1849807E0")]
			get
			{
				return default((TValue, OJDOCFPBNPC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4980A70", Offset = "0x497FC70", VA = "0x184980A70")]
		public ONEJOIPFCKF(NativeArray<TSrc> IEIBCNCHGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xD2E380", Offset = "0xD2D580", VA = "0x180D2E380")]
		public ONEJOIPFCKF<TSrc, TValue, TSelector> AKJNNDDNIOE()
		{
			return default(ONEJOIPFCKF<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x49808F0", Offset = "0x497FAF0", VA = "0x1849808F0")]
		public bool OLKLCFOLPIG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2FBFBC0", Offset = "0x2FBEDC0", VA = "0x182FBFBC0")]
	public static OOJICBOLGGM<T> DNEFLNDHOLB<T>(this NativeList<T> NAGHBLHDGIK) where T : struct
	{
		return default(OOJICBOLGGM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xC99380", Offset = "0xC98580", VA = "0x180C99380")]
	public static OOJICBOLGGM<T> DNEFLNDHOLB<T>(this NativeArray<T> IEIBCNCHGJN) where T : struct
	{
		return default(OOJICBOLGGM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class MFBEBIDCPFF
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct CCOCGIFEDKI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly NativeArray<T>.ReadOnly IEIBCNCHGJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int GFHPFKLIAOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int OPDCICANMMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T BHJNCEOHFON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private T KDAIFGPFMGP;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public OJDOCFPBNPC LBOAFCEAPPP
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x56C7CE0", Offset = "0x56C6EE0", VA = "0x1856C7CE0")]
			get
			{
				return default(OJDOCFPBNPC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T CNAFKFMGFLD
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x3AD5100", Offset = "0x3AD4300", VA = "0x183AD5100")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, OJDOCFPBNPC) HLBNAJGJPKH
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x56C7C10", Offset = "0x56C6E10", VA = "0x1856C7C10")]
			get
			{
				return default((T, OJDOCFPBNPC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x56C80A0", Offset = "0x56C72A0", VA = "0x1856C80A0")]
		public CCOCGIFEDKI(NativeArray<T> IEIBCNCHGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x56C7B30", Offset = "0x56C6D30", VA = "0x1856C7B30")]
		public CCOCGIFEDKI<T> AKJNNDDNIOE()
		{
			return default(CCOCGIFEDKI<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x56C7EC0", Offset = "0x56C70C0", VA = "0x1856C7EC0")]
		public bool OLKLCFOLPIG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5EB0", Offset = "0x2CA50B0", VA = "0x182CA5EB0")]
		public DEILLKENCHE<T, TComparer> EMLMGAABKAG<TComparer>([Optional] TComparer JFIIJBIFFPI) where TComparer : struct, IEqualityComparer<T>
		{
			return default(DEILLKENCHE<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct DEILLKENCHE<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly NativeArray<T>.ReadOnly IEIBCNCHGJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int GFHPFKLIAOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int OPDCICANMMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private T BHJNCEOHFON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private T KDAIFGPFMGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TComparer JFIIJBIFFPI;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public OJDOCFPBNPC LBOAFCEAPPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x56C7CE0", Offset = "0x56C6EE0", VA = "0x1856C7CE0")]
			get
			{
				return default(OJDOCFPBNPC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T CNAFKFMGFLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x3AD5100", Offset = "0x3AD4300", VA = "0x183AD5100")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5B29100", Offset = "0x5B28300", VA = "0x185B29100")]
		public DEILLKENCHE(NativeArray<T>.ReadOnly IEIBCNCHGJN, TComparer JFIIJBIFFPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5B28F20", Offset = "0x5B28120", VA = "0x185B28F20")]
		public bool OLKLCFOLPIG()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2F12E30", Offset = "0x2F12030", VA = "0x182F12E30")]
	public static CCOCGIFEDKI<T> FKOGLDEBNHA<T>(this NativeArray<T> IEIBCNCHGJN) where T : struct
	{
		return default(CCOCGIFEDKI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface GBJFFJAGHON
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class MPGFKBINICO
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct OOCAEJGLPPC<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class MFIHGJOCOLA : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public OOCAEJGLPPC<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x90B430", Offset = "0x90A630", VA = "0x18090B430", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x3E62320", Offset = "0x3E61520", VA = "0x183E62320", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x897B40", Offset = "0x896D40", VA = "0x180897B40")]
		[DebuggerHidden]
		public MFIHGJOCOLA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x477E9E0", Offset = "0x477DBE0", VA = "0x18477E9E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x477EBB0", Offset = "0x477DDB0", VA = "0x18477EBB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly Action<Protobuf> KPFJIBNENIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly MemoryStream IOKFEMNNNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly CodedInputStream BNAEDJIEJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Protobuf DNEJKACBLKI;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int DIBMJIIAHIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8FBD20", Offset = "0x8FAF20", VA = "0x1808FBD20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x49B79C0", Offset = "0x49B6BC0", VA = "0x1849B79C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x49B7A00", Offset = "0x49B6C00", VA = "0x1849B7A00", Slot = "4")]
	[IteratorStateMachine(typeof(OOCAEJGLPPC<>.MFIHGJOCOLA))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x49B7B00", Offset = "0x49B6D00", VA = "0x1849B7B00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct PFBDMCLJDLP<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly byte[] GJBDDGHNJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Protobuf DNEJKACBLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream IOKFEMNNNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedOutputStream BNMPHJJPEFJ;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4A8E7F0", Offset = "0x4A8D9F0", VA = "0x184A8E7F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct MNMJKGOOFOF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly MemoryStream IOKFEMNNNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly CodedInputStream BNAEDJIEJFB;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6D75DC0", Offset = "0x6D74FC0", VA = "0x186D75DC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct DBMGCADAKOO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly byte[] GJBDDGHNJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly MemoryStream IOKFEMNNNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CodedOutputStream BNMPHJJPEFJ;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6D758D0", Offset = "0x6D74AD0", VA = "0x186D758D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class GHOJOKCMPMC
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class DEDHCMLMHNH
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Flags]
public enum CCCFLOBJEIK
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
internal static class NAEEBFNJDPB
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class AMHLBKDNBBM
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public AMHLBKDNBBM()
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
