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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
		[Cpp2IlInjected.Address(RVA = "0x833BC10", Offset = "0x833AC10", VA = "0x18833BC10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA8B7C0", Offset = "0xA8A7C0", VA = "0x180A8B7C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8B800", Offset = "0xA8A800", VA = "0x180A8B800")]
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
		[Cpp2IlInjected.Address(RVA = "0x833B1C0", Offset = "0x833A1C0", VA = "0x18833B1C0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MMICFEOIFBA : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	BIFBIJAJCPB DJHDGLHCFMB
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
public interface LPBBDOIPLNF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OMDOPPJFEEE(Entity KELHIEHPDJD, object GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DDGPHGLOEIH(Entity KELHIEHPDJD, object GFDDDAIMFOH, [Out] bool GFPBILJFOLE);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CDGGPEIJCBM(Entity KELHIEHPDJD);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class AJJDMBEIMIN<TComponentData, TValue> : AIPMBCGKPNF<TValue>, IDisposable where TComponentData : struct, MMICFEOIFBA
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class GGIHMNOOJPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<(object token, TValue value)> KKAPDLIJLLM;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int JHCCKPLGFOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x4474990", Offset = "0x4473990", VA = "0x184474990")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4EA9D10", Offset = "0x4EA8D10", VA = "0x184EA9D10")]
		public bool OIIEBJEODDC([Out] TValue IOALKPFEKEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4EA9B00", Offset = "0x4EA8B00", VA = "0x184EA9B00")]
		public void DOPEKGIEJEC(object GFDDDAIMFOH, TValue IOALKPFEKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4EA9C90", Offset = "0x4EA8C90", VA = "0x184EA9C90")]
		public bool LKIPLGLLFFP(object GFDDDAIMFOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4EA9BB0", Offset = "0x4EA8BB0", VA = "0x184EA9BB0")]
		public int EEGEMFPJFIH(object GFDDDAIMFOH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4EA9DE0", Offset = "0x4EA8DE0", VA = "0x184EA9DE0")]
		public GGIHMNOOJPD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stack<GGIHMNOOJPD> HICAJPINJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private HGLMLEOGACH<BIFBIJAJCPB, GGIHMNOOJPD> MONHMGJAGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EntityManager FMBMFCMHGGJ;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x51A36E0", Offset = "0x51A26E0", VA = "0x1851A36E0")]
	public AJJDMBEIMIN(EntityManager FMBMFCMHGGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x51A35C0", Offset = "0x51A25C0", VA = "0x1851A35C0", Slot = "4")]
	public void OMDOPPJFEEE(Entity KELHIEHPDJD, object GFDDDAIMFOH, TValue IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x51A31A0", Offset = "0x51A21A0", VA = "0x1851A31A0", Slot = "5")]
	public bool DDGPHGLOEIH(Entity KELHIEHPDJD, object GFDDDAIMFOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x51A34E0", Offset = "0x51A24E0", VA = "0x1851A34E0", Slot = "6")]
	public bool OIIEBJEODDC(Entity KELHIEHPDJD, [Out] TValue IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x51A3330", Offset = "0x51A2330", VA = "0x1851A3330", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x51A3450", Offset = "0x51A2450", VA = "0x1851A3450")]
	private void MEAOFFPCILI(GGIHMNOOJPD OEGLBLJJNIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x51A3000", Offset = "0x51A2000", VA = "0x1851A3000")]
	private bool ABGKHACCKKF(Entity KELHIEHPDJD, [Out] BIFBIJAJCPB EBEJPHPLJAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x51A30C0", Offset = "0x51A20C0", VA = "0x1851A30C0")]
	private void AOGCPOGOAIN(Entity KELHIEHPDJD, BIFBIJAJCPB EBEJPHPLJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x51A3430", Offset = "0x51A2430", VA = "0x1851A3430")]
	private bool IDHAAANNMMO(BIFBIJAJCPB EBEJPHPLJAD, [Out] GGIHMNOOJPD OEGLBLJJNIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x51A3350", Offset = "0x51A2350", VA = "0x1851A3350")]
	private GGIHMNOOJPD HKKMPMLJNKO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface AIPMBCGKPNF<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OMDOPPJFEEE(Entity KELHIEHPDJD, object GFDDDAIMFOH, TValue IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DDGPHGLOEIH(Entity KELHIEHPDJD, object GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OIIEBJEODDC(Entity KELHIEHPDJD, [Out] TValue IOALKPFEKEK);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct BIFBIJAJCPB : BDFEHDIGKLJ, IEquatable<BIFBIJAJCPB>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly BIFBIJAJCPB MELDNPHKGNM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int MKOCHPIICKK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xD8A410", Offset = "0xD89410", VA = "0x180D8A410", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x14E7060", Offset = "0x14E6060", VA = "0x1814E7060", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int IPPLPEJMEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x314D220", Offset = "0x314C220", VA = "0x18314D220", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6EC13E0", Offset = "0x6EC03E0", VA = "0x186EC13E0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x833AA80", Offset = "0x8339A80", VA = "0x18833AA80", Slot = "8")]
	public bool Equals(BIFBIJAJCPB EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x833AAD0", Offset = "0x8339AD0", VA = "0x18833AAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GKMPLJNALDG<THasTokensTag> : LPBBDOIPLNF, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly ONIHMLNNEEF EFJNGOKNPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Dictionary<Entity, BIFBIJAJCPB> AOMPGNOCHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Stack<HashSet<object>> HICAJPINJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private HGLMLEOGACH<BIFBIJAJCPB, HashSet<object>> MONHMGJAGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EntityManager FMBMFCMHGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EntityCommandBufferSystem JBGMPAMKJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool MCHGOAKENIE;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4ED06A0", Offset = "0x4ECF6A0", VA = "0x184ED06A0")]
	public GKMPLJNALDG(EntityManager FMBMFCMHGGJ, EntityCommandBufferSystem JBGMPAMKJCA, ONIHMLNNEEF CAEAKIPFACE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4ED0380", Offset = "0x4ECF380", VA = "0x184ED0380", Slot = "4")]
	public bool OMDOPPJFEEE(Entity KELHIEHPDJD, object GFDDDAIMFOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4ECED20", Offset = "0x4ECDD20", VA = "0x184ECED20", Slot = "5")]
	public bool DDGPHGLOEIH(Entity KELHIEHPDJD, object GFDDDAIMFOH, [Out] bool GFPBILJFOLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4ECE6E0", Offset = "0x4ECD6E0", VA = "0x184ECE6E0", Slot = "6")]
	public bool CDGGPEIJCBM(Entity KELHIEHPDJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4ECE810", Offset = "0x4ECD810", VA = "0x184ECE810", Slot = "8")]
	public bool CDGGPEIJCBM(BIFBIJAJCPB EBEJPHPLJAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4ECF3E0", Offset = "0x4ECE3E0", VA = "0x184ECF3E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4ECFF80", Offset = "0x4ECEF80", VA = "0x184ECFF80")]
	private void MEAOFFPCILI(HashSet<object> OEGLBLJJNIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4ECDEB0", Offset = "0x4ECCEB0", VA = "0x184ECDEB0")]
	private bool ABGKHACCKKF(Entity KELHIEHPDJD, [Out] BIFBIJAJCPB EBEJPHPLJAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4ECEA20", Offset = "0x4ECDA20", VA = "0x184ECEA20")]
	private bool CJJJJEEPKAP(Entity KELHIEHPDJD, [Out] BIFBIJAJCPB EBEJPHPLJAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4ECFDA0", Offset = "0x4ECEDA0", VA = "0x184ECFDA0")]
	private void KKDJFMJPGGN(Entity KELHIEHPDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4ECE4E0", Offset = "0x4ECD4E0", VA = "0x184ECE4E0")]
	private void BKEKCNKJIFL(Entity KELHIEHPDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4ECF820", Offset = "0x4ECE820", VA = "0x184ECF820")]
	private void IFNKHBNFHBD(Entity KELHIEHPDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4ECE200", Offset = "0x4ECD200", VA = "0x184ECE200")]
	private void AOGCPOGOAIN(Entity KELHIEHPDJD, BIFBIJAJCPB EBEJPHPLJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4ECF9E0", Offset = "0x4ECE9E0", VA = "0x184ECF9E0")]
	private bool JHBGCFKFHFL(BIFBIJAJCPB EBEJPHPLJAD, [Out] HashSet<object> OEGLBLJJNIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4ECF680", Offset = "0x4ECE680", VA = "0x184ECF680")]
	private HashSet<object> HKKMPMLJNKO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class EBBDJGILBPI
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct PALGILMMKJP : IOGNIJIEBPL<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x833BD90", Offset = "0x833AD90", VA = "0x18833BD90")]
	public float IBDNFGELPGG([In] float3 IOALKPFEKEK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x833BD90", Offset = "0x833AD90", VA = "0x18833BD90", Slot = "4")]
	private float LDPMBEKNOKB([In] float3 IOALKPFEKEK)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct KAKNMLKNKOG : IOGNIJIEBPL<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x833B560", Offset = "0x833A560", VA = "0x18833B560")]
	public float IBDNFGELPGG([In] float3 IOALKPFEKEK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x833B560", Offset = "0x833A560", VA = "0x18833B560", Slot = "4")]
	private float LDPMBEKNOKB([In] float3 IOALKPFEKEK)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct JMOHEHFAGIN : IOGNIJIEBPL<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0xFB3780", Offset = "0xFB2780", VA = "0x180FB3780")]
	public float IBDNFGELPGG([In] float3 IOALKPFEKEK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xFB3780", Offset = "0xFB2780", VA = "0x180FB3780", Slot = "4")]
	private float LDPMBEKNOKB([In] float3 IOALKPFEKEK)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct PHIHDIOONBN : IOGNIJIEBPL<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x13E2180", Offset = "0x13E1180", VA = "0x1813E2180")]
	public int IBDNFGELPGG([In] int3 IOALKPFEKEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x13E2180", Offset = "0x13E1180", VA = "0x1813E2180", Slot = "4")]
	private int FHJEFIOHEFF([In] int3 IOALKPFEKEK)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct PIAFMOHFKJM : IOGNIJIEBPL<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1364A90", Offset = "0x1363A90", VA = "0x181364A90")]
	public int IBDNFGELPGG([In] int3 IOALKPFEKEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1364A90", Offset = "0x1363A90", VA = "0x181364A90", Slot = "4")]
	private int FHJEFIOHEFF([In] int3 IOALKPFEKEK)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct FLJMKOJCBHA : IOGNIJIEBPL<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xF7B300", Offset = "0xF7A300", VA = "0x180F7B300")]
	public int IBDNFGELPGG([In] int3 IOALKPFEKEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xF7B300", Offset = "0xF7A300", VA = "0x180F7B300", Slot = "4")]
	private int FHJEFIOHEFF([In] int3 IOALKPFEKEK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FBLHNDMNOCP : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2317390", Offset = "0x2316390", VA = "0x182317390")]
	public FBLHNDMNOCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class CJAAJCOIOJB : SystemBase, LDFMCLHAHPB
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x833ABD0", Offset = "0x8339BD0", VA = "0x18833ABD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3A3F030", Offset = "0x3A3E030", VA = "0x183A3F030")]
	public void IFAECKKEFIB<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3A3F030", Offset = "0x3A3E030", VA = "0x183A3F030")]
	public void NJPNPOKGBGJ<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x833AE10", Offset = "0x8339E10", VA = "0x18833AE10")]
	public JobHandle PKIGMOHFDGC(ReadOnlySpan<int> BJEOIOPJNDP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3A3F3F0", Offset = "0x3A3E3F0", VA = "0x183A3F3F0")]
	public JobHandle MOLPEAMMDPA<T>() where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x833AD30", Offset = "0x8339D30", VA = "0x18833AD30")]
	public JobHandle MOLPEAMMDPA(ReadOnlySpan<int> BJEOIOPJNDP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3A3F130", Offset = "0x3A3E130", VA = "0x183A3F130")]
	public void PDNPDMJPFNH<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3A3F530", Offset = "0x3A3E530", VA = "0x183A3F530")]
	public JobHandle PDNPDMJPFNH<T>(JobHandle EBEJPHPLJAD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x833AD80", Offset = "0x8339D80", VA = "0x18833AD80")]
	public JobHandle PDNPDMJPFNH(ReadOnlySpan<int> BJEOIOPJNDP, JobHandle EBEJPHPLJAD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3A3F130", Offset = "0x3A3E130", VA = "0x183A3F130")]
	public void KFABIBFNDNI<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3A3F1B0", Offset = "0x3A3E1B0", VA = "0x183A3F1B0")]
	public JobHandle KFABIBFNDNI<T>(JobHandle EBEJPHPLJAD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x833ACC0", Offset = "0x8339CC0", VA = "0x18833ACC0")]
	public JobHandle KFABIBFNDNI(Span<int> BJEOIOPJNDP, JobHandle EBEJPHPLJAD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3A3F080", Offset = "0x3A3E080", VA = "0x183A3F080")]
	public ComponentDataFromEntity IMNGENCGHEH<T>(bool GCOHKCLGAHL = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x833AC00", Offset = "0x8339C00", VA = "0x18833AC00")]
	public ComponentDataFromEntity IMNGENCGHEH(int NKBEHDNFLEC, bool GCOHKCLGAHL = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3A3F490", Offset = "0x3A3E490", VA = "0x183A3F490")]
	public SharedComponentIndexFromEntity<T> PDJIFDKNLPG<T>() where T : ISharedComponentData
	{
		return default(SharedComponentIndexFromEntity<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x833AE60", Offset = "0x8339E60", VA = "0x18833AE60")]
	[BurstCompatible]
	public ComponentTypeHandle POHNCDFCCJK(ComponentType FPENJCCAGDA)
	{
		return default(ComponentTypeHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x833ADF0", Offset = "0x8339DF0", VA = "0x18833ADF0")]
	public EntityExistenceLookupByEntity PKBMPCAJNAB()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x833AEC0", Offset = "0x8339EC0", VA = "0x18833AEC0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3A3EF10", Offset = "0x3A3DF10", VA = "0x183A3EF10")]
	public bool EJOCDAKINCD<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "7")]
	protected sealed override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2317390", Offset = "0x2316390", VA = "0x182317390")]
	protected CJAAJCOIOJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class BPPPMDMENOO : CJAAJCOIOJB
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x833AB20", Offset = "0x8339B20", VA = "0x18833AB20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2317390", Offset = "0x2316390", VA = "0x182317390")]
	protected BPPPMDMENOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class KLPLBHPHBKF
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class DHDIEDFIAOP : EntityCommandBufferSystem, LDFMCLHAHPB
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private ONIHMLNNEEF APKHGLJHJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xEA3620", Offset = "0xEA2620", VA = "0x180EA3620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x833B190", Offset = "0x833A190", VA = "0x18833B190")]
	public DHDIEDFIAOP(ONIHMLNNEEF EFJNGOKNPIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface IOGNIJIEBPL<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo IBDNFGELPGG([In] TFrom IOALKPFEKEK);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface KBJMLIIMBDN<T>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BIAGGPFIEIK(T IOALKPFEKEK);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct NAKGPNPHJEM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> PCOPFIMLFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer HKMMHCIGAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public ComponentTypes OJFGLMILFBI;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x833BB20", Offset = "0x833AB20", VA = "0x18833BB20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct LACGAFDLMBD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> PCOPFIMLFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer HKMMHCIGAGL;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x833B810", Offset = "0x833A810", VA = "0x18833B810", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct CFCGCOAEOIN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> PCOPFIMLFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer HKMMHCIGAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public ComponentType FPENJCCAGDA;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x833AB50", Offset = "0x8339B50", VA = "0x18833AB50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[BurstCompile]
internal struct LMHALFFEKKG<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> PCOPFIMLFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> INCJDDLACNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer HKMMHCIGAGL;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x54B83D0", Offset = "0x54B73D0", VA = "0x1854B83D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct FMGPAKMADIP<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> PCOPFIMLFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<T> NCIPNLHDHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer HKMMHCIGAGL;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal struct DDAKMHJMLBI<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<Entity> PCOPFIMLFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public T IOALKPFEKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EntityCommandBuffer HKMMHCIGAGL;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct CNBEMKLLIBL<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, IOGNIJIEBPL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<TFrom> IEFIIOIGINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<TTo> CNHBCFCMAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public TMap DMHPHEGJKMB;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct OOINFCDCKJG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity PNAKLBDIGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> IEFIIOIGINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeArray<byte> CNHBCFCMAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int OFHAGDEDBOL;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x833BC90", Offset = "0x833AC90", VA = "0x18833BC90", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct BIBFADHGCDH<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> LCGNCLODLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<Entity> IEFIIOIGINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<T> GMNALENLDAG;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct GDFBCMLHBPP<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, IOGNIJIEBPL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<TFrom> MPLIJPAABAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[WriteOnly]
	public NativeList<TTo> CNHBCFCMAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public TMap DMHPHEGJKMB;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct CKANFKBFHOL<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> IBGKCPAKBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> PCOLJIJKKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> JCDLGEGKBPJ;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct ELALDMNAICP<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public ComponentDataFromEntity<T> IBGKCPAKBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<Entity> PCOLJIJKKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<bool> JCDLGEGKBPJ;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x490BF10", Offset = "0x490AF10", VA = "0x18490BF10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct GBBNEDEKBPJ<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<T> IEFIIOIGINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<T> GMNALENLDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<T> DKHDCGMKNOM;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4E4A660", Offset = "0x4E49660", VA = "0x184E4A660", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct JEIPDDAIHCG<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : IOGNIJIEBPL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<TFrom> IEFIIOIGINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public NativeList<TFrom> GMNALENLDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeParallelHashSet<TTo> DKHDCGMKNOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TMap DMHPHEGJKMB;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct GFPBBJGIEGL<T, TPredicate> : IJob where T : struct where TPredicate : struct, KBJMLIIMBDN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> IEFIIOIGINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<Entity> PKEIFDHLOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<Entity> GAKBJLAPKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate DMHPHEGJKMB;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct MNKACBNPADO<T, TPredicate> : IJob where T : struct where TPredicate : struct, KBJMLIIMBDN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> IEFIIOIGINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> GMNALENLDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TPredicate DMHPHEGJKMB;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct PDFOICFEBHK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity IBGKCPAKBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> PCOLJIJKKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> ABNOBGMNDHD;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x833BDA0", Offset = "0x833ADA0", VA = "0x18833BDA0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct MMEPCGDMPJD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[ReadOnly]
	public ComponentDataFromEntity IBGKCPAKBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<Entity> PCOLJIJKKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<Entity> ABNOBGMNDHD;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x833BA90", Offset = "0x833AA90", VA = "0x18833BA90", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class NMBFIKBBFMH
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class CJDGNICHKJG
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3A3FEE0", Offset = "0x3A3EEE0", VA = "0x183A3FEE0")]
	public static bool PIJKHAKCFHD<T>(this NativeArray<Entity> PCOLJIJKKBA, EntityManager FMBMFCMHGGJ, Allocator FKPBEKMFPLB = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class JINGDOMCKEM
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class CBKLKMKMHDP<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		public CBKLKMKMHDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class GENCLDNAMKL<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public GENCLDNAMKL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly List<Func<JobHandle, JobHandle>> FNIHNJOOGPO;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x833B490", Offset = "0x833A490", VA = "0x18833B490")]
	public JINGDOMCKEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class PHCBPKGKGCD
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class EOONEKLFKMN
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct MNOCBHJMLHE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct HBKFCNNGLAF<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal MNOCBHJMLHE<TFrom> EBJBKAEFOPM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator FKPBEKMFPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeArray<TFrom> BKFMBMLFOLE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct MLKFHGBJCPJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct NKKMHJAMNGF<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal MLKFHGBJCPJ<TFrom> EBJBKAEFOPM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator FKPBEKMFPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeList<TFrom> BKFMBMLFOLE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct ICHFOFMIMMP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct LMGJODCEDFO<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal ICHFOFMIMMP<TFrom> EBJBKAEFOPM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator FKPBEKMFPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeArrayAsync<TFrom> BKFMBMLFOLE;
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct HNKOJLGEFOE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public struct GLFCBPOLBOD<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			internal HNKOJLGEFOE<TFrom> EBJBKAEFOPM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal Allocator FKPBEKMFPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal NativeListAsync<TFrom> BKFMBMLFOLE;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class MLAEDODENCN
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class FDAFLIGCKBM
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3C30AB0", Offset = "0x3C2FAB0", VA = "0x183C30AB0")]
	public static NativeList<T> FJOKLIMJANA<T>(this NativeArray<T> DHEEPLGNBMC, Allocator FKPBEKMFPLB = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class JLICKBEJAAP
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class CJFDBGEMINN
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3A40450", Offset = "0x3A3F450", VA = "0x183A40450")]
	[KKIFDKNKBGI]
	public static JobHandle BCIIJKNHMOG<T>(this EntityCommandBufferSystem JBGMPAMKJCA, NativeArray<Entity> PCOPFIMLFLG, NativeArray<T> INCJDDLACNP) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3A402F0", Offset = "0x3A3F2F0", VA = "0x183A402F0")]
	[KKIFDKNKBGI]
	public static JobHandle BCIIJKNHMOG<T>(this EntityCommandBufferSystem JBGMPAMKJCA, NativeArrayAsync<Entity> PCOPFIMLFLG, NativeArrayAsync<T> INCJDDLACNP, [Optional] JobHandle FINBEGBKFPM) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3A401D0", Offset = "0x3A3F1D0", VA = "0x183A401D0")]
	[KKIFDKNKBGI]
	public static JobHandle BCIIJKNHMOG<T>(this EntityCommandBufferSystem JBGMPAMKJCA, NativeArray<Entity> PCOPFIMLFLG, [Optional] JobHandle FINBEGBKFPM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x833B020", Offset = "0x833A020", VA = "0x18833B020")]
	[KKIFDKNKBGI]
	public static JobHandle BCIIJKNHMOG(this EntityCommandBufferSystem JBGMPAMKJCA, NativeArray<Entity> PCOPFIMLFLG, ComponentTypes OJFGLMILFBI, [Optional] JobHandle FINBEGBKFPM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x833AED0", Offset = "0x8339ED0", VA = "0x18833AED0")]
	[KKIFDKNKBGI]
	public static JobHandle BCIIJKNHMOG(this EntityCommandBufferSystem JBGMPAMKJCA, EntityCommandBuffer HKMMHCIGAGL, NativeArray<Entity> PCOPFIMLFLG, ComponentTypes OJFGLMILFBI, [Optional] JobHandle FINBEGBKFPM)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class NDMKOGHJCNL
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class KNDLEBMHAPF
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x833B680", Offset = "0x833A680", VA = "0x18833B680")]
	[KKIFDKNKBGI]
	public static JobHandle KLBDMAEFEGD(this EntityCommandBufferSystem JBGMPAMKJCA, NativeList<Entity> PCOPFIMLFLG, [Optional] JobHandle FINBEGBKFPM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x833B580", Offset = "0x833A580", VA = "0x18833B580")]
	[KKIFDKNKBGI]
	public static JobHandle KLBDMAEFEGD(this EntityCommandBufferSystem JBGMPAMKJCA, NativeArrayAsync<Entity> PCOPFIMLFLG)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class IHABILFKCKN
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3CC08B0", Offset = "0x3CBF8B0", VA = "0x183CC08B0")]
	public static void GIDFNGDFKLG<T>(this EntityCommandBufferSystem JBGMPAMKJCA, EntityQuery BMJBBIGFJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3CC0C70", Offset = "0x3CBFC70", VA = "0x183CC0C70")]
	[KKIFDKNKBGI]
	public static JobHandle NMFBGJALJNC<T>(this EntityCommandBufferSystem JBGMPAMKJCA, NativeArrayAsync<Entity> PCOPFIMLFLG, [Optional] JobHandle FINBEGBKFPM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x833B1E0", Offset = "0x833A1E0", VA = "0x18833B1E0")]
	[KKIFDKNKBGI]
	public static JobHandle NMFBGJALJNC(this EntityCommandBufferSystem JBGMPAMKJCA, NativeArrayAsync<Entity> PCOPFIMLFLG, ComponentType FPENJCCAGDA, [Optional] JobHandle FINBEGBKFPM)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class FGDFBIHFEOD
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3C34B90", Offset = "0x3C33B90", VA = "0x183C34B90")]
	[KKIFDKNKBGI]
	public static JobHandle IMEJENDEALD<T>(this EntityCommandBufferSystem JBGMPAMKJCA, NativeArray<Entity> PCOPFIMLFLG, NativeArray<T> INCJDDLACNP, JobHandle FINBEGBKFPM) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class KFBDALHHAMF
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class DLFAPHNAHHC
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class LOCJLNJGABI
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3D553D0", Offset = "0x3D543D0", VA = "0x183D553D0")]
	public static NativeArray<T> JGCAONJINDB<T>(this NativeList<Entity> DHEEPLGNBMC, EntityManager FMBMFCMHGGJ, Allocator FKPBEKMFPLB = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3D55480", Offset = "0x3D54480", VA = "0x183D55480")]
	public static NativeArray<T> JGCAONJINDB<T>(this NativeArray<Entity> DHEEPLGNBMC, EntityManager FMBMFCMHGGJ, Allocator FKPBEKMFPLB = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x833B8B0", Offset = "0x833A8B0", VA = "0x18833B8B0")]
	public static NativeArray<Entity> DOAJKBOJAJA(this NativeArray<Entity> DHEEPLGNBMC, EntityManager FMBMFCMHGGJ, ComponentType FPENJCCAGDA, Allocator FKPBEKMFPLB = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3D55CE0", Offset = "0x3D54CE0", VA = "0x183D55CE0")]
	public static NativeArray<T> MJJIDKLFCBP<T>(this NativeArray<Entity> DHEEPLGNBMC, EntityManager FMBMFCMHGGJ, Allocator FKPBEKMFPLB = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class APNDCPDLGID
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct ALBJIDNCODE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct BIPLEFBCONB<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public ALBJIDNCODE<TFrom> BKFMBMLFOLE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator FKPBEKMFPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArray<TFrom> IEFIIOIGINA;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct NDBGMOLFEME<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct CFJBBFFEAPD<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public NDBGMOLFEME<TFrom> BKFMBMLFOLE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator FKPBEKMFPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeArrayAsync<TFrom> IEFIIOIGINA;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct DNMFPHNKLFH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public struct NMCPNEGHNMP<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public DNMFPHNKLFH<TFrom> BKFMBMLFOLE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator FKPBEKMFPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeListAsync<TFrom> IEFIIOIGINA;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class AOOIPHJCBOJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class CCCPJMACADD
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct KKOONNMODEC : IOGNIJIEBPL<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> ONINGPPENFL;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x833B570", Offset = "0x833A570", VA = "0x18833B570")]
		[BurstCompatible]
		public Entity IBDNFGELPGG([In] Entity IOALKPFEKEK)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x833B570", Offset = "0x833A570", VA = "0x18833B570", Slot = "4")]
		private Entity BBBIGJEECEH([In] Entity IOALKPFEKEK)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class KPMCGDIBCAC
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct BJHBPOALFDD<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x643C400", Offset = "0x643B400", VA = "0x18643C400", Slot = "4")]
		public int Compare((TKey, TValue) OEFDFBLCHHF, (TKey, TValue) GDBEEAKMPMB)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3D4AF70", Offset = "0x3D49F70", VA = "0x183D4AF70")]
	public static void LEPCLHACLKG<TKey, TValue>(NativeList<TKey> HGELDBNDAND, NativeList<TValue> NCIPNLHDHEI) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3D4B1E0", Offset = "0x3D4A1E0", VA = "0x183D4B1E0")]
	public static void LEPCLHACLKG<TKey, TValue>(NativeArray<TKey> HGELDBNDAND, NativeArray<TValue> NCIPNLHDHEI) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3D4AD60", Offset = "0x3D49D60", VA = "0x183D4AD60")]
	public static void LEPCLHACLKG<TKey, TValue, U>(NativeArray<TKey> HGELDBNDAND, NativeArray<TValue> NCIPNLHDHEI, U JHNHCPAGBKG) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class OEPAEGJDCFO
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct CIGKNMNFPAI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator FKPBEKMFPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<Entity> PKEIFDHLOLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> IEFIIOIGINA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct GLCKBANIAOD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator FKPBEKMFPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeList<Entity> PKEIFDHLOLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArray<T> IEFIIOIGINA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct ALEKNCNMBNF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator FKPBEKMFPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArrayAsync<Entity> PKEIFDHLOLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArrayAsync<T> IEFIIOIGINA;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class FEBFNDEPLNN
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class AGJBFAHECHI
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct MCHJEJFGNKO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator FKPBEKMFPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArray<T> IEFIIOIGINA;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct EPPBGDDCCMB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator FKPBEKMFPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeList<T> IEFIIOIGINA;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct NPFCLIMLNLJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator FKPBEKMFPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<T> IEFIIOIGINA;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct HDOHGDJLENE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Allocator FKPBEKMFPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NativeListAsync<T> IEFIIOIGINA;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class JPCIODLIDON
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class JOAFKGGAKBB
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3CF35D0", Offset = "0x3CF25D0", VA = "0x183CF35D0")]
	public static NativeList<Entity> IBLBHLKHBEE<T>(this NativeList<Entity> PCOLJIJKKBA, EntityManager FMBMFCMHGGJ, Allocator FKPBEKMFPLB = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3CF2E50", Offset = "0x3CF1E50", VA = "0x183CF2E50")]
	public static NativeList<Entity> IBLBHLKHBEE<T>(this NativeArray<Entity> PCOLJIJKKBA, EntityManager FMBMFCMHGGJ, Allocator FKPBEKMFPLB = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class LHBBLNKNIBD
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3D52570", Offset = "0x3D51570", VA = "0x183D52570")]
	public static NativeList<Entity> IFCGJABBKHP<T>(this NativeArray<Entity> PCOLJIJKKBA, EntityManager FMBMFCMHGGJ, Allocator FKPBEKMFPLB = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class GIKNFDDJOAH
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public readonly struct EEMPDFMHDGC<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> MFIJBPNIELL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public readonly struct OKCDHBNJOKE<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> MFIJBPNIELL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public readonly struct KMDIAOFIEHG<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, IOGNIJIEBPL<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly NativeArray<TSrc> MFIJBPNIELL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct JABCCGJCOOA<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, IOGNIJIEBPL<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly NativeArray<TSrc> MFIJBPNIELL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TSelector JMNAPAAMBOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int HLGKMAPOEBE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct IDFJACCBMNO<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, IOGNIJIEBPL<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private JABCCGJCOOA<TSrc, TValue, TSelector> CGEANDCJOJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TValue DOPKBGPLANK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int OBJODNIPNPB;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class CBLBLDFJFCI
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct EHJBMBANAGC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<T> MFIJBPNIELL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int OBJODNIPNPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int DJECEPAILLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private T DOPKBGPLANK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T BJBEJLJGPHM;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public LKKNDHJDELB DPFKHJECNPL
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x449B9E0", Offset = "0x449A9E0", VA = "0x18449B9E0")]
			get
			{
				return default(LKKNDHJDELB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public T EPJLKIKAOBE
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA6A700", Offset = "0xA69700", VA = "0x180A6A700")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public (T, LKKNDHJDELB) AJOLFNCECJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x449B890", Offset = "0x449A890", VA = "0x18449B890")]
			get
			{
				return default((T, LKKNDHJDELB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x49025F0", Offset = "0x49015F0", VA = "0x1849025F0")]
		public EHJBMBANAGC(NativeArray<T> MFIJBPNIELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2C45F00", Offset = "0x2C44F00", VA = "0x182C45F00")]
		public EHJBMBANAGC<T> GHDHEBFDHCI()
		{
			return default(EHJBMBANAGC<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4902500", Offset = "0x4901500", VA = "0x184902500")]
		public bool MJEALNFGLBL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3D71660", Offset = "0x3D70660", VA = "0x183D71660")]
		public DMNINMMBCND<T, TComparer> NIFKJBEAIOD<TComparer>([Optional] TComparer JHNHCPAGBKG) where TComparer : struct, IEqualityComparer<T>
		{
			return default(DMNINMMBCND<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct DMNINMMBCND<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly NativeArray<T> MFIJBPNIELL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int OBJODNIPNPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int DJECEPAILLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private T DOPKBGPLANK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private T BJBEJLJGPHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TComparer JHNHCPAGBKG;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public LKKNDHJDELB DPFKHJECNPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x449B9E0", Offset = "0x449A9E0", VA = "0x18449B9E0")]
			get
			{
				return default(LKKNDHJDELB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T EPJLKIKAOBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA6A700", Offset = "0xA69700", VA = "0x180A6A700")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public (T value, LKKNDHJDELB range) AJOLFNCECJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x449B890", Offset = "0x449A890", VA = "0x18449B890")]
			get
			{
				return default((T, LKKNDHJDELB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x449BC80", Offset = "0x449AC80", VA = "0x18449BC80")]
		public DMNINMMBCND(NativeArray<T> MFIJBPNIELL, TComparer JHNHCPAGBKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x449B9F0", Offset = "0x449A9F0", VA = "0x18449B9F0")]
		public DMNINMMBCND<T, TComparer> GHDHEBFDHCI()
		{
			return default(DMNINMMBCND<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x449BB70", Offset = "0x449AB70", VA = "0x18449BB70")]
		public bool MJEALNFGLBL()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3A3BE90", Offset = "0x3A3AE90", VA = "0x183A3BE90")]
	public static EHJBMBANAGC<T> HKNOMGBMEDF<T>(this NativeArray<T> MFIJBPNIELL) where T : struct
	{
		return default(EHJBMBANAGC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface OPDDDKHBNOC
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class HLCFGGFHEFD
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct NMKFNHFLBNP<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class MJIDCEOAKIM : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public NMKFNHFLBNP<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xD36D60", Offset = "0xD35D60", VA = "0x180D36D60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED8080", Offset = "0x4ED7080", VA = "0x184ED8080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA5F480", Offset = "0xA5E480", VA = "0x180A5F480")]
		[DebuggerHidden]
		public MJIDCEOAKIM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x56DC120", Offset = "0x56DB120", VA = "0x1856DC120", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x56DC2D0", Offset = "0x56DB2D0", VA = "0x1856DC2D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly Action<Protobuf> DKFGJGFOMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MemoryStream PMBDKJADIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CodedInputStream LHKPCGIOPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Protobuf JPAJKPMDGBM;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly int BJKDLCPHPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAAD1A0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x579B300", Offset = "0x579A300", VA = "0x18579B300", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x579B340", Offset = "0x579A340", VA = "0x18579B340", Slot = "4")]
	[IteratorStateMachine(typeof(NMKFNHFLBNP<>.MJIDCEOAKIM))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x579B430", Offset = "0x579A430", VA = "0x18579B430", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct PLJCMDCPFDK<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly byte[] MPPMMFHHGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Protobuf JPAJKPMDGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream PMBDKJADIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedOutputStream EEGHEADPAIG;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5A7D3B0", Offset = "0x5A7C3B0", VA = "0x185A7D3B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct JJCKPICBIIK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream PMBDKJADIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedInputStream LHKPCGIOPLA;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x833B520", Offset = "0x833A520", VA = "0x18833B520", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct JHPLOOMNGFC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] MPPMMFHHGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly MemoryStream PMBDKJADIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly CodedOutputStream EEGHEADPAIG;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x833B370", Offset = "0x833A370", VA = "0x18833B370", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class FOBDHLFIGGA
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class BCHEGGOMDCO
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[Flags]
public enum FHIDPOFKAND
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
internal static class HDHNFECPLLE
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class HLGNEFPMHEK
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public HLGNEFPMHEK()
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
