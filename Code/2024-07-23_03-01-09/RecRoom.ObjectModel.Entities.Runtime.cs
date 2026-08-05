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
		[Cpp2IlInjected.Address(RVA = "0x87C5D0", Offset = "0x87B7D0", VA = "0x18087C5D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87C5D0", Offset = "0x87B7D0", VA = "0x18087C5D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69E4700", Offset = "0x69E3900", VA = "0x1869E4700")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CDKJCGHPLFH : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	EACBOGOHBHP NBMIBOLNKKP
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
public interface HIMDKIOCMIF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GMJCNGKBIKC(Entity IBKNLGIDEBH, object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PKCEHGLAEKA(Entity IBKNLGIDEBH, object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FBEJJFNJIMN(Entity IBKNLGIDEBH);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class OLHHIDIPDIF<TComponentData, TValue> : ENAPGDKGFIF<TValue>, IDisposable where TComponentData : struct, CDKJCGHPLFH
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class DEDBBKCEKJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> CGIFJALMJMI;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int MELIDLJEANB
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3592420", Offset = "0x3591620", VA = "0x183592420")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5761D60", Offset = "0x5760F60", VA = "0x185761D60")]
		public bool GIDLGFOLBNE([Out] TValue JMDCGOKJIDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5762000", Offset = "0x5761200", VA = "0x185762000")]
		public void PBLNBBGFGAP(object EOCJCEFCOOA, TValue JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5761F50", Offset = "0x5761150", VA = "0x185761F50")]
		public bool MFKDEBIIBOM(object EOCJCEFCOOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5761E60", Offset = "0x5761060", VA = "0x185761E60")]
		public int IMLBDBIFEKB(object EOCJCEFCOOA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x57620E0", Offset = "0x57612E0", VA = "0x1857620E0")]
		public DEDBBKCEKJO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<DEDBBKCEKJO> DLKBJOHGDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NLJNNOLMIDI<EACBOGOHBHP, DEDBBKCEKJO> DGPPHOLAGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager DIKLEKJGKDE;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4679200", Offset = "0x4678400", VA = "0x184679200")]
	public OLHHIDIPDIF(EntityManager DIKLEKJGKDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4678CF0", Offset = "0x4677EF0", VA = "0x184678CF0", Slot = "4")]
	public void GMJCNGKBIKC(Entity IBKNLGIDEBH, object EOCJCEFCOOA, TValue JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4678F20", Offset = "0x4678120", VA = "0x184678F20", Slot = "5")]
	public bool PKCEHGLAEKA(Entity IBKNLGIDEBH, object EOCJCEFCOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4678AD0", Offset = "0x4677CD0", VA = "0x184678AD0", Slot = "6")]
	public bool GIDLGFOLBNE(Entity IBKNLGIDEBH, [Out] TValue JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4678A90", Offset = "0x4677C90", VA = "0x184678A90", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4678E60", Offset = "0x4678060", VA = "0x184678E60")]
	private void GOMOFBJKICK(DEDBBKCEKJO MOOFNFAEPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x46789D0", Offset = "0x4677BD0", VA = "0x1846789D0")]
	private bool DBAPGFINGNH(Entity IBKNLGIDEBH, [Out] EACBOGOHBHP IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4679110", Offset = "0x4678310", VA = "0x184679110")]
	private void PMNMDKFHFAA(Entity IBKNLGIDEBH, EACBOGOHBHP IIMJMBJHGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4678AB0", Offset = "0x4677CB0", VA = "0x184678AB0")]
	private bool GBLHJJLFALC(EACBOGOHBHP IIMJMBJHGDI, [Out] DEDBBKCEKJO MOOFNFAEPBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4678BD0", Offset = "0x4677DD0", VA = "0x184678BD0")]
	private DEDBBKCEKJO GKGIGHMFNFO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface ENAPGDKGFIF<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GMJCNGKBIKC(Entity IBKNLGIDEBH, object EOCJCEFCOOA, TValue JMDCGOKJIDA);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PKCEHGLAEKA(Entity IBKNLGIDEBH, object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GIDLGFOLBNE(Entity IBKNLGIDEBH, [Out] TValue JMDCGOKJIDA);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct EACBOGOHBHP : DIAIPOOLIIL, IEquatable<EACBOGOHBHP>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly EACBOGOHBHP ADOHMNBGCKE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int LINJEMEJAMF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA7CFA0", Offset = "0xA7C1A0", VA = "0x180A7CFA0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA7CFB0", Offset = "0xA7C1B0", VA = "0x180A7CFB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int GIOOEBIGKMB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x256A860", Offset = "0x2569A60", VA = "0x18256A860", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5CC1B20", Offset = "0x5CC0D20", VA = "0x185CC1B20", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x69E4660", Offset = "0x69E3860", VA = "0x1869E4660", Slot = "8")]
	public bool Equals(EACBOGOHBHP OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x69E46B0", Offset = "0x69E38B0", VA = "0x1869E46B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class MDHEAOIOJEB<THasTokensTag> : HIMDKIOCMIF, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, EACBOGOHBHP> GPJOOKMMKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> DLKBJOHGDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private NLJNNOLMIDI<EACBOGOHBHP, HashSet<object>> DGPPHOLAGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager DIKLEKJGKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem HICMAKMOHPJ;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4496040", Offset = "0x4495240", VA = "0x184496040")]
	public MDHEAOIOJEB(EntityManager DIKLEKJGKDE, EntityCommandBufferSystem HICMAKMOHPJ, CDLNJDLNIPA MKGIBLBFPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x44949E0", Offset = "0x4493BE0", VA = "0x1844949E0", Slot = "4")]
	public bool GMJCNGKBIKC(Entity IBKNLGIDEBH, object EOCJCEFCOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4495860", Offset = "0x4494A60", VA = "0x184495860", Slot = "5")]
	public bool PKCEHGLAEKA(Entity IBKNLGIDEBH, object EOCJCEFCOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4493B20", Offset = "0x4492D20", VA = "0x184493B20", Slot = "6")]
	public bool FBEJJFNJIMN(Entity IBKNLGIDEBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4493D20", Offset = "0x4492F20", VA = "0x184493D20", Slot = "8")]
	public bool FBEJJFNJIMN(EACBOGOHBHP IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4493AA0", Offset = "0x4492CA0", VA = "0x184493AA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4494CD0", Offset = "0x4493ED0", VA = "0x184494CD0")]
	private void GOMOFBJKICK(HashSet<object> MOOFNFAEPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x44936E0", Offset = "0x44928E0", VA = "0x1844936E0")]
	private bool DBAPGFINGNH(Entity IBKNLGIDEBH, [Out] EACBOGOHBHP IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4493560", Offset = "0x4492760", VA = "0x184493560")]
	private bool CGNDPPHGBIG(Entity IBKNLGIDEBH, [Out] EACBOGOHBHP IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4494F40", Offset = "0x4494140", VA = "0x184494F40")]
	private void KHMHDMAGGHO(Entity IBKNLGIDEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4493E80", Offset = "0x4493080", VA = "0x184493E80")]
	private void GKBFNNAFKHO(Entity IBKNLGIDEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x44951D0", Offset = "0x44943D0", VA = "0x1844951D0")]
	private void LIBIHLIDJGC(Entity IBKNLGIDEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4495A00", Offset = "0x4494C00", VA = "0x184495A00")]
	private void PMNMDKFHFAA(Entity IBKNLGIDEBH, EACBOGOHBHP IIMJMBJHGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x44932C0", Offset = "0x44924C0", VA = "0x1844932C0")]
	private bool AJNAKBGHJHO(EACBOGOHBHP IIMJMBJHGDI, [Out] HashSet<object> MOOFNFAEPBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x44943C0", Offset = "0x44935C0", VA = "0x1844943C0")]
	private HashSet<object> GKGIGHMFNFO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class BNAPDFANFDE
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct HGIDLCPIOLH : BLPJEGOCLCP<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x69E49E0", Offset = "0x69E3BE0", VA = "0x1869E49E0")]
	public float KOOHJFIDFKE([In] float3 JMDCGOKJIDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x69E49E0", Offset = "0x69E3BE0", VA = "0x1869E49E0", Slot = "4")]
	private float LANELLANMEN([In] float3 JMDCGOKJIDA)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct OIGOFICOFLP : BLPJEGOCLCP<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x69E53D0", Offset = "0x69E45D0", VA = "0x1869E53D0")]
	public float KOOHJFIDFKE([In] float3 JMDCGOKJIDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x69E53D0", Offset = "0x69E45D0", VA = "0x1869E53D0", Slot = "4")]
	private float LANELLANMEN([In] float3 JMDCGOKJIDA)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct KDFPOKPPCEP : BLPJEGOCLCP<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1CDAE80", Offset = "0x1CDA080", VA = "0x181CDAE80")]
	public float KOOHJFIDFKE([In] float3 JMDCGOKJIDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1CDAE80", Offset = "0x1CDA080", VA = "0x181CDAE80", Slot = "4")]
	private float LANELLANMEN([In] float3 JMDCGOKJIDA)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct CEIDLLCMDKH : BLPJEGOCLCP<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x15A45A0", Offset = "0x15A37A0", VA = "0x1815A45A0")]
	public int KOOHJFIDFKE([In] int3 JMDCGOKJIDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x15A45A0", Offset = "0x15A37A0", VA = "0x1815A45A0", Slot = "4")]
	private int KMKPHECOJGL([In] int3 JMDCGOKJIDA)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct MAJKMKHBNPK : BLPJEGOCLCP<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x69E5270", Offset = "0x69E4470", VA = "0x1869E5270")]
	public int KOOHJFIDFKE([In] int3 JMDCGOKJIDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x69E5270", Offset = "0x69E4470", VA = "0x1869E5270", Slot = "4")]
	private int KMKPHECOJGL([In] int3 JMDCGOKJIDA)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct OKDADONHCIB : BLPJEGOCLCP<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1754BE0", Offset = "0x1753DE0", VA = "0x181754BE0")]
	public int KOOHJFIDFKE([In] int3 JMDCGOKJIDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1754BE0", Offset = "0x1753DE0", VA = "0x181754BE0", Slot = "4")]
	private int KMKPHECOJGL([In] int3 JMDCGOKJIDA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class JIIMGOPLHLL : DFPPNDAPLGM
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x14D3B10", Offset = "0x14D2D10", VA = "0x1814D3B10")]
	public JIIMGOPLHLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class PFBIJGOHPEH : SystemBase, GDJLILNELBP
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x69E5510", Offset = "0x69E4710", VA = "0x1869E5510")]
	public JobHandle GFGJMKDLNPB(ReadOnlySpan<int> MPOIGANILDA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2CD4920", Offset = "0x2CD3B20", VA = "0x182CD4920")]
	public void AMDMEBBPFPN<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2CD49B0", Offset = "0x2CD3BB0", VA = "0x182CD49B0")]
	public JobHandle AMDMEBBPFPN<T>(JobHandle IIMJMBJHGDI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x69E53E0", Offset = "0x69E45E0", VA = "0x1869E53E0")]
	public JobHandle AMDMEBBPFPN(ReadOnlySpan<int> MPOIGANILDA, JobHandle IIMJMBJHGDI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2CD4920", Offset = "0x2CD3B20", VA = "0x182CD4920")]
	public void FPGCPHOMBOA<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2CD5890", Offset = "0x2CD4A90", VA = "0x182CD5890")]
	public JobHandle FPGCPHOMBOA<T>(JobHandle IIMJMBJHGDI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x69E5450", Offset = "0x69E4650", VA = "0x1869E5450")]
	public ComponentDataFromEntity EDAHEICJGPD(int ILLCBJEFNGA, bool HKNKBAEFAJL = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x69E5560", Offset = "0x69E4760", VA = "0x1869E5560")]
	public EntityExistenceLookupByEntity MOKFNDPDBMJ()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x69E5580", Offset = "0x69E4780", VA = "0x1869E5580", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x14D3B10", Offset = "0x14D2D10", VA = "0x1814D3B10")]
	protected PFBIJGOHPEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class NGKJLGEGOEI : PFBIJGOHPEH
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x69E53A0", Offset = "0x69E45A0", VA = "0x1869E53A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x14D3B10", Offset = "0x14D2D10", VA = "0x1814D3B10")]
	protected NGKJLGEGOEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class IHBBPIAPFDN
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class MENJPLLFPFC : EntityCommandBufferSystem, GDJLILNELBP
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x14D3B10", Offset = "0x14D2D10", VA = "0x1814D3B10")]
	protected MENJPLLFPFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface BLPJEGOCLCP<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo KOOHJFIDFKE([In] TFrom JMDCGOKJIDA);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface DBDCKJOIBLN<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MFANNBJAAHE(T JMDCGOKJIDA);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BurstCompile]
internal struct LGEFKNLONGI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[ReadOnly]
	public NativeArray<Entity> JPHDFJFJAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public EntityCommandBuffer HDAOBPDCCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public ComponentTypes NIJECAPFNFB;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x69E5180", Offset = "0x69E4380", VA = "0x1869E5180", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct LCMGGAJIGBJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[ReadOnly]
	public NativeArray<Entity> JPHDFJFJAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public EntityCommandBuffer HDAOBPDCCDB;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x69E50E0", Offset = "0x69E42E0", VA = "0x1869E50E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct JOALDFGJBPE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public NativeArray<Entity> JPHDFJFJAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public EntityCommandBuffer HDAOBPDCCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public ComponentType JDJBLNJHNEJ;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x69E4DD0", Offset = "0x69E3FD0", VA = "0x1869E4DD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct CCEPNAEOFLJ<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	[ReadOnly]
	public NativeArray<Entity> JPHDFJFJAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<T> LINJEFIAFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer HDAOBPDCCDB;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5020890", Offset = "0x501FA90", VA = "0x185020890", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal struct GCKLNBGBEFP<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<Entity> JPHDFJFJAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<T> MNHECFLLMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public EntityCommandBuffer HDAOBPDCCDB;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct NOAOKOHOKKF<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<Entity> JPHDFJFJAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public T JMDCGOKJIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public EntityCommandBuffer HDAOBPDCCDB;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x454E560", Offset = "0x454D760", VA = "0x18454E560", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BurstCompile]
internal struct EPHKNPGHDCP<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, BLPJEGOCLCP<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[ReadOnly]
	public NativeArray<TFrom> MAOBOAGJBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[WriteOnly]
	public NativeArray<TTo> BKNGIPCCBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public TMap ENGMCBPHJGL;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct BBFPLHMAHMG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[ReadOnly]
	public ComponentDataFromEntity EHLMOJFLMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<Entity> MAOBOAGJBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<byte> BKNGIPCCBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int BNAPBDGLJKI;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x69E4560", Offset = "0x69E3760", VA = "0x1869E4560", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct BGPNGEGOACJ<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity<T> EHMLHLFEIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> MAOBOAGJBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeList<T> BEHDFOBFLME;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct CJHGFGFGJOG<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, BLPJEGOCLCP<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public NativeArray<TFrom> DDFJOPLCENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[WriteOnly]
	public NativeList<TTo> BKNGIPCCBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public TMap ENGMCBPHJGL;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct KMPHNMOOKCF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public ComponentDataFromEntity<T> ANEKGNLCFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<Entity> IBJGOCHPIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<bool> CGBIBLMLNMB;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct IDEFLMFJIDM<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ComponentDataFromEntity<T> ANEKGNLCFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public NativeArray<Entity> IBJGOCHPIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public NativeArray<bool> CGBIBLMLNMB;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3E3F020", Offset = "0x3E3E220", VA = "0x183E3F020", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct PFMKJHINIAI<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<T> MAOBOAGJBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeList<T> BEHDFOBFLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeParallelHashSet<T> DNDCPHACLKK;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4777C60", Offset = "0x4776E60", VA = "0x184777C60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct PCAOCKPJIBP<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : BLPJEGOCLCP<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public NativeArray<TFrom> MAOBOAGJBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeList<TFrom> BEHDFOBFLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeParallelHashSet<TTo> DNDCPHACLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public TMap ENGMCBPHJGL;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct NKLDAECOJFH<T, TPredicate> : IJob where T : struct where TPredicate : struct, DBDCKJOIBLN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<T> MAOBOAGJBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public NativeArray<Entity> IKEDHKNGMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeList<Entity> DLFEAJFGIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TPredicate ENGMCBPHJGL;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct OANBJFMALGI<T, TPredicate> : IJob where T : struct where TPredicate : struct, DBDCKJOIBLN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> MAOBOAGJBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public NativeList<T> BEHDFOBFLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public TPredicate ENGMCBPHJGL;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct JMLOJEONKJL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public ComponentDataFromEntity ANEKGNLCFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<Entity> IBJGOCHPIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<Entity> EHOOPGFCGFE;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x69E4A80", Offset = "0x69E3C80", VA = "0x1869E4A80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct INPFOALCKIN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[ReadOnly]
	public ComponentDataFromEntity ANEKGNLCFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<Entity> IBJGOCHPIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<Entity> EHOOPGFCGFE;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x69E49F0", Offset = "0x69E3BF0", VA = "0x1869E49F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class IHHAKDEHFIG
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class BCAJBLMCCPG
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x28CAE70", Offset = "0x28CA070", VA = "0x1828CAE70")]
	public static bool GFCPMACJCDO<T>(this NativeArray<Entity> IBJGOCHPIFE, EntityManager DIKLEKJGKDE, Allocator CHDJMCMMMLJ = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class FCKFNAJABFK
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class PFLODPONEDK<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		public PFLODPONEDK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class HIFOCDFACIL<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		public HIFOCDFACIL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<Func<JobHandle, JobHandle>> AJLBKIHJOPF;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x69E4720", Offset = "0x69E3920", VA = "0x1869E4720")]
	public FCKFNAJABFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class FDHOLIPHIML
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class LDJKJBKGAFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct CCCIJMJLDKI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct JHKNCOGMIEH<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			internal CCCIJMJLDKI<TFrom> BMBBFJPOJEB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal Allocator CHDJMCMMMLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal NativeArray<TFrom> HKKDPGGNNBK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct ACLHCDEOONE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct BENEKPONLMK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			internal ACLHCDEOONE<TFrom> BMBBFJPOJEB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal Allocator CHDJMCMMMLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal NativeList<TFrom> HKKDPGGNNBK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct FKMBPOPHMBJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct KADAEJEAHHM<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			internal FKMBPOPHMBJ<TFrom> BMBBFJPOJEB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal Allocator CHDJMCMMMLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal NativeArrayAsync<TFrom> HKKDPGGNNBK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct MEAAJBGOEKJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct MCDJCKGHCJP<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			internal MEAAJBGOEKJ<TFrom> BMBBFJPOJEB;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal Allocator CHDJMCMMMLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal NativeListAsync<TFrom> HKKDPGGNNBK;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class NEGAIJKMEAG
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class MNIBCBPDOLO
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2C40480", Offset = "0x2C3F680", VA = "0x182C40480")]
	public static NativeList<T> LEFFMPLPDEF<T>(this NativeArray<T> DPJDJKECOOD, Allocator CHDJMCMMMLJ = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class KGNFGHEBLIN
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class JNAGDKFGDEL
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2BDFAB0", Offset = "0x2BDECB0", VA = "0x182BDFAB0")]
	[BHPELHEBLOK]
	public static JobHandle PMMKOBDNHMN<T>(this EntityCommandBufferSystem HICMAKMOHPJ, NativeArrayAsync<Entity> JPHDFJFJAJL, NativeArrayAsync<T> LINJEFIAFHO, [Optional] JobHandle KMIHAIPCDEG) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2BDFD50", Offset = "0x2BDEF50", VA = "0x182BDFD50")]
	[BHPELHEBLOK]
	public static JobHandle PMMKOBDNHMN<T>(this EntityCommandBufferSystem HICMAKMOHPJ, NativeArrayAsync<Entity> JPHDFJFJAJL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2BDFC20", Offset = "0x2BDEE20", VA = "0x182BDFC20")]
	[BHPELHEBLOK]
	public static JobHandle PMMKOBDNHMN<T>(this EntityCommandBufferSystem HICMAKMOHPJ, NativeArray<Entity> JPHDFJFJAJL, [Optional] JobHandle KMIHAIPCDEG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x69E4B10", Offset = "0x69E3D10", VA = "0x1869E4B10")]
	[BHPELHEBLOK]
	public static JobHandle PMMKOBDNHMN(this EntityCommandBufferSystem HICMAKMOHPJ, NativeArray<Entity> JPHDFJFJAJL, ComponentTypes NIJECAPFNFB, [Optional] JobHandle KMIHAIPCDEG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x69E4C80", Offset = "0x69E3E80", VA = "0x1869E4C80")]
	[BHPELHEBLOK]
	public static JobHandle PMMKOBDNHMN(this EntityCommandBufferSystem HICMAKMOHPJ, EntityCommandBuffer HDAOBPDCCDB, NativeArray<Entity> JPHDFJFJAJL, ComponentTypes NIJECAPFNFB, [Optional] JobHandle KMIHAIPCDEG)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class ENEIPAEFGCC
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x29E7B70", Offset = "0x29E6D70", VA = "0x1829E7B70")]
	[BHPELHEBLOK]
	public static JobHandle DGBCIMGPEHH<T>(this EntityCommandBufferSystem HICMAKMOHPJ, EntityCommandBuffer HDAOBPDCCDB, EntityQuery EEIHEBHOGFK, T JMDCGOKJIDA) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class KFFFKHOHNCL
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x69E4E50", Offset = "0x69E4050", VA = "0x1869E4E50")]
	[BHPELHEBLOK]
	public static JobHandle DILLCEBMPAG(this EntityCommandBufferSystem HICMAKMOHPJ, NativeList<Entity> JPHDFJFJAJL, [Optional] JobHandle KMIHAIPCDEG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x69E4FE0", Offset = "0x69E41E0", VA = "0x1869E4FE0")]
	[BHPELHEBLOK]
	public static JobHandle DILLCEBMPAG(this EntityCommandBufferSystem HICMAKMOHPJ, NativeArrayAsync<Entity> JPHDFJFJAJL)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class IFMOOBAJCNL
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class GHAPAIKJKOE
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2B36990", Offset = "0x2B35B90", VA = "0x182B36990")]
	[BHPELHEBLOK]
	public static JobHandle KBEIACKMPMC<T>(this EntityCommandBufferSystem HICMAKMOHPJ, NativeArray<Entity> JPHDFJFJAJL, NativeArray<T> LINJEFIAFHO, JobHandle KMIHAIPCDEG) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class BCLMBKHFHLJ
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x28CB450", Offset = "0x28CA650", VA = "0x1828CB450")]
	[BHPELHEBLOK]
	public static JobHandle EJBJINCLJEI<T>(this EntityCommandBufferSystem HICMAKMOHPJ, NativeArray<Entity> JPHDFJFJAJL, T JMDCGOKJIDA, [Optional] JobHandle KMIHAIPCDEG) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x28CB370", Offset = "0x28CA570", VA = "0x1828CB370")]
	[BHPELHEBLOK]
	public static JobHandle EJBJINCLJEI<T>(this EntityCommandBufferSystem HICMAKMOHPJ, EntityCommandBuffer HDAOBPDCCDB, NativeArray<Entity> JPHDFJFJAJL, T JMDCGOKJIDA, [Optional] JobHandle KMIHAIPCDEG) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class AIBOCJMDLEJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class HAFFKPBMCKM
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2B478D0", Offset = "0x2B46AD0", VA = "0x182B478D0")]
	public static NativeArray<T> DPKNLLCNKOD<T>(this NativeList<Entity> DPJDJKECOOD, EntityManager DIKLEKJGKDE, Allocator CHDJMCMMMLJ = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2B47510", Offset = "0x2B46710", VA = "0x182B47510")]
	public static NativeArray<T> DPKNLLCNKOD<T>(this NativeArray<Entity> DPJDJKECOOD, EntityManager DIKLEKJGKDE, Allocator CHDJMCMMMLJ = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x69E4800", Offset = "0x69E3A00", VA = "0x1869E4800")]
	public static NativeArray<Entity> LHBBIDOHNHM(this NativeArray<Entity> DPJDJKECOOD, EntityManager DIKLEKJGKDE, ComponentType JDJBLNJHNEJ, Allocator CHDJMCMMMLJ = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2B47B80", Offset = "0x2B46D80", VA = "0x182B47B80")]
	public static NativeArray<T> JLCJLGNOKOI<T>(this NativeArray<Entity> DPJDJKECOOD, EntityManager DIKLEKJGKDE, Allocator CHDJMCMMMLJ = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class HFJFMCAJPMF
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct NPKLCPEFAHM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct OPHADOLINHG<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public NPKLCPEFAHM<TFrom> HKKDPGGNNBK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public Allocator CHDJMCMMMLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeArray<TFrom> MAOBOAGJBPB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct EJDMGADJGBH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct HKECDBMFOAO<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public EJDMGADJGBH<TFrom> HKKDPGGNNBK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Allocator CHDJMCMMMLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeArrayAsync<TFrom> MAOBOAGJBPB;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct PBOEADCEFPC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct JLOBDJGLCGC<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public PBOEADCEFPC<TFrom> HKKDPGGNNBK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Allocator CHDJMCMMMLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public NativeListAsync<TFrom> MAOBOAGJBPB;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class NBJOIKKOIEK
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class LAGJDPDPGPH
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct FLGPLBMBKGF : BLPJEGOCLCP<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> DGPIHAINOLJ;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x69E47B0", Offset = "0x69E39B0", VA = "0x1869E47B0")]
		[BurstCompatible]
		public Entity KOOHJFIDFKE([In] Entity JMDCGOKJIDA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x69E47B0", Offset = "0x69E39B0", VA = "0x1869E47B0", Slot = "4")]
		private Entity GPNLGLLFJKO([In] Entity JMDCGOKJIDA)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class JOGOIEBHPGN
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct FKGDBLNBDJA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator CHDJMCMMMLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeArray<Entity> IKEDHKNGMLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<T> MAOBOAGJBPB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct FFOBFDBPNBC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Allocator CHDJMCMMMLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<Entity> IKEDHKNGMLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<T> MAOBOAGJBPB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct JEJFHMMIFIA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Allocator CHDJMCMMMLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArrayAsync<Entity> IKEDHKNGMLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArrayAsync<T> MAOBOAGJBPB;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class CPLCGENICAC
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class ONCJPJJPEPG
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct LPILFLPCLIP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Allocator CHDJMCMMMLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public NativeArray<T> MAOBOAGJBPB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct FBNNOIBOAKC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator CHDJMCMMMLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeList<T> MAOBOAGJBPB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct MAILEICDILP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator CHDJMCMMMLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArrayAsync<T> MAOBOAGJBPB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct NECFLOJEIIB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator CHDJMCMMMLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeListAsync<T> MAOBOAGJBPB;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class FCBNCOANJJN
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class FJOLAABHLAI
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2B23D10", Offset = "0x2B22F10", VA = "0x182B23D10")]
	public static NativeList<Entity> HPBGALLAONG<T>(this NativeArray<Entity> IBJGOCHPIFE, EntityManager DIKLEKJGKDE, Allocator CHDJMCMMMLJ = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class CGFEIDKFOEC
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class ECEDGELDNLE
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public readonly struct LADECEACEGL<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly NativeArray<TSrc> PFKJAOOHGBN;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1FCB2B0", Offset = "0x1FCA4B0", VA = "0x181FCB2B0")]
		public LADECEACEGL(NativeArray<TSrc> PFKJAOOHGBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9C7800", Offset = "0x9C6A00", VA = "0x1809C7800")]
		public LMKJHKJCPEB<TSrc, TValue> BFJBPCBKILB<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(LMKJHKJCPEB<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct LMKJHKJCPEB<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NativeArray<TSrc> PFKJAOOHGBN;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1FCB2B0", Offset = "0x1FCA4B0", VA = "0x181FCB2B0")]
		public LMKJHKJCPEB(NativeArray<TSrc> PFKJAOOHGBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9C7800", Offset = "0x9C6A00", VA = "0x1809C7800")]
		public ONJDLCDOPBA<TSrc, TValue, TSelector> DNFAFKAIGIC<TSelector>() where TSelector : struct, BLPJEGOCLCP<TSrc, TValue>
		{
			return default(ONJDLCDOPBA<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct ONJDLCDOPBA<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, BLPJEGOCLCP<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> PFKJAOOHGBN;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1FCB2B0", Offset = "0x1FCA4B0", VA = "0x181FCB2B0")]
		public ONJDLCDOPBA(NativeArray<TSrc> PFKJAOOHGBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x46BB190", Offset = "0x46BA390", VA = "0x1846BB190")]
		public HBNJGOBLLBN<TSrc, TValue, TSelector> HMJFJALFFBM()
		{
			return default(HBNJGOBLLBN<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct NONCJGGNBHK<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, BLPJEGOCLCP<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> PFKJAOOHGBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TSelector GFJKGKFLLNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int DHNLEFJCEAH;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TValue EBFPDFJFKPC
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x454F910", Offset = "0x454EB10", VA = "0x18454F910")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int LINJEMEJAMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8C9C20", Offset = "0x8C8E20", VA = "0x1808C9C20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int PBLCBJADLHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x1FF92F0", Offset = "0x1FF84F0", VA = "0x181FF92F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x454FAE0", Offset = "0x454ECE0", VA = "0x18454FAE0")]
		public NONCJGGNBHK(NativeArray<TSrc> PFKJAOOHGBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x454FAD0", Offset = "0x454ECD0", VA = "0x18454FAD0")]
		public bool PEHFBODDIND()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x454F950", Offset = "0x454EB50", VA = "0x18454F950")]
		private TSrc ICKPOHFJOGL(int HCDMGOGKHKP)
		{
			return (TSrc)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x454FA40", Offset = "0x454EC40", VA = "0x18454FA40")]
		private TValue NHLFIIPNFDA()
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct HBNJGOBLLBN<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, BLPJEGOCLCP<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private NONCJGGNBHK<TSrc, TValue, TSelector> OBCBMANCKCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TValue OMFCEBOOPAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private int JHEGPJBDKAJ;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public DCAAIJCHCEO KPJGLMCKAEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x3D14130", Offset = "0x3D13330", VA = "0x183D14130")]
			get
			{
				return default(DCAAIJCHCEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue FGPDDHEPKBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x85FD10", Offset = "0x85EF10", VA = "0x18085FD10")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, DCAAIJCHCEO range) EBFPDFJFKPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x3D14170", Offset = "0x3D13370", VA = "0x183D14170")]
			get
			{
				return default((TValue, DCAAIJCHCEO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3D143C0", Offset = "0x3D135C0", VA = "0x183D143C0")]
		public HBNJGOBLLBN(NativeArray<TSrc> PFKJAOOHGBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3C72890", Offset = "0x3C71A90", VA = "0x183C72890")]
		public HBNJGOBLLBN<TSrc, TValue, TSelector> DCPEOMEKOMK()
		{
			return default(HBNJGOBLLBN<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3D14240", Offset = "0x3D13440", VA = "0x183D14240")]
		public bool PEHFBODDIND()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x29AEDB0", Offset = "0x29ADFB0", VA = "0x1829AEDB0")]
	public static LADECEACEGL<T> NPNJGFCIKKO<T>(this NativeList<T> CGIFJALMJMI) where T : struct
	{
		return default(LADECEACEGL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9C7800", Offset = "0x9C6A00", VA = "0x1809C7800")]
	public static LADECEACEGL<T> NPNJGFCIKKO<T>(this NativeArray<T> PFKJAOOHGBN) where T : struct
	{
		return default(LADECEACEGL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class OPFGAJPOIGB
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct AFDHODLIHNE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly NativeArray<T>.ReadOnly PFKJAOOHGBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int JHEGPJBDKAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int JDPAJJEEEGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private T OMFCEBOOPAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T EJMFFAEMBML;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public DCAAIJCHCEO KPJGLMCKAEC
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x3C728F0", Offset = "0x3C71AF0", VA = "0x183C728F0")]
			get
			{
				return default(DCAAIJCHCEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T FGPDDHEPKBO
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x386DFB0", Offset = "0x386D1B0", VA = "0x18386DFB0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, DCAAIJCHCEO) EBFPDFJFKPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x3C72900", Offset = "0x3C71B00", VA = "0x183C72900")]
			get
			{
				return default((T, DCAAIJCHCEO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3C72E20", Offset = "0x3C72020", VA = "0x183C72E20")]
		public AFDHODLIHNE(NativeArray<T> PFKJAOOHGBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3C728B0", Offset = "0x3C71AB0", VA = "0x183C728B0")]
		public AFDHODLIHNE<T> DCPEOMEKOMK()
		{
			return default(AFDHODLIHNE<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3C72C40", Offset = "0x3C71E40", VA = "0x183C72C40")]
		public bool PEHFBODDIND()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x25AC070", Offset = "0x25AB270", VA = "0x1825AC070")]
		public LHIBMMNLCNE<T, TComparer> MAGJIOJDGFP<TComparer>([Optional] TComparer FGFHCBCHPIG) where TComparer : struct, IEqualityComparer<T>
		{
			return default(LHIBMMNLCNE<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct LHIBMMNLCNE<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly NativeArray<T>.ReadOnly PFKJAOOHGBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int JHEGPJBDKAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int JDPAJJEEEGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T OMFCEBOOPAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private T EJMFFAEMBML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TComparer FGFHCBCHPIG;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public DCAAIJCHCEO KPJGLMCKAEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x3C728F0", Offset = "0x3C71AF0", VA = "0x183C728F0")]
			get
			{
				return default(DCAAIJCHCEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T FGPDDHEPKBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x386DFB0", Offset = "0x386D1B0", VA = "0x18386DFB0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x4270930", Offset = "0x426FB30", VA = "0x184270930")]
		public LHIBMMNLCNE(NativeArray<T>.ReadOnly PFKJAOOHGBN, TComparer FGFHCBCHPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4270750", Offset = "0x426F950", VA = "0x184270750")]
		public bool PEHFBODDIND()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2CCDA20", Offset = "0x2CCCC20", VA = "0x182CCDA20")]
	public static AFDHODLIHNE<T> HMJFJALFFBM<T>(this NativeArray<T> PFKJAOOHGBN) where T : struct
	{
		return default(AFDHODLIHNE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface OLNMPDAEMMP
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class DEAKDFPGNOL
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct GFJHAGFCOIJ<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class NOKBLBOOHCI : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public GFJHAGFCOIJ<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xC36B10", Offset = "0xC35D10", VA = "0x180C36B10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x3BFB6E0", Offset = "0x3BFA8E0", VA = "0x183BFB6E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85B3D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public NOKBLBOOHCI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x454F6F0", Offset = "0x454E8F0", VA = "0x18454F6F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x454F8C0", Offset = "0x454EAC0", VA = "0x18454F8C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly Action<Protobuf> MLCMFPHKKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly MemoryStream EDOGOHPOPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly CodedInputStream BOMDHAFAGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Protobuf EEEMMJKAAFP;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int PBLCBJADLHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8CD9B0", Offset = "0x8CCBB0", VA = "0x1808CD9B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3CC76B0", Offset = "0x3CC68B0", VA = "0x183CC76B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3CC76F0", Offset = "0x3CC68F0", VA = "0x183CC76F0", Slot = "4")]
	[IteratorStateMachine(typeof(GFJHAGFCOIJ<>.NOKBLBOOHCI))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3CC77F0", Offset = "0x3CC69F0", VA = "0x183CC77F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct BPMLDPDJBPD<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly byte[] PHMDIHEJOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Protobuf EEEMMJKAAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly MemoryStream EDOGOHPOPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly CodedOutputStream KKBIPELALIE;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4E8D750", Offset = "0x4E8C950", VA = "0x184E8D750", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct GNPBLOPCPNM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MemoryStream EDOGOHPOPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CodedInputStream BOMDHAFAGFH;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x69E47C0", Offset = "0x69E39C0", VA = "0x1869E47C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct MLOKLEPGINA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly byte[] PHMDIHEJOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream EDOGOHPOPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedOutputStream KKBIPELALIE;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x69E5280", Offset = "0x69E4480", VA = "0x1869E5280", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class EIAHBKEOKPE
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class FEPEIFIOKLA
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Flags]
public enum HFFDGPCDICG
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
internal static class EFNMNLPJMFH
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class FFCOGINOOIO
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	public FFCOGINOOIO()
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
