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
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x73D3AA0", Offset = "0x73D28A0", VA = "0x1873D3AA0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HGKNHAOCIKL : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	CDBMLNCPFOP PBKOFPLJDJC
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
public interface EGPIJABLGIF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FPLPHCFANAB(Entity DGNDJCBPFEH, object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IMDKHFABABK(Entity DGNDJCBPFEH, object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CLNIBENAJNF(Entity DGNDJCBPFEH);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class EBMCNPDIDME<TComponentData, TValue> : AELJJEGOFPG<TValue>, IDisposable where TComponentData : struct, HGKNHAOCIKL
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class JEHIDPOIFBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> BJCKKCNKPEK;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int IPKHGMJKDEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3C74770", Offset = "0x3C73570", VA = "0x183C74770")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x48B9EB0", Offset = "0x48B8CB0", VA = "0x1848B9EB0")]
		public bool FOIIEKDBNIH([Out] TValue IPHILEOFJLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x48BA150", Offset = "0x48B8F50", VA = "0x1848BA150")]
		public void MDGAONDGEMG(object HACFGBHNOCC, TValue IPHILEOFJLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x48B9FC0", Offset = "0x48B8DC0", VA = "0x1848B9FC0")]
		public bool IEINLEAGPOE(object HACFGBHNOCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x48BA070", Offset = "0x48B8E70", VA = "0x1848BA070")]
		public int IKKFBIBAJIP(object HACFGBHNOCC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x48BA230", Offset = "0x48B9030", VA = "0x1848BA230")]
		public JEHIDPOIFBP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<JEHIDPOIFBP> CDOGOAIPJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private FNJPKBHHDHM<CDBMLNCPFOP, JEHIDPOIFBP> IEJFKBFOKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager LEDLAOLOFCD;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3F62B90", Offset = "0x3F61990", VA = "0x183F62B90")]
	public EBMCNPDIDME(EntityManager LEDLAOLOFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3F626E0", Offset = "0x3F614E0", VA = "0x183F626E0", Slot = "4")]
	public void FPLPHCFANAB(Entity DGNDJCBPFEH, object HACFGBHNOCC, TValue IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3F62880", Offset = "0x3F61680", VA = "0x183F62880", Slot = "5")]
	public bool IMDKHFABABK(Entity DGNDJCBPFEH, object HACFGBHNOCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3F625D0", Offset = "0x3F613D0", VA = "0x183F625D0", Slot = "6")]
	public bool FOIIEKDBNIH(Entity DGNDJCBPFEH, [Out] TValue IPHILEOFJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3F625B0", Offset = "0x3F613B0", VA = "0x183F625B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3F623F0", Offset = "0x3F611F0", VA = "0x183F623F0")]
	private void BAPOLCLMHNG(JEHIDPOIFBP NLLGKFMNGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3F62330", Offset = "0x3F61130", VA = "0x183F62330")]
	private bool BAGAEBBKKPC(Entity DGNDJCBPFEH, [Out] CDBMLNCPFOP IPNJAOPIHCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3F624B0", Offset = "0x3F612B0", VA = "0x183F624B0")]
	private void DHCLBHMJCFJ(Entity DGNDJCBPFEH, CDBMLNCPFOP IPNJAOPIHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3F62860", Offset = "0x3F61660", VA = "0x183F62860")]
	private bool GPBPEHIIIDA(CDBMLNCPFOP IPNJAOPIHCP, [Out] JEHIDPOIFBP NLLGKFMNGAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3F62A70", Offset = "0x3F61870", VA = "0x183F62A70")]
	private JEHIDPOIFBP NBCFKHNIJLI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface AELJJEGOFPG<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FPLPHCFANAB(Entity DGNDJCBPFEH, object HACFGBHNOCC, TValue IPHILEOFJLB);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IMDKHFABABK(Entity DGNDJCBPFEH, object HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FOIIEKDBNIH(Entity DGNDJCBPFEH, [Out] TValue IPHILEOFJLB);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct CDBMLNCPFOP : PLHKHJEHJBK, IEquatable<CDBMLNCPFOP>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly CDBMLNCPFOP EKNPGNFGBJM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int OFCLDJHOLLK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xC71390", Offset = "0xC70190", VA = "0x180C71390", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xFBB960", Offset = "0xFBA760", VA = "0x180FBB960", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int CKCKCAOJJOM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B506C0", Offset = "0x2B4F4C0", VA = "0x182B506C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x65B1030", Offset = "0x65AFE30", VA = "0x1865B1030", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x73D3900", Offset = "0x73D2700", VA = "0x1873D3900", Slot = "8")]
	public bool Equals(CDBMLNCPFOP LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x73D3950", Offset = "0x73D2750", VA = "0x1873D3950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class CEJKHFJPEMB<THasTokensTag> : EGPIJABLGIF, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, CDBMLNCPFOP> GDGKJBCKMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> CDOGOAIPJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private FNJPKBHHDHM<CDBMLNCPFOP, HashSet<object>> IEJFKBFOKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager LEDLAOLOFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem ODKBJJEBOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool BBDDFKFCEGM;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5861FC0", Offset = "0x5860DC0", VA = "0x185861FC0")]
	public CEJKHFJPEMB(EntityManager LEDLAOLOFCD, EntityCommandBufferSystem ODKBJJEBOMB, IMOCAMGHNDM CHKDACAPMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5860080", Offset = "0x585EE80", VA = "0x185860080", Slot = "4")]
	public bool FPLPHCFANAB(Entity DGNDJCBPFEH, object HACFGBHNOCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5860420", Offset = "0x585F220", VA = "0x185860420", Slot = "5")]
	public bool IMDKHFABABK(Entity DGNDJCBPFEH, object HACFGBHNOCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x585F4E0", Offset = "0x585E2E0", VA = "0x18585F4E0", Slot = "6")]
	public bool CLNIBENAJNF(Entity DGNDJCBPFEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x585F590", Offset = "0x585E390", VA = "0x18585F590", Slot = "8")]
	public bool CLNIBENAJNF(CDBMLNCPFOP IPNJAOPIHCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x585FA10", Offset = "0x585E810", VA = "0x18585FA10", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x585F400", Offset = "0x585E200", VA = "0x18585F400")]
	private void BAPOLCLMHNG(HashSet<object> NLLGKFMNGAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x585F0B0", Offset = "0x585DEB0", VA = "0x18585F0B0")]
	private bool BAGAEBBKKPC(Entity DGNDJCBPFEH, [Out] CDBMLNCPFOP IPNJAOPIHCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5860C10", Offset = "0x585FA10", VA = "0x185860C10")]
	private bool KILHIAMFFCG(Entity DGNDJCBPFEH, [Out] CDBMLNCPFOP IPNJAOPIHCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5861590", Offset = "0x5860390", VA = "0x185861590")]
	private void OOGNFGGKEGE(Entity DGNDJCBPFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5861390", Offset = "0x5860190", VA = "0x185861390")]
	private void OBONKHCHPIE(Entity DGNDJCBPFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5860AD0", Offset = "0x585F8D0", VA = "0x185860AD0")]
	private void JEDIIJBIHHH(Entity DGNDJCBPFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x585F9A0", Offset = "0x585E7A0", VA = "0x18585F9A0")]
	private void DHCLBHMJCFJ(Entity DGNDJCBPFEH, CDBMLNCPFOP IPNJAOPIHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5861AB0", Offset = "0x58608B0", VA = "0x185861AB0")]
	private bool PNNPPFDNNGN(CDBMLNCPFOP IPNJAOPIHCP, [Out] HashSet<object> NLLGKFMNGAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5861050", Offset = "0x585FE50", VA = "0x185861050")]
	private HashSet<object> NBCFKHNIJLI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class GEEPFGLBDBM
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct AGDMIEHFPGP : NAJGILEMNAC<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x73D3830", Offset = "0x73D2630", VA = "0x1873D3830")]
	public float KJLNIMNJKIG([In] float3 IPHILEOFJLB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x73D3830", Offset = "0x73D2630", VA = "0x1873D3830", Slot = "4")]
	private float CBCLNPPPICG([In] float3 IPHILEOFJLB)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct IKFGAFAOBAP : NAJGILEMNAC<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x73D3DA0", Offset = "0x73D2BA0", VA = "0x1873D3DA0")]
	public float KJLNIMNJKIG([In] float3 IPHILEOFJLB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x73D3DA0", Offset = "0x73D2BA0", VA = "0x1873D3DA0", Slot = "4")]
	private float CBCLNPPPICG([In] float3 IPHILEOFJLB)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct LHPJEMCPBPK : NAJGILEMNAC<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xD19B90", Offset = "0xD18990", VA = "0x180D19B90")]
	public float KJLNIMNJKIG([In] float3 IPHILEOFJLB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xD19B90", Offset = "0xD18990", VA = "0x180D19B90", Slot = "4")]
	private float CBCLNPPPICG([In] float3 IPHILEOFJLB)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct AMPEAEGFPFD : NAJGILEMNAC<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1EF7E10", Offset = "0x1EF6C10", VA = "0x181EF7E10")]
	public int KJLNIMNJKIG([In] int3 IPHILEOFJLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1EF7E10", Offset = "0x1EF6C10", VA = "0x181EF7E10", Slot = "4")]
	private int PKKNEMLMFAB([In] int3 IPHILEOFJLB)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct EMEHJJNFJHF : NAJGILEMNAC<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x73D3A90", Offset = "0x73D2890", VA = "0x1873D3A90")]
	public int KJLNIMNJKIG([In] int3 IPHILEOFJLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x73D3A90", Offset = "0x73D2890", VA = "0x1873D3A90", Slot = "4")]
	private int PKKNEMLMFAB([In] int3 IPHILEOFJLB)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct PJFEDDAOFLD : NAJGILEMNAC<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xCFEB20", Offset = "0xCFD920", VA = "0x180CFEB20")]
	public int KJLNIMNJKIG([In] int3 IPHILEOFJLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xCFEB20", Offset = "0xCFD920", VA = "0x180CFEB20", Slot = "4")]
	private int PKKNEMLMFAB([In] int3 IPHILEOFJLB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class OKBKHEFKGBP : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1DF5AB0", Offset = "0x1DF48B0", VA = "0x181DF5AB0")]
	public OKBKHEFKGBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class FILBMAFFENK : SystemBase, JNHEDLEEIHL
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x73D3BB0", Offset = "0x73D29B0", VA = "0x1873D3BB0")]
	public JobHandle EHOLLFIFAEA(ReadOnlySpan<int> GFMCCCHLKFF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x329B690", Offset = "0x329A490", VA = "0x18329B690")]
	public void GGGIDOFHNFE<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x329B3F0", Offset = "0x329A1F0", VA = "0x18329B3F0")]
	public JobHandle GGGIDOFHNFE<T>(JobHandle IPNJAOPIHCP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x73D3C00", Offset = "0x73D2A00", VA = "0x1873D3C00")]
	public JobHandle GGGIDOFHNFE(ReadOnlySpan<int> GFMCCCHLKFF, JobHandle IPNJAOPIHCP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x329BE20", Offset = "0x329AC20", VA = "0x18329BE20")]
	public JobHandle PMOFGBCGKCL<T>(JobHandle IPNJAOPIHCP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x73D3AF0", Offset = "0x73D28F0", VA = "0x1873D3AF0")]
	public ComponentDataFromEntity COOHIGPNMNN(int KANECGJAFNB, bool DIDOHDJAEFH = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x73D3AD0", Offset = "0x73D28D0", VA = "0x1873D3AD0")]
	public EntityExistenceLookupByEntity AIAKKHFCPMB()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x73D3C70", Offset = "0x73D2A70", VA = "0x1873D3C70", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1DF5AB0", Offset = "0x1DF48B0", VA = "0x181DF5AB0")]
	protected FILBMAFFENK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class AJFEBIAILJA : FILBMAFFENK
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x73D38D0", Offset = "0x73D26D0", VA = "0x1873D38D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1DF5AB0", Offset = "0x1DF48B0", VA = "0x181DF5AB0")]
	protected AJFEBIAILJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class PDPAMJEOIIJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class ACGPNLHHGKH : EntityCommandBufferSystem, JNHEDLEEIHL
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1DF5AB0", Offset = "0x1DF48B0", VA = "0x181DF5AB0")]
	protected ACGPNLHHGKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NAJGILEMNAC<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo KJLNIMNJKIG([In] TFrom IPHILEOFJLB);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface PIFILNOPINP<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BCIFHBLANLI(T IPHILEOFJLB);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BurstCompile]
internal struct DCACHDGJAPH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[ReadOnly]
	public NativeArray<Entity> AIJKCNMCOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public EntityCommandBuffer EGGHBGBBEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public ComponentTypes PEJPLOPIMLN;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x73D39A0", Offset = "0x73D27A0", VA = "0x1873D39A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct JEMHNMNNLKN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> AIJKCNMCOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer EGGHBGBBEOC;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x73D3DB0", Offset = "0x73D2BB0", VA = "0x1873D3DB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct NPJGMBDALCO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public NativeArray<Entity> AIJKCNMCOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public EntityCommandBuffer EGGHBGBBEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public ComponentType MIEKFALHKEC;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x73D47A0", Offset = "0x73D35A0", VA = "0x1873D47A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct GOPKFOCLNGM<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> AIJKCNMCOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public NativeArray<T> JOAPLPPIFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public EntityCommandBuffer EGGHBGBBEOC;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4515700", Offset = "0x4514500", VA = "0x184515700", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal struct FJOLEGONDMN<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> AIJKCNMCOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> DCFFMJLJGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer EGGHBGBBEOC;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct PEKGLFMLIBC<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> AIJKCNMCOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public T IPHILEOFJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer EGGHBGBBEOC;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4F14FD0", Offset = "0x4F13DD0", VA = "0x184F14FD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BurstCompile]
internal struct LJJCKFMHCIE<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, NAJGILEMNAC<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<TFrom> DJPACBALFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[WriteOnly]
	public NativeArray<TTo> AMCPOJJMAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public TMap OOCJAOHFGJK;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct KCAPFMCLFKP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public ComponentDataFromEntity MMOMADOGPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> DJPACBALFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[WriteOnly]
	public NativeArray<byte> AMCPOJJMAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int CAAJJAGKIHP;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x73D3E50", Offset = "0x73D2C50", VA = "0x1873D3E50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct MOJOAFCBGOH<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public ComponentDataFromEntity<T> PDGGLEKMGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public NativeArray<Entity> DJPACBALFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[WriteOnly]
	public NativeList<T> KBEEHBOHKEB;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct ADMFMBDMING<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, NAJGILEMNAC<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> BKKIMPDIOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeList<TTo> AMCPOJJMAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap OOCJAOHFGJK;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct GGHNNKIJFLK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity<T> OGIOCEOFMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> KKKOHEMKFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<bool> APKMFAADLIM;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct HLPHNLIAFGL<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> OGIOCEOFMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> KKKOHEMKFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> APKMFAADLIM;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4588720", Offset = "0x4587520", VA = "0x184588720", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct OLGCJHCGEKD<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<T> DJPACBALFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeList<T> KBEEHBOHKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeParallelHashSet<T> BJHMCNLIEAP;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4E4C540", Offset = "0x4E4B340", VA = "0x184E4C540", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct MLPCPNMIADP<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : NAJGILEMNAC<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<TFrom> DJPACBALFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<TFrom> KBEEHBOHKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<TTo> BJHMCNLIEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public TMap OOCJAOHFGJK;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct KKNPNHJPCIJ<T, TPredicate> : IJob where T : struct where TPredicate : struct, PIFILNOPINP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public NativeArray<T> DJPACBALFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> FEMBOHLCJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeList<Entity> KMIIGCCKGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public TPredicate OOCJAOHFGJK;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct ABICHAJFANG<T, TPredicate> : IJob where T : struct where TPredicate : struct, PIFILNOPINP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<T> DJPACBALFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<T> KBEEHBOHKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate OOCJAOHFGJK;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct MIOACMHCCCC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public ComponentDataFromEntity OGIOCEOFMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	public NativeArray<Entity> KKKOHEMKFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeList<Entity> JNDLAJMCLMB;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x73D4530", Offset = "0x73D3330", VA = "0x1873D4530", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct MHIAJHAOAEK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity OGIOCEOFMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> KKKOHEMKFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> JNDLAJMCLMB;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x73D44A0", Offset = "0x73D32A0", VA = "0x1873D44A0", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class IJGDOAKKOLA
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class MMMBCODBNMJ
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x33C90E0", Offset = "0x33C7EE0", VA = "0x1833C90E0")]
	public static bool NJGHIGGOJHC<T>(this NativeArray<Entity> KKKOHEMKFFJ, EntityManager LEDLAOLOFCD, Allocator GCNJHJPCIGN = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class AGOJDGLOKLM
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class MFELMPEAPEF<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		public MFELMPEAPEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class BJNFMCDKPMD<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		public BJNFMCDKPMD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly List<Func<JobHandle, JobHandle>> OMDNGNAHBNK;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x73D3840", Offset = "0x73D2640", VA = "0x1873D3840")]
	public AGOJDGLOKLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class PDMJPIELDNA
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class HONCDDHECIO
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct IHFDGODAMPF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct HFEKJFLHKIO<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			internal IHFDGODAMPF<TFrom> IFAMCPHMKIP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal Allocator GCNJHJPCIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal NativeArray<TFrom> BKEPLGJNEJH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct CCKMKMABAJA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct AAKJDDHHDHI<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal CCKMKMABAJA<TFrom> IFAMCPHMKIP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator GCNJHJPCIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeList<TFrom> BKEPLGJNEJH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct OCFFCFOPHGJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct MMJEMHGFLIF<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal OCFFCFOPHGJ<TFrom> IFAMCPHMKIP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator GCNJHJPCIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeArrayAsync<TFrom> BKEPLGJNEJH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct NMMNNBBDPNE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct ABHGFAODLOP<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal NMMNNBBDPNE<TFrom> IFAMCPHMKIP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator GCNJHJPCIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeListAsync<TFrom> BKEPLGJNEJH;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class PBJBDPGJJMA
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class PNBGDCEJGLM
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x34A8650", Offset = "0x34A7450", VA = "0x1834A8650")]
	public static NativeList<T> PBFEECEEMBA<T>(this NativeArray<T> OOGMCEJHKKC, Allocator GCNJHJPCIGN = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class PIFCAKMFMOK
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class LPAOKGDCOHC
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x33B17B0", Offset = "0x33B05B0", VA = "0x1833B17B0")]
	[JJIFBHBMBPD]
	public static JobHandle PLKMDHMKDCC<T>(this EntityCommandBufferSystem ODKBJJEBOMB, NativeArrayAsync<Entity> AIJKCNMCOKI, NativeArrayAsync<T> JOAPLPPIFPC, [Optional] JobHandle KBDBPNNHAFG) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x33B1930", Offset = "0x33B0730", VA = "0x1833B1930")]
	[JJIFBHBMBPD]
	public static JobHandle PLKMDHMKDCC<T>(this EntityCommandBufferSystem ODKBJJEBOMB, NativeArrayAsync<Entity> AIJKCNMCOKI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x33B1680", Offset = "0x33B0480", VA = "0x1833B1680")]
	[JJIFBHBMBPD]
	public static JobHandle PLKMDHMKDCC<T>(this EntityCommandBufferSystem ODKBJJEBOMB, NativeArray<Entity> AIJKCNMCOKI, [Optional] JobHandle KBDBPNNHAFG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x73D4330", Offset = "0x73D3130", VA = "0x1873D4330")]
	[JJIFBHBMBPD]
	public static JobHandle PLKMDHMKDCC(this EntityCommandBufferSystem ODKBJJEBOMB, NativeArray<Entity> AIJKCNMCOKI, ComponentTypes PEJPLOPIMLN, [Optional] JobHandle KBDBPNNHAFG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x73D41E0", Offset = "0x73D2FE0", VA = "0x1873D41E0")]
	[JJIFBHBMBPD]
	public static JobHandle PLKMDHMKDCC(this EntityCommandBufferSystem ODKBJJEBOMB, EntityCommandBuffer EGGHBGBBEOC, NativeArray<Entity> AIJKCNMCOKI, ComponentTypes PEJPLOPIMLN, [Optional] JobHandle KBDBPNNHAFG)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class MMLIOBPNOND
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x33C8F60", Offset = "0x33C7D60", VA = "0x1833C8F60")]
	[JJIFBHBMBPD]
	public static JobHandle BIGHBDEEKIL<T>(this EntityCommandBufferSystem ODKBJJEBOMB, EntityCommandBuffer EGGHBGBBEOC, EntityQuery JONMOOEGIAL, T IPHILEOFJLB) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class LMLNJKPAMEN
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x73D4050", Offset = "0x73D2E50", VA = "0x1873D4050")]
	[JJIFBHBMBPD]
	public static JobHandle IFJPNHBKKHO(this EntityCommandBufferSystem ODKBJJEBOMB, NativeList<Entity> AIJKCNMCOKI, [Optional] JobHandle KBDBPNNHAFG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x73D3F50", Offset = "0x73D2D50", VA = "0x1873D3F50")]
	[JJIFBHBMBPD]
	public static JobHandle IFJPNHBKKHO(this EntityCommandBufferSystem ODKBJJEBOMB, NativeArrayAsync<Entity> AIJKCNMCOKI)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class NMCEFJLHNNI
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class CGHFDIJOLOL
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x30FF950", Offset = "0x30FE750", VA = "0x1830FF950")]
	[JJIFBHBMBPD]
	public static JobHandle ILDCFFPAJKI<T>(this EntityCommandBufferSystem ODKBJJEBOMB, NativeArray<Entity> AIJKCNMCOKI, NativeArray<T> JOAPLPPIFPC, JobHandle KBDBPNNHAFG) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class HGPMEPMGKEM
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x32BCCB0", Offset = "0x32BBAB0", VA = "0x1832BCCB0")]
	[JJIFBHBMBPD]
	public static JobHandle AJDAFHHPKCM<T>(this EntityCommandBufferSystem ODKBJJEBOMB, NativeArray<Entity> AIJKCNMCOKI, T IPHILEOFJLB, [Optional] JobHandle KBDBPNNHAFG) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x32BCDA0", Offset = "0x32BBBA0", VA = "0x1832BCDA0")]
	[JJIFBHBMBPD]
	public static JobHandle AJDAFHHPKCM<T>(this EntityCommandBufferSystem ODKBJJEBOMB, EntityCommandBuffer EGGHBGBBEOC, NativeArray<Entity> AIJKCNMCOKI, T IPHILEOFJLB, [Optional] JobHandle KBDBPNNHAFG) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class AKEJGJOBMLG
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class NLNCFLGDFMB
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3460A30", Offset = "0x345F830", VA = "0x183460A30")]
	public static NativeArray<T> ODBBKFNPMNP<T>(this NativeArray<Entity> OOGMCEJHKKC, EntityManager LEDLAOLOFCD, Allocator GCNJHJPCIGN = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x73D45C0", Offset = "0x73D33C0", VA = "0x1873D45C0")]
	public static NativeArray<Entity> FNDONKDOCIK(this NativeArray<Entity> OOGMCEJHKKC, EntityManager LEDLAOLOFCD, ComponentType MIEKFALHKEC, Allocator GCNJHJPCIGN = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3460950", Offset = "0x345F750", VA = "0x183460950")]
	public static NativeArray<T> KLGHFOKBLPK<T>(this NativeArray<Entity> OOGMCEJHKKC, EntityManager LEDLAOLOFCD, Allocator GCNJHJPCIGN = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class PJDBGFEOFIG
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct HJMJFHJCJLA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct BACPMBFOOIG<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public HJMJFHJCJLA<TFrom> BKEPLGJNEJH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Allocator GCNJHJPCIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public NativeArray<TFrom> DJPACBALFDH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct OAGCCNNLOMB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct CBFOCLAOEPC<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public OAGCCNNLOMB<TFrom> BKEPLGJNEJH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator GCNJHJPCIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArrayAsync<TFrom> DJPACBALFDH;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct HCKAOJPPFLB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct GAECGMANNJA<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public HCKAOJPPFLB<TFrom> BKEPLGJNEJH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator GCNJHJPCIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeListAsync<TFrom> DJPACBALFDH;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class DFOLHIENOKD
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class KIEEMAFJILO
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct FGAFGPJKNGB : NAJGILEMNAC<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> GANACIGFFOM;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x73D3AC0", Offset = "0x73D28C0", VA = "0x1873D3AC0")]
		[BurstCompatible]
		public Entity KJLNIMNJKIG([In] Entity IPHILEOFJLB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x73D3AC0", Offset = "0x73D28C0", VA = "0x1873D3AC0", Slot = "4")]
		private Entity ADPCHNKGLNP([In] Entity IPHILEOFJLB)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class KFNADODIHLA
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct HIICOJKEIDI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator GCNJHJPCIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<Entity> FEMBOHLCJOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<T> DJPACBALFDH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct PPIIGHLFEGO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator GCNJHJPCIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeList<Entity> FEMBOHLCJOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> DJPACBALFDH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct EHPFEKCEJCK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator GCNJHJPCIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArrayAsync<Entity> FEMBOHLCJOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArrayAsync<T> DJPACBALFDH;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class JJMDOJMDLFA
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class GBOHIAKGKNJ
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct CGEMDJFFMFM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator GCNJHJPCIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> DJPACBALFDH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct KCJJIIEFEIO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator GCNJHJPCIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> DJPACBALFDH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct BHBDLMMOAGO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator GCNJHJPCIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeArrayAsync<T> DJPACBALFDH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct KPBLIENDOBD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator GCNJHJPCIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NativeListAsync<T> DJPACBALFDH;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class MGDLGCPPEEA
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class BBDGEPLEEHF
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x306F7F0", Offset = "0x306E5F0", VA = "0x18306F7F0")]
	public static NativeList<Entity> OBINJCILGKM<T>(this NativeArray<Entity> KKKOHEMKFFJ, EntityManager LEDLAOLOFCD, Allocator GCNJHJPCIGN = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class HOABCPHCHAJ
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class DLAKIHLLPHD
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public readonly struct FAKHOLHFIDK<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NativeArray<TSrc> EOOCBMPNEML;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x105A210", Offset = "0x1059010", VA = "0x18105A210")]
		public FAKHOLHFIDK(NativeArray<TSrc> EOOCBMPNEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x105A220", Offset = "0x1059020", VA = "0x18105A220")]
		public JGCKCNGOJBA<TSrc, TValue> HMPGHDPFJAN<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(JGCKCNGOJBA<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct JGCKCNGOJBA<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> EOOCBMPNEML;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x105A210", Offset = "0x1059010", VA = "0x18105A210")]
		public JGCKCNGOJBA(NativeArray<TSrc> EOOCBMPNEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x105A220", Offset = "0x1059020", VA = "0x18105A220")]
		public NEPKAEMKAHI<TSrc, TValue, TSelector> NCCMLIHLNBH<TSelector>() where TSelector : struct, NAJGILEMNAC<TSrc, TValue>
		{
			return default(NEPKAEMKAHI<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct NEPKAEMKAHI<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, NAJGILEMNAC<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> EOOCBMPNEML;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x105A210", Offset = "0x1059010", VA = "0x18105A210")]
		public NEPKAEMKAHI(NativeArray<TSrc> EOOCBMPNEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4D25E90", Offset = "0x4D24C90", VA = "0x184D25E90")]
		public MMLPMPMEKKK<TSrc, TValue, TSelector> NLNOHKDLLIJ()
		{
			return default(MMLPMPMEKKK<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct EIGKHLPHAIH<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, NAJGILEMNAC<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> EOOCBMPNEML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TSelector CLFNDHMLHOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int KNCPCNBMDNF;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TValue ABCAFDPDGPK
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x3FE3060", Offset = "0x3FE1E60", VA = "0x183FE3060")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int OFCLDJHOLLK
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xA5E990", Offset = "0xA5D790", VA = "0x180A5E990")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int BNJCPJCFEEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2533EA0", Offset = "0x2532CA0", VA = "0x182533EA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3FE3240", Offset = "0x3FE2040", VA = "0x183FE3240")]
		public EIGKHLPHAIH(NativeArray<TSrc> EOOCBMPNEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3FE30A0", Offset = "0x3FE1EA0", VA = "0x183FE30A0")]
		public bool HGCPDEMNJKM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x3FE3140", Offset = "0x3FE1F40", VA = "0x183FE3140")]
		private TSrc JJJCBKKHHGM(int JELBMBFLBOP)
		{
			return (TSrc)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3FE30B0", Offset = "0x3FE1EB0", VA = "0x183FE30B0")]
		private TValue ICFKBICEENB()
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct MMLPMPMEKKK<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, NAJGILEMNAC<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private EIGKHLPHAIH<TSrc, TValue, TSelector> NCNLLJPEKAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TValue HDAONFNEDOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int GJCOHOCILFF;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public GGPBJDCMKPH NLLHDOLLOKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x4CC3ED0", Offset = "0x4CC2CD0", VA = "0x184CC3ED0")]
			get
			{
				return default(GGPBJDCMKPH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue EIKGKMOKNBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8FAE20", Offset = "0x8F9C20", VA = "0x1808FAE20")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, GGPBJDCMKPH range) ABCAFDPDGPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x4CC3C80", Offset = "0x4CC2A80", VA = "0x184CC3C80")]
			get
			{
				return default((TValue, GGPBJDCMKPH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x4CC3F10", Offset = "0x4CC2D10", VA = "0x184CC3F10")]
		public MMLPMPMEKKK(NativeArray<TSrc> EOOCBMPNEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x457D8D0", Offset = "0x457C6D0", VA = "0x18457D8D0")]
		public MMLPMPMEKKK<TSrc, TValue, TSelector> NAPBKLICNNH()
		{
			return default(MMLPMPMEKKK<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4CC3D50", Offset = "0x4CC2B50", VA = "0x184CC3D50")]
		public bool HGCPDEMNJKM()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3146530", Offset = "0x3145330", VA = "0x183146530")]
	public static FAKHOLHFIDK<T> KAHGKEHCFMI<T>(this NativeList<T> BJCKKCNKPEK) where T : struct
	{
		return default(FAKHOLHFIDK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x105A220", Offset = "0x1059020", VA = "0x18105A220")]
	public static FAKHOLHFIDK<T> KAHGKEHCFMI<T>(this NativeArray<T> EOOCBMPNEML) where T : struct
	{
		return default(FAKHOLHFIDK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class FAHGEINHONG
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct HMBLCIBMAEB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly NativeArray<T>.ReadOnly EOOCBMPNEML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int GJCOHOCILFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int KBGLFJBOFMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T HDAONFNEDOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private T AMBOEJHNJAM;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public GGPBJDCMKPH NLLHDOLLOKK
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x454C1D0", Offset = "0x454AFD0", VA = "0x18454C1D0")]
			get
			{
				return default(GGPBJDCMKPH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T EIKGKMOKNBH
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x405DE40", Offset = "0x405CC40", VA = "0x18405DE40")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, GGPBJDCMKPH) ABCAFDPDGPK
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x4594F30", Offset = "0x4593D30", VA = "0x184594F30")]
			get
			{
				return default((T, GGPBJDCMKPH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4595490", Offset = "0x4594290", VA = "0x184595490")]
		public HMBLCIBMAEB(NativeArray<T> EOOCBMPNEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4595450", Offset = "0x4594250", VA = "0x184595450")]
		public HMBLCIBMAEB<T> NAPBKLICNNH()
		{
			return default(HMBLCIBMAEB<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4595270", Offset = "0x4594070", VA = "0x184595270")]
		public bool HGCPDEMNJKM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x35B40B0", Offset = "0x35B2EB0", VA = "0x1835B40B0")]
		public HAJMIPDIPMD<T, TComparer> CBLAHACNGPD<TComparer>([Optional] TComparer JGNANFMDBFC) where TComparer : struct, IEqualityComparer<T>
		{
			return default(HAJMIPDIPMD<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct HAJMIPDIPMD<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly NativeArray<T>.ReadOnly EOOCBMPNEML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int GJCOHOCILFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int KBGLFJBOFMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private T HDAONFNEDOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private T AMBOEJHNJAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TComparer JGNANFMDBFC;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public GGPBJDCMKPH NLLHDOLLOKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x454C1D0", Offset = "0x454AFD0", VA = "0x18454C1D0")]
			get
			{
				return default(GGPBJDCMKPH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T EIKGKMOKNBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x405DE40", Offset = "0x405CC40", VA = "0x18405DE40")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x454C1E0", Offset = "0x454AFE0", VA = "0x18454C1E0")]
		public HAJMIPDIPMD(NativeArray<T>.ReadOnly EOOCBMPNEML, TComparer JGNANFMDBFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x454BFF0", Offset = "0x454ADF0", VA = "0x18454BFF0")]
		public bool HGCPDEMNJKM()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3293FF0", Offset = "0x3292DF0", VA = "0x183293FF0")]
	public static HMBLCIBMAEB<T> NLNOHKDLLIJ<T>(this NativeArray<T> EOOCBMPNEML) where T : struct
	{
		return default(HMBLCIBMAEB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface DECIGFPFAJL
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class JNDPHIPNNAG
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct POGGPHLECGE<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class HECNFLIFMOO : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public POGGPHLECGE<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xACB760", Offset = "0xACA560", VA = "0x180ACB760", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x444E160", Offset = "0x444CF60", VA = "0x18444E160", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
		[DebuggerHidden]
		public HECNFLIFMOO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x45680F0", Offset = "0x4566EF0", VA = "0x1845680F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x45682C0", Offset = "0x45670C0", VA = "0x1845682C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly Action<Protobuf> IOBHJLMFKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly MemoryStream ONEEGGNAFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly CodedInputStream OKDPGCMFOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Protobuf MKAIGHNBGKO;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int BNJCPJCFEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAB5DD0", Offset = "0xAB4BD0", VA = "0x180AB5DD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4F3DC10", Offset = "0x4F3CA10", VA = "0x184F3DC10", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4F3DC50", Offset = "0x4F3CA50", VA = "0x184F3DC50", Slot = "4")]
	[IteratorStateMachine(typeof(POGGPHLECGE<>.HECNFLIFMOO))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4F3DD50", Offset = "0x4F3CB50", VA = "0x184F3DD50", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct BAFNAOCDPMH<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly byte[] FBEHCHGAOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Protobuf MKAIGHNBGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream ONEEGGNAFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedOutputStream KNJNFBIMHAM;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x560C8C0", Offset = "0x560B6C0", VA = "0x18560C8C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct PIOMLHIPPFI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly MemoryStream ONEEGGNAFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly CodedInputStream OKDPGCMFOOI;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x73D4820", Offset = "0x73D3620", VA = "0x1873D4820", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct GCIPLEAHKGM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly byte[] FBEHCHGAOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly MemoryStream ONEEGGNAFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CodedOutputStream KNJNFBIMHAM;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x73D3C80", Offset = "0x73D2A80", VA = "0x1873D3C80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class MHNPAHDIANF
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class PMFFLMEFBDC
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Flags]
public enum IMAHKKDEJNL
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
internal static class BDGOJDNJCBD
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class PINIBFHHCLA
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public PINIBFHHCLA()
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
