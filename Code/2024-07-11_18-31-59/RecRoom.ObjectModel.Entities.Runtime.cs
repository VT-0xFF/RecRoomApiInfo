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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87B0C0", VA = "0x18087C6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87B0C0", VA = "0x18087C6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69C97A0", Offset = "0x69C81A0", VA = "0x1869C97A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3582A30", Offset = "0x3581430", VA = "0x183582A30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5743F60", Offset = "0x5742960", VA = "0x185743F60")]
		public bool GIDLGFOLBNE([Out] TValue JMDCGOKJIDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5744200", Offset = "0x5742C00", VA = "0x185744200")]
		public void PBLNBBGFGAP(object EOCJCEFCOOA, TValue JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5744150", Offset = "0x5742B50", VA = "0x185744150")]
		public bool MFKDEBIIBOM(object EOCJCEFCOOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5744060", Offset = "0x5742A60", VA = "0x185744060")]
		public int IMLBDBIFEKB(object EOCJCEFCOOA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x57442E0", Offset = "0x5742CE0", VA = "0x1857442E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x46639D0", Offset = "0x46623D0", VA = "0x1846639D0")]
	public OLHHIDIPDIF(EntityManager DIKLEKJGKDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x46634C0", Offset = "0x4661EC0", VA = "0x1846634C0", Slot = "4")]
	public void GMJCNGKBIKC(Entity IBKNLGIDEBH, object EOCJCEFCOOA, TValue JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x46636F0", Offset = "0x46620F0", VA = "0x1846636F0", Slot = "5")]
	public bool PKCEHGLAEKA(Entity IBKNLGIDEBH, object EOCJCEFCOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x46632A0", Offset = "0x4661CA0", VA = "0x1846632A0", Slot = "6")]
	public bool GIDLGFOLBNE(Entity IBKNLGIDEBH, [Out] TValue JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4663260", Offset = "0x4661C60", VA = "0x184663260", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4663630", Offset = "0x4662030", VA = "0x184663630")]
	private void GOMOFBJKICK(DEDBBKCEKJO MOOFNFAEPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x46631A0", Offset = "0x4661BA0", VA = "0x1846631A0")]
	private bool DBAPGFINGNH(Entity IBKNLGIDEBH, [Out] EACBOGOHBHP IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x46638E0", Offset = "0x46622E0", VA = "0x1846638E0")]
	private void PMNMDKFHFAA(Entity IBKNLGIDEBH, EACBOGOHBHP IIMJMBJHGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4663280", Offset = "0x4661C80", VA = "0x184663280")]
	private bool GBLHJJLFALC(EACBOGOHBHP IIMJMBJHGDI, [Out] DEDBBKCEKJO MOOFNFAEPBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x46633A0", Offset = "0x4661DA0", VA = "0x1846633A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7BF00", Offset = "0xA7A900", VA = "0x180A7BF00", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA7BF10", Offset = "0xA7A910", VA = "0x180A7BF10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x255BA90", Offset = "0x255A490", VA = "0x18255BA90", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9B30", Offset = "0x5CA8530", VA = "0x185CA9B30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x69C9700", Offset = "0x69C8100", VA = "0x1869C9700", Slot = "8")]
	public bool Equals(EACBOGOHBHP OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x69C9750", Offset = "0x69C8150", VA = "0x1869C9750", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x4480830", Offset = "0x447F230", VA = "0x184480830")]
	public MDHEAOIOJEB(EntityManager DIKLEKJGKDE, EntityCommandBufferSystem HICMAKMOHPJ, CDLNJDLNIPA MKGIBLBFPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x447F1D0", Offset = "0x447DBD0", VA = "0x18447F1D0", Slot = "4")]
	public bool GMJCNGKBIKC(Entity IBKNLGIDEBH, object EOCJCEFCOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4480050", Offset = "0x447EA50", VA = "0x184480050", Slot = "5")]
	public bool PKCEHGLAEKA(Entity IBKNLGIDEBH, object EOCJCEFCOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x447E310", Offset = "0x447CD10", VA = "0x18447E310", Slot = "6")]
	public bool FBEJJFNJIMN(Entity IBKNLGIDEBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x447E510", Offset = "0x447CF10", VA = "0x18447E510", Slot = "8")]
	public bool FBEJJFNJIMN(EACBOGOHBHP IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x447E290", Offset = "0x447CC90", VA = "0x18447E290", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x447F4C0", Offset = "0x447DEC0", VA = "0x18447F4C0")]
	private void GOMOFBJKICK(HashSet<object> MOOFNFAEPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x447DED0", Offset = "0x447C8D0", VA = "0x18447DED0")]
	private bool DBAPGFINGNH(Entity IBKNLGIDEBH, [Out] EACBOGOHBHP IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x447DD50", Offset = "0x447C750", VA = "0x18447DD50")]
	private bool CGNDPPHGBIG(Entity IBKNLGIDEBH, [Out] EACBOGOHBHP IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x447F730", Offset = "0x447E130", VA = "0x18447F730")]
	private void KHMHDMAGGHO(Entity IBKNLGIDEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x447E670", Offset = "0x447D070", VA = "0x18447E670")]
	private void GKBFNNAFKHO(Entity IBKNLGIDEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x447F9C0", Offset = "0x447E3C0", VA = "0x18447F9C0")]
	private void LIBIHLIDJGC(Entity IBKNLGIDEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x44801F0", Offset = "0x447EBF0", VA = "0x1844801F0")]
	private void PMNMDKFHFAA(Entity IBKNLGIDEBH, EACBOGOHBHP IIMJMBJHGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x447DAB0", Offset = "0x447C4B0", VA = "0x18447DAB0")]
	private bool AJNAKBGHJHO(EACBOGOHBHP IIMJMBJHGDI, [Out] HashSet<object> MOOFNFAEPBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x447EBB0", Offset = "0x447D5B0", VA = "0x18447EBB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x69C9A80", Offset = "0x69C8480", VA = "0x1869C9A80")]
	public float KOOHJFIDFKE([In] float3 JMDCGOKJIDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x69C9A80", Offset = "0x69C8480", VA = "0x1869C9A80", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x69CA470", Offset = "0x69C8E70", VA = "0x1869CA470")]
	public float KOOHJFIDFKE([In] float3 JMDCGOKJIDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x69CA470", Offset = "0x69C8E70", VA = "0x1869CA470", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CD0AB0", Offset = "0x1CCF4B0", VA = "0x181CD0AB0")]
	public float KOOHJFIDFKE([In] float3 JMDCGOKJIDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1CD0AB0", Offset = "0x1CCF4B0", VA = "0x181CD0AB0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x159D1E0", Offset = "0x159BBE0", VA = "0x18159D1E0")]
	public int KOOHJFIDFKE([In] int3 JMDCGOKJIDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x159D1E0", Offset = "0x159BBE0", VA = "0x18159D1E0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x69CA310", Offset = "0x69C8D10", VA = "0x1869CA310")]
	public int KOOHJFIDFKE([In] int3 JMDCGOKJIDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x69CA310", Offset = "0x69C8D10", VA = "0x1869CA310", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x174BA10", Offset = "0x174A410", VA = "0x18174BA10")]
	public int KOOHJFIDFKE([In] int3 JMDCGOKJIDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x174BA10", Offset = "0x174A410", VA = "0x18174BA10", Slot = "4")]
	private int KMKPHECOJGL([In] int3 JMDCGOKJIDA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class JIIMGOPLHLL : DFPPNDAPLGM
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x14DD360", Offset = "0x14DBD60", VA = "0x1814DD360")]
	public JIIMGOPLHLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class PFBIJGOHPEH : SystemBase, GDJLILNELBP
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x69CA5B0", Offset = "0x69C8FB0", VA = "0x1869CA5B0")]
	public JobHandle GFGJMKDLNPB(ReadOnlySpan<int> MPOIGANILDA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2CC5F10", Offset = "0x2CC4910", VA = "0x182CC5F10")]
	public void AMDMEBBPFPN<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2CC5FA0", Offset = "0x2CC49A0", VA = "0x182CC5FA0")]
	public JobHandle AMDMEBBPFPN<T>(JobHandle IIMJMBJHGDI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x69CA480", Offset = "0x69C8E80", VA = "0x1869CA480")]
	public JobHandle AMDMEBBPFPN(ReadOnlySpan<int> MPOIGANILDA, JobHandle IIMJMBJHGDI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2CC5F10", Offset = "0x2CC4910", VA = "0x182CC5F10")]
	public void FPGCPHOMBOA<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2CC6E80", Offset = "0x2CC5880", VA = "0x182CC6E80")]
	public JobHandle FPGCPHOMBOA<T>(JobHandle IIMJMBJHGDI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x69CA4F0", Offset = "0x69C8EF0", VA = "0x1869CA4F0")]
	public ComponentDataFromEntity EDAHEICJGPD(int ILLCBJEFNGA, bool HKNKBAEFAJL = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x69CA600", Offset = "0x69C9000", VA = "0x1869CA600")]
	public EntityExistenceLookupByEntity MOKFNDPDBMJ()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x69CA620", Offset = "0x69C9020", VA = "0x1869CA620", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x14DD360", Offset = "0x14DBD60", VA = "0x1814DD360")]
	protected PFBIJGOHPEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class NGKJLGEGOEI : PFBIJGOHPEH
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x69CA440", Offset = "0x69C8E40", VA = "0x1869CA440", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x14DD360", Offset = "0x14DBD60", VA = "0x1814DD360")]
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
	[Cpp2IlInjected.Address(RVA = "0x14DD360", Offset = "0x14DBD60", VA = "0x1814DD360")]
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
	[Cpp2IlInjected.Address(RVA = "0x69CA220", Offset = "0x69C8C20", VA = "0x1869CA220", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x69CA180", Offset = "0x69C8B80", VA = "0x1869CA180", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x69C9E70", Offset = "0x69C8870", VA = "0x1869C9E70", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x50205D0", Offset = "0x501EFD0", VA = "0x1850205D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4538F50", Offset = "0x4537950", VA = "0x184538F50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x69C9600", Offset = "0x69C8000", VA = "0x1869C9600", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E2A630", Offset = "0x3E29030", VA = "0x183E2A630", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4761830", Offset = "0x4760230", VA = "0x184761830", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x69C9B20", Offset = "0x69C8520", VA = "0x1869C9B20", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x69C9A90", Offset = "0x69C8490", VA = "0x1869C9A90", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x28BC9C0", Offset = "0x28BB3C0", VA = "0x1828BC9C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x69C97C0", Offset = "0x69C81C0", VA = "0x1869C97C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C31A70", Offset = "0x2C30470", VA = "0x182C31A70")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BD10A0", Offset = "0x2BCFAA0", VA = "0x182BD10A0")]
	[BHPELHEBLOK]
	public static JobHandle PMMKOBDNHMN<T>(this EntityCommandBufferSystem HICMAKMOHPJ, NativeArrayAsync<Entity> JPHDFJFJAJL, NativeArrayAsync<T> LINJEFIAFHO, [Optional] JobHandle KMIHAIPCDEG) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1340", Offset = "0x2BCFD40", VA = "0x182BD1340")]
	[BHPELHEBLOK]
	public static JobHandle PMMKOBDNHMN<T>(this EntityCommandBufferSystem HICMAKMOHPJ, NativeArrayAsync<Entity> JPHDFJFJAJL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1210", Offset = "0x2BCFC10", VA = "0x182BD1210")]
	[BHPELHEBLOK]
	public static JobHandle PMMKOBDNHMN<T>(this EntityCommandBufferSystem HICMAKMOHPJ, NativeArray<Entity> JPHDFJFJAJL, [Optional] JobHandle KMIHAIPCDEG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x69C9BB0", Offset = "0x69C85B0", VA = "0x1869C9BB0")]
	[BHPELHEBLOK]
	public static JobHandle PMMKOBDNHMN(this EntityCommandBufferSystem HICMAKMOHPJ, NativeArray<Entity> JPHDFJFJAJL, ComponentTypes NIJECAPFNFB, [Optional] JobHandle KMIHAIPCDEG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x69C9D20", Offset = "0x69C8720", VA = "0x1869C9D20")]
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
	[Cpp2IlInjected.Address(RVA = "0x29D8F70", Offset = "0x29D7970", VA = "0x1829D8F70")]
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
	[Cpp2IlInjected.Address(RVA = "0x69C9EF0", Offset = "0x69C88F0", VA = "0x1869C9EF0")]
	[BHPELHEBLOK]
	public static JobHandle DILLCEBMPAG(this EntityCommandBufferSystem HICMAKMOHPJ, NativeList<Entity> JPHDFJFJAJL, [Optional] JobHandle KMIHAIPCDEG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x69CA080", Offset = "0x69C8A80", VA = "0x1869CA080")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B28220", Offset = "0x2B26C20", VA = "0x182B28220")]
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
	[Cpp2IlInjected.Address(RVA = "0x28BCFA0", Offset = "0x28BB9A0", VA = "0x1828BCFA0")]
	[BHPELHEBLOK]
	public static JobHandle EJBJINCLJEI<T>(this EntityCommandBufferSystem HICMAKMOHPJ, NativeArray<Entity> JPHDFJFJAJL, T JMDCGOKJIDA, [Optional] JobHandle KMIHAIPCDEG) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x28BCEC0", Offset = "0x28BB8C0", VA = "0x1828BCEC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B39160", Offset = "0x2B37B60", VA = "0x182B39160")]
	public static NativeArray<T> DPKNLLCNKOD<T>(this NativeList<Entity> DPJDJKECOOD, EntityManager DIKLEKJGKDE, Allocator CHDJMCMMMLJ = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2B38DA0", Offset = "0x2B377A0", VA = "0x182B38DA0")]
	public static NativeArray<T> DPKNLLCNKOD<T>(this NativeArray<Entity> DPJDJKECOOD, EntityManager DIKLEKJGKDE, Allocator CHDJMCMMMLJ = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x69C98A0", Offset = "0x69C82A0", VA = "0x1869C98A0")]
	public static NativeArray<Entity> LHBBIDOHNHM(this NativeArray<Entity> DPJDJKECOOD, EntityManager DIKLEKJGKDE, ComponentType JDJBLNJHNEJ, Allocator CHDJMCMMMLJ = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2B39410", Offset = "0x2B37E10", VA = "0x182B39410")]
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
		[Cpp2IlInjected.Address(RVA = "0x69C9850", Offset = "0x69C8250", VA = "0x1869C9850")]
		[BurstCompatible]
		public Entity KOOHJFIDFKE([In] Entity JMDCGOKJIDA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x69C9850", Offset = "0x69C8250", VA = "0x1869C9850", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B155A0", Offset = "0x2B13FA0", VA = "0x182B155A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FC02F0", Offset = "0x1FBECF0", VA = "0x181FC02F0")]
		public LADECEACEGL(NativeArray<TSrc> PFKJAOOHGBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FC02F0", Offset = "0x1FBECF0", VA = "0x181FC02F0")]
		public LMKJHKJCPEB(NativeArray<TSrc> PFKJAOOHGBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FC02F0", Offset = "0x1FBECF0", VA = "0x181FC02F0")]
		public ONJDLCDOPBA(NativeArray<TSrc> PFKJAOOHGBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x46A47B0", Offset = "0x46A31B0", VA = "0x1846A47B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x453A300", Offset = "0x4538D00", VA = "0x18453A300")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int LINJEMEJAMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8C9DE0", Offset = "0x8C87E0", VA = "0x1808C9DE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int PBLCBJADLHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECD30", VA = "0x181FEE330")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x453A4D0", Offset = "0x4538ED0", VA = "0x18453A4D0")]
		public NONCJGGNBHK(NativeArray<TSrc> PFKJAOOHGBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x453A4C0", Offset = "0x4538EC0", VA = "0x18453A4C0")]
		public bool PEHFBODDIND()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x453A340", Offset = "0x4538D40", VA = "0x18453A340")]
		private TSrc ICKPOHFJOGL(int HCDMGOGKHKP)
		{
			return (TSrc)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x453A430", Offset = "0x4538E30", VA = "0x18453A430")]
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
			[Cpp2IlInjected.Address(RVA = "0x3CFFEF0", Offset = "0x3CFE8F0", VA = "0x183CFFEF0")]
			get
			{
				return default(DCAAIJCHCEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue FGPDDHEPKBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x85FD10", Offset = "0x85E710", VA = "0x18085FD10")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, DCAAIJCHCEO range) EBFPDFJFKPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x3CFFF30", Offset = "0x3CFE930", VA = "0x183CFFF30")]
			get
			{
				return default((TValue, DCAAIJCHCEO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3D00180", Offset = "0x3CFEB80", VA = "0x183D00180")]
		public HBNJGOBLLBN(NativeArray<TSrc> PFKJAOOHGBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3C5FA00", Offset = "0x3C5E400", VA = "0x183C5FA00")]
		public HBNJGOBLLBN<TSrc, TValue, TSelector> DCPEOMEKOMK()
		{
			return default(HBNJGOBLLBN<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3D00000", Offset = "0x3CFEA00", VA = "0x183D00000")]
		public bool PEHFBODDIND()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x29A05A0", Offset = "0x299EFA0", VA = "0x1829A05A0")]
	public static LADECEACEGL<T> NPNJGFCIKKO<T>(this NativeList<T> CGIFJALMJMI) where T : struct
	{
		return default(LADECEACEGL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5450", VA = "0x1809C6A50")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C5FA60", Offset = "0x3C5E460", VA = "0x183C5FA60")]
			get
			{
				return default(DCAAIJCHCEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T FGPDDHEPKBO
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x385B120", Offset = "0x3859B20", VA = "0x18385B120")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, DCAAIJCHCEO) EBFPDFJFKPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x3C5FA70", Offset = "0x3C5E470", VA = "0x183C5FA70")]
			get
			{
				return default((T, DCAAIJCHCEO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3C5FF90", Offset = "0x3C5E990", VA = "0x183C5FF90")]
		public AFDHODLIHNE(NativeArray<T> PFKJAOOHGBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3C5FA20", Offset = "0x3C5E420", VA = "0x183C5FA20")]
		public AFDHODLIHNE<T> DCPEOMEKOMK()
		{
			return default(AFDHODLIHNE<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3C5FDB0", Offset = "0x3C5E7B0", VA = "0x183C5FDB0")]
		public bool PEHFBODDIND()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x259D320", Offset = "0x259BD20", VA = "0x18259D320")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C5FA60", Offset = "0x3C5E460", VA = "0x183C5FA60")]
			get
			{
				return default(DCAAIJCHCEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T FGPDDHEPKBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x385B120", Offset = "0x3859B20", VA = "0x18385B120")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x425B9E0", Offset = "0x425A3E0", VA = "0x18425B9E0")]
		public LHIBMMNLCNE(NativeArray<T>.ReadOnly PFKJAOOHGBN, TComparer FGFHCBCHPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x425B800", Offset = "0x425A200", VA = "0x18425B800")]
		public bool PEHFBODDIND()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2CBF010", Offset = "0x2CBDA10", VA = "0x182CBF010")]
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
			[Cpp2IlInjected.Address(RVA = "0xC35880", Offset = "0xC34280", VA = "0x180C35880", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3BEF130", Offset = "0x3BEDB30", VA = "0x183BEF130", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85ABD0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public NOKBLBOOHCI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x453A0E0", Offset = "0x4538AE0", VA = "0x18453A0E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x453A2B0", Offset = "0x4538CB0", VA = "0x18453A2B0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x8CDB30", Offset = "0x8CC530", VA = "0x1808CDB30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3CB36B0", Offset = "0x3CB20B0", VA = "0x183CB36B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3CB36F0", Offset = "0x3CB20F0", VA = "0x183CB36F0", Slot = "4")]
	[IteratorStateMachine(typeof(GFJHAGFCOIJ<>.NOKBLBOOHCI))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3CB37F0", Offset = "0x3CB21F0", VA = "0x183CB37F0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4E76850", Offset = "0x4E75250", VA = "0x184E76850", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x69C9860", Offset = "0x69C8260", VA = "0x1869C9860", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x69CA320", Offset = "0x69C8D20", VA = "0x1869CA320", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
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
