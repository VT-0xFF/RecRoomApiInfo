using System;
using System.Collections.Generic;
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
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
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
	public class _AssemblyIndex : FDEGBGNEMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6C8FAD0", Offset = "0x6C8E4D0", VA = "0x186C8FAD0", Slot = "9")]
		public override void PIIPODGLMLG(EBGHMGIFFEK registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6C8F670", Offset = "0x6C8E070", VA = "0x186C8F670", Slot = "7")]
		public override void IIBIKAPKCLC(INNEGFJDCKJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x626DEE0", Offset = "0x626C8E0", VA = "0x18626DEE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct DOCLDLONDAP : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildBuffer>, BBLKLPOPLCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6C8CA30", Offset = "0x6C8B430", VA = "0x186C8CA30", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x933670", Offset = "0x932070", VA = "0x180933670")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, BBLKLPOPLCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct HDOJJPHJBLG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct FGFDBDKJIAG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity HPHMCGEHEEG;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct OGKLPBHPKBF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity HPHMCGEHEEG;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct EAMENLPPBCA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<ICBELBLDBGK> JMCEIJEPPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<Entity> AMEGEJEKBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JobHandle AJLOAOCOAJH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DOLICCCNJBI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6C8D9C0", Offset = "0x6C8C3C0", VA = "0x186C8D9C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int LEDCMOMLPMG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6C8D910", Offset = "0x6C8C310", VA = "0x186C8D910")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4EBE7B0", Offset = "0x4EBD1B0", VA = "0x184EBE7B0")]
	public EAMENLPPBCA(NativeList<ICBELBLDBGK> JMCEIJEPPIK, NativeList<Entity> AMEGEJEKBLI, JobHandle AJLOAOCOAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6C8DA30", Offset = "0x6C8C430", VA = "0x186C8DA30")]
	public (Entity, NativeSlice<Entity>) JPEBOLKKALD(int ELMEOKPKOPN)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6C8D960", Offset = "0x6C8C360", VA = "0x186C8D960", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct ICBELBLDBGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Entity BAFHJDFHJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int EDCGGCHLNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int CGDCIDKGGML;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IPHNMELIAEK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JAJLBDANJOB(bool OAHDCNMHMDG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct BDJIMJLHAMG : IEquatable<BDJIMJLHAMG>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool KOOCPKPLKLE(int EKEAKMCADMP);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool JPJPKMBOAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool BPPAJBNLHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool AADJMIBJGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool LJFCHOPOMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly KOOCPKPLKLE MAJLHEKDAGN;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6C8CCD0", Offset = "0x6C8B6D0", VA = "0x186C8CCD0")]
	public BDJIMJLHAMG(PCKDAGNPJNH DLDAJAKJJND, KOOCPKPLKLE MAJLHEKDAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6C8CCA0", Offset = "0x6C8B6A0", VA = "0x186C8CCA0")]
	public BDJIMJLHAMG(bool JPJPKMBOAON, bool BPPAJBNLHOC, bool AADJMIBJGGN, bool LJFCHOPOMOB, KOOCPKPLKLE MAJLHEKDAGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6C8CBF0", Offset = "0x6C8B5F0", VA = "0x186C8CBF0")]
	public bool JBAHBCIOFBE(int EKEAKMCADMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6C8CC70", Offset = "0x6C8B670", VA = "0x186C8CC70")]
	public bool PCGJIDLLLGO(int EKEAKMCADMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6C8CA40", Offset = "0x6C8B440", VA = "0x186C8CA40")]
	public bool ANDGEPPPBFH(int EKEAKMCADMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6C8CC20", Offset = "0x6C8B620", VA = "0x186C8CC20")]
	public bool LAMIEAOEGND(int EKEAKMCADMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6C8CB20", Offset = "0x6C8B520", VA = "0x186C8CB20", Slot = "4")]
	public bool Equals(BDJIMJLHAMG CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6C8CA70", Offset = "0x6C8B470", VA = "0x186C8CA70", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8CB50", Offset = "0x6C8B550", VA = "0x186C8CB50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6C8CC50", Offset = "0x6C8B650", VA = "0x186C8CC50")]
	private bool NNIGKAGEGKJ(int EKEAKMCADMP)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct GDAALHELLAH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct DMLFFBPODLK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct OGGFDMOKKDI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[InternalBufferCapacity(17)]
public struct GFLIBANHBID : IBufferElementData, IEquatable<GFLIBANHBID>, BBLKLPOPLCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity PPFEFKBKBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int EPEPDOGEKHL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity LIMGNAILAOA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6C8DFA0", Offset = "0x6C8C9A0", VA = "0x186C8DFA0", Slot = "4")]
	public bool Equals(GFLIBANHBID CGCLEIBHLHF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct ADJLDKKDOEN : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct GKDOJKDMBAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly AJDGHKJLOEI MDOMAGJPALO;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2300B30", Offset = "0x22FF530", VA = "0x182300B30")]
		public GKDOJKDMBAH(AJDGHKJLOEI ONBLBDNGMOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E140", Offset = "0x6C8CB40", VA = "0x186C8E140")]
		public bool FHLHGMLHBFC(ADJLDKKDOEN JMKCOOIEHBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E150", Offset = "0x6C8CB50", VA = "0x186C8E150")]
		public bool JJIACIGLAME(ADJLDKKDOEN JMKCOOIEHBD, AJDGHKJLOEI CPGNHAGPGCL)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly AJDGHKJLOEI GPMPMENIHHJ;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2300B30", Offset = "0x22FF530", VA = "0x182300B30")]
	public ADJLDKKDOEN(AJDGHKJLOEI GPMPMENIHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C8C900", Offset = "0x6C8B300", VA = "0x186C8C900")]
	public ADJLDKKDOEN IHBEDFNBLPK(AJDGHKJLOEI HICLMAINCBD)
	{
		return default(ADJLDKKDOEN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6C8C8F0", Offset = "0x6C8B2F0", VA = "0x186C8C8F0")]
	public ADJLDKKDOEN ECFMFKMOCHI(AJDGHKJLOEI BJFFDCGJAEH)
	{
		return default(ADJLDKKDOEN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6C8C910", Offset = "0x6C8B310", VA = "0x186C8C910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[Flags]
public enum AJDGHKJLOEI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	HasShapeChildren = 1,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	HasEmbodiedChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	IsRootObject = 4,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	HasColliders = 8,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	TestEmbodiment = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	All = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[Flags]
public enum PLNJMCGJENK : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DJFPDFOCLPE]
public struct NLELCMMMFIK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public PLNJMCGJENK GPMPMENIHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public bool LOHJCEPOEHO;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool CFABOKGJHFL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6C8ECF0", Offset = "0x6C8D6F0", VA = "0x186C8ECF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6C8ED00", Offset = "0x6C8D700", VA = "0x186C8ED00")]
	private NLELCMMMFIK(PLNJMCGJENK GPMPMENIHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6C8ECD0", Offset = "0x6C8D6D0", VA = "0x186C8ECD0")]
	public NLELCMMMFIK IHBEDFNBLPK(PLNJMCGJENK HICLMAINCBD)
	{
		return default(NLELCMMMFIK);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8ECB0", Offset = "0x6C8D6B0", VA = "0x186C8ECB0")]
	public NLELCMMMFIK ECFMFKMOCHI(PLNJMCGJENK BJFFDCGJAEH)
	{
		return default(NLELCMMMFIK);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct OIHIIFHDGHI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct OOAOOPPBJFO : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Entity AKEABABALMF;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildBuffer>, BBLKLPOPLCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6C8CA30", Offset = "0x6C8B430", VA = "0x186C8CA30", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x933670", Offset = "0x932070", VA = "0x180933670")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DJFPDFOCLPE]
public struct GEGIGGOKMGB : ISystemStateBufferElementData, IBufferElementData, BBLKLPOPLCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public Entity AFNIOPPCKNG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Entity MAGDCIACFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct GDLBAIDEENN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Entity IKMDDOOOBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Entity DELLFBBIPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity FPNOGJECCIN;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct BAIPKDMKCKH<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly bool DDBKACNOMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public uint ICKANJCFFHD;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool LNPGPOHGOKF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.TypeVersion(2)]
public struct FEIDHBFAKKC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public uint OKJBABPIDDB;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6C8DD30", Offset = "0x6C8C730", VA = "0x186C8DD30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct COPDEBIBOHK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[DJFPDFOCLPE]
public struct FMIGFHMBDEK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public int PLADPOHBDOP;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct DLFDDHHCNNI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int ILBCHIFAEFG;
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct CDLNHOFPKPL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public GCHandle HJBCPOGGFEJ;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct ENDIHENDOPN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public int ILBCHIFAEFG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct NKABGFEPPDP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct OEIEACNKFOE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public int ILBCHIFAEFG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct BPKKAGMBPGB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct BCAGHALGHOG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct AGICHPHLIJM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct OEHPBFDDEMN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public CollisionDetectionMode HEDHHOJBLEO;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[ECHJOPLOCOF]
public struct ELNHILKNOGM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public HDLBMLPIHPN AOLOFECOFCK;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly ELNHILKNOGM ANDDCLMCCKL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct GJFJGJFOAGI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct ALIPOEEOKDE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct MMPDBAAINKK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[InternalBufferCapacity(0)]
public struct JAMNHPCKMFM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Entity PPFEFKBKBLH;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct EFFLBJDDOGF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Entity KMAENCDMJDN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct FLNNKGDGAAE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct FLJDHBLAMMC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Entity BAFHJDFHJHD;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct KDEDJFMGHGB : JBHJGPJDINF, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public BOEJAEGFCAA FNAOEBKOBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(BOEJAEGFCAA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct CJFAIGHNEAA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float3 PCIJHHCOBJI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct LNDBNDPPDNM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[ECHJOPLOCOF]
public struct GAKHGMJJIAG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public float3x3 BEDBAGAOPLA;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly GAKHGMJJIAG ANDDCLMCCKL;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[ECHJOPLOCOF]
public struct FKICCOCDAMJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public float3x3 BEDBAGAOPLA;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly FKICCOCDAMJ ANDDCLMCCKL;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct NGEJLBHKNMB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public float3 IHFABDHDNJJ;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct JEDNGNEKBPO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public float3 DCIPPFMLOAA;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[ECHJOPLOCOF]
public struct PFEOGFMKCLC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float CHAPLHPHMAC;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly PFEOGFMKCLC ANDDCLMCCKL;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[ECHJOPLOCOF]
public struct OENHNAMPLAP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public float MJBKJCHOPJH;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly OENHNAMPLAP ANDDCLMCCKL;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct JGJJMDIOHEF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public float3 JEJOBFHBDOK;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct KEIKLKOKNAM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public DJFECCHKBLN KKELJBMGMIN;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct BLDLPFPLGHH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public DJFECCHKBLN IHMILFMBPCN;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[DJFPDFOCLPE]
public struct FDLIIMCOOPM : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Entity AFNIOPPCKNG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct FMKOEAEGCFM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct MPCNHAHBGCO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct OPJDBBJIKAD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public RigidbodyConstraints MMHODEDNBAM;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[ECHJOPLOCOF]
public struct NHAMAEAHNLG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public float GDBONDCADGP;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly NHAMAEAHNLG ANDDCLMCCKL;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct GOHDOBEFOLK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float EJENIGIADEA;
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class HIBAGOJAADI : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct LKBJGBEGKBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public object LENOGFOLHKG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public GameObject BICFCMICGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public object LLNAKALPLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public object NIFEHJDOLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public LKBJGBEGKBN LENOGFOLHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public Delegate LCAAGNMFAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Delegate OCDPEOHIPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public HNPDCOKHGBJ<Delegate> KLIMDNMBHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public HNPDCOKHGBJ<Delegate> DDJLJOBFAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public HNPDCOKHGBJ<Delegate> LHHKEILAJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HNPDCOKHGBJ<Delegate> HKPBJEGEGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public HNPDCOKHGBJ<Delegate> IOOGGLHEAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public HNPDCOKHGBJ<Delegate> ALEAAMNCABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public HNPDCOKHGBJ<Delegate> GHDFENCNFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public HNPDCOKHGBJ<Delegate> JEJKEFLIBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public HNPDCOKHGBJ<Delegate> HAGGKBCLHMO;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6C8E220", Offset = "0x6C8CC20", VA = "0x186C8E220", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public HIBAGOJAADI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct AIAIPDJAHCC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct HHFHIAIPCFG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int GOAINEGCKCC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1605D90", Offset = "0x1604790", VA = "0x181605D90")]
	public static HHFHIAIPCFG DBMBPMAANBF(int IPHMAHBENGI)
	{
		return default(HHFHIAIPCFG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class MKPCHCDKLKC : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public Rigidbody EKAOOBAECFJ;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6C8EA40", Offset = "0x6C8D440", VA = "0x186C8EA40", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public MKPCHCDKLKC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct JLFNPMFANIN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct IICJFDEAPFG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 LJFEFIKHHHB;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct MCEONILKGFD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float3 DPBIGMHBMBN;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[ECHJOPLOCOF]
public struct OAJHIHLPLOL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float NJEIMEHMNLE;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly OAJHIHLPLOL ANDDCLMCCKL;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class KBNGCKGDMPA : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public object JLJCJKIKEOD;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6C8E550", Offset = "0x6C8CF50", VA = "0x186C8E550", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public KBNGCKGDMPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class BNFGGMDDGAK : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public object IOENDKDBCON;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6C8CE20", Offset = "0x6C8B820", VA = "0x186C8CE20", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public BNFGGMDDGAK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct HGBGEJBCHJE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct CJJPAGNKIAP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct LIBCOCEIBFP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct IBLLFNJKMFF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct FNNPBJCGBAB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct NCMCICPAAAK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public FixedString32Bytes DDDMPLCOGIM;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[DJFPDFOCLPE]
public struct DNHCCJLDMBL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Entity GAFAAAGMMJN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x933670", Offset = "0x932070", VA = "0x180933670")]
	public static DNHCCJLDMBL DBMBPMAANBF(Entity IPHMAHBENGI)
	{
		return default(DNHCCJLDMBL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal struct CHJMFGLNGHL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Entity AFNIOPPCKNG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x933670", Offset = "0x932070", VA = "0x180933670")]
	public static CHJMFGLNGHL DBMBPMAANBF(Entity AFNIOPPCKNG)
	{
		return default(CHJMFGLNGHL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct KFDGHCNIGKF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Entity LJLMFIGHILN;
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct POEPELFGOMP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Entity LJLMFIGHILN;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal struct DAAALOOIGGD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Entity BHKDDILDFEF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x933670", Offset = "0x932070", VA = "0x180933670")]
	public static DAAALOOIGGD DBMBPMAANBF(Entity AFNIOPPCKNG)
	{
		return default(DAAALOOIGGD);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal struct HJDCMFIIPNN : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct FPBKFIJBLCH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct DHEGMGNCBKM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public uint MOOGIOAAOOM;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[DJFPDFOCLPE]
internal struct NMEAPHLCHJD : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public Entity IGFEFKKGEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int ENMILGHAHOM;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal struct LBHFMKOBHFJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public Entity DOOOLJJPPKH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct LCDOBKANNEH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct CGAFOADFFCC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public uint ICKANJCFFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int HMKNMNAIIHD;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x9B5B10", Offset = "0x9B4510", VA = "0x1809B5B10")]
	public CGAFOADFFCC(uint DHACINLNJCK, int KMCNOJDLJBE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct LIOFJCFBKJO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct AMDHAIKEKOG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct LANANEMODKA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct PFHOHHJJFEI : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct NPMHIIEJCKL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct OBNOBIJOMPC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct MPHBJIKNBMI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct EBOBDJPEHLD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal struct MMOODEPMKCN : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct EDOAOPBEHKH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct KNJIHGDLNCH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct CKBODLGOHJB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal struct ILNLDBHMGKH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal struct CGGIMJKJBAG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct IFBLOAOPDED : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct PJOLCEOMKJI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct DJAIEOIKNJG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct HGFLFPLLDJP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct ANIMHBNOEBI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct NIIIEDLDDEO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct DBEKKJPAECC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct OPLFOPFEAOI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct LEJNPEMFMPB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct JIJBDCEJKLE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal struct HKNLCBNIFGP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct OHGIHOHKIEJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct JMBIDKFEGAH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct AJHDEBKLDFC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DJFPDFOCLPE]
public struct DNADAHBGMIP : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public FixedString32Bytes EEIDNNLIIHD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct FABCFLFLPCN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct DENKCBMFNCE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal struct HMJFEAGPBLK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal struct KLFCBIBIAOC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal struct JFJPKIIDBJE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct KDOJFMEMDBK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct BPGIKPPHMKF : IComponentData, IComparable<BPGIKPPHMKF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public int OEEIIDFNFGC;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1E00F00", Offset = "0x1DFF900", VA = "0x181E00F00", Slot = "4")]
	public int CompareTo(BPGIKPPHMKF CGCLEIBHLHF)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct CAIOKBLEENI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct BPAALBOOFNN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public quaternion PCIAHIPKDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float3 EJEBFMEPKGF;
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct OFOANEGFDDG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float DNCGFIGCFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float LFDPCOHOLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float GLBHIIJBHNC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct EKDPJDHGFHM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct JHDDDGHFHCA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct HODLNOPOIIL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct HDBHOGOFKLO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public int ILBCHIFAEFG;
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[DJFPDFOCLPE]
public struct FJJIOCFJBFJ : ISystemStateBufferElementData, IBufferElementData, BBLKLPOPLCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Entity LJHMHPGNKEJ;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Entity MAGDCIACFGG
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[ECHJOPLOCOF]
public struct ICGNFOEFNAO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public float4x4 OFDIAIOMFEK;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public static readonly ICGNFOEFNAO ANDDCLMCCKL;
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[ECHJOPLOCOF]
public struct JFEDPLPDPMN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public float4x4 HELHGEGHHJI;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public static readonly JFEDPLPDPMN ANDDCLMCCKL;
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public struct IFHGFMANBGN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private int JLIFONIOIAK;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int ENMILGHAHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E320", Offset = "0x6C8CD20", VA = "0x186C8E320")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E330", Offset = "0x6C8CD30", VA = "0x186C8E330")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[ECHJOPLOCOF]
public struct PONDKNPLLJP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public float3 PFCBGIEOFIK;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public static readonly PONDKNPLLJP ANDDCLMCCKL;
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[ECHJOPLOCOF]
public struct MAAIKKLLHNA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float3 EJEBFMEPKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public quaternion PCIAHIPKDFG;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public static readonly MAAIKKLLHNA ANDDCLMCCKL;
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class MMGAJHBBBPH
{
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[ECHJOPLOCOF]
public struct OMOKGHCDGGE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float KJPFMFJFLMJ;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public static readonly OMOKGHCDGGE ANDDCLMCCKL;
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct IKDDLCBMIDM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Entity FGKAOJPFKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NAKOJNDAOID CJJFHMMBLHB;
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct OCGBECDAHMD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public NAKOJNDAOID CJJFHMMBLHB;
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct CEGCEFMHLCM : ISystemStateComponentData, IComponentData, BBLKLPOPLCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Entity LKDGGBDDBJM;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity MAGDCIACFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct IPIEKDPOKHE : ISystemStateBufferElementData, IBufferElementData, BBLKLPOPLCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity KODOOHIDFND;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Entity MAGDCIACFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct NHBEFLHAFEG : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Entity FGKAOJPFKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public NAKOJNDAOID CJJFHMMBLHB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct BLIBJEBMOCA : IEqualityComparer<NHBEFLHAFEG>
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public static BLIBJEBMOCA ANDDCLMCCKL;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8CD70", Offset = "0x6C8B770", VA = "0x186C8CD70", Slot = "4")]
	public bool Equals(NHBEFLHAFEG OFCNMBDJPHM, NHBEFLHAFEG CONCKFNNMJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6C8CDC0", Offset = "0x6C8B7C0", VA = "0x186C8CDC0", Slot = "5")]
	public int GetHashCode(NHBEFLHAFEG FHFDEAHMMBI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct FDKIDHDKMJB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public FixedList32Bytes<int> CMLOGHHHANB;
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct KNJDFLMCECK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public FixedList32Bytes<int> CMLOGHHHANB;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct GDBEENJDMPG : ISystemStateBufferElementData, IBufferElementData, BBLKLPOPLCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Entity DOKHLIFOMOH;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private Entity LIMGNAILAOA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1058360", Offset = "0x1056D60", VA = "0x181058360", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class DJANGFBNANF : ContainerPropertyBag<HIBAGOJAADI>
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	private class AHNGBIPKABO : Property<HIBAGOJAADI, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string FMJDNGHFJGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6C8CA00", Offset = "0x6C8B400", VA = "0x186C8CA00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool MEAEOHJNNNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C9C0", Offset = "0x6C8B3C0", VA = "0x186C8C9C0")]
		public AHNGBIPKABO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C970", Offset = "0x6C8B370", VA = "0x186C8C970", Slot = "14")]
		public override GameObject GetValue(HIBAGOJAADI NKDOKEFKKDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C990", Offset = "0x6C8B390", VA = "0x186C8C990", Slot = "15")]
		public override void SetValue(HIBAGOJAADI NKDOKEFKKDI, GameObject IPHMAHBENGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class LCCHDJJCJNO : Property<HIBAGOJAADI, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string FMJDNGHFJGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6C8E710", Offset = "0x6C8D110", VA = "0x186C8E710", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool MEAEOHJNNNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E6D0", Offset = "0x6C8D0D0", VA = "0x186C8E6D0")]
		public LCCHDJJCJNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E680", Offset = "0x6C8D080", VA = "0x186C8E680", Slot = "14")]
		public override object GetValue(HIBAGOJAADI NKDOKEFKKDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E6A0", Offset = "0x6C8D0A0", VA = "0x186C8E6A0", Slot = "15")]
		public override void SetValue(HIBAGOJAADI NKDOKEFKKDI, object IPHMAHBENGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class PHBMDFIJCPE : Property<HIBAGOJAADI, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string FMJDNGHFJGI
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6C8F0E0", Offset = "0x6C8DAE0", VA = "0x186C8F0E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool MEAEOHJNNNH
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6C8F0A0", Offset = "0x6C8DAA0", VA = "0x186C8F0A0")]
		public PHBMDFIJCPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6C8F050", Offset = "0x6C8DA50", VA = "0x186C8F050", Slot = "14")]
		public override object GetValue(HIBAGOJAADI NKDOKEFKKDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6C8F070", Offset = "0x6C8DA70", VA = "0x186C8F070", Slot = "15")]
		public override void SetValue(HIBAGOJAADI NKDOKEFKKDI, object IPHMAHBENGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	private class GLEGPNLBLAC : Property<HIBAGOJAADI, HIBAGOJAADI.LKBJGBEGKBN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string FMJDNGHFJGI
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6C8E1F0", Offset = "0x6C8CBF0", VA = "0x186C8E1F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool MEAEOHJNNNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E1B0", Offset = "0x6C8CBB0", VA = "0x186C8E1B0")]
		public GLEGPNLBLAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E160", Offset = "0x6C8CB60", VA = "0x186C8E160", Slot = "14")]
		public override HIBAGOJAADI.LKBJGBEGKBN GetValue(HIBAGOJAADI NKDOKEFKKDI)
		{
			return default(HIBAGOJAADI.LKBJGBEGKBN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E180", Offset = "0x6C8CB80", VA = "0x186C8E180", Slot = "15")]
		public override void SetValue(HIBAGOJAADI NKDOKEFKKDI, HIBAGOJAADI.LKBJGBEGKBN IPHMAHBENGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private class FDOMCFOFCPO : Property<HIBAGOJAADI, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string FMJDNGHFJGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6C8DD00", Offset = "0x6C8C700", VA = "0x186C8DD00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool MEAEOHJNNNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6C8DCC0", Offset = "0x6C8C6C0", VA = "0x186C8DCC0")]
		public FDOMCFOFCPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6C8DC70", Offset = "0x6C8C670", VA = "0x186C8DC70", Slot = "14")]
		public override Delegate GetValue(HIBAGOJAADI NKDOKEFKKDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6C8DC90", Offset = "0x6C8C690", VA = "0x186C8DC90", Slot = "15")]
		public override void SetValue(HIBAGOJAADI NKDOKEFKKDI, Delegate IPHMAHBENGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	private class KPHFIFCMIMM : Property<HIBAGOJAADI, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string FMJDNGHFJGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6C8E650", Offset = "0x6C8D050", VA = "0x186C8E650", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool MEAEOHJNNNH
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E610", Offset = "0x6C8D010", VA = "0x186C8E610")]
		public KPHFIFCMIMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E5C0", Offset = "0x6C8CFC0", VA = "0x186C8E5C0", Slot = "14")]
		public override Delegate GetValue(HIBAGOJAADI NKDOKEFKKDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E5E0", Offset = "0x6C8CFE0", VA = "0x186C8E5E0", Slot = "15")]
		public override void SetValue(HIBAGOJAADI NKDOKEFKKDI, Delegate IPHMAHBENGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private class MLJCBNKNODI : Property<HIBAGOJAADI, HNPDCOKHGBJ<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string FMJDNGHFJGI
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6C8EB60", Offset = "0x6C8D560", VA = "0x186C8EB60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool MEAEOHJNNNH
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6C8EB20", Offset = "0x6C8D520", VA = "0x186C8EB20")]
		public MLJCBNKNODI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6C8EAB0", Offset = "0x6C8D4B0", VA = "0x186C8EAB0", Slot = "14")]
		public override HNPDCOKHGBJ<Delegate> GetValue(HIBAGOJAADI NKDOKEFKKDI)
		{
			return default(HNPDCOKHGBJ<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6C8EAE0", Offset = "0x6C8D4E0", VA = "0x186C8EAE0", Slot = "15")]
		public override void SetValue(HIBAGOJAADI NKDOKEFKKDI, HNPDCOKHGBJ<Delegate> IPHMAHBENGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private class NHDBHLJPHFG : Property<HIBAGOJAADI, HNPDCOKHGBJ<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string FMJDNGHFJGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6C8EC80", Offset = "0x6C8D680", VA = "0x186C8EC80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool MEAEOHJNNNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6C8EC40", Offset = "0x6C8D640", VA = "0x186C8EC40")]
		public NHDBHLJPHFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6C8EBD0", Offset = "0x6C8D5D0", VA = "0x186C8EBD0", Slot = "14")]
		public override HNPDCOKHGBJ<Delegate> GetValue(HIBAGOJAADI NKDOKEFKKDI)
		{
			return default(HNPDCOKHGBJ<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6C8EC00", Offset = "0x6C8D600", VA = "0x186C8EC00", Slot = "15")]
		public override void SetValue(HIBAGOJAADI NKDOKEFKKDI, HNPDCOKHGBJ<Delegate> IPHMAHBENGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class CLMJDHCEJEN : Property<HIBAGOJAADI, HNPDCOKHGBJ<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string FMJDNGHFJGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6C8D190", Offset = "0x6C8BB90", VA = "0x186C8D190", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool MEAEOHJNNNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6C8D150", Offset = "0x6C8BB50", VA = "0x186C8D150")]
		public CLMJDHCEJEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6C8D0E0", Offset = "0x6C8BAE0", VA = "0x186C8D0E0", Slot = "14")]
		public override HNPDCOKHGBJ<Delegate> GetValue(HIBAGOJAADI NKDOKEFKKDI)
		{
			return default(HNPDCOKHGBJ<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6C8D110", Offset = "0x6C8BB10", VA = "0x186C8D110", Slot = "15")]
		public override void SetValue(HIBAGOJAADI NKDOKEFKKDI, HNPDCOKHGBJ<Delegate> IPHMAHBENGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	private class CDNADHMCBKN : Property<HIBAGOJAADI, HNPDCOKHGBJ<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string FMJDNGHFJGI
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6C8CFC0", Offset = "0x6C8B9C0", VA = "0x186C8CFC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool MEAEOHJNNNH
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6C8CF80", Offset = "0x6C8B980", VA = "0x186C8CF80")]
		public CDNADHMCBKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6C8CF00", Offset = "0x6C8B900", VA = "0x186C8CF00", Slot = "14")]
		public override HNPDCOKHGBJ<Delegate> GetValue(HIBAGOJAADI NKDOKEFKKDI)
		{
			return default(HNPDCOKHGBJ<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6C8CF40", Offset = "0x6C8B940", VA = "0x186C8CF40", Slot = "15")]
		public override void SetValue(HIBAGOJAADI NKDOKEFKKDI, HNPDCOKHGBJ<Delegate> IPHMAHBENGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private class JLKDGGMLFMH : Property<HIBAGOJAADI, HNPDCOKHGBJ<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string FMJDNGHFJGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6C8E520", Offset = "0x6C8CF20", VA = "0x186C8E520", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool MEAEOHJNNNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E4E0", Offset = "0x6C8CEE0", VA = "0x186C8E4E0")]
		public JLKDGGMLFMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E460", Offset = "0x6C8CE60", VA = "0x186C8E460", Slot = "14")]
		public override HNPDCOKHGBJ<Delegate> GetValue(HIBAGOJAADI NKDOKEFKKDI)
		{
			return default(HNPDCOKHGBJ<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E4A0", Offset = "0x6C8CEA0", VA = "0x186C8E4A0", Slot = "15")]
		public override void SetValue(HIBAGOJAADI NKDOKEFKKDI, HNPDCOKHGBJ<Delegate> IPHMAHBENGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	private class NMCEPEMHBPM : Property<HIBAGOJAADI, HNPDCOKHGBJ<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string FMJDNGHFJGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6C8EDD0", Offset = "0x6C8D7D0", VA = "0x186C8EDD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool MEAEOHJNNNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6C8ED90", Offset = "0x6C8D790", VA = "0x186C8ED90")]
		public NMCEPEMHBPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6C8ED10", Offset = "0x6C8D710", VA = "0x186C8ED10", Slot = "14")]
		public override HNPDCOKHGBJ<Delegate> GetValue(HIBAGOJAADI NKDOKEFKKDI)
		{
			return default(HNPDCOKHGBJ<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6C8ED50", Offset = "0x6C8D750", VA = "0x186C8ED50", Slot = "15")]
		public override void SetValue(HIBAGOJAADI NKDOKEFKKDI, HNPDCOKHGBJ<Delegate> IPHMAHBENGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	private class CKFIHODHBJG : Property<HIBAGOJAADI, HNPDCOKHGBJ<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string FMJDNGHFJGI
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6C8D0B0", Offset = "0x6C8BAB0", VA = "0x186C8D0B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool MEAEOHJNNNH
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6C8D070", Offset = "0x6C8BA70", VA = "0x186C8D070")]
		public CKFIHODHBJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6C8CFF0", Offset = "0x6C8B9F0", VA = "0x186C8CFF0", Slot = "14")]
		public override HNPDCOKHGBJ<Delegate> GetValue(HIBAGOJAADI NKDOKEFKKDI)
		{
			return default(HNPDCOKHGBJ<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6C8D030", Offset = "0x6C8BA30", VA = "0x186C8D030", Slot = "15")]
		public override void SetValue(HIBAGOJAADI NKDOKEFKKDI, HNPDCOKHGBJ<Delegate> IPHMAHBENGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class DDPCCLFLHKC : Property<HIBAGOJAADI, HNPDCOKHGBJ<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string FMJDNGHFJGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x6C8D280", Offset = "0x6C8BC80", VA = "0x186C8D280", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool MEAEOHJNNNH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6C8D240", Offset = "0x6C8BC40", VA = "0x186C8D240")]
		public DDPCCLFLHKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6C8D1C0", Offset = "0x6C8BBC0", VA = "0x186C8D1C0", Slot = "14")]
		public override HNPDCOKHGBJ<Delegate> GetValue(HIBAGOJAADI NKDOKEFKKDI)
		{
			return default(HNPDCOKHGBJ<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6C8D200", Offset = "0x6C8BC00", VA = "0x186C8D200", Slot = "15")]
		public override void SetValue(HIBAGOJAADI NKDOKEFKKDI, HNPDCOKHGBJ<Delegate> IPHMAHBENGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	private class LCIGNGAGIAF : Property<HIBAGOJAADI, HNPDCOKHGBJ<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string FMJDNGHFJGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6C8E800", Offset = "0x6C8D200", VA = "0x186C8E800", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool MEAEOHJNNNH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E7C0", Offset = "0x6C8D1C0", VA = "0x186C8E7C0")]
		public LCIGNGAGIAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E740", Offset = "0x6C8D140", VA = "0x186C8E740", Slot = "14")]
		public override HNPDCOKHGBJ<Delegate> GetValue(HIBAGOJAADI NKDOKEFKKDI)
		{
			return default(HNPDCOKHGBJ<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E780", Offset = "0x6C8D180", VA = "0x186C8E780", Slot = "15")]
		public override void SetValue(HIBAGOJAADI NKDOKEFKKDI, HNPDCOKHGBJ<Delegate> IPHMAHBENGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6C8D2B0", Offset = "0x6C8BCB0", VA = "0x186C8D2B0")]
	public DJANGFBNANF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal class GIMMNNNFKMI : ContainerPropertyBag<HIBAGOJAADI.LKBJGBEGKBN>
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private class IMJNPJJPNPP : Property<HIBAGOJAADI.LKBJGBEGKBN, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string FMJDNGHFJGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6C8E380", Offset = "0x6C8CD80", VA = "0x186C8E380", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool MEAEOHJNNNH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6C8E340", Offset = "0x6C8CD40", VA = "0x186C8E340")]
		public IMJNPJJPNPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x928E80", Offset = "0x927880", VA = "0x180928E80", Slot = "14")]
		public override object GetValue(HIBAGOJAADI.LKBJGBEGKBN NKDOKEFKKDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x49FB3E0", Offset = "0x49F9DE0", VA = "0x1849FB3E0", Slot = "15")]
		public override void SetValue(HIBAGOJAADI.LKBJGBEGKBN NKDOKEFKKDI, object IPHMAHBENGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6C8E060", Offset = "0x6C8CA60", VA = "0x186C8E060")]
	public GIMMNNNFKMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class BIGOCKPMMNM : ContainerPropertyBag<HNPDCOKHGBJ<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6C8CD10", Offset = "0x6C8B710", VA = "0x186C8CD10")]
	public BIGOCKPMMNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal class EGLFMEBIHCL : ContainerPropertyBag<MKPCHCDKLKC>
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class BOAJGIGJLJE : Property<MKPCHCDKLKC, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string FMJDNGHFJGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6C8CED0", Offset = "0x6C8B8D0", VA = "0x186C8CED0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool MEAEOHJNNNH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6C8CE90", Offset = "0x6C8B890", VA = "0x186C8CE90")]
		public BOAJGIGJLJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C970", Offset = "0x6C8B370", VA = "0x186C8C970", Slot = "14")]
		public override Rigidbody GetValue(MKPCHCDKLKC NKDOKEFKKDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C990", Offset = "0x6C8B390", VA = "0x186C8C990", Slot = "15")]
		public override void SetValue(MKPCHCDKLKC NKDOKEFKKDI, Rigidbody IPHMAHBENGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6C8DB50", Offset = "0x6C8C550", VA = "0x186C8DB50")]
	public EGLFMEBIHCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class NMEOPKIMDAF : ContainerPropertyBag<KBNGCKGDMPA>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class GHGJHKDODCO : Property<KBNGCKGDMPA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string FMJDNGHFJGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6C8E030", Offset = "0x6C8CA30", VA = "0x186C8E030", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool MEAEOHJNNNH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6C8DFF0", Offset = "0x6C8C9F0", VA = "0x186C8DFF0")]
		public GHGJHKDODCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C970", Offset = "0x6C8B370", VA = "0x186C8C970", Slot = "14")]
		public override object GetValue(KBNGCKGDMPA NKDOKEFKKDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C990", Offset = "0x6C8B390", VA = "0x186C8C990", Slot = "15")]
		public override void SetValue(KBNGCKGDMPA NKDOKEFKKDI, object IPHMAHBENGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6C8EE00", Offset = "0x6C8D800", VA = "0x186C8EE00")]
	public NMEOPKIMDAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal class MHLBHFKCIPA : ContainerPropertyBag<BNFGGMDDGAK>
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private class NNIMCDFNAFN : Property<BNFGGMDDGAK, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string FMJDNGHFJGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6C8EF20", Offset = "0x6C8D920", VA = "0x186C8EF20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool MEAEOHJNNNH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6C8EEE0", Offset = "0x6C8D8E0", VA = "0x186C8EEE0")]
		public NNIMCDFNAFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C970", Offset = "0x6C8B370", VA = "0x186C8C970", Slot = "14")]
		public override object GetValue(BNFGGMDDGAK NKDOKEFKKDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6C8C990", Offset = "0x6C8B390", VA = "0x186C8C990", Slot = "15")]
		public override void SetValue(BNFGGMDDGAK NKDOKEFKKDI, object IPHMAHBENGI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6C8E960", Offset = "0x6C8D360", VA = "0x186C8E960")]
	public MHLBHFKCIPA()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6C8F190", Offset = "0x6C8DB90", VA = "0x186C8F190")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class MDNKJAHJAPB
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public MDNKJAHJAPB()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
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
