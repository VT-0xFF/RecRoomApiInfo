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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x815ED70", Offset = "0x815D570", VA = "0x18815ED70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA536D0", Offset = "0xA51ED0", VA = "0x180A536D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA53710", Offset = "0xA51F10", VA = "0x180A53710")]
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
		[Cpp2IlInjected.Address(RVA = "0x815E590", Offset = "0x815CD90", VA = "0x18815E590")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface DNJEBEAAODP : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	KAIGLBDFENJ CPFLBKIHGEJ
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
public interface GNGEIMNOHGA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ECCMJIKKPAA(Entity JAOKKIIOCBD, object KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ILBPFEEPDLG(Entity JAOKKIIOCBD, object KAJENDFCCBJ, [Out] bool HLOJMMPHOJP);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JDHDENHBJIF(Entity JAOKKIIOCBD);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class DKCOGJHCCOI<TComponentData, TValue> : GODJOFNNDLD<TValue>, IDisposable where TComponentData : struct, DNJEBEAAODP
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class NKFNLBOHBKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<(object token, TValue value)> NFJJCCDFOPE;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int JAJBNKBAONK
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x4253080", Offset = "0x4251880", VA = "0x184253080")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x55D5D60", Offset = "0x55D4560", VA = "0x1855D5D60")]
		public bool BDKCJAONNHL([Out] TValue MGONBEDEDON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x55D5E70", Offset = "0x55D4670", VA = "0x1855D5E70")]
		public void GGGBGBDKNKJ(object KAJENDFCCBJ, TValue MGONBEDEDON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x55D5F60", Offset = "0x55D4760", VA = "0x1855D5F60")]
		public bool HKOLMKDGPPH(object KAJENDFCCBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x55D6020", Offset = "0x55D4820", VA = "0x1855D6020")]
		public int JJKEKPCJLBP(object KAJENDFCCBJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x55D6120", Offset = "0x55D4920", VA = "0x1855D6120")]
		public NKFNLBOHBKI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stack<NKFNLBOHBKI> FNABKMADFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NEGGAKIBKNL<KAIGLBDFENJ, NKFNLBOHBKI> KCNFDMEDLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EntityManager FAIGBHOGMGE;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CE70", Offset = "0x6D4B670", VA = "0x186D4CE70")]
	public DKCOGJHCCOI(EntityManager FAIGBHOGMGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C8A0", Offset = "0x6D4B0A0", VA = "0x186D4C8A0", Slot = "4")]
	public void ECCMJIKKPAA(Entity JAOKKIIOCBD, object KAJENDFCCBJ, TValue MGONBEDEDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CB30", Offset = "0x6D4B330", VA = "0x186D4CB30", Slot = "5")]
	public bool ILBPFEEPDLG(Entity JAOKKIIOCBD, object KAJENDFCCBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C690", Offset = "0x6D4AE90", VA = "0x186D4C690", Slot = "6")]
	public bool BDKCJAONNHL(Entity JAOKKIIOCBD, [Out] TValue MGONBEDEDON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C880", Offset = "0x6D4B080", VA = "0x186D4C880", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C7B0", Offset = "0x6D4AFB0", VA = "0x186D4C7B0")]
	private void BIAKFGMKCPL(NKFNLBOHBKI HOJPLEBOOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C5D0", Offset = "0x6D4ADD0", VA = "0x186D4C5D0")]
	private bool AENHLEBIPEK(Entity JAOKKIIOCBD, [Out] KAIGLBDFENJ DAMJGGDGMEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CA30", Offset = "0x6D4B230", VA = "0x186D4CA30")]
	private void HMFJCBCNNAJ(Entity JAOKKIIOCBD, KAIGLBDFENJ DAMJGGDGMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6D4C5B0", Offset = "0x6D4ADB0", VA = "0x186D4C5B0")]
	private bool ABACCEDNDIE(KAIGLBDFENJ DAMJGGDGMEF, [Out] NKFNLBOHBKI HOJPLEBOOKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6D4CD40", Offset = "0x6D4B540", VA = "0x186D4CD40")]
	private NKFNLBOHBKI JKPBKCNDFIF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GODJOFNNDLD<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ECCMJIKKPAA(Entity JAOKKIIOCBD, object KAJENDFCCBJ, TValue MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ILBPFEEPDLG(Entity JAOKKIIOCBD, object KAJENDFCCBJ);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BDKCJAONNHL(Entity JAOKKIIOCBD, [Out] TValue MGONBEDEDON);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KAIGLBDFENJ : OACALCJJELJ, IEquatable<KAIGLBDFENJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly KAIGLBDFENJ HBDEBEHCDNA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int PJLMPJGAPPO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xBD78B0", Offset = "0xBD60B0", VA = "0x180BD78B0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x139F860", Offset = "0x139E060", VA = "0x18139F860", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int MOHDHMLGIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2F364C0", Offset = "0x2F34CC0", VA = "0x182F364C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x71B2930", Offset = "0x71B1130", VA = "0x1871B2930", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x815E5D0", Offset = "0x815CDD0", VA = "0x18815E5D0", Slot = "8")]
	public bool Equals(KAIGLBDFENJ KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x815E620", Offset = "0x815CE20", VA = "0x18815E620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class AMKLBFMDPHL<THasTokensTag> : GNGEIMNOHGA, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly BMELPJIFPCL GLHOMCPEEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Dictionary<Entity, KAIGLBDFENJ> KLCIOCMOPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Stack<HashSet<object>> FNABKMADFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private NEGGAKIBKNL<KAIGLBDFENJ, HashSet<object>> KCNFDMEDLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EntityManager FAIGBHOGMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EntityCommandBufferSystem OFCCHAMOKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool LKNCKMOIEPH;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4E3A150", Offset = "0x4E38950", VA = "0x184E3A150")]
	public AMKLBFMDPHL(EntityManager FAIGBHOGMGE, EntityCommandBufferSystem OFCCHAMOKBL, BMELPJIFPCL FOBJIMGGDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4E37C70", Offset = "0x4E36470", VA = "0x184E37C70", Slot = "4")]
	public bool ECCMJIKKPAA(Entity JAOKKIIOCBD, object KAJENDFCCBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4E38630", Offset = "0x4E36E30", VA = "0x184E38630", Slot = "5")]
	public bool ILBPFEEPDLG(Entity JAOKKIIOCBD, object KAJENDFCCBJ, [Out] bool HLOJMMPHOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4E38EF0", Offset = "0x4E376F0", VA = "0x184E38EF0", Slot = "6")]
	public bool JDHDENHBJIF(Entity JAOKKIIOCBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4E39120", Offset = "0x4E37920", VA = "0x184E39120", Slot = "8")]
	public bool JDHDENHBJIF(KAIGLBDFENJ DAMJGGDGMEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4E377F0", Offset = "0x4E35FF0", VA = "0x184E377F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4E376D0", Offset = "0x4E35ED0", VA = "0x184E376D0")]
	private void BIAKFGMKCPL(HashSet<object> HOJPLEBOOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4E373B0", Offset = "0x4E35BB0", VA = "0x184E373B0")]
	private bool AENHLEBIPEK(Entity JAOKKIIOCBD, [Out] KAIGLBDFENJ DAMJGGDGMEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4E37170", Offset = "0x4E35970", VA = "0x184E37170")]
	private bool AAJGLHIADNO(Entity JAOKKIIOCBD, [Out] KAIGLBDFENJ DAMJGGDGMEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4E39910", Offset = "0x4E38110", VA = "0x184E39910")]
	private void LBIIGMKHCLE(Entity JAOKKIIOCBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4E38030", Offset = "0x4E36830", VA = "0x184E38030")]
	private void GGELOEECAME(Entity JAOKKIIOCBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4E39A20", Offset = "0x4E38220", VA = "0x184E39A20")]
	private void NCEKGEJODEA(Entity JAOKKIIOCBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4E385C0", Offset = "0x4E36DC0", VA = "0x184E385C0")]
	private void HMFJCBCNNAJ(Entity JAOKKIIOCBD, KAIGLBDFENJ DAMJGGDGMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4E394C0", Offset = "0x4E37CC0", VA = "0x184E394C0")]
	private bool KMKBABIDFKL(KAIGLBDFENJ DAMJGGDGMEF, [Out] HashSet<object> HOJPLEBOOKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4E39280", Offset = "0x4E37A80", VA = "0x184E39280")]
	private HashSet<object> JKPBKCNDFIF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class KJAKLHNLJPD
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct IILJDMLJIMK : APHCGHJCJHN<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x815E5B0", Offset = "0x815CDB0", VA = "0x18815E5B0")]
	public float EEAAOBPGDMI([In] float3 MGONBEDEDON)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x815E5B0", Offset = "0x815CDB0", VA = "0x18815E5B0", Slot = "4")]
	private float AAHDMKBFCJP([In] float3 MGONBEDEDON)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct IIPHPNFMPOO : APHCGHJCJHN<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x815E5C0", Offset = "0x815CDC0", VA = "0x18815E5C0")]
	public float EEAAOBPGDMI([In] float3 MGONBEDEDON)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x815E5C0", Offset = "0x815CDC0", VA = "0x18815E5C0", Slot = "4")]
	private float AAHDMKBFCJP([In] float3 MGONBEDEDON)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct GOEKMHNHGGD : APHCGHJCJHN<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0xEFECF0", Offset = "0xEFD4F0", VA = "0x180EFECF0")]
	public float EEAAOBPGDMI([In] float3 MGONBEDEDON)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xEFECF0", Offset = "0xEFD4F0", VA = "0x180EFECF0", Slot = "4")]
	private float AAHDMKBFCJP([In] float3 MGONBEDEDON)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct LJMHGIAMLBJ : APHCGHJCJHN<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2287BC0", Offset = "0x22863C0", VA = "0x182287BC0")]
	public int EEAAOBPGDMI([In] int3 MGONBEDEDON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2287BC0", Offset = "0x22863C0", VA = "0x182287BC0", Slot = "4")]
	private int DIEGAFLFIGE([In] int3 MGONBEDEDON)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct BKCMAKKFMCJ : APHCGHJCJHN<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x12614E0", Offset = "0x125FCE0", VA = "0x1812614E0")]
	public int EEAAOBPGDMI([In] int3 MGONBEDEDON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x12614E0", Offset = "0x125FCE0", VA = "0x1812614E0", Slot = "4")]
	private int DIEGAFLFIGE([In] int3 MGONBEDEDON)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct GJANPNCPMND : APHCGHJCJHN<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xEE3150", Offset = "0xEE1950", VA = "0x180EE3150")]
	public int EEAAOBPGDMI([In] int3 MGONBEDEDON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xEE3150", Offset = "0xEE1950", VA = "0x180EE3150", Slot = "4")]
	private int DIEGAFLFIGE([In] int3 MGONBEDEDON)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BBMPEFBOKJO : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x21777B0", Offset = "0x2175FB0", VA = "0x1821777B0")]
	public BBMPEFBOKJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class PLKHDOOKPMK : SystemBase, FKAIGFJIINO
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x815F000", Offset = "0x815D800", VA = "0x18815F000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3BA5F40", Offset = "0x3BA4740", VA = "0x183BA5F40")]
	public void MHMGKDCPFAB<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3BA5F40", Offset = "0x3BA4740", VA = "0x183BA5F40")]
	public void PPOGONACKGI<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x815EFB0", Offset = "0x815D7B0", VA = "0x18815EFB0")]
	public JobHandle FOCAEDCHDIB(ReadOnlySpan<int> PDKPGDEFDIB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3BA5A90", Offset = "0x3BA4290", VA = "0x183BA5A90")]
	public JobHandle IOHCOPBIDNB<T>() where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x815F030", Offset = "0x815D830", VA = "0x18815F030")]
	public JobHandle IOHCOPBIDNB(ReadOnlySpan<int> PDKPGDEFDIB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3BA5C10", Offset = "0x3BA4410", VA = "0x183BA5C10")]
	public void NDDFFGDKJBL<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3BA5FA0", Offset = "0x3BA47A0", VA = "0x183BA5FA0")]
	public JobHandle NDDFFGDKJBL<T>(JobHandle DAMJGGDGMEF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x815F110", Offset = "0x815D910", VA = "0x18815F110")]
	public JobHandle NDDFFGDKJBL(ReadOnlySpan<int> PDKPGDEFDIB, JobHandle DAMJGGDGMEF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3BA5C10", Offset = "0x3BA4410", VA = "0x183BA5C10")]
	public void KFIMHHOKHKE<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3BA5CA0", Offset = "0x3BA44A0", VA = "0x183BA5CA0")]
	public JobHandle KFIMHHOKHKE<T>(JobHandle DAMJGGDGMEF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x815F080", Offset = "0x815D880", VA = "0x18815F080")]
	public JobHandle KFIMHHOKHKE(Span<int> PDKPGDEFDIB, JobHandle DAMJGGDGMEF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3BA6860", Offset = "0x3BA5060", VA = "0x183BA6860")]
	public ComponentDataFromEntity OOKJGLLLPOJ<T>(bool JOOPKFKHMDP = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x815F180", Offset = "0x815D980", VA = "0x18815F180")]
	public ComponentDataFromEntity OOKJGLLLPOJ(int BEIKFCEAAEK, bool JOOPKFKHMDP = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3BA5B40", Offset = "0x3BA4340", VA = "0x183BA5B40")]
	public SharedComponentIndexFromEntity<T> KFDJLHGCDPM<T>() where T : ISharedComponentData
	{
		return default(SharedComponentIndexFromEntity<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x815EF50", Offset = "0x815D750", VA = "0x18815EF50")]
	[BurstCompatible]
	public ComponentTypeHandle DOEHAAEGPNK(ComponentType BGBIGBOOJHP)
	{
		return default(ComponentTypeHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x815F0F0", Offset = "0x815D8F0", VA = "0x18815F0F0")]
	public EntityExistenceLookupByEntity LKDBOJJIACH()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x815F240", Offset = "0x815DA40", VA = "0x18815F240", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3BA6930", Offset = "0x3BA5130", VA = "0x183BA6930")]
	public bool PIPGCDGELCE<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "7")]
	protected sealed override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x21777B0", Offset = "0x2175FB0", VA = "0x1821777B0")]
	protected PLKHDOOKPMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class NOFDBGOFGPB : PLKHDOOKPMK
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x815ED40", Offset = "0x815D540", VA = "0x18815ED40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x21777B0", Offset = "0x2175FB0", VA = "0x1821777B0")]
	protected NOFDBGOFGPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class CELBOBENKGE
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class OECABLIIFOD : EntityCommandBufferSystem, FKAIGFJIINO
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private BMELPJIFPCL MIHGFEDHECA
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xDF7400", Offset = "0xDF5C00", VA = "0x180DF7400")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x815EE90", Offset = "0x815D690", VA = "0x18815EE90")]
	public OECABLIIFOD(BMELPJIFPCL GLHOMCPEEHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface APHCGHJCJHN<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo EEAAOBPGDMI([In] TFrom MGONBEDEDON);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface PPKJAFOFHCD<T>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EPKDMMPEPBE(T MGONBEDEDON);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct EEECNDLLLKG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> EFHAKLBGNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer GKNHGAODBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public ComponentTypes BMBMNMHPIKM;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x815E4A0", Offset = "0x815CCA0", VA = "0x18815E4A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct OBEMFKPMOPO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> EFHAKLBGNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer GKNHGAODBOD;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x815EDF0", Offset = "0x815D5F0", VA = "0x18815EDF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct NIMMJFHGCMO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> EFHAKLBGNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer GKNHGAODBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public ComponentType BGBIGBOOJHP;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x815ECC0", Offset = "0x815D4C0", VA = "0x18815ECC0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[BurstCompile]
internal struct LNKKNFELLHO<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> EFHAKLBGNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> IMINNNCPCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer GKNHGAODBOD;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x532CE60", Offset = "0x532B660", VA = "0x18532CE60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct BHMHDMBOIHK<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> EFHAKLBGNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<T> IFMNLKCJNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer GKNHGAODBOD;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal struct OIAKNPLIDIE<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<Entity> EFHAKLBGNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public T MGONBEDEDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EntityCommandBuffer GKNHGAODBOD;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct HFKGJKNFAIE<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, APHCGHJCJHN<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<TFrom> MFHKBNCBBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<TTo> PIANFAAPEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public TMap AMNCPNDDCLP;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct LCDLLAMIOIA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity HKBOACAAIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> MFHKBNCBBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeArray<byte> PIANFAAPEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int MDFFBBMKIHC;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x815E6B0", Offset = "0x815CEB0", VA = "0x18815E6B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct KMJOKHFCLJD<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> HDOLDHHADEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<Entity> MFHKBNCBBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<T> HHFCNLCBHHO;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct KMHFFFCGJCM<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, APHCGHJCJHN<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<TFrom> GLCFKNLKFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[WriteOnly]
	public NativeList<TTo> PIANFAAPEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public TMap AMNCPNDDCLP;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct DCGJFCEBLNM<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> KHJPMBMIJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> EJCGGJPHCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> CCCIIBCLFNK;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct AJOEEGNOALD<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public ComponentDataFromEntity<T> KHJPMBMIJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<Entity> EJCGGJPHCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<bool> CCCIIBCLFNK;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4D25A10", Offset = "0x4D24210", VA = "0x184D25A10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct JFMCPBHHEPF<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<T> MFHKBNCBBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<T> HHFCNLCBHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<T> FAFDCMPBBMD;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x50B1AB0", Offset = "0x50B02B0", VA = "0x1850B1AB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct ODCKFNCOKAL<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : APHCGHJCJHN<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<TFrom> MFHKBNCBBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public NativeList<TFrom> HHFCNLCBHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeParallelHashSet<TTo> FAFDCMPBBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TMap AMNCPNDDCLP;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct CFKOOPCHFNN<T, TPredicate> : IJob where T : struct where TPredicate : struct, PPKJAFOFHCD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> MFHKBNCBBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<Entity> EFPCAEHECEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<Entity> AAMJGBCFEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate AMNCPNDDCLP;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct HPHLDAKGLHL<T, TPredicate> : IJob where T : struct where TPredicate : struct, PPKJAFOFHCD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> MFHKBNCBBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> HHFCNLCBHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TPredicate AMNCPNDDCLP;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct LEIFNNAFOJE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity KHJPMBMIJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> EJCGGJPHCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> NHEABEEFMDI;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x815E7B0", Offset = "0x815CFB0", VA = "0x18815E7B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct DCHJDGMJDBD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[ReadOnly]
	public ComponentDataFromEntity KHJPMBMIJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<Entity> EJCGGJPHCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<Entity> NHEABEEFMDI;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x815E2F0", Offset = "0x815CAF0", VA = "0x18815E2F0", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class PHEKOFMCGCK
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class DJJGGCHMILO
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x37FBB00", Offset = "0x37FA300", VA = "0x1837FBB00")]
	public static bool JKLNMNOADFK<T>(this NativeArray<Entity> EJCGGJPHCPC, EntityManager FAIGBHOGMGE, Allocator GFNKGIEEHMD = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class PALCFKOBECO
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class CCHOLJODJPD<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		public CCHOLJODJPD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class OBBJODCEFPF<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public OBBJODCEFPF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly List<Func<JobHandle, JobHandle>> ENNDHHJGMKA;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x815EEC0", Offset = "0x815D6C0", VA = "0x18815EEC0")]
	public PALCFKOBECO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class DJJPBPPNNIE
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class ILIMHJDIGCC
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct JBNFCOJNBNK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct MCMENEJHACB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal JBNFCOJNBNK<TFrom> MJNLMOPPION;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator GFNKGIEEHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeArray<TFrom> GJKNNKIANJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct NJEACBOHKOA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct FOKOHLIBIAG<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal NJEACBOHKOA<TFrom> MJNLMOPPION;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator GFNKGIEEHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeList<TFrom> GJKNNKIANJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct EFMPHGHBGIA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct NPBPFHGBDOI<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal EFMPHGHBGIA<TFrom> MJNLMOPPION;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator GFNKGIEEHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeArrayAsync<TFrom> GJKNNKIANJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct GONBAFIFDEA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public struct GCMLAIMIHJO<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			internal GONBAFIFDEA<TFrom> MJNLMOPPION;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal Allocator GFNKGIEEHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal NativeListAsync<TFrom> GJKNNKIANJJ;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class IJAAOEKIANI
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class GPMHHCOHHKI
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x39E9D20", Offset = "0x39E8520", VA = "0x1839E9D20")]
	public static NativeList<T> DEOFPMIMNDL<T>(this NativeArray<T> NJPCHEIHPHA, Allocator GFNKGIEEHMD = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class DPLMBOCIJAK
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class CMMBLINODGD
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x37BC530", Offset = "0x37BAD30", VA = "0x1837BC530")]
	[KJKJIGDJFNN]
	public static JobHandle MOAIDHMEFJD<T>(this EntityCommandBufferSystem OFCCHAMOKBL, NativeArray<Entity> EFHAKLBGNAC, NativeArray<T> IMINNNCPCJF) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x37BC230", Offset = "0x37BAA30", VA = "0x1837BC230")]
	[KJKJIGDJFNN]
	public static JobHandle MOAIDHMEFJD<T>(this EntityCommandBufferSystem OFCCHAMOKBL, NativeArrayAsync<Entity> EFHAKLBGNAC, NativeArrayAsync<T> IMINNNCPCJF, [Optional] JobHandle GDOMAEHADFL) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x37BC100", Offset = "0x37BA900", VA = "0x1837BC100")]
	[KJKJIGDJFNN]
	public static JobHandle MOAIDHMEFJD<T>(this EntityCommandBufferSystem OFCCHAMOKBL, NativeArray<Entity> EFHAKLBGNAC, [Optional] JobHandle GDOMAEHADFL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x815E180", Offset = "0x815C980", VA = "0x18815E180")]
	[KJKJIGDJFNN]
	public static JobHandle MOAIDHMEFJD(this EntityCommandBufferSystem OFCCHAMOKBL, NativeArray<Entity> EFHAKLBGNAC, ComponentTypes BMBMNMHPIKM, [Optional] JobHandle GDOMAEHADFL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x815E030", Offset = "0x815C830", VA = "0x18815E030")]
	[KJKJIGDJFNN]
	public static JobHandle MOAIDHMEFJD(this EntityCommandBufferSystem OFCCHAMOKBL, EntityCommandBuffer GKNHGAODBOD, NativeArray<Entity> EFHAKLBGNAC, ComponentTypes BMBMNMHPIKM, [Optional] JobHandle GDOMAEHADFL)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class GFAPMMDBLDI
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class MAMJOBICBDN
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x815E840", Offset = "0x815D040", VA = "0x18815E840")]
	[KJKJIGDJFNN]
	public static JobHandle OFFDLJMHHLL(this EntityCommandBufferSystem OFCCHAMOKBL, NativeList<Entity> EFHAKLBGNAC, [Optional] JobHandle GDOMAEHADFL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x815E9D0", Offset = "0x815D1D0", VA = "0x18815E9D0")]
	[KJKJIGDJFNN]
	public static JobHandle OFFDLJMHHLL(this EntityCommandBufferSystem OFCCHAMOKBL, NativeArrayAsync<Entity> EFHAKLBGNAC)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class CAJFPHHPDEM
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3792F20", Offset = "0x3791720", VA = "0x183792F20")]
	public static void JPELFPBMCJK<T>(this EntityCommandBufferSystem OFCCHAMOKBL, EntityQuery JGNCOBLHBBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3792E70", Offset = "0x3791670", VA = "0x183792E70")]
	[KJKJIGDJFNN]
	public static JobHandle COHOKOIFPJG<T>(this EntityCommandBufferSystem OFCCHAMOKBL, NativeArrayAsync<Entity> EFHAKLBGNAC, [Optional] JobHandle GDOMAEHADFL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x815DEA0", Offset = "0x815C6A0", VA = "0x18815DEA0")]
	[KJKJIGDJFNN]
	public static JobHandle COHOKOIFPJG(this EntityCommandBufferSystem OFCCHAMOKBL, NativeArrayAsync<Entity> EFHAKLBGNAC, ComponentType BGBIGBOOJHP, [Optional] JobHandle GDOMAEHADFL)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class LKAGMMGHIFJ
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3AACC70", Offset = "0x3AAB470", VA = "0x183AACC70")]
	[KJKJIGDJFNN]
	public static JobHandle POGEPJIEFCO<T>(this EntityCommandBufferSystem OFCCHAMOKBL, NativeArray<Entity> EFHAKLBGNAC, NativeArray<T> IMINNNCPCJF, JobHandle GDOMAEHADFL) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class DDGEEMHNOED
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class JOOJBCMCICK
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class MBJMDIGCKEA
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3ABDE60", Offset = "0x3ABC660", VA = "0x183ABDE60")]
	public static NativeArray<T> GHFMBHJJIHO<T>(this NativeList<Entity> NJPCHEIHPHA, EntityManager FAIGBHOGMGE, Allocator GFNKGIEEHMD = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3ABDF30", Offset = "0x3ABC730", VA = "0x183ABDF30")]
	public static NativeArray<T> GHFMBHJJIHO<T>(this NativeArray<Entity> NJPCHEIHPHA, EntityManager FAIGBHOGMGE, Allocator GFNKGIEEHMD = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x815EAD0", Offset = "0x815D2D0", VA = "0x18815EAD0")]
	public static NativeArray<Entity> FBBILIBLAED(this NativeArray<Entity> NJPCHEIHPHA, EntityManager FAIGBHOGMGE, ComponentType BGBIGBOOJHP, Allocator GFNKGIEEHMD = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3ABE850", Offset = "0x3ABD050", VA = "0x183ABE850")]
	public static NativeArray<T> HKIHODIHFDD<T>(this NativeArray<Entity> NJPCHEIHPHA, EntityManager FAIGBHOGMGE, Allocator GFNKGIEEHMD = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class EHFMFFFNKOD
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct LHAAGJODGOM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct NNEPKGHPDOK<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public LHAAGJODGOM<TFrom> GJKNNKIANJJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator GFNKGIEEHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArray<TFrom> MFHKBNCBBAD;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct JJEJKAFLNIF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct LJKKHPFMPFB<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public JJEJKAFLNIF<TFrom> GJKNNKIANJJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator GFNKGIEEHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeArrayAsync<TFrom> MFHKBNCBBAD;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct GEAEMHKFCNG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public struct FHIJNEMADLD<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public GEAEMHKFCNG<TFrom> GJKNNKIANJJ;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator GFNKGIEEHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeListAsync<TFrom> MFHKBNCBBAD;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class HFDBOMFDLMO
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class NFMMNNIDAJG
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct NANNEMDIJPD : APHCGHJCJHN<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> IDMDNJDIECI;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x815ECB0", Offset = "0x815D4B0", VA = "0x18815ECB0")]
		[BurstCompatible]
		public Entity EEAAOBPGDMI([In] Entity MGONBEDEDON)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x815ECB0", Offset = "0x815D4B0", VA = "0x18815ECB0", Slot = "4")]
		private Entity EHHEEPIOPFJ([In] Entity MGONBEDEDON)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class PNHFPAOIIFJ
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct NMDAONGADGE<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x55DFD60", Offset = "0x55DE560", VA = "0x1855DFD60", Slot = "4")]
		public int Compare((TKey, TValue) BDGPJOKJNIL, (TKey, TValue) HDAFCDJNHAK)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3BA7DD0", Offset = "0x3BA65D0", VA = "0x183BA7DD0")]
	public static void DCCHDFOHILP<TKey, TValue>(NativeList<TKey> PAPCEAPJNGK, NativeList<TValue> IFMNLKCJNMD) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3BA82A0", Offset = "0x3BA6AA0", VA = "0x183BA82A0")]
	public static void DCCHDFOHILP<TKey, TValue>(NativeArray<TKey> PAPCEAPJNGK, NativeArray<TValue> IFMNLKCJNMD) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3BA8060", Offset = "0x3BA6860", VA = "0x183BA8060")]
	public static void DCCHDFOHILP<TKey, TValue, U>(NativeArray<TKey> PAPCEAPJNGK, NativeArray<TValue> IFMNLKCJNMD, U GAANOMHIAJF) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class JGDHOCFIPMK
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct HGDIGIOPBLP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator GFNKGIEEHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<Entity> EFPCAEHECEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> MFHKBNCBBAD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct CBOOFPCMKNF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator GFNKGIEEHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeList<Entity> EFPCAEHECEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArray<T> MFHKBNCBBAD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct NJJCHEOOCDC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator GFNKGIEEHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArrayAsync<Entity> EFPCAEHECEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArrayAsync<T> MFHKBNCBBAD;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class MLDFFDFDGMP
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class JJJCBKLCAJC
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct JPONOCKEGAM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator GFNKGIEEHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArray<T> MFHKBNCBBAD;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct CDMLAEIANGC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator GFNKGIEEHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeList<T> MFHKBNCBBAD;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct NDKLBHDLPJA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator GFNKGIEEHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<T> MFHKBNCBBAD;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct OMAECOOBGBP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Allocator GFNKGIEEHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NativeListAsync<T> MFHKBNCBBAD;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class IHAGEKHPDOH
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class KGFCLBNJEOE
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3A90450", Offset = "0x3A8EC50", VA = "0x183A90450")]
	public static NativeList<Entity> GHDOBKMFFDH<T>(this NativeList<Entity> EJCGGJPHCPC, EntityManager FAIGBHOGMGE, Allocator GFNKGIEEHMD = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3A8FE10", Offset = "0x3A8E610", VA = "0x183A8FE10")]
	public static NativeList<Entity> GHDOBKMFFDH<T>(this NativeArray<Entity> EJCGGJPHCPC, EntityManager FAIGBHOGMGE, Allocator GFNKGIEEHMD = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class LHACDGJICEL
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3AA6990", Offset = "0x3AA5190", VA = "0x183AA6990")]
	public static NativeList<Entity> IFAKOKBNCCI<T>(this NativeArray<Entity> EJCGGJPHCPC, EntityManager FAIGBHOGMGE, Allocator GFNKGIEEHMD = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class OKDKABEOODB
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public readonly struct EFCFMPCNCPH<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> LPBOBEPEKNH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public readonly struct MIMLDOKALHH<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> LPBOBEPEKNH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public readonly struct GGOHFPCAIGG<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, APHCGHJCJHN<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly NativeArray<TSrc> LPBOBEPEKNH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct DMEFMCKGEDI<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, APHCGHJCJHN<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly NativeArray<TSrc> LPBOBEPEKNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TSelector HAJBEIGPEKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int PNJCJGEIDHG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct FGLICFMFPKM<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, APHCGHJCJHN<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private DMEFMCKGEDI<TSrc, TValue, TSelector> DCDHHMABBCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TValue IDNNMKMMIFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int COEFDMIBPJJ;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class NDJANFHFOGG
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct NOGDEDNNGDB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<T> LPBOBEPEKNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int COEFDMIBPJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int OJHGGEKLBHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private T IDNNMKMMIFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T MFNLIEBIAIN;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public OFIADOPPLCJ PIHDMBEFEOL
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x552D420", Offset = "0x552BC20", VA = "0x18552D420")]
			get
			{
				return default(OFIADOPPLCJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public T KENHMGACHIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public (T, OFIADOPPLCJ) EBPBANINJIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x552D430", Offset = "0x552BC30", VA = "0x18552D430")]
			get
			{
				return default((T, OFIADOPPLCJ));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x55EC290", Offset = "0x55EAA90", VA = "0x1855EC290")]
		public NOGDEDNNGDB(NativeArray<T> LPBOBEPEKNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4809F70", Offset = "0x4808770", VA = "0x184809F70")]
		public NOGDEDNNGDB<T> KFPOPIJHFBP()
		{
			return default(NOGDEDNNGDB<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x55EBE40", Offset = "0x55EA640", VA = "0x1855EBE40")]
		public bool LMBOCOKIDAD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4187B40", Offset = "0x4186340", VA = "0x184187B40")]
		public MCMNPEHBDBE<T, TComparer> DAPALPEJGOC<TComparer>([Optional] TComparer GAANOMHIAJF) where TComparer : struct, IEqualityComparer<T>
		{
			return default(MCMNPEHBDBE<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct MCMNPEHBDBE<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly NativeArray<T> LPBOBEPEKNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int COEFDMIBPJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int OJHGGEKLBHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private T IDNNMKMMIFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private T MFNLIEBIAIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TComparer GAANOMHIAJF;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public OFIADOPPLCJ PIHDMBEFEOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x552D420", Offset = "0x552BC20", VA = "0x18552D420")]
			get
			{
				return default(OFIADOPPLCJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T KENHMGACHIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public (T value, OFIADOPPLCJ range) EBPBANINJIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x552D430", Offset = "0x552BC30", VA = "0x18552D430")]
			get
			{
				return default((T, OFIADOPPLCJ));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x552D850", Offset = "0x552C050", VA = "0x18552D850")]
		public MCMNPEHBDBE(NativeArray<T> LPBOBEPEKNH, TComparer GAANOMHIAJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x37F9800", Offset = "0x37F8000", VA = "0x1837F9800")]
		public MCMNPEHBDBE<T, TComparer> KFPOPIJHFBP()
		{
			return default(MCMNPEHBDBE<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x552D6F0", Offset = "0x552BEF0", VA = "0x18552D6F0")]
		public bool LMBOCOKIDAD()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3B45E90", Offset = "0x3B44690", VA = "0x183B45E90")]
	public static NOGDEDNNGDB<T> KMFLPCHGGNN<T>(this NativeArray<T> LPBOBEPEKNH) where T : struct
	{
		return default(NOGDEDNNGDB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface EIJPJPCDFDB
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class BOFCLGBAJFP
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct GBNDKGDDMIO<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class JLFFHEFMCHH : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public GBNDKGDDMIO<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xC8EAC0", Offset = "0xC8D2C0", VA = "0x180C8EAC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4C28240", Offset = "0x4C26A40", VA = "0x184C28240", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
		[DebuggerHidden]
		public JLFFHEFMCHH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x50CDDA0", Offset = "0x50CC5A0", VA = "0x1850CDDA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x50CDF80", Offset = "0x50CC780", VA = "0x1850CDF80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly Action<Protobuf> GIDAKCAGALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MemoryStream HGGLOALDKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CodedInputStream NLLEHGDDGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Protobuf LDIEJDNDIGI;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly int FFBDFGAGHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7C0", Offset = "0xA8CFC0", VA = "0x180A8E7C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4C7B690", Offset = "0x4C79E90", VA = "0x184C7B690", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4C7B6D0", Offset = "0x4C79ED0", VA = "0x184C7B6D0", Slot = "4")]
	[IteratorStateMachine(typeof(GBNDKGDDMIO<>.JLFFHEFMCHH))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4C7B7D0", Offset = "0x4C79FD0", VA = "0x184C7B7D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct OCCCDLKAFNK<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly byte[] FLHFCEEIHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Protobuf LDIEJDNDIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream HGGLOALDKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedOutputStream HJMBFMBOCCG;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5726930", Offset = "0x5725130", VA = "0x185726930", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct KNAMCLIILFG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream HGGLOALDKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedInputStream NLLEHGDDGPA;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x815E670", Offset = "0x815CE70", VA = "0x18815E670", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct DGOEOBOLNGM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] FLHFCEEIHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly MemoryStream HGGLOALDKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly CodedOutputStream HJMBFMBOCCG;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x815E380", Offset = "0x815CB80", VA = "0x18815E380", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class CFIEKHCCHNG
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class LAPMLGDBFAH
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[Flags]
public enum BHBJLGPIFHP
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
internal static class PKMNCJHIEOO
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class LBHJJCIMPIK
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public LBHJJCIMPIK()
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
