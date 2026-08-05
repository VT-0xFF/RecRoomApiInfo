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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0x815D1E0", Offset = "0x815B7E0", VA = "0x18815D1E0", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x815D590", Offset = "0x815BB90", VA = "0x18815D590", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x282D140", Offset = "0x282B740", VA = "0x18282D140")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
[TypeManager.ForcedStableTypeHash(1586941204353847852uL)]
public struct LAMLFLGPOMF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
[TypeManager.ForcedStableTypeHash(1730701010008160003uL)]
public struct PIALPLDDEIL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
[TypeManager.ForcedStableTypeHash(3399609037308777919uL)]
public struct HAFADKIPLGL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
[TypeManager.ForcedStableTypeHash(18083619841998483100uL)]
public struct KBOOJMCPLAM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
[TypeManager.ForcedStableTypeHash(12361415346715948123uL)]
public struct LFDMMGNMGPJ : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[InternalBufferCapacity(8)]
	[TypeManager.ForcedStableTypeHash(15820941866177188261uL)]
	public struct AuthoredChildBuffer : IBufferElementData, IEquatable<AuthoredChildBuffer>, KEIBPJAJHEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x815A080", Offset = "0x8158680", VA = "0x18815A080", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD2DDD0", Offset = "0xD2C3D0", VA = "0x180D2DDD0")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
[TypeManager.ForcedStableTypeHash(7794731847884836165uL)]
public struct JJNKGCBACHF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
[TypeManager.ForcedStableTypeHash(16414266906034106824uL)]
public struct PBLCJGPDDPM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[TypeManager.ForcedStableTypeHash(1525018888797798356uL)]
public struct OMPBFEMGKGB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Entity HHGOLDGLHLC;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[TypeManager.ForcedStableTypeHash(6294257411443737851uL)]
public struct CJKAMIKINPC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity HHGOLDGLHLC;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct BDALEHGGBEB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<FBPBLJLJIEN> CFOPGKCHBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<Entity> AGFONCOCKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private JobHandle JNHDFACBLOI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool MAFFJMNGDOB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x815A2E0", Offset = "0x81588E0", VA = "0x18815A2E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int DFHEGHDHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x815A110", Offset = "0x8158710", VA = "0x18815A110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5EE2D90", Offset = "0x5EE1390", VA = "0x185EE2D90")]
	public BDALEHGGBEB(NativeList<FBPBLJLJIEN> CFOPGKCHBKP, NativeList<Entity> AGFONCOCKHE, JobHandle JNHDFACBLOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x815A1C0", Offset = "0x81587C0", VA = "0x18815A1C0")]
	public (Entity, NativeSlice<Entity>) FEJEPEKGGKK(int LGMBEINIKOB)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x815A160", Offset = "0x8158760", VA = "0x18815A160", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct FBPBLJLJIEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Entity CMAFOEIBEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int MOBKDJHFHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int PHABMFMJBEC;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface PMADPENEMKM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DJBHANEGFJP(bool CDDPBGBOMKO);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct NDHDGBELFKK : IEquatable<NDHDGBELFKK>
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate bool JMMEKLMIHEG(int HFCJPLHKMHP);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly bool NHLNPEKMGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool IPFAOLNNHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool KHCGCDOCHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool AIDLFDCAEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly JMMEKLMIHEG BLJPFHGHMOC;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x815C730", Offset = "0x815AD30", VA = "0x18815C730")]
	public NDHDGBELFKK(HMMDHBIHKAK ENCLHPAOMCM, JMMEKLMIHEG BLJPFHGHMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x815C780", Offset = "0x815AD80", VA = "0x18815C780")]
	public NDHDGBELFKK(bool NHLNPEKMGJJ, bool IPFAOLNNHHH, bool KHCGCDOCHHF, bool AIDLFDCAEMP, JMMEKLMIHEG BLJPFHGHMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x815C520", Offset = "0x815AB20", VA = "0x18815C520")]
	public bool GGPCOAHNLBI(int HFCJPLHKMHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x815C640", Offset = "0x815AC40", VA = "0x18815C640")]
	public bool MGCFDCIFCHK(int HFCJPLHKMHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x815C610", Offset = "0x815AC10", VA = "0x18815C610")]
	public bool KGMIDCPMFEP(int HFCJPLHKMHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x815C670", Offset = "0x815AC70", VA = "0x18815C670")]
	public bool OJNOCDHHNFM(int HFCJPLHKMHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x815C440", Offset = "0x815AA40", VA = "0x18815C440", Slot = "4")]
	public bool Equals(NDHDGBELFKK HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x815C470", Offset = "0x815AA70", VA = "0x18815C470", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x815C550", Offset = "0x815AB50", VA = "0x18815C550", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x815C5F0", Offset = "0x815ABF0", VA = "0x18815C5F0")]
	private bool HOFIGOOMGKN(int HFCJPLHKMHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x815C6A0", Offset = "0x815ACA0", VA = "0x18815C6A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class AMMDPNFPBPA : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public ODCNDAHGGBA IIMFJJALMBC;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x815A010", Offset = "0x8158610", VA = "0x18815A010", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public AMMDPNFPBPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface ODCNDAHGGBA
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[TypeManager.ForcedStableTypeHash(8332665118338960440uL)]
public struct MOKJCKJLALI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity OAEHHMPCJJE;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[TypeManager.ForcedStableTypeHash(8981907371573408222uL)]
public struct ODNNMMBAMLJ : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Entity IJIMFHHDLCC;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[TypeManager.ForcedStableTypeHash(17354288130755581458uL)]
public struct DOBHBDMLMPP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Entity CEGHBGBIDOB;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[TypeManager.ForcedStableTypeHash(10748250521618087564uL)]
public struct CAEJLDNLONB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public bool NOAKBLHKEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool KHHMBAGLBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public int DBJIEIDKLLJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
[TypeManager.ForcedStableTypeHash(3379294255511517190uL)]
public struct BHGCEIIFKNN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[TypeManager.ForcedStableTypeHash(4520164298937563310uL)]
[SingletonComponent]
public struct DFIAKMPCOIL : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public Entity DFPJIKCEODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public Entity FNPEPAJGAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public Entity KBKNDCKDFHJ;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[TypeManager.ForcedStableTypeHash(8968007509158485045uL)]
public struct HMMOGEMMCKM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public Entity JGDCHGNDPLC;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[TypeManager.ForcedStableTypeHash(4138010451634514615uL)]
public struct KKOILFMEKOM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float3 NHLFNDFGAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public quaternion CFFPEJBOBIA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
[TypeManager.ForcedStableTypeHash(1690080301203719739uL)]
public struct ABNGCBJFNJB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.ForcedStableTypeHash(13667964378929084748uL)]
public readonly struct NMGJNGNMMNP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly DDFIENOCKAC OBDNOCEBGEH;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3050230", Offset = "0x304E830", VA = "0x183050230")]
	public NMGJNGNMMNP(DDFIENOCKAC OBDNOCEBGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x815C7B0", Offset = "0x815ADB0", VA = "0x18815C7B0")]
	public NMGJNGNMMNP DBLOAMCAFCJ(DDFIENOCKAC PNCBEDEKAGM)
	{
		return default(NMGJNGNMMNP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x815C7C0", Offset = "0x815ADC0", VA = "0x18815C7C0")]
	public NMGJNGNMMNP PKEIADEMJPI(DDFIENOCKAC FFMFJIBHGPP)
	{
		return default(NMGJNGNMMNP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x815C7D0", Offset = "0x815ADD0", VA = "0x18815C7D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[Flags]
public enum DDFIENOCKAC : ushort
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
public static class FCBGKEMFDMC
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[TypeManager.ForcedStableTypeHash(1995886936411817354uL)]
[SingletonComponent]
public struct MMDHEHHLMML : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public DDFIENOCKAC PEDEDMGEIDO;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x815C290", Offset = "0x815A890", VA = "0x18815C290")]
	public bool JDFFHFJGFKA(NMGJNGNMMNP OLOIBJCPMPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x815C270", Offset = "0x815A870", VA = "0x18815C270")]
	public bool CBAJBCAAMLE(NMGJNGNMMNP OLOIBJCPMPH, DDFIENOCKAC OJHELHHCONP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Flags]
public enum LHNJKCOHCNA : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(12096894998449299302uL)]
public struct EMAJFCCNLCM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public LHNJKCOHCNA OBDNOCEBGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public bool MPFGLJFOGBO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool EOBMALPKPPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x815AEC0", Offset = "0x81594C0", VA = "0x18815AEC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x815AEF0", Offset = "0x81594F0", VA = "0x18815AEF0")]
	private EMAJFCCNLCM(LHNJKCOHCNA OBDNOCEBGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x815AEA0", Offset = "0x81594A0", VA = "0x18815AEA0")]
	public EMAJFCCNLCM DBLOAMCAFCJ(LHNJKCOHCNA PNCBEDEKAGM)
	{
		return default(EMAJFCCNLCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x815AED0", Offset = "0x81594D0", VA = "0x18815AED0")]
	public EMAJFCCNLCM PKEIADEMJPI(LHNJKCOHCNA FFMFJIBHGPP)
	{
		return default(EMAJFCCNLCM);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
[TypeManager.ForcedStableTypeHash(3210980466644930997uL)]
public struct FEAKHGPOMPH : IComponentData
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
public struct AMBENELBIJB : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Entity EOLDHPOBFCC;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[InternalBufferCapacity(8)]
	[TypeManager.ForcedStableTypeHash(2803523268494646145uL)]
	public struct ChildBuffer : IBufferElementData, IEquatable<ChildBuffer>, KEIBPJAJHEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x815A080", Offset = "0x8158680", VA = "0x18815A080", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD2DDD0", Offset = "0xD2C3D0", VA = "0x180D2DDD0")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[TypeManager.ForcedStableTypeHash(6734819606313844273uL)]
[SingletonComponent]
public struct HGFDBFEFOMO : ISystemStateBufferElementData, IBufferElementData, KEIBPJAJHEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Entity DFPJIKCEODG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Entity KFJKIONEHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[TypeManager.ForcedStableTypeHash(10606242260416974827uL)]
public struct IILKJDLONMP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Entity KGMPCAJKLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Entity FICBAJJDPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Entity BNKOGHBKOAF;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct HMFOANOFDKK<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static readonly bool LAPKEHOOABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public uint PKMGDJPHKML;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	private static bool CIKMOKGDFHP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[TypeManager.ForcedStableTypeHash(8255844827150930234uL)]
public struct NGJILLALEDA : IBufferElementData, IEquatable<NGJILLALEDA>, KEIBPJAJHEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Entity ECBGJFILJAH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private Entity MDMNDBKKBBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x815A080", Offset = "0x8158680", VA = "0x18815A080", Slot = "4")]
	public bool Equals(NGJILLALEDA HOPHFOOKMCC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[TypeManager.TypeVersion(2)]
[TypeManager.ForcedStableTypeHash(14518013333183728344uL)]
public struct PBOLJEHJOJC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public uint DEPHFAPMMPF;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x14544D0", Offset = "0x1452AD0", VA = "0x1814544D0")]
	public PBOLJEHJOJC(DAAPNACEHGA EILOFNMLIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x815C8A0", Offset = "0x815AEA0", VA = "0x18815C8A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x202D230", Offset = "0x202B830", VA = "0x18202D230")]
	public static PBOLJEHJOJC EIMKEBEILPD(DAAPNACEHGA EILOFNMLIOM)
	{
		return default(PBOLJEHJOJC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[TypeManager.ForcedStableTypeHash(12631852336897389638uL)]
public struct PNNGKKHICCG : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Entity DFPJIKCEODG;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[TypeManager.ForcedStableTypeHash(8586426759787957142uL)]
public struct DBDOHLENMGN : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public DAAPNACEHGA KKGBKLFKCPO;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[TypeManager.ForcedStableTypeHash(3916218676170013300uL)]
public struct GCBOFIPIDJP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Entity DFPJIKCEODG;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[TypeManager.ForcedStableTypeHash(3395423174463894753uL)]
public struct PKKKABPPFKC : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Guid PPIICOOCLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public int FOAMCIPOLAA;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[TypeManager.ForcedStableTypeHash(13485578171010875955uL)]
public struct LOHCONDPPBI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public int KKGBKLFKCPO;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[TypeManager.ForcedStableTypeHash(11182407275731589027uL)]
public struct OOODLKPJEON : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Entity DFPJIKCEODG;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[TypeManager.ForcedStableTypeHash(238571310055566811uL)]
public struct JBLIOAHPAIA : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public DAAPNACEHGA KKGBKLFKCPO;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[TypeManager.ForcedStableTypeHash(17943708062286791581uL)]
public struct DJKKOGLENMD : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Entity DFPJIKCEODG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
[TypeManager.ForcedStableTypeHash(17717774548790709874uL)]
public struct IJIDIPMHBJB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(1628423395607207516uL)]
public struct CGGCEEOKKFI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int JOODKCBLNMG;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[TypeManager.ForcedStableTypeHash(6255673600552782006uL)]
public struct FPCCHJAKJND : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int HKLGEDHKAEJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public PECONNHPBAN MKFPDJMEAIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xC04EB0", Offset = "0xC034B0", VA = "0x180C04EB0")]
		get
		{
			return default(PECONNHPBAN);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[TypeManager.ForcedStableTypeHash(7921165883083593916uL)]
public struct MGDAIMAONJA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public GCHandle FNPIFKNLHIH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
[TypeManager.ForcedStableTypeHash(14965811366685608319uL)]
public struct HCMOIHMPDLL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003B")]
[TypeManager.ForcedStableTypeHash(8376615066990205632uL)]
public struct LBBEGNMNCAC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003C")]
[TypeManager.ForcedStableTypeHash(7273320061473429398uL)]
public struct AGMEJDPHNHL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003D")]
[TypeManager.ForcedStableTypeHash(15140206241145976177uL)]
public struct LEDNOPJHFHB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003E")]
[TypeManager.ForcedStableTypeHash(15969631250552901108uL)]
public struct DENOCMIFIBC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[TypeManager.ForcedStableTypeHash(9353178840587053763uL)]
public struct KKIMHEKOLIG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public int KHMHPNKMLMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public int PFGEKBLLNEL;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x815BED0", Offset = "0x815A4D0", VA = "0x18815BED0")]
	public KKIMHEKOLIG(Entity DFPJIKCEODG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[TypeManager.ForcedStableTypeHash(16229383422209788655uL)]
public struct LGGOABPBJFB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public CollisionDetectionMode AFOAOPLOAGH;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[TypeManager.ForcedStableTypeHash(5173865590150727846uL)]
[RegisterComponentDefault]
public struct DCMHCMBFNIL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public LNDADOOHAMM OMEOLKCEJJI;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly DCMHCMBFNIL JLODNOEBAIE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000042")]
[TypeManager.ForcedStableTypeHash(7051356195299730219uL)]
public struct ELAHMPAHHBG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000043")]
[TypeManager.ForcedStableTypeHash(780557526766205634uL)]
public struct KPOHFMKFOBE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000044")]
[TypeManager.ForcedStableTypeHash(16413322458062516985uL)]
public struct NKNPBNHJLLN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[InternalBufferCapacity(0)]
[TypeManager.ForcedStableTypeHash(8350832327674051347uL)]
public struct FBPNGJHGEKF : IBufferElementData, IEquatable<FBPNGJHGEKF>, KEIBPJAJHEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Entity JDOHELGNGHJ;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity MDMNDBKKBBG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x815A080", Offset = "0x8158680", VA = "0x18815A080", Slot = "4")]
	public bool Equals(FBPNGJHGEKF HOPHFOOKMCC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[TypeManager.ForcedStableTypeHash(3503423083784418805uL)]
public struct BBCLGNKKIBA : IComponentData, KEIBPJAJHEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public Entity NBIJLPJHNNE;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Entity MDMNDBKKBBG
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
[TypeManager.ForcedStableTypeHash(14551834985136520975uL)]
public struct LPAKIEKFCCJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[TypeManager.ForcedStableTypeHash(4388378139562737487uL)]
public struct BFJBAEKLKHM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Entity CMAFOEIBEKN;
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct OLBLLFEACNG : HOMABKLJMOO, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public INJKFEIDPBK MFPDAEKCEDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(INJKFEIDPBK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[TypeManager.ForcedStableTypeHash(769086036388751339uL)]
public struct ENMKJEEBHHP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public float3 JAAELCGHBGB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004B")]
[TypeManager.ForcedStableTypeHash(15638082890667179775uL)]
public struct ALJMAOGDACL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(7040629969868025973uL)]
public struct DJHFAGBBPPE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public float3x3 IOMBHEPGNNK;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly DJHFAGBBPPE JLODNOEBAIE;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[TypeManager.ForcedStableTypeHash(1290915447730818204uL)]
[RegisterComponentDefault]
public struct CLECJPLEDAE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public float3x3 IOMBHEPGNNK;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly CLECJPLEDAE JLODNOEBAIE;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[TypeManager.ForcedStableTypeHash(7667208078276643555uL)]
public struct PDAGJMMNKHF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float3 HPGGNODINIP;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[TypeManager.ForcedStableTypeHash(11475279934298573286uL)]
public struct DKAEBHINFED : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public float3 HJEKPCDABLB;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(18413785019621221410uL)]
public struct PICNLCGNHCF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float FLOJFPALIGF;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly PICNLCGNHCF JLODNOEBAIE;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(16788150452972582455uL)]
public struct MAGHCFJAABP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public float HOFHDHKPJLP;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly MAGHCFJAABP JLODNOEBAIE;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[TypeManager.ForcedStableTypeHash(971312552983123380uL)]
public struct PEELBGDAPAD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 FFFCNAKBILH;
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[TypeManager.ForcedStableTypeHash(361641396811542242uL)]
public struct EDKNIMEOAMI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public PHONBPAKPKN FFFBJJCPKNN;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[TypeManager.ForcedStableTypeHash(7520974846918069913uL)]
[SingletonComponent]
public struct LDLMLBDDKDC : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public Entity DFPJIKCEODG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
[TypeManager.ForcedStableTypeHash(9260549625364734686uL)]
public struct BDONPJDLCBH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
[TypeManager.ForcedStableTypeHash(469905343419662571uL)]
public struct LEMBPLCBKPH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[TypeManager.ForcedStableTypeHash(7865784707562564105uL)]
public struct AILCJOKHLLN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public RigidbodyConstraints ONGNIJAFIJG;
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[TypeManager.ForcedStableTypeHash(7877027338327956319uL)]
[RegisterComponentDefault]
public struct DJCPLKMDDBJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float KMCPAMNNJNB;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly DJCPLKMDDBJ JLODNOEBAIE;
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[TypeManager.ForcedStableTypeHash(935406425377786813uL)]
public struct LCJAEEFCAIH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float OIDFNHHAEBE;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class LJHKNDAEDFD : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public GameObject KGMBEOBCDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public object GIIIFIPBDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public object EGAHMMLJOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NGNGIBJEHLI PNENHMDGAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Delegate KJAHDKBOMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Delegate PJLMPBIMGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public POIJGDNEEOK<Delegate> IJJJHMJCJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public POIJGDNEEOK<Delegate> MELIADDFKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public POIJGDNEEOK<Delegate> FOPJOPMBDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public POIJGDNEEOK<Delegate> CENCENECGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public POIJGDNEEOK<Delegate> ENNNOPGEEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public POIJGDNEEOK<Delegate> BJHJLCMJFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public POIJGDNEEOK<Delegate> ADNDAAGFBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public POIJGDNEEOK<Delegate> DHCEDLKFFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public POIJGDNEEOK<Delegate> IOOOKKDDBGD;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x815BFA0", Offset = "0x815A5A0", VA = "0x18815BFA0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public LJHKNDAEDFD()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
[TypeManager.ForcedStableTypeHash(9555099704367481551uL)]
public struct JFNBOCHDJAF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
[TypeManager.ForcedStableTypeHash(18165447863202358792uL)]
public struct DICMPKANGLL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[TypeManager.ForcedStableTypeHash(10810926406358250264uL)]
public struct PCMGBKPCNCL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public int NELJHLEOKKO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x202D230", Offset = "0x202B830", VA = "0x18202D230")]
	public static PCMGBKPCNCL EIMKEBEILPD(int KKGBKLFKCPO)
	{
		return default(PCMGBKPCNCL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class CKCHMFKNKJH : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Rigidbody DLDHGDFMDNB;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x815A930", Offset = "0x8158F30", VA = "0x18815A930", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public CKCHMFKNKJH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
[TypeManager.ForcedStableTypeHash(12765569839950265583uL)]
public struct ENIBIAKMBEL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[TypeManager.ForcedStableTypeHash(17236748096909814533uL)]
public struct NCDFEEHNIBC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float3 BOPHMEPMHDE;
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[TypeManager.ForcedStableTypeHash(1288392478539867023uL)]
public struct BGIBBHEPMJI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public float3 OFCFOGHNCGN;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(15102898512288820575uL)]
public struct FPDLNDFPKAE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public float DCJNHHFMMLG;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly FPDLNDFPKAE JLODNOEBAIE;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class OAMMMLADGBO : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public object KEOFODCOAIP;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x815C830", Offset = "0x815AE30", VA = "0x18815C830", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public OAMMMLADGBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class ILDJHGKFNEP : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public object IHAHAMLOGID;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x815BCE0", Offset = "0x815A2E0", VA = "0x18815BCE0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public ILDJHGKFNEP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
[TypeManager.ForcedStableTypeHash(3505189951659289292uL)]
public struct JMLPEGNHNHP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
[TypeManager.ForcedStableTypeHash(16217323095468023009uL)]
public struct NKONADHMEPE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
[TypeManager.ForcedStableTypeHash(12880717127246424414uL)]
public struct AOECGEKCKOA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
[TypeManager.ForcedStableTypeHash(12942629461400744171uL)]
public struct KMIJNMIIIAA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
[TypeManager.ForcedStableTypeHash(10226241216405964379uL)]
public struct HGKDOFNKCKM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
[TypeManager.ForcedStableTypeHash(12400259538654257671uL)]
public struct NPHCAAICGJJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
[TypeManager.ForcedStableTypeHash(12731949941800560397uL)]
public struct FIHCPIAFMKI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
[TypeManager.ForcedStableTypeHash(16270799832065682331uL)]
public struct HJOJBHIGCND : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
[TypeManager.ForcedStableTypeHash(9395080039644288849uL)]
public struct FIPGMGAJGLG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
[TypeManager.ForcedStableTypeHash(15229363233412980908uL)]
public struct BGFEMAGJBJI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[TypeManager.ForcedStableTypeHash(282623311697096978uL)]
public struct PJNKDEHBHHF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NHPHNKOAKCC BHKKMKEIFKE;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x815CA60", Offset = "0x815B060", VA = "0x18815CA60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
[TypeManager.ForcedStableTypeHash(10395819776101408141uL)]
public struct BNEMACGNOCM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
[TypeManager.ForcedStableTypeHash(375953524326549120uL)]
public struct ANCFBGEKHCN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
[TypeManager.ForcedStableTypeHash(14259779488802476986uL)]
public struct NCLBNGICCMK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[TypeManager.ForcedStableTypeHash(15330221065042235480uL)]
public struct PCCDGPECNNC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public FixedString32Bytes IEDAJGLJHNI;
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(5162925656869367991uL)]
public struct DABGIILEEMB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public UnsafeParallelHashMap<NHPHNKOAKCC, Entity> GBPCCKBOLKF;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[TypeManager.ForcedStableTypeHash(9841032716800521808uL)]
public struct FNGDLDIMNAA : ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Entity CKFHGLHHIKG;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[TypeManager.ForcedStableTypeHash(154813247653871879uL)]
internal struct HCNOBLADMDA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Entity DFPJIKCEODG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xD2DDD0", Offset = "0xD2C3D0", VA = "0x180D2DDD0")]
	public static HCNOBLADMDA EIMKEBEILPD(Entity DFPJIKCEODG)
	{
		return default(HCNOBLADMDA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[TypeManager.ForcedStableTypeHash(11656653634719673845uL)]
public struct AGNFLLGDMJE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Entity GBCDPMKDABO;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[TypeManager.ForcedStableTypeHash(1837719173092935466uL)]
public struct NGAIPKCMMID : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Entity GBCDPMKDABO;
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[TypeManager.ForcedStableTypeHash(17382237360022739174uL)]
internal struct CIHFMFPGJJO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Entity JDOCKADAINO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xD2DDD0", Offset = "0xD2C3D0", VA = "0x180D2DDD0")]
	public static CIHFMFPGJJO EIMKEBEILPD(Entity DFPJIKCEODG)
	{
		return default(CIHFMFPGJJO);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
[TypeManager.ForcedStableTypeHash(15858722173278118533uL)]
internal struct EPKKFAPKKJD : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[TypeManager.ForcedStableTypeHash(10313790595830381076uL)]
public struct JFJPOFDLFAG : IBufferElementData, IEquatable<JFJPOFDLFAG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Entity OGMCBFMLPDL;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7F56F50", Offset = "0x7F55550", VA = "0x187F56F50", Slot = "4")]
	public bool Equals(JFJPOFDLFAG HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x815BE40", Offset = "0x815A440", VA = "0x18815BE40", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0xC04EB0", Offset = "0xC034B0", VA = "0x180C04EB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[TypeManager.ForcedStableTypeHash(10169361040328370708uL)]
public struct HJKHPBKBAEB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public uint PFGEKBLLNEL;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(11536226225076729790uL)]
internal struct HEJPDOGMIEH : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Entity HNBFFELCEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public int KHMHPNKMLMD;
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[TypeManager.ForcedStableTypeHash(8309037880064337491uL)]
internal struct NDKNNCBIMPK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Entity HPDPKHBCCGD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
[TypeManager.ForcedStableTypeHash(5891816987223099091uL)]
public struct OCANBLEHPMC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[TypeManager.ForcedStableTypeHash(17289298604600812224uL)]
public struct CFFBDMKJGCL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public uint PKMGDJPHKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public int BCAAEABIFHI;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xDF17C0", Offset = "0xDEFDC0", VA = "0x180DF17C0")]
	public CFFBDMKJGCL(uint EBIKEJNLJCC, int INNDCKAHKOJ)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
[TypeManager.ForcedStableTypeHash(12258100538258701401uL)]
public struct NIEJAECMNAJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
[TypeManager.ForcedStableTypeHash(3081870877980445988uL)]
public struct MMBHNNAPDOF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
[TypeManager.ForcedStableTypeHash(15554741495161407507uL)]
public struct MHFNPMGLLCC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
[TypeManager.ForcedStableTypeHash(17684057078056878475uL)]
public struct OIGOGMLMILG : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000085")]
[TypeManager.ForcedStableTypeHash(10023455309444528896uL)]
public struct BHMPECLAAKC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
[TypeManager.ForcedStableTypeHash(14403752119546393228uL)]
public struct KJHFMGMDPPO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
[TypeManager.ForcedStableTypeHash(9219181242087356214uL)]
public struct PBCNLCDFOBN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
[TypeManager.ForcedStableTypeHash(12371658133244024718uL)]
public struct LHJHNJKKAGF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
[TypeManager.ForcedStableTypeHash(9351414359236295489uL)]
public struct DDEJLPHFGBE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
[TypeManager.ForcedStableTypeHash(12796707860320869007uL)]
internal struct FHHNJEIHKOF : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
[TypeManager.ForcedStableTypeHash(13367368557807690484uL)]
public struct OKJHJOBINHN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008C")]
[TypeManager.ForcedStableTypeHash(7193071459223094579uL)]
public struct DCHHFDLHIKK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
[TypeManager.ForcedStableTypeHash(17039127292426947163uL)]
public struct GDNPGCJIFMH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008E")]
[TypeManager.ForcedStableTypeHash(15247343901949961769uL)]
public struct FJFFJFNHJGK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
[TypeManager.ForcedStableTypeHash(5381043565870728787uL)]
public struct PGJDGIPJFDO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
[TypeManager.ForcedStableTypeHash(11597028615900234104uL)]
internal struct MLOECDONJKK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
[TypeManager.ForcedStableTypeHash(1907494159895213433uL)]
internal struct LCLOAOBMBJK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000092")]
[TypeManager.ForcedStableTypeHash(3955886960983597628uL)]
public struct MJBKGPPPCAG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000093")]
[TypeManager.ForcedStableTypeHash(480620745253244652uL)]
public struct AJENCABNLNB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000094")]
[TypeManager.ForcedStableTypeHash(8253675824478287824uL)]
public struct FEMNBIALNAP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000095")]
[TypeManager.ForcedStableTypeHash(8855488771047251567uL)]
public struct GDDIFBJNFBM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000096")]
[TypeManager.ForcedStableTypeHash(8375777954271012995uL)]
public struct GIGDCKHJPFB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
[TypeManager.ForcedStableTypeHash(16778215356980427836uL)]
public struct DMGKBKBHHLD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000098")]
[TypeManager.ForcedStableTypeHash(16444804027614993581uL)]
public struct BOBFGFIILHK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000099")]
[TypeManager.ForcedStableTypeHash(16177323740107409537uL)]
public struct OHMIKMHNIOE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
[TypeManager.ForcedStableTypeHash(11049752089067741804uL)]
public struct OALLIAJLKFN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009B")]
[TypeManager.ForcedStableTypeHash(1453937769327886583uL)]
public struct AJNPDAAOIJJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
[TypeManager.ForcedStableTypeHash(800754555681830909uL)]
public struct OIBNBNBDGOO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009D")]
[TypeManager.ForcedStableTypeHash(3336901602667819150uL)]
public struct COAPGCFCKIM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009E")]
[TypeManager.ForcedStableTypeHash(11809750536411032401uL)]
public struct KKMDDPKHMJL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
[TypeManager.ForcedStableTypeHash(6387004770090400669uL)]
public struct EMEKOLIIAHO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[TypeManager.ForcedStableTypeHash(2223159712203397538uL)]
internal struct JCMKIOAAPJL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[TypeManager.ForcedStableTypeHash(10153397523300334327uL)]
public struct COENEDKBFLC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[TypeManager.ForcedStableTypeHash(12983102201306073842uL)]
public struct DNFMKOECPJE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[TypeManager.ForcedStableTypeHash(15398959433761599914uL)]
[LGOEDLFAKIN]
public struct MNGEHGJDJNK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6605318152550716456uL)]
public struct HEDAACIEHCP : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public FixedString32Bytes MFGALGGOPCB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[TypeManager.ForcedStableTypeHash(10065634662848845784uL)]
public struct AJNIDPGLOBE : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[TypeManager.ForcedStableTypeHash(15062299176839263439uL)]
public struct NJNHLPGDJLG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[TypeManager.ForcedStableTypeHash(3596269116834888123uL)]
internal struct JMFCLFBOJKA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[TypeManager.ForcedStableTypeHash(4402941654898007496uL)]
internal struct BEIHCJEIGFM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[TypeManager.ForcedStableTypeHash(12682474121528142025uL)]
internal struct GDELIKKILNF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[TypeManager.ForcedStableTypeHash(1840266485562743455uL)]
public struct JFBBOAAOMCF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[TypeManager.ForcedStableTypeHash(4772574226205567794uL)]
public struct EEJDOFPKFII : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[TypeManager.ForcedStableTypeHash(17642911464827038147uL)]
public struct DBDGODMIKEH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public quaternion CFFPEJBOBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public float3 NHLFNDFGAHK;
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[TypeManager.ForcedStableTypeHash(9066921186040058989uL)]
public struct LHAKKOFBNHM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public float HNGABDOPJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public float IGEMHECKPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public float PNEDGMKHNJC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[TypeManager.ForcedStableTypeHash(3328998613642473514uL)]
public struct NIGHJHHABLG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[TypeManager.ForcedStableTypeHash(151116349382904900uL)]
public struct DJFBLIODKIO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[TypeManager.ForcedStableTypeHash(8067675582152570601uL)]
public struct BLLLNIHLLLH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[TypeManager.ForcedStableTypeHash(4522686316477281096uL)]
public struct KAIDOANOKBE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public int HKLGEDHKAEJ;
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[SingletonComponent]
[TypeManager.ForcedStableTypeHash(6216404920432680992uL)]
public struct FJLLLKDAKNA : ISystemStateBufferElementData, IBufferElementData, KEIBPJAJHEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public Entity OLLPKLKPIGH;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity KFJKIONEHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(419884688393735449uL)]
public struct GHBPPFOEOBH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public float4x4 LJJLNHPLEGG;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly GHBPPFOEOBH JLODNOEBAIE;
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[RegisterComponentDefault]
[TypeManager.ForcedStableTypeHash(1954795745923300919uL)]
public struct MKLNGNFLMDB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public float4x4 GOCIIHLDDEK;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly MKLNGNFLMDB JLODNOEBAIE;
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[TypeManager.ForcedStableTypeHash(2447627752265109178uL)]
public struct MMCIDCLGPEN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int PCFIGLBGPCH;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int KHMHPNKMLMD
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x815C260", Offset = "0x815A860", VA = "0x18815C260")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x815C250", Offset = "0x815A850", VA = "0x18815C250")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[TypeManager.ForcedStableTypeHash(13706996280046618062uL)]
[RegisterComponentDefault]
public struct BECLBBIGBNM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public float3 NHLFNDFGAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public quaternion CFFPEJBOBIA;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public static readonly BECLBBIGBNM JLODNOEBAIE;
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class LMGAGGBCBLB
{
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[TypeManager.ForcedStableTypeHash(77694943841979493uL)]
[RegisterComponentDefault]
public struct IMJEAILGDMB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public float ALLNOMJDKNH;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public static readonly IMJEAILGDMB JLODNOEBAIE;
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[TypeManager.ForcedStableTypeHash(6537711325103434903uL)]
public struct JNACJGPJJOF : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public Entity HLMMJBEMNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public JGNPJEKDJKO PDFIFNAMHFC;
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[TypeManager.ForcedStableTypeHash(5471640964865828061uL)]
public struct DHCKFLDLLGD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public JGNPJEKDJKO PDFIFNAMHFC;
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[TypeManager.ForcedStableTypeHash(16527934868211432802uL)]
public struct FDPKHEOGCME : ISystemStateComponentData, IComponentData, KEIBPJAJHEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public Entity FMBOIKGHIFL;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Entity KFJKIONEHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[TypeManager.ForcedStableTypeHash(15310407062508355916uL)]
public struct MFDJEMEFMIA : ISystemStateBufferElementData, IBufferElementData, KEIBPJAJHEF, IEquatable<MFDJEMEFMIA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Entity AGLOFMHINAJ;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Entity KFJKIONEHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7F56F50", Offset = "0x7F55550", VA = "0x187F56F50", Slot = "6")]
	public bool Equals(MFDJEMEFMIA HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x815C110", Offset = "0x815A710", VA = "0x18815C110", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xC04EB0", Offset = "0xC034B0", VA = "0x180C04EB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[TypeManager.ForcedStableTypeHash(11786768220100978132uL)]
public struct FKJGCDJGHPA : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public Entity HLMMJBEMNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public JGNPJEKDJKO PDFIFNAMHFC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public struct JDBGMMDKBKH : IEqualityComparer<FKJGCDJGHPA>
{
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public static JDBGMMDKBKH JLODNOEBAIE;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x815BD90", Offset = "0x815A390", VA = "0x18815BD90", Slot = "4")]
	public bool Equals(FKJGCDJGHPA POMHCCBBBGD, FKJGCDJGHPA JKKMGDMGNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x815BDE0", Offset = "0x815A3E0", VA = "0x18815BDE0", Slot = "5")]
	public int GetHashCode(FKJGCDJGHPA ODCICEDDLMB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[TypeManager.ForcedStableTypeHash(8981997360983277121uL)]
public struct IIKNGPOLAIK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public FixedList32Bytes<int> FDNFPDAMLJB;
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[TypeManager.ForcedStableTypeHash(2801212869002544047uL)]
public struct BNPDNPMHIIE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public FixedList32Bytes<int> FDNFPDAMLJB;
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[TypeManager.ForcedStableTypeHash(16455485691096333919uL)]
public struct DOPOEGFLJGE : ISystemStateBufferElementData, IBufferElementData, KEIBPJAJHEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Entity NPGONMICHFD;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Entity MDMNDBKKBBG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8A20", Offset = "0xDE7020", VA = "0x180DE8A20", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x12D6610", Offset = "0x12D4C10", VA = "0x1812D6610", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal class LKFODGHDFDM : ContainerPropertyBag<AMMDPNFPBPA>
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private class AGDHMCFCEII : Property<AMMDPNFPBPA, ODCNDAHGGBA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string GKIMNFGPLMB
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8159F00", Offset = "0x8158500", VA = "0x188159F00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool KJKCBDBHHDL
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8159EC0", Offset = "0x81584C0", VA = "0x188159EC0")]
		public AGDHMCFCEII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8159E70", Offset = "0x8158470", VA = "0x188159E70", Slot = "14")]
		public override ODCNDAHGGBA GetValue(AMMDPNFPBPA FAIEEFHMPLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8159E90", Offset = "0x8158490", VA = "0x188159E90", Slot = "15")]
		public override void SetValue(AMMDPNFPBPA FAIEEFHMPLL, ODCNDAHGGBA KKGBKLFKCPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x815BFF0", Offset = "0x815A5F0", VA = "0x18815BFF0")]
	public LKFODGHDFDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
internal class EPGCHGCAHCL : ContainerPropertyBag<LJHKNDAEDFD>
{
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private class FLMIOFAIKAN : Property<LJHKNDAEDFD, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string GKIMNFGPLMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x815B660", Offset = "0x8159C60", VA = "0x18815B660", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool KJKCBDBHHDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x815B620", Offset = "0x8159C20", VA = "0x18815B620")]
		public FLMIOFAIKAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8159E70", Offset = "0x8158470", VA = "0x188159E70", Slot = "14")]
		public override GameObject GetValue(LJHKNDAEDFD FAIEEFHMPLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8159E90", Offset = "0x8158490", VA = "0x188159E90", Slot = "15")]
		public override void SetValue(LJHKNDAEDFD FAIEEFHMPLL, GameObject KKGBKLFKCPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	private class NBFGLNBCEBA : Property<LJHKNDAEDFD, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string GKIMNFGPLMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x815C410", Offset = "0x815AA10", VA = "0x18815C410", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool KJKCBDBHHDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x815C3D0", Offset = "0x815A9D0", VA = "0x18815C3D0")]
		public NBFGLNBCEBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x815C380", Offset = "0x815A980", VA = "0x18815C380", Slot = "14")]
		public override object GetValue(LJHKNDAEDFD FAIEEFHMPLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x815C3A0", Offset = "0x815A9A0", VA = "0x18815C3A0", Slot = "15")]
		public override void SetValue(LJHKNDAEDFD FAIEEFHMPLL, object KKGBKLFKCPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	private class FJADMHGLKDP : Property<LJHKNDAEDFD, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string GKIMNFGPLMB
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x815B5F0", Offset = "0x8159BF0", VA = "0x18815B5F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool KJKCBDBHHDL
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x815B5B0", Offset = "0x8159BB0", VA = "0x18815B5B0")]
		public FJADMHGLKDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x815B560", Offset = "0x8159B60", VA = "0x18815B560", Slot = "14")]
		public override object GetValue(LJHKNDAEDFD FAIEEFHMPLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x815B580", Offset = "0x8159B80", VA = "0x18815B580", Slot = "15")]
		public override void SetValue(LJHKNDAEDFD FAIEEFHMPLL, object KKGBKLFKCPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	private class BDDHDOALOCF : Property<LJHKNDAEDFD, NGNGIBJEHLI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string GKIMNFGPLMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x815A3E0", Offset = "0x81589E0", VA = "0x18815A3E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool KJKCBDBHHDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x815A3A0", Offset = "0x81589A0", VA = "0x18815A3A0")]
		public BDDHDOALOCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x815A350", Offset = "0x8158950", VA = "0x18815A350", Slot = "14")]
		public override NGNGIBJEHLI GetValue(LJHKNDAEDFD FAIEEFHMPLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x815A370", Offset = "0x8158970", VA = "0x18815A370", Slot = "15")]
		public override void SetValue(LJHKNDAEDFD FAIEEFHMPLL, NGNGIBJEHLI KKGBKLFKCPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	private class HGAFAPHHOCJ : Property<LJHKNDAEDFD, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string GKIMNFGPLMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x815B940", Offset = "0x8159F40", VA = "0x18815B940", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool KJKCBDBHHDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x815B900", Offset = "0x8159F00", VA = "0x18815B900")]
		public HGAFAPHHOCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x815B8B0", Offset = "0x8159EB0", VA = "0x18815B8B0", Slot = "14")]
		public override Delegate GetValue(LJHKNDAEDFD FAIEEFHMPLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x815B8D0", Offset = "0x8159ED0", VA = "0x18815B8D0", Slot = "15")]
		public override void SetValue(LJHKNDAEDFD FAIEEFHMPLL, Delegate KKGBKLFKCPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	private class CHKMCCKHDAD : Property<LJHKNDAEDFD, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string GKIMNFGPLMB
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x815A900", Offset = "0x8158F00", VA = "0x18815A900", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool KJKCBDBHHDL
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x815A8C0", Offset = "0x8158EC0", VA = "0x18815A8C0")]
		public CHKMCCKHDAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x815A870", Offset = "0x8158E70", VA = "0x18815A870", Slot = "14")]
		public override Delegate GetValue(LJHKNDAEDFD FAIEEFHMPLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x815A890", Offset = "0x8158E90", VA = "0x18815A890", Slot = "15")]
		public override void SetValue(LJHKNDAEDFD FAIEEFHMPLL, Delegate KKGBKLFKCPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	private class BEEGAGFOIJC : Property<LJHKNDAEDFD, POIJGDNEEOK<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string GKIMNFGPLMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x815A5D0", Offset = "0x8158BD0", VA = "0x18815A5D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool KJKCBDBHHDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x815A590", Offset = "0x8158B90", VA = "0x18815A590")]
		public BEEGAGFOIJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x815A540", Offset = "0x8158B40", VA = "0x18815A540", Slot = "14")]
		public override POIJGDNEEOK<Delegate> GetValue(LJHKNDAEDFD FAIEEFHMPLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x815A560", Offset = "0x8158B60", VA = "0x18815A560", Slot = "15")]
		public override void SetValue(LJHKNDAEDFD FAIEEFHMPLL, POIJGDNEEOK<Delegate> KKGBKLFKCPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	private class IEEKNPFJOBJ : Property<LJHKNDAEDFD, POIJGDNEEOK<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string GKIMNFGPLMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x815BBF0", Offset = "0x815A1F0", VA = "0x18815BBF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool KJKCBDBHHDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x815BBB0", Offset = "0x815A1B0", VA = "0x18815BBB0")]
		public IEEKNPFJOBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x815BB60", Offset = "0x815A160", VA = "0x18815BB60", Slot = "14")]
		public override POIJGDNEEOK<Delegate> GetValue(LJHKNDAEDFD FAIEEFHMPLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x815BB80", Offset = "0x815A180", VA = "0x18815BB80", Slot = "15")]
		public override void SetValue(LJHKNDAEDFD FAIEEFHMPLL, POIJGDNEEOK<Delegate> KKGBKLFKCPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	private class IAGKPKPHPCF : Property<LJHKNDAEDFD, POIJGDNEEOK<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string GKIMNFGPLMB
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x815BA70", Offset = "0x815A070", VA = "0x18815BA70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool KJKCBDBHHDL
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x815BA30", Offset = "0x815A030", VA = "0x18815BA30")]
		public IAGKPKPHPCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x815B9E0", Offset = "0x8159FE0", VA = "0x18815B9E0", Slot = "14")]
		public override POIJGDNEEOK<Delegate> GetValue(LJHKNDAEDFD FAIEEFHMPLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x815BA00", Offset = "0x815A000", VA = "0x18815BA00", Slot = "15")]
		public override void SetValue(LJHKNDAEDFD FAIEEFHMPLL, POIJGDNEEOK<Delegate> KKGBKLFKCPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	private class BMGKLKCNBAN : Property<LJHKNDAEDFD, POIJGDNEEOK<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string GKIMNFGPLMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x815A690", Offset = "0x8158C90", VA = "0x18815A690", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool KJKCBDBHHDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x815A650", Offset = "0x8158C50", VA = "0x18815A650")]
		public BMGKLKCNBAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x815A600", Offset = "0x8158C00", VA = "0x18815A600", Slot = "14")]
		public override POIJGDNEEOK<Delegate> GetValue(LJHKNDAEDFD FAIEEFHMPLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x815A620", Offset = "0x8158C20", VA = "0x18815A620", Slot = "15")]
		public override void SetValue(LJHKNDAEDFD FAIEEFHMPLL, POIJGDNEEOK<Delegate> KKGBKLFKCPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	private class KLPMCHCDBGO : Property<LJHKNDAEDFD, POIJGDNEEOK<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string GKIMNFGPLMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x815BF70", Offset = "0x815A570", VA = "0x18815BF70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool KJKCBDBHHDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x815BF30", Offset = "0x815A530", VA = "0x18815BF30")]
		public KLPMCHCDBGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x815BEE0", Offset = "0x815A4E0", VA = "0x18815BEE0", Slot = "14")]
		public override POIJGDNEEOK<Delegate> GetValue(LJHKNDAEDFD FAIEEFHMPLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x815BF00", Offset = "0x815A500", VA = "0x18815BF00", Slot = "15")]
		public override void SetValue(LJHKNDAEDFD FAIEEFHMPLL, POIJGDNEEOK<Delegate> KKGBKLFKCPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	private class GJENGBLFPMD : Property<LJHKNDAEDFD, POIJGDNEEOK<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string GKIMNFGPLMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x815B810", Offset = "0x8159E10", VA = "0x18815B810", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool KJKCBDBHHDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x815B7D0", Offset = "0x8159DD0", VA = "0x18815B7D0")]
		public GJENGBLFPMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x815B780", Offset = "0x8159D80", VA = "0x18815B780", Slot = "14")]
		public override POIJGDNEEOK<Delegate> GetValue(LJHKNDAEDFD FAIEEFHMPLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x815B7A0", Offset = "0x8159DA0", VA = "0x18815B7A0", Slot = "15")]
		public override void SetValue(LJHKNDAEDFD FAIEEFHMPLL, POIJGDNEEOK<Delegate> KKGBKLFKCPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	private class IKCMMJFBEEN : Property<LJHKNDAEDFD, POIJGDNEEOK<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string GKIMNFGPLMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x815BCB0", Offset = "0x815A2B0", VA = "0x18815BCB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool KJKCBDBHHDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x815BC70", Offset = "0x815A270", VA = "0x18815BC70")]
		public IKCMMJFBEEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x815BC20", Offset = "0x815A220", VA = "0x18815BC20", Slot = "14")]
		public override POIJGDNEEOK<Delegate> GetValue(LJHKNDAEDFD FAIEEFHMPLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x815BC40", Offset = "0x815A240", VA = "0x18815BC40", Slot = "15")]
		public override void SetValue(LJHKNDAEDFD FAIEEFHMPLL, POIJGDNEEOK<Delegate> KKGBKLFKCPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	private class IBJDMNNFLPD : Property<LJHKNDAEDFD, POIJGDNEEOK<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string GKIMNFGPLMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x815BB30", Offset = "0x815A130", VA = "0x18815BB30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool KJKCBDBHHDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x815BAF0", Offset = "0x815A0F0", VA = "0x18815BAF0")]
		public IBJDMNNFLPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x815BAA0", Offset = "0x815A0A0", VA = "0x18815BAA0", Slot = "14")]
		public override POIJGDNEEOK<Delegate> GetValue(LJHKNDAEDFD FAIEEFHMPLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x815BAC0", Offset = "0x815A0C0", VA = "0x18815BAC0", Slot = "15")]
		public override void SetValue(LJHKNDAEDFD FAIEEFHMPLL, POIJGDNEEOK<Delegate> KKGBKLFKCPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	private class CBDBKGAPCEH : Property<LJHKNDAEDFD, POIJGDNEEOK<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string GKIMNFGPLMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x815A7D0", Offset = "0x8158DD0", VA = "0x18815A7D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool KJKCBDBHHDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x815A790", Offset = "0x8158D90", VA = "0x18815A790")]
		public CBDBKGAPCEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x815A740", Offset = "0x8158D40", VA = "0x18815A740", Slot = "14")]
		public override POIJGDNEEOK<Delegate> GetValue(LJHKNDAEDFD FAIEEFHMPLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x815A760", Offset = "0x8158D60", VA = "0x18815A760", Slot = "15")]
		public override void SetValue(LJHKNDAEDFD FAIEEFHMPLL, POIJGDNEEOK<Delegate> KKGBKLFKCPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x815AF00", Offset = "0x8159500", VA = "0x18815AF00")]
	public EPGCHGCAHCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class DHPHNDKINGK : ContainerPropertyBag<POIJGDNEEOK<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x815AAE0", Offset = "0x81590E0", VA = "0x18815AAE0")]
	public DHPHNDKINGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal class PEHIGOLCBNN : ContainerPropertyBag<CKCHMFKNKJH>
{
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	private class CGNBMDHMOIF : Property<CKCHMFKNKJH, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string GKIMNFGPLMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x815A840", Offset = "0x8158E40", VA = "0x18815A840", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool KJKCBDBHHDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x815A800", Offset = "0x8158E00", VA = "0x18815A800")]
		public CGNBMDHMOIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8159E70", Offset = "0x8158470", VA = "0x188159E70", Slot = "14")]
		public override Rigidbody GetValue(CKCHMFKNKJH FAIEEFHMPLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8159E90", Offset = "0x8158490", VA = "0x188159E90", Slot = "15")]
		public override void SetValue(CKCHMFKNKJH FAIEEFHMPLL, Rigidbody KKGBKLFKCPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x815C8D0", Offset = "0x815AED0", VA = "0x18815C8D0")]
	public PEHIGOLCBNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal class EJNPFLJKBAB : ContainerPropertyBag<OAMMMLADGBO>
{
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	private class HAKKMHILCII : Property<OAMMMLADGBO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string GKIMNFGPLMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x815B880", Offset = "0x8159E80", VA = "0x18815B880", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool KJKCBDBHHDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x815B840", Offset = "0x8159E40", VA = "0x18815B840")]
		public HAKKMHILCII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8159E70", Offset = "0x8158470", VA = "0x188159E70", Slot = "14")]
		public override object GetValue(OAMMMLADGBO FAIEEFHMPLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8159E90", Offset = "0x8158490", VA = "0x188159E90", Slot = "15")]
		public override void SetValue(OAMMMLADGBO FAIEEFHMPLL, object KKGBKLFKCPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x815ADC0", Offset = "0x81593C0", VA = "0x18815ADC0")]
	public EJNPFLJKBAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal class AIOBGLJHHFI : ContainerPropertyBag<ILDJHGKFNEP>
{
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	private class PFIOLABBPBJ : Property<ILDJHGKFNEP, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string GKIMNFGPLMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x815C9F0", Offset = "0x815AFF0", VA = "0x18815C9F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool KJKCBDBHHDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x815C9B0", Offset = "0x815AFB0", VA = "0x18815C9B0")]
		public PFIOLABBPBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8159E70", Offset = "0x8158470", VA = "0x188159E70", Slot = "14")]
		public override object GetValue(ILDJHGKFNEP FAIEEFHMPLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8159E90", Offset = "0x8158490", VA = "0x188159E90", Slot = "15")]
		public override void SetValue(ILDJHGKFNEP FAIEEFHMPLL, object KKGBKLFKCPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8159F30", Offset = "0x8158530", VA = "0x188159F30")]
	public AIOBGLJHHFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
internal class MPOKNAEIBNJ : ContainerPropertyBag<FNGDLDIMNAA>
{
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	private class CAANJJJEJDJ : Property<FNGDLDIMNAA, Entity>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string GKIMNFGPLMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x815A710", Offset = "0x8158D10", VA = "0x18815A710", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool KJKCBDBHHDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x815A6D0", Offset = "0x8158CD0", VA = "0x18815A6D0")]
		public CAANJJJEJDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xB14900", Offset = "0xB12F00", VA = "0x180B14900", Slot = "14")]
		public override Entity GetValue(FNGDLDIMNAA FAIEEFHMPLL)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x815A6C0", Offset = "0x8158CC0", VA = "0x18815A6C0", Slot = "15")]
		public override void SetValue(FNGDLDIMNAA FAIEEFHMPLL, Entity KKGBKLFKCPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x815C2A0", Offset = "0x815A8A0", VA = "0x18815C2A0")]
	public MPOKNAEIBNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
internal class EEAGDGGBJKO : ContainerPropertyBag<Entity>
{
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	private class HJHGIBCOBKG : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string GKIMNFGPLMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x815B9B0", Offset = "0x8159FB0", VA = "0x18815B9B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool KJKCBDBHHDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x815B970", Offset = "0x8159F70", VA = "0x18815B970")]
		public HJHGIBCOBKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x236E430", Offset = "0x236CA30", VA = "0x18236E430", Slot = "14")]
		public override int GetValue(Entity FAIEEFHMPLL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7F52450", Offset = "0x7F50A50", VA = "0x187F52450", Slot = "15")]
		public override void SetValue(Entity FAIEEFHMPLL, int KKGBKLFKCPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	private class BANOAGBFBPC : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string GKIMNFGPLMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x815A0E0", Offset = "0x81586E0", VA = "0x18815A0E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool KJKCBDBHHDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x815A0A0", Offset = "0x81586A0", VA = "0x18815A0A0")]
		public BANOAGBFBPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x12E2670", Offset = "0x12E0C70", VA = "0x1812E2670", Slot = "14")]
		public override int GetValue(Entity FAIEEFHMPLL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x815A090", Offset = "0x8158690", VA = "0x18815A090", Slot = "15")]
		public override void SetValue(Entity FAIEEFHMPLL, int KKGBKLFKCPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x815AC80", Offset = "0x8159280", VA = "0x18815AC80")]
	public EEAGDGGBJKO()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x815CAB0", Offset = "0x815B0B0", VA = "0x18815CAB0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public class ILCOKFFEKFJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public ILCOKFFEKFJ()
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
