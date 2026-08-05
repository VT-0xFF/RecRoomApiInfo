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
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
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
	public class _AssemblyIndex : JFBHLNBAFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6D6A3B0", Offset = "0x6D695B0", VA = "0x186D6A3B0", Slot = "9")]
		public override void BPAAKGIFHPN(PCOBECOJKDN registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6D6A790", Offset = "0x6D69990", VA = "0x186D6A790", Slot = "7")]
		public override void PKFFFNOIEAI(KCABLKMBKAN registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x63262B0", Offset = "0x63254B0", VA = "0x1863262B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct FEFKNNNFMFC : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildBuffer>, FNCANDADBDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9E9440", Offset = "0x9E8640", VA = "0x1809E9440", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x10CE8F0", Offset = "0x10CDAF0", VA = "0x1810CE8F0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6D67670", Offset = "0x6D66870", VA = "0x186D67670", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x10CE8F0", Offset = "0x10CDAF0", VA = "0x1810CE8F0")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9964B0", Offset = "0x9956B0", VA = "0x1809964B0")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, FNCANDADBDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9E9440", Offset = "0x9E8640", VA = "0x1809E9440", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x10CE8F0", Offset = "0x10CDAF0", VA = "0x1810CE8F0", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct MDDMJOGADGL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct LAPBMNFPEJN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity CNPFPPBGLNO;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct MOBMLEGJNGH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity CNPFPPBGLNO;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct BCPBDCPJNEG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<MMFBKHMDLII> ADIHJNBNECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<Entity> CIGJHLCICAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JobHandle PLDBJICEKIC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LHECKIGJCLM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6D67850", Offset = "0x6D66A50", VA = "0x186D67850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int HDFADKJDLLO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6D67800", Offset = "0x6D66A00", VA = "0x186D67800")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4FB3DF0", Offset = "0x4FB2FF0", VA = "0x184FB3DF0")]
	public BCPBDCPJNEG(NativeList<MMFBKHMDLII> ADIHJNBNECL, NativeList<Entity> CIGJHLCICAP, JobHandle PLDBJICEKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6D67680", Offset = "0x6D66880", VA = "0x186D67680")]
	public (Entity, NativeSlice<Entity>) CPCPDCNDLDM(int ABKDFEIGMDF)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6D677A0", Offset = "0x6D669A0", VA = "0x186D677A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct MMFBKHMDLII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Entity LPLEFLJFGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int ECDKJELMFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int KOHJFMFCHKH;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BKEEDPHIOMH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HFOJCFNJKCN(bool KNCEIPBANDA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct CCDLHMDBAIM : IEquatable<CCDLHMDBAIM>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool CKJLPHKAAMF(int NKKKMBMGHIH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool FOCLIBKDPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool NOBMGNIPPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool KCOBACCMDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool EHDLHMDFJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly CKJLPHKAAMF FKCODLCNBOC;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6D67CC0", Offset = "0x6D66EC0", VA = "0x186D67CC0")]
	public CCDLHMDBAIM(BOHCGEJKFCB CBEJFPKIGAM, CKJLPHKAAMF FKCODLCNBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6D67D00", Offset = "0x6D66F00", VA = "0x186D67D00")]
	public CCDLHMDBAIM(bool FOCLIBKDPFF, bool NOBMGNIPPHI, bool KCOBACCMDBG, bool EHDLHMDFJAD, CKJLPHKAAMF FKCODLCNBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6D67C90", Offset = "0x6D66E90", VA = "0x186D67C90")]
	public bool OMPIGJIOBAK(int NKKKMBMGHIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6D67A90", Offset = "0x6D66C90", VA = "0x186D67A90")]
	public bool ECIGLAMODLO(int NKKKMBMGHIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6D67BA0", Offset = "0x6D66DA0", VA = "0x186D67BA0")]
	public bool FAEGIDINGBA(int NKKKMBMGHIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6D67A60", Offset = "0x6D66C60", VA = "0x186D67A60")]
	public bool APCOCBDCFDJ(int NKKKMBMGHIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6D67AC0", Offset = "0x6D66CC0", VA = "0x186D67AC0", Slot = "4")]
	public bool Equals(CCDLHMDBAIM KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6D67AF0", Offset = "0x6D66CF0", VA = "0x186D67AF0", Slot = "0")]
	public override bool Equals(object JMJAOKJJFGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6D67BD0", Offset = "0x6D66DD0", VA = "0x186D67BD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6D67C70", Offset = "0x6D66E70", VA = "0x186D67C70")]
	private bool JLIPNDPGHOK(int NKKKMBMGHIH)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct ANMCCFLCGHO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct GKDENHKCLDH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct FJAKDMGHKKB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[InternalBufferCapacity(17)]
public struct CMGDCMOCDEM : IBufferElementData, IEquatable<CMGDCMOCDEM>, FNCANDADBDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity EGONKIMCNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int JMFOGEOIKCC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity BBLOLOKOGDG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9E9440", Offset = "0x9E8640", VA = "0x1809E9440", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x10CE8F0", Offset = "0x10CDAF0", VA = "0x1810CE8F0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6D67EC0", Offset = "0x6D670C0", VA = "0x186D67EC0", Slot = "4")]
	public bool Equals(CMGDCMOCDEM KDHPJMADEAD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct MJLHFFHKLNB : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct JLNKDBNHJCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly IEGJNHJCOGA BDPBPODCGEA;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x23B1980", Offset = "0x23B0B80", VA = "0x1823B1980")]
		public JLNKDBNHJCL(IEGJNHJCOGA PJNPHFCMPJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6D68C10", Offset = "0x6D67E10", VA = "0x186D68C10")]
		public bool IIEODEKLDPN(MJLHFFHKLNB NEHPIIGCCIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6D68C00", Offset = "0x6D67E00", VA = "0x186D68C00")]
		public bool IHKNKLMFFLC(MJLHFFHKLNB NEHPIIGCCIH, IEGJNHJCOGA BOONFOMLLEC)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly IEGJNHJCOGA LGJOFBGBKIO;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x23B1980", Offset = "0x23B0B80", VA = "0x1823B1980")]
	public MJLHFFHKLNB(IEGJNHJCOGA LGJOFBGBKIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6D69AC0", Offset = "0x6D68CC0", VA = "0x186D69AC0")]
	public MJLHFFHKLNB ILHKDNAFCOO(IEGJNHJCOGA LMMCCHPAHFB)
	{
		return default(MJLHFFHKLNB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6D69AD0", Offset = "0x6D68CD0", VA = "0x186D69AD0")]
	public MJLHFFHKLNB POFNEINLAJC(IEGJNHJCOGA PIJFGGLJKCD)
	{
		return default(MJLHFFHKLNB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6D69AE0", Offset = "0x6D68CE0", VA = "0x186D69AE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[Flags]
public enum IEGJNHJCOGA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	HasShapeChildren = 1,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	HasEmbodiedChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	HasColliders = 4,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	HasObjectBoard = 8,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	HasUserTags = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	TestEmbodiment = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	All = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[Flags]
public enum KFPOPGMKHLL : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[MOFGEJEFMMF]
public struct LGCIIDGEDEK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public KFPOPGMKHLL LGJOFBGBKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public bool NAPCIGLNFKL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool IPLJNIMOIAA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6D69770", Offset = "0x6D68970", VA = "0x186D69770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6D697A0", Offset = "0x6D689A0", VA = "0x186D697A0")]
	private LGCIIDGEDEK(KFPOPGMKHLL LGJOFBGBKIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6D69750", Offset = "0x6D68950", VA = "0x186D69750")]
	public LGCIIDGEDEK ILHKDNAFCOO(KFPOPGMKHLL LMMCCHPAHFB)
	{
		return default(LGCIIDGEDEK);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6D69780", Offset = "0x6D68980", VA = "0x186D69780")]
	public LGCIIDGEDEK POFNEINLAJC(KFPOPGMKHLL PIJFGGLJKCD)
	{
		return default(LGCIIDGEDEK);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct IJJHFDIFBKL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct JLNMODJEAIA : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Entity OHDAPOPAHDC;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildBuffer>, FNCANDADBDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9E9440", Offset = "0x9E8640", VA = "0x1809E9440", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x10CE8F0", Offset = "0x10CDAF0", VA = "0x1810CE8F0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x10CE8F0", Offset = "0x10CDAF0", VA = "0x1810CE8F0")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6D67670", Offset = "0x6D66870", VA = "0x186D67670", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9964B0", Offset = "0x9956B0", VA = "0x1809964B0")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[MOFGEJEFMMF]
public struct KOCLDEKHAEG : ISystemStateBufferElementData, IBufferElementData, FNCANDADBDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Entity NCLCOHLPCDH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Entity PFGDDEFCDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9E9440", Offset = "0x9E8640", VA = "0x1809E9440", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x10CE8F0", Offset = "0x10CDAF0", VA = "0x1810CE8F0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct HPHIAMOCMEN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Entity KKINFBONNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity FOHMOCHLJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Entity HIPECAHOCFK;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct IANNPJOIHPB<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly bool LHNMCLPFALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public uint GPDMPCPJOCA;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool EOMPDEKFBMC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.TypeVersion(2)]
public struct JPDNGBCFJEA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public uint AOGPPDKOPHA;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6D69280", Offset = "0x6D68480", VA = "0x186D69280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct HIJMJKPFCBH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[MOFGEJEFMMF]
public struct JMIBMAKLAKM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int ACDKPIILFIB;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct KPLBEJPALIN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public int KEOJINBLLLG;
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct BHJAIIJNBEN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public GCHandle MLLMAJDMPKA;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct PJKLJPAICNC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public int KEOJINBLLLG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct FBBAMFLHBHA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct IOCCNBAHCPM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public int KEOJINBLLLG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct IIJLHPMGLIK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct APJGJJEECJP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct FFJLMBMDCLK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct GAHNCGKFFEF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public CollisionDetectionMode GNECNLHAKNN;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[MDAMODEDOMP]
public struct DIAGPHEKJAC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public KOEAFBADJNF HOCCCJFBPGG;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly DIAGPHEKJAC OFNBBIHJLBF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct KIIALOPDAGC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct NHHDKOKGFPN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct IOKBOHFMHFO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[InternalBufferCapacity(0)]
public struct MPBPHKJDJIN : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Entity EGONKIMCNJH;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct PDKFFMMKJAL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Entity MBOJNCFILKL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct NMPEOJMGOEG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct NAHPDANLNFC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Entity LPLEFLJFGNH;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct MCMOINOIEAD : HEBBHPABFIC, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public GEBNEDGKNJP LBDCCKDLGCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9E9440", Offset = "0x9E8640", VA = "0x1809E9440", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(GEBNEDGKNJP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x10CE8F0", Offset = "0x10CDAF0", VA = "0x1810CE8F0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct MGODDAENAGK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public float3 CLBPEAHNAFM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct FFPJMEOEBDK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[MDAMODEDOMP]
public struct KAENEFBGHBL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public float3x3 CIPKLJBJOIP;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly KAENEFBGHBL OFNBBIHJLBF;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[MDAMODEDOMP]
public struct LGJCOEAEKIF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public float3x3 CIPKLJBJOIP;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly LGJCOEAEKIF OFNBBIHJLBF;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct PHBDEKJDEJC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public float3 PPDLGAPNEDI;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct GAOBFFAGJPJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float3 KPAMPNANPBC;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[MDAMODEDOMP]
public struct BKIAAHCAPDK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public float HOEFCJKNBDD;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly BKIAAHCAPDK OFNBBIHJLBF;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[MDAMODEDOMP]
public struct HKLFKKKHPKE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public float NIMDOJLFMKJ;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly HKLFKKKHPKE OFNBBIHJLBF;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct BPHJEGPEIAH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public float3 FNHHOACHJIN;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct AODLEPLFPFP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public FNGCGGCLILE NAMFNAAIKIO;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct PKDKJJBHPPB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public FNGCGGCLILE EKKPKOKAJNG;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[MOFGEJEFMMF]
public struct ABLJEJCKDAL : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Entity NCLCOHLPCDH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct KPLOOJPPIBG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct AKCHGCHOHGD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct FFGIIADGNHO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public RigidbodyConstraints POEAJPPIHCP;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[MDAMODEDOMP]
public struct EANMBAEOJPF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float CJBHGBCPLAB;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly EANMBAEOJPF OFNBBIHJLBF;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct PGALCPDMMEE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float LLPNDJIAONK;
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class KNEHEGFDHNB : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct BPMBIIELCNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public object DNMKFBHAOFO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public GameObject PLNJOBKLAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public object FLJJEMJNPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public object JJFFNBBKIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public BPMBIIELCNI DNMKFBHAOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Delegate ECBBFIELAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public Delegate LENCOEIHEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public IMGNAIKAMJF<Delegate> ENPBAIHAJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public IMGNAIKAMJF<Delegate> LNIJEJDNKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public IMGNAIKAMJF<Delegate> ODMMFAAKJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public IMGNAIKAMJF<Delegate> FLGJBHIDAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public IMGNAIKAMJF<Delegate> EGNCNBBHEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public IMGNAIKAMJF<Delegate> CNJEDCIJMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public IMGNAIKAMJF<Delegate> LKNBDKBJHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public IMGNAIKAMJF<Delegate> HJKGKGAIAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public IMGNAIKAMJF<Delegate> IFAADEMGEGN;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6D69550", Offset = "0x6D68750", VA = "0x186D69550", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public KNEHEGFDHNB()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct JJKKEODKFCO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct IAONKNIFMHK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int BPIBPHIBDAJ;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x170B3E0", Offset = "0x170A5E0", VA = "0x18170B3E0")]
	public static IAONKNIFMHK CFMDMKLGJEH(int JECHHBGMFLN)
	{
		return default(IAONKNIFMHK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class DOHHBHKOFIK : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Rigidbody ABNMHEDMNIJ;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6D68340", Offset = "0x6D67540", VA = "0x186D68340", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public DOHHBHKOFIK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct KBKPIDGBEKH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct DEGIGLPIPED : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float3 KFNNJHCHNGF;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct MAAHFJHCOFC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float3 BEEOMEJFEKJ;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[MDAMODEDOMP]
public struct AGLFOBMBAHC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float EEKNJIACMIJ;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly AGLFOBMBAHC OFNBBIHJLBF;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class DGAKMDKGBEB : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public object BJMAFEPOIMN;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6D681A0", Offset = "0x6D673A0", VA = "0x186D681A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public DGAKMDKGBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class BPMJLMIJNJJ : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public object MCMFECHKLHN;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6D679F0", Offset = "0x6D66BF0", VA = "0x186D679F0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public BPMJLMIJNJJ()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct NPHLOAEEBDE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct BPOLDLEECJA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct APNFADHHAOH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct MNCICKEAJHO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct CCCKNJNDGFN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct GDNJLNBLPGC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public FixedString32Bytes EPPPGDEIJCI;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[MOFGEJEFMMF]
public struct JNILDCEFCLL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Entity HKCJCHLCDOF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x9964B0", Offset = "0x9956B0", VA = "0x1809964B0")]
	public static JNILDCEFCLL CFMDMKLGJEH(Entity JECHHBGMFLN)
	{
		return default(JNILDCEFCLL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal struct HGCLGFJGBJG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Entity NCLCOHLPCDH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x9964B0", Offset = "0x9956B0", VA = "0x1809964B0")]
	public static HGCLGFJGBJG CFMDMKLGJEH(Entity NCLCOHLPCDH)
	{
		return default(HGCLGFJGBJG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct HBFCKJFLOJC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Entity LKADJHHFPBA;
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct LNIJEDHDDBJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Entity LKADJHHFPBA;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal struct DMHPCGDGMMD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Entity LPKBLGPBKAD;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x9964B0", Offset = "0x9956B0", VA = "0x1809964B0")]
	public static DMHPCGDGMMD CFMDMKLGJEH(Entity NCLCOHLPCDH)
	{
		return default(DMHPCGDGMMD);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal struct NJBNNPEHAEN : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct EFBDCEPPIPI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct KDHHBJDFOLF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public uint AIIGKGFGNPA;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[MOFGEJEFMMF]
internal struct JCKKMNBDBIB : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Entity ECCEAALEAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int KINMHNEMPOD;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal struct AOHAEDNJIDJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Entity HPLBHDENDNF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct MKDKPLOHKIG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct GKNLAGNILBE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public uint GPDMPCPJOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public int FLOJOEHLBII;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xA0A040", Offset = "0xA09240", VA = "0x180A0A040")]
	public GKNLAGNILBE(uint EFKFBKBMNNB, int IOBPHDDLPAE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct DFBNDJABELB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct MNDOEPJIJIA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct KDOALNNEIAN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct BKEOLALIHOE : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct GFDNHEPHDCL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct LIDHKDBAJJK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct NNJCLCIDNCC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct LIHGLLLJLBL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal struct IEIGOBODDAF : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct IEKOGJMIPPE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct AIJPLLEBBNF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct ANDCBNBGGLI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal struct KKBBGFAPGIG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal struct GEPCFCPICJP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct IHLCPOANPFP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct OCGMDOGKMOB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct AOEOOMFGEFB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct COIAKEMFBJG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct KEHIFJGNNDC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct DEBCJCKIPKF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct KNKALPCDOJF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct OMHMOOPABIN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct IIPBCIFKPDO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct NALDFAGFHNE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal struct MBPMOJOANOH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct JLNFLINJKMC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct GHHAGNKDHNG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct HGFFCMNMKFA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[MOFGEJEFMMF]
public struct KDJKMMNMHFI : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public FixedString32Bytes FIFHCLBFGGO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct AHLLPONMMKL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct DFBPBKGHNAF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal struct MAAPPNLOLEM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal struct MELKKMKDAAC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal struct GDBJKFOIAFF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct NJFLHGDJBBC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct LADPFNMBECI : IComponentData, IComparable<LADPFNMBECI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public int HLGNMOOIEGG;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1F0DBD0", Offset = "0x1F0CDD0", VA = "0x181F0DBD0", Slot = "4")]
	public int CompareTo(LADPFNMBECI KDHPJMADEAD)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct EJPCAADLNMG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct ADABCICPIBD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public quaternion MBMKLLFOFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float3 FJFKFIAGEPM;
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct NDBMIBHFFGP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float MJKCKDFLGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float FMJKBLLAOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public float BBFFMILNGMC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct NOLFGLLAEPM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct DLFJKJBHEPA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct BJDLCMNEPDE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct NBLJFBFBEMH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public int KEOJINBLLLG;
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[MOFGEJEFMMF]
public struct DEDCBDEBJGG : ISystemStateBufferElementData, IBufferElementData, FNCANDADBDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Entity DNEJKACBLKI;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Entity PFGDDEFCDEI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9E9440", Offset = "0x9E8640", VA = "0x1809E9440", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x10CE8F0", Offset = "0x10CDAF0", VA = "0x1810CE8F0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[MDAMODEDOMP]
public struct OCAFDEFHELL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public float4x4 NPDEDMIKIMG;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly OCAFDEFHELL OFNBBIHJLBF;
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[MDAMODEDOMP]
public struct GNBPNNIHCPK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public float4x4 BOKHKDMLALF;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly GNBPNNIHCPK OFNBBIHJLBF;
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public struct GCIIJICMLOF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private int KMBPLDEJHMG;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int KINMHNEMPOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6D68710", Offset = "0x6D67910", VA = "0x186D68710")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6D68700", Offset = "0x6D67900", VA = "0x186D68700")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[MDAMODEDOMP]
public struct LNPFKPNDIEP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public float3 NLIGMGPLGMH;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public static readonly LNPFKPNDIEP OFNBBIHJLBF;
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[MDAMODEDOMP]
public struct CDMIBNBBFDE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float3 FJFKFIAGEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public quaternion MBMKLLFOFFL;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly CDMIBNBBFDE OFNBBIHJLBF;
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class BDAPEKJCELC
{
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[MDAMODEDOMP]
public struct DKPIAIJNIDF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float LHEGCCJGBMF;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly DKPIAIJNIDF OFNBBIHJLBF;
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct BBLEOCMJDBL : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Entity BCMKDGDGINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public IABBCBEHFAO MBLCENENKDK;
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct NOPKAIEBCKD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public IABBCBEHFAO MBLCENENKDK;
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct BEBMBFBAONA : ISystemStateComponentData, IComponentData, FNCANDADBDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity LCANHDHOBOG;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity PFGDDEFCDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9E9440", Offset = "0x9E8640", VA = "0x1809E9440", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x10CE8F0", Offset = "0x10CDAF0", VA = "0x1810CE8F0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct GCANNBGFGGK : ISystemStateBufferElementData, IBufferElementData, FNCANDADBDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Entity KPKIAJECIIF;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Entity PFGDDEFCDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9E9440", Offset = "0x9E8640", VA = "0x1809E9440", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x10CE8F0", Offset = "0x10CDAF0", VA = "0x1810CE8F0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct AHCFDIODMHD : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Entity BCMKDGDGINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public IABBCBEHFAO MBLCENENKDK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct DKEFCJFHJLG : IEqualityComparer<AHCFDIODMHD>
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static DKEFCJFHJLG OFNBBIHJLBF;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6D68250", Offset = "0x6D67450", VA = "0x186D68250", Slot = "4")]
	public bool Equals(AHCFDIODMHD AKHPALIKFFK, AHCFDIODMHD PGLPHKNNCEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6D682A0", Offset = "0x6D674A0", VA = "0x186D682A0", Slot = "5")]
	public int GetHashCode(AHCFDIODMHD JMJAOKJJFGJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct MBIEPEILIAN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public FixedList32Bytes<int> CJKIOJKDEFA;
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct AEMMCGDDNNB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public FixedList32Bytes<int> CJKIOJKDEFA;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct MPMOBDIINDC : ISystemStateBufferElementData, IBufferElementData, FNCANDADBDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Entity ANBPKPAKCJF;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private Entity BBLOLOKOGDG
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9E9440", Offset = "0x9E8640", VA = "0x1809E9440", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x10CE8F0", Offset = "0x10CDAF0", VA = "0x1810CE8F0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class JNHBHLEPLLO : ContainerPropertyBag<KNEHEGFDHNB>
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	private class IEKKCNKDOII : Property<KNEHEGFDHNB, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string HPIOEFIINLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6D68AF0", Offset = "0x6D67CF0", VA = "0x186D68AF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool CFPKGOMMBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6D68AB0", Offset = "0x6D67CB0", VA = "0x186D68AB0")]
		public IEKKCNKDOII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6D68000", Offset = "0x6D67200", VA = "0x186D68000", Slot = "14")]
		public override GameObject GetValue(KNEHEGFDHNB DDIEINIMBGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6D68020", Offset = "0x6D67220", VA = "0x186D68020", Slot = "15")]
		public override void SetValue(KNEHEGFDHNB DDIEINIMBGH, GameObject JECHHBGMFLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class KOMPJHINHGD : Property<KNEHEGFDHNB, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string HPIOEFIINLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6D69630", Offset = "0x6D68830", VA = "0x186D69630", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool CFPKGOMMBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6D695F0", Offset = "0x6D687F0", VA = "0x186D695F0")]
		public KOMPJHINHGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6D695A0", Offset = "0x6D687A0", VA = "0x186D695A0", Slot = "14")]
		public override object GetValue(KNEHEGFDHNB DDIEINIMBGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6D695C0", Offset = "0x6D687C0", VA = "0x186D695C0", Slot = "15")]
		public override void SetValue(KNEHEGFDHNB DDIEINIMBGH, object JECHHBGMFLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class PBFNLLLLODO : Property<KNEHEGFDHNB, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string HPIOEFIINLC
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6D69DE0", Offset = "0x6D68FE0", VA = "0x186D69DE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool CFPKGOMMBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6D69DA0", Offset = "0x6D68FA0", VA = "0x186D69DA0")]
		public PBFNLLLLODO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6D69D50", Offset = "0x6D68F50", VA = "0x186D69D50", Slot = "14")]
		public override object GetValue(KNEHEGFDHNB DDIEINIMBGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6D69D70", Offset = "0x6D68F70", VA = "0x186D69D70", Slot = "15")]
		public override void SetValue(KNEHEGFDHNB DDIEINIMBGH, object JECHHBGMFLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	private class HEDFKPBPMDL : Property<KNEHEGFDHNB, KNEHEGFDHNB.BPMBIIELCNI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string HPIOEFIINLC
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6D68950", Offset = "0x6D67B50", VA = "0x186D68950", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool CFPKGOMMBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6D68910", Offset = "0x6D67B10", VA = "0x186D68910")]
		public HEDFKPBPMDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6D688C0", Offset = "0x6D67AC0", VA = "0x186D688C0", Slot = "14")]
		public override KNEHEGFDHNB.BPMBIIELCNI GetValue(KNEHEGFDHNB DDIEINIMBGH)
		{
			return default(KNEHEGFDHNB.BPMBIIELCNI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6D688E0", Offset = "0x6D67AE0", VA = "0x186D688E0", Slot = "15")]
		public override void SetValue(KNEHEGFDHNB DDIEINIMBGH, KNEHEGFDHNB.BPMBIIELCNI JECHHBGMFLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private class MDFFMEGCLJI : Property<KNEHEGFDHNB, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string HPIOEFIINLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6D69A90", Offset = "0x6D68C90", VA = "0x186D69A90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool CFPKGOMMBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6D69A50", Offset = "0x6D68C50", VA = "0x186D69A50")]
		public MDFFMEGCLJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6D69A00", Offset = "0x6D68C00", VA = "0x186D69A00", Slot = "14")]
		public override Delegate GetValue(KNEHEGFDHNB DDIEINIMBGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6D69A20", Offset = "0x6D68C20", VA = "0x186D69A20", Slot = "15")]
		public override void SetValue(KNEHEGFDHNB DDIEINIMBGH, Delegate JECHHBGMFLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	private class PHEJIAPJIPF : Property<KNEHEGFDHNB, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string HPIOEFIINLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6D69EA0", Offset = "0x6D690A0", VA = "0x186D69EA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool CFPKGOMMBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6D69E60", Offset = "0x6D69060", VA = "0x186D69E60")]
		public PHEJIAPJIPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6D69E10", Offset = "0x6D69010", VA = "0x186D69E10", Slot = "14")]
		public override Delegate GetValue(KNEHEGFDHNB DDIEINIMBGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6D69E30", Offset = "0x6D69030", VA = "0x186D69E30", Slot = "15")]
		public override void SetValue(KNEHEGFDHNB DDIEINIMBGH, Delegate JECHHBGMFLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private class FDPOOHMHICF : Property<KNEHEGFDHNB, IMGNAIKAMJF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string HPIOEFIINLC
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6D68510", Offset = "0x6D67710", VA = "0x186D68510", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool CFPKGOMMBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6D684D0", Offset = "0x6D676D0", VA = "0x186D684D0")]
		public FDPOOHMHICF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6D68460", Offset = "0x6D67660", VA = "0x186D68460", Slot = "14")]
		public override IMGNAIKAMJF<Delegate> GetValue(KNEHEGFDHNB DDIEINIMBGH)
		{
			return default(IMGNAIKAMJF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6D68490", Offset = "0x6D67690", VA = "0x186D68490", Slot = "15")]
		public override void SetValue(KNEHEGFDHNB DDIEINIMBGH, IMGNAIKAMJF<Delegate> JECHHBGMFLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private class DFLIAKDMFLO : Property<KNEHEGFDHNB, IMGNAIKAMJF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string HPIOEFIINLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6D68170", Offset = "0x6D67370", VA = "0x186D68170", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool CFPKGOMMBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6D68130", Offset = "0x6D67330", VA = "0x186D68130")]
		public DFLIAKDMFLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6D680C0", Offset = "0x6D672C0", VA = "0x186D680C0", Slot = "14")]
		public override IMGNAIKAMJF<Delegate> GetValue(KNEHEGFDHNB DDIEINIMBGH)
		{
			return default(IMGNAIKAMJF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6D680F0", Offset = "0x6D672F0", VA = "0x186D680F0", Slot = "15")]
		public override void SetValue(KNEHEGFDHNB DDIEINIMBGH, IMGNAIKAMJF<Delegate> JECHHBGMFLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class ILHMNAKGLHJ : Property<KNEHEGFDHNB, IMGNAIKAMJF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string HPIOEFIINLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6D68BD0", Offset = "0x6D67DD0", VA = "0x186D68BD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool CFPKGOMMBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6D68B90", Offset = "0x6D67D90", VA = "0x186D68B90")]
		public ILHMNAKGLHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6D68B20", Offset = "0x6D67D20", VA = "0x186D68B20", Slot = "14")]
		public override IMGNAIKAMJF<Delegate> GetValue(KNEHEGFDHNB DDIEINIMBGH)
		{
			return default(IMGNAIKAMJF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6D68B50", Offset = "0x6D67D50", VA = "0x186D68B50", Slot = "15")]
		public override void SetValue(KNEHEGFDHNB DDIEINIMBGH, IMGNAIKAMJF<Delegate> JECHHBGMFLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	private class HLFFJJGBFOI : Property<KNEHEGFDHNB, IMGNAIKAMJF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string HPIOEFIINLC
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6D68A80", Offset = "0x6D67C80", VA = "0x186D68A80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool CFPKGOMMBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6D68A40", Offset = "0x6D67C40", VA = "0x186D68A40")]
		public HLFFJJGBFOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6D689C0", Offset = "0x6D67BC0", VA = "0x186D689C0", Slot = "14")]
		public override IMGNAIKAMJF<Delegate> GetValue(KNEHEGFDHNB DDIEINIMBGH)
		{
			return default(IMGNAIKAMJF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6D68A00", Offset = "0x6D67C00", VA = "0x186D68A00", Slot = "15")]
		public override void SetValue(KNEHEGFDHNB DDIEINIMBGH, IMGNAIKAMJF<Delegate> JECHHBGMFLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private class CNPADDOBPGB : Property<KNEHEGFDHNB, IMGNAIKAMJF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string HPIOEFIINLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6D67FD0", Offset = "0x6D671D0", VA = "0x186D67FD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool CFPKGOMMBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6D67F90", Offset = "0x6D67190", VA = "0x186D67F90")]
		public CNPADDOBPGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6D67F10", Offset = "0x6D67110", VA = "0x186D67F10", Slot = "14")]
		public override IMGNAIKAMJF<Delegate> GetValue(KNEHEGFDHNB DDIEINIMBGH)
		{
			return default(IMGNAIKAMJF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6D67F50", Offset = "0x6D67150", VA = "0x186D67F50", Slot = "15")]
		public override void SetValue(KNEHEGFDHNB DDIEINIMBGH, IMGNAIKAMJF<Delegate> JECHHBGMFLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	private class GNBJBDBMBJH : Property<KNEHEGFDHNB, IMGNAIKAMJF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string HPIOEFIINLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6D687E0", Offset = "0x6D679E0", VA = "0x186D687E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool CFPKGOMMBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6D687A0", Offset = "0x6D679A0", VA = "0x186D687A0")]
		public GNBJBDBMBJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6D68720", Offset = "0x6D67920", VA = "0x186D68720", Slot = "14")]
		public override IMGNAIKAMJF<Delegate> GetValue(KNEHEGFDHNB DDIEINIMBGH)
		{
			return default(IMGNAIKAMJF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6D68760", Offset = "0x6D67960", VA = "0x186D68760", Slot = "15")]
		public override void SetValue(KNEHEGFDHNB DDIEINIMBGH, IMGNAIKAMJF<Delegate> JECHHBGMFLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	private class LCACOBFNGJI : Property<KNEHEGFDHNB, IMGNAIKAMJF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string HPIOEFIINLC
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6D69720", Offset = "0x6D68920", VA = "0x186D69720", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool CFPKGOMMBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6D696E0", Offset = "0x6D688E0", VA = "0x186D696E0")]
		public LCACOBFNGJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6D69660", Offset = "0x6D68860", VA = "0x186D69660", Slot = "14")]
		public override IMGNAIKAMJF<Delegate> GetValue(KNEHEGFDHNB DDIEINIMBGH)
		{
			return default(IMGNAIKAMJF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6D696A0", Offset = "0x6D688A0", VA = "0x186D696A0", Slot = "15")]
		public override void SetValue(KNEHEGFDHNB DDIEINIMBGH, IMGNAIKAMJF<Delegate> JECHHBGMFLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class BOHNOEPHKBH : Property<KNEHEGFDHNB, IMGNAIKAMJF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string HPIOEFIINLC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x6D679C0", Offset = "0x6D66BC0", VA = "0x186D679C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool CFPKGOMMBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6D67980", Offset = "0x6D66B80", VA = "0x186D67980")]
		public BOHNOEPHKBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6D67900", Offset = "0x6D66B00", VA = "0x186D67900", Slot = "14")]
		public override IMGNAIKAMJF<Delegate> GetValue(KNEHEGFDHNB DDIEINIMBGH)
		{
			return default(IMGNAIKAMJF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6D67940", Offset = "0x6D66B40", VA = "0x186D67940", Slot = "15")]
		public override void SetValue(KNEHEGFDHNB DDIEINIMBGH, IMGNAIKAMJF<Delegate> JECHHBGMFLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	private class NCPNLBKGFCO : Property<KNEHEGFDHNB, IMGNAIKAMJF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string HPIOEFIINLC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6D69C00", Offset = "0x6D68E00", VA = "0x186D69C00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool CFPKGOMMBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6D69BC0", Offset = "0x6D68DC0", VA = "0x186D69BC0")]
		public NCPNLBKGFCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6D69B40", Offset = "0x6D68D40", VA = "0x186D69B40", Slot = "14")]
		public override IMGNAIKAMJF<Delegate> GetValue(KNEHEGFDHNB DDIEINIMBGH)
		{
			return default(IMGNAIKAMJF<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6D69B80", Offset = "0x6D68D80", VA = "0x186D69B80", Slot = "15")]
		public override void SetValue(KNEHEGFDHNB DDIEINIMBGH, IMGNAIKAMJF<Delegate> JECHHBGMFLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6D68C20", Offset = "0x6D67E20", VA = "0x186D68C20")]
	public JNHBHLEPLLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal class LMAFLEMAGLG : ContainerPropertyBag<KNEHEGFDHNB.BPMBIIELCNI>
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private class KCBOGLCMODC : Property<KNEHEGFDHNB.BPMBIIELCNI, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string HPIOEFIINLC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6D69520", Offset = "0x6D68720", VA = "0x186D69520", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool CFPKGOMMBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6D694E0", Offset = "0x6D686E0", VA = "0x186D694E0")]
		public KCBOGLCMODC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9A8B60", Offset = "0x9A7D60", VA = "0x1809A8B60", Slot = "14")]
		public override object GetValue(KNEHEGFDHNB.BPMBIIELCNI DDIEINIMBGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4ADA4B0", Offset = "0x4AD96B0", VA = "0x184ADA4B0", Slot = "15")]
		public override void SetValue(KNEHEGFDHNB.BPMBIIELCNI DDIEINIMBGH, object JECHHBGMFLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6D698A0", Offset = "0x6D68AA0", VA = "0x186D698A0")]
	public LMAFLEMAGLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class CJIDJEGKMCP : ContainerPropertyBag<IMGNAIKAMJF<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6D67E60", Offset = "0x6D67060", VA = "0x186D67E60")]
	public CJIDJEGKMCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal class GACIAHMJNPH : ContainerPropertyBag<DOHHBHKOFIK>
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class NJBMNMNJEDE : Property<DOHHBHKOFIK, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string HPIOEFIINLC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6D69C70", Offset = "0x6D68E70", VA = "0x186D69C70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool CFPKGOMMBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6D69C30", Offset = "0x6D68E30", VA = "0x186D69C30")]
		public NJBMNMNJEDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6D68000", Offset = "0x6D67200", VA = "0x186D68000", Slot = "14")]
		public override Rigidbody GetValue(DOHHBHKOFIK DDIEINIMBGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6D68020", Offset = "0x6D67220", VA = "0x186D68020", Slot = "15")]
		public override void SetValue(DOHHBHKOFIK DDIEINIMBGH, Rigidbody JECHHBGMFLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6D68620", Offset = "0x6D67820", VA = "0x186D68620")]
	public GACIAHMJNPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class KAOIKBGLBDB : ContainerPropertyBag<DGAKMDKGBEB>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class CONFENOIEDC : Property<DGAKMDKGBEB, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string HPIOEFIINLC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6D68090", Offset = "0x6D67290", VA = "0x186D68090", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool CFPKGOMMBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6D68050", Offset = "0x6D67250", VA = "0x186D68050")]
		public CONFENOIEDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6D68000", Offset = "0x6D67200", VA = "0x186D68000", Slot = "14")]
		public override object GetValue(DGAKMDKGBEB DDIEINIMBGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6D68020", Offset = "0x6D67220", VA = "0x186D68020", Slot = "15")]
		public override void SetValue(DGAKMDKGBEB DDIEINIMBGH, object JECHHBGMFLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6D69400", Offset = "0x6D68600", VA = "0x186D69400")]
	public KAOIKBGLBDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal class FIJMNJLMIIK : ContainerPropertyBag<BPMJLMIJNJJ>
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private class EDBELDFMKLE : Property<BPMJLMIJNJJ, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string HPIOEFIINLC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6D68430", Offset = "0x6D67630", VA = "0x186D68430", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool CFPKGOMMBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8DEA80", Offset = "0x8DDC80", VA = "0x1808DEA80", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6D683F0", Offset = "0x6D675F0", VA = "0x186D683F0")]
		public EDBELDFMKLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6D68000", Offset = "0x6D67200", VA = "0x186D68000", Slot = "14")]
		public override object GetValue(BPMJLMIJNJJ DDIEINIMBGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6D68020", Offset = "0x6D67220", VA = "0x186D68020", Slot = "15")]
		public override void SetValue(BPMJLMIJNJJ DDIEINIMBGH, object JECHHBGMFLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6D68540", Offset = "0x6D67740", VA = "0x186D68540")]
	public FIJMNJLMIIK()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6D69ED0", Offset = "0x6D690D0", VA = "0x186D69ED0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class AMHLBKDNBBM
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public AMHLBKDNBBM()
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
