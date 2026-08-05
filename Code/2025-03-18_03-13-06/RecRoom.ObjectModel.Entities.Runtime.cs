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
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
		public IsUnmanagedAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7767010", Offset = "0x7766210", VA = "0x187767010")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x98D6C0", Offset = "0x98C8C0", VA = "0x18098D6C0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x98D700", Offset = "0x98C900", VA = "0x18098D700")]
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
		[Cpp2IlInjected.Address(RVA = "0x7766480", Offset = "0x7765680", VA = "0x187766480")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MCMNOGDHFPG : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	JKNBJEOANBN DAOINGDMGJJ
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
public interface DGLMPDMPKAI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool APNINMKHEAL(Entity JJMNGBLHAJC, object GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HNMHPBAAPMG(Entity JJMNGBLHAJC, object GIIKHLJPAKH, [Out] bool MCDHLMHEIDF);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ELLNGJKGEBA(Entity JJMNGBLHAJC);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class PBNCFPFCALD<TComponentData, TValue> : GDIAPOPEONF<TValue>, IDisposable where TComponentData : struct, MCMNOGDHFPG
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class MHBHBKLFAII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<(object token, TValue value)> KBPAKCCMOCP;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int ABNMPHLJIIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x3D86B30", Offset = "0x3D85D30", VA = "0x183D86B30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4DA4E00", Offset = "0x4DA4000", VA = "0x184DA4E00")]
		public bool LNJIOPMIHFC([Out] TValue OMFJNFBDJCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4DA4F00", Offset = "0x4DA4100", VA = "0x184DA4F00")]
		public void OFEFHMDJLMD(object GIIKHLJPAKH, TValue OMFJNFBDJCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4DA4FE0", Offset = "0x4DA41E0", VA = "0x184DA4FE0")]
		public bool OGPGHNCGHLC(object GIIKHLJPAKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4DA4D00", Offset = "0x4DA3F00", VA = "0x184DA4D00")]
		public int ANDIFPOIJPH(object GIIKHLJPAKH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4DA5090", Offset = "0x4DA4290", VA = "0x184DA5090")]
		public MHBHBKLFAII()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stack<MHBHBKLFAII> JLFIGBEOMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private EPBMNOKABIC<JKNBJEOANBN, MHBHBKLFAII> FFGKAGBIEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EntityManager HOPEOGNNILD;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x50B9F80", Offset = "0x50B9180", VA = "0x1850B9F80")]
	public PBNCFPFCALD(EntityManager HOPEOGNNILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x50B9740", Offset = "0x50B8940", VA = "0x1850B9740", Slot = "4")]
	public void APNINMKHEAL(Entity JJMNGBLHAJC, object GIIKHLJPAKH, TValue OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x50B99D0", Offset = "0x50B8BD0", VA = "0x1850B99D0", Slot = "5")]
	public bool HNMHPBAAPMG(Entity JJMNGBLHAJC, object GIIKHLJPAKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x50B9BD0", Offset = "0x50B8DD0", VA = "0x1850B9BD0", Slot = "6")]
	public bool LNJIOPMIHFC(Entity JJMNGBLHAJC, [Out] TValue OMFJNFBDJCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x50B98C0", Offset = "0x50B8AC0", VA = "0x1850B98C0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x50B9E00", Offset = "0x50B9000", VA = "0x1850B9E00")]
	private void MNAHIEHBFHB(MHBHBKLFAII FIDHLKGFJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x50B9EC0", Offset = "0x50B90C0", VA = "0x1850B9EC0")]
	private bool OHCOALFDFKB(Entity JJMNGBLHAJC, [Out] JKNBJEOANBN PBLKLOBKEHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x50B98E0", Offset = "0x50B8AE0", VA = "0x1850B98E0")]
	private void FPOFHLPMADP(Entity JJMNGBLHAJC, JKNBJEOANBN PBLKLOBKEHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x50B9BB0", Offset = "0x50B8DB0", VA = "0x1850B9BB0")]
	private bool KDEAPEHINJG(JKNBJEOANBN PBLKLOBKEHJ, [Out] MHBHBKLFAII FIDHLKGFJIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x50B9CE0", Offset = "0x50B8EE0", VA = "0x1850B9CE0")]
	private MHBHBKLFAII MCCGFIBCFCG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GDIAPOPEONF<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void APNINMKHEAL(Entity JJMNGBLHAJC, object GIIKHLJPAKH, TValue OMFJNFBDJCA);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HNMHPBAAPMG(Entity JJMNGBLHAJC, object GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LNJIOPMIHFC(Entity JJMNGBLHAJC, [Out] TValue OMFJNFBDJCA);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct JKNBJEOANBN : FGEPICOCPFA, IEquatable<JKNBJEOANBN>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly JKNBJEOANBN GCMJBINHBBO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int PGEMEJBADFN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8D0", Offset = "0x9ADAD0", VA = "0x1809AE8D0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1123120", Offset = "0x1122320", VA = "0x181123120", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int DAIODIGKFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2BF46E0", Offset = "0x2BF38E0", VA = "0x182BF46E0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x68B29B0", Offset = "0x68B1BB0", VA = "0x1868B29B0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7766E00", Offset = "0x7766000", VA = "0x187766E00", Slot = "8")]
	public bool Equals(JKNBJEOANBN LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7766E50", Offset = "0x7766050", VA = "0x187766E50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class DNAIJDOJHOA<THasTokensTag> : DGLMPDMPKAI, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Dictionary<Entity, JKNBJEOANBN> PNNHIHOOPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Stack<HashSet<object>> JLFIGBEOMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EPBMNOKABIC<JKNBJEOANBN, HashSet<object>> FFGKAGBIEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EntityManager HOPEOGNNILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EntityCommandBufferSystem CBICMHAFCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool JPJEOEDAIGH;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x63EA1E0", Offset = "0x63E93E0", VA = "0x1863EA1E0")]
	public DNAIJDOJHOA(EntityManager HOPEOGNNILD, EntityCommandBufferSystem CBICMHAFCJG, PBBCGFNIILA HMPNNFNFDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x63E7C60", Offset = "0x63E6E60", VA = "0x1863E7C60", Slot = "4")]
	public bool APNINMKHEAL(Entity JJMNGBLHAJC, object GIIKHLJPAKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x63E8D80", Offset = "0x63E7F80", VA = "0x1863E8D80", Slot = "5")]
	public bool HNMHPBAAPMG(Entity JJMNGBLHAJC, object GIIKHLJPAKH, [Out] bool MCDHLMHEIDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x63E83D0", Offset = "0x63E75D0", VA = "0x1863E83D0", Slot = "6")]
	public bool ELLNGJKGEBA(Entity JJMNGBLHAJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x63E8520", Offset = "0x63E7720", VA = "0x1863E8520", Slot = "8")]
	public bool ELLNGJKGEBA(JKNBJEOANBN PBLKLOBKEHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x63E8220", Offset = "0x63E7420", VA = "0x1863E8220", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x63E9A70", Offset = "0x63E8C70", VA = "0x1863E9A70")]
	private void MNAHIEHBFHB(HashSet<object> FIDHLKGFJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x63E9BC0", Offset = "0x63E8DC0", VA = "0x1863E9BC0")]
	private bool OHCOALFDFKB(Entity JJMNGBLHAJC, [Out] JKNBJEOANBN PBLKLOBKEHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x63E74B0", Offset = "0x63E66B0", VA = "0x1863E74B0")]
	private bool ABJJKHELDGK(Entity JJMNGBLHAJC, [Out] JKNBJEOANBN PBLKLOBKEHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x63E7F20", Offset = "0x63E7120", VA = "0x1863E7F20")]
	private void CJKNBAOLDLM(Entity JJMNGBLHAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x63E9340", Offset = "0x63E8540", VA = "0x1863E9340")]
	private void LJCMKCNPEBM(Entity JJMNGBLHAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x63E9970", Offset = "0x63E8B70", VA = "0x1863E9970")]
	private void MJMHPAEALDM(Entity JJMNGBLHAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x63E86F0", Offset = "0x63E78F0", VA = "0x1863E86F0")]
	private void FPOFHLPMADP(Entity JJMNGBLHAJC, JKNBJEOANBN PBLKLOBKEHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x63E8840", Offset = "0x63E7A40", VA = "0x1863E8840")]
	private bool GKBAJJNLONO(JKNBJEOANBN PBLKLOBKEHJ, [Out] HashSet<object> FIDHLKGFJIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x63E9720", Offset = "0x63E8920", VA = "0x1863E9720")]
	private HashSet<object> MCCGFIBCFCG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class KFGFJLJABNF
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct LKBCOKLFLEA : IJHDIIKPNDI<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7766FF0", Offset = "0x77661F0", VA = "0x187766FF0")]
	public float JDODKOHLKAP([In] float3 OMFJNFBDJCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7766FF0", Offset = "0x77661F0", VA = "0x187766FF0", Slot = "4")]
	private float FHKBFIKJHIO([In] float3 OMFJNFBDJCA)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct DBCEKAHHLPE : IJHDIIKPNDI<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7766380", Offset = "0x7765580", VA = "0x187766380")]
	public float JDODKOHLKAP([In] float3 OMFJNFBDJCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7766380", Offset = "0x7765580", VA = "0x187766380", Slot = "4")]
	private float FHKBFIKJHIO([In] float3 OMFJNFBDJCA)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct FENHBFHOOHC : IJHDIIKPNDI<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0xD68EB0", Offset = "0xD680B0", VA = "0x180D68EB0")]
	public float JDODKOHLKAP([In] float3 OMFJNFBDJCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xD68EB0", Offset = "0xD680B0", VA = "0x180D68EB0", Slot = "4")]
	private float FHKBFIKJHIO([In] float3 OMFJNFBDJCA)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct DNMNPJENGLJ : IJHDIIKPNDI<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1F84300", Offset = "0x1F83500", VA = "0x181F84300")]
	public int JDODKOHLKAP([In] int3 OMFJNFBDJCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1F84300", Offset = "0x1F83500", VA = "0x181F84300", Slot = "4")]
	private int CDCFOBAPAOJ([In] int3 OMFJNFBDJCA)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct GHDGIFHAHNE : IJHDIIKPNDI<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7754BA0", Offset = "0x7753DA0", VA = "0x187754BA0")]
	public int JDODKOHLKAP([In] int3 OMFJNFBDJCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7754BA0", Offset = "0x7753DA0", VA = "0x187754BA0", Slot = "4")]
	private int CDCFOBAPAOJ([In] int3 OMFJNFBDJCA)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct BBGKFIBKDLL : IJHDIIKPNDI<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xD456C0", Offset = "0xD448C0", VA = "0x180D456C0")]
	public int JDODKOHLKAP([In] int3 OMFJNFBDJCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xD456C0", Offset = "0xD448C0", VA = "0x180D456C0", Slot = "4")]
	private int CDCFOBAPAOJ([In] int3 OMFJNFBDJCA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HKNJNMFBLAH : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1E79E60", Offset = "0x1E79060", VA = "0x181E79E60")]
	public HKNJNMFBLAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class IJJBIAEOBIE : SystemBase, DBMDALBKOIO
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string FOBFABOAOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7766A10", Offset = "0x7765C10", VA = "0x187766A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x34D7640", Offset = "0x34D6840", VA = "0x1834D7640")]
	public void IKPCHBDMAPK<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x34D7640", Offset = "0x34D6840", VA = "0x1834D7640")]
	public void BJJLBBKKICL<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7766950", Offset = "0x7765B50", VA = "0x187766950")]
	public JobHandle DLKCFHDLOOE(ReadOnlySpan<int> LENHAGANFIL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x34D76A0", Offset = "0x34D68A0", VA = "0x1834D76A0")]
	public JobHandle BOEEAJJAPLH<T>() where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7766900", Offset = "0x7765B00", VA = "0x187766900")]
	public JobHandle BOEEAJJAPLH(ReadOnlySpan<int> LENHAGANFIL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x34D6DD0", Offset = "0x34D5FD0", VA = "0x1834D6DD0")]
	public void BBCOKBNGHPN<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x34D6CF0", Offset = "0x34D5EF0", VA = "0x1834D6CF0")]
	public JobHandle BBCOKBNGHPN<T>(JobHandle PBLKLOBKEHJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7766890", Offset = "0x7765A90", VA = "0x187766890")]
	public JobHandle BBCOKBNGHPN(ReadOnlySpan<int> LENHAGANFIL, JobHandle PBLKLOBKEHJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x34D6DD0", Offset = "0x34D5FD0", VA = "0x1834D6DD0")]
	public void EHHMOLMBPBA<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x34D7870", Offset = "0x34D6A70", VA = "0x1834D7870")]
	public JobHandle EHHMOLMBPBA<T>(JobHandle PBLKLOBKEHJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x77669A0", Offset = "0x7765BA0", VA = "0x1877669A0")]
	public JobHandle EHHMOLMBPBA(Span<int> LENHAGANFIL, JobHandle PBLKLOBKEHJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x34D7BD0", Offset = "0x34D6DD0", VA = "0x1834D7BD0")]
	public ComponentDataFromEntity JPPLIGIMDLD<T>(bool AAEKHNFFBKG = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7766A40", Offset = "0x7765C40", VA = "0x187766A40")]
	public ComponentDataFromEntity JPPLIGIMDLD(int MHNEMMJLDKF, bool AAEKHNFFBKG = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x34D7B10", Offset = "0x34D6D10", VA = "0x1834D7B10")]
	public SharedComponentIndexFromEntity<T> FIODCAGELFN<T>() where T : ISharedComponentData
	{
		return default(SharedComponentIndexFromEntity<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7766B20", Offset = "0x7765D20", VA = "0x187766B20")]
	[BurstCompatible]
	public ComponentTypeHandle PBFDNCMDEND(ComponentType JAEFMBPDGPB)
	{
		return default(ComponentTypeHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7766B00", Offset = "0x7765D00", VA = "0x187766B00")]
	public EntityExistenceLookupByEntity KFDHLMAOAGD()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7766B80", Offset = "0x7765D80", VA = "0x187766B80", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x34D77E0", Offset = "0x34D69E0", VA = "0x1834D77E0")]
	public bool DBBAFGPJJGC<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "7")]
	protected sealed override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1E79E60", Offset = "0x1E79060", VA = "0x181E79E60")]
	protected IJJBIAEOBIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class HEOBIOIJGMK : IJJBIAEOBIE
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7766860", Offset = "0x7765A60", VA = "0x187766860", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1E79E60", Offset = "0x1E79060", VA = "0x181E79E60")]
	protected HEOBIOIJGMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class HOFLEGMJMBC
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class KBBLIMDMCCD : EntityCommandBufferSystem, DBMDALBKOIO
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private PBBCGFNIILA IPKFDHIOJFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xC58EA0", Offset = "0xC580A0", VA = "0x180C58EA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7766EA0", Offset = "0x77660A0", VA = "0x187766EA0")]
	public KBBLIMDMCCD(PBBCGFNIILA NPAEAIAJLAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface IJHDIIKPNDI<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo JDODKOHLKAP([In] TFrom OMFJNFBDJCA);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface BAJKPHEAOPG<T>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KHINHIECPGD(T OMFJNFBDJCA);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct EGIDABPEPEH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> DNOHLBIMBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer OPMFHEKLOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public ComponentTypes ENONKMHIKCG;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7766390", Offset = "0x7765590", VA = "0x187766390", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct CMMDAANMGKH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> DNOHLBIMBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer OPMFHEKLOJO;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x77662E0", Offset = "0x77654E0", VA = "0x1877662E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct CHBDPEPHHEP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> DNOHLBIMBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer OPMFHEKLOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public ComponentType JAEFMBPDGPB;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7766260", Offset = "0x7765460", VA = "0x187766260", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[BurstCompile]
internal struct ONDEMIKDBCN<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> DNOHLBIMBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> LJELDKAOCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer OPMFHEKLOJO;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5013910", Offset = "0x5012B10", VA = "0x185013910", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct HFEHIMOOPNE<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> DNOHLBIMBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<T> ALKPNNHBNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer OPMFHEKLOJO;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal struct KIBIBEODBAC<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<Entity> DNOHLBIMBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public T OMFJNFBDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EntityCommandBuffer OPMFHEKLOJO;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct JLFGFHDNBOC<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, IJHDIIKPNDI<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<TFrom> DCLKBIAKCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<TTo> MAHMGNIAAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public TMap GJDAMJHNAPC;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct FHEAHJKLBMG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity GHHLNJLIHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> DCLKBIAKCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeArray<byte> MAHMGNIAAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int HKJNHGFIBLG;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x77664A0", Offset = "0x77656A0", VA = "0x1877664A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct ONDFPAOFNEJ<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> BJENPJMLKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<Entity> DCLKBIAKCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<T> FDOMALMEAGA;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct LLAJFAHLLKN<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, IJHDIIKPNDI<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<TFrom> OFJPNHJAFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[WriteOnly]
	public NativeList<TTo> MAHMGNIAAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public TMap GJDAMJHNAPC;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct PNGELDBCOCK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> HABNMNCIIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> PKDMCLNHHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> GADHOLIMEHF;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct DLNPECAFGJF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public ComponentDataFromEntity<T> HABNMNCIIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<Entity> PKDMCLNHHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<bool> GADHOLIMEHF;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x63E2EF0", Offset = "0x63E20F0", VA = "0x1863E2EF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct OHCODODBGJD<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<T> DCLKBIAKCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<T> FDOMALMEAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<T> JHAPDDACOJP;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5001F00", Offset = "0x5001100", VA = "0x185001F00", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct HIPGEBMCPJM<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : IJHDIIKPNDI<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<TFrom> DCLKBIAKCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public NativeList<TFrom> FDOMALMEAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeParallelHashSet<TTo> JHAPDDACOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TMap GJDAMJHNAPC;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct GOBCHEAEBAL<T, TPredicate> : IJob where T : struct where TPredicate : struct, BAJKPHEAOPG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> DCLKBIAKCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<Entity> ABPIOMFBJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<Entity> EMNEKAKMJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate GJDAMJHNAPC;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct JBOEEMGNBJI<T, TPredicate> : IJob where T : struct where TPredicate : struct, BAJKPHEAOPG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> DCLKBIAKCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> FDOMALMEAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TPredicate GJDAMJHNAPC;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct JANFEFBPCLP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity HABNMNCIIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> PKDMCLNHHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> NKNEOHGDMEC;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7766B90", Offset = "0x7765D90", VA = "0x187766B90", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct KILOGCHGDBH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[ReadOnly]
	public ComponentDataFromEntity HABNMNCIIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<Entity> PKDMCLNHHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<Entity> NKNEOHGDMEC;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7766F60", Offset = "0x7766160", VA = "0x187766F60", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class MJBOIPFGLEB
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class AHPIJAOHPHJ
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3BD0720", Offset = "0x3BCF920", VA = "0x183BD0720")]
	public static bool FJMIEANHJBL<T>(this NativeArray<Entity> PKDMCLNHHNE, EntityManager HOPEOGNNILD, Allocator JNKCCGKBKPB = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class KDNOIEFAALF
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class IEIGFBLEBHD<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		public IEIGFBLEBHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class IGKCMGODAJE<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public IGKCMGODAJE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly List<Func<JobHandle, JobHandle>> MDPFCKCKKFA;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7766ED0", Offset = "0x77660D0", VA = "0x187766ED0")]
	public KDNOIEFAALF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class HLCLEODALNK
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class DBOAPEMKMBF
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct MGIIFNHNDNP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct JHBNFNDFOCO<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal MGIIFNHNDNP<TFrom> JNGEIJHHFEP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator JNKCCGKBKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeArray<TFrom> HDPIMFNJLMN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct CBLOIIPEJCE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct BHHCMPPMNOB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal CBLOIIPEJCE<TFrom> JNGEIJHHFEP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator JNKCCGKBKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeList<TFrom> HDPIMFNJLMN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct JMADCDFHPGM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct EIDGFJGJACD<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal JMADCDFHPGM<TFrom> JNGEIJHHFEP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator JNKCCGKBKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeArrayAsync<TFrom> HDPIMFNJLMN;
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct GACOOPCGOHN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public struct INNLCHGBMBL<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			internal GACOOPCGOHN<TFrom> JNGEIJHHFEP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal Allocator JNKCCGKBKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal NativeListAsync<TFrom> HDPIMFNJLMN;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class BNFNOEJPCAL
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class JLAJJAHPPJD
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x34F8DD0", Offset = "0x34F7FD0", VA = "0x1834F8DD0")]
	public static NativeList<T> KOACMMHALIC<T>(this NativeArray<T> MFDBHAMLAOJ, Allocator JNKCCGKBKPB = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class OGBKIOJCMLB
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class GHGACOCADGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3492470", Offset = "0x3491670", VA = "0x183492470")]
	[BAEBENKNABL]
	public static JobHandle KOFPNEHHCCD<T>(this EntityCommandBufferSystem CBICMHAFCJG, NativeArray<Entity> DNOHLBIMBBG, NativeArray<T> LJELDKAOCJM) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3492560", Offset = "0x3491760", VA = "0x183492560")]
	[BAEBENKNABL]
	public static JobHandle KOFPNEHHCCD<T>(this EntityCommandBufferSystem CBICMHAFCJG, NativeArrayAsync<Entity> DNOHLBIMBBG, NativeArrayAsync<T> LJELDKAOCJM, [Optional] JobHandle MHNOHFAPILH) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3492340", Offset = "0x3491540", VA = "0x183492340")]
	[BAEBENKNABL]
	public static JobHandle KOFPNEHHCCD<T>(this EntityCommandBufferSystem CBICMHAFCJG, NativeArray<Entity> DNOHLBIMBBG, [Optional] JobHandle MHNOHFAPILH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x77666F0", Offset = "0x77658F0", VA = "0x1877666F0")]
	[BAEBENKNABL]
	public static JobHandle KOFPNEHHCCD(this EntityCommandBufferSystem CBICMHAFCJG, NativeArray<Entity> DNOHLBIMBBG, ComponentTypes ENONKMHIKCG, [Optional] JobHandle MHNOHFAPILH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x77665A0", Offset = "0x77657A0", VA = "0x1877665A0")]
	[BAEBENKNABL]
	public static JobHandle KOFPNEHHCCD(this EntityCommandBufferSystem CBICMHAFCJG, EntityCommandBuffer OPMFHEKLOJO, NativeArray<Entity> DNOHLBIMBBG, ComponentTypes ENONKMHIKCG, [Optional] JobHandle MHNOHFAPILH)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class EKEEMCCCKGF
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class APFHLLOBHDF
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7766090", Offset = "0x7765290", VA = "0x187766090")]
	[BAEBENKNABL]
	public static JobHandle DFJLDPKHONC(this EntityCommandBufferSystem CBICMHAFCJG, NativeList<Entity> DNOHLBIMBBG, [Optional] JobHandle MHNOHFAPILH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7765F90", Offset = "0x7765190", VA = "0x187765F90")]
	[BAEBENKNABL]
	public static JobHandle DFJLDPKHONC(this EntityCommandBufferSystem CBICMHAFCJG, NativeArrayAsync<Entity> DNOHLBIMBBG)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class CCJOGPGMELP
{
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class GOMDIFGLJAJ
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x34A0F40", Offset = "0x34A0140", VA = "0x1834A0F40")]
	[BAEBENKNABL]
	public static JobHandle ODGCCAEOADO<T>(this EntityCommandBufferSystem CBICMHAFCJG, NativeArray<Entity> DNOHLBIMBBG, NativeArray<T> LJELDKAOCJM, JobHandle MHNOHFAPILH) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class AMCGBCLKHJA
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class NIOKJBDGBGM
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class JBLGGODCDFE
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x34EE0C0", Offset = "0x34ED2C0", VA = "0x1834EE0C0")]
	public static NativeArray<T> NJPFCONOPMM<T>(this NativeList<Entity> MFDBHAMLAOJ, EntityManager HOPEOGNNILD, Allocator JNKCCGKBKPB = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x34EDEE0", Offset = "0x34ED0E0", VA = "0x1834EDEE0")]
	public static NativeArray<T> NJPFCONOPMM<T>(this NativeArray<Entity> MFDBHAMLAOJ, EntityManager HOPEOGNNILD, Allocator JNKCCGKBKPB = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7766C20", Offset = "0x7765E20", VA = "0x187766C20")]
	public static NativeArray<Entity> JFKNHGBOIAB(this NativeArray<Entity> MFDBHAMLAOJ, EntityManager HOPEOGNNILD, ComponentType JAEFMBPDGPB, Allocator JNKCCGKBKPB = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x34EDDE0", Offset = "0x34ECFE0", VA = "0x1834EDDE0")]
	public static NativeArray<T> FLKNBBAHJGO<T>(this NativeArray<Entity> MFDBHAMLAOJ, EntityManager HOPEOGNNILD, Allocator JNKCCGKBKPB = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class ENINLJJBAEE
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct OIMKADBGKLN<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct GAOOKGINFFG<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public OIMKADBGKLN<TFrom> HDPIMFNJLMN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator JNKCCGKBKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArray<TFrom> DCLKBIAKCEH;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct DNDMIBIEEOG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct BNMEGPECIBJ<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public DNDMIBIEEOG<TFrom> HDPIMFNJLMN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator JNKCCGKBKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeArrayAsync<TFrom> DCLKBIAKCEH;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct PCFBJGDPPOH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public struct OOCJBLFFACK<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public PCFBJGDPPOH<TFrom> HDPIMFNJLMN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator JNKCCGKBKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeListAsync<TFrom> DCLKBIAKCEH;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class GGOKEGJAEBG
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class CFCMDBJBCFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct MLDFDMOOKKF : IJHDIIKPNDI<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> DJDNPFFAIGO;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7767000", Offset = "0x7766200", VA = "0x187767000")]
		[BurstCompatible]
		public Entity JDODKOHLKAP([In] Entity OMFJNFBDJCA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7767000", Offset = "0x7766200", VA = "0x187767000", Slot = "4")]
		private Entity PHCLMGJBDHA([In] Entity OMFJNFBDJCA)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class KDKPCDLLGLO
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct IJEOIKPMHEH<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x477AE70", Offset = "0x477A070", VA = "0x18477AE70", Slot = "4")]
		public int Compare((TKey, TValue) NNDJDIFFAID, (TKey, TValue) AMFIBFNKFFJ)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3522540", Offset = "0x3521740", VA = "0x183522540")]
	public static void BDPEHPPMFFK<TKey, TValue>(NativeList<TKey> ILCILCLKBAH, NativeList<TValue> ALKPNNHBNLO) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3522370", Offset = "0x3521570", VA = "0x183522370")]
	public static void BDPEHPPMFFK<TKey, TValue>(NativeArray<TKey> ILCILCLKBAH, NativeArray<TValue> ALKPNNHBNLO) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x35227C0", Offset = "0x35219C0", VA = "0x1835227C0")]
	public static void BDPEHPPMFFK<TKey, TValue, U>(NativeArray<TKey> ILCILCLKBAH, NativeArray<TValue> ALKPNNHBNLO, U HAPIAGJLMDK) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class BCDLLIKJOKO
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct HBCACLOHGPN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator JNKCCGKBKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<Entity> ABPIOMFBJPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> DCLKBIAKCEH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct GLOFNDDKOID<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator JNKCCGKBKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeList<Entity> ABPIOMFBJPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArray<T> DCLKBIAKCEH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct NBGMINNDGLA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator JNKCCGKBKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArrayAsync<Entity> ABPIOMFBJPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArrayAsync<T> DCLKBIAKCEH;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class FKABNLDOMNO
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class DEAIALMOBHO
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct KJLCCCDDCNB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator JNKCCGKBKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArray<T> DCLKBIAKCEH;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct CNNKBBPJNAB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator JNKCCGKBKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeList<T> DCLKBIAKCEH;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct MDJLEEIDBEI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator JNKCCGKBKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<T> DCLKBIAKCEH;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct NLANLMAPOJI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Allocator JNKCCGKBKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NativeListAsync<T> DCLKBIAKCEH;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class JBGPAMNDMKB
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class KGKNMCHLKMG
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3527D70", Offset = "0x3526F70", VA = "0x183527D70")]
	public static NativeList<Entity> IGGPENDAMJO<T>(this NativeList<Entity> PKDMCLNHHNE, EntityManager HOPEOGNNILD, Allocator JNKCCGKBKPB = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3527730", Offset = "0x3526930", VA = "0x183527730")]
	public static NativeList<Entity> IGGPENDAMJO<T>(this NativeArray<Entity> PKDMCLNHHNE, EntityManager HOPEOGNNILD, Allocator JNKCCGKBKPB = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class NKLMGHAGCOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x36160C0", Offset = "0x36152C0", VA = "0x1836160C0")]
	public static NativeList<Entity> BEOJDMJMECJ<T>(this NativeArray<Entity> PKDMCLNHHNE, EntityManager HOPEOGNNILD, Allocator JNKCCGKBKPB = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class LGPPPBNKALD
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public readonly struct CCPKOKFOJAL<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> LGLFHJLCKKH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public readonly struct MDBGILJDKCM<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> LGLFHJLCKKH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public readonly struct DLIHCJBBFDJ<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, IJHDIIKPNDI<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly NativeArray<TSrc> LGLFHJLCKKH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct IDBIACNOIMO<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, IJHDIIKPNDI<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly NativeArray<TSrc> LGLFHJLCKKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TSelector HKKGLPOJHMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int KOOLKCPAFBB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct PNPHGLHHNLF<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, IJHDIIKPNDI<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private IDBIACNOIMO<TSrc, TValue, TSelector> IAHCPHAJMBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TValue BINADNACNMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int JMHJAFCGEDO;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class BAIPOBEAIIP
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct MNMIIDFDAKO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<T> LGLFHJLCKKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int JMHJAFCGEDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int DCFMCEBBNEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private T BINADNACNMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T MNDDDBNMOOC;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public AIKFLEGLMCF PKAGEDFPAHI
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x4A947B0", Offset = "0x4A939B0", VA = "0x184A947B0")]
			get
			{
				return default(AIKFLEGLMCF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public T MDGFMPAHAKI
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public (T, AIKFLEGLMCF) PEOKKFBMNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x4A94A70", Offset = "0x4A93C70", VA = "0x184A94A70")]
			get
			{
				return default((T, AIKFLEGLMCF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x4DB3480", Offset = "0x4DB2680", VA = "0x184DB3480")]
		public MNMIIDFDAKO(NativeArray<T> LGLFHJLCKKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x41C4610", Offset = "0x41C3810", VA = "0x1841C4610")]
		public MNMIIDFDAKO<T> PACLDABBHPO()
		{
			return default(MNMIIDFDAKO<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x4DB2FF0", Offset = "0x4DB21F0", VA = "0x184DB2FF0")]
		public bool NFFHEIPLBGA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3846A00", Offset = "0x3845C00", VA = "0x183846A00")]
		public KJAIFGOKNLC<T, TComparer> PBBNLIDOFGC<TComparer>([Optional] TComparer HAPIAGJLMDK) where TComparer : struct, IEqualityComparer<T>
		{
			return default(KJAIFGOKNLC<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct KJAIFGOKNLC<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly NativeArray<T> LGLFHJLCKKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int JMHJAFCGEDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int DCFMCEBBNEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private T BINADNACNMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private T MNDDDBNMOOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TComparer HAPIAGJLMDK;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public AIKFLEGLMCF PKAGEDFPAHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x4A947B0", Offset = "0x4A939B0", VA = "0x184A947B0")]
			get
			{
				return default(AIKFLEGLMCF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T MDGFMPAHAKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public (T value, AIKFLEGLMCF range) PEOKKFBMNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x4A94A70", Offset = "0x4A93C70", VA = "0x184A94A70")]
			get
			{
				return default((T, AIKFLEGLMCF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4A94BF0", Offset = "0x4A93DF0", VA = "0x184A94BF0")]
		public KJAIFGOKNLC(NativeArray<T> LGLFHJLCKKH, TComparer HAPIAGJLMDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x32C71E0", Offset = "0x32C63E0", VA = "0x1832C71E0")]
		public KJAIFGOKNLC<T, TComparer> PACLDABBHPO()
		{
			return default(KJAIFGOKNLC<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4A94920", Offset = "0x4A93B20", VA = "0x184A94920")]
		public bool NFFHEIPLBGA()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x31F01D0", Offset = "0x31EF3D0", VA = "0x1831F01D0")]
	public static MNMIIDFDAKO<T> DMIKCHDEIME<T>(this NativeArray<T> LGLFHJLCKKH) where T : struct
	{
		return default(MNMIIDFDAKO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface JHGAPPNPHHB
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class LMBGEANMEJE
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct DNBHPLCGIIA<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class NABGEKMAHFN : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public DNBHPLCGIIA<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xAF8440", Offset = "0xAF7640", VA = "0x180AF8440", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default((int, Protobuf));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x45BBFA0", Offset = "0x45BB1A0", VA = "0x1845BBFA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x963B40", Offset = "0x962D40", VA = "0x180963B40")]
		[DebuggerHidden]
		public NABGEKMAHFN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4E10D10", Offset = "0x4E0FF10", VA = "0x184E10D10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x4E10EE0", Offset = "0x4E100E0", VA = "0x184E10EE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly Action<Protobuf> KOKMLHLNKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MemoryStream HENNMDJFPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CodedInputStream JPIJLPBEIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Protobuf GHJPMHHACDK;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly int MCIABBAIGFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xAE2F30", Offset = "0xAE2130", VA = "0x180AE2F30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x63EA720", Offset = "0x63E9920", VA = "0x1863EA720", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x63EA760", Offset = "0x63E9960", VA = "0x1863EA760", Slot = "4")]
	[IteratorStateMachine(typeof(DNBHPLCGIIA<>.NABGEKMAHFN))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x63EA860", Offset = "0x63E9A60", VA = "0x1863EA860", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct JCEBLPMIJEN<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly byte[] LPBGEKCBGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Protobuf GHJPMHHACDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream HENNMDJFPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedOutputStream PHFCFMNEAFP;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4958CD0", Offset = "0x4957ED0", VA = "0x184958CD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct CCDLCKHDCLB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream HENNMDJFPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedInputStream JPIJLPBEIMF;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7766220", Offset = "0x7765420", VA = "0x187766220", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct AGEEIOGIFCJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] LPBGEKCBGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly MemoryStream HENNMDJFPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly CodedOutputStream PHFCFMNEAFP;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7765E70", Offset = "0x7765070", VA = "0x187765E70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class KBFJNJFJELE
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class FEIDMFOGPCJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[Flags]
public enum COMJKBNJGPP
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
internal static class KALNOFFFOCN
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class DCKHMIAOKJO
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public DCKHMIAOKJO()
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
