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
		[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
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
	public class _AssemblyIndex : MBJBLHMHHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x64C69B0", Offset = "0x64C5BB0", VA = "0x1864C69B0", Slot = "8")]
		public override void EMMAINJNGHI(AICMJOGJDAO registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x64C6DB0", Offset = "0x64C5FB0", VA = "0x1864C6DB0", Slot = "7")]
		public override void LHLPEFGBADE(IMHMMPOFLAI registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x64C70F0", Offset = "0x64C62F0", VA = "0x1864C70F0")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct AEGLDJFCAMA : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, LHEDAECFFLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x64C3EE0", Offset = "0x64C30E0", VA = "0x1864C3EE0", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0")]
		public AuthoredChildrenData(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x865250", Offset = "0x864450", VA = "0x180865250")]
		public static implicit operator AuthoredChildrenData(Entity entity)
		{
			return default(AuthoredChildrenData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, LHEDAECFFLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct IIMMFKAPIJC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct MBGCBKMODDL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity MNKIMDHNHCP;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct LLEAKLHCAON : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity MNKIMDHNHCP;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct DFHONOJNOEJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<NAMBGNBFNCF> KNFKBNDAICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<Entity> GHMLEMKLHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JobHandle KNINPPAAPPF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BOAGEKAOIBH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x64C4610", Offset = "0x64C3810", VA = "0x1864C4610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int HJGLMCCDDEF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x64C47A0", Offset = "0x64C39A0", VA = "0x1864C47A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x48952F0", Offset = "0x48944F0", VA = "0x1848952F0")]
	public DFHONOJNOEJ(NativeList<NAMBGNBFNCF> KNFKBNDAICO, NativeList<Entity> GHMLEMKLHFA, JobHandle KNINPPAAPPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x64C4680", Offset = "0x64C3880", VA = "0x1864C4680")]
	public (Entity, NativeSlice<Entity>) NGENEFPMAKH(int BJOOMLAOBEG)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x64C45B0", Offset = "0x64C37B0", VA = "0x1864C45B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct NAMBGNBFNCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Entity LNOFAKNEFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int CFPEDCFCDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int MKCBFIBLIDD;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ENFPOFMALBI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PKANAJNEEBC(bool BMCNPHDGILL);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct OPBCKKJBLPD : IEquatable<OPBCKKJBLPD>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool HNKBOJAOMJO(int MDCNPPDPLHN);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool EBKNADDOLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool GNCCLKPKADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool MBACLHENEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool LHGJLLMGPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly HNKBOJAOMJO CAINJKELODF;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x64C6350", Offset = "0x64C5550", VA = "0x1864C6350")]
	public OPBCKKJBLPD(ACJBFNFLLFC HOFNLGPBEHO, HNKBOJAOMJO CAINJKELODF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x64C6320", Offset = "0x64C5520", VA = "0x1864C6320")]
	public OPBCKKJBLPD(bool EBKNADDOLIH, bool GNCCLKPKADN, bool MBACLHENEIL, bool LHGJLLMGPNM, HNKBOJAOMJO CAINJKELODF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x64C60C0", Offset = "0x64C52C0", VA = "0x1864C60C0")]
	public bool AGAINONAHDN(int MDCNPPDPLHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x64C62F0", Offset = "0x64C54F0", VA = "0x1864C62F0")]
	public bool LNOINMHDDBE(int MDCNPPDPLHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x64C60F0", Offset = "0x64C52F0", VA = "0x1864C60F0")]
	public bool DPINGGCOEIC(int MDCNPPDPLHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x64C62C0", Offset = "0x64C54C0", VA = "0x1864C62C0")]
	public bool JDMGENHDEPA(int MDCNPPDPLHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x64C61F0", Offset = "0x64C53F0", VA = "0x1864C61F0", Slot = "4")]
	public bool Equals(OPBCKKJBLPD JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x64C6140", Offset = "0x64C5340", VA = "0x1864C6140", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x64C6220", Offset = "0x64C5420", VA = "0x1864C6220", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x64C6120", Offset = "0x64C5320", VA = "0x1864C6120")]
	private bool EFLBEGICDMA(int MDCNPPDPLHN)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct OPCCLDDMDAI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct NHHDPCHNPJC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct PJEGCNABKCP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[InternalBufferCapacity(17)]
public struct EHFODAPNFCI : IBufferElementData, IEquatable<EHFODAPNFCI>, LHEDAECFFLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity POGNIHKEPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int IOLMDHFIFNJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity ELMKMJHIFHM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x64C48D0", Offset = "0x64C3AD0", VA = "0x1864C48D0", Slot = "4")]
	public bool Equals(EHFODAPNFCI JPLJHFMPDFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct JOGFPBNPGFO : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Entity CMCNCKBGCML;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, LHEDAECFFLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x64C3EE0", Offset = "0x64C30E0", VA = "0x1864C3EE0", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x865250", Offset = "0x864450", VA = "0x180865250")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct FFCCNFOPGCJ<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly bool DOILPLLJOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public uint FJCDEDCONMA;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	private static bool NCIGGAMNMHB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[TypeManager.TypeVersion(2)]
public struct NKAAIHBECLL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public uint ONILIGIIOEN;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x64C5EA0", Offset = "0x64C50A0", VA = "0x1864C5EA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct KJBEMONPLAL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public int HGLMKMOLHBA;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct NAMNBHFLCMN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public GCHandle DJDMFBFINHD;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct MDKJOELLHNE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int HGLMKMOLHBA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct GIBNIPBEIJK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct HCPEADMLFBO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int HGLMKMOLHBA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct JMFPLBKADNH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct JBPPDDBBNMC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct MBBKILLEDIE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct IEDNNGGHCPO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public CollisionDetectionMode MIEBMAGPBNF;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[FCHDCIFNOJO]
public struct BHBFDNMDJPK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public IEIKJHNHGAC AGPPKFPDNLK;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly BHBFDNMDJPK DNJMIDOFPAJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct KOOCENMCNHN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct ANLMODGKEBJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct ENHEFDNNPBJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[InternalBufferCapacity(0)]
public struct NBAMIFCCNBL : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public Entity POGNIHKEPMJ;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct FJJLIOFKNBN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Entity BGILIGANMHA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct KIAMAMGIJBF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct HAACIKCDBDO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Entity LNOFAKNEFAA;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct DCIKLLNMJCI : AOFBKMLMKHO, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public PIHIHJEBCFM FMNNEPFGFID
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(PIHIHJEBCFM);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct ILHAIIPHGCD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float3 FLPHCNMPJMP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct FMADJJJFNPK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[FCHDCIFNOJO]
public struct KGOKPAFIJGC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float3x3 EMHOHBOOEKO;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly KGOKPAFIJGC DNJMIDOFPAJ;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[FCHDCIFNOJO]
public struct LDECBMJCJAH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float3x3 EMHOHBOOEKO;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly LDECBMJCJAH DNJMIDOFPAJ;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct IAJGNPBICML : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float3 OBLDIFBPOBP;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct KKNCCDICPJN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float3 HMEFCILFNMC;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[FCHDCIFNOJO]
public struct FNCMGJPKGNP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public float FMJBLDMOEDA;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly FNCMGJPKGNP DNJMIDOFPAJ;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[FCHDCIFNOJO]
public struct GHFLMHHLGCP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public float BNHJIEHFLKO;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly GHFLMHHLGCP DNJMIDOFPAJ;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct OGLNIDNIIOO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float3 FOBAICDJODG;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct IBANAEENOGH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public MGOCMEIHPAH OOIAPDIEPPC;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct IPHJIICNCHD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public MGOCMEIHPAH ONOLCLBICLD;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[EADOLFFDPDB]
public struct GMEHDBJODDF : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Entity FOJNONDDGDN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct BNGKCMDKEIM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct POHCJPJMHPE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct DMLJPNIIACG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public RigidbodyConstraints EKIINMPEHKP;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[FCHDCIFNOJO]
public struct MPHECACJMLP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public float KLBMAGELMNP;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly MPHECACJMLP DNJMIDOFPAJ;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct AAJPNDOCFNB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float KGHHNPPMFPJ;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class FNCPACBDGLM : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public struct OEAJNEMPBOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public object MBBBGFBBHMG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public GameObject IIDBEBHLIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public object GJMGGHAOBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public object EKJKMGNLIEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public OEAJNEMPBOD MBBBGFBBHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Delegate OFLKLENIGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Delegate ECDJNOPEHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public EOANOPKHGBN<Delegate> IDIOIMDAPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public EOANOPKHGBN<Delegate> LECLEBOAAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public EOANOPKHGBN<Delegate> KJMNIIEEAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public EOANOPKHGBN<Delegate> OJFHBKCBPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public EOANOPKHGBN<Delegate> PELJKOOFEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public EOANOPKHGBN<Delegate> GLHAAFHHJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public EOANOPKHGBN<Delegate> DPANKDHNMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public EOANOPKHGBN<Delegate> ICNNAIOEMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public EOANOPKHGBN<Delegate> EOAKPONJOLE;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x64C4A90", Offset = "0x64C3C90", VA = "0x1864C4A90", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public FNCPACBDGLM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct MFKBNIOOFAJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct PKFIBEHKLLB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int KDIEHDDACPB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xD96860", Offset = "0xD95A60", VA = "0x180D96860")]
	public static PKFIBEHKLLB LOFAPGLBJHK(int HLCKBKFCMPI)
	{
		return default(PKFIBEHKLLB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class FCMCFKBCBMD : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Rigidbody NCIFAJPFOJP;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x64C4920", Offset = "0x64C3B20", VA = "0x1864C4920", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public FCMCFKBCBMD()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct JHMJHJJEJHC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct KCIKCIHIGNG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float3 MELEABFLNHP;
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct FCMKJAEJEAE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float3 OAFPAEEDKIL;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[FCHDCIFNOJO]
public struct OAANIDFMHKP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float NANJGBHKMLB;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly OAANIDFMHKP DNJMIDOFPAJ;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class DAKDFBHJAHF : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public object OIGBKHJIDHN;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x64C4540", Offset = "0x64C3740", VA = "0x1864C4540", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public DAKDFBHJAHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class KNCKBBOHPNM : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public object NMFNLDIAMIG;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x64C5860", Offset = "0x64C4A60", VA = "0x1864C5860", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public KNCKBBOHPNM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct MOEAKONPMIK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct FIFKCCIPIPL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct LFNMOLGBHOH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct CNHLJJBGCEC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public FixedString32Bytes IIADHBOODBK;
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[EADOLFFDPDB]
public struct FOCNLMHNIDG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Entity FOBJGNMALAM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x865250", Offset = "0x864450", VA = "0x180865250")]
	public static FOCNLMHNIDG LOFAPGLBJHK(Entity HLCKBKFCMPI)
	{
		return default(FOCNLMHNIDG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal struct ILJAMELLELP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public Entity FOJNONDDGDN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x865250", Offset = "0x864450", VA = "0x180865250")]
	public static ILJAMELLELP LOFAPGLBJHK(Entity FOJNONDDGDN)
	{
		return default(ILJAMELLELP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct COKHDLIMDCF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public Entity CGBFJCNGHPP;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct LJEEJIGMMFG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Entity CGBFJCNGHPP;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal struct CKLJJPAPFHI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Entity LIDMHLODBLB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x865250", Offset = "0x864450", VA = "0x180865250")]
	public static CKLJJPAPFHI LOFAPGLBJHK(Entity FOJNONDDGDN)
	{
		return default(CKLJJPAPFHI);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal struct PGNFKNAFFFL : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct IMHFHEDAABN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public uint DHGBHLPPCDP;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[EADOLFFDPDB]
internal struct COHMIOEMFEP : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Entity NMENKOCBHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public int PMNHOLIPOMJ;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal struct GFPKFDFMDPJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public Entity BCALGAKKMJK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct LNBEEHOIPFA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct EDBFDBEGODJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public uint FJCDEDCONMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public int HKBELCKPJFJ;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xB93B00", Offset = "0xB92D00", VA = "0x180B93B00")]
	public EDBFDBEGODJ(uint OPADBJMPMGK, int HCDGPIHAGLF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct GMEINECOBKD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct FHHIMLMAKDO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct LGNCKLOHDFO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct GDAFGKEODDE : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct ECNKEDEGCGN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct PIEKMAAKIGD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
public struct OBLAMPFPKAM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct IANBHBKPEFL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal struct DHLMKNOOLEF : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct DGBOJJOPJOC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct MKHGDHFFLFB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct BEBBGAGFBLB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal struct MOJGDNEOGEH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct JBPAJNFCFML : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct FGACIMDBLJA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct AKJEEOIMCPJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct JHJOOKLCGII : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct HMKKDBBBOFM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct EIBMDIJPEDB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct OHFDAGJPIMC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct JMDHAOONHMA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct MNEDGPBFFCL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct FHLMPPFJLGD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal struct BFKLBPPIPHM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct IANFOLFBEKK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct GGCPJPNGHEL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct JJACLLIILAI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[EADOLFFDPDB]
public struct KACPGEEMIJM : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public FixedString32Bytes KKPDFEBGEBN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct PAKEOBNBEHJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal struct DDHFCEDDOCP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal struct KFNLPNECODB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal struct KKPIDDOILPM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct OKODIHGLMIF : IComponentData, IComparable<OKODIHGLMIF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int BCNNLJHICFA;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x19A1470", Offset = "0x19A0670", VA = "0x1819A1470", Slot = "4")]
	public int CompareTo(OKODIHGLMIF JPLJHFMPDFD)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct IKDFNLDBGLM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct KLEEGGLBPJK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public quaternion JCCMNAMJFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float3 CAOOPLKANIG;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct MGCGDMFMODF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float AABGPCPPAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float MLOENNOACPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float ECJFEMOGKED;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct HJNPKEDOHFB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct OJHGHKIALKM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct HDKGFIFNKLB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct OBDJHIMHGGK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int HGLMKMOLHBA;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[EADOLFFDPDB]
public struct MNKAKMCDKAK : ISystemStateBufferElementData, IBufferElementData, LHEDAECFFLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Entity LPDMDILMCLC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Entity ONAMKGBJPDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x837D70", Offset = "0x836F70", VA = "0x180837D70", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1999BA0", Offset = "0x1998DA0", VA = "0x181999BA0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[FCHDCIFNOJO]
public struct JMFELCOAHCN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float4x4 CPANELLDJMA;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly JMFELCOAHCN DNJMIDOFPAJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct FGFBMEHCIMC : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct CFENACECBNE : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct COELGIMEHMA : IComponentData, IEnableableComponent
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct GEDAEGPOEFG : IComponentData, IEnableableComponent
{
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[FCHDCIFNOJO]
public struct BBIIBGPOMLN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float4x4 NBFEINKEDJM;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly BBIIBGPOMLN DNJMIDOFPAJ;
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct GJLMPFHPNNP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int BPOPFPJLEHH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int PMNHOLIPOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x64C4C70", Offset = "0x64C3E70", VA = "0x1864C4C70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x64C4C80", Offset = "0x64C3E80", VA = "0x1864C4C80")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[FCHDCIFNOJO]
public struct PJBFPKCFFLN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 BAGNCAJEHLD;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly PJBFPKCFFLN DNJMIDOFPAJ;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[FCHDCIFNOJO]
public struct BEKLDFJMPNG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float3 CAOOPLKANIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public quaternion JCCMNAMJFGM;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public static readonly BEKLDFJMPNG DNJMIDOFPAJ;
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public static class OBPAIACPMBN
{
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[FCHDCIFNOJO]
public struct KMPELKHJLCC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public float HEHJCOAAOHE;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public static readonly KMPELKHJLCC DNJMIDOFPAJ;
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct AKJDKALNLGP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public FixedList32Bytes<int> IHLALKIMHCE;
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct IFEGHMMDDDC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public FixedList32Bytes<int> IHLALKIMHCE;
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal class GOPIJCCFLND : ContainerPropertyBag<FNCPACBDGLM>
{
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	private class MJFPACFHFAM : Property<FNCPACBDGLM, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override string KLNBLIAPPFE
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x64C5E30", Offset = "0x64C5030", VA = "0x1864C5E30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override bool PMLPHGCHDJB
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x64C5DF0", Offset = "0x64C4FF0", VA = "0x1864C5DF0")]
		public MJFPACFHFAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x64C43C0", Offset = "0x64C35C0", VA = "0x1864C43C0", Slot = "14")]
		public override GameObject GetValue(FNCPACBDGLM IFAAMIKFIMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x64C43E0", Offset = "0x64C35E0", VA = "0x1864C43E0", Slot = "15")]
		public override void SetValue(FNCPACBDGLM IFAAMIKFIMC, GameObject HLCKBKFCMPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	private class KKAJGMJGPCF : Property<FNCPACBDGLM, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override string KLNBLIAPPFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x64C57F0", Offset = "0x64C49F0", VA = "0x1864C57F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool PMLPHGCHDJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x64C57B0", Offset = "0x64C49B0", VA = "0x1864C57B0")]
		public KKAJGMJGPCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x64C5760", Offset = "0x64C4960", VA = "0x1864C5760", Slot = "14")]
		public override object GetValue(FNCPACBDGLM IFAAMIKFIMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x64C5780", Offset = "0x64C4980", VA = "0x1864C5780", Slot = "15")]
		public override void SetValue(FNCPACBDGLM IFAAMIKFIMC, object HLCKBKFCMPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private class PGICLJNNIAO : Property<FNCPACBDGLM, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override string KLNBLIAPPFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x64C6420", Offset = "0x64C5620", VA = "0x1864C6420", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override bool PMLPHGCHDJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x64C63E0", Offset = "0x64C55E0", VA = "0x1864C63E0")]
		public PGICLJNNIAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x64C6390", Offset = "0x64C5590", VA = "0x1864C6390", Slot = "14")]
		public override object GetValue(FNCPACBDGLM IFAAMIKFIMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x64C63B0", Offset = "0x64C55B0", VA = "0x1864C63B0", Slot = "15")]
		public override void SetValue(FNCPACBDGLM IFAAMIKFIMC, object HLCKBKFCMPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private class FJODENMJBMG : Property<FNCPACBDGLM, FNCPACBDGLM.OEAJNEMPBOD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override string KLNBLIAPPFE
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x64C4A20", Offset = "0x64C3C20", VA = "0x1864C4A20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override bool PMLPHGCHDJB
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x64C49E0", Offset = "0x64C3BE0", VA = "0x1864C49E0")]
		public FJODENMJBMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x64C4990", Offset = "0x64C3B90", VA = "0x1864C4990", Slot = "14")]
		public override FNCPACBDGLM.OEAJNEMPBOD GetValue(FNCPACBDGLM IFAAMIKFIMC)
		{
			return default(FNCPACBDGLM.OEAJNEMPBOD);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x64C49B0", Offset = "0x64C3BB0", VA = "0x1864C49B0", Slot = "15")]
		public override void SetValue(FNCPACBDGLM IFAAMIKFIMC, FNCPACBDGLM.OEAJNEMPBOD HLCKBKFCMPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	private class ACJGJGFGLFN : Property<FNCPACBDGLM, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override string KLNBLIAPPFE
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x64C3EB0", Offset = "0x64C30B0", VA = "0x1864C3EB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override bool PMLPHGCHDJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x64C3E70", Offset = "0x64C3070", VA = "0x1864C3E70")]
		public ACJGJGFGLFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x64C3E20", Offset = "0x64C3020", VA = "0x1864C3E20", Slot = "14")]
		public override Delegate GetValue(FNCPACBDGLM IFAAMIKFIMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x64C3E40", Offset = "0x64C3040", VA = "0x1864C3E40", Slot = "15")]
		public override void SetValue(FNCPACBDGLM IFAAMIKFIMC, Delegate HLCKBKFCMPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	private class CPHFHPKJFOL : Property<FNCPACBDGLM, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override string KLNBLIAPPFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x64C4510", Offset = "0x64C3710", VA = "0x1864C4510", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override bool PMLPHGCHDJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x64C44D0", Offset = "0x64C36D0", VA = "0x1864C44D0")]
		public CPHFHPKJFOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x64C4480", Offset = "0x64C3680", VA = "0x1864C4480", Slot = "14")]
		public override Delegate GetValue(FNCPACBDGLM IFAAMIKFIMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x64C44A0", Offset = "0x64C36A0", VA = "0x1864C44A0", Slot = "15")]
		public override void SetValue(FNCPACBDGLM IFAAMIKFIMC, Delegate HLCKBKFCMPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private class GBCHOJJPBDG : Property<FNCPACBDGLM, EOANOPKHGBN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override string KLNBLIAPPFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x64C4C00", Offset = "0x64C3E00", VA = "0x1864C4C00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override bool PMLPHGCHDJB
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x64C4BC0", Offset = "0x64C3DC0", VA = "0x1864C4BC0")]
		public GBCHOJJPBDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x64C4B50", Offset = "0x64C3D50", VA = "0x1864C4B50", Slot = "14")]
		public override EOANOPKHGBN<Delegate> GetValue(FNCPACBDGLM IFAAMIKFIMC)
		{
			return default(EOANOPKHGBN<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x64C4B80", Offset = "0x64C3D80", VA = "0x1864C4B80", Slot = "15")]
		public override void SetValue(FNCPACBDGLM IFAAMIKFIMC, EOANOPKHGBN<Delegate> HLCKBKFCMPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private class MHEKGJAPINB : Property<FNCPACBDGLM, EOANOPKHGBN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override string KLNBLIAPPFE
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x64C5C60", Offset = "0x64C4E60", VA = "0x1864C5C60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override bool PMLPHGCHDJB
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x64C5C20", Offset = "0x64C4E20", VA = "0x1864C5C20")]
		public MHEKGJAPINB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x64C5BB0", Offset = "0x64C4DB0", VA = "0x1864C5BB0", Slot = "14")]
		public override EOANOPKHGBN<Delegate> GetValue(FNCPACBDGLM IFAAMIKFIMC)
		{
			return default(EOANOPKHGBN<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x64C5BE0", Offset = "0x64C4DE0", VA = "0x1864C5BE0", Slot = "15")]
		public override void SetValue(FNCPACBDGLM IFAAMIKFIMC, EOANOPKHGBN<Delegate> HLCKBKFCMPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	private class CNMFFEAMNCO : Property<FNCPACBDGLM, EOANOPKHGBN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override string KLNBLIAPPFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x64C4390", Offset = "0x64C3590", VA = "0x1864C4390", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool PMLPHGCHDJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x64C4350", Offset = "0x64C3550", VA = "0x1864C4350")]
		public CNMFFEAMNCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x64C42E0", Offset = "0x64C34E0", VA = "0x1864C42E0", Slot = "14")]
		public override EOANOPKHGBN<Delegate> GetValue(FNCPACBDGLM IFAAMIKFIMC)
		{
			return default(EOANOPKHGBN<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x64C4310", Offset = "0x64C3510", VA = "0x1864C4310", Slot = "15")]
		public override void SetValue(FNCPACBDGLM IFAAMIKFIMC, EOANOPKHGBN<Delegate> HLCKBKFCMPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private class LNFNHEBHAOJ : Property<FNCPACBDGLM, EOANOPKHGBN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override string KLNBLIAPPFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x64C5B80", Offset = "0x64C4D80", VA = "0x1864C5B80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override bool PMLPHGCHDJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x64C5B40", Offset = "0x64C4D40", VA = "0x1864C5B40")]
		public LNFNHEBHAOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x64C5AC0", Offset = "0x64C4CC0", VA = "0x1864C5AC0", Slot = "14")]
		public override EOANOPKHGBN<Delegate> GetValue(FNCPACBDGLM IFAAMIKFIMC)
		{
			return default(EOANOPKHGBN<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x64C5B00", Offset = "0x64C4D00", VA = "0x1864C5B00", Slot = "15")]
		public override void SetValue(FNCPACBDGLM IFAAMIKFIMC, EOANOPKHGBN<Delegate> HLCKBKFCMPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private class HMHCALJIKBP : Property<FNCPACBDGLM, EOANOPKHGBN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override string KLNBLIAPPFE
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x64C5490", Offset = "0x64C4690", VA = "0x1864C5490", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override bool PMLPHGCHDJB
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x64C5450", Offset = "0x64C4650", VA = "0x1864C5450")]
		public HMHCALJIKBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x64C53D0", Offset = "0x64C45D0", VA = "0x1864C53D0", Slot = "14")]
		public override EOANOPKHGBN<Delegate> GetValue(FNCPACBDGLM IFAAMIKFIMC)
		{
			return default(EOANOPKHGBN<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x64C5410", Offset = "0x64C4610", VA = "0x1864C5410", Slot = "15")]
		public override void SetValue(FNCPACBDGLM IFAAMIKFIMC, EOANOPKHGBN<Delegate> HLCKBKFCMPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	private class LHEMGLMOPGK : Property<FNCPACBDGLM, EOANOPKHGBN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override string KLNBLIAPPFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x64C5A90", Offset = "0x64C4C90", VA = "0x1864C5A90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override bool PMLPHGCHDJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x64C5A50", Offset = "0x64C4C50", VA = "0x1864C5A50")]
		public LHEMGLMOPGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x64C59D0", Offset = "0x64C4BD0", VA = "0x1864C59D0", Slot = "14")]
		public override EOANOPKHGBN<Delegate> GetValue(FNCPACBDGLM IFAAMIKFIMC)
		{
			return default(EOANOPKHGBN<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x64C5A10", Offset = "0x64C4C10", VA = "0x1864C5A10", Slot = "15")]
		public override void SetValue(FNCPACBDGLM IFAAMIKFIMC, EOANOPKHGBN<Delegate> HLCKBKFCMPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private class CDIGMBAMLBH : Property<FNCPACBDGLM, EOANOPKHGBN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override string KLNBLIAPPFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x64C42B0", Offset = "0x64C34B0", VA = "0x1864C42B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override bool PMLPHGCHDJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x64C4270", Offset = "0x64C3470", VA = "0x1864C4270")]
		public CDIGMBAMLBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x64C41F0", Offset = "0x64C33F0", VA = "0x1864C41F0", Slot = "14")]
		public override EOANOPKHGBN<Delegate> GetValue(FNCPACBDGLM IFAAMIKFIMC)
		{
			return default(EOANOPKHGBN<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x64C4230", Offset = "0x64C3430", VA = "0x1864C4230", Slot = "15")]
		public override void SetValue(FNCPACBDGLM IFAAMIKFIMC, EOANOPKHGBN<Delegate> HLCKBKFCMPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private class MJDBDHBFHHB : Property<FNCPACBDGLM, EOANOPKHGBN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override string KLNBLIAPPFE
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x64C5DC0", Offset = "0x64C4FC0", VA = "0x1864C5DC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override bool PMLPHGCHDJB
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x64C5D80", Offset = "0x64C4F80", VA = "0x1864C5D80")]
		public MJDBDHBFHHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x64C5D00", Offset = "0x64C4F00", VA = "0x1864C5D00", Slot = "14")]
		public override EOANOPKHGBN<Delegate> GetValue(FNCPACBDGLM IFAAMIKFIMC)
		{
			return default(EOANOPKHGBN<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x64C5D40", Offset = "0x64C4F40", VA = "0x1864C5D40", Slot = "15")]
		public override void SetValue(FNCPACBDGLM IFAAMIKFIMC, EOANOPKHGBN<Delegate> HLCKBKFCMPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private class IKFECCFGAAG : Property<FNCPACBDGLM, EOANOPKHGBN<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override string KLNBLIAPPFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x64C5580", Offset = "0x64C4780", VA = "0x1864C5580", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override bool PMLPHGCHDJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x64C5540", Offset = "0x64C4740", VA = "0x1864C5540")]
		public IKFECCFGAAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x64C54C0", Offset = "0x64C46C0", VA = "0x1864C54C0", Slot = "14")]
		public override EOANOPKHGBN<Delegate> GetValue(FNCPACBDGLM IFAAMIKFIMC)
		{
			return default(EOANOPKHGBN<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x64C5500", Offset = "0x64C4700", VA = "0x1864C5500", Slot = "15")]
		public override void SetValue(FNCPACBDGLM IFAAMIKFIMC, EOANOPKHGBN<Delegate> HLCKBKFCMPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x64C4C90", Offset = "0x64C3E90", VA = "0x1864C4C90")]
	public GOPIJCCFLND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal class DKFPNFMHBEI : ContainerPropertyBag<FNCPACBDGLM.OEAJNEMPBOD>
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private class MICPIEBGGBA : Property<FNCPACBDGLM.OEAJNEMPBOD, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override string KLNBLIAPPFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x64C5CD0", Offset = "0x64C4ED0", VA = "0x1864C5CD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override bool PMLPHGCHDJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x64C5C90", Offset = "0x64C4E90", VA = "0x1864C5C90")]
		public MICPIEBGGBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x955710", Offset = "0x954910", VA = "0x180955710", Slot = "14")]
		public override object GetValue(FNCPACBDGLM.OEAJNEMPBOD IFAAMIKFIMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x43FFA20", Offset = "0x43FEC20", VA = "0x1843FFA20", Slot = "15")]
		public override void SetValue(FNCPACBDGLM.OEAJNEMPBOD IFAAMIKFIMC, object HLCKBKFCMPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x64C47F0", Offset = "0x64C39F0", VA = "0x1864C47F0")]
	public DKFPNFMHBEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal class ACEMNMMPCCH : ContainerPropertyBag<EOANOPKHGBN<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x64C3DC0", Offset = "0x64C2FC0", VA = "0x1864C3DC0")]
	public ACEMNMMPCCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class HCOKBPGPHCI : ContainerPropertyBag<FCMCFKBCBMD>
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	private class NLFAOKAFLHK : Property<FCMCFKBCBMD, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override string KLNBLIAPPFE
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x64C5F70", Offset = "0x64C5170", VA = "0x1864C5F70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override bool PMLPHGCHDJB
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x64C5F30", Offset = "0x64C5130", VA = "0x1864C5F30")]
		public NLFAOKAFLHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x64C43C0", Offset = "0x64C35C0", VA = "0x1864C43C0", Slot = "14")]
		public override Rigidbody GetValue(FCMCFKBCBMD IFAAMIKFIMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x64C43E0", Offset = "0x64C35E0", VA = "0x1864C43E0", Slot = "15")]
		public override void SetValue(FCMCFKBCBMD IFAAMIKFIMC, Rigidbody HLCKBKFCMPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x64C52F0", Offset = "0x64C44F0", VA = "0x1864C52F0")]
	public HCOKBPGPHCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal class BPGOCJFHGCJ : ContainerPropertyBag<DAKDFBHJAHF>
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class FNFBFHBCHEM : Property<DAKDFBHJAHF, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override string KLNBLIAPPFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x64C4B20", Offset = "0x64C3D20", VA = "0x1864C4B20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override bool PMLPHGCHDJB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x64C4AE0", Offset = "0x64C3CE0", VA = "0x1864C4AE0")]
		public FNFBFHBCHEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x64C43C0", Offset = "0x64C35C0", VA = "0x1864C43C0", Slot = "14")]
		public override object GetValue(DAKDFBHJAHF IFAAMIKFIMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x64C43E0", Offset = "0x64C35E0", VA = "0x1864C43E0", Slot = "15")]
		public override void SetValue(DAKDFBHJAHF IFAAMIKFIMC, object HLCKBKFCMPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x64C4110", Offset = "0x64C3310", VA = "0x1864C4110")]
	public BPGOCJFHGCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
internal class NNOPONMDAJG : ContainerPropertyBag<KNCKBBOHPNM>
{
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private class COLLHBLNFJF : Property<KNCKBBOHPNM, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override string KLNBLIAPPFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x64C4450", Offset = "0x64C3650", VA = "0x1864C4450", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool PMLPHGCHDJB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x64C4410", Offset = "0x64C3610", VA = "0x1864C4410")]
		public COLLHBLNFJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x64C43C0", Offset = "0x64C35C0", VA = "0x1864C43C0", Slot = "14")]
		public override object GetValue(KNCKBBOHPNM IFAAMIKFIMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x64C43E0", Offset = "0x64C35E0", VA = "0x1864C43E0", Slot = "15")]
		public override void SetValue(KNCKBBOHPNM IFAAMIKFIMC, object HLCKBKFCMPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x64C5FA0", Offset = "0x64C51A0", VA = "0x1864C5FA0")]
	public NNOPONMDAJG()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x64C64D0", Offset = "0x64C56D0", VA = "0x1864C64D0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class MIKFNFJDMKB
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public MIKFNFJDMKB()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
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
