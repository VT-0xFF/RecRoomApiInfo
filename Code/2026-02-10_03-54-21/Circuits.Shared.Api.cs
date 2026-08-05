using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Circuits.Shared.Api.Protobuf;
using Circuits.Shared.RecRoom.Protobuf;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures.Performance;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x28F62B0", Offset = "0x28F54B0", VA = "0x1828F62B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAE0A40", Offset = "0xADFC40", VA = "0x180AE0A40")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAE0A80", Offset = "0xADFC80", VA = "0x180AE0A80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Shared.Api
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public readonly struct CircuitsColor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly float R;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly float G;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly float B;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly float A;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly CircuitsColor Black;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static readonly CircuitsColor White;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x28F35B0", Offset = "0x28F27B0", VA = "0x1828F35B0")]
		public CircuitsColor(float r, float g, float b, float a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public readonly struct CircuitsMtx4x4 : IEquatable<CircuitsMtx4x4>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly float Value00;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly float Value10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly float Value20;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly float Value30;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly float Value01;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly float Value11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly float Value21;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly float Value31;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly float Value02;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly float Value12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly float Value22;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly float Value32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly float Value03;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly float Value13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly float Value23;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly float Value33;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly CircuitsMtx4x4 Zero;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly CircuitsMtx4x4 Identity;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28F4280", Offset = "0x28F3480", VA = "0x1828F4280")]
		public CircuitsMtx4x4(float value00, float value10, float value20, float value30, float value01, float value11, float value21, float value31, float value02, float value12, float value22, float value32, float value03, float value13, float value23, float value33)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x28F3860", Offset = "0x28F2A60", VA = "0x1828F3860")]
		public static bool QEDRWBLLCYQ([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28F3700", Offset = "0x28F2900", VA = "0x1828F3700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x28F3630", Offset = "0x28F2830", VA = "0x1828F3630", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x28F3970", Offset = "0x28F2B70", VA = "0x1828F3970", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x28F35D0", Offset = "0x28F27D0", VA = "0x1828F35D0", Slot = "4")]
		public bool Equals(CircuitsMtx4x4 other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public readonly struct CircuitsQuat : IEquatable<CircuitsQuat>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly float X;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public readonly float Y;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly float Z;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly float W;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly CircuitsQuat Identity;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public static readonly CircuitsQuat FullNaN;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public static readonly CircuitsQuat UnitX;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static readonly CircuitsQuat UnitY;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public static readonly CircuitsQuat UnitZ;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28F35B0", Offset = "0x28F27B0", VA = "0x1828F35B0")]
		public CircuitsQuat(float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28F45B0", Offset = "0x28F37B0", VA = "0x1828F45B0")]
		public static CircuitsQuat New(float x, float y, float z, float w)
		{
			return default(CircuitsQuat);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28F45D0", Offset = "0x28F37D0", VA = "0x1828F45D0")]
		public static bool QEDRWBLLCYQ([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28F4330", Offset = "0x28F3530", VA = "0x1828F4330")]
		public static bool EPOGIYJSRBR([In] CircuitsQuat lhs, [In] CircuitsQuat rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28F4550", Offset = "0x28F3750", VA = "0x1828F4550", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28F43C0", Offset = "0x28F35C0", VA = "0x1828F43C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28F4610", Offset = "0x28F3810", VA = "0x1828F4610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x28F4660", Offset = "0x28F3860", VA = "0x1828F4660")]
		public string UFZUMNHAJBK(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28F44C0", Offset = "0x28F36C0", VA = "0x1828F44C0", Slot = "4")]
		public bool Equals(CircuitsQuat other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class ZVRWULXWADG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x28F6520", Offset = "0x28F5720", VA = "0x1828F6520")]
		public static DSFMADQBQHN JNXWDCMOQDE([In] this CircuitsQuat self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28F6330", Offset = "0x28F5530", VA = "0x1828F6330")]
		public static CircuitsQuat EEHEZYYMZRF(this DSFMADQBQHN a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28F65A0", Offset = "0x28F57A0", VA = "0x1828F65A0")]
		public static DSFMADQBQHN? TPJDNWSNEYX([In] this CircuitsQuat? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28F6400", Offset = "0x28F5600", VA = "0x1828F6400")]
		public static CircuitsQuat? GMPMWUXKZDI(this DSFMADQBQHN? a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public readonly struct CircuitsRigidTransform : IEquatable<CircuitsRigidTransform>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly CircuitsQuat Rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly CircuitsVec3 Position;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public static readonly CircuitsRigidTransform Identity;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x28F4DB0", Offset = "0x28F3FB0", VA = "0x1828F4DB0")]
		public CircuitsRigidTransform([In] CircuitsQuat rotation, [In] CircuitsVec3 position)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x28F4B90", Offset = "0x28F3D90", VA = "0x1828F4B90")]
		public static bool QEDRWBLLCYQ([In] CircuitsRigidTransform lhs, [In] CircuitsRigidTransform rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28F4A90", Offset = "0x28F3C90", VA = "0x1828F4A90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x28F49D0", Offset = "0x28F3BD0", VA = "0x1828F49D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x28F4C70", Offset = "0x28F3E70", VA = "0x1828F4C70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x28F4970", Offset = "0x28F3B70", VA = "0x1828F4970", Slot = "4")]
		public bool Equals(CircuitsRigidTransform other)
		{
			return default(bool);
		}
	}
	[StructLayout((LayoutKind)0, Size = 12)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct CircuitsVec3 : IEquatable<CircuitsVec3>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly float X;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public readonly float Y;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public readonly float Z;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public static readonly CircuitsVec3 Zero;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public static readonly CircuitsVec3 One;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static readonly CircuitsVec3 FullNaN;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public static readonly CircuitsVec3 UnitX;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly CircuitsVec3 UnitY;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public static readonly CircuitsVec3 UnitZ;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly CircuitsVec3 UnitNegativeX;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly CircuitsVec3 UnitNegativeY;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static readonly CircuitsVec3 UnitNegativeZ;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public static readonly CircuitsVec3 Max;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly CircuitsVec3 MaxX;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly CircuitsVec3 MaxY;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly CircuitsVec3 MaxZ;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public static readonly CircuitsVec3 Min;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly CircuitsVec3 MinX;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly CircuitsVec3 MinY;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly CircuitsVec3 MinZ;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x28F5860", Offset = "0x28F4A60", VA = "0x1828F5860")]
		public CircuitsVec3(float x, float y, float z)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x28F50D0", Offset = "0x28F42D0", VA = "0x1828F50D0")]
		public static CircuitsVec3 New(float x, float y, float z)
		{
			return default(CircuitsVec3);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x28F50F0", Offset = "0x28F42F0", VA = "0x1828F50F0")]
		public static bool QEDRWBLLCYQ([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x28F4EB0", Offset = "0x28F40B0", VA = "0x1828F4EB0")]
		public static bool EPOGIYJSRBR([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x28F5380", Offset = "0x28F4580", VA = "0x1828F5380")]
		public static CircuitsVec3 WCQABLCORSM([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x28F4DD0", Offset = "0x28F3FD0", VA = "0x1828F4DD0")]
		public static CircuitsVec3 DHFLFQHETUS([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs)
		{
			return default(CircuitsVec3);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x28F5530", Offset = "0x28F4730", VA = "0x1828F5530")]
		public static CircuitsVec3 ZUYQDJMYCXG([In] CircuitsVec3 lhs, [In] float rhs)
		{
			return default(CircuitsVec3);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x28F5460", Offset = "0x28F4660", VA = "0x1828F5460")]
		public static CircuitsVec3 YQNJTSQZOPR([In] CircuitsVec3 lhs, [In] float rhs)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x28F5080", Offset = "0x28F4280", VA = "0x1828F5080", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x28F4F30", Offset = "0x28F4130", VA = "0x1828F4F30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x28F5120", Offset = "0x28F4320", VA = "0x1828F5120", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x28F5170", Offset = "0x28F4370", VA = "0x1828F5170")]
		public string UFZUMNHAJBK(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x28F5000", Offset = "0x28F4200", VA = "0x1828F5000", Slot = "4")]
		public bool Equals(CircuitsVec3 other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class JRRXRCWWJVK
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x28F5D30", Offset = "0x28F4F30", VA = "0x1828F5D30")]
		public static RGKRTJUIFTV JNXWDCMOQDE([In] this CircuitsVec3 self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x28F5BC0", Offset = "0x28F4DC0", VA = "0x1828F5BC0")]
		public static CircuitsVec3 EEHEZYYMZRF(this RGKRTJUIFTV a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x28F5DA0", Offset = "0x28F4FA0", VA = "0x1828F5DA0")]
		public static RGKRTJUIFTV? TPJDNWSNEYX([In] this CircuitsVec3? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x28F5C60", Offset = "0x28F4E60", VA = "0x1828F5C60")]
		public static CircuitsVec3? GMPMWUXKZDI(this RGKRTJUIFTV? a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface VWEUPIINCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		VWEUPIINCCP OKPCUYKBBPF(string a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		VWEUPIINCCP ZXIOQXNMDHY(string a, string[] b);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		VWEUPIINCCP CTGZSSWCFOC();

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void QIOJAOPXSKN();
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface FTTHWDAOFXU
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		VWEUPIINCCP MGYFTFTIGOX(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface ITZIBLWYZOO
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool? OLNNBCXKKBS(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public readonly struct Id128<TMarker> : IEquatable<Id128<TMarker>>, YTDJCTQVIZN<Id128<TMarker>>, IComparable<Id128<TMarker>> where TMarker : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly Guid Guid;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static Id128<TMarker> WGTQXNAIYNL
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x5013FE0", Offset = "0x50131E0", VA = "0x185013FE0")]
			get
			{
				return default(Id128<TMarker>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x12C54D0", Offset = "0x12C46D0", VA = "0x1812C54D0")]
		public Id128([In] Guid value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x50142E0", Offset = "0x50134E0", VA = "0x1850142E0")]
		public static Id128<TMarker> GCDQOSPLEXN()
		{
			return default(Id128<TMarker>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5014730", Offset = "0x5013930", VA = "0x185014730")]
		public static Id128<TMarker> KLTANLKNPMZ(string a)
		{
			return default(Id128<TMarker>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5014410", Offset = "0x5013610", VA = "0x185014410")]
		public HKJJHOGMRLI? JNXWDCMOQDE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x50148D0", Offset = "0x5013AD0", VA = "0x1850148D0")]
		public HKJJHOGMRLI SQLEJWJCUWG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5014DB0", Offset = "0x5013FB0", VA = "0x185014DB0")]
		public bool VNLJEVZERES([In] Id128<TMarker> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5014210", Offset = "0x5013410", VA = "0x185014210", Slot = "4")]
		public bool Equals(Id128<TMarker> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x50141D0", Offset = "0x50133D0", VA = "0x1850141D0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5013FB0", Offset = "0x50131B0", VA = "0x185013FB0", Slot = "6")]
		public int CompareTo(Id128<TMarker> other)
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5014210", Offset = "0x5013410", VA = "0x185014210")]
		public static bool QEDRWBLLCYQ([In] Id128<TMarker> left, [In] Id128<TMarker> right)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5014100", Offset = "0x5013300", VA = "0x185014100")]
		public static bool EPOGIYJSRBR([In] Id128<TMarker> left, [In] Id128<TMarker> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x50143F0", Offset = "0x50135F0", VA = "0x1850143F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5014CD0", Offset = "0x5013ED0", VA = "0x185014CD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5014210", Offset = "0x5013410", VA = "0x185014210", Slot = "5")]
		private bool SMIBRVKNYNK([In] Id128<TMarker> other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class KHGKTAHMCMK
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x38053D0", Offset = "0x38045D0", VA = "0x1838053D0")]
		public static Id128<a?> EEHEZYYMZRF<a>(this HKJJHOGMRLI? a)
		{
			return default(Id128<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x38051E0", Offset = "0x38043E0", VA = "0x1838051E0")]
		public static Id128<TMarker> DRDDYJOKEJX<TMarker>(this HKJJHOGMRLI a) where TMarker : notnull
		{
			return default(Id128<TMarker>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x38054E0", Offset = "0x38046E0", VA = "0x1838054E0")]
		public static Id128<b?> ZWBTDBMBUAJ<b>([In] this Guid self)
		{
			return default(Id128<b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class HPPYTDORPDU<b>
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		internal static readonly Id128<b> WGTQXNAIYNL;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		internal static readonly Id128<b>? QAWNJGQQTPX;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct Id32<TMarker> : IEquatable<Id32<TMarker>>, YTDJCTQVIZN<Id32<TMarker>>, IComparable<Id32<TMarker>> where TMarker : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly int Int32;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Id32<TMarker> TOHBEKNYDVH
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5015480", Offset = "0x5014680", VA = "0x185015480")]
			get
			{
				return default(Id32<TMarker>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Id32<TMarker> AKUDICRAFEV
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x50153D0", Offset = "0x50145D0", VA = "0x1850153D0")]
			get
			{
				return default(Id32<TMarker>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1354390", Offset = "0x1353590", VA = "0x181354390")]
		public Id32(int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x36821D0", Offset = "0x36813D0", VA = "0x1836821D0")]
		public Id32<a> BTBYARHDKDJ<a>() where a : TMarker
		{
			return default(Id32<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xCF6C10", Offset = "0xCF5E10", VA = "0x180CF6C10")]
		public int JNXWDCMOQDE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x50159E0", Offset = "0x5014BE0", VA = "0x1850159E0")]
		public bool VNLJEVZERES([In] Id32<TMarker> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5015250", Offset = "0x5014450", VA = "0x185015250", Slot = "4")]
		public bool Equals(Id32<TMarker> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5015390", Offset = "0x5014590", VA = "0x185015390", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2117560", Offset = "0x2116760", VA = "0x182117560", Slot = "6")]
		public int CompareTo(Id32<TMarker> other)
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x50155F0", Offset = "0x50147F0", VA = "0x1850155F0")]
		public static bool QEDRWBLLCYQ(Id32<TMarker> left, Id32<TMarker> right)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5015190", Offset = "0x5014390", VA = "0x185015190")]
		public static bool EPOGIYJSRBR(Id32<TMarker> left, Id32<TMarker> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x13ACD60", Offset = "0x13ABF60", VA = "0x1813ACD60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5015910", Offset = "0x5014B10", VA = "0x185015910", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5015770", Offset = "0x5014970", VA = "0x185015770")]
		public string QVMCCLGKGTF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x50155B0", Offset = "0x50147B0", VA = "0x1850155B0", Slot = "5")]
		private bool MFBSUBOVBOC([In] Id32<TMarker> other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class YJCSTEBIRAY
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xE542C0", Offset = "0xE534C0", VA = "0x180E542C0")]
		public static Id32<a?> ZWBTDBMBUAJ<a>(this int a)
		{
			return default(Id32<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xE542C0", Offset = "0xE534C0", VA = "0x180E542C0")]
		public static Id32<b?> YOBJANUEWUP<b>(this int a)
		{
			return default(Id32<b>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3C516B0", Offset = "0x3C508B0", VA = "0x183C516B0")]
		public static CopyEnumerable<Id32<c?>, Id32RangeEnumerator<c?>> AAOKLSNKPPP<c>(Id32<c> startInclusive, Id32<c> endExclusive)
		{
			return default(CopyEnumerable<Id32<c>, Id32RangeEnumerator<c>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x3C51790", Offset = "0x3C50990", VA = "0x183C51790")]
		public static CopyEnumerable<Id32<d?>, Id32RangeEnumerator<d?>> KMDZNYIVQWT<d>(this Id32<d> endExclusive)
		{
			return default(CopyEnumerable<Id32<d>, Id32RangeEnumerator<d>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x3C51840", Offset = "0x3C50A40", VA = "0x183C51840")]
		public static Id32<TMarker?> Offset<TMarker>(this Id32<TMarker> self, int offset)
		{
			return default(Id32<TMarker>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class ARGETWHFUPO<b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x304F3F0", Offset = "0x304E5F0", VA = "0x18304F3F0")]
		public static Id32<b> IRFJRIEMLLI<a>(Id32<a> self) where a : b
		{
			return default(Id32<b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct Id32Enumerator<M> : IEnumerator<Id32<M>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly int _count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private int _current;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public readonly Id32<M> Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5014ED0", Offset = "0x50140D0", VA = "0x185014ED0", Slot = "4")]
			get
			{
				return default(Id32<M>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private readonly object CVJXXTOQWTE
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x5014DE0", Offset = "0x5013FE0", VA = "0x185014DE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xC3E560", Offset = "0xC3D760", VA = "0x180C3E560")]
		private Id32Enumerator(int count, int current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5014EA0", Offset = "0x50140A0", VA = "0x185014EA0")]
		public static Id32Enumerator<M> YGWMVFWLGMD(int a)
		{
			return default(Id32Enumerator<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5014E80", Offset = "0x5014080", VA = "0x185014E80", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5014E90", Offset = "0x5014090", VA = "0x185014E90", Slot = "8")]
		public void Reset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class GDJTUDROZLM
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3726BB0", Offset = "0x3725DB0", VA = "0x183726BB0")]
		public static Id32Enumerator<a?> FPDIIFVAHWK<a>(Id32<a> afterLast)
		{
			return default(Id32Enumerator<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct Id32RangeEnumerator<M> : IEnumerator<Id32<M>>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly int _startExclusive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly int _endExclusive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private int _current;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public readonly Id32<M> Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x5015150", Offset = "0x5014350", VA = "0x185015150", Slot = "4")]
			get
			{
				return default(Id32<M>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private readonly object CVJXXTOQWTE
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x5014F80", Offset = "0x5014180", VA = "0x185014F80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xC3F6E0", Offset = "0xC3E8E0", VA = "0x180C3F6E0")]
		internal Id32RangeEnumerator(int startExclusive, int endExclusive, int current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "5")]
		public readonly void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x50150C0", Offset = "0x50142C0", VA = "0x1850150C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x50150D0", Offset = "0x50142D0", VA = "0x1850150D0", Slot = "8")]
		public void Reset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class ZOJFPAGYVHZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3C5EE30", Offset = "0x3C5E030", VA = "0x183C5EE30")]
		public static Id32RangeEnumerator<M?> New<M>(Id32<M> startInclusive, Id32<M> endExclusive)
		{
			return default(Id32RangeEnumerator<M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3C5ED50", Offset = "0x3C5DF50", VA = "0x183C5ED50")]
		public static CopyEnumerable<Id32<a?>, Id32RangeEnumerator<a?>> NVKSCPJIMRW<a>(Id32<a> startInclusive, Id32<a> endExclusive)
		{
			return default(CopyEnumerable<Id32<a>, Id32RangeEnumerator<a>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public readonly struct IdArray<M, T> where M : notnull where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		internal readonly T[] _array;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Id32<M> QIOJAOPXSKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x5016410", Offset = "0x5015610", VA = "0x185016410")]
			get
			{
				return default(Id32<M>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int EMFZFZKJVBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x28FF7A0", Offset = "0x28FE9A0", VA = "0x1828FF7A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public T this[Id32<M> id]
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x340B5E0", Offset = "0x340A7E0", VA = "0x18340B5E0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xC504D0", Offset = "0xC4F6D0", VA = "0x180C504D0")]
		internal IdArray(T[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5016110", Offset = "0x5015310", VA = "0x185016110")]
		public static IdArray<M, T> New(int length)
		{
			return default(IdArray<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x50159F0", Offset = "0x5014BF0", VA = "0x1850159F0")]
		public static IdArray<M, T> Empty()
		{
			return default(IdArray<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xC504B0", Offset = "0xC4F6B0", VA = "0x180C504B0")]
		public IEnumerable<T> ZUGJPDASHSW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5015EC0", Offset = "0x50150C0", VA = "0x185015EC0")]
		public IdSpan<M, T> KAJHXSAHOLX()
		{
			return default(IdSpan<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5016350", Offset = "0x5015550", VA = "0x185016350")]
		public ReadOnlyIdArray<M, T> VGAQOYGYDQQ()
		{
			return default(ReadOnlyIdArray<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5015B70", Offset = "0x5014D70", VA = "0x185015B70")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5016190", Offset = "0x5015390", VA = "0x185016190", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class PSEHCOYKMZT<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x35C2060", Offset = "0x35C1260", VA = "0x1835C2060")]
		public static IdArray<a, T> QBTOLJPRCBP<T>(params T[] array) where T : notnull
		{
			return default(IdArray<a, T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class BLYOFKVVYRY
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x340B3C0", Offset = "0x340A5C0", VA = "0x18340B3C0")]
		public static b? EXSGEPXZHSG<b, a>(this IdArray<a, b> self, Id32<a> i)
		{
			return (b?)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x340B5E0", Offset = "0x340A7E0", VA = "0x18340B5E0")]
		public static d? XNICNFCHVJY<d, c>(this IdArray<c, d> self, Id32<c> i)
		{
			return (d?)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x340B500", Offset = "0x340A700", VA = "0x18340B500")]
		public static void Set<M, T>(this IdArray<M, T> self, Id32<M> i, [In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x340B2B0", Offset = "0x340A4B0", VA = "0x18340B2B0")]
		public static void DEFBSOHTDJE<i, j>(this IdArray<i, j> self, Id32<i> i, j value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[DefaultMember("Item")]
	public ref struct IdSpan<M, T> where M : notnull where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal readonly Span<T> _span;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x12C54D0", Offset = "0x12C46D0", VA = "0x1812C54D0")]
		internal IdSpan([In] Span<T> span)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x105B030", Offset = "0x105A230", VA = "0x18105B030")]
		public readonly Span<T> BGKSLDQWSUU()
		{
			return default(Span<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5017560", Offset = "0x5016760", VA = "0x185017560")]
		public readonly ReadOnlyIdSpan<M, T> UQJOUKLQKVR()
		{
			return default(ReadOnlyIdSpan<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5017180", Offset = "0x5016380", VA = "0x185017180", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public static class UPNQRYVYKWW<c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x35E8240", Offset = "0x35E7440", VA = "0x1835E8240")]
		public static IdSpan<c?, b?> CZKOHBXCEUU<b>([In] Span<b> span)
		{
			return default(IdSpan<c, b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class MDBGJBRPLAR
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x383D390", Offset = "0x383C590", VA = "0x18383D390")]
		public static void Set<M, T>([In] this IdSpan<M, T> self, Id32<M> i, [In] T value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface IOOLZJQPNCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		float OFQAJSAEIYX([In] float value, [In] int decimals);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		float ZUEVOKFRFYJ([In] float value, [In] int decimals);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		CircuitsColor HETZKSLSVRM([In] CircuitsColor a, [In] CircuitsColor b, float a);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		float XAMDDBFKGBW([In] CircuitsColor a, [In] CircuitsColor b, [In] CircuitsColor c);

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		CircuitsVec3 ZGPIBUWAEOI([In] CircuitsMtx4x4 self);

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		CircuitsQuat QNDIXUHLRWR([In] CircuitsMtx4x4 self);

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		CircuitsMtx4x4 ECEFFXHLPXJ([In] CircuitsMtx4x4 self);

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "7")]
		CircuitsMtx4x4 GCNZNNBFRKF([In] CircuitsMtx4x4 lhs, [In] CircuitsMtx4x4 rhs);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "8")]
		CircuitsMtx4x4 MOHQUHXKBOB([In] CircuitsRigidTransform self);

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "9")]
		float SDSLDNHWPGG([In] CircuitsQuat lhs, [In] CircuitsQuat rhs);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "10")]
		CircuitsQuat AMESUDSJASP(float a, [In] CircuitsVec3 axis);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "11")]
		CircuitsQuat WQVCAWJTFBW([In] CircuitsVec3 euler);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "12")]
		CircuitsQuat QMXYRKSZNLK([In] CircuitsVec3 fromDirection, [In] CircuitsVec3 toDirection);

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "13")]
		CircuitsQuat HCVLATMSIKO([In] CircuitsVec3 forward, [In] CircuitsVec3 upwards);

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "14")]
		CircuitsQuat HHKTSCLYEHP([In] CircuitsQuat self);

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "15")]
		CircuitsQuat GDIDEOGPWUC([In] CircuitsQuat a, [In] CircuitsQuat b, float a);

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "16")]
		CircuitsQuat GGNTYTDKOTD([In] CircuitsQuat a, [In] CircuitsQuat b, float a);

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		float EQRJLGNCKQA([In] CircuitsQuat a, [In] CircuitsQuat b, [In] CircuitsQuat c);

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		CircuitsQuat ILZVALDMLEH([In] CircuitsQuat lhs, [In] CircuitsQuat rhs);

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		CircuitsQuat PZKSPRCALRI([In] CircuitsQuat self);

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		CircuitsQuat IWVWPAXDNSM([In] CircuitsQuat from, [In] CircuitsQuat to, float a);

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		CircuitsVec3 KEUNXETWSDJ([In] CircuitsQuat self, [In] CircuitsVec3 vector);

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "22")]
		CircuitsQuat LBGGAYYCAXD([In] CircuitsQuat a, [In] CircuitsQuat b, float a);

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void BHUEIXTSQDW([In] CircuitsQuat self, [Out] float a, [Out] CircuitsVec3 b);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "24")]
		CircuitsVec3 SBTXFIMXFLN([In] CircuitsQuat self);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "25")]
		CircuitsVec3 NWZJBUTOTDQ([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "26")]
		CircuitsVec3 QXAMPEKEPIE([In] CircuitsVec3 self, float a);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "27")]
		CircuitsVec3 IRYLEAOIKQF([In] CircuitsVec3 position, [In] CircuitsVec3 planePosition, [In] CircuitsVec3 planeNormal);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "28")]
		CircuitsVec3 ONZKRDNOWKR([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "29")]
		CircuitsVec3 UVVMEBAUTLH([In] CircuitsVec3 localPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation);

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "30")]
		CircuitsVec3 WXXHIGMVYFV([In] CircuitsVec3 worldPoint, [In] CircuitsVec3 worldOrigin, [In] CircuitsQuat worldOrientation);

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "31")]
		float HDSPLYFBOOO([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs);

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "32")]
		float BXDVLVHVVXE([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs);

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "33")]
		float QFFMRCLQRND([In] CircuitsVec3 self);

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "34")]
		CircuitsVec3 GXVUSNUEAFE([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a);

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "35")]
		CircuitsVec3 SDQPFZTZRVP([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a);

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "36")]
		float BQAOCTFTQGY([In] CircuitsVec3 a, [In] CircuitsVec3 b, [In] CircuitsVec3 c);

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "37")]
		CircuitsVec3 MRDXKCJMVBQ([In] CircuitsVec3 current, [In] CircuitsVec3 target, float a);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "38")]
		CircuitsVec3 LTKSYQCXZYR([In] CircuitsVec3 self);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "39")]
		CircuitsVec3 ZDFFBTANBWS([In] CircuitsVec3 self);

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "40")]
		CircuitsVec3 BBYHPEEVOGQ([In] CircuitsVec3 self, [In] CircuitsVec3 onNormal);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "41")]
		CircuitsVec3 QWBRHAQHUYN([In] CircuitsVec3 self, [In] CircuitsVec3 planeNormal);

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "42")]
		CircuitsVec3 VVCNZVFFGTR([In] CircuitsVec3 self, float a);

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "43")]
		CircuitsVec3 EZJWBEHHQAD([In] CircuitsVec3 current, [In] CircuitsVec3 target, [In] CircuitsVec3 currentVelocity, float a, float b, float c, [Out] CircuitsVec3 d);

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "44")]
		CircuitsVec3 XOHQRBIWGBJ([In] CircuitsVec3 lhs, [In] CircuitsVec3 rhs);

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "45")]
		CircuitsVec3 XTTUIOPVKDP([In] CircuitsVec3 a, [In] CircuitsVec3 b, float a);

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "46")]
		Task CTTELQUAWRD(Func<Task> a);

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "47")]
		void WHXMTZURQNX([Optional] string? a);

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "48")]
		MVSDGWXZBFC<IWSAOBCGBQA> PLOTQJWGBTT();

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "49")]
		MVSDGWXZBFC<IWSAOBCGBQA> LPBKTYGHTMQ();

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "50")]
		float FFJPCJMJDVQ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public static class JMIRENYHWDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x28F5870", Offset = "0x28F4A70", VA = "0x1828F5870")]
		public static CircuitsRigidTransform VYXAYBAPEEK(this IOOLZJQPNCL a, [In] CircuitsRigidTransform rigidTransform, [In] CircuitsMtx4x4 transform)
		{
			return default(CircuitsRigidTransform);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public enum IOKind
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		Input,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		Output
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface RTBCXHUIOQG
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		bool OMOMCSXCLPG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface XCDISBFUVBP
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		RTBCXHUIOQG SWUNRXFXXLH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class EDCAZKPLXSQ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3626960", Offset = "0x3625B60", VA = "0x183626960")]
		public static bool CBIFDOUAVXK<TSelf>(this TSelf a) where TSelf : notnull, XCDISBFUVBP
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct LogDeps
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly LogDelegates Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Obsolete("Code using LogFlags.Debug should not be checked in!")]
		public readonly LogDelegates Debug;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly LogDelegates CircuitsV2CloudData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly LogDelegates CircuitsV2DebugLogNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly LogDelegates CircuitsV2Environments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly LogDelegates CircuitsV2EventBus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly LogDelegates CircuitsV2Graph;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly LogDelegates CircuitsV2Heat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly LogDelegates CircuitsV2Memory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly LogDelegates CircuitsV2RecRoomIntegration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public readonly LogDelegates CircuitsV2Reduce;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly LogDelegates CircuitsV2Root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public readonly LogDelegates CircuitsV2State;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly LogDelegates CircuitsV2CloudDataOrMemory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public readonly LogDelegates DefaultOrCircuitsV2DebugLogNode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly LogDelegates CircuitsV2Stopwatches;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public readonly LogDelegates CircuitsV2VerboseStopwatches;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x28F5E60", Offset = "0x28F5060", VA = "0x1828F5E60")]
		public LogDeps([In] LogDelegates @default, [In] LogDelegates debug, [In] LogDelegates circuitsV2CloudData, [In] LogDelegates circuitsV2DebugLogNode, [In] LogDelegates circuitsV2Environments, [In] LogDelegates circuitsV2EventBus, [In] LogDelegates circuitsV2Graph, [In] LogDelegates circuitsV2Heat, [In] LogDelegates circuitsV2Memory, [In] LogDelegates circuitsV2RecRoomIntegration, [In] LogDelegates circuitsV2Reduce, [In] LogDelegates circuitsV2Root, [In] LogDelegates circuitsV2State, [In] LogDelegates circuitsV2CloudDataOrMemory, [In] LogDelegates defaultOrCircuitsV2DebugLogNode, [In] LogDelegates circuitsV2Stopwatches, [In] LogDelegates circuitsV2VerboseStopwatches)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class WBUFIROFFZC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class FDGPVGVZFUQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class SFAPMBZNZYR
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class MVLILCSWAQD<a>
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class OTRYTJZBOPP
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public sealed class FQPBODQMINB
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public readonly struct ReadOnlyIdArray<M, T> where M : notnull where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly ReadOnlyArray<T> _array;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Id32<M> QIOJAOPXSKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x5E6A3E0", Offset = "0x5E695E0", VA = "0x185E6A3E0")]
			get
			{
				return default(Id32<M>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int EMFZFZKJVBK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x5E69840", Offset = "0x5E68A40", VA = "0x185E69840")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public T this[Id32<M> id]
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x5E6A580", Offset = "0x5E69780", VA = "0x185E6A580")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x28B1F70", Offset = "0x28B1170", VA = "0x1828B1F70")]
		internal ReadOnlyIdArray(ReadOnlyArray<T> array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5E695E0", Offset = "0x5E687E0", VA = "0x185E695E0")]
		public static ReadOnlyIdArray<M, T> Empty()
		{
			return default(ReadOnlyIdArray<M, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3D640D0", Offset = "0x3D632D0", VA = "0x183D640D0")]
		public IEnumerable<T> ZUGJPDASHSW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xC504B0", Offset = "0xC4F6B0", VA = "0x180C504B0")]
		public ReadOnlyArray<T> MHZEYSCKNRV()
		{
			return default(ReadOnlyArray<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5E694F0", Offset = "0x5E686F0", VA = "0x185E694F0")]
		public ReadOnlySpan<T> CZLFOFDRATM()
		{
			return default(ReadOnlySpan<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5E69970", Offset = "0x5E68B70", VA = "0x185E69970")]
		public bool LIMFTPMMRBH(Id32<M> id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5E69880", Offset = "0x5E68A80", VA = "0x185E69880")]
		public ConstEnumerable<T, ReadOnlyArray<T>.Enumerator> KSDITDALMHX()
		{
			return default(ConstEnumerable<T, ReadOnlyArray<T>.Enumerator>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5E69780", Offset = "0x5E68980", VA = "0x185E69780")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5E69D10", Offset = "0x5E68F10", VA = "0x185E69D10")]
		public T? NJEICNFLLMR(Id32<M> id)
		{
			return (T?)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5E6A320", Offset = "0x5E69520", VA = "0x185E6A320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class VJDGXAXWBJR<b>
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3CAE680", Offset = "0x3CAD880", VA = "0x183CAE680")]
		public static ReadOnlyIdArray<b, T> QBTOLJPRCBP<T>(params T[] array) where T : notnull
		{
			return default(ReadOnlyIdArray<b, T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3755070", Offset = "0x3754270", VA = "0x183755070")]
		public static ReadOnlyIdArray<b?, a?> KMJJKTFOEFJ<a>(ReadOnlyArray<a> readOnlyArray)
		{
			return default(ReadOnlyIdArray<b, a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public ref struct ReadOnlyIdSpan<M, T> where M : notnull where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly ReadOnlySpan<T> _readOnlySpan;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public readonly T this[Id32<M> id]
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x5E6A9B0", Offset = "0x5E69BB0", VA = "0x185E6A9B0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x12C54D0", Offset = "0x12C46D0", VA = "0x1812C54D0")]
		internal ReadOnlyIdSpan([In] ReadOnlySpan<T> readOnlySpan)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5E6A800", Offset = "0x5E69A00", VA = "0x185E6A800", Slot = "3")]
		public override readonly string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class FFBIGPXERSY<f>
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x35E8240", Offset = "0x35E7440", VA = "0x1835E8240")]
		public static ReadOnlyIdSpan<f?, d?> NGQKGESPWVY<d>([In] ReadOnlySpan<d> readOnlySpan)
		{
			return default(ReadOnlyIdSpan<f, d>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x35E8130", Offset = "0x35E7330", VA = "0x1835E8130")]
		public static ReadOnlyIdSpan<f?, e?> CZKOHBXCEUU<e>([In] Span<e> span)
		{
			return default(ReadOnlyIdSpan<f, e>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public enum RoomVersion : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		V1,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		V2
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
