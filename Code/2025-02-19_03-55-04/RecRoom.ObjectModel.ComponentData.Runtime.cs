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
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x75FD790", Offset = "0x75FC390", VA = "0x1875FD790", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x75FDB20", Offset = "0x75FC720", VA = "0x1875FDB20", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x240ECE0", Offset = "0x240D8E0", VA = "0x18240ECE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct OPPEBPLBMJJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct DHJGAJFKCBB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct HBOOPDMPEEI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct EABJIGNOGBL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct OOOHIJGFLPI : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : IBufferElementData, IEquatable<AuthoredChildBuffer>, DAGLOENMFJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x75FA560", Offset = "0x75F9160", VA = "0x1875FA560", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct HMMIDAKLHIL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct PIJFBLKACIA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Entity CJCPMEODIGM;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct BFIFGNJPLNN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity CJCPMEODIGM;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct GKHGDFHCCMI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<NMECAGKLNML> OBEFMIPAADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<Entity> BGCOAFFDCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private JobHandle IEMHNEHKIEH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool NHPIKHBJFOH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x75FB210", Offset = "0x75F9E10", VA = "0x1875FB210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int PHJGKILIPGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x75FB160", Offset = "0x75F9D60", VA = "0x1875FB160")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x55FCAD0", Offset = "0x55FB6D0", VA = "0x1855FCAD0")]
	public GKHGDFHCCMI(NativeList<NMECAGKLNML> OBEFMIPAADD, NativeList<Entity> BGCOAFFDCDH, JobHandle IEMHNEHKIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x75FB040", Offset = "0x75F9C40", VA = "0x1875FB040")]
	public (Entity, NativeSlice<Entity>) APGGJAPPLIM(int GFMJIHODIPC)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x75FB1B0", Offset = "0x75F9DB0", VA = "0x1875FB1B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct NMECAGKLNML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Entity EBMDCHEPJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int KKHFKGIPICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int OKLDJMDCMFC;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CKNGAJFJNCH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MCCMHDIOPGA(bool JLMAJLPKCIP);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct HHFACALNCHA : IEquatable<HHFACALNCHA>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate bool OCAENGMMCMB(int BLMGFGJJCEO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly bool KILFGDJFFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool MCIIJECKLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool IEJCAGFPDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool LLBEOPGIKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly OCAENGMMCMB PGEOBBKHNBJ;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x75FB710", Offset = "0x75FA310", VA = "0x1875FB710")]
	public HHFACALNCHA(KOKMBHAEOFP HOHMEIEFKJJ, OCAENGMMCMB PGEOBBKHNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x75FB6E0", Offset = "0x75FA2E0", VA = "0x1875FB6E0")]
	public HHFACALNCHA(bool KILFGDJFFEE, bool MCIIJECKLMH, bool IEJCAGFPDAA, bool LLBEOPGIKJN, OCAENGMMCMB PGEOBBKHNBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x75FB5D0", Offset = "0x75FA1D0", VA = "0x1875FB5D0")]
	public bool KPIHECOKEDF(int BLMGFGJJCEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x75FB5A0", Offset = "0x75FA1A0", VA = "0x1875FB5A0")]
	public bool HNAJNGPKKOL(int BLMGFGJJCEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x75FB600", Offset = "0x75FA200", VA = "0x1875FB600")]
	public bool NNPAGCLNLDP(int BLMGFGJJCEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x75FB4D0", Offset = "0x75FA0D0", VA = "0x1875FB4D0")]
	public bool GDOMJEAEMBC(int BLMGFGJJCEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x75FB4A0", Offset = "0x75FA0A0", VA = "0x1875FB4A0", Slot = "4")]
	public bool Equals(HHFACALNCHA PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x75FB3F0", Offset = "0x75F9FF0", VA = "0x1875FB3F0", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x75FB500", Offset = "0x75FA100", VA = "0x1875FB500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x75FB630", Offset = "0x75FA230", VA = "0x1875FB630")]
	private bool PHIIPGHAFJB(int BLMGFGJJCEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x75FB650", Offset = "0x75FA250", VA = "0x1875FB650", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct BGGHAEKCCPI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct JNFNHJOGBPO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct JBNLPPFDJCJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[InternalBufferCapacity(17)]
public struct DEKFNECIAGB : IBufferElementData, IEquatable<DEKFNECIAGB>, DAGLOENMFJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity DEDKLMDDBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public int BLLDGEOBAAE;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private Entity DFDONCMAKNK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x75FA990", Offset = "0x75F9590", VA = "0x1875FA990", Slot = "4")]
	public bool Equals(DEKFNECIAGB PELBNOCGOOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FCONMEPGFKA : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public BLCHCKFJGOA NCLOACDHFOJ;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x75FABC0", Offset = "0x75F97C0", VA = "0x1875FABC0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public FCONMEPGFKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface BLCHCKFJGOA
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct AIKLAKAFLEG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct FELLLOPNMCD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly OEKKKOIEKJK MFKCLNMCCJI;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2B45B80", Offset = "0x2B44780", VA = "0x182B45B80")]
	public FELLLOPNMCD(OEKKKOIEKJK MFKCLNMCCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x75FAC30", Offset = "0x75F9830", VA = "0x1875FAC30")]
	public FELLLOPNMCD CDKEEEEGOJC(OEKKKOIEKJK NLJOPMPELKB)
	{
		return default(FELLLOPNMCD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x75FAC40", Offset = "0x75F9840", VA = "0x1875FAC40")]
	public FELLLOPNMCD GJDKJFJNNFC(OEKKKOIEKJK KKAIDDFIEEF)
	{
		return default(FELLLOPNMCD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x75FAC50", Offset = "0x75F9850", VA = "0x1875FAC50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Flags]
public enum OEKKKOIEKJK : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	HasShapeChildren = 1,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	HasEmbodiedChildren = 2,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	HasColliders = 4,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	HasObjectBoard = 8,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	HasUserTags = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	IsInScope = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	IsScopeRoot = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	IsRootObject = 0x80,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	TestEmbodiment = 0x100,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	All = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class FFLHPHLGFKC
{
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[SingletonComponent]
public struct JFPJOOACJMD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public OEKKKOIEKJK PHCDECEIKDA;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x75FBD30", Offset = "0x75FA930", VA = "0x1875FBD30")]
	public bool PACACMGAIJH(FELLLOPNMCD JJAAMJFLMBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x75FBD10", Offset = "0x75FA910", VA = "0x1875FBD10")]
	public bool KKFEEJOEAHL(FELLLOPNMCD JJAAMJFLMBJ, OEKKKOIEKJK AKKBCCOIKOD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Flags]
public enum CNNFOCDKHPO : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[SingletonComponent]
public struct IBFPFKJCHIE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public CNNFOCDKHPO MFKCLNMCCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public bool EICKALLOBPD;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool HMMNINNFILA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x75FB7A0", Offset = "0x75FA3A0", VA = "0x1875FB7A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x75FB7F0", Offset = "0x75FA3F0", VA = "0x1875FB7F0")]
	private IBFPFKJCHIE(CNNFOCDKHPO MFKCLNMCCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x75FB7B0", Offset = "0x75FA3B0", VA = "0x1875FB7B0")]
	public IBFPFKJCHIE CDKEEEEGOJC(CNNFOCDKHPO NLJOPMPELKB)
	{
		return default(IBFPFKJCHIE);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x75FB7D0", Offset = "0x75FA3D0", VA = "0x1875FB7D0")]
	public IBFPFKJCHIE GJDKJFJNNFC(CNNFOCDKHPO KKAIDDFIEEF)
	{
		return default(IBFPFKJCHIE);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct MEBBGPANGBO : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[InternalBufferCapacity(1)]
	public struct NetworkedEntityBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public Entity entity;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct FLOIKOBABCO : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity LKMHMLDCJFE;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : IBufferElementData, IEquatable<ChildBuffer>, DAGLOENMFJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x75FA560", Offset = "0x75F9160", VA = "0x1875FA560", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[SingletonComponent]
public struct LNFGGFOLILL : ISystemStateBufferElementData, IBufferElementData, DAGLOENMFJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public Entity CANLONBNOKL;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Entity DCAIFFNHBOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct KOHGFIIACCJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public Entity AADFNGEBKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public Entity BEEFHAEHPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Entity IHBJPBFCOBG;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct OHIAGLDEKEP<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly bool KBPDDCJKJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public uint BBGDOJMMPDC;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool NJOLBCAPJPG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[TypeManager.TypeVersion(2)]
public struct AFJMLCJKBAK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public uint KBAHGBFMMOL;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x10A34D0", Offset = "0x10A20D0", VA = "0x1810A34D0")]
	public AFJMLCJKBAK(FCEEFAMELLC KFMOBMOKICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x75FA400", Offset = "0x75F9000", VA = "0x1875FA400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1BE03E0", Offset = "0x1BDEFE0", VA = "0x181BE03E0")]
	public static AFJMLCJKBAK NIBCGLOMJGK(FCEEFAMELLC KFMOBMOKICC)
	{
		return default(AFJMLCJKBAK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct OFGONOEAIDI : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Entity CANLONBNOKL;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct BLKDBEHLJBG : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public FCEEFAMELLC MPDLOLIOGJL;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct OMFPLEGOHEH : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Entity CANLONBNOKL;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct LPPNCBBALDC : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Guid IEIMOIIMGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int EBDKDADIOBA;
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct FOFNCDINPCK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public int MPDLOLIOGJL;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct MONJPPENIFG : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Entity CANLONBNOKL;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct PINFLOEHBGP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public FCEEFAMELLC MPDLOLIOGJL;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct MNKGJAKEHMO : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Entity CANLONBNOKL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct KBJHKPEFOBJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[SingletonComponent]
public struct EFFHCMPDNJH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int NNLAAOBDDMI;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct LAKGJNJJMHN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int GMOJJMIJPJF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public GEDEGCEHLJI GCLLBBFNGJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9A3DB0", Offset = "0x9A29B0", VA = "0x1809A3DB0")]
		get
		{
			return default(GEDEGCEHLJI);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct KJKIBNDEOKI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public GCHandle CIGKIFGFDAI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct JFOFAMIJOBO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct BLHJGCKEBNA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct OFKAGGJFNFP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct BKHJCGKBOMI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct NDKJJAADGPM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct KOMACHHDBLI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public int BIEEMEKMINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public int HBIBCNEICNM;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x75FBFF0", Offset = "0x75FABF0", VA = "0x1875FBFF0")]
	public KOMACHHDBLI(Entity CANLONBNOKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct LMLLKNDAJIO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public CollisionDetectionMode HMPNNNPEDIK;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[RegisterComponentDefault]
public struct LFKMHANGJND : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public CKBJHKOEDDL APFPIGFJBJO;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly LFKMHANGJND EPMIHDCFDJH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct IAKADMIFOHA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct BKNLDMDMIGD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct PJFECFJGEKA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[InternalBufferCapacity(0)]
public struct KMLFCKJDDPB : IBufferElementData, IEquatable<KMLFCKJDDPB>, DAGLOENMFJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Entity DEDKLMDDBBA;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity DFDONCMAKNK
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x75FA560", Offset = "0x75F9160", VA = "0x1875FA560", Slot = "4")]
	public bool Equals(KMLFCKJDDPB PELBNOCGOOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct KOKAHBECAMJ : IComponentData, DAGLOENMFJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Entity KOIBCEOILEL;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Entity DFDONCMAKNK
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct NCLAEDJABNL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct EKNAMEGBIJA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Entity EBMDCHEPJIM;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct CPEEPOBLKCC : NGMKJMHNPKG, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public BHGGDDHLAEI CDIDJEACEGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(BHGGDDHLAEI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct MLONJPPHNCF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float3 BAIOIKGIMBI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct MMMDNCHDICG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[RegisterComponentDefault]
public struct IJCCJOGDGIE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public float3x3 JEDHAJEGGHL;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly IJCCJOGDGIE EPMIHDCFDJH;
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[RegisterComponentDefault]
public struct ONJOBGDNFHF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float3x3 JEDHAJEGGHL;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly ONJOBGDNFHF EPMIHDCFDJH;
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct ILEIIKHJNIH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float3 KACLMBOGNBL;
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct MPJACOKOGGF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public float3 KEGDABMPEEB;
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[RegisterComponentDefault]
public struct HKDBDHBBIHD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public float BKLMLKGKIEP;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly HKDBDHBBIHD EPMIHDCFDJH;
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[RegisterComponentDefault]
public struct GLFFILJNPDH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float GGFJEDBCOEH;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly GLFFILJNPDH EPMIHDCFDJH;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct LAHIOFKHHDG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public float3 GHLEGGNKMLL;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct LHNECCJNIDA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public HGFGAMBABML DBMDMGIFLNH;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[SingletonComponent]
public struct ACDLGPIDLCL : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Entity CANLONBNOKL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct FMLNHMMCDJA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct ICLEPFOFEHB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct ENNCBFCPBDH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public RigidbodyConstraints PEPMCCJPIPI;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[RegisterComponentDefault]
public struct CKLHBLCKAAL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public float CHFHCGCKICK;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly CKLHBLCKAAL EPMIHDCFDJH;
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct JJIJGEDODJA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float BNEDBGHNBFO;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class HDBPLOJPADD : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GameObject PHPLOOLODCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public object OFMPPLMKAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public object OHHIJAHMBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public PEPDCBAKMHG FBABJFFKOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public Delegate GPKOPJFAIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Delegate APOGCOLIGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public HKBIAANNAOH<Delegate> EDJMJDAACIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public HKBIAANNAOH<Delegate> BDLFHLEKNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public HKBIAANNAOH<Delegate> EHAODOAOBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public HKBIAANNAOH<Delegate> BPLAKOMEMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public HKBIAANNAOH<Delegate> JODGCEBCJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public HKBIAANNAOH<Delegate> MDMPNFJCCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public HKBIAANNAOH<Delegate> HHFOANIFODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public HKBIAANNAOH<Delegate> FPOMDJINOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public HKBIAANNAOH<Delegate> GOECDKAMMCB;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x75FB3A0", Offset = "0x75F9FA0", VA = "0x1875FB3A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public HDBPLOJPADD()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct KBFEIIJDNBM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct BBNICBMCJDL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public int MBPGFEGFLAM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1BE03E0", Offset = "0x1BDEFE0", VA = "0x181BE03E0")]
	public static BBNICBMCJDL NIBCGLOMJGK(int MPDLOLIOGJL)
	{
		return default(BBNICBMCJDL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class JPABGMDKLBM : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Rigidbody NIAHBPBMHAK;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x75FBE00", Offset = "0x75FAA00", VA = "0x1875FBE00", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public JPABGMDKLBM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct NENOMADBBCO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct LLFJJMOJJEC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 NNJICJPFFMH;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct AEKFHOCDGHN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float3 CNPDFOJECOP;
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[RegisterComponentDefault]
public struct KLOMFLIKNMI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float HKACAGCGEBP;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly KLOMFLIKNMI EPMIHDCFDJH;
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class AKMMKNJAPNG : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public object FIBMPLPGGJL;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x75FA430", Offset = "0x75F9030", VA = "0x1875FA430", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public AKMMKNJAPNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class PBFEKEMFIPJ : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public object GAPPMHBIHLH;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x75FCE70", Offset = "0x75FBA70", VA = "0x1875FCE70", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public PBFEKEMFIPJ()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct LGKHDANPJMP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct CNPEBJFFCIN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct DOAKAEPONDB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct CFGLCJLPHIP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct OGGGPGNFPPA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct JAEGLNKPLLD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct NNMANPEGBPE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct BBLDDHLPOAP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct MPHAKHGKBPH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct DAFLOBGENGM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public BFMNJDOGAFP CCDANHOALOK;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x75FA860", Offset = "0x75F9460", VA = "0x1875FA860", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct GGGDKLFCMEL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct JIOFCFNMOOL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct KJNFJNCILIK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct LAJNDNMPDMK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public FixedString32Bytes BGKKCEGMOKH;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[SingletonComponent]
public struct AIICEGKMJKD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public UnsafeParallelHashMap<BFMNJDOGAFP, Entity> CIHAPOKDBGJ;
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct NNPHEIPFOCC : ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Entity IPNPLEFBDBE;
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal struct KPDEEDDPBBI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Entity CANLONBNOKL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80")]
	public static KPDEEDDPBBI NIBCGLOMJGK(Entity CANLONBNOKL)
	{
		return default(KPDEEDDPBBI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct DMKPEGFDJJG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Entity MDIIEMEHLHH;
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct BAMKFBPNFIO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity MDIIEMEHLHH;
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal struct OAIIACKIOPN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Entity EHGIDGBFEOG;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80")]
	public static OAIIACKIOPN NIBCGLOMJGK(Entity CANLONBNOKL)
	{
		return default(OAIIACKIOPN);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal struct CMLNIPKJEFF : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct LIICNCLJAPH : IBufferElementData, IEquatable<LIICNCLJAPH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Entity IFCCOPAIPCC;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x745DE00", Offset = "0x745CA00", VA = "0x18745DE00", Slot = "4")]
	public bool Equals(LIICNCLJAPH PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x75FC1E0", Offset = "0x75FADE0", VA = "0x1875FC1E0", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x9A3DB0", Offset = "0x9A29B0", VA = "0x1809A3DB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct LAMECDHNCML : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public uint HBIBCNEICNM;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[SingletonComponent]
internal struct DINPJGFHKPP : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Entity DMAKEFCFHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public int BIEEMEKMINN;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal struct PAACJDFDOGO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public Entity IMBIPGAJGEI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct POCFPLCIFNN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct JMILFHAJONM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public uint BBGDOJMMPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int NFABOKECPCE;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xBB76A0", Offset = "0xBB62A0", VA = "0x180BB76A0")]
	public JMILFHAJONM(uint PDKCIMDFEJK, int IAMDLPLOCKI)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct NHFGIJBHFCN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct CLMIDCEBJMA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct CICIELBJEOC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct KODIPKAGJBD : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct MGDOFEFCEHI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct NFDGDEDDHGN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct GAPBCEMIHCD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct JECMKEMCPDH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct ACEELIGDOAI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal struct CDHHCCHBCLP : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct FHNMDMDNJCE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct BDFLDNICNDH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct LIIMOPKICIO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct HFCEOBIDAIJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
internal struct GPPPBBCAAHH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal struct PFKANFLBCPA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct DMBHIJGAKFL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct MAMGBFHMEHP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct ILGOLMOBLJI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct JJCINPBMBOD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct JDCMFKKEDOP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008E")]
public struct ODBKLJHGNKP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct FFELOCEEBLF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
public struct LHDNDCBLCGP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
public struct BPEJPABCJBF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000092")]
public struct MBGDAKGIDMA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct KFDCHKEIHEE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal struct LKHKGKACDPN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct NEFCOPEKMNJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct HKHBCGKJLKJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
[BPBEGDPJBLG]
public struct PNCLGDNILKL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[SingletonComponent]
public struct JHJCDKHEGPF : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public FixedString32Bytes PPIKKIDENAN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct MJPIDFIIPNJ : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct EMCPJKMGOAN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal struct DALFDICHLIF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
internal struct MGIMKBHBAOB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal struct NNLOILDLLJG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009E")]
public struct CGPKGENGNKL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
public struct KMIPBCMJFCO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public struct DBEHBIIOCEA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public quaternion APLHHNGOEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float3 FCININPMBGJ;
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public struct LDHMHMGCKPH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float BOCLHLIKGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float FFJNIEDJELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float FCBKHALDLHB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public struct NFHHIPOHELO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public struct BPIIIAIKHGN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public struct DNFPBBHIFIP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public struct BLMCBKBFPML : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public int GMOJJMIJPJF;
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[SingletonComponent]
public struct OIBFNDCNCJB : ISystemStateBufferElementData, IBufferElementData, DAGLOENMFJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Entity GEEJIMECCCB;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity DCAIFFNHBOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[RegisterComponentDefault]
public struct CBAJFEOBGFB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public float4x4 JPHPGKACNHF;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly CBAJFEOBGFB EPMIHDCFDJH;
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[RegisterComponentDefault]
public struct OECBNNPHFDK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public float4x4 BMBNADKCDGO;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly OECBNNPHFDK EPMIHDCFDJH;
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct ADFOFGMHOJO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private int HHMMCINELGL;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int BIEEMEKMINN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x75FA3E0", Offset = "0x75F8FE0", VA = "0x1875FA3E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x75FA3F0", Offset = "0x75F8FF0", VA = "0x1875FA3F0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[RegisterComponentDefault]
public struct GDBNONDBHBG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public float3 FCININPMBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public quaternion APLHHNGOEFP;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly GDBNONDBHBG EPMIHDCFDJH;
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public static class HHGGFMKLPJJ
{
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[RegisterComponentDefault]
public struct FJNOJPMHHOJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public float HDFMHPEJAHF;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly FJNOJPMHHOJ EPMIHDCFDJH;
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public struct HJINBKMEADN : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Entity EFKBGLNDIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public GDGOOJEEKEA KMMNOOJNABL;
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public struct FCMLHKPFHPA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public GDGOOJEEKEA KMMNOOJNABL;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public struct IDOOPCLJCGL : ISystemStateComponentData, IComponentData, DAGLOENMFJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Entity MGIILDCJJIC;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Entity DCAIFFNHBOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public struct MBPCDBONHHG : ISystemStateBufferElementData, IBufferElementData, DAGLOENMFJH, IEquatable<MBPCDBONHHG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Entity MLIIPDCNOLM;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Entity DCAIFFNHBOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x745DE00", Offset = "0x745CA00", VA = "0x18745DE00", Slot = "6")]
	public bool Equals(MBPCDBONHHG PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x75FC270", Offset = "0x75FAE70", VA = "0x1875FC270", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9A3DB0", Offset = "0x9A29B0", VA = "0x1809A3DB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public struct MEOJOLPAAMP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Entity EFKBGLNDIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public GDGOOJEEKEA KMMNOOJNABL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct EMAHGFAJHND : IEqualityComparer<MEOJOLPAAMP>
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static EMAHGFAJHND EPMIHDCFDJH;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x75FAB10", Offset = "0x75F9710", VA = "0x1875FAB10", Slot = "4")]
	public bool Equals(MEOJOLPAAMP MDFKHKOGFDI, MEOJOLPAAMP ELJEANFLEPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x75FAB60", Offset = "0x75F9760", VA = "0x1875FAB60", Slot = "5")]
	public int GetHashCode(MEOJOLPAAMP CFMCKCBBBKK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct EILGPKEECDA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public FixedList32Bytes<int> AJOBKLGCIIG;
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct NHFHGMJCJCC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public FixedList32Bytes<int> AJOBKLGCIIG;
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public struct LIGAMGECHNA : ISystemStateBufferElementData, IBufferElementData, DAGLOENMFJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public Entity JEKGMLMDPNH;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Entity DFDONCMAKNK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x147F1B0", Offset = "0x147DDB0", VA = "0x18147F1B0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class LGEFDBFODGJ : ContainerPropertyBag<FCONMEPGFKA>
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private class JAIKLJFBJIP : Property<FCONMEPGFKA, BLCHCKFJGOA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string NMFKAOGOELC
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x75FBC20", Offset = "0x75FA820", VA = "0x1875FBC20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool EDFBHKBNGLD
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x75FBBE0", Offset = "0x75FA7E0", VA = "0x1875FBBE0")]
		public JAIKLJFBJIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x75FA4A0", Offset = "0x75F90A0", VA = "0x1875FA4A0", Slot = "14")]
		public override BLCHCKFJGOA GetValue(FCONMEPGFKA AGGFAPJEEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x75FA4C0", Offset = "0x75F90C0", VA = "0x1875FA4C0", Slot = "15")]
		public override void SetValue(FCONMEPGFKA AGGFAPJEEEN, BLCHCKFJGOA MPDLOLIOGJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x75FC100", Offset = "0x75FAD00", VA = "0x1875FC100")]
	public LGEFDBFODGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal class NKHNJMFBHPG : ContainerPropertyBag<HDBPLOJPADD>
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	private class ALEPBMNEFJG : Property<HDBPLOJPADD, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string NMFKAOGOELC
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x75FA530", Offset = "0x75F9130", VA = "0x1875FA530", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool EDFBHKBNGLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x75FA4F0", Offset = "0x75F90F0", VA = "0x1875FA4F0")]
		public ALEPBMNEFJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x75FA4A0", Offset = "0x75F90A0", VA = "0x1875FA4A0", Slot = "14")]
		public override GameObject GetValue(HDBPLOJPADD AGGFAPJEEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x75FA4C0", Offset = "0x75F90C0", VA = "0x1875FA4C0", Slot = "15")]
		public override void SetValue(HDBPLOJPADD AGGFAPJEEEN, GameObject MPDLOLIOGJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private class OPHGGEPKODM : Property<HDBPLOJPADD, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string NMFKAOGOELC
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x75FCE40", Offset = "0x75FBA40", VA = "0x1875FCE40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool EDFBHKBNGLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x75FCE00", Offset = "0x75FBA00", VA = "0x1875FCE00")]
		public OPHGGEPKODM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x75FCDB0", Offset = "0x75FB9B0", VA = "0x1875FCDB0", Slot = "14")]
		public override object GetValue(HDBPLOJPADD AGGFAPJEEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x75FCDD0", Offset = "0x75FB9D0", VA = "0x1875FCDD0", Slot = "15")]
		public override void SetValue(HDBPLOJPADD AGGFAPJEEEN, object MPDLOLIOGJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	private class PGNEDEKIAAI : Property<HDBPLOJPADD, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string NMFKAOGOELC
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x75FCF70", Offset = "0x75FBB70", VA = "0x1875FCF70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool EDFBHKBNGLD
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x75FCF30", Offset = "0x75FBB30", VA = "0x1875FCF30")]
		public PGNEDEKIAAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x75FCEE0", Offset = "0x75FBAE0", VA = "0x1875FCEE0", Slot = "14")]
		public override object GetValue(HDBPLOJPADD AGGFAPJEEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x75FCF00", Offset = "0x75FBB00", VA = "0x1875FCF00", Slot = "15")]
		public override void SetValue(HDBPLOJPADD AGGFAPJEEEN, object MPDLOLIOGJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	private class CMNEOKJCELP : Property<HDBPLOJPADD, PEPDCBAKMHG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string NMFKAOGOELC
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x75FA830", Offset = "0x75F9430", VA = "0x1875FA830", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool EDFBHKBNGLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x75FA7F0", Offset = "0x75F93F0", VA = "0x1875FA7F0")]
		public CMNEOKJCELP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x75FA7A0", Offset = "0x75F93A0", VA = "0x1875FA7A0", Slot = "14")]
		public override PEPDCBAKMHG GetValue(HDBPLOJPADD AGGFAPJEEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x75FA7C0", Offset = "0x75F93C0", VA = "0x1875FA7C0", Slot = "15")]
		public override void SetValue(HDBPLOJPADD AGGFAPJEEEN, PEPDCBAKMHG MPDLOLIOGJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	private class NPPEABJHNJF : Property<HDBPLOJPADD, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string NMFKAOGOELC
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x75FCBE0", Offset = "0x75FB7E0", VA = "0x1875FCBE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool EDFBHKBNGLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x75FCBA0", Offset = "0x75FB7A0", VA = "0x1875FCBA0")]
		public NPPEABJHNJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x75FCB50", Offset = "0x75FB750", VA = "0x1875FCB50", Slot = "14")]
		public override Delegate GetValue(HDBPLOJPADD AGGFAPJEEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x75FCB70", Offset = "0x75FB770", VA = "0x1875FCB70", Slot = "15")]
		public override void SetValue(HDBPLOJPADD AGGFAPJEEEN, Delegate MPDLOLIOGJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	private class NCALBPIHKMA : Property<HDBPLOJPADD, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string NMFKAOGOELC
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x75FC400", Offset = "0x75FB000", VA = "0x1875FC400", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool EDFBHKBNGLD
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x75FC3C0", Offset = "0x75FAFC0", VA = "0x1875FC3C0")]
		public NCALBPIHKMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x75FC370", Offset = "0x75FAF70", VA = "0x1875FC370", Slot = "14")]
		public override Delegate GetValue(HDBPLOJPADD AGGFAPJEEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x75FC390", Offset = "0x75FAF90", VA = "0x1875FC390", Slot = "15")]
		public override void SetValue(HDBPLOJPADD AGGFAPJEEEN, Delegate MPDLOLIOGJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private class NNOFHONBGNJ : Property<HDBPLOJPADD, HKBIAANNAOH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string NMFKAOGOELC
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x75FCB20", Offset = "0x75FB720", VA = "0x1875FCB20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool EDFBHKBNGLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x75FCAE0", Offset = "0x75FB6E0", VA = "0x1875FCAE0")]
		public NNOFHONBGNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x75FCA90", Offset = "0x75FB690", VA = "0x1875FCA90", Slot = "14")]
		public override HKBIAANNAOH<Delegate> GetValue(HDBPLOJPADD AGGFAPJEEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x75FCAB0", Offset = "0x75FB6B0", VA = "0x1875FCAB0", Slot = "15")]
		public override void SetValue(HDBPLOJPADD AGGFAPJEEEN, HKBIAANNAOH<Delegate> MPDLOLIOGJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private class GEJGLFEAGNP : Property<HDBPLOJPADD, HKBIAANNAOH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string NMFKAOGOELC
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x75FAFB0", Offset = "0x75F9BB0", VA = "0x1875FAFB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool EDFBHKBNGLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x75FAF70", Offset = "0x75F9B70", VA = "0x1875FAF70")]
		public GEJGLFEAGNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x75FAF20", Offset = "0x75F9B20", VA = "0x1875FAF20", Slot = "14")]
		public override HKBIAANNAOH<Delegate> GetValue(HDBPLOJPADD AGGFAPJEEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x75FAF40", Offset = "0x75F9B40", VA = "0x1875FAF40", Slot = "15")]
		public override void SetValue(HDBPLOJPADD AGGFAPJEEEN, HKBIAANNAOH<Delegate> MPDLOLIOGJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private class PNNLCJJAAKA : Property<HDBPLOJPADD, HKBIAANNAOH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string NMFKAOGOELC
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x75FD030", Offset = "0x75FBC30", VA = "0x1875FD030", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool EDFBHKBNGLD
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x75FCFF0", Offset = "0x75FBBF0", VA = "0x1875FCFF0")]
		public PNNLCJJAAKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x75FCFA0", Offset = "0x75FBBA0", VA = "0x1875FCFA0", Slot = "14")]
		public override HKBIAANNAOH<Delegate> GetValue(HDBPLOJPADD AGGFAPJEEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x75FCFC0", Offset = "0x75FBBC0", VA = "0x1875FCFC0", Slot = "15")]
		public override void SetValue(HDBPLOJPADD AGGFAPJEEEN, HKBIAANNAOH<Delegate> MPDLOLIOGJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private class IMHMHDPDIML : Property<HDBPLOJPADD, HKBIAANNAOH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string NMFKAOGOELC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x75FBBB0", Offset = "0x75FA7B0", VA = "0x1875FBBB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool EDFBHKBNGLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x75FBB70", Offset = "0x75FA770", VA = "0x1875FBB70")]
		public IMHMHDPDIML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x75FBB20", Offset = "0x75FA720", VA = "0x1875FBB20", Slot = "14")]
		public override HKBIAANNAOH<Delegate> GetValue(HDBPLOJPADD AGGFAPJEEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x75FBB40", Offset = "0x75FA740", VA = "0x1875FBB40", Slot = "15")]
		public override void SetValue(HDBPLOJPADD AGGFAPJEEEN, HKBIAANNAOH<Delegate> MPDLOLIOGJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private class BGFBJDGBKIK : Property<HDBPLOJPADD, HKBIAANNAOH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string NMFKAOGOELC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x75FA600", Offset = "0x75F9200", VA = "0x1875FA600", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool EDFBHKBNGLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x75FA5C0", Offset = "0x75F91C0", VA = "0x1875FA5C0")]
		public BGFBJDGBKIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x75FA570", Offset = "0x75F9170", VA = "0x1875FA570", Slot = "14")]
		public override HKBIAANNAOH<Delegate> GetValue(HDBPLOJPADD AGGFAPJEEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x75FA590", Offset = "0x75F9190", VA = "0x1875FA590", Slot = "15")]
		public override void SetValue(HDBPLOJPADD AGGFAPJEEEN, HKBIAANNAOH<Delegate> MPDLOLIOGJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private class DGEKIDBBPDD : Property<HDBPLOJPADD, HKBIAANNAOH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string NMFKAOGOELC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x75FAA70", Offset = "0x75F9670", VA = "0x1875FAA70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool EDFBHKBNGLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x75FAA30", Offset = "0x75F9630", VA = "0x1875FAA30")]
		public DGEKIDBBPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x75FA9E0", Offset = "0x75F95E0", VA = "0x1875FA9E0", Slot = "14")]
		public override HKBIAANNAOH<Delegate> GetValue(HDBPLOJPADD AGGFAPJEEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x75FAA00", Offset = "0x75F9600", VA = "0x1875FAA00", Slot = "15")]
		public override void SetValue(HDBPLOJPADD AGGFAPJEEEN, HKBIAANNAOH<Delegate> MPDLOLIOGJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private class LAAFCIPHKLG : Property<HDBPLOJPADD, HKBIAANNAOH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string NMFKAOGOELC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x75FC090", Offset = "0x75FAC90", VA = "0x1875FC090", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool EDFBHKBNGLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x75FC050", Offset = "0x75FAC50", VA = "0x1875FC050")]
		public LAAFCIPHKLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x75FC000", Offset = "0x75FAC00", VA = "0x1875FC000", Slot = "14")]
		public override HKBIAANNAOH<Delegate> GetValue(HDBPLOJPADD AGGFAPJEEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x75FC020", Offset = "0x75FAC20", VA = "0x1875FC020", Slot = "15")]
		public override void SetValue(HDBPLOJPADD AGGFAPJEEEN, HKBIAANNAOH<Delegate> MPDLOLIOGJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	private class JFEHJPIKCJB : Property<HDBPLOJPADD, HKBIAANNAOH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string NMFKAOGOELC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x75FBCE0", Offset = "0x75FA8E0", VA = "0x1875FBCE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool EDFBHKBNGLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x75FBCA0", Offset = "0x75FA8A0", VA = "0x1875FBCA0")]
		public JFEHJPIKCJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x75FBC50", Offset = "0x75FA850", VA = "0x1875FBC50", Slot = "14")]
		public override HKBIAANNAOH<Delegate> GetValue(HDBPLOJPADD AGGFAPJEEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x75FBC70", Offset = "0x75FA870", VA = "0x1875FBC70", Slot = "15")]
		public override void SetValue(HDBPLOJPADD AGGFAPJEEEN, HKBIAANNAOH<Delegate> MPDLOLIOGJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	private class JGJHBLFGGAM : Property<HDBPLOJPADD, HKBIAANNAOH<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string NMFKAOGOELC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x75FBDD0", Offset = "0x75FA9D0", VA = "0x1875FBDD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool EDFBHKBNGLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x75FBD90", Offset = "0x75FA990", VA = "0x1875FBD90")]
		public JGJHBLFGGAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x75FBD40", Offset = "0x75FA940", VA = "0x1875FBD40", Slot = "14")]
		public override HKBIAANNAOH<Delegate> GetValue(HDBPLOJPADD AGGFAPJEEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x75FBD60", Offset = "0x75FA960", VA = "0x1875FBD60", Slot = "15")]
		public override void SetValue(HDBPLOJPADD AGGFAPJEEEN, HKBIAANNAOH<Delegate> MPDLOLIOGJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x75FC430", Offset = "0x75FB030", VA = "0x1875FC430")]
	public NKHNJMFBHPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class GIJINCBNLJN : ContainerPropertyBag<HKBIAANNAOH<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x75FAFE0", Offset = "0x75F9BE0", VA = "0x1875FAFE0")]
	public GIJINCBNLJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal class GNELFOFPCGN : ContainerPropertyBag<JPABGMDKLBM>
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	private class DIENAEBIKAE : Property<JPABGMDKLBM, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string NMFKAOGOELC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x75FAAE0", Offset = "0x75F96E0", VA = "0x1875FAAE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool EDFBHKBNGLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x75FAAA0", Offset = "0x75F96A0", VA = "0x1875FAAA0")]
		public DIENAEBIKAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x75FA4A0", Offset = "0x75F90A0", VA = "0x1875FA4A0", Slot = "14")]
		public override Rigidbody GetValue(JPABGMDKLBM AGGFAPJEEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x75FA4C0", Offset = "0x75F90C0", VA = "0x1875FA4C0", Slot = "15")]
		public override void SetValue(JPABGMDKLBM AGGFAPJEEEN, Rigidbody MPDLOLIOGJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x75FB2C0", Offset = "0x75F9EC0", VA = "0x1875FB2C0")]
	public GNELFOFPCGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal class ILIEGLGLHOM : ContainerPropertyBag<AKMMKNJAPNG>
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	private class MLIIDNIALOA : Property<AKMMKNJAPNG, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string NMFKAOGOELC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x75FC340", Offset = "0x75FAF40", VA = "0x1875FC340", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool EDFBHKBNGLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x75FC300", Offset = "0x75FAF00", VA = "0x1875FC300")]
		public MLIIDNIALOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x75FA4A0", Offset = "0x75F90A0", VA = "0x1875FA4A0", Slot = "14")]
		public override object GetValue(AKMMKNJAPNG AGGFAPJEEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x75FA4C0", Offset = "0x75F90C0", VA = "0x1875FA4C0", Slot = "15")]
		public override void SetValue(AKMMKNJAPNG AGGFAPJEEEN, object MPDLOLIOGJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x75FBA40", Offset = "0x75FA640", VA = "0x1875FBA40")]
	public ILIEGLGLHOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal class IJDNMFMLPGP : ContainerPropertyBag<PBFEKEMFIPJ>
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	private class IDFCJGJCBLL : Property<PBFEKEMFIPJ, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string NMFKAOGOELC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x75FB840", Offset = "0x75FA440", VA = "0x1875FB840", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool EDFBHKBNGLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x75FB800", Offset = "0x75FA400", VA = "0x1875FB800")]
		public IDFCJGJCBLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x75FA4A0", Offset = "0x75F90A0", VA = "0x1875FA4A0", Slot = "14")]
		public override object GetValue(PBFEKEMFIPJ AGGFAPJEEEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x75FA4C0", Offset = "0x75F90C0", VA = "0x1875FA4C0", Slot = "15")]
		public override void SetValue(PBFEKEMFIPJ AGGFAPJEEEN, object MPDLOLIOGJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x75FB960", Offset = "0x75FA560", VA = "0x1875FB960")]
	public IJDNMFMLPGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal class DAPLFEIDKJM : ContainerPropertyBag<NNPHEIPFOCC>
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	private class BLICKMKBHOL : Property<NNPHEIPFOCC, Entity>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string NMFKAOGOELC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x75FA680", Offset = "0x75F9280", VA = "0x1875FA680", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool EDFBHKBNGLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x75FA640", Offset = "0x75F9240", VA = "0x1875FA640")]
		public BLICKMKBHOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xCFB360", Offset = "0xCF9F60", VA = "0x180CFB360", Slot = "14")]
		public override Entity GetValue(NNPHEIPFOCC AGGFAPJEEEN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x75FA630", Offset = "0x75F9230", VA = "0x1875FA630", Slot = "15")]
		public override void SetValue(NNPHEIPFOCC AGGFAPJEEEN, Entity MPDLOLIOGJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x75FA8B0", Offset = "0x75F94B0", VA = "0x1875FA8B0")]
	public DAPLFEIDKJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal class KKBPKMAFMLP : ContainerPropertyBag<Entity>
{
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	private class FKFMNOKJOPP : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string NMFKAOGOELC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x75FAD30", Offset = "0x75F9930", VA = "0x1875FAD30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool EDFBHKBNGLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x75FACF0", Offset = "0x75F98F0", VA = "0x1875FACF0")]
		public FKFMNOKJOPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1EE94C0", Offset = "0x1EE80C0", VA = "0x181EE94C0", Slot = "14")]
		public override int GetValue(Entity AGGFAPJEEEN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7448080", Offset = "0x7446C80", VA = "0x187448080", Slot = "15")]
		public override void SetValue(Entity AGGFAPJEEEN, int MPDLOLIOGJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	private class GCKLLNEEEOH : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string NMFKAOGOELC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x75FADC0", Offset = "0x75F99C0", VA = "0x1875FADC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool EDFBHKBNGLD
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x75FAD80", Offset = "0x75F9980", VA = "0x1875FAD80")]
		public GCKLLNEEEOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x75FAD60", Offset = "0x75F9960", VA = "0x1875FAD60", Slot = "14")]
		public override int GetValue(Entity AGGFAPJEEEN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x75FAD70", Offset = "0x75F9970", VA = "0x1875FAD70", Slot = "15")]
		public override void SetValue(Entity AGGFAPJEEEN, int MPDLOLIOGJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x75FBE70", Offset = "0x75FAA70", VA = "0x1875FBE70")]
	public KKBPKMAFMLP()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x75FD060", Offset = "0x75FBC60", VA = "0x1875FD060")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public class DLABOHGMBLK
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public DLABOHGMBLK()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
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
