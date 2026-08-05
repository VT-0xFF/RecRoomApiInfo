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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E287C0", Offset = "0x7E279C0", VA = "0x187E287C0", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7E28B50", Offset = "0x7E27D50", VA = "0x187E28B50", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2675970", Offset = "0x2674B70", VA = "0x182675970")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
[TypeManager.ForcedStableTypeHash(1586941204353847852uL)]
public struct JGIGDBGHAOH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
[TypeManager.ForcedStableTypeHash(1730701010008160003uL)]
public struct FGABHFNHOGO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
[TypeManager.ForcedStableTypeHash(3399609037308777919uL)]
public struct ILPIKEGMEFC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
[TypeManager.ForcedStableTypeHash(18083619841998483100uL)]
public struct IHLEEOAGHKJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
[TypeManager.ForcedStableTypeHash(12361415346715948123uL)]
public struct DBMIAPLPHDP : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[TypeManager.ForcedStableTypeHash(15820941866177188261uL)]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : IBufferElementData, IEquatable<AuthoredChildBuffer>, DBHDPPKALIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7E25890", Offset = "0x7E24A90", VA = "0x187E25890", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
[TypeManager.ForcedStableTypeHash(7794731847884836165uL)]
public struct MFNKLJBIBIJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
[TypeManager.ForcedStableTypeHash(16414266906034106824uL)]
public struct JICILBEGOAE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[TypeManager.ForcedStableTypeHash(1525018888797798356uL)]
public struct ONAKGIDOHEA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Entity LOAIFFEFICO;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[TypeManager.ForcedStableTypeHash(6294257411443737851uL)]
public struct ODKFANPALMI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity LOAIFFEFICO;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct CCGJHCPIDHJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<OFFGCFMOPPD> MALJMAFIKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<Entity> BAIJNLNDOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private JobHandle EOJDBKLNAOP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool CGPGHNNJOHG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7E25DA0", Offset = "0x7E24FA0", VA = "0x187E25DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int FAGABNHAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7E25E10", Offset = "0x7E25010", VA = "0x187E25E10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5C178A0", Offset = "0x5C16AA0", VA = "0x185C178A0")]
	public CCGJHCPIDHJ(NativeList<OFFGCFMOPPD> MALJMAFIKPF, NativeList<Entity> BAIJNLNDOKO, JobHandle EOJDBKLNAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7E25C80", Offset = "0x7E24E80", VA = "0x187E25C80")]
	public (Entity, NativeSlice<Entity>) HNKBAFKJLCP(int EOIAPGKFGAB)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7E25C20", Offset = "0x7E24E20", VA = "0x187E25C20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct OFFGCFMOPPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Entity FHPKLENNKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int OEBFFKLMAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int LMMGFKFHEJP;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface OCAJMGFGBPK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJIEMPJIIFN(bool FENCFBDODPO);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct LHGJHLHCDPK : IEquatable<LHGJHLHCDPK>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate bool FDCICECFAFG(int NAJOEFDLOFP);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly bool IIKIMNNDJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool NDFGBPMPMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool NOPPJGCHNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool NEIJPDAAEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly FDCICECFAFG EGGEOFNELIJ;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7E274B0", Offset = "0x7E266B0", VA = "0x187E274B0")]
	public LHGJHLHCDPK(PFDCBFKJOFO MJJLCGKEEJD, FDCICECFAFG EGGEOFNELIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7E27480", Offset = "0x7E26680", VA = "0x187E27480")]
	public LHGJHLHCDPK(bool IIKIMNNDJAO, bool NDFGBPMPMCJ, bool NOPPJGCHNOI, bool NEIJPDAAEAB, FDCICECFAFG EGGEOFNELIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7E27190", Offset = "0x7E26390", VA = "0x187E27190")]
	public bool CKAPJGALAKA(int NAJOEFDLOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7E273C0", Offset = "0x7E265C0", VA = "0x187E273C0")]
	public bool IGGNCNPCGEC(int NAJOEFDLOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7E271C0", Offset = "0x7E263C0", VA = "0x187E271C0")]
	public bool CMEFHKFJECH(int NAJOEFDLOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7E272F0", Offset = "0x7E264F0", VA = "0x187E272F0")]
	public bool FECDJCECACN(int NAJOEFDLOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7E27210", Offset = "0x7E26410", VA = "0x187E27210", Slot = "4")]
	public bool Equals(LHGJHLHCDPK FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7E27240", Offset = "0x7E26440", VA = "0x187E27240", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7E27320", Offset = "0x7E26520", VA = "0x187E27320", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7E271F0", Offset = "0x7E263F0", VA = "0x187E271F0")]
	private bool DOBBNNNPGHG(int NAJOEFDLOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7E273F0", Offset = "0x7E265F0", VA = "0x187E273F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(14250400792429278320uL)]
public struct GJEABBHDNIH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(14910416840255214023uL)]
public struct CJEKMDGGOFL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
[TypeManager.ForcedStableTypeHash(10891474712127242783uL)]
public struct NECBMKLNFEK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[InternalBufferCapacity(17)]
[TypeManager.ForcedStableTypeHash(613937678496137215uL)]
public struct IFCOLDJINIP : IBufferElementData, IEquatable<IFCOLDJINIP>, DBHDPPKALIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity NCMJKLKGNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public int OIKCJAGJBDC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private Entity BOCPFBFAJPO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7E26C40", Offset = "0x7E25E40", VA = "0x187E26C40", Slot = "4")]
	public bool Equals(IFCOLDJINIP FNJGMJGALLH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class OAKMEIAGOKG : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public MLGJPNMDKJP DLGFIMAKDIN;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7E27980", Offset = "0x7E26B80", VA = "0x187E27980", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public OAKMEIAGOKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface MLGJPNMDKJP
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(1690080301203719739uL)]
public struct FJEJKBCFIGP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[TypeManager.ForcedStableTypeHash(13667964378929084748uL)]
public readonly struct LPNLLHDCAOG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly NKEAJGLMJCN LMDJNJCCJAG;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2E13DC0", Offset = "0x2E12FC0", VA = "0x182E13DC0")]
	public LPNLLHDCAOG(NKEAJGLMJCN LMDJNJCCJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7E275C0", Offset = "0x7E267C0", VA = "0x187E275C0")]
	public LPNLLHDCAOG LAAJBNGFBCB(NKEAJGLMJCN OGFNDKLOFID)
	{
		return default(LPNLLHDCAOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7E275D0", Offset = "0x7E267D0", VA = "0x187E275D0")]
	public LPNLLHDCAOG LBDCPFONFKJ(NKEAJGLMJCN IBIDBKCEMIA)
	{
		return default(LPNLLHDCAOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7E275E0", Offset = "0x7E267E0", VA = "0x187E275E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[Flags]
public enum NKEAJGLMJCN : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	HasShapeChildren = 1,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	HasEmbodiedChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	HasColliders = 4,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	HasObjectBoard = 8,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	HasUserTags = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	IsInScope = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	IsScopeRoot = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	IsRootObject = 0x80,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	TestEmbodiment = 0x100,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	All = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class CAALLLMMDCL
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(1995886936411817354uL)]
[SingletonComponent]
public struct JNNAJLENLEH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NKEAJGLMJCN MHOPGAJCMBE;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7E26DF0", Offset = "0x7E25FF0", VA = "0x187E26DF0")]
	public bool ELHMKNIFOJJ(LPNLLHDCAOG MMLIHGNBOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7E26E00", Offset = "0x7E26000", VA = "0x187E26E00")]
	public bool PKPBJIOALCP(LPNLLHDCAOG MMLIHGNBOOJ, NKEAJGLMJCN HNLIOBHFNEH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[Flags]
public enum NEICBBDCLIH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(12096894998449299302uL)]
public struct ODALMFNFHEG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NEICBBDCLIH LMDJNJCCJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public bool OOGGNNHEGPL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool CINHHNJOFIN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7E27A60", Offset = "0x7E26C60", VA = "0x187E27A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7E27AB0", Offset = "0x7E26CB0", VA = "0x187E27AB0")]
	private ODALMFNFHEG(NEICBBDCLIH LMDJNJCCJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7E27A70", Offset = "0x7E26C70", VA = "0x187E27A70")]
	public ODALMFNFHEG LAAJBNGFBCB(NEICBBDCLIH OGFNDKLOFID)
	{
		return default(ODALMFNFHEG);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7E27A90", Offset = "0x7E26C90", VA = "0x187E27A90")]
	public ODALMFNFHEG LBDCPFONFKJ(NEICBBDCLIH IBIDBKCEMIA)
	{
		return default(ODALMFNFHEG);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
[TypeManager.ForcedStableTypeHash(3210980466644930997uL)]
public struct PBLAGEEHABN : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[InternalBufferCapacity(1)]
	[TypeManager.ForcedStableTypeHash(8887160633523457935uL)]
	public struct NetworkedEntityBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public Entity entity;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[TypeManager.ForcedStableTypeHash(2308769520679974324uL)]
public struct KOJENGBLHHN : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity BIGIOMGDMIM;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[InternalBufferCapacity(8)]
	[TypeManager.ForcedStableTypeHash(2803523268494646145uL)]
	public struct ChildBuffer : IBufferElementData, IEquatable<ChildBuffer>, DBHDPPKALIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7E25890", Offset = "0x7E24A90", VA = "0x187E25890", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6734819606313844273uL)]
public struct KJNCNNNEKHL : ISystemStateBufferElementData, IBufferElementData, DBHDPPKALIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public Entity LBPCFJCJDPM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Entity PDLFACMOJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[TypeManager.ForcedStableTypeHash(10606242260416974827uL)]
public struct PKGPPGJHHNL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public Entity IMJOHOOBKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public Entity GBPAMGJOGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Entity ANBCBEDONNC;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct OPHGMPGODAO<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly bool KJALJJOFOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public uint FIJECBIPCHN;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool DMGBCPACMFE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[TypeManager.ForcedStableTypeHash(14518013333183728344uL)]
[TypeManager.TypeVersion(2)]
public struct NIAGBFEGOLJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public uint IACAEIGMNKN;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x12B95B0", Offset = "0x12B87B0", VA = "0x1812B95B0")]
	public NIAGBFEGOLJ(KOAGADGMKNF CBKIOLAOLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7E27950", Offset = "0x7E26B50", VA = "0x187E27950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1E7A8E0", Offset = "0x1E79AE0", VA = "0x181E7A8E0")]
	public static NIAGBFEGOLJ NEKLFDMHCNA(KOAGADGMKNF CBKIOLAOLGG)
	{
		return default(NIAGBFEGOLJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[TypeManager.ForcedStableTypeHash(12631852336897389638uL)]
public struct FMGCCPEIBMF : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Entity LBPCFJCJDPM;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[TypeManager.ForcedStableTypeHash(8586426759787957142uL)]
public struct PINHCNBCJJB : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public KOAGADGMKNF MLCDCHNOCFI;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[TypeManager.ForcedStableTypeHash(3916218676170013300uL)]
public struct AAOKAOBKJOD : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Entity LBPCFJCJDPM;
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[TypeManager.ForcedStableTypeHash(3395423174463894753uL)]
public struct BGLHGJFEBHG : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Guid DIHOLCNHIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int KIFHGDECLNI;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[TypeManager.ForcedStableTypeHash(13485578171010875955uL)]
public struct MEGOOMDJBMG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public int MLCDCHNOCFI;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[TypeManager.ForcedStableTypeHash(11182407275731589027uL)]
public struct IHPPCADAKMB : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Entity LBPCFJCJDPM;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[TypeManager.ForcedStableTypeHash(238571310055566811uL)]
public struct ANJNICAIAEJ : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public KOAGADGMKNF MLCDCHNOCFI;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[TypeManager.ForcedStableTypeHash(17943708062286791581uL)]
public struct FCLBGIFHOFO : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Entity LBPCFJCJDPM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
[TypeManager.ForcedStableTypeHash(17717774548790709874uL)]
public struct FFNIAMCFAMF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(1628423395607207516uL)]
public struct AGABGCGLMKC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int CBDEIEDEEKK;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[TypeManager.ForcedStableTypeHash(6255673600552782006uL)]
public struct COKEEJODMDH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int KOCMKKLCMKL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public MMNMPKDPAGK LCNGJOONIBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0B0", Offset = "0xA3C2B0", VA = "0x180A3D0B0")]
		get
		{
			return default(MMNMPKDPAGK);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[TypeManager.ForcedStableTypeHash(7921165883083593916uL)]
public struct PGKDAAIKONI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public GCHandle JGFJPGELBKC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
[TypeManager.ForcedStableTypeHash(14965811366685608319uL)]
public struct AFCPOOOFMKA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
[TypeManager.ForcedStableTypeHash(8376615066990205632uL)]
public struct ONCIOLMFELF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
[TypeManager.ForcedStableTypeHash(7273320061473429398uL)]
public struct KDPNOICGDFD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
[TypeManager.ForcedStableTypeHash(15140206241145976177uL)]
public struct ONADEGBLNBF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000039")]
[TypeManager.ForcedStableTypeHash(15969631250552901108uL)]
public struct OHGEBABGDDA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[TypeManager.ForcedStableTypeHash(9353178840587053763uL)]
public struct BCALPEMIHDP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public int NIBICIJAIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public int COBPGHDNJHM;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7E258A0", Offset = "0x7E24AA0", VA = "0x187E258A0")]
	public BCALPEMIHDP(Entity LBPCFJCJDPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[TypeManager.ForcedStableTypeHash(16229383422209788655uL)]
public struct CJMGANIHGCM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public CollisionDetectionMode IPFHOMPHHKD;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[TypeManager.ForcedStableTypeHash(5173865590150727846uL)]
[RegisterComponentDefault]
public struct HAECGFJLFHF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public MIPMLGOBAHP AKLOFHLEJHM;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly HAECGFJLFHF EMOEMPAFHHF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003D")]
[TypeManager.ForcedStableTypeHash(7051356195299730219uL)]
public struct PKEHDIHGKJB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003E")]
[TypeManager.ForcedStableTypeHash(780557526766205634uL)]
public struct CFBGMJAGCHK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003F")]
[TypeManager.ForcedStableTypeHash(16413322458062516985uL)]
public struct CCEHALFHINB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[TypeManager.ForcedStableTypeHash(8350832327674051347uL)]
[InternalBufferCapacity(0)]
public struct FJMFPBHDILE : IBufferElementData, IEquatable<FJMFPBHDILE>, DBHDPPKALIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Entity NCMJKLKGNMA;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity BOCPFBFAJPO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7E25890", Offset = "0x7E24A90", VA = "0x187E25890", Slot = "4")]
	public bool Equals(FJMFPBHDILE FNJGMJGALLH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[TypeManager.ForcedStableTypeHash(3503423083784418805uL)]
public struct OIPAHAJNDMH : IComponentData, DBHDPPKALIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Entity NJHDJGHEICO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Entity BOCPFBFAJPO
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000042")]
[TypeManager.ForcedStableTypeHash(14551834985136520975uL)]
public struct CNCPHFMLINA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[TypeManager.ForcedStableTypeHash(4388378139562737487uL)]
public struct OAJEENPPCFN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Entity FHPKLENNKKO;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct MMLOCJFGPKI : MBNOMAAFELG, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public JBEKFECHPDC NNBLIKHGNEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(JBEKFECHPDC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[TypeManager.ForcedStableTypeHash(769086036388751339uL)]
public struct OJMCAKIMKDE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float3 NIFOKABFMPO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
[TypeManager.ForcedStableTypeHash(15638082890667179775uL)]
public struct BFKKMFHGNMJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(7040629969868025973uL)]
public struct APNIDPDJIAN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public float3x3 CHDEGPGGKBM;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly APNIDPDJIAN EMOEMPAFHHF;
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(1290915447730818204uL)]
public struct CBKENINCNAK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float3x3 CHDEGPGGKBM;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly CBKENINCNAK EMOEMPAFHHF;
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[TypeManager.ForcedStableTypeHash(7667208078276643555uL)]
public struct BODCMJDMHPN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float3 MOIGFIKHLEN;
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[TypeManager.ForcedStableTypeHash(11475279934298573286uL)]
public struct PKPIPBMOKLG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public float3 AMGNIOPNKJN;
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(18413785019621221410uL)]
public struct CIAAIDPIKJD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public float EAEBJMDFJNO;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly CIAAIDPIKJD EMOEMPAFHHF;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(16788150452972582455uL)]
public struct JIBJCLFHNLO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float ICNFBBBPHCP;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly JIBJCLFHNLO EMOEMPAFHHF;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[TypeManager.ForcedStableTypeHash(971312552983123380uL)]
public struct JAKIFGJAFIK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public float3 FMDFCPBCAOG;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[TypeManager.ForcedStableTypeHash(361641396811542242uL)]
public struct COOMKLNJOKL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public IAGAFLNEHEJ IFBOOMJGNNP;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[TypeManager.ForcedStableTypeHash(7520974846918069913uL)]
[SingletonComponent]
public struct NICBCAHFJBI : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Entity LBPCFJCJDPM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
[TypeManager.ForcedStableTypeHash(9260549625364734686uL)]
public struct ELKPICPDHPF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
[TypeManager.ForcedStableTypeHash(469905343419662571uL)]
public struct FPFHFAFMOMH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[TypeManager.ForcedStableTypeHash(7865784707562564105uL)]
public struct HAEACDJEPPA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public RigidbodyConstraints OALBEPLKKHF;
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(7877027338327956319uL)]
public struct FPMHNMJCLND : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public float DNCIBLPJEBK;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly FPMHNMJCLND EMOEMPAFHHF;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[TypeManager.ForcedStableTypeHash(935406425377786813uL)]
public struct MECOPOOJBIC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float KANBCHFHAMH;
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class LILJEKFCBDO : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GameObject GNOLFLMODHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public object GCELGGFODPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public object EADFHKDNNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public GHFHANGICMB EADLIFECOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public Delegate IAOEKBACKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Delegate ILGHFJDHLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public GBAADKKOBIK<Delegate> AFLENOMLHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public GBAADKKOBIK<Delegate> GPAEFOGDFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public GBAADKKOBIK<Delegate> DDJCEGKAFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public GBAADKKOBIK<Delegate> HFGCCCGPBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public GBAADKKOBIK<Delegate> OGPEFGILGBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public GBAADKKOBIK<Delegate> FEDFFEMGCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public GBAADKKOBIK<Delegate> JMIBCLAPAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public GBAADKKOBIK<Delegate> IPKHMGEBJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public GBAADKKOBIK<Delegate> KAJBKGEEMEF;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7E27500", Offset = "0x7E26700", VA = "0x187E27500", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public LILJEKFCBDO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
[TypeManager.ForcedStableTypeHash(18165447863202358792uL)]
public struct NCBGOOHDLJG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[TypeManager.ForcedStableTypeHash(10810926406358250264uL)]
public struct FLONNAKCDCA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public int CDBJCHNNEKD;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1E7A8E0", Offset = "0x1E79AE0", VA = "0x181E7A8E0")]
	public static FLONNAKCDCA NEKLFDMHCNA(int MLCDCHNOCFI)
	{
		return default(FLONNAKCDCA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class CDPDJGEJBPC : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Rigidbody CIIHNEDACOI;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7E25E60", Offset = "0x7E25060", VA = "0x187E25E60", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public CDPDJGEJBPC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
[TypeManager.ForcedStableTypeHash(12765569839950265583uL)]
public struct OKELEEOCCGK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[TypeManager.ForcedStableTypeHash(17236748096909814533uL)]
public struct BNGKNMLDDNL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 HNMBFFBJHEC;
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[TypeManager.ForcedStableTypeHash(1288392478539867023uL)]
public struct JINAPGCBJNB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float3 JONPFBFHNDO;
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(15102898512288820575uL)]
public struct PCGPFPBOMGC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float MJCECBELNNP;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly PCGPFPBOMGC EMOEMPAFHHF;
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class DLAOEIBOPLG : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public object DLPFHINFCLB;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7E260D0", Offset = "0x7E252D0", VA = "0x187E260D0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public DLAOEIBOPLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class CNLKDKILMHK : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public object JIFJMEOIEFA;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7E25FA0", Offset = "0x7E251A0", VA = "0x187E25FA0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public CNLKDKILMHK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
[TypeManager.ForcedStableTypeHash(3505189951659289292uL)]
public struct GKOFNIIAIJP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
[TypeManager.ForcedStableTypeHash(16217323095468023009uL)]
public struct DDLLHPMAFIN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
[TypeManager.ForcedStableTypeHash(12880717127246424414uL)]
public struct CAPJKPAHJPJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[TypeManager.ForcedStableTypeHash(12942629461400744171uL)]
public struct PIHPFBNBPLK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
[TypeManager.ForcedStableTypeHash(10226241216405964379uL)]
public struct BGCNLIIFOCM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
[TypeManager.ForcedStableTypeHash(12400259538654257671uL)]
public struct DKCFJOFCOGK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
[TypeManager.ForcedStableTypeHash(12731949941800560397uL)]
public struct JBBCGEPOOBG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
[TypeManager.ForcedStableTypeHash(16270799832065682331uL)]
public struct EDHIFEMPHDE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
[TypeManager.ForcedStableTypeHash(9395080039644288849uL)]
public struct NGPEPFIFOGA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[TypeManager.ForcedStableTypeHash(282623311697096978uL)]
public struct CMNDBFHMPBN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public MAEKCOICONB NHJLLPIJPJG;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7E25F50", Offset = "0x7E25150", VA = "0x187E25F50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
[TypeManager.ForcedStableTypeHash(10395819776101408141uL)]
public struct ODGDCHDGCBD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
[TypeManager.ForcedStableTypeHash(375953524326549120uL)]
public struct JDGDPAHKOFO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
[TypeManager.ForcedStableTypeHash(14259779488802476986uL)]
public struct NDPDCNGGAKI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[TypeManager.ForcedStableTypeHash(15330221065042235480uL)]
public struct GFGCNLOLBED : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public FixedString32Bytes DGIAFBEDPNJ;
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(5162925656869367991uL)]
public struct CJADJECDFIL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public UnsafeParallelHashMap<MAEKCOICONB, Entity> DCPIHBCBDOD;
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[TypeManager.ForcedStableTypeHash(9841032716800521808uL)]
public struct DGNFOIPLPMA : ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Entity HBGPNCKCAME;
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[TypeManager.ForcedStableTypeHash(154813247653871879uL)]
internal struct PCBLIFELGDP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Entity LBPCFJCJDPM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900")]
	public static PCBLIFELGDP NEKLFDMHCNA(Entity LBPCFJCJDPM)
	{
		return default(PCBLIFELGDP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[TypeManager.ForcedStableTypeHash(11656653634719673845uL)]
public struct DGJPNDBHAIB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Entity CHILCPJABNH;
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[TypeManager.ForcedStableTypeHash(1837719173092935466uL)]
public struct PBIKALFOODC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity CHILCPJABNH;
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[TypeManager.ForcedStableTypeHash(17382237360022739174uL)]
internal struct EHPHMKIPFKD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Entity NEBEFIGHABL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900")]
	public static EHPHMKIPFKD NEKLFDMHCNA(Entity LBPCFJCJDPM)
	{
		return default(EHPHMKIPFKD);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
[TypeManager.ForcedStableTypeHash(15858722173278118533uL)]
internal struct MNNOKGBENMO : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[TypeManager.ForcedStableTypeHash(10313790595830381076uL)]
public struct KPPKEBBEFPF : IBufferElementData, IEquatable<KPPKEBBEFPF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Entity MNMEPCPNPFA;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7C45F70", Offset = "0x7C45170", VA = "0x187C45F70", Slot = "4")]
	public bool Equals(KPPKEBBEFPF FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7E27080", Offset = "0x7E26280", VA = "0x187E27080", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xA3D0B0", Offset = "0xA3C2B0", VA = "0x180A3D0B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[TypeManager.ForcedStableTypeHash(10169361040328370708uL)]
public struct AFAEOFGFGHD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public uint COBPGHDNJHM;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(11536226225076729790uL)]
internal struct BHIMHCKFOFN : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Entity GBPLADNDALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public int NIBICIJAIGM;
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[TypeManager.ForcedStableTypeHash(8309037880064337491uL)]
internal struct BJKHFAOBBHA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public Entity KGNMGMAIJAA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
[TypeManager.ForcedStableTypeHash(5891816987223099091uL)]
public struct OLFGDJKAANE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[TypeManager.ForcedStableTypeHash(17289298604600812224uL)]
public struct CPLOKDJFGPG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public uint FIJECBIPCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int JCABMDIJFIE;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xD3B560", Offset = "0xD3A760", VA = "0x180D3B560")]
	public CPLOKDJFGPG(uint JCPMDDHDIJH, int FCDHLDAHEBF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
[TypeManager.ForcedStableTypeHash(12258100538258701401uL)]
public struct AIKJGFLLNKE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
[TypeManager.ForcedStableTypeHash(3081870877980445988uL)]
public struct AHMKFABOPLN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
[TypeManager.ForcedStableTypeHash(15554741495161407507uL)]
public struct BMCDPHMBFIM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
[TypeManager.ForcedStableTypeHash(17684057078056878475uL)]
public struct IOBBIIBDHAB : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
[TypeManager.ForcedStableTypeHash(10023455309444528896uL)]
public struct FINFDEKGHGB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
[TypeManager.ForcedStableTypeHash(14403752119546393228uL)]
public struct MELKNJDJBHG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
[TypeManager.ForcedStableTypeHash(9219181242087356214uL)]
public struct KIHJEMIOMLD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
[TypeManager.ForcedStableTypeHash(12371658133244024718uL)]
public struct DAIEAEOCKOK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
[TypeManager.ForcedStableTypeHash(9351414359236295489uL)]
public struct BHHEMGLBJNL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
[TypeManager.ForcedStableTypeHash(12796707860320869007uL)]
internal struct BEIBJLHPLCI : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
[TypeManager.ForcedStableTypeHash(13367368557807690484uL)]
public struct KIGKONHAOJG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000085")]
[TypeManager.ForcedStableTypeHash(7193071459223094579uL)]
public struct LFECCFANPFB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
[TypeManager.ForcedStableTypeHash(15247343901949961769uL)]
public struct FICHIDFFBOL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
[TypeManager.ForcedStableTypeHash(5381043565870728787uL)]
public struct HAFGPIGGKMC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
[TypeManager.ForcedStableTypeHash(11597028615900234104uL)]
internal struct LBKPENINGDL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
[TypeManager.ForcedStableTypeHash(1907494159895213433uL)]
internal struct HOKLNGNHPIL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
[TypeManager.ForcedStableTypeHash(3955886960983597628uL)]
public struct LGENJBAELLC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
[TypeManager.ForcedStableTypeHash(480620745253244652uL)]
public struct CKEACCGBFMM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008C")]
[TypeManager.ForcedStableTypeHash(8253675824478287824uL)]
public struct KJBBOJADLOL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
[TypeManager.ForcedStableTypeHash(8855488771047251567uL)]
public struct LLAEMLKBCFM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008E")]
[TypeManager.ForcedStableTypeHash(8375777954271012995uL)]
public struct EKOGFKNMPGG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
[TypeManager.ForcedStableTypeHash(16444804027614993581uL)]
public struct JLNNBGLNLHK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
[TypeManager.ForcedStableTypeHash(16177323740107409537uL)]
public struct DABJMNOLOLD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
[TypeManager.ForcedStableTypeHash(11049752089067741804uL)]
public struct MJFMKEAJDOO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000092")]
[TypeManager.ForcedStableTypeHash(1453937769327886583uL)]
public struct HEKIGMIHFID : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000093")]
[TypeManager.ForcedStableTypeHash(800754555681830909uL)]
public struct OHOGLFDGJAM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000094")]
[TypeManager.ForcedStableTypeHash(3336901602667819150uL)]
public struct CCJEMKEIDEN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000095")]
[TypeManager.ForcedStableTypeHash(11809750536411032401uL)]
public struct ENGBKJICEJG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000096")]
[TypeManager.ForcedStableTypeHash(6387004770090400669uL)]
public struct MECELJKOCFC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
[TypeManager.ForcedStableTypeHash(2223159712203397538uL)]
internal struct GNEJDDOKCIK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000098")]
[TypeManager.ForcedStableTypeHash(10153397523300334327uL)]
public struct FLHIJMDBHCO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000099")]
[TypeManager.ForcedStableTypeHash(12983102201306073842uL)]
public struct MCOIICJNELB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
[NHMOHHDAFJK]
[TypeManager.ForcedStableTypeHash(15398959433761599914uL)]
public struct CFMGHIBCDEO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[TypeManager.ForcedStableTypeHash(6605318152550716456uL)]
[SingletonComponent]
public struct JKAOFNABLGD : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public FixedString32Bytes LHAEPBBBCAO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
[TypeManager.ForcedStableTypeHash(10065634662848845784uL)]
public struct NCJIDIEIGDP : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009D")]
[TypeManager.ForcedStableTypeHash(15062299176839263439uL)]
public struct PILJNIKCPLG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009E")]
[TypeManager.ForcedStableTypeHash(3596269116834888123uL)]
internal struct FKFAKKBGDAD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
[TypeManager.ForcedStableTypeHash(4402941654898007496uL)]
internal struct INAGHJJLNGC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[TypeManager.ForcedStableTypeHash(12682474121528142025uL)]
internal struct GGBPLAGPKHB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[TypeManager.ForcedStableTypeHash(1840266485562743455uL)]
public struct ALAKOMIKPKB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[TypeManager.ForcedStableTypeHash(4772574226205567794uL)]
public struct AEAFECGIIGA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[TypeManager.ForcedStableTypeHash(17642911464827038147uL)]
public struct PKKKPAGCHNE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public quaternion PANMBKPFLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float3 BJHAAAPCKLC;
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[TypeManager.ForcedStableTypeHash(9066921186040058989uL)]
public struct HBNCDKLLCPM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float FLPGBFNBNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float PHFPMFOADCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float LIGABAGHAII;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[TypeManager.ForcedStableTypeHash(3328998613642473514uL)]
public struct GILKOMMDAMN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[TypeManager.ForcedStableTypeHash(151116349382904900uL)]
public struct HDDBGKIEBKA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[TypeManager.ForcedStableTypeHash(8067675582152570601uL)]
public struct NDNOKJJAKAD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[TypeManager.ForcedStableTypeHash(4522686316477281096uL)]
public struct PFOLCKEAPJJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public int KOCMKKLCMKL;
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6216404920432680992uL)]
public struct NCNALHDNIMM : ISystemStateBufferElementData, IBufferElementData, DBHDPPKALIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Entity PEABIEGCDFI;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity PDLFACMOJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(419884688393735449uL)]
public struct AAFPOAIDBAG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public float4x4 FIFCDJMEAOK;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly AAFPOAIDBAG EMOEMPAFHHF;
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(1954795745923300919uL)]
public struct ILPNBPPLNHP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public float4x4 HBIIBPNLLIO;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly ILPNBPPLNHP EMOEMPAFHHF;
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[TypeManager.ForcedStableTypeHash(2447627752265109178uL)]
public struct FCAEHLDIBAP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private int BLMKBOCKHGB;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int NIBICIJAIGM
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7E26920", Offset = "0x7E25B20", VA = "0x187E26920")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7E26930", Offset = "0x7E25B30", VA = "0x187E26930")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(13706996280046618062uL)]
public struct AKMPJDPPDFK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public float3 BJHAAAPCKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public quaternion PANMBKPFLFA;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly AKMPJDPPDFK EMOEMPAFHHF;
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public static class NNIOPGMMJPD
{
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(77694943841979493uL)]
public struct CFBLFMFJPHP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public float JJBKHNFBIMD;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly CFBLFMFJPHP EMOEMPAFHHF;
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[TypeManager.ForcedStableTypeHash(6537711325103434903uL)]
public struct NLIEIOFMINE : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Entity DHOGCHOHKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public FKJDPJEKDDH HFFFCKALIAN;
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[TypeManager.ForcedStableTypeHash(5471640964865828061uL)]
public struct GHENHMIDCOE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public FKJDPJEKDDH HFFFCKALIAN;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[TypeManager.ForcedStableTypeHash(16527934868211432802uL)]
public struct EBEEPHKBJLI : ISystemStateComponentData, IComponentData, DBHDPPKALIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Entity FNEFIOJLPDJ;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Entity PDLFACMOJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[TypeManager.ForcedStableTypeHash(15310407062508355916uL)]
public struct GCCKLBDFFBC : ISystemStateBufferElementData, IBufferElementData, DBHDPPKALIP, IEquatable<GCCKLBDFFBC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Entity PNBHNMBPLNH;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Entity PDLFACMOJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7C45F70", Offset = "0x7C45170", VA = "0x187C45F70", Slot = "6")]
	public bool Equals(GCCKLBDFFBC FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7E26A40", Offset = "0x7E25C40", VA = "0x187E26A40", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xA3D0B0", Offset = "0xA3C2B0", VA = "0x180A3D0B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[TypeManager.ForcedStableTypeHash(11786768220100978132uL)]
public struct DKDCFLDOKOA : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Entity DHOGCHOHKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public FKJDPJEKDDH HFFFCKALIAN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public struct NIAAGOOEEFD : IEqualityComparer<DKDCFLDOKOA>
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static NIAAGOOEEFD EMOEMPAFHHF;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7E278A0", Offset = "0x7E26AA0", VA = "0x187E278A0", Slot = "4")]
	public bool Equals(DKDCFLDOKOA CCOLDGJALNH, DKDCFLDOKOA JCBKIOEHCDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7E278F0", Offset = "0x7E26AF0", VA = "0x187E278F0", Slot = "5")]
	public int GetHashCode(DKDCFLDOKOA DBCLNEGBNLN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[TypeManager.ForcedStableTypeHash(8981997360983277121uL)]
public struct CJHNEJDGOAF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public FixedList32Bytes<int> BLGKPGNAIBK;
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[TypeManager.ForcedStableTypeHash(2801212869002544047uL)]
public struct OKIFAIDCKHD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public FixedList32Bytes<int> BLGKPGNAIBK;
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[TypeManager.ForcedStableTypeHash(16455485691096333919uL)]
public struct JPFLCMKLKKA : ISystemStateBufferElementData, IBufferElementData, DBHDPPKALIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public Entity KFKNANKNAHB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Entity BOCPFBFAJPO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xD42150", Offset = "0xD41350", VA = "0x180D42150", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xEEC790", Offset = "0xEEB990", VA = "0x180EEC790", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal class KOADGICGMFI : ContainerPropertyBag<OAKMEIAGOKG>
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private class OHEEMPCMNAI : Property<OAKMEIAGOKG, MLGJPNMDKJP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string BGMICIBNDMA
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7E27B00", Offset = "0x7E26D00", VA = "0x187E27B00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool FDKDJBEEIID
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7E27AC0", Offset = "0x7E26CC0", VA = "0x187E27AC0")]
		public OHEEMPCMNAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7E26200", Offset = "0x7E25400", VA = "0x187E26200", Slot = "14")]
		public override MLGJPNMDKJP GetValue(OAKMEIAGOKG NPCDKJJJIDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7E26220", Offset = "0x7E25420", VA = "0x187E26220", Slot = "15")]
		public override void SetValue(OAKMEIAGOKG NPCDKJJJIDL, MLGJPNMDKJP MLCDCHNOCFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7E26EE0", Offset = "0x7E260E0", VA = "0x187E26EE0")]
	public KOADGICGMFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal class EIMJMFMGLCC : ContainerPropertyBag<LILJEKFCBDO>
{
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	private class GOOGPDGGCFA : Property<LILJEKFCBDO, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string BGMICIBNDMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x7E26BD0", Offset = "0x7E25DD0", VA = "0x187E26BD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool FDKDJBEEIID
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7E26B90", Offset = "0x7E25D90", VA = "0x187E26B90")]
		public GOOGPDGGCFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7E26200", Offset = "0x7E25400", VA = "0x187E26200", Slot = "14")]
		public override GameObject GetValue(LILJEKFCBDO NPCDKJJJIDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7E26220", Offset = "0x7E25420", VA = "0x187E26220", Slot = "15")]
		public override void SetValue(LILJEKFCBDO NPCDKJJJIDL, GameObject MLCDCHNOCFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	private class ANGGKFINFOA : Property<LILJEKFCBDO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string BGMICIBNDMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7E25770", Offset = "0x7E24970", VA = "0x187E25770", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool FDKDJBEEIID
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7E25730", Offset = "0x7E24930", VA = "0x187E25730")]
		public ANGGKFINFOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7E256E0", Offset = "0x7E248E0", VA = "0x187E256E0", Slot = "14")]
		public override object GetValue(LILJEKFCBDO NPCDKJJJIDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7E25700", Offset = "0x7E24900", VA = "0x187E25700", Slot = "15")]
		public override void SetValue(LILJEKFCBDO NPCDKJJJIDL, object MLCDCHNOCFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	private class PJKNOKHLKEO : Property<LILJEKFCBDO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string BGMICIBNDMA
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7E27F20", Offset = "0x7E27120", VA = "0x187E27F20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool FDKDJBEEIID
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7E27EE0", Offset = "0x7E270E0", VA = "0x187E27EE0")]
		public PJKNOKHLKEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7E27E90", Offset = "0x7E27090", VA = "0x187E27E90", Slot = "14")]
		public override object GetValue(LILJEKFCBDO NPCDKJJJIDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7E27EB0", Offset = "0x7E270B0", VA = "0x187E27EB0", Slot = "15")]
		public override void SetValue(LILJEKFCBDO NPCDKJJJIDL, object MLCDCHNOCFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private class KOJICKAAEGM : Property<LILJEKFCBDO, GHFHANGICMB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string BGMICIBNDMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x7E27050", Offset = "0x7E26250", VA = "0x187E27050", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool FDKDJBEEIID
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7E27010", Offset = "0x7E26210", VA = "0x187E27010")]
		public KOJICKAAEGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7E26FC0", Offset = "0x7E261C0", VA = "0x187E26FC0", Slot = "14")]
		public override GHFHANGICMB GetValue(LILJEKFCBDO NPCDKJJJIDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7E26FE0", Offset = "0x7E261E0", VA = "0x187E26FE0", Slot = "15")]
		public override void SetValue(LILJEKFCBDO NPCDKJJJIDL, GHFHANGICMB MLCDCHNOCFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private class BEHEDAAHDJB : Property<LILJEKFCBDO, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string BGMICIBNDMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7E25940", Offset = "0x7E24B40", VA = "0x187E25940", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool FDKDJBEEIID
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7E25900", Offset = "0x7E24B00", VA = "0x187E25900")]
		public BEHEDAAHDJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7E258B0", Offset = "0x7E24AB0", VA = "0x187E258B0", Slot = "14")]
		public override Delegate GetValue(LILJEKFCBDO NPCDKJJJIDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7E258D0", Offset = "0x7E24AD0", VA = "0x187E258D0", Slot = "15")]
		public override void SetValue(LILJEKFCBDO NPCDKJJJIDL, Delegate MLCDCHNOCFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private class EGNIFAPBPLA : Property<LILJEKFCBDO, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string BGMICIBNDMA
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7E261D0", Offset = "0x7E253D0", VA = "0x187E261D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool FDKDJBEEIID
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7E26190", Offset = "0x7E25390", VA = "0x187E26190")]
		public EGNIFAPBPLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7E26140", Offset = "0x7E25340", VA = "0x187E26140", Slot = "14")]
		public override Delegate GetValue(LILJEKFCBDO NPCDKJJJIDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7E26160", Offset = "0x7E25360", VA = "0x187E26160", Slot = "15")]
		public override void SetValue(LILJEKFCBDO NPCDKJJJIDL, Delegate MLCDCHNOCFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private class OPPNJCNEEPL : Property<LILJEKFCBDO, GBAADKKOBIK<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string BGMICIBNDMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7E27D40", Offset = "0x7E26F40", VA = "0x187E27D40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool FDKDJBEEIID
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7E27D00", Offset = "0x7E26F00", VA = "0x187E27D00")]
		public OPPNJCNEEPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7E27CB0", Offset = "0x7E26EB0", VA = "0x187E27CB0", Slot = "14")]
		public override GBAADKKOBIK<Delegate> GetValue(LILJEKFCBDO NPCDKJJJIDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7E27CD0", Offset = "0x7E26ED0", VA = "0x187E27CD0", Slot = "15")]
		public override void SetValue(LILJEKFCBDO NPCDKJJJIDL, GBAADKKOBIK<Delegate> MLCDCHNOCFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private class MKHHLPCHOLD : Property<LILJEKFCBDO, GBAADKKOBIK<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string BGMICIBNDMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x7E27790", Offset = "0x7E26990", VA = "0x187E27790", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool FDKDJBEEIID
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7E27750", Offset = "0x7E26950", VA = "0x187E27750")]
		public MKHHLPCHOLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7E27700", Offset = "0x7E26900", VA = "0x187E27700", Slot = "14")]
		public override GBAADKKOBIK<Delegate> GetValue(LILJEKFCBDO NPCDKJJJIDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7E27720", Offset = "0x7E26920", VA = "0x187E27720", Slot = "15")]
		public override void SetValue(LILJEKFCBDO NPCDKJJJIDL, GBAADKKOBIK<Delegate> MLCDCHNOCFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private class FKPNJAPONJN : Property<LILJEKFCBDO, GBAADKKOBIK<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string BGMICIBNDMA
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7E269D0", Offset = "0x7E25BD0", VA = "0x187E269D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool FDKDJBEEIID
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7E26990", Offset = "0x7E25B90", VA = "0x187E26990")]
		public FKPNJAPONJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7E26940", Offset = "0x7E25B40", VA = "0x187E26940", Slot = "14")]
		public override GBAADKKOBIK<Delegate> GetValue(LILJEKFCBDO NPCDKJJJIDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7E26960", Offset = "0x7E25B60", VA = "0x187E26960", Slot = "15")]
		public override void SetValue(LILJEKFCBDO NPCDKJJJIDL, GBAADKKOBIK<Delegate> MLCDCHNOCFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private class MEFJKDHFKAA : Property<LILJEKFCBDO, GBAADKKOBIK<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string BGMICIBNDMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7E276D0", Offset = "0x7E268D0", VA = "0x187E276D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool FDKDJBEEIID
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7E27690", Offset = "0x7E26890", VA = "0x187E27690")]
		public MEFJKDHFKAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7E27640", Offset = "0x7E26840", VA = "0x187E27640", Slot = "14")]
		public override GBAADKKOBIK<Delegate> GetValue(LILJEKFCBDO NPCDKJJJIDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7E27660", Offset = "0x7E26860", VA = "0x187E27660", Slot = "15")]
		public override void SetValue(LILJEKFCBDO NPCDKJJJIDL, GBAADKKOBIK<Delegate> MLCDCHNOCFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	private class GDLINNDJPKE : Property<LILJEKFCBDO, GBAADKKOBIK<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string BGMICIBNDMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x7E26B60", Offset = "0x7E25D60", VA = "0x187E26B60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool FDKDJBEEIID
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7E26B20", Offset = "0x7E25D20", VA = "0x187E26B20")]
		public GDLINNDJPKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7E26AD0", Offset = "0x7E25CD0", VA = "0x187E26AD0", Slot = "14")]
		public override GBAADKKOBIK<Delegate> GetValue(LILJEKFCBDO NPCDKJJJIDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7E26AF0", Offset = "0x7E25CF0", VA = "0x187E26AF0", Slot = "15")]
		public override void SetValue(LILJEKFCBDO NPCDKJJJIDL, GBAADKKOBIK<Delegate> MLCDCHNOCFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	private class KNMBNAADADH : Property<LILJEKFCBDO, GBAADKKOBIK<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string BGMICIBNDMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x7E26EB0", Offset = "0x7E260B0", VA = "0x187E26EB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool FDKDJBEEIID
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7E26E70", Offset = "0x7E26070", VA = "0x187E26E70")]
		public KNMBNAADADH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7E26E20", Offset = "0x7E26020", VA = "0x187E26E20", Slot = "14")]
		public override GBAADKKOBIK<Delegate> GetValue(LILJEKFCBDO NPCDKJJJIDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7E26E40", Offset = "0x7E26040", VA = "0x187E26E40", Slot = "15")]
		public override void SetValue(LILJEKFCBDO NPCDKJJJIDL, GBAADKKOBIK<Delegate> MLCDCHNOCFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	private class OPDGFKDHMLP : Property<LILJEKFCBDO, GBAADKKOBIK<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string BGMICIBNDMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7E27C80", Offset = "0x7E26E80", VA = "0x187E27C80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool FDKDJBEEIID
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7E27C40", Offset = "0x7E26E40", VA = "0x187E27C40")]
		public OPDGFKDHMLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7E27BF0", Offset = "0x7E26DF0", VA = "0x187E27BF0", Slot = "14")]
		public override GBAADKKOBIK<Delegate> GetValue(LILJEKFCBDO NPCDKJJJIDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7E27C10", Offset = "0x7E26E10", VA = "0x187E27C10", Slot = "15")]
		public override void SetValue(LILJEKFCBDO NPCDKJJJIDL, GBAADKKOBIK<Delegate> MLCDCHNOCFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	private class CPHLNNCDFOE : Property<LILJEKFCBDO, GBAADKKOBIK<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string BGMICIBNDMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7E260A0", Offset = "0x7E252A0", VA = "0x187E260A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool FDKDJBEEIID
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7E26060", Offset = "0x7E25260", VA = "0x187E26060")]
		public CPHLNNCDFOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7E26010", Offset = "0x7E25210", VA = "0x187E26010", Slot = "14")]
		public override GBAADKKOBIK<Delegate> GetValue(LILJEKFCBDO NPCDKJJJIDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7E26030", Offset = "0x7E25230", VA = "0x187E26030", Slot = "15")]
		public override void SetValue(LILJEKFCBDO NPCDKJJJIDL, GBAADKKOBIK<Delegate> MLCDCHNOCFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	private class OJPJOGFKGBA : Property<LILJEKFCBDO, GBAADKKOBIK<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string BGMICIBNDMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7E27BC0", Offset = "0x7E26DC0", VA = "0x187E27BC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool FDKDJBEEIID
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7E27B80", Offset = "0x7E26D80", VA = "0x187E27B80")]
		public OJPJOGFKGBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7E27B30", Offset = "0x7E26D30", VA = "0x187E27B30", Slot = "14")]
		public override GBAADKKOBIK<Delegate> GetValue(LILJEKFCBDO NPCDKJJJIDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7E27B50", Offset = "0x7E26D50", VA = "0x187E27B50", Slot = "15")]
		public override void SetValue(LILJEKFCBDO NPCDKJJJIDL, GBAADKKOBIK<Delegate> MLCDCHNOCFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7E262C0", Offset = "0x7E254C0", VA = "0x187E262C0")]
	public EIMJMFMGLCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal class AMLGJNBBBOE : ContainerPropertyBag<GBAADKKOBIK<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7E25680", Offset = "0x7E24880", VA = "0x187E25680")]
	public AMLGJNBBBOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal class PJDKCMCONKP : ContainerPropertyBag<CDPDJGEJBPC>
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	private class EHCLINPNNKF : Property<CDPDJGEJBPC, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string BGMICIBNDMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7E26290", Offset = "0x7E25490", VA = "0x187E26290", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool FDKDJBEEIID
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7E26250", Offset = "0x7E25450", VA = "0x187E26250")]
		public EHCLINPNNKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7E26200", Offset = "0x7E25400", VA = "0x187E26200", Slot = "14")]
		public override Rigidbody GetValue(CDPDJGEJBPC NPCDKJJJIDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7E26220", Offset = "0x7E25420", VA = "0x187E26220", Slot = "15")]
		public override void SetValue(CDPDJGEJBPC NPCDKJJJIDL, Rigidbody MLCDCHNOCFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7E27DB0", Offset = "0x7E26FB0", VA = "0x187E27DB0")]
	public PJDKCMCONKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal class CAOIFDPPCCL : ContainerPropertyBag<DLAOEIBOPLG>
{
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	private class JGMCGHJPILA : Property<DLAOEIBOPLG, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string BGMICIBNDMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x7E26D80", Offset = "0x7E25F80", VA = "0x187E26D80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool FDKDJBEEIID
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7E26D40", Offset = "0x7E25F40", VA = "0x187E26D40")]
		public JGMCGHJPILA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7E26200", Offset = "0x7E25400", VA = "0x187E26200", Slot = "14")]
		public override object GetValue(DLAOEIBOPLG NPCDKJJJIDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7E26220", Offset = "0x7E25420", VA = "0x187E26220", Slot = "15")]
		public override void SetValue(DLAOEIBOPLG NPCDKJJJIDL, object MLCDCHNOCFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7E25970", Offset = "0x7E24B70", VA = "0x187E25970")]
	public CAOIFDPPCCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal class NCLLAFDEIAC : ContainerPropertyBag<CNLKDKILMHK>
{
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	private class LOFICJLPENI : Property<CNLKDKILMHK, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string BGMICIBNDMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x7E27590", Offset = "0x7E26790", VA = "0x187E27590", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool FDKDJBEEIID
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7E27550", Offset = "0x7E26750", VA = "0x187E27550")]
		public LOFICJLPENI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7E26200", Offset = "0x7E25400", VA = "0x187E26200", Slot = "14")]
		public override object GetValue(CNLKDKILMHK NPCDKJJJIDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7E26220", Offset = "0x7E25420", VA = "0x187E26220", Slot = "15")]
		public override void SetValue(CNLKDKILMHK NPCDKJJJIDL, object MLCDCHNOCFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7E277C0", Offset = "0x7E269C0", VA = "0x187E277C0")]
	public NCLLAFDEIAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal class CBHFNPMBPBM : ContainerPropertyBag<DGNFOIPLPMA>
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	private class AIPNEIMLABI : Property<DGNFOIPLPMA, Entity>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string BGMICIBNDMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7E25520", Offset = "0x7E24720", VA = "0x187E25520", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool FDKDJBEEIID
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7E254E0", Offset = "0x7E246E0", VA = "0x187E254E0")]
		public AIPNEIMLABI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA6FB20", Offset = "0xA6ED20", VA = "0x180A6FB20", Slot = "14")]
		public override Entity GetValue(DGNFOIPLPMA NPCDKJJJIDL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7E254D0", Offset = "0x7E246D0", VA = "0x187E254D0", Slot = "15")]
		public override void SetValue(DGNFOIPLPMA NPCDKJJJIDL, Entity MLCDCHNOCFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7E25A50", Offset = "0x7E24C50", VA = "0x187E25A50")]
	public CBHFNPMBPBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class PKMKMGCHLOJ : ContainerPropertyBag<Entity>
{
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	private class OCGBFNAMKML : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string BGMICIBNDMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x7E27A30", Offset = "0x7E26C30", VA = "0x187E27A30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool FDKDJBEEIID
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7E279F0", Offset = "0x7E26BF0", VA = "0x187E279F0")]
		public OCGBFNAMKML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x21927C0", Offset = "0x21919C0", VA = "0x1821927C0", Slot = "14")]
		public override int GetValue(Entity NPCDKJJJIDL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7C41630", Offset = "0x7C40830", VA = "0x187C41630", Slot = "15")]
		public override void SetValue(Entity NPCDKJJJIDL, int MLCDCHNOCFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	private class LDICMNBGGNH : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string BGMICIBNDMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x7E27160", Offset = "0x7E26360", VA = "0x187E27160", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool FDKDJBEEIID
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7E27120", Offset = "0x7E26320", VA = "0x187E27120")]
		public LDICMNBGGNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xEFCBE0", Offset = "0xEFBDE0", VA = "0x180EFCBE0", Slot = "14")]
		public override int GetValue(Entity NPCDKJJJIDL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7E27110", Offset = "0x7E26310", VA = "0x187E27110", Slot = "15")]
		public override void SetValue(Entity NPCDKJJJIDL, int MLCDCHNOCFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7E27F50", Offset = "0x7E27150", VA = "0x187E27F50")]
	public PKMKMGCHLOJ()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7E28090", Offset = "0x7E27290", VA = "0x187E28090")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public class HKJKGJGAGLN
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public HKJKGJGAGLN()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	public class RbexHierarchyParentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
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
