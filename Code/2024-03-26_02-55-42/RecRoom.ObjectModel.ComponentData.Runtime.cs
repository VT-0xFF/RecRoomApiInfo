using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
using Unity.Collections;
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
		[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
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
	public class _AssemblyIndex : LHJJEIDOJLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x626F920", Offset = "0x626ED20", VA = "0x18626F920", Slot = "8")]
		public override void AOEHIAAJNNJ(EFDDNENJJHG registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x626FD20", Offset = "0x626F120", VA = "0x18626FD20", Slot = "7")]
		public override void NCKPFIILEOC(GLJGJBKFIFJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x626FFF0", Offset = "0x626F3F0", VA = "0x18626FFF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct EFHBKCAJAFB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct EEMNPEFDFGK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public CollisionDetectionMode NBBMDCPNMEI;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[FPPANCDHLGK]
public struct EDIEPFFJPCG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public IKOBMPEJDCL BBOFLCMPDLG;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly EDIEPFFJPCG AEDHDHNAKOP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct APJGCOFLNEA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct FMOOIJBOHCC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum IKOBMPEJDCL
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Invalid = -1
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct AEAGOCEPKEG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[InternalBufferCapacity(0)]
public struct LCHFDGKKPNE : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public Entity FGOLIAHPGNN;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct PLHCHJPMLIM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity NCGFJMKBOIN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct DFKLFBFAFNA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct NKCAMJGOPEO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity BEOJJJNJFFJ;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct BFOGFEKHOHP : NFFCFMODGMN, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public EPABGPMFAGJ MBGNOEBAOGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x88B850", Offset = "0x88AC50", VA = "0x18088B850", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(EPABGPMFAGJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x184DDA0", Offset = "0x184D1A0", VA = "0x18184DDA0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct BDBHFAIJHNJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 NIBFJMPDCMF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct BKJIFEOMENI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[FPPANCDHLGK]
public struct NNIAGDPHLOD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3x3 IAPOJJFMDGL;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly NNIAGDPHLOD AEDHDHNAKOP;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[FPPANCDHLGK]
public struct AFKAPMFHMED : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float3x3 IAPOJJFMDGL;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly AFKAPMFHMED AEDHDHNAKOP;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct PNFBDPCJLFB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public float3 IDBCOIMPIFJ;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct MKCHMKNGKLE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float3 NADKLJLLPJH;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[FPPANCDHLGK]
public struct GDMBDCLOHDC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public float GMHCANBFGBD;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly GDMBDCLOHDC AEDHDHNAKOP;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[FPPANCDHLGK]
public struct EGGIILGLJLP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float IGEEMABBOMG;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly EGGIILGLJLP AEDHDHNAKOP;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct APIBOFJJLAA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float3 HEMIPMNIEBG;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct DLOEHBMJPNM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public AIOJKDBCCGB EDKMJMLNODM;
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct INCKPEKLCLH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public AIOJKDBCCGB AHLLHMKGOGN;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[ANEGGJMNACP]
public struct MOKINCPAPPN : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Entity OGLHBJLEIOC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct GHHFDPEGKJE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct MAKEHKINLLD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct GNAJPMHEOCF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct PFDBBNMCCNL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public RigidbodyConstraints NFANHHJMFHJ;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[FPPANCDHLGK]
public struct BHMMGFNONNF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float GAFIOIMHEDD;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly BHMMGFNONNF AEDHDHNAKOP;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct IBIFPNPFCMJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float PGOFDFJFBPE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct FHOKEOPEIME : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct EKIADCFNECL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int APPOEEGLMPF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xD8C3C0", Offset = "0xD8B7C0", VA = "0x180D8C3C0")]
	public static EKIADCFNECL KAHNABMFJPM(int PCGOHCLJAPN)
	{
		return default(EKIADCFNECL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class LIABMANHJAB : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Rigidbody DOBGLDLBPEG;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x626ED90", Offset = "0x626E190", VA = "0x18626ED90", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public LIABMANHJAB()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct EBOMLHMGCNJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct DBMAFPDNDKN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float3 NMPMAICHKMC;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct BDDLDDEAFBP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float3 BBCGBJMODNE;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[FPPANCDHLGK]
public struct EMABPJADIIE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float PIHMBBMGCEO;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly EMABPJADIIE AEDHDHNAKOP;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class NLKDKFIMNBA : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public object DGAAGPFHAFL;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x626F120", Offset = "0x626E520", VA = "0x18626F120", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public NLKDKFIMNBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class OKFABCBDDDP : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public object OEENJNDLJKN;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x626F370", Offset = "0x626E770", VA = "0x18626F370", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public OKFABCBDDDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public enum AIOJKDBCCGB
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public enum FCPGOCNJIBG : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface NJFMHODFEFB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGGJKIKCEKB(IKOBMPEJDCL EHCILKPBPDE, IKOBMPEJDCL IBPDPPGDMFJ);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FNDHEBBHIBJ();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KEHAJPEMHIN();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BAKIIAICJJI(bool NHAFDJKECIH);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BKICEAAJJGB();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LIKMPAHBIKF();
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class DKELILEDOJG : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NJFMHODFEFB KBMOEFNEDHD;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x626E860", Offset = "0x626DC60", VA = "0x18626E860", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public DKELILEDOJG()
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, HJNNFDHIBFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x88B850", Offset = "0x88AC50", VA = "0x18088B850", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x184DDA0", Offset = "0x184D1A0", VA = "0x18184DDA0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x626E310", Offset = "0x626D710", VA = "0x18626E310", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, HJNNFDHIBFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x88B850", Offset = "0x88AC50", VA = "0x18088B850", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x184DDA0", Offset = "0x184D1A0", VA = "0x18184DDA0", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct MFFAIPNHEPK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct BDMHBGLDFKK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Entity MAPEILCCMGI;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct DMBOBHGMPDF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public Entity MAPEILCCMGI;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct BPNFHHIDKKE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private NativeList<EKMMILDEPBB> OGIJHNDENJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private NativeList<Entity> DPNIPBEAMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private JobHandle IAOKDALFCBL;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool MOBONADKCKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x626E500", Offset = "0x626D900", VA = "0x18626E500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int ALDOGAGGHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x626E6F0", Offset = "0x626DAF0", VA = "0x18626E6F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4661C40", Offset = "0x4661040", VA = "0x184661C40")]
	public BPNFHHIDKKE(NativeList<EKMMILDEPBB> OGIJHNDENJH, NativeList<Entity> DPNIPBEAMKF, JobHandle IAOKDALFCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x626E5D0", Offset = "0x626D9D0", VA = "0x18626E5D0")]
	public (Entity, NativeSlice<Entity>) FOMIJIFKCPC(int DJKFAHMDLOE)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x626E570", Offset = "0x626D970", VA = "0x18626E570", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct EKMMILDEPBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Entity BEOJJJNJFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public int PADMGOMCMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public int POJMEHKIPEF;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface DIJNAIAJLPM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGOCCNIAMEP(bool HDHGCEMODFE);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct MKCLOEIDJAD : IEquatable<MKCLOEIDJAD>
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate bool CFCLKADLJLD(int NAODMDIIJFN);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly bool BADCEBEPFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly bool LCPGJLLDKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly bool KJIOAODMMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly bool AJGGJANCCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly CFCLKADLJLD OKMCCFCCDDN;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x626F0E0", Offset = "0x626E4E0", VA = "0x18626F0E0")]
	public MKCLOEIDJAD(OCIFAGNHLMI KKLDALHJAEC, CFCLKADLJLD OKMCCFCCDDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x626F0B0", Offset = "0x626E4B0", VA = "0x18626F0B0")]
	public MKCLOEIDJAD(bool BADCEBEPFJE, bool LCPGJLLDKEL, bool KJIOAODMMCL, bool AJGGJANCCDC, CFCLKADLJLD OKMCCFCCDDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x626EF80", Offset = "0x626E380", VA = "0x18626EF80")]
	public bool FPOMLGLHECO(int NAODMDIIJFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x626F050", Offset = "0x626E450", VA = "0x18626F050")]
	public bool KEOBNFCOJIB(int NAODMDIIJFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x626EE50", Offset = "0x626E250", VA = "0x18626EE50")]
	public bool DBPLONLKHGN(int NAODMDIIJFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x626F080", Offset = "0x626E480", VA = "0x18626F080")]
	public bool PNGCBJHLEDG(int NAODMDIIJFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x626EEA0", Offset = "0x626E2A0", VA = "0x18626EEA0", Slot = "4")]
	public bool Equals(MKCLOEIDJAD MGDPHHCBMMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x626EED0", Offset = "0x626E2D0", VA = "0x18626EED0", Slot = "0")]
	public override bool Equals(object LIKEKIACGIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x626EFB0", Offset = "0x626E3B0", VA = "0x18626EFB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x626EE80", Offset = "0x626E280", VA = "0x18626EE80")]
	private bool DFLOHLIDFOK(int NAODMDIIJFN)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct JDBALFENCHC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct BIPMPIODHFB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct NPMKONEOGLK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[InternalBufferCapacity(17)]
public struct MHNLGOEDIEI : IBufferElementData, IEquatable<MHNLGOEDIEI>, HJNNFDHIBFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Entity FGOLIAHPGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int CPIHNPIPBCA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Entity FPGEEDDMICF
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x88B850", Offset = "0x88AC50", VA = "0x18088B850", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x184DDA0", Offset = "0x184D1A0", VA = "0x18184DDA0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x626EE00", Offset = "0x626E200", VA = "0x18626EE00", Slot = "4")]
	public bool Equals(MHNLGOEDIEI MGDPHHCBMMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct LHDIJDPKOHO : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Entity BOOCGHBLBIA;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, HJNNFDHIBFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x88B850", Offset = "0x88AC50", VA = "0x18088B850", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x184DDA0", Offset = "0x184D1A0", VA = "0x18184DDA0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x184DDA0", Offset = "0x184D1A0", VA = "0x18184DDA0")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x626E310", Offset = "0x626D710", VA = "0x18626E310", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x87D480", Offset = "0x87C880", VA = "0x18087D480")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct JMGDPKFPNKL<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static readonly bool JOKPAMMGCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public uint HLCGMPFHGHB;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	private static bool HIEBKAAONNL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[TypeManager.TypeVersion(2)]
public struct FPEOHMEFAJN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public uint JPOGCPFAAAG;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x626EAC0", Offset = "0x626DEC0", VA = "0x18626EAC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct PBIBFMBEEEB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public int HCJFBLNDIGF;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct HBAHEHOMDFC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public GCHandle PHKJICGNANC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct JHLOGACFLMI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct BOPOCDAAHCP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int HCJFBLNDIGF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct FHGDEGEJOJC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct MBHJLBAABKN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct KPEHFIPEING : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct PMKCJIAHIIM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct JBJBPPKNBCC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct FEJHFDDKKHF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct HMNMCPHGAFN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public FixedString32Bytes CCNKHEJHFKM;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[ANEGGJMNACP]
public struct MLEDGHNPMIL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public Entity NKLOKBNKNAB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x87D480", Offset = "0x87C880", VA = "0x18087D480")]
	public static MLEDGHNPMIL KAHNABMFJPM(Entity PCGOHCLJAPN)
	{
		return default(MLEDGHNPMIL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal struct ACMJMODAEKH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Entity OGLHBJLEIOC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x87D480", Offset = "0x87C880", VA = "0x18087D480")]
	public static ACMJMODAEKH KAHNABMFJPM(Entity OGLHBJLEIOC)
	{
		return default(ACMJMODAEKH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct CKPBIAHBAGP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Entity FJBCKKNOKNF;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct GJDKPOPPALN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public Entity FJBCKKNOKNF;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal struct PHPIBBEFEMB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Entity NCIJFIKACLJ;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x87D480", Offset = "0x87C880", VA = "0x18087D480")]
	public static PHPIBBEFEMB KAHNABMFJPM(Entity OGLHBJLEIOC)
	{
		return default(PHPIBBEFEMB);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal struct AFGPEOLJHLB : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct BILAEGMCDMG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public uint PAKIAOEKDPK;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[ANEGGJMNACP]
internal struct IKOENJMPLAO : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public Entity MHFDLLKNMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public int PMLKPJNGBAD;
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct IPEJFMGICHB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public Entity BDKNLMHIBNH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct CLMNKJGKNHE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct JEJGABHPCFP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public uint HLCGMPFHGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int LGIOBJNHHMP;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xAEAF20", Offset = "0xAEA320", VA = "0x180AEAF20")]
	public JEJGABHPCFP(uint MNGAHPLCIFD, int FNDDKPICDKN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct GACIOKIEKHB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct DFLMAKIHOGH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct IOKMOLIMCBG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct AAGLGIPMKON : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct HDHJFMMKACN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct JHKDCIAHFJG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct KDGHCBJIKLM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct FONHFMLLJCI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal struct OLDPOBAGFDK : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct PIKFHOGEPHO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct MMFBMFPDLIP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal struct MPALLNGEJCA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
internal struct KHIJEJGLHDA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct PEFLFIMHDIP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct IDFHKDMAIBC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct FENLAJHDMBM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct IPCINFCKKEF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct PNHCCAANCID : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct PAIFOFEFIME : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct OGFJEDEBGMF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct CDGENHPBJAN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal struct HODMAFCGMFG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct LBCCLJCEKED : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct NDCKIJIAMOJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct BHPMHIBJPIH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[ANEGGJMNACP]
public struct MGAJHCAGFIJ : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public FixedString32Bytes COLNHOJJEDH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct DPKLGLMGING : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal struct AHJDHKLGIJN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal struct JGHGFPNHIAN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct EOJPPPPEINL : IComponentData, IComparable<EOJPPPPEINL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int BDGOOBKCEIK;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x18567B0", Offset = "0x1855BB0", VA = "0x1818567B0", Slot = "4")]
	public int CompareTo(EOJPPPPEINL MGDPHHCBMMP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[FPPANCDHLGK]
public struct PKKADGGDDMG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float4x4 BOCKNFBHFAA;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly PKKADGGDDMG AEDHDHNAKOP;
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[FPPANCDHLGK]
public struct CIBOFBFFIFD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float4x4 BMKHHDHOHFP;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly CIBOFBFFIFD AEDHDHNAKOP;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct ANJBOBKBMJO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private int KOFOIEPBADJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int PMLKPJNGBAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x626E300", Offset = "0x626D700", VA = "0x18626E300")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x626E2F0", Offset = "0x626D6F0", VA = "0x18626E2F0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[FPPANCDHLGK]
public struct OLACIKOEHNJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float3 ICAPAFGMHOP;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly OLACIKOEHNJ AEDHDHNAKOP;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[FPPANCDHLGK]
public struct ENCEIBKFLJD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float3 CJBHLOLHNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public quaternion APMJJPLCLEP;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly ENCEIBKFLJD AEDHDHNAKOP;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class IOGPOBJFIDK
{
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[FPPANCDHLGK]
public struct JDJPBPGGJNK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float POMLDLAAPIO;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly JDJPBPGGJNK AEDHDHNAKOP;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct PJHLDJMMJBB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public FixedList32Bytes<int> FGNAEAFIHMM;
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct OCICNPACCDA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public FixedList32Bytes<int> FGNAEAFIHMM;
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
internal class OIJJAGIKMAC : ContainerPropertyBag<LIABMANHJAB>
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	private class COFPCKCMAHA : Property<LIABMANHJAB, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override string CGOKMMHCJIB
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x626E830", Offset = "0x626DC30", VA = "0x18626E830", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override bool EFGCLFKEOMA
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x626E7F0", Offset = "0x626DBF0", VA = "0x18626E7F0")]
		public COFPCKCMAHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x626E320", Offset = "0x626D720", VA = "0x18626E320", Slot = "14")]
		public override Rigidbody GetValue(LIABMANHJAB CGBKOFIJCLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x626E340", Offset = "0x626D740", VA = "0x18626E340", Slot = "15")]
		public override void SetValue(LIABMANHJAB CGBKOFIJCLK, Rigidbody PCGOHCLJAPN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x626F290", Offset = "0x626E690", VA = "0x18626F290")]
	public OIJJAGIKMAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal class ADFGEEAJOHI : ContainerPropertyBag<NLKDKFIMNBA>
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private class IELIHEOEPLI : Property<NLKDKFIMNBA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override string CGOKMMHCJIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x626EC40", Offset = "0x626E040", VA = "0x18626EC40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool EFGCLFKEOMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x626EC00", Offset = "0x626E000", VA = "0x18626EC00")]
		public IELIHEOEPLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x626E320", Offset = "0x626D720", VA = "0x18626E320", Slot = "14")]
		public override object GetValue(NLKDKFIMNBA CGBKOFIJCLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x626E340", Offset = "0x626D740", VA = "0x18626E340", Slot = "15")]
		public override void SetValue(NLKDKFIMNBA CGBKOFIJCLK, object PCGOHCLJAPN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x626E110", Offset = "0x626D510", VA = "0x18626E110")]
	public ADFGEEAJOHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal class JHLDIFDNLPN : ContainerPropertyBag<OKFABCBDDDP>
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	private class BBBKAKIJHMO : Property<OKFABCBDDDP, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override string CGOKMMHCJIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x626E3B0", Offset = "0x626D7B0", VA = "0x18626E3B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override bool EFGCLFKEOMA
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x626E370", Offset = "0x626D770", VA = "0x18626E370")]
		public BBBKAKIJHMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x626E320", Offset = "0x626D720", VA = "0x18626E320", Slot = "14")]
		public override object GetValue(OKFABCBDDDP CGBKOFIJCLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x626E340", Offset = "0x626D740", VA = "0x18626E340", Slot = "15")]
		public override void SetValue(OKFABCBDDDP CGBKOFIJCLK, object PCGOHCLJAPN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x626ECB0", Offset = "0x626E0B0", VA = "0x18626ECB0")]
	public JHLDIFDNLPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
internal class BDANJBCNEJL : ContainerPropertyBag<DKELILEDOJG>
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	private class GFNEKHPLIEH : Property<DKELILEDOJG, NJFMHODFEFB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string CGOKMMHCJIB
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x626EBD0", Offset = "0x626DFD0", VA = "0x18626EBD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool EFGCLFKEOMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x626EB90", Offset = "0x626DF90", VA = "0x18626EB90")]
		public GFNEKHPLIEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x626E320", Offset = "0x626D720", VA = "0x18626E320", Slot = "14")]
		public override NJFMHODFEFB GetValue(DKELILEDOJG CGBKOFIJCLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x626E340", Offset = "0x626D740", VA = "0x18626E340", Slot = "15")]
		public override void SetValue(DKELILEDOJG CGBKOFIJCLK, NJFMHODFEFB PCGOHCLJAPN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x626E3E0", Offset = "0x626D7E0", VA = "0x18626E3E0")]
	public BDANJBCNEJL()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x626F510", Offset = "0x626E910", VA = "0x18626F510")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class GGOHFKMAPDD
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public GGOHFKMAPDD()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
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
