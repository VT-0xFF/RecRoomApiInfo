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
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
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
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
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
	public class _AssemblyIndex : OIHPLJCCMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x69DE780", Offset = "0x69DDB80", VA = "0x1869DE780", Slot = "8")]
		public override void DLOFGCDOMEH(FELKOHNNBJK registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x69DE320", Offset = "0x69DD720", VA = "0x1869DE320", Slot = "7")]
		public override void CEAPAMBFFHI(GKEDFCPMODP registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x69DEB80", Offset = "0x69DDF80", VA = "0x1869DEB80")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct IFJFAOGGODO : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildBuffer>, MJOBODLPDGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x99D3A0", Offset = "0x99C7A0", VA = "0x18099D3A0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xF01850", Offset = "0xF00C50", VA = "0x180F01850", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x69DBDB0", Offset = "0x69DB1B0", VA = "0x1869DBDB0", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xF01850", Offset = "0xF00C50", VA = "0x180F01850")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x97B1B0", Offset = "0x97A5B0", VA = "0x18097B1B0")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, MJOBODLPDGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x99D3A0", Offset = "0x99C7A0", VA = "0x18099D3A0", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xF01850", Offset = "0xF00C50", VA = "0x180F01850", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct LOMLNGHJCAO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct ALFMOHPJBGG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity ANCLEKHKIOF;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct KICOHIEFIFA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity ANCLEKHKIOF;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct IOIMKJMLELH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<JEODBBKHFMD> FOFCBLOIAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<Entity> LFLFIKKFDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JobHandle DBNLEGDAPHE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BCGECPIHIBO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x69DD200", Offset = "0x69DC600", VA = "0x1869DD200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int AKKFFAPEOHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x69DD390", Offset = "0x69DC790", VA = "0x1869DD390")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4D0C570", Offset = "0x4D0B970", VA = "0x184D0C570")]
	public IOIMKJMLELH(NativeList<JEODBBKHFMD> FOFCBLOIAJP, NativeList<Entity> LFLFIKKFDJA, JobHandle DBNLEGDAPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x69DD270", Offset = "0x69DC670", VA = "0x1869DD270")]
	public (Entity, NativeSlice<Entity>) KOMINIDJKNN(int CBBBHLKBJGE)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x69DD1A0", Offset = "0x69DC5A0", VA = "0x1869DD1A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct JEODBBKHFMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Entity MILPLABKJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int BILMLHHHLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int CHJNEOPKHME;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KDALBDBNAFH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MCAHMKOOEEO(bool GCFIOEDPJGF);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct BAJOFIABLEK : IEquatable<BAJOFIABLEK>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool HOOGBJLAJCO(int CPCCBMAHCJD);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool EAOOGEJANGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool AALMCGIAIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool KPFLLNADCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool APDJKGAPABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly HOOGBJLAJCO HJJGJDMAJJK;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x69DC020", Offset = "0x69DB420", VA = "0x1869DC020")]
	public BAJOFIABLEK(DAMGCJMCCIG EMGMDFDPKIE, HOOGBJLAJCO HJJGJDMAJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x69DC060", Offset = "0x69DB460", VA = "0x1869DC060")]
	public BAJOFIABLEK(bool EAOOGEJANGN, bool AALMCGIAIEA, bool KPFLLNADCIL, bool APDJKGAPABM, HOOGBJLAJCO HJJGJDMAJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x69DBDC0", Offset = "0x69DB1C0", VA = "0x1869DBDC0")]
	public bool AMIPCPOCMJF(int CPCCBMAHCJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x69DBFF0", Offset = "0x69DB3F0", VA = "0x1869DBFF0")]
	public bool NMJFMJBGLHC(int CPCCBMAHCJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x69DBDF0", Offset = "0x69DB1F0", VA = "0x1869DBDF0")]
	public bool CMOHMOHJBPB(int CPCCBMAHCJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x69DBFC0", Offset = "0x69DB3C0", VA = "0x1869DBFC0")]
	public bool JBNKHEAFBCI(int CPCCBMAHCJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x69DBEF0", Offset = "0x69DB2F0", VA = "0x1869DBEF0", Slot = "4")]
	public bool Equals(BAJOFIABLEK IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x69DBE40", Offset = "0x69DB240", VA = "0x1869DBE40", Slot = "0")]
	public override bool Equals(object LALIGKIKEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x69DBF20", Offset = "0x69DB320", VA = "0x1869DBF20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x69DBE20", Offset = "0x69DB220", VA = "0x1869DBE20")]
	private bool EBICEBGPBHM(int CPCCBMAHCJD)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct KGLKFEIKABN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct FJIGMBOJHHJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct FLDNGMGOIGC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[InternalBufferCapacity(17)]
public struct PECFOCJBHCK : IBufferElementData, IEquatable<PECFOCJBHCK>, MJOBODLPDGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity LGDEAAPGGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int AAPHCEAPPLH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity DNFKJMMHGJG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x99D3A0", Offset = "0x99C7A0", VA = "0x18099D3A0", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xF01850", Offset = "0xF00C50", VA = "0x180F01850", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x69DDDB0", Offset = "0x69DD1B0", VA = "0x1869DDDB0", Slot = "4")]
	public bool Equals(PECFOCJBHCK IEDCHGMDIML)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct DOIEIJBALKG : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct FEBIPIADHAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly ECNGAACDJHM BMCGHCHKPGI;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x21B2C90", Offset = "0x21B2090", VA = "0x1821B2C90")]
		public FEBIPIADHAP(ECNGAACDJHM JGBCLJDFGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x69DCB20", Offset = "0x69DBF20", VA = "0x1869DCB20")]
		public bool NOHMEEBAOGE(DOIEIJBALKG NAJEDEDCOGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x69DCB10", Offset = "0x69DBF10", VA = "0x1869DCB10")]
		public bool KAABNEFCCIO(DOIEIJBALKG NAJEDEDCOGC, ECNGAACDJHM PENKPMDBFBH)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly ECNGAACDJHM AODKPMLDJMC;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x21B2C90", Offset = "0x21B2090", VA = "0x1821B2C90")]
	public DOIEIJBALKG(ECNGAACDJHM AODKPMLDJMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x69DC7E0", Offset = "0x69DBBE0", VA = "0x1869DC7E0")]
	public DOIEIJBALKG OFPHNNEFFKJ(ECNGAACDJHM HAFGPGNHIFH)
	{
		return default(DOIEIJBALKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x69DC7D0", Offset = "0x69DBBD0", VA = "0x1869DC7D0")]
	public DOIEIJBALKG GMMEGEIJENL(ECNGAACDJHM PMECOJCCFCG)
	{
		return default(DOIEIJBALKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x69DC7F0", Offset = "0x69DBBF0", VA = "0x1869DC7F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[Flags]
public enum ECNGAACDJHM : byte
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
public enum OICOKEEADFC : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[OHGODCPNOIO]
public struct EAPDJPELIAH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public OICOKEEADFC AODKPMLDJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public bool CMKNIKJMLPJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool CEHJFHKMDEH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x69DC870", Offset = "0x69DBC70", VA = "0x1869DC870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x69DC8A0", Offset = "0x69DBCA0", VA = "0x1869DC8A0")]
	private EAPDJPELIAH(OICOKEEADFC AODKPMLDJMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x69DC880", Offset = "0x69DBC80", VA = "0x1869DC880")]
	public EAPDJPELIAH OFPHNNEFFKJ(OICOKEEADFC HAFGPGNHIFH)
	{
		return default(EAPDJPELIAH);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x69DC850", Offset = "0x69DBC50", VA = "0x1869DC850")]
	public EAPDJPELIAH GMMEGEIJENL(OICOKEEADFC PMECOJCCFCG)
	{
		return default(EAPDJPELIAH);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct ECKOFCPADCJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct OJHAFMIJHIM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Entity NPLFDJGOHCJ;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildBuffer>, MJOBODLPDGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x99D3A0", Offset = "0x99C7A0", VA = "0x18099D3A0", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xF01850", Offset = "0xF00C50", VA = "0x180F01850", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xF01850", Offset = "0xF00C50", VA = "0x180F01850")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x69DBDB0", Offset = "0x69DB1B0", VA = "0x1869DBDB0", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x97B1B0", Offset = "0x97A5B0", VA = "0x18097B1B0")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[OHGODCPNOIO]
public struct OPHOCKBPJBM : ISystemStateBufferElementData, IBufferElementData, MJOBODLPDGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public Entity KHAAFKNHHNL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Entity NAKLFKJFBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x99D3A0", Offset = "0x99C7A0", VA = "0x18099D3A0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xF01850", Offset = "0xF00C50", VA = "0x180F01850", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct NPMIHDBAEIL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Entity NEOAHNJAPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Entity GBJMPAAJGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity OLOPBPLPKMF;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct EPDBLHJFIHN<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly bool MDFNJNDPCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public uint OHLKINIEHLA;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool JKEAMDMBHCC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.TypeVersion(2)]
public struct KNEFPEDCHBJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public uint NBNNFDJBJHH;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x69DD610", Offset = "0x69DCA10", VA = "0x1869DD610", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct GKEBEPJAPPK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[OHGODCPNOIO]
public struct AKMBFODFMJL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public int JEKAMFANBBL;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct HEGNEJLDGJN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int CAMLEFJDICE;
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct AJDHBKDMIJN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public GCHandle AONCCCGMJDI;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct JJFCALNBLBK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public int CAMLEFJDICE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct PGDGCKDKJIA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct PIEHIAECGLJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public int CAMLEFJDICE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct ALNINBPHGAG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct ILLDMAGPBAA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct KOIPINDBHGM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct MICKDCAJFGK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public CollisionDetectionMode GIODENNLDLI;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[GOGPFJLEJIG]
public struct JPGIDFBMMEJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public DHNIPGENADJ BMAGHCGMMLB;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly JPGIDFBMMEJ ONJGBPHIMMM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct GKBPNIAHGMG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct GHHDKDAFBKC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct NOCNOANHAMH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[InternalBufferCapacity(0)]
public struct HBGFLEOMOMB : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Entity LGDEAAPGGHL;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct NGNAGJGGJKJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Entity KOBAADDGPBN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct JJCNDGIOEJM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct IGILHEKGPND : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Entity MILPLABKJCF;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct BKIBINNNALB : FENJKIKIKGD, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public HJLGAPHHBPO BCOFABEOFDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x99D3A0", Offset = "0x99C7A0", VA = "0x18099D3A0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(HJLGAPHHBPO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xF01850", Offset = "0xF00C50", VA = "0x180F01850", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct CDMNLKKLAID : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float3 GKHBMGGLAPL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct LLDAPEGFGNB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[GOGPFJLEJIG]
public struct HEIHOFEOPBJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public float3x3 MGJBBOCIDIM;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly HEIHOFEOPBJ ONJGBPHIMMM;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[GOGPFJLEJIG]
public struct MKEGGBIFKKC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public float3x3 MGJBBOCIDIM;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly MKEGGBIFKKC ONJGBPHIMMM;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct BONMDILNMGM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public float3 CDDLMEIGBHC;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct LHDHMLANPNG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public float3 PMMOPHHKMCE;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[GOGPFJLEJIG]
public struct PJMJNAANOEJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float KELDFMPGLAM;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly PJMJNAANOEJ ONJGBPHIMMM;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[GOGPFJLEJIG]
public struct DMMBHKAHMIL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public float DNIBKKDLNNG;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly DMMBHKAHMIL ONJGBPHIMMM;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct NJNFGCKIEFB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public float3 FAHDLLIHNCI;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct GDGHMAHOIHF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public DJAFCNJDKGP HIGJKJJEENF;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct MKCFFIALLFL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public DJAFCNJDKGP AFEMKMDJBKJ;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[OHGODCPNOIO]
public struct IDPIIFCLBAP : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Entity KHAAFKNHHNL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct LOGIPIFPEOF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct DEHDFPIEKPG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct NJLNLFCOMNG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public RigidbodyConstraints HNHIGMJKFJI;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[GOGPFJLEJIG]
public struct BKMMAHBCLGN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public float CMIDBFEELBA;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly BKMMAHBCLGN ONJGBPHIMMM;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct OBEKAEOCKIO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float CKOKLCCANIH;
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class BLHEJHJKHEC : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct BCKCCAHEBIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public object DCLGFIMBBJJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public GameObject GODEJCKEDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public object PIMMFKOLJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public object DDOJIJNMDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public BCKCCAHEBIO DCLGFIMBBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public Delegate ONPDKBDPANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Delegate CHDKOGKGFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NBHKPCBJCGB<Delegate> LMNPJGPIKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public NBHKPCBJCGB<Delegate> PANNFLPMFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public NBHKPCBJCGB<Delegate> COFDPNBPKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public NBHKPCBJCGB<Delegate> GBHGJOAJGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public NBHKPCBJCGB<Delegate> KPIPIPELBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public NBHKPCBJCGB<Delegate> KNLGIKAPIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public NBHKPCBJCGB<Delegate> KGBIBNMCGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public NBHKPCBJCGB<Delegate> JPOBNCBNAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public NBHKPCBJCGB<Delegate> KJNNMPAEHPL;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x69DC270", Offset = "0x69DB670", VA = "0x1869DC270", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public BLHEJHJKHEC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct BNANMHKJGDM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct HKDMHLEJIBH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int CFIFPOHMEMM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xE66540", Offset = "0xE65940", VA = "0x180E66540")]
	public static HKDMHLEJIBH JHFAHDJBNPM(int OBEEJPGJPFD)
	{
		return default(HKDMHLEJIBH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class GNIABGIFKJI : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public Rigidbody LMOGFGDEOJM;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x69DCCF0", Offset = "0x69DC0F0", VA = "0x1869DCCF0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public GNIABGIFKJI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct EIIDBFDILDG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct AKOIKBCGGNJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 LHKMHBCIMBF;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct MKAMJMEGNII : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float3 CLFPHNHFBOP;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[GOGPFJLEJIG]
public struct FEOEBMMAJCE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float CJHCOONAPDF;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly FEOEBMMAJCE ONJGBPHIMMM;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class IBFKJOMHLEN : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public object LJAIGFPBPKN;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x69DCF50", Offset = "0x69DC350", VA = "0x1869DCF50", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public IBFKJOMHLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class BPJHCIHCPAL : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public object HJEKEKIBIJA;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x69DC3A0", Offset = "0x69DB7A0", VA = "0x1869DC3A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public BPJHCIHCPAL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct JHHIJAIOBJK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct CIIAFIAFMOE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct MAKEIGJEIBA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct GCOMECIFMFB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct HPKPLNCOPKL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct FFGFFAJKKEF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public FixedString32Bytes FIKHOKLHCII;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[OHGODCPNOIO]
public struct DPKGHDEPIAM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Entity GPFPAOCGNND;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x97B1B0", Offset = "0x97A5B0", VA = "0x18097B1B0")]
	public static DPKGHDEPIAM JHFAHDJBNPM(Entity OBEEJPGJPFD)
	{
		return default(DPKGHDEPIAM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal struct BMGCJEHAEKN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Entity KHAAFKNHHNL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x97B1B0", Offset = "0x97A5B0", VA = "0x18097B1B0")]
	public static BMGCJEHAEKN JHFAHDJBNPM(Entity KHAAFKNHHNL)
	{
		return default(BMGCJEHAEKN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct FLJPGGJMAEL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Entity KJIBFCKGECF;
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct NCBKOLKLFFF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Entity KJIBFCKGECF;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal struct DEAJOFPKAKI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Entity CKABONOCHAB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x97B1B0", Offset = "0x97A5B0", VA = "0x18097B1B0")]
	public static DEAJOFPKAKI JHFAHDJBNPM(Entity KHAAFKNHHNL)
	{
		return default(DEAJOFPKAKI);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal struct IDGNFCEGGFO : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct KJLJHDIPGLA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct IDINEBKNPGB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public uint FKMAFNEMDJH;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[OHGODCPNOIO]
internal struct AIEOGGFIMCH : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public Entity KPFMPHAENCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int AGAGKNBDCIG;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal struct NMLAGGHNMEG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public Entity FNMKJCPDDBD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct IOEBAIFEDOM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct KOFINIJEGNO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public uint OHLKINIEHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int DOMKODDKNOI;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xD3FA80", Offset = "0xD3EE80", VA = "0x180D3FA80")]
	public KOFINIJEGNO(uint IKFHDOMHEKD, int ALOINLOHEOL)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct FHGFJLNHNNE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct AOIBDJFCHMG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct LBADMFPIPKB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct EMPCDJGPLJG : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct IFPDMFPHBJG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct MHAEPKAINEI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct HADAKGOKHMJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct KAAGJMKGHIF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal struct KCOOMGJENLK : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct AIFFABMIMPM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct IGGPHPBMCNA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct FPPFKKOMGBM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal struct DHHEGPKKDMN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal struct GOMPAHCMAIP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct PPACIFJLEBO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct KNMPPNFAMOA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct KAHNEJFGNGF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct HNDGBMJHHME : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct NLAJNHFJNOE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct CHJNDBANGOB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct KJLGJLNHGKP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct JBCIHECLPBG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct OKHODEGPKLB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct JHKKOEEIEIG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal struct PGCAPOIMDBP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct BHIGJOMIOJA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct OBNLJGHGIFK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct NPHGAJFOMKD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[OHGODCPNOIO]
public struct AKEKGFFDGKK : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public FixedString32Bytes OCJFKFBFMFI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct MHJAHBGBCMI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct FPBHMGEDNAK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal struct DGJDLMMKCPC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal struct HBEHBBKLEIK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal struct JFGGNFJHNHI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct IIOECGMDMCI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct HKFIGNHGDMJ : IComponentData, IComparable<HKFIGNHGDMJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public int OMHHIJLGFOI;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1B81860", Offset = "0x1B80C60", VA = "0x181B81860", Slot = "4")]
	public int CompareTo(HKFIGNHGDMJ IEDCHGMDIML)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct FODBHIAODKK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct MECJCIIKFGD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public quaternion MGJIDJKDGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float3 HBGADHMDPAD;
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct BJMCCGCGCOA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float EHFMPLLLAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float KBNFMDMPLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float DBKBJDHMBEP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct JGEEIMBHCNC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct GMIHBBOFPCF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct AHMDFIAJJOC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct ABFCHOOBKPC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public int CAMLEFJDICE;
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[OHGODCPNOIO]
public struct MDIDHICOFAK : ISystemStateBufferElementData, IBufferElementData, MJOBODLPDGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Entity HHCALCCKOII;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Entity NAKLFKJFBME
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x99D3A0", Offset = "0x99C7A0", VA = "0x18099D3A0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xF01850", Offset = "0xF00C50", VA = "0x180F01850", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[GOGPFJLEJIG]
public struct IMJCINGNCGE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public float4x4 OKGPEDCJIHN;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public static readonly IMJCINGNCGE ONJGBPHIMMM;
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[GOGPFJLEJIG]
public struct GCGKLCENLLH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public float4x4 AINMCLFGFNI;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public static readonly GCGKLCENLLH ONJGBPHIMMM;
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public struct EMNIHKJBDGB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private int DMLBJFIIMNJ;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int AGAGKNBDCIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x69DCA10", Offset = "0x69DBE10", VA = "0x1869DCA10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x69DCA20", Offset = "0x69DBE20", VA = "0x1869DCA20")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[GOGPFJLEJIG]
public struct OEDJPFDJAPL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public float3 AEOCBCLEPOG;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public static readonly OEDJPFDJAPL ONJGBPHIMMM;
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[GOGPFJLEJIG]
public struct KCOPCDFILBH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float3 HBGADHMDPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public quaternion MGJIDJKDGAB;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public static readonly KCOPCDFILBH ONJGBPHIMMM;
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class PNJCLLFPAGG
{
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[GOGPFJLEJIG]
public struct PECEPECLHGH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float LDCICDFBFCB;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public static readonly PECEPECLHGH ONJGBPHIMMM;
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct MDGBDELDNFD : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Entity BNALJMOIAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public LLNMKDOAMIE NDDOEMMEACD;
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct JEEMMDPHBIA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public LLNMKDOAMIE NDDOEMMEACD;
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct CIPMNCHONCH : ISystemStateComponentData, IComponentData, MJOBODLPDGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Entity FBHCNLEEELM;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity NAKLFKJFBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x99D3A0", Offset = "0x99C7A0", VA = "0x18099D3A0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xF01850", Offset = "0xF00C50", VA = "0x180F01850", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct HJAJGJFNJGK : ISystemStateBufferElementData, IBufferElementData, MJOBODLPDGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity GGCNFGNMBLM;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Entity NAKLFKJFBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x99D3A0", Offset = "0x99C7A0", VA = "0x18099D3A0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xF01850", Offset = "0xF00C50", VA = "0x180F01850", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct PPDOBBGPAAI : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Entity BNALJMOIAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public LLNMKDOAMIE NDDOEMMEACD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct LMKKNGNNBBE : IEqualityComparer<PPDOBBGPAAI>
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public static LMKKNGNNBBE ONJGBPHIMMM;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x69DD8E0", Offset = "0x69DCCE0", VA = "0x1869DD8E0", Slot = "4")]
	public bool Equals(PPDOBBGPAAI PCHHOKEGOFA, PPDOBBGPAAI PDEIPLKJFKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x69DD930", Offset = "0x69DCD30", VA = "0x1869DD930", Slot = "5")]
	public int GetHashCode(PPDOBBGPAAI LALIGKIKEBM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct KNMCKLKKJMA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public FixedList32Bytes<int> DKBIJHGLBLL;
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct LNJHLPCLDGP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public FixedList32Bytes<int> DKBIJHGLBLL;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct GGHLMPBFOEF : ISystemStateBufferElementData, IBufferElementData, MJOBODLPDGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Entity IDDBLPCGJCB;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private Entity DNFKJMMHGJG
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x99D3A0", Offset = "0x99C7A0", VA = "0x18099D3A0", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xF01850", Offset = "0xF00C50", VA = "0x180F01850", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class AOCEKEPLDIM : ContainerPropertyBag<BLHEJHJKHEC>
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	private class EELNCPPHFKA : Property<BLHEJHJKHEC, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string KHPOGHNODCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x69DC9E0", Offset = "0x69DBDE0", VA = "0x1869DC9E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool LMFKAPMEMFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x69DC9A0", Offset = "0x69DBDA0", VA = "0x1869DC9A0")]
		public EELNCPPHFKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x69DC500", Offset = "0x69DB900", VA = "0x1869DC500", Slot = "14")]
		public override GameObject GetValue(BLHEJHJKHEC IFELLLJKHDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x69DC520", Offset = "0x69DB920", VA = "0x1869DC520", Slot = "15")]
		public override void SetValue(BLHEJHJKHEC IFELLLJKHDO, GameObject OBEEJPGJPFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class KBMFALEJFBM : Property<BLHEJHJKHEC, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string KHPOGHNODCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x69DD4B0", Offset = "0x69DC8B0", VA = "0x1869DD4B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool LMFKAPMEMFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x69DD470", Offset = "0x69DC870", VA = "0x1869DD470")]
		public KBMFALEJFBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x69DD420", Offset = "0x69DC820", VA = "0x1869DD420", Slot = "14")]
		public override object GetValue(BLHEJHJKHEC IFELLLJKHDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x69DD440", Offset = "0x69DC840", VA = "0x1869DD440", Slot = "15")]
		public override void SetValue(BLHEJHJKHEC IFELLLJKHDO, object OBEEJPGJPFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class NCMJLEDOJHE : Property<BLHEJHJKHEC, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string KHPOGHNODCD
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x69DDBE0", Offset = "0x69DCFE0", VA = "0x1869DDBE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool LMFKAPMEMFE
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x69DDBA0", Offset = "0x69DCFA0", VA = "0x1869DDBA0")]
		public NCMJLEDOJHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x69DDB50", Offset = "0x69DCF50", VA = "0x1869DDB50", Slot = "14")]
		public override object GetValue(BLHEJHJKHEC IFELLLJKHDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x69DDB70", Offset = "0x69DCF70", VA = "0x1869DDB70", Slot = "15")]
		public override void SetValue(BLHEJHJKHEC IFELLLJKHDO, object OBEEJPGJPFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	private class IBONBNFIMAJ : Property<BLHEJHJKHEC, BLHEJHJKHEC.BCKCCAHEBIO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string KHPOGHNODCD
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x69DD050", Offset = "0x69DC450", VA = "0x1869DD050", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool LMFKAPMEMFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x69DD010", Offset = "0x69DC410", VA = "0x1869DD010")]
		public IBONBNFIMAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x69DCFC0", Offset = "0x69DC3C0", VA = "0x1869DCFC0", Slot = "14")]
		public override BLHEJHJKHEC.BCKCCAHEBIO GetValue(BLHEJHJKHEC IFELLLJKHDO)
		{
			return default(BLHEJHJKHEC.BCKCCAHEBIO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x69DCFE0", Offset = "0x69DC3E0", VA = "0x1869DCFE0", Slot = "15")]
		public override void SetValue(BLHEJHJKHEC IFELLLJKHDO, BLHEJHJKHEC.BCKCCAHEBIO OBEEJPGJPFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private class BGGEJACHCAP : Property<BLHEJHJKHEC, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string KHPOGHNODCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x69DC200", Offset = "0x69DB600", VA = "0x1869DC200", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool LMFKAPMEMFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x69DC1C0", Offset = "0x69DB5C0", VA = "0x1869DC1C0")]
		public BGGEJACHCAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x69DC170", Offset = "0x69DB570", VA = "0x1869DC170", Slot = "14")]
		public override Delegate GetValue(BLHEJHJKHEC IFELLLJKHDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x69DC190", Offset = "0x69DB590", VA = "0x1869DC190", Slot = "15")]
		public override void SetValue(BLHEJHJKHEC IFELLLJKHDO, Delegate OBEEJPGJPFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	private class NAIGCENPAGG : Property<BLHEJHJKHEC, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string KHPOGHNODCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x69DDB20", Offset = "0x69DCF20", VA = "0x1869DDB20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool LMFKAPMEMFE
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x69DDAE0", Offset = "0x69DCEE0", VA = "0x1869DDAE0")]
		public NAIGCENPAGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x69DDA90", Offset = "0x69DCE90", VA = "0x1869DDA90", Slot = "14")]
		public override Delegate GetValue(BLHEJHJKHEC IFELLLJKHDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x69DDAB0", Offset = "0x69DCEB0", VA = "0x1869DDAB0", Slot = "15")]
		public override void SetValue(BLHEJHJKHEC IFELLLJKHDO, Delegate OBEEJPGJPFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private class OGMONFABGDH : Property<BLHEJHJKHEC, NBHKPCBJCGB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string KHPOGHNODCD
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x69DDD40", Offset = "0x69DD140", VA = "0x1869DDD40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool LMFKAPMEMFE
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x69DDD00", Offset = "0x69DD100", VA = "0x1869DDD00")]
		public OGMONFABGDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x69DDC90", Offset = "0x69DD090", VA = "0x1869DDC90", Slot = "14")]
		public override NBHKPCBJCGB<Delegate> GetValue(BLHEJHJKHEC IFELLLJKHDO)
		{
			return default(NBHKPCBJCGB<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x69DDCC0", Offset = "0x69DD0C0", VA = "0x1869DDCC0", Slot = "15")]
		public override void SetValue(BLHEJHJKHEC IFELLLJKHDO, NBHKPCBJCGB<Delegate> OBEEJPGJPFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private class AKBDLEOBNDF : Property<BLHEJHJKHEC, NBHKPCBJCGB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string KHPOGHNODCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x69DB630", Offset = "0x69DAA30", VA = "0x1869DB630", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool LMFKAPMEMFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x69DB5F0", Offset = "0x69DA9F0", VA = "0x1869DB5F0")]
		public AKBDLEOBNDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x69DB580", Offset = "0x69DA980", VA = "0x1869DB580", Slot = "14")]
		public override NBHKPCBJCGB<Delegate> GetValue(BLHEJHJKHEC IFELLLJKHDO)
		{
			return default(NBHKPCBJCGB<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x69DB5B0", Offset = "0x69DA9B0", VA = "0x1869DB5B0", Slot = "15")]
		public override void SetValue(BLHEJHJKHEC IFELLLJKHDO, NBHKPCBJCGB<Delegate> OBEEJPGJPFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class BLPAJBLFCNL : Property<BLHEJHJKHEC, NBHKPCBJCGB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string KHPOGHNODCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x69DC370", Offset = "0x69DB770", VA = "0x1869DC370", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool LMFKAPMEMFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x69DC330", Offset = "0x69DB730", VA = "0x1869DC330")]
		public BLPAJBLFCNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x69DC2C0", Offset = "0x69DB6C0", VA = "0x1869DC2C0", Slot = "14")]
		public override NBHKPCBJCGB<Delegate> GetValue(BLHEJHJKHEC IFELLLJKHDO)
		{
			return default(NBHKPCBJCGB<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x69DC2F0", Offset = "0x69DB6F0", VA = "0x1869DC2F0", Slot = "15")]
		public override void SetValue(BLHEJHJKHEC IFELLLJKHDO, NBHKPCBJCGB<Delegate> OBEEJPGJPFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	private class CDMDKDHPFIG : Property<BLHEJHJKHEC, NBHKPCBJCGB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string KHPOGHNODCD
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x69DC4D0", Offset = "0x69DB8D0", VA = "0x1869DC4D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool LMFKAPMEMFE
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x69DC490", Offset = "0x69DB890", VA = "0x1869DC490")]
		public CDMDKDHPFIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x69DC410", Offset = "0x69DB810", VA = "0x1869DC410", Slot = "14")]
		public override NBHKPCBJCGB<Delegate> GetValue(BLHEJHJKHEC IFELLLJKHDO)
		{
			return default(NBHKPCBJCGB<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x69DC450", Offset = "0x69DB850", VA = "0x1869DC450", Slot = "15")]
		public override void SetValue(BLHEJHJKHEC IFELLLJKHDO, NBHKPCBJCGB<Delegate> OBEEJPGJPFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private class EECCDCEJLPG : Property<BLHEJHJKHEC, NBHKPCBJCGB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string KHPOGHNODCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x69DC970", Offset = "0x69DBD70", VA = "0x1869DC970", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool LMFKAPMEMFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x69DC930", Offset = "0x69DBD30", VA = "0x1869DC930")]
		public EECCDCEJLPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x69DC8B0", Offset = "0x69DBCB0", VA = "0x1869DC8B0", Slot = "14")]
		public override NBHKPCBJCGB<Delegate> GetValue(BLHEJHJKHEC IFELLLJKHDO)
		{
			return default(NBHKPCBJCGB<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x69DC8F0", Offset = "0x69DBCF0", VA = "0x1869DC8F0", Slot = "15")]
		public override void SetValue(BLHEJHJKHEC IFELLLJKHDO, NBHKPCBJCGB<Delegate> OBEEJPGJPFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	private class DDAAMCKBBPG : Property<BLHEJHJKHEC, NBHKPCBJCGB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string KHPOGHNODCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x69DC760", Offset = "0x69DBB60", VA = "0x1869DC760", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool LMFKAPMEMFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x69DC720", Offset = "0x69DBB20", VA = "0x1869DC720")]
		public DDAAMCKBBPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x69DC6A0", Offset = "0x69DBAA0", VA = "0x1869DC6A0", Slot = "14")]
		public override NBHKPCBJCGB<Delegate> GetValue(BLHEJHJKHEC IFELLLJKHDO)
		{
			return default(NBHKPCBJCGB<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x69DC6E0", Offset = "0x69DBAE0", VA = "0x1869DC6E0", Slot = "15")]
		public override void SetValue(BLHEJHJKHEC IFELLLJKHDO, NBHKPCBJCGB<Delegate> OBEEJPGJPFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	private class ALNPJJAOBNI : Property<BLHEJHJKHEC, NBHKPCBJCGB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string KHPOGHNODCD
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x69DB720", Offset = "0x69DAB20", VA = "0x1869DB720", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool LMFKAPMEMFE
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x69DB6E0", Offset = "0x69DAAE0", VA = "0x1869DB6E0")]
		public ALNPJJAOBNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x69DB660", Offset = "0x69DAA60", VA = "0x1869DB660", Slot = "14")]
		public override NBHKPCBJCGB<Delegate> GetValue(BLHEJHJKHEC IFELLLJKHDO)
		{
			return default(NBHKPCBJCGB<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x69DB6A0", Offset = "0x69DAAA0", VA = "0x1869DB6A0", Slot = "15")]
		public override void SetValue(BLHEJHJKHEC IFELLLJKHDO, NBHKPCBJCGB<Delegate> OBEEJPGJPFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class HAFIDBNBBDH : Property<BLHEJHJKHEC, NBHKPCBJCGB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string KHPOGHNODCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x69DCE20", Offset = "0x69DC220", VA = "0x1869DCE20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool LMFKAPMEMFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x69DCDE0", Offset = "0x69DC1E0", VA = "0x1869DCDE0")]
		public HAFIDBNBBDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x69DCD60", Offset = "0x69DC160", VA = "0x1869DCD60", Slot = "14")]
		public override NBHKPCBJCGB<Delegate> GetValue(BLHEJHJKHEC IFELLLJKHDO)
		{
			return default(NBHKPCBJCGB<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x69DCDA0", Offset = "0x69DC1A0", VA = "0x1869DCDA0", Slot = "15")]
		public override void SetValue(BLHEJHJKHEC IFELLLJKHDO, NBHKPCBJCGB<Delegate> OBEEJPGJPFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	private class KPOAKMJOCLA : Property<BLHEJHJKHEC, NBHKPCBJCGB<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string KHPOGHNODCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x69DD760", Offset = "0x69DCB60", VA = "0x1869DD760", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool LMFKAPMEMFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x69DD720", Offset = "0x69DCB20", VA = "0x1869DD720")]
		public KPOAKMJOCLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x69DD6A0", Offset = "0x69DCAA0", VA = "0x1869DD6A0", Slot = "14")]
		public override NBHKPCBJCGB<Delegate> GetValue(BLHEJHJKHEC IFELLLJKHDO)
		{
			return default(NBHKPCBJCGB<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x69DD6E0", Offset = "0x69DCAE0", VA = "0x1869DD6E0", Slot = "15")]
		public override void SetValue(BLHEJHJKHEC IFELLLJKHDO, NBHKPCBJCGB<Delegate> OBEEJPGJPFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x69DB750", Offset = "0x69DAB50", VA = "0x1869DB750")]
	public AOCEKEPLDIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal class BGCIMKICDCH : ContainerPropertyBag<BLHEJHJKHEC.BCKCCAHEBIO>
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private class IENEOAEDEJI : Property<BLHEJHJKHEC.BCKCCAHEBIO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string KHPOGHNODCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x69DD0C0", Offset = "0x69DC4C0", VA = "0x1869DD0C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool LMFKAPMEMFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x69DD080", Offset = "0x69DC480", VA = "0x1869DD080")]
		public IENEOAEDEJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xB011C0", Offset = "0xB005C0", VA = "0x180B011C0", Slot = "14")]
		public override object GetValue(BLHEJHJKHEC.BCKCCAHEBIO IFELLLJKHDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x481C8E0", Offset = "0x481BCE0", VA = "0x18481C8E0", Slot = "15")]
		public override void SetValue(BLHEJHJKHEC.BCKCCAHEBIO IFELLLJKHDO, object OBEEJPGJPFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x69DC090", Offset = "0x69DB490", VA = "0x1869DC090")]
	public BGCIMKICDCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class GFHCCIALACL : ContainerPropertyBag<NBHKPCBJCGB<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x69DCC90", Offset = "0x69DC090", VA = "0x1869DCC90")]
	public GFHCCIALACL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal class ENGEEFDLHBD : ContainerPropertyBag<GNIABGIFKJI>
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class LKLMCPJCEHE : Property<GNIABGIFKJI, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string KHPOGHNODCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x69DD8B0", Offset = "0x69DCCB0", VA = "0x1869DD8B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool LMFKAPMEMFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x69DD870", Offset = "0x69DCC70", VA = "0x1869DD870")]
		public LKLMCPJCEHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x69DC500", Offset = "0x69DB900", VA = "0x1869DC500", Slot = "14")]
		public override Rigidbody GetValue(GNIABGIFKJI IFELLLJKHDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x69DC520", Offset = "0x69DB920", VA = "0x1869DC520", Slot = "15")]
		public override void SetValue(GNIABGIFKJI IFELLLJKHDO, Rigidbody OBEEJPGJPFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x69DCA30", Offset = "0x69DBE30", VA = "0x1869DCA30")]
	public ENGEEFDLHBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class DAIDOJOKBND : ContainerPropertyBag<IBFKJOMHLEN>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class GBKCKEPOJPJ : Property<IBFKJOMHLEN, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string KHPOGHNODCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x69DCBB0", Offset = "0x69DBFB0", VA = "0x1869DCBB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool LMFKAPMEMFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x69DCB70", Offset = "0x69DBF70", VA = "0x1869DCB70")]
		public GBKCKEPOJPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x69DC500", Offset = "0x69DB900", VA = "0x1869DC500", Slot = "14")]
		public override object GetValue(IBFKJOMHLEN IFELLLJKHDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x69DC520", Offset = "0x69DB920", VA = "0x1869DC520", Slot = "15")]
		public override void SetValue(IBFKJOMHLEN IFELLLJKHDO, object OBEEJPGJPFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x69DC5C0", Offset = "0x69DB9C0", VA = "0x1869DC5C0")]
	public DAIDOJOKBND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal class LBHCLKHHMDG : ContainerPropertyBag<BPJHCIHCPAL>
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private class CHDOINNLDDI : Property<BPJHCIHCPAL, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string KHPOGHNODCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x69DC590", Offset = "0x69DB990", VA = "0x1869DC590", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool LMFKAPMEMFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x69DC550", Offset = "0x69DB950", VA = "0x1869DC550")]
		public CHDOINNLDDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x69DC500", Offset = "0x69DB900", VA = "0x1869DC500", Slot = "14")]
		public override object GetValue(BPJHCIHCPAL IFELLLJKHDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x69DC520", Offset = "0x69DB920", VA = "0x1869DC520", Slot = "15")]
		public override void SetValue(BPJHCIHCPAL IFELLLJKHDO, object OBEEJPGJPFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x69DD790", Offset = "0x69DCB90", VA = "0x1869DD790")]
	public LBHCLKHHMDG()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x69DDE40", Offset = "0x69DD240", VA = "0x1869DDE40")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class FKGLLJJNECC
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public FKGLLJJNECC()
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
