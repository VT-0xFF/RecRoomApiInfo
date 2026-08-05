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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
		[Cpp2IlInjected.Address(RVA = "0x832B410", Offset = "0x832A410", VA = "0x18832B410", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x832B7C0", Offset = "0x832A7C0", VA = "0x18832B7C0", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x28D9760", Offset = "0x28D8760", VA = "0x1828D9760")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
[TypeManager.ForcedStableTypeHash(1586941204353847852uL)]
public struct IAFHFIDGKAG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
[TypeManager.ForcedStableTypeHash(1730701010008160003uL)]
public struct MEMJNKNMHCL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
[TypeManager.ForcedStableTypeHash(3399609037308777919uL)]
public struct CHMMKIGOOLP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
[TypeManager.ForcedStableTypeHash(18083619841998483100uL)]
public struct LBAAOJPCMPK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
[TypeManager.ForcedStableTypeHash(12361415346715948123uL)]
public struct JLFBIIPBLAB : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[InternalBufferCapacity(8)]
	[TypeManager.ForcedStableTypeHash(15820941866177188261uL)]
	public struct AuthoredChildBuffer : IBufferElementData, IEquatable<AuthoredChildBuffer>, OHGIBBLFLFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83284F0", Offset = "0x83274F0", VA = "0x1883284F0", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xDBBB10", Offset = "0xDBAB10", VA = "0x180DBBB10")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
[TypeManager.ForcedStableTypeHash(7794731847884836165uL)]
public struct EHHAKOPALID : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
[TypeManager.ForcedStableTypeHash(16414266906034106824uL)]
public struct AJNPONDJCDM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[TypeManager.ForcedStableTypeHash(1525018888797798356uL)]
public struct DDOFONNCKGD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Entity KGPFNKFDGPJ;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[TypeManager.ForcedStableTypeHash(6294257411443737851uL)]
public struct OOLPPBFMNNI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity KGPFNKFDGPJ;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct KCKPHCPINBD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<GKDMMGEPDJK> FINMOBOKJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<Entity> INBFBFGBIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private JobHandle BPLCOHHKDGG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool OJMOGCONOKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8329770", Offset = "0x8328770", VA = "0x188329770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int JHCCKPLGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x83297E0", Offset = "0x83287E0", VA = "0x1883297E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x60740D0", Offset = "0x60730D0", VA = "0x1860740D0")]
	public KCKPHCPINBD(NativeList<GKDMMGEPDJK> FINMOBOKJAM, NativeList<Entity> INBFBFGBIEK, JobHandle BPLCOHHKDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x83295F0", Offset = "0x83285F0", VA = "0x1883295F0")]
	public (Entity, NativeSlice<Entity>) AHLHPMIGMGL(int GGLNBEGGDDO)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8329710", Offset = "0x8328710", VA = "0x188329710", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct GKDMMGEPDJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Entity NKBKNNLLHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int MOAJDMPNBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int FCCMJLNEMIB;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MDANFCHPFMJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IKNFOICPJHE(bool KIAEIKHBCNG);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct OLKICMIFJOM : IEquatable<OLKICMIFJOM>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate bool FFIDCINAACD(int NFDMOMMJDAE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly bool FJLDIMIKMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool OFHJPJDCGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool JKJNBMBMNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool DLIKEFHMGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly FFIDCINAACD BIIJPIGIPGA;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x832A8C0", Offset = "0x83298C0", VA = "0x18832A8C0")]
	public OLKICMIFJOM(MOLPEGLCKDH OMENDEGIBIL, FFIDCINAACD BIIJPIGIPGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x832A890", Offset = "0x8329890", VA = "0x18832A890")]
	public OLKICMIFJOM(bool FJLDIMIKMOB, bool OFHJPJDCGGK, bool JKJNBMBMNFC, bool DLIKEFHMGCB, FFIDCINAACD BIIJPIGIPGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x832A7D0", Offset = "0x83297D0", VA = "0x18832A7D0")]
	public bool PBFIOEOLHDI(int NFDMOMMJDAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x832A780", Offset = "0x8329780", VA = "0x18832A780")]
	public bool JNPLHBPOCHA(int NFDMOMMJDAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x832A5D0", Offset = "0x83295D0", VA = "0x18832A5D0")]
	public bool ENBMOFCODGE(int NFDMOMMJDAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x832A5A0", Offset = "0x83295A0", VA = "0x18832A5A0")]
	public bool BMEDOCMCLFD(int NFDMOMMJDAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x832A600", Offset = "0x8329600", VA = "0x18832A600", Slot = "4")]
	public bool Equals(OLKICMIFJOM EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x832A630", Offset = "0x8329630", VA = "0x18832A630", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x832A6E0", Offset = "0x83296E0", VA = "0x18832A6E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x832A7B0", Offset = "0x83297B0", VA = "0x18832A7B0")]
	private bool MIONAMFMPLF(int NFDMOMMJDAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x832A800", Offset = "0x8329800", VA = "0x18832A800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HDIFIOGFKNI : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public PDCONBAHHJI APBLHJLFMFG;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8328FF0", Offset = "0x8327FF0", VA = "0x188328FF0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public HDIFIOGFKNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface PDCONBAHHJI
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[TypeManager.ForcedStableTypeHash(8332665118338960440uL)]
public struct ANOGJLJEODF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity JGNDHIJFGBE;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[TypeManager.ForcedStableTypeHash(8981907371573408222uL)]
public struct HNJKDMBBEAL : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Entity HBKEHHPNMEE;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[TypeManager.ForcedStableTypeHash(17354288130755581458uL)]
public struct CCODJMKDKLP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Entity ENNHNBJHIMJ;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(10748250521618087564uL)]
public struct HFEGPFPBOPD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public bool POHNOONFNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool FLBDJPBGJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public int HJKIIABJEPB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(3379294255511517190uL)]
public struct OLDHDKNPALC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[TypeManager.ForcedStableTypeHash(4520164298937563310uL)]
[SingletonComponent]
public struct AJCLHJPOEAF : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public Entity KELHIEHPDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public Entity DBIEPPHCNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public Entity FDDALIKNFOM;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(8968007509158485045uL)]
public struct ALLGIBGONBM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public Entity BNCOEAKBHGC;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[TypeManager.ForcedStableTypeHash(4138010451634514615uL)]
public struct ICHMOJEOHJE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float3 EBGKGBGFPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public quaternion KDHLIJMPIFF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(1690080301203719739uL)]
public struct OCLBKHPADCC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(13667964378929084748uL)]
public readonly struct NBGBMCMFOLL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly CLHJDGACDKK AAJLKEIICHH;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x312CE10", Offset = "0x312BE10", VA = "0x18312CE10")]
	public NBGBMCMFOLL(CLHJDGACDKK AAJLKEIICHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x832A210", Offset = "0x8329210", VA = "0x18832A210")]
	public NBGBMCMFOLL KCMHPMJCPPJ(CLHJDGACDKK NPMJNKKDACI)
	{
		return default(NBGBMCMFOLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x832A200", Offset = "0x8329200", VA = "0x18832A200")]
	public NBGBMCMFOLL EFMFGAPFNMN(CLHJDGACDKK FLHFDOPBEJA)
	{
		return default(NBGBMCMFOLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x832A220", Offset = "0x8329220", VA = "0x18832A220", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[Flags]
public enum CLHJDGACDKK : ushort
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
public static class ONHLFJOEPGL
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[TypeManager.ForcedStableTypeHash(1995886936411817354uL)]
[SingletonComponent]
public struct OBBEHCFJGDD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public CLHJDGACDKK KGDDOIOLPCE;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x832A520", Offset = "0x8329520", VA = "0x18832A520")]
	public bool MOPKANCJEEA(NBGBMCMFOLL BIDHJKLPPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x832A500", Offset = "0x8329500", VA = "0x18832A500")]
	public bool MFBJONJKOCL(NBGBMCMFOLL BIDHJKLPPIF, CLHJDGACDKK IAENOIDLJFJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Flags]
public enum DHOKBKEJNPE : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(12096894998449299302uL)]
public struct CAJLIILGPAM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public DHOKBKEJNPE AAJLKEIICHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public bool AKKNPOIICOM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool PKEAIEIHDMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8328610", Offset = "0x8327610", VA = "0x188328610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8328640", Offset = "0x8327640", VA = "0x188328640")]
	private CAJLIILGPAM(DHOKBKEJNPE AAJLKEIICHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8328620", Offset = "0x8327620", VA = "0x188328620")]
	public CAJLIILGPAM KCMHPMJCPPJ(DHOKBKEJNPE NPMJNKKDACI)
	{
		return default(CAJLIILGPAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x83285F0", Offset = "0x83275F0", VA = "0x1883285F0")]
	public CAJLIILGPAM EFMFGAPFNMN(DHOKBKEJNPE FLHFDOPBEJA)
	{
		return default(CAJLIILGPAM);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
[TypeManager.ForcedStableTypeHash(3210980466644930997uL)]
public struct ILOAIAOFKLA : IComponentData
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
public struct OKDFJNDNDPM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Entity IKHBCDJNBKP;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[InternalBufferCapacity(8)]
	[TypeManager.ForcedStableTypeHash(2803523268494646145uL)]
	public struct ChildBuffer : IBufferElementData, IEquatable<ChildBuffer>, OHGIBBLFLFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x83284F0", Offset = "0x83274F0", VA = "0x1883284F0", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xDBBB10", Offset = "0xDBAB10", VA = "0x180DBBB10")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[TypeManager.ForcedStableTypeHash(6734819606313844273uL)]
[SingletonComponent]
public struct KAOJGOHMNEK : ISystemStateBufferElementData, IBufferElementData, OHGIBBLFLFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Entity KELHIEHPDJD;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Entity NLJPPBMCPCH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[TypeManager.ForcedStableTypeHash(10606242260416974827uL)]
public struct IEIGJFKGEIH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Entity DGJCFANBMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Entity DICOMDJBBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Entity KADLFHBBNCG;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct HBPAGKJFEBB<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static readonly bool KJIKLILMPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public uint DMFGBHCBPIF;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	private static bool MKOGDGGCPFD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[TypeManager.ForcedStableTypeHash(8255844827150930234uL)]
public struct HCELOBPCGGI : IBufferElementData, IEquatable<HCELOBPCGGI>, OHGIBBLFLFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Entity JHMDDONIFJK;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private Entity NBBMKJNFNGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x83284F0", Offset = "0x83274F0", VA = "0x1883284F0", Slot = "4")]
	public bool Equals(HCELOBPCGGI EDJHHGMLKFA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[TypeManager.TypeVersion(2)]
[TypeManager.ForcedStableTypeHash(14518013333183728344uL)]
public struct LAKFIGAHNCB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public uint OLFHOEPFPBB;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x14E7060", Offset = "0x14E6060", VA = "0x1814E7060")]
	public LAKFIGAHNCB(AGKIKBEKNMF CLCJHDIBCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8329A50", Offset = "0x8328A50", VA = "0x188329A50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x20EC780", Offset = "0x20EB780", VA = "0x1820EC780")]
	public static LAKFIGAHNCB MJOOONLKLLN(AGKIKBEKNMF CLCJHDIBCKB)
	{
		return default(LAKFIGAHNCB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[TypeManager.ForcedStableTypeHash(12631852336897389638uL)]
public struct EGONJLKOKMN : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Entity KELHIEHPDJD;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[TypeManager.ForcedStableTypeHash(8586426759787957142uL)]
public struct NIAFLPDIOKD : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public AGKIKBEKNMF IOALKPFEKEK;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[TypeManager.ForcedStableTypeHash(3916218676170013300uL)]
public struct GKPFNNEEGKC : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Entity KELHIEHPDJD;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[TypeManager.ForcedStableTypeHash(3395423174463894753uL)]
public struct IJPPDIIPLBN : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Guid JFLBGDIIGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public int MFFPIAPMHCN;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[TypeManager.ForcedStableTypeHash(13485578171010875955uL)]
public struct NJHDJHBONHB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public int IOALKPFEKEK;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[TypeManager.ForcedStableTypeHash(11182407275731589027uL)]
public struct AMDCHMMJFDD : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Entity KELHIEHPDJD;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[TypeManager.ForcedStableTypeHash(238571310055566811uL)]
public struct GLKJHLCABFB : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public AGKIKBEKNMF IOALKPFEKEK;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[TypeManager.ForcedStableTypeHash(17943708062286791581uL)]
public struct KNNKAELDHDL : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Entity KELHIEHPDJD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
[TypeManager.ForcedStableTypeHash(17717774548790709874uL)]
public struct GONMGAFFPDF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(1628423395607207516uL)]
public struct JECDCOCPNBP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int BIBFIHOLJKD;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[TypeManager.ForcedStableTypeHash(6255673600552782006uL)]
public struct IKIAOJGIBGC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int KJENEIANJDF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DOHKIBLNJFC NDDFOCHAEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xD8A410", Offset = "0xD89410", VA = "0x180D8A410")]
		get
		{
			return default(DOHKIBLNJFC);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[TypeManager.ForcedStableTypeHash(7921165883083593916uL)]
public struct LEBGAAEDNMA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public GCHandle JELNEIEMIMD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
[TypeManager.ForcedStableTypeHash(14965811366685608319uL)]
public struct HFJFIDMFEDI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003B")]
[TypeManager.ForcedStableTypeHash(8376615066990205632uL)]
public struct LPPCIIHAPKO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003C")]
[TypeManager.ForcedStableTypeHash(7273320061473429398uL)]
public struct DOIABEHDMBL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003D")]
[TypeManager.ForcedStableTypeHash(15140206241145976177uL)]
public struct AOJBEDLNFBD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003E")]
[TypeManager.ForcedStableTypeHash(15969631250552901108uL)]
public struct MDCEHOHFCOL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[TypeManager.ForcedStableTypeHash(9353178840587053763uL)]
public struct JDDAPJACBFJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public int HLGKMAPOEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public int LMOHNMMFGMP;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8329460", Offset = "0x8328460", VA = "0x188329460")]
	public JDDAPJACBFJ(Entity KELHIEHPDJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[TypeManager.ForcedStableTypeHash(16229383422209788655uL)]
public struct JFACNGLBHMM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public CollisionDetectionMode JLLLJIMNLMF;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[TypeManager.ForcedStableTypeHash(5173865590150727846uL)]
[RegisterComponentDefault]
public struct NCDGEECEOAD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public FECJOJFDCBL FODGGMPAGFC;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly NCDGEECEOAD HPFHFAKCNGM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000042")]
[TypeManager.ForcedStableTypeHash(7051356195299730219uL)]
public struct JNNLNBNIJPF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000043")]
[TypeManager.ForcedStableTypeHash(780557526766205634uL)]
public struct IIBBNILNOLP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000044")]
[TypeManager.ForcedStableTypeHash(16413322458062516985uL)]
public struct DKAJOFIBIII : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[InternalBufferCapacity(0)]
[TypeManager.ForcedStableTypeHash(8350832327674051347uL)]
public struct NLMOPPBHMNF : IBufferElementData, IEquatable<NLMOPPBHMNF>, OHGIBBLFLFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Entity EMABJDLOPJA;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity NBBMKJNFNGG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x83284F0", Offset = "0x83274F0", VA = "0x1883284F0", Slot = "4")]
	public bool Equals(NLMOPPBHMNF EDJHHGMLKFA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[TypeManager.ForcedStableTypeHash(3503423083784418805uL)]
public struct AOHCNOEGPIJ : IComponentData, OHGIBBLFLFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public Entity EBJBKAEFOPM;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Entity NBBMKJNFNGG
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
[TypeManager.ForcedStableTypeHash(14551834985136520975uL)]
public struct CLOJGGAKIKG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[TypeManager.ForcedStableTypeHash(4388378139562737487uL)]
public struct BGCLMHNIIIK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Entity NKBKNNLLHKF;
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct CGIEEGMOJCK : MMICFEOIFBA, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public BIFBIJAJCPB DJHDGLHCFMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(BIFBIJAJCPB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[TypeManager.ForcedStableTypeHash(769086036388751339uL)]
public struct BGBANOKLINI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public float3 JBGGFJIIHFP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004B")]
[TypeManager.ForcedStableTypeHash(15638082890667179775uL)]
public struct CNNIOMDAGDH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(7040629969868025973uL)]
public struct IMHJFKDBKLK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public float3x3 PLAKLGLCBKD;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly IMHJFKDBKLK HPFHFAKCNGM;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[TypeManager.ForcedStableTypeHash(1290915447730818204uL)]
[RegisterComponentDefault]
public struct GAGEFNKPCBH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public float3x3 PLAKLGLCBKD;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly GAGEFNKPCBH HPFHFAKCNGM;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[TypeManager.ForcedStableTypeHash(7667208078276643555uL)]
public struct NEKAFJBDNBH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float3 FNPCKMJDECN;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[TypeManager.ForcedStableTypeHash(11475279934298573286uL)]
public struct CFOIPMPBGFK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public float3 PCEGNICMEOP;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(18413785019621221410uL)]
public struct BGHGNBLLHFM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float HGPGMIAKMMG;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly BGHGNBLLHFM HPFHFAKCNGM;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(16788150452972582455uL)]
public struct KLDCMEPHGOI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float BHBOIEHJEOM;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly KLDCMEPHGOI HPFHFAKCNGM;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[TypeManager.ForcedStableTypeHash(971312552983123380uL)]
public struct HFPHAGPAFJD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 PBPJMOAKLFK;
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[TypeManager.ForcedStableTypeHash(361641396811542242uL)]
public struct DGPMGEOJDME : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public PCMEBGNJIKH ELGDGMOPDKC;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[TypeManager.ForcedStableTypeHash(7520974846918069913uL)]
[SingletonComponent]
public struct PONOFBKHPFG : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public Entity KELHIEHPDJD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
[TypeManager.ForcedStableTypeHash(9260549625364734686uL)]
public struct EFGMJHHNABL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
[TypeManager.ForcedStableTypeHash(469905343419662571uL)]
public struct JOGPNNHOFIB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[TypeManager.ForcedStableTypeHash(7865784707562564105uL)]
public struct EEAEGMAEJGJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public RigidbodyConstraints LCBPFFNIJIA;
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[TypeManager.ForcedStableTypeHash(7877027338327956319uL)]
[RegisterComponentDefault]
public struct ADFCMGKGCMI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float BCEDCCMJNGC;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly ADFCMGKGCMI HPFHFAKCNGM;
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[TypeManager.ForcedStableTypeHash(935406425377786813uL)]
public struct DPOBPBKEOCL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float LJOOJHOLGAP;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class HPAKMLCPNEI : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public GameObject GLGAAAMILBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public object FMMDFKIHIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public object KMHJLOMHEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public KGEJCFCCIMK ELAKGDCNKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Delegate INEJCEBPNDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Delegate PLJEAEMPKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public FNGMMGDEDMM<Delegate> CPBGJMANJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public FNGMMGDEDMM<Delegate> HLPLDCFIEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public FNGMMGDEDMM<Delegate> EJJKPPKEAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public FNGMMGDEDMM<Delegate> OMBOLPBKJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public FNGMMGDEDMM<Delegate> IEMLBICHKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public FNGMMGDEDMM<Delegate> JBHGPCHMACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public FNGMMGDEDMM<Delegate> GKKIOLCLLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public FNGMMGDEDMM<Delegate> MKCECHJHEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public FNGMMGDEDMM<Delegate> LHIFPMCLGDI;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8329120", Offset = "0x8328120", VA = "0x188329120", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public HPAKMLCPNEI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
[TypeManager.ForcedStableTypeHash(9555099704367481551uL)]
public struct DLHNDBKJMCL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
[TypeManager.ForcedStableTypeHash(18165447863202358792uL)]
public struct GHAJICEPMLG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[TypeManager.ForcedStableTypeHash(10810926406358250264uL)]
public struct FEJOEIMAHGB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public int BGHGFGHLFOJ;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x20EC780", Offset = "0x20EB780", VA = "0x1820EC780")]
	public static FEJOEIMAHGB MJOOONLKLLN(int IOALKPFEKEK)
	{
		return default(FEJOEIMAHGB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class ECMOAEDCDGD : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Rigidbody OJLJIHMPMHO;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x83287D0", Offset = "0x83277D0", VA = "0x1883287D0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public ECMOAEDCDGD()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
[TypeManager.ForcedStableTypeHash(12765569839950265583uL)]
public struct BIIGBDFFMBC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[TypeManager.ForcedStableTypeHash(17236748096909814533uL)]
public struct JNIGBBDBKKH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float3 MPLOLODGAEG;
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[TypeManager.ForcedStableTypeHash(1288392478539867023uL)]
public struct IMJCHAJEEHA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public float3 PJFEPLADHFM;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(15102898512288820575uL)]
public struct GMJCOFBCDFB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public float COADJHJPMKC;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly GMJCOFBCDFB HPFHFAKCNGM;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class ONJEDDFMHMA : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public object FFNPNACKGAB;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x832A910", Offset = "0x8329910", VA = "0x18832A910", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public ONJEDDFMHMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class NFMOKHEKIEI : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public object ELIEBADDELA;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x832A2C0", Offset = "0x83292C0", VA = "0x18832A2C0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public NFMOKHEKIEI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
[TypeManager.ForcedStableTypeHash(3505189951659289292uL)]
public struct OGJNNMPMEGO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
[TypeManager.ForcedStableTypeHash(16217323095468023009uL)]
public struct KAJKLLHAGAN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
[TypeManager.ForcedStableTypeHash(12880717127246424414uL)]
public struct MNGOCJPFCBO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
[TypeManager.ForcedStableTypeHash(12942629461400744171uL)]
public struct NOJGOPMFIBO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
[TypeManager.ForcedStableTypeHash(10226241216405964379uL)]
public struct IIDEHPPPINK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
[TypeManager.ForcedStableTypeHash(12400259538654257671uL)]
public struct MFCMNGLFMLL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
[TypeManager.ForcedStableTypeHash(12731949941800560397uL)]
public struct JKLOFCHFFCK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
[TypeManager.ForcedStableTypeHash(16270799832065682331uL)]
public struct IPINPLOGMDI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
[TypeManager.ForcedStableTypeHash(9395080039644288849uL)]
public struct JHDOGOHIAHM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
[TypeManager.ForcedStableTypeHash(15229363233412980908uL)]
public struct JEKEKGMMCHD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[TypeManager.ForcedStableTypeHash(282623311697096978uL)]
public struct NPHKDLJHJDL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public HDLEPENBPIC BHCELHKNNAD;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x832A4B0", Offset = "0x83294B0", VA = "0x18832A4B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
[TypeManager.ForcedStableTypeHash(10395819776101408141uL)]
public struct KBBHFIHELHI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
[TypeManager.ForcedStableTypeHash(375953524326549120uL)]
public struct HFNGOOLMLFA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
[TypeManager.ForcedStableTypeHash(14259779488802476986uL)]
public struct BDHGNIEDFGM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[TypeManager.ForcedStableTypeHash(15330221065042235480uL)]
public struct OBJIBGJHEJP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public FixedString32Bytes HJLBILHBIIC;
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(5162925656869367991uL)]
public struct LFFNBJBAOKO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public UnsafeParallelHashMap<HDLEPENBPIC, Entity> LMKGFGJDIGC;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[TypeManager.ForcedStableTypeHash(9841032716800521808uL)]
public struct NFELBKMEDLJ : ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Entity BFBJJOCGJEG;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[TypeManager.ForcedStableTypeHash(154813247653871879uL)]
internal struct BOHMBBIPBDL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Entity KELHIEHPDJD;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xDBBB10", Offset = "0xDBAB10", VA = "0x180DBBB10")]
	public static BOHMBBIPBDL MJOOONLKLLN(Entity KELHIEHPDJD)
	{
		return default(BOHMBBIPBDL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[TypeManager.ForcedStableTypeHash(11656653634719673845uL)]
public struct AEFPGJOBALM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Entity FLPOMKAKHLI;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[TypeManager.ForcedStableTypeHash(1837719173092935466uL)]
public struct GKMIMPIKGPD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Entity FLPOMKAKHLI;
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[TypeManager.ForcedStableTypeHash(17382237360022739174uL)]
internal struct PMDLNNEOCNK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Entity OCFOKOEDFGJ;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xDBBB10", Offset = "0xDBAB10", VA = "0x180DBBB10")]
	public static PMDLNNEOCNK MJOOONLKLLN(Entity KELHIEHPDJD)
	{
		return default(PMDLNNEOCNK);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
[TypeManager.ForcedStableTypeHash(15858722173278118533uL)]
internal struct JDLHCBKHPPC : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[TypeManager.ForcedStableTypeHash(10313790595830381076uL)]
public struct PMBLJDDEKDM : IBufferElementData, IEquatable<PMBLJDDEKDM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Entity CIMBBBAALLD;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x8118980", Offset = "0x8117980", VA = "0x188118980", Slot = "4")]
	public bool Equals(PMBLJDDEKDM EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x832AC50", Offset = "0x8329C50", VA = "0x18832AC50", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xD8A410", Offset = "0xD89410", VA = "0x180D8A410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[TypeManager.ForcedStableTypeHash(10169361040328370708uL)]
public struct JOOGKLIDABK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public uint LMOHNMMFGMP;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(11536226225076729790uL)]
internal struct NEDHBMADHDA : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Entity CPHKFOPBBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public int HLGKMAPOEBE;
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[TypeManager.ForcedStableTypeHash(8309037880064337491uL)]
internal struct JDOCFEMNGPH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Entity PNINCLCEGEG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
[TypeManager.ForcedStableTypeHash(5891816987223099091uL)]
public struct APBJGDEFPNL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[TypeManager.ForcedStableTypeHash(17289298604600812224uL)]
public struct IFDJBDIIBKB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public uint DMFGBHCBPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public int AAMCCFHMFCG;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xE5E0E0", Offset = "0xE5D0E0", VA = "0x180E5E0E0")]
	public IFDJBDIIBKB(uint MHNMAIFGAEJ, int BBNHBAICALF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
[TypeManager.ForcedStableTypeHash(12258100538258701401uL)]
public struct BLHBPFEKNPM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
[TypeManager.ForcedStableTypeHash(3081870877980445988uL)]
public struct OFPFPLMHIKD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
[TypeManager.ForcedStableTypeHash(15554741495161407507uL)]
public struct FGIDAAIDDIO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
[TypeManager.ForcedStableTypeHash(17684057078056878475uL)]
public struct MMFFAOFNDBH : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000085")]
[TypeManager.ForcedStableTypeHash(10023455309444528896uL)]
public struct IKCIIOFCKMM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
[TypeManager.ForcedStableTypeHash(14403752119546393228uL)]
public struct INJAPAJEAHD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
[TypeManager.ForcedStableTypeHash(9219181242087356214uL)]
public struct KLHFNODMBAF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
[TypeManager.ForcedStableTypeHash(12371658133244024718uL)]
public struct MGDFKGLCLBG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
[TypeManager.ForcedStableTypeHash(9351414359236295489uL)]
public struct LOEOHMOKODB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
[TypeManager.ForcedStableTypeHash(12796707860320869007uL)]
internal struct CNFBPEPLDGO : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
[TypeManager.ForcedStableTypeHash(13367368557807690484uL)]
public struct BLFIAFBEJDL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008C")]
[TypeManager.ForcedStableTypeHash(7193071459223094579uL)]
public struct IPBJPJNABPO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
[TypeManager.ForcedStableTypeHash(17039127292426947163uL)]
public struct JBOMGJDMHLK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008E")]
[TypeManager.ForcedStableTypeHash(15247343901949961769uL)]
public struct ENIHIENIHCE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
[TypeManager.ForcedStableTypeHash(5381043565870728787uL)]
public struct FAKFFPOCPNP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
[TypeManager.ForcedStableTypeHash(11597028615900234104uL)]
internal struct PHBDCJPDMIB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
[TypeManager.ForcedStableTypeHash(1907494159895213433uL)]
internal struct KIGLPOKDPJD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000092")]
[TypeManager.ForcedStableTypeHash(3955886960983597628uL)]
public struct AHAHCNMMGAI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000093")]
[TypeManager.ForcedStableTypeHash(480620745253244652uL)]
public struct MDOAJJEIACE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000094")]
[TypeManager.ForcedStableTypeHash(8253675824478287824uL)]
public struct LFIBKBFBIDF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000095")]
[TypeManager.ForcedStableTypeHash(8855488771047251567uL)]
public struct IEBJOGJHAIE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000096")]
[TypeManager.ForcedStableTypeHash(8375777954271012995uL)]
public struct OPMNNJMHHNB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
[TypeManager.ForcedStableTypeHash(16778215356980427836uL)]
public struct KAICJHKBNPJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000098")]
[TypeManager.ForcedStableTypeHash(16444804027614993581uL)]
public struct NNFFNPHPKMM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000099")]
[TypeManager.ForcedStableTypeHash(16177323740107409537uL)]
public struct DODLBDJLMBI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
[TypeManager.ForcedStableTypeHash(11049752089067741804uL)]
public struct JFNBCPNIIEA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009B")]
[TypeManager.ForcedStableTypeHash(1453937769327886583uL)]
public struct BECPOHBOBLD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
[TypeManager.ForcedStableTypeHash(800754555681830909uL)]
public struct ENAFLCBKFPK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009D")]
[TypeManager.ForcedStableTypeHash(3336901602667819150uL)]
public struct KPOGHPHIGNL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009E")]
[TypeManager.ForcedStableTypeHash(11809750536411032401uL)]
public struct FFINMLDKCON : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
[TypeManager.ForcedStableTypeHash(6387004770090400669uL)]
public struct OOAOGEAGJHP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[TypeManager.ForcedStableTypeHash(2223159712203397538uL)]
internal struct PBMDJEOLKOE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[TypeManager.ForcedStableTypeHash(10153397523300334327uL)]
public struct PHDKHHBDGNN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[TypeManager.ForcedStableTypeHash(12983102201306073842uL)]
public struct LBFIFGFAFFJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[FPIHEMPIIAE]
[TypeManager.ForcedStableTypeHash(15398959433761599914uL)]
public struct PJGCDAEDLNA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6605318152550716456uL)]
public struct DAJLHEADJMC : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public FixedString32Bytes MIMAHBNFICG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[TypeManager.ForcedStableTypeHash(10065634662848845784uL)]
public struct LANMJAHLKKN : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[TypeManager.ForcedStableTypeHash(15062299176839263439uL)]
public struct MADLMIHKCKH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[TypeManager.ForcedStableTypeHash(3596269116834888123uL)]
internal struct KCKJGAJFMFF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[TypeManager.ForcedStableTypeHash(4402941654898007496uL)]
internal struct KPNHJGKCJDM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[TypeManager.ForcedStableTypeHash(12682474121528142025uL)]
internal struct LPNDKPFDGGI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[TypeManager.ForcedStableTypeHash(1840266485562743455uL)]
public struct DAKMOHBKOLI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[TypeManager.ForcedStableTypeHash(15820134490602808056uL)]
public struct GFJFIFOGPBG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public int JIOHPKNKOFA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[TypeManager.ForcedStableTypeHash(4772574226205567794uL)]
public struct GAOOOLOGJJJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[TypeManager.ForcedStableTypeHash(17642911464827038147uL)]
public struct PEFBDKPAOBP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public quaternion KDHLIJMPIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public float3 EBGKGBGFPOC;
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[TypeManager.ForcedStableTypeHash(9066921186040058989uL)]
public struct HFHKIFIMLMJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public float NMJDKLAOJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public float DKCMGGMJJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public float OOGACIBMMPG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[TypeManager.ForcedStableTypeHash(3328998613642473514uL)]
public struct DDCHKACKEEJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[TypeManager.ForcedStableTypeHash(151116349382904900uL)]
public struct AMDNJJKPDJH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[TypeManager.ForcedStableTypeHash(8067675582152570601uL)]
public struct ONEFGFFPJFD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[TypeManager.ForcedStableTypeHash(4522686316477281096uL)]
public struct GIPFEIGFCGJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public int KJENEIANJDF;
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6216404920432680992uL)]
public struct CGAAKJDGFIK : ISystemStateBufferElementData, IBufferElementData, OHGIBBLFLFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Entity JPAJKPMDGBM;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity NLJPPBMCPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(419884688393735449uL)]
public struct KGLEJGCKNJM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public float4x4 ENDKBLJANMP;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static readonly KGLEJGCKNJM HPFHFAKCNGM;
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(1954795745923300919uL)]
public struct AKNONPGBECE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public float4x4 KPOFKEGGPLL;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public static readonly AKNONPGBECE HPFHFAKCNGM;
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[TypeManager.ForcedStableTypeHash(2447627752265109178uL)]
public struct LHBJJMGLJHG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private int POKIHFMKBPM;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int HLGKMAPOEBE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x832A120", Offset = "0x8329120", VA = "0x18832A120")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x832A130", Offset = "0x8329130", VA = "0x18832A130")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[TypeManager.ForcedStableTypeHash(13706996280046618062uL)]
[RegisterComponentDefault]
public struct FFEGEOOIIDD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public float3 EBGKGBGFPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public quaternion KDHLIJMPIFF;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public static readonly FFEGEOOIIDD HPFHFAKCNGM;
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public static class GNMOFAMAKBE
{
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[TypeManager.ForcedStableTypeHash(77694943841979493uL)]
[RegisterComponentDefault]
public struct LBMHKOPCMJJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public float LKLNMNCEBMB;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public static readonly LBMHKOPCMJJ HPFHFAKCNGM;
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[TypeManager.ForcedStableTypeHash(6537711325103434903uL)]
public struct EEEKFDJCJCK : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public Entity HNLEHANEADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public EJKKDGPBELM CBONFFLHKGG;
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[TypeManager.ForcedStableTypeHash(5471640964865828061uL)]
public struct PJOFNEEHPLG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public EJKKDGPBELM CBONFFLHKGG;
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[TypeManager.ForcedStableTypeHash(16527934868211432802uL)]
public struct CDLBINGFOPO : ISystemStateComponentData, IComponentData, OHGIBBLFLFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Entity FICFFHNKAMC;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Entity NLJPPBMCPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[TypeManager.ForcedStableTypeHash(15310407062508355916uL)]
public struct EKPKINKFPPM : ISystemStateBufferElementData, IBufferElementData, OHGIBBLFLFA, IEquatable<EKPKINKFPPM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public Entity BBKPDCBCOFA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Entity NLJPPBMCPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8118980", Offset = "0x8117980", VA = "0x188118980", Slot = "6")]
	public bool Equals(EKPKINKFPPM EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8328920", Offset = "0x8327920", VA = "0x188328920", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xD8A410", Offset = "0xD89410", VA = "0x180D8A410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[TypeManager.ForcedStableTypeHash(11786768220100978132uL)]
public struct NDIHGILLCLA : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public Entity HNLEHANEADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public EJKKDGPBELM CBONFFLHKGG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public struct BGKKBFJCKOP : IEqualityComparer<NDIHGILLCLA>
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static BGKKBFJCKOP HPFHFAKCNGM;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8328540", Offset = "0x8327540", VA = "0x188328540", Slot = "4")]
	public bool Equals(NDIHGILLCLA OEFDFBLCHHF, NDIHGILLCLA GDBEEAKMPMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8328590", Offset = "0x8327590", VA = "0x188328590", Slot = "5")]
	public int GetHashCode(NDIHGILLCLA PGIOEBKALDP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[TypeManager.ForcedStableTypeHash(8981997360983277121uL)]
public struct DKAJPBELJEP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public FixedList32Bytes<int> LHCAACJBMFJ;
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[TypeManager.ForcedStableTypeHash(2801212869002544047uL)]
public struct BHEMGOGEGBK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public FixedList32Bytes<int> LHCAACJBMFJ;
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[TypeManager.ForcedStableTypeHash(16455485691096333919uL)]
public struct LFHAEINJGLC : ISystemStateBufferElementData, IBufferElementData, OHGIBBLFLFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public Entity KKEIJANBOFN;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Entity NBBMKJNFNGG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
internal class EIBBLPPBLGO : ContainerPropertyBag<HDIFIOGFKNI>
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private class GNGIFHEKJOE : Property<HDIFIOGFKNI, PDCONBAHHJI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string GHLJANJDNGM
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8328EE0", Offset = "0x8327EE0", VA = "0x188328EE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool COBLKMLKMPH
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8328EA0", Offset = "0x8327EA0", VA = "0x188328EA0")]
		public GNGIFHEKJOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8328650", Offset = "0x8327650", VA = "0x188328650", Slot = "14")]
		public override PDCONBAHHJI GetValue(HDIFIOGFKNI PFJIPDCNGCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8328670", Offset = "0x8327670", VA = "0x188328670", Slot = "15")]
		public override void SetValue(HDIFIOGFKNI PFJIPDCNGCE, PDCONBAHHJI IOALKPFEKEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8328840", Offset = "0x8327840", VA = "0x188328840")]
	public EIBBLPPBLGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal class LGFCFDDLFMA : ContainerPropertyBag<HPAKMLCPNEI>
{
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	private class DAAOEBFBFLK : Property<HPAKMLCPNEI, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string GHLJANJDNGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x83286E0", Offset = "0x83276E0", VA = "0x1883286E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool COBLKMLKMPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x83286A0", Offset = "0x83276A0", VA = "0x1883286A0")]
		public DAAOEBFBFLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8328650", Offset = "0x8327650", VA = "0x188328650", Slot = "14")]
		public override GameObject GetValue(HPAKMLCPNEI PFJIPDCNGCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8328670", Offset = "0x8327670", VA = "0x188328670", Slot = "15")]
		public override void SetValue(HPAKMLCPNEI PFJIPDCNGCE, GameObject IOALKPFEKEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	private class IHANGHMPGCE : Property<HPAKMLCPNEI, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string GHLJANJDNGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8329200", Offset = "0x8328200", VA = "0x188329200", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool COBLKMLKMPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x83291C0", Offset = "0x83281C0", VA = "0x1883291C0")]
		public IHANGHMPGCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8329170", Offset = "0x8328170", VA = "0x188329170", Slot = "14")]
		public override object GetValue(HPAKMLCPNEI PFJIPDCNGCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8329190", Offset = "0x8328190", VA = "0x188329190", Slot = "15")]
		public override void SetValue(HPAKMLCPNEI PFJIPDCNGCE, object IOALKPFEKEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	private class NINPGCDEFHI : Property<HPAKMLCPNEI, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string GHLJANJDNGM
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x832A3C0", Offset = "0x83293C0", VA = "0x18832A3C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool COBLKMLKMPH
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x832A380", Offset = "0x8329380", VA = "0x18832A380")]
		public NINPGCDEFHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x832A330", Offset = "0x8329330", VA = "0x18832A330", Slot = "14")]
		public override object GetValue(HPAKMLCPNEI PFJIPDCNGCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x832A350", Offset = "0x8329350", VA = "0x18832A350", Slot = "15")]
		public override void SetValue(HPAKMLCPNEI PFJIPDCNGCE, object IOALKPFEKEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	private class GCDBJOAJFHN : Property<HPAKMLCPNEI, KGEJCFCCIMK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string GHLJANJDNGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x8328DB0", Offset = "0x8327DB0", VA = "0x188328DB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool COBLKMLKMPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8328D70", Offset = "0x8327D70", VA = "0x188328D70")]
		public GCDBJOAJFHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8328D20", Offset = "0x8327D20", VA = "0x188328D20", Slot = "14")]
		public override KGEJCFCCIMK GetValue(HPAKMLCPNEI PFJIPDCNGCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8328D40", Offset = "0x8327D40", VA = "0x188328D40", Slot = "15")]
		public override void SetValue(HPAKMLCPNEI PFJIPDCNGCE, KGEJCFCCIMK IOALKPFEKEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	private class DEIJFJBIEBM : Property<HPAKMLCPNEI, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string GHLJANJDNGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x83287A0", Offset = "0x83277A0", VA = "0x1883287A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool COBLKMLKMPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8328760", Offset = "0x8327760", VA = "0x188328760")]
		public DEIJFJBIEBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8328710", Offset = "0x8327710", VA = "0x188328710", Slot = "14")]
		public override Delegate GetValue(HPAKMLCPNEI PFJIPDCNGCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8328730", Offset = "0x8327730", VA = "0x188328730", Slot = "15")]
		public override void SetValue(HPAKMLCPNEI PFJIPDCNGCE, Delegate IOALKPFEKEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	private class LHFFMMGAAOO : Property<HPAKMLCPNEI, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string GHLJANJDNGM
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x832A1D0", Offset = "0x83291D0", VA = "0x18832A1D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool COBLKMLKMPH
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x832A190", Offset = "0x8329190", VA = "0x18832A190")]
		public LHFFMMGAAOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x832A140", Offset = "0x8329140", VA = "0x18832A140", Slot = "14")]
		public override Delegate GetValue(HPAKMLCPNEI PFJIPDCNGCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x832A160", Offset = "0x8329160", VA = "0x18832A160", Slot = "15")]
		public override void SetValue(HPAKMLCPNEI PFJIPDCNGCE, Delegate IOALKPFEKEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	private class FEOMKKKAKLP : Property<HPAKMLCPNEI, FNGMMGDEDMM<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string GHLJANJDNGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x8328AC0", Offset = "0x8327AC0", VA = "0x188328AC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool COBLKMLKMPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8328A80", Offset = "0x8327A80", VA = "0x188328A80")]
		public FEOMKKKAKLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8328A30", Offset = "0x8327A30", VA = "0x188328A30", Slot = "14")]
		public override FNGMMGDEDMM<Delegate> GetValue(HPAKMLCPNEI PFJIPDCNGCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8328A50", Offset = "0x8327A50", VA = "0x188328A50", Slot = "15")]
		public override void SetValue(HPAKMLCPNEI PFJIPDCNGCE, FNGMMGDEDMM<Delegate> IOALKPFEKEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	private class IICKHBPAEAL : Property<HPAKMLCPNEI, FNGMMGDEDMM<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string GHLJANJDNGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x83292C0", Offset = "0x83282C0", VA = "0x1883292C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool COBLKMLKMPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8329280", Offset = "0x8328280", VA = "0x188329280")]
		public IICKHBPAEAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8329230", Offset = "0x8328230", VA = "0x188329230", Slot = "14")]
		public override FNGMMGDEDMM<Delegate> GetValue(HPAKMLCPNEI PFJIPDCNGCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8329250", Offset = "0x8328250", VA = "0x188329250", Slot = "15")]
		public override void SetValue(HPAKMLCPNEI PFJIPDCNGCE, FNGMMGDEDMM<Delegate> IOALKPFEKEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	private class NJBEFDNDLLC : Property<HPAKMLCPNEI, FNGMMGDEDMM<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string GHLJANJDNGM
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x832A480", Offset = "0x8329480", VA = "0x18832A480", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool COBLKMLKMPH
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x832A440", Offset = "0x8329440", VA = "0x18832A440")]
		public NJBEFDNDLLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x832A3F0", Offset = "0x83293F0", VA = "0x18832A3F0", Slot = "14")]
		public override FNGMMGDEDMM<Delegate> GetValue(HPAKMLCPNEI PFJIPDCNGCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x832A410", Offset = "0x8329410", VA = "0x18832A410", Slot = "15")]
		public override void SetValue(HPAKMLCPNEI PFJIPDCNGCE, FNGMMGDEDMM<Delegate> IOALKPFEKEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	private class PGIIDOMIPOF : Property<HPAKMLCPNEI, FNGMMGDEDMM<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string GHLJANJDNGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x832AAD0", Offset = "0x8329AD0", VA = "0x18832AAD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool COBLKMLKMPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x832AA90", Offset = "0x8329A90", VA = "0x18832AA90")]
		public PGIIDOMIPOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x832AA40", Offset = "0x8329A40", VA = "0x18832AA40", Slot = "14")]
		public override FNGMMGDEDMM<Delegate> GetValue(HPAKMLCPNEI PFJIPDCNGCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x832AA60", Offset = "0x8329A60", VA = "0x18832AA60", Slot = "15")]
		public override void SetValue(HPAKMLCPNEI PFJIPDCNGCE, FNGMMGDEDMM<Delegate> IOALKPFEKEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	private class PGGJMDLOJBF : Property<HPAKMLCPNEI, FNGMMGDEDMM<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string GHLJANJDNGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x832AA10", Offset = "0x8329A10", VA = "0x18832AA10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool COBLKMLKMPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x832A9D0", Offset = "0x83299D0", VA = "0x18832A9D0")]
		public PGGJMDLOJBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x832A980", Offset = "0x8329980", VA = "0x18832A980", Slot = "14")]
		public override FNGMMGDEDMM<Delegate> GetValue(HPAKMLCPNEI PFJIPDCNGCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x832A9A0", Offset = "0x83299A0", VA = "0x18832A9A0", Slot = "15")]
		public override void SetValue(HPAKMLCPNEI PFJIPDCNGCE, FNGMMGDEDMM<Delegate> IOALKPFEKEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	private class HDPGBAMPDAG : Property<HPAKMLCPNEI, FNGMMGDEDMM<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string GHLJANJDNGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x83290F0", Offset = "0x83280F0", VA = "0x1883290F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool COBLKMLKMPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x83290B0", Offset = "0x83280B0", VA = "0x1883290B0")]
		public HDPGBAMPDAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8329060", Offset = "0x8328060", VA = "0x188329060", Slot = "14")]
		public override FNGMMGDEDMM<Delegate> GetValue(HPAKMLCPNEI PFJIPDCNGCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8329080", Offset = "0x8328080", VA = "0x188329080", Slot = "15")]
		public override void SetValue(HPAKMLCPNEI PFJIPDCNGCE, FNGMMGDEDMM<Delegate> IOALKPFEKEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	private class KAAOGPMPLLF : Property<HPAKMLCPNEI, FNGMMGDEDMM<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string GHLJANJDNGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x83295C0", Offset = "0x83285C0", VA = "0x1883295C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool COBLKMLKMPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8329580", Offset = "0x8328580", VA = "0x188329580")]
		public KAAOGPMPLLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8329530", Offset = "0x8328530", VA = "0x188329530", Slot = "14")]
		public override FNGMMGDEDMM<Delegate> GetValue(HPAKMLCPNEI PFJIPDCNGCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8329550", Offset = "0x8328550", VA = "0x188329550", Slot = "15")]
		public override void SetValue(HPAKMLCPNEI PFJIPDCNGCE, FNGMMGDEDMM<Delegate> IOALKPFEKEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	private class JFOIDJAGPLF : Property<HPAKMLCPNEI, FNGMMGDEDMM<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string GHLJANJDNGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8329500", Offset = "0x8328500", VA = "0x188329500", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool COBLKMLKMPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x83294C0", Offset = "0x83284C0", VA = "0x1883294C0")]
		public JFOIDJAGPLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8329470", Offset = "0x8328470", VA = "0x188329470", Slot = "14")]
		public override FNGMMGDEDMM<Delegate> GetValue(HPAKMLCPNEI PFJIPDCNGCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8329490", Offset = "0x8328490", VA = "0x188329490", Slot = "15")]
		public override void SetValue(HPAKMLCPNEI PFJIPDCNGCE, FNGMMGDEDMM<Delegate> IOALKPFEKEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	private class KKEGMLDLADB : Property<HPAKMLCPNEI, FNGMMGDEDMM<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string GHLJANJDNGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x8329970", Offset = "0x8328970", VA = "0x188329970", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool COBLKMLKMPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8329930", Offset = "0x8328930", VA = "0x188329930")]
		public KKEGMLDLADB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x83298E0", Offset = "0x83288E0", VA = "0x1883298E0", Slot = "14")]
		public override FNGMMGDEDMM<Delegate> GetValue(HPAKMLCPNEI PFJIPDCNGCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8329900", Offset = "0x8328900", VA = "0x188329900", Slot = "15")]
		public override void SetValue(HPAKMLCPNEI PFJIPDCNGCE, FNGMMGDEDMM<Delegate> IOALKPFEKEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8329AC0", Offset = "0x8328AC0", VA = "0x188329AC0")]
	public LGFCFDDLFMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal class AEBNGHGFCAN : ContainerPropertyBag<FNGMMGDEDMM<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8328300", Offset = "0x8327300", VA = "0x188328300")]
	public AEBNGHGFCAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal class PIPHKKBILMA : ContainerPropertyBag<ECMOAEDCDGD>
{
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	private class KKIKDDKEDGH : Property<ECMOAEDCDGD, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string GHLJANJDNGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x83299E0", Offset = "0x83289E0", VA = "0x1883299E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool COBLKMLKMPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x83299A0", Offset = "0x83289A0", VA = "0x1883299A0")]
		public KKIKDDKEDGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8328650", Offset = "0x8327650", VA = "0x188328650", Slot = "14")]
		public override Rigidbody GetValue(ECMOAEDCDGD PFJIPDCNGCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8328670", Offset = "0x8327670", VA = "0x188328670", Slot = "15")]
		public override void SetValue(ECMOAEDCDGD PFJIPDCNGCE, Rigidbody IOALKPFEKEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x832AB00", Offset = "0x8329B00", VA = "0x18832AB00")]
	public PIPHKKBILMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal class GPHDFHMJBCO : ContainerPropertyBag<ONJEDDFMHMA>
{
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	private class IOIOBBGNONN : Property<ONJEDDFMHMA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string GHLJANJDNGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x8329430", Offset = "0x8328430", VA = "0x188329430", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool COBLKMLKMPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x83293F0", Offset = "0x83283F0", VA = "0x1883293F0")]
		public IOIOBBGNONN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8328650", Offset = "0x8327650", VA = "0x188328650", Slot = "14")]
		public override object GetValue(ONJEDDFMHMA PFJIPDCNGCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8328670", Offset = "0x8327670", VA = "0x188328670", Slot = "15")]
		public override void SetValue(ONJEDDFMHMA PFJIPDCNGCE, object IOALKPFEKEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8328F10", Offset = "0x8327F10", VA = "0x188328F10")]
	public GPHDFHMJBCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal class AAGJFNKPBLI : ContainerPropertyBag<NFMOKHEKIEI>
{
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	private class OJNBIDCHHPE : Property<NFMOKHEKIEI, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string GHLJANJDNGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x832A570", Offset = "0x8329570", VA = "0x18832A570", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool COBLKMLKMPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x832A530", Offset = "0x8329530", VA = "0x18832A530")]
		public OJNBIDCHHPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8328650", Offset = "0x8327650", VA = "0x188328650", Slot = "14")]
		public override object GetValue(NFMOKHEKIEI PFJIPDCNGCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8328670", Offset = "0x8327670", VA = "0x188328670", Slot = "15")]
		public override void SetValue(NFMOKHEKIEI PFJIPDCNGCE, object IOALKPFEKEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x83281E0", Offset = "0x83271E0", VA = "0x1883281E0")]
	public AAGJFNKPBLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
internal class AEOEHDMADPF : ContainerPropertyBag<NFELBKMEDLJ>
{
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	private class GIAOCKAAOIG : Property<NFELBKMEDLJ, Entity>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string GHLJANJDNGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x8328E30", Offset = "0x8327E30", VA = "0x188328E30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool COBLKMLKMPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8328DF0", Offset = "0x8327DF0", VA = "0x188328DF0")]
		public GIAOCKAAOIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xAC9CC0", Offset = "0xAC8CC0", VA = "0x180AC9CC0", Slot = "14")]
		public override Entity GetValue(NFELBKMEDLJ PFJIPDCNGCE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8328DE0", Offset = "0x8327DE0", VA = "0x188328DE0", Slot = "15")]
		public override void SetValue(NFELBKMEDLJ PFJIPDCNGCE, Entity IOALKPFEKEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8328360", Offset = "0x8327360", VA = "0x188328360")]
	public AEOEHDMADPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class AADPANFLFAD : ContainerPropertyBag<Entity>
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	private class PJLCIKFDADL : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string GHLJANJDNGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x832AC20", Offset = "0x8329C20", VA = "0x18832AC20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool COBLKMLKMPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x832ABE0", Offset = "0x8329BE0", VA = "0x18832ABE0")]
		public PJLCIKFDADL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x13E2180", Offset = "0x13E1180", VA = "0x1813E2180", Slot = "14")]
		public override int GetValue(Entity PFJIPDCNGCE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8112900", Offset = "0x8111900", VA = "0x188112900", Slot = "15")]
		public override void SetValue(Entity PFJIPDCNGCE, int IOALKPFEKEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private class EODBEBNHKEL : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string GHLJANJDNGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x8328A00", Offset = "0x8327A00", VA = "0x188328A00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool COBLKMLKMPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x83289C0", Offset = "0x83279C0", VA = "0x1883289C0")]
		public EODBEBNHKEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1364A90", Offset = "0x1363A90", VA = "0x181364A90", Slot = "14")]
		public override int GetValue(Entity PFJIPDCNGCE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x83289B0", Offset = "0x83279B0", VA = "0x1883289B0", Slot = "15")]
		public override void SetValue(Entity PFJIPDCNGCE, int IOALKPFEKEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x83280A0", Offset = "0x83270A0", VA = "0x1883280A0")]
	public AADPANFLFAD()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x832ACE0", Offset = "0x8329CE0", VA = "0x18832ACE0")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public class HLGNEFPMHEK
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public HLGNEFPMHEK()
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
