using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Scripting;

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
namespace _AssemblyRegistry.RecRoom_ObjectModel_ComponentData_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : MFFEOJCHKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6AEE190", Offset = "0x6AEC790", VA = "0x186AEE190", Slot = "8")]
		public override void JHLKEJPJBFN(FONNCKCINIP registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6AEDD20", Offset = "0x6AEC320", VA = "0x186AEDD20", Slot = "7")]
		public override void BFLODHPEMNC(IACCKKKBEBJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6AEE590", Offset = "0x6AECB90", VA = "0x186AEE590")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct LCAKHLFGMLH : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildBuffer>, GEIPLJHPHML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB100", Offset = "0x6AE9700", VA = "0x186AEB100", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8DA780", Offset = "0x8D8D80", VA = "0x1808DA780")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, GEIPLJHPHML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct PAKFBKMCLGK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct GAJIEAPOAEM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity JFIEHCHOPID;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct FDPPDFPKLOP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity JFIEHCHOPID;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct LMOPMEIHOAA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<AIOHKDLJECP> CEDPOANLPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<Entity> DGOKLHBPMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JobHandle KDEMNIPNNKE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool ANHMLBKHNDM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6AED150", Offset = "0x6AEB750", VA = "0x186AED150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int ABEHPFBIDOI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6AECF80", Offset = "0x6AEB580", VA = "0x186AECF80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4D2FE40", Offset = "0x4D2E440", VA = "0x184D2FE40")]
	public LMOPMEIHOAA(NativeList<AIOHKDLJECP> CEDPOANLPEJ, NativeList<Entity> DGOKLHBPMCK, JobHandle KDEMNIPNNKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6AECFD0", Offset = "0x6AEB5D0", VA = "0x186AECFD0")]
	public (Entity, NativeSlice<Entity>) CCNFCFDNEJD(int BILDLIKNGJF)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6AED0F0", Offset = "0x6AEB6F0", VA = "0x186AED0F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct AIOHKDLJECP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Entity OPJBDKMKMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int GCMGLJCEDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int JOCLJBACIHN;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PFJBPOOKBAD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPLCDIOCNBJ(bool GGCNMOLDPEF);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct BKDKGDOMJML : IEquatable<BKDKGDOMJML>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool IMOOECBELGN(int FFHBHOMFFND);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool HEOKPKAHFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool MNJBMNIPIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool JAAAKLLADDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool GADGIMPFDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly IMOOECBELGN OAHEPPNGOKM;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6AEB510", Offset = "0x6AE9B10", VA = "0x186AEB510")]
	public BKDKGDOMJML(DGLLELHCEGN MCGGLIKAALP, IMOOECBELGN OAHEPPNGOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6AEB4E0", Offset = "0x6AE9AE0", VA = "0x186AEB4E0")]
	public BKDKGDOMJML(bool HEOKPKAHFEJ, bool MNJBMNIPIAH, bool JAAAKLLADDN, bool GADGIMPFDGD, IMOOECBELGN OAHEPPNGOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6AEB280", Offset = "0x6AE9880", VA = "0x186AEB280")]
	public bool BBKLPGMMMGD(int FFHBHOMFFND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6AEB2B0", Offset = "0x6AE98B0", VA = "0x186AEB2B0")]
	public bool EGDKFEIJEKF(int FFHBHOMFFND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6AEB490", Offset = "0x6AE9A90", VA = "0x186AEB490")]
	public bool PCKNMPGEMNO(int FFHBHOMFFND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6AEB460", Offset = "0x6AE9A60", VA = "0x186AEB460")]
	public bool LGPPLKLHHPD(int FFHBHOMFFND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6AEB2E0", Offset = "0x6AE98E0", VA = "0x186AEB2E0", Slot = "4")]
	public bool Equals(BKDKGDOMJML BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6AEB310", Offset = "0x6AE9910", VA = "0x186AEB310", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6AEB3C0", Offset = "0x6AE99C0", VA = "0x186AEB3C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6AEB4C0", Offset = "0x6AE9AC0", VA = "0x186AEB4C0")]
	private bool PNAFEFIMMOA(int FFHBHOMFFND)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct EEKEHJNJIKP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct PJFKJDMAKCE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct FNDPEBBJFID : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[InternalBufferCapacity(17)]
public struct ACGMKHFKMLA : IBufferElementData, IEquatable<ACGMKHFKMLA>, GEIPLJHPHML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity BCMCEBEOPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int GKEEBAIMJKN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity JMCICOALBMI
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6AEAFC0", Offset = "0x6AE95C0", VA = "0x186AEAFC0", Slot = "4")]
	public bool Equals(ACGMKHFKMLA BHFGHGMPKOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct DBNCHMABPIC : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct PCHDANEMMGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly LNOJLONKEPE HIEFECMEILH;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x21B0DF0", Offset = "0x21AF3F0", VA = "0x1821B0DF0")]
		public PCHDANEMMGP(LNOJLONKEPE DMPAOFMHJID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6AED6D0", Offset = "0x6AEBCD0", VA = "0x186AED6D0")]
		public bool DFEGOJKNKPJ(DBNCHMABPIC JHCEFLHBODH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6AED6E0", Offset = "0x6AEBCE0", VA = "0x186AED6E0")]
		public bool LIHHLADDOCD(DBNCHMABPIC JHCEFLHBODH, LNOJLONKEPE PGEDICAAEFM)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly LNOJLONKEPE GKJKFANGPND;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x21B0DF0", Offset = "0x21AF3F0", VA = "0x1821B0DF0")]
	public DBNCHMABPIC(LNOJLONKEPE GKJKFANGPND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6AEB8F0", Offset = "0x6AE9EF0", VA = "0x186AEB8F0")]
	public DBNCHMABPIC KCIOCCDNMKF(LNOJLONKEPE BFGAMAEJEAL)
	{
		return default(DBNCHMABPIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6AEB8E0", Offset = "0x6AE9EE0", VA = "0x186AEB8E0")]
	public DBNCHMABPIC IPNIIGPFGDF(LNOJLONKEPE LADOFOAENJB)
	{
		return default(DBNCHMABPIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6AEB900", Offset = "0x6AE9F00", VA = "0x186AEB900", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[Flags]
public enum LNOJLONKEPE : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	HasShapeChildren = 1,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	HasEmbodiedChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	IsRootObject = 4,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	HasColliders = 8,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	TestEmbodiment = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	All = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[Flags]
public enum IDLPGGGFJCE : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[LKODCDHCOEB]
public struct EKADLMJAJDO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public IDLPGGGFJCE GKJKFANGPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public bool DKBMFJPIIFO;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool BKPADFGHFEI
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6AEBBD0", Offset = "0x6AEA1D0", VA = "0x186AEBBD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6AEBC20", Offset = "0x6AEA220", VA = "0x186AEBC20")]
	private EKADLMJAJDO(IDLPGGGFJCE GKJKFANGPND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6AEBC00", Offset = "0x6AEA200", VA = "0x186AEBC00")]
	public EKADLMJAJDO KCIOCCDNMKF(IDLPGGGFJCE BFGAMAEJEAL)
	{
		return default(EKADLMJAJDO);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6AEBBE0", Offset = "0x6AEA1E0", VA = "0x186AEBBE0")]
	public EKADLMJAJDO IPNIIGPFGDF(IDLPGGGFJCE LADOFOAENJB)
	{
		return default(EKADLMJAJDO);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct NKIPFKLMILK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct HNGLINGHCEK : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Entity MHHFNEAAJJB;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildBuffer>, GEIPLJHPHML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB100", Offset = "0x6AE9700", VA = "0x186AEB100", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8DA780", Offset = "0x8D8D80", VA = "0x1808DA780")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[LKODCDHCOEB]
public struct MFCDJIOOGOP : ISystemStateBufferElementData, IBufferElementData, GEIPLJHPHML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public Entity PIKIMHFFNIJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Entity ACDFDGEINEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct DFFEBDIPCJB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Entity GFGBOCMBCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Entity GPNBOAJAHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity EGDEDNLDDBK;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct JEDIKNFIHIF<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly bool IPGIKMPLLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public uint GILIFDHBDDA;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool LNFHJMDMHCD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.TypeVersion(2)]
public struct DCFODCCDGOE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public uint FPAAPMOCKDK;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6AEB960", Offset = "0x6AE9F60", VA = "0x186AEB960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct DMLPPPNJEEA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[LKODCDHCOEB]
public struct EFPDBICDGOC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public int JLIFBAGCKJG;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct CEGMGDHKDIA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int BHJAKHNNONP;
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct HCLAIKMPCHB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public GCHandle PPFJNDALMNH;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct MLEENOBLGFB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public int BHJAKHNNONP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct POHLKNHFHEE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct DJBNNKDHKFM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public int BHJAKHNNONP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct MDLBKCJFECC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct GHEIGMLALGD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct OBANDDPAEEL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct AMDGOCLNOKG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public CollisionDetectionMode ODGJIOBOIPA;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[IGHBAADFIGA]
public struct CFPGELDJIAL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public JCHEPGBFHGG CDPMHJDANAE;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly CFPGELDJIAL ABMFDACMOIG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct KODCBEEKPDO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct JFBGFIPLIID : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct DADEAPPEOAG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[InternalBufferCapacity(0)]
public struct EPICCBIGMJL : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Entity BCMCEBEOPPL;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct EPEMKGOCPFJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Entity PPEEAFEPIIK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct MNNGGEEDAKK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct LDBAPLPICFL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Entity OPJBDKMKMOF;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct GFJPJPDDKFG : CLHHIJGPKGG, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public FLMCKCNPEHP GBOMHHMBNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(FLMCKCNPEHP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct DPIDMNCFFAF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float3 JMBLMEINHPO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct IEDKEGLGEOK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[IGHBAADFIGA]
public struct CDLGJCHEAIN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public float3x3 EDBKCELFBOB;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly CDLGJCHEAIN ABMFDACMOIG;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[IGHBAADFIGA]
public struct OOKDMBCAKOE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public float3x3 EDBKCELFBOB;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly OOKDMBCAKOE ABMFDACMOIG;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct PFOELPEGDMG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public float3 CCCCGIKEICA;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct ONFMMPCOEOD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public float3 NBCMFMIMMHJ;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[IGHBAADFIGA]
public struct ONOMNOBMGJA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float BLIAGABNCKB;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly ONOMNOBMGJA ABMFDACMOIG;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[IGHBAADFIGA]
public struct AAEMKHPCKKE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public float BNMOOCAIDGA;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly AAEMKHPCKKE ABMFDACMOIG;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct BJJIKBJHKEH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public float3 ALIDCNJFNNP;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct HLEEDIHOKJN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public JLMNFBGGGIJ DDPEKAFJBCD;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct BEHBBNGDLIF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public JLMNFBGGGIJ DKEANOJMEDK;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[LKODCDHCOEB]
public struct NBLFNIOMAIO : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Entity PIKIMHFFNIJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct OICFLOHCOCH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct FHFGJIOIEPE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct FINOFIACFJF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public RigidbodyConstraints OMMLCMDJCGO;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[IGHBAADFIGA]
public struct CLNKNKLBAAJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public float ODBDGLOKCLK;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly CLNKNKLBAAJ ABMFDACMOIG;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct MLGENNOCJPE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float PEIIDLLEFGM;
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class HIIKEHCPEFF : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct KNFKABIBENH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public object OOONIGNCAFA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public GameObject FNAHDAKHMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public object EKPJLIPGAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public object HKPGFIIBDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public KNFKABIBENH OOONIGNCAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public Delegate FEHHBBKFKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Delegate DMEKKMEFEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public GKFBNGBAJIH<Delegate> LOCDINNHAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public GKFBNGBAJIH<Delegate> OHFCCMELDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public GKFBNGBAJIH<Delegate> FPFHKPNJBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public GKFBNGBAJIH<Delegate> OAPFEINIAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public GKFBNGBAJIH<Delegate> EICGDLHBLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public GKFBNGBAJIH<Delegate> HFFIHELKPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public GKFBNGBAJIH<Delegate> MENBACCFBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GKFBNGBAJIH<Delegate> KFMAAHGIFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public GKFBNGBAJIH<Delegate> CFELMFCBCBJ;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC2A0", Offset = "0x6AEA8A0", VA = "0x186AEC2A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public HIIKEHCPEFF()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct NNPNHAMPGJC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct PIAGBEINGFN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int HDOACAEGJHA;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xE29C50", Offset = "0xE28250", VA = "0x180E29C50")]
	public static PIAGBEINGFN HDKGBCFDEBL(int DMNGPNKHPKF)
	{
		return default(PIAGBEINGFN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class NBMCGPGJFKD : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public Rigidbody OBCIJMKFLAO;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6AED320", Offset = "0x6AEB920", VA = "0x186AED320", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public NBMCGPGJFKD()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct DNPBNHBMPAH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct GEAPNGBGFOH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 CDGJDANICCD;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct NMPMDLLNHII : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float3 NPPDGHLPBPO;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[IGHBAADFIGA]
public struct DHJEOEAKKEA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float LKELGKDBFGG;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly DHJEOEAKKEA ABMFDACMOIG;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class IFPHMGKKACA : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public object NKMKADCMABO;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC4D0", Offset = "0x6AEAAD0", VA = "0x186AEC4D0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public IFPHMGKKACA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class MGKLKJLBBOM : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public object AKOKKPCNOKC;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6AED2B0", Offset = "0x6AEB8B0", VA = "0x186AED2B0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public MGKLKJLBBOM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct DDABFELBENP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct OBHMALLIABG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct HOJPJKCIJPH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct FLDFIBBAMDC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct NDEKNFEBEMJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct OGDMMLOBDML : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public FixedString32Bytes GJEDHMJMNJA;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[LKODCDHCOEB]
public struct MMKMGMKNOGF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Entity KOGJGCFCINN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8DA780", Offset = "0x8D8D80", VA = "0x1808DA780")]
	public static MMKMGMKNOGF HDKGBCFDEBL(Entity DMNGPNKHPKF)
	{
		return default(MMKMGMKNOGF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal struct GGIDEMAAGHF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Entity PIKIMHFFNIJ;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8DA780", Offset = "0x8D8D80", VA = "0x1808DA780")]
	public static GGIDEMAAGHF HDKGBCFDEBL(Entity PIKIMHFFNIJ)
	{
		return default(GGIDEMAAGHF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct OCPOOMPDFOF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Entity OOJHEOGEMPF;
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct MLHIDLFHAPH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Entity OOJHEOGEMPF;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal struct FLGAOIANHGB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Entity HDNEFHLEMPP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8DA780", Offset = "0x8D8D80", VA = "0x1808DA780")]
	public static FLGAOIANHGB HDKGBCFDEBL(Entity PIKIMHFFNIJ)
	{
		return default(FLGAOIANHGB);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal struct EHNBGEOALPL : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct PKKGGKJPOJP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct GCGEFOCHGJA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public uint CICFELNCFMD;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[LKODCDHCOEB]
internal struct LLNPONEPEMO : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public Entity DDHOEODJFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int PDMMEDBMFPP;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal struct EKGMMJHPJFN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public Entity BOELICHHFGP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct PNKLLPIAGLD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct BNLNJPAEPAJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public uint GILIFDHBDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int HBEGKOCNNMG;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xC84530", Offset = "0xC82B30", VA = "0x180C84530")]
	public BNLNJPAEPAJ(uint CMNLIDJJPJJ, int GGLOENBLFCP)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct PFNGGIMJBCN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct FHJFGLGNGML : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct LNHPFNHINCA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct BANIIJLGMMA : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct KIIKABHIDKI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct ONGOONNCAKN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct KAIENOPDFIF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct IPLCGOLGLCP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal struct JFHKPBCIONH : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct JCHGOJCECGG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct PKCAKMDOEKE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct FMNEDEMMHCF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal struct BDICJAIABCA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal struct KOKFPKEINNF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct EECCMGCHLJK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct PDAMMCMNGBC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct BMBBIFODDHK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct IPHAJOLMPNJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct HAJFIBJPAAG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct CMGHLLNLNMA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct PHOBPHLLOPO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct OOFODEMBEAL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct GNEAEHCHOCD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct MBHMCICNMDE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal struct OODDGENGFCD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct GBAPELNPHJO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct OJDGKFBLMPK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct BFIMJMGCOCP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[LKODCDHCOEB]
public struct AGIMCPKAIGF : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public FixedString32Bytes CMJCNJNCICI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct KENKGILDAFA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct DGAMAAOLMJK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal struct DLNPMGIAPGO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal struct BOEJCKADLNL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal struct DAADDKFJMDL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct DLKJEAIKPFD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct LJODEPAEPOG : IComponentData, IComparable<LJODEPAEPOG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public int NHABFHHOPHJ;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1ADD5E0", Offset = "0x1ADBBE0", VA = "0x181ADD5E0", Slot = "4")]
	public int CompareTo(LJODEPAEPOG BHFGHGMPKOJ)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct HPKEECJGLFK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct NIDPKKODAGN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public quaternion GLKHDAMNPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float3 MCPNOOFMAHG;
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct KJEOFKFNIHH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float HEMHBGEGGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float AKBNLMGEKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float PNNNBNEICGJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct LAONJEBOCBD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct JGOEJHOOAAA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct OGHPCFHLAFA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct BNELCBNDEOB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public int BHJAKHNNONP;
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[LKODCDHCOEB]
public struct KGGJDJCPDNG : ISystemStateBufferElementData, IBufferElementData, GEIPLJHPHML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Entity NJJGFJOBMOG;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Entity ACDFDGEINEH
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[IGHBAADFIGA]
public struct BDDKKMIOMPE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public float4x4 CFMHMOMCMFB;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public static readonly BDDKKMIOMPE ABMFDACMOIG;
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[IGHBAADFIGA]
public struct LCPBLPBILBK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public float4x4 GCKKDKDKEHM;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public static readonly LCPBLPBILBK ABMFDACMOIG;
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public struct LLGALEPEHHO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private int DPIGFCDFGHN;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int PDMMEDBMFPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6AECF70", Offset = "0x6AEB570", VA = "0x186AECF70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6AECF60", Offset = "0x6AEB560", VA = "0x186AECF60")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[IGHBAADFIGA]
public struct GPNDFOMOICI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public float3 PLNOJLPKDCC;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public static readonly GPNDFOMOICI ABMFDACMOIG;
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[IGHBAADFIGA]
public struct COCFKPAGIMD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float3 MCPNOOFMAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public quaternion GLKHDAMNPBA;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public static readonly COCFKPAGIMD ABMFDACMOIG;
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class ILHMKLJFLOG
{
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[IGHBAADFIGA]
public struct NKFEIODJJNE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float MDNGJKBFJKG;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public static readonly NKFEIODJJNE ABMFDACMOIG;
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct IEOBNEEPGIP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Entity AMNPFAMIOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public EEMOMCJGFPH GNLDGJDNMDL;
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct DJOMMJDNOAJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public EEMOMCJGFPH GNLDGJDNMDL;
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct LDFJHPHLOJD : ISystemStateComponentData, IComponentData, GEIPLJHPHML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Entity CAAMCMKANHA;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity ACDFDGEINEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct BEAPNCJHBPN : ISystemStateBufferElementData, IBufferElementData, GEIPLJHPHML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity PIDHMPAKEOP;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Entity ACDFDGEINEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct MGNJANBGJKC : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Entity AMNPFAMIOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public EEMOMCJGFPH GNLDGJDNMDL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct HEOPDIPEPHJ : IEqualityComparer<MGNJANBGJKC>
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public static HEOPDIPEPHJ ABMFDACMOIG;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC110", Offset = "0x6AEA710", VA = "0x186AEC110", Slot = "4")]
	public bool Equals(MGNJANBGJKC OCPDJIJPMCG, MGNJANBGJKC DEKMKLPIHFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC160", Offset = "0x6AEA760", VA = "0x186AEC160", Slot = "5")]
	public int GetHashCode(MGNJANBGJKC NJKKPOFFNNJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct GAOAOILMJDH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public FixedList32Bytes<int> FGPDHFALOFH;
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct MMFBAENABFA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public FixedList32Bytes<int> FGPDHFALOFH;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct OODGDLFAPHF : ISystemStateBufferElementData, IBufferElementData, GEIPLJHPHML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Entity LBOJNPPJLEK;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private Entity JMCICOALBMI
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8FA830", Offset = "0x8F8E30", VA = "0x1808FA830", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xE7B050", Offset = "0xE79650", VA = "0x180E7B050", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class IPKPEEFKBAD : ContainerPropertyBag<HIIKEHCPEFF>
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	private class GPHCBPDPNJC : Property<HIIKEHCPEFF, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string OABCLOFHIGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6AEBF70", Offset = "0x6AEA570", VA = "0x186AEBF70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool IJMBFBLHEGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6AEBF30", Offset = "0x6AEA530", VA = "0x186AEBF30")]
		public GPHCBPDPNJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6AEBE70", Offset = "0x6AEA470", VA = "0x186AEBE70", Slot = "14")]
		public override GameObject GetValue(HIIKEHCPEFF PCIOPLPELBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6AEBE90", Offset = "0x6AEA490", VA = "0x186AEBE90", Slot = "15")]
		public override void SetValue(HIIKEHCPEFF PCIOPLPELBM, GameObject DMNGPNKHPKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class EMOKOIIIMHC : Property<HIIKEHCPEFF, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string OABCLOFHIGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6AEBCC0", Offset = "0x6AEA2C0", VA = "0x186AEBCC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool IJMBFBLHEGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6AEBC80", Offset = "0x6AEA280", VA = "0x186AEBC80")]
		public EMOKOIIIMHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6AEBC30", Offset = "0x6AEA230", VA = "0x186AEBC30", Slot = "14")]
		public override object GetValue(HIIKEHCPEFF PCIOPLPELBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6AEBC50", Offset = "0x6AEA250", VA = "0x186AEBC50", Slot = "15")]
		public override void SetValue(HIIKEHCPEFF PCIOPLPELBM, object DMNGPNKHPKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class BHLOKHNLHOE : Property<HIIKEHCPEFF, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string OABCLOFHIGC
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6AEB250", Offset = "0x6AE9850", VA = "0x186AEB250", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool IJMBFBLHEGC
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB210", Offset = "0x6AE9810", VA = "0x186AEB210")]
		public BHLOKHNLHOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB1C0", Offset = "0x6AE97C0", VA = "0x186AEB1C0", Slot = "14")]
		public override object GetValue(HIIKEHCPEFF PCIOPLPELBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB1E0", Offset = "0x6AE97E0", VA = "0x186AEB1E0", Slot = "15")]
		public override void SetValue(HIIKEHCPEFF PCIOPLPELBM, object DMNGPNKHPKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	private class GAKDLFHNEAL : Property<HIIKEHCPEFF, HIIKEHCPEFF.KNFKABIBENH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string OABCLOFHIGC
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6AEBE40", Offset = "0x6AEA440", VA = "0x186AEBE40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool IJMBFBLHEGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6AEBE00", Offset = "0x6AEA400", VA = "0x186AEBE00")]
		public GAKDLFHNEAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6AEBDB0", Offset = "0x6AEA3B0", VA = "0x186AEBDB0", Slot = "14")]
		public override HIIKEHCPEFF.KNFKABIBENH GetValue(HIIKEHCPEFF PCIOPLPELBM)
		{
			return default(HIIKEHCPEFF.KNFKABIBENH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6AEBDD0", Offset = "0x6AEA3D0", VA = "0x186AEBDD0", Slot = "15")]
		public override void SetValue(HIIKEHCPEFF PCIOPLPELBM, HIIKEHCPEFF.KNFKABIBENH DMNGPNKHPKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private class ENKCODGENEO : Property<HIIKEHCPEFF, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string OABCLOFHIGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6AEBD80", Offset = "0x6AEA380", VA = "0x186AEBD80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool IJMBFBLHEGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6AEBD40", Offset = "0x6AEA340", VA = "0x186AEBD40")]
		public ENKCODGENEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6AEBCF0", Offset = "0x6AEA2F0", VA = "0x186AEBCF0", Slot = "14")]
		public override Delegate GetValue(HIIKEHCPEFF PCIOPLPELBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6AEBD10", Offset = "0x6AEA310", VA = "0x186AEBD10", Slot = "15")]
		public override void SetValue(HIIKEHCPEFF PCIOPLPELBM, Delegate DMNGPNKHPKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	private class EFHCMNKDGOD : Property<HIIKEHCPEFF, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string OABCLOFHIGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6AEBAC0", Offset = "0x6AEA0C0", VA = "0x186AEBAC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool IJMBFBLHEGC
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6AEBA80", Offset = "0x6AEA080", VA = "0x186AEBA80")]
		public EFHCMNKDGOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6AEBA30", Offset = "0x6AEA030", VA = "0x186AEBA30", Slot = "14")]
		public override Delegate GetValue(HIIKEHCPEFF PCIOPLPELBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6AEBA50", Offset = "0x6AEA050", VA = "0x186AEBA50", Slot = "15")]
		public override void SetValue(HIIKEHCPEFF PCIOPLPELBM, Delegate DMNGPNKHPKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private class BKJNGJGKBEH : Property<HIIKEHCPEFF, GKFBNGBAJIH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string OABCLOFHIGC
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6AEB600", Offset = "0x6AE9C00", VA = "0x186AEB600", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool IJMBFBLHEGC
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB5C0", Offset = "0x6AE9BC0", VA = "0x186AEB5C0")]
		public BKJNGJGKBEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB550", Offset = "0x6AE9B50", VA = "0x186AEB550", Slot = "14")]
		public override GKFBNGBAJIH<Delegate> GetValue(HIIKEHCPEFF PCIOPLPELBM)
		{
			return default(GKFBNGBAJIH<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB580", Offset = "0x6AE9B80", VA = "0x186AEB580", Slot = "15")]
		public override void SetValue(HIIKEHCPEFF PCIOPLPELBM, GKFBNGBAJIH<Delegate> DMNGPNKHPKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private class HHAMBILKMEM : Property<HIIKEHCPEFF, GKFBNGBAJIH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string OABCLOFHIGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6AEC270", Offset = "0x6AEA870", VA = "0x186AEC270", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool IJMBFBLHEGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6AEC230", Offset = "0x6AEA830", VA = "0x186AEC230")]
		public HHAMBILKMEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6AEC1C0", Offset = "0x6AEA7C0", VA = "0x186AEC1C0", Slot = "14")]
		public override GKFBNGBAJIH<Delegate> GetValue(HIIKEHCPEFF PCIOPLPELBM)
		{
			return default(GKFBNGBAJIH<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6AEC1F0", Offset = "0x6AEA7F0", VA = "0x186AEC1F0", Slot = "15")]
		public override void SetValue(HIIKEHCPEFF PCIOPLPELBM, GKFBNGBAJIH<Delegate> DMNGPNKHPKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class LICEAINFNDL : Property<HIIKEHCPEFF, GKFBNGBAJIH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string OABCLOFHIGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6AECF30", Offset = "0x6AEB530", VA = "0x186AECF30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool IJMBFBLHEGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6AECEF0", Offset = "0x6AEB4F0", VA = "0x186AECEF0")]
		public LICEAINFNDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6AECE80", Offset = "0x6AEB480", VA = "0x186AECE80", Slot = "14")]
		public override GKFBNGBAJIH<Delegate> GetValue(HIIKEHCPEFF PCIOPLPELBM)
		{
			return default(GKFBNGBAJIH<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6AECEB0", Offset = "0x6AEB4B0", VA = "0x186AECEB0", Slot = "15")]
		public override void SetValue(HIIKEHCPEFF PCIOPLPELBM, GKFBNGBAJIH<Delegate> DMNGPNKHPKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	private class HJNNMFKMKDO : Property<HIIKEHCPEFF, GKFBNGBAJIH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string OABCLOFHIGC
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6AEC3B0", Offset = "0x6AEA9B0", VA = "0x186AEC3B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool IJMBFBLHEGC
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6AEC370", Offset = "0x6AEA970", VA = "0x186AEC370")]
		public HJNNMFKMKDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6AEC2F0", Offset = "0x6AEA8F0", VA = "0x186AEC2F0", Slot = "14")]
		public override GKFBNGBAJIH<Delegate> GetValue(HIIKEHCPEFF PCIOPLPELBM)
		{
			return default(GKFBNGBAJIH<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6AEC330", Offset = "0x6AEA930", VA = "0x186AEC330", Slot = "15")]
		public override void SetValue(HIIKEHCPEFF PCIOPLPELBM, GKFBNGBAJIH<Delegate> DMNGPNKHPKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private class LBIDBEMKJNN : Property<HIIKEHCPEFF, GKFBNGBAJIH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string OABCLOFHIGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6AECDA0", Offset = "0x6AEB3A0", VA = "0x186AECDA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool IJMBFBLHEGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6AECD60", Offset = "0x6AEB360", VA = "0x186AECD60")]
		public LBIDBEMKJNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6AECCE0", Offset = "0x6AEB2E0", VA = "0x186AECCE0", Slot = "14")]
		public override GKFBNGBAJIH<Delegate> GetValue(HIIKEHCPEFF PCIOPLPELBM)
		{
			return default(GKFBNGBAJIH<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6AECD20", Offset = "0x6AEB320", VA = "0x186AECD20", Slot = "15")]
		public override void SetValue(HIIKEHCPEFF PCIOPLPELBM, GKFBNGBAJIH<Delegate> DMNGPNKHPKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	private class HCKCCKFOHGK : Property<HIIKEHCPEFF, GKFBNGBAJIH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string OABCLOFHIGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6AEC0E0", Offset = "0x6AEA6E0", VA = "0x186AEC0E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool IJMBFBLHEGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6AEC0A0", Offset = "0x6AEA6A0", VA = "0x186AEC0A0")]
		public HCKCCKFOHGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6AEC020", Offset = "0x6AEA620", VA = "0x186AEC020", Slot = "14")]
		public override GKFBNGBAJIH<Delegate> GetValue(HIIKEHCPEFF PCIOPLPELBM)
		{
			return default(GKFBNGBAJIH<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6AEC060", Offset = "0x6AEA660", VA = "0x186AEC060", Slot = "15")]
		public override void SetValue(HIIKEHCPEFF PCIOPLPELBM, GKFBNGBAJIH<Delegate> DMNGPNKHPKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	private class ADJJOJMFKIB : Property<HIIKEHCPEFF, GKFBNGBAJIH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string OABCLOFHIGC
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6AEB0D0", Offset = "0x6AE96D0", VA = "0x186AEB0D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool IJMBFBLHEGC
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB090", Offset = "0x6AE9690", VA = "0x186AEB090")]
		public ADJJOJMFKIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB010", Offset = "0x6AE9610", VA = "0x186AEB010", Slot = "14")]
		public override GKFBNGBAJIH<Delegate> GetValue(HIIKEHCPEFF PCIOPLPELBM)
		{
			return default(GKFBNGBAJIH<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB050", Offset = "0x6AE9650", VA = "0x186AEB050", Slot = "15")]
		public override void SetValue(HIIKEHCPEFF PCIOPLPELBM, GKFBNGBAJIH<Delegate> DMNGPNKHPKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class MEODJHKKBDJ : Property<HIIKEHCPEFF, GKFBNGBAJIH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string OABCLOFHIGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x6AED280", Offset = "0x6AEB880", VA = "0x186AED280", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool IJMBFBLHEGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6AED240", Offset = "0x6AEB840", VA = "0x186AED240")]
		public MEODJHKKBDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6AED1C0", Offset = "0x6AEB7C0", VA = "0x186AED1C0", Slot = "14")]
		public override GKFBNGBAJIH<Delegate> GetValue(HIIKEHCPEFF PCIOPLPELBM)
		{
			return default(GKFBNGBAJIH<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6AED200", Offset = "0x6AEB800", VA = "0x186AED200", Slot = "15")]
		public override void SetValue(HIIKEHCPEFF PCIOPLPELBM, GKFBNGBAJIH<Delegate> DMNGPNKHPKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	private class IAKCJLCOGHE : Property<HIIKEHCPEFF, GKFBNGBAJIH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string OABCLOFHIGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6AEC4A0", Offset = "0x6AEAAA0", VA = "0x186AEC4A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool IJMBFBLHEGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6AEC460", Offset = "0x6AEAA60", VA = "0x186AEC460")]
		public IAKCJLCOGHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6AEC3E0", Offset = "0x6AEA9E0", VA = "0x186AEC3E0", Slot = "14")]
		public override GKFBNGBAJIH<Delegate> GetValue(HIIKEHCPEFF PCIOPLPELBM)
		{
			return default(GKFBNGBAJIH<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6AEC420", Offset = "0x6AEAA20", VA = "0x186AEC420", Slot = "15")]
		public override void SetValue(HIIKEHCPEFF PCIOPLPELBM, GKFBNGBAJIH<Delegate> DMNGPNKHPKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC5B0", Offset = "0x6AEABB0", VA = "0x186AEC5B0")]
	public IPKPEEFKBAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal class PHCOBMMPKCE : ContainerPropertyBag<HIIKEHCPEFF.KNFKABIBENH>
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private class ILBMKAAACNL : Property<HIIKEHCPEFF.KNFKABIBENH, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string OABCLOFHIGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6AEC580", Offset = "0x6AEAB80", VA = "0x186AEC580", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool IJMBFBLHEGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6AEC540", Offset = "0x6AEAB40", VA = "0x186AEC540")]
		public ILBMKAAACNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA64770", Offset = "0xA62D70", VA = "0x180A64770", Slot = "14")]
		public override object GetValue(HIIKEHCPEFF.KNFKABIBENH PCIOPLPELBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x483D500", Offset = "0x483BB00", VA = "0x18483D500", Slot = "15")]
		public override void SetValue(HIIKEHCPEFF.KNFKABIBENH PCIOPLPELBM, object DMNGPNKHPKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6AED760", Offset = "0x6AEBD60", VA = "0x186AED760")]
	public PHCOBMMPKCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class JOCIFACNIMN : ContainerPropertyBag<GKFBNGBAJIH<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6AECC10", Offset = "0x6AEB210", VA = "0x186AECC10")]
	public JOCIFACNIMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal class EFPLLIEBKMM : ContainerPropertyBag<NBMCGPGJFKD>
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class KAMDELBOEOF : Property<NBMCGPGJFKD, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string OABCLOFHIGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6AECCB0", Offset = "0x6AEB2B0", VA = "0x186AECCB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool IJMBFBLHEGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6AECC70", Offset = "0x6AEB270", VA = "0x186AECC70")]
		public KAMDELBOEOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6AEBE70", Offset = "0x6AEA470", VA = "0x186AEBE70", Slot = "14")]
		public override Rigidbody GetValue(NBMCGPGJFKD PCIOPLPELBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6AEBE90", Offset = "0x6AEA490", VA = "0x186AEBE90", Slot = "15")]
		public override void SetValue(NBMCGPGJFKD PCIOPLPELBM, Rigidbody DMNGPNKHPKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6AEBAF0", Offset = "0x6AEA0F0", VA = "0x186AEBAF0")]
	public EFPLLIEBKMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class OLCCKIMPCDE : ContainerPropertyBag<IFPHMGKKACA>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class GLKPPKCCOCF : Property<IFPHMGKKACA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string OABCLOFHIGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6AEBF00", Offset = "0x6AEA500", VA = "0x186AEBF00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool IJMBFBLHEGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6AEBEC0", Offset = "0x6AEA4C0", VA = "0x186AEBEC0")]
		public GLKPPKCCOCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6AEBE70", Offset = "0x6AEA470", VA = "0x186AEBE70", Slot = "14")]
		public override object GetValue(IFPHMGKKACA PCIOPLPELBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6AEBE90", Offset = "0x6AEA490", VA = "0x186AEBE90", Slot = "15")]
		public override void SetValue(IFPHMGKKACA PCIOPLPELBM, object DMNGPNKHPKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6AED4B0", Offset = "0x6AEBAB0", VA = "0x186AED4B0")]
	public OLCCKIMPCDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal class OHECHPFMINC : ContainerPropertyBag<MGKLKJLBBOM>
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private class PDFDENDLFGM : Property<MGKLKJLBBOM, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string OABCLOFHIGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6AED730", Offset = "0x6AEBD30", VA = "0x186AED730", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool IJMBFBLHEGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6AED6F0", Offset = "0x6AEBCF0", VA = "0x186AED6F0")]
		public PDFDENDLFGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6AEBE70", Offset = "0x6AEA470", VA = "0x186AEBE70", Slot = "14")]
		public override object GetValue(MGKLKJLBBOM PCIOPLPELBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6AEBE90", Offset = "0x6AEA490", VA = "0x186AEBE90", Slot = "15")]
		public override void SetValue(MGKLKJLBBOM PCIOPLPELBM, object DMNGPNKHPKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6AED3D0", Offset = "0x6AEB9D0", VA = "0x186AED3D0")]
	public OHECHPFMINC()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6AED840", Offset = "0x6AEBE40", VA = "0x186AED840")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class DGOGLIDKJLN
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public DGOGLIDKJLN()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
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
