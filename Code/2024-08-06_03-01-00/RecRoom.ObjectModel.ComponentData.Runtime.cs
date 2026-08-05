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
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
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
	public class _AssemblyIndex : KHELACBDANM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6A96590", Offset = "0x6A94B90", VA = "0x186A96590", Slot = "8")]
		public override void PEGDOCGMNBF(FEIKJFAIAHC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6A96130", Offset = "0x6A94730", VA = "0x186A96130", Slot = "7")]
		public override void GGBGAOICMHA(LDBKNJIJEAO registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6A96970", Offset = "0x6A94F70", VA = "0x186A96970")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct DNOOJFGPDKK : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildBuffer>, AABODMPAJAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9A9F10", Offset = "0x9A8510", VA = "0x1809A9F10", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xF11CB0", Offset = "0xF102B0", VA = "0x180F11CB0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6A93540", Offset = "0x6A91B40", VA = "0x186A93540", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xF11CB0", Offset = "0xF102B0", VA = "0x180F11CB0")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x98BFE0", Offset = "0x98A5E0", VA = "0x18098BFE0")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, AABODMPAJAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9A9F10", Offset = "0x9A8510", VA = "0x1809A9F10", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xF11CB0", Offset = "0xF102B0", VA = "0x180F11CB0", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct EIKBHPNHKFJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct BAPCOLIPABO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity DCLLIJKDEEJ;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct IIJDFDODGPL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity DCLLIJKDEEJ;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct HLGEGIGNDBK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<IGBDCLPAHEI> ILLGEGHMLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<Entity> OLPFMAPMCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JobHandle JKHDOKLDIHM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool PNMIFIKLJBD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6A94920", Offset = "0x6A92F20", VA = "0x186A94920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NCPJPJDHEHD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6A947B0", Offset = "0x6A92DB0", VA = "0x186A947B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4D804D0", Offset = "0x4D7EAD0", VA = "0x184D804D0")]
	public HLGEGIGNDBK(NativeList<IGBDCLPAHEI> ILLGEGHMLOP, NativeList<Entity> OLPFMAPMCJJ, JobHandle JKHDOKLDIHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6A94800", Offset = "0x6A92E00", VA = "0x186A94800")]
	public (Entity, NativeSlice<Entity>) HAMKADGAKKN(int HBONDKDDBNB)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6A94750", Offset = "0x6A92D50", VA = "0x186A94750", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct IGBDCLPAHEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Entity GOKNAIEAOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int LHOLHMCKPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int KDDFOIMAIHK;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EBFHMKKBLOG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DBDMPIJDKOF(bool PHKMLLHKMFB);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct EDNLGDNGFKL : IEquatable<EDNLGDNGFKL>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool NGJNBJJHOFD(int PJCEMACCFLL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool EAMKLLCIELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool FIEONPJKCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool PKPLGDNLLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool PCBKBAAEEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly NGJNBJJHOFD OPAJDHHJJJI;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6A93CD0", Offset = "0x6A922D0", VA = "0x186A93CD0")]
	public EDNLGDNGFKL(LONNJOBPNCL NCGAEKDJMAC, NGJNBJJHOFD OPAJDHHJJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6A93CA0", Offset = "0x6A922A0", VA = "0x186A93CA0")]
	public EDNLGDNGFKL(bool EAMKLLCIELH, bool FIEONPJKCHC, bool PKPLGDNLLFD, bool PCBKBAAEEHL, NGJNBJJHOFD OPAJDHHJJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6A93B70", Offset = "0x6A92170", VA = "0x186A93B70")]
	public bool FOOHLGFMGOJ(int PJCEMACCFLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6A93C70", Offset = "0x6A92270", VA = "0x186A93C70")]
	public bool JGCMIMFMLMF(int PJCEMACCFLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6A93A60", Offset = "0x6A92060", VA = "0x186A93A60")]
	public bool DGJCDFLEMIK(int PJCEMACCFLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6A93BA0", Offset = "0x6A921A0", VA = "0x186A93BA0")]
	public bool GLGOMOKIBIK(int PJCEMACCFLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6A93A90", Offset = "0x6A92090", VA = "0x186A93A90", Slot = "4")]
	public bool Equals(EDNLGDNGFKL OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6A93AC0", Offset = "0x6A920C0", VA = "0x186A93AC0", Slot = "0")]
	public override bool Equals(object CDBNFNMIHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6A93BD0", Offset = "0x6A921D0", VA = "0x186A93BD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6A93A40", Offset = "0x6A92040", VA = "0x186A93A40")]
	private bool BENFIFONCCC(int PJCEMACCFLL)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct CNPLMOLHNBO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct LFIPIIAGAEJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct COLOHJBOLLP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[InternalBufferCapacity(17)]
public struct NMAADFJMFAH : IBufferElementData, IEquatable<NMAADFJMFAH>, AABODMPAJAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity IKNBKKNKJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int KBIOECAHBND;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity IOHPJPMIPKA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9A9F10", Offset = "0x9A8510", VA = "0x1809A9F10", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xF11CB0", Offset = "0xF102B0", VA = "0x180F11CB0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A957A0", Offset = "0x6A93DA0", VA = "0x186A957A0", Slot = "4")]
	public bool Equals(NMAADFJMFAH OGEIJLCLBIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct ACAJJDPHOPD : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct BEPOFBMGPIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly MAACBOAGFBB LEGGHOJEDKI;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x21A1BB0", Offset = "0x21A01B0", VA = "0x1821A1BB0")]
		public BEPOFBMGPIG(MAACBOAGFBB AKKKDOKLKKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6A935B0", Offset = "0x6A91BB0", VA = "0x186A935B0")]
		public bool LKNGNDPONAG(ACAJJDPHOPD ODECNKEGGKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6A935C0", Offset = "0x6A91BC0", VA = "0x186A935C0")]
		public bool OCCMCKINPCI(ACAJJDPHOPD ODECNKEGGKL, MAACBOAGFBB ANHEKBGCOBK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly MAACBOAGFBB NLGHNHBNEMJ;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x21A1BB0", Offset = "0x21A01B0", VA = "0x1821A1BB0")]
	public ACAJJDPHOPD(MAACBOAGFBB NLGHNHBNEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A933C0", Offset = "0x6A919C0", VA = "0x186A933C0")]
	public ACAJJDPHOPD NNKMOFEEPHI(MAACBOAGFBB MJBHMMBOCEG)
	{
		return default(ACAJJDPHOPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6A933B0", Offset = "0x6A919B0", VA = "0x186A933B0")]
	public ACAJJDPHOPD HNCHOCCAEKC(MAACBOAGFBB DOGFIKJICID)
	{
		return default(ACAJJDPHOPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6A933D0", Offset = "0x6A919D0", VA = "0x186A933D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[Flags]
public enum MAACBOAGFBB : byte
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
public enum MCBLMFMDGBN : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[EGJGNPAIPIB]
public struct BEJPDIIGEOJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public MCBLMFMDGBN NLGHNHBNEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public bool LGILJBMLDAI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool LOOIKIBONDE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6A93550", Offset = "0x6A91B50", VA = "0x186A93550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6A935A0", Offset = "0x6A91BA0", VA = "0x186A935A0")]
	private BEJPDIIGEOJ(MCBLMFMDGBN NLGHNHBNEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6A93580", Offset = "0x6A91B80", VA = "0x186A93580")]
	public BEJPDIIGEOJ NNKMOFEEPHI(MCBLMFMDGBN MJBHMMBOCEG)
	{
		return default(BEJPDIIGEOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6A93560", Offset = "0x6A91B60", VA = "0x186A93560")]
	public BEJPDIIGEOJ HNCHOCCAEKC(MCBLMFMDGBN DOGFIKJICID)
	{
		return default(BEJPDIIGEOJ);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct BEGJHFMKIMK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct DIJFDMMLBDE : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Entity MPPAGEOOHDD;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildBuffer>, AABODMPAJAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9A9F10", Offset = "0x9A8510", VA = "0x1809A9F10", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xF11CB0", Offset = "0xF102B0", VA = "0x180F11CB0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xF11CB0", Offset = "0xF102B0", VA = "0x180F11CB0")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6A93540", Offset = "0x6A91B40", VA = "0x186A93540", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x98BFE0", Offset = "0x98A5E0", VA = "0x18098BFE0")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[EGJGNPAIPIB]
public struct JHNIHAIFKJF : ISystemStateBufferElementData, IBufferElementData, AABODMPAJAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public Entity PEMPNCNIDJF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Entity PPOOPKDEDOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9A9F10", Offset = "0x9A8510", VA = "0x1809A9F10", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xF11CB0", Offset = "0xF102B0", VA = "0x180F11CB0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct LBEBLGPACBL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Entity OICJIOGGDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Entity KBCMNEOKBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity NJBALLFGIAA;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct LLMEAECACFE<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly bool NEEAOKHHHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public uint CNPEGPFCDIF;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool OAGODLHCIEG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.TypeVersion(2)]
public struct FLDEJBIOGCH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public uint LAENFNGELBB;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6A93EB0", Offset = "0x6A924B0", VA = "0x186A93EB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct OCEMKCOCPKF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[EGJGNPAIPIB]
public struct OAOPECJGNJJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public int HLBOBALKGCM;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct BPMNIGPAGHA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int BMFGPCBKKKB;
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct GBNIAGLGOFE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public GCHandle GPFFADKDOFC;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct PCIDFGCGKDD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public int BMFGPCBKKKB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct OKCIKKHGCJD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct EMLMBKAJNMF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public int BMFGPCBKKKB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct LALLGHPKFFA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct JAHBGGCEJDJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct HAKFCMLJPNJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct IOELKEEALKH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public CollisionDetectionMode HHFMMJEGJMJ;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[PNGJCJDJMIG]
public struct COBLDNBKFLF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public GHLGGPNNOMD FIPCMAIDAPJ;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly COBLDNBKFLF NEJLCIDCLHL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct NMLAEOJIPEP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct JGBBFNNIBML : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct NFICJGNCEDE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[InternalBufferCapacity(0)]
public struct NFHPKGEMJPF : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Entity IKNBKKNKJDH;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct NDFLNCDNKNP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Entity LPFOFJIMHOE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct CMHDDJDMPCM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct DCHAKDDIOKI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Entity GOKNAIEAOEG;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct APFAOCFAEHP : OHHKPGIMGNG, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public BIMBBAPHHOL LFELKNAKNIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9A9F10", Offset = "0x9A8510", VA = "0x1809A9F10", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(BIMBBAPHHOL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xF11CB0", Offset = "0xF102B0", VA = "0x180F11CB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct LCFANAFCDEG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float3 OHMOHLDNFBD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct JABLPBALFBC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[PNGJCJDJMIG]
public struct MCPPDOCFCAD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public float3x3 BNCGIMNGHFM;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly MCPPDOCFCAD NEJLCIDCLHL;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[PNGJCJDJMIG]
public struct EKNDLCLBCGA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public float3x3 BNCGIMNGHFM;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly EKNDLCLBCGA NEJLCIDCLHL;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct LKLHEPPLIFK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public float3 DNPAFPDKCHK;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct EMLDDLMDIKK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public float3 MNFCPPEDBIC;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[PNGJCJDJMIG]
public struct EPNODALDHPC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float MAMGLAJNMOO;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly EPNODALDHPC NEJLCIDCLHL;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[PNGJCJDJMIG]
public struct HKCJJIBGACI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public float PKMEAMKOGOD;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly HKCJJIBGACI NEJLCIDCLHL;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct MGCKFLPDGGO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public float3 CHEDGBOOAHJ;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct EGEJMCFJGIH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public HOEMCLDCGOB GPLBGPNDJJK;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct GGNPDIEOCEP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public HOEMCLDCGOB EOKJBAJPAJJ;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[EGJGNPAIPIB]
public struct BGJFBGLMFEJ : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Entity PEMPNCNIDJF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct NFCPNAMKFAP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct FFBNDCDDLHG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct OAACHLFAFGJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public RigidbodyConstraints MCCMJELOOAG;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[PNGJCJDJMIG]
public struct ODIJLHFNCNB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public float OLLDGKMLIHF;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly ODIJLHFNCNB NEJLCIDCLHL;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct BFPCIIHBNAE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float MCJJGNAOPFB;
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class KIBCFPELJCB : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct PEDPBIEFMHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public object EMHLDEEKDPM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public GameObject BBKKNFIIKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public object NMDKKHIJGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public object GJDPLHBEPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public PEDPBIEFMHC EMHLDEEKDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public Delegate PKGEGMFEBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Delegate JCBAKANADHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public JPIFDHEJDJL<Delegate> EIAJIIHHFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public JPIFDHEJDJL<Delegate> DOAAICEGKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public JPIFDHEJDJL<Delegate> GDLHEJPNNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public JPIFDHEJDJL<Delegate> OEFHGDNPFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public JPIFDHEJDJL<Delegate> IPGCJDMJEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public JPIFDHEJDJL<Delegate> JIIJHIHPAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public JPIFDHEJDJL<Delegate> JPBLLBGPPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public JPIFDHEJDJL<Delegate> APKIGDIDJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public JPIFDHEJDJL<Delegate> EJKHFECIEOC;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6A950B0", Offset = "0x6A936B0", VA = "0x186A950B0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public KIBCFPELJCB()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct HBCPKABIIEM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct MKPFEGHEAHC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int KFDCKDJMGPO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xE6F580", Offset = "0xE6DB80", VA = "0x180E6F580")]
	public static MKPFEGHEAHC IHCIOHJGPAF(int FEBGGALLBNN)
	{
		return default(MKPFEGHEAHC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class NGNNOAMAGDI : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public Rigidbody KJDLJANECIL;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6A95650", Offset = "0x6A93C50", VA = "0x186A95650", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public NGNNOAMAGDI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct CGLOIPMCNMB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct MGILHAOLNNG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 LMLHIBOJPPE;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct LCGPAFFLIHH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float3 FPMFPAANFEC;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[PNGJCJDJMIG]
public struct PPNAGPAMFLI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float GDJHNEPGHJF;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly PPNAGPAMFLI NEJLCIDCLHL;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class KALGKGCIAKH : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public object JFGLFKDJBPM;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6A94DE0", Offset = "0x6A933E0", VA = "0x186A94DE0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public KALGKGCIAKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class EMINNOBKKAH : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public object CIOOEEJMMMH;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6A93E00", Offset = "0x6A92400", VA = "0x186A93E00", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public EMINNOBKKAH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct LHMHECHOBFG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct BICDIAKEJCE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct CEPOLOGCKOJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct ENOBNEBLGLJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct HMKEPIFFCJK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct NDFMCCMHJKI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public FixedString32Bytes LGJDNDBECCI;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[EGJGNPAIPIB]
public struct MOKMCBCEJKN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Entity COCIKBKCNFK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x98BFE0", Offset = "0x98A5E0", VA = "0x18098BFE0")]
	public static MOKMCBCEJKN IHCIOHJGPAF(Entity FEBGGALLBNN)
	{
		return default(MOKMCBCEJKN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal struct CLPALOBJLDJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Entity PEMPNCNIDJF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x98BFE0", Offset = "0x98A5E0", VA = "0x18098BFE0")]
	public static CLPALOBJLDJ IHCIOHJGPAF(Entity PEMPNCNIDJF)
	{
		return default(CLPALOBJLDJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct CICINHHJFKB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Entity PNECBAELBMC;
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct KNLGLEFMHJH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Entity PNECBAELBMC;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal struct NFDBJPHKFPN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Entity CMFJHPIKCMB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x98BFE0", Offset = "0x98A5E0", VA = "0x18098BFE0")]
	public static NFDBJPHKFPN IHCIOHJGPAF(Entity PEMPNCNIDJF)
	{
		return default(NFDBJPHKFPN);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal struct MGINEJHCPAB : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct CCAPDOPGEFF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct BBLPMGBJBNJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public uint PKICDAADPKG;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[EGJGNPAIPIB]
internal struct HHCJHLDNACJ : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public Entity KCGNKIJHGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int EBDMAJMOJLN;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal struct JCBEKJCHBJF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public Entity PFGJKMHGPNL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct JFHMIDHMIDJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct IEODKJLNGCA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public uint CNPEGPFCDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int LLBENENCDLF;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xD48E20", Offset = "0xD47420", VA = "0x180D48E20")]
	public IEODKJLNGCA(uint MOMPNCOFIOO, int FMDLOAEEICA)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct ICKGPMJKBLF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct HJIALKGOLNP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct GDGHMIKKAEN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct OJLGLMPDBGE : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct MPJJMDMLAHP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct PABDHFFINAP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct KAMNKBONHHE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct FFAEIOFNACD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal struct ODGAFJIFCGO : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct PDPINNCBJLN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct LDDFEDKIEBF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct GELFPFOBFAG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal struct BJMKELKCDBE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal struct BNDJMJMHBKA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct LIKELNGKNKO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct MBLCHPJDHKH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct KPBPANIINNH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct KOKPIHKMLIH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct HHPLGJKNHEB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct MNJIGMCBGDN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct MGKEBPFJBCG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct CCPPGGGBCFP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct CJIKDIGOGFA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct EJEGCFMIOLL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal struct GDMJHOBKLPO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct NPIKGJJIINJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct ADMGBPCBKMB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct DBHBIFEKBOE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[EGJGNPAIPIB]
public struct HOCFKNEHPLP : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public FixedString32Bytes LPMFPECNPEI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct CHCFHOMHBMJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct NFNGLEBODLC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal struct DCKGMPKOJMA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal struct KEPJPDHPPPK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal struct LHIIJMAMBIO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct CNNKDMEOPEB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct EJOIEMMMOOK : IComponentData, IComparable<EJOIEMMMOOK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public int GNAJAAJBCJC;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1B7E530", Offset = "0x1B7CB30", VA = "0x181B7E530", Slot = "4")]
	public int CompareTo(EJOIEMMMOOK OGEIJLCLBIC)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct ANPMFMEAKIH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct KNFJGEKJGMH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public quaternion CNNBBFFJNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float3 LPBGBJBIAOJ;
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct FGBOIEPBAIH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float DAJGFAFBLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float HBLFALIAOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float APBNIHOFMLF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct MBBAOKPGOHA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct ALDPKGDOIMD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct MJMIBGCILAL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct ONDDHMLGJMO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public int BMFGPCBKKKB;
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[EGJGNPAIPIB]
public struct PHCFLDHHIKF : ISystemStateBufferElementData, IBufferElementData, AABODMPAJAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Entity NBMKCMDEKCJ;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Entity PPOOPKDEDOC
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9A9F10", Offset = "0x9A8510", VA = "0x1809A9F10", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xF11CB0", Offset = "0xF102B0", VA = "0x180F11CB0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[PNGJCJDJMIG]
public struct AMLBBLEJCFI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public float4x4 CBPKJDFAKLK;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public static readonly AMLBBLEJCFI NEJLCIDCLHL;
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[PNGJCJDJMIG]
public struct KDHEDHONIBO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public float4x4 OICCLAPEFKA;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public static readonly KDHEDHONIBO NEJLCIDCLHL;
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public struct CDAIIEFAKND : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private int MHFADGLBFEA;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int EBDMAJMOJLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6A937C0", Offset = "0x6A91DC0", VA = "0x186A937C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6A937D0", Offset = "0x6A91DD0", VA = "0x186A937D0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[PNGJCJDJMIG]
public struct OLEDFILPEND : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public float3 PCBJHEHGAII;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public static readonly OLEDFILPEND NEJLCIDCLHL;
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[PNGJCJDJMIG]
public struct DEACKGELGKH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float3 LPBGBJBIAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public quaternion CNNBBFFJNHM;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public static readonly DEACKGELGKH NEJLCIDCLHL;
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class DANDHOHMNAA
{
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[PNGJCJDJMIG]
public struct GFIIAGNJEIF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float NBODJJGJOPF;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public static readonly GFIIAGNJEIF NEJLCIDCLHL;
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct ILOADOCBGHO : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Entity DHOBFELMHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public KDBIDFLODON OHOJHKCPKNF;
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct DIHDHDACMKH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public KDBIDFLODON OHOJHKCPKNF;
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct NCHDOFMFKMG : ISystemStateComponentData, IComponentData, AABODMPAJAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Entity NHEAJDGKBEF;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity PPOOPKDEDOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9A9F10", Offset = "0x9A8510", VA = "0x1809A9F10", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xF11CB0", Offset = "0xF102B0", VA = "0x180F11CB0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct HIFCIMDFKFP : ISystemStateBufferElementData, IBufferElementData, AABODMPAJAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity FCHOCLDEAEM;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Entity PPOOPKDEDOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9A9F10", Offset = "0x9A8510", VA = "0x1809A9F10", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xF11CB0", Offset = "0xF102B0", VA = "0x180F11CB0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct HKDCNKBLJKC : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Entity DHOBFELMHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public KDBIDFLODON OHOJHKCPKNF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct PPNDCGOKPAI : IEqualityComparer<HKDCNKBLJKC>
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public static PPNDCGOKPAI NEJLCIDCLHL;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6A95B30", Offset = "0x6A94130", VA = "0x186A95B30", Slot = "4")]
	public bool Equals(HKDCNKBLJKC OEMFOJFNECE, HKDCNKBLJKC DPKOFHFGJKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6A95B80", Offset = "0x6A94180", VA = "0x186A95B80", Slot = "5")]
	public int GetHashCode(HKDCNKBLJKC CDBNFNMIHPK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct IAJIKDMFFPJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public FixedList32Bytes<int> LNMGFNBGPMP;
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct ALMLNHGNOCE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public FixedList32Bytes<int> LNMGFNBGPMP;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct AICHNOBDBPH : ISystemStateBufferElementData, IBufferElementData, AABODMPAJAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Entity GCNEAPJJLBA;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private Entity IOHPJPMIPKA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9A9F10", Offset = "0x9A8510", VA = "0x1809A9F10", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xF11CB0", Offset = "0xF102B0", VA = "0x180F11CB0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class HDNJFEJIAKH : ContainerPropertyBag<KIBCFPELJCB>
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	private class ONEHGNADGEH : Property<KIBCFPELJCB, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string IKOGEGKCJIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6A959D0", Offset = "0x6A93FD0", VA = "0x186A959D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool AJPOMKOKGAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6A95990", Offset = "0x6A93F90", VA = "0x186A95990")]
		public ONEHGNADGEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6A935D0", Offset = "0x6A91BD0", VA = "0x186A935D0", Slot = "14")]
		public override GameObject GetValue(KIBCFPELJCB CEJMOFAPBGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6A935F0", Offset = "0x6A91BF0", VA = "0x186A935F0", Slot = "15")]
		public override void SetValue(KIBCFPELJCB CEJMOFAPBGN, GameObject FEBGGALLBNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class BKAKMHEGCLM : Property<KIBCFPELJCB, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string IKOGEGKCJIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6A93720", Offset = "0x6A91D20", VA = "0x186A93720", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool AJPOMKOKGAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6A936E0", Offset = "0x6A91CE0", VA = "0x186A936E0")]
		public BKAKMHEGCLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6A93690", Offset = "0x6A91C90", VA = "0x186A93690", Slot = "14")]
		public override object GetValue(KIBCFPELJCB CEJMOFAPBGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6A936B0", Offset = "0x6A91CB0", VA = "0x186A936B0", Slot = "15")]
		public override void SetValue(KIBCFPELJCB CEJMOFAPBGN, object FEBGGALLBNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class KCKJAPIPALF : Property<KIBCFPELJCB, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string IKOGEGKCJIK
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6A94EE0", Offset = "0x6A934E0", VA = "0x186A94EE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool AJPOMKOKGAO
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6A94EA0", Offset = "0x6A934A0", VA = "0x186A94EA0")]
		public KCKJAPIPALF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6A94E50", Offset = "0x6A93450", VA = "0x186A94E50", Slot = "14")]
		public override object GetValue(KIBCFPELJCB CEJMOFAPBGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6A94E70", Offset = "0x6A93470", VA = "0x186A94E70", Slot = "15")]
		public override void SetValue(KIBCFPELJCB CEJMOFAPBGN, object FEBGGALLBNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	private class HPPMOJFICAN : Property<KIBCFPELJCB, KIBCFPELJCB.PEDPBIEFMHC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string IKOGEGKCJIK
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6A94A20", Offset = "0x6A93020", VA = "0x186A94A20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool AJPOMKOKGAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6A949E0", Offset = "0x6A92FE0", VA = "0x186A949E0")]
		public HPPMOJFICAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6A94990", Offset = "0x6A92F90", VA = "0x186A94990", Slot = "14")]
		public override KIBCFPELJCB.PEDPBIEFMHC GetValue(KIBCFPELJCB CEJMOFAPBGN)
		{
			return default(KIBCFPELJCB.PEDPBIEFMHC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6A949B0", Offset = "0x6A92FB0", VA = "0x186A949B0", Slot = "15")]
		public override void SetValue(KIBCFPELJCB CEJMOFAPBGN, KIBCFPELJCB.PEDPBIEFMHC FEBGGALLBNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private class LADLMADKHNL : Property<KIBCFPELJCB, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string IKOGEGKCJIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6A95360", Offset = "0x6A93960", VA = "0x186A95360", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool AJPOMKOKGAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6A95320", Offset = "0x6A93920", VA = "0x186A95320")]
		public LADLMADKHNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6A952D0", Offset = "0x6A938D0", VA = "0x186A952D0", Slot = "14")]
		public override Delegate GetValue(KIBCFPELJCB CEJMOFAPBGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6A952F0", Offset = "0x6A938F0", VA = "0x186A952F0", Slot = "15")]
		public override void SetValue(KIBCFPELJCB CEJMOFAPBGN, Delegate FEBGGALLBNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	private class GNGMBPAFAIA : Property<KIBCFPELJCB, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string IKOGEGKCJIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6A94080", Offset = "0x6A92680", VA = "0x186A94080", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool AJPOMKOKGAO
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6A94040", Offset = "0x6A92640", VA = "0x186A94040")]
		public GNGMBPAFAIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6A93FF0", Offset = "0x6A925F0", VA = "0x186A93FF0", Slot = "14")]
		public override Delegate GetValue(KIBCFPELJCB CEJMOFAPBGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6A94010", Offset = "0x6A92610", VA = "0x186A94010", Slot = "15")]
		public override void SetValue(KIBCFPELJCB CEJMOFAPBGN, Delegate FEBGGALLBNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private class MNJPGBKPLBK : Property<KIBCFPELJCB, JPIFDHEJDJL<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string IKOGEGKCJIK
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6A95620", Offset = "0x6A93C20", VA = "0x186A95620", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool AJPOMKOKGAO
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6A955E0", Offset = "0x6A93BE0", VA = "0x186A955E0")]
		public MNJPGBKPLBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6A95570", Offset = "0x6A93B70", VA = "0x186A95570", Slot = "14")]
		public override JPIFDHEJDJL<Delegate> GetValue(KIBCFPELJCB CEJMOFAPBGN)
		{
			return default(JPIFDHEJDJL<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6A955A0", Offset = "0x6A93BA0", VA = "0x186A955A0", Slot = "15")]
		public override void SetValue(KIBCFPELJCB CEJMOFAPBGN, JPIFDHEJDJL<Delegate> FEBGGALLBNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private class ODAJFIOLLLH : Property<KIBCFPELJCB, JPIFDHEJDJL<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string IKOGEGKCJIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6A958A0", Offset = "0x6A93EA0", VA = "0x186A958A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool AJPOMKOKGAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6A95860", Offset = "0x6A93E60", VA = "0x186A95860")]
		public ODAJFIOLLLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6A957F0", Offset = "0x6A93DF0", VA = "0x186A957F0", Slot = "14")]
		public override JPIFDHEJDJL<Delegate> GetValue(KIBCFPELJCB CEJMOFAPBGN)
		{
			return default(JPIFDHEJDJL<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6A95820", Offset = "0x6A93E20", VA = "0x186A95820", Slot = "15")]
		public override void SetValue(KIBCFPELJCB CEJMOFAPBGN, JPIFDHEJDJL<Delegate> FEBGGALLBNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class NIACHPACDON : Property<KIBCFPELJCB, JPIFDHEJDJL<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string IKOGEGKCJIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6A95770", Offset = "0x6A93D70", VA = "0x186A95770", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool AJPOMKOKGAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6A95730", Offset = "0x6A93D30", VA = "0x186A95730")]
		public NIACHPACDON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6A956C0", Offset = "0x6A93CC0", VA = "0x186A956C0", Slot = "14")]
		public override JPIFDHEJDJL<Delegate> GetValue(KIBCFPELJCB CEJMOFAPBGN)
		{
			return default(JPIFDHEJDJL<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6A956F0", Offset = "0x6A93CF0", VA = "0x186A956F0", Slot = "15")]
		public override void SetValue(KIBCFPELJCB CEJMOFAPBGN, JPIFDHEJDJL<Delegate> FEBGGALLBNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	private class KEOBDGOFNJC : Property<KIBCFPELJCB, JPIFDHEJDJL<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string IKOGEGKCJIK
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6A95080", Offset = "0x6A93680", VA = "0x186A95080", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool AJPOMKOKGAO
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6A95040", Offset = "0x6A93640", VA = "0x186A95040")]
		public KEOBDGOFNJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6A94FC0", Offset = "0x6A935C0", VA = "0x186A94FC0", Slot = "14")]
		public override JPIFDHEJDJL<Delegate> GetValue(KIBCFPELJCB CEJMOFAPBGN)
		{
			return default(JPIFDHEJDJL<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6A95000", Offset = "0x6A93600", VA = "0x186A95000", Slot = "15")]
		public override void SetValue(KIBCFPELJCB CEJMOFAPBGN, JPIFDHEJDJL<Delegate> FEBGGALLBNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private class KMOEEIHFOAF : Property<KIBCFPELJCB, JPIFDHEJDJL<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string IKOGEGKCJIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6A951C0", Offset = "0x6A937C0", VA = "0x186A951C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool AJPOMKOKGAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6A95180", Offset = "0x6A93780", VA = "0x186A95180")]
		public KMOEEIHFOAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6A95100", Offset = "0x6A93700", VA = "0x186A95100", Slot = "14")]
		public override JPIFDHEJDJL<Delegate> GetValue(KIBCFPELJCB CEJMOFAPBGN)
		{
			return default(JPIFDHEJDJL<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6A95140", Offset = "0x6A93740", VA = "0x186A95140", Slot = "15")]
		public override void SetValue(KIBCFPELJCB CEJMOFAPBGN, JPIFDHEJDJL<Delegate> FEBGGALLBNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	private class JNFMCBFJJNG : Property<KIBCFPELJCB, JPIFDHEJDJL<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string IKOGEGKCJIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6A94DB0", Offset = "0x6A933B0", VA = "0x186A94DB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool AJPOMKOKGAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6A94D70", Offset = "0x6A93370", VA = "0x186A94D70")]
		public JNFMCBFJJNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6A94CF0", Offset = "0x6A932F0", VA = "0x186A94CF0", Slot = "14")]
		public override JPIFDHEJDJL<Delegate> GetValue(KIBCFPELJCB CEJMOFAPBGN)
		{
			return default(JPIFDHEJDJL<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6A94D30", Offset = "0x6A93330", VA = "0x186A94D30", Slot = "15")]
		public override void SetValue(KIBCFPELJCB CEJMOFAPBGN, JPIFDHEJDJL<Delegate> FEBGGALLBNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	private class LNBOIDNBKPB : Property<KIBCFPELJCB, JPIFDHEJDJL<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string IKOGEGKCJIK
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6A95450", Offset = "0x6A93A50", VA = "0x186A95450", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool AJPOMKOKGAO
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6A95410", Offset = "0x6A93A10", VA = "0x186A95410")]
		public LNBOIDNBKPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6A95390", Offset = "0x6A93990", VA = "0x186A95390", Slot = "14")]
		public override JPIFDHEJDJL<Delegate> GetValue(KIBCFPELJCB CEJMOFAPBGN)
		{
			return default(JPIFDHEJDJL<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6A953D0", Offset = "0x6A939D0", VA = "0x186A953D0", Slot = "15")]
		public override void SetValue(KIBCFPELJCB CEJMOFAPBGN, JPIFDHEJDJL<Delegate> FEBGGALLBNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class CMOKFIEBNHL : Property<KIBCFPELJCB, JPIFDHEJDJL<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string IKOGEGKCJIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x6A938A0", Offset = "0x6A91EA0", VA = "0x186A938A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool AJPOMKOKGAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6A93860", Offset = "0x6A91E60", VA = "0x186A93860")]
		public CMOKFIEBNHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6A937E0", Offset = "0x6A91DE0", VA = "0x186A937E0", Slot = "14")]
		public override JPIFDHEJDJL<Delegate> GetValue(KIBCFPELJCB CEJMOFAPBGN)
		{
			return default(JPIFDHEJDJL<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6A93820", Offset = "0x6A91E20", VA = "0x186A93820", Slot = "15")]
		public override void SetValue(KIBCFPELJCB CEJMOFAPBGN, JPIFDHEJDJL<Delegate> FEBGGALLBNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	private class PANEFHGDFNM : Property<KIBCFPELJCB, JPIFDHEJDJL<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string IKOGEGKCJIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6A95AC0", Offset = "0x6A940C0", VA = "0x186A95AC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool AJPOMKOKGAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6A95A80", Offset = "0x6A94080", VA = "0x186A95A80")]
		public PANEFHGDFNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6A95A00", Offset = "0x6A94000", VA = "0x186A95A00", Slot = "14")]
		public override JPIFDHEJDJL<Delegate> GetValue(KIBCFPELJCB CEJMOFAPBGN)
		{
			return default(JPIFDHEJDJL<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6A95A40", Offset = "0x6A94040", VA = "0x186A95A40", Slot = "15")]
		public override void SetValue(KIBCFPELJCB CEJMOFAPBGN, JPIFDHEJDJL<Delegate> FEBGGALLBNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6A940B0", Offset = "0x6A926B0", VA = "0x186A940B0")]
	public HDNJFEJIAKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal class JFPNFPLAHJD : ContainerPropertyBag<KIBCFPELJCB.PEDPBIEFMHC>
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private class GMIOIAHKKLK : Property<KIBCFPELJCB.PEDPBIEFMHC, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string IKOGEGKCJIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6A93FC0", Offset = "0x6A925C0", VA = "0x186A93FC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool AJPOMKOKGAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6A93F80", Offset = "0x6A92580", VA = "0x186A93F80")]
		public GMIOIAHKKLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xB10AD0", Offset = "0xB0F0D0", VA = "0x180B10AD0", Slot = "14")]
		public override object GetValue(KIBCFPELJCB.PEDPBIEFMHC CEJMOFAPBGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x48742D0", Offset = "0x48728D0", VA = "0x1848742D0", Slot = "15")]
		public override void SetValue(KIBCFPELJCB.PEDPBIEFMHC CEJMOFAPBGN, object FEBGGALLBNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A94C10", Offset = "0x6A93210", VA = "0x186A94C10")]
	public JFPNFPLAHJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class AGEAOHMIGFM : ContainerPropertyBag<JPIFDHEJDJL<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A93430", Offset = "0x6A91A30", VA = "0x186A93430")]
	public AGEAOHMIGFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal class JFJNEGCHANI : ContainerPropertyBag<NGNNOAMAGDI>
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class BIHDDMENPLI : Property<NGNNOAMAGDI, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string IKOGEGKCJIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6A93660", Offset = "0x6A91C60", VA = "0x186A93660", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool AJPOMKOKGAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6A93620", Offset = "0x6A91C20", VA = "0x186A93620")]
		public BIHDDMENPLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6A935D0", Offset = "0x6A91BD0", VA = "0x186A935D0", Slot = "14")]
		public override Rigidbody GetValue(NGNNOAMAGDI CEJMOFAPBGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6A935F0", Offset = "0x6A91BF0", VA = "0x186A935F0", Slot = "15")]
		public override void SetValue(NGNNOAMAGDI CEJMOFAPBGN, Rigidbody FEBGGALLBNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A94B30", Offset = "0x6A93130", VA = "0x186A94B30")]
	public JFJNEGCHANI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class JADICJFGONK : ContainerPropertyBag<KALGKGCIAKH>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class BLJJIOLFKEM : Property<KALGKGCIAKH, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string IKOGEGKCJIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6A93790", Offset = "0x6A91D90", VA = "0x186A93790", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool AJPOMKOKGAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6A93750", Offset = "0x6A91D50", VA = "0x186A93750")]
		public BLJJIOLFKEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6A935D0", Offset = "0x6A91BD0", VA = "0x186A935D0", Slot = "14")]
		public override object GetValue(KALGKGCIAKH CEJMOFAPBGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6A935F0", Offset = "0x6A91BF0", VA = "0x186A935F0", Slot = "15")]
		public override void SetValue(KALGKGCIAKH CEJMOFAPBGN, object FEBGGALLBNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6A94A50", Offset = "0x6A93050", VA = "0x186A94A50")]
	public JADICJFGONK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal class KOIIJNJMAJC : ContainerPropertyBag<EMINNOBKKAH>
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private class PPNFAIABBPH : Property<EMINNOBKKAH, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string IKOGEGKCJIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6A95C20", Offset = "0x6A94220", VA = "0x186A95C20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool AJPOMKOKGAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6A95BE0", Offset = "0x6A941E0", VA = "0x186A95BE0")]
		public PPNFAIABBPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6A935D0", Offset = "0x6A91BD0", VA = "0x186A935D0", Slot = "14")]
		public override object GetValue(EMINNOBKKAH CEJMOFAPBGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6A935F0", Offset = "0x6A91BF0", VA = "0x186A935F0", Slot = "15")]
		public override void SetValue(EMINNOBKKAH CEJMOFAPBGN, object FEBGGALLBNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6A951F0", Offset = "0x6A937F0", VA = "0x186A951F0")]
	public KOIIJNJMAJC()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6A95C50", Offset = "0x6A94250", VA = "0x186A95C50")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class MIABPGLKCNF
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public MIABPGLKCNF()
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
