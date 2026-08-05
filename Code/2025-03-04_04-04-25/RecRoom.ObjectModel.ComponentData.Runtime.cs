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
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
		[Cpp2IlInjected.Address(RVA = "0x7661090", Offset = "0x765F690", VA = "0x187661090", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7661440", Offset = "0x765FA40", VA = "0x187661440", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x245DCB0", Offset = "0x245C2B0", VA = "0x18245DCB0")]
		public _AssemblyIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct CNKOMGDFBAL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct DKINDPJBJIE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct LAFOMDOHFHE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct IIGNPCJEEOE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct HELCNLMCMFA : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildBuffer : IBufferElementData, IEquatable<AuthoredChildBuffer>, NHANIEANCKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x765E110", Offset = "0x765C710", VA = "0x18765E110", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct HOJAIFGPHGD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct FCLHFCHFPHF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Entity DFJEAODKDBJ;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct HBNKBHLLEDJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Entity DFJEAODKDBJ;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct HIEKEBOAHBL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<GKKFFCAHJLF> MAJLFJCHEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeList<Entity> AKNGIICDPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private JobHandle NIJHHKONNDH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LCHDPNFEMLD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x765F4F0", Offset = "0x765DAF0", VA = "0x18765F4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x765F560", Offset = "0x765DB60", VA = "0x18765F560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x56A44A0", Offset = "0x56A2AA0", VA = "0x1856A44A0")]
	public HIEKEBOAHBL(NativeList<GKKFFCAHJLF> MAJLFJCHEPP, NativeList<Entity> AKNGIICDPBC, JobHandle NIJHHKONNDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x765F3D0", Offset = "0x765D9D0", VA = "0x18765F3D0")]
	public (Entity, NativeSlice<Entity>) FJNENLCPKGC(int BKHEBBAMMAK)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x765F370", Offset = "0x765D970", VA = "0x18765F370", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct GKKFFCAHJLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Entity JGHOOBNHEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int FDJGEFDKBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public int GIGAFKHMOHH;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EBPEBDALCPC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FCGIOPCGKCK(bool PMBOJIIMLKH);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct CEAJMDNMFIO : IEquatable<CEAJMDNMFIO>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate bool GMGFPHCLHCN(int CGHBAOIKKLL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly bool OCLGGDPJBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly bool AHBPOFHBJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly bool LOMAHINPBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly bool JFIPFJCDOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly GMGFPHCLHCN NMCBHKNCEAH;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x765E6D0", Offset = "0x765CCD0", VA = "0x18765E6D0")]
	public CEAJMDNMFIO(KMKOJLIANAG PNCPEFMKILJ, GMGFPHCLHCN NMCBHKNCEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x765E6A0", Offset = "0x765CCA0", VA = "0x18765E6A0")]
	public CEAJMDNMFIO(bool OCLGGDPJBOL, bool AHBPOFHBJKC, bool LOMAHINPBPK, bool JFIPFJCDOCC, GMGFPHCLHCN NMCBHKNCEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x765E5B0", Offset = "0x765CBB0", VA = "0x18765E5B0")]
	public bool HBLBNINELLI(int CGHBAOIKKLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x765E3B0", Offset = "0x765C9B0", VA = "0x18765E3B0")]
	public bool AIHGHHGNEOK(int CGHBAOIKKLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x765E5E0", Offset = "0x765CBE0", VA = "0x18765E5E0")]
	public bool JCLCNEOEBDD(int CGHBAOIKKLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x765E4E0", Offset = "0x765CAE0", VA = "0x18765E4E0")]
	public bool GEMGGKGJAGB(int CGHBAOIKKLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x765E4B0", Offset = "0x765CAB0", VA = "0x18765E4B0", Slot = "4")]
	public bool Equals(CEAJMDNMFIO OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x765E400", Offset = "0x765CA00", VA = "0x18765E400", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x765E510", Offset = "0x765CB10", VA = "0x18765E510", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x765E3E0", Offset = "0x765C9E0", VA = "0x18765E3E0")]
	private bool BLKPBBIJFMB(int CGHBAOIKKLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x765E610", Offset = "0x765CC10", VA = "0x18765E610", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct FEKKOJLKKOO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct NJELIDMGAJM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct MLJDBCNLPPF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[InternalBufferCapacity(17)]
public struct NPIHBPHCJJK : IBufferElementData, IEquatable<NPIHBPHCJJK>, NHANIEANCKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity DJHFBAMKFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public int IGEFECFIJLF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private Entity HJBHAPAKJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7660390", Offset = "0x765E990", VA = "0x187660390", Slot = "4")]
	public bool Equals(NPIHBPHCJJK OKCHLIEAIJP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class MOMPCOGDGLB : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public OJOCGBDBALB FKOFMENDCEB;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7660120", Offset = "0x765E720", VA = "0x187660120", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public MOMPCOGDGLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OJOCGBDBALB
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct EAOBNMKNFIH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct HNBOHBOBJEM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly FHJHFKJHAME ICLECPKAJBI;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2BA3840", Offset = "0x2BA1E40", VA = "0x182BA3840")]
	public HNBOHBOBJEM(FHJHFKJHAME ICLECPKAJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x765F680", Offset = "0x765DC80", VA = "0x18765F680")]
	public HNBOHBOBJEM KMKMCBJODMD(FHJHFKJHAME PIPALKGAHMN)
	{
		return default(HNBOHBOBJEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x765F670", Offset = "0x765DC70", VA = "0x18765F670")]
	public HNBOHBOBJEM FDDAMKFJPKD(FHJHFKJHAME GNEELFPHLCN)
	{
		return default(HNBOHBOBJEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x765F690", Offset = "0x765DC90", VA = "0x18765F690", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Flags]
public enum FHJHFKJHAME : ushort
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
public static class GIIBLHIDOGH
{
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[SingletonComponent]
public struct BIPHOGBGMLK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public FHJHFKJHAME HKKOBANDFBI;

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x765E200", Offset = "0x765C800", VA = "0x18765E200")]
	public bool KDDOKJLBGBJ(HNBOHBOBJEM FBELANIEJHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x765E1E0", Offset = "0x765C7E0", VA = "0x18765E1E0")]
	public bool ICAHCOEPOAJ(HNBOHBOBJEM FBELANIEJHJ, FHJHFKJHAME BJEJHFGKMJC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Flags]
public enum HFJGIJDNIDD : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	MakerPenOut = 1
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[SingletonComponent]
public struct NGEBLDHKBFP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public HFJGIJDNIDD ICLECPKAJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public bool FKAFOHPKEBH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool NLLCKJDKNMD
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7660270", Offset = "0x765E870", VA = "0x187660270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x76602C0", Offset = "0x765E8C0", VA = "0x1876602C0")]
	private NGEBLDHKBFP(HFJGIJDNIDD ICLECPKAJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x76602A0", Offset = "0x765E8A0", VA = "0x1876602A0")]
	public NGEBLDHKBFP KMKMCBJODMD(HFJGIJDNIDD PIPALKGAHMN)
	{
		return default(NGEBLDHKBFP);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7660280", Offset = "0x765E880", VA = "0x187660280")]
	public NGEBLDHKBFP FDDAMKFJPKD(HFJGIJDNIDD GNEELFPHLCN)
	{
		return default(NGEBLDHKBFP);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct JAALAGAFLGL : IComponentData
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
public struct EGJMJFEDMAD : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Entity DEFDENDBJNN;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[InternalBufferCapacity(8)]
	public struct ChildBuffer : IBufferElementData, IEquatable<ChildBuffer>, NHANIEANCKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x765E110", Offset = "0x765C710", VA = "0x18765E110", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[SingletonComponent]
public struct BJCPGDMHHGH : ISystemStateBufferElementData, IBufferElementData, NHANIEANCKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public Entity FCJGDHPNMHF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Entity MOKMABEPCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct IOHPHFBFCLN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public Entity JGJENBEKBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public Entity HMHODOELNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Entity LBKJMIDCEMI;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct DPMMMENNOFH<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly bool DLCFPDABHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public uint MKGKBELEDLC;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	private static bool DIBKJPPLFHI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[TypeManager.TypeVersion(2)]
public struct ICKMJEODMIL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public uint BKFPLLMDOFB;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x10AD620", Offset = "0x10ABC20", VA = "0x1810AD620")]
	public ICKMJEODMIL(GFBOHEINDFO OJGFMNKCCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x765F6F0", Offset = "0x765DCF0", VA = "0x18765F6F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1C09260", Offset = "0x1C07860", VA = "0x181C09260")]
	public static ICKMJEODMIL HEGJABMHLEC(GFBOHEINDFO OJGFMNKCCFJ)
	{
		return default(ICKMJEODMIL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct HINLMBDDNMC : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Entity FCJGDHPNMHF;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct KHEKCGFFBPA : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public GFBOHEINDFO KBGCCIOIGBD;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct IDLACAFDDIA : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Entity FCJGDHPNMHF;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct DMHDIODLEOB : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Guid JINNLDEOCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public int BBEJNKBNMID;
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct DLELHFMNBDE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public int KBGCCIOIGBD;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct BCCNIBLDDAI : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public Entity FCJGDHPNMHF;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct DCOLBCPKHHC : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public GFBOHEINDFO KBGCCIOIGBD;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct BAADHIPNHOO : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Entity FCJGDHPNMHF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct ECAGHDOJEAJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[SingletonComponent]
public struct FJFGODAGPNE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int DKDJOJNMDJP;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct FAJIMJBKCFM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int KHELFHBHLMG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NOONNECLOAO DMMOFKKFCNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x99D850", Offset = "0x99BE50", VA = "0x18099D850")]
		get
		{
			return default(NOONNECLOAO);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct ICCMEIGIGPK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public GCHandle FJODPHFOBGG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct CFJKIAJFANB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct NHBNOLLOEPA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct LBOHAFEFIAL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct INHJEMPJFPF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct EKFPCACHBNF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct MDOEGNJKKGA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public int EAHKFAJBNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public int EPKMALKPPHD;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x765FFB0", Offset = "0x765E5B0", VA = "0x18765FFB0")]
	public MDOEGNJKKGA(Entity FCJGDHPNMHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct FEOFPCOCEHJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public CollisionDetectionMode ILCMKGGAAMD;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[RegisterComponentDefault]
public struct MJPNGPBLNLI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public OINJBHOKJEJ CNBAIKAAJFA;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly MJPNGPBLNLI MPDPNCAPBBE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct DGCGMIKIJIK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003D")]
public struct FDBHNEMICNL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct HGMDBLEKDMK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[InternalBufferCapacity(0)]
public struct CLLFODBLGKN : IBufferElementData, IEquatable<CLLFODBLGKN>, NHANIEANCKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Entity DJHFBAMKFNI;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity HJBHAPAKJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x765E110", Offset = "0x765C710", VA = "0x18765E110", Slot = "4")]
	public bool Equals(CLLFODBLGKN OKCHLIEAIJP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct NJKFFFOGHBD : IComponentData, NHANIEANCKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Entity LDIAONMHHPK;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Entity HJBHAPAKJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct ABHLKMEFBHD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct NGHBDDFCKGJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Entity JGHOOBNHEJB;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct OGLGOMCELDA : NPHNMECBFFC, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public GCLOLCGDHHG LEBJBAKIKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(GCLOLCGDHHG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct LJDIFCNHKDB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float3 AIPKHFOBLGB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct GBGLILNNCGL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[RegisterComponentDefault]
public struct LFMAGCLOLIO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public float3x3 MJODOEGLMDB;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public static readonly LFMAGCLOLIO MPDPNCAPBBE;
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[RegisterComponentDefault]
public struct IGKPBAKJMCJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public float3x3 MJODOEGLMDB;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly IGKPBAKJMCJ MPDPNCAPBBE;
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct KDOJOHNFLCJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public float3 OJOBHJOLOKJ;
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct LCKOJHNMMHH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public float3 POONODMEMIA;
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[RegisterComponentDefault]
public struct MNLDKHGGIMD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public float MPEGFEDHHKK;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly MNLDKHGGIMD MPDPNCAPBBE;
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[RegisterComponentDefault]
public struct IGOKFOGCJEN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public float GLMFLGEIELN;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly IGOKFOGCJEN MPDPNCAPBBE;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct GPOFCADKLKO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public float3 OHLHGJJLLFJ;
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct FPCILBGKLBK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public FALLENFFJHK BHLDBBEMKKJ;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[SingletonComponent]
public struct CMDMKKMINJL : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Entity FCJGDHPNMHF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct BMKAHGGOJCH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct HFHAGJBAHEO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public struct DDIDBKBCIDP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public RigidbodyConstraints MPLKFGNDEDG;
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[RegisterComponentDefault]
public struct AAMMDHFHDKD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public float NPJINIJDOIG;

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public static readonly AAMMDHFHDKD MPDPNCAPBBE;
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct FEAPGNEENHM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public float AOJLFKPPHBO;
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class KLDAFCLLLEK : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public GameObject HHDLNMHBJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public object BLKFLPPAAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public object ANMDJNEKPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public PDOOMAJLGEG MAHGMLPJMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public Delegate CMBFFJBFGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Delegate IIJHOJGEMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public EFMCPKJOHAF<Delegate> BPOCAOADABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public EFMCPKJOHAF<Delegate> IBNIPJJMOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public EFMCPKJOHAF<Delegate> OKDHBNLBJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public EFMCPKJOHAF<Delegate> OEHLPDDALKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public EFMCPKJOHAF<Delegate> NKAKBCPAAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public EFMCPKJOHAF<Delegate> GDHJKOEGOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public EFMCPKJOHAF<Delegate> LOHFJKNOMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public EFMCPKJOHAF<Delegate> DKNEBAPNPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public EFMCPKJOHAF<Delegate> LJJHGGBEJBH;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x765FC10", Offset = "0x765E210", VA = "0x18765FC10", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public KLDAFCLLLEK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
public struct LLODCPNLPEB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public struct JIBCKHJBPCI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public int GHDJKEPFCEC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1C09260", Offset = "0x1C07860", VA = "0x181C09260")]
	public static JIBCKHJBPCI HEGJABMHLEC(int KBGCCIOIGBD)
	{
		return default(JIBCKHJBPCI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class ADJMKBFDFGN : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Rigidbody HFMGHKAPEPN;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x765DFA0", Offset = "0x765C5A0", VA = "0x18765DFA0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public ADJMKBFDFGN()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct IOLLIPNCJPF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct PKONKAKMHJE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 GNFIJOGHJJB;
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public struct NBMHCHIGLDB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float3 PGIPNLMJJCH;
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[RegisterComponentDefault]
public struct AKPMNNHIPOJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float HNCMMPBIENH;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly AKPMNNHIPOJ MPDPNCAPBBE;
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class OPHLPNFIFPI : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public object IHGEAEHHOPP;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x76604C0", Offset = "0x765EAC0", VA = "0x1876604C0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public OPHLPNFIFPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class EJJBOIOFAKC : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public object CMACCAKONPC;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x765E850", Offset = "0x765CE50", VA = "0x18765E850", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public EJJBOIOFAKC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct MGIMHLGDEHA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct GCNPFOLCLIN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct BACLMKOAKIE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct KILLMNFPHCJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct ANICIHKENNJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct AMEOBJJGDMJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct MBFBONODAJG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct AOMILBDLIDJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000066")]
public struct JNJKLAAJBEL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public struct KIJKOKNCHNB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public GOBCHKKNALB ANNFGFFKKNA;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x765FBC0", Offset = "0x765E1C0", VA = "0x18765FBC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct GHAKFPKEKKN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct FECDHGEHNDP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct LLDGAOKDJKD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public struct HGDCLDMGGDF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public FixedString32Bytes OMOOEGOLALI;
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[SingletonComponent]
public struct LCJIKCIPNFP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public UnsafeParallelHashMap<GOBCHKKNALB, Entity> LFHLOIBFOMK;
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct JLBMIHMPFAN : ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Entity GMFPIMKPKGO;
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal struct JGBGKMBBDIJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Entity FCJGDHPNMHF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490")]
	public static JGBGKMBBDIJ HEGJABMHLEC(Entity FCJGDHPNMHF)
	{
		return default(JGBGKMBBDIJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct HBAGLMOJPNG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Entity FEGPJMGBDFP;
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public struct CNJHHKLDIKP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Entity FEGPJMGBDFP;
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal struct MBGDDGGKBAK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Entity LEAOGMMCFDF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490")]
	public static MBGDDGGKBAK HEGJABMHLEC(Entity FCJGDHPNMHF)
	{
		return default(MBGDDGGKBAK);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000072")]
internal struct GPPBKGIAFHG : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct KDIBMODJGIH : IBufferElementData, IEquatable<KDIBMODJGIH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Entity FEKKGJHNKLJ;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x74B1AF0", Offset = "0x74B00F0", VA = "0x1874B1AF0", Slot = "4")]
	public bool Equals(KDIBMODJGIH OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x765FAA0", Offset = "0x765E0A0", VA = "0x18765FAA0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x99D850", Offset = "0x99BE50", VA = "0x18099D850", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct HJCKBBMEFGJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public uint EPKMALKPPHD;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[SingletonComponent]
internal struct JMBFGEPAGAJ : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Entity FGLHGHDGDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public int EAHKFAJBNDN;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
internal struct FNMGLKHJHBF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public Entity JBENCCOBBHH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct GNBAJDHJHEP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct ACMGBPCLLHI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public uint MKGKBELEDLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int NCPLHILMNAP;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xBD0F00", Offset = "0xBCF500", VA = "0x180BD0F00")]
	public ACMGBPCLLHI(uint ECGJJDEPJGG, int JHDJPBJNNLG)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct JELCAODJKAN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct KBCGBBJAOHP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct EEAJPEEENCH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct IPJGCOAPNFB : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct OBMEKAGLLED : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
public struct IELOJNCHDOE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct JDNMNDMJBMM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct BKIHGGBLLNI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct PBLDOBBPLAK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
internal struct DEECKMABCCH : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct OAPPADICLIL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct PKDJKPHGHHO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct KCPKJDMLNEH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000086")]
public struct LLPLHDLEHFB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
internal struct JABKCICPPBF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal struct DHIEIMAHLDE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct AFNEGOEGPCJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct IGHPNOECNND : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct HALCLGLKOJF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008C")]
public struct MCEHLNNOCHE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct HEAAFLJHHMD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008E")]
public struct DJLFGEBDDHK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008F")]
public struct KAGJFPBBLCG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000090")]
public struct OGKMDBMJKON : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
public struct HOGPLDKDNPN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000092")]
public struct PKDAOHDFLIG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct LFCGOIMEDPH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000094")]
internal struct CGDAMADLHIC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct OAOIPJBONNE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct DBINJCILBCM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
[IAMGHNLLAHJ]
public struct FEMDNHBEFMK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[SingletonComponent]
public struct JAIKFKIOEME : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public FixedString32Bytes FHGNCBECHHF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct LCEDCFOEFFG : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct GFBBNKMDCAJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009B")]
internal struct ONGHCDKIKJH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009C")]
internal struct LLGBNFKKMOG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal struct KKIOAPEEKHM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009E")]
public struct JKALPLHCPHA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
public struct GMENOBPJDHJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public struct LDGFNAKDLKL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public quaternion MLMNPOCKAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float3 NDADPNJPMFO;
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public struct PCABEKPIGGH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public float LJNIKAPBADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float CGGINGPOOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float LAGMLDNPANM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public struct PLJJLLAMFJM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public struct ILMLNNMBCHD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public struct JGEODLIEDEC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public struct IFCJGKMFMOA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public int KHELFHBHLMG;
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[SingletonComponent]
public struct CAKGHJODDHN : ISystemStateBufferElementData, IBufferElementData, NHANIEANCKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Entity CAFMPIKGEAO;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Entity MOKMABEPCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[RegisterComponentDefault]
public struct AAEFNDOLBIP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public float4x4 DDIKGCJKBKD;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly AAEFNDOLBIP MPDPNCAPBBE;
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[RegisterComponentDefault]
public struct EJKNJBCAOHO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public float4x4 GLNFFLIPMPB;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly EJKNJBCAOHO MPDPNCAPBBE;
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct OAMGGELJPEH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private int AOJLKEFJBEO;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int EAHKFAJBNDN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x76603F0", Offset = "0x765E9F0", VA = "0x1876603F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x76603E0", Offset = "0x765E9E0", VA = "0x1876603E0")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[RegisterComponentDefault]
public struct AAKDNPOOEKL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public float3 NDADPNJPMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public quaternion MLMNPOCKAAE;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly AAKDNPOOEKL MPDPNCAPBBE;
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public static class FDMIAOLPACI
{
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[RegisterComponentDefault]
public struct ELCPDJLHDKE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public float KNJAEBENIAO;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly ELCPDJLHDKE MPDPNCAPBBE;
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public struct JIKGFKOCDIA : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Entity CMHPCDCAOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public EKDALHPLPPO OPCPCOOFBPO;
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public struct NEKGJEONMKM : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public EKDALHPLPPO OPCPCOOFBPO;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public struct HOOCHCOJANP : ISystemStateComponentData, IComponentData, NHANIEANCKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Entity ADMEOFCKKPF;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Entity MOKMABEPCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public struct KECGNEOIIJC : ISystemStateBufferElementData, IBufferElementData, NHANIEANCKA, IEquatable<KECGNEOIIJC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Entity AELLMLJHMNF;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Entity MOKMABEPCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x74B1AF0", Offset = "0x74B00F0", VA = "0x1874B1AF0", Slot = "6")]
	public bool Equals(KECGNEOIIJC OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x765FB30", Offset = "0x765E130", VA = "0x18765FB30", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x99D850", Offset = "0x99BE50", VA = "0x18099D850", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public struct KDOBOMDECIO : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Entity CMHPCDCAOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public EKDALHPLPPO OPCPCOOFBPO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct LJNDDMHGALH : IEqualityComparer<KDOBOMDECIO>
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static LJNDDMHGALH MPDPNCAPBBE;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x765FDC0", Offset = "0x765E3C0", VA = "0x18765FDC0", Slot = "4")]
	public bool Equals(KDOBOMDECIO IKAEODCKAIP, KDOBOMDECIO ACCJFOPIMAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x765FE10", Offset = "0x765E410", VA = "0x18765FE10", Slot = "5")]
	public int GetHashCode(KDOBOMDECIO GMFKPONAANG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct KFHMGIGPJHN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public FixedList32Bytes<int> KEJFIGAFLGB;
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct DADIBCLPJHF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public FixedList32Bytes<int> KEJFIGAFLGB;
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public struct OEDEBBIBKMI : ISystemStateBufferElementData, IBufferElementData, NHANIEANCKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public Entity OIBJPGHBBDP;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Entity HJBHAPAKJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xBD5490", Offset = "0xBD3A90", VA = "0x180BD5490", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x14A3DE0", Offset = "0x14A23E0", VA = "0x1814A3DE0", Slot = "5")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal class HHBEOFADLIA : ContainerPropertyBag<MOMPCOGDGLB>
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private class PKPEMDMOGGA : Property<MOMPCOGDGLB, OJOCGBDBALB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override string OPDMIMOEGEA
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x76606B0", Offset = "0x765ECB0", VA = "0x1876606B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7660670", Offset = "0x765EC70", VA = "0x187660670")]
		public PKPEMDMOGGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x765E120", Offset = "0x765C720", VA = "0x18765E120", Slot = "14")]
		public override OJOCGBDBALB GetValue(MOMPCOGDGLB MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x765E140", Offset = "0x765C740", VA = "0x18765E140", Slot = "15")]
		public override void SetValue(MOMPCOGDGLB MGOKPJKELJG, OJOCGBDBALB KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x765F200", Offset = "0x765D800", VA = "0x18765F200")]
	public HHBEOFADLIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal class GFMCDLMABDP : ContainerPropertyBag<KLDAFCLLLEK>
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	private class BIELBMFLKIG : Property<KLDAFCLLLEK, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string OPDMIMOEGEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x765E1B0", Offset = "0x765C7B0", VA = "0x18765E1B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x765E170", Offset = "0x765C770", VA = "0x18765E170")]
		public BIELBMFLKIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x765E120", Offset = "0x765C720", VA = "0x18765E120", Slot = "14")]
		public override GameObject GetValue(KLDAFCLLLEK MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x765E140", Offset = "0x765C740", VA = "0x18765E140", Slot = "15")]
		public override void SetValue(KLDAFCLLLEK MGOKPJKELJG, GameObject KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private class OLAGFGLGKHC : Property<KLDAFCLLLEK, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string OPDMIMOEGEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7660490", Offset = "0x765EA90", VA = "0x187660490", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7660450", Offset = "0x765EA50", VA = "0x187660450")]
		public OLAGFGLGKHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7660400", Offset = "0x765EA00", VA = "0x187660400", Slot = "14")]
		public override object GetValue(KLDAFCLLLEK MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7660420", Offset = "0x765EA20", VA = "0x187660420", Slot = "15")]
		public override void SetValue(KLDAFCLLLEK MGOKPJKELJG, object KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	private class JIMNJFEGMFA : Property<KLDAFCLLLEK, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string OPDMIMOEGEA
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x765FA70", Offset = "0x765E070", VA = "0x18765FA70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x765FA30", Offset = "0x765E030", VA = "0x18765FA30")]
		public JIMNJFEGMFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x765F9E0", Offset = "0x765DFE0", VA = "0x18765F9E0", Slot = "14")]
		public override object GetValue(KLDAFCLLLEK MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x765FA00", Offset = "0x765E000", VA = "0x18765FA00", Slot = "15")]
		public override void SetValue(KLDAFCLLLEK MGOKPJKELJG, object KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	private class BLIJPKDDPCB : Property<KLDAFCLLLEK, PDOOMAJLGEG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string OPDMIMOEGEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x765E2A0", Offset = "0x765C8A0", VA = "0x18765E2A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x765E260", Offset = "0x765C860", VA = "0x18765E260")]
		public BLIJPKDDPCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x765E210", Offset = "0x765C810", VA = "0x18765E210", Slot = "14")]
		public override PDOOMAJLGEG GetValue(KLDAFCLLLEK MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x765E230", Offset = "0x765C830", VA = "0x18765E230", Slot = "15")]
		public override void SetValue(KLDAFCLLLEK MGOKPJKELJG, PDOOMAJLGEG KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	private class HNBFDILMHEL : Property<KLDAFCLLLEK, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string OPDMIMOEGEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x765F640", Offset = "0x765DC40", VA = "0x18765F640", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x765F600", Offset = "0x765DC00", VA = "0x18765F600")]
		public HNBFDILMHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x765F5B0", Offset = "0x765DBB0", VA = "0x18765F5B0", Slot = "14")]
		public override Delegate GetValue(KLDAFCLLLEK MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x765F5D0", Offset = "0x765DBD0", VA = "0x18765F5D0", Slot = "15")]
		public override void SetValue(KLDAFCLLLEK MGOKPJKELJG, Delegate KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	private class AACJEFICDOP : Property<KLDAFCLLLEK, Delegate>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string OPDMIMOEGEA
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x765DD50", Offset = "0x765C350", VA = "0x18765DD50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x765DD10", Offset = "0x765C310", VA = "0x18765DD10")]
		public AACJEFICDOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x765DCC0", Offset = "0x765C2C0", VA = "0x18765DCC0", Slot = "14")]
		public override Delegate GetValue(KLDAFCLLLEK MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x765DCE0", Offset = "0x765C2E0", VA = "0x18765DCE0", Slot = "15")]
		public override void SetValue(KLDAFCLLLEK MGOKPJKELJG, Delegate KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private class IGJMAOCCCJB : Property<KLDAFCLLLEK, EFMCPKJOHAF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string OPDMIMOEGEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x765F7B0", Offset = "0x765DDB0", VA = "0x18765F7B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x765F770", Offset = "0x765DD70", VA = "0x18765F770")]
		public IGJMAOCCCJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x765F720", Offset = "0x765DD20", VA = "0x18765F720", Slot = "14")]
		public override EFMCPKJOHAF<Delegate> GetValue(KLDAFCLLLEK MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x765F740", Offset = "0x765DD40", VA = "0x18765F740", Slot = "15")]
		public override void SetValue(KLDAFCLLLEK MGOKPJKELJG, EFMCPKJOHAF<Delegate> KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private class FBKKNDNELON : Property<KLDAFCLLLEK, EFMCPKJOHAF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string OPDMIMOEGEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x765EAB0", Offset = "0x765D0B0", VA = "0x18765EAB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x765EA70", Offset = "0x765D070", VA = "0x18765EA70")]
		public FBKKNDNELON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x765EA20", Offset = "0x765D020", VA = "0x18765EA20", Slot = "14")]
		public override EFMCPKJOHAF<Delegate> GetValue(KLDAFCLLLEK MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x765EA40", Offset = "0x765D040", VA = "0x18765EA40", Slot = "15")]
		public override void SetValue(KLDAFCLLLEK MGOKPJKELJG, EFMCPKJOHAF<Delegate> KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private class PMJOLFJIPCE : Property<KLDAFCLLLEK, EFMCPKJOHAF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string OPDMIMOEGEA
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7660850", Offset = "0x765EE50", VA = "0x187660850", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7660810", Offset = "0x765EE10", VA = "0x187660810")]
		public PMJOLFJIPCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x76607C0", Offset = "0x765EDC0", VA = "0x1876607C0", Slot = "14")]
		public override EFMCPKJOHAF<Delegate> GetValue(KLDAFCLLLEK MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x76607E0", Offset = "0x765EDE0", VA = "0x1876607E0", Slot = "15")]
		public override void SetValue(KLDAFCLLLEK MGOKPJKELJG, EFMCPKJOHAF<Delegate> KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private class FHKKBOIGGKI : Property<KLDAFCLLLEK, EFMCPKJOHAF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string OPDMIMOEGEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x765EB70", Offset = "0x765D170", VA = "0x18765EB70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x765EB30", Offset = "0x765D130", VA = "0x18765EB30")]
		public FHKKBOIGGKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x765EAE0", Offset = "0x765D0E0", VA = "0x18765EAE0", Slot = "14")]
		public override EFMCPKJOHAF<Delegate> GetValue(KLDAFCLLLEK MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x765EB00", Offset = "0x765D100", VA = "0x18765EB00", Slot = "15")]
		public override void SetValue(KLDAFCLLLEK MGOKPJKELJG, EFMCPKJOHAF<Delegate> KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	private class CGGJMAKJMII : Property<KLDAFCLLLEK, EFMCPKJOHAF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string OPDMIMOEGEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x765E7B0", Offset = "0x765CDB0", VA = "0x18765E7B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x765E770", Offset = "0x765CD70", VA = "0x18765E770")]
		public CGGJMAKJMII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x765E720", Offset = "0x765CD20", VA = "0x18765E720", Slot = "14")]
		public override EFMCPKJOHAF<Delegate> GetValue(KLDAFCLLLEK MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x765E740", Offset = "0x765CD40", VA = "0x18765E740", Slot = "15")]
		public override void SetValue(KLDAFCLLLEK MGOKPJKELJG, EFMCPKJOHAF<Delegate> KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	private class NNCHMNEANLK : Property<KLDAFCLLLEK, EFMCPKJOHAF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string OPDMIMOEGEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x7660360", Offset = "0x765E960", VA = "0x187660360", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7660320", Offset = "0x765E920", VA = "0x187660320")]
		public NNCHMNEANLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x76602D0", Offset = "0x765E8D0", VA = "0x1876602D0", Slot = "14")]
		public override EFMCPKJOHAF<Delegate> GetValue(KLDAFCLLLEK MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x76602F0", Offset = "0x765E8F0", VA = "0x1876602F0", Slot = "15")]
		public override void SetValue(KLDAFCLLLEK MGOKPJKELJG, EFMCPKJOHAF<Delegate> KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	private class AODMIKBEBLN : Property<KLDAFCLLLEK, EFMCPKJOHAF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string OPDMIMOEGEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x765E0E0", Offset = "0x765C6E0", VA = "0x18765E0E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x765E0A0", Offset = "0x765C6A0", VA = "0x18765E0A0")]
		public AODMIKBEBLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x765E050", Offset = "0x765C650", VA = "0x18765E050", Slot = "14")]
		public override EFMCPKJOHAF<Delegate> GetValue(KLDAFCLLLEK MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x765E070", Offset = "0x765C670", VA = "0x18765E070", Slot = "15")]
		public override void SetValue(KLDAFCLLLEK MGOKPJKELJG, EFMCPKJOHAF<Delegate> KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	private class INJJMIOPGFD : Property<KLDAFCLLLEK, EFMCPKJOHAF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string OPDMIMOEGEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x765F9B0", Offset = "0x765DFB0", VA = "0x18765F9B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x765F970", Offset = "0x765DF70", VA = "0x18765F970")]
		public INJJMIOPGFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x765F920", Offset = "0x765DF20", VA = "0x18765F920", Slot = "14")]
		public override EFMCPKJOHAF<Delegate> GetValue(KLDAFCLLLEK MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x765F940", Offset = "0x765DF40", VA = "0x18765F940", Slot = "15")]
		public override void SetValue(KLDAFCLLLEK MGOKPJKELJG, EFMCPKJOHAF<Delegate> KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	private class PJPCHHIKDBF : Property<KLDAFCLLLEK, EFMCPKJOHAF<Delegate>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string OPDMIMOEGEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7660640", Offset = "0x765EC40", VA = "0x187660640", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7660600", Offset = "0x765EC00", VA = "0x187660600")]
		public PJPCHHIKDBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x76605B0", Offset = "0x765EBB0", VA = "0x1876605B0", Slot = "14")]
		public override EFMCPKJOHAF<Delegate> GetValue(KLDAFCLLLEK MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x76605D0", Offset = "0x765EBD0", VA = "0x1876605D0", Slot = "15")]
		public override void SetValue(KLDAFCLLLEK MGOKPJKELJG, EFMCPKJOHAF<Delegate> KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x765EBA0", Offset = "0x765D1A0", VA = "0x18765EBA0")]
	public GFMCDLMABDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class LIGHLJBJMDK : ContainerPropertyBag<EFMCPKJOHAF<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x765FD60", Offset = "0x765E360", VA = "0x18765FD60")]
	public LIGHLJBJMDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal class BMEKKONFIMP : ContainerPropertyBag<ADJMKBFDFGN>
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	private class ENKAPDLPPKE : Property<ADJMKBFDFGN, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string OPDMIMOEGEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x765E9F0", Offset = "0x765CFF0", VA = "0x18765E9F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x765E9B0", Offset = "0x765CFB0", VA = "0x18765E9B0")]
		public ENKAPDLPPKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x765E120", Offset = "0x765C720", VA = "0x18765E120", Slot = "14")]
		public override Rigidbody GetValue(ADJMKBFDFGN MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x765E140", Offset = "0x765C740", VA = "0x18765E140", Slot = "15")]
		public override void SetValue(ADJMKBFDFGN MGOKPJKELJG, Rigidbody KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x765E2D0", Offset = "0x765C8D0", VA = "0x18765E2D0")]
	public BMEKKONFIMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal class PPMHGBLOJDO : ContainerPropertyBag<OPHLPNFIFPI>
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	private class MNGBHEBFOPA : Property<OPHLPNFIFPI, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string OPDMIMOEGEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x76600B0", Offset = "0x765E6B0", VA = "0x1876600B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7660070", Offset = "0x765E670", VA = "0x187660070")]
		public MNGBHEBFOPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x765E120", Offset = "0x765C720", VA = "0x18765E120", Slot = "14")]
		public override object GetValue(OPHLPNFIFPI MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x765E140", Offset = "0x765C740", VA = "0x18765E140", Slot = "15")]
		public override void SetValue(OPHLPNFIFPI MGOKPJKELJG, object KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7660880", Offset = "0x765EE80", VA = "0x187660880")]
	public PPMHGBLOJDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal class PLNJOFHHANB : ContainerPropertyBag<EJJBOIOFAKC>
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	private class MEKHCJPIIIB : Property<EJJBOIOFAKC, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string OPDMIMOEGEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x7660000", Offset = "0x765E600", VA = "0x187660000", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x765FFC0", Offset = "0x765E5C0", VA = "0x18765FFC0")]
		public MEKHCJPIIIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x765E120", Offset = "0x765C720", VA = "0x18765E120", Slot = "14")]
		public override object GetValue(EJJBOIOFAKC MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x765E140", Offset = "0x765C740", VA = "0x18765E140", Slot = "15")]
		public override void SetValue(EJJBOIOFAKC MGOKPJKELJG, object KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x76606E0", Offset = "0x765ECE0", VA = "0x1876606E0")]
	public PLNJOFHHANB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal class NAPKHOLOKGP : ContainerPropertyBag<JLBMIHMPFAN>
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	private class PDOIEEHFJIN : Property<JLBMIHMPFAN, Entity>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string OPDMIMOEGEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7660580", Offset = "0x765EB80", VA = "0x187660580", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7660540", Offset = "0x765EB40", VA = "0x187660540")]
		public PDOIEEHFJIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xD09A20", Offset = "0xD08020", VA = "0x180D09A20", Slot = "14")]
		public override Entity GetValue(JLBMIHMPFAN MGOKPJKELJG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7660530", Offset = "0x765EB30", VA = "0x187660530", Slot = "15")]
		public override void SetValue(JLBMIHMPFAN MGOKPJKELJG, Entity KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7660190", Offset = "0x765E790", VA = "0x187660190")]
	public NAPKHOLOKGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal class MCDHANIGILM : ContainerPropertyBag<Entity>
{
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	private class DHEJKLOOEDI : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string OPDMIMOEGEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x765E820", Offset = "0x765CE20", VA = "0x18765E820", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x765E7E0", Offset = "0x765CDE0", VA = "0x18765E7E0")]
		public DHEJKLOOEDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1F19DE0", Offset = "0x1F183E0", VA = "0x181F19DE0", Slot = "14")]
		public override int GetValue(Entity MGOKPJKELJG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x749C910", Offset = "0x749AF10", VA = "0x18749C910", Slot = "15")]
		public override void SetValue(Entity MGOKPJKELJG, int KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	private class HIBEHIGMNMK : Property<Entity, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string OPDMIMOEGEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x765F340", Offset = "0x765D940", VA = "0x18765F340", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x765F300", Offset = "0x765D900", VA = "0x18765F300")]
		public HIBEHIGMNMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x765F2E0", Offset = "0x765D8E0", VA = "0x18765F2E0", Slot = "14")]
		public override int GetValue(Entity MGOKPJKELJG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x765F2F0", Offset = "0x765D8F0", VA = "0x18765F2F0", Slot = "15")]
		public override void SetValue(Entity MGOKPJKELJG, int KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x765FE70", Offset = "0x765E470", VA = "0x18765FE70")]
	public MCDHANIGILM()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7660960", Offset = "0x765EF60", VA = "0x187660960")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000D5")]
public class OKEBKGOCPLK
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public OKEBKGOCPLK()
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
