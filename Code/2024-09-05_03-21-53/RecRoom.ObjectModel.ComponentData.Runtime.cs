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
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
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
	public class _AssemblyIndex : MGJKNLCKGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6CA2460", Offset = "0x6CA0E60", VA = "0x186CA2460", Slot = "9")]
		public override void GNFEPPHDJMI(BFEBAIIJMOC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6CA2840", Offset = "0x6CA1240", VA = "0x186CA2840", Slot = "7")]
		public override void PNIDCIIAHOJ(DIMDGJNLMOK registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6283490", Offset = "0x6281E90", VA = "0x186283490")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct LNLHKBMIOJK : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildBuffer>, EOKPBCPLHBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6C9FF90", Offset = "0x6C9E990", VA = "0x186C9FF90", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA34E90", Offset = "0xA33890", VA = "0x180A34E90")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, EOKPBCPLHBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct LPGJOIDKCHO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct JMGAGJKBEBG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity DHMMICOMFDG;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct OMPKOMKLDIJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity DHMMICOMFDG;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct MBJIAJCIBII : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<KMNHAHILCFK> JPADODJFECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<Entity> KDAINOLCCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JobHandle KPAOAOAPKHJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DNMEJBJAJNL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6CA14E0", Offset = "0x6C9FEE0", VA = "0x186CA14E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int FPAPEBLAAHL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1490", Offset = "0x6C9FE90", VA = "0x186CA1490")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4E87980", Offset = "0x4E86380", VA = "0x184E87980")]
	public MBJIAJCIBII(NativeList<KMNHAHILCFK> JPADODJFECC, NativeList<Entity> KDAINOLCCIC, JobHandle KPAOAOAPKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1310", Offset = "0x6C9FD10", VA = "0x186CA1310")]
	public (Entity, NativeSlice<Entity>) CIBDKPGBDFC(int PPNCECJAFNC)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1430", Offset = "0x6C9FE30", VA = "0x186CA1430", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KMNHAHILCFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Entity MGPJOGDJPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int ELDAPMPELBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int OMBKDMFPMFJ;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FLFCPHGBMMB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CJMJALEGAMF(bool BPENMLOFGPN);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct OIPCNBLDOII : IEquatable<OIPCNBLDOII>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool PCOPOBELABB(int NCGCLGONMJP);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool HCHPHEHAJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool BGKCGPDKAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool DGEAAAGHLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool IHLLFCHNMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly PCOPOBELABB CCLOKCJMJDK;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1CF0", Offset = "0x6CA06F0", VA = "0x186CA1CF0")]
	public OIPCNBLDOII(NKIDGEMOIMN JOPMDPIIDPE, PCOPOBELABB CCLOKCJMJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1CC0", Offset = "0x6CA06C0", VA = "0x186CA1CC0")]
	public OIPCNBLDOII(bool HCHPHEHAJAC, bool BGKCGPDKAKK, bool DGEAAAGHLHA, bool IHLLFCHNMEK, PCOPOBELABB CCLOKCJMJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1B90", Offset = "0x6CA0590", VA = "0x186CA1B90")]
	public bool FGGALKCIFAB(int NCGCLGONMJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1C90", Offset = "0x6CA0690", VA = "0x186CA1C90")]
	public bool NFAEHDNBANF(int NCGCLGONMJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1C60", Offset = "0x6CA0660", VA = "0x186CA1C60")]
	public bool IFPIHJMINNJ(int NCGCLGONMJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1A80", Offset = "0x6CA0480", VA = "0x186CA1A80")]
	public bool BPGAPKNBEBG(int NCGCLGONMJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1AB0", Offset = "0x6CA04B0", VA = "0x186CA1AB0", Slot = "4")]
	public bool Equals(OIPCNBLDOII AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1AE0", Offset = "0x6CA04E0", VA = "0x186CA1AE0", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1BC0", Offset = "0x6CA05C0", VA = "0x186CA1BC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1A60", Offset = "0x6CA0460", VA = "0x186CA1A60")]
	private bool BFBBBAIBBCJ(int NCGCLGONMJP)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct FBLJGDCJDNF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct BENKHJKOGMA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct EAIHJJCBCPL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[InternalBufferCapacity(17)]
public struct FEMGEBEFJKC : IBufferElementData, IEquatable<FEMGEBEFJKC>, EOKPBCPLHBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity FGMPPONDFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int FBEHBAOLLEG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity NPODDNPBBIK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6CA09A0", Offset = "0x6C9F3A0", VA = "0x186CA09A0", Slot = "4")]
	public bool Equals(FEMGEBEFJKC AIPFCMFLDKG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct LOLBHPHCMDC : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct DDNODFDGCGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly GEKEPDOMMAG AEMNIAGJMLI;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x225C3B0", Offset = "0x225ADB0", VA = "0x18225C3B0")]
		public DDNODFDGCGG(GEKEPDOMMAG PHOMHDJOELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0530", Offset = "0x6C9EF30", VA = "0x186CA0530")]
		public bool FDABFMGENNL(LOLBHPHCMDC DCKEGIIOIBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0540", Offset = "0x6C9EF40", VA = "0x186CA0540")]
		public bool NEGMJAPPIFB(LOLBHPHCMDC DCKEGIIOIBB, GEKEPDOMMAG GCFNKHEBGMM)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly GEKEPDOMMAG MFEBJKDFCAF;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x225C3B0", Offset = "0x225ADB0", VA = "0x18225C3B0")]
	public LOLBHPHCMDC(GEKEPDOMMAG MFEBJKDFCAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6CA10F0", Offset = "0x6C9FAF0", VA = "0x186CA10F0")]
	public LOLBHPHCMDC KGLDGLFOPCL(GEKEPDOMMAG GPHMIBAJKOP)
	{
		return default(LOLBHPHCMDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6CA10E0", Offset = "0x6C9FAE0", VA = "0x186CA10E0")]
	public LOLBHPHCMDC AFILGHIEJCO(GEKEPDOMMAG OEDKMBFDDPH)
	{
		return default(LOLBHPHCMDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1100", Offset = "0x6C9FB00", VA = "0x186CA1100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[Flags]
public enum GEKEPDOMMAG : byte
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
public enum PLGDHIFBMCG : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[HLMDPOAMIPG]
public struct CJDNOIJDMPM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public PLGDHIFBMCG MFEBJKDFCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public bool FPKAFNJGHHH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool CHIBKJHMJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6CA03B0", Offset = "0x6C9EDB0", VA = "0x186CA03B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6CA03E0", Offset = "0x6C9EDE0", VA = "0x186CA03E0")]
	private CJDNOIJDMPM(PLGDHIFBMCG MFEBJKDFCAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6CA03C0", Offset = "0x6C9EDC0", VA = "0x186CA03C0")]
	public CJDNOIJDMPM KGLDGLFOPCL(PLGDHIFBMCG GPHMIBAJKOP)
	{
		return default(CJDNOIJDMPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0390", Offset = "0x6C9ED90", VA = "0x186CA0390")]
	public CJDNOIJDMPM AFILGHIEJCO(PLGDHIFBMCG OEDKMBFDDPH)
	{
		return default(CJDNOIJDMPM);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct DNCOEHCJAMN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct BMCJNAHKHEC : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Entity GKMLMKJKKDA;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildBuffer>, EOKPBCPLHBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6C9FF90", Offset = "0x6C9E990", VA = "0x186C9FF90", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA34E90", Offset = "0xA33890", VA = "0x180A34E90")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[HLMDPOAMIPG]
public struct LMGMKFPCLKN : ISystemStateBufferElementData, IBufferElementData, EOKPBCPLHBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public Entity HLKOPNMJGHO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Entity MCOHIAEACAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct PKGCIECHAOG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Entity PKKHKDFDHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Entity BDNNFDCLLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity MDJIHHIDCKA;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct APACCKEDPOA<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly bool IMCHLNDGPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public uint ABGDHDAJHJL;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool GKCMOBPNMML()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.TypeVersion(2)]
public struct DLLOJKKDNIO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public uint IHOBMHJAKNP;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0630", Offset = "0x6C9F030", VA = "0x186CA0630", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct JMOCPNPGBPG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[HLMDPOAMIPG]
public struct LGCEEMPIMME : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public int PHAMFCJINCP;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct CAMPHJHBPNG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int MIDIEPCHOAJ;
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct FNENCOLFPNC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public GCHandle DBNAGJFFAKG;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct EIEELONDEEP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public int MIDIEPCHOAJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct EGHHCDCMHLJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct LEMPDOPNMHN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public int MIDIEPCHOAJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct AAIOAGPKBOA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct OHNEKJAJCHG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct NOHBIACHHHN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct CAIIPLMGLLM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public CollisionDetectionMode MOILANHLOEA;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[AAHPOMMNEKL]
public struct APGFBOADNNI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public JNKKEIFENFB KIEMEHHDJLE;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly APGFBOADNNI LGKHJAOMEPI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct EPADGELOBDP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct INBBAKLOPOD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct EOGGFDEJJCO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[InternalBufferCapacity(0)]
public struct BJAEJJIDONC : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Entity FGMPPONDFPE;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct JKEKPNLEJBF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Entity DLPGBMPJIIG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct FIOMJMIOBIG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct KHNIJBLBADB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Entity MGPJOGDJPHA;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct KEKHEKDGJII : FMFOALMDEDJ, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IJPHLMMHLLL CGGDMDHFMLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(IJPHLMMHLLL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct EDKAEEFHBGH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float3 NNGNAJJPAAD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct KADAEFNPEJM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[AAHPOMMNEKL]
public struct BGCFHPLDKKH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public float3x3 ENCBDNIANFH;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly BGCFHPLDKKH LGKHJAOMEPI;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[AAHPOMMNEKL]
public struct EDJAKKLAAIC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public float3x3 ENCBDNIANFH;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly EDJAKKLAAIC LGKHJAOMEPI;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct AADFHMAIBEG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public float3 DGPPINEBMIF;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct AADMBJPPHMK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public float3 HJGFOKAMHAF;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[AAHPOMMNEKL]
public struct FBDBCDBEMLJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float AKMOHLANENN;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly FBDBCDBEMLJ LGKHJAOMEPI;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[AAHPOMMNEKL]
public struct KMJAMNLIDBK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public float GANMDNFMAEB;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly KMJAMNLIDBK LGKHJAOMEPI;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct PAALLCPOGLC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public float3 AKEOELCGFPM;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct CKNHHCOLFPH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public MFAANDACBHL LJMICMJLNPK;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct CPGPIJKPEED : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public MFAANDACBHL JIEIBMFJOAE;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[HLMDPOAMIPG]
public struct KLMJJADGJGD : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Entity HLKOPNMJGHO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct NIJJCHPFHCN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct DKFDMOMGJKC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct KEIOKOPEKBC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public RigidbodyConstraints AADIACFNDHD;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[AAHPOMMNEKL]
public struct PNDIAPJLGAO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public float IILHOJFNPBM;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly PNDIAPJLGAO LGKHJAOMEPI;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct EEFEKHDBPIH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float POHEHLDHGBN;
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class ILEODJHHPDA : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct EEHNONCEOMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public object AMBHKHDIIIA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public GameObject EABKFLBGOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public object LJGJEDKOKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public object BIILAIMNLMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public EEHNONCEOMC AMBHKHDIIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public Delegate IMBBEJKJIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Delegate MABGPICENJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public HMEICMNDOOE<Delegate> KEGDFCLPFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public HMEICMNDOOE<Delegate> HFKNKEAPJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public HMEICMNDOOE<Delegate> FKJGIGFAFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HMEICMNDOOE<Delegate> OOOEMANKGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public HMEICMNDOOE<Delegate> AIKDLIAGGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public HMEICMNDOOE<Delegate> IMDIMHAMDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public HMEICMNDOOE<Delegate> PMLNJADODJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public HMEICMNDOOE<Delegate> EIOPNEIBODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public HMEICMNDOOE<Delegate> OMOPKGMBKOF;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0C10", Offset = "0x6C9F610", VA = "0x186CA0C10", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public ILEODJHHPDA()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct DKCCMLJAFKF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct NOGACIBDHAL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int IHGJMABLDCH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x140D770", Offset = "0x140C170", VA = "0x18140D770")]
	public static NOGACIBDHAL PFMAFNCLKDD(int CLMKDBDPNNH)
	{
		return default(NOGACIBDHAL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class IHBABOOBFCO : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public Rigidbody BHBGFFIGMHB;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0BA0", Offset = "0x6C9F5A0", VA = "0x186CA0BA0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public IHBABOOBFCO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct PCNIDDNONJH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct CEJHIENPIBC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 DJJLOCLIPLL;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct FJFFOGLLHFH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float3 NJFMAFAPHLI;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AAHPOMMNEKL]
public struct BGDCADBOIKL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float AGMLJGLHOIN;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly BGDCADBOIKL LGKHJAOMEPI;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class ABCHHAIIDLE : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public object KIJDIMMJCEM;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6C9F6E0", Offset = "0x6C9E0E0", VA = "0x186C9F6E0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public ABCHHAIIDLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class NEIOIFAGADK : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public object PNBHIHNKLMI;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6CA16D0", Offset = "0x6CA00D0", VA = "0x186CA16D0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public NEIOIFAGADK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct PBABCNMJMCK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct PPKMCCMLEKI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct DAKHMJODKPH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct EBCGKCNOAAH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct DDFOBDJMBMM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct DDIIDPEDCDC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public FixedString32Bytes HBOONHFLONJ;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[HLMDPOAMIPG]
public struct DDKMGLAIBPL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Entity MPCFINNNDLP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0xA34E90", Offset = "0xA33890", VA = "0x180A34E90")]
	public static DDKMGLAIBPL PFMAFNCLKDD(Entity CLMKDBDPNNH)
	{
		return default(DDKMGLAIBPL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal struct DGOFAPIEHBN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Entity HLKOPNMJGHO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0xA34E90", Offset = "0xA33890", VA = "0x180A34E90")]
	public static DGOFAPIEHBN PFMAFNCLKDD(Entity HLKOPNMJGHO)
	{
		return default(DGOFAPIEHBN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct BOHKOLEAINO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Entity GHMOAFLHIGF;
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct CIKHLLOEOLB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Entity GHMOAFLHIGF;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal struct PABDGHCHEFN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Entity KMHLLPFGKAD;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xA34E90", Offset = "0xA33890", VA = "0x180A34E90")]
	public static PABDGHCHEFN PFMAFNCLKDD(Entity HLKOPNMJGHO)
	{
		return default(PABDGHCHEFN);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal struct OHLOIGIBMNC : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct EDDKJJFEMED : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct DFLNJAPEFAP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public uint DHAIIPINBBD;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[HLMDPOAMIPG]
internal struct GNLMFHKONOJ : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public Entity DBLJICCMHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int EBDDHAPIAHH;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal struct IBOAHLBGACI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public Entity GCCNBCCDLBA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct MDILIGGMMGL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct LNBHDHCBOLB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public uint ABGDHDAJHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int OKANBKGPHGM;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x921970", Offset = "0x920370", VA = "0x180921970")]
	public LNBHDHCBOLB(uint IEKADNCFGDD, int IACHBAHFBCN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct BPDKPEOIBHL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct FCFLIMLKCIO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct IBBPEJBMEHB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct IIAOHPJPBEB : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct COLNCIICLMJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct FKIDMPGIPHO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct ACAHFDLMDJN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct COJOAGPJCDI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal struct JNPDJABAIBH : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct FNMNPOAPENG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct FBAGFOFBJJC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct BBJPKGONBNI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal struct IGMNCMGFMHA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal struct LAOMMFCFFBG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct JHKDNJEMADK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct BGGJCBHEFMG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct IKKGJMGOBJG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct GGMFKFMDMJM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct IINGLIKFINF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct GNCBFIMJJJL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct OFDNHKHHDEO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct CMKKONFEFPB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct IILPPNFMEGD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct HPLLPDMLPMB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal struct HKGEFPIINDK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct HAKBAJHEBEN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct CKPOPPCFGGA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct MPIBNAGGFAF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[HLMDPOAMIPG]
public struct LPHMLOHLNCO : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public FixedString32Bytes HAEMEJAGICK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct ECFJNCGCFLA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct PCKIKMMHEKL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal struct BNJNLFPPAFB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal struct KDKILNNGPKF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal struct DLFBBECOBFH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct LPMJHLPMBFF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct PCJBJMFNFEA : IComponentData, IComparable<PCJBJMFNFEA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public int CJKPNIMIIKL;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1CB2800", Offset = "0x1CB1200", VA = "0x181CB2800", Slot = "4")]
	public int CompareTo(PCJBJMFNFEA AIPFCMFLDKG)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct KEELANMNOJI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct IDMFJGOCOFD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public quaternion FJFNLINEAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float3 BJDHDJCINFH;
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct GGHLNBJIAPM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float MBKDHBFGGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float HKKJOGLKBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float KBPFFBECHFJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct FJFEOMFHAPD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct EDBGOHIOJNI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct OLMDJPMGAJO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct AMPCFDCBDNM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public int MIDIEPCHOAJ;
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[HLMDPOAMIPG]
public struct LONKFLEPKCD : ISystemStateBufferElementData, IBufferElementData, EOKPBCPLHBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Entity POMBPEDHPHB;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Entity MCOHIAEACAC
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[AAHPOMMNEKL]
public struct KLPOKPIEBOP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public float4x4 APGPMOPMBHH;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public static readonly KLPOKPIEBOP LGKHJAOMEPI;
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[AAHPOMMNEKL]
public struct NCOCIOFCNLC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public float4x4 GFJPPCILDBJ;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public static readonly NCOCIOFCNLC LGKHJAOMEPI;
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public struct MPELADOOOON : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private int NCLALFEJPHP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int EBDDHAPIAHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1610", Offset = "0x6CA0010", VA = "0x186CA1610")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1600", Offset = "0x6CA0000", VA = "0x186CA1600")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[AAHPOMMNEKL]
public struct CNMEBGCPEBK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public float3 DNDGJCHCBLP;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public static readonly CNMEBGCPEBK LGKHJAOMEPI;
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[AAHPOMMNEKL]
public struct NPIHGJIOIIA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float3 BJDHDJCINFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public quaternion FJFNLINEAKI;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public static readonly NPIHGJIOIIA LGKHJAOMEPI;
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class MNOMLLJIPPO
{
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[AAHPOMMNEKL]
public struct PBIHMKJBFDL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float KPKLPDPAINP;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public static readonly PBIHMKJBFDL LGKHJAOMEPI;
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct EGEKLLHCLBA : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Entity HLFPHDBLGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public GKIIHAFLNOK OIKBGDLAKHG;
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct EBHIALCFHKL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public GKIIHAFLNOK OIKBGDLAKHG;
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct NOHJLGIELKK : ISystemStateComponentData, IComponentData, EOKPBCPLHBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Entity OMFPMCIAPMD;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity MCOHIAEACAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct CEMFACEIDPF : ISystemStateBufferElementData, IBufferElementData, EOKPBCPLHBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity IIMJLADOPOI;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Entity MCOHIAEACAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct MDDKEICPGCD : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Entity HLFPHDBLGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public GKIIHAFLNOK OIKBGDLAKHG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct MBPBMLPGLJL : IEqualityComparer<MDDKEICPGCD>
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public static MBPBMLPGLJL LGKHJAOMEPI;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1550", Offset = "0x6C9FF50", VA = "0x186CA1550", Slot = "4")]
	public bool Equals(MDDKEICPGCD ICJCFEHCALD, MDDKEICPGCD MPEFCGEJLMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6CA15A0", Offset = "0x6C9FFA0", VA = "0x186CA15A0", Slot = "5")]
	public int GetHashCode(MDDKEICPGCD GIGIFGONEAO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct LNOHOAOBGCA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public FixedList32Bytes<int> AHLLKDMIMLK;
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct LHJCHLNDKMN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public FixedList32Bytes<int> AHLLKDMIMLK;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct IBOLHBFDFBK : ISystemStateBufferElementData, IBufferElementData, EOKPBCPLHBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Entity IPAJPJEFMEP;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private Entity NPODDNPBBIK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C0", Offset = "0xA3D3C0", VA = "0x180A3E9C0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xF9B490", Offset = "0xF99E90", VA = "0x180F9B490", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class AHLIOEEEFNC : ContainerPropertyBag<ILEODJHHPDA>
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	private class OMIPIAMDACP : Property<ILEODJHHPDA, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string IAIAEPAKLMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6CA1D70", Offset = "0x6CA0770", VA = "0x186CA1D70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool NFLNLAGFBEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1D30", Offset = "0x6CA0730", VA = "0x186CA1D30")]
		public OMIPIAMDACP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6CA07B0", Offset = "0x6C9F1B0", VA = "0x186CA07B0", Slot = "14")]
		public override GameObject GetValue(ILEODJHHPDA PLCAFBBHOLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6CA07D0", Offset = "0x6C9F1D0", VA = "0x186CA07D0", Slot = "15")]
		public override void SetValue(ILEODJHHPDA PLCAFBBHOLF, GameObject CLMKDBDPNNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class ABMMFEOGKPE : Property<ILEODJHHPDA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string IAIAEPAKLMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6C9F8C0", Offset = "0x6C9E2C0", VA = "0x186C9F8C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool NFLNLAGFBEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6C9F880", Offset = "0x6C9E280", VA = "0x186C9F880")]
		public ABMMFEOGKPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C9F830", Offset = "0x6C9E230", VA = "0x186C9F830", Slot = "14")]
		public override object GetValue(ILEODJHHPDA PLCAFBBHOLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6C9F850", Offset = "0x6C9E250", VA = "0x186C9F850", Slot = "15")]
		public override void SetValue(ILEODJHHPDA PLCAFBBHOLF, object CLMKDBDPNNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class CMHDDIOEIIE : Property<ILEODJHHPDA, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string IAIAEPAKLMP
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6CA0480", Offset = "0x6C9EE80", VA = "0x186CA0480", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool NFLNLAGFBEP
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0440", Offset = "0x6C9EE40", VA = "0x186CA0440")]
		public CMHDDIOEIIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6CA03F0", Offset = "0x6C9EDF0", VA = "0x186CA03F0", Slot = "14")]
		public override object GetValue(ILEODJHHPDA PLCAFBBHOLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0410", Offset = "0x6C9EE10", VA = "0x186CA0410", Slot = "15")]
		public override void SetValue(ILEODJHHPDA PLCAFBBHOLF, object CLMKDBDPNNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	private class OCMGLFCKLMI : Property<ILEODJHHPDA, ILEODJHHPDA.EEHNONCEOMC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string IAIAEPAKLMP
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6CA19C0", Offset = "0x6CA03C0", VA = "0x186CA19C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool NFLNLAGFBEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1980", Offset = "0x6CA0380", VA = "0x186CA1980")]
		public OCMGLFCKLMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1930", Offset = "0x6CA0330", VA = "0x186CA1930", Slot = "14")]
		public override ILEODJHHPDA.EEHNONCEOMC GetValue(ILEODJHHPDA PLCAFBBHOLF)
		{
			return default(ILEODJHHPDA.EEHNONCEOMC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1950", Offset = "0x6CA0350", VA = "0x186CA1950", Slot = "15")]
		public override void SetValue(ILEODJHHPDA PLCAFBBHOLF, ILEODJHHPDA.EEHNONCEOMC CLMKDBDPNNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private class MBELCIOKKAC : Property<ILEODJHHPDA, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string IAIAEPAKLMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6CA12E0", Offset = "0x6C9FCE0", VA = "0x186CA12E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool NFLNLAGFBEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6CA12A0", Offset = "0x6C9FCA0", VA = "0x186CA12A0")]
		public MBELCIOKKAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1250", Offset = "0x6C9FC50", VA = "0x186CA1250", Slot = "14")]
		public override Delegate GetValue(ILEODJHHPDA PLCAFBBHOLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1270", Offset = "0x6C9FC70", VA = "0x186CA1270", Slot = "15")]
		public override void SetValue(ILEODJHHPDA PLCAFBBHOLF, Delegate CLMKDBDPNNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	private class NJHIAFHFJJH : Property<ILEODJHHPDA, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string IAIAEPAKLMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6CA17D0", Offset = "0x6CA01D0", VA = "0x186CA17D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool NFLNLAGFBEP
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1790", Offset = "0x6CA0190", VA = "0x186CA1790")]
		public NJHIAFHFJJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1740", Offset = "0x6CA0140", VA = "0x186CA1740", Slot = "14")]
		public override Delegate GetValue(ILEODJHHPDA PLCAFBBHOLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1760", Offset = "0x6CA0160", VA = "0x186CA1760", Slot = "15")]
		public override void SetValue(ILEODJHHPDA PLCAFBBHOLF, Delegate CLMKDBDPNNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private class HNALPEEJKNC : Property<ILEODJHHPDA, HMEICMNDOOE<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string IAIAEPAKLMP
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6CA0B00", Offset = "0x6C9F500", VA = "0x186CA0B00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool NFLNLAGFBEP
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0AC0", Offset = "0x6C9F4C0", VA = "0x186CA0AC0")]
		public HNALPEEJKNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0A50", Offset = "0x6C9F450", VA = "0x186CA0A50", Slot = "14")]
		public override HMEICMNDOOE<Delegate> GetValue(ILEODJHHPDA PLCAFBBHOLF)
		{
			return default(HMEICMNDOOE<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0A80", Offset = "0x6C9F480", VA = "0x186CA0A80", Slot = "15")]
		public override void SetValue(ILEODJHHPDA PLCAFBBHOLF, HMEICMNDOOE<Delegate> CLMKDBDPNNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private class LDACCMGGODN : Property<ILEODJHHPDA, HMEICMNDOOE<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string IAIAEPAKLMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6CA0FC0", Offset = "0x6C9F9C0", VA = "0x186CA0FC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool NFLNLAGFBEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0F80", Offset = "0x6C9F980", VA = "0x186CA0F80")]
		public LDACCMGGODN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0F10", Offset = "0x6C9F910", VA = "0x186CA0F10", Slot = "14")]
		public override HMEICMNDOOE<Delegate> GetValue(ILEODJHHPDA PLCAFBBHOLF)
		{
			return default(HMEICMNDOOE<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0F40", Offset = "0x6C9F940", VA = "0x186CA0F40", Slot = "15")]
		public override void SetValue(ILEODJHHPDA PLCAFBBHOLF, HMEICMNDOOE<Delegate> CLMKDBDPNNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class CAOEDOBDPJG : Property<ILEODJHHPDA, HMEICMNDOOE<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string IAIAEPAKLMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6CA0360", Offset = "0x6C9ED60", VA = "0x186CA0360", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool NFLNLAGFBEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0320", Offset = "0x6C9ED20", VA = "0x186CA0320")]
		public CAOEDOBDPJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6CA02B0", Offset = "0x6C9ECB0", VA = "0x186CA02B0", Slot = "14")]
		public override HMEICMNDOOE<Delegate> GetValue(ILEODJHHPDA PLCAFBBHOLF)
		{
			return default(HMEICMNDOOE<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6CA02E0", Offset = "0x6C9ECE0", VA = "0x186CA02E0", Slot = "15")]
		public override void SetValue(ILEODJHHPDA PLCAFBBHOLF, HMEICMNDOOE<Delegate> CLMKDBDPNNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	private class ENJJHDOJKEC : Property<ILEODJHHPDA, HMEICMNDOOE<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string IAIAEPAKLMP
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6CA0930", Offset = "0x6C9F330", VA = "0x186CA0930", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool NFLNLAGFBEP
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6CA08F0", Offset = "0x6C9F2F0", VA = "0x186CA08F0")]
		public ENJJHDOJKEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0870", Offset = "0x6C9F270", VA = "0x186CA0870", Slot = "14")]
		public override HMEICMNDOOE<Delegate> GetValue(ILEODJHHPDA PLCAFBBHOLF)
		{
			return default(HMEICMNDOOE<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6CA08B0", Offset = "0x6C9F2B0", VA = "0x186CA08B0", Slot = "15")]
		public override void SetValue(ILEODJHHPDA PLCAFBBHOLF, HMEICMNDOOE<Delegate> CLMKDBDPNNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private class LOMONDPIIHM : Property<ILEODJHHPDA, HMEICMNDOOE<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string IAIAEPAKLMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6CA1220", Offset = "0x6C9FC20", VA = "0x186CA1220", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool NFLNLAGFBEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6CA11E0", Offset = "0x6C9FBE0", VA = "0x186CA11E0")]
		public LOMONDPIIHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1160", Offset = "0x6C9FB60", VA = "0x186CA1160", Slot = "14")]
		public override HMEICMNDOOE<Delegate> GetValue(ILEODJHHPDA PLCAFBBHOLF)
		{
			return default(HMEICMNDOOE<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6CA11A0", Offset = "0x6C9FBA0", VA = "0x186CA11A0", Slot = "15")]
		public override void SetValue(ILEODJHHPDA PLCAFBBHOLF, HMEICMNDOOE<Delegate> CLMKDBDPNNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	private class BCANHELGEID : Property<ILEODJHHPDA, HMEICMNDOOE<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string IAIAEPAKLMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6CA0060", Offset = "0x6C9EA60", VA = "0x186CA0060", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool NFLNLAGFBEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0020", Offset = "0x6C9EA20", VA = "0x186CA0020")]
		public BCANHELGEID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6C9FFA0", Offset = "0x6C9E9A0", VA = "0x186C9FFA0", Slot = "14")]
		public override HMEICMNDOOE<Delegate> GetValue(ILEODJHHPDA PLCAFBBHOLF)
		{
			return default(HMEICMNDOOE<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6C9FFE0", Offset = "0x6C9E9E0", VA = "0x186C9FFE0", Slot = "15")]
		public override void SetValue(ILEODJHHPDA PLCAFBBHOLF, HMEICMNDOOE<Delegate> CLMKDBDPNNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	private class BJJFCJFLHAD : Property<ILEODJHHPDA, HMEICMNDOOE<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string IAIAEPAKLMP
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6CA0280", Offset = "0x6C9EC80", VA = "0x186CA0280", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool NFLNLAGFBEP
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0240", Offset = "0x6C9EC40", VA = "0x186CA0240")]
		public BJJFCJFLHAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6CA01C0", Offset = "0x6C9EBC0", VA = "0x186CA01C0", Slot = "14")]
		public override HMEICMNDOOE<Delegate> GetValue(ILEODJHHPDA PLCAFBBHOLF)
		{
			return default(HMEICMNDOOE<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0200", Offset = "0x6C9EC00", VA = "0x186CA0200", Slot = "15")]
		public override void SetValue(ILEODJHHPDA PLCAFBBHOLF, HMEICMNDOOE<Delegate> CLMKDBDPNNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class PLGJIOKLNBF : Property<ILEODJHHPDA, HMEICMNDOOE<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string IAIAEPAKLMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x6CA1EA0", Offset = "0x6CA08A0", VA = "0x186CA1EA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool NFLNLAGFBEP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1E60", Offset = "0x6CA0860", VA = "0x186CA1E60")]
		public PLGJIOKLNBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1DE0", Offset = "0x6CA07E0", VA = "0x186CA1DE0", Slot = "14")]
		public override HMEICMNDOOE<Delegate> GetValue(ILEODJHHPDA PLCAFBBHOLF)
		{
			return default(HMEICMNDOOE<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1E20", Offset = "0x6CA0820", VA = "0x186CA1E20", Slot = "15")]
		public override void SetValue(ILEODJHHPDA PLCAFBBHOLF, HMEICMNDOOE<Delegate> CLMKDBDPNNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	private class LEDFEMOHHEI : Property<ILEODJHHPDA, HMEICMNDOOE<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string IAIAEPAKLMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6CA10B0", Offset = "0x6C9FAB0", VA = "0x186CA10B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool NFLNLAGFBEP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1070", Offset = "0x6C9FA70", VA = "0x186CA1070")]
		public LEDFEMOHHEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0FF0", Offset = "0x6C9F9F0", VA = "0x186CA0FF0", Slot = "14")]
		public override HMEICMNDOOE<Delegate> GetValue(ILEODJHHPDA PLCAFBBHOLF)
		{
			return default(HMEICMNDOOE<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1030", Offset = "0x6C9FA30", VA = "0x186CA1030", Slot = "15")]
		public override void SetValue(ILEODJHHPDA PLCAFBBHOLF, HMEICMNDOOE<Delegate> CLMKDBDPNNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6C9F8F0", Offset = "0x6C9E2F0", VA = "0x186C9F8F0")]
	public AHLIOEEEFNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal class DFGCFCBAGAJ : ContainerPropertyBag<ILEODJHHPDA.EEHNONCEOMC>
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private class PMEPJBFJIGG : Property<ILEODJHHPDA.EEHNONCEOMC, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string IAIAEPAKLMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6CA1F10", Offset = "0x6CA0910", VA = "0x186CA1F10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool NFLNLAGFBEP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1ED0", Offset = "0x6CA08D0", VA = "0x186CA1ED0")]
		public PMEPJBFJIGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xB97550", Offset = "0xB95F50", VA = "0x180B97550", Slot = "14")]
		public override object GetValue(ILEODJHHPDA.EEHNONCEOMC PLCAFBBHOLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4965390", Offset = "0x4963D90", VA = "0x184965390", Slot = "15")]
		public override void SetValue(ILEODJHHPDA.EEHNONCEOMC PLCAFBBHOLF, object CLMKDBDPNNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0550", Offset = "0x6C9EF50", VA = "0x186CA0550")]
	public DFGCFCBAGAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class FOAPPBIJIAH : ContainerPropertyBag<HMEICMNDOOE<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6CA09F0", Offset = "0x6C9F3F0", VA = "0x186CA09F0")]
	public FOAPPBIJIAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal class ABJNGHKIEKN : ContainerPropertyBag<IHBABOOBFCO>
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class EHPFBDLBOFM : Property<IHBABOOBFCO, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string IAIAEPAKLMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6CA0840", Offset = "0x6C9F240", VA = "0x186CA0840", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool NFLNLAGFBEP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0800", Offset = "0x6C9F200", VA = "0x186CA0800")]
		public EHPFBDLBOFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6CA07B0", Offset = "0x6C9F1B0", VA = "0x186CA07B0", Slot = "14")]
		public override Rigidbody GetValue(IHBABOOBFCO PLCAFBBHOLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6CA07D0", Offset = "0x6C9F1D0", VA = "0x186CA07D0", Slot = "15")]
		public override void SetValue(IHBABOOBFCO PLCAFBBHOLF, Rigidbody CLMKDBDPNNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6C9F750", Offset = "0x6C9E150", VA = "0x186C9F750")]
	public ABJNGHKIEKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class KDEAMKFHCNP : ContainerPropertyBag<ABCHHAIIDLE>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class OEKBEFJJMLK : Property<ABCHHAIIDLE, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string IAIAEPAKLMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6CA1A30", Offset = "0x6CA0430", VA = "0x186CA1A30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool NFLNLAGFBEP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6CA19F0", Offset = "0x6CA03F0", VA = "0x186CA19F0")]
		public OEKBEFJJMLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6CA07B0", Offset = "0x6C9F1B0", VA = "0x186CA07B0", Slot = "14")]
		public override object GetValue(ABCHHAIIDLE PLCAFBBHOLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6CA07D0", Offset = "0x6C9F1D0", VA = "0x186CA07D0", Slot = "15")]
		public override void SetValue(ABCHHAIIDLE PLCAFBBHOLF, object CLMKDBDPNNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0C60", Offset = "0x6C9F660", VA = "0x186CA0C60")]
	public KDEAMKFHCNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal class KMBBMGBHHAJ : ContainerPropertyBag<NEIOIFAGADK>
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private class IGIPHILMPEN : Property<NEIOIFAGADK, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string IAIAEPAKLMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6CA0B70", Offset = "0x6C9F570", VA = "0x186CA0B70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool NFLNLAGFBEP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0B30", Offset = "0x6C9F530", VA = "0x186CA0B30")]
		public IGIPHILMPEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6CA07B0", Offset = "0x6C9F1B0", VA = "0x186CA07B0", Slot = "14")]
		public override object GetValue(NEIOIFAGADK PLCAFBBHOLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6CA07D0", Offset = "0x6C9F1D0", VA = "0x186CA07D0", Slot = "15")]
		public override void SetValue(NEIOIFAGADK PLCAFBBHOLF, object CLMKDBDPNNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0DF0", Offset = "0x6C9F7F0", VA = "0x186CA0DF0")]
	public KMBBMGBHHAJ()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1F80", Offset = "0x6CA0980", VA = "0x186CA1F80")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class HFMJLCPPHLB
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public HFMJLCPPHLB()
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
