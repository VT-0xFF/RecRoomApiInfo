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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8475510", Offset = "0x8474910", VA = "0x188475510")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA99B00", Offset = "0xA98F00", VA = "0x180A99B00")]
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
		[Cpp2IlInjected.Address(RVA = "0xA99B40", Offset = "0xA98F40", VA = "0x180A99B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8474BE0", Offset = "0x8473FE0", VA = "0x188474BE0")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HHFHACAEKFF : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	PBABGNFFMGK LAJHMEKKOND
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
public interface MEEEFCMJBBM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LLOLOBMLHBN(Entity MEOOAHKPJCE, object MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CBFOAFJIPLJ(Entity MEOOAHKPJCE, object MONGIMOHLAO, [Out] bool FIPDNAEPNIP);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JEJIMLOFMIK(Entity MEOOAHKPJCE);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class HMCFFCAJBIG<TComponentData, TValue> : CNIKOJBAKIL<TValue>, IDisposable where TComponentData : struct, HHFHACAEKFF
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class IJJDIINNIFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<(object token, TValue value)> KIGLENMLJCP;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int JGJMKJIDNDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x44DC760", Offset = "0x44DBB60", VA = "0x1844DC760")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x50E99D0", Offset = "0x50E8DD0", VA = "0x1850E99D0")]
		public bool IDJNECKKMLA([Out] TValue CBMEHPPMEEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x50E9AA0", Offset = "0x50E8EA0", VA = "0x1850E9AA0")]
		public void KOBMLIBBKBO(object MONGIMOHLAO, TValue CBMEHPPMEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x50E9950", Offset = "0x50E8D50", VA = "0x1850E9950")]
		public bool CBDHBFLGDII(object MONGIMOHLAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x50E9B50", Offset = "0x50E8F50", VA = "0x1850E9B50")]
		public int PENPPLDLEPP(object MONGIMOHLAO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x50E9C30", Offset = "0x50E9030", VA = "0x1850E9C30")]
		public IJJDIINNIFH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly Stack<IJJDIINNIFH> NDMAAPGNIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private PLHBMHAOBPJ<PBABGNFFMGK, IJJDIINNIFH> CIJLAKBHPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private EntityManager JGFECLAMEOK;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4FE1FD0", Offset = "0x4FE13D0", VA = "0x184FE1FD0")]
	public HMCFFCAJBIG(EntityManager JGFECLAMEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4FE1D10", Offset = "0x4FE1110", VA = "0x184FE1D10", Slot = "4")]
	public void LLOLOBMLHBN(Entity MEOOAHKPJCE, object MONGIMOHLAO, TValue CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4FE19D0", Offset = "0x4FE0DD0", VA = "0x184FE19D0", Slot = "5")]
	public bool CBFOAFJIPLJ(Entity MEOOAHKPJCE, object MONGIMOHLAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4FE1C30", Offset = "0x4FE1030", VA = "0x184FE1C30", Slot = "6")]
	public bool IDJNECKKMLA(Entity MEOOAHKPJCE, [Out] TValue CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4FE1B60", Offset = "0x4FE0F60", VA = "0x184FE1B60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4FE1BA0", Offset = "0x4FE0FA0", VA = "0x184FE1BA0")]
	private void FAPHBKHBJNA(IJJDIINNIFH MMMMAKHPAIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4FE1F10", Offset = "0x4FE1310", VA = "0x184FE1F10")]
	private bool PHCOHCHFDBA(Entity MEOOAHKPJCE, [Out] PBABGNFFMGK FELIADFOOJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4FE1E30", Offset = "0x4FE1230", VA = "0x184FE1E30")]
	private void MCFFKAABCBI(Entity MEOOAHKPJCE, PBABGNFFMGK FELIADFOOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4FE1B80", Offset = "0x4FE0F80", VA = "0x184FE1B80")]
	private bool EKHNCOIHKMN(PBABGNFFMGK FELIADFOOJH, [Out] IJJDIINNIFH MMMMAKHPAIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4FE18F0", Offset = "0x4FE0CF0", VA = "0x184FE18F0")]
	private IJJDIINNIFH AFHIBGCLJOP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CNIKOJBAKIL<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LLOLOBMLHBN(Entity MEOOAHKPJCE, object MONGIMOHLAO, TValue CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CBFOAFJIPLJ(Entity MEOOAHKPJCE, object MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IDJNECKKMLA(Entity MEOOAHKPJCE, [Out] TValue CBMEHPPMEEA);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct PBABGNFFMGK : GFPDGFGKLAD, IEquatable<PBABGNFFMGK>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly PBABGNFFMGK FEIBEMCCPGP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int JHGBNCFKBAP
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xD71620", Offset = "0xD70A20", VA = "0x180D71620", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1530B00", Offset = "0x152FF00", VA = "0x181530B00", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int CAAKCKNELLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2FBBBB0", Offset = "0x2FBAFB0", VA = "0x182FBBBB0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2FBBBA0", Offset = "0x2FBAFA0", VA = "0x182FBBBA0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8475850", Offset = "0x8474C50", VA = "0x188475850", Slot = "8")]
	public bool Equals(PBABGNFFMGK LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x84758A0", Offset = "0x8474CA0", VA = "0x1884758A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class DHGBKJBBPIO<THasTokensTag> : MEEEFCMJBBM, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private Dictionary<Entity, PBABGNFFMGK> PDGPAHCHIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Stack<HashSet<object>> NDMAAPGNIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private PLHBMHAOBPJ<PBABGNFFMGK, HashSet<object>> CIJLAKBHPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EntityManager JGFECLAMEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EntityCommandBufferSystem LHJOGJKGIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool GJNOCMLAONB;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4555D60", Offset = "0x4555160", VA = "0x184555D60")]
	public DHGBKJBBPIO(EntityManager JGFECLAMEOK, EntityCommandBufferSystem LHJOGJKGIBM, AKNCNLDICPO FHCPJGNECHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4554980", Offset = "0x4553D80", VA = "0x184554980", Slot = "4")]
	public bool LLOLOBMLHBN(Entity MEOOAHKPJCE, object MONGIMOHLAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4553410", Offset = "0x4552810", VA = "0x184553410", Slot = "5")]
	public bool CBFOAFJIPLJ(Entity MEOOAHKPJCE, object MONGIMOHLAO, [Out] bool FIPDNAEPNIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4553FB0", Offset = "0x45533B0", VA = "0x184553FB0", Slot = "6")]
	public bool JEJIMLOFMIK(Entity MEOOAHKPJCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4554190", Offset = "0x4553590", VA = "0x184554190", Slot = "8")]
	public bool JEJIMLOFMIK(PBABGNFFMGK FELIADFOOJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4553970", Offset = "0x4552D70", VA = "0x184553970", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4553A60", Offset = "0x4552E60", VA = "0x184553A60")]
	private void FAPHBKHBJNA(HashSet<object> MMMMAKHPAIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4555570", Offset = "0x4554970", VA = "0x184555570")]
	private bool PHCOHCHFDBA(Entity MEOOAHKPJCE, [Out] PBABGNFFMGK FELIADFOOJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x45542F0", Offset = "0x45536F0", VA = "0x1845542F0")]
	private bool KLFDEGIIFIJ(Entity MEOOAHKPJCE, [Out] PBABGNFFMGK FELIADFOOJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4555370", Offset = "0x4554770", VA = "0x184555370")]
	private void OEOOAEGKOHD(Entity MEOOAHKPJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4553EB0", Offset = "0x45532B0", VA = "0x184553EB0")]
	private void HGPEMFIBBBH(Entity MEOOAHKPJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4554670", Offset = "0x4553A70", VA = "0x184554670")]
	private void LHODJGMMJAD(Entity MEOOAHKPJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4554E30", Offset = "0x4554230", VA = "0x184554E30")]
	private void MCFFKAABCBI(Entity MEOOAHKPJCE, PBABGNFFMGK FELIADFOOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x45550B0", Offset = "0x45544B0", VA = "0x1845550B0")]
	private bool MLGPBAKJOJK(PBABGNFFMGK FELIADFOOJH, [Out] HashSet<object> MMMMAKHPAIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x45531D0", Offset = "0x45525D0", VA = "0x1845531D0")]
	private HashSet<object> AFHIBGCLJOP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class NAPOHAJJDJF
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct GPHBDABDALE : EBFFCDOMAAO<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8474DE0", Offset = "0x84741E0", VA = "0x188474DE0")]
	public float ABGFPJEFANO([In] float3 CBMEHPPMEEA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8474DE0", Offset = "0x84741E0", VA = "0x188474DE0", Slot = "4")]
	private float KPNFMOANCMF([In] float3 CBMEHPPMEEA)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct JBEMOKBIGGF : EBFFCDOMAAO<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x84750F0", Offset = "0x84744F0", VA = "0x1884750F0")]
	public float ABGFPJEFANO([In] float3 CBMEHPPMEEA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x84750F0", Offset = "0x84744F0", VA = "0x1884750F0", Slot = "4")]
	private float KPNFMOANCMF([In] float3 CBMEHPPMEEA)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct JNAFOCKEBFB : EBFFCDOMAAO<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0xFC6E00", Offset = "0xFC6200", VA = "0x180FC6E00")]
	public float ABGFPJEFANO([In] float3 CBMEHPPMEEA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xFC6E00", Offset = "0xFC6200", VA = "0x180FC6E00", Slot = "4")]
	private float KPNFMOANCMF([In] float3 CBMEHPPMEEA)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct OOLEDKLOPNO : EBFFCDOMAAO<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x142C4C0", Offset = "0x142B8C0", VA = "0x18142C4C0")]
	public int ABGFPJEFANO([In] int3 CBMEHPPMEEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x142C4C0", Offset = "0x142B8C0", VA = "0x18142C4C0", Slot = "4")]
	private int IPGFPGLDHBG([In] int3 CBMEHPPMEEA)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct OLLDOAINBKC : EBFFCDOMAAO<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x13A7150", Offset = "0x13A6550", VA = "0x1813A7150")]
	public int ABGFPJEFANO([In] int3 CBMEHPPMEEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x13A7150", Offset = "0x13A6550", VA = "0x1813A7150", Slot = "4")]
	private int IPGFPGLDHBG([In] int3 CBMEHPPMEEA)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct HDCNPMACIAB : EBFFCDOMAAO<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0xF8C850", Offset = "0xF8BC50", VA = "0x180F8C850")]
	public int ABGFPJEFANO([In] int3 CBMEHPPMEEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xF8C850", Offset = "0xF8BC50", VA = "0x180F8C850", Slot = "4")]
	private int IPGFPGLDHBG([In] int3 CBMEHPPMEEA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KNNHMCCJNEJ : RegisterType
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x23556D0", Offset = "0x2354AD0", VA = "0x1823556D0")]
	public KNNHMCCJNEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class IHEMLNHABNH : SystemBase, CGABDCIPMPC
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8474FA0", Offset = "0x84743A0", VA = "0x188474FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3D00BC0", Offset = "0x3CFFFC0", VA = "0x183D00BC0")]
	public void BMAJOINDJCN<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3D00BC0", Offset = "0x3CFFFC0", VA = "0x183D00BC0")]
	public void PCFPAPDDIIO<T>() where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8474EE0", Offset = "0x84742E0", VA = "0x188474EE0")]
	public JobHandle KKINAIBMPLA(ReadOnlySpan<int> BOKPGBMIBOG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3D01980", Offset = "0x3D00D80", VA = "0x183D01980")]
	public JobHandle PGJNEOJHKAH<T>() where T : struct
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8475090", Offset = "0x8474490", VA = "0x188475090")]
	public JobHandle PGJNEOJHKAH(ReadOnlySpan<int> BOKPGBMIBOG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3D00DD0", Offset = "0x3D001D0", VA = "0x183D00DD0")]
	public void MCHDIHOOCBK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3D01090", Offset = "0x3D00490", VA = "0x183D01090")]
	public JobHandle MCHDIHOOCBK<T>(JobHandle FELIADFOOJH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8474F30", Offset = "0x8474330", VA = "0x188474F30")]
	public JobHandle MCHDIHOOCBK(ReadOnlySpan<int> BOKPGBMIBOG, JobHandle FELIADFOOJH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3D00DD0", Offset = "0x3D001D0", VA = "0x183D00DD0")]
	public void KEPHFIGGMEE<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3D00E50", Offset = "0x3D00250", VA = "0x183D00E50")]
	public JobHandle KEPHFIGGMEE<T>(JobHandle FELIADFOOJH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8474E70", Offset = "0x8474270", VA = "0x188474E70")]
	public JobHandle KEPHFIGGMEE(Span<int> BOKPGBMIBOG, JobHandle FELIADFOOJH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3D018D0", Offset = "0x3D00CD0", VA = "0x183D018D0")]
	public ComponentDataFromEntity PFGFEGDHHCN<T>(bool FJELOMHKCGN = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8474FD0", Offset = "0x84743D0", VA = "0x188474FD0")]
	public ComponentDataFromEntity PFGFEGDHHCN(int HPCICPEJMIB, bool FJELOMHKCGN = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3D00D30", Offset = "0x3D00130", VA = "0x183D00D30")]
	public SharedComponentIndexFromEntity<T> KCPBLAFPDEL<T>() where T : ISharedComponentData
	{
		return default(SharedComponentIndexFromEntity<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8474DF0", Offset = "0x84741F0", VA = "0x188474DF0")]
	[BurstCompatible]
	public ComponentTypeHandle BEFLPPHPKGD(ComponentType OFINMLLNFLI)
	{
		return default(ComponentTypeHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8474E50", Offset = "0x8474250", VA = "0x188474E50")]
	public EntityExistenceLookupByEntity IKLLFHBOFAE()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x84750E0", Offset = "0x84744E0", VA = "0x1884750E0", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3D00C10", Offset = "0x3D00010", VA = "0x183D00C10")]
	public bool IJNLEGNHBAA<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "7")]
	protected sealed override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x23556D0", Offset = "0x2354AD0", VA = "0x1823556D0")]
	protected IHEMLNHABNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class EMAGEDACBDD : IHEMLNHABNH
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8474BB0", Offset = "0x8473FB0", VA = "0x188474BB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x23556D0", Offset = "0x2354AD0", VA = "0x1823556D0")]
	protected EMAGEDACBDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class MAAPGJNOKDA
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class FIDLAFLOAEM : EntityCommandBufferSystem, CGABDCIPMPC
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private AKNCNLDICPO GJFBEGANDPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xE9DB50", Offset = "0xE9CF50", VA = "0x180E9DB50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8474C00", Offset = "0x8474000", VA = "0x188474C00")]
	public FIDLAFLOAEM(AKNCNLDICPO CCLJCJDJCOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface EBFFCDOMAAO<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo ABGFPJEFANO([In] TFrom CBMEHPPMEEA);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface BAFBEJMPFGD<T>
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MAELHOLHIPG(T CBMEHPPMEEA);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct AJLNFJMDCCD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> FGABDCIOGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer LJHELOPBMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public ComponentTypes IIGOAHJGBIE;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x84747F0", Offset = "0x8473BF0", VA = "0x1884747F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct GAIJJMIPHFH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public NativeArray<Entity> FGABDCIOGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public EntityCommandBuffer LJHELOPBMLB;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8474CC0", Offset = "0x84740C0", VA = "0x188474CC0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[BurstCompile]
internal struct GGOAFGKBAEM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> FGABDCIOGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer LJHELOPBMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public ComponentType OFINMLLNFLI;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8474D60", Offset = "0x8474160", VA = "0x188474D60", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[BurstCompile]
internal struct OICFIGNDMPF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> FGABDCIOGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> NGIAGNLBILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer LJHELOPBMLB;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x59CF3C0", Offset = "0x59CE7C0", VA = "0x1859CF3C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal struct HBNMJAGBGBI<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> FGABDCIOGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public NativeArray<T> EJCCOPPBIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer LJHELOPBMLB;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal struct BALFMPEBGBA<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<Entity> FGABDCIOGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[ReadOnly]
	public T CBMEHPPMEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public EntityCommandBuffer LJHELOPBMLB;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct AFOONOJKFDJ<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, EBFFCDOMAAO<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<TFrom> ALEKBMJBDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<TTo> FEBOOBCCJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public TMap ENDEKEOKCCM;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct NHFBOGCJCCI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity CIMOMJBKDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> ALEKBMJBDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeArray<byte> FEBOOBCCJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int NOBPPMGNLDH;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8475410", Offset = "0x8474810", VA = "0x188475410", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct GHIJFLHOBHM<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public ComponentDataFromEntity<T> HCLIAFAMACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[ReadOnly]
	public NativeArray<Entity> ALEKBMJBDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[WriteOnly]
	public NativeList<T> EBHAELOCDGC;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct OAEFACNLDAK<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, EBFFCDOMAAO<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<TFrom> FPPKKPECEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[WriteOnly]
	public NativeList<TTo> FEBOOBCCJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public TMap ENDEKEOKCCM;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct OOGKIFKGFNM<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> CEIAJEDCDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> PJPJGIHKOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> HNDBNEFIBNE;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct PNDAGPMHDIA<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public ComponentDataFromEntity<T> CEIAJEDCDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[ReadOnly]
	public NativeArray<Entity> PJPJGIHKOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<bool> HNDBNEFIBNE;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5B22E90", Offset = "0x5B22290", VA = "0x185B22E90", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct GNELJPDFIAJ<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<T> ALEKBMJBDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<T> EBHAELOCDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<T> FPHMDDANKNJ;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4F65FF0", Offset = "0x4F653F0", VA = "0x184F65FF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct BDPOKAPPCNG<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : EBFFCDOMAAO<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<TFrom> ALEKBMJBDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public NativeList<TFrom> EBHAELOCDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeParallelHashSet<TTo> FPHMDDANKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TMap ENDEKEOKCCM;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct CCHCFPEACBF<T, TPredicate> : IJob where T : struct where TPredicate : struct, BAFBEJMPFGD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> ALEKBMJBDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<Entity> PKPKGAIFFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<Entity> PBCNIHIFEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate ENDEKEOKCCM;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct MJJJEMFBBKO<T, TPredicate> : IJob where T : struct where TPredicate : struct, BAFBEJMPFGD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<T> ALEKBMJBDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<T> EBHAELOCDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public TPredicate ENDEKEOKCCM;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BurstCompile]
internal struct FMKIICODKAJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity CEIAJEDCDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> PJPJGIHKOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> HCNOBALBJON;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8474C30", Offset = "0x8474030", VA = "0x188474C30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[BurstCompile]
internal struct KNMNLEIHGGI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[ReadOnly]
	public ComponentDataFromEntity CEIAJEDCDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[ReadOnly]
	public NativeArray<Entity> PJPJGIHKOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<Entity> HCNOBALBJON;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8475380", Offset = "0x8474780", VA = "0x188475380", Slot = "4")]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class FBBKFCPEEFA
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class HIEAJJEBGJD
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x3CC3FE0", Offset = "0x3CC33E0", VA = "0x183CC3FE0")]
	public static bool LPLCAGGMEAB<T>(this NativeArray<Entity> PJPJGIHKOKO, EntityManager JGFECLAMEOK, Allocator KCEIEKBPKNP = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class JIICKEFAGNH
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class NMHCCNPNDIE<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		public NMHCCNPNDIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class OOKFPEJACDE<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		public OOKFPEJACDE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly List<Func<JobHandle, JobHandle>> MGEDIDPIJKH;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8475100", Offset = "0x8474500", VA = "0x188475100")]
	public JIICKEFAGNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class KIPPEFIKFKI
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class PACOEGKIBJN
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct HBGLHPDKNPC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct EBPGMJGMGNI<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal HBGLHPDKNPC<TFrom> JIECBJMGMAC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator KCEIEKBPKNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeArray<TFrom> BEOBAPANJHO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct KIGEMIKBEKP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct LKHICDKPBBI<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal KIGEMIKBEKP<TFrom> JIECBJMGMAC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator KCEIEKBPKNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeList<TFrom> BEOBAPANJHO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct DDMMANNPKLC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct ACACBLHKPCK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal DDMMANNPKLC<TFrom> JIECBJMGMAC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator KCEIEKBPKNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeArrayAsync<TFrom> BEOBAPANJHO;
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct MHBHCENNDCA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public struct BOJLNAFEBKM<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			internal MHBHCENNDCA<TFrom> JIECBJMGMAC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		internal Allocator KCEIEKBPKNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		internal NativeListAsync<TFrom> BEOBAPANJHO;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class FBJDABKBICF
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class HMONALENHMO
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3CD6340", Offset = "0x3CD5740", VA = "0x183CD6340")]
	public static NativeList<T> CHODEONLOCK<T>(this NativeArray<T> IGHFJGAAJJJ, Allocator KCEIEKBPKNP = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class ONEJPAKKABI
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class OECFMBEMJBH
{
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3E88440", Offset = "0x3E87840", VA = "0x183E88440")]
	[MLDKNJJBDAL]
	public static JobHandle NIJIHCJIOFE<T>(this EntityCommandBufferSystem LHJOGJKGIBM, NativeArray<Entity> FGABDCIOGLK, NativeArray<T> NGIAGNLBILI) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3E88180", Offset = "0x3E87580", VA = "0x183E88180")]
	[MLDKNJJBDAL]
	public static JobHandle NIJIHCJIOFE<T>(this EntityCommandBufferSystem LHJOGJKGIBM, NativeArrayAsync<Entity> FGABDCIOGLK, NativeArrayAsync<T> NGIAGNLBILI, [Optional] JobHandle HMFPLJPFOFN) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3E88060", Offset = "0x3E87460", VA = "0x183E88060")]
	[MLDKNJJBDAL]
	public static JobHandle NIJIHCJIOFE<T>(this EntityCommandBufferSystem LHJOGJKGIBM, NativeArray<Entity> FGABDCIOGLK, [Optional] JobHandle HMFPLJPFOFN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x84756E0", Offset = "0x8474AE0", VA = "0x1884756E0")]
	[MLDKNJJBDAL]
	public static JobHandle NIJIHCJIOFE(this EntityCommandBufferSystem LHJOGJKGIBM, NativeArray<Entity> FGABDCIOGLK, ComponentTypes IIGOAHJGBIE, [Optional] JobHandle HMFPLJPFOFN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8475590", Offset = "0x8474990", VA = "0x188475590")]
	[MLDKNJJBDAL]
	public static JobHandle NIJIHCJIOFE(this EntityCommandBufferSystem LHJOGJKGIBM, EntityCommandBuffer LJHELOPBMLB, NativeArray<Entity> FGABDCIOGLK, ComponentTypes IIGOAHJGBIE, [Optional] JobHandle HMFPLJPFOFN)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class EOGDLBNNFGD
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class CJJAMFOOOKE
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8474920", Offset = "0x8473D20", VA = "0x188474920")]
	[MLDKNJJBDAL]
	public static JobHandle HMPCBMIOLLB(this EntityCommandBufferSystem LHJOGJKGIBM, NativeList<Entity> FGABDCIOGLK, [Optional] JobHandle HMFPLJPFOFN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8474AB0", Offset = "0x8473EB0", VA = "0x188474AB0")]
	[MLDKNJJBDAL]
	public static JobHandle HMPCBMIOLLB(this EntityCommandBufferSystem LHJOGJKGIBM, NativeArrayAsync<Entity> FGABDCIOGLK)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class ABBDKBODIDP
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x31E31C0", Offset = "0x31E25C0", VA = "0x1831E31C0")]
	public static void PNMJAOHEBND<T>(this EntityCommandBufferSystem LHJOGJKGIBM, EntityQuery MEHCBCCALPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x31E3120", Offset = "0x31E2520", VA = "0x1831E3120")]
	[MLDKNJJBDAL]
	public static JobHandle BDPLACJEOHJ<T>(this EntityCommandBufferSystem LHJOGJKGIBM, NativeArrayAsync<Entity> FGABDCIOGLK, [Optional] JobHandle HMFPLJPFOFN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8474540", Offset = "0x8473940", VA = "0x188474540")]
	[MLDKNJJBDAL]
	public static JobHandle BDPLACJEOHJ(this EntityCommandBufferSystem LHJOGJKGIBM, NativeArrayAsync<Entity> FGABDCIOGLK, ComponentType OFINMLLNFLI, [Optional] JobHandle HMFPLJPFOFN)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class GKLMMKBFFIH
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3CB9A80", Offset = "0x3CB8E80", VA = "0x183CB9A80")]
	[MLDKNJJBDAL]
	public static JobHandle BNEDIKGKEAL<T>(this EntityCommandBufferSystem LHJOGJKGIBM, NativeArray<Entity> FGABDCIOGLK, NativeArray<T> NGIAGNLBILI, JobHandle HMFPLJPFOFN) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class PNONKGGFIAL
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class DDAOIFKGLJC
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class KMLGDDGPKJG
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3D90DC0", Offset = "0x3D901C0", VA = "0x183D90DC0")]
	public static NativeArray<T> COBCPPDFNHO<T>(this NativeList<Entity> IGHFJGAAJJJ, EntityManager JGFECLAMEOK, Allocator KCEIEKBPKNP = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3D90C00", Offset = "0x3D90000", VA = "0x183D90C00")]
	public static NativeArray<T> COBCPPDFNHO<T>(this NativeArray<Entity> IGHFJGAAJJJ, EntityManager JGFECLAMEOK, Allocator KCEIEKBPKNP = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8475190", Offset = "0x8474590", VA = "0x188475190")]
	public static NativeArray<Entity> CMHDEFIHLOH(this NativeArray<Entity> IGHFJGAAJJJ, EntityManager JGFECLAMEOK, ComponentType OFINMLLNFLI, Allocator KCEIEKBPKNP = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3D90B00", Offset = "0x3D8FF00", VA = "0x183D90B00")]
	public static NativeArray<T> BCMMHBGPKFA<T>(this NativeArray<Entity> IGHFJGAAJJJ, EntityManager JGFECLAMEOK, Allocator KCEIEKBPKNP = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class MCBAJJMODDK
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct OKCMHKCGJNA<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct DNCHMBCOKAO<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public OKCMHKCGJNA<TFrom> BEOBAPANJHO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator KCEIEKBPKNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArray<TFrom> ALEKBMJBDKP;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct AIGBPGFCEJK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct AGPONOBEEPM<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public AIGBPGFCEJK<TFrom> BEOBAPANJHO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator KCEIEKBPKNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeArrayAsync<TFrom> ALEKBMJBDKP;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public struct LOGJGHFMNGI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public struct JLBMJPGBLIL<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public LOGJGHFMNGI<TFrom> BEOBAPANJHO;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator KCEIEKBPKNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeListAsync<TFrom> ALEKBMJBDKP;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class AMKCBCLDFDD
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class EGLLKJDPJIK
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct KMNJJHJLKON : EBFFCDOMAAO<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> IJMKNJCOEOO;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8475370", Offset = "0x8474770", VA = "0x188475370")]
		[BurstCompatible]
		public Entity ABGFPJEFANO([In] Entity CBMEHPPMEEA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8475370", Offset = "0x8474770", VA = "0x188475370", Slot = "4")]
		private Entity FKOJCKHNKPN([In] Entity CBMEHPPMEEA)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class CDDFMFLJPEC
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private struct IDBOGEFMFIF<TKey, TValue> : IComparer<(TKey, TValue)> where TKey : struct, IComparable<TKey> where TValue : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x50AA180", Offset = "0x50A9580", VA = "0x1850AA180", Slot = "4")]
		public int Compare((TKey, TValue) FNBJHADJBNG, (TKey, TValue) MODFPFNICHM)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3AA0760", Offset = "0x3A9FB60", VA = "0x183AA0760")]
	public static void KDBPIKMBPKC<TKey, TValue>(NativeList<TKey> ACDIIENFLJA, NativeList<TValue> EJCCOPPBIIG) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3AA09D0", Offset = "0x3A9FDD0", VA = "0x183AA09D0")]
	public static void KDBPIKMBPKC<TKey, TValue>(NativeArray<TKey> ACDIIENFLJA, NativeArray<TValue> EJCCOPPBIIG) where TKey : struct, IComparable<TKey> where TValue : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x3AA0550", Offset = "0x3A9F950", VA = "0x183AA0550")]
	public static void KDBPIKMBPKC<TKey, TValue, U>(NativeArray<TKey> ACDIIENFLJA, NativeArray<TValue> EJCCOPPBIIG, U ENPHIOABINL) where TKey : struct where TValue : struct where U : struct, IComparer<(TKey, TValue)>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class EMAJLGHBEJB
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct BLECKEMIPAN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator KCEIEKBPKNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<Entity> PKPKGAIFFIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> ALEKBMJBDKP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct LOIJLLMNOOM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator KCEIEKBPKNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeList<Entity> PKPKGAIFFIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArray<T> ALEKBMJBDKP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct OMEAIHHLBLB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator KCEIEKBPKNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArrayAsync<Entity> PKPKGAIFFIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeArrayAsync<T> ALEKBMJBDKP;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class NFHKDLFMBKF
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class PHLHAEJFLGB
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct HEEJONBOKBH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator KCEIEKBPKNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArray<T> ALEKBMJBDKP;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct BCICBKBOCNL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator KCEIEKBPKNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeList<T> ALEKBMJBDKP;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct EBFIJJPFPGC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Allocator KCEIEKBPKNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public NativeArrayAsync<T> ALEKBMJBDKP;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct CPFCMPCNNEJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Allocator KCEIEKBPKNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public NativeListAsync<T> ALEKBMJBDKP;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class LHFFHCHEHID
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class CFJBKHGECPG
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3AA7920", Offset = "0x3AA6D20", VA = "0x183AA7920")]
	public static NativeList<Entity> KIBOLPKJIEG<T>(this NativeList<Entity> PJPJGIHKOKO, EntityManager JGFECLAMEOK, Allocator KCEIEKBPKNP = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3AA71A0", Offset = "0x3AA65A0", VA = "0x183AA71A0")]
	public static NativeList<Entity> KIBOLPKJIEG<T>(this NativeArray<Entity> PJPJGIHKOKO, EntityManager JGFECLAMEOK, Allocator KCEIEKBPKNP = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class PJPNCAFDGDL
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3ED1700", Offset = "0x3ED0B00", VA = "0x183ED1700")]
	public static NativeList<Entity> ONJNJFECLJO<T>(this NativeArray<Entity> PJPJGIHKOKO, EntityManager JGFECLAMEOK, Allocator KCEIEKBPKNP = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class LKJLNGEBKLF
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public readonly struct FOPLKEJCMEK<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> LMLCJEFLFMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public readonly struct GIFOEPPBLGL<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly NativeArray<TSrc> LMLCJEFLFMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public readonly struct JPOKPIMEGGH<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, EBFFCDOMAAO<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly NativeArray<TSrc> LMLCJEFLFMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct MFAIMCJBBII<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, EBFFCDOMAAO<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly NativeArray<TSrc> LMLCJEFLFMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TSelector BIECLDLJNFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int NOEININIMIL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct CFKHDMIOEJP<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, EBFFCDOMAAO<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private MFAIMCJBBII<TSrc, TValue, TSelector> DKMELEEAPAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TValue NEEKPMADNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int FDIBAFEDFOG;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class IMFDBEPBABJ
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct GMKEHINKEBH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly NativeArray<T> LMLCJEFLFMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int FDIBAFEDFOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int MJELINODGCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private T NEEKPMADNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T DKAKCJCIABD;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public NJKCHNHGMDO BNGFKOPPFBA
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x4E9D9A0", Offset = "0x4E9CDA0", VA = "0x184E9D9A0")]
			get
			{
				return default(NJKCHNHGMDO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public T HAMDPJGAEFM
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public (T, NJKCHNHGMDO) FEIHGLOFMJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x4E9D7B0", Offset = "0x4E9CBB0", VA = "0x184E9D7B0")]
			get
			{
				return default((T, NJKCHNHGMDO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4F65F20", Offset = "0x4F65320", VA = "0x184F65F20")]
		public GMKEHINKEBH(NativeArray<T> LMLCJEFLFMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2CBCE70", Offset = "0x2CBC270", VA = "0x182CBCE70")]
		public GMKEHINKEBH<T> OJAPBOKMMBI()
		{
			return default(GMKEHINKEBH<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x4F65A90", Offset = "0x4F64E90", VA = "0x184F65A90")]
		public bool BHOBOOOFJDO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4049860", Offset = "0x4048C60", VA = "0x184049860")]
		public FJIMJDKFLNH<T, TComparer> DNKAOMAEPCA<TComparer>([Optional] TComparer ENPHIOABINL) where TComparer : struct, IEqualityComparer<T>
		{
			return default(FJIMJDKFLNH<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct FJIMJDKFLNH<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly NativeArray<T> LMLCJEFLFMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int FDIBAFEDFOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int MJELINODGCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private T NEEKPMADNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private T DKAKCJCIABD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private TComparer ENPHIOABINL;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public NJKCHNHGMDO BNGFKOPPFBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x4E9D9A0", Offset = "0x4E9CDA0", VA = "0x184E9D9A0")]
			get
			{
				return default(NJKCHNHGMDO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T HAMDPJGAEFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public (T value, NJKCHNHGMDO range) FEIHGLOFMJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x4E9D7B0", Offset = "0x4E9CBB0", VA = "0x184E9D7B0")]
			get
			{
				return default((T, NJKCHNHGMDO));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x4E9D9E0", Offset = "0x4E9CDE0", VA = "0x184E9D9E0")]
		public FJIMJDKFLNH(NativeArray<T> LMLCJEFLFMP, TComparer ENPHIOABINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4AB19D0", Offset = "0x4AB0DD0", VA = "0x184AB19D0")]
		public FJIMJDKFLNH<T, TComparer> OJAPBOKMMBI()
		{
			return default(FJIMJDKFLNH<T, TComparer>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x4E9D650", Offset = "0x4E9CA50", VA = "0x184E9D650")]
		public bool BHOBOOOFJDO()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3D27EB0", Offset = "0x3D272B0", VA = "0x183D27EB0")]
	public static GMKEHINKEBH<T> KFLCNCLIAFL<T>(this NativeArray<T> LMLCJEFLFMP) where T : struct
	{
		return default(GMKEHINKEBH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface KAKFGPPKGGO
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class MCKOPENOHDM
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct GHNDMJEMPBO<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class PILKCBDOHKB : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public GHNDMJEMPBO<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xD45140", Offset = "0xD44540", VA = "0x180D45140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4F235D0", Offset = "0x4F229D0", VA = "0x184F235D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
		[DebuggerHidden]
		public PILKCBDOHKB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5AC8F60", Offset = "0x5AC8360", VA = "0x185AC8F60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5AC9110", Offset = "0x5AC8510", VA = "0x185AC9110", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public readonly Action<Protobuf> MCGOFAFNJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MemoryStream GBHJNKNIPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly CodedInputStream ACBDCFCKFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly Protobuf JKJOEJKLENN;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly int DGIEKOECJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xACA830", Offset = "0xAC9C30", VA = "0x180ACA830")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4F56140", Offset = "0x4F55540", VA = "0x184F56140", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4F56180", Offset = "0x4F55580", VA = "0x184F56180", Slot = "4")]
	[IteratorStateMachine(typeof(GHNDMJEMPBO<>.PILKCBDOHKB))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4F56270", Offset = "0x4F55670", VA = "0x184F56270", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct AAGOEBBHHKC<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly byte[] JCGBEKOGKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Protobuf JKJOEJKLENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MemoryStream GBHJNKNIPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CodedOutputStream BBFOIJHGILH;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x50FF580", Offset = "0x50FE980", VA = "0x1850FF580", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct BLILJFIDIBL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream GBHJNKNIPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedInputStream ACBDCFCKFEJ;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x84748E0", Offset = "0x8473CE0", VA = "0x1884748E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct AINNGGBGGMF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly byte[] JCGBEKOGKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly MemoryStream GBHJNKNIPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly CodedOutputStream BBFOIJHGILH;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x84746D0", Offset = "0x8473AD0", VA = "0x1884746D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class LJLPFFDGDPL
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class PJICFLHBNCN
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[Flags]
public enum FOOCDMJGGLM
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
internal static class OBJAMONAGCE
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class FCNBKKGCIKA
{
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public FCNBKKGCIKA()
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
