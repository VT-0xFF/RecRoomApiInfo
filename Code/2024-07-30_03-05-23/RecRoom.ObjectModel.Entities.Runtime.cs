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
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
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
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
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
		[Cpp2IlInjected.Address(RVA = "0x6AF9310", Offset = "0x6AF7910", VA = "0x186AF9310")]
		public static bool IsValid(this Entity entity)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CLHHIJGPKGG : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	FLMCKCNPEHP GBOMHHMBNAJ
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
public interface BIPDDLPFFFD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MDFDANMGKCK(Entity PIKIMHFFNIJ, object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CLFCEMJCMDN(Entity PIKIMHFFNIJ, object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MOLFLJABKAM(Entity PIKIMHFFNIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class KGIEBFGNHLK<TComponentData, TValue> : DHJNJAMPIKA<TValue>, IDisposable where TComponentData : struct, CLHHIJGPKGG
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class CGPJDDJFMEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private List<(object token, TValue value)> DEPHDEBCNCK;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int ABEHPFBIDOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x35D58A0", Offset = "0x35D3EA0", VA = "0x1835D58A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x538F4C0", Offset = "0x538DAC0", VA = "0x18538F4C0")]
		public bool GPLKPKCAPOI([Out] TValue DMNGPNKHPKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x538F790", Offset = "0x538DD90", VA = "0x18538F790")]
		public void LHEPNGLDBLI(object NJLOKHEKBBE, TValue DMNGPNKHPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x538F5D0", Offset = "0x538DBD0", VA = "0x18538F5D0")]
		public bool HHOKGKJNBNI(object NJLOKHEKBBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x538F690", Offset = "0x538DC90", VA = "0x18538F690")]
		public int LFCMAHLPLCN(object NJLOKHEKBBE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x538F880", Offset = "0x538DE80", VA = "0x18538F880")]
		public CGPJDDJFMEA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Stack<CGPJDDJFMEA> EPOKBLDJNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private KAGJGDFHLAL<FLMCKCNPEHP, CGPJDDJFMEA> KOCCLDHGIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EntityManager NKGJNOFNMMD;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4196210", Offset = "0x4194810", VA = "0x184196210")]
	public KGIEBFGNHLK(EntityManager NKGJNOFNMMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4195DE0", Offset = "0x41943E0", VA = "0x184195DE0", Slot = "4")]
	public void MDFDANMGKCK(Entity PIKIMHFFNIJ, object NJLOKHEKBBE, TValue DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4195A70", Offset = "0x4194070", VA = "0x184195A70", Slot = "5")]
	public bool CLFCEMJCMDN(Entity PIKIMHFFNIJ, object NJLOKHEKBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4195CA0", Offset = "0x41942A0", VA = "0x184195CA0", Slot = "6")]
	public bool GPLKPKCAPOI(Entity PIKIMHFFNIJ, [Out] TValue DMNGPNKHPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4195C80", Offset = "0x4194280", VA = "0x184195C80", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4196140", Offset = "0x4194740", VA = "0x184196140")]
	private void PNLHDKOIHHN(CGPJDDJFMEA IKNGOHBNKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4196070", Offset = "0x4194670", VA = "0x184196070")]
	private bool PINJIGKHPGH(Entity PIKIMHFFNIJ, [Out] FLMCKCNPEHP FPDGNDMPHII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4195F70", Offset = "0x4194570", VA = "0x184195F70")]
	private void NCAKECELGKA(Entity PIKIMHFFNIJ, FLMCKCNPEHP FPDGNDMPHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4195DC0", Offset = "0x41943C0", VA = "0x184195DC0")]
	private bool LKPIOCAODJM(FLMCKCNPEHP FPDGNDMPHII, [Out] CGPJDDJFMEA IKNGOHBNKPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4195940", Offset = "0x4193F40", VA = "0x184195940")]
	private CGPJDDJFMEA AJIAFDANPJP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DHJNJAMPIKA<TValue> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDFDANMGKCK(Entity PIKIMHFFNIJ, object NJLOKHEKBBE, TValue DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CLFCEMJCMDN(Entity PIKIMHFFNIJ, object NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GPLKPKCAPOI(Entity PIKIMHFFNIJ, [Out] TValue DMNGPNKHPKF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct FLMCKCNPEHP : DOGEODOABCA, IEquatable<FLMCKCNPEHP>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly FLMCKCNPEHP NGHCGFLIPPC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	[CreateProperty]
	public int MIMJDCDEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xAAF730", Offset = "0xAADD30", VA = "0x180AAF730", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xAAF690", Offset = "0xAADC90", VA = "0x180AAF690", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	[CreateProperty]
	public int HDIHKFJHDMF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x259FD50", Offset = "0x259E350", VA = "0x18259FD50", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5DD2910", Offset = "0x5DD0F10", VA = "0x185DD2910", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6AF9330", Offset = "0x6AF7930", VA = "0x186AF9330", Slot = "8")]
	public bool Equals(FLMCKCNPEHP BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6AF9380", Offset = "0x6AF7980", VA = "0x186AF9380", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class FDDKBFEJLCC<THasTokensTag> : BIPDDLPFFFD, IDisposable where THasTokensTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly PBGLEKOCCEM APPJEAMJBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Dictionary<Entity, FLMCKCNPEHP> DADDHIAPLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Stack<HashSet<object>> EPOKBLDJNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private KAGJGDFHLAL<FLMCKCNPEHP, HashSet<object>> KOCCLDHGIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EntityManager NKGJNOFNMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private EntityCommandBufferSystem PHHFKCLJAJF;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3C0DC10", Offset = "0x3C0C210", VA = "0x183C0DC10")]
	public FDDKBFEJLCC(EntityManager NKGJNOFNMMD, EntityCommandBufferSystem PHHFKCLJAJF, PBGLEKOCCEM OGNIICELBDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3C0CD70", Offset = "0x3C0B370", VA = "0x183C0CD70", Slot = "4")]
	public bool MDFDANMGKCK(Entity PIKIMHFFNIJ, object NJLOKHEKBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3C0B360", Offset = "0x3C09960", VA = "0x183C0B360", Slot = "5")]
	public bool CLFCEMJCMDN(Entity PIKIMHFFNIJ, object NJLOKHEKBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3C0D3E0", Offset = "0x3C0B9E0", VA = "0x183C0D3E0", Slot = "6")]
	public bool MOLFLJABKAM(Entity PIKIMHFFNIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3C0D320", Offset = "0x3C0B920", VA = "0x183C0D320", Slot = "8")]
	public bool MOLFLJABKAM(FLMCKCNPEHP FPDGNDMPHII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3C0BAA0", Offset = "0x3C0A0A0", VA = "0x183C0BAA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3C0DB30", Offset = "0x3C0C130", VA = "0x183C0DB30")]
	private void PNLHDKOIHHN(HashSet<object> IKNGOHBNKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3C0D980", Offset = "0x3C0BF80", VA = "0x183C0D980")]
	private bool PINJIGKHPGH(Entity PIKIMHFFNIJ, [Out] FLMCKCNPEHP FPDGNDMPHII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3C0BB20", Offset = "0x3C0A120", VA = "0x183C0BB20")]
	private bool GGLLLPBMIBJ(Entity PIKIMHFFNIJ, [Out] FLMCKCNPEHP FPDGNDMPHII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3C0BE60", Offset = "0x3C0A460", VA = "0x183C0BE60")]
	private void HOJMBDGJMFD(Entity PIKIMHFFNIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3C0C420", Offset = "0x3C0AA20", VA = "0x183C0C420")]
	private void MALLFAIEDDE(Entity PIKIMHFFNIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3C0CF20", Offset = "0x3C0B520", VA = "0x183C0CF20")]
	private void MECJLMOBGFD(Entity PIKIMHFFNIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3C0D550", Offset = "0x3C0BB50", VA = "0x183C0D550")]
	private void NCAKECELGKA(Entity PIKIMHFFNIJ, FLMCKCNPEHP FPDGNDMPHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3C0C300", Offset = "0x3C0A900", VA = "0x183C0C300")]
	private bool LPKBNNHEFND(FLMCKCNPEHP FPDGNDMPHII, [Out] HashSet<object> IKNGOHBNKPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3C0B2C0", Offset = "0x3C098C0", VA = "0x183C0B2C0")]
	private HashSet<object> AJIAFDANPJP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class MFCJICFCJCB
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct JFPPHGHGOPM : NCCKMFNBBFL<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6AF95A0", Offset = "0x6AF7BA0", VA = "0x186AF95A0")]
	public float PBGDIAGIJAA([In] float3 DMNGPNKHPKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6AF95A0", Offset = "0x6AF7BA0", VA = "0x186AF95A0", Slot = "4")]
	private float EMHPDNGODOJ([In] float3 DMNGPNKHPKF)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct KOKLOJHDPHN : NCCKMFNBBFL<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6AF96E0", Offset = "0x6AF7CE0", VA = "0x186AF96E0")]
	public float PBGDIAGIJAA([In] float3 DMNGPNKHPKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6AF96E0", Offset = "0x6AF7CE0", VA = "0x186AF96E0", Slot = "4")]
	private float EMHPDNGODOJ([In] float3 DMNGPNKHPKF)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct LJBHFKNCEJI : NCCKMFNBBFL<float3, float>
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1D455D0", Offset = "0x1D43BD0", VA = "0x181D455D0")]
	public float PBGDIAGIJAA([In] float3 DMNGPNKHPKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1D455D0", Offset = "0x1D43BD0", VA = "0x181D455D0", Slot = "4")]
	private float EMHPDNGODOJ([In] float3 DMNGPNKHPKF)
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct EEAGKKKNLFF : NCCKMFNBBFL<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x15E3110", Offset = "0x15E1710", VA = "0x1815E3110")]
	public int PBGDIAGIJAA([In] int3 DMNGPNKHPKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x15E3110", Offset = "0x15E1710", VA = "0x1815E3110", Slot = "4")]
	private int CMDFHCJPLFA([In] int3 DMNGPNKHPKF)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct HLEICPOEDJL : NCCKMFNBBFL<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6AF93D0", Offset = "0x6AF79D0", VA = "0x186AF93D0")]
	public int PBGDIAGIJAA([In] int3 DMNGPNKHPKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6AF93D0", Offset = "0x6AF79D0", VA = "0x186AF93D0", Slot = "4")]
	private int CMDFHCJPLFA([In] int3 DMNGPNKHPKF)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct DKIGHIMCKAB : NCCKMFNBBFL<int3, int>
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1799300", Offset = "0x1797900", VA = "0x181799300")]
	public int PBGDIAGIJAA([In] int3 DMNGPNKHPKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1799300", Offset = "0x1797900", VA = "0x181799300", Slot = "4")]
	private int CMDFHCJPLFA([In] int3 DMNGPNKHPKF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class CIAMIIJKDBJ : JNNEJNBGCCH
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x15163B0", Offset = "0x15149B0", VA = "0x1815163B0")]
	public CIAMIIJKDBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class LDGMEOIJIOA : SystemBase, FFGPMFGDLHJ
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6AF96F0", Offset = "0x6AF7CF0", VA = "0x186AF96F0")]
	public JobHandle ABKECMEOLFF(ReadOnlySpan<int> AAFOHAGAKEP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2C47ED0", Offset = "0x2C464D0", VA = "0x182C47ED0")]
	public void EPINFAJFAND<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2C48580", Offset = "0x2C46B80", VA = "0x182C48580")]
	public JobHandle EPINFAJFAND<T>(JobHandle FPDGNDMPHII)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6AF9760", Offset = "0x6AF7D60", VA = "0x186AF9760")]
	public JobHandle EPINFAJFAND(ReadOnlySpan<int> AAFOHAGAKEP, JobHandle FPDGNDMPHII)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2C47ED0", Offset = "0x2C464D0", VA = "0x182C47ED0")]
	public void CNGAKHNOJMF<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2C47DF0", Offset = "0x2C463F0", VA = "0x182C47DF0")]
	public JobHandle CNGAKHNOJMF<T>(JobHandle FPDGNDMPHII)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6AF97D0", Offset = "0x6AF7DD0", VA = "0x186AF97D0")]
	public ComponentDataFromEntity NMAPMLMKLBA(int ECLABNAHOPL, bool OLDPDAFLNJG = false)
	{
		return default(ComponentDataFromEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6AF9740", Offset = "0x6AF7D40", VA = "0x186AF9740")]
	public EntityExistenceLookupByEntity EOMHAPIHBIP()
	{
		return default(EntityExistenceLookupByEntity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6AF9890", Offset = "0x6AF7E90", VA = "0x186AF9890", Slot = "10")]
	public sealed override void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x15163B0", Offset = "0x15149B0", VA = "0x1815163B0")]
	protected LDGMEOIJIOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public abstract class IKIAIBONIEG : LDGMEOIJIOA
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6AF94E0", Offset = "0x6AF7AE0", VA = "0x186AF94E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x15163B0", Offset = "0x15149B0", VA = "0x1815163B0")]
	protected IKIAIBONIEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class ENABOMHLBOH
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class DAMJDPEJKHH : EntityCommandBufferSystem, FFGPMFGDLHJ
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x15163B0", Offset = "0x15149B0", VA = "0x1815163B0")]
	protected DAMJDPEJKHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NCCKMFNBBFL<TFrom, TTo>
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TTo PBGDIAGIJAA([In] TFrom DMNGPNKHPKF);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface JNDIOEEGOIO<T>
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FMHDMEPEHBH(T DMNGPNKHPKF);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[BurstCompile]
internal struct AHNPFDILOBA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[ReadOnly]
	public NativeArray<Entity> OKKKBJGONCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public EntityCommandBuffer BNGLLBLEECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public ComponentTypes DFCPALFHLFH;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6AF8C80", Offset = "0x6AF7280", VA = "0x186AF8C80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal struct CMPOJJIEELN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[ReadOnly]
	public NativeArray<Entity> OKKKBJGONCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public EntityCommandBuffer BNGLLBLEECM;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6AF9270", Offset = "0x6AF7870", VA = "0x186AF9270", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BurstCompile]
internal struct LIGFALDHPHB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public NativeArray<Entity> OKKKBJGONCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public EntityCommandBuffer BNGLLBLEECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public ComponentType JELHBOHDAGJ;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6AF98A0", Offset = "0x6AF7EA0", VA = "0x186AF98A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[BurstCompile]
internal struct CHLFDKGGLHN<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	[ReadOnly]
	public NativeArray<Entity> OKKKBJGONCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	public NativeArray<T> MMDLBEBNCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public EntityCommandBuffer BNGLLBLEECM;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5483320", Offset = "0x5481920", VA = "0x185483320", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal struct LLFBFNCNCBK<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public NativeArray<Entity> OKKKBJGONCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[ReadOnly]
	public NativeArray<T> EJHPODPBOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public EntityCommandBuffer BNGLLBLEECM;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal struct ECEJKHIPCCN<T> : IJob where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[ReadOnly]
	public NativeArray<Entity> OKKKBJGONCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[ReadOnly]
	public T DMNGPNKHPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public EntityCommandBuffer BNGLLBLEECM;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3856150", Offset = "0x3854750", VA = "0x183856150", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[BurstCompile]
internal struct CKEPBHHOBKB<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, NCCKMFNBBFL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[ReadOnly]
	public NativeArray<TFrom> IBAOBIOLDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[WriteOnly]
	public NativeArray<TTo> LHKHOFKFAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public TMap PEMICEIPPPL;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[BurstCompile]
internal struct IIFEPFNGBAI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[ReadOnly]
	public ComponentDataFromEntity BNDBIIFGMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<Entity> IBAOBIOLDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[WriteOnly]
	public NativeArray<byte> LHKHOFKFAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int APLAKNMIOGH;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6AF93E0", Offset = "0x6AF79E0", VA = "0x186AF93E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[BurstCompile]
internal struct PLMBLDHHNCI<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[ReadOnly]
	public ComponentDataFromEntity<T> JDNKBMBNIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeArray<Entity> IBAOBIOLDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[WriteOnly]
	public NativeList<T> HNNGOJJMIIJ;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[BurstCompile]
internal struct CEFGPHOMIBK<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct where TMap : struct, NCCKMFNBBFL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public NativeArray<TFrom> KBCAKDFDAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[WriteOnly]
	public NativeList<TTo> LHKHOFKFAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public TMap PEMICEIPPPL;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[BurstCompile]
internal struct NOCABCAOCBP<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[ReadOnly]
	public ComponentDataFromEntity<T> KHKGIDBHFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[ReadOnly]
	public NativeArray<Entity> BCCDEBDBKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<bool> GPEGNIBAJCK;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[BurstCompile]
internal struct OBIGNAOAEEG<T> : IJob where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[ReadOnly]
	public ComponentDataFromEntity<T> KHKGIDBHFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[ReadOnly]
	public NativeArray<Entity> BCCDEBDBKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public NativeArray<bool> GPEGNIBAJCK;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x46AEA40", Offset = "0x46AD040", VA = "0x1846AEA40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[BurstCompile]
internal struct KBKMAJDJOCK<T> : IJob where T : struct, IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	[ReadOnly]
	public NativeArray<T> IBAOBIOLDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeList<T> HNNGOJJMIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeParallelHashSet<T> JDGKLLKEGLH;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4169420", Offset = "0x4167A20", VA = "0x184169420", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[BurstCompile]
internal struct MKGLHKIAPEE<TFrom, TTo, TMap> : IJob where TFrom : struct where TTo : struct, IEquatable<TTo> where TMap : NCCKMFNBBFL<TFrom, TTo>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	[ReadOnly]
	public NativeArray<TFrom> IBAOBIOLDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeList<TFrom> HNNGOJJMIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NativeParallelHashSet<TTo> JDGKLLKEGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public TMap PEMICEIPPPL;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[BurstCompile]
internal struct DCGKHLPKLMO<T, TPredicate> : IJob where T : struct where TPredicate : struct, JNDIOEEGOIO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	public NativeArray<T> IBAOBIOLDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	public NativeArray<Entity> GPOICIKDLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public NativeList<Entity> EPEFNMDJDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public TPredicate PEMICEIPPPL;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
internal struct DJPGFIKKCBH<T, TPredicate> : IJob where T : struct where TPredicate : struct, JNDIOEEGOIO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<T> IBAOBIOLDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public NativeList<T> HNNGOJJMIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public TPredicate PEMICEIPPPL;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[BurstCompile]
internal struct IMGFNNLOPPP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	public ComponentDataFromEntity KHKGIDBHFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	public NativeArray<Entity> BCCDEBDBKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public NativeList<Entity> HIDHBMHAIMH;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6AF9510", Offset = "0x6AF7B10", VA = "0x186AF9510", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
internal struct CIFEFJPJPEJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[ReadOnly]
	public ComponentDataFromEntity KHKGIDBHFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[ReadOnly]
	public NativeArray<Entity> BCCDEBDBKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public NativeList<Entity> HIDHBMHAIMH;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6AF91E0", Offset = "0x6AF77E0", VA = "0x186AF91E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class EAFJKPGHIEE
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class LPCJOKAGLLI
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2C5D4E0", Offset = "0x2C5BAE0", VA = "0x182C5D4E0")]
	public static bool IPCBBLKHNPH<T>(this NativeArray<Entity> BCCDEBDBKNP, EntityManager NKGJNOFNMMD, Allocator KOIILCBLJPK = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class OCCJMBIKNAN
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class AFDFOCDEJIC<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		public AFDFOCDEJIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class FBAJKDIOAGM<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		public FBAJKDIOAGM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<Func<JobHandle, JobHandle>> LEALOECKHBD;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6AF9BE0", Offset = "0x6AF81E0", VA = "0x186AF9BE0")]
	public OCCJMBIKNAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class CKDEEAHJHCL
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class EBFNJALPALJ
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct DCNFGEHAKBM<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct OOEAMMINAML<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			internal DCNFGEHAKBM<TFrom> PPEEAFEPIIK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		internal Allocator KOIILCBLJPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		internal NativeArray<TFrom> MBEDFGIGBHI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct MBIINCMAIJI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct DLKFHKEPOLP<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			internal MBIINCMAIJI<TFrom> PPEEAFEPIIK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		internal Allocator KOIILCBLJPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		internal NativeList<TFrom> MBEDFGIGBHI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct FAHOOCHNAMC<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct CAJAOAOCPBA<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			internal FAHOOCHNAMC<TFrom> PPEEAFEPIIK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		internal Allocator KOIILCBLJPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		internal NativeArrayAsync<TFrom> MBEDFGIGBHI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct GGDPBMALOJL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct KGKJEAGGJBK<TKey> where TKey : struct, IEquatable<TKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			internal GGDPBMALOJL<TFrom> PPEEAFEPIIK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		internal Allocator KOIILCBLJPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		internal NativeListAsync<TFrom> MBEDFGIGBHI;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class LEDLGMLJFBP
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class FAGDOOBJGNI
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2B727B0", Offset = "0x2B70DB0", VA = "0x182B727B0")]
	public static NativeList<T> HFCLIEDKBAJ<T>(this NativeArray<T> AIIHNAJANNH, Allocator KOIILCBLJPK = Allocator.TempJob) where T : struct, IEquatable<T>
	{
		return default(NativeList<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class IFLCGLPPGBI
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class LNMCDLHLLNM
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2C59E20", Offset = "0x2C58420", VA = "0x182C59E20")]
	[MOIGMJCLNPG]
	public static JobHandle MEJKFDNJECE<T>(this EntityCommandBufferSystem PHHFKCLJAJF, NativeArrayAsync<Entity> OKKKBJGONCO, NativeArrayAsync<T> MMDLBEBNCGC, [Optional] JobHandle CDNHDCBEPMI) where T : struct, IComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2C59FA0", Offset = "0x2C585A0", VA = "0x182C59FA0")]
	[MOIGMJCLNPG]
	public static JobHandle MEJKFDNJECE<T>(this EntityCommandBufferSystem PHHFKCLJAJF, NativeArrayAsync<Entity> OKKKBJGONCO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2C59CF0", Offset = "0x2C582F0", VA = "0x182C59CF0")]
	[MOIGMJCLNPG]
	public static JobHandle MEJKFDNJECE<T>(this EntityCommandBufferSystem PHHFKCLJAJF, NativeArray<Entity> OKKKBJGONCO, [Optional] JobHandle CDNHDCBEPMI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6AF9920", Offset = "0x6AF7F20", VA = "0x186AF9920")]
	[MOIGMJCLNPG]
	public static JobHandle MEJKFDNJECE(this EntityCommandBufferSystem PHHFKCLJAJF, NativeArray<Entity> OKKKBJGONCO, ComponentTypes DFCPALFHLFH, [Optional] JobHandle CDNHDCBEPMI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6AF9A90", Offset = "0x6AF8090", VA = "0x186AF9A90")]
	[MOIGMJCLNPG]
	public static JobHandle MEJKFDNJECE(this EntityCommandBufferSystem PHHFKCLJAJF, EntityCommandBuffer BNGLLBLEECM, NativeArray<Entity> OKKKBJGONCO, ComponentTypes DFCPALFHLFH, [Optional] JobHandle CDNHDCBEPMI)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class OCNMJOFNDIM
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2CF4220", Offset = "0x2CF2820", VA = "0x182CF4220")]
	[MOIGMJCLNPG]
	public static JobHandle CIKGBHAABCO<T>(this EntityCommandBufferSystem PHHFKCLJAJF, EntityCommandBuffer BNGLLBLEECM, EntityQuery LJKEGIPFAAH, T DMNGPNKHPKF) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class CHJHLCKBCPF
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6AF8F50", Offset = "0x6AF7550", VA = "0x186AF8F50")]
	[MOIGMJCLNPG]
	public static JobHandle NFPLAPNBPGD(this EntityCommandBufferSystem PHHFKCLJAJF, NativeList<Entity> OKKKBJGONCO, [Optional] JobHandle CDNHDCBEPMI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6AF90E0", Offset = "0x6AF76E0", VA = "0x186AF90E0")]
	[MOIGMJCLNPG]
	public static JobHandle NFPLAPNBPGD(this EntityCommandBufferSystem PHHFKCLJAJF, NativeArrayAsync<Entity> OKKKBJGONCO)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class EANJFNGJOBI
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class CEPBCLJBADF
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x29A5040", Offset = "0x29A3640", VA = "0x1829A5040")]
	[MOIGMJCLNPG]
	public static JobHandle DJIEHBCEIGG<T>(this EntityCommandBufferSystem PHHFKCLJAJF, NativeArray<Entity> OKKKBJGONCO, NativeArray<T> MMDLBEBNCGC, JobHandle CDNHDCBEPMI) where T : struct, IComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class FOAGGFMAALG
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2B87DA0", Offset = "0x2B863A0", VA = "0x182B87DA0")]
	[MOIGMJCLNPG]
	public static JobHandle MIALBNAHOPN<T>(this EntityCommandBufferSystem PHHFKCLJAJF, NativeArray<Entity> OKKKBJGONCO, T DMNGPNKHPKF, [Optional] JobHandle CDNHDCBEPMI) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2B87E90", Offset = "0x2B86490", VA = "0x182B87E90")]
	[MOIGMJCLNPG]
	public static JobHandle MIALBNAHOPN<T>(this EntityCommandBufferSystem PHHFKCLJAJF, EntityCommandBuffer BNGLLBLEECM, NativeArray<Entity> OKKKBJGONCO, T DMNGPNKHPKF, [Optional] JobHandle CDNHDCBEPMI) where T : struct, ISharedComponentData
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class CHNHGHINPMM
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class BNIFPDCNFEB
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x293BCD0", Offset = "0x293A2D0", VA = "0x18293BCD0")]
	public static NativeArray<T> LDHGBCFBMHH<T>(this NativeList<Entity> AIIHNAJANNH, EntityManager NKGJNOFNMMD, Allocator KOIILCBLJPK = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x293B910", Offset = "0x2939F10", VA = "0x18293B910")]
	public static NativeArray<T> LDHGBCFBMHH<T>(this NativeArray<Entity> AIIHNAJANNH, EntityManager NKGJNOFNMMD, Allocator KOIILCBLJPK = Allocator.TempJob) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6AF8D70", Offset = "0x6AF7370", VA = "0x186AF8D70")]
	public static NativeArray<Entity> LGFCJANNDJF(this NativeArray<Entity> AIIHNAJANNH, EntityManager NKGJNOFNMMD, ComponentType JELHBOHDAGJ, Allocator KOIILCBLJPK = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x293B830", Offset = "0x2939E30", VA = "0x18293B830")]
	public static NativeArray<T> HEIPEDBLLCK<T>(this NativeArray<Entity> AIIHNAJANNH, EntityManager NKGJNOFNMMD, Allocator KOIILCBLJPK = Allocator.TempJob) where T : struct, ISharedComponentData
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class DBOHNLCEKAM
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct FPFKHNIHKNL<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public struct JPMLOEBGPDC<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public FPFKHNIHKNL<TFrom> MBEDFGIGBHI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public Allocator KOIILCBLJPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public NativeArray<TFrom> IBAOBIOLDKN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct NGOKEAOAFBJ<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct KEKPECCFNGH<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public NGOKEAOAFBJ<TFrom> MBEDFGIGBHI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Allocator KOIILCBLJPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NativeArrayAsync<TFrom> IBAOBIOLDKN;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct DDHFABCLJKI<TFrom> where TFrom : struct
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public struct KFDBDAFJHAK<TTo> where TTo : struct
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public DDHFABCLJKI<TFrom> MBEDFGIGBHI;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Allocator KOIILCBLJPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public NativeListAsync<TFrom> IBAOBIOLDKN;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class MLJFDJBMKCG
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class EIDGIENEIMA
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct AHGNFMICMAD : NCCKMFNBBFL<Entity, Entity>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ReadOnly]
		public NativeArray<EntityRemapUtility.EntityRemapInfo> MIDNJMMDBAI;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6AF8C70", Offset = "0x6AF7270", VA = "0x186AF8C70")]
		[BurstCompatible]
		public Entity PBGDIAGIJAA([In] Entity DMNGPNKHPKF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6AF8C70", Offset = "0x6AF7270", VA = "0x186AF8C70", Slot = "4")]
		private Entity OIHIBOAJIOL([In] Entity DMNGPNKHPKF)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class PFDMCKNGKLM
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct BJLLFBFALJO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Allocator KOIILCBLJPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public NativeArray<Entity> GPOICIKDLIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public NativeArray<T> IBAOBIOLDKN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct KMBBPJJJENM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Allocator KOIILCBLJPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public NativeList<Entity> GPOICIKDLIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NativeArray<T> IBAOBIOLDKN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public struct OIDPBPKDIIO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Allocator KOIILCBLJPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NativeArrayAsync<Entity> GPOICIKDLIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NativeArrayAsync<T> IBAOBIOLDKN;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class FLGKJPMANNG
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class GAJFKDKIMIA
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct LMKJCPONGKL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Allocator KOIILCBLJPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public NativeArray<T> IBAOBIOLDKN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct BHCIOIHBAAI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Allocator KOIILCBLJPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public NativeList<T> IBAOBIOLDKN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct GIIODOAIDGM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Allocator KOIILCBLJPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public NativeArrayAsync<T> IBAOBIOLDKN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct AMNEHKKFNFC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Allocator KOIILCBLJPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public NativeListAsync<T> IBAOBIOLDKN;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class CNGADGMLPDA
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class EAAEMBJCPNK
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E820", Offset = "0x2A2CE20", VA = "0x182A2E820")]
	public static NativeList<Entity> OEGNGBDMKKB<T>(this NativeArray<Entity> BCCDEBDBKNP, EntityManager NKGJNOFNMMD, Allocator KOIILCBLJPK = Allocator.TempJob)
	{
		return default(NativeList<Entity>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class HLADGDPJBAC
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class NHFGJMBKMEA
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public readonly struct IMAMGJJHIBG<TSrc> where TSrc : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly NativeArray<TSrc> FAJBEEIFFCK;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1FFBB40", Offset = "0x1FFA140", VA = "0x181FFBB40")]
		public IMAMGJJHIBG(NativeArray<TSrc> FAJBEEIFFCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0")]
		public KGNBKKBOAGI<TSrc, TValue> APPMNHINFML<TValue>() where TValue : struct, IEquatable<TValue>
		{
			return default(KGNBKKBOAGI<TSrc, TValue>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public readonly struct KGNBKKBOAGI<TSrc, TValue> where TSrc : struct where TValue : struct, IEquatable<TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NativeArray<TSrc> FAJBEEIFFCK;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1FFBB40", Offset = "0x1FFA140", VA = "0x181FFBB40")]
		public KGNBKKBOAGI(NativeArray<TSrc> FAJBEEIFFCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0")]
		public FBDJDDKFBGM<TSrc, TValue, TSelector> KCIOCCDNMKF<TSelector>() where TSelector : struct, NCCKMFNBBFL<TSrc, TValue>
		{
			return default(FBDJDDKFBGM<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public readonly struct FBDJDDKFBGM<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, NCCKMFNBBFL<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NativeArray<TSrc> FAJBEEIFFCK;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1FFBB40", Offset = "0x1FFA140", VA = "0x181FFBB40")]
		public FBDJDDKFBGM(NativeArray<TSrc> FAJBEEIFFCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3BFB5A0", Offset = "0x3BF9BA0", VA = "0x183BFB5A0")]
		public FNDCBELPKAE<TSrc, TValue, TSelector> CHMELNIFGOH()
		{
			return default(FNDCBELPKAE<TSrc, TValue, TSelector>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct LAENHFBFIFF<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct where TSelector : struct, NCCKMFNBBFL<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly NativeArray<TSrc> FAJBEEIFFCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TSelector JJPJJLMIMIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int PDMMEDBMFPP;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public TValue FOBIFFPGMIL
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x42B7500", Offset = "0x42B5B00", VA = "0x1842B7500")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int MIMJDCDEIKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8FBA90", Offset = "0x8FA090", VA = "0x1808FBA90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int LBEGGACHKEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2025160", Offset = "0x2023760", VA = "0x182025160")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x42B7640", Offset = "0x42B5C40", VA = "0x1842B7640")]
		public LAENHFBFIFF(NativeArray<TSrc> FAJBEEIFFCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x42B7460", Offset = "0x42B5A60", VA = "0x1842B7460")]
		public bool HNHNGOHHPDK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x42B7540", Offset = "0x42B5B40", VA = "0x1842B7540")]
		private TSrc MDPJBLEKEKH(int BILDLIKNGJF)
		{
			return (TSrc)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x42B7470", Offset = "0x42B5A70", VA = "0x1842B7470")]
		private TValue IMOLPICHMGB()
		{
			return (TValue)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct FNDCBELPKAE<TSrc, TValue, TSelector> where TSrc : struct where TValue : struct, IEquatable<TValue> where TSelector : struct, NCCKMFNBBFL<TSrc, TValue>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private LAENHFBFIFF<TSrc, TValue, TSelector> JGMPEELHOOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TValue EIIIPEJDMHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private int CMKHMGALFJE;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public BEGHBKAAGJH PGMDIGJHHMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x3C3A860", Offset = "0x3C38E60", VA = "0x183C3A860")]
			get
			{
				return default(BEGHBKAAGJH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TValue JPINMKLIOME
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x86C7E0", Offset = "0x86ADE0", VA = "0x18086C7E0")]
			get
			{
				return (TValue)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public (TValue value, BEGHBKAAGJH range) FOBIFFPGMIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x3C3AA20", Offset = "0x3C39020", VA = "0x183C3AA20")]
			get
			{
				return default((TValue, BEGHBKAAGJH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3C3AB00", Offset = "0x3C39100", VA = "0x183C3AB00")]
		public FNDCBELPKAE(NativeArray<TSrc> FAJBEEIFFCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3C290E0", Offset = "0x3C276E0", VA = "0x183C290E0")]
		public FNDCBELPKAE<TSrc, TValue, TSelector> GGGADAADMEJ()
		{
			return default(FNDCBELPKAE<TSrc, TValue, TSelector>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3C3A8A0", Offset = "0x3C38EA0", VA = "0x183C3A8A0")]
		public bool HNHNGOHHPDK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2CD4B70", Offset = "0x2CD3170", VA = "0x182CD4B70")]
	public static IMAMGJJHIBG<T> HPHFAFKBKDG<T>(this NativeList<T> DEPHDEBCNCK) where T : struct
	{
		return default(IMAMGJJHIBG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FB6C0", VA = "0x1809FD0C0")]
	public static IMAMGJJHIBG<T> HPHFAFKBKDG<T>(this NativeArray<T> FAJBEEIFFCK) where T : struct
	{
		return default(IMAMGJJHIBG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class JDFIGOAGIDD
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct HOEBBILNCFK<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly NativeArray<T>.ReadOnly FAJBEEIFFCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int CMKHMGALFJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int MBOAMBPHGJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private T EIIIPEJDMHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private T IPDPHOBFLHD;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public BEGHBKAAGJH PGMDIGJHHMK
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x3DB45C0", Offset = "0x3DB2BC0", VA = "0x183DB45C0")]
			get
			{
				return default(BEGHBKAAGJH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T JPINMKLIOME
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x38E8120", Offset = "0x38E6720", VA = "0x1838E8120")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public (T, BEGHBKAAGJH) FOBIFFPGMIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x3DB49E0", Offset = "0x3DB2FE0", VA = "0x183DB49E0")]
			get
			{
				return default((T, BEGHBKAAGJH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3DB4BD0", Offset = "0x3DB31D0", VA = "0x183DB4BD0")]
		public HOEBBILNCFK(NativeArray<T> FAJBEEIFFCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3DB45D0", Offset = "0x3DB2BD0", VA = "0x183DB45D0")]
		public HOEBBILNCFK<T> GGGADAADMEJ()
		{
			return default(HOEBBILNCFK<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3DB47F0", Offset = "0x3DB2DF0", VA = "0x183DB47F0")]
		public bool HNHNGOHHPDK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x2A19DF0", Offset = "0x2A183F0", VA = "0x182A19DF0")]
		public DCKBLDOIGGJ<T, TComparer> MBCPOEGCMJN<TComparer>([Optional] TComparer PHFMENIGPGN) where TComparer : struct, IEqualityComparer<T>
		{
			return default(DCKBLDOIGGJ<T, TComparer>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct DCKBLDOIGGJ<T, TComparer> where T : struct where TComparer : struct, IEqualityComparer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly NativeArray<T>.ReadOnly FAJBEEIFFCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int CMKHMGALFJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int MBOAMBPHGJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private T EIIIPEJDMHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private T IPDPHOBFLHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private TComparer PHFMENIGPGN;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public BEGHBKAAGJH PGMDIGJHHMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x3DB45C0", Offset = "0x3DB2BC0", VA = "0x183DB45C0")]
			get
			{
				return default(BEGHBKAAGJH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T JPINMKLIOME
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x38E8120", Offset = "0x38E6720", VA = "0x1838E8120")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x58B5490", Offset = "0x58B3A90", VA = "0x1858B5490")]
		public DCKBLDOIGGJ(NativeArray<T>.ReadOnly FAJBEEIFFCK, TComparer PHFMENIGPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x58B52A0", Offset = "0x58B38A0", VA = "0x1858B52A0")]
		public bool HNHNGOHHPDK()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2BF4950", Offset = "0x2BF2F50", VA = "0x182BF4950")]
	public static HOEBBILNCFK<T> CHMELNIFGOH<T>(this NativeArray<T> FAJBEEIFFCK) where T : struct
	{
		return default(HOEBBILNCFK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public interface KBGPKHLNJPJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public static class MFFGMFFHIBG
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct KFGHAEGMMPD<Protobuf> : IEnumerable<(int, Protobuf)>, IEnumerable, IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class MIGDNHDJAGB : IEnumerator<(int, Protobuf)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private (int index, Protobuf element) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public KFGHAEGMMPD<Protobuf> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private (int, Protobuf) System.Collections.Generic.IEnumerator<(System.Int32index,Protobufelement)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xC70640", Offset = "0xC6EC40", VA = "0x180C70640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C40040", Offset = "0x3C3E640", VA = "0x183C40040", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x871800", Offset = "0x86FE00", VA = "0x180871800")]
		[DebuggerHidden]
		public MIGDNHDJAGB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x44CC4C0", Offset = "0x44CAAC0", VA = "0x1844CC4C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x44CC6A0", Offset = "0x44CACA0", VA = "0x1844CC6A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly Action<Protobuf> NGDKGOJICLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly MemoryStream GILGOCDJPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly CodedInputStream DLCKJGOPALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Protobuf NJJGFJOBMOG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly int LBEGGACHKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8F0D30", Offset = "0x8EF330", VA = "0x1808F0D30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4188A00", Offset = "0x4187000", VA = "0x184188A00", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4188A40", Offset = "0x4187040", VA = "0x184188A40", Slot = "4")]
	[IteratorStateMachine(typeof(KFGHAEGMMPD<>.MIGDNHDJAGB))]
	public IEnumerator<(int, Protobuf)> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4188B40", Offset = "0x4187140", VA = "0x184188B40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct MJLEDEPHEIP<Protobuf> : IDisposable where Protobuf : IMessage, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly byte[] JDFOAHNNFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly Protobuf NJJGFJOBMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly MemoryStream GILGOCDJPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly CodedOutputStream CPBBHGDEALP;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x44D1710", Offset = "0x44CFD10", VA = "0x1844D1710", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct AGDPPPMADAK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MemoryStream GILGOCDJPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CodedInputStream DLCKJGOPALO;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6AF8C30", Offset = "0x6AF7230", VA = "0x186AF8C30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct KOJCJBOGIHD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly byte[] JDFOAHNNFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MemoryStream GILGOCDJPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CodedOutputStream CPBBHGDEALP;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6AF95B0", Offset = "0x6AF7BB0", VA = "0x186AF95B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class NOOHLCAEDKF
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public static class EOAHHANGBND
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[Flags]
public enum HJPDFODMAKE
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
internal static class JPGCFLINLDA
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class DGOGLIDKJLN
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public DGOGLIDKJLN()
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
