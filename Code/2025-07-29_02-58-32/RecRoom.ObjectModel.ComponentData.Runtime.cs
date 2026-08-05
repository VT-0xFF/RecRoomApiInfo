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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x84BD930", Offset = "0x84BC330", VA = "0x1884BD930", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x84BDCE0", Offset = "0x84BC6E0", VA = "0x1884BDCE0", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2906C90", Offset = "0x2905690", VA = "0x182906C90")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
[TypeManager.ForcedStableTypeHash(1586941204353847852uL)]
public struct NGNJEGNNEEF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
[TypeManager.ForcedStableTypeHash(1730701010008160003uL)]
public struct HAEECCAABCK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
[TypeManager.ForcedStableTypeHash(3399609037308777919uL)]
public struct NEFEJCJPGPN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
[TypeManager.ForcedStableTypeHash(18083619841998483100uL)]
public struct IDICEFDLMKM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
[TypeManager.ForcedStableTypeHash(12361415346715948123uL)]
public struct GKOPOFGMJPL : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[InternalBufferCapacity(8)]
	[TypeManager.ForcedStableTypeHash(15820941866177188261uL)]
	public struct AuthoredChildBuffer : IBufferElementData, IEquatable<AuthoredChildBuffer>, HNBIGGMBGLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84BA860", Offset = "0x84B9260", VA = "0x1884BA860", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xDE25D0", Offset = "0xDE0FD0", VA = "0x180DE25D0")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
[TypeManager.ForcedStableTypeHash(7794731847884836165uL)]
public struct ELADNKLNJFI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
[TypeManager.ForcedStableTypeHash(16414266906034106824uL)]
public struct CNBNLEDFPFD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[TypeManager.ForcedStableTypeHash(1525018888797798356uL)]
public struct NBGIFACKGKP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Entity IKBCADHKDJF;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[TypeManager.ForcedStableTypeHash(6294257411443737851uL)]
public struct IMOJGGNJPAK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity IKBCADHKDJF;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct BGAPDFMFJDF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<CEPCLINDHHA> IGIDBOEHOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<Entity> KPBDPBNANLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private JobHandle HADFHMENAPG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool GAMFHFGHFHC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x84BAA40", Offset = "0x84B9440", VA = "0x1884BAA40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int NEOIHEKIHEL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x84BA9F0", Offset = "0x84B93F0", VA = "0x1884BA9F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6165710", Offset = "0x6164110", VA = "0x186165710")]
	public BGAPDFMFJDF(NativeList<CEPCLINDHHA> IGIDBOEHOLL, NativeList<Entity> KPBDPBNANLC, JobHandle HADFHMENAPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x84BA8D0", Offset = "0x84B92D0", VA = "0x1884BA8D0")]
	public (Entity, NativeSlice<Entity>) GGDMKOIPHHJ(int BAMENPFPKND)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x84BA870", Offset = "0x84B9270", VA = "0x1884BA870", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct CEPCLINDHHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Entity PJFDNMGHMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int KIOPHNHDMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int KLLLBPFLPCD;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LAIHCKFDDGH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GCGDIGDEFNK(bool FKNNKHIFMGO);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct OKGBIPKBBLK : IEquatable<OKGBIPKBBLK>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate bool HDPIOMAKGPI(int FCNHLPKGBDC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly bool KKOLIGBPFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool AJBFLDNEGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool FIJCCJGDBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool BMPDIIFGFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly HDPIOMAKGPI NICCOEANHBB;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x84BCDA0", Offset = "0x84BB7A0", VA = "0x1884BCDA0")]
	public OKGBIPKBBLK(GCGINMLPDDC DHGLMDLACKG, HDPIOMAKGPI NICCOEANHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x84BCD70", Offset = "0x84BB770", VA = "0x1884BCD70")]
	public OKGBIPKBBLK(bool KKOLIGBPFCL, bool AJBFLDNEGLI, bool FIJCCJGDBAH, bool BMPDIIFGFCJ, HDPIOMAKGPI NICCOEANHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x84BCC50", Offset = "0x84BB650", VA = "0x1884BCC50")]
	public bool KAHEJBODHOF(int FCNHLPKGBDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x84BCC80", Offset = "0x84BB680", VA = "0x1884BCC80")]
	public bool KJKDONJMPMK(int FCNHLPKGBDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x84BCAA0", Offset = "0x84BB4A0", VA = "0x1884BCAA0")]
	public bool EGCAODHNEAL(int FCNHLPKGBDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x84BCCB0", Offset = "0x84BB6B0", VA = "0x1884BCCB0")]
	public bool MCIHOIDNCMC(int FCNHLPKGBDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x84BCAD0", Offset = "0x84BB4D0", VA = "0x1884BCAD0", Slot = "4")]
	public bool Equals(OKGBIPKBBLK EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x84BCB00", Offset = "0x84BB500", VA = "0x1884BCB00", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x84BCBB0", Offset = "0x84BB5B0", VA = "0x1884BCBB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x84BCA80", Offset = "0x84BB480", VA = "0x1884BCA80")]
	private bool EFNHEIOJGMO(int FCNHLPKGBDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x84BCCE0", Offset = "0x84BB6E0", VA = "0x1884BCCE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class PNAOEEFDDHO : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public MBPJOONFHIE LAHDKLNDKDF;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x84BD190", Offset = "0x84BBB90", VA = "0x1884BD190", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public PNAOEEFDDHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface MBPJOONFHIE
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[TypeManager.ForcedStableTypeHash(8332665118338960440uL)]
public struct PFCALLPDJKK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity CHCAMNCKAML;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[TypeManager.ForcedStableTypeHash(8981907371573408222uL)]
public struct PKOLBHALIFO : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Entity AEODPPICCCA;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[TypeManager.ForcedStableTypeHash(17354288130755581458uL)]
public struct BBAKGLEFLEI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Entity ANDHKLFIMAM;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(10748250521618087564uL)]
public struct OKIFHMCAFKN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public bool COCHFCNNKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool PJBLDPINHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public int FEIHGMDLJNA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(3379294255511517190uL)]
public struct BKEDJMFOHIJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[TypeManager.ForcedStableTypeHash(4520164298937563310uL)]
[SingletonComponent]
public struct KDMKADDMFFI : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public Entity EOGGAEBALGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public Entity LBACNFEIFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public Entity OLKOIAJAGLH;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(8968007509158485045uL)]
public struct DALPIAIFOCF : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public Entity HGDJAIPKJFK;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[TypeManager.ForcedStableTypeHash(4138010451634514615uL)]
public struct EDPPMPEGJAO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float3 DDIHIBMHCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public quaternion JCDLBIBEGAF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(1690080301203719739uL)]
public struct HANLDEALMOH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(13667964378929084748uL)]
public readonly struct NPJBAEABJGE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly KONABNFAAIE BJHDPNAPFMC;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3161120", Offset = "0x315FB20", VA = "0x183161120")]
	public NPJBAEABJGE(KONABNFAAIE BJHDPNAPFMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x84BC830", Offset = "0x84BB230", VA = "0x1884BC830")]
	public NPJBAEABJGE BCBENBICOJA(KONABNFAAIE MMMCAJDAOAF)
	{
		return default(NPJBAEABJGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x84BC840", Offset = "0x84BB240", VA = "0x1884BC840")]
	public NPJBAEABJGE GJCAGPIGIPB(KONABNFAAIE DHFNHAMLMDF)
	{
		return default(NPJBAEABJGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x84BC850", Offset = "0x84BB250", VA = "0x1884BC850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[Flags]
public enum KONABNFAAIE : ushort
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
public static class OKCAMOGAOMC
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[TypeManager.ForcedStableTypeHash(1995886936411817354uL)]
[SingletonComponent]
public struct PEJCBDJIIJJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public KONABNFAAIE DJLGJJLOBPH;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x84BCEB0", Offset = "0x84BB8B0", VA = "0x1884BCEB0")]
	public bool CBHBIBNKKLJ(NPJBAEABJGE IHNNCNLLPCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x84BCEC0", Offset = "0x84BB8C0", VA = "0x1884BCEC0")]
	public bool ILHMKCFHIHF(NPJBAEABJGE IHNNCNLLPCN, KONABNFAAIE DLOAKGGHDFF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Flags]
public enum PKEKNPAIPHL : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(12096894998449299302uL)]
public struct JPGHPPIANKL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public PKEKNPAIPHL BJHDPNAPFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public bool BJODBAGBKNA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool OFBNHBNMPHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84BC170", Offset = "0x84BAB70", VA = "0x1884BC170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x84BC180", Offset = "0x84BAB80", VA = "0x1884BC180")]
	private JPGHPPIANKL(PKEKNPAIPHL BJHDPNAPFMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x84BC130", Offset = "0x84BAB30", VA = "0x1884BC130")]
	public JPGHPPIANKL BCBENBICOJA(PKEKNPAIPHL MMMCAJDAOAF)
	{
		return default(JPGHPPIANKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x84BC150", Offset = "0x84BAB50", VA = "0x1884BC150")]
	public JPGHPPIANKL GJCAGPIGIPB(PKEKNPAIPHL DHFNHAMLMDF)
	{
		return default(JPGHPPIANKL);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
[TypeManager.ForcedStableTypeHash(3210980466644930997uL)]
public struct FIJDJFDPIMF : IComponentData
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
public struct KIFHHFLNCIC : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Entity NFEOFIAGDMH;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[InternalBufferCapacity(8)]
	[TypeManager.ForcedStableTypeHash(2803523268494646145uL)]
	public struct ChildBuffer : IBufferElementData, IEquatable<ChildBuffer>, HNBIGGMBGLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x84BA860", Offset = "0x84B9260", VA = "0x1884BA860", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xDE25D0", Offset = "0xDE0FD0", VA = "0x180DE25D0")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[TypeManager.ForcedStableTypeHash(6734819606313844273uL)]
[SingletonComponent]
public struct DJKJHLKLPGM : ISystemStateBufferElementData, IBufferElementData, HNBIGGMBGLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Entity EOGGAEBALGK;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Entity EODELNCODMB
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[TypeManager.ForcedStableTypeHash(10606242260416974827uL)]
public struct IHMDGHNNNJL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Entity GEHGEKCMDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Entity AFHJODNAMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Entity ELENDKBAMOD;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct OCMHLCBEINB<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static readonly bool DKCDJFPCHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public uint CFPAOOCPAOI;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	private static bool HBAOIBHJNPM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[TypeManager.ForcedStableTypeHash(8255844827150930234uL)]
public struct BJIHHEJCHPK : IBufferElementData, IEquatable<BJIHHEJCHPK>, HNBIGGMBGLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Entity PJOCONLEPEA;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private Entity DLCNFBOECPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x84BA860", Offset = "0x84B9260", VA = "0x1884BA860", Slot = "4")]
	public bool Equals(BJIHHEJCHPK EFNHKCDKOGH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[TypeManager.TypeVersion(2)]
[TypeManager.ForcedStableTypeHash(14518013333183728344uL)]
public struct ADDEEKAABMM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public uint OGFAHFALEAG;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x152BB60", Offset = "0x152A560", VA = "0x18152BB60")]
	public ADDEEKAABMM(GLONLLNEBOJ GDPFIJKMJBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x84BA6E0", Offset = "0x84B90E0", VA = "0x1884BA6E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2120A70", Offset = "0x211F470", VA = "0x182120A70")]
	public static ADDEEKAABMM LHJBCIIELME(GLONLLNEBOJ GDPFIJKMJBC)
	{
		return default(ADDEEKAABMM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[TypeManager.ForcedStableTypeHash(12631852336897389638uL)]
public struct AGODEBJBPNN : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Entity EOGGAEBALGK;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[TypeManager.ForcedStableTypeHash(8586426759787957142uL)]
public struct LGHGPDMIMPC : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public GLONLLNEBOJ PDKJBMPOMNC;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[TypeManager.ForcedStableTypeHash(3916218676170013300uL)]
public struct GLBOMNBOACL : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Entity EOGGAEBALGK;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[TypeManager.ForcedStableTypeHash(3395423174463894753uL)]
public struct EJDDPELIOGC : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Guid DNLDANFOOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public int CDCPIGCEABM;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[TypeManager.ForcedStableTypeHash(13485578171010875955uL)]
public struct DLOFCMNNCHI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public int PDKJBMPOMNC;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[TypeManager.ForcedStableTypeHash(11182407275731589027uL)]
public struct PJPELICLFNP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Entity EOGGAEBALGK;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[TypeManager.ForcedStableTypeHash(238571310055566811uL)]
public struct FLIPKOCMJCH : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public GLONLLNEBOJ PDKJBMPOMNC;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[TypeManager.ForcedStableTypeHash(17943708062286791581uL)]
public struct MADDALMHKCM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Entity EOGGAEBALGK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
[TypeManager.ForcedStableTypeHash(17717774548790709874uL)]
public struct KBPLHMFEPEL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(1628423395607207516uL)]
public struct ACDGLCLHMOO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int JOCHNADMHPI;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[TypeManager.ForcedStableTypeHash(6255673600552782006uL)]
public struct HNHMBACPDGM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int PCJBPIKLFBM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public IOMKCHPPNFJ HAGDNBLHJBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xD893D0", Offset = "0xD87DD0", VA = "0x180D893D0")]
		get
		{
			return default(IOMKCHPPNFJ);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[TypeManager.ForcedStableTypeHash(7921165883083593916uL)]
public struct DHEIOGKBGIK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public GCHandle NPGFAJMKLBM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
[TypeManager.ForcedStableTypeHash(14965811366685608319uL)]
public struct BKEHCDFJACA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003B")]
[TypeManager.ForcedStableTypeHash(8376615066990205632uL)]
public struct HIANAHGKGPP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003C")]
[TypeManager.ForcedStableTypeHash(7273320061473429398uL)]
public struct ENMACCNKJJJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003D")]
[TypeManager.ForcedStableTypeHash(15140206241145976177uL)]
public struct AFIGLGEDEDE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003E")]
[TypeManager.ForcedStableTypeHash(15969631250552901108uL)]
public struct LALKMOHJPEH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[TypeManager.ForcedStableTypeHash(9353178840587053763uL)]
public struct DFJLJEIAGPJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public int FILGHJLFKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public int OHBCMIBMOPM;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x84BAD50", Offset = "0x84B9750", VA = "0x1884BAD50")]
	public DFJLJEIAGPJ(Entity EOGGAEBALGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[TypeManager.ForcedStableTypeHash(16229383422209788655uL)]
public struct EHBPBPHKOJJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public CollisionDetectionMode JFCHAKMLCCK;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[TypeManager.ForcedStableTypeHash(5173865590150727846uL)]
[RegisterComponentDefault]
public struct ODLIGMNDAAH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public CNMJFAPGOOG EALFHFBCJIN;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly ODLIGMNDAAH MDAKIDAOHEC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000042")]
[TypeManager.ForcedStableTypeHash(7051356195299730219uL)]
public struct PEDCANDBPIK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000043")]
[TypeManager.ForcedStableTypeHash(780557526766205634uL)]
public struct GHNJJKLELKH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000044")]
[TypeManager.ForcedStableTypeHash(16413322458062516985uL)]
public struct BODBEBIJAIF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[InternalBufferCapacity(0)]
[TypeManager.ForcedStableTypeHash(8350832327674051347uL)]
public struct KCDDOIADMDE : IBufferElementData, IEquatable<KCDDOIADMDE>, HNBIGGMBGLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Entity KOAIHIGOIMD;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity DLCNFBOECPH
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x84BA860", Offset = "0x84B9260", VA = "0x1884BA860", Slot = "4")]
	public bool Equals(KCDDOIADMDE EFNHKCDKOGH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[TypeManager.ForcedStableTypeHash(3503423083784418805uL)]
public struct CCEBCEHGKME : IComponentData, HNBIGGMBGLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public Entity DFKFFPKHNCH;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Entity DLCNFBOECPH
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
[TypeManager.ForcedStableTypeHash(14551834985136520975uL)]
public struct DHGILGHJMFN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[TypeManager.ForcedStableTypeHash(4388378139562737487uL)]
public struct AKPBLHANLHM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Entity PJFDNMGHMBL;
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct LJPKCHMCBAB : FJDBCBNBCHI, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public KFBMKOPGMCG CPGCEJBKJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(KFBMKOPGMCG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[TypeManager.ForcedStableTypeHash(769086036388751339uL)]
public struct JFGHIJGPDBE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public float3 OKPCFNDIFLN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004B")]
[TypeManager.ForcedStableTypeHash(15638082890667179775uL)]
public struct IPJLHIFNLGC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(7040629969868025973uL)]
public struct LFOEMABICNN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public float3x3 BOFAILPOFPI;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly LFOEMABICNN MDAKIDAOHEC;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[TypeManager.ForcedStableTypeHash(1290915447730818204uL)]
[RegisterComponentDefault]
public struct FLPADHKLCKM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public float3x3 BOFAILPOFPI;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly FLPADHKLCKM MDAKIDAOHEC;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[TypeManager.ForcedStableTypeHash(7667208078276643555uL)]
public struct CCEDGIINPCM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float3 HPOEMBFHKEI;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[TypeManager.ForcedStableTypeHash(11475279934298573286uL)]
public struct GIJDOIKEGNO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public float3 BIOCFJJOINE;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(18413785019621221410uL)]
public struct PLEEGCMOPPN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float ADNEPMIFGIC;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly PLEEGCMOPPN MDAKIDAOHEC;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(16788150452972582455uL)]
public struct ACBOFDGHCAN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float KDAIFIBAGKB;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly ACBOFDGHCAN MDAKIDAOHEC;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[TypeManager.ForcedStableTypeHash(971312552983123380uL)]
public struct HLALLIGABOI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 LMOJGFOMNLM;
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[TypeManager.ForcedStableTypeHash(361641396811542242uL)]
public struct BKGEKDMFIHK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public EJPCFNJKDCP PNNMBEKNGNK;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[TypeManager.ForcedStableTypeHash(7520974846918069913uL)]
[SingletonComponent]
public struct EAADMMDDBAO : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public Entity EOGGAEBALGK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
[TypeManager.ForcedStableTypeHash(9260549625364734686uL)]
public struct GBKPPGGJAAM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
[TypeManager.ForcedStableTypeHash(469905343419662571uL)]
public struct HEFAHJIONIM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[TypeManager.ForcedStableTypeHash(7865784707562564105uL)]
public struct BFGKOONNHDB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public RigidbodyConstraints AMKDAJKEPNO;
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[TypeManager.ForcedStableTypeHash(7877027338327956319uL)]
[RegisterComponentDefault]
public struct DNCIOIMFGFG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float PPMELLOMIIG;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly DNCIOIMFGFG MDAKIDAOHEC;
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[TypeManager.ForcedStableTypeHash(935406425377786813uL)]
public struct FDGOBLBGFKJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float GOBMCPDJAGA;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class FHMFFFKKMPG : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public GameObject CEENMGBCJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public object LKBHNBGNNKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public object IGCFCDIAPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public BAPEBGBNCLI FFIKJGPFGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Delegate AFGHIAGNGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Delegate BNOMFODCOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public MFJNMJILDKH<Delegate> NJIIMMLPCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public MFJNMJILDKH<Delegate> ILILINPHIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public MFJNMJILDKH<Delegate> CEHBCABDJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public MFJNMJILDKH<Delegate> OGDCCEGJOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public MFJNMJILDKH<Delegate> BFPEGDPBCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public MFJNMJILDKH<Delegate> LCMPCFLLGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public MFJNMJILDKH<Delegate> CDFHOIANMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public MFJNMJILDKH<Delegate> PFEMPACPCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public MFJNMJILDKH<Delegate> HDKEFKBJDBG;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x84BB060", Offset = "0x84B9A60", VA = "0x1884BB060", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public FHMFFFKKMPG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
[TypeManager.ForcedStableTypeHash(9555099704367481551uL)]
public struct HALPBBMIOGN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
[TypeManager.ForcedStableTypeHash(18165447863202358792uL)]
public struct GKJFBAGPMCE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[TypeManager.ForcedStableTypeHash(10810926406358250264uL)]
public struct PMFPJAHJEJO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public int AOJHCGLBGJJ;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2120A70", Offset = "0x211F470", VA = "0x182120A70")]
	public static PMFPJAHJEJO LHJBCIIELME(int PDKJBMPOMNC)
	{
		return default(PMFPJAHJEJO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class PJHGOOHJBOL : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Rigidbody HKGICDHJGKC;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x84BD070", Offset = "0x84BBA70", VA = "0x1884BD070", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public PJHGOOHJBOL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
[TypeManager.ForcedStableTypeHash(12765569839950265583uL)]
public struct JEANEFLHDBL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[TypeManager.ForcedStableTypeHash(17236748096909814533uL)]
public struct BIALBEJPJPP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float3 JMCMALMHEEL;
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[TypeManager.ForcedStableTypeHash(1288392478539867023uL)]
public struct JHHNJNJDDNN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public float3 GINLPEHDJCD;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(15102898512288820575uL)]
public struct PHAGLEGHDCO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public float FOKPMGJBGBH;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly PHAGLEGHDCO MDAKIDAOHEC;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class FPKOBJECKGM : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public object KAJFOLMPNCF;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x84BB1B0", Offset = "0x84B9BB0", VA = "0x1884BB1B0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public FPKOBJECKGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class AFIFJGOFAIO : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public object JNIGDFIJJPN;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x84BA7D0", Offset = "0x84B91D0", VA = "0x1884BA7D0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public AFIFJGOFAIO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
[TypeManager.ForcedStableTypeHash(3505189951659289292uL)]
public struct IFFLEFCDABL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
[TypeManager.ForcedStableTypeHash(16217323095468023009uL)]
public struct MGHLLBJGEIM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
[TypeManager.ForcedStableTypeHash(12880717127246424414uL)]
public struct EDIKJJJOKDO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
[TypeManager.ForcedStableTypeHash(12942629461400744171uL)]
public struct MHGAIEOEBNK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
[TypeManager.ForcedStableTypeHash(10226241216405964379uL)]
public struct ECIJJJAKFGK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
[TypeManager.ForcedStableTypeHash(12400259538654257671uL)]
public struct BODFNOHEKCD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
[TypeManager.ForcedStableTypeHash(12731949941800560397uL)]
public struct MFPEEHCKHKG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
[TypeManager.ForcedStableTypeHash(16270799832065682331uL)]
public struct AMEJLHIOODD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
[TypeManager.ForcedStableTypeHash(9395080039644288849uL)]
public struct EDGINODOGLN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
[TypeManager.ForcedStableTypeHash(15229363233412980908uL)]
public struct BPNFMDDHJEO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[TypeManager.ForcedStableTypeHash(282623311697096978uL)]
public struct JGIKKLGBBBB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public EFJKAGJCDIF IPENDGIIFGC;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x84BC020", Offset = "0x84BAA20", VA = "0x1884BC020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
[TypeManager.ForcedStableTypeHash(10395819776101408141uL)]
public struct LIHDJAFIKJN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
[TypeManager.ForcedStableTypeHash(375953524326549120uL)]
public struct KKEDKBMAMFN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
[TypeManager.ForcedStableTypeHash(14259779488802476986uL)]
public struct PHDNEICLHPH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[TypeManager.ForcedStableTypeHash(15330221065042235480uL)]
public struct KHGFAEJNAAB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public FixedString32Bytes FLBFBHGDBLM;
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(5162925656869367991uL)]
public struct LOEKGOMCOIC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public UnsafeParallelHashMap<EFJKAGJCDIF, Entity> EBIDCBFHANN;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[TypeManager.ForcedStableTypeHash(9841032716800521808uL)]
public struct MOAIGHIKIIC : ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Entity GHMOGFOHDHP;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[TypeManager.ForcedStableTypeHash(154813247653871879uL)]
internal struct OLEEFIFMBKM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Entity EOGGAEBALGK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xDE25D0", Offset = "0xDE0FD0", VA = "0x180DE25D0")]
	public static OLEEFIFMBKM LHJBCIIELME(Entity EOGGAEBALGK)
	{
		return default(OLEEFIFMBKM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[TypeManager.ForcedStableTypeHash(11656653634719673845uL)]
public struct OEHHDKODLKE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Entity MNBFOLHDKGC;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[TypeManager.ForcedStableTypeHash(1837719173092935466uL)]
public struct JEOKMPELLCK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Entity MNBFOLHDKGC;
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[TypeManager.ForcedStableTypeHash(17382237360022739174uL)]
internal struct PHGJEPGJNNH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Entity OMKBLJLOFFB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xDE25D0", Offset = "0xDE0FD0", VA = "0x180DE25D0")]
	public static PHGJEPGJNNH LHJBCIIELME(Entity EOGGAEBALGK)
	{
		return default(PHGJEPGJNNH);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
[TypeManager.ForcedStableTypeHash(15858722173278118533uL)]
internal struct FFLCFADDCAG : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[TypeManager.ForcedStableTypeHash(10313790595830381076uL)]
public struct DPHEJEAMBFO : IBufferElementData, IEquatable<DPHEJEAMBFO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Entity PKPIFEMAIAE;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x82AA910", Offset = "0x82A9310", VA = "0x1882AA910", Slot = "4")]
	public bool Equals(DPHEJEAMBFO EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x84BAE50", Offset = "0x84B9850", VA = "0x1884BAE50", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xD893D0", Offset = "0xD87DD0", VA = "0x180D893D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[TypeManager.ForcedStableTypeHash(10169361040328370708uL)]
public struct KOAGEGPNIGH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public uint OHBCMIBMOPM;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(11536226225076729790uL)]
internal struct DFACKGDEHHO : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Entity NEKKAKABMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public int FILGHJLFKAL;
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[TypeManager.ForcedStableTypeHash(8309037880064337491uL)]
internal struct HEEGOMMAGLC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Entity JOBEDKBFIEJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
[TypeManager.ForcedStableTypeHash(5891816987223099091uL)]
public struct MICGBIPMAAH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[TypeManager.ForcedStableTypeHash(17289298604600812224uL)]
public struct OJOOEIMCEGA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public uint CFPAOOCPAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public int FNCFBFJAEOA;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xE83310", Offset = "0xE81D10", VA = "0x180E83310")]
	public OJOOEIMCEGA(uint JJIIMOGBBAG, int BLFBOJKHPAK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
[TypeManager.ForcedStableTypeHash(12258100538258701401uL)]
public struct KACGAMPOOIJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
[TypeManager.ForcedStableTypeHash(3081870877980445988uL)]
public struct KADDKECKICD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
[TypeManager.ForcedStableTypeHash(15554741495161407507uL)]
public struct HNLLANKDELC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
[TypeManager.ForcedStableTypeHash(17684057078056878475uL)]
public struct JPIGHFOPPDC : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000085")]
[TypeManager.ForcedStableTypeHash(10023455309444528896uL)]
public struct JFDCCMGNLHI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
[TypeManager.ForcedStableTypeHash(14403752119546393228uL)]
public struct IDFHMLGLPBP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
[TypeManager.ForcedStableTypeHash(9219181242087356214uL)]
public struct OEPFPKJFFPK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
[TypeManager.ForcedStableTypeHash(12371658133244024718uL)]
public struct FKKOGBGFEPK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
[TypeManager.ForcedStableTypeHash(9351414359236295489uL)]
public struct FHMHDCNMPBP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
[TypeManager.ForcedStableTypeHash(12796707860320869007uL)]
internal struct BABLONINKEI : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
[TypeManager.ForcedStableTypeHash(13367368557807690484uL)]
public struct DLNGIENEAPB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008C")]
[TypeManager.ForcedStableTypeHash(7193071459223094579uL)]
public struct IBBLHPFFCAA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
[TypeManager.ForcedStableTypeHash(17039127292426947163uL)]
public struct KIJMDJFAANB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008E")]
[TypeManager.ForcedStableTypeHash(15247343901949961769uL)]
public struct GEICLODCCEC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
[TypeManager.ForcedStableTypeHash(5381043565870728787uL)]
public struct IPODNFJKAII : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
[TypeManager.ForcedStableTypeHash(11597028615900234104uL)]
internal struct LFGGCEFEMBB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
[TypeManager.ForcedStableTypeHash(1907494159895213433uL)]
internal struct JCKLKMFNJIG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000092")]
[TypeManager.ForcedStableTypeHash(3955886960983597628uL)]
public struct ECOGHNLGMJI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000093")]
[TypeManager.ForcedStableTypeHash(480620745253244652uL)]
public struct CJFBEDPAONC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000094")]
[TypeManager.ForcedStableTypeHash(8253675824478287824uL)]
public struct BIPLHKLEAJJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000095")]
[TypeManager.ForcedStableTypeHash(8855488771047251567uL)]
public struct ICBACMPJHOP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000096")]
[TypeManager.ForcedStableTypeHash(8375777954271012995uL)]
public struct PGBJKEBIIHC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
[TypeManager.ForcedStableTypeHash(16778215356980427836uL)]
public struct PMCPAKEJFHN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000098")]
[TypeManager.ForcedStableTypeHash(16444804027614993581uL)]
public struct IMDCNCMPLGC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000099")]
[TypeManager.ForcedStableTypeHash(16177323740107409537uL)]
public struct KIKLBALIING : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
[TypeManager.ForcedStableTypeHash(11049752089067741804uL)]
public struct JIFAECAGFBF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009B")]
[TypeManager.ForcedStableTypeHash(1453937769327886583uL)]
public struct GAJCJCBLPAD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
[TypeManager.ForcedStableTypeHash(800754555681830909uL)]
public struct OABFLBDNOFN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009D")]
[TypeManager.ForcedStableTypeHash(3336901602667819150uL)]
public struct GGMLONOCBLL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009E")]
[TypeManager.ForcedStableTypeHash(11809750536411032401uL)]
public struct CPCKIOPMCEK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
[TypeManager.ForcedStableTypeHash(6387004770090400669uL)]
public struct AIOMGIDJBHB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[TypeManager.ForcedStableTypeHash(2223159712203397538uL)]
internal struct EJDENHONKEJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[TypeManager.ForcedStableTypeHash(10153397523300334327uL)]
public struct PFBNFNJKBMP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[TypeManager.ForcedStableTypeHash(12983102201306073842uL)]
public struct FDCFJLNJMFC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[DEFLLJFAJAI]
[TypeManager.ForcedStableTypeHash(15398959433761599914uL)]
public struct FEKDJAECINK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6605318152550716456uL)]
public struct NAPMOEJAFCC : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public FixedString32Bytes FLFLJCMPPBA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[TypeManager.ForcedStableTypeHash(10065634662848845784uL)]
public struct LPDHGMAIKBB : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[TypeManager.ForcedStableTypeHash(15062299176839263439uL)]
public struct NNIGGPDJLJD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[TypeManager.ForcedStableTypeHash(3596269116834888123uL)]
internal struct IFDCCBDPMEC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[TypeManager.ForcedStableTypeHash(4402941654898007496uL)]
internal struct MCLHLOMDPJF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[TypeManager.ForcedStableTypeHash(12682474121528142025uL)]
internal struct BLJKHGMEEEA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[TypeManager.ForcedStableTypeHash(1840266485562743455uL)]
public struct PJGEBHPLOBG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[TypeManager.ForcedStableTypeHash(15820134490602808056uL)]
public struct FKGHHDNDFAL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public int LLAOHLFNGCP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[TypeManager.ForcedStableTypeHash(4772574226205567794uL)]
public struct HEDGMDEAGDD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[TypeManager.ForcedStableTypeHash(17642911464827038147uL)]
public struct NLNFODCLJAA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public quaternion JCDLBIBEGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public float3 DDIHIBMHCDH;
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[TypeManager.ForcedStableTypeHash(9066921186040058989uL)]
public struct DJMKDIFABOI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public float KCLCGCNNGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public float HMJGCFFNBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public float MFHNOMFGJKA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[TypeManager.ForcedStableTypeHash(3328998613642473514uL)]
public struct FAENCHCPCKK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[TypeManager.ForcedStableTypeHash(151116349382904900uL)]
public struct DPALFKMIGAI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[TypeManager.ForcedStableTypeHash(8067675582152570601uL)]
public struct KBHADJCNCAL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[TypeManager.ForcedStableTypeHash(4522686316477281096uL)]
public struct NNOHFCMJPMA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public int PCJBPIKLFBM;
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6216404920432680992uL)]
public struct PGMOIFOLLLE : ISystemStateBufferElementData, IBufferElementData, HNBIGGMBGLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Entity IKAEKOBLDMB;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity EODELNCODMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(419884688393735449uL)]
public struct HHLPJFBOKMD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public float4x4 KEOPNJLEGAL;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static readonly HHLPJFBOKMD MDAKIDAOHEC;
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(1954795745923300919uL)]
public struct OIFOOJEKLFL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public float4x4 CNNCGMLGFMG;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public static readonly OIFOOJEKLFL MDAKIDAOHEC;
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[TypeManager.ForcedStableTypeHash(2447627752265109178uL)]
public struct APKDENHGFBA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int AJNFKPPJEID;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int FILGHJLFKAL
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x84BA850", Offset = "0x84B9250", VA = "0x1884BA850")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x84BA840", Offset = "0x84B9240", VA = "0x1884BA840")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[TypeManager.ForcedStableTypeHash(13706996280046618062uL)]
[RegisterComponentDefault]
public struct JFOCBBLEMOB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public float3 DDIHIBMHCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public quaternion JCDLBIBEGAF;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public static readonly JFOCBBLEMOB MDAKIDAOHEC;
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public static class MEBOICCLCMC
{
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[TypeManager.ForcedStableTypeHash(77694943841979493uL)]
[RegisterComponentDefault]
public struct CFDILIGPJFN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public float NNHKPGHHFBM;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public static readonly CFDILIGPJFN MDAKIDAOHEC;
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[TypeManager.ForcedStableTypeHash(6537711325103434903uL)]
public struct AFBDHCAHJDH : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public Entity KIJPAPAKCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public MOLGCNIPLLK DOFFGKPAKJD;
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[TypeManager.ForcedStableTypeHash(5471640964865828061uL)]
public struct IJDJEOKANHC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public MOLGCNIPLLK DOFFGKPAKJD;
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[TypeManager.ForcedStableTypeHash(16527934868211432802uL)]
public struct NOKJPMGHHNB : ISystemStateComponentData, IComponentData, HNBIGGMBGLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Entity ICBGFNPAHKN;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Entity EODELNCODMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[TypeManager.ForcedStableTypeHash(15310407062508355916uL)]
public struct IEDLINEKGIE : ISystemStateBufferElementData, IBufferElementData, HNBIGGMBGLM, IEquatable<IEDLINEKGIE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public Entity PEMHCMGLLNL;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Entity EODELNCODMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x82AA910", Offset = "0x82A9310", VA = "0x1882AA910", Slot = "6")]
	public bool Equals(IEDLINEKGIE EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x84BB680", Offset = "0x84BA080", VA = "0x1884BB680", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xD893D0", Offset = "0xD87DD0", VA = "0x180D893D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[TypeManager.ForcedStableTypeHash(11786768220100978132uL)]
public struct KDBKNENGPCL : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public Entity KIJPAPAKCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public MOLGCNIPLLK DOFFGKPAKJD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public struct DIIJIHBJKAA : IEqualityComparer<KDBKNENGPCL>
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static DIIJIHBJKAA MDAKIDAOHEC;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x84BAD60", Offset = "0x84B9760", VA = "0x1884BAD60", Slot = "4")]
	public bool Equals(KDBKNENGPCL IECENJOJFJH, KDBKNENGPCL OFOCBNJJIJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x84BADB0", Offset = "0x84B97B0", VA = "0x1884BADB0", Slot = "5")]
	public int GetHashCode(KDBKNENGPCL CEFJEHJNIAP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[TypeManager.ForcedStableTypeHash(8981997360983277121uL)]
public struct LIJEDBJACAJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public FixedList32Bytes<int> PGEBFDGIMJK;
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[TypeManager.ForcedStableTypeHash(2801212869002544047uL)]
public struct BHCNAHMCPAH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public FixedList32Bytes<int> PGEBFDGIMJK;
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[TypeManager.ForcedStableTypeHash(16455485691096333919uL)]
public struct CPGGEOKLGOK : ISystemStateBufferElementData, IBufferElementData, HNBIGGMBGLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public Entity JIKPFILDPHL;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Entity DLCNFBOECPH
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xB1D6E0", Offset = "0xB1C0E0", VA = "0x180B1D6E0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1379BA0", Offset = "0x13785A0", VA = "0x181379BA0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal class AADGMOBNLHP : ContainerPropertyBag<PNAOEEFDDHO>
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private class PGHGGAHFFLB : Property<PNAOEEFDDHO, MBPJOONFHIE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string FAHMGKIDCFD
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x84BD000", Offset = "0x84BBA00", VA = "0x1884BD000", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool CLDNKONDKJO
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x84BCFC0", Offset = "0x84BB9C0", VA = "0x1884BCFC0")]
		public PGHGGAHFFLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x84BAFA0", Offset = "0x84B99A0", VA = "0x1884BAFA0", Slot = "14")]
		public override MBPJOONFHIE GetValue(PNAOEEFDDHO JBOIKIICKBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x84BAFC0", Offset = "0x84B99C0", VA = "0x1884BAFC0", Slot = "15")]
		public override void SetValue(PNAOEEFDDHO JBOIKIICKBA, MBPJOONFHIE PDKJBMPOMNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x84BA5C0", Offset = "0x84B8FC0", VA = "0x1884BA5C0")]
	public AADGMOBNLHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal class JAOFLPFBMDO : ContainerPropertyBag<FHMFFFKKMPG>
{
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	private class FDJHDKAPLBO : Property<FHMFFFKKMPG, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string FAHMGKIDCFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x84BB030", Offset = "0x84B9A30", VA = "0x1884BB030", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool CLDNKONDKJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x84BAFF0", Offset = "0x84B99F0", VA = "0x1884BAFF0")]
		public FDJHDKAPLBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x84BAFA0", Offset = "0x84B99A0", VA = "0x1884BAFA0", Slot = "14")]
		public override GameObject GetValue(FHMFFFKKMPG JBOIKIICKBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x84BAFC0", Offset = "0x84B99C0", VA = "0x1884BAFC0", Slot = "15")]
		public override void SetValue(FHMFFFKKMPG JBOIKIICKBA, GameObject PDKJBMPOMNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	private class JBBNDDJDFPG : Property<FHMFFFKKMPG, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string FAHMGKIDCFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x84BBEC0", Offset = "0x84BA8C0", VA = "0x1884BBEC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool CLDNKONDKJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x84BBE80", Offset = "0x84BA880", VA = "0x1884BBE80")]
		public JBBNDDJDFPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x84BBE30", Offset = "0x84BA830", VA = "0x1884BBE30", Slot = "14")]
		public override object GetValue(FHMFFFKKMPG JBOIKIICKBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x84BBE50", Offset = "0x84BA850", VA = "0x1884BBE50", Slot = "15")]
		public override void SetValue(FHMFFFKKMPG JBOIKIICKBA, object PDKJBMPOMNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	private class FAFCCGEHMBL : Property<FHMFFFKKMPG, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string FAHMGKIDCFD
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x84BAF70", Offset = "0x84B9970", VA = "0x1884BAF70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool CLDNKONDKJO
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x84BAF30", Offset = "0x84B9930", VA = "0x1884BAF30")]
		public FAFCCGEHMBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x84BAEE0", Offset = "0x84B98E0", VA = "0x1884BAEE0", Slot = "14")]
		public override object GetValue(FHMFFFKKMPG JBOIKIICKBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x84BAF00", Offset = "0x84B9900", VA = "0x1884BAF00", Slot = "15")]
		public override void SetValue(FHMFFFKKMPG JBOIKIICKBA, object PDKJBMPOMNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	private class JMDKKJBHBBC : Property<FHMFFFKKMPG, BAPEBGBNCLI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string FAHMGKIDCFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x84BC100", Offset = "0x84BAB00", VA = "0x1884BC100", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool CLDNKONDKJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x84BC0C0", Offset = "0x84BAAC0", VA = "0x1884BC0C0")]
		public JMDKKJBHBBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x84BC070", Offset = "0x84BAA70", VA = "0x1884BC070", Slot = "14")]
		public override BAPEBGBNCLI GetValue(FHMFFFKKMPG JBOIKIICKBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x84BC090", Offset = "0x84BAA90", VA = "0x1884BC090", Slot = "15")]
		public override void SetValue(FHMFFFKKMPG JBOIKIICKBA, BAPEBGBNCLI PDKJBMPOMNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	private class KOFDFGFFHFG : Property<FHMFFFKKMPG, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string FAHMGKIDCFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x84BC220", Offset = "0x84BAC20", VA = "0x1884BC220", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool CLDNKONDKJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x84BC1E0", Offset = "0x84BABE0", VA = "0x1884BC1E0")]
		public KOFDFGFFHFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x84BC190", Offset = "0x84BAB90", VA = "0x1884BC190", Slot = "14")]
		public override Delegate GetValue(FHMFFFKKMPG JBOIKIICKBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x84BC1B0", Offset = "0x84BABB0", VA = "0x1884BC1B0", Slot = "15")]
		public override void SetValue(FHMFFFKKMPG JBOIKIICKBA, Delegate PDKJBMPOMNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	private class CDNNLPFHOAB : Property<FHMFFFKKMPG, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string FAHMGKIDCFD
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x84BABA0", Offset = "0x84B95A0", VA = "0x1884BABA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool CLDNKONDKJO
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x84BAB60", Offset = "0x84B9560", VA = "0x1884BAB60")]
		public CDNNLPFHOAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x84BAB10", Offset = "0x84B9510", VA = "0x1884BAB10", Slot = "14")]
		public override Delegate GetValue(FHMFFFKKMPG JBOIKIICKBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x84BAB30", Offset = "0x84B9530", VA = "0x1884BAB30", Slot = "15")]
		public override void SetValue(FHMFFFKKMPG JBOIKIICKBA, Delegate PDKJBMPOMNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	private class AFDAHFCMEJK : Property<FHMFFFKKMPG, MFJNMJILDKH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string FAHMGKIDCFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x84BA7A0", Offset = "0x84B91A0", VA = "0x1884BA7A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool CLDNKONDKJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x84BA760", Offset = "0x84B9160", VA = "0x1884BA760")]
		public AFDAHFCMEJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x84BA710", Offset = "0x84B9110", VA = "0x1884BA710", Slot = "14")]
		public override MFJNMJILDKH<Delegate> GetValue(FHMFFFKKMPG JBOIKIICKBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x84BA730", Offset = "0x84B9130", VA = "0x1884BA730", Slot = "15")]
		public override void SetValue(FHMFFFKKMPG JBOIKIICKBA, MFJNMJILDKH<Delegate> PDKJBMPOMNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	private class DBFFHDHLICA : Property<FHMFFFKKMPG, MFJNMJILDKH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string FAHMGKIDCFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x84BAD20", Offset = "0x84B9720", VA = "0x1884BAD20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool CLDNKONDKJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x84BACE0", Offset = "0x84B96E0", VA = "0x1884BACE0")]
		public DBFFHDHLICA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x84BAC90", Offset = "0x84B9690", VA = "0x1884BAC90", Slot = "14")]
		public override MFJNMJILDKH<Delegate> GetValue(FHMFFFKKMPG JBOIKIICKBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x84BACB0", Offset = "0x84B96B0", VA = "0x1884BACB0", Slot = "15")]
		public override void SetValue(FHMFFFKKMPG JBOIKIICKBA, MFJNMJILDKH<Delegate> PDKJBMPOMNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	private class IDPADDPFGLA : Property<FHMFFFKKMPG, MFJNMJILDKH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string FAHMGKIDCFD
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x84BB650", Offset = "0x84BA050", VA = "0x1884BB650", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool CLDNKONDKJO
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x84BB610", Offset = "0x84BA010", VA = "0x1884BB610")]
		public IDPADDPFGLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x84BB5C0", Offset = "0x84B9FC0", VA = "0x1884BB5C0", Slot = "14")]
		public override MFJNMJILDKH<Delegate> GetValue(FHMFFFKKMPG JBOIKIICKBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x84BB5E0", Offset = "0x84B9FE0", VA = "0x1884BB5E0", Slot = "15")]
		public override void SetValue(FHMFFFKKMPG JBOIKIICKBA, MFJNMJILDKH<Delegate> PDKJBMPOMNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	private class PCDIPGMKFBL : Property<FHMFFFKKMPG, MFJNMJILDKH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string FAHMGKIDCFD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x84BCE80", Offset = "0x84BB880", VA = "0x1884BCE80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool CLDNKONDKJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x84BCE40", Offset = "0x84BB840", VA = "0x1884BCE40")]
		public PCDIPGMKFBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x84BCDF0", Offset = "0x84BB7F0", VA = "0x1884BCDF0", Slot = "14")]
		public override MFJNMJILDKH<Delegate> GetValue(FHMFFFKKMPG JBOIKIICKBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x84BCE10", Offset = "0x84BB810", VA = "0x1884BCE10", Slot = "15")]
		public override void SetValue(FHMFFFKKMPG JBOIKIICKBA, MFJNMJILDKH<Delegate> PDKJBMPOMNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	private class NDIGMJIDHMA : Property<FHMFFFKKMPG, MFJNMJILDKH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string FAHMGKIDCFD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x84BC710", Offset = "0x84BB110", VA = "0x1884BC710", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool CLDNKONDKJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x84BC6D0", Offset = "0x84BB0D0", VA = "0x1884BC6D0")]
		public NDIGMJIDHMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x84BC680", Offset = "0x84BB080", VA = "0x1884BC680", Slot = "14")]
		public override MFJNMJILDKH<Delegate> GetValue(FHMFFFKKMPG JBOIKIICKBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x84BC6A0", Offset = "0x84BB0A0", VA = "0x1884BC6A0", Slot = "15")]
		public override void SetValue(FHMFFFKKMPG JBOIKIICKBA, MFJNMJILDKH<Delegate> PDKJBMPOMNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	private class IOBKIPKPDOM : Property<FHMFFFKKMPG, MFJNMJILDKH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string FAHMGKIDCFD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x84BB7A0", Offset = "0x84BA1A0", VA = "0x1884BB7A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool CLDNKONDKJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x84BB760", Offset = "0x84BA160", VA = "0x1884BB760")]
		public IOBKIPKPDOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x84BB710", Offset = "0x84BA110", VA = "0x1884BB710", Slot = "14")]
		public override MFJNMJILDKH<Delegate> GetValue(FHMFFFKKMPG JBOIKIICKBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x84BB730", Offset = "0x84BA130", VA = "0x1884BB730", Slot = "15")]
		public override void SetValue(FHMFFFKKMPG JBOIKIICKBA, MFJNMJILDKH<Delegate> PDKJBMPOMNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	private class LHFCMMDKDEH : Property<FHMFFFKKMPG, MFJNMJILDKH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string FAHMGKIDCFD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x84BC5E0", Offset = "0x84BAFE0", VA = "0x1884BC5E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool CLDNKONDKJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x84BC5A0", Offset = "0x84BAFA0", VA = "0x1884BC5A0")]
		public LHFCMMDKDEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x84BC550", Offset = "0x84BAF50", VA = "0x1884BC550", Slot = "14")]
		public override MFJNMJILDKH<Delegate> GetValue(FHMFFFKKMPG JBOIKIICKBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x84BC570", Offset = "0x84BAF70", VA = "0x1884BC570", Slot = "15")]
		public override void SetValue(FHMFFFKKMPG JBOIKIICKBA, MFJNMJILDKH<Delegate> PDKJBMPOMNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	private class ICDPEGJODPJ : Property<FHMFFFKKMPG, MFJNMJILDKH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string FAHMGKIDCFD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x84BB590", Offset = "0x84B9F90", VA = "0x1884BB590", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool CLDNKONDKJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x84BB550", Offset = "0x84B9F50", VA = "0x1884BB550")]
		public ICDPEGJODPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x84BB500", Offset = "0x84B9F00", VA = "0x1884BB500", Slot = "14")]
		public override MFJNMJILDKH<Delegate> GetValue(FHMFFFKKMPG JBOIKIICKBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x84BB520", Offset = "0x84B9F20", VA = "0x1884BB520", Slot = "15")]
		public override void SetValue(FHMFFFKKMPG JBOIKIICKBA, MFJNMJILDKH<Delegate> PDKJBMPOMNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	private class KPGEHOPPLJJ : Property<FHMFFFKKMPG, MFJNMJILDKH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string FAHMGKIDCFD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x84BC2E0", Offset = "0x84BACE0", VA = "0x1884BC2E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool CLDNKONDKJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x84BC2A0", Offset = "0x84BACA0", VA = "0x1884BC2A0")]
		public KPGEHOPPLJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x84BC250", Offset = "0x84BAC50", VA = "0x1884BC250", Slot = "14")]
		public override MFJNMJILDKH<Delegate> GetValue(FHMFFFKKMPG JBOIKIICKBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x84BC270", Offset = "0x84BAC70", VA = "0x1884BC270", Slot = "15")]
		public override void SetValue(FHMFFFKKMPG JBOIKIICKBA, MFJNMJILDKH<Delegate> PDKJBMPOMNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x84BB7D0", Offset = "0x84BA1D0", VA = "0x1884BB7D0")]
	public JAOFLPFBMDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal class BKAOAFHHBPL : ContainerPropertyBag<MFJNMJILDKH<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x84BAAB0", Offset = "0x84B94B0", VA = "0x1884BAAB0")]
	public BKAOAFHHBPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal class PGBJLCGKGDL : ContainerPropertyBag<PJHGOOHJBOL>
{
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	private class PJIFDIOJMFB : Property<PJHGOOHJBOL, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string FAHMGKIDCFD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x84BD120", Offset = "0x84BBB20", VA = "0x1884BD120", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool CLDNKONDKJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x84BD0E0", Offset = "0x84BBAE0", VA = "0x1884BD0E0")]
		public PJIFDIOJMFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x84BAFA0", Offset = "0x84B99A0", VA = "0x1884BAFA0", Slot = "14")]
		public override Rigidbody GetValue(PJHGOOHJBOL JBOIKIICKBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x84BAFC0", Offset = "0x84B99C0", VA = "0x1884BAFC0", Slot = "15")]
		public override void SetValue(PJHGOOHJBOL JBOIKIICKBA, Rigidbody PDKJBMPOMNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x84BCEE0", Offset = "0x84BB8E0", VA = "0x1884BCEE0")]
	public PGBJLCGKGDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal class OJGMPMCFPHB : ContainerPropertyBag<FPKOBJECKGM>
{
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	private class GNOODGGHKBG : Property<FPKOBJECKGM, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string FAHMGKIDCFD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x84BB340", Offset = "0x84B9D40", VA = "0x1884BB340", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool CLDNKONDKJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x84BB300", Offset = "0x84B9D00", VA = "0x1884BB300")]
		public GNOODGGHKBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x84BAFA0", Offset = "0x84B99A0", VA = "0x1884BAFA0", Slot = "14")]
		public override object GetValue(FPKOBJECKGM JBOIKIICKBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x84BAFC0", Offset = "0x84B99C0", VA = "0x1884BAFC0", Slot = "15")]
		public override void SetValue(FPKOBJECKGM JBOIKIICKBA, object PDKJBMPOMNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x84BC9A0", Offset = "0x84BB3A0", VA = "0x1884BC9A0")]
	public OJGMPMCFPHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal class HNBEJIMGCNN : ContainerPropertyBag<AFIFJGOFAIO>
{
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	private class LOBOOJJNHCK : Property<AFIFJGOFAIO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string FAHMGKIDCFD
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x84BC650", Offset = "0x84BB050", VA = "0x1884BC650", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool CLDNKONDKJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x84BC610", Offset = "0x84BB010", VA = "0x1884BC610")]
		public LOBOOJJNHCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x84BAFA0", Offset = "0x84B99A0", VA = "0x1884BAFA0", Slot = "14")]
		public override object GetValue(AFIFJGOFAIO JBOIKIICKBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x84BAFC0", Offset = "0x84B99C0", VA = "0x1884BAFC0", Slot = "15")]
		public override void SetValue(AFIFJGOFAIO JBOIKIICKBA, object PDKJBMPOMNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x84BB420", Offset = "0x84B9E20", VA = "0x1884BB420")]
	public HNBEJIMGCNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
internal class GFPDENOPPOE : ContainerPropertyBag<MOAIGHIKIIC>
{
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	private class CFJNDJMELAL : Property<MOAIGHIKIIC, Entity>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string FAHMGKIDCFD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x84BAC60", Offset = "0x84B9660", VA = "0x1884BAC60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool CLDNKONDKJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x84BAC20", Offset = "0x84B9620", VA = "0x1884BAC20")]
		public CFJNDJMELAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xAEEC90", Offset = "0xAED690", VA = "0x180AEEC90", Slot = "14")]
		public override Entity GetValue(MOAIGHIKIIC JBOIKIICKBA)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x84BAC10", Offset = "0x84B9610", VA = "0x1884BAC10", Slot = "15")]
		public override void SetValue(MOAIGHIKIIC JBOIKIICKBA, Entity PDKJBMPOMNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x84BB220", Offset = "0x84B9C20", VA = "0x1884BB220")]
	public GFPDENOPPOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class LANICPMEMNN : ContainerPropertyBag<Entity>
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	private class NHLAGJNEPDF : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string FAHMGKIDCFD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x84BC800", Offset = "0x84BB200", VA = "0x1884BC800", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool CLDNKONDKJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x84BC7C0", Offset = "0x84BB1C0", VA = "0x1884BC7C0")]
		public NHLAGJNEPDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x14249B0", Offset = "0x14233B0", VA = "0x1814249B0", Slot = "14")]
		public override int GetValue(Entity JBOIKIICKBA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x82A46E0", Offset = "0x82A30E0", VA = "0x1882A46E0", Slot = "15")]
		public override void SetValue(Entity JBOIKIICKBA, int PDKJBMPOMNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private class NFHMLNADNKF : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string FAHMGKIDCFD
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x84BC790", Offset = "0x84BB190", VA = "0x1884BC790", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool CLDNKONDKJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x84BC750", Offset = "0x84BB150", VA = "0x1884BC750")]
		public NFHMLNADNKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1388890", Offset = "0x1387290", VA = "0x181388890", Slot = "14")]
		public override int GetValue(Entity JBOIKIICKBA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x84BC740", Offset = "0x84BB140", VA = "0x1884BC740", Slot = "15")]
		public override void SetValue(Entity JBOIKIICKBA, int PDKJBMPOMNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x84BC310", Offset = "0x84BAD10", VA = "0x1884BC310")]
	public LANICPMEMNN()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x84BD200", Offset = "0x84BBC00", VA = "0x1884BD200")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public class IFNBIANOKDF
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public IFNBIANOKDF()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public class RbexHierarchyParentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
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
