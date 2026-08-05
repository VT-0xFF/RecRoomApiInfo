using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x826F050", Offset = "0x826DE50", VA = "0x18826F050", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x826F400", Offset = "0x826E200", VA = "0x18826F400", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x286F3E0", Offset = "0x286E1E0", VA = "0x18286F3E0")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
[TypeManager.ForcedStableTypeHash(1586941204353847852uL)]
public struct IJKAKAKEHDE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
[TypeManager.ForcedStableTypeHash(1730701010008160003uL)]
public struct MGFLJOCOHPG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
[TypeManager.ForcedStableTypeHash(3399609037308777919uL)]
public struct DJFGCDDDOHH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
[TypeManager.ForcedStableTypeHash(18083619841998483100uL)]
public struct KCLFEDBDMPE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
[TypeManager.ForcedStableTypeHash(12361415346715948123uL)]
public struct BGJIMEMNMHC : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[InternalBufferCapacity(8)]
	[TypeManager.ForcedStableTypeHash(15820941866177188261uL)]
	public struct AuthoredChildBuffer : IBufferElementData, IEquatable<AuthoredChildBuffer>, NMAGGKEIAEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x826BE40", Offset = "0x826AC40", VA = "0x18826BE40", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD87780", Offset = "0xD86580", VA = "0x180D87780")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
[TypeManager.ForcedStableTypeHash(7794731847884836165uL)]
public struct NFKIBEHMGHF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
[TypeManager.ForcedStableTypeHash(16414266906034106824uL)]
public struct PFABIOAFFCD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[TypeManager.ForcedStableTypeHash(1525018888797798356uL)]
public struct JGNFECMMGEP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Entity OAFEHLHLPJI;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[TypeManager.ForcedStableTypeHash(6294257411443737851uL)]
public struct HDEOOAOIKJN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity OAFEHLHLPJI;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct IDIIFHDOCJH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<GMFKEINLIDK> JKGNPCJCFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<Entity> LMLMELGNLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private JobHandle BNNGADNDJHP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool HFECACFKEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x826D740", Offset = "0x826C540", VA = "0x18826D740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int OOJPJFMJCLH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x826D690", Offset = "0x826C490", VA = "0x18826D690")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB7F0", Offset = "0x5FBA5F0", VA = "0x185FBB7F0")]
	public IDIIFHDOCJH(NativeList<GMFKEINLIDK> JKGNPCJCFMG, NativeList<Entity> LMLMELGNLOF, JobHandle BNNGADNDJHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x826D7B0", Offset = "0x826C5B0", VA = "0x18826D7B0")]
	public (Entity, NativeSlice<Entity>) PPNCHGFKONL(int BOECAAOIBHO)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x826D6E0", Offset = "0x826C4E0", VA = "0x18826D6E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct GMFKEINLIDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Entity EGPDFGOHLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int DOBKAGHAEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int IDFEOHMGIAF;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface COMMAFHFBJP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KPOBAEMGENL(bool NHBMEICLACE);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct OLHOHDDEIDE : IEquatable<OLHOHDDEIDE>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate bool IPOLEGLMBBE(int FLHCGDNOCHL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly bool EJEKJNHCAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool LJAFFOCJLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool LCABMIEJGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool HPHMOKHHCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly IPOLEGLMBBE PJFMIKOIEJM;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x826E670", Offset = "0x826D470", VA = "0x18826E670")]
	public OLHOHDDEIDE(GCLFJAMLBJN AALJBKNKHCP, IPOLEGLMBBE PJFMIKOIEJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x826E640", Offset = "0x826D440", VA = "0x18826E640")]
	public OLHOHDDEIDE(bool EJEKJNHCAHE, bool LJAFFOCJLJL, bool LCABMIEJGFB, bool HPHMOKHHCIM, IPOLEGLMBBE PJFMIKOIEJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x826E380", Offset = "0x826D180", VA = "0x18826E380")]
	public bool EOEEAGMDEHK(int FLHCGDNOCHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x826E580", Offset = "0x826D380", VA = "0x18826E580")]
	public bool OMDPJKICJDN(int FLHCGDNOCHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x826E350", Offset = "0x826D150", VA = "0x18826E350")]
	public bool BJOFBEAPALD(int FLHCGDNOCHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x826E490", Offset = "0x826D290", VA = "0x18826E490")]
	public bool GGLMGPMKLAK(int FLHCGDNOCHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x826E3B0", Offset = "0x826D1B0", VA = "0x18826E3B0", Slot = "4")]
	public bool Equals(OLHOHDDEIDE LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x826E3E0", Offset = "0x826D1E0", VA = "0x18826E3E0", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x826E4C0", Offset = "0x826D2C0", VA = "0x18826E4C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x826E560", Offset = "0x826D360", VA = "0x18826E560")]
	private bool KKFBOBCDMEM(int FLHCGDNOCHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x826E5B0", Offset = "0x826D3B0", VA = "0x18826E5B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CJLDNFCAAGE : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public IIJPOAKLDNG KPNIMMJCFHO;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x826C0F0", Offset = "0x826AEF0", VA = "0x18826C0F0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public CJLDNFCAAGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface IIJPOAKLDNG
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[TypeManager.ForcedStableTypeHash(8332665118338960440uL)]
public struct NGFKLAJIBGM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity AIOHINOEHLH;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[TypeManager.ForcedStableTypeHash(8981907371573408222uL)]
public struct FDLHNHKKPMO : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Entity EEDDICMBPCL;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[TypeManager.ForcedStableTypeHash(17354288130755581458uL)]
public struct KDAOFGPKECK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Entity IMMGGPCNCFI;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(10748250521618087564uL)]
public struct AACFAAJHHIH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public bool HFCNFDFCDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool FKFEPPCPGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public int DOOINCAOLIE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(3379294255511517190uL)]
public struct DPFIIELIDDO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[TypeManager.ForcedStableTypeHash(4520164298937563310uL)]
[SingletonComponent]
public struct EKEGOEIFIHF : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public Entity ALBBAEBLONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public Entity DIACOHFNPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public Entity GNKEPPKDICI;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(8968007509158485045uL)]
public struct IABMBHNNNBK : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public Entity PEHLPDAABGI;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[TypeManager.ForcedStableTypeHash(4138010451634514615uL)]
public struct PDNEOCILFOP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float3 EMECBHNHILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public quaternion NOLDGDLLBBL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(1690080301203719739uL)]
public struct NCLIMDPIAHA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(13667964378929084748uL)]
public readonly struct OCJLGMBHEFB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly CKOIOLBAIGI PHBJAELIHCD;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3097920", Offset = "0x3096720", VA = "0x183097920")]
	public OCJLGMBHEFB(CKOIOLBAIGI PHBJAELIHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x826E230", Offset = "0x826D030", VA = "0x18826E230")]
	public OCJLGMBHEFB LBAOMACOOFK(CKOIOLBAIGI IFOKKOPCBFE)
	{
		return default(OCJLGMBHEFB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x826E220", Offset = "0x826D020", VA = "0x18826E220")]
	public OCJLGMBHEFB JGCCEEEJAGF(CKOIOLBAIGI FKKDJDGEFEF)
	{
		return default(OCJLGMBHEFB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x826E240", Offset = "0x826D040", VA = "0x18826E240", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[Flags]
public enum CKOIOLBAIGI : ushort
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	HasShapeChildren = 1,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	HasEmbodiedChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	HasColliders = 4,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	HasObjectBoard = 8,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	HasUserTags = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	IsInScope = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	IsScopeRoot = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	IsRootObject = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	TestEmbodiment = 0x100,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	ReferredToByGroup = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	All = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class OMGMPGOOGKL
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[TypeManager.ForcedStableTypeHash(1995886936411817354uL)]
[SingletonComponent]
public struct MABFDMHIOMA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public CKOIOLBAIGI HAGFNEGDDNM;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x826DD80", Offset = "0x826CB80", VA = "0x18826DD80")]
	public bool EHEKBODMPLL(OCJLGMBHEFB OGLCGLIABDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x826DD90", Offset = "0x826CB90", VA = "0x18826DD90")]
	public bool KCMPOKBJBOK(OCJLGMBHEFB OGLCGLIABDH, CKOIOLBAIGI HCGJIOHPHHI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Flags]
public enum EGMENOJAELG : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(12096894998449299302uL)]
public struct EFGMGIMGPMJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public EGMENOJAELG PHBJAELIHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public bool BJHHJADLFLL;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool NMFMKGOEBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x826C3F0", Offset = "0x826B1F0", VA = "0x18826C3F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x826C440", Offset = "0x826B240", VA = "0x18826C440")]
	private EFGMGIMGPMJ(EGMENOJAELG PHBJAELIHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x826C420", Offset = "0x826B220", VA = "0x18826C420")]
	public EFGMGIMGPMJ LBAOMACOOFK(EGMENOJAELG IFOKKOPCBFE)
	{
		return default(EFGMGIMGPMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x826C400", Offset = "0x826B200", VA = "0x18826C400")]
	public EFGMGIMGPMJ JGCCEEEJAGF(EGMENOJAELG FKKDJDGEFEF)
	{
		return default(EFGMGIMGPMJ);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
[TypeManager.ForcedStableTypeHash(3210980466644930997uL)]
public struct GNGJGOHHMIB : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[InternalBufferCapacity(1)]
	[TypeManager.ForcedStableTypeHash(8887160633523457935uL)]
	public struct NetworkedEntityBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Entity entity;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[TypeManager.ForcedStableTypeHash(2308769520679974324uL)]
public struct MFLCONBLDMH : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Entity IEAPJDADILM;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[InternalBufferCapacity(8)]
	[TypeManager.ForcedStableTypeHash(2803523268494646145uL)]
	public struct ChildBuffer : IBufferElementData, IEquatable<ChildBuffer>, NMAGGKEIAEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x826BE40", Offset = "0x826AC40", VA = "0x18826BE40", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD87780", Offset = "0xD86580", VA = "0x180D87780")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[TypeManager.ForcedStableTypeHash(6734819606313844273uL)]
[SingletonComponent]
public struct DCMHMHEFMBJ : ISystemStateBufferElementData, IBufferElementData, NMAGGKEIAEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Entity ALBBAEBLONH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Entity CCDIJACDPMM
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[TypeManager.ForcedStableTypeHash(10606242260416974827uL)]
public struct HPLONADIDPD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Entity NGHGEPHKNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Entity DMKLKGJLLIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Entity KOJLOBLMLLN;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct KELFFGEELPI<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static readonly bool IHBLCGMONJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public uint OPHHKFNAMLO;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	private static bool JKNKKFPJIBJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[TypeManager.ForcedStableTypeHash(8255844827150930234uL)]
public struct MPNFFCOAKEN : IBufferElementData, IEquatable<MPNFFCOAKEN>, NMAGGKEIAEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Entity APKOLOEAFMJ;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private Entity AAOFEDLLHMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x826BE40", Offset = "0x826AC40", VA = "0x18826BE40", Slot = "4")]
	public bool Equals(MPNFFCOAKEN LOKLFHKEJPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[TypeManager.TypeVersion(2)]
[TypeManager.ForcedStableTypeHash(14518013333183728344uL)]
public struct FKIFJDJPCPP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public uint ENJBFLELFEA;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x14A3E20", Offset = "0x14A2C20", VA = "0x1814A3E20")]
	public FKIFJDJPCPP(CAPEGOJHEPC GOPPKIOICJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x826C5F0", Offset = "0x826B3F0", VA = "0x18826C5F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2099710", Offset = "0x2098510", VA = "0x182099710")]
	public static FKIFJDJPCPP JGGBAIGHKJA(CAPEGOJHEPC GOPPKIOICJL)
	{
		return default(FKIFJDJPCPP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[TypeManager.ForcedStableTypeHash(12631852336897389638uL)]
public struct MKPFMIEHJEF : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Entity ALBBAEBLONH;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[TypeManager.ForcedStableTypeHash(8586426759787957142uL)]
public struct DFFEDPOHMNH : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public CAPEGOJHEPC BNECONOIKOE;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[TypeManager.ForcedStableTypeHash(3916218676170013300uL)]
public struct BDNJGODDBFA : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Entity ALBBAEBLONH;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[TypeManager.ForcedStableTypeHash(3395423174463894753uL)]
public struct OMNLFPPBHFI : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Guid OKDHAOKOGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public int LJEIHABMGGI;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[TypeManager.ForcedStableTypeHash(13485578171010875955uL)]
public struct AEOPJGIOFHP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public int BNECONOIKOE;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[TypeManager.ForcedStableTypeHash(11182407275731589027uL)]
public struct NBNCJJCBDEO : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Entity ALBBAEBLONH;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[TypeManager.ForcedStableTypeHash(238571310055566811uL)]
public struct PGCNFMHFHAP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public CAPEGOJHEPC BNECONOIKOE;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[TypeManager.ForcedStableTypeHash(17943708062286791581uL)]
public struct DMNOMJBAMPG : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Entity ALBBAEBLONH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
[TypeManager.ForcedStableTypeHash(17717774548790709874uL)]
public struct JJLNKHELLKK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(1628423395607207516uL)]
public struct KBOBGPBCEAA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int HNKNEIKMHEI;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[TypeManager.ForcedStableTypeHash(6255673600552782006uL)]
public struct NAHIGOMEFIB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int DGOGGKOBPII;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public GLHCBKLDIDI IJCHILKMBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xD87DD0", Offset = "0xD86BD0", VA = "0x180D87DD0")]
		get
		{
			return default(GLHCBKLDIDI);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[TypeManager.ForcedStableTypeHash(7921165883083593916uL)]
public struct CMILJOEOOJN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public GCHandle NMCILABGJBA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
[TypeManager.ForcedStableTypeHash(14965811366685608319uL)]
public struct GLGFPMJJJKD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003B")]
[TypeManager.ForcedStableTypeHash(8376615066990205632uL)]
public struct HFHFPDLFIMK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003C")]
[TypeManager.ForcedStableTypeHash(7273320061473429398uL)]
public struct KBPFABKALEI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003D")]
[TypeManager.ForcedStableTypeHash(15140206241145976177uL)]
public struct ICDFEJPFFJD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003E")]
[TypeManager.ForcedStableTypeHash(15969631250552901108uL)]
public struct DLEBJMPFCGA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[TypeManager.ForcedStableTypeHash(9353178840587053763uL)]
public struct DEAOMIPJGHO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public int CKFKPOAGPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public int DMIBKIHBLCP;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x826C1A0", Offset = "0x826AFA0", VA = "0x18826C1A0")]
	public DEAOMIPJGHO(Entity ALBBAEBLONH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[TypeManager.ForcedStableTypeHash(16229383422209788655uL)]
public struct NKLJFPKMBDD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public CollisionDetectionMode EIBHGACBPDK;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[TypeManager.ForcedStableTypeHash(5173865590150727846uL)]
[RegisterComponentDefault]
public struct KKGDBNPCKJA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public CNPJGKPMCGN GDNJGEGADEG;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly KKGDBNPCKJA CLGJEJAIGBE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000042")]
[TypeManager.ForcedStableTypeHash(7051356195299730219uL)]
public struct GKEJGHFOHFH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000043")]
[TypeManager.ForcedStableTypeHash(780557526766205634uL)]
public struct OFDIFIKNBLO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000044")]
[TypeManager.ForcedStableTypeHash(16413322458062516985uL)]
public struct GFIEOOGCENC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[InternalBufferCapacity(0)]
[TypeManager.ForcedStableTypeHash(8350832327674051347uL)]
public struct NCHCEPGMMCL : IBufferElementData, IEquatable<NCHCEPGMMCL>, NMAGGKEIAEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Entity CCEEMHPLNFI;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity AAOFEDLLHMO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x826BE40", Offset = "0x826AC40", VA = "0x18826BE40", Slot = "4")]
	public bool Equals(NCHCEPGMMCL LOKLFHKEJPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[TypeManager.ForcedStableTypeHash(3503423083784418805uL)]
public struct MLMJAHJBCCM : IComponentData, NMAGGKEIAEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public Entity CMDMCJGFCDK;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Entity AAOFEDLLHMO
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
[TypeManager.ForcedStableTypeHash(14551834985136520975uL)]
public struct COGFHIMAIKF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[TypeManager.ForcedStableTypeHash(4388378139562737487uL)]
public struct IDDNCBPJLDG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Entity EGPDFGOHLFM;
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct PEABCKGEJPJ : KBOPFIBNPBI, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public FMAJPJOEDGP OIOBNMGLBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(FMAJPJOEDGP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[TypeManager.ForcedStableTypeHash(769086036388751339uL)]
public struct KEEJKDENDME : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public float3 IIMONNAPLJF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004B")]
[TypeManager.ForcedStableTypeHash(15638082890667179775uL)]
public struct AGOALFEABMN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(7040629969868025973uL)]
public struct ACLNBCKDKNM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public float3x3 PPKCHBCCHIP;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly ACLNBCKDKNM CLGJEJAIGBE;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[TypeManager.ForcedStableTypeHash(1290915447730818204uL)]
[RegisterComponentDefault]
public struct BIFBKICBICP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public float3x3 PPKCHBCCHIP;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly BIFBKICBICP CLGJEJAIGBE;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[TypeManager.ForcedStableTypeHash(7667208078276643555uL)]
public struct HHLLIIHNJKN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float3 PKIDCIONLMF;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[TypeManager.ForcedStableTypeHash(11475279934298573286uL)]
public struct DCPLPPLADHF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public float3 LBOABIBEHGJ;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(18413785019621221410uL)]
public struct DDBOEJBPEIJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float KKOFBCIKICH;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly DDBOEJBPEIJ CLGJEJAIGBE;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(16788150452972582455uL)]
public struct MGHHGKLBDJH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float LHKAFEIBHKJ;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly MGHHGKLBDJH CLGJEJAIGBE;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[TypeManager.ForcedStableTypeHash(971312552983123380uL)]
public struct HAAHEKJKJMC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 PPFGELDDKDA;
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[TypeManager.ForcedStableTypeHash(361641396811542242uL)]
public struct NFOFIFNJHED : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public CLOJPGAOOMI CJGCNOHEHKE;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[TypeManager.ForcedStableTypeHash(7520974846918069913uL)]
[SingletonComponent]
public struct INNMLNPFINC : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public Entity ALBBAEBLONH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
[TypeManager.ForcedStableTypeHash(9260549625364734686uL)]
public struct FNKEBLGBLOF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
[TypeManager.ForcedStableTypeHash(469905343419662571uL)]
public struct DHOJFCABPKG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[TypeManager.ForcedStableTypeHash(7865784707562564105uL)]
public struct ENCCBEPOKAM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public RigidbodyConstraints PNCGHFMOGAI;
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[TypeManager.ForcedStableTypeHash(7877027338327956319uL)]
[RegisterComponentDefault]
public struct NIBHOHIBAPL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float AFJPJKDLJMG;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly NIBHOHIBAPL CLGJEJAIGBE;
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[TypeManager.ForcedStableTypeHash(935406425377786813uL)]
public struct PMJLFDEJFJB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float IKBPJPOMDFD;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class NBNHELBHBEC : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public GameObject JLNNGPHDMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public object BGLGCACIJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public object CPBIKLIJBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public HGOBILCNGDO JPJFDCGGAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Delegate DAAJNNACEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Delegate KCOPELAOLMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public GDLAFIILODC<Delegate> APBEPPFPMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public GDLAFIILODC<Delegate> GAHJBAKLMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public GDLAFIILODC<Delegate> LNLFPCNHLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public GDLAFIILODC<Delegate> HFNHDKGHODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public GDLAFIILODC<Delegate> AOFMDGGKEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public GDLAFIILODC<Delegate> FEMPAKKBKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public GDLAFIILODC<Delegate> CKNCDKEAHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public GDLAFIILODC<Delegate> JAOHBHNKAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public GDLAFIILODC<Delegate> PPGDICHGFNJ;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x826E060", Offset = "0x826CE60", VA = "0x18826E060", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public NBNHELBHBEC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
[TypeManager.ForcedStableTypeHash(9555099704367481551uL)]
public struct CHBNBCFEDIL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
[TypeManager.ForcedStableTypeHash(18165447863202358792uL)]
public struct IJDBPLKIPHP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[TypeManager.ForcedStableTypeHash(10810926406358250264uL)]
public struct CLDLBPGBCOB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public int COBLIMDGLGG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2099710", Offset = "0x2098510", VA = "0x182099710")]
	public static CLDLBPGBCOB JGGBAIGHKJA(int BNECONOIKOE)
	{
		return default(CLDLBPGBCOB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class EHJNILFGKMO : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Rigidbody GFGAJJMHNJH;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x826C450", Offset = "0x826B250", VA = "0x18826C450", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public EHJNILFGKMO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
[TypeManager.ForcedStableTypeHash(12765569839950265583uL)]
public struct FMNAGLEEKJA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[TypeManager.ForcedStableTypeHash(17236748096909814533uL)]
public struct MNIHOJDEPCB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float3 BBFHLEIKDJM;
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[TypeManager.ForcedStableTypeHash(1288392478539867023uL)]
public struct JHFOIOHKLKD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public float3 LNGDDNPHJHH;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(15102898512288820575uL)]
public struct GHEMMDOHCCG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public float GOMMACADPEP;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly GHEMMDOHCCG CLGJEJAIGBE;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class EKNCCFOALFH : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public object JKPIAMHLJHL;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x826C4C0", Offset = "0x826B2C0", VA = "0x18826C4C0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public EKNCCFOALFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class JMPOKHHGAPG : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public object INNILBHDIHC;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x826D8D0", Offset = "0x826C6D0", VA = "0x18826D8D0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public JMPOKHHGAPG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
[TypeManager.ForcedStableTypeHash(3505189951659289292uL)]
public struct LEAFEHHCJHF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
[TypeManager.ForcedStableTypeHash(16217323095468023009uL)]
public struct MNBIGFPBNEE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
[TypeManager.ForcedStableTypeHash(12880717127246424414uL)]
public struct IKBLICFNBJB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
[TypeManager.ForcedStableTypeHash(12942629461400744171uL)]
public struct LCJDJHEGGJF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
[TypeManager.ForcedStableTypeHash(10226241216405964379uL)]
public struct CMPLCGEACPC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
[TypeManager.ForcedStableTypeHash(12400259538654257671uL)]
public struct MMCOPDHPLJJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
[TypeManager.ForcedStableTypeHash(12731949941800560397uL)]
public struct LAIPNMLPAGP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
[TypeManager.ForcedStableTypeHash(16270799832065682331uL)]
public struct EBDLOLACPPK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
[TypeManager.ForcedStableTypeHash(9395080039644288849uL)]
public struct OCAIMKLAEJJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
[TypeManager.ForcedStableTypeHash(15229363233412980908uL)]
public struct BNNPDLHFJNK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[TypeManager.ForcedStableTypeHash(282623311697096978uL)]
public struct GMPKNELNHMA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public OGAPBCAHLMD FCEAMCDDCEK;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x826D460", Offset = "0x826C260", VA = "0x18826D460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
[TypeManager.ForcedStableTypeHash(10395819776101408141uL)]
public struct OGNAIJECPFD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
[TypeManager.ForcedStableTypeHash(375953524326549120uL)]
public struct FPBAHCDMGGI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
[TypeManager.ForcedStableTypeHash(14259779488802476986uL)]
public struct JMPIDLOBLHO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[TypeManager.ForcedStableTypeHash(15330221065042235480uL)]
public struct DELACFKBGCG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public FixedString32Bytes GGDFKFACHGG;
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(5162925656869367991uL)]
public struct NHDMFFMFJEJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public UnsafeParallelHashMap<OGAPBCAHLMD, Entity> PFMKNHFEBCL;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[TypeManager.ForcedStableTypeHash(9841032716800521808uL)]
public struct KNBLECDJKNI : ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Entity KPBEMECHECD;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[TypeManager.ForcedStableTypeHash(154813247653871879uL)]
internal struct CPEGLOINOPC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Entity ALBBAEBLONH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xD87780", Offset = "0xD86580", VA = "0x180D87780")]
	public static CPEGLOINOPC JGGBAIGHKJA(Entity ALBBAEBLONH)
	{
		return default(CPEGLOINOPC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[TypeManager.ForcedStableTypeHash(11656653634719673845uL)]
public struct LLHHALFALGN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Entity BOFOJNJCFMK;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[TypeManager.ForcedStableTypeHash(1837719173092935466uL)]
public struct NNMGGBHAHFN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Entity BOFOJNJCFMK;
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[TypeManager.ForcedStableTypeHash(17382237360022739174uL)]
internal struct JNJFKKDCILL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Entity IHDHNJGHJAG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xD87780", Offset = "0xD86580", VA = "0x180D87780")]
	public static JNJFKKDCILL JGGBAIGHKJA(Entity ALBBAEBLONH)
	{
		return default(JNJFKKDCILL);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
[TypeManager.ForcedStableTypeHash(15858722173278118533uL)]
internal struct FHNDHGMGNMJ : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[TypeManager.ForcedStableTypeHash(10313790595830381076uL)]
public struct FLNDPGONJKG : IBufferElementData, IEquatable<FLNDPGONJKG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Entity OBKNICGFEIH;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8068130", Offset = "0x8066F30", VA = "0x188068130", Slot = "4")]
	public bool Equals(FLNDPGONJKG LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x826C620", Offset = "0x826B420", VA = "0x18826C620", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xD87DD0", Offset = "0xD86BD0", VA = "0x180D87DD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[TypeManager.ForcedStableTypeHash(10169361040328370708uL)]
public struct MAOGFAABFID : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public uint DMIBKIHBLCP;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(11536226225076729790uL)]
internal struct KDGDLDEOKLL : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Entity EKJEEABCOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public int CKFKPOAGPKN;
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[TypeManager.ForcedStableTypeHash(8309037880064337491uL)]
internal struct HAGJMAMJLJO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Entity BJIHLOBCEHA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
[TypeManager.ForcedStableTypeHash(5891816987223099091uL)]
public struct HBLHGKOMPLJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[TypeManager.ForcedStableTypeHash(17289298604600812224uL)]
public struct FOJOEBPGHNO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public uint OPHHKFNAMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public int BFILDJBFAFD;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xE3B7B0", Offset = "0xE3A5B0", VA = "0x180E3B7B0")]
	public FOJOEBPGHNO(uint PKDBMFDANPA, int JDNIFFHLOOG)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
[TypeManager.ForcedStableTypeHash(12258100538258701401uL)]
public struct NHNNIFDIFBM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
[TypeManager.ForcedStableTypeHash(3081870877980445988uL)]
public struct GBBABKNCPEG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
[TypeManager.ForcedStableTypeHash(15554741495161407507uL)]
public struct PKCFDDMJPNP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
[TypeManager.ForcedStableTypeHash(17684057078056878475uL)]
public struct LDMOFFIHGHC : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000085")]
[TypeManager.ForcedStableTypeHash(10023455309444528896uL)]
public struct OBONGDOPOKO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
[TypeManager.ForcedStableTypeHash(14403752119546393228uL)]
public struct OAJNGBEENND : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
[TypeManager.ForcedStableTypeHash(9219181242087356214uL)]
public struct OBPNICHOHCA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
[TypeManager.ForcedStableTypeHash(12371658133244024718uL)]
public struct KFANMBFBMMJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
[TypeManager.ForcedStableTypeHash(9351414359236295489uL)]
public struct OGFCPDBHHPP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
[TypeManager.ForcedStableTypeHash(12796707860320869007uL)]
internal struct JHDFDLFOJBG : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
[TypeManager.ForcedStableTypeHash(13367368557807690484uL)]
public struct GECMKANENEJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008C")]
[TypeManager.ForcedStableTypeHash(7193071459223094579uL)]
public struct GEMDCMFNOND : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
[TypeManager.ForcedStableTypeHash(17039127292426947163uL)]
public struct ICIEIHPNCLD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008E")]
[TypeManager.ForcedStableTypeHash(15247343901949961769uL)]
public struct IPGIEGPLAIP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
[TypeManager.ForcedStableTypeHash(5381043565870728787uL)]
public struct CMEOFJDIOEC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
[TypeManager.ForcedStableTypeHash(11597028615900234104uL)]
internal struct JACCCHBNCDD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
[TypeManager.ForcedStableTypeHash(1907494159895213433uL)]
internal struct NEBOEPEPCLL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000092")]
[TypeManager.ForcedStableTypeHash(3955886960983597628uL)]
public struct OOAPNBCCACE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000093")]
[TypeManager.ForcedStableTypeHash(480620745253244652uL)]
public struct GNBGAPNKCED : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000094")]
[TypeManager.ForcedStableTypeHash(8253675824478287824uL)]
public struct IEMKBPEIHMB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000095")]
[TypeManager.ForcedStableTypeHash(8855488771047251567uL)]
public struct MFBEGDJMAGK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000096")]
[TypeManager.ForcedStableTypeHash(8375777954271012995uL)]
public struct HAGAPMBKPFP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
[TypeManager.ForcedStableTypeHash(16778215356980427836uL)]
public struct AFIPIIIKDIE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000098")]
[TypeManager.ForcedStableTypeHash(16444804027614993581uL)]
public struct KDMLMPNECKE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000099")]
[TypeManager.ForcedStableTypeHash(16177323740107409537uL)]
public struct MMPBFOLKPGG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
[TypeManager.ForcedStableTypeHash(11049752089067741804uL)]
public struct NOOLGDMDNBC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009B")]
[TypeManager.ForcedStableTypeHash(1453937769327886583uL)]
public struct CEEHAGMACFI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
[TypeManager.ForcedStableTypeHash(800754555681830909uL)]
public struct IDIPDKGECLP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009D")]
[TypeManager.ForcedStableTypeHash(3336901602667819150uL)]
public struct GLPNIBIKOON : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009E")]
[TypeManager.ForcedStableTypeHash(11809750536411032401uL)]
public struct NDKAGGHENDA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
[TypeManager.ForcedStableTypeHash(6387004770090400669uL)]
public struct LHHMJGKAAJF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[TypeManager.ForcedStableTypeHash(2223159712203397538uL)]
internal struct HHMFDCKBOIG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[TypeManager.ForcedStableTypeHash(10153397523300334327uL)]
public struct OKFNECBIABD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[TypeManager.ForcedStableTypeHash(12983102201306073842uL)]
public struct PDAHDJOJHCN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[TypeManager.ForcedStableTypeHash(15398959433761599914uL)]
[KCOIFBNOEOP]
public struct BCNIGAICNBL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6605318152550716456uL)]
public struct ICNKDFPGOBL : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public FixedString32Bytes PEGIKAFHCAA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[TypeManager.ForcedStableTypeHash(10065634662848845784uL)]
public struct FMMFCLKIKEP : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[TypeManager.ForcedStableTypeHash(15062299176839263439uL)]
public struct IHAKKLNMNJD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[TypeManager.ForcedStableTypeHash(3596269116834888123uL)]
internal struct KDLPGOGMMIL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[TypeManager.ForcedStableTypeHash(4402941654898007496uL)]
internal struct PBKCOACIGIP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[TypeManager.ForcedStableTypeHash(12682474121528142025uL)]
internal struct LDCMIPCHAGB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[TypeManager.ForcedStableTypeHash(1840266485562743455uL)]
public struct PBBEGBHMGEG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[TypeManager.ForcedStableTypeHash(4772574226205567794uL)]
public struct ENFDCJPIFCA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[TypeManager.ForcedStableTypeHash(17642911464827038147uL)]
public struct NNAICEKKFBI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public quaternion NOLDGDLLBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public float3 EMECBHNHILC;
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[TypeManager.ForcedStableTypeHash(9066921186040058989uL)]
public struct NINKKMIJBOF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public float KBDKBIKGICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public float EGDKNCBJGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public float NACIPLLDEIM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[TypeManager.ForcedStableTypeHash(3328998613642473514uL)]
public struct CCPLCDCOKJL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[TypeManager.ForcedStableTypeHash(151116349382904900uL)]
public struct PIPBGIMIDBI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[TypeManager.ForcedStableTypeHash(8067675582152570601uL)]
public struct APMKFMGHNLE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[TypeManager.ForcedStableTypeHash(4522686316477281096uL)]
public struct LFPFOFAGNDB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public int DGOGGKOBPII;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6216404920432680992uL)]
public struct OLFMJLMJBEH : ISystemStateBufferElementData, IBufferElementData, NMAGGKEIAEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public Entity AGPNNEOOLAK;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity CCDIJACDPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(419884688393735449uL)]
public struct GNPNDBACEDK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public float4x4 NPCNJOHCAEB;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly GNPNDBACEDK CLGJEJAIGBE;
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(1954795745923300919uL)]
public struct MHODLMEGJLK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public float4x4 NNHONNMDIEJ;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly MHODLMEGJLK CLGJEJAIGBE;
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[TypeManager.ForcedStableTypeHash(2447627752265109178uL)]
public struct BEOEHKJPOEM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int JFOOLGFDLLK;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int CKFKPOAGPKN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x826BE60", Offset = "0x826AC60", VA = "0x18826BE60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x826BE50", Offset = "0x826AC50", VA = "0x18826BE50")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[TypeManager.ForcedStableTypeHash(13706996280046618062uL)]
[RegisterComponentDefault]
public struct NIHCNOMFDIH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public float3 EMECBHNHILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public quaternion NOLDGDLLBBL;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly NIHCNOMFDIH CLGJEJAIGBE;
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class JBHCFIIBDMA
{
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[TypeManager.ForcedStableTypeHash(77694943841979493uL)]
[RegisterComponentDefault]
public struct NBGGCMIDFJI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public float DJCJFHNJEON;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public static readonly NBGGCMIDFJI CLGJEJAIGBE;
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[TypeManager.ForcedStableTypeHash(6537711325103434903uL)]
public struct MNCLFFGOPLL : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public Entity HKDEGGMBIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public EOBJDHADOCF INALECHHMIH;
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[TypeManager.ForcedStableTypeHash(5471640964865828061uL)]
public struct LMOKGNDFOOG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public EOBJDHADOCF INALECHHMIH;
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[TypeManager.ForcedStableTypeHash(16527934868211432802uL)]
public struct AFOEEIPMDJC : ISystemStateComponentData, IComponentData, NMAGGKEIAEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public Entity PBHKHJPMFCF;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Entity CCDIJACDPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[TypeManager.ForcedStableTypeHash(15310407062508355916uL)]
public struct LPKHFLGFGNG : ISystemStateBufferElementData, IBufferElementData, NMAGGKEIAEM, IEquatable<LPKHFLGFGNG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Entity MAJIMBBOIAA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Entity CCDIJACDPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8068130", Offset = "0x8066F30", VA = "0x188068130", Slot = "6")]
	public bool Equals(LPKHFLGFGNG LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x826DCF0", Offset = "0x826CAF0", VA = "0x18826DCF0", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xD87DD0", Offset = "0xD86BD0", VA = "0x180D87DD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[TypeManager.ForcedStableTypeHash(11786768220100978132uL)]
public struct FEPDLDFEIDP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public Entity HKDEGGMBIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public EOBJDHADOCF INALECHHMIH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public struct OCLAIPKOLLA : IEqualityComparer<FEPDLDFEIDP>
{
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public static OCLAIPKOLLA CLGJEJAIGBE;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x826E2A0", Offset = "0x826D0A0", VA = "0x18826E2A0", Slot = "4")]
	public bool Equals(FEPDLDFEIDP DHOMBGCEEAK, FEPDLDFEIDP EDBCCDDDLPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x826E2F0", Offset = "0x826D0F0", VA = "0x18826E2F0", Slot = "5")]
	public int GetHashCode(FEPDLDFEIDP MKPNGAKJFMP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[TypeManager.ForcedStableTypeHash(8981997360983277121uL)]
public struct DAAHHHNIGIO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public FixedList32Bytes<int> JJCDINDALNK;
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[TypeManager.ForcedStableTypeHash(2801212869002544047uL)]
public struct PEMFOLMNCJD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public FixedList32Bytes<int> JJCDINDALNK;
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[TypeManager.ForcedStableTypeHash(16455485691096333919uL)]
public struct MLBPMGKOKHG : ISystemStateBufferElementData, IBufferElementData, NMAGGKEIAEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Entity PHMBPHLNOKI;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Entity AAOFEDLLHMO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1334A20", Offset = "0x1333820", VA = "0x181334A20", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal class FOLDPDGOKBC : ContainerPropertyBag<CJLDNFCAAGE>
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private class DOGDMDGOPOH : Property<CJLDNFCAAGE, IIJPOAKLDNG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string OFMLOIDKMDO
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x826C300", Offset = "0x826B100", VA = "0x18826C300", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool ECOGGGAIBMA
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x826C2C0", Offset = "0x826B0C0", VA = "0x18826C2C0")]
		public DOGDMDGOPOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x826C270", Offset = "0x826B070", VA = "0x18826C270", Slot = "14")]
		public override IIJPOAKLDNG GetValue(CJLDNFCAAGE CHDHLAGMCKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x826C290", Offset = "0x826B090", VA = "0x18826C290", Slot = "15")]
		public override void SetValue(CJLDNFCAAGE CHDHLAGMCKI, IIJPOAKLDNG BNECONOIKOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x826C800", Offset = "0x826B600", VA = "0x18826C800")]
	public FOLDPDGOKBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
internal class GHIFHEBCOEN : ContainerPropertyBag<NBNHELBHBEC>
{
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private class FNNOJLBKGDA : Property<NBNHELBHBEC, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string OFMLOIDKMDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x826C7D0", Offset = "0x826B5D0", VA = "0x18826C7D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool ECOGGGAIBMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x826C790", Offset = "0x826B590", VA = "0x18826C790")]
		public FNNOJLBKGDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x826C270", Offset = "0x826B070", VA = "0x18826C270", Slot = "14")]
		public override GameObject GetValue(NBNHELBHBEC CHDHLAGMCKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x826C290", Offset = "0x826B090", VA = "0x18826C290", Slot = "15")]
		public override void SetValue(NBNHELBHBEC CHDHLAGMCKI, GameObject BNECONOIKOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	private class GGPIAAFFGLE : Property<NBNHELBHBEC, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string OFMLOIDKMDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x826CB10", Offset = "0x826B910", VA = "0x18826CB10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool ECOGGGAIBMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x826CAD0", Offset = "0x826B8D0", VA = "0x18826CAD0")]
		public GGPIAAFFGLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x826CA80", Offset = "0x826B880", VA = "0x18826CA80", Slot = "14")]
		public override object GetValue(NBNHELBHBEC CHDHLAGMCKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x826CAA0", Offset = "0x826B8A0", VA = "0x18826CAA0", Slot = "15")]
		public override void SetValue(NBNHELBHBEC CHDHLAGMCKI, object BNECONOIKOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	private class HBNLGLGNOLA : Property<NBNHELBHBEC, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string OFMLOIDKMDO
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x826D660", Offset = "0x826C460", VA = "0x18826D660", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool ECOGGGAIBMA
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x826D620", Offset = "0x826C420", VA = "0x18826D620")]
		public HBNLGLGNOLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x826D5D0", Offset = "0x826C3D0", VA = "0x18826D5D0", Slot = "14")]
		public override object GetValue(NBNHELBHBEC CHDHLAGMCKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x826D5F0", Offset = "0x826C3F0", VA = "0x18826D5F0", Slot = "15")]
		public override void SetValue(NBNHELBHBEC CHDHLAGMCKI, object BNECONOIKOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	private class KHKGEJINAGF : Property<NBNHELBHBEC, HGOBILCNGDO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string OFMLOIDKMDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x826DAB0", Offset = "0x826C8B0", VA = "0x18826DAB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool ECOGGGAIBMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x826DA70", Offset = "0x826C870", VA = "0x18826DA70")]
		public KHKGEJINAGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x826DA20", Offset = "0x826C820", VA = "0x18826DA20", Slot = "14")]
		public override HGOBILCNGDO GetValue(NBNHELBHBEC CHDHLAGMCKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x826DA40", Offset = "0x826C840", VA = "0x18826DA40", Slot = "15")]
		public override void SetValue(NBNHELBHBEC CHDHLAGMCKI, HGOBILCNGDO BNECONOIKOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	private class EADNJNEOOIK : Property<NBNHELBHBEC, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string OFMLOIDKMDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x826C3C0", Offset = "0x826B1C0", VA = "0x18826C3C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool ECOGGGAIBMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x826C380", Offset = "0x826B180", VA = "0x18826C380")]
		public EADNJNEOOIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x826C330", Offset = "0x826B130", VA = "0x18826C330", Slot = "14")]
		public override Delegate GetValue(NBNHELBHBEC CHDHLAGMCKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x826C350", Offset = "0x826B150", VA = "0x18826C350", Slot = "15")]
		public override void SetValue(NBNHELBHBEC CHDHLAGMCKI, Delegate BNECONOIKOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	private class ENGPGKOELCE : Property<NBNHELBHBEC, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string OFMLOIDKMDO
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x826C5C0", Offset = "0x826B3C0", VA = "0x18826C5C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool ECOGGGAIBMA
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x826C580", Offset = "0x826B380", VA = "0x18826C580")]
		public ENGPGKOELCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x826C530", Offset = "0x826B330", VA = "0x18826C530", Slot = "14")]
		public override Delegate GetValue(NBNHELBHBEC CHDHLAGMCKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x826C550", Offset = "0x826B350", VA = "0x18826C550", Slot = "15")]
		public override void SetValue(NBNHELBHBEC CHDHLAGMCKI, Delegate BNECONOIKOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	private class BIFGPJMOMHL : Property<NBNHELBHBEC, GDLAFIILODC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string OFMLOIDKMDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x826C000", Offset = "0x826AE00", VA = "0x18826C000", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool ECOGGGAIBMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x826BFC0", Offset = "0x826ADC0", VA = "0x18826BFC0")]
		public BIFGPJMOMHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x826BF70", Offset = "0x826AD70", VA = "0x18826BF70", Slot = "14")]
		public override GDLAFIILODC<Delegate> GetValue(NBNHELBHBEC CHDHLAGMCKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x826BF90", Offset = "0x826AD90", VA = "0x18826BF90", Slot = "15")]
		public override void SetValue(NBNHELBHBEC CHDHLAGMCKI, GDLAFIILODC<Delegate> BNECONOIKOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	private class MKMPKOBKGIN : Property<NBNHELBHBEC, GDLAFIILODC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string OFMLOIDKMDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x826DF30", Offset = "0x826CD30", VA = "0x18826DF30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool ECOGGGAIBMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x826DEF0", Offset = "0x826CCF0", VA = "0x18826DEF0")]
		public MKMPKOBKGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x826DEA0", Offset = "0x826CCA0", VA = "0x18826DEA0", Slot = "14")]
		public override GDLAFIILODC<Delegate> GetValue(NBNHELBHBEC CHDHLAGMCKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x826DEC0", Offset = "0x826CCC0", VA = "0x18826DEC0", Slot = "15")]
		public override void SetValue(NBNHELBHBEC CHDHLAGMCKI, GDLAFIILODC<Delegate> BNECONOIKOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	private class BMLPDGEMCPB : Property<NBNHELBHBEC, GDLAFIILODC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string OFMLOIDKMDO
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x826C0C0", Offset = "0x826AEC0", VA = "0x18826C0C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool ECOGGGAIBMA
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x826C080", Offset = "0x826AE80", VA = "0x18826C080")]
		public BMLPDGEMCPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x826C030", Offset = "0x826AE30", VA = "0x18826C030", Slot = "14")]
		public override GDLAFIILODC<Delegate> GetValue(NBNHELBHBEC CHDHLAGMCKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x826C050", Offset = "0x826AE50", VA = "0x18826C050", Slot = "15")]
		public override void SetValue(NBNHELBHBEC CHDHLAGMCKI, GDLAFIILODC<Delegate> BNECONOIKOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	private class PIPLMEDPHJK : Property<NBNHELBHBEC, GDLAFIILODC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string OFMLOIDKMDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x826E8F0", Offset = "0x826D6F0", VA = "0x18826E8F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool ECOGGGAIBMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x826E8B0", Offset = "0x826D6B0", VA = "0x18826E8B0")]
		public PIPLMEDPHJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x826E860", Offset = "0x826D660", VA = "0x18826E860", Slot = "14")]
		public override GDLAFIILODC<Delegate> GetValue(NBNHELBHBEC CHDHLAGMCKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x826E880", Offset = "0x826D680", VA = "0x18826E880", Slot = "15")]
		public override void SetValue(NBNHELBHBEC CHDHLAGMCKI, GDLAFIILODC<Delegate> BNECONOIKOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	private class PDOHHDOFIIM : Property<NBNHELBHBEC, GDLAFIILODC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string OFMLOIDKMDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x826E750", Offset = "0x826D550", VA = "0x18826E750", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool ECOGGGAIBMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x826E710", Offset = "0x826D510", VA = "0x18826E710")]
		public PDOHHDOFIIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x826E6C0", Offset = "0x826D4C0", VA = "0x18826E6C0", Slot = "14")]
		public override GDLAFIILODC<Delegate> GetValue(NBNHELBHBEC CHDHLAGMCKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x826E6E0", Offset = "0x826D4E0", VA = "0x18826E6E0", Slot = "15")]
		public override void SetValue(NBNHELBHBEC CHDHLAGMCKI, GDLAFIILODC<Delegate> BNECONOIKOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	private class MMFIIEOOPPE : Property<NBNHELBHBEC, GDLAFIILODC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string OFMLOIDKMDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x826DFF0", Offset = "0x826CDF0", VA = "0x18826DFF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool ECOGGGAIBMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x826DFB0", Offset = "0x826CDB0", VA = "0x18826DFB0")]
		public MMFIIEOOPPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x826DF60", Offset = "0x826CD60", VA = "0x18826DF60", Slot = "14")]
		public override GDLAFIILODC<Delegate> GetValue(NBNHELBHBEC CHDHLAGMCKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x826DF80", Offset = "0x826CD80", VA = "0x18826DF80", Slot = "15")]
		public override void SetValue(NBNHELBHBEC CHDHLAGMCKI, GDLAFIILODC<Delegate> BNECONOIKOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	private class DNOMKHKPPEC : Property<NBNHELBHBEC, GDLAFIILODC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string OFMLOIDKMDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x826C240", Offset = "0x826B040", VA = "0x18826C240", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool ECOGGGAIBMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x826C200", Offset = "0x826B000", VA = "0x18826C200")]
		public DNOMKHKPPEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x826C1B0", Offset = "0x826AFB0", VA = "0x18826C1B0", Slot = "14")]
		public override GDLAFIILODC<Delegate> GetValue(NBNHELBHBEC CHDHLAGMCKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x826C1D0", Offset = "0x826AFD0", VA = "0x18826C1D0", Slot = "15")]
		public override void SetValue(NBNHELBHBEC CHDHLAGMCKI, GDLAFIILODC<Delegate> BNECONOIKOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	private class GIGBMOJOCEN : Property<NBNHELBHBEC, GDLAFIILODC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string OFMLOIDKMDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x826D270", Offset = "0x826C070", VA = "0x18826D270", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool ECOGGGAIBMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x826D230", Offset = "0x826C030", VA = "0x18826D230")]
		public GIGBMOJOCEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x826D1E0", Offset = "0x826BFE0", VA = "0x18826D1E0", Slot = "14")]
		public override GDLAFIILODC<Delegate> GetValue(NBNHELBHBEC CHDHLAGMCKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x826D200", Offset = "0x826C000", VA = "0x18826D200", Slot = "15")]
		public override void SetValue(NBNHELBHBEC CHDHLAGMCKI, GDLAFIILODC<Delegate> BNECONOIKOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	private class GBKDJJADHJC : Property<NBNHELBHBEC, GDLAFIILODC<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string OFMLOIDKMDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x826C970", Offset = "0x826B770", VA = "0x18826C970", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool ECOGGGAIBMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x826C930", Offset = "0x826B730", VA = "0x18826C930")]
		public GBKDJJADHJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x826C8E0", Offset = "0x826B6E0", VA = "0x18826C8E0", Slot = "14")]
		public override GDLAFIILODC<Delegate> GetValue(NBNHELBHBEC CHDHLAGMCKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x826C900", Offset = "0x826B700", VA = "0x18826C900", Slot = "15")]
		public override void SetValue(NBNHELBHBEC CHDHLAGMCKI, GDLAFIILODC<Delegate> BNECONOIKOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x826CB80", Offset = "0x826B980", VA = "0x18826CB80")]
	public GHIFHEBCOEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class AHPOAGKGCHA : ContainerPropertyBag<GDLAFIILODC<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x826BDE0", Offset = "0x826ABE0", VA = "0x18826BDE0")]
	public AHPOAGKGCHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal class FMNDAEMMGLH : ContainerPropertyBag<EHJNILFGKMO>
{
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	private class LNPBCPJMHBL : Property<EHJNILFGKMO, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string OFMLOIDKMDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x826DCC0", Offset = "0x826CAC0", VA = "0x18826DCC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool ECOGGGAIBMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x826DC80", Offset = "0x826CA80", VA = "0x18826DC80")]
		public LNPBCPJMHBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x826C270", Offset = "0x826B070", VA = "0x18826C270", Slot = "14")]
		public override Rigidbody GetValue(EHJNILFGKMO CHDHLAGMCKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x826C290", Offset = "0x826B090", VA = "0x18826C290", Slot = "15")]
		public override void SetValue(EHJNILFGKMO CHDHLAGMCKI, Rigidbody BNECONOIKOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x826C6B0", Offset = "0x826B4B0", VA = "0x18826C6B0")]
	public FMNDAEMMGLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal class LHKIPEEHDLC : ContainerPropertyBag<EKNCCFOALFH>
{
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	private class KGEFNHLFCMA : Property<EKNCCFOALFH, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string OFMLOIDKMDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x826D9F0", Offset = "0x826C7F0", VA = "0x18826D9F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool ECOGGGAIBMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x826D9B0", Offset = "0x826C7B0", VA = "0x18826D9B0")]
		public KGEFNHLFCMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x826C270", Offset = "0x826B070", VA = "0x18826C270", Slot = "14")]
		public override object GetValue(EKNCCFOALFH CHDHLAGMCKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x826C290", Offset = "0x826B090", VA = "0x18826C290", Slot = "15")]
		public override void SetValue(EKNCCFOALFH CHDHLAGMCKI, object BNECONOIKOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x826DB20", Offset = "0x826C920", VA = "0x18826DB20")]
	public LHKIPEEHDLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal class GFHMHMFABGP : ContainerPropertyBag<JMPOKHHGAPG>
{
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	private class KDMNKMHJHPC : Property<JMPOKHHGAPG, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string OFMLOIDKMDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x826D980", Offset = "0x826C780", VA = "0x18826D980", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool ECOGGGAIBMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x826D940", Offset = "0x826C740", VA = "0x18826D940")]
		public KDMNKMHJHPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x826C270", Offset = "0x826B070", VA = "0x18826C270", Slot = "14")]
		public override object GetValue(JMPOKHHGAPG CHDHLAGMCKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x826C290", Offset = "0x826B090", VA = "0x18826C290", Slot = "15")]
		public override void SetValue(JMPOKHHGAPG CHDHLAGMCKI, object BNECONOIKOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x826C9A0", Offset = "0x826B7A0", VA = "0x18826C9A0")]
	public GFHMHMFABGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
internal class PIIFBGILKIO : ContainerPropertyBag<KNBLECDJKNI>
{
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	private class LMMNMKAFIGL : Property<KNBLECDJKNI, Entity>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string OFMLOIDKMDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x826DC50", Offset = "0x826CA50", VA = "0x18826DC50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool ECOGGGAIBMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x826DC10", Offset = "0x826CA10", VA = "0x18826DC10")]
		public LMMNMKAFIGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xABF370", Offset = "0xABE170", VA = "0x180ABF370", Slot = "14")]
		public override Entity GetValue(KNBLECDJKNI CHDHLAGMCKI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x826DC00", Offset = "0x826CA00", VA = "0x18826DC00", Slot = "15")]
		public override void SetValue(KNBLECDJKNI CHDHLAGMCKI, Entity BNECONOIKOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x826E780", Offset = "0x826D580", VA = "0x18826E780")]
	public PIIFBGILKIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
internal class GMPGLOJCKKL : ContainerPropertyBag<Entity>
{
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	private class HAIAGBEAFHN : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string OFMLOIDKMDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x826D5A0", Offset = "0x826C3A0", VA = "0x18826D5A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool ECOGGGAIBMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x826D560", Offset = "0x826C360", VA = "0x18826D560")]
		public HAIAGBEAFHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x23EB140", Offset = "0x23E9F40", VA = "0x1823EB140", Slot = "14")]
		public override int GetValue(Entity CHDHLAGMCKI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8063430", Offset = "0x8062230", VA = "0x188063430", Slot = "15")]
		public override void SetValue(Entity CHDHLAGMCKI, int BNECONOIKOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	private class GMOMHHIMMOA : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string OFMLOIDKMDO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x826D2F0", Offset = "0x826C0F0", VA = "0x18826D2F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool ECOGGGAIBMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x826D2B0", Offset = "0x826C0B0", VA = "0x18826D2B0")]
		public GMOMHHIMMOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1340A90", Offset = "0x133F890", VA = "0x181340A90", Slot = "14")]
		public override int GetValue(Entity CHDHLAGMCKI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x826D2A0", Offset = "0x826C0A0", VA = "0x18826D2A0", Slot = "15")]
		public override void SetValue(Entity CHDHLAGMCKI, int BNECONOIKOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x826D320", Offset = "0x826C120", VA = "0x18826D320")]
	public GMPGLOJCKKL()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x826E920", Offset = "0x826D720", VA = "0x18826E920")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public class GNLNCCKEALF
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public GNLNCCKEALF()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public class RbexHierarchyParentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public class RbexHierarchyChildBuffer
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
