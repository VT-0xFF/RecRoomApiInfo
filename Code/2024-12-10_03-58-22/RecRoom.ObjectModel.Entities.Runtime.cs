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
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D7A910", Offset = "0x6D79510", VA = "0x186D7A910")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JNCHEOMDDME : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OAGOMCPOLNA LLMIDEEHJDG
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
public interface GEHOEPCCKAM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NCJDHGFPIMD(Entity OKNDNPBNCCC, object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HPOKOEMADOL(Entity OKNDNPBNCCC, object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NGFGCBMMFKF(Entity OKNDNPBNCCC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class POBNNIAIOOP<TComponentData, TValue> : PKOAGCFLCCH<TValue>, IDisposable where TComponentData : struct, JNCHEOMDDME
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class GKBHBNOJBOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> APGPCFDNGCA;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int DNBGNCFCKIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x379C8E0", Offset = "0x379B4E0", VA = "0x18379C8E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3EEC920", Offset = "0x3EEB520", VA = "0x183EEC920")]
		public bool LBLIBPHHPFB([Out] TValue CABLCDOIFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3EEC760", Offset = "0x3EEB360", VA = "0x183EEC760")]
		public void CMCAIIEBGOH(object DGGGDIFONNG, TValue CABLCDOIFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3EEC6B0", Offset = "0x3EEB2B0", VA = "0x183EEC6B0")]
		public bool CEFMELNJEMA(object DGGGDIFONNG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3EEC840", Offset = "0x3EEB440", VA = "0x183EEC840")]
		public int IJKLJNFANMB(object DGGGDIFONNG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3EECA30", Offset = "0x3EEB630", VA = "0x183EECA30")]
		public GKBHBNOJBOB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<GKBHBNOJBOB> HONJGFGOCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private BCHIGFGJONE<OAGOMCPOLNA, GKBHBNOJBOB> OAEOPCINBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager DPCAAACILIP;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4921350", Offset = "0x491FF50", VA = "0x184921350")]
	public POBNNIAIOOP(EntityManager DPCAAACILIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4921110", Offset = "0x491FD10", VA = "0x184921110", Slot = "4")]
	public void NCJDHGFPIMD(Entity OKNDNPBNCCC, object DGGGDIFONNG, TValue CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4920CF0", Offset = "0x491F8F0", VA = "0x184920CF0", Slot = "5")]
	public bool HPOKOEMADOL(Entity OKNDNPBNCCC, object DGGGDIFONNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4920EE0", Offset = "0x491FAE0", VA = "0x184920EE0", Slot = "6")]
	public bool LBLIBPHHPFB(Entity OKNDNPBNCCC, [Out] TValue CABLCDOIFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4920CD0", Offset = "0x491F8D0", VA = "0x184920CD0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4921290", Offset = "0x491FE90", VA = "0x184921290")]
	private void OIBAKOBIALA(GKBHBNOJBOB JGMPAEGDOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4920AF0", Offset = "0x491F6F0", VA = "0x184920AF0")]
	private bool BKLMJDNICEA(Entity OKNDNPBNCCC, [Out] OAGOMCPOLNA JBFBMCPGKHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4920BD0", Offset = "0x491F7D0", VA = "0x184920BD0")]
	private void DKBPENKLIMA(Entity OKNDNPBNCCC, OAGOMCPOLNA JBFBMCPGKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4920BB0", Offset = "0x491F7B0", VA = "0x184920BB0")]
	private bool DAMNHIBOHFG(OAGOMCPOLNA JBFBMCPGKHE, [Out] GKBHBNOJBOB JGMPAEGDOAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4920FF0", Offset = "0x491FBF0", VA = "0x184920FF0")]
	private GKBHBNOJBOB LOKOKBIIEEA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PKOAGCFLCCH<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NCJDHGFPIMD(Entity OKNDNPBNCCC, object DGGGDIFONNG, TValue CABLCDOIFFL);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HPOKOEMADOL(Entity OKNDNPBNCCC, object DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LBLIBPHHPFB(Entity OKNDNPBNCCC, [Out] TValue CABLCDOIFFL);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct OAGOMCPOLNA : HLDDCBEIKDI, IEquatable<OAGOMCPOLNA>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly OAGOMCPOLNA LPNKNEBEAHM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int NAJFJJKNBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA0B980", Offset = "0xA0A580", VA = "0x180A0B980", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xB227D0", Offset = "0xB213D0", VA = "0x180B227D0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int EJLEFLLIODH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2746650", Offset = "0x2745250", VA = "0x182746650", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5D80", Offset = "0x5FB4980", VA = "0x185FB5D80", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B1C0", Offset = "0x6D79DC0", VA = "0x186D7B1C0", Slot = "8")]
	public bool Equals(OAGOMCPOLNA FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B210", Offset = "0x6D79E10", VA = "0x186D7B210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class IFDDGOJJIOO<THasTokensTag> : GEHOEPCCKAM, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly BNHLDIHMNLF HOKLECPLLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, OAGOMCPOLNA> LEEJBMNFCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> HONJGFGOCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BCHIGFGJONE<OAGOMCPOLNA, HashSet<object>> OAEOPCINBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager DPCAAACILIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem DMGEEODOCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool HINLMPLCGEB;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4026070", Offset = "0x4024C70", VA = "0x184026070")]
	public IFDDGOJJIOO(EntityManager DPCAAACILIP, EntityCommandBufferSystem DMGEEODOCLN, BNHLDIHMNLF HHNEIDEMHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4024FB0", Offset = "0x4023BB0", VA = "0x184024FB0", Slot = "4")]
	public bool NCJDHGFPIMD(Entity OKNDNPBNCCC, object DGGGDIFONNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4024590", Offset = "0x4023190", VA = "0x184024590", Slot = "5")]
	public bool HPOKOEMADOL(Entity OKNDNPBNCCC, object DGGGDIFONNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4025520", Offset = "0x4024120", VA = "0x184025520", Slot = "6")]
	public bool NGFGCBMMFKF(Entity OKNDNPBNCCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4025680", Offset = "0x4024280", VA = "0x184025680", Slot = "8")]
	public bool NGFGCBMMFKF(OAGOMCPOLNA JBFBMCPGKHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4023B60", Offset = "0x4022760", VA = "0x184023B60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4025CE0", Offset = "0x40248E0", VA = "0x184025CE0")]
	private void OIBAKOBIALA(HashSet<object> JGMPAEGDOAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x40234A0", Offset = "0x40220A0", VA = "0x1840234A0")]
	private bool BKLMJDNICEA(Entity OKNDNPBNCCC, [Out] OAGOMCPOLNA JBFBMCPGKHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4025AD0", Offset = "0x40246D0", VA = "0x184025AD0")]
	private bool OEGDJHKNDHO(Entity OKNDNPBNCCC, [Out] OAGOMCPOLNA JBFBMCPGKHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4023C20", Offset = "0x4022820", VA = "0x184023C20")]
	private void GPFEAIPIHPP(Entity OKNDNPBNCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4023560", Offset = "0x4022160", VA = "0x184023560")]
	private void BONEJNAKKHB(Entity OKNDNPBNCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4024BC0", Offset = "0x40237C0", VA = "0x184024BC0")]
	private void MLPFGJAIHNI(Entity OKNDNPBNCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4023960", Offset = "0x4022560", VA = "0x184023960")]
	private void DKBPENKLIMA(Entity OKNDNPBNCCC, OAGOMCPOLNA JBFBMCPGKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4024D20", Offset = "0x4023920", VA = "0x184024D20")]
	private bool NANBDDNGGCI(OAGOMCPOLNA JBFBMCPGKHE, [Out] HashSet<object> JGMPAEGDOAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4024940", Offset = "0x4023540", VA = "0x184024940")]
	private HashSet<object> LOKOKBIIEEA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class HEIMGDPPOGE
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct EDNFIIHNHII : BLABPLHNKMK<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6D7A900", Offset = "0x6D79500", VA = "0x186D7A900")]
	public float LGOLDMMBMEG([In] float3 CABLCDOIFFL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6D7A900", Offset = "0x6D79500", VA = "0x186D7A900", Slot = "4")]
	private float MGCKAJFADLM([In] float3 CABLCDOIFFL)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct MBADELDPIPL : BLABPLHNKMK<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B130", Offset = "0x6D79D30", VA = "0x186D7B130")]
	public float LGOLDMMBMEG([In] float3 CABLCDOIFFL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B130", Offset = "0x6D79D30", VA = "0x186D7B130", Slot = "4")]
	private float MGCKAJFADLM([In] float3 CABLCDOIFFL)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct EMKOCGPLPHO : BLABPLHNKMK<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE830", Offset = "0x1FDD430", VA = "0x181FDE830")]
	public float LGOLDMMBMEG([In] float3 CABLCDOIFFL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1FDE830", Offset = "0x1FDD430", VA = "0x181FDE830", Slot = "4")]
	private float MGCKAJFADLM([In] float3 CABLCDOIFFL)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct KNHOPHOGAHJ : BLABPLHNKMK<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1842970", Offset = "0x1841570", VA = "0x181842970")]
	public int LGOLDMMBMEG([In] int3 CABLCDOIFFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1842970", Offset = "0x1841570", VA = "0x181842970", Slot = "4")]
	private int BJGNJPGKCBP([In] int3 CABLCDOIFFL)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct KPLDHLBJDOB : BLABPLHNKMK<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x69973B0", Offset = "0x6995FB0", VA = "0x1869973B0")]
	public int LGOLDMMBMEG([In] int3 CABLCDOIFFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x69973B0", Offset = "0x6995FB0", VA = "0x1869973B0", Slot = "4")]
	private int BJGNJPGKCBP([In] int3 CABLCDOIFFL)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct DACACJJPIKO : BLABPLHNKMK<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xBC97C0", Offset = "0xBC83C0", VA = "0x180BC97C0")]
	public int LGOLDMMBMEG([In] int3 CABLCDOIFFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xBC97C0", Offset = "0xBC83C0", VA = "0x180BC97C0", Slot = "4")]
	private int BJGNJPGKCBP([In] int3 CABLCDOIFFL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class BFMMMHNAANC : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1738690", Offset = "0x1737290", VA = "0x181738690")]
	public BFMMMHNAANC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class GBBIAOIACBC : SystemBase, GLBHAANGGGO
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6D7ACD0", Offset = "0x6D798D0", VA = "0x186D7ACD0")]
	public JobHandle PCNAKCHNDOA(ReadOnlySpan<int> BDJFMDJIMBJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2DF7FB0", Offset = "0x2DF6BB0", VA = "0x182DF7FB0")]
	public void PDFJKHEEJJB<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2DF7D10", Offset = "0x2DF6910", VA = "0x182DF7D10")]
	public JobHandle PDFJKHEEJJB<T>(JobHandle JBFBMCPGKHE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6D7AD20", Offset = "0x6D79920", VA = "0x186D7AD20")]
	public JobHandle PDFJKHEEJJB(ReadOnlySpan<int> BDJFMDJIMBJ, JobHandle JBFBMCPGKHE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2DF7A70", Offset = "0x2DF6670", VA = "0x182DF7A70")]
	public JobHandle CJKFMEDKCEJ<T>(JobHandle JBFBMCPGKHE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6D7ABF0", Offset = "0x6D797F0", VA = "0x186D7ABF0")]
	public ComponentDataFromEntity MNCBPNOELKM(int FPOAMEDFGKO, bool MCMJDLJKCGC = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6D7ACB0", Offset = "0x6D798B0", VA = "0x186D7ACB0")]
	public EntityExistenceLookupByEntity PAJPPCIANHI()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6D7AD90", Offset = "0x6D79990", VA = "0x186D7AD90", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1738690", Offset = "0x1737290", VA = "0x181738690")]
	protected GBBIAOIACBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class DOGGCGLBPJF : GBBIAOIACBC
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6D7A8C0", Offset = "0x6D794C0", VA = "0x186D7A8C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1738690", Offset = "0x1737290", VA = "0x181738690")]
	protected DOGGCGLBPJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class BNGIHPNGKFC
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class NBEMPBHKOIP : EntityCommandBufferSystem, GLBHAANGGGO
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1738690", Offset = "0x1737290", VA = "0x181738690")]
	protected NBEMPBHKOIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface BLABPLHNKMK<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo LGOLDMMBMEG([In] TFrom CABLCDOIFFL);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface MIPJOHKFFBK<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PAMOPNGNJAN(T CABLCDOIFFL);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BurstCompile]
internal struct BNDBMJBGGGO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[ReadOnly]
	public NativeArray<Entity> BHNJCFOPBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public EntityCommandBuffer NJBLOPLHFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public ComponentTypes FHLHPJLMDHJ;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6D7A560", Offset = "0x6D79160", VA = "0x186D7A560", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct GENEFAGLFIH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> BHNJCFOPBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer NJBLOPLHFIL;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6D7ADA0", Offset = "0x6D799A0", VA = "0x186D7ADA0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct NIGHCJKKMPO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public NativeArray<Entity> BHNJCFOPBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public EntityCommandBuffer NJBLOPLHFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public ComponentType CNHGDNGGOPD;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B140", Offset = "0x6D79D40", VA = "0x186D7B140", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct FJBLOMFEAEO<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> BHNJCFOPBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public NativeArray<T> BFLLAIFBMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public EntityCommandBuffer NJBLOPLHFIL;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3E09EF0", Offset = "0x3E08AF0", VA = "0x183E09EF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal struct GFPMPJBDKHH<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> BHNJCFOPBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> ILAABJMNJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer NJBLOPLHFIL;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct CKDJOMJLPKP<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> BHNJCFOPBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public T CABLCDOIFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer NJBLOPLHFIL;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x55DF100", Offset = "0x55DDD00", VA = "0x1855DF100", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BurstCompile]
internal struct DAHICBPELHE<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, BLABPLHNKMK<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<TFrom> MBAODKPBMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[WriteOnly]
	public NativeArray<TTo> OFBMGPGDDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public TMap FNGNLBJEBKM;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct JBONCEIIKBP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public ComponentDataFromEntity BGMKPKNCPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> MBAODKPBMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[WriteOnly]
	public NativeArray<byte> OFBMGPGDDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int JPBNHCJHCMA;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6D7AED0", Offset = "0x6D79AD0", VA = "0x186D7AED0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct ANLKANPPBML<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public ComponentDataFromEntity<T> AKHHILKJPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public NativeArray<Entity> MBAODKPBMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[WriteOnly]
	public NativeList<T> HAHIKBJMFBC;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct NLFEAHPNALH<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, BLABPLHNKMK<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> EFLHLLOJCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeList<TTo> OFBMGPGDDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap FNGNLBJEBKM;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct JACHADKKPAG<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity<T> LADMFPGGGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> DFMPJHEOPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<bool> NGAIENAFJDN;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct CALJNGNOGKC<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> LADMFPGGGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> DFMPJHEOPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> NGAIENAFJDN;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5234D70", Offset = "0x5233970", VA = "0x185234D70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct IIHEIDBIAPH<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<T> MBAODKPBMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeList<T> HAHIKBJMFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeParallelHashSet<T> GICACIPKCID;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x402E3E0", Offset = "0x402CFE0", VA = "0x18402E3E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct GJINBNDKHGL<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : BLABPLHNKMK<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<TFrom> MBAODKPBMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<TFrom> HAHIKBJMFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<TTo> GICACIPKCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public TMap FNGNLBJEBKM;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct HDGJHCDIAMA<T, TPredicate> : IJob where T : struct where TPredicate : struct, MIPJOHKFFBK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public NativeArray<T> MBAODKPBMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> CCJHPAIGAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeList<Entity> ICHGMHBKBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public TPredicate FNGNLBJEBKM;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct HCIDDNLFNFM<T, TPredicate> : IJob where T : struct where TPredicate : struct, MIPJOHKFFBK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<T> MBAODKPBMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<T> HAHIKBJMFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate FNGNLBJEBKM;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct HOHNCDNPCLO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public ComponentDataFromEntity LADMFPGGGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	public NativeArray<Entity> DFMPJHEOPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeList<Entity> FNIIMKDJCFD;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6D7AE40", Offset = "0x6D79A40", VA = "0x186D7AE40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct PEACNLBHEGA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity LADMFPGGGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> DFMPJHEOPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> FNIIMKDJCFD;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B4F0", Offset = "0x6D7A0F0", VA = "0x186D7B4F0", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class KKOLIBMFBFM
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class OBNPMLHIPKM
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2FC3390", Offset = "0x2FC1F90", VA = "0x182FC3390")]
	public static bool NDMBABALFIJ<T>(this NativeArray<Entity> DFMPJHEOPDM, EntityManager DPCAAACILIP, Allocator ICLGONBNBJO = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class CNHBKHAOBHK
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class KJMMBEAJMKJ<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		public KJMMBEAJMKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class CCMOPOPPAMK<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		public CCMOPOPPAMK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly List<Func<JobHandle, JobHandle>> NBDKHHINOGO;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6D7A830", Offset = "0x6D79430", VA = "0x186D7A830")]
	public CNHBKHAOBHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class MCOCNGAIFME
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class GDPAKNLBDIH
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct FMDLCAPMEDJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct AEPHMBPGIKG<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			internal FMDLCAPMEDJ<TFrom> CDBGCEIGNJC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal Allocator ICLGONBNBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal NativeArray<TFrom> FCAIJJGOPCC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct MBICJHGNDKP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct BPIKNGMBCED<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal MBICJHGNDKP<TFrom> CDBGCEIGNJC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator ICLGONBNBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeList<TFrom> FCAIJJGOPCC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct JGIHMPEELFC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct MCMNIAAFJGE<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal JGIHMPEELFC<TFrom> CDBGCEIGNJC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator ICLGONBNBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeArrayAsync<TFrom> FCAIJJGOPCC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct NJKFBOJCFPH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct FHLIOPFKBCO<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal NJKFBOJCFPH<TFrom> CDBGCEIGNJC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator ICLGONBNBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeListAsync<TFrom> FCAIJJGOPCC;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class IOJCDKPLGDE
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class DBAEHBAEJNP
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2C363F0", Offset = "0x2C34FF0", VA = "0x182C363F0")]
	public static NativeList<T> CNOOFCHEBLC<T>(this NativeArray<T> DMJLEDIMDBF, Allocator ICLGONBNBJO = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class MDJBPJFEGMB
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class FCLPHMHFENP
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2DE8BF0", Offset = "0x2DE77F0", VA = "0x182DE8BF0")]
	[FCHGKHLIPOC]
	public static JobHandle BMHPEPBNPLL<T>(this EntityCommandBufferSystem DMGEEODOCLN, NativeArrayAsync<Entity> BHNJCFOPBNC, NativeArrayAsync<T> BFLLAIFBMAJ, [Optional] JobHandle KAKJAACMJHD) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2DE8EA0", Offset = "0x2DE7AA0", VA = "0x182DE8EA0")]
	[FCHGKHLIPOC]
	public static JobHandle BMHPEPBNPLL<T>(this EntityCommandBufferSystem DMGEEODOCLN, NativeArrayAsync<Entity> BHNJCFOPBNC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2DE8D70", Offset = "0x2DE7970", VA = "0x182DE8D70")]
	[FCHGKHLIPOC]
	public static JobHandle BMHPEPBNPLL<T>(this EntityCommandBufferSystem DMGEEODOCLN, NativeArray<Entity> BHNJCFOPBNC, [Optional] JobHandle KAKJAACMJHD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6D7A930", Offset = "0x6D79530", VA = "0x186D7A930")]
	[FCHGKHLIPOC]
	public static JobHandle BMHPEPBNPLL(this EntityCommandBufferSystem DMGEEODOCLN, NativeArray<Entity> BHNJCFOPBNC, ComponentTypes FHLHPJLMDHJ, [Optional] JobHandle KAKJAACMJHD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6D7AAA0", Offset = "0x6D796A0", VA = "0x186D7AAA0")]
	[FCHGKHLIPOC]
	public static JobHandle BMHPEPBNPLL(this EntityCommandBufferSystem DMGEEODOCLN, EntityCommandBuffer NJBLOPLHFIL, NativeArray<Entity> BHNJCFOPBNC, ComponentTypes FHLHPJLMDHJ, [Optional] JobHandle KAKJAACMJHD)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class KCFALFIABIK
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2EC53C0", Offset = "0x2EC3FC0", VA = "0x182EC53C0")]
	[FCHGKHLIPOC]
	public static JobHandle FBIIIPAEMPG<T>(this EntityCommandBufferSystem DMGEEODOCLN, EntityCommandBuffer NJBLOPLHFIL, EntityQuery PBBNDNDLPAF, T CABLCDOIFFL) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class OHMCNHGBHEM
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B260", Offset = "0x6D79E60", VA = "0x186D7B260")]
	[FCHGKHLIPOC]
	public static JobHandle OLDMNMKKBFF(this EntityCommandBufferSystem DMGEEODOCLN, NativeList<Entity> BHNJCFOPBNC, [Optional] JobHandle KAKJAACMJHD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B3F0", Offset = "0x6D79FF0", VA = "0x186D7B3F0")]
	[FCHGKHLIPOC]
	public static JobHandle OLDMNMKKBFF(this EntityCommandBufferSystem DMGEEODOCLN, NativeArrayAsync<Entity> BHNJCFOPBNC)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class AAOKMJFPBBA
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class AHMEKPAPLOJ
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x34B7A20", Offset = "0x34B6620", VA = "0x1834B7A20")]
	[FCHGKHLIPOC]
	public static JobHandle CDHPMHIKLDC<T>(this EntityCommandBufferSystem DMGEEODOCLN, NativeArray<Entity> BHNJCFOPBNC, NativeArray<T> BFLLAIFBMAJ, JobHandle KAKJAACMJHD) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class KDOOLHMJFJC
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2EC6C60", Offset = "0x2EC5860", VA = "0x182EC6C60")]
	[FCHGKHLIPOC]
	public static JobHandle ANBFCCKMMLN<T>(this EntityCommandBufferSystem DMGEEODOCLN, NativeArray<Entity> BHNJCFOPBNC, T CABLCDOIFFL, [Optional] JobHandle KAKJAACMJHD) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2EC6D50", Offset = "0x2EC5950", VA = "0x182EC6D50")]
	[FCHGKHLIPOC]
	public static JobHandle ANBFCCKMMLN<T>(this EntityCommandBufferSystem DMGEEODOCLN, EntityCommandBuffer NJBLOPLHFIL, NativeArray<Entity> BHNJCFOPBNC, T CABLCDOIFFL, [Optional] JobHandle KAKJAACMJHD) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class CMIACGAHOHO
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class CJDKDBFDLNP
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2C047E0", Offset = "0x2C033E0", VA = "0x182C047E0")]
	public static NativeArray<T> NLOJGNBJCOL<T>(this NativeArray<Entity> DMJLEDIMDBF, EntityManager DPCAAACILIP, Allocator ICLGONBNBJO = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6D7A650", Offset = "0x6D79250", VA = "0x186D7A650")]
	public static NativeArray<Entity> IMPHHNDJGPH(this NativeArray<Entity> DMJLEDIMDBF, EntityManager DPCAAACILIP, ComponentType CNHGDNGGOPD, Allocator ICLGONBNBJO = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2C04700", Offset = "0x2C03300", VA = "0x182C04700")]
	public static NativeArray<T> CFHGILIICFD<T>(this NativeArray<Entity> DMJLEDIMDBF, EntityManager DPCAAACILIP, Allocator ICLGONBNBJO = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class FJCKEKGBNHF
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct FLPGLKBDJKE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct FBOFEANIOOI<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public FLPGLKBDJKE<TFrom> FCAIJJGOPCC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Allocator ICLGONBNBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public NativeArray<TFrom> MBAODKPBMNE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct HMFLEPMHHEB<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct BHLMFHFBBGB<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public HMFLEPMHHEB<TFrom> FCAIJJGOPCC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator ICLGONBNBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArrayAsync<TFrom> MBAODKPBMNE;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct DFOLGCOMBCJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct LEMKKNOCIAG<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public DFOLGCOMBCJ<TFrom> FCAIJJGOPCC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator ICLGONBNBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeListAsync<TFrom> MBAODKPBMNE;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class JECMLDFICFH
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class JJAOCGKPFHN
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct DPMEDJKGANA : BLABPLHNKMK<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> CCKFFJOLKHB;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6D7A8F0", Offset = "0x6D794F0", VA = "0x186D7A8F0")]
		[BurstCompatible]
		public Entity LGOLDMMBMEG([In] Entity CABLCDOIFFL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6D7A8F0", Offset = "0x6D794F0", VA = "0x186D7A8F0", Slot = "4")]
		private Entity ILNAGIGJEMB([In] Entity CABLCDOIFFL)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class EBOJEBHEDMI
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct ANEDFNJENPO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator ICLGONBNBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<Entity> CCJHPAIGAIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<T> MBAODKPBMNE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct PBIPIGIHLGB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator ICLGONBNBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeList<Entity> CCJHPAIGAIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> MBAODKPBMNE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct FAOAGOIIJPI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator ICLGONBNBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArrayAsync<Entity> CCJHPAIGAIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArrayAsync<T> MBAODKPBMNE;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class KPCGGEBFBNH
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class OKCIJCPPOEM
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct DOIFFAEJCFL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator ICLGONBNBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> MBAODKPBMNE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct DMMMMAHDDKB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator ICLGONBNBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> MBAODKPBMNE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct MMNGJGNOHNB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator ICLGONBNBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeArrayAsync<T> MBAODKPBMNE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct LNLOMOLDLNH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator ICLGONBNBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NativeListAsync<T> MBAODKPBMNE;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class LPCMMMHADCI
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class LFFEEGHPCMK
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2ED00D0", Offset = "0x2ECECD0", VA = "0x182ED00D0")]
	public static NativeList<Entity> FACDFAOBAFP<T>(this NativeArray<Entity> DFMPJHEOPDM, EntityManager DPCAAACILIP, Allocator ICLGONBNBJO = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class BOJMBPEMGAD
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class EIHNLDMAMNH
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public readonly struct PBBIDHBICGC<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NativeArray<TSrc> BFDOCKABCPN;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xBACEF0", Offset = "0xBABAF0", VA = "0x180BACEF0")]
		public PBBIDHBICGC(NativeArray<TSrc> BFDOCKABCPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0")]
		public PPHONEBPCFJ<TSrc, TValue> ENEKDMMAOIL<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(PPHONEBPCFJ<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct PPHONEBPCFJ<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> BFDOCKABCPN;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xBACEF0", Offset = "0xBABAF0", VA = "0x180BACEF0")]
		public PPHONEBPCFJ(NativeArray<TSrc> BFDOCKABCPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0")]
		public MEDEOIFIOBO<TSrc, TValue, TSelector> DPHPDJAKHIM<TSelector>() where TSelector : struct, BLABPLHNKMK<TSrc, TValue>
		{
			return default(MEDEOIFIOBO<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct MEDEOIFIOBO<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, BLABPLHNKMK<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> BFDOCKABCPN;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xBACEF0", Offset = "0xBABAF0", VA = "0x180BACEF0")]
		public MEDEOIFIOBO(NativeArray<TSrc> BFDOCKABCPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x458F100", Offset = "0x458DD00", VA = "0x18458F100")]
		public OIICMLMBAOL<TSrc, TValue, TSelector> FLPEFMPCOBC()
		{
			return default(OIICMLMBAOL<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct MFBJJFJPAMB<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, BLABPLHNKMK<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> BFDOCKABCPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TSelector ANIODLFLJCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int MFJLAMOCOBC;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TValue FFEGLPIJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x4594020", Offset = "0x4592C20", VA = "0x184594020")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int NAJFJJKNBLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x917870", Offset = "0x916470", VA = "0x180917870")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int LDFIBCLBPPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2161EC0", Offset = "0x2160AC0", VA = "0x182161EC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4594200", Offset = "0x4592E00", VA = "0x184594200")]
		public MFBJJFJPAMB(NativeArray<TSrc> BFDOCKABCPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x45940F0", Offset = "0x4592CF0", VA = "0x1845940F0")]
		public bool GLLFIIAPDOL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4594100", Offset = "0x4592D00", VA = "0x184594100")]
		private TSrc KDPGOGJKFPF(int EKJHOCEPHIA)
		{
			return (TSrc)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4594060", Offset = "0x4592C60", VA = "0x184594060")]
		private TValue GACPLFLHDDF()
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct OIICMLMBAOL<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, BLABPLHNKMK<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private MFBJJFJPAMB<TSrc, TValue, TSelector> LLKKIBMDGDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TValue CFPKIHEHMHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int HAOCJMNINJC;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public FEBLOFFJPHN CABKHFMEFDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x47A98D0", Offset = "0x47A84D0", VA = "0x1847A98D0")]
			get
			{
				return default(FEBLOFFJPHN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue JLCDNGAOOBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x887AB0", Offset = "0x8866B0", VA = "0x180887AB0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, FEBLOFFJPHN range) FFEGLPIJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x47A9910", Offset = "0x47A8510", VA = "0x1847A9910")]
			get
			{
				return default((TValue, FEBLOFFJPHN));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x47A9B60", Offset = "0x47A8760", VA = "0x1847A9B60")]
		public OIICMLMBAOL(NativeArray<TSrc> BFDOCKABCPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3A893A0", Offset = "0x3A87FA0", VA = "0x183A893A0")]
		public OIICMLMBAOL<TSrc, TValue, TSelector> NEGBLLIJCNA()
		{
			return default(OIICMLMBAOL<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x47A99E0", Offset = "0x47A85E0", VA = "0x1847A99E0")]
		public bool GLLFIIAPDOL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2C60210", Offset = "0x2C5EE10", VA = "0x182C60210")]
	public static PBBIDHBICGC<T> OFLFNDKKEML<T>(this NativeList<T> APGPCFDNGCA) where T : struct
	{
		return default(PBBIDHBICGC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xBACEE0", Offset = "0xBABAE0", VA = "0x180BACEE0")]
	public static PBBIDHBICGC<T> OFLFNDKKEML<T>(this NativeArray<T> BFDOCKABCPN) where T : struct
	{
		return default(PBBIDHBICGC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class PCCHFGCOGAA
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct MAIJNAIMLEE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly NativeArray<T>.ReadOnly BFDOCKABCPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int HAOCJMNINJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int PKLPDEEDBHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T CFPKIHEHMHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private T DBCNDMCKNCB;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public FEBLOFFJPHN CABKHFMEFDF
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x45820D0", Offset = "0x4580CD0", VA = "0x1845820D0")]
			get
			{
				return default(FEBLOFFJPHN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T JLCDNGAOOBP
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x3A63E20", Offset = "0x3A62A20", VA = "0x183A63E20")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, FEBLOFFJPHN) FFEGLPIJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x4582180", Offset = "0x4580D80", VA = "0x184582180")]
			get
			{
				return default((T, FEBLOFFJPHN));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4582640", Offset = "0x4581240", VA = "0x184582640")]
		public MAIJNAIMLEE(NativeArray<T> BFDOCKABCPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4582600", Offset = "0x4581200", VA = "0x184582600")]
		public MAIJNAIMLEE<T> NEGBLLIJCNA()
		{
			return default(MAIJNAIMLEE<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4582250", Offset = "0x4580E50", VA = "0x184582250")]
		public bool GLLFIIAPDOL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2C92930", Offset = "0x2C91530", VA = "0x182C92930")]
		public PHEEHADMNJG<T, TComparer> GHOJFILBPLF<TComparer>([Optional] TComparer OAEJPGHELLE) where TComparer : struct, IEqualityComparer<T>
		{
			return default(PHEEHADMNJG<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct PHEEHADMNJG<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly NativeArray<T>.ReadOnly BFDOCKABCPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int HAOCJMNINJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int PKLPDEEDBHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private T CFPKIHEHMHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private T DBCNDMCKNCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TComparer OAEJPGHELLE;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public FEBLOFFJPHN CABKHFMEFDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x45820D0", Offset = "0x4580CD0", VA = "0x1845820D0")]
			get
			{
				return default(FEBLOFFJPHN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T JLCDNGAOOBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x3A63E20", Offset = "0x3A62A20", VA = "0x183A63E20")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4889870", Offset = "0x4888470", VA = "0x184889870")]
		public PHEEHADMNJG(NativeArray<T>.ReadOnly BFDOCKABCPN, TComparer OAEJPGHELLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4889690", Offset = "0x4888290", VA = "0x184889690")]
		public bool GLLFIIAPDOL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2FD14F0", Offset = "0x2FD00F0", VA = "0x182FD14F0")]
	public static MAIJNAIMLEE<T> FLPEFMPCOBC<T>(this NativeArray<T> BFDOCKABCPN) where T : struct
	{
		return default(MAIJNAIMLEE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface DJEEMLIBBAN
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class HMBGOACLOPL
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct AMIMMCIOCKF<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class BGNNKINLNIA : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AMIMMCIOCKF<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xDF95E0", Offset = "0xDF81E0", VA = "0x180DF95E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E6E2F0", Offset = "0x3E6CEF0", VA = "0x183E6E2F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x891CE0", Offset = "0x8908E0", VA = "0x180891CE0")]
		[DebuggerHidden]
		public BGNNKINLNIA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x50A98B0", Offset = "0x50A84B0", VA = "0x1850A98B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x50A9A80", Offset = "0x50A8680", VA = "0x1850A9A80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly Action<Protobuf> CHMJPGBNKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly MemoryStream DBNLHNDOGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly CodedInputStream GKPAELPAHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Protobuf APFPONLDBCK;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int LDFIBCLBPPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8E9FA0", Offset = "0x8E8BA0", VA = "0x1808E9FA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3F1D480", Offset = "0x3F1C080", VA = "0x183F1D480", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3F1D4C0", Offset = "0x3F1C0C0", VA = "0x183F1D4C0", Slot = "4")]
	[IteratorStateMachine(typeof(AMIMMCIOCKF<>.BGNNKINLNIA))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3F1D5C0", Offset = "0x3F1C1C0", VA = "0x183F1D5C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct LMPOPNBFJAL<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly byte[] OFBCPBHPLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Protobuf APFPONLDBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream DBNLHNDOGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedOutputStream PMBNGAEIGHM;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x43C2850", Offset = "0x43C1450", VA = "0x1843C2850", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct JIIGPMGHJDB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly MemoryStream DBNLHNDOGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly CodedInputStream GKPAELPAHBI;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B0F0", Offset = "0x6D79CF0", VA = "0x186D7B0F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct JEGDKIDEDNM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly byte[] OFBCPBHPLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly MemoryStream DBNLHNDOGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CodedOutputStream PMBNGAEIGHM;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6D7AFD0", Offset = "0x6D79BD0", VA = "0x186D7AFD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class KFMLBEHDDJJ
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class HHDMHJJFNCM
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Flags]
public enum FGGIFEKPDFM
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
internal static class PKHPNGEIAOC
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class IGMOIHGFJHJ
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public IGMOIHGFJHJ()
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
