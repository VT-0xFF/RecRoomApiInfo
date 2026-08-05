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
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x62C0C50", Offset = "0x62BFE50", VA = "0x1862C0C50")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EKMIDNDKGON : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	AMNPIJKABKO KFEHFNEHCEC
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
public interface PBOPLJFOHPG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OMFFIGABJON(Entity NFFCGLFHPNG, object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LKCLAEPLNDJ(Entity NFFCGLFHPNG, object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EBHMAIEOIGN(Entity NFFCGLFHPNG);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DMBHFEDJIAD(Entity NFFCGLFHPNG);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class KEEPHOEEDBP<TComponentData, TValue> : CBBMHEMGMFN<TValue>, IDisposable where TComponentData : struct, EKMIDNDKGON
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class GDDBKHHOANF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> JLCIFHJMGPA;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int PIKJCOKEANP
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x3287A60", Offset = "0x3286C60", VA = "0x183287A60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x38A7660", Offset = "0x38A6860", VA = "0x1838A7660")]
		public bool HEEKPDMMONK([Out] TValue NICEPFIEJED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x38A77B0", Offset = "0x38A69B0", VA = "0x1838A77B0")]
		public void OEOPOJPHCNL(object FCKLPDKGPKE, TValue NICEPFIEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x38A7730", Offset = "0x38A6930", VA = "0x1838A7730")]
		public bool MFEEKLGJAPH(object FCKLPDKGPKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x38A7580", Offset = "0x38A6780", VA = "0x1838A7580")]
		public int ABLINEPLCMF(object FCKLPDKGPKE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x38A7860", Offset = "0x38A6A60", VA = "0x1838A7860")]
		public GDDBKHHOANF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<GDDBKHHOANF> IOGAFPFIAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private OGBPLMAHFKA<AMNPIJKABKO, GDDBKHHOANF> LFCBFADCPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager LMKGBBMBMBN;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3C71C10", Offset = "0x3C70E10", VA = "0x183C71C10")]
	public KEEPHOEEDBP(EntityManager LMKGBBMBMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3C71AF0", Offset = "0x3C70CF0", VA = "0x183C71AF0", Slot = "4")]
	public void OMFFIGABJON(Entity NFFCGLFHPNG, object FCKLPDKGPKE, TValue NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3C71970", Offset = "0x3C70B70", VA = "0x183C71970", Slot = "5")]
	public bool LKCLAEPLNDJ(Entity NFFCGLFHPNG, object FCKLPDKGPKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3C71800", Offset = "0x3C70A00", VA = "0x183C71800", Slot = "6")]
	public bool HEEKPDMMONK(Entity NFFCGLFHPNG, [Out] TValue NICEPFIEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3C71650", Offset = "0x3C70850", VA = "0x183C71650", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3C718E0", Offset = "0x3C70AE0", VA = "0x183C718E0")]
	private void JFLFAFOODCM(GDDBKHHOANF DFDDJJGLJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3C71670", Offset = "0x3C70870", VA = "0x183C71670")]
	private bool EODECKGHEIH(Entity NFFCGLFHPNG, [Out] AMNPIJKABKO EIKDEMMADOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3C71720", Offset = "0x3C70920", VA = "0x183C71720")]
	private void GFJDOOONKBK(Entity NFFCGLFHPNG, AMNPIJKABKO EIKDEMMADOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3C71630", Offset = "0x3C70830", VA = "0x183C71630")]
	private bool DOICFKMGHMA(AMNPIJKABKO EIKDEMMADOB, [Out] GDDBKHHOANF DFDDJJGLJIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3C71550", Offset = "0x3C70750", VA = "0x183C71550")]
	private GDDBKHHOANF CBPLIPJGOKH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CBBMHEMGMFN<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OMFFIGABJON(Entity NFFCGLFHPNG, object FCKLPDKGPKE, TValue NICEPFIEJED);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LKCLAEPLNDJ(Entity NFFCGLFHPNG, object FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HEEKPDMMONK(Entity NFFCGLFHPNG, [Out] TValue NICEPFIEJED);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct AMNPIJKABKO : CJGADGIIKPL, IEquatable<AMNPIJKABKO>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly AMNPIJKABKO BKMHILKPIAJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int JPDBMMOIFEO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x91AD60", Offset = "0x919F60", VA = "0x18091AD60", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x91AD70", Offset = "0x919F70", VA = "0x18091AD70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int CIPMFJNCALK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x238FDE0", Offset = "0x238EFE0", VA = "0x18238FDE0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x561FD50", Offset = "0x561EF50", VA = "0x18561FD50", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x62C0690", Offset = "0x62BF890", VA = "0x1862C0690", Slot = "8")]
	public bool Equals(AMNPIJKABKO NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x62C06E0", Offset = "0x62BF8E0", VA = "0x1862C06E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class LIKJOINBCBE<THasTokensTag> : PBOPLJFOHPG, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly JJNHGMIGPBK OMJOPGOBIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, AMNPIJKABKO> EKEFOHBEEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> IOGAFPFIAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private OGBPLMAHFKA<AMNPIJKABKO, HashSet<object>> LFCBFADCPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager LMKGBBMBMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem LNGBLFKDAHB;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3D68D50", Offset = "0x3D67F50", VA = "0x183D68D50")]
	public LIKJOINBCBE(EntityManager LMKGBBMBMBN, EntityCommandBufferSystem LNGBLFKDAHB, JJNHGMIGPBK DPMNPMPCCMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3D687B0", Offset = "0x3D679B0", VA = "0x183D687B0", Slot = "4")]
	public bool OMFFIGABJON(Entity NFFCGLFHPNG, object FCKLPDKGPKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3D67D60", Offset = "0x3D66F60", VA = "0x183D67D60", Slot = "5")]
	public bool LKCLAEPLNDJ(Entity NFFCGLFHPNG, object FCKLPDKGPKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3D66490", Offset = "0x3D65690", VA = "0x183D66490", Slot = "6")]
	public bool EBHMAIEOIGN(Entity NFFCGLFHPNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3D66670", Offset = "0x3D65870", VA = "0x183D66670", Slot = "9")]
	public bool EBHMAIEOIGN(AMNPIJKABKO EIKDEMMADOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3D65C20", Offset = "0x3D64E20", VA = "0x183D65C20", Slot = "7")]
	public bool DMBHFEDJIAD(Entity NFFCGLFHPNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3D66450", Offset = "0x3D65650", VA = "0x183D66450", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3D679C0", Offset = "0x3D66BC0", VA = "0x183D679C0")]
	private void JFLFAFOODCM(HashSet<object> DFDDJJGLJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3D67080", Offset = "0x3D66280", VA = "0x183D67080")]
	private bool EODECKGHEIH(Entity NFFCGLFHPNG, [Out] AMNPIJKABKO EIKDEMMADOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3D68390", Offset = "0x3D67590", VA = "0x183D68390")]
	private bool OJCFKACOABD(Entity NFFCGLFHPNG, [Out] AMNPIJKABKO EIKDEMMADOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3D67140", Offset = "0x3D66340", VA = "0x183D67140")]
	private void EPJBMCGOBNE(Entity NFFCGLFHPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3D66A80", Offset = "0x3D65C80", VA = "0x183D66A80")]
	private void ENGKGAJEPJM(Entity NFFCGLFHPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3D66150", Offset = "0x3D65350", VA = "0x183D66150")]
	private void DMFIJJKPJCO(Entity NFFCGLFHPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3D67640", Offset = "0x3D66840", VA = "0x183D67640")]
	private void GFJDOOONKBK(Entity NFFCGLFHPNG, AMNPIJKABKO EIKDEMMADOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3D65720", Offset = "0x3D64920", VA = "0x183D65720")]
	private bool ACNGOKBCKAE(AMNPIJKABKO EIKDEMMADOB, [Out] HashSet<object> DFDDJJGLJIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3D65A40", Offset = "0x3D64C40", VA = "0x183D65A40")]
	private HashSet<object> CBPLIPJGOKH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class NGDLEDEOGHA
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct HLPOIGABHLD : IHEGMBHMADO<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x62C0D00", Offset = "0x62BFF00", VA = "0x1862C0D00")]
	public float NMOBNBOJAGM([In] float3 NICEPFIEJED)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x62C0D00", Offset = "0x62BFF00", VA = "0x1862C0D00", Slot = "4")]
	private float PNEPHCONDGM([In] float3 NICEPFIEJED)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct IEAGHHHNLLG : IHEGMBHMADO<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x62C0D50", Offset = "0x62BFF50", VA = "0x1862C0D50")]
	public float NMOBNBOJAGM([In] float3 NICEPFIEJED)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x62C0D50", Offset = "0x62BFF50", VA = "0x1862C0D50", Slot = "4")]
	private float PNEPHCONDGM([In] float3 NICEPFIEJED)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct BPFHBPHKBFO : IHEGMBHMADO<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1B1F3A0", Offset = "0x1B1E5A0", VA = "0x181B1F3A0")]
	public float NMOBNBOJAGM([In] float3 NICEPFIEJED)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1B1F3A0", Offset = "0x1B1E5A0", VA = "0x181B1F3A0", Slot = "4")]
	private float PNEPHCONDGM([In] float3 NICEPFIEJED)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct LHBDDGPCJBA : IHEGMBHMADO<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1408570", Offset = "0x1407770", VA = "0x181408570")]
	public int NMOBNBOJAGM([In] int3 NICEPFIEJED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1408570", Offset = "0x1407770", VA = "0x181408570", Slot = "4")]
	private int JCAIIIAFAPD([In] int3 NICEPFIEJED)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct OCKKKPDJCBI : IHEGMBHMADO<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x62C1560", Offset = "0x62C0760", VA = "0x1862C1560")]
	public int NMOBNBOJAGM([In] int3 NICEPFIEJED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x62C1560", Offset = "0x62C0760", VA = "0x1862C1560", Slot = "4")]
	private int JCAIIIAFAPD([In] int3 NICEPFIEJED)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct LDCPAPCBNFE : IHEGMBHMADO<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1719030", Offset = "0x1718230", VA = "0x181719030")]
	public int NMOBNBOJAGM([In] int3 NICEPFIEJED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1719030", Offset = "0x1718230", VA = "0x181719030", Slot = "4")]
	private int JCAIIIAFAPD([In] int3 NICEPFIEJED)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class MDHFEMGPMGB : NDNLFDIDCML
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7C4110", Offset = "0x7C3310", VA = "0x1807C4110")]
	public MDHFEMGPMGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class MOPCKKPFMDB : SystemBase, HNDEDAMHEDP
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x29BB4A0", Offset = "0x29BA6A0", VA = "0x1829BB4A0")]
	public void IDDLHABFCPK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x29BB520", Offset = "0x29BA720", VA = "0x1829BB520")]
	public JobHandle IDDLHABFCPK<T>(JobHandle GBHDJGFBJBP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x29BB4A0", Offset = "0x29BA6A0", VA = "0x1829BB4A0")]
	public void PHEGIJDICHM<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x29BBB20", Offset = "0x29BAD20", VA = "0x1829BBB20")]
	public JobHandle PHEGIJDICHM<T>(JobHandle GBHDJGFBJBP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x62C1370", Offset = "0x62C0570", VA = "0x1862C1370")]
	public ComponentDataFromEntity FNFEHDNGDJC(int OLIJILKFIJO, bool IAKMHAJBDDH = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x62C1430", Offset = "0x62C0630", VA = "0x1862C1430")]
	public EntityExistenceLookupByEntity OGLIDINHCKM()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x62C1450", Offset = "0x62C0650", VA = "0x1862C1450", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7C4110", Offset = "0x7C3310", VA = "0x1807C4110")]
	protected MOPCKKPFMDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class INLCGEOKJMK : MOPCKKPFMDB
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x62C0E90", Offset = "0x62C0090", VA = "0x1862C0E90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7C4110", Offset = "0x7C3310", VA = "0x1807C4110")]
	protected INLCGEOKJMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class BDCKCACJHFI
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class OPLOAMGOHOG : EntityCommandBufferSystem, HNDEDAMHEDP
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7C4110", Offset = "0x7C3310", VA = "0x1807C4110")]
	protected OPLOAMGOHOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface IHEGMBHMADO<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo NMOBNBOJAGM([In] TFrom NICEPFIEJED);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface IKPDGGCEEAC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GKJJGGELFLC(T NICEPFIEJED);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BurstCompile]
internal struct JKPNFCMDLFL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[ReadOnly]
	public NativeArray<Entity> AFOPCKBACJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public EntityCommandBuffer NFPODEOEKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public ComponentTypes NDMOCLNJIMD;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x62C0FE0", Offset = "0x62C01E0", VA = "0x1862C0FE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct IIPCLJFFEDJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[ReadOnly]
	public NativeArray<Entity> AFOPCKBACJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public EntityCommandBuffer NFPODEOEKDF;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x62C0DF0", Offset = "0x62BFFF0", VA = "0x1862C0DF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct EMGPLLBKIAK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public NativeArray<Entity> AFOPCKBACJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public EntityCommandBuffer NFPODEOEKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public ComponentType FELHENFOFHD;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x62C0BD0", Offset = "0x62BFDD0", VA = "0x1862C0BD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct DLBDKHLLJCI<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	[ReadOnly]
	public NativeArray<Entity> AFOPCKBACJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<T> FODGEDCJIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer NFPODEOEKDF;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x512EB60", Offset = "0x512DD60", VA = "0x18512EB60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal struct FMJNMHINCCP<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<Entity> AFOPCKBACJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<T> NGOGJHGFHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public EntityCommandBuffer NFPODEOEKDF;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct KGPLDENPMFN<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<Entity> AFOPCKBACJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public T NICEPFIEJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public EntityCommandBuffer NFPODEOEKDF;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3C91E40", Offset = "0x3C91040", VA = "0x183C91E40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BurstCompile]
internal struct CIDMILAMLOK<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, IHEGMBHMADO<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[ReadOnly]
	public NativeArray<TFrom> PDDIFFBIFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[WriteOnly]
	public NativeArray<TTo> IDMJECCJGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public TMap GKGLDBAJJCH;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct NKDIEHCOJLF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[ReadOnly]
	public ComponentDataFromEntity OHJMJHIBHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<Entity> PDDIFFBIFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<byte> IDMJECCJGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int LGHPAPEAKAK;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x62C1460", Offset = "0x62C0660", VA = "0x1862C1460", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct AOKIGEJHEFP<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity<T> HFLNFGMJGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> PDDIFFBIFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeList<T> PNAAOAPFPHO;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct PPPLHPBMHAI<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, IHEGMBHMADO<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public NativeArray<TFrom> LABHOOAIJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[WriteOnly]
	public NativeList<TTo> IDMJECCJGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public TMap GKGLDBAJJCH;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct MEIOBLFMAHH<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public ComponentDataFromEntity<T> KDCGGADFCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<Entity> ALEELOCKAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<bool> JFAECANOBEH;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct OLNOJCLCBEI<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ComponentDataFromEntity<T> KDCGGADFCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public NativeArray<Entity> ALEELOCKAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public NativeArray<bool> JFAECANOBEH;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x41B4F80", Offset = "0x41B4180", VA = "0x1841B4F80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct PEHJIDNGDMG<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<T> PDDIFFBIFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeList<T> PNAAOAPFPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeParallelHashSet<T> MGDCNENJAML;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4265850", Offset = "0x4264A50", VA = "0x184265850", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct ANMNADFAMPF<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : IHEGMBHMADO<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public NativeArray<TFrom> PDDIFFBIFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeList<TFrom> PNAAOAPFPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeParallelHashSet<TTo> MGDCNENJAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public TMap GKGLDBAJJCH;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct PAAHLMCNIGH<T, TPredicate> : IJob where T : struct where TPredicate : struct, IKPDGGCEEAC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<T> PDDIFFBIFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public NativeArray<Entity> JEMKJNFMGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeList<Entity> JDAHIKCIBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TPredicate GKGLDBAJJCH;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x424AA80", Offset = "0x4249C80", VA = "0x18424AA80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct OHPDCAKNAGC<T, TPredicate> : IJob where T : struct where TPredicate : struct, IKPDGGCEEAC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> PDDIFFBIFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public NativeList<T> PNAAOAPFPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public TPredicate GKGLDBAJJCH;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct OFNEOCBCANL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public ComponentDataFromEntity KDCGGADFCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<Entity> ALEELOCKAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<Entity> BBPLLOGIJHN;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x62C1570", Offset = "0x62C0770", VA = "0x1862C1570", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct IGDIABGJNNP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[ReadOnly]
	public ComponentDataFromEntity KDCGGADFCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<Entity> ALEELOCKAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<Entity> BBPLLOGIJHN;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x62C0D60", Offset = "0x62BFF60", VA = "0x1862C0D60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class ANDGMJHCDDK
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class BFCKACGONCA
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x26A6290", Offset = "0x26A5490", VA = "0x1826A6290")]
	public static bool DLGFILOBADH<T>(this NativeArray<Entity> ALEELOCKAHN, EntityManager LMKGBBMBMBN, Allocator ILEAEEDKNCF = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class GMHHEICPNCB
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class MLKLAMADLGN<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		public MLKLAMADLGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class FPBJPJMIPND<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		public FPBJPJMIPND()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<Func<JobHandle, JobHandle>> PMLJKGKDNFB;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x62C0C70", Offset = "0x62BFE70", VA = "0x1862C0C70")]
	public GMHHEICPNCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class CKIHOILMLLM
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class EHFPOLHFCLC
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct LPJMPNCEJLF<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct FCOCBIGDOFG<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			internal LPJMPNCEJLF<TFrom> BHNONFFBKHO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal Allocator ILEAEEDKNCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal NativeArray<TFrom> LHCBCAKMNGO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct OKGJJEDKAFJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct KLMBLPMNPIG<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			internal OKGJJEDKAFJ<TFrom> BHNONFFBKHO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal Allocator ILEAEEDKNCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal NativeList<TFrom> LHCBCAKMNGO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct CGBNAHAKMII<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct NHDKNEPBFBD<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			internal CGBNAHAKMII<TFrom> BHNONFFBKHO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal Allocator ILEAEEDKNCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal NativeArrayAsync<TFrom> LHCBCAKMNGO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct IJJOGAIJHPG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct FEFNDIAOFLO<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			internal IJJOGAIJHPG<TFrom> BHNONFFBKHO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal Allocator ILEAEEDKNCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal NativeListAsync<TFrom> LHCBCAKMNGO;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class PKJMMFKCNLP
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class BNENFCNBOLC
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x26BDB60", Offset = "0x26BCD60", VA = "0x1826BDB60")]
	public static NativeList<T> JAFOPOOIOFL<T>(this NativeArray<T> PCLFDNONBON, Allocator ILEAEEDKNCF = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class CNONEMIAHNL
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class CIDKFLGEPHA
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x27185E0", Offset = "0x27177E0", VA = "0x1827185E0")]
	[FLENPNPEDNH]
	public static JobHandle INMPHCHGAEE<T>(this EntityCommandBufferSystem LNGBLFKDAHB, NativeArrayAsync<Entity> AFOPCKBACJG, NativeArrayAsync<T> FODGEDCJIDC, [Optional] JobHandle GBHDJGFBJBP) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2718860", Offset = "0x2717A60", VA = "0x182718860")]
	[FLENPNPEDNH]
	public static JobHandle INMPHCHGAEE<T>(this EntityCommandBufferSystem LNGBLFKDAHB, NativeArrayAsync<Entity> AFOPCKBACJG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2718740", Offset = "0x2717940", VA = "0x182718740")]
	[FLENPNPEDNH]
	public static JobHandle INMPHCHGAEE<T>(this EntityCommandBufferSystem LNGBLFKDAHB, NativeArray<Entity> AFOPCKBACJG, [Optional] JobHandle GBHDJGFBJBP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x62C0910", Offset = "0x62BFB10", VA = "0x1862C0910")]
	[FLENPNPEDNH]
	public static JobHandle INMPHCHGAEE(this EntityCommandBufferSystem LNGBLFKDAHB, NativeArray<Entity> AFOPCKBACJG, ComponentTypes NDMOCLNJIMD, [Optional] JobHandle GBHDJGFBJBP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x62C0A80", Offset = "0x62BFC80", VA = "0x1862C0A80")]
	[FLENPNPEDNH]
	public static JobHandle INMPHCHGAEE(this EntityCommandBufferSystem LNGBLFKDAHB, EntityCommandBuffer NFPODEOEKDF, NativeArray<Entity> AFOPCKBACJG, ComponentTypes NDMOCLNJIMD, [Optional] JobHandle GBHDJGFBJBP)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class APMGPDIGPOO
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2F198D0", Offset = "0x2F18AD0", VA = "0x182F198D0")]
	[FLENPNPEDNH]
	public static JobHandle ADEGGGFDDKG<T>(this EntityCommandBufferSystem LNGBLFKDAHB, EntityCommandBuffer NFPODEOEKDF, EntityQuery JPOCMHGHJPO, T NICEPFIEJED) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class KDLGIKLDNCD
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x62C11D0", Offset = "0x62C03D0", VA = "0x1862C11D0")]
	[FLENPNPEDNH]
	public static JobHandle AGAGKMHIJKD(this EntityCommandBufferSystem LNGBLFKDAHB, NativeList<Entity> AFOPCKBACJG, [Optional] JobHandle GBHDJGFBJBP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x62C10D0", Offset = "0x62C02D0", VA = "0x1862C10D0")]
	[FLENPNPEDNH]
	public static JobHandle AGAGKMHIJKD(this EntityCommandBufferSystem LNGBLFKDAHB, NativeArrayAsync<Entity> AFOPCKBACJG)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class EFNFJGLANDD
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x277A4F0", Offset = "0x27796F0", VA = "0x18277A4F0")]
	public static void AMMMMACIHCI<T>(this EntityCommandBufferSystem LNGBLFKDAHB, EntityQuery JPOCMHGHJPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x277A8C0", Offset = "0x2779AC0", VA = "0x18277A8C0")]
	[FLENPNPEDNH]
	public static JobHandle ELOMIOJFDJE<T>(this EntityCommandBufferSystem LNGBLFKDAHB, NativeListAsync<Entity> AFOPCKBACJG, [Optional] JobHandle GBHDJGFBJBP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x277A980", Offset = "0x2779B80", VA = "0x18277A980")]
	[FLENPNPEDNH]
	public static JobHandle ELOMIOJFDJE<T>(this EntityCommandBufferSystem LNGBLFKDAHB, NativeArrayAsync<Entity> AFOPCKBACJG, [Optional] JobHandle GBHDJGFBJBP)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class LJPFJFIMFEK
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x298A6C0", Offset = "0x29898C0", VA = "0x18298A6C0")]
	[FLENPNPEDNH]
	public static JobHandle KCPNLBJIKOO<T>(this EntityCommandBufferSystem LNGBLFKDAHB, NativeArray<Entity> AFOPCKBACJG, NativeArray<T> FODGEDCJIDC, JobHandle GBHDJGFBJBP) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class DPLLNMGDFJB
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x27643D0", Offset = "0x27635D0", VA = "0x1827643D0")]
	[FLENPNPEDNH]
	public static JobHandle CNPPBJALNJO<T>(this EntityCommandBufferSystem LNGBLFKDAHB, NativeArray<Entity> AFOPCKBACJG, T NICEPFIEJED, [Optional] JobHandle GBHDJGFBJBP) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x27644B0", Offset = "0x27636B0", VA = "0x1827644B0")]
	[FLENPNPEDNH]
	public static JobHandle CNPPBJALNJO<T>(this EntityCommandBufferSystem LNGBLFKDAHB, EntityCommandBuffer NFPODEOEKDF, NativeArray<Entity> AFOPCKBACJG, T NICEPFIEJED, [Optional] JobHandle GBHDJGFBJBP) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class MMCBHGIMFCJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class BOMDABBLKBI
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x26C0CC0", Offset = "0x26BFEC0", VA = "0x1826C0CC0")]
	public static NativeArray<T> JFPGPABDCLI<T>(this NativeList<Entity> PCLFDNONBON, EntityManager LMKGBBMBMBN, Allocator ILEAEEDKNCF = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x26C0780", Offset = "0x26BF980", VA = "0x1826C0780")]
	public static NativeArray<T> JFPGPABDCLI<T>(this NativeArray<Entity> PCLFDNONBON, EntityManager LMKGBBMBMBN, Allocator ILEAEEDKNCF = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x62C0730", Offset = "0x62BF930", VA = "0x1862C0730")]
	public static NativeArray<Entity> ILMBLFFDPNJ(this NativeArray<Entity> PCLFDNONBON, EntityManager LMKGBBMBMBN, ComponentType FELHENFOFHD, Allocator ILEAEEDKNCF = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x26C0D70", Offset = "0x26BFF70", VA = "0x1826C0D70")]
	public static NativeArray<T> PCFJMGPIKHP<T>(this NativeArray<Entity> PCLFDNONBON, EntityManager LMKGBBMBMBN, Allocator ILEAEEDKNCF = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class HHDHNEACCHI
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct PDPAKHDEMOD<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct HCFFAFOAFAF<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public PDPAKHDEMOD<TFrom> LHCBCAKMNGO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public Allocator ILEAEEDKNCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeArray<TFrom> PDDIFFBIFKH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct OBNPJAOLIMC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct DDLNIHGNFLP<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public OBNPJAOLIMC<TFrom> LHCBCAKMNGO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Allocator ILEAEEDKNCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeArrayAsync<TFrom> PDDIFFBIFKH;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct AJFCIKFAPDG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct FIGIAGDGJML<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public AJFCIKFAPDG<TFrom> LHCBCAKMNGO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Allocator ILEAEEDKNCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public NativeListAsync<TFrom> PDDIFFBIFKH;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class BPJCGBCNGJG
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class FNADJNMIPDC
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct KPCNOIGHNBK : IHEGMBHMADO<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> KDBJOHGMCGC;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x62C1360", Offset = "0x62C0560", VA = "0x1862C1360")]
		[BurstCompatible]
		public Entity NMOBNBOJAGM([In] Entity NICEPFIEJED)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x62C1360", Offset = "0x62C0560", VA = "0x1862C1360", Slot = "4")]
		private Entity LAGFJLEBPBN([In] Entity NICEPFIEJED)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class IMGANODBNLL
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct GMEFLFBOLHF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator ILEAEEDKNCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeArray<Entity> JEMKJNFMGHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<T> PDDIFFBIFKH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct NOCBHLLDMCP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Allocator ILEAEEDKNCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<Entity> JEMKJNFMGHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<T> PDDIFFBIFKH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct FFAGMKJEFOF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Allocator ILEAEEDKNCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArrayAsync<Entity> JEMKJNFMGHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArrayAsync<T> PDDIFFBIFKH;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2579280", Offset = "0x2578480", VA = "0x182579280")]
		public NativeListAsync<Entity> GKJJGGELFLC<TPredicate>() where TPredicate : struct, IKPDGGCEEAC<T>
		{
			return default(NativeListAsync<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x292F920", Offset = "0x292EB20", VA = "0x18292F920")]
	public static FFAGMKJEFOF<T> MMLCNPADLLM<T>(this NativeArrayAsync<Entity> ALEELOCKAHN, NativeArrayAsync<T> PCLFDNONBON, Allocator ILEAEEDKNCF = Allocator.TempJob) where T : struct
	{
		return default(FFAGMKJEFOF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class BDDIICIOJED
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x26A5B90", Offset = "0x26A4D90", VA = "0x1826A5B90")]
	public static NativeListAsync<Entity> BCGGIHPBEPL<T, TPredicate>(this NativeArrayAsync<T> PCLFDNONBON, NativeArrayAsync<Entity> ALEELOCKAHN, Allocator ILEAEEDKNCF = Allocator.TempJob) where T : struct where TPredicate : struct, IKPDGGCEEAC<T>
	{
		return default(NativeListAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x26A5C50", Offset = "0x26A4E50", VA = "0x1826A5C50")]
	private static NativeListAsync<Entity> HEIDIMDJNLC<T, TPredicate>(NativeArrayAsync<T> KIIEFADNHDF, NativeArrayAsync<Entity> ALEELOCKAHN, int HHOELNLHIEN, Allocator ILEAEEDKNCF) where T : struct where TPredicate : struct, IKPDGGCEEAC<T>
	{
		return default(NativeListAsync<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class FDGPKFIHKJA
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct NAIFNOJOFEP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Allocator ILEAEEDKNCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public NativeArray<T> PDDIFFBIFKH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct NHEABLOAFLG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator ILEAEEDKNCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeList<T> PDDIFFBIFKH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct PPCFMAJKLLO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator ILEAEEDKNCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArrayAsync<T> PDDIFFBIFKH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct PNJCIIGOOBB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator ILEAEEDKNCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeListAsync<T> PDDIFFBIFKH;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class CBADHCLNGPA
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class AECHAMNODGK
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2F0ACB0", Offset = "0x2F09EB0", VA = "0x182F0ACB0")]
	public static NativeList<Entity> EFLAMHAJCOP<T>(this NativeArray<Entity> ALEELOCKAHN, EntityManager LMKGBBMBMBN, Allocator ILEAEEDKNCF = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class JBNMLDHADAI
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class LMAMHDKLLJN
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public readonly struct FMDDIBMEJBD<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly NativeArray<TSrc> GEHAOEPMDJB;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1E4A460", Offset = "0x1E49660", VA = "0x181E4A460")]
		public FMDDIBMEJBD(NativeArray<TSrc> GEHAOEPMDJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70")]
		public MKGBBAGEMKE<TSrc, TValue> HCMBNKLILAH<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(MKGBBAGEMKE<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct MKGBBAGEMKE<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NativeArray<TSrc> GEHAOEPMDJB;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1E4A460", Offset = "0x1E49660", VA = "0x181E4A460")]
		public MKGBBAGEMKE(NativeArray<TSrc> GEHAOEPMDJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70")]
		public ODJJJKIBEJK<TSrc, TValue, TSelector> HOECFEAFEJD<TSelector>() where TSelector : struct, IHEGMBHMADO<TSrc, TValue>
		{
			return default(ODJJJKIBEJK<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct ODJJJKIBEJK<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, IHEGMBHMADO<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> GEHAOEPMDJB;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1E4A460", Offset = "0x1E49660", VA = "0x181E4A460")]
		public ODJJJKIBEJK(NativeArray<TSrc> GEHAOEPMDJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4172B80", Offset = "0x4171D80", VA = "0x184172B80")]
		public HJAPHAFEKLB<TSrc, TValue, TSelector> INDEELJHKHE()
		{
			return default(HJAPHAFEKLB<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct IIOMDMPBDHK<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, IHEGMBHMADO<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> GEHAOEPMDJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TSelector JCJCFPMBEBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int HMFNCGHECPG;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TValue DCJELCPGFEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x3A404A0", Offset = "0x3A3F6A0", VA = "0x183A404A0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int JPDBMMOIFEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA552E0", Offset = "0xA544E0", VA = "0x180A552E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int FPAACNPAGCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3A40610", Offset = "0x3A3F810", VA = "0x183A40610")]
		public IIOMDMPBDHK(NativeArray<TSrc> GEHAOEPMDJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3A40490", Offset = "0x3A3F690", VA = "0x183A40490")]
		public bool EKIMDKEIFIK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3A40530", Offset = "0x3A3F730", VA = "0x183A40530")]
		private TSrc PDCECLDILLH(int GJIHJJPNBNJ)
		{
			return (TSrc)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct HJAPHAFEKLB<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, IHEGMBHMADO<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private IIOMDMPBDHK<TSrc, TValue, TSelector> JEGBGBMOBCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TValue KMJEHLMJDDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private int LCKACGDGBMN;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public APEHIJMKLDJ HCFAOOCOGEB
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x397CEC0", Offset = "0x397C0C0", VA = "0x18397CEC0")]
			get
			{
				return default(APEHIJMKLDJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue MBGDICHLGFD
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7C1090", Offset = "0x7C0290", VA = "0x1807C1090")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, APEHIJMKLDJ range) DCJELCPGFEP
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x397CDF0", Offset = "0x397BFF0", VA = "0x18397CDF0")]
			get
			{
				return default((TValue, APEHIJMKLDJ));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x397CF00", Offset = "0x397C100", VA = "0x18397CF00")]
		public HJAPHAFEKLB(NativeArray<TSrc> GEHAOEPMDJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3804ED0", Offset = "0x38040D0", VA = "0x183804ED0")]
		public HJAPHAFEKLB<TSrc, TValue, TSelector> ODDJKKOCOEI()
		{
			return default(HJAPHAFEKLB<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x397CCB0", Offset = "0x397BEB0", VA = "0x18397CCB0")]
		public bool EKIMDKEIFIK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x298B6E0", Offset = "0x298A8E0", VA = "0x18298B6E0")]
	public static FMDDIBMEJBD<T> NCCDEIIGFOL<T>(this NativeList<T> JLCIFHJMGPA) where T : struct
	{
		return default(FMDDIBMEJBD<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70")]
	public static FMDDIBMEJBD<T> NCCDEIIGFOL<T>(this NativeArray<T> GEHAOEPMDJB) where T : struct
	{
		return default(FMDDIBMEJBD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class KJOGGHGNNJL
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct AIOPMBJPOLO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly NativeArray<T>.ReadOnly GEHAOEPMDJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int LCKACGDGBMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int CGJFEDJOFDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private T KMJEHLMJDDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T JBMEGHIGOPG;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public APEHIJMKLDJ HCFAOOCOGEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x39800E0", Offset = "0x397F2E0", VA = "0x1839800E0")]
			get
			{
				return default(APEHIJMKLDJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T MBGDICHLGFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x34FED00", Offset = "0x34FDF00", VA = "0x1834FED00")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, APEHIJMKLDJ) DCJELCPGFEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x3A07D70", Offset = "0x3A06F70", VA = "0x183A07D70")]
			get
			{
				return default((T, APEHIJMKLDJ));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3A07E80", Offset = "0x3A07080", VA = "0x183A07E80")]
		public AIOPMBJPOLO(NativeArray<T> GEHAOEPMDJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3A07E40", Offset = "0x3A07040", VA = "0x183A07E40")]
		public AIOPMBJPOLO<T> ODDJKKOCOEI()
		{
			return default(AIOPMBJPOLO<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3A07940", Offset = "0x3A06B40", VA = "0x183A07940")]
		public bool EKIMDKEIFIK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x23CA740", Offset = "0x23C9940", VA = "0x1823CA740")]
		public HKPHKDOBHKI<T, TComparer> LCOPBMHJCHA<TComparer>([Optional] TComparer CNPNPGNKLDE) where TComparer : struct, IEqualityComparer<T>
		{
			return default(HKPHKDOBHKI<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct HKPHKDOBHKI<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly NativeArray<T>.ReadOnly GEHAOEPMDJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int LCKACGDGBMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int CGJFEDJOFDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T KMJEHLMJDDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private T JBMEGHIGOPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TComparer CNPNPGNKLDE;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public APEHIJMKLDJ HCFAOOCOGEB
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x39800E0", Offset = "0x397F2E0", VA = "0x1839800E0")]
			get
			{
				return default(APEHIJMKLDJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T MBGDICHLGFD
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x34FED00", Offset = "0x34FDF00", VA = "0x1834FED00")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x39800F0", Offset = "0x397F2F0", VA = "0x1839800F0")]
		public HKPHKDOBHKI(NativeArray<T>.ReadOnly GEHAOEPMDJB, TComparer CNPNPGNKLDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x397FF10", Offset = "0x397F110", VA = "0x18397FF10")]
		public bool EKIMDKEIFIK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x297AC00", Offset = "0x2979E00", VA = "0x18297AC00")]
	public static AIOPMBJPOLO<T> INDEELJHKHE<T>(this NativeArray<T> GEHAOEPMDJB) where T : struct
	{
		return default(AIOPMBJPOLO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface MNPOPEOJMLI
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class PAIJGEGOIJG
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct IBAHACDMJDA<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class BLPODIHIAGF : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public IBAHACDMJDA<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xAEBD30", Offset = "0xAEAF30", VA = "0x180AEBD30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x384D770", Offset = "0x384C970", VA = "0x18384D770", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7B7470", Offset = "0x7B6670", VA = "0x1807B7470")]
		[DebuggerHidden]
		public BLPODIHIAGF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x48AB450", Offset = "0x48AA650", VA = "0x1848AB450", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x48AB600", Offset = "0x48AA800", VA = "0x1848AB600", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly Action<Protobuf> FIAPNBCOEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly MemoryStream KIIMFPPABLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly CodedInputStream NIBBLOLPPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Protobuf POKLKCPNLGE;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int FPAACNPAGCG
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x821ED0", Offset = "0x8210D0", VA = "0x180821ED0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3A32110", Offset = "0x3A31310", VA = "0x183A32110", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3A32150", Offset = "0x3A31350", VA = "0x183A32150", Slot = "4")]
	[IteratorStateMachine(typeof(IBAHACDMJDA<>.BLPODIHIAGF))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3A32240", Offset = "0x3A31440", VA = "0x183A32240", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct PLALGNLCDID<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly byte[] BCDEBAAMJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Protobuf POKLKCPNLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly MemoryStream KIIMFPPABLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly CodedOutputStream JDDAIFKLICN;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4276210", Offset = "0x4275410", VA = "0x184276210", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct IDNHGJKHJNO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MemoryStream KIIMFPPABLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CodedInputStream NIBBLOLPPHK;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x62C0D10", Offset = "0x62BFF10", VA = "0x1862C0D10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct JGFIOEDJBNM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly byte[] BCDEBAAMJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream KIIMFPPABLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedOutputStream JDDAIFKLICN;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x62C0EC0", Offset = "0x62C00C0", VA = "0x1862C0EC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class AKBEPAGLEHL
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class KKKDMDAALCD
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Flags]
public enum NOHNHGLINFM
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
internal static class JFAKKLDHNOJ
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class NIBLCMOALME
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public NIBLCMOALME()
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
