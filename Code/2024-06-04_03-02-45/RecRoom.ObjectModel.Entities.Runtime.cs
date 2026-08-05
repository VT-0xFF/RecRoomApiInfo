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
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x693FC50", Offset = "0x693E450", VA = "0x18693FC50")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OCABEDPNOFO : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	APEEKCJGOHE EIFODBLDLBO
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
public interface NLCKKNPCGNK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CIABFNINDNF(Entity JIPIEBFBEML, object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FCMHGDCJJJF(Entity JIPIEBFBEML, object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NHBHNCLDAMJ(Entity JIPIEBFBEML);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class BCKCHOLBGAN<TComponentData, TValue> : HPBEEPPFOBA<TValue>, IDisposable where TComponentData : struct, OCABEDPNOFO
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class IDKDGKDGPKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> MAKDKEMHGGE;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int HJCFDKBBGAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x34C1040", Offset = "0x34BF840", VA = "0x1834C1040")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3D82DD0", Offset = "0x3D815D0", VA = "0x183D82DD0")]
		public bool MGPMEJOJKLP([Out] TValue IPHHABIKCHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3D82C20", Offset = "0x3D81420", VA = "0x183D82C20")]
		public void CNLMKNIMMKA(object OECMOOGGOOF, TValue IPHHABIKCHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3D82D10", Offset = "0x3D81510", VA = "0x183D82D10")]
		public bool GALPDKBCKMP(object OECMOOGGOOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3D82B20", Offset = "0x3D81320", VA = "0x183D82B20")]
		public int AEDBEMBEOJF(object OECMOOGGOOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3D82EE0", Offset = "0x3D816E0", VA = "0x183D82EE0")]
		public IDKDGKDGPKM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<IDKDGKDGPKM> ANAAFFHGJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private DILCIBMIILI<APEEKCJGOHE, IDKDGKDGPKM> CJIMLMKEAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager FHNEBBCLKID;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4D1B430", Offset = "0x4D19C30", VA = "0x184D1B430")]
	public BCKCHOLBGAN(EntityManager FHNEBBCLKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4D1AC40", Offset = "0x4D19440", VA = "0x184D1AC40", Slot = "4")]
	public void CIABFNINDNF(Entity JIPIEBFBEML, object OECMOOGGOOF, TValue IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4D1ADF0", Offset = "0x4D195F0", VA = "0x184D1ADF0", Slot = "5")]
	public bool FCMHGDCJJJF(Entity JIPIEBFBEML, object OECMOOGGOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4D1B100", Offset = "0x4D19900", VA = "0x184D1B100", Slot = "6")]
	public bool MGPMEJOJKLP(Entity JIPIEBFBEML, [Out] TValue IPHHABIKCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4D1ADD0", Offset = "0x4D195D0", VA = "0x184D1ADD0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4D1AB70", Offset = "0x4D19370", VA = "0x184D1AB70")]
	private void BLDFGNOPHHO(IDKDGKDGPKM MIJPBKKKKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4D1B220", Offset = "0x4D19A20", VA = "0x184D1B220")]
	private bool NDCMAMDHJAF(Entity JIPIEBFBEML, [Out] APEEKCJGOHE PFACKKBJPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4D1B000", Offset = "0x4D19800", VA = "0x184D1B000")]
	private void HEGKNMIBAJP(Entity JIPIEBFBEML, APEEKCJGOHE PFACKKBJPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4D1B410", Offset = "0x4D19C10", VA = "0x184D1B410")]
	private bool PDGBOFMNLAK(APEEKCJGOHE PFACKKBJPID, [Out] IDKDGKDGPKM MIJPBKKKKIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4D1B2E0", Offset = "0x4D19AE0", VA = "0x184D1B2E0")]
	private IDKDGKDGPKM NIFHDLHFOOP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HPBEEPPFOBA<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CIABFNINDNF(Entity JIPIEBFBEML, object OECMOOGGOOF, TValue IPHHABIKCHD);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FCMHGDCJJJF(Entity JIPIEBFBEML, object OECMOOGGOOF);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MGPMEJOJKLP(Entity JIPIEBFBEML, [Out] TValue IPHHABIKCHD);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct APEEKCJGOHE : POIKBLLOAII, IEquatable<APEEKCJGOHE>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly APEEKCJGOHE GKJEPKMOIEE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int CFDBFCCMKIM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8FC6D0", Offset = "0x8FAED0", VA = "0x1808FC6D0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA36A50", Offset = "0xA35250", VA = "0x180A36A50", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int BCBMJBGNDJN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x248EF50", Offset = "0x248D750", VA = "0x18248EF50", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5C84E60", Offset = "0x5C83660", VA = "0x185C84E60", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x693F5F0", Offset = "0x693DDF0", VA = "0x18693F5F0", Slot = "8")]
	public bool Equals(APEEKCJGOHE OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x693F640", Offset = "0x693DE40", VA = "0x18693F640", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class OHJCFOEEOMO<THasTokensTag> : NLCKKNPCGNK, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MMJHHDEPGMK LPJFGGMIIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, APEEKCJGOHE> BDNJAJDJKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> ANAAFFHGJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private DILCIBMIILI<APEEKCJGOHE, HashSet<object>> CJIMLMKEAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager FHNEBBCLKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem DCIPJFFEGJB;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4562540", Offset = "0x4560D40", VA = "0x184562540")]
	public OHJCFOEEOMO(EntityManager FHNEBBCLKID, EntityCommandBufferSystem DCIPJFFEGJB, MMJHHDEPGMK LJBFGAFMDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4560240", Offset = "0x455EA40", VA = "0x184560240", Slot = "4")]
	public bool CIABFNINDNF(Entity JIPIEBFBEML, object OECMOOGGOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4560EE0", Offset = "0x455F6E0", VA = "0x184560EE0", Slot = "5")]
	public bool FCMHGDCJJJF(Entity JIPIEBFBEML, object OECMOOGGOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4561C90", Offset = "0x4560490", VA = "0x184561C90", Slot = "6")]
	public bool NHBHNCLDAMJ(Entity JIPIEBFBEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4561E00", Offset = "0x4560600", VA = "0x184561E00", Slot = "8")]
	public bool NHBHNCLDAMJ(APEEKCJGOHE PFACKKBJPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4560790", Offset = "0x455EF90", VA = "0x184560790", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x455FED0", Offset = "0x455E6D0", VA = "0x18455FED0")]
	private void BLDFGNOPHHO(HashSet<object> MIJPBKKKKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4561A50", Offset = "0x4560250", VA = "0x184561A50")]
	private bool NDCMAMDHJAF(Entity JIPIEBFBEML, [Out] APEEKCJGOHE PFACKKBJPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4561750", Offset = "0x455FF50", VA = "0x184561750")]
	private bool LKPNMBPKPFB(Entity JIPIEBFBEML, [Out] APEEKCJGOHE PFACKKBJPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x455FCB0", Offset = "0x455E4B0", VA = "0x18455FCB0")]
	private void AMFBMDDNAOB(Entity JIPIEBFBEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4561580", Offset = "0x455FD80", VA = "0x184561580")]
	private void JNNECBDAEHK(Entity JIPIEBFBEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x45624A0", Offset = "0x4560CA0", VA = "0x1845624A0")]
	private void OCDOCDPPDBJ(Entity JIPIEBFBEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x45611E0", Offset = "0x455F9E0", VA = "0x1845611E0")]
	private void HEGKNMIBAJP(Entity JIPIEBFBEML, APEEKCJGOHE PFACKKBJPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4560970", Offset = "0x455F170", VA = "0x184560970")]
	private bool EGFMOHKPGOP(APEEKCJGOHE PFACKKBJPID, [Out] HashSet<object> MIJPBKKKKIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4562040", Offset = "0x4560840", VA = "0x184562040")]
	private HashSet<object> NIFHDLHFOOP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class DILAKFEFNAN
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct JGPJHMNDCPJ : BHFFHFFELGC<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6940060", Offset = "0x693E860", VA = "0x186940060")]
	public float KDAGPIIKDJI([In] float3 IPHHABIKCHD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6940060", Offset = "0x693E860", VA = "0x186940060", Slot = "4")]
	private float FNMFEFFCJOD([In] float3 IPHHABIKCHD)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct FLHGOIHDBDI : BHFFHFFELGC<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x693FE20", Offset = "0x693E620", VA = "0x18693FE20")]
	public float KDAGPIIKDJI([In] float3 IPHHABIKCHD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x693FE20", Offset = "0x693E620", VA = "0x18693FE20", Slot = "4")]
	private float FNMFEFFCJOD([In] float3 IPHHABIKCHD)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct GCIMGKPGPAI : BHFFHFFELGC<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1C63340", Offset = "0x1C61B40", VA = "0x181C63340")]
	public float KDAGPIIKDJI([In] float3 IPHHABIKCHD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1C63340", Offset = "0x1C61B40", VA = "0x181C63340", Slot = "4")]
	private float FNMFEFFCJOD([In] float3 IPHHABIKCHD)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct PLNBMGINNHL : BHFFHFFELGC<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x154BCE0", Offset = "0x154A4E0", VA = "0x18154BCE0")]
	public int KDAGPIIKDJI([In] int3 IPHHABIKCHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x154BCE0", Offset = "0x154A4E0", VA = "0x18154BCE0", Slot = "4")]
	private int IHFCCJKLDBF([In] int3 IPHHABIKCHD)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct IELOADFEJMI : BHFFHFFELGC<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x693FF10", Offset = "0x693E710", VA = "0x18693FF10")]
	public int KDAGPIIKDJI([In] int3 IPHHABIKCHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x693FF10", Offset = "0x693E710", VA = "0x18693FF10", Slot = "4")]
	private int IHFCCJKLDBF([In] int3 IPHHABIKCHD)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct CPDHLMHEOAJ : BHFFHFFELGC<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x184CC70", Offset = "0x184B470", VA = "0x18184CC70")]
	public int KDAGPIIKDJI([In] int3 IPHHABIKCHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x184CC70", Offset = "0x184B470", VA = "0x18184CC70", Slot = "4")]
	private int IHFCCJKLDBF([In] int3 IPHHABIKCHD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class EOMJCKGLAON : NBLDFFPFCFK
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1483A10", Offset = "0x1482210", VA = "0x181483A10")]
	public EOMJCKGLAON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class FLAENOFMIGE : SystemBase, KHPLDOIOAME
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x693FCE0", Offset = "0x693E4E0", VA = "0x18693FCE0")]
	public JobHandle DGDMLFELDMH(ReadOnlySpan<int> LIPHIIEJBAC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2A77D40", Offset = "0x2A76540", VA = "0x182A77D40")]
	public void BLLMDHBAMDI<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2A77560", Offset = "0x2A75D60", VA = "0x182A77560")]
	public JobHandle BLLMDHBAMDI<T>(JobHandle PFACKKBJPID)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x693FC70", Offset = "0x693E470", VA = "0x18693FC70")]
	public JobHandle BLLMDHBAMDI(ReadOnlySpan<int> LIPHIIEJBAC, JobHandle PFACKKBJPID)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2A77D40", Offset = "0x2A76540", VA = "0x182A77D40")]
	public void KIDCICHHLBK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2A78310", Offset = "0x2A76B10", VA = "0x182A78310")]
	public JobHandle KIDCICHHLBK<T>(JobHandle PFACKKBJPID)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x693FD30", Offset = "0x693E530", VA = "0x18693FD30")]
	public ComponentDataFromEntity FBBMJJDMMMM(int COMFAOIGFPJ, bool IBPCMECMNGO = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x693FDF0", Offset = "0x693E5F0", VA = "0x18693FDF0")]
	public EntityExistenceLookupByEntity MLJLACIGGDG()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x693FE10", Offset = "0x693E610", VA = "0x18693FE10", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1483A10", Offset = "0x1482210", VA = "0x181483A10")]
	protected FLAENOFMIGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class IFFIGDPNIEF : FLAENOFMIGE
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x693FF20", Offset = "0x693E720", VA = "0x18693FF20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1483A10", Offset = "0x1482210", VA = "0x181483A10")]
	protected IFFIGDPNIEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class FGOODAIMCGD
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class DDHBKPGLDKH : EntityCommandBufferSystem, KHPLDOIOAME
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1483A10", Offset = "0x1482210", VA = "0x181483A10")]
	protected DDHBKPGLDKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface BHFFHFFELGC<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo KDAGPIIKDJI([In] TFrom IPHHABIKCHD);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface FNPFGBCLPIJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EKPOJIILGHK(T IPHHABIKCHD);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BurstCompile]
internal struct EKHJMILECAD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[ReadOnly]
	public NativeArray<Entity> CLKMHECJDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public EntityCommandBuffer LOEJBHBBGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public ComponentTypes EGHDNBCHJOE;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x693F840", Offset = "0x693E040", VA = "0x18693F840", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct HNPFHKLDFIB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[ReadOnly]
	public NativeArray<Entity> CLKMHECJDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public EntityCommandBuffer LOEJBHBBGDN;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x693FE70", Offset = "0x693E670", VA = "0x18693FE70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct IHGEPGGFDDL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public NativeArray<Entity> CLKMHECJDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public EntityCommandBuffer LOEJBHBBGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public ComponentType JCHCKBIFPCG;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x693FF50", Offset = "0x693E750", VA = "0x18693FF50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct PCAKAHJGDKI<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	[ReadOnly]
	public NativeArray<Entity> CLKMHECJDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<T> MLKNGAFFKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer LOEJBHBBGDN;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x464E650", Offset = "0x464CE50", VA = "0x18464E650", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal struct HDAODIDNLDB<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<Entity> CLKMHECJDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<T> AHHBLMGMEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public EntityCommandBuffer LOEJBHBBGDN;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct IFHPDEGJNEN<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<Entity> CLKMHECJDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public T IPHHABIKCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public EntityCommandBuffer LOEJBHBBGDN;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3D89BA0", Offset = "0x3D883A0", VA = "0x183D89BA0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BurstCompile]
internal struct HMNBEHKLAGD<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, BHFFHFFELGC<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[ReadOnly]
	public NativeArray<TFrom> EIGKEKEJFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[WriteOnly]
	public NativeArray<TTo> LCDBEFBEHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public TMap BMOCGPMNBAF;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct OEIMLMCLFOD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[ReadOnly]
	public ComponentDataFromEntity OLCLOLOCJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<Entity> EIGKEKEJFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<byte> LCDBEFBEHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int ILKHMOFDLMB;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6940520", Offset = "0x693ED20", VA = "0x186940520", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct DNABEBEGBHB<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity<T> PKDLNPPCJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> EIGKEKEJFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeList<T> OMCOMPOMHHH;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct OFPLDLJOKNK<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, BHFFHFFELGC<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public NativeArray<TFrom> APDHAHFGMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[WriteOnly]
	public NativeList<TTo> LCDBEFBEHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public TMap BMOCGPMNBAF;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct HMBIMBJCGID<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public ComponentDataFromEntity<T> AHFGMABHBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<Entity> HBHJNMMADKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<bool> ONOFCIBLLGC;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct CHBMJPBCHEG<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ComponentDataFromEntity<T> AHFGMABHBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public NativeArray<Entity> HBHJNMMADKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public NativeArray<bool> ONOFCIBLLGC;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4F86950", Offset = "0x4F85150", VA = "0x184F86950", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct OFDCCEFEEBN<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<T> EIGKEKEJFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeList<T> OMCOMPOMHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeParallelHashSet<T> HHCGBAEONME;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4557BF0", Offset = "0x45563F0", VA = "0x184557BF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct JHFPNHLMPNI<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : BHFFHFFELGC<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public NativeArray<TFrom> EIGKEKEJFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeList<TFrom> OMCOMPOMHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeParallelHashSet<TTo> HHCGBAEONME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public TMap BMOCGPMNBAF;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct LKAEJGIHHJK<T, TPredicate> : IJob where T : struct where TPredicate : struct, FNPFGBCLPIJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<T> EIGKEKEJFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public NativeArray<Entity> DELLGJMNACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeList<Entity> BLBLIAHOLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TPredicate BMOCGPMNBAF;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct ONKGONEDCBF<T, TPredicate> : IJob where T : struct where TPredicate : struct, FNPFGBCLPIJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> EIGKEKEJFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public NativeList<T> OMCOMPOMHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public TPredicate BMOCGPMNBAF;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct ELFODKCKDML : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public ComponentDataFromEntity AHFGMABHBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<Entity> HBHJNMMADKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<Entity> JPJBDLMFGJA;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x693F930", Offset = "0x693E130", VA = "0x18693F930", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct BJJFLMEDNOK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[ReadOnly]
	public ComponentDataFromEntity AHFGMABHBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<Entity> HBHJNMMADKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<Entity> JPJBDLMFGJA;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x693F690", Offset = "0x693DE90", VA = "0x18693F690", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class BIKGLHCKDEH
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class AMABHMGOMML
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x314CD40", Offset = "0x314B540", VA = "0x18314CD40")]
	public static bool MDMNGAMDKJJ<T>(this NativeArray<Entity> HBHJNMMADKF, EntityManager FHNEBBCLKID, Allocator KCJKALFMGMC = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class JEOCMLCNPCC
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class ECIHGPJCBGP<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		public ECIHGPJCBGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class PDPFPGKHKAE<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		public PDPFPGKHKAE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<Func<JobHandle, JobHandle>> IEJFNKDBFBI;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x693FFD0", Offset = "0x693E7D0", VA = "0x18693FFD0")]
	public JEOCMLCNPCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class FLOMCKFPKKJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class OKMGGGOAHNG
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct JMKBOABDADC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct OJOLHIGEINN<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			internal JMKBOABDADC<TFrom> GGJNHHDMGON;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal Allocator KCJKALFMGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal NativeArray<TFrom> AMBKIFNGGDN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct OADIIHKOAIN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct DKENHJLAIIO<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			internal OADIIHKOAIN<TFrom> GGJNHHDMGON;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal Allocator KCJKALFMGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal NativeList<TFrom> AMBKIFNGGDN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct FMEMBBGHHJF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct KKPCMEGIIFN<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			internal FMEMBBGHHJF<TFrom> GGJNHHDMGON;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal Allocator KCJKALFMGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal NativeArrayAsync<TFrom> AMBKIFNGGDN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct JEMCIMMMOIF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct GJDNKIMLDEJ<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			internal JEMCIMMMOIF<TFrom> GGJNHHDMGON;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal Allocator KCJKALFMGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal NativeListAsync<TFrom> AMBKIFNGGDN;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class PCJEELGGNML
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class IKCNDMFAKEB
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2ACE500", Offset = "0x2ACCD00", VA = "0x182ACE500")]
	public static NativeList<T> AGEMJHMONIC<T>(this NativeArray<T> AOANMIEDBKF, Allocator KCJKALFMGMC = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class NEINPLOJKJN
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class KCHIAEPGMLP
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2B222B0", Offset = "0x2B20AB0", VA = "0x182B222B0")]
	[LJODHLMPCLG]
	public static JobHandle LJKEBJNJIFG<T>(this EntityCommandBufferSystem DCIPJFFEGJB, NativeArrayAsync<Entity> CLKMHECJDKN, NativeArrayAsync<T> MLKNGAFFKGE, [Optional] JobHandle LBNICNJJGEJ) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2B22560", Offset = "0x2B20D60", VA = "0x182B22560")]
	[LJODHLMPCLG]
	public static JobHandle LJKEBJNJIFG<T>(this EntityCommandBufferSystem DCIPJFFEGJB, NativeArrayAsync<Entity> CLKMHECJDKN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2B22430", Offset = "0x2B20C30", VA = "0x182B22430")]
	[LJODHLMPCLG]
	public static JobHandle LJKEBJNJIFG<T>(this EntityCommandBufferSystem DCIPJFFEGJB, NativeArray<Entity> CLKMHECJDKN, [Optional] JobHandle LBNICNJJGEJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x69401C0", Offset = "0x693E9C0", VA = "0x1869401C0")]
	[LJODHLMPCLG]
	public static JobHandle LJKEBJNJIFG(this EntityCommandBufferSystem DCIPJFFEGJB, NativeArray<Entity> CLKMHECJDKN, ComponentTypes EGHDNBCHJOE, [Optional] JobHandle LBNICNJJGEJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6940070", Offset = "0x693E870", VA = "0x186940070")]
	[LJODHLMPCLG]
	public static JobHandle LJKEBJNJIFG(this EntityCommandBufferSystem DCIPJFFEGJB, EntityCommandBuffer LOEJBHBBGDN, NativeArray<Entity> CLKMHECJDKN, ComponentTypes EGHDNBCHJOE, [Optional] JobHandle LBNICNJJGEJ)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class KMAIOMHPCDF
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2B2AC50", Offset = "0x2B29450", VA = "0x182B2AC50")]
	[LJODHLMPCLG]
	public static JobHandle GGPMKDPGPIP<T>(this EntityCommandBufferSystem DCIPJFFEGJB, EntityCommandBuffer LOEJBHBBGDN, EntityQuery HDPCBHKBDOG, T IPHHABIKCHD) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class EPJGPBDKCFE
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x693FAC0", Offset = "0x693E2C0", VA = "0x18693FAC0")]
	[LJODHLMPCLG]
	public static JobHandle KAGOHABGHMG(this EntityCommandBufferSystem DCIPJFFEGJB, NativeList<Entity> CLKMHECJDKN, [Optional] JobHandle LBNICNJJGEJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x693F9C0", Offset = "0x693E1C0", VA = "0x18693F9C0")]
	[LJODHLMPCLG]
	public static JobHandle KAGOHABGHMG(this EntityCommandBufferSystem DCIPJFFEGJB, NativeArrayAsync<Entity> CLKMHECJDKN)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class MILNBLIICLM
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class PKGAIGLEDBJ
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2C4DAE0", Offset = "0x2C4C2E0", VA = "0x182C4DAE0")]
	[LJODHLMPCLG]
	public static JobHandle MOKENHOEBEN<T>(this EntityCommandBufferSystem DCIPJFFEGJB, NativeArray<Entity> CLKMHECJDKN, NativeArray<T> MLKNGAFFKGE, JobHandle LBNICNJJGEJ) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class HMOMNLMKHPL
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2AB0240", Offset = "0x2AAEA40", VA = "0x182AB0240")]
	[LJODHLMPCLG]
	public static JobHandle EPIFNMHCIKG<T>(this EntityCommandBufferSystem DCIPJFFEGJB, NativeArray<Entity> CLKMHECJDKN, T IPHHABIKCHD, [Optional] JobHandle LBNICNJJGEJ) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2AB0160", Offset = "0x2AAE960", VA = "0x182AB0160")]
	[LJODHLMPCLG]
	public static JobHandle EPIFNMHCIKG<T>(this EntityCommandBufferSystem DCIPJFFEGJB, EntityCommandBuffer LOEJBHBBGDN, NativeArray<Entity> CLKMHECJDKN, T IPHHABIKCHD, [Optional] JobHandle LBNICNJJGEJ) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class DNHPJJAAKHF
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class MLGKMKGBGBD
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2B6F1B0", Offset = "0x2B6D9B0", VA = "0x182B6F1B0")]
	public static NativeArray<T> BJLGKJPACMD<T>(this NativeList<Entity> AOANMIEDBKF, EntityManager FHNEBBCLKID, Allocator KCJKALFMGMC = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2B6EC10", Offset = "0x2B6D410", VA = "0x182B6EC10")]
	public static NativeArray<T> BJLGKJPACMD<T>(this NativeArray<Entity> AOANMIEDBKF, EntityManager FHNEBBCLKID, Allocator KCJKALFMGMC = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6940340", Offset = "0x693EB40", VA = "0x186940340")]
	public static NativeArray<Entity> PDNOJKPNJIO(this NativeArray<Entity> AOANMIEDBKF, EntityManager FHNEBBCLKID, ComponentType JCHCKBIFPCG, Allocator KCJKALFMGMC = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2B6F280", Offset = "0x2B6DA80", VA = "0x182B6F280")]
	public static NativeArray<T> IAIHKJDHLIO<T>(this NativeArray<Entity> AOANMIEDBKF, EntityManager FHNEBBCLKID, Allocator KCJKALFMGMC = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class JEOKBJHDEKD
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct FIMFEGNOPHJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct ACDNEAOLDGO<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public FIMFEGNOPHJ<TFrom> AMBKIFNGGDN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public Allocator KCJKALFMGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeArray<TFrom> EIGKEKEJFGK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct GHOKOOEGGEI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct PFMNKKOAEHI<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public GHOKOOEGGEI<TFrom> AMBKIFNGGDN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Allocator KCJKALFMGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeArrayAsync<TFrom> EIGKEKEJFGK;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct OFIMBGLFAHG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct NKDJEHLBNKA<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public OFIMBGLFAHG<TFrom> AMBKIFNGGDN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Allocator KCJKALFMGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public NativeListAsync<TFrom> EIGKEKEJFGK;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class ILCEEHDHGIJ
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class DKPCODFCFPB
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct KCIOOHBAEIA : BHFFHFFELGC<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> AMHLOPCDEKG;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6940330", Offset = "0x693EB30", VA = "0x186940330")]
		[BurstCompatible]
		public Entity KDAGPIIKDJI([In] Entity IPHHABIKCHD)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6940330", Offset = "0x693EB30", VA = "0x186940330", Slot = "4")]
		private Entity CLMJNAFENOO([In] Entity IPHHABIKCHD)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class GLMKEJKJDOM
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct BJHIDOGCPKF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator KCJKALFMGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeArray<Entity> DELLGJMNACL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<T> EIGKEKEJFGK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct EKDJPAMICNB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Allocator KCJKALFMGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<Entity> DELLGJMNACL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<T> EIGKEKEJFGK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct KHEDJJIPAII<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Allocator KCJKALFMGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArrayAsync<Entity> DELLGJMNACL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArrayAsync<T> EIGKEKEJFGK;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class NPLHALIJDCB
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class DIFAKHBDBHM
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct KKOPFCHMDGD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Allocator KCJKALFMGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public NativeArray<T> EIGKEKEJFGK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct APFHODAPMMF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator KCJKALFMGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeList<T> EIGKEKEJFGK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct FHAPGEINAEC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator KCJKALFMGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArrayAsync<T> EIGKEKEJFGK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct NCIEGLKDJDA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator KCJKALFMGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeListAsync<T> EIGKEKEJFGK;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class KLMJBBCPIKH
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class KIJANIEMMME
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2B28A00", Offset = "0x2B27200", VA = "0x182B28A00")]
	public static NativeList<Entity> IKEKKEENCIM<T>(this NativeArray<Entity> HBHJNMMADKF, EntityManager FHNEBBCLKID, Allocator KCJKALFMGMC = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class EDFENHMPONE
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class EBGBLPHJBFI
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public readonly struct JAEIHLBNLBF<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly NativeArray<TSrc> JAOFFCELONG;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1F38BF0", Offset = "0x1F373F0", VA = "0x181F38BF0")]
		public JAEIHLBNLBF(NativeArray<TSrc> JAOFFCELONG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x999770", Offset = "0x997F70", VA = "0x180999770")]
		public ABGKAPOJFKO<TSrc, TValue> KJLJOGCCNGA<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(ABGKAPOJFKO<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct ABGKAPOJFKO<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NativeArray<TSrc> JAOFFCELONG;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1F38BF0", Offset = "0x1F373F0", VA = "0x181F38BF0")]
		public ABGKAPOJFKO(NativeArray<TSrc> JAOFFCELONG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x999770", Offset = "0x997F70", VA = "0x180999770")]
		public HLOGOAIKIHH<TSrc, TValue, TSelector> LEAEGPBAFOI<TSelector>() where TSelector : struct, BHFFHFFELGC<TSrc, TValue>
		{
			return default(HLOGOAIKIHH<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct HLOGOAIKIHH<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, BHFFHFFELGC<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> JAOFFCELONG;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1F38BF0", Offset = "0x1F373F0", VA = "0x181F38BF0")]
		public HLOGOAIKIHH(NativeArray<TSrc> JAOFFCELONG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3290", Offset = "0x3CB1A90", VA = "0x183CB3290")]
		public GCKKHAFNECH<TSrc, TValue, TSelector> GDDDCAPOMKO()
		{
			return default(GCKKHAFNECH<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct FFDNLJCCEOB<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, BHFFHFFELGC<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> JAOFFCELONG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TSelector BJEJABDCCOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int JBDLDJOINOF;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TValue APOKPICBEBA
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x3ADFB60", Offset = "0x3ADE360", VA = "0x183ADFB60")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int CFDBFCCMKIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8BAB10", Offset = "0x8B9310", VA = "0x1808BAB10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int FDFCDEPBPCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x1F5C7A0", Offset = "0x1F5AFA0", VA = "0x181F5C7A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3ADFD00", Offset = "0x3ADE500", VA = "0x183ADFD00")]
		public FFDNLJCCEOB(NativeArray<TSrc> JAOFFCELONG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3ADFBF0", Offset = "0x3ADE3F0", VA = "0x183ADFBF0")]
		public bool GJEIFFMFIAF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x3ADFC00", Offset = "0x3ADE400", VA = "0x183ADFC00")]
		private TSrc NMCNHKCBLOH(int JIAIKHGLBJE)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct GCKKHAFNECH<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, BHFFHFFELGC<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private FFDNLJCCEOB<TSrc, TValue, TSelector> PLIDPKHELGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TValue KMIPDFJKDEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private int JDPLFEPKJAC;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public OAOCAEFDLKO NDNPBCAGBED
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x3BC51F0", Offset = "0x3BC39F0", VA = "0x183BC51F0")]
			get
			{
				return default(OAOCAEFDLKO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue DAKFFGIPJKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x84F0B0", Offset = "0x84D8B0", VA = "0x18084F0B0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, OAOCAEFDLKO range) APOKPICBEBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x3BC5230", Offset = "0x3BC3A30", VA = "0x183BC5230")]
			get
			{
				return default((TValue, OAOCAEFDLKO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3BC5450", Offset = "0x3BC3C50", VA = "0x183BC5450")]
		public GCKKHAFNECH(NativeArray<TSrc> JAOFFCELONG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x374F980", Offset = "0x374E180", VA = "0x18374F980")]
		public GCKKHAFNECH<TSrc, TValue, TSelector> ALKLFOKMKDP()
		{
			return default(GCKKHAFNECH<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3BC5310", Offset = "0x3BC3B10", VA = "0x183BC5310")]
		public bool GJEIFFMFIAF()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2912C60", Offset = "0x2911460", VA = "0x182912C60")]
	public static JAEIHLBNLBF<T> OGEJICFFNLM<T>(this NativeList<T> MAKDKEMHGGE) where T : struct
	{
		return default(JAEIHLBNLBF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x999770", Offset = "0x997F70", VA = "0x180999770")]
	public static JAEIHLBNLBF<T> OGEJICFFNLM<T>(this NativeArray<T> JAOFFCELONG) where T : struct
	{
		return default(JAEIHLBNLBF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class EGADGKAOOJK
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct JOEJICPNMMM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly NativeArray<T>.ReadOnly JAOFFCELONG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int JDPLFEPKJAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int ADKNGCFBIEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private T KMIPDFJKDEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T MIGIMKHFCKG;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public OAOCAEFDLKO NDNPBCAGBED
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x375F0F0", Offset = "0x375D8F0", VA = "0x18375F0F0")]
			get
			{
				return default(OAOCAEFDLKO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T DAKFFGIPJKI
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x375F2F0", Offset = "0x375DAF0", VA = "0x18375F2F0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, OAOCAEFDLKO) APOKPICBEBA
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x3FB3200", Offset = "0x3FB1A00", VA = "0x183FB3200")]
			get
			{
				return default((T, OAOCAEFDLKO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3FB3750", Offset = "0x3FB1F50", VA = "0x183FB3750")]
		public JOEJICPNMMM(NativeArray<T> JAOFFCELONG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3FB31C0", Offset = "0x3FB19C0", VA = "0x183FB31C0")]
		public JOEJICPNMMM<T> ALKLFOKMKDP()
		{
			return default(JOEJICPNMMM<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x3FB3560", Offset = "0x3FB1D60", VA = "0x183FB3560")]
		public bool GJEIFFMFIAF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x299AC40", Offset = "0x2999440", VA = "0x18299AC40")]
		public ELFHNNFGBGE<T, TComparer> BCHOBEHJHLL<TComparer>([Optional] TComparer JDHEBDHHOMI) where TComparer : struct, IEqualityComparer<T>
		{
			return default(ELFHNNFGBGE<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct ELFHNNFGBGE<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly NativeArray<T>.ReadOnly JAOFFCELONG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int JDPLFEPKJAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int ADKNGCFBIEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T KMIPDFJKDEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private T MIGIMKHFCKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TComparer JDHEBDHHOMI;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public OAOCAEFDLKO NDNPBCAGBED
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x375F0F0", Offset = "0x375D8F0", VA = "0x18375F0F0")]
			get
			{
				return default(OAOCAEFDLKO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T DAKFFGIPJKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x375F2F0", Offset = "0x375DAF0", VA = "0x18375F2F0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x375F310", Offset = "0x375DB10", VA = "0x18375F310")]
		public ELFHNNFGBGE(NativeArray<T>.ReadOnly JAOFFCELONG, TComparer JDHEBDHHOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x375F100", Offset = "0x375D900", VA = "0x18375F100")]
		public bool GJEIFFMFIAF()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2917470", Offset = "0x2915C70", VA = "0x182917470")]
	public static JOEJICPNMMM<T> GDDDCAPOMKO<T>(this NativeArray<T> JAOFFCELONG) where T : struct
	{
		return default(JOEJICPNMMM<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface CDLJFCBHEBO
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class GJOIMDNGADP
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct OCHBABHMJHD<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class JPKMDMHIFMF : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public OCHBABHMJHD<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xBF3DE0", Offset = "0xBF25E0", VA = "0x180BF3DE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3B2FE50", Offset = "0x3B2E650", VA = "0x183B2FE50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x848DF0", Offset = "0x8475F0", VA = "0x180848DF0")]
		[DebuggerHidden]
		public JPKMDMHIFMF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3FB6460", Offset = "0x3FB4C60", VA = "0x183FB6460", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3FB6640", Offset = "0x3FB4E40", VA = "0x183FB6640", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly Action<Protobuf> GAALHBKNPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly MemoryStream JMDMENEIBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly CodedInputStream NOFOKMEHOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Protobuf FJADDONBCKL;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int FDFCDEPBPCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8B89F0", Offset = "0x8B71F0", VA = "0x1808B89F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4545DC0", Offset = "0x45445C0", VA = "0x184545DC0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4545E00", Offset = "0x4544600", VA = "0x184545E00", Slot = "4")]
	[IteratorStateMachine(typeof(OCHBABHMJHD<>.JPKMDMHIFMF))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4545F00", Offset = "0x4544700", VA = "0x184545F00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct AOAJDJCFOGJ<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly byte[] PAJEBKJPIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Protobuf FJADDONBCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly MemoryStream JMDMENEIBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly CodedOutputStream OAOEADIOIHL;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3C564B0", Offset = "0x3C54CB0", VA = "0x183C564B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct GDGIELGHJCP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MemoryStream JMDMENEIBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CodedInputStream NOFOKMEHOMD;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x693FE30", Offset = "0x693E630", VA = "0x18693FE30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct ECEAGDICIKK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly byte[] PAJEBKJPIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream JMDMENEIBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedOutputStream OAOEADIOIHL;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x693F720", Offset = "0x693DF20", VA = "0x18693F720", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class JKBAACFFAKN
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class MDBFLGOLKMM
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Flags]
public enum ODALDGBBAFD
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
internal static class GGCFLEPJGJJ
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class CBIBAIGKJBN
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public CBIBAIGKJBN()
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
