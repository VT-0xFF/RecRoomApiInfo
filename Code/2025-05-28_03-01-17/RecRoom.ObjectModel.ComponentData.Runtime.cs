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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F48C60", Offset = "0x7F47A60", VA = "0x187F48C60", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7F49010", Offset = "0x7F47E10", VA = "0x187F49010", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x26D4E40", Offset = "0x26D3C40", VA = "0x1826D4E40")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
[TypeManager.ForcedStableTypeHash(1586941204353847852uL)]
public struct ALLBKGAEHHJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
[TypeManager.ForcedStableTypeHash(1730701010008160003uL)]
public struct MMLBDOFPLCH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
[TypeManager.ForcedStableTypeHash(3399609037308777919uL)]
public struct EGHIOLCANKF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
[TypeManager.ForcedStableTypeHash(18083619841998483100uL)]
public struct NMMHAAOGLIC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
[TypeManager.ForcedStableTypeHash(12361415346715948123uL)]
public struct GMFGNAOKAKJ : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[TypeManager.ForcedStableTypeHash(15820941866177188261uL)]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : IBufferElementData, IEquatable<AuthoredChildBuffer>, GEMOGKGJOPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7F45EA0", Offset = "0x7F44CA0", VA = "0x187F45EA0", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xCA1030", Offset = "0xC9FE30", VA = "0x180CA1030")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
[TypeManager.ForcedStableTypeHash(7794731847884836165uL)]
public struct IHIPMHIIKHJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
[TypeManager.ForcedStableTypeHash(16414266906034106824uL)]
public struct MGDPGOLEKHM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[TypeManager.ForcedStableTypeHash(1525018888797798356uL)]
public struct CBOBNFCBOHO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Entity MABPMOAJPLE;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[TypeManager.ForcedStableTypeHash(6294257411443737851uL)]
public struct DEGBEKJPOKB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity MABPMOAJPLE;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct CJHDHDJIFNC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<IPJINGCFAFB> PLBDAGCMACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<Entity> NMMDGCJKCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private JobHandle JAAMMEMKHCH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool AMBHJOJJGCD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7F46240", Offset = "0x7F45040", VA = "0x187F46240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int GFOKFGGJOIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7F46190", Offset = "0x7F44F90", VA = "0x187F46190")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5D9CC70", Offset = "0x5D9BA70", VA = "0x185D9CC70")]
	public CJHDHDJIFNC(NativeList<IPJINGCFAFB> PLBDAGCMACJ, NativeList<Entity> NMMDGCJKCMM, JobHandle JAAMMEMKHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7F462B0", Offset = "0x7F450B0", VA = "0x187F462B0")]
	public (Entity, NativeSlice<Entity>) LPKENAFMJPI(int CPKBMDHHFLH)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7F461E0", Offset = "0x7F44FE0", VA = "0x187F461E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct IPJINGCFAFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Entity IPCOMOHMNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int PPPFIBNDOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int NPCJGIOCILE;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface FDFBPECHJLN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NDBHIJIDNIK(bool HIINAJHCPIO);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct AJAHHFGNGNK : IEquatable<AJAHHFGNGNK>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate bool KGENCIMIPPI(int FAPLIEIFOHC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly bool AOILIEMCANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool IDLDHKDCJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool IKPPFFKDHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool DGMKDFHNIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly KGENCIMIPPI INEJFPGDCNK;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7F45DB0", Offset = "0x7F44BB0", VA = "0x187F45DB0")]
	public AJAHHFGNGNK(KKNPPHDFLGB KKBDAOHAGLC, KGENCIMIPPI INEJFPGDCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7F45E00", Offset = "0x7F44C00", VA = "0x187F45E00")]
	public AJAHHFGNGNK(bool AOILIEMCANF, bool IDLDHKDCJHK, bool IKPPFFKDHBC, bool DGMKDFHNIPL, KGENCIMIPPI INEJFPGDCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7F45CF0", Offset = "0x7F44AF0", VA = "0x187F45CF0")]
	public bool KODNBCJLDGP(int FAPLIEIFOHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7F45C90", Offset = "0x7F44A90", VA = "0x187F45C90")]
	public bool ILHPGNFGEHN(int FAPLIEIFOHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7F45AC0", Offset = "0x7F448C0", VA = "0x187F45AC0")]
	public bool BMKBMHGLFDB(int FAPLIEIFOHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7F45CC0", Offset = "0x7F44AC0", VA = "0x187F45CC0")]
	public bool JOCMMAOBFIJ(int FAPLIEIFOHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7F45BA0", Offset = "0x7F449A0", VA = "0x187F45BA0", Slot = "4")]
	public bool Equals(AJAHHFGNGNK HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7F45AF0", Offset = "0x7F448F0", VA = "0x187F45AF0", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7F45BF0", Offset = "0x7F449F0", VA = "0x187F45BF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7F45BD0", Offset = "0x7F449D0", VA = "0x187F45BD0")]
	private bool FKKJDKOJEEL(int FAPLIEIFOHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7F45D20", Offset = "0x7F44B20", VA = "0x187F45D20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
[TypeManager.ForcedStableTypeHash(14250400792429278320uL)]
public struct NLEBFEAHDBE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
[TypeManager.ForcedStableTypeHash(14910416840255214023uL)]
public struct MGIECHJHFIM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
[TypeManager.ForcedStableTypeHash(10891474712127242783uL)]
public struct CDCBCDINCCE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[InternalBufferCapacity(17)]
[TypeManager.ForcedStableTypeHash(613937678496137215uL)]
public struct ADEICDAPAGD : IBufferElementData, IEquatable<ADEICDAPAGD>, GEMOGKGJOPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity OBOFPKCKJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public int FNKJBHGFEHM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private Entity INFCOBGALBD
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7F45960", Offset = "0x7F44760", VA = "0x187F45960", Slot = "4")]
	public bool Equals(ADEICDAPAGD HBLONCAMFLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class APEHBGPMCHP : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public ABKBGPGDIAJ NJCLLFFIHGK;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7F45E30", Offset = "0x7F44C30", VA = "0x187F45E30", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public APEHBGPMCHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface ABKBGPGDIAJ
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(1690080301203719739uL)]
public struct HIIJLBLEEIE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[TypeManager.ForcedStableTypeHash(13667964378929084748uL)]
public readonly struct JILKJKBOAGA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly GKBHPNNJDNK PMGANKPPAMI;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2E93D50", Offset = "0x2E92B50", VA = "0x182E93D50")]
	public JILKJKBOAGA(GKBHPNNJDNK PMGANKPPAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7F47840", Offset = "0x7F46640", VA = "0x187F47840")]
	public JILKJKBOAGA NMDEMLKELEM(GKBHPNNJDNK JBPEFHNHACL)
	{
		return default(JILKJKBOAGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7F47850", Offset = "0x7F46650", VA = "0x187F47850")]
	public JILKJKBOAGA OGNJODLLOCJ(GKBHPNNJDNK GKOJBGJFCDD)
	{
		return default(JILKJKBOAGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7F47860", Offset = "0x7F46660", VA = "0x187F47860", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[Flags]
public enum GKBHPNNJDNK : ushort
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
	ReferredToByGroup = 0x200,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	All = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class JFBFOKMHBAM
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(1995886936411817354uL)]
[SingletonComponent]
public struct IGGJBJEODLP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public GKBHPNNJDNK BKBIHBBELGJ;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7F476E0", Offset = "0x7F464E0", VA = "0x187F476E0")]
	public bool HFBFIIEDCGP(JILKJKBOAGA BFDMBBGBMDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7F476F0", Offset = "0x7F464F0", VA = "0x187F476F0")]
	public bool NEIMKBOCPEB(JILKJKBOAGA BFDMBBGBMDF, GKBHPNNJDNK DCEFBBJFEKL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[Flags]
public enum MAKDGGIPJCL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(12096894998449299302uL)]
public struct ELMIKCMLNOA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public MAKDGGIPJCL PMGANKPPAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public bool PNPFHMNIODF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool BINGIECKDIP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7F46750", Offset = "0x7F45550", VA = "0x187F46750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7F467A0", Offset = "0x7F455A0", VA = "0x187F467A0")]
	private ELMIKCMLNOA(MAKDGGIPJCL PMGANKPPAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7F46760", Offset = "0x7F45560", VA = "0x187F46760")]
	public ELMIKCMLNOA NMDEMLKELEM(MAKDGGIPJCL JBPEFHNHACL)
	{
		return default(ELMIKCMLNOA);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7F46780", Offset = "0x7F45580", VA = "0x187F46780")]
	public ELMIKCMLNOA OGNJODLLOCJ(MAKDGGIPJCL GKOJBGJFCDD)
	{
		return default(ELMIKCMLNOA);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
[TypeManager.ForcedStableTypeHash(3210980466644930997uL)]
public struct PDKIABNLJFC : IComponentData
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
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public Entity entity;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[TypeManager.ForcedStableTypeHash(2308769520679974324uL)]
public struct BPHCAOLACFK : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Entity MBIOGBHEOMJ;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[InternalBufferCapacity(8)]
	[TypeManager.ForcedStableTypeHash(2803523268494646145uL)]
	public struct ChildBuffer : IBufferElementData, IEquatable<ChildBuffer>, GEMOGKGJOPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7F45EA0", Offset = "0x7F44CA0", VA = "0x187F45EA0", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xCA1030", Offset = "0xC9FE30", VA = "0x180CA1030")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6734819606313844273uL)]
public struct DEGANNGEJNI : ISystemStateBufferElementData, IBufferElementData, GEMOGKGJOPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public Entity OFJKELIPJNP;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Entity LMKJAAFDABE
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[TypeManager.ForcedStableTypeHash(10606242260416974827uL)]
public struct ELNIICHPHIN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public Entity HMENLJLLCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Entity OFEJMIPLMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public Entity HCELEKIGLIG;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct DAKAEIOEDEC<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly bool JOCIPIGBAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public uint CCFCIEDDINO;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool PNEHGAAIPBI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[TypeManager.ForcedStableTypeHash(14518013333183728344uL)]
[TypeManager.TypeVersion(2)]
public struct NEGCPPNACKE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public uint DIPFNMIIGIM;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x12EC4E0", Offset = "0x12EB2E0", VA = "0x1812EC4E0")]
	public NEGCPPNACKE(LAFPBLKJNNP LEBLPDLNOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7F47DE0", Offset = "0x7F46BE0", VA = "0x187F47DE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1ECE1B0", Offset = "0x1ECCFB0", VA = "0x181ECE1B0")]
	public static NEGCPPNACKE HEKJAOMNHLJ(LAFPBLKJNNP LEBLPDLNOOO)
	{
		return default(NEGCPPNACKE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[TypeManager.ForcedStableTypeHash(12631852336897389638uL)]
public struct MLAACAHKGOD : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Entity OFJKELIPJNP;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[TypeManager.ForcedStableTypeHash(8586426759787957142uL)]
public struct LLDCDDICJCC : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public LAFPBLKJNNP OAIIHELJHLG;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[TypeManager.ForcedStableTypeHash(3916218676170013300uL)]
public struct HCNBJNKMOAK : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Entity OFJKELIPJNP;
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[TypeManager.ForcedStableTypeHash(3395423174463894753uL)]
public struct KLLACFABMLN : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Guid PDFBNFKDLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public int ALFGNAHPKIG;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[TypeManager.ForcedStableTypeHash(13485578171010875955uL)]
public struct IEDHEIMLLFI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public int OAIIHELJHLG;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[TypeManager.ForcedStableTypeHash(11182407275731589027uL)]
public struct IPDENDDNGHO : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public Entity OFJKELIPJNP;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[TypeManager.ForcedStableTypeHash(238571310055566811uL)]
public struct HINKKNILEJL : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public LAFPBLKJNNP OAIIHELJHLG;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[TypeManager.ForcedStableTypeHash(17943708062286791581uL)]
public struct HOCHACNDBDG : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public Entity OFJKELIPJNP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
[TypeManager.ForcedStableTypeHash(17717774548790709874uL)]
public struct KPFMDEBALGB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(1628423395607207516uL)]
public struct DBOOKFLLLDJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int FHLACDFMOGO;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[TypeManager.ForcedStableTypeHash(6255673600552782006uL)]
public struct FMACCDDKHKM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public int LCALHIDHIGO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HMJDCIMFIOA PFOPKNGJLID
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA55A60", Offset = "0xA54860", VA = "0x180A55A60")]
		get
		{
			return default(HMJDCIMFIOA);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[TypeManager.ForcedStableTypeHash(7921165883083593916uL)]
public struct IFBEKLPHHOE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public GCHandle EMGALCFIMKK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
[TypeManager.ForcedStableTypeHash(14965811366685608319uL)]
public struct ELJPNJADPKN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
[TypeManager.ForcedStableTypeHash(8376615066990205632uL)]
public struct KELHMDDHOKI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
[TypeManager.ForcedStableTypeHash(7273320061473429398uL)]
public struct FGGFDOAOFHI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
[TypeManager.ForcedStableTypeHash(15140206241145976177uL)]
public struct AFJDHHCAGDJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000039")]
[TypeManager.ForcedStableTypeHash(15969631250552901108uL)]
public struct CLHJDFNPMKE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[TypeManager.ForcedStableTypeHash(9353178840587053763uL)]
public struct GPEPCKNLCNJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public int GLAOLHCPLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public int MFIBIFPFGCD;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7F46C40", Offset = "0x7F45A40", VA = "0x187F46C40")]
	public GPEPCKNLCNJ(Entity OFJKELIPJNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[TypeManager.ForcedStableTypeHash(16229383422209788655uL)]
public struct FIPPMJKGILI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public CollisionDetectionMode KHFKPKHLOIH;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[TypeManager.ForcedStableTypeHash(5173865590150727846uL)]
[RegisterComponentDefault]
public struct EBINDBJDNFK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public MOCFDENFFJA CGGDCHHAEHC;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly EBINDBJDNFK OOIHKAJEMOK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003D")]
[TypeManager.ForcedStableTypeHash(7051356195299730219uL)]
public struct NKOBDJBECOF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003E")]
[TypeManager.ForcedStableTypeHash(780557526766205634uL)]
public struct JGMFEIPMKEL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003F")]
[TypeManager.ForcedStableTypeHash(16413322458062516985uL)]
public struct GCFFNBMAAKG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[TypeManager.ForcedStableTypeHash(8350832327674051347uL)]
[InternalBufferCapacity(0)]
public struct PDGJNEDJNBJ : IBufferElementData, IEquatable<PDGJNEDJNBJ>, GEMOGKGJOPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Entity OBOFPKCKJOC;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity INFCOBGALBD
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7F45EA0", Offset = "0x7F44CA0", VA = "0x187F45EA0", Slot = "4")]
	public bool Equals(PDGJNEDJNBJ HBLONCAMFLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[TypeManager.ForcedStableTypeHash(3503423083784418805uL)]
public struct NIPEIJECPLG : IComponentData, GEMOGKGJOPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Entity BOGJJGPKPIJ;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Entity INFCOBGALBD
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000042")]
[TypeManager.ForcedStableTypeHash(14551834985136520975uL)]
public struct BOCBKMBDCGJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[TypeManager.ForcedStableTypeHash(4388378139562737487uL)]
public struct EDFJHJGKNKB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Entity IPCOMOHMNHK;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct NDGKGAPCMOM : IOAANAKHIMO, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public LEAOBEHEHNM PFBMALFMIMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(LEAOBEHEHNM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[TypeManager.ForcedStableTypeHash(769086036388751339uL)]
public struct CFBJKFMBBMM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public float3 BJKCDGABEDH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
[TypeManager.ForcedStableTypeHash(15638082890667179775uL)]
public struct OOPHPCEAGMA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(7040629969868025973uL)]
public struct LHNAECOLFKO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public float3x3 AHJDHJIPGEH;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly LHNAECOLFKO OOIHKAJEMOK;
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(1290915447730818204uL)]
public struct IEMGJLAEMDH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float3x3 AHJDHJIPGEH;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly IEMGJLAEMDH OOIHKAJEMOK;
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[TypeManager.ForcedStableTypeHash(7667208078276643555uL)]
public struct DIEKLBGPMOL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public float3 JKHDNGOFDAG;
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[TypeManager.ForcedStableTypeHash(11475279934298573286uL)]
public struct IDJNHKFIMJH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public float3 PJAHIMCPCBP;
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(18413785019621221410uL)]
public struct KKFCBKOEELI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public float HKHKIFKKHAM;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly KKFCBKOEELI OOIHKAJEMOK;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(16788150452972582455uL)]
public struct FKDGNDGHFDC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public float NADMIGILEFJ;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly FKDGNDGHFDC OOIHKAJEMOK;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[TypeManager.ForcedStableTypeHash(971312552983123380uL)]
public struct JEBKNGIJNDN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public float3 NLHEABDFAJA;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[TypeManager.ForcedStableTypeHash(361641396811542242uL)]
public struct AAAKPPPLECE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public JFLNIIIFAEP GHLLJKOAGBP;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[TypeManager.ForcedStableTypeHash(7520974846918069913uL)]
[SingletonComponent]
public struct FCJHNBLCIBI : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Entity OFJKELIPJNP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
[TypeManager.ForcedStableTypeHash(9260549625364734686uL)]
public struct OGJHPNNONGC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
[TypeManager.ForcedStableTypeHash(469905343419662571uL)]
public struct OJONMBMDBJP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[TypeManager.ForcedStableTypeHash(7865784707562564105uL)]
public struct LBAMDFBPGLD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public RigidbodyConstraints JLLEEMLPJAH;
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(7877027338327956319uL)]
public struct PDOBIFDHOAC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public float ABGFEBJEBMA;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly PDOBIFDHOAC OOIHKAJEMOK;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[TypeManager.ForcedStableTypeHash(935406425377786813uL)]
public struct AOKIMCJBGKP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public float LBCDGKAHFJP;
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class AFLCBCENJIP : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public GameObject MMMAEDGEACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public object HFNBKDBKMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public object FHDLHGCLAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public AOMONGPLOBA DNCCNJDOKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Delegate LLECLIOIDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public Delegate OMJFIBMMHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public HIMKNIEIOHE<Delegate> EDBOIHKIDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public HIMKNIEIOHE<Delegate> CKNIAEAHIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public HIMKNIEIOHE<Delegate> CACLFBMPJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public HIMKNIEIOHE<Delegate> OKPAOKLLPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public HIMKNIEIOHE<Delegate> BDAMMMHHHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public HIMKNIEIOHE<Delegate> BODMLPEHGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public HIMKNIEIOHE<Delegate> CDGLFNJADCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public HIMKNIEIOHE<Delegate> MBNCAAHBEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public HIMKNIEIOHE<Delegate> JFKNBAMGLKE;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7F459B0", Offset = "0x7F447B0", VA = "0x187F459B0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public AFLCBCENJIP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
[TypeManager.ForcedStableTypeHash(18165447863202358792uL)]
public struct HGMFJEHIKEA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[TypeManager.ForcedStableTypeHash(10810926406358250264uL)]
public struct CICOAAMIEDF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public int HHDPAPLCKKF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1ECE1B0", Offset = "0x1ECCFB0", VA = "0x181ECE1B0")]
	public static CICOAAMIEDF HEKJAOMNHLJ(int OAIIHELJHLG)
	{
		return default(CICOAAMIEDF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class HKCHHNKGLBC : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Rigidbody HDAOKPJKILI;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7F46E30", Offset = "0x7F45C30", VA = "0x187F46E30", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public HKCHHNKGLBC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
[TypeManager.ForcedStableTypeHash(12765569839950265583uL)]
public struct MMGCFIPFDKC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[TypeManager.ForcedStableTypeHash(17236748096909814533uL)]
public struct MOBPOOKBPEJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float3 MFGCBODNMPM;
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[TypeManager.ForcedStableTypeHash(1288392478539867023uL)]
public struct NNMNPDPEPJC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float3 GPBPHJJLKFP;
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(15102898512288820575uL)]
public struct PJIACJOIFDJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float OGJIMPJBAGB;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public static readonly PJIACJOIFDJ OOIHKAJEMOK;
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class GHKLIHMPJFN : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public object EOFPPFPJPIP;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7F46AF0", Offset = "0x7F458F0", VA = "0x187F46AF0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public GHKLIHMPJFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class PPEFBKNIHFK : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public object LICODPAFPMH;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7F484C0", Offset = "0x7F472C0", VA = "0x187F484C0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public PPEFBKNIHFK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
[TypeManager.ForcedStableTypeHash(3505189951659289292uL)]
public struct HKDOOJHENHM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
[TypeManager.ForcedStableTypeHash(16217323095468023009uL)]
public struct AJLLPFOGCEM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
[TypeManager.ForcedStableTypeHash(12880717127246424414uL)]
public struct ECGBLKHDEDA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[TypeManager.ForcedStableTypeHash(12942629461400744171uL)]
public struct PFCDPKBINOC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
[TypeManager.ForcedStableTypeHash(10226241216405964379uL)]
public struct JFBAJGMEHPP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
[TypeManager.ForcedStableTypeHash(12400259538654257671uL)]
public struct OHMMHAHIKBK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
[TypeManager.ForcedStableTypeHash(12731949941800560397uL)]
public struct GIKOHMNEMIO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
[TypeManager.ForcedStableTypeHash(16270799832065682331uL)]
public struct OGAKIMOEKPE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
[TypeManager.ForcedStableTypeHash(9395080039644288849uL)]
public struct FNAIAHKIDIB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[TypeManager.ForcedStableTypeHash(282623311697096978uL)]
public struct KHLKNGMFLJO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public ECFMGHLFIHK DLJDIONABKD;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7F47940", Offset = "0x7F46740", VA = "0x187F47940", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
[TypeManager.ForcedStableTypeHash(10395819776101408141uL)]
public struct MFMFIFJJKDA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
[TypeManager.ForcedStableTypeHash(375953524326549120uL)]
public struct FHNNNHPDACE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
[TypeManager.ForcedStableTypeHash(14259779488802476986uL)]
public struct DOPIADHBNJI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[TypeManager.ForcedStableTypeHash(15330221065042235480uL)]
public struct OGEJONHBLJL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public FixedString32Bytes IHGFMOMOADA;
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(5162925656869367991uL)]
public struct HOHMANIMIDE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public UnsafeParallelHashMap<ECFMGHLFIHK, Entity> FCIIFNNMLKG;
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[TypeManager.ForcedStableTypeHash(9841032716800521808uL)]
public struct OBDNADGGANP : ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Entity NDFEOJPNLHD;
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[TypeManager.ForcedStableTypeHash(154813247653871879uL)]
internal struct HDPLJGHNFHI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Entity OFJKELIPJNP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xCA1030", Offset = "0xC9FE30", VA = "0x180CA1030")]
	public static HDPLJGHNFHI HEKJAOMNHLJ(Entity OFJKELIPJNP)
	{
		return default(HDPLJGHNFHI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[TypeManager.ForcedStableTypeHash(11656653634719673845uL)]
public struct MONCECGCOMH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity IDCAMJCEJMG;
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[TypeManager.ForcedStableTypeHash(1837719173092935466uL)]
public struct AIHKHMANFPO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Entity IDCAMJCEJMG;
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[TypeManager.ForcedStableTypeHash(17382237360022739174uL)]
internal struct LMEHELFPHKC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Entity DDBFPLKBAKL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xCA1030", Offset = "0xC9FE30", VA = "0x180CA1030")]
	public static LMEHELFPHKC HEKJAOMNHLJ(Entity OFJKELIPJNP)
	{
		return default(LMEHELFPHKC);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
[TypeManager.ForcedStableTypeHash(15858722173278118533uL)]
internal struct HBKLJICGMPO : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[TypeManager.ForcedStableTypeHash(10313790595830381076uL)]
public struct HCILLLNFIIN : IBufferElementData, IEquatable<HCILLLNFIIN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Entity KIIFAMCKEIC;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7D4AE00", Offset = "0x7D49C00", VA = "0x187D4AE00", Slot = "4")]
	public bool Equals(HCILLLNFIIN HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7F46C50", Offset = "0x7F45A50", VA = "0x187F46C50", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xA55A60", Offset = "0xA54860", VA = "0x180A55A60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[TypeManager.ForcedStableTypeHash(10169361040328370708uL)]
public struct DLHKMEOMOGB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public uint MFIBIFPFGCD;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(11536226225076729790uL)]
internal struct ADLKGHOFDBL : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Entity PPNONDAGEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public int GLAOLHCPLLG;
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[TypeManager.ForcedStableTypeHash(8309037880064337491uL)]
internal struct GGDOHLKFHIL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public Entity GLOHLOECDHC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
[TypeManager.ForcedStableTypeHash(5891816987223099091uL)]
public struct OAJABLOILOH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[TypeManager.ForcedStableTypeHash(17289298604600812224uL)]
public struct AKCNJLNDKNI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public uint CCFCIEDDINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public int CJJEHFGCLNJ;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xD5BDF0", Offset = "0xD5ABF0", VA = "0x180D5BDF0")]
	public AKCNJLNDKNI(uint PLIONFPCPEM, int BCPPBMHBDHF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
[TypeManager.ForcedStableTypeHash(12258100538258701401uL)]
public struct OLKHHEMKNCD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
[TypeManager.ForcedStableTypeHash(3081870877980445988uL)]
public struct OHFKAFLNKMA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
[TypeManager.ForcedStableTypeHash(15554741495161407507uL)]
public struct GHGCHELODNG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
[TypeManager.ForcedStableTypeHash(17684057078056878475uL)]
public struct HEFNLFINBLM : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
[TypeManager.ForcedStableTypeHash(10023455309444528896uL)]
public struct KCOEMCHAJOM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
[TypeManager.ForcedStableTypeHash(14403752119546393228uL)]
public struct KOHPPFGHNNK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
[TypeManager.ForcedStableTypeHash(9219181242087356214uL)]
public struct PAMIDKFKNMK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
[TypeManager.ForcedStableTypeHash(12371658133244024718uL)]
public struct FBIJLMOHGMM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
[TypeManager.ForcedStableTypeHash(9351414359236295489uL)]
public struct ADFENJIGLFL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
[TypeManager.ForcedStableTypeHash(12796707860320869007uL)]
internal struct MMKNHBOLKBE : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
[TypeManager.ForcedStableTypeHash(13367368557807690484uL)]
public struct LMHOBPMHIHH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000085")]
[TypeManager.ForcedStableTypeHash(7193071459223094579uL)]
public struct MILNDJAMHJP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
[TypeManager.ForcedStableTypeHash(15247343901949961769uL)]
public struct DNCBOPEOFNM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
[TypeManager.ForcedStableTypeHash(5381043565870728787uL)]
public struct LEFJLFPGCEG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
[TypeManager.ForcedStableTypeHash(11597028615900234104uL)]
internal struct KDBPDLOBLIB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
[TypeManager.ForcedStableTypeHash(1907494159895213433uL)]
internal struct NOLNGFGNODO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
[TypeManager.ForcedStableTypeHash(3955886960983597628uL)]
public struct JBJOCFLMDGK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
[TypeManager.ForcedStableTypeHash(480620745253244652uL)]
public struct KHNAPFCBDDM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008C")]
[TypeManager.ForcedStableTypeHash(8253675824478287824uL)]
public struct LCALPDGLNNB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
[TypeManager.ForcedStableTypeHash(8855488771047251567uL)]
public struct NFAEFEKEMAK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008E")]
[TypeManager.ForcedStableTypeHash(8375777954271012995uL)]
public struct GBGHKHHDBFB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
[TypeManager.ForcedStableTypeHash(16444804027614993581uL)]
public struct GCMNFIBHCNG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
[TypeManager.ForcedStableTypeHash(16177323740107409537uL)]
public struct EEBCFBBPCKD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
[TypeManager.ForcedStableTypeHash(11049752089067741804uL)]
public struct MNBALJPGLOP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000092")]
[TypeManager.ForcedStableTypeHash(1453937769327886583uL)]
public struct LJANOFHFCBB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000093")]
[TypeManager.ForcedStableTypeHash(800754555681830909uL)]
public struct DLLFICOBJKD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000094")]
[TypeManager.ForcedStableTypeHash(3336901602667819150uL)]
public struct ACKEINDNBEJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000095")]
[TypeManager.ForcedStableTypeHash(11809750536411032401uL)]
public struct NOMKFKDLGFP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000096")]
[TypeManager.ForcedStableTypeHash(6387004770090400669uL)]
public struct JOHFLEEFBIK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
[TypeManager.ForcedStableTypeHash(2223159712203397538uL)]
internal struct KIIMGMHNDNB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000098")]
[TypeManager.ForcedStableTypeHash(10153397523300334327uL)]
public struct NAFBGOKDLBC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000099")]
[TypeManager.ForcedStableTypeHash(12983102201306073842uL)]
public struct BIKCBAJNJMG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
[ALMDCCEBCCP]
[TypeManager.ForcedStableTypeHash(15398959433761599914uL)]
public struct PEGIGHEGKAA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[TypeManager.ForcedStableTypeHash(6605318152550716456uL)]
[SingletonComponent]
public struct JNPIDAGPFHP : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public FixedString32Bytes EHKJLJIDDFP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
[TypeManager.ForcedStableTypeHash(10065634662848845784uL)]
public struct IKKFEHMCJAF : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009D")]
[TypeManager.ForcedStableTypeHash(15062299176839263439uL)]
public struct FCCLKFMBBCH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009E")]
[TypeManager.ForcedStableTypeHash(3596269116834888123uL)]
internal struct HHCHGLKNEFM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
[TypeManager.ForcedStableTypeHash(4402941654898007496uL)]
internal struct EIGDGLJLKLF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[TypeManager.ForcedStableTypeHash(12682474121528142025uL)]
internal struct DOAOOMNMEJH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[TypeManager.ForcedStableTypeHash(1840266485562743455uL)]
public struct DHMCDCHCALF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[TypeManager.ForcedStableTypeHash(4772574226205567794uL)]
public struct EJEHFBICHKE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[TypeManager.ForcedStableTypeHash(17642911464827038147uL)]
public struct NKMKJJOMLMC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public quaternion LJIHJJKHDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float3 NPJPCFKLMHD;
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[TypeManager.ForcedStableTypeHash(9066921186040058989uL)]
public struct NHHIIEDJMNL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float KKIFEKBNEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float MFCCHGGPJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public float HHACFCFCHEO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[TypeManager.ForcedStableTypeHash(3328998613642473514uL)]
public struct AEFOJOOHJMA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[TypeManager.ForcedStableTypeHash(151116349382904900uL)]
public struct LBJONDPDABM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[TypeManager.ForcedStableTypeHash(8067675582152570601uL)]
public struct MHCGPIAHGCM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[TypeManager.ForcedStableTypeHash(4522686316477281096uL)]
public struct CPBKFILOOON : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public int LCALHIDHIGO;
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6216404920432680992uL)]
public struct CPFKOFDDBGL : ISystemStateBufferElementData, IBufferElementData, GEMOGKGJOPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Entity FCFFBGOAPEH;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity LMKJAAFDABE
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(419884688393735449uL)]
public struct CCBLFPDLJPG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public float4x4 IANLPDCIKEF;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly CCBLFPDLJPG OOIHKAJEMOK;
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(1954795745923300919uL)]
public struct LKCBAGLKPMM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public float4x4 CNDMPNPBLND;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly LKCBAGLKPMM OOIHKAJEMOK;
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[TypeManager.ForcedStableTypeHash(2447627752265109178uL)]
public struct DDMBJNADHJC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private int PKMNLJJGJKA;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int GLAOLHCPLLG
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7F46640", Offset = "0x7F45440", VA = "0x187F46640")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7F46630", Offset = "0x7F45430", VA = "0x187F46630")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(13706996280046618062uL)]
public struct OMIFLDKFCDD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public float3 NPJPCFKLMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public quaternion LJIHJJKHDDH;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly OMIFLDKFCDD OOIHKAJEMOK;
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public static class GODBHGMAFDA
{
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(77694943841979493uL)]
public struct OILIDPBKBGL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public float JINABHIJEMD;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public static readonly OILIDPBKBGL OOIHKAJEMOK;
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[TypeManager.ForcedStableTypeHash(6537711325103434903uL)]
public struct IPKPLIPJGKO : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public Entity NNLLPHNMAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public FMPIAKEFFMI OEFNLALAAAN;
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[TypeManager.ForcedStableTypeHash(5471640964865828061uL)]
public struct DDJCDOMAPOB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public FMPIAKEFFMI OEFNLALAAAN;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[TypeManager.ForcedStableTypeHash(16527934868211432802uL)]
public struct AAPLCPLNMPA : ISystemStateComponentData, IComponentData, GEMOGKGJOPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Entity EALBMDJEHIA;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Entity LMKJAAFDABE
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[TypeManager.ForcedStableTypeHash(15310407062508355916uL)]
public struct HHFBPLLCNGP : ISystemStateBufferElementData, IBufferElementData, GEMOGKGJOPM, IEquatable<HHFBPLLCNGP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Entity IDGMIOOPAON;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Entity LMKJAAFDABE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7D4AE00", Offset = "0x7D49C00", VA = "0x187D4AE00", Slot = "6")]
	public bool Equals(HHFBPLLCNGP HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7F46DA0", Offset = "0x7F45BA0", VA = "0x187F46DA0", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xA55A60", Offset = "0xA54860", VA = "0x180A55A60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[TypeManager.ForcedStableTypeHash(11786768220100978132uL)]
public struct JBFHMLCKMFA : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public Entity NNLLPHNMAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public FMPIAKEFFMI OEFNLALAAAN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public struct BOGGACKIKOA : IEqualityComparer<JBFHMLCKMFA>
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public static BOGGACKIKOA OOIHKAJEMOK;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7F45EB0", Offset = "0x7F44CB0", VA = "0x187F45EB0", Slot = "4")]
	public bool Equals(JBFHMLCKMFA AJEEBBBAOKG, JBFHMLCKMFA GJPKMHAOJHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7F45F00", Offset = "0x7F44D00", VA = "0x187F45F00", Slot = "5")]
	public int GetHashCode(JBFHMLCKMFA GLEBGNJJOHG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[TypeManager.ForcedStableTypeHash(8981997360983277121uL)]
public struct IMCBHDMDKDH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public FixedList32Bytes<int> FIAMKOAPKNO;
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[TypeManager.ForcedStableTypeHash(2801212869002544047uL)]
public struct IBAAJCCHHNP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public FixedList32Bytes<int> FIAMKOAPKNO;
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[TypeManager.ForcedStableTypeHash(16455485691096333919uL)]
public struct LGPLPGEBLKD : ISystemStateBufferElementData, IBufferElementData, GEMOGKGJOPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public Entity KKHEONDFJOF;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Entity INFCOBGALBD
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5A800", VA = "0x180D5BA00", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xF0D610", Offset = "0xF0C410", VA = "0x180F0D610", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal class PBOMKBAOJHC : ContainerPropertyBag<APEHBGPMCHP>
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private class CPNDIIMEMAO : Property<APEHBGPMCHP, ABKBGPGDIAJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string KHKODDKNOBC
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7F465A0", Offset = "0x7F453A0", VA = "0x187F465A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool LHOLHNBADAD
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7F46560", Offset = "0x7F45360", VA = "0x187F46560")]
		public CPNDIIMEMAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7F46510", Offset = "0x7F45310", VA = "0x187F46510", Slot = "14")]
		public override ABKBGPGDIAJ GetValue(APEHBGPMCHP AHGNCOFKLHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7F46530", Offset = "0x7F45330", VA = "0x187F46530", Slot = "15")]
		public override void SetValue(APEHBGPMCHP AHGNCOFKLHK, ABKBGPGDIAJ OAIIHELJHLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7F482A0", Offset = "0x7F470A0", VA = "0x187F482A0")]
	public PBOMKBAOJHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal class IBNHPGCBDMI : ContainerPropertyBag<AFLCBCENJIP>
{
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	private class IKFHBAIAANB : Property<AFLCBCENJIP, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string KHKODDKNOBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x7F47810", Offset = "0x7F46610", VA = "0x187F47810", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool LHOLHNBADAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7F477D0", Offset = "0x7F465D0", VA = "0x187F477D0")]
		public IKFHBAIAANB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7F46510", Offset = "0x7F45310", VA = "0x187F46510", Slot = "14")]
		public override GameObject GetValue(AFLCBCENJIP AHGNCOFKLHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7F46530", Offset = "0x7F45330", VA = "0x187F46530", Slot = "15")]
		public override void SetValue(AFLCBCENJIP AHGNCOFKLHK, GameObject OAIIHELJHLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	private class AGJJBCDHDDP : Property<AFLCBCENJIP, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string KHKODDKNOBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7F45A90", Offset = "0x7F44890", VA = "0x187F45A90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool LHOLHNBADAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7F45A50", Offset = "0x7F44850", VA = "0x187F45A50")]
		public AGJJBCDHDDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7F45A00", Offset = "0x7F44800", VA = "0x187F45A00", Slot = "14")]
		public override object GetValue(AFLCBCENJIP AHGNCOFKLHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7F45A20", Offset = "0x7F44820", VA = "0x187F45A20", Slot = "15")]
		public override void SetValue(AFLCBCENJIP AHGNCOFKLHK, object OAIIHELJHLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	private class HGGMBEMPJAA : Property<AFLCBCENJIP, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string KHKODDKNOBC
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7F46D70", Offset = "0x7F45B70", VA = "0x187F46D70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool LHOLHNBADAD
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7F46D30", Offset = "0x7F45B30", VA = "0x187F46D30")]
		public HGGMBEMPJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7F46CE0", Offset = "0x7F45AE0", VA = "0x187F46CE0", Slot = "14")]
		public override object GetValue(AFLCBCENJIP AHGNCOFKLHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7F46D00", Offset = "0x7F45B00", VA = "0x187F46D00", Slot = "15")]
		public override void SetValue(AFLCBCENJIP AHGNCOFKLHK, object OAIIHELJHLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private class LLHAHCGJBLE : Property<AFLCBCENJIP, AOMONGPLOBA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string KHKODDKNOBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x7F47CD0", Offset = "0x7F46AD0", VA = "0x187F47CD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool LHOLHNBADAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7F47C90", Offset = "0x7F46A90", VA = "0x187F47C90")]
		public LLHAHCGJBLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7F47C40", Offset = "0x7F46A40", VA = "0x187F47C40", Slot = "14")]
		public override AOMONGPLOBA GetValue(AFLCBCENJIP AHGNCOFKLHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7F47C60", Offset = "0x7F46A60", VA = "0x187F47C60", Slot = "15")]
		public override void SetValue(AFLCBCENJIP AHGNCOFKLHK, AOMONGPLOBA OAIIHELJHLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private class LBCIGECPBHC : Property<AFLCBCENJIP, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string KHKODDKNOBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7F47A60", Offset = "0x7F46860", VA = "0x187F47A60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool LHOLHNBADAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7F47A20", Offset = "0x7F46820", VA = "0x187F47A20")]
		public LBCIGECPBHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7F479D0", Offset = "0x7F467D0", VA = "0x187F479D0", Slot = "14")]
		public override Delegate GetValue(AFLCBCENJIP AHGNCOFKLHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7F479F0", Offset = "0x7F467F0", VA = "0x187F479F0", Slot = "15")]
		public override void SetValue(AFLCBCENJIP AHGNCOFKLHK, Delegate OAIIHELJHLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private class FLFPEIKOKLF : Property<AFLCBCENJIP, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string KHKODDKNOBC
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7F46970", Offset = "0x7F45770", VA = "0x187F46970", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool LHOLHNBADAD
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7F46930", Offset = "0x7F45730", VA = "0x187F46930")]
		public FLFPEIKOKLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7F468E0", Offset = "0x7F456E0", VA = "0x187F468E0", Slot = "14")]
		public override Delegate GetValue(AFLCBCENJIP AHGNCOFKLHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7F46900", Offset = "0x7F45700", VA = "0x187F46900", Slot = "15")]
		public override void SetValue(AFLCBCENJIP AHGNCOFKLHK, Delegate OAIIHELJHLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private class DHPLNKHPFCL : Property<AFLCBCENJIP, HIMKNIEIOHE<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string KHKODDKNOBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7F466E0", Offset = "0x7F454E0", VA = "0x187F466E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool LHOLHNBADAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7F466A0", Offset = "0x7F454A0", VA = "0x187F466A0")]
		public DHPLNKHPFCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7F46650", Offset = "0x7F45450", VA = "0x187F46650", Slot = "14")]
		public override HIMKNIEIOHE<Delegate> GetValue(AFLCBCENJIP AHGNCOFKLHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7F46670", Offset = "0x7F45470", VA = "0x187F46670", Slot = "15")]
		public override void SetValue(AFLCBCENJIP AHGNCOFKLHK, HIMKNIEIOHE<Delegate> OAIIHELJHLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private class OHACHGOBGMO : Property<AFLCBCENJIP, HIMKNIEIOHE<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string KHKODDKNOBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x7F48100", Offset = "0x7F46F00", VA = "0x187F48100", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool LHOLHNBADAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7F480C0", Offset = "0x7F46EC0", VA = "0x187F480C0")]
		public OHACHGOBGMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7F48070", Offset = "0x7F46E70", VA = "0x187F48070", Slot = "14")]
		public override HIMKNIEIOHE<Delegate> GetValue(AFLCBCENJIP AHGNCOFKLHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7F48090", Offset = "0x7F46E90", VA = "0x187F48090", Slot = "15")]
		public override void SetValue(AFLCBCENJIP AHGNCOFKLHK, HIMKNIEIOHE<Delegate> OAIIHELJHLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private class BPDFHLJONOB : Property<AFLCBCENJIP, HIMKNIEIOHE<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string KHKODDKNOBC
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7F45FF0", Offset = "0x7F44DF0", VA = "0x187F45FF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool LHOLHNBADAD
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7F45FB0", Offset = "0x7F44DB0", VA = "0x187F45FB0")]
		public BPDFHLJONOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7F45F60", Offset = "0x7F44D60", VA = "0x187F45F60", Slot = "14")]
		public override HIMKNIEIOHE<Delegate> GetValue(AFLCBCENJIP AHGNCOFKLHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7F45F80", Offset = "0x7F44D80", VA = "0x187F45F80", Slot = "15")]
		public override void SetValue(AFLCBCENJIP AHGNCOFKLHK, HIMKNIEIOHE<Delegate> OAIIHELJHLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private class PMOEJJDNICC : Property<AFLCBCENJIP, HIMKNIEIOHE<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string KHKODDKNOBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x7F48490", Offset = "0x7F47290", VA = "0x187F48490", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool LHOLHNBADAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7F48450", Offset = "0x7F47250", VA = "0x187F48450")]
		public PMOEJJDNICC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7F48400", Offset = "0x7F47200", VA = "0x187F48400", Slot = "14")]
		public override HIMKNIEIOHE<Delegate> GetValue(AFLCBCENJIP AHGNCOFKLHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7F48420", Offset = "0x7F47220", VA = "0x187F48420", Slot = "15")]
		public override void SetValue(AFLCBCENJIP AHGNCOFKLHK, HIMKNIEIOHE<Delegate> OAIIHELJHLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	private class CDEMINMPNPI : Property<AFLCBCENJIP, HIMKNIEIOHE<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string KHKODDKNOBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x7F46160", Offset = "0x7F44F60", VA = "0x187F46160", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool LHOLHNBADAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7F46120", Offset = "0x7F44F20", VA = "0x187F46120")]
		public CDEMINMPNPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7F460D0", Offset = "0x7F44ED0", VA = "0x187F460D0", Slot = "14")]
		public override HIMKNIEIOHE<Delegate> GetValue(AFLCBCENJIP AHGNCOFKLHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7F460F0", Offset = "0x7F44EF0", VA = "0x187F460F0", Slot = "15")]
		public override void SetValue(AFLCBCENJIP AHGNCOFKLHK, HIMKNIEIOHE<Delegate> OAIIHELJHLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	private class ABJCGCPIBHI : Property<AFLCBCENJIP, HIMKNIEIOHE<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string KHKODDKNOBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x7F45930", Offset = "0x7F44730", VA = "0x187F45930", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool LHOLHNBADAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7F458F0", Offset = "0x7F446F0", VA = "0x187F458F0")]
		public ABJCGCPIBHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7F458A0", Offset = "0x7F446A0", VA = "0x187F458A0", Slot = "14")]
		public override HIMKNIEIOHE<Delegate> GetValue(AFLCBCENJIP AHGNCOFKLHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7F458C0", Offset = "0x7F446C0", VA = "0x187F458C0", Slot = "15")]
		public override void SetValue(AFLCBCENJIP AHGNCOFKLHK, HIMKNIEIOHE<Delegate> OAIIHELJHLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	private class IJIFJJFKAMA : Property<AFLCBCENJIP, HIMKNIEIOHE<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string KHKODDKNOBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7F477A0", Offset = "0x7F465A0", VA = "0x187F477A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool LHOLHNBADAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7F47760", Offset = "0x7F46560", VA = "0x187F47760")]
		public IJIFJJFKAMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7F47710", Offset = "0x7F46510", VA = "0x187F47710", Slot = "14")]
		public override HIMKNIEIOHE<Delegate> GetValue(AFLCBCENJIP AHGNCOFKLHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7F47730", Offset = "0x7F46530", VA = "0x187F47730", Slot = "15")]
		public override void SetValue(AFLCBCENJIP AHGNCOFKLHK, HIMKNIEIOHE<Delegate> OAIIHELJHLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	private class NHGBNKIHNDA : Property<AFLCBCENJIP, HIMKNIEIOHE<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string KHKODDKNOBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7F47EA0", Offset = "0x7F46CA0", VA = "0x187F47EA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool LHOLHNBADAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7F47E60", Offset = "0x7F46C60", VA = "0x187F47E60")]
		public NHGBNKIHNDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7F47E10", Offset = "0x7F46C10", VA = "0x187F47E10", Slot = "14")]
		public override HIMKNIEIOHE<Delegate> GetValue(AFLCBCENJIP AHGNCOFKLHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7F47E30", Offset = "0x7F46C30", VA = "0x187F47E30", Slot = "15")]
		public override void SetValue(AFLCBCENJIP AHGNCOFKLHK, HIMKNIEIOHE<Delegate> OAIIHELJHLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	private class NHIGCGALADF : Property<AFLCBCENJIP, HIMKNIEIOHE<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string KHKODDKNOBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7F47F60", Offset = "0x7F46D60", VA = "0x187F47F60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool LHOLHNBADAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7F47F20", Offset = "0x7F46D20", VA = "0x187F47F20")]
		public NHIGCGALADF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7F47ED0", Offset = "0x7F46CD0", VA = "0x187F47ED0", Slot = "14")]
		public override HIMKNIEIOHE<Delegate> GetValue(AFLCBCENJIP AHGNCOFKLHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7F47EF0", Offset = "0x7F46CF0", VA = "0x187F47EF0", Slot = "15")]
		public override void SetValue(AFLCBCENJIP AHGNCOFKLHK, HIMKNIEIOHE<Delegate> OAIIHELJHLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7F46F80", Offset = "0x7F45D80", VA = "0x187F46F80")]
	public IBNHPGCBDMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal class DBJLMBPPLPA : ContainerPropertyBag<HIMKNIEIOHE<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7F465D0", Offset = "0x7F453D0", VA = "0x187F465D0")]
	public DBJLMBPPLPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal class MDAGEMIAMIN : ContainerPropertyBag<HKCHHNKGLBC>
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	private class HLHDHNAEOLG : Property<HKCHHNKGLBC, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string KHKODDKNOBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7F46F50", Offset = "0x7F45D50", VA = "0x187F46F50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool LHOLHNBADAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7F46F10", Offset = "0x7F45D10", VA = "0x187F46F10")]
		public HLHDHNAEOLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7F46510", Offset = "0x7F45310", VA = "0x187F46510", Slot = "14")]
		public override Rigidbody GetValue(HKCHHNKGLBC AHGNCOFKLHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7F46530", Offset = "0x7F45330", VA = "0x187F46530", Slot = "15")]
		public override void SetValue(HKCHHNKGLBC AHGNCOFKLHK, Rigidbody OAIIHELJHLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7F47D00", Offset = "0x7F46B00", VA = "0x187F47D00")]
	public MDAGEMIAMIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal class GIKJKHEPNFD : ContainerPropertyBag<GHKLIHMPJFN>
{
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	private class HLHCJAADHAJ : Property<GHKLIHMPJFN, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string KHKODDKNOBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x7F46EE0", Offset = "0x7F45CE0", VA = "0x187F46EE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool LHOLHNBADAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7F46EA0", Offset = "0x7F45CA0", VA = "0x187F46EA0")]
		public HLHCJAADHAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7F46510", Offset = "0x7F45310", VA = "0x187F46510", Slot = "14")]
		public override object GetValue(GHKLIHMPJFN AHGNCOFKLHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7F46530", Offset = "0x7F45330", VA = "0x187F46530", Slot = "15")]
		public override void SetValue(GHKLIHMPJFN AHGNCOFKLHK, object OAIIHELJHLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7F46B60", Offset = "0x7F45960", VA = "0x187F46B60")]
	public GIKJKHEPNFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal class GGLHOPBEMKO : ContainerPropertyBag<PPEFBKNIHFK>
{
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	private class FMLOAAFDCII : Property<PPEFBKNIHFK, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string KHKODDKNOBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x7F469E0", Offset = "0x7F457E0", VA = "0x187F469E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool LHOLHNBADAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7F469A0", Offset = "0x7F457A0", VA = "0x187F469A0")]
		public FMLOAAFDCII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7F46510", Offset = "0x7F45310", VA = "0x187F46510", Slot = "14")]
		public override object GetValue(PPEFBKNIHFK AHGNCOFKLHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7F46530", Offset = "0x7F45330", VA = "0x187F46530", Slot = "15")]
		public override void SetValue(PPEFBKNIHFK AHGNCOFKLHK, object OAIIHELJHLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7F46A10", Offset = "0x7F45810", VA = "0x187F46A10")]
	public GGLHOPBEMKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal class OGLJAJJHBFH : ContainerPropertyBag<OBDNADGGANP>
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	private class FBHMBPICPNP : Property<OBDNADGGANP, Entity>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string KHKODDKNOBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7F46800", Offset = "0x7F45600", VA = "0x187F46800", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool LHOLHNBADAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7F467C0", Offset = "0x7F455C0", VA = "0x187F467C0")]
		public FBHMBPICPNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA88A40", Offset = "0xA87840", VA = "0x180A88A40", Slot = "14")]
		public override Entity GetValue(OBDNADGGANP AHGNCOFKLHK)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7F467B0", Offset = "0x7F455B0", VA = "0x187F467B0", Slot = "15")]
		public override void SetValue(OBDNADGGANP AHGNCOFKLHK, Entity OAIIHELJHLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7F47F90", Offset = "0x7F46D90", VA = "0x187F47F90")]
	public OGLJAJJHBFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class CKFPIDHEDIO : ContainerPropertyBag<Entity>
{
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	private class FKECINGHPCE : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string KHKODDKNOBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x7F468B0", Offset = "0x7F456B0", VA = "0x187F468B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool LHOLHNBADAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7F46870", Offset = "0x7F45670", VA = "0x187F46870")]
		public FKECINGHPCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x21E85F0", Offset = "0x21E73F0", VA = "0x1821E85F0", Slot = "14")]
		public override int GetValue(Entity AHGNCOFKLHK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7D46300", Offset = "0x7D45100", VA = "0x187D46300", Slot = "15")]
		public override void SetValue(Entity AHGNCOFKLHK, int OAIIHELJHLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	private class KGEGKPKPMGE : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string KHKODDKNOBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x7F47910", Offset = "0x7F46710", VA = "0x187F47910", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool LHOLHNBADAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7F478D0", Offset = "0x7F466D0", VA = "0x187F478D0")]
		public KGEGKPKPMGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xF1DD80", Offset = "0xF1CB80", VA = "0x180F1DD80", Slot = "14")]
		public override int GetValue(Entity AHGNCOFKLHK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7F478C0", Offset = "0x7F466C0", VA = "0x187F478C0", Slot = "15")]
		public override void SetValue(Entity AHGNCOFKLHK, int OAIIHELJHLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7F463D0", Offset = "0x7F451D0", VA = "0x187F463D0")]
	public CKFPIDHEDIO()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7F48530", Offset = "0x7F47330", VA = "0x187F48530")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public class KAMDLADCGCG
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public KAMDLADCGCG()
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
