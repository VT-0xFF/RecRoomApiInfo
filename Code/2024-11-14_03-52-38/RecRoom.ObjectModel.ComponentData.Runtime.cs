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
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
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
	public class _AssemblyIndex : KNLEODIDJOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6E59630", Offset = "0x6E58A30", VA = "0x186E59630", Slot = "9")]
		public override void GJOPPFNMCBO(OCLKFHKIKLK registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6E591D0", Offset = "0x6E585D0", VA = "0x186E591D0", Slot = "7")]
		public override void AFCMNJELLNP(GFPLBLFDLJF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x63F5FE0", Offset = "0x63F53E0", VA = "0x1863F5FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct JPDCEIDJPIM : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildBuffer>, FEJGLAAIMGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x948270", Offset = "0x947670", VA = "0x180948270", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x11616E0", Offset = "0x1160AE0", VA = "0x1811616E0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6E565B0", Offset = "0x6E559B0", VA = "0x186E565B0", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x11616E0", Offset = "0x1160AE0", VA = "0x1811616E0")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9F9470", Offset = "0x9F8870", VA = "0x1809F9470")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, FEJGLAAIMGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x948270", Offset = "0x947670", VA = "0x180948270", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x11616E0", Offset = "0x1160AE0", VA = "0x1811616E0", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct LHGCLFDKENN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct NHMPFEHLJPD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity IIOCIFDOEOL;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct DPEHCHBMEKP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Entity IIOCIFDOEOL;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct KOKLDOKJPKH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<HIBKAKEKCCO> ABLCDCDBFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<Entity> KJKBEACNBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JobHandle NCIJHBALCJA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DINKENCDIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6E57C90", Offset = "0x6E57090", VA = "0x186E57C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int AHBPDFJLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6E57BE0", Offset = "0x6E56FE0", VA = "0x186E57BE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x505E220", Offset = "0x505D620", VA = "0x18505E220")]
	public KOKLDOKJPKH(NativeList<HIBKAKEKCCO> ABLCDCDBFDA, NativeList<Entity> KJKBEACNBDJ, JobHandle NCIJHBALCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6E57D00", Offset = "0x6E57100", VA = "0x186E57D00")]
	public (Entity, NativeSlice<Entity>) NHNKNNFJIEN(int CLDPBDGHEDO)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6E57C30", Offset = "0x6E57030", VA = "0x186E57C30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct HIBKAKEKCCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Entity DADDPLMNJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int HHOJFKLGPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public int LGPCCHEOHGO;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LLGJLBCIDFG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NOABPMJGFHG(bool KODCBJDJHNC);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct DOKJLAMLLEJ : IEquatable<DOKJLAMLLEJ>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate bool IMAFPOEJNEG(int NPNBEFCNIIF);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool GLGCOEJCECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool BLBGNLLJDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool MKKDBBFAAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool INCFEFNMMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly IMAFPOEJNEG AOKFKCOKHBO;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6E56E60", Offset = "0x6E56260", VA = "0x186E56E60")]
	public DOKJLAMLLEJ(NOIFHPCOMKO JADACNGBBCI, IMAFPOEJNEG AOKFKCOKHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6E56E30", Offset = "0x6E56230", VA = "0x186E56E30")]
	public DOKJLAMLLEJ(bool GLGCOEJCECN, bool BLBGNLLJDBN, bool MKKDBBFAAMM, bool INCFEFNMMJF, IMAFPOEJNEG AOKFKCOKHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6E56E00", Offset = "0x6E56200", VA = "0x186E56E00")]
	public bool PEIHIDMFABP(int NPNBEFCNIIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6E56DD0", Offset = "0x6E561D0", VA = "0x186E56DD0")]
	public bool ONNIJONFPDD(int NPNBEFCNIIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6E56D80", Offset = "0x6E56180", VA = "0x186E56D80")]
	public bool IMNANKBECLP(int NPNBEFCNIIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6E56CB0", Offset = "0x6E560B0", VA = "0x186E56CB0")]
	public bool FDNLLBHHBGH(int NPNBEFCNIIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6E56BD0", Offset = "0x6E55FD0", VA = "0x186E56BD0", Slot = "4")]
	public bool Equals(DOKJLAMLLEJ OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6E56C00", Offset = "0x6E56000", VA = "0x186E56C00", Slot = "0")]
	public override bool Equals(object FAKGLFFOLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6E56CE0", Offset = "0x6E560E0", VA = "0x186E56CE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6E56DB0", Offset = "0x6E561B0", VA = "0x186E56DB0")]
	private bool OEHLIOKJPIP(int NPNBEFCNIIF)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct MDNJLLNNFMH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct HKEBFLHNNKG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct BMMMOMALNOD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[InternalBufferCapacity(17)]
public struct IPKLDDGBAFA : IBufferElementData, IEquatable<IPKLDDGBAFA>, FEJGLAAIMGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity KFLLLPCKFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public int MDAPOFMAJJP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private Entity NKLEFIAIGMG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x948270", Offset = "0x947670", VA = "0x180948270", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x11616E0", Offset = "0x1160AE0", VA = "0x1811616E0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6E57860", Offset = "0x6E56C60", VA = "0x186E57860", Slot = "4")]
	public bool Equals(IPKLDDGBAFA OGKFFDCECEL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct EODAPEPKJBO : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct OFKAEOCKFAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly CAMAOOBMIJB NGNDHMJDKFA;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2431B30", Offset = "0x2430F30", VA = "0x182431B30")]
		public OFKAEOCKFAK(CAMAOOBMIJB LOOBNHKJLLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6E58A70", Offset = "0x6E57E70", VA = "0x186E58A70")]
		public bool HBOKMGKPALN(EODAPEPKJBO NJAPDILGBAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6E58A60", Offset = "0x6E57E60", VA = "0x186E58A60")]
		public bool GHCHPNEBJEL(EODAPEPKJBO NJAPDILGBAD, CAMAOOBMIJB EJGPOBNICIB)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly CAMAOOBMIJB ONOEGHNEDOH;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2431B30", Offset = "0x2430F30", VA = "0x182431B30")]
	public EODAPEPKJBO(CAMAOOBMIJB ONOEGHNEDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6E56FE0", Offset = "0x6E563E0", VA = "0x186E56FE0")]
	public EODAPEPKJBO DHIJGOLDGBP(CAMAOOBMIJB OICPOLDDGPH)
	{
		return default(EODAPEPKJBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6E56FF0", Offset = "0x6E563F0", VA = "0x186E56FF0")]
	public EODAPEPKJBO MLMDLGDLJBH(CAMAOOBMIJB BDAJOBABDMB)
	{
		return default(EODAPEPKJBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6E57000", Offset = "0x6E56400", VA = "0x186E57000", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[Flags]
public enum CAMAOOBMIJB : byte
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
public enum AFGCJNKMIBB : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[EKGFDPHPDGH]
public struct DMKFJPJOAPK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public AFGCJNKMIBB ONOEGHNEDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public bool KNCCFGAGFEA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool FFAAJGNBHDE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6E56B70", Offset = "0x6E55F70", VA = "0x186E56B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6E56BC0", Offset = "0x6E55FC0", VA = "0x186E56BC0")]
	private DMKFJPJOAPK(AFGCJNKMIBB ONOEGHNEDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6E56B80", Offset = "0x6E55F80", VA = "0x186E56B80")]
	public DMKFJPJOAPK DHIJGOLDGBP(AFGCJNKMIBB OICPOLDDGPH)
	{
		return default(DMKFJPJOAPK);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6E56BA0", Offset = "0x6E55FA0", VA = "0x186E56BA0")]
	public DMKFJPJOAPK MLMDLGDLJBH(AFGCJNKMIBB BDAJOBABDMB)
	{
		return default(DMKFJPJOAPK);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct EIJDMPKAGMC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct BAIMOBCDHLM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Entity MIKMNPHPFJG;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildBuffer>, FEJGLAAIMGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x948270", Offset = "0x947670", VA = "0x180948270", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x11616E0", Offset = "0x1160AE0", VA = "0x1811616E0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x11616E0", Offset = "0x1160AE0", VA = "0x1811616E0")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6E565B0", Offset = "0x6E559B0", VA = "0x186E565B0", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9F9470", Offset = "0x9F8870", VA = "0x1809F9470")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[EKGFDPHPDGH]
public struct NKDDAOEGAMJ : ISystemStateBufferElementData, IBufferElementData, FEJGLAAIMGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public Entity FEMCIAKBEIF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Entity GBMFBGIBJLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x948270", Offset = "0x947670", VA = "0x180948270", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x11616E0", Offset = "0x1160AE0", VA = "0x1811616E0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct MEKPPIODJEG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Entity GIKPADHJEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity GFBHECAAEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Entity ANMEINPIOBI;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct HANCEHHMCIA<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly bool KIGAEJLFEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public uint GCLLJDPKDKM;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool LODLJIGNDMD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[TypeManager.TypeVersion(2)]
public struct CMEJMBOFEHB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public uint IIKDBKOAGBM;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6E569A0", Offset = "0x6E55DA0", VA = "0x186E569A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct FEKBBBBLFKK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[EKGFDPHPDGH]
public struct EBDFBDAMAGI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int CMBKPDDNBFD;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct NJBMAEJMNLI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public int AOBEINLDKMC;
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct CGNCNJOJOIP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public GCHandle PAHEBJFODDB;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct OFNIJOLMDAK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public int AOBEINLDKMC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct BEOHMEPJPAF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct FMDHLCOJKPN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public int AOBEINLDKMC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct DGMNHMGLLMP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct CCEBDGJGCFE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct LBJGJGJPPDN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct KMFDJBPAPOC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public CollisionDetectionMode MCFHJDIMBGN;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[AAOHLEIBBPD]
public struct JCGEHDHEFMC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public IHJDLPBPHOK HKHFKPLLMEL;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static readonly JCGEHDHEFMC JDAIBLFKEOP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct OHJEMDBBIFO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct LDCOKIPPJLC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct ABFEEBALKCF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[InternalBufferCapacity(0)]
public struct DIBACODMPCJ : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Entity KFLLLPCKFFO;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct HFFKNEMGNBM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Entity EGIKLIBGODG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct NLCBLJLGIJC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct LBGLBMJCCNA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Entity DADDPLMNJHB;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct EBGNHLJBMHC : KNIPNMIAPFI, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public FHHOGCBMPHG NGNLAGNHLDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x948270", Offset = "0x947670", VA = "0x180948270", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(FHHOGCBMPHG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x11616E0", Offset = "0x1160AE0", VA = "0x1811616E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct DGHFHHDBFIB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public float3 PHEILDBONCC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct BDDGGGEEGHF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[AAOHLEIBBPD]
public struct NMDDPPLKNHA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public float3x3 ECGNFJABGOC;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly NMDDPPLKNHA JDAIBLFKEOP;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[AAOHLEIBBPD]
public struct MOKCAJFBFOP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public float3x3 ECGNFJABGOC;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly MOKCAJFBFOP JDAIBLFKEOP;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct EJNEIHMEKNO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public float3 IMGMIFGNEHL;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct CKFGMLAKEOO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float3 MBMCIOPNKAB;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[AAOHLEIBBPD]
public struct NFAHMGBOKKE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public float PIKBKGEJPON;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly NFAHMGBOKKE JDAIBLFKEOP;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[AAOHLEIBBPD]
public struct NBIMBEICOGO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public float MIEENKIDIJI;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly NBIMBEICOGO JDAIBLFKEOP;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct IGCPFIIIJDL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public float3 DBIOMFPAKHF;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct BCNBCAHGEPO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public LBCHOGGNAFE LDKKHBHCIHC;
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct LAKCHBPGLHN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public LBCHOGGNAFE IIHLMLDMNPG;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[EKGFDPHPDGH]
public struct MLFBAEDLEPM : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Entity FEMCIAKBEIF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct JPPDLFHIKDE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct NKNOGOCNOJF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct EEGNLCHPDBD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public RigidbodyConstraints ABJLOMHPHIB;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[AAOHLEIBBPD]
public struct NEFGHLIFDBF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float LCLJDBKEPEG;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly NEFGHLIFDBF JDAIBLFKEOP;
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct AFBACOHPJOG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float HHFMDKJOKDB;
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class DFILCEKDIGB : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct JJFHJJADKFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public object LJCJINKPICJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public GameObject NEMCGAENDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public object BPJONAJCLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public object GDAOFKMLKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public JJFHJJADKFP LJCJINKPICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Delegate FJBCIPPCEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public Delegate IMLPLOJJNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public IBCMFGIIKMI<Delegate> BILGOEEEMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public IBCMFGIIKMI<Delegate> JFLOCHEKEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public IBCMFGIIKMI<Delegate> JGEFMOBJGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public IBCMFGIIKMI<Delegate> OFMOHJJMOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public IBCMFGIIKMI<Delegate> HCJKCLLOKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public IBCMFGIIKMI<Delegate> HNOHOAHGGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public IBCMFGIIKMI<Delegate> EAIACEHOCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public IBCMFGIIKMI<Delegate> KHHJBHMAKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public IBCMFGIIKMI<Delegate> HODNMNOOAJH;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6E56B20", Offset = "0x6E55F20", VA = "0x186E56B20", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public DFILCEKDIGB()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct JFOEJGJCJMC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct LADEABAMJDB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int HAANOAEMKFC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x17111F0", Offset = "0x17105F0", VA = "0x1817111F0")]
	public static LADEABAMJDB NMFIIIJGOAJ(int PFKKDHPJFEH)
	{
		return default(LADEABAMJDB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class PBLDHGAAIKJ : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Rigidbody GGEKFKJPDOC;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6E58C40", Offset = "0x6E58040", VA = "0x186E58C40", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public PBLDHGAAIKJ()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct IGMHDNCGEOD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct IDLLJLDLDGE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float3 EACBDNMKAIL;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct FIBEICDIMAG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float3 IKJAACJPELI;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[AAOHLEIBBPD]
public struct PHJAACLNLCJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float JHJMHMDFKFN;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly PHJAACLNLCJ JDAIBLFKEOP;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class IHKBGOCKFDF : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public object KJFCOCLEACN;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6E577F0", Offset = "0x6E56BF0", VA = "0x186E577F0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public IHKBGOCKFDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class GKHLDKAOMAP : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public object PPBBGGFMAEE;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6E57460", Offset = "0x6E56860", VA = "0x186E57460", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public GKHLDKAOMAP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct HMMGCPNFNAA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct EAOHEFKGELD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct JBKACIAHKBC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct JOJHDEBCEMM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000054")]
public struct JCGLILGHAGK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct HAINJDIPJIH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public FixedString32Bytes ACDGEPBIBHJ;
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[EKGFDPHPDGH]
public struct MAIFJBGPMNL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Entity JFMDCCFECCK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x9F9470", Offset = "0x9F8870", VA = "0x1809F9470")]
	public static MAIFJBGPMNL NMFIIIJGOAJ(Entity PFKKDHPJFEH)
	{
		return default(MAIFJBGPMNL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal struct NFILIADJIHK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Entity FEMCIAKBEIF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x9F9470", Offset = "0x9F8870", VA = "0x1809F9470")]
	public static NFILIADJIHK NMFIIIJGOAJ(Entity FEMCIAKBEIF)
	{
		return default(NFILIADJIHK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct ADIGLCBCIPM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Entity GBNGKBCGKDF;
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct CNJLFPEJPMA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Entity GBNGKBCGKDF;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal struct ONNFPAOGAEJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Entity IDJPDKBCGID;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x9F9470", Offset = "0x9F8870", VA = "0x1809F9470")]
	public static ONNFPAOGAEJ NMFIIIJGOAJ(Entity FEMCIAKBEIF)
	{
		return default(ONNFPAOGAEJ);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal struct JIBKBBNDBKH : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct EMPPMFCOFGF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct LCINOFJJOCG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public uint FCPMNBOKKMJ;
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[EKGFDPHPDGH]
internal struct DAOAHKLJCME : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Entity JAEHDIBBHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int OBFJPFHENMC;
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal struct MCLHIGENFPE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Entity BDPDIDJOBGL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct DABGAGGPOBI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct EBAFFOHPNHC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public uint GCLLJDPKDKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public int BEJPLFFPELB;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0xA89130", Offset = "0xA88530", VA = "0x180A89130")]
	public EBAFFOHPNHC(uint AJLCKIAIBOI, int NMJOCJJOAMG)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct OBPIDGPPOKM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct BJDDGHMPOFA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct PIBOPFCPKGE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct APNLOOLKNMI : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct GDHOGOFIACH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct HFEBJOJEILI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct ONGKKFMDNKD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct LDDAFALBLNK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal struct OBKHNHMJMHG : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct AAENKGGKKLN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct GKGBOOKMMBJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct HBOPKGIOCHP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal struct LJOLBBEPFAM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal struct LDJOLAANMOC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct MDJJEKIJNOI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct BOOCLOPHFGC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct INACNHOGOGO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct JFBDNFGOOCO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct EMADJFIGOKK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct FHPODIICMAG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct MFDJLLGFLEG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct DNJDNDEFGIJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct MJDHNNKIMCP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct NKMFOMLOFBB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal struct EKHEEHLFEAL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct OMMOOIOJPJN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct EBNKJKPHMCF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct GNJKOPLCPLB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[EKGFDPHPDGH]
public struct FAMCLJCEAFC : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public FixedString32Bytes CHOCLJFEHKE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct BHDOKNDNDGN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct MOBKACFFBGP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
internal struct ADILFKMJHLC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal struct LNLEFNACOIN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
internal struct FPJAPAENNIO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct LENBPLCIJHJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct FMNOEPPACAD : IComponentData, IComparable<FMNOEPPACAD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public int CDGNBPMEKMN;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1FFE730", Offset = "0x1FFDB30", VA = "0x181FFE730", Slot = "4")]
	public int CompareTo(FMNOEPPACAD OGKFFDCECEL)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct LNFCPPEFLPH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct EHFDHECDDHG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public quaternion GEMHEIIKJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float3 OGKCMCMHLOD;
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct DPPGDCHNOHL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float EHMBFMMCPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float DMLKEHOPDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public float IGMPNNGLNFJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct BBBOIEBMPGC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct MFNOPMKCBBK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct ADKHHJHBLIE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct MEEFHOFPNFG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public int AOBEINLDKMC;
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[EKGFDPHPDGH]
public struct JKELBIFDLJO : ISystemStateBufferElementData, IBufferElementData, FEJGLAAIMGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Entity MMGNDBIPIEK;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Entity GBMFBGIBJLC
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x948270", Offset = "0x947670", VA = "0x180948270", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x11616E0", Offset = "0x1160AE0", VA = "0x1811616E0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[AAOHLEIBBPD]
public struct CGOHPKNKKFC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public float4x4 FLKDPFNPIAO;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly CGOHPKNKKFC JDAIBLFKEOP;
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[AAOHLEIBBPD]
public struct NIPADJMKEJD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public float4x4 OJEAPADKDDG;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly NIPADJMKEJD JDAIBLFKEOP;
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public struct LGANHGIBAKK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private int LNLCNDBFBHB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int OBFJPFHENMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6E58490", Offset = "0x6E57890", VA = "0x186E58490")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6E58480", Offset = "0x6E57880", VA = "0x186E58480")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[AAOHLEIBBPD]
public struct GNNBMPADLKN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public float3 LABIIFBKNCI;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public static readonly GNNBMPADLKN JDAIBLFKEOP;
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[AAOHLEIBBPD]
public struct FPOGPECLLHL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float3 OGKCMCMHLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public quaternion GEMHEIIKJKD;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly FPOGPECLLHL JDAIBLFKEOP;
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class DPINMAOOONJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[AAOHLEIBBPD]
public struct LJGBGFNMDMA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float EDNLCCBAPFO;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly LJGBGFNMDMA JDAIBLFKEOP;
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct LOBPOLIOJAK : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Entity PIHOHCGEHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public GBCNNEPBFII PMKDNKJPJKE;
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct MCKIDMJGINI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public GBCNNEPBFII PMKDNKJPJKE;
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct EKFBKADIEOP : ISystemStateComponentData, IComponentData, FEJGLAAIMGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Entity NNHLGBCKJOM;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity GBMFBGIBJLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x948270", Offset = "0x947670", VA = "0x180948270", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x11616E0", Offset = "0x1160AE0", VA = "0x1811616E0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct AEMNOMMPJNP : ISystemStateBufferElementData, IBufferElementData, FEJGLAAIMGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Entity LJFLCEPDIAO;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Entity GBMFBGIBJLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x948270", Offset = "0x947670", VA = "0x180948270", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x11616E0", Offset = "0x1160AE0", VA = "0x1811616E0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct HHIBLLPHJNM : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Entity PIHOHCGEHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public GBCNNEPBFII PMKDNKJPJKE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct KLPHFPDJLJL : IEqualityComparer<HHIBLLPHJNM>
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static KLPHFPDJLJL JDAIBLFKEOP;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6E57AC0", Offset = "0x6E56EC0", VA = "0x186E57AC0", Slot = "4")]
	public bool Equals(HHIBLLPHJNM KPPEBBOFEKD, HHIBLLPHJNM EJAKPDCBGAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6E57B10", Offset = "0x6E56F10", VA = "0x186E57B10", Slot = "5")]
	public int GetHashCode(HHIBLLPHJNM FAKGLFFOLFI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct GONFMNBLMBA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public FixedList32Bytes<int> BGGIPDHEELK;
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct BGLBPLDJAHD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public FixedList32Bytes<int> BGGIPDHEELK;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct PHLBAOODIEF : ISystemStateBufferElementData, IBufferElementData, FEJGLAAIMGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Entity DCPLELAPFIO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private Entity NKLEFIAIGMG
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x948270", Offset = "0x947670", VA = "0x180948270", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x11616E0", Offset = "0x1160AE0", VA = "0x1811616E0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class LBGADKNBAFI : ContainerPropertyBag<DFILCEKDIGB>
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	private class NGNPPAAGAOM : Property<DFILCEKDIGB, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override string MKBLEONOOOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6E587A0", Offset = "0x6E57BA0", VA = "0x186E587A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool FGFOPPEDKMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6E58760", Offset = "0x6E57B60", VA = "0x186E58760")]
		public NGNPPAAGAOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6E56430", Offset = "0x6E55830", VA = "0x186E56430", Slot = "14")]
		public override GameObject GetValue(DFILCEKDIGB HOCJPKACMFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6E56450", Offset = "0x6E55850", VA = "0x186E56450", Slot = "15")]
		public override void SetValue(DFILCEKDIGB HOCJPKACMFM, GameObject PFKKDHPJFEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class FIHMFCDNACK : Property<DFILCEKDIGB, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string MKBLEONOOOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6E571D0", Offset = "0x6E565D0", VA = "0x186E571D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool FGFOPPEDKMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6E57190", Offset = "0x6E56590", VA = "0x186E57190")]
		public FIHMFCDNACK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6E57140", Offset = "0x6E56540", VA = "0x186E57140", Slot = "14")]
		public override object GetValue(DFILCEKDIGB HOCJPKACMFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6E57160", Offset = "0x6E56560", VA = "0x186E57160", Slot = "15")]
		public override void SetValue(DFILCEKDIGB HOCJPKACMFM, object PFKKDHPJFEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private class MAOHKOHPNHN : Property<DFILCEKDIGB, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string MKBLEONOOOC
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6E58570", Offset = "0x6E57970", VA = "0x186E58570", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool FGFOPPEDKMD
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6E58530", Offset = "0x6E57930", VA = "0x186E58530")]
		public MAOHKOHPNHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6E584E0", Offset = "0x6E578E0", VA = "0x186E584E0", Slot = "14")]
		public override object GetValue(DFILCEKDIGB HOCJPKACMFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6E58500", Offset = "0x6E57900", VA = "0x186E58500", Slot = "15")]
		public override void SetValue(DFILCEKDIGB HOCJPKACMFM, object PFKKDHPJFEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	private class GEFALBBMOOK : Property<DFILCEKDIGB, DFILCEKDIGB.JJFHJJADKFP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string MKBLEONOOOC
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6E57430", Offset = "0x6E56830", VA = "0x186E57430", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool FGFOPPEDKMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6E573F0", Offset = "0x6E567F0", VA = "0x186E573F0")]
		public GEFALBBMOOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6E573A0", Offset = "0x6E567A0", VA = "0x186E573A0", Slot = "14")]
		public override DFILCEKDIGB.JJFHJJADKFP GetValue(DFILCEKDIGB HOCJPKACMFM)
		{
			return default(DFILCEKDIGB.JJFHJJADKFP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6E573C0", Offset = "0x6E567C0", VA = "0x186E573C0", Slot = "15")]
		public override void SetValue(DFILCEKDIGB HOCJPKACMFM, DFILCEKDIGB.JJFHJJADKFP PFKKDHPJFEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private class AGKBNPMAIPK : Property<DFILCEKDIGB, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string MKBLEONOOOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6E56580", Offset = "0x6E55980", VA = "0x186E56580", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool FGFOPPEDKMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6E56540", Offset = "0x6E55940", VA = "0x186E56540")]
		public AGKBNPMAIPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6E564F0", Offset = "0x6E558F0", VA = "0x186E564F0", Slot = "14")]
		public override Delegate GetValue(DFILCEKDIGB HOCJPKACMFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6E56510", Offset = "0x6E55910", VA = "0x186E56510", Slot = "15")]
		public override void SetValue(DFILCEKDIGB HOCJPKACMFM, Delegate PFKKDHPJFEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	private class HNEGKINCMFO : Property<DFILCEKDIGB, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string MKBLEONOOOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6E577C0", Offset = "0x6E56BC0", VA = "0x186E577C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool FGFOPPEDKMD
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6E57780", Offset = "0x6E56B80", VA = "0x186E57780")]
		public HNEGKINCMFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6E57730", Offset = "0x6E56B30", VA = "0x186E57730", Slot = "14")]
		public override Delegate GetValue(DFILCEKDIGB HOCJPKACMFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6E57750", Offset = "0x6E56B50", VA = "0x186E57750", Slot = "15")]
		public override void SetValue(DFILCEKDIGB HOCJPKACMFM, Delegate PFKKDHPJFEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	private class OCKFNNPKDAH : Property<DFILCEKDIGB, IBCMFGIIKMI<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string MKBLEONOOOC
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6E58A30", Offset = "0x6E57E30", VA = "0x186E58A30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool FGFOPPEDKMD
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6E589F0", Offset = "0x6E57DF0", VA = "0x186E589F0")]
		public OCKFNNPKDAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6E58980", Offset = "0x6E57D80", VA = "0x186E58980", Slot = "14")]
		public override IBCMFGIIKMI<Delegate> GetValue(DFILCEKDIGB HOCJPKACMFM)
		{
			return default(IBCMFGIIKMI<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6E589B0", Offset = "0x6E57DB0", VA = "0x186E589B0", Slot = "15")]
		public override void SetValue(DFILCEKDIGB HOCJPKACMFM, IBCMFGIIKMI<Delegate> PFKKDHPJFEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	private class OPGJLGLOIBM : Property<DFILCEKDIGB, IBCMFGIIKMI<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string MKBLEONOOOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6E58C10", Offset = "0x6E58010", VA = "0x186E58C10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool FGFOPPEDKMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6E58BD0", Offset = "0x6E57FD0", VA = "0x186E58BD0")]
		public OPGJLGLOIBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6E58B60", Offset = "0x6E57F60", VA = "0x186E58B60", Slot = "14")]
		public override IBCMFGIIKMI<Delegate> GetValue(DFILCEKDIGB HOCJPKACMFM)
		{
			return default(IBCMFGIIKMI<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6E58B90", Offset = "0x6E57F90", VA = "0x186E58B90", Slot = "15")]
		public override void SetValue(DFILCEKDIGB HOCJPKACMFM, IBCMFGIIKMI<Delegate> PFKKDHPJFEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private class OIDDBFCBHMN : Property<DFILCEKDIGB, IBCMFGIIKMI<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string MKBLEONOOOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6E58B30", Offset = "0x6E57F30", VA = "0x186E58B30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool FGFOPPEDKMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6E58AF0", Offset = "0x6E57EF0", VA = "0x186E58AF0")]
		public OIDDBFCBHMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6E58A80", Offset = "0x6E57E80", VA = "0x186E58A80", Slot = "14")]
		public override IBCMFGIIKMI<Delegate> GetValue(DFILCEKDIGB HOCJPKACMFM)
		{
			return default(IBCMFGIIKMI<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6E58AB0", Offset = "0x6E57EB0", VA = "0x186E58AB0", Slot = "15")]
		public override void SetValue(DFILCEKDIGB HOCJPKACMFM, IBCMFGIIKMI<Delegate> PFKKDHPJFEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	private class KELABENCPDJ : Property<DFILCEKDIGB, IBCMFGIIKMI<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string MKBLEONOOOC
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6E57A90", Offset = "0x6E56E90", VA = "0x186E57A90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool FGFOPPEDKMD
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6E57A50", Offset = "0x6E56E50", VA = "0x186E57A50")]
		public KELABENCPDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6E579D0", Offset = "0x6E56DD0", VA = "0x186E579D0", Slot = "14")]
		public override IBCMFGIIKMI<Delegate> GetValue(DFILCEKDIGB HOCJPKACMFM)
		{
			return default(IBCMFGIIKMI<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6E57A10", Offset = "0x6E56E10", VA = "0x186E57A10", Slot = "15")]
		public override void SetValue(DFILCEKDIGB HOCJPKACMFM, IBCMFGIIKMI<Delegate> PFKKDHPJFEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	private class BPFLNOBFFNL : Property<DFILCEKDIGB, IBCMFGIIKMI<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string MKBLEONOOOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6E56680", Offset = "0x6E55A80", VA = "0x186E56680", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool FGFOPPEDKMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6E56640", Offset = "0x6E55A40", VA = "0x186E56640")]
		public BPFLNOBFFNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6E565C0", Offset = "0x6E559C0", VA = "0x186E565C0", Slot = "14")]
		public override IBCMFGIIKMI<Delegate> GetValue(DFILCEKDIGB HOCJPKACMFM)
		{
			return default(IBCMFGIIKMI<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6E56600", Offset = "0x6E55A00", VA = "0x186E56600", Slot = "15")]
		public override void SetValue(DFILCEKDIGB HOCJPKACMFM, IBCMFGIIKMI<Delegate> PFKKDHPJFEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	private class HIIKOIDNNDI : Property<DFILCEKDIGB, IBCMFGIIKMI<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string MKBLEONOOOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6E57700", Offset = "0x6E56B00", VA = "0x186E57700", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool FGFOPPEDKMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6E576C0", Offset = "0x6E56AC0", VA = "0x186E576C0")]
		public HIIKOIDNNDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6E57640", Offset = "0x6E56A40", VA = "0x186E57640", Slot = "14")]
		public override IBCMFGIIKMI<Delegate> GetValue(DFILCEKDIGB HOCJPKACMFM)
		{
			return default(IBCMFGIIKMI<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6E57680", Offset = "0x6E56A80", VA = "0x186E57680", Slot = "15")]
		public override void SetValue(DFILCEKDIGB HOCJPKACMFM, IBCMFGIIKMI<Delegate> PFKKDHPJFEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	private class CCKDOHCFMBK : Property<DFILCEKDIGB, IBCMFGIIKMI<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string MKBLEONOOOC
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6E56770", Offset = "0x6E55B70", VA = "0x186E56770", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool FGFOPPEDKMD
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6E56730", Offset = "0x6E55B30", VA = "0x186E56730")]
		public CCKDOHCFMBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6E566B0", Offset = "0x6E55AB0", VA = "0x186E566B0", Slot = "14")]
		public override IBCMFGIIKMI<Delegate> GetValue(DFILCEKDIGB HOCJPKACMFM)
		{
			return default(IBCMFGIIKMI<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6E566F0", Offset = "0x6E55AF0", VA = "0x186E566F0", Slot = "15")]
		public override void SetValue(DFILCEKDIGB HOCJPKACMFM, IBCMFGIIKMI<Delegate> PFKKDHPJFEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private class CNEBCMNHFHD : Property<DFILCEKDIGB, IBCMFGIIKMI<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string MKBLEONOOOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x6E56AF0", Offset = "0x6E55EF0", VA = "0x186E56AF0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool FGFOPPEDKMD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6E56AB0", Offset = "0x6E55EB0", VA = "0x186E56AB0")]
		public CNEBCMNHFHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6E56A30", Offset = "0x6E55E30", VA = "0x186E56A30", Slot = "14")]
		public override IBCMFGIIKMI<Delegate> GetValue(DFILCEKDIGB HOCJPKACMFM)
		{
			return default(IBCMFGIIKMI<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6E56A70", Offset = "0x6E55E70", VA = "0x186E56A70", Slot = "15")]
		public override void SetValue(DFILCEKDIGB HOCJPKACMFM, IBCMFGIIKMI<Delegate> PFKKDHPJFEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	private class GNBAOEBKNGH : Property<DFILCEKDIGB, IBCMFGIIKMI<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string MKBLEONOOOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6E57590", Offset = "0x6E56990", VA = "0x186E57590", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool FGFOPPEDKMD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6E57550", Offset = "0x6E56950", VA = "0x186E57550")]
		public GNBAOEBKNGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6E574D0", Offset = "0x6E568D0", VA = "0x186E574D0", Slot = "14")]
		public override IBCMFGIIKMI<Delegate> GetValue(DFILCEKDIGB HOCJPKACMFM)
		{
			return default(IBCMFGIIKMI<Delegate>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6E57510", Offset = "0x6E56910", VA = "0x186E57510", Slot = "15")]
		public override void SetValue(DFILCEKDIGB HOCJPKACMFM, IBCMFGIIKMI<Delegate> PFKKDHPJFEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6E57E20", Offset = "0x6E57220", VA = "0x186E57E20")]
	public LBGADKNBAFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
internal class FBKCPPKHEIE : ContainerPropertyBag<DFILCEKDIGB.JJFHJJADKFP>
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private class FNHPPODNPIO : Property<DFILCEKDIGB.JJFHJJADKFP, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string MKBLEONOOOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6E57240", Offset = "0x6E56640", VA = "0x186E57240", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool FGFOPPEDKMD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6E57200", Offset = "0x6E56600", VA = "0x186E57200")]
		public FNHPPODNPIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA0A120", Offset = "0xA09520", VA = "0x180A0A120", Slot = "14")]
		public override object GetValue(DFILCEKDIGB.JJFHJJADKFP HOCJPKACMFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x4B7E2B0", Offset = "0x4B7D6B0", VA = "0x184B7E2B0", Slot = "15")]
		public override void SetValue(DFILCEKDIGB.JJFHJJADKFP HOCJPKACMFM, object PFKKDHPJFEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6E57060", Offset = "0x6E56460", VA = "0x186E57060")]
	public FBKCPPKHEIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
internal class EDENICNIEFC : ContainerPropertyBag<IBCMFGIIKMI<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6E56EA0", Offset = "0x6E562A0", VA = "0x186E56EA0")]
	public EDENICNIEFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
internal class EDPLNCEHNFB : ContainerPropertyBag<PBLDHGAAIKJ>
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class KNILHHCPMDJ : Property<PBLDHGAAIKJ, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string MKBLEONOOOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6E57BB0", Offset = "0x6E56FB0", VA = "0x186E57BB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool FGFOPPEDKMD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6E57B70", Offset = "0x6E56F70", VA = "0x186E57B70")]
		public KNILHHCPMDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6E56430", Offset = "0x6E55830", VA = "0x186E56430", Slot = "14")]
		public override Rigidbody GetValue(PBLDHGAAIKJ HOCJPKACMFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6E56450", Offset = "0x6E55850", VA = "0x186E56450", Slot = "15")]
		public override void SetValue(PBLDHGAAIKJ HOCJPKACMFM, Rigidbody PFKKDHPJFEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6E56F00", Offset = "0x6E56300", VA = "0x186E56F00")]
	public EDPLNCEHNFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal class CKOIAJMCBJE : ContainerPropertyBag<IHKBGOCKFDF>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class CDMFNDIIGDB : Property<IHKBGOCKFDF, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string MKBLEONOOOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6E567E0", Offset = "0x6E55BE0", VA = "0x186E567E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool FGFOPPEDKMD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6E567A0", Offset = "0x6E55BA0", VA = "0x186E567A0")]
		public CDMFNDIIGDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6E56430", Offset = "0x6E55830", VA = "0x186E56430", Slot = "14")]
		public override object GetValue(IHKBGOCKFDF HOCJPKACMFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6E56450", Offset = "0x6E55850", VA = "0x186E56450", Slot = "15")]
		public override void SetValue(IHKBGOCKFDF HOCJPKACMFM, object PFKKDHPJFEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6E568C0", Offset = "0x6E55CC0", VA = "0x186E568C0")]
	public CKOIAJMCBJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
internal class JOFIDLABDHH : ContainerPropertyBag<GKHLDKAOMAP>
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private class AFDOOGBLHCD : Property<GKHLDKAOMAP, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string MKBLEONOOOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x6E564C0", Offset = "0x6E558C0", VA = "0x186E564C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool FGFOPPEDKMD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6E56480", Offset = "0x6E55880", VA = "0x186E56480")]
		public AFDOOGBLHCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6E56430", Offset = "0x6E55830", VA = "0x186E56430", Slot = "14")]
		public override object GetValue(GKHLDKAOMAP HOCJPKACMFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6E56450", Offset = "0x6E55850", VA = "0x186E56450", Slot = "15")]
		public override void SetValue(GKHLDKAOMAP HOCJPKACMFM, object PFKKDHPJFEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6E578F0", Offset = "0x6E56CF0", VA = "0x186E578F0")]
	public JOFIDLABDHH()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6E58CF0", Offset = "0x6E580F0", VA = "0x186E58CF0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class DHPHBMGKPAN
{
	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public DHPHBMGKPAN()
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
