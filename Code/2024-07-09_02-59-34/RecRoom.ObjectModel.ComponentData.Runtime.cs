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
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
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
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_ObjectModel_ComponentData_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : ONOOFAIPBBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6AB66E0", Offset = "0x6AB52E0", VA = "0x186AB66E0", Slot = "8")]
		public override void HAJCGDOEHIM(DNMIJDJJJKD registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6AB6AE0", Offset = "0x6AB56E0", VA = "0x186AB6AE0", Slot = "7")]
		public override void KOICIADILPF(MBNHAMLGJBA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6AB6EE0", Offset = "0x6AB5AE0", VA = "0x186AB6EE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct IGJEECPLOKN : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildBuffer>, KAGDFHACOBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3940", Offset = "0x6AB2540", VA = "0x186AB3940", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x932F10", Offset = "0x931B10", VA = "0x180932F10")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, KAGDFHACOBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct MIBNNAGEDKI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct JFOAKPFPGMF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity COLNAPOFGPC;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct PPEGJFMBJCK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity COLNAPOFGPC;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct EJPBNFKNGNG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<OJFBHEBCADG> JPJGLGDBOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<Entity> LDHHMLLPBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JobHandle HDLKHHLCLHJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LFJOKDMJBJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6AB40F0", Offset = "0x6AB2CF0", VA = "0x186AB40F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NAAONAFFINP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6AB40A0", Offset = "0x6AB2CA0", VA = "0x186AB40A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4CEB0E0", Offset = "0x4CE9CE0", VA = "0x184CEB0E0")]
	public EJPBNFKNGNG(NativeList<OJFBHEBCADG> JPJGLGDBOMB, NativeList<Entity> LDHHMLLPBKO, JobHandle HDLKHHLCLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6AB41C0", Offset = "0x6AB2DC0", VA = "0x186AB41C0")]
	public (Entity, NativeSlice<Entity>) HGPKGBFGFMC(int BFOGKPIBBMC)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4160", Offset = "0x6AB2D60", VA = "0x186AB4160", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct OJFBHEBCADG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Entity LNPGMAMPBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int JEHLDDEOFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int AEGGIAICNFC;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CLFMKMNAACC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LLIKKOEKEHK(bool CBOEGDCMJJK);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct HKPEMOOMPIO : IEquatable<HKPEMOOMPIO>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool NNAIPJBDCOG(int KNHDHKABHEK);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool KPBAOMDPODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool KOCDPGEMPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool PDOKDGNHPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool JMCGPINBGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly NNAIPJBDCOG PPIEPFPOIAC;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4AC0", Offset = "0x6AB36C0", VA = "0x186AB4AC0")]
	public HKPEMOOMPIO(DHKMNICNAEB DKIOAOHDADG, NNAIPJBDCOG PPIEPFPOIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4A90", Offset = "0x6AB3690", VA = "0x186AB4A90")]
	public HKPEMOOMPIO(bool KPBAOMDPODD, bool KOCDPGEMPIK, bool PDOKDGNHPGF, bool JMCGPINBGFE, NNAIPJBDCOG PPIEPFPOIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4910", Offset = "0x6AB3510", VA = "0x186AB4910")]
	public bool GDCIJKBFLJG(int KNHDHKABHEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4A10", Offset = "0x6AB3610", VA = "0x186AB4A10")]
	public bool MOHGNMJNJMA(int KNHDHKABHEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6AB49E0", Offset = "0x6AB35E0", VA = "0x186AB49E0")]
	public bool IIMPMHBIHNB(int KNHDHKABHEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4A60", Offset = "0x6AB3660", VA = "0x186AB4A60")]
	public bool PHIBFACIKAE(int KNHDHKABHEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6AB48E0", Offset = "0x6AB34E0", VA = "0x186AB48E0", Slot = "4")]
	public bool Equals(HKPEMOOMPIO HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4830", Offset = "0x6AB3430", VA = "0x186AB4830", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4940", Offset = "0x6AB3540", VA = "0x186AB4940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4A40", Offset = "0x6AB3640", VA = "0x186AB4A40")]
	private bool PBCACOIFFHK(int KNHDHKABHEK)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct ADJMGMNAFGE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct GCDONMLIFGH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct AHFMBLLGLEC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[InternalBufferCapacity(17)]
public struct GKFKDIIBMKD : IBufferElementData, IEquatable<GKFKDIIBMKD>, KAGDFHACOBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity INEKOMJGJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int JKNCMIJCBON;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity KIOPDNEHJGI
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4720", Offset = "0x6AB3320", VA = "0x186AB4720", Slot = "4")]
	public bool Equals(GKFKDIIBMKD HEIGABGMPLJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct ODIELCGOMOL : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct CCCKNHFHNAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly BCDIBNKHHJN COMFELHDALN;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x217CC00", Offset = "0x217B800", VA = "0x18217CC00")]
		public CCCKNHFHNAD(BCDIBNKHHJN IAMBCHNOONF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3AB0", Offset = "0x6AB26B0", VA = "0x186AB3AB0")]
		public bool DINAHCPDBJF(ODIELCGOMOL GLJHGPDBBAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3AA0", Offset = "0x6AB26A0", VA = "0x186AB3AA0")]
		public bool AEFAFJLHJEF(ODIELCGOMOL GLJHGPDBBAI, BCDIBNKHHJN MEEDNCKCKOG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly BCDIBNKHHJN MPJOJNPPKPJ;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x217CC00", Offset = "0x217B800", VA = "0x18217CC00")]
	public ODIELCGOMOL(BCDIBNKHHJN MPJOJNPPKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5DF0", Offset = "0x6AB49F0", VA = "0x186AB5DF0")]
	public ODIELCGOMOL GGGKDAGJAID(BCDIBNKHHJN LMKAOONBNBK)
	{
		return default(ODIELCGOMOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5E00", Offset = "0x6AB4A00", VA = "0x186AB5E00")]
	public ODIELCGOMOL JGLCMNFJIHA(BCDIBNKHHJN CIJLACMEODM)
	{
		return default(ODIELCGOMOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5E10", Offset = "0x6AB4A10", VA = "0x186AB5E10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[Flags]
public enum BCDIBNKHHJN : byte
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
public enum OGDABHALENC : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DHONBOEOKPB]
public struct OACAPHMEOKE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public OGDABHALENC MPJOJNPPKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public bool KJCLDINDJKK;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool DMDMCLKIKED
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6AB5CD0", Offset = "0x6AB48D0", VA = "0x186AB5CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5D20", Offset = "0x6AB4920", VA = "0x186AB5D20")]
	private OACAPHMEOKE(OGDABHALENC MPJOJNPPKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5CE0", Offset = "0x6AB48E0", VA = "0x186AB5CE0")]
	public OACAPHMEOKE GGGKDAGJAID(OGDABHALENC LMKAOONBNBK)
	{
		return default(OACAPHMEOKE);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5D00", Offset = "0x6AB4900", VA = "0x186AB5D00")]
	public OACAPHMEOKE JGLCMNFJIHA(OGDABHALENC CIJLACMEODM)
	{
		return default(OACAPHMEOKE);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct PMPGNPDGJKH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct MEIJDJJPPJA : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Entity GHDGMKFGCOA;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildBuffer>, KAGDFHACOBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3940", Offset = "0x6AB2540", VA = "0x186AB3940", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x932F10", Offset = "0x931B10", VA = "0x180932F10")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DHONBOEOKPB]
public struct LOEDCNPOHMJ : ISystemStateBufferElementData, IBufferElementData, KAGDFHACOBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public Entity AOPPIDPOGKL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Entity GMIGJKKMKNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct HGNCKDNKLAD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Entity BCOLLKODMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Entity OGHCJOIKPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity HHELPBBHENN;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct MPIKDNEIAEK<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly bool PHIOAAOKLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public uint JKIBBDCDEIL;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool AHBEKNOGNEK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.TypeVersion(2)]
public struct KIOGHPMPHCN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public uint HNAEHBGFEDE;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5080", Offset = "0x6AB3C80", VA = "0x186AB5080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct PKFIBIPKAAA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public int OAINFFFHFMB;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct NMDLMGNKKJO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public GCHandle LKHHKKPDEED;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct OJJPNMECDJI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public int OAINFFFHFMB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct EMDDKIJKCFB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct KNOOBNGGANM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public int OAINFFFHFMB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct CDPHKHABBEO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct AHIGIBPILDE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct EABFCBIMPMJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct EACMPKIAPJM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public CollisionDetectionMode IPJDNPGACPK;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[NPDIMBKLOMB]
public struct DBFOFGAFDKN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public IABFIAOBIIB PMGIBJAKIBE;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly DBFOFGAFDKN APEJJIEJKNM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct PINBKBIHOGK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct DJJJKHIMOJE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct JKAEPEFCLAP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[InternalBufferCapacity(0)]
public struct MGBDCDGADFP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Entity INEKOMJGJNI;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct EMBIOJLFLOF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Entity DELFIACNBGK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct LNAOCLHOOND : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct LGJAHJJFOCB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Entity LNPGMAMPBAC;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct FCDPJIMMEDN : ODCMJHJBKHI, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JDHOHDOFEHO KBDDOKDLMOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(JDHOHDOFEHO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct BDENBANINBN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float3 ABEPCGMOPPD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct KBMJNCOKCOK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[NPDIMBKLOMB]
public struct MPJEJNNGIFP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float3x3 MKMNCAFCPDO;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly MPJEJNNGIFP APEJJIEJKNM;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[NPDIMBKLOMB]
public struct CIIEBEKBECI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public float3x3 MKMNCAFCPDO;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly CIIEBEKBECI APEJJIEJKNM;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct LACALBMNOLC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public float3 KOGABKCBAAE;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct BBBBAHJKJEI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public float3 FGHEEDGOCFO;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[NPDIMBKLOMB]
public struct FBBNEGELOLP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public float IADHPBNDONB;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly FBBNEGELOLP APEJJIEJKNM;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[NPDIMBKLOMB]
public struct JCKLGDKFLLG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public float JNHGPIJJLML;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly JCKLGDKFLLG APEJJIEJKNM;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct DFILPKKKHOM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public float3 LPLGLMOGFIG;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct ALKDIHCGOMF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public GPOLNCCKNBK NKHEJILBBLG;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct OFMPCFEJKBF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public GPOLNCCKNBK GFNEFAFMGDK;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[DHONBOEOKPB]
public struct LDODOMGGHFB : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Entity AOPPIDPOGKL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct LFAPMFCBBLJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct DFENNOLMKPI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct LCPEAGMHNDL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public RigidbodyConstraints BONEEFDMJEH;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[NPDIMBKLOMB]
public struct JPDDJPOAIPC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public float EGGDIMEEDGF;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly JPDDJPOAIPC APEJJIEJKNM;
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct GGOIFCLHMJM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float EPCPCMHEJBJ;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class PKDEHLJAPLK : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct HHOGMBPOJKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public object EFEMGJMOAOE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public GameObject OJCNPGOLEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public object FGNCGFIJIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public object NOBMGIFPNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public HHOGMBPOJKB EFEMGJMOAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Delegate ODADKMJMJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public Delegate AOFDEHFGAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public GLMBAMGBOHP<Delegate> KOHPMKBBAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public GLMBAMGBOHP<Delegate> PHAPDPBKFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public GLMBAMGBOHP<Delegate> DJJKBKAPGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public GLMBAMGBOHP<Delegate> DEEHDKANJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public GLMBAMGBOHP<Delegate> LBFJOBAKOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public GLMBAMGBOHP<Delegate> IAEGMGFLDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public GLMBAMGBOHP<Delegate> KDDMDANJEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public GLMBAMGBOHP<Delegate> BLBCOFLIEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GLMBAMGBOHP<Delegate> FOLDPEBPPOM;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6AB61B0", Offset = "0x6AB4DB0", VA = "0x186AB61B0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public PKDEHLJAPLK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct NCOEFFEGJGO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct OHMEMEDKIGP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public int KDFFBEFBPLK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xE24FB0", Offset = "0xE23BB0", VA = "0x180E24FB0")]
	public static OHMEMEDKIGP ANHILFPCAJJ(int IIPLJLPCLBC)
	{
		return default(OHMEMEDKIGP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class BCHEKJKHBEN : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public Rigidbody IGFNCGLOHFM;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6AB3A30", Offset = "0x6AB2630", VA = "0x186AB3A30", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public BCHEKJKHBEN()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct EMADIJMHEMG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct OCNFGCGEALH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 EGKIANADJEO;
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct BOLIKKBMFMB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 IFAKEJMGKPK;
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[NPDIMBKLOMB]
public struct JPPNKBKNEBE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float GHFICBPGDAF;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly JPPNKBKNEBE APEJJIEJKNM;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class JOHMGJCBKOO : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public object KBNDENGPFOD;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4F90", Offset = "0x6AB3B90", VA = "0x186AB4F90", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public JOHMGJCBKOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class KOGLFCGHHPE : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public object BMONKAEKPHG;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5110", Offset = "0x6AB3D10", VA = "0x186AB5110", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public KOGLFCGHHPE()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct OODPEEAJOIO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct BKHJBBOCFNB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct HPDCCLECPOP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct LOGKLJHAHEN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct JDGNKKDAPOP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct KPODHNAHLNG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public FixedString32Bytes LONKACOOPGJ;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[DHONBOEOKPB]
public struct COGGKMDHKFL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Entity FEDKAPNICJB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x932F10", Offset = "0x931B10", VA = "0x180932F10")]
	public static COGGKMDHKFL ANHILFPCAJJ(Entity IIPLJLPCLBC)
	{
		return default(COGGKMDHKFL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct MCLKCNLNFBO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Entity AOPPIDPOGKL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x932F10", Offset = "0x931B10", VA = "0x180932F10")]
	public static MCLKCNLNFBO ANHILFPCAJJ(Entity AOPPIDPOGKL)
	{
		return default(MCLKCNLNFBO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct IGCEHBHCBKD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Entity KLIENGPHKKP;
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct BHFCONBDFFA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Entity KLIENGPHKKP;
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal struct NFALGELFKLM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Entity NMJPFOFGFOC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x932F10", Offset = "0x931B10", VA = "0x180932F10")]
	public static NFALGELFKLM ANHILFPCAJJ(Entity AOPPIDPOGKL)
	{
		return default(NFALGELFKLM);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal struct LFLJNFLOHNH : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct MOLKJPAGEBG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct BPAGHCCEMPF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public uint FAEMFOKJHDK;
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[DHONBOEOKPB]
internal struct BFKHGIMEPOG : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Entity HOPOBFMKOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public int BAEBMIBABAE;
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal struct GPNNILEPPHJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Entity BBBOJPMLDLJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct MBGKLNOLDNG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct FHNMAINJLCO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public uint JKIBBDCDEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int IPKBLHDMOIM;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xC51CA0", Offset = "0xC508A0", VA = "0x180C51CA0")]
	public FHNMAINJLCO(uint IOFBECDOPMH, int AMNBLEKHBPB)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct FHGGOFONFMB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct MKGIFBACJOJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct NECOOEIDFAE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct GPDAJNKPBDM : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct NOJGKCNLEAK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct CCPKOHJADHM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct MHIGKCNNLIB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct GFJLEKJBPAF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal struct OCAAEMIDIII : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct IOJONOJCKOC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct OKAPOEPDDEP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct OJJCIGCBAPO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal struct MBDKGBILBMO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal struct LHFEEJBLOEH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct PCPEIKBCHGI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct AOBHGLJIHNI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct DBNAIKCHHIK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct LJCJEEAIHFF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct OFMBOIGINFC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct DDMPIBNFKHG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct AAGLNOOLBAP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct BICAFDGELEE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct GMBKLHNMNEP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct GIJNMHNCLNL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal struct DPIMEPGOOII : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct NPOEAGJGCOF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct HPGGBPFHLIF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct JPLBJDMHPDP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[DHONBOEOKPB]
public struct MFMAJLKMFMK : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public FixedString32Bytes OKKJFMBNHDK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct PELNIGAJOJP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct NHIIMIIIHHO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal struct KCAGNODEKHF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
internal struct FFFJHBGIKHD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal struct KMAJHFJHMOA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct JKPKKPCDELJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct CFNEPDFBIMF : IComponentData, IComparable<CFNEPDFBIMF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public int OIIKIOOEBCH;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1A9A650", Offset = "0x1A99250", VA = "0x181A9A650", Slot = "4")]
	public int CompareTo(CFNEPDFBIMF HEIGABGMPLJ)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct GCFHICLOFPP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct LDKOJMPDNNE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public quaternion GPEICHFGELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float3 DCDKACDAEIJ;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct MHCJFEAAOEB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float LGLMPLHAOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float KKDAKFLAHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float JGJEFLKIGGP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct JPBLHDIJPAF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct ICMDDLFJNNG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct BOFLJJIKPNH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct KJDMACJPEHN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public int OAINFFFHFMB;
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[DHONBOEOKPB]
public struct ONBJIGALNDK : ISystemStateBufferElementData, IBufferElementData, KAGDFHACOBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Entity LEGDHLFEPNP;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Entity GMIGJKKMKNG
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[NPDIMBKLOMB]
public struct OLPMENMOFIF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public float4x4 LCEACDODJKI;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly OLPMENMOFIF APEJJIEJKNM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct EOMKJEAADHO : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008E")]
public struct HDMGNOEKFEC : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct LEADBBGPPJK : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
public struct FBBCNCMDIHL : IComponentData, IEnableableComponent
{
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[NPDIMBKLOMB]
public struct LBOJLNNLCBB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public float4x4 APILGPEEJFM;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly LBOJLNNLCBB APEJJIEJKNM;
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public struct CFHGNPGFDON : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private int MGNAJEKLNNI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int BAEBMIBABAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3AD0", Offset = "0x6AB26D0", VA = "0x186AB3AD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3AC0", Offset = "0x6AB26C0", VA = "0x186AB3AC0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[NPDIMBKLOMB]
public struct NLAFPGNCFAI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public float3 ICBHJHEOJJF;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly NLAFPGNCFAI APEJJIEJKNM;
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[NPDIMBKLOMB]
public struct PAPPLPFEIHC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public float3 DCDKACDAEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public quaternion GPEICHFGELO;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public static readonly PAPPLPFEIHC APEJJIEJKNM;
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class NGPPFJOPCID
{
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[NPDIMBKLOMB]
public struct NEDJJCMDAJH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float PFEFDBGHAKC;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly NEDJJCMDAJH APEJJIEJKNM;
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct PMDGLMBNNFM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Entity BEIEEDBGEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public ENHGDLNCONB DEJLCIIFBAN;
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct HFPCAKAECOB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public ENHGDLNCONB DEJLCIIFBAN;
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct IKEEKEJKHLL : ISystemStateComponentData, IComponentData, KAGDFHACOBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Entity DJNHJDCMHHE;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity GMIGJKKMKNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct BNDLFBHALAM : ISystemStateBufferElementData, IBufferElementData, KAGDFHACOBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Entity IMKJELMPCKH;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Entity GMIGJKKMKNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct GEDFNNHBGEE : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity BEIEEDBGEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public ENHGDLNCONB DEJLCIIFBAN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct NPEAJCCLFCP : IEqualityComparer<GEDFNNHBGEE>
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static NPEAJCCLFCP APEJJIEJKNM;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5C20", Offset = "0x6AB4820", VA = "0x186AB5C20", Slot = "4")]
	public bool Equals(GEDFNNHBGEE KIGIELEFAKI, GEDFNNHBGEE DKINGMIONNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5C70", Offset = "0x6AB4870", VA = "0x186AB5C70", Slot = "5")]
	public int GetHashCode(GEDFNNHBGEE APKAFMDACKK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct ANEMONIGFOP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public FixedList32Bytes<int> PJNBHAEFPPO;
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public struct KADPDELBMEP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public FixedList32Bytes<int> PJNBHAEFPPO;
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public struct LKCFIFJHHND : ISystemStateBufferElementData, IBufferElementData, KAGDFHACOBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Entity HHAMAALKAGM;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private Entity KIOPDNEHJGI
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E80", Offset = "0x8D5A80", VA = "0x1808D6E80", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xE57B40", Offset = "0xE56740", VA = "0x180E57B40", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal class LILNAHGLCON : ContainerPropertyBag<PKDEHLJAPLK>
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class FNIGODCKNGI : Property<PKDEHLJAPLK, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string ACNBDEPIOMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6AB44B0", Offset = "0x6AB30B0", VA = "0x186AB44B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool JGMKIDPCBFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6AB4470", Offset = "0x6AB3070", VA = "0x186AB4470")]
		public FNIGODCKNGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3BE0", Offset = "0x6AB27E0", VA = "0x186AB3BE0", Slot = "14")]
		public override GameObject GetValue(PKDEHLJAPLK MLGAMJFBMDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3C00", Offset = "0x6AB2800", VA = "0x186AB3C00", Slot = "15")]
		public override void SetValue(PKDEHLJAPLK MLGAMJFBMDB, GameObject IIPLJLPCLBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	private class GNOEGGGOLOL : Property<PKDEHLJAPLK, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string ACNBDEPIOMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6AB4800", Offset = "0x6AB3400", VA = "0x186AB4800", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool JGMKIDPCBFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6AB47C0", Offset = "0x6AB33C0", VA = "0x186AB47C0")]
		public GNOEGGGOLOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6AB4770", Offset = "0x6AB3370", VA = "0x186AB4770", Slot = "14")]
		public override object GetValue(PKDEHLJAPLK MLGAMJFBMDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6AB4790", Offset = "0x6AB3390", VA = "0x186AB4790", Slot = "15")]
		public override void SetValue(PKDEHLJAPLK MLGAMJFBMDB, object IIPLJLPCLBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private class DNLFDFDPLGE : Property<PKDEHLJAPLK, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string ACNBDEPIOMC
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6AB3FB0", Offset = "0x6AB2BB0", VA = "0x186AB3FB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool JGMKIDPCBFO
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3F70", Offset = "0x6AB2B70", VA = "0x186AB3F70")]
		public DNLFDFDPLGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3F20", Offset = "0x6AB2B20", VA = "0x186AB3F20", Slot = "14")]
		public override object GetValue(PKDEHLJAPLK MLGAMJFBMDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3F40", Offset = "0x6AB2B40", VA = "0x186AB3F40", Slot = "15")]
		public override void SetValue(PKDEHLJAPLK MLGAMJFBMDB, object IIPLJLPCLBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	private class DOHNEOBDMIK : Property<PKDEHLJAPLK, PKDEHLJAPLK.HHOGMBPOJKB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string ACNBDEPIOMC
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6AB4070", Offset = "0x6AB2C70", VA = "0x186AB4070", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool JGMKIDPCBFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6AB4030", Offset = "0x6AB2C30", VA = "0x186AB4030")]
		public DOHNEOBDMIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3FE0", Offset = "0x6AB2BE0", VA = "0x186AB3FE0", Slot = "14")]
		public override PKDEHLJAPLK.HHOGMBPOJKB GetValue(PKDEHLJAPLK MLGAMJFBMDB)
		{
			return default(PKDEHLJAPLK.HHOGMBPOJKB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6AB4000", Offset = "0x6AB2C00", VA = "0x186AB4000", Slot = "15")]
		public override void SetValue(PKDEHLJAPLK MLGAMJFBMDB, PKDEHLJAPLK.HHOGMBPOJKB IIPLJLPCLBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private class HOGKMCCGILC : Property<PKDEHLJAPLK, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string ACNBDEPIOMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6AB4B90", Offset = "0x6AB3790", VA = "0x186AB4B90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool JGMKIDPCBFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6AB4B50", Offset = "0x6AB3750", VA = "0x186AB4B50")]
		public HOGKMCCGILC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6AB4B00", Offset = "0x6AB3700", VA = "0x186AB4B00", Slot = "14")]
		public override Delegate GetValue(PKDEHLJAPLK MLGAMJFBMDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6AB4B20", Offset = "0x6AB3720", VA = "0x186AB4B20", Slot = "15")]
		public override void SetValue(PKDEHLJAPLK MLGAMJFBMDB, Delegate IIPLJLPCLBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private class OCFCMJDPNOH : Property<PKDEHLJAPLK, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string ACNBDEPIOMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6AB5DC0", Offset = "0x6AB49C0", VA = "0x186AB5DC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool JGMKIDPCBFO
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6AB5D80", Offset = "0x6AB4980", VA = "0x186AB5D80")]
		public OCFCMJDPNOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6AB5D30", Offset = "0x6AB4930", VA = "0x186AB5D30", Slot = "14")]
		public override Delegate GetValue(PKDEHLJAPLK MLGAMJFBMDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6AB5D50", Offset = "0x6AB4950", VA = "0x186AB5D50", Slot = "15")]
		public override void SetValue(PKDEHLJAPLK MLGAMJFBMDB, Delegate IIPLJLPCLBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class IBILKDGBHLL : Property<PKDEHLJAPLK, GLMBAMGBOHP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string ACNBDEPIOMC
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6AB4C70", Offset = "0x6AB3870", VA = "0x186AB4C70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool JGMKIDPCBFO
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6AB4C30", Offset = "0x6AB3830", VA = "0x186AB4C30")]
		public IBILKDGBHLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6AB4BC0", Offset = "0x6AB37C0", VA = "0x186AB4BC0", Slot = "14")]
		public override GLMBAMGBOHP<Delegate> GetValue(PKDEHLJAPLK MLGAMJFBMDB)
		{
			return default(GLMBAMGBOHP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6AB4BF0", Offset = "0x6AB37F0", VA = "0x186AB4BF0", Slot = "15")]
		public override void SetValue(PKDEHLJAPLK MLGAMJFBMDB, GLMBAMGBOHP<Delegate> IIPLJLPCLBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	private class FFJFOAIAFFE : Property<PKDEHLJAPLK, GLMBAMGBOHP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string ACNBDEPIOMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6AB43D0", Offset = "0x6AB2FD0", VA = "0x186AB43D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool JGMKIDPCBFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6AB4390", Offset = "0x6AB2F90", VA = "0x186AB4390")]
		public FFJFOAIAFFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6AB4320", Offset = "0x6AB2F20", VA = "0x186AB4320", Slot = "14")]
		public override GLMBAMGBOHP<Delegate> GetValue(PKDEHLJAPLK MLGAMJFBMDB)
		{
			return default(GLMBAMGBOHP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6AB4350", Offset = "0x6AB2F50", VA = "0x186AB4350", Slot = "15")]
		public override void SetValue(PKDEHLJAPLK MLGAMJFBMDB, GLMBAMGBOHP<Delegate> IIPLJLPCLBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private class BABKAKNILHI : Property<PKDEHLJAPLK, GLMBAMGBOHP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string ACNBDEPIOMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6AB3A00", Offset = "0x6AB2600", VA = "0x186AB3A00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool JGMKIDPCBFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6AB39C0", Offset = "0x6AB25C0", VA = "0x186AB39C0")]
		public BABKAKNILHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3950", Offset = "0x6AB2550", VA = "0x186AB3950", Slot = "14")]
		public override GLMBAMGBOHP<Delegate> GetValue(PKDEHLJAPLK MLGAMJFBMDB)
		{
			return default(GLMBAMGBOHP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3980", Offset = "0x6AB2580", VA = "0x186AB3980", Slot = "15")]
		public override void SetValue(PKDEHLJAPLK MLGAMJFBMDB, GLMBAMGBOHP<Delegate> IIPLJLPCLBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	private class MDKNBKMMHKL : Property<PKDEHLJAPLK, GLMBAMGBOHP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string ACNBDEPIOMC
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6AB5950", Offset = "0x6AB4550", VA = "0x186AB5950", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool JGMKIDPCBFO
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6AB5910", Offset = "0x6AB4510", VA = "0x186AB5910")]
		public MDKNBKMMHKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6AB5890", Offset = "0x6AB4490", VA = "0x186AB5890", Slot = "14")]
		public override GLMBAMGBOHP<Delegate> GetValue(PKDEHLJAPLK MLGAMJFBMDB)
		{
			return default(GLMBAMGBOHP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6AB58D0", Offset = "0x6AB44D0", VA = "0x186AB58D0", Slot = "15")]
		public override void SetValue(PKDEHLJAPLK MLGAMJFBMDB, GLMBAMGBOHP<Delegate> IIPLJLPCLBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	private class OHFMCNDGDDI : Property<PKDEHLJAPLK, GLMBAMGBOHP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string ACNBDEPIOMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6AB5F30", Offset = "0x6AB4B30", VA = "0x186AB5F30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool JGMKIDPCBFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6AB5EF0", Offset = "0x6AB4AF0", VA = "0x186AB5EF0")]
		public OHFMCNDGDDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6AB5E70", Offset = "0x6AB4A70", VA = "0x186AB5E70", Slot = "14")]
		public override GLMBAMGBOHP<Delegate> GetValue(PKDEHLJAPLK MLGAMJFBMDB)
		{
			return default(GLMBAMGBOHP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6AB5EB0", Offset = "0x6AB4AB0", VA = "0x186AB5EB0", Slot = "15")]
		public override void SetValue(PKDEHLJAPLK MLGAMJFBMDB, GLMBAMGBOHP<Delegate> IIPLJLPCLBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class GJAAMKENFLB : Property<PKDEHLJAPLK, GLMBAMGBOHP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string ACNBDEPIOMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6AB46F0", Offset = "0x6AB32F0", VA = "0x186AB46F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool JGMKIDPCBFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6AB46B0", Offset = "0x6AB32B0", VA = "0x186AB46B0")]
		public GJAAMKENFLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6AB4630", Offset = "0x6AB3230", VA = "0x186AB4630", Slot = "14")]
		public override GLMBAMGBOHP<Delegate> GetValue(PKDEHLJAPLK MLGAMJFBMDB)
		{
			return default(GLMBAMGBOHP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6AB4670", Offset = "0x6AB3270", VA = "0x186AB4670", Slot = "15")]
		public override void SetValue(PKDEHLJAPLK MLGAMJFBMDB, GLMBAMGBOHP<Delegate> IIPLJLPCLBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	private class GABGNAMBHCI : Property<PKDEHLJAPLK, GLMBAMGBOHP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string ACNBDEPIOMC
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6AB45A0", Offset = "0x6AB31A0", VA = "0x186AB45A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool JGMKIDPCBFO
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6AB4560", Offset = "0x6AB3160", VA = "0x186AB4560")]
		public GABGNAMBHCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6AB44E0", Offset = "0x6AB30E0", VA = "0x186AB44E0", Slot = "14")]
		public override GLMBAMGBOHP<Delegate> GetValue(PKDEHLJAPLK MLGAMJFBMDB)
		{
			return default(GLMBAMGBOHP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6AB4520", Offset = "0x6AB3120", VA = "0x186AB4520", Slot = "15")]
		public override void SetValue(PKDEHLJAPLK MLGAMJFBMDB, GLMBAMGBOHP<Delegate> IIPLJLPCLBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	private class JGKHJBMIMGI : Property<PKDEHLJAPLK, GLMBAMGBOHP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string ACNBDEPIOMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x6AB4F60", Offset = "0x6AB3B60", VA = "0x186AB4F60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool JGMKIDPCBFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6AB4F20", Offset = "0x6AB3B20", VA = "0x186AB4F20")]
		public JGKHJBMIMGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6AB4EA0", Offset = "0x6AB3AA0", VA = "0x186AB4EA0", Slot = "14")]
		public override GLMBAMGBOHP<Delegate> GetValue(PKDEHLJAPLK MLGAMJFBMDB)
		{
			return default(GLMBAMGBOHP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6AB4EE0", Offset = "0x6AB3AE0", VA = "0x186AB4EE0", Slot = "15")]
		public override void SetValue(PKDEHLJAPLK MLGAMJFBMDB, GLMBAMGBOHP<Delegate> IIPLJLPCLBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private class DABDGLGPAMK : Property<PKDEHLJAPLK, GLMBAMGBOHP<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string ACNBDEPIOMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6AB3EB0", Offset = "0x6AB2AB0", VA = "0x186AB3EB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool JGMKIDPCBFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3E70", Offset = "0x6AB2A70", VA = "0x186AB3E70")]
		public DABDGLGPAMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3DF0", Offset = "0x6AB29F0", VA = "0x186AB3DF0", Slot = "14")]
		public override GLMBAMGBOHP<Delegate> GetValue(PKDEHLJAPLK MLGAMJFBMDB)
		{
			return default(GLMBAMGBOHP<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3E30", Offset = "0x6AB2A30", VA = "0x186AB3E30", Slot = "15")]
		public override void SetValue(PKDEHLJAPLK MLGAMJFBMDB, GLMBAMGBOHP<Delegate> IIPLJLPCLBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5230", Offset = "0x6AB3E30", VA = "0x186AB5230")]
	public LILNAHGLCON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class COBGCFJPLAL : ContainerPropertyBag<PKDEHLJAPLK.HHOGMBPOJKB>
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private class OPHOLJKJGHF : Property<PKDEHLJAPLK.HHOGMBPOJKB, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string ACNBDEPIOMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6AB6050", Offset = "0x6AB4C50", VA = "0x186AB6050", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool JGMKIDPCBFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6AB6010", Offset = "0x6AB4C10", VA = "0x186AB6010")]
		public OPHOLJKJGHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA219E0", Offset = "0xA205E0", VA = "0x180A219E0", Slot = "14")]
		public override object GetValue(PKDEHLJAPLK.HHOGMBPOJKB MLGAMJFBMDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x47E71D0", Offset = "0x47E5DD0", VA = "0x1847E71D0", Slot = "15")]
		public override void SetValue(PKDEHLJAPLK.HHOGMBPOJKB MLGAMJFBMDB, object IIPLJLPCLBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6AB3D10", Offset = "0x6AB2910", VA = "0x186AB3D10")]
	public COBGCFJPLAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
internal class GELFBHHLCFP : ContainerPropertyBag<GLMBAMGBOHP<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6AB45D0", Offset = "0x6AB31D0", VA = "0x186AB45D0")]
	public GELFBHHLCFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class IPGBDGPOEBI : ContainerPropertyBag<BCHEKJKHBEN>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class CLJBGKLKBGP : Property<BCHEKJKHBEN, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string ACNBDEPIOMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6AB3C70", Offset = "0x6AB2870", VA = "0x186AB3C70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool JGMKIDPCBFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3C30", Offset = "0x6AB2830", VA = "0x186AB3C30")]
		public CLJBGKLKBGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3BE0", Offset = "0x6AB27E0", VA = "0x186AB3BE0", Slot = "14")]
		public override Rigidbody GetValue(BCHEKJKHBEN MLGAMJFBMDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3C00", Offset = "0x6AB2800", VA = "0x186AB3C00", Slot = "15")]
		public override void SetValue(BCHEKJKHBEN MLGAMJFBMDB, Rigidbody IIPLJLPCLBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4D80", Offset = "0x6AB3980", VA = "0x186AB4D80")]
	public IPGBDGPOEBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal class NMPDGOOBPJE : ContainerPropertyBag<JOHMGJCBKOO>
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private class CMIHFHBIMLJ : Property<JOHMGJCBKOO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string ACNBDEPIOMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6AB3CE0", Offset = "0x6AB28E0", VA = "0x186AB3CE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool JGMKIDPCBFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3CA0", Offset = "0x6AB28A0", VA = "0x186AB3CA0")]
		public CMIHFHBIMLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3BE0", Offset = "0x6AB27E0", VA = "0x186AB3BE0", Slot = "14")]
		public override object GetValue(JOHMGJCBKOO MLGAMJFBMDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3C00", Offset = "0x6AB2800", VA = "0x186AB3C00", Slot = "15")]
		public override void SetValue(JOHMGJCBKOO MLGAMJFBMDB, object IIPLJLPCLBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5B40", Offset = "0x6AB4740", VA = "0x186AB5B40")]
	public NMPDGOOBPJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal class IJHPCAIBIOO : ContainerPropertyBag<KOGLFCGHHPE>
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	private class FLCEJBOFFKD : Property<KOGLFCGHHPE, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string ACNBDEPIOMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6AB4440", Offset = "0x6AB3040", VA = "0x186AB4440", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool JGMKIDPCBFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6AB4400", Offset = "0x6AB3000", VA = "0x186AB4400")]
		public FLCEJBOFFKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3BE0", Offset = "0x6AB27E0", VA = "0x186AB3BE0", Slot = "14")]
		public override object GetValue(KOGLFCGHHPE MLGAMJFBMDB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3C00", Offset = "0x6AB2800", VA = "0x186AB3C00", Slot = "15")]
		public override void SetValue(KOGLFCGHHPE MLGAMJFBMDB, object IIPLJLPCLBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4CA0", Offset = "0x6AB38A0", VA = "0x186AB4CA0")]
	public IJHPCAIBIOO()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6AB6200", Offset = "0x6AB4E00", VA = "0x186AB6200")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public class KNEBJPIKILJ
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public KNEBJPIKILJ()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
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
