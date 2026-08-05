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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C92930", Offset = "0x7C91130", VA = "0x187C92930", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7C92CC0", Offset = "0x7C914C0", VA = "0x187C92CC0", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2612DF0", Offset = "0x26115F0", VA = "0x182612DF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
[TypeManager.ForcedStableTypeHash(1586941204353847852uL)]
public struct IOCMNIGKPCA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
[TypeManager.ForcedStableTypeHash(1730701010008160003uL)]
public struct EMPLIBENLOB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
[TypeManager.ForcedStableTypeHash(3399609037308777919uL)]
public struct EPDIPHDIBPG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
[TypeManager.ForcedStableTypeHash(18083619841998483100uL)]
public struct ODBDLEOLAMH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
[TypeManager.ForcedStableTypeHash(12361415346715948123uL)]
public struct MIPDHPANNLB : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[TypeManager.ForcedStableTypeHash(15820941866177188261uL)]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : IBufferElementData, IEquatable<AuthoredChildBuffer>, PDNDGMALGHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7C8F9F0", Offset = "0x7C8E1F0", VA = "0x187C8F9F0", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC627A0", Offset = "0xC60FA0", VA = "0x180C627A0")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
[TypeManager.ForcedStableTypeHash(7794731847884836165uL)]
public struct KJBPOGEGOMB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[TypeManager.ForcedStableTypeHash(1525018888797798356uL)]
public struct IBNBGLLKLGI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Entity PPKDINOOEPN;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[TypeManager.ForcedStableTypeHash(6294257411443737851uL)]
public struct LEDGFJMNDMK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity PPKDINOOEPN;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct NHBNOFIDAKN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<AAFIBMADICI> EFPMMBOGHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<Entity> AONKCMHFGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private JobHandle OHHKLKBFKLA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool IIAMENEAPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7C91AA0", Offset = "0x7C902A0", VA = "0x187C91AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int FCHJPHAGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7C919F0", Offset = "0x7C901F0", VA = "0x187C919F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5B5DBF0", Offset = "0x5B5C3F0", VA = "0x185B5DBF0")]
	public NHBNOFIDAKN(NativeList<AAFIBMADICI> EFPMMBOGHCF, NativeList<Entity> AONKCMHFGFC, JobHandle OHHKLKBFKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7C91B10", Offset = "0x7C90310", VA = "0x187C91B10")]
	public (Entity, NativeSlice<Entity>) PJEGOFDOENB(int JEGIFICJAGL)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7C91A40", Offset = "0x7C90240", VA = "0x187C91A40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct AAFIBMADICI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Entity PNDCHGJLEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int BFKGIFAKMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int IMNFCKGEMOH;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EECHAHGKDLL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PGKJFEDADEA(bool IMCLJNKNFIP);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct HHHFGKDAGPO : IEquatable<HHHFGKDAGPO>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate bool FBGGEGNNNGP(int EIOPAHLHHKC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly bool LGCOCMKLJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool NIMAKHCFKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool JJFHCANJAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool AACOJDBKBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly FBGGEGNNNGP HGGEEGIDIFE;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7C90FF0", Offset = "0x7C8F7F0", VA = "0x187C90FF0")]
	public HHHFGKDAGPO(LJAJHDLLPIK ENMPGGCMLIP, FBGGEGNNNGP HGGEEGIDIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7C91040", Offset = "0x7C8F840", VA = "0x187C91040")]
	public HHHFGKDAGPO(bool LGCOCMKLJAP, bool NIMAKHCFKMP, bool JJFHCANJAPK, bool AACOJDBKBMP, FBGGEGNNNGP HGGEEGIDIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7C90ED0", Offset = "0x7C8F6D0", VA = "0x187C90ED0")]
	public bool KHMEKMDMPMD(int EIOPAHLHHKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7C90EA0", Offset = "0x7C8F6A0", VA = "0x187C90EA0")]
	public bool IEJOKPAAFNA(int EIOPAHLHHKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7C90F30", Offset = "0x7C8F730", VA = "0x187C90F30")]
	public bool MIEIEGAGPKI(int EIOPAHLHHKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7C90F00", Offset = "0x7C8F700", VA = "0x187C90F00")]
	public bool LMFLPDPOEOK(int EIOPAHLHHKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7C90D00", Offset = "0x7C8F500", VA = "0x187C90D00", Slot = "4")]
	public bool Equals(HHHFGKDAGPO PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C90D30", Offset = "0x7C8F530", VA = "0x187C90D30", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7C90DE0", Offset = "0x7C8F5E0", VA = "0x187C90DE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7C90E80", Offset = "0x7C8F680", VA = "0x187C90E80")]
	private bool HOEHLHAAFNJ(int EIOPAHLHHKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C90F60", Offset = "0x7C8F760", VA = "0x187C90F60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
[TypeManager.ForcedStableTypeHash(14250400792429278320uL)]
public struct DLGFNHIEBHO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(14910416840255214023uL)]
public struct GLFIMMCCLBC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(10891474712127242783uL)]
public struct KJBGOEKPLLL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[InternalBufferCapacity(17)]
[TypeManager.ForcedStableTypeHash(613937678496137215uL)]
public struct CCNABMDOBLA : IBufferElementData, IEquatable<CCNABMDOBLA>, PDNDGMALGHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity NGDINOANFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public int NNHGELLNEAO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private Entity FLDEFJFBOHA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7C8FCA0", Offset = "0x7C8E4A0", VA = "0x187C8FCA0", Slot = "4")]
	public bool Equals(CCNABMDOBLA PGPJMFPAKOO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class EIIOODAMIBE : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NKCKAAGEAMB MDOFGLOOKBP;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7C90830", Offset = "0x7C8F030", VA = "0x187C90830", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public EIIOODAMIBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NKCKAAGEAMB
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(1690080301203719739uL)]
public struct IJJDCOLJFMD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(13667964378929084748uL)]
public readonly struct DGHBDILANAE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly IHBHLGHIBLD CKBDBHBADNB;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2D9A6D0", Offset = "0x2D98ED0", VA = "0x182D9A6D0")]
	public DGHBDILANAE(IHBHLGHIBLD CKBDBHBADNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7C8FDB0", Offset = "0x7C8E5B0", VA = "0x187C8FDB0")]
	public DGHBDILANAE JHCGIPLJKBO(IHBHLGHIBLD NJMJPBJOAIJ)
	{
		return default(DGHBDILANAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7C8FDC0", Offset = "0x7C8E5C0", VA = "0x187C8FDC0")]
	public DGHBDILANAE NHJNPLKNKLJ(IHBHLGHIBLD NJLLMHMJHHI)
	{
		return default(DGHBDILANAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7C8FDD0", Offset = "0x7C8E5D0", VA = "0x187C8FDD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Flags]
public enum IHBHLGHIBLD : ushort
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
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class FNJLEIDILIN
{
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(1995886936411817354uL)]
public struct MCCOCAKJLPJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public IHBHLGHIBLD HONHOEJOJGO;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7C915B0", Offset = "0x7C8FDB0", VA = "0x187C915B0")]
	public bool FPLLEEBLFCK(DGHBDILANAE OIJKDMFANBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7C91590", Offset = "0x7C8FD90", VA = "0x187C91590")]
	public bool ELPBEEHOAJK(DGHBDILANAE OIJKDMFANBO, IHBHLGHIBLD PNJNPDKHBAN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Flags]
public enum EBKAKJKPKMB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(12096894998449299302uL)]
[SingletonComponent]
public struct DJBCDMKOGML : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public EBKAKJKPKMB CKBDBHBADNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public bool NDNIPBNANNM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool EPPNHAHODJE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7C8FE30", Offset = "0x7C8E630", VA = "0x187C8FE30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7C8FE80", Offset = "0x7C8E680", VA = "0x187C8FE80")]
	private DJBCDMKOGML(EBKAKJKPKMB CKBDBHBADNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C8FE40", Offset = "0x7C8E640", VA = "0x187C8FE40")]
	public DJBCDMKOGML JHCGIPLJKBO(EBKAKJKPKMB NJMJPBJOAIJ)
	{
		return default(DJBCDMKOGML);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7C8FE60", Offset = "0x7C8E660", VA = "0x187C8FE60")]
	public DJBCDMKOGML NHJNPLKNKLJ(EBKAKJKPKMB NJLLMHMJHHI)
	{
		return default(DJBCDMKOGML);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
[TypeManager.ForcedStableTypeHash(3210980466644930997uL)]
public struct MOMPLFMBGLO : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[InternalBufferCapacity(1)]
	[TypeManager.ForcedStableTypeHash(8887160633523457935uL)]
	public struct NetworkedEntityBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public Entity entity;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[TypeManager.ForcedStableTypeHash(2308769520679974324uL)]
public struct BAKEGNPMNFK : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity IAMGHEOECMM;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[TypeManager.ForcedStableTypeHash(2803523268494646145uL)]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : IBufferElementData, IEquatable<ChildBuffer>, PDNDGMALGHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7C8F9F0", Offset = "0x7C8E1F0", VA = "0x187C8F9F0", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xC627A0", Offset = "0xC60FA0", VA = "0x180C627A0")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6734819606313844273uL)]
public struct AIGOJMPGGOB : ISystemStateBufferElementData, IBufferElementData, PDNDGMALGHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public Entity EAALLGNPDMK;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Entity DJOLAHNDCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[TypeManager.ForcedStableTypeHash(10606242260416974827uL)]
public struct EBDFFAGNLOG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public Entity HGAGHBHPKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public Entity LEPOHLAKDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Entity COGBGOKDMAB;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct PJJKKPNDNBE<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly bool FFFKLPKJBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public uint KKJBEKOJOJM;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool KNDDPCBIKJJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[TypeManager.TypeVersion(2)]
[TypeManager.ForcedStableTypeHash(14518013333183728344uL)]
public struct EADJJHIPPCI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public uint KICMHPMABCG;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x127A100", Offset = "0x1278900", VA = "0x18127A100")]
	public EADJJHIPPCI(EPFBCAMMJCA DMBOJOBJMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7C905D0", Offset = "0x7C8EDD0", VA = "0x187C905D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1E1CD20", Offset = "0x1E1B520", VA = "0x181E1CD20")]
	public static EADJJHIPPCI FGIKKMMHFBO(EPFBCAMMJCA DMBOJOBJMEI)
	{
		return default(EADJJHIPPCI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[TypeManager.ForcedStableTypeHash(12631852336897389638uL)]
public struct APMKLOBEKOI : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Entity EAALLGNPDMK;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[TypeManager.ForcedStableTypeHash(8586426759787957142uL)]
public struct BAFGLJLNIBN : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public EPFBCAMMJCA OPMIAMEJKDH;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[TypeManager.ForcedStableTypeHash(3916218676170013300uL)]
public struct ILFDKAMMKPB : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Entity EAALLGNPDMK;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[TypeManager.ForcedStableTypeHash(3395423174463894753uL)]
public struct MJLBCKBJOLG : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Guid BGPPHEMBCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int PCFOAHIEPDL;
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[TypeManager.ForcedStableTypeHash(13485578171010875955uL)]
public struct LDLLPPDCGIK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public int OPMIAMEJKDH;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[TypeManager.ForcedStableTypeHash(11182407275731589027uL)]
public struct KNANLFNPCDH : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Entity EAALLGNPDMK;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[TypeManager.ForcedStableTypeHash(238571310055566811uL)]
public struct KGMJCIODGNM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public EPFBCAMMJCA OPMIAMEJKDH;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[TypeManager.ForcedStableTypeHash(17943708062286791581uL)]
public struct PFHAGJKFGGD : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Entity EAALLGNPDMK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
[TypeManager.ForcedStableTypeHash(17717774548790709874uL)]
public struct IFFFFFICKNN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(1628423395607207516uL)]
public struct ODDMBJLHNJG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int NHIKAEPIDIB;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[TypeManager.ForcedStableTypeHash(6255673600552782006uL)]
public struct AHLPNJDMKJA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int OJPIEODNKAI;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NDBHNEPADKO JIDJLPNJOBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA2A760", Offset = "0xA28F60", VA = "0x180A2A760")]
		get
		{
			return default(NDBHNEPADKO);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[TypeManager.ForcedStableTypeHash(7921165883083593916uL)]
public struct LKCKFMMKDGN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public GCHandle MCPJDAABHCK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
[TypeManager.ForcedStableTypeHash(14965811366685608319uL)]
public struct LBBDIENHBJL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
[TypeManager.ForcedStableTypeHash(8376615066990205632uL)]
public struct HMHLOBPPFHF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
[TypeManager.ForcedStableTypeHash(7273320061473429398uL)]
public struct NKKCHFEIFDH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
[TypeManager.ForcedStableTypeHash(15140206241145976177uL)]
public struct GGIEBJJEKDG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
[TypeManager.ForcedStableTypeHash(15969631250552901108uL)]
public struct MOABCICECKH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[TypeManager.ForcedStableTypeHash(9353178840587053763uL)]
public struct HCGMJGHBBNI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public int FPEOONOJHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public int JLNEBEJFOHB;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7C90CF0", Offset = "0x7C8F4F0", VA = "0x187C90CF0")]
	public HCGMJGHBBNI(Entity EAALLGNPDMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[TypeManager.ForcedStableTypeHash(16229383422209788655uL)]
public struct GJALJOGJHNB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public CollisionDetectionMode CCNBDBCLHLE;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(5173865590150727846uL)]
public struct MCNJENOIFCB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public GLBLJMJHHNB ABCONEOGEHF;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly MCNJENOIFCB CONOIFPANGO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003C")]
[TypeManager.ForcedStableTypeHash(7051356195299730219uL)]
public struct MAFCLAEALHK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003D")]
[TypeManager.ForcedStableTypeHash(780557526766205634uL)]
public struct KHDMMKJHONP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003E")]
[TypeManager.ForcedStableTypeHash(16413322458062516985uL)]
public struct NAMDHFMOEPI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[TypeManager.ForcedStableTypeHash(8350832327674051347uL)]
[InternalBufferCapacity(0)]
public struct LCACFNKEECF : IBufferElementData, IEquatable<LCACFNKEECF>, PDNDGMALGHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Entity NGDINOANFEF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity FLDEFJFBOHA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7C8F9F0", Offset = "0x7C8E1F0", VA = "0x187C8F9F0", Slot = "4")]
	public bool Equals(LCACFNKEECF PGPJMFPAKOO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[TypeManager.ForcedStableTypeHash(3503423083784418805uL)]
public struct FLPOMAKNMGF : IComponentData, PDNDGMALGHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Entity DFPCBMGPBFO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Entity FLDEFJFBOHA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000041")]
[TypeManager.ForcedStableTypeHash(14551834985136520975uL)]
public struct CMONNEEFKGJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[TypeManager.ForcedStableTypeHash(4388378139562737487uL)]
public struct PCPNNKKAONJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Entity PNDCHGJLEGG;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct IKCAPDMHCDN : LDCAEHCBJPO, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public FMMMHPMEALG KKDDIBAEBFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(FMMMHPMEALG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[TypeManager.ForcedStableTypeHash(769086036388751339uL)]
public struct BCFHGOFICHP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float3 CIBHNMHOCMK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000045")]
[TypeManager.ForcedStableTypeHash(15638082890667179775uL)]
public struct OMJOOEEFEJN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(7040629969868025973uL)]
public struct ANENKGEADKC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public float3x3 JDBICJJCEJM;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly ANENKGEADKC CONOIFPANGO;
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(1290915447730818204uL)]
public struct AGIHFPDOBNK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float3x3 JDBICJJCEJM;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly AGIHFPDOBNK CONOIFPANGO;
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[TypeManager.ForcedStableTypeHash(7667208078276643555uL)]
public struct EOAMJKFOIFI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float3 OABBLAJMILF;
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[TypeManager.ForcedStableTypeHash(11475279934298573286uL)]
public struct IHFKHKOIHDI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public float3 NFAHNNONIFF;
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(18413785019621221410uL)]
public struct BCKMMPCLMHD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public float OEEIKFGFOOD;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly BCKMMPCLMHD CONOIFPANGO;
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(16788150452972582455uL)]
public struct POMDNHIFCGC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float GJPHIKFMONM;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly POMDNHIFCGC CONOIFPANGO;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[TypeManager.ForcedStableTypeHash(971312552983123380uL)]
public struct DJMJJJIMEPD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public float3 DMHCFGBDPDL;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[TypeManager.ForcedStableTypeHash(361641396811542242uL)]
public struct OEHMIMDBBEM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public LBIAHMGKBGM CMBPKLECODO;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(7520974846918069913uL)]
public struct NLAFPHBJLIG : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Entity EAALLGNPDMK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
[TypeManager.ForcedStableTypeHash(9260549625364734686uL)]
public struct DPJLEHGPMMA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
[TypeManager.ForcedStableTypeHash(469905343419662571uL)]
public struct JBLHOLPCCOC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[TypeManager.ForcedStableTypeHash(7865784707562564105uL)]
public struct MIPEFMDEGNO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public RigidbodyConstraints KLIMCHMEJBB;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[TypeManager.ForcedStableTypeHash(7877027338327956319uL)]
[RegisterComponentDefault]
public struct IIAJDJOHPNI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public float LBEAICOAIPK;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly IIAJDJOHPNI CONOIFPANGO;
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[TypeManager.ForcedStableTypeHash(935406425377786813uL)]
public struct JEAJIFKJPIG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float AEBFBCIHNGJ;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class AEDLKJHLLHM : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GameObject KJMBGAPFJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public object OOLFAOOHKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public object BMGOJBKHAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public GJEDOGGJDGG ANFLHMAADCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public Delegate FBIDONAHMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Delegate JACHGKMCOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public JNOBHPMEBLN<Delegate> CECDBPNMFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public JNOBHPMEBLN<Delegate> JGALJGHEBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public JNOBHPMEBLN<Delegate> HBMJBBAOHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public JNOBHPMEBLN<Delegate> MGKIBLDCHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public JNOBHPMEBLN<Delegate> OONHCJNIFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public JNOBHPMEBLN<Delegate> FILPJGAPAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public JNOBHPMEBLN<Delegate> BBPAMJOBHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public JNOBHPMEBLN<Delegate> DOKHBJHGDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public JNOBHPMEBLN<Delegate> DJKICMEBICI;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7C8F650", Offset = "0x7C8DE50", VA = "0x187C8F650", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public AEDLKJHLLHM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
[TypeManager.ForcedStableTypeHash(18165447863202358792uL)]
public struct EOLGFLGNIPH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[TypeManager.ForcedStableTypeHash(10810926406358250264uL)]
public struct FDFBJJILBKN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public int EFFDDNLJFPG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1E1CD20", Offset = "0x1E1B520", VA = "0x181E1CD20")]
	public static FDFBJJILBKN FGIKKMMHFBO(int OPMIAMEJKDH)
	{
		return default(FDFBJJILBKN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class APNIADIFBLC : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Rigidbody DNDBHALNMFA;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7C8F980", Offset = "0x7C8E180", VA = "0x187C8F980", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public APNIADIFBLC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
[TypeManager.ForcedStableTypeHash(12765569839950265583uL)]
public struct IKMJMDJGBMO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[TypeManager.ForcedStableTypeHash(17236748096909814533uL)]
public struct DDKGGDGBODC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 PMKMNPODBEH;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[TypeManager.ForcedStableTypeHash(1288392478539867023uL)]
public struct FOEIGNFOINJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float3 CPDFCHMENBI;
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(15102898512288820575uL)]
public struct ALPPKFOLNGF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float CHHPBJDEEKK;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly ALPPKFOLNGF CONOIFPANGO;
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class FDCIPGOJLDG : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public object LKJBPEFCKHM;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7C908A0", Offset = "0x7C8F0A0", VA = "0x187C908A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public FDCIPGOJLDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class MLDOLHOEDCF : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public object KAFPKAGPLDF;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7C91860", Offset = "0x7C90060", VA = "0x187C91860", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public MLDOLHOEDCF()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
[TypeManager.ForcedStableTypeHash(3505189951659289292uL)]
public struct EFEAIMMNFCP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
[TypeManager.ForcedStableTypeHash(16217323095468023009uL)]
public struct FFDGLCBBAII : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
[TypeManager.ForcedStableTypeHash(12880717127246424414uL)]
public struct AEACFADPCME : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
[TypeManager.ForcedStableTypeHash(12942629461400744171uL)]
public struct OGCCGCIHBOI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[TypeManager.ForcedStableTypeHash(10226241216405964379uL)]
public struct KDEJKKINKGI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
[TypeManager.ForcedStableTypeHash(12400259538654257671uL)]
public struct OAJGMMLFLHD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
[TypeManager.ForcedStableTypeHash(12731949941800560397uL)]
public struct GEBKACONPMK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
[TypeManager.ForcedStableTypeHash(16270799832065682331uL)]
public struct GANNCIONDJC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
[TypeManager.ForcedStableTypeHash(9395080039644288849uL)]
public struct LGEABFIPMOG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[TypeManager.ForcedStableTypeHash(282623311697096978uL)]
public struct LPMAFNHDJKJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public IHHMOLPFMOD HFHJKJDLFEL;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7C91540", Offset = "0x7C8FD40", VA = "0x187C91540", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
[TypeManager.ForcedStableTypeHash(10395819776101408141uL)]
public struct ADEJMOPOLKJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
[TypeManager.ForcedStableTypeHash(375953524326549120uL)]
public struct GCPBBDENJFA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
[TypeManager.ForcedStableTypeHash(14259779488802476986uL)]
public struct IBNABMAHLEP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[TypeManager.ForcedStableTypeHash(15330221065042235480uL)]
public struct MNDGGCGGJHH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public FixedString32Bytes GLGOHIJMLFB;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(5162925656869367991uL)]
public struct BPOJOJCANOJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public UnsafeParallelHashMap<IHHMOLPFMOD, Entity> BGILKODLMJC;
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[TypeManager.ForcedStableTypeHash(9841032716800521808uL)]
public struct DBEMFIMPEIM : ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Entity MABJBCLAGFJ;
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[TypeManager.ForcedStableTypeHash(154813247653871879uL)]
internal struct KJPEJKHDLFM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Entity EAALLGNPDMK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xC627A0", Offset = "0xC60FA0", VA = "0x180C627A0")]
	public static KJPEJKHDLFM FGIKKMMHFBO(Entity EAALLGNPDMK)
	{
		return default(KJPEJKHDLFM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[TypeManager.ForcedStableTypeHash(11656653634719673845uL)]
public struct ADMGMMNGDAD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Entity DICENMFMJAG;
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[TypeManager.ForcedStableTypeHash(1837719173092935466uL)]
public struct AJGHALEAJMD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity DICENMFMJAG;
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[TypeManager.ForcedStableTypeHash(17382237360022739174uL)]
internal struct IKCDOMCPEGH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Entity AFGPIGDPJHD;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xC627A0", Offset = "0xC60FA0", VA = "0x180C627A0")]
	public static IKCDOMCPEGH FGIKKMMHFBO(Entity EAALLGNPDMK)
	{
		return default(IKCDOMCPEGH);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
[TypeManager.ForcedStableTypeHash(15858722173278118533uL)]
internal struct LMIMOPIGNMG : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[TypeManager.ForcedStableTypeHash(10313790595830381076uL)]
public struct GDMAFCGNOLG : IBufferElementData, IEquatable<GDMAFCGNOLG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Entity FKPHEGFJAGO;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7AD5CC0", Offset = "0x7AD44C0", VA = "0x187AD5CC0", Slot = "4")]
	public bool Equals(GDMAFCGNOLG PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7C90B30", Offset = "0x7C8F330", VA = "0x187C90B30", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xA2A760", Offset = "0xA28F60", VA = "0x180A2A760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[TypeManager.ForcedStableTypeHash(10169361040328370708uL)]
public struct PODELDJHCLM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public uint JLNEBEJFOHB;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(11536226225076729790uL)]
internal struct HKCECPDKJKP : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Entity PKPGBOOHCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public int FPEOONOJHML;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[TypeManager.ForcedStableTypeHash(8309037880064337491uL)]
internal struct OCNPBFDLPGA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public Entity MAPHNMEPAOC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
[TypeManager.ForcedStableTypeHash(5891816987223099091uL)]
public struct OONDDDEAJBI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[TypeManager.ForcedStableTypeHash(17289298604600812224uL)]
public struct GGILKNPIJIL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public uint KKJBEKOJOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int MDGLEPECJKP;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xCEB9D0", Offset = "0xCEA1D0", VA = "0x180CEB9D0")]
	public GGILKNPIJIL(uint AEDCFOKDNKJ, int CABHILNMMFK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
[TypeManager.ForcedStableTypeHash(12258100538258701401uL)]
public struct GNOAJKBLAOK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
[TypeManager.ForcedStableTypeHash(3081870877980445988uL)]
public struct ALKIGKIEIFP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
[TypeManager.ForcedStableTypeHash(15554741495161407507uL)]
public struct BAGDCDNHMBN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
[TypeManager.ForcedStableTypeHash(17684057078056878475uL)]
public struct APEAONFIKIG : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
[TypeManager.ForcedStableTypeHash(10023455309444528896uL)]
public struct HKMMBACGEEA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
[TypeManager.ForcedStableTypeHash(14403752119546393228uL)]
public struct GGNNPGAEOCF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
[TypeManager.ForcedStableTypeHash(9219181242087356214uL)]
public struct EOKDKAKLNNK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
[TypeManager.ForcedStableTypeHash(12371658133244024718uL)]
public struct HMEFLONLHLL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
[TypeManager.ForcedStableTypeHash(9351414359236295489uL)]
public struct IHLKNHMIKMA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
[TypeManager.ForcedStableTypeHash(12796707860320869007uL)]
internal struct FOONACDKFGC : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
[TypeManager.ForcedStableTypeHash(13367368557807690484uL)]
public struct JOECIEFGIBO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
[TypeManager.ForcedStableTypeHash(7193071459223094579uL)]
public struct ONDPNIMCNLJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000085")]
[TypeManager.ForcedStableTypeHash(15247343901949961769uL)]
public struct AHBFABFCPKL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
[TypeManager.ForcedStableTypeHash(5381043565870728787uL)]
public struct HOEOJKGDCKO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
[TypeManager.ForcedStableTypeHash(11597028615900234104uL)]
internal struct KOJGEGIDJEP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
[TypeManager.ForcedStableTypeHash(1907494159895213433uL)]
internal struct KNKMKMMCNNE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
[TypeManager.ForcedStableTypeHash(3955886960983597628uL)]
public struct JLEFAIDCENE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
[TypeManager.ForcedStableTypeHash(480620745253244652uL)]
public struct DHGJGHIDAOD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
[TypeManager.ForcedStableTypeHash(8253675824478287824uL)]
public struct EGOMJGDEMGG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008C")]
[TypeManager.ForcedStableTypeHash(8855488771047251567uL)]
public struct IOKPBAEEBNL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
[TypeManager.ForcedStableTypeHash(8375777954271012995uL)]
public struct HPAOCLNDOKI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008E")]
[TypeManager.ForcedStableTypeHash(16444804027614993581uL)]
public struct KKPEALBKKOM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
[TypeManager.ForcedStableTypeHash(16177323740107409537uL)]
public struct HJEKPBPAPLN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
[TypeManager.ForcedStableTypeHash(11049752089067741804uL)]
public struct POGPAKGBJKP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
[TypeManager.ForcedStableTypeHash(1453937769327886583uL)]
public struct FGLGHOKGKLO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000092")]
[TypeManager.ForcedStableTypeHash(800754555681830909uL)]
public struct CCCONONMJPL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000093")]
[TypeManager.ForcedStableTypeHash(3336901602667819150uL)]
public struct NAGDOOMBILP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000094")]
[TypeManager.ForcedStableTypeHash(11809750536411032401uL)]
public struct NHLNAFNCJBP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000095")]
[TypeManager.ForcedStableTypeHash(6387004770090400669uL)]
public struct JFKGIENAFEJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000096")]
[TypeManager.ForcedStableTypeHash(2223159712203397538uL)]
internal struct GFOFAPJIIOL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
[TypeManager.ForcedStableTypeHash(10153397523300334327uL)]
public struct CDPMAJJPIFN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000098")]
[TypeManager.ForcedStableTypeHash(12983102201306073842uL)]
public struct OODHAKLBBIE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000099")]
[TypeManager.ForcedStableTypeHash(15398959433761599914uL)]
[OLALJCOJEKD]
public struct LHDHIMLONPD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6605318152550716456uL)]
public struct CHKKIGJGEJE : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public FixedString32Bytes LEKFEHEMONH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009B")]
[TypeManager.ForcedStableTypeHash(10065634662848845784uL)]
public struct KIDMFHDJLHI : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
[TypeManager.ForcedStableTypeHash(15062299176839263439uL)]
public struct HEBDLCEHFFI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009D")]
[TypeManager.ForcedStableTypeHash(3596269116834888123uL)]
internal struct HDADHLAHHKB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009E")]
[TypeManager.ForcedStableTypeHash(4402941654898007496uL)]
internal struct PNAHEDIEIKL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
[TypeManager.ForcedStableTypeHash(12682474121528142025uL)]
internal struct ICEIPJKIANE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[TypeManager.ForcedStableTypeHash(1840266485562743455uL)]
public struct OGPHJJLBEAD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[TypeManager.ForcedStableTypeHash(4772574226205567794uL)]
public struct PHJALDEAFLB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[TypeManager.ForcedStableTypeHash(17642911464827038147uL)]
public struct DLPACHMBCHM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public quaternion PMHMEKBKJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float3 NCGKJMOKFAF;
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[TypeManager.ForcedStableTypeHash(9066921186040058989uL)]
public struct ANCOFEMFNBC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float GONJLMHMAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float IEABIEPAMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float LIGDNAIKHOF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[TypeManager.ForcedStableTypeHash(3328998613642473514uL)]
public struct NLIBBHFOEAP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[TypeManager.ForcedStableTypeHash(151116349382904900uL)]
public struct NFAAHLABPMC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[TypeManager.ForcedStableTypeHash(8067675582152570601uL)]
public struct CNDMGJNHEEK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[TypeManager.ForcedStableTypeHash(4522686316477281096uL)]
public struct PIJOBOFEHAN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public int OJPIEODNKAI;
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6216404920432680992uL)]
public struct AHJPJLBAOHI : ISystemStateBufferElementData, IBufferElementData, PDNDGMALGHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Entity IJHICJECDIG;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity DJOLAHNDCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(419884688393735449uL)]
public struct EGDJHKKBMJF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public float4x4 MMKGNKBEIOJ;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly EGDJHKKBMJF CONOIFPANGO;
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(1954795745923300919uL)]
public struct JJJAMCKIMJC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public float4x4 NNEKMEDCPOO;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly JJJAMCKIMJC CONOIFPANGO;
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[TypeManager.ForcedStableTypeHash(2447627752265109178uL)]
public struct DPFDAHFMMGL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private int PLCFIKDAIAJ;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int FPEOONOJHML
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7C905B0", Offset = "0x7C8EDB0", VA = "0x187C905B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7C905C0", Offset = "0x7C8EDC0", VA = "0x187C905C0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(13706996280046618062uL)]
public struct GJFHBEPMICO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public float3 NCGKJMOKFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public quaternion PMHMEKBKJJA;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly GJFHBEPMICO CONOIFPANGO;
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class DGKLBNBDPOC
{
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(77694943841979493uL)]
public struct PDJGHHCJFDF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public float LMPAENCKMLD;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly PDJGHHCJFDF CONOIFPANGO;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[TypeManager.ForcedStableTypeHash(6537711325103434903uL)]
public struct JAEPLKADPAD : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Entity DIKHGKFCIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public OCDLEPLDLBO KJHADNKKPBJ;
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[TypeManager.ForcedStableTypeHash(5471640964865828061uL)]
public struct AKGDLGIFEPN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public OCDLEPLDLBO KJHADNKKPBJ;
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[TypeManager.ForcedStableTypeHash(16527934868211432802uL)]
public struct FKHGMOBEFEO : ISystemStateComponentData, IComponentData, PDNDGMALGHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Entity PIDPEOCOGMC;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Entity DJOLAHNDCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[TypeManager.ForcedStableTypeHash(15310407062508355916uL)]
public struct LLCNFNEJAIK : ISystemStateBufferElementData, IBufferElementData, PDNDGMALGHF, IEquatable<LLCNFNEJAIK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Entity HIFFHGAPLDJ;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Entity DJOLAHNDCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7AD5CC0", Offset = "0x7AD44C0", VA = "0x187AD5CC0", Slot = "6")]
	public bool Equals(LLCNFNEJAIK PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7C913F0", Offset = "0x7C8FBF0", VA = "0x187C913F0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xA2A760", Offset = "0xA28F60", VA = "0x180A2A760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[TypeManager.ForcedStableTypeHash(11786768220100978132uL)]
public struct HFAHCLCOGOM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Entity DIKHGKFCIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public OCDLEPLDLBO KJHADNKKPBJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct MOIPNHLBKGK : IEqualityComparer<HFAHCLCOGOM>
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static MOIPNHLBKGK CONOIFPANGO;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7C918D0", Offset = "0x7C900D0", VA = "0x187C918D0", Slot = "4")]
	public bool Equals(HFAHCLCOGOM LEFBJAGNHCD, HFAHCLCOGOM LLGPJHIECFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7C91920", Offset = "0x7C90120", VA = "0x187C91920", Slot = "5")]
	public int GetHashCode(HFAHCLCOGOM PNHCNFOFAFI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[TypeManager.ForcedStableTypeHash(8981997360983277121uL)]
public struct KEKNIIFNBDP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public FixedList32Bytes<int> CHKOHMIIEJH;
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[TypeManager.ForcedStableTypeHash(2801212869002544047uL)]
public struct LEANJGDBPMP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public FixedList32Bytes<int> CHKOHMIIEJH;
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[TypeManager.ForcedStableTypeHash(16455485691096333919uL)]
public struct ILGEHJLLIPF : ISystemStateBufferElementData, IBufferElementData, PDNDGMALGHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public Entity BICLBOHAIOE;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Entity FLDEFJFBOHA
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal class MFDMGOCDEHC : ContainerPropertyBag<EIIOODAMIBE>
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	private class OPMGICNMIIM : Property<EIIOODAMIBE, NKCKAAGEAMB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string ACOJEEABMOC
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7C91D50", Offset = "0x7C90550", VA = "0x187C91D50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool KFFGFCMACFL
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7C91D10", Offset = "0x7C90510", VA = "0x187C91D10")]
		public OPMGICNMIIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7C906C0", Offset = "0x7C8EEC0", VA = "0x187C906C0", Slot = "14")]
		public override NKCKAAGEAMB GetValue(EIIOODAMIBE PMKEELMHMLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7C906E0", Offset = "0x7C8EEE0", VA = "0x187C906E0", Slot = "15")]
		public override void SetValue(EIIOODAMIBE PMKEELMHMLA, NKCKAAGEAMB OPMIAMEJKDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7C916C0", Offset = "0x7C8FEC0", VA = "0x187C916C0")]
	public MFDMGOCDEHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class DKLJMKBOACK : ContainerPropertyBag<AEDLKJHLLHM>
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	private class NHDKOGCAJNI : Property<AEDLKJHLLHM, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string ACOJEEABMOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x7C91C70", Offset = "0x7C90470", VA = "0x187C91C70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool KFFGFCMACFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7C91C30", Offset = "0x7C90430", VA = "0x187C91C30")]
		public NHDKOGCAJNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7C906C0", Offset = "0x7C8EEC0", VA = "0x187C906C0", Slot = "14")]
		public override GameObject GetValue(AEDLKJHLLHM PMKEELMHMLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7C906E0", Offset = "0x7C8EEE0", VA = "0x187C906E0", Slot = "15")]
		public override void SetValue(AEDLKJHLLHM PMKEELMHMLA, GameObject OPMIAMEJKDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	private class EDKFEDNFBIL : Property<AEDLKJHLLHM, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string ACOJEEABMOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7C90690", Offset = "0x7C8EE90", VA = "0x187C90690", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool KFFGFCMACFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7C90650", Offset = "0x7C8EE50", VA = "0x187C90650")]
		public EDKFEDNFBIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7C90600", Offset = "0x7C8EE00", VA = "0x187C90600", Slot = "14")]
		public override object GetValue(AEDLKJHLLHM PMKEELMHMLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7C90620", Offset = "0x7C8EE20", VA = "0x187C90620", Slot = "15")]
		public override void SetValue(AEDLKJHLLHM PMKEELMHMLA, object OPMIAMEJKDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	private class DDKOCFJDELC : Property<AEDLKJHLLHM, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string ACOJEEABMOC
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7C8FD80", Offset = "0x7C8E580", VA = "0x187C8FD80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool KFFGFCMACFL
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7C8FD40", Offset = "0x7C8E540", VA = "0x187C8FD40")]
		public DDKOCFJDELC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7C8FCF0", Offset = "0x7C8E4F0", VA = "0x187C8FCF0", Slot = "14")]
		public override object GetValue(AEDLKJHLLHM PMKEELMHMLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7C8FD10", Offset = "0x7C8E510", VA = "0x187C8FD10", Slot = "15")]
		public override void SetValue(AEDLKJHLLHM PMKEELMHMLA, object OPMIAMEJKDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	private class AEMOIJIOMDE : Property<AEDLKJHLLHM, GJEDOGGJDGG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string ACOJEEABMOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F730", Offset = "0x7C8DF30", VA = "0x187C8F730", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool KFFGFCMACFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7C8F6F0", Offset = "0x7C8DEF0", VA = "0x187C8F6F0")]
		public AEMOIJIOMDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7C8F6A0", Offset = "0x7C8DEA0", VA = "0x187C8F6A0", Slot = "14")]
		public override GJEDOGGJDGG GetValue(AEDLKJHLLHM PMKEELMHMLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7C8F6C0", Offset = "0x7C8DEC0", VA = "0x187C8F6C0", Slot = "15")]
		public override void SetValue(AEDLKJHLLHM PMKEELMHMLA, GJEDOGGJDGG OPMIAMEJKDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private class MDBDMFBIBLC : Property<AEDLKJHLLHM, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string ACOJEEABMOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7C91690", Offset = "0x7C8FE90", VA = "0x187C91690", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool KFFGFCMACFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7C91650", Offset = "0x7C8FE50", VA = "0x187C91650")]
		public MDBDMFBIBLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7C91600", Offset = "0x7C8FE00", VA = "0x187C91600", Slot = "14")]
		public override Delegate GetValue(AEDLKJHLLHM PMKEELMHMLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7C91620", Offset = "0x7C8FE20", VA = "0x187C91620", Slot = "15")]
		public override void SetValue(AEDLKJHLLHM PMKEELMHMLA, Delegate OPMIAMEJKDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private class DNPMNJEJHBL : Property<AEDLKJHLLHM, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string ACOJEEABMOC
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7C90580", Offset = "0x7C8ED80", VA = "0x187C90580", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool KFFGFCMACFL
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7C90540", Offset = "0x7C8ED40", VA = "0x187C90540")]
		public DNPMNJEJHBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7C904F0", Offset = "0x7C8ECF0", VA = "0x187C904F0", Slot = "14")]
		public override Delegate GetValue(AEDLKJHLLHM PMKEELMHMLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7C90510", Offset = "0x7C8ED10", VA = "0x187C90510", Slot = "15")]
		public override void SetValue(AEDLKJHLLHM PMKEELMHMLA, Delegate OPMIAMEJKDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private class BBIIKBCJPME : Property<AEDLKJHLLHM, JNOBHPMEBLN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string ACOJEEABMOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7C8FA90", Offset = "0x7C8E290", VA = "0x187C8FA90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool KFFGFCMACFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7C8FA50", Offset = "0x7C8E250", VA = "0x187C8FA50")]
		public BBIIKBCJPME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7C8FA00", Offset = "0x7C8E200", VA = "0x187C8FA00", Slot = "14")]
		public override JNOBHPMEBLN<Delegate> GetValue(AEDLKJHLLHM PMKEELMHMLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7C8FA20", Offset = "0x7C8E220", VA = "0x187C8FA20", Slot = "15")]
		public override void SetValue(AEDLKJHLLHM PMKEELMHMLA, JNOBHPMEBLN<Delegate> OPMIAMEJKDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private class MFGHIBPHECP : Property<AEDLKJHLLHM, JNOBHPMEBLN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string ACOJEEABMOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x7C91830", Offset = "0x7C90030", VA = "0x187C91830", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool KFFGFCMACFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7C917F0", Offset = "0x7C8FFF0", VA = "0x187C917F0")]
		public MFGHIBPHECP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7C917A0", Offset = "0x7C8FFA0", VA = "0x187C917A0", Slot = "14")]
		public override JNOBHPMEBLN<Delegate> GetValue(AEDLKJHLLHM PMKEELMHMLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7C917C0", Offset = "0x7C8FFC0", VA = "0x187C917C0", Slot = "15")]
		public override void SetValue(AEDLKJHLLHM PMKEELMHMLA, JNOBHPMEBLN<Delegate> OPMIAMEJKDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private class AAMEIAAJOJE : Property<AEDLKJHLLHM, JNOBHPMEBLN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string ACOJEEABMOC
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F620", Offset = "0x7C8DE20", VA = "0x187C8F620", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool KFFGFCMACFL
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7C8F5E0", Offset = "0x7C8DDE0", VA = "0x187C8F5E0")]
		public AAMEIAAJOJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7C8F590", Offset = "0x7C8DD90", VA = "0x187C8F590", Slot = "14")]
		public override JNOBHPMEBLN<Delegate> GetValue(AEDLKJHLLHM PMKEELMHMLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7C8F5B0", Offset = "0x7C8DDB0", VA = "0x187C8F5B0", Slot = "15")]
		public override void SetValue(AEDLKJHLLHM PMKEELMHMLA, JNOBHPMEBLN<Delegate> OPMIAMEJKDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private class BBOKAEGIDFD : Property<AEDLKJHLLHM, JNOBHPMEBLN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string ACOJEEABMOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7C8FB50", Offset = "0x7C8E350", VA = "0x187C8FB50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool KFFGFCMACFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7C8FB10", Offset = "0x7C8E310", VA = "0x187C8FB10")]
		public BBOKAEGIDFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7C8FAC0", Offset = "0x7C8E2C0", VA = "0x187C8FAC0", Slot = "14")]
		public override JNOBHPMEBLN<Delegate> GetValue(AEDLKJHLLHM PMKEELMHMLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7C8FAE0", Offset = "0x7C8E2E0", VA = "0x187C8FAE0", Slot = "15")]
		public override void SetValue(AEDLKJHLLHM PMKEELMHMLA, JNOBHPMEBLN<Delegate> OPMIAMEJKDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private class PEAEJBBEPNJ : Property<AEDLKJHLLHM, JNOBHPMEBLN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string ACOJEEABMOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x7C91F10", Offset = "0x7C90710", VA = "0x187C91F10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool KFFGFCMACFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7C91ED0", Offset = "0x7C906D0", VA = "0x187C91ED0")]
		public PEAEJBBEPNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7C91E80", Offset = "0x7C90680", VA = "0x187C91E80", Slot = "14")]
		public override JNOBHPMEBLN<Delegate> GetValue(AEDLKJHLLHM PMKEELMHMLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7C91EA0", Offset = "0x7C906A0", VA = "0x187C91EA0", Slot = "15")]
		public override void SetValue(AEDLKJHLLHM PMKEELMHMLA, JNOBHPMEBLN<Delegate> OPMIAMEJKDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	private class PPMKMIKOMPM : Property<AEDLKJHLLHM, JNOBHPMEBLN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string ACOJEEABMOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x7C921D0", Offset = "0x7C909D0", VA = "0x187C921D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool KFFGFCMACFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7C92190", Offset = "0x7C90990", VA = "0x187C92190")]
		public PPMKMIKOMPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7C92140", Offset = "0x7C90940", VA = "0x187C92140", Slot = "14")]
		public override JNOBHPMEBLN<Delegate> GetValue(AEDLKJHLLHM PMKEELMHMLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7C92160", Offset = "0x7C90960", VA = "0x187C92160", Slot = "15")]
		public override void SetValue(AEDLKJHLLHM PMKEELMHMLA, JNOBHPMEBLN<Delegate> OPMIAMEJKDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	private class LLGPJNMJDGO : Property<AEDLKJHLLHM, JNOBHPMEBLN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string ACOJEEABMOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7C91510", Offset = "0x7C8FD10", VA = "0x187C91510", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool KFFGFCMACFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7C914D0", Offset = "0x7C8FCD0", VA = "0x187C914D0")]
		public LLGPJNMJDGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7C91480", Offset = "0x7C8FC80", VA = "0x187C91480", Slot = "14")]
		public override JNOBHPMEBLN<Delegate> GetValue(AEDLKJHLLHM PMKEELMHMLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7C914A0", Offset = "0x7C8FCA0", VA = "0x187C914A0", Slot = "15")]
		public override void SetValue(AEDLKJHLLHM PMKEELMHMLA, JNOBHPMEBLN<Delegate> OPMIAMEJKDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	private class IHLJLIDGLNH : Property<AEDLKJHLLHM, JNOBHPMEBLN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string ACOJEEABMOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7C91100", Offset = "0x7C8F900", VA = "0x187C91100", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool KFFGFCMACFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7C910C0", Offset = "0x7C8F8C0", VA = "0x187C910C0")]
		public IHLJLIDGLNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7C91070", Offset = "0x7C8F870", VA = "0x187C91070", Slot = "14")]
		public override JNOBHPMEBLN<Delegate> GetValue(AEDLKJHLLHM PMKEELMHMLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7C91090", Offset = "0x7C8F890", VA = "0x187C91090", Slot = "15")]
		public override void SetValue(AEDLKJHLLHM PMKEELMHMLA, JNOBHPMEBLN<Delegate> OPMIAMEJKDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	private class OPPIAFLCCOC : Property<AEDLKJHLLHM, JNOBHPMEBLN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string ACOJEEABMOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7C91E10", Offset = "0x7C90610", VA = "0x187C91E10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool KFFGFCMACFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7C91DD0", Offset = "0x7C905D0", VA = "0x187C91DD0")]
		public OPPIAFLCCOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7C91D80", Offset = "0x7C90580", VA = "0x187C91D80", Slot = "14")]
		public override JNOBHPMEBLN<Delegate> GetValue(AEDLKJHLLHM PMKEELMHMLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7C91DA0", Offset = "0x7C905A0", VA = "0x187C91DA0", Slot = "15")]
		public override void SetValue(AEDLKJHLLHM PMKEELMHMLA, JNOBHPMEBLN<Delegate> OPMIAMEJKDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7C8FE90", Offset = "0x7C8E690", VA = "0x187C8FE90")]
	public DKLJMKBOACK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal class FKNBLLAINIA : ContainerPropertyBag<JNOBHPMEBLN<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7C90AD0", Offset = "0x7C8F2D0", VA = "0x187C90AD0")]
	public FKNBLLAINIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal class FKFIFMDFFHC : ContainerPropertyBag<APNIADIFBLC>
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	private class NAMPHDOBAKG : Property<APNIADIFBLC, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string ACOJEEABMOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7C919C0", Offset = "0x7C901C0", VA = "0x187C919C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool KFFGFCMACFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7C91980", Offset = "0x7C90180", VA = "0x187C91980")]
		public NAMPHDOBAKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7C906C0", Offset = "0x7C8EEC0", VA = "0x187C906C0", Slot = "14")]
		public override Rigidbody GetValue(APNIADIFBLC PMKEELMHMLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7C906E0", Offset = "0x7C8EEE0", VA = "0x187C906E0", Slot = "15")]
		public override void SetValue(APNIADIFBLC PMKEELMHMLA, Rigidbody OPMIAMEJKDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7C909F0", Offset = "0x7C8F1F0", VA = "0x187C909F0")]
	public FKFIFMDFFHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal class KBMMKBABAGB : ContainerPropertyBag<FDCIPGOJLDG>
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	private class EEFMKNBJAPL : Property<FDCIPGOJLDG, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string ACOJEEABMOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x7C90750", Offset = "0x7C8EF50", VA = "0x187C90750", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool KFFGFCMACFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7C90710", Offset = "0x7C8EF10", VA = "0x187C90710")]
		public EEFMKNBJAPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7C906C0", Offset = "0x7C8EEC0", VA = "0x187C906C0", Slot = "14")]
		public override object GetValue(FDCIPGOJLDG PMKEELMHMLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7C906E0", Offset = "0x7C8EEE0", VA = "0x187C906E0", Slot = "15")]
		public override void SetValue(FDCIPGOJLDG PMKEELMHMLA, object OPMIAMEJKDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7C91310", Offset = "0x7C8FB10", VA = "0x187C91310")]
	public KBMMKBABAGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal class FJLIHDILMBJ : ContainerPropertyBag<MLDOLHOEDCF>
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	private class JJOIAKPJKKN : Property<MLDOLHOEDCF, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string ACOJEEABMOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x7C912E0", Offset = "0x7C8FAE0", VA = "0x187C912E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool KFFGFCMACFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7C912A0", Offset = "0x7C8FAA0", VA = "0x187C912A0")]
		public JJOIAKPJKKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7C906C0", Offset = "0x7C8EEC0", VA = "0x187C906C0", Slot = "14")]
		public override object GetValue(MLDOLHOEDCF PMKEELMHMLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7C906E0", Offset = "0x7C8EEE0", VA = "0x187C906E0", Slot = "15")]
		public override void SetValue(MLDOLHOEDCF PMKEELMHMLA, object OPMIAMEJKDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7C90910", Offset = "0x7C8F110", VA = "0x187C90910")]
	public FJLIHDILMBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal class BOKAFMKLOJJ : ContainerPropertyBag<DBEMFIMPEIM>
{
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	private class IOKMBLGPCCC : Property<DBEMFIMPEIM, Entity>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string ACOJEEABMOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7C911C0", Offset = "0x7C8F9C0", VA = "0x187C911C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool KFFGFCMACFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7C91180", Offset = "0x7C8F980", VA = "0x187C91180")]
		public IOKMBLGPCCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xE32C70", Offset = "0xE31470", VA = "0x180E32C70", Slot = "14")]
		public override Entity GetValue(DBEMFIMPEIM PMKEELMHMLA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7C91170", Offset = "0x7C8F970", VA = "0x187C91170", Slot = "15")]
		public override void SetValue(DBEMFIMPEIM PMKEELMHMLA, Entity OPMIAMEJKDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7C8FBC0", Offset = "0x7C8E3C0", VA = "0x187C8FBC0")]
	public BOKAFMKLOJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal class PGPKMPFDNGA : ContainerPropertyBag<Entity>
{
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	private class NNBPACDBKNB : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string ACOJEEABMOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x7C91CE0", Offset = "0x7C904E0", VA = "0x187C91CE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool KFFGFCMACFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C91CA0", Offset = "0x7C904A0", VA = "0x187C91CA0")]
		public NNBPACDBKNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x212E4E0", Offset = "0x212CCE0", VA = "0x18212E4E0", Slot = "14")]
		public override int GetValue(Entity PMKEELMHMLA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7AD13B0", Offset = "0x7ACFBB0", VA = "0x187AD13B0", Slot = "15")]
		public override void SetValue(Entity PMKEELMHMLA, int OPMIAMEJKDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	private class PLIGBIDPMMB : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string ACOJEEABMOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x7C920D0", Offset = "0x7C908D0", VA = "0x187C920D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool KFFGFCMACFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7C92090", Offset = "0x7C90890", VA = "0x187C92090")]
		public PLIGBIDPMMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xEC83B0", Offset = "0xEC6BB0", VA = "0x180EC83B0", Slot = "14")]
		public override int GetValue(Entity PMKEELMHMLA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7C92080", Offset = "0x7C90880", VA = "0x187C92080", Slot = "15")]
		public override void SetValue(Entity PMKEELMHMLA, int OPMIAMEJKDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7C91F40", Offset = "0x7C90740", VA = "0x187C91F40")]
	public PGPKMPFDNGA()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7C92200", Offset = "0x7C90A00", VA = "0x187C92200")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public class AICHEIEOLIK
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public AICHEIEOLIK()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public class RbexHierarchyParentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
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
