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
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x70973D0", Offset = "0x7095BD0", VA = "0x1870973D0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GMKMNIIHDAE : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	CCDACHFALGH EOBIPHHMBKJ
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
public interface LODJJLBHGHH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BKLEOMAMOJO(Entity DPHKAEKJOIN, object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HIDHENLJOMH(Entity DPHKAEKJOIN, object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CLCNPCLLHPG(Entity DPHKAEKJOIN);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class DMCPAGJKGNK<TComponentData, TValue> : PLJMOKMOFEI<TValue>, IDisposable where TComponentData : struct, GMKMNIIHDAE
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class NPLEIPDBKHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> OCHGNEGGEPP;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int BMBFHPLNLGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x39E04B0", Offset = "0x39DECB0", VA = "0x1839E04B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4A5ED90", Offset = "0x4A5D590", VA = "0x184A5ED90")]
		public bool FHNJIEGCCOD([Out] TValue INDENPJBLHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4A5EEA0", Offset = "0x4A5D6A0", VA = "0x184A5EEA0")]
		public void JGCMIIMCCFC(object DJIMHLGHFGI, TValue INDENPJBLHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4A5ECE0", Offset = "0x4A5D4E0", VA = "0x184A5ECE0")]
		public bool CGFLGFPAOEK(object DJIMHLGHFGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4A5EF80", Offset = "0x4A5D780", VA = "0x184A5EF80")]
		public int NBGOGJONJGM(object DJIMHLGHFGI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4A5F060", Offset = "0x4A5D860", VA = "0x184A5F060")]
		public NPLEIPDBKHD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<NPLEIPDBKHD> BDDLKBDEEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private DLGFDIFNGCE<CCDACHFALGH, NPLEIPDBKHD> JHIENBJIHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager MOHAGLEGECH;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5DF23B0", Offset = "0x5DF0BB0", VA = "0x185DF23B0")]
	public DMCPAGJKGNK(EntityManager MOHAGLEGECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1AE0", Offset = "0x5DF02E0", VA = "0x185DF1AE0", Slot = "4")]
	public void BKLEOMAMOJO(Entity DPHKAEKJOIN, object DJIMHLGHFGI, TValue INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5DF20E0", Offset = "0x5DF08E0", VA = "0x185DF20E0", Slot = "5")]
	public bool HIDHENLJOMH(Entity DPHKAEKJOIN, object DJIMHLGHFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1CF0", Offset = "0x5DF04F0", VA = "0x185DF1CF0", Slot = "6")]
	public bool FHNJIEGCCOD(Entity DPHKAEKJOIN, [Out] TValue INDENPJBLHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1CD0", Offset = "0x5DF04D0", VA = "0x185DF1CD0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF22D0", Offset = "0x5DF0AD0", VA = "0x185DF22D0")]
	private void LOEEEPHAILG(NPLEIPDBKHD CBPDIHBKODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2020", Offset = "0x5DF0820", VA = "0x185DF2020")]
	private bool HHOMKPAKHPD(Entity DPHKAEKJOIN, [Out] CCDACHFALGH KACBIAOBGKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1F20", Offset = "0x5DF0720", VA = "0x185DF1F20")]
	private void GOFGNOLCHJH(Entity DPHKAEKJOIN, CCDACHFALGH KACBIAOBGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2390", Offset = "0x5DF0B90", VA = "0x185DF2390")]
	private bool MPPABEGGPCC(CCDACHFALGH KACBIAOBGKP, [Out] NPLEIPDBKHD CBPDIHBKODK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1E00", Offset = "0x5DF0600", VA = "0x185DF1E00")]
	private NPLEIPDBKHD FOJNNPOELJM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PLJMOKMOFEI<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKLEOMAMOJO(Entity DPHKAEKJOIN, object DJIMHLGHFGI, TValue INDENPJBLHO);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HIDHENLJOMH(Entity DPHKAEKJOIN, object DJIMHLGHFGI);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FHNJIEGCCOD(Entity DPHKAEKJOIN, [Out] TValue INDENPJBLHO);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct CCDACHFALGH : KCFKJNPGMEA, IEquatable<CCDACHFALGH>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly CCDACHFALGH EOIJNKLPKGL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int MBLPHBBBBKP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9E3640", Offset = "0x9E1E40", VA = "0x1809E3640", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xD1C690", Offset = "0xD1AE90", VA = "0x180D1C690", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int KCBFDBADCEE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x293C5C0", Offset = "0x293ADC0", VA = "0x18293C5C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6292880", Offset = "0x6291080", VA = "0x186292880", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7097180", Offset = "0x7095980", VA = "0x187097180", Slot = "8")]
	public bool Equals(CCDACHFALGH LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x70971D0", Offset = "0x70959D0", VA = "0x1870971D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class KEKPJBIIKAE<THasTokensTag> : LODJJLBHGHH, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly FICDJCDJOAA AGHKKLOENAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, CCDACHFALGH> LIJIBLIFMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> BDDLKBDEEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private DLGFDIFNGCE<CCDACHFALGH, HashSet<object>> JHIENBJIHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager MOHAGLEGECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem EFNKGCOBBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool BCEDAPNKMCC;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4635D40", Offset = "0x4634540", VA = "0x184635D40")]
	public KEKPJBIIKAE(EntityManager MOHAGLEGECH, EntityCommandBufferSystem EFNKGCOBBLO, FICDJCDJOAA DMLEGCKNBEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4633420", Offset = "0x4631C20", VA = "0x184633420", Slot = "4")]
	public bool BKLEOMAMOJO(Entity DPHKAEKJOIN, object DJIMHLGHFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4634A00", Offset = "0x4633200", VA = "0x184634A00", Slot = "5")]
	public bool HIDHENLJOMH(Entity DPHKAEKJOIN, object DJIMHLGHFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4633870", Offset = "0x4632070", VA = "0x184633870", Slot = "6")]
	public bool CLCNPCLLHPG(Entity DPHKAEKJOIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4633920", Offset = "0x4632120", VA = "0x184633920", Slot = "8")]
	public bool CLCNPCLLHPG(CCDACHFALGH KACBIAOBGKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4633E30", Offset = "0x4632630", VA = "0x184633E30", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4635260", Offset = "0x4633A60", VA = "0x184635260")]
	private void LOEEEPHAILG(HashSet<object> CBPDIHBKODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x46345C0", Offset = "0x4632DC0", VA = "0x1846345C0")]
	private bool HHOMKPAKHPD(Entity DPHKAEKJOIN, [Out] CCDACHFALGH KACBIAOBGKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4633D70", Offset = "0x4632570", VA = "0x184633D70")]
	private bool DCLJEFPCHMJ(Entity DPHKAEKJOIN, [Out] CCDACHFALGH KACBIAOBGKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x46357B0", Offset = "0x4633FB0", VA = "0x1846357B0")]
	private void OOPNNFIMAAK(Entity DPHKAEKJOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x46356B0", Offset = "0x4633EB0", VA = "0x1846356B0")]
	private void ODCMCHKGODA(Entity DPHKAEKJOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4634F70", Offset = "0x4633770", VA = "0x184634F70")]
	private void KLKBAIEGHDK(Entity DPHKAEKJOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4634480", Offset = "0x4632C80", VA = "0x184634480")]
	private void GOFGNOLCHJH(Entity DPHKAEKJOIN, CCDACHFALGH KACBIAOBGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4634210", Offset = "0x4632A10", VA = "0x184634210")]
	private bool GJJDCEIFKPF(CCDACHFALGH KACBIAOBGKP, [Out] HashSet<object> CBPDIHBKODK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4633FD0", Offset = "0x46327D0", VA = "0x184633FD0")]
	private HashSet<object> FOJNNPOELJM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LEJNMHANHDO
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct HMAMGBIDCFH : FMPKLPIEFOJ<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7097530", Offset = "0x7095D30", VA = "0x187097530")]
	public float LONJNDPEGFF([In] float3 INDENPJBLHO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7097530", Offset = "0x7095D30", VA = "0x187097530", Slot = "4")]
	private float CGCDHEGHHHH([In] float3 INDENPJBLHO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct FKPCPMBIOIC : FMPKLPIEFOJ<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x70973F0", Offset = "0x7095BF0", VA = "0x1870973F0")]
	public float LONJNDPEGFF([In] float3 INDENPJBLHO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x70973F0", Offset = "0x7095BF0", VA = "0x1870973F0", Slot = "4")]
	private float CGCDHEGHHHH([In] float3 INDENPJBLHO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct KJEOKKKLFKI : FMPKLPIEFOJ<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xA96170", Offset = "0xA94970", VA = "0x180A96170")]
	public float LONJNDPEGFF([In] float3 INDENPJBLHO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xA96170", Offset = "0xA94970", VA = "0x180A96170", Slot = "4")]
	private float CGCDHEGHHHH([In] float3 INDENPJBLHO)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct BEJOHBCNIEM : FMPKLPIEFOJ<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1B39820", Offset = "0x1B38020", VA = "0x181B39820")]
	public int LONJNDPEGFF([In] int3 INDENPJBLHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1B39820", Offset = "0x1B38020", VA = "0x181B39820", Slot = "4")]
	private int OGLKEKFJHHE([In] int3 INDENPJBLHO)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct PHOKMKBLCCD : FMPKLPIEFOJ<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7097D20", Offset = "0x7096520", VA = "0x187097D20")]
	public int LONJNDPEGFF([In] int3 INDENPJBLHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7097D20", Offset = "0x7096520", VA = "0x187097D20", Slot = "4")]
	private int OGLKEKFJHHE([In] int3 INDENPJBLHO)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct LCJOHLPMOLI : FMPKLPIEFOJ<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xA5F310", Offset = "0xA5DB10", VA = "0x180A5F310")]
	public int LONJNDPEGFF([In] int3 INDENPJBLHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xA5F310", Offset = "0xA5DB10", VA = "0x180A5F310", Slot = "4")]
	private int OGLKEKFJHHE([In] int3 INDENPJBLHO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class CBMAIACPKDB : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1A1FEA0", Offset = "0x1A1E6A0", VA = "0x181A1FEA0")]
	public CBMAIACPKDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class BGBDLDKINMC : SystemBase, KCIFHBBDCMC
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7097100", Offset = "0x7095900", VA = "0x187097100")]
	public JobHandle EKLANONNCPN(ReadOnlySpan<int> GDCMPMLECNK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2DE3B20", Offset = "0x2DE2320", VA = "0x182DE3B20")]
	public void EDMHHLNNNIM<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2DE3420", Offset = "0x2DE1C20", VA = "0x182DE3420")]
	public JobHandle EDMHHLNNNIM<T>(JobHandle KACBIAOBGKP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7097090", Offset = "0x7095890", VA = "0x187097090")]
	public JobHandle EDMHHLNNNIM(ReadOnlySpan<int> GDCMPMLECNK, JobHandle KACBIAOBGKP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2DE3E50", Offset = "0x2DE2650", VA = "0x182DE3E50")]
	public JobHandle KKCMDAFLFFG<T>(JobHandle KACBIAOBGKP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7096FD0", Offset = "0x70957D0", VA = "0x187096FD0")]
	public ComponentDataFromEntity DKOONJKELGB(int JBGLLNPFNIB, bool MKAPLEONLGD = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7097150", Offset = "0x7095950", VA = "0x187097150")]
	public EntityExistenceLookupByEntity JFCJLBDGLAG()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7097170", Offset = "0x7095970", VA = "0x187097170", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1A1FEA0", Offset = "0x1A1E6A0", VA = "0x181A1FEA0")]
	protected BGBDLDKINMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class NCCFNFEBIJC : BGBDLDKINMC
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7097C00", Offset = "0x7096400", VA = "0x187097C00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1A1FEA0", Offset = "0x1A1E6A0", VA = "0x181A1FEA0")]
	protected NCCFNFEBIJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class FLBOHGDAJHF
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class JNMDOEKJDGI : EntityCommandBufferSystem, KCIFHBBDCMC
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1A1FEA0", Offset = "0x1A1E6A0", VA = "0x181A1FEA0")]
	protected JNMDOEKJDGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FMPKLPIEFOJ<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo LONJNDPEGFF([In] TFrom INDENPJBLHO);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface FOAPBILDEEH<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DAPEIAJBKIH(T INDENPJBLHO);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BurstCompile]
internal struct NLKPGLOIEOL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[ReadOnly]
	public NativeArray<Entity> NFLDGMHEJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public EntityCommandBuffer EMHONPBGBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public ComponentTypes KBJICJNPOMB;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7097C30", Offset = "0x7096430", VA = "0x187097C30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct HHDODJLFCOE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> NFLDGMHEJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer EMHONPBGBEC;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7097490", Offset = "0x7095C90", VA = "0x187097490", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct JBHKGOFCGKL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public NativeArray<Entity> NFLDGMHEJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public EntityCommandBuffer EMHONPBGBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public ComponentType PJHPBNHEFEC;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7097830", Offset = "0x7096030", VA = "0x187097830", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct FNEMJNGHAAC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> NFLDGMHEJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public NativeArray<T> EBNFOODJNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public EntityCommandBuffer EMHONPBGBEC;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4078700", Offset = "0x4076F00", VA = "0x184078700", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal struct OLJEFJEFBIK<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> NFLDGMHEJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> MCAFGDLBCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer EMHONPBGBEC;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct GJFMHGIGNHH<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> NFLDGMHEJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public T INDENPJBLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer EMHONPBGBEC;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4134D80", Offset = "0x4133580", VA = "0x184134D80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BurstCompile]
internal struct DGENAGMEEHE<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, FMPKLPIEFOJ<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<TFrom> GLKDBPNKLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[WriteOnly]
	public NativeArray<TTo> OCHKOOBMFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public TMap ILIPDNLABEN;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct IKLPONCMMAH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public ComponentDataFromEntity LFCEHCJAJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> GLKDBPNKLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[WriteOnly]
	public NativeArray<byte> OCHKOOBMFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int MCPONDACNLG;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7097550", Offset = "0x7095D50", VA = "0x187097550", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct BDAMKKHEAAC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public ComponentDataFromEntity<T> BGHIHOHNNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public NativeArray<Entity> GLKDBPNKLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[WriteOnly]
	public NativeList<T> OKOPMNFEIPP;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct AAIFCDBGCHJ<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, FMPKLPIEFOJ<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> PEENBMFEKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeList<TTo> OCHKOOBMFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap ILIPDNLABEN;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct IOAHEHOLAFB<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity<T> IOHKGJJPCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> KBNCFPJPKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<bool> CHDIAJLAFEF;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct CNOLDFDKLGF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> IOHKGJJPCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> KBNCFPJPKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> CHDIAJLAFEF;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x593EE40", Offset = "0x593D640", VA = "0x18593EE40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct KACGCAPPNCG<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<T> GLKDBPNKLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeList<T> OKOPMNFEIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeParallelHashSet<T> CDAHCNPNJEP;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x462A480", Offset = "0x4628C80", VA = "0x18462A480", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct BFHGGAKHBFP<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : FMPKLPIEFOJ<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<TFrom> GLKDBPNKLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<TFrom> OKOPMNFEIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<TTo> CDAHCNPNJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public TMap ILIPDNLABEN;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct JAGPJPNEHGD<T, TPredicate> : IJob where T : struct where TPredicate : struct, FOAPBILDEEH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public NativeArray<T> GLKDBPNKLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> BMINEKGJEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeList<Entity> GIGMBDCNFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public TPredicate ILIPDNLABEN;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct BBBDPEJDHFG<T, TPredicate> : IJob where T : struct where TPredicate : struct, FOAPBILDEEH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<T> GLKDBPNKLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<T> OKOPMNFEIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate ILIPDNLABEN;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct LCFFKMBNKHP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public ComponentDataFromEntity IOHKGJJPCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	public NativeArray<Entity> KBNCFPJPKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeList<Entity> CENBGMEFLBN;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x70978B0", Offset = "0x70960B0", VA = "0x1870978B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct DFEICKFOPON : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity IOHKGJJPCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> KBNCFPJPKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> CENBGMEFLBN;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7097220", Offset = "0x7095A20", VA = "0x187097220", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class IGNFHDIBEEP
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class MJKOHAALKJD
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3165CC0", Offset = "0x31644C0", VA = "0x183165CC0")]
	public static bool GHBLPNONLLA<T>(this NativeArray<Entity> KBNCFPJPKBH, EntityManager MOHAGLEGECH, Allocator MOBIJPCBMOB = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class GHEGHPGBCLF
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class EEJOAIHBHBO<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		public EEJOAIHBHBO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class LPPJPHOHNFJ<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		public LPPJPHOHNFJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly List<Func<JobHandle, JobHandle>> ICJMFAHKEHK;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7097400", Offset = "0x7095C00", VA = "0x187097400")]
	public GHEGHPGBCLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class BDAFENCDFLN
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class KCELDNPNALC
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct AEEFEBHMKOA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct JILBPNDNLGG<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			internal AEEFEBHMKOA<TFrom> NCCLECGLDAO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal Allocator MOBIJPCBMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal NativeArray<TFrom> HJDPFHBMCGB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct EGAOJONHHIO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct EBCNOEFPCMB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal EGAOJONHHIO<TFrom> NCCLECGLDAO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator MOBIJPCBMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeList<TFrom> HJDPFHBMCGB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct KJKFOEMHBAH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct ECLAEDLGODE<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal KJKFOEMHBAH<TFrom> NCCLECGLDAO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator MOBIJPCBMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeArrayAsync<TFrom> HJDPFHBMCGB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct MAJDFPOIIBC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct DCKMLMJILJH<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal MAJDFPOIIBC<TFrom> NCCLECGLDAO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator MOBIJPCBMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeListAsync<TFrom> HJDPFHBMCGB;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class IMGPIKBJLCJ
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class CMODMCBENEC
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2E68210", Offset = "0x2E66A10", VA = "0x182E68210")]
	public static NativeList<T> BIFBIAFAMCD<T>(this NativeArray<T> BJFKGCNINJP, Allocator MOBIJPCBMOB = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class PHDHJNICNMH
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class NAAPKENEOLB
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x31C18A0", Offset = "0x31C00A0", VA = "0x1831C18A0")]
	[EFEMOJOKCMI]
	public static JobHandle KPKMCJLGLLF<T>(this EntityCommandBufferSystem EFNKGCOBBLO, NativeArrayAsync<Entity> NFLDGMHEJEF, NativeArrayAsync<T> EBNFOODJNOB, [Optional] JobHandle GFFMBHIFEJD) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x31C1B50", Offset = "0x31C0350", VA = "0x1831C1B50")]
	[EFEMOJOKCMI]
	public static JobHandle KPKMCJLGLLF<T>(this EntityCommandBufferSystem EFNKGCOBBLO, NativeArrayAsync<Entity> NFLDGMHEJEF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x31C1A20", Offset = "0x31C0220", VA = "0x1831C1A20")]
	[EFEMOJOKCMI]
	public static JobHandle KPKMCJLGLLF<T>(this EntityCommandBufferSystem EFNKGCOBBLO, NativeArray<Entity> NFLDGMHEJEF, [Optional] JobHandle GFFMBHIFEJD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7097940", Offset = "0x7096140", VA = "0x187097940")]
	[EFEMOJOKCMI]
	public static JobHandle KPKMCJLGLLF(this EntityCommandBufferSystem EFNKGCOBBLO, NativeArray<Entity> NFLDGMHEJEF, ComponentTypes KBJICJNPOMB, [Optional] JobHandle GFFMBHIFEJD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7097AB0", Offset = "0x70962B0", VA = "0x187097AB0")]
	[EFEMOJOKCMI]
	public static JobHandle KPKMCJLGLLF(this EntityCommandBufferSystem EFNKGCOBBLO, EntityCommandBuffer EMHONPBGBEC, NativeArray<Entity> NFLDGMHEJEF, ComponentTypes KBJICJNPOMB, [Optional] JobHandle GFFMBHIFEJD)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class POAEHOHFJID
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x322A8C0", Offset = "0x32290C0", VA = "0x18322A8C0")]
	[EFEMOJOKCMI]
	public static JobHandle FHMPGKMDMAB<T>(this EntityCommandBufferSystem EFNKGCOBBLO, EntityCommandBuffer EMHONPBGBEC, EntityQuery GDGPGFFCGKI, T INDENPJBLHO) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class BAMAJGKFILL
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7096E40", Offset = "0x7095640", VA = "0x187096E40")]
	[EFEMOJOKCMI]
	public static JobHandle FMAEEJNCOOD(this EntityCommandBufferSystem EFNKGCOBBLO, NativeList<Entity> NFLDGMHEJEF, [Optional] JobHandle GFFMBHIFEJD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7096D40", Offset = "0x7095540", VA = "0x187096D40")]
	[EFEMOJOKCMI]
	public static JobHandle FMAEEJNCOOD(this EntityCommandBufferSystem EFNKGCOBBLO, NativeArrayAsync<Entity> NFLDGMHEJEF)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class EANHHHMKEDK
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class LFPIBGLPNJJ
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x310CD50", Offset = "0x310B550", VA = "0x18310CD50")]
	[EFEMOJOKCMI]
	public static JobHandle HONEGLCBABO<T>(this EntityCommandBufferSystem EFNKGCOBBLO, NativeArray<Entity> NFLDGMHEJEF, NativeArray<T> EBNFOODJNOB, JobHandle GFFMBHIFEJD) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class AKFKPHNGFNK
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x374A910", Offset = "0x3749110", VA = "0x18374A910")]
	[EFEMOJOKCMI]
	public static JobHandle AHFMFNBGCAD<T>(this EntityCommandBufferSystem EFNKGCOBBLO, NativeArray<Entity> NFLDGMHEJEF, T INDENPJBLHO, [Optional] JobHandle GFFMBHIFEJD) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x374A830", Offset = "0x3749030", VA = "0x18374A830")]
	[EFEMOJOKCMI]
	public static JobHandle AHFMFNBGCAD<T>(this EntityCommandBufferSystem EFNKGCOBBLO, EntityCommandBuffer EMHONPBGBEC, NativeArray<Entity> NFLDGMHEJEF, T INDENPJBLHO, [Optional] JobHandle GFFMBHIFEJD) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class PFKKCGLLFDO
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class IOMPLDFFAEK
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x30A5EB0", Offset = "0x30A46B0", VA = "0x1830A5EB0")]
	public static NativeArray<T> OGIBIJCBOAN<T>(this NativeArray<Entity> BJFKGCNINJP, EntityManager MOHAGLEGECH, Allocator MOBIJPCBMOB = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7097650", Offset = "0x7095E50", VA = "0x187097650")]
	public static NativeArray<Entity> DKBJGAPJNJP(this NativeArray<Entity> BJFKGCNINJP, EntityManager MOHAGLEGECH, ComponentType PJHPBNHEFEC, Allocator MOBIJPCBMOB = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x30A6270", Offset = "0x30A4A70", VA = "0x1830A6270")]
	public static NativeArray<T> PECKHLLPFAD<T>(this NativeArray<Entity> BJFKGCNINJP, EntityManager MOHAGLEGECH, Allocator MOBIJPCBMOB = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class KJFKILNJPDF
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct KBCAPPAJNAO<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct OLEBGBLIGFD<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public KBCAPPAJNAO<TFrom> HJDPFHBMCGB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Allocator MOBIJPCBMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public NativeArray<TFrom> GLKDBPNKLMB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct JPIDKGCAIPN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct BOJOKGBEGBB<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public JPIDKGCAIPN<TFrom> HJDPFHBMCGB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator MOBIJPCBMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArrayAsync<TFrom> GLKDBPNKLMB;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct NOMCAONLDFG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct AAMMDFKAAJO<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public NOMCAONLDFG<TFrom> HJDPFHBMCGB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator MOBIJPCBMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeListAsync<TFrom> GLKDBPNKLMB;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class AAJFFDCIBOG
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class AIMEPAAJGIK
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct ICJBMDPEBDK : FMPKLPIEFOJ<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> IOKPEABJICM;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7097540", Offset = "0x7095D40", VA = "0x187097540")]
		[BurstCompatible]
		public Entity LONJNDPEGFF([In] Entity INDENPJBLHO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7097540", Offset = "0x7095D40", VA = "0x187097540", Slot = "4")]
		private Entity JBOMNHLGCPI([In] Entity INDENPJBLHO)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class OMAEEPPBCHJ
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct ONHPDHBGKAL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator MOBIJPCBMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<Entity> BMINEKGJEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<T> GLKDBPNKLMB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct HAICEFOFPKO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator MOBIJPCBMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeList<Entity> BMINEKGJEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> GLKDBPNKLMB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct ENIADMGBEAH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator MOBIJPCBMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArrayAsync<Entity> BMINEKGJEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArrayAsync<T> GLKDBPNKLMB;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class PJOCGIHKAKB
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class MHMDILOPCJG
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct OPDEOGJPOHN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator MOBIJPCBMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> GLKDBPNKLMB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct PONNGOKHCNC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator MOBIJPCBMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> GLKDBPNKLMB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct ANOGIPALJPD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator MOBIJPCBMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeArrayAsync<T> GLKDBPNKLMB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct GPNLABMOJCH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator MOBIJPCBMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NativeListAsync<T> GLKDBPNKLMB;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class GFOEBKHIBGC
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class GHEMGPBEGJO
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x307C3C0", Offset = "0x307ABC0", VA = "0x18307C3C0")]
	public static NativeList<Entity> GLIPPJGKIDM<T>(this NativeArray<Entity> KBNCFPJPKBH, EntityManager MOHAGLEGECH, Allocator MOBIJPCBMOB = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class GLHPBGEAHIP
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class HFCAGPNHMJG
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public readonly struct EELAOKIDCFO<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NativeArray<TSrc> GHAIAFELBIF;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xDCC440", Offset = "0xDCAC40", VA = "0x180DCC440")]
		public EELAOKIDCFO(NativeArray<TSrc> GHAIAFELBIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430")]
		public DMMEOALOIAJ<TSrc, TValue> PFGOABBPIMH<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(DMMEOALOIAJ<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct DMMEOALOIAJ<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> GHAIAFELBIF;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xDCC440", Offset = "0xDCAC40", VA = "0x180DCC440")]
		public DMMEOALOIAJ(NativeArray<TSrc> GHAIAFELBIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430")]
		public KFNOCEDKGPI<TSrc, TValue, TSelector> DCMJGJNLGEM<TSelector>() where TSelector : struct, FMPKLPIEFOJ<TSrc, TValue>
		{
			return default(KFNOCEDKGPI<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct KFNOCEDKGPI<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, FMPKLPIEFOJ<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> GHAIAFELBIF;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xDCC440", Offset = "0xDCAC40", VA = "0x180DCC440")]
		public KFNOCEDKGPI(NativeArray<TSrc> GHAIAFELBIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4639320", Offset = "0x4637B20", VA = "0x184639320")]
		public OEILKAKPOOI<TSrc, TValue, TSelector> HPNOPKGMEAJ()
		{
			return default(OEILKAKPOOI<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct KMNBOHOIEJE<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, FMPKLPIEFOJ<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> GHAIAFELBIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TSelector KILDMDKKILC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int ECDOOAABOPD;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TValue NEPDGMBEJHL
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x466F0A0", Offset = "0x466D8A0", VA = "0x18466F0A0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int MBLPHBBBBKP
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xA8EA70", Offset = "0xA8D270", VA = "0x180A8EA70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int NALHPIPMEMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x23206E0", Offset = "0x231EEE0", VA = "0x1823206E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x466F280", Offset = "0x466DA80", VA = "0x18466F280")]
		public KMNBOHOIEJE(NativeArray<TSrc> GHAIAFELBIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x466F270", Offset = "0x466DA70", VA = "0x18466F270")]
		public bool JNDDBDHEFKO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x466F0E0", Offset = "0x466D8E0", VA = "0x18466F0E0")]
		private TSrc GICPGCHKGCN(int KKPBEBNOEKN)
		{
			return (TSrc)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x466F1E0", Offset = "0x466D9E0", VA = "0x18466F1E0")]
		private TValue HHFLLDHEAGB()
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct OEILKAKPOOI<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, FMPKLPIEFOJ<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private KMNBOHOIEJE<TSrc, TValue, TSelector> DDLDHCJHPPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TValue OEKENKMNEPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int PPAKOENBJHH;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public LGIPPHGAGPO IJFKJILAOEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x4B437B0", Offset = "0x4B41FB0", VA = "0x184B437B0")]
			get
			{
				return default(LGIPPHGAGPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue IKIELNFKFCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8BC040", Offset = "0x8BA840", VA = "0x1808BC040")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, LGIPPHGAGPO range) NEPDGMBEJHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x4B436E0", Offset = "0x4B41EE0", VA = "0x184B436E0")]
			get
			{
				return default((TValue, LGIPPHGAGPO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x4B43970", Offset = "0x4B42170", VA = "0x184B43970")]
		public OEILKAKPOOI(NativeArray<TSrc> GHAIAFELBIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x406F660", Offset = "0x406DE60", VA = "0x18406F660")]
		public OEILKAKPOOI<TSrc, TValue, TSelector> IGEPHCDGPEC()
		{
			return default(OEILKAKPOOI<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4B437F0", Offset = "0x4B41FF0", VA = "0x184B437F0")]
		public bool JNDDBDHEFKO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3086580", Offset = "0x3084D80", VA = "0x183086580")]
	public static EELAOKIDCFO<T> FCHBMACHBBL<T>(this NativeList<T> OCHGNEGGEPP) where T : struct
	{
		return default(EELAOKIDCFO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xDCC430", Offset = "0xDCAC30", VA = "0x180DCC430")]
	public static EELAOKIDCFO<T> FCHBMACHBBL<T>(this NativeArray<T> GHAIAFELBIF) where T : struct
	{
		return default(EELAOKIDCFO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class IPIDAHHJBEF
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct CPJDANACHAH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly NativeArray<T>.ReadOnly GHAIAFELBIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int PPAKOENBJHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int GLFFHMKGLMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T OEKENKMNEPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private T IJNHJCDHPDB;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public LGIPPHGAGPO IJFKJILAOEN
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x42F5440", Offset = "0x42F3C40", VA = "0x1842F5440")]
			get
			{
				return default(LGIPPHGAGPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T IKIELNFKFCI
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x3D4A010", Offset = "0x3D48810", VA = "0x183D4A010")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, LGIPPHGAGPO) NEPDGMBEJHL
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5A20FF0", Offset = "0x5A1F7F0", VA = "0x185A20FF0")]
			get
			{
				return default((T, LGIPPHGAGPO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5A214B0", Offset = "0x5A1FCB0", VA = "0x185A214B0")]
		public CPJDANACHAH(NativeArray<T> GHAIAFELBIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5A210C0", Offset = "0x5A1F8C0", VA = "0x185A210C0")]
		public CPJDANACHAH<T> IGEPHCDGPEC()
		{
			return default(CPJDANACHAH<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5A212D0", Offset = "0x5A1FAD0", VA = "0x185A212D0")]
		public bool JNDDBDHEFKO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2F559F0", Offset = "0x2F541F0", VA = "0x182F559F0")]
		public IANEOCKGJNE<T, TComparer> PIBEOGMNMML<TComparer>([Optional] TComparer NFJEKJCKCPB) where TComparer : struct, IEqualityComparer<T>
		{
			return default(IANEOCKGJNE<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct IANEOCKGJNE<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly NativeArray<T>.ReadOnly GHAIAFELBIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int PPAKOENBJHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int GLFFHMKGLMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private T OEKENKMNEPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private T IJNHJCDHPDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TComparer NFJEKJCKCPB;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LGIPPHGAGPO IJFKJILAOEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x42F5440", Offset = "0x42F3C40", VA = "0x1842F5440")]
			get
			{
				return default(LGIPPHGAGPO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T IKIELNFKFCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x3D4A010", Offset = "0x3D48810", VA = "0x183D4A010")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x42F5630", Offset = "0x42F3E30", VA = "0x1842F5630")]
		public IANEOCKGJNE(NativeArray<T>.ReadOnly GHAIAFELBIF, TComparer NFJEKJCKCPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x42F5450", Offset = "0x42F3C50", VA = "0x1842F5450")]
		public bool JNDDBDHEFKO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x30A71A0", Offset = "0x30A59A0", VA = "0x1830A71A0")]
	public static CPJDANACHAH<T> HPNOPKGMEAJ<T>(this NativeArray<T> GHAIAFELBIF) where T : struct
	{
		return default(CPJDANACHAH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface FIONEKKDKGL
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class DPEHMCEMNIG
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct GKHHAIIHMJO<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class DHPMKIMACPH : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public GKHHAIIHMJO<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x9DB570", Offset = "0x9D9D70", VA = "0x1809DB570", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x40C9890", Offset = "0x40C8090", VA = "0x1840C9890", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB50", Offset = "0x8B9350", VA = "0x1808BAB50")]
		[DebuggerHidden]
		public DHPMKIMACPH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4660", Offset = "0x5DE2E60", VA = "0x185DE4660", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5DE4830", Offset = "0x5DE3030", VA = "0x185DE4830", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly Action<Protobuf> LLBICDDFFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly MemoryStream NMANOCJJAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly CodedInputStream GPDDPPLPLMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Protobuf DAJIEEBMGGN;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int NALHPIPMEMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x958980", Offset = "0x957180", VA = "0x180958980")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4138B70", Offset = "0x4137370", VA = "0x184138B70", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4138BB0", Offset = "0x41373B0", VA = "0x184138BB0", Slot = "4")]
	[IteratorStateMachine(typeof(GKHHAIIHMJO<>.DHPMKIMACPH))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4138CB0", Offset = "0x41374B0", VA = "0x184138CB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct CIAOJKKCACK<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly byte[] ENCIEGIIIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Protobuf DAJIEEBMGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream NMANOCJJAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedOutputStream DFKDOLFLPAJ;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5925230", Offset = "0x5923A30", VA = "0x185925230", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct POEDHPDNMFE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly MemoryStream NMANOCJJAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly CodedInputStream GPDDPPLPLMO;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7097D30", Offset = "0x7096530", VA = "0x187097D30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct DKPEHEHGGCI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly byte[] ENCIEGIIIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly MemoryStream NMANOCJJAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CodedOutputStream DFKDOLFLPAJ;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x70972B0", Offset = "0x7095AB0", VA = "0x1870972B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class ABECLEPANPG
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class MOEIGDHKOBH
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Flags]
public enum EPPIBPNCDOH
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
internal static class FNMILMBINAK
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class AGIJBHGDPCL
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public AGIJBHGDPCL()
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
