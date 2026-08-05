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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DC0D40", Offset = "0x7DBF340", VA = "0x187DC0D40", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7DC10D0", Offset = "0x7DBF6D0", VA = "0x187DC10D0", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2645EC0", Offset = "0x26444C0", VA = "0x182645EC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
[TypeManager.ForcedStableTypeHash(1586941204353847852uL)]
public struct LAHKAEHJLAI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
[TypeManager.ForcedStableTypeHash(1730701010008160003uL)]
public struct NJAECPEMNON : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
[TypeManager.ForcedStableTypeHash(3399609037308777919uL)]
public struct MGHKAFECNEJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
[TypeManager.ForcedStableTypeHash(18083619841998483100uL)]
public struct GGFHDPBANLM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
[TypeManager.ForcedStableTypeHash(12361415346715948123uL)]
public struct IMNNODEJLGI : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[TypeManager.ForcedStableTypeHash(15820941866177188261uL)]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : IBufferElementData, IEquatable<AuthoredChildBuffer>, OJDFJPEFOBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7DBDCE0", Offset = "0x7DBC2E0", VA = "0x187DBDCE0", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC7C260", Offset = "0xC7A860", VA = "0x180C7C260")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
[TypeManager.ForcedStableTypeHash(7794731847884836165uL)]
public struct BCCDBADMABG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
[TypeManager.ForcedStableTypeHash(16414266906034106824uL)]
public struct MOPGAMPCIJA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[TypeManager.ForcedStableTypeHash(1525018888797798356uL)]
public struct FGCEPNGLJJO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Entity MCFONGBDAIM;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[TypeManager.ForcedStableTypeHash(6294257411443737851uL)]
public struct PIICJJPKMLC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity MCFONGBDAIM;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct HELBNGOMAOP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<KDPBGKODFLO> IFAAKOAPAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<Entity> EJADPJNLODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private JobHandle GMNPCPDAADC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool AHPBLIDLKJE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE8E0", Offset = "0x7DBCEE0", VA = "0x187DBE8E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE950", Offset = "0x7DBCF50", VA = "0x187DBE950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5C1D860", Offset = "0x5C1BE60", VA = "0x185C1D860")]
	public HELBNGOMAOP(NativeList<KDPBGKODFLO> IFAAKOAPAMH, NativeList<Entity> EJADPJNLODD, JobHandle GMNPCPDAADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7DBE9A0", Offset = "0x7DBCFA0", VA = "0x187DBE9A0")]
	public (Entity, NativeSlice<Entity>) PKDKKJHIOCH(int DEBKJNNAPAB)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7DBE880", Offset = "0x7DBCE80", VA = "0x187DBE880", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct KDPBGKODFLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Entity KNNDNAPJIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int LLPAIMMACAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int DDGBDMFPMAI;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DPMBPIGHIIN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LHLDIAMGMIF(bool EFBCJFFMEBM);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct IFBFDABBFAD : IEquatable<IFBFDABBFAD>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate bool JKEJLIJKGJO(int GIBLACJPDHG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly bool IDJEGMPCCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool FKAHCMHJDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool DOKBADFBNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool IAFGCFILNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly JKEJLIJKGJO DGMKFAGGAKB;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7DBEF90", Offset = "0x7DBD590", VA = "0x187DBEF90")]
	public IFBFDABBFAD(HGKJLDPCHCO EIBMLBPPJAJ, JKEJLIJKGJO DGMKFAGGAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7DBEF60", Offset = "0x7DBD560", VA = "0x187DBEF60")]
	public IFBFDABBFAD(bool IDJEGMPCCPP, bool FKAHCMHJDJP, bool DOKBADFBNID, bool IAFGCFILNJL, JKEJLIJKGJO DGMKFAGGAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7DBEC70", Offset = "0x7DBD270", VA = "0x187DBEC70")]
	public bool ACAHNGCJBAO(int GIBLACJPDHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7DBECA0", Offset = "0x7DBD2A0", VA = "0x187DBECA0")]
	public bool BINHIJPIKID(int GIBLACJPDHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7DBECD0", Offset = "0x7DBD2D0", VA = "0x187DBECD0")]
	public bool DKAEPPGMFBI(int GIBLACJPDHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7DBEEA0", Offset = "0x7DBD4A0", VA = "0x187DBEEA0")]
	public bool OIAKNMFJBKL(int GIBLACJPDHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7DBEDD0", Offset = "0x7DBD3D0", VA = "0x187DBEDD0", Slot = "4")]
	public bool Equals(IFBFDABBFAD MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7DBED20", Offset = "0x7DBD320", VA = "0x187DBED20", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7DBEE00", Offset = "0x7DBD400", VA = "0x187DBEE00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7DBED00", Offset = "0x7DBD300", VA = "0x187DBED00")]
	private bool EAPGLLPLBMM(int GIBLACJPDHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7DBEED0", Offset = "0x7DBD4D0", VA = "0x187DBEED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(14250400792429278320uL)]
public struct CAAGFONPFME : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(14910416840255214023uL)]
public struct FLGKBLPOFKF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
[TypeManager.ForcedStableTypeHash(10891474712127242783uL)]
public struct MIKJIEMJJDM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[InternalBufferCapacity(17)]
[TypeManager.ForcedStableTypeHash(613937678496137215uL)]
public struct PIFMNNIGMLB : IBufferElementData, IEquatable<PIFMNNIGMLB>, OJDFJPEFOBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity HMCFPGIFOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public int DCKHPKBNAHB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private Entity PDEPLAGMOLE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7DC03E0", Offset = "0x7DBE9E0", VA = "0x187DC03E0", Slot = "4")]
	public bool Equals(PIFMNNIGMLB MIJLJBIHDMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GGDALAGJMMI : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public BENOGLOIGDB FPNICFGNJFG;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7DBE530", Offset = "0x7DBCB30", VA = "0x187DBE530", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public GGDALAGJMMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface BENOGLOIGDB
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(1690080301203719739uL)]
public struct FFNLKOOMPLH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[TypeManager.ForcedStableTypeHash(13667964378929084748uL)]
public readonly struct INIDJELMJAF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly JPFHKPMJGOM AFDADOBMIND;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2DD6C20", Offset = "0x2DD5220", VA = "0x182DD6C20")]
	public INIDJELMJAF(JPFHKPMJGOM AFDADOBMIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7DBF1B0", Offset = "0x7DBD7B0", VA = "0x187DBF1B0")]
	public INIDJELMJAF JPBKKMBKMOL(JPFHKPMJGOM LIHCEHHFJNO)
	{
		return default(INIDJELMJAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7DBF1A0", Offset = "0x7DBD7A0", VA = "0x187DBF1A0")]
	public INIDJELMJAF CJLLDADIMGH(JPFHKPMJGOM KMMBKGLIGEF)
	{
		return default(INIDJELMJAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7DBF1C0", Offset = "0x7DBD7C0", VA = "0x187DBF1C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[Flags]
public enum JPFHKPMJGOM : ushort
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
public static class KOKHBFDGPID
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(1995886936411817354uL)]
[SingletonComponent]
public struct OEMIFBKHIKN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public JPFHKPMJGOM MEIGEJIJMFC;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7DC0110", Offset = "0x7DBE710", VA = "0x187DC0110")]
	public bool DJCKFIDIABF(INIDJELMJAF EJEBDHOKGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7DC0120", Offset = "0x7DBE720", VA = "0x187DC0120")]
	public bool FPNBICEDBLO(INIDJELMJAF EJEBDHOKGAM, JPFHKPMJGOM OPIJJHDOHGK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[Flags]
public enum NELDGKDEPJK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(12096894998449299302uL)]
public struct FDABMKLOFCL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NELDGKDEPJK AFDADOBMIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public bool PFFJLCJMPEB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool IEIOHHJICPC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE2B0", Offset = "0x7DBC8B0", VA = "0x187DBE2B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7DBE2E0", Offset = "0x7DBC8E0", VA = "0x187DBE2E0")]
	private FDABMKLOFCL(NELDGKDEPJK AFDADOBMIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7DBE2C0", Offset = "0x7DBC8C0", VA = "0x187DBE2C0")]
	public FDABMKLOFCL JPBKKMBKMOL(NELDGKDEPJK LIHCEHHFJNO)
	{
		return default(FDABMKLOFCL);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7DBE290", Offset = "0x7DBC890", VA = "0x187DBE290")]
	public FDABMKLOFCL CJLLDADIMGH(NELDGKDEPJK KMMBKGLIGEF)
	{
		return default(FDABMKLOFCL);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
[TypeManager.ForcedStableTypeHash(3210980466644930997uL)]
public struct OMKMLFBNMEA : IComponentData
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
public struct FIAJGLFHFPD : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity JGJALDBANCO;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[InternalBufferCapacity(8)]
	[TypeManager.ForcedStableTypeHash(2803523268494646145uL)]
	public struct ChildBuffer : IBufferElementData, IEquatable<ChildBuffer>, OJDFJPEFOBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7DBDCE0", Offset = "0x7DBC2E0", VA = "0x187DBDCE0", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xC7C260", Offset = "0xC7A860", VA = "0x180C7C260")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6734819606313844273uL)]
public struct GINCLLHDPHN : ISystemStateBufferElementData, IBufferElementData, OJDFJPEFOBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public Entity IOGPJKLGKKO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Entity MFOJDPOEONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[TypeManager.ForcedStableTypeHash(10606242260416974827uL)]
public struct FEPAEBIDLDC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public Entity HDBLBJIMMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public Entity MEKNILHIBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Entity OGEABCEPMDD;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct PDOCKKKBDEK<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly bool LKIDIFGHMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public uint BGLNIPGDAPO;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool LPHHPOHGOPK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[TypeManager.ForcedStableTypeHash(14518013333183728344uL)]
[TypeManager.TypeVersion(2)]
public struct HMPMPJIHGEA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public uint NDICPILKAON;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x12AC0B0", Offset = "0x12AA6B0", VA = "0x1812AC0B0")]
	public HMPMPJIHGEA(JOKHKLAANOK CEDMGFDCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7DBEAC0", Offset = "0x7DBD0C0", VA = "0x187DBEAC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B780", Offset = "0x1E59D80", VA = "0x181E5B780")]
	public static HMPMPJIHGEA OIFHDJNIHDL(JOKHKLAANOK CEDMGFDCANL)
	{
		return default(HMPMPJIHGEA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[TypeManager.ForcedStableTypeHash(12631852336897389638uL)]
public struct KJPLDGDICGL : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Entity IOGPJKLGKKO;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[TypeManager.ForcedStableTypeHash(8586426759787957142uL)]
public struct ABOMMICJPJD : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public JOKHKLAANOK OHLIHBDBKCE;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[TypeManager.ForcedStableTypeHash(3916218676170013300uL)]
public struct FPLLHJDGFPN : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Entity IOGPJKLGKKO;
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[TypeManager.ForcedStableTypeHash(3395423174463894753uL)]
public struct COABLKKKNPO : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Guid DGNNPFFMIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int JAALIADHHOC;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[TypeManager.ForcedStableTypeHash(13485578171010875955uL)]
public struct LBFOFGJNPLO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public int OHLIHBDBKCE;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[TypeManager.ForcedStableTypeHash(11182407275731589027uL)]
public struct GOOGLLALCAP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Entity IOGPJKLGKKO;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[TypeManager.ForcedStableTypeHash(238571310055566811uL)]
public struct JFNNOOLAEBF : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public JOKHKLAANOK OHLIHBDBKCE;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[TypeManager.ForcedStableTypeHash(17943708062286791581uL)]
public struct HGJNPGGFDBO : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Entity IOGPJKLGKKO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
[TypeManager.ForcedStableTypeHash(17717774548790709874uL)]
public struct LJHEJANNLDF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(1628423395607207516uL)]
public struct IIKDAEFMHMC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int ANNJKPFPAGK;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[TypeManager.ForcedStableTypeHash(6255673600552782006uL)]
public struct GCKBGHENLBJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int LFJPHGCMAAL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public AEMMHEJJEHA AGOECKHDGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA36AF0", Offset = "0xA350F0", VA = "0x180A36AF0")]
		get
		{
			return default(AEMMHEJJEHA);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[TypeManager.ForcedStableTypeHash(7921165883083593916uL)]
public struct BIGLEFOIHNN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public GCHandle FPDLNBIDOCB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
[TypeManager.ForcedStableTypeHash(14965811366685608319uL)]
public struct AMKNPIFMEFJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
[TypeManager.ForcedStableTypeHash(8376615066990205632uL)]
public struct HDKACLNIADC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
[TypeManager.ForcedStableTypeHash(7273320061473429398uL)]
public struct KCHKCIJNCON : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
[TypeManager.ForcedStableTypeHash(15140206241145976177uL)]
public struct HMPCINAMHHF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000039")]
[TypeManager.ForcedStableTypeHash(15969631250552901108uL)]
public struct ONPDFDAMHBM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[TypeManager.ForcedStableTypeHash(9353178840587053763uL)]
public struct MIBKFJGBEGF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public int OHHMJGCBCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public int DJNGLBELENN;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7DBF900", Offset = "0x7DBDF00", VA = "0x187DBF900")]
	public MIBKFJGBEGF(Entity IOGPJKLGKKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[TypeManager.ForcedStableTypeHash(16229383422209788655uL)]
public struct CMIFIBBALLN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public CollisionDetectionMode LIJAHILONNJ;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[TypeManager.ForcedStableTypeHash(5173865590150727846uL)]
[RegisterComponentDefault]
public struct GNIDLNHFKNK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public MEACMOOJHJN JONLENCCPHH;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly GNIDLNHFKNK OPJKGEJPJBC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003D")]
[TypeManager.ForcedStableTypeHash(7051356195299730219uL)]
public struct MFJEFHEJFII : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003E")]
[TypeManager.ForcedStableTypeHash(780557526766205634uL)]
public struct BEKOLOEIJJF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003F")]
[TypeManager.ForcedStableTypeHash(16413322458062516985uL)]
public struct IDBEHAOGDMG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[TypeManager.ForcedStableTypeHash(8350832327674051347uL)]
[InternalBufferCapacity(0)]
public struct COOMLOMLNME : IBufferElementData, IEquatable<COOMLOMLNME>, OJDFJPEFOBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Entity HMCFPGIFOED;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity PDEPLAGMOLE
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7DBDCE0", Offset = "0x7DBC2E0", VA = "0x187DBDCE0", Slot = "4")]
	public bool Equals(COOMLOMLNME MIJLJBIHDMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[TypeManager.ForcedStableTypeHash(3503423083784418805uL)]
public struct DBCLHGPACKL : IComponentData, OJDFJPEFOBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Entity JHDAOHEONAC;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Entity PDEPLAGMOLE
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000042")]
[TypeManager.ForcedStableTypeHash(14551834985136520975uL)]
public struct GJHFHCJECII : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[TypeManager.ForcedStableTypeHash(4388378139562737487uL)]
public struct PLGBHMIGBKH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Entity KNNDNAPJIDP;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct INNBJIGOFMP : PFKHMNBCONN, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public JENABNPBLBO AHDIELKOAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(JENABNPBLBO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[TypeManager.ForcedStableTypeHash(769086036388751339uL)]
public struct LECEALBDPCB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float3 IHADCAGHIBB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
[TypeManager.ForcedStableTypeHash(15638082890667179775uL)]
public struct BJNFNJELDAG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(7040629969868025973uL)]
public struct EJONBDLJBBO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public float3x3 KKFMLGCMMFA;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly EJONBDLJBBO OPJKGEJPJBC;
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(1290915447730818204uL)]
public struct APPEKFAJJFI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float3x3 KKFMLGCMMFA;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly APPEKFAJJFI OPJKGEJPJBC;
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[TypeManager.ForcedStableTypeHash(7667208078276643555uL)]
public struct NFIMPEEOOCB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float3 KNOAKPGCCEG;
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[TypeManager.ForcedStableTypeHash(11475279934298573286uL)]
public struct JCAECHLLLED : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public float3 GEHFEDIANJI;
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(18413785019621221410uL)]
public struct EPEBOKPCPID : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public float LGLAIENPBLC;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly EPEBOKPCPID OPJKGEJPJBC;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(16788150452972582455uL)]
public struct MFKPIFNEMBA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float APNMIMOLDBF;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly MFKPIFNEMBA OPJKGEJPJBC;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[TypeManager.ForcedStableTypeHash(971312552983123380uL)]
public struct AKJHJAODHBO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public float3 BPGNLFEJJHH;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[TypeManager.ForcedStableTypeHash(361641396811542242uL)]
public struct EHPAEHODNMF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public KDGIOFPALDJ KAHHOMCKKDN;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[TypeManager.ForcedStableTypeHash(7520974846918069913uL)]
[SingletonComponent]
public struct CCKAJPCOGMH : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Entity IOGPJKLGKKO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
[TypeManager.ForcedStableTypeHash(9260549625364734686uL)]
public struct KEAEOGFOFFK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
[TypeManager.ForcedStableTypeHash(469905343419662571uL)]
public struct KBBNLMGLPLE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[TypeManager.ForcedStableTypeHash(7865784707562564105uL)]
public struct FIBEJMOKMJE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public RigidbodyConstraints OPFLPGHGOHH;
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(7877027338327956319uL)]
public struct OLDCCDMEMDH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public float FKHPPHJNCJO;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly OLDCCDMEMDH OPJKGEJPJBC;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[TypeManager.ForcedStableTypeHash(935406425377786813uL)]
public struct HJMGMOIDOMI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float IFIDNLLDPOO;
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class AHDNFKOADDO : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GameObject CEKGANCAJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public object IBNAICKPLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public object CDBPMKBCPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public KGHDONEDALP EGLHICHHNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public Delegate DFLCNFCCMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Delegate IIHMPEDGHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public IEALDBHBOML<Delegate> GJCMNAIBLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public IEALDBHBOML<Delegate> ECGLIDHNKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public IEALDBHBOML<Delegate> DLBDGIENMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public IEALDBHBOML<Delegate> CEPJHCJMFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public IEALDBHBOML<Delegate> PGOJDFGCHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public IEALDBHBOML<Delegate> HBAPHKOMFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public IEALDBHBOML<Delegate> FDKPKDILEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public IEALDBHBOML<Delegate> FHFKNBALDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public IEALDBHBOML<Delegate> ACNAGENFHGH;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7DBD9A0", Offset = "0x7DBBFA0", VA = "0x187DBD9A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public AHDNFKOADDO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
[TypeManager.ForcedStableTypeHash(18165447863202358792uL)]
public struct DOOMLKMDLPP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[TypeManager.ForcedStableTypeHash(10810926406358250264uL)]
public struct MHNBIDOJOMN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public int FCMIPCKKHIK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1E5B780", Offset = "0x1E59D80", VA = "0x181E5B780")]
	public static MHNBIDOJOMN OIFHDJNIHDL(int OHLIHBDBKCE)
	{
		return default(MHNBIDOJOMN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class KKCBMIFKGLE : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Rigidbody FFHIAOPJEJF;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7DBF350", Offset = "0x7DBD950", VA = "0x187DBF350", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public KKCBMIFKGLE()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
[TypeManager.ForcedStableTypeHash(12765569839950265583uL)]
public struct FMDNKEFKCMO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[TypeManager.ForcedStableTypeHash(17236748096909814533uL)]
public struct CIKOKAGNDHE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 NAPJPBKPLFK;
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[TypeManager.ForcedStableTypeHash(1288392478539867023uL)]
public struct PEHBMJFCNKK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float3 NPNMEIDGLAE;
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(15102898512288820575uL)]
public struct MGNHBHBLJJK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float MNPGOIABGFO;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly MGNHBHBLJJK OPJKGEJPJBC;
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class AMKLKHALLHP : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public object AEEEFHOPKPJ;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7DBDAA0", Offset = "0x7DBC0A0", VA = "0x187DBDAA0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public AMKLKHALLHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class HDBEDMBMJJD : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public object NOBJIHFNOLC;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7DBE810", Offset = "0x7DBCE10", VA = "0x187DBE810", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public HDBEDMBMJJD()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
[TypeManager.ForcedStableTypeHash(3505189951659289292uL)]
public struct FLCBGFBJOOO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
[TypeManager.ForcedStableTypeHash(16217323095468023009uL)]
public struct GIMAJNEDINI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
[TypeManager.ForcedStableTypeHash(12880717127246424414uL)]
public struct PMPFCECMICC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[TypeManager.ForcedStableTypeHash(12942629461400744171uL)]
public struct FAJMFPBFMHM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
[TypeManager.ForcedStableTypeHash(10226241216405964379uL)]
public struct FOBPBLBIPOB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
[TypeManager.ForcedStableTypeHash(12400259538654257671uL)]
public struct LICMLPFEMME : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
[TypeManager.ForcedStableTypeHash(12731949941800560397uL)]
public struct HHHLFCAHGFN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
[TypeManager.ForcedStableTypeHash(16270799832065682331uL)]
public struct AMCBJPHPINC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
[TypeManager.ForcedStableTypeHash(9395080039644288849uL)]
public struct KKAPEJNLJBL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[TypeManager.ForcedStableTypeHash(282623311697096978uL)]
public struct EEEGICPHBIG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public KNIHOKEGCFA EJHJGBMJABF;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7DBE050", Offset = "0x7DBC650", VA = "0x187DBE050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
[TypeManager.ForcedStableTypeHash(10395819776101408141uL)]
public struct ELDPIJAKKBO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
[TypeManager.ForcedStableTypeHash(375953524326549120uL)]
public struct JMIJHIKEPIG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
[TypeManager.ForcedStableTypeHash(14259779488802476986uL)]
public struct OECAKHPBOCE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[TypeManager.ForcedStableTypeHash(15330221065042235480uL)]
public struct AMKKCFMHLHP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public FixedString32Bytes NFHOBPDKIPM;
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(5162925656869367991uL)]
public struct IKOINHFFJDL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public UnsafeParallelHashMap<KNIHOKEGCFA, Entity> ILAKJFCHGOE;
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[TypeManager.ForcedStableTypeHash(9841032716800521808uL)]
public struct FBCAMHDNEBC : ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Entity EHFEIAIDBAH;
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[TypeManager.ForcedStableTypeHash(154813247653871879uL)]
internal struct IEGBCELEFNP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Entity IOGPJKLGKKO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xC7C260", Offset = "0xC7A860", VA = "0x180C7C260")]
	public static IEGBCELEFNP OIFHDJNIHDL(Entity IOGPJKLGKKO)
	{
		return default(IEGBCELEFNP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[TypeManager.ForcedStableTypeHash(11656653634719673845uL)]
public struct MDHCECEFLHI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Entity CNGALJJAOOA;
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[TypeManager.ForcedStableTypeHash(1837719173092935466uL)]
public struct FNAFKFIAOHJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity CNGALJJAOOA;
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[TypeManager.ForcedStableTypeHash(17382237360022739174uL)]
internal struct NHBCAOMFGBP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Entity FGGDIGEMBLA;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xC7C260", Offset = "0xC7A860", VA = "0x180C7C260")]
	public static NHBCAOMFGBP OIFHDJNIHDL(Entity IOGPJKLGKKO)
	{
		return default(NHBCAOMFGBP);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
[TypeManager.ForcedStableTypeHash(15858722173278118533uL)]
internal struct JAALOJDJIBL : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[TypeManager.ForcedStableTypeHash(10313790595830381076uL)]
public struct MGCACBCDLEK : IBufferElementData, IEquatable<MGCACBCDLEK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Entity DCCBDFNGPDJ;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7BDE780", Offset = "0x7BDCD80", VA = "0x187BDE780", Slot = "4")]
	public bool Equals(MGCACBCDLEK MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7DBF830", Offset = "0x7DBDE30", VA = "0x187DBF830", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xA36AF0", Offset = "0xA350F0", VA = "0x180A36AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[TypeManager.ForcedStableTypeHash(10169361040328370708uL)]
public struct ODKEOKJFEJJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public uint DJNGLBELENN;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(11536226225076729790uL)]
internal struct FHJGCJNAAHI : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Entity HMFCGNLLBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public int OHHMJGCBCKD;
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[TypeManager.ForcedStableTypeHash(8309037880064337491uL)]
internal struct EEAGMJPINCO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public Entity FKFPDEAIGAP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
[TypeManager.ForcedStableTypeHash(5891816987223099091uL)]
public struct FMHPKBOPMDH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[TypeManager.ForcedStableTypeHash(17289298604600812224uL)]
public struct JKCPEGONFLE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public uint BGLNIPGDAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int OOLINOEGCNI;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xD2E720", Offset = "0xD2CD20", VA = "0x180D2E720")]
	public JKCPEGONFLE(uint JGKBJMGOPEC, int FPNGAODKLNE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
[TypeManager.ForcedStableTypeHash(12258100538258701401uL)]
public struct KINIDIBJNBJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
[TypeManager.ForcedStableTypeHash(3081870877980445988uL)]
public struct GABLABELGGJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
[TypeManager.ForcedStableTypeHash(15554741495161407507uL)]
public struct LCOHNINEGPK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
[TypeManager.ForcedStableTypeHash(17684057078056878475uL)]
public struct IDAAEHHFNIE : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
[TypeManager.ForcedStableTypeHash(10023455309444528896uL)]
public struct NHEPJCEIBIG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
[TypeManager.ForcedStableTypeHash(14403752119546393228uL)]
public struct BEMIMBPINKH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
[TypeManager.ForcedStableTypeHash(9219181242087356214uL)]
public struct FLBCFBICGGE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
[TypeManager.ForcedStableTypeHash(12371658133244024718uL)]
public struct ALAHHKLGPFH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
[TypeManager.ForcedStableTypeHash(9351414359236295489uL)]
public struct EBKMLJCFJLH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
[TypeManager.ForcedStableTypeHash(12796707860320869007uL)]
internal struct NJELJDONJLC : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
[TypeManager.ForcedStableTypeHash(13367368557807690484uL)]
public struct ALNFHEDHOFA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000085")]
[TypeManager.ForcedStableTypeHash(7193071459223094579uL)]
public struct CDDHAAOFBEP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
[TypeManager.ForcedStableTypeHash(15247343901949961769uL)]
public struct KNLPFEBKPGF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
[TypeManager.ForcedStableTypeHash(5381043565870728787uL)]
public struct EEKCJAPECLN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
[TypeManager.ForcedStableTypeHash(11597028615900234104uL)]
internal struct CMMFDECFMAD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
[TypeManager.ForcedStableTypeHash(1907494159895213433uL)]
internal struct PKEFACKKLMM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
[TypeManager.ForcedStableTypeHash(3955886960983597628uL)]
public struct MCCLGICMBEG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
[TypeManager.ForcedStableTypeHash(480620745253244652uL)]
public struct ALKGMEMGFIE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008C")]
[TypeManager.ForcedStableTypeHash(8253675824478287824uL)]
public struct IGJLNAHCIHP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
[TypeManager.ForcedStableTypeHash(8855488771047251567uL)]
public struct BMHHOCKLEJL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008E")]
[TypeManager.ForcedStableTypeHash(8375777954271012995uL)]
public struct MKFJPCKHKKO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
[TypeManager.ForcedStableTypeHash(16444804027614993581uL)]
public struct CLKNNIPLJFI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
[TypeManager.ForcedStableTypeHash(16177323740107409537uL)]
public struct HIFPBGIMGDJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
[TypeManager.ForcedStableTypeHash(11049752089067741804uL)]
public struct AIBIAOHCBLO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000092")]
[TypeManager.ForcedStableTypeHash(1453937769327886583uL)]
public struct PMEEEJIBPAA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000093")]
[TypeManager.ForcedStableTypeHash(800754555681830909uL)]
public struct MKOAOICLKLB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000094")]
[TypeManager.ForcedStableTypeHash(3336901602667819150uL)]
public struct ACAHJEGLDNE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000095")]
[TypeManager.ForcedStableTypeHash(11809750536411032401uL)]
public struct JHGCFNHLEDA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000096")]
[TypeManager.ForcedStableTypeHash(6387004770090400669uL)]
public struct FJGJGLHNDIE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
[TypeManager.ForcedStableTypeHash(2223159712203397538uL)]
internal struct MAGCLCDOMMD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000098")]
[TypeManager.ForcedStableTypeHash(10153397523300334327uL)]
public struct MDEJDOBJLIH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000099")]
[TypeManager.ForcedStableTypeHash(12983102201306073842uL)]
public struct FIGAPCIANEE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
[FHHHLIJDCNN]
[TypeManager.ForcedStableTypeHash(15398959433761599914uL)]
public struct CEIOHAMIFGN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[TypeManager.ForcedStableTypeHash(6605318152550716456uL)]
[SingletonComponent]
public struct MJDGOHFGIKK : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public FixedString32Bytes ALDJJJCLNOI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
[TypeManager.ForcedStableTypeHash(10065634662848845784uL)]
public struct ENCAHEMLJEB : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009D")]
[TypeManager.ForcedStableTypeHash(15062299176839263439uL)]
public struct IHKBDBBGMNF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009E")]
[TypeManager.ForcedStableTypeHash(3596269116834888123uL)]
internal struct ODDNLPHMNEI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
[TypeManager.ForcedStableTypeHash(4402941654898007496uL)]
internal struct HODKCAHOFEG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[TypeManager.ForcedStableTypeHash(12682474121528142025uL)]
internal struct EOKDAFGEFEH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[TypeManager.ForcedStableTypeHash(1840266485562743455uL)]
public struct CBJEILHPOED : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[TypeManager.ForcedStableTypeHash(4772574226205567794uL)]
public struct LACEILALMKE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[TypeManager.ForcedStableTypeHash(17642911464827038147uL)]
public struct EBJFDHJOPGB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public quaternion OOBEGCNALKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float3 EPCLGOKLIPO;
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[TypeManager.ForcedStableTypeHash(9066921186040058989uL)]
public struct HKMGJGAMEDN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float NMHCFEIEHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float FAEKEKLBLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float PPIMMHGHNFA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[TypeManager.ForcedStableTypeHash(3328998613642473514uL)]
public struct EIKNLLHMOPK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[TypeManager.ForcedStableTypeHash(151116349382904900uL)]
public struct NOIKBMFFEGL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[TypeManager.ForcedStableTypeHash(8067675582152570601uL)]
public struct GDNAHILOLOP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[TypeManager.ForcedStableTypeHash(4522686316477281096uL)]
public struct CBNALBBPKNA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public int LFJPHGCMAAL;
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6216404920432680992uL)]
public struct PHMAKEJIDOB : ISystemStateBufferElementData, IBufferElementData, OJDFJPEFOBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Entity OHDGCHLKIKP;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity MFOJDPOEONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(419884688393735449uL)]
public struct PKMHLKDEGFH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public float4x4 KAHAHHMBPFK;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly PKMHLKDEGFH OPJKGEJPJBC;
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(1954795745923300919uL)]
public struct GOPIELNPNDN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public float4x4 HFLBLHLDCPA;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly GOPIELNPNDN OPJKGEJPJBC;
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[TypeManager.ForcedStableTypeHash(2447627752265109178uL)]
public struct HAHHJPLMFHC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private int APCPPMBKJCA;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int OHHMJGCBCKD
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE710", Offset = "0x7DBCD10", VA = "0x187DBE710")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE720", Offset = "0x7DBCD20", VA = "0x187DBE720")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(13706996280046618062uL)]
public struct POJBICJOCGH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public float3 EPCLGOKLIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public quaternion OOBEGCNALKF;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly POJBICJOCGH OPJKGEJPJBC;
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public static class DGAMODIMHKL
{
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(77694943841979493uL)]
public struct MDIJHFMIFAB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public float AMHMINBKJJD;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly MDIJHFMIFAB OPJKGEJPJBC;
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[TypeManager.ForcedStableTypeHash(6537711325103434903uL)]
public struct EPKIIKAHGNP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Entity FEHDPLGKCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public AEGDAJEGAFP KOJNMKELJGK;
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[TypeManager.ForcedStableTypeHash(5471640964865828061uL)]
public struct JGHCBAEBBEC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public AEGDAJEGAFP KOJNMKELJGK;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[TypeManager.ForcedStableTypeHash(16527934868211432802uL)]
public struct LJIGAADNOPB : ISystemStateComponentData, IComponentData, OJDFJPEFOBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Entity AMICCGMJHBK;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Entity MFOJDPOEONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[TypeManager.ForcedStableTypeHash(15310407062508355916uL)]
public struct ILBOHHLDFDI : ISystemStateBufferElementData, IBufferElementData, OJDFJPEFOBA, IEquatable<ILBOHHLDFDI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Entity LLNBPONOCJH;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Entity MFOJDPOEONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7BDE780", Offset = "0x7BDCD80", VA = "0x187BDE780", Slot = "6")]
	public bool Equals(ILBOHHLDFDI MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7DBF050", Offset = "0x7DBD650", VA = "0x187DBF050", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xA36AF0", Offset = "0xA350F0", VA = "0x180A36AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[TypeManager.ForcedStableTypeHash(11786768220100978132uL)]
public struct EMGAEIMOOLC : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Entity FEHDPLGKCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public AEGDAJEGAFP KOJNMKELJGK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public struct AJNFGKCIHJI : IEqualityComparer<EMGAEIMOOLC>
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static AJNFGKCIHJI OPJKGEJPJBC;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7DBD9F0", Offset = "0x7DBBFF0", VA = "0x187DBD9F0", Slot = "4")]
	public bool Equals(EMGAEIMOOLC CEJAAIDLEPA, EMGAEIMOOLC IMNDAJIDDFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7DBDA40", Offset = "0x7DBC040", VA = "0x187DBDA40", Slot = "5")]
	public int GetHashCode(EMGAEIMOOLC BOMDCGFKGKF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[TypeManager.ForcedStableTypeHash(8981997360983277121uL)]
public struct PPMGKIHOFLD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public FixedList32Bytes<int> MKHFKNEFINC;
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[TypeManager.ForcedStableTypeHash(2801212869002544047uL)]
public struct DMIKOOHKGNA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public FixedList32Bytes<int> MKHFKNEFINC;
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[TypeManager.ForcedStableTypeHash(16455485691096333919uL)]
public struct CFODBPACJFK : ISystemStateBufferElementData, IBufferElementData, OJDFJPEFOBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public Entity BBNAOHAKLAG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Entity PDEPLAGMOLE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2D500", VA = "0x180D2EF00", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xEE2DE0", Offset = "0xEE13E0", VA = "0x180EE2DE0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal class FFDGGOJBCGD : ContainerPropertyBag<GGDALAGJMMI>
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private class IJJKMLALGIA : Property<GGDALAGJMMI, BENOGLOIGDB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string IJKBIMCGCEM
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7DBF020", Offset = "0x7DBD620", VA = "0x187DBF020", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool DJCGEFIJFFP
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7DBEFE0", Offset = "0x7DBD5E0", VA = "0x187DBEFE0")]
		public IJJKMLALGIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7DBEAF0", Offset = "0x7DBD0F0", VA = "0x187DBEAF0", Slot = "14")]
		public override BENOGLOIGDB GetValue(GGDALAGJMMI NELIKBMJKPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7DBEB10", Offset = "0x7DBD110", VA = "0x187DBEB10", Slot = "15")]
		public override void SetValue(GGDALAGJMMI NELIKBMJKPH, BENOGLOIGDB OHLIHBDBKCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7DBE2F0", Offset = "0x7DBC8F0", VA = "0x187DBE2F0")]
	public FFDGGOJBCGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal class MOJELEKIGEO : ContainerPropertyBag<AHDNFKOADDO>
{
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	private class LPJPIIEGDGO : Property<AHDNFKOADDO, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string IJKBIMCGCEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x7DBF780", Offset = "0x7DBDD80", VA = "0x187DBF780", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool DJCGEFIJFFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF740", Offset = "0x7DBDD40", VA = "0x187DBF740")]
		public LPJPIIEGDGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7DBEAF0", Offset = "0x7DBD0F0", VA = "0x187DBEAF0", Slot = "14")]
		public override GameObject GetValue(AHDNFKOADDO NELIKBMJKPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7DBEB10", Offset = "0x7DBD110", VA = "0x187DBEB10", Slot = "15")]
		public override void SetValue(AHDNFKOADDO NELIKBMJKPH, GameObject OHLIHBDBKCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	private class LMKDPMICEIC : Property<AHDNFKOADDO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string IJKBIMCGCEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7DBF710", Offset = "0x7DBDD10", VA = "0x187DBF710", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool DJCGEFIJFFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF6D0", Offset = "0x7DBDCD0", VA = "0x187DBF6D0")]
		public LMKDPMICEIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF680", Offset = "0x7DBDC80", VA = "0x187DBF680", Slot = "14")]
		public override object GetValue(AHDNFKOADDO NELIKBMJKPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF6A0", Offset = "0x7DBDCA0", VA = "0x187DBF6A0", Slot = "15")]
		public override void SetValue(AHDNFKOADDO NELIKBMJKPH, object OHLIHBDBKCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	private class ONOIHAIJBFF : Property<AHDNFKOADDO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string IJKBIMCGCEM
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7DC0210", Offset = "0x7DBE810", VA = "0x187DC0210", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool DJCGEFIJFFP
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7DC01D0", Offset = "0x7DBE7D0", VA = "0x187DC01D0")]
		public ONOIHAIJBFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7DC0180", Offset = "0x7DBE780", VA = "0x187DC0180", Slot = "14")]
		public override object GetValue(AHDNFKOADDO NELIKBMJKPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7DC01A0", Offset = "0x7DBE7A0", VA = "0x187DC01A0", Slot = "15")]
		public override void SetValue(AHDNFKOADDO NELIKBMJKPH, object OHLIHBDBKCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private class PEBHPCFPOBP : Property<AHDNFKOADDO, KGHDONEDALP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string IJKBIMCGCEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x7DC02D0", Offset = "0x7DBE8D0", VA = "0x187DC02D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool DJCGEFIJFFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7DC0290", Offset = "0x7DBE890", VA = "0x187DC0290")]
		public PEBHPCFPOBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7DC0240", Offset = "0x7DBE840", VA = "0x187DC0240", Slot = "14")]
		public override KGHDONEDALP GetValue(AHDNFKOADDO NELIKBMJKPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7DC0260", Offset = "0x7DBE860", VA = "0x187DC0260", Slot = "15")]
		public override void SetValue(AHDNFKOADDO NELIKBMJKPH, KGHDONEDALP OHLIHBDBKCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private class EDOHABNBCCH : Property<AHDNFKOADDO, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string IJKBIMCGCEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7DBE020", Offset = "0x7DBC620", VA = "0x187DBE020", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool DJCGEFIJFFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7DBDFE0", Offset = "0x7DBC5E0", VA = "0x187DBDFE0")]
		public EDOHABNBCCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7DBDF90", Offset = "0x7DBC590", VA = "0x187DBDF90", Slot = "14")]
		public override Delegate GetValue(AHDNFKOADDO NELIKBMJKPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7DBDFB0", Offset = "0x7DBC5B0", VA = "0x187DBDFB0", Slot = "15")]
		public override void SetValue(AHDNFKOADDO NELIKBMJKPH, Delegate OHLIHBDBKCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private class NGEIJEEDALI : Property<AHDNFKOADDO, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string IJKBIMCGCEM
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7DC00E0", Offset = "0x7DBE6E0", VA = "0x187DC00E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool DJCGEFIJFFP
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7DC00A0", Offset = "0x7DBE6A0", VA = "0x187DC00A0")]
		public NGEIJEEDALI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7DC0050", Offset = "0x7DBE650", VA = "0x187DC0050", Slot = "14")]
		public override Delegate GetValue(AHDNFKOADDO NELIKBMJKPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7DC0070", Offset = "0x7DBE670", VA = "0x187DC0070", Slot = "15")]
		public override void SetValue(AHDNFKOADDO NELIKBMJKPH, Delegate OHLIHBDBKCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private class DHDPFDPKMFA : Property<AHDNFKOADDO, IEALDBHBOML<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string IJKBIMCGCEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7DBDEA0", Offset = "0x7DBC4A0", VA = "0x187DBDEA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool DJCGEFIJFFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7DBDE60", Offset = "0x7DBC460", VA = "0x187DBDE60")]
		public DHDPFDPKMFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7DBDE10", Offset = "0x7DBC410", VA = "0x187DBDE10", Slot = "14")]
		public override IEALDBHBOML<Delegate> GetValue(AHDNFKOADDO NELIKBMJKPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7DBDE30", Offset = "0x7DBC430", VA = "0x187DBDE30", Slot = "15")]
		public override void SetValue(AHDNFKOADDO NELIKBMJKPH, IEALDBHBOML<Delegate> OHLIHBDBKCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private class DODOEGEBEDP : Property<AHDNFKOADDO, IEALDBHBOML<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string IJKBIMCGCEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x7DBDF60", Offset = "0x7DBC560", VA = "0x187DBDF60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool DJCGEFIJFFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7DBDF20", Offset = "0x7DBC520", VA = "0x187DBDF20")]
		public DODOEGEBEDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7DBDED0", Offset = "0x7DBC4D0", VA = "0x187DBDED0", Slot = "14")]
		public override IEALDBHBOML<Delegate> GetValue(AHDNFKOADDO NELIKBMJKPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7DBDEF0", Offset = "0x7DBC4F0", VA = "0x187DBDEF0", Slot = "15")]
		public override void SetValue(AHDNFKOADDO NELIKBMJKPH, IEALDBHBOML<Delegate> OHLIHBDBKCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private class LAIJFDOFEHM : Property<AHDNFKOADDO, IEALDBHBOML<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string IJKBIMCGCEM
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7DBF450", Offset = "0x7DBDA50", VA = "0x187DBF450", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool DJCGEFIJFFP
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF410", Offset = "0x7DBDA10", VA = "0x187DBF410")]
		public LAIJFDOFEHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF3C0", Offset = "0x7DBD9C0", VA = "0x187DBF3C0", Slot = "14")]
		public override IEALDBHBOML<Delegate> GetValue(AHDNFKOADDO NELIKBMJKPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF3E0", Offset = "0x7DBD9E0", VA = "0x187DBF3E0", Slot = "15")]
		public override void SetValue(AHDNFKOADDO NELIKBMJKPH, IEALDBHBOML<Delegate> OHLIHBDBKCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private class LEIDBIJBPMN : Property<AHDNFKOADDO, IEALDBHBOML<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string IJKBIMCGCEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7DBF650", Offset = "0x7DBDC50", VA = "0x187DBF650", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool DJCGEFIJFFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF610", Offset = "0x7DBDC10", VA = "0x187DBF610")]
		public LEIDBIJBPMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF5C0", Offset = "0x7DBDBC0", VA = "0x187DBF5C0", Slot = "14")]
		public override IEALDBHBOML<Delegate> GetValue(AHDNFKOADDO NELIKBMJKPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF5E0", Offset = "0x7DBDBE0", VA = "0x187DBF5E0", Slot = "15")]
		public override void SetValue(AHDNFKOADDO NELIKBMJKPH, IEALDBHBOML<Delegate> OHLIHBDBKCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	private class IMFNFCPPINJ : Property<AHDNFKOADDO, IEALDBHBOML<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string IJKBIMCGCEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x7DBF170", Offset = "0x7DBD770", VA = "0x187DBF170", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool DJCGEFIJFFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF130", Offset = "0x7DBD730", VA = "0x187DBF130")]
		public IMFNFCPPINJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF0E0", Offset = "0x7DBD6E0", VA = "0x187DBF0E0", Slot = "14")]
		public override IEALDBHBOML<Delegate> GetValue(AHDNFKOADDO NELIKBMJKPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF100", Offset = "0x7DBD700", VA = "0x187DBF100", Slot = "15")]
		public override void SetValue(AHDNFKOADDO NELIKBMJKPH, IEALDBHBOML<Delegate> OHLIHBDBKCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	private class IBODPGGJAIH : Property<AHDNFKOADDO, IEALDBHBOML<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string IJKBIMCGCEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x7DBEC40", Offset = "0x7DBD240", VA = "0x187DBEC40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool DJCGEFIJFFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7DBEC00", Offset = "0x7DBD200", VA = "0x187DBEC00")]
		public IBODPGGJAIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7DBEBB0", Offset = "0x7DBD1B0", VA = "0x187DBEBB0", Slot = "14")]
		public override IEALDBHBOML<Delegate> GetValue(AHDNFKOADDO NELIKBMJKPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7DBEBD0", Offset = "0x7DBD1D0", VA = "0x187DBEBD0", Slot = "15")]
		public override void SetValue(AHDNFKOADDO NELIKBMJKPH, IEALDBHBOML<Delegate> OHLIHBDBKCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	private class JAEHGJIOBKJ : Property<AHDNFKOADDO, IEALDBHBOML<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string IJKBIMCGCEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7DBF2B0", Offset = "0x7DBD8B0", VA = "0x187DBF2B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool DJCGEFIJFFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF270", Offset = "0x7DBD870", VA = "0x187DBF270")]
		public JAEHGJIOBKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF220", Offset = "0x7DBD820", VA = "0x187DBF220", Slot = "14")]
		public override IEALDBHBOML<Delegate> GetValue(AHDNFKOADDO NELIKBMJKPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF240", Offset = "0x7DBD840", VA = "0x187DBF240", Slot = "15")]
		public override void SetValue(AHDNFKOADDO NELIKBMJKPH, IEALDBHBOML<Delegate> OHLIHBDBKCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	private class BDILLLJGKJD : Property<AHDNFKOADDO, IEALDBHBOML<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string IJKBIMCGCEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7DBDD80", Offset = "0x7DBC380", VA = "0x187DBDD80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool DJCGEFIJFFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7DBDD40", Offset = "0x7DBC340", VA = "0x187DBDD40")]
		public BDILLLJGKJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7DBDCF0", Offset = "0x7DBC2F0", VA = "0x187DBDCF0", Slot = "14")]
		public override IEALDBHBOML<Delegate> GetValue(AHDNFKOADDO NELIKBMJKPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7DBDD10", Offset = "0x7DBC310", VA = "0x187DBDD10", Slot = "15")]
		public override void SetValue(AHDNFKOADDO NELIKBMJKPH, IEALDBHBOML<Delegate> OHLIHBDBKCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	private class ELGAGCJLMGD : Property<AHDNFKOADDO, IEALDBHBOML<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string IJKBIMCGCEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7DBE220", Offset = "0x7DBC820", VA = "0x187DBE220", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool DJCGEFIJFFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE1E0", Offset = "0x7DBC7E0", VA = "0x187DBE1E0")]
		public ELGAGCJLMGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE190", Offset = "0x7DBC790", VA = "0x187DBE190", Slot = "14")]
		public override IEALDBHBOML<Delegate> GetValue(AHDNFKOADDO NELIKBMJKPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE1B0", Offset = "0x7DBC7B0", VA = "0x187DBE1B0", Slot = "15")]
		public override void SetValue(AHDNFKOADDO NELIKBMJKPH, IEALDBHBOML<Delegate> OHLIHBDBKCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7DBF910", Offset = "0x7DBDF10", VA = "0x187DBF910")]
	public MOJELEKIGEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal class BMGJLPOOBIO : ContainerPropertyBag<IEALDBHBOML<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7DBDDB0", Offset = "0x7DBC3B0", VA = "0x187DBDDB0")]
	public BMGJLPOOBIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal class PELNEHDNAKE : ContainerPropertyBag<KKCBMIFKGLE>
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	private class HODMGPLJKNA : Property<KKCBMIFKGLE, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string IJKBIMCGCEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7DBEB80", Offset = "0x7DBD180", VA = "0x187DBEB80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool DJCGEFIJFFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7DBEB40", Offset = "0x7DBD140", VA = "0x187DBEB40")]
		public HODMGPLJKNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7DBEAF0", Offset = "0x7DBD0F0", VA = "0x187DBEAF0", Slot = "14")]
		public override Rigidbody GetValue(KKCBMIFKGLE NELIKBMJKPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7DBEB10", Offset = "0x7DBD110", VA = "0x187DBEB10", Slot = "15")]
		public override void SetValue(KKCBMIFKGLE NELIKBMJKPH, Rigidbody OHLIHBDBKCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7DC0300", Offset = "0x7DBE900", VA = "0x187DC0300")]
	public PELNEHDNAKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal class HCKANPAGHNI : ContainerPropertyBag<AMKLKHALLHP>
{
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	private class NFAOAKGCECO : Property<AMKLKHALLHP, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string IJKBIMCGCEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x7DC0020", Offset = "0x7DBE620", VA = "0x187DC0020", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool DJCGEFIJFFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7DBFFE0", Offset = "0x7DBE5E0", VA = "0x187DBFFE0")]
		public NFAOAKGCECO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7DBEAF0", Offset = "0x7DBD0F0", VA = "0x187DBEAF0", Slot = "14")]
		public override object GetValue(AMKLKHALLHP NELIKBMJKPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7DBEB10", Offset = "0x7DBD110", VA = "0x187DBEB10", Slot = "15")]
		public override void SetValue(AMKLKHALLHP NELIKBMJKPH, object OHLIHBDBKCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7DBE730", Offset = "0x7DBCD30", VA = "0x187DBE730")]
	public HCKANPAGHNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal class GEPLFOHCLKC : ContainerPropertyBag<HDBEDMBMJJD>
{
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	private class KCIIBJGIPIO : Property<HDBEDMBMJJD, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string IJKBIMCGCEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x7DBF320", Offset = "0x7DBD920", VA = "0x187DBF320", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool DJCGEFIJFFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF2E0", Offset = "0x7DBD8E0", VA = "0x187DBF2E0")]
		public KCIIBJGIPIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7DBEAF0", Offset = "0x7DBD0F0", VA = "0x187DBEAF0", Slot = "14")]
		public override object GetValue(HDBEDMBMJJD NELIKBMJKPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7DBEB10", Offset = "0x7DBD110", VA = "0x187DBEB10", Slot = "15")]
		public override void SetValue(HDBEDMBMJJD NELIKBMJKPH, object OHLIHBDBKCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7DBE450", Offset = "0x7DBCA50", VA = "0x187DBE450")]
	public GEPLFOHCLKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal class APGMNHEPMGM : ContainerPropertyBag<FBCAMHDNEBC>
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	private class FOHEFNBNOJE : Property<FBCAMHDNEBC, Entity>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string IJKBIMCGCEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7DBE420", Offset = "0x7DBCA20", VA = "0x187DBE420", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool DJCGEFIJFFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE3E0", Offset = "0x7DBC9E0", VA = "0x187DBE3E0")]
		public FOHEFNBNOJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA6BD50", Offset = "0xA6A350", VA = "0x180A6BD50", Slot = "14")]
		public override Entity GetValue(FBCAMHDNEBC NELIKBMJKPH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE3D0", Offset = "0x7DBC9D0", VA = "0x187DBE3D0", Slot = "15")]
		public override void SetValue(FBCAMHDNEBC NELIKBMJKPH, Entity OHLIHBDBKCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7DBDB10", Offset = "0x7DBC110", VA = "0x187DBDB10")]
	public APGMNHEPMGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class LDGACGJCLKB : ContainerPropertyBag<Entity>
{
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	private class NELLDAJPNMO : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string IJKBIMCGCEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x7DBFFB0", Offset = "0x7DBE5B0", VA = "0x187DBFFB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool DJCGEFIJFFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7DBFF70", Offset = "0x7DBE570", VA = "0x187DBFF70")]
		public NELLDAJPNMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2171A90", Offset = "0x2170090", VA = "0x182171A90", Slot = "14")]
		public override int GetValue(Entity NELIKBMJKPH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7BD9F20", Offset = "0x7BD8520", VA = "0x187BD9F20", Slot = "15")]
		public override void SetValue(Entity NELIKBMJKPH, int OHLIHBDBKCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	private class GPIGLNKFFPI : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string IJKBIMCGCEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x7DBE6E0", Offset = "0x7DBCCE0", VA = "0x187DBE6E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool DJCGEFIJFFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE6A0", Offset = "0x7DBCCA0", VA = "0x187DBE6A0")]
		public GPIGLNKFFPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xEF2570", Offset = "0xEF0B70", VA = "0x180EF2570", Slot = "14")]
		public override int GetValue(Entity NELIKBMJKPH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE690", Offset = "0x7DBCC90", VA = "0x187DBE690", Slot = "15")]
		public override void SetValue(Entity NELIKBMJKPH, int OHLIHBDBKCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7DBF480", Offset = "0x7DBDA80", VA = "0x187DBF480")]
	public LDGACGJCLKB()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7DC0610", Offset = "0x7DBEC10", VA = "0x187DC0610")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public class PPHBBBBMJHN
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public PPHBBBBMJHN()
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
