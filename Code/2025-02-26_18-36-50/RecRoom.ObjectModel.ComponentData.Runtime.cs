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
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75C2A90", Offset = "0x75C1E90", VA = "0x1875C2A90", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x75C2E40", Offset = "0x75C2240", VA = "0x1875C2E40", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x242AF30", Offset = "0x242A330", VA = "0x18242AF30")]
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
			[Cpp2IlInjected.Address(RVA = "0xBCD970", Offset = "0xBCCD70", VA = "0x180BCD970", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x1481460", Offset = "0x1480860", VA = "0x181481460", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x75BFB10", Offset = "0x75BEF10", VA = "0x1875BFB10", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1481460", Offset = "0x1480860", VA = "0x181481460")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB0B4F0", Offset = "0xB0A8F0", VA = "0x180B0B4F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75C0EF0", Offset = "0x75C02F0", VA = "0x1875C0EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x75C0F60", Offset = "0x75C0360", VA = "0x1875C0F60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x561DFE0", Offset = "0x561D3E0", VA = "0x18561DFE0")]
	public HIEKEBOAHBL(NativeList<GKKFFCAHJLF> MAJLFJCHEPP, NativeList<Entity> AKNGIICDPBC, JobHandle NIJHHKONNDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x75C0DD0", Offset = "0x75C01D0", VA = "0x1875C0DD0")]
	public (Entity, NativeSlice<Entity>) FJNENLCPKGC(int BKHEBBAMMAK)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x75C0D70", Offset = "0x75C0170", VA = "0x1875C0D70", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x75C00D0", Offset = "0x75BF4D0", VA = "0x1875C00D0")]
	public CEAJMDNMFIO(KMKOJLIANAG PNCPEFMKILJ, GMGFPHCLHCN NMCBHKNCEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x75C00A0", Offset = "0x75BF4A0", VA = "0x1875C00A0")]
	public CEAJMDNMFIO(bool OCLGGDPJBOL, bool AHBPOFHBJKC, bool LOMAHINPBPK, bool JFIPFJCDOCC, GMGFPHCLHCN NMCBHKNCEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x75BFFB0", Offset = "0x75BF3B0", VA = "0x1875BFFB0")]
	public bool HBLBNINELLI(int CGHBAOIKKLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x75BFDB0", Offset = "0x75BF1B0", VA = "0x1875BFDB0")]
	public bool AIHGHHGNEOK(int CGHBAOIKKLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x75BFFE0", Offset = "0x75BF3E0", VA = "0x1875BFFE0")]
	public bool JCLCNEOEBDD(int CGHBAOIKKLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x75BFEE0", Offset = "0x75BF2E0", VA = "0x1875BFEE0")]
	public bool GEMGGKGJAGB(int CGHBAOIKKLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x75BFEB0", Offset = "0x75BF2B0", VA = "0x1875BFEB0", Slot = "4")]
	public bool Equals(CEAJMDNMFIO OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x75BFE00", Offset = "0x75BF200", VA = "0x1875BFE00", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x75BFF10", Offset = "0x75BF310", VA = "0x1875BFF10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x75BFDE0", Offset = "0x75BF1E0", VA = "0x1875BFDE0")]
	private bool BLKPBBIJFMB(int CGHBAOIKKLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x75C0010", Offset = "0x75BF410", VA = "0x1875C0010", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xBCD970", Offset = "0xBCCD70", VA = "0x180BCD970", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1481460", Offset = "0x1480860", VA = "0x181481460", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x75C1D90", Offset = "0x75C1190", VA = "0x1875C1D90", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x75C1B20", Offset = "0x75C0F20", VA = "0x1875C1B20", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B6D860", Offset = "0x2B6CC60", VA = "0x182B6D860")]
	public HNBOHBOBJEM(FHJHFKJHAME ICLECPKAJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x75C1080", Offset = "0x75C0480", VA = "0x1875C1080")]
	public HNBOHBOBJEM KMKMCBJODMD(FHJHFKJHAME PIPALKGAHMN)
	{
		return default(HNBOHBOBJEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x75C1070", Offset = "0x75C0470", VA = "0x1875C1070")]
	public HNBOHBOBJEM FDDAMKFJPKD(FHJHFKJHAME GNEELFPHLCN)
	{
		return default(HNBOHBOBJEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x75C1090", Offset = "0x75C0490", VA = "0x1875C1090", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x75BFC00", Offset = "0x75BF000", VA = "0x1875BFC00")]
	public bool KDDOKJLBGBJ(HNBOHBOBJEM FBELANIEJHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x75BFBE0", Offset = "0x75BEFE0", VA = "0x1875BFBE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x75C1C70", Offset = "0x75C1070", VA = "0x1875C1C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x75C1CC0", Offset = "0x75C10C0", VA = "0x1875C1CC0")]
	private NGEBLDHKBFP(HFJGIJDNIDD ICLECPKAJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x75C1CA0", Offset = "0x75C10A0", VA = "0x1875C1CA0")]
	public NGEBLDHKBFP KMKMCBJODMD(HFJGIJDNIDD PIPALKGAHMN)
	{
		return default(NGEBLDHKBFP);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x75C1C80", Offset = "0x75C1080", VA = "0x1875C1C80")]
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
			[Cpp2IlInjected.Address(RVA = "0xBCD970", Offset = "0xBCCD70", VA = "0x180BCD970", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1481460", Offset = "0x1480860", VA = "0x181481460", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1481460", Offset = "0x1480860", VA = "0x181481460")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x75BFB10", Offset = "0x75BEF10", VA = "0x1875BFB10", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xB0B4F0", Offset = "0xB0A8F0", VA = "0x180B0B4F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xBCD970", Offset = "0xBCCD70", VA = "0x180BCD970", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1481460", Offset = "0x1480860", VA = "0x181481460", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x1098640", Offset = "0x1097A40", VA = "0x181098640")]
	public ICKMJEODMIL(GFBOHEINDFO OJGFMNKCCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x75C10F0", Offset = "0x75C04F0", VA = "0x1875C10F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1BE8ED0", Offset = "0x1BE82D0", VA = "0x181BE8ED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x995B20", Offset = "0x994F20", VA = "0x180995B20")]
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
	[Cpp2IlInjected.Address(RVA = "0x75C19B0", Offset = "0x75C0DB0", VA = "0x1875C19B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xBCD970", Offset = "0xBCCD70", VA = "0x180BCD970", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1481460", Offset = "0x1480860", VA = "0x181481460", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x75BFB10", Offset = "0x75BEF10", VA = "0x1875BFB10", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xBCD970", Offset = "0xBCCD70", VA = "0x180BCD970", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1481460", Offset = "0x1480860", VA = "0x181481460", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xBCD970", Offset = "0xBCCD70", VA = "0x180BCD970", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(GCLOLCGDHHG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1481460", Offset = "0x1480860", VA = "0x181481460", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x75C1610", Offset = "0x75C0A10", VA = "0x1875C1610", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1BE8ED0", Offset = "0x1BE82D0", VA = "0x181BE8ED0")]
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
	[Cpp2IlInjected.Address(RVA = "0x75BF9A0", Offset = "0x75BEDA0", VA = "0x1875BF9A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x75C1EC0", Offset = "0x75C12C0", VA = "0x1875C1EC0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x75C0250", Offset = "0x75BF650", VA = "0x1875C0250", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x75C15C0", Offset = "0x75C09C0", VA = "0x1875C15C0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0xB0B4F0", Offset = "0xB0A8F0", VA = "0x180B0B4F0")]
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
	[Cpp2IlInjected.Address(RVA = "0xB0B4F0", Offset = "0xB0A8F0", VA = "0x180B0B4F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x74137A0", Offset = "0x7412BA0", VA = "0x1874137A0", Slot = "4")]
	public bool Equals(KDIBMODJGIH OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x75C14A0", Offset = "0x75C08A0", VA = "0x1875C14A0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x995B20", Offset = "0x994F20", VA = "0x180995B20", Slot = "2")]
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
	[Cpp2IlInjected.Address(RVA = "0xBAEB50", Offset = "0xBADF50", VA = "0x180BAEB50")]
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
		[Cpp2IlInjected.Address(RVA = "0xBCD970", Offset = "0xBCCD70", VA = "0x180BCD970", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1481460", Offset = "0x1480860", VA = "0x181481460", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x75C1DF0", Offset = "0x75C11F0", VA = "0x1875C1DF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x75C1DE0", Offset = "0x75C11E0", VA = "0x1875C1DE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xBCD970", Offset = "0xBCCD70", VA = "0x180BCD970", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1481460", Offset = "0x1480860", VA = "0x181481460", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xBCD970", Offset = "0xBCCD70", VA = "0x180BCD970", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1481460", Offset = "0x1480860", VA = "0x181481460", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x74137A0", Offset = "0x7412BA0", VA = "0x1874137A0", Slot = "6")]
	public bool Equals(KECGNEOIIJC OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x75C1530", Offset = "0x75C0930", VA = "0x1875C1530", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x995B20", Offset = "0x994F20", VA = "0x180995B20", Slot = "2")]
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
	[Cpp2IlInjected.Address(RVA = "0x75C17C0", Offset = "0x75C0BC0", VA = "0x1875C17C0", Slot = "4")]
	public bool Equals(KDOBOMDECIO IKAEODCKAIP, KDOBOMDECIO ACCJFOPIMAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x75C1810", Offset = "0x75C0C10", VA = "0x1875C1810", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xBCD970", Offset = "0xBCCD70", VA = "0x180BCD970", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1481460", Offset = "0x1480860", VA = "0x181481460", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x75C20B0", Offset = "0x75C14B0", VA = "0x1875C20B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x75C2070", Offset = "0x75C1470", VA = "0x1875C2070")]
		public PKPEMDMOGGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x75BFB20", Offset = "0x75BEF20", VA = "0x1875BFB20", Slot = "14")]
		public override OJOCGBDBALB GetValue(MOMPCOGDGLB MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x75BFB40", Offset = "0x75BEF40", VA = "0x1875BFB40", Slot = "15")]
		public override void SetValue(MOMPCOGDGLB MGOKPJKELJG, OJOCGBDBALB KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x75C0C00", Offset = "0x75C0000", VA = "0x1875C0C00")]
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
			[Cpp2IlInjected.Address(RVA = "0x75BFBB0", Offset = "0x75BEFB0", VA = "0x1875BFBB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x75BFB70", Offset = "0x75BEF70", VA = "0x1875BFB70")]
		public BIELBMFLKIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x75BFB20", Offset = "0x75BEF20", VA = "0x1875BFB20", Slot = "14")]
		public override GameObject GetValue(KLDAFCLLLEK MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x75BFB40", Offset = "0x75BEF40", VA = "0x1875BFB40", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x75C1E90", Offset = "0x75C1290", VA = "0x1875C1E90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x75C1E50", Offset = "0x75C1250", VA = "0x1875C1E50")]
		public OLAGFGLGKHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x75C1E00", Offset = "0x75C1200", VA = "0x1875C1E00", Slot = "14")]
		public override object GetValue(KLDAFCLLLEK MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x75C1E20", Offset = "0x75C1220", VA = "0x1875C1E20", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x75C1470", Offset = "0x75C0870", VA = "0x1875C1470", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x75C1430", Offset = "0x75C0830", VA = "0x1875C1430")]
		public JIMNJFEGMFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x75C13E0", Offset = "0x75C07E0", VA = "0x1875C13E0", Slot = "14")]
		public override object GetValue(KLDAFCLLLEK MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x75C1400", Offset = "0x75C0800", VA = "0x1875C1400", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x75BFCA0", Offset = "0x75BF0A0", VA = "0x1875BFCA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x75BFC60", Offset = "0x75BF060", VA = "0x1875BFC60")]
		public BLIJPKDDPCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x75BFC10", Offset = "0x75BF010", VA = "0x1875BFC10", Slot = "14")]
		public override PDOOMAJLGEG GetValue(KLDAFCLLLEK MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x75BFC30", Offset = "0x75BF030", VA = "0x1875BFC30", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x75C1040", Offset = "0x75C0440", VA = "0x1875C1040", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x75C1000", Offset = "0x75C0400", VA = "0x1875C1000")]
		public HNBFDILMHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x75C0FB0", Offset = "0x75C03B0", VA = "0x1875C0FB0", Slot = "14")]
		public override Delegate GetValue(KLDAFCLLLEK MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x75C0FD0", Offset = "0x75C03D0", VA = "0x1875C0FD0", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x75BF750", Offset = "0x75BEB50", VA = "0x1875BF750", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x75BF710", Offset = "0x75BEB10", VA = "0x1875BF710")]
		public AACJEFICDOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x75BF6C0", Offset = "0x75BEAC0", VA = "0x1875BF6C0", Slot = "14")]
		public override Delegate GetValue(KLDAFCLLLEK MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x75BF6E0", Offset = "0x75BEAE0", VA = "0x1875BF6E0", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x75C11B0", Offset = "0x75C05B0", VA = "0x1875C11B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x75C1170", Offset = "0x75C0570", VA = "0x1875C1170")]
		public IGJMAOCCCJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x75C1120", Offset = "0x75C0520", VA = "0x1875C1120", Slot = "14")]
		public override EFMCPKJOHAF<Delegate> GetValue(KLDAFCLLLEK MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x75C1140", Offset = "0x75C0540", VA = "0x1875C1140", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x75C04B0", Offset = "0x75BF8B0", VA = "0x1875C04B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x75C0470", Offset = "0x75BF870", VA = "0x1875C0470")]
		public FBKKNDNELON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x75C0420", Offset = "0x75BF820", VA = "0x1875C0420", Slot = "14")]
		public override EFMCPKJOHAF<Delegate> GetValue(KLDAFCLLLEK MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x75C0440", Offset = "0x75BF840", VA = "0x1875C0440", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x75C2250", Offset = "0x75C1650", VA = "0x1875C2250", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x75C2210", Offset = "0x75C1610", VA = "0x1875C2210")]
		public PMJOLFJIPCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x75C21C0", Offset = "0x75C15C0", VA = "0x1875C21C0", Slot = "14")]
		public override EFMCPKJOHAF<Delegate> GetValue(KLDAFCLLLEK MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x75C21E0", Offset = "0x75C15E0", VA = "0x1875C21E0", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x75C0570", Offset = "0x75BF970", VA = "0x1875C0570", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x75C0530", Offset = "0x75BF930", VA = "0x1875C0530")]
		public FHKKBOIGGKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x75C04E0", Offset = "0x75BF8E0", VA = "0x1875C04E0", Slot = "14")]
		public override EFMCPKJOHAF<Delegate> GetValue(KLDAFCLLLEK MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x75C0500", Offset = "0x75BF900", VA = "0x1875C0500", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x75C01B0", Offset = "0x75BF5B0", VA = "0x1875C01B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x75C0170", Offset = "0x75BF570", VA = "0x1875C0170")]
		public CGGJMAKJMII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x75C0120", Offset = "0x75BF520", VA = "0x1875C0120", Slot = "14")]
		public override EFMCPKJOHAF<Delegate> GetValue(KLDAFCLLLEK MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x75C0140", Offset = "0x75BF540", VA = "0x1875C0140", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x75C1D60", Offset = "0x75C1160", VA = "0x1875C1D60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x75C1D20", Offset = "0x75C1120", VA = "0x1875C1D20")]
		public NNCHMNEANLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x75C1CD0", Offset = "0x75C10D0", VA = "0x1875C1CD0", Slot = "14")]
		public override EFMCPKJOHAF<Delegate> GetValue(KLDAFCLLLEK MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x75C1CF0", Offset = "0x75C10F0", VA = "0x1875C1CF0", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x75BFAE0", Offset = "0x75BEEE0", VA = "0x1875BFAE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x75BFAA0", Offset = "0x75BEEA0", VA = "0x1875BFAA0")]
		public AODMIKBEBLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x75BFA50", Offset = "0x75BEE50", VA = "0x1875BFA50", Slot = "14")]
		public override EFMCPKJOHAF<Delegate> GetValue(KLDAFCLLLEK MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x75BFA70", Offset = "0x75BEE70", VA = "0x1875BFA70", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x75C13B0", Offset = "0x75C07B0", VA = "0x1875C13B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x75C1370", Offset = "0x75C0770", VA = "0x1875C1370")]
		public INJJMIOPGFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x75C1320", Offset = "0x75C0720", VA = "0x1875C1320", Slot = "14")]
		public override EFMCPKJOHAF<Delegate> GetValue(KLDAFCLLLEK MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x75C1340", Offset = "0x75C0740", VA = "0x1875C1340", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x75C2040", Offset = "0x75C1440", VA = "0x1875C2040", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x75C2000", Offset = "0x75C1400", VA = "0x1875C2000")]
		public PJPCHHIKDBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x75C1FB0", Offset = "0x75C13B0", VA = "0x1875C1FB0", Slot = "14")]
		public override EFMCPKJOHAF<Delegate> GetValue(KLDAFCLLLEK MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x75C1FD0", Offset = "0x75C13D0", VA = "0x1875C1FD0", Slot = "15")]
		public override void SetValue(KLDAFCLLLEK MGOKPJKELJG, EFMCPKJOHAF<Delegate> KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x75C05A0", Offset = "0x75BF9A0", VA = "0x1875C05A0")]
	public GFMCDLMABDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class LIGHLJBJMDK : ContainerPropertyBag<EFMCPKJOHAF<Delegate>>
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x75C1760", Offset = "0x75C0B60", VA = "0x1875C1760")]
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
			[Cpp2IlInjected.Address(RVA = "0x75C03F0", Offset = "0x75BF7F0", VA = "0x1875C03F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x75C03B0", Offset = "0x75BF7B0", VA = "0x1875C03B0")]
		public ENKAPDLPPKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x75BFB20", Offset = "0x75BEF20", VA = "0x1875BFB20", Slot = "14")]
		public override Rigidbody GetValue(ADJMKBFDFGN MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x75BFB40", Offset = "0x75BEF40", VA = "0x1875BFB40", Slot = "15")]
		public override void SetValue(ADJMKBFDFGN MGOKPJKELJG, Rigidbody KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x75BFCD0", Offset = "0x75BF0D0", VA = "0x1875BFCD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x75C1AB0", Offset = "0x75C0EB0", VA = "0x1875C1AB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x75C1A70", Offset = "0x75C0E70", VA = "0x1875C1A70")]
		public MNGBHEBFOPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x75BFB20", Offset = "0x75BEF20", VA = "0x1875BFB20", Slot = "14")]
		public override object GetValue(OPHLPNFIFPI MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x75BFB40", Offset = "0x75BEF40", VA = "0x1875BFB40", Slot = "15")]
		public override void SetValue(OPHLPNFIFPI MGOKPJKELJG, object KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x75C2280", Offset = "0x75C1680", VA = "0x1875C2280")]
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
			[Cpp2IlInjected.Address(RVA = "0x75C1A00", Offset = "0x75C0E00", VA = "0x1875C1A00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x75C19C0", Offset = "0x75C0DC0", VA = "0x1875C19C0")]
		public MEKHCJPIIIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x75BFB20", Offset = "0x75BEF20", VA = "0x1875BFB20", Slot = "14")]
		public override object GetValue(EJJBOIOFAKC MGOKPJKELJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x75BFB40", Offset = "0x75BEF40", VA = "0x1875BFB40", Slot = "15")]
		public override void SetValue(EJJBOIOFAKC MGOKPJKELJG, object KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x75C20E0", Offset = "0x75C14E0", VA = "0x1875C20E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x75C1F80", Offset = "0x75C1380", VA = "0x1875C1F80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x75C1F40", Offset = "0x75C1340", VA = "0x1875C1F40")]
		public PDOIEEHFJIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xCF8D90", Offset = "0xCF8190", VA = "0x180CF8D90", Slot = "14")]
		public override Entity GetValue(JLBMIHMPFAN MGOKPJKELJG)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x75C1F30", Offset = "0x75C1330", VA = "0x1875C1F30", Slot = "15")]
		public override void SetValue(JLBMIHMPFAN MGOKPJKELJG, Entity KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x75C1B90", Offset = "0x75C0F90", VA = "0x1875C1B90")]
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
			[Cpp2IlInjected.Address(RVA = "0x75C0220", Offset = "0x75BF620", VA = "0x1875C0220", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x75C01E0", Offset = "0x75BF5E0", VA = "0x1875C01E0")]
		public DHEJKLOOEDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1EF61A0", Offset = "0x1EF55A0", VA = "0x181EF61A0", Slot = "14")]
		public override int GetValue(Entity MGOKPJKELJG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x73FE830", Offset = "0x73FDC30", VA = "0x1873FE830", Slot = "15")]
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
			[Cpp2IlInjected.Address(RVA = "0x75C0D40", Offset = "0x75C0140", VA = "0x1875C0D40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool NJEEMOHCODN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x75C0D00", Offset = "0x75C0100", VA = "0x1875C0D00")]
		public HIBEHIGMNMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x75C0CE0", Offset = "0x75C00E0", VA = "0x1875C0CE0", Slot = "14")]
		public override int GetValue(Entity MGOKPJKELJG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x75C0CF0", Offset = "0x75C00F0", VA = "0x1875C0CF0", Slot = "15")]
		public override void SetValue(Entity MGOKPJKELJG, int KBGCCIOIGBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x75C1870", Offset = "0x75C0C70", VA = "0x1875C1870")]
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
		[Cpp2IlInjected.Address(RVA = "0x75C2360", Offset = "0x75C1760", VA = "0x1875C2360")]
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
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
