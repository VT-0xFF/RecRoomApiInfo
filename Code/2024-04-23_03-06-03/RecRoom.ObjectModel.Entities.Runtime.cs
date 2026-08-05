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
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6383DA0", Offset = "0x6382DA0", VA = "0x186383DA0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PLEKLJEIOFK : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	EJACCNNJNJP PANJKGBNGEJ
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
public interface LMAOEDDLJOM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OIIGAIHFLBC(Entity KNIDMAMMIEJ, object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KJPPGCBMIKP(Entity KNIDMAMMIEJ, object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PONJCDMLDMN(Entity KNIDMAMMIEJ);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AOPOOJJFAMP(Entity KNIDMAMMIEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class JENNLKAIADJ<TComponentData, TValue> : JMNGNIJKJLO<TValue>, IDisposable where TComponentData : struct, PLEKLJEIOFK
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class BDLBPNDJEKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> FKIBLLNGEAG;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int JFLFCJGPPMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x329FD00", Offset = "0x329ED00", VA = "0x18329FD00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x48EB600", Offset = "0x48EA600", VA = "0x1848EB600")]
		public bool KDJHPABCMIJ([Out] TValue LDGMLLMKHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x48EB550", Offset = "0x48EA550", VA = "0x1848EB550")]
		public void BGLDHBEBEIE(object KONODCHOCOG, TValue LDGMLLMKHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x48EB6F0", Offset = "0x48EA6F0", VA = "0x1848EB6F0")]
		public bool NCLCGNJGAKA(object KONODCHOCOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x48EB770", Offset = "0x48EA770", VA = "0x1848EB770")]
		public int OFIJAHKONJB(object KONODCHOCOG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x48EB850", Offset = "0x48EA850", VA = "0x1848EB850")]
		public BDLBPNDJEKL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<BDLBPNDJEKL> KMGHDIJAHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private CHNAPLNIBDM<EJACCNNJNJP, BDLBPNDJEKL> EDOICBCPPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager BKPACEIFJEG;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3CCB3F0", Offset = "0x3CCA3F0", VA = "0x183CCB3F0")]
	public JENNLKAIADJ(EntityManager BKPACEIFJEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3CCB2B0", Offset = "0x3CCA2B0", VA = "0x183CCB2B0", Slot = "4")]
	public void OIIGAIHFLBC(Entity KNIDMAMMIEJ, object KONODCHOCOG, TValue LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3CCB0F0", Offset = "0x3CCA0F0", VA = "0x183CCB0F0", Slot = "5")]
	public bool KJPPGCBMIKP(Entity KNIDMAMMIEJ, object KONODCHOCOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3CCAFF0", Offset = "0x3CC9FF0", VA = "0x183CCAFF0", Slot = "6")]
	public bool KDJHPABCMIJ(Entity KNIDMAMMIEJ, [Out] TValue LDGMLLMKHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3CCAE20", Offset = "0x3CC9E20", VA = "0x183CCAE20", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3CCACA0", Offset = "0x3CC9CA0", VA = "0x183CCACA0")]
	private void BBDPNIGOKDN(BDLBPNDJEKL GALPMAFNHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3CCAE40", Offset = "0x3CC9E40", VA = "0x183CCAE40")]
	private bool EBJEEBMHFDF(Entity KNIDMAMMIEJ, [Out] EJACCNNJNJP NJADCNCCDAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3CCAF00", Offset = "0x3CC9F00", VA = "0x183CCAF00")]
	private void EPOHIENIONF(Entity KNIDMAMMIEJ, EJACCNNJNJP NJADCNCCDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3CCB290", Offset = "0x3CCA290", VA = "0x183CCB290")]
	private bool LEGBPACDJJA(EJACCNNJNJP NJADCNCCDAJ, [Out] BDLBPNDJEKL GALPMAFNHMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3CCAD30", Offset = "0x3CC9D30", VA = "0x183CCAD30")]
	private BDLBPNDJEKL BLGBPOBEOBK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JMNGNIJKJLO<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OIIGAIHFLBC(Entity KNIDMAMMIEJ, object KONODCHOCOG, TValue LDGMLLMKHLF);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KJPPGCBMIKP(Entity KNIDMAMMIEJ, object KONODCHOCOG);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KDJHPABCMIJ(Entity KNIDMAMMIEJ, [Out] TValue LDGMLLMKHLF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct EJACCNNJNJP : FFECINGEIPC, IEquatable<EJACCNNJNJP>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly EJACCNNJNJP PPEPKDCDIPM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int CBOGBOOIKCP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9151A0", Offset = "0x9141A0", VA = "0x1809151A0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x915160", Offset = "0x914160", VA = "0x180915160", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int LDLNMMLFDEG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x237F180", Offset = "0x237E180", VA = "0x18237F180", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x56EA740", Offset = "0x56E9740", VA = "0x1856EA740", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6383C60", Offset = "0x6382C60", VA = "0x186383C60", Slot = "8")]
	public bool Equals(EJACCNNJNJP JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6383CB0", Offset = "0x6382CB0", VA = "0x186383CB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class PDKLAFGAEDD<THasTokensTag> : LMAOEDDLJOM, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly NDLEKAMCBHL LAGKGKDNMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, EJACCNNJNJP> IJJEGFJBMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> KMGHDIJAHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CHNAPLNIBDM<EJACCNNJNJP, HashSet<object>> EDOICBCPPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager BKPACEIFJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem IPMNKGLLGHE;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x42863E0", Offset = "0x42853E0", VA = "0x1842863E0")]
	public PDKLAFGAEDD(EntityManager BKPACEIFJEG, EntityCommandBufferSystem IPMNKGLLGHE, NDLEKAMCBHL KEDNFJEGECA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4284ED0", Offset = "0x4283ED0", VA = "0x184284ED0", Slot = "4")]
	public bool OIIGAIHFLBC(Entity KNIDMAMMIEJ, object KONODCHOCOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4284A10", Offset = "0x4283A10", VA = "0x184284A10", Slot = "5")]
	public bool KJPPGCBMIKP(Entity KNIDMAMMIEJ, object KONODCHOCOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x42859E0", Offset = "0x42849E0", VA = "0x1842859E0", Slot = "6")]
	public bool PONJCDMLDMN(Entity KNIDMAMMIEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4285D30", Offset = "0x4284D30", VA = "0x184285D30", Slot = "9")]
	public bool PONJCDMLDMN(EJACCNNJNJP NJADCNCCDAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x42829F0", Offset = "0x42819F0", VA = "0x1842829F0", Slot = "7")]
	public bool AOPOOJJFAMP(Entity KNIDMAMMIEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4283140", Offset = "0x4282140", VA = "0x184283140", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4282BF0", Offset = "0x4281BF0", VA = "0x184282BF0")]
	private void BBDPNIGOKDN(HashSet<object> GALPMAFNHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4283420", Offset = "0x4282420", VA = "0x184283420")]
	private bool EBJEEBMHFDF(Entity KNIDMAMMIEJ, [Out] EJACCNNJNJP NJADCNCCDAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4283C00", Offset = "0x4282C00", VA = "0x184283C00")]
	private bool FEMLOPKIEPP(Entity KNIDMAMMIEJ, [Out] EJACCNNJNJP NJADCNCCDAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4284120", Offset = "0x4283120", VA = "0x184284120")]
	private void JAPFMHBAGEM(Entity KNIDMAMMIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x42858D0", Offset = "0x42848D0", VA = "0x1842858D0")]
	private void OJKFAKABJKD(Entity KNIDMAMMIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4283810", Offset = "0x4282810", VA = "0x184283810")]
	private void EFFPFABMKJK(Entity KNIDMAMMIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4283A60", Offset = "0x4282A60", VA = "0x184283A60")]
	private void EPOHIENIONF(Entity KNIDMAMMIEJ, EJACCNNJNJP NJADCNCCDAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4284CA0", Offset = "0x4283CA0", VA = "0x184284CA0")]
	private bool OAJBGDNLAPH(EJACCNNJNJP NJADCNCCDAJ, [Out] HashSet<object> GALPMAFNHMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4282F60", Offset = "0x4281F60", VA = "0x184282F60")]
	private HashSet<object> BLGBPOBEOBK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class IKNMKJOGCBM
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct IKIAJMOIOMB : MAMFKEAGJIO<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x63844E0", Offset = "0x63834E0", VA = "0x1863844E0")]
	public float HKFENHIPJKG([In] float3 LDGMLLMKHLF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x63844E0", Offset = "0x63834E0", VA = "0x1863844E0", Slot = "4")]
	private float HILJADEKOOP([In] float3 LDGMLLMKHLF)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct BBOJGJOPAJN : MAMFKEAGJIO<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6383980", Offset = "0x6382980", VA = "0x186383980")]
	public float HKFENHIPJKG([In] float3 LDGMLLMKHLF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6383980", Offset = "0x6382980", VA = "0x186383980", Slot = "4")]
	private float HILJADEKOOP([In] float3 LDGMLLMKHLF)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct IMEPLDLGAIL : MAMFKEAGJIO<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1B14F20", Offset = "0x1B13F20", VA = "0x181B14F20")]
	public float HKFENHIPJKG([In] float3 LDGMLLMKHLF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1B14F20", Offset = "0x1B13F20", VA = "0x181B14F20", Slot = "4")]
	private float HILJADEKOOP([In] float3 LDGMLLMKHLF)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct INENCJJMMBM : MAMFKEAGJIO<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1404430", Offset = "0x1403430", VA = "0x181404430")]
	public int HKFENHIPJKG([In] int3 LDGMLLMKHLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1404430", Offset = "0x1403430", VA = "0x181404430", Slot = "4")]
	private int NHKGOGCHHKL([In] int3 LDGMLLMKHLF)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct AOHANHMPFNK : MAMFKEAGJIO<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6383970", Offset = "0x6382970", VA = "0x186383970")]
	public int HKFENHIPJKG([In] int3 LDGMLLMKHLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6383970", Offset = "0x6382970", VA = "0x186383970", Slot = "4")]
	private int NHKGOGCHHKL([In] int3 LDGMLLMKHLF)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct JEGMKOCPIEL : MAMFKEAGJIO<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1711380", Offset = "0x1710380", VA = "0x181711380")]
	public int HKFENHIPJKG([In] int3 LDGMLLMKHLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1711380", Offset = "0x1710380", VA = "0x181711380", Slot = "4")]
	private int NHKGOGCHHKL([In] int3 LDGMLLMKHLF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class EIJJJAHKEOC : IGIJIHDOMKC
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7D00C0", Offset = "0x7CF0C0", VA = "0x1807D00C0")]
	public EIJJJAHKEOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class CLEPFGKIPHK : SystemBase, DEKKCDKHFOM
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x271D490", Offset = "0x271C490", VA = "0x18271D490")]
	public void DHPCBLGBLEO<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x271D250", Offset = "0x271C250", VA = "0x18271D250")]
	public JobHandle DHPCBLGBLEO<T>(JobHandle JGKAKAKNMCO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x271D490", Offset = "0x271C490", VA = "0x18271D490")]
	public void JHOLJLEDFNI<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x271D8D0", Offset = "0x271C8D0", VA = "0x18271D8D0")]
	public JobHandle JHOLJLEDFNI<T>(JobHandle JGKAKAKNMCO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6383AE0", Offset = "0x6382AE0", VA = "0x186383AE0")]
	public ComponentDataFromEntity PJMHNICKEHM(int OGCKBBAGLEA, bool NADBDEMMHIN = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6383AC0", Offset = "0x6382AC0", VA = "0x186383AC0")]
	public EntityExistenceLookupByEntity AOOJOAMKGDP()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6383BA0", Offset = "0x6382BA0", VA = "0x186383BA0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7D00C0", Offset = "0x7CF0C0", VA = "0x1807D00C0")]
	protected CLEPFGKIPHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class DHFGJDBDEFL : CLEPFGKIPHK
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6383BB0", Offset = "0x6382BB0", VA = "0x186383BB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7D00C0", Offset = "0x7CF0C0", VA = "0x1807D00C0")]
	protected DHFGJDBDEFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class IMBNHILDBGI
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class ACHMGPONLAG : EntityCommandBufferSystem, DEKKCDKHFOM
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7D00C0", Offset = "0x7CF0C0", VA = "0x1807D00C0")]
	protected ACHMGPONLAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface MAMFKEAGJIO<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo HKFENHIPJKG([In] TFrom LDGMLLMKHLF);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface JLPEGBJPINE<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NOPDHFPAIPJ(T LDGMLLMKHLF);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BurstCompile]
internal struct MLHMJNIBEIE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[ReadOnly]
	public NativeArray<Entity> LEIOAKAEPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public EntityCommandBuffer KNMGMKDDCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public ComponentTypes JDBNMFNILOF;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x63847F0", Offset = "0x63837F0", VA = "0x1863847F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct EJIFLKOLNKO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[ReadOnly]
	public NativeArray<Entity> LEIOAKAEPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public EntityCommandBuffer KNMGMKDDCAP;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6383D00", Offset = "0x6382D00", VA = "0x186383D00", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct DOPGDGDAJCH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public NativeArray<Entity> LEIOAKAEPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public EntityCommandBuffer KNMGMKDDCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public ComponentType JGJOIHLLNGN;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6383BE0", Offset = "0x6382BE0", VA = "0x186383BE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct IODFDEFLOHH<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	[ReadOnly]
	public NativeArray<Entity> LEIOAKAEPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<T> GPKMLHOONCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer KNMGMKDDCAP;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3B19E40", Offset = "0x3B18E40", VA = "0x183B19E40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal struct HGLEPEMFJOE<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<Entity> LEIOAKAEPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<T> AGKDCPLPFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public EntityCommandBuffer KNMGMKDDCAP;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct LLKACACDGHE<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<Entity> LEIOAKAEPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public T LDGMLLMKHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public EntityCommandBuffer KNMGMKDDCAP;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3E43A10", Offset = "0x3E42A10", VA = "0x183E43A10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BurstCompile]
internal struct GKLBFMENGGF<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, MAMFKEAGJIO<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[ReadOnly]
	public NativeArray<TFrom> GOFIEMPPEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[WriteOnly]
	public NativeArray<TTo> DFCOLLIKHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public TMap LNMJHEPMAAO;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct GPAHADPKKBP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[ReadOnly]
	public ComponentDataFromEntity ECBOHEHIIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<Entity> GOFIEMPPEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<byte> DFCOLLIKHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int IJEFEIPJIPG;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6383DC0", Offset = "0x6382DC0", VA = "0x186383DC0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct EFKPKIAEEIE<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity<T> FEHLNIJIOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> GOFIEMPPEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeList<T> KHBBLMHOLDC;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct AJGLJAKCMCN<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, MAMFKEAGJIO<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public NativeArray<TFrom> BKCKBMPGNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[WriteOnly]
	public NativeList<TTo> DFCOLLIKHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public TMap LNMJHEPMAAO;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct INMJPLGHNMG<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public ComponentDataFromEntity<T> JBEOOMFKBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<Entity> PGFKCPFBPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<bool> AFANJADABIE;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct DNDKFLEECFL<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ComponentDataFromEntity<T> JBEOOMFKBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public NativeArray<Entity> PGFKCPFBPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public NativeArray<bool> AFANJADABIE;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5219D90", Offset = "0x5218D90", VA = "0x185219D90", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct AGAIEDAJACL<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<T> GOFIEMPPEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeList<T> KHBBLMHOLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeParallelHashSet<T> CIHLNHKCPAD;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x395D210", Offset = "0x395C210", VA = "0x18395D210", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct DDPHABLEJEN<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : MAMFKEAGJIO<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public NativeArray<TFrom> GOFIEMPPEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeList<TFrom> KHBBLMHOLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeParallelHashSet<TTo> CIHLNHKCPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public TMap LNMJHEPMAAO;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct NKBPGGBPMME<T, TPredicate> : IJob where T : struct where TPredicate : struct, JLPEGBJPINE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<T> GOFIEMPPEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public NativeArray<Entity> MPNFPFDLNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeList<Entity> LMNDHOAGNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TPredicate LNMJHEPMAAO;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x40BDCF0", Offset = "0x40BCCF0", VA = "0x1840BDCF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct BGJMCNFODCA<T, TPredicate> : IJob where T : struct where TPredicate : struct, JLPEGBJPINE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> GOFIEMPPEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public NativeList<T> KHBBLMHOLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public TPredicate LNMJHEPMAAO;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct IEHABFHEKBC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public ComponentDataFromEntity JBEOOMFKBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<Entity> PGFKCPFBPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<Entity> EGAJIFPIALP;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6384450", Offset = "0x6383450", VA = "0x186384450", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct KNPCAKHBIPC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[ReadOnly]
	public ComponentDataFromEntity JBEOOMFKBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<Entity> PGFKCPFBPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<Entity> EGAJIFPIALP;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x63844F0", Offset = "0x63834F0", VA = "0x1863844F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class JIMMECBAMMK
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class EBJOMEMEMBE
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x275F630", Offset = "0x275E630", VA = "0x18275F630")]
	public static bool EFOHAPGKLNB<T>(this NativeArray<Entity> PGFKCPFBPPH, EntityManager BKPACEIFJEG, Allocator NFBFCGHLHAF = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class MBHPIGMALGM
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class LLADEDKFMDA<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		public LLADEDKFMDA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class CCFPHGCCNLF<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		public CCFPHGCCNLF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<Func<JobHandle, JobHandle>> BPPAFEPGJGG;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6384580", Offset = "0x6383580", VA = "0x186384580")]
	public MBHPIGMALGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class EANBCGNFANF
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class AEBDLLIBELP
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct DCKJDFMEBNG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct NGMCEAHCHME<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			internal DCKJDFMEBNG<TFrom> NNHBJFPLAAA;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal Allocator NFBFCGHLHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal NativeArray<TFrom> KFMGLDNFPAF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct GGOEIECDPPE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct GEEHNKDMEJO<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			internal GGOEIECDPPE<TFrom> NNHBJFPLAAA;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal Allocator NFBFCGHLHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal NativeList<TFrom> KFMGLDNFPAF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct GEAJCAODEDK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct JJJNPGPMFDG<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			internal GEAJCAODEDK<TFrom> NNHBJFPLAAA;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal Allocator NFBFCGHLHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal NativeArrayAsync<TFrom> KFMGLDNFPAF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct BGMIBPCFGKC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct JGNMNAKKCOC<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			internal BGMIBPCFGKC<TFrom> NNHBJFPLAAA;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal Allocator NFBFCGHLHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal NativeListAsync<TFrom> KFMGLDNFPAF;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class MDHAMLJJDCC
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class BINOGLGAKMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x26BA8D0", Offset = "0x26B98D0", VA = "0x1826BA8D0")]
	public static NativeList<T> MDJBKACFODN<T>(this NativeArray<T> BFMIAAGKDCA, Allocator NFBFCGHLHAF = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class LMJALFAAIDK
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class IAHAIMBBKBH
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x28F7920", Offset = "0x28F6920", VA = "0x1828F7920")]
	[KAMPHHHPMGG]
	public static JobHandle CFKHIJFBHIO<T>(this EntityCommandBufferSystem IPMNKGLLGHE, NativeArrayAsync<Entity> LEIOAKAEPIN, NativeArrayAsync<T> GPKMLHOONCL, [Optional] JobHandle JGKAKAKNMCO) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x28F7A80", Offset = "0x28F6A80", VA = "0x1828F7A80")]
	[KAMPHHHPMGG]
	public static JobHandle CFKHIJFBHIO<T>(this EntityCommandBufferSystem IPMNKGLLGHE, NativeArrayAsync<Entity> LEIOAKAEPIN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x28F7800", Offset = "0x28F6800", VA = "0x1828F7800")]
	[KAMPHHHPMGG]
	public static JobHandle CFKHIJFBHIO<T>(this EntityCommandBufferSystem IPMNKGLLGHE, NativeArray<Entity> LEIOAKAEPIN, [Optional] JobHandle JGKAKAKNMCO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6384150", Offset = "0x6383150", VA = "0x186384150")]
	[KAMPHHHPMGG]
	public static JobHandle CFKHIJFBHIO(this EntityCommandBufferSystem IPMNKGLLGHE, NativeArray<Entity> LEIOAKAEPIN, ComponentTypes JDBNMFNILOF, [Optional] JobHandle JGKAKAKNMCO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x63842C0", Offset = "0x63832C0", VA = "0x1863842C0")]
	[KAMPHHHPMGG]
	public static JobHandle CFKHIJFBHIO(this EntityCommandBufferSystem IPMNKGLLGHE, EntityCommandBuffer KNMGMKDDCAP, NativeArray<Entity> LEIOAKAEPIN, ComponentTypes JDBNMFNILOF, [Optional] JobHandle JGKAKAKNMCO)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class JFKJEGIACMA
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2937FA0", Offset = "0x2936FA0", VA = "0x182937FA0")]
	[KAMPHHHPMGG]
	public static JobHandle DEHNGKODBOL<T>(this EntityCommandBufferSystem IPMNKGLLGHE, EntityCommandBuffer KNMGMKDDCAP, EntityQuery FOBNGMIEJJH, T LDGMLLMKHLF) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class HAMEDOPHPKC
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6383FC0", Offset = "0x6382FC0", VA = "0x186383FC0")]
	[KAMPHHHPMGG]
	public static JobHandle KHKNAADBDEE(this EntityCommandBufferSystem IPMNKGLLGHE, NativeList<Entity> LEIOAKAEPIN, [Optional] JobHandle JGKAKAKNMCO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6383EC0", Offset = "0x6382EC0", VA = "0x186383EC0")]
	[KAMPHHHPMGG]
	public static JobHandle KHKNAADBDEE(this EntityCommandBufferSystem IPMNKGLLGHE, NativeArrayAsync<Entity> LEIOAKAEPIN)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class AGAJMBAPMLB
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2F14720", Offset = "0x2F13720", VA = "0x182F14720")]
	public static void BEFFAPNJMAD<T>(this EntityCommandBufferSystem IPMNKGLLGHE, EntityQuery FOBNGMIEJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2F14C80", Offset = "0x2F13C80", VA = "0x182F14C80")]
	[KAMPHHHPMGG]
	public static JobHandle NHJHBBPEAFM<T>(this EntityCommandBufferSystem IPMNKGLLGHE, NativeListAsync<Entity> LEIOAKAEPIN, [Optional] JobHandle JGKAKAKNMCO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2F14AF0", Offset = "0x2F13AF0", VA = "0x182F14AF0")]
	[KAMPHHHPMGG]
	public static JobHandle NHJHBBPEAFM<T>(this EntityCommandBufferSystem IPMNKGLLGHE, NativeArrayAsync<Entity> LEIOAKAEPIN, [Optional] JobHandle JGKAKAKNMCO)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class GJNFKPHMHEG
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x28BC4E0", Offset = "0x28BB4E0", VA = "0x1828BC4E0")]
	[KAMPHHHPMGG]
	public static JobHandle EIEBOFJEGHJ<T>(this EntityCommandBufferSystem IPMNKGLLGHE, NativeArray<Entity> LEIOAKAEPIN, NativeArray<T> GPKMLHOONCL, JobHandle JGKAKAKNMCO) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class FPJJFBDPPKM
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x28B0790", Offset = "0x28AF790", VA = "0x1828B0790")]
	[KAMPHHHPMGG]
	public static JobHandle GGMFLIBLIMI<T>(this EntityCommandBufferSystem IPMNKGLLGHE, NativeArray<Entity> LEIOAKAEPIN, T LDGMLLMKHLF, [Optional] JobHandle JGKAKAKNMCO) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x28B0870", Offset = "0x28AF870", VA = "0x1828B0870")]
	[KAMPHHHPMGG]
	public static JobHandle GGMFLIBLIMI<T>(this EntityCommandBufferSystem IPMNKGLLGHE, EntityCommandBuffer KNMGMKDDCAP, NativeArray<Entity> LEIOAKAEPIN, T LDGMLLMKHLF, [Optional] JobHandle JGKAKAKNMCO) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class MEIAJAHJIIG
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class MDPIHHGHFFF
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2976670", Offset = "0x2975670", VA = "0x182976670")]
	public static NativeArray<T> JHJLHBGKHLC<T>(this NativeList<Entity> BFMIAAGKDCA, EntityManager BKPACEIFJEG, Allocator NFBFCGHLHAF = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x29762F0", Offset = "0x29752F0", VA = "0x1829762F0")]
	public static NativeArray<T> JHJLHBGKHLC<T>(this NativeArray<Entity> BFMIAAGKDCA, EntityManager BKPACEIFJEG, Allocator NFBFCGHLHAF = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6384610", Offset = "0x6383610", VA = "0x186384610")]
	public static NativeArray<Entity> OIJCLBFOELF(this NativeArray<Entity> BFMIAAGKDCA, EntityManager BKPACEIFJEG, ComponentType JGJOIHLLNGN, Allocator NFBFCGHLHAF = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2976210", Offset = "0x2975210", VA = "0x182976210")]
	public static NativeArray<T> IFBGDANPFGI<T>(this NativeArray<Entity> BFMIAAGKDCA, EntityManager BKPACEIFJEG, Allocator NFBFCGHLHAF = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class OGDOJPGHABF
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct HOHMHJGLIBM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct HAEOGIOFIMO<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public HOHMHJGLIBM<TFrom> KFMGLDNFPAF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public Allocator NFBFCGHLHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeArray<TFrom> GOFIEMPPEBK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct KIIFLHCFHDF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct LIBJOANBFPF<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public KIIFLHCFHDF<TFrom> KFMGLDNFPAF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Allocator NFBFCGHLHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeArrayAsync<TFrom> GOFIEMPPEBK;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct IHKAGKPGCMD<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct NHLNKBJNNMP<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public IHKAGKPGCMD<TFrom> KFMGLDNFPAF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Allocator NFBFCGHLHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public NativeListAsync<TFrom> GOFIEMPPEBK;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class MCCOOKHPKDN
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class OGEPIKFDFAN
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct OKOMFHOLNAK : MAMFKEAGJIO<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> IHBKPAJPPIH;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x63848E0", Offset = "0x63838E0", VA = "0x1863848E0")]
		[BurstCompatible]
		public Entity HKFENHIPJKG([In] Entity LDGMLLMKHLF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x63848E0", Offset = "0x63838E0", VA = "0x1863848E0", Slot = "4")]
		private Entity PCMBINDOMGP([In] Entity LDGMLLMKHLF)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class FMJAKMEGKGO
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct JCPDAJNIGCE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator NFBFCGHLHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeArray<Entity> MPNFPFDLNJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<T> GOFIEMPPEBK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct GOABCCMINLJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Allocator NFBFCGHLHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<Entity> MPNFPFDLNJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<T> GOFIEMPPEBK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct KHOBIKINHBC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Allocator NFBFCGHLHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArrayAsync<Entity> MPNFPFDLNJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArrayAsync<T> GOFIEMPPEBK;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x27CD500", Offset = "0x27CC500", VA = "0x1827CD500")]
		public NativeListAsync<Entity> NOPDHFPAIPJ<TPredicate>() where TPredicate : struct, JLPEGBJPINE<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x28A78A0", Offset = "0x28A68A0", VA = "0x1828A78A0")]
	public static KHOBIKINHBC<T> HPMJKLOPCMI<T>(this NativeArrayAsync<Entity> PGFKCPFBPPH, NativeArrayAsync<T> BFMIAAGKDCA, Allocator NFBFCGHLHAF = Allocator.TempJob) where T : struct
	{
		return default(KHOBIKINHBC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class MJOGEJFCAOM
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2988FE0", Offset = "0x2987FE0", VA = "0x182988FE0")]
	public static NativeListAsync<Entity> JFGNBPPACPC<T, TPredicate>(this NativeArrayAsync<T> BFMIAAGKDCA, NativeArrayAsync<Entity> PGFKCPFBPPH, Allocator NFBFCGHLHAF = Allocator.TempJob) where T : struct where TPredicate : struct, JLPEGBJPINE<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2988E40", Offset = "0x2987E40", VA = "0x182988E40")]
	private static NativeListAsync<Entity> BBLJABCGLAM<T, TPredicate>(NativeArrayAsync<T> CAPGGFLMOPJ, NativeArrayAsync<Entity> PGFKCPFBPPH, int GOKGFKKLOOJ, Allocator NFBFCGHLHAF) where T : struct where TPredicate : struct, JLPEGBJPINE<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class JDFAFOBDNBG
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct FCLNMLPLIGD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Allocator NFBFCGHLHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public NativeArray<T> GOFIEMPPEBK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct GDHPFDJGOAN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator NFBFCGHLHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeList<T> GOFIEMPPEBK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct GHNJLIAOJKN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator NFBFCGHLHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArrayAsync<T> GOFIEMPPEBK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct LHKMLBOPBGI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator NFBFCGHLHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeListAsync<T> GOFIEMPPEBK;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class OPDDKNLHPCI
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class FPBGHHACINN
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x28B0110", Offset = "0x28AF110", VA = "0x1828B0110")]
	public static NativeList<Entity> CHIALEALNCN<T>(this NativeArray<Entity> PGFKCPFBPPH, EntityManager BKPACEIFJEG, Allocator NFBFCGHLHAF = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class BMCCIOLNJGF
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class KCDBGAAHJPC
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public readonly struct NFLELPLMDGA<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly NativeArray<TSrc> PAFIMPMPKHD;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1E41B40", Offset = "0x1E40B40", VA = "0x181E41B40")]
		public NFLELPLMDGA(NativeArray<TSrc> PAFIMPMPKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x890FB0", Offset = "0x88FFB0", VA = "0x180890FB0")]
		public BPPIMMHOIHH<TSrc, TValue> EOMHAFAONFM<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(BPPIMMHOIHH<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct BPPIMMHOIHH<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NativeArray<TSrc> PAFIMPMPKHD;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1E41B40", Offset = "0x1E40B40", VA = "0x181E41B40")]
		public BPPIMMHOIHH(NativeArray<TSrc> PAFIMPMPKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x890FB0", Offset = "0x88FFB0", VA = "0x180890FB0")]
		public EONANLDHANF<TSrc, TValue, TSelector> ELPFPFDOKNE<TSelector>() where TSelector : struct, MAMFKEAGJIO<TSrc, TValue>
		{
			return default(EONANLDHANF<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct EONANLDHANF<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, MAMFKEAGJIO<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> PAFIMPMPKHD;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1E41B40", Offset = "0x1E40B40", VA = "0x181E41B40")]
		public EONANLDHANF(NativeArray<TSrc> PAFIMPMPKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3538530", Offset = "0x3537530", VA = "0x183538530")]
		public JOBHMHPFMII<TSrc, TValue, TSelector> CHIMHHNDKPE()
		{
			return default(JOBHMHPFMII<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct EGAFDAEIGNM<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, MAMFKEAGJIO<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> PAFIMPMPKHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TSelector FLFINEBGODE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int GPEHCABDGEJ;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TValue DGGBFKFKJBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x350B650", Offset = "0x350A650", VA = "0x18350B650")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int CBOGBOOIKCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA5CB80", Offset = "0xA5BB80", VA = "0x180A5CB80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int GBPKIPDCGGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1E64090", Offset = "0x1E63090", VA = "0x181E64090")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x350B7D0", Offset = "0x350A7D0", VA = "0x18350B7D0")]
		public EGAFDAEIGNM(NativeArray<TSrc> PAFIMPMPKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x350B7C0", Offset = "0x350A7C0", VA = "0x18350B7C0")]
		public bool IICKNEMONBO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x350B6E0", Offset = "0x350A6E0", VA = "0x18350B6E0")]
		private TSrc DIPEJLFDPHF(int AFFJDCKHCJD)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct JOBHMHPFMII<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, MAMFKEAGJIO<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private EGAFDAEIGNM<TSrc, TValue, TSelector> ABNJJAFLONB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TValue EEOBMCAOBNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private int GOABEOHPNBP;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public KGLAONMICFP HGHBHJNCDPO
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x3D18980", Offset = "0x3D17980", VA = "0x183D18980")]
			get
			{
				return default(KGLAONMICFP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue FIJIPJBPDFC
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7C5830", Offset = "0x7C4830", VA = "0x1807C5830")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, KGLAONMICFP range) DGGBFKFKJBG
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x3D18760", Offset = "0x3D17760", VA = "0x183D18760")]
			get
			{
				return default((TValue, KGLAONMICFP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3D189C0", Offset = "0x3D179C0", VA = "0x183D189C0")]
		public JOBHMHPFMII(NativeArray<TSrc> PAFIMPMPKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x38994F0", Offset = "0x38984F0", VA = "0x1838994F0")]
		public JOBHMHPFMII<TSrc, TValue, TSelector> IEKFBOGGJFJ()
		{
			return default(JOBHMHPFMII<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3D18840", Offset = "0x3D17840", VA = "0x183D18840")]
		public bool IICKNEMONBO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x294E0D0", Offset = "0x294D0D0", VA = "0x18294E0D0")]
	public static NFLELPLMDGA<T> BBHLHOLGNEJ<T>(this NativeList<T> FKIBLLNGEAG) where T : struct
	{
		return default(NFLELPLMDGA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x890FB0", Offset = "0x88FFB0", VA = "0x180890FB0")]
	public static NFLELPLMDGA<T> BBHLHOLGNEJ<T>(this NativeArray<T> PAFIMPMPKHD) where T : struct
	{
		return default(NFLELPLMDGA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class DNGDDFNMBHG
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct LJMFEGCGGMN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly NativeArray<T>.ReadOnly PAFIMPMPKHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int GOABEOHPNBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int FGIJLDPEIDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private T EEOBMCAOBNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T KFHMMEMHMDH;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public KGLAONMICFP HGHBHJNCDPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x3E3AFF0", Offset = "0x3E39FF0", VA = "0x183E3AFF0")]
			get
			{
				return default(KGLAONMICFP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T FIJIPJBPDFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x358FC20", Offset = "0x358EC20", VA = "0x18358FC20")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, KGLAONMICFP) DGGBFKFKJBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x3E3AB30", Offset = "0x3E39B30", VA = "0x183E3AB30")]
			get
			{
				return default((T, KGLAONMICFP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3E3B000", Offset = "0x3E3A000", VA = "0x183E3B000")]
		public LJMFEGCGGMN(NativeArray<T> PAFIMPMPKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3E3AC00", Offset = "0x3E39C00", VA = "0x183E3AC00")]
		public LJMFEGCGGMN<T> IEKFBOGGJFJ()
		{
			return default(LJMFEGCGGMN<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3E3AC40", Offset = "0x3E39C40", VA = "0x183E3AC40")]
		public bool IICKNEMONBO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x27CF610", Offset = "0x27CE610", VA = "0x1827CF610")]
		public CEOPOLMNMCJ<T, TComparer> IELFJJJBPAG<TComparer>([Optional] TComparer EEFJBELNPIK) where TComparer : struct, IEqualityComparer<T>
		{
			return default(CEOPOLMNMCJ<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct CEOPOLMNMCJ<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly NativeArray<T>.ReadOnly PAFIMPMPKHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int GOABEOHPNBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int FGIJLDPEIDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T EEOBMCAOBNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private T KFHMMEMHMDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TComparer EEFJBELNPIK;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public KGLAONMICFP HGHBHJNCDPO
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x3E3AFF0", Offset = "0x3E39FF0", VA = "0x183E3AFF0")]
			get
			{
				return default(KGLAONMICFP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T FIJIPJBPDFC
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x358FC20", Offset = "0x358EC20", VA = "0x18358FC20")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x4BE4FA0", Offset = "0x4BE3FA0", VA = "0x184BE4FA0")]
		public CEOPOLMNMCJ(NativeArray<T>.ReadOnly PAFIMPMPKHD, TComparer EEFJBELNPIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4BE4DC0", Offset = "0x4BE3DC0", VA = "0x184BE4DC0")]
		public bool IICKNEMONBO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x2746D80", Offset = "0x2745D80", VA = "0x182746D80")]
	public static LJMFEGCGGMN<T> CHIMHHNDKPE<T>(this NativeArray<T> PAFIMPMPKHD) where T : struct
	{
		return default(LJMFEGCGGMN<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface CGJHDEJKNJE
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class PDEAGIIKHDO
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct OOGDIGHJOMI<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class OLOMPMKNNLE : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public OOGDIGHJOMI<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xAE6AD0", Offset = "0xAE5AD0", VA = "0x180AE6AD0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x3908590", Offset = "0x3907590", VA = "0x183908590", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C1AC0", VA = "0x1807C2AC0")]
		[DebuggerHidden]
		public OLOMPMKNNLE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x41EA590", Offset = "0x41E9590", VA = "0x1841EA590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x41EA740", Offset = "0x41E9740", VA = "0x1841EA740", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly Action<Protobuf> ABMPKGEDDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly MemoryStream FEMBCGGKAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly CodedInputStream HDIFFMGAKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Protobuf MOOOFCHMDDO;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int GBPKIPDCGGG
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x96ECB0", Offset = "0x96DCB0", VA = "0x18096ECB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x41ECCC0", Offset = "0x41EBCC0", VA = "0x1841ECCC0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x41ECD00", Offset = "0x41EBD00", VA = "0x1841ECD00", Slot = "4")]
	[IteratorStateMachine(typeof(OOGDIGHJOMI<>.OLOMPMKNNLE))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x41ECDF0", Offset = "0x41EBDF0", VA = "0x1841ECDF0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct HOJADEKLMKJ<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly byte[] IDAJCEMIFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Protobuf MOOOFCHMDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly MemoryStream FEMBCGGKAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly CodedOutputStream NNIOCPDIDAI;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3A44650", Offset = "0x3A43650", VA = "0x183A44650", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct ICDNKKHJOAG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MemoryStream FEMBCGGKAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CodedInputStream HDIFFMGAKMN;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6384410", Offset = "0x6383410", VA = "0x186384410", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct CJBJNGHDHJN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly byte[] IDAJCEMIFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream FEMBCGGKAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedOutputStream NNIOCPDIDAI;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6383990", Offset = "0x6382990", VA = "0x186383990", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class FIJHCMFIGLM
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class DIAJCJOGKPJ
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Flags]
public enum OEMFBIKHFIA
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
internal static class OEANKBGDNGE
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class CKEHPJAMLMC
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public CKEHPJAMLMC()
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
