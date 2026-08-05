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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EF9740", Offset = "0x7EF8140", VA = "0x187EF9740", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7EF9AD0", Offset = "0x7EF84D0", VA = "0x187EF9AD0", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2796C60", Offset = "0x2795660", VA = "0x182796C60")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
[TypeManager.ForcedStableTypeHash(1586941204353847852uL)]
public struct AAHJDLHMILL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
[TypeManager.ForcedStableTypeHash(1730701010008160003uL)]
public struct JEBJPIOECIB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
[TypeManager.ForcedStableTypeHash(3399609037308777919uL)]
public struct NFBLKIOMMPP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
[TypeManager.ForcedStableTypeHash(18083619841998483100uL)]
public struct EDOIOCGFDLF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
[TypeManager.ForcedStableTypeHash(12361415346715948123uL)]
public struct CJHGFBFCNEN : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[InternalBufferCapacity(8)]
	[TypeManager.ForcedStableTypeHash(15820941866177188261uL)]
	public struct AuthoredChildBuffer : IBufferElementData, IEquatable<AuthoredChildBuffer>, FKOILGKDFCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7EF6890", Offset = "0x7EF5290", VA = "0x187EF6890", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD0DC80", Offset = "0xD0C680", VA = "0x180D0DC80")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
[TypeManager.ForcedStableTypeHash(7794731847884836165uL)]
public struct CEKPDCDJNFB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
[TypeManager.ForcedStableTypeHash(16414266906034106824uL)]
public struct BIIKPLNCJON : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[TypeManager.ForcedStableTypeHash(1525018888797798356uL)]
public struct BGDJHIGGEFM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Entity FLJIKDFJCMC;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[TypeManager.ForcedStableTypeHash(6294257411443737851uL)]
public struct OMLJKMONAND : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity FLJIKDFJCMC;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct FFBAEFODIMO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<JBCHALCPPGE> GADNMOBPPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<Entity> NKNHPCDBDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private JobHandle IGNDKHDOGPP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool OGNPMGIBCLC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7EF7590", Offset = "0x7EF5F90", VA = "0x187EF7590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int IMMMMMEPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7EF74E0", Offset = "0x7EF5EE0", VA = "0x187EF74E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5D41340", Offset = "0x5D3FD40", VA = "0x185D41340")]
	public FFBAEFODIMO(NativeList<JBCHALCPPGE> GADNMOBPPDC, NativeList<Entity> NKNHPCDBDJH, JobHandle IGNDKHDOGPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7600", Offset = "0x7EF6000", VA = "0x187EF7600")]
	public (Entity, NativeSlice<Entity>) JNMBDACFHPA(int LFGCGKOHNIA)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7530", Offset = "0x7EF5F30", VA = "0x187EF7530", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct JBCHALCPPGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Entity ALPBGLGCPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int BACDJHJBLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int EIJGIDNMHGP;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KMILEGDAIEA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HKKHPNEMOAD(bool KAPMBAHKLJL);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct AAJIJBMDHCM : IEquatable<AAJIJBMDHCM>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate bool IFCGGONKEGG(int NIHHJEGJCCB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly bool CDANBDMIMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool ICOMFKCCDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool PPBOPBHAFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool DKNBHMPIJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly IFCGGONKEGG EHHGKHMJHMM;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7EF66E0", Offset = "0x7EF50E0", VA = "0x187EF66E0")]
	public AAJIJBMDHCM(JEMODOMIDJB FIKPCOCNDHE, IFCGGONKEGG EHHGKHMJHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6730", Offset = "0x7EF5130", VA = "0x187EF6730")]
	public AAJIJBMDHCM(bool CDANBDMIMKL, bool ICOMFKCCDFN, bool PPBOPBHAFBB, bool DKNBHMPIJOG, IFCGGONKEGG EHHGKHMJHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7EF65D0", Offset = "0x7EF4FD0", VA = "0x187EF65D0")]
	public bool LFJFEGJGKEI(int NIHHJEGJCCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7EF65A0", Offset = "0x7EF4FA0", VA = "0x187EF65A0")]
	public bool JBKNAEEEAKM(int NIHHJEGJCCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6570", Offset = "0x7EF4F70", VA = "0x187EF6570")]
	public bool HJMLLLKHDLC(int NIHHJEGJCCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6620", Offset = "0x7EF5020", VA = "0x187EF6620")]
	public bool ONMPJHNBPNO(int NIHHJEGJCCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7EF63F0", Offset = "0x7EF4DF0", VA = "0x187EF63F0", Slot = "4")]
	public bool Equals(AAJIJBMDHCM NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6420", Offset = "0x7EF4E20", VA = "0x187EF6420", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7EF64D0", Offset = "0x7EF4ED0", VA = "0x187EF64D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6600", Offset = "0x7EF5000", VA = "0x187EF6600")]
	private bool LMEDEOKBECI(int NIHHJEGJCCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6650", Offset = "0x7EF5050", VA = "0x187EF6650", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class LEFIFNLHGKE : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public EAIPDLDMFMI INMLGCAAFGI;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7EF81F0", Offset = "0x7EF6BF0", VA = "0x187EF81F0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public LEFIFNLHGKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface EAIPDLDMFMI
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000016")]
[TypeManager.ForcedStableTypeHash(1690080301203719739uL)]
public struct LHHGEDOBMEG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[TypeManager.ForcedStableTypeHash(13667964378929084748uL)]
public readonly struct FGDPOFKNEED : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly BFNELAPAKGN JCKGNLCHIIB;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2F98C40", Offset = "0x2F97640", VA = "0x182F98C40")]
	public FGDPOFKNEED(BFNELAPAKGN JCKGNLCHIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7730", Offset = "0x7EF6130", VA = "0x187EF7730")]
	public FGDPOFKNEED OPNHLJPIJOL(BFNELAPAKGN FPHMFJGPDNG)
	{
		return default(FGDPOFKNEED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7720", Offset = "0x7EF6120", VA = "0x187EF7720")]
	public FGDPOFKNEED HNMJLNBNOGF(BFNELAPAKGN HJMCIMOGCLJ)
	{
		return default(FGDPOFKNEED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7740", Offset = "0x7EF6140", VA = "0x187EF7740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[Flags]
public enum BFNELAPAKGN : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	HasShapeChildren = 1,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	HasEmbodiedChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	HasColliders = 4,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	HasObjectBoard = 8,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	HasUserTags = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	IsInScope = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	IsScopeRoot = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	IsRootObject = 0x80,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	TestEmbodiment = 0x100,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	ReferredToByGroup = 0x200,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	All = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class GHEMENEOCFH
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(1995886936411817354uL)]
public struct GIOJPLJOGGE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public BFNELAPAKGN BAMKAKLMMFP;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7EF79B0", Offset = "0x7EF63B0", VA = "0x187EF79B0")]
	public bool GOIOGNPEOPP(FGDPOFKNEED PCFOJAEKGIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7990", Offset = "0x7EF6390", VA = "0x187EF7990")]
	public bool DGGJCKKAKIO(FGDPOFKNEED PCFOJAEKGIP, BFNELAPAKGN KGAELOEODGI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Flags]
public enum PKMHOEADGIA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(12096894998449299302uL)]
public struct DHIGJFJNOMN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public PKMHOEADGIA JCKGNLCHIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool PEDFICGDDCA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool OIJEIIHBGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7EF6F90", Offset = "0x7EF5990", VA = "0x187EF6F90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6FE0", Offset = "0x7EF59E0", VA = "0x187EF6FE0")]
	private DHIGJFJNOMN(PKMHOEADGIA JCKGNLCHIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6FC0", Offset = "0x7EF59C0", VA = "0x187EF6FC0")]
	public DHIGJFJNOMN OPNHLJPIJOL(PKMHOEADGIA FPHMFJGPDNG)
	{
		return default(DHIGJFJNOMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6FA0", Offset = "0x7EF59A0", VA = "0x187EF6FA0")]
	public DHIGJFJNOMN HNMJLNBNOGF(PKMHOEADGIA HJMCIMOGCLJ)
	{
		return default(DHIGJFJNOMN);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
[TypeManager.ForcedStableTypeHash(3210980466644930997uL)]
public struct ECIPIKLEIPE : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[InternalBufferCapacity(1)]
	[TypeManager.ForcedStableTypeHash(8887160633523457935uL)]
	public struct NetworkedEntityBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public Entity entity;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(2308769520679974324uL)]
public struct GCHIACBIGMC : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Entity MILFBKNNLKN;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[TypeManager.ForcedStableTypeHash(2803523268494646145uL)]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : IBufferElementData, IEquatable<ChildBuffer>, FKOILGKDFCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7EF6890", Offset = "0x7EF5290", VA = "0x187EF6890", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD0DC80", Offset = "0xD0C680", VA = "0x180D0DC80")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[TypeManager.ForcedStableTypeHash(6734819606313844273uL)]
[SingletonComponent]
public struct CLOIFGJLAED : ISystemStateBufferElementData, IBufferElementData, FKOILGKDFCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Entity FCFDGFFMMDF;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Entity JAJKMDFDFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[TypeManager.ForcedStableTypeHash(10606242260416974827uL)]
public struct ADAABKAMECJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public Entity CDKNDMJAGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public Entity NGMPELCCNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public Entity DHOEELMNJAP;
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct HLMNEFDBHIK<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static readonly bool HBILGBNKLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public uint PGNKCJDOKDF;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	private static bool MLLHGNHMBCB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[TypeManager.ForcedStableTypeHash(14518013333183728344uL)]
[TypeManager.TypeVersion(2)]
public struct ECAMLCIDMLN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public uint PKNKKCEBIPH;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x13EB010", Offset = "0x13E9A10", VA = "0x1813EB010")]
	public ECAMLCIDMLN(ADLHINHFEDA ABAEHPFNLLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7EF71F0", Offset = "0x7EF5BF0", VA = "0x187EF71F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB340", Offset = "0x1FC9D40", VA = "0x181FCB340")]
	public static ECAMLCIDMLN HNONLACFBHP(ADLHINHFEDA ABAEHPFNLLE)
	{
		return default(ECAMLCIDMLN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[TypeManager.ForcedStableTypeHash(12631852336897389638uL)]
public struct BBPIDHNJHDM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Entity FCFDGFFMMDF;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[TypeManager.ForcedStableTypeHash(8586426759787957142uL)]
public struct MJJHFFMHLHL : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public ADLHINHFEDA PCDAHJCDHHF;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[TypeManager.ForcedStableTypeHash(3916218676170013300uL)]
public struct PMDAMCJEDPG : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Entity FCFDGFFMMDF;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[TypeManager.ForcedStableTypeHash(3395423174463894753uL)]
public struct HJINKODAGJB : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Guid FNKCCICOAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public int IMCIONKBBCL;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[TypeManager.ForcedStableTypeHash(13485578171010875955uL)]
public struct IOBPLGCOLNO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int PCDAHJCDHHF;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[TypeManager.ForcedStableTypeHash(11182407275731589027uL)]
public struct LJOPPCOALCF : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Entity FCFDGFFMMDF;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[TypeManager.ForcedStableTypeHash(238571310055566811uL)]
public struct EJFCGFHPCMH : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public ADLHINHFEDA PCDAHJCDHHF;
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[TypeManager.ForcedStableTypeHash(17943708062286791581uL)]
public struct BAMCCIJJONL : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public Entity FCFDGFFMMDF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
[TypeManager.ForcedStableTypeHash(17717774548790709874uL)]
public struct BPDFOCBAGBD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[TypeManager.ForcedStableTypeHash(1628423395607207516uL)]
[SingletonComponent]
public struct CIALBNHHJLI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int OBGAOBEFDPD;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[TypeManager.ForcedStableTypeHash(6255673600552782006uL)]
public struct OLLBHPBBFEA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int BJBHFAMODGO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public PGNMDKGFDBN KOGGOBOPADB
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xBB5930", Offset = "0xBB4330", VA = "0x180BB5930")]
		get
		{
			return default(PGNMDKGFDBN);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[TypeManager.ForcedStableTypeHash(7921165883083593916uL)]
public struct EPKFJNNELBG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public GCHandle MENCFAOEOAB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
[TypeManager.ForcedStableTypeHash(14965811366685608319uL)]
public struct EJOHOECMJJM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000032")]
[TypeManager.ForcedStableTypeHash(8376615066990205632uL)]
public struct EIINCLANAOG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000033")]
[TypeManager.ForcedStableTypeHash(7273320061473429398uL)]
public struct GMAKGJEIGPO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
[TypeManager.ForcedStableTypeHash(15140206241145976177uL)]
public struct AAOCMFCGKLG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
[TypeManager.ForcedStableTypeHash(15969631250552901108uL)]
public struct HMGLJEGICEI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[TypeManager.ForcedStableTypeHash(9353178840587053763uL)]
public struct DEIJOLIADHC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public int MNFHMLCLFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public int GPMAOGCPKOA;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6F80", Offset = "0x7EF5980", VA = "0x187EF6F80")]
	public DEIJOLIADHC(Entity FCFDGFFMMDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[TypeManager.ForcedStableTypeHash(16229383422209788655uL)]
public struct ABFMDDIKHKA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public CollisionDetectionMode HDHHAEAPENK;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(5173865590150727846uL)]
public struct NACCJAKIDGO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public AMDCJLIPDMO DJGBEOCJNLB;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly NACCJAKIDGO MCHDAMDLAPK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000039")]
[TypeManager.ForcedStableTypeHash(7051356195299730219uL)]
public struct KPCAPJFAMND : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
[TypeManager.ForcedStableTypeHash(780557526766205634uL)]
public struct NDMILBCFAJA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003B")]
[TypeManager.ForcedStableTypeHash(16413322458062516985uL)]
public struct DDPAAICOMOK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[InternalBufferCapacity(0)]
[TypeManager.ForcedStableTypeHash(8350832327674051347uL)]
public struct DHHDDHFOJIH : IBufferElementData, IEquatable<DHHDDHFOJIH>, FKOILGKDFCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Entity GBGDJHDAECJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Entity BCPNPGPBEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6890", Offset = "0x7EF5290", VA = "0x187EF6890", Slot = "4")]
	public bool Equals(DHHDDHFOJIH NDNHELJMDCG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[TypeManager.ForcedStableTypeHash(3503423083784418805uL)]
public struct CGKENGCDODM : IComponentData, FKOILGKDFCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Entity EAGGHBKHKHF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity BCPNPGPBEGD
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003E")]
[TypeManager.ForcedStableTypeHash(14551834985136520975uL)]
public struct PNDKNJNDBEM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[TypeManager.ForcedStableTypeHash(4388378139562737487uL)]
public struct NKFDNHNHOJC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Entity ALPBGLGCPNB;
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct AHGGCFKDINK : MMGDHABHMMF, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IDLHGOBNGLO CCGKKINMCDA
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(IDLHGOBNGLO);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[TypeManager.ForcedStableTypeHash(769086036388751339uL)]
public struct HPMDOMLGNLE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public float3 JFDJDOPNINB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000042")]
[TypeManager.ForcedStableTypeHash(15638082890667179775uL)]
public struct BIHKCNNINEM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(7040629969868025973uL)]
public struct BMPJHHCGGKA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float3x3 OPOGJDDMJEI;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly BMPJHHCGGKA MCHDAMDLAPK;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[TypeManager.ForcedStableTypeHash(1290915447730818204uL)]
[RegisterComponentDefault]
public struct KLCPKCBGNJG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public float3x3 OPOGJDDMJEI;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly KLCPKCBGNJG MCHDAMDLAPK;
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[TypeManager.ForcedStableTypeHash(7667208078276643555uL)]
public struct IPOGEAKMNPK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float3 IJMKMFMGPMH;
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[TypeManager.ForcedStableTypeHash(11475279934298573286uL)]
public struct BJDBLNCMLEO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float3 MNOHLHDDEIL;
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(18413785019621221410uL)]
public struct JCKMLEDJLFE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public float ILBLNIBNLKD;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly JCKMLEDJLFE MCHDAMDLAPK;
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(16788150452972582455uL)]
public struct HCLKEDJELMG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public float GEINHDPPGIL;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly HCLKEDJELMG MCHDAMDLAPK;
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[TypeManager.ForcedStableTypeHash(971312552983123380uL)]
public struct IACGGAPNEGB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public float3 BCOJONMDENG;
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[TypeManager.ForcedStableTypeHash(361641396811542242uL)]
public struct PDCPIDLKHJK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public DLKLAKEEKHP GOMCGOABOEM;
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(7520974846918069913uL)]
public struct CMGIOFHINPO : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public Entity FCFDGFFMMDF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004C")]
[TypeManager.ForcedStableTypeHash(9260549625364734686uL)]
public struct JCMKBNDFAJO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
[TypeManager.ForcedStableTypeHash(469905343419662571uL)]
public struct BPEHEEDOJAO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[TypeManager.ForcedStableTypeHash(7865784707562564105uL)]
public struct BBLLOMNFLMM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public RigidbodyConstraints NCCGHLDKGBC;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(7877027338327956319uL)]
public struct JACLHGDBPCB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public float FAKMAGJHOJC;

	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly JACLHGDBPCB MCHDAMDLAPK;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[TypeManager.ForcedStableTypeHash(935406425377786813uL)]
public struct NCHDACIOLFC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public float GBIPHNOKDIJ;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class OKHHFEECPNH : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public GameObject HNGFDIJGINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public object PDCPAHOHNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public object KFEFLKLOANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public AOOENPIJLCF GNNAFAGJBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public Delegate BCIMCPGPFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public Delegate OJLGLMNIJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public BBKFGDIALBG<Delegate> ECBFOCGBMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public BBKFGDIALBG<Delegate> PFMDFJJFCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public BBKFGDIALBG<Delegate> JIDILEHIFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public BBKFGDIALBG<Delegate> AICFACMCAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public BBKFGDIALBG<Delegate> KBBBHPMBMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public BBKFGDIALBG<Delegate> AHJCDLODOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public BBKFGDIALBG<Delegate> HMHIJNDGAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public BBKFGDIALBG<Delegate> CKFNEJADDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public BBKFGDIALBG<Delegate> HPLFMHGLDOC;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8EE0", Offset = "0x7EF78E0", VA = "0x187EF8EE0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public OKHHFEECPNH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
[TypeManager.ForcedStableTypeHash(18165447863202358792uL)]
public struct PCGKBHGHGIE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[TypeManager.ForcedStableTypeHash(10810926406358250264uL)]
public struct DCCBPHBJBLH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public int BHAKNOADKEH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1FCB340", Offset = "0x1FC9D40", VA = "0x181FCB340")]
	public static DCCBPHBJBLH HNONLACFBHP(int PCDAHJCDHHF)
	{
		return default(DCCBPHBJBLH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class PBCNIBDNANH : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Rigidbody FADODMKCMLG;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8FA0", Offset = "0x7EF79A0", VA = "0x187EF8FA0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public PBCNIBDNANH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
[TypeManager.ForcedStableTypeHash(12765569839950265583uL)]
public struct NAPAHPACPPP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[TypeManager.ForcedStableTypeHash(17236748096909814533uL)]
public struct MMGLONKJDKK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float3 DGGOMONDOHM;
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[TypeManager.ForcedStableTypeHash(1288392478539867023uL)]
public struct CEKDEAKEEAG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 CGGOJBPICAG;
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(15102898512288820575uL)]
public struct OIBKMMHLMDL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float KBEANDGBNDE;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public static readonly OIBKMMHLMDL MCHDAMDLAPK;
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class OLOJBBBBODD : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public object CAIINGBLIIC;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8F30", Offset = "0x7EF7930", VA = "0x187EF8F30", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public OLOJBBBBODD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class AFGBFDKJPMO : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public object IBBDNJNKHPM;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6760", Offset = "0x7EF5160", VA = "0x187EF6760", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public AFGBFDKJPMO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
[TypeManager.ForcedStableTypeHash(3505189951659289292uL)]
public struct BDCMJGJMICH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
[TypeManager.ForcedStableTypeHash(16217323095468023009uL)]
public struct DECCADHLOEP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
[TypeManager.ForcedStableTypeHash(12880717127246424414uL)]
public struct NAOPOAMOKAN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
[TypeManager.ForcedStableTypeHash(12942629461400744171uL)]
public struct CKECCFEGGLF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
[TypeManager.ForcedStableTypeHash(10226241216405964379uL)]
public struct HIIOMOOONAA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
[TypeManager.ForcedStableTypeHash(12400259538654257671uL)]
public struct FDFNNPBBIEE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
[TypeManager.ForcedStableTypeHash(12731949941800560397uL)]
public struct MCEFEBDGHPI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[TypeManager.ForcedStableTypeHash(16270799832065682331uL)]
public struct PIMGKLAPBHB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
[TypeManager.ForcedStableTypeHash(9395080039644288849uL)]
public struct LLLJAEDGPOJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
[TypeManager.ForcedStableTypeHash(15229363233412980908uL)]
public struct KJDPNEBDGAA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[TypeManager.ForcedStableTypeHash(282623311697096978uL)]
public struct EMJJKMJJBEP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public IAIEGNHMFLD BNJDCEAGAEP;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7300", Offset = "0x7EF5D00", VA = "0x187EF7300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
[TypeManager.ForcedStableTypeHash(10395819776101408141uL)]
public struct AOIEJDDIFIE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
[TypeManager.ForcedStableTypeHash(375953524326549120uL)]
public struct JMNFCFCFDEL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
[TypeManager.ForcedStableTypeHash(14259779488802476986uL)]
public struct COALGEIEFAO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[TypeManager.ForcedStableTypeHash(15330221065042235480uL)]
public struct GDPMOILAFNO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public FixedString32Bytes GBCFHNGPBLM;
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(5162925656869367991uL)]
public struct ILKJGKJEOEG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public UnsafeParallelHashMap<IAIEGNHMFLD, Entity> PBIELCIHHIF;
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[TypeManager.ForcedStableTypeHash(9841032716800521808uL)]
public struct FDMBPGEGPKM : ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Entity ELCMGKAECHA;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[TypeManager.ForcedStableTypeHash(154813247653871879uL)]
internal struct MOHPOCPBGKH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Entity FCFDGFFMMDF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xD0DC80", Offset = "0xD0C680", VA = "0x180D0DC80")]
	public static MOHPOCPBGKH HNONLACFBHP(Entity FCFDGFFMMDF)
	{
		return default(MOHPOCPBGKH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[TypeManager.ForcedStableTypeHash(11656653634719673845uL)]
public struct HDCIFBGFDOJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Entity LMLNCBHIMKP;
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[TypeManager.ForcedStableTypeHash(1837719173092935466uL)]
public struct JPNOPCMGDFJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Entity LMLNCBHIMKP;
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[TypeManager.ForcedStableTypeHash(17382237360022739174uL)]
internal struct BIGAKOHIIOB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity FAHEDALNAJO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xD0DC80", Offset = "0xD0C680", VA = "0x180D0DC80")]
	public static BIGAKOHIIOB HNONLACFBHP(Entity FCFDGFFMMDF)
	{
		return default(BIGAKOHIIOB);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
[TypeManager.ForcedStableTypeHash(15858722173278118533uL)]
internal struct IDGEBKCBMLL : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[TypeManager.ForcedStableTypeHash(10313790595830381076uL)]
public struct GNGJIDGAOKI : IBufferElementData, IEquatable<GNGJIDGAOKI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Entity PBAFAOPJFCF;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7CF6550", Offset = "0x7CF4F50", VA = "0x187CF6550", Slot = "4")]
	public bool Equals(GNGJIDGAOKI NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7EF79C0", Offset = "0x7EF63C0", VA = "0x187EF79C0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xBB5930", Offset = "0xBB4330", VA = "0x180BB5930", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[TypeManager.ForcedStableTypeHash(10169361040328370708uL)]
public struct JGEDAPJMAAN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public uint GPMAOGCPKOA;
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[TypeManager.ForcedStableTypeHash(11536226225076729790uL)]
[SingletonComponent]
internal struct JJDEPJAIKEB : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Entity IIJMPJHDMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public int MNFHMLCLFEB;
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[TypeManager.ForcedStableTypeHash(8309037880064337491uL)]
internal struct HLKPGCBODFM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Entity DOOGFLKEMBP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
[TypeManager.ForcedStableTypeHash(5891816987223099091uL)]
public struct OAPOOINHCBE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[TypeManager.ForcedStableTypeHash(17289298604600812224uL)]
public struct JNJLPPOJNIL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public uint PGNKCJDOKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public int LGPFDPJBBJJ;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xDCDD90", Offset = "0xDCC790", VA = "0x180DCDD90")]
	public JNJLPPOJNIL(uint HNJOHODCGOE, int OFOILIIDNKF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
[TypeManager.ForcedStableTypeHash(12258100538258701401uL)]
public struct PONKEHAICNH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
[TypeManager.ForcedStableTypeHash(3081870877980445988uL)]
public struct GGCHFOODBNF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
[TypeManager.ForcedStableTypeHash(15554741495161407507uL)]
public struct DPHKGBAHEHH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
[TypeManager.ForcedStableTypeHash(17684057078056878475uL)]
public struct MIJOOBIABNG : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
[TypeManager.ForcedStableTypeHash(10023455309444528896uL)]
public struct NFHFCELLNEB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
[TypeManager.ForcedStableTypeHash(14403752119546393228uL)]
public struct KKLIKBKEPCH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
[TypeManager.ForcedStableTypeHash(9219181242087356214uL)]
public struct DLIIDFDHHPP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
[TypeManager.ForcedStableTypeHash(12371658133244024718uL)]
public struct GBEGIHCOMCA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
[TypeManager.ForcedStableTypeHash(9351414359236295489uL)]
public struct GJEBHMKPAFM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
[TypeManager.ForcedStableTypeHash(12796707860320869007uL)]
internal struct EKPBMMHCDFL : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
[TypeManager.ForcedStableTypeHash(13367368557807690484uL)]
public struct FIKIGNCHKIJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
[TypeManager.ForcedStableTypeHash(7193071459223094579uL)]
public struct GGFMIIGAEBN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
[TypeManager.ForcedStableTypeHash(17039127292426947163uL)]
public struct NOBLCNBMDPP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
[TypeManager.ForcedStableTypeHash(15247343901949961769uL)]
public struct KGNOOMDGGKA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000085")]
[TypeManager.ForcedStableTypeHash(5381043565870728787uL)]
public struct IEBAMLPLPLL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
[TypeManager.ForcedStableTypeHash(11597028615900234104uL)]
internal struct GGFKKLMNEOE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
[TypeManager.ForcedStableTypeHash(1907494159895213433uL)]
internal struct KHFIBNEIIGP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
[TypeManager.ForcedStableTypeHash(3955886960983597628uL)]
public struct CECAPKCENKL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
[TypeManager.ForcedStableTypeHash(480620745253244652uL)]
public struct PMEJCBCPNIK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
[TypeManager.ForcedStableTypeHash(8253675824478287824uL)]
public struct IPGHOLPAEPA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
[TypeManager.ForcedStableTypeHash(8855488771047251567uL)]
public struct OLPNBHFFJKP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008C")]
[TypeManager.ForcedStableTypeHash(8375777954271012995uL)]
public struct AIGKIMOLOBO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
[TypeManager.ForcedStableTypeHash(16444804027614993581uL)]
public struct FKJHFNPGJEB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008E")]
[TypeManager.ForcedStableTypeHash(16177323740107409537uL)]
public struct JKNDHPIGMKN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
[TypeManager.ForcedStableTypeHash(11049752089067741804uL)]
public struct MGMBMJAPBHN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
[TypeManager.ForcedStableTypeHash(1453937769327886583uL)]
public struct LODFPGAMGNP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
[TypeManager.ForcedStableTypeHash(800754555681830909uL)]
public struct OLNHJEGDMBH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000092")]
[TypeManager.ForcedStableTypeHash(3336901602667819150uL)]
public struct EOKGGNKNKLJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000093")]
[TypeManager.ForcedStableTypeHash(11809750536411032401uL)]
public struct ENNJCDMJEPB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000094")]
[TypeManager.ForcedStableTypeHash(6387004770090400669uL)]
public struct FPHEDFBBIMH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000095")]
[TypeManager.ForcedStableTypeHash(2223159712203397538uL)]
internal struct PCBDJHIGJAO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000096")]
[TypeManager.ForcedStableTypeHash(10153397523300334327uL)]
public struct LODBGEKCCAH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
[TypeManager.ForcedStableTypeHash(12983102201306073842uL)]
public struct HLJNMJGDDLI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000098")]
[ALPHDKFPCHI]
[TypeManager.ForcedStableTypeHash(15398959433761599914uL)]
public struct HMLINICFNIP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6605318152550716456uL)]
public struct PJCPMBKNJLI : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public FixedString32Bytes GBJOGAJJMBI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
[TypeManager.ForcedStableTypeHash(10065634662848845784uL)]
public struct ILLBJCHIDHG : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009B")]
[TypeManager.ForcedStableTypeHash(15062299176839263439uL)]
public struct CIJPLNJCCPH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
[TypeManager.ForcedStableTypeHash(3596269116834888123uL)]
internal struct IBCABBOGFFP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009D")]
[TypeManager.ForcedStableTypeHash(4402941654898007496uL)]
internal struct LKNGCHKADNL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009E")]
[TypeManager.ForcedStableTypeHash(12682474121528142025uL)]
internal struct ANHAHBGBENJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
[TypeManager.ForcedStableTypeHash(1840266485562743455uL)]
public struct KBPADADBPKN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[TypeManager.ForcedStableTypeHash(4772574226205567794uL)]
public struct PKCFBOOIFMM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[TypeManager.ForcedStableTypeHash(17642911464827038147uL)]
public struct HPCJKFBEPPL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public quaternion NGPACIMGGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float3 JFMEMBGKAOB;
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[TypeManager.ForcedStableTypeHash(9066921186040058989uL)]
public struct AKDEOAKCAPI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float MDKJAFELLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float FIBFKMOJBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float JIPHEINMAIM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[TypeManager.ForcedStableTypeHash(3328998613642473514uL)]
public struct BFBIPOIOFAM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[TypeManager.ForcedStableTypeHash(151116349382904900uL)]
public struct OLHABMCBIEI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[TypeManager.ForcedStableTypeHash(8067675582152570601uL)]
public struct LIGKCHOLACC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[TypeManager.ForcedStableTypeHash(4522686316477281096uL)]
public struct BLPOHBNDNEK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public int BJBHFAMODGO;
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[TypeManager.ForcedStableTypeHash(6216404920432680992uL)]
[SingletonComponent]
public struct KJMILDBCIIO : ISystemStateBufferElementData, IBufferElementData, FKOILGKDFCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Entity HLLAODLFFLE;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Entity JAJKMDFDFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(419884688393735449uL)]
public struct FBKOLKBFGDM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public float4x4 HFMGIOCPIIE;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly FBKOLKBFGDM MCHDAMDLAPK;
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(1954795745923300919uL)]
public struct MIOEGMOINOC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public float4x4 CGPCBMKHHCJ;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly MIOEGMOINOC MCHDAMDLAPK;
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[TypeManager.ForcedStableTypeHash(2447627752265109178uL)]
public struct MOLFAEIBCCI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private int FMMDNMNGMCF;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int MNFHMLCLFEB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7EF85A0", Offset = "0x7EF6FA0", VA = "0x187EF85A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7EF85B0", Offset = "0x7EF6FB0", VA = "0x187EF85B0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(13706996280046618062uL)]
public struct CGNDHMMJKFB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public float3 JFMEMBGKAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public quaternion NGPACIMGGNA;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly CGNDHMMJKFB MCHDAMDLAPK;
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class JLCOFNCPPGA
{
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(77694943841979493uL)]
public struct MHOHGNNJNCF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public float LDIEJMGKIFA;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly MHOHGNNJNCF MCHDAMDLAPK;
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[TypeManager.ForcedStableTypeHash(6537711325103434903uL)]
public struct BMOMEEEPOIN : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Entity AJEELMNCDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public HCMBDPHADFA GGGOHEOOHCH;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[TypeManager.ForcedStableTypeHash(5471640964865828061uL)]
public struct NACLAAKHCNO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public HCMBDPHADFA GGGOHEOOHCH;
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[TypeManager.ForcedStableTypeHash(16527934868211432802uL)]
public struct PPJCKEEFOMH : ISystemStateComponentData, IComponentData, FKOILGKDFCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Entity BBAFJLLBENK;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Entity JAJKMDFDFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[TypeManager.ForcedStableTypeHash(15310407062508355916uL)]
public struct LCMCMCJOKMO : ISystemStateBufferElementData, IBufferElementData, FKOILGKDFCL, IEquatable<LCMCMCJOKMO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Entity ALJNNFLEMMP;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Entity JAJKMDFDFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7CF6550", Offset = "0x7CF4F50", VA = "0x187CF6550", Slot = "6")]
	public bool Equals(LCMCMCJOKMO NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8080", Offset = "0x7EF6A80", VA = "0x187EF8080", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xBB5930", Offset = "0xBB4330", VA = "0x180BB5930", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[TypeManager.ForcedStableTypeHash(11786768220100978132uL)]
public struct DNCHAGMKAKP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Entity AJEELMNCDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public HCMBDPHADFA GGGOHEOOHCH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct KFIOIBNBMPI : IEqualityComparer<DNCHAGMKAKP>
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public static KFIOIBNBMPI MCHDAMDLAPK;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7E70", Offset = "0x7EF6870", VA = "0x187EF7E70", Slot = "4")]
	public bool Equals(DNCHAGMKAKP CBPCNABIALH, DNCHAGMKAKP CBOHEKOGGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7EC0", Offset = "0x7EF68C0", VA = "0x187EF7EC0", Slot = "5")]
	public int GetHashCode(DNCHAGMKAKP OJDHMKOBKLD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[TypeManager.ForcedStableTypeHash(8981997360983277121uL)]
public struct MOCOGPPDFAH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public FixedList32Bytes<int> FHMNFJFMOMK;
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[TypeManager.ForcedStableTypeHash(2801212869002544047uL)]
public struct KOJKPNPPPGA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public FixedList32Bytes<int> FHMNFJFMOMK;
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[TypeManager.ForcedStableTypeHash(16455485691096333919uL)]
public struct ODJNJABPLMP : ISystemStateBufferElementData, IBufferElementData, FKOILGKDFCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public Entity LBJOPOEBKNH;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private Entity BCPNPGPBEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA85B60", Offset = "0xA84560", VA = "0x180A85B60", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1290CD0", Offset = "0x128F6D0", VA = "0x181290CD0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
internal class BEJEDAHJBDA : ContainerPropertyBag<LEFIFNLHGKE>
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	private class FIIEBEDKOPP : Property<LEFIFNLHGKE, EAIPDLDMFMI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override string HMKINKIIOPK
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x7EF7830", Offset = "0x7EF6230", VA = "0x187EF7830", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override bool HDMPHDAENOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7EF77F0", Offset = "0x7EF61F0", VA = "0x187EF77F0")]
		public FIIEBEDKOPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7EF77A0", Offset = "0x7EF61A0", VA = "0x187EF77A0", Slot = "14")]
		public override EAIPDLDMFMI GetValue(LEFIFNLHGKE DJGDNAKMFCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7EF77C0", Offset = "0x7EF61C0", VA = "0x187EF77C0", Slot = "15")]
		public override void SetValue(LEFIFNLHGKE DJGDNAKMFCE, EAIPDLDMFMI PCDAHJCDHHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7EF68A0", Offset = "0x7EF52A0", VA = "0x187EF68A0")]
	public BEJEDAHJBDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal class OGKFBJFCHNP : ContainerPropertyBag<OKHHFEECPNH>
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private class KONCAFMMEGP : Property<OKHHFEECPNH, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override string HMKINKIIOPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x7EF8050", Offset = "0x7EF6A50", VA = "0x187EF8050", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override bool HDMPHDAENOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8010", Offset = "0x7EF6A10", VA = "0x187EF8010")]
		public KONCAFMMEGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7EF77A0", Offset = "0x7EF61A0", VA = "0x187EF77A0", Slot = "14")]
		public override GameObject GetValue(OKHHFEECPNH DJGDNAKMFCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7EF77C0", Offset = "0x7EF61C0", VA = "0x187EF77C0", Slot = "15")]
		public override void SetValue(OKHHFEECPNH DJGDNAKMFCE, GameObject PCDAHJCDHHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	private class JLNGNGDNJAE : Property<OKHHFEECPNH, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override string HMKINKIIOPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x7EF7E40", Offset = "0x7EF6840", VA = "0x187EF7E40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override bool HDMPHDAENOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7EF7E00", Offset = "0x7EF6800", VA = "0x187EF7E00")]
		public JLNGNGDNJAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7EF7DB0", Offset = "0x7EF67B0", VA = "0x187EF7DB0", Slot = "14")]
		public override object GetValue(OKHHFEECPNH DJGDNAKMFCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7EF7DD0", Offset = "0x7EF67D0", VA = "0x187EF7DD0", Slot = "15")]
		public override void SetValue(OKHHFEECPNH DJGDNAKMFCE, object PCDAHJCDHHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	private class OFPEJMBBDNC : Property<OKHHFEECPNH, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override string HMKINKIIOPK
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7EF8810", Offset = "0x7EF7210", VA = "0x187EF8810", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override bool HDMPHDAENOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7EF87D0", Offset = "0x7EF71D0", VA = "0x187EF87D0")]
		public OFPEJMBBDNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8780", Offset = "0x7EF7180", VA = "0x187EF8780", Slot = "14")]
		public override object GetValue(OKHHFEECPNH DJGDNAKMFCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7EF87A0", Offset = "0x7EF71A0", VA = "0x187EF87A0", Slot = "15")]
		public override void SetValue(OKHHFEECPNH DJGDNAKMFCE, object PCDAHJCDHHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	private class AMNJNONBBNI : Property<OKHHFEECPNH, AOOENPIJLCF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override string HMKINKIIOPK
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x7EF6860", Offset = "0x7EF5260", VA = "0x187EF6860", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override bool HDMPHDAENOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7EF6820", Offset = "0x7EF5220", VA = "0x187EF6820")]
		public AMNJNONBBNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7EF67D0", Offset = "0x7EF51D0", VA = "0x187EF67D0", Slot = "14")]
		public override AOOENPIJLCF GetValue(OKHHFEECPNH DJGDNAKMFCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7EF67F0", Offset = "0x7EF51F0", VA = "0x187EF67F0", Slot = "15")]
		public override void SetValue(OKHHFEECPNH DJGDNAKMFCE, AOOENPIJLCF PCDAHJCDHHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	private class BMAELFAMBFP : Property<OKHHFEECPNH, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override string HMKINKIIOPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x7EF6A10", Offset = "0x7EF5410", VA = "0x187EF6A10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool HDMPHDAENOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7EF69D0", Offset = "0x7EF53D0", VA = "0x187EF69D0")]
		public BMAELFAMBFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7EF6980", Offset = "0x7EF5380", VA = "0x187EF6980", Slot = "14")]
		public override Delegate GetValue(OKHHFEECPNH DJGDNAKMFCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7EF69A0", Offset = "0x7EF53A0", VA = "0x187EF69A0", Slot = "15")]
		public override void SetValue(OKHHFEECPNH DJGDNAKMFCE, Delegate PCDAHJCDHHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private class EBNGIGIMAFI : Property<OKHHFEECPNH, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override string HMKINKIIOPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x7EF71C0", Offset = "0x7EF5BC0", VA = "0x187EF71C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override bool HDMPHDAENOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7EF7180", Offset = "0x7EF5B80", VA = "0x187EF7180")]
		public EBNGIGIMAFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7EF7130", Offset = "0x7EF5B30", VA = "0x187EF7130", Slot = "14")]
		public override Delegate GetValue(OKHHFEECPNH DJGDNAKMFCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7EF7150", Offset = "0x7EF5B50", VA = "0x187EF7150", Slot = "15")]
		public override void SetValue(OKHHFEECPNH DJGDNAKMFCE, Delegate PCDAHJCDHHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private class IGJLAIKIENH : Property<OKHHFEECPNH, BBKFGDIALBG<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override string HMKINKIIOPK
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x7EF7C80", Offset = "0x7EF6680", VA = "0x187EF7C80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override bool HDMPHDAENOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7EF7C40", Offset = "0x7EF6640", VA = "0x187EF7C40")]
		public IGJLAIKIENH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7EF7BF0", Offset = "0x7EF65F0", VA = "0x187EF7BF0", Slot = "14")]
		public override BBKFGDIALBG<Delegate> GetValue(OKHHFEECPNH DJGDNAKMFCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7EF7C10", Offset = "0x7EF6610", VA = "0x187EF7C10", Slot = "15")]
		public override void SetValue(OKHHFEECPNH DJGDNAKMFCE, BBKFGDIALBG<Delegate> PCDAHJCDHHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private class GCKKCHPOLDC : Property<OKHHFEECPNH, BBKFGDIALBG<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override string HMKINKIIOPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7EF7960", Offset = "0x7EF6360", VA = "0x187EF7960", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override bool HDMPHDAENOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7EF7920", Offset = "0x7EF6320", VA = "0x187EF7920")]
		public GCKKCHPOLDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7EF78D0", Offset = "0x7EF62D0", VA = "0x187EF78D0", Slot = "14")]
		public override BBKFGDIALBG<Delegate> GetValue(OKHHFEECPNH DJGDNAKMFCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7EF78F0", Offset = "0x7EF62F0", VA = "0x187EF78F0", Slot = "15")]
		public override void SetValue(OKHHFEECPNH DJGDNAKMFCE, BBKFGDIALBG<Delegate> PCDAHJCDHHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private class CCCIPIBBLHA : Property<OKHHFEECPNH, BBKFGDIALBG<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override string HMKINKIIOPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x7EF6BC0", Offset = "0x7EF55C0", VA = "0x187EF6BC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override bool HDMPHDAENOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7EF6B80", Offset = "0x7EF5580", VA = "0x187EF6B80")]
		public CCCIPIBBLHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7EF6B30", Offset = "0x7EF5530", VA = "0x187EF6B30", Slot = "14")]
		public override BBKFGDIALBG<Delegate> GetValue(OKHHFEECPNH DJGDNAKMFCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7EF6B50", Offset = "0x7EF5550", VA = "0x187EF6B50", Slot = "15")]
		public override void SetValue(OKHHFEECPNH DJGDNAKMFCE, BBKFGDIALBG<Delegate> PCDAHJCDHHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private class NJJMOHJHDOF : Property<OKHHFEECPNH, BBKFGDIALBG<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override string HMKINKIIOPK
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7EF8690", Offset = "0x7EF7090", VA = "0x187EF8690", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override bool HDMPHDAENOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8650", Offset = "0x7EF7050", VA = "0x187EF8650")]
		public NJJMOHJHDOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8600", Offset = "0x7EF7000", VA = "0x187EF8600", Slot = "14")]
		public override BBKFGDIALBG<Delegate> GetValue(OKHHFEECPNH DJGDNAKMFCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8620", Offset = "0x7EF7020", VA = "0x187EF8620", Slot = "15")]
		public override void SetValue(OKHHFEECPNH DJGDNAKMFCE, BBKFGDIALBG<Delegate> PCDAHJCDHHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private class COHNEBAAMIF : Property<OKHHFEECPNH, BBKFGDIALBG<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override string HMKINKIIOPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x7EF6E90", Offset = "0x7EF5890", VA = "0x187EF6E90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override bool HDMPHDAENOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7EF6E50", Offset = "0x7EF5850", VA = "0x187EF6E50")]
		public COHNEBAAMIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7EF6E00", Offset = "0x7EF5800", VA = "0x187EF6E00", Slot = "14")]
		public override BBKFGDIALBG<Delegate> GetValue(OKHHFEECPNH DJGDNAKMFCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7EF6E20", Offset = "0x7EF5820", VA = "0x187EF6E20", Slot = "15")]
		public override void SetValue(OKHHFEECPNH DJGDNAKMFCE, BBKFGDIALBG<Delegate> PCDAHJCDHHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private class DCGKKINGJHO : Property<OKHHFEECPNH, BBKFGDIALBG<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override string HMKINKIIOPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x7EF6F50", Offset = "0x7EF5950", VA = "0x187EF6F50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override bool HDMPHDAENOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7EF6F10", Offset = "0x7EF5910", VA = "0x187EF6F10")]
		public DCGKKINGJHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7EF6EC0", Offset = "0x7EF58C0", VA = "0x187EF6EC0", Slot = "14")]
		public override BBKFGDIALBG<Delegate> GetValue(OKHHFEECPNH DJGDNAKMFCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7EF6EE0", Offset = "0x7EF58E0", VA = "0x187EF6EE0", Slot = "15")]
		public override void SetValue(OKHHFEECPNH DJGDNAKMFCE, BBKFGDIALBG<Delegate> PCDAHJCDHHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	private class LGPLKPIGCAL : Property<OKHHFEECPNH, BBKFGDIALBG<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override string HMKINKIIOPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x7EF82F0", Offset = "0x7EF6CF0", VA = "0x187EF82F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override bool HDMPHDAENOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7EF82B0", Offset = "0x7EF6CB0", VA = "0x187EF82B0")]
		public LGPLKPIGCAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8260", Offset = "0x7EF6C60", VA = "0x187EF8260", Slot = "14")]
		public override BBKFGDIALBG<Delegate> GetValue(OKHHFEECPNH DJGDNAKMFCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8280", Offset = "0x7EF6C80", VA = "0x187EF8280", Slot = "15")]
		public override void SetValue(OKHHFEECPNH DJGDNAKMFCE, BBKFGDIALBG<Delegate> PCDAHJCDHHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	private class NKEOODDMPME : Property<OKHHFEECPNH, BBKFGDIALBG<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override string HMKINKIIOPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x7EF8750", Offset = "0x7EF7150", VA = "0x187EF8750", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override bool HDMPHDAENOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8710", Offset = "0x7EF7110", VA = "0x187EF8710")]
		public NKEOODDMPME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7EF86C0", Offset = "0x7EF70C0", VA = "0x187EF86C0", Slot = "14")]
		public override BBKFGDIALBG<Delegate> GetValue(OKHHFEECPNH DJGDNAKMFCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7EF86E0", Offset = "0x7EF70E0", VA = "0x187EF86E0", Slot = "15")]
		public override void SetValue(OKHHFEECPNH DJGDNAKMFCE, BBKFGDIALBG<Delegate> PCDAHJCDHHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	private class LHPFBHEEFGL : Property<OKHHFEECPNH, BBKFGDIALBG<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override string HMKINKIIOPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x7EF83B0", Offset = "0x7EF6DB0", VA = "0x187EF83B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool HDMPHDAENOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8370", Offset = "0x7EF6D70", VA = "0x187EF8370")]
		public LHPFBHEEFGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8320", Offset = "0x7EF6D20", VA = "0x187EF8320", Slot = "14")]
		public override BBKFGDIALBG<Delegate> GetValue(OKHHFEECPNH DJGDNAKMFCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8340", Offset = "0x7EF6D40", VA = "0x187EF8340", Slot = "15")]
		public override void SetValue(OKHHFEECPNH DJGDNAKMFCE, BBKFGDIALBG<Delegate> PCDAHJCDHHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8840", Offset = "0x7EF7240", VA = "0x187EF8840")]
	public OGKFBJFCHNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal class LMIKBDLHFPP : ContainerPropertyBag<BBKFGDIALBG<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7EF83E0", Offset = "0x7EF6DE0", VA = "0x187EF83E0")]
	public LMIKBDLHFPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal class FCAAANBAAJO : ContainerPropertyBag<PBCNIBDNANH>
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	private class MNABODMGLGF : Property<PBCNIBDNANH, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override string HMKINKIIOPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7EF8570", Offset = "0x7EF6F70", VA = "0x187EF8570", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override bool HDMPHDAENOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8530", Offset = "0x7EF6F30", VA = "0x187EF8530")]
		public MNABODMGLGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7EF77A0", Offset = "0x7EF61A0", VA = "0x187EF77A0", Slot = "14")]
		public override Rigidbody GetValue(PBCNIBDNANH DJGDNAKMFCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7EF77C0", Offset = "0x7EF61C0", VA = "0x187EF77C0", Slot = "15")]
		public override void SetValue(PBCNIBDNANH DJGDNAKMFCE, Rigidbody PCDAHJCDHHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7400", Offset = "0x7EF5E00", VA = "0x187EF7400")]
	public FCAAANBAAJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal class EFMLJFEJDPK : ContainerPropertyBag<OLOJBBBBODD>
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	private class FOKKAGLPHMK : Property<OLOJBBBBODD, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override string HMKINKIIOPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x7EF78A0", Offset = "0x7EF62A0", VA = "0x187EF78A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override bool HDMPHDAENOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7EF7860", Offset = "0x7EF6260", VA = "0x187EF7860")]
		public FOKKAGLPHMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7EF77A0", Offset = "0x7EF61A0", VA = "0x187EF77A0", Slot = "14")]
		public override object GetValue(OLOJBBBBODD DJGDNAKMFCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7EF77C0", Offset = "0x7EF61C0", VA = "0x187EF77C0", Slot = "15")]
		public override void SetValue(OLOJBBBBODD DJGDNAKMFCE, object PCDAHJCDHHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7220", Offset = "0x7EF5C20", VA = "0x187EF7220")]
	public EFMLJFEJDPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal class CFCHLNGDFEI : ContainerPropertyBag<AFGBFDKJPMO>
{
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	private class LDABLKEHOIE : Property<AFGBFDKJPMO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override string HMKINKIIOPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x7EF8150", Offset = "0x7EF6B50", VA = "0x187EF8150", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override bool HDMPHDAENOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8110", Offset = "0x7EF6B10", VA = "0x187EF8110")]
		public LDABLKEHOIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7EF77A0", Offset = "0x7EF61A0", VA = "0x187EF77A0", Slot = "14")]
		public override object GetValue(AFGBFDKJPMO DJGDNAKMFCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7EF77C0", Offset = "0x7EF61C0", VA = "0x187EF77C0", Slot = "15")]
		public override void SetValue(AFGBFDKJPMO DJGDNAKMFCE, object PCDAHJCDHHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6BF0", Offset = "0x7EF55F0", VA = "0x187EF6BF0")]
	public CFCHLNGDFEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal class GPONGADCAJP : ContainerPropertyBag<FDMBPGEGPKM>
{
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	private class HKNCJPEHCLM : Property<FDMBPGEGPKM, Entity>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override string HMKINKIIOPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7EF7BC0", Offset = "0x7EF65C0", VA = "0x187EF7BC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override bool HDMPHDAENOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7EF7B80", Offset = "0x7EF6580", VA = "0x187EF7B80")]
		public HKNCJPEHCLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA71660", Offset = "0xA70060", VA = "0x180A71660", Slot = "14")]
		public override Entity GetValue(FDMBPGEGPKM DJGDNAKMFCE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7EF7B70", Offset = "0x7EF6570", VA = "0x187EF7B70", Slot = "15")]
		public override void SetValue(FDMBPGEGPKM DJGDNAKMFCE, Entity PCDAHJCDHHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7A50", Offset = "0x7EF6450", VA = "0x187EF7A50")]
	public GPONGADCAJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal class DILMPCPEDPN : ContainerPropertyBag<Entity>
{
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	private class LECIOPJOAFB : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override string HMKINKIIOPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x7EF81C0", Offset = "0x7EF6BC0", VA = "0x187EF81C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override bool HDMPHDAENOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8180", Offset = "0x7EF6B80", VA = "0x187EF8180")]
		public LECIOPJOAFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x22F87B0", Offset = "0x22F71B0", VA = "0x1822F87B0", Slot = "14")]
		public override int GetValue(Entity DJGDNAKMFCE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7CF1900", Offset = "0x7CF0300", VA = "0x187CF1900", Slot = "15")]
		public override void SetValue(Entity DJGDNAKMFCE, int PCDAHJCDHHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	private class JBKIOIMCBJD : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override string HMKINKIIOPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x7EF7D40", Offset = "0x7EF6740", VA = "0x187EF7D40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override bool HDMPHDAENOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7EF7D00", Offset = "0x7EF6700", VA = "0x187EF7D00")]
		public JBKIOIMCBJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x129D660", Offset = "0x129C060", VA = "0x18129D660", Slot = "14")]
		public override int GetValue(Entity DJGDNAKMFCE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7EF7CF0", Offset = "0x7EF66F0", VA = "0x187EF7CF0", Slot = "15")]
		public override void SetValue(Entity DJGDNAKMFCE, int PCDAHJCDHHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6FF0", Offset = "0x7EF59F0", VA = "0x187EF6FF0")]
	public DILMPCPEDPN()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7EF9010", Offset = "0x7EF7A10", VA = "0x187EF9010")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public class IBFGABBDLJO
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public IBFGABBDLJO()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	public class RbexHierarchyParentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
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
