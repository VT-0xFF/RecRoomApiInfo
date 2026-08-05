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
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
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
		[Cpp2IlInjected.Address(RVA = "0x6CADA60", Offset = "0x6CAC460", VA = "0x186CADA60")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FMFOALMDEDJ : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IJPHLMMHLLL CGGDMDHFMLM
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
public interface BCNOLBFPADE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EFDNJCKHNAN(Entity HLKOPNMJGHO, object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LJELHMCIJNJ(Entity HLKOPNMJGHO, object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MOEJOIBGICD(Entity HLKOPNMJGHO);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class NAAGGEPFICM<TComponentData, TValue> : KDMBFACOBIN<TValue>, IDisposable where TComponentData : struct, FMFOALMDEDJ
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class ONIKOIBEBPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> JNHGBAGBHGA;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int FPAPEBLAAHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x36CB460", Offset = "0x36C9E60", VA = "0x1836CB460")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x484CF40", Offset = "0x484B940", VA = "0x18484CF40")]
		public bool KDADGCELFLH([Out] TValue CLMKDBDPNNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x484CD50", Offset = "0x484B750", VA = "0x18484CD50")]
		public void EGHPKMGPEOO(object KLGLJKMNAIM, TValue CLMKDBDPNNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x484D050", Offset = "0x484BA50", VA = "0x18484D050")]
		public bool MIOFMOMIMDC(object KLGLJKMNAIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x484CE40", Offset = "0x484B840", VA = "0x18484CE40")]
		public int FKEKIHAMDBP(object KLGLJKMNAIM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x484D110", Offset = "0x484BB10", VA = "0x18484D110")]
		public ONIKOIBEBPK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<ONIKOIBEBPK> JJAIOJPMCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private PMDDMLENNFO<IJPHLMMHLLL, ONIKOIBEBPK> EDLABKGBFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager PBPLCKDKLPP;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x468F810", Offset = "0x468E210", VA = "0x18468F810")]
	public NAAGGEPFICM(EntityManager PBPLCKDKLPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x468EF70", Offset = "0x468D970", VA = "0x18468EF70", Slot = "4")]
	public void EFDNJCKHNAN(Entity HLKOPNMJGHO, object KLGLJKMNAIM, TValue CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x468F440", Offset = "0x468DE40", VA = "0x18468F440", Slot = "5")]
	public bool LJELHMCIJNJ(Entity HLKOPNMJGHO, object KLGLJKMNAIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x468F320", Offset = "0x468DD20", VA = "0x18468F320", Slot = "6")]
	public bool KDADGCELFLH(Entity HLKOPNMJGHO, [Out] TValue CLMKDBDPNNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x468EF50", Offset = "0x468D950", VA = "0x18468EF50", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x468F250", Offset = "0x468DC50", VA = "0x18468F250")]
	private void IPCFNIDGCCD(ONIKOIBEBPK FDEHONHGPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x468F750", Offset = "0x468E150", VA = "0x18468F750")]
	private bool OJGKIHNPIBJ(Entity HLKOPNMJGHO, [Out] IJPHLMMHLLL OMKGKCDECFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x468F650", Offset = "0x468E050", VA = "0x18468F650")]
	private void NJKGEJIIPEM(Entity HLKOPNMJGHO, IJPHLMMHLLL OMKGKCDECFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x468F230", Offset = "0x468DC30", VA = "0x18468F230")]
	private bool IIKFGMEJNAF(IJPHLMMHLLL OMKGKCDECFC, [Out] ONIKOIBEBPK FDEHONHGPGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x468F100", Offset = "0x468DB00", VA = "0x18468F100")]
	private ONIKOIBEBPK IIAIKHAAPDD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface KDMBFACOBIN<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EFDNJCKHNAN(Entity HLKOPNMJGHO, object KLGLJKMNAIM, TValue CLMKDBDPNNH);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LJELHMCIJNJ(Entity HLKOPNMJGHO, object KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KDADGCELFLH(Entity HLKOPNMJGHO, [Out] TValue CLMKDBDPNNH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct IJPHLMMHLLL : LCMEFFHGKGH, IEquatable<IJPHLMMHLLL>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly IJPHLMMHLLL BONAFNCHILA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int MOMFAOPBBMD
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9696E0", Offset = "0x9680E0", VA = "0x1809696E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xB0FC60", Offset = "0xB0E660", VA = "0x180B0FC60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int EBJFPPIDGMF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2664280", Offset = "0x2662C80", VA = "0x182664280", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5F77A80", Offset = "0x5F76480", VA = "0x185F77A80", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6CADC80", Offset = "0x6CAC680", VA = "0x186CADC80", Slot = "8")]
	public bool Equals(IJPHLMMHLLL AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6CADCD0", Offset = "0x6CAC6D0", VA = "0x186CADCD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HCKGAKHAEFO<THasTokensTag> : BCNOLBFPADE, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly ANDGIEDMMDP AGICKJCJECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, IJPHLMMHLLL> JHFCCNNMLEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> JJAIOJPMCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private PMDDMLENNFO<IJPHLMMHLLL, HashSet<object>> EDLABKGBFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager PBPLCKDKLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem GCAFIHLAMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool JJAPMBJBFNG;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3EC9F50", Offset = "0x3EC8950", VA = "0x183EC9F50")]
	public HCKGAKHAEFO(EntityManager PBPLCKDKLPP, EntityCommandBufferSystem GCAFIHLAMKK, ANDGIEDMMDP KMKFBEOABJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3EC7C00", Offset = "0x3EC6600", VA = "0x183EC7C00", Slot = "4")]
	public bool EFDNJCKHNAN(Entity HLKOPNMJGHO, object KLGLJKMNAIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3EC9080", Offset = "0x3EC7A80", VA = "0x183EC9080", Slot = "5")]
	public bool LJELHMCIJNJ(Entity HLKOPNMJGHO, object KLGLJKMNAIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3EC9260", Offset = "0x3EC7C60", VA = "0x183EC9260", Slot = "6")]
	public bool MOEJOIBGICD(Entity HLKOPNMJGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3EC9490", Offset = "0x3EC7E90", VA = "0x183EC9490", Slot = "8")]
	public bool MOEJOIBGICD(IJPHLMMHLLL OMKGKCDECFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3EC75E0", Offset = "0x3EC5FE0", VA = "0x183EC75E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3EC8810", Offset = "0x3EC7210", VA = "0x183EC8810")]
	private void IPCFNIDGCCD(HashSet<object> FDEHONHGPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3EC9890", Offset = "0x3EC8290", VA = "0x183EC9890")]
	private bool OJGKIHNPIBJ(Entity HLKOPNMJGHO, [Out] IJPHLMMHLLL OMKGKCDECFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3EC82E0", Offset = "0x3EC6CE0", VA = "0x183EC82E0")]
	private bool HKJIHLLFPKJ(Entity HLKOPNMJGHO, [Out] IJPHLMMHLLL OMKGKCDECFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3EC7450", Offset = "0x3EC5E50", VA = "0x183EC7450")]
	private void DKCKDGGODGD(Entity HLKOPNMJGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3EC7DE0", Offset = "0x3EC67E0", VA = "0x183EC7DE0")]
	private void EJCHGCJDPLF(Entity HLKOPNMJGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3EC6EA0", Offset = "0x3EC58A0", VA = "0x183EC6EA0")]
	private void BLJIMOEOLNP(Entity HLKOPNMJGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3EC9680", Offset = "0x3EC8080", VA = "0x183EC9680")]
	private void NJKGEJIIPEM(Entity HLKOPNMJGHO, IJPHLMMHLLL OMKGKCDECFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3EC8A20", Offset = "0x3EC7420", VA = "0x183EC8A20")]
	private bool JBNDNEDAIKJ(IJPHLMMHLLL OMKGKCDECFC, [Out] HashSet<object> FDEHONHGPGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3EC8520", Offset = "0x3EC6F20", VA = "0x183EC8520")]
	private HashSet<object> IIAIKHAAPDD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class JCLFJPJAFBO
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct PIDDPKPANFF : LECNEDPIJJM<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6CAE410", Offset = "0x6CACE10", VA = "0x186CAE410")]
	public float DKLLPIHJAHM([In] float3 CLMKDBDPNNH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6CAE410", Offset = "0x6CACE10", VA = "0x186CAE410", Slot = "4")]
	private float KCPFFMPFPPM([In] float3 CLMKDBDPNNH)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct LMPMMHPBKLP : LECNEDPIJJM<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6CAE330", Offset = "0x6CACD30", VA = "0x186CAE330")]
	public float DKLLPIHJAHM([In] float3 CLMKDBDPNNH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6CAE330", Offset = "0x6CACD30", VA = "0x186CAE330", Slot = "4")]
	private float KCPFFMPFPPM([In] float3 CLMKDBDPNNH)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct APBOCHJDDBB : LECNEDPIJJM<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1F30CB0", Offset = "0x1F2F6B0", VA = "0x181F30CB0")]
	public float DKLLPIHJAHM([In] float3 CLMKDBDPNNH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1F30CB0", Offset = "0x1F2F6B0", VA = "0x181F30CB0", Slot = "4")]
	private float KCPFFMPFPPM([In] float3 CLMKDBDPNNH)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct IKHDOLOLPLK : LECNEDPIJJM<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x17E4DC0", Offset = "0x17E37C0", VA = "0x1817E4DC0")]
	public int DKLLPIHJAHM([In] int3 CLMKDBDPNNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x17E4DC0", Offset = "0x17E37C0", VA = "0x1817E4DC0", Slot = "4")]
	private int OJKNMAHEPNF([In] int3 CLMKDBDPNNH)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct OCABAGPHNML : LECNEDPIJJM<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6CAE400", Offset = "0x6CACE00", VA = "0x186CAE400")]
	public int DKLLPIHJAHM([In] int3 CLMKDBDPNNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6CAE400", Offset = "0x6CACE00", VA = "0x186CAE400", Slot = "4")]
	private int OJKNMAHEPNF([In] int3 CLMKDBDPNNH)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct BBEILNPPKDN : LECNEDPIJJM<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1987E40", Offset = "0x1986840", VA = "0x181987E40")]
	public int DKLLPIHJAHM([In] int3 CLMKDBDPNNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1987E40", Offset = "0x1986840", VA = "0x181987E40", Slot = "4")]
	private int OJKNMAHEPNF([In] int3 CLMKDBDPNNH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class KDBOHBLIBFF : NDHJEEIONBB
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x16FBD20", Offset = "0x16FA720", VA = "0x1816FBD20")]
	public KDBOHBLIBFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class BIKMEAGGACD : SystemBase, DFBIACAGILF
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD7B0", Offset = "0x6CAC1B0", VA = "0x186CAD7B0")]
	public JobHandle FBFNPOMNMMJ(ReadOnlySpan<int> NEDKLHPCFDC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2A263D0", Offset = "0x2A24DD0", VA = "0x182A263D0")]
	public void BAGLDOMLIHM<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2A26130", Offset = "0x2A24B30", VA = "0x182A26130")]
	public JobHandle BAGLDOMLIHM<T>(JobHandle OMKGKCDECFC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD680", Offset = "0x6CAC080", VA = "0x186CAD680")]
	public JobHandle BAGLDOMLIHM(ReadOnlySpan<int> NEDKLHPCFDC, JobHandle OMKGKCDECFC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2A263D0", Offset = "0x2A24DD0", VA = "0x182A263D0")]
	public void HKCPMDKDKCB<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2A270A0", Offset = "0x2A25AA0", VA = "0x182A270A0")]
	public JobHandle HKCPMDKDKCB<T>(JobHandle OMKGKCDECFC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD6F0", Offset = "0x6CAC0F0", VA = "0x186CAD6F0")]
	public ComponentDataFromEntity DFJALBAAGDC(int NNGGOAJPOAO, bool POLJDPHJFMD = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD800", Offset = "0x6CAC200", VA = "0x186CAD800")]
	public EntityExistenceLookupByEntity LIEJNPFEBBE()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD820", Offset = "0x6CAC220", VA = "0x186CAD820", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x16FBD20", Offset = "0x16FA720", VA = "0x1816FBD20")]
	protected BIKMEAGGACD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class NJCEBGCPHCC : BIKMEAGGACD
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6CAE3D0", Offset = "0x6CACDD0", VA = "0x186CAE3D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x16FBD20", Offset = "0x16FA720", VA = "0x1816FBD20")]
	protected NJCEBGCPHCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class CIDPMJBLDDB
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class OCAAABGHDAM : EntityCommandBufferSystem, DFBIACAGILF
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x16FBD20", Offset = "0x16FA720", VA = "0x1816FBD20")]
	protected OCAAABGHDAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LECNEDPIJJM<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo DKLLPIHJAHM([In] TFrom CLMKDBDPNNH);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface CDDIBFFOCEA<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BMABGLGEFGI(T CLMKDBDPNNH);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BurstCompile]
internal struct LECEMMIMCBP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[ReadOnly]
	public NativeArray<Entity> KJEILEEIDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public EntityCommandBuffer AEPOMCBNLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public ComponentTypes NKJMJPNBAPM;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6CAE240", Offset = "0x6CACC40", VA = "0x186CAE240", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct EOKFKKOKBBJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> KJEILEEIDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer AEPOMCBNLPK;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD9C0", Offset = "0x6CAC3C0", VA = "0x186CAD9C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct KBJCKDABHMI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public NativeArray<Entity> KJEILEEIDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public EntityCommandBuffer AEPOMCBNLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public ComponentType MLAEDPCFJGE;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6CADFE0", Offset = "0x6CAC9E0", VA = "0x186CADFE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct BONINKBMEBK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> KJEILEEIDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public NativeArray<T> OIGMDCDEKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public EntityCommandBuffer AEPOMCBNLPK;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5072290", Offset = "0x5070C90", VA = "0x185072290", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal struct JBCNDGIFGDM<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> KJEILEEIDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> ACOKCANBLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer AEPOMCBNLPK;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct LBHHBDMHJAF<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> KJEILEEIDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public T CLMKDBDPNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer AEPOMCBNLPK;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x441B750", Offset = "0x441A150", VA = "0x18441B750", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BurstCompile]
internal struct PLIONDOPBPP<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, LECNEDPIJJM<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<TFrom> NAPFGBDCIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[WriteOnly]
	public NativeArray<TTo> DDAAFOOIHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public TMap ENNGIICFMFD;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct DKOANEKFBFP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public ComponentDataFromEntity MOFGFKENEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> NAPFGBDCIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[WriteOnly]
	public NativeArray<byte> DDAAFOOIHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int DLMHKCBHGME;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD830", Offset = "0x6CAC230", VA = "0x186CAD830", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct PODEKEHAOBA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public ComponentDataFromEntity<T> BKIPJAFBHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public NativeArray<Entity> NAPFGBDCIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[WriteOnly]
	public NativeList<T> NCBGMMNIDHG;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct HOKCFEDLIHA<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, LECNEDPIJJM<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> ADABKDODFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeList<TTo> DDAAFOOIHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap ENNGIICFMFD;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct LLMPGFEPLGH<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity<T> MFGEMAGCLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> DKBLNGKPNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<bool> EDICEBKJAAB;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct MFKGHMIHGOO<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> MFGEMAGCLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> DKBLNGKPNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> EDICEBKJAAB;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x46136B0", Offset = "0x46120B0", VA = "0x1846136B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct BKNIKJPPIPH<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<T> NAPFGBDCIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeList<T> NCBGMMNIDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeParallelHashSet<T> IANJADGEJJA;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5063B20", Offset = "0x5062520", VA = "0x185063B20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct MEFOLMIMEMH<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : LECNEDPIJJM<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<TFrom> NAPFGBDCIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<TFrom> NCBGMMNIDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<TTo> IANJADGEJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public TMap ENNGIICFMFD;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct FHFBNBDKOCB<T, TPredicate> : IJob where T : struct where TPredicate : struct, CDDIBFFOCEA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public NativeArray<T> NAPFGBDCIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> NMCOMJJALMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeList<Entity> OMKCLMCAGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public TPredicate ENNGIICFMFD;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct PHKLLNMFDPL<T, TPredicate> : IJob where T : struct where TPredicate : struct, CDDIBFFOCEA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<T> NAPFGBDCIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<T> NCBGMMNIDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate ENNGIICFMFD;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct NIGGNGJELFP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public ComponentDataFromEntity MFGEMAGCLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	public NativeArray<Entity> DKBLNGKPNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeList<Entity> JHAPBGFIFOC;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6CAE340", Offset = "0x6CACD40", VA = "0x186CAE340", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct EECABDBJPNI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity MFGEMAGCLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> DKBLNGKPNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> JHAPBGFIFOC;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD930", Offset = "0x6CAC330", VA = "0x186CAD930", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class BKFANILPCOM
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class LPKLKODINJG
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2D4E580", Offset = "0x2D4CF80", VA = "0x182D4E580")]
	public static bool IIEGLGKPKBH<T>(this NativeArray<Entity> DKBLNGKPNAF, EntityManager PBPLCKDKLPP, Allocator MDICAPEDFAK = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class FJJNPNDIKOJ
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class MFCKEIDKKAN<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		public MFCKEIDKKAN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class PPLEKAEECMP<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		public PPLEKAEECMP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly List<Func<JobHandle, JobHandle>> LPEELOIOIAD;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6CADA80", Offset = "0x6CAC480", VA = "0x186CADA80")]
	public FJJNPNDIKOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class EBFBDIGONCG
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class DHOAFAGCAFO
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct KGDNLIPDAOL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct MCNAJIHCKNC<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			internal KGDNLIPDAOL<TFrom> DLPGBMPJIIG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal Allocator MDICAPEDFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal NativeArray<TFrom> CDNMICCKGIM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct LBPHDELDKNL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct EHMNMCJAAFJ<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal LBPHDELDKNL<TFrom> DLPGBMPJIIG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator MDICAPEDFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeList<TFrom> CDNMICCKGIM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct EODCLIEANKM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct LHEKGADLHDD<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal EODCLIEANKM<TFrom> DLPGBMPJIIG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator MDICAPEDFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeArrayAsync<TFrom> CDNMICCKGIM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct EJCLOPMFKMG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct OEFMHDMDPKF<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal EJCLOPMFKMG<TFrom> DLPGBMPJIIG;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator MDICAPEDFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeListAsync<TFrom> CDNMICCKGIM;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class BNKHJFGJAHH
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class FODDPOFCOCL
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2C77030", Offset = "0x2C75A30", VA = "0x182C77030")]
	public static NativeList<T> AODAENIKIOK<T>(this NativeArray<T> BOKMODFGJLK, Allocator MDICAPEDFAK = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class GLIJECELCFO
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class JBAKFIAIFBE
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2CF6FE0", Offset = "0x2CF59E0", VA = "0x182CF6FE0")]
	[JKICCOBAPEC]
	public static JobHandle JOCKGAHENEF<T>(this EntityCommandBufferSystem GCAFIHLAMKK, NativeArrayAsync<Entity> KJEILEEIDEP, NativeArrayAsync<T> OIGMDCDEKEG, [Optional] JobHandle FELHCJGCNAA) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7160", Offset = "0x2CF5B60", VA = "0x182CF7160")]
	[JKICCOBAPEC]
	public static JobHandle JOCKGAHENEF<T>(this EntityCommandBufferSystem GCAFIHLAMKK, NativeArrayAsync<Entity> KJEILEEIDEP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2CF6EB0", Offset = "0x2CF58B0", VA = "0x182CF6EB0")]
	[JKICCOBAPEC]
	public static JobHandle JOCKGAHENEF<T>(this EntityCommandBufferSystem GCAFIHLAMKK, NativeArray<Entity> KJEILEEIDEP, [Optional] JobHandle FELHCJGCNAA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6CADD20", Offset = "0x6CAC720", VA = "0x186CADD20")]
	[JKICCOBAPEC]
	public static JobHandle JOCKGAHENEF(this EntityCommandBufferSystem GCAFIHLAMKK, NativeArray<Entity> KJEILEEIDEP, ComponentTypes NKJMJPNBAPM, [Optional] JobHandle FELHCJGCNAA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6CADE90", Offset = "0x6CAC890", VA = "0x186CADE90")]
	[JKICCOBAPEC]
	public static JobHandle JOCKGAHENEF(this EntityCommandBufferSystem GCAFIHLAMKK, EntityCommandBuffer AEPOMCBNLPK, NativeArray<Entity> KJEILEEIDEP, ComponentTypes NKJMJPNBAPM, [Optional] JobHandle FELHCJGCNAA)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class AJBKMHMDOPB
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x336A360", Offset = "0x3368D60", VA = "0x18336A360")]
	[JKICCOBAPEC]
	public static JobHandle LMFILAKKDHD<T>(this EntityCommandBufferSystem GCAFIHLAMKK, EntityCommandBuffer AEPOMCBNLPK, EntityQuery GKMPBNKNBNF, T CLMKDBDPNNH) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class BCOLHNNKCGP
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD3F0", Offset = "0x6CABDF0", VA = "0x186CAD3F0")]
	[JKICCOBAPEC]
	public static JobHandle LIMEJDOMHOL(this EntityCommandBufferSystem GCAFIHLAMKK, NativeList<Entity> KJEILEEIDEP, [Optional] JobHandle FELHCJGCNAA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD580", Offset = "0x6CABF80", VA = "0x186CAD580")]
	[JKICCOBAPEC]
	public static JobHandle LIMEJDOMHOL(this EntityCommandBufferSystem GCAFIHLAMKK, NativeArrayAsync<Entity> KJEILEEIDEP)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class KOOMEDAMALF
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class FJOEOKGBPAE
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2C6CF70", Offset = "0x2C6B970", VA = "0x182C6CF70")]
	[JKICCOBAPEC]
	public static JobHandle KDOGICJCCFE<T>(this EntityCommandBufferSystem GCAFIHLAMKK, NativeArray<Entity> KJEILEEIDEP, NativeArray<T> OIGMDCDEKEG, JobHandle FELHCJGCNAA) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class PIPJPDALBGD
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2E4C430", Offset = "0x2E4AE30", VA = "0x182E4C430")]
	[JKICCOBAPEC]
	public static JobHandle PEGOLLNLOBB<T>(this EntityCommandBufferSystem GCAFIHLAMKK, NativeArray<Entity> KJEILEEIDEP, T CLMKDBDPNNH, [Optional] JobHandle FELHCJGCNAA) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2E4C520", Offset = "0x2E4AF20", VA = "0x182E4C520")]
	[JKICCOBAPEC]
	public static JobHandle PEGOLLNLOBB<T>(this EntityCommandBufferSystem GCAFIHLAMKK, EntityCommandBuffer AEPOMCBNLPK, NativeArray<Entity> KJEILEEIDEP, T CLMKDBDPNNH, [Optional] JobHandle FELHCJGCNAA) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class CMJGNCPAJPF
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class KIBINJLPPBK
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2D27930", Offset = "0x2D26330", VA = "0x182D27930")]
	public static NativeArray<T> JGJFHGBAMFO<T>(this NativeList<Entity> BOKMODFGJLK, EntityManager PBPLCKDKLPP, Allocator MDICAPEDFAK = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2D27390", Offset = "0x2D25D90", VA = "0x182D27390")]
	public static NativeArray<T> JGJFHGBAMFO<T>(this NativeArray<Entity> BOKMODFGJLK, EntityManager PBPLCKDKLPP, Allocator MDICAPEDFAK = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6CAE060", Offset = "0x6CACA60", VA = "0x186CAE060")]
	public static NativeArray<Entity> KKEFPOPNALL(this NativeArray<Entity> BOKMODFGJLK, EntityManager PBPLCKDKLPP, ComponentType MLAEDPCFJGE, Allocator MDICAPEDFAK = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2D272B0", Offset = "0x2D25CB0", VA = "0x182D272B0")]
	public static NativeArray<T> BOHBOEILCDC<T>(this NativeArray<Entity> BOKMODFGJLK, EntityManager PBPLCKDKLPP, Allocator MDICAPEDFAK = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class CKFIPJAHIBD
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct FIFECFKDGAI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct EDMNKIJPIHN<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public FIFECFKDGAI<TFrom> CDNMICCKGIM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Allocator MDICAPEDFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public NativeArray<TFrom> NAPFGBDCIEA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct CBDMDLDHHCK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct PJKHGNCFFFP<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public CBDMDLDHHCK<TFrom> CDNMICCKGIM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator MDICAPEDFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArrayAsync<TFrom> NAPFGBDCIEA;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct KACGFJMNFBA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct LONGICGPFEG<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public KACGFJMNFBA<TFrom> CDNMICCKGIM;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator MDICAPEDFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeListAsync<TFrom> NAPFGBDCIEA;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class HFBOBEEFGKL
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class ECIFDJJIKPH
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct HLOPNIJKFIH : LECNEDPIJJM<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> EGBBOCCPNEC;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6CADC70", Offset = "0x6CAC670", VA = "0x186CADC70")]
		[BurstCompatible]
		public Entity DKLLPIHJAHM([In] Entity CLMKDBDPNNH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6CADC70", Offset = "0x6CAC670", VA = "0x186CADC70", Slot = "4")]
		private Entity ENNHEENLPLF([In] Entity CLMKDBDPNNH)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class ENHMKCOCMCG
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct BMGJGPCABIB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator MDICAPEDFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<Entity> NMCOMJJALMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<T> NAPFGBDCIEA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct KEGODPBDBNC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator MDICAPEDFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeList<Entity> NMCOMJJALMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> NAPFGBDCIEA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct GLCPENICJEC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator MDICAPEDFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArrayAsync<Entity> NMCOMJJALMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArrayAsync<T> NAPFGBDCIEA;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class POJMPNIACFG
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class OBOEPENGGGE
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct LCLCKDLIFOP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator MDICAPEDFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> NAPFGBDCIEA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct CKMPLBNBHIH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator MDICAPEDFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> NAPFGBDCIEA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct CKPDKKMABKB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator MDICAPEDFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeArrayAsync<T> NAPFGBDCIEA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct CNIELKCDMEC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator MDICAPEDFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NativeListAsync<T> NAPFGBDCIEA;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class FAEMNIOPKPD
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class LGMEHFILJPH
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2D3D7B0", Offset = "0x2D3C1B0", VA = "0x182D3D7B0")]
	public static NativeList<Entity> MPPDLGAHKEB<T>(this NativeArray<Entity> DKBLNGKPNAF, EntityManager PBPLCKDKLPP, Allocator MDICAPEDFAK = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class DLIPAGMINOC
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class INFGKOHHMNM
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public readonly struct ELIELEFKEMO<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NativeArray<TSrc> FNCIFDCGDBA;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xB7B800", Offset = "0xB7A200", VA = "0x180B7B800")]
		public ELIELEFKEMO(NativeArray<TSrc> FNCIFDCGDBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xB7B7F0", Offset = "0xB7A1F0", VA = "0x180B7B7F0")]
		public EHLFEAPIFHO<TSrc, TValue> ICHFCCECAKM<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(EHLFEAPIFHO<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct EHLFEAPIFHO<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> FNCIFDCGDBA;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xB7B800", Offset = "0xB7A200", VA = "0x180B7B800")]
		public EHLFEAPIFHO(NativeArray<TSrc> FNCIFDCGDBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xB7B7F0", Offset = "0xB7A1F0", VA = "0x180B7B7F0")]
		public HAEEGBKHBDO<TSrc, TValue, TSelector> KGLDGLFOPCL<TSelector>() where TSelector : struct, LECNEDPIJJM<TSrc, TValue>
		{
			return default(HAEEGBKHBDO<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct HAEEGBKHBDO<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, LECNEDPIJJM<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> FNCIFDCGDBA;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xB7B800", Offset = "0xB7A200", VA = "0x180B7B800")]
		public HAEEGBKHBDO(NativeArray<TSrc> FNCIFDCGDBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3EA17E0", Offset = "0x3EA01E0", VA = "0x183EA17E0")]
		public OCONCPCOGNI<TSrc, TValue, TSelector> KIPCDNBDJAP()
		{
			return default(OCONCPCOGNI<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct PLKPKEOEMFG<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, LECNEDPIJJM<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> FNCIFDCGDBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TSelector OBHHBKOEDBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int EBDDHAPIAHH;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TValue JOCMDMELDEE
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x4937C00", Offset = "0x4936600", VA = "0x184937C00")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int MOMFAOPBBMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8FD280", Offset = "0x8FBC80", VA = "0x1808FD280")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int PKLCBMGOIIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x20DE2D0", Offset = "0x20DCCD0", VA = "0x1820DE2D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4937C50", Offset = "0x4936650", VA = "0x184937C50")]
		public PLKPKEOEMFG(NativeArray<TSrc> FNCIFDCGDBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4937C40", Offset = "0x4936640", VA = "0x184937C40")]
		public bool NFOMNEMJJDC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x4937A70", Offset = "0x4936470", VA = "0x184937A70")]
		private TSrc BKBIOINDBIL(int PPNCECJAFNC)
		{
			return (TSrc)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4937B70", Offset = "0x4936570", VA = "0x184937B70")]
		private TValue KFOGNDJJCJE()
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct OCONCPCOGNI<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, LECNEDPIJJM<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private PLKPKEOEMFG<TSrc, TValue, TSelector> ANMEDFHNEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TValue FMDGOLKCEAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int GLCOHEPGOCK;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public FHFJABPJBIK BMOJDIPPLPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x4820040", Offset = "0x481EA40", VA = "0x184820040")]
			get
			{
				return default(FHFJABPJBIK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue MHHIAKALKOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x889410", Offset = "0x887E10", VA = "0x180889410")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, FHFJABPJBIK range) JOCMDMELDEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x4820080", Offset = "0x481EA80", VA = "0x184820080")]
			get
			{
				return default((TValue, FHFJABPJBIK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x48202E0", Offset = "0x481ECE0", VA = "0x1848202E0")]
		public OCONCPCOGNI(NativeArray<TSrc> FNCIFDCGDBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3ED3790", Offset = "0x3ED2190", VA = "0x183ED3790")]
		public OCONCPCOGNI<TSrc, TValue, TSelector> BPGPEIEKEPK()
		{
			return default(OCONCPCOGNI<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4820160", Offset = "0x481EB60", VA = "0x184820160")]
		public bool NFOMNEMJJDC()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2CE5290", Offset = "0x2CE3C90", VA = "0x182CE5290")]
	public static ELIELEFKEMO<T> ONBGMLCJAGF<T>(this NativeList<T> JNHGBAGBHGA) where T : struct
	{
		return default(ELIELEFKEMO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xB7B7F0", Offset = "0xB7A1F0", VA = "0x180B7B7F0")]
	public static ELIELEFKEMO<T> ONBGMLCJAGF<T>(this NativeArray<T> FNCIFDCGDBA) where T : struct
	{
		return default(ELIELEFKEMO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class GNJJHDHLMLM
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct HFHCPDMIMCP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly NativeArray<T>.ReadOnly FNCIFDCGDBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int GLCOHEPGOCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int NMJDIMINFCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T FMDGOLKCEAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private T NABPGHNMOIE;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public FHFJABPJBIK BMOJDIPPLPA
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x3ED37B0", Offset = "0x3ED21B0", VA = "0x183ED37B0")]
			get
			{
				return default(FHFJABPJBIK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T MHHIAKALKOO
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x3A08860", Offset = "0x3A07260", VA = "0x183A08860")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, FHFJABPJBIK) JOCMDMELDEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x3ED37C0", Offset = "0x3ED21C0", VA = "0x183ED37C0")]
			get
			{
				return default((T, FHFJABPJBIK));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3ED3D80", Offset = "0x3ED2780", VA = "0x183ED3D80")]
		public HFHCPDMIMCP(NativeArray<T> FNCIFDCGDBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3ED3750", Offset = "0x3ED2150", VA = "0x183ED3750")]
		public HFHCPDMIMCP<T> BPGPEIEKEPK()
		{
			return default(HFHCPDMIMCP<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3ED3940", Offset = "0x3ED2340", VA = "0x183ED3940")]
		public bool NFOMNEMJJDC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE990", Offset = "0x2BCD390", VA = "0x182BCE990")]
		public LMKEGAGKLKL<T, TComparer> DCOJOGNBPJK<TComparer>([Optional] TComparer AFDGILOHDOK) where TComparer : struct, IEqualityComparer<T>
		{
			return default(LMKEGAGKLKL<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct LMKEGAGKLKL<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly NativeArray<T>.ReadOnly FNCIFDCGDBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int GLCOHEPGOCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int NMJDIMINFCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private T FMDGOLKCEAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private T NABPGHNMOIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TComparer AFDGILOHDOK;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public FHFJABPJBIK BMOJDIPPLPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x3ED37B0", Offset = "0x3ED21B0", VA = "0x183ED37B0")]
			get
			{
				return default(FHFJABPJBIK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T MHHIAKALKOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x3A08860", Offset = "0x3A07260", VA = "0x183A08860")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x443E330", Offset = "0x443CD30", VA = "0x18443E330")]
		public LMKEGAGKLKL(NativeArray<T>.ReadOnly FNCIFDCGDBA, TComparer AFDGILOHDOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x443E140", Offset = "0x443CB40", VA = "0x18443E140")]
		public bool NFOMNEMJJDC()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2C88EB0", Offset = "0x2C878B0", VA = "0x182C88EB0")]
	public static HFHCPDMIMCP<T> KIPCDNBDJAP<T>(this NativeArray<T> FNCIFDCGDBA) where T : struct
	{
		return default(HFHCPDMIMCP<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface KOCHBFLDGON
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class HPMCGKHFLKO
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct AMBKECIFNAH<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class KONGLJHLBKH : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AMBKECIFNAH<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xDCD700", Offset = "0xDCC100", VA = "0x180DCD700", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D270B0", Offset = "0x3D25AB0", VA = "0x183D270B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
		[DebuggerHidden]
		public KONGLJHLBKH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x439AD60", Offset = "0x4399760", VA = "0x18439AD60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x439AF40", Offset = "0x4399940", VA = "0x18439AF40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly Action<Protobuf> OINOLAKKKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly MemoryStream KLEBCAELJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly CodedInputStream HJKECMKAJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Protobuf POMBPEDHPHB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int PKLCBMGOIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8F2EF0", Offset = "0x8F18F0", VA = "0x1808F2EF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3DECE30", Offset = "0x3DEB830", VA = "0x183DECE30", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3DECE70", Offset = "0x3DEB870", VA = "0x183DECE70", Slot = "4")]
	[IteratorStateMachine(typeof(AMBKECIFNAH<>.KONGLJHLBKH))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3DECF70", Offset = "0x3DEB970", VA = "0x183DECF70", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct CBEEEPCHDFB<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly byte[] NONPGPMAOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Protobuf POMBPEDHPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream KLEBCAELJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedOutputStream MAHACGKGBIC;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x51101A0", Offset = "0x510EBA0", VA = "0x1851101A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct HIGPDOKOHDI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly MemoryStream KLEBCAELJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly CodedInputStream HJKECMKAJNM;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6CADB10", Offset = "0x6CAC510", VA = "0x186CADB10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct HJPAFKHJICB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly byte[] NONPGPMAOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly MemoryStream KLEBCAELJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CodedOutputStream MAHACGKGBIC;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6CADB50", Offset = "0x6CAC550", VA = "0x186CADB50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class MBCODGKEFNB
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class KKGJADNOGIF
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Flags]
public enum PDBDBIJEKGC
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
internal static class BJENPOJJHPD
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class HFMJLCPPHLB
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public HFMJLCPPHLB()
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
