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
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A60F80", Offset = "0x6A5FF80", VA = "0x186A60F80")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IFEHJAGOEKO : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	EBLIKEEJFDD KJFOPJMOHIC
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
public interface FGGPONIFCOH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JAEHGEFDFGE(Entity JOAHHHNEJGM, object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NHMLNFGHJFO(Entity JOAHHHNEJGM, object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OIAGGLCOINL(Entity JOAHHHNEJGM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class MOBINMFPFBA<TComponentData, TValue> : DPOLAJOHKFK<TValue>, IDisposable where TComponentData : struct, IFEHJAGOEKO
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class EAMMOLJDIEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> DNOAHHGKGFF;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int FGAKKPCAMNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3574890", Offset = "0x3573890", VA = "0x183574890")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x37DFF50", Offset = "0x37DEF50", VA = "0x1837DFF50")]
		public bool MJCCDLHFNGB([Out] TValue CBAEIEAPLIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x37E0060", Offset = "0x37DF060", VA = "0x1837E0060")]
		public void MJFEDCBJOBF(object OEDJKICDDGA, TValue CBAEIEAPLIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x37DFD90", Offset = "0x37DED90", VA = "0x1837DFD90")]
		public bool GAGDAFIMOPK(object OEDJKICDDGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x37DFE50", Offset = "0x37DEE50", VA = "0x1837DFE50")]
		public int KNGEDAAOIAE(object OEDJKICDDGA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x37E0150", Offset = "0x37DF150", VA = "0x1837E0150")]
		public EAMMOLJDIEB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<EAMMOLJDIEB> LLNBIODNBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private FJOOEIFJBJH<EBLIKEEJFDD, EAMMOLJDIEB> DJLHKKLHJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager EHDLNANHIAB;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4506EF0", Offset = "0x4505EF0", VA = "0x184506EF0")]
	public MOBINMFPFBA(EntityManager EHDLNANHIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4506830", Offset = "0x4505830", VA = "0x184506830", Slot = "4")]
	public void JAEHGEFDFGE(Entity JOAHHHNEJGM, object OEDJKICDDGA, TValue CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4506CE0", Offset = "0x4505CE0", VA = "0x184506CE0", Slot = "5")]
	public bool NHMLNFGHJFO(Entity JOAHHHNEJGM, object OEDJKICDDGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4506BC0", Offset = "0x4505BC0", VA = "0x184506BC0", Slot = "6")]
	public bool MJCCDLHFNGB(Entity JOAHHHNEJGM, [Out] TValue CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4506640", Offset = "0x4505640", VA = "0x184506640", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4506660", Offset = "0x4505660", VA = "0x184506660")]
	private void FMFAONCEKNC(EAMMOLJDIEB ADBCOPDPENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x45069C0", Offset = "0x45059C0", VA = "0x1845069C0")]
	private bool KCJGAOALIMD(Entity JOAHHHNEJGM, [Out] EBLIKEEJFDD JNKGLDBBIBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4506730", Offset = "0x4505730", VA = "0x184506730")]
	private void IIOENMOHDGB(Entity JOAHHHNEJGM, EBLIKEEJFDD JNKGLDBBIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4506620", Offset = "0x4505620", VA = "0x184506620")]
	private bool CICFBDELEOF(EBLIKEEJFDD JNKGLDBBIBB, [Out] EAMMOLJDIEB ADBCOPDPENJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4506A90", Offset = "0x4505A90", VA = "0x184506A90")]
	private EAMMOLJDIEB LAFBHCFNHAM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DPOLAJOHKFK<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JAEHGEFDFGE(Entity JOAHHHNEJGM, object OEDJKICDDGA, TValue CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NHMLNFGHJFO(Entity JOAHHHNEJGM, object OEDJKICDDGA);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MJCCDLHFNGB(Entity JOAHHHNEJGM, [Out] TValue CBAEIEAPLIH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct EBLIKEEJFDD : BNGFLHDNNIJ, IEquatable<EBLIKEEJFDD>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly EBLIKEEJFDD GCMJGJIPGKE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int FPNFNABMIOF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA8D560", Offset = "0xA8C560", VA = "0x180A8D560", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA8D540", Offset = "0xA8C540", VA = "0x180A8D540", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int HJHABCPEMBO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2550DE0", Offset = "0x254FDE0", VA = "0x182550DE0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5D54330", Offset = "0x5D53330", VA = "0x185D54330", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6A60EE0", Offset = "0x6A5FEE0", VA = "0x186A60EE0", Slot = "8")]
	public bool Equals(EBLIKEEJFDD LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A60F30", Offset = "0x6A5FF30", VA = "0x186A60F30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class KBGPCINPCAH<THasTokensTag> : FGGPONIFCOH, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly ICJNMGNJFIN CAJBNIGHKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, EBLIKEEJFDD> PDAIBAMEPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> LLNBIODNBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private FJOOEIFJBJH<EBLIKEEJFDD, HashSet<object>> DJLHKKLHJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager EHDLNANHIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem ECDCJPCEIAL;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x41ED9E0", Offset = "0x41EC9E0", VA = "0x1841ED9E0")]
	public KBGPCINPCAH(EntityManager EHDLNANHIAB, EntityCommandBufferSystem ECDCJPCEIAL, ICJNMGNJFIN PCFMAFGGCMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x41EBC00", Offset = "0x41EAC00", VA = "0x1841EBC00", Slot = "4")]
	public bool JAEHGEFDFGE(Entity JOAHHHNEJGM, object OEDJKICDDGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x41EC860", Offset = "0x41EB860", VA = "0x1841EC860", Slot = "5")]
	public bool NHMLNFGHJFO(Entity JOAHHHNEJGM, object OEDJKICDDGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x41ECD70", Offset = "0x41EBD70", VA = "0x1841ECD70", Slot = "6")]
	public bool OIAGGLCOINL(Entity JOAHHHNEJGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x41ECE20", Offset = "0x41EBE20", VA = "0x1841ECE20", Slot = "8")]
	public bool OIAGGLCOINL(EBLIKEEJFDD JNKGLDBBIBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x41EAEB0", Offset = "0x41E9EB0", VA = "0x1841EAEB0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x41EB010", Offset = "0x41EA010", VA = "0x1841EB010")]
	private void FMFAONCEKNC(HashSet<object> ADBCOPDPENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x41EC360", Offset = "0x41EB360", VA = "0x1841EC360")]
	private bool KCJGAOALIMD(Entity JOAHHHNEJGM, [Out] EBLIKEEJFDD JNKGLDBBIBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x41EBE80", Offset = "0x41EAE80", VA = "0x1841EBE80")]
	private bool JLLDDLHMMBH(Entity JOAHHHNEJGM, [Out] EBLIKEEJFDD JNKGLDBBIBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x41EB200", Offset = "0x41EA200", VA = "0x1841EB200")]
	private void GDLLENBCALM(Entity JOAHHHNEJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x41ED3B0", Offset = "0x41EC3B0", VA = "0x1841ED3B0")]
	private void PPAGOFJCOBJ(Entity JOAHHHNEJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x41EAC50", Offset = "0x41E9C50", VA = "0x1841EAC50")]
	private void BOBFKDLIHAG(Entity JOAHHHNEJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x41EB530", Offset = "0x41EA530", VA = "0x1841EB530")]
	private void IIOENMOHDGB(Entity JOAHHHNEJGM, EBLIKEEJFDD JNKGLDBBIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x41ED1E0", Offset = "0x41EC1E0", VA = "0x1841ED1E0")]
	private bool PJPKNFKMJEA(EBLIKEEJFDD JNKGLDBBIBB, [Out] HashSet<object> ADBCOPDPENJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x41EC4D0", Offset = "0x41EB4D0", VA = "0x1841EC4D0")]
	private HashSet<object> LAFBHCFNHAM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class IBMMDKLJPKB
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct JLEAGIOCADE : FOFANDPCFMO<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6A619A0", Offset = "0x6A609A0", VA = "0x186A619A0")]
	public float ICFHAODEJKH([In] float3 CBAEIEAPLIH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6A619A0", Offset = "0x6A609A0", VA = "0x186A619A0", Slot = "4")]
	private float OMNNNKLPNIJ([In] float3 CBAEIEAPLIH)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct BDIKCFJHDDG : FOFANDPCFMO<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6A60E40", Offset = "0x6A5FE40", VA = "0x186A60E40")]
	public float ICFHAODEJKH([In] float3 CBAEIEAPLIH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6A60E40", Offset = "0x6A5FE40", VA = "0x186A60E40", Slot = "4")]
	private float OMNNNKLPNIJ([In] float3 CBAEIEAPLIH)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct EBFAAKMKIMD : FOFANDPCFMO<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1CD6CB0", Offset = "0x1CD5CB0", VA = "0x181CD6CB0")]
	public float ICFHAODEJKH([In] float3 CBAEIEAPLIH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1CD6CB0", Offset = "0x1CD5CB0", VA = "0x181CD6CB0", Slot = "4")]
	private float OMNNNKLPNIJ([In] float3 CBAEIEAPLIH)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct IMJOHEFCMEF : FOFANDPCFMO<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x15A92C0", Offset = "0x15A82C0", VA = "0x1815A92C0")]
	public int ICFHAODEJKH([In] int3 CBAEIEAPLIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x15A92C0", Offset = "0x15A82C0", VA = "0x1815A92C0", Slot = "4")]
	private int EJMMCNOMCJD([In] int3 CBAEIEAPLIH)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct JBCKANLCIPM : FOFANDPCFMO<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6A61990", Offset = "0x6A60990", VA = "0x186A61990")]
	public int ICFHAODEJKH([In] int3 CBAEIEAPLIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6A61990", Offset = "0x6A60990", VA = "0x186A61990", Slot = "4")]
	private int EJMMCNOMCJD([In] int3 CBAEIEAPLIH)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct NFIDEAGCPHE : FOFANDPCFMO<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1754AB0", Offset = "0x1753AB0", VA = "0x181754AB0")]
	public int ICFHAODEJKH([In] int3 CBAEIEAPLIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1754AB0", Offset = "0x1753AB0", VA = "0x181754AB0", Slot = "4")]
	private int EJMMCNOMCJD([In] int3 CBAEIEAPLIH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class DLDKAINFGBD : GODPKMDNFNE
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x14E9870", Offset = "0x14E8870", VA = "0x1814E9870")]
	public DLDKAINFGBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class BBOLIBOODPP : SystemBase, LHHDIIKFJJL
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6A60DC0", Offset = "0x6A5FDC0", VA = "0x186A60DC0")]
	public JobHandle LIKBFKJHBBI(ReadOnlySpan<int> KFJKFIBFNGA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x28BC860", Offset = "0x28BB860", VA = "0x1828BC860")]
	public void JPLKILPPIID<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x28BCD50", Offset = "0x28BBD50", VA = "0x1828BCD50")]
	public JobHandle JPLKILPPIID<T>(JobHandle JNKGLDBBIBB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6A60D50", Offset = "0x6A5FD50", VA = "0x186A60D50")]
	public JobHandle JPLKILPPIID(ReadOnlySpan<int> KFJKFIBFNGA, JobHandle JNKGLDBBIBB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x28BC860", Offset = "0x28BB860", VA = "0x1828BC860")]
	public void BGBICBPDJIJ<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x28BC4E0", Offset = "0x28BB4E0", VA = "0x1828BC4E0")]
	public JobHandle BGBICBPDJIJ<T>(JobHandle JNKGLDBBIBB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6A60C90", Offset = "0x6A5FC90", VA = "0x186A60C90")]
	public ComponentDataFromEntity AAEEKPHFHDH(int OPLDNLPEEPG, bool HMEODBHHKLA = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6A60E10", Offset = "0x6A5FE10", VA = "0x186A60E10")]
	public EntityExistenceLookupByEntity PHOHHCLNJKO()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6A60E30", Offset = "0x6A5FE30", VA = "0x186A60E30", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x14E9870", Offset = "0x14E8870", VA = "0x1814E9870")]
	protected BBOLIBOODPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class KNDGAJPABPL : BBOLIBOODPP
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6A61A50", Offset = "0x6A60A50", VA = "0x186A61A50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x14E9870", Offset = "0x14E8870", VA = "0x1814E9870")]
	protected KNDGAJPABPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class HLKPCMEGJCF
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class OKOGHIEECNF : EntityCommandBufferSystem, LHHDIIKFJJL
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x14E9870", Offset = "0x14E8870", VA = "0x1814E9870")]
	protected OKOGHIEECNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FOFANDPCFMO<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo ICFHAODEJKH([In] TFrom CBAEIEAPLIH);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface EBFCCMCCHIE<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NOGNDBMLADG(T CBAEIEAPLIH);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BurstCompile]
internal struct HHELOJMFOAN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[ReadOnly]
	public NativeArray<Entity> GOBIGKPCBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public EntityCommandBuffer AAACHMIDDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public ComponentTypes BCLAAAOJFDI;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6A61570", Offset = "0x6A60570", VA = "0x186A61570", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct JLEPDCKNNFP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[ReadOnly]
	public NativeArray<Entity> GOBIGKPCBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public EntityCommandBuffer AAACHMIDDAD;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6A619B0", Offset = "0x6A609B0", VA = "0x186A619B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct MJIPNCHCBPD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public NativeArray<Entity> GOBIGKPCBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public EntityCommandBuffer AAACHMIDDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public ComponentType KENNFFELPHA;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6A61B80", Offset = "0x6A60B80", VA = "0x186A61B80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct ODPBFDGGBNI<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	[ReadOnly]
	public NativeArray<Entity> GOBIGKPCBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<T> FHNKDHIILBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer AAACHMIDDAD;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x46832D0", Offset = "0x46822D0", VA = "0x1846832D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal struct GLJBPOMKOCB<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<Entity> GOBIGKPCBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<T> CNNODMDOLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public EntityCommandBuffer AAACHMIDDAD;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct ECFMFPJKGCC<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<Entity> GOBIGKPCBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public T CBAEIEAPLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public EntityCommandBuffer AAACHMIDDAD;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x37E4900", Offset = "0x37E3900", VA = "0x1837E4900", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BurstCompile]
internal struct GBPLEHBNEEP<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, FOFANDPCFMO<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[ReadOnly]
	public NativeArray<TFrom> HJIBGCEHFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[WriteOnly]
	public NativeArray<TTo> IMJCKEABDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public TMap OGLJLDNLGIJ;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct LPHIEJMAECO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[ReadOnly]
	public ComponentDataFromEntity JHENFKNNICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<Entity> HJIBGCEHFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<byte> IMJCKEABDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int JIBKMDCHNFJ;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6A61A80", Offset = "0x6A60A80", VA = "0x186A61A80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct JHGJOPIMDCG<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity<T> AOOCKAEILOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> HJIBGCEHFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeList<T> ILHMOKHOKOI;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct ELCACNCKMDD<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, FOFANDPCFMO<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public NativeArray<TFrom> AEJNMMFBHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[WriteOnly]
	public NativeList<TTo> IMJCKEABDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public TMap OGLJLDNLGIJ;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct CMMNDFKAFGJ<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public ComponentDataFromEntity<T> CHBDDBLHPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<Entity> LLICOMKFJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<bool> PGANDGHEDEL;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct GLBAALMPENF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ComponentDataFromEntity<T> CHBDDBLHPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public NativeArray<Entity> LLICOMKFJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public NativeArray<bool> PGANDGHEDEL;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3D4B2D0", Offset = "0x3D4A2D0", VA = "0x183D4B2D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct DBNPHHDENAF<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<T> HJIBGCEHFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeList<T> ILHMOKHOKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeParallelHashSet<T> MNOLCMCDDNK;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x57F6FC0", Offset = "0x57F5FC0", VA = "0x1857F6FC0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct BBPLCMCDEHG<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : FOFANDPCFMO<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public NativeArray<TFrom> HJIBGCEHFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeList<TFrom> ILHMOKHOKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeParallelHashSet<TTo> MNOLCMCDDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public TMap OGLJLDNLGIJ;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct KGJPPLAHFMM<T, TPredicate> : IJob where T : struct where TPredicate : struct, EBFCCMCCHIE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<T> HJIBGCEHFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public NativeArray<Entity> KIHIDAOHBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeList<Entity> JIOLMGLLMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TPredicate OGLJLDNLGIJ;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct MLJHDNABCML<T, TPredicate> : IJob where T : struct where TPredicate : struct, EBFCCMCCHIE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> HJIBGCEHFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public NativeList<T> ILHMOKHOKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public TPredicate OGLJLDNLGIJ;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct CLCHGCDFJIE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public ComponentDataFromEntity CHBDDBLHPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<Entity> LLICOMKFJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<Entity> CNEHACOHAAI;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6A60E50", Offset = "0x6A5FE50", VA = "0x186A60E50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct MKEGMAJGJCC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[ReadOnly]
	public ComponentDataFromEntity CHBDDBLHPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<Entity> LLICOMKFJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<Entity> CNEHACOHAAI;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6A61C00", Offset = "0x6A60C00", VA = "0x186A61C00", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class OANGMMIDNBE
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class BMOMGNAFHAO
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x28CB760", Offset = "0x28CA760", VA = "0x1828CB760")]
	public static bool MFEHGPEKFBG<T>(this NativeArray<Entity> LLICOMKFJEC, EntityManager EHDLNANHIAB, Allocator IDMGOAKOEDG = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class IDPNHHOPOFJ
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class JLMNECEOGFK<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		public JLMNECEOGFK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class MKFLLABLJOL<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		public MKFLLABLJOL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<Func<JobHandle, JobHandle>> AFODIEKPJDG;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6A61900", Offset = "0x6A60900", VA = "0x186A61900")]
	public IDPNHHOPOFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class ALDCJHAANHI
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class PNDLHLLNPNF
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct GNENHKCGPAA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct AMGJADFAFJC<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			internal GNENHKCGPAA<TFrom> HHMPHBNGMGF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal Allocator IDMGOAKOEDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal NativeArray<TFrom> LPPNOBMEEDD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct BGLOGJJJGKA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct OINBCHOGGPB<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			internal BGLOGJJJGKA<TFrom> HHMPHBNGMGF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal Allocator IDMGOAKOEDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal NativeList<TFrom> LPPNOBMEEDD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct AMLLGCKKACH<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct HPIJEHHHIHM<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			internal AMLLGCKKACH<TFrom> HHMPHBNGMGF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal Allocator IDMGOAKOEDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal NativeArrayAsync<TFrom> LPPNOBMEEDD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct GJJDGEICALG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct PJEHAPMHFNO<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			internal GJJDGEICALG<TFrom> HHMPHBNGMGF;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal Allocator IDMGOAKOEDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal NativeListAsync<TFrom> LPPNOBMEEDD;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class EKCCCAOJCIA
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class IFKAIEJFPAI
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2B48870", Offset = "0x2B47870", VA = "0x182B48870")]
	public static NativeList<T> HPFGJFBMMBH<T>(this NativeArray<T> NEIPNMNDENL, Allocator IDMGOAKOEDG = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class LGJHLLKEIMD
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class FADGJHPNHDK
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2B04810", Offset = "0x2B03810", VA = "0x182B04810")]
	[PHBDFBAAEGM]
	public static JobHandle KANBMEFGDFP<T>(this EntityCommandBufferSystem ECDCJPCEIAL, NativeArrayAsync<Entity> GOBIGKPCBPO, NativeArrayAsync<T> FHNKDHIILBL, [Optional] JobHandle BJHOEPIEFDG) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2B04AC0", Offset = "0x2B03AC0", VA = "0x182B04AC0")]
	[PHBDFBAAEGM]
	public static JobHandle KANBMEFGDFP<T>(this EntityCommandBufferSystem ECDCJPCEIAL, NativeArrayAsync<Entity> GOBIGKPCBPO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2B04990", Offset = "0x2B03990", VA = "0x182B04990")]
	[PHBDFBAAEGM]
	public static JobHandle KANBMEFGDFP<T>(this EntityCommandBufferSystem ECDCJPCEIAL, NativeArray<Entity> GOBIGKPCBPO, [Optional] JobHandle BJHOEPIEFDG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6A60FA0", Offset = "0x6A5FFA0", VA = "0x186A60FA0")]
	[PHBDFBAAEGM]
	public static JobHandle KANBMEFGDFP(this EntityCommandBufferSystem ECDCJPCEIAL, NativeArray<Entity> GOBIGKPCBPO, ComponentTypes BCLAAAOJFDI, [Optional] JobHandle BJHOEPIEFDG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6A61110", Offset = "0x6A60110", VA = "0x186A61110")]
	[PHBDFBAAEGM]
	public static JobHandle KANBMEFGDFP(this EntityCommandBufferSystem ECDCJPCEIAL, EntityCommandBuffer AAACHMIDDAD, NativeArray<Entity> GOBIGKPCBPO, ComponentTypes BCLAAAOJFDI, [Optional] JobHandle BJHOEPIEFDG)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class AMACCCIHDCB
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x31BE270", Offset = "0x31BD270", VA = "0x1831BE270")]
	[PHBDFBAAEGM]
	public static JobHandle MIONNNKDBAI<T>(this EntityCommandBufferSystem ECDCJPCEIAL, EntityCommandBuffer AAACHMIDDAD, EntityQuery KGCOADJFKCN, T CBAEIEAPLIH) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class ICKIMLOMKAF
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6A61770", Offset = "0x6A60770", VA = "0x186A61770")]
	[PHBDFBAAEGM]
	public static JobHandle CJKNKIGDDCI(this EntityCommandBufferSystem ECDCJPCEIAL, NativeList<Entity> GOBIGKPCBPO, [Optional] JobHandle BJHOEPIEFDG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6A61670", Offset = "0x6A60670", VA = "0x186A61670")]
	[PHBDFBAAEGM]
	public static JobHandle CJKNKIGDDCI(this EntityCommandBufferSystem ECDCJPCEIAL, NativeArrayAsync<Entity> GOBIGKPCBPO)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class IIIDDABEPJL
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class IGIJDAOEBIB
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2B48D20", Offset = "0x2B47D20", VA = "0x182B48D20")]
	[PHBDFBAAEGM]
	public static JobHandle EJAHPHMCDPC<T>(this EntityCommandBufferSystem ECDCJPCEIAL, NativeArray<Entity> GOBIGKPCBPO, NativeArray<T> FHNKDHIILBL, JobHandle BJHOEPIEFDG) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class HKLJMEMOEDK
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2B27090", Offset = "0x2B26090", VA = "0x182B27090")]
	[PHBDFBAAEGM]
	public static JobHandle FHGEMIJMGOE<T>(this EntityCommandBufferSystem ECDCJPCEIAL, NativeArray<Entity> GOBIGKPCBPO, T CBAEIEAPLIH, [Optional] JobHandle BJHOEPIEFDG) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2B26FB0", Offset = "0x2B25FB0", VA = "0x182B26FB0")]
	[PHBDFBAAEGM]
	public static JobHandle FHGEMIJMGOE<T>(this EntityCommandBufferSystem ECDCJPCEIAL, EntityCommandBuffer AAACHMIDDAD, NativeArray<Entity> GOBIGKPCBPO, T CBAEIEAPLIH, [Optional] JobHandle BJHOEPIEFDG) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class OOPDOIOBCPJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class FNFEMPGOOHK
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2B10070", Offset = "0x2B0F070", VA = "0x182B10070")]
	public static NativeArray<T> NAOPHDOOEPC<T>(this NativeList<Entity> NEIPNMNDENL, EntityManager EHDLNANHIAB, Allocator IDMGOAKOEDG = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2B0FAD0", Offset = "0x2B0EAD0", VA = "0x182B0FAD0")]
	public static NativeArray<T> NAOPHDOOEPC<T>(this NativeArray<Entity> NEIPNMNDENL, EntityManager EHDLNANHIAB, Allocator IDMGOAKOEDG = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6A61260", Offset = "0x6A60260", VA = "0x186A61260")]
	public static NativeArray<Entity> JIGFFMIGPFB(this NativeArray<Entity> NEIPNMNDENL, EntityManager EHDLNANHIAB, ComponentType KENNFFELPHA, Allocator IDMGOAKOEDG = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2B10140", Offset = "0x2B0F140", VA = "0x182B10140")]
	public static NativeArray<T> NJMGEIHGDHM<T>(this NativeArray<Entity> NEIPNMNDENL, EntityManager EHDLNANHIAB, Allocator IDMGOAKOEDG = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class GLJNBPHKDOE
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct HEFGPBCPJMD<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct ALNGFOEAFLJ<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public HEFGPBCPJMD<TFrom> LPPNOBMEEDD;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public Allocator IDMGOAKOEDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeArray<TFrom> HJIBGCEHFCP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct DDJKANGDINE<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct OFDJACPPCAH<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public DDJKANGDINE<TFrom> LPPNOBMEEDD;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Allocator IDMGOAKOEDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeArrayAsync<TFrom> HJIBGCEHFCP;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct COJOBOMCHFA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct EMBFBNEMAFL<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public COJOBOMCHFA<TFrom> LPPNOBMEEDD;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Allocator IDMGOAKOEDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public NativeListAsync<TFrom> HJIBGCEHFCP;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class LCLPLGGEAOL
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class LOCDLGGFABA
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct HLKEABKOOHG : FOFANDPCFMO<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> BCHDLDCDOFJ;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6A61660", Offset = "0x6A60660", VA = "0x186A61660")]
		[BurstCompatible]
		public Entity ICFHAODEJKH([In] Entity CBAEIEAPLIH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6A61660", Offset = "0x6A60660", VA = "0x186A61660", Slot = "4")]
		private Entity CDCFBMDJJJL([In] Entity CBAEIEAPLIH)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class KMFPFFGPGKO
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct IGPJNOLMAIL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator IDMGOAKOEDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeArray<Entity> KIHIDAOHBGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<T> HJIBGCEHFCP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct BFBBAIBADEB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Allocator IDMGOAKOEDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<Entity> KIHIDAOHBGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<T> HJIBGCEHFCP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct DACFAJLHBPP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Allocator IDMGOAKOEDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArrayAsync<Entity> KIHIDAOHBGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArrayAsync<T> HJIBGCEHFCP;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class NIEKJPNAENC
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class IABJOAJAEIM
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct CKCMFOGAHIN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Allocator IDMGOAKOEDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public NativeArray<T> HJIBGCEHFCP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct FGEAMMDJBOF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator IDMGOAKOEDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeList<T> HJIBGCEHFCP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct DBDOFBOHKOB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator IDMGOAKOEDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArrayAsync<T> HJIBGCEHFCP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct OIANCACPOGP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator IDMGOAKOEDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeListAsync<T> HJIBGCEHFCP;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class DBLPCMONIBC
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class PLIEJPLPOON
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2CD84E0", Offset = "0x2CD74E0", VA = "0x182CD84E0")]
	public static NativeList<Entity> COABKPCAFJL<T>(this NativeArray<Entity> LLICOMKFJEC, EntityManager EHDLNANHIAB, Allocator IDMGOAKOEDG = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class LIKIMDIDIJH
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class ACIFKMJKIBE
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public readonly struct MIGHAIEFIFP<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly NativeArray<TSrc> GGEMIJICFPG;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1FCAEE0", Offset = "0x1FC9EE0", VA = "0x181FCAEE0")]
		public MIGHAIEFIFP(NativeArray<TSrc> GGEMIJICFPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9D5DF0", Offset = "0x9D4DF0", VA = "0x1809D5DF0")]
		public KDEHCLKMAIM<TSrc, TValue> AJGBMAOCNEI<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(KDEHCLKMAIM<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct KDEHCLKMAIM<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NativeArray<TSrc> GGEMIJICFPG;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1FCAEE0", Offset = "0x1FC9EE0", VA = "0x181FCAEE0")]
		public KDEHCLKMAIM(NativeArray<TSrc> GGEMIJICFPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9D5DF0", Offset = "0x9D4DF0", VA = "0x1809D5DF0")]
		public PJFPJMKEMFB<TSrc, TValue, TSelector> HANNIJGNKJE<TSelector>() where TSelector : struct, FOFANDPCFMO<TSrc, TValue>
		{
			return default(PJFPJMKEMFB<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct PJFPJMKEMFB<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, FOFANDPCFMO<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> GGEMIJICFPG;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1FCAEE0", Offset = "0x1FC9EE0", VA = "0x181FCAEE0")]
		public PJFPJMKEMFB(NativeArray<TSrc> GGEMIJICFPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x47888A0", Offset = "0x47878A0", VA = "0x1847888A0")]
		public OLJELPALBCA<TSrc, TValue, TSelector> MMBNJBLDBML()
		{
			return default(OLJELPALBCA<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct LBFFIAPCIJK<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, FOFANDPCFMO<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> GGEMIJICFPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TSelector OOEOCNGCCGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int LLPJHIPCNFD;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TValue NKNICMABPJA
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x42C0D90", Offset = "0x42BFD90", VA = "0x1842C0D90")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int FPNFNABMIOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8D7510", Offset = "0x8D6510", VA = "0x1808D7510")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int DNIPBCBOHOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x1FEFC50", Offset = "0x1FEEC50", VA = "0x181FEFC50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x42C0EE0", Offset = "0x42BFEE0", VA = "0x1842C0EE0")]
		public LBFFIAPCIJK(NativeArray<TSrc> GGEMIJICFPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x42C0DD0", Offset = "0x42BFDD0", VA = "0x1842C0DD0")]
		public bool IEOEAKHLKGI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x42C0DE0", Offset = "0x42BFDE0", VA = "0x1842C0DE0")]
		private TSrc INDADLDEPLA(int JFDIHIMJIHB)
		{
			return (TSrc)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x42C0D00", Offset = "0x42BFD00", VA = "0x1842C0D00")]
		private TValue COCABBDONFD()
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct OLJELPALBCA<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, FOFANDPCFMO<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private LBFFIAPCIJK<TSrc, TValue, TSelector> JPEENEJPGDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TValue HCFJOHGPONG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private int GEIGDPFELPO;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public LEKMELECFFF LNDIDPOIMCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x46B8640", Offset = "0x46B7640", VA = "0x1846B8640")]
			get
			{
				return default(LEKMELECFFF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue OJCOMJAJFLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8687F0", Offset = "0x8677F0", VA = "0x1808687F0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, LEKMELECFFF range) NKNICMABPJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x46B83E0", Offset = "0x46B73E0", VA = "0x1846B83E0")]
			get
			{
				return default((TValue, LEKMELECFFF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x46B8680", Offset = "0x46B7680", VA = "0x1846B8680")]
		public OLJELPALBCA(NativeArray<TSrc> GGEMIJICFPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3C46B20", Offset = "0x3C45B20", VA = "0x183C46B20")]
		public OLJELPALBCA<TSrc, TValue, TSelector> AKHPNFMFJMK()
		{
			return default(OLJELPALBCA<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x46B84C0", Offset = "0x46B74C0", VA = "0x1846B84C0")]
		public bool IEOEAKHLKGI()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x31BA3A0", Offset = "0x31B93A0", VA = "0x1831BA3A0")]
	public static MIGHAIEFIFP<T> JBECHMJBHAL<T>(this NativeList<T> DNOAHHGKGFF) where T : struct
	{
		return default(MIGHAIEFIFP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9D5DF0", Offset = "0x9D4DF0", VA = "0x1809D5DF0")]
	public static MIGHAIEFIFP<T> JBECHMJBHAL<T>(this NativeArray<T> GGEMIJICFPG) where T : struct
	{
		return default(MIGHAIEFIFP<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class AJJNEGGLEGI
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct FIMBLKIPMHD<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly NativeArray<T>.ReadOnly GGEMIJICFPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int GEIGDPFELPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int HLBFIANHDJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private T HCFJOHGPONG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T IHFKNGIALPP;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public LEKMELECFFF LNDIDPOIMCL
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x3C470D0", Offset = "0x3C460D0", VA = "0x183C470D0")]
			get
			{
				return default(LEKMELECFFF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T OJCOMJAJFLH
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x38B4400", Offset = "0x38B3400", VA = "0x1838B4400")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, LEKMELECFFF) NKNICMABPJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x3C46B80", Offset = "0x3C45B80", VA = "0x183C46B80")]
			get
			{
				return default((T, LEKMELECFFF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3C47150", Offset = "0x3C46150", VA = "0x183C47150")]
		public FIMBLKIPMHD(NativeArray<T> GGEMIJICFPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3C46B40", Offset = "0x3C45B40", VA = "0x183C46B40")]
		public FIMBLKIPMHD<T> AKHPNFMFJMK()
		{
			return default(FIMBLKIPMHD<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3C46D00", Offset = "0x3C45D00", VA = "0x183C46D00")]
		public bool IEOEAKHLKGI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2A67A50", Offset = "0x2A66A50", VA = "0x182A67A50")]
		public NLFIOIJHIPE<T, TComparer> KGMPOEAENCN<TComparer>([Optional] TComparer CMJCLMMNLJJ) where TComparer : struct, IEqualityComparer<T>
		{
			return default(NLFIOIJHIPE<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct NLFIOIJHIPE<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly NativeArray<T>.ReadOnly GGEMIJICFPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int GEIGDPFELPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int HLBFIANHDJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T HCFJOHGPONG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private T IHFKNGIALPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TComparer CMJCLMMNLJJ;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LEKMELECFFF LNDIDPOIMCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x3C470D0", Offset = "0x3C460D0", VA = "0x183C470D0")]
			get
			{
				return default(LEKMELECFFF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T OJCOMJAJFLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x38B4400", Offset = "0x38B3400", VA = "0x1838B4400")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x4596120", Offset = "0x4595120", VA = "0x184596120")]
		public NLFIOIJHIPE(NativeArray<T>.ReadOnly GGEMIJICFPG, TComparer CMJCLMMNLJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4595F30", Offset = "0x4594F30", VA = "0x184595F30")]
		public bool IEOEAKHLKGI()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x31BCE00", Offset = "0x31BBE00", VA = "0x1831BCE00")]
	public static FIMBLKIPMHD<T> MMBNJBLDBML<T>(this NativeArray<T> GGEMIJICFPG) where T : struct
	{
		return default(FIMBLKIPMHD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface NPKDOELFFOF
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class GLBGAHKMAOP
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct BJGPKCDOFLF<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class PPEIAAMCCBL : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public BJGPKCDOFLF<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xC43BD0", Offset = "0xC42BD0", VA = "0x180C43BD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3BFEC80", Offset = "0x3BFDC80", VA = "0x183BFEC80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x86B3A0", Offset = "0x86A3A0", VA = "0x18086B3A0")]
		[DebuggerHidden]
		public PPEIAAMCCBL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x47BA220", Offset = "0x47B9220", VA = "0x1847BA220", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x47BA400", Offset = "0x47B9400", VA = "0x1847BA400", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly Action<Protobuf> ADLBKHNNPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly MemoryStream OBCPGDKFCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly CodedInputStream LKNMIEEKIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Protobuf IJGAKAKDEFC;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int DNIPBCBOHOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8DB860", Offset = "0x8DA860", VA = "0x1808DB860")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4E9CE10", Offset = "0x4E9BE10", VA = "0x184E9CE10", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4E9CE50", Offset = "0x4E9BE50", VA = "0x184E9CE50", Slot = "4")]
	[IteratorStateMachine(typeof(BJGPKCDOFLF<>.PPEIAAMCCBL))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4E9CF50", Offset = "0x4E9BF50", VA = "0x184E9CF50", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct BFCCPAOLCOC<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly byte[] EPBKIHMMALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Protobuf IJGAKAKDEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly MemoryStream OBCPGDKFCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly CodedOutputStream PINJIMBJNLH;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4E7D840", Offset = "0x4E7C840", VA = "0x184E7D840", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct PFCCGPKBHAO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MemoryStream OBCPGDKFCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CodedInputStream LKNMIEEKIJM;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A61C90", Offset = "0x6A60C90", VA = "0x186A61C90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct HFINDEEIFPC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly byte[] EPBKIHMMALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream OBCPGDKFCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedOutputStream PINJIMBJNLH;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A61440", Offset = "0x6A60440", VA = "0x186A61440", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class JPENAGHBHHG
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class OGBIBCFAICK
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Flags]
public enum AIFOKMBGCFA
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
internal static class KAFLCPANNJB
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class ECFAFCMGIDH
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public ECFAFCMGIDH()
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
