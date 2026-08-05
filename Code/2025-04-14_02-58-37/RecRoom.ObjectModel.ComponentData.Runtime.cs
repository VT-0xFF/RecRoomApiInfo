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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A6EB60", Offset = "0x7A6D560", VA = "0x187A6EB60", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7A6EEF0", Offset = "0x7A6D8F0", VA = "0x187A6EEF0", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2571680", Offset = "0x2570080", VA = "0x182571680")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
[TypeManager.ForcedStableTypeHash(1586941204353847852uL)]
public struct NABCGDCFEHD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
[TypeManager.ForcedStableTypeHash(1730701010008160003uL)]
public struct DDNHKEHDFIP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
[TypeManager.ForcedStableTypeHash(3399609037308777919uL)]
public struct FHDMNDPNOPA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
[TypeManager.ForcedStableTypeHash(18083619841998483100uL)]
public struct BIEDKNIJLHK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
[TypeManager.ForcedStableTypeHash(12361415346715948123uL)]
public struct CIPNCBIOLGJ : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[TypeManager.ForcedStableTypeHash(15820941866177188261uL)]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : IBufferElementData, IEquatable<AuthoredChildBuffer>, BOAGFLLOLPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7A6BA40", Offset = "0x7A6A440", VA = "0x187A6BA40", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC12D40", Offset = "0xC11740", VA = "0x180C12D40")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
[TypeManager.ForcedStableTypeHash(7794731847884836165uL)]
public struct OMHCPEMOJBD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[TypeManager.ForcedStableTypeHash(1525018888797798356uL)]
public struct ABIIANDANGH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Entity DMJPKEHPPGF;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[TypeManager.ForcedStableTypeHash(6294257411443737851uL)]
public struct AMKMEMEGJIC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity DMJPKEHPPGF;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct KALIBJCDCDI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<MAJFCNMMOEM> AIEPBNOJPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<Entity> LHAPCEOBLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private JobHandle GDFPJOCLDKE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool MNPGKBIJONA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7A6CEF0", Offset = "0x7A6B8F0", VA = "0x187A6CEF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int NIAGHPMMKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7A6CD20", Offset = "0x7A6B720", VA = "0x187A6CD20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x597D400", Offset = "0x597BE00", VA = "0x18597D400")]
	public KALIBJCDCDI(NativeList<MAJFCNMMOEM> AIEPBNOJPNN, NativeList<Entity> LHAPCEOBLCI, JobHandle GDFPJOCLDKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7A6CDD0", Offset = "0x7A6B7D0", VA = "0x187A6CDD0")]
	public (Entity, NativeSlice<Entity>) HNDMIFNFAOD(int LGMJDKKAMNE)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7A6CD70", Offset = "0x7A6B770", VA = "0x187A6CD70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct MAJFCNMMOEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Entity MHHKOMDGDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int LMGBAALNFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int ENHEICOLGJO;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OFNGKMJKMMD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FMBDDLANMBJ(bool HEGFJIBHIHE);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct NGMENJNPHOG : IEquatable<NGMENJNPHOG>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate bool AGGEMGAPEPJ(int DJPDBDCCOEF);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly bool BPHODBGPDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool JABBAMODELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool JFGPPNMGCBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool BOOMOLNECPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly AGGEMGAPEPJ LDAEJKMFGLJ;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7A6E020", Offset = "0x7A6CA20", VA = "0x187A6E020")]
	public NGMENJNPHOG(ECGPIELDBBK BNNEEGIINDP, AGGEMGAPEPJ LDAEJKMFGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7A6E070", Offset = "0x7A6CA70", VA = "0x187A6E070")]
	public NGMENJNPHOG(bool BPHODBGPDNM, bool JABBAMODELM, bool JFGPPNMGCBH, bool BOOMOLNECPC, AGGEMGAPEPJ LDAEJKMFGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7A6DF60", Offset = "0x7A6C960", VA = "0x187A6DF60")]
	public bool NNNJGHHPCHL(int DJPDBDCCOEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7A6DE40", Offset = "0x7A6C840", VA = "0x187A6DE40")]
	public bool FGGGIOKPCLN(int DJPDBDCCOEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7A6DD30", Offset = "0x7A6C730", VA = "0x187A6DD30")]
	public bool BBFDJCNGCNO(int DJPDBDCCOEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7A6DF10", Offset = "0x7A6C910", VA = "0x187A6DF10")]
	public bool JAPHKHIJGKC(int DJPDBDCCOEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7A6DE10", Offset = "0x7A6C810", VA = "0x187A6DE10", Slot = "4")]
	public bool Equals(NGMENJNPHOG OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7A6DD60", Offset = "0x7A6C760", VA = "0x187A6DD60", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7A6DE70", Offset = "0x7A6C870", VA = "0x187A6DE70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7A6DF40", Offset = "0x7A6C940", VA = "0x187A6DF40")]
	private bool MEFCHANLMHP(int DJPDBDCCOEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7A6DF90", Offset = "0x7A6C990", VA = "0x187A6DF90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
[TypeManager.ForcedStableTypeHash(14250400792429278320uL)]
public struct NIMPFIKDDHC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(14910416840255214023uL)]
public struct DOAJNKIFOPA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(10891474712127242783uL)]
public struct ICAKNPLAPAF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[InternalBufferCapacity(17)]
[TypeManager.ForcedStableTypeHash(613937678496137215uL)]
public struct BICKNDHLPIP : IBufferElementData, IEquatable<BICKNDHLPIP>, BOAGFLLOLPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity CGGKEPFNHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public int JMPPAOJDMIG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private Entity KNKNIMLGONK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7A6BBA0", Offset = "0x7A6A5A0", VA = "0x187A6BBA0", Slot = "4")]
	public bool Equals(BICKNDHLPIP OLKLGHOAKNE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class DLGMKMLKKMB : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public EJDGDAIPGFC LPMOKCKBNAB;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7A6BFC0", Offset = "0x7A6A9C0", VA = "0x187A6BFC0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public DLGMKMLKKMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface EJDGDAIPGFC
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(1690080301203719739uL)]
public struct GLMACMKJMEB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(13667964378929084748uL)]
public readonly struct HIAOINCGDIK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly KPAMAIDLAIP HOJKHOCJOOK;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2CC3920", Offset = "0x2CC2320", VA = "0x182CC3920")]
	public HIAOINCGDIK(KPAMAIDLAIP HOJKHOCJOOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7A6C4E0", Offset = "0x7A6AEE0", VA = "0x187A6C4E0")]
	public HIAOINCGDIK DFFCAEDGEHN(KPAMAIDLAIP NKNHIPAPJKB)
	{
		return default(HIAOINCGDIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7A6C4D0", Offset = "0x7A6AED0", VA = "0x187A6C4D0")]
	public HIAOINCGDIK AGCOIEMBNPI(KPAMAIDLAIP BIFNNGNBNCL)
	{
		return default(HIAOINCGDIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7A6C4F0", Offset = "0x7A6AEF0", VA = "0x187A6C4F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Flags]
public enum KPAMAIDLAIP : ushort
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
public static class MOEBKPFAAFF
{
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(1995886936411817354uL)]
public struct PMPNFOLDIPC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public KPAMAIDLAIP IPOIANHMKLP;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7A6E420", Offset = "0x7A6CE20", VA = "0x187A6E420")]
	public bool LJMBBMCNKIA(HIAOINCGDIK BBCMBGAAODC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7A6E400", Offset = "0x7A6CE00", VA = "0x187A6E400")]
	public bool HIBCLAAODDH(HIAOINCGDIK BBCMBGAAODC, KPAMAIDLAIP PGEMLCAIHNP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Flags]
public enum EKCPNKAEKCO : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(12096894998449299302uL)]
[SingletonComponent]
public struct NADPBKFGDMJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public EKCPNKAEKCO HOJKHOCJOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public bool PAAGAGCNFEC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool HJLDDGOOHLE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7A6DC10", Offset = "0x7A6C610", VA = "0x187A6DC10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7A6DC40", Offset = "0x7A6C640", VA = "0x187A6DC40")]
	private NADPBKFGDMJ(EKCPNKAEKCO HOJKHOCJOOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7A6DC20", Offset = "0x7A6C620", VA = "0x187A6DC20")]
	public NADPBKFGDMJ DFFCAEDGEHN(EKCPNKAEKCO NKNHIPAPJKB)
	{
		return default(NADPBKFGDMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7A6DBF0", Offset = "0x7A6C5F0", VA = "0x187A6DBF0")]
	public NADPBKFGDMJ AGCOIEMBNPI(EKCPNKAEKCO BIFNNGNBNCL)
	{
		return default(NADPBKFGDMJ);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
[TypeManager.ForcedStableTypeHash(3210980466644930997uL)]
public struct AOOJKNIPBLG : IComponentData
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
public struct BKDGJCCCOOJ : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity BGPPDNIOKDA;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[TypeManager.ForcedStableTypeHash(2803523268494646145uL)]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : IBufferElementData, IEquatable<ChildBuffer>, BOAGFLLOLPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7A6BA40", Offset = "0x7A6A440", VA = "0x187A6BA40", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xC12D40", Offset = "0xC11740", VA = "0x180C12D40")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6734819606313844273uL)]
public struct MBLILPKGIBF : ISystemStateBufferElementData, IBufferElementData, BOAGFLLOLPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public Entity CGNAGBGLBDK;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Entity AMICHBPMCHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[TypeManager.ForcedStableTypeHash(10606242260416974827uL)]
public struct CEGEFDMPABI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public Entity MEFEAOEMHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public Entity NPJGGHGBLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Entity PAKEKEHKENM;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct APCBDOFDJIE<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly bool BFBBKCKIDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public uint KDLAMKDBHPC;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool MDBJKJMOCAH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[TypeManager.TypeVersion(2)]
[TypeManager.ForcedStableTypeHash(14518013333183728344uL)]
public struct IODNIGOKEMO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public uint LOOMJHGMFAD;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x11DE630", Offset = "0x11DD030", VA = "0x1811DE630")]
	public IODNIGOKEMO(MNGNDNIEHNP NBMFEEBJLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7A6C960", Offset = "0x7A6B360", VA = "0x187A6C960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1D76B80", Offset = "0x1D75580", VA = "0x181D76B80")]
	public static IODNIGOKEMO MEHFEEABIDG(MNGNDNIEHNP NBMFEEBJLOH)
	{
		return default(IODNIGOKEMO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[TypeManager.ForcedStableTypeHash(12631852336897389638uL)]
public struct KPJDPFOAGOB : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Entity CGNAGBGLBDK;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[TypeManager.ForcedStableTypeHash(8586426759787957142uL)]
public struct MNLMNMFDHNB : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public MNGNDNIEHNP PPJFMHBDGNA;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[TypeManager.ForcedStableTypeHash(3916218676170013300uL)]
public struct BCLLELFAJAN : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Entity CGNAGBGLBDK;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[TypeManager.ForcedStableTypeHash(3395423174463894753uL)]
public struct CNCKPJJIFMI : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Guid BIGAPECKJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int PGJKBFGEJNK;
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[TypeManager.ForcedStableTypeHash(13485578171010875955uL)]
public struct LLOONHMFOEP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public int PPJFMHBDGNA;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[TypeManager.ForcedStableTypeHash(11182407275731589027uL)]
public struct GLGLNBODPLM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Entity CGNAGBGLBDK;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[TypeManager.ForcedStableTypeHash(238571310055566811uL)]
public struct EBNHBBNJMDE : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public MNGNDNIEHNP PPJFMHBDGNA;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[TypeManager.ForcedStableTypeHash(17943708062286791581uL)]
public struct FAJFJFBJPCH : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Entity CGNAGBGLBDK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
[TypeManager.ForcedStableTypeHash(17717774548790709874uL)]
public struct HDIGLBCMEBH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(1628423395607207516uL)]
public struct LAFODEKPACB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int KAMDOOGECGD;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[TypeManager.ForcedStableTypeHash(6255673600552782006uL)]
public struct GGKLNMGJIHD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int LNFLFPBOJOG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public JKHDNFMHOCD EKAPONBNDPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9F9640", Offset = "0x9F8040", VA = "0x1809F9640")]
		get
		{
			return default(JKHDNFMHOCD);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[TypeManager.ForcedStableTypeHash(7921165883083593916uL)]
public struct DDDDGBDGPFL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public GCHandle BJBICCJFDPB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
[TypeManager.ForcedStableTypeHash(14965811366685608319uL)]
public struct CKJFPAEBPEN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
[TypeManager.ForcedStableTypeHash(8376615066990205632uL)]
public struct OFGKHKIBGJI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
[TypeManager.ForcedStableTypeHash(7273320061473429398uL)]
public struct BOBPEIDIPHG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
[TypeManager.ForcedStableTypeHash(15140206241145976177uL)]
public struct PNLIBNMMCNN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
[TypeManager.ForcedStableTypeHash(15969631250552901108uL)]
public struct AJJJPJLKMOC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[TypeManager.ForcedStableTypeHash(9353178840587053763uL)]
public struct PLCDINDMMEG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public int DOAKEFBOPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public int AIBPOENNNGG;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7A6E330", Offset = "0x7A6CD30", VA = "0x187A6E330")]
	public PLCDINDMMEG(Entity CGNAGBGLBDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[TypeManager.ForcedStableTypeHash(16229383422209788655uL)]
public struct OEHFJBBLPDE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public CollisionDetectionMode JOKCKJGMFOB;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(5173865590150727846uL)]
public struct BODPDDDNHHF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public HNIGDDENMGF DGKCIHOGHGM;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly BODPDDDNHHF JKECEEFIAPF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003C")]
[TypeManager.ForcedStableTypeHash(7051356195299730219uL)]
public struct ILANJILCPDH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003D")]
[TypeManager.ForcedStableTypeHash(780557526766205634uL)]
public struct FEBHGJEDBDA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003E")]
[TypeManager.ForcedStableTypeHash(16413322458062516985uL)]
public struct CDHCIBIABNE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[TypeManager.ForcedStableTypeHash(8350832327674051347uL)]
[InternalBufferCapacity(0)]
public struct ODPDEONJLPM : IBufferElementData, IEquatable<ODPDEONJLPM>, BOAGFLLOLPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Entity CGGKEPFNHFP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity KNKNIMLGONK
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7A6BA40", Offset = "0x7A6A440", VA = "0x187A6BA40", Slot = "4")]
	public bool Equals(ODPDEONJLPM OLKLGHOAKNE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[TypeManager.ForcedStableTypeHash(3503423083784418805uL)]
public struct CBHGOBGPDKA : IComponentData, BOAGFLLOLPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Entity HGBJMKAPAJA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Entity KNKNIMLGONK
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000041")]
[TypeManager.ForcedStableTypeHash(14551834985136520975uL)]
public struct COJCHBOHFDJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[TypeManager.ForcedStableTypeHash(4388378139562737487uL)]
public struct PKJDFEGFDAD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Entity MHHKOMDGDID;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct PLLPLNKJBLP : GCMDOONGFHE, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public FLLMDNHGNBM AJONEENKLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(FLLMDNHGNBM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[TypeManager.ForcedStableTypeHash(769086036388751339uL)]
public struct EHJLFJKKHIE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float3 LMGDLPKFLBF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000045")]
[TypeManager.ForcedStableTypeHash(15638082890667179775uL)]
public struct MHOLKMGHDBF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(7040629969868025973uL)]
public struct GNBCBMDCJAH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public float3x3 NGPEMHIJION;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly GNBCBMDCJAH JKECEEFIAPF;
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(1290915447730818204uL)]
public struct HNKOJOBIHHG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float3x3 NGPEMHIJION;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly HNKOJOBIHHG JKECEEFIAPF;
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[TypeManager.ForcedStableTypeHash(7667208078276643555uL)]
public struct HMLBCBABIIL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float3 IFOLDLDJDFF;
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[TypeManager.ForcedStableTypeHash(11475279934298573286uL)]
public struct GMIIOCJLCLB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public float3 ICEMGFKKLMF;
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(18413785019621221410uL)]
public struct FMCKOCAGBLE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public float GMHILGCCKLP;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly FMCKOCAGBLE JKECEEFIAPF;
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(16788150452972582455uL)]
public struct CGAMICDPBLM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float DJPMGMIBIEI;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly CGAMICDPBLM JKECEEFIAPF;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[TypeManager.ForcedStableTypeHash(971312552983123380uL)]
public struct BOAJAIPFNBB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public float3 LFKEIMJCIAF;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[TypeManager.ForcedStableTypeHash(361641396811542242uL)]
public struct PNLOMGJFLDO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public FDEOGDPKFCL HAJKLCOCJOA;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(7520974846918069913uL)]
public struct CFDCKLHMPCE : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Entity CGNAGBGLBDK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
[TypeManager.ForcedStableTypeHash(9260549625364734686uL)]
public struct BIANMLFCEJM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
[TypeManager.ForcedStableTypeHash(469905343419662571uL)]
public struct HIOJOCPHKMP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[TypeManager.ForcedStableTypeHash(7865784707562564105uL)]
public struct DLCPIKPNOJG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public RigidbodyConstraints ODACFPDGGJM;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[TypeManager.ForcedStableTypeHash(7877027338327956319uL)]
[RegisterComponentDefault]
public struct GKPJJMKNHKD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public float CGGNBGNBIIJ;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly GKPJJMKNHKD JKECEEFIAPF;
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[TypeManager.ForcedStableTypeHash(935406425377786813uL)]
public struct GLCICCOHLBA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float DDGFLICCGJD;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class EOJCFAJHJJL : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GameObject IHDAMAGFMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public object NNJJGBANEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public object LHLAGKMEFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public EEAKLOMOEIA BHOIPEJOEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public Delegate NPECLBBIODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Delegate KOCAJPMEJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public HPNOBMMHMAN<Delegate> JBLOHLDANOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public HPNOBMMHMAN<Delegate> EDOIFKGADND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public HPNOBMMHMAN<Delegate> FKLLGEDIKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public HPNOBMMHMAN<Delegate> CAOHBFIFIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public HPNOBMMHMAN<Delegate> DMDLDGPIMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public HPNOBMMHMAN<Delegate> DPBKKLDDGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public HPNOBMMHMAN<Delegate> KGJCFILBEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public HPNOBMMHMAN<Delegate> FGAMKECJGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public HPNOBMMHMAN<Delegate> JNDOLLPNMMM;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7A6C180", Offset = "0x7A6AB80", VA = "0x187A6C180", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public EOJCFAJHJJL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
[TypeManager.ForcedStableTypeHash(18165447863202358792uL)]
public struct ICDKMILNNMH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[TypeManager.ForcedStableTypeHash(10810926406358250264uL)]
public struct BELONOEANFM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public int IHHGNIEJKKA;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1D76B80", Offset = "0x1D75580", VA = "0x181D76B80")]
	public static BELONOEANFM MEHFEEABIDG(int PPJFMHBDGNA)
	{
		return default(BELONOEANFM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class AMOFCJMDLHP : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Rigidbody NEPEGLKEMNE;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7A6B9D0", Offset = "0x7A6A3D0", VA = "0x187A6B9D0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public AMOFCJMDLHP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
[TypeManager.ForcedStableTypeHash(12765569839950265583uL)]
public struct BPGHPHFPOIE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[TypeManager.ForcedStableTypeHash(17236748096909814533uL)]
public struct KKJENBFPHOD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 AEJKODDIOPN;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[TypeManager.ForcedStableTypeHash(1288392478539867023uL)]
public struct OFFKABOJOPH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float3 FKMLPLAMBLK;
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(15102898512288820575uL)]
public struct KIEKJOPEHHE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float PDIIMOBPILN;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly KIEKJOPEHHE JKECEEFIAPF;
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class NKIBOHOEIEI : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public object IHOJAEAFFMA;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7A6E0A0", Offset = "0x7A6CAA0", VA = "0x187A6E0A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public NKIBOHOEIEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class BGBDDBMJPPA : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public object JIJNNDINMNF;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7A6BB30", Offset = "0x7A6A530", VA = "0x187A6BB30", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public BGBDDBMJPPA()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
[TypeManager.ForcedStableTypeHash(3505189951659289292uL)]
public struct PHAOHKBJKNB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
[TypeManager.ForcedStableTypeHash(16217323095468023009uL)]
public struct CAKBEIMCGEH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
[TypeManager.ForcedStableTypeHash(12880717127246424414uL)]
public struct EKEMGKNGEGO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
[TypeManager.ForcedStableTypeHash(12942629461400744171uL)]
public struct JPFKJHMONOH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[TypeManager.ForcedStableTypeHash(10226241216405964379uL)]
public struct KAIEBGFHOIH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
[TypeManager.ForcedStableTypeHash(12400259538654257671uL)]
public struct JBKGIDANBKL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
[TypeManager.ForcedStableTypeHash(12731949941800560397uL)]
public struct IOEEEFMDLFC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
[TypeManager.ForcedStableTypeHash(16270799832065682331uL)]
public struct GKOHNKCDJGG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
[TypeManager.ForcedStableTypeHash(9395080039644288849uL)]
public struct OMBIEIGOHNG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[TypeManager.ForcedStableTypeHash(282623311697096978uL)]
public struct FPADEBLLEGD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NLLAEBLBHHD COIFLLKNIJD;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7A6C350", Offset = "0x7A6AD50", VA = "0x187A6C350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
[TypeManager.ForcedStableTypeHash(10395819776101408141uL)]
public struct AJGHIBDAEBH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
[TypeManager.ForcedStableTypeHash(375953524326549120uL)]
public struct ICBNFPFFFAF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
[TypeManager.ForcedStableTypeHash(14259779488802476986uL)]
public struct MHGHKAMELDN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[TypeManager.ForcedStableTypeHash(15330221065042235480uL)]
public struct DCMICHCFLOO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public FixedString32Bytes EMLAIMJKHOE;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(5162925656869367991uL)]
public struct AKKLLDLPIGN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public UnsafeParallelHashMap<NLLAEBLBHHD, Entity> OIIEPNLMNCJ;
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[TypeManager.ForcedStableTypeHash(9841032716800521808uL)]
public struct ICCBFODLIHN : ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Entity MCNNFMJJMFK;
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[TypeManager.ForcedStableTypeHash(154813247653871879uL)]
internal struct JABEFFHGCBM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Entity CGNAGBGLBDK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xC12D40", Offset = "0xC11740", VA = "0x180C12D40")]
	public static JABEFFHGCBM MEHFEEABIDG(Entity CGNAGBGLBDK)
	{
		return default(JABEFFHGCBM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[TypeManager.ForcedStableTypeHash(11656653634719673845uL)]
public struct COBMCDJJMIA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Entity FFLKNEOJNJG;
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[TypeManager.ForcedStableTypeHash(1837719173092935466uL)]
public struct FBPJKPJGBIP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity FFLKNEOJNJG;
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[TypeManager.ForcedStableTypeHash(17382237360022739174uL)]
internal struct DKEKLGDBMJL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Entity LCDNGMPLBEC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xC12D40", Offset = "0xC11740", VA = "0x180C12D40")]
	public static DKEKLGDBMJL MEHFEEABIDG(Entity CGNAGBGLBDK)
	{
		return default(DKEKLGDBMJL);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
[TypeManager.ForcedStableTypeHash(15858722173278118533uL)]
internal struct KPJOEGELMJL : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[TypeManager.ForcedStableTypeHash(10313790595830381076uL)]
public struct MHBDILECOFL : IBufferElementData, IEquatable<MHBDILECOFL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Entity BOLKIDCDNAM;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x78B8D90", Offset = "0x78B7790", VA = "0x1878B8D90", Slot = "4")]
	public bool Equals(MHBDILECOFL OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7A6D900", Offset = "0x7A6C300", VA = "0x187A6D900", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x9F9640", Offset = "0x9F8040", VA = "0x1809F9640", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[TypeManager.ForcedStableTypeHash(10169361040328370708uL)]
public struct OLPHOLNEOFI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public uint AIBPOENNNGG;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(11536226225076729790uL)]
internal struct EJDBEGAPOFA : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Entity KIFJADBHAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public int DOAKEFBOPIA;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[TypeManager.ForcedStableTypeHash(8309037880064337491uL)]
internal struct DDEGDCIMBFE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public Entity CIGFHDBGGNF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
[TypeManager.ForcedStableTypeHash(5891816987223099091uL)]
public struct NIMNKLOCPHB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[TypeManager.ForcedStableTypeHash(17289298604600812224uL)]
public struct GFMJHIHGFKJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public uint KDLAMKDBHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int OHCLNLEPCFP;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xC9DAC0", Offset = "0xC9C4C0", VA = "0x180C9DAC0")]
	public GFMJHIHGFKJ(uint LCKEIMADOKK, int OFDHMHDLPBL)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
[TypeManager.ForcedStableTypeHash(12258100538258701401uL)]
public struct EFKAAPFNEBH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
[TypeManager.ForcedStableTypeHash(3081870877980445988uL)]
public struct CDAHOBOAKHG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
[TypeManager.ForcedStableTypeHash(15554741495161407507uL)]
public struct HMPGJFBIIJE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
[TypeManager.ForcedStableTypeHash(17684057078056878475uL)]
public struct GFPPKFACHLF : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
[TypeManager.ForcedStableTypeHash(10023455309444528896uL)]
public struct DPPILDEMBMK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
[TypeManager.ForcedStableTypeHash(14403752119546393228uL)]
public struct PCCOAEAGIGM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
[TypeManager.ForcedStableTypeHash(9219181242087356214uL)]
public struct OOCIBKKLMDN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
[TypeManager.ForcedStableTypeHash(12371658133244024718uL)]
public struct NNABCJBKEMB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
[TypeManager.ForcedStableTypeHash(9351414359236295489uL)]
public struct EPEMINPMIAO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
[TypeManager.ForcedStableTypeHash(12796707860320869007uL)]
internal struct AEKPBFCECEB : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
[TypeManager.ForcedStableTypeHash(13367368557807690484uL)]
public struct MJBGGCFAKJD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
[TypeManager.ForcedStableTypeHash(7193071459223094579uL)]
public struct AMGNABJOEDH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000085")]
[TypeManager.ForcedStableTypeHash(15247343901949961769uL)]
public struct CFKKMBMANCH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
[TypeManager.ForcedStableTypeHash(5381043565870728787uL)]
public struct KOPNKHNLELJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
[TypeManager.ForcedStableTypeHash(11597028615900234104uL)]
internal struct ICPDBNMGEIM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
[TypeManager.ForcedStableTypeHash(1907494159895213433uL)]
internal struct JCACGEGLPPJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
[TypeManager.ForcedStableTypeHash(3955886960983597628uL)]
public struct NEGAPJPEIED : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
[TypeManager.ForcedStableTypeHash(480620745253244652uL)]
public struct BMBJFFEABCM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
[TypeManager.ForcedStableTypeHash(8253675824478287824uL)]
public struct FKLFCJHMFPG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008C")]
[TypeManager.ForcedStableTypeHash(8855488771047251567uL)]
public struct PAHIKECECMI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
[TypeManager.ForcedStableTypeHash(8375777954271012995uL)]
public struct CJIAMCIEKLM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008E")]
[TypeManager.ForcedStableTypeHash(16444804027614993581uL)]
public struct FKKEPBANHBA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
[TypeManager.ForcedStableTypeHash(16177323740107409537uL)]
public struct HBELAPGCPEJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
[TypeManager.ForcedStableTypeHash(11049752089067741804uL)]
public struct PKIIPBOEOGC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
[TypeManager.ForcedStableTypeHash(1453937769327886583uL)]
public struct NOMFECPINCN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000092")]
[TypeManager.ForcedStableTypeHash(800754555681830909uL)]
public struct HIMKDAGLONK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000093")]
[TypeManager.ForcedStableTypeHash(3336901602667819150uL)]
public struct DAOFKGHGDMH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000094")]
[TypeManager.ForcedStableTypeHash(11809750536411032401uL)]
public struct CAIFEAGKKBH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000095")]
[TypeManager.ForcedStableTypeHash(6387004770090400669uL)]
public struct JHABLHGHHBB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000096")]
[TypeManager.ForcedStableTypeHash(2223159712203397538uL)]
internal struct HGKGJLJEBJK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
[TypeManager.ForcedStableTypeHash(10153397523300334327uL)]
public struct HOGGEPJHNIH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000098")]
[TypeManager.ForcedStableTypeHash(12983102201306073842uL)]
public struct OPOIFAFHACA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000099")]
[TypeManager.ForcedStableTypeHash(15398959433761599914uL)]
[JCPBMBFIJIM]
public struct JLDDANFJFEJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6605318152550716456uL)]
public struct BFIDOALNJKJ : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public FixedString32Bytes FDBECNGFMME;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009B")]
[TypeManager.ForcedStableTypeHash(10065634662848845784uL)]
public struct EIDADDGDOLD : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
[TypeManager.ForcedStableTypeHash(15062299176839263439uL)]
public struct KFCOODLLCKA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009D")]
[TypeManager.ForcedStableTypeHash(3596269116834888123uL)]
internal struct ECJDNKNIDKC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009E")]
[TypeManager.ForcedStableTypeHash(4402941654898007496uL)]
internal struct ODJPJMPINMC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
[TypeManager.ForcedStableTypeHash(12682474121528142025uL)]
internal struct ODMHJKFNPJK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[TypeManager.ForcedStableTypeHash(1840266485562743455uL)]
public struct DCPJPFDPDJH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[TypeManager.ForcedStableTypeHash(4772574226205567794uL)]
public struct HDLLANEBAAI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[TypeManager.ForcedStableTypeHash(17642911464827038147uL)]
public struct HBJHNHGNFJL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public quaternion KONJHPLFEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float3 KKIJMCHODGC;
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[TypeManager.ForcedStableTypeHash(9066921186040058989uL)]
public struct PMLKOIBNONC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float CNEGPCMLHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float OCCLNPFMAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float FMMHBALBGML;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[TypeManager.ForcedStableTypeHash(3328998613642473514uL)]
public struct PBOFIDPKMID : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[TypeManager.ForcedStableTypeHash(151116349382904900uL)]
public struct NNLLLDFJHAB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[TypeManager.ForcedStableTypeHash(8067675582152570601uL)]
public struct PNLKLANNMNM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[TypeManager.ForcedStableTypeHash(4522686316477281096uL)]
public struct CIFLAJLPNDB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public int LNFLFPBOJOG;
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6216404920432680992uL)]
public struct LHGBPAODGFE : ISystemStateBufferElementData, IBufferElementData, BOAGFLLOLPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Entity GAICPBMAOMP;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity AMICHBPMCHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(419884688393735449uL)]
public struct LCIMICDAGBA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public float4x4 NLGEOBNCPOL;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly LCIMICDAGBA JKECEEFIAPF;
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(1954795745923300919uL)]
public struct BNKJLFLADEH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public float4x4 FFKIELGPMDB;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly BNKJLFLADEH JKECEEFIAPF;
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[TypeManager.ForcedStableTypeHash(2447627752265109178uL)]
public struct CNHFEECLBJE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private int DKFJAHHCONE;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int DOAKEFBOPIA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7A6BD70", Offset = "0x7A6A770", VA = "0x187A6BD70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7A6BD60", Offset = "0x7A6A760", VA = "0x187A6BD60")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(13706996280046618062uL)]
public struct HPINJEDNMAH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public float3 KKIJMCHODGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public quaternion KONJHPLFEME;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly HPINJEDNMAH JKECEEFIAPF;
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class JFLGDMLALEI
{
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(77694943841979493uL)]
public struct CBOLHGBAHHD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public float LADPIIKEOMJ;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly CBOLHGBAHHD JKECEEFIAPF;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[TypeManager.ForcedStableTypeHash(6537711325103434903uL)]
public struct JLFINOMDCPJ : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Entity ILBJJIFAJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public PDPDCPPPIIG OAIBEKCJMGA;
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[TypeManager.ForcedStableTypeHash(5471640964865828061uL)]
public struct DMLJPFCFKMB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public PDPDCPPPIIG OAIBEKCJMGA;
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[TypeManager.ForcedStableTypeHash(16527934868211432802uL)]
public struct IONMENKFNOE : ISystemStateComponentData, IComponentData, BOAGFLLOLPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Entity NMGLJLCLAKO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Entity AMICHBPMCHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[TypeManager.ForcedStableTypeHash(15310407062508355916uL)]
public struct AFFKBAJCMBE : ISystemStateBufferElementData, IBufferElementData, BOAGFLLOLPF, IEquatable<AFFKBAJCMBE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Entity OOLOPHFNKML;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Entity AMICHBPMCHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x78B8D90", Offset = "0x78B7790", VA = "0x1878B8D90", Slot = "6")]
	public bool Equals(AFFKBAJCMBE OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7A6B880", Offset = "0x7A6A280", VA = "0x187A6B880", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9F9640", Offset = "0x9F8040", VA = "0x1809F9640", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[TypeManager.ForcedStableTypeHash(11786768220100978132uL)]
public struct AIIPMLDFOIE : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Entity ILBJJIFAJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public PDPDCPPPIIG OAIBEKCJMGA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct JAGPALDJCFI : IEqualityComparer<AIIPMLDFOIE>
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static JAGPALDJCFI JKECEEFIAPF;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7A6CA70", Offset = "0x7A6B470", VA = "0x187A6CA70", Slot = "4")]
	public bool Equals(AIIPMLDFOIE CJBFFOKBLHB, AIIPMLDFOIE CNBLFOFLDDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7A6CAC0", Offset = "0x7A6B4C0", VA = "0x187A6CAC0", Slot = "5")]
	public int GetHashCode(AIIPMLDFOIE OIIGDBLKEDN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[TypeManager.ForcedStableTypeHash(8981997360983277121uL)]
public struct MFONPMMGMCD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public FixedList32Bytes<int> AGMGBCKIJCO;
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[TypeManager.ForcedStableTypeHash(2801212869002544047uL)]
public struct OCMHOOEKONF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public FixedList32Bytes<int> AGMGBCKIJCO;
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[TypeManager.ForcedStableTypeHash(16455485691096333919uL)]
public struct MENBGNDHFEF : ISystemStateBufferElementData, IBufferElementData, BOAGFLLOLPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public Entity LBMKGLPDEBP;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Entity KNKNIMLGONK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xC9BA50", Offset = "0xC9A450", VA = "0x180C9BA50", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xE68EE0", Offset = "0xE678E0", VA = "0x180E68EE0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal class NGHKMHIPCNJ : ContainerPropertyBag<DLGMKMLKKMB>
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	private class IKBDGOFFKEO : Property<DLGMKMLKKMB, EJDGDAIPGFC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string HFKDIDMKBGI
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7A6C930", Offset = "0x7A6B330", VA = "0x187A6C930", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool KMCAIMHLNNE
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7A6C8F0", Offset = "0x7A6B2F0", VA = "0x187A6C8F0")]
		public IKBDGOFFKEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7A6B7C0", Offset = "0x7A6A1C0", VA = "0x187A6B7C0", Slot = "14")]
		public override EJDGDAIPGFC GetValue(DLGMKMLKKMB MCJDMILNGAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7A6B7E0", Offset = "0x7A6A1E0", VA = "0x187A6B7E0", Slot = "15")]
		public override void SetValue(DLGMKMLKKMB MCJDMILNGAL, EJDGDAIPGFC PPJFMHBDGNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7A6DC50", Offset = "0x7A6C650", VA = "0x187A6DC50")]
	public NGHKMHIPCNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal class KFNBABNMBNO : ContainerPropertyBag<EOJCFAJHJJL>
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	private class LNHAFPCBHPJ : Property<EOJCFAJHJJL, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string HFKDIDMKBGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x7A6D810", Offset = "0x7A6C210", VA = "0x187A6D810", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool KMCAIMHLNNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7A6D7D0", Offset = "0x7A6C1D0", VA = "0x187A6D7D0")]
		public LNHAFPCBHPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7A6B7C0", Offset = "0x7A6A1C0", VA = "0x187A6B7C0", Slot = "14")]
		public override GameObject GetValue(EOJCFAJHJJL MCJDMILNGAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7A6B7E0", Offset = "0x7A6A1E0", VA = "0x187A6B7E0", Slot = "15")]
		public override void SetValue(EOJCFAJHJJL MCJDMILNGAL, GameObject PPJFMHBDGNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	private class OAGHNNODIFM : Property<EOJCFAJHJJL, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string HFKDIDMKBGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7A6E280", Offset = "0x7A6CC80", VA = "0x187A6E280", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool KMCAIMHLNNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7A6E240", Offset = "0x7A6CC40", VA = "0x187A6E240")]
		public OAGHNNODIFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7A6E1F0", Offset = "0x7A6CBF0", VA = "0x187A6E1F0", Slot = "14")]
		public override object GetValue(EOJCFAJHJJL MCJDMILNGAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7A6E210", Offset = "0x7A6CC10", VA = "0x187A6E210", Slot = "15")]
		public override void SetValue(EOJCFAJHJJL MCJDMILNGAL, object PPJFMHBDGNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	private class DEMEGPIGIEP : Property<EOJCFAJHJJL, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string HFKDIDMKBGI
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7A6BF90", Offset = "0x7A6A990", VA = "0x187A6BF90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool KMCAIMHLNNE
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7A6BF50", Offset = "0x7A6A950", VA = "0x187A6BF50")]
		public DEMEGPIGIEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7A6BF00", Offset = "0x7A6A900", VA = "0x187A6BF00", Slot = "14")]
		public override object GetValue(EOJCFAJHJJL MCJDMILNGAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7A6BF20", Offset = "0x7A6A920", VA = "0x187A6BF20", Slot = "15")]
		public override void SetValue(EOJCFAJHJJL MCJDMILNGAL, object PPJFMHBDGNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	private class HPPKGCHIKIL : Property<EOJCFAJHJJL, EEAKLOMOEIA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string HFKDIDMKBGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x7A6C8C0", Offset = "0x7A6B2C0", VA = "0x187A6C8C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool KMCAIMHLNNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7A6C880", Offset = "0x7A6B280", VA = "0x187A6C880")]
		public HPPKGCHIKIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7A6C830", Offset = "0x7A6B230", VA = "0x187A6C830", Slot = "14")]
		public override EEAKLOMOEIA GetValue(EOJCFAJHJJL MCJDMILNGAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7A6C850", Offset = "0x7A6B250", VA = "0x187A6C850", Slot = "15")]
		public override void SetValue(EOJCFAJHJJL MCJDMILNGAL, EEAKLOMOEIA PPJFMHBDGNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private class PLHLOFCJJAP : Property<EOJCFAJHJJL, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string HFKDIDMKBGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7A6E3D0", Offset = "0x7A6CDD0", VA = "0x187A6E3D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool KMCAIMHLNNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7A6E390", Offset = "0x7A6CD90", VA = "0x187A6E390")]
		public PLHLOFCJJAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7A6E340", Offset = "0x7A6CD40", VA = "0x187A6E340", Slot = "14")]
		public override Delegate GetValue(EOJCFAJHJJL MCJDMILNGAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7A6E360", Offset = "0x7A6CD60", VA = "0x187A6E360", Slot = "15")]
		public override void SetValue(EOJCFAJHJJL MCJDMILNGAL, Delegate PPJFMHBDGNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private class MOOLPKDNODB : Property<EOJCFAJHJJL, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string HFKDIDMKBGI
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7A6DB50", Offset = "0x7A6C550", VA = "0x187A6DB50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool KMCAIMHLNNE
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7A6DB10", Offset = "0x7A6C510", VA = "0x187A6DB10")]
		public MOOLPKDNODB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7A6DAC0", Offset = "0x7A6C4C0", VA = "0x187A6DAC0", Slot = "14")]
		public override Delegate GetValue(EOJCFAJHJJL MCJDMILNGAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7A6DAE0", Offset = "0x7A6C4E0", VA = "0x187A6DAE0", Slot = "15")]
		public override void SetValue(EOJCFAJHJJL MCJDMILNGAL, Delegate PPJFMHBDGNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private class HPBIOEMOEIC : Property<EOJCFAJHJJL, HPNOBMMHMAN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string HFKDIDMKBGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7A6C6D0", Offset = "0x7A6B0D0", VA = "0x187A6C6D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool KMCAIMHLNNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7A6C690", Offset = "0x7A6B090", VA = "0x187A6C690")]
		public HPBIOEMOEIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7A6C640", Offset = "0x7A6B040", VA = "0x187A6C640", Slot = "14")]
		public override HPNOBMMHMAN<Delegate> GetValue(EOJCFAJHJJL MCJDMILNGAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7A6C660", Offset = "0x7A6B060", VA = "0x187A6C660", Slot = "15")]
		public override void SetValue(EOJCFAJHJJL MCJDMILNGAL, HPNOBMMHMAN<Delegate> PPJFMHBDGNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private class ALABGHFNLDN : Property<EOJCFAJHJJL, HPNOBMMHMAN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string HFKDIDMKBGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x7A6B9A0", Offset = "0x7A6A3A0", VA = "0x187A6B9A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool KMCAIMHLNNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7A6B960", Offset = "0x7A6A360", VA = "0x187A6B960")]
		public ALABGHFNLDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7A6B910", Offset = "0x7A6A310", VA = "0x187A6B910", Slot = "14")]
		public override HPNOBMMHMAN<Delegate> GetValue(EOJCFAJHJJL MCJDMILNGAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7A6B930", Offset = "0x7A6A330", VA = "0x187A6B930", Slot = "15")]
		public override void SetValue(EOJCFAJHJJL MCJDMILNGAL, HPNOBMMHMAN<Delegate> PPJFMHBDGNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private class DEBHODNGECL : Property<EOJCFAJHJJL, HPNOBMMHMAN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string HFKDIDMKBGI
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7A6BED0", Offset = "0x7A6A8D0", VA = "0x187A6BED0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool KMCAIMHLNNE
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7A6BE90", Offset = "0x7A6A890", VA = "0x187A6BE90")]
		public DEBHODNGECL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7A6BE40", Offset = "0x7A6A840", VA = "0x187A6BE40", Slot = "14")]
		public override HPNOBMMHMAN<Delegate> GetValue(EOJCFAJHJJL MCJDMILNGAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7A6BE60", Offset = "0x7A6A860", VA = "0x187A6BE60", Slot = "15")]
		public override void SetValue(EOJCFAJHJJL MCJDMILNGAL, HPNOBMMHMAN<Delegate> PPJFMHBDGNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private class FEMABJEEMFJ : Property<EOJCFAJHJJL, HPNOBMMHMAN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string HFKDIDMKBGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7A6C260", Offset = "0x7A6AC60", VA = "0x187A6C260", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool KMCAIMHLNNE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7A6C220", Offset = "0x7A6AC20", VA = "0x187A6C220")]
		public FEMABJEEMFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7A6C1D0", Offset = "0x7A6ABD0", VA = "0x187A6C1D0", Slot = "14")]
		public override HPNOBMMHMAN<Delegate> GetValue(EOJCFAJHJJL MCJDMILNGAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7A6C1F0", Offset = "0x7A6ABF0", VA = "0x187A6C1F0", Slot = "15")]
		public override void SetValue(EOJCFAJHJJL MCJDMILNGAL, HPNOBMMHMAN<Delegate> PPJFMHBDGNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private class MANJPOMKPLD : Property<EOJCFAJHJJL, HPNOBMMHMAN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string HFKDIDMKBGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x7A6D8D0", Offset = "0x7A6C2D0", VA = "0x187A6D8D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool KMCAIMHLNNE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7A6D890", Offset = "0x7A6C290", VA = "0x187A6D890")]
		public MANJPOMKPLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7A6D840", Offset = "0x7A6C240", VA = "0x187A6D840", Slot = "14")]
		public override HPNOBMMHMAN<Delegate> GetValue(EOJCFAJHJJL MCJDMILNGAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7A6D860", Offset = "0x7A6C260", VA = "0x187A6D860", Slot = "15")]
		public override void SetValue(EOJCFAJHJJL MCJDMILNGAL, HPNOBMMHMAN<Delegate> PPJFMHBDGNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	private class COBAJDKBCLF : Property<EOJCFAJHJJL, HPNOBMMHMAN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string HFKDIDMKBGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x7A6BE10", Offset = "0x7A6A810", VA = "0x187A6BE10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool KMCAIMHLNNE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7A6BDD0", Offset = "0x7A6A7D0", VA = "0x187A6BDD0")]
		public COBAJDKBCLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7A6BD80", Offset = "0x7A6A780", VA = "0x187A6BD80", Slot = "14")]
		public override HPNOBMMHMAN<Delegate> GetValue(EOJCFAJHJJL MCJDMILNGAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7A6BDA0", Offset = "0x7A6A7A0", VA = "0x187A6BDA0", Slot = "15")]
		public override void SetValue(EOJCFAJHJJL MCJDMILNGAL, HPNOBMMHMAN<Delegate> PPJFMHBDGNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	private class KNOMMBJKMAD : Property<EOJCFAJHJJL, HPNOBMMHMAN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string HFKDIDMKBGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7A6D6F0", Offset = "0x7A6C0F0", VA = "0x187A6D6F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool KMCAIMHLNNE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7A6D6B0", Offset = "0x7A6C0B0", VA = "0x187A6D6B0")]
		public KNOMMBJKMAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7A6D660", Offset = "0x7A6C060", VA = "0x187A6D660", Slot = "14")]
		public override HPNOBMMHMAN<Delegate> GetValue(EOJCFAJHJJL MCJDMILNGAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7A6D680", Offset = "0x7A6C080", VA = "0x187A6D680", Slot = "15")]
		public override void SetValue(EOJCFAJHJJL MCJDMILNGAL, HPNOBMMHMAN<Delegate> PPJFMHBDGNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	private class JPJAOHHELMI : Property<EOJCFAJHJJL, HPNOBMMHMAN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string HFKDIDMKBGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7A6CBB0", Offset = "0x7A6B5B0", VA = "0x187A6CBB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool KMCAIMHLNNE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7A6CB70", Offset = "0x7A6B570", VA = "0x187A6CB70")]
		public JPJAOHHELMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7A6CB20", Offset = "0x7A6B520", VA = "0x187A6CB20", Slot = "14")]
		public override HPNOBMMHMAN<Delegate> GetValue(EOJCFAJHJJL MCJDMILNGAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7A6CB40", Offset = "0x7A6B540", VA = "0x187A6CB40", Slot = "15")]
		public override void SetValue(EOJCFAJHJJL MCJDMILNGAL, HPNOBMMHMAN<Delegate> PPJFMHBDGNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	private class MIIKJIBEFIM : Property<EOJCFAJHJJL, HPNOBMMHMAN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string HFKDIDMKBGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7A6DA20", Offset = "0x7A6C420", VA = "0x187A6DA20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool KMCAIMHLNNE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7A6D9E0", Offset = "0x7A6C3E0", VA = "0x187A6D9E0")]
		public MIIKJIBEFIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7A6D990", Offset = "0x7A6C390", VA = "0x187A6D990", Slot = "14")]
		public override HPNOBMMHMAN<Delegate> GetValue(EOJCFAJHJJL MCJDMILNGAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7A6D9B0", Offset = "0x7A6C3B0", VA = "0x187A6D9B0", Slot = "15")]
		public override void SetValue(EOJCFAJHJJL MCJDMILNGAL, HPNOBMMHMAN<Delegate> PPJFMHBDGNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7A6CF60", Offset = "0x7A6B960", VA = "0x187A6CF60")]
	public KFNBABNMBNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal class KMAECHCLIDL : ContainerPropertyBag<HPNOBMMHMAN<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7A6D600", Offset = "0x7A6C000", VA = "0x187A6D600")]
	public KMAECHCLIDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal class EDNBOAIKCLC : ContainerPropertyBag<AMOFCJMDLHP>
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	private class AAFANMDFNAC : Property<AMOFCJMDLHP, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string HFKDIDMKBGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7A6B850", Offset = "0x7A6A250", VA = "0x187A6B850", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool KMCAIMHLNNE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7A6B810", Offset = "0x7A6A210", VA = "0x187A6B810")]
		public AAFANMDFNAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7A6B7C0", Offset = "0x7A6A1C0", VA = "0x187A6B7C0", Slot = "14")]
		public override Rigidbody GetValue(AMOFCJMDLHP MCJDMILNGAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7A6B7E0", Offset = "0x7A6A1E0", VA = "0x187A6B7E0", Slot = "15")]
		public override void SetValue(AMOFCJMDLHP MCJDMILNGAL, Rigidbody PPJFMHBDGNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7A6C0A0", Offset = "0x7A6AAA0", VA = "0x187A6C0A0")]
	public EDNBOAIKCLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal class NMCGAOCAANL : ContainerPropertyBag<NKIBOHOEIEI>
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	private class MOPNCHEEMHP : Property<NKIBOHOEIEI, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string HFKDIDMKBGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x7A6DBC0", Offset = "0x7A6C5C0", VA = "0x187A6DBC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool KMCAIMHLNNE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7A6DB80", Offset = "0x7A6C580", VA = "0x187A6DB80")]
		public MOPNCHEEMHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7A6B7C0", Offset = "0x7A6A1C0", VA = "0x187A6B7C0", Slot = "14")]
		public override object GetValue(NKIBOHOEIEI MCJDMILNGAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7A6B7E0", Offset = "0x7A6A1E0", VA = "0x187A6B7E0", Slot = "15")]
		public override void SetValue(NKIBOHOEIEI MCJDMILNGAL, object PPJFMHBDGNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7A6E110", Offset = "0x7A6CB10", VA = "0x187A6E110")]
	public NMCGAOCAANL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal class JAFHFHBHIHN : ContainerPropertyBag<BGBDDBMJPPA>
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	private class EBEPFLBDDFK : Property<BGBDDBMJPPA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string HFKDIDMKBGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x7A6C070", Offset = "0x7A6AA70", VA = "0x187A6C070", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool KMCAIMHLNNE
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7A6C030", Offset = "0x7A6AA30", VA = "0x187A6C030")]
		public EBEPFLBDDFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7A6B7C0", Offset = "0x7A6A1C0", VA = "0x187A6B7C0", Slot = "14")]
		public override object GetValue(BGBDDBMJPPA MCJDMILNGAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7A6B7E0", Offset = "0x7A6A1E0", VA = "0x187A6B7E0", Slot = "15")]
		public override void SetValue(BGBDDBMJPPA MCJDMILNGAL, object PPJFMHBDGNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7A6C990", Offset = "0x7A6B390", VA = "0x187A6C990")]
	public JAFHFHBHIHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal class BFGPGBDHAGB : ContainerPropertyBag<ICCBFODLIHN>
{
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	private class FMNJAMJGLEN : Property<ICCBFODLIHN, Entity>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string HFKDIDMKBGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7A6C320", Offset = "0x7A6AD20", VA = "0x187A6C320", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool KMCAIMHLNNE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7A6C2E0", Offset = "0x7A6ACE0", VA = "0x187A6C2E0")]
		public FMNJAMJGLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xDE2F60", Offset = "0xDE1960", VA = "0x180DE2F60", Slot = "14")]
		public override Entity GetValue(ICCBFODLIHN MCJDMILNGAL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7A6C2D0", Offset = "0x7A6ACD0", VA = "0x187A6C2D0", Slot = "15")]
		public override void SetValue(ICCBFODLIHN MCJDMILNGAL, Entity PPJFMHBDGNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7A6BA50", Offset = "0x7A6A450", VA = "0x187A6BA50")]
	public BFGPGBDHAGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal class JPPOLEMKEEO : ContainerPropertyBag<Entity>
{
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	private class MNEMJDLEBFN : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string HFKDIDMKBGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x7A6DA90", Offset = "0x7A6C490", VA = "0x187A6DA90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool KMCAIMHLNNE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7A6DA50", Offset = "0x7A6C450", VA = "0x187A6DA50")]
		public MNEMJDLEBFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2083650", Offset = "0x2082050", VA = "0x182083650", Slot = "14")]
		public override int GetValue(Entity MCJDMILNGAL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x78B4660", Offset = "0x78B3060", VA = "0x1878B4660", Slot = "15")]
		public override void SetValue(Entity MCJDMILNGAL, int PPJFMHBDGNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	private class OALBGKACLFG : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string HFKDIDMKBGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x7A6E300", Offset = "0x7A6CD00", VA = "0x187A6E300", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool KMCAIMHLNNE
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7A6E2C0", Offset = "0x7A6CCC0", VA = "0x187A6E2C0")]
		public OALBGKACLFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xE74830", Offset = "0xE73230", VA = "0x180E74830", Slot = "14")]
		public override int GetValue(Entity MCJDMILNGAL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7A6E2B0", Offset = "0x7A6CCB0", VA = "0x187A6E2B0", Slot = "15")]
		public override void SetValue(Entity MCJDMILNGAL, int PPJFMHBDGNA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7A6CBE0", Offset = "0x7A6B5E0", VA = "0x187A6CBE0")]
	public JPPOLEMKEEO()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7A6E430", Offset = "0x7A6CE30", VA = "0x187A6E430")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000D7")]
public class LPHLOPHCPMO
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public LPHLOPHCPMO()
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
