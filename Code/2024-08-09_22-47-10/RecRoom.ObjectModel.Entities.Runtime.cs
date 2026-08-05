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
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
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
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
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
		[Cpp2IlInjected.Address(RVA = "0x69E9770", Offset = "0x69E8B70", VA = "0x1869E9770")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FENJKIKIKGD : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	HJLGAPHHBPO BCOFABEOFDI
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
public interface HFNNGCGFCIG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PMGOHICPNEL(Entity KHAAFKNHHNL, object IAIFDAAIBBN);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JICKLOFBELE(Entity KHAAFKNHHNL, object IAIFDAAIBBN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HJDCJAHNCBL(Entity KHAAFKNHHNL);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class BEBPHAPJCLL<TComponentData, TValue> : PFDEAHOGCEF<TValue>, IDisposable where TComponentData : struct, FENJKIKIKGD
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class JIMCNLFGHHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> EGGGJKKPDIP;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int AKKFFAPEOHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x35B8D10", Offset = "0x35B8110", VA = "0x1835B8D10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x40640B0", Offset = "0x40634B0", VA = "0x1840640B0")]
		public bool APOKLOIOBJG([Out] TValue OBEEJPGJPFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x40642A0", Offset = "0x40636A0", VA = "0x1840642A0")]
		public void HINMMBAADBG(object IAIFDAAIBBN, TValue OBEEJPGJPFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4064380", Offset = "0x4063780", VA = "0x184064380")]
		public bool LHAIFCNDDDC(object IAIFDAAIBBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x40641C0", Offset = "0x40635C0", VA = "0x1840641C0")]
		public int GABGLIPHJDD(object IAIFDAAIBBN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4064430", Offset = "0x4063830", VA = "0x184064430")]
		public JIMCNLFGHHK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<JIMCNLFGHHK> MICGNMFGBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private KFDBGKKPNII<HJLGAPHHBPO, JIMCNLFGHHK> HEMBOPKMACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager NIHNJICAABF;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4E8D5B0", Offset = "0x4E8C9B0", VA = "0x184E8D5B0")]
	public BEBPHAPJCLL(EntityManager NIHNJICAABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4E8D430", Offset = "0x4E8C830", VA = "0x184E8D430", Slot = "4")]
	public void PMGOHICPNEL(Entity KHAAFKNHHNL, object IAIFDAAIBBN, TValue OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4E8D080", Offset = "0x4E8C480", VA = "0x184E8D080", Slot = "5")]
	public bool JICKLOFBELE(Entity KHAAFKNHHNL, object IAIFDAAIBBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4E8CD50", Offset = "0x4E8C150", VA = "0x184E8CD50", Slot = "6")]
	public bool APOKLOIOBJG(Entity KHAAFKNHHNL, [Out] TValue OBEEJPGJPFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4E8CE60", Offset = "0x4E8C260", VA = "0x184E8CE60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4E8CFC0", Offset = "0x4E8C3C0", VA = "0x184E8CFC0")]
	private void JHGPEODKCBH(JIMCNLFGHHK NBFMKPAFICB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4E8D270", Offset = "0x4E8C670", VA = "0x184E8D270")]
	private bool JONBFOFJCBF(Entity KHAAFKNHHNL, [Out] HJLGAPHHBPO EELBLNNILCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4E8D330", Offset = "0x4E8C730", VA = "0x184E8D330")]
	private void LDANOPMPAOE(Entity KHAAFKNHHNL, HJLGAPHHBPO EELBLNNILCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4E8CE80", Offset = "0x4E8C280", VA = "0x184E8CE80")]
	private bool EHFAGCOCLNL(HJLGAPHHBPO EELBLNNILCF, [Out] JIMCNLFGHHK NBFMKPAFICB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4E8CEA0", Offset = "0x4E8C2A0", VA = "0x184E8CEA0")]
	private JIMCNLFGHHK IGNONPMLCCN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PFDEAHOGCEF<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PMGOHICPNEL(Entity KHAAFKNHHNL, object IAIFDAAIBBN, TValue OBEEJPGJPFD);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JICKLOFBELE(Entity KHAAFKNHHNL, object IAIFDAAIBBN);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool APOKLOIOBJG(Entity KHAAFKNHHNL, [Out] TValue OBEEJPGJPFD);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct HJLGAPHHBPO : GLFEIEJPNEO, IEquatable<HJLGAPHHBPO>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly HJLGAPHHBPO ABBKLKCLAKE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int KCOEJCJFNCN
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xB50400", Offset = "0xB4F800", VA = "0x180B50400", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xB503C0", Offset = "0xB4F7C0", VA = "0x180B503C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int JAGCLOHPBDL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x258C120", Offset = "0x258B520", VA = "0x18258C120", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5CC1520", Offset = "0x5CC0920", VA = "0x185CC1520", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x69E9790", Offset = "0x69E8B90", VA = "0x1869E9790", Slot = "8")]
	public bool Equals(HJLGAPHHBPO IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x69E97E0", Offset = "0x69E8BE0", VA = "0x1869E97E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class PKDKDABNCOC<THasTokensTag> : HFNNGCGFCIG, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly BADOKLEEAHE MMCLBKHCHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, HJLGAPHHBPO> NODEAJFCPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> MICGNMFGBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private KFDBGKKPNII<HJLGAPHHBPO, HashSet<object>> HEMBOPKMACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager NIHNJICAABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem FGJNGACCPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool BHKOIIDPEHB;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x47EFAB0", Offset = "0x47EEEB0", VA = "0x1847EFAB0")]
	public PKDKDABNCOC(EntityManager NIHNJICAABF, EntityCommandBufferSystem FGJNGACCPIG, BADOKLEEAHE CCDOPNGAKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x47EF590", Offset = "0x47EE990", VA = "0x1847EF590", Slot = "4")]
	public bool PMGOHICPNEL(Entity KHAAFKNHHNL, object IAIFDAAIBBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x47EDDB0", Offset = "0x47ED1B0", VA = "0x1847EDDB0", Slot = "5")]
	public bool JICKLOFBELE(Entity KHAAFKNHHNL, object IAIFDAAIBBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x47ED590", Offset = "0x47EC990", VA = "0x1847ED590", Slot = "6")]
	public bool HJDCJAHNCBL(Entity KHAAFKNHHNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x47ED4E0", Offset = "0x47EC8E0", VA = "0x1847ED4E0", Slot = "8")]
	public bool HJDCJAHNCBL(HJLGAPHHBPO EELBLNNILCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x47ED280", Offset = "0x47EC680", VA = "0x1847ED280", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x47EDC60", Offset = "0x47ED060", VA = "0x1847EDC60")]
	private void JHGPEODKCBH(HashSet<object> NBFMKPAFICB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x47EE690", Offset = "0x47EDA90", VA = "0x1847EE690")]
	private bool JONBFOFJCBF(Entity KHAAFKNHHNL, [Out] HJLGAPHHBPO EELBLNNILCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x47ED040", Offset = "0x47EC440", VA = "0x1847ED040")]
	private bool DMFJDLOJNMP(Entity KHAAFKNHHNL, [Out] HJLGAPHHBPO EELBLNNILCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x47EEAF0", Offset = "0x47EDEF0", VA = "0x1847EEAF0")]
	private void ODPPBGBBBIP(Entity KHAAFKNHHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x47EEFF0", Offset = "0x47EE3F0", VA = "0x1847EEFF0")]
	private void PCGLFGPMAHI(Entity KHAAFKNHHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x47ED6F0", Offset = "0x47ECAF0", VA = "0x1847ED6F0")]
	private void IEANDBHMJCL(Entity KHAAFKNHHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x47EE830", Offset = "0x47EDC30", VA = "0x1847EE830")]
	private void LDANOPMPAOE(Entity KHAAFKNHHNL, HJLGAPHHBPO EELBLNNILCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x47ECF20", Offset = "0x47EC320", VA = "0x1847ECF20")]
	private bool CBHJNPFBIMI(HJLGAPHHBPO EELBLNNILCF, [Out] HashSet<object> NBFMKPAFICB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x47EDB50", Offset = "0x47ECF50", VA = "0x1847EDB50")]
	private HashSet<object> IGNONPMLCCN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class NEMMINFOLFN
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct MOBGPBLNGDP : OKHCFDMGEPH<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x69E9D20", Offset = "0x69E9120", VA = "0x1869E9D20")]
	public float NMNBLHHKCHI([In] float3 OBEEJPGJPFD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x69E9D20", Offset = "0x69E9120", VA = "0x1869E9D20", Slot = "4")]
	private float JOFEFEFPKDN([In] float3 OBEEJPGJPFD)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct DADCHJPMHEG : OKHCFDMGEPH<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x69E95A0", Offset = "0x69E89A0", VA = "0x1869E95A0")]
	public float NMNBLHHKCHI([In] float3 OBEEJPGJPFD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x69E95A0", Offset = "0x69E89A0", VA = "0x1869E95A0", Slot = "4")]
	private float JOFEFEFPKDN([In] float3 OBEEJPGJPFD)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct MBMMICJAOFA : OKHCFDMGEPH<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1DFA900", Offset = "0x1DF9D00", VA = "0x181DFA900")]
	public float NMNBLHHKCHI([In] float3 OBEEJPGJPFD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1DFA900", Offset = "0x1DF9D00", VA = "0x181DFA900", Slot = "4")]
	private float JOFEFEFPKDN([In] float3 OBEEJPGJPFD)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct EHINBCHCAHH : OKHCFDMGEPH<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1683EF0", Offset = "0x16832F0", VA = "0x181683EF0")]
	public int NMNBLHHKCHI([In] int3 OBEEJPGJPFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1683EF0", Offset = "0x16832F0", VA = "0x181683EF0", Slot = "4")]
	private int KHNPIDFKDAA([In] int3 OBEEJPGJPFD)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct DDBHNBEHDAD : OKHCFDMGEPH<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x69E95B0", Offset = "0x69E89B0", VA = "0x1869E95B0")]
	public int NMNBLHHKCHI([In] int3 OBEEJPGJPFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x69E95B0", Offset = "0x69E89B0", VA = "0x1869E95B0", Slot = "4")]
	private int KHNPIDFKDAA([In] int3 OBEEJPGJPFD)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct IAAEAHOHOPG : OKHCFDMGEPH<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1853DF0", Offset = "0x18531F0", VA = "0x181853DF0")]
	public int NMNBLHHKCHI([In] int3 OBEEJPGJPFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1853DF0", Offset = "0x18531F0", VA = "0x181853DF0", Slot = "4")]
	private int KHNPIDFKDAA([In] int3 OBEEJPGJPFD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class HKBCCOCDDCG : AFENHBMIOLA
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x15B3AC0", Offset = "0x15B2EC0", VA = "0x1815B3AC0")]
	public HKBCCOCDDCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class DHMGPBABENG : SystemBase, IJPDCJFICGO
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x69E9710", Offset = "0x69E8B10", VA = "0x1869E9710")]
	public JobHandle OAPMDNPDDGB(ReadOnlySpan<int> CFEEKJLLHJE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2997CF0", Offset = "0x29970F0", VA = "0x182997CF0")]
	public void GINCFFAGEHO<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2997890", Offset = "0x2996C90", VA = "0x182997890")]
	public JobHandle GINCFFAGEHO<T>(JobHandle EELBLNNILCF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x69E95E0", Offset = "0x69E89E0", VA = "0x1869E95E0")]
	public JobHandle GINCFFAGEHO(ReadOnlySpan<int> CFEEKJLLHJE, JobHandle EELBLNNILCF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2997CF0", Offset = "0x29970F0", VA = "0x182997CF0")]
	public void JGLECGDGHON<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2998800", Offset = "0x2997C00", VA = "0x182998800")]
	public JobHandle JGLECGDGHON<T>(JobHandle EELBLNNILCF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x69E9650", Offset = "0x69E8A50", VA = "0x1869E9650")]
	public ComponentDataFromEntity LHAGBGABODC(int OLMBNHICOOH, bool KEGIADFCPCA = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x69E95C0", Offset = "0x69E89C0", VA = "0x1869E95C0")]
	public EntityExistenceLookupByEntity COLCJDKOODE()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x69E9760", Offset = "0x69E8B60", VA = "0x1869E9760", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x15B3AC0", Offset = "0x15B2EC0", VA = "0x1815B3AC0")]
	protected DHMGPBABENG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class HJMKBJJIEJL : DHMGPBABENG
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x69E9830", Offset = "0x69E8C30", VA = "0x1869E9830", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x15B3AC0", Offset = "0x15B2EC0", VA = "0x1815B3AC0")]
	protected HJMKBJJIEJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class ALNEPABFHMG
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class GEJNMEEKOAK : EntityCommandBufferSystem, IJPDCJFICGO
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x15B3AC0", Offset = "0x15B2EC0", VA = "0x1815B3AC0")]
	protected GEJNMEEKOAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OKHCFDMGEPH<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo NMNBLHHKCHI([In] TFrom OBEEJPGJPFD);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface COKNIHJAKAL<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GPONCPGMDCC(T OBEEJPGJPFD);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BurstCompile]
internal struct NBCNFAKOLNH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[ReadOnly]
	public NativeArray<Entity> OMFJPLKFCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public EntityCommandBuffer DAIEEBBBKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public ComponentTypes FFDAHNANPCC;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x69E9D30", Offset = "0x69E9130", VA = "0x1869E9D30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct CDLDNGCJIOM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<Entity> OMFJPLKFCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public EntityCommandBuffer DAIEEBBBKKG;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x69E9240", Offset = "0x69E8640", VA = "0x1869E9240", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct BNDKEJNMIOG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public NativeArray<Entity> OMFJPLKFCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public EntityCommandBuffer DAIEEBBBKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public ComponentType HCLAMIDKCAN;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x69E91C0", Offset = "0x69E85C0", VA = "0x1869E91C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct JAMJIKNOGIF<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<Entity> OMFJPLKFCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public NativeArray<T> LDNEPNAGEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public EntityCommandBuffer DAIEEBBBKKG;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4017DB0", Offset = "0x40171B0", VA = "0x184017DB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal struct LLAMAIAJKPB<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<Entity> OMFJPLKFCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	[ReadOnly]
	public NativeArray<T> FJJNGLOPNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EntityCommandBuffer DAIEEBBBKKG;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct OCHFICJPNOM<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public NativeArray<Entity> OMFJPLKFCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[ReadOnly]
	public T OBEEJPGJPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public EntityCommandBuffer DAIEEBBBKKG;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4671C10", Offset = "0x4671010", VA = "0x184671C10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BurstCompile]
internal struct JKLDBBELLCC<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, OKHCFDMGEPH<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[ReadOnly]
	public NativeArray<TFrom> FBOFIAFKFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[WriteOnly]
	public NativeArray<TTo> JFHEBELGINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public TMap FADGJFNLBLP;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct KLFBPIBELDE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public ComponentDataFromEntity GPPKCHDBLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public NativeArray<Entity> FBOFIAFKFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[WriteOnly]
	public NativeArray<byte> JFHEBELGINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public int FEKKDNMHPIN;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x69E9C20", Offset = "0x69E9020", VA = "0x1869E9C20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct FCMMNNPEHNK<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public ComponentDataFromEntity<T> KEMBEGKIEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public NativeArray<Entity> FBOFIAFKFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[WriteOnly]
	public NativeList<T> OBCPLNGNFEL;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct EKGAEOCIOND<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, OKHCFDMGEPH<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public NativeArray<TFrom> KNEINECAGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeList<TTo> JFHEBELGINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TMap FADGJFNLBLP;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct GOHMBAGHOJD<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public ComponentDataFromEntity<T> BAJLBPEGKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[ReadOnly]
	public NativeArray<Entity> GAKNDOJBCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<bool> GCCNHMLFFJK;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct EAGDFFIEPLO<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public ComponentDataFromEntity<T> BAJLBPEGKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[ReadOnly]
	public NativeArray<Entity> GAKNDOJBCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public NativeArray<bool> GCCNHMLFFJK;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x37DA4F0", Offset = "0x37D98F0", VA = "0x1837DA4F0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct AHGCJHNEIPL<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[ReadOnly]
	public NativeArray<T> FBOFIAFKFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeList<T> OBCPLNGNFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeParallelHashSet<T> OGIBNNKHLGO;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3D6EC20", Offset = "0x3D6E020", VA = "0x183D6EC20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct LLFPNIOKGMI<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : OKHCFDMGEPH<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	[ReadOnly]
	public NativeArray<TFrom> FBOFIAFKFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeList<TFrom> OBCPLNGNFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public NativeParallelHashSet<TTo> OGIBNNKHLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public TMap FADGJFNLBLP;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct NIDGELDLLDD<T, TPredicate> : IJob where T : struct where TPredicate : struct, COKNIHJAKAL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public NativeArray<T> FBOFIAFKFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	public NativeArray<Entity> CNAPDCPBDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NativeList<Entity> AJINBAANLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public TPredicate FADGJFNLBLP;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct HKBGGDJGCBC<T, TPredicate> : IJob where T : struct where TPredicate : struct, COKNIHJAKAL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	public NativeArray<T> FBOFIAFKFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NativeList<T> OBCPLNGNFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public TPredicate FADGJFNLBLP;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct OIFPOOGFMCA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public ComponentDataFromEntity BAJLBPEGKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	public NativeArray<Entity> GAKNDOJBCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public NativeList<Entity> DINMIAINHDJ;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x69EA0D0", Offset = "0x69E94D0", VA = "0x1869EA0D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct NBECPNFELEK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public ComponentDataFromEntity BAJLBPEGKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[ReadOnly]
	public NativeArray<Entity> GAKNDOJBCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<Entity> DINMIAINHDJ;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x69E9E20", Offset = "0x69E9220", VA = "0x1869E9E20", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class BLMPEEACBAF
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class MKLGNBNONMI
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2C54B80", Offset = "0x2C53F80", VA = "0x182C54B80")]
	public static bool JDHIBNMHDLB<T>(this NativeArray<Entity> GAKNDOJBCLO, EntityManager NIHNJICAABF, Allocator EIFDLGAHDFC = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class PMOLNJAMHNK
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class LMMALEEMAOH<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		public LMMALEEMAOH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class GHCBIDAHNJE<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		public GHCBIDAHNJE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly List<Func<JobHandle, JobHandle>> BBIBMFLAPJD;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x69EA160", Offset = "0x69E9560", VA = "0x1869EA160")]
	public PMOLNJAMHNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class EKDHPGJIBBK
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class OJMGPJMOCMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct FHCDJLEMALP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct IMLFFBOIJFE<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			internal FHCDJLEMALP<TFrom> KOBAADDGPBN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal Allocator EIFDLGAHDFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		internal NativeArray<TFrom> DENOKKMKOFP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct OMHMOJMJOLG<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct OILELADPDND<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			internal OMHMOJMJOLG<TFrom> KOBAADDGPBN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal Allocator EIFDLGAHDFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		internal NativeList<TFrom> DENOKKMKOFP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct KCPNOOJGFGP<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct CCFNBMDPINL<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			internal KCPNOOJGFGP<TFrom> KOBAADDGPBN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal Allocator EIFDLGAHDFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		internal NativeArrayAsync<TFrom> DENOKKMKOFP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct BEFFNNPJDHM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct IKOPIOGILCL<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			internal BEFFNNPJDHM<TFrom> KOBAADDGPBN;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal Allocator EIFDLGAHDFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal NativeListAsync<TFrom> DENOKKMKOFP;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class KPFDHIBCDHB
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class GKKPNILKNNA
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2B6A590", Offset = "0x2B69990", VA = "0x182B6A590")]
	public static NativeList<T> IKBOGCOLGMK<T>(this NativeArray<T> OJNDDLHKGHK, Allocator EIFDLGAHDFC = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class EJLLLGHDEOB
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class CINNKJAHDAK
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x295C5D0", Offset = "0x295B9D0", VA = "0x18295C5D0")]
	[FOPHEPAMDGI]
	public static JobHandle CLMDLJIBFCA<T>(this EntityCommandBufferSystem FGJNGACCPIG, NativeArrayAsync<Entity> OMFJPLKFCMF, NativeArrayAsync<T> LDNEPNAGEGN, [Optional] JobHandle CMCMGFGEBFC) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x295C880", Offset = "0x295BC80", VA = "0x18295C880")]
	[FOPHEPAMDGI]
	public static JobHandle CLMDLJIBFCA<T>(this EntityCommandBufferSystem FGJNGACCPIG, NativeArrayAsync<Entity> OMFJPLKFCMF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x295C750", Offset = "0x295BB50", VA = "0x18295C750")]
	[FOPHEPAMDGI]
	public static JobHandle CLMDLJIBFCA<T>(this EntityCommandBufferSystem FGJNGACCPIG, NativeArray<Entity> OMFJPLKFCMF, [Optional] JobHandle CMCMGFGEBFC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x69E92E0", Offset = "0x69E86E0", VA = "0x1869E92E0")]
	[FOPHEPAMDGI]
	public static JobHandle CLMDLJIBFCA(this EntityCommandBufferSystem FGJNGACCPIG, NativeArray<Entity> OMFJPLKFCMF, ComponentTypes FFDAHNANPCC, [Optional] JobHandle CMCMGFGEBFC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x69E9450", Offset = "0x69E8850", VA = "0x1869E9450")]
	[FOPHEPAMDGI]
	public static JobHandle CLMDLJIBFCA(this EntityCommandBufferSystem FGJNGACCPIG, EntityCommandBuffer DAIEEBBBKKG, NativeArray<Entity> OMFJPLKFCMF, ComponentTypes FFDAHNANPCC, [Optional] JobHandle CMCMGFGEBFC)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class AOFNHAAFLMA
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3225C50", Offset = "0x3225050", VA = "0x183225C50")]
	[FOPHEPAMDGI]
	public static JobHandle LHPKCCBCNME<T>(this EntityCommandBufferSystem FGJNGACCPIG, EntityCommandBuffer DAIEEBBBKKG, EntityQuery EMMJEBBEHMJ, T OBEEJPGJPFD) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class IAEBPFMIENG
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x69E9960", Offset = "0x69E8D60", VA = "0x1869E9960")]
	[FOPHEPAMDGI]
	public static JobHandle EOODEBGFAHC(this EntityCommandBufferSystem FGJNGACCPIG, NativeList<Entity> OMFJPLKFCMF, [Optional] JobHandle CMCMGFGEBFC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x69E9860", Offset = "0x69E8C60", VA = "0x1869E9860")]
	[FOPHEPAMDGI]
	public static JobHandle EOODEBGFAHC(this EntityCommandBufferSystem FGJNGACCPIG, NativeArrayAsync<Entity> OMFJPLKFCMF)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class NHPPOKPKKLJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class KIPGEIONOHG
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2C266A0", Offset = "0x2C25AA0", VA = "0x182C266A0")]
	[FOPHEPAMDGI]
	public static JobHandle FEHLHMKCEHF<T>(this EntityCommandBufferSystem FGJNGACCPIG, NativeArray<Entity> OMFJPLKFCMF, NativeArray<T> LDNEPNAGEGN, JobHandle CMCMGFGEBFC) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class GPJJIJMAGPF
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2B6EC50", Offset = "0x2B6E050", VA = "0x182B6EC50")]
	[FOPHEPAMDGI]
	public static JobHandle FDDIFHIFPFM<T>(this EntityCommandBufferSystem FGJNGACCPIG, NativeArray<Entity> OMFJPLKFCMF, T OBEEJPGJPFD, [Optional] JobHandle CMCMGFGEBFC) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2B6ED40", Offset = "0x2B6E140", VA = "0x182B6ED40")]
	[FOPHEPAMDGI]
	public static JobHandle FDDIFHIFPFM<T>(this EntityCommandBufferSystem FGJNGACCPIG, EntityCommandBuffer DAIEEBBBKKG, NativeArray<Entity> OMFJPLKFCMF, T OBEEJPGJPFD, [Optional] JobHandle CMCMGFGEBFC) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class PFEAIBIAMOP
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class ODACFHLEGMA
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2D0AFA0", Offset = "0x2D0A3A0", VA = "0x182D0AFA0")]
	public static NativeArray<T> AIBHOGDJGKI<T>(this NativeList<Entity> OJNDDLHKGHK, EntityManager NIHNJICAABF, Allocator EIFDLGAHDFC = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2D0AA00", Offset = "0x2D09E00", VA = "0x182D0AA00")]
	public static NativeArray<T> AIBHOGDJGKI<T>(this NativeArray<Entity> OJNDDLHKGHK, EntityManager NIHNJICAABF, Allocator EIFDLGAHDFC = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x69E9EF0", Offset = "0x69E92F0", VA = "0x1869E9EF0")]
	public static NativeArray<Entity> BJEGKHCGMAG(this NativeArray<Entity> OJNDDLHKGHK, EntityManager NIHNJICAABF, ComponentType HCLAMIDKCAN, Allocator EIFDLGAHDFC = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2D0B070", Offset = "0x2D0A470", VA = "0x182D0B070")]
	public static NativeArray<T> ECJPLGNLFFM<T>(this NativeArray<Entity> OJNDDLHKGHK, EntityManager NIHNJICAABF, Allocator EIFDLGAHDFC = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class BDDOKOHEBNN
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct BMKGDAJEMKD<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct HMLGGEKDAAO<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public BMKGDAJEMKD<TFrom> DENOKKMKOFP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Allocator EIFDLGAHDFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public NativeArray<TFrom> FBOFIAFKFOD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct FKMBPKGAEPK<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct LPKLLJELECG<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public FKMBPKGAEPK<TFrom> DENOKKMKOFP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Allocator EIFDLGAHDFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NativeArrayAsync<TFrom> FBOFIAFKFOD;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct JFCJMNGAFKC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct OECELKHNFEM<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public JFCJMNGAFKC<TFrom> DENOKKMKOFP;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Allocator EIFDLGAHDFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public NativeListAsync<TFrom> FBOFIAFKFOD;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class ECNOJOKPEDL
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class OGDEIJHGOCC
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct IDHDOJMDGAG : OKHCFDMGEPH<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> HCBLCJBGODH;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x69E9AF0", Offset = "0x69E8EF0", VA = "0x1869E9AF0")]
		[BurstCompatible]
		public Entity NMNBLHHKCHI([In] Entity OBEEJPGJPFD)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x69E9AF0", Offset = "0x69E8EF0", VA = "0x1869E9AF0", Slot = "4")]
		private Entity GHCFJIFGHHD([In] Entity OBEEJPGJPFD)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class IFHBILKMOII
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct MEKPGKLMDPF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Allocator EIFDLGAHDFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<Entity> CNAPDCPBDFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NativeArray<T> FBOFIAFKFOD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct KGDNOMNJLCP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Allocator EIFDLGAHDFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeList<Entity> CNAPDCPBDFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public NativeArray<T> FBOFIAFKFOD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct LKEJPNJABJK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Allocator EIFDLGAHDFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArrayAsync<Entity> CNAPDCPBDFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public NativeArrayAsync<T> FBOFIAFKFOD;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class HIMKOGKANNB
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class FJENFAKHAPC
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct AECIJPOOFEP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Allocator EIFDLGAHDFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public NativeArray<T> FBOFIAFKFOD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct GGBIAKKJIGC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Allocator EIFDLGAHDFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public NativeList<T> FBOFIAFKFOD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct MILFHFJPNEM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Allocator EIFDLGAHDFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public NativeArrayAsync<T> FBOFIAFKFOD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct EMCFPMBAJMH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Allocator EIFDLGAHDFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public NativeListAsync<T> FBOFIAFKFOD;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class LDLAFALMIAJ
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class KKAGCFIEOKL
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2C27570", Offset = "0x2C26970", VA = "0x182C27570")]
	public static NativeList<Entity> LNCLEGHNMFP<T>(this NativeArray<Entity> GAKNDOJBCLO, EntityManager NIHNJICAABF, Allocator EIFDLGAHDFC = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class NBFKDFOJEJO
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class KILGOLPPEEF
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public readonly struct HJMLLIMECBJ<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NativeArray<TSrc> ELFCOFFIPBP;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xAB7C70", Offset = "0xAB7070", VA = "0x180AB7C70")]
		public HJMLLIMECBJ(NativeArray<TSrc> ELFCOFFIPBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xAB7CE0", Offset = "0xAB70E0", VA = "0x180AB7CE0")]
		public PANGILJGACO<TSrc, TValue> DKNLPFIODBM<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(PANGILJGACO<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct PANGILJGACO<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> ELFCOFFIPBP;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xAB7C70", Offset = "0xAB7070", VA = "0x180AB7C70")]
		public PANGILJGACO(NativeArray<TSrc> ELFCOFFIPBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xAB7CE0", Offset = "0xAB70E0", VA = "0x180AB7CE0")]
		public KCHGPDPCEDB<TSrc, TValue, TSelector> OFPHNNEFFKJ<TSelector>() where TSelector : struct, OKHCFDMGEPH<TSrc, TValue>
		{
			return default(KCHGPDPCEDB<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct KCHGPDPCEDB<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, OKHCFDMGEPH<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> ELFCOFFIPBP;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xAB7C70", Offset = "0xAB7070", VA = "0x180AB7C70")]
		public KCHGPDPCEDB(NativeArray<TSrc> ELFCOFFIPBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4156DD0", Offset = "0x41561D0", VA = "0x184156DD0")]
		public INMDHOAFOJP<TSrc, TValue, TSelector> MHHLDJIAAKN()
		{
			return default(INMDHOAFOJP<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct DHCCKNMFLNK<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, OKHCFDMGEPH<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NativeArray<TSrc> ELFCOFFIPBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TSelector EFGMPOBNDGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int AGAGKNBDCIG;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TValue AKMKAIGAIOP
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x578BCE0", Offset = "0x578B0E0", VA = "0x18578BCE0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int KCOEJCJFNCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x9A0B80", Offset = "0x99FF80", VA = "0x1809A0B80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int LHAGCGMDNAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x578BDB0", Offset = "0x578B1B0", VA = "0x18578BDB0")]
		public DHCCKNMFLNK(NativeArray<TSrc> ELFCOFFIPBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x578BBD0", Offset = "0x578AFD0", VA = "0x18578BBD0")]
		public bool FEGGLLHEBGD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x578BBE0", Offset = "0x578AFE0", VA = "0x18578BBE0")]
		private TSrc JHBMAKCGGPD(int CBBBHLKBJGE)
		{
			return (TSrc)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x578BD20", Offset = "0x578B120", VA = "0x18578BD20")]
		private TValue OOMNECONMBM()
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct INMDHOAFOJP<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, OKHCFDMGEPH<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private DHCCKNMFLNK<TSrc, TValue, TSelector> EBGPMHNLEJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TValue DMAJKOBDEGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private int OCDCDAOIAHP;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public EBENJPLIHMM HCKDIKKEAIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x3E7C1A0", Offset = "0x3E7B5A0", VA = "0x183E7C1A0")]
			get
			{
				return default(EBENJPLIHMM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue LNEIHCKLKFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8517F0", Offset = "0x850BF0", VA = "0x1808517F0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, EBENJPLIHMM range) AKMKAIGAIOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x3E7C360", Offset = "0x3E7B760", VA = "0x183E7C360")]
			get
			{
				return default((TValue, EBENJPLIHMM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C430", Offset = "0x3E7B830", VA = "0x183E7C430")]
		public INMDHOAFOJP(NativeArray<TSrc> ELFCOFFIPBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x380D560", Offset = "0x380C960", VA = "0x18380D560")]
		public INMDHOAFOJP<TSrc, TValue, TSelector> GHLGIEPLNLN()
		{
			return default(INMDHOAFOJP<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C1E0", Offset = "0x3E7B5E0", VA = "0x183E7C1E0")]
		public bool FEGGLLHEBGD()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2C264D0", Offset = "0x2C258D0", VA = "0x182C264D0")]
	public static HJMLLIMECBJ<T> KJJOEDGHEED<T>(this NativeList<T> EGGGJKKPDIP) where T : struct
	{
		return default(HJMLLIMECBJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xAB7CE0", Offset = "0xAB70E0", VA = "0x180AB7CE0")]
	public static HJMLLIMECBJ<T> KJJOEDGHEED<T>(this NativeArray<T> ELFCOFFIPBP) where T : struct
	{
		return default(HJMLLIMECBJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class IHJICKGCFHH
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct EJEBAEKOOAE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly NativeArray<T>.ReadOnly ELFCOFFIPBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int OCDCDAOIAHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int MBIGLNKMAFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T DMAJKOBDEGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private T KCIAMDNJLEM;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public EBENJPLIHMM HCKDIKKEAIN
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x380D1A0", Offset = "0x380C5A0", VA = "0x18380D1A0")]
			get
			{
				return default(EBENJPLIHMM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T LNEIHCKLKFM
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x380D5C0", Offset = "0x380C9C0", VA = "0x18380D5C0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, EBENJPLIHMM) AKMKAIGAIOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x380D5E0", Offset = "0x380C9E0", VA = "0x18380D5E0")]
			get
			{
				return default((T, EBENJPLIHMM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x380D750", Offset = "0x380CB50", VA = "0x18380D750")]
		public EJEBAEKOOAE(NativeArray<T> ELFCOFFIPBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x380D580", Offset = "0x380C980", VA = "0x18380D580")]
		public EJEBAEKOOAE<T> GHLGIEPLNLN()
		{
			return default(EJEBAEKOOAE<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x380D1B0", Offset = "0x380C5B0", VA = "0x18380D1B0")]
		public bool FEGGLLHEBGD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x29C5D50", Offset = "0x29C5150", VA = "0x1829C5D50")]
		public AFFNJBIGNAG<T, TComparer> PHGLADFCKBJ<TComparer>([Optional] TComparer MOOKNHNFOEO) where TComparer : struct, IEqualityComparer<T>
		{
			return default(AFFNJBIGNAG<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct AFFNJBIGNAG<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly NativeArray<T>.ReadOnly ELFCOFFIPBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int OCDCDAOIAHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int MBIGLNKMAFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private T DMAJKOBDEGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private T KCIAMDNJLEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TComparer MOOKNHNFOEO;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public EBENJPLIHMM HCKDIKKEAIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x380D1A0", Offset = "0x380C5A0", VA = "0x18380D1A0")]
			get
			{
				return default(EBENJPLIHMM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T LNEIHCKLKFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x380D5C0", Offset = "0x380C9C0", VA = "0x18380D5C0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3CD1AA0", Offset = "0x3CD0EA0", VA = "0x183CD1AA0")]
		public AFFNJBIGNAG(NativeArray<T>.ReadOnly ELFCOFFIPBP, TComparer MOOKNHNFOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3CD18C0", Offset = "0x3CD0CC0", VA = "0x183CD18C0")]
		public bool FEGGLLHEBGD()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2B9BC50", Offset = "0x2B9B050", VA = "0x182B9BC50")]
	public static EJEBAEKOOAE<T> MHHLDJIAAKN<T>(this NativeArray<T> ELFCOFFIPBP) where T : struct
	{
		return default(EJEBAEKOOAE<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface NJMANEFKCIA
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class AOMEFIFCIPP
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct BFPKPJBEOCP<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class EJCDPMLFBKC : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public BFPKPJBEOCP<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xD2CB60", Offset = "0xD2BF60", VA = "0x180D2CB60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x380D160", Offset = "0x380C560", VA = "0x18380D160", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8527C0", Offset = "0x851BC0", VA = "0x1808527C0")]
		[DebuggerHidden]
		public EJCDPMLFBKC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x380CF40", Offset = "0x380C340", VA = "0x18380CF40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x380D110", Offset = "0x380C510", VA = "0x18380D110", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public readonly Action<Protobuf> HEOKACBHFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly MemoryStream GJNAAJIEDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly CodedInputStream HDEONJJFPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly Protobuf HHCALCCKOII;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int LHAGCGMDNAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9874E0", Offset = "0x9868E0", VA = "0x1809874E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4E90BC0", Offset = "0x4E8FFC0", VA = "0x184E90BC0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4E90C00", Offset = "0x4E90000", VA = "0x184E90C00", Slot = "4")]
	[IteratorStateMachine(typeof(BFPKPJBEOCP<>.EJCDPMLFBKC))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4E90D00", Offset = "0x4E90100", VA = "0x184E90D00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct OILMJMOALGO<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly byte[] OAAIHOHLDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public readonly Protobuf HHCALCCKOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MemoryStream GJNAAJIEDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CodedOutputStream OJMPKJAPPPP;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4698EB0", Offset = "0x46982B0", VA = "0x184698EB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct NEMFMNDEMDJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly MemoryStream GJNAAJIEDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly CodedInputStream HDEONJJFPEP;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x69E9EB0", Offset = "0x69E92B0", VA = "0x1869E9EB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct IHKKEFBAFCI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly byte[] OAAIHOHLDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly MemoryStream GJNAAJIEDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CodedOutputStream OJMPKJAPPPP;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x69E9B00", Offset = "0x69E8F00", VA = "0x1869E9B00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class KBDJCNMEIEB
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class FJGBKDLELCC
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Flags]
public enum NJMFJMJKOMG
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
internal static class KEEACDMAIPM
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class FKGLLJJNECC
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public FKGLLJJNECC()
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
