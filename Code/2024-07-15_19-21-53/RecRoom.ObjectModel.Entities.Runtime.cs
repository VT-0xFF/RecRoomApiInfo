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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87AEC0", VA = "0x18087C6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87AEC0", VA = "0x18087C6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69C96A0", Offset = "0x69C7EA0", VA = "0x1869C96A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3582930", Offset = "0x3581130", VA = "0x183582930")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5743E60", Offset = "0x5742660", VA = "0x185743E60")]
		public bool GIDLGFOLBNE([Out] TValue JMDCGOKJIDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5744100", Offset = "0x5742900", VA = "0x185744100")]
		public void PBLNBBGFGAP(object EOCJCEFCOOA, TValue JMDCGOKJIDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5744050", Offset = "0x5742850", VA = "0x185744050")]
		public bool MFKDEBIIBOM(object EOCJCEFCOOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5743F60", Offset = "0x5742760", VA = "0x185743F60")]
		public int IMLBDBIFEKB(object EOCJCEFCOOA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x57441E0", Offset = "0x57429E0", VA = "0x1857441E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x46638D0", Offset = "0x46620D0", VA = "0x1846638D0")]
	public OLHHIDIPDIF(EntityManager DIKLEKJGKDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x46633C0", Offset = "0x4661BC0", VA = "0x1846633C0", Slot = "4")]
	public void GMJCNGKBIKC(Entity IBKNLGIDEBH, object EOCJCEFCOOA, TValue JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x46635F0", Offset = "0x4661DF0", VA = "0x1846635F0", Slot = "5")]
	public bool PKCEHGLAEKA(Entity IBKNLGIDEBH, object EOCJCEFCOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x46631A0", Offset = "0x46619A0", VA = "0x1846631A0", Slot = "6")]
	public bool GIDLGFOLBNE(Entity IBKNLGIDEBH, [Out] TValue JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4663160", Offset = "0x4661960", VA = "0x184663160", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4663530", Offset = "0x4661D30", VA = "0x184663530")]
	private void GOMOFBJKICK(DEDBBKCEKJO MOOFNFAEPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x46630A0", Offset = "0x46618A0", VA = "0x1846630A0")]
	private bool DBAPGFINGNH(Entity IBKNLGIDEBH, [Out] EACBOGOHBHP IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x46637E0", Offset = "0x4661FE0", VA = "0x1846637E0")]
	private void PMNMDKFHFAA(Entity IBKNLGIDEBH, EACBOGOHBHP IIMJMBJHGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4663180", Offset = "0x4661980", VA = "0x184663180")]
	private bool GBLHJJLFALC(EACBOGOHBHP IIMJMBJHGDI, [Out] DEDBBKCEKJO MOOFNFAEPBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x46632A0", Offset = "0x4661AA0", VA = "0x1846632A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA7BF00", Offset = "0xA7A700", VA = "0x180A7BF00", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA7BF10", Offset = "0xA7A710", VA = "0x180A7BF10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x255BA90", Offset = "0x255A290", VA = "0x18255BA90", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9A30", Offset = "0x5CA8230", VA = "0x185CA9A30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x69C9600", Offset = "0x69C7E00", VA = "0x1869C9600", Slot = "8")]
	public bool Equals(EACBOGOHBHP OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x69C9650", Offset = "0x69C7E50", VA = "0x1869C9650", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x4480730", Offset = "0x447EF30", VA = "0x184480730")]
	public MDHEAOIOJEB(EntityManager DIKLEKJGKDE, EntityCommandBufferSystem HICMAKMOHPJ, CDLNJDLNIPA MKGIBLBFPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x447F0D0", Offset = "0x447D8D0", VA = "0x18447F0D0", Slot = "4")]
	public bool GMJCNGKBIKC(Entity IBKNLGIDEBH, object EOCJCEFCOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x447FF50", Offset = "0x447E750", VA = "0x18447FF50", Slot = "5")]
	public bool PKCEHGLAEKA(Entity IBKNLGIDEBH, object EOCJCEFCOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x447E210", Offset = "0x447CA10", VA = "0x18447E210", Slot = "6")]
	public bool FBEJJFNJIMN(Entity IBKNLGIDEBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x447E410", Offset = "0x447CC10", VA = "0x18447E410", Slot = "8")]
	public bool FBEJJFNJIMN(EACBOGOHBHP IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x447E190", Offset = "0x447C990", VA = "0x18447E190", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x447F3C0", Offset = "0x447DBC0", VA = "0x18447F3C0")]
	private void GOMOFBJKICK(HashSet<object> MOOFNFAEPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x447DDD0", Offset = "0x447C5D0", VA = "0x18447DDD0")]
	private bool DBAPGFINGNH(Entity IBKNLGIDEBH, [Out] EACBOGOHBHP IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x447DC50", Offset = "0x447C450", VA = "0x18447DC50")]
	private bool CGNDPPHGBIG(Entity IBKNLGIDEBH, [Out] EACBOGOHBHP IIMJMBJHGDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x447F630", Offset = "0x447DE30", VA = "0x18447F630")]
	private void KHMHDMAGGHO(Entity IBKNLGIDEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x447E570", Offset = "0x447CD70", VA = "0x18447E570")]
	private void GKBFNNAFKHO(Entity IBKNLGIDEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x447F8C0", Offset = "0x447E0C0", VA = "0x18447F8C0")]
	private void LIBIHLIDJGC(Entity IBKNLGIDEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x44800F0", Offset = "0x447E8F0", VA = "0x1844800F0")]
	private void PMNMDKFHFAA(Entity IBKNLGIDEBH, EACBOGOHBHP IIMJMBJHGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x447D9B0", Offset = "0x447C1B0", VA = "0x18447D9B0")]
	private bool AJNAKBGHJHO(EACBOGOHBHP IIMJMBJHGDI, [Out] HashSet<object> MOOFNFAEPBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x447EAB0", Offset = "0x447D2B0", VA = "0x18447EAB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x69C9980", Offset = "0x69C8180", VA = "0x1869C9980")]
	public float KOOHJFIDFKE([In] float3 JMDCGOKJIDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x69C9980", Offset = "0x69C8180", VA = "0x1869C9980", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x69CA370", Offset = "0x69C8B70", VA = "0x1869CA370")]
	public float KOOHJFIDFKE([In] float3 JMDCGOKJIDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x69CA370", Offset = "0x69C8B70", VA = "0x1869CA370", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x1CD0AB0", Offset = "0x1CCF2B0", VA = "0x181CD0AB0")]
	public float KOOHJFIDFKE([In] float3 JMDCGOKJIDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1CD0AB0", Offset = "0x1CCF2B0", VA = "0x181CD0AB0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x159D1E0", Offset = "0x159B9E0", VA = "0x18159D1E0")]
	public int KOOHJFIDFKE([In] int3 JMDCGOKJIDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x159D1E0", Offset = "0x159B9E0", VA = "0x18159D1E0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x69CA210", Offset = "0x69C8A10", VA = "0x1869CA210")]
	public int KOOHJFIDFKE([In] int3 JMDCGOKJIDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x69CA210", Offset = "0x69C8A10", VA = "0x1869CA210", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x174BA10", Offset = "0x174A210", VA = "0x18174BA10")]
	public int KOOHJFIDFKE([In] int3 JMDCGOKJIDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x174BA10", Offset = "0x174A210", VA = "0x18174BA10", Slot = "4")]
	private int KMKPHECOJGL([In] int3 JMDCGOKJIDA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class JIIMGOPLHLL : DFPPNDAPLGM
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x14DD360", Offset = "0x14DBB60", VA = "0x1814DD360")]
	public JIIMGOPLHLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class PFBIJGOHPEH : SystemBase, GDJLILNELBP
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x69CA4B0", Offset = "0x69C8CB0", VA = "0x1869CA4B0")]
	public JobHandle GFGJMKDLNPB(ReadOnlySpan<int> MPOIGANILDA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2CC5E10", Offset = "0x2CC4610", VA = "0x182CC5E10")]
	public void AMDMEBBPFPN<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2CC5EA0", Offset = "0x2CC46A0", VA = "0x182CC5EA0")]
	public JobHandle AMDMEBBPFPN<T>(JobHandle IIMJMBJHGDI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x69CA380", Offset = "0x69C8B80", VA = "0x1869CA380")]
	public JobHandle AMDMEBBPFPN(ReadOnlySpan<int> MPOIGANILDA, JobHandle IIMJMBJHGDI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2CC5E10", Offset = "0x2CC4610", VA = "0x182CC5E10")]
	public void FPGCPHOMBOA<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2CC6D80", Offset = "0x2CC5580", VA = "0x182CC6D80")]
	public JobHandle FPGCPHOMBOA<T>(JobHandle IIMJMBJHGDI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x69CA3F0", Offset = "0x69C8BF0", VA = "0x1869CA3F0")]
	public ComponentDataFromEntity EDAHEICJGPD(int ILLCBJEFNGA, bool HKNKBAEFAJL = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x69CA500", Offset = "0x69C8D00", VA = "0x1869CA500")]
	public EntityExistenceLookupByEntity MOKFNDPDBMJ()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x69CA520", Offset = "0x69C8D20", VA = "0x1869CA520", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x14DD360", Offset = "0x14DBB60", VA = "0x1814DD360")]
	protected PFBIJGOHPEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class NGKJLGEGOEI : PFBIJGOHPEH
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x69CA340", Offset = "0x69C8B40", VA = "0x1869CA340", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x14DD360", Offset = "0x14DBB60", VA = "0x1814DD360")]
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
	[Cpp2IlInjected.Address(RVA = "0x14DD360", Offset = "0x14DBB60", VA = "0x1814DD360")]
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
	[Cpp2IlInjected.Address(RVA = "0x69CA120", Offset = "0x69C8920", VA = "0x1869CA120", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x69CA080", Offset = "0x69C8880", VA = "0x1869CA080", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x69C9D70", Offset = "0x69C8570", VA = "0x1869C9D70", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x50204D0", Offset = "0x501ECD0", VA = "0x1850204D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4538E50", Offset = "0x4537650", VA = "0x184538E50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x69C9500", Offset = "0x69C7D00", VA = "0x1869C9500", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E2A530", Offset = "0x3E28D30", VA = "0x183E2A530", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x4761730", Offset = "0x475FF30", VA = "0x184761730", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x69C9A20", Offset = "0x69C8220", VA = "0x1869C9A20", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x69C9990", Offset = "0x69C8190", VA = "0x1869C9990", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x28BCCC0", Offset = "0x28BB4C0", VA = "0x1828BCCC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x69C96C0", Offset = "0x69C7EC0", VA = "0x1869C96C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C31970", Offset = "0x2C30170", VA = "0x182C31970")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BD0FA0", Offset = "0x2BCF7A0", VA = "0x182BD0FA0")]
	[BHPELHEBLOK]
	public static JobHandle PMMKOBDNHMN<T>(this EntityCommandBufferSystem HICMAKMOHPJ, NativeArrayAsync<Entity> JPHDFJFJAJL, NativeArrayAsync<T> LINJEFIAFHO, [Optional] JobHandle KMIHAIPCDEG) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1240", Offset = "0x2BCFA40", VA = "0x182BD1240")]
	[BHPELHEBLOK]
	public static JobHandle PMMKOBDNHMN<T>(this EntityCommandBufferSystem HICMAKMOHPJ, NativeArrayAsync<Entity> JPHDFJFJAJL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1110", Offset = "0x2BCF910", VA = "0x182BD1110")]
	[BHPELHEBLOK]
	public static JobHandle PMMKOBDNHMN<T>(this EntityCommandBufferSystem HICMAKMOHPJ, NativeArray<Entity> JPHDFJFJAJL, [Optional] JobHandle KMIHAIPCDEG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x69C9AB0", Offset = "0x69C82B0", VA = "0x1869C9AB0")]
	[BHPELHEBLOK]
	public static JobHandle PMMKOBDNHMN(this EntityCommandBufferSystem HICMAKMOHPJ, NativeArray<Entity> JPHDFJFJAJL, ComponentTypes NIJECAPFNFB, [Optional] JobHandle KMIHAIPCDEG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x69C9C20", Offset = "0x69C8420", VA = "0x1869C9C20")]
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
	[Cpp2IlInjected.Address(RVA = "0x29D8E70", Offset = "0x29D7670", VA = "0x1829D8E70")]
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
	[Cpp2IlInjected.Address(RVA = "0x69C9DF0", Offset = "0x69C85F0", VA = "0x1869C9DF0")]
	[BHPELHEBLOK]
	public static JobHandle DILLCEBMPAG(this EntityCommandBufferSystem HICMAKMOHPJ, NativeList<Entity> JPHDFJFJAJL, [Optional] JobHandle KMIHAIPCDEG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x69C9F80", Offset = "0x69C8780", VA = "0x1869C9F80")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B284A0", Offset = "0x2B26CA0", VA = "0x182B284A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x28BD2A0", Offset = "0x28BBAA0", VA = "0x1828BD2A0")]
	[BHPELHEBLOK]
	public static JobHandle EJBJINCLJEI<T>(this EntityCommandBufferSystem HICMAKMOHPJ, NativeArray<Entity> JPHDFJFJAJL, T JMDCGOKJIDA, [Optional] JobHandle KMIHAIPCDEG) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x28BD1C0", Offset = "0x28BB9C0", VA = "0x1828BD1C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B393E0", Offset = "0x2B37BE0", VA = "0x182B393E0")]
	public static NativeArray<T> DPKNLLCNKOD<T>(this NativeList<Entity> DPJDJKECOOD, EntityManager DIKLEKJGKDE, Allocator CHDJMCMMMLJ = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2B39020", Offset = "0x2B37820", VA = "0x182B39020")]
	public static NativeArray<T> DPKNLLCNKOD<T>(this NativeArray<Entity> DPJDJKECOOD, EntityManager DIKLEKJGKDE, Allocator CHDJMCMMMLJ = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x69C97A0", Offset = "0x69C7FA0", VA = "0x1869C97A0")]
	public static NativeArray<Entity> LHBBIDOHNHM(this NativeArray<Entity> DPJDJKECOOD, EntityManager DIKLEKJGKDE, ComponentType JDJBLNJHNEJ, Allocator CHDJMCMMMLJ = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2B39690", Offset = "0x2B37E90", VA = "0x182B39690")]
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
		[Cpp2IlInjected.Address(RVA = "0x69C9750", Offset = "0x69C7F50", VA = "0x1869C9750")]
		[BurstCompatible]
		public Entity KOOHJFIDFKE([In] Entity JMDCGOKJIDA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x69C9750", Offset = "0x69C7F50", VA = "0x1869C9750", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B15820", Offset = "0x2B14020", VA = "0x182B15820")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FC02F0", Offset = "0x1FBEAF0", VA = "0x181FC02F0")]
		public LADECEACEGL(NativeArray<TSrc> PFKJAOOHGBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5250", VA = "0x1809C6A50")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FC02F0", Offset = "0x1FBEAF0", VA = "0x181FC02F0")]
		public LMKJHKJCPEB(NativeArray<TSrc> PFKJAOOHGBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5250", VA = "0x1809C6A50")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FC02F0", Offset = "0x1FBEAF0", VA = "0x181FC02F0")]
		public ONJDLCDOPBA(NativeArray<TSrc> PFKJAOOHGBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x46A46B0", Offset = "0x46A2EB0", VA = "0x1846A46B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x453A200", Offset = "0x4538A00", VA = "0x18453A200")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int LINJEMEJAMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8C9DE0", Offset = "0x8C85E0", VA = "0x1808C9DE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int PBLCBJADLHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x453A3D0", Offset = "0x4538BD0", VA = "0x18453A3D0")]
		public NONCJGGNBHK(NativeArray<TSrc> PFKJAOOHGBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x453A3C0", Offset = "0x4538BC0", VA = "0x18453A3C0")]
		public bool PEHFBODDIND()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x453A240", Offset = "0x4538A40", VA = "0x18453A240")]
		private TSrc ICKPOHFJOGL(int HCDMGOGKHKP)
		{
			return (TSrc)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x453A330", Offset = "0x4538B30", VA = "0x18453A330")]
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
			[Cpp2IlInjected.Address(RVA = "0x3CFFDF0", Offset = "0x3CFE5F0", VA = "0x183CFFDF0")]
			get
			{
				return default(DCAAIJCHCEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue FGPDDHEPKBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x85FD10", Offset = "0x85E510", VA = "0x18085FD10")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, DCAAIJCHCEO range) EBFPDFJFKPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x3CFFE30", Offset = "0x3CFE630", VA = "0x183CFFE30")]
			get
			{
				return default((TValue, DCAAIJCHCEO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3D00080", Offset = "0x3CFE880", VA = "0x183D00080")]
		public HBNJGOBLLBN(NativeArray<TSrc> PFKJAOOHGBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3C5F900", Offset = "0x3C5E100", VA = "0x183C5F900")]
		public HBNJGOBLLBN<TSrc, TValue, TSelector> DCPEOMEKOMK()
		{
			return default(HBNJGOBLLBN<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3CFFF00", Offset = "0x3CFE700", VA = "0x183CFFF00")]
		public bool PEHFBODDIND()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x29A08A0", Offset = "0x299F0A0", VA = "0x1829A08A0")]
	public static LADECEACEGL<T> NPNJGFCIKKO<T>(this NativeList<T> CGIFJALMJMI) where T : struct
	{
		return default(LADECEACEGL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9C6A50", Offset = "0x9C5250", VA = "0x1809C6A50")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C5F960", Offset = "0x3C5E160", VA = "0x183C5F960")]
			get
			{
				return default(DCAAIJCHCEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T FGPDDHEPKBO
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x385B020", Offset = "0x3859820", VA = "0x18385B020")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, DCAAIJCHCEO) EBFPDFJFKPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x3C5F970", Offset = "0x3C5E170", VA = "0x183C5F970")]
			get
			{
				return default((T, DCAAIJCHCEO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3C5FE90", Offset = "0x3C5E690", VA = "0x183C5FE90")]
		public AFDHODLIHNE(NativeArray<T> PFKJAOOHGBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3C5F920", Offset = "0x3C5E120", VA = "0x183C5F920")]
		public AFDHODLIHNE<T> DCPEOMEKOMK()
		{
			return default(AFDHODLIHNE<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3C5FCB0", Offset = "0x3C5E4B0", VA = "0x183C5FCB0")]
		public bool PEHFBODDIND()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x259D320", Offset = "0x259BB20", VA = "0x18259D320")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C5F960", Offset = "0x3C5E160", VA = "0x183C5F960")]
			get
			{
				return default(DCAAIJCHCEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T FGPDDHEPKBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x385B020", Offset = "0x3859820", VA = "0x18385B020")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x425B8E0", Offset = "0x425A0E0", VA = "0x18425B8E0")]
		public LHIBMMNLCNE(NativeArray<T>.ReadOnly PFKJAOOHGBN, TComparer FGFHCBCHPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x425B700", Offset = "0x4259F00", VA = "0x18425B700")]
		public bool PEHFBODDIND()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2CBEF10", Offset = "0x2CBD710", VA = "0x182CBEF10")]
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
			[Cpp2IlInjected.Address(RVA = "0xC35880", Offset = "0xC34080", VA = "0x180C35880", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3BEF030", Offset = "0x3BED830", VA = "0x183BEF030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85A9D0", VA = "0x18085C1D0")]
		[DebuggerHidden]
		public NOKBLBOOHCI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x4539FE0", Offset = "0x45387E0", VA = "0x184539FE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x453A1B0", Offset = "0x45389B0", VA = "0x18453A1B0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x8CDB30", Offset = "0x8CC330", VA = "0x1808CDB30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3CB35B0", Offset = "0x3CB1DB0", VA = "0x183CB35B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3CB35F0", Offset = "0x3CB1DF0", VA = "0x183CB35F0", Slot = "4")]
	[IteratorStateMachine(typeof(GFJHAGFCOIJ<>.NOKBLBOOHCI))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3CB36F0", Offset = "0x3CB1EF0", VA = "0x183CB36F0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4E76750", Offset = "0x4E74F50", VA = "0x184E76750", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x69C9760", Offset = "0x69C7F60", VA = "0x1869C9760", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x69CA220", Offset = "0x69C8A20", VA = "0x1869CA220", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
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
